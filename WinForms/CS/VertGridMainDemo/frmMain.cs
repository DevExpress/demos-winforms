using DevExpress.DXperience.Demos;
using DevExpress.Tutorials;
using DevExpress.Utils;

namespace DevExpress.XtraVerticalGrid.Demos {
    public class frmMain : RibbonMainForm {
        protected override void SetFormParam() {
            this.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraVerticalGrid.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override string DemoName {
            get { return DemoHelper.GetFormText("The XtraVerticalGrid Suite by DevExpress"); }
        }
        protected override SourceFileType FileType {
            get { return DemoHelper.GetSourceFileType(); }
        }
        protected override string ProductName {
            get { return "XtraVerticalGrid"; }
        }
        protected override void ShowAbout() {
            VGridControl.About();
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new VGridRibbonMenuManager(this);
        }
        protected override void ShowModule(string name, DevExpress.XtraEditors.GroupControl group, DevExpress.LookAndFeel.DefaultLookAndFeel lookAndFeel) {
            DemosInfo.ShowModule(name, group, RibbonMenuManager as VGridRibbonMenuManager);
        }
        protected override void FillNavBar() {
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText, true, DevExpress.XtraNavBar.NavBarImage.Large);
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        protected override bool CanUseEmptyRootPadding(string name) {
            if(name == "PC Market" || name== "Vertical Grid")
                return true;
            return base.CanUseEmptyRootPadding(name);
        }
    }
}
