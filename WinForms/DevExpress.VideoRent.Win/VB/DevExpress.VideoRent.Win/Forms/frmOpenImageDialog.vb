Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System.Drawing
Imports System
Imports DevExpress.Utils
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.IO
Imports DevExpress.VideoRent.Helpers
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmOpenImageDialog
		Inherits XtraForm
		Private Class FileAssociatedIcons
            Private fcollection As ImageCollection
            Private indexes As Dictionary(Of String, Integer)
            Public Sub New()
                fcollection = New ImageCollection()
                indexes = New Dictionary(Of String, Integer)()
            End Sub
            Public ReadOnly Property Collection() As ImageCollection
                Get
                    Return fcollection
                End Get
            End Property
            Public Function IconIndex(ByVal file As String, ByVal folderOpen As Boolean) As Integer
                Dim type As String = GetFileType(file, folderOpen)
                If indexes.ContainsKey(type) Then
                    Return indexes(type)
                End If
                fcollection.AddImage(GetIcon(type, file))
                indexes.Add(type, fcollection.Images.Count - 1)
                Return indexes(type)
            End Function
            Private Shared Function GetIcon(ByVal type As String, ByVal file As String) As Image
                If type = "Drive" Then
                    Return ElementHelper.FolderIcons.Images(0)
                End If
                If type = "Open Folder" Then
                    Return ElementHelper.FolderIcons.Images(1)
                End If
                If type = "Close Folder" Then
                    Return ElementHelper.FolderIcons.Images(2)
                End If
                Dim icon As Icon = WinApiWrapper.GetIconBySHGetFileInfo(file, True)
                If Object.Equals(icon, Nothing) Then
                    Return Nothing
                Else
                    Return icon.ToBitmap()
                End If
            End Function
            Private Shared Function GetFileType(ByVal file As String, ByVal folderOpen As Boolean) As String
                If IsDrive(file) Then
                    Return "Drive"
                End If
                If IsFolder(file) Then
                    If folderOpen Then
                        Return "Open Folder"
                    Else
                        Return "Close Folder"
                    End If
                End If
                Return WinApiWrapper.GetTypeNameBySHGetFileInfo(file)
            End Function
            Public Shared Function IsFolder(ByVal file As String) As Boolean
                Dim di As New DirectoryInfo(file)
                Try
                    Return (di.Attributes And FileAttributes.Directory) <> 0
                Catch
                    Return False
                End Try
            End Function
            Public Shared Function IsDrive(ByVal file As String) As Boolean
                Dim di As New DirectoryInfo(file)
                Dim drives() As String = Directory.GetLogicalDrives()
                For Each drive As String In drives
                    If Object.Equals(drive, di.Name) Then
                        Return True
                    End If
                Next drive
                Return False
            End Function
        End Class
        Public Delegate Sub SetImageDelegate(ByVal value As Image)
        Private loadDrives As Boolean = False
        Private resultImage As SetImageDelegate
        Private Shared icons As New FileAssociatedIcons()
        Private fcurrentPath As String
        Private maxImageSize As New Size(3000, 2000)
        Private nodeChangedTimer As Timer
        Private layoutManager As FormLayoutManager
        Private bManager As XtraBars.BarManager
        Public Property CurrentPath() As String
            Get
                Return fcurrentPath
            End Get
            Set(ByVal value As String)
                fcurrentPath = value
            End Set
        End Property
		Public Sub New(ByVal resultImage As SetImageDelegate)
			Me.New(resultImage, Nothing)
		End Sub
		Public Sub New(ByVal resultImage As SetImageDelegate, ByVal manager As FormLayoutManager)
			MyBase.New()
			InitializeComponent()
			InitData()
            bManager = New XtraBars.BarManager()
            bManager.Form = Me
			Me.resultImage = resultImage
			treeList.StateImageList = icons.Collection
            treeList.MenuManager = bManager
            teImageScale.MenuManager = bManager
            layoutControl.MenuManager = bManager
			nodeChangedTimer = New Timer()
			nodeChangedTimer.Interval = 300
			AddHandler nodeChangedTimer.Tick, AddressOf nodeChangedTimer_Tick
			layoutManager = manager
		End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
                components.Dispose()
            End If
            If disposing Then bManager.Dispose()
            MyBase.Dispose(disposing)
        End Sub
		Private Sub InitData()
			treeList.DataSource = New Object()
		End Sub
		Private pictureExtensions() As String = { ".png", ".bmp", ".dib", ".jpg", ".jpeg", ".jpe", ".jfif", ".gif", ".tif", ".tiff", ".ico" }
		Private Function IsPicture(ByVal path As String) As Boolean
			For Each mask As String In pictureExtensions
				If path.Length <= mask.Length Then
					Continue For
				End If
				If path.Substring(path.Length - mask.Length, mask.Length) = mask Then
					Return True
				End If
			Next mask
			Return False
		End Function
		Private Sub treeList_VirtualTreeGetChildNodes(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo) Handles treeList.VirtualTreeGetChildNodes
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			If (Not loadDrives) Then
				Dim roots() As String = Directory.GetLogicalDrives()
				e.Children = roots
				loadDrives = True
			Else
				Try
					Dim path As String = CStr(e.Node)
					If Directory.Exists(path) Then
						Dim dirs() As String = Directory.GetDirectories(path)
						Dim files() As String = Directory.GetFiles(path)
						Dim imageFiles(files.Length - 1) As String
						Dim imageFilesCount As Integer = 0
						For Each file As String In files
							If IsPicture(file) Then
								imageFiles(imageFilesCount) = file
								imageFilesCount += 1
							End If
						Next file
						Dim arr(dirs.Length + imageFilesCount - 1) As String
						dirs.CopyTo(arr, 0)
						For i As Integer = 0 To imageFilesCount - 1
							arr(dirs.Length + i) = imageFiles(i)
						Next i
						e.Children = arr
					Else
						e.Children = New Object() { }
					End If
				Catch
					e.Children = New Object() { }
				End Try
			End If
			Cursor.Current = currentCursor
		End Sub
		Private Sub treeList_VirtualTreeGetCellValue(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo) Handles treeList.VirtualTreeGetCellValue
			Dim path As String = CStr(e.Node)
			Dim di As New DirectoryInfo(path)
			If e.Column Is colName Then
				e.CellData = di.Name
			Else
				e.CellData = path
			End If
		End Sub
		Private Sub treeList_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles treeList.FocusedNodeChanged
			nodeChangedTimer.Stop()
			sbOk.Enabled = False
			CurrentPath = CStr(e.Node.GetValue(1))
			teImageScale.Text = String.Empty
			pictureEdit.CancelLoadAsync()
			If FileAssociatedIcons.IsFolder(CurrentPath) Then
				pictureEdit.Image = Nothing
			Else
                nodeChangedTimer.Start()
			End If
		End Sub
		Private Sub nodeChangedTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			pictureEdit.LoadAsync(CurrentPath)
			nodeChangedTimer.Stop()
		End Sub
		Private Sub treeList_GetStateImage(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.GetStateImageEventArgs) Handles treeList.GetStateImage
			e.NodeImageIndex = icons.IconIndex(e.Node.GetDisplayText("Path"), e.Node.Expanded)
		End Sub
		Private Sub pictureEdit_LoadCompleted(ByVal sender As Object, ByVal e As EventArgs) Handles pictureEdit.LoadCompleted
			Dim pictureEdit As PictureEdit = CType((CType(sender, RepositoryItemPictureEdit)).OwnerEdit, PictureEdit)
			If Object.Equals(pictureEdit.Image, Nothing) Then
				Return
			End If
			teImageScale.Text = String.Format("{0} x {1}", pictureEdit.Image.Size.Width, pictureEdit.Image.Size.Height)
			sbOk.Enabled = True
		End Sub
		Private Sub teImageScale_Click(ByVal sender As Object, ByVal e As EventArgs) Handles teImageScale.Click
			treeList.Focus()
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.SuspendLayout()
			LoadFormLayout()
			treeList.ForceInitialize()
			DrawPath(CurrentPath)
			Me.ResumeLayout()
		End Sub
		Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
			MyBase.OnFormClosing(e)
			If DialogResult = System.Windows.Forms.DialogResult.OK AndAlso (Not Object.Equals(resultImage, Nothing)) Then
				resultImage(pictureEdit.Image)
			End If
			SaveFormLayout()
		End Sub
		Public Sub DrawPath(ByVal path As String)
			CurrentPath = path
			treeList.CollapseAll()
			If String.IsNullOrEmpty(path) Then
				Return
			End If
			If path.Chars(path.Length - 1) = "\"c Then
				path = path.Remove(path.Length - 1)
			End If
			Dim pathParts() As String = path.Split(New Char() { "\"c })
			Dim nodePath As String = String.Empty
			Dim lastNode As TreeListNode = Nothing
			For i As Integer = 0 To pathParts.Length - 1
				nodePath &= pathParts(i)
				Dim nodePathWithBackslash As String = nodePath & "\"
				If nodePath.Chars(nodePath.Length - 1) = ":"c Then
					nodePath = nodePathWithBackslash
				End If
				Dim node As TreeListNode = treeList.FindNodeByFieldValue("Path", nodePath)
				If (Not Object.Equals(node, Nothing)) Then
					node.Expanded = True
				End If
				lastNode = node
				nodePath = nodePathWithBackslash
			Next i
			If (Not Object.Equals(lastNode, Nothing)) Then
				lastNode.Expanded = False
				treeList.SetFocusedNode(lastNode)
			End If
		End Sub
		Private Sub pictureEdit_EditValueChanging(ByVal sender As Object, ByVal e As ChangingEventArgs) Handles pictureEdit.EditValueChanging
			Dim bmp As Bitmap = TryCast(e.NewValue, Bitmap)
			Try
				If (Not Object.Equals(bmp, Nothing)) AndAlso (bmp.Width > maxImageSize.Width OrElse bmp.Height > maxImageSize.Height) Then
					Dim delta As Decimal = Math.Max(CDec(bmp.Width) / maxImageSize.Width, CDec(bmp.Height) / maxImageSize.Height)
					Dim size As New Size(CInt(Fix(bmp.Width / delta)), CInt(Fix(bmp.Height / delta)))
					Dim resized As New Bitmap(bmp, size)
					bmp.Dispose()
					e.NewValue = resized
				End If
			Catch
			End Try
		End Sub
		Private Sub treeList_CompareNodeValues(ByVal sender As Object, ByVal e As CompareNodeValuesEventArgs) Handles treeList.CompareNodeValues
			Dim path1 As String = CStr(e.Node1.GetValue(1))
			Dim path2 As String = CStr(e.Node2.GetValue(1))
			Dim isFolder1 As Boolean = FileAssociatedIcons.IsFolder(path1)
			Dim isFolder2 As Boolean = FileAssociatedIcons.IsFolder(path2)
			If isFolder1 AndAlso (Not isFolder2) Then
				If Object.Equals(e.SortOrder, SortOrder.Ascending) Then
					e.Result = -1
				Else
					e.Result = 1
				End If
			End If
			If (Not isFolder1) AndAlso isFolder2 Then
				If Object.Equals(e.SortOrder, SortOrder.Ascending) Then
					e.Result = 1
				Else
					e.Result = -1
				End If
			End If
		End Sub
		Private Sub LoadFormLayout()
			If Object.Equals(layoutManager, Nothing) Then
				Return
			End If
			layoutManager.RestoreFormLayout(New FormLayoutInfo(Me, layoutControl))
		End Sub
		Private Sub SaveFormLayout()
			If Object.Equals(layoutManager, Nothing) Then
				Return
			End If
			layoutManager.SaveFormLayout(New FormLayoutInfo(Me, layoutControl))
		End Sub

        Public Function GetTreeList() As TreeList
            Return treeList
        End Function

	End Class
End Namespace
