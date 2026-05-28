Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.Xml.Linq
Imports DevExpress.XtraCharts.Heatmap

Namespace DevExpress.XtraTreeMap.Demos

    Public Partial Class HeatmapSelection
        Inherits DevExpress.XtraTreeMap.Demos.TreeMapTutorialControl

        Private ReadOnly Property HeatmapDataAdapter As HeatmapDataSourceAdapter
            Get
                Return CType(Me.heatmapControl1.DataAdapter, DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter)
            End Get
        End Property

        Public Overrides ReadOnly Property ActiveDemoModule As Control
            Get
                Return Me.heatmapControl1
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            Dim data As System.Collections.Generic.List(Of DevExpress.XtraTreeMap.Demos.ProductSale) = Me.LoadData()
            Me.HeatmapDataAdapter.DataSource = data
            Me.HeatmapDataAdapter.XArgumentComparer = New DevExpress.XtraTreeMap.Demos.OriginalOrderComparer()
            Me.heatmapControl1.SelectedItems.Add(data(0))
        End Sub

        Private Function LoadData() As List(Of DevExpress.XtraTreeMap.Demos.ProductSale)
            Dim data As System.Collections.Generic.List(Of DevExpress.XtraTreeMap.Demos.ProductSale) = New System.Collections.Generic.List(Of DevExpress.XtraTreeMap.Demos.ProductSale)()
            Try
                Dim sales_xml As System.Xml.Linq.XDocument = System.Xml.Linq.XDocument.Load(DevExpress.XtraTreeMap.Demos.Utils.GetRelativePath("ProductSales.xml"))
                For Each monthSale As System.Xml.Linq.XElement In sales_xml.Root.Elements()
                    Dim product As String = monthSale.Element(CType(("Product"), System.Xml.Linq.XName)).Value
                    Dim month As String = monthSale.Element(CType(("Month"), System.Xml.Linq.XName)).Value
                    Dim dailySales As System.Collections.Generic.List(Of DevExpress.XtraTreeMap.Demos.DailySale) = New System.Collections.Generic.List(Of DevExpress.XtraTreeMap.Demos.DailySale)()
                    For Each daySale As System.Xml.Linq.XElement In monthSale.Elements("SalesByDay").Elements("DailySale")
                        dailySales.Add(New DevExpress.XtraTreeMap.Demos.DailySale() With {.Product = product, .[Date] = System.Convert.ToDateTime(daySale.Element(CType(("Date"), System.Xml.Linq.XName)).Value), .Revenue = System.Convert.ToDouble(daySale.Element(CType(("Revenue"), System.Xml.Linq.XName)).Value)})
                    Next

                    data.Add(New DevExpress.XtraTreeMap.Demos.ProductSale() With {.SalesByDay = dailySales})
                Next
            Catch
            End Try

            Return data
        End Function

        Private Sub heatmapControl1_SelectedItemsChanged(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.SelectedItemsChangedEventArgs)
            Dim list As System.Collections.Generic.List(Of DevExpress.XtraTreeMap.Demos.DailySale) = New System.Collections.Generic.List(Of DevExpress.XtraTreeMap.Demos.DailySale)()
            For Each item As DevExpress.XtraTreeMap.Demos.ProductSale In Me.heatmapControl1.SelectedItems
                list.AddRange(item.SalesByDay)
            Next

            Me.chartControl1.DataSource = list
        End Sub
    End Class

    Public Class ProductSale

        Public ReadOnly Property Product As String
            Get
                Return Me.SalesByDay(CInt((0))).Product
            End Get
        End Property

        Public ReadOnly Property Month As String
            Get
                Return Me.SalesByDay(CInt((0))).[Date].ToString("MMMM")
            End Get
        End Property

        Public ReadOnly Property RevenueByMonth As Double
            Get
                Return Me.SalesByDay.Sum(Function(s) s.Revenue)
            End Get
        End Property

        Public Property SalesByDay As List(Of DevExpress.XtraTreeMap.Demos.DailySale)
    End Class

    Public Class DailySale

        Public Property Product As String

        Public Property Revenue As Double

        Public Property [Date] As DateTime
    End Class

    Public Class OriginalOrderComparer
        Implements System.Collections.IComparer

        Private Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements Global.System.Collections.IComparer.Compare
            Return 0
        End Function
    End Class
End Namespace
