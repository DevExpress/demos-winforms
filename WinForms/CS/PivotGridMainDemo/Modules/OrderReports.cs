using DevExpress.Utils;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    /// <summary>
    /// Summary description for OrderReports.
    /// </summary>
    public partial class OrderReports : TutorialControl {
        public OrderReports() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();
        }

        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

        private void OrderReports_Load(object sender, System.EventArgs e) {
            pivotGridControl1.DataSource = GetNWindData("OrderReports");
            InitComboBox();
            rgReport.SelectedIndex = 0;
            pivotGridControl1.HeaderImages = HeadersImageList;
            fieldOrderID.ImageIndex = 1;
            fieldSum.ImageIndex = 3;
        }

        void InitComboBox() {
            object[] values = fieldOrderID.GetUniqueValues();
            foreach(object obj in values)
                cbeOrder.Properties.Items.Add(obj);
            cbeOrder.SelectedIndex = 0;
        }
        //<rgReport>
        void SetReport() {
            DoShow();
            pivotGridControl1.BeginUpdate();
            try {
                fieldOrderID.FilterValues.Clear();
                layoutControlItem2.Visibility = rgReport.SelectedIndex == 1?XtraLayout.Utils.LayoutVisibility.Always:XtraLayout.Utils.LayoutVisibility.Never;
                pivotGridControl1.OptionsView.ShowRowGrandTotals = rgReport.SelectedIndex != 1;
                fieldOrderID.FilterValues.FilterType = rgReport.SelectedIndex == 1 ? PivotFilterType.Included : PivotFilterType.Excluded;
                DefaultBoolean parameter = (rgReport.SelectedIndex == 1) ? DefaultBoolean.False : DefaultBoolean.Default;
                fieldOrderID.Options.AllowFilter = fieldOrderID.Options.AllowSort = parameter;
                pivotGridControl1.OptionsCustomization.FilterPanelVisible =  parameter == DefaultBoolean.False ? FilterPanelVisible.Never : FilterPanelVisible.Default;
                foreach(PivotGridField field in pivotGridControl1.Fields)
                    field.Area = PivotArea.FilterArea;
                switch(rgReport.SelectedIndex) {
                    case 0:
                    case 1:
                        fieldOrderID.Area = PivotArea.RowArea;
                        fieldProduct.Area = PivotArea.RowArea;
                        fieldUnitPrice.Area = PivotArea.DataArea;
                        fieldQuantity.Area = PivotArea.DataArea;
                        fieldDiscount.Area = PivotArea.DataArea;
                        fieldSum.Area = PivotArea.DataArea;
                        if(rgReport.SelectedIndex == 1)
                            SetOrderFilter();
                        break;
                    case 2:
                        fieldProduct.Area = PivotArea.RowArea;
                        fieldQuantity.Area = PivotArea.DataArea;
                        break;
                    case 3:
                        fieldProduct.Area = PivotArea.RowArea;
                        fieldUnitPrice.Area = PivotArea.DataArea;
                        break;
                }
            } finally {
                pivotGridControl1.EndUpdate();
            }
        }
        //</rgReport>
        //<cbeOrder>
        void SetOrderFilter() {
            pivotGridControl1.BeginUpdate();
            try {
                fieldOrderID.FilterValues.Clear();
                fieldOrderID.FilterValues.Add(cbeOrder.SelectedItem);
            } finally {
                pivotGridControl1.EndUpdate();
            }
        }
        //</cbeOrder>

        private void rgReport_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetReport();
        }

        private void cbeOrder_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetOrderFilter();
        }
    }
}
