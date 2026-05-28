Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Data
Imports System.Drawing
Imports System.ComponentModel
Imports System.Collections
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Group and sort data", "GroupingAndSorting.cs")>
    Public Module GroupingAndSorting

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(10)
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Grouping and Sorting"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Sort against columns"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SortOrder")>
        Public Sub SortAgainstColumns(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' The SortOrder property value is used to determine 
            ' which sort order is currently applied to the column
            gridView.Columns(CStr(("Length"))).SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            gridView.Columns(CStr(("Mark"))).SortOrder = DevExpress.Data.ColumnSortOrder.Descending
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom sorting"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomColumnSort", "SortMode", "Result")>
        Public Sub CustomSorting(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Custom Column Sorting            
            Dim column As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("Length")
            column.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom
            AddHandler gridView.CustomColumnSort, Sub(sender, e)
                ' Always show 0 at the bottom
                If Equals(e.Column.FieldName, "Length") Then
                    If CDbl(e.Value1) = 0 AndAlso CDbl(e.Value2) <> 0 Then
                        e.Result = If(e.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending, 1, -1)
                    ElseIf CDbl(e.Value2) = 0 AndAlso CDbl(e.Value1) <> 0 Then
                        e.Result = If(e.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending, -1, 1)
                    Else
                        ' default comparison
                        e.Result = System.Collections.Comparer.[Default].Compare(e.Value1, e.Value2)
                    End If

                    e.Handled = True
                End If
            End Sub
            column.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Hide group rows’ expand/collapse buttons"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawGroupRow")>
        Public Sub HideGroupRowButton(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CInt((0))).Group()
            ' Allows you to paint group rows manually
            AddHandler gridView.CustomDrawGroupRow, Sub(s, e)
                Dim ggri As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo = TryCast(e.Info, DevExpress.XtraGrid.Views.Grid.ViewInfo.GridGroupRowInfo)
                ' Reduce the size of the expand-collapse button to zero
                ggri.ButtonBounds = System.Drawing.Rectangle.Empty
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent group rows from being collapsed"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("GroupRowCollapsing", "Allow")>
        Public Sub PreventCollapsingGroupRows(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CStr(("Mark"))).Group()
            gridView.ExpandAllGroups()
            ' The GroupRowCollapsing event is raised on an attempt to collapse a group row
            AddHandler gridView.GroupRowCollapsing, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                ' Restricting Full Collapse
                If e.RowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    e.Allow = False
                Else
                    ' Restricting "Checked" group rows from being collapsed
                    If CBool(view.GetGroupRowValue(e.RowHandle)) Then e.Allow = False
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent group rows from being expanded"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("GroupRowExpanding", "Allow")>
        Public Sub PreventExpandingGroupRows(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.Columns(CStr(("Mark"))).Group()
            ' The GroupRowExpanding event is raised on an attempt to expand a group row
            AddHandler gridView.GroupRowExpanding, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                ' Restricting Full Expand
                If e.RowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                    e.Allow = False
                Else
                    ' Restricting "Checked" group rows from being expanded
                    If CBool(view.GetGroupRowValue(e.RowHandle)) Then e.Allow = False
                End If
            End Sub
        End Sub
#End Region
    End Module
End Namespace
