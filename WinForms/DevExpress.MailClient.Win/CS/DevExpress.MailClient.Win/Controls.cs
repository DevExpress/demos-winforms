using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Design;
using DevExpress.Utils.Menu;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraNavBar;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit;
using DevExpress.XtraSplashScreen;

namespace DevExpress.MailClient.Win {
    public class ModulesNavigator {
        RibbonControl ribbon;
        PanelControl panel;
        public ModulesNavigator(RibbonControl ribbon, PanelControl panel) {
            this.ribbon = ribbon;
            this.panel = panel;
        }
        public void ChangeGroup(NavBarGroup group, object moduleData) {
            bool allowSetVisiblePage = true;
            NavBarGroupTagObject groupObject = group.Tag as NavBarGroupTagObject;
            if(groupObject == null) return;
            List<RibbonPage> deferredPagesToShow = new List<RibbonPage>();
            foreach(RibbonPage page in ribbon.Pages) {
                if(!string.IsNullOrEmpty(string.Format("{0}", page.Tag))) {
                    bool isPageVisible = groupObject.Name.Equals(page.Tag);
                    if(isPageVisible != page.Visible && isPageVisible)
                        deferredPagesToShow.Add(page);
                    else
                        page.Visible = isPageVisible;
                }
                if(page.Visible && allowSetVisiblePage) {
                    //page.Text = "Home";
                    ribbon.SelectedPage = page;
                    allowSetVisiblePage = false;
                }
            }
            bool firstShow = groupObject.Module == null;
            if(firstShow) {
                if(SplashScreenManager.Default == null)
                    SplashScreenManager.ShowForm(ribbon.FindForm(), typeof(DevExpress.MailClient.Win.Forms.wfMain), false, true);
                ConstructorInfo constructorInfoObj = groupObject.ModuleType.GetConstructor(Type.EmptyTypes);
                if(constructorInfoObj != null) {
                    groupObject.Module = constructorInfoObj.Invoke(null) as BaseModule;
                    groupObject.Module.InitModule(ribbon, moduleData);
                }
                if(SplashScreenManager.Default != null) {
                    Form frm = moduleData as Form;
                    if(frm != null) {
                        if(SplashScreenManager.FormInPendingState)
                            SplashScreenManager.CloseForm();
                        else
                            SplashScreenManager.CloseForm(false, 500, frm);
                    }
                    else
                        SplashScreenManager.CloseForm();
                }
            }

            foreach(RibbonPage page in deferredPagesToShow) {
                page.Visible = true;
            }
            foreach(RibbonPage page in ribbon.Pages) {
                if(page.Visible) {
                    ribbon.SelectedPage = page;
                    break;
                }
            }

            if(groupObject.Module != null) {
                if(panel.Controls.Count > 0) {
                    BaseModule currentModule = panel.Controls[0] as BaseModule;
                    if(currentModule != null)
                        currentModule.HideModule();
                }
                panel.Controls.Clear();
                panel.Controls.Add(groupObject.Module);
                groupObject.Module.Dock = DockStyle.Fill;
                groupObject.Module.ShowModule(firstShow);
            }
        }
        public BaseModule CurrentModule {
            get {
                if(panel.Controls.Count == 0) return null;
                return panel.Controls[0] as BaseModule;
            }
        }
    }
    public class FindControlManager : IDisposable {
        RibbonControl ribbon;
        FindControl fControl;
        public FindControlManager(RibbonControl ribbon, FindControl control) {
            this.ribbon = ribbon;
            this.fControl = control;
            AddFindControlEvents();
        }
        void AddFindControlEvents() {
            fControl.FindButton.GotFocus += new EventHandler(FindControl_GotFocus);
            fControl.FindEdit.GotFocus += new EventHandler(FindControl_GotFocus);
            fControl.ClearButton.GotFocus += new EventHandler(FindControl_GotFocus);
            fControl.FindButton.Leave += new EventHandler(FindControl_Leave);
            fControl.FindEdit.Leave += new EventHandler(FindControl_Leave);
            fControl.ClearButton.Leave += new EventHandler(FindControl_Leave);
            fControl.FindButton.ImageOptions.SvgImage = Properties.Resources.Search1;
            fControl.FindButton.ImageOptions.SvgImageSize = new Size(16, 16);
            fControl.ClearButton.ImageOptions.SvgImage = Properties.Resources.Delete;
            fControl.ClearButton.ImageOptions.SvgImageSize = new Size(16, 16);
            fControl.FindButton.TabStop = false;
            fControl.ClearButton.TabStop = false;
            fControl.CalcButtonsBestFit();
        }
        void FindControl_Leave(object sender, EventArgs e) {
            fControl.BeginInvoke(new System.Windows.Forms.MethodInvoker(UpdateSearchTools));
        }
        void FindControl_GotFocus(object sender, EventArgs e) {
            UpdateSearchTools();
        }
        void UpdateSearchTools() {
            if(fControl.FindButton.Focused ||
                fControl.FindEdit.ContainsFocus ||
                fControl.ClearButton.Focused) {
                ribbon.PageCategories[TagResources.SearchTools].Visible = true;
                ribbon.SelectedPage = ribbon.PageCategories[TagResources.SearchTools].Pages[0];
            }
            else {
                ribbon.PageCategories[TagResources.SearchTools].Visible = false;
                ribbon.SelectedPage = ribbon.DefaultPageCategory.Pages[0];
            }
        }

