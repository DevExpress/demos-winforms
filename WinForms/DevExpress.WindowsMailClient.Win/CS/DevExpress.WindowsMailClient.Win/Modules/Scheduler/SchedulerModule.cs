using System;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.WindowsMailClient.Win.ViewModels;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Demos.DemoData;

namespace DevExpress.WindowsMailClient.Win.Modules {
    public partial class SchedulerModule : BaseModule {
        public SchedulerModule() : base(typeof(SchedulerModuleViewModel)) {
            InitializeComponent();
            this.schedulerControl1.BeginUpdate();
            try
            {
                this.schedulerControl1.OptionsBehavior.UseAsyncMode = false;
                this.schedulerControl1.MonthView.AllowScrollAnimation = false;
            }
            finally {
                this.schedulerControl1.EndUpdate();
            }
        }
        public SchedulerControl Scheduler { get { return this.schedulerControl1; } }

        void SchedulerModule_Load(object sender, EventArgs e) {
            Scheduler.Start = SchedulerDataHelper.Start;
            SchedulerDataHelper.Attach(this.schedulerControl1);
        }
        protected override void WndProc(ref System.Windows.Forms.Message m) {
            if(m.Msg == 528 || m.Msg == MSG.WM_LBUTTONDBLCLK || m.Msg == MSG.WM_LBUTTONDOWN || m.Msg == MSG.WM_LBUTTONDOWN) { 
                this.GetParentViewModel<MainViewModel>().HideAllPanels();
            }
            base.WndProc(ref m);
        }
    }
}
