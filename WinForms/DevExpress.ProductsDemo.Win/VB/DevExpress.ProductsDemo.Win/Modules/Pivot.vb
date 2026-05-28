Imports System
Imports System.Data
Imports System.Linq
Imports System.Collections.Generic
Imports System.Globalization
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraCharts
Imports DevExpress.SalesDemo.Model
Imports DevExpress.SalesDemo.Win
Imports DevExpress.SalesDemo.Win.Modules

Namespace DevExpress.ProductsDemo.Win.Modules
	Partial Public Class PivotModuleNew
		Inherits BaseModule

		Protected Overrides Property AutoMergeRibbon() As Boolean
			Get
				Return True
			End Get
			Set(ByVal value As Boolean)
				MyBase.AutoMergeRibbon = value
			End Set
		End Property
		Private currentRange, range As DateTimeRange
		Private dataProvider As IDataProvider
		Private rangeControlClient As RangeControlSalesClient
		Public Sub New()
			InitializeComponent()
			InitializePivot()
			Initialize()
			UpdateData()
			UpdateTiles()
			AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
			LookAndFeel_StyleChanged(Nothing, EventArgs.Empty)
		End Sub

		Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
			'tiles.AppearanceItem.Normal.BackColor = LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.Control);
			'tiles.AppearanceItem.Normal.ForeColor = LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.ControlText);
			'tiles.AppearanceItem.Normal.BorderColor = LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.ControlDark);
		End Sub

		Private Sub InitializePivot()
			pivot.OptionsFilterPopup.FieldFilterPopupMode = FieldFilterPopupMode.Excel
			pivot.Fields.Add(New PivotGridField("StartOfPeriod", PivotArea.RowArea) With {
				.Caption = "Year",
				.GroupInterval = PivotGroupInterval.DateYear,
				.TotalsVisibility = PivotTotalsVisibility.None
			})
			pivot.Fields.Add(New PivotGridField("StartOfPeriod", PivotArea.RowArea) With {
				.Caption = "Month",
				.GroupInterval = PivotGroupInterval.DateMonth,
				.TotalsVisibility = PivotTotalsVisibility.None
			})
			pivot.Fields.Add(New PivotGridField("GroupName", PivotArea.ColumnArea) With {.Caption = "Product"})
			pivot.Fields.Add(New PivotGridField("TotalCost", PivotArea.DataArea) With {.Caption = "Sales"})
			pivot.Fields.Add(New PivotGridField("Units", PivotArea.DataArea) With {.Caption = "Units"})
		End Sub

		Private Sub UpdateData()
			RemoveHandler Me.rangeControl.RangeChanged, AddressOf rangeControl_RangeChanged
			ucUnits.SetSalesPerformanceProvider(New UnitsByProductByDateRange(dataProvider, Me.currentRange))
			ucSales.SetSalesPerformanceProvider(New SalesByProductByDateRange(dataProvider, Me.currentRange))
			pivot.DataSource = dataProvider.GetSalesByProduct(currentRange.Start, currentRange.End, GroupingPeriod.Day).ToList()
			pivot.BestFit()
			AddHandler Me.rangeControl.RangeChanged, AddressOf rangeControl_RangeChanged
			ucUnits.Annotation.Text = "Units" '.Visible = false;
			'FreePosition fp;fp.doc
			ucUnits.Annotation.ShapePosition = New FreePosition() With {
				.DockCorner = XtraCharts.DockCorner.RightTop,
				.DockTarget = CType(ucUnits.chart.Diagram, XYDiagram).DefaultPane
			}
			ucSales.Annotation.Text = "Sales" '.Visible = false;
			ucSales.Annotation.ShapePosition = New FreePosition() With {.DockCorner = XtraCharts.DockCorner.LeftTop}
		End Sub

		Private Sub Initialize()
			Me.dataProvider = DataSource.GetDataProvider()
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: this.range = this.currentRange = DateTimeUtils.GetOneYearRange();
			Me.currentRange = DateTimeUtils.GetOneYearRange()
			Me.range = Me.currentRange
			ucSales.Diagram.AxisY.Visibility = Utils.DefaultBoolean.False
			ucSales.Diagram.AxisX.Visibility = Utils.DefaultBoolean.False
			ucUnits.Diagram.AxisY.Visibility = Utils.DefaultBoolean.False
			ucUnits.Diagram.AxisX.Visibility = Utils.DefaultBoolean.False
			ucUnits.Diagram.Margins.All = 0
			ucUnits.Diagram.Rotated = True
			ucUnits.chart.Legend.AlignmentVertical = LegendAlignmentVertical.Top
			ucUnits.chart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside

			ucUnits.chart.Legend.Border.Visibility = Utils.DefaultBoolean.False
			ucUnits.chart.Legend.Margins.Right = 0
			ucUnits.chart.Legend.MarkerSize = New System.Drawing.Size(18, 18)
			ucUnits.chart.Legend.MarkerMode = LegendMarkerMode.None
			ucUnits.chart.Legend.TextOffset = 8
			ucUnits.chart.Legend.VerticalIndent = 4
			ucUnits.chart.Legend.Visibility = Utils.DefaultBoolean.True
			ucUnits.chart.Series(0).LegendTextPattern = "{A}"
			ucSales.Diagram.Margins.All = 0

			Dim palette As Palette = ChartUtils.GeneratePalette()
			Me.rangeControlClient = New RangeControlSalesClient(palette(3).Color)
			Me.rangeControlClient.YearMonth = True
			rangeControl.Client = Me.rangeControlClient
			Dim sales As IEnumerable(Of SalesGroup) = dataProvider.GetSales(range.Start, range.End, GroupingPeriod.Day)
			Me.rangeControlClient.UpdateData(sales)

		End Sub
		Private Sub UpdateTiles()
			Dim ytd = DateTimeUtils.GetYtdRange()
			Dim ytdPrev = New DateTimeRange(ytd.Start.AddYears(-1), ytd.End.AddYears(-1))
			Dim ytdSales = dataProvider.GetTotalSalesByRange(ytd.Start, ytd.End)
			tiUnitSales.Elements(1).Text = ytdSales.Units.ToString("n0")
			tiDirectSales.Elements(1).Text = ytdSales.TotalCost.ToString("$#,##0,,M", CultureInfo.InvariantCulture)
			Dim ytdSalesPrev = dataProvider.GetTotalSalesByRange(ytdPrev.Start, ytdPrev.End)
			If ytdSalesPrev.TotalCost <> Decimal.Zero Then
				Dim percents As Decimal = (ytdSales.TotalCost - ytdSalesPrev.TotalCost) / ytdSalesPrev.TotalCost
				tiRevenue.Elements(1).Text = String.Format("{1}{0:P1}", Math.Abs(percents),If(percents < 0, "-", "+"))
			Else
				tiRevenue.Elements(1).Text = "N/A"
			End If

			Dim sector = dataProvider.GetSalesBySector(ytd.Start, ytd.End, GroupingPeriod.All).OrderByDescending(Function(q) q.TotalCost).FirstOrDefault()
			If sector Is Nothing Then
				tiBestSector.Visible = False
			Else
				tiBestSector.Text = String.Format(tiBestSector.Text, sector.GroupName.ToUpper())
				tiBestSector.Elements(1).Text = sector.TotalCost.ToString("$#,##0,,M", CultureInfo.InvariantCulture)
			End If
		End Sub

		Private Sub rangeControl_RangeChanged(ByVal sender As Object, ByVal range As XtraEditors.RangeControlRangeEventArgs)
			Dim start As Date = Me.range.Start.AddDays(DirectCast(range.Range.Minimum, Integer))
			Dim [end] As Date = Me.range.Start.AddDays(DirectCast(range.Range.Maximum, Integer))
			Me.currentRange = New DateTimeRange(start, [end])
			UpdateData()

		End Sub

	End Class
	Public Class SalesByProductByDateRange
		Implements ISalesPerformanceProvider

		Protected dataProvider As IDataProvider
		Protected range As DateTimeRange
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
		Public Overridable ReadOnly Property ChartValueDataMember() As String Implements ISalesPerformanceProvider.ChartValueDataMember
			Get
				Return "TotalCost"
			End Get
		End Property
		Public ReadOnly Property SalesValuesFormat() As String Implements ISalesPerformanceProvider.SalesValuesFormat
			Get
				Return "${0:N0}"
			End Get
		End Property
		Public Overridable ReadOnly Property SalesValueFirst() As Double Implements ISalesPerformanceProvider.SalesValueFirst
			Get
				Return 0
			End Get
		End Property
		Public Overridable ReadOnly Property SalesValueSecond() As Double Implements ISalesPerformanceProvider.SalesValueSecond
			Get
				Return 0
			End Get
		End Property
		Public Overridable ReadOnly Property SalesValueThird() As Double Implements ISalesPerformanceProvider.SalesValueThird
			Get
				Return 0
			End Get
		End Property

		Public Sub New(ByVal dataProvider As IDataProvider, ByVal range As DateTimeRange)
			Me.range = range
			Me.dataProvider = dataProvider
		End Sub

		Public Overridable Function GetChartData(ByVal [date] As Date) As Object Implements ISalesPerformanceProvider.GetChartData
			Return dataProvider.GetSalesByProduct(range.Start, range.End, GroupingPeriod.All)
		End Function
	End Class
	Public Class UnitsByProductByDateRange
		Inherits SalesByProductByDateRange

		Public Sub New(ByVal dataProvider As IDataProvider, ByVal range As DateTimeRange)
			MyBase.New(dataProvider, range)
		End Sub
		Public Overrides Function GetChartData(ByVal [date] As Date) As Object
			Return dataProvider.GetSalesByProduct(range.Start, range.End, GroupingPeriod.All)
		End Function
		Public Overrides ReadOnly Property ChartValueDataMember() As String
			Get
				Return "Units"
			End Get
		End Property
	End Class

End Namespace
