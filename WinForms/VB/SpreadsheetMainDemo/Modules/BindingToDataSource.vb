Imports System
Imports System.Data
Imports System.Text
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet.Demos.Modules.DataBinding
Imports DevExpress.XtraSpreadsheet.Demos.Modules.DataBinding.nwindOrdersTableAdapters

Namespace DevExpress.XtraSpreadsheet.Demos

    Public Partial Class BindingToDataSourceModule
        Inherits SpreadsheetRibbonTutorialControlBase

        Private dataView As DataView

        Private previousRange As CellRange

        Private locked As Boolean = False

        Public Sub New()
            InitializeComponent()
            InitializeBindToData()
            spreadsheetControl1.Options.Culture = DefaultCulture
            spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataSourceToRange_template.xlsx"))
            Dim dataSet As nwindOrders = New nwindOrders()
            BindEditors(dataSet)
            BindDataSource(dataSet)
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            spreadsheetControl1.Focus()
        End Sub

        Private Sub BindDataSource(ByVal dataSet As nwindOrders)
            Dim orderDetailsAdapter As OrderDetailsTableAdapter = New OrderDetailsTableAdapter()
            orderDetailsAdapter.Fill(dataSet.OrderDetails)
            dataView = New DataView(dataSet.OrderDetails)
            dataView.Sort = "OrderID"
            BindDataSourceToWorksheet()
        End Sub

        Private Sub BindDataSourceToWorksheet()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            Dim sheet As Worksheet = workbook.Worksheets(0)
            sheet.DataBindings.BindToDataSource(dataView, 4, 1)
            UpdateTotalPrice()
        End Sub

        Private Sub BindDataSourceToTable()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            Dim sheet As Worksheet = workbook.Worksheets(0)
            workbook.BeginUpdate()
            Try
                Dim options As ExternalDataSourceOptions = New ExternalDataSourceOptions() With {.ImportHeaders = True}
                Dim table As Table = sheet.Tables.Add(dataView, 3, 1, options)
                table.Columns(0).Name = "Order ID"
                table.Columns(1).Name = "Product"
                table.Columns(2).Name = "Supplier"
                table.Columns(3).Name = "Unit Price"
                table.Columns(4).Name = "Quantity"
                table.Columns(5).Name = "Discount"
                Dim subtotalColumn As TableColumn = table.Columns.Add()
                subtotalColumn.Name = "Subtotal"
                subtotalColumn.Formula = "=[Unit Price]*[Quantity]*(1-[Discount])"
                subtotalColumn.TotalRowFunction = TotalRowFunction.Sum
                table.Columns(0).TotalRowLabel = "Total"
                table.ShowTotals = True
            Finally
                workbook.EndUpdate()
            End Try
        End Sub

        Private Sub BindEditors(ByVal dataSet As nwindOrders)
            ' Order ID
            Dim ordersAdapter As OrdersTableAdapter = New OrdersTableAdapter()
            ordersAdapter.Fill(dataSet.Orders)
            edOrderId.Properties.DataSource = dataSet.Orders
            edOrderId.Properties.Columns.Add(New XtraEditors.Controls.LookUpColumnInfo("OrderID"))
            edOrderId.Properties.DisplayMember = "OrderID"
            edOrderId.Properties.ValueMember = "OrderID"
            ' Product
            Dim productsAdapter As ProductsTableAdapter = New ProductsTableAdapter()
            productsAdapter.Fill(dataSet.Products)
            edProductName.Properties.DataSource = dataSet.Products
            edProductName.Properties.Columns.Add(New XtraEditors.Controls.LookUpColumnInfo("ProductName"))
            edProductName.Properties.DisplayMember = "ProductName"
            edProductName.Properties.ValueMember = "ProductName"
        End Sub

        Private Sub OrderId_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not locked Then SetupDataView()
        End Sub

        Private Sub ProductName_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not locked Then SetupDataView()
        End Sub

        Private Sub Discount_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not locked Then SetupDataView()
        End Sub

        Private Sub Reset_Click(ByVal sender As Object, ByVal e As EventArgs)
            locked = True
            Try
                edOrderId.EditValue = Nothing
                edProductName.EditValue = Nothing
                chbDiscount.Checked = False
                SetupDataView()
            Finally
                locked = False
            End Try
        End Sub

        Private Sub SetupDataView()
            If dataView Is Nothing Then Return
            Dim sb As StringBuilder = New StringBuilder()
            If Not String.IsNullOrEmpty(edOrderId.Text) Then sb.AppendFormat("OrderID = {0}", edOrderId.Text)
            If Not String.IsNullOrEmpty(edProductName.Text) Then
                If sb.Length > 0 Then sb.Append(" AND ")
                sb.AppendFormat("ProductName = '{0}'", edProductName.Text.Replace("'", "''"))
            End If

            If chbDiscount.Checked Then
                If sb.Length > 0 Then sb.Append(" AND ")
                sb.Append("Discount > 0")
            End If

            spreadsheetControl1.BeginUpdate()
            Try
                dataView.RowFilter = sb.ToString()
                If cbxBindToData.SelectedIndex = 0 Then UpdateTotalPrice()
            Finally
                spreadsheetControl1.EndUpdate()
            End Try
        End Sub

        Private Sub UpdateTotalPrice()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            workbook.BeginUpdate()
            Try
                Dim sheet As Worksheet = workbook.Worksheets(0)
                Dim currentRange As CellRange = sheet.DataBindings(0).Range
                Dim subtotalRange As CellRange
                If previousRange IsNot Nothing Then
                    subtotalRange = sheet.Range.FromLTRB(previousRange.RightColumnIndex + 1, previousRange.TopRowIndex, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex)
                    subtotalRange.ClearContents()
                    If currentRange.RowCount < previousRange.RowCount Then
                        subtotalRange = sheet.Range.FromLTRB(previousRange.LeftColumnIndex, previousRange.BottomRowIndex + 1, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex + 1)
                        subtotalRange.ClearContents()
                    End If

                    previousRange = Nothing
                End If

                If dataView.Count > 0 Then
                    previousRange = currentRange
                    subtotalRange = sheet.Range.FromLTRB(previousRange.RightColumnIndex + 1, previousRange.TopRowIndex, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex)
                    subtotalRange.FormulaInvariant = "=E5*F5*(1-G5)"
                    Dim range As CellRange = sheet.Range.FromLTRB(previousRange.LeftColumnIndex, previousRange.BottomRowIndex + 1, previousRange.LeftColumnIndex, previousRange.BottomRowIndex + 1)
                    range.Value = "Total"
                    range = sheet.Range.FromLTRB(previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex + 1, previousRange.RightColumnIndex + 1, previousRange.BottomRowIndex + 1)
                    range.FormulaInvariant = String.Format("=SUBTOTAL(9,{0})", subtotalRange.GetReferenceA1())
                End If
            Finally
                workbook.EndUpdate()
            End Try
        End Sub

        Private Sub InitializeBindToData()
            locked = True
            Try
                cbxBindToData.SelectedIndex = 0
            Finally
                locked = False
            End Try
        End Sub

        Private Sub ClearDataBindings()
            Dim workbook As IWorkbook = spreadsheetControl1.Document
            Dim sheet As Worksheet = workbook.Worksheets(0)
            sheet.DataBindings.Clear()
        End Sub

        Private Sub BindToData_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If locked Then Return
            ClearDataBindings()
            If cbxBindToData.SelectedIndex = 0 Then
                previousRange = Nothing
                spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataSourceToRange_template.xlsx"))
                BindDataSourceToWorksheet()
            Else
                spreadsheetControl1.LoadDocument(DemoUtils.GetRelativePath("DataSourceToTable_template.xlsx"))
                BindDataSourceToTable()
            End If
        End Sub
    End Class
End Namespace
