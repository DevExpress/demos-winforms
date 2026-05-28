using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class RotatedTextModule : SpreadsheetRibbonTutorialControlBase {
        public RotatedTextModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("RotatedText_template.xlsx"));
        }

        protected internal override RibbonPage SelectedRibbonPage {
            get {
                return homeRibbonPage1;
            }
        }
    }
}
