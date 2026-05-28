using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DevExpress.XtraBars.Demos.TileControlDemo {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            if(!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                XtraEditors.WindowsFormsSettings.SetDPIAware();
            XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
