Imports DevExpress.Data.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class NumericDataAggregationDemo
        Inherits ChartDemoModule

        Const PointCount As Integer = 500000

        Private ReadOnly Property Series As Series
            Get
                Return If(chart.Series.Count > 0, chart.Series(0), Nothing)
            End Get
        End Property

        Private ReadOnly Property Diagram As XYDiagram
            Get
                Return TryCast(chart.Diagram, XYDiagram)
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ChartControl.BeginInit()
            LoadPoints()
            Diagram.AxisX.NumericScaleOptions.ScaleMode = ScaleMode.Automatic
            Dim crosshairPosition As CrosshairFreePosition = New CrosshairFreePosition()
            crosshairPosition.DockTarget = CType(ChartControl.Diagram, XYDiagram2D).DefaultPane
            crosshairPosition.DockCorner = DockCorner.LeftTop
            ChartControl.CrosshairOptions.CommonLabelPosition = crosshairPosition
            For Each series As Series In chart.Series
                series.CrosshairLabelPattern = "{A} : {V:F2}"
            Next

            ChartControl.EndInit()
        End Sub

        Private Sub LoadPoints()
            If Series IsNot Nothing Then
                Dim value As Double = 0
                Dim argument As Double = 1
                Dim random As NonCryptographicRandom = NonCryptographicRandom.System
                Series.Points.BeginUpdate()
                Series.Points.Clear()
                For i As Double = 0 To PointCount - 1
                    Series.Points.Add(New SeriesPoint(argument, value))
                    value +=(random.NextDouble() * 10.0 - 5.0)
                    argument += 1
                Next

                Series.Points.EndUpdate()
            End If
        End Sub

        Private Sub chart_AxisVisualRangeChanged(ByVal sender As Object, ByVal e As AxisRangeChangedEventArgs)
            If TypeOf e.Axis Is AxisX Then CType(e.Axis, AxisX).Title.Text = "Measure Unit: " & e.Axis.NumericScaleOptions.MeasureUnit
        End Sub
    End Class
End Namespace
