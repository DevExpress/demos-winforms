using System;
using System.Windows.Forms;
using DevExpress.Security.Resources;

namespace DevExpress.XtraTreeMap.Demos {
    static class Program {
        [STAThread]
        static void Main() {
            AccessSettings.StaticResources.SetRules(DirectoryAccessRule.Allow(Utils.GetRelativeDirectoryPath("")));
            if(!System.Windows.Forms.SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();

            DevExpress.UserSkins.BonusSkins.Register();
            Application.Run(new frmMain());
        }
    }
}
