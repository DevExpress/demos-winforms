Imports DevExpress.XtraCharts.Sankey
Imports DevExpress.XtraEditors.Controls
Imports System
Imports System.Data
Imports System.Globalization
Imports System.Linq

Namespace DevExpress.XtraSankey.Demos

    Public Partial Class CustomNodeOrder
        Inherits SankeyDemoModuleWithOptions

        Public Overrides ReadOnly Property SankeyDiagramControl As SankeyDiagramControl
            Get
                Return sankeyDiagramControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            InitComboBoxes()
            ordersTableAdapter1.Fill(nwindDataSet.Orders)
            productsTableAdapter1.Fill(nwindDataSet.Products)
            suppliersTableAdapter1.Fill(nwindDataSet.Suppliers)
            categoriesTableAdapter1.Fill(nwindDataSet.Categories)
            shippersTableAdapter1.Fill(nwindDataSet.Shippers)
            customersTableAdapter1.Fill(nwindDataSet.Customers)
            order_DetailsTableAdapter1.Fill(nwindDataSet.Order_Details)
            SetDataSource()
        End Sub

        Private Sub InitComboBoxes()
            comparerRadioGroup.Properties.Items.Add(New RadioGroupItem(New SankeyNodeComparerItem(New TotalWeightComparer(True), New TotalWeightComparer(False)), "Total Weight"))
            comparerRadioGroup.Properties.Items.Add(New RadioGroupItem(New SankeyNodeComparerItem(New OutputLinkCountComparer(True), New OutputLinkCountComparer(False)), "Output Link Count"))
            comparerRadioGroup.Properties.Items.Add(New RadioGroupItem(New SankeyNodeComparerItem(New NodeNameComparer(True), New NodeNameComparer(False)), "Node Name"))
            comparerRadioGroup.SelectedIndex = 0
            Dim ascendingItem As BoolItem = New BoolItem("Ascending", True)
            orderRadioGroup.Properties.Items.Add(New RadioGroupItem(True, "Ascending"))
            orderRadioGroup.Properties.Items.Add(New RadioGroupItem(False, "Descending"))
            orderRadioGroup.SelectedIndex = 0
        End Sub

        Private Sub SetDataSource()
            Dim limit As Decimal = 1900
            Dim year As Integer = 2016
            Dim q0 = nwindDataSet.Order_Details.Where(Function(x) x.UnitPrice * x.Quantity > limit AndAlso x.OrdersRow.OrderDate.Year = year).[Select](Function(x) New With {.Column1 = x.ProductsRow.SuppliersRow.CompanyName, .Column2 = x.ProductsRow.CategoriesRow.CategoryName, .Column3 = x.UnitPrice * x.Quantity})
            Dim q1 = nwindDataSet.Order_Details.Where(Function(x) x.UnitPrice * x.Quantity > limit AndAlso x.OrdersRow.OrderDate.Year = year).[Select](Function(x) New With {.Column1 = x.ProductsRow.CategoriesRow.CategoryName, .Column2 = x.OrdersRow.ShippersRow.CompanyName, .Column3 = x.UnitPrice * x.Quantity})
            Dim q2 = nwindDataSet.Order_Details.Where(Function(x) x.UnitPrice * x.Quantity > limit AndAlso x.OrdersRow.OrderDate.Year = year).[Select](Function(x) New With {.Column1 = x.OrdersRow.ShippersRow.CompanyName, .Column2 = x.OrdersRow.CustomersRow.Country, .Column3 = x.UnitPrice * x.Quantity})
            Dim data = q0.ToList()
            data.AddRange(q1.ToList())
            data.AddRange(q2.ToList())
            sankeyDiagramControl1.DataSource = data
            sankeyDiagramControl1.SourceDataMember = "Column1"
            sankeyDiagramControl1.TargetDataMember = "Column2"
            sankeyDiagramControl1.WeightDataMember = "Column3"
        End Sub

        Private Sub OnCustomizeLinkToolTip(ByVal sender As Object, ByVal e As CustomizeSankeyLinkToolTipEventArgs)
            Dim format As NumberFormatInfo = CultureInfo.InvariantCulture.NumberFormat
            e.Content = "$" & e.Link.TotalWeight.ToString("#,0.00", format)
        End Sub

        Private Sub OnCustomizeNodeToolTip(ByVal sender As Object, ByVal e As CustomizeSankeyNodeToolTipEventArgs)
            Dim prefix As String = ""
            Select Case e.Node.Level
                Case 0
                    prefix = "Company"
                Case 1
                    prefix = "Product Category"
                Case 2
                    prefix = "Ship mode"
                Case 3
                    prefix = "Customer Country"
            End Select

            e.Title = prefix & ": " & e.Title
            Dim format As NumberFormatInfo = CultureInfo.InvariantCulture.NumberFormat
            e.Content = "$" & e.Node.TotalWeight.ToString("#,0.00", format)
        End Sub

        Private Sub RadioGroup_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If comparerRadioGroup.SelectedIndex >= 0 AndAlso orderRadioGroup.SelectedIndex >= 0 Then
                Dim nodeComparerItem As SankeyNodeComparerItem = CType(comparerRadioGroup.Properties.Items(comparerRadioGroup.SelectedIndex).Value, SankeyNodeComparerItem)
                Dim ascending As Boolean = CBool(orderRadioGroup.Properties.Items(orderRadioGroup.SelectedIndex).Value)
                sankeyDiagramControl1.NodeComparer = nodeComparerItem.GetComparer(ascending)
            End If
        End Sub
    End Class
End Namespace
