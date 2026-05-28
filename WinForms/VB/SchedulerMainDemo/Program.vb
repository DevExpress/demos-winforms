Imports System
Imports System.Windows.Forms
Imports DevExpress.Tutorials

Namespace DevExpress.XtraScheduler.Demos

    Friend Module Program

        Public Const OptUseAsyncMode As Boolean = True

        <STAThread>
        Sub Main()
            Call FilePathUtils.ResolveAssembliesFromSpecificFolderIfRequired()
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If

            XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True
            Call SchedulerDemoLogify.Register()
            UserSkins.BonusSkins.Register()
            Call Application.Run(New frmMain())
        End Sub
    End Module
End Namespace
