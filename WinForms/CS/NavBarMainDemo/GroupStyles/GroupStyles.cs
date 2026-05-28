using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraNavBar.Demos {
	/// <summary>
	/// Summary description for GroupStyles.
	/// </summary>
	public partial class GroupStyles : TutorialControl {
		public GroupStyles() {
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
            if(navBarControl1.LinkSelectionMode == LinkSelectionModeType.None)
                ceAllowSelectedLink.Checked = false;
            else ceAllowSelectedLink.Checked = true;
			AddGroupStyleItems(cbLocalStyle);
			AddGroupStyleItems(cbContactStyle);
			AddGroupImageStyle(cbLocalImage);
			AddGroupImageStyle(cbContactImage);
			cbLocalStyle.Text = navBarGroup1.GroupStyle.ToString();
			cbContactStyle.Text = navBarGroup2.GroupStyle.ToString();
			cbLocalImage.Text = navBarGroup1.GroupCaptionUseImage.ToString();
			cbContactImage.Text = navBarGroup2.GroupCaptionUseImage.ToString();
		}

		private void ceAllowSelectedLink_CheckedChanged(object sender, System.EventArgs e) {
            if(navBarControl1.LinkSelectionMode == LinkSelectionModeType.None && ceAllowSelectedLink.Checked)
                navBarControl1.LinkSelectionMode = LinkSelectionModeType.OneInControl;
            if(!(navBarControl1.LinkSelectionMode == LinkSelectionModeType.None) && !ceAllowSelectedLink.Checked)
                navBarControl1.LinkSelectionMode = LinkSelectionModeType.None;
		}

		void AddGroupImageStyle(DevExpress.XtraEditors.ComboBoxEdit cb) {
			foreach(string _name in System.Enum.GetNames(typeof(DevExpress.XtraNavBar.NavBarImage)))
					cb.Properties.Items.Add(_name);
		}

		void AddGroupStyleItems(DevExpress.XtraEditors.ComboBoxEdit cb) {
			foreach(string _name in System.Enum.GetNames(typeof(DevExpress.XtraNavBar.NavBarGroupStyle)))
				if(_name.IndexOf("Text") > 0)
					cb.Properties.Items.Add(_name);
		}

		DevExpress.XtraNavBar.NavBarGroupStyle GetGroupStyleByString(object sender) {
			DevExpress.XtraEditors.ComboBoxEdit cb = sender as DevExpress.XtraEditors.ComboBoxEdit;
			return (DevExpress.XtraNavBar.NavBarGroupStyle)System.Enum.Parse(typeof(DevExpress.XtraNavBar.NavBarGroupStyle), cb.SelectedItem.ToString());
		}

		DevExpress.XtraNavBar.NavBarImage GetGroupImageStyleByString(object sender) {
			DevExpress.XtraEditors.ComboBoxEdit cb = sender as DevExpress.XtraEditors.ComboBoxEdit;
			return (DevExpress.XtraNavBar.NavBarImage)System.Enum.Parse(typeof(DevExpress.XtraNavBar.NavBarImage), cb.SelectedItem.ToString());
		}

		private void cbLocalStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
			navBarGroup1.GroupStyle = GetGroupStyleByString(sender);
		}

		private void cbContactStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
			navBarGroup2.GroupStyle = GetGroupStyleByString(sender);
		}

		private void cbLocalImage_SelectedIndexChanged(object sender, System.EventArgs e) {
			navBarGroup1.GroupCaptionUseImage = GetGroupImageStyleByString(sender);
		}

		private void cbContactImage_SelectedIndexChanged(object sender, System.EventArgs e) {
			navBarGroup2.GroupCaptionUseImage = GetGroupImageStyleByString(sender);
		}
	}
}
