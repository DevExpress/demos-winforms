using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraNavBar;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars;

namespace DevExpress.XtraNavBar.Demos {
	public partial class frmNavBarProperties : TutorialControl {
		public frmNavBarProperties() {
			InitializeComponent();
			InitComponent();
			FillData();
			navBarControl1.Groups.CollectionItemChanged += new CollectionItemEventHandler(GroupChanged);
			navBarControl1.Items.CollectionItemChanged += new CollectionItemEventHandler(ItemChanged);
			lbClick.Text = "None";
		}
        NavBarGroup selectedGroup = null;
        NavBarItemLink selectedLink = null;
        Point menuPoint = new Point(0, 0);
		#region Init
		private int IndexOf(DevExpress.XtraEditors.Controls.ComboBoxItemCollection objCollection, string s) {
			for(int i = 0; i < objCollection.Count; i++)
				if(objCollection[i].ToString() == s) return i;
			return -1;
		}
        public void InitComponent() {
            cbStyles.Properties.Items.AddRange(navBarControl1.AvailableNavBarViews.ToArray(typeof(object)) as object[]);
            cbStyles.SelectedIndex = IndexOf(cbStyles.Properties.Items, navBarControl1.View.ToString());
            cbScrollStyle.Properties.Items.AddEnum(typeof(SkinExplorerBarViewScrollStyle));
            cbScrollStyle.EditValue = navBarControl1.SkinExplorerBarViewScrollStyle;
        }
		private void FillData() {
			FillGroups(0);
			FillItems(0); 
			InitOptions();
		}
		private void FillGroups(int n) {
			Groups.Items.Clear();
			for(int i = 0; i < navBarControl1.Groups.Count; i++) 
				Groups.Items.Add(navBarControl1.Groups[i].Caption);
			if(Groups.Items.Count > n) Groups.SelectedIndex = n;
			btnRemoveGroup.Enabled = Groups.SelectedIndex != -1;
			ShowGroupProperties();
		}
		private void FillItems(int n) {
			Items.Items.Clear();
			for(int i = 0; i < navBarControl1.Items.Count; i++) 
				Items.Items.Add(navBarControl1.Items[i].Caption);
			if(Items.Items.Count > n) Items.SelectedIndex = n;
			btnRemoveItem.Enabled = Items.SelectedIndex != -1;
			ShowItemProperties();
		}
		private void InitOptions() {
            if(navBarControl1.LinkSelectionMode == LinkSelectionModeType.None)
                chbAllowSelectedLink.Checked = false;
            else chbAllowSelectedLink.Checked = true;
			chbAllowDrag.Checked = (navBarControl1.DragDropFlags & NavBarDragDrop.AllowDrag) != 0;
			chbAllowDrop.Checked = (navBarControl1.DragDropFlags & NavBarDragDrop.AllowDrop) != 0;
			chbAllowOuterDrop.Checked = (navBarControl1.DragDropFlags & NavBarDragDrop.AllowOuterDrop) != 0;
		}
		#endregion
		#region Editing
		private void cbStyles_SelectedIndexChanged(object sender, System.EventArgs e) {
			navBarControl1.View = cbStyles.SelectedItem as DevExpress.XtraNavBar.ViewInfo.BaseViewInfoRegistrator;
			navBarControl1.ResetStyles();
		}

		private void cbScrollStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
			navBarControl1.SkinExplorerBarViewScrollStyle = (DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle)cbScrollStyle.EditValue;
		}

