namespace DevExpress.ApplicationUI.Demos {
    partial class Weather {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weather));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.weatherItem1 = new DevExpress.ApplicationUI.Demos.WeatherItem();
            this.weatherItem2 = new DevExpress.ApplicationUI.Demos.WeatherItem();
            this.weatherItem3 = new DevExpress.ApplicationUI.Demos.WeatherItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.weatherItem1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.weatherItem2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.weatherItem3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(340, 256);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // weatherItem1
            // 
            this.weatherItem1.BackColor = System.Drawing.Color.Transparent;
            this.weatherItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weatherItem1.Image = ((System.Drawing.Image)(resources.GetObject("weatherItem1.Image")));
            this.weatherItem1.Location = new System.Drawing.Point(116, 3);
            this.weatherItem1.Name = "weatherItem1";
            this.weatherItem1.RelativeHumidity = "94%";
            this.weatherItem1.Sity = "Moscow";
            this.weatherItem1.Size = new System.Drawing.Size(107, 250);
            this.weatherItem1.SkyConditions = "Cloudy";
            this.weatherItem1.TabIndex = 2;
            this.weatherItem1.Temperature = "23F (-5C)";
            // 
            // weatherItem2
            // 
            this.weatherItem2.BackColor = System.Drawing.Color.Transparent;
            this.weatherItem2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weatherItem2.Image = ((System.Drawing.Image)(resources.GetObject("weatherItem2.Image")));
            this.weatherItem2.Location = new System.Drawing.Point(3, 3);
            this.weatherItem2.Name = "weatherItem2";
            this.weatherItem2.RelativeHumidity = "86%";
            this.weatherItem2.Sity = "London";
            this.weatherItem2.Size = new System.Drawing.Size(107, 250);
            this.weatherItem2.SkyConditions = "Showers";
            this.weatherItem2.TabIndex = 2;
            this.weatherItem2.Temperature = "37F (3C)";
            // 
            // weatherItem3
            // 
            this.weatherItem3.BackColor = System.Drawing.Color.Transparent;
            this.weatherItem3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weatherItem3.Image = ((System.Drawing.Image)(resources.GetObject("weatherItem3.Image")));
            this.weatherItem3.Location = new System.Drawing.Point(229, 3);
            this.weatherItem3.Name = "weatherItem3";
            this.weatherItem3.RelativeHumidity = "81%";
            this.weatherItem3.Sity = "New York";
            this.weatherItem3.Size = new System.Drawing.Size(108, 250);
            this.weatherItem3.SkyConditions = "Clear";
            this.weatherItem3.TabIndex = 3;
            this.weatherItem3.Temperature = "25F (-3C)";
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Weather";
            this.Size = new System.Drawing.Size(340, 256);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private WeatherItem weatherItem1;
        private WeatherItem weatherItem2;
        private WeatherItem weatherItem3;
    }
}
