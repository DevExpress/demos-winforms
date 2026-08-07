using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.MVVM;
using DevExpress.WindowsMailClient.Win.Data;
using DevExpress.WindowsMailClient.Win.Model;
using DevExpress.WindowsMailClient.Win.Utils;
using DevExpress.WindowsMailClient.Win.ViewModels;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.ToastNotifications;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraGrid.Views.Tile.ViewInfo;
using DevExpress.XtraLayout;
using Message = DevExpress.WindowsMailClient.Win.Data.Message;

namespace DevExpress.WindowsMailClient.Win.Modules {
    public enum FilterType {
        Focused,
        Other
    }
    public partial class MailViewer : BaseModule {
        Color UnreadTextColor;
        public MailViewer() : base(typeof(MailViewerViewModel)) {
            InitializeComponent();
            layoutControl1.UseLocalBindingContext = true;
            gridControl1.DataSource = MailClientDataModel.Messages;
            this.colDate.SortOrder = ColumnSortOrder.Descending;
            this.biSortDate.Tag = "Date";
            this.biSortFrom.Tag = "From";
            this.biSortRead.Tag = "Read";
            this.biSortSubject.Tag = "SubjectDisplayText";
            this.biSortImportance.Tag = "Priority";

            ViewModel.MessageDeleted += ViewModel_MessageDeleted;
            ViewModel.MessageFlagged += ViewModel_MessageFlagged;
            ViewModel.MessageChanged += ViewModel_MessageChanged;
            ViewModel.FilterChanged += ViewModel_FilterChanged;
            ViewModel.SortInfoChanged += ViewModel_SortInfoChanged;

            tileView.MouseMove += TileView_MouseMove;

            tileView.OptionsFind.AllowFindPanel = true;
            this.gridControl1.SizeChanged += (s, e) => { CompactTemplate = gridControl1.Width <= 300; };
            InitNotifications();

            ViewModel.CurrentFilterType = FilterType.Other;
            ViewModel.CurrentMailType = MailType.Inbox;

            navigationItemFocused.Tag = FilterType.Focused;
            navigationItemOther.Tag = FilterType.Other;

            BindCommands();
            InitBindings();

            UpdateColors();
        }

        void TileView_MouseMove(object sender, MouseEventArgs e) {
            if(tileView.IsEditing) return;
            TileViewHitInfo hitInfo = tileView.CalcHitInfo(e.X, e.Y) as TileViewHitInfo;
            if(hitInfo != null) currentRowHandle = hitInfo.RowHandle;
        }

        void ViewModel_MessageFlagged(object sender, EventArgs e) {
            SetMailType(ViewModel.CurrentMailType);
        }

        bool updateSortValues;
        void ViewModel_FilterChanged(object sender, EventArgs e) {
            UpdateCurrentMessage();

            updateSortValues = true;

            bcFilterAll.Checked = true;
            bcFilterUnread.Checked = false;
            bcFilterImportance.Checked = false;
            bcFilterToday.Checked = false;
            bcFilterYesterday.Checked = false;

            updateSortValues = false;
        }
        void UpdateCurrentMessage() {
            tileView.FocusedRowHandle = 0;
            ViewModel.CurrentMessage = tileView.GetFocusedRow() as Message;
        }
        public MailViewerViewModel ViewModel {
            get { return GetViewModel<MailViewerViewModel>(); }
        }
        void ViewModel_MessageChanged(object sender, EventArgs e) {
            mailPresenter.ShowMessage(ViewModel.CurrentMessage);
        }

