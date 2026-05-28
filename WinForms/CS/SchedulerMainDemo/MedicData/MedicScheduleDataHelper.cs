using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraScheduler.Native;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace DevExpress.XtraScheduler.Demos {
    public static class MedicScheduleDataHelper {

        public static DateTime BaseDate = TutorialConstants.Today;

        public static string[] AppointmentTypes = { "Hospital", "Office", "Phone Consultation", "Home", "Hospice" };
        public static SchedulerColorId[] AppointmentColorTypes = { SchedulerColorId.BusinessLabel, SchedulerColorId.ImportantLabel, SchedulerColorId.PhoneCallLabel, SchedulerColorId.PersonalLabel, SchedulerColorId.VacationLabel };

        public static string[] PaymentStates = { "Paid", "Unpaid" };
        public static Color[] PaymentColorStates = { Color.Green, Color.Red };

        public static string[] PatientNames = {   "Andrew Glover", "Mark Oliver", "Taylor Riley", "Addison Davis", "Benjamin Hughes", "Lucas Smith",
                                    "Robert King", "Laura Callahan", "Miguel Simmons", "Isabella Carter", "Andrew Fuller", "Madeleine Russell",
                                    "Steven Buchanan", "Nancy Davolio", "Michael Suyama", "Margaret Peacock", "Janet Leverling", "Ariana Alexander",
                                    "Brad Farkus", "Bart Arnaz", "Arnie Schwartz", "Billy Zimmer", "Samantha Piper", "Maggie Boxter",
                                    "Terry Bradley", "Stu Pizaro", "Greta Sims", "Sandra Johnson", "Cindy Stanwick", "Marcus Orbison",
                                    "Sandy Bright", "Ken Samuelson", "Brett Wade", "Wally Hobbs", "Brad Jameson", "Karen Goodson",
                                    "Morgan Kennedy", "Violet Bailey", "John Heart", "Arthur Miller", "Robert Reagan",
                                    "Ed Holmes", "Sammy Hill", "Olivia Peyton", "Jim Packard", "Hannah Brookly", "Harv Mudd",
                                    "Todd Hoffman", "Kevin Carter","Mary Stern", "Robin Cosworth","Jenny Hobbs", "Dallas Lou"};

        public static Dictionary<string, string[]> departmentCache = new Dictionary<string, string[]>();

        static MedicScheduleDataHelper() {
            departmentCache.Add("Therapy", new string[] { "Lincoln Bartlett", "Amelia Harper", "Stu Pizaro", "Sandra Johnson", "Victor Norris" });
            departmentCache.Add("Ophthalmology", new string[] { "Lucy Ball" });
            departmentCache.Add("Dentistry", new string[] { "Clark Morgan", "Leah Simpson" });
            departmentCache.Add("Surgery", new string[] { "Davey Jones" });
            departmentCache.Add("Neurology", new string[] { "Samantha Bright" });
        }

        public static List<Patient> CreatePatients() {
            List<Patient> patients = new List<Patient>();
            int patientCount = PatientNames.Length;
            int patientId = 1;
            DateTime birthday = new DateTime(1975, 2, 5);
            for (int i = 0; i < patientCount; i++) {
                Patient patient = new Patient();
                patient.Id = patientId++;
                patient.Name = PatientNames[i];
                patient.Birthday = birthday.AddMonths(TutorialConstants.Random.Next(1, 12)).AddYears(TutorialConstants.Random.Next(0, 20));
                patient.Phone = "(" + TutorialConstants.Random.Next(100, 999) + ") " + TutorialConstants.Random.Next(100, 999) + "-" + TutorialConstants.Random.Next(1000, 9999);
                patients.Add(patient);
            }
            return patients;
        }

        public static List<HospitalDepartment> CreateHospitalDepartments() {
            List<HospitalDepartment> departments = new List<HospitalDepartment>();
            int departmentId = 1;
            foreach (string name in departmentCache.Keys) {
                HospitalDepartment department = new HospitalDepartment();
                department.Id = departmentId++;
                department.Name = name;
                departments.Add(department);
            }
            return departments;
        }

        public static List<Medic> CreateMedics(List<HospitalDepartment> hospitalDepartments) {
            Dictionary<string, string[]> departmentCache = MedicScheduleDataHelper.departmentCache;
            List<Medic> medics = new List<Medic>();
            int departmentId = 1;
            int medicId = 1;
            foreach (KeyValuePair<string, string[]> department in departmentCache) {
                string[] medicNames = department.Value;
                int medicCount = medicNames.Length;
                for (int i = 0; i < medicCount; i++) {
                    Medic medic = new Medic();
                    medic.Id = medicId++;
                    medic.Name = medicNames[i];
                    medic.Phone = "(" + TutorialConstants.Random.Next(10, 99) + ") " + TutorialConstants.Random.Next(100, 999) + "-" + TutorialConstants.Random .Next(1000, 9999);
                    medic.DepartmentId = departmentId;
                    string imageName = String.Format("MedicData.Images.{0}.png", medic.Name.Replace(" ", ""));
                    if (DemoUtils.FindResourceName(imageName) != String.Empty) {
                        Image image = ResourceImageHelper.CreateImageFromResources(DemoUtils.FindResourceName(imageName), System.Reflection.Assembly.GetExecutingAssembly());
                        medic.SetPhoto(image);
                    }
                    medics.Add(medic);
                }
                departmentId++;
            }
            return medics;
        }

        public static List<MedicalAppointment> CreateMedicalAppointments(List<Medic> resources) {
            List<MedicalAppointment> appointments = new List<MedicalAppointment>();
            List<Patient> patients = CreatePatients();
            int appointmentId = 1;
            int patientIndex = 0;
            DateTime date = DateTimeHelper.GetStartOfWeek(BaseDate);
            foreach (Medic medic in resources) {
                TimeSpan duration = CalculateAppointmentDuration(medic);
                DateTime firstDate = new DateTime(date.Year, date.Month, date.Day, TutorialConstants.Random.Next(9, 11), 0, 0);
                for (DateTime startDate = firstDate; startDate < firstDate.AddDays(10); startDate += TimeSpan.FromDays(1)) {
                    TimeSpan endTime = new TimeSpan(18, 0, 0);
                    endTime = endTime.Add(-duration);
                    DateTime endDate = new DateTime(startDate.Year, startDate.Month, startDate.Day, endTime.Hours, endTime.Minutes, 0);
                    int room = TutorialConstants.Random.Next(1, 100);
                    for (DateTime startTime = startDate; startTime < endDate; startTime += duration.Add(new TimeSpan(0, TutorialConstants.Random.Next(2, 4) * 10, 0))) {
                        appointments.Add(CreateMedicAppointment(appointmentId, medic.Id, patients[patientIndex], startTime, duration, room));
                        appointmentId++;
                        patientIndex++;
                        if (patientIndex >= patients.Count() - 1)
                            patientIndex = 1;
                    }
                }
            }
            return appointments;
        }

        public static void CreateLabels(SchedulerDataStorage storage) {
            PersistentAppointmentLabelCollection labels = storage.Appointments.Labels;
            labels.Clear();
            int count = AppointmentTypes.Length;
            for (int i = 0; i < count; i++)
                labels.Add(AppointmentColorTypes[i], AppointmentTypes[i], AppointmentTypes[i]);
        }

        public static void CreateStatuses(SchedulerDataStorage storage) {
            PersistentAppointmentStatusCollection statuses = storage.Appointments.Statuses;
            statuses.Clear();
            int count = PaymentStates.Length;
            for (int i = 0; i < count; i++)
                statuses.Add(PaymentColorStates[i], PaymentStates[i]);
        }

        static TimeSpan CalculateAppointmentDuration(Medic resource) {
            switch (resource.DepartmentId) {
                case 1:
                    return new TimeSpan(0, TutorialConstants.Random.Next(2, 4) * 10, 0);
                case 2:
                    return new TimeSpan(0, TutorialConstants.Random.Next(3, 6) * 10, 0);
                case 3:
                    return new TimeSpan(TutorialConstants.Random.Next(0, 1), TutorialConstants.Random.Next(3, 4) * 10, 0);
                case 4:
                    return new TimeSpan(TutorialConstants.Random.Next(0, 1), TutorialConstants.Random.Next(2, 5) * 10, 0);
                case 5:
                    return new TimeSpan(0, TutorialConstants.Random.Next(2, 3) * 10, 0);
                default:
                    return new TimeSpan(0, TutorialConstants.Random.Next(2, 3) * 10, 0);
            }
        }

        static MedicalAppointment CreateMedicAppointment(long appointmentId, long resourceId, Patient patient, DateTime start, TimeSpan duration, int room) {
            MedicalAppointment medicalAppointment = new MedicalAppointment();
            medicalAppointment.Id = appointmentId;
            medicalAppointment.StartTime = start;
            medicalAppointment.EndTime = start.Add(duration);
            medicalAppointment.IssueId = TutorialConstants.Random.Next(0, 5);
            medicalAppointment.PaymentStatusId = TutorialConstants.Random.Next(0, 2);
            medicalAppointment.PatientId = patient.Id;
            medicalAppointment.MedicId = resourceId;
            if (medicalAppointment.IssueId != 3)
                medicalAppointment.Location = String.Format("{0}", room);
            return medicalAppointment;
        }
    }
}
