using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using DevExpress.Data.Utils;
using DevExpress.Data.Utils.Security;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
#if WPF
using DevExpress.Xpf.Core;
using PivotGridDemo.Controls;
using System.Windows;
using System.Windows.Input;
#endif

#if WPF
namespace PivotGridDemo.PivotGrid.Helpers {
#else
namespace DevExpress.XtraPivotGrid.Demos.Helpers {
#endif
    public delegate void UpdateProgressCallback(int percents);
    public delegate void DatabaseGeneratedCallback();
    public delegate void DataSetFilledCallback(DataSet dataSet);
    //
    public static class DatabaseHelper {
        readonly static NonCryptographicRandom random = NonCryptographicRandom.Default;
        readonly static BackgroundWorker worker = new BackgroundWorker();
        static readonly string[] FirstNames = { "Julia", "Stephanie", "Alex", "John", "Curtis", "Keith", "Timothy", "Jack", "Miranda", "Alice" };
        static readonly string[] LastNames = { "Black", "White", "Brown", "Smith", "Cooper", "Parker", "Walker", "Hunter", "Burton", "Douglas", "Fox", "Simpson" };
        static readonly string[] Adjectives = { "Ancient", "Modern", "Mysterious", "Elegant", "Red", "Green", "Blue", "Amazing", "Wonderful", "Astonishing", "Lovely", "Beautiful", "Inexpensive", "Famous", "Magnificent", "Fancy" };
        static readonly string[] ProductNames = { "Ice Cubes", "Bicycle", "Desk", "Hamburger", "Notebook", "Tea", "Cellphone", "Butter", "Frying Pan", "Napkin",
                    "Armchair", "Chocolate", "Yoghurt", "Statuette", "Keychain" };
        static readonly string[] CategoryNames = { "Business", "Presents", "Accessories", "Home", "Hobby" };
        //
        static DatabaseHelper() {
            worker.DoWork += GenerateDatabaseAsyncCore;
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
        }
        public static bool IsGenerating {
            get { return worker.IsBusy; }
        }
        public static void GenerateDatabaseAsync(int rowsCount,
            UpdateProgressCallback updateProgressCallback, DatabaseGeneratedCallback databaseGeneratedCallback) {
            worker.ProgressChanged += (s, e) => updateProgressCallback(e.ProgressPercentage);
            worker.RunWorkerCompleted += (s, e) => databaseGeneratedCallback();
            worker.RunWorkerAsync(rowsCount);
        }
        public static void CancelDatabaseGenerationAsync() {
            worker.CancelAsync();
        }
        static void GenerateDatabaseAsyncCore(object sender, DoWorkEventArgs e) {
            worker.ReportProgress(0);
            int rowsCount = (int)e.Argument;
            int rowsRemaining = rowsCount;
            using(UnitOfWork uow = new UnitOfWork()) {
                try {
                    uow.ClearDatabase();
                }
                catch { }
                int salesPersonCount = random.Next(40, 50);
                int customersCount = random.Next(40, 50);
                int productsCount = random.Next(80, 100);
                List<string> peopleNames = GeneratePeopleNames(salesPersonCount + customersCount);
                List<string> fullProductNames = GenerateProductNames(productsCount);
                int indexPersonName = 0;

                XPCollection<SalesPerson> salesPeople = new XPCollection<SalesPerson>(uow);
                for(int i = 0; i < salesPersonCount; i++) {
                    salesPeople.Add(new SalesPerson(uow, peopleNames[indexPersonName]));
                    indexPersonName++;
                }
                XPCollection<Customer> customers = new XPCollection<Customer>(uow);
                for(int i = 0; i < customersCount; i++) {
                    customers.Add(new Customer(uow, peopleNames[indexPersonName]));
                    indexPersonName++;
                }
                XPCollection<Category> categories = new XPCollection<Category>(uow);
                for(int i = 0; i < CategoryNames.Length; i++)
                    categories.Add(new Category(uow, CategoryNames[i]));
                XPCollection<Product> products = new XPCollection<Product>(uow);
                for(int i = 0; i < productsCount; i++)
                    products.Add(new Product(uow, fullProductNames[i], categories[random.Next(categories.Count)], random.Next(500)));

                do {
                    for(int k = 0; k < 300; k++) {
                        Order order = new Order(uow, salesPeople[random.Next(salesPeople.Count)], customers[random.Next(customers.Count)], GetDate());
                        int salesCount = rowsRemaining >= 5 ? random.Next(1, 6) : rowsRemaining;
                        for(int j = 0; j < salesCount; j++) {
                            Product product = products[random.Next(products.Count)];
                            new Sale(uow, order, product, random.Next(1, 100), GetProductPrice(product));
                            rowsRemaining--;
                        }
                    }
                    uow.CommitChanges();
                    worker.ReportProgress(rowsCount - rowsRemaining);
                }
                while(!worker.CancellationPending && rowsRemaining > 0);
                uow.FlushChanges();
            }
        }
        static List<string> GeneratePeopleNames(int count) {
            HashSet<string> names = new HashSet<string>(count);
            while(names.Count < count)
                names.Add(GeneratePeopleName());
            return names.ToList();
        }
        static List<string> GenerateProductNames(int count) {
            HashSet<string> names = new HashSet<string>(count);
            while(names.Count < count)
                names.Add(GenerateProductName());
            return names.ToList();
        }
        static string GeneratePeopleName() {
            return FirstNames[random.Next(FirstNames.Length)] + " " + LastNames[random.Next(LastNames.Length)];
        }
        static string GenerateProductName() {
            return Adjectives[random.Next(Adjectives.Length)] + " " + ProductNames[random.Next(ProductNames.Length)];
        }
        static decimal GetProductPrice(Product product) {
            return product.Price * (decimal)(0.5 + random.NextDouble());
        }
        static DateTime GetDate() {
            return new DateTime(random.Next(2007, 2015), random.Next(1, 13), random.Next(1, 28));
        }
        public static PivotGridDemoDBEntities GetContext() {
            PivotGridDemoDBEntities context = new PivotGridDemoDBEntities(ServerParameters.GetDBConnectionString());
            bool databaseOK = false;
            try {
                databaseOK = context.Database.Exists();
            }
            finally {
                if(!databaseOK) {
                    if(context != null)
                        context.Dispose();
                    context = null;
                }
            }
            return context;
        }
        public static int CalculateRecordCount() {
            bool isConnectionFailed = false;
            using(SqlConnection connection = SQLConnectionHelper.GetConnection(ServerParameters.GetDBConnectionString())) {
                if(connection == null)
                    isConnectionFailed = true;
                else {
#pragma warning disable DX0024 
                    using(SqlCommand command = new SqlCommand("select count(OID) as count from [dbo].[Sales]", connection))
                        return (int)command.ExecuteScalar();
#pragma warning restore DX0024 
                }
            }
            if(isConnectionFailed) {
                if(SQLConnectionHelper.IsConnectionCorrect(ServerParameters.GetServerConnectionString()))
                    return 0;
            }
            return -1;
        }
        public static bool CreateDataLayer() {
            if(!SQLConnectionHelper.IsConnectionCorrect(ServerParameters.GetServerConnectionString()))
                return false;
            IDataStore store;
            try {
                store = XpoDefault.GetConnectionProvider(ServerParameters.GetDBConnectionString(), AutoCreateOption.DatabaseAndSchema);
            }
            catch {
                return false;
            }
            XpoDefault.DataLayer = new SimpleDataLayer(store);
            return true;
        }
    }