        void InitBindings() {
            mvvmContext.SetBinding(tileView, view => view.ActiveFilterCriteria, "ActiveFilter");
            mvvmContext.SetBinding(labelHeader, x => x.Text, "LabelText");
            mvvmContext.SetBinding(lciHeader, x => x.Visibility, "LayoutHeaderVisibility");
            mvvmContext.SetBinding(lciTabFilter, x => x.Visibility, "FocusedItemVisibility");

            MVVMContextFluentAPI<MailViewerViewModel> fluentAPI = mvvmContext.OfType<MailViewerViewModel>();
            fluentAPI.EventToCommand<FocusedRowChangedEventArgs>(tileView, "FocusedRowChanged", x => x.SetCurrentMessage(null), (Func<FocusedRowChangedEventArgs, object>)GetMessageForFocusedRow);
            fluentAPI.EventToCommand<ItemClickEventArgs>(biSortDate, "ItemClick", x => x.Sort(null), EventArgsToSortCommandParameter());
            fluentAPI.EventToCommand<ItemClickEventArgs>(biSortFrom, "ItemClick", x => x.Sort(null), EventArgsToSortCommandParameter());
            fluentAPI.EventToCommand<ItemClickEventArgs>(biSortRead, "ItemClick", x => x.Sort(null), EventArgsToSortCommandParameter());
            fluentAPI.EventToCommand<ItemClickEventArgs>(biSortSubject, "ItemClick", x => x.Sort(null), EventArgsToSortCommandParameter());
            fluentAPI.EventToCommand<ItemClickEventArgs>(biSortImportance, "ItemClick", x => x.Sort(null), EventArgsToSortCommandParameter());

            fluentAPI.EventToCommand<ItemClickEventArgs>(bcFilterAll, "CheckedChanged", x => x.SetFilterAll(), x => ((BarCheckItem)x.Item).Checked && !updateSortValues);
            fluentAPI.EventToCommand<ItemClickEventArgs>(bcFilterUnread, "CheckedChanged", x => x.SetFilterUnread(), x => ((BarCheckItem)x.Item).Checked && !updateSortValues);
            fluentAPI.EventToCommand<ItemClickEventArgs>(bcFilterImportance, "CheckedChanged", x => x.SetFilterImportance(), x => ((BarCheckItem)x.Item).Checked && !updateSortValues);
            fluentAPI.EventToCommand<ItemClickEventArgs>(bcFilterToday, "CheckedChanged", x => x.SetFilterToday(), x => ((BarCheckItem)x.Item).Checked && !updateSortValues);
            fluentAPI.EventToCommand<ItemClickEventArgs>(bcFilterYesterday, "CheckedChanged", x => x.SetFilterYesterday(), x => ((BarCheckItem)x.Item).Checked && !updateSortValues);
            fluentAPI.EventToCommand<NavigationBarItemEventArgs>(officeFilterTab, "SelectedItemChanged", x => x.SetFilterType(GetCurrentFilterType()), x => GetCurrentFilterType());
        }
        object GetMessageForFocusedRow(FocusedRowChangedEventArgs x) {
            if(x.FocusedRowHandle >= 0) return (Message)tileView.GetFocusedRow();
            return null;
        }
        Func<ItemClickEventArgs, object> EventArgsToSortCommandParameter() {
            return x => {
                this.popupMenu.BeginUpdate();
                if(x.Item.ImageIndex == -1) {
                    UpdateSortItemsImageIndexes();
                    x.Item.ImageIndex = 0;
                }
                else {
                    x.Item.ImageIndex = x.Item.ImageIndex == 1 ? 0 : 1;
                }
                popupMenu.EndUpdate();
                return new SortInfo() { Column = tileView.Columns[(string)x.Item.Tag], Order = x.Item.ImageIndex == 1 ? ColumnSortOrder.Ascending : ColumnSortOrder.Descending };
            };
        }
        void ViewModel_MessageDeleted(object sender, EventArgs e) {
            SetMailType(ViewModel.CurrentMailType);
        }

