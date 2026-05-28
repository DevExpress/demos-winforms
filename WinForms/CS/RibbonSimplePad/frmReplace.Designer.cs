namespace DevExpress.XtraBars.Demos.RibbonSimplePad {
    partial class frmReplace {

        #region Designer generated code
        private void InitializeComponent() {
            this.btnReplace = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chCase = new DevExpress.XtraEditors.CheckEdit();
            this.txtFind = new DevExpress.XtraEditors.TextEdit();
            this.chWholeword = new DevExpress.XtraEditors.CheckEdit();
            this.btnReplaceAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnFindNext = new DevExpress.XtraEditors.SimpleButton();
            this.txtReplace = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chCase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chWholeword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReplace.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(256, 40);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(92, 28);
            this.btnReplace.TabIndex = 5;
            this.btnReplace.Text = "&Replace";
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Replace with:";
            // 
            // chCase
            // 
            this.chCase.Location = new System.Drawing.Point(8, 104);
            this.chCase.Name = "chCase";
            this.chCase.Properties.Caption = "Match case";
            this.chCase.Size = new System.Drawing.Size(164, 19);
            this.chCase.TabIndex = 3;
            // 
            // txtFind
            // 
            this.txtFind.EditValue = "";
            this.txtFind.Location = new System.Drawing.Point(88, 8);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(156, 20);
            this.txtFind.TabIndex = 0;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // chWholeword
            // 
            this.chWholeword.Location = new System.Drawing.Point(8, 80);
            this.chWholeword.Name = "chWholeword";
            this.chWholeword.Properties.Caption = "Match whole word only";
            this.chWholeword.Size = new System.Drawing.Size(164, 19);
            this.chWholeword.TabIndex = 2;
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(256, 72);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(92, 28);
            this.btnReplaceAll.TabIndex = 6;
            this.btnReplaceAll.Text = "Replace A&ll";
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(256, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(256, 8);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(92, 27);
            this.btnFindNext.TabIndex = 4;
            this.btnFindNext.Text = "&Find Next";
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // txtReplace
            // 
            this.txtReplace.EditValue = "";
            this.txtReplace.Location = new System.Drawing.Point(88, 40);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(156, 20);
            this.txtReplace.TabIndex = 1;
            // 
            // frmReplace
            // 
            this.AcceptButton = this.btnFindNext;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(361, 150);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.chCase);
            this.Controls.Add(this.chWholeword);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Replace";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.chCase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chWholeword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReplace.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.CheckEdit chWholeword;
        private DevExpress.XtraEditors.TextEdit txtFind;
        private DevExpress.XtraEditors.SimpleButton btnFindNext;
        private DevExpress.XtraEditors.CheckEdit chCase;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtReplace;
        private DevExpress.XtraEditors.SimpleButton btnReplaceAll;
        private DevExpress.XtraEditors.SimpleButton btnReplace;
        private System.Windows.Forms.Label label1;

    }
}
