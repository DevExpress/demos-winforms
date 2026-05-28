Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.ChatClient.ViewModels
Imports DevExpress.Data
Imports DevExpress.DevAV.Chat.Model
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Tile

Namespace DevExpress.ChatClient.Views

    Public Partial Class ContactsView
        Inherits XtraUserControl

        Public Sub New()
            InitializeComponent()
            If Not mvvmContext.IsDesignMode Then
                InitializeStyles()
                InitializeBindings()
                InitializeBehavior()
                InitializeMenusAndTooltips()
            End If
        End Sub

        Private Sub InitializeStyles()
            Styles.SearchPanel.Apply(searchPanel)
            Styles.ContactMenu.Apply(contactMenuPopup)
            Styles.ContactTooltip.Apply(contactTooltip)
            contactsTileView.HtmlImages = SvgImages
        End Sub

        Private Sub InitializeBindings()
            Dim fluent = mvvmContext.OfType(Of ContactsViewModel)()
            fluent.SetBinding(gridControl, Function(gc) gc.DataSource, Function(x) x.Contacts)
            fluent.WithEvent(Of TileView, FocusedRowObjectChangedEventArgs)(contactsTileView, "FocusedRowObjectChanged").SetBinding(Function(x) x.SelectedContact, Function(args) TryCast(args.Row, Contact), Sub(gView, entity) gView.FocusedRowHandle = gView.FindRow(entity))
            fluent.SetTrigger(Function(x) x.Contacts, Sub(contacts) contactsTileView.RefreshData())
            fluent.WithEvent(Me, "HandleCreated").EventToCommand(Sub(x) x.OnCreate())
            fluent.WithEvent(Me, "HandleDestroyed").EventToCommand(Sub(x) x.OnDestroy())
            fluent.BindCommandToElement(contactMenuPopup, "miClearConversation", Sub(x) x.ClearConversation())
            fluent.BindCommandToElement(contactMenuPopup, "miCopyContact", Sub(x) x.CopyContact())
        End Sub

        Private Sub OnContactTooltipViewModelSet(ByVal sender As Object, ByVal e As Utils.MVVM.ViewModelSetEventArgs)
            Dim fluent = contactTooltip.OfType(Of ContactViewModel)()
            fluent.BindCommand("lnkEmail", Sub(x) x.MailTo())
            fluent.BindCommand("btnPhoneCall", Sub(x) x.PhoneCall())
            fluent.BindCommand("btnVideoCall", Sub(x) x.VideoCall())
            fluent.BindCommand("btnMessage", Sub(x) x.TextMessage())
        End Sub

        Private Sub InitializeBehavior()
            Dim colLastActivity = contactsTileView.Columns("LastActivity")
            If colLastActivity IsNot Nothing Then contactsTileView.SortInfo.Add(colLastActivity, ColumnSortOrder.Descending)
            AddHandler searchControl.QueryIsSearchColumn, AddressOf OnQueryIsSearchColumn
        End Sub

        Private Sub OnQueryIsSearchColumn(ByVal sender As Object, ByVal e As QueryIsSearchColumnEventArgs)
            e.IsSearchColumn = Equals(e.FieldName, "UserName")
        End Sub

        Private Sub InitializeMenusAndTooltips()
            AddHandler contactsTileView.MouseUp, AddressOf OnContactsMouseUp
            AddHandler contactsTileView.MouseDown, AddressOf OnContactsMouseDown
            AddHandler contactsTileView.HtmlElementMouseOver, AddressOf OnContactsHtmlElementMouseOver
            AddHandler contactsTileView.PositionChanged, AddressOf OnContactsPositionChanged
            AddHandler contactTooltip.Hidden, AddressOf ContactTooltip_Hidden
        End Sub

        Private activeInfoRowHandle As Integer?

        Private Sub ContactTooltip_Hidden(ByVal sender As Object, ByVal e As EventArgs)
            activeInfoStyle = Nothing
            If activeInfoRowHandle.HasValue Then contactsTileView.RefreshRow(activeInfoRowHandle.Value)
            activeInfoRowHandle = Nothing
        End Sub

        Private activeInfoStyle As Utils.Html.CssStyle

        Private Async Sub OnContactsHtmlElementMouseOver(ByVal sender As Object, ByVal e As TileViewHtmlElementMouseEventArgs)
            If Equals(e.ElementId, "info") Then
                activeInfoStyle = e.Element.Style
                activeInfoRowHandle = e.RowHandle
                Await Threading.Tasks.Task.Delay(500)
                If Not e.Bounds.Contains(gridControl.PointToClient(MousePosition)) Then Return
                If activeInfoStyle IsNot Nothing Then activeInfoStyle.SetProperty("opacity", "0.5")
                Dim fluent = mvvmContext.OfType(Of ContactsViewModel)()
                Dim tooltipViewModel = Await fluent.ViewModel.EnsureTooltipViewModel(TryCast(e.Row, Contact))
                If Not contactTooltip.IsViewModelCreated Then contactTooltip.SetViewModel(GetType(ContactViewModel), tooltipViewModel)
                Dim size = ScaleDPI.ScaleSize(New Size(352, 360))
                Dim location = New Point(e.Bounds.Right - ScaleDPI.ScaleHorizontal(6), e.Bounds.Y + ScaleDPI.ScaleHorizontal(8) - (size.Height - e.Bounds.Height) \ 2)
                Dim tooltipScreenBounds = gridControl.RectangleToScreen(New Rectangle(location, size))
                contactTooltip.Show(gridControl, tooltipScreenBounds)
            End If
        End Sub

        Private Sub OnContactsPositionChanged(ByVal sender As Object, ByVal e As EventArgs)
            contactTooltip.Hide()
        End Sub

        Private Sub OnContactsMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim args = Utils.DXMouseEventArgs.GetMouseArgs(e)
            If e.Button = MouseButtons.Right Then
                Dim hitInfo = contactsTileView.CalcHitInfo(e.Location)
                If hitInfo.HitTest = TileControlHitTest.Item Then args.Handled = True
            End If
        End Sub

        Private Sub OnContactsMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim args = Utils.DXMouseEventArgs.GetMouseArgs(e)
            If e.Button = MouseButtons.Right Then
                Dim hitInfo = contactsTileView.CalcHitInfo(e.Location)
                If hitInfo.HitTest = TileControlHitTest.Item Then
                    Dim size = ScaleDPI.ScaleSize(New Size(212, 130))
                    Dim location = New Point(e.X - size.Width \ 2, e.Y - size.Height + ScaleDPI.ScaleVertical(8))
                    Dim menuScreenBounds = gridControl.RectangleToScreen(New Rectangle(location, size))
                    contactMenuPopup.Show(gridControl, menuScreenBounds)
                    args.Handled = True
                End If
            End If
        End Sub

        Private Sub OnContactItemTemplate(ByVal sender As Object, ByVal e As TileViewCustomItemTemplateEventArgs)
            Styles.Contact.Apply(e.HtmlTemplate)
        End Sub

        Private Sub OnContactItemTemplateCustomize(ByVal sender As Object, ByVal e As TileViewItemCustomizeEventArgs)
            Dim contact = TryCast(contactsTileView.GetRow(e.RowHandle), Contact)
            If contact IsNot Nothing Then
                Dim statusBadge = e.HtmlElement.FindElementById("statusBadge")
                If statusBadge IsNot Nothing AndAlso Not contact.IsInactive Then statusBadge.Style.SetBackgroundColor("@Green")
                If Not contact.HasUnreadMessages Then
                    Dim unreadBadge = e.HtmlElement.FindElementById("unreadBadge")
                    If unreadBadge IsNot Nothing Then unreadBadge.Hidden = True
                End If
            End If
        End Sub

        Private NotInheritable Class Styles

            Public Shared SearchPanel As Style = New SearchPanelStyle()

            Public Shared Contact As Style = New ContactStyle()

            Public Shared ContactMenu As Style = New ContactMenuStyle()

            Public Shared ContactTooltip As Style = New ContactTooltipStyle()

            Private NotInheritable Class SearchPanelStyle
                Inherits Style

            End Class

            Private NotInheritable Class ContactStyle
                Inherits Style

            End Class

            Private NotInheritable Class ContactMenuStyle
                Inherits Style

                Public Sub New()
                    MyBase.New(Nothing, "Menu")
                End Sub
            End Class

            Private NotInheritable Class ContactTooltipStyle
                Inherits Style

            End Class
        End Class
    End Class
End Namespace
