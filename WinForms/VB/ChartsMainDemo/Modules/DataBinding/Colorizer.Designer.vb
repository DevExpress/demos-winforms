Namespace DevExpress.XtraCharts.Demos

    Partial Class ColorizerDemo

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
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter1 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember3 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember4 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember5 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim bubbleSeriesLabel1 As DevExpress.XtraCharts.BubbleSeriesLabel = New DevExpress.XtraCharts.BubbleSeriesLabel()
            Dim bubbleSeriesView1 As DevExpress.XtraCharts.BubbleSeriesView = New DevExpress.XtraCharts.BubbleSeriesView()
            Dim xyMarkerSlideAnimation1 As DevExpress.XtraCharts.XYMarkerSlideAnimation = New DevExpress.XtraCharts.XYMarkerSlideAnimation()
            Dim elasticEasingFunction1 As DevExpress.XtraCharts.ElasticEasingFunction = New DevExpress.XtraCharts.ElasticEasingFunction()
            Dim bubbleSeriesView2 As DevExpress.XtraCharts.BubbleSeriesView = New DevExpress.XtraCharts.BubbleSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bubbleSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bubbleSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bubbleSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.QualitativeScaleOptions.AutoGrid = False
            xyDiagram1.AxisX.Tickmarks.MinorVisible = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0.7R
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0.7R
            xyDiagram1.AxisY.LabelPosition = DevExpress.XtraCharts.AxisLabelPosition.Inside
            xyDiagram1.AxisY.NumericScaleOptions.AutoGrid = False
            xyDiagram1.AxisY.NumericScaleOptions.GridAlignment = DevExpress.XtraCharts.NumericGridAlignment.Thousands
            xyDiagram1.AxisY.NumericScaleOptions.GridSpacing = 10R
            xyDiagram1.AxisY.Tickmarks.MinorVisible = False
            xyDiagram1.AxisY.Tickmarks.Visible = False
            xyDiagram1.AxisY.Title.Text = "GDP per capita, $"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.PaletteRepository.Add("ColorizerPalette", New DevExpress.XtraCharts.Palette("ColorizerPalette", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((90)))))), (CInt(((CByte((25))))))), System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((90)))))), (CInt(((CByte((25)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((254)))))), (CInt(((CByte((173)))))), (CInt(((CByte((45))))))), System.Drawing.Color.FromArgb((CInt(((CByte((254)))))), (CInt(((CByte((173)))))), (CInt(((CByte((45)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((227)))))), (CInt(((CByte((53))))))), System.Drawing.Color.FromArgb((CInt(((CByte((229)))))), (CInt(((CByte((227)))))), (CInt(((CByte((53)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((172)))))), (CInt(((CByte((228)))))), (CInt(((CByte((92))))))), System.Drawing.Color.FromArgb((CInt(((CByte((172)))))), (CInt(((CByte((228)))))), (CInt(((CByte((92)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((110)))))), (CInt(((CByte((201)))))), (CInt(((CByte((92))))))), System.Drawing.Color.FromArgb((CInt(((CByte((110)))))), (CInt(((CByte((201)))))), (CInt(((CByte((92))))))))}))
            dataMember1.ColumnName = "Country"
            dataMember2.ColumnName = "Product"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataMember3.ColumnName = "Population"
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Weight
            dataMember4.ColumnName = "HPI"
            dataMember4.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Color
            dataMember5.ColumnName = "HPI"
            dataMember5.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.ToolTipHint
            dataSourceAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2, dataMember3, dataMember4, dataMember5})
            series1.DataAdapter = dataSourceAdapter1
            bubbleSeriesLabel1.TextPattern = "{W:0,,.00} M"
            series1.Label = bubbleSeriesLabel1
            series1.Name = "Series 1"
            series1.ToolTipPointPattern = "{A}" & Global.Microsoft.VisualBasic.Constants.vbLf & "GDP per capita: {V:0.00}$" & Global.Microsoft.VisualBasic.Constants.vbLf & "Population: {W:0,,.00} M" & Global.Microsoft.VisualBasic.Constants.vbLf & "HPI: {HINT}"
            bubbleSeriesView1.MaxSize = 1.4R
            bubbleSeriesView1.MinSize = 0.6R
            xyMarkerSlideAnimation1.Direction = DevExpress.XtraCharts.XYMarkerSlideAnimationDirection.FromLeftTopCorner
            xyMarkerSlideAnimation1.Duration = System.TimeSpan.Parse("00:00:01.5000000")
            elasticEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out
            xyMarkerSlideAnimation1.EasingFunction = elasticEasingFunction1
            xyMarkerSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
            xyMarkerSlideAnimation1.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random
            bubbleSeriesView1.SeriesPointAnimation = xyMarkerSlideAnimation1
            bubbleSeriesView1.Transparency =(CByte((90)))
            series1.View = bubbleSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chart.SeriesTemplate.View = bubbleSeriesView2
            Me.chart.Size = New System.Drawing.Size(784, 432)
            Me.chart.TabIndex = 2
            chartTitle1.Text = "Happy Planet Index for G20"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            Me.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' ColorizerDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "ColorizerDemo"
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bubbleSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bubbleSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bubbleSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
