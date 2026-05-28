Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraGauges.Demos

    Friend Module Program

        <STAThread>
        Sub Main(ByVal arguments As String())
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                Call WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                Call WindowsFormsSettings.SetDPIAware()
            End If

            WindowsFormsSettings.UseUIAutomation = Utils.DefaultBoolean.True
            '
            LayoutControl.AllowCustomizationDefaultValue = False
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New frmMain(arguments))
        End Sub
    End Module
End Namespace
