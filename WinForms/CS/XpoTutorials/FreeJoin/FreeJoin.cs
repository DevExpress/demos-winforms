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
using DevExpress.Xpo.Demos.Tutorials;

namespace DevExpress.Xpo.Demos {
    public partial class FreeJoin : TutorialControl {
        public override bool SetNewWhatsThisPadding { get { return true; } }

        bool[] firstShow = new bool[] { true, true };

        public FreeJoin() {
            InitializeComponent();
            CreateConnection();
            xtraTabControl1_SelectedPageChanged(this, new DevExpress.XtraTab.TabPageChangedEventArgs(xtpSimple, xtpSimple));
        }
        UnitOfWork session;
        void CreateConnection() {
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if (!string.IsNullOrEmpty(DBFileName)) {
                InMemoryDataStore dataStore = new InMemoryDataStore(AutoCreateOption.None);
                dataStore.ReadXml(DBFileName);
                IDataLayer dataLayer = new SimpleDataLayer(dataStore);
                session = new UnitOfWork(dataLayer);
            }
        }

        private void splitContainerControl1_Resize(object sender, EventArgs e) {
            splitContainerControl1.SplitterPosition = xtpAssociationsEquivalent.Width / 2;
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            if(firstShow[xtraTabControl1.SelectedTabPageIndex]) {
                firstShow[xtraTabControl1.SelectedTabPageIndex] = false;
                switch(xtraTabControl1.SelectedTabPageIndex) {
                    case 0:
                        LoadFreeJoin();
                        break;
                    case 1:
                        LoadSuppliersAssociation();
                        LoadSuppliersFreeJoin();
                        break;
                    default:
                        break;
                }
            }
        }


        //<splitContainerControl1>
        void LoadSuppliersAssociation() {
            XPCollection<Suppliers> sups = new XPCollection<Suppliers>(session, CriteriaOperator.Parse("Products[].Count() > 2"));
            gclAssociation.DataSource = sups;
        }
        void LoadSuppliersFreeJoin() {
            XPCollection<Suppliers> sups = new XPCollection<Suppliers>(session, CriteriaOperator.Parse("[<Products>][^.SupplierID = SupplierID].Count() > 2"));
            gclFreeJoin.DataSource = sups;
        }
        //</splitContainerControl1>

        //<gclFreeJoinMain>
        void LoadFreeJoin() {
            XPView view = new XPView(session, typeof(Employees));
            view.Criteria = CriteriaOperator.Parse("[<Orders>][^.EmployeeID = EmployeeID].Count() > 50");
            view.AddProperty("FirstName", "FirstName");
            view.AddProperty("LastName", "LastName");
            view.AddProperty("OrderCount", "[<Orders>][^.EmployeeID = EmployeeID].Count()");
            view.AddProperty("OrderCount2", new JoinOperand("Orders", new OperandProperty("^.EmployeeID") == new OperandProperty("EmployeeID"), Aggregate.Count, null));
            view.AddProperty("City", "City");
            view.AddProperty("CustomersInTheCity", "[<Customers>][^.City = City].Count()");
            view.AddProperty("LastAlphabeticalCustomerInTheCity", "[<Customers>][^.City = City].Max(ContactName)");
            gclFreeJoinMain.DataSource = view;
        }
        //</gclFreeJoinMain>
    }
}

