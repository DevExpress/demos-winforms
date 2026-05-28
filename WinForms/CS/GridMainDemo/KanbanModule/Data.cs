using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using DevExpress.Internal;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;

namespace DevExpress.XtraGrid.Demos {
    public class KanbanHelper {
        public static BindingList<TaskRecord> LoadTasks() {
            string file = DataDirectoryHelper.GetDataFile(Path.Combine("KanbanModuleData", "KanbanTasks.xml"));
            var _tasks = new BindingList<TaskRecord>();
            using(var reader = new StreamReader(file)) {
#pragma warning disable DX0008 // deserialized only a predefined type
                XmlSerializer deserializer = new XmlSerializer(typeof(TaskList), new XmlRootAttribute("DocumentElement"));
                var taskList = (TaskList)deserializer.Deserialize(reader);
#pragma warning restore DX0008
                _tasks = taskList.List;
            }
            LoadImages(_tasks);
            return _tasks;
        }
        static void LoadImages(BindingList<TaskRecord> taskList) {
            foreach(var task in taskList) {
                if(!String.IsNullOrEmpty(task.ImagePath)) {
                    string file = DataDirectoryHelper.GetDataFile(Path.Combine("KanbanModuleData", "Images", task.ImagePath));
                    if(File.Exists(file))
                        task.AttachedImage = Image.FromFile(file);
                }
            }
        }
        public static DataTable LoadChecklist() {
            string file = DataDirectoryHelper.GetDataFile(Path.Combine("KanbanModuleData", "KanbanChecklist.xml"));
            var checklist = new DataTable();
            checklist.TableName = "TaskChecklist";
            checklist.Columns.Add("TaskID", typeof(Guid));
            checklist.Columns.Add("Caption", typeof(String));
            checklist.Columns.Add("Checked", typeof(Boolean));
            if(!String.IsNullOrEmpty(file) && System.IO.File.Exists(file)) {
                checklist.ReadXml(file);
            }
            return checklist;
        }
        public static DataTable LoadMembers() {
            string file = DataDirectoryHelper.GetDataFile(Path.Combine("KanbanModuleData", "KanbanMembers.xml"));
            var members = new DataTable();
            members.TableName = "TaskMembers";
            members.Columns.Add("TaskID", typeof(Guid));
            members.Columns.Add("MemberID", typeof(Int32));
            if(!String.IsNullOrEmpty(file) && System.IO.File.Exists(file)) {
                members.ReadXml(file);
            }
            return members;
        }
        public static DataTable LoadEmployees() {
            string DBFileName = string.Empty;
            string connectionString = string.Empty;
            DBFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if(String.IsNullOrEmpty(DBFileName))
                return null;
            DataSet ds = new DataSet();
            ds.ReadXml(DBFileName);
            var table = ds.Tables["Employees"];
            table.PrimaryKey = new DataColumn[] { table.Columns["EmployeeID"] };
            return table;
        }
        public static void UpdateMembersGlyph(DataTable employees, ISkinProvider skinProvider, int size) {
            for(int i = 0; i < employees.Rows.Count; i++) {
                var row = employees.Rows[i];
                char a = (row["FirstName"] as string)[0];
                char b = (row["LastName"] as string)[0];
                string text = string.Format("{0}{1}", a, b);
                byte[] glyphbytes;

                Bitmap glyph = GlyphPainter.CreateRoundedStubGlyph(skinProvider, new Size(size, size), text);
                using(MemoryStream ms = new MemoryStream()) {
                    glyph.Save(ms, ImageFormat.Png);
                    glyphbytes = ms.ToArray();
                    ms.Close();
                }
                row["Photo"] = glyphbytes;
            }
        }
        public static TaskRecord CreateNewTask() {
            return new TaskRecord();
        }
    }

    public enum TaskStatus { ToDo, Planned, Doing, Testing, Done }
    public enum TaskLabel { None, Red, Yellow, Green }

    public class TaskRecord {
        public TaskRecord() {
            Label = TaskLabel.None;
        }
        public Guid Id { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public Image AttachedImage { get; set; }
        [XmlIgnore]
        public TaskStatus Status { get; set; }
        [XmlIgnore]
        public TaskLabel Label { get; set; }
        [XmlElement("Status")]
        public int StatusCore {
            get { return (int)Status; }
            set { Status = (TaskStatus)value; }
        }
        [XmlElement("Label")]
        public int LabelCore {
            get { return (int)Label; }
            set { Label = (TaskLabel)value; }
        }
    }

    [XmlRoot("DocumentElement")]
    public class TaskList {
        public TaskList() {
            List = new BindingList<TaskRecord>();
        }
        [XmlElement("Tasks")]
        public BindingList<TaskRecord> List { get; set; }
    }
}
