using DevExpress.DemoData.Models.Mapping;
using DevExpress.Internal;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.SQLite;
using System.IO;
using System.Linq;


namespace DevExpress.DemoData {
    using Models;
    using System.Linq;

    public abstract class DataLoaderBase {
        protected void LoadIfNeed(ref bool checkFlag, IQueryable target) {
            if(!checkFlag) {
                target.Load();
                checkFlag = true;
            }
        }
    }

    public class NWindDataLoader : DataLoaderBase {
        NWindContext context;
        public NWindDataLoader() {
            if(!ViewModelBase.IsInDesignMode)
                context = NWindContext.Create();
        }
        public object Invoices {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<Invoice>();
                return context.Invoices.OrderBy(i => i.OrderID).ToList();
            }
        }
        public object ObservableInvoices {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<Invoice>();
                return new System.Collections.ObjectModel.ObservableCollection<Invoice>(context.Invoices.OrderBy(i => i.OrderID));
            }
        }
        public object ObservableInvoices200 {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<Invoice>();
                return new System.Collections.ObjectModel.ObservableCollection<Invoice>(context.Invoices.Take(200).OrderBy(i => i.OrderID));
            }
        }
        public object Customers {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<Customer>();
                context.Customers.Load();
                return context.Customers.Local;
            }
        }
        public object Employees {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<Employee>();
                context.Employees.Load();
                return context.Employees.Local;
            }
        }
        public object SalesPersons {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<SalesPerson>();
                context.SalesPersons.Load();
                return context.SalesPersons.Local;
            }
        }
        public object EmployeesWithOrdersAndOrderDetails {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<Employee>();
                context.Employees.Include(x => x.Orders.Select(y => y.OrderDetails)).Load();
                return context.Employees.Local;
            }
        }
        public object Products {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<Product>();
                context.Products.Load();
                return context.Products.Local;
            }
        }
        public object Categories {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<Category>();
                context.Categories.Load();
                return context.Categories.Local;
            }
        }
        public object OrderDetails {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<OrderDetail>();
                context.OrderDetails.Load();
                return context.OrderDetails.Local;
            }
        }
        public object OrderDetailsExtended {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<OrderDetailsExtended>();
                context.OrderDetailsExtended.Load();
                return context.OrderDetailsExtended.Local;
            }
        }
        public object Orders {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<Order>();
                context.Orders.Load();
                return context.Orders.Local;
            }
        }
        public static List<string> Titles {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<string>();
                return NWindContext.Create().Employees.Select(e => e.Title).Distinct().ToList();
            }
        }
        public static string[] Countries {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new string[0];
                return NWindContext.Create().CountriesArray;
            }
        }
        public object ProductReports {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<ProductReport>();
                context.ProductReports.Load();
                return context.ProductReports.Local;
            }
        }
        public object OrderReports {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<OrderReport>();
                context.OrderReports.Load();
                return context.OrderReports.Local;
            }
        }
        public object CustomerReports {
            get {
                if(ViewModelBase.IsInDesignMode)
                    return new List<CustomerReport>();
                context.CustomerReports.Load();
                return context.CustomerReports.Local;
            }
        }
    }
    public static class NWindDataProvider {
        public static IList<Employee> Employees {
            get { return (IList<Employee>)new NWindDataLoader().Employees; }
        }
        public static IList<Customer> Customers {
            get { return (IList<Customer>)new NWindDataLoader().Customers; }
        }
        public static IList<Invoice> Invoices {
            get { return (IList<Invoice>)new NWindDataLoader().Invoices; }
        }
        public static IList<Invoice> InvoicesUpToDate {
            get {
                var invoices = Invoices;
                var correction = (DateTime.Today - invoices.Select(x => x.OrderDate).Max()).Value.Days;
                foreach(var invoice in invoices) {
                    invoice.OrderDate = invoice.OrderDate.Value.AddDays(correction);
                }
                return invoices;
            }
        }
        public static IList<Product> Products {
            get { return (IList<Product>)new NWindDataLoader().Products; }
        }
        public static IList<SalesPerson> SalesPersons {
            get { return (IList<SalesPerson>)new NWindDataLoader().SalesPersons; }
        }
        public static IList<ProductReport> ProductReports {
            get { return (IList<ProductReport>)new NWindDataLoader().ProductReports; }
        }
        public static IList<OrderReport> OrderReports {
            get { return (IList<OrderReport>)new NWindDataLoader().OrderReports; }
        }
        public static IList<CustomerReport> CustomerReports {
            get { return (IList<CustomerReport>)new NWindDataLoader().CustomerReports; }
        }
        public static System.Collections.ObjectModel.ObservableCollection<Invoice> ObservableInvoices200 {
            get { return (System.Collections.ObjectModel.ObservableCollection<Invoice>)new NWindDataLoader().ObservableInvoices200; }
        }
    }
}

// NWindContext.cs

