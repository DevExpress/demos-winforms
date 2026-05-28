using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Tutorials;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.Utils.Frames;
using DevExpress.XtraGauges.Win;

namespace DevExpress.XtraGauges.Demos {
    public class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        bool showOutdated = true;
        public frmMain(string[] arguments)
            : base(arguments) {
            ToolTipController.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            foreach(string _name in arguments)
                if(_name == "-demo") showOutdated = false;
        }
        protected override string DemoName {
            get { return "WinForms Gauge and Indicators"; }
        }
        protected override string ProductName {
            get { return "XtraGauges"; }
        }
        protected override SourceFileType FileType {
            get { return DemoHelper.GetSourceFileType(); }
        }
        protected override void ShowAbout() {
            GaugeControl.About();
        }
        protected override void SetFormParam() {
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraGauges.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new GaugesRibbonMenuManager(this);
        }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DefaultLookAndFeel lookAndFeel) {
            DemosInfo.ShowModule(name, group, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText, showOutdated);
        }
        protected override bool SupportAdvancedTitlePainting { get { return false; } }
    }
}
