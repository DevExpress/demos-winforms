using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.MailClient.Win;

namespace DevExpress.ProductsDemo.Win.Forms {
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
