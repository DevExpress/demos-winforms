Imports System

Namespace DevExpress.XtraScheduler.Demos

    Public Class CommonOptions

        Private Shared _instance As CommonOptions = New CommonOptions()

        Public Shared ReadOnly Property Instance As CommonOptions
            Get
                Return _instance
            End Get
        End Property

        Public Shared Sub ResetInstance()
            _instance = New CommonOptions()
        End Sub

        Public Sub New()
            ShowDayHeaders = True
            ShowAllDayArea = True
            ShowWeekEnd = True
            ShowModuleOptionsPane = True
            ShowAllDayAppointmentStatusVertically = True
            ShowRightTimeRuler = True
            WorkTime = New TimeOfDayInterval(TimeSpan.FromHours(9), TimeSpan.FromHours(18))
            WorkDays = WeekDays.WorkDays
            EnableReminders = True
            EnableNavigationButtons = True
            AllowEditAppointment = True
            ShowAppointmentReminder = True
            ShowAppointmentRecurrence = True
            ShowAppointmentStatusVertically = True
            AppointmentStatusDisplayType = AppointmentStatusDisplayType.Bounds
            AllowAsyncLayout = True
            ShowDayViewAppointmentSeparator = False
            ShowTodayButton = True
        End Sub

        Public Property ShowModuleOptionsPane As Boolean

        Public Property ShowDayHeaders As Boolean

        Public Property ShowAllDayArea As Boolean

        Public Property TimeMarkerVisibility As TimeMarkerVisibility

        Public Property ShowAllDayAppointmentStatusVertically As Boolean

        Public Property ShowRightTimeRuler As Boolean

        Public Property ShowWeekEnd As Boolean

        Public Property CompressWeekEnd As Boolean

        Public Property ShowAppointmentStatusVertically As Boolean

        Public Property ShowDayViewAppointmentSeparator As Boolean

        Public Property ShowTimeIndicatorOverAppointment As Boolean

        Public Property ShowStartTime As Boolean

        Public Property ShowEndTime As Boolean

        Public Property ShowTimeForDayView As Boolean

        Public Property WorkTime As TimeOfDayInterval

        Public Property WorkDays As WeekDays

        Public Property FirstDayOfWeek As FirstDayOfWeek

        Public Property EnableReminders As Boolean

        Public Property EnableNavigationButtons As Boolean

        Public Property AllowEditAppointment As Boolean

        Public Property AllowAsyncLayout As Boolean

        Public Property FontSize As Single

        Public Property FontFamilyName As String

        Public Property ShowAppointmentReminder As Boolean

        Public Property ShowAppointmentRecurrence As Boolean

        Public Property ShowTodayButton As Boolean

        Public Property AppointmentStatusDisplayType As AppointmentStatusDisplayType

        Public Sub Apply(ByVal tutorial As TutorialControl)
            If tutorial Is Nothing OrElse tutorial.Scheduler Is Nothing Then Return
            If tutorial.CommonRibbonPanel IsNot Nothing Then tutorial.CommonRibbonPanel.UpdateRibbonItems()
            tutorial.UpdateOptionsPaneVisibility(ShowModuleOptionsPane)
            Dim scheduler As SchedulerControl = tutorial.Scheduler
            Dim canApplyGlobalOption As Func(Of String, Boolean) = AddressOf tutorial.CanApplyGlobalOption
            ApplyScheduler(scheduler, canApplyGlobalOption)
            ApplyBaseView(scheduler.DayView, canApplyGlobalOption)
            ApplyBaseView(scheduler.WorkWeekView, canApplyGlobalOption)
            ApplyBaseView(scheduler.FullWeekView, canApplyGlobalOption)
            ApplyBaseView(scheduler.MonthView, canApplyGlobalOption)
            ApplyBaseView(scheduler.TimelineView, canApplyGlobalOption)
            ApplyBaseView(scheduler.AgendaView, canApplyGlobalOption)
            Apply(scheduler.DayView, canApplyGlobalOption)
            Apply(scheduler.WorkWeekView, canApplyGlobalOption)
            Apply(scheduler.FullWeekView, canApplyGlobalOption)
            Apply(scheduler.MonthView, canApplyGlobalOption)
            Apply(scheduler.TimelineView, canApplyGlobalOption)
            tutorial.UpdateOptionsFromControl()
        End Sub

        Private Sub Apply(ByVal applyAction As Action, ByVal propertyName As String, ByVal canApply As Func(Of String, Boolean))
            If canApply(propertyName) Then
                applyAction()
            End If
        End Sub

        Private Sub ApplyScheduler(ByVal scheduler As SchedulerControl, ByVal canApply As Func(Of String, Boolean))
            Apply(Sub()
                scheduler.WorkDays.BeginUpdate()
                scheduler.WorkDays.Clear()
                scheduler.WorkDays.Add(WorkDays)
                scheduler.WorkDays.EndUpdate()
            End Sub, "WorkDays", canApply)
            Apply(Sub() scheduler.OptionsView.FirstDayOfWeek = FirstDayOfWeek, "FirstDayOfWeek", canApply)
            Apply(Sub() scheduler.DataStorage.EnableReminders = EnableReminders, "EnableReminders", canApply)
            Apply(Sub() scheduler.OptionsView.NavigationButtons.Visibility = If(EnableNavigationButtons, NavigationButtonVisibility.Auto, NavigationButtonVisibility.Never), "EnableNavigationButtons", canApply)
            Apply(Sub() scheduler.OptionsCustomization.AllowAppointmentEdit = If(AllowEditAppointment, UsedAppointmentType.All, UsedAppointmentType.None), "AllowEditAppointment", canApply)
            Apply(Sub() scheduler.OptionsBehavior.UseAsyncMode = AllowAsyncLayout, "AllowAsyncLayout", canApply)
            Apply(Sub()
                If Not String.IsNullOrEmpty(FontFamilyName) Then
                    Dim font As System.Drawing.Font = scheduler.Appearance.Appointment.Font
                    scheduler.Appearance.Appointment.Font = New System.Drawing.Font(FontFamilyName, FontSize, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont)
                Else
                    FontFamilyName = scheduler.Appearance.Appointment.Font.FontFamily.Name
                    FontSize = scheduler.Appearance.Appointment.Font.Size
                End If
            End Sub, "FontFamilyName", canApply)
            Apply(Sub() scheduler.DateNavigationBar.ShowTodayButton = ShowTodayButton, "ShowTodayButton", canApply)
        End Sub

        Private Sub ApplyBaseView(ByVal view As SchedulerViewBase, ByVal canApply As Func(Of String, Boolean))
            Apply(Sub() view.AppointmentDisplayOptions.ShowReminder = ShowAppointmentReminder, "ShowAppointmentReminder", canApply)
            Apply(Sub() view.AppointmentDisplayOptions.ShowRecurrence = ShowAppointmentRecurrence, "ShowAppointmentRecurrence", canApply)
            Apply(Sub() view.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType, "AppointmentStatusDisplayType", canApply)
        End Sub

        Private Sub Apply(ByVal dayView As DayView, ByVal canApply As Func(Of String, Boolean))
            Apply(Sub() dayView.AppointmentDisplayOptions.ShowSeparator = ShowDayViewAppointmentSeparator, "ShowDayViewAppointmentSeparator", canApply)
            Apply(Sub() dayView.WorkTime = WorkTime, "WorkTime", canApply)
            Apply(Sub() dayView.ShowDayHeaders = ShowDayHeaders, "ShowDayHeaders", canApply)
            Apply(Sub() dayView.ShowAllDayArea = ShowAllDayArea, "ShowAllDayArea", canApply)
            Apply(Sub() dayView.TimeMarkerVisibility = TimeMarkerVisibility, "TimeMarkerVisibility", canApply)
            Apply(Sub() dayView.TimeIndicatorDisplayOptions.ShowOverAppointment = ShowTimeIndicatorOverAppointment, "ShowTimeIndicatorOverAppointment", canApply)
            Apply(Sub() dayView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically = ShowAllDayAppointmentStatusVertically, "ShowAllDayAppointmentStatusVertically", canApply)
            Apply(Sub() dayView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType = AppointmentStatusDisplayType, "AppointmentStatusDisplayType", canApply)
            Apply(Sub()
                dayView.AppointmentDisplayOptions.StartTimeVisibility = If(ShowTimeForDayView, AppointmentTimeVisibility.Auto, AppointmentTimeVisibility.Never)
                dayView.AppointmentDisplayOptions.EndTimeVisibility = If(ShowTimeForDayView, AppointmentTimeVisibility.Auto, AppointmentTimeVisibility.Never)
            End Sub, "ShowTimeForDayView", canApply)
            Apply(Sub()
                For Each ruler As TimeRuler In dayView.TimeRulers
                    If ruler.HorizontalAlignment = TimeRulerHorizontalAlignment.Far Then ruler.Visible = ShowRightTimeRuler
                Next
            End Sub, "ShowRightTimeRuler", canApply)
        End Sub

        Private Sub Apply(ByVal monthView As MonthView, ByVal canApply As Func(Of String, Boolean))
            Apply(Sub() monthView.ShowWeekend = ShowWeekEnd, "ShowWeekEnd", canApply)
            Apply(Sub() monthView.CompressWeekend = CompressWeekEnd, "CompressWeekEnd", canApply)
            Apply(Sub() monthView.AppointmentDisplayOptions.ShowAppointmentStatusVertically = ShowAppointmentStatusVertically, "ShowAppointmentStatusVertically", canApply)
            Apply(Sub() monthView.AppointmentDisplayOptions.StartTimeVisibility = If(ShowStartTime, AppointmentTimeVisibility.Always, AppointmentTimeVisibility.Never), "ShowStartTime", canApply)
            Apply(Sub() monthView.AppointmentDisplayOptions.EndTimeVisibility = If(ShowEndTime, AppointmentTimeVisibility.Always, AppointmentTimeVisibility.Never), "ShowEndTime", canApply)
        End Sub

        Private Sub Apply(ByVal timelineView As TimelineView, ByVal canApply As Func(Of String, Boolean))
            Apply(Sub() timelineView.WorkTime = WorkTime, "WorkTime", canApply)
        End Sub
    End Class
End Namespace
