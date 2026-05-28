Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraLayout.Demos

    Friend Module Program

        <STAThread>
        Sub Main()
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                WindowsFormsSettings.SetDPIAware()
            End If

            WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True
            UserSkins.BonusSkins.Register()
            Call Application.EnableVisualStyles()
            Call WindowsFormsSettings.ForcePaintApiDiagnostics(DevExpress.Utils.Diagnostics.PaintApiDiagnosticsLevel.Disable)
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New frmMain())
        End Sub
    End Module
End Namespace
