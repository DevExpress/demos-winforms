Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler.Demos.DemoData
Imports DevExpress.Utils

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class YearViewModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            HideUnusedViews()
            cbFirstDayOfWeek.Properties.Items.AddEnum(GetType(FirstDayOfWeek))
            cbFirstDayOfWeek.EditValue = Scheduler.OptionsView.FirstDayOfWeek
            cbHighlightWeekends.Properties.Items.AddEnum(GetType(DefaultBoolean))
            cbHighlightWeekends.EditValue = Scheduler.Views.YearView.HighlightWeekends
            cbShowOutOfScopeDays.Properties.Items.AddEnum(GetType(DefaultBoolean))
            cbShowOutOfScopeDays.EditValue = Scheduler.Views.YearView.ShowOutOfScopeDays
            schedulerControl.YearView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Never
            cbStretchAppointmentsMode.EditValue = StretchAppointmentsMode.GrowAndShrink
            chkStretchAppointments.Checked = Scheduler.YearView.AppointmentDisplayOptions.StretchAppointments
            commonRibbon.GroupByRibbonPageGroupVisible = False
            commonRibbon.SwitchViewPageGroupVisible = False
            UpdateAppointmentHeight()
        End Sub

        Public Overrides ReadOnly Property Scheduler As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Public Overrides ReadOnly Property CommonRibbonPanel As CommonRibbon
            Get
                Return commonRibbon
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsPane As Control
            Get
                Return spOptionPanel
            End Get
        End Property

        Private Sub OnMonthCountEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.YearView.MonthCount = CInt(spinMonthCount.Value)
        End Sub

        Private Sub OnFirstDayOfWeekSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.OptionsView.FirstDayOfWeek = CType(cbFirstDayOfWeek.EditValue, FirstDayOfWeek)
        End Sub

        Private Sub cbHighlightWeekends_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.Views.YearView.HighlightWeekends = CType(cbHighlightWeekends.EditValue, DefaultBoolean)
        End Sub

        Private Sub cbShowOutOfScopeDays_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.Views.YearView.ShowOutOfScopeDays = CType(cbShowOutOfScopeDays.EditValue, DefaultBoolean)
        End Sub

        Private Sub OnAppointmentHeightEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateAppointmentHeight()
        End Sub

        Private Sub UpdateAppointmentHeight()
            Scheduler.YearView.AppointmentDisplayOptions.AppointmentHeight = CInt(spinAppointmentHeight.Value)
        End Sub

        Private Sub HideUnusedViews()
            schedulerControl.DayView.Enabled = False
            schedulerControl.WeekView.Enabled = False
            schedulerControl.WorkWeekView.Enabled = False
            schedulerControl.TimelineView.Enabled = False
            schedulerControl.AgendaView.Enabled = False
            schedulerControl.MonthView.Enabled = False
            schedulerControl.YearView.Enabled = True
        End Sub

        Private Sub YearView_Load(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.Start = New DateTime(Date.Now.Year, 1, 1)
            SchedulerDataHelper.AttachYearView(Scheduler)
            ResetOptions()
        End Sub

        Private Sub cbStretchAppointmentsMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.YearView.AppointmentDisplayOptions.StretchAppointmentsMode = CType(cbStretchAppointmentsMode.EditValue, StretchAppointmentsMode)
        End Sub

        Private Sub chkStretchAppointments_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.YearView.AppointmentDisplayOptions.StretchAppointments = chkStretchAppointments.Checked
        End Sub
    End Class
End Namespace
