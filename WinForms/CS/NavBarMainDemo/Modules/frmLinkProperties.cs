using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using DevExpress.Utils;

namespace DevExpress.XtraNavBar.Demos {
	public partial class frmLinkProperties : DevExpress.XtraEditors.XtraForm {
        public frmLinkProperties(Point location, NavBarGroup group, NavBarItemLink link, NavItemCollection items, ImageCollection imlL, ImageCollection imlS) {
			InitializeComponent();
			if(location.X + this.Width > Screen.PrimaryScreen.WorkingArea.Width) 
				location.X = Screen.PrimaryScreen.WorkingArea.Width - this.Width; 
			if(location.Y + this.Height > Screen.PrimaryScreen.WorkingArea.Height) 
				location.Y = Screen.PrimaryScreen.WorkingArea.Height - this.Height; 
			this.DesktopLocation = location;
			this.link = link;
			this.items = items;
			this.group = group;
			imlLarge = imlL;
			imlSmall = imlS;
			foreach(NavBarItem i in items) 
				cbItem.Properties.Items.Add(i.Caption);
			cbItem.SelectedItem = link.Item.Caption;
		}

        private NavBarItemLink link;
        private NavItemCollection items;
        private NavBarGroup group;
        private ImageCollection imlLarge, imlSmall;
        
		private void cbItem_SelectedIndexChanged(object sender, System.EventArgs e) {
			txtCaption.Text = items[cbItem.SelectedIndex].Caption;
			Invalidate(new Rectangle(cbItem.Left, lbImages.Top, 100, 100));
		}

		private void SetNewProperties () {
			if(group != null) {
				int ind = group.ItemLinks.IndexOf(link);
				if(ind != -1) {
					link.Dispose();
					group.ItemLinks.Insert(ind, items[cbItem.SelectedIndex]);
				}
			}
			items[cbItem.SelectedIndex].Caption = txtCaption.Text;
		}

		private void frmLinkProperties_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
			if(DialogResult == DialogResult.OK) 
				SetNewProperties();
		}

		private void frmLinkProperties_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
			e.Graphics.DrawImage(imlLarge.Images[items[cbItem.SelectedIndex].LargeImageIndex], cbItem.Left, lbImages.Top);
			e.Graphics.DrawImage(imlSmall.Images[items[cbItem.SelectedIndex].SmallImageIndex], cbItem.Left + 56, lbImages.Top);	
		}
	}
}
