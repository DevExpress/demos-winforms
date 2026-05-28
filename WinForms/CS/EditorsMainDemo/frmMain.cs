using System;
using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Tutorials;
using DevExpress.Utils;

namespace DevExpress.XtraEditors.Demos {
    public partial class frmMain : RibbonMainForm {
        protected override string DemoName {
            get { return "WinForms Data Editors and Controls"; }
        }
        protected override string ProductName {
            get { return "XtraEditors"; }
        }
        protected override SourceFileType FileType {
            get { return DemoHelper.GetSourceFileType(); }
        }
		protected override void SetFormParam() {
			Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraEditors.Demos.AppIcon.ico", typeof(frmMain).Assembly);
		}
        protected override bool CanUseEmptyRootPadding(string name) {
            if(name.StartsWith("SvgImage Box")) return true;
            if(name.StartsWith("Memo Edit")) return true;
            return base.CanUseEmptyRootPadding(name);
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        protected override void ShowModule(string name, GroupControl group, DefaultLookAndFeel lookAndFeel) {
            DemosInfo.ShowModule(name, group, RibbonMenuManager);
        }
        protected override void ShowAbout() {
            BaseEdit.About();
        }
        protected override void OnLoad(object sender, EventArgs e) {
            base.OnLoad(sender, e);
            InitRibbonPageGroupsMergeOrder();
        }
        void InitRibbonPageGroupsMergeOrder() {
            if(ribbonControl1 == null) return;
            foreach(XtraBars.Ribbon.RibbonPage page in ribbonControl1.Pages) {
                foreach(XtraBars.Ribbon.RibbonPageGroup group in page.Groups) {
                    group.MergeOrder = page.Groups.IndexOf(group);
                }
            }
        }
    }
}
