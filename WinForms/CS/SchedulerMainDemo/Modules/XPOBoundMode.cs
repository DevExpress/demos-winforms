using System;
using System.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace DevExpress.XtraScheduler.Demos {
    public partial class XPOBoundModeModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        DateTime baseDate = TutorialConstants.Today;

        public XPOBoundModeModule() {
            XpoDefault.DataLayer = new SimpleDataLayer(new InMemoryDataStore());
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
        }
        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

        private void XPOBoundModeModule_Load(object sender, System.EventArgs e) {
            schedulerControl.Start = baseDate;
            InitData();
        }
        private void OnAppointmentsChanged(object sender, PersistentObjectsEventArgs e) {
            foreach (Appointment apt in e.Objects) {
                XPBaseObject o = apt.GetSourceObject(schedulerStorage) as XPBaseObject;
                if (o != null)
                    o.Save();
            }
        }
        void InitData() {
            if (xpCollectionEmployees.Count <= 0) {
                for (int i = 0; i < 5; i++) {
                    AddEmployee(DemoUtils.Users[i]);
                }
            }
            if (xpCollectionTasks.Count <= 0) {
                for (int i = 0; i < xpCollectionEmployees.Count; i++) {
                    AddTasks((Employee)xpCollectionEmployees[i]);
                }
            }
        }
        void AddEmployee(string name) {
            Employee employee = new Employee(session1);
            employee.Name = name;
            xpCollectionEmployees.Add(employee);
            employee.Save();
        }
        void AddTasks(Employee employee) {
            AddTask(employee, "meeting", 2, 5);
            AddTask(employee, "travel", 3, 6);
            AddTask(employee, "phone call", 0, 10);
        }
        void AddTask(Employee employee, string taskName, int status, int label) {
            Task task = new Task(session1);
            task.Employee = employee;
            task.Subject = employee.Name + "'s " + taskName;

            int rangeInMinutes = 60 * 24;
            task.Created = baseDate + TimeSpan.FromMinutes(TutorialConstants.Random.Next(0, rangeInMinutes));
            task.Finish = task.Created + TimeSpan.FromMinutes(TutorialConstants.Random.Next(0, rangeInMinutes / 4));

            task.Status = status;
            task.Label = label;

            xpCollectionTasks.Add(task);
            task.Save();
        }
    }

    // XP object
    public class Task : XPObject {
        public Task(Session session) : base(session) { }
        public bool AllDay;              // Appointment.AllDay

        [Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
        public string Description;       // Appointment.Description

        public DateTime Finish;          // Appointment.End
        public int Label;                // Appointment.Label
        public string Location;          // Appointment.Location

        [Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
        public string Recurrence;        // Appointment.RecurrenceInfo

        [Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
        public string Reminder;          // Appointment.ReminderInfo

        public DateTime Created;         // Appointment.Start
        public int Status;               // Appointment.Status
        public string Subject;           // Appointment.Subject
        public int AppointmentType;      // Appointment.Type

        public Employee Employee;
    }

    // XP object
    public class Employee : XPObject {
        public Employee(Session session) : base(session) { }

        [Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
        public string Name;              // Resource.Caption
    }
}