namespace DevExpress.DemoData.Models {
    static class DbContextPreloader<T> where T : DbContext, new() {
        static System.Threading.Tasks.Task task;
        static DbContextPreloader() {
            Action action = null;
            if(ViewModelBase.IsInDesignMode) {
                action = () => { };
            } else {
                action = () => {
                    var context = new T();
                    var prop = typeof(T).GetProperties()
                        .Where(p => p.PropertyType.IsGenericType &&
                                    p.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
                        .FirstOrDefault();
                    if(prop == null)
                        return;
                    var query = (IQueryable<object>)prop.GetValue(context, null);
                    query.Count();
                };
            }
            task = new System.Threading.Tasks.TaskFactory().StartNew(action);
        }
        public static System.Threading.Tasks.Task Preload() {
            return task;
        }
    }

    public partial class NWindContext : DbContext {
        public NWindContext() : base(CreateConnection(), true) { }
        public NWindContext(string connectionString) : base(connectionString) { }
        public NWindContext(DbConnection connection) : base(connection, true) { }
        
        static NWindContext() {
            Database.SetInitializer<NWindContext>(null);
        }

        static string filePath;
        static DbConnection CreateConnection() {
            if(filePath == null)
                filePath = DataDirectoryHelper.GetFile("nwind.db", DataDirectoryHelper.DataFolderName);
            try {
                var attributes = File.GetAttributes(filePath);
                if(attributes.HasFlag(FileAttributes.ReadOnly)) {
                    File.SetAttributes(filePath, attributes & ~FileAttributes.ReadOnly);
                }
            } catch { }
            var connection = DbProviderFactories.GetFactory("System.Data.SQLite.EF6").CreateConnection();
            connection.ConnectionString = new SQLiteConnectionStringBuilder { DataSource = filePath }.ConnectionString;
            return connection;
        }

        public override int SaveChanges() {
            throw new Exception("Readonly context");
        }

        public static System.Threading.Tasks.Task Preload() {
            return DbContextPreloader<NWindContext>.Preload();
        }

        public static NWindContext Create() {
            Preload().Wait();
            return new NWindContext();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }
        public DbSet<CategoryProduct> CategoryProducts { get; set; }
        public DbSet<CurrentProductList> CurrentProductLists { get; set; }
        public DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }
        public DbSet<CustomerReport> CustomerReports { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<OrderDetailsExtended> OrderDetailsExtended { get; set; }
        public DbSet<OrderReport> OrderReports { get; set; }
        public DbSet<OrdersQry> OrdersQries { get; set; }
        public DbSet<OrderSubtotal> OrderSubtotals { get; set; }
        public DbSet<ProductReport> ProductReports { get; set; }
        public DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }
        public DbSet<ProductsByCategory> ProductsByCategories { get; set; }
        public DbSet<SalesByCategory> SalesByCategories { get; set; }
        public DbSet<SalesPerson> SalesPersons { get; set; }
        public DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; }
        public DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; }
        public DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new EmployeeTerritoryMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new ShipperMap());
            modelBuilder.Configurations.Add(new SupplierMap());
            modelBuilder.Configurations.Add(new TerritoryMap());
            modelBuilder.Configurations.Add(new AlphabeticalListOfProductMap());
            modelBuilder.Configurations.Add(new CategoryProductMap());
            modelBuilder.Configurations.Add(new CurrentProductListMap());
            modelBuilder.Configurations.Add(new CustomerAndSuppliersByCityMap());
            modelBuilder.Configurations.Add(new CustomerReportMap());
            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new OrderDetailsExtendedMap());
            modelBuilder.Configurations.Add(new OrderReportMap());
            modelBuilder.Configurations.Add(new OrdersQryMap());
            modelBuilder.Configurations.Add(new OrderSubtotalMap());
            modelBuilder.Configurations.Add(new ProductReportMap());
            modelBuilder.Configurations.Add(new ProductsAboveAveragePriceMap());
            modelBuilder.Configurations.Add(new ProductsByCategoryMap());
            modelBuilder.Configurations.Add(new SalesByCategoryMap());
            modelBuilder.Configurations.Add(new SalesPersonMap());
            modelBuilder.Configurations.Add(new SalesTotalsByAmountMap());
            modelBuilder.Configurations.Add(new SummaryOfSalesByQuarterMap());
            modelBuilder.Configurations.Add(new SummaryOfSalesByYearMap());
        }
        
        public string[] CountriesArray = new[] { "United States", "Afghanistan", "Albania", "Algeria", "Andorra", "Angola",
            "Anguilla", "Antarctica", "Antigua & Barbuda", "Argentina", "Armenia", "Aruba (neth.)", "Australia", "Austria", "Azerbaijan", "Azores (port.)", "Bahamas",
            "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", "Bosnia And Herzegovina", "Botswana", "Brazil",
            "British Virgin Islands", "Brunei Darussalam", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Cayman Islands", "Central African Republic",
            "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Cook Islands", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic",
            "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Fiji", "Finland", "Fmr Yug Rep Macedonia", "France", "French Guiana", "French Polynesia",
            "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea Bissau", "Guyana", "Haiti", "Honduras", "Hong Kong",
            "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Iraq-Saudi Arabia Neutral Zone", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati",
            "Korea Dem.People's Rep.", "Korea, Republic Of", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya Arab Jamahiriy", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar",
            "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mexico", "Micronesia, Fed Stat", "Moldova, Republic Of", "Monaco", "Mongolia", "Morocco",
            "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Caledonia", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Niue", "Northern Mariana Islands", "Norway", "Oman", "Pakistan", "Palau Islands",
            "Panama", "Panama Canal Zone", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saint Lucia", "San Marino",
            "Sao Tome & Principe", "Saudi Arabia", "Senegal", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "St.Kitts & Nevis",
            "St.Vinct & Grenadine", "Sudan", "Suriname", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Rep.", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad & Tobago", "Tunisia",
            "Turkey", "Turkmenistan", "Turks And Caicos Islands", "Tuvalu", "U.S. Virgin Islands", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City (Holy See)",
            "Venezuela", "Vietnam", "Western Sahara", "Western Samoa", "Yemen", "Yugoslavia", "Zaire", "Zambia", "Zimbabwe" };
    }
}

