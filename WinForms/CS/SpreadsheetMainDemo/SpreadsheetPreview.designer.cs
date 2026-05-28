namespace DevExpress.XtraSpreadsheet.Demos {
	partial class SpreadsheetPreview
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.documentViewerSinglePreview = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(623, 244);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(623, 244);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(629, 272);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // documentViewerSinglePreview
            // 
            this.documentViewerSinglePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewerSinglePreview.IsMetric = true;
            this.documentViewerSinglePreview.Location = new System.Drawing.Point(0, 0);
            this.documentViewerSinglePreview.Name = "documentViewerSinglePreview";
            this.documentViewerSinglePreview.Size = new System.Drawing.Size(629, 272);
            this.documentViewerSinglePreview.TabIndex = 2;
            // 
            // SpreadsheetPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.documentViewerSinglePreview);
            this.Name = "SpreadsheetPreview";
            this.Size = new System.Drawing.Size(629, 272);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private XtraTab.XtraTabPage xtraTabPage2;
        private XtraTab.XtraTabPage xtraTabPage1;
        private XtraTab.XtraTabControl xtraTabControl1;
        private XtraPrinting.Preview.DocumentViewer documentViewerSinglePreview;
	}
}
