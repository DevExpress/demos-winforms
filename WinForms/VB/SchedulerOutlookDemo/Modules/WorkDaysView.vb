Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler.Demos.DemoData

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class WorkWeekViewModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            HideUnusedViews()
            weekDaysCheckEdit1.WeekDays = WeekDays.WorkDays
            weekDaysCheckEdit1.MinimumSize = New System.Drawing.Size(0, 20)
            layoutControlItem1.MinSize = New System.Drawing.Size(0, 20)
        End Sub

        Public Overrides ReadOnly Property Scheduler As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Public Overrides ReadOnly Property CommonRibbonPanel As CommonRibbon
            Get
                Return commonRibbon1
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsPane As Control
            Get
                Return spOptionsPane
            End Get
        End Property

        Public Overrides Sub ResetOptions()
            MyBase.ResetOptions()
            Scheduler.BeginUpdate()
            Try
                chkShowOverAppointment.Checked = True
                cbTimeIndicatorVisibility.EditValue = TimeIndicatorVisibility.DaysBeforeToday
                cbTimeMarkerVisibility.EditValue = TimeMarkerVisibility.TodayView
                cbTimeMarkerStyle.EditValue = TimeMarkerStyle.Default
                weekDaysCheckEdit1.WeekDays = WeekDays.WorkDays
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub

        Friend Overrides Sub UpdateOptionsFromControl()
            MyBase.UpdateOptionsFromControl()
            Scheduler.BeginUpdate()
            Try
                chkShowWorkTimeOnly.Checked = Scheduler.WorkWeekView.ShowWorkTimeOnly
                chkShowOverAppointment.Checked = Scheduler.WorkWeekView.TimeIndicatorDisplayOptions.ShowOverAppointment
                cbTimeIndicatorVisibility.EditValue = Scheduler.WorkWeekView.TimeIndicatorDisplayOptions.Visibility
                cbTimeMarkerVisibility.EditValue = Scheduler.WorkWeekView.TimeMarkerVisibility
                cbTimeMarkerStyle.EditValue = Scheduler.WorkWeekView.TimeMarkerStyle
                weekDaysCheckEdit1.WeekDays = schedulerControl.WorkDays.GetWeekDays()
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub

        Protected Overrides Function GetGlobalOptionIgnoreList() As IEnumerable(Of String)
            Return New String() {"ShowTimeIndicatorOverAppointment", "TimeMarkerVisibility", "WorkDays"}
        End Function

        Private Sub WorkWeekViewModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.Start = SchedulerDataHelper.Start
            SchedulerDataHelper.Attach(schedulerControl)
            TimeRegionHelper.Attach(Scheduler)
            ResetOptions()
        End Sub

        Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.Menu.Id = SchedulerMenuItemId.DefaultMenu OrElse e.Menu.Id = SchedulerMenuItemId.RulerMenu Then e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
        End Sub

        Private Sub WorkWeekViewModule_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.ActiveViewType = SchedulerViewType.WorkWeek
        End Sub

        Private Sub chkShowOverAppointment_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.WorkWeekView.TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked
        End Sub

        Private Sub cbTimeIndicatorVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.WorkWeekView.TimeIndicatorDisplayOptions.Visibility = CType(cbTimeIndicatorVisibility.EditValue, TimeIndicatorVisibility)
        End Sub

        Private Sub cbTimeMarkerVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.WorkWeekView.TimeMarkerVisibility = CType(cbTimeMarkerVisibility.EditValue, TimeMarkerVisibility)
        End Sub

        Private Sub cbTimeMarkerStyle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.WorkWeekView.TimeMarkerStyle = CType(cbTimeMarkerStyle.EditValue, TimeMarkerStyle)
        End Sub

        Private Sub chkShowWorkTimeOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.WorkWeekView.ShowWorkTimeOnly = chkShowWorkTimeOnly.Checked
        End Sub

        Private Sub weekDaysCheckEdit1_WeekDaysChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim weekDays As WeekDays = weekDaysCheckEdit1.WeekDays
            Dim workDays As WorkDaysCollection = schedulerControl.WorkDays
            workDays.BeginUpdate()
            workDays.Clear()
            If Not weekDays.Equals(CType(0, WeekDays)) Then workDays.Add(New WeekDaysWorkDay(weekDays))
            workDays.EndUpdate()
        End Sub

        Private Sub HideUnusedViews()
            schedulerControl.DayView.Enabled = False
            schedulerControl.WeekView.Enabled = False
            schedulerControl.MonthView.Enabled = False
            schedulerControl.TimelineView.Enabled = False
            schedulerControl.AgendaView.Enabled = False
            schedulerControl.YearView.Enabled = False
        End Sub

        Private Sub chkCustomGroup_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If chkCustomGroup.Checked Then
                AddHandler Scheduler.CustomAppointmentGroup, AddressOf CustomAppointmentGroup
            Else
                RemoveHandler Scheduler.CustomAppointmentGroup, AddressOf CustomAppointmentGroup
            End If

            Scheduler.Refresh()
        End Sub

        Private Sub CustomAppointmentGroup(ByVal sender As Object, ByVal e As CustomAppointmentGroupEventArgs)
            e.GroupKey = CInt(e.AppointmentLayoutInfo.Appointment.LabelKey)
        End Sub
    End Class
End Namespace
