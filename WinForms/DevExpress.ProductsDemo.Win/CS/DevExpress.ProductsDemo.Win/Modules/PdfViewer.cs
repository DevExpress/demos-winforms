using System;
using DevExpress.XtraEditors;

namespace DevExpress.ProductsDemo.Win.Modules {
    public partial class PdfViewerModule : BaseModule {
        const string fileName = "Demo.pdf";

        protected override bool AutoMergeRibbon { get { return true; } }

        public PdfViewerModule() {
            InitializeComponent();
            pdfViewer.DocumentCreator = "PDF Viewer Demo";
            pdfViewer.DocumentProducer = "Developer Express Inc., " + AssemblyInfo.Version;
            pdfViewer.CreateRibbon();
        }
        internal override void ShowModule(bool firstShow) {
            base.ShowModule(firstShow);
            if (firstShow) {
                string path = DemoUtils.GetRelativePath(fileName);
                if (!String.IsNullOrEmpty(path)) 
                    try {
                        pdfViewer.LoadDocument(path);
                    }
                    catch {
                        XtraMessageBox.Show("The demo data has been corrupted.", "Error");
                    }
            }
            MainRibbon.SelectedPage = MainRibbon.MergedPages[0];
        }
        internal override void HideModule() {
            base.HideModule();
            if (pdfViewer != null)
                pdfViewer.HideFindDialog(true);
        }
    }
}
