using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.MailClient.Win.Forms {
    public partial class frmReminders : XtraForm {
        public frmReminders() {
            InitializeComponent();
        }
        public Task CurrentTask {
            get {
                return gridView1.GetRow(gridView1.FocusedRowHandle) as Task;
            }
        }
        internal void InitData(List<Task> list) {
            gridControl1.DataSource = list;
            Text = string.Format("{0} Reminder{1}", list.Count, list.Count > 1 ? "s" : string.Empty);
        }

        private void gridView1_FocusedRowObjectChanged(object sender, XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e) {
            lbSubject.Text = string.Format("<image=#BO_Task><size=+2> <b>{0}", CurrentTask.Subject);
            lbDueDate.Text = string.Format("Due: {0:ddd, MMMM dd, yyyy}", CurrentTask.DueDate);
        }

        private void gridView1_RowCellClick(object sender, XtraGrid.Views.Grid.RowCellClickEventArgs e) {
            if(CurrentTask == null) return;
            if(e.Button == MouseButtons.Left && e.RowHandle >= 0 && e.Clicks == 2) 
                OkClick();
        }
        void OkClick() {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyData == Keys.Enter)
                OkClick();
        }
    }
}
