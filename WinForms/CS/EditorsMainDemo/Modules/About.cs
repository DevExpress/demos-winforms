using System.Drawing;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.Tutorials;


namespace DevExpress.XtraEditors.Demos {
    public partial class About : ucOverviewPage {
        protected override string Line1Text {
            get {
                return "The XtraEditors Suite";
            }
        }
        protected override string Line2Text {
            get {
                return "The most comprehensive collection of editors for the WinForms platform.";
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
