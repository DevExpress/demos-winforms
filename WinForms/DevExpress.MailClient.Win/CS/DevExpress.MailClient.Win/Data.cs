using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DevExpress.Utils;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors;
using System.ComponentModel;
using DevExpress.DevAV;
using DevExpress.Internal;
using DevExpress.Utils.Svg;
#if !NET
using System.Data.Entity;
#else
using Microsoft.EntityFrameworkCore;
#endif

namespace DevExpress.MailClient.Win {
    public class Message : INotifyPropertyChanged {
        DataRow row;
        DateTime date;
        bool read, deleted, hasAttachment;
        int priority = 1;
        MailType mailType;
        int mailFolder;
        string from = String.Empty, subject = String.Empty, text = String.Empty, plainText = string.Empty, email = String.Empty;
        public Message() {
            date = DateTime.Now;
        }
        public Message(DataRow row) {
            this.row = row;
            var rnd = DevExpress.Data.Utils.NonCryptographicRandom.Default;
            date = DateTime.Now.AddDays((int)row["Day"]).AddSeconds(-rnd.Next(10000));
            email = string.Format("{0}", row["From"]);
            from = DataHelper.GetNameByEmail(email);
            subject = string.Format("{0}", row["Subject"]);
            read = Delay > TimeSpan.FromHours(48);
            text = string.Format("{0}", row["Text"]);
            deleted = false;
            mailType = MailType.Inbox;
            mailFolder = (int)GetFolder(row);
            DataTweaking();
        }
        public string FullName {
            get {
                if(string.IsNullOrEmpty(email))
                    return from;
                return string.Format("{0} ({1})", from, email);
            }
        }
        public DateTime Date { get { return date; } set { date = value; } }
        public string From { get { return from; } set { from = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public string SubjectDisplayText { get { return Subject; } }
        public int Attachment { get { return hasAttachment ? 1 : 0; } }
        public int Read { get { return read ? 1 : 0; } }
        public int Priority { get { return priority; } set { priority = value; } }
        public bool IsUnread { get { return !read; } }
        internal string Folder { get { return string.Format("{0}", mailFolder); } }
        public string Text { get { return text; } set { text = value; } }
        public string PlainText { get { return GetPlainText(); } }

        string GetPlainText() {
            if(string.IsNullOrEmpty(plainText)) {
                plainText = ObjectHelper.GetPlainTextFromMHT(text).Replace("\r\n", " ");
            }
            return plainText;
        }
        public MailType MailType { get { return mailType; } set { mailType = value; } }
        public int MailFolder {
            get { return mailFolder; }
            set {
                if(MailFolder == value) return;
                mailFolder = value;
                OnPropertyChanged("MailFolder");
            }
        }
        public bool Deleted {
            get { return deleted; }
            set { deleted = value; }
        }
        internal TimeSpan Delay {
            get { return DateTime.Now - date; }
        }
        public void ToggleRead() {
            read = !read;
        }
        void DataTweaking() {
            if(Delay > TimeSpan.FromHours(50) && Delay < TimeSpan.FromHours(100)) read = false;
            if(subject.IndexOf("RE:") >= 0 || subject.IndexOf("FW:") >= 0) read = false;
            this.hasAttachment = text.Length > 20000;
            if(subject.IndexOf("Review") >= 0 || subject.IndexOf("Important") >= 0) priority = 2;
            if(subject.IndexOf("FW:") >= 0 && Delay > TimeSpan.FromHours(48)) priority = 0;
            if(subject.IndexOf("New") >= 0 || subject.IndexOf("Meeting") >= 0)
                mailFolder += 1;
        }
        MailFolder GetFolder(DataRow row) {
            object category = row["CategoryID"];
            string ret = string.Format("{0}", (Categories)(category == DBNull.Value ? 1 : (int)category));
            if(string.IsNullOrEmpty(ret)) return DevExpress.MailClient.Win.MailFolder.All;
            return (MailFolder)Enum.Parse(typeof(MailFolder), ret.Replace(" ", ""));
        }
        public void SetPlainText(string text) { plainText = text; }

        #region INotifyPropertyChanged Members
        PropertyChangedEventHandler propertyChanged;
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged {
            add { propertyChanged += value; }
            remove { propertyChanged -= value; }
        }
        protected void OnPropertyChanged(string name) {
            if(propertyChanged != null) propertyChanged(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
    public class Task : IDXDataErrorInfo {
        int priority = 1;
        int percentComplete = 0;
        DateTime createdDate;
        DateTime? startDate = null, dueDate = null, completedDate = null;
        string subject, description;
        TaskStatus status = TaskStatus.NotStarted;
        TaskCategory category;
        Contact assignTo = null;
        public Task(string subject, TaskCategory category)
            : this(subject, category, DateTime.Now) {
        }
        internal Task(string subject, TaskCategory category, DateTime date) {
            this.subject = subject;
            this.category = category;
            this.createdDate = date;
        }
        public int Priority { get { return priority; } set { priority = value; } }
        public int PercentComplete {
            get { return percentComplete; }
            set {
                if(value < 0) value = 0;
                if(value > 100) value = 100;
                if(percentComplete == value) return;
                percentComplete = value;
                if(percentComplete == 100) Status = TaskStatus.Completed;
                if(percentComplete > 0 && percentComplete < 100) Status = TaskStatus.InProgress;
            }
        }
        public DateTime CreatedDate { get { return createdDate; } }
        public DateTime? StartDate { get { return startDate; } set { startDate = value; } }
        public DateTime? DueDate { get { return dueDate; } set { dueDate = value; } }
        public DateTime? CompletedDate { get { return completedDate; } set { completedDate = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public string Description { get { return description; } set { description = value; } }
        public TaskCategory Category { get { return category; } set { category = value; } }
        public TaskStatus Status {
            get { return status; }
            set {
                status = value;
                if(status == TaskStatus.Completed) {
                    PercentComplete = 100;
                    CompletedDate = DateTime.Now;
                }
                else
                    CompletedDate = null;
                if(status == TaskStatus.NotStarted)
                    PercentComplete = 0;
                if(status == TaskStatus.InProgress && PercentComplete == 100)
                    PercentComplete = 75;
                if(status == TaskStatus.Deferred || status == TaskStatus.WaitingOnSomeoneElse)
                    DueDate = null;
            }
        }
        public Contact AssignTo { get { return assignTo; } set { assignTo = value; } }
        internal TimeSpan TimeDiff { get { return (DateTime.Now - CreatedDate); } }
        public bool Overdue {
            get {
                if(Status == TaskStatus.Completed || !DueDate.HasValue) return false;
                DateTime dDate = DueDate.Value.Date.AddDays(1);
                if(DateTime.Now >= dDate) return true;
                return false;
            }
        }
        public bool Complete {
            get { return Status == TaskStatus.Completed; }
            set {
                if(value)
                    Status = TaskStatus.Completed;
                else Status = TaskStatus.NotStarted;
            }
        }
        public int Icon { get { return Complete ? 0 : 1; } }
        public FlagStatus FlagStatus {
            get {
                DateTime today = DateTime.Today;
                if(Complete) return FlagStatus.Completed;
                if(!DueDate.HasValue) return FlagStatus.NoDate;
                if(DueDate.Value.Date.Equals(today)) return FlagStatus.Today;
                if(DueDate.Value.Date.Equals(today.AddDays(1))) return FlagStatus.Tomorrow;
                DateTime thisWeekStart = DevExpress.Data.Filtering.Helpers.EvalHelpers.GetWeekStart(today);
                if(DueDate.Value.Date >= thisWeekStart && DueDate.Value.Date < thisWeekStart.AddDays(7)) return FlagStatus.ThisWeek;
                if(DueDate.Value.Date >= thisWeekStart.AddDays(7) && DueDate.Value.Date < thisWeekStart.AddDays(14)) return FlagStatus.NextWeek;
                return FlagStatus.Custom;
            }
        }
        public void Assign(Task task) {
            this.subject = task.Subject;
            this.priority = task.Priority;
            this.percentComplete = task.PercentComplete;
            this.createdDate = task.CreatedDate;
            this.startDate = task.StartDate;
            this.dueDate = task.DueDate;
            this.completedDate = task.CompletedDate;
            this.description = task.Description;
            this.category = task.Category;
            this.status = task.Status;
            this.assignTo = task.AssignTo;
        }
        public Task Clone() {
            Task task = new Task(this.Subject, this.Category);
            task.Assign(this);
            return task;
        }
        public string DueIn {
            get {
                if(DueDate.HasValue) {
                    int oDays = (DateTime.Today - DueDate.Value).Days;
                    return oDays > 0 ? string.Format("{0} day{1} overdue", oDays, oDays > 1 ? "s" : string.Empty) : string.Empty;
                }
                return string.Empty;
            }
        }
        #region IDXDataErrorInfo Members
        public void GetError(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info) { }

        public void GetPropertyError(string propertyName, DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info) {
            if(propertyName == "DueDate") {
                if((DueDate.HasValue && StartDate.HasValue) && DueDate < StartDate)
                    SetErrorInfo(info, Properties.Resources.DueDateError, ErrorType.Critical);
                if(!DueDate.HasValue && Status == TaskStatus.InProgress)
                    SetErrorInfo(info, Properties.Resources.DueDateWarning, ErrorType.Warning);
            }
        }
        void SetErrorInfo(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info, string errorText, ErrorType errorType) {
            info.ErrorText = errorText;
            info.ErrorType = errorType;
        }
        #endregion
    }
    public class Contact : IComparable {
        Image photo;
        FullName name;
        string email, phone, note, fullname;
        DateTime? birthDate;
        Address address;
        public Contact() {
            name = new FullName(PersonPrefix.Mr, Properties.Resources.NewFirstName, string.Empty, Properties.Resources.NewLastName);
            address = new Address();
        }
        public Contact(Contact contact) {
            name = new FullName();
            address = new Address();
            this.Assign(contact);
        }
        public Contact(Employee employee) {
            photo = employee.Photo;
            name = new FullName(employee.Prefix, employee.FirstName, string.Empty, employee.LastName);
            fullname = employee.FullName;
            email = employee.Email;
            birthDate = employee.BirthDate;
            phone = employee.MobilePhone;
            address = new Address(employee.Address.ToString());
        }
        public string Name { get { return name.ToString(); } }
        public string EmployeeName { get { return fullname; } }
        public string FirstName { get { return name.FirstName; } }
        public string MiddleName { get { return name.MiddleName; } }
        public string LastName { get { return name.LastName; } }
        public string Email { get { return email; } set { email = value; } }
        public DateTime? BirthDate { get { return birthDate; } }
        readonly DateTime DefaultBirthDate = new DateTime(1970, 1, 1);
        public DateTime BindingBirthDate {
            get {
                if(BirthDate.HasValue)
                    return BirthDate.Value;
                return DefaultBirthDate;
            }
            set { birthDate = value; }
        }
        public PersonPrefix Title { get { return name.Title; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string State { get { return address.State; } }
        public string City { get { return address.City; } }
        public string Zip { get { return address.Zip; } }
        public string AddressLine { get { return address.AddressLine; } }
        public Address Address { get { return address; } }
        public FullName FullName { get { return name; } }
        public Image Photo { get { return photo; } set { photo = value; } }
        public string Note { get { return note; } set { note = value; } }
        public string GetContactInfoHtml() {
            string ret = string.Format("<size=+2><b>{0}</b><size=-2>", Name);
            ret += "<br>";
            if(BirthDate != null && BirthDate != DateTime.MinValue) ret += string.Format(Properties.Resources.BirthDateHtml, BirthDate);
            if(!string.IsNullOrEmpty(Email)) ret += string.Format(Properties.Resources.EmailHtml, Email);
            if(!string.IsNullOrEmpty(Phone)) ret += string.Format(Properties.Resources.PhoneHtml, Phone);
            ret += string.Format(Properties.Resources.AddressHtml, Address);

            return ret;
        }
        public override string ToString() { return Name; }
        public SvgImage Icon {
            get {
                switch(name.Title) {
                    case PersonPrefix.Dr:
                        return Properties.Resources.Doctor1;
                    case PersonPrefix.Ms:
                        return Properties.Resources.Ms1;
                    case PersonPrefix.Miss:
                        return Properties.Resources.Miss1;
                    case PersonPrefix.Mrs:
                        return Properties.Resources.Mrs1;
                }
                return Properties.Resources.Mr1;
            }
        }
        public void Assign(Contact contact) {
            this.photo = contact.Photo;
            this.name.Assign(contact.FullName);
            this.address.Assign(contact.Address);
            this.email = contact.Email;
            this.birthDate = contact.BirthDate;
            this.phone = contact.Phone;
            this.note = contact.Note;
        }
        public Contact Clone() {
            return new Contact(this);
        }
        #region IComparable Members

        public int CompareTo(object obj) {
            return Comparer<string>.Default.Compare(Name, obj.ToString());
        }

        #endregion
    }

    public class UnknownContact : Contact {
        public UnknownContact(string email) {
            Email = email;
        }
        public override string ToString() {
            return Email;
        }
    }

    public class FullName {
        PersonPrefix title;
        string first, middle, last;
        public FullName() : this(PersonPrefix.Mr, string.Empty, string.Empty, string.Empty) { }
        public FullName(PersonPrefix title, string first, string middle, string last) {
            this.title = title;
            this.first = first;
            this.middle = middle;
            this.last = last;
        }
        public PersonPrefix Title { get { return title; } set { title = value; } }
        public string FirstName { get { return first; } set { first = value; } }
        public string MiddleName { get { return middle; } set { middle = value; } }
        public string LastName { get { return last; } set { last = value; } }
        public override string ToString() {
            return string.Format("{1}{2}{3}", GetFormatString(EditorHelper.GetTitleNameByContactTitle(Title)),
                GetFormatString(FirstName), GetFormatString(MiddleName), LastName);
        }
        string GetFormatString(string name) {
            if(string.IsNullOrEmpty(name)) return string.Empty;
            return string.Format("{0} ", name);
        }
        public void Assign(FullName name) {
            this.title = name.Title;
            this.first = name.FirstName;
            this.middle = name.MiddleName;
            this.last = name.LastName;
        }
    }
    public class Address {
        string address, city = string.Empty, state = string.Empty, zip;
        public Address() : this(string.Empty) { }
        public Address(string address, string city, string state, string zip) {
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }
        internal Address(string addressString) {
            if(string.IsNullOrEmpty(addressString)) return;
            try {
                string[] lines = addressString.Split(',');
                this.address = lines[0].Trim();
                this.city = lines[1].Trim();
                this.state = lines[2].Trim().Substring(0, 2);
                string temp = lines[2].Trim();
                this.zip = temp.Substring(3, temp.Length - 3);
            }
            catch { }
        }
        public string AddressLine { get { return address; } set { address = value; } }
        public string State { get { return state; } set { state = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Zip { get { return zip; } set { zip = value; } }
        public override string ToString() {
            return string.Format("{0}{1}{2}{3}", GetFormatString(AddressLine), GetFormatString(City), GetFormatString(State), Zip);
        }
        string GetFormatString(string name) {
            if(string.IsNullOrEmpty(name)) return string.Empty;
            return string.Format("{0}, ", name);
        }
        public void Assign(Address address) {
            this.address = address.AddressLine;
            this.state = address.State;
            this.city = address.City;
            this.zip = address.Zip;
        }
    }
    public class FeedItem {
        public FeedItem() { }
        public string ID { get; set; }
        public DateTime Date { get; set; }
        public string From { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
    public class DataHelper {
        internal static bool ShowAllMessageCount = false;
        internal static bool ShowUnreadMessageCount = true;
        static List<Message> messages = null;
        static List<Contact> contacts = null;
        static List<Task> tasks = null;
        static BindingList<Employee> employees = null;
        internal static DateTime CalendarDate = DateTime.Today;
        internal static string[] ApplicationArguments;

        static DataTable calendarResourcesTable;
        static DataTable calendarAppointmentsTable;

        internal static DataTable MailTable {
            get {
                string table = "Messages";
                DataTable messages = CreateDataTable(table);
                return messages;
            }
        }
        internal static BindingList<Employee> Employees {
            get {
                if(employees == null) {
#if !NET
                    DevAVDb devAvDb = new DevAVDb();
#else
                    DevAVDb devAvDb = new DevAVDb($"Data Source={DevAVDataDirectoryHelper.GetFile("devav.sqlite3")}");
#endif
                    devAvDb.Employees.Load();
                    employees = devAvDb.Employees.Local.ToBindingList();
                }
                return employees;
            }
        }
        public static string GetNameByEmail(string email) {
            Employee employee = Employees.FirstOrDefault(p => p.Email == email);
            return (employee != null) ? employee.FullName : string.Empty;
        }
        public static Image GetPhotoByEmail(string email) {
            Employee employee = Employees.FirstOrDefault(p => p.Email == email);
            return (employee != null && employee.Picture != null) ? employee.Photo : null;
        }
        public static List<Message> Messages {
            get {
                try {
                    if(messages == null) {
                        messages = new List<Message>();
                        DataTable tbl = MailTable;
                        if(tbl != null) {
                            foreach(DataRow row in tbl.Rows)
                                messages.Add(new Message(row));
                        }
                        messages.Add(CreateMessageAbout());
                    }
                }
                catch(Exception e) {
                    XtraMessageBox.Show(e.Message, e.Source);
                    messages = new List<Message>();
                    messages.Add(CreateMessageAbout());
                }
                return messages;
            }
        }
        public static List<Contact> Contacts {
            get {
                if(contacts == null)
                    contacts = GetContacts();
                return contacts;
            }
        }
        public static List<Task> Tasks {
            get {
                if(tasks == null)
                    tasks = GenerateTasks();
                return tasks;
            }
        }
        static List<Task> GenerateTasks() {
            List<Task> ret = new List<Task>();
            for(int i = 0; i < TaskGenerator.CustomerCount; i++)
                foreach(string s in CollectionResources.OfficeTasks)
                    ret.Add(TaskGenerator.CreateTask(s, TaskCategory.Office));
            foreach(string s in CollectionResources.HouseTasks)
                ret.Add(TaskGenerator.CreateTask(s, TaskCategory.HouseChores));
            foreach(string s in CollectionResources.ShoppingTasks)
                ret.Add(TaskGenerator.CreateTask(s, TaskCategory.Shopping));
            return ret;
        }
        internal static List<Contact> GetContacts() {
            List<Contact> ret = new List<Contact>();
            foreach(Employee emp in Employees)
                ret.Add(new Contact(emp));
            return ret;
        }
        internal static Contact FindByName(string name) {
            if(string.IsNullOrEmpty(name)) return null;
            return Contacts.FirstOrDefault(p => p.Name == name || p.EmployeeName == name);
        }
        static Message CreateMessageAbout() {
            Message ret = new Message();
            ret.Subject = Properties.Resources.AboutSubj;
            ret.From = Properties.Resources.AboutFrom;
            ret.Priority = 2;
            ret.Text = ObjectHelper.GetMHTTextFromHTML(StringResources.Get("AboutMessage"));
            ret.SetPlainText(StringResources.Get("AboutMessagePlain"));
            ret.MailFolder = (int)MailFolder.Announcements;
            return ret;
        }
        internal static DataTable CalendarResources {
            get {
                if(calendarResourcesTable == null) {
                    string table = "Resources";
                    calendarResourcesTable = CreateDataTable(table);
                }
                return calendarResourcesTable;
            }
        }
        internal static DataTable CalendarAppointments {
            get {
                if(calendarAppointmentsTable == null) {
                    string table = "Appointments";
                    calendarAppointmentsTable = CreateDataTable(table);
                }
                return calendarAppointmentsTable;
            }
        }
        static DataTable CreateDataTable(string table) {
            DataSet dataSet = new DataSet();
            string dataFile = DevAVDataDirectoryHelper.GetFile("MailDevAv.xml");
            if(dataFile != string.Empty) {
                FileInfo fi = new FileInfo(dataFile);
                dataSet.ReadXml(fi.FullName);
                return dataSet.Tables[table];
            }
            return null;
        }
    }
    //
    internal class TaskGenerator {
        public static int CustomerCount = 10;
        static List<Contact> customers;
        internal static List<Contact> Customers {
            get {
                if(customers == null) {
                    customers = new List<Contact>();
                    List<Contact> temp = DataHelper.GetContacts();
                    if(temp.Count > CustomerCount) {
                        var rnd = DevExpress.Data.Utils.NonCryptographicRandom.Default;
                        while(customers.Count < CustomerCount) {
                            Contact contact = GetCustomer(rnd.Next(temp.Count - 1), customers, temp);
                            if(contact != null)
                                customers.Add(contact);
                        }
                    }
                }
                return customers;
            }
        }
        static Contact GetCustomer(int index, List<Contact> customers, List<Contact> contacts) {
            Contact contact = contacts[index];
            foreach(Contact c in customers)
                if(ReferenceEquals(c, contact)) return null;
            return contact;
        }
        public static Task CreateTask(string subject, TaskCategory category) {
            var rnd = DevExpress.Data.Utils.NonCryptographicRandom.Default;
            Task task = new Task(subject, category, DateTime.Now.AddHours(-rnd.Next(96)));
            int rndStatus = rnd.Next(10);
            if(task.TimeDiff.TotalHours > 12) {
                if(task.TimeDiff.TotalHours > 80) {
                    task.Status = TaskStatus.Completed;

                }
                else {
                    task.Status = TaskStatus.InProgress;
                    task.PercentComplete = rnd.Next(9) * 10;
                }
                task.StartDate = task.CreatedDate.AddMinutes(rnd.Next(720)).Date;
            }
            if(rndStatus != 5) task.DueDate = task.CreatedDate.AddHours((90 - rndStatus * 9) + 24).Date;
            if(rndStatus > 8) task.Priority = 2;
            if(rndStatus < 3) task.Priority = 0;
            if(rndStatus == 6 && task.Status == TaskStatus.InProgress) task.Status = TaskStatus.Deferred;
            if(rndStatus == 4 && task.Status == TaskStatus.InProgress && task.PercentComplete < 40) task.Status = TaskStatus.WaitingOnSomeoneElse;
            if(task.Category == TaskCategory.Office && rndStatus != 7 && Customers.Count > 0)
                task.AssignTo = Customers[rnd.Next(Customers.Count)];
            if(task.Status == TaskStatus.Completed) {
                if(!task.StartDate.HasValue) task.StartDate = task.CreatedDate.AddHours(12).Date;
                task.CompletedDate = task.StartDate.Value.AddHours(rnd.Next(48) + 24);
            }
            return task;
        }
    }
    public class LayoutOption {
        public static bool TaskCollapsed = false;
        public static bool MailCollapsed = false;
    }
}
