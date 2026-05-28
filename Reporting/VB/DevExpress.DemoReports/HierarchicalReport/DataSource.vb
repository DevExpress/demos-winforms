Imports System.Collections.Generic
Imports System.ComponentModel

Namespace XtraReportsDemos.HierarchicalReport

    <DisplayName("Hierarchical Report Data Source")>
    Public Class DataSource

        Public Shared Function GetData() As List(Of SalesData)
            Dim sales As List(Of SalesData) = New List(Of SalesData)()
            sales.Add(New SalesData(0, -1, "Western Europe", 30540, 33000, 32220, 35500, .93))
            sales.Add(New SalesData(1, 0, "Austria", 22000, 28000, 26120, 28500, .92))
            sales.Add(New SalesData(2, 0, "Belgium", 13000, 9640, 14500, 11200, .16))
            sales.Add(New SalesData(3, 0, "Denmark", 21000, 18100, 17120, 15500, .56))
            sales.Add(New SalesData(4, 0, "Finland", 17000, 17420, 18120, 19200, .44))
            sales.Add(New SalesData(5, 0, "France", 23020, 27000, 20120, 24200, .51))
            sales.Add(New SalesData(6, 0, "Germany", 30540, 33000, 32220, 35500, .93))
            sales.Add(New SalesData(7, 0, "Greece", 15600, 13200, 11500, 11000, .11))
            sales.Add(New SalesData(8, 0, "Ireland", 9530, 10939, 12620, 12990, .34))
            sales.Add(New SalesData(9, 0, "Italy", 17299, 19321, 14120, 15945, .22))
            sales.Add(New SalesData(11, 0, "Netherlands", 8902, 9214, 7400, 9600, .85))
            sales.Add(New SalesData(12, 0, "Norway", 5400, 7310, 5200, 6880, .7))
            sales.Add(New SalesData(13, 0, "Portugal", 9220, 4271, 4100, 3880, .5))
            sales.Add(New SalesData(14, 0, "Spain", 12900, 10300, 14300, 14900, .82))
            sales.Add(New SalesData(15, 0, "Switzerland", 9323, 10730, 7244, 9400, .14))
            sales.Add(New SalesData(16, 0, "United Kingdom", 14580, 13967, 15200, 16900, .91))
            sales.Add(New SalesData(17, -1, "Eastern Europe", 22500, 24580, 21225, 22698, .85))
            sales.Add(New SalesData(19, 17, "Bulgaria", 6300, 2821, 5200, 4880, .8))
            sales.Add(New SalesData(20, 17, "Croatia", 4200, 3890, 3880, 4430, .29))
            sales.Add(New SalesData(21, 17, "Czech Republic", 19500, 15340, 16230, 14980, .13))
            sales.Add(New SalesData(22, 17, "Hungary", 13495, 13900, 10245, 9560, .14))
            sales.Add(New SalesData(23, 17, "Poland", 8930, 9440, 12200, 12150, .52))
            sales.Add(New SalesData(24, 17, "Romania", 4900, 5100, 5241, 6284, .30))
            sales.Add(New SalesData(26, -1, "North America", 31400, 32800, 30300, 31940, .87))
            sales.Add(New SalesData(27, 26, "USA", 31400, 32800, 30300, 31940, .87))
            sales.Add(New SalesData(28, 26, "Canada", 25390, 27000, 5200, 6880, .64))
            sales.Add(New SalesData(29, -1, "South America", 16380, 17590, 15400, 16680, .88))
            sales.Add(New SalesData(30, 29, "Argentina", 16380, 17590, 15400, 16680, .88))
            sales.Add(New SalesData(31, 29, "Brazil", 4560, 9480, 3900, 6100, .10))
            sales.Add(New SalesData(32, -1, "Asia", 20388, 22547, 22500, 25756, .82))
            sales.Add(New SalesData(34, 32, "India", 4642, 5320, 4200, 6470, .44))
            sales.Add(New SalesData(35, 32, "Japan", 9457, 12859, 8300, 8733, .70))
            Return sales
        End Function
    End Class

    Public Class SalesData

        Public Sub New(ByVal id As Integer, ByVal regionId As Integer, ByVal region As String, ByVal marchSales As Decimal, ByVal septemberSales As Decimal, ByVal marchSalesPrev As Decimal, ByVal septermberSalesPrev As Decimal, ByVal marketShare As Double)
            Me.ID = id
            Me.RegionID = regionId
            Me.Region = region
            Me.MarchSales = marchSales
            Me.SeptemberSales = septemberSales
            Me.MarchSalesPrev = marchSalesPrev
            SeptemberSalesPrev = septermberSalesPrev
            Me.MarketShare = marketShare
        End Sub

        Public Property ID As Integer

        Public Property RegionID As Integer

        Public Property Region As String

        Public Property MarchSales As Decimal

        Public Property SeptemberSales As Decimal

        Public Property MarchSalesPrev As Decimal

        Public Property SeptemberSalesPrev As Decimal

        Public Property MarketShare As Double
    End Class
End Namespace
