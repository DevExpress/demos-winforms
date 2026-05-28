using DevExpress.DXperience.Demos;
using DevExpress.Utils;

namespace DevExpress.XtraRichEdit.Demos {
    public partial class frmMain : RibbonMainForm {
        protected override string DemoName {
            get { return "WinForms Word Processing (RTF)"; }
        }
        protected override string ProductName {
            get { return "XtraRichEdit"; }
        }
        protected override void ShowAbout() {
            RichEditControl.About();
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        protected override void SetFormParam() {
            Icon = ResourceImageHelper.CreateIconFromResources("DevExpress.XtraRichEdit.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override void ShowModule(string name, XtraEditors.GroupControl groupControl, LookAndFeel.DefaultLookAndFeel lookAndFeel) {
            DemosInfo.DoShowModule(name, groupControl, RibbonMenuManager);
        }
    }
}
