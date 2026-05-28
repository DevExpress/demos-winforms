Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar

Namespace DevExpress.XtraGrid.Demos

    Partial Class ExplorerView

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.ExplorerView))
            Dim superToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim galleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItem1 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem2 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem3 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem4 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem5 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem6 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem7 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim skinPaddingEdges1 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
            Dim skinPaddingEdges2 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
            Dim editorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim serializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim editorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim serializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim breadCrumbNode1 As DevExpress.XtraEditors.BreadCrumbNode = New DevExpress.XtraEditors.BreadCrumbNode()
            Dim breadCrumbNode2 As DevExpress.XtraEditors.BreadCrumbNode = New DevExpress.XtraEditors.BreadCrumbNode()
            Dim editorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim serializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.repositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.ButtonItemHelp = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNavigationPane = New DevExpress.XtraBars.BarSubItem()
            Me.ButtonCheckItemNavigationPane = New DevExpress.XtraBars.BarCheckItem()
            Me.ButtonCheckItemShowFavorites = New DevExpress.XtraBars.BarCheckItem()
            Me.ButtonCheckItemShowLibraries = New DevExpress.XtraBars.BarCheckItem()
            Me.ButtonItemItemCheckBoxes = New DevExpress.XtraBars.BarCheckItem()
            Me.ButtonItemFileNameExtensions = New DevExpress.XtraBars.BarCheckItem()
            Me.ButtonItemHiddenItems = New DevExpress.XtraBars.BarCheckItem()
            Me.btnHideSelectedItems = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemCopy = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemPaste = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemCut = New DevExpress.XtraBars.BarButtonItem()
            Me.btnCopyItem = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemMoveTo = New DevExpress.XtraBars.BarSubItem()
            Me.ButtonItemDocuments = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemMusic = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemVideos = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemPictures = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemChooseLocation = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemCopyTo = New DevExpress.XtraBars.BarSubItem()
            Me.ButtonItemRename = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewFolder = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewItem = New DevExpress.XtraBars.BarSubItem()
            Me.ButtonItemNewShortcut = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewBitmapImage = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewContact = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewJournalDocument = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewRichTextDocument = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemNewTextDocument = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemCompressedFolder = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemSelectAll = New DevExpress.XtraBars.BarButtonItem()
            Me.btnSelectNone = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemInvertSelection = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemRemoveProperties = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenuDeleteButton = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.ButtonItemRecycle = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemPermanentlyDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.ButtonItemShowRecycleConfirmation = New DevExpress.XtraBars.BarCheckItem()
            Me.btnOpen = New DevExpress.XtraBars.BarButtonItem()
            Me.rgbiViewStyle = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.ContextItemOpen = New DevExpress.XtraBars.BarButtonItem()
            Me.ContextItemCut = New DevExpress.XtraBars.BarButtonItem()
            Me.ContextItemCopy = New DevExpress.XtraBars.BarButtonItem()
            Me.ContextItemPaste = New DevExpress.XtraBars.BarButtonItem()
            Me.ContextItemDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.ContextItemRename = New DevExpress.XtraBars.BarButtonItem()
            Me.PageHome = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.PageGroupClipboard = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageGroupOrganize = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageGroupNew = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageGroupOpen = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageGroupSelect = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageView = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.PageGroupViewPanes = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageGroupViewLayouts = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.PageGroupViewShowHide = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.repositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
            Me.repositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.navBar = New DevExpress.XtraNavBar.NavBarControl()
            Me.groupFavorites = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navPanelItemDesktop = New DevExpress.XtraNavBar.NavBarItem()
            Me.navPanelItemDownloads = New DevExpress.XtraNavBar.NavBarItem()
            Me.navPanelItemRecent = New DevExpress.XtraNavBar.NavBarItem()
            Me.groupLibraries = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navPanelItemDocuments = New DevExpress.XtraNavBar.NavBarItem()
            Me.navPanelItemMusic = New DevExpress.XtraNavBar.NavBarItem()
            Me.navPanelItemPictures = New DevExpress.XtraNavBar.NavBarItem()
            Me.navPanelItemVideos = New DevExpress.XtraNavBar.NavBarItem()
            Me.navigationPanel = New DevExpress.Utils.Layout.TablePanel()
            Me.btnUpTo = New DevExpress.XtraEditors.LabelControl()
            Me.btnNavigationHistory = New DevExpress.XtraEditors.LabelControl()
            Me.editBreadCrumb = New DevExpress.XtraEditors.BreadCrumbEdit()
            Me.images = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.editSearch = New DevExpress.XtraEditors.ButtonEdit()
            Me.btnForward = New DevExpress.XtraEditors.LabelControl()
            Me.btnBack = New DevExpress.XtraEditors.LabelControl()
            Me.contentPanel = New DevExpress.XtraEditors.PanelControl()
            Me.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.winExplorerView = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
            Me.columnName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.columnPath = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.columnCheck = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.columnGroup = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.columnImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.LayoutControlMainGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItemExplorerView = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.liNavPaneRight = New DevExpress.XtraLayout.LayoutControlItem()
            Me.itemPopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.navigationMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType((Me.repositoryItemTextEdit3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.RibbonControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.PopupMenuDeleteButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemRadioGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navBar), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPanel.SuspendLayout()
            CType((Me.editBreadCrumb.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.images), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.editSearch.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.contentPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contentPanel.SuspendLayout()
            CType((Me.LayoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.winExplorerView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.LayoutControlMainGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.LayoutControlItemExplorerView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.SplitterItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liNavPaneRight), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.itemPopupMenu), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationMenu), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' repositoryItemTextEdit3
            ' 
            Me.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3"
            ' 
            ' repositoryItemTextEdit4
            ' 
            Me.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4"
            ' 
            ' RibbonControl
            ' 
            Me.RibbonControl.ApplicationButtonText = "File"
            Me.RibbonControl.ExpandCollapseItem.Id = 0
            Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.ButtonItemHelp, Me.ButtonItemNavigationPane, Me.ButtonItemItemCheckBoxes, Me.ButtonItemFileNameExtensions, Me.ButtonItemHiddenItems, Me.btnHideSelectedItems, Me.ButtonCheckItemNavigationPane, Me.ButtonItemCopy, Me.ButtonItemPaste, Me.ButtonItemCut, Me.btnCopyItem, Me.ButtonItemMoveTo, Me.ButtonItemCopyTo, Me.ButtonItemRename, Me.ButtonItemNewFolder, Me.ButtonItemNewItem, Me.ButtonItemEdit, Me.ButtonItemSelectAll, Me.btnSelectNone, Me.ButtonItemInvertSelection, Me.ButtonItemRemoveProperties, Me.ButtonItemDelete, Me.ButtonItemRecycle, Me.ButtonItemPermanentlyDelete, Me.ButtonItemShowRecycleConfirmation, Me.ButtonItemDocuments, Me.ButtonItemMusic, Me.ButtonItemVideos, Me.ButtonItemPictures, Me.ButtonItemChooseLocation, Me.ButtonCheckItemShowFavorites, Me.ButtonCheckItemShowLibraries, Me.ButtonItemNewShortcut, Me.ButtonItemNewBitmapImage, Me.ButtonItemNewContact, Me.ButtonItemNewJournalDocument, Me.ButtonItemNewRichTextDocument, Me.ButtonItemNewTextDocument, Me.ButtonItemCompressedFolder, Me.btnOpen, Me.rgbiViewStyle, Me.ContextItemOpen, Me.ContextItemCut, Me.ContextItemCopy, Me.ContextItemPaste, Me.ContextItemDelete, Me.ContextItemRename})
            Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
            Me.RibbonControl.MaxItemId = 175
            Me.RibbonControl.Name = "RibbonControl"
            Me.RibbonControl.PageHeaderItemLinks.Add(Me.ButtonItemHelp)
            Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.PageHome, Me.PageView})
            Me.RibbonControl.QuickToolbarItemLinks.Add(Me.ButtonItemNewFolder)
            Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemTextEdit1, Me.repositoryItemRadioGroup1, Me.repositoryItemTextEdit2})
            Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
            Me.RibbonControl.Size = New System.Drawing.Size(824, 150)
            ' 
            ' ButtonItemHelp
            ' 
            Me.ButtonItemHelp.Caption = "Help"
            Me.ButtonItemHelp.Id = 15
            Me.ButtonItemHelp.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ButtonItemHelp.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemHelp.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemHelp.Name = "ButtonItemHelp"
            AddHandler Me.ButtonItemHelp.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnHelpButtonItemClick)
            ' 
            ' ButtonItemNavigationPane
            ' 
            Me.ButtonItemNavigationPane.Caption = "Navigation pane"
            Me.ButtonItemNavigationPane.Id = 16
            Me.ButtonItemNavigationPane.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemNavigationPane.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemNavigationPane.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonCheckItemNavigationPane), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonCheckItemShowFavorites, True), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonCheckItemShowLibraries)})
            Me.ButtonItemNavigationPane.Name = "ButtonItemNavigationPane"
            Me.ButtonItemNavigationPane.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' ButtonCheckItemNavigationPane
            ' 
            Me.ButtonCheckItemNavigationPane.BindableChecked = True
            Me.ButtonCheckItemNavigationPane.Caption = "Navigation pane"
            Me.ButtonCheckItemNavigationPane.Checked = True
            Me.ButtonCheckItemNavigationPane.Id = 37
            Me.ButtonCheckItemNavigationPane.Name = "ButtonCheckItemNavigationPane"
            AddHandler Me.ButtonCheckItemNavigationPane.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnShowNavPaneItemClick)
            ' 
            ' ButtonCheckItemShowFavorites
            ' 
            Me.ButtonCheckItemShowFavorites.BindableChecked = True
            Me.ButtonCheckItemShowFavorites.Caption = "Show favorites"
            Me.ButtonCheckItemShowFavorites.Checked = True
            Me.ButtonCheckItemShowFavorites.Id = 118
            Me.ButtonCheckItemShowFavorites.Name = "ButtonCheckItemShowFavorites"
            AddHandler Me.ButtonCheckItemShowFavorites.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnShowFavoritesItemClick)
            ' 
            ' ButtonCheckItemShowLibraries
            ' 
            Me.ButtonCheckItemShowLibraries.BindableChecked = True
            Me.ButtonCheckItemShowLibraries.Caption = "Show libraries"
            Me.ButtonCheckItemShowLibraries.Checked = True
            Me.ButtonCheckItemShowLibraries.Id = 119
            Me.ButtonCheckItemShowLibraries.Name = "ButtonCheckItemShowLibraries"
            AddHandler Me.ButtonCheckItemShowLibraries.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnShowLibrariesItemClick)
            ' 
            ' ButtonItemItemCheckBoxes
            ' 
            Me.ButtonItemItemCheckBoxes.Caption = "Item check boxes"
            Me.ButtonItemItemCheckBoxes.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.ButtonItemItemCheckBoxes.Id = 26
            Me.ButtonItemItemCheckBoxes.Name = "ButtonItemItemCheckBoxes"
            AddHandler Me.ButtonItemItemCheckBoxes.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnShowCheckBoxesItemClick)
            ' 
            ' ButtonItemFileNameExtensions
            ' 
            Me.ButtonItemFileNameExtensions.Caption = "File name extensions"
            Me.ButtonItemFileNameExtensions.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.ButtonItemFileNameExtensions.Id = 27
            Me.ButtonItemFileNameExtensions.Name = "ButtonItemFileNameExtensions"
            AddHandler Me.ButtonItemFileNameExtensions.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnShowFileNameExtensionsCheckItemClick)
            ' 
            ' ButtonItemHiddenItems
            ' 
            Me.ButtonItemHiddenItems.Caption = "Hidden items"
            Me.ButtonItemHiddenItems.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.ButtonItemHiddenItems.Id = 28
            Me.ButtonItemHiddenItems.Name = "ButtonItemHiddenItems"
            AddHandler Me.ButtonItemHiddenItems.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnShowHiddenItemsCheckItemClick)
            ' 
            ' btnHideSelectedItems
            ' 
            Me.btnHideSelectedItems.Caption = "Hide selected items"
            Me.btnHideSelectedItems.Id = 29
            Me.btnHideSelectedItems.ImageOptions.SvgImage = CType((resources.GetObject("btnHideSelectedItems.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.btnHideSelectedItems.Name = "btnHideSelectedItems"
            Me.btnHideSelectedItems.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' ButtonItemCopy
            ' 
            Me.ButtonItemCopy.Caption = "Copy"
            Me.ButtonItemCopy.Id = 38
            Me.ButtonItemCopy.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemCopy.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemCopy.Name = "ButtonItemCopy"
            Me.ButtonItemCopy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            toolTipItem1.Text = "The command is not implemented"
            superToolTip1.Items.Add(toolTipItem1)
            Me.ButtonItemCopy.SuperTip = superToolTip1
            ' 
            ' ButtonItemPaste
            ' 
            Me.ButtonItemPaste.Caption = "Paste"
            Me.ButtonItemPaste.Id = 39
            Me.ButtonItemPaste.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemPaste.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemPaste.Name = "ButtonItemPaste"
            Me.ButtonItemPaste.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' ButtonItemCut
            ' 
            Me.ButtonItemCut.Caption = "Cut"
            Me.ButtonItemCut.Id = 40
            Me.ButtonItemCut.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemCut.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemCut.ImageOptions.SvgImageSize = New System.Drawing.Size(8, 8)
            Me.ButtonItemCut.Name = "ButtonItemCut"
            Me.ButtonItemCut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' btnCopyItem
            ' 
            Me.btnCopyItem.Caption = "Copy path"
            Me.btnCopyItem.Enabled = False
            Me.btnCopyItem.Id = 41
            Me.btnCopyItem.ImageOptions.SvgImage = CType((resources.GetObject("btnCopyItem.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.btnCopyItem.ImageOptions.SvgImageSize = New System.Drawing.Size(8, 8)
            Me.btnCopyItem.Name = "btnCopyItem"
            Me.btnCopyItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            AddHandler Me.btnCopyItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnCopyPathItemClick)
            ' 
            ' ButtonItemMoveTo
            ' 
            Me.ButtonItemMoveTo.Caption = "Move to"
            Me.ButtonItemMoveTo.Enabled = False
            Me.ButtonItemMoveTo.Id = 43
            Me.ButtonItemMoveTo.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemMoveTo.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemMoveTo.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemDocuments), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemMusic), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemVideos), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemPictures), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemChooseLocation, True)})
            Me.ButtonItemMoveTo.Name = "ButtonItemMoveTo"
            Me.ButtonItemMoveTo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' ButtonItemDocuments
            ' 
            Me.ButtonItemDocuments.Caption = "Documents"
            Me.ButtonItemDocuments.Id = 106
            Me.ButtonItemDocuments.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemDocuments.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemDocuments.Name = "ButtonItemDocuments"
            ' 
            ' ButtonItemMusic
            ' 
            Me.ButtonItemMusic.Caption = "Music"
            Me.ButtonItemMusic.Id = 107
            Me.ButtonItemMusic.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemMusic.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemMusic.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.ButtonItemMusic.Name = "ButtonItemMusic"
            ' 
            ' ButtonItemVideos
            ' 
            Me.ButtonItemVideos.Caption = "Videos"
            Me.ButtonItemVideos.Id = 108
            Me.ButtonItemVideos.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemVideos.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemVideos.Name = "ButtonItemVideos"
            ' 
            ' ButtonItemPictures
            ' 
            Me.ButtonItemPictures.Caption = "Pictures"
            Me.ButtonItemPictures.Id = 109
            Me.ButtonItemPictures.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemPictures.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemPictures.Name = "ButtonItemPictures"
            ' 
            ' ButtonItemChooseLocation
            ' 
            Me.ButtonItemChooseLocation.Caption = "Choose location..."
            Me.ButtonItemChooseLocation.Id = 110
            Me.ButtonItemChooseLocation.Name = "ButtonItemChooseLocation"
            ' 
            ' ButtonItemCopyTo
            ' 
            Me.ButtonItemCopyTo.Caption = "Copy to"
            Me.ButtonItemCopyTo.Enabled = False
            Me.ButtonItemCopyTo.Id = 44
            Me.ButtonItemCopyTo.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemCopyTo.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemCopyTo.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemDocuments), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemMusic), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemVideos), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemPictures), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemChooseLocation, True)})
            Me.ButtonItemCopyTo.Name = "ButtonItemCopyTo"
            Me.ButtonItemCopyTo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' ButtonItemRename
            ' 
            Me.ButtonItemRename.Caption = "Rename"
            Me.ButtonItemRename.Id = 46
            Me.ButtonItemRename.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemRename.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemRename.Name = "ButtonItemRename"
            Me.ButtonItemRename.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' ButtonItemNewFolder
            ' 
            Me.ButtonItemNewFolder.Caption = "New folder"
            Me.ButtonItemNewFolder.Id = 47
            Me.ButtonItemNewFolder.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemNewFolder.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemNewFolder.Name = "ButtonItemNewFolder"
            Me.ButtonItemNewFolder.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' ButtonItemNewItem
            ' 
            Me.ButtonItemNewItem.Caption = "New item"
            Me.ButtonItemNewItem.Id = 48
            Me.ButtonItemNewItem.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemNewItem.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemNewItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewFolder), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewShortcut), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewBitmapImage), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewContact), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewJournalDocument), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewRichTextDocument), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemNewTextDocument), New DevExpress.XtraBars.LinkPersistInfo(Me.ButtonItemCompressedFolder)})
            Me.ButtonItemNewItem.Name = "ButtonItemNewItem"
            Me.ButtonItemNewItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' ButtonItemNewShortcut
            ' 
            Me.ButtonItemNewShortcut.Caption = "Shortcut"
            Me.ButtonItemNewShortcut.Id = 120
            Me.ButtonItemNewShortcut.Name = "ButtonItemNewShortcut"
            ' 
            ' ButtonItemNewBitmapImage
            ' 
            Me.ButtonItemNewBitmapImage.Caption = "Bitmap image"
            Me.ButtonItemNewBitmapImage.Id = 121
            Me.ButtonItemNewBitmapImage.Name = "ButtonItemNewBitmapImage"
            ' 
            ' ButtonItemNewContact
            ' 
            Me.ButtonItemNewContact.Caption = "Contact"
            Me.ButtonItemNewContact.Id = 122
            Me.ButtonItemNewContact.Name = "ButtonItemNewContact"
            ' 
            ' ButtonItemNewJournalDocument
            ' 
            Me.ButtonItemNewJournalDocument.Caption = "Journal document"
            Me.ButtonItemNewJournalDocument.Id = 123
            Me.ButtonItemNewJournalDocument.Name = "ButtonItemNewJournalDocument"
            ' 
            ' ButtonItemNewRichTextDocument
            ' 
            Me.ButtonItemNewRichTextDocument.Caption = "Rich text document"
            Me.ButtonItemNewRichTextDocument.Id = 124
            Me.ButtonItemNewRichTextDocument.Name = "ButtonItemNewRichTextDocument"
            ' 
            ' ButtonItemNewTextDocument
            ' 
            Me.ButtonItemNewTextDocument.Caption = "Text document"
            Me.ButtonItemNewTextDocument.Id = 125
            Me.ButtonItemNewTextDocument.Name = "ButtonItemNewTextDocument"
            ' 
            ' ButtonItemCompressedFolder
            ' 
            Me.ButtonItemCompressedFolder.Caption = "Compressed (zipped) folder"
            Me.ButtonItemCompressedFolder.Id = 126
            Me.ButtonItemCompressedFolder.Name = "ButtonItemCompressedFolder"
            ' 
            ' ButtonItemEdit
            ' 
            Me.ButtonItemEdit.Caption = "Edit"
            Me.ButtonItemEdit.Id = 52
            Me.ButtonItemEdit.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemEdit.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemEdit.Name = "ButtonItemEdit"
            Me.ButtonItemEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' ButtonItemSelectAll
            ' 
            Me.ButtonItemSelectAll.Caption = "Select all"
            Me.ButtonItemSelectAll.Id = 54
            Me.ButtonItemSelectAll.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemSelectAll.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemSelectAll.Name = "ButtonItemSelectAll"
            Me.ButtonItemSelectAll.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            AddHandler Me.ButtonItemSelectAll.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnSelectAllItemClick)
            ' 
            ' btnSelectNone
            ' 
            Me.btnSelectNone.Caption = "Select none"
            Me.btnSelectNone.Id = 55
            Me.btnSelectNone.ImageOptions.SvgImage = CType((resources.GetObject("btnSelectNone.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.btnSelectNone.Name = "btnSelectNone"
            Me.btnSelectNone.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            AddHandler Me.btnSelectNone.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnSelectNoneItemClick)
            ' 
            ' ButtonItemInvertSelection
            ' 
            Me.ButtonItemInvertSelection.Caption = "Invert selection"
            Me.ButtonItemInvertSelection.Id = 56
            Me.ButtonItemInvertSelection.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemInvertSelection.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemInvertSelection.Name = "ButtonItemInvertSelection"
            Me.ButtonItemInvertSelection.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            AddHandler Me.ButtonItemInvertSelection.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnInvertSelectionItemClick)
            ' 
            ' ButtonItemRemoveProperties
            ' 
            Me.ButtonItemRemoveProperties.Caption = "Remove properties"
            Me.ButtonItemRemoveProperties.Enabled = False
            Me.ButtonItemRemoveProperties.Id = 98
            Me.ButtonItemRemoveProperties.Name = "ButtonItemRemoveProperties"
            ' 
            ' ButtonItemDelete
            ' 
            Me.ButtonItemDelete.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.ButtonItemDelete.Caption = "Delete"
            Me.ButtonItemDelete.DropDownControl = Me.PopupMenuDeleteButton
            Me.ButtonItemDelete.Id = 99
            Me.ButtonItemDelete.ImageOptions.SvgImage = CType((resources.GetObject("ButtonItemDelete.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ButtonItemDelete.Name = "ButtonItemDelete"
            Me.ButtonItemDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' PopupMenuDeleteButton
            ' 
            Me.PopupMenuDeleteButton.ItemLinks.Add(Me.ButtonItemRecycle)
            Me.PopupMenuDeleteButton.ItemLinks.Add(Me.ButtonItemPermanentlyDelete)
            Me.PopupMenuDeleteButton.ItemLinks.Add(Me.ButtonItemShowRecycleConfirmation, True)
            Me.PopupMenuDeleteButton.Name = "PopupMenuDeleteButton"
            Me.PopupMenuDeleteButton.Ribbon = Me.RibbonControl
            ' 
            ' ButtonItemRecycle
            ' 
            Me.ButtonItemRecycle.Caption = "Recycle"
            Me.ButtonItemRecycle.Id = 100
            Me.ButtonItemRecycle.Name = "ButtonItemRecycle"
            ' 
            ' ButtonItemPermanentlyDelete
            ' 
            Me.ButtonItemPermanentlyDelete.Caption = "Peramnently delete"
            Me.ButtonItemPermanentlyDelete.Id = 101
            Me.ButtonItemPermanentlyDelete.Name = "ButtonItemPermanentlyDelete"
            ' 
            ' ButtonItemShowRecycleConfirmation
            ' 
            Me.ButtonItemShowRecycleConfirmation.Caption = "Show recycle confirmation"
            Me.ButtonItemShowRecycleConfirmation.Id = 103
            Me.ButtonItemShowRecycleConfirmation.Name = "ButtonItemShowRecycleConfirmation"
            ' 
            ' btnOpen
            ' 
            Me.btnOpen.Caption = "Open"
            Me.btnOpen.Enabled = False
            Me.btnOpen.Id = 134
            Me.btnOpen.ImageOptions.SvgImage = CType((resources.GetObject("btnOpen.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.btnOpen.Name = "btnOpen"
            Me.btnOpen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            AddHandler Me.btnOpen.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnOpenItemClick)
            ' 
            ' rgbiViewStyle
            ' 
            Me.rgbiViewStyle.Caption = "View"
            ' 
            ' 
            ' 
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.rgbiViewStyle.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.rgbiViewStyle.Gallery.ColumnCount = 3
            Me.rgbiViewStyle.Gallery.DrawImageBackground = False
            galleryItemGroup1.Caption = "ViewStyleGroup"
            galleryItem1.Caption = "Extra large view"
            galleryItem1.ImageOptions.SvgImage = CType((resources.GetObject("resource.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            galleryItem1.Tag = 1
            galleryItem2.Caption = "Large icons"
            galleryItem2.Checked = True
            galleryItem2.ImageOptions.SvgImage = CType((resources.GetObject("resource.SvgImage1")), DevExpress.Utils.Svg.SvgImage)
            galleryItem2.Tag = 2
            galleryItem3.Caption = "Medium icons"
            galleryItem3.ImageOptions.SvgImage = CType((resources.GetObject("resource.SvgImage2")), DevExpress.Utils.Svg.SvgImage)
            galleryItem3.Tag = 3
            galleryItem4.Caption = "Small icons"
            galleryItem4.ImageOptions.SvgImage = CType((resources.GetObject("resource.SvgImage3")), DevExpress.Utils.Svg.SvgImage)
            galleryItem4.Tag = 4
            galleryItem5.Caption = "List"
            galleryItem5.ImageOptions.SvgImage = CType((resources.GetObject("resource.SvgImage4")), DevExpress.Utils.Svg.SvgImage)
            galleryItem5.Tag = 6
            galleryItem6.Caption = "Tiles"
            galleryItem6.ImageOptions.SvgImage = CType((resources.GetObject("resource.SvgImage5")), DevExpress.Utils.Svg.SvgImage)
            galleryItem6.Tag = 5
            galleryItem7.Caption = "Content"
            galleryItem7.ImageOptions.SvgImage = CType((resources.GetObject("resource.SvgImage6")), DevExpress.Utils.Svg.SvgImage)
            galleryItem7.Tag = 7
            galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {galleryItem1, galleryItem2, galleryItem3, galleryItem4, galleryItem5, galleryItem6, galleryItem7})
            Me.rgbiViewStyle.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup1})
            Me.rgbiViewStyle.Gallery.ImageSize = New System.Drawing.Size(18, 18)
            Me.rgbiViewStyle.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
            Me.rgbiViewStyle.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            skinPaddingEdges1.Bottom = -3
            skinPaddingEdges1.Top = -3
            Me.rgbiViewStyle.Gallery.ItemImagePadding = skinPaddingEdges1
            skinPaddingEdges2.Bottom = -1
            skinPaddingEdges2.Top = -1
            Me.rgbiViewStyle.Gallery.ItemTextPadding = skinPaddingEdges2
            Me.rgbiViewStyle.Gallery.ShowItemText = True
            Me.rgbiViewStyle.Id = 141
            Me.rgbiViewStyle.Name = "rgbiViewStyle"
            AddHandler Me.rgbiViewStyle.GalleryItemCheckedChanged, New DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(AddressOf Me.OnViewStyleGalleryItemCheckedChanged)
            AddHandler Me.rgbiViewStyle.GalleryInitDropDownGallery, New DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(AddressOf Me.OnRgbiViewStyleInitDropDown)
            ' 
            ' ContextItemOpen
            ' 
            Me.ContextItemOpen.Caption = "Open"
            Me.ContextItemOpen.Id = 151
            Me.ContextItemOpen.ItemAppearance.Disabled.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.ContextItemOpen.ItemAppearance.Disabled.Options.UseFont = True
            Me.ContextItemOpen.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.ContextItemOpen.ItemAppearance.Hovered.Options.UseFont = True
            Me.ContextItemOpen.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.ContextItemOpen.ItemAppearance.Normal.Options.UseFont = True
            Me.ContextItemOpen.ItemAppearance.Pressed.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.ContextItemOpen.ItemAppearance.Pressed.Options.UseFont = True
            Me.ContextItemOpen.Name = "ContextItemOpen"
            AddHandler Me.ContextItemOpen.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnOpenItemClick)
            ' 
            ' ContextItemCut
            ' 
            Me.ContextItemCut.Caption = "Cut"
            Me.ContextItemCut.Id = 158
            Me.ContextItemCut.Name = "ContextItemCut"
            ' 
            ' ContextItemCopy
            ' 
            Me.ContextItemCopy.Caption = "Copy"
            Me.ContextItemCopy.Id = 159
            Me.ContextItemCopy.Name = "ContextItemCopy"
            ' 
            ' ContextItemPaste
            ' 
            Me.ContextItemPaste.Caption = "Paste"
            Me.ContextItemPaste.Id = 160
            Me.ContextItemPaste.Name = "ContextItemPaste"
            ' 
            ' ContextItemDelete
            ' 
            Me.ContextItemDelete.Caption = "Delete"
            Me.ContextItemDelete.Id = 162
            Me.ContextItemDelete.Name = "ContextItemDelete"
            ' 
            ' ContextItemRename
            ' 
            Me.ContextItemRename.Caption = "Rename"
            Me.ContextItemRename.Id = 163
            Me.ContextItemRename.Name = "ContextItemRename"
            ' 
            ' PageHome
            ' 
            Me.PageHome.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PageGroupClipboard, Me.PageGroupOrganize, Me.PageGroupNew, Me.PageGroupOpen, Me.PageGroupSelect})
            Me.PageHome.Name = "PageHome"
            Me.PageHome.Text = "Home"
            ' 
            ' PageGroupClipboard
            ' 
            Me.PageGroupClipboard.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.PageGroupClipboard.ItemLinks.Add(Me.ButtonItemCopy)
            Me.PageGroupClipboard.ItemLinks.Add(Me.ButtonItemPaste)
            Me.PageGroupClipboard.ItemLinks.Add(Me.ButtonItemCut)
            Me.PageGroupClipboard.ItemLinks.Add(Me.btnCopyItem)
            Me.PageGroupClipboard.Name = "PageGroupClipboard"
            Me.PageGroupClipboard.Text = "Clipboard"
            ' 
            ' PageGroupOrganize
            ' 
            Me.PageGroupOrganize.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.PageGroupOrganize.ItemLinks.Add(Me.ButtonItemMoveTo)
            Me.PageGroupOrganize.ItemLinks.Add(Me.ButtonItemCopyTo)
            Me.PageGroupOrganize.ItemLinks.Add(Me.ButtonItemDelete, True)
            Me.PageGroupOrganize.ItemLinks.Add(Me.ButtonItemRename)
            Me.PageGroupOrganize.Name = "PageGroupOrganize"
            Me.PageGroupOrganize.Text = "Organize"
            ' 
            ' PageGroupNew
            ' 
            Me.PageGroupNew.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.PageGroupNew.ItemLinks.Add(Me.ButtonItemNewFolder)
            Me.PageGroupNew.ItemLinks.Add(Me.ButtonItemNewItem)
            Me.PageGroupNew.Name = "PageGroupNew"
            Me.PageGroupNew.Text = "New"
            ' 
            ' PageGroupOpen
            ' 
            Me.PageGroupOpen.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.PageGroupOpen.ItemLinks.Add(Me.btnOpen)
            Me.PageGroupOpen.ItemLinks.Add(Me.ButtonItemEdit)
            Me.PageGroupOpen.Name = "PageGroupOpen"
            Me.PageGroupOpen.Text = "Open"
            ' 
            ' PageGroupSelect
            ' 
            Me.PageGroupSelect.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.PageGroupSelect.ItemLinks.Add(Me.ButtonItemSelectAll)
            Me.PageGroupSelect.ItemLinks.Add(Me.btnSelectNone)
            Me.PageGroupSelect.ItemLinks.Add(Me.ButtonItemInvertSelection)
            Me.PageGroupSelect.Name = "PageGroupSelect"
            Me.PageGroupSelect.Text = "Select"
            ' 
            ' PageView
            ' 
            Me.PageView.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PageGroupViewPanes, Me.PageGroupViewLayouts, Me.PageGroupViewShowHide})
            Me.PageView.Name = "PageView"
            Me.PageView.Text = "View"
            ' 
            ' PageGroupViewPanes
            ' 
            Me.PageGroupViewPanes.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.PageGroupViewPanes.ItemLinks.Add(Me.ButtonItemNavigationPane)
            Me.PageGroupViewPanes.Name = "PageGroupViewPanes"
            Me.PageGroupViewPanes.Text = "Panes"
            ' 
            ' PageGroupViewLayouts
            ' 
            Me.PageGroupViewLayouts.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.PageGroupViewLayouts.ItemLinks.Add(Me.rgbiViewStyle)
            Me.PageGroupViewLayouts.Name = "PageGroupViewLayouts"
            Me.PageGroupViewLayouts.Text = "Layouts"
            ' 
            ' PageGroupViewShowHide
            ' 
            Me.PageGroupViewShowHide.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.PageGroupViewShowHide.ItemLinks.Add(Me.ButtonItemItemCheckBoxes)
            Me.PageGroupViewShowHide.ItemLinks.Add(Me.ButtonItemFileNameExtensions)
            Me.PageGroupViewShowHide.ItemLinks.Add(Me.ButtonItemHiddenItems)
            Me.PageGroupViewShowHide.ItemLinks.Add(Me.btnHideSelectedItems)
            Me.PageGroupViewShowHide.Name = "PageGroupViewShowHide"
            Me.PageGroupViewShowHide.Text = "Show/Hide"
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' repositoryItemRadioGroup1
            ' 
            Me.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1"
            ' 
            ' repositoryItemTextEdit2
            ' 
            Me.repositoryItemTextEdit2.AutoHeight = False
            Me.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2"
            ' 
            ' navBar
            ' 
            Me.navBar.ActiveGroup = Me.groupFavorites
            Me.navBar.Appearance.GroupHeader.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.navBar.Appearance.GroupHeader.Options.UseFont = True
            Me.navBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.navBar.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None
            Me.navBar.ExplorerBarGroupOuterIndent = 10
            Me.navBar.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.groupFavorites, Me.groupLibraries})
            Me.navBar.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navPanelItemDesktop, Me.navPanelItemDownloads, Me.navPanelItemRecent, Me.navPanelItemDocuments, Me.navPanelItemMusic, Me.navPanelItemPictures, Me.navPanelItemVideos})
            Me.navBar.LinkInterval = 0
            Me.navBar.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl
            Me.navBar.Location = New System.Drawing.Point(632, 2)
            Me.navBar.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
            Me.navBar.Name = "navBar"
            Me.navBar.OptionsNavPane.ExpandedWidth = 190
            Me.navBar.Size = New System.Drawing.Size(190, 309)
            Me.navBar.TabIndex = 1
            Me.navBar.Text = "navigationPanel"
            AddHandler Me.navBar.LinkClicked, New DevExpress.XtraNavBar.NavBarLinkEventHandler(AddressOf Me.OnNavPanelLinkClicked)
            ' 
            ' groupFavorites
            ' 
            Me.groupFavorites.Caption = "Favorites"
            Me.groupFavorites.Expanded = True
            Me.groupFavorites.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemDesktop), New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemDownloads), New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemRecent)})
            Me.groupFavorites.Name = "groupFavorites"
            ' 
            ' navPanelItemDesktop
            ' 
            Me.navPanelItemDesktop.Caption = "Desktop"
            Me.navPanelItemDesktop.Name = "navPanelItemDesktop"
            ' 
            ' navPanelItemDownloads
            ' 
            Me.navPanelItemDownloads.Caption = "Downloads"
            Me.navPanelItemDownloads.Name = "navPanelItemDownloads"
            ' 
            ' navPanelItemRecent
            ' 
            Me.navPanelItemRecent.Caption = "Recent places"
            Me.navPanelItemRecent.Name = "navPanelItemRecent"
            ' 
            ' groupLibraries
            ' 
            Me.groupLibraries.Caption = "Libraries"
            Me.groupLibraries.Expanded = True
            Me.groupLibraries.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemDocuments), New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemMusic), New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemPictures), New DevExpress.XtraNavBar.NavBarItemLink(Me.navPanelItemVideos)})
            Me.groupLibraries.Name = "groupLibraries"
            ' 
            ' navPanelItemDocuments
            ' 
            Me.navPanelItemDocuments.Caption = "Documents"
            Me.navPanelItemDocuments.Name = "navPanelItemDocuments"
            ' 
            ' navPanelItemMusic
            ' 
            Me.navPanelItemMusic.Caption = "Music"
            Me.navPanelItemMusic.Name = "navPanelItemMusic"
            ' 
            ' navPanelItemPictures
            ' 
            Me.navPanelItemPictures.Caption = "Pictures"
            Me.navPanelItemPictures.Name = "navPanelItemPictures"
            ' 
            ' navPanelItemVideos
            ' 
            Me.navPanelItemVideos.Caption = "Videos"
            Me.navPanelItemVideos.Name = "navPanelItemVideos"
            ' 
            ' navigationPanel
            ' 
            Me.navigationPanel.Appearance.Options.UseBackColor = True
            Me.navigationPanel.AutoSize = True
            Me.navigationPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.navigationPanel.Columns.AddRange(New DevExpress.Utils.Layout.TablePanelColumn() {New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 30F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 30F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 30F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 30F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 9F), New DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 272F)})
            Me.navigationPanel.Controls.Add(Me.btnUpTo)
            Me.navigationPanel.Controls.Add(Me.btnNavigationHistory)
            Me.navigationPanel.Controls.Add(Me.editBreadCrumb)
            Me.navigationPanel.Controls.Add(Me.editSearch)
            Me.navigationPanel.Controls.Add(Me.btnForward)
            Me.navigationPanel.Controls.Add(Me.btnBack)
            Me.navigationPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.navigationPanel.LabelVertAlignment = DevExpress.Utils.Layout.LabelVertAlignment.Center
            Me.navigationPanel.Location = New System.Drawing.Point(0, 150)
            Me.navigationPanel.Name = "navigationPanel"
            Me.navigationPanel.Padding = New System.Windows.Forms.Padding(5, 0, 12, 0)
            Me.navigationPanel.Rows.AddRange(New DevExpress.Utils.Layout.TablePanelRow() {New DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)})
            Me.navigationPanel.Size = New System.Drawing.Size(824, 36)
            Me.navigationPanel.TabIndex = 3
            ' 
            ' btnUpTo
            ' 
            Me.btnUpTo.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.btnUpTo.Appearance.ImageIndex = 5
            Me.btnUpTo.Appearance.Options.UseImageIndex = True
            Me.btnUpTo.Appearance.Options.UseImageList = True
            Me.btnUpTo.AppearanceHovered.ImageIndex = 2
            Me.btnUpTo.AppearanceHovered.Options.UseImageIndex = True
            Me.btnUpTo.AppearancePressed.ImageIndex = 8
            Me.btnUpTo.AppearancePressed.Options.UseImageIndex = True
            Me.btnUpTo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.btnUpTo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.navigationPanel.SetColumn(Me.btnUpTo, 3)
            Me.btnUpTo.ImageOptions.SvgImage = CType((resources.GetObject("btnUpTo.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.btnUpTo.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.btnUpTo.Location = New System.Drawing.Point(79, 8)
            Me.btnUpTo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.btnUpTo.Name = "btnUpTo"
            Me.navigationPanel.SetRow(Me.btnUpTo, 0)
            Me.btnUpTo.Size = New System.Drawing.Size(20, 20)
            Me.btnUpTo.TabIndex = 7
            AddHandler Me.btnUpTo.Click, New System.EventHandler(AddressOf Me.OnUpButtonClick)
            ' 
            ' btnNavigationHistory
            ' 
            Me.btnNavigationHistory.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.btnNavigationHistory.Appearance.ImageIndex = 2
            Me.btnNavigationHistory.Appearance.Options.UseImageIndex = True
            Me.btnNavigationHistory.Appearance.Options.UseImageList = True
            Me.btnNavigationHistory.AppearanceHovered.ImageIndex = 1
            Me.btnNavigationHistory.AppearanceHovered.Options.UseImageIndex = True
            Me.btnNavigationHistory.AppearancePressed.ImageIndex = 3
            Me.btnNavigationHistory.AppearancePressed.Options.UseImageIndex = True
            Me.btnNavigationHistory.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.btnNavigationHistory.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.navigationPanel.SetColumn(Me.btnNavigationHistory, 2)
            Me.btnNavigationHistory.ImageOptions.SvgImage = CType((resources.GetObject("btnNavigationHistory.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.btnNavigationHistory.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.btnNavigationHistory.Location = New System.Drawing.Point(55, 8)
            Me.btnNavigationHistory.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.btnNavigationHistory.Name = "btnNavigationHistory"
            Me.navigationPanel.SetRow(Me.btnNavigationHistory, 0)
            Me.btnNavigationHistory.Size = New System.Drawing.Size(20, 20)
            Me.btnNavigationHistory.TabIndex = 8
            AddHandler Me.btnNavigationHistory.Click, New System.EventHandler(AddressOf Me.OnNavigationMenuButtonClick)
            ' 
            ' editBreadCrumb
            ' 
            Me.navigationPanel.SetColumn(Me.editBreadCrumb, 4)
            Me.editBreadCrumb.Dock = System.Windows.Forms.DockStyle.Fill
            Me.editBreadCrumb.Location = New System.Drawing.Point(101, 6)
            Me.editBreadCrumb.Margin = New System.Windows.Forms.Padding(0, 6, 3, 6)
            Me.editBreadCrumb.MenuManager = Me.RibbonControl
            Me.editBreadCrumb.Name = "editBreadCrumb"
            Me.editBreadCrumb.Properties.AutoHeight = False
            editorButtonImageOptions1.SvgImageSize = New System.Drawing.Size(8, 8)
            Me.editBreadCrumb.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.SpinDown, "", 18, True, True, False, editorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Redo, "", 15, True, True, False, editorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.editBreadCrumb.Properties.DropDownRows = 12
            Me.editBreadCrumb.Properties.ImageIndex = 0
            Me.editBreadCrumb.Properties.Images = Me.images
            breadCrumbNode1.Caption = "Root"
            breadCrumbNode1.Persistent = True
            breadCrumbNode1.PopulateOnDemand = True
            breadCrumbNode1.ShowCaption = False
            breadCrumbNode1.Value = "Root"
            breadCrumbNode2.Caption = "Computer"
            breadCrumbNode2.Persistent = True
            breadCrumbNode2.PopulateOnDemand = True
            breadCrumbNode2.Value = "Computer"
            Me.editBreadCrumb.Properties.Nodes.AddRange(New DevExpress.XtraEditors.BreadCrumbNode() {breadCrumbNode1, breadCrumbNode2})
            Me.editBreadCrumb.Properties.RootImageIndex = 0
            Me.editBreadCrumb.Properties.SortNodesByCaption = True
            AddHandler Me.editBreadCrumb.Properties.RootGlyphClick, New System.EventHandler(AddressOf Me.OnBreadCrumbRootGlyphClick)
            AddHandler Me.editBreadCrumb.Properties.QueryChildNodes, New DevExpress.XtraEditors.BreadCrumbQueryChildNodesEventHandler(AddressOf Me.OnBreadCrumbQueryChildNodes)
            AddHandler Me.editBreadCrumb.Properties.ValidatePath, New DevExpress.XtraEditors.BreadCrumbValidatePathEventHandler(AddressOf Me.OnBreadCrumbValidatePath)
            AddHandler Me.editBreadCrumb.Properties.NewNodeAdding, New DevExpress.XtraEditors.BreadCrumbNewNodeAddingEventHandler(AddressOf Me.OnBreadCrumbNewNodeAdding)
            Me.navigationPanel.SetRow(Me.editBreadCrumb, 0)
            Me.editBreadCrumb.Size = New System.Drawing.Size(427, 24)
            Me.editBreadCrumb.TabIndex = 3
            AddHandler Me.editBreadCrumb.PathChanged, New DevExpress.XtraEditors.BreadCrumbPathChangedEventHandler(AddressOf Me.OnBreadCrumbPathChanged)
            ' 
            ' images
            ' 
            Me.images.Add("open", "image://svgimages/actions/open.svg")
            ' 
            ' editSearch
            ' 
            Me.navigationPanel.SetColumn(Me.editSearch, 6)
            Me.editSearch.Location = New System.Drawing.Point(540, 6)
            Me.editSearch.Margin = New System.Windows.Forms.Padding(0, 6, 0, 6)
            Me.editSearch.MenuManager = Me.RibbonControl
            Me.editSearch.Name = "editSearch"
            editorButtonImageOptions3.SvgImage = CType((resources.GetObject("editorButtonImageOptions3.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            editorButtonImageOptions3.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.editSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, editorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.navigationPanel.SetRow(Me.editSearch, 0)
            Me.editSearch.Size = New System.Drawing.Size(272, 24)
            Me.editSearch.TabIndex = 4
            AddHandler Me.editSearch.TextChanged, New System.EventHandler(AddressOf Me.OnEditSearchTextChanged)
            ' 
            ' btnForward
            ' 
            Me.btnForward.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.btnForward.Appearance.ImageIndex = 4
            Me.btnForward.Appearance.Options.UseImageIndex = True
            Me.btnForward.Appearance.Options.UseImageList = True
            Me.btnForward.AppearanceHovered.ImageIndex = 1
            Me.btnForward.AppearanceHovered.Options.UseImageIndex = True
            Me.btnForward.AppearancePressed.ImageIndex = 7
            Me.btnForward.AppearancePressed.Options.UseImageIndex = True
            Me.btnForward.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.btnForward.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.navigationPanel.SetColumn(Me.btnForward, 1)
            Me.btnForward.ImageOptions.SvgImage = CType((resources.GetObject("btnForward.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.btnForward.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.btnForward.Location = New System.Drawing.Point(31, 8)
            Me.btnForward.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.btnForward.Name = "btnForward"
            Me.navigationPanel.SetRow(Me.btnForward, 0)
            Me.btnForward.Size = New System.Drawing.Size(20, 20)
            Me.btnForward.TabIndex = 6
            AddHandler Me.btnForward.Click, New System.EventHandler(AddressOf Me.OnNextButtonClick)
            ' 
            ' btnBack
            ' 
            Me.btnBack.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.btnBack.Appearance.ImageIndex = 3
            Me.btnBack.Appearance.Options.UseImageIndex = True
            Me.btnBack.Appearance.Options.UseImageList = True
            Me.btnBack.AppearanceHovered.ImageIndex = 0
            Me.btnBack.AppearanceHovered.Options.UseImageIndex = True
            Me.btnBack.AppearancePressed.ImageIndex = 6
            Me.btnBack.AppearancePressed.Options.UseImageIndex = True
            Me.btnBack.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.btnBack.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.navigationPanel.SetColumn(Me.btnBack, 0)
            Me.btnBack.ImageOptions.SvgImage = CType((resources.GetObject("btnBack.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.btnBack.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.btnBack.Location = New System.Drawing.Point(7, 8)
            Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.btnBack.Name = "btnBack"
            Me.navigationPanel.SetRow(Me.btnBack, 0)
            Me.btnBack.Size = New System.Drawing.Size(20, 20)
            Me.btnBack.TabIndex = 5
            AddHandler Me.btnBack.Click, New System.EventHandler(AddressOf Me.OnBackButtonClick)
            ' 
            ' contentPanel
            ' 
            Me.contentPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.contentPanel.Controls.Add(Me.LayoutControl)
            Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.contentPanel.Location = New System.Drawing.Point(0, 186)
            Me.contentPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.contentPanel.Name = "contentPanel"
            Me.contentPanel.Size = New System.Drawing.Size(824, 313)
            Me.contentPanel.TabIndex = 5
            ' 
            ' LayoutControl
            ' 
            Me.LayoutControl.Controls.Add(Me.gridControl)
            Me.LayoutControl.Controls.Add(Me.navBar)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl.Name = "LayoutControl"
            Me.LayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(318, 324, 836, 529)
            Me.LayoutControl.Root = Me.LayoutControlMainGroup
            Me.LayoutControl.Size = New System.Drawing.Size(824, 313)
            Me.LayoutControl.TabIndex = 3
            Me.LayoutControl.Text = "LayoutControl"
            ' 
            ' gridControl
            ' 
            Me.gridControl.Location = New System.Drawing.Point(2, 2)
            Me.gridControl.MainView = Me.winExplorerView
            Me.gridControl.MenuManager = Me.RibbonControl
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(616, 309)
            Me.gridControl.TabIndex = 2
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.winExplorerView})
            ' 
            ' winExplorerView
            ' 
            Me.winExplorerView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.winExplorerView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.columnName, Me.columnPath, Me.columnCheck, Me.columnGroup, Me.columnImage})
            Me.winExplorerView.ColumnSet.CheckBoxColumn = Me.columnCheck
            Me.winExplorerView.ColumnSet.DescriptionColumn = Me.columnPath
            Me.winExplorerView.ColumnSet.ExtraLargeImageColumn = Me.columnImage
            Me.winExplorerView.ColumnSet.GroupColumn = Me.columnGroup
            Me.winExplorerView.ColumnSet.LargeImageColumn = Me.columnImage
            Me.winExplorerView.ColumnSet.MediumImageColumn = Me.columnImage
            Me.winExplorerView.ColumnSet.SmallImageColumn = Me.columnImage
            Me.winExplorerView.ColumnSet.TextColumn = Me.columnName
            Me.winExplorerView.GridControl = Me.gridControl
            Me.winExplorerView.GroupCount = 1
            Me.winExplorerView.Name = "winExplorerView"
            Me.winExplorerView.OptionsBehavior.Editable = False
            Me.winExplorerView.OptionsSelection.AllowMarqueeSelection = True
            Me.winExplorerView.OptionsSelection.ItemSelectionMode = DevExpress.XtraGrid.Views.WinExplorer.IconItemSelectionMode.Click
            Me.winExplorerView.OptionsSelection.MultiSelect = True
            Me.winExplorerView.OptionsView.ImageLayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch
            Me.winExplorerView.OptionsView.ShowViewCaption = True
            Me.winExplorerView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.columnGroup, DevExpress.Data.ColumnSortOrder.Ascending)})
            AddHandler Me.winExplorerView.ItemClick, New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemClickEventHandler(AddressOf Me.OnWinExplorerViewItemClick)
            AddHandler Me.winExplorerView.ItemDoubleClick, New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemDoubleClickEventHandler(AddressOf Me.OnWinExplorerViewItemDoubleClick)
            AddHandler Me.winExplorerView.SelectionChanged, New DevExpress.Data.SelectionChangedEventHandler(AddressOf Me.OnWinExplorerViewSelectionChanged)
            AddHandler Me.winExplorerView.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.OnWinExplorerViewKeyDown)
            ' 
            ' columnName
            ' 
            Me.columnName.Caption = "columnName"
            Me.columnName.FieldName = "Name"
            Me.columnName.Name = "columnName"
            Me.columnName.Visible = True
            Me.columnName.VisibleIndex = 0
            ' 
            ' columnPath
            ' 
            Me.columnPath.Caption = "columnPath"
            Me.columnPath.FieldName = "Path"
            Me.columnPath.Name = "columnPath"
            Me.columnPath.Visible = True
            Me.columnPath.VisibleIndex = 0
            ' 
            ' columnCheck
            ' 
            Me.columnCheck.Caption = "columnCheck"
            Me.columnCheck.FieldName = "IsCheck"
            Me.columnCheck.Name = "columnCheck"
            Me.columnCheck.Visible = True
            Me.columnCheck.VisibleIndex = 0
            ' 
            ' columnGroup
            ' 
            Me.columnGroup.Caption = "columnGroup"
            Me.columnGroup.FieldName = "Group"
            Me.columnGroup.Name = "columnGroup"
            Me.columnGroup.Visible = True
            Me.columnGroup.VisibleIndex = 0
            ' 
            ' columnImage
            ' 
            Me.columnImage.Caption = "columnImage"
            Me.columnImage.FieldName = "Image"
            Me.columnImage.Name = "columnImage"
            Me.columnImage.Visible = True
            Me.columnImage.VisibleIndex = 0
            ' 
            ' LayoutControlMainGroup
            ' 
            Me.LayoutControlMainGroup.CustomizationFormText = "Root"
            Me.LayoutControlMainGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.LayoutControlMainGroup.GroupBordersVisible = False
            Me.LayoutControlMainGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItemExplorerView, Me.SplitterItem1, Me.liNavPaneRight})
            Me.LayoutControlMainGroup.Name = "Root"
            Me.LayoutControlMainGroup.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 10, 10, 10)
            Me.LayoutControlMainGroup.Size = New System.Drawing.Size(824, 313)
            Me.LayoutControlMainGroup.TextVisible = False
            ' 
            ' LayoutControlItemExplorerView
            ' 
            Me.LayoutControlItemExplorerView.Control = Me.gridControl
            Me.LayoutControlItemExplorerView.CustomizationFormText = "LayoutControlItemExplorerView"
            Me.LayoutControlItemExplorerView.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItemExplorerView.Name = "LayoutControlItemExplorerView"
            Me.LayoutControlItemExplorerView.Size = New System.Drawing.Size(620, 313)
            Me.LayoutControlItemExplorerView.TextVisible = False
            ' 
            ' SplitterItem1
            ' 
            Me.SplitterItem1.CustomizationFormText = "SplitterItem1"
            Me.SplitterItem1.Location = New System.Drawing.Point(620, 0)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(10, 313)
            ' 
            ' liNavPaneRight
            ' 
            Me.liNavPaneRight.Control = Me.navBar
            Me.liNavPaneRight.CustomizationFormText = "LayoutControlItemNavigationPaneRight"
            Me.liNavPaneRight.Location = New System.Drawing.Point(630, 0)
            Me.liNavPaneRight.Name = "LayoutControlItemNavigationPaneRight"
            Me.liNavPaneRight.Size = New System.Drawing.Size(194, 313)
            Me.liNavPaneRight.TextVisible = False
            ' 
            ' itemPopupMenu
            ' 
            Me.itemPopupMenu.ItemLinks.Add(Me.ContextItemOpen)
            Me.itemPopupMenu.ItemLinks.Add(Me.ContextItemCut, True)
            Me.itemPopupMenu.ItemLinks.Add(Me.ContextItemCopy)
            Me.itemPopupMenu.ItemLinks.Add(Me.ContextItemPaste)
            Me.itemPopupMenu.ItemLinks.Add(Me.ContextItemDelete)
            Me.itemPopupMenu.ItemLinks.Add(Me.ContextItemRename)
            Me.itemPopupMenu.Name = "itemPopupMenu"
            Me.itemPopupMenu.Ribbon = Me.RibbonControl
            ' 
            ' navigationMenu
            ' 
            Me.navigationMenu.Name = "navigationMenu"
            Me.navigationMenu.Ribbon = Me.RibbonControl
            ' 
            ' ExplorerView
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.contentPanel)
            Me.Controls.Add(Me.navigationPanel)
            Me.Controls.Add(Me.RibbonControl)
            Me.Name = "ExplorerView"
            Me.Size = New System.Drawing.Size(824, 499)
            CType((Me.repositoryItemTextEdit3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.RibbonControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.PopupMenuDeleteButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemRadioGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTextEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navBar), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPanel.ResumeLayout(False)
            Me.navigationPanel.PerformLayout()
            CType((Me.editBreadCrumb.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.images), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.editSearch.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.contentPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.contentPanel.ResumeLayout(False)
            CType((Me.LayoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.winExplorerView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.LayoutControlMainGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.LayoutControlItemExplorerView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.SplitterItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liNavPaneRight), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.itemPopupMenu), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationMenu), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl

        Private PageHome As DevExpress.XtraBars.Ribbon.RibbonPage

        Private PageView As DevExpress.XtraBars.Ribbon.RibbonPage

        Private PageGroupViewPanes As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private PageGroupViewLayouts As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private PageGroupViewShowHide As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ButtonItemHelp As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemNavigationPane As DevExpress.XtraBars.BarSubItem

        Private ButtonItemItemCheckBoxes As DevExpress.XtraBars.BarCheckItem

        Private ButtonItemFileNameExtensions As DevExpress.XtraBars.BarCheckItem

        Private ButtonItemHiddenItems As DevExpress.XtraBars.BarCheckItem

        Private btnHideSelectedItems As DevExpress.XtraBars.BarButtonItem

        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private navBar As DevExpress.XtraNavBar.NavBarControl

        Private groupFavorites As DevExpress.XtraNavBar.NavBarGroup

        Private navPanelItemDesktop As DevExpress.XtraNavBar.NavBarItem

        Private navPanelItemDownloads As DevExpress.XtraNavBar.NavBarItem

        Private navPanelItemRecent As DevExpress.XtraNavBar.NavBarItem

        Private ButtonCheckItemNavigationPane As DevExpress.XtraBars.BarCheckItem

        Private ButtonItemCopy As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemPaste As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemCut As DevExpress.XtraBars.BarButtonItem

        Private btnCopyItem As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemMoveTo As DevExpress.XtraBars.BarSubItem

        Private ButtonItemCopyTo As DevExpress.XtraBars.BarSubItem

        Private ButtonItemRename As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemNewFolder As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemNewItem As DevExpress.XtraBars.BarSubItem

        Private ButtonItemEdit As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemSelectAll As DevExpress.XtraBars.BarButtonItem

        Private btnSelectNone As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemInvertSelection As DevExpress.XtraBars.BarButtonItem

        Private PageGroupClipboard As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private PageGroupOrganize As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private PageGroupNew As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private PageGroupOpen As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private PageGroupSelect As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private navigationPanel As DevExpress.Utils.Layout.TablePanel

        Private contentPanel As DevExpress.XtraEditors.PanelControl

        Private groupLibraries As DevExpress.XtraNavBar.NavBarGroup

        Private navPanelItemDocuments As DevExpress.XtraNavBar.NavBarItem

        Private navPanelItemMusic As DevExpress.XtraNavBar.NavBarItem

        Private navPanelItemPictures As DevExpress.XtraNavBar.NavBarItem

        Private navPanelItemVideos As DevExpress.XtraNavBar.NavBarItem

        Private ButtonItemRemoveProperties As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemDelete As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemPermanentlyDelete As DevExpress.XtraBars.BarButtonItem

        Private PopupMenuDeleteButton As DevExpress.XtraBars.PopupMenu

        Private ButtonItemRecycle As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemShowRecycleConfirmation As DevExpress.XtraBars.BarCheckItem

        Private ButtonItemDocuments As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemMusic As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemVideos As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemPictures As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemChooseLocation As DevExpress.XtraBars.BarButtonItem

        Private ButtonCheckItemShowFavorites As DevExpress.XtraBars.BarCheckItem

        Private ButtonCheckItemShowLibraries As DevExpress.XtraBars.BarCheckItem

        Private ButtonItemNewShortcut As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemNewBitmapImage As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemNewContact As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemNewJournalDocument As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemNewRichTextDocument As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemNewTextDocument As DevExpress.XtraBars.BarButtonItem

        Private ButtonItemCompressedFolder As DevExpress.XtraBars.BarButtonItem

        Private editSearch As DevExpress.XtraEditors.ButtonEdit

        Private editBreadCrumb As DevExpress.XtraEditors.BreadCrumbEdit

        Private btnOpen As DevExpress.XtraBars.BarButtonItem

        Private repositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup

        Private rgbiViewStyle As DevExpress.XtraBars.RibbonGalleryBarItem

        Private gridControl As DevExpress.XtraGrid.GridControl

        Private winExplorerView As DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView

        Private repositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private repositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private btnBack As DevExpress.XtraEditors.LabelControl

        Private btnForward As DevExpress.XtraEditors.LabelControl

        Private btnUpTo As DevExpress.XtraEditors.LabelControl

        Private LayoutControl As DevExpress.XtraLayout.LayoutControl

        Private LayoutControlMainGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private LayoutControlItemExplorerView As DevExpress.XtraLayout.LayoutControlItem

        Private liNavPaneRight As DevExpress.XtraLayout.LayoutControlItem

        Private SplitterItem1 As DevExpress.XtraLayout.SplitterItem

        Private ContextItemOpen As DevExpress.XtraBars.BarButtonItem

        Private ContextItemCut As DevExpress.XtraBars.BarButtonItem

        Private ContextItemCopy As DevExpress.XtraBars.BarButtonItem

        Private ContextItemPaste As DevExpress.XtraBars.BarButtonItem

        Private ContextItemDelete As DevExpress.XtraBars.BarButtonItem

        Private ContextItemRename As DevExpress.XtraBars.BarButtonItem

        Private columnName As DevExpress.XtraGrid.Columns.GridColumn

        Private columnPath As DevExpress.XtraGrid.Columns.GridColumn

        Private columnCheck As DevExpress.XtraGrid.Columns.GridColumn

        Private columnGroup As DevExpress.XtraGrid.Columns.GridColumn

        Private columnImage As DevExpress.XtraGrid.Columns.GridColumn

        Private itemPopupMenu As DevExpress.XtraBars.PopupMenu

        Private btnNavigationHistory As DevExpress.XtraEditors.LabelControl

        Private navigationMenu As DevExpress.XtraBars.PopupMenu

        Private images As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
