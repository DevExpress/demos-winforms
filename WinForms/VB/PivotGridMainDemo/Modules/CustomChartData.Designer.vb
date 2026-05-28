Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class CustomChartData

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
            Me.components = New System.ComponentModel.Container()
            Dim pivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim pointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.comboChartType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.panelControl1layoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.checkShowPointLabels = New DevExpress.XtraEditors.CheckEdit()
            Me.seCellZeroValueThreshold = New DevExpress.XtraEditors.SpinEdit()
            Me.cbRowFieldValuesExportRule = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.groupControl1item = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.seCellZeroValueThresholditem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.cbRowFieldValuesExportRuleitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.groupControl2item = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.checkShowPointLabelsitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
            CType((Me.comboChartType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1layoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1layoutControl1ConvertedLayout.SuspendLayout()
            CType((Me.checkShowPointLabels.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seCellZeroValueThreshold.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbRowFieldValuesExportRule.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl1item), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seCellZeroValueThresholditem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbRowFieldValuesExportRuleitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl2item), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkShowPointLabelsitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
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
            ' fieldYear
            ' 
            Me.fieldYear.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            Me.fieldYear.FieldName = "OrderDate"
            Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.Name = "fieldYear"
            Me.fieldYear.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldYear.Options.ShowCustomTotals = False
            Me.fieldYear.Options.ShowGrandTotal = False
            Me.fieldYear.Options.ShowTotals = False
            Me.fieldYear.UnboundFieldName = "fieldYear"
            ' 
            ' fieldQuarter
            ' 
            Me.fieldQuarter.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea
            Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldQuarter.AreaIndex = 1
            Me.fieldQuarter.Caption = "Quarter"
            Me.fieldQuarter.FieldName = "OrderDate"
            Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldQuarter.Name = "fieldQuarter"
            Me.fieldQuarter.Options.ShowCustomTotals = False
            Me.fieldQuarter.Options.ShowGrandTotal = False
            Me.fieldQuarter.Options.ShowTotals = False
            Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
            Me.fieldQuarter.ValueFormat.FormatString = "Qtr {0}"
            Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' fieldMonth
            ' 
            Me.fieldMonth.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea
            Me.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldMonth.AreaIndex = 2
            Me.fieldMonth.Caption = "Month"
            Me.fieldMonth.FieldName = "OrderDate"
            Me.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldMonth.Name = "fieldMonth"
            Me.fieldMonth.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldMonth.Options.ShowCustomTotals = False
            Me.fieldMonth.Options.ShowGrandTotal = False
            Me.fieldMonth.Options.ShowTotals = False
            Me.fieldMonth.UnboundFieldName = "fieldMonth"
            ' 
            ' comboChartType
            ' 
            Me.comboChartType.EditValue = "Line"
            Me.comboChartType.Location = New System.Drawing.Point(11, 180)
            Me.comboChartType.Name = "comboChartType"
            Me.comboChartType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboChartType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboChartType.Size = New System.Drawing.Size(177, 20)
            Me.comboChartType.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.comboChartType.TabIndex = 21
            AddHandler Me.comboChartType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEdit2_SelectedIndexChanged)
            ' 
            ' panelControl1layoutControl1ConvertedLayout
            ' 
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.comboChartType)
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.labelControl1)
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.checkShowPointLabels)
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.seCellZeroValueThreshold)
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.cbRowFieldValuesExportRule)
            Me.panelControl1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1layoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1layoutControl1ConvertedLayout.Name = "panelControl1layoutControl1ConvertedLayout"
            Me.panelControl1layoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(550, 395, 1079, 633)
            Me.panelControl1layoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            Me.panelControl1layoutControl1ConvertedLayout.Size = New System.Drawing.Size(199, 443)
            Me.panelControl1layoutControl1ConvertedLayout.TabIndex = 22
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(11, 110)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(71, 13)
            Me.labelControl1.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.labelControl1.TabIndex = 26
            Me.labelControl1.Text = "As Zero Values"
            ' 
            ' checkShowPointLabels
            ' 
            Me.checkShowPointLabels.Location = New System.Drawing.Point(11, 204)
            Me.checkShowPointLabels.Name = "checkShowPointLabels"
            Me.checkShowPointLabels.Properties.Caption = "Show Point Labels"
            Me.checkShowPointLabels.Size = New System.Drawing.Size(177, 19)
            Me.checkShowPointLabels.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.checkShowPointLabels.TabIndex = 22
            AddHandler Me.checkShowPointLabels.CheckedChanged, New System.EventHandler(AddressOf Me.checkEdit1_CheckedChanged)
            ' 
            ' seCellZeroValueThreshold
            ' 
            Me.seCellZeroValueThreshold.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seCellZeroValueThreshold.Location = New System.Drawing.Point(11, 86)
            Me.seCellZeroValueThreshold.Name = "seCellZeroValueThreshold"
            Me.seCellZeroValueThreshold.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seCellZeroValueThreshold.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.seCellZeroValueThreshold.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.seCellZeroValueThreshold.Properties.IsFloatValue = False
            Me.seCellZeroValueThreshold.Properties.Mask.EditMask = "N00"
            Me.seCellZeroValueThreshold.Size = New System.Drawing.Size(177, 20)
            Me.seCellZeroValueThreshold.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.seCellZeroValueThreshold.TabIndex = 25
            AddHandler Me.seCellZeroValueThreshold.EditValueChanged, New System.EventHandler(AddressOf Me.seCellZeroValueThreshold_EditValueChanged)
            ' 
            ' cbRowFieldValuesExportRule
            ' 
            Me.cbRowFieldValuesExportRule.EditValue = ""
            Me.cbRowFieldValuesExportRule.Location = New System.Drawing.Point(11, 46)
            Me.cbRowFieldValuesExportRule.Name = "cbRowFieldValuesExportRule"
            Me.cbRowFieldValuesExportRule.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbRowFieldValuesExportRule.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbRowFieldValuesExportRule.Size = New System.Drawing.Size(177, 20)
            Me.cbRowFieldValuesExportRule.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.cbRowFieldValuesExportRule.TabIndex = 22
            AddHandler Me.cbRowFieldValuesExportRule.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbRowFieldValuesExportRule_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.groupControl1item, Me.groupControl2item, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 443)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' groupControl1item
            ' 
            Me.groupControl1item.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupControl1item.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.seCellZeroValueThresholditem, Me.cbRowFieldValuesExportRuleitem, Me.layoutControlItem1})
            Me.groupControl1item.Location = New System.Drawing.Point(0, 0)
            Me.groupControl1item.Name = "groupControl1item"
            Me.groupControl1item.Size = New System.Drawing.Size(199, 134)
            Me.groupControl1item.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupControl1item.Text = "Pivot Grid Settings"
            ' 
            ' seCellZeroValueThresholditem
            ' 
            Me.seCellZeroValueThresholditem.Control = Me.seCellZeroValueThreshold
            Me.seCellZeroValueThresholditem.Location = New System.Drawing.Point(0, 40)
            Me.seCellZeroValueThresholditem.Name = "seCellZeroValueThresholditem"
            Me.seCellZeroValueThresholditem.Size = New System.Drawing.Size(181, 40)
            Me.seCellZeroValueThresholditem.Text = "Export Cell Values Less than:"
            Me.seCellZeroValueThresholditem.TextLocation = DevExpress.Utils.Locations.Top
            Me.seCellZeroValueThresholditem.TextSize = New System.Drawing.Size(143, 13)
            ' 
            ' cbRowFieldValuesExportRuleitem
            ' 
            Me.cbRowFieldValuesExportRuleitem.Control = Me.cbRowFieldValuesExportRule
            Me.cbRowFieldValuesExportRuleitem.Location = New System.Drawing.Point(0, 0)
            Me.cbRowFieldValuesExportRuleitem.Name = "cbRowFieldValuesExportRuleitem"
            Me.cbRowFieldValuesExportRuleitem.Size = New System.Drawing.Size(181, 40)
            Me.cbRowFieldValuesExportRuleitem.Text = "Row Field Values Export Rule:"
            Me.cbRowFieldValuesExportRuleitem.TextLocation = DevExpress.Utils.Locations.Top
            Me.cbRowFieldValuesExportRuleitem.TextSize = New System.Drawing.Size(143, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.labelControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 80)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(181, 17)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' groupControl2item
            ' 
            Me.groupControl2item.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.groupControl2item.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.checkShowPointLabelsitem})
            Me.groupControl2item.Location = New System.Drawing.Point(0, 134)
            Me.groupControl2item.Name = "groupControl2item"
            Me.groupControl2item.Size = New System.Drawing.Size(199, 100)
            Me.groupControl2item.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.groupControl2item.Text = "Chart Settings"
            ' 
            ' checkShowPointLabelsitem
            ' 
            Me.checkShowPointLabelsitem.Control = Me.checkShowPointLabels
            Me.checkShowPointLabelsitem.Location = New System.Drawing.Point(0, 40)
            Me.checkShowPointLabelsitem.Name = "checkShowPointLabelsitem"
            Me.checkShowPointLabelsitem.Size = New System.Drawing.Size(181, 23)
            Me.checkShowPointLabelsitem.TextSize = New System.Drawing.Size(0, 0)
            Me.checkShowPointLabelsitem.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.comboChartType
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(181, 40)
            Me.layoutControlItem2.Text = "Chart Type:"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(143, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 234)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 209)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
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
            Me.splitContainerControl1.Size = New System.Drawing.Size(507, 470)
            Me.splitContainerControl1.SplitterPosition = 164
            Me.splitContainerControl1.TabIndex = 5
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' pivotGridControl
            ' 
            Me.pivotGridControl.ActiveFilterString = ""
            Me.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName, Me.fieldExtendedPrice, Me.fieldMonth, Me.fieldYear, Me.fieldProductName, Me.fieldQuarter})
            pivotGridGroup1.Caption = "DateTimeFields"
            pivotGridGroup1.Fields.Add(Me.fieldYear)
            pivotGridGroup1.Fields.Add(Me.fieldQuarter)
            pivotGridGroup1.Fields.Add(Me.fieldMonth)
            pivotGridGroup1.Hierarchy = Nothing
            pivotGridGroup1.ShowNewValues = True
            Me.pivotGridControl.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {pivotGridGroup1})
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings
            Me.pivotGridControl.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.Value
            Me.pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = False
            Me.pivotGridControl.OptionsView.ShowColumnGrandTotals = False
            Me.pivotGridControl.OptionsView.ShowColumnTotals = False
            Me.pivotGridControl.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl.OptionsView.ShowRowGrandTotals = False
            Me.pivotGridControl.OptionsView.ShowRowTotals = False
            Me.pivotGridControl.Size = New System.Drawing.Size(507, 301)
            Me.pivotGridControl.TabIndex = 20
            AddHandler Me.pivotGridControl.CustomChartDataSourceData, New DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventHandler(AddressOf Me.pivotGridControl1_CustomChartDataSourceData)
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category"
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            Me.fieldCategoryName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldCategoryName.Options.ShowCustomTotals = False
            Me.fieldCategoryName.Options.ShowGrandTotal = False
            Me.fieldCategoryName.Options.ShowTotals = False
            Me.fieldCategoryName.Width = 155
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.CellFormat.FormatString = "c"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice.FieldName = "Extended Price"
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            Me.fieldExtendedPrice.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "ProductName"
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' chartControl
            ' 
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
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
            Me.chartControl.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            Me.chartControl.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:c}"
            pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartControl.SeriesTemplate.Label = pointSeriesLabel1
            Me.chartControl.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl.SeriesTemplate.SeriesDataMember = "Series"
            Me.chartControl.SeriesTemplate.ValueDataMembersSerializable = "Values"
            Me.chartControl.SeriesTemplate.View = lineSeriesView1
            Me.chartControl.Size = New System.Drawing.Size(507, 164)
            Me.chartControl.TabIndex = 30
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(507, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 470)
            Me.sidePanel1.TabIndex = 21
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.[Default]
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
            ' CustomChartData
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "CustomChartData"
            Me.Size = New System.Drawing.Size(707, 470)
            CType((Me.comboChartType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1layoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1layoutControl1ConvertedLayout.ResumeLayout(False)
            CType((Me.checkShowPointLabels.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seCellZeroValueThreshold.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbRowFieldValuesExportRule.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl1item), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seCellZeroValueThresholditem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbRowFieldValuesExportRuleitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl2item), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkShowPointLabelsitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
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
        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

        Private pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldMonth As DevExpress.XtraPivotGrid.PivotGridField

        Private chartControl As DevExpress.XtraCharts.ChartControl

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField

        Private checkShowPointLabels As DevExpress.XtraEditors.CheckEdit

        Private comboChartType As DevExpress.XtraEditors.ComboBoxEdit

        Private cbRowFieldValuesExportRule As DevExpress.XtraEditors.ComboBoxEdit

        Private seCellZeroValueThreshold As DevExpress.XtraEditors.SpinEdit

        Private panelControl1layoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private groupControl1item As DevExpress.XtraLayout.LayoutControlGroup

        Private seCellZeroValueThresholditem As DevExpress.XtraLayout.LayoutControlItem

        Private cbRowFieldValuesExportRuleitem As DevExpress.XtraLayout.LayoutControlItem

        Private groupControl2item As DevExpress.XtraLayout.LayoutControlGroup

        Private checkShowPointLabelsitem As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
