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
using DevExpress.Xpo.Demos.Tutorials;
using System.Threading.Tasks;
using DevExpress.Internal;

namespace DevExpress.Xpo.Demos {
    public partial class AsyncLoadingTaskBased : DevExpress.Xpo.Demos.TutorialControl {
        UnitOfWork session;
        IDataLayer dataLayer = new DelayedDataLayer(new SimpleDataLayer(new InMemoryDataStore()));
        public AsyncLoadingTaskBased() {
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
        //<sbLoadData>
        private async void sbLoadData_Click(object sender, EventArgs e) {
            sbLoadData.Enabled = false;
            sbCommit.Enabled = false;
            lbLoadingPersons.Visible = true;
            gclPersons.Enabled = false;
            lbLoadingProducts.Visible = true;
            gclProducts.Enabled = false;

            try {
                var personQuery = new XPQuery<Person>(session);
                gclPersons.DataSource = await personQuery.ToListAsync();
            } catch(Exception ex) {
                XtraMessageBox.Show(ex.Message);
            }

            lbLoadingPersons.Visible = false;
            gclPersons.Enabled = true;

            try {
                var productQuery = new XPQuery<Product>(session);
                gclProducts.DataSource = await productQuery.ToListAsync();
            } catch(Exception ex) {
                XtraMessageBox.Show(ex.Message);
            }

            lbLoadingProducts.Visible = false;
            gclProducts.Enabled = true;
            sbLoadData.Enabled = true;
            sbCommit.Enabled = true;
        }
        //</sbLoadData>

        private void splitContainerControl1_Resize(object sender, EventArgs e) {
            splitContainerControl1.SplitterPosition = Width / 2;
        }

        //<sbCommit>
        private async void sbCommit_Click(object sender, EventArgs e) {
            sbLoadData.Enabled = false;
            sbCommit.Enabled = false;
            gclPersons.Enabled = false;
            gclProducts.Enabled = false;
            lbCommit.Visible = true;

            try {
                await session.CommitChangesAsync();
            } catch(Exception ex) {
                XtraMessageBox.Show(ex.Message);
            }

            sbLoadData.Enabled = true;
            sbCommit.Enabled = true;
            gclPersons.Enabled = true;
            gclProducts.Enabled = true;
            lbCommit.Visible = false;
        }
        //</sbCommit>
        private void AsyncLoading_Resize(object sender, EventArgs e) {
            lbCommit.Left = (this.Width - lbCommit.Width) / 2;
            lbCommit.Top = (this.Height - lbCommit.Height) / 2;
        }
    }
}

