using System;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.Utils.DirectXPaint;
using DevExpress.XtraEditors;

namespace DevExpress.XtraPivotGrid.Demos {
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
            DevExpress.XtraEditors.WindowsFormsSettings.InvertHorizontalScrolling = DevExpress.Utils.DefaultBoolean.True;
            RegisterCustomFunctions();
            DirectXDeviceManager.Default.DeviceLimit = 10;
            WindowsFormsSettings.CustomizationFormSnapMode = DevExpress.Utils.Controls.SnapMode.All;
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Fluent;
            DevExpress.UserSkins.BonusSkins.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
        static void RegisterCustomFunctions() {
            NotBeginsWithFunction.Register();
            IsBlackFridayFunction.Register();
            IsWeekendFunction.Register();
            CriteriaOperator.QueryCustomFunctions += OnQueryCustomUiFunction;
        }
        static void OnQueryCustomUiFunction(object sender, DevExpress.Data.Filtering.CustomFunctionEventArgs e) {
            if(e.PropertyType == typeof(string))
                e.Add(NotBeginsWithFunction.FunctionName);
        }
    }
}
