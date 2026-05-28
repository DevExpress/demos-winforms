using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraNavBar.Demos {
	/// <summary>
	/// Summary description for NavBarHints.
	/// </summary>
	public partial class NavBarHints : TutorialControl {
		public NavBarHints() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			InitProperties();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void InitProperties() {
			ceGroupHint.Checked = navBarControl1.ShowGroupHint;
			ceLinkHint.Checked = navBarControl1.ShowLinkHint;
			seInterval.Value = navBarControl1.ShowHintInterval;
		}

        //<ceCustomHint>
		private void navBarControl1_GetHint(object sender, DevExpress.XtraNavBar.NavBarGetHintEventArgs e) {
			if(!ceCustomHint.Checked) return;
			string s = "This is a custom hint for the ";
			if(e.Group != null)
				e.Hint = s + e.Group.Caption + " group";
			if(e.Link != null)
				e.Hint = s + e.Link.Caption + " link";
		}
        //</ceCustomHint>

        //<ceGroupHint>
		private void ceGroupHint_CheckedChanged(object sender, System.EventArgs e) {
			navBarControl1.ShowGroupHint = ceGroupHint.Checked;
		}
        //</ceGroupHint>

        //<ceLinkHint>
		private void ceLinkHint_CheckedChanged(object sender, System.EventArgs e) {
			navBarControl1.ShowLinkHint = ceLinkHint.Checked;
		}
        //</ceLinkHint>

        //<seInterval>
		private void seInterval_EditValueChanged(object sender, System.EventArgs e) {
			navBarControl1.ShowHintInterval = Convert.ToInt32(seInterval.Value);
		}
        //</seInterval>
	}
}
