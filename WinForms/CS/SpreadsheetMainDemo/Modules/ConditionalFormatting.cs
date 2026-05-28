using System;
using DevExpress.Spreadsheet;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class TopTradingPartnersModule : SpreadsheetRibbonTutorialControlBase {
        public TopTradingPartnersModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("TopTradingPartners.xlsx"));
            UpdateConditionalFormatting();
        }

        private void OnCheckedChanged(object sender, EventArgs e) {
            UpdateConditionalFormatting();
        }

        private void UpdateConditionalFormatting() {
            spreadsheetControl1.BeginUpdate();
            try {
                Worksheet sheet = spreadsheetControl1.ActiveWorksheet;
                sheet.ConditionalFormattings.Clear();
                if(chkImports.Checked) {
                    TopTradingPartners.ApplyTopImportsConditionalFormatting(sheet);
                    TopTradingPartners.ApplyImportsYearlyChangeConditionalFormatting(sheet);
                }
                if(chkExports.Checked) {
                    TopTradingPartners.ApplyTopExportsConditionalFormatting(sheet);
                    TopTradingPartners.ApplyExportsYearlyChangeConditionalFormatting(sheet);
                }
                if(chkBalance.Checked) {
                    TopTradingPartners.ApplyBalanceTrendConditionalFormatting(sheet);
                    TopTradingPartners.ApplyBalanceChangeConditionalFormatting(sheet);
                }
                if(chkAsiaRegion.Checked)
                    TopTradingPartners.ApplyAsiaCountriesConditionalFormatting(sheet);
            }
            finally {
                spreadsheetControl1.EndUpdate();
            }
        }
    }
}
