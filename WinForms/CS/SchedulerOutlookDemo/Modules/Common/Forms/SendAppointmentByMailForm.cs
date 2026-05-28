using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
    public partial class SendAppointmentByMailForm : XtraForm {
        public SendAppointmentByMailForm() {
            InitializeComponent();
            this.lciMessage.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
            ControlBox = false;
            this.lciBtnOk.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
            this.emptySpaceItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
            this.emptySpaceItem1.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
            this.emptySpaceItem3.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
        }

        public SendAppointmentByMailForm(String fileName, String[] filePaths) : this() {
            FileName = FileName;
            FilePaths = filePaths;
        }
                
        String FileName { get; set; }
        String[] FilePaths { get; set; }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (FilePaths == null)
                return;
            Task task = DoActionTask();
            task.ContinueWith(x => { if (!IsDisposed) BeginInvoke((Action)ShowError); }, TaskContinuationOptions.OnlyOnFaulted);
            task.ContinueWith(x => { if (!IsDisposed) BeginInvoke((Action)Done); }, TaskContinuationOptions.OnlyOnRanToCompletion);
        }

        Task DoActionTask() {
            Task task = new Task(SendMail, TaskCreationOptions.LongRunning);
            task.Start();
            return task;
        }

        void SendMail() {
            RecipientCollection recipients = new RecipientCollection();
            recipients.Add(new Recipient());
            MAPI.SendMail(IntPtr.Zero, FilePaths, FileName, "", recipients);
        }

        void ShowError() {
            ControlBox = true;
            this.lciBtnOk.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            this.emptySpaceItem2.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            this.emptySpaceItem1.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            this.emptySpaceItem3.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            this.lciProgressPanel.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
            this.lciMessage.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            this.lblMessage.Text = "Can't open default mail client!";
        }
        void Done() {
            Close();
        }
    }
}
