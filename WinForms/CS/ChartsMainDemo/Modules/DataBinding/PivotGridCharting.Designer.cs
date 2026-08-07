namespace DevExpress.XtraCharts.Demos {
    partial class PivotGridChartingDemo {
        System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SeriesTemplateAdapter seriesTemplateAdapter1 = new DevExpress.XtraCharts.SeriesTemplateAdapter();
            DevExpress.XtraCharts.DataMember dataMember1 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember2 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember3 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SeriesKeyColorColorizer seriesKeyColorColorizer1 = new DevExpress.XtraCharts.SeriesKeyColorColorizer();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.checkEditLabelVisible = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditSelectionOnly = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditShowColumnGrandTotal = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditGenerateSeriesByColumns = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditShowRowGrandTotal = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgCommonOptions = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciShowColumnGrandTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciShowRowGrandTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgLabelOptions = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditLabelVisible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSelectionOnly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowColumnGrandTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditGenerateSeriesByColumns.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowRowGrandTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCommonOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciShowColumnGrandTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciShowRowGrandTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgLabelOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPaneOptions
            // 
            this.tabPaneOptions.Margin = new System.Windows.Forms.Padding(2);
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl1);
            this.tabNavigationPageOptions.Margin = new System.Windows.Forms.Padding(4);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(241, 538);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.pivotGridControl);
            this.sidePanel1.Controls.Add(this.sidePanel2);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(546, 571);
            this.sidePanel1.TabIndex = 1;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProductName,
            this.fieldExtendedPrice,
            this.fieldOrderDate,
            this.fieldOrderYear});
            this.pivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.OptionsChartDataSource.DataProvideMode = DevExpress.XtraPivotGrid.PivotChartDataProvideMode.UseCustomSettings;
            this.pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = false;
            this.pivotGridControl.OptionsChartDataSource.UpdateDelay = 500;
            this.pivotGridControl.Size = new System.Drawing.Size(546, 355);
            this.pivotGridControl.TabIndex = 3;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 0;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Width = 155;
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.CellFormat.FormatString = "c";
            this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fieldOrderDate
            // 
            this.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate.AreaIndex = 0;
            this.fieldOrderDate.Caption = "Order Month";
            this.fieldOrderDate.FieldName = "OrderDate";
            this.fieldOrderDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldOrderDate.Name = "fieldOrderDate";
            this.fieldOrderDate.UnboundFieldName = "fieldOrderDate";
            // 
            // fieldOrderYear
            // 
            this.fieldOrderYear.AreaIndex = 0;
            this.fieldOrderYear.Caption = "Order Year";
            this.fieldOrderYear.FieldName = "OrderDate";
            this.fieldOrderYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderYear.Name = "fieldOrderYear";
            this.fieldOrderYear.Options.IsFilterRadioMode = DevExpress.Utils.DefaultBoolean.True;
            this.fieldOrderYear.UnboundFieldName = "pivotGridField1";
            // 
            // sidePanel2
            // 
            this.sidePanel2.AllowResize = false;
            this.sidePanel2.Controls.Add(this.chart);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel2.Location = new System.Drawing.Point(0, 355);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(546, 216);
            this.sidePanel2.TabIndex = 0;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CrosshairOptions.ShowArgumentLine = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.BackColor = System.Drawing.Color.Transparent;
            this.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Legend.MaxHorizontalPercentage = 30D;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 1);
            this.chart.Name = "chart";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.SeriesTemplate.CrosshairLabelPattern = "{S} : {V:c}";
            dataMember1.ColumnName = "Arguments";
            dataMember2.ColumnName = "Values";
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value;
            dataMember3.ColumnName = "Series";
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series;
            seriesTemplateAdapter1.DataMembers.AddRange(new DevExpress.XtraCharts.DataMember[] {
            dataMember1,
            dataMember2,
            dataMember3});
            this.chart.SeriesTemplate.DataAdapter = seriesTemplateAdapter1;
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chart.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer1;
            this.chart.Size = new System.Drawing.Size(546, 215);
            this.chart.TabIndex = 4;
            this.chart.BoundDataChanged += new DevExpress.XtraCharts.BoundDataChangedEventHandler(this.chart_BoundDataChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.checkEditLabelVisible);
            this.layoutControl1.Controls.Add(this.checkEditSelectionOnly);
            this.layoutControl1.Controls.Add(this.checkEditShowColumnGrandTotal);
            this.layoutControl1.Controls.Add(this.checkEditGenerateSeriesByColumns);
            this.layoutControl1.Controls.Add(this.checkEditShowRowGrandTotal);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(941, 150, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(241, 538);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // checkEditLabelVisible
            // 
            this.checkEditLabelVisible.Location = new System.Drawing.Point(12, 172);
            this.checkEditLabelVisible.Name = "checkEditLabelVisible";
            this.checkEditLabelVisible.Properties.Caption = "Visible";
            this.checkEditLabelVisible.Size = new System.Drawing.Size(217, 20);
            this.checkEditLabelVisible.StyleController = this.layoutControl1;
            this.checkEditLabelVisible.TabIndex = 4;
            this.checkEditLabelVisible.CheckedChanged += new System.EventHandler(this.checkEditLabelVisible_CheckedChanged);
            // 
            // checkEditSelectionOnly
            // 
            this.checkEditSelectionOnly.EditValue = true;
            this.checkEditSelectionOnly.Location = new System.Drawing.Point(12, 34);
            this.checkEditSelectionOnly.Name = "checkEditSelectionOnly";
            this.checkEditSelectionOnly.Properties.Caption = "Selection Only";
            this.checkEditSelectionOnly.Size = new System.Drawing.Size(217, 20);
            this.checkEditSelectionOnly.StyleController = this.layoutControl1;
            this.checkEditSelectionOnly.TabIndex = 17;
            this.checkEditSelectionOnly.CheckedChanged += new System.EventHandler(this.checkEditSelectionOnly_CheckedChanged);
            // 
            // checkEditShowColumnGrandTotal
            // 
            this.checkEditShowColumnGrandTotal.Location = new System.Drawing.Point(12, 106);
            this.checkEditShowColumnGrandTotal.Name = "checkEditShowColumnGrandTotal";
            this.checkEditShowColumnGrandTotal.Properties.Caption = "Show Column Grand Total";
            this.checkEditShowColumnGrandTotal.Size = new System.Drawing.Size(217, 20);
            this.checkEditShowColumnGrandTotal.StyleController = this.layoutControl1;
            this.checkEditShowColumnGrandTotal.TabIndex = 18;
            this.checkEditShowColumnGrandTotal.CheckedChanged += new System.EventHandler(this.checkEditShowColumnGrandTotals_CheckedChanged);
            // 
            // checkEditGenerateSeriesByColumns
            // 
            this.checkEditGenerateSeriesByColumns.Location = new System.Drawing.Point(12, 58);
            this.checkEditGenerateSeriesByColumns.Name = "checkEditGenerateSeriesByColumns";
            this.checkEditGenerateSeriesByColumns.Properties.Caption = "Generate Series by Columns";
            this.checkEditGenerateSeriesByColumns.Size = new System.Drawing.Size(217, 20);
            this.checkEditGenerateSeriesByColumns.StyleController = this.layoutControl1;
            this.checkEditGenerateSeriesByColumns.TabIndex = 19;
            this.checkEditGenerateSeriesByColumns.CheckedChanged += new System.EventHandler(this.checkEditGenerateSeriesByColumns_CheckedChanged);
            // 
            // checkEditShowRowGrandTotal
            // 
            this.checkEditShowRowGrandTotal.Location = new System.Drawing.Point(12, 82);
            this.checkEditShowRowGrandTotal.Name = "checkEditShowRowGrandTotal";
            this.checkEditShowRowGrandTotal.Properties.Caption = "Show Row Grand Total";
            this.checkEditShowRowGrandTotal.Size = new System.Drawing.Size(217, 20);
            this.checkEditShowRowGrandTotal.StyleController = this.layoutControl1;
            this.checkEditShowRowGrandTotal.TabIndex = 20;
            this.checkEditShowRowGrandTotal.CheckedChanged += new System.EventHandler(this.checkEditShowRowGrandTotals_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.lcgCommonOptions,
            this.lcgLabelOptions});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(241, 538);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 204);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(241, 334);
            this.layoutControlGroup2.Text = "Marker Kind";
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(241, 334);
            // 
            // lcgCommonOptions
            // 
            this.lcgCommonOptions.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent;
            this.lcgCommonOptions.AppearanceGroup.Options.UseBorderColor = true;
            this.lcgCommonOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.lcgCommonOptions.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.lciShowColumnGrandTotal,
            this.layoutControlItem4,
            this.lciShowRowGrandTotal});
            this.lcgCommonOptions.Location = new System.Drawing.Point(0, 0);
            this.lcgCommonOptions.Name = "lcgCommonOptions";
            this.lcgCommonOptions.Size = new System.Drawing.Size(241, 138);
            this.lcgCommonOptions.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgCommonOptions.Text = "General";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.checkEditSelectionOnly;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItem2.TextVisible = false;
            // 
            // lciShowColumnGrandTotal
            // 
            this.lciShowColumnGrandTotal.Control = this.checkEditShowColumnGrandTotal;
            this.lciShowColumnGrandTotal.Location = new System.Drawing.Point(0, 72);
            this.lciShowColumnGrandTotal.Name = "lciShowColumnGrandTotal";
            this.lciShowColumnGrandTotal.Size = new System.Drawing.Size(221, 24);
            this.lciShowColumnGrandTotal.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.checkEditGenerateSeriesByColumns;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItem4.TextVisible = false;
            // 
            // lciShowRowGrandTotal
            // 
            this.lciShowRowGrandTotal.Control = this.checkEditShowRowGrandTotal;
            this.lciShowRowGrandTotal.Enabled = false;
            this.lciShowRowGrandTotal.Location = new System.Drawing.Point(0, 48);
            this.lciShowRowGrandTotal.Name = "lciShowRowGrandTotal";
            this.lciShowRowGrandTotal.Size = new System.Drawing.Size(221, 24);
            this.lciShowRowGrandTotal.TextVisible = false;
            // 
            // lcgLabelOptions
            // 
            this.lcgLabelOptions.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent;
            this.lcgLabelOptions.AppearanceGroup.Options.UseBorderColor = true;
            this.lcgLabelOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.lcgLabelOptions.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.lcgLabelOptions.Location = new System.Drawing.Point(0, 138);
            this.lcgLabelOptions.Name = "lcgLabelOptions";
            this.lcgLabelOptions.Size = new System.Drawing.Size(241, 66);
            this.lcgLabelOptions.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgLabelOptions.Text = "Label";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.checkEditLabelVisible;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItem1.TextVisible = false;
            // 
            // PivotGridChartingDemo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PivotGridChartingDemo";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.sidePanel1, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEditLabelVisible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSelectionOnly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowColumnGrandTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditGenerateSeriesByColumns.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditShowRowGrandTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCommonOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciShowColumnGrandTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciShowRowGrandTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgLabelOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        XtraEditors.SidePanel sidePanel1;
        XtraPivotGrid.PivotGridControl pivotGridControl;
        XtraPivotGrid.PivotGridField fieldProductName;
        XtraPivotGrid.PivotGridField fieldExtendedPrice;
        XtraPivotGrid.PivotGridField fieldOrderDate;
        XtraEditors.SidePanel sidePanel2;
        ChartControl chart;
        XtraLayout.LayoutControl layoutControl1;
        XtraEditors.CheckEdit checkEditLabelVisible;
        XtraEditors.CheckEdit checkEditSelectionOnly;
        XtraEditors.CheckEdit checkEditShowColumnGrandTotal;
        XtraEditors.CheckEdit checkEditGenerateSeriesByColumns;
        XtraEditors.CheckEdit checkEditShowRowGrandTotal;
        XtraLayout.LayoutControlGroup layoutControlGroup1;
        XtraLayout.LayoutControlGroup layoutControlGroup2;
        XtraLayout.LayoutControlGroup layoutControlGroup3;
        XtraLayout.LayoutControlGroup lcgCommonOptions;
        XtraLayout.LayoutControlItem layoutControlItem2;
        XtraLayout.LayoutControlItem lciShowColumnGrandTotal;
        XtraLayout.LayoutControlItem layoutControlItem4;
        XtraLayout.LayoutControlItem lciShowRowGrandTotal;
        XtraLayout.LayoutControlGroup lcgLabelOptions;
        XtraLayout.LayoutControlItem layoutControlItem1;
        XtraPivotGrid.PivotGridField fieldOrderYear;
    }
}
