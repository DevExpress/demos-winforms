namespace DevExpress.XtraCharts.Demos {
    partial class SwiftPointDemo {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            DevExpress.XtraCharts.SwiftPlotDiagram swiftPlotDiagram1 = new DevExpress.XtraCharts.SwiftPlotDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPointSeriesView swiftPointSeriesView1 = new DevExpress.XtraCharts.SwiftPointSeriesView();
            DevExpress.XtraCharts.RegressionLine regressionLine1 = new DevExpress.XtraCharts.RegressionLine();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.radioGroupTemperatureUnit = new DevExpress.XtraEditors.RadioGroup();
            this.radioGroupChartType = new DevExpress.XtraEditors.RadioGroup();
            this.radioGroupColorizerType = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItemBottom = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroupChartType = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemChartType = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupColorizerType = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItemChartType1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupTemperatureUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupChartType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupColorizerType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupChartType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemChartType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupColorizerType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemChartType1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPointSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(regressionLine1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.radioGroupTemperatureUnit);
            this.layoutControl.Controls.Add(this.radioGroupChartType);
            this.layoutControl.Controls.Add(this.radioGroupColorizerType);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(362, 873);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // radioGroupTemperatureUnit
            // 
            this.radioGroupTemperatureUnit.EditValue = "Fahrenheit";
            this.radioGroupTemperatureUnit.Location = new System.Drawing.Point(14, 180);
            this.radioGroupTemperatureUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioGroupTemperatureUnit.Name = "radioGroupTemperatureUnit";
            this.radioGroupTemperatureUnit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupTemperatureUnit.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupTemperatureUnit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupTemperatureUnit.Properties.Columns = 1;
            this.radioGroupTemperatureUnit.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Fahrenheit", "Fahrenheit"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Celsius", "Celsius")});
            this.radioGroupTemperatureUnit.Size = new System.Drawing.Size(334, 130);
            this.radioGroupTemperatureUnit.StyleController = this.layoutControl;
            this.radioGroupTemperatureUnit.TabIndex = 5;
            // 
            // radioGroupChartType
            // 
            this.radioGroupChartType.Location = new System.Drawing.Point(12, 106);
            this.radioGroupChartType.Name = "radioGroupChartType";
            this.radioGroupChartType.Size = new System.Drawing.Size(338, 26);
            this.radioGroupChartType.StyleController = this.layoutControl;
            this.radioGroupChartType.TabIndex = 6;
            // 
            // radioGroupColorizerType
            // 
            this.radioGroupColorizerType.Location = new System.Drawing.Point(12, 34);
            this.radioGroupColorizerType.Name = "radioGroupColorizerType";
            this.radioGroupColorizerType.Size = new System.Drawing.Size(338, 26);
            this.radioGroupColorizerType.StyleController = this.layoutControl;
            this.radioGroupColorizerType.TabIndex = 7;
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItemBottom,
            this.layoutControlGroupChartType,
            this.layoutControlGroupColorizerType,
            this.layoutControlGroup1});
            this.layoutControlGroupRoot.Name = "Root";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(362, 873);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // emptySpaceItemBottom
            // 
            this.emptySpaceItemBottom.Location = new System.Drawing.Point(0, 324);
            this.emptySpaceItemBottom.Name = "emptySpaceItem1";
            this.emptySpaceItemBottom.Size = new System.Drawing.Size(362, 549);
            // 
            // layoutControlGroupChartType
            // 
            this.layoutControlGroupChartType.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupChartType.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemChartType});
            this.layoutControlGroupChartType.Location = new System.Drawing.Point(0, 72);
            this.layoutControlGroupChartType.Name = "layoutControlGroupChartType";
            this.layoutControlGroupChartType.Size = new System.Drawing.Size(362, 72);
            this.layoutControlGroupChartType.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupChartType.Text = "Chart Type";
            // 
            // layoutControlItemChartType
            // 
            this.layoutControlItemChartType.Control = this.radioGroupChartType;
            this.layoutControlItemChartType.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemChartType.Name = "layoutControlItemChartType";
            this.layoutControlItemChartType.Size = new System.Drawing.Size(342, 30);
            this.layoutControlItemChartType.TextVisible = false;
            // 
            // layoutControlGroupColorizerType
            // 
            this.layoutControlGroupColorizerType.CustomizationFormText = "Chart Type";
            this.layoutControlGroupColorizerType.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupColorizerType.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItemChartType1});
            this.layoutControlGroupColorizerType.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupColorizerType.Name = "layoutControlGroupColorizerType";
            this.layoutControlGroupColorizerType.Size = new System.Drawing.Size(362, 72);
            this.layoutControlGroupColorizerType.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupColorizerType.Text = "Segment Colorizer Type";
            // 
            // layoutControlItemChartType1
            // 
            this.layoutControlItemChartType1.Control = this.radioGroupColorizerType;
            this.layoutControlItemChartType1.CustomizationFormText = "layoutControlItemChartType";
            this.layoutControlItemChartType1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemChartType1.Name = "layoutControlItemChartType1";
            this.layoutControlItemChartType1.Size = new System.Drawing.Size(342, 30);
            this.layoutControlItemChartType1.Text = "layoutControlItemChartType";
            this.layoutControlItemChartType1.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 144);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(362, 180);
            this.layoutControlGroup1.Text = "Temperature Unit";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.radioGroupTemperatureUnit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(338, 134);
            this.layoutControlItem1.TextVisible = false;
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chart.AutoLayout = false;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.Default;
            this.chart.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free;
            this.chart.CrosshairOptions.ShowArgumentLabels = true;
            this.chart.CrosshairOptions.ShowValueLabels = true;
            this.chart.CrosshairOptions.ShowValueLine = true;
            swiftPlotDiagram1.AxisX.CrosshairAxisLabelOptions.Pattern = "{A:N0}";
            swiftPlotDiagram1.AxisX.GridLines.Visible = true;
            swiftPlotDiagram1.AxisX.Title.Tag = "";
            swiftPlotDiagram1.AxisX.Title.Text = "House Area in ft<sup>2</sup>";
            swiftPlotDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.AxisY.Label.TextPattern = "{V:0,.}";
            swiftPlotDiagram1.AxisY.Title.Text = "Price in Thousands of Dollars ";
            swiftPlotDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.EnableAxisXScrolling = true;
            swiftPlotDiagram1.EnableAxisXZooming = true;
            swiftPlotDiagram1.EnableAxisYScrolling = true;
            swiftPlotDiagram1.EnableAxisYZooming = true;
            this.chart.Diagram = swiftPlotDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.PaletteRepository.Add("Temperature Palette", new DevExpress.XtraCharts.Palette("Temperature Palette", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(151))))), System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(151)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(176))))), System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(176)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(202)))), ((int)(((byte)(222))))), System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(202)))), ((int)(((byte)(222)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(222)))), ((int)(((byte)(194))))), System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(222)))), ((int)(((byte)(194)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(53))))), System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(53)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(121)))), ((int)(((byte)(5))))), System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(121)))), ((int)(((byte)(5)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(53))))), System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(246)))), ((int)(((byte)(53)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(222)))), ((int)(((byte)(194))))), System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(222)))), ((int)(((byte)(194)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(202)))), ((int)(((byte)(222))))), System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(202)))), ((int)(((byte)(222)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(176))))), System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(120)))), ((int)(((byte)(176)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(151))))), System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(40)))), ((int)(((byte)(151))))))}));
            this.chart.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Argument;
            series1.CrosshairLabelPattern = "{A:N0}ft<sup>2</sup> : {V:$0}";
            series1.Name = "Houses";
            series1.SeriesID = 0;
            regressionLine1.CrosshairLabelPattern = "{A:N0}ft<sup>2</sup> : {V:$0}";
            regressionLine1.IndicatorID = 0;
            regressionLine1.Name = "Regression";
            regressionLine1.ShowInLegend = true;
            swiftPointSeriesView1.Indicators.AddRange(new DevExpress.XtraCharts.Indicator[] {
            regressionLine1});
            series1.View = swiftPointSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(784, 432);
            this.chart.TabIndex = 3;
            this.chart.TabStop = false;
            chartTitle1.Text = "House Sale Prices";
            chartTitle1.TitleID = 0;
            chartTitle2.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 12F);
            chartTitle2.Text = "Point Count: 100000";
            chartTitle2.TitleID = 1;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.chart);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(784, 432);
            this.sidePanel1.TabIndex = 4;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // SwiftPointDemo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SwiftPointDemo";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupTemperatureUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupChartType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupColorizerType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItemBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupChartType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemChartType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupColorizerType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemChartType1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(regressionLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPointSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private XtraLayout.LayoutControl layoutControl;
        private XtraEditors.RadioGroup radioGroupChartType;
        private XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        private XtraLayout.EmptySpaceItem emptySpaceItemBottom;
        private XtraLayout.LayoutControlGroup layoutControlGroupChartType;
        private XtraLayout.LayoutControlItem layoutControlItemChartType;
        private XtraEditors.RadioGroup radioGroupColorizerType;
        private XtraLayout.LayoutControlGroup layoutControlGroupColorizerType;
        private XtraLayout.LayoutControlItem layoutControlItemChartType1;
        private ChartControl chart;
        private XtraEditors.SidePanel sidePanel1;
        private XtraEditors.RadioGroup radioGroupTemperatureUnit;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
