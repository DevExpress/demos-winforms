using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Logify;
using DevExpress.Utils;
using DevExpress.XtraScheduler.Outlook;
using DevExpress.XtraScheduler.Outlook.Interop;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos {
    /// <summary>
    /// Summary description for DemoUtils.
    /// </summary>
    public class DemoUtils {
        public const string aptDataResourceName = "Data.appointments.xml";
        public const string resDataResourceName = "Data.resources.xml";
        public const string aptReportDataResourceName = "Data.ReportAppointments.xml";
        public const string resReportDataResourceName = "Data.ReportResources.xml";
        public const string sportEventsResourceName = "Data.sportevents.xml";

        public static string[] Users = new string[] { "Peter Dolan", "Ryan Fischer", "Andrew Miller", "Tom Hamlett",
                                                        "Jerry Campbell", "Carl Lucas", "Mark Hamilton", "Steve Lee" };

        static string[] taskDescriptions = new string[] {
                                                   "Implementing DevExpress MasterView control into Accounting System.",
                                                   "Web Edition: Data Entry Page. The issue with date validation.",
                                                   "Payables Due Calculator. It is ready for testing.",
                                                   "Web Edition: Search Page. It is ready for testing.",
                                                   "Main Menu: Duplicate Items. Somebody has to review all menu items in the system.",
                                                   "Receivables Calculator. Where can I found the complete specs",
                                                   "Ledger: Inconsistency. Please fix it.",
                                                   "Receivables Printing. It is ready for testing.",
                                                   "Screen Redraw. Somebody has to look at it.",
                                                   "Email System. What library we are going to use?",
                                                   "Adding New Vendors Fails. This module doesn't work completely!",
                                                   "History. Will we track the sales history in our system?",
                                                   "Main Menu: Add a File menu. File menu is missed!!!",
                                                   "Currency Mask. The current currency mask in completely inconvinience.",
                                                   "Drag & Drop. In the schedule module drag & drop is not available.",
                                                   "Data Import. What competitors databases will we support?",
                                                   "Reports. The list of incomplete reports.",
                                                   "Data Archiving. This features is still missed in our application",
                                                   "Email Attachments. How to add the multiple attachment? I did not find a way to do it.",
                                                   "Check Register. We are using different paths for different modules.",
                                                   "Data Export. Our customers asked for export into Excel"};


        public static DateTime Date = new DateTime(2016, 6, 15);
        public static PrintColorSchema ReportPrintColorSchema = PrintColorSchema.FullColor;

        static string[] _outlookCalendarPaths = null;

        public static string[] OutlookCalendarPaths {
            get {
                if (_outlookCalendarPaths != null)
                    return _outlookCalendarPaths;
                try {
                    _outlookCalendarPaths = OutlookExchangeHelper.GetOutlookCalendarPaths();
                } catch (System.Exception e) {
                    ReportOutlookError("get the list of available calendars from Microsoft Outlook", e.Message);
                    _outlookCalendarPaths = new string[0];
                }
                return _outlookCalendarPaths;
            }
        }

        public static void FillData(SchedulerControl control) {
            control.DataStorage.EnableReminders = false;
            FillStorageData(control.DataStorage);
            control.Start = Date;
            DayView dayView = control.ActiveView as DayView;
            if (dayView != null)
                dayView.TopRowTime = TimeSpan.FromHours(9);
            //control.OptionsBehavior.ShowRemindersForm = false;
        }
        public static void FillResources(ISchedulerStorage storage, int count) {
            ResourceCollection resources = storage.Resources.Items;
            storage.BeginUpdate();
            try {
                int cnt = Math.Min(count, Users.Length);
                for (int i = 1; i <= cnt; i++) {
                    Resource resource = storage.CreateResource(i);
                    resource.Caption = Users[i - 1];
                    resources.Add(resource);
                }
            } finally {
                storage.EndUpdate();
            }
        }
        public static void FillAppointmentStatuses(SchedulerStorage storage) {
            storage.BeginUpdate();
            try {
                AppointmentStatusCollection statuses = storage.Appointments.Statuses;
                statuses.Clear();
                statuses.Add(Color.White, "Free", "Free");
                statuses.Add(Color.SkyBlue, "Wash", "Wash");
                statuses.Add(Color.SteelBlue, "Maintenance", "Maintenance");
                statuses.Add(Color.YellowGreen, "Rent", "Rent");
                statuses.Add(Color.Coral, "CheckUp", "CheckUp");
            } finally {
                storage.EndUpdate();
            }

        }
        public static void FillStorageData(ISchedulerStorage storage) {
            storage.BeginUpdate();
            try {
                FillStorageCollection(storage.Resources.Items, resDataResourceName);
                FillStorageCollection(storage.Appointments.Items, aptDataResourceName);
            }
            finally {
                storage.EndUpdate();
            }
        }
        public static void FillReportsStorageData(ISchedulerStorage storage) {
            FillStorageCollection(storage.Resources.Items, resReportDataResourceName);
            FillStorageCollection(storage.Appointments.Items, aptReportDataResourceName);
        }
        public static void FillStorageResources(ISchedulerStorage storage) {
            FillStorageCollection(storage.Resources.Items, resDataResourceName);
        }

        public static string FindResourceName(string resourceName) {
            string[] resourceNames = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();
            if (resourceNames.Contains(resourceName))
                return resourceName;
            int indx = resourceName.IndexOf('.');
            if (indx < 0 || indx == resourceName.Length - 1)
                return "";
            return FindResourceName(resourceName.Substring(indx + 1));
        }

        static Stream GetResourceStream(string resourceName) {
            Stream result = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName);
            if (result != null)
                return result;

            string languageString = DemoHelper.GetLanguageString(typeof(frmMain).Assembly);
            if (languageString == "CS")
                return result;
            int indx = resourceName.IndexOf(".");
            if (indx < 0 || indx == resourceName.Length - 1)
                return result;
            return GetResourceStream(resourceName.Substring(indx + 1));
        }


        static void FillStorageCollection(AppointmentCollection c, string resourceName) {
            using (Stream stream = GetResourceStream(resourceName)) {
                c.ReadXml(stream);
                stream.Close();
            }
        }
        static void FillStorageCollection(ResourceCollection c, string resourceName) {
            using (Stream stream = GetResourceStream(resourceName)) {
                c.ReadXml(stream);
                stream.Close();
            }
        }
        public static void SetConnectionString(System.Data.OleDb.OleDbConnection oleDbConnection, string path) {
            oleDbConnection.ConnectionString = String.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;User ID=Admin;Data Source={0};Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SFP=False", path);
        }
        public static string GetFileRelativePath(string fileName) {
            return GetRelativePath(fileName, false);
        }
        public static string GetFolderRelativePath(string fileName) {
            return GetRelativePath(fileName, true);
        }
        static string GetRelativePath(string name, bool isFolder) {
            name = "Data\\" + name;
            string path = System.Windows.Forms.Application.StartupPath;
            string s = "\\";
            for (int i = 0; i <= 10; i++) {
                if (IsObjectExists(path + s + name, isFolder))
                    return (path + s + name);
                else
                    s += "..\\";
            }
            return "";
        }
        static bool IsObjectExists(string name, bool isFolder) {
            if (isFolder)
                return System.IO.Directory.Exists(name);
            else
                return System.IO.File.Exists(name);
        }

        public static CheckState TimeVisibilityToCheckState(AppointmentTimeVisibility visibility) {
            if (visibility.Equals(AppointmentTimeVisibility.Always))
                return CheckState.Checked;
            if (visibility.Equals(AppointmentTimeVisibility.Never))
                return CheckState.Unchecked;
            return CheckState.Indeterminate;
        }
        public static AppointmentTimeVisibility CheckStateToTimeVisibility(CheckState state) {
            if (state.Equals(CheckState.Checked))
                return AppointmentTimeVisibility.Always;
            if (state.Equals(CheckState.Unchecked))
                return AppointmentTimeVisibility.Never;
            return AppointmentTimeVisibility.Auto;
        }

        public static DataTable GenerateScheduleTasks() {
            DataTable tbl = new DataTable();
            tbl = new DataTable("ScheduleTasks");
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Subject", typeof(string));
            tbl.Columns.Add("Severity", typeof(int));
            tbl.Columns.Add("Priority", typeof(int));
            tbl.Columns.Add("Duration", typeof(int));
            tbl.Columns.Add("Description", typeof(string));
            for (int i = 0; i < 21; i++) {
                string description = taskDescriptions[i];
                int index = description.IndexOf('.');
                string subject;
                if (index <= 0)
                    subject = "task" + Convert.ToInt32(i + 1);
                else
                    subject = description.Substring(0, index);
                tbl.Rows.Add(new object[] { i + 1, subject, TutorialConstants.Random.Next(3), TutorialConstants.Random.Next(3), Math.Max(1, TutorialConstants.Random.Next(8)), description });
            }
            return tbl;
        }
        public static DataTable GetSportEventsData() {
            DataSet sportEventDS = new DataSet();
            using (Stream stream = GetResourceStream(sportEventsResourceName)) {
                sportEventDS.ReadXml(stream);
                stream.Close();
            }
            return sportEventDS.Tables[0];
        }
        public static string FormatAppointmentString(Appointment apt) {
            if (apt == null)
                return "Null";
            return String.Format("[{0}] {1}", apt.Type, apt.Subject);
        }
        public static string FormatOutlookAppointmentString(_AppointmentItem olApt) {
            if (olApt == null)
                return "Null";

            string isRecurring = olApt.IsRecurring ? "Recurring" : "NonRecurring";
            return String.Format("[{0}] {1}", isRecurring, olApt.Subject);
        }
        public static void ReportOutlookError(string message, string exceptionMessage) {
            DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("Failed to {0}. An exception has occured:\r\n{1}", message, exceptionMessage), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string GetLanguageString() {
            string result = DemoHelper.GetLanguageString(typeof(frmMain).Assembly);
            if (result == "CS")
                result = "C#";
            return result;
        }
    }

    public class SchedulerDemoLogify : ILogifyCustomDataProvider {

        public static void Register() {
            LogifyState.Instance.AddCustomDataProvider(new SchedulerDemoLogify());
        }

        void ILogifyCustomDataProvider.CollectCustomData(IDictionary<string, string> data) {
            CollectCustomData(data);
        }

        public void CollectCustomData(System.Collections.Generic.IDictionary<string, string> data) {
            Size dpi = ScaleUtils.GetSystemDPI();
            data.Add("dpi", String.Format("{0} : {1}", dpi.Width, dpi.Height));
            data.Add("skin name", String.Format("{0}", DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName));
            data.Add("module", ModulesInfo.CurrentModuleInfo.Name);
        }
    }

}
