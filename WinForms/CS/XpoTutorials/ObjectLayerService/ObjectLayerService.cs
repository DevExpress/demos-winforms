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
using DevExpress.Xpo.Metadata;
using DevExpress.Xpo.Demos.Tutorials;

namespace DevExpress.Xpo.Demos {
    public partial class ObjectLayerServices : TutorialControl {
        //<sbStartService>
        const string auxPath = "net.tcp://localhost:59723/XPOTutorialObjectLayerService";
        //</sbStartService>
        public override bool SetNewWhatsThisPadding { get { return true; } }

        public ObjectLayerServices() {
            InitializeComponent();
            PrepareDataLayer();
        }

        IDataStore mainDataStore;

        //<sbStartService>
        UnitOfWork session;
        ServiceHost serviceHost;
        void CreateService(IDataStore dataStore) {
            XPDictionary xpDictionary = new ReflectionDictionary();
            xpDictionary.CollectClassInfos(typeof(Employees));
            IDataLayer dataLayer = new ThreadSafeDataLayer(xpDictionary, dataStore);
            SerializableObjectLayerServiceTutorial service = new SerializableObjectLayerServiceTutorial(dataLayer);
            serviceHost = new ServiceHost(service);
            NetTcpBinding binding = new NetTcpBinding();
            binding.MaxReceivedMessageSize = Int32.MaxValue;
            serviceHost.AddServiceEndpoint(typeof(ISerializableObjectLayerService), binding, auxPath);
            serviceHost.Open();
        }
        void CloseService() {
            if(serviceHost == null) return;
            if(serviceHost.State != CommunicationState.Opened) return;
            serviceHost.Close();
            serviceHost = null;
        }
        void CreateClient() {
            NetTcpBinding binding = new NetTcpBinding();
            binding.MaxReceivedMessageSize = Int32.MaxValue;
            EndpointAddress endPoint = new EndpointAddress(auxPath);
            ISerializableObjectLayer serializableObjectLayer = new SerializableObjectLayerServiceClient(binding, endPoint);
            serializableObjectLayer.CanLoadCollectionObjects.ToString(); //Check connection
            IObjectLayer objectLayer = new SerializableObjectLayerClient(serializableObjectLayer);
            session = new UnitOfWork(objectLayer);
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
            gclObjectLayerServicesMain.DataSource = viewEmployee;
            gvlObjectLayerServices.PopulateColumns();
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
    public class SerializableObjectLayerServiceTutorial : SerializableObjectLayerService {
        public SerializableObjectLayerServiceTutorial(IDataLayer dataLayer)
            : base(new SerializableObjectLayerProxy(dataLayer)) {
        }
    }
    public class SerializableObjectLayerProxy : SerializableObjectLayerProxyBase {
        IDataLayer dataLayer;
        public SerializableObjectLayerProxy(IDataLayer dataLayer)
            : base() {
            this.dataLayer = dataLayer;
        }
        protected override SerializableObjectLayer GetObjectLayer() {
            return new SerializableObjectLayer(new UnitOfWork(dataLayer), true);
        }
    }
    //</sbStartService>
}

