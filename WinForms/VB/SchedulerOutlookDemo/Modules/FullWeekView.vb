Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler.Demos.DemoData
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class FullWeekViewModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            HideUnusedViews()
        End Sub

        Public Overrides ReadOnly Property Scheduler As SchedulerControl
            Get
                Return schedulerControl1
            End Get
        End Property

        Public Overrides ReadOnly Property CommonRibbonPanel As CommonRibbon
            Get
                Return commonRibbon1
            End Get
        End Property

        Protected Overrides ReadOnly Property OptionsPane As Control
            Get
                Return spOptionPanel
            End Get
        End Property

        Public Overrides Sub ResetOptions()
            MyBase.ResetOptions()
            Scheduler.BeginUpdate()
            Try
                chkShowWorkTimeOnly.Checked = True
                chkShowAllDayArea.Checked = True
                chkShowDayHeaders.Checked = True
                chkAppointmentShadows.Checked = False
                chkShowOverAppointment.Checked = True
                chkStatusOrientation.Checked = True
                chkStretchAppointments.Checked = True
                cbAllDayStatus.EditValue = AppointmentStatusDisplayType.Bounds
                cbStatus.EditValue = AppointmentStatusDisplayType.Bounds
                cbSnapToCellsMode.EditValue = AppointmentSnapToCellsMode.Auto
                cbTimeIndicatorVisibility.EditValue = TimeIndicatorVisibility.DaysBeforeToday
                cbTimeMarkerVisibility.EditValue = TimeMarkerVisibility.TodayView
                cbTimeMarkerStyle.EditValue = TimeMarkerStyle.Default
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub

        Friend Overrides Sub UpdateOptionsFromControl()
            MyBase.UpdateOptionsFromControl()
            Scheduler.BeginUpdate()
            Try
                chkShowWorkTimeOnly.Checked = Scheduler.FullWeekView.ShowWorkTimeOnly
                chkShowAllDayArea.Checked = Scheduler.FullWeekView.ShowAllDayArea
                chkShowDayHeaders.Checked = Scheduler.FullWeekView.ShowDayHeaders
                chkAppointmentShadows.Checked = Scheduler.FullWeekView.AppointmentDisplayOptions.ShowShadows
                cbStatus.EditValue = Scheduler.FullWeekView.AppointmentDisplayOptions.StatusDisplayType
                cbAllDayStatus.EditValue = Scheduler.FullWeekView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType
                cbSnapToCellsMode.EditValue = Scheduler.FullWeekView.AppointmentDisplayOptions.SnapToCellsMode
                chkShowOverAppointment.Checked = Scheduler.FullWeekView.TimeIndicatorDisplayOptions.ShowOverAppointment
                cbTimeIndicatorVisibility.EditValue = Scheduler.FullWeekView.TimeIndicatorDisplayOptions.Visibility
                cbTimeMarkerVisibility.EditValue = Scheduler.FullWeekView.TimeMarkerVisibility
                cbTimeMarkerStyle.EditValue = Scheduler.FullWeekView.TimeMarkerStyle
                chkStatusOrientation.Checked = Scheduler.FullWeekView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically
                cbColumnWidthMode.EditValue = Scheduler.FullWeekView.ColumnWidthMode
                spinColumnWidth.EditValue = Scheduler.FullWeekView.ColumnWidth
                spinAppointmentWidth.EditValue = Scheduler.FullWeekView.AppointmentDisplayOptions.AppointmentWidth
                chkStretchAppointments.Checked = Scheduler.FullWeekView.AppointmentDisplayOptions.StretchAppointments
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub

        Protected Overrides Function GetGlobalOptionIgnoreList() As IEnumerable(Of String)
            Return New String() {"ShowAllDayArea", "ShowDayHeaders", "AppointmentStatusDisplayType", "ShowTimeIndicatorOverAppointment", "TimeMarkerVisibility", "ShowAllDayAppointmentStatusVertically"}
        End Function

        Private Sub FullWeekViewModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.Start = SchedulerDataHelper.Start
            SchedulerDataHelper.Attach(schedulerControl1)
            TimeRegionHelper.Attach(Scheduler)
            ResetOptions()
        End Sub

        Private Sub chkShowWorkTimeOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.ShowWorkTimeOnly = chkShowWorkTimeOnly.Checked
        End Sub

        Private Sub chkShowAllDayArea_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.ShowAllDayArea = chkShowAllDayArea.Checked
        End Sub

        Private Sub chkShowDayHeaders_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.ShowDayHeaders = chkShowDayHeaders.Checked
        End Sub

        Private Sub chkAppointmentShadows_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.AppointmentDisplayOptions.ShowShadows = chkAppointmentShadows.Checked
        End Sub

        Private Sub schedulerControl_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.Menu.Id = SchedulerMenuItemId.DefaultMenu OrElse e.Menu.Id = SchedulerMenuItemId.RulerMenu Then e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
        End Sub

        Private Sub FullWeekViewModule_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.ActiveViewType = SchedulerViewType.FullWeek
        End Sub

        Private Sub cbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.AppointmentDisplayOptions.StatusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub cbAllDayStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType = CType(cbAllDayStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub cbSnapToCellsMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.AppointmentDisplayOptions.SnapToCellsMode = CType(cbSnapToCellsMode.EditValue, AppointmentSnapToCellsMode)
        End Sub

        Private Sub chkShowOverAppointment_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked
        End Sub

        Private Sub cbTimeIndicatorVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.TimeIndicatorDisplayOptions.Visibility = CType(cbTimeIndicatorVisibility.EditValue, TimeIndicatorVisibility)
        End Sub

        Private Sub cbTimeMarkerVisibility_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.TimeMarkerVisibility = CType(cbTimeMarkerVisibility.EditValue, TimeMarkerVisibility)
        End Sub

        Private Sub cbTimeMarkerStyle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.TimeMarkerStyle = CType(cbTimeMarkerStyle.EditValue, TimeMarkerStyle)
        End Sub

        Private Sub chkStatusOrientation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically = chkStatusOrientation.Checked
        End Sub

        Private Sub HideUnusedViews()
            schedulerControl1.FullWeekView.Enabled = True
            schedulerControl1.DayView.Enabled = False
            schedulerControl1.WeekView.Enabled = False
            schedulerControl1.MonthView.Enabled = False
            schedulerControl1.WorkWeekView.Enabled = False
            schedulerControl1.TimelineView.Enabled = False
            schedulerControl1.GanttView.Enabled = False
            schedulerControl1.AgendaView.Enabled = False
            schedulerControl1.YearView.Enabled = False
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

        Private Sub cbColumnWidthModeEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.ColumnWidthMode = CType(cbColumnWidthMode.EditValue, ColumnWidthMode)
            spinColumnWidth.Enabled = Scheduler.FullWeekView.ColumnWidthMode = ColumnWidthMode.Fixed
            spinAppointmentWidth.Enabled = Scheduler.FullWeekView.ColumnWidthMode = ColumnWidthMode.Auto
        End Sub

        Private Sub spinColumnWidthEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim spinEdit As SpinEdit = CType(sender, SpinEdit)
            Dim value As Integer = CInt(spinEdit.Value)
            If value < 0 Then Return
            Scheduler.FullWeekView.ColumnWidth = value
        End Sub

        Private Sub spinAppointmentWidthEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim spinEdit As SpinEdit = CType(sender, SpinEdit)
            Dim value As Integer = CInt(spinEdit.Value)
            If value < 0 Then Return
            Scheduler.FullWeekView.AppointmentDisplayOptions.AppointmentWidth = value
        End Sub

        Private Sub chkStretchAppointmentsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.FullWeekView.AppointmentDisplayOptions.StretchAppointments = chkStretchAppointments.Checked
        End Sub
    End Class
End Namespace
