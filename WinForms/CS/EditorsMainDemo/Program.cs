using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevExpress.XtraEditors.Demos {
	static class Program {
		[STAThread]
		static void Main() {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            if(!System.Windows.Forms.SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
				DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
			else
				DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
			DevExpress.UserSkins.BonusSkins.Register();
			Application.Run(new frmMain());
		}

	}
}
