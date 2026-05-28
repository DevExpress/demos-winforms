namespace DevExpress.XtraScheduler.Demos {
    partial class SchedulerPrint {
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
            this.printSettingsControl = new DevExpress.XtraScheduler.Demos.ReportPrintControl();
            this.reportPreviewControl1 = new DevExpress.XtraScheduler.Demos.ReportPreviewControl();
            this.controlPrintAdapter1 = new DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.controlPrintAdapter1)).BeginInit();
            this.SuspendLayout();
            // 
            // printSettingsControl
            // 
            this.printSettingsControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.printSettingsControl.Location = new System.Drawing.Point(0, 0);
            this.printSettingsControl.Name = "printSettingsControl";
            this.printSettingsControl.Size = new System.Drawing.Size(310, 531);
            this.printSettingsControl.TabIndex = 0;
            this.printSettingsControl.PrintClick += new System.EventHandler(this.OnSettingsControlPrintClick);
            this.printSettingsControl.PrintOptionsClick += new System.EventHandler(this.OnSettingsControlPrintOptionsClick);
            // 
            // reportPreviewControl1
            // 
            this.reportPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportPreviewControl1.Location = new System.Drawing.Point(310, 0);
            this.reportPreviewControl1.Name = "reportPreviewControl1";
            this.reportPreviewControl1.Size = new System.Drawing.Size(420, 531);
            this.reportPreviewControl1.TabIndex = 1;
            // 
            // SchedulerPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportPreviewControl1);
            this.Controls.Add(this.printSettingsControl);
            this.Name = "SchedulerPrint";
            this.Size = new System.Drawing.Size(730, 531);
            ((System.ComponentModel.ISupportInitialize)(this.controlPrintAdapter1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.Demos.ReportPrintControl printSettingsControl;
        private DevExpress.XtraScheduler.Demos.ReportPreviewControl reportPreviewControl1;
        private DevExpress.XtraScheduler.Reporting.SchedulerControlPrintAdapter controlPrintAdapter1;
    }
}
