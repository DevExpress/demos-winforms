using DevExpress.DXperience.Demos;
using System;

namespace DevExpress.XtraScheduler.Demos {
    public partial class RemindersModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        public RemindersModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
        }
        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }


        private void RemindersModule_VisibleChanged(object sender, System.EventArgs e) {
            schedulerDataStorage.Appointments.Clear();
            schedulerControl.DataStorage.EnableReminders = this.Visible;
            //schedulerControl.OptionsBehavior.ShowRemindersForm = this.Visible;
            schedulerControl.Start = TutorialConstants.Today;
        }
        private void btnCreateAppointmentWithReminder_Click(object sender, System.EventArgs e) {
            DateTime now = TutorialConstants.Now + TimeSpan.FromMinutes(5);
            Appointment apt = schedulerDataStorage.CreateAppointment(AppointmentType.Normal);
            apt.Start = now;
            apt.Duration = TimeSpan.FromHours(1);
            apt.Subject = "Appointment with Reminder";

            apt.HasReminder = true;
            schedulerDataStorage.Appointments.Add(apt);
            schedulerControl.ActiveView.GotoTimeInterval(new TimeInterval(apt.Start, apt.Duration));
        }

        private void btnGotoToday_Click(object sender, System.EventArgs e) {
            schedulerControl.GoToToday();
        }
    }
}
