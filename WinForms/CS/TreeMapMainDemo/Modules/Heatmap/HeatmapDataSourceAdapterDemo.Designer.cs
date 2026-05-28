
namespace DevExpress.XtraTreeMap.Demos {
    partial class HeatmapDataSourceAdapterDemo {
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
            DevExpress.XtraCharts.Heatmap.HeatmapRangeColorProvider heatmapRangeColorProvider1 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeColorProvider();
            DevExpress.XtraCharts.Heatmap.HeatmapRangeStop heatmapRangeStop1 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeStop();
            DevExpress.XtraCharts.Heatmap.HeatmapRangeStop heatmapRangeStop2 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeStop();
            DevExpress.XtraCharts.Heatmap.HeatmapRangeStop heatmapRangeStop3 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeStop();
            DevExpress.XtraCharts.Heatmap.HeatmapRangeStop heatmapRangeStop4 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeStop();
            DevExpress.XtraCharts.Heatmap.HeatmapRangeStop heatmapRangeStop5 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeStop();
            DevExpress.XtraCharts.Heatmap.HeatmapRangeStop heatmapRangeStop6 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeStop();
            DevExpress.XtraCharts.Heatmap.HeatmapRangeStop heatmapRangeStop7 = new DevExpress.XtraCharts.Heatmap.HeatmapRangeStop();
            DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter heatmapDataSourceAdapter1 = new DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter();
            DevExpress.XtraCharts.Heatmap.HeatmapTitle heatmapTitle1 = new DevExpress.XtraCharts.Heatmap.HeatmapTitle();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.heatmapControl1 = new DevExpress.XtraCharts.Heatmap.HeatmapControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.heatmapControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(547, 235, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(500, 500);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // heatmapControl1
            // 
            heatmapRangeColorProvider1.ApproximateColors = true;
            heatmapRangeColorProvider1.LegendItemPattern = "{V1} - {V2}";
            heatmapRangeColorProvider1.PaletteName = "Balance of Trade";
            heatmapRangeStop1.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage;
            heatmapRangeStop1.Value = 0D;
            heatmapRangeStop2.Value = -10D;
            heatmapRangeStop3.Value = -2.5D;
            heatmapRangeStop4.Value = 0D;
            heatmapRangeStop5.Value = 2.5D;
            heatmapRangeStop6.Value = 10D;
            heatmapRangeStop7.Type = DevExpress.XtraCharts.Heatmap.HeatmapRangeStopType.Percentage;
            heatmapRangeStop7.Value = 1D;
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop1);
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop2);
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop3);
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop4);
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop5);
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop6);
            heatmapRangeColorProvider1.RangeStops.Add(heatmapRangeStop7);
            this.heatmapControl1.ColorProvider = heatmapRangeColorProvider1;
            heatmapDataSourceAdapter1.ColorDataMember = "Value";
            heatmapDataSourceAdapter1.XArgumentDataMember = "Country";
            heatmapDataSourceAdapter1.YArgumentDataMember = "Product";
            this.heatmapControl1.DataAdapter = heatmapDataSourceAdapter1;
            this.heatmapControl1.HighlightMode = DevExpress.XtraCharts.Heatmap.HeatmapHighlightMode.RowAndColumn;
            this.heatmapControl1.Label.Visible = true;
            this.heatmapControl1.Location = new System.Drawing.Point(0, 0);
            this.heatmapControl1.Margin = new System.Windows.Forms.Padding(0);
            this.heatmapControl1.Name = "heatmapControl1";
            this.heatmapControl1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.heatmapControl1.PaletteRepository.Add("Balance of Trade", new DevExpress.XtraCharts.Palette("Balance of Trade", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(47)))), ((int)(((byte)(66))))), System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(47)))), ((int)(((byte)(66)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.White, System.Drawing.Color.White),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(125))))), System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(139)))), ((int)(((byte)(125))))))}));
            this.heatmapControl1.Size = new System.Drawing.Size(500, 500);
            this.heatmapControl1.TabIndex = 0;
            this.heatmapControl1.Text = "heatmapControl1";
            heatmapTitle1.Text = "Balance of Trade";
            this.heatmapControl1.Titles.Add(heatmapTitle1);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(500, 500);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.heatmapControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(500, 500);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // HeatmapDataSourceAdapterDemo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "HeatmapDataSourceAdapterDemo";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraCharts.Heatmap.HeatmapControl heatmapControl1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
