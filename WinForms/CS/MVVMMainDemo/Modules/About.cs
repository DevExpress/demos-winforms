using DevExpress.Tutorials;

namespace DevExpress.MVVM.Demos {
    public partial class About : ucOverviewPage {
        public About() {
            InitializeComponent();
        }
        protected override string Line1Text {
            get {
                return "DevExpress MVVM Best Practices";
            }
        }
        protected override string Line2Text {
            get {
                return "Elegant and fully adaptable infrastructural pattern for the WinForms platform \r\n powered by DevExpress Desktop Controls.";
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
        public override bool AllowCopyDxDemoLink { get { return false; } }
    }
}
