using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraRichEdit;
using DevExpress.DevAV;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
#if !NET
using System.Data.Entity;
#else
using Microsoft.EntityFrameworkCore;
#endif

namespace DevExpress.XtraNavBar.Demos {
    [Flags]
    public enum MailFolder {
        All = 0,
        Announcements = 1,
        General = 2,
        Management = 4,
        IT = 8,
        Sales = 16,
        Support = 32,
        Engineering = 64,
        Deleted = 128,
        Custom = 1024
    };
    public enum MailCategories {
        General = 1,
        Management = 2,
        IT = 3,
        Sales = 4,
        Support = 5,
        Engineering = 6,
        HR = 7,
        Design = 8
    };
    public enum MailType {
        Inbox,
        Deleted,
        Sent,
        Draft
    };
    public class Message : INotifyPropertyChanged {
        DateTime dateCore;
        bool readCore, deletedCore, hasAttachment;
        int priorityCore = 1;
        MailType mailTypeCore;
        int mailFolderCore;
        string fromCore = String.Empty, subjectCore = String.Empty, textCore = String.Empty, plainTextCore = string.Empty, emailCore = String.Empty;

        public Message() {
            dateCore = TutorialConstants.Now;
        }
        public Message(DataRow row) {
            dateCore = TutorialConstants.Now.AddDays((int)row["Day"]).AddSeconds(-TutorialConstants.Random.Next(10000));
            emailCore = string.Format("{0}", row["From"]);
            fromCore = DataHelper.GetNameByEmail(emailCore);
            subjectCore = string.Format("{0}", row["Subject"]);
            readCore = Delay > TimeSpan.FromHours(48);
            textCore = string.Format("{0}", row["Text"]);
            deletedCore = false;
            mailTypeCore = MailType.Inbox;
            mailFolderCore = (int)GetFolder(row);
            plainTextCore = GetPlainText();
            DataTweaking();
        }
        public string FullName {
            get {
                if(string.IsNullOrEmpty(emailCore)) return fromCore;
                return string.Format("{0} ({1})", fromCore, emailCore);
            }
        }
        public DateTime Date { get { return dateCore; } set { dateCore = value; } }
        public string From { get { return fromCore; } set { fromCore = value; } }
        public string Email { get { return emailCore; } set { emailCore = value; } }
        public string Subject { get { return subjectCore; } set { subjectCore = value; } }
        public string SubjectDisplayText { get { return Subject; } }
        public int Attachment { get { return hasAttachment ? 1 : 0; } }
        public int Read { get { return readCore ? 1 : 0; } }
        public int Priority { get { return priorityCore; } set { priorityCore = value; } }
        public bool IsUnread { get { return !readCore; } }
        internal string Folder { get { return string.Format("{0}", mailFolderCore); } }
        public string Text { get { return textCore; } set { textCore = value; } }
        public string PlainText { get { return GetPlainText(); } }

        string GetPlainText() {
            if(string.IsNullOrEmpty(plainTextCore)) {
                plainTextCore = ObjectHelper.GetPlainTextFromMHT(textCore).Replace("\r\n", " ");
            }
            return plainTextCore;
        }
        public MailType MailType { get { return mailTypeCore; } set { mailTypeCore = value; } }
        public int MailFolder {
            get { return mailFolderCore; }
            set {
                if(MailFolder == value) return;
                mailFolderCore = value;
                OnPropertyChanged("MailFolder");
            }
        }
        public bool Deleted {
            get { return deletedCore; }
            set { deletedCore = value; }
        }
        internal TimeSpan Delay { get { return TutorialConstants.Now - dateCore; } }

