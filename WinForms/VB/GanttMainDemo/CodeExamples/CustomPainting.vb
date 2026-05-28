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
Imports DevExpress.XtraGantt.Scheduling
Imports DevExpress.DXperience.Demos

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Custom painting", "CustomPainting.cs")>
    Public Class CustomPainting

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
            ganttControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.Task.GetData()
            For i As Integer = 0 To 7 - 1
                ganttControl.WorkWeek.Add(New DevExpress.XtraGantt.WorkDayOfWeek(CType(i, System.DayOfWeek), New System.Collections.Generic.List(Of DevExpress.XtraGantt.Scheduling.WorkTime)() From {New DevExpress.XtraGantt.Scheduling.WorkTime(System.TimeSpan.FromHours(0), System.TimeSpan.FromHours(24))}))
            Next

            AddHandler ganttControl.Load, Sub(s, e) ganttControl.ExpandAll()
            Return New Object() {ganttControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Draw striplines")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawTimescaleColumn", "DrawBackground", "DrawHeader")>
        Public Shared Sub DrawStriplines(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            Dim striplineStart As System.DateTime = DevExpress.DXperience.Demos.TutorialConstants.Now.AddHours(5)
            Dim striplineEnd As System.DateTime = striplineStart.AddHours(4)
            Dim striplineColor As System.Drawing.Color = System.Drawing.Color.FromArgb(128, 255, 224, 166)
            AddHandler ganttControl.CustomDrawTimescaleColumn, Sub(sender, e)
                Dim column As DevExpress.XtraGantt.GanttTimescaleColumn = e.Column
                Dim stripLineStartPoint As Single = CSng(System.Math.Max(e.GetPosition(striplineStart), column.Bounds.Left))
                Dim stripLineEndPoint As Single = CSng(System.Math.Min(e.GetPosition(striplineEnd), column.Bounds.Right))
                e.DrawBackground()
                Dim boundsToDraw As System.Drawing.RectangleF = New System.Drawing.RectangleF(stripLineStartPoint, column.Bounds.Y, stripLineEndPoint - stripLineStartPoint, column.Bounds.Height)
                If boundsToDraw.Width > 0 Then e.Cache.FillRectangle(striplineColor, boundsToDraw)
                e.DrawHeader()
                e.Handled = True
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Custom task display text")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomTaskDisplayText", "RightText", "LeftText")>
        Public Shared Sub CustomTaskDisplayText(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            Dim criticalPathIds As System.Collections.Generic.HashSet(Of Integer) = New System.Collections.Generic.HashSet(Of Integer) From {1, 2, 3, 6, 7, 8, 10, 11, 13}
            AddHandler ganttControl.CustomTaskDisplayText, Sub(sender, e)
                Dim taskId As Integer = System.Convert.ToInt32(e.Node.GetValue("Id"))
                If criticalPathIds.Contains(taskId) Then
                    e.RightText = "High priority"
                Else
                    e.RightText = String.Empty
                    e.LeftText = "Normal priority"
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Highlight Tasks and Dependencies")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawTask", "CustomDrawTaskDependency", "BackColor", "ProgressColor")>
        Public Shared Sub DrawHighlightedTasksAndDependencies(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            Dim tasks As System.Collections.Generic.HashSet(Of Integer) = New System.Collections.Generic.HashSet(Of Integer) From {1, 2, 3, 6, 7, 8, 10, 11, 13}
            AddHandler ganttControl.CustomDrawTask, Sub(sender, e)
                Dim taskId As Integer = System.Convert.ToInt32(e.Node.GetValue("Id"))
                If tasks.Contains(taskId) Then
                    e.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
                    e.Appearance.ProgressColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
                End If
            End Sub
            AddHandler ganttControl.CustomDrawTaskDependency, Sub(sender, e)
                Dim predecessorId As Integer = System.Convert.ToInt32(e.PredecessorNode.GetValue("Id"))
                Dim successorId As Integer = System.Convert.ToInt32(e.SuccessorNode.GetValue("Id"))
                If tasks.Contains(predecessorId) AndAlso tasks.Contains(successorId) Then
                    e.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show a deadline")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomDrawTimescaleColumn", "FillRectangle")>
        Public Shared Sub DrawCustomTimescaleColumn(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            Dim deadLine As System.DateTime = DevExpress.DXperience.Demos.CodeDemo.Data.TaskStorage.GetFinishDateFromTask("Deploy Beta")
            AddHandler ganttControl.CustomDrawTimescaleColumn, Sub(sender, e)
                Dim column As DevExpress.XtraGantt.GanttTimescaleColumn = e.Column
                If column.StartDate <= deadLine AndAlso column.FinishDate >= deadLine Then
                    e.DrawBackground()
                    Dim x As Single = CSng(e.GetPosition(deadLine))
                    Dim width As Single = 4
                    Dim deadLineRect As System.Drawing.RectangleF = New System.Drawing.RectangleF(x, column.Bounds.Y, width, column.Bounds.Height)
                    e.Cache.FillRectangle(DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger, deadLineRect)
                    e.DrawHeader()
                    e.Handled = True
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Highlight Tasks in Timeline")>
        Public Shared Sub DrawCustomTimelineTask(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            ganttControl.OptionsTimeline.TimelinePosition = DevExpress.XtraGantt.TimelinePosition.Top
            AddHandler ganttControl.CustomDrawTimelineTask, Sub(sender, e)
                If e.Task.Type = DevExpress.XtraGantt.Scheduling.GanttControlTaskType.SummaryTask Then
                    e.Cache.FillRectangle(DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning, e.Task.Bounds)
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Customize text in tasks in timeline")>
        Public Shared Sub CustomizeTimelineTaskText(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            ganttControl.OptionsTimeline.TimelinePosition = DevExpress.XtraGantt.TimelinePosition.Top
            AddHandler ganttControl.CustomTimelineItemText, Sub(sender, e)
                If e.Task.Type = DevExpress.XtraGantt.Scheduling.GanttControlTaskType.SummaryTask Then
                    e.Caption = "Work being done"
                    e.Details = System.[String].Format("From {0} to {1}", e.Task.Start, e.Task.Finish)
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Customize timeline bar appearance")>
        Public Shared Sub CustomizeTimelineBar(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            ganttControl.OptionsTimeline.TimelinePosition = DevExpress.XtraGantt.TimelinePosition.Top
            AddHandler ganttControl.CustomDrawTimelineBar, Sub(sender, e)
                If e.Bar.Nodes.Count > 0 Then Return
                e.Appearance.BackColor = System.Drawing.Color.GreenYellow
                e.EmptyText = "There is nothing here"
            End Sub
        End Sub
    End Class
End Namespace
