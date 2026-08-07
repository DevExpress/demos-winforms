Namespace DevExpress.XtraCharts.Demos

    Partial Class TimeSpanDataAggregationDemo

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim crosshairFreePosition1 As DevExpress.XtraCharts.CrosshairFreePosition = New DevExpress.XtraCharts.CrosshairFreePosition()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim secondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            crosshairFreePosition1.DockTargetName = "Default Pane"
            Me.chart.CrosshairOptions.CommonLabelPosition = crosshairFreePosition1
            Me.chart.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free
            Me.chart.CrosshairOptions.ShowArgumentLabels = True
            Me.chart.CrosshairOptions.ShowValueLabels = True
            Me.chart.CrosshairOptions.ShowValueLine = True
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = False
            xyDiagram1.AxisX.TimeSpanScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.CrosshairAxisLabelOptions.Pattern = "{V:0}°C"
            xyDiagram1.AxisY.Label.TextPattern = "{V}°C"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisY.WholeRange.EndSideMargin = 0R
            xyDiagram1.AxisY.WholeRange.StartSideMargin = 0R
            xyDiagram1.DependentAxesYRange = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.CrosshairAxisLabelOptions.Pattern = "{V:0}°F"
            secondaryAxisY1.Label.TextPattern = "{V}°F"
            secondaryAxisY1.Name = "Secondary AxisY 1"
            secondaryAxisY1.VisibleInPanesSerializable = "-1"
            secondaryAxisY1.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY1.WholeRange.AutoSideMargins = False
            secondaryAxisY1.WholeRange.EndSideMargin = 0R
            secondaryAxisY1.WholeRange.StartSideMargin = 0R
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {secondaryAxisY1})
            xyDiagram1.ZoomingOptions.AxisXMaxZoomPercent = 100000R
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.TimeSpan
            series1.CrosshairLabelPattern = "{S}: {V:0}°C"
            series1.Name = "CPU Temperature"
            series1.SeriesID = 0
            series1.View = lineSeriesView1
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.TimeSpan
            series2.CrosshairLabelPattern = "{S}: {V:0}°C"
            series2.Name = "GPU Temperature"
            series2.SeriesID = 1
            series2.View = lineSeriesView2
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2}
            Me.chart.Size = New System.Drawing.Size(784, 432)
            Me.chart.TabIndex = 4
            chartTitle1.Text = "Hardware Monitor"
            chartTitle1.TitleID = 0
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.chart.CustomDrawCrosshair, New DevExpress.XtraCharts.CustomDrawCrosshairEventHandler(AddressOf Me.Chart_CustomDrawCrosshair)
            AddHandler Me.chart.AxisVisualRangeChanged, New System.EventHandler(Of DevExpress.XtraCharts.AxisRangeChangedEventArgs)(AddressOf Me.Chart_AxisVisualRangeChanged)
            ' 
            ' TimeSpanDataAggregationDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "TimeSpanDataAggregationDemo"
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
