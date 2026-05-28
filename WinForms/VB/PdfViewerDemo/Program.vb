Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraPdfViewer.Demos

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
            Skins.SkinManager.EnableFormSkins()
            LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful")
            XtraEditors.WindowsFormsSettings.AllowSkinEditorAttach = Utils.DefaultBoolean.True
            XtraEditors.WindowsFormsSettings.UseDXDialogs = Utils.DefaultBoolean.True
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
#If NET
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#End If
            Call Application.Run(New MainForm())
        End Sub
    End Module
End Namespace
