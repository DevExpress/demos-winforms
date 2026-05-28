Imports System
Imports System.Drawing
Imports System.Collections.Generic
Imports DevExpress.SalesDemo.Model
Imports DevExpress.SalesDemo.Win.Modules
Imports DevExpress.XtraCharts

Namespace DevExpress.SalesDemo.Win
    Public Module ChartUtils
        Public Function GeneratePalette() As Palette
            Return New Palette("SalesPalette", PaletteScaleMode.Repeat, New PaletteEntry() {
                New PaletteEntry(Color.FromArgb(&H46, &H68, &HA5)),
                New PaletteEntry(Color.FromArgb(&HA5, &H46, &H71)),
                New PaletteEntry(Color.FromArgb(&H49, &HA4, &HBE)),
                New PaletteEntry(Color.FromArgb(&H46, &H9E, &HA5)),
                New PaletteEntry(Color.FromArgb(&H58, &H48, &HA5)),
                New PaletteEntry(Color.FromArgb(&H94, &H62, &HAE)),
                New PaletteEntry(Color.FromArgb(&HFC, &HC6, &H53))
            })
        End Function
        Public Sub CustomDrawAxisLabel(ByVal sender As Object, ByVal e As CustomDrawAxisLabelEventArgs)
            If TypeOf e.Item.Axis Is AxisY Then
                Dim value As Double = (DirectCast(e.Item.AxisValue, Double))
                e.Item.Text = DoubleToShortString(value)
            End If
            Dim chart As ChartControl = TryCast(sender, ChartControl)
            If chart Is Nothing Then
                Return
            End If
            If chart.LookAndFeel.ActiveSkinName = "Office 2016 Dark" Then
                e.Item.TextColor = Color.White
            End If
        End Sub
        Public Sub CustomDrawSeriesPointLegendMarker(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            Dim markerBitmap As Bitmap = CreateLegendMarker(e.LegendMarkerSize, e.LegendDrawOptions.Color)
            e.LegendMarkerImage = markerBitmap
            e.DisposeLegendMarkerImage = True
        End Sub
        Public Sub CustomDrawPieSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            Dim markerBitmap As Bitmap = CreateLegendMarker(e.LegendMarkerSize, e.LegendDrawOptions.Color)
            e.LegendMarkerImage = markerBitmap
            e.DisposeLegendMarkerImage = True
            Dim value As Double = e.SeriesPoint.Values(0)
            e.LabelText = "$" & DoubleToShortString(value)
            Dim chart As ChartControl = TryCast(sender, ChartControl)
            If chart Is Nothing Then
                Return
            End If
            If chart.LookAndFeel.ActiveSkinName = "Office 2016 Dark" Then
                e.LegendTextColor = Color.White
            End If
        End Sub
        Public Sub CustomDrawBarSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            Dim value As Double = e.SeriesPoint.Values(0)
            If value >= 1000000 Then
                e.LabelText = Math.Round(value / 1000000).ToString() & "M"
            ElseIf value >= 10000 Then
                e.LabelText = Math.Round(value / 1000).ToString() & "K"
            End If
        End Sub

        Private Function CreateLegendMarker(ByVal size As Size, ByVal color As Color) As Bitmap
            Dim bmp As New Bitmap(size.Width, size.Height)
            Using gr As Graphics = Graphics.FromImage(bmp)
                Using brush As Brush = New SolidBrush(color)
                    gr.FillRectangle(brush, New Rectangle(Point.Empty, size))
                End Using
            End Using
            Return bmp
        End Function
        Private Function DoubleToShortString(ByVal value As Double) As String
            If value >= 1000000 Then
                Return Math.Round(value / 1000000).ToString() & "M"
            ElseIf value >= 1000 Then
                Return Math.Round(value / 1000).ToString() & "K"
            Else
                Return value.ToString()
            End If
        End Function
    End Module

    Public Class DailySalesPerformance
		Implements ISalesPerformanceProvider

		Private dataProvider As IDataProvider

		Public ReadOnly Property Mode() As SalesPerformanceMode Implements ISalesPerformanceProvider.Mode
			Get
				Return SalesPerformanceMode.Day
			End Get
		End Property
		Public ReadOnly Property ChartType() As SalesPerformanceChartType Implements ISalesPerformanceProvider.ChartType
			Get
				Return SalesPerformanceChartType.Area
			End Get
		End Property
		Public ReadOnly Property ChartArgumentDataMember() As String Implements ISalesPerformanceProvider.ChartArgumentDataMember
			Get
				Return "StartOfPeriod"
			End Get
		End Property
		Public ReadOnly Property ChartValueDataMember() As String Implements ISalesPerformanceProvider.ChartValueDataMember
			Get
				Return "TotalCost"
			End Get
		End Property
		Public ReadOnly Property SalesValuesFormat() As String Implements ISalesPerformanceProvider.SalesValuesFormat
			Get
				Return "${0:N0}"
			End Get
		End Property
		Public ReadOnly Property SalesValueFirst() As Double Implements ISalesPerformanceProvider.SalesValueFirst
			Get
				Return GetTotalSales(DateTimeUtils.GetDayRange(Date.Today))
			End Get
		End Property
		Public ReadOnly Property SalesValueSecond() As Double Implements ISalesPerformanceProvider.SalesValueSecond
			Get
				Return GetTotalSales(DateTimeUtils.GetDayRange(Date.Today.AddDays(-1)))
			End Get
		End Property
		Public ReadOnly Property SalesValueThird() As Double Implements ISalesPerformanceProvider.SalesValueThird
			Get
				Return GetTotalSales(DateTimeUtils.GetLastWeekRange())
			End Get
		End Property

		Public Sub New(ByVal dataProvider As IDataProvider)
			Me.dataProvider = dataProvider
		End Sub

		Public Function GetChartData(ByVal [date] As Date) As Object Implements ISalesPerformanceProvider.GetChartData
			Dim range As DateTimeRange = DateTimeUtils.GetDayRange([date])
			Return dataProvider.GetSales(range.Start, range.End, GroupingPeriod.Hour)
		End Function
		Private Function GetTotalSales(ByVal range As DateTimeRange) As Double
			Return CDbl(dataProvider.GetTotalSalesByRange(range.Start, range.End).TotalCost)
		End Function
	End Class

	Public Class MonthlySalesPerformance
		Implements ISalesPerformanceProvider

		Private dataProvider As IDataProvider

		Public ReadOnly Property Mode() As SalesPerformanceMode Implements ISalesPerformanceProvider.Mode
			Get
				Return SalesPerformanceMode.Month
			End Get
		End Property
		Public ReadOnly Property ChartType() As SalesPerformanceChartType Implements ISalesPerformanceProvider.ChartType
			Get
				Return SalesPerformanceChartType.Area
			End Get
		End Property
		Public ReadOnly Property ChartArgumentDataMember() As String Implements ISalesPerformanceProvider.ChartArgumentDataMember
			Get
				Return "StartOfPeriod"
			End Get
		End Property
		Public ReadOnly Property ChartValueDataMember() As String Implements ISalesPerformanceProvider.ChartValueDataMember
			Get
				Return "TotalCost"
			End Get
		End Property
		Public ReadOnly Property SalesValuesFormat() As String Implements ISalesPerformanceProvider.SalesValuesFormat
			Get
				Return "${0:N0}"
			End Get
		End Property
		Public ReadOnly Property SalesValueFirst() As Double Implements ISalesPerformanceProvider.SalesValueFirst
			Get
				Return GetTotalSales(DateTimeUtils.GetMonthRange(Date.Today))
			End Get
		End Property
		Public ReadOnly Property SalesValueSecond() As Double Implements ISalesPerformanceProvider.SalesValueSecond
			Get
				Return GetTotalSales(DateTimeUtils.GetMonthRange(Date.Today.AddMonths(-1)))
			End Get
		End Property
		Public ReadOnly Property SalesValueThird() As Double Implements ISalesPerformanceProvider.SalesValueThird
			Get
				Return GetTotalSales(DateTimeUtils.GetLastYearRange())
			End Get
		End Property

		Public Sub New(ByVal dataProvider As IDataProvider)
			Me.dataProvider = dataProvider
		End Sub

		Public Function GetChartData(ByVal [date] As Date) As Object Implements ISalesPerformanceProvider.GetChartData
			Dim range As DateTimeRange = DateTimeUtils.GetMonthRange([date])
			Return dataProvider.GetSales(range.Start, range.End, GroupingPeriod.Day)
		End Function
		Private Function GetTotalSales(ByVal range As DateTimeRange) As Double
			Return CDbl(dataProvider.GetTotalSalesByRange(range.Start, range.End).TotalCost)
		End Function
	End Class

	Public Class DailySalesByProduct
		Implements ISalesPerformanceProvider

		Private dataProvider As IDataProvider

		Public ReadOnly Property Mode() As SalesPerformanceMode Implements ISalesPerformanceProvider.Mode
			Get
				Return SalesPerformanceMode.Day
			End Get
		End Property
		Public ReadOnly Property ChartType() As SalesPerformanceChartType Implements ISalesPerformanceProvider.ChartType
			Get
				Return SalesPerformanceChartType.Bar
			End Get
		End Property
		Public ReadOnly Property ChartArgumentDataMember() As String Implements ISalesPerformanceProvider.ChartArgumentDataMember
			Get
				Return "GroupName"
			End Get
		End Property
		Public ReadOnly Property ChartValueDataMember() As String Implements ISalesPerformanceProvider.ChartValueDataMember
			Get
				Return "TotalCost"
			End Get
		End Property
		Public ReadOnly Property SalesValuesFormat() As String Implements ISalesPerformanceProvider.SalesValuesFormat
			Get
				Return "${0:N0}"
			End Get
		End Property
		Public ReadOnly Property SalesValueFirst() As Double Implements ISalesPerformanceProvider.SalesValueFirst
			Get
				Return GetTotalSales(DateTimeUtils.GetDayRange(Date.Today))
			End Get
		End Property
		Public ReadOnly Property SalesValueSecond() As Double Implements ISalesPerformanceProvider.SalesValueSecond
			Get
				Return GetTotalSales(DateTimeUtils.GetDayRange(Date.Today.AddMonths(-1)))
			End Get
		End Property
		Public ReadOnly Property SalesValueThird() As Double Implements ISalesPerformanceProvider.SalesValueThird
			Get
				Return GetTotalSales(DateTimeUtils.GetLastWeekRange())
			End Get
		End Property

		Public Sub New(ByVal dataProvider As IDataProvider)
			Me.dataProvider = dataProvider
		End Sub

		Public Function GetChartData(ByVal [date] As Date) As Object Implements ISalesPerformanceProvider.GetChartData
			Dim range As DateTimeRange = DateTimeUtils.GetDayRange([date])
			Return dataProvider.GetSalesByProduct(range.Start, range.End, GroupingPeriod.All)
		End Function
		Private Function GetTotalSales(ByVal range As DateTimeRange) As Double
			Return CDbl(dataProvider.GetTotalSalesByRange(range.Start, range.End).TotalCost)
		End Function
	End Class

	Public Class UnitSalesByProduct
		Implements ISalesPerformanceProvider

		Private dataProvider As IDataProvider

		Public ReadOnly Property Mode() As SalesPerformanceMode Implements ISalesPerformanceProvider.Mode
			Get
				Return SalesPerformanceMode.Month
			End Get
		End Property
		Public ReadOnly Property ChartType() As SalesPerformanceChartType Implements ISalesPerformanceProvider.ChartType
			Get
				Return SalesPerformanceChartType.Bar
			End Get
		End Property
		Public ReadOnly Property ChartArgumentDataMember() As String Implements ISalesPerformanceProvider.ChartArgumentDataMember
			Get
				Return "GroupName"
			End Get
		End Property
		Public ReadOnly Property ChartValueDataMember() As String Implements ISalesPerformanceProvider.ChartValueDataMember
			Get
				Return "Units"
			End Get
		End Property
		Public ReadOnly Property SalesValuesFormat() As String Implements ISalesPerformanceProvider.SalesValuesFormat
			Get
				Return "{0:N0} Units"
			End Get
		End Property
		Public ReadOnly Property SalesValueFirst() As Double Implements ISalesPerformanceProvider.SalesValueFirst
			Get
				Return GetTotalSales(DateTimeUtils.GetMonthRange(Date.Today))
			End Get
		End Property
		Public ReadOnly Property SalesValueSecond() As Double Implements ISalesPerformanceProvider.SalesValueSecond
			Get
				Return GetTotalSales(DateTimeUtils.GetMonthRange(Date.Today.AddMonths(-1)))
			End Get
		End Property
		Public ReadOnly Property SalesValueThird() As Double Implements ISalesPerformanceProvider.SalesValueThird
			Get
				Return GetTotalSales(DateTimeUtils.GetLastYearRange())
			End Get
		End Property

		Public Sub New(ByVal dataProvider As IDataProvider)
			Me.dataProvider = dataProvider
		End Sub

		Public Function GetChartData(ByVal [date] As Date) As Object Implements ISalesPerformanceProvider.GetChartData
			Dim range As DateTimeRange = DateTimeUtils.GetMonthRange([date])
			Return dataProvider.GetSalesByProduct(range.Start, range.End, GroupingPeriod.All)
		End Function
		Private Function GetTotalSales(ByVal range As DateTimeRange) As Double
			Return CDbl(dataProvider.GetTotalSalesByRange(range.Start, range.End).Units)
		End Function
	End Class

	Public Class ProductsSalesByRange
		Implements ISalesByRangeProvider

		Private dataProvider As IDataProvider

		Public Sub New(ByVal dataProvider As IDataProvider)
			Me.dataProvider = dataProvider
		End Sub
		Public Function GetSalesDataForItemForPeriod(ByVal start As Date, ByVal [end] As Date) As IEnumerable(Of SalesGroup) Implements ISalesByRangeProvider.GetSalesDataForItemForPeriod
			Return dataProvider.GetSalesByProduct(start, [end], GroupingPeriod.All)
		End Function
		Public Function GetSalesDataForAllItemsForPeriod(ByVal start As Date, ByVal [end] As Date) As IEnumerable(Of SalesGroup) Implements ISalesByRangeProvider.GetSalesDataForAllItemsForPeriod
			Return dataProvider.GetSales(start, [end], GroupingPeriod.Day)
		End Function
	End Class

	Public Class DailySalesBySector
		Implements ISalesPerformanceProvider

		Private dataProvider As IDataProvider

		Public ReadOnly Property Mode() As SalesPerformanceMode Implements ISalesPerformanceProvider.Mode
			Get
				Return SalesPerformanceMode.Day
			End Get
		End Property
		Public ReadOnly Property ChartType() As SalesPerformanceChartType Implements ISalesPerformanceProvider.ChartType
			Get
				Return SalesPerformanceChartType.Bar
			End Get
		End Property
		Public ReadOnly Property ChartArgumentDataMember() As String Implements ISalesPerformanceProvider.ChartArgumentDataMember
			Get
				Return "GroupName"
			End Get
		End Property
		Public ReadOnly Property ChartValueDataMember() As String Implements ISalesPerformanceProvider.ChartValueDataMember
			Get
				Return "TotalCost"
			End Get
		End Property
		Public ReadOnly Property SalesValuesFormat() As String Implements ISalesPerformanceProvider.SalesValuesFormat
			Get
				Return "${0:N0}"
			End Get
		End Property
		Public ReadOnly Property SalesValueFirst() As Double Implements ISalesPerformanceProvider.SalesValueFirst
			Get
				Return GetTotalSales(DateTimeUtils.GetDayRange(Date.Today))
			End Get
		End Property
		Public ReadOnly Property SalesValueSecond() As Double Implements ISalesPerformanceProvider.SalesValueSecond
			Get
				Return GetTotalSales(DateTimeUtils.GetDayRange(Date.Today.AddMonths(-1)))
			End Get
		End Property
		Public ReadOnly Property SalesValueThird() As Double Implements ISalesPerformanceProvider.SalesValueThird
			Get
				Return GetTotalSales(DateTimeUtils.GetLastWeekRange())
			End Get
		End Property

		Public Sub New(ByVal dataProvider As IDataProvider)
			Me.dataProvider = dataProvider
		End Sub

		Public Function GetChartData(ByVal [date] As Date) As Object Implements ISalesPerformanceProvider.GetChartData
			Dim range As DateTimeRange = DateTimeUtils.GetDayRange([date])
			Return dataProvider.GetSalesBySector(range.Start, range.End, GroupingPeriod.All)
		End Function
		Private Function GetTotalSales(ByVal range As DateTimeRange) As Double
			Return CDbl(dataProvider.GetTotalSalesByRange(range.Start, range.End).TotalCost)
		End Function
	End Class

	Public Class UnitSalesBySector
		Implements ISalesPerformanceProvider

		Private dataProvider As IDataProvider

		Public ReadOnly Property Mode() As SalesPerformanceMode Implements ISalesPerformanceProvider.Mode
			Get
				Return SalesPerformanceMode.Month
			End Get
		End Property
		Public ReadOnly Property ChartType() As SalesPerformanceChartType Implements ISalesPerformanceProvider.ChartType
			Get
				Return SalesPerformanceChartType.Bar
			End Get
		End Property
		Public ReadOnly Property ChartArgumentDataMember() As String Implements ISalesPerformanceProvider.ChartArgumentDataMember
			Get
				Return "GroupName"
			End Get
		End Property
		Public ReadOnly Property ChartValueDataMember() As String Implements ISalesPerformanceProvider.ChartValueDataMember
			Get
				Return "Units"
			End Get
		End Property
		Public ReadOnly Property SalesValuesFormat() As String Implements ISalesPerformanceProvider.SalesValuesFormat
			Get
				Return "{0:N0} Units"
			End Get
		End Property
		Public ReadOnly Property SalesValueFirst() As Double Implements ISalesPerformanceProvider.SalesValueFirst
			Get
				Return GetTotalSales(DateTimeUtils.GetMonthRange(Date.Today))
			End Get
		End Property
		Public ReadOnly Property SalesValueSecond() As Double Implements ISalesPerformanceProvider.SalesValueSecond
			Get
				Return GetTotalSales(DateTimeUtils.GetMonthRange(Date.Today.AddMonths(-1)))
			End Get
		End Property
		Public ReadOnly Property SalesValueThird() As Double Implements ISalesPerformanceProvider.SalesValueThird
			Get
				Return GetTotalSales(DateTimeUtils.GetLastYearRange())
			End Get
		End Property

		Public Sub New(ByVal dataProvider As IDataProvider)
			Me.dataProvider = dataProvider
		End Sub

		Public Function GetChartData(ByVal [date] As Date) As Object Implements ISalesPerformanceProvider.GetChartData
			Dim range As DateTimeRange = DateTimeUtils.GetMonthRange([date])
			Return dataProvider.GetSalesBySector(range.Start, range.End, GroupingPeriod.All)
		End Function
		Private Function GetTotalSales(ByVal range As DateTimeRange) As Double
			Return CDbl(dataProvider.GetTotalSalesByRange(range.Start, range.End).Units)
		End Function
	End Class

	Public Class SectorSalesByRange
		Implements ISalesByRangeProvider

		Private dataProvider As IDataProvider

		Public Sub New(ByVal dataProvider As IDataProvider)
			Me.dataProvider = dataProvider
		End Sub
		Public Function GetSalesDataForItemForPeriod(ByVal start As Date, ByVal [end] As Date) As IEnumerable(Of SalesGroup) Implements ISalesByRangeProvider.GetSalesDataForItemForPeriod
			Return dataProvider.GetSalesBySector(start, [end], GroupingPeriod.All)
		End Function
		Public Function GetSalesDataForAllItemsForPeriod(ByVal start As Date, ByVal [end] As Date) As IEnumerable(Of SalesGroup) Implements ISalesByRangeProvider.GetSalesDataForAllItemsForPeriod
			Return dataProvider.GetSales(start, [end], GroupingPeriod.Day)
		End Function
	End Class

	Public Class DailySalesByRegion
		Implements ISalesPerformanceProvider

		Private dataProvider As IDataProvider

		Public ReadOnly Property Mode() As SalesPerformanceMode Implements ISalesPerformanceProvider.Mode
			Get
				Return SalesPerformanceMode.Day
			End Get
		End Property
		Public ReadOnly Property ChartType() As SalesPerformanceChartType Implements ISalesPerformanceProvider.ChartType
			Get
				Return SalesPerformanceChartType.Bar
			End Get
		End Property
		Public ReadOnly Property ChartArgumentDataMember() As String Implements ISalesPerformanceProvider.ChartArgumentDataMember
			Get
				Return "GroupName"
			End Get
		End Property
		Public ReadOnly Property ChartValueDataMember() As String Implements ISalesPerformanceProvider.ChartValueDataMember
			Get
				Return "TotalCost"
			End Get
		End Property
		Public ReadOnly Property SalesValuesFormat() As String Implements ISalesPerformanceProvider.SalesValuesFormat
			Get
				Return "${0:N0}"
			End Get
		End Property
		Public ReadOnly Property SalesValueFirst() As Double Implements ISalesPerformanceProvider.SalesValueFirst
			Get
				Return GetTotalSales(DateTimeUtils.GetDayRange(Date.Today))
			End Get
		End Property
		Public ReadOnly Property SalesValueSecond() As Double Implements ISalesPerformanceProvider.SalesValueSecond
			Get
				Return GetTotalSales(DateTimeUtils.GetDayRange(Date.Today.AddMonths(-1)))
			End Get
		End Property
		Public ReadOnly Property SalesValueThird() As Double Implements ISalesPerformanceProvider.SalesValueThird
			Get
				Return GetTotalSales(DateTimeUtils.GetLastWeekRange())
			End Get
		End Property

		Public Sub New(ByVal dataProvider As IDataProvider)
			Me.dataProvider = dataProvider
		End Sub

		Public Function GetChartData(ByVal [date] As Date) As Object Implements ISalesPerformanceProvider.GetChartData
			Dim range As DateTimeRange = DateTimeUtils.GetDayRange([date])
			Return dataProvider.GetSalesByRegion(range.Start, range.End, GroupingPeriod.All)
		End Function
		Private Function GetTotalSales(ByVal range As DateTimeRange) As Double
			Return CDbl(dataProvider.GetTotalSalesByRange(range.Start, range.End).TotalCost)
		End Function
	End Class

	Public Class UnitSalesByRegion
		Implements ISalesPerformanceProvider

		Private dataProvider As IDataProvider

		Public ReadOnly Property Mode() As SalesPerformanceMode Implements ISalesPerformanceProvider.Mode
			Get
				Return SalesPerformanceMode.Month
			End Get
		End Property
		Public ReadOnly Property ChartType() As SalesPerformanceChartType Implements ISalesPerformanceProvider.ChartType
			Get
				Return SalesPerformanceChartType.Bar
			End Get
		End Property
		Public ReadOnly Property ChartArgumentDataMember() As String Implements ISalesPerformanceProvider.ChartArgumentDataMember
			Get
				Return "GroupName"
			End Get
		End Property
		Public ReadOnly Property ChartValueDataMember() As String Implements ISalesPerformanceProvider.ChartValueDataMember
			Get
				Return "Units"
			End Get
		End Property
		Public ReadOnly Property SalesValuesFormat() As String Implements ISalesPerformanceProvider.SalesValuesFormat
			Get
				Return "{0:N0} Units"
			End Get
		End Property
		Public ReadOnly Property SalesValueFirst() As Double Implements ISalesPerformanceProvider.SalesValueFirst
			Get
				Return GetTotalSales(DateTimeUtils.GetMonthRange(Date.Today))
			End Get
		End Property
		Public ReadOnly Property SalesValueSecond() As Double Implements ISalesPerformanceProvider.SalesValueSecond
			Get
				Return GetTotalSales(DateTimeUtils.GetMonthRange(Date.Today.AddMonths(-1)))
			End Get
		End Property
		Public ReadOnly Property SalesValueThird() As Double Implements ISalesPerformanceProvider.SalesValueThird
			Get
				Return GetTotalSales(DateTimeUtils.GetLastYearRange())
			End Get
		End Property

		Public Sub New(ByVal dataProvider As IDataProvider)
			Me.dataProvider = dataProvider
		End Sub

		Public Function GetChartData(ByVal [date] As Date) As Object Implements ISalesPerformanceProvider.GetChartData
			Dim range As DateTimeRange = DateTimeUtils.GetMonthRange([date])
			Return dataProvider.GetSalesByRegion(range.Start, range.End, GroupingPeriod.All)
		End Function
		Private Function GetTotalSales(ByVal range As DateTimeRange) As Double
			Return CDbl(dataProvider.GetTotalSalesByRange(range.Start, range.End).Units)
		End Function
	End Class

	Public Class RegionSalesByRange
		Implements ISalesByRangeProvider

		Private dataProvider As IDataProvider

		Public Sub New(ByVal dataProvider As IDataProvider)
			Me.dataProvider = dataProvider
		End Sub
		Public Function GetSalesDataForItemForPeriod(ByVal start As Date, ByVal [end] As Date) As IEnumerable(Of SalesGroup) Implements ISalesByRangeProvider.GetSalesDataForItemForPeriod
			Return dataProvider.GetSalesByRegion(start, [end], GroupingPeriod.All)
		End Function
		Public Function GetSalesDataForAllItemsForPeriod(ByVal start As Date, ByVal [end] As Date) As IEnumerable(Of SalesGroup) Implements ISalesByRangeProvider.GetSalesDataForAllItemsForPeriod
			Return dataProvider.GetSales(start, [end], GroupingPeriod.Day)
		End Function
	End Class

	Public Class ChannelsSalesByRange
		Implements ISalesByRangeProvider

		Private dataProvider As IDataProvider

		Public Sub New(ByVal dataProvider As IDataProvider)
			Me.dataProvider = dataProvider
		End Sub
		Public Function GetSalesDataForItemForPeriod(ByVal start As Date, ByVal [end] As Date) As IEnumerable(Of SalesGroup) Implements ISalesByRangeProvider.GetSalesDataForItemForPeriod
			Return dataProvider.GetSalesByChannel(start, [end], GroupingPeriod.All)
		End Function
		Public Function GetSalesDataForAllItemsForPeriod(ByVal start As Date, ByVal [end] As Date) As IEnumerable(Of SalesGroup) Implements ISalesByRangeProvider.GetSalesDataForAllItemsForPeriod
			Return dataProvider.GetSales(start, [end], GroupingPeriod.Day)
		End Function
	End Class
End Namespace
