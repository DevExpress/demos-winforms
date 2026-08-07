Imports System
Imports DevExpress.Data.Utils
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class DateTimeDataAggregationDemo
        Inherits ChartDemoModule

        Const PointCount As Integer = 50000

        Private ReadOnly Property Series As Series
            Get
                Return If(chart.Series.Count > 0, chart.Series(0), Nothing)
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
            ChartControl.EndInit()
        End Sub

        Private Sub LoadPoints()
            If Series IsNot Nothing Then
                Dim value As Double = 0
                Dim argument As Date = TutorialConstants.Now.AddDays(-PointCount)
                Dim random As NonCryptographicRandom = NonCryptographicRandom.System
                Series.Points.BeginUpdate()
                Series.Points.Clear()
                For i As Double = 0 To PointCount - 1
                    Series.Points.Add(New SeriesPoint(argument.AddDays(i), Math.Abs(value)))
                    value +=(random.NextDouble() * 10.0 - 5.0)
                Next

                Series.Points.EndUpdate()
            End If
        End Sub

        Private Sub chart_AxisVisualRangeChanged(ByVal sender As Object, ByVal e As AxisRangeChangedEventArgs)
            If TypeOf e.Axis Is AxisX Then CType(e.Axis, AxisX).Title.Text = "Measure Unit: " & e.Axis.DateTimeScaleOptions.MeasureUnit
        End Sub
    End Class
End Namespace
