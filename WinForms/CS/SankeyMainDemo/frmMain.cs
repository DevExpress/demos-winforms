using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraCharts.Sankey;
using DevExpress.XtraEditors;

namespace DevExpress.XtraSankey.Demos {
    public class frmMain : RibbonMainForm {
        protected override string DemoName {
            get { return "WinForms Sankey Diagram"; }
        }
        protected override string ProductName {
            get { return "XtraSankey"; }
        }
        protected override void ShowAbout() {
            SankeyDiagramControl.About();
        }
        public override bool UseEmptyRootPadding {
            get { return true; }
        }
        protected override void SetFormParam() {
            this.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraSankey.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel) {
            DemosInfo.DoShowModule(name, group, RibbonMenuManager);
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
    }    
}
