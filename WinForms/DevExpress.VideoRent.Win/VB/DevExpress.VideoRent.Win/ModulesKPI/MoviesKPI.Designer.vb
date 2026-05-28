Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.ModulesKPI
	Partial Public Class MoviesKPI
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
			Dim pivotGridGroup1 As New DevExpress.XtraPivotGrid.PivotGridGroup()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim splineSeriesView1 As New DevExpress.XtraCharts.SplineSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.Year = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.Quarter = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.Month = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldPayment = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.profitGrid = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.rentsCollection = New DevExpress.Xpo.XPCollection()
			Me.fieldMovie = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.profitChart = New DevExpress.XtraCharts.ChartControl()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.lciChartProfit = New DevExpress.XtraLayout.LayoutControlItem()
			Me.splitterItem1 = New DevExpress.XtraLayout.SplitterItem()
			Me.colIcon = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colReleaseDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCheck = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colInfo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			CType(Me.profitGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.rentsCollection, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.profitChart, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(splineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lciChartProfit, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' Year
			' 
			Me.Year.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.Year.AreaIndex = 0
			Me.Year.Caption = "Year"
			Me.Year.FieldName = "RentedOn"
			Me.Year.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.Year.Name = "Year"
			Me.Year.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.Year.RunningTotal = True
			Me.Year.UnboundFieldName = "Year"
			' 
			' Quarter
			' 
			Me.Quarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.Quarter.AreaIndex = 1
			Me.Quarter.Caption = "Quarter"
			Me.Quarter.ExpandedInFieldsGroup = False
			Me.Quarter.FieldName = "RentedOn"
			Me.Quarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
			Me.Quarter.Name = "Quarter"
			Me.Quarter.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.Quarter.RunningTotal = True
			Me.Quarter.UnboundFieldName = "Quarter"
			' 
			' Month
			' 
			Me.Month.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.Month.AreaIndex = 2
			Me.Month.Caption = "Month"
			Me.Month.FieldName = "RentedOn"
			Me.Month.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
			Me.Month.Name = "Month"
			Me.Month.Options.AllowSort = DevExpress.Utils.DefaultBoolean.False
			Me.Month.RunningTotal = True
			Me.Month.UnboundFieldName = "Month"
			Me.Month.Visible = False
			' 
			' fieldPayment
			' 
			Me.fieldPayment.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldPayment.AreaIndex = 0
			Me.fieldPayment.FieldName = "Payment"
			Me.fieldPayment.Name = "fieldPayment"
			' 
			' layoutControl1
			' 
            Me.layoutControl1.AllowCustomization = False
			Me.layoutControl1.Controls.Add(Me.profitGrid)
			Me.layoutControl1.Controls.Add(Me.profitChart)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.lcgMain
			Me.layoutControl1.Size = New System.Drawing.Size(979, 604)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' profitGrid
			' 
			Me.profitGrid.DataSource = Me.rentsCollection
			Me.profitGrid.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldMovie, Me.fieldPayment, Me.Year, Me.Quarter, Me.Month})
			pivotGridGroup1.Caption = "Year"
			pivotGridGroup1.Fields.Add(Me.Year)
			pivotGridGroup1.Fields.Add(Me.Quarter)
			pivotGridGroup1.Fields.Add(Me.Month)
			pivotGridGroup1.Hierarchy = Nothing
			Me.profitGrid.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() { pivotGridGroup1})
			Me.profitGrid.Location = New System.Drawing.Point(8, 8)
			Me.profitGrid.Name = "profitGrid"
			Me.profitGrid.OptionsChartDataSource.ProvideDataByColumns = False
			Me.profitGrid.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.Value
			Me.profitGrid.OptionsChartDataSource.ProvideColumnCustomTotals = False
			Me.profitGrid.OptionsChartDataSource.ProvideColumnGrandTotals = False
			Me.profitGrid.OptionsChartDataSource.ProvideColumnTotals = False
			Me.profitGrid.OptionsChartDataSource.ProvideRowCustomTotals = False
			Me.profitGrid.OptionsChartDataSource.ProvideRowGrandTotals = False
			Me.profitGrid.OptionsChartDataSource.ProvideRowTotals = False
			Me.profitGrid.OptionsCustomization.AllowDrag = False
			Me.profitGrid.OptionsCustomization.AllowDragInCustomizationForm = False
			Me.profitGrid.OptionsCustomization.AllowEdit = False
			Me.profitGrid.OptionsCustomization.AllowExpand = False
			Me.profitGrid.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near
			Me.profitGrid.OptionsView.ShowColumnTotals = False
			Me.profitGrid.OptionsView.ShowFilterHeaders = False
			Me.profitGrid.OptionsView.ShowFilterSeparatorBar = False
			Me.profitGrid.OptionsView.ShowRowGrandTotalHeader = False
			Me.profitGrid.OptionsView.ShowRowGrandTotals = False
			Me.profitGrid.OptionsView.ShowRowTotals = False
			Me.profitGrid.Size = New System.Drawing.Size(336, 588)
			Me.profitGrid.TabIndex = 9
'			Me.profitGrid.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.profitGrid_MouseMove);
'			Me.profitGrid.FieldTooltipShowing += New DevExpress.XtraPivotGrid.PivotFieldTooltipShowingEventHandler(Me.profitGrid_FieldTooltipShowing);
'			Me.profitGrid.FocusedCellChanged += New System.EventHandler(Me.profitGrid_FocusedCellChanged);
'			Me.profitGrid.FieldExpandedInFieldGroupChanged += New DevExpress.XtraPivotGrid.PivotFieldEventHandler(Me.profitGrid_FieldExpandedInFieldGroupChanged);
'			Me.profitGrid.CellSelectionChanged += New System.EventHandler(Me.profitGrid_CellSelectionChanged);
			' 
			' rentsCollection
			' 
			Me.rentsCollection.ObjectType = GetType(DevExpress.VideoRent.Rent)
'			Me.rentsCollection.ResolveSession += New DevExpress.Xpo.ResolveSessionEventHandler(Me.rentsCollection_ResolveSession);
			' 
			' fieldMovie
			' 
			Me.fieldMovie.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldMovie.AreaIndex = 0
			Me.fieldMovie.Caption = "Movie"
			Me.fieldMovie.FieldName = "Movie!"
			Me.fieldMovie.Name = "fieldMovie"
			Me.fieldMovie.SortBySummaryInfo.Field = Me.fieldPayment
			Me.fieldMovie.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
			Me.fieldMovie.Width = 115
			' 
			' profitChart
			' 
			xyDiagram1.AxisX.GridLines.MinorVisible = True
			xyDiagram1.AxisX.GridLines.Visible = True
			xyDiagram1.AxisX.Label.Staggered = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.GridLines.MinorVisible = True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.profitChart.Diagram = xyDiagram1
			Me.profitChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
			Me.profitChart.Location = New System.Drawing.Point(353, 8)
			Me.profitChart.Name = "profitChart"
			Me.profitChart.RefreshDataOnRepaint = False
			Me.profitChart.RuntimeHitTesting = False
			Me.profitChart.SeriesDataMember = "Series"
			Me.profitChart.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.profitChart.SeriesTemplate.ArgumentDataMember = "Arguments"
			Me.profitChart.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            pointSeriesLabel1.LineVisibility = Utils.DefaultBoolean.True
            Me.profitChart.SeriesTemplate.Label = pointSeriesLabel1
			Me.profitChart.SeriesTemplate.LabelsVisibility = Utils.DefaultBoolean.False
			Me.profitChart.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.profitChart.SeriesTemplate.View = splineSeriesView1
			Me.profitChart.Size = New System.Drawing.Size(618, 588)
			Me.profitChart.TabIndex = 5
			chartTitle1.Text = "Revenue from Movies"
			Me.profitChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "Root"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.lciChartProfit, Me.splitterItem1})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "lcgMain"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6)
			Me.lcgMain.Size = New System.Drawing.Size(979, 604)
			Me.lcgMain.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Text = "lcgMain"
			Me.lcgMain.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.profitGrid
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Size = New System.Drawing.Size(340, 592)
			Me.layoutControlItem1.Text = "layoutControlItem1"
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextToControlDistance = 0
			Me.layoutControlItem1.TextVisible = False
			' 
			' lciChartProfit
			' 
			Me.lciChartProfit.Control = Me.profitChart
			Me.lciChartProfit.CustomizationFormText = "lciChartProfit"
			Me.lciChartProfit.Location = New System.Drawing.Point(345, 0)
			Me.lciChartProfit.Name = "lciChartProfit"
			Me.lciChartProfit.Size = New System.Drawing.Size(622, 592)
			Me.lciChartProfit.Text = "lciChartProfit"
			Me.lciChartProfit.TextSize = New System.Drawing.Size(0, 0)
			Me.lciChartProfit.TextToControlDistance = 0
			Me.lciChartProfit.TextVisible = False
			' 
			' splitterItem1
			' 
			Me.splitterItem1.AllowHotTrack = True
			Me.splitterItem1.CustomizationFormText = "splitterItem1"
			Me.splitterItem1.Location = New System.Drawing.Point(340, 0)
			Me.splitterItem1.Name = "splitterItem1"
			Me.splitterItem1.Size = New System.Drawing.Size(5, 592)
			' 
			' colIcon
			' 
			Me.colIcon.AutoFillDown = True
			Me.colIcon.Caption = "Icon"
			Me.colIcon.FieldName = "PhotoExist"
			Me.colIcon.Name = "colIcon"
			Me.colIcon.OptionsColumn.AllowEdit = False
			Me.colIcon.OptionsColumn.AllowFocus = False
			Me.colIcon.OptionsColumn.AllowSize = False
			Me.colIcon.OptionsColumn.FixedWidth = True
			Me.colIcon.OptionsColumn.ReadOnly = True
			Me.colIcon.RowCount = 2
			Me.colIcon.Visible = True
			Me.colIcon.Width = 40
			' 
			' colTitle
			' 
			Me.colTitle.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.colTitle.AppearanceCell.Options.UseFont = True
			Me.colTitle.FieldName = "Title"
			Me.colTitle.Name = "colTitle"
			Me.colTitle.OptionsColumn.AllowFocus = False
			Me.colTitle.OptionsColumn.ReadOnly = True
			Me.colTitle.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
			Me.colTitle.Visible = True
			Me.colTitle.Width = 157
			' 
			' colReleaseDate
			' 
			Me.colReleaseDate.FieldName = "ReleaseDate"
			Me.colReleaseDate.Name = "colReleaseDate"
			Me.colReleaseDate.OptionsColumn.AllowFocus = False
			Me.colReleaseDate.OptionsColumn.ReadOnly = True
			Me.colReleaseDate.RowIndex = 1
			Me.colReleaseDate.Visible = True
			Me.colReleaseDate.Width = 157
			' 
			' colCheck
			' 
			Me.colCheck.Caption = "Check"
			Me.colCheck.FieldName = "Check"
			Me.colCheck.Name = "colCheck"
			Me.colCheck.RowCount = 2
			Me.colCheck.UnboundType = DevExpress.Data.UnboundColumnType.Boolean
			Me.colCheck.Visible = True
			Me.colCheck.Width = 32
			' 
			' colInfo
			' 
			Me.colInfo.FieldName = "Info"
			Me.colInfo.Name = "colInfo"
			Me.colInfo.UnboundType = DevExpress.Data.UnboundColumnType.String
			Me.colInfo.Visible = True
			' 
			' gridBand3
			' 
			Me.gridBand3.Caption = "Data1"
			Me.gridBand3.Columns.Add(Me.colTitle)
			Me.gridBand3.Columns.Add(Me.colReleaseDate)
			Me.gridBand3.MinWidth = 20
			Me.gridBand3.Name = "gridBand3"
			Me.gridBand3.Width = 157
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "Image"
			Me.gridBand2.Columns.Add(Me.colIcon)
			Me.gridBand2.MinWidth = 20
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.OptionsBand.FixedWidth = True
			Me.gridBand2.Width = 40
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "Check"
			Me.gridBand1.Columns.Add(Me.colCheck)
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.OptionsBand.FixedWidth = True
			Me.gridBand1.Width = 32
			' 
			' MoviesKPI
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl1)
			Me.Name = "MoviesKPI"
			Me.Size = New System.Drawing.Size(979, 604)
'			Me.Load += New System.EventHandler(Me.MovieKPI_Load);
			CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			CType(Me.profitGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.rentsCollection, System.ComponentModel.ISupportInitialize).EndInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(splineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.profitChart, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lciChartProfit, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
		Private lcgMain As DevExpress.XtraLayout.LayoutControlGroup
        Private profitChart As DevExpress.XtraCharts.ChartControl
		Private lciChartProfit As DevExpress.XtraLayout.LayoutControlItem
		Private splitterItem1 As DevExpress.XtraLayout.SplitterItem
		Private WithEvents profitGrid As DevExpress.XtraPivotGrid.PivotGridControl
		Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
		Private colIcon As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colReleaseDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCheck As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colInfo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private WithEvents rentsCollection As DevExpress.Xpo.XPCollection
		Private fieldMovie As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldPayment As DevExpress.XtraPivotGrid.PivotGridField
		Private Year As DevExpress.XtraPivotGrid.PivotGridField
		Private Quarter As DevExpress.XtraPivotGrid.PivotGridField
		Private Month As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace
