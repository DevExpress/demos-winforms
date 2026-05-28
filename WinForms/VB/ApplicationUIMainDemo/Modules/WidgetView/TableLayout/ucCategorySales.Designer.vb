Namespace DevExpress.ApplicationUI.Demos

    Partial Class ucCategorySales

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
            Dim pieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
            Dim pieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
            Dim pieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.totalSalesItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.totalSalesItemBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl1.DataSource = Me.totalSalesItemBindingSource
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.EquallySpacedItems = False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.ArgumentDataMember = "Category"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            pieSeriesLabel1.ColumnIndent = 6
            pieSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
            pieSeriesLabel1.TextPattern = "{A}"
            series1.Label = pieSeriesLabel1
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series1.Name = "Series 1"
            series1.QualitativeSummaryOptions.SummaryFunction = "SUM([RevenueYTD])"
            series1.SeriesID = 0
            series1.View = pieSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Category"
            Me.chartControl1.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            pieSeriesLabel2.TextPattern = "{VP:G}"
            Me.chartControl1.SeriesTemplate.Label = pieSeriesLabel2
            Me.chartControl1.SeriesTemplate.QualitativeSummaryOptions.SummaryFunction = "SUM([RevenueYTD])"
            Me.chartControl1.SeriesTemplate.TopNOptions.Enabled = True
            Me.chartControl1.SeriesTemplate.View = pieSeriesView2
            Me.chartControl1.Size = New System.Drawing.Size(690, 341)
            Me.chartControl1.TabIndex = 0
            chartTitle1.Text = "Revenue"
            chartTitle1.TextColor = System.Drawing.Color.FromArgb((CInt(((CByte((60)))))), (CInt(((CByte((147)))))), (CInt(((CByte((211)))))))
            chartTitle1.TitleID = 0
            Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' totalSalesItemBindingSource
            ' 
            Me.totalSalesItemBindingSource.DataSource = GetType(DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem)
            ' 
            ' ucCategorySales
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "ucCategorySales"
            Me.Size = New System.Drawing.Size(690, 341)
            CType((pieSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.totalSalesItemBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private totalSalesItemBindingSource As System.Windows.Forms.BindingSource
    End Class
End Namespace
