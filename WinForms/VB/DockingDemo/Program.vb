Imports DevExpress.LookAndFeel
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Namespace DevExpress.XtraBars.Demos.DockingDemo

    Friend Module Program

        <STAThread>
        Sub Main(ByVal args As String())
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If

            XtraEditors.WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim isBarDemo As Boolean = False
            If args.Length <> 0 Then isBarDemo = Equals(args(0), "-barDemo")
            UserSkins.BonusSkins.Register()
            Skins.SkinManager.EnableFormSkins()
            If isBarDemo Then
                UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.Bezier.VSLight)
            Else
                UserLookAndFeel.Default.SetSkinStyle(SkinSvgPalette.Bezier.VSBlue)
            End If

            Dim splashScreenImage = DevExpress.Utils.ResourceImageHelperCore.CreateImageFromResourcesEx("DockingDemo.Resources.SplashScreenNew.png", CurrentAssembly)
            XtraSplashScreen.SplashScreenManager.ShowImage(splashScreenImage, True, False)
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
            fileStreams.Add(DevExpress.Utils.ResourceImageHelperCore.FindStream("DockingDemo.Resources.ProgramText.rtf", CurrentAssembly))
            fileStreams.Add(DevExpress.Utils.ResourceImageHelperCore.FindStream("DockingDemo.Resources.ProgramText2.rtf", CurrentAssembly))
            fileStreams.Add(DevExpress.Utils.ResourceImageHelperCore.FindStream("DockingDemo.Resources.ProgramText3.rtf", CurrentAssembly))
            Return fileStreams
        End Function

        Friend Function GetDocumentStream(ByVal fileName As String) As Stream
            Return DevExpress.Utils.ResourceImageHelperCore.FindStream(String.Format("DockingDemo.Resources.{0}.rtf", fileName), CurrentAssembly)
        End Function
    End Module
End Namespace
