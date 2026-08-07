using System;
using System.Linq;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraScheduler.Demos.DemoData {
    public class SchedulerDataHelper {
        public static void Attach(SchedulerControl scheduler, bool hideParentResource = true) {
            new SchedulerDataHelper().AttachToScheduler(scheduler, hideParentResource);
        }

        public static LocationDataBindingList GetLocations(SchedulerControl scheduler) {
            SchedulerDataHelper instance = scheduler.Tag as SchedulerDataHelper;
            if(instance == null)
                return null;
            return instance.Locations;
        }

        public static void AddLocation(SchedulerControl scheduler, string location) {
            if(string.IsNullOrEmpty(location))
                return;
            SchedulerDataHelper instance = scheduler.Tag as SchedulerDataHelper;
            if(instance == null)
                return;
            if(instance.Locations.Select(x => x.Caption).Contains(location))
                return;
            instance.Locations.Add(new LocationData() { Id = instance.Locations.Count, Caption = location });
        }

        public static DateTime Start { get { return TutorialConstants.Today; } }

        EventBindingList events = new EventBindingList();
        CalendarBindingList calendars = new CalendarBindingList();

        public SchedulerDataHelper() {
            Locations = new LocationDataBindingList();
        }

        public LocationDataBindingList Locations { get; private set; }

        void AttachToScheduler(SchedulerControl scheduler, bool hideParentResource = true) {
            scheduler.Tag = this;
            SchedulerDataStorage storage = (SchedulerDataStorage)scheduler.DataStorage;
            scheduler.BeginUpdate();
            try {
                scheduler.DataStorage.Appointments.ResourceSharing = true;
                scheduler.DataStorage.DateTimeSavingMode = DateTimeSavingMode.Storage;

                GenerateLocations();
                GenerateResources();
                GenerateEvents();

                PrepareResourceStorage(storage, hideParentResource);
                PrepareAppointmentStorage(storage);
                scheduler.InitNewAppointment += (o, e) => { if(((SchedulerControl)o).GroupType == SchedulerGroupType.None) e.Appointment.ResourceId = 1; };

            }
            finally {
                scheduler.EndUpdate();
            }
            
            
            
            
            
            
        }

        void PrepareResourceStorage(SchedulerDataStorage storage, bool hideParentResource) {
            ResourceMappingInfo mappings = storage.Resources.Mappings;
            mappings.Id = "Id";
            mappings.Caption = "Caption";
            mappings.ParentId = "ParentId";
            storage.Resources.DataSource = calendars;
            if(hideParentResource) {
                foreach(Resource resource in storage.Resources.Items) {
                    if(resource.ParentId.Equals(resource.Id))
                        continue;
                    storage.Resources.GetResourceById(resource.ParentId).Visible = false;
                }
            }
        }

        void PrepareAppointmentStorage(SchedulerDataStorage storage) {
            AppointmentMappingInfo mappings = storage.Appointments.Mappings;
            mappings.AppointmentId = "Id";
            mappings.Start = "StartDate";
            mappings.End = "EndDate";
            mappings.AllDay = "AllDay";
            mappings.Subject = "Subject";
            mappings.Description = "Description";
            mappings.Location = "Location";
            mappings.ReminderInfo = "ReminderInfo";
            mappings.RecurrenceInfo = "RecurrenceInfo";
            mappings.Type = "EventType";
            mappings.ResourceId = "CalendarIds";
            mappings.Label = "LabelId";
            mappings.Status = "StatusId";
            storage.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("Priority", "Priority"));
            storage.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("IsPrivate", "IsPrivate"));
            storage.Appointments.DataSource = this.events;
        }

        void GenerateLocations() {
            int id = 0;
            Locations.Add(new LocationData() { Id = id, Caption = "My Office" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Conference Room A" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Lunch at Caroline's Steakhouse" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Conference Room B" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "MacArthur Country Club" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "R&R Health Spa" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Sam's Breakfast Nook" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "The Beer Garden Lunchroom" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Dr Drake Dental Center" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Training Room A" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Harry's Steakhouse" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "The Crossfit Center" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Training Room B" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "4 Corners Family Restaurant" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Community Hospital" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Tiffany's Breakfast Lounge" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Bob's Burgers" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Baseball Sadium" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Headquarters" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Hilton Hotel" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "The Lunch Counter" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Las Vegas" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Sal's Delicatessen" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Hilltop Development" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Suzy's Steakhouse" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Westside Country Club" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "The 19th Hole Pub" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Disneyland" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Brad's Sandwich Shop" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Great American Gym" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Sheraton Hotel" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Zeke's BBQ" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Los Angeles" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Home" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Sara's Breakfast Nook" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Breckenridge Seafood" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Hungry Heff's Burgers" }); ++id;
            Locations.Add(new LocationData() { Id = id, Caption = "Surgical Outpatient Center" }); ++id;
        }

        void GenerateResources() {
            calendars.Add(new Calendar() { Id = 0, Caption = "Work", ParentId = 0 });
            calendars.Add(new Calendar() { Id = 1, Caption = "Indoor meetings", ParentId = 0 });
            calendars.Add(new Calendar() { Id = 2, Caption = "Outdoor meetings", ParentId = 0 });
            calendars.Add(new Calendar() { Id = 3, Caption = "Partnership", ParentId = 3 });
            calendars.Add(new Calendar() { Id = 4, Caption = "Personal", ParentId = 4 });
            calendars.Add(new Calendar() { Id = 5, Caption = "Golfing", ParentId = 4 });
            calendars.Add(new Calendar() { Id = 6, Caption = "Other", ParentId = 0 });
            calendars.Add(new Calendar() { Id = 7, Caption = "Other Activities", ParentId = 4 });
            calendars.Add(new Calendar() { Id = 8, Caption = "Baseball", ParentId = 4 });
            calendars.Add(new Calendar() { Id = 9, Caption = "Family", ParentId = 4 });
        }

        void GenerateEvents() {
            EventGenerator.Generate(events, TutorialConstants.Today);
        }
    }
}