// AlphabeticalListOfProduct.cs

namespace DevExpress.DemoData.Models {
    public partial class AlphabeticalListOfProduct
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<long> SupplierID { get; set; }
        public Nullable<long> CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string EAN13 { get; set; }
        public string CategoryName { get; set; }
    }
}

// Category.cs

namespace DevExpress.DemoData.Models {
    public partial class Category
    {
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public byte[] Icon25 { get; set; }
        public byte[] Icon17 { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

// CategoryProduct.cs

namespace DevExpress.DemoData.Models {
    public partial class CategoryProduct
    {
        public long ProductID { get; set; }
        public Nullable<long> SupplierID { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public byte[] Picture { get; set; }
        public string Description { get; set; }
    }
}

// CurrentProductList.cs

namespace DevExpress.DemoData.Models {
    public partial class CurrentProductList
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
    }
}

// Customer.cs

namespace DevExpress.DemoData.Models {
    public partial class Customer
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

// CustomerAndSuppliersByCity.cs

namespace DevExpress.DemoData.Models {
    public partial class CustomerAndSuppliersByCity
    {
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
    }
}

// CustomerReport.cs

namespace DevExpress.DemoData.Models {
    public partial class CustomerReport
    {
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public decimal ProductAmount { get; set; }
    }
}

// Employee.cs

namespace DevExpress.DemoData.Models {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "DXCA003", Justification = "VB Convertion")]
    public partial class Employee : BindableBase
    {
        long _EmployeeID;
        public long EmployeeID { get { return _EmployeeID; } set { SetProperty(ref _EmployeeID, value, "EmployeeID"); } }
        string _LastName;
        public string LastName { get { return _LastName; } set { SetProperty(ref _LastName, value, "LastName"); } }
        string _FirstName;
        public string FirstName { get { return _FirstName; } set { SetProperty(ref _FirstName, value, "FirstName"); } }
        string _Title;
        public string Title { get { return _Title; } set { SetProperty(ref _Title, value, "Title"); } }
        string _TitleOfCourtesy;
        public string TitleOfCourtesy { get { return _TitleOfCourtesy; } set { SetProperty(ref _TitleOfCourtesy, value, "TitleOfCourtesy"); } }
        Nullable<System.DateTime> _BirthDate;
        public Nullable<System.DateTime> BirthDate { get { return _BirthDate; } set { SetProperty(ref _BirthDate, value, "BirthDate"); } }
        Nullable<System.DateTime> _HireDate;
        public Nullable<System.DateTime> HireDate { get { return _HireDate; } set { SetProperty(ref _HireDate, value, "HireDate"); } }
        string _Address;
        public string Address { get { return _Address; } set { SetProperty(ref _Address, value, "Address"); } }
        string _City;
        public string City { get { return _City; } set { SetProperty(ref _City, value, "City"); } }
        string _Region;
        public string Region { get { return _Region; } set { SetProperty(ref _Region, value, "Region"); } }
        string _PostalCode;
        public string PostalCode { get { return _PostalCode; } set { SetProperty(ref _PostalCode, value, "PostalCode"); } }
        string _Country;
        public string Country { get { return _Country; } set { SetProperty(ref _Country, value, "Country"); } }
        string _HomePhone;
        public string HomePhone { get { return _HomePhone; } set { SetProperty(ref _HomePhone, value, "HomePhone"); } }
        string _Extension;
        public string Extension { get { return _Extension; } set { SetProperty(ref _Extension, value, "Extension"); } }
        byte[] _Photo;
        public byte[] Photo { get { return _Photo; } set { SetProperty(ref _Photo, value, "Photo"); } }
        string _Notes;
        public string Notes { get { return _Notes; } set { SetProperty(ref _Notes, value, "Notes"); } }
        Nullable<long> _ReportsTo;
        public Nullable<long> ReportsTo { get { return _ReportsTo; } set { SetProperty(ref _ReportsTo, value, "ReportsTo"); } }
        string _Email;
        public string Email { get { return _Email; } set { SetProperty(ref _Email, value, "Email"); } }
        string _GroupName;
        public string GroupName { get { return _GroupName; } set { SetProperty(ref _GroupName, value, "GroupName"); } }

        string _FullName = null;
        public string FullName {
            get {
                if(_FullName == null)
                    _FullName = String.Format("{0} {1}", FirstName, LastName);
                return _FullName;
            }
        }

        public virtual ICollection<Customer> Customers { get; set; }
		public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual Employee SubEmployee { get; set; }
        public string PageHeader { get { return (FirstName + " " + LastName).ToUpper(); } }
        public string PageContent {
            get {
                return FirstName + " " + LastName + " was born on " + DateToString(BirthDate) + ". Now lives in " +
                    City + ", " + Country + ". " + TitleOfCourtesy + " " + LastName + " holds a position of " + Title + " our " +
                    Region + " deparment, (" + City + " " + Country + "). Joined our company on " + DateToString(HireDate) + ".";
            }
        }
        string DateToString(DateTime? date) {
            if(date == null)
                return null;
            string[] Months = { "January", "February", "Marth", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return date.Value.Day + "th of " + Months[date.Value.Month - 1] + " in " + date.Value.Year;
        }

		IEnumerable<ChartPoint> _ChartSource = null;
        public IEnumerable<ChartPoint> ChartSource {
            get {
                if(_ChartSource == null)
                    CreateChartSource();
                return _ChartSource;
            }
        }

        void CreateChartSource() {
            IEnumerable<ChartPoint> list = (from o in Orders
                                            group o by o.OrderDate into cp
                                            select new ChartPoint() {
                                                ArgumentMember = cp.Key,
                                                Orders = cp.ToList()
                                            }).ToList();
            foreach(ChartPoint cp in list) {
                decimal value = 0;
                foreach(Order order in cp.Orders)
                    foreach(OrderDetailsExtended inv in order.OrderDetails)
                        value += inv.Quantity * inv.UnitPrice;
                cp.ValueMember = (int)value;
            }
            _ChartSource = list;
        }
    }

    public class ChartPoint {
        public DateTime? ArgumentMember { get; internal set; }
        public int ValueMember { get; set; }
        internal IList<Order> Orders { get; set; }
    }
}

// EmployeeTerritory.cs

namespace DevExpress.DemoData.Models {
    public partial class EmployeeTerritory
    {
        public long EmployeeID { get; set; }
        public string TerritoryID { get; set; }
    }
}

// InternationalOrder.cs

namespace DevExpress.DemoData.Models {
    public partial class InternationalOrder
    {
        public long OrderID { get; set; }
        public string CustomsDescription { get; set; }
        public decimal ExciseTax { get; set; }
        public virtual Order Order { get; set; }
    }
}

// Invoice.cs

namespace DevExpress.DemoData.Models {
    public partial class Invoice
    {
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public long OrderID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public string ShipperName { get; set; }
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }
        public Nullable<decimal> Freight { get; set; }
    }
}

// Order.cs

namespace DevExpress.DemoData.Models {
    public partial class Order
    {
        public long OrderID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<long> EmployeeID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public Nullable<long> ShipVia { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }

