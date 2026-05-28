using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class DataValidationModule : SpreadsheetRibbonTutorialControlBase {
        public DataValidationModule() {
            InitializeComponent();

            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataValidation_template.xlsx"));
            spreadsheetControl1.Options.Behavior.Drawing.Move = DocumentCapability.Disabled;
            spreadsheetControl1.Options.Behavior.Drawing.Resize = DocumentCapability.Disabled;
            spreadsheetControl1.Options.Behavior.Drawing.Rotate = DocumentCapability.Disabled;
        }

        protected internal override RibbonPage SelectedRibbonPage {
            get {
                return dataRibbonPage1;
            }
        }
    }
}
