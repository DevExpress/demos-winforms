
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
    using DevExpress.XtraGantt.Options;
    using DevExpress.XtraGantt.Scheduling;
    using System.Linq;

    [CodeExampleClass("Interactive editing", "Interactions.cs")]
    public static class Interactions {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GanttControl ganttControl = new GanttControl();
            ganttControl.Dock = DockStyle.Fill;
            ganttControl.OptionsCustomization.AllowModifyDependencies = DefaultBoolean.True;
            ganttControl.OptionsCustomization.AllowModifyProgress = DefaultBoolean.True;
            ganttControl.OptionsCustomization.AllowModifyTasks = DefaultBoolean.True;
            ganttControl.OptionsBehavior.ScheduleMode = ScheduleMode.Manual;
            ganttControl.Parent = sampleHost;
            ganttControl.TreeListMappings.KeyFieldName = "Id";
            ganttControl.TreeListMappings.ParentFieldName = "ParentId";
            ganttControl.ChartMappings.TextFieldName = "Name";
            ganttControl.ChartMappings.StartDateFieldName = "StartTime";
            ganttControl.ChartMappings.FinishDateFieldName = "EndTime";
            ganttControl.ChartMappings.ProgressFieldName = "Progress";
            ganttControl.ChartMappings.PredecessorsFieldName = "PredecessorIDs";
            for(int i = 0; i < 7; i++) {
                ganttControl.WorkWeek.Add(new WorkDayOfWeek((DayOfWeek) i, new List<WorkTime>() {new WorkTime(TimeSpan.FromHours(0), TimeSpan.FromHours(24))}));
            }
            ganttControl.DataSource = Task.GetData();
            ganttControl.Load += (s, e) => ganttControl.ExpandAll();
            return new object[] {ganttControl};
        }

        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        [CodeExampleCase("Prevent users from postponing tasks for more than one day")]
        [CodeExampleUnderlineTokens("TaskMoveCompleted", "Cancel", "CurrentTaskStart", "OriginalTaskStart")]
        public static void CancelShiftTask(GanttControl ganttControl) {
            ganttControl.TaskMoveCompleted += (sender, e) => {
                if(e.CurrentTaskStart > e.OriginalTaskStart.Value.AddDays(1))
                    e.Cancel = true;
            };
        }
        [CodeExampleCase("Prevent users from prolonging tasks for more than one day")]
        [CodeExampleUnderlineTokens("TaskFinishDateModificationCompleted", "Cancel", "CurrentTaskFinish", "OriginalTaskFinish")]
        public static void CancelTaskFinishDateModification(GanttControl ganttControl) {
            ganttControl.TaskFinishDateModificationCompleted += (sender, e) => {
                if(e.CurrentTaskFinish > e.OriginalTaskFinish.Value.AddDays(1))
                    e.Cancel = true;
            };
        }
        [CodeExampleCase("Prevent users from updating progress for more than 30%")]
        [CodeExampleUnderlineTokens("TaskProgressModificationCompleted", "Cancel", "CurrentProgress", "OriginalProgress")]
        public static void CancelTaskProgressModification(GanttControl ganttControl) {
            ganttControl.TaskProgressModificationCompleted += (sender, e) => {
                if(Math.Abs(e.CurrentProgress - e.OriginalProgress) > 0.3)
                    e.Cancel = true;
            };
        }
        [CodeExampleCase("Prevent users from Modification a link between two particular tasks")]
        [CodeExampleUnderlineTokens("TaskDependencyModificationCompleted", "Cancel", "PredecessorTask", "OriginalSuccessorTask")]
        public static void AdjustTaskDependencyModification(GanttControl ganttControl) {
            ganttControl.TaskDependencyModificationCompleted += (sender, e) => {
                if(Equals(e.PredecessorTask.Text, "Develop software") && Equals(e.OriginalSuccessorTask.Text, "Create software maintenance team"))
                    e.Cancel = true;
            };
        }
        [CodeExampleCase("Highlight created/modified dependencies")]
        [CodeExampleUnderlineTokens("TaskDependencyModified", "CustomDrawTaskDependency", "BackColor", "ProgressColor", "ChangeType")]
        public static void HighlightModifiedDependencies(GanttControl ganttControl) {
            List<DependencyInfo> modifiedDependencies = new List<DependencyInfo>();
            List<DependencyInfo> createdDependencies = new List<DependencyInfo>();
            ganttControl.TaskDependencyModified += (sender, e) => {
                if(e.PredecessorNode != null && e.SuccessorNode != null) {
                    DependencyInfo dependency = new DependencyInfo(e.PredecessorNode.Id, e.SuccessorNode.Id);
                    if(e.ChangeType == ChangeType.Modify)
                        modifiedDependencies.Add(dependency);
                    if(e.ChangeType == ChangeType.Create)
                        createdDependencies.Add(dependency);
                }
            };
            ganttControl.CustomDrawTaskDependency += (sender, e) => {
                if(e.PredecessorNode != null && e.SuccessorNode != null) {
                    DependencyInfo dependency = new DependencyInfo(e.PredecessorNode.Id, e.SuccessorNode.Id);
                    var modifiedDependency = modifiedDependencies.FirstOrDefault(x => Equals(x, dependency));
                    if(modifiedDependency != null)
                        e.Appearance.BackColor = DXSkinColors.FillColors.Danger;
                    var createdDependency = createdDependencies.FirstOrDefault(x => Equals(x, dependency));
                    if(createdDependency != null)
                        e.Appearance.BackColor = DXSkinColors.FillColors.Success;
                }
            };
        }
        [CodeExampleCase("Highlight modified progress, finish date and moved tasks")]
        [CodeExampleUnderlineTokens("TaskMoved", "TaskFinishDateModified", "TaskProgressModified", "CustomDrawTask", "BackColor", "ProgressColor", "TaskMoveStarted", "TaskProgressModificationStarted", "TaskFinishDateModificationStarted")]
        public static void HighlightModifiedTaskElements(GanttControl ganttControl) {
            //Initialize
            List<TaskElementsModificationState> elementsState = new List<TaskElementsModificationState>();
            for(int i = 0; i < ganttControl.AllNodesCount; i++)
                elementsState.Add(new TaskElementsModificationState());
            ganttControl.TaskMoved += (sender, e) => {
                elementsState[e.ProcessedNode.Id].TaskPositionModified = true;
            };
            ganttControl.TaskFinishDateModified += (sender, e) => {
                elementsState[e.ProcessedNode.Id].TaskFinishDateModified = true;
            };
            ganttControl.TaskProgressModified += (sender, e) => {
                elementsState[e.ProcessedNode.Id].TaskProgressModified = true;
            };
            ganttControl.CustomDrawTask += (sender, e) => {
                var state = elementsState[e.Node.Id];
                if(state.TaskFinishDateModified)
                    e.Appearance.BackColor = DXSkinColors.FillColors.Warning;
                if(state.TaskPositionModified)
                    e.Appearance.BackColor = DXSkinColors.FillColors.Danger;
                if(state.TaskProgressModified)
                    e.Appearance.ProgressColor = DXSkinColors.FillColors.Danger;
            };
            //Reset states
            ganttControl.TaskMoveStarted += (sender, e) => {
                elementsState[e.ProcessedNode.Id].Reset();
            };
            ganttControl.TaskProgressModificationStarted += (sender, e) => {
                elementsState[e.ProcessedNode.Id].Reset();
            };
            ganttControl.TaskFinishDateModificationStarted += (sender, e) => {
                elementsState[e.ProcessedNode.Id].Reset();
            };
        }
        [CodeExampleCase("Highlight refused changes")]
        [CodeExampleUnderlineTokens("TaskMoveCanceled", "TaskFinishDateModificationCanceled", "TaskProgressModificationCanceled", "CustomDrawTask", "BackColor", "ProgressColor", "TaskMoveStarted", "TaskProgressModificationStarted", "TaskFinishDateModificationStarted")]
        public static void ModificationCanceled(GanttControl ganttControl) {
            //Initialize
            List<TaskElementsModificationState> elementsState = new List<TaskElementsModificationState>();
            for(int i = 0; i < ganttControl.AllNodesCount; i++)
                elementsState.Add(new TaskElementsModificationState());
            // Press Esc to cancel modification
            ganttControl.TaskMoveCanceled += (sender, e) => {
                elementsState[e.ProcessedNode.Id].TaskPositionModified = true;
            };
            ganttControl.TaskFinishDateModificationCanceled += (sender, e) => {
                elementsState[e.ProcessedNode.Id].TaskFinishDateModified = true;
            };
            ganttControl.TaskProgressModificationCanceled += (sender, e) => {
                elementsState[e.ProcessedNode.Id].TaskProgressModified = true;
            };
            ganttControl.CustomDrawTask += (sender, e) => {
                var state = elementsState[e.Node.Id];
                if(state.TaskFinishDateModified)
                    e.Appearance.BackColor = DXSkinColors.FillColors.Warning;
                if(state.TaskPositionModified)
                    e.Appearance.BackColor = DXSkinColors.FillColors.Danger;
                if(state.TaskProgressModified)
                    e.Appearance.ProgressColor = DXSkinColors.FillColors.Danger;
            };
            //Reset states
            ganttControl.TaskMoveStarted += (sender, e) => {
                elementsState[e.ProcessedNode.Id].Reset();
            };
            ganttControl.TaskProgressModificationStarted += (sender, e) => {
                elementsState[e.ProcessedNode.Id].Reset();
            };
            ganttControl.TaskFinishDateModificationStarted += (sender, e) => {
                elementsState[e.ProcessedNode.Id].Reset();
            };
        }
        //[CodeExampleCase("Adjust task shift")]
        //[CodeExampleUnderlineTokens("ScheduledTaskStart", "ScheduledTaskFinish", "TaskMoving")]
        //public static void ShiftTask(GanttControl ganttControl) {
        //    ganttControl.TaskMoving += (sender, e) => {
        //        if(e.CurrentTaskStart > e.OriginalTaskStart.Value.AddDays(2))
        //            e.Cancel = true;
        //    };
        //}
        //[CodeExampleCase("Adjust task finish date shift")]
        //[CodeExampleUnderlineTokens("ScheduledTaskFinish", "TaskFinishDateModification")]
        //public static void ShiftTaskFinishDate(GanttControl ganttControl) {
        //    ganttControl.TaskFinishDateModification += (sender, e) => {
        //        if(e.CurrentTaskFinish > e.OriginalTaskFinish.Value.AddDays(2))
        //            e.Cancel = true;
        //    };
        //}
        //[CodeExampleCase("Adjust completion progress")]
        //[CodeExampleUnderlineTokens("Progress", "TaskProgressModification")]
        //public static void RecalculateTaskProgress(GanttControl ganttControl) {
        //    ganttControl.TaskProgressModification += (sender, e) => {
        //        float correctionFactor = (float) e.ProcessedNode.GetValue("ProgressCorrectionFactor");
        //        e.CurrentProgress *= correctionFactor;
        //    };
        //}
    }
}
