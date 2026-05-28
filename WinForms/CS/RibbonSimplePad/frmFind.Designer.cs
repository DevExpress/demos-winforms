namespace DevExpress.XtraBars.Demos.RibbonSimplePad {
    partial class frmFind {

        #region Designer generated code
        private void InitializeComponent() {
            this.chWholeword = new DevExpress.XtraEditors.CheckEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtFind = new DevExpress.XtraEditors.TextEdit();
            this.chCase = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chWholeword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCase.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chWholeword
            // 
            this.chWholeword.Location = new System.Drawing.Point(8, 40);
            this.chWholeword.Name = "chWholeword";
            this.chWholeword.Properties.Caption = "Match whole word only";
            this.chWholeword.Size = new System.Drawing.Size(164, 19);
            this.chWholeword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Find what:";
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(248, 8);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(92, 27);
            this.btnFindNext.TabIndex = 3;
            this.btnFindNext.Text = "&Find Next";
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(248, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 27);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFind
            // 
            this.txtFind.EditValue = "";
            this.txtFind.Location = new System.Drawing.Point(80, 8);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(156, 20);
            this.txtFind.TabIndex = 0;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // chCase
            // 
            this.chCase.Location = new System.Drawing.Point(8, 63);
            this.chCase.Name = "chCase";
            this.chCase.Properties.Caption = "Match case";
            this.chCase.Size = new System.Drawing.Size(164, 19);
            this.chCase.TabIndex = 2;
            // 
            // frmFind
            // 
            this.AcceptButton = this.btnFindNext;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(350, 94);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.chCase);
            this.Controls.Add(this.chWholeword);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Find ";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.chWholeword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chCase.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.CheckEdit chWholeword;
        private DevExpress.XtraEditors.TextEdit txtFind;
        private DevExpress.XtraEditors.SimpleButton btnFindNext;
        private DevExpress.XtraEditors.CheckEdit chCase;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Label label1;

    }
}
