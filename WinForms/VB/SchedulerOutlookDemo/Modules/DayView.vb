Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraScheduler.Demos.DemoData

Namespace DevExpress.XtraScheduler.Demos

    Public Partial Class DayViewModule
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
            <p class=""location"">${Appointment.Location}</p >
"

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            Dim svgImage As SvgImage = DemoUtils.GetResourceSvgImage("Images.Private.svg")
            Dim svgImages As SvgImageCollection = New SvgImageCollection()
            svgImages.Add("locked", svgImage)
            schedulerControl.HtmlImages = svgImages
        'this.schedulerControl.CustomAppointmentHtmlText += OnSchedulerControlCustomAppointmentHtmlText;
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
                Return spOptionPane
            End Get
        End Property

        Public Overrides Sub ResetOptions()
            MyBase.ResetOptions()
            Scheduler.BeginUpdate()
            Try
                chkShowRightTimeRuler.Checked = True
                chkShowWorkTimeOnly.Checked = True
                chkShowAllDayArea.Checked = True
                chkShowDayHeaders.Checked = True
                chkShowOverAppointment.Checked = True
                chkStatusOrientation.Checked = True
                chkAllowHtmlText.Checked = True
                spinDaysCount.EditValue = 3
                chkColorizeResources.Checked = True
                cbAllDayStatus.EditValue = AppointmentStatusDisplayType.Bounds
                cbStatus.EditValue = AppointmentStatusDisplayType.Bounds
                cbSnapToCellsMode.EditValue = AppointmentSnapToCellsMode.Auto
                cbColumnWidthMode.EditValue = ColumnWidthMode.Auto
                chkCustomGroup.Checked = True
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
                spinDaysCount.EditValue = schedulerControl.DayView.DayCount
                cbSnapToCellsMode.EditValue = Scheduler.DayView.AppointmentDisplayOptions.SnapToCellsMode
                cbColumnWidthMode.EditValue = Scheduler.DayView.ColumnWidthMode
                cbAllDayStatus.EditValue = Scheduler.DayView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType
                cbStatus.EditValue = Scheduler.DayView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType
                chkStatusOrientation.Checked = Scheduler.DayView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically
                cbTimeMarkerVisibility.EditValue = Scheduler.DayView.TimeMarkerVisibility
                cbTimeMarkerStyle.EditValue = Scheduler.DayView.TimeMarkerStyle
                cbTimeIndicatorVisibility.EditValue = Scheduler.DayView.TimeIndicatorDisplayOptions.Visibility
                chkShowOverAppointment.Checked = Scheduler.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment
                chkShowDayHeaders.Checked = Scheduler.DayView.ShowDayHeaders
                chkShowAllDayArea.Checked = Scheduler.DayView.ShowAllDayArea
                chkShowWorkTimeOnly.Checked = Scheduler.DayView.ShowWorkTimeOnly
                chkAllowHtmlText.Checked = Not Equals(Scheduler.DayView.HtmlTemplates.Appointment.Template, Nothing)
                Dim timeRulersCount As Integer = schedulerControl.DayView.TimeRulers.Count
                Dim shouldShowRightRuler As Boolean = False
                For i As Integer = 0 To timeRulersCount - 1
                    Dim timeRuler As TimeRuler = schedulerControl.DayView.TimeRulers(i)
                    If timeRuler.HorizontalAlignment = TimeRulerHorizontalAlignment.Far AndAlso timeRuler.Visible Then
                        shouldShowRightRuler = True
                        Exit For
                    End If
                Next

                chkShowRightTimeRuler.Checked = shouldShowRightRuler
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub

        Protected Overrides Function GetGlobalOptionIgnoreList() As IEnumerable(Of String)
            Return New String() {"AppointmentStatusDisplayType", "AppointmentStatusDisplayType", "ShowAllDayAppointmentStatusVertically", "TimeMarkerVisibility", "ShowTimeIndicatorOverAppointment", "ShowDayHeaders", "ShowAllDayArea", "ShowRightTimeRuler"}
        End Function

        Private Sub OnDayViewModuleLoad(ByVal sender As Object, ByVal e As EventArgs)
            HideUnusedViews()
            UpdateRulers(True)
            Scheduler.Start = SchedulerDataHelper.Start.AddDays(-1)
            Scheduler.DayView.TopRowTime = TimeSpan.FromHours(8)
            SchedulerDataHelper.Attach(Scheduler)
            TimeRegionHelper.Attach(Scheduler)
            SetOfficeUI(schedulerControl)
            ResetOptions()
        End Sub

        Private Sub SetOfficeUI(ByVal scheduler As SchedulerControl)
            scheduler.DayView.ShowMoreButtonsOnEachColumn = True
            scheduler.DayView.ShowNumbersInMoreButtons = True
            scheduler.DayView.ShowDayNumberInAllDayArea = DefaultBoolean.True
        End Sub

        Private Sub spinDaysCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.DayView.DayCount = Convert.ToInt32(spinDaysCount.EditValue)
        End Sub

        Private Sub cbSnapToCellsMode_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.DayView.AppointmentDisplayOptions.SnapToCellsMode = CType(cbSnapToCellsMode.EditValue, AppointmentSnapToCellsMode)
        End Sub

        Private Sub cbColumnWidthMode_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.DayView.ColumnWidthMode = CType(cbColumnWidthMode.EditValue, ColumnWidthMode)
        End Sub

        Private Sub cbAllDayStatus_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.DayView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType = CType(cbAllDayStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub cbStatus_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.DayView.AppointmentDisplayOptions.StatusDisplayType = CType(cbStatus.EditValue, AppointmentStatusDisplayType)
        End Sub

        Private Sub chkStatusOrientation_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.DayView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically = chkStatusOrientation.Checked
        End Sub

        Private Sub cbTimeMarkerVisibility_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.DayView.TimeMarkerVisibility = CType(cbTimeMarkerVisibility.EditValue, TimeMarkerVisibility)
        End Sub

        Private Sub cbTimeMarkerStyle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.DayView.TimeMarkerStyle = CType(cbTimeMarkerStyle.EditValue, TimeMarkerStyle)
        End Sub

        Private Sub cbTimeIndicatorVisibility_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.DayView.TimeIndicatorDisplayOptions.Visibility = CType(cbTimeIndicatorVisibility.EditValue, TimeIndicatorVisibility)
        End Sub

        Private Sub chkShowOverAppointment_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.DayView.TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked
        End Sub

        Private Sub chkShowDayHeaders_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.DayView.ShowDayHeaders = chkShowDayHeaders.Checked
        End Sub

        Private Sub chkShowAllDayArea_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.DayView.ShowAllDayArea = chkShowAllDayArea.Checked
        End Sub

        Private Sub chkShowWorkTimeOnly_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.DayView.ShowWorkTimeOnly = chkShowWorkTimeOnly.Checked
        End Sub

        Private Sub chkShowRightTimeRuler_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim shouldShowRightRuler As Boolean = chkShowRightTimeRuler.Checked
            UpdateRulers(shouldShowRightRuler)
        End Sub

        Private Sub UpdateRulers(ByVal shouldShowRightRuler As Boolean)
            Dim timeRulersCount As Integer = schedulerControl.DayView.TimeRulers.Count
            For i As Integer = 0 To timeRulersCount - 1
                Dim timeRuler As TimeRuler = schedulerControl.DayView.TimeRulers(i)
                If timeRuler.HorizontalAlignment = TimeRulerHorizontalAlignment.Far Then timeRuler.Visible = shouldShowRightRuler
            Next
        End Sub

        Private Sub OnSchedulerControlPopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs)
            If e.Menu.Id = SchedulerMenuItemId.DefaultMenu OrElse e.Menu.Id = SchedulerMenuItemId.RulerMenu Then
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu)
            End If
        End Sub

        Private Sub OnDayViewModuleVisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl.ActiveViewType = SchedulerViewType.Day
        End Sub

        Private Sub HideUnusedViews()
            schedulerControl.WorkWeekView.Enabled = False
            schedulerControl.WeekView.Enabled = False
            schedulerControl.MonthView.Enabled = False
            schedulerControl.TimelineView.Enabled = False
            schedulerControl.AgendaView.Enabled = False
            schedulerControl.YearView.Enabled = False
        End Sub

        Private Sub OnSchedulerControlVisibleIntervalChanged(ByVal sender As Object, ByVal e As EventArgs)
            spinDaysCount.EditValue = Scheduler.DayView.DayCount
        End Sub

        Private Sub OnChkCustomGroupCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
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

        Private Sub OnChkAllowHtmlTextCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If chkAllowHtmlText.Checked Then
                schedulerControl.DayView.HtmlTemplates.Appointment.Template = AppointmentTemplate
                schedulerControl.DayView.HtmlTemplates.Appointment.Styles = AppointmentCss
            Else
                schedulerControl.DayView.HtmlTemplates.Appointment.Template = String.Empty
                schedulerControl.DayView.HtmlTemplates.Appointment.Styles = String.Empty
            End If
        End Sub

        Private Sub OnChkColorizeResourcesCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Scheduler.BeginUpdate()
            Try
                If Scheduler.GroupType = SchedulerGroupType.None Then Scheduler.GroupType = SchedulerGroupType.Resource
                Scheduler.OptionsView.ColorizeResources = chkColorizeResources.Checked
            Finally
                Scheduler.EndUpdate()
            End Try
        End Sub
    End Class
End Namespace
