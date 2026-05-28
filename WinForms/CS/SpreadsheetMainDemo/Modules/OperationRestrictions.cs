using System;
using DevExpress.Spreadsheet.Demos;
using DevExpress.XtraEditors;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class OperationRestrictionsModule : SpreadsheetRibbonTutorialControlBase {
        public OperationRestrictionsModule() {
            InitializeComponent();
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("OperationRestrictions_template.xlsx"));

            propertyGridControl1.SelectedObject = new BehaviorOptionsProvider(spreadsheetControl1.Options.Behavior);
            propertyGridControl1.RowHeaderWidth = 110;
            propertyGridControl1.OptionsView.ShowRootCategories = false;
            propertyGridControl1.ExpandAllRows();
            InitializeZoomFactors();
        }

        private void InitializeZoomFactors() {
            spreadsheetControl1.Options.Behavior.MaxZoomFactor = SpreadsheetBehaviorZoomOptionsProvider.MaxZoomFactorDefault;
            spreadsheetControl1.Options.Behavior.MinZoomFactor = SpreadsheetBehaviorZoomOptionsProvider.MinZoomFactorDefault;
        }

        private void ReadOnly_CheckedChanged(object sender, EventArgs e) {
            spreadsheetControl1.ReadOnly = ((CheckEdit)sender).Checked;
        }
    }

}
