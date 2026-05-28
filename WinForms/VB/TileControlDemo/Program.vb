Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraBars.Demos.TileControlDemo

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If

            XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New MainForm())
        End Sub
    End Module
End Namespace
