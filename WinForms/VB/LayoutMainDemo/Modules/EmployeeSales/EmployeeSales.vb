Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Internal

Namespace DevExpress.XtraLayout.Demos

    Public Partial Class EmployeeSales
        Inherits TutorialControl

        '<layoutGridControl>//<bandGridControl>
        Private FillColors As List(Of Color) = New List(Of Color)(New Color() {DXSkinColors.FillColors.Danger, DXSkinColors.FillColors.Primary, DXSkinColors.FillColors.Question, DXSkinColors.FillColors.Success, DXSkinColors.FillColors.Warning})

        '</layoutGridControl>//</bandGridControl>
        Public Sub New()
            InitializeComponent()
            InitData()
            InitGridControl()
            InitAllColorPickEdits(True)
        End Sub

        Protected Overrides ReadOnly Property WhatsThisXMLFileName As String
            Get
                Return "EmployeeSales"
            End Get
        End Property

        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"EmployeeSales"}
            End Get
        End Property

        Private Sub InitAllColorPickEdits(ByVal subscribe As Boolean)
            InitColorPickEdit(DXSkinColors.FillColors.Danger, 0, colorPickEdit1, subscribe)
            InitColorPickEdit(DXSkinColors.FillColors.Primary, 1, colorPickEdit2, subscribe)
            InitColorPickEdit(DXSkinColors.FillColors.Question, 2, colorPickEdit3, subscribe)
            InitColorPickEdit(DXSkinColors.FillColors.Success, 3, colorPickEdit4, subscribe)
            InitColorPickEdit(DXSkinColors.FillColors.Warning, 4, colorPickEdit5, subscribe)
        End Sub

        Private Sub InitColorPickEdit(ByVal clr As Color, ByVal q As Integer, ByVal colorPickEdit As ColorPickEdit, ByVal subscribe As Boolean)
            colorPickEdit.Properties.AutomaticColor = clr
            colorPickEdit.EditValue = clr
            colorPickEdit.Tag = q
            If Not subscribe Then Return
            AddHandler colorPickEdit.ColorChanged, Sub(s, e)
                Dim edit As ColorPickEdit = TryCast(s, ColorPickEdit)
                FillColors(CInt(edit.Tag)) = edit.Color
                bandedGridView1.BeginUpdate()
                '<bandGridControl>
                For Each band As GridBand In bandedGridView1.Bands
                    If band.Tag IsNot Nothing Then band.AppearanceHeader.BackColor = FillColors(((CInt(band.Tag)) - 1) Mod FillColors.Count)
                Next

                '</bandGridControl>
                bandedGridView1.EndUpdate()
                Refresh()
            End Sub
        End Sub

        Private Sub layoutControlGroup2_CustomButtonClick(ByVal sender As Object, ByVal e As XtraBars.Docking2010.BaseButtonEventArgs)
            InitAllColorPickEdits(False)
        End Sub

        '<bandGridControl>
        Private Sub bandedGridView1_CustomDrawCell(ByVal sender As Object, ByVal e As Views.Base.RowCellCustomDrawEventArgs)
            If e.Column IsNot colProductName Then Return
            If bandedGridView1.FocusedRowHandle = e.RowHandle AndAlso bandedGridView1.FocusedColumn IsNot e.Column Then Return
            Dim row As dsOrder.CategoryProductsRow = TryCast(TryCast(bandedGridView1.GetRow(e.RowHandle), DataRowView).Row, dsOrder.CategoryProductsRow)
            e.Appearance.ForeColor = DXSkinColors.ForeColors.InnerColors((row.CategoryID - 1) Mod DXSkinColors.ForeColors.InnerColors.Count)
        End Sub

        '</bandGridControl>
        '<layoutGridControl>
        Private Sub layoutView1_CustomCardStyle(ByVal sender As Object, ByVal e As Views.Layout.Events.LayoutViewCardStyleEventArgs)
            Dim row As dsOrder.EmployeesRow = TryCast(TryCast(layoutView1.GetRow(e.RowHandle), DataRowView).Row, dsOrder.EmployeesRow)
            e.Appearance.BorderColor = FillColors((row.EmployeeID - 1) Mod FillColors.Count)
        End Sub

        '</layoutGridControl>
#Region "FilteringUI"
        Private Sub layoutView1_ColumnFilterChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not layoutView1.IsVisible OrElse Not String.IsNullOrEmpty(layoutView1.ActiveFilterString) AndAlso layoutView1.RowCount = dsOrder.Employees.Count Then Return
            bandedGridView1.BeginUpdate()
            For Each band As GridBand In bandedGridView1.Bands
                If band.Tag IsNot Nothing Then band.Visible = False
            Next

            For i As Integer = 0 To layoutView1.RowCount - 1
                Dim row As dsOrder.EmployeesRow = TryCast(TryCast(layoutView1.GetRow(i), DataRowView).Row, dsOrder.EmployeesRow)
                bandedGridView1.Bands(row.EmployeeID.ToString()).Visible = True
                bandedGridView1.Bands(row.EmployeeID.ToString()).VisibleIndex = 3 + i
            Next

            bandedGridView1.EndUpdate()
        End Sub

