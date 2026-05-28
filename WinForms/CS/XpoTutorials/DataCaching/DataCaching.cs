using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo.DB;
using DevExpress.Data.Filtering;
using System.Globalization;
using DevExpress.Internal;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.Xpo.Demos;
using DevExpress.Xpo.Demos.Tutorials;

namespace DevExpress.Xpo.Demos {
    public partial class DataCaching : TutorialControl {
        public override bool SetNewWhatsThisPadding { get { return true; } }

        public DataCaching() {
            InitializeComponent();
            PrepareDataLayer();
            PrepareViews();
            LoadEmployees();
        }

        //<gclDataCachingMain>
        UnitOfWork session;
        DataCacheRoot dataCacheRoot;
        void CreateCachedConnection(IDataStore dataStore) {
            if(dataCacheRoot == null) {
                dataCacheRoot = new DataCacheRoot(dataStore);
                dataCacheRoot.Configure(new DataCacheConfiguration(DataCacheConfigurationCaching.InList, "Employees"));
            }
            DataCacheNode cachedDataStore = new DataCacheNode(dataCacheRoot);
            cachedDataStore.MaxCacheLatency = TimeSpan.FromSeconds(2);

            IDataLayer dataLayer = new SimpleDataLayer(cachedDataStore);
            session = new UnitOfWork(dataLayer);
        }
        XPView viewEmployee;
        XPView viewOrder;
        void PrepareViews() {
            viewEmployee = new XPView(session, typeof(Employees));
            viewEmployee.AddProperty("FirstName", "FirstName");
            viewEmployee.AddProperty("LastName", "LastName");
            viewEmployee.AddProperty("City", "City");
            viewOrder = new XPView(session, typeof(Orders));
            viewOrder.AddProperty("ShipName", "ShipName");
            viewOrder.AddProperty("OrderDate", "OrderDate");
            viewOrder.AddProperty("Freight", "Freight");
        }
        //</gclDataCachingMain>

        void PrepareDataLayer() {
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if(!string.IsNullOrEmpty(DBFileName)) {
                InMemoryDataStore inMemory = new InMemoryDataStore(AutoCreateOption.SchemaAlreadyExists);
                inMemory.ReadXml(DBFileName);
                CreateCachedConnection(new DataStoreCounter(inMemory));
                DataStoreCounter.ClearCounter();
            }
        }

        //<sbChangeAnyEmployee>
        void UpdateAnyEmployee() {
            DataCacheNode cachedDataStore = new DataCacheNode(dataCacheRoot);
            cachedDataStore.MaxCacheLatency = TimeSpan.FromSeconds(2);
            IDataLayer dataLayer = new SimpleDataLayer(cachedDataStore);
            using(UnitOfWork uow = new UnitOfWork(dataLayer)) {
                Employees employee = uow.FindObject<Employees>(null);
                if(employee == null) return;
                if(employee.City == "New York") {
                    employee.City = "Chicago";
                } else {
                    employee.City = "New York";
                }
                employee.Save();
                uow.CommitChanges();
                lbSelectCount.Text = DataStoreCounter.SelectCounterValue.ToString();
            }
        }
        //</sbChangeAnyEmployee>


        //<sbEmployees>
        void LoadEmployees() {
            viewEmployee.Reload();
            if(gclDataCachingMain.DataSource != viewEmployee) {
                gclDataCachingMain.DataSource = viewEmployee;
                gvlDataCaching.PopulateColumns();
                sbEmployees.Text = "Reload Employees";
                sbOrders.Text = "Load Orders";
            }
            lbSelectCount.Text = DataStoreCounter.SelectCounterValue.ToString();
        }
        //</sbEmployees>
        //<sbOrders>
        void LoadOrders() {
            viewOrder.Reload();
            if(gclDataCachingMain.DataSource != viewOrder) {
                gclDataCachingMain.DataSource = viewOrder;
                gvlDataCaching.PopulateColumns();
                sbEmployees.Text = "Load Employees";
                sbOrders.Text = "Reload Orders";
            }
            lbSelectCount.Text = DataStoreCounter.SelectCounterValue.ToString();
        }
        //</sbOrders>


        private void sbEmployees_Click(object sender, EventArgs e) {
            LoadEmployees();
        }

        private void sbOrders_Click(object sender, EventArgs e) {
            LoadOrders();
        }

        private void changeAnyEmployee_Click(object sender, EventArgs e) {
            UpdateAnyEmployee();
        }
    }
}