		private void UpdateGroup(NavBarGroup group) {
			if(group == null) return;
			int ind = navBarControl1.Groups.IndexOf(group);
			if(ind != -1) {
				Groups.Items[ind] = group.Caption;
				Groups.SelectedIndex = ind;
			}
		}
		private void UpdateItem(NavBarItem item) {
			if(item == null) return;
			int ind = navBarControl1.Items.IndexOf(item);
			if(ind != -1) {
				Items.Items[ind] = item.Caption;
				Items.SelectedIndex = ind;
			}
		}
		private void GroupChanged(object sender, CollectionItemEventArgs e) {
			UpdateGroup(e.Item as NavBarGroup);
		}
		private void ItemChanged(object sender, CollectionItemEventArgs e) {
			UpdateItem(e.Item as NavBarItem);
		}
		private void SetDragDropFlags(NavBarDragDrop flag, bool IsChecked) {
			if(IsChecked) navBarControl1.DragDropFlags |= flag;
			else navBarControl1.DragDropFlags &= ~flag;
		}
		private void chbAllowDrag_CheckedChanged(object sender, System.EventArgs e) {
			SetDragDropFlags(NavBarDragDrop.AllowDrag, chbAllowDrag.Checked);
		}
		private void chbAllowDrop_CheckedChanged(object sender, System.EventArgs e) {
			SetDragDropFlags(NavBarDragDrop.AllowDrop, chbAllowDrop.Checked);		
		}
		private void chbAllowOuterDrop_CheckedChanged(object sender, System.EventArgs e) {
			SetDragDropFlags(NavBarDragDrop.AllowOuterDrop, chbAllowOuterDrop.Checked);
		}
		private void chbAllowSelectedLink_CheckedChanged(object sender, System.EventArgs e) {
            if(navBarControl1.LinkSelectionMode == LinkSelectionModeType.None && chbAllowSelectedLink.Checked)
                navBarControl1.LinkSelectionMode = LinkSelectionModeType.OneInControl;
            if(!(navBarControl1.LinkSelectionMode == LinkSelectionModeType.None) && !chbAllowSelectedLink.Checked)
                navBarControl1.LinkSelectionMode = LinkSelectionModeType.None;		
		}
		private void ShowGroupProperties() {
			if(Groups.SelectedIndex != -1)
				propertyGridControl1.SelectedObject = navBarControl1.Groups[Groups.SelectedIndex];
			else 
				propertyGridControl1.SelectedObject = null;
		}
		private void Groups_SelectedIndexChanged(object sender, System.EventArgs e) {
			ShowGroupProperties();
		}
		private void ShowItemProperties() {
			if(Items.SelectedIndex != -1)
				propertyGridControl2.SelectedObject = navBarControl1.Items[Items.SelectedIndex];
			else 
				propertyGridControl2.SelectedObject = null;
		}
		private void Items_SelectedIndexChanged(object sender, System.EventArgs e) {
			ShowItemProperties();
		}

		private void btnAddGroup_Click(object sender, System.EventArgs e) {
			navBarControl1.Groups.Add();
			FillGroups(navBarControl1.Groups.Count - 1);
		}

		private void btnRemoveGroup_Click(object sender, System.EventArgs e) {
			if(Groups.SelectedIndex != -1)
				navBarControl1.Groups.RemoveAt(Groups.SelectedIndex);
			FillGroups(0);
		}

		private void btnAddItem_Click(object sender, System.EventArgs e) {
			navBarControl1.Items.Add();
			FillItems(navBarControl1.Items.Count - 1);
		}