        #region IDisposable Members
        public void Dispose() {
            fControl.FindButton.GotFocus -= new EventHandler(FindControl_GotFocus);
            fControl.FindEdit.GotFocus -= new EventHandler(FindControl_GotFocus);
            fControl.ClearButton.GotFocus -= new EventHandler(FindControl_GotFocus);
            fControl.FindButton.Leave -= new EventHandler(FindControl_Leave);
            fControl.FindEdit.Leave -= new EventHandler(FindControl_Leave);
            fControl.ClearButton.Leave -= new EventHandler(FindControl_Leave);
        }
        #endregion
    }
    public class FilterColumnsManager {
        List<BarButtonItem> items;
        GridView view;
        bool lockUpdate = false;
        public FilterColumnsManager(List<BarButtonItem> items) {
            this.items = items;
            foreach(BarButtonItem item in items)
                item.DownChanged += new ItemClickEventHandler(item_DownChanged);
        }
        BarButtonItem GetItemByName(string name) {
            foreach(BarButtonItem item in items)
                if(item.Tag.Equals(name)) return item;
            return null;
        }
        public void SetDefault() {
            lockUpdate = true;
            foreach(BarButtonItem item in items)
                if(item.CanDown)
                    item.Down = false;
            GetItemByName(TagResources.SubjectColumn).Down = true;
            GetItemByName(TagResources.PersonColumn).Down = true;
            lockUpdate = false;
            Update();
        }
        void Update() {
            string filterColumns = string.Empty;
            if(GetItemByName(TagResources.SubjectColumn).Down) filterColumns += "Subject;";
            if(GetItemByName(TagResources.PersonColumn).Down) filterColumns += "From;";
            if(GetItemByName(TagResources.DateColumn).Down) filterColumns += "Date;";
            if(GetItemByName(TagResources.PriorityColumn).Down) filterColumns += "Priority;";
            if(GetItemByName(TagResources.AttachmentColumn).Down) filterColumns += "Attachment;";
            view.OptionsFind.FindFilterColumns = filterColumns;
        }
        void item_DownChanged(object sender, ItemClickEventArgs e) {
            if(lockUpdate) return;
            Update();
        }
        public void InitGridView(DevExpress.XtraGrid.Views.Grid.GridView gridView) {
            if(view != null) return;
            view = gridView;
            SetDefault();
        }
        internal void UpdateColumnsCaption(string date, string person) {
            GetItemByName(TagResources.PersonColumn).Caption = person;
            GetItemByName(TagResources.DateColumn).Caption = date;
            GetItemByName(TagResources.DateFilterMenu).Caption = date;
        }
    }
    public class PriorityMenu : PopupMenu {
        GridView view;
        BarButtonItem lowPriority, mediumPriority, highPriority;
        public PriorityMenu(BarManager manager, GridView view, SvgImage low, SvgImage high)
            : base(manager) {
            this.view = view;
            lowPriority = new BarButtonItem(manager, Properties.Resources.LowPriority);
            lowPriority.ImageOptions.SvgImage = low;
            lowPriority.ImageOptions.SvgImageSize = new Size(16, 16);
            mediumPriority = new BarButtonItem(manager, Properties.Resources.MediumPriority);
            highPriority = new BarButtonItem(manager, Properties.Resources.HighPriority);
            highPriority.ImageOptions.SvgImage = high;
            highPriority.ImageOptions.SvgImageSize = new Size(16, 16);
            ItemLinks.AddRange(new BarItem[] { lowPriority, mediumPriority, highPriority });
            lowPriority.ItemClick += new ItemClickEventHandler(lowPriority_ItemClick);
            mediumPriority.ItemClick += new ItemClickEventHandler(mediumPriority_ItemClick);
            highPriority.ItemClick += new ItemClickEventHandler(highPriority_ItemClick);
            lowPriority.ButtonStyle = BarButtonStyle.Check;
            mediumPriority.ButtonStyle = BarButtonStyle.Check;
            highPriority.ButtonStyle = BarButtonStyle.Check;
        }
        protected override void OnBeforePopup(CancelEventArgs e) {
            base.OnBeforePopup(e);
            int priority = -1;
            foreach(int row in view.GetSelectedRows()) {
                if(row >= 0) {
                    Message message = view.GetRow(row) as Message;
                    if(priority == -1)
                        priority = message.Priority;
                    if(priority != message.Priority) {
                        priority = -1;
                        break;
                    }
                }
            }
            lowPriority.Down = priority == 0;
            mediumPriority.Down = priority == 1;
            highPriority.Down = priority == 2;
        }
        void SetPriority(int value) {
            foreach(int row in view.GetSelectedRows())
                if(row >= 0)
                    ((Message)view.GetRow(row)).Priority = value;
            view.LayoutChanged();
            view.MakeRowVisible(view.FocusedRowHandle);
        }
        void highPriority_ItemClick(object sender, ItemClickEventArgs e) { SetPriority(2); }
        void mediumPriority_ItemClick(object sender, ItemClickEventArgs e) { SetPriority(1); }
        void lowPriority_ItemClick(object sender, ItemClickEventArgs e) { SetPriority(0); }
    }
    public class DateFilterMenu : PopupMenu {
        GridView view;
        FilterCriteriaManager filterManager;
        public DateFilterMenu(BarManager manager, GridView view, FilterCriteriaManager filterManager)
            : base(manager) {
            this.view = view;
            this.filterManager = filterManager;
            CreateBarItem(Properties.Resources.IsToday, "IsOutlookIntervalToday([Date])");
            CreateBarItem(Properties.Resources.IsYesterday, "IsOutlookIntervalYesterday([Date])");
            CreateBarItem(Properties.Resources.IsEarlierThisWeek, "IsOutlookIntervalEarlierThisWeek([Date])");
            CreateBarItem(Properties.Resources.IsLastWeek, "IsOutlookIntervalLastWeek([Date])");
            CreateBarItem(Properties.Resources.IsEarlierThisMonth, "IsOutlookIntervalEarlierThisMonth([Date])");
            CreateBarItem(Properties.Resources.IsEarlierThisYear, "IsOutlookIntervalEarlierThisYear([Date])");
        }
        void CreateBarItem(string caption, string filterString) {
            BarButtonItem item = new BarButtonItem(this.Manager, caption);
            item.Tag = filterString;
            item.CloseSubMenuOnClick = false;
            ItemLinks.Add(item);
            filterManager.AddBarItem(item, view.Columns["Date"], filterString);
        }
    }
    public class FilterCriteriaManager {
        GridView view;
        List<FilterCriteriaItem> itemList;
        BarButtonItem clearFilterItem;
        public FilterCriteriaManager(GridView view) {
            this.view = view;
            itemList = new List<FilterCriteriaItem>();
            view.ColumnFilterChanged += new EventHandler(view_ColumnFilterChanged);
        }
        public GridView View { get { return view; } }
        void view_ColumnFilterChanged(object sender, EventArgs e) {
            UpdateFilterInfo();
        }
        void UpdateFilterInfo() {
            foreach(FilterCriteriaItem item in itemList)
                item.UpdateDown();
            if(clearFilterItem != null)
                clearFilterItem.Enabled = !view.ActiveFilter.IsEmpty;
        }
        public void AddBarItem(BarButtonItem item, GridColumn column, string filterCriteria) {
            itemList.Add(new FilterCriteriaItem(this, item, column, filterCriteria));
        }
        public void AddClearFilterButton(BarButtonItem item) {
            clearFilterItem = item;
            UpdateFilterInfo();
        }
        internal string GetFilterCriteriaByColumn(GridColumn column) {
            string ret = string.Empty;
            foreach(FilterCriteriaItem item in itemList)
                if(item.Checked && item.IsColumnEquals(column))
                    ret = AddCriteria(ret, item.FilterCriteria);
            return ret;
        }

