Namespace DevExpress.XtraCharts.Demos

    Partial Class RangeControlIntegrationDemo

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
            Dim rangeControlRange1 As DevExpress.XtraEditors.RangeControlRange = New DevExpress.XtraEditors.RangeControlRange()
            Dim crosshairFreePosition1 As DevExpress.XtraCharts.CrosshairFreePosition = New DevExpress.XtraCharts.CrosshairFreePosition()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim lineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.rangeControl = New DevExpress.XtraEditors.RangeControl()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
            CType((Me.rangeControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitContainer1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' rangeControl
            ' 
            Me.rangeControl.Client = Me.chart
            Me.rangeControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rangeControl.Location = New System.Drawing.Point(0, 0)
            Me.rangeControl.Name = "rangeControl"
            rangeControlRange1.Maximum = New System.DateTime(2018, 5, 13, 1, 0, 0, 0)
            rangeControlRange1.Minimum = New System.DateTime(2018, 5, 3, 23, 0, 0, 0)
            rangeControlRange1.Owner = Me.rangeControl
            Me.rangeControl.SelectedRange = rangeControlRange1
            Me.rangeControl.Size = New System.Drawing.Size(784, 85)
            Me.rangeControl.TabIndex = 4
            Me.rangeControl.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((64)))))), (CInt(((CByte((64)))))))
            crosshairFreePosition1.DockTargetName = "Default Pane"
            Me.chart.CrosshairOptions.CommonLabelPosition = crosshairFreePosition1
            Me.chart.CrosshairOptions.GroupHeaderPattern = "<b>{A:d}</b>"
            Me.chart.CrosshairOptions.ShowArgumentLabels = True
            Me.chart.CrosshairOptions.ShowValueLabels = True
            Me.chart.CrosshairOptions.ShowValueLine = True
            Me.chart.CrosshairOptions.ValueLineColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((64)))))), (CInt(((CByte((64)))))))
            xyDiagram1.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.VisualRange.Auto = False
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "05/13/2018 01:00:00.000"
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "05/03/2018 23:00:00.000"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 1R
            xyDiagram1.AxisY.Label.TextPattern = "{V:F2}"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.DependentAxesYRange = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagram1.RangeControlDateTimeGridOptions.SnapAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year
            xyDiagram1.RangeControlDateTimeGridOptions.SnapMode = DevExpress.XtraCharts.ChartRangeControlClientSnapMode.Manual
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            series1.ArgumentDataMember = "DateTimeStamp"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.CrosshairLabelPattern = "<b>GBP : {V:F4}</b>"
            series1.Name = "GBPUSD"
            series1.ValueDataMembersSerializable = "Close"
            series1.View = lineSeriesView1
            series2.ArgumentDataMember = "DateTimeStamp"
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series2.CrosshairLabelPattern = "<b>EUR : {V:F4}</b>"
            series2.Name = "EURUSD"
            series2.ValueDataMembersSerializable = "Close"
            series2.View = lineSeriesView2
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2}
            Me.chart.SeriesTemplate.View = lineSeriesView3
            Me.chart.Size = New System.Drawing.Size(784, 343)
            Me.chart.TabIndex = 3
            chartTitle1.Text = "Currency Exchange Rates"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.chart.CustomDrawCrosshair, New DevExpress.XtraCharts.CustomDrawCrosshairEventHandler(AddressOf Me.chart_CustomDrawCrosshair)
            ' 
            ' splitContainer1
            ' 
            Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainer1.Name = "splitContainer1"
            Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
            ' 
            ' splitContainer1.Panel1
            ' 
            Me.splitContainer1.Panel1.Controls.Add(Me.chart)
            ' 
            ' splitContainer1.Panel2
            ' 
            Me.splitContainer1.Panel2.Controls.Add(Me.rangeControl)
            Me.splitContainer1.Size = New System.Drawing.Size(784, 432)
            Me.splitContainer1.SplitterDistance = 343
            Me.splitContainer1.TabIndex = 4
            ' 
            ' RangeControlIntegrationDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainer1)
            Me.Name = "RangeControlIntegrationDemo"
            CType((Me.rangeControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel2.ResumeLayout(False)
            CType((Me.splitContainer1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl

        Private splitContainer1 As System.Windows.Forms.SplitContainer

        Private rangeControl As DevExpress.XtraEditors.RangeControl
    End Class
End Namespace
