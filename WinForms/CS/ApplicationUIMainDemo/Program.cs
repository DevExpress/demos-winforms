using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace DevExpress.ApplicationUI.Demos {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            DevExpress.ApplicationUI.Demos.DataLoader.AllowDataDirectoryAccess();
            if(!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Utils.Taskbar.Core.TaskbarAssistantCore.Initialize();
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
            fileStreams.Add(DevExpress.Utils.ResourceImageHelper.FindStream("DevExpress.ApplicationUI.Demos.Resources.ucSolutionExplorer.rtf", CurrentAssembly));
            fileStreams.Add(DevExpress.Utils.ResourceImageHelper.FindStream("DevExpress.ApplicationUI.Demos.Resources.ucToolbox.rtf", CurrentAssembly));
            fileStreams.Add(DevExpress.Utils.ResourceImageHelper.FindStream("DevExpress.ApplicationUI.Demos.Resources.ucSolutionExplorer.rtf", CurrentAssembly));
            return fileStreams;
        }
        internal static Stream GetStream(string fileName) {
            return DevExpress.Utils.ResourceImageHelper.FindStream(String.Format("DevExpress.ApplicationUI.Demos.Resources.{0}", fileName), CurrentAssembly);
        }
    }
}
