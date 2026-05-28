Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.UserSkins
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.VideoRent.Win.Forms
Imports System.IO
Imports System.Globalization
Imports DevExpress.LookAndFeel

Namespace DevExpress.VideoRent.Win
	Friend NotInheritable Class Program
		Private Const iniFilePath As String = "VideoRent.ini"
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
        <STAThread()> _
        Shared Sub Main()
            Dim videoRentCI As CultureInfo = CType(Application.CurrentCulture.Clone(), CultureInfo)
            videoRentCI.NumberFormat.CurrencySymbol = "$"
            Application.CurrentCulture = videoRentCI
            BonusSkins.Register()
            Skins.SkinManager.EnableFormSkins()
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim iniFile As New IniFile()
            If File.Exists(iniFilePath) Then
                iniFile.Load(iniFilePath)
            End If
            Dim initialDbCreator As New InitialDbCreator(New CreateInitialDbDialog(), New ExceptionsProcesser(Nothing))
            If initialDbCreator.OpenDb(iniFile) Then
                iniFile.Save(iniFilePath)
                VideoRentCurrentUser.Login(DevExpress.Xpo.Session.DefaultSession, ReferenceData.AdministratorString) 'TODO Create Login-Dialog
                Application.Run(New frmMain())
            End If
        End Sub
	End Class
End Namespace
