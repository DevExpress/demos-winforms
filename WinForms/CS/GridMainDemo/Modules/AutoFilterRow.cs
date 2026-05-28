using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
	/// <summary>
	/// Summary description for AutoFilterRow.
	/// </summary>
	public partial class AutoFilterRow : TutorialControl {
		public AutoFilterRow() {
			// This call is required by the Windows.Forms Form Designer.
			CreateWaitDialog();
			InitializeComponent();
			// TODO: Add any initialization after the InitForm call

		}
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "AutoFilterRow" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "AutoFilterRow"; }
        }

		private void AutoFilterRow_Load(object sender, System.EventArgs e) {
			InitIssueListData(dsIssueList1);
            InitCheckEditors();
			gridView1.FocusedRowHandle = GridControl.AutoFilterRowHandle;
		}

        bool initEditors = false;
        void InitCheckEditors() {
            initEditors = true;
            ceAutoFilterRow.Checked = gridView1.OptionsView.ShowAutoFilterRow;
            ceAutoFilterRowMenuItem.Checked = gridView1.OptionsMenu.ShowAutoFilterRowItem;
            ceAllowAutoFilterConditionChange.Checked = gridView1.OptionsFilter.AllowAutoFilterConditionChange != DefaultBoolean.False;
            initEditors = false;
        }
        //<ceAutoFilterRow>
		private void ceAutoFilterRow_CheckedChanged(object sender, System.EventArgs e) {
            if(initEditors) return;
            CheckEdit ce = sender as CheckEdit;
            gridView1.OptionsView.ShowAutoFilterRow = ce.Checked;
		}
        //</ceAutoFilterRow>

        //<ceAutoFilterRowMenuItem>
        private void ceAutoFilterRowMenuItem_CheckedChanged(object sender, EventArgs e) {
            if(initEditors) return;
            CheckEdit ce = sender as CheckEdit;
            gridView1.OptionsMenu.ShowAutoFilterRowItem = ce.Checked;
        }
        //</ceAutoFilterRowMenuItem>
        private void gridView1_GridMenuItemClick(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs e) {
            BeginInvoke(new MethodInvoker(InitCheckEditors));
        }

        private void ceAllowAutoFilterConditionChange_CheckedChanged(object sender, EventArgs e) {
            if(initEditors) return;
            CheckEdit ce = sender as CheckEdit;
            gridView1.OptionsFilter.AllowAutoFilterConditionChange = ce.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
	}
}
