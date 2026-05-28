Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Skins
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraRichEdit

Namespace DevExpress.MailClient.Win
    Partial Public Class ucMailViewer
        Inherits BaseControl

        Private parentModule As BaseModule = Nothing
        Public Sub New()
            InitializeComponent()
            pePhoto.Properties.OptionsMask.MaskType = XtraEditors.Controls.PictureEditMaskType.Circle
            recMessage.Text = String.Empty
            bbiReply.Hint = My.Resources.ReplyDescription
            bbiReplyAll.Hint = My.Resources.ReplyAllDescription
            bbiForward.Hint = My.Resources.ForwardDescription
        End Sub
        Friend Sub SetParentModule(ByVal [module] As BaseModule)
            parentModule = [module]
        End Sub
        Public Sub SetMenuManager(ByVal manager As IDXMenuManager)
            recMessage.MenuManager = manager
        End Sub
        Protected Overrides Sub LookAndFeelStyleChanged()
            MyBase.LookAndFeelStyleChanged()
            Dim windowColor As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("Window")
            Dim windowTextColor As Color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("WindowText")
            lgMessageInfo.AppearanceGroup.ForeColor = windowTextColor
            lgMessageInfo.AppearanceGroup.BackColor = windowColor
            lbSubject.ForeColor = windowTextColor
            lbFrom.ForeColor = lbSubject.ForeColor
            lbDate.ForeColor = lbFrom.ForeColor
        End Sub
        Private Sub ShowMessageInfo(ByVal visible As Boolean)
            lgMessageInfo.Visibility = If(visible, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
        End Sub
        Friend Sub ShowMessage(ByVal message As Message)
            If message Is Nothing Then
                Return
            End If
            ShowMessageInfo(True)
            lbSubject.Text = message.Subject
            lbFrom.Text = message.FullName
            lbDate.Text = message.Date.ToString()
            pePhoto.Image = DataHelper.GetPhotoByEmail(message.Email)
            lcPicture.Padding = New XtraLayout.Utils.Padding(If(pePhoto.Image Is Nothing, 10, 0))
            pePhoto.Properties.OptionsMask.MaskLayoutMode = If(pePhoto.Image Is Nothing, XtraEditors.Controls.PictureEditMaskLayoutMode.Default, XtraEditors.Controls.PictureEditMaskLayoutMode.Stretch)
            If pePhoto.Image Is Nothing Then
                pePhoto.Image = ImageHelper.CreateSenderImage(message.From, pePhoto.Size, pePhoto.LookAndFeel.ActiveLookAndFeel)
            End If
            recMessage.MhtText = message.Text
        End Sub
        Private Function GetFromString(ByVal mailType As MailType) As String
            If mailType = DevExpress.MailClient.Win.MailType.Inbox Then
                Return My.Resources.FromInbox
            End If
            If mailType = DevExpress.MailClient.Win.MailType.Deleted Then
                Return My.Resources.FromDeleted
            End If
            Return My.Resources.FromOutbox
        End Function
        Friend Sub ShowMessagesInfo(ByVal messages As List(Of Message))
            ShowMessageInfo(False)
            Dim text As String = StringResources.Get("MessageTile")
            For Each message As Message In messages
                text &= String.Format(StringResources.Get("MessageTileEx"), message.FullName, message.Date, message.Subject)
            Next message
            text &= StringResources.Get("MessageTileEnd")
            recMessage.HtmlText = text
        End Sub
        Friend Sub ShowFeed(ByVal feed As FeedItem, ByVal showUrl As Boolean)
            ShowMessageInfo(False)
            If showUrl Then
                layoutControlItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Always
            Else
                layoutControlItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Never
            End If
            linkView.Text = feed.Url
            recMessage.HtmlText = feed.Description
        End Sub
        Friend Sub ClearInfo()
            recMessage.Text = String.Empty
            layoutControlItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Never
        End Sub
        Public Property ZoomFactor() As Single
            Get
                Return recMessage.Views.SimpleView.ZoomFactor
            End Get
            Set(ByVal value As Single)
                recMessage.Views.SimpleView.ZoomFactor = value
            End Set
        End Property
        Public ReadOnly Property RichEdit() As RichEditControl
            Get
                Return recMessage
            End Get
        End Property

        Private Sub bbiReply_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bbiReply.ItemClick
            parentModule.ButtonClick(TagResources.Reply)
        End Sub
        Private Sub bbiReplyAll_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bbiReplyAll.ItemClick
            parentModule.ButtonClick(TagResources.ReplyAll)
        End Sub
        Private Sub bbiForward_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bbiForward.ItemClick
            parentModule.ButtonClick(TagResources.Forward)
        End Sub
    End Class
End Namespace
