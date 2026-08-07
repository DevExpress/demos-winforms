Imports System
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Data
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.MVVM
Imports DevExpress.WindowsMailClient.Win.Data
Imports DevExpress.WindowsMailClient.Win.Model
Imports DevExpress.WindowsMailClient.Win.Utils
Imports DevExpress.WindowsMailClient.Win.ViewModels
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraBars.ToastNotifications
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Controls
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraGrid.Views.Tile.ViewInfo
Imports DevExpress.XtraLayout
Imports Message = DevExpress.WindowsMailClient.Win.Data.Message

Namespace DevExpress.WindowsMailClient.Win.Modules

    Public Enum FilterType
        Focused
        Other
    End Enum

    Public Partial Class MailViewer
        Inherits BaseModule

        Private UnreadTextColor As Color

        Public Sub New()
            MyBase.New(GetType(MailViewerViewModel))
            InitializeComponent()
            layoutControl1.UseLocalBindingContext = True
            gridControl1.DataSource = MailClientDataModel.Messages
            colDate.SortOrder = ColumnSortOrder.Descending
            biSortDate.Tag = "Date"
            biSortFrom.Tag = "From"
            biSortRead.Tag = "Read"
            biSortSubject.Tag = "SubjectDisplayText"
            biSortImportance.Tag = "Priority"
            AddHandler ViewModel.MessageDeleted, AddressOf ViewModel_MessageDeleted
            AddHandler ViewModel.MessageFlagged, AddressOf ViewModel_MessageFlagged
            AddHandler ViewModel.MessageChanged, AddressOf ViewModel_MessageChanged
            AddHandler ViewModel.FilterChanged, AddressOf ViewModel_FilterChanged
            AddHandler ViewModel.SortInfoChanged, AddressOf ViewModel_SortInfoChanged
            AddHandler tileView.MouseMove, AddressOf TileView_MouseMove
            tileView.OptionsFind.AllowFindPanel = True
            AddHandler gridControl1.SizeChanged, Sub(s, e) CompactTemplate = gridControl1.Width <= 300
            InitNotifications()
            ViewModel.CurrentFilterType = FilterType.Other
            ViewModel.CurrentMailType = MailType.Inbox
            navigationItemFocused.Tag = FilterType.Focused
            navigationItemOther.Tag = FilterType.Other
            BindCommands()
            InitBindings()
            UpdateColors()
        End Sub

        Private Sub TileView_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            If tileView.IsEditing Then Return
            Dim hitInfo As TileViewHitInfo = TryCast(tileView.CalcHitInfo(e.X, e.Y), TileViewHitInfo)
            If hitInfo IsNot Nothing Then currentRowHandle = hitInfo.RowHandle
        End Sub

        Private Sub ViewModel_MessageFlagged(ByVal sender As Object, ByVal e As EventArgs)
            SetMailType(ViewModel.CurrentMailType)
        End Sub

        Private updateSortValues As Boolean

        Private Sub ViewModel_FilterChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateCurrentMessage()
            updateSortValues = True
            bcFilterAll.Checked = True
            bcFilterUnread.Checked = False
            bcFilterImportance.Checked = False
            bcFilterToday.Checked = False
            bcFilterYesterday.Checked = False
            updateSortValues = False
        End Sub

        Private Sub UpdateCurrentMessage()
            tileView.FocusedRowHandle = 0
            ViewModel.CurrentMessage = TryCast(tileView.GetFocusedRow(), Message)
        End Sub

        Public ReadOnly Property ViewModel As MailViewerViewModel
            Get
                Return GetViewModel(Of MailViewerViewModel)()
            End Get
        End Property

        Private Sub ViewModel_MessageChanged(ByVal sender As Object, ByVal e As EventArgs)
            mailPresenter.ShowMessage(ViewModel.CurrentMessage)
        End Sub

        Private Sub InitBindings()
            mvvmContext.SetBinding(tileView, Function(view) view.ActiveFilterCriteria, "ActiveFilter")
            mvvmContext.SetBinding(labelHeader, Function(x) x.Text, "LabelText")
            mvvmContext.SetBinding(lciHeader, Function(x) x.Visibility, "LayoutHeaderVisibility")
            mvvmContext.SetBinding(lciTabFilter, Function(x) x.Visibility, "FocusedItemVisibility")
            Dim fluentAPI As MVVMContextFluentAPI(Of MailViewerViewModel) = mvvmContext.OfType(Of MailViewerViewModel)()
            fluentAPI.EventToCommand(tileView, "FocusedRowChanged", Sub(x) x.SetCurrentMessage(Nothing), CType(AddressOf GetMessageForFocusedRow, Func(Of FocusedRowChangedEventArgs, Object)))
            fluentAPI.EventToCommand(biSortDate, "ItemClick", Sub(x) x.Sort(Nothing), EventArgsToSortCommandParameter())
            fluentAPI.EventToCommand(biSortFrom, "ItemClick", Sub(x) x.Sort(Nothing), EventArgsToSortCommandParameter())
            fluentAPI.EventToCommand(biSortRead, "ItemClick", Sub(x) x.Sort(Nothing), EventArgsToSortCommandParameter())
            fluentAPI.EventToCommand(biSortSubject, "ItemClick", Sub(x) x.Sort(Nothing), EventArgsToSortCommandParameter())
            fluentAPI.EventToCommand(biSortImportance, "ItemClick", Sub(x) x.Sort(Nothing), EventArgsToSortCommandParameter())
            fluentAPI.EventToCommand(Of ItemClickEventArgs)(bcFilterAll, "CheckedChanged", Sub(x) x.SetFilterAll(), Function(x) CType(x.Item, BarCheckItem).Checked AndAlso Not updateSortValues)
            fluentAPI.EventToCommand(Of ItemClickEventArgs)(bcFilterUnread, "CheckedChanged", Sub(x) x.SetFilterUnread(), Function(x) CType(x.Item, BarCheckItem).Checked AndAlso Not updateSortValues)
            fluentAPI.EventToCommand(Of ItemClickEventArgs)(bcFilterImportance, "CheckedChanged", Sub(x) x.SetFilterImportance(), Function(x) CType(x.Item, BarCheckItem).Checked AndAlso Not updateSortValues)
            fluentAPI.EventToCommand(Of ItemClickEventArgs)(bcFilterToday, "CheckedChanged", Sub(x) x.SetFilterToday(), Function(x) CType(x.Item, BarCheckItem).Checked AndAlso Not updateSortValues)
            fluentAPI.EventToCommand(Of ItemClickEventArgs)(bcFilterYesterday, "CheckedChanged", Sub(x) x.SetFilterYesterday(), Function(x) CType(x.Item, BarCheckItem).Checked AndAlso Not updateSortValues)
            fluentAPI.EventToCommand(Of NavigationBarItemEventArgs)(officeFilterTab, "SelectedItemChanged", Sub(x) x.SetFilterType(GetCurrentFilterType()), Function(x) GetCurrentFilterType())
        End Sub

        Private Function GetMessageForFocusedRow(ByVal x As FocusedRowChangedEventArgs) As Object
            If x.FocusedRowHandle >= 0 Then Return CType(tileView.GetFocusedRow(), Message)
            Return Nothing
        End Function

        Private Function EventArgsToSortCommandParameter() As Func(Of ItemClickEventArgs, Object)
            Return Function(x)
                popupMenu.BeginUpdate()
                If x.Item.ImageIndex = -1 Then
                    UpdateSortItemsImageIndexes()
                    x.Item.ImageIndex = 0
                Else
                    x.Item.ImageIndex = If(x.Item.ImageIndex = 1, 0, 1)
                End If

                popupMenu.EndUpdate()
                Return New SortInfo() With {.Column = tileView.Columns(CStr(x.Item.Tag)), .Order = If(x.Item.ImageIndex = 1, ColumnSortOrder.Ascending, ColumnSortOrder.Descending)}
            End Function
        End Function

        Private Sub ViewModel_MessageDeleted(ByVal sender As Object, ByVal e As EventArgs)
            SetMailType(ViewModel.CurrentMailType)
        End Sub

        Private Sub BindCommands()
            mvvmContext.BindCommand(Of MailViewerViewModel)(contextButton2, Sub(x) x.DeleteMessage(GetCurrentMessage()), Function(p) GetCurrentMessage())
            mvvmContext.BindCommand(Of MailViewerViewModel)(contextButton3, Sub(x) x.ReplyMessage(GetCurrentMessage()), Function(p) GetCurrentMessage())
            mvvmContext.BindCommand(Of MailViewerViewModel)(checkContextButton1, Sub(x) x.SetMessageFlaged(GetCurrentMessage()), Function(p) GetCurrentMessage())
        End Sub

        Private currentRowHandle As Integer

        Private Function GetCurrentMessage() As Message
            Return TryCast(tileView.GetRow(currentRowHandle), Message)
        End Function

        Private Function GetCurrentFilterType() As FilterType
            Dim item = officeFilterTab.SelectedItem
            Return If(item IsNot Nothing, CType(item.Tag, FilterType), FilterType.Other)
        End Function

