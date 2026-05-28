Imports DevExpress.Utils
Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Friend Module Program

        <STAThread>
        Sub Main()
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If

            XtraEditors.WindowsFormsSettings.UseUIAutomation = DefaultBoolean.True
            XtraEditors.WindowsFormsSettings.UseDXDialogs = DefaultBoolean.True
            XtraEditors.WindowsFormsSettings.AllowSkinEditorAttach = DefaultBoolean.True
            Call Application.Run(New frmMain())
        End Sub
    End Module
End Namespace
