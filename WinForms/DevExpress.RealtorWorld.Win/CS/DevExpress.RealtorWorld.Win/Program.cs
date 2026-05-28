using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.Internal;
using DevExpress.Skins;
using DevExpress.Skins.Info;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraSplashScreen;

namespace DevExpress.RealtorWorld.Win {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
#if !NET
            DataDirectoryHelper.SetWebBrowserMode();
#endif
            if(!System.Windows.Forms.SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.ApplyDemoSettings();
            SkinManager.EnableFormSkins();
            UserSkins.BonusSkins.Register();
            AppearanceObject.DefaultFont = new Font("Segoe UI", 8.25f);
            SkinBlobXmlCreator skinCreator = new SkinBlobXmlCreator("MetroBlack",
                "DevExpress.RealtorWorld.Win.SkinData.", typeof(Program).Assembly, null);
            SkinManager.Default.RegisterSkin(skinCreator);
            AsyncAdornerBootStrapper.RegisterLookAndFeel(
                "MetroBlack", "DevExpress.RealtorWorld.Win.SkinData.", typeof(Program).Assembly);
            LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Metropolis");
            CultureInfo demoCI = (CultureInfo)Application.CurrentCulture.Clone();
            demoCI.NumberFormat.CurrencySymbol = "$";
            SplashScreenManager.RegisterUserSkin(skinCreator);
            Application.CurrentCulture = demoCI;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DataHelper.CreateWmiService();
            Application.Run(new frmMain());
        }
    }
    interface IMainForm {
        void ShowHome(Home home);
        void ShowAgent(Agent agent);
    }
}
