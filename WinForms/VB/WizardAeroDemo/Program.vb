Imports System
Imports System.Windows.Forms
Imports DevExpress.Utils.Drawing.Helpers

Namespace DevExpress.XtraWizard.Demos

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If

            XtraEditors.WindowsFormsSettings.UseUIAutomation = Utils.DefaultBoolean.True
            UserSkins.BonusSkins.Register()
            If Not NativeVista.IsVista Then Skins.SkinManager.EnableFormSkins()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim frm As frmStart = New frmStart()
            frm.ShowDialog()
            If Not Skins.SkinManager.AllowFormSkins Then Skins.SkinManager.EnableFormSkins()
            Call Application.Run(New frmMain())
        End Sub
    End Module
End Namespace
