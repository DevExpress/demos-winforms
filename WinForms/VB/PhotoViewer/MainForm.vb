Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Data.Utils
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ColorWheel
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraSplashScreen

Namespace PhotoViewer

    Public Partial Class MainForm
        Inherits RibbonForm

        Public Shared HoverSkinImageSize As Size = New Size(116, 86)

        Public Shared SkinImageSize As Size = New Size(58, 43)

        Public Sub New()
            InitializeComponent()
            InitSkins()
            InitFilters()
            SelectDefaultPage()
            LoadData()
            UpdateItemsEnabledState()
            UpdateAddToLibraryItem(biAddFolder)
            Icon = ResourceImageHelperCore.CreateIconFromResourcesEx("PhotoViewer.AppIcon.ico", GetType(MainForm).Assembly)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Call SplashScreenManager.CloseForm()
        End Sub

        Private viewDataCore As PhotoViewerData

        Private rightClickItemCore As GalleryItem

        Private lastSelectedGroup As NavBarGroup

        Private customizableLinkCore As NavBarItemLink

        Private markedItemsCore As List(Of GalleryItem)

        Protected ReadOnly Property MarkedItems As List(Of GalleryItem)
            Get
                If markedItemsCore Is Nothing Then markedItemsCore = New List(Of GalleryItem)()
                Return markedItemsCore
            End Get
        End Property

        Protected ReadOnly Property ViewData As PhotoViewerData
            Get
                If viewDataCore Is Nothing Then viewDataCore = New PhotoViewerData()
                Return viewDataCore
            End Get
        End Property

        Protected Function GetDataDir() As String
            Dim rootPath As String = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory)
            For i As Integer = 0 To 10 - 1
                Dim fullPath As String = Path.GetFullPath(Path.Combine(rootPath, "Data"))
                If Directory.Exists(fullPath) Then Return fullPath
                rootPath += "\.."
            Next

            Return String.Empty
        End Function

        Protected ReadOnly Property DataPath As String
            Get
                Dim _dataPath As String = Path.Combine(GetDataDir(), "PhotoViewer")
                If Directory.Exists(_dataPath) Then Return _dataPath
                Return String.Empty
            End Get
        End Property

        Protected ReadOnly Property ThumbPath As String
            Get
                Return Path.Combine(DataPath, "Thumbs")
            End Get
        End Property

        Protected ReadOnly Property ViewDataFile As String
            Get
                Return Path.Combine(DataPath, "data.xml")
            End Get
        End Property

        Protected Property RightClickItem As GalleryItem
            Get
                Return rightClickItemCore
            End Get

            Set(ByVal value As GalleryItem)
                rightClickItemCore = value
            End Set
        End Property

        Protected ReadOnly Property SelectedAlbum As AlbumData
            Get
                Dim album As AlbumData = If(CustomizableLink Is Nothing, Nothing, TryCast(CustomizableLink.Item.Tag, AlbumData))
                If album Is Nothing Then album = If(albumGroup.SelectedLink Is Nothing, Nothing, CType(albumGroup.SelectedLink.Item.Tag, AlbumData))
                Return album
            End Get
        End Property

        Protected Property CustomizableLink As NavBarItemLink
            Get
                Return customizableLinkCore
            End Get

            Set(ByVal value As NavBarItemLink)
                customizableLinkCore = value
            End Set
        End Property

        Private Sub SaveData()
            ViewData.FirstRun = False
            ViewData.SaveLayoutToXml(ViewDataFile)
        End Sub

        Private Sub LoadData()
            ViewData.Clear()
            Dim forceProcess As Boolean = False
            If File.Exists(ViewDataFile) Then
                ViewData.RestoreLayoutFromXml(ViewDataFile)
            End If

            If ViewData.FirstRun Then
                GenerateSampleData()
                forceProcess = True
            End If

            InitNavBar()
            UpdateMainGalleryContent(forceProcess)
        End Sub

        Protected Sub UpdateData()
            UpdateData(False)
        End Sub

        Protected Sub UpdateData(ByVal onlyAlbums As Boolean)
            SaveData()
            InitNavBar(onlyAlbums)
        End Sub

        Private Sub InitSkins()
            Call SkinHelper.InitSkinGallery(skinGalleryBarItem, True)
            UserLookAndFeel.Default.SetSkinStyle("Office 2016 Colorful")
        End Sub

        Protected Overridable Sub InitFilters()
            Dim imageSize As Size = Global.PhotoViewer.Properties.Resources.FilterSample.Size
            imageSize.Width = CInt(imageSize.Width * 0.5)
            imageSize.Height = CInt(imageSize.Height * 0.5)
            filtersGallery.Gallery.ImageSize = imageSize
            filtersGallery.Gallery.Images = FilterHelper.GetFiltersSamples(Global.PhotoViewer.Properties.Resources.FilterSample)
            filtersGallery.Gallery.HoverImages = filtersGallery.Gallery.Images
            For Each fInfo As FilterInfo In Filters
                filtersGallery.Gallery.Groups(0).Items.Add(CreateFilterGalleryItem(fInfo))
            Next
        End Sub

        Private Sub InitNavBar()
            InitNavBar(False)
        End Sub

        Private Sub InitNavBar(ByVal onlyAlbums As Boolean)
            navBarControl1.SelectedLink = Nothing
            For Each group As NavBarGroup In navBarControl1.Groups
                If onlyAlbums AndAlso group IsNot albumGroup Then Continue For
                For i As Integer = group.ItemLinks.Count - 1 To 0 Step -1
                    navBarControl1.Items.Remove(group.ItemLinks(i).Item)
                Next
            Next

            navBarControl1.BeginUpdate()
            Try
                For Each album As AlbumData In ViewData.Albums
                    Dim item As NavBarItem = CreateAlbumItem(album)
                    navBarControl1.Items.Add(item)
                    albumGroup.ItemLinks.Add(item)
                Next

                If onlyAlbums Then Return
                For Each folder As PathData In ViewData.Folders
                    Dim item As NavBarItem = CreateFolderItem(folder)
                    If item IsNot Nothing Then
                        navBarControl1.Items.Add(item)
                        foldersGroup.ItemLinks.Add(item)
                    End If
                Next

                For Each file As PathData In ViewData.Others.Files
                    Dim item As NavBarItem = CreateFolderItem(file)
                    If item IsNot Nothing Then
                        navBarControl1.Items.Add(item)
                        othersGroup.ItemLinks.Add(item)
                    End If
                Next
            Finally
                navBarControl1.EndUpdate()
            End Try

            If navBarControl1.Items.Count > 0 Then navBarControl1.SelectedLink = navBarControl1.Items(0).Links(0)
        End Sub

        Private Sub SelectDefaultPage()
            ribbonControl1.SelectedPage = imagePage
        End Sub

        Private Function CreateFilterGalleryItem(ByVal info As FilterInfo) As GalleryItem
            Dim item As GalleryItem = New GalleryItem()
            item.ImageIndex = Filters.IndexOf(info)
            item.HoverImageIndex = item.ImageIndex
            item.Caption = info.Name
            item.Tag = info
            item.Hint = info.Name
            Return item
        End Function

        Private Function CreateFolderItem(ByVal folder As PathData) As NavBarItem
            Dim item As NavBarItem = New NavBarItem()
            item.Caption = folder.Name
            item.Hint = folder.Path
            item.Tag = folder
            AddHandler item.LinkClicked, New NavBarLinkEventHandler(AddressOf OnFolderLinkClicked)
            Return item
        End Function

        Private Function CreateAlbumItem(ByVal album As AlbumData) As NavBarItem
            Dim item As NavBarItem = New NavBarItem()
            item.Caption = album.Name
            item.Hint = album.Description
            item.Tag = album
            AddHandler item.LinkClicked, New NavBarLinkEventHandler(AddressOf OnAlbumLinkClicked)
            Return item
        End Function

        Private Function CreatePhotoGalleryItem(ByVal fileName As String) As GalleryItem
            Dim item As GalleryItem = New GalleryItem()
            item.Caption = Path.GetFileName(fileName)
            item.Hint = fileName
            item.Tag = fileName
            Return item
        End Function

        Private Function CreateFolderGroup(ByVal folder As PathData) As GalleryItemGroup
            Dim group As GalleryItemGroup = New GalleryItemGroup()
            group.Tag = folder
            group.Caption = folder.Name
            group.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch
            group.CaptionControl = CreateFolderGroupCaptionControl(folder)
            Return group
        End Function

        Private Function CreateFolderGroupCaptionControl(ByVal folder As PathData) As Control
            Dim control As FolderGroupCaptionControl = New FolderGroupCaptionControl()
            control.Folder = folder
            control.MainForm = Me
            Return control
        End Function

        Private Function CreateAlbumGroup(ByVal albumData As AlbumData) As GalleryItemGroup
            Dim group As GalleryItemGroup = New GalleryItemGroup()
            group.Tag = albumData
            group.Caption = albumData.Name
            group.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch
            group.CaptionControl = CreateAlbumGroupCaptionControl(albumData)
            Return group
        End Function

        Private Function CreateAlbumGroupCaptionControl(ByVal albumData As AlbumData) As Control
            Dim control As AlbumGroupCaptionControl = New AlbumGroupCaptionControl()
            control.Album = albumData
            control.MainForm = Me
            Return control
        End Function

        Private Function CreateAddToAlbumItem(ByVal album As AlbumData) As BarItem
            Dim item As BarButtonItem = New BarButtonItem(ribbonControl1.Manager, If(album IsNot Nothing, album.Name, "New album..."))
            AddHandler item.ItemClick, New ItemClickEventHandler(AddressOf OnAddToAlbumItemClick)
            item.Tag = album
            Return item
        End Function

        Private Function CreateFilePathData(ByVal fileName As String) As PathData
            Dim pdata As PathData = New PathData()
            pdata.Path = fileName
            pdata.Name = Path.GetFileName(fileName)
            Return pdata
        End Function

        Protected Overridable Sub CreateThumbForFiles(ByVal files As List(Of String), ByVal progressText As String)
            Dim pf As ProgressForm = New ProgressForm()
            pf.ProgressControl.Maximum = files.Count
            pf.ProgressControl.ProgressText = progressText
            pf.Show(Me)
            For Each fileName As String In files
                CreateThumbForFile(fileName)
                pf.ProgressControl.Value += 1
                Call Application.DoEvents()
            Next

            pf.Close()
        End Sub

        Protected Overridable Sub CreateThumbForFile(ByVal fileName As String)
            Dim img As Image = ThumbnailHelper.Default.GetThumbnail(fileName, 208, ThumbPath)
            If img IsNot Nothing Then img.Dispose()
        End Sub

        Protected Overridable Sub CreateThumbsForFolder(ByVal folder As PathData)
            CreateThumbForFiles(GetImagesInFolder(folder), "Processing folder")
        End Sub

        Private Sub OnFolderLinkClicked(ByVal sender As Object, ByVal e As NavBarLinkEventArgs)
        End Sub

        Private Sub OnAlbumLinkClicked(ByVal sender As Object, ByVal e As NavBarLinkEventArgs)
        End Sub

        Private Overloads Sub OnFormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            If File.Exists(ViewDataFile) Then ViewData.SaveLayoutToXml(ViewDataFile)
        End Sub

        Private Sub OnExitButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            If XtraMessageBox.Show(Me, "Exit Application?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Close()
            End If
        End Sub

        Private Sub OnNewAlbumItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            AddNewAlbum()
        End Sub

        Private Sub OnAddFolderItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                If Not IsFolderAdded(folderBrowserDialog1.SelectedPath) Then
                    Dim p As PathData = New PathData()
                    p.Name = Path.GetFileName(folderBrowserDialog1.SelectedPath)
                    p.Path = folderBrowserDialog1.SelectedPath
                    ViewData.Folders.Add(p)
                    CreateThumbsForFolder(p)
                    UpdateData()
                    navBarControl1.SelectedLink = GetLink(p)
                    UpdateMainGalleryContent(True)
                End If

                UpdateAddToLibraryItem(e.Item)
            End If
        End Sub

        Private Function GetLink(ByVal fileName As String) As NavBarItemLink
            For Each link As NavBarItemLink In othersGroup.ItemLinks
                If Equals(CType(link.Item.Tag, PathData).Path, fileName) Then Return link
            Next

            Return Nothing
        End Function

        Private Function GetLinkByTag(ByVal group As NavBarGroup, ByVal tag As Object) As NavBarItemLink
            For Each link As NavBarItemLink In group.ItemLinks
                If link.Item.Tag Is tag Then Return link
            Next

            Return Nothing
        End Function

        Private Function GetLink(ByVal album As AlbumData) As NavBarItemLink
            Return GetLinkByTag(albumGroup, album)
        End Function

        Private Function GetLink(ByVal path As PathData) As NavBarItemLink
            Return GetLinkByTag(foldersGroup, path)
        End Function

        Private Sub OnAddFileClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If imageDialog.ShowDialog() = DialogResult.OK Then
                Dim lastFileName As String = String.Empty
                For Each fileName As String In imageDialog.FileNames
                    If Not IsFileAdded(fileName) Then
                        Dim p As PathData = New PathData()
                        p.Name = Path.GetFileName(fileName)
                        p.Path = fileName
                        ViewData.Others.Files.Add(p)
                    End If

                    lastFileName = fileName
                Next

                CreateThumbForFiles(New List(Of String)(imageDialog.FileNames), "Processing files")
                UpdateData()
                navBarControl1.SelectedLink = GetLink(lastFileName)
                UpdateMainGalleryContent(True)
            End If

            UpdateAddToLibraryItem(e.Item)
        End Sub

        Private Sub OnNavBarControl1SelectedLinkChanged(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventArgs)
            UpdateMainGalleryContent(False)
            lastSelectedGroup = e.Group
        End Sub

        Private Sub OnNavBarControl1MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button <> MouseButtons.Right Then Return
            Dim hi As NavBarHitInfo = navBarControl1.GetViewInfo().CalcHitInfo(e.Location)
            If hi.Link Is Nothing Then
                ribbonControl1.Manager.SetPopupContextMenu(navBarControl1, Nothing)
                Return
            End If

            CustomizableLink = hi.Link
            If hi.Group Is albumGroup Then
                ribbonControl1.Manager.SetPopupContextMenu(navBarControl1, albumPopupMenu)
            ElseIf hi.Group Is foldersGroup Then
                ribbonControl1.Manager.SetPopupContextMenu(navBarControl1, folderPopupMenu)
            End If
        End Sub

        Private Sub OnRemoveAlbumItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CustomizableLink Is Nothing Then Return
            Dim album As AlbumData = CType(customizableLinkCore.Item.Tag, AlbumData)
            RemoveAlbum(album)
        End Sub

        Private Sub OnRemoveFolderItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If CustomizableLink Is Nothing Then Return
            Dim folder As PathData = CType(customizableLinkCore.Item.Tag, PathData)
            RemoveFolder(folder)
        End Sub

        Private Sub OnMainGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            UpdateImageButtonsEnabledState()
            UpdateSelectedPictureEdit(e)
        End Sub

        Private Sub OnMainGalleryMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hi As RibbonHitInfo = mainGallery.CalcHitInfo(e.Location)
            If e.Button = MouseButtons.Right Then
                RightClickItem = hi.GalleryItem
                ribbonControl1.Manager.SetPopupContextMenu(mainGallery, galleryItemMenu)
                Return
            End If
        End Sub

        Private Sub OnMarkItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim contextBtns As ContextItemCollection = mainGallery.Gallery.ContextButtons
            Dim checkBtn As CheckContextButton = TryCast(contextBtns("itemCheck"), CheckContextButton)
            checkBtn.Checked = True
            UnmarkItems()
            MarkItems(mainGallery.Gallery.GetAllItems())
            UpdateImageButtonsEnabledState()
        End Sub

        Private Sub OnSelectionGalleryCustomDrawItemImage(ByVal sender As Object, ByVal e As GalleryItemCustomDrawEventArgs)
            If Not MarkedItems.Contains(e.Item) Then Return
            If e.Item.Image IsNot Nothing Then
                e.Cache.Graphics.DrawImage(e.Item.Image, CType(e.ItemInfo, GalleryItemViewInfo).ImageContentBounds)
            End If

            DrawMarkedIconInSelection(e.Cache, CType(e.ItemInfo, GalleryItemViewInfo).ImageClientBounds)
            e.Handled = True
        End Sub

        Private Sub OnMainGalleryCustomDrawItemImage(ByVal sender As Object, ByVal e As GalleryItemCustomDrawEventArgs)
            If Not MarkedItems.Contains(e.Item) Then Return
            If e.Item.Image IsNot Nothing Then
                e.Cache.Graphics.DrawImage(e.Item.Image, CType(e.ItemInfo, GalleryItemViewInfo).ImageContentBounds)
            End If

            e.Handled = True
        End Sub

        Private Sub OnUnmarkAllItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CheckCollContextBtn("itemCheck", False)
            UnmarkItems()
            mainGallery.Gallery.LayoutChanged()
            UpdateImageButtonsEnabledState()
        End Sub

        Private Sub OnUnmarkItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim items As List(Of GalleryItem) = mainGallery.Gallery.GetCheckedItems()
            UnmarkItems(items)
            mainGallery.Refresh()
        End Sub

        Private Sub OnAddToAlbumButtonShowDropDownControl(ByVal sender As Object, ByVal e As ShowDropDownControlEventArgs)
            UpdateAlbumsMenu()
        End Sub

        Private Sub OnAddToAlbumItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim album As AlbumData = TryCast(e.Item.Tag, AlbumData)
            If album Is Nothing Then album = AddNewAlbum()
            If album Is Nothing Then Return
            Dim items As List(Of GalleryItem) = MarkedItems
            For Each item As GalleryItem In items
                If Not album.Files.Contains(CStr(item.Tag)) Then album.Files.Add(CreateFilePathData(CStr(item.Tag)))
            Next

            UnmarkItems()
            UpdateMainGalleryContent(True)
        End Sub

        Private Sub OnZoomTackValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim control As ZoomTrackBarControl = CType(sender, ZoomTrackBarControl)
            mainGallery.Gallery.ImageSize = New Size(control.Value, control.Value)
        End Sub

        Private Sub OnViewImageItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim fileName As String =(CStr(RightClickItem.Tag))
            Dim files As List(Of String) = New List(Of String)(1)
            files.Add(fileName)
            ViewSelectedImages(Path.GetFileName(fileName), fileName, files)
        End Sub

        Private Sub OnTabControlCloseButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            CloseSelectedTabPage()
        End Sub

        Private Sub OnEditAlbumItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            EditAlbum()
        End Sub

        Private Sub OnAlbumPopupMenuCloseUp(ByVal sender As Object, ByVal e As EventArgs)
            CustomizableLink = Nothing
        End Sub

        Private Sub OnViewSelectedImagesItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim files As List(Of String) = GetFilesInSelection()
            If files.Count = 0 Then
                XtraMessageBox.Show(Me, "None of images selected.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim tabName As String = If(files.Count > 1, "Collection", Path.GetFileName(files(0)))
            ViewSelectedImages(tabName, "", files)
        End Sub

        Private Sub OnAboutItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Call BarManager.About()
        End Sub

        Private Function GetCheckedImages() As List(Of Image)
            Dim items As List(Of GalleryItem) = MarkedItems
            Dim images As List(Of Image) = New List(Of Image)(items.Count)
            For Each item As GalleryItem In items
                images.Add(Image.FromFile(CStr(item.Tag)))
            Next

            Return images
        End Function

        Private Sub OnPrintItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim images As List(Of Image) = GetCheckedImages()
            Dim ps As PrintingSystem = New PrintingSystem()
            ps.PageSettings.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A5
            ps.PageSettings.Landscape = True
            ps.PageSettings.LeftMargin = 0
            ps.PageSettings.RightMargin = 0
            ps.PageSettings.TopMargin = 0
            ps.PageSettings.BottomMargin = 0
            Dim gr As BrickGraphics = ps.Graph
            ps.Begin()
            Dim offsetY As Single = 0
            For Each image As Image In images
                Dim imageBrick As ImageBrick = New ImageBrick()
                imageBrick.Image = image
                imageBrick.BorderWidth = 0
                imageBrick.BorderStyle = BrickBorderStyle.Inset
                imageBrick.Sides = BorderSide.All
                imageBrick.SizeMode = ImageSizeMode.Squeeze
                gr.DrawBrick(imageBrick, New RectangleF(New PointF(0, offsetY), ps.PageSettings.UsablePageSizeInPixels))
                offsetY += ps.PageSettings.UsablePageSizeInPixels.Height
            Next

            ps.End()
            Call New PrintTool(ps).ShowPreviewDialog()
        End Sub

        Private Sub OnExportItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            XtraMessageBox.Show(Me, "Here you can show your own export dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub OnEmailItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            XtraMessageBox.Show(Me, "Here you can make preparations for e-mail.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub OnUploadItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            XtraMessageBox.Show(Me, "Here you can show your own upload settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub OnCollageItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            XtraMessageBox.Show(Me, "Here you can show your own collage settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub OnSlideShowItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            XtraMessageBox.Show(Me, "Here you can show your own slideshow settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub OnFilmItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            XtraMessageBox.Show(Me, "Here you can show your own film settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub OnMainTabSelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs)
            If controlPresenter1.SelectedControl IsNot libraryPanel Then
                ShowViewCategory()
            Else
                HideViewCategory()
            End If
        End Sub

        Private Sub OnCloseImageItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CloseSelectedTabPage()
        End Sub

        Private Sub OnSaveImageItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            XtraMessageBox.Show(Me, "SaveImageItemClick", "PhotoViewer", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub OnCancelFilterItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim imageCollectionViewer As ImageCollectionViewer = TryCast(controlPresenter1.SelectedControl, ImageCollectionViewer)
            If imageCollectionViewer Is Nothing Then Return
            imageCollectionViewer.CancelFilters()
            UpdateCancelButtonEnabledState()
        End Sub

        Private Sub OnAddToAlbumItemPress(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            UpdateAlbumsMenu()
        End Sub

        Private Sub OnFiltersGalleryInitDropDown(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs)
            e.PopupGallery.AllowHoverImages = False
            e.PopupGallery.ImageSize = Global.PhotoViewer.Properties.Resources.FilterSample.Size
            e.PopupGallery.ShowItemText = True
            e.PopupGallery.ItemImageLocation = Locations.Top
            e.PopupGallery.SynchWithInRibbonGallery = True
        End Sub

        Private Sub OnFilterGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            Dim imageCollectionViewer As ImageCollectionViewer = TryCast(controlPresenter1.SelectedControl, ImageCollectionViewer)
            If imageCollectionViewer Is Nothing OrElse Not e.Item.Checked Then Return
            imageCollectionViewer.SetFilter(CType(e.Item.Tag, FilterInfo))
        End Sub

        Private Sub OnRibbonControlSelectedPageChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim page As Control = TryCast(ribbonControl1.SelectedPage.Tag, Control)
            If page Is Nothing Then page = libraryPanel
            controlPresenter1.SelectedControl = page
            UpdateItemsEnabledState()
            beZoom.Visibility = If(page Is libraryPanel, BarItemVisibility.Always, BarItemVisibility.Never)
        End Sub

        Private Sub OnAddToLibraryItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim item As BarItem = TryCast(biAddToLibrary.Tag, BarItem)
            If item IsNot Nothing Then item.PerformClick()
        End Sub

        Private Sub OnMainGalleryDoubleClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs)
            e.Item.Checked = True
            Dim fileName As String =(CStr(e.Item.Tag))
            Dim files As List(Of String) = New List(Of String)(1)
            files.Add(fileName)
            ViewSelectedImages(Path.GetFileName(fileName), fileName, files)
        End Sub

        Private Sub OnFilterByMarkedCheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            FilterByMarked(biFilterByMarked.Checked)
        End Sub

        Private Sub OnGenerateDataItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If XtraMessageBox.Show(Me, "Are you sure you want generate data? Current data will be lost.", Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            GenerateSampleData()
        End Sub

        Private Sub OnRemoveFromAlbumItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim items As List(Of GalleryItem) = MarkedItems
            If items.Count = 0 Then Return
            RemoveImagesFromAlbum(items)
        End Sub

        Private Sub ScrollToFolder(ByVal path As PathData, ByVal bAnimated As Boolean)
            mainGallery.Gallery.ScrollTo(GetGalleryGroupByTag(path), bAnimated)
        End Sub

        Private Sub ScrollToFile(ByVal fileName As String, ByVal bAnimated As Boolean)
            mainGallery.Gallery.ScrollTo(GetGalleryItemByTag(fileName), bAnimated)
        End Sub

        Private Sub ScrollToAlbum(ByVal album As AlbumData, ByVal bAnimated As Boolean)
            mainGallery.Gallery.ScrollTo(GetGalleryGroupByTag(album), bAnimated)
        End Sub

        Private Sub ProcessAlbums()
            mainGallery.Gallery.BeginUpdate()
            Try
                ClearGalleryAndImages()
                For Each album As AlbumData In ViewData.Albums
                    ProcessAlbum(album)
                Next
            Finally
                mainGallery.Gallery.EndUpdate()
            End Try
        End Sub

        Private Sub ProcessAlbum(ByVal albumData As AlbumData, ByVal showEditButtons As Boolean)
            Dim group As GalleryItemGroup = CreateAlbumGroup(albumData)
            Dim control As AlbumGroupCaptionControl = CType(group.CaptionControl, AlbumGroupCaptionControl)
            If Not showEditButtons Then control.HideEditButtons()
            mainGallery.Gallery.Groups.Add(group)
            For Each pData As PathData In albumData.Files
                group.Items.Add(CreatePhotoGalleryItem(pData.Path))
            Next
        End Sub

        Private Sub ProcessAlbum(ByVal albumData As AlbumData)
            ProcessAlbum(albumData, True)
        End Sub

        Private Sub ProcessOthers()
            mainGallery.Gallery.BeginUpdate()
            Try
                ClearGalleryAndImages()
                ProcessAlbum(ViewData.Others, False)
            Finally
                mainGallery.Gallery.EndUpdate()
            End Try
        End Sub

        Private Sub ProcessFolder(ByVal folder As PathData)
            Dim group As GalleryItemGroup = CreateFolderGroup(folder)
            mainGallery.Gallery.Groups.Add(group)
            Dim files As List(Of String) = GetImagesInFolder(folder)
            For Each fileName As String In files
                group.Items.Add(CreatePhotoGalleryItem(fileName))
            Next
        End Sub

        Private Sub ProcessFolders()
            mainGallery.Gallery.BeginUpdate()
            Try
                ClearGalleryAndImages()
                For Each pData As PathData In ViewData.Folders
                    ProcessFolder(pData)
                Next
            Finally
                mainGallery.Gallery.EndUpdate()
            End Try
        End Sub

        Private Function AddNewAlbum() As AlbumData
            Dim form As AlbumPropertiesForm = New AlbumPropertiesForm(ViewData)
            form.Text = "New album properties"
            form.Owner = Me
            If form.ShowDialog() = DialogResult.OK Then
                Dim album As AlbumData = New AlbumData()
                album.Name = form.AlbumName
                album.Date = form.AlbumDate
                album.Description = form.AlbumDescription
                ViewData.Albums.Add(album)
                UpdateData(True)
                navBarControl1.SelectedLink = GetLink(album)
                UpdateMainGalleryContent(True)
                Return album
            End If

            Return Nothing
        End Function

        Friend Sub EditAlbum(ByVal album As AlbumData)
            If album Is Nothing Then Return
            Dim form As AlbumPropertiesForm = New AlbumPropertiesForm(ViewData)
            form.Text = "Edit album properties"
            form.Owner = Me
            form.AlbumName = album.Name
            form.AlbumDate = album.Date
            form.AlbumDescription = album.Description
            form.IsEditExistingAlbumMode = True
            If form.ShowDialog() = DialogResult.OK Then
                album.Name = form.AlbumName
                album.Date = form.AlbumDate
                album.Description = form.AlbumDescription
                UpdateData(True)
                For Each link As NavBarItemLink In navBarControl1.Groups(0).ItemLinks
                    If link.Item.Tag Is album Then
                        navBarControl1.Groups(0).SelectedLink = link
                        UpdateMainGalleryContent(True)
                        Exit For
                    End If
                Next
            End If
        End Sub

        Friend Sub EditAlbum()
            EditAlbum(SelectedAlbum)
        End Sub

        Friend Sub RemoveAlbum(ByVal album As AlbumData)
            If XtraMessageBox.Show(Me, "Are you really want to remove album?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ViewData.Albums.Remove(album)
                UpdateData()
                UpdateMainGalleryContent(True)
            End If
        End Sub

        Friend Sub RemoveFolder(ByVal folder As PathData)
            If XtraMessageBox.Show(Me, "Are you really want to remove folder?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ViewData.Folders.Remove(folder)
                UpdateData()
                UpdateMainGalleryContent(True)
            End If
        End Sub

        Private Sub MarkItems(ByVal items As List(Of GalleryItem))
            For Each item As GalleryItem In items
                If Not MarkedItems.Contains(item) Then
                    MarkedItems.Add(item)
                End If
            Next
        End Sub

        Private Sub UnmarkItems(ByVal items As List(Of GalleryItem))
            For Each item As GalleryItem In items
                MarkedItems.Remove(item)
            Next
        End Sub

        Private Sub UnmarkItems()
            MarkedItems.Clear()
        End Sub

        Private Function IsPathAdded(ByVal path As String, ByVal coll As PathCollection) As Boolean
            For Each p As PathData In coll
                If Equals(p.Path, path) Then Return True
            Next

            Return False
        End Function

        Private Function IsFolderAdded(ByVal folderPath As String) As Boolean
            Return IsPathAdded(folderPath, ViewData.Folders)
        End Function

        Private Function IsFileAdded(ByVal fileName As String) As Boolean
            Return IsPathAdded(fileName, ViewData.Others.Files)
        End Function

        Private Sub ClearGalleryAndImages()
            mainGallery.Gallery.Groups.Clear()
            For Each group As GalleryItemGroup In mainGallery.Gallery.Groups
                If group.CaptionControl IsNot Nothing Then
                    group.CaptionControl.Dispose()
                    group.CaptionControl = Nothing
                    For Each item As GalleryItem In group.Items
                        If item.Image IsNot Nothing Then
                            item.Image.Dispose()
                            item.Image = Nothing
                        End If

                        Dim pData As PathData = TryCast(item.Tag, PathData)
                        pData.Image = Nothing
                    Next
                End If
            Next
        End Sub

        Protected Function GetImagesInFolder(ByVal folder As PathData) As List(Of String)
            Dim strFilter As String = "*bmp;*tga;*.jpg;*.png;*.gif"
            Dim m_arExt As String() = strFilter.Split(";"c)
            Dim files As List(Of String) = New List(Of String)()
            For Each filter As String In m_arExt
                Dim str As String() = Directory.GetFiles(folder.Path, filter)
                files.AddRange(str)
            Next

            Return files
        End Function

        Private Function GetGalleryGroupByTag(ByVal tag As Object) As GalleryItemGroup
            For Each group As GalleryItemGroup In mainGallery.Gallery.Groups
                If group.Tag Is tag Then Return group
            Next

            Return Nothing
        End Function

        Private Function GetGalleryItemByTag(ByVal tag As Object) As GalleryItem
            For Each group As GalleryItemGroup In mainGallery.Gallery.Groups
                For Each item As GalleryItem In group.Items
                    If item.Tag Is tag Then Return item
                Next
            Next

            Return Nothing
        End Function

        Private Function InflateClip(ByVal cache As GraphicsCache) As RectangleF
            Dim clipBounds As RectangleF = cache.Graphics.ClipBounds
            Dim rect As RectangleF = cache.Graphics.ClipBounds
            rect.Inflate(50, 50)
            cache.Graphics.SetClip(rect)
            Return clipBounds
        End Function

        Private Sub DrawMarkedIconInSelection(ByVal cache As GraphicsCache, ByVal bounds As Rectangle)
            Dim oldClipBounds As RectangleF = InflateClip(cache)
            cache.Graphics.DrawImage(Global.PhotoViewer.Properties.Resources.ItemMarked_16x16, New Rectangle(bounds.Right - 10, bounds.Bottom - 10, 16, 16))
            cache.Graphics.SetClip(oldClipBounds)
        End Sub

        Private Sub UpdateAlbumsMenu()
            For i As Integer = albumsPopupMenu.ItemLinks.Count - 1 To 0 Step -1
                Dim link As BarItemLink = albumsPopupMenu.ItemLinks(i)
                RemoveHandler link.Item.ItemClick, New ItemClickEventHandler(AddressOf OnAddToAlbumItemClick)
                ribbonControl1.Manager.Items.Remove(link.Item)
            Next

            albumsPopupMenu.ItemLinks.Clear()
            For Each album As AlbumData In ViewData.Albums
                albumsPopupMenu.ItemLinks.Add(CreateAddToAlbumItem(album))
            Next

            Dim newAlbumLink As BarItemLink = albumsPopupMenu.ItemLinks.Add(CreateAddToAlbumItem(Nothing))
            newAlbumLink.BeginGroup = True
        End Sub

        Private Sub ShowViewCategory()
            If controlPresenter1.SelectedControl.Tag IsNot Nothing Then Return
            viewPageCategory.Visible = True
            collectionOriginalPage.Visible = False
            Dim ribbonPage As RibbonPage = CType(CType(collectionOriginalPage, ICloneable).Clone(), RibbonPage)
            ribbonPage.Visible = True
            ribbonPage.Text = controlPresenter1.SelectedControl.Text
            viewPageCategory.Pages.Add(ribbonPage)
            ribbonPage.Tag = controlPresenter1.SelectedControl
            controlPresenter1.SelectedControl.Tag = ribbonPage
            ribbonControl1.SelectedPage = ribbonPage
        End Sub

        Private Sub HideViewCategory()
            If viewPageCategory.Pages.Count = 1 Then viewPageCategory.Visible = False
        End Sub

        Private Sub ViewSelectedImages(ByVal tabName As String, ByVal toolTip As String, ByVal files As List(Of String))
            Dim imageCollectionViewer As ImageCollectionViewer = New ImageCollectionViewer(files, ThumbPath)
            imageCollectionViewer.SetMenuManager(ribbonControl1.Manager)
            imageCollectionViewer.Text = tabName
            imageCollectionViewer.Dock = DockStyle.Fill
            imageCollectionViewer.SetFilter(GetSelectedFilter())
            controlPresenter1.Controls.Add(imageCollectionViewer)
            controlPresenter1.SelectedControl = imageCollectionViewer
        End Sub

        Private Function GetSelectedFilter() As FilterInfo
            For Each group As GalleryItemGroup In filtersGallery.Gallery.Groups
                For Each item As GalleryItem In group.Items
                    If item.Checked Then Return CType(item.Tag, FilterInfo)
                Next
            Next

            Return Nothing
        End Function

        Private Function GetFilesInSelection() As List(Of String)
            Dim items As List(Of GalleryItem) = MarkedItems
            Dim res As List(Of String) = New List(Of String)(items.Count)
            For Each item As GalleryItem In items
                res.Add(CStr(item.Tag))
            Next

            Return res
        End Function

        Private Sub UpdateAlbumButtonsEnabledState()
            biEditAlbum.Enabled = SelectedAlbum IsNot Nothing
            biRemoveAlbum.Enabled = SelectedAlbum IsNot Nothing
        End Sub

        Private Sub UpdateImageButtonsEnabledState()
            Dim hasFiles As Boolean = GetFilesInSelection().Count > 0
            biView.Enabled = hasFiles
            biRemoveFilesFromLibrary.Enabled = hasFiles
            biAddToAlbum.Enabled = hasFiles
            biCollage.Enabled = hasFiles
            biSlideShow.Enabled = hasFiles
            biFilm.Enabled = hasFiles
            biExportFolder.Enabled = hasFiles
            biEmail.Enabled = hasFiles
            biUpload.Enabled = hasFiles
            biPrint.Enabled = hasFiles
            biUnmark.Enabled = hasFiles
            biRemoveFromAlbum.Enabled = hasFiles AndAlso navBarControl1.SelectedLink IsNot Nothing AndAlso (TypeOf navBarControl1.SelectedLink.Item.Tag Is AlbumData OrElse navBarControl1.SelectedLink.Group Is othersGroup)
        End Sub

        Private Sub UpdateSelectedPictureEdit(ByVal e As GalleryItemEventArgs)
            selectedPictureEdit.LoadAsync(CStr(e.Item.Tag))
        End Sub

        Private Sub UpdateItemsEnabledState()
            UpdateImageButtonsEnabledState()
            UpdateAlbumButtonsEnabledState()
            UpdateCancelButtonEnabledState()
        End Sub

        Private Sub CloseSelectedTabPage()
            Dim page As Control = controlPresenter1.SelectedControl
            If page Is libraryPanel Then page = controlPresenter1.Controls(controlPresenter1.Controls.Count - 1)
            If page Is libraryPanel Then Return
            controlPresenter1.Controls.Remove(page)
            page.Dispose()
            Dim ribbonPage As RibbonPage = CType(page.Tag, RibbonPage)
            ribbonPage.Category.Pages.Remove(ribbonPage)
            ribbonPage.Dispose()
        End Sub

        Private Sub UpdateAddToLibraryItem(ByVal item As BarItem)
            biAddToLibrary.Glyph = item.Glyph
            biAddToLibrary.LargeGlyph = item.LargeGlyph
            biAddToLibrary.SuperTip = item.SuperTip
            biAddToLibrary.Hint = item.Hint
            biAddToLibrary.Tag = item
        End Sub

        Private Sub FilterByMarked(ByVal pFilterByMarked As Boolean)
            mainGallery.Gallery.BeginUpdate()
            Try
                For Each group As GalleryItemGroup In mainGallery.Gallery.Groups
                    For Each item As GalleryItem In group.Items
                        item.Visible = Not pFilterByMarked OrElse MarkedItems.Contains(item)
                    Next
                Next
            Finally
                mainGallery.Gallery.EndUpdate()
                mainGallery.Gallery.LayoutChanged()
            End Try
        End Sub

        Private Sub GenerateSampleData()
            ViewData.Clear()
            AddFolder("\SamplePhotos\Photo1")
            AddFolder("\SamplePhotos\Photo2")
            AddFolder("\SamplePhotos\Photo3")
            AddFolder("\SamplePhotos\Photo4")
            If ViewData.Folders.Count > 1 Then
                Dim files As List(Of String) = GetImagesInFolder(ViewData.Folders(0))
                files.AddRange(GetImagesInFolder(ViewData.Folders(1)))
                AddAlbum("Sample Album 1", Date.Now, "This is a sample album 1", files)
            End If

            If ViewData.Folders.Count > 3 Then
                Dim files As List(Of String) = GetImagesInFolder(ViewData.Folders(2))
                files.AddRange(GetImagesInFolder(ViewData.Folders(3)))
                AddAlbum("Sample Album 2", Date.Now, "This is a sample album 2", files)
            End If

            ViewData.Others.Name = "Other"
            ViewData.Others.Date = Date.Now
            ViewData.Others.Description = "Other image files"
            UpdateData()
            UpdateMainGalleryContent(True)
        End Sub

        Private Sub AddFolder(ByVal relativePath As String)
            Dim pData As PathData = New PathData()
            pData.Path = DataPath & relativePath
            pData.Name = Path.GetFileName(pData.Path)
            If Not Directory.Exists(pData.Path) Then
                XtraMessageBox.Show(Me, "Error: no such path '" & pData.Path & "'. Maybe you removed this folder?", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ViewData.Folders.Add(pData)
        End Sub

        Private Sub AddAlbum(ByVal albumName As String, ByVal albumDate As Date, ByVal description As String, ByVal files As List(Of String))
            Dim aData As AlbumData = New AlbumData()
            aData.Name = albumName
            aData.Date = albumDate
            aData.Description = description
            For Each file As String In files
                Dim pData As PathData = New PathData()
                pData.Path = file
                aData.Files.Add(pData)
            Next

            ViewData.Albums.Add(aData)
        End Sub

        Private Sub RemoveImagesFromAlbum(ByVal items As List(Of GalleryItem))
            Dim aData As AlbumData = TryCast(navBarControl1.SelectedLink.Item.Tag, AlbumData)
            Dim messageText As String = String.Empty
            If aData Is Nothing Then
                If navBarControl1.SelectedLink.Group Is othersGroup Then
                    aData = ViewData.Others
                    messageText = "Are you sure you want to remove checked items?"
                Else
                    Return
                End If
            Else
                messageText = "Are you sure you want to remove checked items from album '" & aData.Name & "'?"
            End If

            If XtraMessageBox.Show(Me, messageText, Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            For Each item As GalleryItem In items
                aData.Files.Remove(CStr(item.Tag))
            Next

            UpdateData()
            UpdateMainGalleryContent(True)
        End Sub

        Private flag As Boolean = False

        Private Sub UpdateMainGalleryContent(ByVal forceProcess As Boolean)
            If navBarControl1.SelectedLink Is Nothing Then
                ClearGalleryAndImages()
                Return
            End If

            Dim album As AlbumData = TryCast(navBarControl1.SelectedLink.Item.Tag, AlbumData)
            Dim path As PathData = TryCast(navBarControl1.SelectedLink.Item.Tag, PathData)
            Dim shouldRecreateGallery As Boolean = lastSelectedGroup IsNot navBarControl1.SelectedLink.Group OrElse forceProcess
            Dim isOtherFiles As Boolean = navBarControl1.SelectedLink.Group Is othersGroup
            If album IsNot Nothing Then
                If shouldRecreateGallery Then ProcessAlbums()
                If Not flag Then ScrollToAlbum(album, Not shouldRecreateGallery)
            ElseIf path IsNot Nothing Then
                If shouldRecreateGallery Then
                    If isOtherFiles Then
                        ProcessOthers()
                    Else
                        ProcessFolders()
                    End If
                End If

                If isOtherFiles Then
                    ScrollToFile(path.Path, Not shouldRecreateGallery)
                Else
                    ScrollToFolder(path, Not shouldRecreateGallery)
                End If
            End If

            UpdateItemsEnabledState()
        End Sub

        Friend Sub UpdateCancelButtonEnabledState()
            Dim viewer As ImageCollectionViewer = TryCast(controlPresenter1.SelectedControl, ImageCollectionViewer)
            biCancel.Enabled = viewer IsNot Nothing AndAlso viewer.IsImageFilterd()
        End Sub

        Private Sub OnSelectAllMarkedItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            For Each item As GalleryItem In MarkedItems
                Dim unselectOtherItems As Boolean = MarkedItems.IndexOf(item) = 0
                mainGallery.Gallery.SetItemCheck(item, True, unselectOtherItems)
            Next
        End Sub

        Private Sub filtersGallery_Gallery_PopupClose(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs)
            Dim items As List(Of GalleryItem) = e.Item.Gallery.GetCheckedItems()
            If items.Count > 0 Then e.Item.Gallery.MakeVisible(items(0))
        End Sub

        Private Sub OnDateFilterSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            mainGallery.Gallery.BeginUpdate()
            Try
                Dim items As List(Of GalleryItem) = mainGallery.Gallery.GetAllItems()
                For Each item As GalleryItem In items
                    Dim [date] As Date = File.GetCreationTime(CStr(item.Tag))
                    item.Visible = Not dateFilter1.AllowFilter OrElse [date] >= dateFilter1.StartDate AndAlso [date] <= dateFilter1.EndDate
                Next
            Finally
                mainGallery.Gallery.EndUpdate()
            End Try
        End Sub

        Private Sub galleryControlGallery1_MarqueeSelectionCompleted(ByVal sender As Object, ByVal e As GallerySelectionEventArgs)
            Dim pt As Point = MousePosition
            pt.Y -= 11
            ribbonMiniToolbar1.Show(pt)
        End Sub

        Private Sub repositoryItemZoomTrackBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            OnZoomTackValueChanged(sender, e)
        End Sub

        Private Sub bBColorMix_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim form As ColorWheelForm = New ColorWheelForm()
            form.StartPosition = FormStartPosition.CenterParent
            form.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor
            form.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2
            form.ShowDialog(Me)
        End Sub

        Private ratingValuesCore As Dictionary(Of GalleryItem, Integer)

        Protected ReadOnly Property RatingValues As Dictionary(Of GalleryItem, Integer)
            Get
                If ratingValuesCore Is Nothing Then ratingValuesCore = New Dictionary(Of GalleryItem, Integer)()
                Return ratingValuesCore
            End Get
        End Property

        Private Sub OnMainGallery_ContextButtonCustomize(ByVal sender As Object, ByVal e As GalleryContextButtonCustomizeEventArgs)
            Dim gallery As GalleryControlGallery = TryCast(sender, GalleryControlGallery)
            Select Case e.Item.Name
                Case "itemRating"
                    Dim rating As RatingContextButton = TryCast(e.Item, RatingContextButton)
                    Dim value As Integer
                    If Not RatingValues.TryGetValue(e.GalleryItem, value) Then
                        rating.Rating = NonCryptographicRandom.Default.Next(0, 6)
                        RatingValues.Add(e.GalleryItem, CInt(rating.Rating))
                    Else
                        rating.Rating = value
                    End If

                Case "itemCheck"
                    Dim check As CheckContextButton = TryCast(e.Item, CheckContextButton)
                    If MarkedItems.Contains(e.GalleryItem) Then check.Checked = True
                Case "itemInfo"
                    Dim btn As ContextButton = TryCast(e.Item, ContextButton)
                    btn.Caption = e.GalleryItem.Caption
                Case Else
            End Select
        End Sub

        Private Sub SelectLinkByGalleryItem(ByVal galleryItem As GalleryItem)
            For Each navItem As NavBarItem In navBarControl1.Items
                If Equals(navItem.Links(0).Caption, galleryItem.GalleryGroup.Caption) AndAlso navBarControl1.SelectedLink IsNot navItem.Links(0) Then
                    flag = True
                    navBarControl1.SelectedLink = navItem.Links(0)
                    flag = False
                End If
            Next
        End Sub

        Private Sub CheckItemContextButton(ByVal galleryItem As GalleryItem, ByVal checkItem As CheckContextButton)
            If checkItem.Checked AndAlso Not MarkedItems.Contains(galleryItem) Then MarkedItems.Add(galleryItem)
            If Not checkItem.Checked AndAlso MarkedItems.Contains(galleryItem) Then MarkedItems.Remove(galleryItem)
        End Sub

        Private Sub ShowItemImageLocation(ByVal galleryItem As GalleryItem)
            Dim path As String = galleryItem.Hint
            Dim folderPath As String = IO.Path.GetDirectoryName(path)
            SafeProcess.Start(folderPath)
        End Sub

        Private Sub galleryControlGallery1_ContextButtonClick(ByVal sender As Object, ByVal e As ContextItemClickEventArgs)
            Dim galleryItem As GalleryItem = TryCast(e.DataItem, GalleryItem)
            SelectLinkByGalleryItem(galleryItem)
            Select Case e.Item.Name
                Case "itemCheck"
                    CheckItemContextButton(galleryItem, TryCast(e.Item, CheckContextButton))
                    UpdateImageButtonsEnabledState()
                Case "itemRating"
                    RatingValues(galleryItem) = CInt(TryCast(e.Item, RatingContextButton).Rating)
                Case "itemRemove"
                    Dim items As List(Of GalleryItem) = New List(Of GalleryItem)()
                    items.Add(galleryItem)
                    RemoveImagesFromAlbum(items)
                Case "itemLocation"
                    ShowItemImageLocation(galleryItem)
            End Select
        End Sub

        Private Sub navBarControl1_ActiveGroupChanged(ByVal sender As Object, ByVal e As NavBarGroupEventArgs)
            CheckCollContextBtn("itemCheck", False)
            UnmarkItems()
            UpdateMainGalleryContent(True)
        End Sub

        Private Sub CheckCollContextBtn(ByVal name As String, ByVal isChecked As Boolean)
            Dim contextBtns As ContextItemCollection = mainGallery.Gallery.ContextButtons
            Dim checkBtn As CheckContextButton = TryCast(contextBtns(name), CheckContextButton)
            checkBtn.Checked = isChecked
        End Sub

        Private Sub galleryControlGallery1_GetThumbnailImage(ByVal sender As Object, ByVal e As GalleryThumbnailImageEventArgs)
            If e.Item.Tag IsNot Nothing Then
                Try
                    If File.Exists(CStr(e.Item.Tag)) Then
                        e.ThumbnailImage = e.CreateThumbnailImage(Image.FromFile(CStr(e.Item.Tag)))
                    End If
                Catch
                End Try
            End If
        End Sub

        Private Sub OnAnimationTypeChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If e.Item Is bcAnimationNone Then
                mainGallery.Gallery.OptionsImageLoad.AnimationType = ImageContentAnimationType.None
            ElseIf e.Item Is bcExpandAnimation Then
                mainGallery.Gallery.OptionsImageLoad.AnimationType = ImageContentAnimationType.Expand
            ElseIf e.Item Is bcPushAnimation Then
                mainGallery.Gallery.OptionsImageLoad.AnimationType = ImageContentAnimationType.Push
            ElseIf e.Item Is bcSlideAnimation Then
                mainGallery.Gallery.OptionsImageLoad.AnimationType = ImageContentAnimationType.Slide
            ElseIf e.Item Is bcSegmentedAnimation Then
                mainGallery.Gallery.OptionsImageLoad.AnimationType = ImageContentAnimationType.SegmentedFade
            End If
        End Sub

        Private Sub barCheckItem1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            mainGallery.Gallery.OptionsImageLoad.RandomShow = barCheckItem1.Checked
        End Sub
    End Class

    Public Class PhotoViewerSplashScreen
        Inherits DemoSplashScreen

        Public Sub New()
            DemoText = "PhotoViewer"
            ProductText = "The XtraBars Suite"
        End Sub
    End Class
End Namespace
