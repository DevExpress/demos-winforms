Imports System
Imports System.Data
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class SegmentColorizerDemo
        Inherits DevExpress.XtraCharts.Demos.ChartDemoModuleWithOptions

        Const FahrenheitPattern As String = "{V:F1}°F"

        Const CelsiusPattern As String = "{V:F1}°C"

        Private ReadOnly celsiusRangeStops As Double() = New Double() {-40, -35, -30, -25, -20, -15, -10, -5, 0, 5, 10, 15, 20, 25, 30}

        Private ReadOnly fahrenheitRangeStops As Double() = New Double() {-40, -31, -22, -13, -4, 5, 14, 23, 32, 41, 50, 59, 68, 77, 86}

        Private ReadOnly Property ActualRangeStops As Double()
            Get
                Return If(Me.radioGroupTemperatureUnit.SelectedIndex = 0, Me.fahrenheitRangeStops, Me.celsiusRangeStops)
            End Get
        End Property

        Private ReadOnly Property KeyColorColorizer As KeyColorColorizer
            Get
                Return CType(Me.View.Colorizer, DevExpress.XtraCharts.KeyColorColorizer)
            End Get
        End Property

        Private ReadOnly Property Series As Series
            Get
                Return Me.chart.Series(0)
            End Get
        End Property

        Private ReadOnly Property View As LineSeriesView
            Get
                Return CType(Me.Series.View, DevExpress.XtraCharts.LineSeriesView)
            End Get
        End Property

        Friend Overrides ReadOnly Property PaletteButtonEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartDesignerEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return Me.chart
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            Me.InitializeControls()
            Me.UpdateSegmentColorizer()
            Me.KeyColorColorizer.KeyProvider = New DevExpress.XtraCharts.Demos.MonthKeyProvider()
            Me.chart.DataSource = Me.PrepareData(DevExpress.XtraCharts.Demos.Utils.LoadDataTableFromXml("CityWeather.xml", "CityWeather"))
        End Sub

        Private Function CreateRangeColorizer() As SegmentColorizerBase
            Dim palette As DevExpress.XtraCharts.Palette = New DevExpress.XtraCharts.Palette("TemperaturePalette", New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.DarkBlue), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.SteelBlue), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.LightBlue), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Yellow), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.OrangeRed)})
            Dim colorizer As DevExpress.XtraCharts.RangeSegmentColorizer = New DevExpress.XtraCharts.RangeSegmentColorizer() With {.LegendItemPattern = "{V1}..{V2}", .Palette = palette}
            colorizer.RangeStops.AddRange(Me.ActualRangeStops)
            Return colorizer
        End Function

        Private Function CreateTrendColorizer() As SegmentColorizerBase
            Return New DevExpress.XtraCharts.TrendSegmentColorizer() With {.RisingTrendColor = System.Drawing.Color.Red, .FallingTrendColor = System.Drawing.Color.Blue, .RisingTrendLegendText = "Temperature Rise", .FallingTrendLegendText = "Temperature Decrease"}
        End Function

        Private Function PrepareData(ByVal table As System.Data.DataTable) As DataTable
            For Each row As System.Data.DataRow In table.Rows
                Dim [date] As System.DateTime = CDate(row(0))
                row(0) = New System.DateTime(System.DateTime.Now.Year - 1, [date].Month, [date].Day)
            Next

            Return table
        End Function

        Private Sub InitializeControls()
            Me.radioGroupTemperatureUnit.SelectedIndex = 0
            Dim items As DevExpress.XtraEditors.Controls.RadioGroupItemCollection = Me.radioGroupColorizerType.Properties.Items
            items.Add(New DevExpress.XtraEditors.Controls.RadioGroupItem(Me.CreateRangeColorizer(), "Range"))
            items.Add(New DevExpress.XtraEditors.Controls.RadioGroupItem(Me.CreateTrendColorizer(), "Trend"))
            items.Add(New DevExpress.XtraEditors.Controls.RadioGroupItem(New DevExpress.XtraCharts.PointBasedSegmentColorizer(), "Point Based"))
            Me.radioGroupColorizerType.SelectedIndex = 0
            items = Me.radioGroupChartType.Properties.Items
            items.Add(New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraCharts.ViewType.Line, "Line"))
            items.Add(New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraCharts.ViewType.Spline, "Spline"))
            items.Add(New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraCharts.ViewType.Area, "Area"))
            items.Add(New DevExpress.XtraEditors.Controls.RadioGroupItem(DevExpress.XtraCharts.ViewType.SplineArea, "Spline Area"))
            Me.radioGroupChartType.SelectedIndex = 0
        End Sub

        Private Sub radioGroupChartType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.chart.Series(CInt((0))).ChangeView(CType(Me.radioGroupChartType.EditValue, DevExpress.XtraCharts.ViewType))
        End Sub

        Private Sub radioGroupColorizerType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.UpdateSegmentColorizer()
        End Sub

        Private Sub UpdateSegmentColorizer()
            Dim selectedColorizer As DevExpress.XtraCharts.SegmentColorizerBase = CType(Me.radioGroupColorizerType.EditValue, DevExpress.XtraCharts.SegmentColorizerBase)
            Me.View.SegmentColorizer = selectedColorizer
            Dim isPointBasedSegmentColorizer As Boolean = TypeOf selectedColorizer Is DevExpress.XtraCharts.PointBasedSegmentColorizer
            Me.KeyColorColorizer.ShowInLegend = isPointBasedSegmentColorizer
            Me.View.MarkerVisibility = DevExpress.XtraCharts.Demos.Utils.CovertBoolToDefaultBoolean(isPointBasedSegmentColorizer)
            Me.chart.Legend.MaxVerticalPercentage = If(isPointBasedSegmentColorizer, 28, 30)
            Me.UpdateRangeStops(selectedColorizer)
        End Sub

        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            CType(Me.Series.DataAdapter, DevExpress.XtraCharts.DataSourceAdapter).DataMembers(DevExpress.XtraCharts.ChartDataMemberType.Value) = CStr(Me.radioGroupTemperatureUnit.EditValue)
            CType(Me.chart.Diagram, DevExpress.XtraCharts.XYDiagram).AxisY.Label.TextPattern = If(Me.radioGroupTemperatureUnit.SelectedIndex = 0, DevExpress.XtraCharts.Demos.SegmentColorizerDemo.FahrenheitPattern, DevExpress.XtraCharts.Demos.SegmentColorizerDemo.CelsiusPattern)
            Me.UpdateRangeStops(Me.View.SegmentColorizer)
        End Sub

        Private Sub UpdateRangeStops(ByVal colorizer As DevExpress.XtraCharts.SegmentColorizerBase)
            Dim rangeColorizer As DevExpress.XtraCharts.RangeSegmentColorizer = TryCast(colorizer, DevExpress.XtraCharts.RangeSegmentColorizer)
            If rangeColorizer IsNot Nothing Then
                rangeColorizer.RangeStops.Clear()
                rangeColorizer.RangeStops.AddRange(Me.ActualRangeStops)
            End If
        End Sub
    End Class

    Public Class MonthKeyProvider
        Implements DevExpress.XtraCharts.IColorizerKeyProvider

        Private ReadOnly cultureInfo As System.Globalization.CultureInfo = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

        Private Function GetKey(ByVal colorKey As Object) As Object Implements Global.DevExpress.XtraCharts.IColorizerKeyProvider.GetKey
            Return String.Format(Me.cultureInfo, "{0:MMMM}", colorKey)
        End Function
    End Class
End Namespace
