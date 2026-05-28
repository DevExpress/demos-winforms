using System.Drawing;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {

    public partial class PivotTableModule : SpreadsheetRibbonTutorialControlBase {
        public PivotTableModule() {
            InitializeComponent();
        }

        IWorkbook Workbook {
            get {
                return spreadsheetControl1.Document;
            }
        }

        protected internal override RibbonPage SelectedRibbonPage {
            get {
                pivotTableToolsRibbonPageCategory1.Visible = true;
                pivotTableAnalyzeRibbonPage1.Visible = true;
                return pivotTableAnalyzeRibbonPage1;
            }
        }

        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            ApplyOptions();
            Workbook.LoadDocument(DemoUtils.GetRelativePath("PivotTableDemoTemplate.xlsx"));
            spreadsheetControl1.Document.PivotCaches.RefreshAll();
        }

        void ApplyOptions() {
            Graphics graphics = CreateGraphics();
            SpreadsheetPivotTableFieldListOptions pivotTableFieldListOptions = spreadsheetControl1.Options.PivotTableFieldList;
            pivotTableFieldListOptions.StartPosition = SpreadsheetPivotTableFieldListStartPosition.ManualSpreadsheetControl;
            pivotTableFieldListOptions.StartSize = new Size((int)(350 * graphics.DpiX / 96F), (int)(601 * graphics.DpiY / 96F));
            double width = spreadsheetControl1.Width - pivotTableFieldListOptions.StartSize.Width;
            pivotTableFieldListOptions.StartLocation = new Point((int)width, 0);
        }

        protected override void DoShow() {
            base.DoShow();
            Workbook.Worksheets.ActiveWorksheet.Selection = Workbook.Worksheets.ActiveWorksheet["C3"];
        }

        protected override void DoHide() {
            Workbook.Worksheets.ActiveWorksheet.Selection = Workbook.Worksheets.ActiveWorksheet["A1"];
            base.DoHide();
        }
    }
}
