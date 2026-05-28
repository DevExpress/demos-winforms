namespace DevExpress.XtraDialogs.Demos {
    using DevExpress.XtraEditors;

    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm  {
        protected override void SetFormParam() {
            Icon = Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraDialogs.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string ProductName {
            get { return "Xtra Dialogs"; }
        }
        protected override string DemoName {
            get { return "Dialogs Demo (C# code)"; }
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
        protected override bool CanUseEmptyRootPadding(string name) {
            return true;
        }
        protected override void ShowAbout() {
            BaseEdit.About();
        }
    }
}
