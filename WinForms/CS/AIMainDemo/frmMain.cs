using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraTreeList;
using System;
using System.Drawing;

namespace DevExpress.AI.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm  {
        public frmMain()
            : base() {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(GridControl).TypeHandle);
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(typeof(TreeList).TypeHandle);
        }
        protected override void SetFormParam() {
            Icon = Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.AI.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }   
        protected override string ProductName {
            get { return "AI"; }
        }
        protected override string DemoName {
            get { return "WinForms AI-powered Extensions"; }
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
#if !NET
        protected override void RegisterDemos() {
            DXperience.Demos.MainFormRegisterDemoHelper.RegisterDemos(
                x => x.Group != DemoData.Model.Repository.WinAIChatControlGroupName
                && x.Group != DemoData.Model.Repository.WinAgentsApiGroupName);
        }
#endif
    }
}
