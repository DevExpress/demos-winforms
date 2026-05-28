using System.IO;
using System.Reflection;
using DevExpress.DXperience.Demos;
using DevExpress.XtraReports.UI;

namespace DevExpress.AI.Demos {
    public partial class ReportViewerAIModule : AITutorialControl {
        public ReportViewerAIModule() {
            AutoMergeRibbon = true;
            InitializeComponent();
            UpdatePaddings();
            if(DemoHelper.IsTesting)
                return;//Don't load Report
            using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.AI.Demos.Data.TableReport.prnx")) {
                if (manifestResourceStream == null)
                    throw new FileNotFoundException("Embedded report resource not found.");
                XtraReport report = new XtraReport();
                report.PrintingSystem.LoadDocument(manifestResourceStream);
                documentViewerControl1.DocumentSource = report;
            }
            
        }
        protected override void UpdatePaddings() {
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset);
        }
    }
}
