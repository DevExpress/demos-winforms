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
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Data.Filtering
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Cell editors", "CellEditors.cs")>
    Public Module CellEditors

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(10)
            gridView.PopulateColumns()
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Cell editors"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Assign in-place editors dynamically"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("spinEdit", "calcEdit", "CustomRowCellEdit")>
        Public Sub AssignInPalceEditorsDynamically(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim spinEdit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Dim calcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            gridView.Columns(CStr(("Length"))).ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
            ' Handle this event to assign editors to individual cells
            AddHandler gridView.CustomRowCellEdit, Sub(sender, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                If Equals(e.Column.FieldName, "Length") Then
                    Dim boolVal As Boolean = CBool(view.GetRowCellValue(e.RowHandle, "Mark"))
                    If boolVal Then
                        e.RepositoryItem = spinEdit
                    Else
                        e.RepositoryItem = calcEdit
                    End If
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Override the default in-place editor for certain cells"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomRowCellEditForEditing", "gridLookUpEdit")>
        Public Sub OverrideTheDefaultInPlaceEditorForCertainCells(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim gridLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit() With {.DisplayMember = "ID", .ValueMember = "ID"}
            gridControl.RepositoryItems.Add(gridLookUpEdit)
            ' The ID column uses a text editor by default.
            ' The CustomRowCellEditForEditing event is handled to override this editor for rows. 
            AddHandler gridView.CustomRowCellEditForEditing, Sub(sender, e)
                If Equals(e.Column.FieldName, "ID") Then
                    ' Assign data to gridLookUpEdit dynamically
                    gridLookUpEdit.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(10)
                    e.RepositoryItem = gridLookUpEdit
                End If
            End Sub
            gridView.ShowEditor()
            TryCast(gridView.ActiveEditor, DevExpress.XtraEditors.GridLookUpEdit).ShowPopup()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Assign in-place editors (repository items)"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ColumnEdit")>
        Public Sub AssignInPlaceEditors(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Assign a repository item to a column            
            Dim edit As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
            gridControl.RepositoryItems.Add(edit)
            gridView.Columns(CStr(("Mark"))).ColumnEdit = edit
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show buttons in grid cells"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ColumnEdit", "ShowButtonMode")>
        Public Sub ShowButtonsInGridCells(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Show a button in a grid cell            
            Dim edit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            AddHandler edit.ButtonClick, Sub(sender, e)
                If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete Then
                    If DevExpress.XtraEditors.XtraMessageBox.Show("Do you wish to remove this row?", "Confirmation Dialog", System.Windows.Forms.MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                        gridView.DeleteRow(gridView.FocusedRowHandle)
                    End If
                End If
            End Sub
            edit.Buttons(CInt((0))).Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete
            edit.Buttons(CInt((0))).Caption = "Custom Button"
            gridControl.RepositoryItems.Add(edit)
            Dim column As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns("ID")
            column.ColumnEdit = edit
            column.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("In-place mode immediate post changes"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ColumnEdit")>
        Public Sub InplaceModeImmediatePostChanges(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Immediate post changes
            Dim edit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit() With {.InplaceModeImmediatePostChanges = DevExpress.Utils.DefaultBoolean.[True]}
            gridControl.RepositoryItems.Add(edit)
            gridView.Columns(CStr(("Mark"))).ColumnEdit = edit
            Dim messageColumn As DevExpress.XtraGrid.Columns.GridColumn = New DevExpress.XtraGrid.Columns.GridColumn() With {.FieldName = "Message", .Visible = True, .UnboundDataType = GetType(String), .UnboundExpression = "Iif([Mark], '', 'Not available in your region')"}
            gridView.Columns.Add(messageColumn)
        End Sub
#End Region
    End Module
End Namespace
