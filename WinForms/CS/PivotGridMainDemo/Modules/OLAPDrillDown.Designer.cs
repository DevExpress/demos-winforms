namespace DevExpress.XtraPivotGrid.Demos.Modules {
	partial class OLAPDrillDown {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.panelError = new DevExpress.XtraEditors.PanelControl();
            this.hyperLinkEdit1 = new DevExpress.XtraEditors.HyperLinkEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.controlPanel = new DevExpress.XtraEditors.PanelControl();
            this.paddingPanel = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelError)).BeginInit();
            this.panelError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).BeginInit();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.pivotGridControl.Size = new System.Drawing.Size(710, 350);
            this.pivotGridControl.TabIndex = 1;
            this.pivotGridControl.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pivotGridControl_CellDoubleClick);
            // 
            // panelError
            // 
            this.panelError.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelError.Controls.Add(this.hyperLinkEdit1);
            this.panelError.Controls.Add(this.labelControl2);
            this.panelError.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelError.Location = new System.Drawing.Point(2, 2);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(706, 48);
            this.panelError.TabIndex = 6;
            // 
            // hyperLinkEdit1
            // 
            this.hyperLinkEdit1.EditValue = "http://www.microsoft.com/en-us/download/details.aspx?id=16978#ASOLEDB";
            this.hyperLinkEdit1.Location = new System.Drawing.Point(454, 20);
            this.hyperLinkEdit1.Name = "hyperLinkEdit1";
            this.hyperLinkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.hyperLinkEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.hyperLinkEdit1.Properties.Caption = "www.microsoft.com";
            this.hyperLinkEdit1.Size = new System.Drawing.Size(100, 18);
            this.hyperLinkEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.AutoEllipsis = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(683, 28);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "To run this demo, you should have Microsoft SQL Server Analysis Services OLE DB 8" +
    ".0 (or later) \r\ninstalled on your system. You can get the latest version of this" +
    " provider here:";
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mainPanel.Controls.Add(this.pivotGridControl);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(710, 350);
            this.mainPanel.TabIndex = 11;
            // 
            // controlPanel
            // 
            this.controlPanel.AutoSize = true;
            this.controlPanel.Controls.Add(this.panelError);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(710, 52);
            this.controlPanel.TabIndex = 10;
            // 
            // paddingPanel
            // 
            this.paddingPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.paddingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paddingPanel.Location = new System.Drawing.Point(0, 52);
            this.paddingPanel.Name = "paddingPanel";
            this.paddingPanel.Size = new System.Drawing.Size(710, 8);
            this.paddingPanel.TabIndex = 12;
            // 
            // OLAPDrillDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.paddingPanel);
            this.Controls.Add(this.controlPanel);
            this.Name = "OLAPDrillDown";
            this.Size = new System.Drawing.Size(710, 410);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelError)).EndInit();
            this.panelError.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.controlPanel)).EndInit();
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paddingPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private PivotGridControl pivotGridControl;
		private DevExpress.XtraEditors.PanelControl panelError;
		private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEdit1;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.PanelControl mainPanel;
		private DevExpress.XtraEditors.PanelControl controlPanel;
		private DevExpress.XtraEditors.PanelControl paddingPanel;

	}
}
