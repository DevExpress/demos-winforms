Imports DevExpress.Data.Filtering
Imports DevExpress.MailClient.Win.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.MailClient.Win
    Friend NotInheritable Class Program
        <STAThread>
        Shared Sub Main(ByVal arguments() As String)
            DevExpress.Internal.ExternalAssemblies.ResolveFromSpecificFolderIfRequired()
            DataHelper.ApplicationArguments = arguments
            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Segoe UI", 8)
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful")
            SkinManager.EnableFormSkins()
            EnumProcessingHelper.RegisterEnum(Of TaskStatus)()
            UnpackHelper.Unpack()

            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Using langSelector As LanguageSelectorForm = New LanguageSelectorForm()
                If langSelector.ShowDialog() <> DialogResult.OK Then
                    Return
                End If
            End Using
            SplashScreenManager.ShowForm(Nothing, GetType(ssMain), True, True, False, 1)
            Application.Run(New frmMain())
        End Sub
    End Class
End Namespace
