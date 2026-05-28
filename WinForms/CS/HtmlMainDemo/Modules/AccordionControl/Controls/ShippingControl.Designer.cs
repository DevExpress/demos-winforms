namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls {
    partial class ShippingControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShippingControl));
            this.htmlContentControl1 = new DevExpress.XtraEditors.HtmlContentControl();
            this.cityEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.stateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.codeEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.phoneEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.addressEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.addressEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlContentControl1
            // 
            this.htmlContentControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlContentControl1.HtmlTemplate.Styles = resources.GetString("htmlContentControl1.HtmlTemplate.Styles");
            this.htmlContentControl1.HtmlTemplate.Template = resources.GetString("htmlContentControl1.HtmlTemplate.Template");
            this.htmlContentControl1.Location = new System.Drawing.Point(0, 0);
            this.htmlContentControl1.Name = "htmlContentControl1";
            this.htmlContentControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cityEdit,
            this.stateEdit,
            this.codeEdit,
            this.phoneEdit,
            this.addressEdit1,
            this.addressEdit2});
            this.htmlContentControl1.Size = new System.Drawing.Size(570, 296);
            this.htmlContentControl1.TabIndex = 0;
            // 
            // cityEdit
            // 
            this.cityEdit.AutoHeight = false;
            this.cityEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cityEdit.Name = "cityEdit";
            this.cityEdit.NullValuePrompt = "City";
            this.cityEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // stateEdit
            // 
            this.stateEdit.AutoHeight = false;
            this.stateEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.stateEdit.Name = "stateEdit";
            this.stateEdit.NullValuePrompt = "State";
            this.stateEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // codeEdit
            // 
            this.codeEdit.AutoHeight = false;
            this.codeEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.codeEdit.Name = "codeEdit";
            this.codeEdit.NullValuePrompt = "Postal Code";
            this.codeEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // phoneEdit
            // 
            this.phoneEdit.AutoHeight = false;
            this.phoneEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.phoneEdit.Name = "phoneEdit";
            this.phoneEdit.NullValuePrompt = "Phone";
            this.phoneEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // addressEdit1
            // 
            this.addressEdit1.AutoHeight = false;
            this.addressEdit1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.addressEdit1.Name = "addressEdit1";
            this.addressEdit1.NullValuePrompt = "Address 1";
            this.addressEdit1.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // addressEdit2
            // 
            this.addressEdit2.AutoHeight = false;
            this.addressEdit2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.addressEdit2.Name = "addressEdit2";
            this.addressEdit2.NullValuePrompt = "Address 2";
            this.addressEdit2.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ShippingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.htmlContentControl1);
            this.Name = "ShippingControl";
            this.Size = new System.Drawing.Size(570, 296);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.HtmlContentControl htmlContentControl1;
        private XtraEditors.Repository.RepositoryItemTextEdit cityEdit;
        private XtraEditors.Repository.RepositoryItemTextEdit stateEdit;
        private XtraEditors.Repository.RepositoryItemTextEdit codeEdit;
        private XtraEditors.Repository.RepositoryItemTextEdit phoneEdit;
        private XtraEditors.Repository.RepositoryItemTextEdit addressEdit1;
        private XtraEditors.Repository.RepositoryItemTextEdit addressEdit2;
    }
}
