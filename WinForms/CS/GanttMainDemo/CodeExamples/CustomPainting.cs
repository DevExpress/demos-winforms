
namespace Examples {
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.LookAndFeel;
    using DevExpress.XtraEditors;
    using DevExpress.XtraGantt;
    using DevExpress.Utils.Menu;
    using DevExpress.Utils;
    using DevExpress.Utils.Svg;
    using Examples;
    using DevExpress.XtraGantt.Scheduling;
    using DevExpress.DXperience.Demos;

    [CodeExampleClass("Custom painting", "CustomPainting.cs")]
    public class CustomPainting {
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
            ganttControl.DataSource = Task.GetData();
            for(int i = 0; i < 7; i++) {
                ganttControl.WorkWeek.Add(new WorkDayOfWeek((DayOfWeek) i, new List<WorkTime>() {new WorkTime(TimeSpan.FromHours(0), TimeSpan.FromHours(24))}));
            }
            ganttControl.Load += (s, e) => ganttControl.ExpandAll();
            return new object[] {ganttControl};
        }

        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("Draw striplines")]
        [CodeExampleUnderlineTokens("CustomDrawTimescaleColumn", "DrawBackground", "DrawHeader")]
        public static void DrawStriplines(GanttControl ganttControl) {
            DateTime striplineStart = TutorialConstants.Now.AddHours(5);
            DateTime striplineEnd = striplineStart.AddHours(4);
            Color striplineColor = Color.FromArgb(128, 255, 224, 166);
            ganttControl.CustomDrawTimescaleColumn += (sender, e) => {
                GanttTimescaleColumn column = e.Column;
                float stripLineStartPoint = (float) Math.Max(e.GetPosition(striplineStart), column.Bounds.Left);
                float stripLineEndPoint = (float) Math.Min(e.GetPosition(striplineEnd), column.Bounds.Right);
                e.DrawBackground();
                RectangleF boundsToDraw = new RectangleF(stripLineStartPoint, column.Bounds.Y, stripLineEndPoint - stripLineStartPoint, column.Bounds.Height);
                if(boundsToDraw.Width > 0)
                    e.Cache.FillRectangle(striplineColor, boundsToDraw);
                e.DrawHeader();
                e.Handled = true;
            };
        }
        [CodeExampleCase("Custom task display text")]
        [CodeExampleUnderlineTokens("CustomTaskDisplayText", "RightText", "LeftText")]
        public static void CustomTaskDisplayText(GanttControl ganttControl) {
            HashSet<int> criticalPathIds = new HashSet<int> { 1, 2, 3, 6, 7, 8, 10, 11, 13 };
            ganttControl.CustomTaskDisplayText += (sender, e) => {
                int taskId = Convert.ToInt32(e.Node.GetValue("Id"));
                if(criticalPathIds.Contains(taskId)) {
                    e.RightText = "High priority";
                }
                else {
                    e.RightText = string.Empty;
                    e.LeftText = "Normal priority";
                }
            };
        }
        [CodeExampleCase("Highlight Tasks and Dependencies")]
        [CodeExampleUnderlineTokens("CustomDrawTask", "CustomDrawTaskDependency", "BackColor", "ProgressColor")]
        public static void DrawHighlightedTasksAndDependencies(GanttControl ganttControl) {
            HashSet<int> tasks = new HashSet<int> { 1, 2, 3, 6, 7, 8, 10, 11, 13 };
            ganttControl.CustomDrawTask += (sender, e) => {
                int taskId = Convert.ToInt32(e.Node.GetValue("Id"));
                if(tasks.Contains(taskId)) {
                    e.Appearance.BackColor = DXSkinColors.FillColors.Warning;
                    e.Appearance.ProgressColor = DXSkinColors.FillColors.Warning;
                }
            };
            ganttControl.CustomDrawTaskDependency += (sender, e) => {
                int predecessorId = Convert.ToInt32(e.PredecessorNode.GetValue("Id"));
                int successorId = Convert.ToInt32(e.SuccessorNode.GetValue("Id"));
                if(tasks.Contains(predecessorId) && tasks.Contains(successorId)) {
                    e.Appearance.BackColor = DXSkinColors.FillColors.Warning;
                }
            };
        }

        [CodeExampleCase("Show a deadline")]
        [CodeExampleUnderlineTokens("CustomDrawTimescaleColumn", "FillRectangle")]
        public static void DrawCustomTimescaleColumn(GanttControl ganttControl) {
            DateTime deadLine = TaskStorage.GetFinishDateFromTask("Deploy Beta");
            ganttControl.CustomDrawTimescaleColumn += (sender, e) => {
                GanttTimescaleColumn column = e.Column;
                if(column.StartDate <= deadLine && column.FinishDate >= deadLine) {
                    e.DrawBackground();
                    float x = (float) e.GetPosition(deadLine);
                    float width = 4;
                    RectangleF deadLineRect = new RectangleF(x, column.Bounds.Y, width, column.Bounds.Height);
                    e.Cache.FillRectangle(DXSkinColors.FillColors.Danger, deadLineRect);
                    e.DrawHeader();
                    e.Handled = true;
                }
            };
        }

        [CodeExampleCase("Highlight Tasks in Timeline")]
        public static void DrawCustomTimelineTask(GanttControl ganttControl) { 
            ganttControl.OptionsTimeline.TimelinePosition = TimelinePosition.Top;
            ganttControl.CustomDrawTimelineTask += (sender, e) => {
                if(e.Task.Type == GanttControlTaskType.SummaryTask) {
                    e.Cache.FillRectangle(DXSkinColors.FillColors.Warning, e.Task.Bounds);
                }
            };
        }

        [CodeExampleCase("Customize text in tasks in timeline")]
        public static void CustomizeTimelineTaskText(GanttControl ganttControl) { 
            ganttControl.OptionsTimeline.TimelinePosition = TimelinePosition.Top;
            ganttControl.CustomTimelineItemText += (sender, e) => {
                if(e.Task.Type == GanttControlTaskType.SummaryTask) {
                    e.Caption = "Work being done";
                    e.Details = String.Format("From {0} to {1}", e.Task.Start, e.Task.Finish);
                }
            };
        }

        [CodeExampleCase("Customize timeline bar appearance")]
        public static void CustomizeTimelineBar(GanttControl ganttControl) { 
            ganttControl.OptionsTimeline.TimelinePosition = TimelinePosition.Top;
            ganttControl.CustomDrawTimelineBar += (sender, e) => {
                if(e.Bar.Nodes.Count > 0)
                    return;
                e.Appearance.BackColor = Color.GreenYellow;
                e.EmptyText = "There is nothing here";
            };
        }
    }
}
