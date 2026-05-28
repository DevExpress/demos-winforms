using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraPdfViewer.Demos {
    public partial class ViewerModule : TutorialControlBase {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override bool AutoMergeRibbon {
            get { return true; }
            set { }
        }
        public override bool AllowGenerateReport { get { return false; } }
        public override bool AllowPrintOptions { get { return false; } }

        public ViewerModule() {
            InitializeComponent();
            pdfViewer1.CreateRibbon();
            pdfViewer1.DocumentCreator = "PDF Viewer Demo";
            pdfViewer1.DocumentProducer = "Developer Express Inc., " + AssemblyInfo.Version;
            pdfViewer1.LoadDocument(DemoHelpers.GetDocumentStream());
            pdfViewer1.DocumentClosing += OnDocumentClosing;
        }
        protected override void OnParentChanged(EventArgs e) {
            base.OnParentChanged(e);
            ParentForm.FormClosing += OnDocumentClosing;
        }
        void OnDocumentClosing(object sender, CancelEventArgs e) {
            if(pdfViewer1.IsDocumentChanged)
                e.Cancel = !pdfViewer1.ShowDocumentClosingWarning();
        }

    }
}
