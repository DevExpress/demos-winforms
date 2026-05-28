Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.ModulesKPI
	Partial Public Class CustomersByDatesKPI
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
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim StackedBarSeriesView1 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim StackedBarSeriesView2 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim StackedBarSeriesView3 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim Series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim StackedBarSeriesView4 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim Series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim StackedBarSeriesView5 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim SideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Me.Year = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.Quarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cbeSortMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.customersChart = New DevExpress.XtraCharts.ChartControl()
            Me.customersGrid = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.receiptsCollection = New DevExpress.Xpo.XPCollection()
            Me.fieldPayment = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCustomer = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciChart = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciPivot = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.cbeSortMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customersChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(StackedBarSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(StackedBarSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(StackedBarSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(StackedBarSeriesView5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.customersGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.receiptsCollection, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciChart, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.lciPivot, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.Quarter.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.Quarter.RunningTotal = True
            Me.Quarter.UnboundFieldName = "Quarter"
            Me.Quarter.Width = 105
            '
            'layoutControl1
            '
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.cbeSortMode)
            Me.layoutControl1.Controls.Add(Me.customersChart)
            Me.layoutControl1.Controls.Add(Me.customersGrid)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.lcgMain
            Me.layoutControl1.Size = New System.Drawing.Size(887, 538)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            '
            'cbeSortMode
            '
            Me.cbeSortMode.EditValue = "Payment"
            Me.cbeSortMode.Location = New System.Drawing.Point(349, 8)
            Me.cbeSortMode.Name = "cbeSortMode"
            Me.cbeSortMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeSortMode.Properties.DropDownRows = 2
            Me.cbeSortMode.Properties.Items.AddRange(New Object() {"Payment", "Customer"})
            Me.cbeSortMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbeSortMode.Size = New System.Drawing.Size(530, 20)
            Me.cbeSortMode.StyleController = Me.layoutControl1
            Me.cbeSortMode.TabIndex = 6
            '
            'customersChart
            '
            XyDiagram1.AxisX.MinorCount = 1
            XyDiagram1.AxisX.Tickmarks.MinorLength = 5
            XyDiagram1.AxisX.Tickmarks.Visible = False
            XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            XyDiagram1.AxisY.Tickmarks.MinorVisible = False
            XyDiagram1.AxisY.Title.Text = "Payment $"
            XyDiagram1.AxisY.Title.Visibility = Utils.DefaultBoolean.True
            XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.customersChart.Diagram = XyDiagram1
            Me.customersChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.customersChart.Location = New System.Drawing.Point(311, 32)
            Me.customersChart.Name = "customersChart"
            Me.customersChart.RefreshDataOnRepaint = False
            Me.customersChart.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point
            Me.customersChart.SeriesDataMember = "Series"
            Series1.LabelsVisibility = Utils.DefaultBoolean.True
            Series1.Name = "Prodigious Renter"
            Series1.View = StackedBarSeriesView1
            Series2.LabelsVisibility = Utils.DefaultBoolean.True
            Series2.Name = "Active Renter"
            Series2.View = StackedBarSeriesView2
            Series3.LabelsVisibility = Utils.DefaultBoolean.True
            Series3.Name = "Occasional Renter"
            Series3.View = StackedBarSeriesView3
            Series4.LabelsVisibility = Utils.DefaultBoolean.True
            Series4.Name = "Basic Renter"
            Series4.View = StackedBarSeriesView4
            Series5.LabelsVisibility = Utils.DefaultBoolean.True
            Series5.Name = "First-Time Renter"
            Series5.View = StackedBarSeriesView5
            Me.customersChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3, Series4, Series5}
            Me.customersChart.SeriesTemplate.ArgumentDataMember = "Arguments"
            SideBySideBarSeriesLabel1.TextPattern = "{V:C2}"
            SideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.Center
            SideBySideBarSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
            Me.customersChart.SeriesTemplate.Label = SideBySideBarSeriesLabel1
            Me.customersChart.SeriesTemplate.LabelsVisibility = Utils.DefaultBoolean.True
            Me.customersChart.SeriesTemplate.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending
            Me.customersChart.SeriesTemplate.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
            Me.customersChart.SeriesTemplate.ShowInLegend = False
            Me.customersChart.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.customersChart.Size = New System.Drawing.Size(568, 498)
            Me.customersChart.TabIndex = 4
            ChartTitle1.Text = "Customers by Dates"
            Me.customersChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
            '
            'customersGrid
            '
            Me.customersGrid.DataSource = Me.receiptsCollection
            Me.customersGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldPayment, Me.fieldCustomer, Me.Year, Me.Quarter})
            PivotGridGroup1.Fields.Add(Me.Year)
            PivotGridGroup1.Fields.Add(Me.Quarter)
            PivotGridGroup1.Hierarchy = Nothing
            PivotGridGroup1.ShowNewValues = True
            Me.customersGrid.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
            Me.customersGrid.Location = New System.Drawing.Point(8, 8)
            Me.customersGrid.Name = "customersGrid"
            Me.customersGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.DisplayText
            Me.customersGrid.OptionsChartDataSource.ProvideColumnGrandTotals = True
            Me.customersGrid.OptionsCustomization.AllowDrag = False
            Me.customersGrid.OptionsCustomization.AllowEdit = False
            Me.customersGrid.OptionsSelection.MaxWidth = 1
            Me.customersGrid.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near
            Me.customersGrid.OptionsView.ShowColumnTotals = False
            Me.customersGrid.OptionsView.ShowFilterHeaders = False
            Me.customersGrid.OptionsView.ShowRowGrandTotalHeader = False
            Me.customersGrid.OptionsView.ShowRowGrandTotals = False
            Me.customersGrid.OptionsView.ShowRowTotals = False
            Me.customersGrid.Size = New System.Drawing.Size(294, 522)
            Me.customersGrid.TabIndex = 5
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
            Me.fieldCustomer.SortBySummaryInfo.FieldName = "Payment"
            Me.fieldCustomer.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            Me.fieldCustomer.Width = 127
            '
            'lcgMain
            '
            Me.lcgMain.CustomizationFormText = "Root"
            Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.lcgMain.GroupBordersVisible = False
            Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciChart, Me.lciPivot, Me.splitterItem1, Me.layoutControlItem1})
            Me.lcgMain.Location = New System.Drawing.Point(0, 0)
            Me.lcgMain.Name = "lcgMain"
            Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
            Me.lcgMain.Size = New System.Drawing.Size(887, 538)
            Me.lcgMain.Text = "lcgMain"
            Me.lcgMain.TextVisible = False
            '
            'lciChart
            '
            Me.lciChart.Control = Me.customersChart
            Me.lciChart.CustomizationFormText = "layoutControlItem1"
            Me.lciChart.Location = New System.Drawing.Point(303, 24)
            Me.lciChart.Name = "lciChart"
            Me.lciChart.Size = New System.Drawing.Size(572, 502)
            Me.lciChart.Text = "lciChart"
            Me.lciChart.TextSize = New System.Drawing.Size(0, 0)
            Me.lciChart.TextToControlDistance = 0
            Me.lciChart.TextVisible = False
            '
            'lciPivot
            '
            Me.lciPivot.Control = Me.customersGrid
            Me.lciPivot.CustomizationFormText = "lciPivot"
            Me.lciPivot.Location = New System.Drawing.Point(0, 0)
            Me.lciPivot.MinSize = New System.Drawing.Size(104, 24)
            Me.lciPivot.Name = "lciPivot"
            Me.lciPivot.Size = New System.Drawing.Size(298, 526)
            Me.lciPivot.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.lciPivot.Text = "lciPivot"
            Me.lciPivot.TextSize = New System.Drawing.Size(0, 0)
            Me.lciPivot.TextToControlDistance = 0
            Me.lciPivot.TextVisible = False
            '
            'splitterItem1
            '
            Me.splitterItem1.AllowHotTrack = True
            Me.splitterItem1.CustomizationFormText = "splitterItem1"
            Me.splitterItem1.Location = New System.Drawing.Point(298, 0)
            Me.splitterItem1.Name = "splitterItem1"
            Me.splitterItem1.Size = New System.Drawing.Size(5, 526)
            '
            'layoutControlItem1
            '
            Me.layoutControlItem1.Control = Me.cbeSortMode
            Me.layoutControlItem1.CustomizationFormText = "comboSortMode"
            Me.layoutControlItem1.Location = New System.Drawing.Point(303, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(572, 24)
            Me.layoutControlItem1.Text = "Sort by"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(35, 13)
            '
            'CustomersByDatesKPI
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "CustomersByDatesKPI"
            Me.Size = New System.Drawing.Size(887, 538)
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.cbeSortMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(StackedBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(StackedBarSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(StackedBarSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(StackedBarSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(StackedBarSeriesView5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(SideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customersChart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.customersGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.receiptsCollection, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciChart, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.lciPivot, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents customersChart As DevExpress.XtraCharts.ChartControl
		Private lciChart As DevExpress.XtraLayout.LayoutControlItem
		Private WithEvents customersGrid As DevExpress.XtraPivotGrid.PivotGridControl
		Private lciPivot As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private WithEvents receiptsCollection As DevExpress.Xpo.XPCollection
		Private fieldPayment As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCustomer As DevExpress.XtraPivotGrid.PivotGridField
		Private Year As DevExpress.XtraPivotGrid.PivotGridField
		Private Quarter As DevExpress.XtraPivotGrid.PivotGridField
		Private WithEvents cbeSortMode As DevExpress.XtraEditors.ComboBoxEdit
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

	End Class
End Namespace
