using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;

namespace DevExpress.DevAV {
    internal static class Program {
        [STAThread]
        static void Main() {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            ExternalAssemblies.ResolveFromSpecificFolderIfRequired();
            DevAVDataDirectoryHelper.LocalPrefix = "WinHybridApp";
            
            bool exit;
            using(IDisposable singleInstanceApplicationGuard = DevAVDataDirectoryHelper.SingleInstanceApplicationGuard("DevExpressWinHybridApp", out exit)) {
                if(exit && IsTablet)
                    return;
                if(!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                    XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
                else
                    XtraEditors.WindowsFormsSettings.SetDPIAware();
                DevExpress.XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
                DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
                DevExpress.XtraEditors.WindowsFormsSettings.ForceDirectXPaint();
                DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = Utils.DefaultBoolean.True;
                DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = XtraEditors.ScrollUIMode.Touch;
                
                float appFontSize = 11f;
                Font appFont = new Font("Segoe UI", appFontSize);
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = appFont;
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultMenuFont = appFont;
                
                Application.CurrentCulture = CultureInfo.GetCultureInfo("en-us");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                
                MainFormHelper.InitTakeScreen(DevExpress.Data.Utils.SafeEnvironment.GetCommandLineArgs());
                MainForm = new DevAV.MainForm {
                    Icon = AppIcon
                };
                if(IsTablet)
                    SetupAsTablet();
                Application.Run(MainForm);
            }
        }
        
        static bool? isTablet = null;
        public static bool IsTablet {
            get {
                if(isTablet == null) {
                    
#if !NET
                    isTablet = DevExpress.DevAV.Common.Utils.DeviceDetector.IsTablet;
#else
                    isTablet = false;
#endif
                }
                return isTablet.Value;
            }
        }
        public static Icon AppIcon {
            get { return DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.DevAV.Resources.AppIcon.ico", typeof(MainForm).Assembly); }
        }
        public static MainForm MainForm {
            get;
            private set;
        }
        public static void SetupAsTablet() {
            MainForm.ShowTileNavPane();
            MainForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MainForm.WindowState = FormWindowState.Maximized;
            DevExpress.XtraEditors.WindowsFormsSettings.PopupMenuStyle = XtraEditors.Controls.PopupMenuStyle.RadialMenu;
            DevExpress.Utils.TouchHelpers.TouchKeyboardSupport.EnableTouchKeyboard = true;
        }
    }
}
