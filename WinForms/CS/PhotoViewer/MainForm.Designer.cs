using DevExpress.XtraTab;
namespace PhotoViewer {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup3 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup4 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.Utils.ContextButton contextButton1 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.ContextButton contextButton2 = new DevExpress.Utils.ContextButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.Utils.ContextButton contextButton3 = new DevExpress.Utils.ContextButton();
            DevExpress.Utils.CheckContextButton checkContextButton1 = new DevExpress.Utils.CheckContextButton();
            DevExpress.Utils.RatingContextButton ratingContextButton1 = new DevExpress.Utils.RatingContextButton();
            this.biAddFolder = new DevExpress.XtraBars.BarButtonItem();
            this.biAddFile = new DevExpress.XtraBars.BarButtonItem();
            this.biPrint = new DevExpress.XtraBars.BarButtonItem();
            this.biExit = new DevExpress.XtraBars.BarButtonItem();
            this.albumSubItem = new DevExpress.XtraBars.BarSubItem();
            this.biNewAlbum = new DevExpress.XtraBars.BarButtonItem();
            this.biEditAlbum = new DevExpress.XtraBars.BarButtonItem();
            this.biRemoveAlbum = new DevExpress.XtraBars.BarButtonItem();
            this.bsView = new DevExpress.XtraBars.BarSubItem();
            this.biView = new DevExpress.XtraBars.BarButtonItem();
            this.bsTools = new DevExpress.XtraBars.BarSubItem();
            this.bsSkins = new DevExpress.XtraBars.BarSubItem();
            this.bsHelp = new DevExpress.XtraBars.BarSubItem();
            this.biAbout = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.biRemoveFolder = new DevExpress.XtraBars.BarButtonItem();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.albumGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.foldersGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.othersGroup = new DevExpress.XtraNavBar.NavBarGroup();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.albumPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.popupControlContainer1 = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.exitButton = new DevExpress.XtraEditors.SimpleButton();
            this.biEmail = new DevExpress.XtraBars.BarButtonItem();
            this.biGenerateData = new DevExpress.XtraBars.BarButtonItem();
            this.skinGalleryBarItem = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.biExportFolder = new DevExpress.XtraBars.BarButtonItem();
            this.biUpload = new DevExpress.XtraBars.BarButtonItem();
            this.biAddToLibrary = new DevExpress.XtraBars.BarButtonItem();
            this.addToLibraryMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.biRemoveFilesFromLibrary = new DevExpress.XtraBars.BarButtonItem();
            this.biAddToAlbum = new DevExpress.XtraBars.BarButtonItem();
            this.albumsPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.biMark = new DevExpress.XtraBars.BarButtonItem();
            this.biUnmark = new DevExpress.XtraBars.BarButtonItem();
            this.biUnmarkAll = new DevExpress.XtraBars.BarButtonItem();
            this.biCollage = new DevExpress.XtraBars.BarButtonItem();
            this.biSlideShow = new DevExpress.XtraBars.BarButtonItem();
            this.biFilm = new DevExpress.XtraBars.BarButtonItem();
            this.biSaveImage = new DevExpress.XtraBars.BarButtonItem();
            this.biCancel = new DevExpress.XtraBars.BarButtonItem();
            this.biClose = new DevExpress.XtraBars.BarButtonItem();
            this.filtersGallery = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.biFilterByMarked = new DevExpress.XtraBars.BarCheckItem();
            this.biRemoveFromAlbum = new DevExpress.XtraBars.BarButtonItem();
            this.biSelectAllMarked = new DevExpress.XtraBars.BarButtonItem();
            this.beZoom = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup2 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup3 = new DevExpress.XtraBars.BarButtonGroup();
            this.barButtonGroup4 = new DevExpress.XtraBars.BarButtonGroup();
            this.bBColorMix = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.bsAnimationType = new DevExpress.XtraBars.BarSubItem();
            this.bcAnimationNone = new DevExpress.XtraBars.BarCheckItem();
            this.bcExpandAnimation = new DevExpress.XtraBars.BarCheckItem();
            this.bcPushAnimation = new DevExpress.XtraBars.BarCheckItem();
            this.bcSegmentedAnimation = new DevExpress.XtraBars.BarCheckItem();
            this.bcSlideAnimation = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.viewPageCategory = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.collectionOriginalPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.filtersFilePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.filtersPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.imagePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.imageGeneralPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.imageMarkingPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.makePageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.outputPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.folderPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.folderPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.albumPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.albumPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.viewPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.skinsPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mainGallery = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.defaultToolTipController1 = new DevExpress.Utils.DefaultToolTipController(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.libraryPanel = new System.Windows.Forms.UserControl();
            this.galleryContentPanel = new System.Windows.Forms.Panel();
            this.galleryPanel = new System.Windows.Forms.Panel();
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.selectedPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dateFilter1 = new PhotoViewer.DateFilter();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.controlPresenter1 = new DevExpress.Utils.Controls.ControlPresenter();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderPopupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.galleryItemMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.imageDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addToLibraryMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGallery)).BeginInit();
            this.mainGallery.SuspendLayout();
            this.libraryPanel.SuspendLayout();
            this.galleryContentPanel.SuspendLayout();
            this.galleryPanel.SuspendLayout();
            this.panelContainer1.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.controlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureEdit.Properties)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            this.controlPresenter1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.folderPopupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryItemMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // biAddFolder
            // 
            this.biAddFolder.Caption = "Add Folder";
            this.biAddFolder.Glyph = global::PhotoViewer.Properties.Resources.AddFolder_16x16;
            this.biAddFolder.Id = 9;
            this.biAddFolder.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.biAddFolder.LargeGlyph = global::PhotoViewer.Properties.Resources.AddFolder_32x32;
            this.biAddFolder.Name = "biAddFolder";
            this.biAddFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAddFolderItemClick);
            // 
            // biAddFile
            // 
            this.biAddFile.Caption = "Add File";
            this.biAddFile.Glyph = global::PhotoViewer.Properties.Resources.AddFile_16x16;
            this.biAddFile.Id = 10;
            this.biAddFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.biAddFile.LargeGlyph = global::PhotoViewer.Properties.Resources.AddFile_32x32;
            this.biAddFile.Name = "biAddFile";
            this.biAddFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAddFileClick);
            // 
            // biPrint
            // 
            this.biPrint.Caption = "Print";
            this.biPrint.Glyph = global::PhotoViewer.Properties.Resources.Print_16x16;
            this.biPrint.Hint = "Print selected images";
            this.biPrint.Id = 11;
            this.biPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.biPrint.LargeGlyph = global::PhotoViewer.Properties.Resources.Print_32x32;
            this.biPrint.Name = "biPrint";
            this.biPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPrintItemClick);
            // 
            // biExit
            // 
            this.biExit.Caption = "&Exit";
            this.biExit.Id = 12;
            this.biExit.Name = "biExit";
            // 
            // albumSubItem
            // 
            this.albumSubItem.Caption = "&Album";
            this.albumSubItem.Id = 18;
            this.albumSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.biNewAlbum),
            new DevExpress.XtraBars.LinkPersistInfo(this.biEditAlbum, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.biRemoveAlbum)});
            this.albumSubItem.Name = "albumSubItem";
            // 
            // biNewAlbum
            // 
            this.biNewAlbum.Caption = "&New Album...";
            this.biNewAlbum.Glyph = global::PhotoViewer.Properties.Resources.NewAlbum_16x16;
            this.biNewAlbum.Id = 8;
            this.biNewAlbum.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.biNewAlbum.LargeGlyph = global::PhotoViewer.Properties.Resources.NewAlbum_32x32;
            this.biNewAlbum.Name = "biNewAlbum";
            this.biNewAlbum.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnNewAlbumItemClick);
            // 
            // biEditAlbum
            // 
            this.biEditAlbum.Caption = "Edit Album";
            this.biEditAlbum.Glyph = global::PhotoViewer.Properties.Resources.Edit_16x16;
            this.biEditAlbum.Id = 17;
            this.biEditAlbum.LargeGlyph = global::PhotoViewer.Properties.Resources.Edit_32x32;
            this.biEditAlbum.Name = "biEditAlbum";
            this.biEditAlbum.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnEditAlbumItemClick);
            // 
            // biRemoveAlbum
            // 
            this.biRemoveAlbum.Caption = "Remove Album";
            this.biRemoveAlbum.Glyph = global::PhotoViewer.Properties.Resources.RemoveAlbum_16x16;
            this.biRemoveAlbum.Id = 14;
            this.biRemoveAlbum.LargeGlyph = global::PhotoViewer.Properties.Resources.RemoveAlbum_32x32;
            this.biRemoveAlbum.Name = "biRemoveAlbum";
            this.biRemoveAlbum.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRemoveAlbumItemClick);
            // 
            // bsView
            // 
            this.bsView.Caption = "&View";
            this.bsView.Id = 2;
            this.bsView.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.biView)});
            this.bsView.Name = "bsView";
            // 
            // biView
            // 
            this.biView.Caption = "View";
            this.biView.Glyph = global::PhotoViewer.Properties.Resources.View_16x16;
            this.biView.Hint = "View selected images";
            this.biView.Id = 19;
            this.biView.LargeGlyph = global::PhotoViewer.Properties.Resources.View_32x32;
            this.biView.Name = "biView";
            this.biView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnViewSelectedImagesItemClick);
            // 
            // bsTools
            // 
            this.bsTools.Caption = "&Tools";
            this.bsTools.Id = 3;
            this.bsTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bsSkins)});
            this.bsTools.Name = "bsTools";
            // 
            // bsSkins
            // 
            this.bsSkins.Caption = "&Skins";
            this.bsSkins.Id = 7;
            this.bsSkins.Name = "bsSkins";
            // 
            // bsHelp
            // 
            this.bsHelp.Caption = "&Help";
            this.bsHelp.Id = 5;
            this.bsHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.biAbout)});
            this.bsHelp.Name = "bsHelp";
            // 
            // biAbout
            // 
            this.biAbout.Caption = "&About";
            this.biAbout.Glyph = global::PhotoViewer.Properties.Resources.Help_16x16;
            this.biAbout.Id = 6;
            this.biAbout.LargeGlyph = global::PhotoViewer.Properties.Resources.Help_32x32;
            this.biAbout.Name = "biAbout";
            this.biAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAboutItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete Folder";
            this.barButtonItem2.Id = 13;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // biRemoveFolder
            // 
            this.biRemoveFolder.Caption = "Remove Folder";
            this.biRemoveFolder.Glyph = global::PhotoViewer.Properties.Resources.RemoveFolder_16x16;
            this.biRemoveFolder.Id = 15;
            this.biRemoveFolder.LargeGlyph = global::PhotoViewer.Properties.Resources.RemoveFolder_32x32;
            this.biRemoveFolder.Name = "biRemoveFolder";
            this.biRemoveFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRemoveFolderItemClick);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.albumGroup;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.albumGroup,
            this.foldersGroup,
            this.othersGroup});
            this.navBarControl1.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl;
            this.navBarControl1.Location = new System.Drawing.Point(6, 6);
            this.navBarControl1.MenuManager = this.ribbonControl1;
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 186;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.ribbonControl1.SetPopupContextMenu(this.navBarControl1, this.albumPopupMenu);
            this.navBarControl1.Size = new System.Drawing.Size(186, 582);
            this.navBarControl1.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar;
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.SelectedLinkChanged += new DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventHandler(this.OnNavBarControl1SelectedLinkChanged);
            this.navBarControl1.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl1_ActiveGroupChanged);
            this.navBarControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnNavBarControl1MouseDown);
            // 
            // albumGroup
            // 
            this.albumGroup.Caption = "Albums";
            this.albumGroup.Expanded = true;
            this.albumGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.albumGroup.LargeImage = global::PhotoViewer.Properties.Resources.Album_32x32;
            this.albumGroup.Name = "albumGroup";
            this.albumGroup.SmallImage = global::PhotoViewer.Properties.Resources.Album_16x16;
            // 
            // foldersGroup
            // 
            this.foldersGroup.Caption = "Folders";
            this.foldersGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.foldersGroup.LargeImage = global::PhotoViewer.Properties.Resources.Folder_32x32;
            this.foldersGroup.Name = "foldersGroup";
            this.foldersGroup.SmallImage = global::PhotoViewer.Properties.Resources.Folder_16x16;
            // 
            // othersGroup
            // 
            this.othersGroup.Caption = "Other";
            this.othersGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.othersGroup.LargeImage = global::PhotoViewer.Properties.Resources.Other_32x32;
            this.othersGroup.Name = "othersGroup";
            this.othersGroup.SmallImage = global::PhotoViewer.Properties.Resources.Other_16x16;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbonControl1.ItemPanelStyle = DevExpress.XtraBars.Ribbon.RibbonItemPanelStyle.Classic;
            this.ribbonControl1.ApplicationButtonText = null;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bsView,
            this.bsTools,
            this.bsHelp,
            this.biAbout,
            this.bsSkins,
            this.biNewAlbum,
            this.biAddFolder,
            this.biAddFile,
            this.biPrint,
            this.biExit,
            this.barButtonItem2,
            this.biRemoveAlbum,
            this.biRemoveFolder,
            this.biEditAlbum,
            this.albumSubItem,
            this.biView,
            this.skinGalleryBarItem,
            this.biExportFolder,
            this.biEmail,
            this.biUpload,
            this.biAddToLibrary,
            this.biRemoveFilesFromLibrary,
            this.biAddToAlbum,
            this.biMark,
            this.biUnmark,
            this.biUnmarkAll,
            this.biCollage,
            this.biSlideShow,
            this.biFilm,
            this.biSaveImage,
            this.biCancel,
            this.biClose,
            this.filtersGallery,
            this.biFilterByMarked,
            this.biGenerateData,
            this.biRemoveFromAlbum,
            this.biSelectAllMarked,
            this.beZoom,
            this.barButtonGroup1,
            this.barButtonGroup2,
            this.barButtonGroup3,
            this.barButtonGroup4,
            this.bBColorMix,
            this.barCheckItem1,
            this.bsAnimationType,
            this.bcAnimationNone,
            this.bcExpandAnimation,
            this.bcPushAnimation,
            this.bcSlideAnimation,
            this.bcSegmentedAnimation});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 34;
            this.ribbonControl1.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsTouch.ShowTouchUISelectorInQAT = true;
            this.ribbonControl1.OptionsTouch.ShowTouchUISelectorVisibilityItemInQATMenu = true;
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.viewPageCategory});
            this.ribbonControl1.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right;
            this.ribbonControl1.PageHeaderItemLinks.Add(this.biAbout);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.imagePage,
            this.folderPage,
            this.albumPage,
            this.viewPage});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemZoomTrackBar1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1114, 144);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.TransparentEditors = true;
            this.ribbonControl1.SelectedPageChanged += new System.EventHandler(this.OnRibbonControlSelectedPageChanged);
            // 
            // albumPopupMenu
            // 
            this.albumPopupMenu.ItemLinks.Add(this.biRemoveAlbum);
            this.albumPopupMenu.ItemLinks.Add(this.biEditAlbum);
            this.albumPopupMenu.Name = "albumPopupMenu";
            this.albumPopupMenu.Ribbon = this.ribbonControl1;
            this.albumPopupMenu.CloseUp += new System.EventHandler(this.OnAlbumPopupMenuCloseUp);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.BottomPaneControlContainer = this.popupControlContainer1;
            this.applicationMenu1.ItemLinks.Add(this.biNewAlbum);
            this.applicationMenu1.ItemLinks.Add(this.biAddFolder, true);
            this.applicationMenu1.ItemLinks.Add(this.biAddFile);
            this.applicationMenu1.ItemLinks.Add(this.biEmail, true);
            this.applicationMenu1.ItemLinks.Add(this.biPrint, true);
            this.applicationMenu1.ItemLinks.Add(this.biGenerateData, true);
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbonControl1;
            // 
            // popupControlContainer1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.popupControlContainer1, DevExpress.Utils.DefaultBoolean.Default);
            this.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.popupControlContainer1.Appearance.Options.UseBackColor = true;
            this.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.popupControlContainer1.Controls.Add(this.exitButton);
            this.popupControlContainer1.Location = new System.Drawing.Point(848, 58);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Ribbon = this.ribbonControl1;
            this.popupControlContainer1.Size = new System.Drawing.Size(68, 29);
            this.popupControlContainer1.TabIndex = 1;
            this.popupControlContainer1.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(3, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(61, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.OnExitButtonClick);
            // 
            // biEmail
            // 
            this.biEmail.Caption = "E-mail";
            this.biEmail.Glyph = global::PhotoViewer.Properties.Resources.EMail_16x16;
            this.biEmail.Hint = "Send selected images via e-mail";
            this.biEmail.Id = 3;
            this.biEmail.LargeGlyph = global::PhotoViewer.Properties.Resources.EMail_32x32;
            this.biEmail.Name = "biEmail";
            this.biEmail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnEmailItemClick);
            // 
            // biGenerateData
            // 
            this.biGenerateData.Caption = "Generate Data";
            this.biGenerateData.Glyph = global::PhotoViewer.Properties.Resources.GenerateData_16x16;
            this.biGenerateData.Hint = "This item allow you to generate default data for demo";
            this.biGenerateData.Id = 19;
            this.biGenerateData.LargeGlyph = global::PhotoViewer.Properties.Resources.GenerateData_32x32;
            this.biGenerateData.Name = "biGenerateData";
            this.biGenerateData.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnGenerateDataItemClick);
            // 
            // skinGalleryBarItem
            // 
            // 
            // 
            // 
            this.skinGalleryBarItem.Gallery.AllowHoverImages = true;
            this.skinGalleryBarItem.Gallery.FixedHoverImageSize = false;
            galleryItemGroup1.Caption = "Standard";
            galleryItemGroup2.Caption = "Bonus";
            galleryItemGroup2.Visible = false;
            galleryItemGroup3.Caption = "Office";
            galleryItemGroup3.Visible = false;
            this.skinGalleryBarItem.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1,
            galleryItemGroup2,
            galleryItemGroup3});
            this.skinGalleryBarItem.Gallery.ImageSize = new System.Drawing.Size(58, 43);
            this.skinGalleryBarItem.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio;
            this.skinGalleryBarItem.Id = 1;
            this.skinGalleryBarItem.Name = "skinGalleryBarItem";
            // 
            // biExportFolder
            // 
            this.biExportFolder.Caption = "Export";
            this.biExportFolder.Glyph = global::PhotoViewer.Properties.Resources.Export_16x16;
            this.biExportFolder.Hint = "Export folders content to hard drive";
            this.biExportFolder.Id = 2;
            this.biExportFolder.LargeGlyph = global::PhotoViewer.Properties.Resources.Export_32x32;
            this.biExportFolder.Name = "biExportFolder";
            this.biExportFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnExportItemClick);
            // 
            // biUpload
            // 
            this.biUpload.Caption = "Upload";
            this.biUpload.Glyph = global::PhotoViewer.Properties.Resources.Upload_16x16;
            this.biUpload.Hint = "Upload selected images to your web album";
            this.biUpload.Id = 4;
            this.biUpload.LargeGlyph = global::PhotoViewer.Properties.Resources.Upload_32x32;
            this.biUpload.Name = "biUpload";
            this.biUpload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnUploadItemClick);
            // 
            // biAddToLibrary
            // 
            this.biAddToLibrary.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.biAddToLibrary.Caption = "Add to Library";
            this.biAddToLibrary.DropDownControl = this.addToLibraryMenu;
            this.biAddToLibrary.Glyph = global::PhotoViewer.Properties.Resources.AddToLibrary_16x16;
            this.biAddToLibrary.Hint = "Add files or folder to library";
            this.biAddToLibrary.Id = 5;
            this.biAddToLibrary.LargeGlyph = global::PhotoViewer.Properties.Resources.AddToLibrary_32x32;
            this.biAddToLibrary.Name = "biAddToLibrary";
            this.biAddToLibrary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAddToLibraryItemClick);
            // 
            // addToLibraryMenu
            // 
            this.addToLibraryMenu.ItemLinks.Add(this.biAddFolder);
            this.addToLibraryMenu.ItemLinks.Add(this.biAddFile);
            this.addToLibraryMenu.Name = "addToLibraryMenu";
            this.addToLibraryMenu.Ribbon = this.ribbonControl1;
            // 
            // biRemoveFilesFromLibrary
            // 
            this.biRemoveFilesFromLibrary.Caption = "Remove";
            this.biRemoveFilesFromLibrary.Glyph = global::PhotoViewer.Properties.Resources.Remove_16x16;
            this.biRemoveFilesFromLibrary.Id = 6;
            this.biRemoveFilesFromLibrary.LargeGlyph = global::PhotoViewer.Properties.Resources.Remove_32x32;
            this.biRemoveFilesFromLibrary.Name = "biRemoveFilesFromLibrary";
            // 
            // biAddToAlbum
            // 
            this.biAddToAlbum.ActAsDropDown = true;
            this.biAddToAlbum.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.biAddToAlbum.Caption = "Add to album";
            this.biAddToAlbum.DropDownControl = this.albumsPopupMenu;
            this.biAddToAlbum.Glyph = global::PhotoViewer.Properties.Resources.AddToAlbum_16x16;
            this.biAddToAlbum.Hint = "Add selected images to album";
            this.biAddToAlbum.Id = 7;
            this.biAddToAlbum.LargeGlyph = global::PhotoViewer.Properties.Resources.AddToAlbum_32x32;
            this.biAddToAlbum.Name = "biAddToAlbum";
            this.biAddToAlbum.ItemPress += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAddToAlbumItemPress);
            // 
            // albumsPopupMenu
            // 
            this.albumsPopupMenu.Name = "albumsPopupMenu";
            this.albumsPopupMenu.Ribbon = this.ribbonControl1;
            // 
            // biMark
            // 
            this.biMark.Caption = "Mark All";
            this.biMark.Glyph = global::PhotoViewer.Properties.Resources.Mark_16x16;
            this.biMark.Id = 8;
            this.biMark.LargeGlyph = global::PhotoViewer.Properties.Resources.Mark_32x32;
            this.biMark.Name = "biMark";
            this.biMark.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnMarkItemClick);
            // 
            // biUnmark
            // 
            this.biUnmark.Caption = "Unmark";
            this.biUnmark.Glyph = global::PhotoViewer.Properties.Resources.Unmark_16x16;
            this.biUnmark.Id = 9;
            this.biUnmark.LargeGlyph = global::PhotoViewer.Properties.Resources.Unmark_32x32;
            this.biUnmark.Name = "biUnmark";
            this.biUnmark.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.biUnmark.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnUnmarkItemClick);
            // 
            // biUnmarkAll
            // 
            this.biUnmarkAll.Caption = "Unmark All";
            this.biUnmarkAll.Glyph = global::PhotoViewer.Properties.Resources.UnmarkAll_16x16;
            this.biUnmarkAll.Id = 10;
            this.biUnmarkAll.LargeGlyph = global::PhotoViewer.Properties.Resources.UnmarkAll_32x32;
            this.biUnmarkAll.Name = "biUnmarkAll";
            this.biUnmarkAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnUnmarkAllItemClick);
            // 
            // biCollage
            // 
            this.biCollage.Caption = "Collage";
            this.biCollage.Glyph = global::PhotoViewer.Properties.Resources.Collage_16x16;
            this.biCollage.Hint = "Make collage from using selected images";
            this.biCollage.Id = 11;
            this.biCollage.LargeGlyph = global::PhotoViewer.Properties.Resources.Collage_32x32;
            this.biCollage.Name = "biCollage";
            this.biCollage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnCollageItemClick);
            // 
            // biSlideShow
            // 
            this.biSlideShow.Caption = "Slide Show";
            this.biSlideShow.Glyph = global::PhotoViewer.Properties.Resources.Slideshow_16x16;
            this.biSlideShow.Hint = "Make slide show using selected images";
            this.biSlideShow.Id = 12;
            this.biSlideShow.LargeGlyph = global::PhotoViewer.Properties.Resources.Slideshow_32x32;
            this.biSlideShow.Name = "biSlideShow";
            this.biSlideShow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSlideShowItemClick);
            // 
            // biFilm
            // 
            this.biFilm.Caption = "Film";
            this.biFilm.Glyph = global::PhotoViewer.Properties.Resources.Film_16x16;
            this.biFilm.Hint = "Make film using selected images";
            this.biFilm.Id = 13;
            this.biFilm.LargeGlyph = global::PhotoViewer.Properties.Resources.Film_32x32;
            this.biFilm.Name = "biFilm";
            this.biFilm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnFilmItemClick);
            // 
            // biSaveImage
            // 
            this.biSaveImage.Caption = "Save";
            this.biSaveImage.Glyph = global::PhotoViewer.Properties.Resources.Save_16x16;
            this.biSaveImage.Id = 14;
            this.biSaveImage.LargeGlyph = global::PhotoViewer.Properties.Resources.Save_32x32;
            this.biSaveImage.Name = "biSaveImage";
            this.biSaveImage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSaveImageItemClick);
            // 
            // biCancel
            // 
            this.biCancel.Caption = "Cancel";
            this.biCancel.Glyph = global::PhotoViewer.Properties.Resources.Cancel_16x16;
            this.biCancel.Id = 15;
            this.biCancel.LargeGlyph = global::PhotoViewer.Properties.Resources.Cancel_32x32;
            this.biCancel.Name = "biCancel";
            this.biCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnCancelFilterItemClick);
            // 
            // biClose
            // 
            this.biClose.Caption = "Close";
            this.biClose.Glyph = global::PhotoViewer.Properties.Resources.Close_16x16;
            this.biClose.Id = 16;
            this.biClose.LargeGlyph = global::PhotoViewer.Properties.Resources.Close_32x32;
            this.biClose.Name = "biClose";
            this.biClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnCloseImageItemClick);
            // 
            // filtersGallery
            // 
            // 
            // 
            // 
            this.filtersGallery.Gallery.AllowHoverImages = true;
            galleryItemGroup4.Caption = "Group4";
            this.filtersGallery.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup4});
            this.filtersGallery.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio;
            this.filtersGallery.Gallery.InitDropDownGallery += new DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(this.OnFiltersGalleryInitDropDown);
            this.filtersGallery.Gallery.PopupClose += new DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(this.filtersGallery_Gallery_PopupClose);
            this.filtersGallery.Id = 17;
            this.filtersGallery.Name = "filtersGallery";
            this.filtersGallery.GalleryItemCheckedChanged += new DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(this.OnFilterGalleryItemCheckedChanged);
            // 
            // biFilterByMarked
            // 
            this.biFilterByMarked.Caption = "Filter by Marked";
            this.biFilterByMarked.Glyph = global::PhotoViewer.Properties.Resources.Filter_16x16;
            this.biFilterByMarked.Id = 18;
            this.biFilterByMarked.LargeGlyph = global::PhotoViewer.Properties.Resources.Filter_32x32;
            this.biFilterByMarked.Name = "biFilterByMarked";
            this.biFilterByMarked.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnFilterByMarkedCheckedChanged);
            // 
            // biRemoveFromAlbum
            // 
            this.biRemoveFromAlbum.Caption = "Remove from album";
            this.biRemoveFromAlbum.Glyph = global::PhotoViewer.Properties.Resources.RemoveFromAlbum_16x16;
            this.biRemoveFromAlbum.Id = 20;
            this.biRemoveFromAlbum.LargeGlyph = global::PhotoViewer.Properties.Resources.RemoveFromAlbum_32x32;
            this.biRemoveFromAlbum.Name = "biRemoveFromAlbum";
            this.biRemoveFromAlbum.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRemoveFromAlbumItemClick);
            // 
            // biSelectAllMarked
            // 
            this.biSelectAllMarked.Caption = "Select All Marked";
            this.biSelectAllMarked.Glyph = global::PhotoViewer.Properties.Resources.SelectAllMarked_16x16;
            this.biSelectAllMarked.Id = 21;
            this.biSelectAllMarked.LargeGlyph = global::PhotoViewer.Properties.Resources.SelectAllMarked_32x32;
            this.biSelectAllMarked.Name = "biSelectAllMarked";
            this.biSelectAllMarked.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSelectAllMarkedItemClick);
            // 
            // beZoom
            // 
            this.beZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.beZoom.Edit = this.repositoryItemZoomTrackBar1;
            this.beZoom.EditValue = 210;
            this.beZoom.Id = 22;
            this.beZoom.Name = "beZoom";
            this.beZoom.Width = 200;
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemZoomTrackBar1.AllowFocused = false;
            this.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemZoomTrackBar1.Maximum = 400;
            this.repositoryItemZoomTrackBar1.Middle = 5;
            this.repositoryItemZoomTrackBar1.Minimum = 50;
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            this.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight;
            this.repositoryItemZoomTrackBar1.ValueChanged += new System.EventHandler(this.repositoryItemZoomTrackBar1_ValueChanged);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.Id = 23;
            this.barButtonGroup1.ItemLinks.Add(this.biView);
            this.barButtonGroup1.ItemLinks.Add(this.biRemoveFilesFromLibrary);
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // barButtonGroup2
            // 
            this.barButtonGroup2.Caption = "barButtonGroup2";
            this.barButtonGroup2.Id = 24;
            this.barButtonGroup2.ItemLinks.Add(this.biAddToAlbum);
            this.barButtonGroup2.ItemLinks.Add(this.biRemoveFromAlbum);
            this.barButtonGroup2.Name = "barButtonGroup2";
            // 
            // barButtonGroup3
            // 
            this.barButtonGroup3.Caption = "barButtonGroup3";
            this.barButtonGroup3.Id = 25;
            this.barButtonGroup3.ItemLinks.Add(this.biMark);
            this.barButtonGroup3.ItemLinks.Add(this.biUnmark);
            this.barButtonGroup3.ItemLinks.Add(this.biUnmarkAll);
            this.barButtonGroup3.Name = "barButtonGroup3";
            // 
            // barButtonGroup4
            // 
            this.barButtonGroup4.Caption = "barButtonGroup4";
            this.barButtonGroup4.Id = 26;
            this.barButtonGroup4.ItemLinks.Add(this.biCollage);
            this.barButtonGroup4.ItemLinks.Add(this.biSlideShow);
            this.barButtonGroup4.ItemLinks.Add(this.biFilm);
            this.barButtonGroup4.Name = "barButtonGroup4";
            // 
            // bBColorMix
            // 
            this.bBColorMix.Caption = "Color Mix";
            this.bBColorMix.Glyph = global::PhotoViewer.Properties.Resources.ColorMixer_16x16;
            this.bBColorMix.Id = 27;
            this.bBColorMix.LargeGlyph = global::PhotoViewer.Properties.Resources.ColorMixer_32x32;
            this.bBColorMix.Name = "bBColorMix";
            this.bBColorMix.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bBColorMix_ItemClick);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "Random show";
            this.barCheckItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barCheckItem1.Checked = true;
            this.barCheckItem1.Id = 29;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem1_ItemClick);
            // 
            // bsAnimationType
            // 
            this.bsAnimationType.Caption = "Animation type";
            this.bsAnimationType.Id = 30;
            this.bsAnimationType.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bcAnimationNone),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcExpandAnimation),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcPushAnimation),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcSegmentedAnimation),
            new DevExpress.XtraBars.LinkPersistInfo(this.bcSlideAnimation)});
            this.bsAnimationType.Name = "bsAnimationType";
            // 
            // bcAnimationNone
            // 
            this.bcAnimationNone.Caption = "None";
            this.bcAnimationNone.GroupIndex = 4;
            this.bcAnimationNone.Id = 31;
            this.bcAnimationNone.Name = "bcAnimationNone";
            this.bcAnimationNone.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAnimationTypeChanged);
            // 
            // bcExpandAnimation
            // 
            this.bcExpandAnimation.Caption = "Expand";
            this.bcExpandAnimation.GroupIndex = 4;
            this.bcExpandAnimation.Id = 32;
            this.bcExpandAnimation.Name = "bcExpandAnimation";
            this.bcExpandAnimation.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAnimationTypeChanged);
            // 
            // bcPushAnimation
            // 
            this.bcPushAnimation.Caption = "Push";
            this.bcPushAnimation.Checked = true;
            this.bcPushAnimation.GroupIndex = 4;
            this.bcPushAnimation.Id = 33;
            this.bcPushAnimation.Name = "bcPushAnimation";
            this.bcPushAnimation.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAnimationTypeChanged);
            // 
            // bcSegmentedAnimation
            // 
            this.bcSegmentedAnimation.Caption = "Segmented fade";
            this.bcSegmentedAnimation.GroupIndex = 4;
            this.bcSegmentedAnimation.Id = 35;
            this.bcSegmentedAnimation.Name = "bcSegmentedAnimation";
            this.bcSegmentedAnimation.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAnimationTypeChanged);
            // 
            // bcSlideAnimation
            // 
            this.bcSlideAnimation.Caption = "Slide";
            this.bcSlideAnimation.GroupIndex = 4;
            this.bcSlideAnimation.Id = 34;
            this.bcSlideAnimation.Name = "bcSlideAnimation";
            this.bcSlideAnimation.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAnimationTypeChanged);
            // 
            // ribbonMiniToolbar1
            // 
            this.ribbonMiniToolbar1.Alignment = System.Drawing.ContentAlignment.TopRight;
            this.ribbonMiniToolbar1.ItemLinks.Add(this.barButtonGroup1);
            this.ribbonMiniToolbar1.ItemLinks.Add(this.barButtonGroup2);
            this.ribbonMiniToolbar1.ItemLinks.Add(this.barButtonGroup3);
            this.ribbonMiniToolbar1.ItemLinks.Add(this.barButtonGroup4);
            this.ribbonMiniToolbar1.ParentControl = this;
            // 
            // viewPageCategory
            // 
            this.viewPageCategory.Name = "viewPageCategory";
            this.viewPageCategory.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.collectionOriginalPage});
            this.viewPageCategory.Text = "View";
            this.viewPageCategory.Visible = false;
            // 
            // collectionOriginalPage
            // 
            this.collectionOriginalPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.filtersFilePageGroup,
            this.filtersPageGroup});
            this.collectionOriginalPage.Name = "collectionOriginalPage";
            this.collectionOriginalPage.Text = "Collection";
            this.collectionOriginalPage.Visible = false;
            // 
            // filtersFilePageGroup
            // 
            this.filtersFilePageGroup.ItemLinks.Add(this.biSaveImage);
            this.filtersFilePageGroup.ItemLinks.Add(this.biCancel);
            this.filtersFilePageGroup.ItemLinks.Add(this.biClose, true);
            this.filtersFilePageGroup.Name = "filtersFilePageGroup";
            this.filtersFilePageGroup.Text = "File";
            // 
            // filtersPageGroup
            // 
            this.filtersPageGroup.ItemLinks.Add(this.filtersGallery);
            this.filtersPageGroup.Name = "filtersPageGroup";
            this.filtersPageGroup.Text = "Filters";
            // 
            // imagePage
            // 
            this.imagePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.imageGeneralPageGroup,
            this.imageMarkingPageGroup,
            this.makePageGroup,
            this.outputPageGroup});
            this.imagePage.Name = "imagePage";
            this.imagePage.Text = "Image";
            // 
            // imageGeneralPageGroup
            // 
            this.imageGeneralPageGroup.ItemLinks.Add(this.biAddToLibrary);
            this.imageGeneralPageGroup.ItemLinks.Add(this.biView, true);
            this.imageGeneralPageGroup.ItemLinks.Add(this.biRemoveFilesFromLibrary);
            this.imageGeneralPageGroup.ItemLinks.Add(this.biAddToAlbum, true);
            this.imageGeneralPageGroup.ItemLinks.Add(this.biRemoveFromAlbum);
            this.imageGeneralPageGroup.Name = "imageGeneralPageGroup";
            this.imageGeneralPageGroup.ShowCaptionButton = false;
            this.imageGeneralPageGroup.Text = "General";
            // 
            // imageMarkingPageGroup
            // 
            this.imageMarkingPageGroup.ItemLinks.Add(this.biMark);
            this.imageMarkingPageGroup.ItemLinks.Add(this.biUnmark);
            this.imageMarkingPageGroup.ItemLinks.Add(this.biUnmarkAll);
            this.imageMarkingPageGroup.ItemLinks.Add(this.biFilterByMarked, true);
            this.imageMarkingPageGroup.ItemLinks.Add(this.biSelectAllMarked);
            this.imageMarkingPageGroup.Name = "imageMarkingPageGroup";
            this.imageMarkingPageGroup.ShowCaptionButton = false;
            this.imageMarkingPageGroup.Text = "Marking";
            // 
            // makePageGroup
            // 
            this.makePageGroup.ItemLinks.Add(this.biCollage);
            this.makePageGroup.ItemLinks.Add(this.biSlideShow);
            this.makePageGroup.ItemLinks.Add(this.biFilm);
            this.makePageGroup.Name = "makePageGroup";
            this.makePageGroup.ShowCaptionButton = false;
            this.makePageGroup.Text = "Make";
            // 
            // outputPageGroup
            // 
            this.outputPageGroup.ItemLinks.Add(this.biExportFolder);
            this.outputPageGroup.ItemLinks.Add(this.biEmail);
            this.outputPageGroup.ItemLinks.Add(this.biUpload);
            this.outputPageGroup.ItemLinks.Add(this.biPrint, true);
            this.outputPageGroup.Name = "outputPageGroup";
            this.outputPageGroup.ShowCaptionButton = false;
            this.outputPageGroup.Text = "Output";
            // 
            // folderPage
            // 
            this.folderPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.folderPageGroup});
            this.folderPage.Name = "folderPage";
            this.folderPage.Text = "Folder";
            // 
            // folderPageGroup
            // 
            this.folderPageGroup.ItemLinks.Add(this.biAddFolder);
            this.folderPageGroup.ItemLinks.Add(this.biAddFile);
            this.folderPageGroup.ItemLinks.Add(this.biRemoveFolder);
            this.folderPageGroup.Name = "folderPageGroup";
            this.folderPageGroup.ShowCaptionButton = false;
            this.folderPageGroup.Text = "General";
            // 
            // albumPage
            // 
            this.albumPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.albumPageGroup});
            this.albumPage.Name = "albumPage";
            this.albumPage.Text = "Album";
            // 
            // albumPageGroup
            // 
            this.albumPageGroup.ItemLinks.Add(this.biNewAlbum);
            this.albumPageGroup.ItemLinks.Add(this.biEditAlbum);
            this.albumPageGroup.ItemLinks.Add(this.biRemoveAlbum);
            this.albumPageGroup.Name = "albumPageGroup";
            this.albumPageGroup.ShowCaptionButton = false;
            this.albumPageGroup.Text = "General";
            // 
            // viewPage
            // 
            this.viewPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.skinsPageGroup,
            this.ribbonPageGroup4});
            this.viewPage.Name = "viewPage";
            this.viewPage.Text = "View";
            // 
            // skinsPageGroup
            // 
            this.skinsPageGroup.ItemLinks.Add(this.skinGalleryBarItem);
            this.skinsPageGroup.ItemLinks.Add(this.bBColorMix);
            this.skinsPageGroup.Name = "skinsPageGroup";
            this.skinsPageGroup.ShowCaptionButton = false;
            this.skinsPageGroup.Text = "Skins";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.bsAnimationType);
            this.ribbonPageGroup4.ItemLinks.Add(this.barCheckItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Options image load";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.beZoom);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 738);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1114, 31);
            // 
            // mainGallery
            // 
            this.mainGallery.Controls.Add(this.galleryControlClient1);
            this.mainGallery.DesignGalleryGroupIndex = 0;
            this.mainGallery.DesignGalleryItemIndex = 0;
            this.mainGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // galleryControlGallery1
            // 
            this.mainGallery.Gallery.AllowMarqueeSelection = true;
            this.mainGallery.Gallery.ClearSelectionOnClickEmptySpace = true;
            this.mainGallery.Gallery.ContextButtonOptions.BottomPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mainGallery.Gallery.ContextButtonOptions.BottomPanelPadding = new System.Windows.Forms.Padding(5);
            this.mainGallery.Gallery.ContextButtonOptions.TopPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mainGallery.Gallery.ContextButtonOptions.TopPanelPadding = new System.Windows.Forms.Padding(5);
            contextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.MiddleTop;
            contextButton1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton1.AppearanceHover.ForeColor = System.Drawing.Color.White;
            contextButton1.AppearanceHover.Options.UseForeColor = true;
            contextButton1.AppearanceNormal.ForeColor = System.Drawing.Color.Gainsboro;
            contextButton1.AppearanceNormal.Options.UseForeColor = true;
            contextButton1.Id = new System.Guid("ef256683-68b4-4f42-8152-a25dfc3f6513");
            contextButton1.Name = "itemInfo";
            contextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible;
            contextButton2.Alignment = DevExpress.Utils.ContextItemAlignment.TopFar;
            contextButton2.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton2.AppearanceHover.ForeColor = System.Drawing.Color.Gainsboro;
            contextButton2.AppearanceHover.Options.UseForeColor = true;
            contextButton2.AppearanceNormal.ForeColor = System.Drawing.Color.White;
            contextButton2.AppearanceNormal.Options.UseForeColor = true;
            contextButton2.Glyph = ((System.Drawing.Image)(resources.GetObject("contextButton2.Glyph")));
            contextButton2.Id = new System.Guid("8200a79a-62ac-419a-8e6d-a512a1dbedc8");
            contextButton2.Name = "itemRemove";
            contextButton3.Alignment = DevExpress.Utils.ContextItemAlignment.TopFar;
            contextButton3.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            contextButton3.AppearanceHover.ForeColor = System.Drawing.Color.Gainsboro;
            contextButton3.AppearanceHover.Options.UseForeColor = true;
            contextButton3.AppearanceNormal.ForeColor = System.Drawing.Color.White;
            contextButton3.AppearanceNormal.Options.UseForeColor = true;
            contextButton3.Glyph = ((System.Drawing.Image)(resources.GetObject("contextButton3.Glyph")));
            contextButton3.Id = new System.Guid("da28a8b1-d513-4fac-a7e8-c6e3f516e047");
            contextButton3.Name = "itemLocation";
            checkContextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.BottomNear;
            checkContextButton1.Id = new System.Guid("96356b6d-4ef9-466b-90e7-3889bd257758");
            checkContextButton1.Name = "itemCheck";
            checkContextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible;
            ratingContextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.MiddleBottom;
            ratingContextButton1.Id = new System.Guid("fc941a69-954d-4247-a4cb-eee0d430799e");
            ratingContextButton1.Name = "itemRating";
            ratingContextButton1.Rating = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mainGallery.Gallery.ContextButtons.Add(contextButton1);
            this.mainGallery.Gallery.ContextButtons.Add(contextButton2);
            this.mainGallery.Gallery.ContextButtons.Add(contextButton3);
            this.mainGallery.Gallery.ContextButtons.Add(checkContextButton1);
            this.mainGallery.Gallery.ContextButtons.Add(ratingContextButton1);
            this.mainGallery.Gallery.ImageSize = new System.Drawing.Size(210, 210);
            this.mainGallery.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple;
            this.mainGallery.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.mainGallery.Gallery.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Push;
            this.mainGallery.Gallery.OptionsImageLoad.AsyncLoad = true;
            this.mainGallery.Gallery.OptionsImageLoad.DesiredThumbnailSize = new System.Drawing.Size(208, 208);
            this.mainGallery.Gallery.ScrollMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryScrollMode.Smooth;
            this.mainGallery.Gallery.ScrollSpeed = 0.75F;
            this.mainGallery.Gallery.ContextButtonCustomize += new DevExpress.XtraBars.Ribbon.Gallery.GalleryContextButtonCustomizeEventHandler(this.OnMainGallery_ContextButtonCustomize);
            this.mainGallery.Gallery.ContextButtonClick += new DevExpress.Utils.ContextItemClickEventHandler(this.galleryControlGallery1_ContextButtonClick);
            this.mainGallery.Gallery.ItemDoubleClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.OnMainGalleryDoubleClick);
            this.mainGallery.Gallery.ItemCheckedChanged += new DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(this.OnMainGalleryItemCheckedChanged);
            this.mainGallery.Gallery.CustomDrawItemImage += new DevExpress.XtraBars.Ribbon.GalleryItemCustomDrawEventHandler(this.OnMainGalleryCustomDrawItemImage);
            this.mainGallery.Gallery.MarqueeSelectionCompleted += new DevExpress.XtraBars.Ribbon.GallerySelectionEventHandler(this.galleryControlGallery1_MarqueeSelectionCompleted);
            this.mainGallery.Gallery.GetThumbnailImage += new DevExpress.XtraBars.Ribbon.Gallery.GalleryThumbnailImageEventHandler(this.galleryControlGallery1_GetThumbnailImage);
            this.mainGallery.Location = new System.Drawing.Point(6, 0);
            this.mainGallery.Name = "mainGallery";
            this.mainGallery.Size = new System.Drawing.Size(573, 582);
            this.mainGallery.TabIndex = 0;
            this.mainGallery.Text = "galleryControl1";
            this.mainGallery.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMainGalleryMouseDown);
            // 
            // galleryControlClient1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.galleryControlClient1, DevExpress.Utils.DefaultBoolean.Default);
            this.galleryControlClient1.GalleryControl = this.mainGallery;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(552, 578);
            // 
            // defaultToolTipController1
            // 
            // 
            // 
            // 
            this.defaultToolTipController1.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            // 
            // printPreviewDialog1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.printPreviewDialog1, DevExpress.Utils.DefaultBoolean.Default);
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.UseAntiAlias = true;
            this.printPreviewDialog1.Visible = false;
            // 
            // libraryPanel
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.libraryPanel, DevExpress.Utils.DefaultBoolean.Default);
            this.libraryPanel.Controls.Add(this.galleryContentPanel);
            this.libraryPanel.Controls.Add(this.panelContainer1);
            this.libraryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryPanel.Location = new System.Drawing.Point(0, 0);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Size = new System.Drawing.Size(1114, 594);
            this.libraryPanel.TabIndex = 1;
            // 
            // galleryContentPanel
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.galleryContentPanel, DevExpress.Utils.DefaultBoolean.Default);
            this.galleryContentPanel.Controls.Add(this.galleryPanel);
            this.galleryContentPanel.Controls.Add(this.navBarControl1);
            this.galleryContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryContentPanel.Location = new System.Drawing.Point(0, 0);
            this.galleryContentPanel.Name = "galleryContentPanel";
            this.galleryContentPanel.Padding = new System.Windows.Forms.Padding(6);
            this.galleryContentPanel.Size = new System.Drawing.Size(777, 594);
            this.galleryContentPanel.TabIndex = 2;
            // 
            // galleryPanel
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.galleryPanel, DevExpress.Utils.DefaultBoolean.Default);
            this.galleryPanel.Controls.Add(this.mainGallery);
            this.galleryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.galleryPanel.Location = new System.Drawing.Point(192, 6);
            this.galleryPanel.Name = "galleryPanel";
            this.galleryPanel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.galleryPanel.Size = new System.Drawing.Size(579, 582);
            this.galleryPanel.TabIndex = 1;
            // 
            // panelContainer1
            // 
            this.panelContainer1.Controls.Add(this.dockPanel1);
            this.panelContainer1.Controls.Add(this.dockPanel2);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.panelContainer1.ID = new System.Guid("8218d2c3-3acd-4418-8cf7-e1b6091107a3");
            this.panelContainer1.Location = new System.Drawing.Point(777, 0);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(337, 200);
            this.panelContainer1.Size = new System.Drawing.Size(337, 594);
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.controlContainer1);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel1.ID = new System.Guid("1a5d040e-8d04-4f3d-bfd7-d81cb0934982");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(337, 252);
            this.dockPanel1.Size = new System.Drawing.Size(337, 250);
            this.dockPanel1.Text = "Preview";
            // 
            // controlContainer1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.controlContainer1, DevExpress.Utils.DefaultBoolean.Default);
            this.controlContainer1.Controls.Add(this.selectedPictureEdit);
            this.controlContainer1.Location = new System.Drawing.Point(4, 23);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(329, 223);
            this.controlContainer1.TabIndex = 0;
            // 
            // selectedPictureEdit
            // 
            this.selectedPictureEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectedPictureEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedPictureEdit.Location = new System.Drawing.Point(0, 0);
            this.selectedPictureEdit.MenuManager = this.ribbonControl1;
            this.selectedPictureEdit.Name = "selectedPictureEdit";
            this.selectedPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.selectedPictureEdit.Size = new System.Drawing.Size(329, 223);
            this.selectedPictureEdit.TabIndex = 0;
            this.selectedPictureEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel2.ID = new System.Guid("b921466f-3e4f-4a20-8f62-f73e3660d5d9");
            this.dockPanel2.Location = new System.Drawing.Point(0, 250);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(337, 347);
            this.dockPanel2.Size = new System.Drawing.Size(337, 344);
            this.dockPanel2.Text = "Date Filter";
            // 
            // dockPanel2_Container
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.dockPanel2_Container, DevExpress.Utils.DefaultBoolean.Default);
            this.dockPanel2_Container.Controls.Add(this.dateFilter1);
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(329, 317);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dateFilter1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.dateFilter1, DevExpress.Utils.DefaultBoolean.Default);
            this.dateFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFilter1.Location = new System.Drawing.Point(0, 0);
            this.dateFilter1.Name = "dateFilter1";
            this.dateFilter1.Size = new System.Drawing.Size(329, 317);
            this.dateFilter1.TabIndex = 0;
            this.dateFilter1.SelectionChanged += new System.EventHandler(this.OnDateFilterSelectionChanged);
            // 
            // dockPanel1_Container
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.dockPanel1_Container, DevExpress.Utils.DefaultBoolean.Default);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(238, 401);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // controlPresenter1
            // 
            this.defaultToolTipController1.SetAllowHtmlText(this.controlPresenter1, DevExpress.Utils.DefaultBoolean.Default);
            this.controlPresenter1.Controls.Add(this.libraryPanel);
            this.controlPresenter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPresenter1.Location = new System.Drawing.Point(0, 144);
            this.controlPresenter1.Name = "controlPresenter1";
            this.controlPresenter1.SelectedControl = this.libraryPanel;
            this.controlPresenter1.SelectedControlIndex = 0;
            this.controlPresenter1.Size = new System.Drawing.Size(1114, 594);
            this.controlPresenter1.TabIndex = 10;
            this.controlPresenter1.SelectedControlChanged += new System.EventHandler(this.OnMainTabSelectedPageChanged);
            // 
            // folderPopupMenu
            // 
            this.folderPopupMenu.ItemLinks.Add(this.biRemoveFolder);
            this.folderPopupMenu.Name = "folderPopupMenu";
            this.folderPopupMenu.Ribbon = this.ribbonControl1;
            // 
            // galleryItemMenu
            // 
            this.galleryItemMenu.Name = "galleryItemMenu";
            this.galleryItemMenu.Ribbon = this.ribbonControl1;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this.libraryPanel;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // imageDialog
            // 
            this.imageDialog.Filter = "Image files (BMP,JPG,PNG,GIF) |*.bmp;*.jpg;*.png;*.gif| All files|*.*";
            this.imageDialog.Multiselect = true;
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.defaultToolTipController1.SetAllowHtmlText(this, DevExpress.Utils.DefaultBoolean.Default);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 769);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.controlPresenter1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Photo Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupControlContainer1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addToLibraryMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainGallery)).EndInit();
            this.mainGallery.ResumeLayout(false);
            this.libraryPanel.ResumeLayout(false);
            this.galleryContentPanel.ResumeLayout(false);
            this.galleryPanel.ResumeLayout(false);
            this.panelContainer1.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.controlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedPictureEdit.Properties)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.controlPresenter1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.folderPopupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryItemMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarSubItem bsView;
        private DevExpress.XtraBars.BarSubItem bsTools;
        private DevExpress.XtraBars.BarSubItem bsHelp;
        private DevExpress.XtraBars.BarButtonItem biAbout;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup albumGroup;
        private DevExpress.XtraNavBar.NavBarGroup foldersGroup;
        private DevExpress.XtraNavBar.NavBarGroup othersGroup;
        private DevExpress.XtraBars.Ribbon.GalleryControl mainGallery;
        private DevExpress.XtraBars.BarSubItem bsSkins;
        private DevExpress.XtraBars.BarButtonItem biNewAlbum;
        private DevExpress.XtraBars.BarButtonItem biAddFolder;
        private DevExpress.XtraBars.BarButtonItem biAddFile;
        private DevExpress.XtraBars.BarButtonItem biPrint;
        private DevExpress.XtraBars.BarButtonItem biExit;
        private DevExpress.Utils.DefaultToolTipController defaultToolTipController1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraBars.PopupMenu albumPopupMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem biRemoveAlbum;
        private DevExpress.XtraBars.PopupMenu folderPopupMenu;
        private DevExpress.XtraBars.BarButtonItem biRemoveFolder;
        private DevExpress.XtraBars.PopupMenu albumsPopupMenu;
        private DevExpress.Utils.Controls.ControlPresenter controlPresenter1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private DevExpress.XtraBars.PopupMenu galleryItemMenu;
        private DevExpress.XtraBars.BarButtonItem biEditAlbum;
        private DevExpress.XtraBars.BarSubItem albumSubItem;
        private DevExpress.XtraBars.BarButtonItem biView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage imagePage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup imageGeneralPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup imageMarkingPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup makePageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup outputPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage folderPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory viewPageCategory;
        private DevExpress.XtraBars.Ribbon.RibbonPage collectionOriginalPage;
        private DevExpress.XtraBars.Ribbon.RibbonPage albumPage;
        private DevExpress.XtraBars.Ribbon.RibbonPage viewPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup folderPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup albumPageGroup;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.RibbonGalleryBarItem skinGalleryBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup skinsPageGroup;
        private DevExpress.XtraBars.PopupControlContainer popupControlContainer1;
        private DevExpress.XtraEditors.SimpleButton exitButton;
        private DevExpress.XtraBars.BarButtonItem biExportFolder;
        private DevExpress.XtraBars.BarButtonItem biEmail;
        private DevExpress.XtraBars.BarButtonItem biUpload;
        private DevExpress.XtraBars.BarButtonItem biAddToLibrary;
        private DevExpress.XtraBars.PopupMenu addToLibraryMenu;
        private DevExpress.XtraBars.BarButtonItem biRemoveFilesFromLibrary;
        private DevExpress.XtraBars.BarButtonItem biAddToAlbum;
        private DevExpress.XtraBars.BarButtonItem biMark;
        private DevExpress.XtraBars.BarButtonItem biUnmark;
        private DevExpress.XtraBars.BarButtonItem biUnmarkAll;
        private DevExpress.XtraBars.BarButtonItem biCollage;
        private DevExpress.XtraBars.BarButtonItem biSlideShow;
        private DevExpress.XtraBars.BarButtonItem biFilm;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private System.Windows.Forms.UserControl libraryPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PictureEdit selectedPictureEdit;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup filtersFilePageGroup;
        private DevExpress.XtraBars.BarButtonItem biSaveImage;
        private DevExpress.XtraBars.BarButtonItem biCancel;
        private DevExpress.XtraBars.BarButtonItem biClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup filtersPageGroup;
        private DevExpress.XtraBars.RibbonGalleryBarItem filtersGallery;
        private DevExpress.XtraBars.BarCheckItem biFilterByMarked;
        private DevExpress.XtraBars.BarButtonItem biGenerateData;
        private DevExpress.XtraBars.BarButtonItem biRemoveFromAlbum;
        private System.Windows.Forms.OpenFileDialog imageDialog;
        private DevExpress.XtraBars.BarButtonItem biSelectAllMarked;
        private DevExpress.XtraBars.BarEditItem beZoom;
        private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DateFilter dateFilter1;
        private System.Windows.Forms.Panel galleryContentPanel;
        private System.Windows.Forms.Panel galleryPanel;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup2;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup3;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.BarButtonItem bBColorMix;
        private DevExpress.XtraBars.BarSubItem bsAnimationType;
        private DevExpress.XtraBars.BarCheckItem bcAnimationNone;
        private DevExpress.XtraBars.BarCheckItem bcSlideAnimation;
        private DevExpress.XtraBars.BarCheckItem bcExpandAnimation;
        private DevExpress.XtraBars.BarCheckItem bcPushAnimation;
        private DevExpress.XtraBars.BarCheckItem bcSegmentedAnimation;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
    }
}

