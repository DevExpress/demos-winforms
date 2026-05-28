using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;

namespace DevExpress.XtraNavBar.Demos {
	/// <summary>
	/// Summary description for NavBarInfo.
	/// </summary>
	public partial class NavBarInfo : TutorialControl {
		public NavBarInfo() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void button1_Click(object sender, System.EventArgs e) {
			SimpleButton btn = sender as SimpleButton;
			XtraForm frm = new XtraForm();
			MemoEdit mEdit = new MemoEdit();
			mEdit.Dock = DockStyle.Fill;
			mEdit.Text = GetNavBarInfo(navBarControl1);
			mEdit.Select(0, 0);
			frm.Controls.Add(mEdit);
			frm.Location = btn.PointToScreen(new Point(btn.Width / 2, btn.Height / 2));
			frm.StartPosition = FormStartPosition.Manual;
			frm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
			frm.Text = "NavBar Control";
			frm.ShowDialog();
		}

        //<button1>
		private string GetNavBarInfo(DevExpress.XtraNavBar.NavBarControl nbc) {
			string s = "Items:\r\n";
			for(int i = 0; i < nbc.Items.Count; i++)
				s += " Item" + i.ToString() + ": " + nbc.Items[i].Caption + "\r\n";
			s += "\r\nGroups:\r\n";
			for(int i = 0; i < nbc.Groups.Count; i++) {
				s += "  Group" + i.ToString() + ": " + nbc.Groups[i].Caption + "\r\n";
				s += "    ItemLinks:\r\n";
				for(int j = 0; j < nbc.Groups[i].ItemLinks.Count; j++) 
					s += "      Link" + j.ToString() + ": " + nbc.Groups[i].ItemLinks[j].Caption + "\r\n";
			}
			return s;
		}
        //</button1>
	}
}
