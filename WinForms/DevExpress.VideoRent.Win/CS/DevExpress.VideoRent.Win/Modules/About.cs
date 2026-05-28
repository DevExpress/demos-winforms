using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.VideoRent.Win.Modules {
    public partial class About : TutorialControl {
        public About() {
            InitializeComponent();
            ElementConstStringLoader.LoadConstStringsForAbout(this);
            lcLink1.Appearance.Image = ElementHelper.GetAboutPageImage("Learn-More");
            lcLink2.Appearance.Image = ElementHelper.GetAboutPageImage("Download");
            lcLink3.Appearance.Image = ElementHelper.GetAboutPageImage("Buy");
            ucControlAbout1.Init("XtraGrid", DemoProducts.Grid, ElementHelper.GetAboutPageImage("Grid"));
            ucControlAbout2.Init("XtraReports", DemoProducts.Reports, ElementHelper.GetAboutPageImage("Reports"));
            ucControlAbout3.Init("XtraCharts", DemoProducts.Charts, ElementHelper.GetAboutPageImage("Charts"));
            ucControlAbout4.Init("XtraPivotGrid", DemoProducts.Pivot, ElementHelper.GetAboutPageImage("PivotGrid"));
            ucControlAbout5.Init("XtraScheduler", DemoProducts.Scheduler, ElementHelper.GetAboutPageImage("Scheduler"));
            esiCaption.Width = Width;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            foreach(Control ctrl in lcAbout.Controls) {
                if(ctrl is HotLabel)
                    ((HotLabel)ctrl).UpdateColors();
                ctrl.Font = new Font("Segoe UI", ctrl.Font.Size, ctrl.Font.Style);
            }
        }
    }
}