    public class ServerParameters {
        #region Singleton
#if WPF
        public //enables binding to static properties
#endif
        ServerParameters() { }
        static ServerParameters fInstance;
        static ServerParameters Instance {
            get {
                if(fInstance == null)
                    fInstance = new ServerParameters();
                return fInstance;
            }
        }
        #endregion
        const string ServerParametersFileName = "PivotGridSQLParameters.xml";
        string fServer = DbEngineDetector.GetSqlServerInstanceName();
        string fLogin = "sa";
        readonly SensitiveData passwordData = SensitiveData.CreateForCurrentUser();
        bool fUseWindowsAuthentication = true;
        public static string DBName {
            get { return "PivotGridDemoDB"; }
        }
        public static string Server {
            get { return Instance.fServer; }
            set { Instance.fServer = value; }
        }
        public static string Login {
            get { return Instance.fLogin; }
            set { Instance.fLogin = value; }
        }
        public static string Password {
            get { return Instance.passwordData.Text; }
            set { Instance.passwordData.Text = value; }
        }
        public static bool UseWindowsAuthentication {
            get { return Instance.fUseWindowsAuthentication; }
            set { Instance.fUseWindowsAuthentication = value; }
        }
        public static void LoadParameters() {
            if(!File.Exists(ServerParametersFileName))
                return;
            try {
                string xmlContent = File.ReadAllText(ServerParametersFileName);
                XmlDocument doc = SafeXml.CreateDocument(xmlContent);
                if(doc.DocumentElement.Name == "Parameters") {
                    string[] parameters = doc.DocumentElement.InnerText.Split(new char[] { ';' });
                    Server = parameters[0];
                    UseWindowsAuthentication = Convert.ToBoolean(parameters[1]);
                    Login = parameters[2];
                }
            }
            catch { }
        }
        public static void SaveParameters() {
            try {
                using(XmlTextWriter writer = new XmlTextWriter(ServerParametersFileName, Encoding.UTF8))
                    writer.WriteElementString("Parameters", string.Format("{0};{1};{2}", Server, UseWindowsAuthentication, Login));
            }
            catch { }
        }
        public static string GetServerConnectionString() {
            if(UseWindowsAuthentication)
                return string.Format("data source={0};integrated security=SSPI;connect timeout=10", Server);
            return string.Format("data source={0};user id={1};password={2};connect timeout=10", Server, Login, Password);
        }
        public static string GetDBConnectionString() {
            return string.Format("{0};initial catalog={1}", GetServerConnectionString(), DBName);
        }
    }

