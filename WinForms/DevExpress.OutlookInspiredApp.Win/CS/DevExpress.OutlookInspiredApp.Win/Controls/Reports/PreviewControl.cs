using System;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Preview;

namespace DevExpress.DevAV {
    public partial class ReportPreviewControl : XtraUserControl {
        public ReportPreviewControl() {
            InitializeComponent();
            printPreviewBarItemWholePage.Glyph = null;
            printPreviewBarItemScale.Glyph = null;
            printPreviewBarItemMultiplePages.Glyph = null;
            printPreviewBarItemWholePage.ImageOptions.SvgImage = SvgImage.FromResources("DevExpress.DevAV.Resources.Fluent.Controls.OverviewControl.scale-fluent-light-blue-16.svg", typeof(MainForm).Assembly);
            printPreviewBarItemMultiplePages.ImageOptions.SvgImage = SvgImage.FromResources("DevExpress.DevAV.Resources.Fluent.Controls.OverviewControl.page-multiple-fluent-light-blue-16.svg", typeof(MainForm).Assembly);
            printPreviewBarItemScale.ImageOptions.SvgImage = SvgImage.FromResources("DevExpress.DevAV.Resources.Fluent.Controls.OverviewControl.expand-fluent-light-yellow-16.svg", typeof(MainForm).Assembly);
        }
        public DocumentViewer DocumentViewer {
            get { return documentViewerCore; }
        }
        protected override void OnLoad(System.EventArgs e) {
            base.OnLoad(e);
            DocumentViewer.BackColor = ColorHelper.GetControlColor(LookAndFeel);
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            DocumentViewer.BackColor = ColorHelper.GetControlColor(LookAndFeel);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(false)]
        public object DocumentSource {
            get { return documentViewerCore.DocumentSource; }
            set {
                if(!ReferenceEquals(documentViewerCore.DocumentSource, value)) {
                    documentViewerCore.DocumentSource = value;
                }
            }
        }
    }
}
