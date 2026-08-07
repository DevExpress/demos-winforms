using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DentalClinic.Model;
using DevExpress.DXperience.Demos;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Utils;
using DevExpress.Utils.MVVM;
using DevExpress.XtraLayout;
using DevExpress.XtraSplashScreen;

namespace DevExpress.DentalClinic {
    static class Program {
        [STAThread]
        static void Main() {
            DevExpress.Internal.ExternalAssemblies.ResolveFromSpecificFolderIfRequired();
            if(!SystemInformation.TerminalServerSession && Screen.AllScreens.Length > 1)
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware();
            else
                XtraEditors.WindowsFormsSettings.SetDPIAware();
            XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True;
            XtraEditors.WindowsFormsSettings.ForceDirectXPaint();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            MVVMContext.RegisterFlyoutDialogService();
            XtraMessageBoxServiceHelper.RegisterXtraMessageBoxService();
            XtraEditors.WindowsFormsSettings.LoadApplicationSettings();
            bool darkTheme = Properties.Settings.Default.DarkTheme;
            SplashScreenManager.ShowFluentSplashScreen(logoImageOptions: new ImageOptions() {
                SvgImage = Properties.Resources.DevExpress_Logo_Mono,
                SvgImageColorizationMode = SvgImageColorizationMode.None
            });
            ToolTipController.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            LayoutControl.AllowCustomizationDefaultValue = false;
            XtraEditors.WindowsFormsSettings.FilterCriteriaDisplayStyle = XtraEditors.FilterCriteriaDisplayStyle.Visual;
            RegisterEntities();
            // Initialize Data-Layer
#if RECREATE_DATA
            DataGenerator.Instance.RecreateData();
#endif
            Task rescheduleAppointments = InvoiceHelper.RescheduleAppointments();
            MainFormHelper.InitTakeScreen(DevExpress.Data.Utils.SafeEnvironment.GetCommandLineArgs());
            Application.Run(new MainForm(rescheduleAppointments));
        }
        static void RegisterEntities() {
            XpoTypesInfoHelper.GetXpoTypeInfoSource();
            XafTypesInfo.Instance.RegisterEntity(typeof(Doctor));
            XafTypesInfo.Instance.RegisterEntity(typeof(Employee));
            XafTypesInfo.Instance.RegisterEntity(typeof(EmployeeRole));
            XafTypesInfo.Instance.RegisterEntity(typeof(PermissionPolicyUser));
            XafTypesInfo.Instance.RegisterEntity(typeof(PermissionPolicyRole));
        }
    }
}
