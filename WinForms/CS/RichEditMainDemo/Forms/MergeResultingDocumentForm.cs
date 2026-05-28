using System;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraRichEdit.API.Native;

namespace DevExpress.XtraRichEdit.Demos.Forms {
    public partial class MergeResultingDocumentForm : RibbonForm {
        public MergeResultingDocumentForm() {
            InitializeComponent();
            RibbonControl ribbonControl = richEditControl.CreateRibbon();
            Controls.Add(ribbonControl);
        }

        public Document Document { get { return richEditControl.Document; } }

        void ribbonControl1_ApplicationButtonDoubleClick(object sender, EventArgs e) {
            Close();
        }
    }
}
