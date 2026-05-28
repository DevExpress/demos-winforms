namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class About {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
			this.rtbAbout = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.xtraTabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// xtraTabControl1
			// 
			this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
			this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
			this.xtraTabControl1.Size = new System.Drawing.Size(524, 457);
			this.xtraTabControl1.TabIndex = 1;
			this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
			this.xtraTabControl1.Text = "xtraTabControl1";
			// 
			// xtraTabPage1
			// 
			this.xtraTabPage1.Controls.Add(this.rtbAbout);
			this.xtraTabPage1.Name = "xtraTabPage1";
			this.xtraTabPage1.Size = new System.Drawing.Size(515, 448);
			this.xtraTabPage1.Text = "xtraTabPage1";
			// 
			// rtbAbout
			// 
			this.rtbAbout.BackColor = System.Drawing.SystemColors.Window;
			this.rtbAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbAbout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbAbout.Location = new System.Drawing.Point(0, 0);
			this.rtbAbout.Name = "rtbAbout";
			this.rtbAbout.ReadOnly = true;
			this.rtbAbout.Size = new System.Drawing.Size(515, 448);
			this.rtbAbout.TabIndex = 1;
			this.rtbAbout.Text = "";
			// 
			// About
			// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.xtraTabControl1);
			this.Name = "About";
			this.Size = new System.Drawing.Size(524, 457);
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.xtraTabControl1.ResumeLayout(false);
			this.xtraTabPage1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

		private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
		private System.Windows.Forms.RichTextBox rtbAbout;

    }
}
