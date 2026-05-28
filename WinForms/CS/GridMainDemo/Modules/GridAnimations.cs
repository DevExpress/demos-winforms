using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing.Imaging;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for GridAnimations.
	/// </summary>
	public partial class GridAnimations : TutorialControl {
		public GridAnimations() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
			// TODO: Add any initialization after the InitForm call

		}
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "GridAnimations" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "GridAnimations"; }
        }

		public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return gridView1; } }
		private void GridAnimations_Load(object sender, System.EventArgs e) {
			gridControl1.DataSource = OutlookData.CreateDataTable(4);
            gridView1.ExpandAllGroups();
            foreach(GridAnimationType mode in Enum.GetValues(typeof(GridAnimationType)))
                icbAnimation.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<GridAnimationType>.GetTitle(mode), mode, -1));
            icbAnimation.EditValue = gridView1.OptionsView.AnimationType;
            OnStyleChanged();
		}

		private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
			GridGroupRowInfo info = e.Info as GridGroupRowInfo;
			if(info == null) return;
			info.GroupText = info.GroupText.Replace("1 " + Properties.Resources.Items, "1 " + Properties.Resources.Item);
		}

        Hashtable ht = new Hashtable();
        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if(e.IsGetData) {
                DataRow row = ((DataRowView)e.Row).Row;
                int key = (int)row["Priority"];
                if(key != 1) {
                    if(!ht.ContainsKey(key))
                        ht.Add(key, GetImage(key));
                    e.Value = ht[key];
                }
            }
        }

        byte[] GetImage(int key) {
            Image img = DevExpress.Utils.ResourceImageHelper.CreateImageFromResourcesEx(string.Format("DevExpress.XtraGrid.Demos.Images.{0}.gif", GetPictureName(key)), typeof(GridAnimations).Assembly);
            return ByteImageConverter.ToByteArray(img, ImageFormat.Gif);
        }

        string GetPictureName(int key) {
            if(key == 0) return "low"; else return "high";
        }

        private void gridView1_ShowFilterPopupListBox(object sender, DevExpress.XtraGrid.Views.Grid.FilterPopupListBoxEventArgs e) {
            if(e.Column != colPriority) return;
            for(int i = e.ComboBox.Items.Count - 1; i >= 0; i--) {
                FilterItem item = e.ComboBox.Items[i] as FilterItem;
                if(item == null) continue;
                if(item.Text == GridLocalizer.Active.GetLocalizedString(GridStringId.PopupFilterCustom))
                    e.ComboBox.Items.RemoveAt(i);
            }
            e.ComboBox.Items.Add(new FilterItem(Properties.Resources.LowPriority, new ColumnFilterInfo("[Priority] = 0", Properties.Resources.LowPriority)));
            e.ComboBox.Items.Add(new FilterItem(Properties.Resources.HighPriority, new ColumnFilterInfo("[Priority] = 2", Properties.Resources.HighPriority)));
        }
        //<icbAnimation>
        private void icbAnimation_SelectedIndexChanged(object sender, EventArgs e) {
            gridView1.OptionsView.AnimationType = (GridAnimationType)icbAnimation.EditValue;
        }
        //</icbAnimation>
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}
