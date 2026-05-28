Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Demos
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Annotations
Imports DevExpress.XtraTreeList.Menu
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Painter

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class HierarchyColumn
        Inherits TutorialControl

        Friend Enum NodeMenuItemID
            Indent = 6
            Outdent = 7
        End Enum

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"TreeListMainDemo\Modules\HierarchyColumn", "TreeListMainDemo\Options\ucScrollAnnotationsOptions"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "HierarchyColumn"
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            treeList1.DataSource = TaskGenerator.Default.GenerateSource(400)
            treeList1.ExpandAll()
            repositoryItemPriorityComboBox.AddImages(svgImageCollection)
            repositoryItemDescriptionComboBox.Items.Add("", True, 3)
            repositoryItemCompletedComboBox.Items.Add("", True, 2)
            AddHandler treeList1.MouseDown, AddressOf OnMouseDown
            AddHandler treeList1.NodeCellStyle, AddressOf OnNodeCellStyle
            AddHandler treeList1.ScrollAnnotationsStyle, AddressOf OnScrollAnnotationsStyle
            AddHandler treeList1.PopupMenuShowing, AddressOf OnPopupMenuShowing
            ucScrollAnnotationsOptions.InitData(treeList1)
            treeList1.ClearSelection()
            treeList1.ApplyFindFilter("QA")
        End Sub

        Private Sub OnScrollAnnotationsStyle(ByVal sender As Object, ByVal e As TreeListScrollAnnotationsStyleEventArgs)
            Dim styleColor = ucScrollAnnotationsOptions.GetColor(e.Kind)
            If Not styleColor.IsEmpty Then e.Color = styleColor
        End Sub

        Private Sub OnPopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If TypeOf e.Menu Is TreeListNodeMenu Then
                AddItem(e.Menu, NodeMenuItemID.Indent, treeList1.CanIndentNodes(treeList1.Selection))
                AddItem(e.Menu, NodeMenuItemID.Outdent, treeList1.CanOutdentNodes(treeList1.Selection))
                e.Allow = True
            End If
        End Sub

        Private Sub AddItem(ByVal menu As TreeListMenu, ByVal id As NodeMenuItemID, ByVal enabled As Boolean)
            Dim _item As Utils.Menu.DXMenuItem = New Utils.Menu.DXMenuItem(id.ToString())
            _item.Tag = id
            _item.ImageOptions.SvgImage = svgImageCollection(CInt(id))
            _item.Enabled = enabled
            AddHandler _item.Click, AddressOf OnMenuItemClick
            menu.Items.Add(_item)
        End Sub

        Private Sub OnMenuItemClick(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim _item = TryCast(sender, Utils.Menu.DXMenuItem)
            If CType(_item.Tag, NodeMenuItemID) = NodeMenuItemID.Indent Then treeList1.IndentNodes(treeList1.Selection, False)
            If CType(_item.Tag, NodeMenuItemID) = NodeMenuItemID.Outdent Then treeList1.OutdentNodes(treeList1.Selection, False)
        End Sub

        Private Sub OnNodeCellStyle(ByVal sender As Object, ByVal e As GetCustomNodeCellStyleEventArgs)
            Dim task As EmployeeTask = TryCast(treeList1.GetRow(e.Node.Id), EmployeeTask)
            If task Is Nothing OrElse Not task.IsCompleted Then Return
            e.Appearance.FontStyleDelta =(FontStyle.Italic Or FontStyle.Strikeout)
        End Sub

        Private Overloads Sub OnMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button <> MouseButtons.Left Then Return
            Dim hitInfo = treeList1.CalcHitInfo(e.Location)
            If hitInfo.InRowCell AndAlso hitInfo.Column Is descriptionColumn Then
                Dim task As EmployeeTask = TryCast(treeList1.GetRow(hitInfo.Node.Id), EmployeeTask)
                If task IsNot Nothing AndAlso task.HasDescription Then ToolTipController.DefaultController.ShowHint(task.Description, ToolTipLocation.RightCenter)
            End If
        End Sub

        Private Function GetPalette() As Utils.Design.ISvgPaletteProvider
            Return Svg.SvgPaletteHelper.GetSvgPalette(treeList1.LookAndFeel, Utils.Drawing.ObjectState.Normal)
        End Function

        ' Addding bookmark items
        '<treeList1>
        Private ReadOnly bookmarks As HashSet(Of Integer) = New HashSet(Of Integer)() From {5, 17, 74}

        Private Sub OnCustomScrollAnnotation(ByVal sender As Object, ByVal e As TreeListCustomScrollAnnotationsEventArgs)
            Dim rowHandles As TreeListNode() = bookmarks.[Select](Function(x) treeList1.FindNodeByID(x)).ToArray()
            e.SetAnnotations(DevExpress.LookAndFeel.DXSkinColors.IconColors.Blue, rowHandles)
        End Sub

        Private Sub OnCustomDrawRowIndicator(ByVal sender As Object, ByVal e As CustomDrawNodeIndicatorEventArgs)
            If e.Node Is Nothing OrElse treeList1.IsAutoFilterNode(e.Node) Then Return
            If e.Info.ImageIndex = TreeListPainter.ErrorInNodeIndicatorImageIndex OrElse e.Info.ImageIndex = TreeListPainter.ErrorInFocusedNodeIndicatorImageIndex Then
                ' suppress error indicator
                e.Info.ImageIndex = -1
            End If

            If Not ucScrollAnnotationsOptions.BookmarksEnabled OrElse Not bookmarks.Contains(e.Node.Id) Then Return
            e.DefaultDraw()
            Dim bookmarkImage = svgImageCollection.GetImage("bookmark", GetPalette(), ScaleDPI.ScaleSize(New Size(8, 8)))
            Dim imageBounds = PlacementHelper.Arrange(bookmarkImage.Size, e.Bounds, ContentAlignment.MiddleLeft)
            e.Cache.DrawImageUnscaled(bookmarkImage, imageBounds)
            e.Handled = True
        End Sub

        ' Bookmark items navigation
        Private Overloads Sub OnKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyData = (Keys.F2 Or Keys.Control) OrElse e.KeyData = (Keys.B Or Keys.Control) Then e.Handled = ToggleBookmark(treeList1.FocusedNode)
            ' navigating via shortcuts
            If e.KeyData = Keys.F2 Then e.Handled = treeList1.MoveToNextScrollAnnotation(ScrollAnnotationKind.Custom)
            If e.KeyData = (Keys.F2 Or Keys.Shift) Then e.Handled = treeList1.MoveToPrevScrollAnnotation(ScrollAnnotationKind.Custom)
        End Sub

        Private Function ToggleBookmark(ByVal node As TreeListNode) As Boolean
            Dim dataIndex As Integer = If(node IsNot Nothing, node.Id, -1)
            If dataIndex < 0 Then Return False
            If Not bookmarks.Remove(dataIndex) Then bookmarks.Add(dataIndex)
            treeList1.RefreshScrollAnnotations(ScrollAnnotationKind.Custom)
            treeList1.InvalidateNode(node)
            Return True
        End Function

        '</treeList1>
#Region "Export"
        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property
#End Region  ' Export
    End Class
End Namespace
