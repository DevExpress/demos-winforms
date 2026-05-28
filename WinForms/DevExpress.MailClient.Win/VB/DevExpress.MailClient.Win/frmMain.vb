Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPrinting
Imports DevExpress.Utils.About
Imports DevExpress.MailClient.Win.Forms
Imports DevExpress.XtraEditors.ColorWheel
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Taskbar.Core
Imports DevExpress.Utils.Taskbar
Imports System.Globalization

Namespace DevExpress.MailClient.Win
    Partial Public Class frmMain
        Inherits RibbonForm

        Private currentMailType As MailType = MailType.Inbox
        Private modulesNavigator As ModulesNavigator
        Friend FilterColumnManager As FilterColumnsManager
        Private zoomManager_Field As ZoomManager
        Private AllowCustomizationMenuList As New List(Of BarItem)()
        Public Sub New()
            TaskbarHelper.InitDemoJumpList(TaskbarAssistant.Default, Me)
            InitializeComponent()
            rpcSearch.Text = TagResources.SearchTools
            InitNavBarGroups()
            SkinHelper.InitSkinGallery(rgbiSkins)
            RibbonButtonsInitialize()
            modulesNavigator = New ModulesNavigator(ribbonControl1, pcMain)
            zoomManager_Field = New ZoomManager(ribbonControl1, modulesNavigator, beiZoom)
            modulesNavigator.ChangeGroup(navBarControl1.ActiveGroup, Me)
            NavigationInitialize()
            SetPageLayoutStyle()
        End Sub
        Private Sub NavigationInitialize()
            For Each group As NavBarGroup In navBarControl1.Groups
                If Not group.Visible Then
                    Continue For
                End If
                Dim item As New BarButtonItem(ribbonControl1.Manager, group.Caption)
                item.Tag = group
                item.Glyph = group.SmallImage
                AddHandler item.ItemClick, AddressOf item_ItemClick
                bsiNavigation.ItemLinks.Add(item)
            Next group
        End Sub
        Private Sub item_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            navBarControl1.ActiveGroup = CType(e.Item.Tag, NavBarGroup)
        End Sub
        Private Sub RibbonButtonsInitialize()
            InitBarButtonItem(bbiRotateLayout, TagResources.RotateLayout, My.Resources.RotateLayoutDescription)
            InitBarButtonItem(bbiFlipLayout, TagResources.FlipLayout, My.Resources.FlipLayoutDescription)
            InitBarButtonItem(bbiDelete, TagResources.DeleteItem, My.Resources.DeleteItemDescription)
            InitBarButtonItem(bbiNew, TagResources.NewMail, My.Resources.NewItemDescription)
            InitBarButtonItem(bbiReply, TagResources.Reply, My.Resources.ReplyDescription)
            InitBarButtonItem(bbiReplyAll, TagResources.ReplyAll, My.Resources.ReplyAllDescription)
            InitBarButtonItem(bbiForward, TagResources.Forward, My.Resources.ForwardDescription)
            InitBarButtonItem(bbiUnreadRead, TagResources.UnreadRead, My.Resources.UnreadReadDescription)
            InitBarButtonItem(bbiCloseSearch, TagResources.CloseSearch, My.Resources.CloseSearchDescription)
            InitBarButtonItem(bbiSubjectColumn, TagResources.SubjectColumn)
            InitBarButtonItem(bbiFromColumn, TagResources.PersonColumn)
            InitBarButtonItem(bbiDateColumn, TagResources.DateColumn)
            InitBarButtonItem(bbiPriorityColumn, TagResources.PriorityColumn)
            InitBarButtonItem(bbiAttachmentColumn, TagResources.AttachmentColumn)
            InitBarButtonItem(bbiResetColumnsToDefault, TagResources.ResetColumnsToDefault)
            InitBarButtonItem(bbiDate, TagResources.DateFilterMenu)
            InitBarButtonItem(bbiClearFilter, TagResources.ClearFilter)
            InitBarButtonItem(bbiNewFeed, TagResources.FeedNew, My.Resources.NewFeedDescription)
            InitBarButtonItem(bbiEditFeed, TagResources.FeedEdit, My.Resources.EditFeedDescription)
            InitBarButtonItem(bbiDeleteFeed, TagResources.FeedDelete, My.Resources.DeleteFeedDescription)
            InitBarButtonItem(bbiRefreshFeed, TagResources.FeedRefresh, My.Resources.RefreshFeedDescription)
            InitBarButtonItem(bbiNewContact, TagResources.ContactNew, My.Resources.NewContactDescription)
            InitBarButtonItem(bbiEditContact, TagResources.ContactEdit, My.Resources.EditContactDescription)
            InitBarButtonItem(bbiDeleteContact, TagResources.ContactDelete, My.Resources.DeleteContactDescription)
            InitBarButtonItem(bbiNewTask, TagResources.TaskNew, My.Resources.NewTaskDescription)
            InitBarButtonItem(bbiEditTask, TagResources.TaskEdit, My.Resources.EditTaskDescription)
            InitBarButtonItem(bbiDeleteTask, TagResources.TaskDelete, My.Resources.DeleteTaskDescription)
            InitBarButtonItem(bbiTodayFlag, FlagStatus.Today, My.Resources.FlagTodayDescription)
            InitBarButtonItem(bbiTomorrowFlag, FlagStatus.Tomorrow, My.Resources.FlagTomorrowDescription)
            InitBarButtonItem(bbiThisWeekFlag, FlagStatus.ThisWeek, My.Resources.FlagThisWeekDescription)
            InitBarButtonItem(bbiNextWeekFlag, FlagStatus.NextWeek, My.Resources.FlagNextWeekDescription)
            InitBarButtonItem(bbiNoDateFlag, FlagStatus.NoDate, My.Resources.FlagNoDatekDescription)
            InitBarButtonItem(bbiCustomFlag, FlagStatus.Custom, My.Resources.FlagCustomDescription)
            InitBarButtonItem(bbiShowPreview, TagResources.Preview, My.Resources.ShowPreviewDescription)
            InitGalleryItem(rgbiCurrentView.Gallery.Groups(0).Items(0), TagResources.ContactList, My.Resources.ContactListDescription)
            InitGalleryItem(rgbiCurrentView.Gallery.Groups(0).Items(1), TagResources.ContactAlphabetical, My.Resources.ContactAlphabeticalDescription)
            InitGalleryItem(rgbiCurrentView.Gallery.Groups(0).Items(2), TagResources.ContactByState, My.Resources.ContactByStateDescription)
            InitGalleryItem(rgbiCurrentView.Gallery.Groups(0).Items(3), TagResources.ContactCard, My.Resources.ContactCardDescription)
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(0), TagResources.TaskList, My.Resources.TaskListDescription)
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(1), TagResources.TaskToDoList, My.Resources.TaskToDoListDescription)
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(2), TagResources.TaskCompleted, My.Resources.TaskCompletedDescription)
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(3), TagResources.TaskToday, My.Resources.TaskTodayDescription)
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(4), TagResources.TaskPrioritized, My.Resources.TaskPrioritizedDescription)
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(5), TagResources.TaskOverdue, My.Resources.TaskOverdueDescription)
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(6), TagResources.TaskSimpleList, My.Resources.TaskSimpleListDescription)
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(7), TagResources.TaskDeferred, My.Resources.TaskDeferredDescription)
            bvbiSaveAs.Tag = TagResources.MenuSaveAs
            bvbiSaveAttachment.Tag = TagResources.MenuSaveAttachment
            bvbiSaveCalendar.Tag = TagResources.MenuSaveCalendar
            bbiPriority.Hint = My.Resources.PriorityDescription
            bsiNavigation.Hint = My.Resources.NavigationDescription
            bbiShowUnread.Hint = My.Resources.SearchUnreadDescription
            bbiDate.Hint = My.Resources.SearchReceivedDescription
            bbiImportant.Hint = My.Resources.SearchImportantDescription
            bbiHasAttachment.Hint = My.Resources.SearchHasAttachmentDescription
            bbiClearFilter.Hint = My.Resources.SearchClearDescription
            bsiColumns.Hint = My.Resources.SearchColumnsDescription
            bbiResetColumnsToDefault.Hint = My.Resources.SearchResetDescription
            bbiCloseSearch.Hint = My.Resources.SearchCloseDescription
            bbiReminder.Glyph = My.Resources.reminder

            Dim items As New List(Of BarButtonItem)()
            items.Add(bbiSubjectColumn)
            items.Add(bbiFromColumn)
            items.Add(bbiDateColumn)
            items.Add(bbiPriorityColumn)
            items.Add(bbiAttachmentColumn)
            items.Add(bbiDate)
            FilterColumnManager = New FilterColumnsManager(items)
            ucContacts1.SynchronizeGalleryItems(rgbiCurrentView)
            ucCalendar1.SetBarController(schedulerBarController1)
            AllowCustomizationMenuList.Add(bbiFlipLayout)
            AllowCustomizationMenuList.Add(bbiRotateLayout)
            AllowCustomizationMenuList.Add(bsiNavigation)
            AllowCustomizationMenuList.Add(rgbiSkins)
            ribbonControl1.Toolbar.ItemLinks.Add(rgbiSkins)
        End Sub

        Private Sub InitGalleryItem(ByVal galleryItem As GalleryItem, ByVal tag As String, ByVal description As String)
            galleryItem.Tag = tag
            galleryItem.Hint = description
        End Sub
        Friend ReadOnly Property ShowPreview() As Boolean
            Get
                Return bbiShowPreview.Down
            End Get
        End Property
        Friend ReadOnly Property ZoomManager() As ZoomManager
            Get
                Return zoomManager_Field
            End Get
        End Property
        Friend ReadOnly Property ShowUnreadItem() As BarButtonItem
            Get
                Return bbiShowUnread
            End Get
        End Property
        Friend ReadOnly Property ImportantItem() As BarButtonItem
            Get
                Return bbiImportant
            End Get
        End Property
        Friend ReadOnly Property HasAttachmentItem() As BarButtonItem
            Get
                Return bbiHasAttachment
            End Get
        End Property
        Friend ReadOnly Property ClearFilterItem() As BarButtonItem
            Get
                Return bbiClearFilter
            End Get
        End Property
        Friend ReadOnly Property SaveAsMenuItem() As BackstageViewButtonItem
            Get
                Return bvbiSaveAs
            End Get
        End Property
        Friend ReadOnly Property SaveAttachmentMenuItem() As BackstageViewButtonItem
            Get
                Return bvbiSaveAttachment
            End Get
        End Property
        Friend ReadOnly Property SaveCalendar() As BackstageViewButtonItem
            Get
                Return bvbiSaveCalendar
            End Get
        End Property
        Friend ReadOnly Property TaskGallery() As InRibbonGallery
            Get
                Return rgbiCurrentViewTasks.Gallery
            End Get
        End Property
        Friend ReadOnly Property FlagStatusMenu() As PopupMenu
            Get
                Return pmFlagStatus
            End Get
        End Property
        Private Sub InitBarButtonItem(ByVal buttonItem As DevExpress.XtraBars.BarButtonItem, ByVal tag As Object)
            InitBarButtonItem(buttonItem, tag, String.Empty)
        End Sub
        Private Sub InitBarButtonItem(ByVal buttonItem As DevExpress.XtraBars.BarButtonItem, ByVal tag As Object, ByVal description As String)
            AddHandler buttonItem.ItemClick, AddressOf bbi_ItemClick
            buttonItem.Hint = description
            buttonItem.Tag = tag
        End Sub
        Private Sub InitNavBarGroups()
            nbgMail.Tag = New NavBarGroupTagObject("Mail", GetType(DevExpress.MailClient.Win.Mail))
            nbgCalendar.Tag = New NavBarGroupTagObject("Calendar", GetType(DevExpress.MailClient.Win.Calendar))
            nbgContacts.Tag = New NavBarGroupTagObject("Contacts", GetType(DevExpress.MailClient.Win.Contacts))
            nbgTasks.Tag = New NavBarGroupTagObject("Tasks", GetType(DevExpress.MailClient.Win.Tasks))
        End Sub
        Public Sub ReadMessagesChanged()
            ucMailTree1.RefreshTreeList()
        End Sub
        Public Sub UpdateTreeViewMessages()
            ucMailTree1.UpdateTreeViewMessages()
        End Sub
        Friend Sub EnableDelete(ByVal enabled As Boolean)
            bbiDelete.Enabled = enabled
            bbiUnreadRead.Enabled = enabled
            bbiPriority.Enabled = enabled
        End Sub
        Friend Sub EnableMail(ByVal enabled As Boolean, ByVal unread As Boolean)
            bbiReply.Enabled = enabled AndAlso currentMailType = MailType.Inbox
            bbiReplyAll.Enabled = enabled AndAlso currentMailType = MailType.Inbox
            bbiForward.Enabled = enabled AndAlso currentMailType = MailType.Inbox
        End Sub
        Friend Sub EnableEditFeed(ByVal enabled As Boolean)
            bbiDeleteFeed.Enabled = enabled
            bbiEditFeed.Enabled = enabled
            bbiRefreshFeed.Enabled = enabled
        End Sub
        Friend Sub EnableEditContact(ByVal enabled As Boolean)
            bbiDeleteContact.Enabled = enabled
            bbiEditContact.Enabled = enabled
        End Sub
        Friend Sub EnableLayoutButtons(ByVal enabled As Boolean)
            bbiRotateLayout.Enabled = enabled
            bbiFlipLayout.Enabled = enabled
        End Sub
        Friend Sub EnabledFlagButtons(ByVal enabledCurrentTask As Boolean, ByVal enabledEdit As Boolean, ByVal task As Task)
            Dim list As New List(Of BarButtonItem)() From {bbiTodayFlag, bbiTomorrowFlag, bbiThisWeekFlag, bbiNextWeekFlag, bbiNoDateFlag, bbiCustomFlag}
            For Each item As BarButtonItem In list
                item.Enabled = enabledCurrentTask
                If task IsNot Nothing Then
                    item.Down = task.FlagStatus.Equals(item.Tag)
                Else
                    item.Down = False
                End If
            Next item
            bbiDeleteTask.Enabled = enabledCurrentTask
            bbiEditTask.Enabled = enabledEdit
        End Sub
        Friend Sub EnableZoomControl(ByVal enabled As Boolean)
            beiZoom.Enabled = enabled
        End Sub
        Friend Sub SetPriorityMenu(ByVal menu As PopupMenu)
            bbiPriority.DropDownControl = menu
        End Sub
        Friend Sub SetDateFilterMenu(ByVal menu As PopupMenu)
            bbiDate.DropDownControl = menu
        End Sub
        Friend Sub ShowMessageMenu(ByVal location As Point)
            pmMessage.ShowPopup(location)
        End Sub
        Friend Sub ShowReminder(ByVal reminders As List(Of Task))
            Dim allowReminders As Boolean = reminders IsNot Nothing AndAlso reminders.Count > 0
            bbiReminder.Visibility = If(allowReminders, BarItemVisibility.Always, BarItemVisibility.Never)
            bsiTemp.Visibility = If(allowReminders, BarItemVisibility.Never, BarItemVisibility.Always)
            If allowReminders Then
                bbiReminder.Caption = String.Format(My.Resources.ReminderText, reminders.Count)
                bbiReminder.Tag = reminders
            End If
        End Sub
        Friend Sub ShowInfo(ByVal count? As Integer)
            If count Is Nothing Then
                bsiInfo.Caption = String.Empty
            Else
                bsiInfo.Caption = String.Format(My.Resources.InfoText, count.Value)
            End If
            HtmlText = String.Format("{0}{1}", GetModuleName(), GetModulePartName())
        End Sub
        Private Function GetModuleName() As String
            If String.IsNullOrEmpty(modulesNavigator.CurrentModule.PartName) Then
                Return CurrentModuleName
            End If
            Return String.Format("<b>{0}</b>", CurrentModuleName)
        End Function
        Private Function GetModulePartName() As String
            If String.IsNullOrEmpty(modulesNavigator.CurrentModule.PartName) Then
                Return Nothing
            End If
            Return String.Format(" - {0}", modulesNavigator.CurrentModule.PartName)
        End Function
        Private Sub navBarControl1_ActiveGroupChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarGroupEventArgs) Handles navBarControl1.ActiveGroupChanged
            Dim data As Object = GetModuleData(CType(e.Group.Tag, NavBarGroupTagObject))
            modulesNavigator.ChangeGroup(e.Group, data)
        End Sub
        Private Sub bbi_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            modulesNavigator.CurrentModule.ButtonClick(String.Format("{0}", e.Item.Tag))
        End Sub
        Private Sub ucMailTree1_DataSourceChanged(ByVal sender As Object, ByVal e As DataSourceChangedEventArgs) Handles ucMailTree1.DataSourceChanged
            currentMailType = e.Type
            modulesNavigator.CurrentModule.MessagesDataChanged(e)
            ShowInfo(e.List.Count)
        End Sub
        Private Sub ucMailTree1_ShowMenu(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ucMailTree1.ShowMenu
            pmTreeView.ShowPopup(ucMailTree1.PointToScreen(e.Location))
        End Sub
        Private Sub pmTreeView_BeforePopup(ByVal sender As Object, ByVal e As CancelEventArgs) Handles pmTreeView.BeforePopup
            biCreateFolder.Enabled = Not ucMailTree1.IsDeletedFolderFocused()
            biRename.Enabled = Not ucMailTree1.IsDeletedFolderFocused()
            bciShowAllMessageCount.Checked = DataHelper.ShowAllMessageCount
            bciShowUnreadMessageCount.Checked = DataHelper.ShowUnreadMessageCount
        End Sub
        Private Sub bciShowAllMessageCount_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bciShowAllMessageCount.CheckedChanged
            DataHelper.ShowAllMessageCount = bciShowAllMessageCount.Checked
            ucMailTree1.RefreshTreeList()
        End Sub
        Private Sub bciShowUnreadMessageCount_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bciShowUnreadMessageCount.CheckedChanged
            DataHelper.ShowUnreadMessageCount = bciShowUnreadMessageCount.Checked
            ucMailTree1.RefreshTreeList()
        End Sub
        Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
            If modulesNavigator IsNot Nothing AndAlso modulesNavigator.CurrentModule IsNot Nothing Then
                modulesNavigator.CurrentModule.SendKeyDown(e)
            End If
        End Sub
        Protected Function GetModuleData(ByVal tag As NavBarGroupTagObject) As Object
            If tag Is Nothing Then
                Return Nothing
            End If
            If tag.ModuleType Is GetType(DevExpress.MailClient.Win.Calendar) Then
                Return ucCalendar1
            End If
            If tag.ModuleType Is GetType(DevExpress.MailClient.Win.Tasks) Then
                Return nbgTasks
            End If
            Return Nothing
        End Function
        Private Sub navBarControl1_NavPaneStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles navBarControl1.NavPaneStateChanged
            ucCalendar1.StateChanged(navBarControl1.OptionsNavPane.ActualNavPaneState)
            SetPageLayoutStyle()
        End Sub
        Private moduleTag As Object = Nothing
        Private Sub ucContacts1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ucContacts1.CheckedChanged
            moduleTag = DirectCast(sender, CheckEdit).Tag
            BeginInvoke(New MethodInvoker(AddressOf NavigateModule))
        End Sub
        Private Sub NavigateModule()
            modulesNavigator.CurrentModule.ButtonClick(String.Format("{0}", moduleTag))
        End Sub

        Private Sub bvbiExit_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs) Handles bvbiExit.ItemClick
            Me.Close()
        End Sub

        Private Sub galleryControlGallery1_ItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs) Handles galleryControl1.Gallery.ItemClick
            If TagResources.OpenCalendar.Equals(e.Item.Tag) Then
                ribbonControl1.HideApplicationButtonContentControl()
                Me.Refresh()
                navBarControl1.ActiveGroup = nbgCalendar
            End If
            modulesNavigator.CurrentModule.ButtonClick(String.Format("{0}", e.Item.Tag))
        End Sub

        Private Sub backstageViewControl1_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs) Handles backstageViewControl1.ItemClick
            If modulesNavigator.CurrentModule Is Nothing Then
                Return
            End If
            modulesNavigator.CurrentModule.ButtonClick(String.Format("{0}", e.Item.Tag))
        End Sub
        Private Sub SetPageLayoutStyle()
            bbiNormal.Down = navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded
            bbiReading.Down = navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed
        End Sub

        Private Sub bbiNormal_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiNormal.ItemClick
            If bbiNormal.Down Then
                navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded
            Else
                bbiNormal.Down = True
            End If
        End Sub

        Private Sub bbiReading_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiReading.ItemClick
            If bbiReading.Down Then
                navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed
            Else
                bbiReading.Down = True
            End If
        End Sub

        Private Sub rgbiCurrentView_GalleryInitDropDownGallery(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs) Handles rgbiCurrentView.GalleryInitDropDownGallery, rgbiCurrentViewTasks.GalleryInitDropDownGallery
            e.PopupGallery.GalleryDropDown.ItemLinks.Add(bbiManageView)
            e.PopupGallery.GalleryDropDown.ItemLinks.Add(bbiSaveCurrentView)
            e.PopupGallery.SynchWithInRibbonGallery = True
        End Sub

        Private Sub rgbiCurrentViewTasks_GalleryItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs) Handles rgbiCurrentViewTasks.GalleryItemClick
            modulesNavigator.CurrentModule.ButtonClick(String.Format("{0}", e.Item.Tag))
        End Sub

        Private Sub ucCalendar1_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ucCalendar1.VisibleChanged
            If ucCalendar1.Visible Then
                ucCalendar1.UpdateTreeListHeight()
            End If
        End Sub

        Private Sub bvtiPrint_SelectedChanged(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs) Handles bvtiPrint.SelectedChanged
            If backstageViewControl1.SelectedTab Is bvtiPrint Then
                Me.printControl1.InitPrintingSystem()
            End If
        End Sub
        Private Sub ribbonControl1_BeforeApplicationButtonContentControlShow(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonControl1.BeforeApplicationButtonContentControlShow
            If backstageViewControl1.SelectedTab Is bvtiPrint Then
                backstageViewControl1.SelectedTab = bvtiInfo
            End If
            bvtiPrint.Enabled = CurrentRichEdit IsNot Nothing OrElse CurrentPrintableComponent IsNot Nothing
            bvtiExport.Enabled = CurrentExportComponent IsNot Nothing
        End Sub
        Public ReadOnly Property CurrentPrintableComponent() As IPrintable
            Get
                Return modulesNavigator.CurrentModule.PrintableComponent
            End Get
        End Property
        Public ReadOnly Property CurrentExportComponent() As IPrintable
            Get
                Return modulesNavigator.CurrentModule.ExportComponent
            End Get
        End Property
        Public ReadOnly Property CurrentRichEdit() As RichEditControl
            Get
                Return modulesNavigator.CurrentModule.CurrentRichEdit
            End Get
        End Property
        Public ReadOnly Property CurrentModuleName() As String
            Get
                Return modulesNavigator.CurrentModule.ModuleName
            End Get
        End Property

        Private Sub ribbonControl1_ShowCustomizationMenu(ByVal sender As Object, ByVal e As RibbonCustomizationMenuEventArgs) Handles ribbonControl1.ShowCustomizationMenu
            e.CustomizationMenu.InitializeMenu()
            If e.Link Is Nothing OrElse (Not AllowCustomizationMenuList.Contains(e.Link.Item)) Then
                e.CustomizationMenu.RemoveLink(e.CustomizationMenu.ItemLinks(0))
            End If
        End Sub

        Private Sub ucMailTree1_UCTreeDragDrop(ByVal sender As Object, ByVal e As UCTreeDragDropEventArgs) Handles ucMailTree1.UCTreeDragDrop
            If TypeOf modulesNavigator.CurrentModule Is Mail Then
                DirectCast(modulesNavigator.CurrentModule, Mail).OnMoveEmails(ucMailTree1, e)
            End If
        End Sub

        Private Sub biRename_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biRename.ItemClick
            ucMailTree1.StartEditing()
        End Sub

        Private Sub biCreateFolder_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biCreateFolder.ItemClick
            ucMailTree1.CreateNewFolder()
        End Sub

        Private Sub bbiReminder_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiReminder.ItemClick
            Using frm As New frmReminders()
                frm.InitData(TryCast(bbiReminder.Tag, List(Of Task)))
                If frm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    modulesNavigator.CurrentModule.FocusObject(frm.CurrentTask)
                    modulesNavigator.CurrentModule.ButtonClick(TagResources.TaskEdit)
                End If
            End Using
        End Sub
    End Class
End Namespace
