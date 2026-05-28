using System;
using System.Windows.Forms;

namespace DevExpress.SalesDemo.Win {
    static class Program {
        
        
        
        [STAThread]
        static void Main() {
            XtraEditors.WindowsFormsSettings.UseUIAutomation = Utils.DefaultBoolean.True;
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2013");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
