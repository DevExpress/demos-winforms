Imports System.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class ConstantLinesAndStripsDemo
        Inherits ChartDemoModule

        Private ReadOnly optimalTemperatureDefaultLine As ConstantLine

        Private ReadOnly temperatureData As TemperatureData = New TemperatureData()

        Friend Overrides ReadOnly Property PaletteButtonEnabled As Boolean
            Get
                Return False
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AutoMergeRibbon = True
            ChartControl.BeginInit()
            Dim series As Series = New Series("Surface Temperature", ViewType.Spline)
            series.BindToData(temperatureData.Data, "TimeStamp", "Temperature")
            Dim splineView As SplineSeriesView = CType(series.View, SplineSeriesView)
            splineView.Color = Color.FromArgb(255, 147, 8, 255)
            splineView.LineMarkerOptions.Size = 1
            series.CheckableInLegend = False
            series.CrosshairLabelPattern = "{V:0.##}°C"
            ChartControl.Series.Add(series)
            ChartControl.PaletteBaseColorNumber = 5
            ChartControl.BorderOptions.Visibility = DefaultBoolean.False
            ChartControl.Legend.Border.Visibility = DefaultBoolean.False
            ChartControl.Legend.BackColor = Color.Transparent
            AddHandler ChartControl.ConstantLineMoved, AddressOf ChartControl_ConstantLineMoved
            Dim diagram As XYDiagram = New XYDiagram()
            ChartControl.Diagram = diagram
            diagram.EnableAxisXScrolling = True
            diagram.EnableAxisXZooming = True
            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Second
            diagram.AxisX.WholeRange.AutoSideMargins = False
            diagram.AxisX.WholeRange.SideMarginsValue = 0
            diagram.ZoomingOptions.AxisXMaxZoomPercent = 200
            diagram.AxisY.WholeRange.AlwaysShowZeroLevel = False
            diagram.AxisY.Interlaced = False
            Dim edge1 As Double = temperatureData.OptimalTemperature + 30
            Dim edge2 As Double = temperatureData.MaxTemperaturePoint.Temperature
            Dim extremelyHighTemperatureStrip As Strip = New Strip("Extremely High Temperature", edge1, edge2) With {.Color = Color.FromArgb(150, 209, 99, 73)}
            diagram.AxisY.Strips.Add(extremelyHighTemperatureStrip)
            edge1 = temperatureData.OptimalTemperature + 10
            edge2 = temperatureData.OptimalTemperature + 30
            Dim highTemperatureStrip As Strip = New Strip("High Temperature", edge1, edge2) With {.Color = Color.FromArgb(150, 209, 144, 73)}
            diagram.AxisY.Strips.Add(highTemperatureStrip)
            edge1 = temperatureData.OptimalTemperature - 10
            edge2 = temperatureData.OptimalTemperature + 10
            Dim normalTemperatureStrip As Strip = New Strip("Normal Temperature", edge1, edge2) With {.Color = Color.FromArgb(150, 143, 176, 140)}
            diagram.AxisY.Strips.Add(normalTemperatureStrip)
            edge2 = temperatureData.OptimalTemperature - 10
            edge1 = temperatureData.MinTemperaturePoint.Temperature
            Dim lowTemperatureStrip As Strip = New Strip("Low Temperature", edge1, edge2) With {.Color = Color.FromArgb(150, 140, 173, 174)}
            diagram.AxisY.Strips.Add(lowTemperatureStrip)
            optimalTemperatureDefaultLine = New ConstantLine("Optimal Temperature", temperatureData.OptimalTemperature)
            optimalTemperatureDefaultLine.ShowBehind = True
            optimalTemperatureDefaultLine.RuntimeMoving = True
            optimalTemperatureDefaultLine.Title.Alignment = ConstantLineTitleAlignment.Far
            diagram.AxisY.ConstantLines.Add(optimalTemperatureDefaultLine)
            ChartControl.Legend.MarkerMode = LegendMarkerMode.CheckBoxAndMarker
            ChartControl.CrosshairOptions.ShowArgumentLabels = True
            Dim title As ChartTitle = New ChartTitle() With {.Text = "Operating Surface Temperature"}
            ChartControl.Titles.Add(title)
            ChartControl.AnimationStartMode = ChartAnimationMode.OnLoad
            ChartControl.EndInit()
        End Sub

        Private Sub ChartControl_ConstantLineMoved(ByVal sender As Object, ByVal e As ConstantLineMovedEventArgs)
            If e.ConstantLine IsNot optimalTemperatureDefaultLine Then Return
            If CDbl(e.ConstantLine.AxisValue) > temperatureData.OptimalTemperature + 10 Then e.ConstantLine.AxisValue = temperatureData.OptimalTemperature + 10
            If CDbl(e.ConstantLine.AxisValue) < temperatureData.OptimalTemperature - 10 Then e.ConstantLine.AxisValue = temperatureData.OptimalTemperature - 10
        End Sub
    End Class
End Namespace
