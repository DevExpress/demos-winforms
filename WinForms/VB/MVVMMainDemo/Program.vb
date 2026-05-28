Imports System
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Utils.Taskbar

Namespace DevExpress.MVVM.Demos
    Friend NotInheritable Class Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Shared Sub Main()
            If Not SystemInformation.TerminalServerSession And Screen.AllScreens.Length > 1 Then
                DevExpress.XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If
            TaskbarAssistant.Default.Initialize()
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf OnCurrentDomainAssemblyResolve

            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.Skins.SkinManager.EnableFormSkins()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New frmMain())
        End Sub
        Private Shared Function OnCurrentDomainAssemblyResolve(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
            Dim partialName As String = DevExpress.Utils.AssemblyHelper.GetPartialName(args.Name).ToLower()
            If partialName = "entityframework" OrElse partialName = "system.data.sqlite" OrElse partialName = "system.data.sqlite.ef6" OrElse partialName = "entityframework.sqlserver" Then
                Dim path As String = Tutorials.FilePathUtils.FindFilePath("Dll\\" + partialName + ".dll", False)
                If String.IsNullOrEmpty(path) Then
                    Return Nothing
                End If
                Return System.Reflection.Assembly.LoadFrom(path)
                End If
                Return Nothing
        End Function
    End Class
End Namespace
