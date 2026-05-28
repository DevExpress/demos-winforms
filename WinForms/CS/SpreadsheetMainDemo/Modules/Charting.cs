using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class ChartingModule : SpreadsheetRibbonTutorialControlBase {
        public ChartingModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("Charting.xlsx"));
        }

        protected internal override RibbonPage SelectedRibbonPage { get { return insertRibbonPage1; } }
    }
}
