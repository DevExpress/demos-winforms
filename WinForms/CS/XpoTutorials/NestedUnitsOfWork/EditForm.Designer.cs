namespace DevExpress.Xpo.Demos {
    partial class EditForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.lbName = new DevExpress.XtraEditors.LabelControl();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.imageComboBoxEdit2 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.teOwner = new DevExpress.XtraEditors.TextEdit();
            this.deCreatedDate = new DevExpress.XtraEditors.DateEdit();
            this.bSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOwner.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCreatedDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCreatedDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Appearance.Font = new System.Drawing.Font("Arial Black", 10F);
            this.lbName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.LineVisible = true;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(42, 18);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // imageComboBoxEdit1
            // 
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(153, 97);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit1.Size = new System.Drawing.Size(128, 20);
            this.imageComboBoxEdit1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(73, 143);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Status:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(73, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Type:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(73, 193);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(69, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Created Date:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(74, 56);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Owner:";
            // 
            // imageComboBoxEdit2
            // 
            this.imageComboBoxEdit2.Location = new System.Drawing.Point(153, 143);
            this.imageComboBoxEdit2.Name = "imageComboBoxEdit2";
            this.imageComboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit2.Size = new System.Drawing.Size(128, 20);
            this.imageComboBoxEdit2.TabIndex = 6;
            // 
            // teOwner
            // 
            this.teOwner.Location = new System.Drawing.Point(153, 53);
            this.teOwner.Name = "teOwner";
            this.teOwner.Size = new System.Drawing.Size(128, 20);
            this.teOwner.TabIndex = 7;
            // 
            // deCreatedDate
            // 
            this.deCreatedDate.EditValue = null;
            this.deCreatedDate.Location = new System.Drawing.Point(153, 190);
            this.deCreatedDate.Name = "deCreatedDate";
            this.deCreatedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deCreatedDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deCreatedDate.Size = new System.Drawing.Size(128, 20);
            this.deCreatedDate.TabIndex = 8;
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bSave.Image = ((System.Drawing.Image)(resources.GetObject("bSave.Image")));
            this.bSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.bSave.Location = new System.Drawing.Point(307, 231);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(32, 27);
            this.bSave.TabIndex = 9;
            this.bSave.ToolTip = "Save Changes";
            // 
            // EditForm
            // 
            this.AcceptButton = this.bSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 268);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.deCreatedDate);
            this.Controls.Add(this.teOwner);
            this.Controls.Add(this.imageComboBoxEdit2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.imageComboBoxEdit1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project Edit Form";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teOwner.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCreatedDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deCreatedDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit2;
        private DevExpress.XtraEditors.TextEdit teOwner;
        private DevExpress.XtraEditors.DateEdit deCreatedDate;
        private DevExpress.XtraEditors.SimpleButton bSave;
        private DevExpress.XtraEditors.LabelControl lbName;

    }
}
