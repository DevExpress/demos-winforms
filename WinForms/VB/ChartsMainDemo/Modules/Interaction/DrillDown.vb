Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class DrillDownDemo
        Inherits ChartDemoModule

        Private ReadOnly categories As List(Of String)

        Private ReadOnly linkFont As Font

        Private ReadOnly regularFont As Font

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Dim keys As Dictionary(Of String, List(Of String)).KeyCollection = SaleItem.CategorizedProducts.Keys
            categories = New List(Of String)(keys.Count)
            For Each category As String In SaleItem.CategorizedProducts.Keys
                categories.Add(category)
            Next

            chart.SeriesTemplate.SeriesDataMember = "Category"
            chart.SeriesTemplate.ArgumentDataMember = "Company"
            chart.SeriesTemplate.QualitativeSummaryOptions.SummaryFunction = "SUM([Income])"
            chart.SeriesTemplate.ChangeView(ViewType.StackedBar)
            chart.SeriesTemplate.ToolTipPointPattern = "{S}: ${V:N2}"
            Dim seriesPointLevel1Template As SeriesTemplate = CreateTemplate("Product", "OrderDate", ViewType.StackedSplineArea, False)
            Dim seriesPointLevel2Template As SeriesTemplate = CreateTemplate("Product", "OrderDate", ViewType.SplineArea, True)
            seriesPointLevel1Template.SeriesDrillTemplate = seriesPointLevel2Template
            chart.SeriesTemplate.SeriesPointDrillTemplate = seriesPointLevel1Template
            Dim argumentLevel1Template As SeriesTemplate = CreateTemplate("Category", "OrderDate", ViewType.StackedSplineArea, False)
            Dim argumentLevel2Template As SeriesTemplate = CreateTemplate("Product", "OrderDate", ViewType.StackedSplineArea, False)
            Dim argumentLevel3Template As SeriesTemplate = CreateTemplate("Product", "OrderDate", ViewType.SplineArea, True)
            argumentLevel2Template.SeriesDrillTemplate = argumentLevel3Template
            argumentLevel1Template.SeriesDrillTemplate = argumentLevel2Template
            chart.SeriesTemplate.ArgumentDrillTemplate = argumentLevel1Template
            Dim seriesLevel1Template As SeriesTemplate = CreateTemplate("Product", "Company", ViewType.StackedBar, False, True)
            Dim seriesLevel2Template As SeriesTemplate = CreateTemplate("Product", "OrderDate", ViewType.StackedSplineArea, False)
            seriesLevel2Template.SeriesDrillTemplate = CreateTemplate("Product", "OrderDate", ViewType.SplineArea, True)
            Dim seriesLevel3Template As SeriesTemplate = CreateTemplate("Company", "OrderDate", ViewType.StackedSplineArea, False)
            seriesLevel3Template.SeriesDrillTemplate = CreateTemplate("Product", "OrderDate", ViewType.SplineArea, True)
            Dim seriesLevel4Template As SeriesTemplate = CreateTemplate("Product", "OrderDate", ViewType.SplineArea, False)
            seriesLevel1Template.ArgumentDrillTemplate = seriesLevel2Template
            seriesLevel1Template.SeriesDrillTemplate = seriesLevel3Template
            seriesLevel1Template.SeriesPointDrillTemplate = seriesLevel4Template
            chart.SeriesTemplate.SeriesDrillTemplate = seriesLevel1Template
            chart.DataSource = SaleItem.GetTotalIncome()
            Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
            If diagram IsNot Nothing Then
                regularFont = diagram.AxisX.Label.Font
                linkFont = New Font(regularFont, FontStyle.Underline)
                diagram.AxisX.Label.Font = linkFont
                diagram.AxisX.DateTimeScaleOptions.ScaleMode = ScaleMode.Automatic
                diagram.AxisX.DateTimeScaleOptions.AggregateFunction = AggregateFunction.Sum
            End If
        End Sub

        Private Function CreateTemplate(ByVal seriesDataMember As String, ByVal argumentDataMember As String, ByVal viewType As ViewType, ByVal crosshairByArgument As Boolean, ByVal Optional useSummary As Boolean = False) As SeriesTemplate
            Dim template As SeriesTemplate = New SeriesTemplate()
            template.ChangeView(viewType)
            Dim view As AreaSeriesViewBase = TryCast(template.View, AreaSeriesViewBase)
            If view IsNot Nothing Then view.Transparency = 100
            template.SeriesDataMember = seriesDataMember
            template.ArgumentDataMember = argumentDataMember
            If useSummary Then
                template.QualitativeSummaryOptions.SummaryFunction = "SUM([Income])"
            Else
                template.ValueDataMembers(0) = "Income"
            End If

            template.CrosshairLabelPattern = If(crosshairByArgument, "{A:d}: ${V:N2}", "{S}: ${V:N2}")
            Return template
        End Function

        Private Sub chart_DrillDownStateChanged(ByVal sender As Object, ByVal e As DrillDownStateChangedEventArgs)
            Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
            If diagram IsNot Nothing AndAlso e.Series.Length > 0 Then
                If TypeOf e.Series(0).View Is StackedBarSeriesView Then
                    chart.CrosshairEnabled = DefaultBoolean.False
                    chart.ToolTipEnabled = DefaultBoolean.True
                    diagram.Rotated = True
                    diagram.AxisX.Label.Font = linkFont
                    diagram.EnableAxisXScrolling = False
                    diagram.EnableAxisXZooming = False
                Else
                    chart.CrosshairEnabled = DefaultBoolean.True
                    chart.ToolTipEnabled = DefaultBoolean.False
                    diagram.Rotated = False
                    diagram.AxisX.Label.Font = regularFont
                    diagram.EnableAxisXScrolling = True
                    diagram.EnableAxisXZooming = True
                End If
            End If

            For Each item As DrillDownItem In e.States
                Dim category As Object = Nothing
                If item.Parameters.TryGetValue("Category", category) Then
                    chart.PaletteBaseColorNumber = categories.IndexOf(category.ToString()) + 1
                    Return
                End If
            Next

            chart.PaletteBaseColorNumber = 0
        End Sub
    End Class
End Namespace
