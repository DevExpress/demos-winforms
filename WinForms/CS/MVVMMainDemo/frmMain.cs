namespace DevExpress.MVVM.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        protected override void SetFormParam() {
            Icon = Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.MVVM.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string ProductName {
            get { return "MVVM"; }
        }
        protected override string DemoName { 
            get { return "DevExpress MVVM Framework"; } 
        }
        protected override void ShowAbout() {
            Utils.MVVM.MVVMContext.About();
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        protected override void ShowModule(string name, XtraEditors.GroupControl group, LookAndFeel.DefaultLookAndFeel lookAndFeel) {
            DemosInfo.ShowModule(name, group, RibbonMenuManager);
        }
        protected override void FillNavBar() {
            DXperience.Demos.ModulesInfo.FillAccordionControl(accordionControl1, XtraNavBar.NavBarGroupStyle.SmallIconsList, true, XtraNavBar.NavBarImage.Large);
        }
    }
}
