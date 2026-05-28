Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.ModulesStatistics
	Partial Public Class RevenueSplitStatistics
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
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram
            Dim StackedBarSeriesLabel1 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel
            Dim StackedBarSeriesView1 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView
            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.chart = New DevExpress.XtraCharts.ChartControl
            Me.pivotGrid = New DevExpress.XtraPivotGrid.PivotGridControl
            Me.fieldRevenue = New DevExpress.XtraPivotGrid.PivotGridField
            Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField
            Me.fieldReceiptType = New DevExpress.XtraPivotGrid.PivotGridField
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(StackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pivotGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl1
            '
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
            'chart
            '
            Me.chart.DataSource = Me.pivotGrid
            XyDiagram1.AxisX.Label.Staggered = True
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.Label.TextPattern = "{V:C0}"
            XyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chart.Diagram = XyDiagram1
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Legend.MaxVerticalPercentage = 30
            Me.chart.Location = New System.Drawing.Point(8, 8)
            Me.chart.Name = "chart"
            Me.chart.PaletteName = "Concourse"
            Me.chart.SeriesDataMember = "Series"
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chart.SeriesTemplate.ArgumentDataMember = "Arguments"
            StackedBarSeriesLabel1.TextPattern = "{V:C2}"
            StackedBarSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
            Me.chart.SeriesTemplate.Label = StackedBarSeriesLabel1
            Me.chart.SeriesTemplate.LabelsVisibility = Utils.DefaultBoolean.True
            Me.chart.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.chart.SeriesTemplate.View = StackedBarSeriesView1
            Me.chart.Size = New System.Drawing.Size(1000, 343)
            Me.chart.TabIndex = 4
            ChartTitle1.Text = "Revenue Split - Last 12 Months"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
            '
            'pivotGrid
            '
            Me.pivotGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldRevenue, Me.fieldMonth, Me.fieldReceiptType})
            Me.pivotGrid.Location = New System.Drawing.Point(8, 360)
            Me.pivotGrid.Name = "pivotGrid"
            Me.pivotGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
            Me.pivotGrid.OptionsChartDataSource.ProvideColumnCustomTotals = False
            Me.pivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = False
            Me.pivotGrid.OptionsChartDataSource.ProvideColumnTotals = False
            Me.pivotGrid.OptionsChartDataSource.ProvideDataByColumns = False
            Me.pivotGrid.OptionsChartDataSource.ProvideRowCustomTotals = False
            Me.pivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = False
            Me.pivotGrid.OptionsChartDataSource.ProvideRowTotals = False
            Me.pivotGrid.OptionsChartDataSource.SelectionOnly = False
            Me.pivotGrid.OptionsCustomization.AllowDrag = False
            Me.pivotGrid.OptionsView.ShowColumnGrandTotals = False
            Me.pivotGrid.OptionsView.ShowFilterHeaders = False
            Me.pivotGrid.Size = New System.Drawing.Size(1000, 169)
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
            'fieldMonth
            '
            Me.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldMonth.AreaIndex = 0
            Me.fieldMonth.Caption = "Month"
            Me.fieldMonth.FieldName = "Date"
            Me.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Custom
            Me.fieldMonth.Name = "fieldMonth"
            Me.fieldMonth.UnboundFieldName = "fieldPeriod"
            '
            'fieldReceiptType
            '
            Me.fieldReceiptType.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldReceiptType.AreaIndex = 0
            Me.fieldReceiptType.Caption = "Receipt Type"
            Me.fieldReceiptType.FieldName = "Type"
            Me.fieldReceiptType.Name = "fieldReceiptType"
            Me.fieldReceiptType.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom
            Me.fieldReceiptType.UnboundFieldName = "fieldMonth"
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.splitterItem1})
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
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(1004, 347)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.pivotGrid
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 352)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(1004, 173)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            '
            'splitterItem1
            '
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.CustomizationFormText = "splitterItem1"
            Me.splitterItem1.Location = New System.Drawing.Point(0, 347)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(1004, 5)
            '
            'RevenueSplitStatistics
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "RevenueSplitStatistics"
            Me.Size = New System.Drawing.Size(1016, 537)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(StackedBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pivotGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
		Private WithEvents pivotGrid As DevExpress.XtraPivotGrid.PivotGridControl
		Private chart As DevExpress.XtraCharts.ChartControl
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private fieldRevenue As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldMonth As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldReceiptType As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace
