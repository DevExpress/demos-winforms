using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Data.Utils.Registry;
using DevExpress.DemoData.Helpers;
using DevExpress.Utils;
using DevExpress.Utils.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.WinExplorer;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraNavBar;

namespace DevExpress.XtraGrid.Demos {
    public partial class ExplorerView : TutorialControl, IFileSystemNavigationSupports {
        string _currentPath;
        public ExplorerView() {
            InitializeComponent();
            AutoMergeRibbon = true;
        }
        static ExplorerView() {
            FileSystemImageCache.Cache.EnableFileIconCaching = false;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            Initialize();
        }
        void Initialize() {
            InitializeDefaultFolderIcons();
            InitializeBreadCrumb();
            InitializeNavBar();
            InitializeAppearance();
            CalcPanels();
            UpdateView();
        }
        void InitializeDefaultFolderIcons() {
            groupFavorites.ImageOptions.SmallImage = FileSystemHelper.GetImage(DevExpress.Data.Utils.SafeEnvironment.Favorites, IconSizeType.Small, FolderIconSize);
            navPanelItemDesktop.ImageOptions.SmallImage = FileSystemHelper.GetImage(DevExpress.Data.Utils.SafeEnvironment.Desktop, IconSizeType.Small, FolderIconSize);
            navPanelItemDownloads.ImageOptions.SmallImage = FileSystemHelper.GetImage(DXSystemSettings.GetDownloadsDirectory(), IconSizeType.Small, FolderIconSize);
            navPanelItemRecent.ImageOptions.SmallImage = FileSystemHelper.GetImage(DevExpress.Data.Utils.SafeEnvironment.Recent, IconSizeType.Small, FolderIconSize);

            groupLibraries.ImageOptions.SmallImage = FileSystemHelper.GetImage(DevExpress.Data.Utils.SafeEnvironment.MyComputer, IconSizeType.Small, FolderIconSize);
            navPanelItemDocuments.ImageOptions.SmallImage = FileSystemHelper.GetImage(DevExpress.Data.Utils.SafeEnvironment.MyDocuments, IconSizeType.Small, FolderIconSize);
            navPanelItemPictures.ImageOptions.SmallImage = FileSystemHelper.GetImage(DevExpress.Data.Utils.SafeEnvironment.MyPictures, IconSizeType.Small, FolderIconSize);
            navPanelItemVideos.ImageOptions.SmallImage = FileSystemHelper.GetImage(DevExpress.Data.Utils.SafeEnvironment.MyVideos, IconSizeType.Small, FolderIconSize);
            navPanelItemMusic.ImageOptions.SmallImage = FileSystemHelper.GetImage(DevExpress.Data.Utils.SafeEnvironment.MyMusic, IconSizeType.Small, FolderIconSize);
        }
        Size FolderIconSize {
            get { return new Size(ScaleUtils.ScaleValue(16), ScaleUtils.ScaleValue(16)); }
        }
        void InitializeBreadCrumb() {
            this._currentPath = StartupPath;
            BreadCrumb.Path = this._currentPath;
            foreach(DriveInfo driveInfo in FileSystemHelper.GetFixedDrives()) {
                BreadCrumb.Properties.History.Add(new BreadCrumbHistoryItem(driveInfo.RootDirectory.ToString()));
            }
        }
        void InitializeAppearance() {
            GalleryItem item = rgbiViewStyle.Gallery.GetCheckedItem();
            if(item != null)
                this.winExplorerView.OptionsView.Style = (WinExplorerViewStyle)item.Tag;
        }
        void OnBreadCrumbPathChanged(object sender, BreadCrumbPathChangedEventArgs e) {
            this._currentPath = e.Path;
            UpdateView();
            UpdateButtons();
        }
        void OnBreadCrumbNewNodeAdding(object sender, BreadCrumbNewNodeAddingEventArgs e) {
            e.Node.PopulateOnDemand = true;
        }
        void OnBreadCrumbQueryChildNodes(object sender, BreadCrumbQueryChildNodesEventArgs e) {
            if(e.Node.Caption == "Root") {
                InitBreadCrumbRootNode(e.Node);
                return;
            }
            if(e.Node.Caption == "Computer") {
                InitBreadCrumbComputerNode(e.Node);
                return;
            }
            string dir = e.Node.Path;
            if(!FileSystemHelper.IsDirExists(dir))
                return;
            string[] subDirs = FileSystemHelper.GetSubFolders(dir);
            for(int i = 0; i < subDirs.Length; i++) {
                e.Node.ChildNodes.Add(CreateNode(subDirs[i]));
            }
        }
        void InitBreadCrumbRootNode(BreadCrumbNode node) {
            node.ChildNodes.Add(new BreadCrumbNode("Desktop", DevExpress.Data.Utils.SafeEnvironment.Desktop));
            node.ChildNodes.Add(new BreadCrumbNode("Documents", DevExpress.Data.Utils.SafeEnvironment.Recent));
            node.ChildNodes.Add(new BreadCrumbNode("Music", DevExpress.Data.Utils.SafeEnvironment.MyMusic));
            node.ChildNodes.Add(new BreadCrumbNode("Pictures", DevExpress.Data.Utils.SafeEnvironment.MyPictures));
            node.ChildNodes.Add(new BreadCrumbNode("Video", DevExpress.Data.Utils.SafeEnvironment.MyVideos));
            node.ChildNodes.Add(new BreadCrumbNode("Program Files", DevExpress.Data.Utils.SafeEnvironment.ProgramFiles));
            node.ChildNodes.Add(new BreadCrumbNode("Windows", DevExpress.Data.Utils.SafeEnvironment.Windows));
        }
        void InitBreadCrumbComputerNode(BreadCrumbNode node) {
            foreach(DriveInfo driveInfo in FileSystemHelper.GetFixedDrives()) {
                node.ChildNodes.Add(new BreadCrumbNode(driveInfo.Name, driveInfo.RootDirectory));
            }
        }
        void OnBreadCrumbValidatePath(object sender, BreadCrumbValidatePathEventArgs e) {
            if(!FileSystemHelper.IsDirExists(e.Path)) {
                e.ValidationResult = BreadCrumbValidatePathResult.Cancel;
                return;
            }
            e.ValidationResult = BreadCrumbValidatePathResult.CreateNodes;
        }
        void OnBreadCrumbRootGlyphClick(object sender, EventArgs e) {
            BreadCrumb.Properties.BreadCrumbMode = BreadCrumbMode.Edit;
            BreadCrumb.SelectAll();
        }
        BreadCrumbNode CreateNode(string path) {
            string folderName = FileSystemHelper.GetDirName(path);
            return new BreadCrumbNode(folderName, folderName, true);
        }
        protected string StartupPath { get { return DevExpress.Data.Utils.SafeEnvironment.Desktop; } }

