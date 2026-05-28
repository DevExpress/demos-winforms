Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraEditors.Repository

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class DataEntryFormModule
        Inherits SpreadSheetTutorialControlBase

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.Options.Culture = CultureInfo.CurrentCulture
            LoadInvoiceTemplate()
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            spreadsheetControl1.Focus()
            Dim invoice As Worksheet = spreadsheetControl1.Document.Worksheets("Invoice")
            spreadsheetControl1.SelectedCell = invoice("B10")
        End Sub

        Private Sub LoadInvoiceTemplate()
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DevAVInvoicing.xltx"))
            InitializeDateFields()
            BindCustomEditors()
        End Sub

        Private Sub InitializeDateFields()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            Dim invoice As Worksheet = workbook.Worksheets("Invoice")
            invoice("B4").Value = Date.Today
            invoice("F18").Value = Date.Today.AddDays(14)
        End Sub

        Private Sub BindCustomEditors()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            Dim invoice As Worksheet = workbook.Worksheets("Invoice")
            Dim customers As Worksheet = workbook.Worksheets("Customers")
            Dim employees As Worksheet = workbook.Worksheets("Employees")
            Dim products As Worksheet = workbook.Worksheets("Products")
            ' Invoice date
            invoice.CustomCellInplaceEditors.Add(invoice("B4"), CustomCellInplaceEditorType.DateEdit)
            ' Customer (billing address)
            invoice.CustomCellInplaceEditors.Add(invoice("B10:E10"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(customers("A2:A21")))
            ' Customer store (shipping address)
            Dim stores As Worksheet = workbook.Worksheets("Stores")
            invoice.CustomCellInplaceEditors.Add(invoice("H12:M12"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(stores("D5:D204")), True)
            ' Sales Rep
            invoice.CustomCellInplaceEditors.Add(invoice("B18:C18"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(employees("I2:I52")), True)
            ' Ship date
            invoice.CustomCellInplaceEditors.Add(invoice("F18:G18"), CustomCellInplaceEditorType.DateEdit)
            ' Ship Via
            Dim shipVia As CellValue() = {"Air", "Ground", "Rail"}
            invoice.CustomCellInplaceEditors.Add(invoice("H18:I18"), CustomCellInplaceEditorType.ComboBox, ValueObject.CreateListSource(shipVia))
            ' FOB
            invoice.CustomCellInplaceEditors.Add(invoice("J18:K18"), CustomCellInplaceEditorType.Custom, "FOBSpinEdit")
            ' Terms
            invoice.CustomCellInplaceEditors.Add(invoice("L18:M18"), CustomCellInplaceEditorType.Custom, "TermsSpinEdit")
            ' Quantity
            invoice.CustomCellInplaceEditors.Add(invoice("B22:B25"), CustomCellInplaceEditorType.Custom, "QtySpinEdit")
            ' Invoice positions
            invoice.CustomCellInplaceEditors.Add(invoice("C22:F25"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(products("B2:B20")))
            ' Discont
            invoice.CustomCellInplaceEditors.Add(invoice("I22:J25"), CustomCellInplaceEditorType.Custom, "DiscountSpinEdit")
            ' Shipping
            invoice.CustomCellInplaceEditors.Add(invoice("K27:M27"), CustomCellInplaceEditorType.Custom, "ShippingSpinEdit")
        End Sub

        Private Sub spreadsheetControl1_CustomCellEdit(ByVal sender As Object, ByVal e As SpreadsheetCustomCellEditEventArgs)
            If e.ValueObject.IsText Then
                If Equals(e.ValueObject.TextValue, "FOBSpinEdit") Then
                    e.RepositoryItem = CreateSpinEdit(0, 500, 5)
                ElseIf Equals(e.ValueObject.TextValue, "TermsSpinEdit") Then
                    e.RepositoryItem = CreateSpinEdit(5, 30, 1)
                ElseIf Equals(e.ValueObject.TextValue, "QtySpinEdit") Then
                    e.RepositoryItem = CreateSpinEdit(1, 100, 1)
                ElseIf Equals(e.ValueObject.TextValue, "DiscountSpinEdit") Then
                    e.RepositoryItem = CreateSpinEdit(0, 1000, 10)
                ElseIf Equals(e.ValueObject.TextValue, "ShippingSpinEdit") Then
                    e.RepositoryItem = CreateSpinEdit(10, 1000, 5)
                End If
            End If

            If e.RepositoryItem IsNot Nothing Then e.RepositoryItem.BorderStyle = XtraEditors.Controls.BorderStyles.Default
        End Sub

        Private Function CreateSpinEdit(ByVal minValue As Integer, ByVal maxValue As Integer, ByVal increment As Integer) As RepositoryItemSpinEdit
            Dim editor As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
            editor.AutoHeight = False
            editor.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder
            editor.MinValue = minValue
            editor.MaxValue = maxValue
            editor.Increment = increment
            editor.IsFloatValue = False
            Return editor
        End Function

        Private Sub spreadsheetControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            ActivateEditor()
        End Sub

        Private Sub ActivateEditor()
            Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
            If Equals(sheet.Name, "Invoice") Then
                Dim editors As IList(Of CustomCellInplaceEditor) = sheet.CustomCellInplaceEditors.GetCustomCellInplaceEditors(sheet.Selection)
                If editors.Count = 1 Then spreadsheetControl1.OpenCellEditor(CellEditorMode.Edit)
            End If
        End Sub

        Private Sub spreadsheetControl1_CellValueChanged(ByVal sender As Object, ByVal e As SpreadsheetCellEventArgs)
            If e.Action = CellValueChangedAction.UndoRedo OrElse e.OldValue Is e.Cell.Value OrElse Not Equals(e.Cell.GetReferenceA1(ReferenceElement.IncludeSheetName), "Invoice!B10") Then Return
            Dim invoice As Worksheet = e.Worksheet
            Dim customerStores As Worksheet = spreadsheetControl1.Document.Worksheets("Stores")
            ' Apply filter to customer's stores
            Dim customerId As String = invoice("B11").Value.TextValue
            Dim storesTable As Table = customerStores.Tables(0)
            storesTable.AutoFilter.Clear()
            storesTable.AutoFilter.Columns(1).ApplyFilterCriteria(customerId)
            ' Select default store
            Dim range As CellRange = storesTable.DataRange
            For rowOffset As Integer = 0 To range.RowCount - 1
                If Equals(range(rowOffset, 1).Value.TextValue, customerId) Then
                    invoice("H12").Value = range(rowOffset, 3).Value.TextValue
                    Return
                End If
            Next

            invoice("H12").Value = CellValue.Empty
        End Sub

        Private Sub RemoveOrderItem(ByVal sheet As Worksheet)
            If spreadsheetControl1.IsCellEditorActive Then spreadsheetControl1.CloseCellEditor(CellEditorEnterValueMode.Cancel)
            sheet.Rows.Remove(sheet.SelectedCell.TopRowIndex, 1)
            ActivateEditor()
        End Sub

        Private Sub AddOrderItem(ByVal sheet As Worksheet)
            If spreadsheetControl1.IsCellEditorActive Then spreadsheetControl1.CloseCellEditor(CellEditorEnterValueMode.Cancel)
            AddRecord(sheet)
            ActivateEditor()
        End Sub

        ' Add record to invoice
        Private Sub AddRecord(ByVal sheet As Worksheet)
            spreadsheetControl1.BeginUpdate()
            Try
                Dim invoiceItems As DefinedName = sheet.DefinedNames.GetDefinedName("InvoiceItems")
                Dim rowIndex As Integer = invoiceItems.Range.BottomRowIndex
                sheet.Rows.Insert(rowIndex)
                sheet.Rows(rowIndex).Height = sheet.Rows(rowIndex + 1).Height
                Dim range As CellRange = invoiceItems.Range
                Dim itemRange As CellRange = sheet.Range.FromLTRB(range.LeftColumnIndex, range.BottomRowIndex, range.RightColumnIndex, range.BottomRowIndex)
                If range.RowCount = 1 Then
                    sheet("K24").FormulaInvariant = "=SUM(K22:K23)"
                    invoiceItems.Range = sheet.Range.FromLTRB(range.LeftColumnIndex, range.TopRowIndex - 1, range.RightColumnIndex, range.BottomRowIndex).GetRangeWithAbsoluteReference()
                    RecreateCustomEditors()
                End If

                MoveUpLastRecord(itemRange)
                InitializeRecord(itemRange)
                spreadsheetControl1.SelectedCell = itemRange(1)
            Finally
                spreadsheetControl1.EndUpdate()
            End Try
        End Sub

        Private Sub RecreateCustomEditors()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            Dim invoice As Worksheet = workbook.Worksheets("Invoice")
            Dim products As Worksheet = workbook.Worksheets("Products")
            ' Remove custom editors
            invoice.CustomCellInplaceEditors.Remove(invoice("B23:M23"))
            ' Quantity
            invoice.CustomCellInplaceEditors.Add(invoice("B22:B23"), CustomCellInplaceEditorType.Custom, "QtySpinEdit")
            ' Invoice positions
            invoice.CustomCellInplaceEditors.Add(invoice("C22:F23"), CustomCellInplaceEditorType.ComboBox, ValueObject.FromRange(products("B2:B20")))
            ' Discont
            invoice.CustomCellInplaceEditors.Add(invoice("I22:J23"), CustomCellInplaceEditorType.Custom, "DiscountSpinEdit")
        End Sub

        ' Move last record one row up
        Private Sub MoveUpLastRecord(ByVal itemRange As CellRange)
            Dim range As CellRange = itemRange.Offset(-1, 0)
            range.CopyFrom(itemRange, PasteSpecial.All, True)
        End Sub

        ' Setup new record values 
        Private Sub InitializeRecord(ByVal itemRange As CellRange)
            itemRange(0).Value = 1 ' Qty
            itemRange(1).Value = CellValue.Empty ' Product
            itemRange(7).Value = 0 ' Discount
        End Sub

        ' Suppress protection warning
        Private Sub spreadsheetControl1_ProtectionWarning(ByVal sender As Object, ByVal e As HandledEventArgs)
            e.Handled = True
        End Sub

        ' Load invoice template on empty document created
        Private Sub spreadsheetControl1_EmptyDocumentCreated(ByVal sender As Object, ByVal e As EventArgs)
            LoadInvoiceTemplate()
        End Sub

        ' Draw Add/Remove order item
        Private Sub spreadsheetControl1_CustomDrawCell(ByVal sender As Object, ByVal e As CustomDrawCellEventArgs)
            Dim sheet As Worksheet = e.Cell.Worksheet
            If Not Equals(sheet.Name, "Invoice") Then Return
            Dim invoiceItems As DefinedName = sheet.DefinedNames.GetDefinedName("InvoiceItems")
            ' Add Order Item
            If e.Cell.ColumnIndex = 2 AndAlso e.Cell.RowIndex = If(invoiceItems Is Nothing, 21, invoiceItems.Range.BottomRowIndex + 1) Then DrawCustomText(e, "Add Order Item")
            ' Delete Order Item
            If invoiceItems IsNot Nothing AndAlso e.Cell.ColumnIndex = 13 AndAlso invoiceItems.Range.RowCount > 1 AndAlso e.Cell.RowIndex >= invoiceItems.Range.TopRowIndex AndAlso e.Cell.RowIndex <= invoiceItems.Range.BottomRowIndex Then DrawCustomText(e, "Delete Order Item")
        End Sub

        Private Sub DrawCustomText(ByVal e As CustomDrawCellEventArgs, ByVal text As String)
            e.Handled = True
            e.DrawDefault()
            Dim dpiScale As Single = e.Cache.DeviceDpi / spreadsheetControl1.DpiY
            Using font As Font = New Font(e.Font.Name, 10 * dpiScale, FontStyle.Underline)
                Dim size As SizeF = e.Graphics.MeasureString(text, font, Integer.MaxValue, StringFormat.GenericDefault)
                Dim textBounds As RectangleF = New RectangleF(e.Bounds.Left + 8, e.Bounds.Top + (e.Bounds.Height - size.Height) / 2, size.Width + 4, size.Height)
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
                e.Graphics.DrawString(text, font, e.Cache.GetSolidBrush(Color.FromArgb(5, 111, 206)), textBounds, StringFormat.GenericDefault)
            End Using
        End Sub

        Private Sub spreadsheetControl1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim cell As Cell = spreadsheetControl1.GetCellFromPoint(e.Location)
            If cell Is Nothing OrElse Not Equals(cell.Worksheet.Name, "Invoice") Then Return
            Dim sheet As Worksheet = cell.Worksheet
            Dim invoiceItems As DefinedName = sheet.DefinedNames.GetDefinedName("InvoiceItems")
            ' Add Order Item
            If cell.ColumnIndex >= 2 AndAlso cell.ColumnIndex <= 3 AndAlso cell.RowIndex = If(invoiceItems Is Nothing, 21, invoiceItems.Range.BottomRowIndex + 1) Then AddOrderItem(sheet)
            ' Delete Order Item
            If invoiceItems IsNot Nothing AndAlso cell.ColumnIndex >= 13 AndAlso cell.ColumnIndex <= 15 AndAlso invoiceItems.Range.RowCount > 1 AndAlso cell.RowIndex >= invoiceItems.Range.TopRowIndex AndAlso cell.RowIndex <= invoiceItems.Range.BottomRowIndex Then RemoveOrderItem(sheet)
        End Sub

        Private Sub spreadsheetControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim cell As Cell = spreadsheetControl1.GetCellFromPoint(e.Location)
            If cell Is Nothing OrElse Not Equals(cell.Worksheet.Name, "Invoice") Then Return
            Dim sheet As Worksheet = cell.Worksheet
            Dim invoiceItems As DefinedName = sheet.DefinedNames.GetDefinedName("InvoiceItems")
            Dim handCursor As Boolean = cell.ColumnIndex >= 2 AndAlso cell.ColumnIndex <= 3 AndAlso cell.RowIndex = If(invoiceItems Is Nothing, 21, invoiceItems.Range.BottomRowIndex + 1)
            handCursor = handCursor Or invoiceItems IsNot Nothing AndAlso cell.ColumnIndex >= 13 AndAlso cell.ColumnIndex <= 15 AndAlso invoiceItems.Range.RowCount > 1 AndAlso cell.RowIndex >= invoiceItems.Range.TopRowIndex AndAlso cell.RowIndex <= invoiceItems.Range.BottomRowIndex
            spreadsheetControl1.Cursor = If(handCursor, Cursors.Hand, Cursors.Default)
        End Sub
    End Class
End Namespace