        public void ToggleRead() {
            readCore = !readCore;
        }
        void DataTweaking() {
            if(Delay > TimeSpan.FromHours(50) && Delay < TimeSpan.FromHours(100)) readCore = false;
            if(subjectCore.IndexOf("RE:") >= 0 || subjectCore.IndexOf("FW:") >= 0) readCore = false;
            this.hasAttachment = textCore.Length > 20000;
            if(subjectCore.IndexOf("Review") >= 0 || subjectCore.IndexOf("Important") >= 0) priorityCore = 2;
            if(subjectCore.IndexOf("FW:") >= 0 && Delay > TimeSpan.FromHours(48)) priorityCore = 0;
            if(subjectCore.IndexOf("New") >= 0 || subjectCore.IndexOf("Meeting") >= 0)
                mailFolderCore += 1;
        }
        MailFolder GetFolder(DataRow row) {
            object category = row["CategoryID"];
            string ret = string.Format("{0}", (MailCategories)(category == DBNull.Value ? 1 : (int)category));
            if(string.IsNullOrEmpty(ret)) return DevExpress.XtraNavBar.Demos.MailFolder.All;
            return (MailFolder)Enum.Parse(typeof(MailFolder), ret.Replace(" ", ""));
        }
        public void SetPlainText(string text) { plainTextCore = text; }

