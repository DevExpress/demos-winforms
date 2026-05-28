Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.ModulesKPI
	Partial Public Class CustomersKPI
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram
            Dim XyDiagramPane1 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane
            Dim SecondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
            Dim FullStackedAreaSeriesLabel1 As DevExpress.XtraCharts.FullStackedAreaSeriesLabel = New DevExpress.XtraCharts.FullStackedAreaSeriesLabel
            Dim FullStackedSplineAreaSeriesView1 As DevExpress.XtraCharts.FullStackedSplineAreaSeriesView = New DevExpress.XtraCharts.FullStackedSplineAreaSeriesView
            Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
            Dim FullStackedAreaSeriesLabel2 As DevExpress.XtraCharts.FullStackedAreaSeriesLabel = New DevExpress.XtraCharts.FullStackedAreaSeriesLabel
            Dim FullStackedSplineAreaSeriesView2 As DevExpress.XtraCharts.FullStackedSplineAreaSeriesView = New DevExpress.XtraCharts.FullStackedSplineAreaSeriesView
            Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
            Dim FullStackedAreaSeriesLabel3 As DevExpress.XtraCharts.FullStackedAreaSeriesLabel = New DevExpress.XtraCharts.FullStackedAreaSeriesLabel
            Dim FullStackedSplineAreaSeriesView3 As DevExpress.XtraCharts.FullStackedSplineAreaSeriesView = New DevExpress.XtraCharts.FullStackedSplineAreaSeriesView
            Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
            Dim FullStackedAreaSeriesLabel4 As DevExpress.XtraCharts.FullStackedAreaSeriesLabel = New DevExpress.XtraCharts.FullStackedAreaSeriesLabel
            Dim FullStackedSplineAreaSeriesView4 As DevExpress.XtraCharts.FullStackedSplineAreaSeriesView = New DevExpress.XtraCharts.FullStackedSplineAreaSeriesView
            Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series
            Dim FullStackedAreaSeriesLabel5 As DevExpress.XtraCharts.FullStackedAreaSeriesLabel = New DevExpress.XtraCharts.FullStackedAreaSeriesLabel
            Dim FullStackedSplineAreaSeriesView5 As DevExpress.XtraCharts.FullStackedSplineAreaSeriesView = New DevExpress.XtraCharts.FullStackedSplineAreaSeriesView
            Dim PointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel
            Dim SplineSeriesView1 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView
            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle
            Me.Year = New DevExpress.XtraPivotGrid.PivotGridField
            Me.Quarter = New DevExpress.XtraPivotGrid.PivotGridField
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
            Me.discountGrid = New DevExpress.XtraPivotGrid.PivotGridControl
            Me.receiptsCollection = New DevExpress.Xpo.XPCollection
            Me.fieldPayment = New DevExpress.XtraPivotGrid.PivotGridField
            Me.fieldCustomer = New DevExpress.XtraPivotGrid.PivotGridField
            Me.discountChart = New DevExpress.XtraCharts.ChartControl
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.discountGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.receiptsCollection, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.discountChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagramPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SecondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(FullStackedAreaSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(FullStackedSplineAreaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(FullStackedAreaSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(FullStackedSplineAreaSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(FullStackedAreaSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(FullStackedSplineAreaSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(FullStackedAreaSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(FullStackedSplineAreaSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(FullStackedAreaSeriesLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(FullStackedSplineAreaSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Year
            '
            Me.Year.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.Year.AreaIndex = 0
            Me.Year.Caption = "Year"
            Me.Year.FieldName = "Date"
            Me.Year.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.Year.Name = "Year"
            Me.Year.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
            Me.Year.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.Year.RunningTotal = True
            Me.Year.UnboundFieldName = "Year"
            '
            'Quarter
            '
            Me.Quarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.Quarter.AreaIndex = 1
            Me.Quarter.Caption = "Quarter"
            Me.Quarter.FieldName = "Date"
            Me.Quarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.Quarter.Name = "Quarter"
            Me.Quarter.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
            Me.Quarter.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.Quarter.RunningTotal = True
            Me.Quarter.UnboundFieldName = "Quarter"
            Me.Quarter.Width = 74
            '
            'layoutControl1
            '
            Me.layoutControl1.Controls.Add(Me.discountGrid)
            Me.layoutControl1.Controls.Add(Me.discountChart)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(873, 589)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '
            'discountGrid
            '
            Me.discountGrid.DataSource = Me.receiptsCollection
            Me.discountGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldPayment, Me.fieldCustomer, Me.Year, Me.Quarter})
            Me.discountGrid.Location = New System.Drawing.Point(8, 8)
            Me.discountGrid.Name = "discountGrid"
            Me.discountGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.Value
            Me.discountGrid.OptionsChartDataSource.ProvideColumnCustomTotals = False
            Me.discountGrid.OptionsChartDataSource.ProvideColumnGrandTotals = False
            Me.discountGrid.OptionsChartDataSource.ProvideColumnTotals = False
            Me.discountGrid.OptionsChartDataSource.ProvideDataByColumns = False
            Me.discountGrid.OptionsChartDataSource.ProvideRowCustomTotals = False
            Me.discountGrid.OptionsChartDataSource.ProvideRowGrandTotals = False
            Me.discountGrid.OptionsChartDataSource.ProvideRowTotals = False
            Me.discountGrid.OptionsCustomization.AllowDrag = False
            Me.discountGrid.OptionsCustomization.AllowDragInCustomizationForm = False
            Me.discountGrid.OptionsCustomization.AllowEdit = False
            Me.discountGrid.OptionsCustomization.AllowExpand = False
            Me.discountGrid.OptionsView.ShowColumnGrandTotals = False
            Me.discountGrid.OptionsView.ShowColumnTotals = False
            Me.discountGrid.OptionsView.ShowFilterHeaders = False
            Me.discountGrid.OptionsView.ShowRowGrandTotalHeader = False
            Me.discountGrid.OptionsView.ShowRowGrandTotals = False
            Me.discountGrid.OptionsView.ShowRowTotals = False
            Me.discountGrid.Size = New System.Drawing.Size(284, 573)
            Me.discountGrid.TabIndex = 5
            '
            'receiptsCollection
            '
            Me.receiptsCollection.ObjectType = GetType(DevExpress.VideoRent.Receipt)
            '
            'fieldPayment
            '
            Me.fieldPayment.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldPayment.AreaIndex = 0
            Me.fieldPayment.FieldName = "Payment"
            Me.fieldPayment.Name = "fieldPayment"
            Me.fieldPayment.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            '
            'fieldCustomer
            '
            Me.fieldCustomer.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCustomer.AreaIndex = 0
            Me.fieldCustomer.Caption = "Customer"
            Me.fieldCustomer.FieldName = "Customer!"
            Me.fieldCustomer.Name = "fieldCustomer"
            Me.fieldCustomer.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            Me.fieldCustomer.Width = 127
            '
            'discountChart
            '
            XyDiagram1.AxisX.GridLines.MinorVisible = True
            XyDiagram1.AxisX.GridLines.Visible = True
            XyDiagram1.AxisX.Label.Staggered = True
            XyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            XyDiagram1.AxisX.WholeRange.SideMarginsValue = 0
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1;0"
            XyDiagram1.AxisY.GridLines.MinorVisible = True
            XyDiagram1.AxisY.Title.Text = "Payment $"
            XyDiagram1.AxisY.Title.Visibility = Utils.DefaultBoolean.True
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            XyDiagram1.DefaultPane.LayoutOptions.RowSpan = 3
            XyDiagramPane1.Name = "DiscountsPane"
            XyDiagramPane1.PaneID = 0
            XyDiagramPane1.LayoutOptions.RowSpan = 2
            XyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {XyDiagramPane1})
            SecondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            SecondaryAxisY1.AxisID = 0
            SecondaryAxisY1.GridLines.MinorVisible = True
            SecondaryAxisY1.GridLines.Visible = True
            SecondaryAxisY1.Name = "SecondaryAxisY"
            SecondaryAxisY1.Label.TextPattern = "{V:P0}"
            SecondaryAxisY1.WholeRange.AutoSideMargins = False
            SecondaryAxisY1.WholeRange.SideMarginsValue = 0
            SecondaryAxisY1.VisibleInPanesSerializable = "0"
            XyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {SecondaryAxisY1})
            Me.discountChart.Diagram = XyDiagram1
            Me.discountChart.Location = New System.Drawing.Point(301, 8)
            Me.discountChart.Name = "discountChart"
            Me.discountChart.RefreshDataOnRepaint = False
            Me.discountChart.SeriesDataMember = "Series"
            Series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            FullStackedAreaSeriesLabel1.TextPattern = "{V:G2}"
            Series1.Label = FullStackedAreaSeriesLabel1
            Series1.LabelsVisibility = Utils.DefaultBoolean.True
            Series1.Name = "First-Time Renter"
            FullStackedSplineAreaSeriesView1.AxisYName = "SecondaryAxisY"
            FullStackedSplineAreaSeriesView1.PaneName = "DiscountsPane"
            FullStackedSplineAreaSeriesView1.Transparency = CType(100, Byte)
            Series1.View = FullStackedSplineAreaSeriesView1
            Series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            FullStackedAreaSeriesLabel2.TextPattern = "{V:G2}"
            Series2.Label = FullStackedAreaSeriesLabel2
            Series2.LabelsVisibility = Utils.DefaultBoolean.True
            Series2.Name = "Basic Renter"
            FullStackedSplineAreaSeriesView2.AxisYName = "SecondaryAxisY"
            FullStackedSplineAreaSeriesView2.PaneName = "DiscountsPane"
            FullStackedSplineAreaSeriesView2.Transparency = CType(100, Byte)
            Series2.View = FullStackedSplineAreaSeriesView2
            Series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            FullStackedAreaSeriesLabel3.TextPattern = "{V:G2}"
            Series3.Label = FullStackedAreaSeriesLabel3
            Series3.LabelsVisibility = Utils.DefaultBoolean.True
            Series3.Name = "Occasional Renter"
            FullStackedSplineAreaSeriesView3.AxisYName = "SecondaryAxisY"
            FullStackedSplineAreaSeriesView3.PaneName = "DiscountsPane"
            FullStackedSplineAreaSeriesView3.Transparency = CType(100, Byte)
            Series3.View = FullStackedSplineAreaSeriesView3
            Series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            FullStackedAreaSeriesLabel4.TextPattern = "{V:G2}"
            Series4.Label = FullStackedAreaSeriesLabel4
            Series4.LabelsVisibility = Utils.DefaultBoolean.True
            Series4.Name = "Active Renter"
            FullStackedSplineAreaSeriesView4.AxisYName = "SecondaryAxisY"
            FullStackedSplineAreaSeriesView4.PaneName = "DiscountsPane"
            FullStackedSplineAreaSeriesView4.Transparency = CType(100, Byte)
            Series4.View = FullStackedSplineAreaSeriesView4
            Series5.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            FullStackedAreaSeriesLabel5.TextPattern = "{V:G2}"
            Series5.Label = FullStackedAreaSeriesLabel5
            Series5.LabelsVisibility = Utils.DefaultBoolean.True
            Series5.Name = "Prodigious Renter"
            FullStackedSplineAreaSeriesView5.AxisYName = "SecondaryAxisY"
            FullStackedSplineAreaSeriesView5.PaneName = "DiscountsPane"
            FullStackedSplineAreaSeriesView5.Transparency = CType(100, Byte)
            Series5.View = FullStackedSplineAreaSeriesView5
            Me.discountChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3, Series4, Series5}
            Me.discountChart.SeriesTemplate.ArgumentDataMember = "Arguments"
            Me.discountChart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            PointSeriesLabel1.LineVisibility = Utils.DefaultBoolean.True
            Me.discountChart.SeriesTemplate.Label = PointSeriesLabel1
            Me.discountChart.SeriesTemplate.LabelsVisibility = Utils.DefaultBoolean.False
            Me.discountChart.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.discountChart.SeriesTemplate.View = SplineSeriesView1
            Me.discountChart.Size = New System.Drawing.Size(564, 573)
            Me.discountChart.TabIndex = 4
            ChartTitle1.Text = "Revenue by Customers"
            Me.discountChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.splitterItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(873, 589)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.discountChart
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(293, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(568, 577)
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            '
            'layoutControlItem2
            '
            Me.layoutControlItem2.Control = Me.discountGrid
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(288, 577)
            Me.layoutControlItem2.Text = "layoutControlItem2"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextToControlDistance = 0
            Me.layoutControlItem2.TextVisible = False
            '
            'splitterItem1
            '
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.CustomizationFormText = "splitterItem1"
            Me.splitterItem1.Location = New System.Drawing.Point(288, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(5, 577)
            '
            'CustomersKPI
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "CustomersKPI"
            Me.Size = New System.Drawing.Size(873, 589)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.discountGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.receiptsCollection, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagramPane1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SecondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(FullStackedAreaSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(FullStackedSplineAreaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(FullStackedAreaSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(FullStackedSplineAreaSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(FullStackedAreaSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(FullStackedSplineAreaSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(FullStackedAreaSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(FullStackedSplineAreaSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(FullStackedAreaSeriesLabel5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(FullStackedSplineAreaSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SplineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.discountChart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents discountChart As DevExpress.XtraCharts.ChartControl
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents discountGrid As DevExpress.XtraPivotGrid.PivotGridControl
		Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private WithEvents receiptsCollection As DevExpress.Xpo.XPCollection
		Private fieldPayment As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCustomer As DevExpress.XtraPivotGrid.PivotGridField
		Private Year As DevExpress.XtraPivotGrid.PivotGridField
		Private Quarter As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace
