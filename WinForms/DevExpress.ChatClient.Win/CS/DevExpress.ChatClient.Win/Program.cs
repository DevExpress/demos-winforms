using System;
using System.Windows.Forms;
using DevExpress.Internal;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.ChatClient {
    static class ChatClient {
        public static SvgImageCollection SvgImages {
            get;
        }
        static ChatClient() {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            ExternalAssemblies.ResolveFromSpecificFolderIfRequired();
            if(!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            WindowsFormsSettings.EnableFormSkins();
            WindowsFormsSettings.ForceDirectXPaint();
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Fluent;
            WindowsFormsSettings.FontBehavior = WindowsFormsFontBehavior.ForceSegoeUI;
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(DevExpress.LookAndFeel.SkinStyle.Bezier, DevExpress.LookAndFeel.SkinSvgPalette.Bezier.Default);
            SvgImages = SvgImageCollection.FromResources("DevExpress.ChatClient.Resources.Svg", typeof(ChatClient).Assembly);
            RegisterAppServices();
            DevAVDataDirectoryHelper.LocalPrefix = "WinChatClientApp";
        }
        static void RegisterAppServices() {
            Services.AppSettigns.Register();
            Func<DevAV.DevAVDb> createDB =
#if NET
                () => new DevAV.DevAVDb(string.Format("Data Source={0}", GetDatabaseFilePath()));
#else
                () => new DevAV.DevAVDb();
#endif
            var messageServer = new DevAV.Chat.DevAVEmpployeesInMemoryServer(createDB);
            Mvvm.ServiceContainer.Default.RegisterService(messageServer);
        }
#if NET
        static string GetDatabaseFilePath() {
            var filePath = DevAVDataDirectoryHelper.GetFile("devav.sqlite3");
            try {
                var attributes = System.IO.File.GetAttributes(filePath);
                if(attributes.HasFlag(System.IO.FileAttributes.ReadOnly)) 
                    System.IO.File.SetAttributes(filePath, attributes & ~System.IO.FileAttributes.ReadOnly);
            }
            catch { }
            return filePath;
        }
#endif
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var messenger = new Messenger();
            messenger.IconOptions.SvgImage = SvgImages["AppIcon"];
            Application.Run(messenger);
        }
    }
}
