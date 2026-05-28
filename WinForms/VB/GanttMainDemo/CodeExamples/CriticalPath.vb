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

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Critical Path", "CriticalPath.cs")>
    Public Class Format

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

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show a critical path")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("OptionsView", "CriticalPathTask", "CriticalPathDependency")>
        Public Shared Sub ShowCriticalPath(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            ganttControl.OptionsView.CriticalPathHighlightMode = DevExpress.XtraGantt.CriticalPathHighlightMode.[Single]
            ganttControl.Appearance.CriticalPathTask.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
            ganttControl.Appearance.CriticalPathDependency.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Show multiple critical paths")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("OptionsView", "CriticalPathTask", "CriticalPathDependency")>
        Public Shared Sub ShowMultipleCriticalPaths(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            ganttControl.OptionsView.CriticalPathHighlightMode = DevExpress.XtraGantt.CriticalPathHighlightMode.Multiple
            ganttControl.Appearance.CriticalPathTask.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
            ganttControl.Appearance.CriticalPathDependency.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub
    End Class
End Namespace
