namespace DevExpress.XtraNavBar.Demos {
    partial class frmLinkProperties {
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
            this.cbItem = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbLinkItem = new DevExpress.XtraEditors.LabelControl();
            this.txtCaption = new DevExpress.XtraEditors.TextEdit();
            this.lbCaption = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.lbImages = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.cbItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbItem
            // 
            this.cbItem.Location = new System.Drawing.Point(88, 37);
            this.cbItem.Name = "cbItem";
            this.cbItem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbItem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbItem.Size = new System.Drawing.Size(152, 20);
            this.cbItem.TabIndex = 1;
            this.cbItem.SelectedIndexChanged += new System.EventHandler(this.cbItem_SelectedIndexChanged);
            // 
            // lbLinkItem
            // 
            this.lbLinkItem.Location = new System.Drawing.Point(8, 42);
            this.lbLinkItem.Name = "lbLinkItem";
            this.lbLinkItem.Size = new System.Drawing.Size(44, 13);
            this.lbLinkItem.TabIndex = 14;
            this.lbLinkItem.Text = "LinkItem:";
            // 
            // txtCaption
            // 
            this.txtCaption.EditValue = "";
            this.txtCaption.Location = new System.Drawing.Point(88, 9);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(152, 20);
            this.txtCaption.TabIndex = 0;
            // 
            // lbCaption
            // 
            this.lbCaption.Location = new System.Drawing.Point(8, 9);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(66, 13);
            this.lbCaption.TabIndex = 0;
            this.lbCaption.Text = "Item Caption:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(160, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 26);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(71, 134);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(80, 26);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            // 
            // lbImages
            // 
            this.lbImages.Location = new System.Drawing.Point(8, 74);
            this.lbImages.Name = "lbImages";
            this.lbImages.Size = new System.Drawing.Size(39, 13);
            this.lbImages.TabIndex = 15;
            this.lbImages.Text = "Images:";
            // 
            // frmLinkProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 166);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.lbImages);
            this.Controls.Add(this.lbLinkItem);
            this.Controls.Add(this.lbCaption);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLinkProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Link Properties";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmLinkProperties_Paint);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLinkProperties_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.cbItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.ComboBoxEdit cbItem;
        private DevExpress.XtraEditors.LabelControl lbLinkItem;
        private DevExpress.XtraEditors.TextEdit txtCaption;
        private DevExpress.XtraEditors.LabelControl lbCaption;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.ComponentModel.Container components = null;
        private DevExpress.XtraEditors.LabelControl lbImages;

    }
}
