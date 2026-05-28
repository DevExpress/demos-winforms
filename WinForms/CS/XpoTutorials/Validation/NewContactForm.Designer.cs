namespace DevExpress.Xpo.Demos {
    partial class NewContactForm {
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
            this.lcFirstName = new DevExpress.XtraEditors.LabelControl();
            this.lcLastName = new DevExpress.XtraEditors.LabelControl();
            this.lcAddress = new DevExpress.XtraEditors.LabelControl();
            this.lcEmail = new DevExpress.XtraEditors.LabelControl();
            this.lcPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teAddress = new DevExpress.XtraEditors.TextEdit();
            this.teEmail = new DevExpress.XtraEditors.TextEdit();
            this.tePhone = new DevExpress.XtraEditors.TextEdit();
            this.sbOk = new DevExpress.XtraEditors.SimpleButton();
            this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhone.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lcFirstName
            // 
            this.lcFirstName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lcFirstName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lcFirstName.Location = new System.Drawing.Point(28, 83);
            this.lcFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lcFirstName.Name = "lcFirstName";
            this.lcFirstName.Size = new System.Drawing.Size(75, 16);
            this.lcFirstName.TabIndex = 0;
            this.lcFirstName.Text = "*First Name:";
            // 
            // lcLastName
            // 
            this.lcLastName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lcLastName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lcLastName.Location = new System.Drawing.Point(28, 117);
            this.lcLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lcLastName.Name = "lcLastName";
            this.lcLastName.Size = new System.Drawing.Size(73, 16);
            this.lcLastName.TabIndex = 1;
            this.lcLastName.Text = "*Last Name:";
            // 
            // lcAddress
            // 
            this.lcAddress.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lcAddress.Location = new System.Drawing.Point(28, 151);
            this.lcAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lcAddress.Name = "lcAddress";
            this.lcAddress.Size = new System.Drawing.Size(51, 16);
            this.lcAddress.TabIndex = 2;
            this.lcAddress.Text = "Address:";
            // 
            // lcEmail
            // 
            this.lcEmail.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lcEmail.Location = new System.Drawing.Point(28, 186);
            this.lcEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lcEmail.Name = "lcEmail";
            this.lcEmail.Size = new System.Drawing.Size(36, 16);
            this.lcEmail.TabIndex = 3;
            this.lcEmail.Text = "Email:";
            // 
            // lcPhoneNumber
            // 
            this.lcPhoneNumber.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lcPhoneNumber.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lcPhoneNumber.Location = new System.Drawing.Point(28, 220);
            this.lcPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lcPhoneNumber.Name = "lcPhoneNumber";
            this.lcPhoneNumber.Size = new System.Drawing.Size(89, 16);
            this.lcPhoneNumber.TabIndex = 4;
            this.lcPhoneNumber.Text = "Phone Number:";
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(140, 80);
            this.teFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Size = new System.Drawing.Size(187, 22);
            this.teFirstName.TabIndex = 5;
            this.teFirstName.Validated += new System.EventHandler(this.teFirstName_Validated);
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(140, 114);
            this.teLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.teLastName.Name = "teLastName";
            this.teLastName.Size = new System.Drawing.Size(187, 22);
            this.teLastName.TabIndex = 6;
            this.teLastName.Validated += new System.EventHandler(this.teFirstName_Validated);
            // 
            // teAddress
            // 
            this.teAddress.Location = new System.Drawing.Point(140, 148);
            this.teAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.teAddress.Name = "teAddress";
            this.teAddress.Size = new System.Drawing.Size(187, 22);
            this.teAddress.TabIndex = 7;
            // 
            // teEmail
            // 
            this.teEmail.Location = new System.Drawing.Point(140, 182);
            this.teEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.teEmail.Name = "teEmail";
            this.teEmail.Size = new System.Drawing.Size(187, 22);
            this.teEmail.TabIndex = 8;
            // 
            // tePhone
            // 
            this.tePhone.Location = new System.Drawing.Point(140, 217);
            this.tePhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tePhone.Name = "tePhone";
            this.tePhone.Properties.Mask.EditMask = "(999)000-00-00";
            this.tePhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.tePhone.Size = new System.Drawing.Size(121, 22);
            this.tePhone.TabIndex = 9;
            // 
            // sbOk
            // 
            this.sbOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sbOk.Enabled = false;
            this.sbOk.Location = new System.Drawing.Point(75, 308);
            this.sbOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbOk.Name = "sbOk";
            this.sbOk.Size = new System.Drawing.Size(87, 33);
            this.sbOk.TabIndex = 10;
            this.sbOk.Text = "OK";
            // 
            // sbCancel
            // 
            this.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbCancel.Location = new System.Drawing.Point(168, 308);
            this.sbCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(87, 33);
            this.sbCancel.TabIndex = 11;
            this.sbCancel.Text = "Cancel";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(269, 16);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = " * Fields marked with an asterisk are required.";
            // 
            // NewContactForm
            // 
            this.AcceptButton = this.sbOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.sbCancel;
            this.ClientSize = new System.Drawing.Size(344, 352);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lcPhoneNumber);
            this.Controls.Add(this.lcEmail);
            this.Controls.Add(this.lcAddress);
            this.Controls.Add(this.lcLastName);
            this.Controls.Add(this.lcFirstName);
            this.Controls.Add(this.sbCancel);
            this.Controls.Add(this.sbOk);
            this.Controls.Add(this.tePhone);
            this.Controls.Add(this.teEmail);
            this.Controls.Add(this.teAddress);
            this.Controls.Add(this.teLastName);
            this.Controls.Add(this.teFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Contact";
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhone.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lcFirstName;
        private DevExpress.XtraEditors.LabelControl lcLastName;
        private DevExpress.XtraEditors.LabelControl lcAddress;
        private DevExpress.XtraEditors.LabelControl lcEmail;
        private DevExpress.XtraEditors.LabelControl lcPhoneNumber;
        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.TextEdit teAddress;
        private DevExpress.XtraEditors.TextEdit teEmail;
        private DevExpress.XtraEditors.TextEdit tePhone;
        private DevExpress.XtraEditors.SimpleButton sbOk;
        private DevExpress.XtraEditors.SimpleButton sbCancel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.ComponentModel.IContainer components = null;

    }
}
