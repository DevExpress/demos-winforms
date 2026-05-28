Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class TooltipAndCrosshairDemo
        Inherits ChartDemoModuleWithOptions

        Private Shared ReadOnly DefaultToolTipChartSize As Size = New Size(300, 200)

        Private focusedChart As ChartControl

        Private chartBar As ChartControl

        Private ReadOnly toolTipMousePosition As ToolTipMousePosition = New ToolTipMousePosition()

        Private ReadOnly toolTipRelativePosition As ToolTipRelativePosition = New ToolTipRelativePosition()

        Private ReadOnly toolTipFreePosition As ToolTipFreePosition = New ToolTipFreePosition()

        Private toolTipChartSize As Size = DefaultToolTipChartSize

        Private tooltipShowImage As Boolean = True

        Private ReadOnly Property CrosshairOptions As CrosshairOptions
            Get
                Return chartSpline.CrosshairOptions
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return focusedChart
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControls As List(Of ChartControl)
            Get
                Return New List(Of ChartControl)() From {chartBar, chartSpline}
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            Dim items As List(Of CategorySaleItem) = SaleItem.GetProductsCategoriesByMonth()
            chartBar.DataSource = items
            chartBar.SelectedItems.Add(items(4))
            chartSpline.SeriesTemplate.DateTimeSummaryOptions.SummaryFunction = "SUM([Income])"
            toolTipFreePosition.DockTarget = CType(chartBar.Diagram, XYDiagram2D).DefaultPane
            comboBoxEditTooltipPosition.SelectedIndex = 1
            focusedChart = chartBar
        End Sub

        Private Function Create(ByVal categorySaleItem As CategorySaleItem) As SuperToolTip
            Dim superTip As SuperToolTip = New SuperToolTip()
            Dim title As ToolTipTitleItem = New ToolTipTitleItem() With {.Text = categorySaleItem.Category}
            title.Appearance.TextOptions.HAlignment = HorzAlignment.Center
            superTip.Items.Add(title)
            superTip.Items.Add(New ToolTipSeparatorItem())
            For Each item As KeyValuePair(Of String, Double) In categorySaleItem.ProductIncome
                superTip.Items.Add(New ToolTipItem With {.Text = String.Format("{0}: {1}", item.Key, item.Value)})
            Next

            Return superTip
        End Function

        Private Sub UpdateSplineChartColors(ByVal item As CategorySaleItem)
            Dim splineChartBaseColor As Color = GetColorFromPaletteByNumber(item.OrderIndex)
            Dim seriesCount As Integer = chartSpline.Series.Count
            For i As Integer = 0 To seriesCount - 1
                chartSpline.Series(i).View.Color = ConvertColor(splineChartBaseColor, i, seriesCount)
            Next
        End Sub

        Private Function GetColorFromPaletteByNumber(ByVal colorNumber As Integer) As Color
            If chartBar.Series.Count = 0 Then Return Color.Empty
            Dim entries As PaletteEntry() = chartBar.GetPaletteEntries(chartBar.Series(0).Points.Count)
            Return entries(colorNumber).Color
        End Function

        Private Function CreateChart(ByVal toolTipChartDataSource As List(Of SaleItem), ByVal chartTitleText As String, ByVal seriesColor As Color) As Image
            Dim chart As ChartControl = New ChartControl()
            chart.Size = toolTipChartSize
            chart.BorderOptions.Visibility = DefaultBoolean.False
            chart.DataSource = toolTipChartDataSource
            Dim series As Series = New Series("Products Income", ViewType.Bar)
            series.ValueDataMembers.AddRange("Income")
            series.ArgumentDataMember = "Product"
            series.LabelsVisibility = DefaultBoolean.False
            series.View.Color = seriesColor
            series.ArgumentScaleType = ScaleType.Qualitative
            series.QualitativeSummaryOptions.SummaryFunction = "SUM([Income])"
            chart.Series.Add(series)
            chart.Legend.Visibility = DefaultBoolean.False
            Dim xyDiagram As XYDiagram = CType(chart.Diagram, XYDiagram)
            xyDiagram.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram.AxisX.Label.DXFont = New DXFont("Tahoma", 7)
            xyDiagram.AxisX.QualitativeScaleOptions.AutoGrid = False
            xyDiagram.AxisX.Tickmarks.MinorVisible = False
            chart.Titles.Add(New ChartTitle() With {.Text = chartTitleText, .DXFont = New DXFont("Tahoma", 12)})
            Dim chartAsImage As Image
            Using stream As MemoryStream = New MemoryStream()
                chart.ExportToImage(stream, DXImageFormat.Png)
                chartAsImage = New Bitmap(stream)
            End Using

            Return chartAsImage
        End Function

        Private Sub comboBoxEditToolTipPosition_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Select Case comboBoxEditTooltipPosition.SelectedIndex
                Case 0
                    chartBar.ToolTipOptions.ToolTipPosition = toolTipMousePosition
                    barChartToolTipController.ShowBeak = True
                Case 1
                    chartBar.ToolTipOptions.ToolTipPosition = toolTipRelativePosition
                    barChartToolTipController.ShowBeak = True
                Case 2
                    chartBar.ToolTipOptions.ToolTipPosition = toolTipFreePosition
                    barChartToolTipController.ShowBeak = False
            End Select
        End Sub

        Private Sub comboBoxEditTooltipType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            tooltipShowImage = comboBoxEditTooltipType.SelectedIndex = 0
        End Sub

        Private Sub checkEditShowLabel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            CrosshairOptions.ShowCrosshairLabels = checkEditShowLabel.Checked
        End Sub

        Private Sub comboBoxEditShowAxisXValues_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            CrosshairOptions.ShowArgumentLabels = comboBoxEditShowAxisXValues.Checked
        End Sub

        Private Sub comboBoxEditShowAxisYValues_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            CrosshairOptions.ShowValueLabels = comboBoxEditShowAxisYValues.Checked
        End Sub

        Private Sub comboBoxEditShowArgumentLine_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            CrosshairOptions.ShowArgumentLine = comboBOxEditShowArgumentLine.Checked
        End Sub

        Private Sub comboBoxEditShowValueLine_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            CrosshairOptions.ShowValueLine = comboBoxEditShowValueLine.Checked
        End Sub

        Private Sub comboBoxEditShowContentIn_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim isLabelMode As Boolean = comboBoxEditShowContentIn.SelectedIndex = 0
            CrosshairOptions.ContentShowMode = If(isLabelMode, CrosshairContentShowMode.Label, CrosshairContentShowMode.Legend)
            lciShowLabel.Enabled = isLabelMode
            lciLabelMode.Enabled = isLabelMode
            If Not isLabelMode Then comboBoxEditLabelMode.SelectedIndex = 1
        End Sub

        Private Sub comboBoxEditLabelMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If comboBoxEditLabelMode.SelectedIndex = -1 Then Return
            CrosshairOptions.CrosshairLabelMode = If(comboBoxEditLabelMode.SelectedIndex = 0, CrosshairLabelMode.ShowForNearestSeries, CrosshairLabelMode.ShowCommonForAllSeries)
        End Sub

        Private Sub barChart_SelectedItemsChanged(ByVal sender As Object, ByVal e As SelectedItemsChangedEventArgs)
            If e.NewItems Is Nothing OrElse e.NewItems.Count = 0 Then Return
            Dim item As CategorySaleItem = TryCast(e.NewItems(0), CategorySaleItem)
            If item Is Nothing Then Return
            chartSpline.BeginInit()
            chartSpline.DataSource = item.SaleItems
            chartSpline.EndInit()
            UpdateSplineChartColors(item)
            chartSpline.Animate()
        End Sub

        Private Sub barChartToolTipController_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs)
            Dim controller As ToolTipController = TryCast(sender, ToolTipController)
            Dim seriesPoint As SeriesPoint = TryCast(controller.ActiveObject, SeriesPoint)
            If seriesPoint Is Nothing Then Return
            Dim categorySaleItem As CategorySaleItem = TryCast(seriesPoint.Tag, CategorySaleItem)
            If categorySaleItem Is Nothing Then Return
            If tooltipShowImage Then
                e.ToolTipType = ToolTipType.Standard
                e.ToolTipImage = CreateChart(categorySaleItem.SaleItems, categorySaleItem.Category, GetColorFromPaletteByNumber(categorySaleItem.OrderIndex))
                e.ToolTip = ""
            Else
                e.ToolTipType = ToolTipType.SuperTip
                e.SuperTip = Create(categorySaleItem)
            End If
        End Sub

        Private Sub chartBar_ObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs)
            e.Cancel = True
        End Sub

        Private Sub chartBar_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs)
            e.Cancel = Not(TypeOf e.Object Is Series)
        End Sub

        Private Sub OnChartClick(ByVal sender As Object, ByVal e As EventArgs)
            focusedChart = CType(sender, ChartControl)
        End Sub

        Protected Overrides Sub OnPaletteChanged()
            MyBase.OnPaletteChanged()
            If chartBar.SelectedItems.Count > 0 Then UpdateSplineChartColors(CType(chartBar.SelectedItems(0), CategorySaleItem))
        End Sub

        Protected Overrides Sub ScaleControl(ByVal factor As SizeF, ByVal specified As BoundsSpecified)
            MyBase.ScaleControl(factor, specified)
            Dim width As Integer = CInt(Math.Round(DefaultToolTipChartSize.Width * factor.Width))
            Dim height As Integer = CInt(Math.Round(DefaultToolTipChartSize.Height * factor.Height))
            toolTipChartSize = New Size(width, height)
        End Sub
    End Class
End Namespace
