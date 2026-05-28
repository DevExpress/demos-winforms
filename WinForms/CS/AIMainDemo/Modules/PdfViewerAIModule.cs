using System.IO;
using System.Reflection;
using DevExpress.XtraReports.UI;

namespace DevExpress.AI.Demos {
    public partial class PdfViewerAIModule : AITutorialControl {
        public PdfViewerAIModule() {
            AutoMergeRibbon = true;
            InitializeComponent();
            pdfViewer1.CreateRibbon();

            var pdfStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.AI.Demos.Data.PageContent.pdf");
            pdfViewer1.LoadDocument(pdfStream);
            UpdatePaddings();
        }

        protected override void UpdatePaddings() {
            UpdateBottomSpacings(lciUcDisclaimerPanel1, ucDisclaimerPanel1.RoundedPanelOffset);
        }
    }
}
