using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

using System.Windows.Forms;
using DevExpress.Tutorials;
using DevExpress.Utils.About;


namespace DevExpress.XtraGrid.Demos {
	public partial class About : ucOverviewPage {
		public About() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
        protected override Image Awards { get { return DevExpress.Tutorials.Properties.Resources.Awards; } }
        protected override string Line1Text {
            get {
                return "When only the best grid will do.";
            }
        }
        protected override string Line2Text {
            get {
                return "Voted #1 six times by readers of Visual Studio Magazine.";
            }
        }
        protected override string Line3Text {
            get {
                return "Your peers say the XtraGrid is #1.";
            }
        }
        protected override string Line4Text {
            get {
                return "Try it yourself and see why.";
            }
        }
        public override bool AllowCopyDxDemoLink { get { return false; } }
        /*protected override void StartDemo() {
            StartDemoCore(false);
        }*/
    }
}

