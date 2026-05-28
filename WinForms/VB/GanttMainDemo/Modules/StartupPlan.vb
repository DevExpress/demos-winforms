Imports System
Imports System.Collections.Generic
Imports DevExpress.Utils
Imports DevExpress.XtraGantt.Demos.Utils
Imports DevExpress.XtraGantt.Options
Imports DevExpress.XtraGantt.Scheduling

Namespace DevExpress.XtraGantt.Demos

    Public Partial Class StartupPlan
        Inherits TutorialControl

        Private ReadOnly logger As EventLogger

        Public Sub New()
            InitializeComponent()
            ganttControl1.TreeListMappings.ParentFieldName = "ParentUID"
            ganttControl1.TreeListMappings.KeyFieldName = "UID"
            ganttControl1.ChartMappings.TextFieldName = "Resources"
            ganttControl1.ChartMappings.InteractionTooltipTextFieldName = "Name"
            ganttControl1.SplitTaskMappings.StartDateFieldName = "StartDate"
            ganttControl1.SplitTaskMappings.DurationFieldName = "Duration"
            ganttControl1.SplitTaskMappings.KeyFieldName = "UID"
            ganttControl1.OptionsBehavior.ScheduleMode = ScheduleMode.Auto
            LoadData()
            '
            ganttControl1.OptionsView.ShowBaselines = True
            ceShowBaseLines.Checked = ganttControl1.OptionsView.ShowBaselines
            ceAllowSplitTasks.Checked = ganttControl1.OptionsBehavior.AllowSplitTasks <> DefaultBoolean.False
            ganttControl1.ExpandAll()
            meLog.Enabled = ceEnableTracing.Checked
            SubscribeEvents()
            logger = New EventLogger(meLog)
        End Sub

        Private Sub LoadData()
            Dim tasks As IList(Of TaskDataItem)
            Using stream = LoadXml("StartupPlan.xml")
                tasks = LoadModel(stream)
            End Using

            If tasks IsNot Nothing Then
                ganttControl1.DataSource = tasks
                Dim splitInfo As List(Of TaskSplitInfo) = New List(Of TaskSplitInfo)()
                splitInfo.Add(New TaskSplitInfo() With {.UID = "8", .StartDate = tasks(8).StartDate + TimeSpan.FromHours(2), .Duration = TimeSpan.FromHours(8)})
                splitInfo.Add(New TaskSplitInfo() With {.UID = "9", .StartDate = tasks(9).StartDate + TimeSpan.FromHours(5), .Duration = TimeSpan.FromDays(1)})
                splitInfo.Add(New TaskSplitInfo() With {.UID = "10", .StartDate = tasks(10).StartDate + TimeSpan.FromHours(4), .Duration = TimeSpan.FromHours(4)})
                splitInfo.Add(New TaskSplitInfo() With {.UID = "10", .StartDate = tasks(10).StartDate + TimeSpan.FromDays(2) + TimeSpan.FromHours(2), .Duration = TimeSpan.FromHours(4)})
                ganttControl1.SplitTaskSource = splitInfo
                '
                Dim offsets = New List(Of TaskItemBaseLineOffset)(tasks.Count)
                Using stream = LoadXml("StartupPlanBaselinesInfo.xml")
                    offsets = SafeXml.Deserialize(Of List(Of TaskItemBaseLineOffset))(stream)
                End Using

                If offsets IsNot Nothing Then
                    For i As Integer = 0 To offsets.Count - 1
                        tasks(i).BaselineStartDate = tasks(i).StartDate + TimeSpan.FromTicks(offsets(i).BaselineStartOffset)
                        tasks(i).BaselineFinishDate = tasks(i).StartDate + TimeSpan.FromTicks(offsets(i).BaselineFinishOffset)
                    Next
                End If
            End If
        End Sub

