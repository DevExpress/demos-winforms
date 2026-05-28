using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class CommentsModule : SpreadsheetRibbonTutorialControlBase {
        public CommentsModule() {
            InitializeComponent();
            spreadsheetControl1.Options.Culture = DefaultCulture;
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("Comments_template.xlsx"));
        }

        protected internal override RibbonPage SelectedRibbonPage {
            get {
                return reviewRibbonPage1;
            }
        }
    }
}
