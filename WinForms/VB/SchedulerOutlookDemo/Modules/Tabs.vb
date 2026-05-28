Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports DevExpress.XtraScheduler.Demos.DemoData

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class Tabs
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            HideUnusedViews()
        End Sub

        Public Overrides ReadOnly Property Scheduler As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Private Sub Tabs_Load(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.Start = SchedulerDataHelper.Start
            SchedulerDataHelper.Attach(Scheduler, False)
            ResetOptions()
        End Sub

        Public Overrides Sub ResetOptions()
            MyBase.ResetOptions()
            Scheduler.BeginUpdate()
            GroupByParentId()
            Scheduler.DayView.DayCount = 3
            Scheduler.GroupType = SchedulerGroupType.Resource
            Scheduler.DayView.ResourcesPerPage = 2
            Scheduler.DayView.ShowWorkTimeOnly = True
            Scheduler.WorkWeekView.ShowWorkTimeOnly = True
            Scheduler.WorkWeekView.ResourcesPerPage = 2
            Scheduler.FullWeekView.ShowWorkTimeOnly = True
            Scheduler.FullWeekView.ResourcesPerPage = 2
            cmbAppointmentDisplayMode.EditValue = AppointmentDisplayMode.AllResources
            cmbResourceDisplayStyle.EditValue = ResourceDisplayStyle.Tabs
            chkShowAddButton.Checked = Scheduler.OptionsView.ResourceCategories.ShowAddButton
            chkShowCloseButton.Checked = Scheduler.OptionsView.ResourceCategories.ShowCloseButton
            Scheduler.EndUpdate()
        End Sub

        Private Sub GroupByParentId()
            Dim categories = schedulerDataStorage1.Resources.Items.GroupBy(Function(x) If(x.ParentId, x.Id)).[Select](Function(x) New ResourceCategory(x))
            For Each category As ResourceCategory In categories
                Scheduler.ResourceCategories.Add(category)
            Next
        End Sub

        Private Sub HideUnusedViews()
            schedulerControl.AgendaView.Enabled = False
        End Sub

        Private Sub cmbAppointmentDisplayMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.OptionsView.ResourceCategories.AppointmentDisplayMode = CType(cmbAppointmentDisplayMode.EditValue, AppointmentDisplayMode)
        End Sub

        Private Sub cmbResourceDisplayStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.OptionsView.ResourceCategories.ResourceDisplayStyle = CType(cmbResourceDisplayStyle.EditValue, ResourceDisplayStyle)
        End Sub

        Private Sub chkShowAddButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.OptionsView.ResourceCategories.ShowAddButton = chkShowAddButton.Checked
        End Sub

        Private Sub chkShowCloseButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.OptionsView.ResourceCategories.ShowCloseButton = chkShowCloseButton.Checked
        End Sub
    End Class
End Namespace
