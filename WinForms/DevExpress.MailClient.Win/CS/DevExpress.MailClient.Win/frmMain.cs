using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.MailClient.Win.Forms;
using DevExpress.Utils.About;
using DevExpress.Utils.Taskbar;
using DevExpress.Utils.Taskbar.Core;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit;

namespace DevExpress.MailClient.Win {
    public partial class frmMain : RibbonForm {
        MailType currentMailType = MailType.Inbox;
        ModulesNavigator modulesNavigator;
        internal FilterColumnsManager FilterColumnManager;
        ZoomManager zoomManager;
        List<BarItem> AllowCustomizationMenuList = new List<BarItem>();
        public frmMain() {
            TaskbarHelper.InitDemoJumpList(TaskbarAssistant.Default, this);
            InitializeComponent();
            rpcSearch.Text = TagResources.SearchTools;
            InitNavBarGroups();
            RibbonButtonsInitialize();
            modulesNavigator = new ModulesNavigator(ribbonControl1, pcMain);
            zoomManager = new ZoomManager(ribbonControl1, modulesNavigator, beiZoom);
            modulesNavigator.ChangeGroup(navBarControl1.ActiveGroup, this);
            NavigationInitialize();
            SetPageLayoutStyle();
        }
        void NavigationInitialize() {
            foreach(NavBarGroup group in navBarControl1.Groups) {
                if(!group.Visible) continue;
                BarButtonItem item = new BarButtonItem(ribbonControl1.Manager, group.Caption);
                item.Tag = group;
                item.Glyph = group.SmallImage;
                item.ItemClick += new ItemClickEventHandler(item_ItemClick);
                bsiNavigation.ItemLinks.Add(item);
            }
        }
        void item_ItemClick(object sender, ItemClickEventArgs e) {
            navBarControl1.ActiveGroup = (NavBarGroup)e.Item.Tag;
        }
        void RibbonButtonsInitialize() {
            InitBarButtonItem(bbiRotateLayout, TagResources.RotateLayout, Properties.Resources.RotateLayoutDescription);
            InitBarButtonItem(bbiFlipLayout, TagResources.FlipLayout, Properties.Resources.FlipLayoutDescription);
            InitBarButtonItem(bbiDelete, TagResources.DeleteItem, Properties.Resources.DeleteItemDescription);
            InitBarButtonItem(bbiNew, TagResources.NewMail, Properties.Resources.NewItemDescription);
            InitBarButtonItem(bbiReply, TagResources.Reply, Properties.Resources.ReplyDescription);
            InitBarButtonItem(bbiReplyAll, TagResources.ReplyAll, Properties.Resources.ReplyAllDescription);
            InitBarButtonItem(bbiForward, TagResources.Forward, Properties.Resources.ForwardDescription);
            InitBarButtonItem(bbiUnreadRead, TagResources.UnreadRead, Properties.Resources.UnreadReadDescription);
            InitBarButtonItem(bbiCloseSearch, TagResources.CloseSearch, Properties.Resources.CloseSearchDescription);
            InitBarButtonItem(bbiSubjectColumn, TagResources.SubjectColumn);
            InitBarButtonItem(bbiFromColumn, TagResources.PersonColumn);
            InitBarButtonItem(bbiDateColumn, TagResources.DateColumn);
            InitBarButtonItem(bbiPriorityColumn, TagResources.PriorityColumn);
            InitBarButtonItem(bbiAttachmentColumn, TagResources.AttachmentColumn);
            InitBarButtonItem(bbiResetColumnsToDefault, TagResources.ResetColumnsToDefault);
            InitBarButtonItem(bbiDate, TagResources.DateFilterMenu);
            InitBarButtonItem(bbiClearFilter, TagResources.ClearFilter);
            InitBarButtonItem(bbiNewFeed, TagResources.FeedNew, Properties.Resources.NewFeedDescription);
            InitBarButtonItem(bbiEditFeed, TagResources.FeedEdit, Properties.Resources.EditFeedDescription);
            InitBarButtonItem(bbiDeleteFeed, TagResources.FeedDelete, Properties.Resources.DeleteFeedDescription);
            InitBarButtonItem(bbiRefreshFeed, TagResources.FeedRefresh, Properties.Resources.RefreshFeedDescription);
            InitBarButtonItem(bbiNewContact, TagResources.ContactNew, Properties.Resources.NewContactDescription);
            InitBarButtonItem(bbiEditContact, TagResources.ContactEdit, Properties.Resources.EditContactDescription);
            InitBarButtonItem(bbiDeleteContact, TagResources.ContactDelete, Properties.Resources.DeleteContactDescription);
            InitBarButtonItem(bbiNewTask, TagResources.TaskNew, Properties.Resources.NewTaskDescription);
            InitBarButtonItem(bbiEditTask, TagResources.TaskEdit, Properties.Resources.EditTaskDescription);
            InitBarButtonItem(bbiDeleteTask, TagResources.TaskDelete, Properties.Resources.DeleteTaskDescription);
            InitBarButtonItem(bbiTodayFlag, FlagStatus.Today, Properties.Resources.FlagTodayDescription);
            InitBarButtonItem(bbiTomorrowFlag, FlagStatus.Tomorrow, Properties.Resources.FlagTomorrowDescription);
            InitBarButtonItem(bbiThisWeekFlag, FlagStatus.ThisWeek, Properties.Resources.FlagThisWeekDescription);
            InitBarButtonItem(bbiNextWeekFlag, FlagStatus.NextWeek, Properties.Resources.FlagNextWeekDescription);
            InitBarButtonItem(bbiNoDateFlag, FlagStatus.NoDate, Properties.Resources.FlagNoDatekDescription);
            InitBarButtonItem(bbiCustomFlag, FlagStatus.Custom, Properties.Resources.FlagCustomDescription);
            InitBarButtonItem(bbiShowPreview, TagResources.Preview, Properties.Resources.ShowPreviewDescription);
            InitGalleryItem(rgbiCurrentView.Gallery.Groups[0].Items[0], TagResources.ContactList, Properties.Resources.ContactListDescription);
            InitGalleryItem(rgbiCurrentView.Gallery.Groups[0].Items[1], TagResources.ContactAlphabetical, Properties.Resources.ContactAlphabeticalDescription);
            InitGalleryItem(rgbiCurrentView.Gallery.Groups[0].Items[2], TagResources.ContactByState, Properties.Resources.ContactByStateDescription);
            InitGalleryItem(rgbiCurrentView.Gallery.Groups[0].Items[3], TagResources.ContactCard, Properties.Resources.ContactCardDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[0], TagResources.TaskList, Properties.Resources.TaskListDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[1], TagResources.TaskToDoList, Properties.Resources.TaskToDoListDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[2], TagResources.TaskCompleted, Properties.Resources.TaskCompletedDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[3], TagResources.TaskToday, Properties.Resources.TaskTodayDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[4], TagResources.TaskPrioritized, Properties.Resources.TaskPrioritizedDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[5], TagResources.TaskOverdue, Properties.Resources.TaskOverdueDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[6], TagResources.TaskSimpleList, Properties.Resources.TaskSimpleListDescription);
            InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups[0].Items[7], TagResources.TaskDeferred, Properties.Resources.TaskDeferredDescription);
            bvbiSaveAs.Tag = TagResources.MenuSaveAs;
            bvbiSaveAttachment.Tag = TagResources.MenuSaveAttachment;
            bvbiSaveCalendar.Tag = TagResources.MenuSaveCalendar;
            bbiPriority.Hint = Properties.Resources.PriorityDescription;
            bsiNavigation.Hint = Properties.Resources.NavigationDescription;
            bbiShowUnread.Hint = Properties.Resources.SearchUnreadDescription;
            bbiDate.Hint = Properties.Resources.SearchReceivedDescription;
            bbiImportant.Hint = Properties.Resources.SearchImportantDescription;
            bbiHasAttachment.Hint = Properties.Resources.SearchHasAttachmentDescription;
            bbiClearFilter.Hint = Properties.Resources.SearchClearDescription;
            bsiColumns.Hint = Properties.Resources.SearchColumnsDescription;
            bbiResetColumnsToDefault.Hint = Properties.Resources.SearchResetDescription;
            bbiCloseSearch.Hint = Properties.Resources.SearchCloseDescription;
            bbiReminder.ImageOptions.SvgImage = Properties.Resources.Reminder;

