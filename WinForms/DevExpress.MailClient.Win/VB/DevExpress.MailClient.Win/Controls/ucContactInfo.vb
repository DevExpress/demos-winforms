Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.LookAndFeel

Namespace DevExpress.MailClient.Win.Controls
    Partial Public Class ucContactInfo
        Inherits XtraUserControl

        Private tmr As Timer
        Private contact_Field As Contact

        Public Sub New()
            InitializeComponent()
            pePhoto.Properties.AllowAnimationOnValueChanged = Utils.DefaultBoolean.True
        End Sub
        Public ReadOnly Property Contact() As Contact
            Get
                Return contact_Field
            End Get
        End Property
        Private ReadOnly Property PictureTimer() As Timer
            Get
                If tmr Is Nothing Then
                    tmr = New Timer()
                    tmr.Interval = 100
                    tmr.Enabled = False
                    AddHandler tmr.Tick, AddressOf tmr_Tick
                End If
                Return tmr
            End Get
        End Property
        Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
            SizePhoto()
            PictureTimer.Stop()
        End Sub
        Public Sub Init(ByVal contact As Contact, ByVal toolTip As String)
            If contact IsNot Nothing Then
                If contact.Photo Is Nothing Then
                    pePhoto.Image = Nothing
                Else
                    pePhoto.Image = contact.Photo
                End If
                lbName.Text = contact.FullName.ToString()
                teEmail.Text = contact.Email
                teBirthDate.Text = contact.BindingBirthDate.ToShortDateString()
                teAddress.Text = contact.Address.ToString() '.AddressLine;
                tePhone.Text = contact.Phone
                teNotes.Text = contact.Note
            Else
                pePhoto.Image = Nothing
                lbName.Text = String.Empty
                teEmail.Text = lbName.Text
                teBirthDate.Text = teEmail.Text
                teAddress.Text = teBirthDate.Text
                tePhone.Text = teAddress.Text
                teNotes.Text = tePhone.Text
            End If

            'lciInfo.Visibility = contact == null ? LayoutVisibility.Never : LayoutVisibility.Always;
            'lcInfo.Text = GetContactInfo(contact);
            SizePhoto()
            If Not String.IsNullOrEmpty(toolTip) Then
                pePhoto.ToolTip = toolTip
                pePhoto.Cursor = Cursors.Hand
            Else
                pePhoto.Cursor = Cursors.Default
            End If
            Me.contact_Field = contact
            Me.Refresh()
        End Sub
        Private lockResize As Boolean = False
        Private Sub SizePhoto()
            If lockResize Then
                Return
            End If
            lockResize = True
            Dim img As Image = pePhoto.Image
            Try
                If img Is Nothing Then
                    lciPhoto.Visibility = LayoutVisibility.Never
                    Return
                Else
                    lciPhoto.Visibility = LayoutVisibility.Always
                End If
                Dim height As Integer = CInt((CDbl(img.Height) * pePhoto.Properties.ZoomPercent / 100.0)) + 4
                If pePhoto.Properties.ZoomPercent = 100 Then
                    lciPhoto.Height = Math.Min(lciPhoto.Width * img.Height \ img.Width, height)
                Else
                    lciPhoto.Height = height
                End If
            Finally
                lockResize = False
            End Try
        End Sub
        Private Sub pePhoto_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles pePhoto.Resize
            PictureTimer.Start()
        End Sub
        Private Sub ucContactInfo_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            PictureTimer.Start()
        End Sub
        Private Function GetContactInfo(ByVal contact As Contact) As String
            If contact Is Nothing Then
                Return String.Empty
            End If
            Return contact.GetContactInfoHtml()
        End Function
        Public Property ZoomFactor() As Single
            Get
                Return CSng(pePhoto.Properties.ZoomPercent / 100)
            End Get
            Set(ByVal value As Single)
                If value = 1 Then
                    pePhoto.Properties.ZoomPercent= 100
                    pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
                    pePhoto.Properties.ShowScrollBars = False
                Else
                    pePhoto.Properties.ZoomPercent = CInt((value * 100))
                    pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Clip
                    pePhoto.Properties.ShowScrollBars = True
                End If
                SizePhoto()
            End Set
        End Property

        Private Sub teEmail_OpenLink(ByVal sender As Object, ByVal e As XtraEditors.Controls.OpenLinkEventArgs) Handles teEmail.OpenLink
            If e.EditValue IsNot Nothing Then
                e.EditValue = "mailto:" & e.EditValue.ToString()
            End If

        End Sub
    End Class
End Namespace
