namespace DevExpress.XtraCharts.Demos {
    partial class WaterfallDemo {
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
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel1 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel2 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel3 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel4 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.CustomAxisLabel customAxisLabel5 = new DevExpress.XtraCharts.CustomAxisLabel();
            DevExpress.XtraCharts.SeriesTemplateAdapter seriesTemplateAdapter1 = new DevExpress.XtraCharts.SeriesTemplateAdapter();
            DevExpress.XtraCharts.DataMember dataMember1 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember2 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember3 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.WaterfallSeriesLabel waterfallSeriesLabel1 = new DevExpress.XtraCharts.WaterfallSeriesLabel();
            DevExpress.XtraCharts.SeriesKeyColorColorizer seriesKeyColorColorizer1 = new DevExpress.XtraCharts.SeriesKeyColorColorizer();
            DevExpress.XtraCharts.WaterfallSeriesView waterfallSeriesView1 = new DevExpress.XtraCharts.WaterfallSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.WaterfallRelativeValueOptions waterfallRelativeValueOptions1 = new DevExpress.XtraCharts.WaterfallRelativeValueOptions();
            DevExpress.XtraCharts.Subtotal subtotal1 = new DevExpress.XtraCharts.Subtotal();
            DevExpress.XtraCharts.Subtotal subtotal2 = new DevExpress.XtraCharts.Subtotal();
            DevExpress.XtraCharts.Subtotal subtotal3 = new DevExpress.XtraCharts.Subtotal();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.radioGroupDataView = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupGeneral = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(waterfallSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(waterfallSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupDataView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(241, 538);
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            customAxisLabel1.AxisValueSerializable = "1989";
            customAxisLabel1.Name = "1989";
            customAxisLabel2.AxisValueSerializable = "Kyoto Protocol Adopted";
            customAxisLabel2.Name = "1997\nKyoto Protocol";
            customAxisLabel3.AxisValueSerializable = "Clean Development Mechanism Opens";
            customAxisLabel3.Name = "2006\nClean Development Mechanism Opens";
            customAxisLabel4.AxisValueSerializable = "Paris Agreement Adopted";
            customAxisLabel4.Name = "2016\nParis Agreement";
            customAxisLabel5.AxisValueSerializable = "2020";
            customAxisLabel5.Name = "2020";
            xyDiagram1.AxisX.CustomLabels.AddRange(new DevExpress.XtraCharts.CustomAxisLabel[] {
            customAxisLabel1,
            customAxisLabel2,
            customAxisLabel3,
            customAxisLabel4,
            customAxisLabel5});
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "Emissions and Sinks, BtC";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.PaletteRepository.Add("Palette 1", new DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(108))))), System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(68)))), ((int)(((byte)(108)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(89))))), System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(88)))), ((int)(((byte)(89)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(220)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(213))))), System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(131)))), ((int)(((byte)(213)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(206)))), ((int)(((byte)(181))))), System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(206)))), ((int)(((byte)(181)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(155)))), ((int)(((byte)(136))))), System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(155)))), ((int)(((byte)(136))))))}));
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            dataMember1.ColumnName = "Year";
            dataMember1.ScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            dataMember2.ColumnName = "CalculatedContribution";
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value;
            dataMember3.ColumnName = "Factor";
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series;
            seriesTemplateAdapter1.DataMembers.AddRange(new DevExpress.XtraCharts.DataMember[] {
            dataMember1,
            dataMember2,
            dataMember3});
            this.chart.SeriesTemplate.DataAdapter = seriesTemplateAdapter1;
            waterfallSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.SeriesTemplate.Label = waterfallSeriesLabel1;
            seriesKeyColorColorizer1.Keys.Add("Fuel/Industry");
            seriesKeyColorColorizer1.Keys.Add("Land-Use Emissions");
            seriesKeyColorColorizer1.Keys.Add("Atmospheric Growth");
            seriesKeyColorColorizer1.Keys.Add("Ocean Sink");
            seriesKeyColorColorizer1.Keys.Add("Land Sink");
            seriesKeyColorColorizer1.Keys.Add("Cement Carbonation Sink");
            seriesKeyColorColorizer1.PaletteName = "Palette 1";
            this.chart.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer1;
            waterfallSeriesView1.FallingBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            waterfallSeriesView1.RisingBarColor = System.Drawing.Color.Red;
            this.chart.SeriesTemplate.View = waterfallSeriesView1;
            this.chart.Size = new System.Drawing.Size(546, 571);
            this.chart.TabIndex = 0;
            chartTitle1.Text = "Global Carbon Balance";
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far;
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom;
            chartTitle2.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 8.25F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point);
            chartTitle2.Text = "From globalcarbonproject.org";
            chartTitle2.TextColor = System.Drawing.Color.Gray;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            waterfallRelativeValueOptions1.StartBarLabel = "1989";
            waterfallRelativeValueOptions1.StartBarValue = 2766D;
            subtotal1.Label = "Kyoto Protocol Adopted";
            subtotal1.PointIndex = 7;
            subtotal2.Label = "Clean Development Mechanism Opens";
            subtotal2.PointIndex = 16;
            subtotal3.Label = "Paris Agreement Adopted";
            subtotal3.PointIndex = 26;
            waterfallRelativeValueOptions1.Subtotals.AddRange(new DevExpress.XtraCharts.Subtotal[] {
            subtotal1,
            subtotal2,
            subtotal3});
            waterfallRelativeValueOptions1.TotalLabel = "2020";
            this.chart.WaterfallValueOptions = waterfallRelativeValueOptions1;
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.radioGroupDataView);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(602, 135, 650, 400);
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(241, 538);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // radioGroupDataView
            // 
            this.radioGroupDataView.AutoSizeInLayoutControl = true;
            this.radioGroupDataView.EditValue = "Fahrenheit";
            this.radioGroupDataView.Location = new System.Drawing.Point(12, 34);
            this.radioGroupDataView.Name = "radioGroupDataView";
            this.radioGroupDataView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupDataView.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupDataView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupDataView.Properties.Columns = 1;
            this.radioGroupDataView.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("AggregatedData", "Aggregated Data"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("DetailedData", "Detailed Data")});
            this.radioGroupDataView.Size = new System.Drawing.Size(217, 56);
            this.radioGroupDataView.StyleController = this.layoutControl;
            this.radioGroupDataView.TabIndex = 6;
            this.radioGroupDataView.SelectedIndexChanged += new System.EventHandler(this.RadioGroupTemperatureUnit_SelectedIndexChanged);
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupGeneral,
            this.emptySpaceItem});
            this.layoutControlGroupRoot.Name = "Root";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(241, 538);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // layoutControlGroupGeneral
            // 
            this.layoutControlGroupGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent;
            this.layoutControlGroupGeneral.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupGeneral.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroupGeneral.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral";
            this.layoutControlGroupGeneral.Size = new System.Drawing.Size(241, 102);
            this.layoutControlGroupGeneral.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupGeneral.Text = "General";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.radioGroupDataView;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(221, 60);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 102);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(241, 436);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // WaterfallDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "WaterfallDemo";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.chart, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(waterfallSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(waterfallSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupDataView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        ChartControl chart;
        private XtraLayout.LayoutControl layoutControl;
        private XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        private XtraLayout.LayoutControlGroup layoutControlGroupGeneral;
        private XtraLayout.EmptySpaceItem emptySpaceItem;
        private XtraEditors.RadioGroup radioGroupDataView;
        private XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
