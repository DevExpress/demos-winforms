Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.Internal
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.ChatClient

    Friend Module ChatClient

        Public ReadOnly Property SvgImages As SvgImageCollection

        Sub New()
            Runtime.ProfileOptimization.SetProfileRoot(AppContext.BaseDirectory)
            Runtime.ProfileOptimization.StartProfile("Startup.Profile")
            Call ExternalAssemblies.ResolveFromSpecificFolderIfRequired()
            If Not SystemInformation.TerminalServerSession AndAlso Screen.AllScreens.Length > 1 Then
                Call WindowsFormsSettings.SetPerMonitorDpiAware()
            Else
                Call WindowsFormsSettings.SetDPIAware()
            End If

            WindowsFormsSettings.UseUIAutomation = DefaultBoolean.True
            Call WindowsFormsSettings.EnableFormSkins()
            Call WindowsFormsSettings.ForceDirectXPaint()
            WindowsFormsSettings.ScrollUIMode = ScrollUIMode.Fluent
            WindowsFormsSettings.FontBehavior = WindowsFormsFontBehavior.ForceSegoeUI
            WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle(LookAndFeel.SkinStyle.Bezier, LookAndFeel.SkinSvgPalette.Bezier.Default)
            SvgImages = SvgImageCollection.FromResources(GetType(ChatClient).Assembly)
            Call MainFormHelper.InitTakeScreen(Data.Utils.SafeEnvironment.GetCommandLineArgs())
            Call RegisterAppServices()
            DevAVDataDirectoryHelper.LocalPrefix = "WinChatClientApp"
        End Sub

        Private Sub RegisterAppServices()
            Call Services.AppSettigns.Register()
#If NET
                () => new DevAV.DevAVDb(string.Format("Data Source={0}", GetDatabaseFilePath()), MainFormHelper.TakeScreens);
#Else
            Dim createDB As Func(Of DevAV.DevAVDb) = Function() New DevAV.DevAVDb(MainFormHelper.TakeScreens)
#End If
            Dim messageServer = New DevAV.Chat.DevAVEmpployeesInMemoryServer(createDB)
            Mvvm.ServiceContainer.Default.RegisterService(messageServer)
        End Sub

#If NET
        static string GetDatabaseFilePath() {
            var filePath = DevAVDataDirectoryHelper.GetFile("devav.sqlite3");
            try {
                var attributes = System.IO.File.GetAttributes(filePath);
                if(attributes.HasFlag(System.IO.FileAttributes.ReadOnly)) 
                    System.IO.File.SetAttributes(filePath, attributes & ~System.IO.FileAttributes.ReadOnly);
            }
            catch { }
            return filePath;
        }
#End If
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim messenger = New Messenger()
            messenger.IconOptions.SvgImage = SvgImages("AppIcon")
            Application.Run(messenger)
        End Sub
    End Module
End Namespace