		public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetailsExtended> OrderDetails { get; set; }
    }
}

// OrderDetail.cs

namespace DevExpress.DemoData.Models {
    public partial class OrderDetail
    {
        public long OrderID { get; set; }
        public long ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }
    }
}

// OrderDetailsExtended.cs

namespace DevExpress.DemoData.Models {
    public partial class OrderDetailsExtended
    {
        public long OrderID { get; set; }
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }
        public decimal ExtendedPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}

// OrderReport.cs

namespace DevExpress.DemoData.Models {
    public partial class OrderReport
    {
        public long OrderID { get; set; }
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }
        public decimal ExtendedPrice { get; set; }
    }
}

// OrdersQry.cs

namespace DevExpress.DemoData.Models {
    public partial class OrdersQry
    {
        public long OrderID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<long> EmployeeID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public Nullable<long> ShipVia { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}

// OrderSubtotal.cs

namespace DevExpress.DemoData.Models {
    public partial class OrderSubtotal
    {
        public long OrderID { get; set; }
    }
}

// PreviousEmployee.cs

namespace DevExpress.DemoData.Models {
    public partial class PreviousEmployee
    {
        public long EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public string PhotoPath { get; set; }
    }
}

// Product.cs

namespace DevExpress.DemoData.Models {
    public partial class Product
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<long> SupplierID { get; set; }
        public Nullable<long> CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string EAN13 { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetailsExtended> OrderDetails { get; set; }
    }
}

// ProductReport.cs

namespace DevExpress.DemoData.Models {
    public partial class ProductReport
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal ProductSales { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
    }
}

// ProductsAboveAveragePrice.cs

namespace DevExpress.DemoData.Models {
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    }
}

// ProductsByCategory.cs

namespace DevExpress.DemoData.Models {
    public partial class ProductsByCategory
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}

// Region.cs

namespace DevExpress.DemoData.Models {
    public partial class Region
    {
        public long RegionID { get; set; }
        public string RegionDescription { get; set; }
    }
}

// SalesByCategory.cs

namespace DevExpress.DemoData.Models {
    public partial class SalesByCategory
    {
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
    }
}

// SalesPerson.cs

namespace DevExpress.DemoData.Models {
    public partial class SalesPerson
    {
        public long OrderID { get; set; }
        public string Country { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public double Discount { get; set; }
        public decimal ExtendedPrice { get; set; }
        public string FullName { get; set; }
    }
}

// SalesTotalsByAmount.cs

namespace DevExpress.DemoData.Models {
    public partial class SalesTotalsByAmount
    {
        public long OrderID { get; set; }
        public string CompanyName { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
    }
}

// Shipper.cs

namespace DevExpress.DemoData.Models {
    public partial class Shipper
    {
        public long ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}

// SummaryOfSalesByQuarter.cs

namespace DevExpress.DemoData.Models {
    public partial class SummaryOfSalesByQuarter
    {
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public long OrderID { get; set; }
    }
}

// SummaryOfSalesByYear.cs

namespace DevExpress.DemoData.Models {
    public partial class SummaryOfSalesByYear
    {
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public long OrderID { get; set; }
    }
}

// Supplier.cs

namespace DevExpress.DemoData.Models {
    public partial class Supplier
    {
        public long SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }
    }
}

// Territory.cs

namespace DevExpress.DemoData.Models {
    public partial class Territory
    {
        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public long RegionID { get; set; }
    }
}

// AlphabeticalListOfProductMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class AlphabeticalListOfProductMap : EntityTypeConfiguration<AlphabeticalListOfProduct>
    {
        public AlphabeticalListOfProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.QuantityPerUnit)
                .HasMaxLength(20);

