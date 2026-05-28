using DevExpress.DevAV;
using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraScheduler;
using DevExpress.Internal;
using DevExpress.XtraScheduler.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#if !NET
using System.Data.Entity;
#else
using Microsoft.EntityFrameworkCore;
#endif
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DXperience.Demos;

namespace DevExpress.HTML.Demos.Helpers {
    public class SchedulerData {

        IList<string> locations = new List<string>();
        DateTime Start { get { return TutorialConstants.Today; } }


        public SchedulerData() {
#if NET
            DevAVDb devAvDb = new DevAVDb($"Data Source={DevAVDataDirectoryHelper.GetFile("devav.sqlite3")}");
#else
            DevAVDb devAvDb = new DevAVDb();
#endif
            devAvDb.Employees.Load();
            Employees = new Dictionary<string, Employee>();
            Employees = devAvDb.Employees.Local.ToDictionary(employee => employee.FullName);
        }

        public Dictionary<string, Employee> Employees { get; }

        public void AttachToScheduler(SchedulerControl scheduler) {
            scheduler.Tag = this;

            SchedulerDataStorage storage = (SchedulerDataStorage)scheduler.DataStorage;
            scheduler.BeginUpdate();
            try {
                storage.DateTimeSavingMode = DateTimeSavingMode.Storage;
                CreateLabels(scheduler);
                GenerateResources();
                GenerateLocations();
                CreateMappings(storage);
                storage.Resources.DataSource = GenerateResources();
                storage.Appointments.DataSource = GenerateEvents();
                scheduler.InitNewAppointment += (o, e) => { if(((SchedulerControl)o).GroupType == SchedulerGroupType.None) e.Appointment.ResourceId = 1; };

            }
            finally {
                scheduler.EndUpdate();
            }
        }
        void CreateLabels(SchedulerControl scheduler) {
            SchedulerDataStorage storage = (SchedulerDataStorage)scheduler.DataStorage;
            storage.Appointments.Labels.Clear();
            storage.Appointments.Labels.Add(SchedulerColorId.BirthdayLabel, "1 Category", "1 Category");
            storage.Appointments.Labels.Add(SchedulerColorId.NeedsPreparationLabel, "2 Category", "2 Category");
            storage.Appointments.Labels.Add(SchedulerColorId.VacationLabel, "3 Category", "3 Category");
            storage.Appointments.Labels.Add(SchedulerColorId.PhoneCallLabel, "4 Category", "4 Category");
        }
        void CreateMappings(ISchedulerStorage storage) {
            AppointmentMappingInfo appointmentMappings = storage.Appointments.Mappings;
            appointmentMappings.AppointmentId = "Id";
            appointmentMappings.Start = "StartDate";
            appointmentMappings.End = "EndDate";
            appointmentMappings.AllDay = "AllDay";
            appointmentMappings.Subject = "Subject";
            appointmentMappings.Description = "Description";
            appointmentMappings.Location = "Location";
            appointmentMappings.ReminderInfo = "ReminderInfo";
            appointmentMappings.RecurrenceInfo = "RecurrenceInfo";
            appointmentMappings.Type = "EventType";
            appointmentMappings.ResourceId = "ResourceId";
            appointmentMappings.Label = "LabelId";
            appointmentMappings.Status = "StatusId";
            storage.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("Position", "Position", FieldValueType.String));
            storage.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping("Employee", "Employee", FieldValueType.String));

