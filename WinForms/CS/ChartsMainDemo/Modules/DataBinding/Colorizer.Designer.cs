namespace DevExpress.XtraCharts.Demos {
    partial class ColorizerDemo {
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
            DevExpress.XtraCharts.DataSourceAdapter dataSourceAdapter1 = new DevExpress.XtraCharts.DataSourceAdapter();
            DevExpress.XtraCharts.DataMember dataMember1 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember2 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember3 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember4 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.DataMember dataMember5 = new DevExpress.XtraCharts.DataMember();
            DevExpress.XtraCharts.BubbleSeriesLabel bubbleSeriesLabel1 = new DevExpress.XtraCharts.BubbleSeriesLabel();
            DevExpress.XtraCharts.BubbleSeriesView bubbleSeriesView1 = new DevExpress.XtraCharts.BubbleSeriesView();
            DevExpress.XtraCharts.XYMarkerSlideAnimation xyMarkerSlideAnimation1 = new DevExpress.XtraCharts.XYMarkerSlideAnimation();
            DevExpress.XtraCharts.ElasticEasingFunction elasticEasingFunction1 = new DevExpress.XtraCharts.ElasticEasingFunction();
            DevExpress.XtraCharts.BubbleSeriesView bubbleSeriesView2 = new DevExpress.XtraCharts.BubbleSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.QualitativeScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0.7D;
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0.7D;
            xyDiagram1.AxisY.LabelPosition = DevExpress.XtraCharts.AxisLabelPosition.Inside;
            xyDiagram1.AxisY.NumericScaleOptions.AutoGrid = false;
            xyDiagram1.AxisY.NumericScaleOptions.GridAlignment = DevExpress.XtraCharts.NumericGridAlignment.Thousands;
            xyDiagram1.AxisY.NumericScaleOptions.GridSpacing = 10D;
            xyDiagram1.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisY.Tickmarks.Visible = false;
            xyDiagram1.AxisY.Title.Text = "GDP per capita, $";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.PaletteRepository.Add("ColorizerPalette", new DevExpress.XtraCharts.Palette("ColorizerPalette", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(25))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(25)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(173)))), ((int)(((byte)(45))))), System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(173)))), ((int)(((byte)(45)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(227)))), ((int)(((byte)(53))))), System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(227)))), ((int)(((byte)(53)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(228)))), ((int)(((byte)(92))))), System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(228)))), ((int)(((byte)(92)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(201)))), ((int)(((byte)(92))))), System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(201)))), ((int)(((byte)(92))))))}));
            dataMember1.ColumnName = "Country";
            dataMember2.ColumnName = "Product";
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value;
            dataMember3.ColumnName = "Population";
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Weight;
            dataMember4.ColumnName = "HPI";
            dataMember4.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Color;
            dataMember5.ColumnName = "HPI";
            dataMember5.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.ToolTipHint;
            dataSourceAdapter1.DataMembers.AddRange(new DevExpress.XtraCharts.DataMember[] {
            dataMember1,
            dataMember2,
            dataMember3,
            dataMember4,
            dataMember5});
            series1.DataAdapter = dataSourceAdapter1;
            bubbleSeriesLabel1.TextPattern = "{W:0,,.00} M";
            series1.Label = bubbleSeriesLabel1;
            series1.Name = "Series 1";
            series1.ToolTipPointPattern = "{A}\nGDP per capita: {V:0.00}$\nPopulation: {W:0,,.00} M\nHPI: {HINT}";
            bubbleSeriesView1.MaxSize = 1.4D;
            bubbleSeriesView1.MinSize = 0.6D;
            xyMarkerSlideAnimation1.Direction = DevExpress.XtraCharts.XYMarkerSlideAnimationDirection.FromLeftTopCorner;
            xyMarkerSlideAnimation1.Duration = System.TimeSpan.Parse("00:00:01.5000000");
            elasticEasingFunction1.EasingMode = DevExpress.XtraCharts.EasingMode.Out;
            xyMarkerSlideAnimation1.EasingFunction = elasticEasingFunction1;
            xyMarkerSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000");
            xyMarkerSlideAnimation1.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random;
            bubbleSeriesView1.SeriesPointAnimation = xyMarkerSlideAnimation1;
            bubbleSeriesView1.Transparency = ((byte)(90));
            series1.View = bubbleSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.SeriesTemplate.View = bubbleSeriesView2;
            this.chart.Size = new System.Drawing.Size(784, 432);
            this.chart.TabIndex = 2;
            chartTitle1.Text = "Happy Planet Index for G20";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ColorizerDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "ColorizerDemo";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(bubbleSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        ChartControl chart;
    }
}
