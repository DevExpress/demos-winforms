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
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Edit cells and obtain cell values", "Editing.cs")>
    Public Module Editing

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(6)
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Helpers"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public NotInheritable Class DemoHelper

            Public Shared Function GetDeleteImage() As Image
                Return DevExpress.XtraGrid.Demos.CodeExamples.Editing.DemoHelper.GetImage(System.Drawing.Brushes.Red)
            End Function

            Public Shared Function GetEditImage() As Image
                Return DevExpress.XtraGrid.Demos.CodeExamples.Editing.DemoHelper.GetImage(System.Drawing.Brushes.Green)
            End Function

            Public Shared Function GetImage(ByVal b As System.Drawing.Brush) As Image
                Dim img As System.Drawing.Image = New System.Drawing.Bitmap(16, 16)
                Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(img)
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
                    g.FillEllipse(b, New System.Drawing.Rectangle(0, 0, img.Width - 1, img.Height - 1))
                End Using

                Return img
            End Function
        End Class

#End Region
#Region "Edit cells and obtain cell values"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Non editable mode"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("Editable")>
        Public Sub MakeGridViewNonEditable(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' The Editable property allows end-users to invoke cell editors 
            gridView.OptionsBehavior.Editable = False
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Read-only mode (allow copying individual cell values)"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ReadOnly")>
        Public Sub MakeGridViewReadOnly(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' The ReadOnly property enables the read-only status for the current View. 
            gridView.OptionsBehavior.[ReadOnly] = True
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Read-only mode for certain cells"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShownEditor")>
        Public Sub MakeCertainCellsReadOnly(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' You can handle the ShownEditor event to manage the 
            ' settings of an active editor
            AddHandler gridView.ShownEditor, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                view.ActiveEditor.Properties.[ReadOnly] = Equals(gridView.FocusedColumn.FieldName, "ID") AndAlso gridView.FocusedRowHandle Mod 2 = 0
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prohibit editing certain GridView's cells"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ShowingEditor")>
        Public Sub PreventEditingCertainCells(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' You can handle the ShowingEditor event to cancel editor activation
            AddHandler gridView.ShowingEditor, Sub(s, e) e.Cancel = Equals(gridView.FocusedColumn.FieldName, "ID") AndAlso gridView.FocusedRowHandle Mod 2 = 0
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Change column cell values based on another column values"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CellValueChanged")>
        Public Sub ChangingCellValuesBasedOnOtherCellValues(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Changing cell values of one column based on values of another one            
            AddHandler gridView.CellValueChanged, Sub(sender, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
                If Equals(e.Column.FieldName, "Length") Then
                    Dim doubleVal As Double = CDbl(e.Value)
                    view.SetRowCellValue(e.RowHandle, "Mark", doubleVal > 10)
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Iterating through grid rows and accessing cell values"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("GetRowCellValue")>
        Public Sub IteratingThroughGridRowsAndAccessingCellValues(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Iterating through grid rows and accessing cell values            
            Dim text As String = "Ids of rows that have the checked state" & System.Environment.NewLine
            For i As Integer = 0 To gridView.DataRowCount - 1
                Dim boolVal As Boolean = CBool(gridView.GetRowCellValue(i, "Mark"))
                If boolVal Then
                    Dim id As Object = gridView.GetRowCellValue(i, "ID")
                    text += id.ToString() & System.Environment.NewLine
                End If
            Next

            Call DevExpress.XtraEditors.XtraMessageBox.Show(text)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Cell commands to edit and delete rows", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.Editing.DemoHelper)}), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomRowCellEditForEditing", "CustomRowCellEdit", "ShowingEditor", "EditFormPrepared")>
        Public Sub CommandsColumn(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Create the Commands column editor
            Dim commandsEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit With {.AutoHeight = False, .Name = "CommandsEdit", .TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor}
            commandsEdit.Buttons.Clear()
            commandsEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Edit", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleLeft, DevExpress.XtraGrid.Demos.CodeExamples.Editing.DemoHelper.GetEditImage()), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Delete", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleLeft, DevExpress.XtraGrid.Demos.CodeExamples.Editing.DemoHelper.GetDeleteImage())})
            ' Create an unbound Commands column
            Dim _commandsColumn As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns.AddField("Commands")
            _commandsColumn.UnboundDataType = GetType(Object)
            _commandsColumn.Visible = True
            _commandsColumn.Width = 100
            ' Hide commandsColumn from EditForm
            _commandsColumn.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.[False]
            ' Display commands only for focused row
            AddHandler gridView.CustomRowCellEdit, Sub(s, e)
                If e.RowHandle = gridView.FocusedRowHandle AndAlso e.Column Is _commandsColumn Then e.RepositoryItem = commandsEdit
            End Sub
            AddHandler gridView.CustomRowCellEditForEditing, Sub(s, e)
                If e.RowHandle = gridView.FocusedRowHandle AndAlso e.Column Is _commandsColumn Then e.RepositoryItem = commandsEdit
            End Sub
            ' Allow only commandsColumn to be edited
            AddHandler gridView.ShowingEditor, Sub(s, e) e.Cancel = gridView.FocusedColumn IsNot _commandsColumn
            gridView.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            gridView.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.[False]
            gridView.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.[False]
            gridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace
            ' Perform a specific action when an EditorButton is clicked
            AddHandler commandsEdit.ButtonClick, Sub(s, e)
                Select Case e.Button.Caption
                    Case "Edit"
                        ' Start edit a row using EditForm
                        gridView.CloseEditor()
                        gridView.ShowEditForm()
                    Case "Delete"
                        ' Delete focused row
                        gridControl.BeginInvoke(New System.Windows.Forms.MethodInvoker(Sub() gridView.DeleteRow(gridView.FocusedRowHandle)))
                End Select
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Post data to an underlying data source immediately"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("EditValueChanged", "ShownEditor", "PostEditor", "UpdateCurrentRow", "HiddenEditor", "RowUpdated")>
        Public Sub PostDataToAnUnderlyingDataSourceImmediately(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            Dim editValueChanged As System.EventHandler = Sub(s, e)
                gridView.PostEditor()
                gridView.UpdateCurrentRow()
            End Sub
            Dim edit As DevExpress.XtraEditors.BaseEdit = Nothing
            AddHandler gridView.ShownEditor, Sub(s, e)
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                edit = view.ActiveEditor
                AddHandler edit.EditValueChanged, editValueChanged
            End Sub
            AddHandler gridView.HiddenEditor, Sub(s, e)
                RemoveHandler edit.EditValueChanged, editValueChanged
                edit = Nothing
            End Sub
            '  Post data to a connected data base here
            AddHandler gridView.RowUpdated, Sub(s, e) Call DevExpress.XtraEditors.XtraMessageBox.Show("Row is updated.")
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Disable buttons in certain rows"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RepositoryItemButtonEdit", "Assign", "CustomRowCellEdit")>
        Public Sub DisableButtonsInCertainRows(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            gridView.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
            Dim riButtonEditEnabled As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            riButtonEditEnabled.Buttons.Clear()
            riButtonEditEnabled.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "Copy cell value"))
            riButtonEditEnabled.Buttons.Add(New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Clear this cell"))
            Dim riButtonEditDisabled As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            ' Create a similar RepositoryItem 
            riButtonEditDisabled.Assign(riButtonEditEnabled)
            ' Disable all buttons
            System.Linq.Enumerable.ToList(Of DevExpress.XtraEditors.Controls.EditorButton)(riButtonEditDisabled.Buttons).ForEach(Sub(button) button.Enabled = False)
            AddHandler gridView.CustomRowCellEdit, Sub(s, e)
                If Equals(e.Column.FieldName, "Notes") Then
                    Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                    Dim actionsAvailable As Boolean = System.Convert.ToBoolean(view.GetRowCellValue(e.RowHandle, "Mark"))
                    e.RepositoryItem = If(actionsAvailable, riButtonEditEnabled, riButtonEditDisabled)
                End If
            End Sub
        End Sub
#End Region
    End Module
End Namespace