            List<BarButtonItem> items = new List<BarButtonItem>();
            items.Add(bbiSubjectColumn);
            items.Add(bbiFromColumn);
            items.Add(bbiDateColumn);
            items.Add(bbiPriorityColumn);
            items.Add(bbiAttachmentColumn);
            items.Add(bbiDate);
            FilterColumnManager = new FilterColumnsManager(items);
            ucContacts1.SynchronizeGalleryItems(rgbiCurrentView);
            ucCalendar1.SetBarController(schedulerBarController1);
            AllowCustomizationMenuList.Add(bbiFlipLayout);
            AllowCustomizationMenuList.Add(bbiRotateLayout);
            AllowCustomizationMenuList.Add(bsiNavigation);
            AllowCustomizationMenuList.Add(skinDropDownButtonItem1);
            AllowCustomizationMenuList.Add(skinPaletteRibbonGalleryBarItem1);
            ribbonControl1.Toolbar.ItemLinks.Add(skinDropDownButtonItem1);
            ribbonControl1.Toolbar.ItemLinks.Add(skinPaletteRibbonGalleryBarItem1);
        }

        void InitGalleryItem(GalleryItem galleryItem, string tag, string description) {
            galleryItem.Tag = tag;
            galleryItem.Hint = description;
        }
        internal bool ShowPreview { get { return bbiShowPreview.Down; } }
        internal ZoomManager ZoomManager { get { return zoomManager; } }
        internal BarButtonItem ShowUnreadItem { get { return bbiShowUnread; } }
        internal BarButtonItem ImportantItem { get { return bbiImportant; } }
        internal BarButtonItem HasAttachmentItem { get { return bbiHasAttachment; } }
        internal BarButtonItem ClearFilterItem { get { return bbiClearFilter; } }
        internal BackstageViewButtonItem SaveAsMenuItem { get { return bvbiSaveAs; } }
        internal BackstageViewButtonItem SaveAttachmentMenuItem { get { return bvbiSaveAttachment; } }
        internal BackstageViewButtonItem SaveCalendar { get { return bvbiSaveCalendar; } }
        internal InRibbonGallery TaskGallery { get { return rgbiCurrentViewTasks.Gallery; } }
        internal PopupMenu FlagStatusMenu { get { return pmFlagStatus; } }
        void InitBarButtonItem(DevExpress.XtraBars.BarButtonItem buttonItem, object tag) {
            InitBarButtonItem(buttonItem, tag, string.Empty);
        }
        void InitBarButtonItem(DevExpress.XtraBars.BarButtonItem buttonItem, object tag, string description) {
            buttonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbi_ItemClick);
            buttonItem.Hint = description;
            buttonItem.Tag = tag;
        }
        void InitNavBarGroups() {
            nbgMail.Tag = new NavBarGroupTagObject("Mail", typeof(DevExpress.MailClient.Win.Mail));
            nbgCalendar.Tag = new NavBarGroupTagObject("Calendar", typeof(DevExpress.MailClient.Win.Calendar));
            nbgContacts.Tag = new NavBarGroupTagObject("Contacts", typeof(DevExpress.MailClient.Win.Contacts));
            nbgTasks.Tag = new NavBarGroupTagObject("Tasks", typeof(DevExpress.MailClient.Win.Tasks));
        }
        public void ReadMessagesChanged() {
            ucMailTree1.RefreshTreeList();
        }
        public void UpdateTreeViewMessages() {
            ucMailTree1.UpdateTreeViewMessages();
        }
        internal void EnableDelete(bool enabled) {
            bbiDelete.Enabled = enabled;
            bbiUnreadRead.Enabled = enabled;
            bbiPriority.Enabled = enabled;
        }
        internal void EnableMail(bool enabled, bool unread) {
            bbiReply.Enabled = enabled && currentMailType == MailType.Inbox;
            bbiReplyAll.Enabled = enabled && currentMailType == MailType.Inbox;
            bbiForward.Enabled = enabled && currentMailType == MailType.Inbox;
        }
        internal void EnableEditFeed(bool enabled) {
            bbiDeleteFeed.Enabled = enabled;
            bbiEditFeed.Enabled = enabled;
            bbiRefreshFeed.Enabled = enabled;
        }
        internal void EnableEditContact(bool enabled) {
            bbiDeleteContact.Enabled = enabled;
            bbiEditContact.Enabled = enabled;
        }
        internal void EnableLayoutButtons(bool enabled) {
            bbiRotateLayout.Enabled = enabled;
            bbiFlipLayout.Enabled = enabled;
        }
        internal void EnabledFlagButtons(bool enabledCurrentTask, bool enabledEdit, Task task) {
            List<BarButtonItem> list = new List<BarButtonItem> { bbiTodayFlag, bbiTomorrowFlag, bbiThisWeekFlag,
                bbiNextWeekFlag, bbiNoDateFlag, bbiCustomFlag };
            foreach(BarButtonItem item in list) {
                item.Enabled = enabledCurrentTask;
                if(task != null)
                    item.Down = task.FlagStatus.Equals(item.Tag);
                else item.Down = false;
            }
            bbiDeleteTask.Enabled = enabledCurrentTask;
            bbiEditTask.Enabled = enabledEdit;
        }
        internal void EnableZoomControl(bool enabled) {
            beiZoom.Enabled = enabled;
        }
        internal void SetPriorityMenu(PopupMenu menu) {
            bbiPriority.DropDownControl = menu;
        }
        internal void SetDateFilterMenu(PopupMenu menu) {
            bbiDate.DropDownControl = menu;
        }
        internal void ShowMessageMenu(Point location) {
            pmMessage.ShowPopup(location);
        }
        internal void ShowReminder(List<Task> reminders) {
            bool allowReminders = reminders != null && reminders.Count > 0;
            bbiReminder.Visibility = allowReminders ? BarItemVisibility.Always : BarItemVisibility.Never;
            bsiTemp.Visibility = allowReminders ? BarItemVisibility.Never : BarItemVisibility.Always;
            if(allowReminders) {
                bbiReminder.Caption = string.Format(Properties.Resources.ReminderText, reminders.Count);
                bbiReminder.Tag = reminders;
            }
        }
        internal void ShowInfo(int? count) {
            if(count == null) bsiInfo.Caption = string.Empty;
            else
                bsiInfo.Caption = string.Format(Properties.Resources.InfoText, count.Value);
            HtmlText = string.Format("{0}{1}", GetModuleName(), GetModulePartName());
        }
        string GetModuleName() {
            if(string.IsNullOrEmpty(modulesNavigator.CurrentModule.PartName)) return CurrentModuleName;
#pragma warning disable DX0025 // not a file path
            return string.Format("<b>{0}</b>", CurrentModuleName);
#pragma warning restore DX0025 // not a file path
        }
        string GetModulePartName() {
            if(string.IsNullOrEmpty(modulesNavigator.CurrentModule.PartName)) return null;
            return string.Format(" - {0}", modulesNavigator.CurrentModule.PartName);
        }
        void navBarControl1_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e) {
            object data = GetModuleData((NavBarGroupTagObject)e.Group.Tag);
            modulesNavigator.ChangeGroup(e.Group, data);
        }
        void bbi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            modulesNavigator.CurrentModule.ButtonClick(string.Format("{0}", e.Item.Tag));
        }
        void ucMailTree1_DataSourceChanged(object sender, DataSourceChangedEventArgs e) {
            currentMailType = e.Type;
            modulesNavigator.CurrentModule.MessagesDataChanged(e);
            ShowInfo(e.List.Count);
        }
        void ucMailTree1_ShowMenu(object sender, MouseEventArgs e) {
            pmTreeView.ShowPopup(ucMailTree1.PointToScreen(e.Location));
        }
        void pmTreeView_BeforePopup(object sender, CancelEventArgs e) {
            biCreateFolder.Enabled = !ucMailTree1.IsDeletedFolderFocused();
            biRename.Enabled = !ucMailTree1.IsDeletedFolderFocused();
            bciShowAllMessageCount.Checked = DataHelper.ShowAllMessageCount;
            bciShowUnreadMessageCount.Checked = DataHelper.ShowUnreadMessageCount;
        }
        void bciShowAllMessageCount_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DataHelper.ShowAllMessageCount = bciShowAllMessageCount.Checked;
            ucMailTree1.RefreshTreeList();
        }
        void bciShowUnreadMessageCount_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DataHelper.ShowUnreadMessageCount = bciShowUnreadMessageCount.Checked;
            ucMailTree1.RefreshTreeList();
        }
        void frmMain_KeyDown(object sender, KeyEventArgs e) {
            if(modulesNavigator != null && modulesNavigator.CurrentModule != null)
                modulesNavigator.CurrentModule.SendKeyDown(e);
        }
        protected object GetModuleData(NavBarGroupTagObject tag) {
            if(tag == null) return null;
            if(tag.ModuleType == typeof(DevExpress.MailClient.Win.Calendar)) return ucCalendar1;
            if(tag.ModuleType == typeof(DevExpress.MailClient.Win.Tasks)) return nbgTasks;
            return null;
        }
        void navBarControl1_NavPaneStateChanged(object sender, EventArgs e) {
            ucCalendar1.StateChanged(navBarControl1.OptionsNavPane.ActualNavPaneState);
            SetPageLayoutStyle();
        }
        object moduleTag = null;
        void ucContacts1_CheckedChanged(object sender, EventArgs e) {
            moduleTag = ((CheckEdit)sender).Tag;
            BeginInvoke(new MethodInvoker(NavigateModule));
        }
        void NavigateModule() {
            modulesNavigator.CurrentModule.ButtonClick(string.Format("{0}", moduleTag));
        }
        void bvbiExit_ItemClick(object sender, BackstageViewItemEventArgs e) {
            this.Close();
        }
        void galleryControlGallery1_ItemClick(object sender, GalleryItemClickEventArgs e) {
            if(TagResources.OpenCalendar.Equals(e.Item.Tag)) {
                ribbonControl1.HideApplicationButtonContentControl();
                this.Refresh();
                navBarControl1.ActiveGroup = nbgCalendar;
            }
            modulesNavigator.CurrentModule.ButtonClick(string.Format("{0}", e.Item.Tag));
        }
        void backstageViewControl1_ItemClick(object sender, BackstageViewItemEventArgs e) {
            if(modulesNavigator.CurrentModule == null) return;
            modulesNavigator.CurrentModule.ButtonClick(string.Format("{0}", e.Item.Tag));
        }
        void SetPageLayoutStyle() {
            bbiNormal.Down = navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Expanded;
            bbiReading.Down = navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Collapsed;
        }
        void bbiNormal_ItemClick(object sender, ItemClickEventArgs e) {
            if(bbiNormal.Down) navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded;
            else
                bbiNormal.Down = true;
        }
        void bbiReading_ItemClick(object sender, ItemClickEventArgs e) {
            if(bbiReading.Down) navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed;
            else
                bbiReading.Down = true;
        }
        void rgbiCurrentView_GalleryInitDropDownGallery(object sender, InplaceGalleryEventArgs e) {
            e.PopupGallery.GalleryDropDown.ItemLinks.Add(bbiManageView);
            e.PopupGallery.GalleryDropDown.ItemLinks.Add(bbiSaveCurrentView);
            e.PopupGallery.SynchWithInRibbonGallery = true;
        }
        void rgbiCurrentViewTasks_GalleryItemClick(object sender, GalleryItemClickEventArgs e) {
            modulesNavigator.CurrentModule.ButtonClick(string.Format("{0}", e.Item.Tag));
        }
        private void ucCalendar1_VisibleChanged(object sender, EventArgs e) {
            if(ucCalendar1.Visible)
                ucCalendar1.UpdateTreeListHeight();
        }
        void bvtiPrint_SelectedChanged(object sender, BackstageViewItemEventArgs e) {
            if(backstageViewControl1.SelectedTab == bvtiPrint)
                this.printControl1.InitPrintingSystem();
        }
        void ribbonControl1_BeforeApplicationButtonContentControlShow(object sender, EventArgs e) {
            if(backstageViewControl1.SelectedTab == bvtiPrint) backstageViewControl1.SelectedTab = bvtiInfo;
            bvtiPrint.Enabled = CurrentRichEdit != null || CurrentPrintableComponent != null;
            bvtiExport.Enabled = CurrentExportComponent != null;
        }
        public IPrintable CurrentPrintableComponent { get { return modulesNavigator.CurrentModule.PrintableComponent; } }
        public IPrintable CurrentExportComponent { get { return modulesNavigator.CurrentModule.ExportComponent; } }
        public RichEditControl CurrentRichEdit { get { return modulesNavigator.CurrentModule.CurrentRichEdit; } }
        public string CurrentModuleName { get { return modulesNavigator.CurrentModule.ModuleName; } }
        void ribbonControl1_ShowCustomizationMenu(object sender, RibbonCustomizationMenuEventArgs e) {
            e.CustomizationMenu.InitializeMenu();
            if(e.Link == null || !AllowCustomizationMenuList.Contains(e.Link.Item))
                e.CustomizationMenu.RemoveLink(e.CustomizationMenu.ItemLinks[0]);
        }
        void ucMailTree1_UCTreeDragDrop(object sender, UCTreeDragDropEventArgs e) {
            if(modulesNavigator.CurrentModule is Mail) {
                ((Mail)modulesNavigator.CurrentModule).OnMoveEmails(ucMailTree1, e);
            }
        }
        void biRename_ItemClick(object sender, ItemClickEventArgs e) {
            ucMailTree1.StartEditing();
        }
        void biCreateFolder_ItemClick(object sender, ItemClickEventArgs e) {
            ucMailTree1.CreateNewFolder();
        }
        void bbiReminder_ItemClick(object sender, ItemClickEventArgs e) {
            using(frmReminders frm = new frmReminders()) {
                frm.InitData(bbiReminder.Tag as List<Task>);
                if(frm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK) {
                    modulesNavigator.CurrentModule.FocusObject(frm.CurrentTask);
                    modulesNavigator.CurrentModule.ButtonClick(TagResources.TaskEdit);
                }
            }
        }
    }
}