            this.Property(t => t.EAN13)
                .HasMaxLength(2147483647);

            this.Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("AlphabeticalListOfProducts");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.UnitsInStock).HasColumnName("UnitsInStock");
            this.Property(t => t.UnitsOnOrder).HasColumnName("UnitsOnOrder");
            this.Property(t => t.ReorderLevel).HasColumnName("ReorderLevel");
            this.Property(t => t.Discontinued).HasColumnName("Discontinued");
            this.Property(t => t.EAN13).HasColumnName("EAN13");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
        }
    }
}

// CategoryMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.CategoryID);

            // Properties
            this.Property(t => t.CategoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Description)
                .HasMaxLength(1073741823);

            this.Property(t => t.Picture)
                .HasMaxLength(2147483647);

            // Table & Column Mappings
            this.ToTable("Categories");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Picture).HasColumnName("Picture");
        }
    }
}

// CategoryProductMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class CategoryProductMap : EntityTypeConfiguration<CategoryProduct>
    {
        public CategoryProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Picture)
                .HasMaxLength(2147483647);

            this.Property(t => t.Description)
                .HasMaxLength(1073741823);

            // Table & Column Mappings
            this.ToTable("CategoryProducts");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.Picture).HasColumnName("Picture");
            this.Property(t => t.Description).HasColumnName("Description");
        }
    }
}

// CurrentProductListMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class CurrentProductListMap : EntityTypeConfiguration<CurrentProductList>
    {
        public CurrentProductListMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("CurrentProductList");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
        }
    }
}

// CustomerAndSuppliersByCityMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class CustomerAndSuppliersByCityMap : EntityTypeConfiguration<CustomerAndSuppliersByCity>
    {
        public CustomerAndSuppliersByCityMap()
        {
            // Primary Key
            this.HasKey(t => t.CompanyName);

            // Properties
            this.Property(t => t.City)
                .HasMaxLength(15);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ContactName)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("CustomerAndSuppliersByCity");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
        }
    }
}

// CustomerMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerID);

            // Properties
            this.Property(t => t.CustomerID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ContactName)
                .HasMaxLength(30);

            this.Property(t => t.ContactTitle)
                .HasMaxLength(30);

            this.Property(t => t.Address)
                .HasMaxLength(60);

            this.Property(t => t.City)
                .HasMaxLength(15);

            this.Property(t => t.Region)
                .HasMaxLength(15);

            this.Property(t => t.PostalCode)
                .HasMaxLength(10);

            this.Property(t => t.Country)
                .HasMaxLength(15);

            this.Property(t => t.Phone)
                .HasMaxLength(24);

            this.Property(t => t.Fax)
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("Customers");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.ContactTitle).HasColumnName("ContactTitle");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.HasMany(x => x.Orders)
                .WithOptional(x => x.Customer)
                .HasForeignKey(x => x.CustomerID);
        }
    }
}

// CustomerReportMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class CustomerReportMap : EntityTypeConfiguration<CustomerReport>
    {
        public CustomerReportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductName, t.CompanyName });

            // Properties
            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("CustomerReports");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
        }
    }
}

// EmployeeMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeID);

            // Properties
            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Title)
                .HasMaxLength(30);

            this.Property(t => t.TitleOfCourtesy)
                .HasMaxLength(25);

            this.Property(t => t.Address)
                .HasMaxLength(60);

            this.Property(t => t.City)
                .HasMaxLength(15);

            this.Property(t => t.Region)
                .HasMaxLength(15);

            this.Property(t => t.PostalCode)
                .HasMaxLength(10);

            this.Property(t => t.Country)
                .HasMaxLength(15);

            this.Property(t => t.HomePhone)
                .HasMaxLength(24);

            this.Property(t => t.Extension)
                .HasMaxLength(4);

            this.Property(t => t.Photo)
                .HasMaxLength(2147483647);

            this.Property(t => t.Notes)
                .HasMaxLength(1073741823);

            // Table & Column Mappings
            this.ToTable("Employees");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.TitleOfCourtesy).HasColumnName("TitleOfCourtesy");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.HireDate).HasColumnName("HireDate");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.HomePhone).HasColumnName("HomePhone");
            this.Property(t => t.Extension).HasColumnName("Extension");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.ReportsTo).HasColumnName("ReportsTo");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.HasMany(x => x.Customers)
                .WithMany(x => x.Employees)
                .Map(m => {
                    m.ToTable("EmployeeCustomers");
                    m.MapLeftKey("EmployeeId");
                    m.MapRightKey("CustomerId");
                });
            this.HasMany(x => x.Employees)
                .WithOptional(x => x.SubEmployee)
                .HasForeignKey(x => x.ReportsTo);
            this.HasMany(x => x.Orders)
                .WithOptional(x => x.Employee)
                .HasForeignKey(x => x.EmployeeID);
        }
    }
}

// EmployeeTerritoryMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class EmployeeTerritoryMap : EntityTypeConfiguration<EmployeeTerritory>
    {
        public EmployeeTerritoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EmployeeID, t.TerritoryID });

            // Properties
            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TerritoryID)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("EmployeeTerritories");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.TerritoryID).HasColumnName("TerritoryID");
        }
    }
}

// InvoiceMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class InvoiceMap : EntityTypeConfiguration<Invoice>
    {
        public InvoiceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CustomerName, t.OrderID, t.ShipperName, t.ProductID, t.ProductName, t.UnitPrice, t.Quantity, t.Discount });

            // Properties
            this.Property(t => t.ShipName)
                .HasMaxLength(40);

            this.Property(t => t.ShipAddress)
                .HasMaxLength(60);

            this.Property(t => t.ShipCity)
                .HasMaxLength(15);

            this.Property(t => t.ShipRegion)
                .HasMaxLength(15);

            this.Property(t => t.ShipPostalCode)
                .HasMaxLength(10);

            this.Property(t => t.ShipCountry)
                .HasMaxLength(15);

            this.Property(t => t.CustomerID)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.CustomerName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Address)
                .HasMaxLength(60);

            this.Property(t => t.City)
                .HasMaxLength(15);

            this.Property(t => t.Region)
                .HasMaxLength(15);

            this.Property(t => t.PostalCode)
                .HasMaxLength(10);

            this.Property(t => t.Country)
                .HasMaxLength(15);

            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ShipperName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.UnitPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Quantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Invoices");
            this.Property(t => t.ShipName).HasColumnName("ShipName");
            this.Property(t => t.ShipAddress).HasColumnName("ShipAddress");
            this.Property(t => t.ShipCity).HasColumnName("ShipCity");
            this.Property(t => t.ShipRegion).HasColumnName("ShipRegion");
            this.Property(t => t.ShipPostalCode).HasColumnName("ShipPostalCode");
            this.Property(t => t.ShipCountry).HasColumnName("ShipCountry");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.RequiredDate).HasColumnName("RequiredDate");
            this.Property(t => t.ShippedDate).HasColumnName("ShippedDate");
            this.Property(t => t.ShipperName).HasColumnName("ShipperName");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.Freight).HasColumnName("Freight");
        }
    }
}

// OrderDetailMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderID, t.ProductID, t.UnitPrice, t.Quantity, t.Discount });

            // Properties
            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Quantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrderDetails");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Discount).HasColumnName("Discount");
        }
    }
}

// OrderDetailsExtendedMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class OrderDetailsExtendedMap : EntityTypeConfiguration<OrderDetailsExtended>
    {
        public OrderDetailsExtendedMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderID, t.ProductID, t.ProductName, t.UnitPrice, t.Quantity, t.Discount });

            // Properties
            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.UnitPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Quantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrderDetailsExtended");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Discount).HasColumnName("Discount");
        }
    }
}

// OrderMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderID);

            // Properties
            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CustomerID)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.ShipName)
                .HasMaxLength(40);

            this.Property(t => t.ShipAddress)
                .HasMaxLength(60);

            this.Property(t => t.ShipCity)
                .HasMaxLength(15);

            this.Property(t => t.ShipRegion)
                .HasMaxLength(15);

            this.Property(t => t.ShipPostalCode)
                .HasMaxLength(10);

            this.Property(t => t.ShipCountry)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("Orders");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.RequiredDate).HasColumnName("RequiredDate");
            this.Property(t => t.ShippedDate).HasColumnName("ShippedDate");
            this.Property(t => t.ShipVia).HasColumnName("ShipVia");
            this.Property(t => t.Freight).HasColumnName("Freight");
            this.Property(t => t.ShipName).HasColumnName("ShipName");
            this.Property(t => t.ShipAddress).HasColumnName("ShipAddress");
            this.Property(t => t.ShipCity).HasColumnName("ShipCity");
            this.Property(t => t.ShipRegion).HasColumnName("ShipRegion");
            this.Property(t => t.ShipPostalCode).HasColumnName("ShipPostalCode");
            this.Property(t => t.ShipCountry).HasColumnName("ShipCountry");
            this.HasMany(x => x.OrderDetails)
                .WithRequired(x => x.Order)
                .HasForeignKey(x => x.OrderID);
        }
    }
}

// OrderReportMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class OrderReportMap : EntityTypeConfiguration<OrderReport>
    {
        public OrderReportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderID, t.ProductID, t.ProductName, t.UnitPrice, t.Quantity, t.Discount });

            // Properties
            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.UnitPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Quantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrderReports");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Discount).HasColumnName("Discount");
        }
    }
}

// OrdersQryMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class OrdersQryMap : EntityTypeConfiguration<OrdersQry>
    {
        public OrdersQryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderID, t.CompanyName });

            // Properties
            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CustomerID)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.ShipName)
                .HasMaxLength(40);

            this.Property(t => t.ShipAddress)
                .HasMaxLength(60);

            this.Property(t => t.ShipCity)
                .HasMaxLength(15);

            this.Property(t => t.ShipRegion)
                .HasMaxLength(15);

            this.Property(t => t.ShipPostalCode)
                .HasMaxLength(10);

            this.Property(t => t.ShipCountry)
                .HasMaxLength(15);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Address)
                .HasMaxLength(60);

            this.Property(t => t.City)
                .HasMaxLength(15);

            this.Property(t => t.Region)
                .HasMaxLength(15);

            this.Property(t => t.PostalCode)
                .HasMaxLength(10);

            this.Property(t => t.Country)
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("OrdersQry");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.RequiredDate).HasColumnName("RequiredDate");
            this.Property(t => t.ShippedDate).HasColumnName("ShippedDate");
            this.Property(t => t.ShipVia).HasColumnName("ShipVia");
            this.Property(t => t.Freight).HasColumnName("Freight");
            this.Property(t => t.ShipName).HasColumnName("ShipName");
            this.Property(t => t.ShipAddress).HasColumnName("ShipAddress");
            this.Property(t => t.ShipCity).HasColumnName("ShipCity");
            this.Property(t => t.ShipRegion).HasColumnName("ShipRegion");
            this.Property(t => t.ShipPostalCode).HasColumnName("ShipPostalCode");
            this.Property(t => t.ShipCountry).HasColumnName("ShipCountry");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.Country).HasColumnName("Country");
        }
    }
}

// OrderSubtotalMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class OrderSubtotalMap : EntityTypeConfiguration<OrderSubtotal>
    {
        public OrderSubtotalMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderID);

            // Properties
            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OrderSubtotals");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
        }
    }
}

// PreviousEmployeeMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class PreviousEmployeeMap : EntityTypeConfiguration<PreviousEmployee>
    {
        public PreviousEmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeID);

            // Properties
            this.Property(t => t.EmployeeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Title)
                .HasMaxLength(30);

            this.Property(t => t.TitleOfCourtesy)
                .HasMaxLength(25);

            this.Property(t => t.Address)
                .HasMaxLength(60);

            this.Property(t => t.City)
                .HasMaxLength(15);

            this.Property(t => t.Region)
                .HasMaxLength(15);

            this.Property(t => t.PostalCode)
                .HasMaxLength(10);

            this.Property(t => t.Country)
                .HasMaxLength(15);

            this.Property(t => t.HomePhone)
                .HasMaxLength(24);

            this.Property(t => t.Extension)
                .HasMaxLength(4);

            this.Property(t => t.Photo)
                .HasMaxLength(2147483647);

            this.Property(t => t.Notes)
                .HasMaxLength(2147483647);

            this.Property(t => t.PhotoPath)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("PreviousEmployees");
            this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.TitleOfCourtesy).HasColumnName("TitleOfCourtesy");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.HireDate).HasColumnName("HireDate");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.HomePhone).HasColumnName("HomePhone");
            this.Property(t => t.Extension).HasColumnName("Extension");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.PhotoPath).HasColumnName("PhotoPath");
        }
    }
}

// ProductMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.ProductID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.QuantityPerUnit)
                .HasMaxLength(20);

            this.Property(t => t.EAN13)
                .HasMaxLength(2147483647);

            // Table & Column Mappings
            this.ToTable("Products");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.UnitsInStock).HasColumnName("UnitsInStock");
            this.Property(t => t.UnitsOnOrder).HasColumnName("UnitsOnOrder");
            this.Property(t => t.ReorderLevel).HasColumnName("ReorderLevel");
            this.Property(t => t.Discontinued).HasColumnName("Discontinued");
            this.Property(t => t.EAN13).HasColumnName("EAN13");
            this.HasOptional(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryID);

            this.HasMany(x => x.OrderDetails)
                .WithRequired(x => x.Product)
                .HasForeignKey(x => x.ProductID);

        }
    }
}

// ProductReportMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class ProductReportMap : EntityTypeConfiguration<ProductReport>
    {
        public ProductReportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CategoryName, t.ProductName, t.ShippedDate });

            // Properties
            this.Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("ProductReports");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.ProductSales).HasColumnName("ProductSales");
            this.Property(t => t.ShippedDate).HasColumnName("ShippedDate");
        }
    }
}

// ProductsAboveAveragePriceMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class ProductsAboveAveragePriceMap : EntityTypeConfiguration<ProductsAboveAveragePrice>
    {
        public ProductsAboveAveragePriceMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductName);

            // Properties
            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("ProductsAboveAveragePrice");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
        }
    }
}

// ProductsByCategoryMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class ProductsByCategoryMap : EntityTypeConfiguration<ProductsByCategory>
    {
        public ProductsByCategoryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CategoryName, t.ProductName, t.Discontinued });

            // Properties
            this.Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.QuantityPerUnit)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("ProductsByCategory");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.QuantityPerUnit).HasColumnName("QuantityPerUnit");
            this.Property(t => t.UnitsInStock).HasColumnName("UnitsInStock");
            this.Property(t => t.Discontinued).HasColumnName("Discontinued");
        }
    }
}

// RegionMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionID);

            // Properties
            this.Property(t => t.RegionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RegionDescription)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Region");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.RegionDescription).HasColumnName("RegionDescription");
        }
    }
}

// SalesByCategoryMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class SalesByCategoryMap : EntityTypeConfiguration<SalesByCategory>
    {
        public SalesByCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.CategoryID);

            // Properties
            this.Property(t => t.CategoryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("SalesByCategory");
            this.Property(t => t.CategoryID).HasColumnName("CategoryID");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
        }
    }
}

// SalesPersonMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class SalesPersonMap : EntityTypeConfiguration<SalesPerson>
    {
        public SalesPersonMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderID, t.FirstName, t.LastName, t.ProductName, t.CategoryName, t.UnitPrice, t.Quantity, t.Discount });

            // Properties
            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Country)
                .HasMaxLength(15);

            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.UnitPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Quantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SalesPerson");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.OrderDate).HasColumnName("OrderDate");
            this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Discount).HasColumnName("Discount");
        }
    }
}

// SalesTotalsByAmountMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class SalesTotalsByAmountMap : EntityTypeConfiguration<SalesTotalsByAmount>
    {
        public SalesTotalsByAmountMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderID, t.CompanyName });

            // Properties
            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("SalesTotalsByAmount");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.ShippedDate).HasColumnName("ShippedDate");
        }
    }
}

// ShipperMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class ShipperMap : EntityTypeConfiguration<Shipper>
    {
        public ShipperMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ShipperID, t.CompanyName });

            // Properties
            this.Property(t => t.ShipperID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.Phone)
                .HasMaxLength(24);

            // Table & Column Mappings
            this.ToTable("Shippers");
            this.Property(t => t.ShipperID).HasColumnName("ShipperID");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.Phone).HasColumnName("Phone");
        }
    }
}

// SummaryOfSalesByQuarterMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class SummaryOfSalesByQuarterMap : EntityTypeConfiguration<SummaryOfSalesByQuarter>
    {
        public SummaryOfSalesByQuarterMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderID);

            // Properties
            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SummaryOfSalesByQuarter");
            this.Property(t => t.ShippedDate).HasColumnName("ShippedDate");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
        }
    }
}

// SummaryOfSalesByYearMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class SummaryOfSalesByYearMap : EntityTypeConfiguration<SummaryOfSalesByYear>
    {
        public SummaryOfSalesByYearMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderID);

            // Properties
            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SummaryOfSalesByYear");
            this.Property(t => t.ShippedDate).HasColumnName("ShippedDate");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
        }
    }
}

// SupplierMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class SupplierMap : EntityTypeConfiguration<Supplier>
    {
        public SupplierMap()
        {
            // Primary Key
            this.HasKey(t => t.SupplierID);

            // Properties
            this.Property(t => t.SupplierID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.ContactName)
                .HasMaxLength(30);

            this.Property(t => t.ContactTitle)
                .HasMaxLength(30);

            this.Property(t => t.Address)
                .HasMaxLength(60);

            this.Property(t => t.City)
                .HasMaxLength(15);

            this.Property(t => t.Region)
                .HasMaxLength(15);

            this.Property(t => t.PostalCode)
                .HasMaxLength(10);

            this.Property(t => t.Country)
                .HasMaxLength(15);

            this.Property(t => t.Phone)
                .HasMaxLength(24);

            this.Property(t => t.Fax)
                .HasMaxLength(24);

            this.Property(t => t.HomePage)
                .HasMaxLength(1073741823);

            // Table & Column Mappings
            this.ToTable("Suppliers");
            this.Property(t => t.SupplierID).HasColumnName("SupplierID");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.ContactName).HasColumnName("ContactName");
            this.Property(t => t.ContactTitle).HasColumnName("ContactTitle");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Region).HasColumnName("Region");
            this.Property(t => t.PostalCode).HasColumnName("PostalCode");
            this.Property(t => t.Country).HasColumnName("Country");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.HomePage).HasColumnName("HomePage");
        }
    }
}

// TerritoryMap.cs

namespace DevExpress.DemoData.Models.Mapping {
    public class TerritoryMap : EntityTypeConfiguration<Territory>
    {
        public TerritoryMap()
        {
            // Primary Key
            this.HasKey(t => t.TerritoryID);

            // Properties
            this.Property(t => t.TerritoryID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.TerritoryDescription)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            this.Property(t => t.RegionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Territories");
            this.Property(t => t.TerritoryID).HasColumnName("TerritoryID");
            this.Property(t => t.TerritoryDescription).HasColumnName("TerritoryDescription");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
        }
    }
}

