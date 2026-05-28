Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class ChartGeneralOptions

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim pointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Me.seUpdateDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.panelControl1layoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.comboChartType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.ceShowRowGrandTotals = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowColumnGrandTotals = New DevExpress.XtraEditors.CheckEdit()
            Me.ceSelectionOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.ceChartDataVertical = New DevExpress.XtraEditors.CheckEdit()
            Me.checkShowPointLabels = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.comboChartTypeitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ceShowColumnGrandTotalsitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ceShowRowGrandTotalsitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ceChartDataVerticalitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ceSelectionOnlyitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.seUpdateDelayitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.checkShowPointLabelsitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.seUpdateDelay.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1layoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1layoutControl1ConvertedLayout.SuspendLayout()
            CType((Me.comboChartType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowRowGrandTotals.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowColumnGrandTotals.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceSelectionOnly.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceChartDataVertical.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkShowPointLabels.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboChartTypeitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowColumnGrandTotalsitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowRowGrandTotalsitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceChartDataVerticalitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceSelectionOnlyitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seUpdateDelayitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkShowPointLabelsitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chartControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' seUpdateDelay
            ' 
            Me.seUpdateDelay.EditValue = New Decimal(New Integer() {500, 0, 0, 0})
            Me.seUpdateDelay.Location = New System.Drawing.Point(84, 170)
            Me.seUpdateDelay.Name = "seUpdateDelay"
            Me.seUpdateDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seUpdateDelay.Properties.Increment = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seUpdateDelay.Properties.IsFloatValue = False
            Me.seUpdateDelay.Properties.Mask.EditMask = "N00"
            Me.seUpdateDelay.Properties.MaxValue = New Decimal(New Integer() {5000, 0, 0, 0})
            Me.seUpdateDelay.Size = New System.Drawing.Size(103, 20)
            Me.seUpdateDelay.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.seUpdateDelay.TabIndex = 10
            Me.seUpdateDelay.ToolTip = "Sets the Chart update delay when PivotGrid selection changes."
            AddHandler Me.seUpdateDelay.EditValueChanged, New System.EventHandler(AddressOf Me.seUpdateDelay_EditValueChanged)
            ' 
            ' panelControl1layoutControl1ConvertedLayout
            ' 
            Me.panelControl1layoutControl1ConvertedLayout.AllowCustomization = False
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.seUpdateDelay)
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.comboChartType)
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.ceShowRowGrandTotals)
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.ceShowColumnGrandTotals)
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.ceSelectionOnly)
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.ceChartDataVertical)
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.checkShowPointLabels)
            Me.panelControl1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1layoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1layoutControl1ConvertedLayout.Name = "panelControl1layoutControl1ConvertedLayout"
            Me.panelControl1layoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(619, 391, 896, 593)
            Me.panelControl1layoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            Me.panelControl1layoutControl1ConvertedLayout.Size = New System.Drawing.Size(199, 443)
            Me.panelControl1layoutControl1ConvertedLayout.TabIndex = 6
            ' 
            ' comboChartType
            ' 
            Me.comboChartType.EditValue = "Line"
            Me.comboChartType.Location = New System.Drawing.Point(84, 31)
            Me.comboChartType.Name = "comboChartType"
            Me.comboChartType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboChartType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboChartType.Size = New System.Drawing.Size(103, 20)
            Me.comboChartType.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.comboChartType.TabIndex = 3
            AddHandler Me.comboChartType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEdit2_SelectedIndexChanged)
            ' 
            ' ceShowRowGrandTotals
            ' 
            Me.ceShowRowGrandTotals.EditValue = True
            Me.ceShowRowGrandTotals.Location = New System.Drawing.Point(12, 101)
            Me.ceShowRowGrandTotals.Name = "ceShowRowGrandTotals"
            Me.ceShowRowGrandTotals.Properties.AutoWidth = True
            Me.ceShowRowGrandTotals.Properties.Caption = "Show Row Grand Totals"
            Me.ceShowRowGrandTotals.Size = New System.Drawing.Size(136, 19)
            Me.ceShowRowGrandTotals.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.ceShowRowGrandTotals.TabIndex = 7
            Me.ceShowRowGrandTotals.ToolTip = "Toggles whether row grand total values are shown in the Chart control"
            AddHandler Me.ceShowRowGrandTotals.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowRowGrandTotals_CheckedChanged)
            ' 
            ' ceShowColumnGrandTotals
            ' 
            Me.ceShowColumnGrandTotals.Location = New System.Drawing.Point(12, 78)
            Me.ceShowColumnGrandTotals.Name = "ceShowColumnGrandTotals"
            Me.ceShowColumnGrandTotals.Properties.AutoWidth = True
            Me.ceShowColumnGrandTotals.Properties.Caption = "Show Column Grand Totals"
            Me.ceShowColumnGrandTotals.Size = New System.Drawing.Size(150, 19)
            Me.ceShowColumnGrandTotals.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.ceShowColumnGrandTotals.TabIndex = 13
            Me.ceShowColumnGrandTotals.ToolTip = "Toggles whether column grand total values are shown in the Chart control"
            AddHandler Me.ceShowColumnGrandTotals.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowColumnGrandTotals_CheckedChanged)
            ' 
            ' ceSelectionOnly
            ' 
            Me.ceSelectionOnly.EditValue = True
            Me.ceSelectionOnly.Location = New System.Drawing.Point(12, 147)
            Me.ceSelectionOnly.Name = "ceSelectionOnly"
            Me.ceSelectionOnly.Properties.AutoWidth = True
            Me.ceSelectionOnly.Properties.Caption = "Selection Only"
            Me.ceSelectionOnly.Size = New System.Drawing.Size(90, 19)
            Me.ceSelectionOnly.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.ceSelectionOnly.TabIndex = 9
            Me.ceSelectionOnly.ToolTip = "Toggles whether all PivotGrid cells or selected cells only should be represented " & "in the Chart"
            AddHandler Me.ceSelectionOnly.CheckedChanged, New System.EventHandler(AddressOf Me.ceSelectionOnly_CheckedChanged)
            ' 
            ' ceChartDataVertical
            ' 
            Me.ceChartDataVertical.Location = New System.Drawing.Point(12, 124)
            Me.ceChartDataVertical.Name = "ceChartDataVertical"
            Me.ceChartDataVertical.Properties.AutoWidth = True
            Me.ceChartDataVertical.Properties.Caption = "Generate Series from Columns"
            Me.ceChartDataVertical.Size = New System.Drawing.Size(167, 19)
            Me.ceChartDataVertical.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.ceChartDataVertical.TabIndex = 12
            Me.ceChartDataVertical.ToolTip = "Toggles whether series in a chart control are created based on PivotGrid columns " & "or rows"
            AddHandler Me.ceChartDataVertical.CheckedChanged, New System.EventHandler(AddressOf Me.ceChartDataVertical_CheckedChanged)
            ' 
            ' checkShowPointLabels
            ' 
            Me.checkShowPointLabels.Location = New System.Drawing.Point(12, 55)
            Me.checkShowPointLabels.Name = "checkShowPointLabels"
            Me.checkShowPointLabels.Properties.AutoWidth = True
            Me.checkShowPointLabels.Properties.Caption = "Show Point Labels"
            Me.checkShowPointLabels.Size = New System.Drawing.Size(108, 19)
            Me.checkShowPointLabels.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.checkShowPointLabels.TabIndex = 4
            Me.checkShowPointLabels.ToolTip = "Toggles whether value labels are shown in the Chart control"
            AddHandler Me.checkShowPointLabels.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit1_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 443)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.comboChartTypeitem, Me.ceShowColumnGrandTotalsitem, Me.ceShowRowGrandTotalsitem, Me.ceChartDataVerticalitem, Me.ceSelectionOnlyitem, Me.seUpdateDelayitem, Me.emptySpaceItem1, Me.checkShowPointLabelsitem})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 443)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Chart Settings"
            ' 
            ' comboChartTypeitem
            ' 
            Me.comboChartTypeitem.Control = Me.comboChartType
            Me.comboChartTypeitem.Location = New System.Drawing.Point(0, 0)
            Me.comboChartTypeitem.Name = "comboChartTypeitem"
            Me.comboChartTypeitem.Size = New System.Drawing.Size(179, 24)
            Me.comboChartTypeitem.Text = "Chart Type:"
            Me.comboChartTypeitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.comboChartTypeitem.TextSize = New System.Drawing.Size(69, 13)
            ' 
            ' ceShowColumnGrandTotalsitem
            ' 
            Me.ceShowColumnGrandTotalsitem.Control = Me.ceShowColumnGrandTotals
            Me.ceShowColumnGrandTotalsitem.Location = New System.Drawing.Point(0, 47)
            Me.ceShowColumnGrandTotalsitem.Name = "ceShowColumnGrandTotalsitem"
            Me.ceShowColumnGrandTotalsitem.Size = New System.Drawing.Size(179, 23)
            Me.ceShowColumnGrandTotalsitem.TextSize = New System.Drawing.Size(0, 0)
            Me.ceShowColumnGrandTotalsitem.TextVisible = False
            ' 
            ' ceShowRowGrandTotalsitem
            ' 
            Me.ceShowRowGrandTotalsitem.Control = Me.ceShowRowGrandTotals
            Me.ceShowRowGrandTotalsitem.Location = New System.Drawing.Point(0, 70)
            Me.ceShowRowGrandTotalsitem.Name = "ceShowRowGrandTotalsitem"
            Me.ceShowRowGrandTotalsitem.Size = New System.Drawing.Size(179, 23)
            Me.ceShowRowGrandTotalsitem.TextSize = New System.Drawing.Size(0, 0)
            Me.ceShowRowGrandTotalsitem.TextVisible = False
            ' 
            ' ceChartDataVerticalitem
            ' 
            Me.ceChartDataVerticalitem.Control = Me.ceChartDataVertical
            Me.ceChartDataVerticalitem.Location = New System.Drawing.Point(0, 93)
            Me.ceChartDataVerticalitem.Name = "ceChartDataVerticalitem"
            Me.ceChartDataVerticalitem.Size = New System.Drawing.Size(179, 23)
            Me.ceChartDataVerticalitem.TextSize = New System.Drawing.Size(0, 0)
            Me.ceChartDataVerticalitem.TextVisible = False
            ' 
            ' ceSelectionOnlyitem
            ' 
            Me.ceSelectionOnlyitem.Control = Me.ceSelectionOnly
            Me.ceSelectionOnlyitem.Location = New System.Drawing.Point(0, 116)
            Me.ceSelectionOnlyitem.Name = "ceSelectionOnlyitem"
            Me.ceSelectionOnlyitem.Size = New System.Drawing.Size(179, 23)
            Me.ceSelectionOnlyitem.TextSize = New System.Drawing.Size(0, 0)
            Me.ceSelectionOnlyitem.TextVisible = False
            ' 
            ' seUpdateDelayitem
            ' 
            Me.seUpdateDelayitem.Control = Me.seUpdateDelay
            Me.seUpdateDelayitem.Location = New System.Drawing.Point(0, 139)
            Me.seUpdateDelayitem.Name = "seUpdateDelayitem"
            Me.seUpdateDelayitem.Size = New System.Drawing.Size(179, 24)
            Me.seUpdateDelayitem.Text = "Update Delay:"
            Me.seUpdateDelayitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.seUpdateDelayitem.TextSize = New System.Drawing.Size(69, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 163)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(179, 241)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' checkShowPointLabelsitem
            ' 
            Me.checkShowPointLabelsitem.Control = Me.checkShowPointLabels
            Me.checkShowPointLabelsitem.Location = New System.Drawing.Point(0, 24)
            Me.checkShowPointLabelsitem.Name = "checkShowPointLabelsitem"
            Me.checkShowPointLabelsitem.Size = New System.Drawing.Size(179, 23)
            Me.checkShowPointLabelsitem.TextSize = New System.Drawing.Size(0, 0)
            Me.checkShowPointLabelsitem.TextVisible = False
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.splitContainerControl1.Horizontal = False
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            Me.splitContainerControl1.Panel1.Controls.Add(Me.pivotGridControl)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            Me.splitContainerControl1.Panel2.Controls.Add(Me.chartControl)
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(490, 470)
            Me.splitContainerControl1.SplitterPosition = 176
            Me.splitContainerControl1.TabIndex = 5
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' pivotGridControl
            ' 
            Me.pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductName, Me.fieldExtendedPrice, Me.fieldOrderDate, Me.fieldOrderYear})
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings
            Me.pivotGridControl.OptionsChartDataSource.MaxAllowedPointCountInSeries = 400
            Me.pivotGridControl.OptionsChartDataSource.MaxAllowedSeriesCount = 20
            Me.pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = False
            Me.pivotGridControl.OptionsChartDataSource.UpdateDelay = 500
            Me.pivotGridControl.Size = New System.Drawing.Size(490, 289)
            Me.pivotGridControl.TabIndex = 2
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 0
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductName")
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Width = 155
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.CellFormat.FormatString = "c"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Extended Price")
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            ' 
            ' fieldOrderDate
            ' 
            Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate.AreaIndex = 0
            Me.fieldOrderDate.Caption = "Order Month"
            Me.fieldOrderDate.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth)
            Me.fieldOrderDate.Name = "fieldOrderDate"
            ' 
            ' fieldOrderYear
            ' 
            Me.fieldOrderYear.AreaIndex = 0
            Me.fieldOrderYear.Caption = "Order Year"
            Me.fieldOrderYear.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear)
            Me.fieldOrderYear.Name = "fieldOrderYear"
            Me.fieldOrderYear.Options.IsFilterRadioMode = DevExpress.Utils.DefaultBoolean.[True]
            ' 
            ' chartControl
            ' 
            Me.chartControl.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.Label.Staggered = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl.Diagram = xyDiagram1
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Legend.MaxHorizontalPercentage = 30R
            Me.chartControl.Legend.Name = "Default Legend"
            Me.chartControl.Location = New System.Drawing.Point(0, 0)
            Me.chartControl.Name = "chartControl"
            Me.chartControl.SeriesDataMember = "Series"
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartControl.SeriesTemplate.ArgumentDataMember = "Arguments"
            Me.chartControl.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:c}"
            pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartControl.SeriesTemplate.Label = pointSeriesLabel1
            Me.chartControl.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl.SeriesTemplate.SeriesDataMember = "Series"
            Me.chartControl.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.chartControl.SeriesTemplate.View = lineSeriesView1
            Me.chartControl.Size = New System.Drawing.Size(490, 176)
            Me.chartControl.TabIndex = 3
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(490, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 470)
            Me.sidePanel1.TabIndex = 3
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 470)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 470)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.panelControl1layoutControl1ConvertedLayout)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 443)
            ' 
            ' ChartGeneralOptions
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "ChartGeneralOptions"
            Me.Size = New System.Drawing.Size(690, 470)
            CType((Me.seUpdateDelay.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1layoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1layoutControl1ConvertedLayout.ResumeLayout(False)
            CType((Me.comboChartType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowRowGrandTotals.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowColumnGrandTotals.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceSelectionOnly.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceChartDataVertical.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkShowPointLabels.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboChartTypeitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowColumnGrandTotalsitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowRowGrandTotalsitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceChartDataVerticalitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceSelectionOnlyitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seUpdateDelayitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkShowPointLabelsitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private comboChartType As DevExpress.XtraEditors.ComboBoxEdit

        Private checkShowPointLabels As DevExpress.XtraEditors.CheckEdit

        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

        Private pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private chartControl As DevExpress.XtraCharts.ChartControl

        Private ceSelectionOnly As DevExpress.XtraEditors.CheckEdit

        Private ceChartDataVertical As DevExpress.XtraEditors.CheckEdit

        Private ceShowRowGrandTotals As DevExpress.XtraEditors.CheckEdit

        Private ceShowColumnGrandTotals As DevExpress.XtraEditors.CheckEdit

        Private seUpdateDelay As DevExpress.XtraEditors.SpinEdit

        Private panelControl1layoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private seUpdateDelayitem As DevExpress.XtraLayout.LayoutControlItem

        Private comboChartTypeitem As DevExpress.XtraLayout.LayoutControlItem

        Private ceShowRowGrandTotalsitem As DevExpress.XtraLayout.LayoutControlItem

        Private ceShowColumnGrandTotalsitem As DevExpress.XtraLayout.LayoutControlItem

        Private ceSelectionOnlyitem As DevExpress.XtraLayout.LayoutControlItem

        Private ceChartDataVerticalitem As DevExpress.XtraLayout.LayoutControlItem

        Private checkShowPointLabelsitem As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
