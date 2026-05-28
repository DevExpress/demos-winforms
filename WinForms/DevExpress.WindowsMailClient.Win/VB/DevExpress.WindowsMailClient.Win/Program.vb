Imports System
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Internal
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Skins.Info
Imports DevExpress.WindowsMailClient.Win.Utils
Imports DevExpress.XtraBars.FluentDesignSystem
Imports DevExpress.XtraEditors

Namespace DevExpress.WindowsMailClient.Win

    Friend Module Program

        Const AppName As String = "DevExpress.WindowsMailClient.Win"

        <STAThread>
        Sub Main()
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            Call ExternalAssemblies.ResolveFromSpecificFolderIfRequired()
            Dim [exit] As Boolean
            Using DevAVDataDirectoryHelper.SingleInstanceApplicationGuard(AppName, [exit])
                If [exit] Then Return
            End Using

            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                Call WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                Call WindowsFormsSettings.SetDPIAware()
            End If

            Call RegisterSkin()
            Call SetSkinPalette()
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Touch
            WindowsFormsSettings.CustomizationFormSnapMode = DevExpress.Utils.Controls.SnapMode.OwnerControl
            WindowsFormsSettings.UseUIAutomation = DevExpress.Utils.DefaultBoolean.True
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Using New StartUpProcess()
                Using StartUpProcess.Status.Subscribe(New DemoStartUp())
                    Call Application.Run(New MainForm())
                End Using
            End Using
        End Sub

        Private Sub SetSkinPalette()
            UserLookAndFeel.Default.SetSkinStyle("fluentmailclient")
            Dim skin = CommonSkins.GetSkin(WindowsFormsSettings.DefaultLookAndFeel)
            Dim palette As DevExpress.Utils.Svg.SvgPalette = skin.CustomSvgPalettes("Default")
            skin.SvgPalettes(Skin.DefaultSkinPaletteName).SetCustomPalette(palette)
            Call LookAndFeelHelper.ForceDefaultLookAndFeelChanged()
        End Sub

        Private Sub RegisterSkin()
            Dim assemblyName As String = Assembly.GetExecutingAssembly().GetName().Name
            Dim fluentMailClientSkinDataPath As String = String.Format("{0}.SkinData.fluentmailclient.fluentmailclient.SkinData.", assemblyName)
            Dim skinCreator As SkinBlobXmlCreator = New SkinBlobXmlCreator("fluentmailclient", fluentMailClientSkinDataPath, GetType(Program).Assembly, Nothing)
            SkinManager.Default.RegisterSkin(skinCreator)
            XtraSplashScreen.SplashScreenManager.RegisterUserSkin(skinCreator)
            FluentDesignFormCompatibleSkins.Skins.Add("fluentmailclient")
        End Sub
    End Module
End Namespace
