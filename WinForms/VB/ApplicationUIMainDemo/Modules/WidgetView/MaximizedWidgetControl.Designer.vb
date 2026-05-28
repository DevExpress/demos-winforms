Namespace DevExpress.ApplicationUI.Demos

    Partial Class MaximizedWidgetControl

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        Private Sub InitializeComponent()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim candleStickSeriesView1 As DevExpress.XtraCharts.CandleStickSeriesView = New DevExpress.XtraCharts.CandleStickSeriesView()
            Dim candleStickSeriesView2 As DevExpress.XtraCharts.CandleStickSeriesView = New DevExpress.XtraCharts.CandleStickSeriesView()
            Dim xyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.chartControl2 = New DevExpress.XtraCharts.ChartControl()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((candleStickSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((candleStickSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chartControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.Color = System.Drawing.Color.White
            xyDiagram1.AxisX.NumericScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PaletteName = "Apex"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.Name = "Series 1"
            series1.SeriesID = 0
            candleStickSeriesView1.Color = System.Drawing.Color.FromArgb((CInt(((CByte((70)))))), (CInt(((CByte((104)))))), (CInt(((CByte((165)))))))
            candleStickSeriesView1.ReductionOptions.Color = System.Drawing.Color.FromArgb((CInt(((CByte((165)))))), (CInt(((CByte((70)))))), (CInt(((CByte((113)))))))
            series1.View = candleStickSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chartControl1.SeriesTemplate.View = candleStickSeriesView2
            Me.chartControl1.Size = New System.Drawing.Size(447, 180)
            Me.chartControl1.TabIndex = 1
            ' 
            ' chartControl2
            ' 
            Me.chartControl2.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl2.Diagram = xyDiagram2
            Me.chartControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.chartControl2.Location = New System.Drawing.Point(0, 180)
            Me.chartControl2.Name = "chartControl2"
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series2.Name = "Series 1"
            series2.SeriesID = 0
            sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb((CInt(((CByte((88)))))), (CInt(((CByte((72)))))), (CInt(((CByte((165)))))))
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
            series2.View = sideBySideBarSeriesView1
            series3.Name = "Series 2"
            series3.SeriesID = 1
            Me.chartControl2.SeriesSerializable = New DevExpress.XtraCharts.Series() {series2, series3}
            Me.chartControl2.Size = New System.Drawing.Size(447, 140)
            Me.chartControl2.TabIndex = 2
            ' 
            ' MaximizedWidgetControl
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.chartControl2)
            Me.Name = "MaximizedWidgetControl"
            Me.Size = New System.Drawing.Size(447, 320)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((candleStickSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((candleStickSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private chartControl2 As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
