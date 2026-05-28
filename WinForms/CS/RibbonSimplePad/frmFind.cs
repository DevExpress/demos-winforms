using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DevExpress.XtraBars.Demos.RibbonSimplePad {
    public partial class frmFind : DevExpress.XtraEditors.XtraForm {
        RichTextBox rtb;
        public RichTextBox RichText { get { return rtb; } }

        public frmFind(RichTextBox r, Rectangle rec) {
            rtb = r;
            rtb.SelectionStart = 0;
            InitializeComponent();
            this.Location = new Point(rec.X + (rec.Width - this.Width) / 2, rec.Y + (rec.Height - this.Height) / 2);
            txtFind_TextChanged(null, null);
        }

        private void btnFindNext_Click(object sender, System.EventArgs e) {
            RichTextBoxFinds rtf = new RichTextBoxFinds();
            if(chWholeword.Checked)
                rtf |= RichTextBoxFinds.WholeWord;
            if(chCase.Checked)
                rtf |= RichTextBoxFinds.MatchCase;
            int p = rtb.Find(txtFind.Text, rtb.SelectionStart + rtb.SelectionLength, rtb.MaxLength, rtf);
            if(p == -1)
                DevExpress.XtraEditors.XtraMessageBox.Show("The search text is not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtFind_TextChanged(object sender, System.EventArgs e) {
            btnFindNext.Enabled = txtFind.Text != "";
        }

        private void btnCancel_Click(object sender, System.EventArgs e) {
            Owner.Focus();
            Close();
        }
    }
}
