using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmStart frm = new frmStart();
            frm.ShowDialog();
            if(!frm.AllowSkin4Form) DevExpress.Skins.SkinManager.DisableFormSkins();
            Application.Run(new frmMain(frm.AllowAnimation, frm.WizardStyle));
        }
    }
}
