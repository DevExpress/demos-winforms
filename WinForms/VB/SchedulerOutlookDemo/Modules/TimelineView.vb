Imports DevExpress.XtraEditors
Imports DevExpress.XtraScheduler.Demos.DemoData
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class TimelineViewModule
        Inherits TutorialControl

        Const DefaultTimeScaleWidth As Integer = 75

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
                Return spOptionPane
            End Get
        End Property

        Public Overrides Sub ResetOptions()
            MyBase.ResetOptions()
            Scheduler.BeginUpdate()
            Try
                chkAutoHeight.Checked = False
                spinMinHeight.Enabled = chkAutoHeight.Checked
                spinMaxHeight.Enabled = chkAutoHeight.Checked
                spinHeight.Value = 0
                spinMinHeight.Value = 0
                spinMaxHeight.Value = 0
                cbSnapToCellsMode.EditValue = AppointmentSnapToCellsMode.Auto
                cbStatus.EditValue = AppointmentStatusDisplayType.Bounds
                chkSelectionBarVisible.Checked = True
                chkStatusOrientation.Checked = True
                chkSetResourceHeight.Checked = False
                lciResourceHeight.Visibility = XtraLayout.Utils.LayoutVisibility.Never
                spinResourceHeight.EditValue = 200
                RestoreDefaultScales()
                UpdateTimeScaleWidthTrackBar()
                chkShowOverAppointment.Checked = False
                cbTimeIndicatorVisibility.EditValue = TimeIndicatorVisibility.CurrentDate
                chkStretchAppointments.Checked = Scheduler.TimelineView.AppointmentDisplayOptions.StretchAppointments
                chkStretchAppointments.Enabled = Not chkAutoHeight.Checked
                Scheduler.TimelineView.AppointmentDisplayOptions.StartTimeVisibility = AppointmentTimeVisibility.Never
                Scheduler.TimelineView.AppointmentDisplayOptions.EndTimeVisibility = AppointmentTimeVisibility.Never
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub

        Protected Overrides Function GetGlobalOptionIgnoreList() As IEnumerable(Of String)
            Return New String() {"AppointmentStatusDisplayType", "ShowTimeIndicatorOverAppointment", "ShowAppointmentStatusVertically"}
        End Function

        Private Sub OnTimelineViewModuleLoad(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.Start = SchedulerDataHelper.Start
            SchedulerDataHelper.Attach(schedulerControl)
            ResetOptions()
        End Sub

        Private Sub OnTimelineViewModuleVisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.ActiveViewType = SchedulerViewType.Timeline
        End Sub

        Private Sub OnChkSelectionBarVisibleCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.TimelineView.SelectionBar.Visible = chkSelectionBarVisible.Checked
        End Sub

        Private Sub OnChkFixedResourceHeightCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim checkEdit = CType(sender, CheckEdit)
            chkCellAutoHeight.Enabled = Not checkEdit.Checked
            Scheduler.BeginUpdate()
            Try
                Dim resourceHeight As Integer = CInt(spinResourceHeight.Value)
                Scheduler.TimelineView.ResourceHeight = If(checkEdit.Checked, resourceHeight, 0)
                lciResourceHeight.Visibility = If(checkEdit.Checked, XtraLayout.Utils.LayoutVisibility.Always, XtraLayout.Utils.LayoutVisibility.Never)
                Scheduler.GroupType = SchedulerGroupType.Resource
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub

        Private Sub OnSpinResourceHeightEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Scheduler.TimelineView.ResourceHeight <= 0 Then Return
            Dim spinEdit As SpinEdit = CType(sender, SpinEdit)
            Scheduler.TimelineView.ResourceHeight = If(chkSetResourceHeight.Checked, CInt(spinEdit.Value), 0)
        End Sub

        Private Sub OnChkCellAutoHeightCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim checkEdit = CType(sender, CheckEdit)
            Scheduler.BeginUpdate()
            Try
                If checkEdit.Checked Then
                    chkSetResourceHeight.Enabled = False
                    Scheduler.TimelineView.CellsAutoHeightOptions.AutoHeightMode = SchedulerCellAutoHeightMode.Full
                    Scheduler.TimelineView.CellsAutoHeightOptions.MinHeight = 100
                    Scheduler.TimelineView.CellsAutoHeightOptions.MaxHeight = 500
                    Scheduler.GroupType = SchedulerGroupType.Resource
                Else
                    chkSetResourceHeight.Enabled = True
                    Scheduler.TimelineView.CellsAutoHeightOptions.AutoHeightMode = SchedulerCellAutoHeightMode.None
                End If
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub

        Private Sub OnBtnEditScalesClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As TimeScalesEditForm = New TimeScalesEditForm(Scheduler.TimelineView.Scales, FindForm())
            AddHandler form.RestoreDefaultClicked, AddressOf OnRestoreDefaultScalesClicked
            form.ShowDialog()
            UpdateTimeScaleWidthTrackBar()
        End Sub

        Private Sub OnRestoreDefaultScalesClicked(ByVal sender As Object, ByVal e As EventArgs)
            RestoreDefaultScales()
        End Sub

        Private Sub UpdateTimeScaleWidthTrackBar()
            trckScaleWidth.Value = Scheduler.TimelineView.GetBaseTimeScale().Width
            trckScaleWidth.Enabled = Scheduler.TimelineView.Scales.Count > 0
        End Sub

        Private Sub OnChkAutoHeightCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.TimelineView.AppointmentDisplayOptions.AppointmentAutoHeight = chkAutoHeight.Checked
            chkStretchAppointments.Enabled = Not chkAutoHeight.Checked
            spinMinHeight.Enabled = chkAutoHeight.Checked
            spinMaxHeight.Enabled = chkAutoHeight.Checked
        End Sub

        Private Sub OnSpinHeightEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.TimelineView.AppointmentDisplayOptions.AppointmentHeight = Convert.ToInt32(spinHeight.Value)
        End Sub

        Private Sub OnSpinMinHeightEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.TimelineView.AppointmentDisplayOptions.AppointmentMinHeight = Convert.ToInt32(spinMinHeight.Value)
        End Sub

        Private Sub OnSpinMaxHeightEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.TimelineView.AppointmentDisplayOptions.AppointmentMaxHeight = Convert.ToInt32(spinMaxHeight.Value)
        End Sub

        Private Sub OnCbStatusEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not GetType(AppointmentStatusDisplayType).IsAssignableFrom(cbStatus.EditValue.GetType()) Then Return
            Scheduler.TimelineView.AppointmentDisplayOptions.StatusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub OnCbSnapToCellsModeEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.TimelineView.AppointmentDisplayOptions.SnapToCellsMode = CType(cbSnapToCellsMode.EditValue, AppointmentSnapToCellsMode)
        End Sub

        Private Sub OnTrckScaleWidthEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.TimelineView.Scales.ForEach(Sub(x) x.Width = trckScaleWidth.Value)
        End Sub

        Private Sub OnChkShowOverAppointmentCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.TimelineView.TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked
        End Sub

        Private Sub OnCbTimeIndicatorVisibilitySelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.TimelineView.TimeIndicatorDisplayOptions.Visibility = CType(cbTimeIndicatorVisibility.EditValue, TimeIndicatorVisibility)
        End Sub

        Private Sub OnChkStatusOrientationCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.TimelineView.AppointmentDisplayOptions.ShowAppointmentStatusVertically = chkStatusOrientation.Checked
        End Sub

        Private Sub OnChkStretchAppointmentsCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.TimelineView.AppointmentDisplayOptions.StretchAppointments = chkStretchAppointments.Checked
        End Sub

        Private Sub OnChkCustomSortCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If chkCustomSort.Checked Then
                AddHandler Scheduler.CustomAppointmentSort, AddressOf CustomAppointmentSort
                chkCustomGroup.Checked = False
            Else
                RemoveHandler Scheduler.CustomAppointmentSort, AddressOf CustomAppointmentSort
            End If

            Scheduler.Refresh()
        End Sub

        Private Sub OnChkCustomGroupCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
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

        Private Sub RestoreDefaultScales()
            Scheduler.TimelineView.Scales.LoadDefaults()
            Scheduler.TimelineView.Scales.Add(New TimeScaleWorkDay(Scheduler))
            Scheduler.TimelineView.Scales.Add(New TimeScaleWorkHour(Scheduler))
            For Each scaleItem As TimeScale In Scheduler.TimelineView.Scales
                scaleItem.Enabled = TypeOf scaleItem Is TimeScaleWorkDay OrElse TypeOf scaleItem Is TimeScaleWeek
                scaleItem.Width = ScaleDPI.ScaleHorizontal(DefaultTimeScaleWidth)
            Next
        End Sub

        Private Sub HideUnusedViews()
            schedulerControl.DayView.Enabled = True
            schedulerControl.WeekView.Enabled = False
            schedulerControl.WorkWeekView.Enabled = False
            schedulerControl.MonthView.Enabled = False
            schedulerControl.AgendaView.Enabled = False
            schedulerControl.YearView.Enabled = False
        End Sub
    End Class
End Namespace
