Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Data-binding modes", "DataBindingModes.cs")>
    Public Module DataBindingModes

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            AddHandler treeList.DataSourceChanged, Sub(s, e)
                If TypeOf treeList.DataSource Is System.Collections.Generic.IEnumerable(Of DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject) Then
                    treeList.ExpandAll()
                    treeList.Columns(CStr(("Name"))).BestFit()
                End If
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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Bound mode"), Examples.SpaceObjectCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("KeyFieldName", "ParentFieldName", "DataSource")>
        Public Sub InitializeDataBoundMode(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Initialize the Data Source with list of self-references objects
            ' All the columns will be created automatically
            ' To generate Key/Parent columns(service columns) uncomment the following line
            ' treeList.OptionsBehavior.PopulateServiceColumns = true;
            treeList.KeyFieldName = "ID"
            treeList.ParentFieldName = "ParentID"
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.LoadData()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Unbound mode")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AppendNode")>
        Public Sub InitializeDataUnboundMode(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Add the column
            treeList.Columns.AddVisible("Text")
            '  TreeList.AppendNode adds a new TreeListNode containing the specified values to the XtraTreeList.
            For i As Integer = 0 To 5 - 1
                Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode = treeList.AppendNode(New Object() {"Root Node " & i.ToString()}, parentNode:=Nothing)
                For j As Integer = i + 1 To i + 3 - 1
                    treeList.AppendNode(New Object() {"Child Node " & j.ToString()}, parentNode:=node)
                Next
            Next
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Virtual mode", New System.Type() {GetType(Examples.DataBindingModes.VirtualData)})>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("DataSource")>
        Public Sub InitializeDataVirtualMode(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' Add the column
            treeList.Columns.AddVisible("Text")
            ' Initialize the Data Source with object that implements IVirtualTreeListData interface
            treeList.DataSource = New Examples.DataBindingModes.VirtualData()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass>
        Public Class VirtualData
            Implements DevExpress.XtraTreeList.TreeList.IVirtualTreeListData

            Const LevelCapacity As Integer = 10

            Private ReadOnly parentID As Integer

            Private ReadOnly levelCore As Integer

            Public Sub New()
                Me.parentID = 0
            End Sub

            Private Sub New(ByVal id As String, ByVal parentID As Integer, ByVal level As Integer)
                Me.parentID = parentID
                Me.levelCore = level
                Me.Text = "Level " & level.ToString() & ": Node" & id
            End Sub

            Public Property Text As String

            Public ReadOnly Property Level As Integer
                Get
                    Return Me.levelCore
                End Get
            End Property

            Private Sub VirtualTreeGetCellValue(ByVal info As DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo) Implements Global.DevExpress.XtraTreeList.TreeList.IVirtualTreeListData.VirtualTreeGetCellValue
                Dim virtualData = CType(info.Node, Examples.DataBindingModes.VirtualData)
                info.CellData = virtualData.Text
            End Sub

            Private Sub VirtualTreeSetCellValue(ByVal info As DevExpress.XtraTreeList.VirtualTreeSetCellValueInfo) Implements Global.DevExpress.XtraTreeList.TreeList.IVirtualTreeListData.VirtualTreeSetCellValue
                Dim virtualData = CType(info.Node, Examples.DataBindingModes.VirtualData)
                virtualData.Text = info.NewCellData.ToString()
            End Sub

            Private Sub VirtualTreeGetChildNodes(ByVal info As DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo) Implements Global.DevExpress.XtraTreeList.TreeList.IVirtualTreeListData.VirtualTreeGetChildNodes
                If Me.parentID > 0 AndAlso Integer.MaxValue \ Me.parentID < Examples.DataBindingModes.VirtualData.LevelCapacity Then Return
                Dim virtualDataNode = CType(info.Node, Examples.DataBindingModes.VirtualData)
                Dim children As System.Collections.Generic.List(Of Examples.DataBindingModes.VirtualData) = New System.Collections.Generic.List(Of Examples.DataBindingModes.VirtualData)()
                Dim startIndex As Integer =(Me.parentID * Examples.DataBindingModes.VirtualData.LevelCapacity) + 1
                For i As Integer = startIndex To Examples.DataBindingModes.VirtualData.LevelCapacity - (2 * Me.Level) + startIndex - 1
                    children.Add(New Examples.DataBindingModes.VirtualData(i.ToString(), i, virtualDataNode.Level + 1))
                Next

                info.Children = children
            End Sub
        End Class
    End Module
End Namespace
