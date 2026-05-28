Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.MailClient.Win.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.Utils.Localization
Imports DevExpress.MailClient.Win.Localizer
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraScheduler.Localization
Imports DevExpress.XtraBars.Localization
Imports DevExpress.XtraNavBar

Namespace DevExpress.MailClient.Win
    Partial Public Class LanguageSelectorForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub englishSimpleButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles englishSimpleButton.Click
            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private Sub arabicSimpleButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles arabicSimpleButton.Click
            DialogResult = DialogResult.OK
            SetCulture("ar")
            Close()
        End Sub

        Private Sub farsiSimpleButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles farsiSimpleButton.Click
            DialogResult = DialogResult.OK
            SetCulture("fa") 'TODO
            Close()
        End Sub

        Private Sub hebrewSimpleButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles hebrewSimpleButton.Click
            DialogResult = DialogResult.OK
            SetCulture("he")
            Close()
        End Sub
        Private Shared Sub SetCulture(ByVal name As String)
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(name)
            System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(name)
            My.Resources.Culture = System.Threading.Thread.CurrentThread.CurrentCulture 'TODO
            GridLocalizer.Active = GetActiveGridLocalizer(name)
            XtraEditors.Controls.Localizer.Active = GetActiveEditorLocalizer(name)
            SchedulerLocalizer.Active = GetActiveSchedulerLocalizer(name)
            SchedulerExtensionsLocalizer.Active = GetActiveSchedulerExtensionsLocalizer(name)
            BarLocalizer.Active = GetActiveBarLocalizer(name)
            NavBarLocalizer.Active = GetActiveNavBarLocalizer(name)
        End Sub

        Private Shared Function GetActiveSchedulerExtensionsLocalizer(ByVal name As String) As XtraLocalizer(Of SchedulerExtensionsStringId)
            Select Case name
                Case "fa"
                    Return New FarsiSchedulerExtensionsLocalizer()
                Case "ar"
                    Return New ArabicSchedulerExtensionsLocalizer()
                Case "he"
                    Return New HebrewSchedulerExtensionsLocalizer()
                Case Else
                    Return SchedulerExtensionsLocalizer.Active
            End Select
        End Function

        Private Shared Function GetActiveNavBarLocalizer(ByVal name As String) As XtraLocalizer(Of NavBarStringId)
            Select Case name
                Case "fa"
                    Return New FarsiNavBarLocalizer()
                Case "ar"
                    Return New ArabicNavBarLocalizer()
                Case "he"
                    Return New HebrewNavBarLocalizer()
                Case Else
                    Return NavBarLocalizer.Active
            End Select
        End Function

        Private Shared Function GetActiveBarLocalizer(ByVal name As String) As BarLocalizer
            Select Case name
                Case "fa"
                    Return New FarsiBarLocalizer()
                Case "ar"
                    Return New ArabicBarLocalizer()
                Case "he"
                    Return New HebrewBarLocalizer()
                Case Else
                    Return CType(BarLocalizer.Active, BarLocalizer)
            End Select
        End Function

        Private Shared Function GetActiveSchedulerLocalizer(ByVal name As String) As XtraLocalizer(Of SchedulerStringId)
            Select Case name
                Case "fa"
                Return New FarsiSchedulerLocalizer()
                Case "ar"
                Return New ArabicSchedulerLocalizer()
                Case "he"
                Return New HebrewSchedulerLocalizer()
                Case Else
                Return SchedulerLocalizer.Active
            End Select
        End Function

        Private Shared Function GetActiveEditorLocalizer(ByVal name As String) As XtraLocalizer(Of StringId)
            Select Case name
                Case "fa"
                Return New FarsiEditorLocalizer()
                Case "ar"
                Return New ArabicEditorLocalizer()
                Case "he"
                Return New HebrewEditorLocalizer()
                Case Else
                Return XtraEditors.Controls.Localizer.Active
            End Select
        End Function

        Private Shared Function GetActiveGridLocalizer(ByVal name As String) As XtraLocalizer(Of GridStringId)
            Select Case name
                Case "fa"
                Return New FarsiGridLocalizer()
                Case "ar"
                Return New ArabicGridLocalizer()
                Case "he"
                Return New HebrewGridLocalizer()
                Case Else
                Return GridLocalizer.Active
            End Select
        End Function
    End Class


End Namespace
