Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Data.Utils
Imports DevExpress.Utils.Helpers
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList.Nodes

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class ExplorerNew
        Inherits DevExpress.XtraTreeList.Demos.TutorialControl

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return Me.treeList1
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            Me.CalcImageSize()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"TreeListMainDemo\Modules\ExplorerNew"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "ExplorerNew"
            End Get
        End Property

        Private Sub CalcImageSize()
            DevExpress.XtraTreeList.Demos.Item.ImageSize = New System.Drawing.Size(16, 16)
            If Me.ScaleHelper.ScaleFactor.Width < 1.5 Then Return
            DevExpress.XtraTreeList.Demos.Item.ImageSize = Me.ScaleHelper.ScaleSize(DevExpress.XtraTreeList.Demos.Item.ImageSize)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            Me.InitializeBreadCrumb()
            Me.InitializeDisplayTreeList()
            Me.InitializeNavigationTreeList()
            Me.UpdateButtonsState()
        End Sub

#Region "Initialize"
        '<navigationTreeList>
        Private Sub InitializeNavigationTreeList()
            Me.navigationTreeList.DataSource = New DevExpress.XtraTreeList.Demos.RootItem()
            AddHandler Me.navigationTreeList.VirtualTreeGetChildNodes, AddressOf Me.OnNavigationTreeListGetChildNodes
            AddHandler Me.navigationTreeList.VirtualTreeGetCellValue, AddressOf Me.OnNavigationTreeListGetCellValue
            AddHandler Me.navigationTreeList.FocusedNodeChanged, AddressOf Me.OnNavigationTreeListFocusedNodeChanged
            AddHandler Me.navigationTreeList.CustomDrawNodeImages, AddressOf Me.OnTreeListCustomDrawNodeImages
            AddHandler Me.navigationTreeList.GetSelectImage, AddressOf Me.OnTreeListGetStateImage
            Me.navigationTreeList.ForceInitialize()
            Me.navigationTreeList.Nodes(CInt((0))).Expand()
            If Me.navigationTreeList.Nodes(CInt((0))).Nodes.Count > 2 Then
                Me.navigationTreeList.Nodes(CInt((0))).Nodes(CInt((1))).Expand()
                Me.navigationTreeList.FocusedNode = Me.navigationTreeList.Nodes(CInt((0))).Nodes(1)
            Else
                Me.navigationTreeList.FocusedNode = Me.navigationTreeList.Nodes(0)
            End If
        End Sub

        '</navigationTreeList>
        '<breadCrumbEdit>
        Private Sub InitializeBreadCrumb()
            Me.breadCrumbEdit.Properties.RootImageIndex = 0
            AddHandler Me.breadCrumbEdit.PathChanged, AddressOf Me.OnBreadCrumbEditPathChanged
            AddHandler Me.breadCrumbEvents1.CustomItemContents, AddressOf Me.OnBreadCrumbEventsCustomItemContents
        End Sub

        Private Sub InitializeDisplayTreeList()
            AddHandler Me.treeList1.CustomDrawNodeImages, AddressOf Me.OnTreeListCustomDrawNodeImages
            AddHandler Me.treeList1.GetSelectImage, AddressOf Me.OnTreeListGetStateImage
            AddHandler Me.treeList1.MouseDoubleClick, AddressOf Me.OnTreeListMouseDoubleClick
        End Sub

        '</breadCrumbEdit>
