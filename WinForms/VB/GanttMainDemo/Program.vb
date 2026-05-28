Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraGantt.Demos

    Friend Module Program

        <STAThread>
        Sub Main(ByVal arguments As String())
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If

            XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True
            XtraEditors.WindowsFormsSettings.InvertHorizontalScrolling = DevExpress.Utils.DefaultBoolean.True
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            UserSkins.BonusSkins.Register()
            Call Application.Run(New frmMain(arguments))
        End Sub
    End Module
End Namespace
