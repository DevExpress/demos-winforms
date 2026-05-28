using DevExpress.Utils.Menu;
using DevExpress.XtraScheduler.Commands;
using DevExpress.XtraScheduler.Demos.DemoData;
using System;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
    public partial class TimeZonesModule : TutorialControl {
        public TimeZonesModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            this.schedulerControl.PopupMenuShowing += schedulerControl_PopupMenuShowing;
            // TODO: Add any initialization after the InitializeComponent call
        }

        public override SchedulerControl Scheduler { get { return this.schedulerControl; } }
        protected override Control OptionsPane { get { return this.spOptionPane; } }

        private void TimeZonesModule_Load(object sender, EventArgs e) {
            Scheduler.Start = SchedulerDataHelper.Start;
            SchedulerDataHelper.Attach(this.schedulerControl);
            UpdateControls();
        }

        private void UpdateControls() {
            this.schedulerControl.DayView.TimeRulers[1].UseClientTimeZone = false;
            this.schedulerControl.WorkWeekView.TimeRulers[1].UseClientTimeZone = false;
            this.edtTimeZone.TimeZoneId = this.schedulerControl.OptionsBehavior.ClientTimeZoneId;
        }
        private void edtTimeZone_EditValueChanged(object sender, EventArgs e) {
            this.schedulerControl.OptionsBehavior.ClientTimeZoneId = this.edtTimeZone.TimeZoneId;
            string caption = this.schedulerControl.OptionsBehavior.ClientTimeZoneId.ToString();
            this.schedulerControl.DayView.TimeRulers[2].Caption = caption;
            this.schedulerControl.WorkWeekView.TimeRulers[2].Caption = caption;
            this.schedulerControl.FullWeekView.TimeRulers[2].Caption = caption;
        }
        private void schedulerControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if (e.Menu.Id == SchedulerMenuItemId.AppointmentMenu) {
                SplitAppointmentOperationCommand command = new SplitAppointmentOperationCommand(this.schedulerControl);
                SchedulerMenuItemCommandWinAdapter menuItemCommandAdapter = new SchedulerMenuItemCommandWinAdapter(command);
                DXMenuItem menuItem = (DXMenuItem)menuItemCommandAdapter.CreateMenuItem(DXMenuItemPriority.Normal);
                menuItem.BeginGroup = true;
                e.Menu.Items.Add(menuItem);
            }
        }
    }
}