        void UpdateView() {
            Cursor oldCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                if(!string.IsNullOrEmpty(this._currentPath))
                    gridControl.DataSource = FileSystemHelper.GetFileSystemEntries(this._currentPath, GetItemSizeType(ViewStyle), GetItemSize(ViewStyle));
                else
                    gridControl.DataSource = null;
                winExplorerView.RefreshData();
                EnsureSearchEdit();
                BeginInvoke(new MethodInvoker(winExplorerView.ClearSelection));
            }
            finally {
                Cursor.Current = oldCursor;
            }
        }
        void EnsureSearchEdit() {
            editSearch.Properties.NullValuePrompt = "Search " + FileSystemHelper.GetDirName(this._currentPath);
            editSearch.EditValue = null;
            this.winExplorerView.FindFilterText = string.Empty;
        }
        void OnNavPanelLinkClicked(object sender, NavBarLinkEventArgs e) {
            BreadCrumb.Path = (string)e.Link.Item.Tag;
        }
        void OnShowNavPaneItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            BarCheckItem item = (BarCheckItem)e.Item;
            this.liNavPaneRight.Visibility = item.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            this.navBar.Visible = item.Checked;
        }
        void OnShowFavoritesItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.groupFavorites.Visible = ((BarCheckItem)e.Item).Checked;
        }
        void OnShowLibrariesItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            groupLibraries.Visible = ((BarCheckItem)e.Item).Checked;
        }
        void OnShowCheckBoxesItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            this.winExplorerView.OptionsView.ShowCheckBoxes = ((BarCheckItem)e.Item).Checked;
        }
        void InitializeNavBar() {
            navPanelItemDesktop.Tag = DevExpress.Data.Utils.SafeEnvironment.Desktop;
            navPanelItemRecent.Tag = DevExpress.Data.Utils.SafeEnvironment.Recent;
            navPanelItemDocuments.Tag = DevExpress.Data.Utils.SafeEnvironment.MyDocuments;
            navPanelItemMusic.Tag = DevExpress.Data.Utils.SafeEnvironment.MyMusic;
            navPanelItemPictures.Tag = DevExpress.Data.Utils.SafeEnvironment.MyPictures;
            navPanelItemVideos.Tag = DevExpress.Data.Utils.SafeEnvironment.MyVideos;
            navPanelItemDownloads.Tag = DXSystemSettings.GetDownloadsDirectory();
            if(navPanelItemDownloads.Tag == null) navPanelItemDownloads.Visible = false;
        }
        void OnViewStyleGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            GalleryItem item = e.Item;
            if(!item.Checked) return;
            WinExplorerViewStyle _viewStyle = (WinExplorerViewStyle)Enum.Parse(typeof(WinExplorerViewStyle), item.Tag.ToString());
            this.winExplorerView.OptionsView.Style = _viewStyle;
            FileSystemImageCache.Cache.ClearCache();
            UpdateView();
        }
        void OnRgbiViewStyleInitDropDown(object sender, InplaceGalleryEventArgs e) {
            e.PopupGallery.SynchWithInRibbonGallery = true;
        }
        void OnEditSearchTextChanged(object sender, EventArgs e) {
            this.winExplorerView.FindFilterText = editSearch.Text;
        }
        void OnSelectAllItemClick(object sender, ItemClickEventArgs e) {
            this.winExplorerView.SelectAll();
        }
        void OnSelectNoneItemClick(object sender, ItemClickEventArgs e) {
            this.winExplorerView.ClearSelection();
        }
        void OnInvertSelectionItemClick(object sender, ItemClickEventArgs e) {
            for(int i = 0; i < this.winExplorerView.RowCount; i++) this.winExplorerView.InvertRowSelection(i);
        }
        void OnShowFileNameExtensionsCheckItemClick(object sender, ItemClickEventArgs e) {
            FileSystemEntryCollection col = gridControl.DataSource as FileSystemEntryCollection;
            if(col == null) return;
            col.ShowExtensions = ((BarCheckItem)e.Item).Checked;
            gridControl.RefreshDataSource();
        }
        void OnShowHiddenItemsCheckItemClick(object sender, ItemClickEventArgs e) {
            btnHideSelectedItems.Enabled = !((BarCheckItem)e.Item).Checked;
        }
        void OnHelpButtonItemClick(object sender, ItemClickEventArgs e) {
            StartApplicationHelper.ShowHelp();
        }
        void OnWinExplorerViewSelectionChanged(object sender, SelectionChangedEventArgs e) {
            UpdateButtons();
        }
        void OnCopyPathItemClick(object sender, ItemClickEventArgs e) {
            StringBuilder builder = new StringBuilder();
            foreach(FileSystemEntry entry in GetSelectedEntries()) {
                builder.AppendLine(entry.Path);
            }
            if(!string.IsNullOrEmpty(builder.ToString()))
                DevExpress.Data.Utils.SafeClipboardWin.Instance.SetText(builder.ToString());
        }
        void OnOpenItemClick(object sender, ItemClickEventArgs e) {
            foreach(FileSystemEntry entry in GetSelectedEntries(true)) {
                entry.DoAction(this);
            }
        }
        void OnWinExplorerViewKeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if(e.KeyCode != Keys.Enter) return;
            FileSystemEntry entry = GetSelectedEntries().LastOrDefault();
            if(entry != null) entry.DoAction(this);
        }
        void OnWinExplorerViewItemClick(object sender, WinExplorerViewItemClickEventArgs e) {
            if(e.MouseInfo.Button == MouseButtons.Right) itemPopupMenu.ShowPopup(Cursor.Position);
        }
        void OnWinExplorerViewItemDoubleClick(object sender, WinExplorerViewItemDoubleClickEventArgs e) {
            if(e.MouseInfo.Button != MouseButtons.Left) return;
            winExplorerView.ClearSelection();
            ((FileSystemEntry)e.ItemInfo.Row.RowKey).DoAction(this);
        }
        void UpdateButtons() {
            int selEntriesCount = GetSelectedEntries().Count();
            this.btnOpen.Enabled = this.btnCopyItem.Enabled = selEntriesCount > 0;
            this.btnUpTo.Enabled = BreadCrumb.CanGoUp;
            this.btnBack.Enabled = BreadCrumb.CanGoBack;
            this.btnForward.Enabled = BreadCrumb.CanGoForward;
        }
        void OnBackButtonClick(object sender, EventArgs e) {
            BreadCrumb.GoBack();
        }
        void OnNextButtonClick(object sender, EventArgs e) {
            BreadCrumb.GoForward();
        }
        void OnUpButtonClick(object sender, EventArgs e) {
            BreadCrumb.GoUp();
        }
        void OnNavigationMenuButtonClick(object sender, EventArgs e) {
            navigationMenu.ItemLinks.Clear();
            navigationMenu.ItemLinks.AddRange(GetNavigationHistroryItems().ToArray());
            navigationMenu.ShowPopup(PointToScreen(new Point(0, navigationPanel.Bottom)));
        }
        IEnumerable<BarItem> GetNavigationHistroryItems() {
            BreadCrumbHistory history = BreadCrumb.GetNavigationHistory();
            for(int i = history.Count - 1; i >= 0; i--) {
                BreadCrumbHistoryItem item = history[i];
                BarCheckItem menuItem = new BarCheckItem();
                menuItem.Tag = i;
                menuItem.Caption = FileSystemHelper.GetDirName(item.Path);
                menuItem.ItemClick += OnNavigationMenuItemClick;
                menuItem.Checked = BreadCrumb.GetNavigationHistoryCurrentItemIndex() == i;
                yield return menuItem;
            }
        }
        void OnNavigationMenuItemClick(object sender, ItemClickEventArgs e) {
            BreadCrumb.SetNavigationHistoryCurrentItemIndex(Convert.ToInt32(e.Item.Tag));
            UpdateButtons();
        }
        List<FileSystemEntry> GetSelectedEntries() { return GetSelectedEntries(false); }
        List<FileSystemEntry> GetSelectedEntries(bool sort) {
            List<FileSystemEntry> list = new List<FileSystemEntry>();
            int[] rows = winExplorerView.GetSelectedRows();
            for(int i = 0; i < rows.Length; i++) {
                list.Add((FileSystemEntry)winExplorerView.GetRow(rows[i]));
            }
            if(sort) list.Sort(new FileSytemEntryComparer());
            return list;
        }
        Size GetItemSize(WinExplorerViewStyle viewStyle) {
            switch(viewStyle) {
                case WinExplorerViewStyle.ExtraLarge: return new Size(256, 256);
                case WinExplorerViewStyle.Large: return new Size(96, 96);
                case WinExplorerViewStyle.Content: return new Size(32, 32);
                case WinExplorerViewStyle.Small: return new Size(16, 16);
                case WinExplorerViewStyle.Tiles:
                case WinExplorerViewStyle.Default:
                case WinExplorerViewStyle.List:
                case WinExplorerViewStyle.Medium:
                default: return new Size(96, 96);
            }
        }
        IconSizeType GetItemSizeType(WinExplorerViewStyle viewStyle) {
            switch(viewStyle) {
                case WinExplorerViewStyle.Large:
                case WinExplorerViewStyle.ExtraLarge: return IconSizeType.ExtraLarge;
                case WinExplorerViewStyle.List:
                case WinExplorerViewStyle.Small: return IconSizeType.Small;
                case WinExplorerViewStyle.Tiles:
                case WinExplorerViewStyle.Medium:
                case WinExplorerViewStyle.Content: return IconSizeType.Large;
                default: return IconSizeType.ExtraLarge;
            }
        }
        void CalcPanels() {
            this.navigationPanel.Location = Point.Empty;
            this.contentPanel.Location = new Point(0, this.navigationPanel.Bottom - 1);
            this.contentPanel.Height = Height - this.navigationPanel.Height + 1;
        }
        public BreadCrumbEdit BreadCrumb { get { return editBreadCrumb; } }
        public WinExplorerViewStyle ViewStyle { get { return this.winExplorerView.OptionsView.Style; } }

        #region IFileSystemNavigationSupports
        string IFileSystemNavigationSupports.CurrentPath {
            get { return _currentPath; }
        }
        void IFileSystemNavigationSupports.UpdatePath(string path) {
            BreadCrumb.Path = path;
        }
        #endregion
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}
