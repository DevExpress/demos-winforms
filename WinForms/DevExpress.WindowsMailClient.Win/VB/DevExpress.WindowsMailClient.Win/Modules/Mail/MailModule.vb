Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text.RegularExpressions
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Drawing.Helpers
Imports DevExpress.Utils.Svg
Imports DevExpress.WindowsMailClient.Win.Data
Imports DevExpress.WindowsMailClient.Win.Properties
Imports DevExpress.WindowsMailClient.Win.ViewModels

Namespace DevExpress.WindowsMailClient.Win.Modules

    Public Partial Class MailModule
        Inherits BaseModule

        Private Shared EmailRegex As Regex = New Regex("\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.Compiled)

        Public Sub New()
            MyBase.New(GetType(MailViewModel))
            InitializeComponent()
            LoadDefaultText()
            tEditTo.Properties.AutoHeight = False
        End Sub

        Public ReadOnly Property ViewModel As MailViewModel
            Get
                Return GetViewModel(Of MailViewModel)()
            End Get
        End Property

        Private Sub LoadDefaultText()
            If Utils.UseAsEmailSignature Then editMail.MhtText = Utils.StartMhtText
        End Sub

        Public Function SaveMessageToDrafts() As Boolean
            If teFrom.EditValue IsNot Nothing Then
                ViewModel.SaveMessageToDrafts(editMail.MhtText, tEditSubject.Text, tEditTo.EditValue, teFrom.EditValue)
                Return True
            End If

            Return False
        End Function

        Public Sub Init()
            tEditSubject.Text = Nothing
            tEditTo.EditValue = Nothing
            teFrom.EditValue = Nothing
            LoadDefaultText()
        End Sub

        Private Sub tEditTo_CustomDrawTokenGlyph(ByVal sender As Object, ByVal e As XtraEditors.TokenEditCustomDrawTokenGlyphEventArgs)
            Dim image As SvgImage = Resources.newemployee
            Dim bm As SvgBitmap = New SvgBitmap(image)
            Dim palette = SvgPaletteHelper.GetSvgPalette(LookAndFeel, ObjectState.Normal)
            If image IsNot Nothing Then e.Cache.Paint.DrawImage(e.Graphics, bm.Render(palette), e.GlyphBounds, New Rectangle(Point.Empty, New Size(CInt(image.Width), CInt(image.Height))), True)
            e.Handled = True
        End Sub

        Private Sub tEditTo_ValidateToken(ByVal sender As Object, ByVal e As XtraEditors.TokenEditValidateTokenEventArgs)
            Dim email As String = e.Description
            If Not String.IsNullOrEmpty(Utils.MessageFrom) AndAlso String.Equals(Utils.MessageFrom, email, StringComparison.OrdinalIgnoreCase) Then
                e.IsValid = True
                Return
            End If

            If EmailRegex.IsMatch(email) Then
                e.IsValid = True
            End If
        End Sub

        Protected Overrides Sub WndProc(ByRef m As Windows.Forms.Message)
            If m.Msg = 528 OrElse m.Msg = MSG.WM_LBUTTONDBLCLK OrElse m.Msg = MSG.WM_LBUTTONDOWN OrElse m.Msg = MSG.WM_LBUTTONDOWN Then
                Me.GetParentViewModel(Of MainViewModel)().HideAllPanels()
            End If

            MyBase.WndProc(m)
        End Sub

        Public Sub ShowMessage(ByVal message As Message)
            tEditSubject.Text = message.Subject
            If Not String.IsNullOrEmpty(message.Email) Then tEditTo.EditValue = New List(Of String)() From {message.Email}
            If Not String.IsNullOrEmpty(message.From) AndAlso Not EmailRegex.IsMatch(message.From) Then teFrom.EditValue = New List(Of String)() From {Utils.MessageFrom}
            editMail.MhtText = message.Text
        End Sub

        Private Sub tEditTo_BeforeShowPopupPanel(ByVal sender As Object, ByVal e As XtraEditors.TokenEditBeforeShowPopupPanelEventArgs)
        End Sub
    End Class
End Namespace
