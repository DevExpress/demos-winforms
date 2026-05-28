Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Utils

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class LegendsDemo
        Inherits ChartDemoModuleWithOptions

        Private ReadOnly Property MemoryLegend As Legend
            Get
                Return If(chart.Legends.Count > 0, chart.Legends(0), Nothing)
            End Get
        End Property

        Private ReadOnly Property CpuLegend As Legend
            Get
                Return If(chart.Legends.Count > 1, chart.Legends(1), Nothing)
            End Get
        End Property

        Private ReadOnly Property CustomLegend As Legend
            Get
                Return If(chart.Legends.Count > 2, chart.Legends(2), Nothing)
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
            ChartControl.DataSource = New PerformanceDataSource()
            layoutControlGroupMarkerMode.Spacing = XtraLayout.Utils.Padding.Empty
            layoutControlGroupLegendMode.Spacing = layoutControlGroupMarkerMode.Spacing
            layoutControlGroupRoot.Spacing = layoutControlGroupLegendMode.Spacing
            radioGroupMarkerMode.SelectedIndex = CInt(chart.Legend.MarkerMode)
            UpdateChartColors()
            ChartControl.EndInit()
        End Sub

        Private Function FindCpuSeries() As List(Of Series)
            Dim cpuSeries As List(Of Series) = New List(Of Series)()
            For Each series As Series In ChartControl.Series
                If Equals(CStr(series.Tag), "CPU") Then cpuSeries.Add(series)
            Next

            Return cpuSeries
        End Function

        Private Function FindMemorySeries() As List(Of Series)
            Dim cpuSeries As List(Of Series) = New List(Of Series)()
            For Each series As Series In ChartControl.Series
                If Equals(CStr(series.Tag), "Memory") Then cpuSeries.Add(series)
            Next

            Return cpuSeries
        End Function

        Private Sub AssignLegendSeriesAndAlignment(ByVal cpuSeries As List(Of Series), ByVal legend As Legend, ByVal alignment As LegendAlignmentHorizontal)
            chart.Legend.Visibility = DefaultBoolean.False
            If CustomLegend IsNot Nothing Then CustomLegend.Visibility = DefaultBoolean.False
            If legend Is Nothing Then Return
            legend.AlignmentHorizontal = alignment
            For Each series As Series In cpuSeries
                series.Legend = legend
                series.LegendTextPattern = String.Empty
            Next
        End Sub

        Private Sub ResetSeparatedLegends(ByVal useCustomLegend As Boolean)
            Dim cpuSeries As List(Of Series) = FindCpuSeries()
            For Each series As Series In chart.Series
                series.Legend = Nothing
                series.LegendTextPattern = If(cpuSeries.Contains(series), "{S} CPU Usage", "{S} Memory Utilization")
            Next

            chart.Legend.Visibility = If(useCustomLegend, DefaultBoolean.False, DefaultBoolean.True)
            If CustomLegend IsNot Nothing Then CustomLegend.Visibility = If(useCustomLegend, DefaultBoolean.True, DefaultBoolean.False)
        End Sub

        Private Sub UpdateChartColors()
            Dim memorySeries As List(Of Series) = FindMemorySeries()
            Dim paletteEntries As PaletteEntry() = ChartControl.GetPaletteEntries(3)
            For i As Integer = 0 To memorySeries.Count - 1
                memorySeries(i).View.Color = Color.FromArgb(135, paletteEntries(i).Color)
            Next

            If CustomLegend Is Nothing Then Return
            For i As Integer = 0 To CustomLegend.CustomItems.Count - 1
                CustomLegend.CustomItems(i).MarkerColor = paletteEntries(i).Color
            Next
        End Sub

        Private Sub radioGroupMarkerMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim markerMode As LegendMarkerMode = CType(radioGroupMarkerMode.EditValue, LegendMarkerMode)
            ChartControl.Legend.MarkerMode = markerMode
            If CpuLegend IsNot Nothing Then CpuLegend.MarkerMode = markerMode
            If MemoryLegend IsNot Nothing Then MemoryLegend.MarkerMode = markerMode
        End Sub

        Private Sub radioGroupLegendMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim cpuSeries As List(Of Series) = FindCpuSeries()
            Dim memorySeries As List(Of Series) = FindMemorySeries()
            Dim legendMode As LegendMode = CType(radioGroupLegendMode.EditValue, LegendMode)
            Select Case legendMode
                Case LegendMode.Common
                    ResetSeparatedLegends(False)
                Case LegendMode.SeparateInsidePane
                    AssignLegendSeriesAndAlignment(cpuSeries, CpuLegend, LegendAlignmentHorizontal.Left)
                    AssignLegendSeriesAndAlignment(memorySeries, MemoryLegend, LegendAlignmentHorizontal.Left)
                Case LegendMode.SeparateOutsidePane
                    AssignLegendSeriesAndAlignment(cpuSeries, CpuLegend, LegendAlignmentHorizontal.RightOutside)
                    AssignLegendSeriesAndAlignment(memorySeries, MemoryLegend, LegendAlignmentHorizontal.RightOutside)
                Case LegendMode.CommonCustomItems
                    ResetSeparatedLegends(True)
            End Select

            UpdateControls(legendMode)
        End Sub

        Private Sub UpdateControls(ByVal legendMode As LegendMode)
            Dim optionEnable As Boolean = Not legendMode.Equals(LegendMode.CommonCustomItems)
            radioGroupCrosshairContentMode.Enabled = optionEnable
            radioGroupMarkerMode.Enabled = optionEnable
        End Sub

        Private Sub radioGroupCrosshairContentMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim mode As CrosshairContentShowMode = CType(radioGroupCrosshairContentMode.EditValue, CrosshairContentShowMode)
            ChartControl.CrosshairOptions.ContentShowMode = mode
        End Sub

        Protected Overrides Sub OnPaletteChanged()
            MyBase.OnPaletteChanged()
            UpdateChartColors()
        End Sub

        Protected Friend Overrides Sub OnChartDesignerClosed()
            UpdateChartColors()
        End Sub
    End Class

    Friend Enum LegendMode
        Common
        SeparateInsidePane
        SeparateOutsidePane
        CommonCustomItems
    End Enum
End Namespace
