Imports System
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.Internal
Imports DevExpress.Skins
Imports DevExpress.Skins.Info
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.RealtorWorld.Win

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
#If Not NET
            Call DataDirectoryHelper.SetWebBrowserMode()
#End If
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                XtraEditors.WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                XtraEditors.WindowsFormsSettings.SetDPIAware()
            End If

            XtraEditors.WindowsFormsSettings.UseUIAutomation = DefaultBoolean.True
            XtraEditors.WindowsFormsSettings.ApplyDemoSettings()
            Call SkinManager.EnableFormSkins()
            UserSkins.BonusSkins.Register()
            AppearanceObject.DefaultFont = New Font("Segoe UI", 8.25F)
            Dim skinCreator As SkinBlobXmlCreator = New SkinBlobXmlCreator("MetroBlack", "DevExpress.RealtorWorld.Win.SkinData.", GetType(Program).Assembly, Nothing)
            SkinManager.Default.RegisterSkin(skinCreator)
            AsyncAdornerBootStrapper.RegisterLookAndFeel("MetroBlack", "DevExpress.RealtorWorld.Win.SkinData.", GetType(Program).Assembly)
            LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Metropolis")
            Dim demoCI As CultureInfo = CType(Application.CurrentCulture.Clone(), CultureInfo)
            demoCI.NumberFormat.CurrencySymbol = "$"
            SplashScreenManager.RegisterUserSkin(skinCreator)
            Application.CurrentCulture = demoCI
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call DataHelper.CreateWmiService()
            Call Application.Run(New frmMain())
        End Sub
    End Module

    Friend Interface IMainForm

        Sub ShowHome(ByVal home As Home)

        Sub ShowAgent(ByVal agent As Agent)

    End Interface
End Namespace
