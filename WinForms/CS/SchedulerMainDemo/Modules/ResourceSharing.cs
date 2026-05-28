using DevExpress.DXperience.Demos;
using System;

namespace DevExpress.XtraScheduler.Demos {
    public partial class ResourceSharingModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        const string AttendeeDescription = "The following persons are invited:\r\n";
        static readonly int[] labelKeys = new int[] { 1, 2, 5, 6, 7 };
        static readonly int[] statusKeys = new int[] { 1, 2 };

        public ResourceSharingModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
        }
        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

        void ResourceSharingModule_Load(object sender, System.EventArgs e) {
            schedulerControl.Start = TutorialConstants.Today;
            DemoUtils.FillResources(schedulerDataStorage, int.MaxValue);
            PrepareMeetings();
        }

        #region data initialization
        void PrepareMeetings() {
            int resourceCount = schedulerDataStorage.Resources.Count;
            System.Diagnostics.Debug.Assert(resourceCount == 8);

            DateTime today = TutorialConstants.Today;
            for (int i = 0; i < 30; i++) {
                if (today.DayOfWeek != DayOfWeek.Sunday) {
                    CreateMeeting("Morning meeting", today + TimeSpan.FromHours(9), 1);
                    CreateMeeting("Product delivery planning", today + TimeSpan.FromHours(11), 2);
                    CreateMeeting("New product concept presentation", today + TimeSpan.FromHours(14), 2);
                    CreateMeeting("Discussion", today + TimeSpan.FromHours(16), 1);
                    CreateMeeting("New employee interview", today + TimeSpan.FromHours(17), 1);
                }
                today = today + TimeSpan.FromDays(1);
            }
        }
        int[] GetParticipants() {
            int count = TutorialConstants.Random.Next(1, 6);
            int[] resources = new int[count];
            for (int i = 0; i < count; i++)
                resources[i] = TutorialConstants.Random.Next(8);
            return resources;
        }
        Appointment CreateMeeting(string subject, DateTime date, int hours) {
            Appointment apt = schedulerDataStorage.CreateAppointment(AppointmentType.Normal);
            apt.Start = date;
            apt.Duration = TimeSpan.FromHours(hours);
            apt.Subject = subject;
            apt.StatusKey = TutorialConstants.Random.Next(100) % 2 > 0 ? statusKeys[0] : statusKeys[1];
            apt.LabelKey = labelKeys[TutorialConstants.Random.Next(4)];

            string description = AttendeeDescription;
            int[] participants = GetParticipants();
            int count = participants.Length;
            for (int i = 0; i < count; i++) {
                Resource resource = schedulerDataStorage.Resources[participants[i]];
                description += String.Format("{0}\r\n", resource.Caption);
                apt.ResourceIds.Add(resource.Id);
            }
            apt.Description = description;
            schedulerDataStorage.Appointments.Add(apt);
            return apt;
        }
        #endregion
        private void schedulerStorage_AppointmentChanging(object sender, PersistentObjectCancelEventArgs e) {
            Appointment apt = e.Object as Appointment;
            apt.Description = AttendeeDescription + GetAttendeeNames(apt.ResourceIds);
        }
        private string GetAttendeeNames(AppointmentResourceIdCollection resIds) {
            string result = string.Empty;
            ResourceCollection resources = schedulerDataStorage.Resources.Items;
            foreach (Resource resource in resources) {
                if (resIds.Contains(resource.Id))
                    result += String.Format("{0}\r\n", resource.Caption);
            }
            return result;
        }

    }
}

