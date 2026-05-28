using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGantt.Options;

namespace DevExpress.XtraGantt.Demos {
    public partial class LargeDataSource : TutorialControl {
        public LargeDataSource() {
            InitializeComponent();
            ganttControl1.ChartStartDate = new DateTime(2020, 2, 17);
            ganttControl1.ChartFinishDate = new DateTime(2020, 11, 5);
            LoadData();
        }

        void LoadData() {
            //ganttControl1.OptionsBehavior.PopulateServiceColumns = true;
            ganttControl1.LoadingPanelVisible = true;
            btngenerate.Enabled = false;
            var uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            System.Threading.Tasks.Task.Factory.StartNew(() => DataGenerator.Generate(TasksCount)).ContinueWith(load => {
                //this.ganttControl1.BeginUpdate();
                this.ganttControl1.ChartMappings.StartDateFieldName = "Start";
                this.ganttControl1.ChartMappings.DurationFieldName = "Duration";
                this.ganttControl1.ChartMappings.PredecessorsFieldName = "Predecessors";
                this.ganttControl1.KeyFieldName = "UID";
                this.ganttControl1.ParentFieldName = "ParentUID";
                this.ganttControl1.ChartMappings.TextFieldName = "Name";
                this.ganttControl1.DataSource = null;
                this.ganttControl1.DataSource = load.Result;
                this.ganttControl1.ExpandAll();
                this.ganttControl1.LoadingPanelVisible = false;
                this.btngenerate.Enabled = true;
                //this.ganttControl1.EndUpdate();
            }, uiScheduler);
        }
        public override GanttControl MainControl {
            get { return ganttControl1; }
        }
        public override bool AllowPrintOptions {
            get { return false; }
        }
        public override bool AllowGenerateReport {
            get { return false; }
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] {"LargeDataSource"}; }
        }
        int TasksCount {
            get {
                if(ceValue1.Checked)
                    return 100000;
                if(ceValue2.Checked)
                    return 500000;
                if(ceValue3.Checked)
                    return 1000000;
                return (int) customTasksCount.Value;
            }
        }
        void seCustomRecordsCount_Enter(object sender, EventArgs e) {
            ceCustom.Checked = true;
        }
        void ceTask_CheckedChanged(object sender, EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            if(!ce.Checked)
                return;
            if(ce != ceCustom) {
                LoadData();
            }
        }

        private void btngenerate_Click(object sender, EventArgs e) {
            ceCustom.Checked = true;
            LoadData();
        }
    }

    public class Task {
        public int UID { get; set; }
        public int ParentUID { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public TimeSpan Duration { get; set; }
        public IList<int> Predecessors { get; set; }
    }

    static class DataGenerator {
        static List<Task> generated = new List<Task>(100000);
        static string[] courses = new[] {"World History", "Economics", "Chemistry", "Biology", "Physics", "Cosmology", "Astronomy", "BioChemistry", "Classics", "English", "Political Science", "Marketing", "Accounting", "Education", "Communications", "Public Administration", "Architecture", "Business Admin", "Engineering", "Materials Science", "Anthropology", "Archaeology", "Egyptology", "Mathematics", "Astrophysics", "Oceanic Sciences", "Legal Studies", "Linguistics", "Computer Science", "BioPhysics", "Art History", "Molecular Biology", "Music", "Neuroscience", "Ecology", "Data Science", "Civil Engineering", "Electrical Engineering", "Climatology", "Geology", "Social Studies", "Psychology", "Psychiatry", "Urban Planning", "Theater", "Sociology", "Social Welfare", "Statistics", "Logic", "Philosophy", "European Studies", "Mid-East Studies", "Far-East Studies", "Genetics", "Film & TV", "Applied Science"};
        static string[] courseModules = new[] {"Overview and Introduction", "Module One", "Module Two", "Module Three", "Module Four", "Module Five", "Module Six", "Module Seven", "Module Eight", "Final Module", "Review and Final Exam Prep"};
        static TimeSpan[] durations = new[] { new TimeSpan(8, 0, 0), new TimeSpan(16, 0, 0), new TimeSpan(8, 0, 0), new TimeSpan(24, 0, 0), new TimeSpan(8, 0, 0), new TimeSpan(8, 0, 0), new TimeSpan(16, 0, 0), new TimeSpan(40, 0, 0), new TimeSpan(24, 0, 0), new TimeSpan(8, 0, 0), new TimeSpan(0, 0, 0)};
        static DateTime[] dateTime = new[] { new DateTime(2020, 04, 02), new DateTime(2020, 04, 03), new DateTime(2020, 04, 07), new DateTime(2020, 04, 8), new DateTime(2020, 04, 13), new DateTime(2020, 04, 14), new DateTime(2020, 04, 15), new DateTime(2020, 04, 17), new DateTime(2020, 04, 24), new DateTime(2020, 04, 29), new DateTime(2020, 4, 29, 17, 0, 0, 0) };
        public static List<Task> Generate(int count) {
            generated.Clear();
            generated.Add(new Task() { UID = 0, ParentUID = -1, Name = "Company training", Start = new DateTime(2020, 2, 17), Duration = new TimeSpan(488, 0, 0) });
            generated.Add(new Task() { UID = 1, ParentUID = 0, Name = "Preparation stage", Start = new DateTime(2020, 2, 17), Duration = new TimeSpan(264, 0, 0) });
            generated.Add(new Task() { UID = 2, ParentUID = 1, Name = "Define objectives", Start = new DateTime(2020, 2, 17), Duration = new TimeSpan(16, 0, 0) });

            generated.Add(new Task() { UID = 3, ParentUID = 1, Name = "Identify Departments to be Trained", Start = new DateTime(2020, 2, 19), Duration = new TimeSpan(96, 0, 0) });
            generated.Add(new Task() { UID = 4, ParentUID = 3, Name = "Create a list of target departments", Start = new DateTime(2020, 2, 19), Duration = new TimeSpan(8, 0, 0), Predecessors = new List<int> { 2 } });
            generated.Add(new Task() { UID = 5, ParentUID = 3, Name = "Perform departmental training needs analysis", Start = new DateTime(2020, 2, 20), Duration = new TimeSpan(56, 0, 0), Predecessors = new List<int> { 4 } });
            generated.Add(new Task() { UID = 6, ParentUID = 3, Name = "Compile results", Start = new DateTime(2020, 3, 2), Duration = new TimeSpan(16, 0, 0), Predecessors = new List<int> { 5 } });
            generated.Add(new Task() { UID = 7, ParentUID = 3, Name = "Create a list of courses", Start = new DateTime(2020, 3, 4), Duration = new TimeSpan(16, 0, 0), Predecessors = new List<int> { 6 } });
            generated.Add(new Task() { UID = 8, ParentUID = 3, Name = "Inform department heads of the training initiative", Start = new DateTime(2020, 3, 4), Duration = new TimeSpan(16, 0, 0), Predecessors = new List<int> { 6 } });

            generated.Add(new Task() { UID = 9, ParentUID = 1, Name = "Find for a courses vendor", Start = new DateTime(2020, 3, 6), Duration = new TimeSpan(80, 0, 0) });
            generated.Add(new Task() { UID = 10, ParentUID = 9, Name = "Create a list of vendors", Start = new DateTime(2020, 3, 6), Duration = new TimeSpan(8, 0, 0), Predecessors = new List<int> { 7 } });
            generated.Add(new Task() { UID = 11, ParentUID = 9, Name = "Review and customize training material", Start = new DateTime(2020, 3, 9), Duration = new TimeSpan(56, 0, 0), Predecessors = new List<int> { 10 } });
            generated.Add(new Task() { UID = 12, ParentUID = 9, Name = "Selection of the vendor and conclusion of the contract", Start = new DateTime(2020, 3, 18), Duration = new TimeSpan(16, 0, 0), Predecessors = new List<int> { 11 } });

            generated.Add(new Task() { UID = 13, ParentUID = 1, Name = "Schedule courses", Start = new DateTime(2020, 3, 20), Duration = new TimeSpan(72, 0, 0) });
            generated.Add(new Task() { UID = 14, ParentUID = 13, Name = "Determine course dates, start and end times", Start = new DateTime(2020, 3, 20), Duration = new TimeSpan(8, 0, 0), Predecessors = new List<int> { 12 } });
            generated.Add(new Task() { UID = 15, ParentUID = 13, Name = "Determine course locations", Start = new DateTime(2020, 3, 20), Duration = new TimeSpan(8, 0, 0), Predecessors = new List<int> { 12 } });
            generated.Add(new Task() { UID = 16, ParentUID = 13, Name = "Post training outlines and schedule", Start = new DateTime(2020, 3, 23), Duration = new TimeSpan(8, 0, 0), Predecessors = new List<int> { 14 } });
            generated.Add(new Task() { UID = 17, ParentUID = 13, Name = "Order training manuals and necessary material", Start = new DateTime(2020, 3, 24), Duration = new TimeSpan(56, 0, 0), Predecessors = new List<int> { 16 } });

            generated.Add(new Task() { UID = 18, ParentUID = 1, Name = "Finish stage", Start = new DateTime(2020, 4, 1, 17, 0, 0, 0), Duration = new TimeSpan(0, 0, 0), Predecessors = new List<int> { 17 } });
            
            generated.Add(new Task() { UID = 19, ParentUID = 0, Name = "Implementation stage", Start = new DateTime(2020, 4, 2), Duration = new TimeSpan(160, 0, 0), Predecessors = new List<int> { 18 } });

            int requiredCoursesCount = count - 29;
            int fullCoursesCount = requiredCoursesCount / 12;
            int additionalCourses = requiredCoursesCount - fullCoursesCount * 12;

            List<int> coursesDependencies = new List<int>();
            var start = dateTime[0];
            int uid = 20;
            for(int course = 0; course < fullCoursesCount; course++) {
                int courseIndex = course % courses.Length;
                generated.Add(new Task() {
                    Start = start,
                    Duration = new TimeSpan(160, 0, 0),
                    Name = GetCourseName(courseIndex, course < courses.Length ? 0 : course),
                    UID = uid,
                    ParentUID = 19
                });
                int _parentuid = uid;
                uid = uid + 1;
                int currentPredecessorUID = 18;
                for(int m = 0; m < courseModules.Length; m++) {
                    generated.Add(new Task() {
                        Start = dateTime[m],
                        Duration = durations[m],
                        Name = courseModules[m],
                        ParentUID = _parentuid,
                        UID = uid,
                        //Predecessors = new List<int> { currentPredecessorUID }
                    });
                    currentPredecessorUID = uid;
                    uid = uid + 1;
                }
                coursesDependencies.Add(currentPredecessorUID);
            }
            for(int ac = 0; ac < additionalCourses; ac++) {
                int courseIndex = ac % courses.Length;
                generated.Add(new Task() {
                    Start = start,
                    Duration = new TimeSpan(160, 0, 0),
                    Name = courses[courseIndex] + " Additional",
                    UID = uid,
                    ParentUID = 19,
                    //Predecessors = new List<int> { 18 }
                });
                coursesDependencies.Add(uid);
                uid = uid + 1;
            }
            generated.Add(new Task() { UID = generated.Count, ParentUID = 19, Name = "Finish implementation stage", Start = dateTime[dateTime.Length - 1], Duration = new TimeSpan(0, 0, 0, 0), Predecessors = coursesDependencies });
            var parentUID = generated.Count;
            generated.Add(new Task() { UID = parentUID, ParentUID = 0, Name = "Closing stage", Start = new DateTime(2020, 4, 30), Duration = new TimeSpan(64, 0, 0) });
            generated.Add(new Task() { UID = generated.Count, ParentUID = parentUID, Name = "Issue certificates of completion to participants", Start = new DateTime(2020, 4, 30), Duration = new TimeSpan(8, 0, 0), Predecessors = new List<int> { generated[generated.Count - 2].UID } });
            generated.Add(new Task() { UID = generated.Count, ParentUID = parentUID, Name = "Discuss evaluations, results, and process improvements", Start = new DateTime(2020, 5, 1), Duration = new TimeSpan(8, 0, 0), Predecessors = new List<int> { generated[generated.Count - 1].UID } });
            generated.Add(new Task() { UID = generated.Count, ParentUID = parentUID, Name = "Collect feedback and compile results", Start = new DateTime(2020, 5, 4), Duration = new TimeSpan(24, 0, 0), Predecessors = new List<int> { generated[generated.Count - 1].UID } });
            generated.Add(new Task() { UID = generated.Count, ParentUID = parentUID, Name = "Discuss results with vendor for any improvements", Start = new DateTime(2020, 5, 7), Duration = new TimeSpan(8, 0, 0), Predecessors = new List<int> { generated[generated.Count - 1].UID } });
            generated.Add(new Task() { UID = generated.Count, ParentUID = parentUID, Name = " Create a list of best practices and FAQ for future training endeavors", Start = new DateTime(2020, 5, 8), Duration = new TimeSpan(16, 0, 0), Predecessors = new List<int> { generated[generated.Count - 1].UID } });
            generated.Add(new Task() { UID = generated.Count, ParentUID = parentUID, Name = "Finish stage", Start = new DateTime(2020, 5, 11, 17, 0, 0, 0), Duration = new TimeSpan(0, 0, 0), Predecessors = new List<int> { generated[generated.Count - 1].UID } });

            generated.Add(new Task() { UID = generated.Count, ParentUID = 0, Name = "Finish company training", Start = new DateTime(2020, 5, 11, 17, 0, 0, 0), Duration = new TimeSpan(0, 0, 0), Predecessors = new List<int> { generated[generated.Count - 1].UID } });
            return generated;
        }
        static string GetCourseName(int course, int rp) {
            if(rp == 0) return courses[course];
            return courses[course] + " " + rp;
        }
    }
}