        string AddCriteria(string ret, string filterCriteria) {
            if(!string.IsNullOrEmpty(ret))
                ret = string.Format("{0} Or {1}", ret, filterCriteria);
            else ret = filterCriteria;
            return ret;
        }
    }
    public class FilterCriteriaItem {
        BarButtonItem item;
        string filterCriteria;
        GridColumn column;
        FilterCriteriaManager owner;
        public FilterCriteriaItem(FilterCriteriaManager owner, BarButtonItem item, GridColumn column, string filterCriteria) {
            this.item = item;
            this.column = column;
            this.filterCriteria = filterCriteria;
            this.owner = owner;
            item.ButtonStyle = BarButtonStyle.Check;
            item.ItemClick += new ItemClickEventHandler(item_ItemClick);
        }
        GridView View { get { return owner.View; } }
        public bool Checked { get { return item.Down; } }
        internal string FilterCriteria { get { return filterCriteria; } }
        internal bool IsColumnEquals(GridColumn column) {
            return this.column.Equals(column);
        }
        void item_ItemClick(object sender, ItemClickEventArgs e) {
            UpdateFilterCriteria(column);
        }
        void UpdateFilterCriteria(GridColumn column) {
            string filterCriteria = owner.GetFilterCriteriaByColumn(column);
            if(string.IsNullOrEmpty(filterCriteria)) View.ActiveFilter.Remove(column);
            else
                View.ActiveFilter.Add(column, new ColumnFilterInfo(filterCriteria));
        }
        internal void UpdateDown() {
            item.Down = View.ActiveFilterString.IndexOf(filterCriteria) >= 0;
        }
    }
    public class BaseControl : XtraUserControl {
        public BaseControl() {
            if(!DesignTimeTools.IsDesignMode)
                LookAndFeel.ActiveLookAndFeel.StyleChanged += new EventHandler(ActiveLookAndFeel_StyleChanged);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(!DesignTimeTools.IsDesignMode)
                LookAndFeelStyleChanged();
        }
        protected override void Dispose(bool disposing) {
            if(disposing && !DesignTimeTools.IsDesignMode)
                LookAndFeel.ActiveLookAndFeel.StyleChanged -= new EventHandler(ActiveLookAndFeel_StyleChanged);
            base.Dispose(disposing);
        }
        void ActiveLookAndFeel_StyleChanged(object sender, EventArgs e) {
            LookAndFeelStyleChanged();
        }
        protected virtual void LookAndFeelStyleChanged() { }
    }
    public class NavPanePanel : BaseControl {
        NavPaneState state = NavPaneState.Collapsed;
        [DefaultValue(NavPaneState.Collapsed)]
        public NavPaneState State {
            get { return state; }
            set {
                state = value;
                RefreshBackColor();
            }
        }
        protected override void LookAndFeelStyleChanged() {
            base.LookAndFeelStyleChanged();
            RefreshBackColor();
        }
        public void RefreshBackColor() {
            this.BackColor = new SkinElementInfo(CommonSkins.GetSkin(this.LookAndFeel)[CommonSkins.SkinTextBorder]).Element.Border.GetBottom();
            Padding = new Padding(BorderByState(state), 1, 1, IsOfficeStyle ? BorderByState(state) : 1);
        }
        static int BorderByState(NavPaneState state) {
            return state == NavPaneState.Collapsed ? 0 : 1;
        }
        bool IsOfficeStyle {
            get {
                return this.LookAndFeel.ActiveSkinName.IndexOf("Office") > -1;
            }
        }
    }
    public class BaseModule : BaseControl {
        protected string partName = string.Empty;
        internal frmMain OwnerForm { get { return this.FindForm() as frmMain; } }
        public BaseModule() { }
        internal virtual void ShowModule(bool firstShow) {
            frmMain owner = OwnerForm;
            if(owner == null) return;
            owner.SaveAsMenuItem.Enabled = SaveAsEnable;
            owner.SaveAttachmentMenuItem.Enabled = SaveAttachmentEnable;
            owner.SaveCalendar.Visible = SaveCalendarVisible;
            owner.EnableLayoutButtons(true);
            ShowReminder();
            ShowInfo();
            owner.ZoomManager.ZoomFactor = (int)(ZoomFactor * 100);
            SetZoomCaption();
            owner.EnableZoomControl(AllowZoomControl);
        }
        internal virtual void FocusObject(object obj) { }
        protected virtual void ShowReminder() {
            if(OwnerForm != null)
                OwnerForm.ShowReminder(null);
        }
        internal void ShowInfo() {
            if(OwnerForm == null) return;
            if(Grid == null) {
                OwnerForm.ShowInfo(null);
                return;
            }
            ICollection list = Grid.DataSource as ICollection;
            if(list == null)
                OwnerForm.ShowInfo(null);
            else OwnerForm.ShowInfo(list.Count);
        }
        internal virtual void HideModule() { }
        internal virtual void InitModule(IDXMenuManager manager, object data) {
            SetMenuManager(this.Controls, manager);
            if(Grid != null && Grid.MainView is ColumnView) {
                ((ColumnView)Grid.MainView).ColumnFilterChanged += new EventHandler(BaseModule_ColumnFilterChanged);
            }
        }
        internal void ShowInfo(ColumnView view) {
            if(OwnerForm == null) return;
            ShowReminder();
            OwnerForm.ShowInfo(view.DataRowCount);
        }
        void BaseModule_ColumnFilterChanged(object sender, EventArgs e) {
            ShowInfo(sender as ColumnView);
        }
        void SetMenuManager(ControlCollection controlCollection, IDXMenuManager manager) {
            foreach(Control ctrl in controlCollection) {
                GridControl grid = ctrl as GridControl;
                if(grid != null) {
                    grid.MenuManager = manager;
                    break;
                }
                BaseEdit edit = ctrl as BaseEdit;
                if(edit != null) {
                    edit.MenuManager = manager;
                    break;
                }
                SetMenuManager(ctrl.Controls, manager);
            }
        }
        protected virtual bool AllowZoomControl { get { return false; } }
        protected virtual void SetZoomCaption() { }
        [DefaultValue(1)]
        public virtual float ZoomFactor {
            get { return 1; }
            set { }
        }
        public virtual IPrintable PrintableComponent { get { return Grid; } }
        public virtual IPrintable ExportComponent { get { return Grid; } }
        protected virtual GridControl Grid { get { return null; } }
        protected virtual bool SaveAsEnable { get { return false; } }
        protected virtual bool SaveAttachmentEnable { get { return false; } }
        protected virtual bool SaveCalendarVisible { get { return false; } }
        protected internal virtual void ButtonClick(string tag) { }
        protected internal virtual void MessagesDataChanged(DataSourceChangedEventArgs args) { }
        protected internal virtual void SendKeyDown(KeyEventArgs e) { }
        protected internal virtual RichEditControl CurrentRichEdit { get { return null; } }
        public virtual string ModuleName { get { return this.GetType().Name; } }
        public string PartName { get { return partName; } }
    }
    public class NavBarGroupTagObject {
        string name;
        Type moduleType;
        BaseModule module;
        public NavBarGroupTagObject(string name, Type moduleType) {
            this.name = name;
            this.moduleType = moduleType;
            module = null;
        }
        public string Name { get { return name; } }
        public Type ModuleType { get { return moduleType; } }
        public BaseModule Module {
            get { return module; }
            set { module = value; }
        }
    }
    public class BackstageViewLabel : LabelControl {
        public BackstageViewLabel() {
            Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            LineVisible = true;
            ShowLineShadow = false;
        }
    }
    public class ZoomManager {
        ZoomTrackBarControl zoomControl;
        int zoomFactor = 0;
        List<int> zoomValues = new List<int>() { 100, 115, 130, 150, 200, 250, 300, 350, 400, 500 };
        RibbonControl ribbon;
        BarEditItem beiZoom;
        ModulesNavigator modulesNavigator;
        public ZoomManager(RibbonControl ribbon, ModulesNavigator modulesNavigator, BarEditItem beItem) {
            this.ribbon = ribbon;
            this.modulesNavigator = modulesNavigator;
            this.beiZoom = beItem;
            this.beiZoom.HiddenEditor += new DevExpress.XtraBars.ItemClickEventHandler(this.beiZoom_HiddenEditor);
            this.beiZoom.ShownEditor += new DevExpress.XtraBars.ItemClickEventHandler(this.beiZoom_ShownEditor);
        }
        ZoomTrackBarControl ZoomControl { get { return zoomControl; } }
        public int ZoomFactor {
            get { return zoomFactor; }
            set {
                zoomFactor = value;
                beiZoom.Caption = string.Format(" {0}%", ZoomFactor);
                int index = zoomValues.IndexOf(ZoomFactor);
                if(index == -1)
                    beiZoom.EditValue = ZoomFactor / 10;
                else beiZoom.EditValue = 10 + index;
                modulesNavigator.CurrentModule.ZoomFactor = (float)ZoomFactor / 100;
            }
        }
        public void SetZoomCaption(string caption) {
            beiZoom.Caption = caption;
        }
        private void beiZoom_ShownEditor(object sender, ItemClickEventArgs e) {
            this.zoomControl = ribbon.Manager.ActiveEditor as ZoomTrackBarControl;
            if(ZoomControl != null) {
                ZoomControl.ValueChanged += new EventHandler(OnZoomTackValueChanged);
                OnZoomTackValueChanged(ZoomControl, EventArgs.Empty);
            }
        }
        private void beiZoom_HiddenEditor(object sender, ItemClickEventArgs e) {
            ZoomControl.ValueChanged -= new EventHandler(OnZoomTackValueChanged);
            this.zoomControl = null;
        }
        private void OnZoomTackValueChanged(object sender, EventArgs e) {
            int val = val = ZoomControl.Value * 10;
            if(ZoomControl.Value > 10) val = zoomValues[ZoomControl.Value - 10];
            ZoomFactor = val;
        }
    }
    public class ObjectToolTipController : IDisposable {
        ToolTipController controller;
        Control parent;
        object editObject;
        public object EditObject { get { return editObject; } }
        public ObjectToolTipController(Control parent) {
            this.parent = parent;
            this.parent.Disposed += new EventHandler(delegate { Dispose(); });
            this.controller = new ToolTipController();
            this.controller.ToolTipType = ToolTipType.SuperTip;
            this.controller.AllowHtmlText = true;
            this.controller.ReshowDelay = controller.InitialDelay;
            this.controller.AutoPopDelay = 10000;
            parent.MouseDown += new MouseEventHandler(delegate { HideHint(false); });
            parent.MouseLeave += new EventHandler(delegate { HideHint(true); });
        }
        public void ShowHint(object editObject, Point location) {
            if(object.Equals(editObject, this.editObject)) return;
            this.editObject = editObject;
            ToolTipControlInfo info = new ToolTipControlInfo();
            ToolTipItem item = new ToolTipItem();
            InitToolTipItem(item);
            item.ImageToTextDistance = 10;
            info.Object = DateTime.Now.Ticks;
            info.SuperTip = new SuperToolTip();
            info.SuperTip.Items.Add(item);
            info.ToolTipPosition = parent.PointToScreen(location);
            controller.ShowHint(info);
        }
        protected virtual void InitToolTipItem(ToolTipItem item) {
        }
        public void HideHint(bool clearCurrentObject) {
            if(clearCurrentObject) editObject = null;
            this.controller.HideHint();
        }
        #region IDisposable Members
        public void Dispose() {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing) {
            if(disposing) {
                this.controller.Dispose();
            }
        }
        ~ObjectToolTipController() {
            Dispose(false);
        }
        #endregion
    }
    public class ContactToolTipController : ObjectToolTipController {
        const int MaxPhotoWidth = 120, MaxPhotoHeight = 120;
        public ContactToolTipController(Control parent) : base(parent) { }
        Contact CurrentContact { get { return EditObject as Contact; } }
        protected override void InitToolTipItem(ToolTipItem item) {
            if(CurrentContact == null) return;
            if(CurrentContact.Photo != null)
                item.Image = ImageCreator.CreateImage(CurrentContact.Photo, MaxPhotoWidth, MaxPhotoHeight);
            item.Text = CurrentContact.GetContactInfoHtml();
        }
    }
    public class ImageCreator {
        public static Image CreateImage(Image srcImage, int maxWidth, int maxHeight) {
            if(srcImage == null) return null;
            Size size = GetPhotoSize(srcImage, maxWidth, maxHeight);
            Image ret = new Bitmap(size.Width, size.Height);
            using(Graphics gr = Graphics.FromImage(ret)) {
                gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                gr.DrawImage(srcImage, new Rectangle(0, 0, size.Width, size.Height));
            }
            return ret;
        }
        static Size GetPhotoSize(Image image, int maxWidth, int maxHeight) {
            int width = Math.Min(maxWidth, image.Width),
                height = width * image.Height / image.Width;
            if(height > maxHeight) {
                height = maxHeight;
                width = height * image.Width / image.Height;
            }
            return new Size(width, height);
        }
        public static Rectangle GetZoomDestRectangle(Rectangle r, Image img) {
            float horzRatio = Math.Min((float)r.Width / img.Width, 1);
            float vertRatio = Math.Min((float)r.Height / img.Height, 1);
            float zoomRatio = Math.Min(horzRatio, vertRatio);

            return new Rectangle(
                r.Left + (int)(r.Width - img.Width * zoomRatio) / 2,
                r.Top + (int)(r.Height - img.Height * zoomRatio) / 2,
                (int)(img.Width * zoomRatio),
                (int)(img.Height * zoomRatio));
        }
    }
}
