using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.MailDemo.Win;
using DevExpress.ProductsDemo.Win;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors.DXErrorProvider;

namespace DevExpress.MailClient.Win {
    public class Task : IDXDataErrorInfo {
        int _priority = 1;
        int _percentComplete = 0;
        DateTime _createdDate;
        DateTime? _startDate = null, _dueDate = null, _completedDate = null;
        string _subject, _description;
        TaskStatus _status = TaskStatus.NotStarted;
        TaskCategory _category;
        Contact _assignTo = null;
        public Task(string subject, TaskCategory category)
            : this(subject, category, TutorialConstants.Now) {
        }
        internal Task(string subject, TaskCategory category, DateTime date) {
            this._subject = subject;
            this._category = category;
            this._createdDate = date;
        }
        public int Priority { get { return _priority; } set { _priority = value; } }
        public int PercentComplete {
            get { return _percentComplete; }
            set {
                if(value < 0)
                    value = 0;
                if(value > 100)
                    value = 100;
                if(_percentComplete == value)
                    return;
                _percentComplete = value;
                if(_percentComplete == 100)
                    Status = TaskStatus.Completed;
                if(_percentComplete > 0 && _percentComplete < 100)
                    Status = TaskStatus.InProgress;
            }
        }
        public DateTime CreatedDate { get { return _createdDate; } }
        public DateTime? StartDate { get { return _startDate; } set { _startDate = value; } }
        public DateTime? DueDate { get { return _dueDate; } set { _dueDate = value; } }
        public DateTime? CompletedDate { get { return _completedDate; } set { _completedDate = value; } }
        public string Subject { get { return _subject; } set { _subject = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public TaskCategory Category { get { return _category; } set { _category = value; } }
        public TaskStatus Status {
            get { return _status; }
            set {
                _status = value;
                if(_status == TaskStatus.Completed) {
                    PercentComplete = 100;
                    CompletedDate = TutorialConstants.Now;
                }
                else
                    CompletedDate = null;
                if(_status == TaskStatus.NotStarted)
                    PercentComplete = 0;
                if(_status == TaskStatus.InProgress && PercentComplete == 100)
                    PercentComplete = 75;
                if(_status == TaskStatus.Deferred || _status == TaskStatus.WaitingOnSomeoneElse)
                    DueDate = null;
            }
        }
        public Contact AssignTo { get { return _assignTo; } set { _assignTo = value; } }
        internal TimeSpan TimeDiff { get { return (TutorialConstants.Now - CreatedDate); } }
        public bool Overdue {
            get {
                if(Status == TaskStatus.Completed || !DueDate.HasValue)
                    return false;
                DateTime dDate = DueDate.Value.Date.AddDays(1);
                if(TutorialConstants.Now >= dDate)
                    return true;
                return false;
            }
        }
        public bool Complete {
            get { return Status == TaskStatus.Completed; }
            set {
                if(value)
                    Status = TaskStatus.Completed;
                else
                    Status = TaskStatus.NotStarted;
            }
        }
        public int Icon { get { return Complete ? 0 : 1; } }
        public FlagStatus FlagStatus {
            get {
                DateTime today = TutorialConstants.Today;
                if(Complete)
                    return FlagStatus.Completed;
                if(!DueDate.HasValue)
                    return FlagStatus.NoDate;
                if(DueDate.Value.Date.Equals(today))
                    return FlagStatus.Today;
                if(DueDate.Value.Date.Equals(today.AddDays(1)))
                    return FlagStatus.Tomorrow;
                DateTime thisWeekStart = DevExpress.Data.Filtering.Helpers.EvalHelpers.GetWeekStart(today);
                if(DueDate.Value.Date >= thisWeekStart && DueDate.Value.Date < thisWeekStart.AddDays(7))
                    return FlagStatus.ThisWeek;
                if(DueDate.Value.Date >= thisWeekStart.AddDays(7) && DueDate.Value.Date < thisWeekStart.AddDays(14))
                    return FlagStatus.NextWeek;
                return FlagStatus.Custom;
            }
        }
        public void Assign(Task task) {
            this._subject = task.Subject;
            this._priority = task.Priority;
            this._percentComplete = task.PercentComplete;
            this._createdDate = task.CreatedDate;
            this._startDate = task.StartDate;
            this._dueDate = task.DueDate;
            this._completedDate = task.CompletedDate;
            this._description = task.Description;
            this._category = task.Category;
            this._status = task.Status;
            this._assignTo = task.AssignTo;
        }
        public Task Clone() {
            Task task = new Task(this.Subject, this.Category);
            task.Assign(this);
            return task;
        }
        public string DueIn {
            get {
                if(DueDate.HasValue) {
                    int oDays = (TutorialConstants.Today - DueDate.Value).Days;
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
                    SetErrorInfo(info, DevExpress.ProductsDemo.Win.Properties.Resources.DueDateError, ErrorType.Critical);
                if(!DueDate.HasValue && Status == TaskStatus.InProgress)
                    SetErrorInfo(info, DevExpress.ProductsDemo.Win.Properties.Resources.DueDateWarning, ErrorType.Warning);
            }
        }
        void SetErrorInfo(DevExpress.XtraEditors.DXErrorProvider.ErrorInfo info, string errorText, ErrorType errorType) {
            info.ErrorText = errorText;
            info.ErrorType = errorType;
        }
        #endregion
    }
    public class Contact : IComparable {
        DataRow _customer, _person;
        Image _photo;
        FullName _name;
        string _email, _phone, _note;
        ContactGender _gender;
        DateTime? _birthDate;
        Address _address;
        bool _hasPhoto = false;
        public Contact() {
            _name = new FullName(DevExpress.ProductsDemo.Win.Properties.Resources.NewFirstName, string.Empty, DevExpress.ProductsDemo.Win.Properties.Resources.NewLastName);
            _address = new Address();
        }
        public Contact(Contact contact) {
            _name = new FullName();
            _address = new Address();
            this.Assign(contact);
        }
        public Contact(DataRow customer, DataRow person) {
            this._customer = customer;
            this._person = person;
            if(!(customer["Photo"] is DBNull)) {
                _photo = XtraEditors.Controls.ByteImageConverter.FromByteArray((byte[])customer["Photo"]);
                _hasPhoto = true;
            }
            else
                _photo = global::DevExpress.ProductsDemo.Win.Properties.Resources.Unknown_user;
            _name = new FullName(string.Format("{0}", person["FirstName"]), string.Format("{0}", customer["MiddleName"]), string.Format("{0}", person["LastName"]));
            _email = string.Format("{0}", customer["Email"]).Replace("dxvideorent.com", "dxmail.net");
            _gender = (ContactGender)person["Gender"];
            _birthDate = (DateTime?)person["BirthDate"];
            _phone = string.Format("{0}", customer["Phone"]);
            _address = new Address(string.Format("{0}", customer["Address"]));
        }
        public string Name { get { return _name.ToString(); } }
        public string FirstName { get { return _name.FirstName; } }
        public string MiddleName { get { return _name.MiddleName; } }
        public string LastName { get { return _name.LastName; } }
        public string Email { get { return _email; } set { _email = value; } }
        public ContactGender Gender { get { return _gender; } set { _gender = value; } }
        public DateTime? BirthDate { get { return _birthDate; } }
        public DateTime BindingBirthDate {
            get {
                if(BirthDate.HasValue)
                    return BirthDate.Value;
                return DateTime.MinValue;
            }
            set {
                _birthDate = value;
            }
        }
        public string Phone { get { return _phone; } set { _phone = value; } }
        public string State { get { return _address.State; } }
        public string City { get { return _address.City; } }
        public string Zip { get { return _address.Zip; } }
        public string AddressLine { get { return _address.AddressLine; } }
        public Address Address { get { return _address; } }
        public FullName FullName { get { return _name; } }
        public Image Photo { get { return _photo; } set { _photo = value; } }
        public string Note { get { return _note; } set { _note = value; } }
        public string GetContactInfoHtml() {
            string ret = string.Format("<size=+2><b>{0}</b><size=-2>", Name);
            ret += "<br>";
            if(BirthDate != null && BirthDate != DateTime.MinValue)
                ret += string.Format(DevExpress.ProductsDemo.Win.Properties.Resources.BirthDateHtml, BirthDate);
            if(!string.IsNullOrEmpty(Email))
                ret += string.Format(DevExpress.ProductsDemo.Win.Properties.Resources.EmailHtml, Email);
            if(!string.IsNullOrEmpty(Phone))
                ret += string.Format(DevExpress.ProductsDemo.Win.Properties.Resources.PhoneHtml, Phone);
            ret += string.Format(DevExpress.ProductsDemo.Win.Properties.Resources.AddressHtml, Address);

            return ret;
        }
        public override string ToString() { return Name; }
        public Image Icon {
            get {
                ContactTitle title = _name.Title;
                if(title == ContactTitle.None && _gender == ContactGender.Female)
                    title = ContactTitle.Mrs;
                switch(title) {
                    case ContactTitle.Dr:
                        return global::DevExpress.ProductsDemo.Win.Properties.Resources.Doctor;
                    case ContactTitle.Miss:
                        return global::DevExpress.ProductsDemo.Win.Properties.Resources.Miss;
                    case ContactTitle.Mrs:
                        return global::DevExpress.ProductsDemo.Win.Properties.Resources.Mrs;
                    case ContactTitle.Ms:
                        return global::DevExpress.ProductsDemo.Win.Properties.Resources.Ms;
                    case ContactTitle.Prof:
                        return global::DevExpress.ProductsDemo.Win.Properties.Resources.Professor;
                }
                return global::DevExpress.ProductsDemo.Win.Properties.Resources.Mr;
            }
        }
        public SvgImage SvgIcon {
            get {
                ContactTitle title = _name.Title;
                if(title == ContactTitle.None && _gender == ContactGender.Female)
                    title = ContactTitle.Mrs;
                switch(title) {
                    case ContactTitle.Dr:
                        return global::DevExpress.ProductsDemo.Win.Properties.Resources.Doctor1;
                    case ContactTitle.Miss:
                        return global::DevExpress.ProductsDemo.Win.Properties.Resources.Miss1;
                    case ContactTitle.Mrs:
                        return global::DevExpress.ProductsDemo.Win.Properties.Resources.Mrs1;
                    case ContactTitle.Ms:
                        return global::DevExpress.ProductsDemo.Win.Properties.Resources.Ms1;
                    case ContactTitle.Prof:
                        return global::DevExpress.ProductsDemo.Win.Properties.Resources.Professor1;
                }
                return global::DevExpress.ProductsDemo.Win.Properties.Resources.Mr1;
            }
        }
        internal bool HasPhoto { get { return _hasPhoto; } }
        public void Assign(Contact contact) {
            this._photo = contact.Photo;
            this._name.Assign(contact.FullName);
            this._address.Assign(contact.Address);
            this._email = contact.Email;
            this._gender = contact.Gender;
            this._birthDate = contact.BirthDate;
            this._phone = contact.Phone;
            this._note = contact.Note;
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
    public class FullName {
        ContactTitle _title;
        string first, middle, last;
        public FullName() : this(string.Empty, string.Empty, string.Empty) { }
        public FullName(string first, string middle, string last) : this(ContactTitle.None, first, middle, last) { }
        public FullName(ContactTitle title, string first, string middle, string last) {
            this._title = title;
            this.first = first;
            this.middle = middle;
            this.last = last;
        }
        public ContactTitle Title { get { return _title; } set { _title = value; } }
        public string FirstName { get { return first; } set { first = value; } }
        public string MiddleName { get { return middle; } set { middle = value; } }
        public string LastName { get { return last; } set { last = value; } }
        public override string ToString() {
            return string.Format("{0}{1}{2}{3}", GetFormatString(EditorHelper.GetTitleNameByContactTitle(Title)),
                GetFormatString(FirstName), GetFormatString(MiddleName), LastName);
        }
        string GetFormatString(string name) {
            if(string.IsNullOrEmpty(name))
                return string.Empty;
            return string.Format("{0} ", name);
        }
        public void Assign(FullName name) {
            this._title = name.Title;
            this.first = name.FirstName;
            this.middle = name.MiddleName;
            this.last = name.LastName;
        }
    }
    public class Address {
        string _address, _city = string.Empty, _state = string.Empty, _zip;
        public Address() : this(string.Empty) { }
        public Address(string address, string city, string state, string zip) {
            this._address = address;
            this._city = city;
            this._state = state;
            this._zip = zip;
        }
        internal Address(string addressString) {
            if(string.IsNullOrEmpty(addressString))
                return;
            try {
                string[] lines = addressString.Split(',');
                this._address = lines[0].Trim();
                this._city = lines[1].Trim();
                this._state = lines[2].Trim().Substring(0, 2);
                string temp = lines[2].Trim();
                this._zip = temp.Substring(3, temp.Length - 3);
            }
            catch { }
        }
        public string AddressLine { get { return _address; } set { _address = value; } }
        public string State { get { return _state; } set { _state = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public string Zip { get { return _zip; } set { _zip = value; } }
        public override string ToString() {
            return string.Format("{0}{1}{2}{3}", GetFormatString(AddressLine), GetFormatString(City), GetFormatString(State), Zip);
        }
        string GetFormatString(string name) {
            if(string.IsNullOrEmpty(name))
                return string.Empty;
            return string.Format("{0}, ", name);
        }
        public void Assign(Address address) {
            this._address = address.AddressLine;
            this._state = address.State;
            this._city = address.City;
            this._zip = address.Zip;
        }
    }
    public class DataHelper {
        static List<Contact> _contacts = null;
        static List<Task> _tasks = null;
        internal static string[] ApplicationArguments;
        static DataTable calendarResourcesTable;
        static DataTable calendarAppointmentsTable;

        public static List<Contact> Contacts {
            get {
                if(_contacts == null)
                    _contacts = GetContacts();
                return _contacts;
            }
        }
        public static List<Task> Tasks {
            get {
                if(_tasks == null)
                    _tasks = GenerateTasks();
                return _tasks;
            }
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
            DataSet dataSet = GetDataSet("VideoRent.xml");
            if(dataSet == null)
                return ret;
            DataTable tbl = dataSet.Relations["FK_CustomerOidOidPerson"].ChildTable;
            for(int i = 0; i < tbl.Rows.Count; i++)
                ret.Add(new Contact(tbl.Rows[i], tbl.Rows[i].GetParentRow("FK_CustomerOidOidPerson")));
            return ret;
        }
        static DataTable CreateDataTable(string table) {
            DataSet dataSet = GetDataSet("MailDevAv.xml");
            return (dataSet != null) ? dataSet.Tables[table] : null;
        }
        static readonly Dictionary<string, DataSet> dataSets = new Dictionary<string, DataSet>();
        static DataSet GetDataSet(string name) {
            string dataFile = DataDirectoryHelper.GetDataFile(name);
            DataSet result = null;
            if(!string.IsNullOrEmpty(dataFile) && !dataSets.TryGetValue(dataFile, out result)) {
                result = new DataSet(name);
                result.ReadXml(dataFile);
                dataSets.Add(dataFile, result);
            }
            return result;
        }
    }
    internal class TaskGenerator {
        public static int CustomerCount = 10;
        static List<Contact> _customers;
        internal static List<Contact> Customers {
            get {
                if(_customers == null) {
                    _customers = new List<Contact>();
                    List<Contact> temp = DataHelper.GetContacts();
                    if(temp.Count > CustomerCount) {
                        while(_customers.Count < CustomerCount) {
                            Contact contact = GetCustomer(TutorialConstants.Random.Next(temp.Count - 1), _customers, temp);
                            if(contact != null)
                                _customers.Add(contact);
                        }
                    }
                }
                return _customers;
            }
        }
        static Contact GetCustomer(int index, List<Contact> customers, List<Contact> contacts) {
            Contact contact = contacts[index];
            if(!contact.HasPhoto)
                return null;
            foreach(Contact c in customers)
                if(ReferenceEquals(c, contact))
                    return null;
            return contact;
        }
        public static Task CreateTask(string subject, TaskCategory category) {
            Task task = new Task(subject, category, TutorialConstants.Now.AddHours(-TutorialConstants.Random.Next(96)));
            int rndStatus = TutorialConstants.Random.Next(10);
            if(task.TimeDiff.TotalHours > 12) {
                if(task.TimeDiff.TotalHours > 80) {
                    task.Status = TaskStatus.Completed;

                }
                else {
                    task.Status = TaskStatus.InProgress;
                    task.PercentComplete = TutorialConstants.Random.Next(9) * 10;
                }
                task.StartDate = task.CreatedDate.AddMinutes(TutorialConstants.Random.Next(720)).Date;
            }
            if(rndStatus != 5)
                task.DueDate = task.CreatedDate.AddHours((90 - rndStatus * 9) + 24).Date;
            if(rndStatus > 8)
                task.Priority = 2;
            if(rndStatus < 3)
                task.Priority = 0;
            if(rndStatus == 6 && task.Status == TaskStatus.InProgress)
                task.Status = TaskStatus.Deferred;
            if(rndStatus == 4 && task.Status == TaskStatus.InProgress && task.PercentComplete < 40)
                task.Status = TaskStatus.WaitingOnSomeoneElse;
            if(task.Category == TaskCategory.Office && rndStatus != 7 && Customers.Count > 0)
                task.AssignTo = Customers[TutorialConstants.Random.Next(Customers.Count)];
            if(task.Status == TaskStatus.Completed) {
                if(!task.StartDate.HasValue)
                    task.StartDate = task.CreatedDate.AddHours(12).Date;
                task.CompletedDate = task.StartDate.Value.AddHours(TutorialConstants.Random.Next(48) + 24);
            }
            return task;
        }

    }
    public class LayoutOption {
        public static bool TaskCollapsed = false;
    }
}
