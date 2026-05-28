using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Internal;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;

namespace DevExpress.XtraLayout.Demos {
    public partial class LayoutWaybill : XtraUserControl {
        public LayoutWaybill() {
            InitializeComponent();
        }
        void InitData() {
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if(DBFileName != "") {
                dsOrder.ReadXml(DBFileName, XmlReadMode.InferSchema);
                rilProduct.DataSource = dsOrder.Products;
            }
        }
        void ChangeData() {
            dnNavigationCustomer.Position = (int)dsOrder.Orders[dnNavigationOrders.Position][dsOrder.Orders.Columns[2]];
            string str = (string)dsOrder.Orders[dnNavigationOrders.Position][dsOrder.Orders.Columns[1]];
            dnNavigationEmployee.Position = dsOrder.Customers.FindByCustomerID(str).Table.Rows.IndexOf(dsOrder.Customers.FindByCustomerID(str));
            ChangeFilter();
        }
        void ChangeFilter() {
            gridViewOrders.ActiveFilter.Clear();
            gridViewOrders.ActiveFilter.Add(gridViewOrders.Columns["OrderID"], new ColumnFilterInfo(String.Format("OrderID == '{0}'", dsOrder.Orders[dnNavigationOrders.Position].OrderID)));
        }
        void dataNavigator1_PositionChanged(object sender, EventArgs e) {
            ChangeData();
        }
        void LayoutWaybill_Load(object sender, EventArgs e) {
            if(!DesignMode) {
                InitData();
                ChangeData();
            }
        }
    }
}
