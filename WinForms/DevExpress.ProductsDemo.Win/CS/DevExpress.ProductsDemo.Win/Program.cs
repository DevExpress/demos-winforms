using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos;
using DevExpress.MailClient.Win;
using DevExpress.MailDemo.Win;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace DevExpress.ProductsDemo.Win {
    static class Program {
        [STAThread]
        static void Main(string[] arguments) {
            if(!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                WindowsFormsSettings.SetPerMonitorDpiAware();
            else WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            AppHelper.WarmUp();
            WindowsFormsSettings.ApplyDemoSettings();
            DataHelper.ApplicationArguments = arguments;
            System.Globalization.CultureInfo enUs = new System.Globalization.CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = enUs;
            System.Threading.Thread.CurrentThread.CurrentUICulture = enUs;
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Utils.AppearanceObject.DefaultFont = new Font("Segoe UI", 8);
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");
            SkinManager.EnableFormSkins();
            EnumProcessingHelper.RegisterEnum<TaskStatus>();
            EnumProcessingHelper.RegisterEnum(typeof(TaskStatus), "DevExpress.ProductsDemo.Win.TaskStatus");
            MainFormHelper.InitTakeScreen(DevExpress.Data.Utils.SafeEnvironment.GetCommandLineArgs());
            if(!MainFormHelper.TakeScreens)
                SplashScreenManager.ShowSkinSplashScreen(Tutorials.ucOverviewPage.GetSVGLogoImage(), "Build Your Own Office");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
