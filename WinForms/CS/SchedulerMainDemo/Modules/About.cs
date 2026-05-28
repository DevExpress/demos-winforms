using System;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.Tutorials;
using DevExpress.Utils.About;

namespace DevExpress.XtraScheduler.Demos {
    public partial class About : ucOverviewPage {
        public About() {
            InitializeComponent();
        }

        protected override string Line1Text { get { return "The XtraScheduler Suite"; } }
        protected override string Line2Text { get { return "Outlook® inspired scheduler and calendar control for the WinForms platform."; } }
        protected override string Line3Text { get { return "DevExpress Desktop Controls"; } }
        protected override string Line4Text { get { return votedVSM; } }
        public override bool AllowCopyDxDemoLink { get { return false; } }
    }
}

