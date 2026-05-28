Imports System
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports DevExpress.XtraSplashScreen

Namespace PhotoViewer

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If

            DevExpress.XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True
            SplashScreenManager.ShowForm(GetType(PhotoViewerSplashScreen))
            Call BonusSkins.Register()
            Call SkinManager.EnableFormSkins()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New MainForm())
        End Sub
    End Module
End Namespace
