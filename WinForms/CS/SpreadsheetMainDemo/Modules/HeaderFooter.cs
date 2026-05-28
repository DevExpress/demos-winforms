using System;
using DevExpress.Spreadsheet;
using DevExpress.XtraSpreadsheet.Commands;
using DevExpress.XtraSpreadsheet.Services;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class HeaderFooterModule : SpreadSheetTutorialControlBase {
        public HeaderFooterModule() {
            InitializeComponent();
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("HeaderFooter_template.xlsx"), DocumentFormat.Xlsx);
            spreadsheetPreview1.Workbook = spreadsheetControl1.Document;
            spreadsheetPreview1.UpdatePreview();
        }

        private void spreadsheetControl1_ContentChanged(object sender, EventArgs e) {
            spreadsheetPreview1.UpdatePreview();
        }

        private void btnPageSetup_Click(object sender, EventArgs e) {
            ISpreadsheetCommandFactoryService service = spreadsheetControl1.GetService<ISpreadsheetCommandFactoryService>();
            SpreadsheetCommand command = service.CreateCommand(SpreadsheetCommandId.PageSetupHeaderFooter);
            command.ForceExecute(command.CreateDefaultCommandUIState());
        }
    }
}
