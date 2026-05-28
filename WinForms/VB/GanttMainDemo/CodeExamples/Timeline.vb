Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGantt
Imports DevExpress.XtraGantt.Scheduling
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Timeline", "Timeline.cs")>
    Public Class Timeline

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim ganttControl As DevExpress.XtraGantt.GanttControl = New DevExpress.XtraGantt.GanttControl()
            ganttControl.OptionsBehavior.Editable = False
            ganttControl.Dock = System.Windows.Forms.DockStyle.Fill
            ganttControl.Parent = sampleHost
            ganttControl.TreeListMappings.KeyFieldName = "Id"
            ganttControl.TreeListMappings.ParentFieldName = "ParentId"
            ganttControl.ChartMappings.TextFieldName = "Name"
            ganttControl.ChartMappings.StartDateFieldName = "StartTime"
            ganttControl.ChartMappings.FinishDateFieldName = "EndTime"
            ganttControl.ChartMappings.ProgressFieldName = "Progress"
            ganttControl.ChartMappings.PredecessorsFieldName = "PredecessorIDs"
            ganttControl.ChartMappings.VisibleInTimelineFieldName = ""
            ganttControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.Task.GetData()
            For i As Integer = 0 To 7 - 1
                ganttControl.WorkWeek.Add(New DevExpress.XtraGantt.WorkDayOfWeek(CType(i, System.DayOfWeek), New System.Collections.Generic.List(Of DevExpress.XtraGantt.Scheduling.WorkTime)() From {New DevExpress.XtraGantt.Scheduling.WorkTime(System.TimeSpan.FromHours(0), System.TimeSpan.FromHours(24))}))
            Next

            AddHandler ganttControl.Load, Sub(s, e) ganttControl.ExpandAll()
            ganttControl.ForceInitialize()
            Return New Object() {ganttControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show timeline")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TimelinePosition")>
        Public Shared Sub ShowTimeline(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            ganttControl.OptionsTimeline.TimelinePosition = DevExpress.XtraGantt.TimelinePosition.Top
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Add tasks to the timeline")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ClearTasks", "AddTaskToTimeline")>
        Public Shared Sub OperateTasks(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            ganttControl.OptionsTimeline.TimelinePosition = DevExpress.XtraGantt.TimelinePosition.Top
            ganttControl.AddTaskToTimeline(ganttControl.Nodes(0))
            ganttControl.AddTaskToTimeline(CType(ganttControl.FindNodeByID(3), DevExpress.XtraGantt.GanttControlNode))
            ganttControl.AddTaskToTimeline(CType(ganttControl.FindNodeByID(6), DevExpress.XtraGantt.GanttControlNode))
            ganttControl.AddTaskToTimeline(CType(ganttControl.FindNodeByID(11), DevExpress.XtraGantt.GanttControlNode))
            ganttControl.AddTaskToTimeline(ganttControl.Nodes(CInt((0))).Nodes.LastNode)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Add bars to the timeline")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("AddTimelineBar", "FocusedTimelineBar", "TimelineBars")>
        Public Shared Sub OperateBars(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            ganttControl.OptionsTimeline.TimelinePosition = DevExpress.XtraGantt.TimelinePosition.Top
            ganttControl.AddTaskToTimeline(ganttControl.Nodes(0))
            ganttControl.AddTimelineBar()
            ganttControl.FocusedTimelineBar = ganttControl.TimelineBars(1)
            ganttControl.AddTaskToTimeline(CType(ganttControl.FindNodeByID(3), DevExpress.XtraGantt.GanttControlNode))
            ganttControl.AddTaskToTimeline(CType(ganttControl.FindNodeByID(6), DevExpress.XtraGantt.GanttControlNode))
            ganttControl.AddTaskToTimeline(CType(ganttControl.FindNodeByID(11), DevExpress.XtraGantt.GanttControlNode))
        End Sub
    End Class
End Namespace
