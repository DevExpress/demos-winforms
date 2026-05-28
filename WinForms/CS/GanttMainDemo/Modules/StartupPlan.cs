using System;
using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraGantt.Demos.Utils;
using DevExpress.XtraGantt.Options;
using DevExpress.XtraGantt.Scheduling;

namespace DevExpress.XtraGantt.Demos {
    public partial class StartupPlan : TutorialControl {
        readonly EventLogger logger;
        public StartupPlan() {
            InitializeComponent();
            ganttControl1.TreeListMappings.ParentFieldName = "ParentUID";
            ganttControl1.TreeListMappings.KeyFieldName = "UID";
            ganttControl1.ChartMappings.TextFieldName = "Resources";
            ganttControl1.ChartMappings.InteractionTooltipTextFieldName = "Name";
            ganttControl1.SplitTaskMappings.StartDateFieldName = "StartDate";
            ganttControl1.SplitTaskMappings.DurationFieldName = "Duration";
            ganttControl1.SplitTaskMappings.KeyFieldName = "UID";
            ganttControl1.OptionsBehavior.ScheduleMode = ScheduleMode.Auto;
            LoadData();
            //
            ganttControl1.OptionsView.ShowBaselines = true;
            ceShowBaseLines.Checked = ganttControl1.OptionsView.ShowBaselines;
            ceAllowSplitTasks.Checked = ganttControl1.OptionsBehavior.AllowSplitTasks != DefaultBoolean.False;
            ganttControl1.ExpandAll();
            meLog.Enabled = ceEnableTracing.Checked;
            SubscribeEvents();
            logger = new EventLogger(meLog);
        }
        void LoadData() {
            IList<TaskDataItem> tasks;
            using(var stream = LoadXml("StartupPlan.xml")) {
                tasks = ProjectXMLLoader.LoadModel(stream);
            }
            if(tasks != null) {
                ganttControl1.DataSource = tasks;
                List<TaskSplitInfo> splitInfo = new List<TaskSplitInfo>();
                splitInfo.Add(new TaskSplitInfo() {UID = "8", StartDate = tasks[8].StartDate + TimeSpan.FromHours(2), Duration = TimeSpan.FromHours(8)});
                splitInfo.Add(new TaskSplitInfo() {UID = "9", StartDate = tasks[9].StartDate + TimeSpan.FromHours(5), Duration = TimeSpan.FromDays(1)});
                splitInfo.Add(new TaskSplitInfo() {UID = "10", StartDate = tasks[10].StartDate + TimeSpan.FromHours(4), Duration = TimeSpan.FromHours(4)});
                splitInfo.Add(new TaskSplitInfo() {UID = "10", StartDate = tasks[10].StartDate + TimeSpan.FromDays(2) + TimeSpan.FromHours(2), Duration = TimeSpan.FromHours(4)});
                ganttControl1.SplitTaskSource = splitInfo;
                //
                var offsets = new List<TaskItemBaseLineOffset>(tasks.Count);
                using(var stream = LoadXml("StartupPlanBaselinesInfo.xml")) 
                    offsets = SafeXml.Deserialize<List<TaskItemBaseLineOffset>>(stream);
                if(offsets != null) {
                    for(int i = 0; i < offsets.Count; i++) {
                        tasks[i].BaselineStartDate = tasks[i].StartDate + TimeSpan.FromTicks(offsets[i].BaselineStartOffset);
                        tasks[i].BaselineFinishDate = tasks[i].StartDate + TimeSpan.FromTicks(offsets[i].BaselineFinishOffset);
                    }
                }
            }
        }
        #region EventLogging
        void SubscribeEvents() {
            ganttControl1.TaskDependencyModificationCompleted += GanttControl1_TaskDependencyModificationCompleted;
            ganttControl1.TaskDependencyModificationCanceled += GanttControl1_TaskDependencyModificationCanceled;
            ganttControl1.TaskDependencyModified += GanttControl1_TaskDependencyModified;
            ganttControl1.TaskMoveStarted += GanttControl1_TaskMoveStarted;
            ganttControl1.TaskMoveCompleted += GanttControl1_TaskMoveCompleted;
            ganttControl1.TaskMoveCanceled += GanttControl1_TaskMoveCanceled;
            ganttControl1.TaskMoved += GanttControl1_TaskMoved;
            ganttControl1.TaskFinishDateModificationStarted += GanttControl1_TaskFinishDateModificationStarted;
            ganttControl1.TaskFinishDateModificationCompleted += GanttControl1_TaskFinishDateModificationCompleted;
            ganttControl1.TaskFinishDateModificationCanceled += GanttControl1_TaskFinishDateModificationCanceled;
            ganttControl1.TaskFinishDateModified += GanttControl1_TaskFinishDateModified;
            ganttControl1.TaskProgressModificationStarted += GanttControl1_TaskProgressModificationStarted;
            ganttControl1.TaskProgressModificationCanceled += GanttControl1_TaskProgressModificationCanceled;
            ganttControl1.TaskProgressModified += GanttControl1_TaskProgressModified;
            ganttControl1.TaskProgressModificationCompleted += GanttControl1_TaskProgressModificationCompleted;
        }
        void AppendProgressInfo(string eventName, GanttControlTask processedTask, float currentProgress) {
            logger.Append(eventName);
            logger.AppendWithIndent(string.Format("Task: {0}", processedTask.TooltipText));
            logger.AppendWithIndent(string.Format("Progress: {0}%", Math.Round(currentProgress * 100, 1)));
        }
        void GanttControl1_TaskProgressModified(object sender, TaskProgressModifiedEventArgs e) {
            AppendProgressInfo("TaskProgressModified", e.ProcessedTask, e.CurrentProgress);
        }
        void GanttControl1_TaskProgressModificationCanceled(object sender, TaskProgressModificationCanceledEventArgs e) {
            AppendProgressInfo("TaskProgressModificationCanceled", e.ProcessedTask, e.CurrentProgress);
        }
        void GanttControl1_TaskProgressModificationStarted(object sender, TaskProgressModificationEventArgs e) {
            AppendProgressInfo("TaskProgressModificationStarted", e.ProcessedTask, e.CurrentProgress);
        }
        void GanttControl1_TaskProgressModificationCompleted(object sender, TaskProgressModificationEventArgs e) {
            AppendProgressInfo("TaskProgressModificationCompleted", e.ProcessedTask, e.CurrentProgress);
        }
        void AppendTaskFinishDateInfo(string eventName, GanttControlTask processedTask, DateTime? finishDate) {
            logger.Append(eventName);
            logger.AppendWithIndent(string.Format("Task: {0}", processedTask.TooltipText));
            logger.AppendWithIndent(string.Format("Finish Date: {0}", finishDate));
        }
        void GanttControl1_TaskFinishDateModified(object sender, TaskFinishModifiedEventArgs e) {
            AppendTaskFinishDateInfo("TaskFinishDateModified", e.ProcessedTask, e.OriginalTaskFinish);
        }
        void GanttControl1_TaskFinishDateModificationCompleted(object sender, TaskFinishModificationEventArgs e) {
            AppendTaskFinishDateInfo("TaskFinishDateModificationCompleted", e.ProcessedTask, e.OriginalTaskFinish);
        }
        void GanttControl1_TaskFinishDateModificationCanceled(object sender, TaskFinishModificationCanceledEventArgs e) {
            AppendTaskFinishDateInfo("TaskFinishDateModificationCanceled", e.ProcessedTask, e.OriginalTaskFinish);
        }
        void GanttControl1_TaskFinishDateModificationStarted(object sender, TaskFinishModificationEventArgs e) {
            AppendTaskFinishDateInfo("TaskFinishDateModificationStarted", e.ProcessedTask, e.OriginalTaskFinish);
        }
        void AppendTaskMovingInfo(string eventName, GanttControlTask processedTask, DateTime? taskStart, DateTime? taskFinish) {
            logger.Append(eventName);
            logger.AppendWithIndent(string.Format("Task: {0}", processedTask.TooltipText));
            logger.AppendWithIndent(string.Format("Start Date: {0}", taskStart));
            logger.AppendWithIndent(string.Format("Finish Date: {0}", taskFinish));
        }
        void GanttControl1_TaskMoved(object sender, TaskMovedEventArgs e) {
            AppendTaskMovingInfo("TaskMoved", e.ProcessedTask, e.OriginalTaskStart, e.OriginalTaskFinish);
        }
        void GanttControl1_TaskMoveCompleted(object sender, TaskMovingEventArgs e) {
            AppendTaskMovingInfo("TaskMoveCompleted", e.ProcessedTask, e.OriginalTaskStart, e.OriginalTaskFinish);
        }
        void AppendTaskMoveInfo(string eventName, GanttControlTask processedTask, DateTime? scheduledDate) {
            logger.Append(eventName);
            logger.AppendWithIndent(string.Format("Task: {0}", processedTask.TooltipText));
            logger.AppendWithIndent(string.Format("Start Date: {0}", scheduledDate));
        }
        void GanttControl1_TaskMoveCanceled(object sender, TaskMoveCanceledEventArgs e) {
            AppendTaskMoveInfo("TaskMoveCanceled", e.ProcessedTask, e.ProcessedTask.ScheduledStartDate);
        }
        void GanttControl1_TaskMoveStarted(object sender, TaskMovingEventArgs e) {
            AppendTaskMoveInfo("TaskMoveStarted", e.ProcessedTask, e.OriginalTaskStart);
        }
        void AppendDependencyModificationInfo(string eventName, GanttControlTask predecessorTask, GanttControlTask successorTask, GanttControlTask originalSuccessorsTask, ChangeType ct) {
            logger.Append(eventName);
            logger.AppendWithIndent(string.Format("Predecessor: {0}", predecessorTask.TooltipText));
            if(successorTask != null)
                logger.AppendWithIndent(string.Format("Successor: {0}", successorTask.TooltipText));
            if(originalSuccessorsTask != null)
                logger.AppendWithIndent(string.Format("Original Successor: {0}", originalSuccessorsTask.TooltipText));
            logger.AppendWithIndent(string.Format("Change Type: {0}", ct));
        }
        void GanttControl1_TaskDependencyModified(object sender, TaskDependencyModificationEventArgs e) {
            AppendDependencyModificationInfo("TaskDependencyModified", e.PredecessorTask, e.SuccessorTask, e.OriginalSuccessorTask, e.ChangeType);
        }
        void GanttControl1_TaskDependencyModificationCanceled(object sender, TaskDependencyModificationEventArgs e) {
            AppendDependencyModificationInfo("TaskDependencyModificationCanceled", e.PredecessorTask, e.SuccessorTask, e.OriginalSuccessorTask, e.ChangeType);
        }
        void GanttControl1_TaskDependencyModificationCompleted(object sender, TaskDependencyModificationCancelEventArgs e) {
            AppendDependencyModificationInfo("TaskDependencyModificationCompleted", e.PredecessorTask, e.SuccessorTask, e.OriginalSuccessorTask, e.ChangeType);
        }
        #endregion
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] {"StartupPlan"}; }
        }
        public override GanttControl MainControl {
            get { return ganttControl1; }
        }
        public override bool AllowPrintOptions {
            get { return true; }
        }
        public override bool AllowGenerateReport {
            get { return false; }
        }
        void ceShowBaseLines_CheckedChanged(object sender, EventArgs e) {
            ganttControl1.OptionsView.ShowBaselines = ceShowBaseLines.Checked;
        }
        void btnClearLog_Click(object sender, EventArgs e) {
            meLog.ResetText();
        }
        void ceEnableTracing_CheckedChanged(object sender, EventArgs e) {
            meLog.Enabled = ceEnableTracing.Checked;
        }
        void ceAllowSplitTasks_CheckedChanged(object sender, EventArgs e) {
            ganttControl1.OptionsBehavior.AllowSplitTasks = ceAllowSplitTasks.Checked ? DefaultBoolean.Default : DefaultBoolean.False;
        }
    }
}
