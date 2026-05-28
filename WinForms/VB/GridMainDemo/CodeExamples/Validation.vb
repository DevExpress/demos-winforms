Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.Utils
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Validation", "Validation.cs")>
    Public Module Validation

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(5)
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Helpers"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public NotInheritable Class DemoHelper

            Public Shared Function GetIcon() As Icon
                Return DevExpress.Utils.ResourceImageHelper.CreateIconFromResources("DevExpress.XtraGrid.Demos.AppIcon.ico", GetType(DevExpress.XtraGrid.Demos.frmMain).Assembly)
            End Function
        End Class

#End Region
#Region "Validation"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Validate the active editor’s value"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ValidatingEditor", "ErrorText", "Valid", "InvalidValueException", "ErrorText")>
        Public Sub ValidatingEditor(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Handle this event to perform manual validation of an in-place active editor or the EditForm's active editor 
            AddHandler gridView.ValidatingEditor, Sub(s, e)
                Dim fieldName As String = String.Empty
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                Dim ea As DevExpress.XtraGrid.Views.Grid.EditFormValidateEditorEventArgs = TryCast(e, DevExpress.XtraGrid.Views.Grid.EditFormValidateEditorEventArgs)
                If ea Is Nothing Then
                    fieldName = view.FocusedColumn.FieldName
                Else
                    fieldName = ea.Column.FieldName
                End If

                If Equals(fieldName, "ID") Then
                    e.Valid = Not(System.Convert.ToInt32(e.Value) < 0)
                ElseIf Equals(fieldName, "Notes") Then
                    e.Valid = Not(String.IsNullOrEmpty(System.Convert.ToString(e.Value)))
                End If

                e.ErrorText = "The entered value is invalid (ValidatingEditor)"
            End Sub
            ' Provide a custom response when an invalid cell value is entered
            ' The ExceptionMode parameter controls the actual response to the error
            AddHandler gridView.InvalidValueException, Sub(s, e) e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
            Dim editingModesComboBox As DevExpress.XtraEditors.ComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit With {.Parent = gridControl.Parent, .Dock = System.Windows.Forms.DockStyle.Top}
            editingModesComboBox.Properties.Items.AddRange(System.[Enum].GetValues(GetType(DevExpress.XtraGrid.Views.Grid.GridEditingMode)))
            'Use the GridOptionsBehavior.EditingMode property to switch from the default in-place edit mode to the Edit Form
            editingModesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", gridView.OptionsBehavior, "EditingMode", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            editingModesComboBox.EditValue = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
            Dim editingModesComboBoxLabel As DevExpress.XtraEditors.LabelControl = New DevExpress.XtraEditors.LabelControl With {.Text = "EditingMode", .Dock = System.Windows.Forms.DockStyle.Top, .Parent = gridControl.Parent}
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Validate row data on losing focus"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ValidateRow", "ErrorText", "InvalidRowException", "ExceptionMode", "Valid")>
        Public Sub ValidateRow(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' You can handle the event to specify whether row data is valid. 
            ' The event fires if a row was modified and is about to lose focus.
            AddHandler gridView.ValidateRow, Sub(s, e)
                Dim obj As DevExpress.DXperience.Demos.CodeDemo.Data.SampleData = TryCast(e.Row, DevExpress.DXperience.Demos.CodeDemo.Data.SampleData)
                If obj.Length <= 0 Then
                    e.Valid = False
                    e.ErrorText = String.Format("Length cannot be less than or equal to zero. Please input a correct value.")
                End If
            End Sub
            ' This event is raised if the row fails validation or cannot be saved to the data source due to database restrictions
            'The ExceptionMode parameter controls the actual response to the error
            AddHandler gridView.InvalidRowException, Sub(s, e) e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Customize the error message box", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.Validation.DemoHelper)}), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ValidateRow", "ErrorText", "InvalidRowException", "ExceptionMode", "Valid")>
        Public Sub CustomizeTheErrorMessageBox(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            AddHandler gridView.ValidateRow, Sub(s, e)
                Dim obj As DevExpress.DXperience.Demos.CodeDemo.Data.SampleData = TryCast(e.Row, DevExpress.DXperience.Demos.CodeDemo.Data.SampleData)
                e.Valid = obj.Length > 0
            End Sub
            AddHandler gridView.InvalidRowException, Sub(s, e)
                ' Create a custom error message box
                Dim args As DevExpress.XtraEditors.XtraMessageBoxArgs = New DevExpress.XtraEditors.XtraMessageBoxArgs()
                args.Caption = "Length validation failed"
                args.Icon = DevExpress.XtraGrid.Demos.CodeExamples.Validation.DemoHelper.GetIcon()
                args.Text = "Length cannot be less than or equal to zero. Please input a correct value."
                args.Buttons = New System.Windows.Forms.DialogResult() {System.Windows.Forms.DialogResult.OK, System.Windows.Forms.DialogResult.Cancel}
                If DevExpress.XtraEditors.XtraMessageBox.Show(args) = System.Windows.Forms.DialogResult.OK Then
                    ' The ExceptionMode parameter controls the actual response to the error
                    e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
                Else
                    e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent entering duplicate values"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ValidatingEditor", "ErrorText", "Valid", "InvalidValueException", "ErrorText")>
        Public Sub PreventEnteringDuplicateValues(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Handle this event to perform manual validation of an in-place active editor or the EditForm's active editor 
            AddHandler gridView.ValidatingEditor, Sub(s, e)
                Dim fieldName As String = String.Empty
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(s, DevExpress.XtraGrid.Views.Grid.GridView)
                Dim ea As DevExpress.XtraGrid.Views.Grid.EditFormValidateEditorEventArgs = TryCast(e, DevExpress.XtraGrid.Views.Grid.EditFormValidateEditorEventArgs)
                If ea Is Nothing Then
                    fieldName = view.FocusedColumn.FieldName
                Else
                    fieldName = ea.Column.FieldName
                End If

                Dim rowCellValue As Integer
                Dim validatingCellValue As Integer = System.Convert.ToInt32(e.Value)
                If Equals(fieldName, "ID") Then
                    For rowHandle As Integer = 0 To view.DataRowCount - 1 ' iterate through all data rows within GridView
                        rowCellValue = System.Convert.ToInt32(view.GetRowCellValue(rowHandle, fieldName)) ' obtain the ID cell value of the processed row
                        If rowCellValue = validatingCellValue Then
                            e.Valid = False
                            e.ErrorText = "ID should be unique (ValidatingEditor)"
                            Return
                        End If
                    Next
                End If
            End Sub
            ' Provide a custom response when an invalid cell value is entered
            ' The ExceptionMode parameter controls the actual response to the error
            AddHandler gridView.InvalidValueException, Sub(s, e) e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
            Dim editingModesComboBox As DevExpress.XtraEditors.ComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit With {.Parent = gridControl.Parent, .Dock = System.Windows.Forms.DockStyle.Top}
            editingModesComboBox.Properties.Items.AddRange(System.[Enum].GetValues(GetType(DevExpress.XtraGrid.Views.Grid.GridEditingMode)))
            ' Use the GridOptionsBehavior.EditingMode property to switch from the default in-place edit mode to the Edit Form
            editingModesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", gridView.OptionsBehavior, "EditingMode", False, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            editingModesComboBox.EditValue = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
            Dim editingModesComboBoxLabel As DevExpress.XtraEditors.LabelControl = New DevExpress.XtraEditors.LabelControl With {.Text = "EditingMode", .Dock = System.Windows.Forms.DockStyle.Top, .Parent = gridControl.Parent}
        End Sub
#End Region
    End Module
End Namespace
