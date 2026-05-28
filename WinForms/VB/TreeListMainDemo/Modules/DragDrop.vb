Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.Utils.DragDrop
Imports System.Collections.Generic
Imports DevExpress.Internal

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class TreeListDragDrop
        Inherits TutorialControl

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return treeList1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitProjectsData()
        End Sub

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"TreeListMainDemo\Modules\DragDrop"}
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "DragDrop"
            End Get
        End Property

        Private Sub InitProjectsData()
            Dim dataSet As DataSet = CreateDataSource()
            If dataSet Is Nothing Then Return
            listBoxControl.DataSource = dataSet.Tables(1).DefaultView
            treeList1.DataSource = dataSet.Tables(0)
            treeList1.ExpandAll()
            AddHandler DragDropManager.Default.DragOver, AddressOf OnDragOver
            AddHandler DragDropManager.Default.DragDrop, AddressOf OnDragDrop
        End Sub

        Private Overloads Sub OnDragDrop(ByVal sender As Object, ByVal e As DragDropEventArgs)
            If ReferenceEquals(e.Source, e.Target) Then Return
            e.Handled = True
            If e.Action = DragDropActions.None OrElse e.InsertType = InsertType.None Then Return
            If e.Target Is treeList1 Then OnTreeListDrop(e)
            If e.Target Is listBoxControl Then OnListBoxDrop(e)
            Cursor.Current = Cursors.Default
        End Sub

        '<listBoxControl>
        Private Sub OnListBoxDrop(ByVal e As DragDropEventArgs)
            Dim dataView As DataView = TryCast(listBoxControl.DataSource, DataView)
            If dataView Is Nothing Then Return
            Dim nodes = e.GetData(Of IList(Of TreeListNode))()
            If nodes Is Nothing Then Return
            Dim index As Integer = CalcDestItemIndex(e)
            treeList1.BeginUpdate()
            listBoxControl.BeginUpdate()
            listBoxControl.UnSelectAll()
            Dim selectIndices As List(Of Integer) = New List(Of Integer)()
            DropNode(nodes, dataView, selectIndices, index, e.Action = DragDropActions.Copy)
            For i As Integer = 0 To selectIndices.Count - 1
                listBoxControl.SetSelected(selectIndices(i), True)
            Next

            listBoxControl.EndUpdate()
            treeList1.EndUpdate()
        End Sub

        '</listBoxControl>
        Private Sub DropNode(ByVal nodes As IEnumerable(Of TreeListNode), ByVal dataView As DataView, ByVal selectIndices As List(Of Integer), ByRef index As Integer, ByVal isCopy As Boolean)
            Dim _nodes As List(Of TreeListNode) = New List(Of TreeListNode)(nodes)
            For Each node As TreeListNode In _nodes
                If node.HasChildren Then DropNode(node.Nodes, dataView, selectIndices, index, isCopy)
                Dim rowView As DataRowView = TryCast(treeList1.GetRow(node.Id), DataRowView)
                If rowView Is Nothing Then Return
                Dim newRow = dataView.Table.NewRow()
                For i As Integer = 0 To dataView.Table.Columns.Count - 1
                    Dim rowColumn = rowView.Row.Table.Columns(i)
                    Dim newRowColumn = newRow.Table.Columns(i)
                    newRow(newRowColumn) = rowView.Row(rowColumn)
                Next

                dataView.Table.Rows.InsertAt(newRow, index)
                If Not isCopy Then treeList1.Nodes.Remove(node)
                selectIndices.Add(System.Math.Min(System.Threading.Interlocked.Increment(index), index - 1))
            Next
        End Sub

        Private Function CalcDestItemIndex(ByVal e As DragDropEventArgs) As Integer
            Dim hitPoint As Point = listBoxControl.PointToClient(e.Location)
            Dim index As Integer = listBoxControl.IndexFromPoint(hitPoint)
            If e.InsertType = InsertType.After Then index += 1
            If index = -1 AndAlso listBoxControl.ItemCount = 0 Then Return 0
            Return index
        End Function

        '<treeList1>
        Private Sub OnTreeListDrop(ByVal e As DragDropEventArgs)
            Dim dataView As DataView = TryCast(listBoxControl.DataSource, DataView)
            If dataView Is Nothing Then Return
            Dim items = e.GetData(Of IEnumerable(Of Object))()
            If items Is Nothing Then Return
            Dim destNode = GetDestNode(e.Location)
            Dim index As Integer = CalcDestNodeIndex(e, destNode)
            treeList1.BeginUpdate()
            listBoxControl.BeginUpdate()
            treeList1.Selection.UnselectAll()
            Dim _items As List(Of Object) = New List(Of Object)(items)
            For Each _item As Object In _items
                Dim rowView As DataRowView = TryCast(_item, DataRowView)
                Dim node As TreeListNode = treeList1.AppendNode(rowView.Row.ItemArray, If(index = -1000, destNode, Nothing))
                If index > -1 Then
                    treeList1.MoveNode(node, destNode.ParentNode, True, index)
                    index += 1
                End If

                If e.Action <> DragDropActions.Copy Then dataView.Table.Rows.Remove(rowView.Row)
                treeList1.SelectNode(node)
                If node.ParentNode IsNot Nothing Then node.ParentNode.Expand()
            Next

            listBoxControl.EndUpdate()
            treeList1.EndUpdate()
        End Sub

        '</treeList1>
        Private Function GetDestNode(ByVal hitPoint As Point) As TreeListNode
            Dim pt As Point = treeList1.PointToClient(hitPoint)
            Dim ht As TreeListHitInfo = treeList1.CalcHitInfo(pt)
            Dim destNode As TreeListNode = ht.Node
            If TypeOf destNode Is TreeListAutoFilterNode Then Return Nothing
            Return destNode
        End Function

        Private Function CalcDestNodeIndex(ByVal e As DragDropEventArgs, ByVal destNode As TreeListNode) As Integer
            If destNode Is Nothing Then Return -1
            If e.InsertType = InsertType.AsChild Then Return -1000
            Dim nodes = If(destNode.ParentNode Is Nothing, treeList1.Nodes, destNode.ParentNode.Nodes)
            Dim index As Integer = nodes.IndexOf(destNode)
            If e.InsertType = InsertType.After Then Return System.Threading.Interlocked.Increment(index)
            Return index
        End Function

        Private Overloads Sub OnDragOver(ByVal sender As Object, ByVal e As DragOverEventArgs)
            If ReferenceEquals(e.Source, e.Target) Then Return
            e.Default()
            If e.InsertType = InsertType.None Then Return
            e.Action = If(IsCopy(e.KeyState), DragDropActions.Copy, DragDropActions.Move)
            Dim current As Cursor = Cursors.No
            If e.Action <> DragDropActions.None Then current = Cursors.Default
            e.Cursor = current
        End Sub

        Private Function IsCopy(ByVal key As DragDropKeyState) As Boolean
            Return(key And DragDropKeyState.Control) <> 0
        End Function

        Private Function CreateDataSource() As DataSet
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("EmployeesGroups.xml")
            If Not Equals(DBFileName, "") Then
                Dim dataSet As DataSet = New DataSet()
                dataSet.ReadXml(DBFileName)
                dataSet.Tables(0).Columns.Add("FullName", GetType(String), "FirstName + ' ' + LastName")
                Dim jobHunter = dataSet.Tables.Add("JobHunter")
                For Each column As DataColumn In dataSet.Tables(0).Columns
                    jobHunter.Columns.Add(column.ColumnName, column.DataType, column.Expression)
                Next

                For i As Integer = 0 To 10 - 1
                    Dim id As Integer = dataSet.Tables(0).Rows.Count - 1
                    Dim row = dataSet.Tables(0).Rows(id).ItemArray
                    dataSet.Tables(0).Rows.RemoveAt(id)
                    jobHunter.Rows.Add(row)
                Next

                Return dataSet
            End If

            Return Nothing
        End Function
    End Class
End Namespace