#Region "Notifications"
        Private notificationsTimer As Timer

        Private alertControl As XtraBars.Alerter.AlertControl

        Private Sub InitNotifications()
            If CanUseToastNotifications() Then
                notificationManager.ApplicationId = AppProvider.ApplicationID
                notificationManager.TryCreateApplicationShortcut()
                AddHandler notificationManager.Activated, AddressOf notificationsManager_Activated
            Else
                alertControl = New Alerter.AlertControl(components)
                alertControl.AllowHtmlText = True
                alertControl.FormLocation = Alerter.AlertFormLocation.TopRight
                alertControl.ShowPinButton = False
                AddHandler alertControl.AlertClick, AddressOf alertControl_AlertClick
            End If

            EnsureNotificationsTimer()
        End Sub

        Private Sub EnsureNotificationsTimer()
            If notificationsTimer Is Nothing Then
                notificationsTimer = New Timer(components)
                notificationsTimer.Interval = 15000
                AddHandler notificationsTimer.Tick, AddressOf notificationsTimer_Tick
            End If

            notificationsTimer.Start()
        End Sub

        Private Sub DestroyNotificationsTimer()
            If notificationsTimer IsNot Nothing Then
                notificationsTimer.Stop()
                RemoveHandler notificationsTimer.Tick, AddressOf notificationsTimer_Tick
                notificationsTimer.Dispose()
            End If

            notificationsTimer = Nothing
        End Sub

        Private Sub notificationsTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
            If notificationManager.IsDisposing Then
                DestroyNotificationsTimer()
                Return
            End If

            If ShowNotifications Then
                notificationsTimer.Interval = 15000
                ShowNotification()
            End If
        End Sub

        Private Sub alertControl_AlertClick(ByVal sender As Object, ByVal e As XtraBars.Alerter.AlertClickEventArgs)
            Dim notificationId As Object = e.Info.Tag
            e.AlertForm.Close()
            OnNotificationClick(notificationId)
        End Sub

        Private Sub notificationsManager_Activated(ByVal sender As Object, ByVal e As ToastNotificationEventArgs)
            OnNotificationClick(e.NotificationID)
        End Sub

        Private Function CanUseToastNotifications() As Boolean
            Return ToastNotificationsManager.AreToastNotificationsSupported
        End Function

        Private Sub ShowNotification()
        End Sub

        Private Sub OnNotificationClick(ByVal notificationId As Object)
        End Sub

