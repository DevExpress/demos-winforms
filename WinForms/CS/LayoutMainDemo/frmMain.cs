using DevExpress.DXperience.Demos;
using DevExpress.Tutorials;
using DevExpress.XtraNavBar;

namespace DevExpress.XtraLayout.Demos {
    public class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        protected override void SetFormParam() {
            this.Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraLayout.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override SourceFileType FileType {
            get { return DemoHelper.GetSourceFileType(); }
        }
        protected override string DemoName {
            get { return "WinForms Automatic Form Layout Control"; }
        }
        protected override string ProductName {
            get { return "XtraLayoutControl"; }
        }
        protected override void ShowAbout() {
            LayoutControl.About();
        }
        public override bool UseEmptyRootPadding {
            get { return true; }
        }
        protected override void ShowModule(string name, XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel) {
            DemosInfo.ShowModule(name, group, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            DemosInfo.FillAccordionControl(accordionControl1, NavBarGroupStyle.SmallIconsList, true, NavBarImage.Large);
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
    }
}
