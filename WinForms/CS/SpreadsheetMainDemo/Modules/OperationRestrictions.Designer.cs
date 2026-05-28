namespace DevExpress.XtraSpreadsheet.Demos {
    partial class OperationRestrictionsModule {
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
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.edtReadOnly = new DevExpress.XtraEditors.CheckEdit();
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtReadOnly.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Options.Print.PrintContent = DevExpress.XtraSpreadsheet.SpreadsheetPrintContent.ActiveSheets;
            this.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheetControl1.Options.View.Charts.TextAntialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled;
            this.spreadsheetControl1.Size = new System.Drawing.Size(788, 214);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 41);
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.AccessibleName = "Search Item";
            this.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl1.SearchEditItem.EditWidth = 150;
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(1037, 150);
            // 
            // sidePanel1
            // 
            this.sidePanel1.AllowResize = false;
            this.sidePanel1.Controls.Add(this.edtReadOnly);
            this.sidePanel1.Controls.Add(this.propertyGridControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(788, 191);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(249, 214);
            this.sidePanel1.TabIndex = 9;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // edtReadOnly
            // 
            this.edtReadOnly.Location = new System.Drawing.Point(8, 11);
            this.edtReadOnly.Name = "edtReadOnly";
            this.edtReadOnly.Properties.Caption = "ReadOnly";
            this.edtReadOnly.Size = new System.Drawing.Size(120, 20);
            this.edtReadOnly.TabIndex = 19;
            this.edtReadOnly.CheckedChanged += new System.EventHandler(this.ReadOnly_CheckedChanged);
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGridControl1.Location = new System.Drawing.Point(10, 36);
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.True;
            this.propertyGridControl1.Size = new System.Drawing.Size(232, 168);
            this.propertyGridControl1.TabIndex = 18;
            // 
            // OperationRestrictionsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel1);
            this.Name = "OperationRestrictionsModule";
            this.Size = new System.Drawing.Size(1037, 432);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.sidePanel1, 0);
            this.Controls.SetChildIndex(this.spreadsheetControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edtReadOnly.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraEditors.SidePanel sidePanel1;
        private XtraEditors.CheckEdit edtReadOnly;
        private XtraVerticalGrid.PropertyGridControl propertyGridControl1;
    }
}
