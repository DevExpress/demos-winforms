using System;
using System.Windows.Forms;
using DevExpress.Tutorials;

namespace DevExpress.XtraScheduler.Demos {
    static class Program {
        public const bool OptUseAsyncMode = true;
        [STAThread]
        static void Main() {
            FilePathUtils.ResolveAssembliesFromSpecificFolderIfRequired();
            if(!System.Windows.Forms.SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            SchedulerDemoLogify.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            Application.Run(new frmMain());
        }
    }
}
