using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;

namespace DevExpress.XtraPdfViewer.Demos {
    public partial class MainForm : RibbonMainForm {
        public override bool UseEmptyRootPadding { get { return true; } }
        protected override bool CreateFeedbackPanel { get { return false; } }
        protected override bool ShowPanelDescription { get { return false; } }
        protected override bool SupportAdvancedTitlePainting { get { return true; } }
        protected override string ProductName { get { return "XtraPdfViewer"; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Control NavigationControl {
            get { return null; }
            set { }
        }

        public MainForm() {
            InitializeComponent();
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel) {
            DemosInfo.DoShowModule(name, group, RibbonMenuManager);
        }
        protected override void ShowAbout() {
            DevExpress.XtraPdfViewer.PdfViewer.About();
        }
    }
}
