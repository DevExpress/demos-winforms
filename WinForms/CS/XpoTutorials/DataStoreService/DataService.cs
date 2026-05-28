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
using DevExpress.Xpo.DB.Helpers;
using DevExpress.Xpo.Demos;
using System.ServiceModel;
using System.Threading;
using DevExpress.Internal;
using DevExpress.Xpo.Demos.Tutorials;

namespace DevExpress.Xpo.Demos {
    public partial class DataServices : TutorialControl {
        //<sbStartService>
        const string auxPath = "net.tcp://localhost:49381/XPOTutorialService";
        //</sbStartService>
        public override bool SetNewWhatsThisPadding { get { return true; } }

        public DataServices() {
            InitializeComponent();
            PrepareDataLayer();
        }

        IDataStore mainDataStore;

        //<sbStartService>
        UnitOfWork session;
        ServiceHost serviceHost;
        void CreateService(IDataStore dataStore) {
            DataStoreServiceTutorial service = new DataStoreServiceTutorial(dataStore);
            serviceHost = new ServiceHost(service);
            NetTcpBinding binding = new NetTcpBinding();
            binding.MaxReceivedMessageSize = Int32.MaxValue;
            serviceHost.AddServiceEndpoint(typeof(IDataStoreService), binding, auxPath);
            serviceHost.Open();
        }
        void CloseService() {
            if(serviceHost == null) return;
            if(serviceHost.State != CommunicationState.Opened) return;
            serviceHost.Close();
            serviceHost = null;
        }
        void CreateClient() {
            IDataStore clientDataStore = XpoDefault.GetConnectionProvider(auxPath, AutoCreateOption.SchemaAlreadyExists);
            IDataLayer dataLayer = new SimpleDataLayer(clientDataStore);
            session = new UnitOfWork(dataLayer);
        }
        //</sbStartService>

        void PrepareDataLayer() {
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if(!string.IsNullOrEmpty(DBFileName)) {
                InMemoryDataStore inMemory = new InMemoryDataStore(AutoCreateOption.SchemaAlreadyExists);
                inMemory.ReadXml(DBFileName);
                mainDataStore = inMemory;
            }
        }

        //<sbEmployees>
        void LoadEmployees() {
            XPView viewEmployee = new XPView(session, typeof(Employees));
            viewEmployee.AddProperty("FirstName", "FirstName");
            viewEmployee.AddProperty("LastName", "LastName");
            viewEmployee.AddProperty("City", "City");
            gclDataServicesMain.DataSource = viewEmployee;
            gvlDataServices.PopulateColumns();
        }
        //</sbEmployees>


        private void sbEmployees_Click(object sender, EventArgs e) {
            LoadEmployees();
        }

        private void sbStartService_Click(object sender, EventArgs e) {
            if(serviceHost == null) {
                AutoResetEvent waitEvent = new AutoResetEvent(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object o) {
                    CreateService(mainDataStore);
                    waitEvent.Set();
                }));
                waitEvent.WaitOne(20000, false);
                CreateClient();
                sbStartService.Text = "Stop Service";
                sbEmployees.Enabled = true;
            } else {
                sbStartService.Text = "Stopping Service... Please Wait";
                sbStartService.Update();
                AutoResetEvent waitEvent = new AutoResetEvent(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate(object o) {
                    CloseService();
                    waitEvent.Set();
                }));
                waitEvent.WaitOne(20000, false);
                sbStartService.Text = "Start Service And Create Client";
                sbEmployees.Enabled = false;
            }
        }
    }

    //<sbStartService>
    [ServiceBehaviorAttribute(InstanceContextMode = InstanceContextMode.Single)]
    public class DataStoreServiceTutorial : DataStoreService {
        public DataStoreServiceTutorial(IDataStore dataStore)
            : base(dataStore) {
        }
    }
    //</sbStartService>
}

