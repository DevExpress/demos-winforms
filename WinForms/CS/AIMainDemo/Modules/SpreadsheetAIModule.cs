using System.Reflection;
using DevExpress.AIIntegration.WinForms;
using DevExpress.Spreadsheet;

namespace DevExpress.AI.Demos {
    public partial class SpreadsheetAIModule : AITutorialControl {
        public SpreadsheetAIModule() {
            AutoMergeRibbon = true;
            InitializeComponent();
            var documentStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.AI.Demos.Data.LoanAmortizationSchedule.xlsx");
            spreadsheetControl1.LoadDocument(documentStream, DocumentFormat.OpenXml);
            UpdatePaddings();
        }
        protected override void UpdatePaddings() {
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset);
        }
        protected override void DoHide() {
            behaviorManager1.GetBehavior<ProofreadBehavior>(spreadsheetControl1)?.CloseOverlayForm();
            behaviorManager1.GetBehavior<TranslateBehavior>(spreadsheetControl1)?.CloseOverlayForm();
            base.DoHide();
        }
    }
}
