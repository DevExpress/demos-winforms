Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Add and remove rows", "AddAndRemoveRows.cs")>
    Public Module AddAndRemoveRows

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(6)
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Add and remove rows"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Use New Item Row to add rows"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("NewItemRowPosition")>
        Public Sub UseNewItemRowToAddRows(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Display a New Item Row to add rows to the View.
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top ' Available modes: Top, Bottom, None
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Init newly added rows in a custom manner"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("InitNewRow")>
        Public Sub InitNewRow(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
            'Handle the InitNewRow event to initialize newly added rows. To initialize row cells use the SetRowCellValue method
            AddHandler gridView.InitNewRow, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                view.SetRowCellValue(e.RowHandle, view.Columns("RecordDate"), System.DateTime.Today) ' Set the new row cell value
                view.SetRowCellValue(e.RowHandle, view.Columns("Name"), "CustomName")
                Dim newRowID As Integer = System.Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "ID")) ' Obtain the new row cell value 
                view.SetRowCellValue(e.RowHandle, view.Columns("Notes"), String.Format("Row ID: {0}", newRowID))
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Remove rows with the Ctrl+Delete shortcut"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("DeleteSelectedRows")>
        Public Sub RemoveRowWhenShortCutIsPressed(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsBehavior.Editable = False
            ' Handle the ProcessGridKey event to process key presses before they are processed by the gridcontrol.
            AddHandler gridControl.ProcessGridKey, Sub(s, e)
                If e.KeyCode = System.Windows.Forms.Keys.Delete AndAlso e.Modifiers = System.Windows.Forms.Keys.Control Then
                    If DevExpress.XtraEditors.XtraMessageBox.Show("Delete row(s)?", "Delete rows dialog", System.Windows.Forms.MessageBoxButtons.YesNo) <> System.Windows.Forms.DialogResult.Yes Then Return
                    Dim grid As DevExpress.XtraGrid.GridControl = TryCast(s, DevExpress.XtraGrid.GridControl)
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(grid.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
                    'Deletes the selected rows in multiple selection mode or focused row
                    '  in single selection mode. 
                    view.DeleteSelectedRows()
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent a row from being deleted"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("DeleteSelectedRows", "RowDeleting")>
        Public Sub PreventDeletingRow(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsBehavior.Editable = False
            Dim btnDeleteRow As DevExpress.XtraEditors.SimpleButton = New DevExpress.XtraEditors.SimpleButton With {.Parent = gridControl.Parent, .Text = "Delete focused row", .Dock = System.Windows.Forms.DockStyle.Top}
            'Deletes the selected rows in multiple selection mode or focused row
            '   in single selection mode. 
            AddHandler btnDeleteRow.Click, Sub(s, e) gridView.DeleteSelectedRows()
            'The RowDeleting event allows you to prevent row deletion
            AddHandler gridView.RowDeleting, Sub(s, e) e.Cancel = DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Delete row? (RowHandle = {0} ListSourceIndex = {1})", e.RowHandle, e.ListSourceIndex), "Delete rows dialog", System.Windows.Forms.MessageBoxButtons.YesNo) <> System.Windows.Forms.DialogResult.Yes
        End Sub
#End Region
    End Module
End Namespace
