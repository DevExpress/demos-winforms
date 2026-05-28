namespace Examples {
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraGantt;
    using DevExpress.XtraGantt.Scheduling;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    [CodeExampleClass("Timeline", "Timeline.cs")]
    public class Timeline {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GanttControl ganttControl = new GanttControl();
            ganttControl.OptionsBehavior.Editable = false;
            ganttControl.Dock = DockStyle.Fill;
            ganttControl.Parent = sampleHost;
            ganttControl.TreeListMappings.KeyFieldName = "Id";
            ganttControl.TreeListMappings.ParentFieldName = "ParentId";
            ganttControl.ChartMappings.TextFieldName = "Name";
            ganttControl.ChartMappings.StartDateFieldName = "StartTime";
            ganttControl.ChartMappings.FinishDateFieldName = "EndTime";
            ganttControl.ChartMappings.ProgressFieldName = "Progress";
            ganttControl.ChartMappings.PredecessorsFieldName = "PredecessorIDs";
            ganttControl.ChartMappings.VisibleInTimelineFieldName = "";
            ganttControl.DataSource = Task.GetData();
            for(int i = 0; i < 7; i++) {
                ganttControl.WorkWeek.Add(new WorkDayOfWeek((DayOfWeek)i, new List<WorkTime>() { new WorkTime(TimeSpan.FromHours(0), TimeSpan.FromHours(24)) }));
            }
            ganttControl.Load += (s, e) => ganttControl.ExpandAll();
            ganttControl.ForceInitialize();
            return new object[] { ganttControl };
        }

        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }

        [CodeExampleCase("Show timeline")]
        [CodeExampleUnderlineTokens("TimelinePosition")]
        public static void ShowTimeline(GanttControl ganttControl) {
            ganttControl.OptionsTimeline.TimelinePosition = TimelinePosition.Top;
        }

        [CodeExampleCase("Add tasks to the timeline")]
        [CodeExampleUnderlineTokens("ClearTasks", "AddTaskToTimeline")]
        public static void OperateTasks(GanttControl ganttControl) {
            ganttControl.OptionsTimeline.TimelinePosition = TimelinePosition.Top;
            ganttControl.AddTaskToTimeline(ganttControl.Nodes[0]);
            ganttControl.AddTaskToTimeline((GanttControlNode)ganttControl.FindNodeByID(3));
            ganttControl.AddTaskToTimeline((GanttControlNode)ganttControl.FindNodeByID(6));
            ganttControl.AddTaskToTimeline((GanttControlNode)ganttControl.FindNodeByID(11));
            ganttControl.AddTaskToTimeline(ganttControl.Nodes[0].Nodes.LastNode);
        }

        [CodeExampleCase("Add bars to the timeline")]
        [CodeExampleUnderlineTokens("AddTimelineBar", "FocusedTimelineBar", "TimelineBars")]
        public static void OperateBars(GanttControl ganttControl) {
            ganttControl.OptionsTimeline.TimelinePosition = TimelinePosition.Top;
            ganttControl.AddTaskToTimeline(ganttControl.Nodes[0]);
            ganttControl.AddTimelineBar();
            ganttControl.FocusedTimelineBar = ganttControl.TimelineBars[1];
            ganttControl.AddTaskToTimeline((GanttControlNode)ganttControl.FindNodeByID(3));
            ganttControl.AddTaskToTimeline((GanttControlNode)ganttControl.FindNodeByID(6));
            ganttControl.AddTaskToTimeline((GanttControlNode)ganttControl.FindNodeByID(11));
        }
    }
}
