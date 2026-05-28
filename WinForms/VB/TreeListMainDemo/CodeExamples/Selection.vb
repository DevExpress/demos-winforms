Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Selection", "Selection.cs")>
    Public Module Selection

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.LoadData()
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
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Multiple row/cell selection")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("OptionsSelection", "SelectCells")>
        Public Sub CustomizingSelection(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' This property controls whether multi-select feature is enabled
            treeList.OptionsSelection.MultiSelect = True
            ' Controls whether multiple cells or rows can be selected
            ' Available modes:
            '     CellSelect - Individual cells and blocks of cells can be selected.  
            '     RowSelect - Multiple rows can be selected using the mouse and keyboard. Individual cells cannot be selected.
            treeList.OptionsSelection.MultiSelectMode = DevExpress.XtraTreeList.TreeListMultiSelectMode.CellSelect
            ' select some cells after loading
            AddHandler treeList.Load, Sub(s, e)
                treeList.ExpandAll()
                '
                Dim colNotes = treeList.Columns("Notes")
                Dim colMark = treeList.Columns("Mark")
                Dim jupiterNodes = treeList.Nodes(CInt((0))).Nodes(CInt((0))).Nodes
                treeList.SelectCells(startNode:=jupiterNodes.FirstNode, startColumn:=colNotes, endNode:=jupiterNodes.LastNode, endColumn:=colMark)
            End Sub
        End Sub
    End Module
End Namespace
