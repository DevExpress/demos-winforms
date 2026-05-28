Imports System

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class DayViewModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            PrepareViews()
            AddHandler spinDaysCount.EditValueChanged, New EventHandler(AddressOf spinDaysCount_EditValueChanged)
        ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        Public Overrides ReadOnly Property PrintingSchedulerControl As SchedulerControl
            Get
                Return schedulerControl
            End Get
        End Property

        Protected ReadOnly Property DisplayOptions As DayViewAppointmentDisplayOptions
            Get
                Return CType(schedulerControl.DayView.AppointmentDisplayOptions, DayViewAppointmentDisplayOptions)
            End Get
        End Property

        Private ReadOnly Property TimeIndicatorDisplayOptions As TimeIndicatorDisplayOptions
            Get
                Return CType(schedulerControl.DayView.TimeIndicatorDisplayOptions, TimeIndicatorDisplayOptions)
            End Get
        End Property

        Private Sub PrepareViews()
            schedulerControl.WeekView.Enabled = False
            schedulerControl.WorkWeekView.Enabled = False
            schedulerControl.MonthView.Enabled = False
            schedulerControl.TimelineView.Enabled = False
            schedulerControl.AgendaView.Enabled = False
        End Sub

        Private Sub DayViewModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            FillData(schedulerControl, schedulerDataStorage)
            UpdateControls()
        End Sub

        Private Sub UpdateControls()
            chkShowRightTimeRuler.Checked = True
            chkShowWorkTimeOnly.Checked = schedulerControl.DayView.ShowWorkTimeOnly
            chkShowAllDayArea.Checked = schedulerControl.DayView.ShowAllDayArea
            chkShowDayHeaders.Checked = schedulerControl.DayView.ShowDayHeaders
            chkAppointmentShadows.Checked = DisplayOptions.ShowShadows
            chkShowOverAppointment.Checked = TimeIndicatorDisplayOptions.ShowOverAppointment
            spinDaysCount.EditValue = schedulerControl.DayView.DayCount
            cbAllDayStatus.EditValue = DisplayOptions.AllDayAppointmentsStatusDisplayType
            cbStatus.EditValue = DisplayOptions.StatusDisplayType
            cbSnapToCellsMode.EditValue = DisplayOptions.SnapToCellsMode
            cbTimeIndicatorVisibility.EditValue = TimeIndicatorDisplayOptions.Visibility
            cbTimeMarkerVisibility.EditValue = schedulerControl.DayView.TimeMarkerVisibility
        End Sub

        Private Sub chkShowWorkTimeOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.DayView.ShowWorkTimeOnly = chkShowWorkTimeOnly.Checked
        End Sub

        Private Sub chkShowAllDayArea_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.DayView.ShowAllDayArea = chkShowAllDayArea.Checked
        End Sub

        Private Sub chkShowDayHeaders_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.DayView.ShowDayHeaders = chkShowDayHeaders.Checked
        End Sub

        Private Sub chkAppointmentShadows_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.DayView.AppointmentDisplayOptions.ShowShadows = chkAppointmentShadows.Checked
        End Sub

        Private Sub spinDaysCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.DayView.DayCount = Convert.ToInt32(spinDaysCount.EditValue)
        End Sub

        Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.Menu.Id = SchedulerMenuItemId.DefaultMenu OrElse e.Menu.Id = SchedulerMenuItemId.RulerMenu Then
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
            End If
        End Sub

        Private Sub DayViewModule_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.ActiveViewType = SchedulerViewType.Day
        End Sub

        Private Sub cbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            DisplayOptions.StatusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub cbAllDayStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            DisplayOptions.AllDayAppointmentsStatusDisplayType = CType(cbAllDayStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub cbSnapToCellsMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            DisplayOptions.SnapToCellsMode = CType(cbSnapToCellsMode.EditValue, AppointmentSnapToCellsMode)
        End Sub

        Private Sub chkShowOverAppointment_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked
        End Sub

        Private Sub cbTimeIndicatorVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            TimeIndicatorDisplayOptions.Visibility = CType(cbTimeIndicatorVisibility.EditValue, TimeIndicatorVisibility)
        End Sub

        Private Sub cbTimeMarkerVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.DayView.TimeMarkerVisibility = CType(cbTimeMarkerVisibility.EditValue, TimeMarkerVisibility)
        End Sub

        Private Sub chkShowRightTimeRuler_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim timeRulersCount As Integer = schedulerControl.DayView.TimeRulers.Count
            For i As Integer = 0 To timeRulersCount - 1
                Dim timeRuler As TimeRuler = schedulerControl.DayView.TimeRulers(i)
                If timeRuler.HorizontalAlignment = TimeRulerHorizontalAlignment.Far Then timeRuler.Visible = chkShowRightTimeRuler.Checked
            Next
        End Sub

        Private Sub chkStatusOrientation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.DayView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically = chkStatusOrientation.Checked
        End Sub
    End Class
End Namespace
