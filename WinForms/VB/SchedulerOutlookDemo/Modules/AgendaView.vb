Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler.Demos.DemoData

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class AgendaViewModule
        Inherits TutorialControl

        Const AppointmentCss As String = "
.subject {
    font-size: 1em;
    font-weight: bold;
}
.description {
    font-size: 1em;
}
.location {
    font-weight: bold;
}
"

        Const AppointmentTemplate As String = "
            <div class=""subject"">${Appointment.Subject}</div>
            <p class=""description"">${Appointment.Description}</p>
            <p class=""location"">${Appointment.Location}</p>
"

        Public Sub New()
            InitializeComponent()
            HideUnusedViews()
        End Sub

        Public Overrides ReadOnly Property Scheduler As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsPane As Control
            Get
                Return spOptionPane
            End Get
        End Property

        Private Sub AgendaViewModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.Start = SchedulerDataHelper.Start
            SchedulerDataHelper.Attach(Scheduler)
            ResetOptions()
        End Sub

        Private Sub spinDaysCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.AgendaView.DayCount = Convert.ToInt32(spinDaysCount.EditValue)
        End Sub

        Private Sub cbStatus_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not GetType(AppointmentStatusDisplayType).IsAssignableFrom(cbStatus.EditValue.GetType()) Then Return
            Scheduler.AgendaView.AppointmentDisplayOptions.StatusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub ceShowLabel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.AgendaView.AppointmentDisplayOptions.ShowLabel = ceShowLabel.Checked
        End Sub

        Private Sub ceShowResource_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.AgendaView.AppointmentDisplayOptions.ShowResource = ceShowResource.Checked
        End Sub

        Private Sub chkAllowHtml_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If chkAllowHtmlText.Checked Then
                schedulerControl.AgendaView.HtmlTemplates.Appointment.Template = AppointmentTemplate
                schedulerControl.AgendaView.HtmlTemplates.Appointment.Styles = AppointmentCss
            Else
                schedulerControl.AgendaView.HtmlTemplates.Appointment.Template = String.Empty
                schedulerControl.AgendaView.HtmlTemplates.Appointment.Styles = String.Empty
            End If

            Scheduler.AgendaView.AppointmentDisplayOptions.AllowMultiLineSubject = chkAllowHtmlText.Checked
        End Sub

        Private Sub HideUnusedViews()
            Scheduler.AgendaView.Enabled = True
            Scheduler.FullWeekView.Enabled = False
            Scheduler.DayView.Enabled = False
            Scheduler.WeekView.Enabled = False
            Scheduler.MonthView.Enabled = False
            Scheduler.WorkWeekView.Enabled = False
            Scheduler.TimelineView.Enabled = False
            Scheduler.GanttView.Enabled = False
            Scheduler.YearView.Enabled = False
        End Sub

        Public Overrides Sub ResetOptions()
            MyBase.ResetOptions()
            Scheduler.BeginUpdate()
            Try
                spinDaysCount.EditValue = 10
                cbStatus.EditValue = AppointmentStatusDisplayType.Bounds
                ceShowLabel.Checked = True
                ceShowResource.Checked = False
                chkAllowHtmlText.Checked = True
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub

        Friend Overrides Sub UpdateOptionsFromControl()
            MyBase.UpdateOptionsFromControl()
            Scheduler.BeginUpdate()
            Try
                spinDaysCount.EditValue = Scheduler.AgendaView.DayCount
                cbStatus.EditValue = Scheduler.AgendaView.AppointmentDisplayOptions.StatusDisplayType
                ceShowLabel.Checked = Scheduler.AgendaView.AppointmentDisplayOptions.ShowLabel
                ceShowResource.Checked = Scheduler.AgendaView.AppointmentDisplayOptions.ShowResource
                chkAllowHtmlText.Checked = Not Equals(Scheduler.AgendaView.HtmlTemplates.Appointment.Template, Nothing)
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
