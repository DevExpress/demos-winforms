using DevExpress.LookAndFeel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace DevExpress.XtraBars.Demos.DockingDemo {
    static class Program {
        [STAThread]
        static void Main(string[] args) {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            if(!System.Windows.Forms.SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool isBarDemo = false;
            if(args.Length != 0) 
                isBarDemo = (args[0] == "-barDemo");
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            if(isBarDemo) DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.Bezier.VSLight);
            else DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.Bezier.VSBlue);
            var splashScreenImage = DevExpress.Utils.ResourceImageHelper.CreateImageFromResourcesEx("DockingDemo.Resources.SplashScreenNew.png", CurrentAssembly);
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowImage(splashScreenImage, true, false);
            Application.Run(new frmMain());
        }
        static Assembly currentAssemblyCore;
        static Assembly CurrentAssembly {
            get {
                if(currentAssemblyCore == null)
                    currentAssemblyCore = Assembly.GetExecutingAssembly();
                return currentAssemblyCore;
            }
        }
        internal static List<Stream> CreateResourceStreams() {
            List<Stream> fileStreams = new List<Stream>();
            fileStreams.Add(DevExpress.Utils.ResourceImageHelper.FindStream("DockingDemo.Resources.ProgramText.rtf", CurrentAssembly));
            fileStreams.Add(DevExpress.Utils.ResourceImageHelper.FindStream("DockingDemo.Resources.ProgramText2.rtf", CurrentAssembly));
            fileStreams.Add(DevExpress.Utils.ResourceImageHelper.FindStream("DockingDemo.Resources.ProgramText3.rtf", CurrentAssembly));
            return fileStreams;
        }
        internal static Stream GetDocumentStream(string fileName) {
            return DevExpress.Utils.ResourceImageHelper.FindStream(string.Format("DockingDemo.Resources.{0}.rtf", fileName), CurrentAssembly);
        }
    }
}
