using DevExpress.DXperience.Demos;
using System;

namespace DevExpress.XtraScheduler.Demos {
    public partial class CustomWorkTimeModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        public CustomWorkTimeModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

        }
        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

        private void CustomWorkTimeModule_Load(object sender, System.EventArgs e) {
            DemoUtils.FillResources(schedulerStorage, 5);
            InitAppointments();
            schedulerControl.Start = TutorialConstants.Now;
        }
        void InitAppointments() {
            this.schedulerStorage.Appointments.Mappings.Start = "StartTime";
            this.schedulerStorage.Appointments.Mappings.End = "EndTime";
            this.schedulerStorage.Appointments.Mappings.Subject = "Subject";
            this.schedulerStorage.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerStorage.Appointments.Mappings.Description = "Description";
            this.schedulerStorage.Appointments.Mappings.Label = "Label";
            this.schedulerStorage.Appointments.Mappings.Location = "Location";
            this.schedulerStorage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerStorage.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerStorage.Appointments.Mappings.ResourceId = "OwnerId";
            this.schedulerStorage.Appointments.Mappings.Status = "Status";
            this.schedulerStorage.Appointments.Mappings.Type = "EventType";

            CustomEventList eventList = new CustomEventList();
            GenerateEvents(eventList);
            this.schedulerStorage.Appointments.DataSource = eventList;

        }
        void GenerateEvents(CustomEventList eventList) {
            int count = schedulerStorage.Resources.Count;
            for (int i = 0; i < count; i++) {
                Resource resource = schedulerStorage.Resources[i];
                string subjPrefix = resource.Caption + "'s ";
                eventList.Add(CreateEvent(eventList, subjPrefix + "meeting", resource.Id, 2, 5));
                eventList.Add(CreateEvent(eventList, subjPrefix + "travel", resource.Id, 3, 6));
                eventList.Add(CreateEvent(eventList, subjPrefix + "phone call", resource.Id, 0, 10));
            }
        }
        CustomEvent CreateEvent(CustomEventList eventList, string subject, object resourceId, int status, int label) {
            CustomEvent apt = new CustomEvent(eventList);
            apt.Subject = subject;
            apt.OwnerId = resourceId;
            int rangeInMinutes = 60 * 24;
            apt.StartTime = TutorialConstants.Today + TimeSpan.FromMinutes(TutorialConstants.Random.Next(0, rangeInMinutes));
            apt.EndTime = apt.StartTime + TimeSpan.FromMinutes(TutorialConstants.Random.Next(0, rangeInMinutes / 4));
            apt.Status = status;
            apt.Label = label;
            return apt;
        }
        TimeOfDayInterval[] workTimes = new TimeOfDayInterval[] {
			new TimeOfDayInterval(TimeSpan.FromHours(0), TimeSpan.FromHours(16)),
			new TimeOfDayInterval(TimeSpan.FromHours(10), TimeSpan.FromHours(20)),
			null,
			new TimeOfDayInterval(TimeSpan.FromHours(7), TimeSpan.FromHours(15)),
			new TimeOfDayInterval(TimeSpan.FromHours(16), TimeSpan.FromHours(24)),
		};

        private void schedulerControl_QueryWorkTime(object sender, QueryWorkTimeEventArgs e) {
            if (!chkCustomWorkTime.Checked)
                return;

            if (schedulerStorage.Resources == null)
                return;

            int resourceIndex = schedulerStorage.Resources.Items.IndexOf(e.Resource);
            if (resourceIndex >= 0) {
                if (resourceIndex == 0) {
                    if ((e.Interval.Start.Day % 2) == 0)
                        e.WorkTime = workTimes[resourceIndex % workTimes.Length];
                    else {
                        e.WorkTimes.Add(new TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(13)));
                        e.WorkTimes.Add(new TimeOfDayInterval(TimeSpan.FromHours(14), TimeSpan.FromHours(18)));
                    }
                }
                else {
                    if (schedulerControl.WorkDays.IsWorkDay(e.Interval.Start.Date))
                        e.WorkTime = workTimes[resourceIndex % workTimes.Length];
                }
            }
        }

        private void chkCustomWorkTime_CheckedChanged(object sender, EventArgs e) {
            schedulerControl.ActiveView.LayoutChanged();
        }
    }
}
