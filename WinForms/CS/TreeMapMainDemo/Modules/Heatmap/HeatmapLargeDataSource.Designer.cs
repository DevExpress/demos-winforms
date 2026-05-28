
namespace DevExpress.XtraTreeMap.Demos {
    partial class HeatmapLargeDataSource {
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
            DevExpress.XtraCharts.Heatmap.HeatmapObjectColorProvider heatmapObjectColorProvider1 = new DevExpress.XtraCharts.Heatmap.HeatmapObjectColorProvider();
            this.heatmapControl1 = new DevExpress.XtraCharts.Heatmap.HeatmapControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // heatmapControl1
            // 
            this.heatmapControl1.ColorProvider = heatmapObjectColorProvider1;
            this.heatmapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heatmapControl1.Location = new System.Drawing.Point(0, 0);
            this.heatmapControl1.Margin = new System.Windows.Forms.Padding(0);
            this.heatmapControl1.Name = "heatmapControl1";
            this.heatmapControl1.Padding = new System.Windows.Forms.Padding(5);
            this.heatmapControl1.Size = new System.Drawing.Size(500, 500);
            this.heatmapControl1.TabIndex = 0;
            this.heatmapControl1.Text = "heatmapControl1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // HeatmapLargeDataSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.heatmapControl1);
            this.Name = "HeatmapLargeDataSource";
            this.ResumeLayout(false);

        }

        #endregion

        private XtraCharts.Heatmap.HeatmapControl heatmapControl1;
        private System.Windows.Forms.Timer timer1;
    }
}
