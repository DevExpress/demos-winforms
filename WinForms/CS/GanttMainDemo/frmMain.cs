using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Tutorials;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGantt.Demos {
    public class frmMain : RibbonMainForm {
        public frmMain(string[] arguments) : base(arguments) {
            GetStartedLink = AssemblyInfo.DXLinkGetStarted;
            ToolTipController.DefaultController.ToolTipType = ToolTipType.SuperTip;
        }
        public override bool UseEmptyRootPadding {
            get { return true; }
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        protected override string ProductName {
            get { return "XtraGantt"; }
        }
        protected override string DemoName {
            get { return Properties.Resources.DemoName; }
        }
        protected override SourceFileType FileType {
            get { return DemoHelper.GetSourceFileType(); }
        }
        protected override void ShowAbout() {
            GanttControl.About();
        }
        protected override void SetFormParam() {
            this.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraGantt.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new GanttRibbonMenuManager(this);
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel) {
            DemosInfo.ShowModule(name, group, RibbonMenuManager as GanttRibbonMenuManager);
        }
    }
}
