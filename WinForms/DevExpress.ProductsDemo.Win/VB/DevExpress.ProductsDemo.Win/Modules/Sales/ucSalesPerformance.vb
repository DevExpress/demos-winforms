Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.Utils
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports System.ComponentModel

Namespace DevExpress.SalesDemo.Win.Modules
	Public Enum SalesPerformanceMode
		Day
		Month
	End Enum
	Public Enum SalesPerformanceChartType
		Area
		Bar
	End Enum

	Partial Public Class ucSalesPerformance
		Inherits UserControl

		Private provider As ISalesPerformanceProvider
		Private currentDate As Date

		Public ReadOnly Property Series() As Series
			Get
				Return chart.Series(0)
			End Get
		End Property
		Public ReadOnly Property Annotation() As TextAnnotation
			Get
				Return CType(chart.Annotations(0), TextAnnotation)
			End Get
		End Property
		Public ReadOnly Property Diagram() As XYDiagram
			Get
				Return (CType(chart.Diagram, XYDiagram))
			End Get
		End Property
		Private ReadOnly Property ChartPalette() As Palette
			Get
				Return chart.PaletteRepository(chart.PaletteName)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Dim palette As Palette = ChartUtils.GeneratePalette()
			chart.PaletteRepository.Add(palette.Name, palette)
			chart.PaletteName = palette.Name
            AddHandler chart.CustomDrawAxisLabel, AddressOf ChartUtils.CustomDrawAxisLabel
            AddHandler chart.CustomDrawSeriesPoint, AddressOf ChartUtils.CustomDrawBarSeriesPoint
		End Sub
		<DefaultValue(True)>
		Public Property ShowCaptionPanel() As Boolean
			Get
				Return captionPanel.Visible
			End Get
			Set(ByVal value As Boolean)
				captionPanel.Visible = value
				UpdateChartLayout()
			End Set
		End Property

		Private Sub UpdateChartLayout()
			Dim rowSpan As Integer = 1 + (If(ShowCaptionPanel, 0, 1)) + (If(ShowButtonsPanel, 0, 1))
			Dim rowStart As Integer = 0 + (If(ShowCaptionPanel, 1, 0))
			layoutPanel.SetRow(chart, rowStart)
			layoutPanel.SetRowSpan(chart, rowSpan)
		End Sub
		<DefaultValue(True)>
		Public Property ShowButtonsPanel() As Boolean
			Get
				Return buttonsPanel.Visible
			End Get
			Set(ByVal value As Boolean)
				buttonsPanel.Visible = value
				UpdateChartLayout()
			End Set
		End Property
		Public Sub SetSalesPerformanceProvider(ByVal provider As ISalesPerformanceProvider)
			SetSalesPerformanceProvider(provider, Nothing)
		End Sub
		Public Sub SetSalesPerformanceProvider(ByVal provider As ISalesPerformanceProvider, ByVal [date]? As Date)
			Me.provider = provider
			Series.ArgumentDataMember = provider.ChartArgumentDataMember
			Series.ValueDataMembers.AddRange(provider.ChartValueDataMember)
			Select Case provider.ChartType
				Case SalesPerformanceChartType.Area
					Series.ChangeView(ViewType.Area)
					Diagram.AxisX.WholeRange.AutoSideMargins = False
					CType(Series.View, AreaSeriesView).Border.Visibility = Utils.DefaultBoolean.False
					CType(Series.View, AreaSeriesView).Transparency = 64
				Case SalesPerformanceChartType.Bar
					Series.ChangeView(ViewType.Bar)
					Dim view As BarSeriesView = (CType(Series.View, BarSeriesView))
					Dim label As BarSeriesLabel = (CType(Series.Label, BarSeriesLabel))
					view.ColorEach = True
					view.Transparency = 0
					view.Border.Visibility = Utils.DefaultBoolean.False
					label.Position = BarSeriesLabelPosition.TopInside
					label.Border.Visibility = Utils.DefaultBoolean.False
					label.FillStyle.FillMode = FillMode.Empty
					label.TextColor = Color.White
					label.Indent = 6
					label.EnableAntialiasing = Utils.DefaultBoolean.True
					Diagram.AxisX.WholeRange.AutoSideMargins = True
                    Series.LabelsVisibility = Utils.DefaultBoolean.True
                Case Else
			End Select
			Select Case provider.Mode
				Case SalesPerformanceMode.Day
					SetDayMode()
				Case SalesPerformanceMode.Month
					SetMonthMode()
			End Select
			If [date] Is Nothing Then
				[date] = Date.Today
			End If
			currentDate = [date].Value
			UpdateSalesValues()
			UpdateChart(currentDate)
			UpdateNavigationButtons(True, True)
		End Sub

		Private Sub UpdateNavigationButtons(ByVal updateCurrentButton As Boolean, ByVal updatePreviousButton As Boolean)
			Dim prevDate As Date = Date.Today
			Select Case provider.Mode
				Case SalesPerformanceMode.Day
					prevDate = Date.Today.AddDays(-1)
				Case SalesPerformanceMode.Month
					prevDate = Date.Today.AddMonths(-1)
				Case Else
			End Select
			Dim isPreviousDate As Boolean = (prevDate = currentDate)
			Dim isCurentDate As Boolean = (currentDate = Date.Today)
			btnForward.Enabled = Not isCurentDate
			If updateCurrentButton Then
				btnCurrentDate.Checked = isCurentDate
			End If
			If updatePreviousButton Then
				btnPreviousDate.Checked = isPreviousDate
			End If
		End Sub
		Private Sub SetDayMode()
			valuePresenter0.TitleText = "Today"
			valuePresenter1.TitleText = "Yesterday"
			valuePresenter2.TitleText = "Last Week"
			btnCurrentDate.Text = "Today"
			btnPreviousDate.Text = "Yesterday"
			SetPaletteColorNumber(1)
			Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Hour
			Diagram.AxisX.Label.TextPattern = "{A:t}"
			Diagram.AxisX.DateTimeScaleOptions.AggregateFunction = AggregateFunction.Sum
		End Sub
		Private Sub SetMonthMode()
			valuePresenter0.TitleText = "This Month"
			valuePresenter1.TitleText = "Last Month"
			valuePresenter2.TitleText = "YTD"
			btnCurrentDate.Text = "This Month"
			btnPreviousDate.Text = "Last Month"
			SetPaletteColorNumber(4)
			Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day
			Diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Day
			Diagram.AxisX.DateTimeScaleOptions.GridSpacing = 5
			Diagram.AxisX.Label.TextPattern = "{A:M/d}"
			Diagram.AxisX.DateTimeScaleOptions.AggregateFunction = AggregateFunction.Sum

		End Sub
		Private Sub SetPaletteColorNumber(ByVal baseColorNumber As Integer)
			If provider.ChartType = SalesPerformanceChartType.Area Then
				chart.PaletteBaseColorNumber = baseColorNumber
			End If
			If baseColorNumber > 0 Then
				Dim index As Integer = baseColorNumber - 1
				valuePresenter0.ValueTextColor = ChartPalette(index).Color
				valuePresenter1.ValueTextColor = ChartPalette(index).Color
				valuePresenter2.ValueTextColor = ChartPalette(index).Color
			End If
		End Sub
		Private Sub UpdateSalesValues()
			valuePresenter0.ValueFormat = provider.SalesValuesFormat
			valuePresenter1.ValueFormat = provider.SalesValuesFormat
			valuePresenter2.ValueFormat = provider.SalesValuesFormat
			valuePresenter0.Value = provider.SalesValueFirst
			valuePresenter1.Value = provider.SalesValueSecond
			valuePresenter2.Value = provider.SalesValueThird
		End Sub
		Private Sub UpdateChart(ByVal [date] As Date)
			Series.DataSource = provider.GetChartData([date])
			Select Case provider.Mode
				Case SalesPerformanceMode.Day
					Annotation.Text = [date].ToString("d")
				Case SalesPerformanceMode.Month
					Annotation.Text = [date].ToString("M/yyyy")
			End Select
		End Sub
		Private Function ChangeDate(ByVal [date] As Date, ByVal dateDelta As Integer) As Date
			Dim resultDate As Date = [date]
			If dateDelta <> 0 Then
				Select Case provider.Mode
					Case SalesPerformanceMode.Day
						resultDate = [date].AddDays(dateDelta)
					Case SalesPerformanceMode.Month
						resultDate = [date].AddMonths(dateDelta)
				End Select
			End If
			If resultDate > Date.Today Then
				resultDate = Date.Today
			End If
			Return resultDate
		End Function
		Private Sub ChangeDateAndUpdate(ByVal [date] As Date, ByVal dateDelta As Integer, ByVal updateCurrentButton As Boolean, ByVal updatePreviousButton As Boolean)
			currentDate = ChangeDate([date], dateDelta)
			UpdateChart(currentDate)
			UpdateNavigationButtons(updateCurrentButton, updatePreviousButton)
		End Sub

		Private Sub btnBackClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
			ChangeDateAndUpdate(currentDate, -1, True, True)
		End Sub
		Private Sub btnForwardClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnForward.Click
			ChangeDateAndUpdate(currentDate, 1, True, True)
		End Sub
		Private Sub btnPreviousDateClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnPreviousDate.Click
			ChangeDateAndUpdate(Date.Today, -1, True, False)
		End Sub
		Private Sub btnCurrentDateClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnCurrentDate.Click
			ChangeDateAndUpdate(Date.Today, 0, False, True)
		End Sub
	End Class

	Public Interface ISalesPerformanceProvider
		ReadOnly Property Mode() As SalesPerformanceMode
		ReadOnly Property ChartType() As SalesPerformanceChartType
		ReadOnly Property ChartArgumentDataMember() As String
		ReadOnly Property ChartValueDataMember() As String
		Function GetChartData(ByVal [date] As Date) As Object
		ReadOnly Property SalesValuesFormat() As String
		ReadOnly Property SalesValueFirst() As Double
		ReadOnly Property SalesValueSecond() As Double
		ReadOnly Property SalesValueThird() As Double
	End Interface
End Namespace
