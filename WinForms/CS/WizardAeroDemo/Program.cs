using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils.Drawing.Helpers;

namespace DevExpress.XtraWizard.Demos {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            if(!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                XtraEditors.WindowsFormsSettings.SetDPIAware();
            XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.UserSkins.BonusSkins.Register();
            if(!NativeVista.IsVista)
                DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmStart frm = new frmStart();
            frm.ShowDialog();
            if(!DevExpress.Skins.SkinManager.AllowFormSkins)
                DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.Run(new frmMain());
        }
    }
}
