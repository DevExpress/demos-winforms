Imports DevExpress.XtraTab

Namespace PhotoViewer

    Partial Class MainForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim galleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItemGroup2 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItemGroup3 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItemGroup4 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim contextButton1 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
            Dim contextButton2 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhotoViewer.MainForm))
            Dim contextButton3 As DevExpress.Utils.ContextButton = New DevExpress.Utils.ContextButton()
            Dim checkContextButton1 As DevExpress.Utils.CheckContextButton = New DevExpress.Utils.CheckContextButton()
            Dim ratingContextButton1 As DevExpress.Utils.RatingContextButton = New DevExpress.Utils.RatingContextButton()
            Me.biAddFolder = New DevExpress.XtraBars.BarButtonItem()
            Me.biAddFile = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrint = New DevExpress.XtraBars.BarButtonItem()
            Me.biExit = New DevExpress.XtraBars.BarButtonItem()
            Me.albumSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.biNewAlbum = New DevExpress.XtraBars.BarButtonItem()
            Me.biEditAlbum = New DevExpress.XtraBars.BarButtonItem()
            Me.biRemoveAlbum = New DevExpress.XtraBars.BarButtonItem()
            Me.bsView = New DevExpress.XtraBars.BarSubItem()
            Me.biView = New DevExpress.XtraBars.BarButtonItem()
            Me.bsTools = New DevExpress.XtraBars.BarSubItem()
            Me.bsSkins = New DevExpress.XtraBars.BarSubItem()
            Me.bsHelp = New DevExpress.XtraBars.BarSubItem()
            Me.biAbout = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.biRemoveFolder = New DevExpress.XtraBars.BarButtonItem()
            Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
            Me.albumGroup = New DevExpress.XtraNavBar.NavBarGroup()
            Me.foldersGroup = New DevExpress.XtraNavBar.NavBarGroup()
            Me.othersGroup = New DevExpress.XtraNavBar.NavBarGroup()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.albumPopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.applicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
            Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
            Me.exitButton = New DevExpress.XtraEditors.SimpleButton()
            Me.biEmail = New DevExpress.XtraBars.BarButtonItem()
            Me.biGenerateData = New DevExpress.XtraBars.BarButtonItem()
            Me.skinGalleryBarItem = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.biExportFolder = New DevExpress.XtraBars.BarButtonItem()
            Me.biUpload = New DevExpress.XtraBars.BarButtonItem()
            Me.biAddToLibrary = New DevExpress.XtraBars.BarButtonItem()
            Me.addToLibraryMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.biRemoveFilesFromLibrary = New DevExpress.XtraBars.BarButtonItem()
            Me.biAddToAlbum = New DevExpress.XtraBars.BarButtonItem()
            Me.albumsPopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.biMark = New DevExpress.XtraBars.BarButtonItem()
            Me.biUnmark = New DevExpress.XtraBars.BarButtonItem()
            Me.biUnmarkAll = New DevExpress.XtraBars.BarButtonItem()
            Me.biCollage = New DevExpress.XtraBars.BarButtonItem()
            Me.biSlideShow = New DevExpress.XtraBars.BarButtonItem()
            Me.biFilm = New DevExpress.XtraBars.BarButtonItem()
            Me.biSaveImage = New DevExpress.XtraBars.BarButtonItem()
            Me.biCancel = New DevExpress.XtraBars.BarButtonItem()
            Me.biClose = New DevExpress.XtraBars.BarButtonItem()
            Me.filtersGallery = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.biFilterByMarked = New DevExpress.XtraBars.BarCheckItem()
            Me.biRemoveFromAlbum = New DevExpress.XtraBars.BarButtonItem()
            Me.biSelectAllMarked = New DevExpress.XtraBars.BarButtonItem()
            Me.beZoom = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
            Me.bBColorMix = New DevExpress.XtraBars.BarButtonItem()
            Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.bsAnimationType = New DevExpress.XtraBars.BarSubItem()
            Me.bcAnimationNone = New DevExpress.XtraBars.BarCheckItem()
            Me.bcExpandAnimation = New DevExpress.XtraBars.BarCheckItem()
            Me.bcPushAnimation = New DevExpress.XtraBars.BarCheckItem()
            Me.bcSegmentedAnimation = New DevExpress.XtraBars.BarCheckItem()
            Me.bcSlideAnimation = New DevExpress.XtraBars.BarCheckItem()
            Me.ribbonMiniToolbar1 = New DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(Me.components)
            Me.viewPageCategory = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
            Me.collectionOriginalPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.filtersFilePageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.filtersPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.imagePage = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.imageGeneralPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.imageMarkingPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.makePageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.outputPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.folderPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.folderPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.albumPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.albumPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.viewPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.skinsPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.mainGallery = New DevExpress.XtraBars.Ribbon.GalleryControl()
            Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
            Me.defaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
            Me.printPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
            Me.libraryPanel = New System.Windows.Forms.UserControl()
            Me.galleryContentPanel = New System.Windows.Forms.Panel()
            Me.galleryPanel = New System.Windows.Forms.Panel()
            Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.controlContainer1 = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.selectedPictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.dateFilter1 = New PhotoViewer.DateFilter()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.controlPresenter1 = New DevExpress.Utils.Controls.ControlPresenter()
            Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
            Me.folderPopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.galleryItemMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.imageDialog = New System.Windows.Forms.OpenFileDialog()
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.albumPopupMenu), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.applicationMenu1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupControlContainer1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer1.SuspendLayout()
            CType((Me.addToLibraryMenu), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.albumsPopupMenu), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemZoomTrackBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mainGallery), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainGallery.SuspendLayout()
            Me.libraryPanel.SuspendLayout()
            Me.galleryContentPanel.SuspendLayout()
            Me.galleryPanel.SuspendLayout()
            Me.panelContainer1.SuspendLayout()
            Me.dockPanel1.SuspendLayout()
            Me.controlContainer1.SuspendLayout()
            CType((Me.selectedPictureEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            Me.controlPresenter1.SuspendLayout()
            CType((Me.folderPopupMenu), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.galleryItemMenu), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' biAddFolder
            ' 
            Me.biAddFolder.Caption = "Add Folder"
            Me.biAddFolder.Glyph = Global.PhotoViewer.Properties.Resources.AddFolder_16x16
            Me.biAddFolder.Id = 9
            Me.biAddFolder.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F))
            Me.biAddFolder.LargeGlyph = Global.PhotoViewer.Properties.Resources.AddFolder_32x32
            Me.biAddFolder.Name = "biAddFolder"
            AddHandler Me.biAddFolder.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnAddFolderItemClick)
            ' 
            ' biAddFile
            ' 
            Me.biAddFile.Caption = "Add File"
            Me.biAddFile.Glyph = Global.PhotoViewer.Properties.Resources.AddFile_16x16
            Me.biAddFile.Id = 10
            Me.biAddFile.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O))
            Me.biAddFile.LargeGlyph = Global.PhotoViewer.Properties.Resources.AddFile_32x32
            Me.biAddFile.Name = "biAddFile"
            AddHandler Me.biAddFile.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnAddFileClick)
            ' 
            ' biPrint
            ' 
            Me.biPrint.Caption = "Print"
            Me.biPrint.Glyph = Global.PhotoViewer.Properties.Resources.Print_16x16
            Me.biPrint.Hint = "Print selected images"
            Me.biPrint.Id = 11
            Me.biPrint.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P))
            Me.biPrint.LargeGlyph = Global.PhotoViewer.Properties.Resources.Print_32x32
            Me.biPrint.Name = "biPrint"
            AddHandler Me.biPrint.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnPrintItemClick)
            ' 
            ' biExit
            ' 
            Me.biExit.Caption = "&Exit"
            Me.biExit.Id = 12
            Me.biExit.Name = "biExit"
            ' 
            ' albumSubItem
            ' 
            Me.albumSubItem.Caption = "&Album"
            Me.albumSubItem.Id = 18
            Me.albumSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.biNewAlbum), New DevExpress.XtraBars.LinkPersistInfo(Me.biEditAlbum, True), New DevExpress.XtraBars.LinkPersistInfo(Me.biRemoveAlbum)})
            Me.albumSubItem.Name = "albumSubItem"
            ' 
            ' biNewAlbum
            ' 
            Me.biNewAlbum.Caption = "&New Album..."
            Me.biNewAlbum.Glyph = Global.PhotoViewer.Properties.Resources.NewAlbum_16x16
            Me.biNewAlbum.Id = 8
            Me.biNewAlbum.ItemShortcut = New DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N))
            Me.biNewAlbum.LargeGlyph = Global.PhotoViewer.Properties.Resources.NewAlbum_32x32
            Me.biNewAlbum.Name = "biNewAlbum"
            AddHandler Me.biNewAlbum.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnNewAlbumItemClick)
            ' 
            ' biEditAlbum
            ' 
            Me.biEditAlbum.Caption = "Edit Album"
            Me.biEditAlbum.Glyph = Global.PhotoViewer.Properties.Resources.Edit_16x16
            Me.biEditAlbum.Id = 17
            Me.biEditAlbum.LargeGlyph = Global.PhotoViewer.Properties.Resources.Edit_32x32
            Me.biEditAlbum.Name = "biEditAlbum"
            AddHandler Me.biEditAlbum.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnEditAlbumItemClick)
            ' 
            ' biRemoveAlbum
            ' 
            Me.biRemoveAlbum.Caption = "Remove Album"
            Me.biRemoveAlbum.Glyph = Global.PhotoViewer.Properties.Resources.RemoveAlbum_16x16
            Me.biRemoveAlbum.Id = 14
            Me.biRemoveAlbum.LargeGlyph = Global.PhotoViewer.Properties.Resources.RemoveAlbum_32x32
            Me.biRemoveAlbum.Name = "biRemoveAlbum"
            AddHandler Me.biRemoveAlbum.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnRemoveAlbumItemClick)
            ' 
            ' bsView
            ' 
            Me.bsView.Caption = "&View"
            Me.bsView.Id = 2
            Me.bsView.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.biView)})
            Me.bsView.Name = "bsView"
            ' 
            ' biView
            ' 
            Me.biView.Caption = "View"
            Me.biView.Glyph = Global.PhotoViewer.Properties.Resources.View_16x16
            Me.biView.Hint = "View selected images"
            Me.biView.Id = 19
            Me.biView.LargeGlyph = Global.PhotoViewer.Properties.Resources.View_32x32
            Me.biView.Name = "biView"
            AddHandler Me.biView.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnViewSelectedImagesItemClick)
            ' 
            ' bsTools
            ' 
            Me.bsTools.Caption = "&Tools"
            Me.bsTools.Id = 3
            Me.bsTools.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bsSkins)})
            Me.bsTools.Name = "bsTools"
            ' 
            ' bsSkins
            ' 
            Me.bsSkins.Caption = "&Skins"
            Me.bsSkins.Id = 7
            Me.bsSkins.Name = "bsSkins"
            ' 
            ' bsHelp
            ' 
            Me.bsHelp.Caption = "&Help"
            Me.bsHelp.Id = 5
            Me.bsHelp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.biAbout)})
            Me.bsHelp.Name = "bsHelp"
            ' 
            ' biAbout
            ' 
            Me.biAbout.Caption = "&About"
            Me.biAbout.Glyph = Global.PhotoViewer.Properties.Resources.Help_16x16
            Me.biAbout.Id = 6
            Me.biAbout.LargeGlyph = Global.PhotoViewer.Properties.Resources.Help_32x32
            Me.biAbout.Name = "biAbout"
            AddHandler Me.biAbout.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnAboutItemClick)
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "Delete Folder"
            Me.barButtonItem2.Id = 13
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' biRemoveFolder
            ' 
            Me.biRemoveFolder.Caption = "Remove Folder"
            Me.biRemoveFolder.Glyph = Global.PhotoViewer.Properties.Resources.RemoveFolder_16x16
            Me.biRemoveFolder.Id = 15
            Me.biRemoveFolder.LargeGlyph = Global.PhotoViewer.Properties.Resources.RemoveFolder_32x32
            Me.biRemoveFolder.Name = "biRemoveFolder"
            AddHandler Me.biRemoveFolder.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnRemoveFolderItemClick)
            ' 
            ' navBarControl1
            ' 
            Me.navBarControl1.ActiveGroup = Me.albumGroup
            Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.navBarControl1.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.albumGroup, Me.foldersGroup, Me.othersGroup})
            Me.navBarControl1.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl
            Me.navBarControl1.Location = New System.Drawing.Point(6, 6)
            Me.navBarControl1.MenuManager = Me.ribbonControl1
            Me.navBarControl1.Name = "navBarControl1"
            Me.navBarControl1.OptionsNavPane.ExpandedWidth = 186
            Me.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
            Me.ribbonControl1.SetPopupContextMenu(Me.navBarControl1, Me.albumPopupMenu)
            Me.navBarControl1.Size = New System.Drawing.Size(186, 582)
            Me.navBarControl1.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar
            Me.navBarControl1.TabIndex = 0
            Me.navBarControl1.Text = "navBarControl1"
            AddHandler Me.navBarControl1.SelectedLinkChanged, New DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventHandler(AddressOf Me.OnNavBarControl1SelectedLinkChanged)
            AddHandler Me.navBarControl1.ActiveGroupChanged, New DevExpress.XtraNavBar.NavBarGroupEventHandler(AddressOf Me.navBarControl1_ActiveGroupChanged)
            AddHandler Me.navBarControl1.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnNavBarControl1MouseDown)
            ' 
            ' albumGroup
            ' 
            Me.albumGroup.Caption = "Albums"
            Me.albumGroup.Expanded = True
            Me.albumGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.albumGroup.LargeImage = Global.PhotoViewer.Properties.Resources.Album_32x32
            Me.albumGroup.Name = "albumGroup"
            Me.albumGroup.SmallImage = Global.PhotoViewer.Properties.Resources.Album_16x16
            ' 
            ' foldersGroup
            ' 
            Me.foldersGroup.Caption = "Folders"
            Me.foldersGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.foldersGroup.LargeImage = Global.PhotoViewer.Properties.Resources.Folder_32x32
            Me.foldersGroup.Name = "foldersGroup"
            Me.foldersGroup.SmallImage = Global.PhotoViewer.Properties.Resources.Folder_16x16
            ' 
            ' othersGroup
            ' 
            Me.othersGroup.Caption = "Other"
            Me.othersGroup.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.othersGroup.LargeImage = Global.PhotoViewer.Properties.Resources.Other_32x32
            Me.othersGroup.Name = "othersGroup"
            Me.othersGroup.SmallImage = Global.PhotoViewer.Properties.Resources.Other_16x16
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ApplicationButtonDropDownControl = Me.applicationMenu1
            Me.ribbonControl1.ItemPanelStyle = DevExpress.XtraBars.Ribbon.RibbonItemPanelStyle.Classic
            Me.ribbonControl1.ApplicationButtonText = Nothing
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.bsView, Me.bsTools, Me.bsHelp, Me.biAbout, Me.bsSkins, Me.biNewAlbum, Me.biAddFolder, Me.biAddFile, Me.biPrint, Me.biExit, Me.barButtonItem2, Me.biRemoveAlbum, Me.biRemoveFolder, Me.biEditAlbum, Me.albumSubItem, Me.biView, Me.skinGalleryBarItem, Me.biExportFolder, Me.biEmail, Me.biUpload, Me.biAddToLibrary, Me.biRemoveFilesFromLibrary, Me.biAddToAlbum, Me.biMark, Me.biUnmark, Me.biUnmarkAll, Me.biCollage, Me.biSlideShow, Me.biFilm, Me.biSaveImage, Me.biCancel, Me.biClose, Me.filtersGallery, Me.biFilterByMarked, Me.biGenerateData, Me.biRemoveFromAlbum, Me.biSelectAllMarked, Me.beZoom, Me.barButtonGroup1, Me.barButtonGroup2, Me.barButtonGroup3, Me.barButtonGroup4, Me.bBColorMix, Me.barCheckItem1, Me.bsAnimationType, Me.bcAnimationNone, Me.bcExpandAnimation, Me.bcPushAnimation, Me.bcSlideAnimation, Me.bcSegmentedAnimation})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 34
            Me.ribbonControl1.MiniToolbars.Add(Me.ribbonMiniToolbar1)
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.OptionsTouch.ShowTouchUISelectorInQAT = True
            Me.ribbonControl1.OptionsTouch.ShowTouchUISelectorVisibilityItemInQATMenu = True
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.viewPageCategory})
            Me.ribbonControl1.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right
            Me.ribbonControl1.PageHeaderItemLinks.Add(Me.biAbout)
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.imagePage, Me.folderPage, Me.albumPage, Me.viewPage})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemZoomTrackBar1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
            Me.ribbonControl1.Size = New System.Drawing.Size(1114, 144)
            Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
            Me.ribbonControl1.TransparentEditors = True
            AddHandler Me.ribbonControl1.SelectedPageChanged, New System.EventHandler(AddressOf Me.OnRibbonControlSelectedPageChanged)
            ' 
            ' albumPopupMenu
            ' 
            Me.albumPopupMenu.ItemLinks.Add(Me.biRemoveAlbum)
            Me.albumPopupMenu.ItemLinks.Add(Me.biEditAlbum)
            Me.albumPopupMenu.Name = "albumPopupMenu"
            Me.albumPopupMenu.Ribbon = Me.ribbonControl1
            AddHandler Me.albumPopupMenu.CloseUp, New System.EventHandler(AddressOf Me.OnAlbumPopupMenuCloseUp)
            ' 
            ' applicationMenu1
            ' 
            Me.applicationMenu1.BottomPaneControlContainer = Me.popupControlContainer1
            Me.applicationMenu1.ItemLinks.Add(Me.biNewAlbum)
            Me.applicationMenu1.ItemLinks.Add(Me.biAddFolder, True)
            Me.applicationMenu1.ItemLinks.Add(Me.biAddFile)
            Me.applicationMenu1.ItemLinks.Add(Me.biEmail, True)
            Me.applicationMenu1.ItemLinks.Add(Me.biPrint, True)
            Me.applicationMenu1.ItemLinks.Add(Me.biGenerateData, True)
            Me.applicationMenu1.Name = "applicationMenu1"
            Me.applicationMenu1.Ribbon = Me.ribbonControl1
            ' 
            ' popupControlContainer1
            ' 
            Me.defaultToolTipController1.SetAllowHtmlText(Me.popupControlContainer1, DevExpress.Utils.DefaultBoolean.[Default])
            Me.popupControlContainer1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.popupControlContainer1.Appearance.Options.UseBackColor = True
            Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.popupControlContainer1.Controls.Add(Me.exitButton)
            Me.popupControlContainer1.Location = New System.Drawing.Point(848, 58)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.Ribbon = Me.ribbonControl1
            Me.popupControlContainer1.Size = New System.Drawing.Size(68, 29)
            Me.popupControlContainer1.TabIndex = 1
            Me.popupControlContainer1.Visible = False
            ' 
            ' exitButton
            ' 
            Me.exitButton.Location = New System.Drawing.Point(3, 3)
            Me.exitButton.Name = "exitButton"
            Me.exitButton.Size = New System.Drawing.Size(61, 23)
            Me.exitButton.TabIndex = 0
            Me.exitButton.Text = "Exit"
            AddHandler Me.exitButton.Click, New System.EventHandler(AddressOf Me.OnExitButtonClick)
            ' 
            ' biEmail
            ' 
            Me.biEmail.Caption = "E-mail"
            Me.biEmail.Glyph = Global.PhotoViewer.Properties.Resources.EMail_16x16
            Me.biEmail.Hint = "Send selected images via e-mail"
            Me.biEmail.Id = 3
            Me.biEmail.LargeGlyph = Global.PhotoViewer.Properties.Resources.EMail_32x32
            Me.biEmail.Name = "biEmail"
            AddHandler Me.biEmail.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnEmailItemClick)
            ' 
            ' biGenerateData
            ' 
            Me.biGenerateData.Caption = "Generate Data"
            Me.biGenerateData.Glyph = Global.PhotoViewer.Properties.Resources.GenerateData_16x16
            Me.biGenerateData.Hint = "This item allow you to generate default data for demo"
            Me.biGenerateData.Id = 19
            Me.biGenerateData.LargeGlyph = Global.PhotoViewer.Properties.Resources.GenerateData_32x32
            Me.biGenerateData.Name = "biGenerateData"
            AddHandler Me.biGenerateData.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnGenerateDataItemClick)
            ' 
            ' skinGalleryBarItem
            ' 
            ' 
            ' 
            ' 
            Me.skinGalleryBarItem.Gallery.AllowHoverImages = True
            Me.skinGalleryBarItem.Gallery.FixedHoverImageSize = False
            galleryItemGroup1.Caption = "Standard"
            galleryItemGroup2.Caption = "Bonus"
            galleryItemGroup2.Visible = False
            galleryItemGroup3.Caption = "Office"
            galleryItemGroup3.Visible = False
            Me.skinGalleryBarItem.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup1, galleryItemGroup2, galleryItemGroup3})
            Me.skinGalleryBarItem.Gallery.ImageSize = New System.Drawing.Size(58, 43)
            Me.skinGalleryBarItem.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
            Me.skinGalleryBarItem.Id = 1
            Me.skinGalleryBarItem.Name = "skinGalleryBarItem"
            ' 
            ' biExportFolder
            ' 
            Me.biExportFolder.Caption = "Export"
            Me.biExportFolder.Glyph = Global.PhotoViewer.Properties.Resources.Export_16x16
            Me.biExportFolder.Hint = "Export folders content to hard drive"
            Me.biExportFolder.Id = 2
            Me.biExportFolder.LargeGlyph = Global.PhotoViewer.Properties.Resources.Export_32x32
            Me.biExportFolder.Name = "biExportFolder"
            AddHandler Me.biExportFolder.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnExportItemClick)
            ' 
            ' biUpload
            ' 
            Me.biUpload.Caption = "Upload"
            Me.biUpload.Glyph = Global.PhotoViewer.Properties.Resources.Upload_16x16
            Me.biUpload.Hint = "Upload selected images to your web album"
            Me.biUpload.Id = 4
            Me.biUpload.LargeGlyph = Global.PhotoViewer.Properties.Resources.Upload_32x32
            Me.biUpload.Name = "biUpload"
            AddHandler Me.biUpload.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnUploadItemClick)
            ' 
            ' biAddToLibrary
            ' 
            Me.biAddToLibrary.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.biAddToLibrary.Caption = "Add to Library"
            Me.biAddToLibrary.DropDownControl = Me.addToLibraryMenu
            Me.biAddToLibrary.Glyph = Global.PhotoViewer.Properties.Resources.AddToLibrary_16x16
            Me.biAddToLibrary.Hint = "Add files or folder to library"
            Me.biAddToLibrary.Id = 5
            Me.biAddToLibrary.LargeGlyph = Global.PhotoViewer.Properties.Resources.AddToLibrary_32x32
            Me.biAddToLibrary.Name = "biAddToLibrary"
            AddHandler Me.biAddToLibrary.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnAddToLibraryItemClick)
            ' 
            ' addToLibraryMenu
            ' 
            Me.addToLibraryMenu.ItemLinks.Add(Me.biAddFolder)
            Me.addToLibraryMenu.ItemLinks.Add(Me.biAddFile)
            Me.addToLibraryMenu.Name = "addToLibraryMenu"
            Me.addToLibraryMenu.Ribbon = Me.ribbonControl1
            ' 
            ' biRemoveFilesFromLibrary
            ' 
            Me.biRemoveFilesFromLibrary.Caption = "Remove"
            Me.biRemoveFilesFromLibrary.Glyph = Global.PhotoViewer.Properties.Resources.Remove_16x16
            Me.biRemoveFilesFromLibrary.Id = 6
            Me.biRemoveFilesFromLibrary.LargeGlyph = Global.PhotoViewer.Properties.Resources.Remove_32x32
            Me.biRemoveFilesFromLibrary.Name = "biRemoveFilesFromLibrary"
            ' 
            ' biAddToAlbum
            ' 
            Me.biAddToAlbum.ActAsDropDown = True
            Me.biAddToAlbum.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.biAddToAlbum.Caption = "Add to album"
            Me.biAddToAlbum.DropDownControl = Me.albumsPopupMenu
            Me.biAddToAlbum.Glyph = Global.PhotoViewer.Properties.Resources.AddToAlbum_16x16
            Me.biAddToAlbum.Hint = "Add selected images to album"
            Me.biAddToAlbum.Id = 7
            Me.biAddToAlbum.LargeGlyph = Global.PhotoViewer.Properties.Resources.AddToAlbum_32x32
            Me.biAddToAlbum.Name = "biAddToAlbum"
            AddHandler Me.biAddToAlbum.ItemPress, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnAddToAlbumItemPress)
            ' 
            ' albumsPopupMenu
            ' 
            Me.albumsPopupMenu.Name = "albumsPopupMenu"
            Me.albumsPopupMenu.Ribbon = Me.ribbonControl1
            ' 
            ' biMark
            ' 
            Me.biMark.Caption = "Mark All"
            Me.biMark.Glyph = Global.PhotoViewer.Properties.Resources.Mark_16x16
            Me.biMark.Id = 8
            Me.biMark.LargeGlyph = Global.PhotoViewer.Properties.Resources.Mark_32x32
            Me.biMark.Name = "biMark"
            AddHandler Me.biMark.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnMarkItemClick)
            ' 
            ' biUnmark
            ' 
            Me.biUnmark.Caption = "Unmark"
            Me.biUnmark.Glyph = Global.PhotoViewer.Properties.Resources.Unmark_16x16
            Me.biUnmark.Id = 9
            Me.biUnmark.LargeGlyph = Global.PhotoViewer.Properties.Resources.Unmark_32x32
            Me.biUnmark.Name = "biUnmark"
            Me.biUnmark.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            AddHandler Me.biUnmark.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnUnmarkItemClick)
            ' 
            ' biUnmarkAll
            ' 
            Me.biUnmarkAll.Caption = "Unmark All"
            Me.biUnmarkAll.Glyph = Global.PhotoViewer.Properties.Resources.UnmarkAll_16x16
            Me.biUnmarkAll.Id = 10
            Me.biUnmarkAll.LargeGlyph = Global.PhotoViewer.Properties.Resources.UnmarkAll_32x32
            Me.biUnmarkAll.Name = "biUnmarkAll"
            AddHandler Me.biUnmarkAll.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnUnmarkAllItemClick)
            ' 
            ' biCollage
            ' 
            Me.biCollage.Caption = "Collage"
            Me.biCollage.Glyph = Global.PhotoViewer.Properties.Resources.Collage_16x16
            Me.biCollage.Hint = "Make collage from using selected images"
            Me.biCollage.Id = 11
            Me.biCollage.LargeGlyph = Global.PhotoViewer.Properties.Resources.Collage_32x32
            Me.biCollage.Name = "biCollage"
            AddHandler Me.biCollage.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnCollageItemClick)
            ' 
            ' biSlideShow
            ' 
            Me.biSlideShow.Caption = "Slide Show"
            Me.biSlideShow.Glyph = Global.PhotoViewer.Properties.Resources.Slideshow_16x16
            Me.biSlideShow.Hint = "Make slide show using selected images"
            Me.biSlideShow.Id = 12
            Me.biSlideShow.LargeGlyph = Global.PhotoViewer.Properties.Resources.Slideshow_32x32
            Me.biSlideShow.Name = "biSlideShow"
            AddHandler Me.biSlideShow.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnSlideShowItemClick)
            ' 
            ' biFilm
            ' 
            Me.biFilm.Caption = "Film"
            Me.biFilm.Glyph = Global.PhotoViewer.Properties.Resources.Film_16x16
            Me.biFilm.Hint = "Make film using selected images"
            Me.biFilm.Id = 13
            Me.biFilm.LargeGlyph = Global.PhotoViewer.Properties.Resources.Film_32x32
            Me.biFilm.Name = "biFilm"
            AddHandler Me.biFilm.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnFilmItemClick)
            ' 
            ' biSaveImage
            ' 
            Me.biSaveImage.Caption = "Save"
            Me.biSaveImage.Glyph = Global.PhotoViewer.Properties.Resources.Save_16x16
            Me.biSaveImage.Id = 14
            Me.biSaveImage.LargeGlyph = Global.PhotoViewer.Properties.Resources.Save_32x32
            Me.biSaveImage.Name = "biSaveImage"
            AddHandler Me.biSaveImage.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnSaveImageItemClick)
            ' 
            ' biCancel
            ' 
            Me.biCancel.Caption = "Cancel"
            Me.biCancel.Glyph = Global.PhotoViewer.Properties.Resources.Cancel_16x16
            Me.biCancel.Id = 15
            Me.biCancel.LargeGlyph = Global.PhotoViewer.Properties.Resources.Cancel_32x32
            Me.biCancel.Name = "biCancel"
            AddHandler Me.biCancel.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnCancelFilterItemClick)
            ' 
            ' biClose
            ' 
            Me.biClose.Caption = "Close"
            Me.biClose.Glyph = Global.PhotoViewer.Properties.Resources.Close_16x16
            Me.biClose.Id = 16
            Me.biClose.LargeGlyph = Global.PhotoViewer.Properties.Resources.Close_32x32
            Me.biClose.Name = "biClose"
            AddHandler Me.biClose.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnCloseImageItemClick)
            ' 
            ' filtersGallery
            ' 
            ' 
            ' 
            ' 
            Me.filtersGallery.Gallery.AllowHoverImages = True
            galleryItemGroup4.Caption = "Group4"
            Me.filtersGallery.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup4})
            Me.filtersGallery.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
            AddHandler Me.filtersGallery.Gallery.InitDropDownGallery, New DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(AddressOf Me.OnFiltersGalleryInitDropDown)
            AddHandler Me.filtersGallery.Gallery.PopupClose, New DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(AddressOf Me.filtersGallery_Gallery_PopupClose)
            Me.filtersGallery.Id = 17
            Me.filtersGallery.Name = "filtersGallery"
            AddHandler Me.filtersGallery.GalleryItemCheckedChanged, New DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(AddressOf Me.OnFilterGalleryItemCheckedChanged)
            ' 
            ' biFilterByMarked
            ' 
            Me.biFilterByMarked.Caption = "Filter by Marked"
            Me.biFilterByMarked.Glyph = Global.PhotoViewer.Properties.Resources.Filter_16x16
            Me.biFilterByMarked.Id = 18
            Me.biFilterByMarked.LargeGlyph = Global.PhotoViewer.Properties.Resources.Filter_32x32
            Me.biFilterByMarked.Name = "biFilterByMarked"
            AddHandler Me.biFilterByMarked.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnFilterByMarkedCheckedChanged)
            ' 
            ' biRemoveFromAlbum
            ' 
            Me.biRemoveFromAlbum.Caption = "Remove from album"
            Me.biRemoveFromAlbum.Glyph = Global.PhotoViewer.Properties.Resources.RemoveFromAlbum_16x16
            Me.biRemoveFromAlbum.Id = 20
            Me.biRemoveFromAlbum.LargeGlyph = Global.PhotoViewer.Properties.Resources.RemoveFromAlbum_32x32
            Me.biRemoveFromAlbum.Name = "biRemoveFromAlbum"
            AddHandler Me.biRemoveFromAlbum.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnRemoveFromAlbumItemClick)
            ' 
            ' biSelectAllMarked
            ' 
            Me.biSelectAllMarked.Caption = "Select All Marked"
            Me.biSelectAllMarked.Glyph = Global.PhotoViewer.Properties.Resources.SelectAllMarked_16x16
            Me.biSelectAllMarked.Id = 21
            Me.biSelectAllMarked.LargeGlyph = Global.PhotoViewer.Properties.Resources.SelectAllMarked_32x32
            Me.biSelectAllMarked.Name = "biSelectAllMarked"
            AddHandler Me.biSelectAllMarked.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnSelectAllMarkedItemClick)
            ' 
            ' beZoom
            ' 
            Me.beZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.beZoom.Edit = Me.repositoryItemZoomTrackBar1
            Me.beZoom.EditValue = 210
            Me.beZoom.Id = 22
            Me.beZoom.Name = "beZoom"
            Me.beZoom.Width = 200
            ' 
            ' repositoryItemZoomTrackBar1
            ' 
            Me.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center
            Me.repositoryItemZoomTrackBar1.AllowFocused = False
            Me.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemZoomTrackBar1.Maximum = 400
            Me.repositoryItemZoomTrackBar1.Middle = 5
            Me.repositoryItemZoomTrackBar1.Minimum = 50
            Me.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1"
            Me.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
            AddHandler Me.repositoryItemZoomTrackBar1.ValueChanged, New System.EventHandler(AddressOf Me.repositoryItemZoomTrackBar1_ValueChanged)
            ' 
            ' barButtonGroup1
            ' 
            Me.barButtonGroup1.Caption = "barButtonGroup1"
            Me.barButtonGroup1.Id = 23
            Me.barButtonGroup1.ItemLinks.Add(Me.biView)
            Me.barButtonGroup1.ItemLinks.Add(Me.biRemoveFilesFromLibrary)
            Me.barButtonGroup1.Name = "barButtonGroup1"
            ' 
            ' barButtonGroup2
            ' 
            Me.barButtonGroup2.Caption = "barButtonGroup2"
            Me.barButtonGroup2.Id = 24
            Me.barButtonGroup2.ItemLinks.Add(Me.biAddToAlbum)
            Me.barButtonGroup2.ItemLinks.Add(Me.biRemoveFromAlbum)
            Me.barButtonGroup2.Name = "barButtonGroup2"
            ' 
            ' barButtonGroup3
            ' 
            Me.barButtonGroup3.Caption = "barButtonGroup3"
            Me.barButtonGroup3.Id = 25
            Me.barButtonGroup3.ItemLinks.Add(Me.biMark)
            Me.barButtonGroup3.ItemLinks.Add(Me.biUnmark)
            Me.barButtonGroup3.ItemLinks.Add(Me.biUnmarkAll)
            Me.barButtonGroup3.Name = "barButtonGroup3"
            ' 
            ' barButtonGroup4
            ' 
            Me.barButtonGroup4.Caption = "barButtonGroup4"
            Me.barButtonGroup4.Id = 26
            Me.barButtonGroup4.ItemLinks.Add(Me.biCollage)
            Me.barButtonGroup4.ItemLinks.Add(Me.biSlideShow)
            Me.barButtonGroup4.ItemLinks.Add(Me.biFilm)
            Me.barButtonGroup4.Name = "barButtonGroup4"
            ' 
            ' bBColorMix
            ' 
            Me.bBColorMix.Caption = "Color Mix"
            Me.bBColorMix.Glyph = Global.PhotoViewer.Properties.Resources.ColorMixer_16x16
            Me.bBColorMix.Id = 27
            Me.bBColorMix.LargeGlyph = Global.PhotoViewer.Properties.Resources.ColorMixer_32x32
            Me.bBColorMix.Name = "bBColorMix"
            AddHandler Me.bBColorMix.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.bBColorMix_ItemClick)
            ' 
            ' barCheckItem1
            ' 
            Me.barCheckItem1.Caption = "Random show"
            Me.barCheckItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.barCheckItem1.Checked = True
            Me.barCheckItem1.Id = 29
            Me.barCheckItem1.Name = "barCheckItem1"
            AddHandler Me.barCheckItem1.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.barCheckItem1_ItemClick)
            ' 
            ' bsAnimationType
            ' 
            Me.bsAnimationType.Caption = "Animation type"
            Me.bsAnimationType.Id = 30
            Me.bsAnimationType.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bcAnimationNone), New DevExpress.XtraBars.LinkPersistInfo(Me.bcExpandAnimation), New DevExpress.XtraBars.LinkPersistInfo(Me.bcPushAnimation), New DevExpress.XtraBars.LinkPersistInfo(Me.bcSegmentedAnimation), New DevExpress.XtraBars.LinkPersistInfo(Me.bcSlideAnimation)})
            Me.bsAnimationType.Name = "bsAnimationType"
            ' 
            ' bcAnimationNone
            ' 
            Me.bcAnimationNone.Caption = "None"
            Me.bcAnimationNone.GroupIndex = 4
            Me.bcAnimationNone.Id = 31
            Me.bcAnimationNone.Name = "bcAnimationNone"
            AddHandler Me.bcAnimationNone.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnAnimationTypeChanged)
            ' 
            ' bcExpandAnimation
            ' 
            Me.bcExpandAnimation.Caption = "Expand"
            Me.bcExpandAnimation.GroupIndex = 4
            Me.bcExpandAnimation.Id = 32
            Me.bcExpandAnimation.Name = "bcExpandAnimation"
            AddHandler Me.bcExpandAnimation.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnAnimationTypeChanged)
            ' 
            ' bcPushAnimation
            ' 
            Me.bcPushAnimation.Caption = "Push"
            Me.bcPushAnimation.Checked = True
            Me.bcPushAnimation.GroupIndex = 4
            Me.bcPushAnimation.Id = 33
            Me.bcPushAnimation.Name = "bcPushAnimation"
            AddHandler Me.bcPushAnimation.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnAnimationTypeChanged)
            ' 
            ' bcSegmentedAnimation
            ' 
            Me.bcSegmentedAnimation.Caption = "Segmented fade"
            Me.bcSegmentedAnimation.GroupIndex = 4
            Me.bcSegmentedAnimation.Id = 35
            Me.bcSegmentedAnimation.Name = "bcSegmentedAnimation"
            AddHandler Me.bcSegmentedAnimation.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnAnimationTypeChanged)
            ' 
            ' bcSlideAnimation
            ' 
            Me.bcSlideAnimation.Caption = "Slide"
            Me.bcSlideAnimation.GroupIndex = 4
            Me.bcSlideAnimation.Id = 34
            Me.bcSlideAnimation.Name = "bcSlideAnimation"
            AddHandler Me.bcSlideAnimation.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnAnimationTypeChanged)
            ' 
            ' ribbonMiniToolbar1
            ' 
            Me.ribbonMiniToolbar1.Alignment = System.Drawing.ContentAlignment.TopRight
            Me.ribbonMiniToolbar1.ItemLinks.Add(Me.barButtonGroup1)
            Me.ribbonMiniToolbar1.ItemLinks.Add(Me.barButtonGroup2)
            Me.ribbonMiniToolbar1.ItemLinks.Add(Me.barButtonGroup3)
            Me.ribbonMiniToolbar1.ItemLinks.Add(Me.barButtonGroup4)
            Me.ribbonMiniToolbar1.ParentControl = Me
            ' 
            ' viewPageCategory
            ' 
            Me.viewPageCategory.Name = "viewPageCategory"
            Me.viewPageCategory.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.collectionOriginalPage})
            Me.viewPageCategory.Text = "View"
            Me.viewPageCategory.Visible = False
            ' 
            ' collectionOriginalPage
            ' 
            Me.collectionOriginalPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.filtersFilePageGroup, Me.filtersPageGroup})
            Me.collectionOriginalPage.Name = "collectionOriginalPage"
            Me.collectionOriginalPage.Text = "Collection"
            Me.collectionOriginalPage.Visible = False
            ' 
            ' filtersFilePageGroup
            ' 
            Me.filtersFilePageGroup.ItemLinks.Add(Me.biSaveImage)
            Me.filtersFilePageGroup.ItemLinks.Add(Me.biCancel)
            Me.filtersFilePageGroup.ItemLinks.Add(Me.biClose, True)
            Me.filtersFilePageGroup.Name = "filtersFilePageGroup"
            Me.filtersFilePageGroup.Text = "File"
            ' 
            ' filtersPageGroup
            ' 
            Me.filtersPageGroup.ItemLinks.Add(Me.filtersGallery)
            Me.filtersPageGroup.Name = "filtersPageGroup"
            Me.filtersPageGroup.Text = "Filters"
            ' 
            ' imagePage
            ' 
            Me.imagePage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.imageGeneralPageGroup, Me.imageMarkingPageGroup, Me.makePageGroup, Me.outputPageGroup})
            Me.imagePage.Name = "imagePage"
            Me.imagePage.Text = "Image"
            ' 
            ' imageGeneralPageGroup
            ' 
            Me.imageGeneralPageGroup.ItemLinks.Add(Me.biAddToLibrary)
            Me.imageGeneralPageGroup.ItemLinks.Add(Me.biView, True)
            Me.imageGeneralPageGroup.ItemLinks.Add(Me.biRemoveFilesFromLibrary)
            Me.imageGeneralPageGroup.ItemLinks.Add(Me.biAddToAlbum, True)
            Me.imageGeneralPageGroup.ItemLinks.Add(Me.biRemoveFromAlbum)
            Me.imageGeneralPageGroup.Name = "imageGeneralPageGroup"
            Me.imageGeneralPageGroup.ShowCaptionButton = False
            Me.imageGeneralPageGroup.Text = "General"
            ' 
            ' imageMarkingPageGroup
            ' 
            Me.imageMarkingPageGroup.ItemLinks.Add(Me.biMark)
            Me.imageMarkingPageGroup.ItemLinks.Add(Me.biUnmark)
            Me.imageMarkingPageGroup.ItemLinks.Add(Me.biUnmarkAll)
            Me.imageMarkingPageGroup.ItemLinks.Add(Me.biFilterByMarked, True)
            Me.imageMarkingPageGroup.ItemLinks.Add(Me.biSelectAllMarked)
            Me.imageMarkingPageGroup.Name = "imageMarkingPageGroup"
            Me.imageMarkingPageGroup.ShowCaptionButton = False
            Me.imageMarkingPageGroup.Text = "Marking"
            ' 
            ' makePageGroup
            ' 
            Me.makePageGroup.ItemLinks.Add(Me.biCollage)
            Me.makePageGroup.ItemLinks.Add(Me.biSlideShow)
            Me.makePageGroup.ItemLinks.Add(Me.biFilm)
            Me.makePageGroup.Name = "makePageGroup"
            Me.makePageGroup.ShowCaptionButton = False
            Me.makePageGroup.Text = "Make"
            ' 
            ' outputPageGroup
            ' 
            Me.outputPageGroup.ItemLinks.Add(Me.biExportFolder)
            Me.outputPageGroup.ItemLinks.Add(Me.biEmail)
            Me.outputPageGroup.ItemLinks.Add(Me.biUpload)
            Me.outputPageGroup.ItemLinks.Add(Me.biPrint, True)
            Me.outputPageGroup.Name = "outputPageGroup"
            Me.outputPageGroup.ShowCaptionButton = False
            Me.outputPageGroup.Text = "Output"
            ' 
            ' folderPage
            ' 
            Me.folderPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.folderPageGroup})
            Me.folderPage.Name = "folderPage"
            Me.folderPage.Text = "Folder"
            ' 
            ' folderPageGroup
            ' 
            Me.folderPageGroup.ItemLinks.Add(Me.biAddFolder)
            Me.folderPageGroup.ItemLinks.Add(Me.biAddFile)
            Me.folderPageGroup.ItemLinks.Add(Me.biRemoveFolder)
            Me.folderPageGroup.Name = "folderPageGroup"
            Me.folderPageGroup.ShowCaptionButton = False
            Me.folderPageGroup.Text = "General"
            ' 
            ' albumPage
            ' 
            Me.albumPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.albumPageGroup})
            Me.albumPage.Name = "albumPage"
            Me.albumPage.Text = "Album"
            ' 
            ' albumPageGroup
            ' 
            Me.albumPageGroup.ItemLinks.Add(Me.biNewAlbum)
            Me.albumPageGroup.ItemLinks.Add(Me.biEditAlbum)
            Me.albumPageGroup.ItemLinks.Add(Me.biRemoveAlbum)
            Me.albumPageGroup.Name = "albumPageGroup"
            Me.albumPageGroup.ShowCaptionButton = False
            Me.albumPageGroup.Text = "General"
            ' 
            ' viewPage
            ' 
            Me.viewPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.skinsPageGroup, Me.ribbonPageGroup4})
            Me.viewPage.Name = "viewPage"
            Me.viewPage.Text = "View"
            ' 
            ' skinsPageGroup
            ' 
            Me.skinsPageGroup.ItemLinks.Add(Me.skinGalleryBarItem)
            Me.skinsPageGroup.ItemLinks.Add(Me.bBColorMix)
            Me.skinsPageGroup.Name = "skinsPageGroup"
            Me.skinsPageGroup.ShowCaptionButton = False
            Me.skinsPageGroup.Text = "Skins"
            ' 
            ' ribbonPageGroup4
            ' 
            Me.ribbonPageGroup4.AllowTextClipping = False
            Me.ribbonPageGroup4.ItemLinks.Add(Me.bsAnimationType)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.barCheckItem1)
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.ShowCaptionButton = False
            Me.ribbonPageGroup4.Text = "Options image load"
            ' 
            ' ribbonStatusBar1
            ' 
            Me.ribbonStatusBar1.ItemLinks.Add(Me.beZoom)
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 738)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1114, 31)
            ' 
            ' mainGallery
            ' 
            Me.mainGallery.Controls.Add(Me.galleryControlClient1)
            Me.mainGallery.DesignGalleryGroupIndex = 0
            Me.mainGallery.DesignGalleryItemIndex = 0
            Me.mainGallery.Dock = System.Windows.Forms.DockStyle.Fill
            ' 
            ' galleryControlGallery1
            ' 
            Me.mainGallery.Gallery.AllowMarqueeSelection = True
            Me.mainGallery.Gallery.ClearSelectionOnClickEmptySpace = True
            Me.mainGallery.Gallery.ContextButtonOptions.BottomPanelColor = System.Drawing.Color.FromArgb((CInt(((CByte((190)))))), (CInt(((CByte((109)))))), (CInt(((CByte((109)))))), (CInt(((CByte((109)))))))
            Me.mainGallery.Gallery.ContextButtonOptions.BottomPanelPadding = New System.Windows.Forms.Padding(5)
            Me.mainGallery.Gallery.ContextButtonOptions.TopPanelColor = System.Drawing.Color.FromArgb((CInt(((CByte((190)))))), (CInt(((CByte((109)))))), (CInt(((CByte((109)))))), (CInt(((CByte((109)))))))
            Me.mainGallery.Gallery.ContextButtonOptions.TopPanelPadding = New System.Windows.Forms.Padding(5)
            contextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.MiddleTop
            contextButton1.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            contextButton1.AppearanceHover.ForeColor = System.Drawing.Color.White
            contextButton1.AppearanceHover.Options.UseForeColor = True
            contextButton1.AppearanceNormal.ForeColor = System.Drawing.Color.Gainsboro
            contextButton1.AppearanceNormal.Options.UseForeColor = True
            contextButton1.Id = New System.Guid("ef256683-68b4-4f42-8152-a25dfc3f6513")
            contextButton1.Name = "itemInfo"
            contextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible
            contextButton2.Alignment = DevExpress.Utils.ContextItemAlignment.TopFar
            contextButton2.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            contextButton2.AppearanceHover.ForeColor = System.Drawing.Color.Gainsboro
            contextButton2.AppearanceHover.Options.UseForeColor = True
            contextButton2.AppearanceNormal.ForeColor = System.Drawing.Color.White
            contextButton2.AppearanceNormal.Options.UseForeColor = True
            contextButton2.Glyph = CType((resources.GetObject("contextButton2.Glyph")), System.Drawing.Image)
            contextButton2.Id = New System.Guid("8200a79a-62ac-419a-8e6d-a512a1dbedc8")
            contextButton2.Name = "itemRemove"
            contextButton3.Alignment = DevExpress.Utils.ContextItemAlignment.TopFar
            contextButton3.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            contextButton3.AppearanceHover.ForeColor = System.Drawing.Color.Gainsboro
            contextButton3.AppearanceHover.Options.UseForeColor = True
            contextButton3.AppearanceNormal.ForeColor = System.Drawing.Color.White
            contextButton3.AppearanceNormal.Options.UseForeColor = True
            contextButton3.Glyph = CType((resources.GetObject("contextButton3.Glyph")), System.Drawing.Image)
            contextButton3.Id = New System.Guid("da28a8b1-d513-4fac-a7e8-c6e3f516e047")
            contextButton3.Name = "itemLocation"
            checkContextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.BottomNear
            checkContextButton1.Id = New System.Guid("96356b6d-4ef9-466b-90e7-3889bd257758")
            checkContextButton1.Name = "itemCheck"
            checkContextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible
            ratingContextButton1.Alignment = DevExpress.Utils.ContextItemAlignment.MiddleBottom
            ratingContextButton1.Id = New System.Guid("fc941a69-954d-4247-a4cb-eee0d430799e")
            ratingContextButton1.Name = "itemRating"
            ratingContextButton1.Rating = New Decimal(New Integer() {0, 0, 0, 0})
            Me.mainGallery.Gallery.ContextButtons.Add(contextButton1)
            Me.mainGallery.Gallery.ContextButtons.Add(contextButton2)
            Me.mainGallery.Gallery.ContextButtons.Add(contextButton3)
            Me.mainGallery.Gallery.ContextButtons.Add(checkContextButton1)
            Me.mainGallery.Gallery.ContextButtons.Add(ratingContextButton1)
            Me.mainGallery.Gallery.ImageSize = New System.Drawing.Size(210, 210)
            Me.mainGallery.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.Multiple
            Me.mainGallery.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
            Me.mainGallery.Gallery.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Push
            Me.mainGallery.Gallery.OptionsImageLoad.AsyncLoad = True
            Me.mainGallery.Gallery.OptionsImageLoad.DesiredThumbnailSize = New System.Drawing.Size(208, 208)
            Me.mainGallery.Gallery.ScrollMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryScrollMode.Smooth
            Me.mainGallery.Gallery.ScrollSpeed = 0.75F
            AddHandler Me.mainGallery.Gallery.ContextButtonCustomize, New DevExpress.XtraBars.Ribbon.Gallery.GalleryContextButtonCustomizeEventHandler(AddressOf Me.OnMainGallery_ContextButtonCustomize)
            AddHandler Me.mainGallery.Gallery.ContextButtonClick, New DevExpress.Utils.ContextItemClickEventHandler(AddressOf Me.galleryControlGallery1_ContextButtonClick)
            AddHandler Me.mainGallery.Gallery.ItemDoubleClick, New DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(AddressOf Me.OnMainGalleryDoubleClick)
            AddHandler Me.mainGallery.Gallery.ItemCheckedChanged, New DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(AddressOf Me.OnMainGalleryItemCheckedChanged)
            AddHandler Me.mainGallery.Gallery.CustomDrawItemImage, New DevExpress.XtraBars.Ribbon.GalleryItemCustomDrawEventHandler(AddressOf Me.OnMainGalleryCustomDrawItemImage)
            AddHandler Me.mainGallery.Gallery.MarqueeSelectionCompleted, New DevExpress.XtraBars.Ribbon.GallerySelectionEventHandler(AddressOf Me.galleryControlGallery1_MarqueeSelectionCompleted)
            AddHandler Me.mainGallery.Gallery.GetThumbnailImage, New DevExpress.XtraBars.Ribbon.Gallery.GalleryThumbnailImageEventHandler(AddressOf Me.galleryControlGallery1_GetThumbnailImage)
            Me.mainGallery.Location = New System.Drawing.Point(6, 0)
            Me.mainGallery.Name = "mainGallery"
            Me.mainGallery.Size = New System.Drawing.Size(573, 582)
            Me.mainGallery.TabIndex = 0
            Me.mainGallery.Text = "galleryControl1"
            AddHandler Me.mainGallery.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnMainGalleryMouseDown)
            ' 
            ' galleryControlClient1
            ' 
            Me.defaultToolTipController1.SetAllowHtmlText(Me.galleryControlClient1, DevExpress.Utils.DefaultBoolean.[Default])
            Me.galleryControlClient1.GalleryControl = Me.mainGallery
            Me.galleryControlClient1.Location = New System.Drawing.Point(2, 2)
            Me.galleryControlClient1.Size = New System.Drawing.Size(552, 578)
            ' 
            ' defaultToolTipController1
            ' 
            ' 
            ' 
            ' 
            Me.defaultToolTipController1.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
            ' 
            ' printPreviewDialog1
            ' 
            Me.defaultToolTipController1.SetAllowHtmlText(Me.printPreviewDialog1, DevExpress.Utils.DefaultBoolean.[Default])
            Me.printPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
            Me.printPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
            Me.printPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
            Me.printPreviewDialog1.Enabled = True
            Me.printPreviewDialog1.Icon = CType((resources.GetObject("printPreviewDialog1.Icon")), System.Drawing.Icon)
            Me.printPreviewDialog1.Name = "printPreviewDialog1"
            Me.printPreviewDialog1.UseAntiAlias = True
            Me.printPreviewDialog1.Visible = False
            ' 
            ' libraryPanel
            ' 
            Me.defaultToolTipController1.SetAllowHtmlText(Me.libraryPanel, DevExpress.Utils.DefaultBoolean.[Default])
            Me.libraryPanel.Controls.Add(Me.galleryContentPanel)
            Me.libraryPanel.Controls.Add(Me.panelContainer1)
            Me.libraryPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.libraryPanel.Location = New System.Drawing.Point(0, 0)
            Me.libraryPanel.Name = "libraryPanel"
            Me.libraryPanel.Size = New System.Drawing.Size(1114, 594)
            Me.libraryPanel.TabIndex = 1
            ' 
            ' galleryContentPanel
            ' 
            Me.defaultToolTipController1.SetAllowHtmlText(Me.galleryContentPanel, DevExpress.Utils.DefaultBoolean.[Default])
            Me.galleryContentPanel.Controls.Add(Me.galleryPanel)
            Me.galleryContentPanel.Controls.Add(Me.navBarControl1)
            Me.galleryContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.galleryContentPanel.Location = New System.Drawing.Point(0, 0)
            Me.galleryContentPanel.Name = "galleryContentPanel"
            Me.galleryContentPanel.Padding = New System.Windows.Forms.Padding(6)
            Me.galleryContentPanel.Size = New System.Drawing.Size(777, 594)
            Me.galleryContentPanel.TabIndex = 2
            ' 
            ' galleryPanel
            ' 
            Me.defaultToolTipController1.SetAllowHtmlText(Me.galleryPanel, DevExpress.Utils.DefaultBoolean.[Default])
            Me.galleryPanel.Controls.Add(Me.mainGallery)
            Me.galleryPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.galleryPanel.Location = New System.Drawing.Point(192, 6)
            Me.galleryPanel.Name = "galleryPanel"
            Me.galleryPanel.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
            Me.galleryPanel.Size = New System.Drawing.Size(579, 582)
            Me.galleryPanel.TabIndex = 1
            ' 
            ' panelContainer1
            ' 
            Me.panelContainer1.Controls.Add(Me.dockPanel1)
            Me.panelContainer1.Controls.Add(Me.dockPanel2)
            Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.panelContainer1.ID = New System.Guid("8218d2c3-3acd-4418-8cf7-e1b6091107a3")
            Me.panelContainer1.Location = New System.Drawing.Point(777, 0)
            Me.panelContainer1.Name = "panelContainer1"
            Me.panelContainer1.OriginalSize = New System.Drawing.Size(337, 200)
            Me.panelContainer1.Size = New System.Drawing.Size(337, 594)
            Me.panelContainer1.Text = "panelContainer1"
            ' 
            ' dockPanel1
            ' 
            Me.dockPanel1.Controls.Add(Me.controlContainer1)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel1.ID = New System.Guid("1a5d040e-8d04-4f3d-bfd7-d81cb0934982")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.Options.ShowCloseButton = False
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(337, 252)
            Me.dockPanel1.Size = New System.Drawing.Size(337, 250)
            Me.dockPanel1.Text = "Preview"
            ' 
            ' controlContainer1
            ' 
            Me.defaultToolTipController1.SetAllowHtmlText(Me.controlContainer1, DevExpress.Utils.DefaultBoolean.[Default])
            Me.controlContainer1.Controls.Add(Me.selectedPictureEdit)
            Me.controlContainer1.Location = New System.Drawing.Point(4, 23)
            Me.controlContainer1.Name = "controlContainer1"
            Me.controlContainer1.Size = New System.Drawing.Size(329, 223)
            Me.controlContainer1.TabIndex = 0
            ' 
            ' selectedPictureEdit
            ' 
            Me.selectedPictureEdit.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.selectedPictureEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.selectedPictureEdit.Location = New System.Drawing.Point(0, 0)
            Me.selectedPictureEdit.MenuManager = Me.ribbonControl1
            Me.selectedPictureEdit.Name = "selectedPictureEdit"
            Me.selectedPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.selectedPictureEdit.Size = New System.Drawing.Size(329, 223)
            Me.selectedPictureEdit.TabIndex = 0
            Me.selectedPictureEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            ' 
            ' dockPanel2
            ' 
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.dockPanel2.ID = New System.Guid("b921466f-3e4f-4a20-8f62-f73e3660d5d9")
            Me.dockPanel2.Location = New System.Drawing.Point(0, 250)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(337, 347)
            Me.dockPanel2.Size = New System.Drawing.Size(337, 344)
            Me.dockPanel2.Text = "Date Filter"
            ' 
            ' dockPanel2_Container
            ' 
            Me.defaultToolTipController1.SetAllowHtmlText(Me.dockPanel2_Container, DevExpress.Utils.DefaultBoolean.[Default])
            Me.dockPanel2_Container.Controls.Add(Me.dateFilter1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 23)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(329, 317)
            Me.dockPanel2_Container.TabIndex = 0
            ' 
            ' dateFilter1
            ' 
            Me.defaultToolTipController1.SetAllowHtmlText(Me.dateFilter1, DevExpress.Utils.DefaultBoolean.[Default])
            Me.dateFilter1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dateFilter1.Location = New System.Drawing.Point(0, 0)
            Me.dateFilter1.Name = "dateFilter1"
            Me.dateFilter1.Size = New System.Drawing.Size(329, 317)
            Me.dateFilter1.TabIndex = 0
            AddHandler Me.dateFilter1.SelectionChanged, New System.EventHandler(AddressOf Me.OnDateFilterSelectionChanged)
            ' 
            ' dockPanel1_Container
            ' 
            Me.defaultToolTipController1.SetAllowHtmlText(Me.dockPanel1_Container, DevExpress.Utils.DefaultBoolean.[Default])
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 25)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(238, 401)
            Me.dockPanel1_Container.TabIndex = 0
            ' 
            ' controlPresenter1
            ' 
            Me.defaultToolTipController1.SetAllowHtmlText(Me.controlPresenter1, DevExpress.Utils.DefaultBoolean.[Default])
            Me.controlPresenter1.Controls.Add(Me.libraryPanel)
            Me.controlPresenter1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.controlPresenter1.Location = New System.Drawing.Point(0, 144)
            Me.controlPresenter1.Name = "controlPresenter1"
            Me.controlPresenter1.SelectedControl = Me.libraryPanel
            Me.controlPresenter1.SelectedControlIndex = 0
            Me.controlPresenter1.Size = New System.Drawing.Size(1114, 594)
            Me.controlPresenter1.TabIndex = 10
            AddHandler Me.controlPresenter1.SelectedControlChanged, New System.EventHandler(AddressOf Me.OnMainTabSelectedPageChanged)
            ' 
            ' folderPopupMenu
            ' 
            Me.folderPopupMenu.ItemLinks.Add(Me.biRemoveFolder)
            Me.folderPopupMenu.Name = "folderPopupMenu"
            Me.folderPopupMenu.Ribbon = Me.ribbonControl1
            ' 
            ' galleryItemMenu
            ' 
            Me.galleryItemMenu.Name = "galleryItemMenu"
            Me.galleryItemMenu.Ribbon = Me.ribbonControl1
            ' 
            ' dockManager1
            ' 
            Me.dockManager1.Form = Me.libraryPanel
            Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.panelContainer1})
            Me.dockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            ' 
            ' imageDialog
            ' 
            Me.imageDialog.Filter = "Image files (BMP,JPG,PNG,GIF) |*.bmp;*.jpg;*.png;*.gif| All files|*.*"
            Me.imageDialog.Multiselect = True
            ' 
            ' MainForm
            ' 
            Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
            Me.defaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1114, 769)
            Me.Controls.Add(Me.popupControlContainer1)
            Me.Controls.Add(Me.controlPresenter1)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.Icon = CType((resources.GetObject("$this.Icon")), System.Drawing.Icon)
            Me.Name = "MainForm"
            Me.Ribbon = Me.ribbonControl1
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "Photo Viewer"
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.albumPopupMenu), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.applicationMenu1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupControlContainer1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer1.ResumeLayout(False)
            CType((Me.addToLibraryMenu), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.albumsPopupMenu), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemZoomTrackBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mainGallery), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainGallery.ResumeLayout(False)
            Me.libraryPanel.ResumeLayout(False)
            Me.galleryContentPanel.ResumeLayout(False)
            Me.galleryPanel.ResumeLayout(False)
            Me.panelContainer1.ResumeLayout(False)
            Me.dockPanel1.ResumeLayout(False)
            Me.controlContainer1.ResumeLayout(False)
            CType((Me.selectedPictureEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            Me.controlPresenter1.ResumeLayout(False)
            CType((Me.folderPopupMenu), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.galleryItemMenu), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private bsView As DevExpress.XtraBars.BarSubItem

        Private bsTools As DevExpress.XtraBars.BarSubItem

        Private bsHelp As DevExpress.XtraBars.BarSubItem

        Private biAbout As DevExpress.XtraBars.BarButtonItem

        Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl

        Private albumGroup As DevExpress.XtraNavBar.NavBarGroup

        Private foldersGroup As DevExpress.XtraNavBar.NavBarGroup

        Private othersGroup As DevExpress.XtraNavBar.NavBarGroup

        Private mainGallery As DevExpress.XtraBars.Ribbon.GalleryControl

        Private bsSkins As DevExpress.XtraBars.BarSubItem

        Private biNewAlbum As DevExpress.XtraBars.BarButtonItem

        Private biAddFolder As DevExpress.XtraBars.BarButtonItem

        Private biAddFile As DevExpress.XtraBars.BarButtonItem

        Private biPrint As DevExpress.XtraBars.BarButtonItem

        Private biExit As DevExpress.XtraBars.BarButtonItem

        Private defaultToolTipController1 As DevExpress.Utils.DefaultToolTipController

        Private folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog

        Private albumPopupMenu As DevExpress.XtraBars.PopupMenu

        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem

        Private biRemoveAlbum As DevExpress.XtraBars.BarButtonItem

        Private folderPopupMenu As DevExpress.XtraBars.PopupMenu

        Private biRemoveFolder As DevExpress.XtraBars.BarButtonItem

        Private albumsPopupMenu As DevExpress.XtraBars.PopupMenu

        Private controlPresenter1 As DevExpress.Utils.Controls.ControlPresenter

        Private printPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog

        Private galleryItemMenu As DevExpress.XtraBars.PopupMenu

        Private biEditAlbum As DevExpress.XtraBars.BarButtonItem

        Private albumSubItem As DevExpress.XtraBars.BarSubItem

        Private biView As DevExpress.XtraBars.BarButtonItem

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private imagePage As DevExpress.XtraBars.Ribbon.RibbonPage

        Private imageGeneralPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private imageMarkingPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private makePageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private outputPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private folderPage As DevExpress.XtraBars.Ribbon.RibbonPage

        Private viewPageCategory As DevExpress.XtraBars.Ribbon.RibbonPageCategory

        Private collectionOriginalPage As DevExpress.XtraBars.Ribbon.RibbonPage

        Private albumPage As DevExpress.XtraBars.Ribbon.RibbonPage

        Private viewPage As DevExpress.XtraBars.Ribbon.RibbonPage

        Private folderPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private albumPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private applicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu

        Private skinGalleryBarItem As DevExpress.XtraBars.RibbonGalleryBarItem

        Private skinsPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer

        Private exitButton As DevExpress.XtraEditors.SimpleButton

        Private biExportFolder As DevExpress.XtraBars.BarButtonItem

        Private biEmail As DevExpress.XtraBars.BarButtonItem

        Private biUpload As DevExpress.XtraBars.BarButtonItem

        Private biAddToLibrary As DevExpress.XtraBars.BarButtonItem

        Private addToLibraryMenu As DevExpress.XtraBars.PopupMenu

        Private biRemoveFilesFromLibrary As DevExpress.XtraBars.BarButtonItem

        Private biAddToAlbum As DevExpress.XtraBars.BarButtonItem

        Private biMark As DevExpress.XtraBars.BarButtonItem

        Private biUnmark As DevExpress.XtraBars.BarButtonItem

        Private biUnmarkAll As DevExpress.XtraBars.BarButtonItem

        Private biCollage As DevExpress.XtraBars.BarButtonItem

        Private biSlideShow As DevExpress.XtraBars.BarButtonItem

        Private biFilm As DevExpress.XtraBars.BarButtonItem

        Private dockManager1 As DevExpress.XtraBars.Docking.DockManager

        Private libraryPanel As System.Windows.Forms.UserControl

        Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private selectedPictureEdit As DevExpress.XtraEditors.PictureEdit

        Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel

        Private controlContainer1 As DevExpress.XtraBars.Docking.ControlContainer

        Private filtersFilePageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private biSaveImage As DevExpress.XtraBars.BarButtonItem

        Private biCancel As DevExpress.XtraBars.BarButtonItem

        Private biClose As DevExpress.XtraBars.BarButtonItem

        Private filtersPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private filtersGallery As DevExpress.XtraBars.RibbonGalleryBarItem

        Private biFilterByMarked As DevExpress.XtraBars.BarCheckItem

        Private biGenerateData As DevExpress.XtraBars.BarButtonItem

        Private biRemoveFromAlbum As DevExpress.XtraBars.BarButtonItem

        Private imageDialog As System.Windows.Forms.OpenFileDialog

        Private biSelectAllMarked As DevExpress.XtraBars.BarButtonItem

        Private beZoom As DevExpress.XtraBars.BarEditItem

        Private repositoryItemZoomTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar

        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dateFilter1 As PhotoViewer.DateFilter

        Private galleryContentPanel As System.Windows.Forms.Panel

        Private galleryPanel As System.Windows.Forms.Panel

        Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient

        Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup

        Private barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup

        Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup

        Private barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup

        Private ribbonMiniToolbar1 As DevExpress.XtraBars.Ribbon.RibbonMiniToolbar

        Private bBColorMix As DevExpress.XtraBars.BarButtonItem

        Private bsAnimationType As DevExpress.XtraBars.BarSubItem

        Private bcAnimationNone As DevExpress.XtraBars.BarCheckItem

        Private bcSlideAnimation As DevExpress.XtraBars.BarCheckItem

        Private bcExpandAnimation As DevExpress.XtraBars.BarCheckItem

        Private bcPushAnimation As DevExpress.XtraBars.BarCheckItem

        Private bcSegmentedAnimation As DevExpress.XtraBars.BarCheckItem

        Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem
    End Class
End Namespace