#End Region
        '<navigationTreeList>
        Private Sub OnNavigationTreeListGetCellValue(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo)
            e.CellData = CType(e.Node, DevExpress.XtraTreeList.Demos.Item).DisplayName
        End Sub

        Private Sub OnNavigationTreeListGetChildNodes(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo)
            Dim current As System.Windows.Forms.Cursor = System.Windows.Forms.Cursor.Current
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            e.Children = CType(e.Node, DevExpress.XtraTreeList.Demos.Item).GetDirectories()
            System.Windows.Forms.Cursor.Current = current
        End Sub

        '</navigationTreeList>
        Private Sub OnNavigationTreeListFocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs)
            If Me.navigationTreeList.FocusedNode Is Nothing Then Return
            Dim current As System.Windows.Forms.Cursor = System.Windows.Forms.Cursor.Current
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
            Me.searchControl.ClearFilter()
            Me.searchControl.Properties.NullValuePrompt = "Search " & Me.navigationTreeList.FocusedNode.GetDisplayText(0)
            Dim _item As DevExpress.XtraTreeList.Demos.Item = CType(Me.navigationTreeList.GetRow(Me.navigationTreeList.FocusedNode.Id), DevExpress.XtraTreeList.Demos.Item)
            Me.breadCrumbEdit.Properties.RootGlyph = _item.Image
            Me.treeList1.DataSource = _item.GetFilesSystemInfo()
            System.Windows.Forms.Cursor.Current = current
        End Sub

        Private Sub OnTreeListCustomDrawNodeImages(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeImagesEventArgs)
            Dim tree As DevExpress.XtraTreeList.TreeList = CType(sender, DevExpress.XtraTreeList.TreeList)
            Dim _item As DevExpress.XtraTreeList.Demos.IFileImage = CType(tree.GetRow(e.Node.Id), DevExpress.XtraTreeList.Demos.IFileImage)
            If _item.Image Is Nothing Then Return
            e.Cache.DrawImage(_item.Image, e.SelectImageLocation)
            e.Handled = True
        End Sub

        Private Sub OnTreeListGetStateImage(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetSelectImageEventArgs)
            e.NodeImageIndex = 0
        End Sub

        Private Sub OnTreeListMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If e.Button <> System.Windows.Forms.MouseButtons.Left Then Return
            Dim hitInfo As DevExpress.XtraTreeList.TreeListHitInfo = Me.treeList1.CalcHitInfo(e.Location)
            If hitInfo.Node Is Nothing Then Return
            Dim pressedNode As DevExpress.XtraTreeList.Nodes.TreeListNode = hitInfo.Node
            Dim fileInfo As DevExpress.XtraTreeList.Demos.CustomFileInfo = CType(Me.treeList1.GetRow(pressedNode.Id), DevExpress.XtraTreeList.Demos.CustomFileInfo)
            If fileInfo.Type = DevExpress.XtraTreeList.Demos.FileType.File Then
                Call DevExpress.Data.Utils.SafeProcess.Open(fileInfo.FullName)
            Else
                Me.navigationTreeList.FocusedNode = Me.navigationTreeList.FocusedNode.Nodes(pressedNode.Id)
            End If
        End Sub

        Private Sub OnBackButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.breadCrumbEdit.GoBack()
        End Sub

        Private Sub OnForwardButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.breadCrumbEdit.GoForward()
        End Sub

        Private Sub OnUpButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.breadCrumbEdit.GoUp()
        End Sub

        '<breadCrumbEdit>
        Private Sub OnBreadCrumbEditPathChanged(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.BreadCrumbPathChangedEventArgs)
            Me.UpdateButtonsState()
        End Sub

        Private Sub OnBreadCrumbEventsCustomItemContents(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Behaviors.CustomItemContentsEventArgs)
            Dim node As DevExpress.XtraEditors.BreadCrumbNode = e.Item
            Dim _item As DevExpress.XtraTreeList.Demos.Item = CType(Me.navigationTreeList.GetRow(CType(e.Source, DevExpress.XtraTreeList.Nodes.TreeListNode).Id), DevExpress.XtraTreeList.Demos.Item)
            node.Value = _item.Name
            node.Image = _item.Image
        End Sub

        '</breadCrumbEdit>
        Private Sub UpdateButtonsState()
            Me.forwardButton.Enabled = Me.breadCrumbEdit.CanGoForward
            Me.backButton.Enabled = Me.breadCrumbEdit.CanGoBack
            Me.upButton.Enabled = Me.breadCrumbEdit.CanGoUp
        End Sub

        Private Sub OnRecentButtonCheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        End Sub

        Private Sub OnMouseEnterButton(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim button As DevExpress.XtraEditors.SimpleButton = CType(sender, DevExpress.XtraEditors.SimpleButton)
            button.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        End Sub

        Private Sub OnMouseLeaveButton(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim button As DevExpress.XtraEditors.SimpleButton = CType(sender, DevExpress.XtraEditors.SimpleButton)
            button.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        End Sub
    End Class

    Public Class RootItem
        Inherits DevExpress.XtraTreeList.Demos.Item

        Public Sub New()
            MyBase.New("Root")
        End Sub

        Public Overrides Function GetDirectories() As List(Of DevExpress.XtraTreeList.Demos.Item)
            Return New System.Collections.Generic.List(Of DevExpress.XtraTreeList.Demos.Item)() From {New DevExpress.XtraTreeList.Demos.ThisPCItem()}
        End Function

        Public Overrides Property Image As Image
            Get
                Return Nothing
            End Get

            Set(ByVal value As Image)
            End Set
        End Property

        Public Overrides Function GetFilesSystemInfo() As List(Of DevExpress.XtraTreeList.Demos.CustomFileInfo)
            Return Nothing
        End Function
    End Class

    Public Class ThisPCItem
        Inherits DevExpress.XtraTreeList.Demos.Item

        Public Sub New()
            MyBase.New("This PC")
        End Sub

        Public Overrides Function GetDirectories() As List(Of DevExpress.XtraTreeList.Demos.Item)
            Dim items As System.Collections.Generic.List(Of DevExpress.XtraTreeList.Demos.Item) = New System.Collections.Generic.List(Of DevExpress.XtraTreeList.Demos.Item)(10)
            items.Add(New DevExpress.XtraTreeList.Demos.DirectoryItem(DevExpress.Data.Utils.SafeEnvironment.DesktopDirectory))
            items.Add(New DevExpress.XtraTreeList.Demos.DirectoryItem(DevExpress.Data.Utils.SafeEnvironment.MyDocuments))
            items.Add(New DevExpress.XtraTreeList.Demos.DirectoryItem(DevExpress.Data.Utils.SafeEnvironment.MyMusic))
            items.Add(New DevExpress.XtraTreeList.Demos.DirectoryItem(DevExpress.Data.Utils.SafeEnvironment.MyPictures))
            items.Add(New DevExpress.XtraTreeList.Demos.DirectoryItem(DevExpress.Data.Utils.SafeEnvironment.MyVideos))
            Dim drives As String() = System.IO.Directory.GetLogicalDrives()
            For Each drive As String In drives
                items.Add(New DevExpress.XtraTreeList.Demos.DriveItem(drive))
            Next

            Return items
        End Function

        Public Overrides Function GetFilesSystemInfo() As List(Of DevExpress.XtraTreeList.Demos.CustomFileInfo)
            Dim infos As System.Collections.Generic.List(Of DevExpress.XtraTreeList.Demos.CustomFileInfo) = New System.Collections.Generic.List(Of DevExpress.XtraTreeList.Demos.CustomFileInfo)(15)
            infos.Add(Me.CreateSystemFolderInfo(New System.IO.DirectoryInfo(DevExpress.Data.Utils.SafeEnvironment.DesktopDirectory)))
            infos.Add(Me.CreateSystemFolderInfo(New System.IO.DirectoryInfo(DevExpress.Data.Utils.SafeEnvironment.MyDocuments)))
            infos.Add(Me.CreateSystemFolderInfo(New System.IO.DirectoryInfo(DevExpress.Data.Utils.SafeEnvironment.MyMusic)))
            infos.Add(Me.CreateSystemFolderInfo(New System.IO.DirectoryInfo(DevExpress.Data.Utils.SafeEnvironment.MyPictures)))
            infos.Add(Me.CreateSystemFolderInfo(New System.IO.DirectoryInfo(DevExpress.Data.Utils.SafeEnvironment.MyVideos)))
            Dim drives As String() = System.IO.Directory.GetLogicalDrives()
            For Each drive As String In drives
                Dim driveInfo As System.IO.DriveInfo = New System.IO.DriveInfo(drive)
                infos.Add(New DevExpress.XtraTreeList.Demos.CustomFileInfo() With {.FullName = driveInfo.Name, .Name = drive, .Image = Me.GetImage(drive), .TypeName = "Drive", .Type = DevExpress.XtraTreeList.Demos.FileType.Drive})
            Next

            Return infos
        End Function

        Private Function CreateSystemFolderInfo(ByVal info As System.IO.FileSystemInfo) As CustomFileInfo
            Return New DevExpress.XtraTreeList.Demos.CustomFileInfo() With {.Name = info.Name, .FullName = info.FullName, .DateCreated = info.CreationTime, .DateModified = info.LastWriteTime, .Image = Me.GetImage(info.FullName), .TypeName = "System Folder", .Type = DevExpress.XtraTreeList.Demos.FileType.SystemFolder}
        End Function

        Public Overrides Property Image As Image
            Get
                Return Nothing
            End Get

            Set(ByVal value As Image)
            End Set
        End Property
    End Class

    Public Class DriveItem
        Inherits DevExpress.XtraTreeList.Demos.DirectoryItem

        Public Sub New(ByVal fullName As String)
            MyBase.New(fullName)
        End Sub

        Protected Overrides Function GetDirectoryName(ByVal path As String) As String
            Dim _name As String = path.Replace(System.IO.Path.DirectorySeparatorChar.ToString(), "")
            Return _name
        End Function

        Protected Overrides Function GetDisplayName(ByVal fullName As String) As String
            Return "Disc (" & Me.Name & ")"
        End Function
    End Class

    Public Class DirectoryItem
        Inherits DevExpress.XtraTreeList.Demos.Item

        Public Sub New(ByVal fullName As String)
            MyBase.New(fullName)
        End Sub

        Public Overrides Function GetDirectories() As List(Of DevExpress.XtraTreeList.Demos.Item)
            Dim items As System.Collections.Generic.List(Of DevExpress.XtraTreeList.Demos.Item) = New System.Collections.Generic.List(Of DevExpress.XtraTreeList.Demos.Item)(10)
            Try
                If System.IO.Directory.Exists(Me.FullName) Then
                    Dim dirs As String() = System.IO.Directory.GetDirectories(Me.FullName)
                    For Each dir As String In dirs
                        Dim attributes = System.IO.File.GetAttributes(dir)
                        If(attributes And System.IO.FileAttributes.Hidden) <> System.IO.FileAttributes.Hidden Then items.Add(New DevExpress.XtraTreeList.Demos.DirectoryItem(dir))
                    Next
                End If
            Catch
            Finally
            End Try

            Return items
        End Function

        Protected Overrides Function GetDirectoryName(ByVal path As String) As String
            Return System.IO.Path.GetFileName(path)
        End Function
    End Class

    Public MustInherit Class Item
        Implements DevExpress.XtraTreeList.Demos.IFileImage

        Private _DisplayName As String, _Name As String, _FullName As String

        Public Sub New(ByVal fullName As String)
            Me.Image = Me.GetImage(fullName)
            Me.Name = Me.GetDirectoryName(fullName)
            Me.FullName = fullName
            Me.DisplayName = Me.GetDisplayName(fullName)
        End Sub

        Protected Overridable Function GetDisplayName(ByVal fullName As String) As String
            Return Me.Name
        End Function

        Public Property DisplayName As String
            Get
                Return _DisplayName
            End Get

            Private Set(ByVal value As String)
                _DisplayName = value
            End Set
        End Property

        Public Property Name As String
            Get
                Return _Name
            End Get

            Private Set(ByVal value As String)
                _Name = value
            End Set
        End Property

        Public Property FullName As String
            Get
                Return _FullName
            End Get

            Private Set(ByVal value As String)
                _FullName = value
            End Set
        End Property

        Public Overridable Property Image As Image Implements Global.DevExpress.XtraTreeList.Demos.IFileImage.Image

        Public MustOverride Function GetDirectories() As List(Of DevExpress.XtraTreeList.Demos.Item)

        Public Shared Property ImageSize As Size

        Protected Function GetImage(ByVal fullName As String) As Image
            Return DevExpress.Utils.Helpers.FileSystemHelper.GetImage(fullName, DevExpress.Utils.Helpers.IconSizeType.Small, DevExpress.XtraTreeList.Demos.Item.ImageSize)
        End Function

        Protected Overridable Function GetDirectoryName(ByVal fullName As String) As String
            Return fullName
        End Function

        Public Overridable Function GetFilesSystemInfo() As List(Of DevExpress.XtraTreeList.Demos.CustomFileInfo)
            Dim infos As System.Collections.Generic.List(Of DevExpress.XtraTreeList.Demos.CustomFileInfo) = New System.Collections.Generic.List(Of DevExpress.XtraTreeList.Demos.CustomFileInfo)(15)
            Try
                Dim dInfo As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(Me.FullName)
                If CInt(dInfo.Attributes) = -1 Then Return infos
                Dim directories = dInfo.GetDirectories()
                For Each directory In directories
                    If(directory.Attributes And System.IO.FileAttributes.Hidden) <> System.IO.FileAttributes.Hidden Then
                        infos.Add(New DevExpress.XtraTreeList.Demos.CustomFileInfo() With {.Name = directory.Name, .FullName = directory.FullName, .DateCreated = directory.CreationTime, .DateModified = directory.LastWriteTime, .Image = Me.GetImage(directory.FullName), .TypeName = "File Folder", .Type = DevExpress.XtraTreeList.Demos.FileType.FileFolder})
                    End If
                Next

                Dim files = dInfo.GetFiles()
                For Each file In files
                    If(file.Attributes And System.IO.FileAttributes.Hidden) <> System.IO.FileAttributes.Hidden Then
                        infos.Add(New DevExpress.XtraTreeList.Demos.CustomFileInfo() With {.Name = file.Name, .FullName = file.FullName, .DateCreated = file.CreationTime, .DateModified = file.LastWriteTime, .Image = Me.GetImage(file.FullName), .TypeName = "File", .Type = DevExpress.XtraTreeList.Demos.FileType.File, .Size = file.Length})
                    End If
                Next
            Catch
            End Try

            Return infos
        End Function
    End Class

    Public Class CustomFileInfo
        Implements DevExpress.XtraTreeList.Demos.IFileImage

        Public Sub New()
        End Sub

        Public Property Image As Image Implements Global.DevExpress.XtraTreeList.Demos.IFileImage.Image

        Public Property FullName As String

        Public Property Name As String

        Public Property Type As FileType

        Public Property TypeName As String

        Public Property DateModified As System.DateTime?

        Public Property DateCreated As System.DateTime?

        Public Property Size As Long?
    End Class

    Public Enum FileType
        Drive
        SystemFolder
        FileFolder
        File
    End Enum

    Friend Interface IFileImage

        ReadOnly Property Image As Image

    End Interface
End Namespace
