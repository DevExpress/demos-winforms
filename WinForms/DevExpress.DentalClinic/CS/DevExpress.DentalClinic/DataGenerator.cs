#if RECREATE_DATA
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.DentalClinic.Model;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.ClientServer;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.DentalClinic {
    public class DataGenerator {
        DataGenerator() { }
        static DataGenerator instanceCore;
        public static DataGenerator Instance {
            get {
                if(instanceCore == null)
                    instanceCore = new DataGenerator();
                return instanceCore;
            }
        }
        public DentalClinicDb Clinic { get; set; }
        public DevAV.DevAVDb DevAV { get; set; }
        public Random Random { get; set; }
        DataGenerationParameters parameters;
        public DataGenerationParameters Parameters {
            get {
                if(parameters == null)
                    parameters = CreateDataGenerationParams();
                return parameters;
            }
        }
        Dictionary<NoteType, List<NoteTemplate>> noteTemplates;
        Dictionary<NoteType, List<NoteTemplate>> NoteTemplates {
            get {
                if(noteTemplates == null)
                    noteTemplates = CreateNoteTemplates();
                return noteTemplates;
            }
        }
        public void RecreateData() {
            PurgeData();
            SetUp();
            FillData();
            ReplaceDb();
        }
        void ReplaceDb() {
            string destDbRelativePath = @"..\..\..\Data\DentalCabinet.db";
            if(File.Exists(destDbRelativePath))
                FilesHelper.EnsureWriteable(Application.StartupPath, destDbRelativePath);
            File.Copy(DentalClinicDb.DbPath, destDbRelativePath, true);
        }
        void SetUp() {
            Random = new Random((int)DateTime.Now.Ticks);
            DevAV = new DevAV.DevAVDb();
            Clinic = new DentalClinicDb();
        }
        void FillData() {
            ObjectSpace = Clinic.ObjectSpace;
            PopulateProcedures();
            PopulateDoctors(5);
            PopulatePatients();
            PopulateAppointments();
            PopulateUnassignedProcedures();
            PopulateNotes();
            SaveData();
            CreateAdmin();
            CreateUser();
            SaveData();
        }
        DataGenerationParameters CreateDataGenerationParams() {
            var dataGenParams = new DataGenerationParameters(Clinic);
            dataGenParams.AppointmentsPerPatientCounts = new[] { 4, 3, 5, 6 };
            dataGenParams.AppointmentProcedureCounts = new[] { 1, 2, 3 };
            dataGenParams.UnassignedProcedureCounts = new[] { 0, 1, 2, 3, 0 };
            dataGenParams.StatusProportion = new Dictionary<AppointmentStatus, double> {
                { AppointmentStatus.Open, 30 },
                { AppointmentStatus.Failed, 5 },
                { AppointmentStatus.Completed, 55 },
                { AppointmentStatus.Canceled, 10 }
            };
            return dataGenParams;
        }
        void PurgeData() {
            if(File.Exists(DentalClinicDb.DbPath)) {
                FilesHelper.EnsureWriteable(Application.StartupPath, DentalClinicDb.DbPath);
                File.Delete(DentalClinicDb.DbPath);
            }
        }
        void SaveData() {
            Clinic.CommitChanges();
        }
        void PopulateDoctors(int? count = null) {
            var employees = count != null ? DevAV.Employees.Take(count.Value) : DevAV.Employees;
            foreach(var employee in employees) {
                var address = CreateAddressFrom(employee.Address);
                Clinic.Addresses.Add(address);
                Doctor doctor = CreateDoctorFrom(employee, address);
                Clinic.Doctors.Add(doctor);
            }
        }
        Dictionary<long, Picture> images = new Dictionary<long, Picture>();
        List<Document> documents = new List<Document>();
        void PopulatePatients(int? count = null) {
            var customers = count != null ? DevAV.CustomerEmployees.Take(count.Value) : DevAV.CustomerEmployees;
            var pictures = customers.Select(x => x.Picture).Distinct();

            Document document1 = new Document(Clinic.Session);
            document1.Date = DateTime.Now;
            document1.Content = File.ReadAllBytes(@"..\..\..\Data\Logo.png");
            document1.Name = "X-ray.png";
            
            Document document2 = new Document(Clinic.Session);
            document2.Date = DateTime.Now;
            document2.Content = File.ReadAllBytes(@"..\..\..\Data\demo.pdf");
            document2.Name = "Test results.pdf";

            Clinic.Documents.Add(document1);
            Clinic.Documents.Add(document2);
            foreach(var picture in pictures) {
                var newPicture = new Picture(Clinic.Session);
                newPicture.Image = ByteImageConverter.FromByteArray(picture.Data);
                Clinic.Pictures.Add(newPicture);
                images.Add(picture.Id, newPicture);
            }
            //
            foreach(var customer in customers) {
                var address = CreateAddressFrom(customer.Address);
                Patient patient = CreatePatientFrom(customer, address, images[customer.Picture.Id]);
                patient.DocumentCollection.Add(document1);
                patient.DocumentCollection.Add(document2);
                Clinic.Patients.Add(patient);
            }
        }
        void CreateDocuments() {
            Document document1 = new Document(Clinic.Session);
            document1.Name = "X_ray.png";
            document1.Date = DateTime.Now;
            document1.Content = File.ReadAllBytes(@"..\..\..\Data\Logo.png");
            Clinic.Documents.Add(document1);
            Document document2 = new Document(Clinic.Session);
            document2.Name = "Test results.pdf";
            document2.Date = DateTime.Now;
            document2.Content = File.ReadAllBytes(@"..\..\..\Data\demo.pdf");
            Clinic.Documents.Add(document2);
            documents.Add(document1);
            documents.Add(document2);
        }
        void PopulateAppointments() {
            var appointmentInfos = AppointmentInfo.GenerateBy(Parameters);
            DateTime date = DateTime.Now;
            while(appointmentInfos.Count > 0) {
                date = date.AddSeconds(1);
                int index = Random.Next(0, appointmentInfos.Count - 1);
                var appointmentInfo = appointmentInfos[index];
                //Appointment
                var appointment = new Appointment(Clinic.Session);
                appointment.Patient = appointmentInfo.Patient;
                appointment.Doctor = appointmentInfo.Doctor;
                appointment.Status = appointmentInfo.Status;
                appointment.Date = date;
                //Invoice
                Invoice invoice = null;
                if(appointment.Status == AppointmentStatus.Completed) {
                    invoice = new Invoice(Clinic.Session);
                    invoice.Patient = appointmentInfo.Patient;
                    invoice.Date = date;
                    invoice.PaymentMethod = appointmentInfo.PaymentMethod;
                    invoice.PaymentStatus = appointmentInfo.PaymentStatus;
                    invoice.Doctor = appointmentInfo.Doctor;
                    invoice.Discount = appointmentInfo.Discount;
                }
                for(int i = 0; i < appointmentInfo.ProcedureCount; i++) {
                    //ProcedureItem
                    var procedureItem = new ProcedureItem(Clinic.Session);
                    procedureItem.Appointment = appointment;
                    procedureItem.Procedure = appointmentInfo.Procedures[i];
                    procedureItem.Patient = appointment.Patient;
                    procedureItem.ToothNumber = appointmentInfo.ProcedureTooths[i];
                    //
                    Clinic.ProcedureItems.Add(procedureItem);
                    //InvoiceItem
                    if(invoice == null) continue;
                    var invoiceItem = new InvoiceItem(Clinic.Session);
                    invoiceItem.Invoice = invoice;
                    invoiceItem.Procedure = appointmentInfo.Procedures[i];
                    invoiceItem.ProcedurePrice = invoiceItem.Procedure.Price;
                    invoiceItem.Discount = invoiceItem.ProcedurePrice == 0 ? 0 : invoice.Discount;
                    invoiceItem.Total = invoiceItem.ProcedurePrice * (1 - invoice.Discount / 100);
                    invoice.Total += invoiceItem.ProcedurePrice;
                    //
                    Clinic.InvoiceItems.Add(invoiceItem);
                }
                //
                Clinic.Appointments.Add(appointment);
                if(invoice != null) {
                    if(invoice.Total == 0)
                        invoice.Discount = 0;
                    invoice.GrandTotal = invoice.Total * (1 - invoice.Discount / 100);
                    invoice.Appointment = appointment;
                    //
                    Clinic.Invoices.Add(invoice);
                }
                appointmentInfos.RemoveAt(index);
            }
        }
        void PopulateUnassignedProcedures() {
            int[] unassignedProcedureCounts = Parameters.UnassignedProcedureCounts;
            var procedureGroups = ((ProcedureGroup[])Enum.GetValues(typeof(ProcedureGroup))).ToList();
            for(int i = 0; i < Clinic.Patients.Count; i++) {
                var patient = Clinic.Patients[i];
                int index = i % unassignedProcedureCounts.Length;
                int unassignedProcedureCount = unassignedProcedureCounts[Random.Next(index, unassignedProcedureCounts.Length - 1)];
                var toothNumbers = Enumerable.Range(1, 32).ToList();
                for(int j = 0; j < unassignedProcedureCount; j++) {
                    var procedureItem = new ProcedureItem(Clinic.Session);
                    var procedureGroup = procedureGroups[Random.Next(0, procedureGroups.Count - 1)];
                    var procedures = Clinic.Procedures.Where(p => p.Group == procedureGroup).ToList();
                    procedureItem.Procedure = procedures[Random.Next(0, procedures.Count - 1)];
                    procedureItem.Patient = patient;
                    procedureItem.ToothNumber = toothNumbers[Random.Next(0, toothNumbers.Count - 1)];
                    toothNumbers.Remove(procedureItem.ToothNumber);
                }
            }
        }
        void PopulateProcedures() {
            //ProcedureGroup.Diagnosis
            AddProcedure(ProcedureGroup.Diagnosis, ProcedureType.General, "ConeBeam CT X-ray (1 jaw)", 40, new TimeSpan(0, 15, 0));
            AddProcedure(ProcedureGroup.Diagnosis, ProcedureType.General, "ConeBeam CT X-ray (2 jaw)", 30, new TimeSpan(0, 15, 0));
            AddProcedure(ProcedureGroup.Diagnosis, ProcedureType.Tooth, "Bitewing X-Ray", 0, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.Diagnosis, ProcedureType.General, "Periapical X-Ray", 0, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.Diagnosis, ProcedureType.General, "Consultation and treatment plan", 0, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.Diagnosis, ProcedureType.General, "Blood test", 25, new TimeSpan(0, 10, 0));
            AddProcedure(ProcedureGroup.Diagnosis, ProcedureType.General, "Cephalometric X-ray", 15, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.Diagnosis, ProcedureType.General, "Panoramic X-Ray", 15, new TimeSpan(0, 20, 0));
            //ProcedureGroup.Restoration
            AddProcedure(ProcedureGroup.Restoration, ProcedureType.Tooth, "Cosmetic Composite resin restoration", 40, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Restoration, ProcedureType.Tooth, "Composite veneer", 100, new TimeSpan(0, 40, 0));
            AddProcedure(ProcedureGroup.Restoration, ProcedureType.Tooth, "Tooth gap filling", 50, new TimeSpan(0, 40, 0));
            AddProcedure(ProcedureGroup.Restoration, ProcedureType.Tooth, "Sealant", 15, new TimeSpan(0, 40, 0));
            AddProcedure(ProcedureGroup.Restoration, ProcedureType.Tooth, "Dental dam", 15, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Restoration, ProcedureType.Tooth, "Composite filling (minimal)", 15, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Restoration, ProcedureType.Tooth, "Composite filling (moderate)", 30, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Restoration, ProcedureType.Tooth, "Composite filling (enlarged)", 40, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Restoration, ProcedureType.Tooth, "Composite filling (extensive)", 50, new TimeSpan(0, 30, 0));
            //ProcedureGroup.RootCanal
            AddProcedure(ProcedureGroup.RootCanal, ProcedureType.Tooth, "Root canal re-treatment (premolar)", 200, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.RootCanal, ProcedureType.Tooth, "Root canal re-treatment (anterior)", 150, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.RootCanal, ProcedureType.Tooth, "Root canal re-treatment (molar)", 250, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.RootCanal, ProcedureType.Tooth, "Direct pulp capping", 50, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.RootCanal, ProcedureType.Tooth, "Root canal treatment (molar)", 200, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.RootCanal, ProcedureType.Tooth, "Abscess drainage/Abscess treatment", 50, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.RootCanal, ProcedureType.Tooth, "Root canal treatment (anterior)", 100, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.RootCanal, ProcedureType.Tooth, "Root canal treatment (premolar)", 150, new TimeSpan(0, 20, 0));
            //ProcedureGroup.Hygiene               
            AddProcedure(ProcedureGroup.Hygiene, ProcedureType.Tooth, "Cleaning and polishing (Moderate calculus)", 20, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.Hygiene, ProcedureType.Tooth, "Periodontal pocket treatment (non-surgical)", 10, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.Hygiene, ProcedureType.Tooth, "Operculectomy", 25, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Hygiene, ProcedureType.Tooth, "Cleaning and polishing (Mild calculus)", 15, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.Hygiene, ProcedureType.General, "Gum contouring surgery", 100, new TimeSpan(0, 50, 0));
            AddProcedure(ProcedureGroup.Hygiene, ProcedureType.General, "Gum grafting", 300, new TimeSpan(1, 0, 0));
            AddProcedure(ProcedureGroup.Hygiene, ProcedureType.Tooth, "Cleaning and polishing (Heavy calculus)", 25, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.Hygiene, ProcedureType.General,  "Teeth cleaning and polishing under local anesthetics", 100, new TimeSpan(0, 30, 0));
            //ProcedureGroup.Whitening
            AddProcedure(ProcedureGroup.Whitening, ProcedureType.General, "In-office laser whitening with Zoom 2", 250, new TimeSpan(0, 40, 0));
            AddProcedure(ProcedureGroup.Whitening, ProcedureType.General, "Internal bleaching", 100, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Whitening, ProcedureType.General, "Whitening Combination Package", 280, new TimeSpan(1, 0, 0));
            AddProcedure(ProcedureGroup.Whitening, ProcedureType.General, "At-home whitening kit (Zoom)", 100, new TimeSpan(0, 20, 0));
            //ProcedureGroup.Prosthetics
            AddProcedure(ProcedureGroup.Prosthetics, ProcedureType.Tooth, "Re-cement crown", 25, new TimeSpan(0, 15, 0));
            AddProcedure(ProcedureGroup.Prosthetics, ProcedureType.Tooth, "Composite onlay", 100, new TimeSpan(0, 40, 0));
            AddProcedure(ProcedureGroup.Prosthetics, ProcedureType.Tooth, "Temporary crown (PMMA)", 20, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Prosthetics, ProcedureType.Tooth, "Composite inlay", 100, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Prosthetics, ProcedureType.Tooth, "All-porcelain overlay (Emax CAD)", 400, new TimeSpan(1, 0, 0));
            AddProcedure(ProcedureGroup.Prosthetics, ProcedureType.Tooth, "All-porcelain inlay (Emax CAD)", 200, new TimeSpan(0, 40, 0));
            AddProcedure(ProcedureGroup.Prosthetics, ProcedureType.Tooth, "Crown removal", 15, new TimeSpan(0, 15, 0));
            AddProcedure(ProcedureGroup.Prosthetics, ProcedureType.Tooth, "Porcleain fused to titanium crown (CAD/CAM)", 350, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Prosthetics, ProcedureType.Tooth, "All-porcelain onlay (Emax CAD)", 350, new TimeSpan(0, 30, 0));
            //ProcedureGroup.Implantation
            AddProcedure(ProcedureGroup.Implantation, ProcedureType.Tooth, "Sinus augmentation (Open)", 600, new TimeSpan(1, 0, 0));
            AddProcedure(ProcedureGroup.Implantation, ProcedureType.Tooth, "Bone grafting", 600, new TimeSpan(0, 40, 0));
            AddProcedure(ProcedureGroup.Implantation, ProcedureType.Tooth, "Sinus augmentation (Closed)", 300, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Implantation, ProcedureType.Tooth, "Guided bone regeneration membrane", 400, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Implantation, ProcedureType.General, "All on 6 (Nobel Biocare/SGS Switzerlang dental implant)", 10000, new TimeSpan(0, 50, 0));
            AddProcedure(ProcedureGroup.Implantation, ProcedureType.General, "All on 8 (Nobel Biocare/SGS Switzerlang dental implant)", 13000, new TimeSpan(1, 30, 0));
            AddProcedure(ProcedureGroup.Implantation, ProcedureType.Tooth, "Nobel Biocare/SGS Switzerlang dental implant", 1500, new TimeSpan(0, 40, 0));
            //ProcedureGroup.Orthodontics
            AddProcedure(ProcedureGroup.Orthodontics, ProcedureType.Tooth, "Traditional ceramic braces - Complicated case: lost of molar, root treated teeth etc", 2800, new TimeSpan(0, 40, 0));
            AddProcedure(ProcedureGroup.Orthodontics, ProcedureType.Tooth, "Traditional metal braces - Simple case: no extraction required", 1500, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.Orthodontics, ProcedureType.Tooth, "Traditional metal braces - Complicated case: lost of molar, root treated teeth etc", 2500, new TimeSpan(0, 40, 0));
            AddProcedure(ProcedureGroup.Orthodontics, ProcedureType.Tooth, "Traditional metal braces - Requires extraction (fee for extraction is not included)", 1750, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Orthodontics, ProcedureType.Tooth, "Traditional ceramic braces - Requires extraction (fee for extraction is not included)", 2590, new TimeSpan(0, 40, 0));
            AddProcedure(ProcedureGroup.Orthodontics, ProcedureType.Tooth, "Traditional ceramic braces - Simple case: no extraction required", 2000, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Orthodontics, ProcedureType.General, "Invisalign ClinCheck", 250, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.Orthodontics, ProcedureType.General, "Functional appliance", 300, new TimeSpan(0, 20, 0));
            AddProcedure(ProcedureGroup.Orthodontics, ProcedureType.General, "Invisalign", 4500, new TimeSpan(0, 50, 0));
            //ProcedureGroup.Surgery
            AddProcedure(ProcedureGroup.Surgery, ProcedureType.Tooth, "Wisdom tooth extraction (upper jaw)", 100, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Surgery, ProcedureType.Tooth, "Tooth extraction with bone grafting", 500, new TimeSpan(0, 40, 0));
            AddProcedure(ProcedureGroup.Surgery, ProcedureType.Tooth, "Gum contouring surgery", 150, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Surgery, ProcedureType.Tooth, "Crown lengthening surgery", 100, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Surgery, ProcedureType.Tooth, "Surgical tooth extraction", 175, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Surgery, ProcedureType.Tooth, "Wisdom tooth extraction (lower jaw)", 125, new TimeSpan(0, 30, 0));
            AddProcedure(ProcedureGroup.Surgery, ProcedureType.Tooth, "Permanent tooth extraction", 80, new TimeSpan(0, 30, 0));
        }
        void PopulateNotes(int[] noteCounts = null) {
            if(noteCounts == null)
                noteCounts = new int[] { 2, 4, 1, 5, 3 };
            foreach(var patient in Clinic.Patients) {
                PopulateNotes(patient, NoteType.Clinical, noteCounts);
                PopulateNotes(patient, NoteType.Complaint, noteCounts);
                PopulateNotes(patient, NoteType.Allergy, noteCounts);
            }
            Clinic.Session.CommitChanges();
        }
        void PopulateNotes(Patient patient, NoteType noteType, int[] noteCounts) {
            var noteCount = noteCounts[Random.Next(0, noteCounts.Length - 1)];
            var noteTemplates = NoteTemplates[noteType].ToList();
            string noteText = string.Empty;
            for(int i = 0; i < noteCount && noteTemplates.Count > 0; i++) {
                var randomTemplateIndex = Random.Next(0, noteTemplates.Count - 1);
                var noteTemplate = noteTemplates[randomTemplateIndex];
                noteText += new string(' ', 4);
                noteText += noteTemplate.GetRandomNote(Random);
                noteText += Environment.NewLine;
                noteTemplates.Remove(noteTemplate);
            }
            if(noteType == NoteType.Clinical)
                patient.Notes = noteText;
            if(noteType == NoteType.Allergy)
                patient.Allergies = noteText;
            if(noteType == NoteType.Complaint)
                patient.Complaints = noteText;
        }
        Dictionary<NoteType, List<NoteTemplate>> CreateNoteTemplates() {
            return new Dictionary<NoteType, List<NoteTemplate>> {
                {
                    NoteType.Clinical,
                    new List<NoteTemplate> {
                        new NoteTemplate(
                            "Antibiotic Pre-Med Confirmed",
                            "The patient confirmed that they pre-medicated with {0} one hour prior to todays appointment, as instructed. The patient's dental chart indicates that they must be pre-medicated prior to any dental treatment. The patient was instructed to pre-medicate with two grams of the antibiotic (4 pills) one hour prior to todays appointment.",
                            new[] {
                                new NoteTemplateItem(new[] { "Amoxicillin 500 mg","Celcor 500 mg", "Hydrocondone 5 mg", "Keflex 500 mg","Tylenol #3","Valium 5 mg","Zpak"}, false),
                            }),
                        new NoteTemplate(
                            "Antibiotic Pre-Med Negative",
                            "The patient was asked if they pre-medicated with antibiotics one hour prior to todays appointment. The patient's dental chart indicates that they must be pre-medicated prior to any dental treatment. The patient stated that they DID NOT pre-medicate prior to todays appointment. The patient was re-appointed."),
                        new NoteTemplate(
                            "Health History Updated",
                            "Before dental treatment, the patient was asked about changes to their medical history such as a recent surgery or changes in medication. Patient confirmed verbally that there have been changes in their medical history."),
                        new NoteTemplate(
                            "Health History, No Change",
                            "Before dental treatment, the patient was asked about changes to their medical history such as a recent surgery or changes in medication. Patient confirmed verbally that there have been NO changes in their medical history."),
                        new NoteTemplate(
                            "Health History, None",
                            "The patient has stated that they are not currently taking any medications, do not have any health issues, and have no need to be under a doctor's care at this time."),
                        new NoteTemplate(
                            "Cosmetic Aberration",
                            "The patient has {0}, {1}.",
                            new [] {
                                new NoteTemplateItem(new[] { "skeletal aberration", "soft tissue aberration"}, false),
                                new NoteTemplateItem(new[] { "treatable by Dentist", "treatable by Physician", "not treatable"}, false),
                            }),
                        new NoteTemplate(
                            "Cosmetic Issue",
                            "The patient has {0} {1} in the {2} area.",
                            new [] {
                                new NoteTemplateItem(new[] { "no", "a mild level of", "a moderate level of", "a severe level of"}, false),
                                new NoteTemplateItem(new[] { "abnormal tooth morphology", "diastema", "fractured teeth", "malalignment", "missing teeth", "stains", "unacceptable restorations"}, false),
                                new NoteTemplateItem(new[] { "maxillary, anterior", "maxillary, posterior", "mandibular, anterior", "mandibular, posterior"}, false)
                            }),
                        new NoteTemplate(
                            "Oral Pathology",
                            "The patient has {0} {1} oral pathology. {2} is recommended. The prognosis is {3}. {4}.",
                            new [] {
                                new NoteTemplateItem(new[] { "no", "mild", "moderate", "severe"}, false),
                                new NoteTemplateItem(new[] { "evident", "developmental", "systemic", "surface", "deep"}, false),
                                new NoteTemplateItem(new[] { "No treatment", "A biopsy", "Other treatment", "Patient referral to a specialist"}, false),
                                new NoteTemplateItem(new[] { "good", "fair", "poor", "unknown"}, false),
                                new NoteTemplateItem(new[] { "There is no evident tooth-related oral pathology", "Oral pathology is tooth related", "Oral pathology is not tooth related"}, false)
                            }),
                        new NoteTemplate(
                            "Patient Health",
                            "Patient health conditions: {0}.",
                            new [] {
                                new NoteTemplateItem(
                                    new[] {
                                        "AIDS", "Allergies", "Anemia", "Arthritis", "Artificial Joints", "Asthma", "Blood Disease", "Cancer", "Codeine Allergy", "Diabetes", "Dizziness", "Epilepsy",
                                        "Excessive Bleeding", "Fainting", "Glaucoma", "Growths","Hay Fever", "Head Injuries", "Heart Disease", "Heart Murmur", "Hepatitis", "HIV Positive", "Hypertension",
                                        "Jaundice","Kidney Disease", "Liver Disease", "Mental Disorders", "Nervous Disorders", "Pacemaker", "Penicillin Allergy", "Pregnancy", "Radiation Treatment",
                                        "Respiratory Problems", "Rheumatic Fever", "Rheumatism", "Sinus Problems","Stomach Problems","Stroke", "Tuberculosis", "Tumors", "Ulcers", "Venereal Disease"},
                                    true)
                            }),
                        new NoteTemplate(
                            "No Medication or Antibiotic",
                            "Neither pain medication nor antibiotics were given to the patient. The patient understood that their procedures were minor and did not require the use of either pain medication or antibiotics."),
                        new NoteTemplate(
                            "Prescription",
                            "The patient has been given the following prescription: {0}, {1}; {2}.There are {3} refills on the prescription.Prescription instructions have been given to the patient and the patient has confirmed that they understand the instructions.",
                            new [] {
                                new NoteTemplateItem(new[] { "Amoxicillin 500 mg","Celcor 500 mg", "Hydrocondone 5 mg", "Keflex 500 mg","Tylenol #3","Valium 5 mg","Zpak"}, false),
                                new NoteTemplateItem(new[] { "8 tabs", "20 tabs", "30 tabs", "dispense one pack"}, false),
                                new NoteTemplateItem(new[] { "Take 2 now", "1 Q 6 H until gone", "1 Q4-6H pm pain"}, false),
                                new NoteTemplateItem(Enumerable.Range(0, 11).Select(x => x.ToString()).ToArray(), false),
                            }),
                        new NoteTemplate(
                            "Prescription to Pharmacy",
                            "The patient's prescription was {0}.",
                            new [] {
                                new NoteTemplateItem(new[] { "phoned in to a pharmacy technician", "phoned in to the pharmacy", "A message was left on the pharmacy's answering machine", "sent to the pharmacy by fax", "sent to the pharmacy by e-mail"}, false),
                            }),
                        new NoteTemplate(
                            "Patient Referred",
                            "The patient has been referred to {0} for {1}.",
                            new [] {
                                new NoteTemplateItem(new[] { "an endodontist", "an orthodontist", "an oral surgeon", "a pedodontist", "a periodontist", "a prosthodontist", "their primary care physician"}, false),
                                new NoteTemplateItem(new[] { "second opinion", "further treatment" }, false),
                            }),
                        new NoteTemplate(
                            "Patient, Consider Tx Options",
                            "The patient has been presented with several treatment options and understands that they need to schedule an appointment and return to the office for treatment when they have decided upon a treatment plan."),
                        new NoteTemplate(
                            "Patient Instructions",
                            "The patient has been given their removable appliance and has been instructed to return to the office if they experience any discomfort related to the appliance or if the appliance requires any adjustments."),
                        new NoteTemplate(
                            "Used FMX Instead of X-ray",
                            "No X-ray was taken of the patient. The most recent FMX was used instead."),
                        new NoteTemplate(
                            "X-ray, Patient NO Permission",
                            "A thorough explanation of the benefits and risks associated with the taking of digital x-rays was verbally discussed with the patient, including the necessity of taking an x-ray on tooth {0}. Despite my recommendations to have x-rays taken, the patient refused to give permission to take x-rays and the patient understands the possible consequences of this action.",
                            new[] {
                                new NoteTemplateItem(Enumerable.Range(1, 32).Select(x => x.ToString()).ToArray(), false),
                            }),
                    }
                },
                {
                    NoteType.Complaint,
                    new List<NoteTemplate> {
                        new NoteTemplate(
                            "Pain, Hard Tissue",
                            "The patient has pain in the following teeth: {0}.",
                            new[] {
                                new NoteTemplateItem(Enumerable.Range(1, 32).Select(x => x.ToString()).ToArray(), true)
                            }),
                        new NoteTemplate(
                            "Pain, No Swelling",
                            "Patient experiences pain but has no swelling in the {0} quadrant. The pain seems to be associated with tooth {1}.",
                            new [] {
                                new NoteTemplateItem(new[] { "Upper Right", "Upper Left","Lower Right", "Lower Left"}, false),
                                new NoteTemplateItem(Enumerable.Range(1, 32).Select(x => x.ToString()).ToArray(), false)
                            }),
                        new NoteTemplate(
                            "Pain, Soft Tissue",
                            "There is evidence of {0} on the {1} adjacent to tooth {2}. From the patient's description it is determined that the pain level is {3}.",
                            new [] {
                                new NoteTemplateItem(new[] { "bleeding", "suppuration", "swelling", "ulceration"}, false),
                                new NoteTemplateItem(new[] { "facial", "buccal", "palatal", "lingual"}, false),
                                new NoteTemplateItem(Enumerable.Range(1, 32).Select(x => x.ToString()).ToArray(), false),
                                new NoteTemplateItem(new[] { "low acute", "low chronic", "high acute", "high chronic"}, false),
                            }),
                        new NoteTemplate(
                            "Pain, Swelling",
                            "Patient complains of pain and swelling in the {0} quadrant. The swelling is located near the {1} surface of tooth {2}.",
                            new [] {
                                new NoteTemplateItem(new[] { "Upper Right", "Upper Left","Lower Right", "Lower Left"}, false),
                                new NoteTemplateItem(new[] { "mesial","incisal","occlusal","distal","lingual","facial","buccal","mesiobuccal","mesiolingual","distobuccal","distolingual"}, false),
                                new NoteTemplateItem(Enumerable.Range(1, 32).Select(x => x.ToString()).ToArray(), false),
                            }),
                        new NoteTemplate(
                            "TMJ Joint Problem",
                            "Patient complained of pain in the following joint(s): {0}.",
                            new [] {
                                new NoteTemplateItem(new[] { "Right TMJ", "Left TMJ"}, true),
                            }),
                        new NoteTemplate(
                            "Ulcers in Mouth",
                            "The patient complained of pain in the oral cavity. An examination revealed the presence of an ulcerated, white, circular lesion of {0} in diameter, on the mucosa in the {1} quadrant, on the {2} surface adjacent to tooth {3}.",
                            new [] {
                                new NoteTemplateItem(new[] { "less than 5 mm", "5 mm to 10 mm", "greater than 1 cm" }, false),
                                new NoteTemplateItem(new[] { "Upper Right", "Upper Left","Lower Right", "Lower Left"}, false),
                                new NoteTemplateItem(new[] { "mesial","incisal","occlusal","distal","lingual","facial","buccal","mesiobuccal","mesiolingual","distobuccal","distolingual"}, false),
                                new NoteTemplateItem(Enumerable.Range(1, 32).Select(x => x.ToString()).ToArray(), false),
                            }),
                    }
                },
                {
                    NoteType.Allergy,
                    new List<NoteTemplate> {
                        new NoteTemplate("Allergy to", "Allergy to {0}.", new[] {
                            new NoteTemplateItem(new []{ "nonsteroidal anti-inflammatory drugs", "acetaminophen", "opioids", "beta-lactam antibiotics", "clindamycin","azithromycin","tetracyclines","local anesthetics" }, false)
                        }),
                        new NoteTemplate("Hypersensitivity reactions", "Hypersensitivity reactions."),
                        new NoteTemplate("Lichenoid Reactions", "Lichenoid Reactions."),
                        new NoteTemplate("Allergic reactions", "Allergic reactions to {0}.", new[] {
                            new NoteTemplateItem(new []{ "natural rubber latex", "dental amalgam", "nickel", "titanium" }, false)
                        }),
                    }
                }
            };
        }
        void AddProcedure(ProcedureGroup procedureGroup, ProcedureType procedureType, string procedureName, decimal price, TimeSpan duration) {
            var procedure = new Procedure(Clinic.Session);
            procedure.Price = price;
            procedure.Name = procedureName;
            procedure.Group = procedureGroup;
            procedure.Duration = duration;
            procedure.Type = procedureType;
            Clinic.Procedures.Add(procedure);
        }
        Doctor CreateDoctorFrom(DevAV.Employee employee, Address address) {
            var doctor = ObjectSpace.CreateObject<Doctor>();
            doctor.FirstName = employee.FirstName;
            doctor.LastName = employee.LastName;
            doctor.Birthday = employee.BirthDate ?? new DateTime(1975 + Random.Next(0, 20), Random.Next(1, 12), Random.Next(0, 28));
            doctor.Email = employee.Email;
            doctor.Phone = employee.HomePhone;
            doctor.Photo = employee.Photo;
            doctor.Address = address;
            doctor.UserName = employee.LastName;
            doctor.SetPassword("");
            doctor.EmployeeRoles.Add(CreateDefaultRole());
            return doctor;
        }
        Patient CreatePatientFrom(DevAV.CustomerEmployee customer, Address address, Picture picture) {
            return new Patient(Clinic.Session) {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Birthday = new DateTime(1965 + Random.Next(0, 20), Random.Next(1, 12), Random.Next(1, 27)),
                Email = customer.Email,
                Phone = customer.MobilePhone,
                Picture = picture,
                Address = address
            };
        }
        Address CreateAddressFrom(DevAV.Address address) {
            return new Address(Clinic.Session) {
                City = address.City,
                ZipCode = address.ZipCode,
                State = address.State.ToString(),
                Street = address.Line
            };
        }
        static void CreateUser() {
            Employee sampleUser = ObjectSpace.FindObject<Employee>(new BinaryOperator("UserName", "User"));
            if(sampleUser == null) {
                sampleUser = ObjectSpace.CreateObject<Employee>();
                sampleUser.UserName = "User";
                sampleUser.SetPassword("");
            }
            EmployeeRole defaultRole = CreateDefaultRole();
            sampleUser.EmployeeRoles.Add(defaultRole);
        }
        static void CreateAdmin() {
            Employee userAdmin = ObjectSpace.FindObject<Employee>(new BinaryOperator("UserName", "Admin"));
            if(userAdmin == null) {
                userAdmin = ObjectSpace.CreateObject<Employee>();
                userAdmin.UserName = "Admin";
                userAdmin.SetPassword("");
            }
            EmployeeRole adminRole = CreateAdminRole();
            userAdmin.EmployeeRoles.Add(adminRole);
        }
        static IObjectSpace ObjectSpace { get; set; }
        static EmployeeRole CreateAdminRole() {
            EmployeeRole adminRole = ObjectSpace.FindObject<EmployeeRole>(new BinaryOperator("Name", "Administrators"));
            if(adminRole == null) {
                adminRole = ObjectSpace.CreateObject<EmployeeRole>();
                adminRole.Name = "Administrators";
            }
            adminRole.IsAdministrative = true;
            return adminRole;
        }
        private static EmployeeRole CreateDefaultRole() {
            EmployeeRole defaultRole = ObjectSpace.FindObject<EmployeeRole>(new BinaryOperator("Name", "Default"));
            if(defaultRole == null) {
                defaultRole = ObjectSpace.CreateObject<EmployeeRole>();
                defaultRole.Name = "Default";
                defaultRole.PermissionPolicy = SecurityPermissionPolicy.AllowAllByDefault;
                defaultRole.AddObjectPermission<Employee>(SecurityOperations.Read, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                defaultRole.AddObjectPermission<PermissionPolicyUser>(SecurityOperations.Read, "[Oid] = CurrentUserId()", SecurityPermissionState.Allow);
                defaultRole.AddNavigationPermission(@"UserCollection", SecurityPermissionState.Deny);
                defaultRole.AddTypePermissionsRecursively<PermissionPolicyRole>(SecurityOperations.Read, SecurityPermissionState.Deny);
                defaultRole.AddTypePermissionsRecursively<Invoice>(SecurityOperations.Delete, SecurityPermissionState.Deny);
                defaultRole.AddTypePermissionsRecursively<InvoiceItem>(SecurityOperations.Delete, SecurityPermissionState.Deny);
            }
            return defaultRole;
        }
        public class DataGenerationParameters {
            public DataGenerationParameters(DentalClinicDb data) {
                Data = data;
                Random = new Random((int)DateTime.Now.Ticks);
            }
            public DentalClinicDb Data { get; }
            public Random Random { get; }
            public int[] AppointmentsPerPatientCounts { get; set; }
            public int[] AppointmentProcedureCounts { get; set; }
            public int[] UnassignedProcedureCounts { get; set; }
            public Dictionary<AppointmentStatus, double> StatusProportion { get; set; }
            public int RandomAppointmentsPerPatientCount {
                get {
                    if(AppointmentsPerPatientCounts == null) return 0;
                    return AppointmentsPerPatientCounts[Random.Next(0, AppointmentsPerPatientCounts.Length - 1)];
                }
            }
            public int RandomAppointmentProcedureCount {
                get {
                    if(AppointmentProcedureCounts == null) return 0;
                    return AppointmentProcedureCounts[Random.Next(0, AppointmentProcedureCounts.Length - 1)];
                }
            }
            public int RandomUnassignedProcedureCount {
                get {
                    if(UnassignedProcedureCounts == null) return 0;
                    return UnassignedProcedureCounts[Random.Next(0, UnassignedProcedureCounts.Length - 1)];
                }
            }
        }
        class AppointmentInfo {
            public static List<AppointmentInfo> GenerateBy(DataGenerationParameters genParams) {
                var random = Instance.Random;
                var result = new List<AppointmentInfo>();
                var apptsPerPatientCounts = Instance.Clinic.Patients.Select(p => new { Patient = p, AppointmentCount = genParams.RandomAppointmentsPerPatientCount }).ToList();
                int totalAppointmentCount = apptsPerPatientCounts.Sum(x => x.AppointmentCount);
                AppointmentStatus[] statuses = EnsureAppointmentStatuses(totalAppointmentCount, genParams.StatusProportion, random);
                int aptIndex = 0;
                foreach(var apptsPerPatientCount in apptsPerPatientCounts) {
                    var patientAptStatuses = new List<AppointmentStatus>();
                    CorrectPatientAppointmentsStatuses(aptIndex, apptsPerPatientCount.AppointmentCount, ref statuses);
                    for(int i = 0; i < apptsPerPatientCount.AppointmentCount; i++) {
                        var aptStatus = statuses[aptIndex];
                        patientAptStatuses.Add(aptStatus);
                        result.Add(new AppointmentInfo(genParams, aptStatus, apptsPerPatientCount.Patient, i));
                        aptIndex++;
                    }
                }
                return result;
            }
            static void CorrectPatientAppointmentsStatuses(int startIndex, int count, ref AppointmentStatus[] statuses) {
                if(count < 2)
                    return;
                int endIndex = startIndex + count - 1;
                int completedIdx = Array.IndexOf(statuses, AppointmentStatus.Completed, startIndex, count);
                if(completedIdx == -1) {
                    statuses[startIndex] = AppointmentStatus.Completed;
                    completedIdx = startIndex;
                }
                int openIdx = Array.IndexOf(statuses, AppointmentStatus.Open, startIndex, count);
                if(openIdx == -1) {
                    openIdx = endIndex == completedIdx ? endIndex - 1 : endIndex;
                    statuses[openIdx] = AppointmentStatus.Open;
                }
            }
            static AppointmentStatus[] EnsureAppointmentStatuses(int appointmentCount, Dictionary<AppointmentStatus, double> proportion, Random random) {
                var result = new AppointmentStatus[appointmentCount];
                var indexes = Enumerable.Range(0, appointmentCount).Reverse().ToList();
                var remainingProportion = proportion.Values.Sum();
                int remainingCount = appointmentCount;
                for(int i = 0; i < proportion.Count; i++) {
                    bool isLast = i == proportion.Count - 1;
                    var proportionItem = proportion.Keys.ElementAt(i);
                    double percent = proportion[proportionItem];
                    int count = isLast ? remainingCount : (int)(percent / remainingProportion * remainingCount + 0.5F);
                    remainingCount -= count;
                    remainingProportion -= percent;
                    while(count > 0) {
                        int index = random.Next(0, indexes.Count - 1);
                        result[indexes[index]] = proportionItem;
                        indexes.RemoveAt(index);
                        count--;
                    }
                }
                return result;
            }
            DataGenerationParameters paramsCore;
            AppointmentInfo(DataGenerationParameters @params, AppointmentStatus status, Patient patient, int index) {
                paramsCore = @params;
                Index = index;
                Status = status;
                Patient = patient;
                EnsureInfo();
            }
            public DentalClinicDb Data { get { return paramsCore.Data; } }
            public Random Random { get { return paramsCore.Random; } }
            public int Index { get; set; }
            public Patient Patient { get; set; }
            public AppointmentStatus Status { get; set; }
            public PaymentMethod PaymentMethod { get; set; }
            public PaymentStatus PaymentStatus { get; set; }
            public Doctor Doctor { get; set; }
            public decimal Discount { get; set; }
            public int ProcedureCount { get; set; }
            public Procedure[] Procedures { get; set; }
            public int[] ProcedureTooths { get; set; }
            void EnsureInfo() {
                EnsureProcedureCount();
                EnsureProcedures();
                EnsurePaymentMethod();
                EnsurePaymentStatus();
                EnsureDoctor();
                EnsureDiscount();
                EnsureProcedureTooths();
            }
            void EnsureDiscount() {
                Discount = Random.NextDouble() > 0.7 ? 5 : 0;
            }
            void EnsureDoctor() {
                Doctor = Data.Doctors.ElementAt(Random.Next(0, Data.Doctors.Count));
            }
            void EnsurePaymentMethod() {
                PaymentMethod = Random.NextDouble() > 0.5 ? PaymentMethod.Cash : PaymentMethod.Card;
            }
            void EnsurePaymentStatus() {
                if(Status == AppointmentStatus.Completed) {
                    if(Random.NextDouble() < 0.7)
                        PaymentStatus = PaymentStatus.PaidInFull;
                    else
                        PaymentStatus = Random.NextDouble() < 0.5 ? PaymentStatus.Unpaid : PaymentStatus.RefundInFull;
                }
            }
            void EnsureProcedureCount() {
                var actualInvoiceItemsCounts = Index == 0 ? paramsCore.AppointmentProcedureCounts.Except(new[] { 1 }).ToArray() : paramsCore.AppointmentProcedureCounts;
                ProcedureCount = actualInvoiceItemsCounts[Random.Next(0, actualInvoiceItemsCounts.Length - 1)];
            }
            void EnsureProcedures() {
                Procedures = new Procedure[ProcedureCount];
                var procedureGroups = (ProcedureGroup[])Enum.GetValues(typeof(ProcedureGroup));
                for(int i = 0; i < ProcedureCount; i++) {
                    bool isOnlyOneItem = ProcedureCount == 1;
                    bool isFirstProcedure = Index == 0 && i == 0;
                    int procedureGroupIndex = 0;
                    var actualProcedureGroups = isOnlyOneItem ? procedureGroups.Except(new[] { ProcedureGroup.Diagnosis }).ToArray() : procedureGroups;
                    if(!isFirstProcedure)
                        procedureGroupIndex = Random.Next(i % (actualProcedureGroups.Length - 1), actualProcedureGroups.Length - 1);
                    ProcedureGroup procedureGroup = actualProcedureGroups[procedureGroupIndex];
                    var durationLimit = new TimeSpan(0, 20, 0);
                    var groupProcedures = Data.Procedures.Where(p => p.Group == procedureGroup && (isOnlyOneItem && p.Duration > durationLimit || !isOnlyOneItem)).ToArray();
                    Procedures[i] = groupProcedures[Random.Next(0, groupProcedures.Length - 1)];
                }
            }
            void EnsureProcedureTooths() {
                ProcedureTooths = new int[ProcedureCount];
                var toothNumbers = Enumerable.Range(1, 32).ToList();
                for(int i = 0; i < ProcedureTooths.Length; i++) {
                    ProcedureTooths[i] = toothNumbers[Random.Next(0, toothNumbers.Count - 1)];
                    toothNumbers.Remove(ProcedureTooths[i]);
                }
            }
        }
        class NoteTemplate {
            public NoteTemplate(string name, string format) : this(name, format, new NoteTemplateItem[0]) {
            }
            public NoteTemplate(string name, string format, NoteTemplateItem[] formatItems) {
                Name = name;
                Format = format;
                Items = formatItems;
            }
            public string Name { get; }
            public string Format { get; }
            public NoteTemplateItem[] Items { get; }
            public string GetRandomNote(Random random) {
                var randomItemValues = new string[Items.Length];
                for(int i = 0; i < Items.Length; i++) {
                    var formatItem = Items[i];
                    int valuesCount = formatItem.Values.Length;
                    if(formatItem.CanCombineValues) {
                        int randomValueCount = random.Next(1, valuesCount);
                        var randomItemValueBuilder = new StringBuilder();
                        List<string> values = formatItem.Values.ToList();
                        for(int j = 0; j < randomValueCount; j++) {
                            int randomValueIndex = random.Next(0, values.Count - 1);
                            randomItemValueBuilder.Append(values[randomValueIndex]);
                            if(j != randomValueCount - 1)
                                randomItemValueBuilder.Append(", ");
                            values.RemoveAt(randomValueIndex);
                        }
                        randomItemValues[i] = randomItemValueBuilder.ToString();
                    }
                    else {
                        int randomValueIndex = random.Next(0, valuesCount - 1);
                        randomItemValues[i] = formatItem.Values[randomValueIndex];
                    }
                }
                return string.Format(Format, randomItemValues);
            }
        }
        class NoteTemplateItem {
            public NoteTemplateItem(string[] values, bool combineValues) {
                Values = values;
                CanCombineValues = combineValues;
            }
            public string[] Values { get; }
            public bool CanCombineValues { get; }
        }
    }
    public class DentalClinicDb {
        public const string DbPath = @"`";
        public DentalClinicDb() {
            string connectionString = $@"XpoProvider=SQLite;Data Source={DbPath}";
            var authentication = new AuthenticationStandard();
            var security = new SecurityStrategyComplex(typeof(PermissionPolicyUser), typeof(PermissionPolicyRole), authentication);
            var objectSpaceProvider = new SecuredObjectSpaceProvider(security, connectionString, null);
            security.RegisterXPOAdapterProviders();
            ObjectSpace = objectSpaceProvider.CreateUpdatingObjectSpace(true);
            Session = (ObjectSpace as XPObjectSpace).Session as UnitOfWork; ;
            Procedures = new XPCollection<Procedure>(Session);
            Appointments = new XPCollection<Appointment>(Session);
            Invoices = new XPCollection<Invoice>(Session);
            Documents = new XPCollection<Document>(Session);
            Doctors = new XPCollection<Doctor>(Session);
            Patients = new XPCollection<Patient>(Session);
            Addresses = new XPCollection<Address>(Session);
            MissingTeeth = new XPCollection<MissingTooth>(Session);
            InvoiceItems = new XPCollection<InvoiceItem>(Session);
            ProcedureItems = new XPCollection<ProcedureItem>(Session);
            Pictures = new XPCollection<Picture>(Session);
            XpoTypesInfoHelper.GetXpoTypeInfoSource();
            XafTypesInfo.Instance.RegisterEntity(typeof(Doctor));
            XafTypesInfo.Instance.RegisterEntity(typeof(PermissionPolicyUser));
            XafTypesInfo.Instance.RegisterEntity(typeof(PermissionPolicyRole));
        }
        public IObjectSpace ObjectSpace { get; set; }
        public XPCollection<Procedure> Procedures { get; set; }
        public XPCollection<Appointment> Appointments { get; set; }
        public XPCollection<Invoice> Invoices { get; set; }
        public XPCollection<Document> Documents { get; set; }
        public XPCollection<Doctor> Doctors { get; set; }
        public XPCollection<Patient> Patients { get; set; }
        public XPCollection<Picture> Pictures { get; set; }
        public XPCollection<Address> Addresses { get; set; }
        public XPCollection<MissingTooth> MissingTeeth { get; set; }
        public XPCollection<InvoiceItem> InvoiceItems { get; set; }
        public XPCollection<ProcedureItem> ProcedureItems { get; set; }
        public UnitOfWork Session { get; set; }
        public void CommitChanges() {
            Session.CommitChanges();
        }
        public void Delete(object obj) {
            Session.Delete(obj as ICollection);
            Session.PurgeDeletedObjects();
            Session.Save(obj);
        }
    }
    public enum NoteType {
        Clinical,
        Complaint,
        Allergy
    }
}
#endif
