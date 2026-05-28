using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class WorksheetProtectionModule : SpreadsheetRibbonTutorialControlBase {
        public WorksheetProtectionModule() {
            InitializeComponent();
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("SimpleMonthlyBudget.xlsx"));
        }

        protected internal override RibbonPage SelectedRibbonPage {
            get {
                return reviewRibbonPage1;
            }
        }
    }
}
