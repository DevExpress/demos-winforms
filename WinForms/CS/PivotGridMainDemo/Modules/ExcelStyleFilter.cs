using System.Windows.Forms;
using DevExpress.Internal;
using DevExpress.XtraPivotGrid.Demos.Helpers;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class ExcelStyleFilter : TutorialControl {
        public ExcelStyleFilter() {
            InitializeComponent();
            InitVehiclesData();
        }
        #region Init Data
        void InitVehiclesData() {
            if(DesignMode)
                return;
            string dbFileName = DevAVDataDirectoryHelper.GetFile("Vehicles.xml");
            if(!string.IsNullOrEmpty(dbFileName)) {
                pivotGridControl.LoadingPanelVisible = true;
                VehiclesData.InitOrdersData(dbFileName, pivotGridControl, 10000, 365 * 3, () => {
                    pivotGridControl.HtmlImages = PivotDemoHelper.GetTransmissionGlyphs();
                    pivotGridControl.CollapseAllColumns();
                    string price = fieldModelPrice.FilterColumnName, body = fieldBodyStyle.FilterColumnName;
                    pivotGridControl.ActiveFilterString = "([" + price + "] >= 25000 And [" + price + "] <= 80000) And [" + body + "] In (6,7)";
                    pivotGridControl.MRUFilters.Add(new PivotFilterInfo("([" + price + "] >= 25000 And [" + price + "] <= 80000)"));
                    // Hide loading panel
                    pivotGridControl.LoadingPanelVisible = false;
                });
            }
        }
        #endregion
        //<pivotGridControl>
        void OnFilterPopupExcelData(object sender, FilterPopupExcelDataEventArgs e) {
            string fieldName = e.Field.FilterColumnName;
            if(e.Field == fieldModification) {
                // Filter Items
                e.AddFilter("<image=A><nbsp>Automatic Transmission (6-speed)", "Contains([" + fieldName + "], '6A')", true);
                e.AddFilter("<image=A><nbsp>Automatic Transmission (8-speed)", "Contains([" + fieldName + "], '8A')", true);
                e.AddFilter("<image=M><nbsp>Manual Transmission (6-speed)", "Contains([" + fieldName + "], '6M')", true);
                e.AddFilter("<image=M><nbsp>Manual Transmission (7-speed)", "Contains([" + fieldName + "], '7M')", true);
                e.AddFilter("<image=V><nbsp>Variomatic Transmission", "Contains([" + fieldName + "], 'VA')", true);
                e.AddFilter("<b>Limited Edition</b>", "Contains([" + fieldName + "], 'Limited')", true);
                // Data Items
                foreach(var item in e.DataItems) {
                    if(item.Text.Contains("V6"))
                        item.HtmlText = item.Text.Replace("V6", "<b>V6</b>");
                    if(item.Text.Contains("V8"))
                        item.HtmlText = item.Text.Replace("V8", "<b>V8</b>");
                    if(item.Text.Contains("Limited"))
                        item.HtmlText = "<image=Ltd><nbsp>" + item.Text;
                }
            }
            if(e.Field == fieldMPGCity) { // 12-28
                e.AddFilter("Fuel Economy (<color=green>High</color>)", "[" + fieldName + "]>25", true);
                e.AddFilter("Fuel Economy (<color=orange>Medium</color>)", "[" + fieldName + "]>=15 AND [" + fieldName + "]<=25", true);
                e.AddFilter("Fuel Economy (<color=red>Low</color>)", "[" + fieldName + "]<15", true);
            }
            if(e.Field == fieldMPGHighway) { // 15-36
                e.AddFilter("Fuel Economy (<color=green>High</color>)", "[" + fieldName + "]>30", true);
                e.AddFilter("Fuel Economy (<color=orange>Medium</color>)", "[" + fieldName + "]>=20 AND [" + fieldName + "]<=30", true);
                e.AddFilter("Fuel Economy (<color=red>Low</color>)", "[" + fieldName + "]<20", true);
            }
        }
        //</pivotGridControl>
        #region Options
        public override PivotGridControl ViewOptionsControl {
            get { return pivotGridControl; }
        }
        public override PivotGridControl ExportControl {
            get { return pivotGridControl; }
        }
        #endregion Options
    }
}
