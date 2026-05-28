namespace DevExpress.XtraGauges.Demos {
    partial class ColorSchemeGauges {
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
            this.colorPickControl1 = new DevExpress.XtraGauges.Demos.ColorPickerControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gaugesDashboard1 = new DevExpress.XtraGauges.Demos.GaugesDashboard();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorPickControl1
            // 
            this.colorPickControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPickControl1.Location = new System.Drawing.Point(0, 10);
            this.colorPickControl1.Margin = new System.Windows.Forms.Padding(10);
            this.colorPickControl1.Name = "colorPickControl1";
            this.colorPickControl1.Size = new System.Drawing.Size(267, 600);
            this.colorPickControl1.TabIndex = 1;
            this.colorPickControl1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.colorPickControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(485, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.panel1.Size = new System.Drawing.Size(277, 620);
            this.panel1.TabIndex = 2;
            // 
            // gaugesDashboard1
            // 
            this.gaugesDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugesDashboard1.Location = new System.Drawing.Point(0, 0);
            this.gaugesDashboard1.Name = "gaugesDashboard1";
            this.gaugesDashboard1.Size = new System.Drawing.Size(485, 620);
            this.gaugesDashboard1.TabIndex = 3;
            // 
            // ColorSchemeGauges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gaugesDashboard1);
            this.Controls.Add(this.panel1);
            this.Name = "ColorSchemeGauges";
            this.Size = new System.Drawing.Size(762, 620);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private ColorPickerControl colorPickControl1;
        private System.Windows.Forms.Panel panel1;
        private GaugesDashboard gaugesDashboard1;
    }
}
