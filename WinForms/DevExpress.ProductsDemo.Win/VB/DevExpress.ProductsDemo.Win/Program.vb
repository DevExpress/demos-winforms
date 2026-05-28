Imports System.IO
Imports System.Reflection
Imports DevExpress.Data.Filtering
Imports DevExpress.MailClient.Win
Imports DevExpress.MailDemo.Win
Imports DevExpress.ProductsDemo.Win.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.ProductsDemo.Win
	Friend Module Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main(ByVal arguments() As String)
            AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf OnCurrentDomainAssemblyResolve
            WindowsFormsSettings.ApplyDemoSettings()

            DataHelper.ApplicationArguments = arguments
            Dim enUs As New System.Globalization.CultureInfo("en-US")
            System.Threading.Thread.CurrentThread.CurrentCulture = enUs
            System.Threading.Thread.CurrentThread.CurrentUICulture = enUs
            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Segoe UI", 8)
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful")
            SkinManager.EnableFormSkins()
            EnumProcessingHelper.RegisterEnum(Of TaskStatus)()

            SplashScreenManager.ShowForm(Nothing, GetType(ssMain), True, True, False, 1000)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New frmMain())
        End Sub
        Function OnCurrentDomainAssemblyResolve(ByVal sender As Object, ByVal args As ResolveEventArgs) As Assembly
            Dim partialName As String = Utils.AssemblyHelper.GetPartialName(args.Name).ToLower()
            If partialName = "entityframework" OrElse partialName = "system.data.sqlite" Then
                Dim dllPath As String = Path.Combine(Path.GetDirectoryName(GetType(Program).Assembly.Location), "..\..\bin", partialName & ".dll")
                Return Assembly.LoadFrom(dllPath)
            End If
            Return Nothing
        End Function
    End Module
End Namespace
