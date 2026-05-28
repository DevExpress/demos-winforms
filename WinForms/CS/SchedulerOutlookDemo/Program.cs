using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using System;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
    static class Program {
        [STAThread]
        static void Main() {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            if(!System.Windows.Forms.SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.UseUIAutomation = DefaultBoolean.True;
            XtraEditors.WindowsFormsSettings.UseDXDialogs = DefaultBoolean.True;
            XtraEditors.WindowsFormsSettings.AllowSkinEditorAttach = DevExpress.Utils.DefaultBoolean.True;
            Application.Run(new frmMain());
        }
    }
}
