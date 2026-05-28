using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraBars;

namespace DevExpress.XtraMap.Demos {
    public partial class frmMain : RibbonMainForm {
        #region Properties
        new internal BarSubItem ExportToImageExButton {
            get { return base.ExportToImageExButton; }
        }
        protected override string DemoName {
            get { return "WinForms Map Control"; }
        }
        protected override string ProductName {
            get { return "XtraMap"; }
        }
        #endregion
        protected override void WndProc(ref Message msg) {
            if(OverlapFlickeringSolver.ShouldDoWndProc(msg))
                base.WndProc(ref msg);
        }
        protected override void ShowAbout() {
            MapControl.About();
        }
        protected override void SetFormParam() {
            Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraMap.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }
        protected override RibbonMenuManager CreateRibbonMenuManager() {
            return new RibbonMenuManager(this);
        }
        protected override void ShowModule(string name, XtraEditors.GroupControl groupControl, LookAndFeel.DefaultLookAndFeel lookAndFeel) {
            DemosInfo.DoShowModule(name, groupControl, RibbonMenuManager);
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        protected override int TestTimerInterval {
            get { return 4500; }
        }
        protected override bool CanUseEmptyRootPadding(string name) {
            ModuleInfo info = ModulesInfo.GetItem(name);
            if(info != null && info.TModule is MapTutorialControl)
                return ((MapTutorialControl)info.TModule).UseEmptyRootPadding;
            return base.CanUseEmptyRootPadding(name);
        }
    }

    static class OverlapFlickeringSolver {
        readonly static bool isWin7 = Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor == 1;
        static bool isFilteringEnabled = false;
        //
        [System.Security.SecurityCritical]
        public static bool ShouldDoWndProc(Message message) {
            return !isWin7 || !isFilteringEnabled || (message.Msg != 0x3 && message.Msg != 0x47);
        }
        public static void Refresh(Form backgroundForm) {
            if(!isWin7)
                return;
            try {
                isFilteringEnabled = true;
                Type safeNativeMethodsType = Data.Internal.SafeTypeResolver.GetKnownType(typeof(Form).Assembly, "System.Windows.Forms.SafeNativeMethods", false);
                if(safeNativeMethodsType != null) {
                    object parentNativeWindow = DevExpress.Utils.Helpers.NativeField<Control>.Ensure("window").GetValue(backgroundForm);
                    HandleRef parent = new HandleRef(parentNativeWindow, backgroundForm.Handle);
                    HandleRef zero = new HandleRef(null, IntPtr.Zero);
                    System.Reflection.MethodInfo setWindowPos = safeNativeMethodsType.GetMethod("SetWindowPos");
                    setWindowPos.Invoke(null, new object[] { parent, zero, backgroundForm.Left + 1, backgroundForm.Top, 0, 0, 0x441 });
                    setWindowPos.Invoke(null, new object[] { parent, zero, backgroundForm.Left, backgroundForm.Top, 0, 0, 0x441 });
                }
                Application.DoEvents();
            }
            catch { }
            finally { isFilteringEnabled = false; }
        }
    }
}
