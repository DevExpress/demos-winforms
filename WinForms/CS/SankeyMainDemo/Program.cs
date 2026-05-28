using System;
using System.Windows.Forms;
using DevExpress.Security.Resources;

namespace DevExpress.XtraSankey.Demos {
	static class Program {
		[STAThread]
		static void Main() {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            AccessSettings.StaticResources.SetRules(DirectoryAccessRule.Allow(Utils.GetRelativeDirectoryPath("")));
            if(!System.Windows.Forms.SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
				DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
			else
				DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
			Utils.SetDatabasePath();
			DevExpress.UserSkins.BonusSkins.Register();
			Application.Run(new frmMain());
		}
	}
}
