namespace DevExpress.SalesDemo.Win.Modules {
    partial class ucSalesPerformance {
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
            DevExpress.XtraCharts.TextAnnotation textAnnotation1 = new DevExpress.XtraCharts.TextAnnotation();
            DevExpress.XtraCharts.ChartAnchorPoint chartAnchorPoint1 = new DevExpress.XtraCharts.ChartAnchorPoint();
            DevExpress.XtraCharts.FreePosition freePosition1 = new DevExpress.XtraCharts.FreePosition();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView1 = new DevExpress.XtraCharts.AreaSeriesView();
            DevExpress.XtraCharts.AreaSeriesView areaSeriesView2 = new DevExpress.XtraCharts.AreaSeriesView();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.captionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnForward = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreviousDate = new DevExpress.XtraEditors.CheckButton();
            this.btnCurrentDate = new DevExpress.XtraEditors.CheckButton();
            this.valuePresenter1 = new DevExpress.SalesDemo.Win.Modules.ucValuePresenter();
            this.valuePresenter0 = new DevExpress.SalesDemo.Win.Modules.ucValuePresenter();
            this.valuePresenter2 = new DevExpress.SalesDemo.Win.Modules.ucValuePresenter();
            this.layoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView2)).BeginInit();
            this.captionPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.layoutPanel.ColumnCount = 1;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.Controls.Add(this.chart, 0, 1);
            this.layoutPanel.Controls.Add(this.captionPanel, 0, 0);
            this.layoutPanel.Controls.Add(this.buttonsPanel, 0, 2);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.layoutPanel.RowCount = 3;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutPanel.Size = new System.Drawing.Size(724, 711);
            this.layoutPanel.TabIndex = 1;
            // 
            // chart
            // 
            chartAnchorPoint1.X = 50;
            chartAnchorPoint1.Y = 30;
            textAnnotation1.AnchorPoint = chartAnchorPoint1;
            textAnnotation1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            textAnnotation1.ConnectorStyle = DevExpress.XtraCharts.AnnotationConnectorStyle.None;
            textAnnotation1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            textAnnotation1.Name = "Text Annotation 1";
            textAnnotation1.Padding.Bottom = 7;
            textAnnotation1.Padding.Left = 7;
            textAnnotation1.Padding.Right = 10;
            textAnnotation1.Padding.Top = 7;
            textAnnotation1.Shadow.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            textAnnotation1.Shadow.Size = 1;
            textAnnotation1.ShapeKind = DevExpress.XtraCharts.ShapeKind.Rectangle;
            freePosition1.DockTargetName = "Default Pane";
            textAnnotation1.ShapePosition = freePosition1;
            this.chart.AnnotationRepository.AddRange(new DevExpress.XtraCharts.Annotation[] {
            textAnnotation1});
            this.chart.BackColor = System.Drawing.Color.Transparent;
            this.chart.BorderOptions.Visibility = Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.CrosshairAxisLabelOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowHide = false;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = false;
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = false;
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.Tickmarks.Visible = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.Label.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisY.Tickmarks.Visible = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Transparent;
            xyDiagram1.Margins.Left = 35;
            xyDiagram1.Margins.Right = 21;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chart.Legend.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chart.Legend.MarkerSize = new System.Drawing.Size(1, 16);
            this.chart.Legend.MarkerMode = XtraCharts.LegendMarkerMode.None;
            this.chart.Legend.Visibility = Utils.DefaultBoolean.False;
            this.chart.Location = new System.Drawing.Point(0, 45);
            this.chart.Margin = new System.Windows.Forms.Padding(0);
            this.chart.Name = "chart";
            this.chart.Padding.Left = 0;
            this.chart.Padding.Right = 0;
            pointSeriesLabel1.TextPattern = "{V:N0}";
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            areaSeriesView1.Border.Visibility = Utils.DefaultBoolean.False;
            areaSeriesView1.Transparency = ((byte)(64));
            series1.View = areaSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            areaSeriesView2.Transparency = ((byte)(0));
            this.chart.SeriesTemplate.View = areaSeriesView2;
            this.chart.Size = new System.Drawing.Size(724, 621);
            this.chart.TabIndex = 0;
            // 
            // captionPanel
            // 
            this.captionPanel.ColumnCount = 4;
            this.captionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.captionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.captionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.captionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.captionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.captionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.captionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.captionPanel.Controls.Add(this.valuePresenter1, 2, 0);
            this.captionPanel.Controls.Add(this.valuePresenter0, 1, 0);
            this.captionPanel.Controls.Add(this.valuePresenter2, 3, 0);
            this.captionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captionPanel.Location = new System.Drawing.Point(0, 5);
            this.captionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.captionPanel.Name = "captionPanel";
            this.captionPanel.RowCount = 1;
            this.captionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.captionPanel.Size = new System.Drawing.Size(724, 40);
            this.captionPanel.TabIndex = 1;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.ColumnCount = 6;
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.buttonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.buttonsPanel.Controls.Add(this.btnBack, 1, 0);
            this.buttonsPanel.Controls.Add(this.btnForward, 4, 0);
            this.buttonsPanel.Controls.Add(this.btnPreviousDate, 2, 0);
            this.buttonsPanel.Controls.Add(this.btnCurrentDate, 3, 0);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 666);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.RowCount = 1;
            this.buttonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsPanel.Size = new System.Drawing.Size(724, 40);
            this.buttonsPanel.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Image = global::DevExpress.ProductsDemo.Win.Properties.Resources.ArrowLeft;
            this.btnBack.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBack.Location = new System.Drawing.Point(35, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 34);
            this.btnBack.TabIndex = 0;
            this.btnBack.Click += new System.EventHandler(this.btnBackClick);
            // 
            // btnForward
            // 
            this.btnForward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForward.Image = global::DevExpress.ProductsDemo.Win.Properties.Resources.ArrowRight;
            this.btnForward.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnForward.Location = new System.Drawing.Point(659, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(44, 34);
            this.btnForward.TabIndex = 1;
            this.btnForward.Click += new System.EventHandler(this.btnForwardClick);
            // 
            // btnPreviousDate
            // 
            this.btnPreviousDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPreviousDate.Location = new System.Drawing.Point(85, 3);
            this.btnPreviousDate.Name = "btnPreviousDate";
            this.btnPreviousDate.Size = new System.Drawing.Size(281, 34);
            this.btnPreviousDate.TabIndex = 2;
            this.btnPreviousDate.Text = "prev";
            this.btnPreviousDate.Click += new System.EventHandler(this.btnPreviousDateClick);
            // 
            // btnCurrentDate
            // 
            this.btnCurrentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCurrentDate.Location = new System.Drawing.Point(372, 3);
            this.btnCurrentDate.Name = "btnCurrentDate";
            this.btnCurrentDate.Size = new System.Drawing.Size(281, 34);
            this.btnCurrentDate.TabIndex = 3;
            this.btnCurrentDate.Text = "current";
            this.btnCurrentDate.Click += new System.EventHandler(this.btnCurrentDateClick);
            // 
            // valuePresenter1
            // 
            this.valuePresenter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuePresenter1.Location = new System.Drawing.Point(264, 0);
            this.valuePresenter1.Margin = new System.Windows.Forms.Padding(0);
            this.valuePresenter1.Name = "valuePresenter1";
            this.valuePresenter1.Size = new System.Drawing.Size(229, 40);
            this.valuePresenter1.TabIndex = 9;
            this.valuePresenter1.TitleText = "title";
            this.valuePresenter1.Value = 0D;
            this.valuePresenter1.ValueFormat = "${0:N0}";
            this.valuePresenter1.ValueTextColor = System.Drawing.SystemColors.ControlText;
            // 
            // valuePresenter0
            // 
            this.valuePresenter0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuePresenter0.Location = new System.Drawing.Point(35, 0);
            this.valuePresenter0.Margin = new System.Windows.Forms.Padding(0);
            this.valuePresenter0.Name = "valuePresenter0";
            this.valuePresenter0.Size = new System.Drawing.Size(229, 40);
            this.valuePresenter0.TabIndex = 8;
            this.valuePresenter0.TitleText = "title";
            this.valuePresenter0.Value = 0D;
            this.valuePresenter0.ValueFormat = "${0:N0}";
            this.valuePresenter0.ValueTextColor = System.Drawing.SystemColors.ControlText;
            // 
            // valuePresenter2
            // 
            this.valuePresenter2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuePresenter2.Location = new System.Drawing.Point(493, 0);
            this.valuePresenter2.Margin = new System.Windows.Forms.Padding(0);
            this.valuePresenter2.Name = "valuePresenter2";
            this.valuePresenter2.Size = new System.Drawing.Size(231, 40);
            this.valuePresenter2.TabIndex = 10;
            this.valuePresenter2.TitleText = "title";
            this.valuePresenter2.Value = 0D;
            this.valuePresenter2.ValueFormat = "${0:N0}";
            this.valuePresenter2.ValueTextColor = System.Drawing.SystemColors.ControlText;
            // 
            // ucSalesPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutPanel);
            this.Name = "ucSalesPerformance";
            this.Size = new System.Drawing.Size(724, 711);
            this.layoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(textAnnotation1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(areaSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.captionPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        public XtraCharts.ChartControl chart;
        private System.Windows.Forms.TableLayoutPanel captionPanel;
        private System.Windows.Forms.TableLayoutPanel buttonsPanel;
        private XtraEditors.SimpleButton btnBack;
        private XtraEditors.SimpleButton btnForward;
        private XtraEditors.CheckButton btnPreviousDate;
        private XtraEditors.CheckButton btnCurrentDate;
        private ucValuePresenter valuePresenter0;
        private ucValuePresenter valuePresenter1;
        private ucValuePresenter valuePresenter2;
    }
}
