using System;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Outlook;
using System.Threading;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
    public partial class SelectOutlookCalendarsForm : XtraForm {
        Task<string[]> loadCalendarPathsTask = null;
        CancellationTokenSource tokenSource;
        CancellationToken token;

        public SelectOutlookCalendarsForm() {
            InitializeComponent();
            this.tokenSource = new CancellationTokenSource();
            this.token = this.tokenSource.Token;
            this.lciEditor.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
            this.lciErrorMessage.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
            this.btnOk.Enabled = false;
            Load += OnFormLoad;
        }

        public string CalendarName {
            get {
                return this.cbCalendars.EditValue as String;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e) {
            base.OnFormClosed(e);
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
                return;
            this.tokenSource.Cancel();
        }

        void OnFormLoad(object sender, EventArgs e) {
            this.loadCalendarPathsTask = LoadCalendars();
            this.loadCalendarPathsTask.ContinueWith(x => BeginInvoke((Action)ShowError), TaskContinuationOptions.OnlyOnFaulted);
            this.loadCalendarPathsTask.ContinueWith(x => BeginInvoke((Action<string[]>)ShowEditors, new object[] { x.Result }), TaskContinuationOptions.OnlyOnRanToCompletion);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        Task<string[]> LoadCalendars() {
            Task<string[]> task = new Task<string[]>(() => {
                if (this.token.IsCancellationRequested)
                    this.token.ThrowIfCancellationRequested();
                string[] result = OutlookExchangeHelper.GetOutlookCalendarPaths();
                if (this.tokenSource.Token.IsCancellationRequested)
                    this.tokenSource.Token.ThrowIfCancellationRequested();
                return result;
            }, this.token, TaskCreationOptions.LongRunning);
            task.Start();
            return task;
        }

        void ShowError() {
            this.lblErrorMessage.Text = "Cannot connect to oulook. Install or close outlook instance.";
            this.lciErrorMessage.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            this.lciProgress.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
        }

        void ShowEditors(string[] calendarPaths) {
            this.lciProgress.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
            this.lciEditor.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            this.cbCalendars.Properties.Items.AddRange(calendarPaths);
            if (calendarPaths.Count() > 0)
                this.cbCalendars.SelectedIndex = 0;
            this.btnOk.Enabled = true;
        }
    }
}
