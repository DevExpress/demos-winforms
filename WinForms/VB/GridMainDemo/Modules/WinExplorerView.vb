Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Data
Imports DevExpress.Data.Utils.Registry
Imports DevExpress.DemoData.Helpers
Imports DevExpress.Utils
Imports DevExpress.Utils.Helpers
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.WinExplorer
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.XtraNavBar

Namespace DevExpress.XtraGrid.Demos

    Public Partial Class ExplorerView
        Inherits TutorialControl
        Implements IFileSystemNavigationSupports

        Private _currentPath As String

        Public Sub New()
            InitializeComponent()
            AutoMergeRibbon = True
        End Sub

        Shared Sub New()
            FileSystemImageCache.Cache.EnableFileIconCaching = False
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Initialize()
        End Sub

        Private Sub Initialize()
            InitializeDefaultFolderIcons()
            InitializeBreadCrumb()
            InitializeNavBar()
            InitializeAppearance()
            CalcPanels()
            UpdateView()
        End Sub

        Private Sub InitializeDefaultFolderIcons()
            groupFavorites.ImageOptions.SmallImage = FileSystemHelper.GetImage(Data.Utils.SafeEnvironment.Favorites, IconSizeType.Small, FolderIconSize)
            navPanelItemDesktop.ImageOptions.SmallImage = FileSystemHelper.GetImage(Data.Utils.SafeEnvironment.Desktop, IconSizeType.Small, FolderIconSize)
            navPanelItemDownloads.ImageOptions.SmallImage = FileSystemHelper.GetImage(DXSystemSettings.GetDownloadsDirectory(), IconSizeType.Small, FolderIconSize)
            navPanelItemRecent.ImageOptions.SmallImage = FileSystemHelper.GetImage(Data.Utils.SafeEnvironment.Recent, IconSizeType.Small, FolderIconSize)
            groupLibraries.ImageOptions.SmallImage = FileSystemHelper.GetImage(Data.Utils.SafeEnvironment.MyComputer, IconSizeType.Small, FolderIconSize)
            navPanelItemDocuments.ImageOptions.SmallImage = FileSystemHelper.GetImage(Data.Utils.SafeEnvironment.MyDocuments, IconSizeType.Small, FolderIconSize)
            navPanelItemPictures.ImageOptions.SmallImage = FileSystemHelper.GetImage(Data.Utils.SafeEnvironment.MyPictures, IconSizeType.Small, FolderIconSize)
            navPanelItemVideos.ImageOptions.SmallImage = FileSystemHelper.GetImage(Data.Utils.SafeEnvironment.MyVideos, IconSizeType.Small, FolderIconSize)
            navPanelItemMusic.ImageOptions.SmallImage = FileSystemHelper.GetImage(Data.Utils.SafeEnvironment.MyMusic, IconSizeType.Small, FolderIconSize)
        End Sub

        Private ReadOnly Property FolderIconSize As Size
            Get
                Return New Size(ScaleUtils.ScaleValue(16), ScaleUtils.ScaleValue(16))
            End Get
        End Property

        Private Sub InitializeBreadCrumb()
            _currentPath = StartupPath
            BreadCrumb.Path = _currentPath
            For Each driveInfo As DriveInfo In FileSystemHelper.GetFixedDrives()
                BreadCrumb.Properties.History.Add(New BreadCrumbHistoryItem(driveInfo.RootDirectory.ToString()))
            Next
        End Sub

        Private Sub InitializeAppearance()
            Dim item As GalleryItem = rgbiViewStyle.Gallery.GetCheckedItem()
            If item IsNot Nothing Then winExplorerView.OptionsView.Style = CType(item.Tag, WinExplorerViewStyle)
        End Sub

        Private Sub OnBreadCrumbPathChanged(ByVal sender As Object, ByVal e As BreadCrumbPathChangedEventArgs)
            _currentPath = e.Path
            UpdateView()
            UpdateButtons()
        End Sub

        Private Sub OnBreadCrumbNewNodeAdding(ByVal sender As Object, ByVal e As BreadCrumbNewNodeAddingEventArgs)
            e.Node.PopulateOnDemand = True
        End Sub

        Private Sub OnBreadCrumbQueryChildNodes(ByVal sender As Object, ByVal e As BreadCrumbQueryChildNodesEventArgs)
            If Equals(e.Node.Caption, "Root") Then
                InitBreadCrumbRootNode(e.Node)
                Return
            End If

            If Equals(e.Node.Caption, "Computer") Then
                InitBreadCrumbComputerNode(e.Node)
                Return
            End If

            Dim dir As String = e.Node.Path
            If Not FileSystemHelper.IsDirExists(dir) Then Return
            Dim subDirs As String() = FileSystemHelper.GetSubFolders(dir)
            For i As Integer = 0 To subDirs.Length - 1
                e.Node.ChildNodes.Add(CreateNode(subDirs(i)))
            Next
        End Sub

        Private Sub InitBreadCrumbRootNode(ByVal node As BreadCrumbNode)
            node.ChildNodes.Add(New BreadCrumbNode("Desktop", Data.Utils.SafeEnvironment.Desktop))
            node.ChildNodes.Add(New BreadCrumbNode("Documents", Data.Utils.SafeEnvironment.Recent))
            node.ChildNodes.Add(New BreadCrumbNode("Music", Data.Utils.SafeEnvironment.MyMusic))
            node.ChildNodes.Add(New BreadCrumbNode("Pictures", Data.Utils.SafeEnvironment.MyPictures))
            node.ChildNodes.Add(New BreadCrumbNode("Video", Data.Utils.SafeEnvironment.MyVideos))
            node.ChildNodes.Add(New BreadCrumbNode("Program Files", Data.Utils.SafeEnvironment.ProgramFiles))
            node.ChildNodes.Add(New BreadCrumbNode("Windows", Data.Utils.SafeEnvironment.Windows))
        End Sub

        Private Sub InitBreadCrumbComputerNode(ByVal node As BreadCrumbNode)
            For Each driveInfo As DriveInfo In FileSystemHelper.GetFixedDrives()
                node.ChildNodes.Add(New BreadCrumbNode(driveInfo.Name, driveInfo.RootDirectory))
            Next
        End Sub

        Private Sub OnBreadCrumbValidatePath(ByVal sender As Object, ByVal e As BreadCrumbValidatePathEventArgs)
            If Not FileSystemHelper.IsDirExists(e.Path) Then
                e.ValidationResult = BreadCrumbValidatePathResult.Cancel
                Return
            End If

            e.ValidationResult = BreadCrumbValidatePathResult.CreateNodes
        End Sub

        Private Sub OnBreadCrumbRootGlyphClick(ByVal sender As Object, ByVal e As EventArgs)
            BreadCrumb.Properties.BreadCrumbMode = BreadCrumbMode.Edit
            BreadCrumb.SelectAll()
        End Sub

        Private Function CreateNode(ByVal path As String) As BreadCrumbNode
            Dim folderName As String = FileSystemHelper.GetDirName(path)
            Return New BreadCrumbNode(folderName, folderName, True)
        End Function

        Protected ReadOnly Property StartupPath As String
            Get
                Return Data.Utils.SafeEnvironment.Desktop
            End Get
        End Property

        Private Sub UpdateView()
            Dim oldCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            Try
                If Not String.IsNullOrEmpty(_currentPath) Then
                    gridControl.DataSource = FileSystemHelper.GetFileSystemEntries(_currentPath, GetItemSizeType(ViewStyle), GetItemSize(ViewStyle))
                Else
                    gridControl.DataSource = Nothing
                End If

                winExplorerView.RefreshData()
                EnsureSearchEdit()
                BeginInvoke(New MethodInvoker(AddressOf winExplorerView.ClearSelection))
            Finally
                Cursor.Current = oldCursor
            End Try
        End Sub

        Private Sub EnsureSearchEdit()
            editSearch.Properties.NullValuePrompt = "Search " & FileSystemHelper.GetDirName(_currentPath)
            editSearch.EditValue = Nothing
            winExplorerView.FindFilterText = String.Empty
        End Sub

        Private Sub OnNavPanelLinkClicked(ByVal sender As Object, ByVal e As NavBarLinkEventArgs)
            BreadCrumb.Path = CStr(e.Link.Item.Tag)
        End Sub

        Private Sub OnShowNavPaneItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim item As BarCheckItem = CType(e.Item, BarCheckItem)
            liNavPaneRight.Visibility = If(item.Checked, LayoutVisibility.Always, LayoutVisibility.Never)
            navBar.Visible = item.Checked
        End Sub

        Private Sub OnShowFavoritesItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            groupFavorites.Visible = CType(e.Item, BarCheckItem).Checked
        End Sub

        Private Sub OnShowLibrariesItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            groupLibraries.Visible = CType(e.Item, BarCheckItem).Checked
        End Sub

        Private Sub OnShowCheckBoxesItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            winExplorerView.OptionsView.ShowCheckBoxes = CType(e.Item, BarCheckItem).Checked
        End Sub

        Private Sub InitializeNavBar()
            navPanelItemDesktop.Tag = Data.Utils.SafeEnvironment.Desktop
            navPanelItemRecent.Tag = Data.Utils.SafeEnvironment.Recent
            navPanelItemDocuments.Tag = Data.Utils.SafeEnvironment.MyDocuments
            navPanelItemMusic.Tag = Data.Utils.SafeEnvironment.MyMusic
            navPanelItemPictures.Tag = Data.Utils.SafeEnvironment.MyPictures
            navPanelItemVideos.Tag = Data.Utils.SafeEnvironment.MyVideos
            navPanelItemDownloads.Tag = DXSystemSettings.GetDownloadsDirectory()
            If navPanelItemDownloads.Tag Is Nothing Then navPanelItemDownloads.Visible = False
        End Sub

        Private Sub OnViewStyleGalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            Dim item As GalleryItem = e.Item
            If Not item.Checked Then Return
            Dim _viewStyle As WinExplorerViewStyle = CType([Enum].Parse(GetType(WinExplorerViewStyle), item.Tag.ToString()), WinExplorerViewStyle)
            winExplorerView.OptionsView.Style = _viewStyle
            Call FileSystemImageCache.Cache.ClearCache()
            UpdateView()
        End Sub

        Private Sub OnRgbiViewStyleInitDropDown(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs)
            e.PopupGallery.SynchWithInRibbonGallery = True
        End Sub

        Private Sub OnEditSearchTextChanged(ByVal sender As Object, ByVal e As EventArgs)
            winExplorerView.FindFilterText = editSearch.Text
        End Sub

        Private Sub OnSelectAllItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            winExplorerView.SelectAll()
        End Sub

        Private Sub OnSelectNoneItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            winExplorerView.ClearSelection()
        End Sub

        Private Sub OnInvertSelectionItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            For i As Integer = 0 To winExplorerView.RowCount - 1
                winExplorerView.InvertRowSelection(i)
            Next
        End Sub

        Private Sub OnShowFileNameExtensionsCheckItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim col As FileSystemEntryCollection = TryCast(gridControl.DataSource, FileSystemEntryCollection)
            If col Is Nothing Then Return
            col.ShowExtensions = CType(e.Item, BarCheckItem).Checked
            gridControl.RefreshDataSource()
        End Sub

        Private Sub OnShowHiddenItemsCheckItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            btnHideSelectedItems.Enabled = Not CType(e.Item, BarCheckItem).Checked
        End Sub

        Private Sub OnHelpButtonItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Call StartApplicationHelper.ShowHelp()
        End Sub

        Private Sub OnWinExplorerViewSelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
            UpdateButtons()
        End Sub

        Private Sub OnCopyPathItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim builder As StringBuilder = New StringBuilder()
            For Each entry As FileSystemEntry In GetSelectedEntries()
                builder.AppendLine(entry.Path)
            Next

            If Not String.IsNullOrEmpty(builder.ToString()) Then Data.Utils.SafeClipboardWin.Instance.SetText(builder.ToString())
        End Sub

        Private Sub OnOpenItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            For Each entry As FileSystemEntry In GetSelectedEntries(True)
                entry.DoAction(Me)
            Next
        End Sub

        Private Sub OnWinExplorerViewKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode <> Keys.Enter Then Return
            Dim entry As FileSystemEntry = GetSelectedEntries().LastOrDefault()
            If entry IsNot Nothing Then entry.DoAction(Me)
        End Sub

        Private Sub OnWinExplorerViewItemClick(ByVal sender As Object, ByVal e As WinExplorerViewItemClickEventArgs)
            If e.MouseInfo.Button = MouseButtons.Right Then itemPopupMenu.ShowPopup(Cursor.Position)
        End Sub

        Private Sub OnWinExplorerViewItemDoubleClick(ByVal sender As Object, ByVal e As WinExplorerViewItemDoubleClickEventArgs)
            If e.MouseInfo.Button <> MouseButtons.Left Then Return
            winExplorerView.ClearSelection()
            CType(e.ItemInfo.Row.RowKey, FileSystemEntry).DoAction(Me)
        End Sub

        Private Sub UpdateButtons()
            Dim selEntriesCount As Integer = GetSelectedEntries().Count()
            btnCopyItem.Enabled = selEntriesCount > 0
            btnOpen.Enabled = btnCopyItem.Enabled
            btnUpTo.Enabled = BreadCrumb.CanGoUp
            btnBack.Enabled = BreadCrumb.CanGoBack
            btnForward.Enabled = BreadCrumb.CanGoForward
        End Sub

        Private Sub OnBackButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            BreadCrumb.GoBack()
        End Sub

        Private Sub OnNextButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            BreadCrumb.GoForward()
        End Sub

        Private Sub OnUpButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            BreadCrumb.GoUp()
        End Sub

        Private Sub OnNavigationMenuButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            navigationMenu.ItemLinks.Clear()
            navigationMenu.ItemLinks.AddRange(GetNavigationHistroryItems().ToArray())
            navigationMenu.ShowPopup(PointToScreen(New Point(0, navigationPanel.Bottom)))
        End Sub

        Private Iterator Function GetNavigationHistroryItems() As IEnumerable(Of BarItem)
            Dim history As BreadCrumbHistory = BreadCrumb.GetNavigationHistory()
            For i As Integer = history.Count - 1 To 0 Step -1
                Dim item As BreadCrumbHistoryItem = history(i)
                Dim menuItem As BarCheckItem = New BarCheckItem()
                menuItem.Tag = i
                menuItem.Caption = FileSystemHelper.GetDirName(item.Path)
                AddHandler menuItem.ItemClick, AddressOf OnNavigationMenuItemClick
                menuItem.Checked = BreadCrumb.GetNavigationHistoryCurrentItemIndex() = i
                Yield menuItem
            Next
        End Function

        Private Sub OnNavigationMenuItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            BreadCrumb.SetNavigationHistoryCurrentItemIndex(Convert.ToInt32(e.Item.Tag))
            UpdateButtons()
        End Sub

        Private Function GetSelectedEntries() As List(Of FileSystemEntry)
            Return GetSelectedEntries(False)
        End Function

        Private Function GetSelectedEntries(ByVal sort As Boolean) As List(Of FileSystemEntry)
            Dim list As List(Of FileSystemEntry) = New List(Of FileSystemEntry)()
            Dim rows As Integer() = winExplorerView.GetSelectedRows()
            For i As Integer = 0 To rows.Length - 1
                list.Add(CType(winExplorerView.GetRow(rows(i)), FileSystemEntry))
            Next

            If sort Then list.Sort(New FileSytemEntryComparer())
            Return list
        End Function

        Private Function GetItemSize(ByVal viewStyle As WinExplorerViewStyle) As Size
            Select Case viewStyle
                Case WinExplorerViewStyle.ExtraLarge
                    Return New Size(256, 256)
                Case WinExplorerViewStyle.Large
                    Return New Size(96, 96)
                Case WinExplorerViewStyle.Content
                    Return New Size(32, 32)
                Case WinExplorerViewStyle.Small
                    Return New Size(16, 16)
                Case Else
                    Return New Size(96, 96)
            End Select
        End Function

        Private Function GetItemSizeType(ByVal viewStyle As WinExplorerViewStyle) As IconSizeType
            Select Case viewStyle
                Case WinExplorerViewStyle.Large, WinExplorerViewStyle.ExtraLarge
                    Return IconSizeType.ExtraLarge
                Case WinExplorerViewStyle.List, WinExplorerViewStyle.Small
                    Return IconSizeType.Small
                Case WinExplorerViewStyle.Tiles, WinExplorerViewStyle.Medium, WinExplorerViewStyle.Content
                    Return IconSizeType.Large
                Case Else
                    Return IconSizeType.ExtraLarge
            End Select
        End Function

        Private Sub CalcPanels()
            navigationPanel.Location = Point.Empty
            contentPanel.Location = New Point(0, navigationPanel.Bottom - 1)
            contentPanel.Height = Height - navigationPanel.Height + 1
        End Sub

        Public ReadOnly Property BreadCrumb As BreadCrumbEdit
            Get
                Return editBreadCrumb
            End Get
        End Property

        Public ReadOnly Property ViewStyle As WinExplorerViewStyle
            Get
                Return winExplorerView.OptionsView.Style
            End Get
        End Property

#Region "IFileSystemNavigationSupports"
        Private ReadOnly Property CurrentPath As String Implements IFileSystemNavigationSupports.CurrentPath
            Get
                Return _currentPath
            End Get
        End Property

        Private Sub UpdatePath(ByVal path As String) Implements IFileSystemNavigationSupports.UpdatePath
            BreadCrumb.Path = path
        End Sub

#End Region
#Region "ReportGeneration"
        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
#End Region
    End Class
End Namespace
