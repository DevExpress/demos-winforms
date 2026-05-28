using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class SparklinesModule : SpreadsheetRibbonTutorialControlBase {
        public SparklinesModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("Sparklines.xlsx"));
        }

        protected internal override RibbonPage SelectedRibbonPage {
            get {
                return homeRibbonPage1;
            }
        }
    }
}
