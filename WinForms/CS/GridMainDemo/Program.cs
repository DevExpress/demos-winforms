using System;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.Tutorials;
using DevExpress.Utils.DirectXPaint;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraGrid.Demos {
    static class Program {
        [STAThread]
        static void Main(string[] arguments) {
            System.Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory);
            System.Runtime.ProfileOptimization.StartProfile("Startup.Profile");
            FilePathUtils.ResolveAssembliesFromSpecificFolderIfRequired();
            if(!System.Windows.Forms.SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();
            DevExpress.XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.InvertHorizontalScrolling = DevExpress.Utils.DefaultBoolean.True;
            DevExpress.XtraEditors.WindowsFormsSettings.KeyboardNavigationExtensions = XtraEditors.KeyboardNavigationExtensions.ColumnHeaders;
            RegisterCustomFunctions();
            RepositoryItemTextEdit.MaxToolTipTextLength = 1000;
            DirectXDeviceManager.Default.DeviceLimit = 10;
            CultureInfo demoCI = (CultureInfo)Application.CurrentCulture.Clone();
            demoCI.NumberFormat.CurrencySymbol = "$";
            demoCI.NumberFormat.CurrencyDecimalDigits = 2;
            Application.CurrentCulture = demoCI;
            DevExpress.UserSkins.BonusSkins.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain(arguments));
        }
        // Custom Functions
        static void RegisterCustomFunctions() {
            NotBeginsWithFunction.Register();
            IsBlackFridayDiscountFunction.Register();
            DaysBeforeOrAfterTodayFunction.Register();
            IsWeekendFunction.Register();
            CriteriaOperator.QueryCustomFunctions += OnQueryCustomUIFunctions;
        }
        static void OnQueryCustomUIFunctions(object sender, CustomFunctionEventArgs e) {
            if(e.PropertyType == typeof(string))
                e.Add(NotBeginsWithFunction.FunctionName);
        }
    }
}
