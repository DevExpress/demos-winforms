Namespace DevExpress.XtraTreeMap.Demos

    Partial Class HeatmapSelection

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
            Me.components = New System.ComponentModel.Container()
            Dim heatmapRangeColorProvider1 As DevExpress.XtraCharts.Heatmap.HeatmapRangeColorProvider = New DevExpress.XtraCharts.Heatmap.HeatmapRangeColorProvider()
            Dim heatmapRangeStop1 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop2 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop3 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop4 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop5 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop6 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop7 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop8 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop9 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop10 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapRangeStop11 As DevExpress.XtraCharts.Heatmap.HeatmapRangeStop = New DevExpress.XtraCharts.Heatmap.HeatmapRangeStop()
            Dim heatmapDataSourceAdapter1 As DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter = New DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter()
            Dim heatmapTitle1 As DevExpress.XtraCharts.Heatmap.HeatmapTitle = New DevExpress.XtraCharts.Heatmap.HeatmapTitle()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim stackedBarSeriesView1 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.heatmapControl1 = New DevExpress.XtraCharts.Heatmap.HeatmapControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanel3 = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanel1.SuspendLayout()
            Me.sidePanel3.SuspendLayout()
            Me.sidePanel2.SuspendLayout()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' heatmapControl1
            ' 
            Me.heatmapControl1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            heatmapRangeColorProvider1.PaletteName = "Palette 1"
            heatmapRangeStop1.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage
            heatmapRangeStop1.Value = 0R
            heatmapRangeStop2.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage
            heatmapRangeStop2.Value = 0.1R
            heatmapRangeStop3.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage
            heatmapRangeStop3.Value = 0.2R
            heatmapRangeStop4.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage
            heatmapRangeStop4.Value = 0.3R
            heatmapRangeStop5.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage
            heatmapRangeStop5.Value = 0.4R
            heatmapRangeStop6.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage
            heatmapRangeStop6.Value = 0.5R
            heatmapRangeStop7.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage
            heatmapRangeStop7.Value = 0.6R
            heatmapRangeStop8.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage
            heatmapRangeStop8.Value = 0.7R
            heatmapRangeStop9.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage
            heatmapRangeStop9.Value = 0.8R
            heatmapRangeStop10.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage
            heatmapRangeStop10.Value = 0.9R
            heatmapRangeStop11.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage
            heatmapRangeStop11.Value = 1R
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop1)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop2)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop3)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop4)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop5)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop6)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop7)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop8)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop9)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop10)
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop11)
            Me.heatmapControl1.ColorProvider = heatmapRangeColorProvider1
            heatmapDataSourceAdapter1.ColorDataMember = "RevenueByMonth"
            heatmapDataSourceAdapter1.XArgumentDataMember = "Month"
            heatmapDataSourceAdapter1.YArgumentDataMember = "Product"
            Me.heatmapControl1.DataAdapter = heatmapDataSourceAdapter1
            Me.heatmapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.heatmapControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.heatmapControl1.Location = New System.Drawing.Point(0, 0)
            Me.heatmapControl1.Name = "heatmapControl1"
            Me.heatmapControl1.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((170)))))), (CInt(((CByte((222)))))), (CInt(((CByte((122))))))), System.Drawing.Color.FromArgb((CInt(((CByte((170)))))), (CInt(((CByte((222)))))), (CInt(((CByte((122)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((114)))))), (CInt(((CByte((207))))))), System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((114)))))), (CInt(((CByte((207))))))))}))
            Me.heatmapControl1.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Multiple
            Me.heatmapControl1.Size = New System.Drawing.Size(500, 243)
            Me.heatmapControl1.TabIndex = 0
            Me.heatmapControl1.Text = "heatmapControl1"
            heatmapTitle1.Alignment = System.Drawing.StringAlignment.Near
            heatmapTitle1.Text = "Sales by Month, $K"
            Me.heatmapControl1.Titles.Add(heatmapTitle1)
            Me.heatmapControl1.ToolTipController = Me.toolTipController1
            Me.heatmapControl1.ToolTipEnabled = True
            Me.heatmapControl1.ToolTipTextPattern = "Month: {X}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Product: {Y}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Revenue: $ {V}K"
            AddHandler Me.heatmapControl1.SelectedItemsChanged, New DevExpress.XtraCharts.SelectedItemsChangedEventHandler(AddressOf Me.heatmapControl1_SelectedItemsChanged)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.sidePanel3)
            Me.sidePanel1.Controls.Add(Me.sidePanel2)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(500, 500)
            Me.sidePanel1.TabIndex = 1
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' sidePanel3
            ' 
            Me.sidePanel3.Controls.Add(Me.heatmapControl1)
            Me.sidePanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel3.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel3.Name = "sidePanel3"
            Me.sidePanel3.Size = New System.Drawing.Size(500, 243)
            Me.sidePanel3.TabIndex = 1
            Me.sidePanel3.Text = "sidePanel3"
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.Controls.Add(Me.chartControl1)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.sidePanel2.Location = New System.Drawing.Point(0, 243)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(500, 257)
            Me.sidePanel2.TabIndex = 0
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Location = New System.Drawing.Point(0, 1)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.SeriesDataMember = "Product"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Date"
            Me.chartControl1.SeriesTemplate.CrosshairLabelPattern = "{S}: $ {V}K"
            Me.chartControl1.SeriesTemplate.SeriesDataMember = "Product"
            Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Revenue"
            Me.chartControl1.SeriesTemplate.View = stackedBarSeriesView1
            Me.chartControl1.Size = New System.Drawing.Size(500, 256)
            Me.chartControl1.TabIndex = 0
            chartTitle1.Alignment = System.Drawing.StringAlignment.Near
            chartTitle1.Text = "Product Sales by Day, $K"
            Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' HeatmapSelection
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "HeatmapSelection"
            Me.sidePanel1.ResumeLayout(False)
            Me.sidePanel3.ResumeLayout(False)
            Me.sidePanel2.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private heatmapControl1 As DevExpress.XtraCharts.Heatmap.HeatmapControl

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private sidePanel3 As DevExpress.XtraEditors.SidePanel

        Private toolTipController1 As DevExpress.Utils.ToolTipController
    End Class
End Namespace
