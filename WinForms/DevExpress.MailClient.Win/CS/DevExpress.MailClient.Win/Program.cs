using System;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos;
using DevExpress.MailClient.Win.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace DevExpress.MailClient.Win {
    static class Program {
        [STAThread]
        static void Main(string[] arguments) {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            Internal.ExternalAssemblies.ResolveFromSpecificFolderIfRequired();
            if(!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            DataHelper.ApplicationArguments = arguments;
            DevExpress.UserSkins.BonusSkins.Register();
            SkinManager.EnableFormSkins();
            EnumProcessingHelper.RegisterEnum<TaskStatus>();
            UnpackHelper.Unpack();
            //
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainFormHelper.InitTakeScreen(DevExpress.Data.Utils.SafeEnvironment.GetCommandLineArgs());
            if(!MainFormHelper.TakeScreens) {
                using(var landSelector = new LanguageSelectorForm()) {
                    if(landSelector.ShowDialog() != DialogResult.OK)
                        return;
                }
                SplashScreenManager.ShowForm(null, typeof(ssMain), true, true, false, 1);
            }
            Application.Run(new frmMain());
        }
    }
}
