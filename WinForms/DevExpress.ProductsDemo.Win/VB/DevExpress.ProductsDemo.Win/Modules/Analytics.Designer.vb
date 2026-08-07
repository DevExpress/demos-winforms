Imports DevExpress.SalesDemo.Win.Modules
Namespace DevExpress.ProductsDemo.Win.Modules
	Partial Public Class AnalyticsModule
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
            Dim ArcScaleRange1 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
            Dim ArcScaleRange2 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
            Dim ArcScaleRange3 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
            Dim LinearScaleRange1 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim LinearScaleRange2 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim LinearScaleRange3 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim ArcScaleRange4 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
            Dim ArcScaleRange5 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
            Dim ArcScaleRange6 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
            Dim ArcScaleRange7 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
            Dim ArcScaleRange8 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
            Dim ArcScaleRange9 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim DoughnutSeriesLabel1 As DevExpress.XtraCharts.DoughnutSeriesLabel = New DevExpress.XtraCharts.DoughnutSeriesLabel()
            Dim DoughnutSeriesView1 As DevExpress.XtraCharts.DoughnutSeriesView = New DevExpress.XtraCharts.DoughnutSeriesView()
            Dim DoughnutSeriesLabel2 As DevExpress.XtraCharts.DoughnutSeriesLabel = New DevExpress.XtraCharts.DoughnutSeriesLabel()
            Dim DoughnutSeriesView2 As DevExpress.XtraCharts.DoughnutSeriesView = New DevExpress.XtraCharts.DoughnutSeriesView()
            Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.labelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.tableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.monthlySalesPerformance = New DevExpress.SalesDemo.Win.Modules.ucSalesPerformance()
            Me.tableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.dailySalesPerformance = New DevExpress.SalesDemo.Win.Modules.ucSalesPerformance()
            Me.tableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleRangeBarForecast = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent()
            Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.tableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge2 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScalePrevYear = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.needleFiscalYear = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.gaugeControl3 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge3 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleFiscalToData = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.needleFiscalToData = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.labelFiscalToData = New System.Windows.Forms.Label()
            Me.labelFiscalYear = New System.Windows.Forms.Label()
            Me.fiscalToData = New System.Windows.Forms.Label()
            Me.fiscalYear = New System.Windows.Forms.Label()
            Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.chartSalesbySecor = New DevExpress.XtraCharts.ChartControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.tableLayoutPanel4.SuspendLayout()
            Me.tableLayoutPanel5.SuspendLayout()
            Me.tableLayoutPanel6.SuspendLayout()
            CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleRangeBarForecast, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanel3.SuspendLayout()
            CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScalePrevYear, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.needleFiscalYear, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.circularGauge3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleFiscalToData, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.needleFiscalToData, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tableLayoutPanel2.SuspendLayout()
            CType(Me.chartSalesbySecor, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(DoughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(DoughnutSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(DoughnutSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(DoughnutSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'arcScaleBackgroundLayerComponent2
            '
            Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleBackgroundLayerComponent2.Name = "bg"
            Me.arcScaleBackgroundLayerComponent2.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 0.584!)
            Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularThreeFourth_Style27
            Me.arcScaleBackgroundLayerComponent2.Size = New System.Drawing.SizeF(200.0!, 170.7!)
            Me.arcScaleBackgroundLayerComponent2.ZOrder = 1000
            '
            'arcScaleComponent2
            '
            Me.arcScaleComponent2.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent2.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10.0!)
            Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
            Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.arcScaleComponent2.EndAngle = 45.0!
            Me.arcScaleComponent2.MajorTickCount = 0
            Me.arcScaleComponent2.MajorTickmark.AllowTickOverlap = True
            Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent2.MajorTickmark.ShapeOffset = -4.0!
            Me.arcScaleComponent2.MajorTickmark.ShowFirst = False
            Me.arcScaleComponent2.MajorTickmark.ShowLast = False
            Me.arcScaleComponent2.MajorTickmark.ShowText = False
            Me.arcScaleComponent2.MajorTickmark.ShowTick = False
            Me.arcScaleComponent2.MajorTickmark.TextOffset = 18.0!
            Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent2.MaxValue = 100.0!
            Me.arcScaleComponent2.MinorTickCount = 0
            Me.arcScaleComponent2.MinorTickmark.ShapeOffset = 4.0!
            Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style22_2
            Me.arcScaleComponent2.MinorTickmark.ShowFirst = False
            Me.arcScaleComponent2.MinorTickmark.ShowLast = False
            Me.arcScaleComponent2.MinorTickmark.ShowTick = False
            Me.arcScaleComponent2.Name = "scale1"
            Me.arcScaleComponent2.RadiusX = 101.0!
            Me.arcScaleComponent2.RadiusY = 100.5!
            ArcScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9BBB59")
            ArcScaleRange1.EndThickness = 22.0!
            ArcScaleRange1.EndValue = 33.0!
            ArcScaleRange1.Name = "Range0"
            ArcScaleRange1.ShapeOffset = -4.0!
            ArcScaleRange1.StartThickness = 22.0!
            ArcScaleRange1.StartValue = -0.2!
            ArcScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F4F56B")
            ArcScaleRange2.EndThickness = 22.0!
            ArcScaleRange2.EndValue = 66.0!
            ArcScaleRange2.Name = "Range1"
            ArcScaleRange2.ShapeOffset = -4.0!
            ArcScaleRange2.StartThickness = 22.0!
            ArcScaleRange2.StartValue = 33.0!
            ArcScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E73141")
            ArcScaleRange3.EndThickness = 22.0!
            ArcScaleRange3.EndValue = 100.2!
            ArcScaleRange3.Name = "Range2"
            ArcScaleRange3.ShapeOffset = -4.0!
            ArcScaleRange3.StartThickness = 22.0!
            ArcScaleRange3.StartValue = 66.0!
            Me.arcScaleComponent2.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {ArcScaleRange1, ArcScaleRange2, ArcScaleRange3})
            Me.arcScaleComponent2.StartAngle = -225.0!
            Me.arcScaleComponent2.Value = 50.0!
            '
            'arcScaleNeedleComponent2
            '
            Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent2
            Me.arcScaleNeedleComponent2.EndOffset = 8.0!
            Me.arcScaleNeedleComponent2.Name = "needle"
            Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style27
            Me.arcScaleNeedleComponent2.StartOffset = -6.0!
            Me.arcScaleNeedleComponent2.ZOrder = -50
            '
            'circularGauge1
            '
            Me.circularGauge1.AutoSize = DevExpress.Utils.DefaultBoolean.[False]
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 220, 176)
            Me.circularGauge1.Name = "circularGauge1"
            '
            'labelComponent1
            '
            Me.labelComponent1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent1.Name = "circularGauge3_Label1"
            Me.labelComponent1.Text = "circularGauge3_Label1"
            Me.labelComponent1.ZOrder = -1001
            '
            'tableLayoutPanel1
            '
            Me.tableLayoutPanel1.ColumnCount = 3
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 420.0!))
            Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel4, 0, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel5, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel6, 2, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.tableLayoutPanel2, 2, 0)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI Light", 8.25!)
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 3
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(996, 700)
            Me.tableLayoutPanel1.TabIndex = 0
            '
            'tableLayoutPanel4
            '
            Me.tableLayoutPanel4.ColumnCount = 1
            Me.tableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel4.Controls.Add(Me.labelControl3, 0, 0)
            Me.tableLayoutPanel4.Controls.Add(Me.monthlySalesPerformance, 0, 1)
            Me.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel4.Location = New System.Drawing.Point(3, 359)
            Me.tableLayoutPanel4.Name = "tableLayoutPanel4"
            Me.tableLayoutPanel4.RowCount = 2
            Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.tableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel4.Size = New System.Drawing.Size(566, 338)
            Me.tableLayoutPanel4.TabIndex = 12
            '
            'labelControl3
            '
            Me.labelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!)
            Me.labelControl3.Appearance.Options.UseFont = True
            Me.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center
            Me.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
            Me.labelControl3.LineVisible = True
            Me.labelControl3.Location = New System.Drawing.Point(3, 3)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Padding = New System.Windows.Forms.Padding(34, 0, 20, 0)
            Me.labelControl3.ShowLineShadow = False
            Me.labelControl3.Size = New System.Drawing.Size(560, 34)
            Me.labelControl3.TabIndex = 12
            Me.labelControl3.Text = "Monthly Sales Performance "
            '
            'monthlySalesPerformance
            '
            Me.monthlySalesPerformance.Dock = System.Windows.Forms.DockStyle.Fill
            Me.monthlySalesPerformance.Location = New System.Drawing.Point(3, 43)
            Me.monthlySalesPerformance.Name = "monthlySalesPerformance"
            Me.monthlySalesPerformance.Size = New System.Drawing.Size(560, 292)
            Me.monthlySalesPerformance.TabIndex = 11
            '
            'tableLayoutPanel5
            '
            Me.tableLayoutPanel5.ColumnCount = 1
            Me.tableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel5.Controls.Add(Me.labelControl2, 0, 0)
            Me.tableLayoutPanel5.Controls.Add(Me.dailySalesPerformance, 0, 1)
            Me.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
            Me.tableLayoutPanel5.Name = "tableLayoutPanel5"
            Me.tableLayoutPanel5.RowCount = 2
            Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.tableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel5.Size = New System.Drawing.Size(566, 338)
            Me.tableLayoutPanel5.TabIndex = 13
            '
            'labelControl2
            '
            Me.labelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!)
            Me.labelControl2.Appearance.Options.UseFont = True
            Me.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.Center
            Me.labelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
            Me.labelControl2.LineVisible = True
            Me.labelControl2.Location = New System.Drawing.Point(3, 3)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Padding = New System.Windows.Forms.Padding(34, 0, 20, 0)
            Me.labelControl2.ShowLineShadow = False
            Me.labelControl2.Size = New System.Drawing.Size(560, 34)
            Me.labelControl2.TabIndex = 3
            Me.labelControl2.Text = "Daily Sales Performance "
            '
            'dailySalesPerformance
            '
            Me.dailySalesPerformance.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dailySalesPerformance.Location = New System.Drawing.Point(3, 43)
            Me.dailySalesPerformance.Name = "dailySalesPerformance"
            Me.dailySalesPerformance.Size = New System.Drawing.Size(560, 292)
            Me.dailySalesPerformance.TabIndex = 0
            '
            'tableLayoutPanel6
            '
            Me.tableLayoutPanel6.ColumnCount = 1
            Me.tableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel6.Controls.Add(Me.labelControl4, 0, 0)
            Me.tableLayoutPanel6.Controls.Add(Me.gaugeControl2, 0, 4)
            Me.tableLayoutPanel6.Controls.Add(Me.tableLayoutPanel3, 0, 1)
            Me.tableLayoutPanel6.Controls.Add(Me.labelControl5, 0, 3)
            Me.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel6.Location = New System.Drawing.Point(579, 359)
            Me.tableLayoutPanel6.Name = "tableLayoutPanel6"
            Me.tableLayoutPanel6.RowCount = 5
            Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.tableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
            Me.tableLayoutPanel6.Size = New System.Drawing.Size(414, 338)
            Me.tableLayoutPanel6.TabIndex = 14
            '
            'labelControl4
            '
            Me.labelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!)
            Me.labelControl4.Appearance.Options.UseFont = True
            Me.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelControl4.LineLocation = DevExpress.XtraEditors.LineLocation.Center
            Me.labelControl4.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
            Me.labelControl4.LineVisible = True
            Me.labelControl4.Location = New System.Drawing.Point(3, 3)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
            Me.labelControl4.ShowLineShadow = False
            Me.labelControl4.Size = New System.Drawing.Size(408, 34)
            Me.labelControl4.TabIndex = 16
            Me.labelControl4.Text = "Annual Sales Performance "
            '
            'gaugeControl2
            '
            Me.gaugeControl2.AutoLayout = False
            Me.gaugeControl2.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge1})
            Me.gaugeControl2.Location = New System.Drawing.Point(3, 281)
            Me.gaugeControl2.Name = "gaugeControl2"
            Me.gaugeControl2.Size = New System.Drawing.Size(408, 54)
            Me.gaugeControl2.TabIndex = 9
            '
            'linearGauge1
            '
            Me.linearGauge1.AutoSize = DevExpress.Utils.DefaultBoolean.[True]
            Me.linearGauge1.Bounds = New System.Drawing.Rectangle(-12, -10, 432, 59)
            Me.linearGauge1.Name = "linearGauge1"
            Me.linearGauge1.Orientation = DevExpress.XtraGauges.Core.Model.ScaleOrientation.Horizontal
            Me.linearGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent() {Me.linearScaleRangeBarForecast})
            Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent1})
            '
            'linearScaleRangeBarForecast
            '
            Me.linearScaleRangeBarForecast.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#5848A5")
            Me.linearScaleRangeBarForecast.EndOffset = 8.0!
            Me.linearScaleRangeBarForecast.LinearScale = Me.linearScaleComponent1
            Me.linearScaleRangeBarForecast.Name = "linearGauge2_RangeBar1"
            Me.linearScaleRangeBarForecast.StartOffset = 4.0!
            Me.linearScaleRangeBarForecast.ZOrder = -100
            '
            'linearScaleComponent1
            '
            Me.linearScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceScale.Brush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
            Me.linearScaleComponent1.AppearanceScale.Width = 4.0!
            Me.linearScaleComponent1.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Segoe UI", 8.0!, DevExpress.Drawing.DXFontStyle.Bold)
            Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
            Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, -100.0!)
            Me.linearScaleComponent1.MajorTickCount = 6
            Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent1.MajorTickmark.ShapeOffset = -7.0!
            Me.linearScaleComponent1.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.1!, 1.0!)
            Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
            Me.linearScaleComponent1.MajorTickmark.TextOffset = -16.0!
            Me.linearScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop
            Me.linearScaleComponent1.MaxValue = 600.0!
            Me.linearScaleComponent1.MinorTickCount = 4
            Me.linearScaleComponent1.MinorTickmark.ShapeOffset = -14.0!
            Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
            Me.linearScaleComponent1.MinorTickmark.ShowTick = False
            Me.linearScaleComponent1.Name = "scale2"
            LinearScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#A54671")
            LinearScaleRange1.EndThickness = 11.0!
            LinearScaleRange1.EndValue = 300.0!
            LinearScaleRange1.Name = "Range0"
            LinearScaleRange1.ShapeOffset = 10.0!
            LinearScaleRange1.StartThickness = 11.0!
            LinearScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FCC653")
            LinearScaleRange2.EndThickness = 11.0!
            LinearScaleRange2.EndValue = 480.0!
            LinearScaleRange2.Name = "Range1"
            LinearScaleRange2.ShapeOffset = 10.0!
            LinearScaleRange2.StartThickness = 11.0!
            LinearScaleRange2.StartValue = 300.0!
            LinearScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#469EA5")
            LinearScaleRange3.EndThickness = 11.0!
            LinearScaleRange3.EndValue = 600.0!
            LinearScaleRange3.Name = "Range2"
            LinearScaleRange3.ShapeOffset = 10.0!
            LinearScaleRange3.StartThickness = 11.0!
            LinearScaleRange3.StartValue = 480.0!
            Me.linearScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {LinearScaleRange1, LinearScaleRange2, LinearScaleRange3})
            Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 330.0!)
            Me.linearScaleComponent1.Value = 20.0!
            '
            'tableLayoutPanel3
            '
            Me.tableLayoutPanel3.ColumnCount = 2
            Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.tableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.tableLayoutPanel3.Controls.Add(Me.gaugeControl1, 1, 0)
            Me.tableLayoutPanel3.Controls.Add(Me.gaugeControl3, 0, 0)
            Me.tableLayoutPanel3.Controls.Add(Me.labelFiscalToData, 0, 1)
            Me.tableLayoutPanel3.Controls.Add(Me.labelFiscalYear, 1, 1)
            Me.tableLayoutPanel3.Controls.Add(Me.fiscalToData, 0, 2)
            Me.tableLayoutPanel3.Controls.Add(Me.fiscalYear, 1, 2)
            Me.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel3.Location = New System.Drawing.Point(3, 43)
            Me.tableLayoutPanel3.Name = "tableLayoutPanel3"
            Me.tableLayoutPanel3.RowCount = 3
            Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
            Me.tableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
            Me.tableLayoutPanel3.Size = New System.Drawing.Size(408, 172)
            Me.tableLayoutPanel3.TabIndex = 0
            '
            'gaugeControl1
            '
            Me.gaugeControl1.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge2})
            Me.gaugeControl1.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(0, 6, 0, 0)
            Me.gaugeControl1.Location = New System.Drawing.Point(204, 0)
            Me.gaugeControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(204, 128)
            Me.gaugeControl1.TabIndex = 11
            '
            'circularGauge2
            '
            Me.circularGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent4})
            Me.circularGauge2.Bounds = New System.Drawing.Rectangle(0, 6, 204, 122)
            Me.circularGauge2.Name = "circularGauge2"
            Me.circularGauge2.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.needleFiscalYear})
            Me.circularGauge2.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScalePrevYear})
            '
            'arcScaleBackgroundLayerComponent4
            '
            Me.arcScaleBackgroundLayerComponent4.ArcScale = Me.arcScalePrevYear
            Me.arcScaleBackgroundLayerComponent4.Name = "bg"
            Me.arcScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style27
            Me.arcScaleBackgroundLayerComponent4.Size = New System.Drawing.SizeF(200.0!, 200.0!)
            Me.arcScaleBackgroundLayerComponent4.ZOrder = 1000
            '
            'arcScalePrevYear
            '
            Me.arcScalePrevYear.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScalePrevYear.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScalePrevYear.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScalePrevYear.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScalePrevYear.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Segoe UI", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScalePrevYear.AppearanceTickmarkText.Spacing = New DevExpress.XtraGauges.Core.Base.TextSpacing(-10, 0, -10, 0)
            Me.arcScalePrevYear.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
            Me.arcScalePrevYear.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.arcScalePrevYear.EndAngle = 60.0!
            Me.arcScalePrevYear.MajorTickCount = 4
            Me.arcScalePrevYear.MajorTickmark.AllowTickOverlap = True
            Me.arcScalePrevYear.MajorTickmark.FormatString = "${0:0,,}M"
            Me.arcScalePrevYear.MajorTickmark.ShapeOffset = -2.0!
            Me.arcScalePrevYear.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
            Me.arcScalePrevYear.MajorTickmark.TextOffset = 20.0!
            Me.arcScalePrevYear.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScalePrevYear.MaxValue = 6.0E+8!
            Me.arcScalePrevYear.MinorTickCount = 4
            Me.arcScalePrevYear.MinorTickmark.ShapeOffset = 4.0!
            Me.arcScalePrevYear.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
            Me.arcScalePrevYear.MinorTickmark.ShowTick = False
            Me.arcScalePrevYear.Name = "scale1"
            ArcScaleRange4.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#A54671")
            ArcScaleRange4.EndThickness = 22.0!
            ArcScaleRange4.EndValue = 3.0E+8!
            ArcScaleRange4.Name = "Range0"
            ArcScaleRange4.ShapeOffset = -4.0!
            ArcScaleRange4.StartThickness = 22.0!
            ArcScaleRange5.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FCC653")
            ArcScaleRange5.EndThickness = 22.0!
            ArcScaleRange5.EndValue = 5.0E+8!
            ArcScaleRange5.Name = "Range1"
            ArcScaleRange5.ShapeOffset = -4.0!
            ArcScaleRange5.StartThickness = 22.0!
            ArcScaleRange5.StartValue = 3.0E+8!
            ArcScaleRange6.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#469EA5")
            ArcScaleRange6.EndThickness = 22.0!
            ArcScaleRange6.EndValue = 6.0E+8!
            ArcScaleRange6.Name = "Range2"
            ArcScaleRange6.ShapeOffset = -4.0!
            ArcScaleRange6.StartThickness = 22.0!
            ArcScaleRange6.StartValue = 5.0E+8!
            Me.arcScalePrevYear.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {ArcScaleRange4, ArcScaleRange5, ArcScaleRange6})
            Me.arcScalePrevYear.StartAngle = -240.0!
            Me.arcScalePrevYear.Value = 50.0!
            '
            'needleFiscalYear
            '
            Me.needleFiscalYear.ArcScale = Me.arcScalePrevYear
            Me.needleFiscalYear.EndOffset = 8.0!
            Me.needleFiscalYear.Name = "needle"
            Me.needleFiscalYear.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style27
            Me.needleFiscalYear.StartOffset = -6.0!
            Me.needleFiscalYear.ZOrder = -50
            '
            'gaugeControl3
            '
            Me.gaugeControl3.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gaugeControl3.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge3})
            Me.gaugeControl3.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(0, 6, 0, 0)
            Me.gaugeControl3.Location = New System.Drawing.Point(0, 0)
            Me.gaugeControl3.Margin = New System.Windows.Forms.Padding(0)
            Me.gaugeControl3.Name = "gaugeControl3"
            Me.gaugeControl3.Size = New System.Drawing.Size(204, 128)
            Me.gaugeControl3.TabIndex = 12
            '
            'circularGauge3
            '
            Me.circularGauge3.AutoSize = DevExpress.Utils.DefaultBoolean.[True]
            Me.circularGauge3.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent3})
            Me.circularGauge3.Bounds = New System.Drawing.Rectangle(0, 6, 204, 122)
            Me.circularGauge3.Name = "circularGauge3"
            Me.circularGauge3.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.needleFiscalToData})
            Me.circularGauge3.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleFiscalToData})
            '
            'arcScaleBackgroundLayerComponent3
            '
            Me.arcScaleBackgroundLayerComponent3.ArcScale = Me.arcScaleFiscalToData
            Me.arcScaleBackgroundLayerComponent3.Name = "bg"
            Me.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style27
            Me.arcScaleBackgroundLayerComponent3.Size = New System.Drawing.SizeF(200.0!, 200.0!)
            Me.arcScaleBackgroundLayerComponent3.ZOrder = 1000
            '
            'arcScaleFiscalToData
            '
            Me.arcScaleFiscalToData.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleFiscalToData.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleFiscalToData.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleFiscalToData.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleFiscalToData.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Segoe UI", 10.0!, DevExpress.Drawing.DXFontStyle.Bold)
            Me.arcScaleFiscalToData.AppearanceTickmarkText.Spacing = New DevExpress.XtraGauges.Core.Base.TextSpacing(-10, 0, -10, 0)
            Me.arcScaleFiscalToData.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
            Me.arcScaleFiscalToData.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.arcScaleFiscalToData.EndAngle = 60.0!
            Me.arcScaleFiscalToData.MajorTickCount = 4
            Me.arcScaleFiscalToData.MajorTickmark.AllowTickOverlap = True
            Me.arcScaleFiscalToData.MajorTickmark.FormatString = "${0:0,,}M"
            Me.arcScaleFiscalToData.MajorTickmark.ShapeOffset = -2.0!
            Me.arcScaleFiscalToData.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
            Me.arcScaleFiscalToData.MajorTickmark.TextOffset = 20.0!
            Me.arcScaleFiscalToData.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleFiscalToData.MaxValue = 6.0E+8!
            Me.arcScaleFiscalToData.MinorTickCount = 4
            Me.arcScaleFiscalToData.MinorTickmark.ShapeOffset = 4.0!
            Me.arcScaleFiscalToData.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
            Me.arcScaleFiscalToData.MinorTickmark.ShowTick = False
            Me.arcScaleFiscalToData.Name = "scale1"
            ArcScaleRange7.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#A54671")
            ArcScaleRange7.EndThickness = 22.0!
            ArcScaleRange7.EndValue = 3.0E+8!
            ArcScaleRange7.Name = "Range0"
            ArcScaleRange7.ShapeOffset = -4.0!
            ArcScaleRange7.StartThickness = 22.0!
            ArcScaleRange8.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FCC653")
            ArcScaleRange8.EndThickness = 22.0!
            ArcScaleRange8.EndValue = 5.0E+8!
            ArcScaleRange8.Name = "Range1"
            ArcScaleRange8.ShapeOffset = -4.0!
            ArcScaleRange8.StartThickness = 22.0!
            ArcScaleRange8.StartValue = 3.0E+8!
            ArcScaleRange9.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#469EA5")
            ArcScaleRange9.EndThickness = 22.0!
            ArcScaleRange9.EndValue = 6.0E+8!
            ArcScaleRange9.Name = "Range2"
            ArcScaleRange9.ShapeOffset = -4.0!
            ArcScaleRange9.StartThickness = 22.0!
            ArcScaleRange9.StartValue = 5.0E+8!
            Me.arcScaleFiscalToData.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {ArcScaleRange7, ArcScaleRange8, ArcScaleRange9})
            Me.arcScaleFiscalToData.StartAngle = -240.0!
            Me.arcScaleFiscalToData.Value = 50.0!
            '
            'needleFiscalToData
            '
            Me.needleFiscalToData.ArcScale = Me.arcScaleFiscalToData
            Me.needleFiscalToData.EndOffset = 8.0!
            Me.needleFiscalToData.Name = "needle"
            Me.needleFiscalToData.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style27
            Me.needleFiscalToData.StartOffset = -6.0!
            Me.needleFiscalToData.ZOrder = -50
            '
            'labelFiscalToData
            '
            Me.labelFiscalToData.AutoSize = True
            Me.labelFiscalToData.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelFiscalToData.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.labelFiscalToData.ForeColor = System.Drawing.Color.Gray
            Me.labelFiscalToData.Location = New System.Drawing.Point(3, 128)
            Me.labelFiscalToData.Name = "labelFiscalToData"
            Me.labelFiscalToData.Size = New System.Drawing.Size(198, 16)
            Me.labelFiscalToData.TabIndex = 13
            Me.labelFiscalToData.Text = "Fiscal To Date"
            Me.labelFiscalToData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'labelFiscalYear
            '
            Me.labelFiscalYear.AutoSize = True
            Me.labelFiscalYear.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelFiscalYear.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.labelFiscalYear.ForeColor = System.Drawing.Color.Gray
            Me.labelFiscalYear.Location = New System.Drawing.Point(207, 128)
            Me.labelFiscalYear.Name = "labelFiscalYear"
            Me.labelFiscalYear.Size = New System.Drawing.Size(198, 16)
            Me.labelFiscalYear.TabIndex = 14
            Me.labelFiscalYear.Text = "Fiscal Year"
            Me.labelFiscalYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'fiscalToData
            '
            Me.fiscalToData.AutoSize = True
            Me.fiscalToData.Dock = System.Windows.Forms.DockStyle.Fill
            Me.fiscalToData.Font = New System.Drawing.Font("Segoe UI", 15.0!)
            Me.fiscalToData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(165, Byte), Integer))
            Me.fiscalToData.Location = New System.Drawing.Point(3, 144)
            Me.fiscalToData.Name = "fiscalToData"
            Me.fiscalToData.Size = New System.Drawing.Size(198, 28)
            Me.fiscalToData.TabIndex = 15
            Me.fiscalToData.Text = "$000,000,000"
            Me.fiscalToData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'fiscalYear
            '
            Me.fiscalYear.AutoSize = True
            Me.fiscalYear.Dock = System.Windows.Forms.DockStyle.Fill
            Me.fiscalYear.Font = New System.Drawing.Font("Segoe UI", 15.0!)
            Me.fiscalYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(113, Byte), Integer))
            Me.fiscalYear.Location = New System.Drawing.Point(207, 144)
            Me.fiscalYear.Name = "fiscalYear"
            Me.fiscalYear.Size = New System.Drawing.Size(198, 28)
            Me.fiscalYear.TabIndex = 16
            Me.fiscalYear.Text = "$000,000,000"
            Me.fiscalYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'labelControl5
            '
            Me.labelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!)
            Me.labelControl5.Appearance.Options.UseFont = True
            Me.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Center
            Me.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
            Me.labelControl5.LineVisible = True
            Me.labelControl5.Location = New System.Drawing.Point(3, 241)
            Me.labelControl5.Name = "labelControl5"
            Me.labelControl5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
            Me.labelControl5.ShowLineShadow = False
            Me.labelControl5.Size = New System.Drawing.Size(408, 34)
            Me.labelControl5.TabIndex = 17
            Me.labelControl5.Text = "Sales Forecast"
            '
            'tableLayoutPanel2
            '
            Me.tableLayoutPanel2.ColumnCount = 1
            Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel2.Controls.Add(Me.chartSalesbySecor, 0, 1)
            Me.tableLayoutPanel2.Controls.Add(Me.labelControl1, 0, 0)
            Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel2.Location = New System.Drawing.Point(579, 3)
            Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
            Me.tableLayoutPanel2.RowCount = 2
            Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
            Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutPanel2.Size = New System.Drawing.Size(414, 338)
            Me.tableLayoutPanel2.TabIndex = 15
            '
            'chartSalesbySecor
            '
            Me.chartSalesbySecor.BackColor = System.Drawing.Color.Transparent
            Me.chartSalesbySecor.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartSalesbySecor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartSalesbySecor.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.LeftOutside
            Me.chartSalesbySecor.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center
            Me.chartSalesbySecor.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chartSalesbySecor.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartSalesbySecor.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartSalesbySecor.Legend.EquallySpacedItems = False
            Me.chartSalesbySecor.Legend.LegendID = -1
            Me.chartSalesbySecor.Legend.Margins.Right = 0
            Me.chartSalesbySecor.Legend.MarkerSize = New System.Drawing.Size(18, 18)
            Me.chartSalesbySecor.Legend.Name = "Default Legend"
            Me.chartSalesbySecor.Legend.TextOffset = 8
            Me.chartSalesbySecor.Legend.VerticalIndent = 12
            Me.chartSalesbySecor.Location = New System.Drawing.Point(3, 43)
            Me.chartSalesbySecor.Name = "chartSalesbySecor"
            Me.chartSalesbySecor.Padding.Right = 0
            Series1.ArgumentDataMember = "GroupName"
            Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            DoughnutSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            DoughnutSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            DoughnutSeriesLabel1.TextPattern = "{V:F0}"
            Series1.Label = DoughnutSeriesLabel1
            Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Series1.LegendTextPattern = "{A}"
            Series1.Name = "Series 1"
            Series1.SeriesID = 0
            Series1.ValueDataMembersSerializable = "TotalCost"
            DoughnutSeriesView1.HoleRadiusPercent = 55
            Series1.View = DoughnutSeriesView1
            Me.chartSalesbySecor.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
            DoughnutSeriesLabel2.TextPattern = "{VP:G2}"
            Me.chartSalesbySecor.SeriesTemplate.Label = DoughnutSeriesLabel2
            Me.chartSalesbySecor.SeriesTemplate.View = DoughnutSeriesView2
            Me.chartSalesbySecor.Size = New System.Drawing.Size(408, 292)
            Me.chartSalesbySecor.TabIndex = 1
            '
            'labelControl1
            '
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!)
            Me.labelControl1.Appearance.Options.UseFont = True
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center
            Me.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
            Me.labelControl1.LineVisible = True
            Me.labelControl1.Location = New System.Drawing.Point(3, 3)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
            Me.labelControl1.ShowLineShadow = False
            Me.labelControl1.Size = New System.Drawing.Size(408, 34)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "Sales By Sector "
            '
            'AnalyticsModule
            '
            Me.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "AnalyticsModule"
            Me.Size = New System.Drawing.Size(996, 700)
            CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel4.ResumeLayout(False)
            Me.tableLayoutPanel4.PerformLayout()
            Me.tableLayoutPanel5.ResumeLayout(False)
            Me.tableLayoutPanel5.PerformLayout()
            Me.tableLayoutPanel6.ResumeLayout(False)
            Me.tableLayoutPanel6.PerformLayout()
            CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleRangeBarForecast, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanel3.ResumeLayout(False)
            Me.tableLayoutPanel3.PerformLayout()
            CType(Me.circularGauge2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScalePrevYear, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.needleFiscalYear, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.circularGauge3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleFiscalToData, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.needleFiscalToData, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tableLayoutPanel2.ResumeLayout(False)
            Me.tableLayoutPanel2.PerformLayout()
            CType(DoughnutSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(DoughnutSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(DoughnutSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(DoughnutSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartSalesbySecor, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private dailySalesPerformance As ucSalesPerformance
		Private chartSalesbySecor As XtraCharts.ChartControl
		Private tableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
		Private arcScaleBackgroundLayerComponent2 As XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent2 As XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleNeedleComponent2 As XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private circularGauge1 As XtraGauges.Win.Gauges.Circular.CircularGauge
		Private gaugeControl2 As XtraGauges.Win.GaugeControl
		Private linearScaleRangeBarForecast As XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent
		Private linearScaleComponent1 As XtraGauges.Win.Gauges.Linear.LinearScaleComponent
		Private linearGauge1 As XtraGauges.Win.Gauges.Linear.LinearGauge
		Private gaugeControl1 As XtraGauges.Win.GaugeControl
		Private circularGauge2 As XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent4 As XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScalePrevYear As XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private needleFiscalYear As XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private labelComponent1 As XtraGauges.Win.Base.LabelComponent
		Private gaugeControl3 As XtraGauges.Win.GaugeControl
		Private circularGauge3 As XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent3 As XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleFiscalToData As XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private needleFiscalToData As XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private tableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
		Private monthlySalesPerformance As ucSalesPerformance
		Private tableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
		Private tableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
		Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
		Private labelFiscalToData As System.Windows.Forms.Label
		Private labelFiscalYear As System.Windows.Forms.Label
		Private fiscalToData As System.Windows.Forms.Label
		Private fiscalYear As System.Windows.Forms.Label
		Private labelControl1 As XtraEditors.LabelControl
		Private labelControl3 As XtraEditors.LabelControl
		Private labelControl2 As XtraEditors.LabelControl
		Private labelControl4 As XtraEditors.LabelControl
		Private labelControl5 As XtraEditors.LabelControl

	End Class
End Namespace
