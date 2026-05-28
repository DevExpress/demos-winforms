using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.Collections;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using DevExpress.Internal;
using DevExpress.Xpo.Demos.Tutorials;

namespace DevExpress.Xpo.Demos {
    public partial class AsyncLoading : DevExpress.Xpo.Demos.TutorialControl {
        UnitOfWork session;
        XPCollection xpcPersons;
        XPCollection xpcProducts;
        XPView xpvPersons;
        XPView xpvProducts;
        IDataLayer dataLayer = new DelayedDataLayer(new SimpleDataLayer(new InMemoryDataStore()));
        public AsyncLoading() {
            InitializeComponent();
            InitData();
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
        public void InitData() {
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if (!string.IsNullOrEmpty(DBFileName)) {
                using (UnitOfWork saveSession = new UnitOfWork(dataLayer)) {
                    InMemoryDataStore dataStore = new InMemoryDataStore(AutoCreateOption.None);
                    dataStore.ReadXml(DBFileName);
                    using (UnitOfWork loadSession = new UnitOfWork(new SimpleDataLayer(dataStore))) {
                        ICollection persons = loadSession.GetObjects(loadSession.Dictionary.GetClassInfo(typeof(Employees)), CriteriaOperator.Parse("Len(FirstName) <= ?", 5), null, 0, false, true);
                        foreach (Employees empl in persons) {
                            Person person = new Person(saveSession);
                            person.FirstName = empl.FirstName;
                            person.LastName = empl.LastName;
                        }
                        ICollection products = loadSession.GetObjects(loadSession.Dictionary.GetClassInfo(typeof(Products)), CriteriaOperator.Parse("UnitPrice <= ?", 10) , null, 0, false, true);
                        foreach (Products prod in products) {
                            Product product= new Product(saveSession);
                            product.ProductName = prod.ProductName;
                            product.Price = prod.UnitPrice;
                        }
                    }
                    saveSession.CommitChanges();
                }
                session = new UnitOfWork(dataLayer);
            }
        }
        public void AddData() {
            string connectionString;
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.mdb");
            if (!string.IsNullOrEmpty(DBFileName)) {
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DBFileName;
                using (UnitOfWork saveSession = new UnitOfWork(dataLayer)) {
                    using (UnitOfWork loadSession = new UnitOfWork(new SimpleDataLayer(XpoDefault.GetConnectionProvider(connectionString, AutoCreateOption.None)))) {
                        ICollection persons = loadSession.GetObjects(loadSession.Dictionary.GetClassInfo(typeof(Employees)), CriteriaOperator.Parse("Len(FirstName) > ?", 5), null, 0, false, true);
                        foreach (Employees empl in persons) {
                            Person person = new Person(saveSession);
                            person.FirstName = empl.FirstName;
                            person.LastName = empl.LastName;
                        }
                        ICollection products = loadSession.GetObjects(loadSession.Dictionary.GetClassInfo(typeof(Products)), CriteriaOperator.Parse("UnitPrice > ?", 10), null, 0, false, true);
                        foreach (Products prod in products) {
                            Product product = new Product(saveSession);
                            product.ProductName = prod.ProductName;
                            product.Price = prod.UnitPrice;
                        }
                    }
                    saveSession.CommitChanges();
                }
            }
        }

        public class Person : XPBaseObject {
            int oid;
            [Key(true)]
            public int Oid { get { return oid; } set { SetPropertyValue(nameof(Oid), ref oid, value); } }
            string firstName;
            public string FirstName { get { return firstName; } set { SetPropertyValue(nameof(FirstName), ref firstName, value); } }
            string lastName;
            public string LastName { get { return lastName; } set { SetPropertyValue(nameof(LastName), ref lastName, value); } }
            public Person(Session session)
                : base(session) {
            }
        }

        public class Product : XPBaseObject {
            int oid;
            [Key(true)]
            public int Oid { get { return oid; } set { SetPropertyValue(nameof(Oid), ref oid, value); } }
            string productName;
            public string ProductName { get { return productName; } set { SetPropertyValue(nameof(ProductName), ref productName, value); } }
            decimal price;
            public decimal Price { get { return price; } set { SetPropertyValue(nameof(Price), ref price, value); } }
            public Product(Session session)
                : base(session) {
            }
        }

        private void gclPersons_Resize(object sender, EventArgs e) {
            lbLoadingPersons.Left = (gclPersons.Width - lbLoadingPersons.Width) / 2;
            lbLoadingPersons.Top = (gclPersons.Height - lbLoadingPersons.Height) / 2;
        }

        private void gclProducts_Resize(object sender, EventArgs e) {
            lbLoadingProducts.Left = (gclProducts.Width - lbLoadingProducts.Width) / 2;
            lbLoadingProducts.Top = (gclProducts.Height - lbLoadingProducts.Height) / 2;
        }
        private void sbLoadData_Click_1(object sender, EventArgs e) {
            if((cbXpView.Checked && xpvPersons == null) || (cbXpView.Checked && xpcPersons == null)) {
                sbAddData.Enabled = true;
            }
            sbLoadData_Click(sender, e);
        }
        private void sbLoadDataXPView_Click_1(object sender, EventArgs e) {
            if(xpvPersons == null) {
                sbAddData.Enabled = true;
            }
            sbLoadData_Click(sender, e);
        }
        //<sbLoadData>
        private void sbLoadData_Click(object sender, EventArgs e) {
            if(cbXpView.Checked) {
                if(xpvPersons == null) {
                    xpvPersons = new XPView(session, typeof(Person));
                    xpvPersons.AddProperty("Oid", "Oid");
                    xpvPersons.AddProperty("FirstName", "FirstName");
                    xpvPersons.AddProperty("LastName", "LastName");
                    LoadAsyncPersonsXPView();
                }
                else {
                    LoadAsyncPersonsXPView();
                }
                if(xpvProducts == null) {
                    xpvProducts = new XPView(session, typeof(Product));
                    xpvProducts.AddProperty("Oid", "Oid");
                    xpvProducts.AddProperty("ProductName", "ProductName");
                    xpvProducts.AddProperty("Price", "Price");
                    LoadAsyncProductsXPView();
                }
                else {
                    LoadAsyncProductsXPView();
                }
            }
            else {
                if(xpcPersons == null) {
                    xpcPersons = new XPCollection(session, typeof(Person));
                    LoadAsyncPersonsXPCollection();
                }
                else {
                    LoadAsyncPersonsXPCollection();
                }
                if(xpcProducts == null) {
                    xpcProducts = new XPCollection(session, typeof(Product));
                    LoadAsyncProductsXPCollection();
                }
                else {
                    LoadAsyncProductsXPCollection();
                }
            }
        }
        void LoadAsyncPersonsCore() {
            sbLoadData.Enabled = false;
            sbCommit.Enabled = false;
            lbLoadingPersons.Visible = true;
            gclPersons.Enabled = false;
            cbXpView.Enabled = false;
        }
        void LoadAsyncPersonsXPView() {
            LoadAsyncPersonsCore();
            xpvPersons.LoadAsync(new DevExpress.Xpo.Helpers.AsyncLoadObjectsCallback(CallBackPersons));
            if(!ReferenceEquals(gclPersons.DataSource, xpvPersons)) gclPersons.DataSource = xpvPersons;
        }
        void LoadAsyncPersonsXPCollection() {
            LoadAsyncPersonsCore();
            xpcPersons.LoadAsync(new DevExpress.Xpo.Helpers.AsyncLoadObjectsCallback(CallBackPersons));
            if(!ReferenceEquals(gclPersons.DataSource, xpcPersons)) gclPersons.DataSource = xpcPersons;
        }
        void LoadAsyncProductsXPView() {
            lbLoadingProducts.Visible = true;
            gclProducts.Enabled = false;
            xpvProducts.LoadAsync(new DevExpress.Xpo.Helpers.AsyncLoadObjectsCallback(CallBackProducts));
            if(!ReferenceEquals(gclProducts.DataSource, xpvProducts)) gclProducts.DataSource = xpvProducts;
        }
        void LoadAsyncProductsXPCollection() {
            lbLoadingProducts.Visible = true;
            gclProducts.Enabled = false;
            xpcProducts.LoadAsync(new DevExpress.Xpo.Helpers.AsyncLoadObjectsCallback(CallBackProducts));
            if(!ReferenceEquals(gclProducts.DataSource, xpcProducts)) gclProducts.DataSource = xpcProducts;
        }
        void CallBackPersons(ICollection[] result, Exception ex) {
            lbLoadingPersons.Visible = false;
            gclPersons.Enabled = true;
            if(ex != null) {
                XtraMessageBox.Show(ex.Message);
            }
        }
        void CallBackProducts(ICollection[] result, Exception ex) {
            sbLoadData.Enabled = true;
            sbCommit.Enabled = true;
            lbLoadingProducts.Visible = false;
            gclProducts.Enabled = true;
            cbXpView.Enabled = true;
            if(ex == null) return;
            XtraMessageBox.Show(ex.Message);
        }
        //</sbLoadData>

        private void sbAddData_Click(object sender, EventArgs e) {
            AddData();
            sbAddData.Enabled = false;
        }

        private void splitContainerControl1_Resize(object sender, EventArgs e) {
            splitContainerControl1.SplitterPosition = Width / 2;
        }

        //<sbCommit>
        private void sbCommit_Click(object sender, EventArgs e) {
            sbLoadData.Enabled = false;
            sbCommit.Enabled = false;
            gclPersons.Enabled = false;
            gclProducts.Enabled = false;
            cbXpView.Enabled = false;
            lbCommit.Visible = true;
            session.CommitChangesAsync(new AsyncCommitCallback(CallBackCommit));
        }

        void CallBackCommit(Exception ex) {
            sbLoadData.Enabled = true;
            sbCommit.Enabled = true;
            gclPersons.Enabled = true;
            gclProducts.Enabled = true;
            cbXpView.Enabled = true;
            lbCommit.Visible = false;
            if (ex == null) return;
            XtraMessageBox.Show(ex.Message);
        }
        //</sbCommit>
        private void AsyncLoading_Resize(object sender, EventArgs e) {
            lbCommit.Left = (this.Width - lbCommit.Width) / 2;
            lbCommit.Top = (this.Height - lbCommit.Height) / 2;
        }
    }
}

