using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.MailClient.Win.Forms {
    public partial class frmCustomDate : XtraForm {
        Task currentTask;
        public frmCustomDate() {
            InitializeComponent();
        }
        public frmCustomDate(Task task) {
            InitializeComponent();
            this.currentTask = task;
            if(task.StartDate.HasValue)
                dateEdit1.DateTime = task.StartDate.Value;
            if(task.DueDate.HasValue)
                dateEdit2.DateTime = task.DueDate.Value;
        }
        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if(DialogResult == DialogResult.OK) {
                if(dateEdit1.DateTime > DateTime.MinValue)
                    currentTask.StartDate = dateEdit1.DateTime;
                else currentTask.StartDate = null;
                if(dateEdit2.DateTime > DateTime.MinValue)
                    currentTask.DueDate = dateEdit2.DateTime;
                else currentTask.DueDate = null;
            }
        }
    }
}