#End Region
#Region "Edit"
        Private Sub repositoryItemHypertextLabel1_Click(ByVal sender As Object, ByVal e As EventArgs)
            layoutView1.CloseEditor()
            ShowEditForm()
        End Sub

        Private Sub layoutView1_CardClick(ByVal sender As Object, ByVal e As Views.Layout.Events.CardClickEventArgs)
            If e.Clicks <> 2 OrElse e.Button <> MouseButtons.Left Then Return
            ShowEditForm()
        End Sub

        Private Sub ShowEditForm()
            Call FlyoutDialog.Show(FindForm(), New EmployeeEdit(dsOrder, TryCast(TryCast(layoutView1.GetFocusedRow(), DataRowView).Row, dsOrder.EmployeesRow).EmployeeID))
        End Sub

#End Region
#Region "Data"
        Const layoutViewFilter As String = "[FullName] In ('Andrew Fuller', 'Janet Leverling', 'Margaret Peacock')"

        Const bandedViewFilter As String = "[CategoryName] In ('Condiments', 'Beverages')"

        Private dictionary As Dictionary(Of EmployeeProductKey, EmployeeProductAnalytics) = New Dictionary(Of EmployeeProductKey, EmployeeProductAnalytics)()

        Private Sub InitGridControl()
            For i As Integer = 0 To dsOrder.Employees.Count - 1
                Dim employeeRow As dsOrder.EmployeesRow = dsOrder.Employees(i)
                Dim newBand As GridBand = bandedGridView1.Bands.Add()
                newBand.Tag = employeeRow.EmployeeID
                newBand.Name = employeeRow.EmployeeID.ToString()
                newBand.Caption = employeeRow.FirstName & " " & employeeRow.LastName
                newBand.AppearanceHeader.BackColor = FillColors((employeeRow.EmployeeID - 1) Mod FillColors.Count)
                newBand.Visible = Equals(employeeRow.LastName, "Fuller") OrElse Equals(employeeRow.LastName, "Leverling") OrElse Equals(employeeRow.LastName, "Peacock")
                newBand.VisibleIndex = gridBand1.VisibleIndex + i + 1
                newBand.Width = gridBand1.Width
                Dim totalSalesColumn As BandedGridColumn = New BandedGridColumn() With {.FieldName = "TotalSales" & employeeRow.EmployeeID.ToString(), .Caption = "Total", .Tag = employeeRow.EmployeeID, .Visible = True, .MinWidth = 65, .UnboundType = Data.UnboundColumnType.Decimal}
                totalSalesColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                totalSalesColumn.DisplayFormat.FormatString = "c2"
                totalSalesColumn.Summary.Add(New GridColumnSummaryItem(Data.SummaryItemType.Sum, totalSalesColumn.FieldName, "{0:c0}"))
                Dim salesTrendColumn As BandedGridColumn = New BandedGridColumn() With {.FieldName = "SalesTrend" & employeeRow.EmployeeID.ToString(), .Caption = "Trend", .Tag = employeeRow.EmployeeID, .Visible = True, .MinWidth = 80, .UnboundType = Data.UnboundColumnType.Object, .ColumnEdit = repositoryItemSparklineEdit1}
                Dim salesCountColumn As BandedGridColumn = New BandedGridColumn() With {.FieldName = "SalesCount" & employeeRow.EmployeeID.ToString(), .Caption = "Sales", .Tag = employeeRow.EmployeeID, .Visible = True, .MinWidth = 40, .UnboundType = Data.UnboundColumnType.Decimal}
                salesCountColumn.Summary.Add(New GridColumnSummaryItem(Data.SummaryItemType.Sum, salesCountColumn.FieldName, "{0}"))
                bandedGridView1.Columns.Add(totalSalesColumn)
                bandedGridView1.Columns.Add(salesTrendColumn)
                bandedGridView1.Columns.Add(salesCountColumn)
                newBand.Columns.Add(salesCountColumn)
                newBand.Columns.Add(salesTrendColumn)
                newBand.Columns.Add(totalSalesColumn)
            Next

            layoutView1.ActiveFilterString = layoutViewFilter
            bandedGridView1.ActiveFilterString = bandedViewFilter
            bandedGridView1.BestFitColumns()
        End Sub

        Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDataEventArgs)
            If e.IsSetData Then Return
            If e.Column.FieldName.StartsWith("TotalSales") Then
                Dim categoryProductsRow As dsOrder.CategoryProductsRow = TryCast(TryCast(e.Row, DataRowView).Row, dsOrder.CategoryProductsRow)
                Dim analytics As EmployeeProductAnalytics = Nothing
                dictionary.TryGetValue(New EmployeeProductKey(CInt(e.Column.Tag), categoryProductsRow.ProductID), analytics)
                e.Value = If(analytics Is Nothing, 0, analytics.TotalSale)
            End If

            If e.Column.FieldName.StartsWith("SalesTrend") Then
                Dim categoryProductsRow As dsOrder.CategoryProductsRow = TryCast(TryCast(e.Row, DataRowView).Row, dsOrder.CategoryProductsRow)
                Dim analytics As EmployeeProductAnalytics = Nothing
                dictionary.TryGetValue(New EmployeeProductKey(CInt(e.Column.Tag), categoryProductsRow.ProductID), analytics)
                e.Value = If(analytics Is Nothing, New List(Of Decimal)(), analytics.SalesTrend)
            End If

            If e.Column.FieldName.StartsWith("TotalQuantities") Then
                Dim categoryProductsRow As dsOrder.CategoryProductsRow = TryCast(TryCast(e.Row, DataRowView).Row, dsOrder.CategoryProductsRow)
                Dim analytics As EmployeeProductAnalytics = Nothing
                dictionary.TryGetValue(New EmployeeProductKey(CInt(e.Column.Tag), categoryProductsRow.ProductID), analytics)
                e.Value = If(analytics Is Nothing, 0, analytics.TotalQuantities)
            End If

            If e.Column.FieldName.StartsWith("SalesCount") Then
                Dim categoryProductsRow As dsOrder.CategoryProductsRow = TryCast(TryCast(e.Row, DataRowView).Row, dsOrder.CategoryProductsRow)
                Dim analytics As EmployeeProductAnalytics = Nothing
                dictionary.TryGetValue(New EmployeeProductKey(CInt(e.Column.Tag), categoryProductsRow.ProductID), analytics)
                e.Value = If(analytics Is Nothing, 0, analytics.SalesCount)
            End If
        End Sub

        Private Sub InitConnection()
            Dim DBFileName As String = DataDirectoryHelper.GetDataFile("nwind.mdb")
            If Not Equals(DBFileName, String.Empty) Then
                Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
                Dim oleDBAdapter1 As OleDbDataAdapter = New OleDbDataAdapter("SELECT [FirstName]+' '+[LastName] AS FullName, * FROM Employees WHERE (Employees.EmployeeID < 6)", con)
                Dim oleDBAdapter2 As OleDbDataAdapter = New OleDbDataAdapter("SELECT Products.ProductID, Products.ProductName, Categories.CategoryName, Categories.Picture, Categories.Description, Products.UnitPrice, Products.UnitsInStock, Products.CategoryID FROM (Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) WHERE (Products.CategoryID < 8)", con)
                Dim oleDBAdapter3 As OleDbDataAdapter = New OleDbDataAdapter("SELECT Orders.EmployeeID, Orders.OrderID, [Order Details].ProductID, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount, Orders.OrderDate FROM((Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) INNER JOIN Products ON[Order Details].ProductID = Products.ProductID) WHERE (Products.CategoryID < 8)", con)
                oleDBAdapter1.Fill(dsOrder.Employees)
                oleDBAdapter2.Fill(dsOrder.CategoryProducts)
                oleDBAdapter3.Fill(dsOrder.OrderDetailsEmployees)
            End If
        End Sub

        Private Sub InitData()
            InitConnection()
            For Each row As dsOrder.OrderDetailsEmployeesRow In dsOrder.OrderDetailsEmployees.ToList().OrderBy(Function(e) e.OrderDate)
                Dim key As EmployeeProductKey = New EmployeeProductKey(row.EmployeeID, row.ProductID)
                Dim oldResult As EmployeeProductAnalytics = Nothing
                dictionary.TryGetValue(key, oldResult)
                Dim totalSale As Decimal = New Decimal(Decimal.ToInt32(row.UnitPrice) * row.Quantity * (1F - row.Discount))
                Dim totalQuantities As Decimal = row.Quantity
                If oldResult Is Nothing Then
                    oldResult = New EmployeeProductAnalytics(totalSale, key, totalQuantities, row.OrderDate, totalSale)
                Else
                    oldResult.SalesTrend.Add(totalSale)
                    oldResult.TotalQuantities += totalQuantities
                    oldResult.TotalSale += totalSale
                End If

                dictionary(key) = oldResult
            Next
        End Sub
