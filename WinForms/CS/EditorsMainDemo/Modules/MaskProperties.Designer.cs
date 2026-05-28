namespace DevExpress.XtraEditors.Demos {
    partial class MaskProperties {
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ceUseMaskAsDisplayFormat = new DevExpress.XtraEditors.CheckEdit();
            this.ceShowPlaceHolder = new DevExpress.XtraEditors.CheckEdit();
            this.ceSaveLiteral = new DevExpress.XtraEditors.CheckEdit();
            this.ceIgnoreMaskBlank = new DevExpress.XtraEditors.CheckEdit();
            this.cbPlaceHolder = new DevExpress.XtraEditors.ComboBoxEdit();
            this.teEditMask = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.lbMaskType = new DevExpress.XtraEditors.LabelControl();
            this.ceBeepOnError = new DevExpress.XtraEditors.CheckEdit();
            this.icbAutoComplete = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceUseMaskAsDisplayFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowPlaceHolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSaveLiteral.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIgnoreMaskBlank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlaceHolder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEditMask.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceBeepOnError.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbAutoComplete.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ceUseMaskAsDisplayFormat);
            this.groupControl1.Controls.Add(this.ceShowPlaceHolder);
            this.groupControl1.Controls.Add(this.ceSaveLiteral);
            this.groupControl1.Controls.Add(this.ceIgnoreMaskBlank);
            this.groupControl1.Controls.Add(this.cbPlaceHolder);
            this.groupControl1.Controls.Add(this.teEditMask);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.lbMaskType);
            this.groupControl1.Controls.Add(this.ceBeepOnError);
            this.groupControl1.Controls.Add(this.icbAutoComplete);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.MinimumSize = new System.Drawing.Size(350, 270);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(350, 270);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Mask properties";
            // 
            // ceUseMaskAsDisplayFormat
            // 
            this.ceUseMaskAsDisplayFormat.Location = new System.Drawing.Point(18, 234);
            this.ceUseMaskAsDisplayFormat.Name = "ceUseMaskAsDisplayFormat";
            this.ceUseMaskAsDisplayFormat.Properties.Caption = "Use mask as display format";
            this.ceUseMaskAsDisplayFormat.Size = new System.Drawing.Size(184, 20);
            this.ceUseMaskAsDisplayFormat.TabIndex = 8;
            this.ceUseMaskAsDisplayFormat.TabStop = false;
            this.ceUseMaskAsDisplayFormat.CheckedChanged += new System.EventHandler(this.ceUseMaskAsDisplayFormat_CheckedChanged);
            // 
            // ceShowPlaceHolder
            // 
            this.ceShowPlaceHolder.Location = new System.Drawing.Point(18, 210);
            this.ceShowPlaceHolder.Name = "ceShowPlaceHolder";
            this.ceShowPlaceHolder.Properties.Caption = "Show place holders";
            this.ceShowPlaceHolder.Size = new System.Drawing.Size(184, 20);
            this.ceShowPlaceHolder.TabIndex = 7;
            this.ceShowPlaceHolder.TabStop = false;
            this.ceShowPlaceHolder.CheckedChanged += new System.EventHandler(this.ceShowPlaceHolder_CheckedChanged);
            // 
            // ceSaveLiteral
            // 
            this.ceSaveLiteral.Location = new System.Drawing.Point(18, 186);
            this.ceSaveLiteral.Name = "ceSaveLiteral";
            this.ceSaveLiteral.Properties.Caption = "Save literals";
            this.ceSaveLiteral.Size = new System.Drawing.Size(184, 20);
            this.ceSaveLiteral.TabIndex = 6;
            this.ceSaveLiteral.TabStop = false;
            this.ceSaveLiteral.CheckedChanged += new System.EventHandler(this.ceSaveLiteral_CheckedChanged);
            // 
            // ceIgnoreMaskBlank
            // 
            this.ceIgnoreMaskBlank.Location = new System.Drawing.Point(18, 162);
            this.ceIgnoreMaskBlank.Name = "ceIgnoreMaskBlank";
            this.ceIgnoreMaskBlank.Properties.Caption = "Ignore mask blanks";
            this.ceIgnoreMaskBlank.Size = new System.Drawing.Size(184, 20);
            this.ceIgnoreMaskBlank.TabIndex = 5;
            this.ceIgnoreMaskBlank.TabStop = false;
            this.ceIgnoreMaskBlank.CheckedChanged += new System.EventHandler(this.ceIgnoreMaskBlank_CheckedChanged);
            // 
            // cbPlaceHolder
            // 
            this.cbPlaceHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPlaceHolder.EditValue = "_";
            this.cbPlaceHolder.Location = new System.Drawing.Point(123, 109);
            this.cbPlaceHolder.Name = "cbPlaceHolder";
            this.cbPlaceHolder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPlaceHolder.Properties.Items.AddRange(new object[] {
            "_",
            "*",
            ".",
            "~"});
            this.cbPlaceHolder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbPlaceHolder.Size = new System.Drawing.Size(208, 20);
            this.cbPlaceHolder.TabIndex = 3;
            this.cbPlaceHolder.TabStop = false;
            this.cbPlaceHolder.SelectedIndexChanged += new System.EventHandler(this.cbPlaceHolder_SelectedIndexChanged);
            // 
            // teEditMask
            // 
            this.teEditMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teEditMask.EditValue = "";
            this.teEditMask.Location = new System.Drawing.Point(123, 51);
            this.teEditMask.Name = "teEditMask";
            this.teEditMask.Size = new System.Drawing.Size(208, 20);
            this.teEditMask.TabIndex = 1;
            this.teEditMask.TabStop = false;
            this.teEditMask.EditValueChanged += new System.EventHandler(this.teEditMask_EditValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Edit mask:";
            // 
            // lbMaskType
            // 
            this.lbMaskType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMaskType.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lbMaskType.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbMaskType.Appearance.Options.UseBackColor = true;
            this.lbMaskType.Appearance.Options.UseFont = true;
            this.lbMaskType.Appearance.Options.UseTextOptions = true;
            this.lbMaskType.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.lbMaskType.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lbMaskType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbMaskType.Location = new System.Drawing.Point(123, 32);
            this.lbMaskType.Name = "lbMaskType";
            this.lbMaskType.Size = new System.Drawing.Size(208, 13);
            this.lbMaskType.TabIndex = 21;
            this.lbMaskType.Text = "Member";
            // 
            // ceBeepOnError
            // 
            this.ceBeepOnError.Location = new System.Drawing.Point(18, 138);
            this.ceBeepOnError.Name = "ceBeepOnError";
            this.ceBeepOnError.Properties.Caption = "Beep on error";
            this.ceBeepOnError.Size = new System.Drawing.Size(184, 20);
            this.ceBeepOnError.TabIndex = 4;
            this.ceBeepOnError.TabStop = false;
            this.ceBeepOnError.CheckedChanged += new System.EventHandler(this.ceBeepOnError_CheckedChanged);
            // 
            // icbAutoComplete
            // 
            this.icbAutoComplete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.icbAutoComplete.EditValue = "imageComboBoxEdit1";
            this.icbAutoComplete.Location = new System.Drawing.Point(123, 80);
            this.icbAutoComplete.Name = "icbAutoComplete";
            this.icbAutoComplete.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbAutoComplete.Size = new System.Drawing.Size(208, 20);
            this.icbAutoComplete.TabIndex = 2;
            this.icbAutoComplete.TabStop = false;
            this.icbAutoComplete.SelectedIndexChanged += new System.EventHandler(this.icbAutoComplete_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Place holder:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Auto-complete:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mask type:";
            // 
            // MaskProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.MinimumSize = new System.Drawing.Size(280, 270);
            this.Name = "MaskProperties";
            this.Size = new System.Drawing.Size(350, 270);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceUseMaskAsDisplayFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowPlaceHolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSaveLiteral.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceIgnoreMaskBlank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlaceHolder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEditMask.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceBeepOnError.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbAutoComplete.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label4;
        private System.ComponentModel.Container components = null;
        private DevExpress.XtraEditors.CheckEdit ceBeepOnError;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbAutoComplete;
        private DevExpress.XtraEditors.LabelControl lbMaskType;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit teEditMask;
        private DevExpress.XtraEditors.ComboBoxEdit cbPlaceHolder;
        private DevExpress.XtraEditors.CheckEdit ceIgnoreMaskBlank;
        private DevExpress.XtraEditors.CheckEdit ceSaveLiteral;
        private DevExpress.XtraEditors.CheckEdit ceShowPlaceHolder;
        private DevExpress.XtraEditors.CheckEdit ceUseMaskAsDisplayFormat;

    }
}