            ResourceMappingInfo resourceMappings = storage.Resources.Mappings;
            resourceMappings.Id = "Id";
            resourceMappings.Caption = "Caption";
            resourceMappings.ParentId = "ParentId";
            resourceMappings.Image = "Image";
        }

        CalendarBindingList GenerateResources() {
            CalendarBindingList calendars = new CalendarBindingList();
            calendars.Add(new Calendar() { Id = 0, Caption = "DevAV", ParentId = 0 });
            return calendars;
        }

        void GenerateLocations() {
            locations.Add("Conference Room A");
            locations.Add("Conference Room B");
            locations.Add("Training Room A");
            locations.Add("Training Room B");
        }
        EventBindingList GenerateEvents() {
            EventBindingList events = new EventBindingList();
            DateTime date = Start;
            int id = 0;
            id++; events.Add(CreateEvent(id, date.AddHours(8), date.AddHours(10), "Review product literature and marketing brochures", "Detailed review of all product literature and discuss layout of new marketing brochures. \r\n\r\nMust address customer complaints that our specifications are not 100% accurate.", 0, 0, GetNextEmployee(id), "Marketing"));
            id++; events.Add(CreateEvent(id, date.AddHours(10).AddMinutes(30), date.AddHours(12).AddMinutes(30), "Team training session on new automation engine", "Discuss new home automation API and see if we are close to integrating our products with Amazon Alexa. \r\n\r\nNeed to figure out if we'll ever release our own controller as well.", 2, 2, GetNextEmployee(id), "Product Manager"));
            id++; events.Add(CreateEvent(id, date.AddHours(13), date.AddHours(15), "Board of Directors meeting", "Demonstrate need for outside capital to help fuel sales growth and describe risks to business from weakness in supply chain.", 1, 1, GetNextEmployee(id), "Director"));
            id++; events.Add(CreateEvent(id, date.AddHours(15).AddMinutes(30), date.AddHours(17).AddMinutes(30), "Customer service training part 1", "Jack Howell from Worldwide Consulting will pay us a visit to give us pointers on how to improve our customer service processes.", 3, 3, GetNextEmployee(id), "Support Engineer"));
            date = date.AddDays(1);
            id++; events.Add(CreateEvent(id, date.AddHours(8), date.AddHours(10), "Product development meeting with R&D team", "Review schematics for new projectors and discuss options for 8K and Dolby Atmos. Determine if we should create our own A/V receiver.", 0, 0, GetNextEmployee(id), "Product Manager"));
            id++; events.Add(CreateEvent(id, date.AddHours(10).AddMinutes(30), date.AddHours(12).AddMinutes(30), "Customer service training part 2", "Part 2 - Jack promises that he will share some cutting edge techniques and case studies on how his system revolutionizes customer service processes.", 2, 2, GetNextEmployee(id), "Support Engineer"));
            id++; events.Add(CreateEvent(id, date.AddHours(13), date.AddHours(15), "Company-wide meeting", "Everyone must be ready to ask questions and inform leadership team why they are not performing as expected and what we need to do as a team to improve morale.", 1, 1, GetNextEmployee(id), "Director"));
            id++; events.Add(CreateEvent(id, date.AddHours(15).AddMinutes(30), date.AddHours(17).AddMinutes(30), "Train staff on new remote controls", "Our newest remote controls are ready for production. Everyone needs to understand how our new universal remote works and our long term plans for better automation.", 3, 3, GetNextEmployee(id), "Product Manager"));
            date = date.AddDays(1);
            id++; events.Add(CreateEvent(id, date.AddHours(8), date.AddHours(10), "Review financials with outside accounting firm", "Determine if all accounting rules are followed and make certain that last year's errors are addressed and will no longer be an issue going forward.", 0, 0, GetNextEmployee(id), "Accountant"));
            id++; events.Add(CreateEvent(id, date.AddHours(10).AddMinutes(30), date.AddHours(12).AddMinutes(30), "Sales Force Training", "All sales reps will be in attendance. Review sales techniques to determine how to best improve closing rates. Make certain to answer all product related questions during meeting.", 2, 2, GetNextEmployee(id), "Marketing Team"));
            id++; events.Add(CreateEvent(id, date.AddHours(13), date.AddHours(15), "Meeting with risk analysts", "Economists are suggesting that we are about to enter a global recession. Some analysts dispute this reality and we need to figure out who is right.", 1, 1, GetNextEmployee(id), "Director")); ;
            id++; events.Add(CreateEvent(id, date.AddHours(15).AddMinutes(30), date.AddHours(17).AddMinutes(30), "Company meeting", "Review rules that govern workplace behavior. Discuss impact of changes to the law and how it will impact DevAV in the upcoming 12 months.", 3, 3, GetNextEmployee(id), "Product Manager"));
            date = date.AddDays(1);
            id++; events.Add(CreateEvent(id, date.AddHours(8), date.AddHours(10), "Meeting with outside HR team", "Johnson & Co is promising to reduce our HR costs and improve the quality of hires. Need to verify that their proposal is factual and not smoke and mirrors.", 0, 0, GetNextEmployee(id), "Accountant"));
            id++; events.Add(CreateEvent(id, date.AddHours(10).AddMinutes(30), date.AddHours(12).AddMinutes(30), "Database overhaul meeting", "Meet to discuss changes required to our database to deal with new products and to address on-going complaints from staff members about performance.", 2, 2, GetNextEmployee(id), "Product Manager"));
            id++; events.Add(CreateEvent(id, date.AddHours(13), date.AddHours(15), "Review the basic principles of Game Theory", "Discuss game theory with entire team and see if we have the tools necessary to improve internal decision making.", 1, 1, GetNextEmployee(id), "Evangelist"));
            id++; events.Add(CreateEvent(id, date.AddHours(15).AddMinutes(30), date.AddHours(17).AddMinutes(30), "Determine operational deficiencies", "Weaknesses remain throughout operations and we need to determine the weakest link and eliminate any bottlenecks in production.", 3, 3, GetNextEmployee(id), "Product Manager"));
            date = date.AddDays(1);
            id++; events.Add(CreateEvent(id, date.AddHours(8), date.AddHours(10), "Meeting to discuss progress on new website", "The website is taking far too long to develop and we need to get everyone on board with management's plan to release the site this month.", 0, 0, GetNextEmployee(id), "Evangelist"));
            id++; events.Add(CreateEvent(id, date.AddHours(10).AddMinutes(30), date.AddHours(12).AddMinutes(30), "East-coast distributors meeting", "Host major distributors in the conference room and show them why they need to start carrying our products today.", 2, 2, GetNextEmployee(id), "Director"));
            id++; events.Add(CreateEvent(id, date.AddHours(13), date.AddHours(15), "Meet with analysts and media", "Share our upcoming product releases, discuss stengths of existing product line and provide demos of our new 8K panels.", 1, 1, GetNextEmployee(id), "Product Manager"));
            id++; events.Add(CreateEvent(id, date.AddHours(15).AddMinutes(30), date.AddHours(17).AddMinutes(30), "Meeting with EU regulators", "Meet with EU regulators to determine battery disposal regulations and how we can avoid fines going forward. Need to verify if our current procedures are sufficient.", 3, 3, GetNextEmployee(id), "Director"));
            return events;
        }

        Employee GetNextEmployee(int id) {
            if(Employees.Values.Count < id)
                return Employees.Values.ElementAt(id % Employees.Values.Count);
            return Employees.Values.ElementAt(id);
        }
        EventData CreateEvent(int id, DateTime startDate, DateTime endDate, string subject, string description, int locationId, int labelId, Employee employee, string position) {
            EventData result = new EventData();
            result.Id = id;
            result.StartDate = startDate;
            result.EndDate = endDate;
            result.Subject = subject;
            result.Description = description;
            result.AllDay = false;
            result.ResourceId = 0;
            result.EventType = 0;
            result.Location = this.locations[locationId];
            result.LabelId = labelId;
            result.StatusId = 0;
            result.Employee = employee.FullName;
            result.Photo = employee.Photo;
            result.Position = position;
            return result;
        }

    }
    public class Calendar {
        public int Id { get; set; }
        public string Caption { get; set; }
        public int ParentId { get; set; }
        public DevExpress.Utils.Svg.SvgImage Image { get; set; }
    }
    public class CalendarBindingList : BindingList<Calendar> {
    }
    public class EventBindingList : BindingList<EventData> {
        public EventBindingList() {
        }
    }
    public class EventData {
        [Key]
        public long Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool AllDay { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int EventState { get; set; }
        public int LabelId { get; set; }
        public int StatusId { get; set; }

        public string Employee { get; set; }
        public string Position { get; set; }
        public Image Photo { get; set; }
        public string Location { get; set; }
        public string ReminderInfo { get; set; }
        public string RecurrenceInfo { get; set; }
        public int EventType { get; set; }
        public int ResourceId { get; set; }
    }
}
