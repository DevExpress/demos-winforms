namespace DevExpress.XtraGauges.Demos {
    partial class GaugesDashboard {
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GaugesDashboard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.electricityGauge = new DevExpress.XtraGauges.Demos.GaugeContent();
            this.hotWGauge = new DevExpress.XtraGauges.Demos.GaugeContent();
            this.coldWGauge = new DevExpress.XtraGauges.Demos.GaugeContent();
            this.gasGauge = new DevExpress.XtraGauges.Demos.GaugeContent();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.electricityGauge, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.hotWGauge, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.coldWGauge, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gasGauge, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 600);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // electricityGauge
            // 
            this.electricityGauge.Caption = "Electricity";
            this.electricityGauge.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(24)))));
            this.electricityGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.electricityGauge.Hot = false;
            this.electricityGauge.Image = ((System.Drawing.Image)(resources.GetObject("electricityGauge.Image")));
            this.electricityGauge.Location = new System.Drawing.Point(343, 303);
            this.electricityGauge.Name = "electricityGauge";
            this.electricityGauge.Padding = new System.Windows.Forms.Padding(0, 15, 70, 20);
            this.electricityGauge.Selected = false;
            this.electricityGauge.Size = new System.Drawing.Size(335, 294);
            this.electricityGauge.TabIndex = 3;
            // 
            // hotWGauge
            // 
            this.hotWGauge.Caption = "Hot Water";
            this.hotWGauge.Color = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(53)))), ((int)(((byte)(67)))));
            this.hotWGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hotWGauge.Hot = false;
            this.hotWGauge.Image = ((System.Drawing.Image)(resources.GetObject("hotWGauge.Image")));
            this.hotWGauge.Location = new System.Drawing.Point(3, 303);
            this.hotWGauge.Name = "hotWGauge";
            this.hotWGauge.Padding = new System.Windows.Forms.Padding(70, 15, 0, 20);
            this.hotWGauge.Selected = false;
            this.hotWGauge.Size = new System.Drawing.Size(334, 294);
            this.hotWGauge.TabIndex = 2;
            // 
            // coldWGauge
            // 
            this.coldWGauge.Caption = "Cold Water";
            this.coldWGauge.Color = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(190)))), ((int)(((byte)(251)))));
            this.coldWGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coldWGauge.Hot = false;
            this.coldWGauge.Image = ((System.Drawing.Image)(resources.GetObject("coldWGauge.Image")));
            this.coldWGauge.Location = new System.Drawing.Point(343, 3);
            this.coldWGauge.Name = "coldWGauge";
            this.coldWGauge.Padding = new System.Windows.Forms.Padding(0, 30, 70, 0);
            this.coldWGauge.Selected = false;
            this.coldWGauge.Size = new System.Drawing.Size(335, 294);
            this.coldWGauge.TabIndex = 1;
            // 
            // gasGauge
            // 
            this.gasGauge.Caption = "Gas";
            this.gasGauge.Color = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(178)))), ((int)(((byte)(121)))));
            this.gasGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gasGauge.Hot = false;
            this.gasGauge.Image = ((System.Drawing.Image)(resources.GetObject("gasGauge.Image")));
            this.gasGauge.Location = new System.Drawing.Point(3, 3);
            this.gasGauge.Name = "gasGauge";
            this.gasGauge.Padding = new System.Windows.Forms.Padding(70, 30, 0, 0);
            this.gasGauge.Selected = false;
            this.gasGauge.Size = new System.Drawing.Size(334, 294);
            this.gasGauge.TabIndex = 0;
            // 
            // GaugesDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GaugesDashboard";
            this.Size = new System.Drawing.Size(681, 600);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GaugeContent electricityGauge;
        private GaugeContent hotWGauge;
        private GaugeContent coldWGauge;
        private GaugeContent gasGauge;
    }
}
