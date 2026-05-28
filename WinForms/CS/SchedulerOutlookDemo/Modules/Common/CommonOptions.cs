using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.XtraScheduler.Demos {
    public class CommonOptions {
        static CommonOptions _instance = new CommonOptions();
        public static CommonOptions Instance { get { return _instance; } }
        public static void ResetInstance() {
            _instance = new CommonOptions();
        }

        public CommonOptions() {
            ShowDayHeaders = true;
            ShowAllDayArea = true;
            ShowWeekEnd = true;
            ShowModuleOptionsPane = true;
            ShowAllDayAppointmentStatusVertically = true;
            ShowRightTimeRuler = true;
            WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(9), TimeSpan.FromHours(18));
            WorkDays = WeekDays.WorkDays;
            EnableReminders = true;
            EnableNavigationButtons = true;
            AllowEditAppointment = true;
            ShowAppointmentReminder = true;
            ShowAppointmentRecurrence = true;
            ShowAppointmentStatusVertically = true;
            AppointmentStatusDisplayType = AppointmentStatusDisplayType.Bounds;
            AllowAsyncLayout = true;
            ShowDayViewAppointmentSeparator = false;
            ShowTodayButton = true;
    }

        public bool ShowModuleOptionsPane { get; set; }

        public bool ShowDayHeaders { get; set; }
        public bool ShowAllDayArea { get; set; }
        public TimeMarkerVisibility TimeMarkerVisibility { get; set; }
        public bool ShowAllDayAppointmentStatusVertically { get; set; }
        public bool ShowRightTimeRuler { get; set; }

        public bool ShowWeekEnd { get; set; }
        public bool CompressWeekEnd { get; set; }
        public bool ShowAppointmentStatusVertically { get; set; }
        public bool ShowDayViewAppointmentSeparator { get; set; }
        public bool ShowTimeIndicatorOverAppointment { get; set; }
        public bool ShowStartTime { get; set; }
        public bool ShowEndTime { get; set; }
        public bool ShowTimeForDayView { get; set; }

        public TimeOfDayInterval WorkTime { get; set; }
        public WeekDays WorkDays { get; set; }
        public FirstDayOfWeek FirstDayOfWeek { get; set; }
        public bool EnableReminders { get; set; }
        public bool EnableNavigationButtons { get; set; }
        public bool AllowEditAppointment { get; set; }
        public bool AllowAsyncLayout { get; set; }

        public float FontSize { get; set; }
        public string FontFamilyName { get; set; }
        public bool ShowAppointmentReminder { get; set; }
        public bool ShowAppointmentRecurrence { get; set; }
        public bool ShowTodayButton { get; set; }

        public AppointmentStatusDisplayType AppointmentStatusDisplayType { get; set; }

        public void Apply(TutorialControl tutorial) {
            if (tutorial == null || tutorial.Scheduler == null)
                return;
            if (tutorial.CommonRibbonPanel != null)
                tutorial.CommonRibbonPanel.UpdateRibbonItems();
            tutorial.UpdateOptionsPaneVisibility(ShowModuleOptionsPane);
            SchedulerControl scheduler = tutorial.Scheduler;
            Func<string, bool> canApplyGlobalOption = tutorial.CanApplyGlobalOption;
            ApplyScheduler(scheduler, canApplyGlobalOption);
            ApplyBaseView(scheduler.DayView, canApplyGlobalOption);
            ApplyBaseView(scheduler.WorkWeekView, canApplyGlobalOption);
            ApplyBaseView(scheduler.FullWeekView, canApplyGlobalOption);
            ApplyBaseView(scheduler.MonthView, canApplyGlobalOption);
            ApplyBaseView(scheduler.TimelineView, canApplyGlobalOption);
            ApplyBaseView(scheduler.AgendaView, canApplyGlobalOption);
            Apply(scheduler.DayView, canApplyGlobalOption);
            Apply(scheduler.WorkWeekView, canApplyGlobalOption);
            Apply(scheduler.FullWeekView, canApplyGlobalOption);
            Apply(scheduler.MonthView, canApplyGlobalOption);
            Apply(scheduler.TimelineView, canApplyGlobalOption);
            tutorial.UpdateOptionsFromControl();
        }

        void Apply(Action applyAction, string propertyName, Func<string, bool> canApply) {
            if (canApply(propertyName)) {
                applyAction();
            }
        }

        void ApplyScheduler(SchedulerControl scheduler, Func<string, bool> canApply) {
            Apply(() => {
                scheduler.WorkDays.BeginUpdate();
                scheduler.WorkDays.Clear();
                scheduler.WorkDays.Add(WorkDays);
                scheduler.WorkDays.EndUpdate();
            }, "WorkDays", canApply);
            Apply(() => scheduler.OptionsView.FirstDayOfWeek = FirstDayOfWeek, "FirstDayOfWeek", canApply);
            Apply(() => scheduler.DataStorage.EnableReminders = EnableReminders, "EnableReminders", canApply);
            Apply(() => scheduler.OptionsView.NavigationButtons.Visibility = (EnableNavigationButtons) ? NavigationButtonVisibility.Auto : NavigationButtonVisibility.Never, "EnableNavigationButtons", canApply);
            Apply(() => scheduler.OptionsCustomization.AllowAppointmentEdit = AllowEditAppointment ? UsedAppointmentType.All : UsedAppointmentType.None, "AllowEditAppointment", canApply);
            Apply(() => scheduler.OptionsBehavior.UseAsyncMode = AllowAsyncLayout, "AllowAsyncLayout", canApply);
            Apply(() => {
                if (!String.IsNullOrEmpty(FontFamilyName)) {
                    System.Drawing.Font font = scheduler.Appearance.Appointment.Font;
                    scheduler.Appearance.Appointment.Font = new System.Drawing.Font(FontFamilyName, FontSize, font.Style, font.Unit, font.GdiCharSet, font.GdiVerticalFont);
                }
                else {
                    FontFamilyName = scheduler.Appearance.Appointment.Font.FontFamily.Name;
                    FontSize = scheduler.Appearance.Appointment.Font.Size;
                }
            }, "FontFamilyName", canApply);
            Apply(() => scheduler.DateNavigationBar.ShowTodayButton = ShowTodayButton, "ShowTodayButton", canApply);
        }

        void ApplyBaseView(SchedulerViewBase view, Func<string, bool> canApply) {
            Apply(() => view.AppointmentDisplayOptions.ShowReminder = ShowAppointmentReminder, "ShowAppointmentReminder", canApply);
            Apply(() => view.AppointmentDisplayOptions.ShowRecurrence = ShowAppointmentRecurrence, "ShowAppointmentRecurrence", canApply);
            Apply(() => view.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType, "AppointmentStatusDisplayType", canApply);
        }

        void Apply(DayView dayView, Func<string, bool> canApply) {
            Apply(() => dayView.AppointmentDisplayOptions.ShowSeparator = ShowDayViewAppointmentSeparator, "ShowDayViewAppointmentSeparator", canApply);
            Apply(() => dayView.WorkTime = WorkTime, "WorkTime", canApply);
            Apply(() => dayView.ShowDayHeaders = ShowDayHeaders, "ShowDayHeaders", canApply);
            Apply(() => dayView.ShowAllDayArea = ShowAllDayArea, "ShowAllDayArea", canApply);
            Apply(() => dayView.TimeMarkerVisibility = TimeMarkerVisibility, "TimeMarkerVisibility", canApply);
            Apply(() => dayView.TimeIndicatorDisplayOptions.ShowOverAppointment = ShowTimeIndicatorOverAppointment, "ShowTimeIndicatorOverAppointment", canApply);
            Apply(() => dayView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically = ShowAllDayAppointmentStatusVertically, "ShowAllDayAppointmentStatusVertically", canApply);
            Apply(() => dayView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType = AppointmentStatusDisplayType, "AppointmentStatusDisplayType", canApply);
            Apply(() => {
                dayView.AppointmentDisplayOptions.StartTimeVisibility = ShowTimeForDayView ? AppointmentTimeVisibility.Auto : AppointmentTimeVisibility.Never;
                dayView.AppointmentDisplayOptions.EndTimeVisibility = ShowTimeForDayView ? AppointmentTimeVisibility.Auto : AppointmentTimeVisibility.Never;
            }, "ShowTimeForDayView", canApply);
            Apply(() => {
                foreach (TimeRuler ruler in dayView.TimeRulers) {
                    if (ruler.HorizontalAlignment == TimeRulerHorizontalAlignment.Far)
                        ruler.Visible = ShowRightTimeRuler;
                }
            }, "ShowRightTimeRuler", canApply);
        }

        void Apply(MonthView monthView, Func<string, bool> canApply) {
            Apply(() => monthView.ShowWeekend = ShowWeekEnd, "ShowWeekEnd", canApply);
            Apply(() => monthView.CompressWeekend = CompressWeekEnd, "CompressWeekEnd", canApply);
            Apply(() => monthView.AppointmentDisplayOptions.ShowAppointmentStatusVertically = ShowAppointmentStatusVertically, "ShowAppointmentStatusVertically", canApply);
            Apply(() => monthView.AppointmentDisplayOptions.StartTimeVisibility = ShowStartTime ? AppointmentTimeVisibility.Always : AppointmentTimeVisibility.Never, "ShowStartTime", canApply);
            Apply(() => monthView.AppointmentDisplayOptions.EndTimeVisibility = ShowEndTime ? AppointmentTimeVisibility.Always : AppointmentTimeVisibility.Never, "ShowEndTime", canApply);
        }

        void Apply(TimelineView timelineView, Func<string, bool> canApply) {
            Apply(() => timelineView.WorkTime = WorkTime, "WorkTime", canApply);
        }
    }
}
