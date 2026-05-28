using DevExpress.XtraScheduler.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.MailClient.Win.Localizer {
    public class FarsiSchedulerLocalizer : SchedulerLocalizer {
        public override string GetLocalizedString(SchedulerStringId id) {
            switch (id) {
                case SchedulerStringId.AppointmentLabel_Anniversary:
                    return "سالگرد";
                case SchedulerStringId.Caption_WeekOfMonthLast:
                    return "آخرين";
                case SchedulerStringId.TimeScaleDisplayName_Year:
                    return "سال";
                case SchedulerStringId.MenuCmd_20Minutes:
                    return "& 20 دقیقه";
                case SchedulerStringId.DefaultToolTipStringFormat_SplitAppointment:
                    return "{0}: گام {1}";
                case SchedulerStringId.AppointmentLabel_PhoneCall:
                    return "تلفن تماس";
                case SchedulerStringId.MenuCmd_OpenAppointment:
                    return "& باز";
                case SchedulerStringId.Msg_InvalidDayCount:
                    return "تعداد روز های نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید.";
                case SchedulerStringId.Abbr_MinutesShort1:
                    return "m";
                case SchedulerStringId.Caption_MonthViewDescription:
                    return "تعویض به نمای ماه (چند هفته). نمای تقویم مفید برای برنامه های بلند مدت.";
                case SchedulerStringId.DescCmd_OpenAppointment:
                    return "انتصاب انتخاب شده را باز کنید.";
                case SchedulerStringId.Msg_InvalidDayOfWeekForDailyRecurrence:
                    return "نامعتبر روز هفته برای عود روزانه. تنها WeekDays.EveryDay WeekDays.WeekendDays و WeekDays.WorkDays معتبر در این زمینه هستند.";
                case SchedulerStringId.Appointment_StartContinueText:
                    return "از {0}";
                case SchedulerStringId.MenuCmd_DeleteAppointment:
                    return "& حذف";
                case SchedulerStringId.Msg_InvalidDayCountValue:
                    return "تعداد روز های نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید.";
                case SchedulerStringId.PrintCalendarDetailsControlDayPeriod:
                    return "روز";
                case SchedulerStringId.Abbr_MinutesShort2:
                    return "دقیقه";
                case SchedulerStringId.MenuCmd_PrintAppointment:
                    return "& چاپ";
                case SchedulerStringId.Appointment_EndContinueText:
                    return "به {0}";
                case SchedulerStringId.MenuCmd_30Minutes:
                    return "& 30 دقیقه";
                case SchedulerStringId.Caption_TimelineViewDescription:
                    return "تعویض به نمای خط زمان. قرار ملاقات در رابطه با زمان می رسم.";
                case SchedulerStringId.DescCmd_DeleteAppointment:
                    return "Appointment(s) انتخاب شده را حذف کنید.";
                case SchedulerStringId.Msg_InvalidWeekCount:
                    return "تعداد هفته های نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید.";
                case SchedulerStringId.Abbr_Minute:
                    return "دقیقه";
                case SchedulerStringId.Msg_InternalError:
                    return "خطای داخلی!";
                case SchedulerStringId.MenuCmd_NewAppointment:
                    return "جدید App & پماد";
                case SchedulerStringId.PrintCalendarDetailsControlWeekPeriod:
                    return "هفته";
                case SchedulerStringId.Msg_InvalidEndDate:
                    return "تاریخی که قبل از تاریخ شروع رخ می دهد.";
                case SchedulerStringId.MenuCmd_EditSeries:
                    return "& ویرایش سری";
                case SchedulerStringId.MenuCmd_60Minutes:
                    return "6 & 0 دقیقه";
                case SchedulerStringId.Msg_InvalidWeekCountValue:
                    return "تعداد هفته های نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید.";
                case SchedulerStringId.Abbr_Minutes:
                    return "دقیقه";
                case SchedulerStringId.DescCmd_NewAppointment:
                    return "ایجاد قرار جدید.";
                case SchedulerStringId.Caption_FullWeekViewDescription:
                    return "برای مشاهده هفته کامل تعویض نمایید. قرار ملاقات را برای یک هفته خاص در یک فرم فشرده مرتب می کند.";
                case SchedulerStringId.Msg_XtraSchedulerNotAssigned:
                    return "جزء SchedulerStorage به SchedulerControl شده است";
                case SchedulerStringId.Caption_Appointment:
                    return "{0} - قرار ملاقات";
                case SchedulerStringId.MenuCmd_RestoreOccurrence:
                    return "& حالت پیش فرض بازیابی";
                case SchedulerStringId.Msg_InvalidMonthCount:
                    return "تعداد دفعات مشاهده ماه نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید.";
                case SchedulerStringId.PrintCalendarDetailsControlMonthPeriod:
                    return "ماه";
                case SchedulerStringId.Abbr_HoursShort:
                    return "h";
                case SchedulerStringId.MenuCmd_NewAllDayEvent:
                    return "جدید تمام روز & رویداد";
                case SchedulerStringId.Caption_Event:
                    return "{0} - رویداد";
                case SchedulerStringId.MenuCmd_SwitchViewMenu:
                    return "تغییر نظر به";
                case SchedulerStringId.Caption_GanttViewDescription:
                    return "تعویض به نمای گانت. پروژه مشاهده مدیریت است که قرار ملاقات و وابستگیهای خود را در رابطه با زمان را نشان می دهد.";
                case SchedulerStringId.DescCmd_NewRecurringAppointment:
                    return "ملاقات تکراری جدید ایجاد کنید.";
                case SchedulerStringId.Msg_InvalidMonthCountValue:
                    return "تعداد دفعات مشاهده ماه نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید.";
                case SchedulerStringId.Abbr_Hour:
                    return "ساعت";
                case SchedulerStringId.Msg_InvalidTimeOfDayInterval:
                    return "مدت زمان نامعتبر برای TimeOfDayInterval";
                case SchedulerStringId.PrintMonthlyOptControlOnePagePerMonth:
                    return "1 صفحه در ماه";
                case SchedulerStringId.MenuCmd_NewRecurringAppointment:
                    return "تکراری جدید & قرار ملاقات";
                case SchedulerStringId.Caption_UntitledAppointment:
                    return "بدون عنوان";
                case SchedulerStringId.MenuCmd_NewRecurringEvent:
                    return "Recurring جدید الکترونیکی & دریچه";
                case SchedulerStringId.MenuCmd_SwitchToDayView:
                    return "& روز مشاهده";
                case SchedulerStringId.Msg_InvalidYearCount:
                    return "تعداد سال های نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید.";
                case SchedulerStringId.Abbr_Hours:
                    return "ساعت";
                case SchedulerStringId.Caption_AgendaViewDescription:
                    return "برای مشاهده برنامه تعویض نمایید. لیستی از رویدادهای آینده را نمایش می دهد";
                case SchedulerStringId.DescCmd_GotoToday:
                    return "تاریخ نمایش داده شده در نمای کنونی به تاریخ فعلی را تغییر دهید.";
                case SchedulerStringId.Msg_OverflowTimeOfDayInterval:
                    return "مقدار غیرمعتبر برای TimeOfDayInterval. باید کمتر یا برابر با روز";
                case SchedulerStringId.Caption_ReadOnly:
                    return "[ادامه]";
                case SchedulerStringId.MenuCmd_EditAppointmentDependency:
                    return "& ویرایش";
                case SchedulerStringId.PrintMonthlyOptControlTwoPagesPerMonth:
                    return "2 صفحه در ماه";
                case SchedulerStringId.Msg_InvalidYearCountValue:
                    return "تعداد سال های نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید.";
                case SchedulerStringId.Abbr_DaysShort:
                    return "د";
                case SchedulerStringId.MenuCmd_GotoDate:
                    return "& رفتن به تاریخ...";
                case SchedulerStringId.MenuCmd_SwitchToWorkWeekView:
                    return "وو & rk هفته مشاهده";
                case SchedulerStringId.Caption_WeekDaysEveryDay:
                    return "روز";
                case SchedulerStringId.Caption_GroupByNoneDescription:
                    return "لغو قرار ملاقات.";
                case SchedulerStringId.DescCmd_EditAppointmentDependency:
                    return "ویرایش وابستگی ملاقات.";
                case SchedulerStringId.Msg_InvalidOccurrencesCount:
                    return "تعداد رخداد نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید.";
                case SchedulerStringId.Abbr_Day:
                    return "روز";
                case SchedulerStringId.Msg_LoadCollectionFromXml:
                    return "برنامه ریز باید در حالت بی بند و بار بار مورد مجموعه از xml باشد";
                case SchedulerStringId.MenuCmd_OtherSettings:
                    return "دیگر Sett & آمیزش...";
                case SchedulerStringId.Caption_WeekDaysWeekendDays:
                    return "روز آخر هفته";
                case SchedulerStringId.MenuCmd_DeleteAppointmentDependency:
                    return "& حذف";
                case SchedulerStringId.Msg_InvalidOccurrencesCountValue:
                    return "تعداد رخداد نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید.";
                case SchedulerStringId.Abbr_Days:
                    return "روز";
                case SchedulerStringId.MenuCmd_CustomizeCurrentView:
                    return "& سفارشی نمودن نمای کنونی...";
                case SchedulerStringId.MenuCmd_SwitchToMonthView:
                    return "& نمای ماه";
                case SchedulerStringId.PrintTimeIntervalControlInvalidDuration:
                    return "مدت زمان باید باشد نه بیشتر از یک روز و بیشتر از 0";
                case SchedulerStringId.Caption_WeekDaysWorkDays:
                    return "روز هفته";
                case SchedulerStringId.DescCmd_DeleteAppointmentDependency:
                    return "وابستگی قرار ملاقات را حذف کنید.";
                case SchedulerStringId.Msg_InvalidDayNumber:
                    return "تعداد روز های نامعتبر. لطفا عدد صحیح از 1 تا {0} را وارد کنید.";
                case SchedulerStringId.MenuCmd_SwitchToWeekView:
                    return "& هفته مشاهده";
                case SchedulerStringId.Abbr_WeeksShort:
                    return "w";
                case SchedulerStringId.Abbr_Months:
                    return "ماه";
                case SchedulerStringId.MenuCmd_CustomizeTimeRuler:
                    return "زمان حاکم سفارشی...";
                case SchedulerStringId.Caption_GroupByDateDescription:
                    return "قرار ملاقات گروه تاریخ.";
                case SchedulerStringId.AppointmentLabel_None:
                    return "هیچ کدام";
                case SchedulerStringId.Caption_WeekOfMonthFirst:
                    return "اول";
                case SchedulerStringId.MenuCmd_GotoThisDay:
                    return "رفتن به این & روز";
                case SchedulerStringId.Msg_InvalidDayNumberValue:
                    return "تعداد روز های نامعتبر. لطفا عدد صحیح از 1 تا {0} را وارد کنید.";
                case SchedulerStringId.MenuCmd_SwitchToTimelineView:
                    return "& نمای";
                case SchedulerStringId.Abbr_Week:
                    return "هفته";
                case SchedulerStringId.Abbr_Year:
                    return "سال";
                case SchedulerStringId.MenuCmd_5Minutes:
                    return "& 5 دقیقه";
                case SchedulerStringId.PrintTimeIntervalControlInvalidStartEndTime:
                    return "زمان پایان می باید بیشتر از زمان شروع";
                case SchedulerStringId.MenuCmd_SwitchToAgendaView:
                    return "& مشاهده دستور کار";
                case SchedulerStringId.Caption_WeekOfMonthSecond:
                    return "دوم";
                case SchedulerStringId.MenuCmd_GotoToday:
                    return "رفتن به & امروز";
                case SchedulerStringId.Msg_WarningDayNumber:
                    return "چند ماه کمتر از {0} روز است. این ماه رخدادها در آخرین روز ماه سقوط خواهد کرد.";
                case SchedulerStringId.Caption_GroupByResourceDescription:
                    return "ملاقات گروهی توسط منابع.";
                case SchedulerStringId.Abbr_Weeks:
                    return "هفته";
                case SchedulerStringId.Abbr_Years:
                    return "سال";
                case SchedulerStringId.AppointmentLabel_Important:
                    return "مهم";
                case SchedulerStringId.MenuCmd_6Minutes:
                    return "& 6 دقیقه";
                case SchedulerStringId.MenuCmd_SwitchToFullWeekView:
                    return "& هفته کامل مشاهده";
                case SchedulerStringId.Caption_WeekOfMonthThird:
                    return "سوم";
                case SchedulerStringId.MenuCmd_15Minutes:
                    return "& 15 دقیقه";
                case SchedulerStringId.PrintTriFoldOptControlDailyCalendar:
                    return "تقویم روزانه";
                case SchedulerStringId.Msg_InvalidDayOfWeek:
                    return "هیچ روز انتخاب شده. لطفا حداقل یک روز در هفته را انتخاب کنید.";
                case SchedulerStringId.Abbr_Month:
                    return "ماه";
                case SchedulerStringId.Caption_Reminder:
                    return "{0} یادآوری";
                case SchedulerStringId.MenuCmd_SwitchToGroupByNone:
                    return "& گروه توسط هیچ";
                case SchedulerStringId.Msg_iCalendar_NotValidFile:
                    return "پرونده های تقویم اینترنتی معتبر";
                case SchedulerStringId.MenuCmd_10Minutes:
                    return "10 & دقیقه";
                case SchedulerStringId.Caption_WeekOfMonthFourth:
                    return "چهارم";
                case SchedulerStringId.MenuCmd_TimeScaleYear:
                    return "& سال";
                case SchedulerStringId.AppointmentLabel_Business:
                    return "کسب و کار";
                case SchedulerStringId.Msg_WarningAppointmentDeleted:
                    return "انتصاب بوسیله کاربر دیگری حذف شده است.";
                case SchedulerStringId.Format_TimeBeforeStart:
                    return "{0} قبل از شروع";
                case SchedulerStringId.MenuCmd_TimeScaleDay:
                    return "& روز";
                case SchedulerStringId.Caption_Reminders:
                    return "{0} یادآوری";
                case SchedulerStringId.PrintTriFoldOptControlWeeklyCalendar:
                    return "تقویم هفتگی";
                case SchedulerStringId.MenuCmd_AppointmentLabelTravelRequired:
                    return "& لزوم مسافرت";
                case SchedulerStringId.Caption_Busy:
                    return "گرفتار";
                case SchedulerStringId.MenuCmd_ShowTimeAs:
                    return "& نمایش زمان بعنوان";
                case SchedulerStringId.MenuCmd_SwitchToGroupByResource:
                    return "& گروه توسط منابع";
                case SchedulerStringId.ViewShortDisplayName_Timeline:
                    return "جدول زمانی";
                case SchedulerStringId.Msg_iCalendar_AppointmentsImportWarning:
                    return "برخی از قرار ملاقات را وارد کند";
                case SchedulerStringId.Msg_Conflict:
                    return "درگیری ویرایش قرار ملاقات با یک یا چند ملاقات دیگر.";
                case SchedulerStringId.Caption_StartTime:
                    return "زمان شروع: {0}";
                case SchedulerStringId.AppointmentLabel_Personal:
                    return "شخصی";
                case SchedulerStringId.MenuCmd_AppointmentLabelNeedsPreparation:
                    return "& احتیاج به آمادگی";
                case SchedulerStringId.MenuCmd_TimeScaleWeek:
                    return "& هفته";
                case SchedulerStringId.Caption_Tentative:
                    return "آزمایشی";
                case SchedulerStringId.DescCmd_ShowTimeAs:
                    return "وضعیت ملاقات های انتخاب شده را تغییر دهید.";
                case SchedulerStringId.PrintTriFoldOptControlMonthlyCalendar:
                    return "تقویم ماهانه";
                case SchedulerStringId.ViewShortDisplayName_FullWeek:
                    return "هفته کامل";
                case SchedulerStringId.Msg_InvalidAppointmentDuration:
                    return "مقدار نامعتبر مشخص برای مدت زمان فاصله. لطفا یک مقدار مثبت.";
                case SchedulerStringId.MenuCmd_SwitchToGroupByDate:
                    return "& گروه تاریخ";
                case SchedulerStringId.Caption_NAppointmentsAreSelected:
                    return "قرار ملاقات {0} انتخاب می شوند";
                case SchedulerStringId.MenuCmd_NavigateBackward:
                    return "عقب مانده";
                case SchedulerStringId.MenuCmd_AppointmentLabelBirthday:
                    return "& تولد";
                case SchedulerStringId.Caption_WorkingElsewhere:
                    return "در جای دیگر کار";
                case SchedulerStringId.MenuCmd_Free:
                    return "& رایگان";
                case SchedulerStringId.Caption_FirstVisibleResources:
                    return "اول";
                case SchedulerStringId.ViewShortDisplayName_Gantt:
                    return "گانت";
                case SchedulerStringId.AppointmentLabel_Vacation:
                    return "تعطیلات";
                case SchedulerStringId.Msg_InvalidReminderTimeBeforeStart:
                    return "مقدار نامعتبر برای تعیین شده قبل از زمان یادآوری رویداد. لطفا یک مقدار مثبت.";
                case SchedulerStringId.TextWeekly_2Day:
                    return "{0} و {1}";
                case SchedulerStringId.MenuCmd_TimeScaleMonth:
                    return "& ماه";
                case SchedulerStringId.MenuCmd_AppointmentLabelAnniversary:
                    return "& سالگرد";
                case SchedulerStringId.Caption_OutOfOffice:
                    return "خارج از دفتر";
                case SchedulerStringId.MenuCmd_Busy:
                    return "& مشغول";
                case SchedulerStringId.ViewShortDisplayName_Agenda:
                    return "دستور کار";
                case SchedulerStringId.PrintWeeklyOptControlOneWeekPerPage:
                    return "1 صفحه در روز";
                case SchedulerStringId.TextDuration_FromTo:
                    return "از {0} به {1}";
                case SchedulerStringId.TextWeekly_3Day:
                    return "{0}، {1} و {2}";
                case SchedulerStringId.MenuCmd_AppointmentLabelPhoneCall:
                    return "& تلفنی";
                case SchedulerStringId.ViewDisplayName_Day:
                    return "تقویم روز";
                case SchedulerStringId.MenuCmd_Tentative:
                    return "& نامشخص";
                case SchedulerStringId.MenuCmd_SwitchToGanttView:
                    return "& گانت مشاهده";
                case SchedulerStringId.MenuCmd_NavigateForward:
                    return "به جلو";
                case SchedulerStringId.TimeScaleDisplayName_Hour:
                    return "ساعت";
                case SchedulerStringId.TextDuration_FromForDays:
                    return "از {0} {1} ";
                case SchedulerStringId.MenuCmd_ViewZoomOut:
                    return "زوم کردن";
                case SchedulerStringId.Caption_PrevVisibleResourcesPage:
                    return "صفحه قبلی";
                case SchedulerStringId.TextWeekly_4Day:
                    return "{0}، {1}، {2} و {3}";
                case SchedulerStringId.MenuCmd_AppointmentMove:
                    return "ماه & ve";
                case SchedulerStringId.ViewDisplayName_WorkDays:
                    return "تقویم هفته کاری";
                case SchedulerStringId.AppointmentLabel_MustAttend:
                    return "ضروریت حضور";
                case SchedulerStringId.MenuCmd_TimeScaleQuarter:
                    return "& سه ماهه";
                case SchedulerStringId.MenuCmd_OutOfOffice:
                    return "& خارج از دفتر";
                case SchedulerStringId.TimeScaleDisplayName_Day:
                    return "روز";
                case SchedulerStringId.TextDuration_FromForDaysHours:
                    return "از {0} {1} {2}";
                case SchedulerStringId.PrintWeeklyOptControlTwoWeekPerPage:
                    return "2 صفحه در هفته";
                case SchedulerStringId.MenuCmd_TimeScalesMenu:
                    return "& مقیاس زمان";
                case SchedulerStringId.DescCmd_ViewZoomIn:
                    return "پوسته پوسته شدن برای نمایش محتویات در جزئیات بیشتری را انجام می دهد.";
                case SchedulerStringId.TextWeekly_5Day:
                    return "{0}، {1}، {2}، {3} و {4}";
                case SchedulerStringId.MenuCmd_AppointmentCopy:
                    return "& کپی";
                case SchedulerStringId.DescCmd_NavigateBackward:
                    return "گام به عقب در زمان به عنوان پیشنهاد شده توسط نمای کنونی.";
                case SchedulerStringId.ViewDisplayName_Week:
                    return "تقویم هفته";
                case SchedulerStringId.MenuCmd_WorkingElsewhere:
                    return "& کار جای دیگر";
                case SchedulerStringId.TimeScaleDisplayName_Week:
                    return "هفته";
                case SchedulerStringId.Caption_PrevVisibleResources:
                    return "قبلی";
                case SchedulerStringId.AppointmentLabel_TravelRequired:
                    return "لزوم مسافرت";
                case SchedulerStringId.TextDuration_FromForDaysMinutes:
                    return "از {0} {1} {3}";
                case SchedulerStringId.DescCmd_ViewZoomOut:
                    return "مقیاس گذاری برای نمایش نگاه گسترده تر از این دیدگاه را انجام می دهد.";
                case SchedulerStringId.TextWeekly_6Day:
                    return "{0}، {1}، {2}، {3}، {4} و {5}";
                case SchedulerStringId.TextMonthlyPatternString_SubPattern:
                    return "از هر {0} {2} {1}";
                case SchedulerStringId.PrintPageSetupFormCaption:
                    return "گزینه های چاپ: {0}";
                case SchedulerStringId.MenuCmd_AppointmentCancel:
                    return "ج & ancel";
                case SchedulerStringId.ViewDisplayName_Month:
                    return "تقویم ماه";
                case SchedulerStringId.MenuCmd_LabelAs:
                    return "& خشکاندن";
                case SchedulerStringId.MenuCmd_TimeScaleCaptionsMenu:
                    return "مقیاس زمانی & شرح";
                case SchedulerStringId.TimeScaleDisplayName_Month:
                    return "ماه";
                case SchedulerStringId.TextDuration_FromForDaysHoursMinutes:
                    return "از {0} {1} {2} {3}";
                case SchedulerStringId.DescCmd_NavigateForward:
                    return "به جلو پیشروی در زمان به عنوان پیشنهاد شده توسط نمای کنونی.";
                case SchedulerStringId.DescCmd_SplitAppointment:
                    return "انتصاب منتخب در دو با کشیدن خط شکاف تقسیم.";
                case SchedulerStringId.Caption_PleaseSeeAbove:
                    return "لطفا نگاه کنید به بالا";
                case SchedulerStringId.TextWeekly_7Day:
                    return "{0}، {1}، {2}، {3}، {4}، {5} و {6}";
                case SchedulerStringId.Caption_5Minutes:
                    return "5 دقیقه";
                case SchedulerStringId.Caption_NextVisibleResources:
                    return "بعدی";
                case SchedulerStringId.ViewDisplayName_Timeline:
                    return "تقویم روزشمار";
                case SchedulerStringId.AppointmentLabel_NeedsPreparation:
                    return "احتیاج به آمادگی";
                case SchedulerStringId.DescCmd_LabelAs:
                    return "برچسب ملاقات های انتخاب شده را تغییر دهید.";
                case SchedulerStringId.TimeScaleDisplayName_Quarter:
                    return "سه ماهه";
                case SchedulerStringId.TextMonthlyPatternString1:
                    return "روز {3} {0}";
                case SchedulerStringId.TextDuration_ForPattern:
                    return "{0} و {1}";
                case SchedulerStringId.Caption_SplitAppointment:
                    return "اسپلیت";
                case SchedulerStringId.TextWeeklyPatternString_EveryWeek:
                    return "هر {0} {3}";
                case SchedulerStringId.PrintMoreItemsMsg:
                    return "موارد بیشتر...";
                case SchedulerStringId.MenuCmd_TimeScaleHour:
                    return "& ساعت";
                case SchedulerStringId.Caption_6Minutes:
                    return "6 دقیقه";
                case SchedulerStringId.ViewDisplayName_FullWeek:
                    return "تقویم هفته کامل";
                case SchedulerStringId.MenuCmd_AppointmentLabelNone:
                    return "& هیچ کدام";
                case SchedulerStringId.MenuCmd_ViewZoomIn:
                    return "بزرگنمایی";
                case SchedulerStringId.Caption_RecurrenceStartTime:
                    return "شروع:";
                case SchedulerStringId.TextDailyPatternString_EveryDay:
                    return "هر {0} {1}";
                case SchedulerStringId.VS_SchedulerReportsToolboxCategoryName:
                    return "DX. {0}: برنامه ریز گزارش";
                case SchedulerStringId.Caption_RecurrenceSubject:
                    return "موضوع:";
                case SchedulerStringId.Caption_NextVisibleResourcesPage:
                    return "صفحه بعد";
                case SchedulerStringId.TextWeeklyPatternString_EveryWeeks:
                    return "هر {2} {1} در {3} {0}";
                case SchedulerStringId.Caption_10Minutes:
                    return "10 دقیقه";
                case SchedulerStringId.ViewDisplayName_Gantt:
                    return "نمای گانت";
                case SchedulerStringId.AppointmentLabel_Birthday:
                    return "تولد";
                case SchedulerStringId.MenuCmd_AppointmentLabelImportant:
                    return "& مهم";
                case SchedulerStringId.TextMonthlyPatternString2:
                    return "{1} {2} {0}";
                case SchedulerStringId.Caption_RecurrenceEndTime:
                    return "پایان:";
                case SchedulerStringId.TextDailyPatternString_EveryDays:
                    return "هر {0} {1} {2}";
                case SchedulerStringId.PrintNoPrintersInstalled:
                    return "هیچ چاپگری نصب نشده";
                case SchedulerStringId.UD_SchedulerReportsToolboxCategoryName:
                    return "کنترل زمانبندی";
                case SchedulerStringId.Caption_DecreaseVisibleResourcesCount:
                    return "کاهش تعداد منابع قابل مشاهده";
                case SchedulerStringId.Caption_15Minutes:
                    return "15 دقیقه";
                case SchedulerStringId.Caption_ColorConverterBlackAndWhite:
                    return "سیاه و سفید";
                case SchedulerStringId.Reporting_NotAssigned_TimeCells:
                    return "مورد نیاز TimeCells کنترل شده است";
                case SchedulerStringId.ViewDisplayName_Agenda:
                    return "دستور کار تقویم";
                case SchedulerStringId.MenuCmd_AppointmentLabelBusiness:
                    return "& کسب و کار";
                case SchedulerStringId.Caption_RecurrenceShowTimeAs:
                    return "نمایش زمان بعنوان:";
                case SchedulerStringId.Caption_RecurrenceLocation:
                    return "محل سکونت:";
                case SchedulerStringId.TextDailyPatternString_EveryWeekDay:
                    return "هر روز هفته {0}";
                case SchedulerStringId.Caption_LastVisibleResources:
                    return "آخرين";
                case SchedulerStringId.DescCmd_Print:
                    return "برنامه ارسال مستقیم به چاپگر پیش فرض بدون ایجاد تغییرات.";
                case SchedulerStringId.Caption_ShadingApplyToAllDayArea:
                    return "تمام روز منطقه";
                case SchedulerStringId.Msg_InvalidInputFile:
                    return "فایل ورودی نامعتبر است";
                case SchedulerStringId.Caption_20Minutes:
                    return "20 دقیقه";
                case SchedulerStringId.ViewShortDisplayName_Day:
                    return "روز";
                case SchedulerStringId.MenuCmd_AppointmentLabelPersonal:
                    return "& شخصی";
                case SchedulerStringId.TextYearlyPattern_YearString1:
                    return "هر {0} {4} {3}";
                case SchedulerStringId.Caption_Recurrence:
                    return "عود:";
                case SchedulerStringId.TextDailyPatternString_EveryWeekend:
                    return "هر آخر هفته {0}";
                case SchedulerStringId.MenuCmd_PrintPageSetup:
                    return "راه اندازی & صفحه";
                case SchedulerStringId.Msg_MissingRequiredMapping:
                    return "نقشه برداری مورد نیاز برای '{0}' اموال مفقود شده است.";
                case SchedulerStringId.Caption_ResourceNone:
                    return "(خالی)";
                case SchedulerStringId.Caption_ShadingApplyToAppointments:
                    return "قرار ملاقات";
                case SchedulerStringId.Caption_30Minutes:
                    return "30 دقیقه";
                case SchedulerStringId.ViewShortDisplayName_WorkDays:
                    return "هفته کاری";
                case SchedulerStringId.Reporting_NotAssigned_View:
                    return "جزء مورد نیاز مشاهده شده است";
                case SchedulerStringId.MenuCmd_AppointmentLabelVacation:
                    return "& تعطیلات";
                case SchedulerStringId.Caption_RecurrencePattern:
                    return "الگوی تکرار:";
                case SchedulerStringId.Caption_SetupAppointmentStorage:
                    return "تنظیم قرار ملاقات ذخیره سازی";
                case SchedulerStringId.TextWeekly_0Day:
                    return "روز مشخص نشده هفته";
                case SchedulerStringId.Caption_IncreaseVisibleResourcesCount:
                    return "افزایش تعداد منابع قابل مشاهده";
                case SchedulerStringId.DescCmd_PrintPageSetup:
                    return "سفارشی کردن ظاهر صفحه و پیکربندی گزینه های چاپ مختلف.";
                case SchedulerStringId.Caption_ShadingApplyToAppointmentStatuses:
                    return "وضعیت ملاقات";
                case SchedulerStringId.Caption_ModifyResourceStorageTransactionDescription:
                    return "تغییر منبع ذخیره سازی";
                case SchedulerStringId.TextRecurrenceTypeDaily:
                    return "روزانه";
                case SchedulerStringId.TextYearlyPattern_YearString2:
                    return "{6} {5} {3} {0}";
                case SchedulerStringId.Caption_60Minutes:
                    return "60 دقیقه";
                case SchedulerStringId.ViewShortDisplayName_Week:
                    return "هفته";
                case SchedulerStringId.MenuCmd_AppointmentLabelMustAttend:
                    return "باید & حضور";
                case SchedulerStringId.Caption_NoneRecurrence:
                    return "(خالی)";
                case SchedulerStringId.TextWeekly_1Day:
                    return "{0}";
                case SchedulerStringId.DescCmd_TimeScalesMenu:
                    return "مقیاس زمانی تغییر دهید.";
                case SchedulerStringId.Caption_ResourceAll:
                    return "(تمام)";
                case SchedulerStringId.Msg_RecurrenceExceptionsWillBeLost:
                    return "هر استثنایی مربوط به این ملاقات تکراری گم می شود. ادامه می دهید؟";
                case SchedulerStringId.Caption_ShadingApplyToHeaders:
                    return "سرصفحه ها";
                case SchedulerStringId.MenuCmd_CellsAutoHeight:
                    return "ارتفاع خودرو همراه";
                case SchedulerStringId.Caption_Free:
                    return "رایگان";
                case SchedulerStringId.Caption_SetupResourceStorage:
                    return "راه اندازی منابع ذخیره سازی";
                case SchedulerStringId.ViewShortDisplayName_Month:
                    return "ماه";
                case SchedulerStringId.MenuCmd_ToggleRecurrence:
                    return "عود";
                case SchedulerStringId.MemoPrintDateFormat:
                    return "{0} {1} {2}";
                case SchedulerStringId.Caption_ModifyAppointmentDependencyStorageTransactionDescription:
                    return "ویرایش ذخیره سازی AppointmentDependency";
                case SchedulerStringId.TextRecurrenceTypeWeekly:
                    return "بارگیری";
                case SchedulerStringId.DescCmd_OpenSeries:
                    return "این جلسه سری باز.";
                case SchedulerStringId.MenuCmd_ShowWorkTimeOnly:
                    return "ساعات کار";
                case SchedulerStringId.Caption_ShadingApplyToTimeRulers:
                    return "حاکمان زمان";
                case SchedulerStringId.TextYearlyPattern_YearsString1:
                    return "{3} {4} هر {0} {2} {1}";
                case SchedulerStringId.Msg_DuplicateMappingMember:
                    return "عضو '{0}' نقشه برداری منحصر به فرد است:";
                case SchedulerStringId.PrintPageSetupFormatTabControlCustomizeShading:
                    return "<Customize...></Customize...>";
                case SchedulerStringId.DescCmd_CellsAutoHeight:
                    return "همراه هم به اندازه آن را به جای آن وجود دارد قرار ملاقات تنظیم خودکار را فعال کنید.";
                case SchedulerStringId.DescCmd_ToggleRecurrence:
                    return "را انتخاب شده ملاقات تکراری و یا ویرایش الگوی تکرار.";
                case SchedulerStringId.Caption_EmptyResource:
                    return "(هر)";
                case SchedulerStringId.DescCmd_CreateAppointmentDependency:
                    return "ایجاد وابستگی بین قرار ملاقات";
                case SchedulerStringId.Caption_DayViewDescription:
                    return "تعویض به نمای روز. مشاهده دقیق ترین ملاقات براى روز خاص.";
                case SchedulerStringId.MenuCmd_DeleteOccurrence:
                    return "حذف رخداد";
                case SchedulerStringId.Caption_SetupAppointmentDependencyStorage:
                    return "راه اندازی شبکه وابستگی";
                case SchedulerStringId.DescCmd_ShowWorkTimeOnly:
                    return "فقط ساعات کار را در تقویم نشان می دهد.";
                case SchedulerStringId.Caption_ShadingApplyToCells:
                    return "سلول های";
                case SchedulerStringId.TextRecurrenceTypeMonthly:
                    return "ماهانه";
                case SchedulerStringId.MenuCmd_ChangeAppointmentReminderUI:
                    return "یادآوری";
                case SchedulerStringId.Caption_DailyPrintStyle:
                    return "سبک روزانه";
                case SchedulerStringId.TextYearlyPattern_YearsString2:
                    return "{5} {6} {3} هر {0} {2} {1}";
                case SchedulerStringId.Caption_WorkWeekViewDescription:
                    return "تعویض به نمای هفته کاری. مشاهده دقیق برای روز کاری در هفته خاص.";
                case SchedulerStringId.Msg_InconsistentRecurrenceInfoMapping:
                    return "برای حمایت از عود شما RecurrenceInfo و نوع نقشه باید عضو.";
                case SchedulerStringId.PrintPageSetupFormatTabControlSizeAndFontName:
                    return "{0} pt. {1}";
                case SchedulerStringId.DescCmd_DeleteOccurrence:
                    return "حذف رخداد.";
                case SchedulerStringId.MenuCmd_CreateAppointmentDependency:
                    return "ایجاد وابستگی";
                case SchedulerStringId.MenuCmd_CompressWeekend:
                    return "آخر هفته فشرده";
                case SchedulerStringId.Msg_InvalidSize:
                    return "مقدار نامعتبر تعیین شده برای اندازه.";
                case SchedulerStringId.Caption_ModifyAppointmentStorageTransactionDescription:
                    return "تغییر ملاقات ذخیره سازی";
                case SchedulerStringId.DescCmd_ChangeAppointmentReminderUI:
                    return "زمان ملاقات منتخب یادآوری می شود را انتخاب کنید.";
                case SchedulerStringId.Caption_WeeklyPrintStyle:
                    return "سبک هفتگی";
                case SchedulerStringId.TextRecurrenceTypeYearly:
                    return "سالانه";
                case SchedulerStringId.Caption_WeekViewDescription:
                    return "برای مشاهده هفته تعویض نمایید. قرار ملاقات را برای یک هفته خاص در یک فرم فشرده مرتب می کند.";
                case SchedulerStringId.Caption_AllDay:
                    return "همه روز";
                case SchedulerStringId.MenuCmd_DeleteSeries:
                    return "حذف سری";
                case SchedulerStringId.DescCmd_CompressWeekend:
                    return "شنبه و یکشنبه فشرده شده به ستون را نشان می دهد.";
                case SchedulerStringId.Msg_MappingsCheckPassedOk:
                    return "تعیین صحیح است!";
                case SchedulerStringId.Msg_ApplyToAllStyles:
                    return "تنظیمات چاپگر را برای همه سبک اقدام کنم؟";
                case SchedulerStringId.PrintRangeControlInvalidDate:
                    return "تاریخ پایان باید بزرگتر یا برابر با تاریخ شروع";
                case SchedulerStringId.Caption_NoneReminder:
                    return "هیچ کدام";
                case SchedulerStringId.Caption_MonthlyPrintStyle:
                    return "سبک ماهانه";
                case SchedulerStringId.DescCmd_DeleteSeries:
                    return "حذف سری.";
                case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToStart:
                    return "پایان به شروع (FS)";
                case SchedulerStringId.Msg_MemoPrintNoSelectedItems:
                    return "چاپ نمی باشد، مگر اینکه موردی انتخاب شده است. موردی را انتخاب کنید و سپس مجددا برای چاپ سعی کنید.";
                case SchedulerStringId.TextRecurrenceTypeMinutely:
                    return "Minutely";
                case SchedulerStringId.DescCmd_ChangeTimelineScaleWidth:
                    return "پهنای ستون در پیکسل برای مقیاس پایه را مشخص کنید.";
                case SchedulerStringId.Caption_TrifoldPrintStyle:
                    return "سبک سه تایی";
                case SchedulerStringId.Caption_SetupAppointmentMappings:
                    return "تنظیم قرار ملاقات نگاشت";
                case SchedulerStringId.Caption_AppointmentDependencyTypeStartToStart:
                    return "شروع برای شروع (اس اس)";
                case SchedulerStringId.Msg_SaveBeforeClose:
                    return "می خواهید تغییرات را ذخیره کنید؟";
                case SchedulerStringId.Caption_AllResources:
                    return "تمام منابع";
                case SchedulerStringId.MenuCmd_ChangeTimelineScaleWidth:
                    return "مقیاس عرض";
                case SchedulerStringId.TextRecurrenceTypeHourly:
                    return "ساعات روز:";
                case SchedulerStringId.Caption_CalendarDetailsPrintStyle:
                    return "جزئیات سبک تقویم";
                case SchedulerStringId.String_to:
                    return "به";
                case SchedulerStringId.Caption_VisibleResources:
                    return "منابع قابل مشاهده";
                case SchedulerStringId.MenuCmd_OpenSchedule:
                    return "باز";
                case SchedulerStringId.Caption_SetupResourceMappings:
                    return "راه اندازی منابع نگاشت";
                case SchedulerStringId.Caption_MemoPrintStyle:
                    return "سبک یادآور";
                case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToFinish:
                    return "پایان به پایان (FF)";
                case SchedulerStringId.Caption_OnScreenResources:
                    return "صفحه منابع";
                case SchedulerStringId.DescCmd_OpenSchedule:
                    return "برنامه واردات از فایل (.ics).";
                case SchedulerStringId.Caption_ColorConverterFullColor:
                    return "رنگ کامل";
                case SchedulerStringId.Msg_Warning:
                    return "هشدار!";
                case SchedulerStringId.Caption_GroupByNone:
                    return "هیچ کدام";
                case SchedulerStringId.Caption_SetupDependencyMappings:
                    return "تنظیم وابستگی نگاشت";
                case SchedulerStringId.MenuCmd_SaveSchedule:
                    return "ذخیره";
                case SchedulerStringId.Caption_ColorConverterGrayScale:
                    return "سایه خاکستری";
                case SchedulerStringId.Caption_AppointmentDependencyTypeStartToFinish:
                    return "آغاز تا پایان (سانفرانسیسکو)";
                case SchedulerStringId.Caption_GroupByDate:
                    return "تاریخ";
                case SchedulerStringId.Msg_CantFitIntoPage:
                    return "خروجی چاپ را به یک صفحه با استفاده از تنظیمات چاپ مناسب است. لطفا سعی کنید به ارتفاع صفحه افزایش یا کاهش فاصله PrintTime.";
                case SchedulerStringId.DescCmd_SaveSchedule:
                    return "برنامه ذخیره فایل (.ics).";
                case SchedulerStringId.TextAppointmentSnapToCells_Always:
                    return "همیشه";
                case SchedulerStringId.Caption_GroupByResources:
                    return "منابع";
                case SchedulerStringId.Caption_ModifyAppointmentMappingsTransactionDescription:
                    return "تعیین قرار ملاقات را تغییر دهید";
                case SchedulerStringId.MenuCmd_ChangeSnapToCellsUI:
                    return "ضربه محکم و ناگهانی به سلول";
                case SchedulerStringId.TextAppointmentSnapToCells_Auto:
                    return "خودکار";
                case SchedulerStringId.Msg_PrintStyleNameExists:
                    return "نام سبک '{0}' در حال حاضر وجود دارد. نام دیگری را بنویسید.";
                case SchedulerStringId.Caption_ModifyResourceMappingsTransactionDescription:
                    return "تعیین منبع را تغییر دهید";
                case SchedulerStringId.DescCmd_ChangeSnapToCellsUI:
                    return "حالت snapping برای نمایش قرار ملاقات ها در داخل سلول های زمان را مشخص کنید.";
                case SchedulerStringId.TextAppointmentSnapToCells_Disabled:
                    return "معلول";
                case SchedulerStringId.Msg_OutlookCalendarNotFound:
                    return "'{0}' تقویم یافت نشد.";
                case SchedulerStringId.MenuCmd_OpenOccurrence:
                    return "وقوع باز";
                case SchedulerStringId.Caption_ModifyAppointmentDependencyMappingsTransactionDescription:
                    return "تعیین وابستگی قرار ملاقات را تغییر دهید";
                case SchedulerStringId.TextAppointmentSnapToCells_Never:
                    return "هرگز";
                case SchedulerStringId.Caption_PrevAppointment:
                    return "ملاقات قبلی";
                case SchedulerStringId.DescCmd_OpenOccurrence:
                    return "این رخداد جلسه را باز کنید.";
                case SchedulerStringId.Caption_MappingsValidation:
                    return "تعیین اعتبار";
                case SchedulerStringId.MenuCmd_PrintPreview:
                    return "نسخه قابل چاپ پیشنمایش &";
                case SchedulerStringId.Caption_NextAppointment:
                    return "ملاقات بعدی";
                case SchedulerStringId.MenuCmd_OpenSeries:
                    return "سری باز";
                case SchedulerStringId.Caption_MappingsWizard:
                    return "سهل آموز نگاشت...";
                case SchedulerStringId.DescCmd_PrintPreview:
                    return "پیش نمایش و ایجاد تغییرات در صفحات قبل از چاپ.";
                case SchedulerStringId.DisplayName_Appointment:
                    return "قرار ملاقات";
                case SchedulerStringId.Caption_CheckMappings:
                    return "تعیین را بررسی کنید";
                case SchedulerStringId.MenuCmd_Print:
                    return "چاپ فوری";
                case SchedulerStringId.Format_CopyOf:
                    return "کپی از {0}";
                case SchedulerStringId.Format_CopyNOf:
                    return "کپی ({0}) از {1}";

                default:
                    return base.GetLocalizedString(id);
            }

        }
    }
    public class ArabicSchedulerLocalizer : SchedulerLocalizer {
        public override string GetLocalizedString(SchedulerStringId id) {
            switch (id) {
                case SchedulerStringId.AppointmentLabel_Anniversary:
                    return "الذكرى السنوية";
                case SchedulerStringId.Msg_InvalidEndDate:
                    return "يحدث التاريخ الذي أدخلته قبل تاريخ البدء.";
                case SchedulerStringId.Msg_IsNotValid:
                    return "'{0}' ليست قيمة صالحة ل '{1}'";
                case SchedulerStringId.MenuCmd_20Minutes:
                    return "آند 20 دقيقة";
                case SchedulerStringId.PrintCalendarDetailsControlDayPeriod:
                    return "اليوم";
                case SchedulerStringId.Msg_InvalidDayOfWeekForDailyRecurrence:
                    return "غير صالح اليوم من الأسبوع لتكرار يومية. إلا WeekDays.EveryDay و WeekDays.WeekendDays و WeekDays.WorkDays صالحة في هذا السياق.";
                case SchedulerStringId.TimeScaleDisplayName_Year:
                    return "السنة";
                case SchedulerStringId.Caption_MonthViewDescription:
                    return "قم بالتبديل إلى طريقة عرض الشهر (عدة أسابيع). طريقة عرض التقويم مفيدة لخطط طويلة الأجل.";
                case SchedulerStringId.Caption_Appointment:
                    return "{0}-التعيين";
                case SchedulerStringId.DefaultToolTipStringFormat_SplitAppointment:
                    return "{0}: الخطوة {1}";
                case SchedulerStringId.AppointmentLabel_PhoneCall:
                    return "مكالمة هاتفية";
                case SchedulerStringId.Caption_Event:
                    return "{0}-الحدث";
                case SchedulerStringId.MenuCmd_30Minutes:
                    return "آند 30 دقيقة";
                case SchedulerStringId.PrintCalendarDetailsControlWeekPeriod:
                    return "الأسبوع";
                case SchedulerStringId.Msg_InternalError:
                    return "خطأ داخلي!";
                case SchedulerStringId.Abbr_MinutesShort1:
                    return "m";
                case SchedulerStringId.Caption_WeekOfMonthFirst:
                    return "الأولى";
                case SchedulerStringId.Caption_TimelineViewDescription:
                    return "قم بالتبديل إلى طريقة عرض المخطط الزمني. قطع التعيينات بالنسبة للوقت.";
                case SchedulerStringId.Caption_ReadOnly:
                    return "[للقراءة فقط]";
                case SchedulerStringId.MenuCmd_60Minutes:
                    return "6 آند 0 دقيقة";
                case SchedulerStringId.Appointment_StartContinueText:
                    return "من {0}";
                case SchedulerStringId.Caption_UntitledAppointment:
                    return "بدون عنوان";
                case SchedulerStringId.PrintCalendarDetailsControlMonthPeriod:
                    return "في الشهر";
                case SchedulerStringId.Msg_XtraSchedulerNotAssigned:
                    return "لم يتم تعيين عنصر شيدوليرستوراجي إلى شيدوليركونترول";
                case SchedulerStringId.Caption_FullWeekViewDescription:
                    return "قم بالتبديل إلى طريقة عرض أسبوع كامل. ترتيب مواعيد لأسبوع معين في نموذج مضغوط.";
                case SchedulerStringId.Caption_WeekDaysEveryDay:
                    return "اليوم";
                case SchedulerStringId.Abbr_MinutesShort2:
                    return "دقيقة";
                case SchedulerStringId.Caption_WeekOfMonthSecond:
                    return "الثانية";
                case SchedulerStringId.Appointment_EndContinueText:
                    return "إلى {0}";
                case SchedulerStringId.MenuCmd_SwitchViewMenu:
                    return "تغيير طريقة العرض إلى";
                case SchedulerStringId.PrintMonthlyOptControlOnePagePerMonth:
                    return "الصفحة 1/الشهر";
                case SchedulerStringId.Caption_WeekOfMonthThird:
                    return "الثالثة";
                case SchedulerStringId.Msg_InvalidTimeOfDayInterval:
                    return "المدة غير صحيحة تيميوفدايينتيرفال";
                case SchedulerStringId.Abbr_Minute:
                    return "دقيقة";
                case SchedulerStringId.Caption_GanttViewDescription:
                    return "قم بالتبديل إلى طريقة العرض مخطط جانت. عرض إدارة المشروع تظهر المواعيد والتبعيات الخاصة بهم فيما يتعلق بالوقت.";
                case SchedulerStringId.Caption_WeekDaysWeekendDays:
                    return "يوم عطلة نهاية الأسبوع";
                case SchedulerStringId.MenuCmd_SwitchToDayView:
                    return "آند طريقة العرض يوم";
                case SchedulerStringId.Msg_InvalidDayCountValue:
                    return "عد اليوم غير صالحة. الرجاء إدخال عدد صحيح موجب.";
                case SchedulerStringId.PrintMonthlyOptControlTwoPagesPerMonth:
                    return "2 صفحات/الشهر";
                case SchedulerStringId.Msg_InvalidMonthCountValue:
                    return "عدد غير صالح في الشهر. الرجاء إدخال عدد صحيح موجب.";
                case SchedulerStringId.Caption_WeekOfMonthFourth:
                    return "الرابعة";
                case SchedulerStringId.Caption_AgendaViewDescription:
                    return "قم بالتبديل إلى طريقة عرض جدول. يعرض قائمة بالأحداث القادمة";
                case SchedulerStringId.Caption_WeekDaysWorkDays:
                    return "يوم من أيام الأسبوع";
                case SchedulerStringId.Msg_OverflowTimeOfDayInterval:
                    return "الحصول على قيمة غير صحيحة تيميوفدايينتيرفال. وينبغي أن يكون أقل من أو يساوي يوم واحد";
                case SchedulerStringId.Abbr_Minutes:
                    return "دقيقة";
                case SchedulerStringId.Msg_InvalidWeekCount:
                    return "عدد غير صالح في الأسبوع. الرجاء إدخال عدد صحيح موجب.";
                case SchedulerStringId.PrintTimeIntervalControlInvalidDuration:
                    return "يجب أن تكون مدة لا تزيد عن يوم واحد وأكبر من 0";
                case SchedulerStringId.Caption_GroupByNoneDescription:
                    return "فك تجميع التعيينات.";
                case SchedulerStringId.Msg_InvalidYearCount:
                    return "عد السنة غير صالح. الرجاء إدخال عدد صحيح موجب.";
                case SchedulerStringId.Caption_WeekOfMonthLast:
                    return "آخر";
                case SchedulerStringId.Msg_InvalidDayOfWeek:
                    return "لا يوجد اليوم المحدد. الرجاء تحديد يوم واحد على الأقل في الأسبوع.";
                case SchedulerStringId.MenuCmd_SwitchToMonthView:
                    return "آند طريقة عرض الشهر";
                case SchedulerStringId.MenuCmd_SwitchToWorkWeekView:
                    return "عمل عرض الأسبوع";
                case SchedulerStringId.Msg_LoadCollectionFromXml:
                    return "الجدولة تحتاج أن تكون في وضع غير منضم لتحميل عناصر مجموعة من xml";
                case SchedulerStringId.MenuCmd_SwitchToWeekView:
                    return "آند طريقة عرض الأسبوع";
                case SchedulerStringId.Abbr_HoursShort:
                    return "ح";
                case SchedulerStringId.Msg_InvalidWeekCountValue:
                    return "عدد غير صالح في الأسبوع. الرجاء إدخال عدد صحيح موجب.";
                case SchedulerStringId.Msg_InvalidYearCountValue:
                    return "عد السنة غير صالح. الرجاء إدخال عدد صحيح موجب.";
                case SchedulerStringId.Msg_InvalidDayCount:
                    return "عد اليوم غير صالحة. الرجاء إدخال عدد صحيح موجب.";
                case SchedulerStringId.AppointmentLabel_None:
                    return "لا شيء";
                case SchedulerStringId.PrintTimeIntervalControlInvalidStartEndTime:
                    return "يجب أن يكون وقت النهاية أكبر من وقت البدء";
                case SchedulerStringId.Caption_GroupByDateDescription:
                    return "مجموعة التعيينات حسب التاريخ.";
                case SchedulerStringId.Msg_WarningAppointmentDeleted:
                    return "تم حذف التعيين من قبل مستخدم آخر.";
                case SchedulerStringId.Abbr_Hour:
                    return "ساعة";
                case SchedulerStringId.Msg_InvalidMonthCount:
                    return "عدد غير صالح في الشهر. الرجاء إدخال عدد صحيح موجب.";
                case SchedulerStringId.Msg_InvalidOccurrencesCount:
                    return "عدد تكرارات غير صالحة. الرجاء إدخال عدد صحيح موجب.";
                case SchedulerStringId.MenuCmd_SwitchToTimelineView:
                    return "آند طريقة عرض الخط الزمني";
                case SchedulerStringId.MenuCmd_SwitchToAgendaView:
                    return "آند عرض جدول الأعمال";
                case SchedulerStringId.PrintTriFoldOptControlDailyCalendar:
                    return "تقويم يومي";
                case SchedulerStringId.MenuCmd_EditSeries:
                    return "آند تحرير سلسلة";
                case SchedulerStringId.AppointmentLabel_Important:
                    return "هام";
                case SchedulerStringId.Abbr_Hours:
                    return "ساعات";
                case SchedulerStringId.Caption_GroupByResourceDescription:
                    return "مجموعة تعيينات الموارد.";
                case SchedulerStringId.MenuCmd_OpenAppointment:
                    return "آند فتح";
                case SchedulerStringId.MenuCmd_EditAppointmentDependency:
                    return "آند تحرير";
                case SchedulerStringId.Msg_InvalidOccurrencesCountValue:
                    return "عدد تكرارات غير صالحة. الرجاء إدخال عدد صحيح موجب.";
                case SchedulerStringId.MenuCmd_SwitchToFullWeekView:
                    return "آند عرض أسبوع كامل";
                case SchedulerStringId.MenuCmd_SwitchToGroupByNone:
                    return "آند مجموعة من لا شيء";
                case SchedulerStringId.MenuCmd_RestoreOccurrence:
                    return "آند استعادة الحالة الافتراضية";
                case SchedulerStringId.PrintTriFoldOptControlWeeklyCalendar:
                    return "تقويم أسبوعي";
                case SchedulerStringId.AppointmentLabel_Business:
                    return "الأعمال التجارية";
                case SchedulerStringId.Abbr_DaysShort:
                    return "د";
                case SchedulerStringId.DescCmd_OpenAppointment:
                    return "افتح الموعد المحدد.";
                case SchedulerStringId.DescCmd_EditAppointmentDependency:
                    return "تحرير تعيين تبعية.";
                case SchedulerStringId.MenuCmd_TimeScaleDay:
                    return "آند اليوم";
                case SchedulerStringId.MenuCmd_SwitchToGroupByResource:
                    return "آند مجموعة من الموارد";
                case SchedulerStringId.Msg_InvalidDayNumber:
                    return "رقم غير صالح اليوم. الرجاء إدخال قيمة عدد صحيح من 1 إلى {0}.";
                case SchedulerStringId.MenuCmd_NewAppointment:
                    return "جديد التطبيق آند مرهم";
                case SchedulerStringId.PrintTriFoldOptControlMonthlyCalendar:
                    return "تقويم شهري";
                case SchedulerStringId.AppointmentLabel_Personal:
                    return "شخصية";
                case SchedulerStringId.Msg_iCalendar_AppointmentsImportWarning:
                    return "لا يمكن استيراد بعض التعيين";
                case SchedulerStringId.Abbr_Day:
                    return "اليوم";
                case SchedulerStringId.MenuCmd_PrintAppointment:
                    return "آند طباعة";
                case SchedulerStringId.MenuCmd_DeleteAppointmentDependency:
                    return "آند حذف";
                case SchedulerStringId.MenuCmd_TimeScaleWeek:
                    return "آند الأسبوع";
                case SchedulerStringId.Msg_InvalidDayNumberValue:
                    return "رقم غير صالح اليوم. الرجاء إدخال قيمة عدد صحيح من 1 إلى {0}.";
                case SchedulerStringId.MenuCmd_SwitchToGroupByDate:
                    return "آند مجموعة حسب التاريخ";
                case SchedulerStringId.PrintWeeklyOptControlOneWeekPerPage:
                    return "الأسبوع الصفحة 1";
                case SchedulerStringId.DescCmd_NewAppointment:
                    return "إنشاء موعد جديد.";
                case SchedulerStringId.AppointmentLabel_Vacation:
                    return "عطلة";
                case SchedulerStringId.MenuCmd_NavigateBackward:
                    return "إلى الخلف";
                case SchedulerStringId.MenuCmd_DeleteAppointment:
                    return "آند حذف";
                case SchedulerStringId.MenuCmd_TimeScaleMonth:
                    return "آند الشهر";
                case SchedulerStringId.Abbr_Days:
                    return "أيام";
                case SchedulerStringId.DescCmd_DeleteAppointmentDependency:
                    return "حذف تعيين تبعية.";
                case SchedulerStringId.Abbr_Months:
                    return "أشهر";
                case SchedulerStringId.MenuCmd_SwitchToGanttView:
                    return "آند طريقة عرض جانت";
                case SchedulerStringId.PrintWeeklyOptControlTwoWeekPerPage:
                    return "2 صفحات/الأسبوع";
                case SchedulerStringId.MenuCmd_NavigateForward:
                    return "إلى الأمام";
                case SchedulerStringId.Msg_WarningDayNumber:
                    return "بعض أشهر لديها عدد أقل من الأيام {0}. لهذين الشهرين، سوف تقع الحوادث في اليوم الأخير من الشهر.";
                case SchedulerStringId.MenuCmd_NewAllDayEvent:
                    return "جديدة كل يوم آند الحدث";
                case SchedulerStringId.AppointmentLabel_MustAttend:
                    return "ويجب أن يحضر";
                case SchedulerStringId.DescCmd_DeleteAppointment:
                    return "حذف الموعد المحدد.";
                case SchedulerStringId.MenuCmd_TimeScaleQuarter:
                    return "آند الربع";
                case SchedulerStringId.MenuCmd_TimeScalesMenu:
                    return "آند المقاييس الزمنية";
                case SchedulerStringId.Abbr_WeeksShort:
                    return "w";
                case SchedulerStringId.PrintPageSetupFormCaption:
                    return "خيارات الطباعة: {0}";
                case SchedulerStringId.MenuCmd_GotoThisDay:
                    return "الذهاب إلى هذا آند اليوم";
                case SchedulerStringId.Abbr_Year:
                    return "السنة";
                case SchedulerStringId.MenuCmd_OtherSettings:
                    return "ضبط & تحديد أخرى...";
                case SchedulerStringId.DescCmd_NavigateBackward:
                    return "خطوة إلى الوراء في الوقت المناسب كما اقترح طريقة العرض الحالية.";
                case SchedulerStringId.MenuCmd_TimeScaleYear:
                    return "آند العام";
                case SchedulerStringId.MenuCmd_AppointmentLabelTravelRequired:
                    return "آند السفر المطلوبة";
                case SchedulerStringId.MenuCmd_NewRecurringAppointment:
                    return "جديد متكرر & التعيين";
                case SchedulerStringId.AppointmentLabel_TravelRequired:
                    return "السفر المطلوبة";
                case SchedulerStringId.Abbr_Week:
                    return "الأسبوع";
                case SchedulerStringId.MenuCmd_TimeScaleCaptionsMenu:
                    return "مقياس الوقت & التسميات التوضيحية";
                case SchedulerStringId.PrintMoreItemsMsg:
                    return "المزيد من العناصر...";
                case SchedulerStringId.MenuCmd_GotoToday:
                    return "اذهب إلى آند اليوم";
                case SchedulerStringId.Abbr_Years:
                    return "السنوات";
                case SchedulerStringId.MenuCmd_CustomizeCurrentView:
                    return "آند تخصيص طريقة العرض الحالية...";
                case SchedulerStringId.DescCmd_NavigateForward:
                    return "المضي قدما إلى الأمام في الوقت المناسب كما اقترح طريقة العرض الحالية.";
                case SchedulerStringId.DescCmd_NewRecurringAppointment:
                    return "إنشاء موعد متكرر جديد.";
                case SchedulerStringId.MenuCmd_ShowTimeAs:
                    return "آند إظهار الوقت ك";
                case SchedulerStringId.AppointmentLabel_NeedsPreparation:
                    return "يحتاج إعداد";
                case SchedulerStringId.Abbr_Weeks:
                    return "أسابيع";
                case SchedulerStringId.MenuCmd_AppointmentLabelNeedsPreparation:
                    return "آند يحتاج إلى إعداد";
                case SchedulerStringId.Caption_FirstVisibleResources:
                    return "الأولى";
                case SchedulerStringId.MenuCmd_TimeScaleHour:
                    return "آند ساعة";
                case SchedulerStringId.PrintNoPrintersInstalled:
                    return "لا توجد طابعات مثبتة";
                case SchedulerStringId.MenuCmd_ViewZoomIn:
                    return "تكبير";
                case SchedulerStringId.DescCmd_ShowTimeAs:
                    return "لتغيير حالة الموعد المحدد.";
                case SchedulerStringId.MenuCmd_AppointmentLabelBirthday:
                    return "آند أعياد ميلاد";
                case SchedulerStringId.DescCmd_GotoToday:
                    return "قم بتغيير تاريخ عرضه في طريقة العرض الحالية إلى التاريخ الحالي.";
                case SchedulerStringId.Caption_Reminder:
                    return "{0} تذكير";
                case SchedulerStringId.MenuCmd_CustomizeTimeRuler:
                    return "تخصيص الوقت المسطرة...";
                case SchedulerStringId.Caption_PrevVisibleResourcesPage:
                    return "الصفحة السابقة";
                case SchedulerStringId.Caption_5Minutes:
                    return "بعد 5 دقائق";
                case SchedulerStringId.Caption_NextVisibleResources:
                    return "القادم";
                case SchedulerStringId.MenuCmd_NewRecurringEvent:
                    return "جديد متكرر ه & تنفيس";
                case SchedulerStringId.AppointmentLabel_Birthday:
                    return "عيد ميلاد";
                case SchedulerStringId.Abbr_Month:
                    return "في الشهر";
                case SchedulerStringId.MenuCmd_ViewZoomOut:
                    return "التصغير";
                case SchedulerStringId.MenuCmd_Free:
                    return "آند الحرة";
                case SchedulerStringId.MenuCmd_AppointmentLabelAnniversary:
                    return "آند الذكرى";
                case SchedulerStringId.Caption_PrevVisibleResources:
                    return "السابقة";
                case SchedulerStringId.MenuCmd_GotoDate:
                    return "آند الانتقال إلى تاريخ...";
                case SchedulerStringId.Caption_Reminders:
                    return "{0} رسائل تذكيرية";
                case SchedulerStringId.MenuCmd_5Minutes:
                    return "آند 5 دقائق";
                case SchedulerStringId.Caption_6Minutes:
                    return "6 دقائق";
                case SchedulerStringId.Caption_NextVisibleResourcesPage:
                    return "الصفحة التالية";
                case SchedulerStringId.ViewDisplayName_Timeline:
                    return "التقويم الزمني";
                case SchedulerStringId.TimeScaleDisplayName_Quarter:
                    return "الربع";
                case SchedulerStringId.Format_TimeBeforeStart:
                    return "{0} قبل البدء";
                case SchedulerStringId.DescCmd_ViewZoomIn:
                    return "القيام برفع مستوى لعرض المحتوى بمزيد من التفصيل.";
                case SchedulerStringId.MenuCmd_Busy:
                    return "آند مشغول";
                case SchedulerStringId.TextWeekly_2Day:
                    return "{0} و {1}";
                case SchedulerStringId.Caption_StartTime:
                    return "وقت البدء: {0}";
                case SchedulerStringId.MenuCmd_AppointmentLabelPhoneCall:
                    return "مكالمة هاتفية &";
                case SchedulerStringId.MenuCmd_6Minutes:
                    return "آند 6 دقائق";
                case SchedulerStringId.Caption_OnScreenResources:
                    return "الموارد التي تظهر على الشاشة";
                case SchedulerStringId.Caption_10Minutes:
                    return "10 دقائق";
                case SchedulerStringId.Caption_LastVisibleResources:
                    return "آخر";
                case SchedulerStringId.ViewDisplayName_FullWeek:
                    return "تقويم أسبوع كامل";
                case SchedulerStringId.Caption_PleaseSeeAbove:
                    return "الرجاء انظر أعلاه";
                case SchedulerStringId.DescCmd_ViewZoomOut:
                    return "إجراء تقليص لعرض نظرة أوسع نطاقا من طريقة العرض.";
                case SchedulerStringId.MenuCmd_Tentative:
                    return "آند مؤقت";
                case SchedulerStringId.MenuCmd_AppointmentMove:
                    return "مو آند ve";
                case SchedulerStringId.Msg_Conflict:
                    return "تعيين محرر يتعارض مع واحد أو عدة تعيينات أخرى.";
                case SchedulerStringId.TextWeekly_3Day:
                    return "{0} و {1} و {2}";
                case SchedulerStringId.Caption_NAppointmentsAreSelected:
                    return "يتم تحديد المواعيد {0}";
                case SchedulerStringId.Caption_GroupByNone:
                    return "لا شيء";
                case SchedulerStringId.Caption_15Minutes:
                    return "مدة 15 دقيقة";
                case SchedulerStringId.Caption_IncreaseVisibleResourcesCount:
                    return "زيادة عدد الموارد مرئية";
                case SchedulerStringId.MenuCmd_10Minutes:
                    return "10 آند دقيقة";
                case SchedulerStringId.ViewDisplayName_Gantt:
                    return "طريقة عرض جانت";
                case SchedulerStringId.Caption_RecurrenceSubject:
                    return "الموضوع:";
                case SchedulerStringId.DescCmd_SplitAppointment:
                    return "تقسيم الموعد المحدد في اثنين بواسطة سحب خط تقسيم.";
                case SchedulerStringId.TextAppointmentSnapToCells_Always:
                    return "دائماً";
                case SchedulerStringId.MenuCmd_OutOfOffice:
                    return "آند خارج المكتب";
                case SchedulerStringId.MenuCmd_AppointmentCopy:
                    return "آند نسخة";
                case SchedulerStringId.Msg_InvalidAppointmentDuration:
                    return "تحديد مدة الفاصل الزمني لقيمة غير صالحة. الرجاء إدخال قيمة إيجابية.";
                case SchedulerStringId.TextWeekly_4Day:
                    return "{0} {1}، {2} و {3}";
                case SchedulerStringId.Caption_GroupByDate:
                    return "تاريخ";
                case SchedulerStringId.Caption_20Minutes:
                    return "20 دقيقة";
                case SchedulerStringId.Caption_MemoPrintStyle:
                    return "نمط المذكرة";
                case SchedulerStringId.Caption_DecreaseVisibleResourcesCount:
                    return "إنقاص عدد الموارد مرئية";
                case SchedulerStringId.MenuCmd_15Minutes:
                    return "آند 15 دقيقة";
                case SchedulerStringId.ViewDisplayName_Agenda:
                    return "جدول التقويم";
                case SchedulerStringId.Caption_SplitAppointment:
                    return "انقسام";
                case SchedulerStringId.MenuCmd_WorkingElsewhere:
                    return "آند العمل في مكان آخر";
                case SchedulerStringId.MenuCmd_AppointmentCancel:
                    return "ج & انسيل";
                case SchedulerStringId.Caption_RecurrenceLocation:
                    return "الموقع:";
                case SchedulerStringId.TextAppointmentSnapToCells_Auto:
                    return "تلقائي";
                case SchedulerStringId.Msg_InvalidReminderTimeBeforeStart:
                    return "قيمة غير صالحة قبل وقت تذكير الحدث. الرجاء إدخال قيمة إيجابية.";
                case SchedulerStringId.Caption_GroupByResources:
                    return "الموارد";
                case SchedulerStringId.Caption_30Minutes:
                    return "30 دقيقة";
                case SchedulerStringId.Caption_ShadingApplyToAllDayArea:
                    return "كل يوم المنطقة";
                case SchedulerStringId.TextWeekly_5Day:
                    return "{0} {1}، {2}، {3} و {4}";
                case SchedulerStringId.Caption_ColorConverterFullColor:
                    return "لون كامل";
                case SchedulerStringId.VS_SchedulerReportsToolboxCategoryName:
                    return "DX. {0}: جدولة التقارير";
                case SchedulerStringId.MenuCmd_LabelAs:
                    return "آند التسمية";
                case SchedulerStringId.PrintRangeControlInvalidDate:
                    return "يجب أن يكون تاريخ الانتهاء أكبر أو مساوياً لتاريخ البدء";
                case SchedulerStringId.Msg_InvalidInputFile:
                    return "ملف الإدخال غير صالح";
                case SchedulerStringId.ViewShortDisplayName_Day:
                    return "اليوم";
                case SchedulerStringId.Caption_RecurrenceStartTime:
                    return "البدء:";
                case SchedulerStringId.TextAppointmentSnapToCells_Disabled:
                    return "ذوي";
                case SchedulerStringId.TextDuration_FromTo:
                    return "من {0} إلى {1}";
                case SchedulerStringId.Msg_MissingRequiredMapping:
                    return "تعيين الخاصية '{0}' مطلوب مفقود.";
                case SchedulerStringId.Caption_60Minutes:
                    return "60 دقيقة";
                case SchedulerStringId.Caption_ShadingApplyToAppointments:
                    return "التعيينات";
                case SchedulerStringId.TextWeekly_6Day:
                    return "{0} {1}، {2}، {3}، {4} و {5}";
                case SchedulerStringId.Caption_ColorConverterGrayScale:
                    return "تدرج الرمادي";
                case SchedulerStringId.Caption_SetupResourceMappings:
                    return "إعداد تعيينات الموارد";
                case SchedulerStringId.UD_SchedulerReportsToolboxCategoryName:
                    return "جدولة عناصر التحكم";
                case SchedulerStringId.ViewShortDisplayName_WorkDays:
                    return "أسبوع العمل";
                case SchedulerStringId.DescCmd_LabelAs:
                    return "تغيير تسمية الموعد المحدد.";
                case SchedulerStringId.TextRecurrenceTypeDaily:
                    return "اليومية";
                case SchedulerStringId.Caption_RecurrenceEndTime:
                    return "نهاية:";
                case SchedulerStringId.TextAppointmentSnapToCells_Never:
                    return "ابدأ";
                case SchedulerStringId.TextDuration_FromForDays:
                    return "من {0} {1} ";
                case SchedulerStringId.Msg_MissingMappingMember:
                    return "مفقود '{1}' عضو تعيين الخاصية '{0}'.";
                case SchedulerStringId.Caption_Free:
                    return "مجاناً";
                case SchedulerStringId.Caption_ShadingApplyToAppointmentStatuses:
                    return "حالات التعيين";
                case SchedulerStringId.TextWeekly_7Day:
                    return "{0} {1}، {2}، {3}، {4}، {5} و {6}";
                case SchedulerStringId.Caption_ColorConverterBlackAndWhite:
                    return "أسود وأبيض";
                case SchedulerStringId.Caption_SetupDependencyMappings:
                    return "إعداد تعيينات التبعية";
                case SchedulerStringId.ViewShortDisplayName_Week:
                    return "الأسبوع";
                case SchedulerStringId.Reporting_NotAssigned_TimeCells:
                    return "لم يتم تعيين التحكم تيميسيلس المطلوب";
                case SchedulerStringId.MenuCmd_AppointmentLabelNone:
                    return "آند بلا";
                case SchedulerStringId.TextRecurrenceTypeWeekly:
                    return "التنزيلات";
                case SchedulerStringId.Caption_RecurrenceShowTimeAs:
                    return "إظهار الوقت بصيغة:";
                case SchedulerStringId.MenuCmd_PrintPreview:
                    return "معاينة قبل الطباعة &";
                case SchedulerStringId.TextDuration_FromForDaysHours:
                    return "من {0} ل {1} {2}";
                case SchedulerStringId.Msg_DuplicateMappingMember:
                    return "العضو '{0}' رسم الخرائط ليست فريدة من نوعها:";
                case SchedulerStringId.Caption_Busy:
                    return "مشغول";
                case SchedulerStringId.Caption_ShadingApplyToHeaders:
                    return "رؤوس";
                case SchedulerStringId.TextWeeklyPatternString_EveryWeek:
                    return "كل {3} {0}";
                case SchedulerStringId.Caption_ResourceNone:
                    return "(بلا)";
                case SchedulerStringId.Caption_ModifyAppointmentMappingsTransactionDescription:
                    return "تعديل تعيين تعيينات";
                case SchedulerStringId.Reporting_NotAssigned_View:
                    return "لم يتم تعيين المكون العرض المطلوب";
                case SchedulerStringId.Caption_WeekViewDescription:
                    return "قم بالتبديل إلى طريقة عرض الأسبوع. ترتيب مواعيد لأسبوع معين في نموذج مضغوط.";
                case SchedulerStringId.ViewShortDisplayName_Month:
                    return "في الشهر";
                case SchedulerStringId.MenuCmd_AppointmentLabelImportant:
                    return "آند هامة";
                case SchedulerStringId.Caption_Recurrence:
                    return "التكرار:";
                case SchedulerStringId.DescCmd_PrintPreview:
                    return "معاينة وإجراء التغييرات على الصفحات قبل الطباعة.";
                case SchedulerStringId.TextRecurrenceTypeMonthly:
                    return "الشهري";
                case SchedulerStringId.TextDuration_FromForDaysMinutes:
                    return "من {0} ل {1} {3}";
                case SchedulerStringId.Msg_InconsistentRecurrenceInfoMapping:
                    return "ولدعم تكرار يجب عليك تعيين كلا من ريكورينسينفو ونوع الأعضاء.";
                case SchedulerStringId.Caption_Tentative:
                    return "مؤقت";
                case SchedulerStringId.TextWeeklyPatternString_EveryWeeks:
                    return "كل {1} {2} على {3} {0}";
                case SchedulerStringId.Caption_ResourceAll:
                    return "(الكل)";
                case SchedulerStringId.Caption_ShadingApplyToTimeRulers:
                    return "حكام الوقت";
                case SchedulerStringId.Caption_ModifyResourceMappingsTransactionDescription:
                    return "تعديل تعيينات الموارد";
                case SchedulerStringId.ViewShortDisplayName_Timeline:
                    return "الجدول الزمني";
                case SchedulerStringId.Caption_RecurrencePattern:
                    return "نمط التكرار:";
                case SchedulerStringId.Msg_RecurrenceExceptionsWillBeLost:
                    return "ستفقد أية استثناءات مقترنة بهذا الموعد المتكرر. هل تريد المتابعة؟";
                case SchedulerStringId.MenuCmd_Print:
                    return "طباعة سريعة";
                case SchedulerStringId.DescCmd_Print:
                    return "إرسال الجدول الزمني مباشرة إلى الطابعة الافتراضية دون إجراء تغييرات.";
                case SchedulerStringId.TextDuration_FromForDaysHoursMinutes:
                    return "من {0} ل {1} {2} {3}";
                case SchedulerStringId.MenuCmd_AppointmentLabelBusiness:
                    return "آند الأعمال";
                case SchedulerStringId.TextMonthlyPatternString_SubPattern:
                    return "لكل {0} {1} {2}";
                case SchedulerStringId.TextRecurrenceTypeYearly:
                    return "سنوياً";
                case SchedulerStringId.PrintPageSetupFormatTabControlCustomizeShading:
                    return "<Customize...></Customize...>";
                case SchedulerStringId.Caption_WorkingElsewhere:
                    return "العمل في مكان آخر";
                case SchedulerStringId.Caption_ModifyAppointmentDependencyMappingsTransactionDescription:
                    return "تعديل تعيين تبعية تعيينات";
                case SchedulerStringId.ViewShortDisplayName_FullWeek:
                    return "أسبوع كامل";
                case SchedulerStringId.Msg_MappingsCheckPassedOk:
                    return "التعيينات الصحيحة!";
                case SchedulerStringId.Caption_ShadingApplyToCells:
                    return "الخلايا";
                case SchedulerStringId.Caption_NoneRecurrence:
                    return "(بلا)";
                case SchedulerStringId.DescCmd_CreateAppointmentDependency:
                    return "إنشاء تبعية بين المواعيد";
                case SchedulerStringId.MenuCmd_PrintPageSetup:
                    return "إعداد الصفحة &";
                case SchedulerStringId.DescCmd_PrintPageSetup:
                    return "تخصيص مظهر الصفحة وتكوين خيارات الطباعة المختلفة.";
                case SchedulerStringId.MenuCmd_AppointmentLabelPersonal:
                    return "آند الشخصية";
                case SchedulerStringId.DescCmd_TimeScalesMenu:
                    return "تغيير مقياس الوقت.";
                case SchedulerStringId.TextDuration_ForPattern:
                    return "{0} {1}";
                case SchedulerStringId.TextRecurrenceTypeMinutely:
                    return "دقة";
                case SchedulerStringId.Caption_OutOfOffice:
                    return "خارج المكتب";
                case SchedulerStringId.TextMonthlyPatternString1:
                    return "يوم {3} {0}";
                case SchedulerStringId.PrintPageSetupFormatTabControlSizeAndFontName:
                    return "بنط {0} {1}";
                case SchedulerStringId.Caption_SetupAppointmentMappings:
                    return "الإعداد تعيين تعيينات";
                case SchedulerStringId.Caption_MappingsValidation:
                    return "التحقق من صحة التعيينات";
                case SchedulerStringId.ViewShortDisplayName_Gantt:
                    return "مخطط جانت";
                case SchedulerStringId.MemoPrintDateFormat:
                    return "{0} {1} {2}";
                case SchedulerStringId.Msg_InvalidSize:
                    return "المحدد للحجم قيمة غير صالحة.";
                case SchedulerStringId.MenuCmd_CreateAppointmentDependency:
                    return "إنشاء تبعية";
                case SchedulerStringId.DescCmd_ToggleRecurrence:
                    return "تكرار الموعد المحدد، أو تحرير نمط التكرار.";
                case SchedulerStringId.DescCmd_ChangeTimelineScaleWidth:
                    return "تعيين عرض العمود بالبكسل لجدول المرتبات الأساسية.";
                case SchedulerStringId.MenuCmd_AppointmentLabelVacation:
                    return "آند عطلة";
                case SchedulerStringId.TextRecurrenceTypeHourly:
                    return "كل ساعة";
                case SchedulerStringId.MenuCmd_ShowWorkTimeOnly:
                    return "ساعات العمل";
                case SchedulerStringId.TextDailyPatternString_EveryDay:
                    return "كل {0} {1}";
                case SchedulerStringId.ViewDisplayName_Day:
                    return "يوم التقويم";
                case SchedulerStringId.TextMonthlyPatternString2:
                    return "{1} {2} {0}";
                case SchedulerStringId.MenuCmd_OpenSchedule:
                    return "فتح";
                case SchedulerStringId.Caption_MappingsWizard:
                    return "تعيينات معالج...";
                case SchedulerStringId.Msg_SaveBeforeClose:
                    return "هل تريد حفظ التغييرات التي أجريتها؟";
                case SchedulerStringId.Msg_ApplyToAllStyles:
                    return "تنطبق إعدادات الطابعة الحالية على كافة الأنماط؟";
                case SchedulerStringId.ViewShortDisplayName_Agenda:
                    return "جدول الأعمال";
                case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToStart:
                    return "انتهاء-إلى-بدء (خ)";
                case SchedulerStringId.Caption_EmptyResource:
                    return "(أي)";
                case SchedulerStringId.MenuCmd_ChangeTimelineScaleWidth:
                    return "عرض الجدول";
                case SchedulerStringId.MenuCmd_ChangeAppointmentReminderUI:
                    return "تذكير";
                case SchedulerStringId.MenuCmd_AppointmentLabelMustAttend:
                    return "يجب أن آند حضور";
                case SchedulerStringId.Msg_Warning:
                    return "تحذير!";
                case SchedulerStringId.DescCmd_ShowWorkTimeOnly:
                    return "إظهار ساعات العمل فقط في التقويم.";
                case SchedulerStringId.TextDailyPatternString_EveryDays:
                    return "كل {0} {1} {2}";
                case SchedulerStringId.TextYearlyPattern_YearString1:
                    return "كل {3} {4} {0}";
                case SchedulerStringId.ViewDisplayName_WorkDays:
                    return "تقويم أسبوع العمل";
                case SchedulerStringId.String_to:
                    return "إلى";
                case SchedulerStringId.DescCmd_OpenSchedule:
                    return "استيراد جدول من ملف (.ics).";
                case SchedulerStringId.Caption_CheckMappings:
                    return "تعيينات الاختيار";
                case SchedulerStringId.Msg_MemoPrintNoSelectedItems:
                    return "لا يمكن طباعة ما لم يتم تحديد عنصر. تحديد عنصر، ومن ثم حاول الطباعة مرة أخرى.";
                case SchedulerStringId.TimeScaleDisplayName_Hour:
                    return "ساعة";
                case SchedulerStringId.Caption_AppointmentDependencyTypeStartToStart:
                    return "بدء-إلى-بدء (SS)";
                case SchedulerStringId.DescCmd_ChangeAppointmentReminderUI:
                    return "اختيار متى يتم تذكيرك الموعد المحدد.";
                case SchedulerStringId.Caption_DailyPrintStyle:
                    return "نمط يومي";
                case SchedulerStringId.MenuCmd_CompressWeekend:
                    return "ضغط في نهاية الأسبوع";
                case SchedulerStringId.TextDailyPatternString_EveryWeekDay:
                    return "كل يوم من أيام الأسبوع {0}";
                case SchedulerStringId.Msg_CantFitIntoPage:
                    return "من المستحيل أن تناسب إخراج الطباعة باستخدام الإعدادات الحالية لطباعة صفحة واحدة. الرجاء محاولة زيادة ارتفاع الصفحة أو تقليل الفاصل الزمني برينتيمي.";
                case SchedulerStringId.ViewDisplayName_Week:
                    return "تقويم أسبوع";
                case SchedulerStringId.MenuCmd_SaveSchedule:
                    return "حفظ";
                case SchedulerStringId.TextYearlyPattern_YearString2:
                    return "{6} {5} {3} {0}";
                case SchedulerStringId.Caption_SetupAppointmentStorage:
                    return "الإعداد تعيين مخزن";
                case SchedulerStringId.TimeScaleDisplayName_Day:
                    return "اليوم";
                case SchedulerStringId.Caption_AllResources:
                    return "جميع الموارد";
                case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToFinish:
                    return "انتهاء-إلى-انتهاء (FF)";
                case SchedulerStringId.Caption_NoneReminder:
                    return "لا شيء";
                case SchedulerStringId.Caption_WeeklyPrintStyle:
                    return "نمط أسبوعي";
                case SchedulerStringId.DescCmd_CompressWeekend:
                    return "إظهار يومي السبت والأحد مضغوطة في عمود واحد.";
                case SchedulerStringId.TextDailyPatternString_EveryWeekend:
                    return "كل نهاية الأسبوع {0}";
                case SchedulerStringId.Msg_PrintStyleNameExists:
                    return "اسم النمط '{0}' موجود بالفعل. اكتب اسماً آخر.";
                case SchedulerStringId.ViewDisplayName_Month:
                    return "تقويم الشهر";
                case SchedulerStringId.TextYearlyPattern_YearsString1:
                    return "{4} {3} من كل {0} {1} {2}";
                case SchedulerStringId.DescCmd_SaveSchedule:
                    return "حفظ جدول إلى ملف (.ics).";
                case SchedulerStringId.Caption_VisibleResources:
                    return "الموارد مرئية";
                case SchedulerStringId.Caption_SetupResourceStorage:
                    return "إعداد مورد تخزين";
                case SchedulerStringId.TimeScaleDisplayName_Week:
                    return "الأسبوع";
                case SchedulerStringId.Caption_AppointmentDependencyTypeStartToFinish:
                    return "بدء-إلى-انتهاء (SF)";
                case SchedulerStringId.Caption_MonthlyPrintStyle:
                    return "نمط شهري";
                case SchedulerStringId.Msg_OutlookCalendarNotFound:
                    return "لم يتم العثور على التقويم '{0}'.";
                case SchedulerStringId.TextYearlyPattern_YearsString2:
                    return "{6} {5} من {3} كل {0} {1} {2}";
                case SchedulerStringId.MenuCmd_ChangeSnapToCellsUI:
                    return "انجذاب إلى الخلايا";
                case SchedulerStringId.MenuCmd_CellsAutoHeight:
                    return "ارتفاع السيارات الخلية";
                case SchedulerStringId.Caption_TrifoldPrintStyle:
                    return "نمط ثلاثي إضعاف";
                case SchedulerStringId.TextWeekly_0Day:
                    return "يوم غير محدد في الأسبوع";
                case SchedulerStringId.Caption_PrevAppointment:
                    return "الموعد السابق";
                case SchedulerStringId.Caption_SetupAppointmentDependencyStorage:
                    return "إعداد تبعية التخزين";
                case SchedulerStringId.Caption_AllDay:
                    return "كل يوم";
                case SchedulerStringId.TimeScaleDisplayName_Month:
                    return "في الشهر";
                case SchedulerStringId.DescCmd_ChangeSnapToCellsUI:
                    return "تحديد وضع أطباق لعرض التعيينات داخل خلايا الوقت.";
                case SchedulerStringId.Caption_CalendarDetailsPrintStyle:
                    return "نمط تفاصيل التقويم";
                case SchedulerStringId.Caption_NextAppointment:
                    return "الموعد التالي";
                case SchedulerStringId.DescCmd_CellsAutoHeight:
                    return "تمكين خلية وقت تلقائياً ضبط حجمه لاستيعاب المواعيد يحتوي على.";
                case SchedulerStringId.TextWeekly_1Day:
                    return "{0}";
                case SchedulerStringId.Caption_ModifyAppointmentStorageTransactionDescription:
                    return "تعديل تعيين مخزن";
                case SchedulerStringId.MenuCmd_OpenOccurrence:
                    return "حدوث مفتوحة";
                case SchedulerStringId.MenuCmd_ToggleRecurrence:
                    return "تكرار";
                case SchedulerStringId.DisplayName_Appointment:
                    return "تعيين";
                case SchedulerStringId.Caption_ModifyResourceStorageTransactionDescription:
                    return "تعديل مخزن الموارد";
                case SchedulerStringId.DescCmd_OpenOccurrence:
                    return "فتح هذا التكرار الاجتماع.";
                case SchedulerStringId.Format_CopyOf:
                    return "نسخ {0}";
                case SchedulerStringId.MenuCmd_OpenSeries:
                    return "سلسلة مفتوحة";
                case SchedulerStringId.Caption_ModifyAppointmentDependencyStorageTransactionDescription:
                    return "تعديل مخزن أبوينتمينتديبيندينسي";
                case SchedulerStringId.DescCmd_OpenSeries:
                    return "وهذا فتح سلسلة الاجتماعات.";
                case SchedulerStringId.Format_CopyNOf:
                    return "نسخة ({0}) {1}";
                case SchedulerStringId.MenuCmd_DeleteOccurrence:
                    return "حذف التكرار";
                case SchedulerStringId.Caption_DayViewDescription:
                    return "قم بالتبديل إلى طريقة عرض اليوم. العرض الأكثر تفصيلاً التعيينات أيام محددة.";
                case SchedulerStringId.DescCmd_DeleteOccurrence:
                    return "حذف التكرار.";
                case SchedulerStringId.MenuCmd_DeleteSeries:
                    return "حذف السلسلة";
                case SchedulerStringId.DescCmd_DeleteSeries:
                    return "حذف سلسلة.";
                default:
                    return base.GetLocalizedString(id);
            }

        }
    }
    public class HebrewSchedulerLocalizer : SchedulerLocalizer {
        public override string GetLocalizedString(SchedulerStringId id) {
            switch (id) {
                case SchedulerStringId.AppointmentLabel_Anniversary:
                    return "יום השנה";
                case SchedulerStringId.Msg_IsNotValid:
                    return "'{0}' אינו ערך חוקי עבור '{1}'";
                case SchedulerStringId.Caption_MonthViewDescription:
                    return "החלפה לתצוגה חודש (רב-שבועי). תצוגת לוח התאריכים שימושי עבור תוכניות ארוכות טווח.";
                case SchedulerStringId.MenuCmd_20Minutes:
                    return "& 20 דקות";
                case SchedulerStringId.TimeScaleDisplayName_Year:
                    return "השנה";
                case SchedulerStringId.Appointment_StartContinueText:
                    return "מ- {0}";
                case SchedulerStringId.AppointmentLabel_PhoneCall:
                    return "שיחת טלפון";
                case SchedulerStringId.Appointment_EndContinueText:
                    return "{0}";
                case SchedulerStringId.Caption_TimelineViewDescription:
                    return "לעבור תצוגת ציר הזמן. חלקות פגישות ביחס לזמן.";
                case SchedulerStringId.Msg_InvalidDayOfWeekForDailyRecurrence:
                    return "לא חוקי יום בשבוע להישנות מדי יום. רק WeekDays.EveryDay, WeekDays.WeekendDays, WeekDays.WorkDays תקפים בהקשר זה.";
                case SchedulerStringId.DefaultToolTipStringFormat_SplitAppointment:
                    return "{0}: צעד {1}";
                case SchedulerStringId.PrintCalendarDetailsControlDayPeriod:
                    return "היום";
                case SchedulerStringId.MenuCmd_30Minutes:
                    return "& 30 דקות";
                case SchedulerStringId.Abbr_MinutesShort1:
                    return "m";
                case SchedulerStringId.Msg_InvalidWeekCountValue:
                    return "ספירת שבוע לא חוקי. נא הזן ערך מספר שלם חיובי.";
                case SchedulerStringId.Msg_InvalidDayCountValue:
                    return "ספירת היום לא חוקי. נא הזן ערך מספר שלם חיובי.";
                case SchedulerStringId.Msg_InternalError:
                    return "שגיאה פנימית!";
                case SchedulerStringId.Msg_InvalidYearCountValue:
                    return "ספירת בן לא חוקי. נא הזן ערך מספר שלם חיובי.";
                case SchedulerStringId.Msg_InvalidEndDate:
                    return "התאריך שהזנת מתרחש לפני תאריך ההתחלה.";
                case SchedulerStringId.Caption_FullWeekViewDescription:
                    return "החלפה לתצוגה שבוע מלא. סידור פגישות לשבוע מסוים בצורה קומפקטית.";
                case SchedulerStringId.MenuCmd_60Minutes:
                    return "6 & 10 דקות";
                case SchedulerStringId.PrintCalendarDetailsControlWeekPeriod:
                    return "השבוע";
                case SchedulerStringId.Msg_InvalidWeekCount:
                    return "ספירת שבוע לא חוקי. נא הזן ערך מספר שלם חיובי.";
                case SchedulerStringId.Msg_XtraSchedulerNotAssigned:
                    return "הרכיב SchedulerStorage לא הוקצו את SchedulerControl";
                case SchedulerStringId.Abbr_MinutesShort2:
                    return "min";
                case SchedulerStringId.Msg_InvalidMonthCount:
                    return "לספור חודש לא חוקי. נא הזן ערך מספר שלם חיובי.";
                case SchedulerStringId.Caption_Appointment:
                    return "{0} - פעילות";
                case SchedulerStringId.Msg_InvalidOccurrencesCount:
                    return "ספירת מופעים לא חוקי. נא הזן ערך מספר שלם חיובי.";
                case SchedulerStringId.PrintCalendarDetailsControlMonthPeriod:
                    return "חודש";
                case SchedulerStringId.Msg_InvalidOccurrencesCountValue:
                    return "ספירת מופעים לא חוקי. נא הזן ערך מספר שלם חיובי.";
                case SchedulerStringId.Caption_GanttViewDescription:
                    return "לעבור בתצוגה ' גנט '. ניהול פרויקט תצוגה המציג פגישות והתלויות ביחס לזמן.";
                case SchedulerStringId.MenuCmd_SwitchViewMenu:
                    return "לשנות את התצוגה כך";
                case SchedulerStringId.Msg_InvalidTimeOfDayInterval:
                    return "לא חוקי משך TimeOfDayInterval";
                case SchedulerStringId.Abbr_Minute:
                    return "דקה";
                case SchedulerStringId.Msg_InvalidDayOfWeek:
                    return "אין היום הנבחר. נא בחר לפחות יום אחד בשבוע.";
                case SchedulerStringId.Msg_InvalidMonthCountValue:
                    return "לספור חודש לא חוקי. נא הזן ערך מספר שלם חיובי.";
                case SchedulerStringId.Caption_Event:
                    return "{0} - אירוע";
                case SchedulerStringId.Msg_InvalidDayNumber:
                    return "מספר יום לא חוקי. נא הזן ערך של מספר שלם בין 1 ל {0}.";
                case SchedulerStringId.Caption_AgendaViewDescription:
                    return "עבור לתצוגת סדר היום. מציג רשימה של אירועים עתידיים";
                case SchedulerStringId.PrintMonthlyOptControlOnePagePerMonth:
                    return "1 עמוד לחודש";
                case SchedulerStringId.Msg_OverflowTimeOfDayInterval:
                    return "ערך לא חוקי עבור TimeOfDayInterval. צריך להיות קטן או שווה ליום";
                case SchedulerStringId.MenuCmd_SwitchToDayView:
                    return "& תצוגת ' יום '";
                case SchedulerStringId.Abbr_Minutes:
                    return "דקות";
                case SchedulerStringId.Msg_WarningAppointmentDeleted:
                    return "הפעילות נמחק על-ידי משתמש אחר.";
                case SchedulerStringId.Msg_InvalidDayNumberValue:
                    return "מספר יום לא חוקי. נא הזן ערך של מספר שלם בין 1 ל {0}.";
                case SchedulerStringId.Msg_InvalidYearCount:
                    return "ספירת בן לא חוקי. נא הזן ערך מספר שלם חיובי.";
                case SchedulerStringId.PrintMonthlyOptControlTwoPagesPerMonth:
                    return "2 עמודים לחודש";
                case SchedulerStringId.Caption_UntitledAppointment:
                    return "ללא כותרת";
                case SchedulerStringId.Caption_GroupByNoneDescription:
                    return "ביטול קיבוץ של פעילויות.";
                case SchedulerStringId.MenuCmd_SwitchToWorkWeekView:
                    return "Wo & rk תצוגת שבוע";
                case SchedulerStringId.Msg_LoadCollectionFromXml:
                    return "מתזמן המשימות צריך להיות במצב לא מאוגדת כדי לטעון את אוסף הפריטים מ- xml";
                case SchedulerStringId.MenuCmd_OpenAppointment:
                    return "& פתוח";
                case SchedulerStringId.Abbr_HoursShort:
                    return "h";
                case SchedulerStringId.DescCmd_OpenAppointment:
                    return "פתח את הפעילות שנבחרה.";
                case SchedulerStringId.Msg_WarningDayNumber:
                    return "כמה חודשים יש פחות מ- {0} ימים. חודשים אלה, המופעים תיפול ביום האחרון של החודש.";
                case SchedulerStringId.Caption_ReadOnly:
                    return "[לקריאה בלבד]";
                case SchedulerStringId.PrintTimeIntervalControlInvalidDuration:
                    return "המשך להיות לא גדול יותר יום יותר מ 0";
                case SchedulerStringId.AppointmentLabel_None:
                    return "אף אחד";
                case SchedulerStringId.Caption_GroupByDateDescription:
                    return "פגישות הקבוצה לפי תאריך.";
                case SchedulerStringId.MenuCmd_SwitchToWeekView:
                    return "& תצוגת שבוע";
                case SchedulerStringId.Abbr_Hour:
                    return "שעה";
                case SchedulerStringId.MenuCmd_NewAllDayEvent:
                    return "חדש כל יום & האירוע";
                case SchedulerStringId.MenuCmd_GotoThisDay:
                    return ". לך זה & היום";
                case SchedulerStringId.PrintTimeIntervalControlInvalidStartEndTime:
                    return "שעת סיום חייב להיות גדול יותר זמן ההתחלה";
                case SchedulerStringId.MenuCmd_PrintAppointment:
                    return "& הדפסה";
                case SchedulerStringId.Caption_WeekDaysEveryDay:
                    return "היום";
                case SchedulerStringId.Caption_GroupByResourceDescription:
                    return "פגישות הקבוצה על-ידי משאב.";
                case SchedulerStringId.AppointmentLabel_Important:
                    return "חשוב";
                case SchedulerStringId.MenuCmd_NewRecurringAppointment:
                    return "חוזרת חדשה & תור";
                case SchedulerStringId.MenuCmd_GotoToday:
                    return "ללכת ל & היום";
                case SchedulerStringId.MenuCmd_SwitchToMonthView:
                    return "& תצוגת חודש";
                case SchedulerStringId.Abbr_Hours:
                    return "שעות";
                case SchedulerStringId.MenuCmd_DeleteAppointment:
                    return "& מחק";
                case SchedulerStringId.PrintTriFoldOptControlDailyCalendar:
                    return "את לוח השנה היומי";
                case SchedulerStringId.AppointmentLabel_Business:
                    return "עסקים";
                case SchedulerStringId.Caption_WeekDaysWeekendDays:
                    return "היום בסוף השבוע";
                case SchedulerStringId.DescCmd_NewRecurringAppointment:
                    return "צור פעילות מחזורית חדשה.";
                case SchedulerStringId.Msg_iCalendar_NotValidFile:
                    return "קובץ לוח שנה באינטרנט לא חוקי";
                case SchedulerStringId.MenuCmd_SwitchToTimelineView:
                    return "& תצוגת ציר הזמן";
                case SchedulerStringId.Abbr_DaysShort:
                    return "d";
                case SchedulerStringId.DescCmd_DeleteAppointment:
                    return "למחוק את appointment(s) שנבחר.";
                case SchedulerStringId.Caption_WeekDaysWorkDays:
                    return "יום חול";
                case SchedulerStringId.DescCmd_GotoToday:
                    return "לשנות את התאריך המוצג בתצוגה הנוכחית לתאריך הנוכחי.";
                case SchedulerStringId.PrintTriFoldOptControlWeeklyCalendar:
                    return "לוח שנה שבועי";
                case SchedulerStringId.AppointmentLabel_Personal:
                    return "אישי";
                case SchedulerStringId.Msg_iCalendar_AppointmentsImportWarning:
                    return "אין אפשרות לייבא איזושהי פגישה";
                case SchedulerStringId.MenuCmd_SwitchToFullWeekView:
                    return "& תצוגת שבוע מלא";
                case SchedulerStringId.Abbr_Day:
                    return "היום";
                case SchedulerStringId.MenuCmd_NewRecurringEvent:
                    return "מחזורי חדש E & פתח";
                case SchedulerStringId.MenuCmd_TimeScalesMenu:
                    return "& פרקי זמן";
                case SchedulerStringId.MenuCmd_GotoDate:
                    return "& ללכת תאריך...";
                case SchedulerStringId.MenuCmd_EditSeries:
                    return "& עריכת סדרות";
                case SchedulerStringId.Caption_WeekOfMonthFirst:
                    return "הראשון";
                case SchedulerStringId.MenuCmd_NavigateBackward:
                    return "לאחור";
                case SchedulerStringId.PrintTriFoldOptControlMonthlyCalendar:
                    return "לוח שנה חודשי";
                case SchedulerStringId.AppointmentLabel_Vacation:
                    return "חופשה";
                case SchedulerStringId.MenuCmd_EditAppointmentDependency:
                    return "& ערוך";
                case SchedulerStringId.MenuCmd_SwitchToAgendaView:
                    return "& סדר היום תצוגה";
                case SchedulerStringId.Abbr_Days:
                    return "ימים";
                case SchedulerStringId.MenuCmd_RestoreOccurrence:
                    return "& שחזור מצב ברירת המחדל";
                case SchedulerStringId.MenuCmd_TimeScaleCaptionsMenu:
                    return "סרגל זמן & כיתובים";
                case SchedulerStringId.MenuCmd_OtherSettings:
                    return "אחרים Sett & הפגישות...";
                case SchedulerStringId.PrintWeeklyOptControlOneWeekPerPage:
                    return "1 עמוד לשבוע";
                case SchedulerStringId.Caption_WeekOfMonthSecond:
                    return "שנייה";
                case SchedulerStringId.MenuCmd_NavigateForward:
                    return "קדימה";
                case SchedulerStringId.MenuCmd_SwitchToGroupByNone:
                    return "& קבוצה על ידי אף אחד";
                case SchedulerStringId.AppointmentLabel_MustAttend:
                    return "מה אתו?";
                case SchedulerStringId.DescCmd_EditAppointmentDependency:
                    return "לערוך פגישה תלות.";
                case SchedulerStringId.Abbr_WeeksShort:
                    return "w";
                case SchedulerStringId.MenuCmd_NewAppointment:
                    return "New App & משחה";
                case SchedulerStringId.Caption_WeekOfMonthThird:
                    return "שלישי";
                case SchedulerStringId.MenuCmd_TimeScaleHour:
                    return "& שעה";
                case SchedulerStringId.MenuCmd_CustomizeCurrentView:
                    return "& התאמה אישית של תצוגה נוכחית.";
                case SchedulerStringId.PrintWeeklyOptControlTwoWeekPerPage:
                    return "2 עמודים לשבוע";
                case SchedulerStringId.DescCmd_NavigateBackward:
                    return "צעדו אחורה בזמן כפי שהוצע על ידי התצוגה הנוכחית.";
                case SchedulerStringId.MenuCmd_SwitchToGroupByResource:
                    return "& קבוצה על-ידי משאב";
                case SchedulerStringId.AppointmentLabel_TravelRequired:
                    return "נסיעות חובה";
                case SchedulerStringId.Abbr_Week:
                    return "השבוע";
                case SchedulerStringId.MenuCmd_DeleteAppointmentDependency:
                    return "& מחק";
                case SchedulerStringId.MenuCmd_TimeScaleDay:
                    return "& יום";
                case SchedulerStringId.DescCmd_NewAppointment:
                    return "צור פעילות חדשה.";
                case SchedulerStringId.Caption_WeekOfMonthFourth:
                    return "הרביעי";
                case SchedulerStringId.MenuCmd_CustomizeTimeRuler:
                    return "התאמה אישית של סרגל זמן...";
                case SchedulerStringId.PrintPageSetupFormCaption:
                    return "אפשרויות הדפסה: {0}";
                case SchedulerStringId.AppointmentLabel_NeedsPreparation:
                    return "צריך הכנה";
                case SchedulerStringId.DescCmd_NavigateForward:
                    return "להתקדם קדימה בזמן כפי שהוצע על ידי התצוגה הנוכחית.";
                case SchedulerStringId.MenuCmd_SwitchToGroupByDate:
                    return "& קבוצה לפי תאריך";
                case SchedulerStringId.Abbr_Weeks:
                    return "שבועות";
                case SchedulerStringId.DescCmd_DeleteAppointmentDependency:
                    return "מחיקת הפעילות תלות.";
                case SchedulerStringId.MenuCmd_TimeScaleWeek:
                    return "& שבוע";
                case SchedulerStringId.MenuCmd_5Minutes:
                    return "& 5 דקות";
                case SchedulerStringId.Caption_WeekOfMonthLast:
                    return "אחרונה";
                case SchedulerStringId.MenuCmd_ViewZoomIn:
                    return "התקרבות";
                case SchedulerStringId.PrintMoreItemsMsg:
                    return "עוד פריטים...";
                case SchedulerStringId.AppointmentLabel_Birthday:
                    return "יום הולדת";
                case SchedulerStringId.MenuCmd_SwitchToGanttView:
                    return "& תצוגת גנט";
                case SchedulerStringId.MenuCmd_TimeScaleYear:
                    return "& שנה";
                case SchedulerStringId.Abbr_Month:
                    return "חודש";
                case SchedulerStringId.MenuCmd_10Minutes:
                    return "10 & דקות";
                case SchedulerStringId.MenuCmd_TimeScaleMonth:
                    return "& החודש";
                case SchedulerStringId.Msg_InvalidDayCount:
                    return "ספירת היום לא חוקי. נא הזן ערך מספר שלם חיובי.";
                case SchedulerStringId.MenuCmd_AppointmentLabelTravelRequired:
                    return "& נסיעות חובה";
                case SchedulerStringId.PrintNoPrintersInstalled:
                    return "לא מותקנות מדפסות";
                case SchedulerStringId.MenuCmd_ViewZoomOut:
                    return "התרחקות";
                case SchedulerStringId.ViewShortDisplayName_Timeline:
                    return "ציר הזמן";
                case SchedulerStringId.Abbr_Months:
                    return "חודשים";
                case SchedulerStringId.Caption_Busy:
                    return "עסוק";
                case SchedulerStringId.MenuCmd_ShowTimeAs:
                    return "& הצג זמן כ";
                case SchedulerStringId.MenuCmd_TimeScaleQuarter:
                    return "& הרובע";
                case SchedulerStringId.MenuCmd_15Minutes:
                    return "& 15 דקות";
                case SchedulerStringId.TextDuration_ForPattern:
                    return "{0} {1}";
                case SchedulerStringId.MenuCmd_AppointmentLabelNeedsPreparation:
                    return "& צריך הכנה";
                case SchedulerStringId.Caption_FirstVisibleResources:
                    return "הראשון";
                case SchedulerStringId.DescCmd_ViewZoomIn:
                    return "לבצע שינוי גודל כדי להציג תוכן בפירוט רב יותר.";
                case SchedulerStringId.Caption_Tentative:
                    return "לא סופי";
                case SchedulerStringId.ViewShortDisplayName_FullWeek:
                    return "שבוע מלא";
                case SchedulerStringId.Abbr_Year:
                    return "השנה";
                case SchedulerStringId.DescCmd_ShowTimeAs:
                    return "לשנות את מצב הפעילות שנבחרה.";
                case SchedulerStringId.TextMonthlyPatternString1:
                    return "יום {3} {0}";
                case SchedulerStringId.Caption_RecurrenceSubject:
                    return "נושא:";
                case SchedulerStringId.MenuCmd_AppointmentLabelBirthday:
                    return "& יום הולדת";
                case SchedulerStringId.TextDailyPatternString_EveryDay:
                    return "כל {0} {1}";
                case SchedulerStringId.DescCmd_ViewZoomOut:
                    return "לבצע להצטמצם כדי להציג מבט רחבה יותר של התצוגה.";
                case SchedulerStringId.Caption_PrevVisibleResourcesPage:
                    return "דף קודמות";
                case SchedulerStringId.ViewShortDisplayName_Gantt:
                    return "גנט";
                case SchedulerStringId.Abbr_Years:
                    return "שנים";
                case SchedulerStringId.Caption_WorkingElsewhere:
                    return "עובד במקום אחר";
                case SchedulerStringId.Caption_RecurrenceLocation:
                    return "מיקום:";
                case SchedulerStringId.MenuCmd_Free:
                    return "& חינם";
                case SchedulerStringId.TextMonthlyPatternString2:
                    return "{1} {2} {0}";
                case SchedulerStringId.TextDailyPatternString_EveryDays:
                    return "כל {0} {1} {2}";
                case SchedulerStringId.MenuCmd_AppointmentLabelAnniversary:
                    return "& השנה";
                case SchedulerStringId.Caption_PrevVisibleResources:
                    return "הקודם";
                case SchedulerStringId.DescCmd_SplitAppointment:
                    return "לפצל את הפעילות שנבחרה לשניים על-ידי גרירת קו הפיצול.";
                case SchedulerStringId.ViewShortDisplayName_Agenda:
                    return "סדר היום";
                case SchedulerStringId.Caption_Reminder:
                    return "{0} תזכורת";
                case SchedulerStringId.Caption_OutOfOffice:
                    return "מחוץ למשרד";
                case SchedulerStringId.MenuCmd_Busy:
                    return "& עמוס";
                case SchedulerStringId.TextYearlyPattern_YearString1:
                    return "כל {0} {4} {3}";
                case SchedulerStringId.Caption_RecurrenceStartTime:
                    return "התחל:";
                case SchedulerStringId.Caption_ColorConverterFullColor:
                    return "צבע מלא";
                case SchedulerStringId.MenuCmd_AppointmentLabelPhoneCall:
                    return "טלפון &";
                case SchedulerStringId.Caption_NextVisibleResources:
                    return "הבא";
                case SchedulerStringId.TextDailyPatternString_EveryWeekDay:
                    return "{0} בכל יום בשבוע";
                case SchedulerStringId.ViewDisplayName_Day:
                    return "יום השנה";
                case SchedulerStringId.Caption_SplitAppointment:
                    return "פיצול";
                case SchedulerStringId.TimeScaleDisplayName_Hour:
                    return "שעה";
                case SchedulerStringId.MenuCmd_Tentative:
                    return "& סופי";
                case SchedulerStringId.Caption_Reminders:
                    return "{0} תזכורות";
                case SchedulerStringId.Caption_RecurrenceEndTime:
                    return "סוף:";
                case SchedulerStringId.TextYearlyPattern_YearString2:
                    return "{6} {5} {0} {3}";
                case SchedulerStringId.MenuCmd_AppointmentMove:
                    return "מו & ve";
                case SchedulerStringId.Caption_ColorConverterGrayScale:
                    return "סולם אפור";
                case SchedulerStringId.TextDailyPatternString_EveryWeekend:
                    return "{0} כל השבוע";
                case SchedulerStringId.Caption_NextVisibleResourcesPage:
                    return "דף הבא";
                case SchedulerStringId.VS_SchedulerReportsToolboxCategoryName:
                    return "DX. {0}: מתזמן דיווח";
                case SchedulerStringId.TimeScaleDisplayName_Day:
                    return "היום";
                case SchedulerStringId.ViewDisplayName_WorkDays:
                    return "לוח שנה שבוע עבודה";
                case SchedulerStringId.MenuCmd_OutOfOffice:
                    return "& מחוץ למשרד";
                case SchedulerStringId.Caption_StartTime:
                    return "שעת התחלה: {0}";
                case SchedulerStringId.TextYearlyPattern_YearsString1:
                    return "{3} {4} כל {0} {2} ' {1} '";
                case SchedulerStringId.Caption_RecurrenceShowTimeAs:
                    return "הצג זמן כ:";
                case SchedulerStringId.MenuCmd_AppointmentCopy:
                    return "& להעתיק";
                case SchedulerStringId.Caption_ColorConverterBlackAndWhite:
                    return "שחור-לבן";
                case SchedulerStringId.Msg_MemoPrintNoSelectedItems:
                    return "אין אפשרות להדפיס אלא אם פריט נבחר. בחר פריט ולאחר מכן לנסות להדפיס שוב.";
                case SchedulerStringId.Caption_LastVisibleResources:
                    return "אחרונה";
                case SchedulerStringId.ViewDisplayName_Week:
                    return "לוח שנה בשבוע";
                case SchedulerStringId.TextWeekly_0Day:
                    return "לא צוין יום בשבוע";
                case SchedulerStringId.UD_SchedulerReportsToolboxCategoryName:
                    return "מתזמן פקדים";
                case SchedulerStringId.TimeScaleDisplayName_Week:
                    return "השבוע";
                case SchedulerStringId.MenuCmd_WorkingElsewhere:
                    return "& עובד במקום אחר";
                case SchedulerStringId.TextYearlyPattern_YearsString2:
                    return "{6} {5} של {3} כל {0} {2} ' {1} '";
                case SchedulerStringId.MenuCmd_AppointmentCancel:
                    return "C & ancel";
                case SchedulerStringId.Caption_AllResources:
                    return "כל המשאבים";
                case SchedulerStringId.Caption_NAppointmentsAreSelected:
                    return "{0} פעילויות נבחרות";
                case SchedulerStringId.Caption_Recurrence:
                    return "החוזר:";
                case SchedulerStringId.Caption_ResourceNone:
                    return "(אף אחד)";
                case SchedulerStringId.Caption_IncreaseVisibleResourcesCount:
                    return "להגדיל את ספירת משאבים גלוי";
                case SchedulerStringId.ViewDisplayName_Month:
                    return "לוח שנה של חודש";
                case SchedulerStringId.MenuCmd_LabelAs:
                    return "& תווית בתור";
                case SchedulerStringId.TextWeekly_1Day:
                    return "{0}";
                case SchedulerStringId.Reporting_NotAssigned_TimeCells:
                    return "השליטה TimeCells הנדרשים לא מוקצה";
                case SchedulerStringId.TimeScaleDisplayName_Month:
                    return "חודש";
                case SchedulerStringId.Caption_AllDay:
                    return "כל היום";
                case SchedulerStringId.Caption_5Minutes:
                    return "5 דקות";
                case SchedulerStringId.Caption_VisibleResources:
                    return "משאבים גלוי";
                case SchedulerStringId.Format_TimeBeforeStart:
                    return "{0} לפני ההתחלה";
                case SchedulerStringId.Caption_RecurrencePattern:
                    return "תבנית המופע החוזר:";
                case SchedulerStringId.Caption_ResourceAll:
                    return "(הכל)";
                case SchedulerStringId.Caption_DecreaseVisibleResourcesCount:
                    return "להקטין את ספירת משאבים גלוי";
                case SchedulerStringId.ViewDisplayName_Timeline:
                    return "ציר לוח השנה";
                case SchedulerStringId.DescCmd_LabelAs:
                    return "לשנות את התווית שנבחרו.";
                case SchedulerStringId.TextAppointmentSnapToCells_Always:
                    return "תמיד";
                case SchedulerStringId.TextWeekly_2Day:
                    return "{0} ו- {1}";
                case SchedulerStringId.Reporting_NotAssigned_View:
                    return "נדרש רכיב התצוגה אינה מוקצית";
                case SchedulerStringId.Caption_PleaseSeeAbove:
                    return "נא עיין לעיל";
                case SchedulerStringId.Caption_6Minutes:
                    return "6 דקות";
                case SchedulerStringId.Caption_OnScreenResources:
                    return "משאבים על המסך";
                case SchedulerStringId.TimeScaleDisplayName_Quarter:
                    return "הרובע";
                case SchedulerStringId.Caption_ShadingApplyToAllDayArea:
                    return "כל יום באזור";
                case SchedulerStringId.Msg_Conflict:
                    return "פגישה הערוך מתנגשת עם אחד או מספר פעילויות אחרות.";
                case SchedulerStringId.Caption_NoneRecurrence:
                    return "(אף אחד)";
                case SchedulerStringId.ViewDisplayName_FullWeek:
                    return "שבוע מלא לוח שנה";
                case SchedulerStringId.MenuCmd_AppointmentLabelNone:
                    return "& אף אחד";
                case SchedulerStringId.PrintPageSetupFormatTabControlCustomizeShading:
                    return "<Customize...></Customize...>";
                case SchedulerStringId.TextAppointmentSnapToCells_Auto:
                    return "אוטומטי";
                case SchedulerStringId.PrintRangeControlInvalidDate:
                    return "תאריך הסיום להיות גדולה או שווה לתאריך ההתחלה";
                case SchedulerStringId.Caption_10Minutes:
                    return "10 דקות";
                case SchedulerStringId.Caption_GroupByNone:
                    return "אף אחד";
                case SchedulerStringId.TextWeekly_3Day:
                    return "{0} {1}, {2}";
                case SchedulerStringId.Msg_RecurrenceExceptionsWillBeLost:
                    return "מקרים חריגים המשויכים לפעילת חוזרת זו יאבדו. האם להמשיך?";
                case SchedulerStringId.Msg_InvalidInputFile:
                    return "קובץ הקלט אינו חוקי";
                case SchedulerStringId.Msg_InvalidAppointmentDuration:
                    return "ערך לא חוקי צוין למשך פרק זמן. הזינו ערך חיובי.";
                case SchedulerStringId.Caption_ShadingApplyToAppointments:
                    return "פגישות";
                case SchedulerStringId.ViewDisplayName_Gantt:
                    return "תצוגת גנט";
                case SchedulerStringId.MenuCmd_AppointmentLabelImportant:
                    return "& חשוב";
                case SchedulerStringId.MemoPrintDateFormat:
                    return "{0} {1} {2}";
                case SchedulerStringId.PrintPageSetupFormatTabControlSizeAndFontName:
                    return "{0} {1} pt.";
                case SchedulerStringId.TextAppointmentSnapToCells_Disabled:
                    return "בעלי מוגבלויות";
                case SchedulerStringId.Msg_MissingRequiredMapping:
                    return "המיפוי הדרושים עבור המאפיין '{0}' חסרה.";
                case SchedulerStringId.Caption_15Minutes:
                    return "15 דקות";
                case SchedulerStringId.Caption_GroupByDate:
                    return "תאריך";
                case SchedulerStringId.TextWeekly_4Day:
                    return "{0} {1}, {2}, {3}";
                case SchedulerStringId.DescCmd_CreateAppointmentDependency:
                    return "יצירת יחסי תלות בין פעילויות";
                case SchedulerStringId.TextRecurrenceTypeDaily:
                    return "יומי";
                case SchedulerStringId.Caption_ShadingApplyToAppointmentStatuses:
                    return "סטטוסים";
                case SchedulerStringId.ViewDisplayName_Agenda:
                    return "לוח שנה סדר היום";
                case SchedulerStringId.MenuCmd_AppointmentLabelBusiness:
                    return "& עסקים";
                case SchedulerStringId.Msg_InvalidReminderTimeBeforeStart:
                    return "ערך לא חוקי צוין עבור לפני לתזכורת של האירוע. הזינו ערך חיובי.";
                case SchedulerStringId.Caption_EmptyResource:
                    return "(בכלל)";
                case SchedulerStringId.Caption_SetupAppointmentStorage:
                    return "הגדרת פעילות אחסון";
                case SchedulerStringId.Msg_MissingMappingMember:
                    return "חסר '{1}' חבר של מיפוי המאפיינים '{0}'.";
                case SchedulerStringId.Caption_20Minutes:
                    return "20 דקות";
                case SchedulerStringId.Caption_GroupByResources:
                    return "משאבים";
                case SchedulerStringId.TextAppointmentSnapToCells_Never:
                    return "אף פעם לא";
                case SchedulerStringId.TextWeekly_5Day:
                    return "{0} {1}, {2}, {3}, {4}";
                case SchedulerStringId.MenuCmd_CreateAppointmentDependency:
                    return "יצירת תלות";
                case SchedulerStringId.Caption_ShadingApplyToHeaders:
                    return "כותרות";
                case SchedulerStringId.ViewShortDisplayName_Day:
                    return "היום";
                case SchedulerStringId.TextRecurrenceTypeWeekly:
                    return "שבועי";
                case SchedulerStringId.MenuCmd_AppointmentLabelPersonal:
                    return "& אישיים";
                case SchedulerStringId.TextDuration_FromTo:
                    return "מ- {0} {1}";
                case SchedulerStringId.Caption_DailyPrintStyle:
                    return "סגנון יומי";
                case SchedulerStringId.Caption_SetupResourceStorage:
                    return "הגדרת משאב אחסון";
                case SchedulerStringId.Caption_WeekViewDescription:
                    return "החלפה לתצוגה בשבוע. סידור פגישות לשבוע מסוים בצורה קומפקטית.";
                case SchedulerStringId.MenuCmd_PrintPreview:
                    return "הדפסה &";
                case SchedulerStringId.Msg_DuplicateMappingMember:
                    return "החבר '{0}' מיפוי אינו ייחודי:";
                case SchedulerStringId.Caption_30Minutes:
                    return "30 דקות";
                case SchedulerStringId.TextWeekly_6Day:
                    return "{0} {1}, {2}, {3}, {4}, {5}";
                case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToStart:
                    return "סיום-התחלה (סה)";
                case SchedulerStringId.DescCmd_Print:
                    return "שלח את לוח הזמנים ישירות למדפסת ברירת המחדל מבלי לבצע שינויים.";
                case SchedulerStringId.Caption_ShadingApplyToTimeRulers:
                    return "שליטי הזמן";
                case SchedulerStringId.ViewShortDisplayName_WorkDays:
                    return "שבוע העבודה";
                case SchedulerStringId.TextDuration_FromForDays:
                    return "מ- {0} עבור {1} ";
                case SchedulerStringId.Caption_WeeklyPrintStyle:
                    return "סגנון שבועי";
                case SchedulerStringId.MenuCmd_AppointmentLabelVacation:
                    return "& נופש";
                case SchedulerStringId.MenuCmd_CellsAutoHeight:
                    return "גובה אוטומטי התא";
                case SchedulerStringId.Caption_SetupAppointmentDependencyStorage:
                    return "הגדרת יחסי תלות אחסון";
                case SchedulerStringId.Msg_InconsistentRecurrenceInfoMapping:
                    return "כדי לתמוך הישנות עליך למפות גם RecurrenceInfo וגם סוג חברים.";
                case SchedulerStringId.DescCmd_PrintPreview:
                    return "תצוגה מקדימה ולבצע שינויים עמודים לפני הדפסה.";
                case SchedulerStringId.TextWeekly_7Day:
                    return "{0} {1}, {2}, {3}, {4}, {5}, {6}";
                case SchedulerStringId.Caption_60Minutes:
                    return "60 דקות";
                case SchedulerStringId.MenuCmd_PrintPageSetup:
                    return "הגדרת עמוד &";
                case SchedulerStringId.Caption_ShadingApplyToCells:
                    return "תאים";
                case SchedulerStringId.Caption_AppointmentDependencyTypeStartToStart:
                    return "התחלה-התחלה (הה)";
                case SchedulerStringId.TextRecurrenceTypeYearly:
                    return "שנתי";
                case SchedulerStringId.TextDuration_FromForDaysHours:
                    return "מ- {0} עבור {1} {2}";
                case SchedulerStringId.ViewShortDisplayName_Week:
                    return "השבוע";
                case SchedulerStringId.MenuCmd_AppointmentLabelMustAttend:
                    return "בטח & להשתתף";
                case SchedulerStringId.DescCmd_CellsAutoHeight:
                    return "לאפשר תא הזמן להתאים אוטומטית את גודלו כדי להכיל את הפגישות שהוא מכיל.";
                case SchedulerStringId.Caption_ModifyAppointmentStorageTransactionDescription:
                    return "שינוי מינוי אחסון";
                case SchedulerStringId.MenuCmd_Print:
                    return "הדפסה מהירה";
                case SchedulerStringId.Msg_MappingsCheckPassedOk:
                    return "מיפויי נכונים!";
                case SchedulerStringId.Caption_Free:
                    return "חינם";
                case SchedulerStringId.TextWeeklyPatternString_EveryWeek:
                    return "כל {0} {3}";
                case SchedulerStringId.MenuCmd_ToggleRecurrence:
                    return "מופע חוזר";
                case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToFinish:
                    return "סיום-סיום (סס)";
                case SchedulerStringId.DescCmd_PrintPageSetup:
                    return "להתאים אישית את המראה של דף ולהגדיר את אפשרויות ההדפסה השונות.";
                case SchedulerStringId.Msg_InvalidSize:
                    return "ערך לא חוקי צוין עבור הגודל.";
                case SchedulerStringId.ViewShortDisplayName_Month:
                    return "חודש";
                case SchedulerStringId.TextRecurrenceTypeMinutely:
                    return "מסוגל";
                case SchedulerStringId.TextDuration_FromForDaysMinutes:
                    return "מ- {0} עבור {1} {3}";
                case SchedulerStringId.MenuCmd_DeleteOccurrence:
                    return "מחק מופע";
                case SchedulerStringId.DescCmd_ToggleRecurrence:
                    return "להפוך את הפעילות שנבחרה לחוזרת, או ערוך את תבנית המופע החוזר.";
                case SchedulerStringId.Caption_TrifoldPrintStyle:
                    return "סגנון קיפול משולש";
                case SchedulerStringId.Caption_ModifyResourceStorageTransactionDescription:
                    return "לשנות משאבי אחסון";
                case SchedulerStringId.Caption_SetupAppointmentMappings:
                    return "מיפוי פעילות תוכנית ההתקנה";
                case SchedulerStringId.Msg_SaveBeforeClose:
                    return "רוצה לשמור את השינויים שביצעת?";
                case SchedulerStringId.Caption_AppointmentDependencyTypeStartToFinish:
                    return "התחלה-סיום (הס)";
                case SchedulerStringId.TextWeeklyPatternString_EveryWeeks:
                    return "כל {2} {1} {0} {3}";
                case SchedulerStringId.Msg_ApplyToAllStyles:
                    return "להחיל את הגדרות המדפסת הנוכחית על כל הסגנונות?";
                case SchedulerStringId.TextRecurrenceTypeHourly:
                    return "כל שעה";
                case SchedulerStringId.DescCmd_TimeScalesMenu:
                    return "שינוי ציר הזמן.";
                case SchedulerStringId.TextDuration_FromForDaysHoursMinutes:
                    return "מ- {0} עבור {1} {2} {3}";
                case SchedulerStringId.DescCmd_DeleteOccurrence:
                    return "למחוק את המופע.";
                case SchedulerStringId.MenuCmd_ChangeAppointmentReminderUI:
                    return "תזכורת";
                case SchedulerStringId.Caption_CalendarDetailsPrintStyle:
                    return "סגנון פרטי לוח שנה";
                case SchedulerStringId.Caption_SetupResourceMappings:
                    return "הגדרת משאב מיפויים";
                case SchedulerStringId.String_to:
                    return "כדי";
                case SchedulerStringId.TextMonthlyPatternString_SubPattern:
                    return "של כל {2} {1} ' {0} '";
                case SchedulerStringId.Msg_Warning:
                    return "אזהרה!";
                case SchedulerStringId.MenuCmd_ShowWorkTimeOnly:
                    return "שעות עבודה";
                case SchedulerStringId.Caption_MemoPrintStyle:
                    return "סגנון תזכיר";
                case SchedulerStringId.MenuCmd_DeleteSeries:
                    return "למחוק את הסדרה";
                case SchedulerStringId.DescCmd_ChangeAppointmentReminderUI:
                    return "לבחור מתי לקבל תזכורת של הפעילות שנבחרה.";
                case SchedulerStringId.Caption_DayViewDescription:
                    return "החלפה לתצוגה היום. הנוף המפורט ביותר של פגישות במשך ימים ספציפיים.";
                case SchedulerStringId.Caption_SetupDependencyMappings:
                    return "הגדרת יחסי תלות מיפויים";
                case SchedulerStringId.Msg_CantFitIntoPage:
                    return "זה בלתי אפשרי להכניס את פלט הדפסה דף בודד באמצעות הגדרות ההדפסה הנוכחי. נסה להגדיל את גובה העמוד או להקטין את מרווח הזמן PrintTime.";
                case SchedulerStringId.DescCmd_DeleteSeries:
                    return "מחק את הסדרה.";
                case SchedulerStringId.DescCmd_ShowWorkTimeOnly:
                    return "הצג שעות עבודה בלבד בלוח השנה.";
                case SchedulerStringId.Caption_NoneReminder:
                    return "אף אחד";
                case SchedulerStringId.Caption_WorkWeekViewDescription:
                    return "החלפה לתצוגה שבוע העבודה. תצוגה מפורטת עבור ימי העבודה בשבוע מסוים.";
                case SchedulerStringId.Caption_ModifyAppointmentMappingsTransactionDescription:
                    return "שינוי מינוי מיפויים";
                case SchedulerStringId.Msg_PrintStyleNameExists:
                    return "שם סגנון '{0}' כבר קיים. הקלד שם אחר.";
                case SchedulerStringId.MenuCmd_CompressWeekend:
                    return "לדחוס בסוף השבוע";
                case SchedulerStringId.Caption_ModifyResourceMappingsTransactionDescription:
                    return "שינוי מיפוי משאבים";
                case SchedulerStringId.DescCmd_ChangeTimelineScaleWidth:
                    return "ציין רוחב העמודות בפיקסלים על הסולם הבסיס.";
                case SchedulerStringId.Msg_OutlookCalendarNotFound:
                    return "לוח '{0}' לא נמצא.";
                case SchedulerStringId.DescCmd_CompressWeekend:
                    return "הצג שבת וראשון נדחס לתוך עמודה בודדת.";
                case SchedulerStringId.Caption_ModifyAppointmentDependencyMappingsTransactionDescription:
                    return "שינוי מינוי תלות מיפויים";
                case SchedulerStringId.MenuCmd_ChangeTimelineScaleWidth:
                    return "קנה מידה של רוחב";
                case SchedulerStringId.Caption_PrevAppointment:
                    return "המינוי הקודם";
                case SchedulerStringId.Caption_MappingsValidation:
                    return "מיפויי אימות";
                case SchedulerStringId.Caption_NextAppointment:
                    return "הפגישה הבאה";
                case SchedulerStringId.MenuCmd_OpenSchedule:
                    return "פתוח";
                case SchedulerStringId.DisplayName_Appointment:
                    return "פגישה";
                case SchedulerStringId.Caption_MappingsWizard:
                    return "אשף מיפויים...";
                case SchedulerStringId.Format_CopyOf:
                    return "עותק של {0}";
                case SchedulerStringId.DescCmd_OpenSchedule:
                    return "ייבוא זמנים מקובץ (.ics).";
                case SchedulerStringId.Format_CopyNOf:
                    return "עותק ({0}) {1}";
                case SchedulerStringId.Caption_CheckMappings:
                    return "סימון מיפויי";
                case SchedulerStringId.MenuCmd_SaveSchedule:
                    return "שמור";
                case SchedulerStringId.DescCmd_SaveSchedule:
                    return "לשמור את לוח זמנים לקובץ (.ics).";
                case SchedulerStringId.MenuCmd_ChangeSnapToCellsUI:
                    return "הצמד לתאים";
                case SchedulerStringId.DescCmd_ChangeSnapToCellsUI:
                    return "ציין מצב ההצמדה להצגת פעילויות בתוך התאים זמן.";
                case SchedulerStringId.MenuCmd_OpenOccurrence:
                    return "מופע פתוח";
                case SchedulerStringId.DescCmd_OpenOccurrence:
                    return "פתח את מופע הפגישה הזאת.";
                case SchedulerStringId.MenuCmd_OpenSeries:
                    return "סדרת פתוח";
                case SchedulerStringId.DescCmd_OpenSeries:
                    return "פתח את זה מפגש בסדרה";
                default:
                    return base.GetLocalizedString(id);
            }

        }
    }

    public class FarsiSchedulerExtensionsLocalizer : SchedulerExtensionsLocalizer {
        public override string GetLocalizedString(SchedulerExtensionsStringId id) {
            switch(id) {
                case SchedulerExtensionsStringId.CaptionViewNavigator_Today:
                    return "امروز";
                case SchedulerExtensionsStringId.Caption_GroupActiveView:
                    return "فعال مشاهده";
                case SchedulerExtensionsStringId.Caption_PageView:
                    return "مشاهده";
                case SchedulerExtensionsStringId.Caption_Event:
                    return "رویداد";
                case SchedulerExtensionsStringId.Caption_GroupActions:
                    return "اقدامات";
                case SchedulerExtensionsStringId.Msg_Some:
                    return "برخی از";
                case SchedulerExtensionsStringId.Caption_GroupGroupBy:
                    return "گروه بندی بر اساس";
                case SchedulerExtensionsStringId.Caption_GroupTimeScale:
                    return "مقیاس زمانی";
                case SchedulerExtensionsStringId.Caption_PageHome:
                    return "صفحه اصلی";
                case SchedulerExtensionsStringId.Caption_GroupAppointment:
                    return "قرار ملاقات";
                case SchedulerExtensionsStringId.Caption_GroupOptions:
                    return "گزینه های";
                case SchedulerExtensionsStringId.Caption_RecurringAppointment:
                    return "ملاقات تکراری";
                case SchedulerExtensionsStringId.Caption_ViewNavigator:
                    return "مشاهده ناوبر";
                case SchedulerExtensionsStringId.Caption_PageAppointment:
                    return "قرار ملاقات";
                case SchedulerExtensionsStringId.Caption_GroupNavigator:
                    return "حرکت";
                case SchedulerExtensionsStringId.Caption_GroupCommon:
                    return "مشترک";
                case SchedulerExtensionsStringId.Caption_ViewSelector:
                    return "مشاهده انتخاب";
                case SchedulerExtensionsStringId.Caption_GroupLayout:
                    return "چیدمان";
                case SchedulerExtensionsStringId.Caption_Reminder:
                    return "یادآوری:";
                case SchedulerExtensionsStringId.Caption_GroupPrint:
                    return "نسخه قابل چاپ";
                case SchedulerExtensionsStringId.Caption_PageCategoryCalendarTools:
                    return "ابزار تقویم";
                case SchedulerExtensionsStringId.Caption_PageFile:
                    return "دریافت فایل";
                case SchedulerExtensionsStringId.Caption_RecurringEvent:
                    return "رویداد تکراری";
                case SchedulerExtensionsStringId.Caption_Appointment:
                    return "قرار ملاقات";
                case SchedulerExtensionsStringId.Caption_GroupArrange:
                    return "ترتیب";
                default:
                return base.GetLocalizedString(id);
            }
            
        }
    }
    public class ArabicSchedulerExtensionsLocalizer : SchedulerExtensionsLocalizer {
        public override string GetLocalizedString(SchedulerExtensionsStringId id) {
            switch(id) {
                case SchedulerExtensionsStringId.Caption_GroupGroupBy:
                    return "تجميع حسب";
                case SchedulerExtensionsStringId.Caption_PageView:
                    return "طريقة العرض";
                case SchedulerExtensionsStringId.Caption_PageHome:
                    return "الصفحة الرئيسية";
                case SchedulerExtensionsStringId.CaptionViewNavigator_Today:
                    return "اليوم";
                case SchedulerExtensionsStringId.Caption_Event:
                    return "الحدث";
                case SchedulerExtensionsStringId.Caption_RecurringAppointment:
                    return "موعد متكرر";
                case SchedulerExtensionsStringId.Msg_Some:
                    return "بعض";
                case SchedulerExtensionsStringId.Caption_PageAppointment:
                    return "تعيين";
                case SchedulerExtensionsStringId.Caption_PageFile:
                    return "الملف";
                case SchedulerExtensionsStringId.Caption_GroupActions:
                    return "الإجراءات";
                case SchedulerExtensionsStringId.Caption_GroupTimeScale:
                    return "مقياس الوقت";
                case SchedulerExtensionsStringId.Caption_GroupActiveView:
                    return "طريقة العرض النشطة";
                case SchedulerExtensionsStringId.Caption_ViewSelector:
                    return "محدد طريقة العرض";
                case SchedulerExtensionsStringId.Caption_GroupLayout:
                    return "تخطيط";
                case SchedulerExtensionsStringId.Caption_RecurringEvent:
                    return "تكرار الحدث";
                case SchedulerExtensionsStringId.Caption_GroupAppointment:
                    return "تعيين";
                case SchedulerExtensionsStringId.Caption_GroupArrange:
                    return "ترتيب";
                case SchedulerExtensionsStringId.Caption_ViewNavigator:
                    return "طريقة عرض المستكشف";
                case SchedulerExtensionsStringId.Caption_GroupOptions:
                    return "خيارات";
                case SchedulerExtensionsStringId.Caption_PageCategoryCalendarTools:
                    return "أدوات التقويم";
                case SchedulerExtensionsStringId.Caption_GroupPrint:
                    return "طباعة";
                case SchedulerExtensionsStringId.Caption_GroupNavigator:
                    return "التنقل";
                case SchedulerExtensionsStringId.Caption_Appointment:
                    return "تعيين";
                case SchedulerExtensionsStringId.Caption_Reminder:
                    return "للتذكير:";
                case SchedulerExtensionsStringId.Caption_GroupCommon:
                    return "المشتركة";
                default:
                    return base.GetLocalizedString(id);
            }

        }
    }
    public class HebrewSchedulerExtensionsLocalizer : SchedulerExtensionsLocalizer {
        public override string GetLocalizedString(SchedulerExtensionsStringId id) {
            switch(id) {
                case SchedulerExtensionsStringId.Caption_PageHome:
                    return "הבית";
                case SchedulerExtensionsStringId.Msg_Some:
                    return "כמה";
                case SchedulerExtensionsStringId.Caption_GroupActions:
                    return "פעולות";
                case SchedulerExtensionsStringId.Caption_GroupActiveView:
                    return "התצוגה הפעילה";
                case SchedulerExtensionsStringId.Caption_PageView:
                    return "תצוגה";
                case SchedulerExtensionsStringId.Caption_Event:
                    return "אירוע";
                case SchedulerExtensionsStringId.Caption_PageFile:
                    return "קובץ";
                case SchedulerExtensionsStringId.CaptionViewNavigator_Today:
                    return "היום";
                case SchedulerExtensionsStringId.Caption_GroupOptions:
                    return "אפשרויות";
                case SchedulerExtensionsStringId.Caption_GroupTimeScale:
                    return "סרגל זמן";
                case SchedulerExtensionsStringId.Caption_GroupGroupBy:
                    return "קבץ לפי";
                case SchedulerExtensionsStringId.Caption_PageAppointment:
                    return "פגישה";
                case SchedulerExtensionsStringId.Caption_GroupAppointment:
                    return "פגישה";
                case SchedulerExtensionsStringId.Caption_GroupPrint:
                    return "הדפסה";
                case SchedulerExtensionsStringId.Caption_GroupNavigator:
                    return "נווט";
                case SchedulerExtensionsStringId.Caption_RecurringAppointment:
                    return "החוזרת";
                case SchedulerExtensionsStringId.Caption_GroupArrange:
                    return "לארגן";
                case SchedulerExtensionsStringId.Caption_GroupCommon:
                    return "נפוצות";
                case SchedulerExtensionsStringId.Caption_RecurringEvent:
                    return "אירוע חוזר";
                case SchedulerExtensionsStringId.Caption_ViewNavigator:
                    return "תצוגת ניווט";
                case SchedulerExtensionsStringId.Caption_Appointment:
                    return "פגישה";
                case SchedulerExtensionsStringId.Caption_ViewSelector:
                    return "בורר התצוגות";
                case SchedulerExtensionsStringId.Caption_GroupLayout:
                    return "פריסה";
                case SchedulerExtensionsStringId.Caption_PageCategoryCalendarTools:
                    return "לוח כלים";
                case SchedulerExtensionsStringId.Caption_Reminder:
                    return "תזכורת:";

                default:
                    return base.GetLocalizedString(id);
            }

        }
    }
}