#End Region
#Region "UI Customization and Drawing"
        Protected Overrides Sub WndProc(ByRef m As Windows.Forms.Message)
            If m.Msg = 528 Then
                Me.GetParentViewModel(Of MainViewModel)().HideAllPanels()
            End If

            MyBase.WndProc(m)
        End Sub

        Private Sub tileView1_CustomItemTemplate(ByVal sender As Object, ByVal e As TileViewCustomItemTemplateEventArgs)
            If CompactTemplate Then e.Template = e.Templates("smallsize")
        End Sub

        Protected Overrides Sub OnLookAndFeelChanged()
            MyBase.OnLookAndFeelChanged()
            UpdateColors()
        End Sub

        Private Sub UpdateColors()
            Dim skinElement As SkinElement = NavPaneSkins.GetSkin(LookAndFeel.ActiveLookAndFeel)(NavPaneSkins.SkinOfficeNavigationBarItem)
            UnreadTextColor = If(skinElement IsNot Nothing, skinElement.Properties.GetColor("PressedColor"), QuestionColor)
            tileView.Appearance.GroupText.ForeColor = UnreadTextColor
            tileView.Appearance.ItemFocused.BackColor = Color.FromArgb(40, UnreadTextColor)
            tileView.Appearance.ItemHovered.BackColor = Color.FromArgb(40, UnreadTextColor)
            labelControl1.AppearanceDropDownHovered.Font = GetFont(labelControl1.Font.FontFamily.Name, 12F)
            labelControl1.AppearanceDropDown.Font = labelControl1.AppearanceDropDownHovered.Font
            labelControl1.AppearancePressed.Font = labelControl1.AppearanceDropDown.Font
            labelControl1.AppearanceHovered.Font = labelControl1.AppearancePressed.Font
            labelControl1.Appearance.Font = labelControl1.AppearanceHovered.Font
            labelControl1.AppearanceDropDownPressed.ForeColor = UnreadTextColor
            labelControl1.AppearanceDropDownHovered.ForeColor = labelControl1.AppearanceDropDownPressed.ForeColor
            labelControl1.AppearanceDropDown.ForeColor = labelControl1.AppearanceDropDownHovered.ForeColor
            labelControl1.AppearancePressed.ForeColor = labelControl1.AppearanceDropDown.ForeColor
            labelControl1.AppearanceHovered.ForeColor = labelControl1.AppearancePressed.ForeColor
            labelControl1.Appearance.ForeColor = labelControl1.AppearanceHovered.ForeColor
        End Sub

        Private Sub tileView_ItemCustomize(ByVal sender As Object, ByVal e As TileViewItemCustomizeEventArgs)
            Dim isRead As Boolean = CInt(tileView.GetRowCellValue(e.RowHandle, colRead)) = 1
            If Not isRead Then
                e.Item("Read").Appearance.Normal.BackColor = UnreadTextColor
                e.Item("Date").Appearance.Normal.ForeColor = UnreadTextColor
                e.Item("SubjectDisplayText").Appearance.Normal.ForeColor = UnreadTextColor
                e.Item("SubjectDisplayText").Appearance.Normal.FontStyleDelta = FontStyle.Bold
            End If
        End Sub

        Private Sub tileView_ContextButtonCustomize(ByVal sender As Object, ByVal e As TileViewContextButtonCustomizeEventArgs)
            If Equals(e.Item.Name, "cbFlag") Then
                Dim flagged As Boolean = CInt(tileView.GetRowCellValue(e.RowHandle, colFlag)) Mod 2 <> 0
                e.Item.AllowGlyphSkinning = DefaultBoolean.False
                e.Item.Visibility = If(flagged, ContextItemVisibility.Visible, ContextItemVisibility.Auto)
            ElseIf Equals(e.Item.Name, "cbExclamation") Then
                Dim priority As Boolean = CInt(tileView.GetRowCellValue(e.RowHandle, colPriority)) = 2
                e.Item.AllowGlyphSkinning = DefaultBoolean.False
                e.Item.Visibility = If(priority, ContextItemVisibility.Visible, ContextItemVisibility.Hidden)
            Else
                e.Item.AllowGlyphSkinning = DefaultBoolean.True
                e.Item.AppearanceNormal.ForeColor = CType(tileView.GetViewInfo(), ITileControl).ViewInfo.AppearanceText.ForeColor
                e.Item.AppearanceHover.ForeColor = e.Item.AppearanceNormal.ForeColor
            End If
        End Sub

