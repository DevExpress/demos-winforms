Namespace DevExpress.XtraCharts.Demos

    Partial Class DateTimeDataAggregationDemo

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
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            crosshairFreePosition1.DockTargetName = "Default Pane"
            Me.chart.CrosshairOptions.CommonLabelPosition = crosshairFreePosition1
            xyDiagram1.AxisX.DateTimeScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Label.TextPattern = "{V:F2}"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagram1.ZoomingOptions.AxisXMaxZoomPercent = 150000R
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.CrosshairLabelPattern = "{A:d} : {V:F4}"
            series1.Name = "Random Data"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chart.Size = New System.Drawing.Size(784, 432)
            Me.chart.TabIndex = 4
            chartTitle1.Text = "Data Aggregation (50000 points)"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.chart.AxisVisualRangeChanged, New System.EventHandler(Of DevExpress.XtraCharts.AxisRangeChangedEventArgs)(AddressOf Me.chart_AxisVisualRangeChanged)
            ' 
            ' DateTimeDataAggregationDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "DateTimeDataAggregationDemo"
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