    #region XPOs
    [Persistent("SalesPeople")]
    public class SalesPerson : XPObject {
        string fName;
        public SalesPerson(Session session)
            : base(session) { }
        public SalesPerson(Session session, string name)
            : this(session) {
            Name = name;
        }
        [Persistent("SalesPersonName")]
        public string Name { get { return fName; } set { SetPropertyValue("Name", ref fName, value); } }
        [Association("SalesPeople-Orders")]
        public XPCollection<Order> Orders { get { return GetCollection<Order>("Orders"); } }
    }
    [Persistent("Customers")]
    public class Customer : XPObject {
        string fName;
        public Customer(Session session)
            : base(session) { }
        public Customer(Session session, string name)
            : this(session) {
            Name = name;
        }
        [Persistent("CustomerName")]
        public string Name { get { return fName; } set { SetPropertyValue("Name", ref fName, value); } }
        [Association("Customers-Orders")]
        public XPCollection<Order> Orders { get { return GetCollection<Order>("Orders"); } }
    }
    [Persistent("Orders")]
    public class Order : XPObject {
        SalesPerson fSalesPerson;
        Customer fCustomer;
        DateTime fDate;
        public Order(Session session)
            : base(session) { }
        public Order(Session session, SalesPerson salesPerson, Customer customer, DateTime date)
            : this(session) {
            SalesPerson = salesPerson;
            Customer = customer;
            Date = date;
            salesPerson.Orders.Add(this);
            customer.Orders.Add(this);
        }
        [Association("SalesPeople-Orders")]
        public SalesPerson SalesPerson { get { return fSalesPerson; } set { SetPropertyValue("SalesPerson", ref fSalesPerson, value); } }
        [Association("Customers-Orders")]
        public Customer Customer { get { return fCustomer; } set { SetPropertyValue("Customer", ref fCustomer, value); } }
        [Association("Orders-Sales")]
        public XPCollection<Sale> Sales { get { return GetCollection<Sale>("Sales"); } }
        [Persistent("OrderDate"), Indexed]
        public DateTime Date { get { return fDate; } set { SetPropertyValue("Date", ref fDate, value); } }
    }
    [Persistent("Categories")]
    public class Category : XPObject {
        string fName;
        public Category(Session session)
            : base(session) { }
        public Category(Session session, string name)
            : this(session) {
            Name = name;
        }
        [Persistent("CategoryName")]
        public string Name { get { return fName; } set { SetPropertyValue("Name", ref fName, value); } }
        [Association("Category-Products")]
        public XPCollection<Product> Products { get { return GetCollection<Product>("Products"); } }
    }
    [Persistent("Products")]
    public class Product : XPObject {
        string fName;
        Category fCategory;
        decimal fPrice;
        public Product(Session session)
            : base(session) { }
        public Product(Session session, string name, Category category, decimal price)
            : this(session) {
            Name = name;
            this.Category = category;
            this.Category.Products.Add(this);
            Price = price;
        }
        [Persistent("ProductName")]
        public string Name { get { return fName; } set { SetPropertyValue("Name", ref fName, value); } }
        [Association("Category-Products")]
        public Category Category { get { return fCategory; } set { SetPropertyValue("Category", ref fCategory, value); } }
        [Association("Product-Sales")]
        public XPCollection<Sale> Sales { get { return GetCollection<Sale>("Sales"); } }
        [NonPersistent]
        public decimal Price { get { return fPrice; } set { fPrice = value; } }
    }
    [Persistent("Sales")]
    public class Sale : XPObject {
        Order fOrder;
        Product fProduct;
        int fQuantity;
        decimal fUnitPrice;
        public Sale(Session session)
            : base(session) { }
        public Sale(Session session, Order order, Product product, int quantity, decimal unitPrice)
            : this(session) {
            Order = order;
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
            order.Sales.Add(this);
            product.Sales.Add(this);
        }
        [Association("Orders-Sales")]
        public Order Order { get { return fOrder; } set { SetPropertyValue("Order", ref fOrder, value); } }
        [Association("Product-Sales")]
        public Product Product { get { return fProduct; } set { SetPropertyValue("Product", ref fProduct, value); } }
        [Persistent("Quantity")]
        public int Quantity { get { return fQuantity; } set { SetPropertyValue("Quantity", ref fQuantity, value); } }
        [Persistent("UnitPrice")]
        public decimal UnitPrice { get { return fUnitPrice; } set { SetPropertyValue("UnitPrice", ref fUnitPrice, value); } }
    }
    #endregion
}
