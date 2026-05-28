using System.Windows.Forms;
using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace DevExpress.XtraCharts.Demos {
    internal partial class frmMain : RibbonMainForm {
        protected override string DemoName {
            get { return "WinForms Chart Control"; }
        }
        protected override string ProductName {
            get { return "XtraCharts"; }
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        new internal BarSubItem ExportToImageExButton {
            get { return base.ExportToImageExButton; }
        }
        public override bool UseEmptyRootPadding {
            get { return true; }
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new ChartRibbonMenuManager(this);
        }
        protected override void SetFormParam() {
            Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraCharts.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel) {
            ChartDemoModule currentModule = DemosInfo.DoShowModule(name, group, RibbonMenuManager as ChartRibbonMenuManager);
            if(currentModule == null) return;
            ((ChartRibbonMenuManager)RibbonMenuManager).CurrentModule = currentModule;
            ((ChartRibbonMenuManager)RibbonMenuManager).UpdateMenu(currentModule.ChartDesignerEnabled, currentModule.PaletteButtonEnabled);
        }
        protected override IOverlaySplashScreenHandle ShowProgressPanel(Control owner, OverlayWindowOptions windowOptions = null) {
            return FrameworkVersions.IsFullFramework() ? base.ShowProgressPanel(owner, windowOptions) : null;
        }
        protected override void CloseProgressPanel(IOverlaySplashScreenHandle handle) {
            if(FrameworkVersions.IsFullFramework())
                base.CloseProgressPanel(handle);
        }
        protected override void ShowAbout() {
            ChartControl.About();
        }
        protected override int TestTimerInterval {
            get {
                return 4500;
            }
        }
        protected override bool AllowApplicationDoEventsOnShowModuleOnTest(ModuleInfo info) {
            return false;
        }
    }
}
