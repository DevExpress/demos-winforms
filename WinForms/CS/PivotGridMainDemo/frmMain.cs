using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraPivotGrid.Demos {
    public class frmMain : RibbonMainForm {
        public frmMain() {
            gcDescription.HyperlinkClick += GcDescription_HyperlinkClick;
        }
        void GcDescription_HyperlinkClick(object sender, HyperlinkClickEventArgs e) {
            SafeProcess.Start(e.Link);
        }
        protected override void SetFormParam() {
            this.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string ProductName {
            get { return "XtraPivotGrid"; }
        }
        protected override void ShowModule(string name, XtraEditors.GroupControl group, LookAndFeel.DefaultLookAndFeel lookAndFeel, Control notePanel) {
            DemosInfo.Show(name, group, notePanel, RibbonMenuManager as PivotGridRibbonMenuManager);
        }
        protected override string DemoName {
            get { return "WinForms Pivot Grid"; }
        }
        protected override void FillNavBar() {
            DemosInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsText);
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new PivotGridRibbonMenuManager(this);
        }
        public override bool UseEmptyRootPadding {
            get { return true; }
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        protected override void ShowAbout() {
            PivotGridControl.About();
        }
    }
}
