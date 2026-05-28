Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows
Imports SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Selection", "Selection.cs")>
    Public Module Selection

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim vGridControl As DevExpress.XtraVerticalGrid.VGridControl = New DevExpress.XtraVerticalGrid.VGridControl()
            vGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            vGridControl.Parent = sampleHost
            vGridControl.RowHeaderWidth = DevExpress.Utils.ScaleUtils.ScaleValue(120)
            vGridControl.RecordWidth = DevExpress.Utils.ScaleUtils.ScaleValue(140)
            vGridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(10)
            Return New Object() {vGridControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraVerticalGrid.VGridControl).Dispose()
        End Sub

#Region "Selection"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Enable multiple row/cell selection"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("OptionsSelection", "MultiSelect", "MultiSelectMode")>
        Public Sub EnableMultipleSelection(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            ' Specifies whether or not end-users can select multiple rows or cells.
            vGridControl.OptionsSelectionAndFocus.MultiSelect = True
            ' Specifies whether a user can select individual cells, or only entire rows. 
            vGridControl.OptionsSelectionAndFocus.MultiSelectMode = DevExpress.XtraVerticalGrid.MultiSelectMode.CellSelect
        ' Available property values: RecordSelect, CellSelect, RowSelect
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Select/deselect cells"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SelectCell", "UnselectCell")>
        Public Sub SelectUnselectCells(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            vGridControl.OptionsSelectionAndFocus.MultiSelect = True
            vGridControl.OptionsSelectionAndFocus.MultiSelectMode = DevExpress.XtraVerticalGrid.MultiSelectMode.CellSelect
            ' Selects the cell.
            vGridControl.SelectCell(1, "Name")
            vGridControl.SelectCell(2, "Name")
            Dim btnUnselect As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = vGridControl.Parent, .Text = "Deselect cell", .Dock = System.Windows.Forms.DockStyle.Top}
            AddHandler btnUnselect.Click, Sub(s, e)
                ' Deselect a cell
                vGridControl.UnselectCell(1, "Name")
                vGridControl.UnselectCell(2, "Name")
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Select/deselect rows"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SelectRow", "UnSelectRow")>
        Public Sub SelectUnselectRows(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            vGridControl.OptionsSelectionAndFocus.MultiSelect = True
            vGridControl.OptionsSelectionAndFocus.MultiSelectMode = DevExpress.XtraVerticalGrid.MultiSelectMode.RowSelect
            ' Selects the row.
            vGridControl.SelectRow("Name")
            Dim btnUnselect As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = vGridControl.Parent, .Text = "Deselect row", .Dock = System.Windows.Forms.DockStyle.Top}
            ' Deselect a row.
            AddHandler btnUnselect.Click, Sub(s, e) vGridControl.UnselectRow("Name")
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Select/deselect records"), DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("SelectRecord", "UnSelectRecord")>
        Public Sub SelectUnselectRecords(ByVal vGridControl As DevExpress.XtraVerticalGrid.VGridControl)
            vGridControl.OptionsSelectionAndFocus.MultiSelect = True
            vGridControl.OptionsSelectionAndFocus.MultiSelectMode = DevExpress.XtraVerticalGrid.MultiSelectMode.RecordSelect
            ' Selects the record.
            vGridControl.SelectRecord(2)
            Dim btnUnselect As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = vGridControl.Parent, .Text = "Deselect record", .Dock = System.Windows.Forms.DockStyle.Top}
            ' Deselect a record.
            AddHandler btnUnselect.Click, Sub(s, e) vGridControl.UnselectRecord(2)
        End Sub
#End Region  ' Selection
    End Module
End Namespace
