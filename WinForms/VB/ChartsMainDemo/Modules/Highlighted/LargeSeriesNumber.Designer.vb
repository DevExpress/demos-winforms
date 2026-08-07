Namespace DevExpress.XtraCharts.Demos

    Partial Class LargeSeriesNumberDemo

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
            Dim customAxisLabel1 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel2 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel3 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel4 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel5 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel6 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel7 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel8 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel9 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel10 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel11 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim customAxisLabel12 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim seriesTemplateAdapter1 As DevExpress.XtraCharts.SeriesTemplateAdapter = New DevExpress.XtraCharts.SeriesTemplateAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember3 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.CrosshairLabelMode = DevExpress.XtraCharts.CrosshairLabelMode.ShowForNearestSeries
            Me.chart.CrosshairOptions.ShowArgumentLabels = True
            customAxisLabel1.AxisValueSerializable = "1"
            customAxisLabel1.Name = "January"
            customAxisLabel2.AxisValueSerializable = "31"
            customAxisLabel2.Name = "February"
            customAxisLabel3.AxisValueSerializable = "59"
            customAxisLabel3.Name = "March"
            customAxisLabel4.AxisValueSerializable = "90"
            customAxisLabel4.Name = "April"
            customAxisLabel5.AxisValueSerializable = "120"
            customAxisLabel5.Name = "May"
            customAxisLabel6.AxisValueSerializable = "151"
            customAxisLabel6.Name = "June"
            customAxisLabel7.AxisValueSerializable = "181"
            customAxisLabel7.Name = "July"
            customAxisLabel8.AxisValueSerializable = "212"
            customAxisLabel8.Name = "August"
            customAxisLabel9.AxisValueSerializable = "243"
            customAxisLabel9.Name = "September"
            customAxisLabel10.AxisValueSerializable = "273"
            customAxisLabel10.Name = "October"
            customAxisLabel11.AxisValueSerializable = "303"
            customAxisLabel11.Name = "November"
            customAxisLabel12.AxisValueSerializable = "334"
            customAxisLabel12.Name = "December"
            xyDiagram1.AxisX.CustomLabels.AddRange(New DevExpress.XtraCharts.CustomAxisLabel() {customAxisLabel1, customAxisLabel2, customAxisLabel3, customAxisLabel4, customAxisLabel5, customAxisLabel6, customAxisLabel7, customAxisLabel8, customAxisLabel9, customAxisLabel10, customAxisLabel11, customAxisLabel12})
            xyDiagram1.AxisX.Label.TextPattern = "Day {A:0.}"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisX.WholeRange.Auto = False
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0R
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "367"
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "0"
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0R
            xyDiagram1.AxisY.Title.Text = "Sea Ice Area, Millions km²"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagram1.EnableAxisYScrolling = True
            xyDiagram1.EnableAxisYZooming = True
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
            Me.chart.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBox
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chart.SeriesTemplate.CrosshairLabelPattern = "{S}<br/>Day {A:0.}: {V:0.000M km²}"
            dataMember1.ColumnName = "DayOfYear"
            dataMember2.ColumnName = "IceArea"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataMember3.ColumnName = "Year"
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series
            seriesTemplateAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2, dataMember3})
            Me.chart.SeriesTemplate.DataAdapter = seriesTemplateAdapter1
            lineSeriesView1.LineStyle.DXLineJoin = DevExpress.Drawing.DXLineJoin.Round
            Me.chart.SeriesTemplate.View = lineSeriesView1
            Me.chart.Size = New System.Drawing.Size(784, 432)
            Me.chart.TabIndex = 0
            chartTitle1.Text = "Global Sea Ice Area"
            chartTitle1.TitleID = 0
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle2.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            chartTitle2.Text = "From NSIDC NASA Team sea ice concentration data"
            chartTitle2.TextColor = System.Drawing.Color.Gray
            chartTitle2.TitleID = 1
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            AddHandler Me.chart.BoundDataChanged, New DevExpress.XtraCharts.BoundDataChangedEventHandler(AddressOf Me.ChartControl_BoundDataChanged)
            AddHandler Me.chart.LegendItemChecked, New DevExpress.XtraCharts.LegendItemCheckedEventHandler(AddressOf Me.ChartControl_LegendItemChecked)
            ' 
            ' LargeSeriesNumberDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "LargeSeriesNumberDemo"
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