        void BindCommands() {
            mvvmContext.BindCommand<MailViewerViewModel>(contextButton2, x => x.DeleteMessage(GetCurrentMessage()), p => GetCurrentMessage());
            mvvmContext.BindCommand<MailViewerViewModel>(contextButton3, x => x.ReplyMessage(GetCurrentMessage()), p => GetCurrentMessage());
            mvvmContext.BindCommand<MailViewerViewModel>(checkContextButton1, x => x.SetMessageFlaged(GetCurrentMessage()), p => GetCurrentMessage());
        }
        int currentRowHandle;
        Message GetCurrentMessage() { return tileView.GetRow(currentRowHandle) as Message; }
        FilterType GetCurrentFilterType() {
            var item = officeFilterTab.SelectedItem;
            return item != null ? (FilterType)item.Tag : FilterType.Other;
        }
        #region Notifications
        Timer notificationsTimer;
        XtraBars.Alerter.AlertControl alertControl;
        void InitNotifications() {
            if(CanUseToastNotifications()) {
                notificationManager.ApplicationId = AppProvider.ApplicationID;
                notificationManager.TryCreateApplicationShortcut();
                notificationManager.Activated += notificationsManager_Activated;
            }
            else {
                alertControl = new XtraBars.Alerter.AlertControl(components);
                alertControl.AllowHtmlText = true;
                alertControl.FormLocation = XtraBars.Alerter.AlertFormLocation.TopRight;
                alertControl.ShowPinButton = false;
                alertControl.AlertClick += alertControl_AlertClick;
            }
            EnsureNotificationsTimer();
        }
        void EnsureNotificationsTimer() {
            if(notificationsTimer == null) {
                notificationsTimer = new Timer(components);
                notificationsTimer.Interval = 15000;
                notificationsTimer.Tick += notificationsTimer_Tick;
            }
            notificationsTimer.Start();
        }
        void DestroyNotificationsTimer() {
            if(notificationsTimer != null) {
                notificationsTimer.Stop();
                notificationsTimer.Tick -= notificationsTimer_Tick;
                notificationsTimer.Dispose();
            }
            notificationsTimer = null;
        }
        void notificationsTimer_Tick(object sender, EventArgs e) {
            if(notificationManager.IsDisposing) {
                DestroyNotificationsTimer();
                return;
            }
            if(Utils.Utils.ShowNotifications) {
                notificationsTimer.Interval = 15000;
                ShowNotification();
            }
            
        }
        void alertControl_AlertClick(object sender, XtraBars.Alerter.AlertClickEventArgs e) {
            object notificationId = e.Info.Tag;
            e.AlertForm.Close();
            OnNotificationClick(notificationId);
        }
        void notificationsManager_Activated(object sender, ToastNotificationEventArgs e) {
            OnNotificationClick(e.NotificationID);
        }
        bool CanUseToastNotifications() {
            return ToastNotificationsManager.AreToastNotificationsSupported;
        }
        void ShowNotification() {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
        }
        void OnNotificationClick(object notificationId) {
        }
        #endregion

        #region UI Customization and Drawing

        protected override void WndProc(ref System.Windows.Forms.Message m) {
            if(m.Msg == 528) { 
                this.GetParentViewModel<MainViewModel>().HideAllPanels();
            }
            base.WndProc(ref m);
        }
        void tileView1_CustomItemTemplate(object sender, TileViewCustomItemTemplateEventArgs e) {
            if(CompactTemplate)
                e.Template = e.Templates["smallsize"];
        }

        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateColors();
        }

