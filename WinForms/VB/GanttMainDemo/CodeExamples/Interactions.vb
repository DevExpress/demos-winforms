Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGantt
Imports DevExpress.Utils.Menu
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports Examples
Imports DevExpress.XtraGantt.Options
Imports DevExpress.XtraGantt.Scheduling
Imports System.Linq

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Interactive editing", "Interactions.cs")>
    Public Module Interactions

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim ganttControl As DevExpress.XtraGantt.GanttControl = New DevExpress.XtraGantt.GanttControl()
            ganttControl.Dock = System.Windows.Forms.DockStyle.Fill
            ganttControl.OptionsCustomization.AllowModifyDependencies = DevExpress.Utils.DefaultBoolean.[True]
            ganttControl.OptionsCustomization.AllowModifyProgress = DevExpress.Utils.DefaultBoolean.[True]
            ganttControl.OptionsCustomization.AllowModifyTasks = DevExpress.Utils.DefaultBoolean.[True]
            ganttControl.OptionsBehavior.ScheduleMode = DevExpress.XtraGantt.Options.ScheduleMode.Manual
            ganttControl.Parent = sampleHost
            ganttControl.TreeListMappings.KeyFieldName = "Id"
            ganttControl.TreeListMappings.ParentFieldName = "ParentId"
            ganttControl.ChartMappings.TextFieldName = "Name"
            ganttControl.ChartMappings.StartDateFieldName = "StartTime"
            ganttControl.ChartMappings.FinishDateFieldName = "EndTime"
            ganttControl.ChartMappings.ProgressFieldName = "Progress"
            ganttControl.ChartMappings.PredecessorsFieldName = "PredecessorIDs"
            For i As Integer = 0 To 7 - 1
                ganttControl.WorkWeek.Add(New DevExpress.XtraGantt.WorkDayOfWeek(CType(i, System.DayOfWeek), New System.Collections.Generic.List(Of DevExpress.XtraGantt.Scheduling.WorkTime)() From {New DevExpress.XtraGantt.Scheduling.WorkTime(System.TimeSpan.FromHours(0), System.TimeSpan.FromHours(24))}))
            Next

            ganttControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.Task.GetData()
            AddHandler ganttControl.Load, Sub(s, e) ganttControl.ExpandAll()
            Return New Object() {ganttControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent users from postponing tasks for more than one day")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TaskMoveCompleted", "Cancel", "CurrentTaskStart", "OriginalTaskStart")>
        Public Sub CancelShiftTask(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            AddHandler ganttControl.TaskMoveCompleted, Sub(sender, e)
                If e.CurrentTaskStart > e.OriginalTaskStart.Value.AddDays(1) Then e.Cancel = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent users from prolonging tasks for more than one day")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TaskFinishDateModificationCompleted", "Cancel", "CurrentTaskFinish", "OriginalTaskFinish")>
        Public Sub CancelTaskFinishDateModification(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            AddHandler ganttControl.TaskFinishDateModificationCompleted, Sub(sender, e)
                If e.CurrentTaskFinish > e.OriginalTaskFinish.Value.AddDays(1) Then e.Cancel = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent users from updating progress for more than 30%")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TaskProgressModificationCompleted", "Cancel", "CurrentProgress", "OriginalProgress")>
        Public Sub CancelTaskProgressModification(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            AddHandler ganttControl.TaskProgressModificationCompleted, Sub(sender, e)
                If System.Math.Abs(e.CurrentProgress - e.OriginalProgress) > 0.3 Then e.Cancel = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent users from Modification a link between two particular tasks")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TaskDependencyModificationCompleted", "Cancel", "PredecessorTask", "OriginalSuccessorTask")>
        Public Sub AdjustTaskDependencyModification(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            AddHandler ganttControl.TaskDependencyModificationCompleted, Sub(sender, e)
                If System.[Object].Equals(e.PredecessorTask.Text, "Develop software") AndAlso System.[Object].Equals(e.OriginalSuccessorTask.Text, "Create software maintenance team") Then e.Cancel = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Highlight created/modified dependencies")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TaskDependencyModified", "CustomDrawTaskDependency", "BackColor", "ProgressColor", "ChangeType")>
        Public Sub HighlightModifiedDependencies(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            Dim modifiedDependencies As System.Collections.Generic.List(Of DevExpress.DXperience.Demos.CodeDemo.Data.DependencyInfo) = New System.Collections.Generic.List(Of DevExpress.DXperience.Demos.CodeDemo.Data.DependencyInfo)()
            Dim createdDependencies As System.Collections.Generic.List(Of DevExpress.DXperience.Demos.CodeDemo.Data.DependencyInfo) = New System.Collections.Generic.List(Of DevExpress.DXperience.Demos.CodeDemo.Data.DependencyInfo)()
            AddHandler ganttControl.TaskDependencyModified, Sub(sender, e)
                If e.PredecessorNode IsNot Nothing AndAlso e.SuccessorNode IsNot Nothing Then
                    Dim dependency As DevExpress.DXperience.Demos.CodeDemo.Data.DependencyInfo = New DevExpress.DXperience.Demos.CodeDemo.Data.DependencyInfo(e.PredecessorNode.Id, e.SuccessorNode.Id)
                    If e.ChangeType = DevExpress.XtraGantt.ChangeType.Modify Then modifiedDependencies.Add(dependency)
                    If e.ChangeType = DevExpress.XtraGantt.ChangeType.Create Then createdDependencies.Add(dependency)
                End If
            End Sub
            AddHandler ganttControl.CustomDrawTaskDependency, Sub(sender, e)
                If e.PredecessorNode IsNot Nothing AndAlso e.SuccessorNode IsNot Nothing Then
                    Dim dependency As DevExpress.DXperience.Demos.CodeDemo.Data.DependencyInfo = New DevExpress.DXperience.Demos.CodeDemo.Data.DependencyInfo(e.PredecessorNode.Id, e.SuccessorNode.Id)
                    Dim modifiedDependency = modifiedDependencies.FirstOrDefault(Function(x) System.[Object].Equals(x, dependency))
                    If modifiedDependency IsNot Nothing Then e.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
                    Dim createdDependency = createdDependencies.FirstOrDefault(Function(x) System.[Object].Equals(x, dependency))
                    If createdDependency IsNot Nothing Then e.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Highlight modified progress, finish date and moved tasks")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TaskMoved", "TaskFinishDateModified", "TaskProgressModified", "CustomDrawTask", "BackColor", "ProgressColor", "TaskMoveStarted", "TaskProgressModificationStarted", "TaskFinishDateModificationStarted")>
        Public Sub HighlightModifiedTaskElements(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            'Initialize
            Dim elementsState As System.Collections.Generic.List(Of DevExpress.DXperience.Demos.CodeDemo.Data.TaskElementsModificationState) = New System.Collections.Generic.List(Of DevExpress.DXperience.Demos.CodeDemo.Data.TaskElementsModificationState)()
            For i As Integer = 0 To ganttControl.AllNodesCount - 1
                elementsState.Add(New DevExpress.DXperience.Demos.CodeDemo.Data.TaskElementsModificationState())
            Next

            AddHandler ganttControl.TaskMoved, Sub(sender, e) elementsState(CInt((e.ProcessedNode.Id))).TaskPositionModified = True
            AddHandler ganttControl.TaskFinishDateModified, Sub(sender, e) elementsState(CInt((e.ProcessedNode.Id))).TaskFinishDateModified = True
            AddHandler ganttControl.TaskProgressModified, Sub(sender, e) elementsState(CInt((e.ProcessedNode.Id))).TaskProgressModified = True
            AddHandler ganttControl.CustomDrawTask, Sub(sender, e)
                Dim state = elementsState(e.Node.Id)
                If state.TaskFinishDateModified Then e.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
                If state.TaskPositionModified Then e.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
                If state.TaskProgressModified Then e.Appearance.ProgressColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
            End Sub
            'Reset states
            AddHandler ganttControl.TaskMoveStarted, Sub(sender, e) elementsState(CInt((e.ProcessedNode.Id))).Reset()
            AddHandler ganttControl.TaskProgressModificationStarted, Sub(sender, e) elementsState(CInt((e.ProcessedNode.Id))).Reset()
            AddHandler ganttControl.TaskFinishDateModificationStarted, Sub(sender, e) elementsState(CInt((e.ProcessedNode.Id))).Reset()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Highlight refused changes")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TaskMoveCanceled", "TaskFinishDateModificationCanceled", "TaskProgressModificationCanceled", "CustomDrawTask", "BackColor", "ProgressColor", "TaskMoveStarted", "TaskProgressModificationStarted", "TaskFinishDateModificationStarted")>
        Public Sub ModificationCanceled(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            'Initialize
            Dim elementsState As System.Collections.Generic.List(Of DevExpress.DXperience.Demos.CodeDemo.Data.TaskElementsModificationState) = New System.Collections.Generic.List(Of DevExpress.DXperience.Demos.CodeDemo.Data.TaskElementsModificationState)()
            For i As Integer = 0 To ganttControl.AllNodesCount - 1
                elementsState.Add(New DevExpress.DXperience.Demos.CodeDemo.Data.TaskElementsModificationState())
            Next

            ' Press Esc to cancel modification
            AddHandler ganttControl.TaskMoveCanceled, Sub(sender, e) elementsState(CInt((e.ProcessedNode.Id))).TaskPositionModified = True
            AddHandler ganttControl.TaskFinishDateModificationCanceled, Sub(sender, e) elementsState(CInt((e.ProcessedNode.Id))).TaskFinishDateModified = True
            AddHandler ganttControl.TaskProgressModificationCanceled, Sub(sender, e) elementsState(CInt((e.ProcessedNode.Id))).TaskProgressModified = True
            AddHandler ganttControl.CustomDrawTask, Sub(sender, e)
                Dim state = elementsState(e.Node.Id)
                If state.TaskFinishDateModified Then e.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
                If state.TaskPositionModified Then e.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
                If state.TaskProgressModified Then e.Appearance.ProgressColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
            End Sub
            'Reset states
            AddHandler ganttControl.TaskMoveStarted, Sub(sender, e) elementsState(CInt((e.ProcessedNode.Id))).Reset()
            AddHandler ganttControl.TaskProgressModificationStarted, Sub(sender, e) elementsState(CInt((e.ProcessedNode.Id))).Reset()
            AddHandler ganttControl.TaskFinishDateModificationStarted, Sub(sender, e) elementsState(CInt((e.ProcessedNode.Id))).Reset()
        End Sub
    '[CodeExampleCase("Adjust task shift")]
    '[CodeExampleUnderlineTokens("ScheduledTaskStart", "ScheduledTaskFinish", "TaskMoving")]
    'public static void ShiftTask(GanttControl ganttControl) {
    '    ganttControl.TaskMoving += (sender, e) => {
    '        if(e.CurrentTaskStart > e.OriginalTaskStart.Value.AddDays(2))
    '            e.Cancel = true;
    '    };
    '}
    '[CodeExampleCase("Adjust task finish date shift")]
    '[CodeExampleUnderlineTokens("ScheduledTaskFinish", "TaskFinishDateModification")]
    'public static void ShiftTaskFinishDate(GanttControl ganttControl) {
    '    ganttControl.TaskFinishDateModification += (sender, e) => {
    '        if(e.CurrentTaskFinish > e.OriginalTaskFinish.Value.AddDays(2))
    '            e.Cancel = true;
    '    };
    '}
    '[CodeExampleCase("Adjust completion progress")]
    '[CodeExampleUnderlineTokens("Progress", "TaskProgressModification")]
    'public static void RecalculateTaskProgress(GanttControl ganttControl) {
    '    ganttControl.TaskProgressModification += (sender, e) => {
    '        float correctionFactor = (float) e.ProcessedNode.GetValue("ProgressCorrectionFactor");
    '        e.CurrentProgress *= correctionFactor;
    '    };
    '}
    End Module
End Namespace
