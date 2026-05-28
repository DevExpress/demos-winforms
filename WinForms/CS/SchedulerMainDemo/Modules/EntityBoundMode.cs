using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Common;
using System.ComponentModel.DataAnnotations;
using DevExpress.Utils;
using DevExpress.DXperience.Demos;
#if !NET
using System.Data.Entity;
using System.Data.SQLite;
#else
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
#endif

namespace DevExpress.XtraScheduler.Demos {
    public partial class EntityBoundModeModule : TutorialControl {
        DoctorScheduleContext dataContext;
        public EntityBoundModeModule() {
            InitializeComponent();
            this.schedulerControl1.Start = DoctorScheduleDataHelper.BaseDate;
            #if !NET
            Database.SetInitializer<DoctorScheduleContext>(null);
            #endif
            this.dataContext = new DoctorScheduleContext();
            DoctorScheduleDataHelper.InitIfRequired(this.dataContext);

            InitializeMappings(this.schedulerStorage1);
            DoctorScheduleDataHelper.CustomizeLabelsAndStatuses(this.schedulerStorage1);

            this.dataContext.Doctors.Load();
            this.dataContext.DoctorAppointments.Load();

            this.schedulerStorage1.Resources.DataSource = this.dataContext.Doctors.Local.ToBindingList();
            this.schedulerStorage1.Appointments.DataSource = this.dataContext.DoctorAppointments.Local.ToBindingList();

            this.schedulerStorage1.AppointmentsChanged += schedulerStorage1_AppointmentsChanged;
            this.schedulerStorage1.AppointmentsInserted += schedulerStorage1_AppointmentsChanged;
            this.schedulerStorage1.AppointmentsDeleted += schedulerStorage1_AppointmentsChanged;
        }
        protected override int TakeScreenDelay => 300;
        void schedulerStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e) {
            this.dataContext.SaveChanges();
        }
        void InitializeMappings(SchedulerStorage schedulerStorage) {
            AppointmentMappingInfo appointmentMapping = schedulerStorage.Appointments.Mappings;
            appointmentMapping.AllDay = "AllDay";
            appointmentMapping.Description = "Note";
            appointmentMapping.Subject = "PatientName";
            appointmentMapping.Start = "StartDate";
            appointmentMapping.End = "EndDate";
            appointmentMapping.Label = "IssueId";
            appointmentMapping.Location = "Location";
            appointmentMapping.RecurrenceInfo = "RecurrenceInfo";
            appointmentMapping.ReminderInfo = "ReminderInfo";
            appointmentMapping.ResourceId = "DoctorId";
            appointmentMapping.Status = "PaymentStatusId";
            appointmentMapping.Type = "EventType";

            ResourceMappingInfo resourceMapping = schedulerStorage.Resources.Mappings;
            resourceMapping.Id = "Id";
            resourceMapping.Caption = "Name";
        }
    }

    #region Data model
    public class DoctorAppointment {
        [Key]
        public Int64 Id { get; set; }
        public bool AllDay { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PatientName { get; set; }
        public string Note { get; set; }
        public int PaymentStatusId { get; set; }
        public int IssueId { get; set; }
        public int EventType { get; set; }
        public string Location { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public Int64? DoctorId { get; set; }
    }
    public class Doctor {
        [Key]
        public Int64 Id { get; set; }
        public string Name { get; set; }
    }

    public class DoctorScheduleContext : DbContext {
        #if !NET
        public DoctorScheduleContext() : base("name=DevExpress.XtraScheduler.Demos.Properties.Settings.DoctorConnectionString") {
        }
        #else
        public DoctorScheduleContext() : base(GetOptions()) {
        }

        private static DbContextOptions GetOptions() {
            var context = new DbContextOptionsBuilder<DoctorScheduleContext>();
            context.UseSqlite("Data Source = Doctors.sqlite");
            return context.Options;
        }
        #endif
        public DbSet<DoctorAppointment> DoctorAppointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    }
    #endregion

    #region DoctorScheduleDataHelper
    public class DoctorScheduleDataHelper {
        #region Table Creation Script
        public const string TableCreationScript =
     @"
-- Table: Doctors
CREATE TABLE Doctors ( 
Id      INTEGER PRIMARY KEY AUTOINCREMENT
                    UNIQUE,
    Name    TEXT
);

-- Table: DoctorAppointments
CREATE TABLE DoctorAppointments ( 
    Id             INTEGER  PRIMARY KEY AUTOINCREMENT
                            UNIQUE,
    AllDay          BOOLEAN,
    StartDate           DATETIME,
    EndDate           DATETIME,
    PatientName     TEXT,
    Note            TEXT,
    IssueId         INTEGER,
    PaymentStatusId INTEGER,
    EventType       INTEGER,
    Location        TEXT,
    RecurrenceInfo  TEXT,
    ReminderInfo    TEXT,
    DoctorId        INT64 
);
";
        #endregion
        public static DateTime BaseDate = TutorialConstants.Today.AddDays(-1);
        public static string[] IssueList = { "Consultation", "Treatment", "X-Ray" };
        public static Color[] IssueColorList = { DXColor.FromArgb(0x8D, 0xE9, 0xDF), DXColor.FromArgb(0xE0, 0xCF, 0xE9), DXColor.FromArgb(0xFF, 0xC2, 0xBE) };
        public static string[] PatientNames = {   "Andrew Glover", "Mark Oliver", "Taylor Riley", "Addison Davis", "Benjamin Hughes", "Lucas Smith",
                                    "Robert King", "Laura Callahan", "Miguel Simmons", "Isabella Carter", "Andrew Fuller", "Madeleine Russell",
                                    "Steven Buchanan", "Nancy Davolio", "Michael Suyama", "Margaret Peacock", "Janet Leverling", "Ariana Alexander",
                                    "Brad Farkus", "Bart Arnaz", "Arnie Schwartz", "Billy Zimmer", "Samantha Piper", "Maggie Boxter",
                                    "Terry Bradley", "Stu Pizaro", "Greta Sims", "Sandra Johnson", "Cindy Stanwick", "Marcus Orbison",
                                    "Sandy Bright", "Ken Samuelson", "Brett Wade", "Wally Hobbs", "Brad Jameson", "Karen Goodson",
                                    "Morgan Kennedy", "Violet Bailey", "John Heart", "Arthur Miller", "Robert Reagan",
                                    "Ed Holmes", "Sammy Hill", "Olivia Peyton", "Jim Packard", "Hannah Brookly", "Harv Mudd",
                                    "Todd Hoffman", "Kevin Carter","Mary Stern", "Robin Cosworth","Jenny Hobbs", "Dallas Lou"};
        public static string[] DoctorNames = { "Isabella Carter", "Miguel Simmons", "Madeleine Russell", "Ariana Alexander" };
        public static string[] PaymentStatuses = { "Paid", "Unpaid" };
        public static Color[] PaymentColorStatuses = { Color.Green, Color.Red };

        public static void InitIfRequired(DoctorScheduleContext dataContext) {
            DoctorScheduleDataHelper helper = new DoctorScheduleDataHelper(dataContext);
            helper.Create();
        }
        public static void CustomizeLabelsAndStatuses(SchedulerStorage storage) {
            AppointmentLabelCollection labels = storage.Appointments.Labels;
            labels.Clear();
            int count = IssueList.Length;
            for (int i = 0; i < count; i++) {
                IAppointmentLabel label = labels.CreateNewLabel(IssueList[i]);
                label.SetColor(IssueColorList[i]);
                labels.Add(label);
            }
            AppointmentStatusCollection statuses = storage.Appointments.Statuses;
            statuses.Clear();
            count = PaymentStatuses.Length;
            for (int i = 0; i < count; i++) {
                AppointmentStatus status = statuses.CreateNewStatus(PaymentStatuses[i]);
                status.Type = AppointmentStatusType.Custom;
                status.SetBrush(new SolidBrush(PaymentColorStatuses[i]));
                statuses.Add(status);
            }
        }

        DoctorScheduleContext dataContext;
        bool isSaveRequired = false;

        protected DoctorScheduleDataHelper(DoctorScheduleContext dataContext) {
            this.dataContext = dataContext;
        }

        public void Create() {
            CreateDBStructureIfRequired();
            this.dataContext.Doctors.Load();
            this.dataContext.DoctorAppointments.Load();
            if (this.dataContext.Doctors.Count() <= 0)
                CreateDoctors();

            if (this.dataContext.DoctorAppointments.Count() > 0) {
                DoctorAppointment appointment = this.dataContext.DoctorAppointments.FirstOrDefault((apt) => apt.EndDate >= DoctorScheduleDataHelper.BaseDate);
                if (appointment == null) {
                    this.dataContext.DoctorAppointments.Local.Clear();
                    this.dataContext.SaveChanges();
                }
            }

            if (this.dataContext.DoctorAppointments.Count() <= 0)
                CreateSchedule();

            if (!this.isSaveRequired)
                return;
            this.dataContext.SaveChanges();
            this.isSaveRequired = false;
        }
        void CreateDBStructureIfRequired() {
            #if !NET
            var connection = this.dataContext.Database.Connection as SQLiteConnection;
            connection.Open();
            var table = connection.GetSchema("Tables");
            if (table.Rows.Count > 0)
                return;
            var command = new SQLiteCommand(DoctorScheduleDataHelper.TableCreationScript, connection);
            #else
            var connection = this.dataContext.Database.GetDbConnection() as SqliteConnection;
            if (connection == null)
                return;
            connection.Open();
            var cmd = new SqliteCommand($"SELECT * FROM sqlite_master WHERE name='Doctors'", connection);
            var reader = cmd.ExecuteReader(CommandBehavior.SchemaOnly);
            if(reader.HasRows)
                return;
            var command = new SqliteCommand(TableCreationScript, connection);
            #endif
            command.ExecuteNonQuery();
        }
        void CreateDoctors() {
            int doctorCount = DoctorNames.Length;
            var doctors = this.dataContext.Doctors;
            for (int i = 0; i < doctorCount; i++) {
            #if !NET
                Doctor doctor = dataContext.Doctors.Create();
            #else
                Doctor doctor = new Doctor();
            #endif
                doctor.Name = DoctorNames[i];
                doctors.Add(doctor);
            }
            this.isSaveRequired = true;
        }
        void CreateSchedule() {
            int doctorAppointmentsCount = dataContext.DoctorAppointments.Count();
            if (doctorAppointmentsCount > 0)
                return;
            int doctorsCount = DoctorNames.Length;
            for (int doctorId = 1; doctorId <= doctorsCount; doctorId++)
                CreateDoctorSchedule(doctorId, BaseDate.AddHours(TutorialConstants.Random.Next(0, 2)));
            this.isSaveRequired = true;
        }
        void CreateDoctorSchedule(int doctorId, DateTime startDate) {
            for (DateTime start = BaseDate; start < BaseDate.AddDays(28); start += TimeSpan.FromDays(1)) {
                CreateDoctorAppointment(doctorId, start.AddHours(TutorialConstants.Random.Next(9, 11)));
                CreateDoctorAppointment(doctorId, start.AddHours(TutorialConstants.Random.Next(12, 14)));
                CreateDoctorAppointment(doctorId, start.AddHours(TutorialConstants.Random.Next(15, 18)));
            }
        }

        void CreateDoctorAppointment(int doctorId, DateTime start) {
            #if !NET
                DoctorAppointment doctorAppointment = dataContext.DoctorAppointments.Create();
            #else
                DoctorAppointment doctorAppointment = new DoctorAppointment();
            #endif
            doctorAppointment.StartDate = start;
            doctorAppointment.EndDate = start.AddMinutes(TutorialConstants.Random.Next(2, 6) * 10);
            doctorAppointment.IssueId = TutorialConstants.Random.Next(0, 3);
            doctorAppointment.PaymentStatusId = TutorialConstants.Random.Next(0, 2);
            int patientNameCount = PatientNames.Length;
            doctorAppointment.PatientName = PatientNames[TutorialConstants.Random.Next(0, patientNameCount - 1)];
            doctorAppointment.DoctorId = doctorId;
            this.dataContext.DoctorAppointments.Add(doctorAppointment);
        }
    }
    #endregion
}
