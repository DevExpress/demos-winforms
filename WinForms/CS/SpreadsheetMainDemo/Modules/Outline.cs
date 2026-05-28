using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class OutlineModule : SpreadsheetRibbonTutorialControlBase {
        public OutlineModule() {
            InitializeComponent();
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("OutlineGrouping_template.xlsx"));
        }

        protected internal override RibbonPage SelectedRibbonPage {
            get {
                return dataRibbonPage1;
            }
        }
    }
}
