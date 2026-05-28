using DevExpress.XtraGantt.Scheduling;

namespace Examples {
    using System;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraGantt;
    using System.Collections.Generic;

    [CodeExampleClass("Data-binding modes", "DataBinding.cs")]
    public static class DataBindingModes {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GanttControl ganttControl = new GanttControl();
            ganttControl.OptionsBehavior.Editable = false;
            ganttControl.Dock = DockStyle.Fill;
            ganttControl.Parent = sampleHost;
            ganttControl.DataSource = Task.GetData();
            ganttControl.Load += (s, e) => ganttControl.ExpandAll();
            for(int i = 0; i < 7; i++) {
                ganttControl.WorkWeek.Add(new WorkDayOfWeek((DayOfWeek) i, new List<WorkTime>() {new WorkTime(TimeSpan.FromHours(0), TimeSpan.FromHours(24))}));
            }
            return new object[] { ganttControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("Map data source fields to task and node properties"), TaskCS]
        [CodeExampleUnderlineTokens("TreeListMappings", "ChartMappings", "DataSource")]
        public static void InitializeMappings(GanttControl ganttControl) {
            // TreeList Mappings
            ganttControl.TreeListMappings.KeyFieldName = "Id";
            ganttControl.TreeListMappings.ParentFieldName = "ParentId";
            // Chart Mappings
            ganttControl.ChartMappings.TextFieldName = "Name";
            ganttControl.ChartMappings.StartDateFieldName = "StartTime";
            ganttControl.ChartMappings.FinishDateFieldName = "EndTime";
            ganttControl.ChartMappings.ProgressFieldName = "Progress";
            ganttControl.ChartMappings.PredecessorsFieldName = "PredecessorIDs";
            // Assign the datasource
            ganttControl.DataSource = Task.LoadData();
        }
        [CodeExampleCase("Use a data source to specify dependencies"), TaskCS]
        [CodeExampleUnderlineTokens("DependencyMappings", "DependencySource")]
        public static void InitializeDependencySource(GanttControl ganttControl) {
            // Dependency Mappings
            ganttControl.DependencyMappings.PredecessorFieldName = "PredecessorID";
            ganttControl.DependencyMappings.SuccessorFieldName = "SuccessorID";
            ganttControl.DependencyMappings.TypeFieldName = "DependencyType";
            ganttControl.DependencyMappings.LagFieldName = "Lag";
            // Assign the dependency source
            ganttControl.DependencySource = Dependency.LoadData();
            // TreeList Mappings
            ganttControl.TreeListMappings.KeyFieldName = "Id";
            ganttControl.TreeListMappings.ParentFieldName = "ParentId";
            // Chart Mappings
            ganttControl.ChartMappings.TextFieldName = "Name";
            ganttControl.ChartMappings.StartDateFieldName = "StartTime";
            ganttControl.ChartMappings.FinishDateFieldName = "EndTime";
            ganttControl.ChartMappings.ProgressFieldName = "Progress";
            // Assign the datasource
            ganttControl.DataSource = Task.LoadData();
        }
        [CodeExampleCase("Use a data source to specify task splits"), TaskCS, SplitInfoCS]
        [CodeExampleUnderlineTokens("DependencyMappings", "DependencySource")]
        public static void InitializeTaskSplitSource(GanttControl ganttControl) {
            // TreeList Mappings
            ganttControl.TreeListMappings.KeyFieldName = "Id";
            ganttControl.TreeListMappings.ParentFieldName = "ParentId";
            // Chart Mappings
            ganttControl.ChartMappings.TextFieldName = "Name";
            ganttControl.ChartMappings.StartDateFieldName = "StartTime";
            ganttControl.ChartMappings.FinishDateFieldName = "EndTime";
            ganttControl.ChartMappings.ProgressFieldName = "Progress";
            ganttControl.ChartMappings.PredecessorsFieldName = "PredecessorIDs";
            // Assign the datasource
            ganttControl.DataSource = Task.LoadData();
            // Task Split Mappings
            ganttControl.SplitTaskMappings.StartDateFieldName = "Start";
            ganttControl.SplitTaskMappings.DurationFieldName = "Duration";
            ganttControl.SplitTaskMappings.KeyFieldName = "ID";
            // Assign task splits
            ganttControl.SplitTaskSource = SplitInfo.GetData();
        }
    }
}
