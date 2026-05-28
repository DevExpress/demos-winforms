namespace DevExpress.XtraCharts.Demos {
    partial class TimeSpanDataAggregationDemo {
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
            DevExpress.XtraCharts.CrosshairFreePosition crosshairFreePosition1 = new DevExpress.XtraCharts.CrosshairFreePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SecondaryAxisY secondaryAxisY1 = new DevExpress.XtraCharts.SecondaryAxisY();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            crosshairFreePosition1.DockTargetName = "Default Pane";
            this.chart.CrosshairOptions.CommonLabelPosition = crosshairFreePosition1;
            this.chart.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free;
            this.chart.CrosshairOptions.ShowArgumentLabels = true;
            this.chart.CrosshairOptions.ShowValueLabels = true;
            this.chart.CrosshairOptions.ShowValueLine = true;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = false;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = false;
            xyDiagram1.AxisX.TimeSpanScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Automatic;
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.CrosshairAxisLabelOptions.Pattern = "{V:0}°C";
            xyDiagram1.AxisY.Label.TextPattern = "{V}°C";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisY.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.DependentAxesYRange = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            secondaryAxisY1.AxisID = 0;
            secondaryAxisY1.CrosshairAxisLabelOptions.Pattern = "{V:0}°F";
            secondaryAxisY1.Label.TextPattern = "{V}°F";
            secondaryAxisY1.Name = "Secondary AxisY 1";
            secondaryAxisY1.VisibleInPanesSerializable = "-1";
            secondaryAxisY1.WholeRange.AlwaysShowZeroLevel = false;
            secondaryAxisY1.WholeRange.AutoSideMargins = false;
            secondaryAxisY1.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.SecondaryAxesY.AddRange(new DevExpress.XtraCharts.SecondaryAxisY[] {
            secondaryAxisY1});
            xyDiagram1.ZoomingOptions.AxisXMaxZoomPercent = 100000D;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.TimeSpan;
            series1.CrosshairLabelPattern = "{S}: {V:0}°C";
            series1.Name = "CPU Temperature";
            series1.View = lineSeriesView1;
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.TimeSpan;
            series2.CrosshairLabelPattern = "{S}: {V:0}°C";
            series2.Name = "GPU Temperature";
            series2.View = lineSeriesView2;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chart.Size = new System.Drawing.Size(784, 432);
            this.chart.TabIndex = 4;
            chartTitle1.Text = "Hardware Monitor";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chart.CustomDrawCrosshair += new DevExpress.XtraCharts.CustomDrawCrosshairEventHandler(this.Chart_CustomDrawCrosshair);
            this.chart.AxisVisualRangeChanged += new System.EventHandler<DevExpress.XtraCharts.AxisRangeChangedEventArgs>(this.Chart_AxisVisualRangeChanged);
            // 
            // TimeSpanDataAggregationDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "TimeSpanDataAggregationDemo";
            ((System.ComponentModel.ISupportInitialize)(secondaryAxisY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        ChartControl chart;

    }
}
