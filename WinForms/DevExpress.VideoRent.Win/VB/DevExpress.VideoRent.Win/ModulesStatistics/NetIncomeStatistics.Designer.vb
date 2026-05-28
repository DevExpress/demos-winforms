Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.ModulesStatistics
	Partial Public Class NetIncomeStatistics
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
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
            Dim ScaleLabel1 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel
            Dim ArcScaleRange1 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange
            Dim ArcScaleRange2 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram
            Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel
            Dim LineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView
            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
            Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
            Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
            Me.labelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent
            Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup
            Me.chart = New DevExpress.XtraCharts.ChartControl
            Me.pivotGrid = New DevExpress.XtraPivotGrid.PivotGridControl
            Me.fieldRevenue = New DevExpress.XtraPivotGrid.PivotGridField
            Me.fieldPeriod = New DevExpress.XtraPivotGrid.PivotGridField
            Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.simpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pivotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.gaugeControl2)
            Me.layoutControl1.Controls.Add(Me.radioGroup1)
            Me.layoutControl1.Controls.Add(Me.chart)
            Me.layoutControl1.Controls.Add(Me.pivotGrid)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(1016, 537)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '
            'gaugeControl2
            '
            Me.gaugeControl2.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.gaugeControl2.Location = New System.Drawing.Point(789, 310)
            Me.gaugeControl2.Name = "gaugeControl2"
            Me.gaugeControl2.Size = New System.Drawing.Size(219, 219)
            Me.gaugeControl2.TabIndex = 8
            '
            'circularGauge1
            '
            Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent1})
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 207, 207)
            Me.circularGauge1.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.labelComponent1})
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent1})
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1})
            '
            'arcScaleBackgroundLayerComponent1
            '
            Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleBackgroundLayerComponent1.Name = "bg"
            Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
            Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
            '
            'arcScaleComponent1
            '
            Me.arcScaleComponent1.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11.0!)
            Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
            Me.arcScaleComponent1.EndAngle = 60.0!
            ScaleLabel1.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11.0!)
            ScaleLabel1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Maroon")
            ScaleLabel1.FormatString = "${1:F2}"
            ScaleLabel1.Name = "Label0"
            ScaleLabel1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 180.0!)
            ScaleLabel1.Size = New System.Drawing.SizeF(150.0!, 30.0!)
            Me.arcScaleComponent1.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel1})
            Me.arcScaleComponent1.MajorTickmark.FormatString = "${0:F2}K"
            Me.arcScaleComponent1.MajorTickmark.Multiplier = 0.001!
            Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -3.5!
            Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
            Me.arcScaleComponent1.MajorTickmark.ShowText = False
            Me.arcScaleComponent1.MajorTickmark.TextOffset = -15.0!
            Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent1.MaxValue = 4000.0!
            Me.arcScaleComponent1.MinorTickCount = 4
            Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
            Me.arcScaleComponent1.MinValue = 2500.0!
            Me.arcScaleComponent1.Name = "scale1"
            ArcScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#90FF8080")
            ArcScaleRange1.EndThickness = 20.0!
            ArcScaleRange1.EndValue = 3000.0!
            ArcScaleRange1.Name = "Range0"
            ArcScaleRange1.ShapeOffset = -10.0!
            ArcScaleRange1.StartThickness = 25.0!
            ArcScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9080FF80")
            ArcScaleRange2.EndThickness = 25.0!
            ArcScaleRange2.EndValue = 3500.0!
            ArcScaleRange2.Name = "Range2"
            ArcScaleRange2.ShapeOffset = -10.0!
            ArcScaleRange2.StartThickness = 20.0!
            ArcScaleRange2.StartValue = 3000.0!
            Me.arcScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {ArcScaleRange1, ArcScaleRange2})
            Me.arcScaleComponent1.StartAngle = -240.0!
            Me.arcScaleComponent1.Value = 3000.0!
            '
            'labelComponent1
            '
            Me.labelComponent1.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11.0!)
            Me.labelComponent1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.labelComponent1.Name = "circularGauge2_Label1"
            Me.labelComponent1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 160.0!)
            Me.labelComponent1.Text = "Month"
            Me.labelComponent1.ZOrder = -1001
            '
            'arcScaleNeedleComponent1
            '
            Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleNeedleComponent1.Name = "needle"
            Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style6
            Me.arcScaleNeedleComponent1.StartOffset = -20.0!
            Me.arcScaleNeedleComponent1.ZOrder = -50
            '
            'radioGroup1
            '
            Me.radioGroup1.AutoSizeInLayoutControl = True
            Me.radioGroup1.EditValue = 1
            Me.radioGroup1.Location = New System.Drawing.Point(8, 8)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroup1.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Show Monthly Revenue"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Show Monthly Receipts")})
            Me.radioGroup1.Size = New System.Drawing.Size(1000, 24)
            Me.radioGroup1.StyleController = Me.layoutControl1
            Me.radioGroup1.TabIndex = 6
            '
            'chart
            '
            Me.chart.DataSource = Me.pivotGrid
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.Label.TextPattern = "{V:C0}"
            XyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chart.Diagram = XyDiagram1
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Legend.MaxVerticalPercentage = 30
            Me.chart.Location = New System.Drawing.Point(8, 38)
            Me.chart.Name = "chart"
            Me.chart.PaletteName = "Concourse"
            Me.chart.SeriesDataMember = "Series"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chart.SeriesTemplate.ArgumentDataMember = "Arguments"
            Me.chart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            PointSeriesLabel1.LineVisibility = Utils.DefaultBoolean.True
            PointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
            Me.chart.SeriesTemplate.Label = PointSeriesLabel1
            Me.chart.SeriesTemplate.LabelsVisibility = Utils.DefaultBoolean.True
            Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.chart.SeriesTemplate.View = LineSeriesView1
            Me.chart.Size = New System.Drawing.Size(1000, 263)
            Me.chart.TabIndex = 4
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
            '
            'pivotGrid
            '
            Me.pivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldRevenue, Me.fieldPeriod, Me.fieldMonth})
            Me.pivotGrid.Location = New System.Drawing.Point(8, 310)
            Me.pivotGrid.Name = "pivotGrid"
            Me.pivotGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.Value
            Me.pivotGrid.OptionsChartDataSource.ProvideColumnCustomTotals = False
            Me.pivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = False
            Me.pivotGrid.OptionsChartDataSource.ProvideColumnTotals = False
            Me.pivotGrid.OptionsChartDataSource.ProvideRowCustomTotals = False
            Me.pivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = False
            Me.pivotGrid.OptionsChartDataSource.ProvideRowTotals = False
            Me.pivotGrid.OptionsChartDataSource.SelectionOnly = False
            Me.pivotGrid.OptionsCustomization.AllowDrag = False
            Me.pivotGrid.OptionsView.ShowColumnGrandTotals = False
            Me.pivotGrid.OptionsView.ShowFilterHeaders = False
            Me.pivotGrid.Size = New System.Drawing.Size(777, 219)
            Me.pivotGrid.TabIndex = 5
            '
            'fieldRevenue
            '
            Me.fieldRevenue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldRevenue.AreaIndex = 0
            Me.fieldRevenue.Caption = "Revenue"
            Me.fieldRevenue.FieldName = "Payment"
            Me.fieldRevenue.Name = "fieldRevenue"
            '
            'fieldPeriod
            '
            Me.fieldPeriod.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldPeriod.AreaIndex = 0
            Me.fieldPeriod.Caption = "Period"
            Me.fieldPeriod.FieldName = "Date"
            Me.fieldPeriod.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom
            Me.fieldPeriod.Name = "fieldPeriod"
            Me.fieldPeriod.UnboundFieldName = "fieldPeriod"
            Me.fieldPeriod.Width = 200
            '
            'fieldMonth
            '
            Me.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldMonth.AreaIndex = 0
            Me.fieldMonth.Caption = "Month"
            Me.fieldMonth.FieldName = "Date"
            Me.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldMonth.Name = "fieldMonth"
            Me.fieldMonth.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
            Me.fieldMonth.UnboundFieldName = "fieldMonth"
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.splitterItem1, Me.layoutControlItem3, Me.simpleSeparator1, Me.layoutControlItem5})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1016, 537)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.chart
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 30)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(1004, 267)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.pivotGrid
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 302)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(781, 223)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            '
            'splitterItem1
            '
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.CustomizationFormText = "splitterItem1"
            Me.splitterItem1.Location = New System.Drawing.Point(0, 297)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(1004, 5)
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.radioGroup1
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(1004, 28)
            Me.layoutControlItem3.Text = "layoutControlItem3"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            '
            'simpleSeparator1
            '
            Me.simpleSeparator1.AllowHotTrack = False
            Me.simpleSeparator1.CustomizationFormText = "simpleSeparator1"
            Me.simpleSeparator1.Location = New System.Drawing.Point(0, 28)
            Me.simpleSeparator1.Name = "simpleSeparator1"
            Me.simpleSeparator1.Size = New System.Drawing.Size(1004, 2)
            Me.simpleSeparator1.Text = "simpleSeparator1"
            '
            'layoutControlItem5
            '
            Me.layoutControlItem5.Control = Me.gaugeControl2
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(781, 302)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(223, 223)
            Me.layoutControlItem5.Text = "layoutControlItem5"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextToControlDistance = 0
            Me.layoutControlItem5.TextVisible = False
            '
            'NetIncomeStatistics
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "NetIncomeStatistics"
            Me.Size = New System.Drawing.Size(1016, 537)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(LineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pivotGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.simpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private WithEvents pivotGrid As DevExpress.XtraPivotGrid.PivotGridControl
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private fieldRevenue As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldPeriod As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldMonth As DevExpress.XtraPivotGrid.PivotGridField
		Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
		Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
		Private simpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
        Private WithEvents chart As DevExpress.XtraCharts.ChartControl
		Private gaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private labelComponent1 As DevExpress.XtraGauges.Win.Base.LabelComponent
		Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
	End Class
End Namespace
