Imports System
Imports DevExpress.Data.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class TimeSpanDataAggregationDemo
        Inherits ChartDemoModule

        Const PointCount As Integer = 50000

        Private ReadOnly random As NonCryptographicRandom = NonCryptographicRandom.System

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
            GeneratePoints(chart.Series(0), 20, 35, 80)
            GeneratePoints(chart.Series(1), 20, 25, 50)
            ChartControl.EndInit()
        End Sub

        Private Sub GeneratePoints(ByVal series As Series, ByVal initialValue As Double, ByVal min As Double, ByVal max As Double)
            If series IsNot Nothing Then
                series.Points.BeginUpdate()
                series.Points.Clear()
                Dim value As Double = initialValue
                Dim threshold As Double =(min - initialValue) / 0.2
                For i As Double = 0 To threshold - 1
                    series.Points.Add(New SeriesPoint(TimeSpan.FromSeconds(i), value))
                    value += random.NextDouble() - 0.3
                Next

                For i As Double = threshold To PointCount - 1
                    series.Points.Add(New SeriesPoint(TimeSpan.FromSeconds(i), value))
                    value = Math.Max(Math.Min(value + random.NextDouble() - 0.5, max), min)
                Next

                series.Points.EndUpdate()
            End If
        End Sub

        Private Sub Chart_AxisVisualRangeChanged(ByVal sender As Object, ByVal e As AxisRangeChangedEventArgs)
            Dim axisX As AxisX = Diagram.AxisX
            Dim axisY As AxisY = Diagram.AxisY
            If axisX.Equals(e.Axis) Then
                axisX.Title.Text = "Measure Unit: " & e.Axis.TimeSpanScaleOptions.MeasureUnit
            ElseIf axisY.Equals(e.Axis) Then
                Diagram.SecondaryAxesY(0).WholeRange.SetMinMaxValues(ConvertCelsiusToFahrenheit(axisY.VisualRange.MinValueInternal), ConvertCelsiusToFahrenheit(axisY.VisualRange.MaxValueInternal))
            End If
        End Sub

        Private Sub Chart_CustomDrawCrosshair(ByVal sender As Object, ByVal e As CustomDrawCrosshairEventArgs)
            If e.CrosshairElementGroups.Count > 0 AndAlso e.CrosshairElementGroups(0).CrosshairElements.Count > 0 Then
                For Each element As CrosshairElement In e.CrosshairElementGroups(0).CrosshairElements
                    If element.LabelElement IsNot Nothing AndAlso element.SeriesPoint IsNot Nothing Then element.LabelElement.Text += String.Format(", {0:0}°F", ConvertCelsiusToFahrenheit(element.SeriesPoint.Values(0)))
                Next
            End If
        End Sub
    End Class
End Namespace