		private void btnRemoveItem_Click(object sender, System.EventArgs e) {
			if(Items.SelectedIndex != -1)
				navBarControl1.Items.RemoveAt(Items.SelectedIndex);
			FillItems(0);
		}
		#endregion
		#region Info
		private void navBarControl1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
			lbClick.Text = "Link Clicked: Group(" + e.Link.Group.Caption + ") / Item(" + e.Link.Caption + ")";
			timer1.Start();
		}

		private void navBarControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
			if(!timer1.Enabled) {
				NavBarHitInfo hi = navBarControl1.CalcHitInfo(new Point(e.X, e.Y));
				lbClick.Text = hi.HitTest.ToString() + "(" + e.X + "; " + e.Y + ")";
			}
		}

		private void navBarControl1_MouseLeave(object sender, System.EventArgs e) {
			lbClick.Text = "None";
		}

		private void timer1_Tick(object sender, System.EventArgs e) {
			timer1.Stop();
		}
		#endregion
		#region Menus
		
		
		
		private void navBarControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
			if(e.Button != MouseButtons.Right) return;
			NavBarHitInfo hi = navBarControl1.CalcHitInfo(new Point(e.X, e.Y));
			menuPoint = navBarControl1.PointToScreen(new Point(e.X, e.Y));
			selectedGroup = hi.Group;
			if(hi.InLink) {
				selectedLink = hi.Link;
				pmItem.ShowPopup(navBarControl1.PointToScreen(new Point(e.X, e.Y)));
				return;
			}
			pmGroup.ShowPopup(navBarControl1.PointToScreen(new Point(e.X, e.Y)));
		}

		private void biDeleteLink_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
			if(selectedLink != null) 
				selectedLink.Dispose();
		}

		private void biLinkProperties_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            frmLinkProperties dlg = new frmLinkProperties(menuPoint, selectedGroup, selectedLink, navBarControl1.Items, imageCollection1, imageCollection2);
			dlg.ShowDialog();
		}

		private void biRemoveGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
			if(selectedGroup != null) {
				selectedGroup.Dispose();
				FillGroups(0);
			}
		}

		private void biAddNewGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
			navBarControl1.Groups.Add();
			FillGroups(navBarControl1.Groups.Count - 1);
		}	

		private void biGroupProperties_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
			if(selectedGroup != null) {
				DevExpress.XtraEditors.XtraForm frm = new DevExpress.XtraEditors.XtraForm();
				frm.Text = "Group Properties (" + selectedGroup.Caption + ")";
				DevExpress.XtraVerticalGrid.PropertyGridControl pg = new DevExpress.XtraVerticalGrid.PropertyGridControl();
				using(System.IO.Stream ms = new System.IO.MemoryStream()) {
					propertyGridControl1.SaveLayoutToStream(ms);
					ms.Seek(0, System.IO.SeekOrigin.Begin);
					pg.RestoreLayoutFromStream(ms);
				}
				pg.DefaultEditors.AddRange(new DevExpress.XtraVerticalGrid.Rows.DefaultEditor[] {
					new DevExpress.XtraVerticalGrid.Rows.DefaultEditor(typeof(System.Drawing.Color), this.repositoryItemColorEdit1),
					new DevExpress.XtraVerticalGrid.Rows.DefaultEditor(typeof(bool), this.repositoryItemCheckEdit1)});
				pg.SelectedObject = selectedGroup;
				pg.Dock = DockStyle.Fill;
				frm.Controls.Add(pg);
				frm.StartPosition = FormStartPosition.Manual;
				if(menuPoint.X + frm.Width > Screen.PrimaryScreen.WorkingArea.Width)
                    menuPoint.X = Screen.PrimaryScreen.WorkingArea.Width - frm.Width;
                if(menuPoint.Y + frm.Height > Screen.PrimaryScreen.WorkingArea.Height)
                    menuPoint.Y = Screen.PrimaryScreen.WorkingArea.Height - frm.Height;
				frm.Location = menuPoint;
				frm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
				frm.ShowDialog();
			}
		}

		private void pmGroup_BeforePopup(object sender, CancelEventArgs e) {
			bool b = selectedGroup != null;
			bsiItems.Enabled = navBarControl1.Items.Count > 0 && b;
			biRemoveGroup.Enabled = b;
			biGroupProperties.Enabled = b;
			if(bsiItems.Enabled)
				InitItems();
		}

		BarButtonItem GetBarItemByLink(NavBarItem nItem) {
			foreach(BarItem item in barManager1.Items) {
				BarButtonItem bItem = item as BarButtonItem;
				if(bItem != null) {
					if(ReferenceEquals(bItem.Tag, nItem)) {
						bItem.Caption = nItem.Caption;
						return bItem;
					}
				}
			} 
			BarButtonItem bi = new BarButtonItem(barManager1, nItem.Caption);
			bi.Tag = nItem;
			bi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(biAddNewLink_ItemClick);
			return bi;
		} 

		void InitItems() {
			lcItems.ClearLinks();
			foreach(NavBarItem item in navBarControl1.Items) 
				lcItems.AddItem(GetBarItemByLink(item));
		}

		private void biAddNewLink_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
			if(selectedGroup != null) {
				selectedGroup.ItemLinks.Add((NavBarItem)e.Item.Tag);
				selectedGroup.Expanded = true;
			}
		}	
		#endregion
	}
}
