using System;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Skins.Info;
using DevExpress.WindowsMailClient.Win.Utils;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraEditors;

namespace DevExpress.WindowsMailClient.Win {
    static class Program {
        const string AppName = "DevExpress.WindowsMailClient.Win";
        
        [STAThread]
        static void Main() {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            ExternalAssemblies.ResolveFromSpecificFolderIfRequired();
            bool exit;
            using(DevAVDataDirectoryHelper.SingleInstanceApplicationGuard(AppName, out exit)) {
                if(exit)
                    return;
            }
            
            if(!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                WindowsFormsSettings.SetDPIAware();
            RegisterSkin();
            SetSkinPalette();
            
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch;
            WindowsFormsSettings.CustomizationFormSnapMode = DevExpress.Utils.Controls.SnapMode.OwnerControl;
            WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainFormHelper.InitTakeScreen(DevExpress.Data.Utils.SafeEnvironment.GetCommandLineArgs());
            using(new StartUpProcess()) {
                using(StartUpProcess.Status.Subscribe(new DemoStartUp())) {
                    Application.Run(new MainForm());
                }
            }
        }
        static void SetSkinPalette() {
            UserLookAndFeel.Default.SetSkinStyle("fluentmailclient");
            var skin = CommonSkins.GetSkin(WindowsFormsSettings.DefaultLookAndFeel);
            DevExpress.Utils.Svg.SvgPalette palette = skin.CustomSvgPalettes["Default"];
            skin.SvgPalettes[Skin.DefaultSkinPaletteName].SetCustomPalette(palette);
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }
        static void RegisterSkin() {
            string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
            string fluentMailClientSkinDataPath = string.Format("{0}.SkinData.fluentmailclient.fluentmailclient.SkinData.", assemblyName);
            SkinBlobXmlCreator skinCreator = new SkinBlobXmlCreator("fluentmailclient", fluentMailClientSkinDataPath, typeof(Program).Assembly, null);
            SkinManager.Default.RegisterSkin(skinCreator);
            XtraSplashScreen.SplashScreenManager.RegisterUserSkin(skinCreator);
            FluentDesignFormCompatibleSkins.Skins.Add("fluentmailclient");
        }
    }
}
