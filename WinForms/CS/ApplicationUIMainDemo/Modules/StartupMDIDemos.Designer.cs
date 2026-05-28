namespace DevExpress.ApplicationUI.Demos {
    partial class StartupMDIDemos {
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
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.sbStart = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // sbClose
            // 
            this.sbClose.Location = new System.Drawing.Point(21, 49);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(136, 26);
            this.sbClose.TabIndex = 3;
            this.sbClose.Text = "Close Sample";
            this.sbClose.Click += new System.EventHandler(this.sbClose_Click);
            // 
            // sbStart
            // 
            this.sbStart.Location = new System.Drawing.Point(21, 17);
            this.sbStart.Name = "sbStart";
            this.sbStart.Size = new System.Drawing.Size(136, 26);
            this.sbStart.TabIndex = 2;
            this.sbStart.Text = "Launch Sample";
            this.sbStart.Click += new System.EventHandler(this.sbStart_Click);
            // 
            // StartupMDIDemos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sbStart);
            this.Controls.Add(this.sbClose);
            this.Name = "StartupMDIDemos";
            this.Size = new System.Drawing.Size(774, 437);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraEditors.SimpleButton sbStart;
    }
}
