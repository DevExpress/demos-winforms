Imports System
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos.PivotGridAndChart

    Public Partial Class Report
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
            Name = ReportNames.PivotGridAndChartName
            DisplayName = ReportNames.PivotGridAndChart
            parameterViewType.Type = GetType(ViewTypeFiltered)
            parameterViewType.Value = ViewTypeFiltered.StackedSplineArea
            AddHandler BeforePrint, AddressOf Report_BeforePrint
        End Sub

        Private Sub Report_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            xrChart.BeginInit()
            If TypeOf parameterViewType.Value Is ViewTypeFiltered Then xrChart.SeriesTemplate.ChangeView(CType(parameterViewType.Value, ViewType))
            Dim labelsVisible As Boolean = Convert.ToBoolean(parameterShowLabels.Value)
            xrChart.SeriesTemplate.LabelsVisibility = If(labelsVisible, DefaultBoolean.True, DefaultBoolean.False)
            Dim diagram As Diagram3D = TryCast(xrChart.Diagram, Diagram3D)
            If diagram IsNot Nothing AndAlso Not labelsVisible Then
                diagram.ZoomPercent = 190
                diagram.VerticalScrollPercent = 5
            End If

            xrPivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = Convert.ToBoolean(parameterShowRowGrandTotals.Value)
            xrPivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = Convert.ToBoolean(parameterShowColumnGrandTotals.Value)
            xrPivotGrid.OptionsChartDataSource.ProvideDataByColumns = Convert.ToBoolean(parameterGenerateSeriesFromColumns.Value)
            xrChart.EndInit()
        End Sub
    End Class
End Namespace