        #region INotifyPropertyChanged Members
        event PropertyChangedEventHandler propertyChangedEventHandler;
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged {
            add { propertyChangedEventHandler += value; }
            remove { propertyChangedEventHandler -= value; }
        }
        protected void OnPropertyChanged(string name) {
            propertyChangedEventHandler?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
    //
    public class ObjectHelper {
        readonly static RichEditDocumentServer rich = new RichEditDocumentServer();
        public static string GetPlainTextFromMHT(string mhtText) {
            rich.MhtText = mhtText;
            return rich.Text.TrimStart();
        }
    }
    public class DataHelper {
        static BindingList<Employee> employeesCore = null;
        static BindingList<Message> messagesCore = null;
        internal static DataTable MailTable {
            get {
                string table = "Messages";
                return CreateDataTable(table);
            }
        }
        public static System.Threading.Tasks.Task LoadMessagesAsync() {
            var context = Data.Helpers.SyncHelper.TryCaptureSynchronizationContext();
            return System.Threading.Tasks.Task.Run(() => {
                if(LoadMessages() && context != null)
                    context.Post(new System.Threading.SendOrPostCallback(PostMessagesUpdate), null);
            });
        }
        static void PostMessagesUpdate(object state) {
            messagesCore.ResetBindings();
        }
        public static bool LoadMessages() {
            try {
                if(messagesCore == null) {
                    messagesCore = new BindingList<Message>();
                    DataTable tbl = MailTable;
                    if(tbl != null) {
                        messagesCore.RaiseListChangedEvents = false;
                        foreach(DataRow row in tbl.Rows)
                            messagesCore.Add(new Message(row));
                        messagesCore.RaiseListChangedEvents = true;
                        return true;
                    }
                }
            }
            catch(Exception e) {
                XtraMessageBox.Show(e.Message, e.Source);
                messagesCore = new BindingList<Message>();
            }
            return messagesCore.Count > 0;
        }
        public static BindingList<Message> Messages {
            get {
                LoadMessages();
                return messagesCore;
            }
        }
        internal static BindingList<Employee> Employees {
            get {
                if(employeesCore == null) {
#if !NET
                    DevAVDb devAvDb = new DevAVDb();
#else
                    DevAVDb devAvDb = new DevAVDb($"Data Source={Internal.DevAVDataDirectoryHelper.GetFile("devav.sqlite3")}");
#endif
                    devAvDb.Employees.Load();
                    employeesCore = devAvDb.Employees.Local.ToBindingList();
                }
                return employeesCore;
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
        private static DataTable CreateDataTable(string table) {
            DataSet dataSet = new DataSet();
            string dataFile = DataDirectoryHelper.GetDataFile("MailDevAv.xml");
            if(dataFile != string.Empty) {
                FileInfo fi = new FileInfo(dataFile);
                dataSet.ReadXml(fi.FullName);
                return dataSet.Tables[table];
            }
            return null;
        }
    }
    public class VehiclesData {
        public enum Category {
            Car = 1,
            [Display(Name = "Crossover & SUV")]
            CrossoverAndSUV = 2,
            Truck = 3,
            Minivan = 4
        }
        public enum BodyStyle {
            Convertible = 1,
            Coupe = 2,
            Hatchback = 3,
            [Display(Name = "Passenger Van")]
            PassengerVan = 4,
            Pickup = 5,
            Sedan = 6,
            [Display(Name = "Sport Utility Vehicle")]
            SportUtilityVehicle = 7,
            Wagon = 8
        }
        public enum TransmissionType {
            Automatic = 1,
            Manual = 2
        }
        public class Trademark {
            public int ID { get; set; }
            public Image Logo { get; set; }
            public string Name { get; set; }
        }
        public class OrderItem {
            internal Model Model;
            public OrderItem(int totalCount, List<Model> models, int id)
                : this(totalCount, models[id % models.Count], id) {
            }
            public OrderItem(int totalCount, Model model, int id) {
                Model = model;
                ModelPrice = model.Price;
                Trademark = model.Trademark;
                Name = model.Name;
                Modification = model.Modification;
                Category = model.Category;
                MPGCity = model.MPGCity;
                MPGHighway = model.MPGHighway;
                Doors = model.Doors;
                BodyStyle = model.BodyStyle;
                Cylinders = model.Cylinders;
                Horsepower = model.Horsepower;
                Torque = model.Torque;
                TransmissionSpeeds = model.TransmissionSpeeds;
                TransmissionType = model.TransmissionType;
                Discount = Math.Round(0.05 * ((id * Trademark) % 4), 2);
                OrderID = id;
                if(totalCount > 0)
                    CreateSalesInfo(id, totalCount);
            }
            void CreateSalesInfo(int id, int totalCount) {
                var salesPerDay = totalCount / (365.25 * 7);
                var lastSaleDateTime = TutorialConstants.Today.AddHours(-15);
                SalesDate = lastSaleDateTime.AddDays(-id / salesPerDay);
                var orderWithinYearId = (int)Math.Floor((SalesDate - new DateTime(SalesDate.Year, 1, 1)).TotalDays * salesPerDay) + 1;
                SalesID = string.Format("{0:d4}-<size=-1><b>{1:d6}</b>", SalesDate.Year, orderWithinYearId);
            }
            public OrderItem(Model model, int days, int id) : this(-1, model, id) {
                Discount = Math.Round(0.05 * TutorialConstants.Random.Next(4), 2);
                SalesDate = TutorialConstants.Now.AddDays(-TutorialConstants.Random.Next(days));
            }
            public int OrderID { get; set; }
            public string SalesID { get; set; }
            public DateTime SalesDate { get; set; }
            public double Discount { get; set; }
            [DataType(DataType.Currency)]
            public decimal ModelPrice { get; set; }
            public int Trademark { get; set; }
            public string Name { get; set; }
            public string Modification { get; set; }
            public int Category { get; set; }
            public int? MPGCity { get; set; }
            public int? MPGHighway { get; set; }
            public int Doors { get; set; }
            public int BodyStyle { get; set; }
            public int Cylinders { get; set; }
            public string Horsepower { get; set; }
            public string Torque { get; set; }
            public int TransmissionSpeeds { get; set; }
            public int TransmissionType { get; set; }
            public Image Photo { get { return Model.Photo; } }
        }
        public class Model {
            public int ID { get; set; }
            public int Trademark { get; set; }
            public string Name { get; set; }
            public string Modification { get; set; }
            public int Category { get; set; }
            public decimal Price { get; set; }
            public int? MPGCity { get; set; }
            public int? MPGHighway { get; set; }
            public int Doors { get; set; }
            public int BodyStyle { get; set; }
            public int Cylinders { get; set; }
            public string Horsepower { get; set; }
            public string Torque { get; set; }
            public int TransmissionSpeeds { get; set; }
            public int TransmissionType { get; set; }
            public string Description { get; set; }
            public Image Photo { get; set; }
            public DateTime DeliveryDate { get; set; }
            public bool InStock { get; set; }
            public Image TrademarkImage {
                get { return Trademarks != null ? Trademarks[Trademark - 1].Logo : null; }
            }
            public string TrademarkName {
                get { return Trademarks != null ? Trademarks[Trademark - 1].Name : string.Empty; }
            }
            public string CategoryName {
                get { return EnumDisplayTextHelper.GetDisplayText((Category)Category); }
            }
            public string BodyStyleName {
                get { return EnumDisplayTextHelper.GetDisplayText((BodyStyle)BodyStyle); }
            }
            public string TransmissionTypeName {
                get { return EnumDisplayTextHelper.GetDisplayText((TransmissionType)TransmissionType); }
            }
            public List<VehiclesData.Trademark> Trademarks = null;
            internal string LicenseInfo { get; set; }
        }

        public static List<Model> InitXMLDataCore(string dataFileName) {
            return InitXMLDataCore(dataFileName, 30);
        }
        static List<Model> InitXMLDataCore(string dataFileName, int dataInterval) {
            string Model = "Model";
            string Trademark = "Trademark";
            DataSet ds = GetDataSet(dataFileName);
            List<Trademark> listTrademarks = new List<VehiclesData.Trademark>();
            foreach(DataRow row in ds.Tables[Trademark].Rows)
                listTrademarks.Add(new VehiclesData.Trademark() {
                    ID = (int)(row["ID"]),
                    Name = (string)row["Name"],
                    Logo = ByteImageConverter.FromByteArray((byte[])row["Logo"])
                });

            var listModels = new List<VehiclesData.Model>();
            foreach(DataRow row in ds.Tables[Model].Rows)
                listModels.Add(new VehiclesData.Model() {
                    ID = (int)row["ID"],
                    Name = (string)row["Name"],
                    Trademark = (int)row["TrademarkID"],
                    Modification = (string)row["Modification"],
                    Category = (int)row["CategoryID"],
                    Price = (decimal)row["Price"],
                    MPGCity = System.DBNull.Value.Equals(row["MPG City"]) ? null : (int?)row["MPG City"],
                    MPGHighway = System.DBNull.Value.Equals(row["MPG City"]) ? null : (int?)row["MPG Highway"],
                    Doors = (int)row["Doors"],
                    BodyStyle = (int)row["BodyStyleID"],
                    Cylinders = (int)row["Cylinders"],
                    Horsepower = (string)row["Horsepower"],
                    Torque = (string)row["Torque"],
                    TransmissionSpeeds = Convert.ToInt32(row["Transmission Speeds"]),
                    TransmissionType = (int)row["Transmission Type"],
                    Description = string.Format("{0}", row["Description"]),
                    Photo = ByteImageConverter.FromByteArray((byte[])row["Photo"]),
                    DeliveryDate = TutorialConstants.Now.AddDays(TutorialConstants.Random.Next(dataInterval)),
                    InStock = TutorialConstants.Random.Next(100) < 95,
                    Trademarks = listTrademarks,
                    LicenseInfo = GetLicenseInfo(row)
                });
            return listModels;
        }
        internal static string GetLicenseInfo(DataRow row) {
            return $"{row["License Name"]}|{row["Author"]}|{row["Source"]}|{row["Edits"]}";
        }
        readonly static Dictionary<string, DataSet> dataSets = new Dictionary<string, DataSet>();
        static DataSet GetDataSet(string dataFileName) {
            if(!dataSets.TryGetValue(dataFileName, out DataSet ds)) {
                ds = new DataSet();
                ds.ReadXml(dataFileName);
                dataSets.Add(dataFileName, ds);
            }
            return ds;
        }
    }
}
