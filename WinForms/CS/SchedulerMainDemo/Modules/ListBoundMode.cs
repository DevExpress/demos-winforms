using DevExpress.DXperience.Demos;
using System;

namespace DevExpress.XtraScheduler.Demos {
	public partial class ListBoundModeModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public ListBoundModeModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

		}
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

		private void ListBoundModeModule_Load(object sender, System.EventArgs e) {
            DemoUtils.FillResources(schedulerStorage, 5);
			InitAppointments();
			schedulerControl.Start = TutorialConstants.Now;
		}
        void InitAppointments() {
            AppointmentMappingInfo mappings = this.schedulerStorage.Appointments.Mappings;
            mappings.Start = "StartTime";
            mappings.End = "EndTime";
            mappings.Subject = "Subject";
            mappings.AllDay = "AllDay";
            mappings.Description = "Description";
            mappings.Label = "Label";
            mappings.Location = "Location";
            mappings.RecurrenceInfo = "RecurrenceInfo";
            mappings.ReminderInfo = "ReminderInfo";
            mappings.ResourceId = "OwnerId";
            mappings.Status = "Status";
            mappings.Type = "EventType";

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
	}
}
