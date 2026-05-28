Imports DevExpress.XtraScheduler.Demos.DemoData
Imports DevExpress.XtraScheduler.Localization
Imports DevExpress.XtraScheduler.Native
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class MonthViewModule
        Inherits TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
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
                Return spOptionPanel
            End Get
        End Property

        Public Overrides Sub ResetOptions()
            MyBase.ResetOptions()
            Scheduler.BeginUpdate()
            Try
                chkStartTimeVisibility.CheckState = CheckState.Unchecked
                chkEndTimeVisibility.CheckState = CheckState.Unchecked
                chkCompressWeekEnd.Checked = False
                chkShowWeekend.Checked = True
                chkCompressWeekEnd.Enabled = chkShowWeekend.Checked
                chkStretchAppointments.Enabled = Not chkCompressWeekEnd.Checked
                cbStretchAppointmentsMode.EditValue = StretchAppointmentsMode.GrowAndShrink
                chkStatusOrientation.Checked = True
                cbTimeDisplayType.EditValue = AppointmentTimeDisplayType.Text
                cbStatus.EditValue = AppointmentStatusDisplayType.Bounds
                spinWeekCount.EditValue = 4
                chkStretchAppointments.Checked = Scheduler.MonthView.AppointmentDisplayOptions.StretchAppointments
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub

        Friend Overrides Sub UpdateOptionsFromControl()
            MyBase.UpdateOptionsFromControl()
            Scheduler.BeginUpdate()
            Try
                chkCompressWeekEnd.Checked = Scheduler.MonthView.CompressWeekend
                chkShowWeekend.Checked = Scheduler.MonthView.ShowWeekend
                chkCompressWeekEnd.Enabled = chkShowWeekend.Checked
                chkStretchAppointments.Enabled = Not chkCompressWeekEnd.Checked
                spinWeekCount.EditValue = Scheduler.MonthView.WeekCount
                chkStartTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(Scheduler.MonthView.AppointmentDisplayOptions.StartTimeVisibility)
                chkEndTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(Scheduler.MonthView.AppointmentDisplayOptions.EndTimeVisibility)
                cbTimeDisplayType.EditValue = Scheduler.MonthView.AppointmentDisplayOptions.TimeDisplayType
                cbStatus.EditValue = Scheduler.MonthView.AppointmentDisplayOptions.StatusDisplayType
                cbStretchAppointmentsMode.EditValue = Scheduler.MonthView.AppointmentDisplayOptions.StretchAppointmentsMode
                chkStatusOrientation.Checked = Scheduler.MonthView.AppointmentDisplayOptions.ShowAppointmentStatusVertically
                chkStretchAppointments.Checked = Scheduler.MonthView.AppointmentDisplayOptions.StretchAppointments
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub

        Protected Overrides Function GetGlobalOptionIgnoreList() As IEnumerable(Of String)
            Return New String() {"CompressWeekEnd", "ShowWeekEnd", "ShowStartTime", "ShowEndTime", "AppointmentStatusDisplayType", "ShowAppointmentStatusVertically"}
        End Function

        Private Sub MonthViewModule_Load(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.Start = SchedulerDataHelper.Start.AddDays(-7)
            SchedulerDataHelper.Attach(schedulerControl)
            ResetOptions()
        End Sub

        Private Sub chkCompressWeekEnd_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.MonthView.CompressWeekend = chkCompressWeekEnd.Checked
            chkStretchAppointments.Enabled = Not chkCompressWeekEnd.Checked
        End Sub

        Private Sub chkShowWeekend_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.MonthView.ShowWeekend = chkShowWeekend.Checked
            chkCompressWeekEnd.Enabled = chkShowWeekend.Checked
        End Sub

        Private Sub spinWeekCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.MonthView.WeekCount = Convert.ToInt32(spinWeekCount.EditValue)
        End Sub

        Private Sub MonthViewModule_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.ActiveViewType = SchedulerViewType.Month
        End Sub

        Private Sub chkStartTimeVisibility_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.MonthView.AppointmentDisplayOptions.StartTimeVisibility = DemoUtils.CheckStateToTimeVisibility(chkStartTimeVisibility.CheckState)
        End Sub

        Private Sub chkEndTimeVisibility_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.MonthView.AppointmentDisplayOptions.EndTimeVisibility = DemoUtils.CheckStateToTimeVisibility(chkEndTimeVisibility.CheckState)
        End Sub

        Private Sub cbTimeDisplayType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.MonthView.AppointmentDisplayOptions.TimeDisplayType = CType(cbTimeDisplayType.EditValue, AppointmentTimeDisplayType)
        End Sub

        Private Sub cbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.MonthView.AppointmentDisplayOptions.StatusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub chkStatusOrientation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.MonthView.AppointmentDisplayOptions.ShowAppointmentStatusVertically = chkStatusOrientation.Checked
        End Sub

        Private Sub chkStretchAppointments_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.MonthView.AppointmentDisplayOptions.StretchAppointments = chkStretchAppointments.Checked
        End Sub

        Private Sub HideUnusedViews()
            schedulerControl.DayView.Enabled = True
            schedulerControl.WeekView.Enabled = False
            schedulerControl.WorkWeekView.Enabled = False
            schedulerControl.TimelineView.Enabled = False
            schedulerControl.AgendaView.Enabled = False
            schedulerControl.YearView.Enabled = False
        End Sub

        Private Sub chkCustomSort_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If chkCustomSort.Checked Then
                AddHandler Scheduler.CustomAppointmentSort, AddressOf CustomAppointmentSort
                chkCustomGroup.Checked = False
            Else
                RemoveHandler Scheduler.CustomAppointmentSort, AddressOf CustomAppointmentSort
            End If

            Scheduler.Refresh()
        End Sub

        Private Sub chkCustomGroup_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If chkCustomGroup.Checked Then
                AddHandler Scheduler.CustomAppointmentGroup, AddressOf CustomAppointmentGroup
                chkCustomSort.Checked = False
            Else
                RemoveHandler Scheduler.CustomAppointmentGroup, AddressOf CustomAppointmentGroup
            End If

            Scheduler.Refresh()
        End Sub

        Private Sub CustomAppointmentSort(ByVal sender As Object, ByVal e As CustomAppointmentSortEventArgs)
            Dim viewInfoX As IAppointmentLayoutInfo = e.AppointmentLayoutInfo1
            Dim viewInfoY As IAppointmentLayoutInfo = e.AppointmentLayoutInfo2
            e.Result = viewInfoX.Start.CompareTo(viewInfoY.Start)
            If e.Result <> 0 Then Return
            e.Result = -viewInfoX.End.CompareTo(viewInfoY.End)
            If e.Result <> 0 Then Return
            Dim aptX As Appointment = viewInfoX.Appointment
            Dim aptY As Appointment = viewInfoY.Appointment
            e.Result =(CInt(aptX.LabelKey)).CompareTo(CInt(aptY.LabelKey))
            If e.Result <> 0 Then Return
            e.Result = aptX.Start.CompareTo(aptY.Start)
            If e.Result <> 0 Then Return
            e.Result = -aptX.End.CompareTo(aptY.End)
        End Sub

        Private Sub CustomAppointmentGroup(ByVal sender As Object, ByVal e As CustomAppointmentGroupEventArgs)
            e.GroupKey = CInt(e.AppointmentLayoutInfo.Appointment.LabelKey)
        End Sub

        Private Sub cbStretchAppointmentsMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.MonthView.AppointmentDisplayOptions.StretchAppointmentsMode = CType(cbStretchAppointmentsMode.EditValue, StretchAppointmentsMode)
        End Sub

        Private Sub schedulerControl_AppointmentFlyoutShowing(ByVal sender As Object, ByVal e As AppointmentFlyoutShowingEventArgs)
            Dim status As AppointmentStatus = schedulerDataStorage.Appointments.Statuses.GetById(e.FlyoutData.Appointment.StatusKey)
            Dim statusImage As String = status.Type.ToString()
            e.HtmlTemplate.Styles += String.Format(".colorized-area {{" & Microsoft.VisualBasic.Constants.vbLf & "  background-color: #{0:X};" & Microsoft.VisualBasic.Constants.vbLf & "}}" & Microsoft.VisualBasic.Constants.vbLf & ".with-status {{" & Microsoft.VisualBasic.Constants.vbLf & "  background-image: url(""{1}"")", e.FlyoutData.SubjectAppearance.BackColor.ToArgb(), statusImage)
        End Sub

        Private Sub schedulerControl_CustomAppointmentFlyoutTemplateValue(ByVal sender As Object, ByVal e As CustomAppointmentFlyoutTemplateValueEventArgs)
            If "Reminder".Equals(e.FieldName) Then
                If e.Appointment.HasReminder Then
                    e.FieldValue = HumanReadableTimeSpanHelper.ToString(e.Appointment.Reminder.TimeBeforeStart)
                Else
                    e.FieldValue = SchedulerLocalizer.GetString(SchedulerStringId.Caption_NoneReminder)
                End If
            End If
        End Sub
    End Class
End Namespace
