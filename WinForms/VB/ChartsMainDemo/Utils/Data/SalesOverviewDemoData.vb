Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Data.Utils
Imports DevExpress.Utils.Filtering
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraCharts.Demos

    Friend Module SalesProductDataGenerator

        Friend Class ProductItemBase

            Public Property Product As String

            Public Property Category As String

            Public Property Price As Decimal
        End Class

        Friend Class SaleItemBase

            <DevExpress.Utils.Filtering.FilterLookupAttribute(UseBlanks:=False, UseSelectAll:=False)>
            Public Property Category As String

            Public Property UnitsSold As Integer

            Public Property Revenue As Decimal

            Public Property UnitsSoldTarget As Integer

            <System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.Currency)>
            Public Property RevenueTarget As Decimal

            <System.ComponentModel.DataAnnotations.DisplayFormatAttribute(DataFormatString:="p")>
            Public ReadOnly Property SalesDynamic As Single
                Get
                    Return CSng(((Me.Revenue - Me.RevenueTarget) / Me.Revenue))
                End Get
            End Property

            Public Property ReportDate As DateTime
        End Class

        Friend Class SaleItem
            Inherits DevExpress.XtraCharts.Demos.SalesProductDataGenerator.SaleItemBase

            Public Property State As String

            Public Property Product As String

            <System.ComponentModel.DataAnnotations.DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType.Currency)>
            Public Property Price As Decimal
        End Class

        Friend Class BikeReportItem
            Inherits DevExpress.XtraCharts.Demos.SalesProductDataGenerator.SaleItemBase

        End Class

        Private ReadOnly rnd As DevExpress.Data.Utils.NonCryptographicRandom = DevExpress.Data.Utils.NonCryptographicRandom.System

        Friend BikeCategories As System.Collections.Generic.List(Of String) = New System.Collections.Generic.List(Of String)() From {"Mountain", "Hybrid/Cross", "Road", "Comfort", "Youth", "Cruiser", "Electric"}

        Private Function GetUnitsSold(ByVal category As String) As Integer
            Dim max As Integer = If(category.Equals("Bikes"), 50, 250)
            Return DevExpress.XtraCharts.Demos.SalesProductDataGenerator.rnd.[Next](1, max)
        End Function

        Private Function CreateProductBase(ByVal dataRow As System.Data.DataRow, ByVal categoryName As String) As Object
            Return New DevExpress.XtraCharts.Demos.SalesProductDataGenerator.ProductItemBase() With {.Price = dataRow.Field(Of Decimal)("ListPrice"), .Product = dataRow.Field(Of String)("Name"), .Category = categoryName}
        End Function

        Private Function LoadData(ByVal fileName As String) As DataSet
            Dim path As String = DevExpress.XtraCharts.Demos.Utils.GetRelativePath(String.Format("{0}.xml", fileName))
            If String.IsNullOrEmpty(path) Then
                Call DevExpress.XtraEditors.XtraMessageBox.Show("The """ & fileName & ".xml"" file not found.", "Error occurred", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.[Error])
                Return Nothing
            End If

            Dim ds As System.Data.DataSet = New System.Data.DataSet()
            ds.ReadXml(path, System.Data.XmlReadMode.ReadSchema)
            Return ds
        End Function

        Private Function GenerateData(ByVal regions As System.Data.DataRowCollection, ByVal products As System.Collections.Generic.IEnumerable(Of DevExpress.XtraCharts.Demos.SalesProductDataGenerator.ProductItemBase)) As List(Of DevExpress.XtraCharts.Demos.SalesProductDataGenerator.SaleItem)
            Dim totalSales As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SalesProductDataGenerator.SaleItem) = New System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SalesProductDataGenerator.SaleItem)()
            For Each region As System.Data.DataRow In regions
                Dim state As String = CStr(region("Region"))
                Dim year As Integer = System.DateTime.Today.Year - 1
                For month As Integer = 1 To 12
                    For Each product As DevExpress.XtraCharts.Demos.SalesProductDataGenerator.ProductItemBase In products
                        Dim tsItem As DevExpress.XtraCharts.Demos.SalesProductDataGenerator.SaleItem = New DevExpress.XtraCharts.Demos.SalesProductDataGenerator.SaleItem With {.State = state, .Category = product.Category, .Product = product.Product, .Price = product.Price}
                        Dim dt As System.DateTime = New System.DateTime(year, month, 1)
                        Dim uSold As Integer = DevExpress.XtraCharts.Demos.SalesProductDataGenerator.GetUnitsSold(product.Category)
                        Dim uSoldTarget As Integer = uSold + DevExpress.XtraCharts.Demos.SalesProductDataGenerator.rnd.[Next](-CInt((uSold * 0.2)), CInt((uSold * 0.2)))
                        Dim rev As Decimal = uSold * product.Price
                        Dim revTarget As Decimal = uSoldTarget * product.Price
                        tsItem.Revenue = rev
                        tsItem.RevenueTarget = revTarget
                        tsItem.UnitsSold = uSold
                        tsItem.UnitsSoldTarget = uSoldTarget
                        tsItem.ReportDate = dt
                        totalSales.Add(tsItem)
                    Next
                Next
            Next

            Return totalSales
        End Function

        Friend Function ExtractData() As List(Of DevExpress.XtraCharts.Demos.SalesProductDataGenerator.SaleItem)
            Dim dataSet As System.Data.DataSet = DevExpress.XtraCharts.Demos.SalesProductDataGenerator.LoadData("DashboardSales")
            If dataSet Is Nothing Then Return Nothing
            Dim products As System.Data.DataTable = dataSet.Tables("Products")
            Dim categories As System.Data.DataTable = dataSet.Tables("Categories")
            Dim regions As System.Data.DataTable = dataSet.Tables("Regions")
            Dim items As System.Collections.Generic.IEnumerable(Of Object) = From t1 In products.AsEnumerable() Join t2 In categories.AsEnumerable() On t1("CategoryID") Equals t2("CategoryID") Select DevExpress.XtraCharts.Demos.SalesProductDataGenerator.CreateProductBase(t1, CStr(t2("CategoryName")))
            Return DevExpress.XtraCharts.Demos.SalesProductDataGenerator.GenerateData(regions.Rows, items.Cast(Of DevExpress.XtraCharts.Demos.SalesProductDataGenerator.ProductItemBase)())
        End Function

        Friend Function GenerateBicyclesReport() As List(Of DevExpress.XtraCharts.Demos.SalesProductDataGenerator.BikeReportItem)
            Dim result As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SalesProductDataGenerator.BikeReportItem) = New System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.SalesProductDataGenerator.BikeReportItem)()
            Dim year As Integer = System.DateTime.Today.Year - 1
            Dim startDate As System.DateTime = New System.DateTime(year, 1, 1)
            Dim averageMonthSold As Integer = 1700
            Dim averagePrice As Decimal = 900
            Dim [date] As System.DateTime = startDate
            For day As Integer = 1 To 365 Step 7
                Dim minDay As Integer = DevExpress.XtraCharts.Demos.SalesProductDataGenerator.rnd.[Next](100, 200)
                Dim maxDay As Integer = DevExpress.XtraCharts.Demos.SalesProductDataGenerator.rnd.[Next](250, 300)
                [date] = startDate.AddDays(day)
                For i As Integer = 0 To DevExpress.XtraCharts.Demos.SalesProductDataGenerator.BikeCategories.Count - 1
                    Dim category As String = DevExpress.XtraCharts.Demos.SalesProductDataGenerator.BikeCategories(i)
                    Dim deltaCorrection As Double = 2 * DevExpress.XtraCharts.Demos.SalesProductDataGenerator.rnd.NextDouble() + 0.2
                    Dim tsItem As DevExpress.XtraCharts.Demos.SalesProductDataGenerator.BikeReportItem = New DevExpress.XtraCharts.Demos.SalesProductDataGenerator.BikeReportItem With {.Category = category}
                    Dim correction As Double = 22 - i * 3 - DevExpress.XtraCharts.Demos.SalesProductDataGenerator.rnd.NextDouble()
                    If day > minDay AndAlso day < maxDay Then correction += deltaCorrection
                    If day > maxDay Then correction -= deltaCorrection
                    Dim uSold As Integer = CInt((averageMonthSold * correction / 100.0))
                    Dim uSoldTarget As Integer = uSold + DevExpress.XtraCharts.Demos.SalesProductDataGenerator.rnd.[Next](-CInt((uSold * 0.2)), CInt((uSold * 0.2)))
                    Dim rev As Decimal = uSold * averagePrice
                    Dim revTarget As Decimal = uSoldTarget * averagePrice
                    tsItem.Revenue = rev
                    tsItem.RevenueTarget = revTarget
                    tsItem.UnitsSold = uSold
                    tsItem.UnitsSoldTarget = uSoldTarget
                    tsItem.ReportDate = [date]
                    result.Add(tsItem)
                Next
            Next

            Return result
        End Function
    End Module
End Namespace
