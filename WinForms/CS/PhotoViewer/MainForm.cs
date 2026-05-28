using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.Data.Utils;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ColorWheel;
using DevExpress.XtraNavBar;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;

namespace PhotoViewer {
    public partial class MainForm : RibbonForm {
        public static Size HoverSkinImageSize = new Size(116, 86);
        public static Size SkinImageSize = new Size(58, 43);

        public MainForm() {
            InitializeComponent();
            InitSkins();
            InitFilters();
            SelectDefaultPage();
            LoadData();
            UpdateItemsEnabledState();
            UpdateAddToLibraryItem(biAddFolder);
            Icon = ResourceImageHelper.CreateIconFromResourcesEx("PhotoViewer.AppIcon.ico", typeof(MainForm).Assembly);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            SplashScreenManager.CloseForm();
        }
        PhotoViewerData viewDataCore;
        GalleryItem rightClickItemCore;
        NavBarGroup lastSelectedGroup;
        NavBarItemLink customizableLinkCore;
        List<GalleryItem> markedItemsCore;
        protected List<GalleryItem> MarkedItems {
            get {
                if(markedItemsCore == null)
                    markedItemsCore = new List<GalleryItem>();
                return markedItemsCore;
            }
        }
        protected PhotoViewerData ViewData {
            get {
                if(viewDataCore == null)
                    viewDataCore = new PhotoViewerData();
                return viewDataCore;
            }
        }
        protected string GetDataDir() {
            string rootPath = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
            for(int i = 0; i < 10; i++) {
                string fullPath = Path.GetFullPath(Path.Combine(rootPath, "Data"));
                if(Directory.Exists(fullPath))
                    return fullPath;
                rootPath += "\\..";
            }
            return string.Empty;
        }
        protected string DataPath {
            get {
                string _dataPath = Path.Combine(GetDataDir(), "PhotoViewer");
                if(Directory.Exists(_dataPath))
                    return _dataPath;
                return string.Empty;
            }
        }
        protected string ThumbPath {
            get { return Path.Combine(DataPath, "Thumbs"); }
        }
        protected string ViewDataFile {
            get { return Path.Combine(DataPath, "data.xml"); }
        }
        protected GalleryItem RightClickItem {
            get { return rightClickItemCore; }
            set { rightClickItemCore = value; }
        }
        protected AlbumData SelectedAlbum {
            get {
                AlbumData album = CustomizableLink == null ? null : CustomizableLink.Item.Tag as AlbumData;
                if(album == null)
                    album = albumGroup.SelectedLink == null ? null : (AlbumData)albumGroup.SelectedLink.Item.Tag;
                return album;
            }
        }
        protected NavBarItemLink CustomizableLink {
            get { return customizableLinkCore; }
            set { customizableLinkCore = value; }
        }
        void SaveData() {
            ViewData.FirstRun = false;
            ViewData.SaveLayoutToXml(ViewDataFile);
        }
        void LoadData() {
            ViewData.Clear();
            bool forceProcess = false;
            if(File.Exists(ViewDataFile)) {
                ViewData.RestoreLayoutFromXml(ViewDataFile);
            }
            if(ViewData.FirstRun) {
                GenerateSampleData();
                forceProcess = true;
            }
            InitNavBar();
            UpdateMainGalleryContent(forceProcess);
        }
        protected void UpdateData() { UpdateData(false); }
        protected void UpdateData(bool onlyAlbums) {
            SaveData();
            InitNavBar(onlyAlbums);
        }
        void InitSkins() {
            SkinHelper.InitSkinGallery(skinGalleryBarItem, true);
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful");
        }
        protected virtual void InitFilters() {
            Size imageSize = global::PhotoViewer.Properties.Resources.FilterSample.Size;
            imageSize.Width = (int)(imageSize.Width * 0.5);
            imageSize.Height = (int)(imageSize.Height * 0.5);
            filtersGallery.Gallery.ImageSize = imageSize;
            filtersGallery.Gallery.HoverImages = filtersGallery.Gallery.Images = FilterHelper.GetFiltersSamples(global::PhotoViewer.Properties.Resources.FilterSample);
            foreach(FilterInfo fInfo in FilterHelper.Filters) {
                filtersGallery.Gallery.Groups[0].Items.Add(CreateFilterGalleryItem(fInfo));
            }
        }
        void InitNavBar() {
            InitNavBar(false);
        }
        void InitNavBar(bool onlyAlbums) {
            navBarControl1.SelectedLink = null;
            foreach(NavBarGroup group in navBarControl1.Groups) {
                if(onlyAlbums && group != albumGroup)
                    continue;
                for(int i = group.ItemLinks.Count - 1; i >= 0; i--) {
                    navBarControl1.Items.Remove(group.ItemLinks[i].Item);
                }
            }
            navBarControl1.BeginUpdate();
            try {
                foreach(AlbumData album in ViewData.Albums) {
                    NavBarItem item = CreateAlbumItem(album);
                    navBarControl1.Items.Add(item);
                    albumGroup.ItemLinks.Add(item);
                }
                if(onlyAlbums)
                    return;
                foreach(PathData folder in ViewData.Folders) {
                    NavBarItem item = CreateFolderItem(folder);
                    if(item != null) {
                        navBarControl1.Items.Add(item);
                        foldersGroup.ItemLinks.Add(item);
                    }
                }
                foreach(PathData file in ViewData.Others.Files) {
                    NavBarItem item = CreateFolderItem(file);
                    if(item != null) {
                        navBarControl1.Items.Add(item);
                        othersGroup.ItemLinks.Add(item);
                    }
                }
            }
            finally { navBarControl1.EndUpdate(); }
            if(navBarControl1.Items.Count > 0)
                navBarControl1.SelectedLink = navBarControl1.Items[0].Links[0];
        }
        void SelectDefaultPage() {
            ribbonControl1.SelectedPage = imagePage;
        }
        GalleryItem CreateFilterGalleryItem(FilterInfo info) {
            GalleryItem item = new GalleryItem();
            item.HoverImageIndex = item.ImageIndex = FilterHelper.Filters.IndexOf(info);
            item.Caption = info.Name;
            item.Tag = info;
            item.Hint = info.Name;
            return item;
        }
        NavBarItem CreateFolderItem(PathData folder) {
            NavBarItem item = new NavBarItem();
            item.Caption = folder.Name;
            item.Hint = folder.Path;
            item.Tag = folder;
            item.LinkClicked += new NavBarLinkEventHandler(OnFolderLinkClicked);
            return item;
        }
        NavBarItem CreateAlbumItem(AlbumData album) {
            NavBarItem item = new NavBarItem();
            item.Caption = album.Name;
            item.Hint = album.Description;
            item.Tag = album;
            item.LinkClicked += new NavBarLinkEventHandler(OnAlbumLinkClicked);
            return item;
        }
        GalleryItem CreatePhotoGalleryItem(string fileName) {
            GalleryItem item = new GalleryItem();
            item.Caption = Path.GetFileName(fileName);
            item.Hint = fileName;
            item.Tag = fileName;
            return item;
        }
        GalleryItemGroup CreateFolderGroup(PathData folder) {
            GalleryItemGroup group = new GalleryItemGroup();
            group.Tag = folder;
            group.Caption = folder.Name;
            group.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
            group.CaptionControl = CreateFolderGroupCaptionControl(folder);
            return group;
        }
        Control CreateFolderGroupCaptionControl(PathData folder) {
            FolderGroupCaptionControl control = new FolderGroupCaptionControl();
            control.Folder = folder;
            control.MainForm = this;
            return control;
        }
        GalleryItemGroup CreateAlbumGroup(AlbumData albumData) {
            GalleryItemGroup group = new GalleryItemGroup();
            group.Tag = albumData;
            group.Caption = albumData.Name;
            group.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
            group.CaptionControl = CreateAlbumGroupCaptionControl(albumData);
            return group;
        }
        Control CreateAlbumGroupCaptionControl(AlbumData albumData) {
            AlbumGroupCaptionControl control = new AlbumGroupCaptionControl();
            control.Album = albumData;
            control.MainForm = this;
            return control;
        }
        BarItem CreateAddToAlbumItem(AlbumData album) {
            BarButtonItem item = new BarButtonItem(ribbonControl1.Manager, album != null ? album.Name : "New album...");
            item.ItemClick += new ItemClickEventHandler(OnAddToAlbumItemClick);
            item.Tag = album;
            return item;
        }
        private PathData CreateFilePathData(string fileName) {
            PathData pdata = new PathData();
            pdata.Path = fileName;
            pdata.Name = Path.GetFileName(fileName);
            return pdata;
        }
        protected virtual void CreateThumbForFiles(List<string> files, string progressText) {
            ProgressForm pf = new ProgressForm();
            pf.ProgressControl.Maximum = files.Count;
            pf.ProgressControl.ProgressText = progressText;
            pf.Show(this);
            foreach(string fileName in files) {
                CreateThumbForFile(fileName);
                pf.ProgressControl.Value++;
                Application.DoEvents();
            }
            pf.Close();
        }
        protected virtual void CreateThumbForFile(string fileName) {
            Image img = ThumbnailHelper.Default.GetThumbnail(fileName, 208, ThumbPath);
            if(img != null)
                img.Dispose();
        }
        protected virtual void CreateThumbsForFolder(PathData folder) {
            CreateThumbForFiles(GetImagesInFolder(folder), "Processing folder");
        }
        void OnFolderLinkClicked(object sender, NavBarLinkEventArgs e) { }
        void OnAlbumLinkClicked(object sender, NavBarLinkEventArgs e) { }
        void OnFormClosing(object sender, FormClosingEventArgs e) {
            if(File.Exists(ViewDataFile))
                ViewData.SaveLayoutToXml(ViewDataFile);
        }
        void OnExitButtonClick(object sender, EventArgs e) {
            if(XtraMessageBox.Show(this, "Exit Application?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Close();
            }
        }
        void OnNewAlbumItemClick(object sender, ItemClickEventArgs e) {
            AddNewAlbum();
        }
        void OnAddFolderItemClick(object sender, ItemClickEventArgs e) {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                if(!IsFolderAdded(folderBrowserDialog1.SelectedPath)) {
                    PathData p = new PathData();
                    p.Name = Path.GetFileName(folderBrowserDialog1.SelectedPath);
                    p.Path = folderBrowserDialog1.SelectedPath;
                    ViewData.Folders.Add(p);
                    CreateThumbsForFolder(p);
                    UpdateData();
                    navBarControl1.SelectedLink = GetLink(p);
                    UpdateMainGalleryContent(true);
                }
                UpdateAddToLibraryItem(e.Item);
            }
        }
        NavBarItemLink GetLink(string fileName) {
            foreach(NavBarItemLink link in othersGroup.ItemLinks) {
                if(((PathData)link.Item.Tag).Path == fileName)
                    return link;
            }
            return null;
        }
        NavBarItemLink GetLinkByTag(NavBarGroup group, object tag) {
            foreach(NavBarItemLink link in group.ItemLinks) {
                if(link.Item.Tag == tag)
                    return link;
            }
            return null;
        }
        NavBarItemLink GetLink(AlbumData album) {
            return GetLinkByTag(albumGroup, album);
        }
        NavBarItemLink GetLink(PathData path) {
            return GetLinkByTag(foldersGroup, path);
        }
        void OnAddFileClick(object sender, ItemClickEventArgs e) {
            if(imageDialog.ShowDialog() == DialogResult.OK) {
                string lastFileName = string.Empty;
                foreach(string fileName in imageDialog.FileNames) {
                    if(!IsFileAdded(fileName)) {
                        PathData p = new PathData();
                        p.Name = Path.GetFileName(fileName);
                        p.Path = fileName;
                        ViewData.Others.Files.Add(p);
                    }
                    lastFileName = fileName;
                }
                CreateThumbForFiles(new List<string>(imageDialog.FileNames), "Processing files");
                UpdateData();
                navBarControl1.SelectedLink = GetLink(lastFileName);
                UpdateMainGalleryContent(true);
            }
            UpdateAddToLibraryItem(e.Item);
        }
        void OnNavBarControl1SelectedLinkChanged(object sender, DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventArgs e) {
            UpdateMainGalleryContent(false);
            lastSelectedGroup = e.Group;
        }
        void OnNavBarControl1MouseDown(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Right)
                return;
            NavBarHitInfo hi = navBarControl1.GetViewInfo().CalcHitInfo(e.Location);
            if(hi.Link == null) {
                this.ribbonControl1.Manager.SetPopupContextMenu(this.navBarControl1, null);
                return;
            }
            CustomizableLink = hi.Link;
            if(hi.Group == albumGroup)
                this.ribbonControl1.Manager.SetPopupContextMenu(this.navBarControl1, this.albumPopupMenu);
            else if(hi.Group == foldersGroup)
                this.ribbonControl1.Manager.SetPopupContextMenu(this.navBarControl1, this.folderPopupMenu);
        }
        void OnRemoveAlbumItemClick(object sender, ItemClickEventArgs e) {
            if(CustomizableLink == null)
                return;
            AlbumData album = (AlbumData)customizableLinkCore.Item.Tag;
            RemoveAlbum(album);
        }
        void OnRemoveFolderItemClick(object sender, ItemClickEventArgs e) {
            if(CustomizableLink == null)
                return;
            PathData folder = (PathData)customizableLinkCore.Item.Tag;
            RemoveFolder(folder);
        }
        void OnMainGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            UpdateImageButtonsEnabledState();
            UpdateSelectedPictureEdit(e);
        }
        void OnMainGalleryMouseDown(object sender, MouseEventArgs e) {
            RibbonHitInfo hi = mainGallery.CalcHitInfo(e.Location);
            if(e.Button == MouseButtons.Right) {
                RightClickItem = hi.GalleryItem;
                ribbonControl1.Manager.SetPopupContextMenu(mainGallery, galleryItemMenu);
                return;
            }
        }
        void OnMarkItemClick(object sender, ItemClickEventArgs e) {
            ContextItemCollection contextBtns = mainGallery.Gallery.ContextButtons;
            CheckContextButton checkBtn = contextBtns["itemCheck"] as CheckContextButton;
            checkBtn.Checked = true;

            UnmarkItems();
            MarkItems(mainGallery.Gallery.GetAllItems());
            UpdateImageButtonsEnabledState();
        }
        void OnSelectionGalleryCustomDrawItemImage(object sender, GalleryItemCustomDrawEventArgs e) {
            if(!MarkedItems.Contains(e.Item))
                return;
            if(e.Item.Image != null) {
                e.Cache.Graphics.DrawImage(e.Item.Image, ((GalleryItemViewInfo)e.ItemInfo).ImageContentBounds);
            }
            DrawMarkedIconInSelection(e.Cache, ((GalleryItemViewInfo)e.ItemInfo).ImageClientBounds);
            e.Handled = true;
        }
        void OnMainGalleryCustomDrawItemImage(object sender, GalleryItemCustomDrawEventArgs e) {
            if(!MarkedItems.Contains(e.Item))
                return;
            if(e.Item.Image != null) {
                e.Cache.Graphics.DrawImage(e.Item.Image, ((GalleryItemViewInfo)e.ItemInfo).ImageContentBounds);
            }
            e.Handled = true;
        }
        void OnUnmarkAllItemClick(object sender, ItemClickEventArgs e) {
            CheckCollContextBtn("itemCheck", false);
            UnmarkItems();
            mainGallery.Gallery.LayoutChanged();
            UpdateImageButtonsEnabledState();
        }
        void OnUnmarkItemClick(object sender, ItemClickEventArgs e) {
            List<GalleryItem> items = mainGallery.Gallery.GetCheckedItems();
            UnmarkItems(items);
            mainGallery.Refresh();
        }
        void OnAddToAlbumButtonShowDropDownControl(object sender, ShowDropDownControlEventArgs e) {
            UpdateAlbumsMenu();
        }
        void OnAddToAlbumItemClick(object sender, ItemClickEventArgs e) {
            AlbumData album = e.Item.Tag as AlbumData;
            if(album == null)
                album = AddNewAlbum();
            if(album == null)
                return;
            List<GalleryItem> items = MarkedItems;
            foreach(GalleryItem item in items) {
                if(!album.Files.Contains((string)item.Tag))
                    album.Files.Add(CreateFilePathData((string)item.Tag));
            }
            UnmarkItems();
            UpdateMainGalleryContent(true);
        }
        void OnZoomTackValueChanged(object sender, EventArgs e) {
            ZoomTrackBarControl control = (ZoomTrackBarControl)sender;
            mainGallery.Gallery.ImageSize = new Size(control.Value, control.Value);
        }
        void OnViewImageItemClick(object sender, ItemClickEventArgs e) {
            string fileName = ((string)RightClickItem.Tag);
            List<string> files = new List<string>(1);
            files.Add(fileName);
            ViewSelectedImages(Path.GetFileName(fileName), fileName, files);
        }
        void OnTabControlCloseButtonClick(object sender, EventArgs e) {
            CloseSelectedTabPage();
        }
        void OnEditAlbumItemClick(object sender, ItemClickEventArgs e) {
            EditAlbum();
        }
        void OnAlbumPopupMenuCloseUp(object sender, EventArgs e) {
            CustomizableLink = null;
        }
        void OnViewSelectedImagesItemClick(object sender, ItemClickEventArgs e) {
            List<string> files = GetFilesInSelection();
            if(files.Count == 0) {
                XtraMessageBox.Show(this, "None of images selected.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string tabName = files.Count > 1 ? "Collection" : Path.GetFileName(files[0]);
            ViewSelectedImages(tabName, "", files);
        }
        void OnAboutItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            BarManager.About();
        }
        List<Image> GetCheckedImages() {
            List<GalleryItem> items = MarkedItems;
            List<Image> images = new List<Image>(items.Count);
            foreach(GalleryItem item in items) {
                images.Add(Image.FromFile((string)item.Tag));
            }
            return images;
        }
        void OnPrintItemClick(object sender, ItemClickEventArgs e) {
            List<Image> images = GetCheckedImages();
            PrintingSystem ps = new PrintingSystem();

            ps.PageSettings.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A5;
            ps.PageSettings.Landscape = true;
            ps.PageSettings.LeftMargin = 0;
            ps.PageSettings.RightMargin = 0;
            ps.PageSettings.TopMargin = 0;
            ps.PageSettings.BottomMargin = 0;

            BrickGraphics gr = ps.Graph;
            ps.Begin();


            float offsetY = 0;
            foreach(Image image in images) {
                ImageBrick imageBrick = new ImageBrick();
                imageBrick.Image = image;
                imageBrick.BorderWidth = 0;
                imageBrick.BorderStyle = BrickBorderStyle.Inset;
                imageBrick.Sides = BorderSide.All;

                imageBrick.SizeMode = ImageSizeMode.Squeeze;
                gr.DrawBrick(imageBrick, new RectangleF(new PointF(0, offsetY), ps.PageSettings.UsablePageSizeInPixels));
                offsetY += ps.PageSettings.UsablePageSizeInPixels.Height;
            }
            ps.End();

            new PrintTool(ps).ShowPreviewDialog();
        }
        void OnExportItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own export dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnEmailItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Here you can make preparations for e-mail.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnUploadItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own upload settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnCollageItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own collage settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnSlideShowItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own slideshow settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnFilmItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own film settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnMainTabSelectedPageChanged(object sender, EventArgs e) {
            if(controlPresenter1.SelectedControl != libraryPanel)
                ShowViewCategory();
            else
                HideViewCategory();
        }
        void OnCloseImageItemClick(object sender, ItemClickEventArgs e) {
            CloseSelectedTabPage();
        }
        void OnSaveImageItemClick(object sender, ItemClickEventArgs e) {
            XtraMessageBox.Show(this, "SaveImageItemClick", "PhotoViewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void OnCancelFilterItemClick(object sender, ItemClickEventArgs e) {
            ImageCollectionViewer imageCollectionViewer = controlPresenter1.SelectedControl as ImageCollectionViewer;
            if(imageCollectionViewer == null)
                return;
            imageCollectionViewer.CancelFilters();
            UpdateCancelButtonEnabledState();
        }
        void OnAddToAlbumItemPress(object sender, ItemClickEventArgs e) {
            UpdateAlbumsMenu();
        }
        void OnFiltersGalleryInitDropDown(object sender, InplaceGalleryEventArgs e) {
            e.PopupGallery.AllowHoverImages = false;
            e.PopupGallery.ImageSize = global::PhotoViewer.Properties.Resources.FilterSample.Size;
            e.PopupGallery.ShowItemText = true;
            e.PopupGallery.ItemImageLocation = Locations.Top;
            e.PopupGallery.SynchWithInRibbonGallery = true;
        }
        void OnFilterGalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            ImageCollectionViewer imageCollectionViewer = controlPresenter1.SelectedControl as ImageCollectionViewer;
            if(imageCollectionViewer == null || !e.Item.Checked)
                return;
            imageCollectionViewer.SetFilter((FilterInfo)e.Item.Tag);
        }
        void OnRibbonControlSelectedPageChanged(object sender, EventArgs e) {
            Control page = ribbonControl1.SelectedPage.Tag as Control;
            if(page == null)
                page = libraryPanel;
            controlPresenter1.SelectedControl = page;
            UpdateItemsEnabledState();
            beZoom.Visibility = page == libraryPanel ? BarItemVisibility.Always : BarItemVisibility.Never;
        }
        void OnAddToLibraryItemClick(object sender, ItemClickEventArgs e) {
            BarItem item = biAddToLibrary.Tag as BarItem;
            if(item != null)
                item.PerformClick();
        }
        void OnMainGalleryDoubleClick(object sender, GalleryItemClickEventArgs e) {
            e.Item.Checked = true;
            string fileName = ((string)e.Item.Tag);
            List<string> files = new List<string>(1);
            files.Add(fileName);
            ViewSelectedImages(Path.GetFileName(fileName), fileName, files);
        }
        void OnFilterByMarkedCheckedChanged(object sender, ItemClickEventArgs e) {
            FilterByMarked(biFilterByMarked.Checked);
        }
        void OnGenerateDataItemClick(object sender, ItemClickEventArgs e) {
            if(XtraMessageBox.Show(this, "Are you sure you want generate data? Current data will be lost.", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            GenerateSampleData();
        }
        void OnRemoveFromAlbumItemClick(object sender, ItemClickEventArgs e) {
            List<GalleryItem> items = MarkedItems;
            if(items.Count == 0)
                return;
            RemoveImagesFromAlbum(items);
        }
        void ScrollToFolder(PathData path, bool bAnimated) {
            mainGallery.Gallery.ScrollTo(GetGalleryGroupByTag(path), bAnimated);
        }
        void ScrollToFile(string fileName, bool bAnimated) {
            mainGallery.Gallery.ScrollTo(GetGalleryItemByTag(fileName), bAnimated);
        }
        void ScrollToAlbum(AlbumData album, bool bAnimated) {
            mainGallery.Gallery.ScrollTo(GetGalleryGroupByTag(album), bAnimated);
        }
        void ProcessAlbums() {
            mainGallery.Gallery.BeginUpdate();
            try {
                ClearGalleryAndImages();
                foreach(AlbumData album in ViewData.Albums) {
                    ProcessAlbum(album);
                }
            }
            finally {
                mainGallery.Gallery.EndUpdate();
            }
        }
        void ProcessAlbum(AlbumData albumData, bool showEditButtons) {
            GalleryItemGroup group = CreateAlbumGroup(albumData);
            AlbumGroupCaptionControl control = (AlbumGroupCaptionControl)group.CaptionControl;
            if(!showEditButtons)
                control.HideEditButtons();
            mainGallery.Gallery.Groups.Add(group);
            foreach(PathData pData in albumData.Files) {
                group.Items.Add(CreatePhotoGalleryItem(pData.Path));
            }
        }
        void ProcessAlbum(AlbumData albumData) {
            ProcessAlbum(albumData, true);
        }
        void ProcessOthers() {
            mainGallery.Gallery.BeginUpdate();
            try {
                ClearGalleryAndImages();
                ProcessAlbum(ViewData.Others, false);
            }
            finally {
                mainGallery.Gallery.EndUpdate();
            }
        }
        void ProcessFolder(PathData folder) {
            GalleryItemGroup group = CreateFolderGroup(folder);
            mainGallery.Gallery.Groups.Add(group);

            List<string> files = GetImagesInFolder(folder);
            foreach(string fileName in files) {
                group.Items.Add(CreatePhotoGalleryItem(fileName));
            }
        }
        void ProcessFolders() {
            mainGallery.Gallery.BeginUpdate();
            try {
                ClearGalleryAndImages();
                foreach(PathData pData in ViewData.Folders) {
                    ProcessFolder(pData);
                }
            }
            finally { mainGallery.Gallery.EndUpdate(); }
        }
        AlbumData AddNewAlbum() {
            AlbumPropertiesForm form = new AlbumPropertiesForm(ViewData);
            form.Text = "New album properties";
            form.Owner = this;
            if(form.ShowDialog() == DialogResult.OK) {
                AlbumData album = new AlbumData();
                album.Name = form.AlbumName;
                album.Date = form.AlbumDate;
                album.Description = form.AlbumDescription;
                ViewData.Albums.Add(album);
                UpdateData(true);
                navBarControl1.SelectedLink = GetLink(album);
                UpdateMainGalleryContent(true);
                return album;
            }
            return null;
        }
        internal void EditAlbum(AlbumData album) {
            if(album == null)
                return;
            AlbumPropertiesForm form = new AlbumPropertiesForm(ViewData);
            form.Text = "Edit album properties";
            form.Owner = this;
            form.AlbumName = album.Name;
            form.AlbumDate = album.Date;
            form.AlbumDescription = album.Description;
            form.IsEditExistingAlbumMode = true;
            if(form.ShowDialog() == DialogResult.OK) {
                album.Name = form.AlbumName;
                album.Date = form.AlbumDate;
                album.Description = form.AlbumDescription;
                UpdateData(true);
                foreach(NavBarItemLink link in navBarControl1.Groups[0].ItemLinks) {
                    if(link.Item.Tag == album) {
                        navBarControl1.Groups[0].SelectedLink = link;
                        UpdateMainGalleryContent(true);
                        break;
                    }
                }
            }
        }
        internal void EditAlbum() {
            EditAlbum(SelectedAlbum);
        }
        internal void RemoveAlbum(AlbumData album) {
            if(XtraMessageBox.Show(this, "Are you really want to remove album?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                ViewData.Albums.Remove(album);
                UpdateData();
                UpdateMainGalleryContent(true);
            }
        }
        internal void RemoveFolder(PathData folder) {
            if(XtraMessageBox.Show(this, "Are you really want to remove folder?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                ViewData.Folders.Remove(folder);
                UpdateData();
                UpdateMainGalleryContent(true);
            }
        }
        void MarkItems(List<GalleryItem> items) {
            foreach(GalleryItem item in items) {
                if(!MarkedItems.Contains(item)) {
                    MarkedItems.Add(item);
                }
            }
        }
        void UnmarkItems(List<GalleryItem> items) {
            foreach(GalleryItem item in items) {
                MarkedItems.Remove(item);
            }
        }
        void UnmarkItems() {
            MarkedItems.Clear();
        }
        bool IsPathAdded(string path, PathCollection coll) {
            foreach(PathData p in coll) {
                if(p.Path == path)
                    return true;
            }
            return false;
        }
        bool IsFolderAdded(string folderPath) {
            return IsPathAdded(folderPath, ViewData.Folders);
        }
        bool IsFileAdded(string fileName) {
            return IsPathAdded(fileName, ViewData.Others.Files);
        }
        void ClearGalleryAndImages() {
            mainGallery.Gallery.Groups.Clear();
            foreach(GalleryItemGroup group in mainGallery.Gallery.Groups) {
                if(group.CaptionControl != null) {
                    group.CaptionControl.Dispose();
                    group.CaptionControl = null;
                    foreach(GalleryItem item in group.Items) {
                        if(item.Image != null) {
                            item.Image.Dispose();
                            item.Image = null;
                        }
                        PathData pData = item.Tag as PathData;
                        pData.Image = null;
                    }
                }
            }
        }
        protected List<string> GetImagesInFolder(PathData folder) {
            string strFilter = "*bmp;*tga;*.jpg;*.png;*.gif";
            string[] m_arExt = strFilter.Split(';');
            List<string> files = new List<string>();
            foreach(string filter in m_arExt) {
                string[] str = Directory.GetFiles(folder.Path, filter);
                files.AddRange(str);
            }
            return files;
        }
        GalleryItemGroup GetGalleryGroupByTag(object tag) {
            foreach(GalleryItemGroup group in mainGallery.Gallery.Groups) {
                if(group.Tag == tag)
                    return group;
            }
            return null;
        }
        GalleryItem GetGalleryItemByTag(object tag) {
            foreach(GalleryItemGroup group in mainGallery.Gallery.Groups) {
                foreach(GalleryItem item in group.Items) {
                    if(item.Tag == tag)
                        return item;
                }
            }
            return null;
        }
        RectangleF InflateClip(GraphicsCache cache) {
            RectangleF clipBounds = cache.Graphics.ClipBounds;
            RectangleF rect = cache.Graphics.ClipBounds;
            rect.Inflate(50, 50);
            cache.Graphics.SetClip(rect);
            return clipBounds;
        }
        void DrawMarkedIconInSelection(GraphicsCache cache, Rectangle bounds) {
            RectangleF oldClipBounds = InflateClip(cache);
            cache.Graphics.DrawImage(global::PhotoViewer.Properties.Resources.ItemMarked_16x16, new Rectangle(bounds.Right - 10, bounds.Bottom - 10, 16, 16));
            cache.Graphics.SetClip(oldClipBounds);
        }
        void UpdateAlbumsMenu() {
            for(int i = this.albumsPopupMenu.ItemLinks.Count - 1; i >= 0; i--) {
                BarItemLink link = this.albumsPopupMenu.ItemLinks[i];
                link.Item.ItemClick -= new ItemClickEventHandler(OnAddToAlbumItemClick);
                ribbonControl1.Manager.Items.Remove(link.Item);
            }
            albumsPopupMenu.ItemLinks.Clear();
            foreach(AlbumData album in ViewData.Albums) {
                albumsPopupMenu.ItemLinks.Add(CreateAddToAlbumItem(album));
            }
            BarItemLink newAlbumLink = albumsPopupMenu.ItemLinks.Add(CreateAddToAlbumItem(null));
            newAlbumLink.BeginGroup = true;
        }
        void ShowViewCategory() {
            if(controlPresenter1.SelectedControl.Tag != null)
                return;
            viewPageCategory.Visible = true;
            collectionOriginalPage.Visible = false;
            RibbonPage ribbonPage = (RibbonPage)((ICloneable)collectionOriginalPage).Clone();
            ribbonPage.Visible = true;
            ribbonPage.Text = controlPresenter1.SelectedControl.Text;
            viewPageCategory.Pages.Add(ribbonPage);
            ribbonPage.Tag = controlPresenter1.SelectedControl;
            controlPresenter1.SelectedControl.Tag = ribbonPage;
            ribbonControl1.SelectedPage = ribbonPage;
        }
        void HideViewCategory() {
            if(viewPageCategory.Pages.Count == 1)
                viewPageCategory.Visible = false;
        }
        void ViewSelectedImages(string tabName, string toolTip, List<string> files) {
            ImageCollectionViewer imageCollectionViewer = new ImageCollectionViewer(files, ThumbPath);
            imageCollectionViewer.SetMenuManager(ribbonControl1.Manager);
            imageCollectionViewer.Text = tabName;
            imageCollectionViewer.Dock = DockStyle.Fill;
            imageCollectionViewer.SetFilter(GetSelectedFilter());
            controlPresenter1.Controls.Add(imageCollectionViewer);
            controlPresenter1.SelectedControl = imageCollectionViewer;
        }
        FilterInfo GetSelectedFilter() {
            foreach(GalleryItemGroup group in filtersGallery.Gallery.Groups) {
                foreach(GalleryItem item in group.Items) {
                    if(item.Checked)
                        return (FilterInfo)item.Tag;
                }
            }
            return null;
        }
        List<string> GetFilesInSelection() {
            List<GalleryItem> items = MarkedItems;
            List<string> res = new List<string>(items.Count);
            foreach(GalleryItem item in items) {
                res.Add((string)item.Tag);
            }
            return res;
        }
        void UpdateAlbumButtonsEnabledState() {
            biEditAlbum.Enabled = SelectedAlbum != null;
            biRemoveAlbum.Enabled = SelectedAlbum != null;
        }
        void UpdateImageButtonsEnabledState() {
            bool hasFiles = GetFilesInSelection().Count > 0;
            biView.Enabled = hasFiles;
            biRemoveFilesFromLibrary.Enabled = hasFiles;
            biAddToAlbum.Enabled = hasFiles;
            biCollage.Enabled = hasFiles;
            biSlideShow.Enabled = hasFiles;
            biFilm.Enabled = hasFiles;
            biExportFolder.Enabled = hasFiles;
            biEmail.Enabled = hasFiles;
            biUpload.Enabled = hasFiles;
            biPrint.Enabled = hasFiles;
            biUnmark.Enabled = hasFiles;
            biRemoveFromAlbum.Enabled = hasFiles && navBarControl1.SelectedLink != null && (navBarControl1.SelectedLink.Item.Tag is AlbumData || navBarControl1.SelectedLink.Group == othersGroup);
        }
        void UpdateSelectedPictureEdit(GalleryItemEventArgs e) {
            selectedPictureEdit.LoadAsync((string)e.Item.Tag);
        }
        void UpdateItemsEnabledState() {
            UpdateImageButtonsEnabledState();
            UpdateAlbumButtonsEnabledState();
            UpdateCancelButtonEnabledState();
        }
        void CloseSelectedTabPage() {
            Control page = controlPresenter1.SelectedControl;
            if(page == libraryPanel)
                page = controlPresenter1.Controls[controlPresenter1.Controls.Count - 1];
            if(page == libraryPanel)
                return;
            controlPresenter1.Controls.Remove(page);
            page.Dispose();
            RibbonPage ribbonPage = (RibbonPage)page.Tag;
            ribbonPage.Category.Pages.Remove(ribbonPage);
            ribbonPage.Dispose();
        }
        void UpdateAddToLibraryItem(BarItem item) {
            biAddToLibrary.Glyph = item.Glyph;
            biAddToLibrary.LargeGlyph = item.LargeGlyph;
            biAddToLibrary.SuperTip = item.SuperTip;
            biAddToLibrary.Hint = item.Hint;
            biAddToLibrary.Tag = item;
        }
        void FilterByMarked(bool filterByMarked) {
            mainGallery.Gallery.BeginUpdate();
            try {
                foreach(GalleryItemGroup group in mainGallery.Gallery.Groups) {
                    foreach(GalleryItem item in group.Items) {
                        item.Visible = !filterByMarked || MarkedItems.Contains(item);
                    }
                }
            }
            finally {
                mainGallery.Gallery.EndUpdate();
                mainGallery.Gallery.LayoutChanged();
            }
        }
        void GenerateSampleData() {
            ViewData.Clear();

            AddFolder("\\SamplePhotos\\Photo1");
            AddFolder("\\SamplePhotos\\Photo2");
            AddFolder("\\SamplePhotos\\Photo3");
            AddFolder("\\SamplePhotos\\Photo4");

            if(ViewData.Folders.Count > 1) {
                List<string> files = GetImagesInFolder(ViewData.Folders[0]);
                files.AddRange(GetImagesInFolder(ViewData.Folders[1]));

                AddAlbum("Sample Album 1", DateTime.Now, "This is a sample album 1", files);
            }
            if(ViewData.Folders.Count > 3) {
                List<string> files = GetImagesInFolder(ViewData.Folders[2]);
                files.AddRange(GetImagesInFolder(ViewData.Folders[3]));

                AddAlbum("Sample Album 2", DateTime.Now, "This is a sample album 2", files);
            }

            ViewData.Others.Name = "Other";
            ViewData.Others.Date = DateTime.Now;
            ViewData.Others.Description = "Other image files";

            UpdateData();
            UpdateMainGalleryContent(true);
        }
        void AddFolder(string relativePath) {
            PathData pData = new PathData();
            pData.Path = DataPath + relativePath;
            pData.Name = Path.GetFileName(pData.Path);
            if(!Directory.Exists(pData.Path)) {
                XtraMessageBox.Show(this, "Error: no such path '" + pData.Path + "'. Maybe you removed this folder?", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ViewData.Folders.Add(pData);
        }
        void AddAlbum(string albumName, DateTime albumDate, string description, List<string> files) {
            AlbumData aData = new AlbumData();
            aData.Name = albumName;
            aData.Date = albumDate;
            aData.Description = description;
            foreach(string file in files) {
                PathData pData = new PathData();
                pData.Path = file;
                aData.Files.Add(pData);
            }
            ViewData.Albums.Add(aData);
        }
        void RemoveImagesFromAlbum(List<GalleryItem> items) {
            AlbumData aData = navBarControl1.SelectedLink.Item.Tag as AlbumData;
            string messageText = string.Empty;
            if(aData == null) {
                if(navBarControl1.SelectedLink.Group == othersGroup) {
                    aData = ViewData.Others;
                    messageText = "Are you sure you want to remove checked items?";
                }
                else return;
            }
            else {
                messageText = "Are you sure you want to remove checked items from album '" + aData.Name + "'?";
            }
            if(XtraMessageBox.Show(this, messageText, Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            foreach(GalleryItem item in items) {
                aData.Files.Remove((string)item.Tag);
            }
            UpdateData();
            UpdateMainGalleryContent(true);
        }
        bool flag = false;
        void UpdateMainGalleryContent(bool forceProcess) {
            if(navBarControl1.SelectedLink == null) {
                ClearGalleryAndImages();
                return;
            }
            AlbumData album = navBarControl1.SelectedLink.Item.Tag as AlbumData;
            PathData path = navBarControl1.SelectedLink.Item.Tag as PathData;
            bool shouldRecreateGallery = lastSelectedGroup != navBarControl1.SelectedLink.Group || forceProcess;
            bool isOtherFiles = navBarControl1.SelectedLink.Group == othersGroup;
            if(album != null) {
                if(shouldRecreateGallery)
                    ProcessAlbums();
                if(!flag)
                    ScrollToAlbum(album, !shouldRecreateGallery);
            }
            else if(path != null) {
                if(shouldRecreateGallery) {
                    if(isOtherFiles)
                        ProcessOthers();
                    else
                        ProcessFolders();
                }
                if(isOtherFiles)
                    ScrollToFile(path.Path, !shouldRecreateGallery);
                else
                    ScrollToFolder(path, !shouldRecreateGallery);
            }
            UpdateItemsEnabledState();
        }
        internal void UpdateCancelButtonEnabledState() {
            ImageCollectionViewer viewer = controlPresenter1.SelectedControl as ImageCollectionViewer;
            biCancel.Enabled = viewer != null && viewer.IsImageFilterd();
        }
        void OnSelectAllMarkedItemClick(object sender, ItemClickEventArgs e) {
            foreach(GalleryItem item in MarkedItems) {
                bool unselectOtherItems = MarkedItems.IndexOf(item) == 0;
                mainGallery.Gallery.SetItemCheck(item, true, unselectOtherItems);
            }
        }
        void filtersGallery_Gallery_PopupClose(object sender, InplaceGalleryEventArgs e) {
            List<GalleryItem> items = e.Item.Gallery.GetCheckedItems();
            if(items.Count > 0)
                e.Item.Gallery.MakeVisible(items[0]);
        }
        void OnDateFilterSelectionChanged(object sender, EventArgs e) {
            mainGallery.Gallery.BeginUpdate();
            try {
                List<GalleryItem> items = mainGallery.Gallery.GetAllItems();
                foreach(GalleryItem item in items) {
                    DateTime date = File.GetCreationTime((string)item.Tag);
                    item.Visible = !dateFilter1.AllowFilter || (date >= dateFilter1.StartDate && date <= dateFilter1.EndDate);
                }
            }
            finally { mainGallery.Gallery.EndUpdate(); }
        }
        void galleryControlGallery1_MarqueeSelectionCompleted(object sender, GallerySelectionEventArgs e) {
            Point pt = Control.MousePosition;
            pt.Y -= 11;
            this.ribbonMiniToolbar1.Show(pt);
        }
        void repositoryItemZoomTrackBar1_ValueChanged(object sender, EventArgs e) {
            OnZoomTackValueChanged(sender, e);
        }
        void bBColorMix_ItemClick(object sender, ItemClickEventArgs e) {
            ColorWheelForm form = new ColorWheelForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor;
            form.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2;
            form.ShowDialog(this);
        }
        Dictionary<GalleryItem, int> ratingValuesCore;
        protected Dictionary<GalleryItem, int> RatingValues {
            get {
                if(ratingValuesCore == null)
                    ratingValuesCore = new Dictionary<GalleryItem, int>();
                return ratingValuesCore;
            }
        }
        void OnMainGallery_ContextButtonCustomize(object sender, GalleryContextButtonCustomizeEventArgs e) {
            GalleryControlGallery gallery = sender as GalleryControlGallery;
            switch(e.Item.Name) {
                case "itemRating":
                    RatingContextButton rating = e.Item as RatingContextButton;
                    int value;
                    if(!RatingValues.TryGetValue(e.GalleryItem, out value)) {
                        rating.Rating = DevExpress.Data.Utils.NonCryptographicRandom.Default.Next(0, 6);
                        RatingValues.Add(e.GalleryItem, (int)rating.Rating);
                    }
                    else rating.Rating = value;
                    break;
                case "itemCheck":
                    CheckContextButton check = e.Item as CheckContextButton;
                    if(MarkedItems.Contains(e.GalleryItem))
                        check.Checked = true;
                    break;
                case "itemInfo":
                    ContextButton btn = e.Item as ContextButton;
                    btn.Caption = e.GalleryItem.Caption;
                    break;
                default:
                    break;
            }
        }
        void SelectLinkByGalleryItem(GalleryItem galleryItem) {
            foreach(NavBarItem navItem in navBarControl1.Items) {
                if(navItem.Links[0].Caption == galleryItem.GalleryGroup.Caption && navBarControl1.SelectedLink != navItem.Links[0]) {
                    flag = true;
                    navBarControl1.SelectedLink = navItem.Links[0];
                    flag = false;
                }
            }
        }
        void CheckItemContextButton(GalleryItem galleryItem, CheckContextButton checkItem) {
            if(checkItem.Checked && !MarkedItems.Contains(galleryItem))
                MarkedItems.Add(galleryItem);
            if(!checkItem.Checked && MarkedItems.Contains(galleryItem))
                MarkedItems.Remove(galleryItem);
        }
        void ShowItemImageLocation(GalleryItem galleryItem) {
            string path = galleryItem.Hint;
            string folderPath = Path.GetDirectoryName(path);
            SafeProcess.Start(folderPath);
        }
        void galleryControlGallery1_ContextButtonClick(object sender, ContextItemClickEventArgs e) {
            GalleryItem galleryItem = e.DataItem as GalleryItem;
            SelectLinkByGalleryItem(galleryItem);

            switch(e.Item.Name) {
                case "itemCheck":
                    CheckItemContextButton(galleryItem, e.Item as CheckContextButton);
                    UpdateImageButtonsEnabledState();
                    break;
                case "itemRating":
                    RatingValues[galleryItem] = (int)(e.Item as RatingContextButton).Rating;
                    break;
                case "itemRemove":
                    List<GalleryItem> items = new List<GalleryItem>();
                    items.Add(galleryItem);
                    RemoveImagesFromAlbum(items);
                    break;
                case "itemLocation":
                    ShowItemImageLocation(galleryItem);
                    break;
            }
        }
        void navBarControl1_ActiveGroupChanged(object sender, NavBarGroupEventArgs e) {
            CheckCollContextBtn("itemCheck", false);
            UnmarkItems();
            UpdateMainGalleryContent(true);
        }
        void CheckCollContextBtn(string name, bool isChecked) {
            ContextItemCollection contextBtns = mainGallery.Gallery.ContextButtons;
            CheckContextButton checkBtn = contextBtns[name] as CheckContextButton;
            checkBtn.Checked = isChecked;
        }
        void galleryControlGallery1_GetThumbnailImage(object sender, GalleryThumbnailImageEventArgs e) {
            if(e.Item.Tag != null) {
                try {
                    if(File.Exists((string)e.Item.Tag)) {
                        e.ThumbnailImage = e.CreateThumbnailImage(Image.FromFile((string)e.Item.Tag));
                    }
                }
                catch { }
            }
        }
        void OnAnimationTypeChanged(object sender, ItemClickEventArgs e) {
            if(e.Item == this.bcAnimationNone)
                this.mainGallery.Gallery.OptionsImageLoad.AnimationType = ImageContentAnimationType.None;
            else if(e.Item == this.bcExpandAnimation)
                this.mainGallery.Gallery.OptionsImageLoad.AnimationType = ImageContentAnimationType.Expand;
            else if(e.Item == this.bcPushAnimation)
                this.mainGallery.Gallery.OptionsImageLoad.AnimationType = ImageContentAnimationType.Push;
            else if(e.Item == this.bcSlideAnimation)
                this.mainGallery.Gallery.OptionsImageLoad.AnimationType = ImageContentAnimationType.Slide;
            else if(e.Item == this.bcSegmentedAnimation)
                this.mainGallery.Gallery.OptionsImageLoad.AnimationType = ImageContentAnimationType.SegmentedFade;
        }
        void barCheckItem1_ItemClick(object sender, ItemClickEventArgs e) {
            this.mainGallery.Gallery.OptionsImageLoad.RandomShow = barCheckItem1.Checked;
        }
    }

    public class PhotoViewerSplashScreen : DemoSplashScreen {
        public PhotoViewerSplashScreen() {
            DemoText = "PhotoViewer";
            ProductText = "The XtraBars Suite";
        }
    }
}