#Region "EventLogging"
        Private Sub SubscribeEvents()
            AddHandler ganttControl1.TaskDependencyModificationCompleted, AddressOf GanttControl1_TaskDependencyModificationCompleted
            AddHandler ganttControl1.TaskDependencyModificationCanceled, AddressOf GanttControl1_TaskDependencyModificationCanceled
            AddHandler ganttControl1.TaskDependencyModified, AddressOf GanttControl1_TaskDependencyModified
            AddHandler ganttControl1.TaskMoveStarted, AddressOf GanttControl1_TaskMoveStarted
            AddHandler ganttControl1.TaskMoveCompleted, AddressOf GanttControl1_TaskMoveCompleted
            AddHandler ganttControl1.TaskMoveCanceled, AddressOf GanttControl1_TaskMoveCanceled
            AddHandler ganttControl1.TaskMoved, AddressOf GanttControl1_TaskMoved
            AddHandler ganttControl1.TaskFinishDateModificationStarted, AddressOf GanttControl1_TaskFinishDateModificationStarted
            AddHandler ganttControl1.TaskFinishDateModificationCompleted, AddressOf GanttControl1_TaskFinishDateModificationCompleted
            AddHandler ganttControl1.TaskFinishDateModificationCanceled, AddressOf GanttControl1_TaskFinishDateModificationCanceled
            AddHandler ganttControl1.TaskFinishDateModified, AddressOf GanttControl1_TaskFinishDateModified
            AddHandler ganttControl1.TaskProgressModificationStarted, AddressOf GanttControl1_TaskProgressModificationStarted
            AddHandler ganttControl1.TaskProgressModificationCanceled, AddressOf GanttControl1_TaskProgressModificationCanceled
            AddHandler ganttControl1.TaskProgressModified, AddressOf GanttControl1_TaskProgressModified
            AddHandler ganttControl1.TaskProgressModificationCompleted, AddressOf GanttControl1_TaskProgressModificationCompleted
        End Sub

        Private Sub AppendProgressInfo(ByVal eventName As String, ByVal processedTask As GanttControlTask, ByVal currentProgress As Single)
            logger.Append(eventName)
            logger.AppendWithIndent(String.Format("Task: {0}", processedTask.TooltipText))
            logger.AppendWithIndent(String.Format("Progress: {0}%", Math.Round(currentProgress * 100, 1)))
        End Sub

        Private Sub GanttControl1_TaskProgressModified(ByVal sender As Object, ByVal e As TaskProgressModifiedEventArgs)
            AppendProgressInfo("TaskProgressModified", e.ProcessedTask, e.CurrentProgress)
        End Sub

        Private Sub GanttControl1_TaskProgressModificationCanceled(ByVal sender As Object, ByVal e As TaskProgressModificationCanceledEventArgs)
            AppendProgressInfo("TaskProgressModificationCanceled", e.ProcessedTask, e.CurrentProgress)
        End Sub

        Private Sub GanttControl1_TaskProgressModificationStarted(ByVal sender As Object, ByVal e As TaskProgressModificationEventArgs)
            AppendProgressInfo("TaskProgressModificationStarted", e.ProcessedTask, e.CurrentProgress)
        End Sub

        Private Sub GanttControl1_TaskProgressModificationCompleted(ByVal sender As Object, ByVal e As TaskProgressModificationEventArgs)
            AppendProgressInfo("TaskProgressModificationCompleted", e.ProcessedTask, e.CurrentProgress)
        End Sub

        Private Sub AppendTaskFinishDateInfo(ByVal eventName As String, ByVal processedTask As GanttControlTask, ByVal finishDate As Date?)
            logger.Append(eventName)
            logger.AppendWithIndent(String.Format("Task: {0}", processedTask.TooltipText))
            logger.AppendWithIndent(String.Format("Finish Date: {0}", finishDate))
        End Sub

        Private Sub GanttControl1_TaskFinishDateModified(ByVal sender As Object, ByVal e As TaskFinishModifiedEventArgs)
            AppendTaskFinishDateInfo("TaskFinishDateModified", e.ProcessedTask, e.OriginalTaskFinish)
        End Sub

        Private Sub GanttControl1_TaskFinishDateModificationCompleted(ByVal sender As Object, ByVal e As TaskFinishModificationEventArgs)
            AppendTaskFinishDateInfo("TaskFinishDateModificationCompleted", e.ProcessedTask, e.OriginalTaskFinish)
        End Sub

        Private Sub GanttControl1_TaskFinishDateModificationCanceled(ByVal sender As Object, ByVal e As TaskFinishModificationCanceledEventArgs)
            AppendTaskFinishDateInfo("TaskFinishDateModificationCanceled", e.ProcessedTask, e.OriginalTaskFinish)
        End Sub

        Private Sub GanttControl1_TaskFinishDateModificationStarted(ByVal sender As Object, ByVal e As TaskFinishModificationEventArgs)
            AppendTaskFinishDateInfo("TaskFinishDateModificationStarted", e.ProcessedTask, e.OriginalTaskFinish)
        End Sub

        Private Sub AppendTaskMovingInfo(ByVal eventName As String, ByVal processedTask As GanttControlTask, ByVal taskStart As Date?, ByVal taskFinish As Date?)
            logger.Append(eventName)
            logger.AppendWithIndent(String.Format("Task: {0}", processedTask.TooltipText))
            logger.AppendWithIndent(String.Format("Start Date: {0}", taskStart))
            logger.AppendWithIndent(String.Format("Finish Date: {0}", taskFinish))
        End Sub

        Private Sub GanttControl1_TaskMoved(ByVal sender As Object, ByVal e As TaskMovedEventArgs)
            AppendTaskMovingInfo("TaskMoved", e.ProcessedTask, e.OriginalTaskStart, e.OriginalTaskFinish)
        End Sub

        Private Sub GanttControl1_TaskMoveCompleted(ByVal sender As Object, ByVal e As TaskMovingEventArgs)
            AppendTaskMovingInfo("TaskMoveCompleted", e.ProcessedTask, e.OriginalTaskStart, e.OriginalTaskFinish)
        End Sub

        Private Sub AppendTaskMoveInfo(ByVal eventName As String, ByVal processedTask As GanttControlTask, ByVal scheduledDate As Date?)
            logger.Append(eventName)
            logger.AppendWithIndent(String.Format("Task: {0}", processedTask.TooltipText))
            logger.AppendWithIndent(String.Format("Start Date: {0}", scheduledDate))
        End Sub

        Private Sub GanttControl1_TaskMoveCanceled(ByVal sender As Object, ByVal e As TaskMoveCanceledEventArgs)
            AppendTaskMoveInfo("TaskMoveCanceled", e.ProcessedTask, e.ProcessedTask.ScheduledStartDate)
        End Sub

        Private Sub GanttControl1_TaskMoveStarted(ByVal sender As Object, ByVal e As TaskMovingEventArgs)
            AppendTaskMoveInfo("TaskMoveStarted", e.ProcessedTask, e.OriginalTaskStart)
        End Sub

        Private Sub AppendDependencyModificationInfo(ByVal eventName As String, ByVal predecessorTask As GanttControlTask, ByVal successorTask As GanttControlTask, ByVal originalSuccessorsTask As GanttControlTask, ByVal ct As ChangeType)
            logger.Append(eventName)
            logger.AppendWithIndent(String.Format("Predecessor: {0}", predecessorTask.TooltipText))
            If successorTask IsNot Nothing Then logger.AppendWithIndent(String.Format("Successor: {0}", successorTask.TooltipText))
            If originalSuccessorsTask IsNot Nothing Then logger.AppendWithIndent(String.Format("Original Successor: {0}", originalSuccessorsTask.TooltipText))
            logger.AppendWithIndent(String.Format("Change Type: {0}", ct))
        End Sub

        Private Sub GanttControl1_TaskDependencyModified(ByVal sender As Object, ByVal e As TaskDependencyModificationEventArgs)
            AppendDependencyModificationInfo("TaskDependencyModified", e.PredecessorTask, e.SuccessorTask, e.OriginalSuccessorTask, e.ChangeType)
        End Sub

        Private Sub GanttControl1_TaskDependencyModificationCanceled(ByVal sender As Object, ByVal e As TaskDependencyModificationEventArgs)
            AppendDependencyModificationInfo("TaskDependencyModificationCanceled", e.PredecessorTask, e.SuccessorTask, e.OriginalSuccessorTask, e.ChangeType)
        End Sub

        Private Sub GanttControl1_TaskDependencyModificationCompleted(ByVal sender As Object, ByVal e As TaskDependencyModificationCancelEventArgs)
            AppendDependencyModificationInfo("TaskDependencyModificationCompleted", e.PredecessorTask, e.SuccessorTask, e.OriginalSuccessorTask, e.ChangeType)
        End Sub

#End Region
        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"StartupPlan"}
            End Get
        End Property

        Public Overrides ReadOnly Property MainControl As GanttControl
            Get
                Return ganttControl1
            End Get
        End Property

        Public Overrides ReadOnly Property AllowPrintOptions As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property AllowGenerateReport As Boolean
            Get
                Return False
            End Get
        End Property

        Private Sub ceShowBaseLines_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsView.ShowBaselines = ceShowBaseLines.Checked
        End Sub

        Private Sub btnClearLog_Click(ByVal sender As Object, ByVal e As EventArgs)
            meLog.ResetText()
        End Sub

        Private Sub ceEnableTracing_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            meLog.Enabled = ceEnableTracing.Checked
        End Sub

        Private Sub ceAllowSplitTasks_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            ganttControl1.OptionsBehavior.AllowSplitTasks = If(ceAllowSplitTasks.Checked, DefaultBoolean.Default, DefaultBoolean.False)
        End Sub
    End Class
End Namespace
