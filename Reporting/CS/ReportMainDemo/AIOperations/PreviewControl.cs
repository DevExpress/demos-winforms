using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.AIIntegration;
using DevExpress.AIIntegration.WinForms;
using DevExpress.Utils.Behaviors;
using DevExpress.XtraReports.UI;
using XtraReportsDemos.NorthwindTraders;

namespace XtraReportsDemos.AIOperations {
    public class PreviewControl : ReportModule {
        readonly BehaviorManager behaviorManager1 = new BehaviorManager();

        protected internal override Control HeaderContent { get; } = new ucDisclaimerPanel();

        protected override XtraReport CreateReport() {
            AIServicesRegistration.RegisterIfNeeded();
            return new InvoiceReport();
        }

        protected override void OnSetViewer() {
            ((System.ComponentModel.ISupportInitialize)(behaviorManager1)).BeginInit();
            LanguageInfo languageInfo1 = new LanguageInfo { Culture = new CultureInfo("en"), LanguageName = "English" };
            LanguageInfo languageInfo2 = new LanguageInfo { Culture = new CultureInfo("es"), LanguageName = "Spanish" };
            LanguageInfo languageInfo3 = new LanguageInfo { Culture = new CultureInfo("de"), LanguageName = "German" };
            LanguageInfo languageInfo4 = new LanguageInfo { Culture = new CultureInfo("zh"), LanguageName = "Chinese" };
            behaviorManager1.Detach(Viewer);
            behaviorManager1.SetBehaviors(Viewer, new Behavior[] {
                DocumentTranslateBehavior.Create(typeof(DocumentTranslateBehaviorSource), new LanguageInfo[] { languageInfo1, languageInfo2, languageInfo3, languageInfo4 }),
                DocumentSummarizeBehavior.Create(typeof(DocumentSummarizeBehaviorSource), SummarizationMode.Abstractive),
                new DocumentTranslateInlineBehavior(typeof(DocumentTranslateInlineBehaviorSource), new LanguageInfo[] { languageInfo1, languageInfo2, languageInfo3, languageInfo4 })
            });
            ((System.ComponentModel.ISupportInitialize)(behaviorManager1)).EndInit();
            Viewer.SetPageView(DevExpress.XtraPrinting.PageViewModes.PageWidth);
        }

        protected override Task StopWorkingAsync() {
            behaviorManager1.Detach(Viewer);
            return base.StopWorkingAsync();
        }

        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
        }
    }
}
