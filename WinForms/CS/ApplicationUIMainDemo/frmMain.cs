using DevExpress.DXperience.Demos;
using DevExpress.Tutorials;

namespace DevExpress.ApplicationUI.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        protected override void SetFormParam() {
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.ApplicationUI.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override SourceFileType FileType {
            get { return DemoHelper.GetSourceFileType(); }
        }
        protected override string DemoName { 
            get { return DemoHelper.GetFormText("Application UI Layout Controls Demo"); } 
        }
        protected override string ProductName { 
            get { return "ApplicationUI"; } 
        }
        protected override bool CanUseEmptyRootPadding(string name) {
            if(name == "Workspace Manager" || name == "Badges" || name == "Dock Panels" || name == "Sales Performance Widget View") 
                return true;
            return base.CanUseEmptyRootPadding(name);
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        protected override void ShowAbout() {
            XtraBars.Docking2010.DocumentManager.About();
        }
        protected override void ShowModule(string name, XtraEditors.GroupControl group, LookAndFeel.DefaultLookAndFeel lookAndFeel) {
            DemosInfo.ShowModule(name, group, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            ModulesInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsList, true, XtraNavBar.NavBarImage.Large);
        }
        protected override bool AllowBorderRounding {
            get { return false; }
        }
    }
}
