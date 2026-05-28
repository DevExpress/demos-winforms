using DevExpress.Tutorials;

namespace DevExpress.XtraCharts.Demos {
    public partial class About : ucOverviewPage {
        public About() {
            InitializeComponent();
        }
        protected override string Line1Text { get { return "The XtraCharts Suite"; } }
        protected override string Line2Text { get { return "Elegant and fully customizable 2D/3D charting for the WinForms platform."; } }
        protected override string Line3Text { get { return "DevExpress Desktop Controls"; } }
        protected override string Line4Text { get { return votedVSM; } }
        public override bool AllowCopyDxDemoLink { get { return false; } }
    }
}
