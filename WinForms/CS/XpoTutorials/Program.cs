using System;
using System.Windows.Forms;
using DevExpress.Xpo.DB;

namespace DevExpress.Xpo.Demos {
    static class Program {
        [STAThread]
        static void Main() {
            if(!System.Windows.Forms.SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.UseUIAutomation = Utils.DefaultBoolean.True;
            DevExpress.UserSkins.BonusSkins.Register();
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(InMemoryDataStore.GetConnectionString("XpoTutorials.xml"), AutoCreateOption.DatabaseAndSchema);
            Application.Run(new frmMain());
        }
    }
}
