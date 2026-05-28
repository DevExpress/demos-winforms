using DevExpress.DXperience.Demos;
using DevExpress.Utils;

namespace DevExpress.XtraSpreadsheet.Demos {
    public partial class frmMain : DevExpress.DXperience.Demos.RibbonMainForm {
        public frmMain() {
            XtraEditors.WindowsFormsSettings.UseDXDialogs = DevExpress.Utils.DefaultBoolean.True;
        }
        protected override string DemoName {
            get { return "WinForms Spreadsheet"; }
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        protected override void ShowAbout() {
            SpreadsheetControl.About();
        }
        protected override string ProductName {
            get { return "XtraSpreadsheet"; }
        }
        protected override void SetFormParam() {
            Icon = ResourceImageHelper.CreateIconFromResources("DevExpress.XtraSpreadsheet.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new SpreadsheetRibbonMenuManager(this);
        }
        protected override void ShowModule(string name, XtraEditors.GroupControl groupControl, LookAndFeel.DefaultLookAndFeel lookAndFeel) {
            DemosInfo.DoShowModule(name, groupControl, RibbonMenuManager as SpreadsheetRibbonMenuManager);
        }
        protected override void InitCurrentRibbon() {
            base.InitCurrentRibbon();
            if(RibbonControl != null)
                RibbonControl.AutoHideEmptyItems = true;
        }
    }

    public class SpreadsheetRibbonMenuManager : RibbonMenuManager {
        public SpreadsheetRibbonMenuManager(RibbonMainForm form)
            : base(form) {
        }
    }
}
