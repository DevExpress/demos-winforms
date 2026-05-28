Namespace DevExpress.XtraCharts.Demos

    Partial Class LogarithmicScaleDemo

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
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim legend1 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView4 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.GroupHeaderPattern = "{A:0.####} Hz"
            Me.chart.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free
            Me.chart.CrosshairOptions.ShowArgumentLabels = True
            Me.chart.CrosshairOptions.ShowValueLabels = True
            Me.chart.CrosshairOptions.ShowValueLine = True
            xyDiagram1.AxisX.GridLines.MinorVisible = True
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.Label.TextPattern = "{A:0.####} Hz"
            xyDiagram1.AxisX.Logarithmic = True
            xyDiagram1.AxisX.MinorCount = 9
            xyDiagram1.AxisX.Title.Text = "Frequency"
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0R
            xyDiagram1.AxisY.CrosshairAxisLabelOptions.Pattern = "{V:0.##}%"
            xyDiagram1.AxisY.GridLines.MinorVisible = True
            xyDiagram1.AxisY.Label.TextPattern = " {V:0.##}%"
            xyDiagram1.AxisY.Logarithmic = True
            xyDiagram1.AxisY.MinorCount = 9
            xyDiagram1.AxisY.Title.Text = "Total Harmonic Distortion "
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.AxisY.WholeRange.Auto = False
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "100"
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0.01"
            xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.chart.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Legend.Margins.Bottom = 0
            Me.chart.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBox
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Padding.Bottom = 2
            Me.chart.Legend.Padding.Left = 2
            Me.chart.Legend.Padding.Right = 2
            Me.chart.Legend.Padding.Top = 2
            legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            legend1.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            legend1.BackColor = System.Drawing.Color.Transparent
            legend1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            legend1.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            legend1.Margins.Top = 0
            legend1.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBox
            legend1.Name = "Legend1"
            legend1.Padding.Bottom = 2
            legend1.Padding.Left = 2
            legend1.Padding.Right = 2
            legend1.Padding.Top = 2
            legend1.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chart.Legends.AddRange(New DevExpress.XtraCharts.Legend() {legend1})
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            series1.CrosshairLabelPattern = "{S}: {V:0.##}%"
            series1.Name = "Headphones 1 90 dB SPL"
            lineSeriesView1.LineMarkerOptions.Size = 5
            lineSeriesView1.LineStyle.Thickness = 3
            series1.View = lineSeriesView1
            series2.CrosshairLabelPattern = "{S}: {V:0.##}%"
            series2.Name = "Headphones 1 100 dB SPL"
            lineSeriesView2.LineMarkerOptions.Size = 5
            lineSeriesView2.LineStyle.Thickness = 3
            series2.View = lineSeriesView2
            series3.CrosshairLabelPattern = "{S}: {V:0.##}%"
            series3.LegendName = "Legend1"
            series3.Name = "Headphones 2 90 dB SPL"
            lineSeriesView3.LineMarkerOptions.Size = 5
            lineSeriesView3.LineStyle.Thickness = 3
            series3.View = lineSeriesView3
            series4.CrosshairLabelPattern = "{S}: {V:0.##}%"
            series4.LegendName = "Legend1"
            series4.Name = "Headphones 2 100 dB SPL"
            lineSeriesView4.LineMarkerOptions.Size = 5
            lineSeriesView4.LineStyle.Thickness = 3
            series4.View = lineSeriesView4
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2, series3, series4}
            Me.chart.Size = New System.Drawing.Size(784, 432)
            Me.chart.TabIndex = 0
            chartTitle1.Text = "Headphones comparison"
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
            chartTitle2.Text = "Unwanted harmonics"
            chartTitle2.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            ' 
            ' LogarithmicScaleDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "LogarithmicScaleDemo"
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
