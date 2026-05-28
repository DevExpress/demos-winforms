using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraTreeMap.Demos {
    public class frmMain : RibbonMainForm {
        protected override string DemoName {
            get { return "WinForms Heatmap, TreeMap & Sunburst"; }
        }
        protected override string ProductName {
            get { return "XtraTreeMap"; }
        }
        protected override void ShowAbout() {
            TreeMapControl.About();
        }
        public override bool UseEmptyRootPadding {
            get { return true; }
        }
        protected override void SetFormParam() {
            Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraTreeMap.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel) {
            DemosInfo.DoShowModule(name, group, RibbonMenuManager);
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
    }
}
