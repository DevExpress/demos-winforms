using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Tutorials;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;

namespace DevExpress.XtraTreeList.Demos {
    public class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        protected override void SetFormParam() {
            this.Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraTreeList.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string DemoName {
            get { return "WinForms TreeList"; }
        }
        protected override SourceFileType FileType {
            get { return DemoHelper.GetSourceFileType(); }
        }
        protected override string ProductName {
            get { return "XtraTreeList"; }
        }
        protected override void ShowAbout() {
            TreeList.About();
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        public override bool UseEmptyRootPadding {
            get { return true; }
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new TreeListRibbonMenuManager(this);
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel) {
            DemosInfo.ShowModule(name, group, RibbonMenuManager as TreeListRibbonMenuManager);
        }
        protected override void FillNavBar() {
            DemosInfo.FillAccordionControl(accordionControl1, NavBarGroupStyle.SmallIconsText, true, NavBarImage.Large);
        }
    }
}