        void UpdateColors() {
            SkinElement skinElement = NavPaneSkins.GetSkin(LookAndFeel.ActiveLookAndFeel)[NavPaneSkins.SkinOfficeNavigationBarItem];
            UnreadTextColor = skinElement != null ? skinElement.Properties.GetColor("PressedColor") : ColorProvider.QuestionColor;
            this.tileView.Appearance.GroupText.ForeColor = UnreadTextColor;
            this.tileView.Appearance.ItemFocused.BackColor = Color.FromArgb(40, UnreadTextColor);
            this.tileView.Appearance.ItemHovered.BackColor = Color.FromArgb(40, UnreadTextColor);

            this.labelControl1.Appearance.Font =
            this.labelControl1.AppearanceHovered.Font =
            this.labelControl1.AppearancePressed.Font =
            this.labelControl1.AppearanceDropDown.Font =
            this.labelControl1.AppearanceDropDownHovered.Font = FontProvider.GetFont(labelControl1.Font.FontFamily.Name, 12f);

            this.labelControl1.Appearance.ForeColor =
            this.labelControl1.AppearanceHovered.ForeColor =
            this.labelControl1.AppearancePressed.ForeColor =
            this.labelControl1.AppearanceDropDown.ForeColor =
            this.labelControl1.AppearanceDropDownHovered.ForeColor =
            this.labelControl1.AppearanceDropDownPressed.ForeColor = UnreadTextColor;
        }
        void tileView_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e) {
            bool isRead = (int)tileView.GetRowCellValue(e.RowHandle, colRead) == 1;
            if(!isRead) {
                e.Item["Read"].Appearance.Normal.BackColor = UnreadTextColor;
                e.Item["Date"].Appearance.Normal.ForeColor = UnreadTextColor;
                e.Item["SubjectDisplayText"].Appearance.Normal.ForeColor = UnreadTextColor;
                e.Item["SubjectDisplayText"].Appearance.Normal.FontStyleDelta = FontStyle.Bold;
            }
        }
        void tileView_ContextButtonCustomize(object sender, TileViewContextButtonCustomizeEventArgs e) {
            if(e.Item.Name == "cbFlag") {
                bool flagged = (int)tileView.GetRowCellValue(e.RowHandle, colFlag) % 2 != 0;
                e.Item.AllowGlyphSkinning = DefaultBoolean.False;
                e.Item.Visibility = flagged ? ContextItemVisibility.Visible : ContextItemVisibility.Auto;
            }
            else if(e.Item.Name == "cbExclamation") {
                bool priority = (int)tileView.GetRowCellValue(e.RowHandle, colPriority) == 2;
                e.Item.AllowGlyphSkinning = DefaultBoolean.False;
                e.Item.Visibility = priority ? ContextItemVisibility.Visible : ContextItemVisibility.Hidden;
            }
            else {
                e.Item.AllowGlyphSkinning = DefaultBoolean.True;
                e.Item.AppearanceHover.ForeColor = e.Item.AppearanceNormal.ForeColor = ((ITileControl)tileView.GetViewInfo()).ViewInfo.AppearanceText.ForeColor;
            }
        }
        #endregion

        bool _compactTemplate = false;
        bool CompactTemplate {
            get { return _compactTemplate; }
            set {
                if(_compactTemplate == value) return;
                _compactTemplate = value;
                tileView.RefreshData();
            }
        }
        void ViewModel_SortInfoChanged(object sender, EventArgs e) {
            tileView.SortInfo.Clear();
            tileView.SortInfo.Add(ViewModel.SortInfo);
        }
        void UpdateSortItemsImageIndexes() {
            this.biSortDate.ImageIndex = -1;
            this.biSortFrom.ImageIndex = -1;
            this.biSortRead.ImageIndex = -1;
            this.biSortSubject.ImageIndex = -1;
            this.biSortImportance.ImageIndex = -1;
        }
        public void SetMailType(MailType mailType) {
            ViewModel.CurrentMailType = mailType;
            this.gridControl1.RefreshDataSource();
        }
        protected override void OnDisposing() {
            ViewModel.MessageDeleted -= ViewModel_MessageDeleted;
            ViewModel.MessageFlagged -= ViewModel_MessageFlagged;
            ViewModel.MessageChanged -= ViewModel_MessageChanged;
            tileView.MouseMove -= TileView_MouseMove;
            base.OnDisposing();
        }

        void gridControl1_ControlAdded(object sender, ControlEventArgs e) {
            if(e.Control is FindControl) {
                if(e.Control.Controls.Count > 0) {
                    var layoutControls = e.Control.Controls.OfType<LayoutControl>();
                    foreach(var ctrl in layoutControls) {
                        var layoutControlGroup = ctrl.Items.FindByName("Root") as LayoutControlGroup;
                        if(layoutControlGroup != null) layoutControlGroup.Padding = new XtraLayout.Utils.Padding(18, 10, 5, 5);
                        var items = ctrl.Items.OfType<LayoutControlItem>();
                        foreach(LayoutControlItem item in items) {
                            item.Padding = new XtraLayout.Utils.Padding(item.Padding.Left, item.Padding.Right, 0, 0);
                        }
                    }
                }
            }
        }
    }
}
