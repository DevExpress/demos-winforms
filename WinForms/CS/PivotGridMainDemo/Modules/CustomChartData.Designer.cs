namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class CustomChartData{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.comboChartType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl1layoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkShowPointLabels = new DevExpress.XtraEditors.CheckEdit();
            this.seCellZeroValueThreshold = new DevExpress.XtraEditors.SpinEdit();
            this.cbRowFieldValuesExportRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupControl1item = new DevExpress.XtraLayout.LayoutControlGroup();
            this.seCellZeroValueThresholditem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbRowFieldValuesExportRuleitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2item = new DevExpress.XtraLayout.LayoutControlGroup();
            this.checkShowPointLabelsitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.comboChartType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1layoutControl1ConvertedLayout)).BeginInit();
            this.panelControl1layoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPointLabels.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCellZeroValueThreshold.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRowFieldValuesExportRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCellZeroValueThresholditem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRowFieldValuesExportRuleitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPointLabelsitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fieldYear
            // 
            this.fieldYear.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            this.fieldYear.FieldName = "OrderDate";
            this.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.Name = "fieldYear";
            this.fieldYear.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            this.fieldYear.Options.ShowCustomTotals = false;
            this.fieldYear.Options.ShowGrandTotal = false;
            this.fieldYear.Options.ShowTotals = false;
            this.fieldYear.UnboundFieldName = "fieldYear";
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldQuarter.AreaIndex = 1;
            this.fieldQuarter.Caption = "Quarter";
            this.fieldQuarter.FieldName = "OrderDate";
            this.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldQuarter.Name = "fieldQuarter";
            this.fieldQuarter.Options.ShowCustomTotals = false;
            this.fieldQuarter.Options.ShowGrandTotal = false;
            this.fieldQuarter.Options.ShowTotals = false;
            this.fieldQuarter.UnboundFieldName = "fieldQuarter";
            this.fieldQuarter.ValueFormat.FormatString = "Qtr {0}";
            this.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldMonth
            // 
            this.fieldMonth.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
            this.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMonth.AreaIndex = 2;
            this.fieldMonth.Caption = "Month";
            this.fieldMonth.FieldName = "OrderDate";
            this.fieldMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldMonth.Name = "fieldMonth";
            this.fieldMonth.Options.AllowExpand = DevExpress.Utils.DefaultBoolean.False;
            this.fieldMonth.Options.ShowCustomTotals = false;
            this.fieldMonth.Options.ShowGrandTotal = false;
            this.fieldMonth.Options.ShowTotals = false;
            this.fieldMonth.UnboundFieldName = "fieldMonth";
            // 
            // comboChartType
            // 
            this.comboChartType.EditValue = "Line";
            this.comboChartType.Location = new System.Drawing.Point(11, 180);
            this.comboChartType.Name = "comboChartType";
            this.comboChartType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboChartType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboChartType.Size = new System.Drawing.Size(177, 20);
            this.comboChartType.StyleController = this.panelControl1layoutControl1ConvertedLayout;
            this.comboChartType.TabIndex = 21;
            this.comboChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit2_SelectedIndexChanged);
            // 
            // panelControl1layoutControl1ConvertedLayout
            // 
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.comboChartType);
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.labelControl1);
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.checkShowPointLabels);
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.seCellZeroValueThreshold);
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.cbRowFieldValuesExportRule);
            this.panelControl1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1layoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.panelControl1layoutControl1ConvertedLayout.Name = "panelControl1layoutControl1ConvertedLayout";
            this.panelControl1layoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(550, 395, 1079, 633);
            this.panelControl1layoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.panelControl1layoutControl1ConvertedLayout.Size = new System.Drawing.Size(199, 443);
            this.panelControl1layoutControl1ConvertedLayout.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 110);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.StyleController = this.panelControl1layoutControl1ConvertedLayout;
            this.labelControl1.TabIndex = 26;
            this.labelControl1.Text = "As Zero Values";
            // 
            // checkShowPointLabels
            // 
            this.checkShowPointLabels.Location = new System.Drawing.Point(11, 204);
            this.checkShowPointLabels.Name = "checkShowPointLabels";
            this.checkShowPointLabels.Properties.Caption = "Show Point Labels";
            this.checkShowPointLabels.Size = new System.Drawing.Size(177, 19);
            this.checkShowPointLabels.StyleController = this.panelControl1layoutControl1ConvertedLayout;
            this.checkShowPointLabels.TabIndex = 22;
            this.checkShowPointLabels.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // seCellZeroValueThreshold
            // 
            this.seCellZeroValueThreshold.EditValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.seCellZeroValueThreshold.Location = new System.Drawing.Point(11, 86);
            this.seCellZeroValueThreshold.Name = "seCellZeroValueThreshold";
            this.seCellZeroValueThreshold.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seCellZeroValueThreshold.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seCellZeroValueThreshold.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seCellZeroValueThreshold.Properties.IsFloatValue = false;
            this.seCellZeroValueThreshold.Properties.Mask.EditMask = "N00";
            this.seCellZeroValueThreshold.Size = new System.Drawing.Size(177, 20);
            this.seCellZeroValueThreshold.StyleController = this.panelControl1layoutControl1ConvertedLayout;
            this.seCellZeroValueThreshold.TabIndex = 25;
            this.seCellZeroValueThreshold.EditValueChanged += new System.EventHandler(this.seCellZeroValueThreshold_EditValueChanged);
            // 
            // cbRowFieldValuesExportRule
            // 
            this.cbRowFieldValuesExportRule.EditValue = "";
            this.cbRowFieldValuesExportRule.Location = new System.Drawing.Point(11, 46);
            this.cbRowFieldValuesExportRule.Name = "cbRowFieldValuesExportRule";
            this.cbRowFieldValuesExportRule.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRowFieldValuesExportRule.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbRowFieldValuesExportRule.Size = new System.Drawing.Size(177, 20);
            this.cbRowFieldValuesExportRule.StyleController = this.panelControl1layoutControl1ConvertedLayout;
            this.cbRowFieldValuesExportRule.TabIndex = 22;
            this.cbRowFieldValuesExportRule.SelectedIndexChanged += new System.EventHandler(this.cbRowFieldValuesExportRule_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupControl1item,
            this.groupControl2item,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(199, 443);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // groupControl1item
            // 
            this.groupControl1item.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1item.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.seCellZeroValueThresholditem,
            this.cbRowFieldValuesExportRuleitem,
            this.layoutControlItem1});
            this.groupControl1item.Location = new System.Drawing.Point(0, 0);
            this.groupControl1item.Name = "groupControl1item";
            this.groupControl1item.Size = new System.Drawing.Size(199, 134);
            this.groupControl1item.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.groupControl1item.Text = "Pivot Grid Settings";
            // 
            // seCellZeroValueThresholditem
            // 
            this.seCellZeroValueThresholditem.Control = this.seCellZeroValueThreshold;
            this.seCellZeroValueThresholditem.Location = new System.Drawing.Point(0, 40);
            this.seCellZeroValueThresholditem.Name = "seCellZeroValueThresholditem";
            this.seCellZeroValueThresholditem.Size = new System.Drawing.Size(181, 40);
            this.seCellZeroValueThresholditem.Text = "Export Cell Values Less than:";
            this.seCellZeroValueThresholditem.TextLocation = DevExpress.Utils.Locations.Top;
            this.seCellZeroValueThresholditem.TextSize = new System.Drawing.Size(143, 13);
            // 
            // cbRowFieldValuesExportRuleitem
            // 
            this.cbRowFieldValuesExportRuleitem.Control = this.cbRowFieldValuesExportRule;
            this.cbRowFieldValuesExportRuleitem.Location = new System.Drawing.Point(0, 0);
            this.cbRowFieldValuesExportRuleitem.Name = "cbRowFieldValuesExportRuleitem";
            this.cbRowFieldValuesExportRuleitem.Size = new System.Drawing.Size(181, 40);
            this.cbRowFieldValuesExportRuleitem.Text = "Row Field Values Export Rule:";
            this.cbRowFieldValuesExportRuleitem.TextLocation = DevExpress.Utils.Locations.Top;
            this.cbRowFieldValuesExportRuleitem.TextSize = new System.Drawing.Size(143, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(181, 17);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // groupControl2item
            // 
            this.groupControl2item.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl2item.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.checkShowPointLabelsitem});
            this.groupControl2item.Location = new System.Drawing.Point(0, 134);
            this.groupControl2item.Name = "groupControl2item";
            this.groupControl2item.Size = new System.Drawing.Size(199, 100);
            this.groupControl2item.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.groupControl2item.Text = "Chart Settings";
            // 
            // checkShowPointLabelsitem
            // 
            this.checkShowPointLabelsitem.Control = this.checkShowPointLabels;
            this.checkShowPointLabelsitem.Location = new System.Drawing.Point(0, 40);
            this.checkShowPointLabelsitem.Name = "checkShowPointLabelsitem";
            this.checkShowPointLabelsitem.Size = new System.Drawing.Size(181, 23);
            this.checkShowPointLabelsitem.TextSize = new System.Drawing.Size(0, 0);
            this.checkShowPointLabelsitem.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.comboChartType;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(181, 40);
            this.layoutControlItem2.Text = "Chart Type:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(143, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 234);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(199, 209);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.pivotGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.chartControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(507, 470);
            this.splitContainerControl1.SplitterPosition = 164;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.ActiveFilterString = "";
            this.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldExtendedPrice,
            this.fieldMonth,
            this.fieldYear,
            this.fieldProductName,
            this.fieldQuarter});
            pivotGridGroup1.Caption = "DateTimeFields";
            pivotGridGroup1.Fields.Add(this.fieldYear);
            pivotGridGroup1.Fields.Add(this.fieldQuarter);
            pivotGridGroup1.Fields.Add(this.fieldMonth);
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup1.ShowNewValues = true;
            this.pivotGridControl.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings;
            this.pivotGridControl.OptionsChartDataSource.FieldValuesProvideMode = DevExpress.XtraPivotGrid.PivotChartFieldValuesProvideMode.Value;
            this.pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = false;
            this.pivotGridControl.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl.OptionsView.ShowRowTotals = false;
            this.pivotGridControl.Size = new System.Drawing.Size(507, 301);
            this.pivotGridControl.TabIndex = 20;
            this.pivotGridControl.CustomChartDataSourceData += new DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventHandler(this.pivotGridControl1_CustomChartDataSourceData);
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            this.fieldCategoryName.Options.ShowCustomTotals = false;
            this.fieldCategoryName.Options.ShowGrandTotal = false;
            this.fieldCategoryName.Options.ShowTotals = false;
            this.fieldCategoryName.Width = 155;
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.CellFormat.FormatString = "c";
            this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            this.fieldExtendedPrice.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldProductName
            // 
            this.fieldProductName.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "ProductName";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            // 
            // chartControl
            // 
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year;
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.MaxHorizontalPercentage = 30D;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesDataMember = "Series";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl.SeriesTemplate.ArgumentDataMember = "Arguments";
            this.chartControl.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            this.chartControl.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:c}";
            pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl.SeriesTemplate.Label = pointSeriesLabel1;
            this.chartControl.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.SeriesTemplate.SeriesDataMember = "Series";
            this.chartControl.SeriesTemplate.ValueDataMembersSerializable = "Values";
            this.chartControl.SeriesTemplate.View = lineSeriesView1;
            this.chartControl.Size = new System.Drawing.Size(507, 164);
            this.chartControl.TabIndex = 30;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(507, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(200, 470);
            this.sidePanel1.TabIndex = 21;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.Default;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(199, 470);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(199, 470);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.panelControl1layoutControl1ConvertedLayout);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(199, 443);
            // 
            // CustomChartData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "CustomChartData";
            this.Size = new System.Drawing.Size(707, 470);
            ((System.ComponentModel.ISupportInitialize)(this.comboChartType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1layoutControl1ConvertedLayout)).EndInit();
            this.panelControl1layoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPointLabels.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCellZeroValueThreshold.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRowFieldValuesExportRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCellZeroValueThresholditem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRowFieldValuesExportRuleitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowPointLabelsitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private PivotGridControl pivotGridControl;
        private PivotGridField fieldCategoryName;
        private PivotGridField fieldExtendedPrice;
        private PivotGridField fieldMonth;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private PivotGridField fieldYear;
        private PivotGridField fieldProductName;
        private PivotGridField fieldQuarter;
        private DevExpress.XtraEditors.CheckEdit checkShowPointLabels;
        private DevExpress.XtraEditors.ComboBoxEdit comboChartType;
        private DevExpress.XtraEditors.ComboBoxEdit cbRowFieldValuesExportRule;
        private DevExpress.XtraEditors.SpinEdit seCellZeroValueThreshold;
        private XtraLayout.LayoutControl panelControl1layoutControl1ConvertedLayout;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlGroup groupControl1item;
        private XtraLayout.LayoutControlItem seCellZeroValueThresholditem;
        private XtraLayout.LayoutControlItem cbRowFieldValuesExportRuleitem;
        private XtraLayout.LayoutControlGroup groupControl2item;
        private XtraLayout.LayoutControlItem checkShowPointLabelsitem;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.Converter.LayoutConverter layoutConverter1;
        private XtraEditors.LabelControl labelControl1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
