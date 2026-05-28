Imports System

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class AgendaViewModule
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            PrepareViews()
        End Sub

        Private Sub AgendaViewModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerDataStorage1)
            UpdateControls()
        End Sub

        Private Sub PrepareViews()
            schedulerControl.AgendaView.Enabled = True
            schedulerControl.FullWeekView.Enabled = False
            schedulerControl.DayView.Enabled = False
            schedulerControl.WeekView.Enabled = False
            schedulerControl.MonthView.Enabled = False
            schedulerControl.WorkWeekView.Enabled = False
            schedulerControl.TimelineView.Enabled = False
            schedulerControl.GanttView.Enabled = False
        End Sub

        Private Sub UpdateControls()
            spinDaysCount.EditValue = schedulerControl.AgendaView.DayCount
            cbStatus.EditValue = schedulerControl.AgendaView.AppointmentDisplayOptions.StatusDisplayType
            ceShowLabel.Checked = schedulerControl.AgendaView.AppointmentDisplayOptions.ShowLabel
            ceShowResource.Checked = schedulerControl.AgendaView.AppointmentDisplayOptions.ShowResource
        End Sub

        Private Sub spinDaysCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.AgendaView.DayCount = Convert.ToInt32(spinDaysCount.EditValue)
        End Sub

        Private Sub cbStatus_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not GetType(AppointmentStatusDisplayType).IsAssignableFrom(cbStatus.EditValue.GetType()) Then Return
            schedulerControl.AgendaView.AppointmentDisplayOptions.StatusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub ceShowLabel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.AgendaView.AppointmentDisplayOptions.ShowLabel = ceShowLabel.Checked
        End Sub

        Private Sub ceShowResource_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.AgendaView.AppointmentDisplayOptions.ShowResource = ceShowResource.Checked
        End Sub
    End Class
End Namespace
