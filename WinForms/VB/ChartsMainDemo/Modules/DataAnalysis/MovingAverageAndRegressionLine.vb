Imports System

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class MovingAverageAndRegressionLineDemo
        Inherits ChartDemoModuleWithOptions

        Private ReadOnly Property Series As Series
            Get
                Return If(chart.Series.Count > 0, chart.Series(0), Nothing)
            End Get
        End Property

        Private ReadOnly Property SeriesView As XYDiagramSeriesViewBase
            Get
                Return If(Series IsNot Nothing, TryCast(Series.View, XYDiagramSeriesViewBase), Nothing)
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
            Series.BindToData(PointGenerator.Generate(), "Argument", "Value")
            checkEditRegressionLineVisible.Checked = True
            radioGroupMovingAverage.SelectedIndex = 0
            comboBoxEditMovingAverageKind.SelectedIndex = 0
            Dim diagram As XYDiagram = CType(ChartControl.Diagram, XYDiagram)
            ChartControl.Diagram = diagram
            ChartControl.EndInit()
            ChartControl.BeginInit()
            diagram.AxisX.VisualRange.SetMinMaxValues(-1250, 1250)
            diagram.AxisY.VisualRange.SetMinMaxValues(-700, 1800)
            ChartControl.EndInit()
        End Sub

        Private Function GetMovingAverage() As MovingAverage
            If SeriesView Is Nothing Then Return Nothing
            Dim indicatorName As String = TryCast(radioGroupMovingAverage.EditValue, String)
            For Each indicator As Indicator In SeriesView.Indicators
                If TypeOf indicator Is MovingAverage AndAlso Equals(indicator.Name, indicatorName) Then Return CType(indicator, MovingAverage)
            Next

            Return Nothing
        End Function

        Private Sub HideAllMovingAverages()
            If SeriesView Is Nothing Then Return
            For Each indicator As Indicator In SeriesView.Indicators
                If TypeOf indicator Is MovingAverage Then indicator.Visible = False
            Next
        End Sub

        Private Sub checkEditRegressionLineVisible_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If SeriesView Is Nothing Then Return
            For Each indicator As Indicator In SeriesView.Indicators
                If TypeOf indicator Is RegressionLine Then indicator.Visible = checkEditRegressionLineVisible.Checked
            Next
        End Sub

        Private Sub radioGroupMovingAverage_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim indicatorName As String = TryCast(radioGroupMovingAverage.EditValue, String)
            HideAllMovingAverages()
            Dim movingAverage As MovingAverage = GetMovingAverage()
            If movingAverage Is Nothing Then Return
            movingAverage.Visible = True
            spinEditPointsCount.Value = movingAverage.PointsCount
            spinEditEnvelopePercent.Value = CDec(movingAverage.EnvelopePercent)
            comboBoxEditMovingAverageKind.SelectedIndex = CInt(movingAverage.Kind)
        End Sub

        Private Sub spinEditPointsCount_Properties_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim movingAverage As MovingAverage = GetMovingAverage()
            If movingAverage Is Nothing Then Return
            movingAverage.PointsCount = CInt(spinEditPointsCount.Value)
        End Sub

        Private Sub comboBoxEditMovingAverageKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim movingAverage As MovingAverage = GetMovingAverage()
            If movingAverage Is Nothing Then Return
            movingAverage.Kind = CType(comboBoxEditMovingAverageKind.SelectedIndex, MovingAverageKind)
            If comboBoxEditMovingAverageKind.SelectedIndex = 0 Then
                spinEditEnvelopePercent.Enabled = False
            Else
                spinEditEnvelopePercent.Enabled = True
            End If
        End Sub

        Private Sub spinEditEnvelopePercent_Properties_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim movingAverage As MovingAverage = GetMovingAverage()
            If movingAverage Is Nothing Then Return
            movingAverage.EnvelopePercent = CDbl(spinEditEnvelopePercent.Value)
        End Sub
    End Class
End Namespace