#End Region
    End Class

    Public Class EmployeeProductKey
        Inherits Tuple(Of Integer, Integer)

        Public Sub New(ByVal EmployeeID As Integer, ByVal ProductID As Integer)
            MyBase.New(EmployeeID, ProductID)
        End Sub

        Public ReadOnly Property EmployeeID As Integer
            Get
                Return Item1
            End Get
        End Property

        Public ReadOnly Property ProductID As Integer
            Get
                Return Item1
            End Get
        End Property
    End Class

    Public Class EmployeeProductAnalytics

        Public Sub New(ByVal totalSale As Decimal, ByVal key As EmployeeProductKey, ByVal totalQuantities As Decimal, ByVal orderDate As Date, ByVal totalPrice As Decimal)
            Me.TotalSale = totalSale
            Me.Key = key
            Me.TotalQuantities = totalQuantities
            SalesTrend = New List(Of Decimal)()
            SalesTrend.Add(totalPrice)
        End Sub

        Public Property Key As EmployeeProductKey

        Public ReadOnly Property SalesCount As Decimal
            Get
                Return SalesTrend.Count
            End Get
        End Property

        Public Property SalesTrend As List(Of Decimal)

        Public Property TotalQuantities As Decimal

        Public Property TotalSale As Decimal
    End Class
End Namespace
