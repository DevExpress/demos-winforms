Imports System

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class WorkWeekViewModule
        Inherits TutorialControl

        Private ReadOnly Property TimeIndicatorDisplayOptions As TimeIndicatorDisplayOptions
            Get
                Return CType(schedulerControl.WorkWeekView.TimeIndicatorDisplayOptions, TimeIndicatorDisplayOptions)
            End Get
        End Property

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            PrepareViews()
            weekDaysCheckEdit1.WeekDays = WeekDays.WorkDays
        End Sub

        Private Sub PrepareViews()
            schedulerControl.DayView.Enabled = False
            schedulerControl.WeekView.Enabled = False
            schedulerControl.MonthView.Enabled = False
            schedulerControl.TimelineView.Enabled = False
            schedulerControl.AgendaView.Enabled = False
        End Sub

        Private Sub WorkWeekViewModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerDataStorage)
            chkShowOverAppointment.Checked = TimeIndicatorDisplayOptions.ShowOverAppointment
            cbTimeIndicatorVisibility.EditValue = TimeIndicatorDisplayOptions.Visibility
            cbTimeMarkerVisibility.EditValue = schedulerControl.WorkWeekView.TimeMarkerVisibility
        End Sub

        Private Sub weekDaysCheckEdit1_WeekDaysChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim workDays As WorkDaysCollection = schedulerControl.WorkDays
            workDays.BeginUpdate()
            workDays.Clear()
            If weekDaysCheckEdit1.WeekDays <> CType(0, WeekDays) Then workDays.Add(New WeekDaysWorkDay(weekDaysCheckEdit1.WeekDays))
            workDays.EndUpdate()
        End Sub

        Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.Menu.Id = SchedulerMenuItemId.DefaultMenu OrElse e.Menu.Id = SchedulerMenuItemId.RulerMenu Then
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
            End If
        End Sub

        Private Sub WorkWeekViewModule_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.ActiveViewType = SchedulerViewType.WorkWeek
        End Sub

        Private Sub chkShowOverAppointment_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked
        End Sub

        Private Sub cbTimeIndicatorVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            TimeIndicatorDisplayOptions.Visibility = CType(cbTimeIndicatorVisibility.EditValue, TimeIndicatorVisibility)
        End Sub

        Private Sub cbTimeMarkerVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.WorkWeekView.TimeMarkerVisibility = CType(cbTimeMarkerVisibility.EditValue, TimeMarkerVisibility)
        End Sub
    End Class
End Namespace
