Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.XtraBars.Demos.RibbonSimplePad

    Friend Module Program

        <STAThread>
        Sub Main()
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                Call WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                Call WindowsFormsSettings.SetDPIAware()
            End If

            WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True
            UserSkins.BonusSkins.Register()
            Skins.SkinManager.EnableFormSkins()
            WindowsFormsSettings.DefaultRibbonStyle = DefaultRibbonControlStyle.Office365
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call SplashScreenManager.ShowForm(CType(Nothing, Form), GetType(RibbonSimplePadSplashScreen), True, True)
            Call Application.Run(New frmMain())
        End Sub
    End Module
End Namespace
