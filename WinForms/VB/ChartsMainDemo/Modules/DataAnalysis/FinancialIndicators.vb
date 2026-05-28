Imports System
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class FinancialIndicatorsDemo
        Inherits ChartDemoModule

        Const MaxZoomPointCount As Integer = 183

        Private crosshairEnabled As DefaultBoolean

        Private ReadOnly Property XYDiagram As XYDiagram
            Get
                Return TryCast(chart.Diagram, XYDiagram)
            End Get
        End Property

        Private ReadOnly Property FinancialSeriesView As FinancialSeriesViewBase
            Get
                If chart.Series.Count = 0 Then Return Nothing
                Return TryCast(chart.Series(0).View, FinancialSeriesViewBase)
            End Get
        End Property

        Private ReadOnly Property IsToolbarInteractionEnabled As Boolean
            Get
                Return trendLineBarCheckItem.Checked OrElse fibbArcBarCheckItem.Checked OrElse fibbFansBarCheckItem.Checked OrElse fibbRetrBarCheckItem.Checked OrElse removeBarCheckItem.Checked OrElse addTextAnnotationBarItem.Checked OrElse addImageAnnotationBarItem.Checked
            End Get
        End Property

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
            ChartControl.BeginInit()
            ChartControl.DataSource = ReadFinancialData("USDJPYDaily.csv")
            ChartControl.EndInit()
            AddIndicators()
        End Sub

        Private Sub AddIndicators()
            Dim indicator As FibonacciIndicator = New FibonacciIndicator() With {.Kind = FibonacciIndicatorKind.FibonacciArcs}
            indicator.Point1.Argument = New DateTime(2017, 9, 20)
            indicator.Point2.Argument = New DateTime(2017, 11, 20)
            FinancialSeriesView.Indicators.Add(indicator)
            indicator = New FibonacciIndicator() With {.Kind = FibonacciIndicatorKind.FibonacciFans}
            indicator.Point1.Argument = New DateTime(2017, 9, 8)
            indicator.Point2.Argument = New DateTime(2017, 11, 6)
            FinancialSeriesView.Indicators.Add(indicator)
        End Sub

        Private Sub chart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim visualMin As Date =(CDate(XYDiagram.AxisX.VisualRange.MaxValue)).AddDays(-300)
            Dim visualMax As Date =(CDate(XYDiagram.AxisX.WholeRange.MaxValue)).AddDays(XYDiagram.AxisX.WholeRange.SideMarginsValue)
            XYDiagram.AxisX.VisualRange.SetMinMaxValues(visualMin, visualMax)
            crosshairEnabled = ChartControl.CrosshairEnabled
        End Sub

        Private Sub chart_BeforeZoom(ByVal sender As Object, ByVal e As ChartBeforeZoomEventArgs)
            If Not(TypeOf e.Axis Is AxisX) Then Return
            Dim rangeLengthInMeasureUnits As Double = e.NewRange.Max - e.NewRange.Min
            If rangeLengthInMeasureUnits > MaxZoomPointCount Then e.Cancel = True
        End Sub

        Private Sub checkItem_CheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            ChartControl.CrosshairEnabled = If(IsToolbarInteractionEnabled, DefaultBoolean.False, crosshairEnabled)
        End Sub

        Private Sub chart_MouseUp(ByVal sender As Object, ByVal e As Windows.Forms.MouseEventArgs)
            If IsToolbarInteractionEnabled Then ChartControl.CrosshairEnabled = crosshairEnabled
        End Sub
    End Class
End Namespace
