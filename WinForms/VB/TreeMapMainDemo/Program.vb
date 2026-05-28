Imports System
Imports System.Windows.Forms
Imports DevExpress.Security.Resources

Namespace DevExpress.XtraTreeMap.Demos

    Friend Module Program

        <STAThread>
        Sub Main()
            AccessSettings.StaticResources.SetRules(DirectoryAccessRule.Allow(GetRelativeDirectoryPath("")))
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If

            UserSkins.BonusSkins.Register()
            Call Application.Run(New frmMain())
        End Sub
    End Module
End Namespace
