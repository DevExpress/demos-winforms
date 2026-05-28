Imports System
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class CustomInplaceEditors
        Inherits SpreadSheetTutorialControlBase

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("CustomInplaceEditors_template.xlsx"))
            AddHandler spreadsheetControl1.CustomCellEdit, AddressOf SpreadsheetControl1_CustomCellEdit
            BindCustomEditors()
        End Sub

        Private Sub BindCustomEditors()
            Dim sheet As Worksheet = spreadsheetControl1.Document.Worksheets("Sales report")
            Dim dateEditRange As CellRange = sheet("Table[Order Date]")
            sheet.CustomCellInplaceEditors.Add(dateEditRange, CustomCellInplaceEditorType.DateEdit)
            Dim comboBoxRange As CellRange = sheet("Table[Category]")
            sheet.CustomCellInplaceEditors.Add(comboBoxRange, CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(sheet("J3:J9")))
            Dim checkBoxRange As CellRange = sheet("Table[Discount]")
            sheet.CustomCellInplaceEditors.Add(checkBoxRange, CustomCellInplaceEditorType.CheckBox)
            Dim customRange As CellRange = sheet("Table[Qty]")
            sheet.CustomCellInplaceEditors.Add(customRange, CustomCellInplaceEditorType.Custom, "MySpinEdit")
        End Sub

        Private Sub SpreadsheetControl1_CustomCellEdit(ByVal sender As Object, ByVal e As SpreadsheetCustomCellEditEventArgs)
            If e.ValueObject.IsText AndAlso Equals(e.ValueObject.TextValue, "MySpinEdit") Then
                Dim editor As RepositoryItemSpinEdit = New RepositoryItemSpinEdit With {.AutoHeight = False, .BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder, .MinValue = 1, .MaxValue = 1000, .IsFloatValue = False}
                e.RepositoryItem = editor
            End If
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            ribbonControl1.SelectedPage = homeRibbonPage1
        End Sub
    End Class
End Namespace
