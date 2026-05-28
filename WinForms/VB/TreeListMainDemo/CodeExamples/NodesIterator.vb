Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Nodes.Operations

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Nodes iterator", "NodesIterator.cs")>
    Public Module NodesIterator

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.LoadData()
            AddHandler treeList.Load, Sub(s, e)
                treeList.Nodes(CInt((0))).Expand()
                treeList.Nodes(CInt((0))).Nodes(CInt((0))).Expand()
            End Sub
            Return New Object() {treeList}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Allow only one node at level to be expanded", New System.Type() {GetType(Examples.NodesIterator.OperationCollapseAllButThis)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("DoOperation", "DoLocalOperation", "OperationCollapseAllButThis"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(171)>
        Public Sub CollapseAllButThisIterator(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            AddHandler treeList.BeforeExpand, Sub(sender, e)
                Dim op As Examples.NodesIterator.OperationCollapseAllButThis = New Examples.NodesIterator.OperationCollapseAllButThis(e.Node)
                treeList.BeginUpdate()
                If e.Node.ParentNode Is Nothing Then
                    treeList.NodesIterator.DoOperation(op)
                Else
                    treeList.NodesIterator.DoLocalOperation(op, e.Node.ParentNode.Nodes)
                End If

                treeList.EndUpdate()
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Allow only one node at level to be expanded(LINQ)")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Do", "DoLocal"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(171)>
        Public Sub CollapseAllButThisAction(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            AddHandler treeList.BeforeExpand, Sub(sender, e)
                Dim collapseAllButThis As System.Action(Of DevExpress.XtraTreeList.Nodes.TreeListNode) = Sub(node)
                    If Not Object.ReferenceEquals(node, e.Node) Then node.Expanded = False
                End Sub
                treeList.BeginUpdate()
                If e.Node.ParentNode Is Nothing Then
                    treeList.NodesIterator.[Do](collapseAllButThis)
                Else
                    treeList.NodesIterator.DoLocal(collapseAllButThis, e.Node.ParentNode.Nodes)
                End If

                treeList.EndUpdate()
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Set value of child nodes when parent's value is changed")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CellValueChanged", "DoLocal"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleVersionID(171)>
        Public Sub RecursiveCellChecking(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Make the all the columns except Mark non-editable
            treeList.OptionsBehavior.Editable = True
            Dim markColumn As DevExpress.XtraTreeList.Columns.TreeListColumn = treeList.Columns("Mark")
            For Each column As DevExpress.XtraTreeList.Columns.TreeListColumn In treeList.Columns
                If column Is markColumn Then Continue For
                column.OptionsColumn.AllowEdit = False
            Next

            ' Post the check value editor immediately
            AddHandler markColumn.RealColumnEdit.EditValueChanged, Sub(sender, e) treeList.PostEditor()
            ' Proceed all the nested nodes
            AddHandler treeList.CellValueChanged, Sub(sender, e)
                treeList.NodesIterator.DoLocal(execute:=Sub(node) node(e.Column) = e.Value, nodes:=e.Node.Nodes)
                '
                Dim parent As DevExpress.XtraTreeList.Nodes.TreeListNode = e.Node.ParentNode
                Dim markValue As Boolean = Object.Equals(e.Value, True)
                While parent IsNot Nothing
                    If markValue Then
                        Dim allChildrenHasMark As Boolean = True
                        treeList.NodesIterator.DoLocal(execute:=Sub(node) allChildrenHasMark = allChildrenHasMark And Not Object.Equals(node(e.Column), False), nodes:=parent.Nodes)
                        parent("Mark") = allChildrenHasMark
                    Else
                        parent("Mark") = False
                    End If

                    parent = parent.ParentNode
                End While
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class OperationCollapseAllButThis
            Inherits DevExpress.XtraTreeList.Nodes.Operations.TreeListOperation

            Private nodeCore As DevExpress.XtraTreeList.Nodes.TreeListNode

            Public Sub New(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode)
                Me.nodeCore = node
            End Sub

            Public Overrides Function NeedsVisitChildren(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode) As Boolean
                Return True
            End Function

            Public Overrides Function CanContinueIteration(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode) As Boolean
                Return True
            End Function

            Public Overrides ReadOnly Property NeedsFullIteration As Boolean
                Get
                    Return False
                End Get
            End Property

            Public Overrides Sub Execute(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode)
                If node Is Me.nodeCore Then Return
                node.Expanded = False
            End Sub
        End Class
    End Module
End Namespace
