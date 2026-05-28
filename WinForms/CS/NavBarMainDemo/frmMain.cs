using System.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Tutorials;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraNavBar.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        bool showOutdated = false;
        public frmMain(string[] arguments) : base(arguments) {
            ToolTipController.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            DataHelper.LoadMessagesAsync();
        }
        protected override string DemoName {
            get { return "WinForms Navigation Bar"; }
        }
        protected override string ProductName {
            get { return "Navigation Bar"; }
        }
        protected override SourceFileType FileType {
            get { return DXperience.Demos.DemoHelper.GetSourceFileType(); }
        }
        protected override void ShowAbout() {
            DevExpress.XtraBars.BarManager.About();
        }
        protected override bool CanUseEmptyRootPadding(string name) {
            if(name.Contains("Hamburger")) return true;
            return base.CanUseEmptyRootPadding(name);
        }
        protected override void SetFormParam() {
            this.MinimumSize = new Size(800, 600);
            this.Icon = ResourceImageHelper.CreateIconFromResourcesEx("NavBarMainDemo.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel) {
            DemosInfo.ShowModule(name, group, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            ModulesInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText, showOutdated);
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
    }
}
