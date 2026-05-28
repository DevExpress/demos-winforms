using DevExpress.DevAV;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit;
using DevExpress.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
#if !NET
using System.Data.Entity;
#else
using Microsoft.EntityFrameworkCore;
#endif
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.HTML.Demos.Helpers {
    [Flags]
    public enum MailFolder { All = 0, Announcements = 1, General = 2, Management = 4, IT = 8, Sales = 16, Support = 32, Engineering = 64, Deleted = 128, Custom = 1024 };
    public enum MailCategories { General = 1, Management = 2, IT = 3, Sales = 4, Support = 5, Engineering = 6, HR = 7, Design = 8 };
    public enum MailType { Inbox, Deleted, Sent, Draft };

    public class DataHelper {
        static BindingList<Employee> employeesCore = null;
        static BindingList<EmailMessage> messagesCore = null;
        internal static DataTable MailTable {
            get {
                string table = "Messages";
                return CreateDataTable(table);
            }
        }
        public static System.Threading.Tasks.Task LoadMessagesAsync() {
            if(MainFormHelper.TakeScreens) {
                LoadMessages();
                PostUpdateMessaged(null);
                return null;
            }
            var context = DevExpress.Data.Helpers.SyncHelper.TryCaptureSynchronizationContext();
            return System.Threading.Tasks.Task.Run(() => {
                if(LoadMessages() && context != null)
                    context.Post(new System.Threading.SendOrPostCallback(PostUpdateMessaged), null);
            });
        }
        static void PostUpdateMessaged(object state) {
            messagesCore.ResetBindings();
        }
        public static bool LoadMessages() {
            try {
                if(messagesCore == null) {
                    messagesCore = new BindingList<EmailMessage>();
                    DataTable tbl = MailTable;
                    if(tbl != null) {
                        messagesCore.RaiseListChangedEvents = false;
                        foreach(DataRow row in tbl.Rows)
                            messagesCore.Add(new EmailMessage(row));
                        messagesCore.RaiseListChangedEvents = true;
                        return true;
                    }
                }
            }
            catch(Exception e) {
                XtraMessageBox.Show(e.Message, e.Source);
                messagesCore = new BindingList<EmailMessage>();
            }
            return messagesCore.Count > 0;
        }
        public static BindingList<EmailMessage> Messages {
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
                    DevAVDb devAvDb = new DevAVDb($"Data Source={DevAVDataDirectoryHelper.GetFile("devav.sqlite3")}");
#endif
                    devAvDb.Employees.Load();
                    employeesCore = devAvDb.Employees.Local.ToBindingList();
                }
                return employeesCore;
            }
        }
        public static Employee GetEmployeeByEmail(string email) {
            return Employees.FirstOrDefault(p => p.Email == email);
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
    public class EmailMessage : INotifyPropertyChanged {
        DataRow row;
        DateTime dateCore;
        bool readCore, deletedCore, hasAttachment;
        int priorityCore = 1;
        MailType mailTypeCore;
        int mailFolderCore;
        string fromCore = String.Empty, subjectCore = String.Empty, textCore = String.Empty, plainTextCore = string.Empty, emailCore = String.Empty;

        public EmailMessage() {
            dateCore = TutorialConstants.Now;
        }
        static int counter = 0;
        public EmailMessage(DataRow row) {
            this.row = row;
            var rnd = GetRandomInstance();
            dateCore = TutorialConstants.Now.AddDays((int)row["Day"]).AddSeconds(-rnd.Next(10000));
            emailCore = string.Format("{0}", row["From"]);
            subjectCore = string.Format("{0}", row["Subject"]);
            readCore = Delay > TimeSpan.FromHours(48);
            textCore = string.Format("{0}", row["Text"]);
            deletedCore = false;
            mailTypeCore = MailType.Inbox;
            mailFolderCore = (int)GetFolder(row);
            plainTextCore = GetPlainText();
            var employee = DataHelper.GetEmployeeByEmail(emailCore);
            if(employee != null) {
                fromCore = employee.FullName;
                Photo = employee.Picture != null ? employee.Photo : null;
                FromInitials = CreateInitials(employee.FullName);
            }
            DataTweaking();
        }

        string CreateInitials(string fullName) {
            var split = fullName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;
            if(split.Length > 0) result = split[0][0].ToString().ToUpper();
            if(split.Length > 1) result += split[1][0].ToString().ToUpper();
            return result;
        }

        static DevExpress.Data.Utils.NonCryptographicRandom GetRandomInstance() {
            if(MainFormHelper.TakeScreens) {
                counter++;
                return new DevExpress.Data.Utils.NonCryptographicRandom(counter);
            }
            return TutorialConstants.Random;
        }
        public string FullName {
            get {
                if(string.IsNullOrEmpty(emailCore)) return fromCore;
                return string.Format("{0} ({1})", fromCore, emailCore);
            }
        }
        public DateTime Date { get { return dateCore; } set { dateCore = value; } }
        public string From { get { return fromCore; } set { fromCore = value; } }
        public string FromInitials { get; }
        public string Email { get { return emailCore; } set { emailCore = value; } }
        public string Subject { get { return subjectCore; } set { subjectCore = value; } }
        public string SubjectDisplayText { get { return Subject; } }
        public int Attachment { get { return hasAttachment ? 1 : 0; } }
        public int Read { get { return readCore ? 1 : 0; } }
        public int Priority { get { return priorityCore; } set { priorityCore = value; } }
        public bool IsUnread { get { return !readCore; } }
        public bool IsImportant { get { return Priority == 2; } }
        internal string Folder { get { return string.Format("{0}", mailFolderCore); } }
        public string Text { get { return textCore; } set { textCore = value; } }
        public string PlainText { get { return GetPlainText(); } }
        public Image Photo { get; }
        public bool HasPhoto { get { return Photo != null; } }


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
        bool flagged;
        public bool Flagged {
            get { return flagged; }
            set {
                if(flagged == value)
                    return;
                flagged = value;
                OnPropertyChanged(nameof(Flagged));
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
            if(string.IsNullOrEmpty(ret)) return DevExpress.HTML.Demos.Helpers.MailFolder.All;
            return (MailFolder)Enum.Parse(typeof(MailFolder), ret.Replace(" ", ""));
        }
        public void SetPlainText(string text) { plainTextCore = text; }

        #region INotifyPropertyChanged Members
        event PropertyChangedEventHandler _propertyChangedEventHandler;
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged {
            add { _propertyChangedEventHandler += value; }
            remove { _propertyChangedEventHandler -= value; }
        }
        protected void OnPropertyChanged(string name) {
            if(_propertyChangedEventHandler != null) _propertyChangedEventHandler(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
    public class ObjectHelper {
        static RichEditDocumentServer rich = new RichEditDocumentServer();
        public static string GetPlainTextFromMHT(string mhtText) {
            rich.MhtText = mhtText;
            return rich.Text.TrimStart();
        }
        public static void GetChildDataRowHandles(GridView view, int rowHandle, List<EmailMessage> list) {
            for(int i = 0; i < view.GetChildRowCount(rowHandle); i++) {
                int row = view.GetChildRowHandle(rowHandle, i);
                if(row >= 0)
                    list.Add(view.GetRow(row) as EmailMessage);
                else
                    GetChildDataRowHandles(view, row, list);
            }
        }
    }

}

namespace DevExpress.HTML.Demos.Helpers.Tasks {
    public class TaskGenerator {
        int employeePosition = 0;
        int subtaskPosition = 0;
        static TaskGenerator defaultCore;
        public static TaskGenerator Default {
            get {
                if(defaultCore == null)
                    defaultCore = new TaskGenerator();
                return defaultCore;
            }
        }
        public List<EmployeeTask> GenerateSource(int count) {
            employeePosition = subtaskPosition = 0;
            DateTime startDate = Today.AddDays(-200);
            DateTime dueDate = Today.AddDays(200);
            List<EmployeeTask> employeeTasks = new List<EmployeeTask>();
            int rootCount = EmployeeTask.RootTasks.Count();
            int id = 1;
            int subtaskCount = count - rootCount;
            for(int i = 0; i < rootCount; i++) {
                EmployeeTask task = new EmployeeTask();
                int complete = 0;
                employeeTasks.Add(task);
                task.ID = id++;
                task.ParentID = 0;
                task.Employee = GetEmployee().FullName;
                AddMembers(task.Members, TutorialConstants.Random.Next(1, 4));
                task.Name = EmployeeTask.RootTasks[i];
                CalcDate(task, startDate, dueDate);
                var tasks = GenerateSubTasks(task, CalcSubtaskCount(subtaskCount, rootCount - i), ref complete);
                id += tasks.Count;
                subtaskCount -= tasks.Count;
                employeeTasks.AddRange(tasks);
                if(tasks.Count != 0)
                    task.Status = complete / tasks.Count;
                else
                    CalcStatus(task);
            }
            return employeeTasks;
        }
        void AddMembers(List<Employee> list, int count) {
            for(int n = 0; n < count; n++) {
                list.Add(GetEmployee());
            }
        }
        int CalcSubtaskCount(int subtaskCount, int rootCount) {
            int value = subtaskCount / rootCount;
            if(value + 10 < 1)
                return 0;
            int minValue = 1;
            if(value > 10)
                minValue = value - 10;
            return TutorialConstants.Random.Next(minValue, value + 10);
        }
        Employee GetEmployee() {
            if(Employee.Employees.Count == employeePosition)
                employeePosition = 0;
            return Employee.Employees[employeePosition++];
        }
        List<EmployeeTask> GenerateSubTasks(EmployeeTask parent, int subtaskCount, ref int complete) {
            List<EmployeeTask> tasks = new List<EmployeeTask>();
            int id = parent.ID + 1;
            for(int i = 0; i < subtaskCount; i++) {
                EmployeeTask task = new EmployeeTask();
                tasks.Add(task);
                int taskID = GetSubtaskPosition();
                task.Name = EmployeeTask.Subtasks[taskID];
                if(CanShowDescription())
                    task.Description = EmployeeTask.DescriptionSubtasks[taskID];
                task.Employee = GetEmployee().FullName;
                AddMembers(task.Members, TutorialConstants.Random.Next(1, 4));
                task.ID = id++;
                task.ParentID = parent.ID;
                task.Priority = GetPriority();
                CalcDate(task, parent.StartDate, parent.DueDate, i == 0, i + 1 == subtaskCount);
                CalcStatus(task);
                complete += task.Status;
            }
            return tasks;
        }
        void CalcDate(EmployeeTask task, DateTime startDate, DateTime dueDate, bool isFirst = false, bool isLast = false) {
            var delta = dueDate.Subtract(startDate);
            var stDT = isFirst ? startDate : GetDate(startDate, 1, delta.Days);
            var deDT = isLast ? dueDate : GetDate(dueDate, -1, delta.Days);
            while(stDT.Equals(deDT))
                deDT = GetDate(dueDate, -1, delta.Days);
            if(stDT > deDT) {
                task.StartDate = deDT;
                task.DueDate = stDT;
            }
            else {
                task.StartDate = stDT;
                task.DueDate = deDT;
            }
        }
        bool CanShowDescription() {
            int value = TutorialConstants.Random.Next(0, 1000);
            return value < 600;
        }
        int GetSubtaskPosition() {
            if(subtaskPosition == EmployeeTask.Subtasks.Count())
                subtaskPosition = 0;
            return subtaskPosition++;
        }
        int GetPriority() {
            int value = TutorialConstants.Random.Next(-100, 100);
            if(value < 0)
                return -1;
            if(value < 60)
                return 0;
            return 1;
        }
        void CalcStatus(EmployeeTask task) {
            int status = 0;
            if(task.StartDate > Today)
                status = TutorialConstants.Random.Next(0, 200) / 9;
            else {
                status = TutorialConstants.Random.Next(800, 1000) / 9;
                if(task.DueDate > Today) {
                    int dif = task.DueDate.Subtract(task.StartDate).Days;
                    int difNow = task.DueDate.Subtract(Today).Days;
                    status = (int)(status * (float)difNow / dif);
                }
                else {
                    if(status < 100 && TutorialConstants.Random.NextDouble() > 0.2) {
                        int lateDays = Today.Subtract(task.DueDate).Days;
                        task.DueDate = task.DueDate.AddDays(lateDays + TutorialConstants.Random.Next(15));
                    }
                }
            }
            if(status > 100)
                status = 100;
            task.Status = status;
        }
        DateTime GetDate(DateTime time, int sign, int delta) {
            return time.AddDays(sign * TutorialConstants.Random.Next(0, delta));
        }
        internal readonly static DateTime Today = TutorialConstants.Now.Date;
    }
    public class EmployeeTask : IDataErrorInfo {
        public EmployeeTask() {
            Priority = Status = -1;
        }
        public string PriorityName {
            get {
                switch(Priority) {
                    case -1: return "Low";
                    case 0: return "Medium";
                    case 1: return "High";
                    default: return string.Empty;
                }
            }
        }
        [Display(Order = -1)]
        public int ID { get; set; }
        [Display(Order = -1)]
        public int ParentID { get; set; }
        [Utils.Filtering.FilterGroup("Employee;Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Employee { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public List<Employee> Members { get; } = new List<Employee>();
        [Display(AutoGenerateField = false)]
        public bool HasDescription {
            get { return !string.IsNullOrEmpty(Description); }
        }
        [Display(AutoGenerateField = false)]
        public bool IsCompleted {
            get { return Status == 100; }
        }
        [Display(AutoGenerateField = false)]
        public bool Overdue {
            get { return !IsCompleted && DueDate.Date < TaskGenerator.Today; }
        }
        public string Error { get { return OverdueDays(); } }
        string IDataErrorInfo.this[string columnName] {
            get { return columnName == "DueDate" ? OverdueDays() : string.Empty; }
        }
        string OverdueDays() {
            return Overdue ? "Late by " + (TaskGenerator.Today - DueDate.Date).Days + " days" : string.Empty;
        }
        public static string[] RootTasks = {
            "Simplify & clarify our product, messaging, presentation of things we do.",
            "Present an action plan for next quarter's messaging improvements.",
            "Increase average subscription size to at least $295 per month.",
            "Reduce churn to less than 1% monthly.",
            "Finalize the content strategy, key messages and topic structure for next 6 months",
            "Grow subscriber base at least 5% per week.",
            "Increase the CTR% to above industry average 3.5%.",
            "Close the final budget.",
            "Achieve record metrics in all areas.",
            "Activate user-testing of our content.",
            "Organize an online survey with min 100 answers to rate our various content.",
            "Improve our content and its distribution.",
            "Implement 12 new channels/mediums where to post old or new content.",
            "Map and analyze all of our current marketing channels and give recommendations to improve them.",
            "Research and improve customer satisfaction.",
            "Present an action plan for next quarter.",
            "Achieve record revenues while increasing profitability.",
            "Hit quarterly revenue of over $1000000.",
            "Start sales in 2 new countries.",
            "Increase gross profit margin % from 63% to 54%.",
            "Reach monthly recurring revenue ($ MRR) of $250000.",
            "Increase recurring revenues.",
            "Achieve trial to % paid ratio of over 50%.",
            "Implement new product planning process.",
            "Redesign and launch our new landing page.",
            "Design new version of our site structure, navigation and all pages.",
            "Support marketing and sales with design deliverables.",
            "Promote our design team as the best place to work.",
            "Improve annual budgeting and business planning.",
            "Receive business line budget proposals before.",
            "Finish raising new capital for growth needs.",
            "Improve internal document management.",
            "Choose and launch new document sharing platform.",
            "Increase end-user satisfaction rating from 4.0 to 4.5.",
            "Implement a better system for tracking incoming requests.",
            "Collect more accurate sales leads data.",
            "Increase the quality of our sales approach."
        };
        public static string[] Subtasks = {
            "Prepare Financial",
            "Prepare Marketing Plan",
            "Update Personnel Files",
            "Review Health Insurance Options Under the Affordable Care Act",
            "Choose between PPO and HMO Health Plan",
            "Google AdWords Strategy",
            "New Brochures",
            "Brochure Designs",
            "Brochure Design Review",
            "Website Re-Design Plan",
            "Rollout of New Website and Marketing Brochures",
            "Update Sales Strategy Documents",
            "Create Sales Report",
            "Direct vs Online Sales Comparison Report",
            "Review Sales Report and Approve Plans",
            "Deliver R&D Plans",
            "Create R&D Plans",
            "QA Strategy Report",
            "Training Events",
            "Approve Hiring of John Jeffers",
            "Non-Compete Agreements",
            "Update Employee Files with New NDA",
            "Sign Updated NDA",
            "Submit Questions Regarding New NDA",
            "Submit Signed NDA",
            "Update Revenue Projections",
            "Review Revenue Projections",
            "Comment on Revenue Projections",
            "Provide New Health Insurance Docs",
            "Review Changes to Health Insurance Coverage",
            "Scan Health Insurance Forms",
            "Sign Health Insurance Forms",
            "Follow up with West Coast Stores",
            "Follow up with East Coast Stores",
            "Send Email to Customers about Recall",
            "Submit Refund Report for 2013 Recall",
            "Give Final Approval for Refunds",
            "Prepare Product Recall Report",
            "Review Product Recall Report by Engineering Team",
            "Create Training Course for New TVs",
            "Review Training Course for any Ommissions",
            "Review Overtime Report",
            "Submit Overtime Request Forms",
            "Overtime Approval Guidelines",
            "Refund Request Template",
            "Recall Rebate Form",
            "Create Report on Customer Feedback",
            "Review Customer Feedback Report",
            "Customer Feedback Report Analysis",
            "Prepare Shipping Cost Analysis Report",
            "Provide Feedback on Shippers",
            "Select Preferred Shipper",
            "Complete Shipper Selection Form",
            "Upgrade Server Hardware",
            "Upgrade Personal Computers",
            "Approve Personal Computer Upgrade Plan",
            "Decide on Mobile Devices to Use in the Field",
            "Upgrade Apps to Windows RT or stay with WinForms",
            "Estimate Time Required to Touch-Enable Apps",
            "Report on Tranistion to Touch-Based Apps",
            "Try New Touch-Enabled WinForms Apps",
            "Rollout New Touch-Enabled WinForms Apps",
            "Site Up-Time Report",
            "Review Site Up-Time Report",
            "Review Online Sales Report",
            "Determine New Online Marketing Strategy",
            "New Online Marketing Strategy",
            "Approve New Online Marketing Strategy",
            "Submit New Website Design",
            "Create Icons for Website",
            "Review PSDs for New Website",
            "Create New Shopping Cart",
            "Create New Product Pages",
            "Review New Product Pages",
            "Approve Website Launch",
            "Launch New Website",
            "Update Customer Shipping Profiles",
            "Create New Shipping Return Labels",
            "Get Design for Shipping Return Labels",
            "PSD needed for Shipping Return Labels",
            "Request Bandwidth Increase from ISP",
            "Submit D&B Number to ISP for Credit Approval",
            "Contact ISP and Discuss Payment Options",
            "Prepare Year-End Support Summary Report",
            "Analyze Support Traffic",
            "Review New Training Material",
            "Distribute Training Material to Support Staff",
            "Training Material Distribution Schedule",
            "Provide New Artwork to Support Team",
            "Publish New Art on the Server",
            "Replace Old Artwork with New Artwork",
            "Ship New Brochures to Field",
            "Ship Brochures to Todd Hoffman",
            "Update Server with Service Packs",
            "Install New Database",
            "Approve Overtime for HR",
            "Review New HDMI Specification",
            "Approval on Converting to New HDMI Specification",
            "Create New Spike for Automation Server",
            "Report on Retail Sales Strategy",
            "Code Review - New Automation Server",
            "Feedback on New Training Course",
            "Send Monthly Invoices from Shippers",
            "Schedule Meeting with Sales Team",
            "Confirm Availability for Sales Meeting",
            "Reschedule Sales Team Meeting",
            "Send 2 Remotes for Giveaways",
            "Ship 2 Remotes Priority to Clark Morgan",
            "Discuss Product Giveaways with Management",
            "Follow Up Email with Recent Online Purchasers",
            "Replace Desktops on the 3rd Floor",
            "Update Database with New Leads",
            "Mail New Leads for Follow Up",
            "Send Territory Sales Breakdown",
            "Territory Sales Breakdown Report",
            "Return Merchandise Report",
            "Report on the State of Engineering Dept",
            "Staff Productivity Report",
            "Review HR Budget Company Wide",
            "Sales Dept Budget Request Report",
            "Support Dept Budget Report",
            "IT Dept Budget Request Report",
            "Engineering Dept Budget Request Report",
            "1Q Travel Spend Report",
            "Approve Benefits Upgrade Package",
            "Final Budget Review",
            "State of Operations Report",
            "Online Sales Report",
            "Reprint All Shipping Labels",
            "Shipping Label Artwork",
            "Specs for New Shipping Label",
            "Move Packaging Materials to New Warehouse",
            "Move Inventory to New Warehouse",
            "Take Forklift to Service Center",
            "Approve Rental of Forklift",
            "Give Final Approval to Rent Forklift",
            "Approve Overtime Pay",
            "Approve Vacation Request",
            "Approve Salary Increase Request",
            "Review Complaint Reports",
            "Review Website Complaint Reports",
            "Fix Synchronization Issues",
            "Free Up Space for New Application Set",
            "Install New Router in Dev Room",
            "Update Your Profile on Website",
            "Schedule Conf Call with SuperMart",
            "Support Team Evaluation Report",
            "Create New Installer for Company Wide App Deployment",
            "Pickup Packages from the Warehouse",
            "Sumit Travel Expenses for Recent Trip",
            "Make Travel Arrangements for Sales Trip to San Francisco",
            "Book Flights to San Fran for Sales Trip",
            "Collect Customer Reviews for Website",
            "Submit New W4 for Updated Exemptions",
            "Get New Frequent Flier Account",
            "Review New Customer Follow Up Plan",
            "Submit Customer Follow Up Plan Feedback",
            "Review Issue Report and Provide Workarounds",
            "Contact Customers for Video Interviews",
            "Resubmit Request for Expense Reimbursement",
            "Approve Vacation Request Form",
            "Email Test Report on New Products",
            "Send Receipts for all Flights Last Month",
            "New Shipping Labels",
            "PSD Needed For Shipping Labels",
            "Online Retail Purchasers",
            "Update NDA Agreement",
            "Test New Automation App",
            "Review Training Content",
            "Classroom Size",
            "Specs for Automation App",
            "Business Cards",
            "Update address",
            "Review Automation App",
            "Tradershow Flight",
            "Tradeshow Marketing Message",
            "Per Diem",
            "Health Insurance Notification",
            "Lunch Potluck",
            "Review Benefits",
            "Training",
            "Submitted Reports",
            "Review Articles",
            "NDA Revision",
            "Budget Reports",
            "Sales Report by Territory",
            "Leads Generated from Atlanta",
            "Materials Needed for On-Site Event",
            "Northwest Territory Customers",
            "Retail Sales Meeting",
            "New Warehourse",
            "Purchase 2 New Remotes",
            "Walk Thru with Shipping Companies",
            "Missing Signatures",
            "Review Training Manual - First Draft",
            "Online Video Content",
        };
        public static string[] DescriptionSubtasks = {
                @"IMPORTANT: The document must be fully formatted in Excel.",
                @"We need to double revenues and our marketing strategy is going to be key here. R&D is improving existing products and creating new products so we can deliver great AV equipment to our customers.",
                @"In an audit I conducted of personnel files this, I found documentation to be lacking. Samantha, you need to review my report and get this fixed.",
                @"The changes in health insurance laws require that we review our existing coverage and update it to meet regulations. Samantha Bright will be point on this.",
                @"We need a final decision on whether we are planning on staying with a PPO Health Plan or we plan on switching to an HMO. We cannot proceed with compliance with the Affordable Health Act until we make this decision.",
                @"Make final decision on whether we are going to increase our Google AdWord spend based on our marketing plan. We must seriously consider a higher spend if we are going to double revenues this year.",
                @"Review and the new brochure designs and give final approval.",
                @"The changes we need to make to our brochures have been forwarded via Email please review and send updated versions to Robert Reagan.",
                @"We have been instructed by management to modify brochure designs. All specifications and change requests are on the server.",
                @"The changes in our brochure designs for 2013 require us to update key areas of our website.",
                @"The designs for new brochures and website have been approved.",
                @"Changes in marketing strategy require an update to our direct sales strategy. The report has to be completed by month's end to submission to the CEO.",
                @"Sales Report has to be completed so we can determine if major changes are required to sales strategy.",
                @"To better understand sales strategy, we need to report direct vs online sales information to management.",
                @"Sales Reports along with detailed market comparisons are complete. Management needs to review and provide additional guidance.",
                @"Marketing strategy is set. R&D needs to deliver a detailed report on product development plans along with final decisions as to which product lines will be terminated.",
                @"Create R&D Plan Report for CEO and include information on products under consideration and final decisions as to which products will be depracated.",
                @"In final stages of the R&D Report to Management. Need QA strategy report asap.",
                @"Need to finalize 2013 Training Events. QA is under pressure to step it up in 2013 and without an effective training strategy for the field, QA problems will persist.",
                @"Review resume and non-compete with previous employer and give final approval to hire John Jeffers.",
                @"Make final decision on whether our employees should sign non-compete agreements.",
                @"Management has approved new NDA. All employees must sign the new NDA and their employee files must be updated.",
                @"You must sign updated NDA. Documents have been emailed to you. Once documents have been signed, please retain one copy for your records and return one to HR for filing.",
                @"The new NDA is now required for employment. I need a list of questions or issues so we can submit all paperwork to HR.",
                @"The new NDA must be signed for continued employment at DevAV. Do not ignore this task as you will be terminated if not signed. The sensitive nature of our job responsibilities demands that we hold ourselves to the highest standards.",
                @"Meeting with Board has been scheduled. Need final sales projections.",
                @"Board requires Revenue Projection Report. Review sales reports and my projections and give final approval before I proceed.",
                @"Board requires Revenue Projection Report. Comment on sales reports and my projections and provide any additional information that might be relevant to management.",
                @"Need to get employees to sign new health insurance documents. Need final paperwork from agents.",
                @"Shipping department must review new health insurance policy and submit paperwork by the end of the month. If not submitted, coverage will terminate.",
                @"HR needs scanned copies of all signed documents for personnel files. Victor, you have to scan them for me as I'm just too busy.",
                @"Kevin asked me to collect all signed health insurance forms for him - he is too busy. Please get this done asap so I can get back to my regular job.",
                @"The problem with the TVs has been confirmed with R&D. We need to immediately follow up with West Coast Retailers and let them know so we do not get any returns.",
                @"The problem with the TVs has been confirmed with R&D. We need to immediately follow up with West Coast Retailers and let them know so we do not get any returns.",
                @"The problem with the TVs has been confirmed with R&D. We need to send an email to all customers who purchased the TV in the last 30 days.",
                @"Need a report on all customers who've been promised a refund as a result of the TV recall.",
                @"Refunds as a result of our TV recalls have been submitted. Need final approval to cut checks to customers.",
                @"Bart, this recall was an absolute disaster. Your report better be on my desk tomorrow. This is killing our bottom-line.",
                @"John, everyone in Engineering is working hard to avoid any future recalls. Can you please review this report and send me your thoughts.",
                @"After the recall, customers have option to purchase new version of TV. You need to prepare training course for our retail partners so they can better understand the design changes.",
                @"Consider this most important item on your agenda. I need this new training material reviewed so it can be submitted to management.",
                @"Way too much overtime being submitted by the IT department please review numbers and get with management and tell me long term decision on this matter.",
                @"You are working too many hours and management wants to stop it. You cannot work this much overtime. Send me the report so I can kick it up to HR. They need you to justify your hours.",
                @"We cannot keep going like this. Everytime my people send overtime request, we get hassled. Can you please send me the definitive guide as to when people can submit overtime?",
                @"We need to update the refund request template as I keep getting asked questions from confused customers. Is this something we can do this week?",
                @"I don’t think we can keep sending our existing rebate forms. Like the refund request forms, customers are confused by all the legal language and they refuse to sign it.",
                @"Ed asked me to get with you and prepare a full report of all questions being asked by customers about the recall and refund request forms. Legal does not want to take any action until we submit this.",
                @"The problems with our recall and refund request forms are real. Sale staff are overwhelmed and are answering the same questions over and over again. Need a solution from legal.",
                @"We've analyzed all complaints submitted to sales staff. The problems are real and a solution is needed. Kicking this up to you John as legal simply will not budge.",
                @"Management needs to see which shipping company is giving us the best bang for our buck. Need the report asap as we have to commit to one shipper soon.",
                @"Need to know which shipping companies you prefer to work. Looks like costs are all coming in the same so I think we just need to pick the one that offers the best services.",
                @"All cost analysis reports have been prepared. I've also submitted personal opinions on all the shippers we've dealt with. We need a final decision so I can negotiate final contract.",
                @"The natives are getting restless. You need to make a final decision on the shipper we are going to go with. I don’t know why we can't choose a single shipper?",
                "Website traffic has doubled. We must upgrade server hardware or customers will continue to experience difficulties ordering. We need a decision by end of month.",
                @"It's end-of-life for Windows XP. We either have to upgrade everyone's computers or upgrade the OS on existing customers. We need a final decision from management to proceed.",
                @"Windows XP is finished and we need to know if we are going to upgrade hardware or simply update OS. IT department has a lot of work ahead of it and the sooner we know, the better it will be for everyone.",
                @"We need to decide whether we are going to use Surface tablets in the field or go with iPad. I've prepared the pros and cons based on feedback from everyon in the IT dept.",
                @"Need to decide if we are going to re-write apps as Metro apps or simply touch-enable our existing apps. Obviously the former is going to take a lot of time.",
                @"Management has decided to stick with existing apps. We simply need to make them touch-enabled for the new Surface Tablets being distributed to the field. Can you get me an estimate?",
                @"I've given the approval to go with touch-based apps on WinForms vs complete re-write. I need your report as to when the apps are going to be ready to deploy to the field.",
                @"The field will get this rolled out next week. You should try the apps on the new Surface tablets and give me your thoughts. We did not re-write anything - the app was already touch-enabled because we used DevExpress UI Controls.",
                @"We are go to rollout the new WinForms apps to all Surface tablets used in the field.",
                @"Need to see site up-time reports. Online sales have taken a big dive and we think it's because the site is not reliable.",
                @"As you'll see by this report, the drop in online sales is not a result of site up-time. You should review this with John and tell me what you want us to do.",
                @"The dip in online sales is not a result of website reliability. The issue is a marketing one and we need to discuss how to update our marketing content so we can get sales back on track.",
                @"Online sales are a disaster. We need to rework our entire marketing message and spend a lot of money on ad-words to generate more traffic to our site. We have great products. I don’t understand the problem.",
                @"We need to do something to stop the fall in online sales right away. Management is putting a lot of pressure on me and I don’t know exactly what to do. Send me a report with your opinions.",
                @"We have prepared a detailed report of all options to improve online sales. We have 3 major recommendations and I need the ok to pursue this with the IT and design teams.",
                @"New marketing strategy has been approved by management. I need a new website design.",
                @"Im in a tough spot as management wants the new design right away. I need you to take the lead and create all the icons we are going to need for the new site. Send it to me asap.",
                @"We've done all we can in the design department. You have all the PSDs. It's now up to you to create and deploy the new online sales portal. Good luck.",
                @"You have the PSDs from the design team. I need the cart updated. Management wants this done immediately.",
                @"You have the PSDs from the design team. I need the product pages updated. Management wants this done immediately.",
                @"Published the new product pages on our sandbox server. Can you take a look and give your thoughts. Is it what you wanted? I'm not sure that I like it that much.",
                @"Everything is in place Robert. You are the final approval for us to launch the new website. Please give me the OK so I can get this done.",
                @"You are good to go Brett. Launch the website and track first day activities. Send me a report once you have everything ready.",
                @"Problems with new website. We did not update shipping profiles and customers have no idea how to update personal information. Can you get on this asap?",
                @"Need a new RMA label for the website. I've requested this a few times but it keeps getting put off. Can we get this completed by the end of the month Brett? It's really important.",
                @"Wally, you are point to create the new RMA labels for the website. We are under pressure from the shipping department to get this done by month's end. Get with the design department and deploy it by the end of the month.",
                @"Violet, Im behind the 8 ball on this one. I need a new design for our RMA labels. Can you please send me the artwork. I've uploaded the specs to the server.",
                @"Getting a lot of complaints from users about slow connection speeds. I've checked with our ISP and we can upgrade to a faster access plan.",
                @"Our ISP is not willing to upgrade our access plan because they are concerned about our payment history. Sandra, please get them our D&B # so they can check our credit history.",
                @"ISP is being difficult and refusing to increase our bandwidth because they say our credit is not good. Can you please get in touch with Herb Heart and resolve this. I don’t have much more information that I can provide them.",
                @"Need a summary of all major support issues we encountered this year. This report will be presented to management. You are the point person on this James.",
                @"We are being pushed to get the a support issues report delivered before year end. Can you aggragate all of our data so I can compile it and send it over to Barb?",
                @"Just getting ready to push out some new training material for our customers so they can better understand how our product line fits together.  Can I get a review of the content so I can send it out to the printer?",
                @"Please distribute new training material to all support staff. The information is very useful and I believe it will help us address issues in a more effective manner.",
                @"I am in the process of publishing my new training material. It will be posted to the server. Please see that all support engineers have access to them.",
                @"We need to get new artwork and PDFs for the support team. We are currently using out-dated materials. Can you please publish them on our server…",
                @"Violet, please get all our new art published so that other teams can use them as necessary. I asked you to do this a week ago.",
                @"Please replace all artwork / brochures / media being used for sales presentations with new materials produced by the graphic design team. If you have questions, ask me.",
                @"Need to receive 1000 new brochures so I can begin distributing it out to customer accounts that I manage. I've stopped using old brochures. Please forward new brochures to me asap.",
                @"We need new brochures sent out to Todd Hoffman. It's urgent as we are no longer using older brochures and he has sales calls to make.",
                @"Going directly to you Amelia as Brett is out of the office. We have to update the server with newest service pack. This is highest priority.",
                @"We are go on the new database. I need you to get it installed so we can begin company wide roll-out.",
                @"Submitted my overtime request to you for approval so I can walk it down to HR before the year end paycheck. I had no choice…I had to work overtime to get the database rolled out.",
                @"This is already delayed too long. I need your report on the new HDMI specification and how we plan on getting to market.",
                @"My report is not complete and in order to complete it, I need approval to invest $250K on new tooling for HDMI 2.",
                @"I need to see if this is a market we should enter and unless I get a spike, I wont know what to report to CEO.",
                @"Need a detailed report on retail sales strategy for 2014. Management wants to significantly increase revenues this year and retail is our primary focus.",
                @"Need your eyes on the new Automation Server product. I'm having performance issues and you have to figure out what is causing it.",
                @"I have not received your feedback on my new training course. Can you please send me an email asap so I can consider your comments?",
                @"Im missing all invoices for this month and I cannot reconcile until I get them. Kevin, please remember to do this on a regular basis.",
                @"Need to discuss new retail strategies with sales team. Please coordinate everything and make sure everyone is present.",
                @"I've called you a few times Hannah, but no response. Retail sales meeting is mandatory but I'm told you are going to be out of town. Please advise.",
                @"Is unable to attend the meeting and unless you want to go without her, you will need to reschedule this.",
                @"Running a contest in my region and will be giving away 2 remote controls. Can you send them to me asap.",
                @"Please refer to my Email. We are doing a giveaway in Clark's region and we need to send 2 remotes.",
                @"Need a final decision if we are going to be doing more product giveaways at tradeshows so I can coordinate with shipping department.",
                @"Need you to send Emails to everyone who purchased a product online in the last week. We want to test whether this yields a sales improvement.",
                @"Been told that all desktops on the third floor have to be replaced. We are being asked to do it because of workload in IT dept.",
                @"I'm told you have all new leads from the tradeshow. Can you please update the database so I can begin my follow-ups.",
                @"I know you have no time to update the database yourself, but can you please forward the leads to me by mail so I an take care of my follow-ups?",
                @"Need you to create a spreadsheet with sales by territory and forward it to CEO. He is on vacation and does not have access to VPN.",
                @"Per discussion, I need territory sales report by EOD.",
                @"Need to see the number of returns this month as I'm told by accounting that our refunds are through the roof. What is the problem Arthur?",
                @"Under a lot of pressure from CEO to figure out cause of refunds. Need you to send me a state of engineering dept report so we can get to the bottom of the problems.",
                @"We might need to cut back on your budget so can you send me staff productivity report so I can send it over to the CEO",
                @"Need to do a top to bottom review on our payroll and figure out where we can cut costs.",
                @"I really need you to send me your budget report because CEO is looking to make changes and I'm stuck without your help.",
                @"I really need you to send me your budget report because CEO is looking to make changes and I'm stuck without your help.",
                @"You are usually really good at getting me this information but you have not done it this year. Being pressured by CEO to deliver final report. Please forward your budget report to me.",
                @"Please see subject. You have to send me your budget report otherwise you may end up with cut-backs.",
                @"Have complaints from management that travel costs are just too high. I need you to send me over your detailed report.",
                @"Negotiated a great new deal for health insurance. I need to get approval from you.",
                @"We need to get together and review the budget before kicking it up to John. I need you to take a look at what I sent and give me your thoughts.",
                @"I'm dissapointed you have not sent this report over to me. You know we are trying to manage a crisis and it does not help when you are not proactive.",
                @"You are the only one who has not sent me the report I requested in our meeting. I need you to send it to me asap.",
                @"Get with graphic design and let's reprint all of our shipping labels. I want to use a new font.",
                @"Wants new shipping labels and I cannot print them without the artwork from your team. Can you please hurry and send it to me.",
                @"We got your specs and we've started the redesign. We are confused by a few things and need you to reply to our Email with detailed information.",
                @"You are going to have to coordinate the move. All packaging materials are your responsibility. You can hire temp workers if needed.",
                @"You are point person to get all inventory moved to the new warehouse location. You can hire temp workers if needed.",
                @"We cannot have the forklift continue to breakdown Victor. You know this is your responsibility and I want you to go out and get it fixed.",
                @"Do we have the ok to get a forklift rental. I still don’t know when our forklift is going to be fixed and I'm worried it might take a long time.",
                @"I cannot wait on your approval any longer. My staff is lifting boxes and everyone's back is starting to hurt. We need you to ok this.",
                @"The overtime I submitted was not paid and I'm being told it was not approved. I thought you approved this. What is the problem?",
                @"Planning a trip with the family for 2 weeks. Can you give me the ok so I can submit this to HR?",
                @"I am told by Bart that we have a salary freeze and that my request for an increase in salary is on hold. Please approve this request. I work very hard and deserve to be paid more.",
                @"We are getting a lot of complaints sent to the Consumer Affairs dept. Can you please reivew the report I sent you and send me your thoughts as to how we can deal with all this.",
                @"A lot of the reports about the website are related to uptime. You need to review this document and send and Email to me and Ken so we can deal with the Consumer Affairs Dept.",
                @"I don’t know who else to get help from. The automation app is not synchronizing anything so I'm stuck until I get this fixed. I need to finish my testing. Please look at the log report and send Email with info.",
                @"I need you to tell me where I'm going to be able to install our new application set for management's review. As it stands, I'm being blamed for the delay, but it's not my fault.",
                @"We keep getting bounced off the network and we cant get our job done. Can you please replace this old router so we can get things done?",
                @"It's your responsibility to maintain personal profile on site. I've asked you repeatedly. Is there a problem or something I can help with?",
                @"They had some great things to say about your support follow up. Please schedule a conf call with them. I want to see if we can do a case study for our website.",
                @"Can we get together and finish our evaluation of the support team.",
                @"I cannot deploy the apps manually. I need you to create an installer so we can get the apps installed on all desktops without manual configuration.",
                @"We have a shipment from one of our PC vendors in the warehouse. Can you please pick these up as we do not have anyone who can deliver them to you.",
                @"You sent me some receipts by Email but in order for me to get you a payment for expenses, I need your expense report.",
                @"Need you to join me on our upcoming roadtrip to San Francisco. We are going to visit a few stores and help out with product staging.",
                @"We are heading out to San Francisco. Planned schedule has been emailed. Please book us flights asap. Please also use my frequent flier #.",
                @"We are updating our website again with customer reviews. Need you to contact 10 customers and get feedback and authorization to publish their thoughts on our website.",
                @"We cannot update your personnel file and we cannot change your exemptions until you sign your W4 form. Can you get that done soon?",
                @"Just called the airline for your Jim and they told me they cancelled your frequent flier account. You need to call them yourself and get a new account. As soon as I get it, I will send it to travel dept.",
                @"I've created a detailed follow up with all of our customers. This will help us with retention. Please review and give me OK so I can push it out to the field.",
                @"Forwarded Ken's new follow up plan to you by email. Need your opinions on it asap so we can get things nailed down in the upcoming months.",
                @"We have a stack of issues with the new apps that you need to review and fix asap. I've logged everything in the db. Give me your thoughts.",
                @"We are creating a new section on our website for video interviews. Contact a few customers and see if they are willing to record a video review for us.",
                @"I lost your expense reimbursement documents so I'm going to need you to send them to me by Email so this can get paid in this week's check run.",
                @"I need to take some time off. My back hurts from lifting all these boxes. Can you please approve my vacation.",
                @"We cannot fix our products until we get the test report from you. Please send everything you have by email to me so I can distribute it in the engineering dept.",
                @"I've not seen last month's flight expense report. Please forward it to me as I cannot reconcile our accounts without them.",
                @"Wants new shipping labels and I cannot print them without the artwork from your team. Can you please hurry and send it to me.",
                @"Im behind the 8 ball on this one. I need a new design for our RMA labels. Can you please send me the artwork. I've uploaded the specs to the server.",
                @"Need you to send Emails to everyone who purchased a product online in the last week. We want to test whether this yields a sales improvement.",
                @"Need sign-off on the new NDA agreement. It's important that this is done quickly to prevent any unauthorized leaks.",
                @"We have to get on this ASAP.  Use standard reporting system to detail bugs.",
                @"Sam please review training content submitted by Leah.  We need to be sure everything is included in the packet.",
                @"We have 32 people registered for training in Orlando.  We need to get a bigger space.",
                @"I need the upddated specs for the Automation App so I can be sure we are all on the same page.",
                @"I need updated business cards with our new address.",
                @"I moved and I need to fill out an address change form for our insurance.  Can I download a PDF online or can you email the form.",
                @"Can we set a time to go over the new changes?  I need to be brought up to speed ASAP",
                @"I need a flight arranged for the tradeshow in Altlanta.  Prefer window seat near the front of the plane.",
                @"Review the 5 point marketing plan in place for customer communications.  I will put together an email once done so everyone is on the same page.",
                @"Submitted request for per diem.",
                @"Please send me the changes to our health insurance plan so I can send an email to all employees",
                @"Send around sheet for lunch potluck",
                @"It will take about an hour to go over your benefits.  Please plan accordingly.",
                @"We need to do a conflict resolution and mediation training session with Engineering.  No more than 1 day.",
                @"Greta can you send me a report for January complaints.",
                @"Did you get through the articles on Improving Skill and Confidence",
                @"Provide points as to why NDA was rejected so we can have legal revise please",
                @"I need the last 3 months of expeses.  Please group by department so we can see a complete picture ASAP",
                @"Wants me to get with you to pull sales numbers by terriorty.",
                @"Can you send me all the leads you were unable to contact.  I will follow-up.",
                @"Send me a list of all materials needed for this event including any documention of all outstanding issues.",
                @"Will I need to cover all NW territory contacts while Harv is on vacation.  Please forward list ASAP",
                @"I missed the last half of the meeting.  Can you shoot me over a list of interested parties to review online sales.",
                @"I need an itemized list of everything moving to the new warehouse next week.",
                @"Please remember to use standard shipping and forward reciept to Sandy.",
                @"The shipping companies want to do a walk through before they quote us.  I've scheduled a time to do this with each company",
                @"We are missing 3 employees health insurance forms.  I sent you a revised list.  Please follow-up ASAP",
                @"I've sent you my first draft revisions to the training manual.  Can you update and send me a revised version.",
                @"I have a few customers interested in doing a video.  Can you send me an ouline for video content"
        };
    }
    public class Employee {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName { get; set; }
        string initials = null;
        public string Initials {
            get {
                if(initials == null) {
                    string first = string.IsNullOrEmpty(FirstName) ? string.Empty : FirstName[0].ToString().ToUpper();
                    string last = string.IsNullOrEmpty(LastName) ? string.Empty : LastName[0].ToString().ToUpper();
                    initials = first + last;
                }
                return initials;
            }
        }

        public static List<Employee> Employees = new List<Employee>() {
            new Employee() { LastName = "Heart", FirstName = "John", FullName = "John Heart" },
            new Employee() { LastName = "Bright", FirstName = "Samantha", FullName = "Samantha Bright" },
            new Employee() { LastName = "Miller", FirstName = "Arthur", FullName = "Arthur Miller" },
            new Employee() { LastName = "Reagan", FirstName = "Robert", FullName = "Robert Reagan" },
            new Employee() { LastName = "Sims", FirstName = "Greta", FullName = "Greta Sims" },
            new Employee() { LastName = "Wade", FirstName = "Brett", FullName = "Brett Wade" },
            new Employee() { LastName = "Johnson", FirstName = "Sandra", FullName = "Sandra Johnson" },
            new Employee() { LastName = "Holmes", FirstName = "Edward", FullName = "Ed Holmes" },
            new Employee() { LastName = "Banks", FirstName = "Barbara", FullName = "Barb Banks" },
            new Employee() { LastName = "Carter", FirstName = "Kevin", FullName = "Kevin Carter" },
            new Employee() { LastName = "Stanwick", FirstName = "Cynthia", FullName = "Cindy Stanwick" },
            new Employee() { LastName = "Hill", FirstName = "Sam", FullName = "Sammy Hill" },
            new Employee() { LastName = "Jones", FirstName = "David", FullName = "Davey Jones" },
            new Employee() { LastName = "Norris", FirstName = "Victor", FullName = "Victor Norris" },
            new Employee() { LastName = "Stern", FirstName = "Mary", FullName = "Mary Stern" },
            new Employee() { LastName = "Cosworth", FirstName = "Robin", FullName = "Robin Cosworth" },
            new Employee() { LastName = "Rodriguez", FirstName = "Kelly", FullName = "Kelly Rodriguez" },
            new Employee() { LastName = "Anderson", FirstName = "James", FullName = "James Anderson" },
            new Employee() { LastName = "Remmen", FirstName = "Anthony", FullName = "Antony Remmen" },
            new Employee() { LastName = "Peyton", FirstName = "Olivia", FullName = "Olivia Peyton" },
            new Employee() { LastName = "Riley", FirstName = "Taylor", FullName = "Taylor Riley" },
            new Employee() { LastName = "Harper", FirstName = "Amelia", FullName = "Amelia Harper" },
            new Employee() { LastName = "Hobbs", FirstName = "Walter", FullName = "Wally Hobbs" },
            new Employee() { LastName = "Jameson", FirstName = "Bradley", FullName = "Brad Jameson" },
            new Employee() { LastName = "Goodson", FirstName = "Karen", FullName = "Karen Goodson" },
            new Employee() { LastName = "Orbison", FirstName = "Marcus", FullName = "Marcus Orbison" },
            new Employee() { LastName = "Bright", FirstName = "Sandra", FullName = "Sandy Bright" },
            new Employee() { LastName = "Kennedy", FirstName = "Morgan", FullName = "Morgan Kennedy" },
            new Employee() { LastName = "Bailey", FirstName = "Violet", FullName = "Violet Bailey" },
            new Employee() { LastName = "Samuelson", FirstName = "Kent", FullName = "Ken Samuelson" },
            new Employee() { LastName = "Maguirre", FirstName = "Natalie", FullName = "Nat Maguiree" },
            new Employee() { LastName = "Arnaz", FirstName = "Bart", FullName = "Bart Arnaz" },
            new Employee() { LastName = "Simpson", FirstName = "Leah", FullName = "Leah Simpson" },
            new Employee() { LastName = "Schwartz", FirstName = "Arnold", FullName = "Arnie Schwartz" },
            new Employee() { LastName = "Zimmer", FirstName = "William", FullName = "Billy Zimmer" },
            new Employee() { LastName = "Piper", FirstName = "Samantha", FullName = "Samantha Piper" },
            new Employee() { LastName = "Boxter", FirstName = "Margaret", FullName = "Maggie Boxter" },
            new Employee() { LastName = "Bradley", FirstName = "Terry", FullName = "Terry Bradley" },
            new Employee() { LastName = "Jones", FirstName = "Gabriel", FullName = "Gabe Jones" },
            new Employee() { LastName = "Ball", FirstName = "Lucy", FullName = "Lucy Ball" },
            new Employee() { LastName = "Packard", FirstName = "James", FullName = "Jim Packard" },
            new Employee() { LastName = "Brooklyn", FirstName = "Hannah", FullName = "Hannah Brookly" },
            new Employee() { LastName = "Mudd", FirstName = "Harvey", FullName = "Harv Mudd" },
            new Employee() { LastName = "Morgan", FirstName = "Clark", FullName = "Clark Morgan" },
            new Employee() { LastName = "Hoffman", FirstName = "Todd", FullName = "Todd Hoffman" },
            new Employee() { LastName = "Garmin", FirstName = "Jack", FullName = "Jackie Garmin" },
            new Employee() { LastName = "Bartlett", FirstName = "Lincoln", FullName = "Lincoln Bartlett" },
            new Employee() { LastName = "Farkus", FirstName = "Brad", FullName = "Brad Farkus" },
            new Employee() { LastName = "Hobbs", FirstName = "Jennifer", FullName = "Jenny Hobbs" },
            new Employee() { LastName = "Lou", FirstName = "Dallas", FullName = "Dallas Lou" },
            new Employee() { LastName = "Pizaro", FirstName = "Stu", FullName = "Stu Pizaro" }
        };
    }
}
