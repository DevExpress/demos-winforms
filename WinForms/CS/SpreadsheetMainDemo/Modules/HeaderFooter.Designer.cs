using System;
using DevExpress.XtraEditors;

namespace DevExpress.XtraSpreadsheet.Demos {
    partial class HeaderFooterModule {
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
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.spreadsheetPreview1 = new DevExpress.XtraSpreadsheet.Demos.SpreadsheetPreview();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.btnPageSetup = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Location = new System.Drawing.Point(24, 74);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheetControl1.Size = new System.Drawing.Size(509, 303);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Visible = false;
            this.spreadsheetControl1.ContentChanged += new System.EventHandler(this.spreadsheetControl1_ContentChanged);
            // 
            // spreadsheetPreview1
            // 
            this.spreadsheetPreview1.CanShowBorders = true;
            this.spreadsheetPreview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetPreview1.Location = new System.Drawing.Point(0, 40);
            this.spreadsheetPreview1.Name = "spreadsheetPreview1";
            this.spreadsheetPreview1.PreviewZoom = DevExpress.XtraSpreadsheet.Demos.SpreadhsheetPreviewZoom.Default;
            this.spreadsheetPreview1.Size = new System.Drawing.Size(725, 416);
            this.spreadsheetPreview1.TabIndex = 7;
            this.spreadsheetPreview1.Workbook = null;
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.Controls.Add(this.btnPageSetup);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(725, 40);
            this.sidePanel1.TabIndex = 8;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnPageSetup.Location = new System.Drawing.Point(8, 8);
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(124, 23);
            this.btnPageSetup.TabIndex = 1;
            this.btnPageSetup.Text = "Headers/Footers";
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // HeaderFooterModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spreadsheetPreview1);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.spreadsheetControl1);
            this.Name = "HeaderFooterModule";
            this.Size = new System.Drawing.Size(725, 456);
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SpreadsheetControl spreadsheetControl1;
        private SpreadsheetPreview spreadsheetPreview1;
        private SidePanel sidePanel1;
        private SimpleButton btnPageSetup;
    }
}
