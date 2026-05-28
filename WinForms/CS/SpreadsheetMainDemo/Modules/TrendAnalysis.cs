using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class TrendAnalysisModule : SpreadsheetRibbonTutorialControlBase {

        public TrendAnalysisModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("TrendlineAnalysis_template.xlsx"));
        }

        protected internal override RibbonPage SelectedRibbonPage {
            get {
                return formulasRibbonPage1;
            }
        }
    }
}
