using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraSpreadsheet.Demos {
    static class Program {
        [STAThread]
        static void Main() {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            if(!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            DemoUtils.SetDatabasePath();
            DevExpress.UserSkins.BonusSkins.Register();
            Application.Run(new frmMain());
        }
    }
}
