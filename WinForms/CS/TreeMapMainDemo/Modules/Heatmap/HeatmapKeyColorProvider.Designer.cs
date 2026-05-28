
namespace DevExpress.XtraTreeMap.Demos {
    partial class HeatmapKeyColorProvider {
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.Heatmap.HeatmapKeyColorProvider heatmapKeyColorProvider1 = new DevExpress.XtraCharts.Heatmap.HeatmapKeyColorProvider();
            DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter heatmapDataSourceAdapter1 = new DevExpress.XtraCharts.Heatmap.HeatmapDataSourceAdapter();
            DevExpress.XtraCharts.Heatmap.HeatmapTitle heatmapTitle1 = new DevExpress.XtraCharts.Heatmap.HeatmapTitle();
            this.heatmapControl1 = new DevExpress.XtraCharts.Heatmap.HeatmapControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.SuspendLayout();
            // 
            // heatmapControl1
            // 
            heatmapKeyColorProvider1.Keys.Add("Fast");
            heatmapKeyColorProvider1.Keys.Add("Average");
            heatmapKeyColorProvider1.Keys.Add("Slow");
            heatmapKeyColorProvider1.PaletteName = "Performance Monitoring";
            this.heatmapControl1.ColorProvider = heatmapKeyColorProvider1;
            heatmapDataSourceAdapter1.ColorDataMember = "Value";
            heatmapDataSourceAdapter1.XArgumentDataMember = "Date";
            heatmapDataSourceAdapter1.YArgumentDataMember = "Application";
            this.heatmapControl1.DataAdapter = heatmapDataSourceAdapter1;
            this.heatmapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heatmapControl1.HighlightMode = DevExpress.XtraCharts.Heatmap.HeatmapHighlightMode.RowAndColumn;
            this.heatmapControl1.Location = new System.Drawing.Point(0, 0);
            this.heatmapControl1.Margin = new System.Windows.Forms.Padding(0);
            this.heatmapControl1.Name = "heatmapControl1";
            this.heatmapControl1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.heatmapControl1.PaletteRepository.Add("Performance Monitoring", new DevExpress.XtraCharts.Palette("Performance Monitoring", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.LightGreen, System.Drawing.Color.LightGreen),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Yellow, System.Drawing.Color.Yellow),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.IndianRed, System.Drawing.Color.IndianRed)}));
            this.heatmapControl1.Size = new System.Drawing.Size(750, 808);
            this.heatmapControl1.TabIndex = 0;
            this.heatmapControl1.Text = "heatmapControl1";
            heatmapTitle1.Text = "Website Performance Monitor";
            this.heatmapControl1.Titles.Add(heatmapTitle1);
            this.heatmapControl1.ToolTipController = this.toolTipController1;
            this.heatmapControl1.ToolTipEnabled = true;
            // 
            // toolTipController1
            // 
            this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
            // 
            // HeatmapKeyColorProvider
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.heatmapControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HeatmapKeyColorProvider";
            this.Size = new System.Drawing.Size(750, 808);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraCharts.Heatmap.HeatmapControl heatmapControl1;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}
