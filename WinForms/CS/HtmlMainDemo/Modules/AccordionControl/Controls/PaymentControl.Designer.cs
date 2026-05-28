namespace DevExpress.HTML.Demos.Modules.AccordionControl.Controls {
    partial class PaymentControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentControl));
            this.htmlContentControl1 = new DevExpress.XtraEditors.HtmlContentControl();
            this.cardNumberEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cardHolderEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.thruEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.cvcEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardNumberEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardHolderEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thruEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvcEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlContentControl1
            // 
            this.htmlContentControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.htmlContentControl1.HtmlTemplate.Styles = resources.GetString("htmlContentControl1.HtmlTemplate.Styles");
            this.htmlContentControl1.HtmlTemplate.Template = resources.GetString("htmlContentControl1.HtmlTemplate.Template");
            this.htmlContentControl1.Location = new System.Drawing.Point(0, 0);
            this.htmlContentControl1.Name = "htmlContentControl1";
            this.htmlContentControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cardNumberEdit,
            this.cardHolderEdit,
            this.thruEdit,
            this.cvcEdit});
            this.htmlContentControl1.Size = new System.Drawing.Size(567, 186);
            this.htmlContentControl1.TabIndex = 0;
            // 
            // cardNumberEdit
            // 
            this.cardNumberEdit.AutoHeight = false;
            this.cardNumberEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cardNumberEdit.Name = "cardNumberEdit";
            this.cardNumberEdit.NullValuePrompt = "Card Number";
            this.cardNumberEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // cardHolderEdit
            // 
            this.cardHolderEdit.AutoHeight = false;
            this.cardHolderEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cardHolderEdit.Name = "cardHolderEdit";
            this.cardHolderEdit.NullValuePrompt = "Card Holder";
            this.cardHolderEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // thruEdit
            // 
            this.thruEdit.AutoHeight = false;
            this.thruEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.thruEdit.Name = "thruEdit";
            this.thruEdit.NullValuePrompt = "Valid Thru";
            this.thruEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // cvcEdit
            // 
            this.cvcEdit.AutoHeight = false;
            this.cvcEdit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.cvcEdit.Name = "cvcEdit";
            this.cvcEdit.NullValuePrompt = "CVC";
            this.cvcEdit.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // PaymentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.htmlContentControl1);
            this.Name = "PaymentControl";
            this.Size = new System.Drawing.Size(567, 186);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardNumberEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardHolderEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thruEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvcEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.HtmlContentControl htmlContentControl1;
        private XtraEditors.Repository.RepositoryItemTextEdit cardNumberEdit;
        private XtraEditors.Repository.RepositoryItemTextEdit cardHolderEdit;
        private XtraEditors.Repository.RepositoryItemTextEdit thruEdit;
        private XtraEditors.Repository.RepositoryItemTextEdit cvcEdit;
    }
}
