using DevExpress.Tutorials;

namespace DevExpress.XtraTreeList.Demos {
    public partial class About : ucOverviewPage {
        public About() {
            InitializeComponent();
        }
        protected override void StartDemo() {
            StartDemoCore(false);
        }
        protected override string Line1Text {
            get {
                return "The XtraTreeList Suite";
            }
        }
        protected override string Line2Text {
            get {
                return "A hybrid treeview-listview control for the WinForms platform.";
            }
        }
        protected override string Line3Text {
            get {
                return "DevExpress Desktop Controls";
            }
        }
        protected override string Line4Text {
            get {
                return votedVSM;
            }
        }
        public override bool AllowCopyDxDemoLink {
            get { return false; }
        }
    }
}
