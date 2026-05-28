using System;
using DevExpress.DXperience.Demos;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.ReportTemplates {

    public partial class ReportTemplatesModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        public ReportTemplatesModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            ControlPrintAdapter1.ReplaceDefaultPrinting();
            // TODO: Add any initialization after the InitializeComponent call
        }

        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }
        protected DayViewAppointmentDisplayOptions DisplayOptions { get { return (DayViewAppointmentDisplayOptions)schedulerControl.DayView.AppointmentDisplayOptions; } }

        private void ReportTemplates_Load(object sender, System.EventArgs e) {
            DemoUtils.FillResources(schedulerStorage, 5);
            InitAppointments();
            schedulerControl.Start = TutorialConstants.Now;
        }
        void InitAppointments() {
            GenerateEvents(schedulerStorage);

        }
        void GenerateEvents(SchedulerStorage storage) {
            int count = storage.Resources.Count;
            AppointmentStorage appointments = storage.Appointments;
            storage.BeginUpdate();
            for (int i = 0; i < count; i++) {
                Resource resource = schedulerStorage.Resources[i];
                CreateAppointentsForResource(storage, resource);
            }
            storage.EndUpdate();
        }

        private void CreateAppointentsForResource(SchedulerStorage storage, Resource resource) {
            int statusCount = storage.Appointments.Statuses.Count;
            string[] appointmentKind = { "appointment", "personal time", "meeting", "travel" };
            int[] labelKind = { 1, 3, 5, 6 };

            string subjPrefix = resource.Caption + "'s ";
            AppointmentStorage appointments = storage.Appointments;

            for (int i = 0; i < 50; i++) {
                int statusId = TutorialConstants.Random.Next(0, statusCount);
                int aptKindId = TutorialConstants.Random.Next(0, appointmentKind.Length);
                int labelId = labelKind[aptKindId];

                string subject = subjPrefix + appointmentKind[aptKindId];
                int dateRange = TutorialConstants.Random.Next(0, 20);
                DateTime start = TutorialConstants.Today.AddDays(dateRange - 2);

                appointments.Add(CreateAppointment(start, subject, resource.Id, statusId, labelId));
            }
        }
        Appointment CreateAppointment(DateTime start, string subject, object resourceId, int status, int label) {
            Appointment apt = schedulerStorage.CreateAppointment(AppointmentType.Normal);
            apt.Subject = subject;
            apt.ResourceId = resourceId;
            apt.AllDay = TutorialConstants.Random.Next(0, 5) == 0;

            int rangeInMinutes = 60 * 24;
            apt.Start = start + TimeSpan.FromMinutes(TutorialConstants.Random.Next(0, rangeInMinutes));
            TimeSpan duration = TimeSpan.FromMinutes(TutorialConstants.Random.Next(0, rangeInMinutes / 4));
            if (duration.Ticks == 0)
                duration = TimeSpan.FromMinutes(5);

            apt.End = apt.Start + duration;
            apt.StatusKey = status;
            apt.LabelKey = label;
            return apt;
        }

        private void btnPreview_Click(object sender, EventArgs e) {
            using (ReportTemplateForm form = new ReportTemplateForm(ControlPrintAdapter1)) {
                form.ShowDialog();
            }
        }
    }
}

