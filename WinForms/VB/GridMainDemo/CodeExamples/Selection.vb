Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Selection", "Selection.cs")>
    Public Module Selection

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

#Region "Selection"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Enable multiple row/cell selection"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("OptionsSelection", "MultiSelect", "MultiSelectMode")>
        Public Sub EnableMultipleSelection(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' This property controls whether multi-select feature is enabled
            gridView.OptionsSelection.MultiSelect = True
            ' Controls whether multiple cells or rows can be selected
            gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
        ' Available modes:
        ' CellSelect - Individual cells and blocks of cells can be selected.  
        ' CheckBoxRowSelect - Multiple rows can be selected using the mouse, keyboard and built-in Check column. Individual cells cannot be selected. 
        ' RowSelect - Multiple rows can be selected using the mouse and keyboard. Individual cells cannot be selected.
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Select/unselect cells"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SelectCell", "UnselectCell")>
        Public Sub SelectUnselectCells(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsSelection.MultiSelect = True
            gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
            ' Selects the cell.
            gridView.SelectCell(2, gridView.Columns("Name"))
            Dim btnUnselect As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Unselect cell", .Dock = System.Windows.Forms.DockStyle.Top}
            ' Unselects a cell
            AddHandler btnUnselect.Click, Sub(s, e) gridView.UnselectCell(2, gridView.Columns("Name"))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Select/unselect rows"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SelectRow", "UnSelectRow")>
        Public Sub SelectUnselectRows(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsSelection.MultiSelect = True
            gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
            ' Selects the row.
            gridView.SelectRow(2)
            Dim btnUnselect As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Unselect row", .Dock = System.Windows.Forms.DockStyle.Top}
            ' Unselects a row.
            AddHandler btnUnselect.Click, Sub(s, e) gridView.UnselectRow(2)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Select cell ranges"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SelectCells")>
        Public Sub SelectUnselectCellRange(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsSelection.MultiSelect = True
            gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
            ' Clear previous selection.
            gridView.ClearSelection()
            Dim startRowHandle As Integer = 2
            Dim endRowHandle As Integer = 4
            Dim startColumn As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("ID")
            Dim endColumn As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("Mark")
            ' Selects multiple cells.
            gridView.SelectCells(startRowHandle, startColumn, endRowHandle, endColumn)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Select row ranges"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SelectRows")>
        Public Sub SelectUnselectRowRange(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsSelection.MultiSelect = True
            gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
            ' Clear previous selection.
            gridView.ClearSelection()
            ' Selects multiple rows.
            gridView.SelectRows(2, 5)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Obtain selected rows"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("GetSelectedRows")>
        Public Sub ObtainSelectedRows(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsSelection.MultiSelect = True
            gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
            gridView.SelectRows(2, 4)
            'Display currently selected rows in a separate form
            Dim b As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Obtain selected rows", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler b.Click, Sub(s, e)
                Dim selectedRows As System.ComponentModel.BindingList(Of DevExpress.DXperience.Demos.CodeDemo.Data.SampleData) = New System.ComponentModel.BindingList(Of DevExpress.DXperience.Demos.CodeDemo.Data.SampleData)()
                For Each rowHandle As Integer In gridView.GetSelectedRows()
                    selectedRows.Add(TryCast(gridView.GetRow(rowHandle), DevExpress.DXperience.Demos.CodeDemo.Data.SampleData))
                Next

                Dim frm As DevExpress.XtraEditors.XtraForm = New DevExpress.XtraEditors.XtraForm With {.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent}
                Dim frmGridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
                Dim frmGrid As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl With {.MainView = frmGridView, .Parent = frm, .DataSource = selectedRows, .Dock = System.Windows.Forms.DockStyle.Fill}
                frm.ShowDialog(gridControl.FindForm())
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent rows from being selected"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("GetSelectedRows", "UnselectRow")>
        Public Sub PreventSelectUnselectRows(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsSelection.MultiSelect = True
            gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect
            gridView.SelectRows(2, 5)
            Dim rowsWhichCannotBeSelected As System.Collections.Generic.List(Of Integer) = New System.Collections.Generic.List(Of Integer) From {0, 1, 6, 7, 8, 9}
            'This property is used to avoid recursive invocation of the SelectionChanged event handler
            Dim lockSelectionChanged As Boolean = False
            ' The SelectionChanged event fires each time selection is changed in multiple selection mode
            AddHandler gridView.SelectionChanged, Sub(s, e)
                If lockSelectionChanged Then Return
                lockSelectionChanged = True
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                For Each rowHandle As Integer In view.GetSelectedRows()
                    If rowsWhichCannotBeSelected.Contains(rowHandle) Then view.UnselectRow(rowHandle)
                Next

                lockSelectionChanged = False
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("How to select a column in Excel style"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AppearanceCell")>
        Public Sub SelectColumnExcelStyle(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim selectedColumns As System.Collections.Generic.List(Of String) = New System.Collections.Generic.List(Of String)()
            AddHandler gridView.MouseDown, Sub(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                Dim info As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = view.CalcHitInfo(New System.Drawing.Point(e.X, e.Y)) ' Obtain Hit Information identifying a visual element of the control under a specific point
                If info.InColumn Then
                    If Not selectedColumns.Contains(info.Column.FieldName) Then
                        info.Column.AppearanceCell.Assign(view.PaintAppearance.SelectedRow) ' Modify the selected column's visual settings like color, font etc
                        selectedColumns.Add(info.Column.FieldName)
                    Else
                        selectedColumns.Remove(info.Column.FieldName)
                        info.Column.AppearanceCell.Reset() ' Reset the appearance settings to their default values
                    End If

                    DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(CType((e), System.Windows.Forms.MouseEventArgs)).Handled = True
                End If
            End Sub
        End Sub
#End Region
    End Module
End Namespace
