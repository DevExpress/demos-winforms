Imports DevExpress.XtraGantt.Scheduling
Imports System
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGantt
Imports System.Collections.Generic

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Data-binding modes", "DataBinding.cs")>
    Public Module DataBindingModes

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim ganttControl As DevExpress.XtraGantt.GanttControl = New DevExpress.XtraGantt.GanttControl()
            ganttControl.OptionsBehavior.Editable = False
            ganttControl.Dock = System.Windows.Forms.DockStyle.Fill
            ganttControl.Parent = sampleHost
            ganttControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.Task.GetData()
            AddHandler ganttControl.Load, Sub(s, e) ganttControl.ExpandAll()
            For i As Integer = 0 To 7 - 1
                ganttControl.WorkWeek.Add(New DevExpress.XtraGantt.WorkDayOfWeek(CType(i, System.DayOfWeek), New System.Collections.Generic.List(Of DevExpress.XtraGantt.Scheduling.WorkTime)() From {New DevExpress.XtraGantt.Scheduling.WorkTime(System.TimeSpan.FromHours(0), System.TimeSpan.FromHours(24))}))
            Next

            Return New Object() {ganttControl}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Map data source fields to task and node properties"), Examples.TaskCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("TreeListMappings", "ChartMappings", "DataSource")>
        Public Sub InitializeMappings(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            ' TreeList Mappings
            ganttControl.TreeListMappings.KeyFieldName = "Id"
            ganttControl.TreeListMappings.ParentFieldName = "ParentId"
            ' Chart Mappings
            ganttControl.ChartMappings.TextFieldName = "Name"
            ganttControl.ChartMappings.StartDateFieldName = "StartTime"
            ganttControl.ChartMappings.FinishDateFieldName = "EndTime"
            ganttControl.ChartMappings.ProgressFieldName = "Progress"
            ganttControl.ChartMappings.PredecessorsFieldName = "PredecessorIDs"
            ' Assign the datasource
            ganttControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.Task.LoadData()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Use a data source to specify dependencies"), Examples.TaskCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("DependencyMappings", "DependencySource")>
        Public Sub InitializeDependencySource(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            ' Dependency Mappings
            ganttControl.DependencyMappings.PredecessorFieldName = "PredecessorID"
            ganttControl.DependencyMappings.SuccessorFieldName = "SuccessorID"
            ganttControl.DependencyMappings.TypeFieldName = "DependencyType"
            ganttControl.DependencyMappings.LagFieldName = "Lag"
            ' Assign the dependency source
            ganttControl.DependencySource = DevExpress.DXperience.Demos.CodeDemo.Data.Dependency.LoadData()
            ' TreeList Mappings
            ganttControl.TreeListMappings.KeyFieldName = "Id"
            ganttControl.TreeListMappings.ParentFieldName = "ParentId"
            ' Chart Mappings
            ganttControl.ChartMappings.TextFieldName = "Name"
            ganttControl.ChartMappings.StartDateFieldName = "StartTime"
            ganttControl.ChartMappings.FinishDateFieldName = "EndTime"
            ganttControl.ChartMappings.ProgressFieldName = "Progress"
            ' Assign the datasource
            ganttControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.Task.LoadData()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Use a data source to specify task splits"), Examples.TaskCS, Examples.SplitInfoCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("DependencyMappings", "DependencySource")>
        Public Sub InitializeTaskSplitSource(ByVal ganttControl As DevExpress.XtraGantt.GanttControl)
            ' TreeList Mappings
            ganttControl.TreeListMappings.KeyFieldName = "Id"
            ganttControl.TreeListMappings.ParentFieldName = "ParentId"
            ' Chart Mappings
            ganttControl.ChartMappings.TextFieldName = "Name"
            ganttControl.ChartMappings.StartDateFieldName = "StartTime"
            ganttControl.ChartMappings.FinishDateFieldName = "EndTime"
            ganttControl.ChartMappings.ProgressFieldName = "Progress"
            ganttControl.ChartMappings.PredecessorsFieldName = "PredecessorIDs"
            ' Assign the datasource
            ganttControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.Task.LoadData()
            ' Task Split Mappings
            ganttControl.SplitTaskMappings.StartDateFieldName = "Start"
            ganttControl.SplitTaskMappings.DurationFieldName = "Duration"
            ganttControl.SplitTaskMappings.KeyFieldName = "ID"
            ' Assign task splits
            ganttControl.SplitTaskSource = DevExpress.DXperience.Demos.CodeDemo.Data.SplitInfo.GetData()
        End Sub
    End Module
End Namespace
