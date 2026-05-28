Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.ChatClient.ViewModels
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Items

Namespace DevExpress.ChatClient.Views

    Public Partial Class MessagesView
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                InitializeStyles()
                InitializeBindings()
                InitializeMessageEdit()
            End If
        End Sub

        Private Sub InitializeStyles()
            Styles.Toolbar.Apply(toolbarPanel)
            Styles.TypingBox.Apply(typingBox)
            Styles.NoMessages.Apply(messagesItemsView.EmptyViewHtmlTemplate)
            messagesItemsView.HtmlImages = SvgImages
        End Sub

        Private Sub InitializeBindings()
            Dim fluent = mvvmContext.OfType(Of MessagesViewModel)()
            fluent.SetBinding(gridControl, Function(gc) gc.DataSource, Function(x) x.Messages)
            fluent.SetBinding(toolbarPanel, Function(tp) tp.DataContext, Function(x) x.Contact)
            fluent.SetBinding(messagesItemsView, Function(mv) mv.FocusedRowObject, Function(x) x.SelectedMessage)
            fluent.SetBinding(messagesItemsView, Function(mv) mv.SelectedText, Function(x) x.SelectedText)
            fluent.KeyToCommand(messagesItemsView, Keys.Control Or Keys.C, Function(x) AddressOf x.CopySelectedText)
            fluent.SetTrigger(Function(x) x.Messages, Sub(contacts) messagesItemsView.RefreshData())
            fluent.SetTrigger(Function(x) x.UpdatedMessageIndices, Sub(indices) messagesItemsView.RefreshData(indices))
            fluent.SetTrigger(Function(x) x.Contact, Sub(contact) messagesItemsView.MoveLast())
            fluent.WithEvent(Me, "HandleCreated").EventToCommand(Sub(x) x.OnCreate())
            fluent.WithEvent(Me, "HandleDestroyed").EventToCommand(Sub(x) x.OnDestroy())
            fluent.BindCommandToElement(toolbarPanel, "btnPhoneCall", Sub(x) x.PhoneCall())
            fluent.BindCommandToElement(toolbarPanel, "btnVideoCall", Sub(x) x.VideoCall())
            fluent.BindCommandToElement(toolbarPanel, "btnContact", Sub(x) x.ShowContact())
            fluent.BindCommandToElement(toolbarPanel, "btnUser", Sub(x) x.ShowUser())
            fluent.BindCommandToElement(typingBox, "btnSend", Sub(x) x.SendMessage())
            fluent.WithKey(messageEdit, Keys.Control Or Keys.Enter).KeyToCommand(Sub(x) x.SendMessage())
            fluent.SetObjectDataSourceBinding(messageBindingSource, Sub(x) x.Update())
            fluent.BindCommandToElement(messageMenuPopup, "miLike", Sub(x) x.LikeMessage())
            fluent.BindCommandToElement(messageMenuPopup, "miCopy", Sub(x) x.CopyMessage())
            fluent.BindCommandToElement(messageMenuPopup, "miDelete", Sub(x) x.DeleteMessage())
            fluent.BindCommandToElement(messageMenuPopup, "miCopyText", Sub(x) x.CopyMessageText())
            fluent.BindCommandToElement(messageMenuPopup, "miCopySelectedText", Function(x) AddressOf x.CopySelectedText)
            AddHandler messagesItemsView.ElementMouseClick, AddressOf OnMessagesViewElementMouseClick
            AddHandler messagesItemsView.TopRowPixelChanged, AddressOf OnMessagesTopRowPixelChanged
            AddHandler messageMenuPopup.Hidden, AddressOf OnMessageMenuPopupHidden
        End Sub

        Private activeMoreStyle As Utils.Html.CssStyle

        Private Sub OnMessagesViewElementMouseClick(ByVal sender As Object, ByVal e As ItemsViewHtmlElementMouseEventArgs)
            If Equals(e.ElementId, "btnMore") Then
                activeMoreStyle = e.Element.Style
                activeMoreRowHandle = e.RowHandle
                activeMoreStyle.SetProperty("opacity", "1")
            End If

            If Equals(e.ElementId, "btnMore") OrElse Equals(e.ElementId, "btnLike") Then
                ShowMenu(e)
            ElseIf e.Button = MouseButtons.Right Then
                If Not String.IsNullOrEmpty(messagesItemsView.SelectedText) Then ShowContextMenu(e)
            End If
        End Sub

        Private Sub ShowMenu(ByVal e As ItemsViewHtmlElementMouseEventArgs)
            Styles.Menu.Apply(messageMenuPopup)
            Dim size = ScaleDPI.ScaleSize(New Size(212, 180))
            Dim location = New Point(e.Bounds.X - (size.Width - e.Bounds.Width) \ 2, e.Bounds.Y - size.Height + ScaleDPI.ScaleVertical(8))
            messageMenuPopup.Show(gridControl, gridControl.RectangleToScreen(New Rectangle(location, size)))
        End Sub

        Private Sub ShowContextMenu(ByVal e As ItemsViewHtmlElementMouseEventArgs)
            Styles.ContextMenu.Apply(messageMenuPopup)
            Dim size = ScaleDPI.ScaleSize(New Size(212, 100))
            Dim location = New Point(e.X - size.Width \ 2, e.Y - size.Height + ScaleDPI.ScaleVertical(8))
            Dim screenRect As Rectangle = gridControl.RectangleToScreen(New Rectangle(location, size))
            messageMenuPopup.Show(gridControl, screenRect)
        End Sub

        Private Sub OnMessagesTopRowPixelChanged(ByVal sender As Object, ByVal e As EventArgs)
            messageMenuPopup.Hide()
        End Sub

        Private activeMoreRowHandle As Integer?

        Private Sub OnMessageMenuPopupHidden(ByVal sender As Object, ByVal e As EventArgs)
            activeMoreStyle = Nothing
            If activeMoreRowHandle.HasValue Then messagesItemsView.RefreshRow(activeMoreRowHandle.Value)
            activeMoreRowHandle = Nothing
        End Sub

        Private Sub InitializeMessageEdit()
            Dim autoHeightEdit = TryCast(messageEdit, IAutoHeightControlEx)
            autoHeightEdit.AutoHeightEnabled = True
            AddHandler autoHeightEdit.HeightChanged, AddressOf OnMessageHeightChanged
        End Sub

        Private Sub OnMessageHeightChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim contentSize = typingBox.GetContentSize()
            typingBox.Height = contentSize.Height
        End Sub

        Private Sub OnQueryItemTemplate(ByVal sender As Object, ByVal e As QueryItemTemplateEventArgs)
            Dim message = TryCast(e.Row, DevAV.Chat.Model.Message)
            If message Is Nothing Then Return
            If message.IsOwnMessage Then
                Styles.MyMessage.Apply(e.Template)
            Else
                Styles.Message.Apply(e.Template)
            End If

            Dim fluent = mvvmContext.OfType(Of MessagesViewModel)()
            fluent.ViewModel.OnMessageRead(message)
        End Sub

        Private Sub OnCustomizeItem(ByVal sender As Object, ByVal e As CustomizeItemArgs)
            Dim message = TryCast(e.Row, DevAV.Chat.Model.Message)
            If message Is Nothing Then Return
            If message.IsLiked Then
                Dim btnLike = e.Element.FindElementById("btnLike")
                Dim btnMore = e.Element.FindElementById("btnMore")
                If btnLike IsNot Nothing AndAlso btnMore IsNot Nothing Then
                    btnLike.Hidden = False
                    btnMore.Hidden = True
                End If
            End If

            If message.IsFirstMessageOfBlock Then Return
            If Not message.IsOwnMessage Then
                Dim avatar = e.Element.FindElementById("avatar")
                If avatar IsNot Nothing Then avatar.Style.SetVisibility(Utils.Html.Internal.CssVisibility.Hidden)
            End If

            Dim name = e.Element.FindElementById("name")
            If name IsNot Nothing Then name.Hidden = True
            If Not message.IsFirstMessageOfReply Then
                Dim sent = e.Element.FindElementById("sent")
                If sent IsNot Nothing Then sent.Hidden = True
            End If
        End Sub

        Private NotInheritable Class Styles

            Public Shared Toolbar As Style = New ToolbarStyle()

            Public Shared Message As Style = New MessageStyle()

            Public Shared MyMessage As Style = New MyMessageStyle()

            Public Shared NoMessages As Style = New NoMessagesStyle()

            Public Shared Menu As Style = New MenuStyle()

            Public Shared ContextMenu As Style = New ContextMenuStyle()

            Public Shared TypingBox As Style = New TypingBoxStyle()

            Private NotInheritable Class ToolbarStyle
                Inherits Style

            End Class

            Private NotInheritable Class MessageStyle
                Inherits Style

            End Class

            Private NotInheritable Class MyMessageStyle
                Inherits Style

            End Class

            Private NotInheritable Class MenuStyle
                Inherits Style

            End Class

            Private NotInheritable Class ContextMenuStyle
                Inherits Style

            End Class

            Private NotInheritable Class TypingBoxStyle
                Inherits Style

            End Class

            Private NotInheritable Class NoMessagesStyle
                Inherits Style

            End Class
        End Class
    End Class
End Namespace
