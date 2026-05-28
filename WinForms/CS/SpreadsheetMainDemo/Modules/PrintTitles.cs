using System;
using DevExpress.XtraSpreadsheet.Commands;
using DevExpress.XtraSpreadsheet.Services;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class PrintTitlesModule : SpreadSheetTutorialControlBase {
        public PrintTitlesModule() {
            InitializeComponent();
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("PrintTitles_template.xlsx"));
            spreadsheetPreview1.PreviewZoom = SpreadhsheetPreviewZoom.WholePage;
            spreadsheetPreview1.Workbook = spreadsheetControl1.Document;
            spreadsheetPreview1.UpdatePreview();
        }

        public override bool ShowWithPaddings {
            get {
                return true;
            }
        }

        private void SpreadsheetControl1_ContentChanged(object sender, EventArgs e) {
            spreadsheetPreview1.UpdatePreview();
            xtraTabControl1.SelectedTabPageIndex = 1;
        }

        private void PageSetup_Click(object sender, EventArgs e) {
            xtraTabControl1.SelectedTabPageIndex = 0;
            ISpreadsheetCommandFactoryService service = spreadsheetControl1.GetService<ISpreadsheetCommandFactoryService>();
            SpreadsheetCommand command = service.CreateCommand(SpreadsheetCommandId.PageSetupSheet);
            command.ForceExecute(command.CreateDefaultCommandUIState());
        }

        private void WholePage_Click(object sender, EventArgs e) {
            spreadsheetPreview1.PreviewZoom = SpreadhsheetPreviewZoom.WholePage;
        }

        private void ManyPages_Click(object sender, EventArgs e) {
            spreadsheetPreview1.PreviewZoom = SpreadhsheetPreviewZoom.TwoPages;
        }
    }
}
