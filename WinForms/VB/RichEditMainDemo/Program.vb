Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraRichEdit.Demos

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
            WindowsFormsSettings.UseDXDialogs = DevExpress.Utils.DefaultBoolean.True
            UserSkins.BonusSkins.Register()
            Call Application.Run(New frmMain())
        End Sub
    End Module
End Namespace
