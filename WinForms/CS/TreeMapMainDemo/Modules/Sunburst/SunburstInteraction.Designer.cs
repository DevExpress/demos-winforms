namespace DevExpress.XtraTreeMap.Demos {
    partial class SunburstInteraction {
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

        //#region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraTreeMap.SunburstFlatDataAdapter sunburstFlatDataAdapter1 = new DevExpress.XtraTreeMap.SunburstFlatDataAdapter();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.SeriesKeyColorColorizer seriesKeyColorColorizer1 = new DevExpress.XtraCharts.SeriesKeyColorColorizer();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView1 = new DevExpress.XtraCharts.StackedBarSeriesView();
            this.sunburstControl1 = new DevExpress.XtraTreeMap.SunburstControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.sunburstControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sunburstControl1
            // 
            this.sunburstControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.sunburstControl1.CenterLabel.TextPattern = "DevAV\r\nBranches\r\nSales";
            sunburstFlatDataAdapter1.GroupDataMembersSerializable = "Company;Category";
            sunburstFlatDataAdapter1.LabelDataMember = "Product";
            sunburstFlatDataAdapter1.ValueDataMember = "Income";
            this.sunburstControl1.DataAdapter = sunburstFlatDataAdapter1;
            this.sunburstControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sunburstControl1.Location = new System.Drawing.Point(0, 0);
            this.sunburstControl1.Name = "sunburstControl1";
            this.sunburstControl1.Padding = new System.Windows.Forms.Padding(20);
            this.sunburstControl1.SelectionMode = DevExpress.XtraTreeMap.ElementSelectionMode.Multiple;
            this.sunburstControl1.Size = new System.Drawing.Size(83, 500);
            this.sunburstControl1.StartAngle = 45D;
            this.sunburstControl1.TabIndex = 0;
            this.sunburstControl1.ToolTipTextPattern = "{L}: ${V}M";
            this.sunburstControl1.SelectionChanged += new DevExpress.XtraTreeMap.SelectionChangedEventHandler(this.SunburstControl1_SelectionChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.AutoLayout = false;
            this.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.AxisX.MinorCount = 1;
            xyDiagram1.AxisX.Tickmarks.MinorLength = 5;
            xyDiagram1.AxisX.Tickmarks.Visible = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.GridLines.Visible = false;
            xyDiagram1.AxisY.MinorCount = 3;
            xyDiagram1.AxisY.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Transparent;
            xyDiagram1.DefaultPane.BorderVisible = false;
            xyDiagram1.Rotated = true;
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left;
            this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(83, 0);
            this.chartControl1.Margin = new System.Windows.Forms.Padding(5);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Padding.Bottom = 20;
            this.chartControl1.Padding.Left = 20;
            this.chartControl1.Padding.Right = 20;
            this.chartControl1.Padding.Top = 20;
            this.chartControl1.SeriesDataMember = "Company";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "Product";
            this.chartControl1.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer1;
            this.chartControl1.SeriesTemplate.SeriesDataMember = "Company";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Income";
            this.chartControl1.SeriesTemplate.View = stackedBarSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(417, 500);
            this.chartControl1.TabIndex = 11;
            // 
            // SunburstInteraction
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.sunburstControl1);
            this.Controls.Add(this.chartControl1);
            this.Name = "SunburstInteraction";
            this.Resize += new System.EventHandler(this.SunburstInteraction_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.sunburstControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }
        private SunburstControl sunburstControl1;
        private XtraCharts.ChartControl chartControl1;
    }
}

