namespace DevExpress.XtraCharts.Demos {
    partial class SecondaryAxesDemo {
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("A", new object[] {
            ((object)(40D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("B", new object[] {
            ((object)(30D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("C", new object[] {
            ((object)(25D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("D", new object[] {
            ((object)(22.5D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("E", new object[] {
            ((object)(21.25D))});
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("A", new object[] {
            ((object)(1700D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint("B", new object[] {
            ((object)(900D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint("C", new object[] {
            ((object)(500D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint9 = new DevExpress.XtraCharts.SeriesPoint("D", new object[] {
            ((object)(300D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint10 = new DevExpress.XtraCharts.SeriesPoint("E", new object[] {
            ((object)(200D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint11 = new DevExpress.XtraCharts.SeriesPoint("F", new object[] {
            ((object)(150D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint12 = new DevExpress.XtraCharts.SeriesPoint("G", new object[] {
            ((object)(125D))});
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.radioGroupChartType = new DevExpress.XtraEditors.RadioGroup();
            this.radioGroupSeries2AxisX = new DevExpress.XtraEditors.RadioGroup();
            this.radioGroupSeries2AxisY = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItemBottom = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroupChartType = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemChartType = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupSeries2AxisX = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemSeries2AxisX = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupSeries2AxisY = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemSeries2AxisY = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupChartType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSeries2AxisX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSeries2AxisY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupChartType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemChartType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSeries2AxisX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeries2AxisX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSeries2AxisY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeries2AxisY)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(241, 544);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CrosshairOptions.GroupHeaderPattern = "{A}";
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Title.Text = "Axis X";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Interlaced = true;
            xyDiagram1.AxisY.Title.Text = "Axis Y";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chart.Legend.Margins.Bottom = 10;
            this.chart.Legend.Margins.Left = 10;
            this.chart.Legend.Margins.Right = 10;
            this.chart.Legend.Margins.Top = 10;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(0);
            this.chart.Name = "chart";
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint;
            pointSeriesLabel1.TextPattern = "{A}: {V}";
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5});
            series1.View = lineSeriesView1;
            pointSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint;
            pointSeriesLabel2.TextPattern = "{A}: {V}";
            series2.Label = pointSeriesLabel2;
            series2.Name = "Series 2";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint6,
            seriesPoint7,
            seriesPoint8,
            seriesPoint9,
            seriesPoint10,
            seriesPoint11,
            seriesPoint12});
            lineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square;
            series2.View = lineSeriesView2;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chart.Size = new System.Drawing.Size(546, 571);
            this.chart.TabIndex = 2;
            this.chart.TabStop = false;
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.radioGroupChartType);
            this.layoutControl.Controls.Add(this.radioGroupSeries2AxisX);
            this.layoutControl.Controls.Add(this.radioGroupSeries2AxisY);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(241, 544);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // radioGroupChartType
            // 
            this.radioGroupChartType.AutoSizeInLayoutControl = true;
            this.radioGroupChartType.Location = new System.Drawing.Point(12, 31);
            this.radioGroupChartType.Name = "radioGroupChartType";
            this.radioGroupChartType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupChartType.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupChartType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupChartType.Properties.Columns = 1;
            this.radioGroupChartType.Size = new System.Drawing.Size(217, 8);
            this.radioGroupChartType.StyleController = this.layoutControl;
            this.radioGroupChartType.TabIndex = 4;
            this.radioGroupChartType.SelectedIndexChanged += new System.EventHandler(this.radioGroupChartType_SelectedIndexChanged);
            // 
            // radioGroupSeries2AxisX
            // 
            this.radioGroupSeries2AxisX.AutoSizeInLayoutControl = true;
            this.radioGroupSeries2AxisX.Location = new System.Drawing.Point(12, 82);
            this.radioGroupSeries2AxisX.Name = "radioGroupSeries2AxisX";
            this.radioGroupSeries2AxisX.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupSeries2AxisX.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupSeries2AxisX.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupSeries2AxisX.Properties.Columns = 1;
            this.radioGroupSeries2AxisX.Size = new System.Drawing.Size(217, 8);
            this.radioGroupSeries2AxisX.StyleController = this.layoutControl;
            this.radioGroupSeries2AxisX.TabIndex = 5;
            this.radioGroupSeries2AxisX.SelectedIndexChanged += new System.EventHandler(this.radioGroupSeries2AxisX_SelectedIndexChanged);
            // 
            // radioGroupSeries2AxisY
            // 
            this.radioGroupSeries2AxisY.AutoSizeInLayoutControl = true;
            this.radioGroupSeries2AxisY.Location = new System.Drawing.Point(12, 133);
            this.radioGroupSeries2AxisY.Name = "radioGroupSeries2AxisY";
            this.radioGroupSeries2AxisY.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupSeries2AxisY.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupSeries2AxisY.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupSeries2AxisY.Properties.Columns = 1;
            this.radioGroupSeries2AxisY.Size = new System.Drawing.Size(217, 8);
            this.radioGroupSeries2AxisY.StyleController = this.layoutControl;
            this.radioGroupSeries2AxisY.TabIndex = 6;
            this.radioGroupSeries2AxisY.SelectedIndexChanged += new System.EventHandler(this.radioGroupSeries2AxisY_SelectedIndexChanged);
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItemBottom,
            this.layoutControlGroupChartType,
            this.layoutControlGroupSeries2AxisX,
            this.layoutControlGroupSeries2AxisY});
            this.layoutControlGroupRoot.Name = "layoutControlGroupRoot";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(241, 544);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // emptySpaceItemBottom
            // 
            this.emptySpaceItemBottom.AllowHotTrack = false;
            this.emptySpaceItemBottom.Location = new System.Drawing.Point(0, 153);
            this.emptySpaceItemBottom.Name = "emptySpaceItem1";
            this.emptySpaceItemBottom.Size = new System.Drawing.Size(241, 391);
            this.emptySpaceItemBottom.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroupChartType
            // 
            this.layoutControlGroupChartType.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupChartType.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemChartType});
            this.layoutControlGroupChartType.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupChartType.Name = "layoutControlGroupChartType";
            this.layoutControlGroupChartType.Size = new System.Drawing.Size(241, 51);
            this.layoutControlGroupChartType.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupChartType.Text = "Chart Type";
            // 
            // layoutControlItemChartType
            // 
            this.layoutControlItemChartType.Control = this.radioGroupChartType;
            this.layoutControlItemChartType.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemChartType.Name = "layoutControlItemChartType";
            this.layoutControlItemChartType.Size = new System.Drawing.Size(221, 12);
            this.layoutControlItemChartType.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemChartType.TextVisible = false;
            // 
            // layoutControlGroupSeries2AxisX
            // 
            this.layoutControlGroupSeries2AxisX.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupSeries2AxisX.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemSeries2AxisX});
            this.layoutControlGroupSeries2AxisX.Location = new System.Drawing.Point(0, 51);
            this.layoutControlGroupSeries2AxisX.Name = "layoutControlGroupSeries2AxisX";
            this.layoutControlGroupSeries2AxisX.Size = new System.Drawing.Size(241, 51);
            this.layoutControlGroupSeries2AxisX.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupSeries2AxisX.Text = "Series 2 Axis X";
            // 
            // layoutControlItemSeries2AxisX
            // 
            this.layoutControlItemSeries2AxisX.Control = this.radioGroupSeries2AxisX;
            this.layoutControlItemSeries2AxisX.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemSeries2AxisX.Name = "layoutControlItemSeries2AxisX";
            this.layoutControlItemSeries2AxisX.Size = new System.Drawing.Size(221, 12);
            this.layoutControlItemSeries2AxisX.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemSeries2AxisX.TextVisible = false;
            // 
            // layoutControlGroupSeries2AxisY
            // 
            this.layoutControlGroupSeries2AxisY.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupSeries2AxisY.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemSeries2AxisY});
            this.layoutControlGroupSeries2AxisY.Location = new System.Drawing.Point(0, 102);
            this.layoutControlGroupSeries2AxisY.Name = "layoutControlGroupSeries2AxisY";
            this.layoutControlGroupSeries2AxisY.Size = new System.Drawing.Size(241, 51);
            this.layoutControlGroupSeries2AxisY.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupSeries2AxisY.Text = "Series 2 Axis Y";
            // 
            // layoutControlItemSeries2AxisY
            // 
            this.layoutControlItemSeries2AxisY.Control = this.radioGroupSeries2AxisY;
            this.layoutControlItemSeries2AxisY.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemSeries2AxisY.Name = "layoutControlItemSeries2AxisY";
            this.layoutControlItemSeries2AxisY.Size = new System.Drawing.Size(221, 12);
            this.layoutControlItemSeries2AxisY.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemSeries2AxisY.TextVisible = false;
            // 
            // SecondaryAxesDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "SecondaryAxesDemo";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupChartType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSeries2AxisX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSeries2AxisY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupChartType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemChartType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSeries2AxisX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeries2AxisX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupSeries2AxisY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemSeries2AxisY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        ChartControl chart;
        XtraLayout.LayoutControl layoutControl;
        XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        XtraEditors.RadioGroup radioGroupChartType;
        XtraEditors.RadioGroup radioGroupSeries2AxisX;
        XtraEditors.RadioGroup radioGroupSeries2AxisY;
        XtraLayout.LayoutControlItem layoutControlItemChartType;
        XtraLayout.LayoutControlItem layoutControlItemSeries2AxisX;
        XtraLayout.LayoutControlItem layoutControlItemSeries2AxisY;
        XtraLayout.EmptySpaceItem emptySpaceItemBottom;
        XtraLayout.LayoutControlGroup layoutControlGroupChartType;
        XtraLayout.LayoutControlGroup layoutControlGroupSeries2AxisX;
        XtraLayout.LayoutControlGroup layoutControlGroupSeries2AxisY;
    }
}
