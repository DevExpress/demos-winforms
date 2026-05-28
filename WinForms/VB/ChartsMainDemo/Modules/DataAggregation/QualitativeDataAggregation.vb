Imports System
Imports System.Collections.Generic

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class QualitativeDataAggregationDemo
        Inherits ChartDemoModuleWithOptions

        Private ReadOnly Property QualitativeScaleOption As QualitativeScaleOptions
            Get
                Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
                If diagram IsNot Nothing Then Return diagram.AxisX.QualitativeScaleOptions
                Return Nothing
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Dim items As List(Of SaleItem) = SaleItem.GetProductsIncome()
            ChartControl.BeginInit()
            chart.Series(0).DataSource = items
            gridControl1.DataSource = items
            ChartControl.EndInit()
            radioGroupAggregationFunction.SelectedIndex = 4
        End Sub

        Private Sub radioGroupAggregationFunction_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If QualitativeScaleOption Is Nothing Then Return
            Dim functionIndex As Integer = radioGroupAggregationFunction.SelectedIndex
            QualitativeScaleOption.AggregateFunction = CType(functionIndex, AggregateFunction)
            Select Case functionIndex
                Case 0
                    SetTitles("Sales Volume", "Volume (USD)")
                Case 1
                    SetTitles("Average Order Amount", "Volume (USD)")
                Case 2
                    SetTitles("Minimal Order Amount", "Volume (USD)")
                Case 3
                    SetTitles("Maximal Order Amount", "Volume (USD)")
                Case 4
                    SetTitles("Sales Volume", "Volume (USD)")
                Case 5
                    SetTitles("Overall Orders Count", "Count")
            End Select

            ChartControl.Animate()
        End Sub

        Private Sub SetTitles(ByVal axisTitle As String, ByVal chartTitle As String)
            CType(chart.Diagram, XYDiagram).AxisY.Title.Text = axisTitle
            If chart.Titles.Count > 0 Then chart.Titles(0).Text = chartTitle
        End Sub
    End Class
End Namespace
