namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls {
    partial class InformationControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationControl));
            this.htmlContentControl1 = new DevExpress.XtraEditors.HtmlContentControl();
            this.firstNameEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.lastNameEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.birthdayEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.emailEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailEdit)).BeginInit();
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
            this.firstNameEdit,
            this.lastNameEdit,
            this.birthdayEdit,
            this.emailEdit});
            this.htmlContentControl1.Size = new System.Drawing.Size(354, 182);
            this.htmlContentControl1.TabIndex = 0;
            // 
            // firstNameEdit
            // 
            this.firstNameEdit.AutoHeight = false;
            this.firstNameEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.firstNameEdit.Name = "firstNameEdit";
            this.firstNameEdit.NullValuePrompt = "First Name";
            this.firstNameEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // lastNameEdit
            // 
            this.lastNameEdit.AutoHeight = false;
            this.lastNameEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lastNameEdit.Name = "lastNameEdit";
            this.lastNameEdit.NullValuePrompt = "Last Name";
            this.lastNameEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // birthdayEdit
            // 
            this.birthdayEdit.AutoHeight = false;
            this.birthdayEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.birthdayEdit.Name = "birthdayEdit";
            this.birthdayEdit.NullValuePrompt = "Date of Birth";
            this.birthdayEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // emailEdit
            // 
            this.emailEdit.AutoHeight = false;
            this.emailEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.emailEdit.Name = "emailEdit";
            this.emailEdit.NullValuePrompt = "Email";
            this.emailEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // InformationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.htmlContentControl1);
            this.Name = "InformationControl";
            this.Size = new System.Drawing.Size(354, 182);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.HtmlContentControl htmlContentControl1;
        private XtraEditors.Repository.RepositoryItemTextEdit firstNameEdit;
        private XtraEditors.Repository.RepositoryItemTextEdit lastNameEdit;
        private XtraEditors.Repository.RepositoryItemTextEdit birthdayEdit;
        private XtraEditors.Repository.RepositoryItemTextEdit emailEdit;
    }
}
