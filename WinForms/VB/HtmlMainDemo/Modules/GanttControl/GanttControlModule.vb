Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraGantt
Imports DevExpress.XtraGantt.Chart
Imports DevExpress.HTML.Demos.Helpers

Namespace DevExpress.HTML.Demos

    Public Partial Class GanttControlModule
        Inherits TutorialControlBase

        Public Sub New()
            InitializeComponent()
            LoadData()
            Setup()
            '
            AddHandler ganttControl1.QueryItemTemplate, AddressOf GanttControl1_QueryItemTemplate
        End Sub

        Private Sub GanttControl1_QueryItemTemplate(ByVal sender As Object, ByVal e As QueryItemTemplateEventArgs)
            Select Case e.ItemType
                Case GanttChartItemType.Task, GanttChartItemType.SummaryTask
                    e.Template.Assign(TaskTemplate)
                Case GanttChartItemType.Progress, GanttChartItemType.SummaryTaskProgress
                    e.Template.Assign(TaskProgressTemplate)
                Case GanttChartItemType.TextLabel
                    e.Template.Assign(TaskTextLabelTemplate)
            End Select
        End Sub

#Region "Initialization"
        Private Sub Setup()
            ganttControl1.OptionsMainTimeRuler.Unit = GanttTimescaleUnit.Hour
            ganttControl1.OptionsMainTimeRuler.Count = 6
            ganttControl1.ExpandAll()
            templateViewer.Fill(ganttControl1)
        End Sub

        Private Sub LoadData()
            ganttControl1.TreeListMappings.KeyFieldName = "Id"
            ganttControl1.TreeListMappings.ParentFieldName = "ParentId"
            ganttControl1.ChartMappings.StartDateFieldName = "StartDate"
            ganttControl1.ChartMappings.InteractionTooltipTextFieldName = "Name"
            ganttControl1.ChartMappings.FinishDateFieldName = "FinishDate"
            ganttControl1.ChartMappings.DurationFieldName = "Duration"
            ganttControl1.ChartMappings.ProgressFieldName = "Progress"
            ganttControl1.ChartMappings.PredecessorsFieldName = "Predecessors"
            ganttControl1.ChartMappings.TextFieldName = "Resource"
            Dim tasks = GanttControlTask.LoadData()
            ganttControl1.DataSource = tasks
            ganttControl1.ScheduleFromStartDate(tasks(0).StartDate)
        End Sub

#End Region
        Protected Overrides ReadOnly Property WhatsThisCodeFileNames As String()
            Get
                Return New String() {"GanttControlModule"}
            End Get
        End Property
    End Class
End Namespace
