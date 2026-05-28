using System;
using System.Drawing;
using DevExpress.Utils;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for Filtering.
	/// </summary>
	public partial class Filtering : TutorialControl {
		public Filtering() {
			// This call is required by the Windows.Forms Form Designer.
			CreateWaitDialog();
			InitializeComponent();
			// TODO: Add any initialization after the InitForm call
		}
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "Filtering" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "Filtering"; }
        }

		private void Filtering_Load(object sender, System.EventArgs e) {
			InitIssueListData(dsIssueList1);
			InitFilter();
			InitEditors();
		}

        void InitFilter() {
			gridControl1.ForceInitialize();
		}

        //<ceAllowFilter>
		void InitDemoFilter() {
			gridView1.Columns["FixedDate"].FilterInfo = new Columns.ColumnFilterInfo(Columns.ColumnFilterType.Custom, null, "[FixedDate] is not null");
			gridView1.Columns["Status"].FilterInfo = new Columns.ColumnFilterInfo(Columns.ColumnFilterType.Custom, null, "[Status] in (2, 3, 4)");
		}
        //</ceAllowFilter>
		void InitEditors() {
			ceAllowFilter.Checked = gridView1.OptionsCustomization.AllowFilter;
			ceFilterEditor.Checked = gridView1.OptionsFilter.AllowFilterEditor;
			ceAdvDialog.Checked = gridView1.OptionsFilter.UseNewCustomFilterDialog;
			ceFilterList.Checked = gridView1.OptionsFilter.AllowMRUFilterList;
			ceColumnFilterList.Checked = gridView1.OptionsFilter.AllowColumnMRUFilterList;
			InitEnabled();
		}

		void InitEnabled() {
			ceFilterEditor.Enabled = ceAdvDialog.Enabled = ceFilterList.Enabled = ceColumnFilterList.Enabled = gridView1.OptionsCustomization.AllowFilter;
		}

		private void gridView1_ColumnFilterChanged(object sender, System.EventArgs e) {
			gridView1.ExpandAllGroups();
		}

		private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e) {
			if(e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Column) {
				for(int i = e.Menu.Items.Count - 1; i >= 0; i--)
					if(e.Menu.Items[i] != null) {
						if(e.Menu.Items[i].Caption.IndexOf("Filter", StringComparison.OrdinalIgnoreCase) == -1) 
							e.Menu.Items.RemoveAt(i);
						else 
							e.Menu.Items[i].BeginGroup = false;
					}
			}
		}

        //<ceAllowFilter>
		private void ceAllowFilter_CheckedChanged(object sender, System.EventArgs e) {
			gridView1.OptionsCustomization.AllowFilter = ceAllowFilter.Checked;
			if(!ceAllowFilter.Checked) 
				gridView1.ClearColumnsFilter();
			else InitDemoFilter();
			InitEnabled();
		}
        //</ceAllowFilter>
        //<ceFilterEditor>
		private void ceFilterEditor_CheckedChanged(object sender, System.EventArgs e) {
			gridView1.OptionsFilter.AllowFilterEditor = ceFilterEditor.Checked;
		}
        //</ceFilterEditor>
        //<ceAdvDialog>
		private void ceAdvDialog_CheckedChanged(object sender, System.EventArgs e) {
			gridView1.OptionsFilter.UseNewCustomFilterDialog = ceAdvDialog.Checked;
		}
        //</ceAdvDialog>
        //<ceFilterList>
		private void ceFilterList_CheckedChanged(object sender, System.EventArgs e) {
			gridView1.OptionsFilter.AllowMRUFilterList = ceFilterList.Checked;
		}
        //</ceFilterList>
        //<ceColumnFilterList>
		private void ceColumnFilterList_CheckedChanged(object sender, System.EventArgs e) {
			gridView1.OptionsFilter.AllowColumnMRUFilterList = ceColumnFilterList.Checked;
		}
        //</ceColumnFilterList>
        //<sbInfo>
		private void sbInfo_Click(object sender, System.EventArgs e) {
			ToolTipControllerShowEventArgs args = new ToolTipControllerShowEventArgs();
            args.IconType = ToolTipIconType.Information;
            args.IconSize = ToolTipIconSize.Large;
            args.AutoHide = false;
            args.ToolTip = string.Format("<u>{7}</u><br> {0}<br><br>{8} <b>{1}</b><br><br>{9} <b>{2}</b><br>{10} <b>{3}</b><br>{11} <b>{4}</b><br>{12} <b>{5}</b><br>{13} <b>{6}</b><br>",
                gridView1.FilterPanelText, gridView1.RowCount, gridView1.OptionsFilter.ColumnFilterPopupMaxRecordsCount, gridView1.OptionsFilter.ColumnFilterPopupRowCount,
                gridView1.OptionsFilter.MRUColumnFilterListCount, gridView1.OptionsFilter.MRUFilterListCount, gridView1.OptionsFilter.MRUFilterListPopupCount, 
                Properties.Resources.RowFilter, Properties.Resources.RowCount, Properties.Resources.FilterPopupMaxRecord, Properties.Resources.FilterPopupRowCount,
                Properties.Resources.MRUColumnFilterListCount, Properties.Resources.MRUFilterListCount, Properties.Resources.MRUFilterListPopupCount);
            args.ShowBeak = true;
            args.ToolTipLocation = ToolTipLocation.TopLeft;
            toolTipController1.ShowHint(args, sbInfo.Parent.PointToScreen(new Point(sbInfo.Left + sbInfo.Width / 2, sbInfo.Top)));

		}
        //</sbInfo>
        private void sbInfo_Leave(object sender, EventArgs e) {
            toolTipController1.HideHint();
        }
	}
}
