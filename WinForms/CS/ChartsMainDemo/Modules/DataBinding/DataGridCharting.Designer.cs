namespace DevExpress.XtraCharts.Demos {
    partial class DataGridChartingDemo{
        System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            DevExpress.XtraCharts.SeriesKeyColorColorizer seriesKeyColorColorizer1 = new DevExpress.XtraCharts.SeriesKeyColorColorizer();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleAboveBelowAverage formatConditionRuleAboveBelowAverage1 = new DevExpress.XtraEditors.FormatConditionRuleAboveBelowAverage();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleAboveBelowAverage formatConditionRuleAboveBelowAverage2 = new DevExpress.XtraEditors.FormatConditionRuleAboveBelowAverage();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SeriesTemplateAdapter seriesTemplateAdapter2 = new DevExpress.XtraCharts.SeriesTemplateAdapter();
            DevExpress.XtraCharts.DataMember dataMember4 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember5 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember6 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.XYSeriesUnwindAnimation xySeriesUnwindAnimation1 = new DevExpress.XtraCharts.XYSeriesUnwindAnimation();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chartTotalUnitsSold = new DevExpress.XtraCharts.ChartControl();
            this.controlRowSourceTotalUnitsSold = new DevExpress.Data.Controls.ControlRowSource();
            this.gridView = new DevExpress.XtraCharts.Demos.SalesGridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chartMonthlyRevenue = new DevExpress.XtraCharts.ChartControl();
            this.controlRowSourceMonthlyRevenue = new DevExpress.Data.Controls.ControlRowSource();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalUnitsSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlRowSourceTotalUnitsSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlRowSourceMonthlyRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "SalesDynamic";
            this.gridColumn9.FieldName = "SalesDynamic";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            // 
            // chartTotalUnitsSold
            // 
            this.chartTotalUnitsSold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chartTotalUnitsSold.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chartTotalUnitsSold.DataSource = this.controlRowSourceTotalUnitsSold;
            xyDiagram1.AxisX.QualitativeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.Sum;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartTotalUnitsSold.Diagram = xyDiagram1;
            this.chartTotalUnitsSold.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartTotalUnitsSold.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chartTotalUnitsSold.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartTotalUnitsSold.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartTotalUnitsSold.Legend.Name = "Default Legend";
            this.chartTotalUnitsSold.Location = new System.Drawing.Point(12, 273);
            this.chartTotalUnitsSold.Name = "chartTotalUnitsSold";
            this.chartTotalUnitsSold.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            dataMember1.ColumnName = "Category";
            dataMember2.ColumnName = "UnitsSold";
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value;
            dataMember3.ColumnName = "State";
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series;
            seriesTemplateAdapter1.DataMembers.AddRange(new DevExpress.XtraCharts.DataMember[] {
            dataMember1,
            dataMember2,
            dataMember3});
            this.chartTotalUnitsSold.SeriesTemplate.DataAdapter = seriesTemplateAdapter1;
            this.chartTotalUnitsSold.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer1;
            this.chartTotalUnitsSold.Size = new System.Drawing.Size(300, 147);
            this.chartTotalUnitsSold.TabIndex = 2;
            chartTitle1.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 14.25F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point);
            chartTitle1.Text = "Total Units Sold";
            this.chartTotalUnitsSold.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chartTotalUnitsSold.Click += new System.EventHandler(this.OnChartControlClick);
            // 
            // controlRowSourceTotalUnitsSold
            // 
            this.controlRowSourceTotalUnitsSold.Control = this.gridView;
            this.controlRowSourceTotalUnitsSold.ControlRows = DevExpress.Data.Controls.ControlRows.Selected;
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            gridFormatRule1.Column = this.gridColumn9;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleAboveBelowAverage1.AverageType = DevExpress.XtraEditors.FormatConditionAboveBelowType.EqualOrAbove;
            formatConditionRuleAboveBelowAverage1.PredefinedName = "Green Text";
            gridFormatRule1.Rule = formatConditionRuleAboveBelowAverage1;
            gridFormatRule2.Column = this.gridColumn9;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleAboveBelowAverage2.AverageType = DevExpress.XtraEditors.FormatConditionAboveBelowType.Below;
            formatConditionRuleAboveBelowAverage2.PredefinedName = "Red Text";
            gridFormatRule2.Rule = formatConditionRuleAboveBelowAverage2;
            this.gridView.FormatRules.Add(gridFormatRule1);
            this.gridView.FormatRules.Add(gridFormatRule2);
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupCount = 2;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsSelection.MultiSelect = true;
            this.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "State";
            this.gridColumn1.FieldName = "State";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Product";
            this.gridColumn2.FieldName = "Product";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Category";
            this.gridColumn3.FieldName = "Category";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 10;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "UnitsSold";
            this.gridColumn4.FieldName = "UnitsSold";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Price";
            this.gridColumn5.FieldName = "Price";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Revenue";
            this.gridColumn6.DisplayFormat.FormatString = "c2";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "Revenue";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "UnitsSoldTarget";
            this.gridColumn7.FieldName = "UnitsSoldTarget";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "RevenueTarget";
            this.gridColumn8.FieldName = "RevenueTarget";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 6;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "ReportDate";
            this.gridColumn10.FieldName = "ReportDate";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 8;
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 47);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(760, 222);
            this.gridControl.TabIndex = 3;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.gridControl);
            this.layoutControl1.Controls.Add(this.chartTotalUnitsSold);
            this.layoutControl1.Controls.Add(this.chartMonthlyRevenue);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(671, 55, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(784, 432);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chartMonthlyRevenue
            // 
            this.chartMonthlyRevenue.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chartMonthlyRevenue.DataSource = this.controlRowSourceMonthlyRevenue;
            xyDiagram2.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.Sum;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.Label.TextPattern = "${V:#,##0,,}M";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartMonthlyRevenue.Diagram = xyDiagram2;
            this.chartMonthlyRevenue.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartMonthlyRevenue.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chartMonthlyRevenue.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartMonthlyRevenue.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartMonthlyRevenue.Legend.Name = "Default Legend";
            this.chartMonthlyRevenue.Location = new System.Drawing.Point(316, 273);
            this.chartMonthlyRevenue.Name = "chartMonthlyRevenue";
            this.chartMonthlyRevenue.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartMonthlyRevenue.SeriesTemplate.CrosshairLabelPattern = "{V:$0.00}";
            dataMember4.ColumnName = "ReportDate";
            dataMember5.ColumnName = "Revenue";
            dataMember5.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value;
            dataMember6.ColumnName = "Category";
            dataMember6.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series;
            seriesTemplateAdapter2.DataMembers.AddRange(new DevExpress.XtraCharts.DataMember[] {
            dataMember4,
            dataMember5,
            dataMember6});
            this.chartMonthlyRevenue.SeriesTemplate.DataAdapter = seriesTemplateAdapter2;
            xySeriesUnwindAnimation1.Duration = System.TimeSpan.Parse("00:00:02");
            lineSeriesView1.SeriesAnimation = xySeriesUnwindAnimation1;
            this.chartMonthlyRevenue.SeriesTemplate.View = lineSeriesView1;
            this.chartMonthlyRevenue.Size = new System.Drawing.Size(456, 147);
            this.chartMonthlyRevenue.TabIndex = 5;
            chartTitle2.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 14.25F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point);
            chartTitle2.Text = "Monthly Revenue";
            this.chartMonthlyRevenue.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            this.chartMonthlyRevenue.Click += new System.EventHandler(this.OnChartControlClick);
            // 
            // controlRowSourceMonthlyRevenue
            // 
            this.controlRowSourceMonthlyRevenue.Control = this.gridView;
            this.controlRowSourceMonthlyRevenue.ControlRows = DevExpress.Data.Controls.ControlRows.Selected;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.simpleLabelItem1,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(784, 432);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chartMonthlyRevenue;
            this.layoutControlItem4.Location = new System.Drawing.Point(304, 261);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(460, 151);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.simpleLabelItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 12);
            this.simpleLabelItem1.Size = new System.Drawing.Size(764, 35);
            this.simpleLabelItem1.Text = "Product Sales YTD";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(154, 23);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chartTotalUnitsSold;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 261);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(304, 151);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 35);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(764, 226);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // DataGridChartingDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "DataGridChartingDemo";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTotalUnitsSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlRowSourceTotalUnitsSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlRowSourceMonthlyRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        ChartControl chartTotalUnitsSold;
        XtraGrid.GridControl gridControl;
        SalesGridView gridView;
        Data.Controls.ControlRowSource controlRowSourceTotalUnitsSold;
        XtraLayout.LayoutControl layoutControl1;
        XtraLayout.LayoutControlGroup layoutControlGroup1;
        XtraLayout.LayoutControlItem layoutControlItem2;
        XtraLayout.LayoutControlItem layoutControlItem3;
        ChartControl chartMonthlyRevenue;
        XtraLayout.LayoutControlItem layoutControlItem4;
        XtraLayout.SimpleLabelItem simpleLabelItem1;
        Data.Controls.ControlRowSource controlRowSourceMonthlyRevenue;
        XtraGrid.Columns.GridColumn gridColumn1;
        XtraGrid.Columns.GridColumn gridColumn2;
        XtraGrid.Columns.GridColumn gridColumn3;
        XtraGrid.Columns.GridColumn gridColumn4;
        XtraGrid.Columns.GridColumn gridColumn5;
        XtraGrid.Columns.GridColumn gridColumn6;
        XtraGrid.Columns.GridColumn gridColumn7;
        XtraGrid.Columns.GridColumn gridColumn8;
        XtraGrid.Columns.GridColumn gridColumn9;
        XtraGrid.Columns.GridColumn gridColumn10;
    }
}
