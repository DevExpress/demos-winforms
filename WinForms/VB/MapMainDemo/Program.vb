Imports System
Imports System.Windows.Forms
Imports DevExpress.Security.Resources

Namespace DevExpress.XtraMap.Demos

    Friend Module Program

        <STAThread>
        Sub Main()
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            AccessSettings.StaticResources.SetRules(DirectoryAccessRule.Allow(DemoUtils.GetRelativeDirectoryPath("")))
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If

            XtraEditors.WindowsFormsSettings.UseUIAutomation = Utils.DefaultBoolean.True
            UserSkins.BonusSkins.Register()
            Call Application.Run(New frmMain())
        End Sub
    End Module
End Namespace
