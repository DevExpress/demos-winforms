using DevExpress.Tutorials;
using DevExpress.Utils;
using System;
using System.Drawing;
using DevExpress.Utils.About;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class About : ucOverviewPage {
        public About() {
            InitializeComponent();
        }

        protected override string Line1Text { get { return "The XtraPivotGrid Suite"; } }
        protected override string Line2Text { get { return "Multi-dimensional data analysis and data mining for the WinForms platform."; } }
        protected override string Line3Text { get { return "DevExpress Desktop Controls"; } }
        protected override string Line4Text { get { return votedVSM; } }
        protected override ProductKind ProductKind { get { return ProductKind.DXperienceWin; } }
        public override bool AllowCopyDxDemoLink { get { return false; } }
    }
}

