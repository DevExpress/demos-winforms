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
    public partial class Single : TutorialControl {
        public override bool SetNewWhatsThisPadding { get { return true; } }

        bool[] firstShow = new bool[] { true, true };

        public Single() {
            InitializeComponent();
            CreateConnection();
            xtraTabControl1_SelectedPageChanged(this, new DevExpress.XtraTab.TabPageChangedEventArgs(xtpSimple, xtpSimple));
        }
        UnitOfWork session;
        void CreateConnection() {
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if(!string.IsNullOrEmpty(DBFileName)) {
                InMemoryDataStore dataStore = new InMemoryDataStore(AutoCreateOption.None);
                dataStore.ReadXml(DBFileName);
                IDataLayer dataLayer = new SimpleDataLayer(dataStore);
                session = new UnitOfWork(dataLayer);
            }
        }

        private void splitContainerControl1_Resize(object sender, EventArgs e) {
            splitContainerControl1.SplitterPosition = xtpReferenceEquivalent.Width / 2;
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            if(firstShow[xtraTabControl1.SelectedTabPageIndex]) {
                firstShow[xtraTabControl1.SelectedTabPageIndex] = false;
                switch(xtraTabControl1.SelectedTabPageIndex) {
                    case 0:
                        LoadSingle();
                        break;
                    case 1:
                        LoadSuppliersAssociation();
                        LoadSuppliersSingle();
                        break;
                    default:
                        break;
                }
            }
        }


        //<splitContainerControl1>
        void LoadSuppliersAssociation() {
            XPCollection<Products> products = new XPCollection<Products>(session, CriteriaOperator.Parse("SupplierID.City = ?", "London"), new SortProperty("ProductName", SortingDirection.Ascending));
            gclReference.DataSource = products;
        }
        void LoadSuppliersSingle() {
            XPCollection<Products> products = new XPCollection<Products>(session, CriteriaOperator.Parse("[<Suppliers>][SupplierID = ^.SupplierID].Single(City) = ?", "London"), new SortProperty("ProductName", SortingDirection.Ascending));
            gclSingle.DataSource = products;
        }
        //</splitContainerControl1>

        //<gclSingleMain>
        void LoadSingle() {
            XPView view = new XPView(session, typeof(Employees));
            view.Criteria = CriteriaOperator.Parse("[<Orders>][^.EmployeeID = EmployeeID].Single() is not null");   //<-- Single
            view.AddProperty("Name", "LastName + ' ' + FirstName", false, true, SortDirection.Ascending);
            view.AddProperty("OrderDate", "[<Orders>][^.EmployeeID = EmployeeID].Single(OrderDate)");               //<-- Single
            view.AddProperty("OrderRequiredDate", "[<Orders>][^.EmployeeID = EmployeeID].Single(RequiredDate)");    //<-- Single
            view.AddProperty("OrderFreight", "[<Orders>][^.EmployeeID = EmployeeID].Single(Freight)");              //<-- Single
            view.AddProperty("City", "City");
            view.AddProperty("CustomersInTheCity", "[<Customers>][^.City = City].Count()");
            view.AddProperty("LastAlphabeticalCustomerInTheCity", "[<Customers>][^.City = City].Max(ContactName)");
            gclSingleMain.DataSource = view;
            gviewSingleMain.Columns.ColumnByFieldName("Name").Group();
        }
        //</gclSingleMain>
    }
}

