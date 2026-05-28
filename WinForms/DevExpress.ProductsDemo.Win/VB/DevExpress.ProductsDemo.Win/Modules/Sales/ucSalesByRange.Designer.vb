Namespace DevExpress.SalesDemo.Win.Modules
	Partial Public Class ucSalesByRange
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim rangeControlRange1 As New DevExpress.XtraEditors.RangeControlRange()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim doughnutSeriesLabel1 As New DevExpress.XtraCharts.DoughnutSeriesLabel()
			Dim doughnutSeriesView1 As New DevExpress.XtraCharts.DoughnutSeriesView()
			Dim doughnutSeriesLabel2 As New DevExpress.XtraCharts.DoughnutSeriesLabel()
			Dim doughnutSeriesView2 As New DevExpress.XtraCharts.DoughnutSeriesView()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
			Me.rangeControl = New DevExpress.XtraEditors.RangeControl()
			Me.pieChart = New DevExpress.XtraCharts.ChartControl()
			Me.tableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
			Me.barChart = New DevExpress.XtraCharts.ChartControl()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.btnPrev = New DevExpress.XtraEditors.SimpleButton()
			Me.btnNext = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.rangeControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pieChart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(doughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(doughnutSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(doughnutSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(doughnutSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel.SuspendLayout()
			CType(Me.barChart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' rangeControl
			' 
			Me.rangeControl.Client = Me.pieChart
			Me.rangeControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.rangeControl.Location = New System.Drawing.Point(55, 3)
			Me.rangeControl.Name = "rangeControl"
			rangeControlRange1.Maximum = 4.5R
			rangeControlRange1.Minimum = -0.5R
			rangeControlRange1.Owner = Me.rangeControl
			Me.rangeControl.SelectedRange = rangeControlRange1
			Me.rangeControl.SelectionType = DevExpress.XtraEditors.RangeControlSelectionType.Flag
			Me.rangeControl.ShowToolTips = False
			Me.rangeControl.ShowZoomScrollBar = False
			Me.rangeControl.Size = New System.Drawing.Size(815, 99)
			Me.rangeControl.TabIndex = 1
			Me.rangeControl.Text = "rangeControl1"
			Me.rangeControl.VisibleRangeMaximumScaleFactor = 1R
			' 
			' pieChart
			' 
			Me.pieChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.pieChart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pieChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center
			Me.pieChart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.pieChart.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
			Me.pieChart.Legend.EquallySpacedItems = False
			Me.pieChart.Legend.MarkerSize = New System.Drawing.Size(18, 18)
			Me.pieChart.Legend.Name = "Default Legend"
			Me.pieChart.Legend.Padding.Bottom = 10
			Me.pieChart.Legend.Padding.Left = 10
			Me.pieChart.Legend.Padding.Right = 10
			Me.pieChart.Legend.Padding.Top = 10
			Me.pieChart.Legend.TextOffset = 8
			Me.pieChart.Legend.VerticalIndent = 12
			Me.pieChart.Location = New System.Drawing.Point(3, 3)
			Me.pieChart.Name = "pieChart"
			Me.pieChart.Padding.Right = 0
			series1.ArgumentDataMember = "GroupName"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
			doughnutSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			doughnutSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
			doughnutSeriesLabel1.TextPattern = "{VP:P0}"
			series1.Label = doughnutSeriesLabel1
            series1.LabelsVisibility = Utils.DefaultBoolean.True
            series1.LegendTextPattern = "{A}"
			series1.Name = "Series 1"
			series1.ValueDataMembersSerializable = "TotalCost"
			doughnutSeriesView1.HoleRadiusPercent = 45
			series1.View = doughnutSeriesView1
			Me.pieChart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
			doughnutSeriesLabel2.TextPattern = "{VP:G2}"
			Me.pieChart.SeriesTemplate.Label = doughnutSeriesLabel2
			Me.pieChart.SeriesTemplate.SeriesColorizer = Nothing
			Me.pieChart.SeriesTemplate.View = doughnutSeriesView2
			Me.pieChart.Size = New System.Drawing.Size(455, 326)
			Me.pieChart.TabIndex = 2
			' 
			' tableLayoutPanel
			' 
			Me.tableLayoutPanel.ColumnCount = 2
			Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel.Controls.Add(Me.barChart, 1, 0)
			Me.tableLayoutPanel.Controls.Add(Me.pieChart, 0, 0)
			Me.tableLayoutPanel.Controls.Add(Me.tableLayoutPanel1, 0, 1)
			Me.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel.Location = New System.Drawing.Point(0, 0)
			Me.tableLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
			Me.tableLayoutPanel.Name = "tableLayoutPanel"
			Me.tableLayoutPanel.RowCount = 2
			Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F))
			Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F))
			Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
			Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
			Me.tableLayoutPanel.Size = New System.Drawing.Size(922, 443)
			Me.tableLayoutPanel.TabIndex = 1
			' 
			' barChart
			' 
			Me.barChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.barChart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.AxisX.CrosshairAxisLabelOptions.Visibility = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = False
			xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
			xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = False
			xyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.FromArgb((CInt((CByte(64)))), (CInt((CByte(64)))), (CInt((CByte(64)))))
			xyDiagram1.AxisX.Reverse = True
			xyDiagram1.AxisX.Tickmarks.MinorVisible = False
			xyDiagram1.AxisX.Tickmarks.Visible = False
			xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisX.WholeRange.SideMarginsValue = 1R
			xyDiagram1.AxisY.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
			xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowHide = False
			xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowRotate = False
			xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowStagger = False
			xyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.FromArgb((CInt((CByte(64)))), (CInt((CByte(64)))), (CInt((CByte(64)))))
			xyDiagram1.AxisY.Tickmarks.MinorVisible = False
			xyDiagram1.AxisY.Tickmarks.Visible = False
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.Margins.Left = 38
			xyDiagram1.Margins.Right = 2
			xyDiagram1.Rotated = True
			Me.barChart.Diagram = xyDiagram1
			Me.barChart.Dock = System.Windows.Forms.DockStyle.Fill
			Me.barChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
			Me.barChart.Legend.Font = New System.Drawing.Font("Tahoma", 10F)
			Me.barChart.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.None
			Me.barChart.Legend.MarkerSize = New System.Drawing.Size(1, 16)
			Me.barChart.Legend.Name = "Default Legend"
			Me.barChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
			Me.barChart.Location = New System.Drawing.Point(461, 0)
			Me.barChart.Margin = New System.Windows.Forms.Padding(0)
			Me.barChart.Name = "barChart"
			Me.barChart.Padding.Bottom = 24
			Me.barChart.Padding.Left = 0
			Me.barChart.Padding.Right = 0
			Me.barChart.Padding.Top = 24
			series2.ArgumentDataMember = "GroupName"
			sideBySideBarSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			sideBySideBarSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True
			sideBySideBarSeriesLabel1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Empty
			sideBySideBarSeriesLabel1.Indent = 4
			sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.TopInside
			sideBySideBarSeriesLabel1.TextColor = System.Drawing.Color.White
			sideBySideBarSeriesLabel1.TextPattern = "{V:N0}"
			series2.Label = sideBySideBarSeriesLabel1
            series2.LabelsVisibility = Utils.DefaultBoolean.True
            series2.LegendTextPattern = "{V:N1}"
			series2.Name = "Series 1"
			series2.ValueDataMembersSerializable = "TotalCost"
			sideBySideBarSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False
			sideBySideBarSeriesView1.ColorEach = True
			series2.View = sideBySideBarSeriesView1
			Me.barChart.SeriesSerializable = New DevExpress.XtraCharts.Series() { series2}
			Me.barChart.SeriesTemplate.SeriesColorizer = Nothing
			Me.barChart.Size = New System.Drawing.Size(461, 332)
			Me.barChart.TabIndex = 6
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 3
			Me.tableLayoutPanel.SetColumnSpan(Me.tableLayoutPanel1, 2)
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F))
			Me.tableLayoutPanel1.Controls.Add(Me.rangeControl, 1, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.btnPrev, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.btnNext, 2, 0)
			Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 335)
			Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 1
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(922, 105)
			Me.tableLayoutPanel1.TabIndex = 4
			' 
			' btnPrev
			' 
			Me.btnPrev.Dock = System.Windows.Forms.DockStyle.Fill
			Me.btnPrev.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
			Me.btnPrev.ImageOptions.SvgImage = My.Resources.ArrowLeft1
			Me.btnPrev.Location = New System.Drawing.Point(5, 3)
			Me.btnPrev.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
			Me.btnPrev.Name = "btnPrev"
			Me.btnPrev.Size = New System.Drawing.Size(44, 99)
			Me.btnPrev.TabIndex = 2
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
			' 
			' btnNext
			' 
			Me.btnNext.Dock = System.Windows.Forms.DockStyle.Fill
			Me.btnNext.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
			Me.btnNext.ImageOptions.SvgImage = My.Resources.ArrowRight1
			Me.btnNext.Location = New System.Drawing.Point(876, 3)
			Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 3, 2, 3)
			Me.btnNext.Name = "btnNext"
			Me.btnNext.Size = New System.Drawing.Size(44, 99)
			Me.btnNext.TabIndex = 3
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			' 
			' ucSalesByRange
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.tableLayoutPanel)
			Me.Name = "ucSalesByRange"
			Me.Size = New System.Drawing.Size(922, 443)
			CType(Me.rangeControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(doughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(doughnutSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(doughnutSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(doughnutSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pieChart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barChart, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tableLayoutPanel As System.Windows.Forms.TableLayoutPanel
		Private pieChart As XtraCharts.ChartControl
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private rangeControl As XtraEditors.RangeControl
		Private barChart As XtraCharts.ChartControl
		Private WithEvents btnNext As XtraEditors.SimpleButton
		Private WithEvents btnPrev As XtraEditors.SimpleButton
	End Class
End Namespace
