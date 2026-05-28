namespace DevExpress.DevAV.Modules {
    partial class QuoteView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FunnelSeriesLabel funnelSeriesLabel1 = new DevExpress.XtraCharts.FunnelSeriesLabel();
            DevExpress.XtraCharts.FunnelSeriesView funnelSeriesView1 = new DevExpress.XtraCharts.FunnelSeriesView();
            DevExpress.XtraCharts.FunnelSeriesView funnelSeriesView2 = new DevExpress.XtraCharts.FunnelSeriesView();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesView2)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.chartControl.AccessibleName = "";
            this.chartControl.AllowDrop = true;
            this.chartControl.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chartControl.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl.Legend.DXFont = new DevExpress.Drawing.DXFont("Segoe UI", 8F);
            this.chartControl.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl.Legend.Margins.Bottom = 0;
            this.chartControl.Legend.Margins.Left = 0;
            this.chartControl.Legend.Margins.Right = 0;
            this.chartControl.Legend.Margins.Top = 0;
            this.chartControl.Legend.MarkerSize = new System.Drawing.Size(20, 20);
            this.chartControl.Legend.Padding.Bottom = 0;
            this.chartControl.Legend.Padding.Left = 0;
            this.chartControl.Legend.Padding.Right = 0;
            this.chartControl.Legend.Padding.Top = 40;
            this.chartControl.Location = new System.Drawing.Point(0, 0);
            this.chartControl.Name = "chartControl";
            this.chartControl.Padding.Bottom = 40;
            this.chartControl.Padding.Left = 40;
            this.chartControl.Padding.Right = 40;
            this.chartControl.Padding.Top = 40;
            this.chartControl.PaletteName = "Opportunities Palette";
            this.chartControl.PaletteRepository.Add("Opportunities Palette", new DevExpress.XtraCharts.Palette("Opportunities Palette", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(108)))), ((int)(((byte)(41))))), System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(108)))), ((int)(((byte)(41)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(135)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(135)))), ((int)(((byte)(184)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135))))), System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135))))))}));
            funnelSeriesLabel1.BackColor = System.Drawing.Color.Transparent;
            funnelSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            funnelSeriesLabel1.DXFont = new DevExpress.Drawing.DXFont("Segoe UI", 10F);
            funnelSeriesLabel1.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.True;
            funnelSeriesLabel1.Position = DevExpress.XtraCharts.FunnelSeriesLabelPosition.Center;
            funnelSeriesLabel1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            funnelSeriesLabel1.TextPattern = "{V:c}";
            series1.Label = funnelSeriesLabel1;
            series1.LegendTextPattern = "{A}";
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            funnelSeriesView1.AlignToCenter = true;
            series1.View = funnelSeriesView1;
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl.SeriesTemplate.View = funnelSeriesView2;
            this.chartControl.Size = new System.Drawing.Size(458, 572);
            this.chartControl.TabIndex = 6;
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl);
            this.Name = "QuoteView";
            this.Size = new System.Drawing.Size(458, 572);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(funnelSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private XtraCharts.ChartControl chartControl;
    }
}
