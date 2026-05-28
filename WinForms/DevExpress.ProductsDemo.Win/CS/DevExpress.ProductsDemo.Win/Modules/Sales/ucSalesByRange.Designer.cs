namespace DevExpress.SalesDemo.Win.Modules {
    partial class ucSalesByRange {
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
            DevExpress.XtraEditors.RangeControlRange rangeControlRange1 = new DevExpress.XtraEditors.RangeControlRange();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel1 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel2 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView2 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            this.rangeControl = new DevExpress.XtraEditors.RangeControl();
            this.pieChart = new DevExpress.XtraCharts.ChartControl();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.barChart = new DevExpress.XtraCharts.ChartControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView2)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rangeControl
            // 
            this.rangeControl.Client = this.pieChart;
            this.rangeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangeControl.Location = new System.Drawing.Point(55, 3);
            this.rangeControl.Name = "rangeControl";
            rangeControlRange1.Maximum = 4.5D;
            rangeControlRange1.Minimum = -0.5D;
            rangeControlRange1.Owner = this.rangeControl;
            this.rangeControl.SelectedRange = rangeControlRange1;
            this.rangeControl.SelectionType = DevExpress.XtraEditors.RangeControlSelectionType.Flag;
            this.rangeControl.ShowToolTips = false;
            this.rangeControl.ShowZoomScrollBar = false;
            this.rangeControl.Size = new System.Drawing.Size(815, 99);
            this.rangeControl.TabIndex = 1;
            this.rangeControl.Text = "rangeControl1";
            this.rangeControl.VisibleRangeMaximumScaleFactor = 1D;
            // 
            // pieChart
            // 
            this.pieChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.pieChart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.pieChart.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            this.pieChart.Legend.EquallySpacedItems = false;
            this.pieChart.Legend.MarkerSize = new System.Drawing.Size(18, 18);
            this.pieChart.Legend.Name = "Default Legend";
            this.pieChart.Legend.Padding.Bottom = 10;
            this.pieChart.Legend.Padding.Left = 10;
            this.pieChart.Legend.Padding.Right = 10;
            this.pieChart.Legend.Padding.Top = 10;
            this.pieChart.Legend.TextOffset = 8;
            this.pieChart.Legend.VerticalIndent = 12;
            this.pieChart.Location = new System.Drawing.Point(3, 3);
            this.pieChart.Name = "pieChart";
            this.pieChart.Padding.Right = 0;
            series1.ArgumentDataMember = "GroupName";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            doughnutSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            doughnutSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            doughnutSeriesLabel1.TextPattern = "{VP:P0}";
            series1.Label = doughnutSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "TotalCost";
            doughnutSeriesView1.HoleRadiusPercent = 45;
            series1.View = doughnutSeriesView1;
            this.pieChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            doughnutSeriesLabel2.TextPattern = "{VP:G2}";
            this.pieChart.SeriesTemplate.Label = doughnutSeriesLabel2;
            this.pieChart.SeriesTemplate.SeriesColorizer = null;
            this.pieChart.SeriesTemplate.View = doughnutSeriesView2;
            this.pieChart.Size = new System.Drawing.Size(455, 326);
            this.pieChart.TabIndex = 2;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.barChart, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.pieChart, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(922, 443);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // barChart
            // 
            this.barChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.barChart.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.CrosshairAxisLabelOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = false;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = false;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = false;
            xyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            xyDiagram1.AxisX.Reverse = true;
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.Tickmarks.Visible = false;
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 1D;
            xyDiagram1.AxisY.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowHide = false;
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowRotate = false;
            xyDiagram1.AxisY.Label.ResolveOverlappingOptions.AllowStagger = false;
            xyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            xyDiagram1.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisY.Tickmarks.Visible = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.Margins.Left = 38;
            xyDiagram1.Margins.Right = 2;
            xyDiagram1.Rotated = true;
            this.barChart.Diagram = xyDiagram1;
            this.barChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.barChart.Legend.Font = new System.Drawing.Font("Tahoma", 10F);
            this.barChart.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.None;
            this.barChart.Legend.MarkerSize = new System.Drawing.Size(1, 16);
            this.barChart.Legend.Name = "Default Legend";
            this.barChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.barChart.Location = new System.Drawing.Point(461, 0);
            this.barChart.Margin = new System.Windows.Forms.Padding(0);
            this.barChart.Name = "barChart";
            this.barChart.Padding.Bottom = 24;
            this.barChart.Padding.Left = 0;
            this.barChart.Padding.Right = 0;
            this.barChart.Padding.Top = 24;
            series2.ArgumentDataMember = "GroupName";
            sideBySideBarSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            sideBySideBarSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            sideBySideBarSeriesLabel1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Empty;
            sideBySideBarSeriesLabel1.Indent = 4;
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.TopInside;
            sideBySideBarSeriesLabel1.TextColor = System.Drawing.Color.White;
            sideBySideBarSeriesLabel1.TextPattern = "{V:N0}";
            series2.Label = sideBySideBarSeriesLabel1;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.LegendTextPattern = "{V:N1}";
            series2.Name = "Series 1";
            series2.ValueDataMembersSerializable = "TotalCost";
            sideBySideBarSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            sideBySideBarSeriesView1.ColorEach = true;
            series2.View = sideBySideBarSeriesView1;
            this.barChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.barChart.SeriesTemplate.SeriesColorizer = null;
            this.barChart.Size = new System.Drawing.Size(461, 332);
            this.barChart.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Controls.Add(this.rangeControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrev, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 335);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 105);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnPrev
            // 
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrev.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrev.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.ArrowLeft1;
            this.btnPrev.Location = new System.Drawing.Point(5, 3);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(44, 99);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.ArrowRight1;
            this.btnNext.Location = new System.Drawing.Point(876, 3);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(44, 99);
            this.btnNext.TabIndex = 3;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ucSalesByRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ucSalesByRange";
            this.Size = new System.Drawing.Size(922, 443);
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChart)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barChart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private XtraCharts.ChartControl pieChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private XtraEditors.RangeControl rangeControl;
        private XtraCharts.ChartControl barChart;
        private XtraEditors.SimpleButton btnNext;
        private XtraEditors.SimpleButton btnPrev;
    }
}