#End Region
        Private _compactTemplate As Boolean = False

        Private Property CompactTemplate As Boolean
            Get
                Return _compactTemplate
            End Get

            Set(ByVal value As Boolean)
                If _compactTemplate = value Then Return
                _compactTemplate = value
                tileView.RefreshData()
            End Set
        End Property

        Private Sub ViewModel_SortInfoChanged(ByVal sender As Object, ByVal e As EventArgs)
            tileView.SortInfo.Clear()
            tileView.SortInfo.Add(ViewModel.SortInfo)
        End Sub

        Private Sub UpdateSortItemsImageIndexes()
            biSortDate.ImageIndex = -1
            biSortFrom.ImageIndex = -1
            biSortRead.ImageIndex = -1
            biSortSubject.ImageIndex = -1
            biSortImportance.ImageIndex = -1
        End Sub

        Public Sub SetMailType(ByVal mailType As MailType)
            ViewModel.CurrentMailType = mailType
            gridControl1.RefreshDataSource()
        End Sub

        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.MessageDeleted, AddressOf ViewModel_MessageDeleted
            RemoveHandler ViewModel.MessageFlagged, AddressOf ViewModel_MessageFlagged
            RemoveHandler ViewModel.MessageChanged, AddressOf ViewModel_MessageChanged
            RemoveHandler tileView.MouseMove, AddressOf TileView_MouseMove
            MyBase.OnDisposing()
        End Sub

        Private Sub gridControl1_ControlAdded(ByVal sender As Object, ByVal e As ControlEventArgs)
            If TypeOf e.Control Is FindControl Then
                If e.Control.Controls.Count > 0 Then
                    Dim layoutControls = e.Control.Controls.OfType(Of LayoutControl)()
                    For Each ctrl In layoutControls
                        Dim layoutControlGroup = TryCast(ctrl.Items.FindByName("Root"), LayoutControlGroup)
                        If layoutControlGroup IsNot Nothing Then layoutControlGroup.Padding = New XtraLayout.Utils.Padding(18, 10, 5, 5)
                        Dim items = ctrl.Items.OfType(Of LayoutControlItem)()
                        For Each item As LayoutControlItem In items
                            item.Padding = New XtraLayout.Utils.Padding(item.Padding.Left, item.Padding.Right, 0, 0)
                        Next
                    Next
                End If
            End If
        End Sub
    End Class
End Namespace
