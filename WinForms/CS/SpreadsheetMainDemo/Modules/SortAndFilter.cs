using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class SortAndFilterModule : SpreadsheetRibbonTutorialControlBase {
        public SortAndFilterModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("AutoFilter_template.xlsx"));
        }

        protected internal override RibbonPage SelectedRibbonPage {
            get {
                return dataRibbonPage1;
            }
        }
    }
}
