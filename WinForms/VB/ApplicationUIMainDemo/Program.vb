Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Namespace DevExpress.ApplicationUI.Demos

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            AllowDataDirectoryAccess()
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If

            XtraEditors.WindowsFormsSettings.UseUIAutomation = Utils.DefaultBoolean.True
            UserSkins.BonusSkins.Register()
            XtraEditors.WindowsFormsSettings.EnableFormSkins()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Utils.Taskbar.Core.TaskbarAssistantCore.Initialize()
            Call Application.Run(New frmMain())
        End Sub

        Private currentAssemblyCore As Assembly

        Private ReadOnly Property CurrentAssembly As Assembly
            Get
                If currentAssemblyCore Is Nothing Then currentAssemblyCore = Assembly.GetExecutingAssembly()
                Return currentAssemblyCore
            End Get
        End Property

        Friend Function CreateResourceStreams() As List(Of Stream)
            Dim fileStreams As List(Of Stream) = New List(Of Stream)()
            fileStreams.Add(Utils.ResourceImageHelperCore.FindStream("DevExpress.ApplicationUI.Demos.Resources.ucSolutionExplorer.rtf", CurrentAssembly))
            fileStreams.Add(Utils.ResourceImageHelperCore.FindStream("DevExpress.ApplicationUI.Demos.Resources.ucToolbox.rtf", CurrentAssembly))
            fileStreams.Add(Utils.ResourceImageHelperCore.FindStream("DevExpress.ApplicationUI.Demos.Resources.ucSolutionExplorer.rtf", CurrentAssembly))
            Return fileStreams
        End Function

        Friend Function GetStream(ByVal fileName As String) As Stream
            Return Utils.ResourceImageHelperCore.FindStream(String.Format("DevExpress.ApplicationUI.Demos.Resources.{0}", fileName), CurrentAssembly)
        End Function
    End Module
End Namespace
