Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraRichEdit
Imports DevExpress.Utils.Design
Imports DevExpress.XtraGrid.Demos.Properties

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class ucMailViewer
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            pePhoto.Properties.OptionsMask.MaskType = XtraEditors.Controls.PictureEditMaskType.Circle
            pePhoto.BackColor = Color.Transparent
            lcTitle.Text = String.Empty
            recMessage.Text = String.Empty
            AddHandler LookAndFeel.ActiveLookAndFeel.StyleChanged, New EventHandler(AddressOf ActiveLookAndFeel_StyleChanged)
        End Sub

        Public Sub SetMenuManager(ByVal manager As IDXMenuManager)
            recMessage.MenuManager = manager
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If Not DesignTimeTools.IsDesignMode Then
                LookAndFeelStyleChanged()
            End If
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso Not DesignTimeTools.IsDesignMode Then RemoveHandler LookAndFeel.ActiveLookAndFeel.StyleChanged, New EventHandler(AddressOf ActiveLookAndFeel_StyleChanged)
            MyBase.Dispose(disposing)
        End Sub

        Private Sub ActiveLookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            LookAndFeelStyleChanged()
        End Sub

        Protected Overridable Sub LookAndFeelStyleChanged()
            recMessage.Appearance.Text.ForeColor = ForeColor
            recMessage.Document.SetPageBackground(BackColor)
        End Sub

        Private Sub ShowMessageAdditions(ByVal visible As Boolean)
            layoutControlItem5.Visibility = If(visible, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
            lcPhoto.Visibility = layoutControlItem5.Visibility
        End Sub

        Protected Friend Overridable Sub ShowMessage(ByVal message As Message)
            If message Is Nothing Then Return
            lcTitle.Text = String.Format("<size=+3><b>{0}<br><br><br></b><size=-4>{3}: <size=+2>{1}<br><size=-2>{4}: <size=+2>{2:g}<br> ", message.Subject, message.FullName, message.Date, GetFromString(message.MailType), [Date])
            pePhoto.Image = DataHelper.GetPhotoByEmail(message.Email)
            pePhoto.Properties.OptionsMask.MaskLayoutMode = If(pePhoto.Image Is Nothing, XtraEditors.Controls.PictureEditMaskLayoutMode.Default, XtraEditors.Controls.PictureEditMaskLayoutMode.Stretch)
            If pePhoto.Image Is Nothing Then pePhoto.Image = ImageHelper.CreateSenderImage(message.From, pePhoto.Size, pePhoto.LookAndFeel.ActiveLookAndFeel)
            recMessage.MhtText = message.Text
            ShowMessageAdditions(True)
            LookAndFeelStyleChanged()
        End Sub

        Private Function GetFromString(ByVal mailType As MailType) As String
            Return Resources.FromString
        End Function

        Friend Sub ShowMessagesInfo(ByVal messages As List(Of Message))
            ShowMessageAdditions(False)
            lcTitle.Text = String.Format("<size=+7> <size=-3><b>{0}</b> <size=-3>{1}", messages.Count, MessageFromCount)
            Dim _text As String = Resources.MessageTile
            For Each message As Message In messages
                _text += String.Format(Resources.MessageTileEx, message.From, message.Date, message.Subject)
            Next

            _text += Resources.MessageTileEnd
            recMessage.HtmlText = _text
            LookAndFeelStyleChanged()
        End Sub

        Friend Sub ClearInfo()
            lcTitle.Text = String.Empty
            recMessage.Text = String.Empty
            layoutControlItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Never
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property ZoomFactor As Single
            Get
                Return recMessage.Views.SimpleView.ZoomFactor
            End Get

            Set(ByVal value As Single)
                recMessage.Views.SimpleView.ZoomFactor = value
            End Set
        End Property

        Public ReadOnly Property RichEdit As RichEditControl
            Get
                Return recMessage
            End Get
        End Property

        Private Sub bbiReply_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
        End Sub

        Private Sub bbiReplyAll_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
        End Sub

        Private Sub bbiForward_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
        End Sub

        Const MessageFromCount As String = "Message(s)"

        Const [Date] As String = "Date"
    End Class
End Namespace
