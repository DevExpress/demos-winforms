using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DevExpress.XtraBars.Demos.RibbonSimplePad {
	public partial class frmReplace : DevExpress.XtraEditors.XtraForm {	
        RichTextBox rtb;
		public RichTextBox RichText {get { return rtb; } }

		public frmReplace(RichTextBox r, Rectangle rec) {	
			rtb = r;
			InitializeComponent();
			txtFind.Text = rtb.SelectedText;
			this.Location = new Point(rec.X + (rec.Width - this.Width) / 2, rec.Y + (rec.Height - this.Height) / 2);
			txtFind_TextChanged(null, null);
		}

		protected RichTextBoxFinds FindsOptions{
			get {
				RichTextBoxFinds rtf = new RichTextBoxFinds();
				if(chWholeword.Checked)
					rtf |= RichTextBoxFinds.WholeWord;
				if(chCase.Checked)
					rtf |= RichTextBoxFinds.MatchCase;
				return rtf;
			}
		}

		protected void MessageNotFound(int p) {
			if(p == -1)
				DevExpress.XtraEditors.XtraMessageBox.Show("The search text is not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		protected int Find() {
			return rtb.Find(txtFind.Text, rtb.SelectionStart + rtb.SelectionLength, rtb.MaxLength, FindsOptions);
		}

		protected int FindForReplace() {
			return rtb.Find(txtFind.Text, rtb.SelectionStart, rtb.MaxLength, FindsOptions);
		}

		private void btnFindNext_Click(object sender, System.EventArgs e) {
			MessageNotFound(Find());
		}

		private void txtFind_TextChanged(object sender, System.EventArgs e) {
			btnFindNext.Enabled = txtFind.Text != "";
			btnReplace.Enabled = btnFindNext.Enabled;
			btnReplaceAll.Enabled = btnFindNext.Enabled;
		}

		private void btnCancel_Click(object sender, System.EventArgs e) {
			Owner.Focus();
			Close();
		}

		private void btnReplace_Click(object sender, System.EventArgs e) {
			if(FindForReplace() != -1)
				rtb.SelectedText = txtReplace.Text;
			else 
				MessageNotFound(-1);
		}

		private void btnReplaceAll_Click(object sender, System.EventArgs e) {
			int r = -1;
			int p = 0;
			rtb.SelectionStart = 0;
			rtb.SelectionLength = 0;
			while(p != -1) {
				p = Find();
				if(p != -1) {
					r++;
					rtb.SelectedText = txtReplace.Text;
				}
			}
			MessageNotFound(r);
		}
	}
}
