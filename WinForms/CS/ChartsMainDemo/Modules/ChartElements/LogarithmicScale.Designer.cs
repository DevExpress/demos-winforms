namespace DevExpress.XtraCharts.Demos {
    partial class LogarithmicScaleDemo {
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
            DevExpress.XtraCharts.Legend legend1 = new DevExpress.XtraCharts.Legend();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(legend1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad;
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.CrosshairOptions.GroupHeaderPattern = "{A:0.####} Hz";
            this.chart.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free;
            this.chart.CrosshairOptions.ShowArgumentLabels = true;
            this.chart.CrosshairOptions.ShowValueLabels = true;
            this.chart.CrosshairOptions.ShowValueLine = true;
            xyDiagram1.AxisX.GridLines.MinorVisible = true;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Label.TextPattern = "{A:0.####} Hz";
            xyDiagram1.AxisX.Logarithmic = true;
            xyDiagram1.AxisX.MinorCount = 9;
            xyDiagram1.AxisX.Title.Text = "Frequency";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0D;
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0D;
            xyDiagram1.AxisY.CrosshairAxisLabelOptions.Pattern = "{V:0.##}%";
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Label.TextPattern = " {V:0.##}%";
            xyDiagram1.AxisY.Logarithmic = true;
            xyDiagram1.AxisY.MinorCount = 9;
            xyDiagram1.AxisY.Title.Text = "Total Harmonic Distortion ";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram1.AxisY.WholeRange.Auto = false;
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisY.WholeRange.EndSideMargin = 0D;
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "100";
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0.01";
            xyDiagram1.AxisY.WholeRange.StartSideMargin = 0D;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chart.Legend.BackColor = System.Drawing.Color.Transparent;
            this.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chart.Legend.Margins.Bottom = 0;
            this.chart.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBox;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Padding.Bottom = 2;
            this.chart.Legend.Padding.Left = 2;
            this.chart.Legend.Padding.Right = 2;
            this.chart.Legend.Padding.Top = 2;
            legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            legend1.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            legend1.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            legend1.LegendID = 0;
            legend1.Margins.Top = 0;
            legend1.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBox;
            legend1.Name = "Legend1";
            legend1.Padding.Bottom = 2;
            legend1.Padding.Left = 2;
            legend1.Padding.Right = 2;
            legend1.Padding.Top = 2;
            legend1.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.Legends.AddRange(new DevExpress.XtraCharts.Legend[] {
            legend1});
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.CrosshairLabelPattern = "{S}: {V:0.##}%";
            series1.Name = "Headphones 1 90 dB SPL";
            series1.SeriesID = 0;
            lineSeriesView1.LineMarkerOptions.Size = 5;
            lineSeriesView1.LineStyle.Thickness = 3;
            series1.View = lineSeriesView1;
            series2.CrosshairLabelPattern = "{S}: {V:0.##}%";
            series2.Name = "Headphones 1 100 dB SPL";
            series2.SeriesID = 1;
            lineSeriesView2.LineMarkerOptions.Size = 5;
            lineSeriesView2.LineStyle.Thickness = 3;
            series2.View = lineSeriesView2;
            series3.CrosshairLabelPattern = "{S}: {V:0.##}%";
            series3.LegendName = "Legend1";
            series3.Name = "Headphones 2 90 dB SPL";
            series3.SeriesID = 2;
            lineSeriesView3.LineMarkerOptions.Size = 5;
            lineSeriesView3.LineStyle.Thickness = 3;
            series3.View = lineSeriesView3;
            series4.CrosshairLabelPattern = "{S}: {V:0.##}%";
            series4.LegendName = "Legend1";
            series4.Name = "Headphones 2 100 dB SPL";
            series4.SeriesID = 3;
            lineSeriesView4.LineMarkerOptions.Size = 5;
            lineSeriesView4.LineStyle.Thickness = 3;
            series4.View = lineSeriesView4;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series4};
            this.chart.Size = new System.Drawing.Size(784, 432);
            this.chart.TabIndex = 0;
            chartTitle1.Text = "Headphones comparison";
            chartTitle1.TitleID = 0;
            chartTitle2.DXFont = new DevExpress.Drawing.DXFont("Tahoma", 12F);
            chartTitle2.Text = "Unwanted harmonics";
            chartTitle2.TitleID = 1;
            chartTitle2.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1,
            chartTitle2});
            // 
            // LogarithmicScaleDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart);
            this.Name = "LogarithmicScaleDemo";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(legend1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        ChartControl chart;
    }
}
