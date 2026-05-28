Imports DevExpress.XtraScheduler.Localization
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DevExpress.MailClient.Win.Localizer
    Public Class FarsiSchedulerLocalizer
        Inherits SchedulerLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As SchedulerStringId) As String
            Select Case id
                Case SchedulerStringId.AppointmentLabel_Anniversary
                    Return "سالگرد"
                Case SchedulerStringId.Caption_WeekOfMonthLast
                    Return "آخرين"
                Case SchedulerStringId.TimeScaleDisplayName_Year
                    Return "سال"
                Case SchedulerStringId.MenuCmd_20Minutes
                    Return "& 20 دقیقه"
                Case SchedulerStringId.DefaultToolTipStringFormat_SplitAppointment
                    Return "{0}: گام {1}"
                Case SchedulerStringId.AppointmentLabel_PhoneCall
                    Return "تلفن تماس"
                Case SchedulerStringId.MenuCmd_OpenAppointment
                    Return "& باز"
                Case SchedulerStringId.Msg_InvalidDayCount
                    Return "تعداد روز های نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید."
                Case SchedulerStringId.Abbr_MinutesShort1
                    Return "m"
                Case SchedulerStringId.Caption_MonthViewDescription
                    Return "تعویض به نمای ماه (چند هفته). نمای تقویم مفید برای برنامه های بلند مدت."
                Case SchedulerStringId.DescCmd_OpenAppointment
                    Return "انتصاب انتخاب شده را باز کنید."
                Case SchedulerStringId.Msg_InvalidDayOfWeekForDailyRecurrence
                    Return "نامعتبر روز هفته برای عود روزانه. تنها WeekDays.EveryDay WeekDays.WeekendDays و WeekDays.WorkDays معتبر در این زمینه هستند."
                Case SchedulerStringId.Appointment_StartContinueText
                    Return "از {0}"
                Case SchedulerStringId.MenuCmd_DeleteAppointment
                    Return "& حذف"
                Case SchedulerStringId.Msg_InvalidDayCountValue
                    Return "تعداد روز های نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید."
                Case SchedulerStringId.PrintCalendarDetailsControlDayPeriod
                    Return "روز"
                Case SchedulerStringId.Abbr_MinutesShort2
                    Return "دقیقه"
                Case SchedulerStringId.MenuCmd_PrintAppointment
                    Return "& چاپ"
                Case SchedulerStringId.Appointment_EndContinueText
                    Return "به {0}"
                Case SchedulerStringId.MenuCmd_30Minutes
                    Return "& 30 دقیقه"
                Case SchedulerStringId.Caption_TimelineViewDescription
                    Return "تعویض به نمای خط زمان. قرار ملاقات در رابطه با زمان می رسم."
                Case SchedulerStringId.DescCmd_DeleteAppointment
                    Return "Appointment(s) انتخاب شده را حذف کنید."
                Case SchedulerStringId.Msg_InvalidWeekCount
                    Return "تعداد هفته های نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید."
                Case SchedulerStringId.Abbr_Minute
                    Return "دقیقه"
                Case SchedulerStringId.Msg_InternalError
                    Return "خطای داخلی!"
                Case SchedulerStringId.MenuCmd_NewAppointment
                    Return "جدید App & پماد"
                Case SchedulerStringId.PrintCalendarDetailsControlWeekPeriod
                    Return "هفته"
                Case SchedulerStringId.Msg_InvalidEndDate
                    Return "تاریخی که قبل از تاریخ شروع رخ می دهد."
                Case SchedulerStringId.MenuCmd_EditSeries
                    Return "& ویرایش سری"
                Case SchedulerStringId.MenuCmd_60Minutes
                    Return "6 & 0 دقیقه"
                Case SchedulerStringId.Msg_InvalidWeekCountValue
                    Return "تعداد هفته های نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید."
                Case SchedulerStringId.Abbr_Minutes
                    Return "دقیقه"
                Case SchedulerStringId.DescCmd_NewAppointment
                    Return "ایجاد قرار جدید."
                Case SchedulerStringId.Caption_FullWeekViewDescription
                    Return "برای مشاهده هفته کامل تعویض نمایید. قرار ملاقات را برای یک هفته خاص در یک فرم فشرده مرتب می کند."
                Case SchedulerStringId.Msg_XtraSchedulerNotAssigned
                    Return "جزء SchedulerStorage به SchedulerControl شده است"
                Case SchedulerStringId.Caption_Appointment
                    Return "{0} - قرار ملاقات"
                Case SchedulerStringId.MenuCmd_RestoreOccurrence
                    Return "& حالت پیش فرض بازیابی"
                Case SchedulerStringId.Msg_InvalidMonthCount
                    Return "تعداد دفعات مشاهده ماه نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید."
                Case SchedulerStringId.PrintCalendarDetailsControlMonthPeriod
                    Return "ماه"
                Case SchedulerStringId.Abbr_HoursShort
                    Return "h"
                Case SchedulerStringId.MenuCmd_NewAllDayEvent
                    Return "جدید تمام روز & رویداد"
                Case SchedulerStringId.Caption_Event
                    Return "{0} - رویداد"
                Case SchedulerStringId.MenuCmd_SwitchViewMenu
                    Return "تغییر نظر به"
                Case SchedulerStringId.Caption_GanttViewDescription
                    Return "تعویض به نمای گانت. پروژه مشاهده مدیریت است که قرار ملاقات و وابستگیهای خود را در رابطه با زمان را نشان می دهد."
                Case SchedulerStringId.DescCmd_NewRecurringAppointment
                    Return "ملاقات تکراری جدید ایجاد کنید."
                Case SchedulerStringId.Msg_InvalidMonthCountValue
                    Return "تعداد دفعات مشاهده ماه نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید."
                Case SchedulerStringId.Abbr_Hour
                    Return "ساعت"
                Case SchedulerStringId.Msg_InvalidTimeOfDayInterval
                    Return "مدت زمان نامعتبر برای TimeOfDayInterval"
                Case SchedulerStringId.PrintMonthlyOptControlOnePagePerMonth
                    Return "1 صفحه در ماه"
                Case SchedulerStringId.MenuCmd_NewRecurringAppointment
                    Return "تکراری جدید & قرار ملاقات"
                Case SchedulerStringId.Caption_UntitledAppointment
                    Return "بدون عنوان"
                Case SchedulerStringId.MenuCmd_NewRecurringEvent
                    Return "Recurring جدید الکترونیکی & دریچه"
                Case SchedulerStringId.MenuCmd_SwitchToDayView
                    Return "& روز مشاهده"
                Case SchedulerStringId.Msg_InvalidYearCount
                    Return "تعداد سال های نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید."
                Case SchedulerStringId.Abbr_Hours
                    Return "ساعت"
                Case SchedulerStringId.Caption_AgendaViewDescription
                    Return "برای مشاهده برنامه تعویض نمایید. لیستی از رویدادهای آینده را نمایش می دهد"
                Case SchedulerStringId.DescCmd_GotoToday
                    Return "تاریخ نمایش داده شده در نمای کنونی به تاریخ فعلی را تغییر دهید."
                Case SchedulerStringId.Msg_OverflowTimeOfDayInterval
                    Return "مقدار غیرمعتبر برای TimeOfDayInterval. باید کمتر یا برابر با روز"
                Case SchedulerStringId.Caption_ReadOnly
                    Return " [ادامه]"
                Case SchedulerStringId.MenuCmd_EditAppointmentDependency
                    Return "& ویرایش"
                Case SchedulerStringId.PrintMonthlyOptControlTwoPagesPerMonth
                    Return "2 صفحه در ماه"
                Case SchedulerStringId.Msg_InvalidYearCountValue
                    Return "تعداد سال های نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید."
                Case SchedulerStringId.Abbr_DaysShort
                    Return "د"
                Case SchedulerStringId.MenuCmd_GotoDate
                    Return "& رفتن به تاریخ..."
                Case SchedulerStringId.MenuCmd_SwitchToWorkWeekView
                    Return "وو & rk هفته مشاهده"
                Case SchedulerStringId.Caption_WeekDaysEveryDay
                    Return "روز"
                Case SchedulerStringId.Caption_GroupByNoneDescription
                    Return "لغو قرار ملاقات."
                Case SchedulerStringId.DescCmd_EditAppointmentDependency
                    Return "ویرایش وابستگی ملاقات."
                Case SchedulerStringId.Msg_InvalidOccurrencesCount
                    Return "تعداد رخداد نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید."
                Case SchedulerStringId.Abbr_Day
                    Return "روز"
                Case SchedulerStringId.Msg_LoadCollectionFromXml
                    Return "برنامه ریز باید در حالت بی بند و بار بار مورد مجموعه از xml باشد"
                Case SchedulerStringId.MenuCmd_OtherSettings
                    Return "دیگر Sett & آمیزش..."
                Case SchedulerStringId.Caption_WeekDaysWeekendDays
                    Return "روز آخر هفته"
                Case SchedulerStringId.MenuCmd_DeleteAppointmentDependency
                    Return "& حذف"
                Case SchedulerStringId.Msg_InvalidOccurrencesCountValue
                    Return "تعداد رخداد نامعتبر. لطفا یک عدد صحیح مثبت وارد نمایید."
                Case SchedulerStringId.Abbr_Days
                    Return "روز"
                Case SchedulerStringId.MenuCmd_CustomizeCurrentView
                    Return "& سفارشی نمودن نمای کنونی..."
                Case SchedulerStringId.MenuCmd_SwitchToMonthView
                    Return "& نمای ماه"
                Case SchedulerStringId.PrintTimeIntervalControlInvalidDuration
                    Return "مدت زمان باید باشد نه بیشتر از یک روز و بیشتر از 0"
                Case SchedulerStringId.Caption_WeekDaysWorkDays
                    Return "روز هفته"
                Case SchedulerStringId.DescCmd_DeleteAppointmentDependency
                    Return "وابستگی قرار ملاقات را حذف کنید."
                Case SchedulerStringId.Msg_InvalidDayNumber
                    Return "تعداد روز های نامعتبر. لطفا عدد صحیح از 1 تا {0} را وارد کنید."
                Case SchedulerStringId.MenuCmd_SwitchToWeekView
                    Return "& هفته مشاهده"
                Case SchedulerStringId.Abbr_WeeksShort
                    Return "w"
                Case SchedulerStringId.Abbr_Months
                    Return "ماه"
                Case SchedulerStringId.MenuCmd_CustomizeTimeRuler
                    Return "زمان حاکم سفارشی..."
                Case SchedulerStringId.Caption_GroupByDateDescription
                    Return "قرار ملاقات گروه تاریخ."
                Case SchedulerStringId.AppointmentLabel_None
                    Return "هیچ کدام"
                Case SchedulerStringId.Caption_WeekOfMonthFirst
                    Return "اول"
                Case SchedulerStringId.MenuCmd_GotoThisDay
                    Return "رفتن به این & روز"
                Case SchedulerStringId.Msg_InvalidDayNumberValue
                    Return "تعداد روز های نامعتبر. لطفا عدد صحیح از 1 تا {0} را وارد کنید."
                Case SchedulerStringId.MenuCmd_SwitchToTimelineView
                    Return "& نمای"
                Case SchedulerStringId.Abbr_Week
                    Return "هفته"
                Case SchedulerStringId.Abbr_Year
                    Return "سال"
                Case SchedulerStringId.MenuCmd_5Minutes
                    Return "& 5 دقیقه"
                Case SchedulerStringId.PrintTimeIntervalControlInvalidStartEndTime
                    Return "زمان پایان می باید بیشتر از زمان شروع"
                Case SchedulerStringId.MenuCmd_SwitchToAgendaView
                    Return "& مشاهده دستور کار"
                Case SchedulerStringId.Caption_WeekOfMonthSecond
                    Return "دوم"
                Case SchedulerStringId.MenuCmd_GotoToday
                    Return "رفتن به & امروز"
                Case SchedulerStringId.Msg_WarningDayNumber
                    Return "چند ماه کمتر از {0} روز است. این ماه رخدادها در آخرین روز ماه سقوط خواهد کرد."
                Case SchedulerStringId.Caption_GroupByResourceDescription
                    Return "ملاقات گروهی توسط منابع."
                Case SchedulerStringId.Abbr_Weeks
                    Return "هفته"
                Case SchedulerStringId.Abbr_Years
                    Return "سال"
                Case SchedulerStringId.AppointmentLabel_Important
                    Return "مهم"
                Case SchedulerStringId.MenuCmd_6Minutes
                    Return "& 6 دقیقه"
                Case SchedulerStringId.MenuCmd_SwitchToFullWeekView
                    Return "& هفته کامل مشاهده"
                Case SchedulerStringId.Caption_WeekOfMonthThird
                    Return "سوم"
                Case SchedulerStringId.MenuCmd_15Minutes
                    Return "& 15 دقیقه"
                Case SchedulerStringId.PrintTriFoldOptControlDailyCalendar
                    Return "تقویم روزانه"
                Case SchedulerStringId.Msg_InvalidDayOfWeek
                    Return "هیچ روز انتخاب شده. لطفا حداقل یک روز در هفته را انتخاب کنید."
                Case SchedulerStringId.Abbr_Month
                    Return "ماه"
                Case SchedulerStringId.Caption_Reminder
                    Return "{0} یادآوری"
                Case SchedulerStringId.MenuCmd_SwitchToGroupByNone
                    Return "& گروه توسط هیچ"
                Case SchedulerStringId.Msg_iCalendar_NotValidFile
                    Return "پرونده های تقویم اینترنتی معتبر"
                Case SchedulerStringId.MenuCmd_10Minutes
                    Return "10 & دقیقه"
                Case SchedulerStringId.Caption_WeekOfMonthFourth
                    Return "چهارم"
                Case SchedulerStringId.MenuCmd_TimeScaleYear
                    Return "& سال"
                Case SchedulerStringId.AppointmentLabel_Business
                    Return "کسب و کار"
                Case SchedulerStringId.Msg_WarningAppointmentDeleted
                    Return "انتصاب بوسیله کاربر دیگری حذف شده است."
                Case SchedulerStringId.Format_TimeBeforeStart
                    Return "{0} قبل از شروع"
                Case SchedulerStringId.MenuCmd_TimeScaleDay
                    Return "& روز"
                Case SchedulerStringId.Caption_Reminders
                    Return "{0} یادآوری"
                Case SchedulerStringId.PrintTriFoldOptControlWeeklyCalendar
                    Return "تقویم هفتگی"
                Case SchedulerStringId.MenuCmd_AppointmentLabelTravelRequired
                    Return "& لزوم مسافرت"
                Case SchedulerStringId.Caption_Busy
                    Return "گرفتار"
                Case SchedulerStringId.MenuCmd_ShowTimeAs
                    Return "& نمایش زمان بعنوان"
                Case SchedulerStringId.MenuCmd_SwitchToGroupByResource
                    Return "& گروه توسط منابع"
                Case SchedulerStringId.ViewShortDisplayName_Timeline
                    Return "جدول زمانی"
                Case SchedulerStringId.Msg_iCalendar_AppointmentsImportWarning
                    Return "برخی از قرار ملاقات را وارد کند"
                Case SchedulerStringId.Msg_Conflict
                    Return "درگیری ویرایش قرار ملاقات با یک یا چند ملاقات دیگر."
                Case SchedulerStringId.Caption_StartTime
                    Return "زمان شروع: {0}"
                Case SchedulerStringId.AppointmentLabel_Personal
                    Return "شخصی"
                Case SchedulerStringId.MenuCmd_AppointmentLabelNeedsPreparation
                    Return "& احتیاج به آمادگی"
                Case SchedulerStringId.MenuCmd_TimeScaleWeek
                    Return "& هفته"
                Case SchedulerStringId.Caption_Tentative
                    Return "آزمایشی"
                Case SchedulerStringId.DescCmd_ShowTimeAs
                    Return "وضعیت ملاقات های انتخاب شده را تغییر دهید."
                Case SchedulerStringId.PrintTriFoldOptControlMonthlyCalendar
                    Return "تقویم ماهانه"
                Case SchedulerStringId.ViewShortDisplayName_FullWeek
                    Return "هفته کامل"
                Case SchedulerStringId.Msg_InvalidAppointmentDuration
                    Return "مقدار نامعتبر مشخص برای مدت زمان فاصله. لطفا یک مقدار مثبت."
                Case SchedulerStringId.MenuCmd_SwitchToGroupByDate
                    Return "& گروه تاریخ"
                Case SchedulerStringId.Caption_NAppointmentsAreSelected
                    Return "قرار ملاقات {0} انتخاب می شوند"
                Case SchedulerStringId.MenuCmd_NavigateBackward
                    Return "عقب مانده"
                Case SchedulerStringId.MenuCmd_AppointmentLabelBirthday
                    Return "& تولد"
                Case SchedulerStringId.Caption_WorkingElsewhere
                    Return "در جای دیگر کار"
                Case SchedulerStringId.MenuCmd_Free
                    Return "& رایگان"
                Case SchedulerStringId.Caption_FirstVisibleResources
                    Return "اول"
                Case SchedulerStringId.ViewShortDisplayName_Gantt
                    Return "گانت"
                Case SchedulerStringId.AppointmentLabel_Vacation
                    Return "تعطیلات"
                Case SchedulerStringId.Msg_InvalidReminderTimeBeforeStart
                    Return "مقدار نامعتبر برای تعیین شده قبل از زمان یادآوری رویداد. لطفا یک مقدار مثبت."
                Case SchedulerStringId.TextWeekly_2Day
                    Return "{0} و {1}"
                Case SchedulerStringId.MenuCmd_TimeScaleMonth
                    Return "& ماه"
                Case SchedulerStringId.MenuCmd_AppointmentLabelAnniversary
                    Return "& سالگرد"
                Case SchedulerStringId.Caption_OutOfOffice
                    Return "خارج از دفتر"
                Case SchedulerStringId.MenuCmd_Busy
                    Return "& مشغول"
                Case SchedulerStringId.ViewShortDisplayName_Agenda
                    Return "دستور کار"
                Case SchedulerStringId.PrintWeeklyOptControlOneWeekPerPage
                    Return "1 صفحه در روز"
                Case SchedulerStringId.TextDuration_FromTo
                    Return "از {0} به {1}"
                Case SchedulerStringId.TextWeekly_3Day
                    Return "{0}، {1} و {2}"
                Case SchedulerStringId.MenuCmd_AppointmentLabelPhoneCall
                    Return "& تلفنی"
                Case SchedulerStringId.ViewDisplayName_Day
                    Return "تقویم روز"
                Case SchedulerStringId.MenuCmd_Tentative
                    Return "& نامشخص"
                Case SchedulerStringId.MenuCmd_SwitchToGanttView
                    Return "& گانت مشاهده"
                Case SchedulerStringId.MenuCmd_NavigateForward
                    Return "به جلو"
                Case SchedulerStringId.TimeScaleDisplayName_Hour
                    Return "ساعت"
                Case SchedulerStringId.TextDuration_FromForDays
                    Return "از {0} {1} "
                Case SchedulerStringId.MenuCmd_ViewZoomOut
                    Return "زوم کردن"
                Case SchedulerStringId.Caption_PrevVisibleResourcesPage
                    Return "صفحه قبلی"
                Case SchedulerStringId.TextWeekly_4Day
                    Return "{0}، {1}، {2} و {3}"
                Case SchedulerStringId.MenuCmd_AppointmentMove
                    Return "ماه & ve"
                Case SchedulerStringId.ViewDisplayName_WorkDays
                    Return "تقویم هفته کاری"
                Case SchedulerStringId.AppointmentLabel_MustAttend
                    Return "ضروریت حضور"
                Case SchedulerStringId.MenuCmd_TimeScaleQuarter
                    Return "& سه ماهه"
                Case SchedulerStringId.MenuCmd_OutOfOffice
                    Return "& خارج از دفتر"
                Case SchedulerStringId.TimeScaleDisplayName_Day
                    Return "روز"
                Case SchedulerStringId.TextDuration_FromForDaysHours
                    Return "از {0} {1} {2}"
                Case SchedulerStringId.PrintWeeklyOptControlTwoWeekPerPage
                    Return "2 صفحه در هفته"
                Case SchedulerStringId.MenuCmd_TimeScalesMenu
                    Return "& مقیاس زمان"
                Case SchedulerStringId.DescCmd_ViewZoomIn
                    Return "پوسته پوسته شدن برای نمایش محتویات در جزئیات بیشتری را انجام می دهد."
                Case SchedulerStringId.TextWeekly_5Day
                    Return "{0}، {1}، {2}، {3} و {4}"
                Case SchedulerStringId.MenuCmd_AppointmentCopy
                    Return "& کپی"
                Case SchedulerStringId.DescCmd_NavigateBackward
                    Return "گام به عقب در زمان به عنوان پیشنهاد شده توسط نمای کنونی."
                Case SchedulerStringId.ViewDisplayName_Week
                    Return "تقویم هفته"
                Case SchedulerStringId.MenuCmd_WorkingElsewhere
                    Return "& کار جای دیگر"
                Case SchedulerStringId.TimeScaleDisplayName_Week
                    Return "هفته"
                Case SchedulerStringId.Caption_PrevVisibleResources
                    Return "قبلی"
                Case SchedulerStringId.AppointmentLabel_TravelRequired
                    Return "لزوم مسافرت"
                Case SchedulerStringId.TextDuration_FromForDaysMinutes
                    Return "از {0} {1} {3}"
                Case SchedulerStringId.DescCmd_ViewZoomOut
                    Return "مقیاس گذاری برای نمایش نگاه گسترده تر از این دیدگاه را انجام می دهد."
                Case SchedulerStringId.TextWeekly_6Day
                    Return "{0}، {1}، {2}، {3}، {4} و {5}"
                Case SchedulerStringId.TextMonthlyPatternString_SubPattern
                    Return "از هر {0} {2} {1}"
                Case SchedulerStringId.PrintPageSetupFormCaption
                    Return "گزینه های چاپ: {0}"
                Case SchedulerStringId.MenuCmd_AppointmentCancel
                    Return "ج & ancel"
                Case SchedulerStringId.ViewDisplayName_Month
                    Return "تقویم ماه"
                Case SchedulerStringId.MenuCmd_LabelAs
                    Return "& خشکاندن"
                Case SchedulerStringId.MenuCmd_TimeScaleCaptionsMenu
                    Return "مقیاس زمانی & شرح"
                Case SchedulerStringId.TimeScaleDisplayName_Month
                    Return "ماه"
                Case SchedulerStringId.TextDuration_FromForDaysHoursMinutes
                    Return "از {0} {1} {2} {3}"
                Case SchedulerStringId.DescCmd_NavigateForward
                    Return "به جلو پیشروی در زمان به عنوان پیشنهاد شده توسط نمای کنونی."
                Case SchedulerStringId.DescCmd_SplitAppointment
                    Return "انتصاب منتخب در دو با کشیدن خط شکاف تقسیم."
                Case SchedulerStringId.Caption_PleaseSeeAbove
                    Return "لطفا نگاه کنید به بالا"
                Case SchedulerStringId.TextWeekly_7Day
                    Return "{0}، {1}، {2}، {3}، {4}، {5} و {6}"
                Case SchedulerStringId.Caption_5Minutes
                    Return "5 دقیقه"
                Case SchedulerStringId.Caption_NextVisibleResources
                    Return "بعدی"
                Case SchedulerStringId.ViewDisplayName_Timeline
                    Return "تقویم روزشمار"
                Case SchedulerStringId.AppointmentLabel_NeedsPreparation
                    Return "احتیاج به آمادگی"
                Case SchedulerStringId.DescCmd_LabelAs
                    Return "برچسب ملاقات های انتخاب شده را تغییر دهید."
                Case SchedulerStringId.TimeScaleDisplayName_Quarter
                    Return "سه ماهه"
                Case SchedulerStringId.TextMonthlyPatternString1
                    Return "روز {3} {0}"
                Case SchedulerStringId.TextDuration_ForPattern
                    Return "{0} و {1}"
                Case SchedulerStringId.Caption_SplitAppointment
                    Return "اسپلیت"
                Case SchedulerStringId.TextWeeklyPatternString_EveryWeek
                    Return "هر {0} {3}"
                Case SchedulerStringId.PrintMoreItemsMsg
                    Return "موارد بیشتر..."
                Case SchedulerStringId.MenuCmd_TimeScaleHour
                    Return "& ساعت"
                Case SchedulerStringId.Caption_6Minutes
                    Return "6 دقیقه"
                Case SchedulerStringId.ViewDisplayName_FullWeek
                    Return "تقویم هفته کامل"
                Case SchedulerStringId.MenuCmd_AppointmentLabelNone
                    Return "& هیچ کدام"
                Case SchedulerStringId.MenuCmd_ViewZoomIn
                    Return "بزرگنمایی"
                Case SchedulerStringId.Caption_RecurrenceStartTime
                    Return "شروع:"
                Case SchedulerStringId.TextDailyPatternString_EveryDay
                    Return "هر {0} {1}"
                Case SchedulerStringId.VS_SchedulerReportsToolboxCategoryName
                    Return "DX. {0}: برنامه ریز گزارش"
                Case SchedulerStringId.Caption_RecurrenceSubject
                    Return "موضوع:"
                Case SchedulerStringId.Caption_NextVisibleResourcesPage
                    Return "صفحه بعد"
                Case SchedulerStringId.TextWeeklyPatternString_EveryWeeks
                    Return "هر {2} {1} در {3} {0}"
                Case SchedulerStringId.Caption_10Minutes
                    Return "10 دقیقه"
                Case SchedulerStringId.ViewDisplayName_Gantt
                    Return "نمای گانت"
                Case SchedulerStringId.AppointmentLabel_Birthday
                    Return "تولد"
                Case SchedulerStringId.MenuCmd_AppointmentLabelImportant
                    Return "& مهم"
                Case SchedulerStringId.TextMonthlyPatternString2
                    Return "{1} {2} {0}"
                Case SchedulerStringId.Caption_RecurrenceEndTime
                    Return "پایان:"
                Case SchedulerStringId.TextDailyPatternString_EveryDays
                    Return "هر {0} {1} {2}"
                Case SchedulerStringId.PrintNoPrintersInstalled
                    Return "هیچ چاپگری نصب نشده"
                Case SchedulerStringId.UD_SchedulerReportsToolboxCategoryName
                    Return "کنترل زمانبندی"
                Case SchedulerStringId.Caption_DecreaseVisibleResourcesCount
                    Return "کاهش تعداد منابع قابل مشاهده"
                Case SchedulerStringId.Caption_15Minutes
                    Return "15 دقیقه"
                Case SchedulerStringId.Caption_ColorConverterBlackAndWhite
                    Return "سیاه و سفید"
                Case SchedulerStringId.Reporting_NotAssigned_TimeCells
                    Return "مورد نیاز TimeCells کنترل شده است"
                Case SchedulerStringId.ViewDisplayName_Agenda
                    Return "دستور کار تقویم"
                Case SchedulerStringId.MenuCmd_AppointmentLabelBusiness
                    Return "& کسب و کار"
                Case SchedulerStringId.Caption_RecurrenceShowTimeAs
                    Return "نمایش زمان بعنوان:"
                Case SchedulerStringId.Caption_RecurrenceLocation
                    Return "محل سکونت:"
                Case SchedulerStringId.TextDailyPatternString_EveryWeekDay
                    Return "هر روز هفته {0}"
                Case SchedulerStringId.Caption_LastVisibleResources
                    Return "آخرين"
                Case SchedulerStringId.DescCmd_Print
                    Return "برنامه ارسال مستقیم به چاپگر پیش فرض بدون ایجاد تغییرات."
                Case SchedulerStringId.Caption_ShadingApplyToAllDayArea
                    Return "تمام روز منطقه"
                Case SchedulerStringId.Msg_InvalidInputFile
                    Return "فایل ورودی نامعتبر است"
                Case SchedulerStringId.Caption_20Minutes
                    Return "20 دقیقه"
                Case SchedulerStringId.ViewShortDisplayName_Day
                    Return "روز"
                Case SchedulerStringId.MenuCmd_AppointmentLabelPersonal
                    Return "& شخصی"
                Case SchedulerStringId.TextYearlyPattern_YearString1
                    Return "هر {0} {4} {3}"
                Case SchedulerStringId.Caption_Recurrence
                    Return "عود:"
                Case SchedulerStringId.TextDailyPatternString_EveryWeekend
                    Return "هر آخر هفته {0}"
                Case SchedulerStringId.MenuCmd_PrintPageSetup
                    Return "راه اندازی & صفحه"
                Case SchedulerStringId.Msg_MissingRequiredMapping
                    Return "نقشه برداری مورد نیاز برای '{0}' اموال مفقود شده است."
                Case SchedulerStringId.Caption_ResourceNone
                    Return "(خالی)"
                Case SchedulerStringId.Caption_ShadingApplyToAppointments
                    Return "قرار ملاقات"
                Case SchedulerStringId.Caption_30Minutes
                    Return "30 دقیقه"
                Case SchedulerStringId.ViewShortDisplayName_WorkDays
                    Return "هفته کاری"
                Case SchedulerStringId.Reporting_NotAssigned_View
                    Return "جزء مورد نیاز مشاهده شده است"
                Case SchedulerStringId.MenuCmd_AppointmentLabelVacation
                    Return "& تعطیلات"
                Case SchedulerStringId.Caption_RecurrencePattern
                    Return "الگوی تکرار:"
                Case SchedulerStringId.Caption_SetupAppointmentStorage
                    Return "تنظیم قرار ملاقات ذخیره سازی"
                Case SchedulerStringId.TextWeekly_0Day
                    Return "روز مشخص نشده هفته"
                Case SchedulerStringId.Caption_IncreaseVisibleResourcesCount
                    Return "افزایش تعداد منابع قابل مشاهده"
                Case SchedulerStringId.DescCmd_PrintPageSetup
                    Return "سفارشی کردن ظاهر صفحه و پیکربندی گزینه های چاپ مختلف."
                Case SchedulerStringId.Caption_ShadingApplyToAppointmentStatuses
                    Return "وضعیت ملاقات"
                Case SchedulerStringId.Caption_ModifyResourceStorageTransactionDescription
                    Return "تغییر منبع ذخیره سازی"
                Case SchedulerStringId.TextRecurrenceTypeDaily
                    Return "روزانه"
                Case SchedulerStringId.TextYearlyPattern_YearString2
                    Return "{6} {5} {3} {0}"
                Case SchedulerStringId.Caption_60Minutes
                    Return "60 دقیقه"
                Case SchedulerStringId.ViewShortDisplayName_Week
                    Return "هفته"
                Case SchedulerStringId.MenuCmd_AppointmentLabelMustAttend
                    Return "باید & حضور"
                Case SchedulerStringId.Caption_NoneRecurrence
                    Return "(خالی)"
                Case SchedulerStringId.TextWeekly_1Day
                    Return "{0}"
                Case SchedulerStringId.DescCmd_TimeScalesMenu
                    Return "مقیاس زمانی تغییر دهید."
                Case SchedulerStringId.Caption_ResourceAll
                    Return "(تمام)"
                Case SchedulerStringId.Msg_RecurrenceExceptionsWillBeLost
                    Return "هر استثنایی مربوط به این ملاقات تکراری گم می شود. ادامه می دهید؟"
                Case SchedulerStringId.Caption_ShadingApplyToHeaders
                    Return "سرصفحه ها"
                Case SchedulerStringId.MenuCmd_CellsAutoHeight
                    Return "ارتفاع خودرو همراه"
                Case SchedulerStringId.Caption_Free
                    Return "رایگان"
                Case SchedulerStringId.Caption_SetupResourceStorage
                    Return "راه اندازی منابع ذخیره سازی"
                Case SchedulerStringId.ViewShortDisplayName_Month
                    Return "ماه"
                Case SchedulerStringId.MenuCmd_ToggleRecurrence
                    Return "عود"
                Case SchedulerStringId.MemoPrintDateFormat
                    Return "{0} {1} {2}"
                Case SchedulerStringId.Caption_ModifyAppointmentDependencyStorageTransactionDescription
                    Return "ویرایش ذخیره سازی AppointmentDependency"
                Case SchedulerStringId.TextRecurrenceTypeWeekly
                    Return "بارگیری"
                Case SchedulerStringId.DescCmd_OpenSeries
                    Return "این جلسه سری باز."
                Case SchedulerStringId.MenuCmd_ShowWorkTimeOnly
                    Return "ساعات کار"
                Case SchedulerStringId.Caption_ShadingApplyToTimeRulers
                    Return "حاکمان زمان"
                Case SchedulerStringId.TextYearlyPattern_YearsString1
                    Return "{3} {4} هر {0} {2} {1}"
                Case SchedulerStringId.Msg_DuplicateMappingMember
                    Return "عضو '{0}' نقشه برداری منحصر به فرد است: "
                Case SchedulerStringId.PrintPageSetupFormatTabControlCustomizeShading
                    Return "<Customize...></Customize...>"
                Case SchedulerStringId.DescCmd_CellsAutoHeight
                    Return "همراه هم به اندازه آن را به جای آن وجود دارد قرار ملاقات تنظیم خودکار را فعال کنید."
                Case SchedulerStringId.DescCmd_ToggleRecurrence
                    Return "را انتخاب شده ملاقات تکراری و یا ویرایش الگوی تکرار. "
                Case SchedulerStringId.Caption_EmptyResource
                    Return "(هر)"
                Case SchedulerStringId.DescCmd_CreateAppointmentDependency
                    Return "ایجاد وابستگی بین قرار ملاقات"
                Case SchedulerStringId.Caption_DayViewDescription
                    Return "تعویض به نمای روز. مشاهده دقیق ترین ملاقات براى روز خاص."
                Case SchedulerStringId.MenuCmd_DeleteOccurrence
                    Return "حذف رخداد"
                Case SchedulerStringId.Caption_SetupAppointmentDependencyStorage
                    Return "راه اندازی شبکه وابستگی"
                Case SchedulerStringId.DescCmd_ShowWorkTimeOnly
                    Return "فقط ساعات کار را در تقویم نشان می دهد."
                Case SchedulerStringId.Caption_ShadingApplyToCells
                    Return "سلول های"
                Case SchedulerStringId.TextRecurrenceTypeMonthly
                    Return "ماهانه"
                Case SchedulerStringId.MenuCmd_ChangeAppointmentReminderUI
                    Return "یادآوری"
                Case SchedulerStringId.Caption_DailyPrintStyle
                    Return "سبک روزانه"
                Case SchedulerStringId.TextYearlyPattern_YearsString2
                    Return "{5} {6} {3} هر {0} {2} {1}"
                Case SchedulerStringId.Caption_WorkWeekViewDescription
                    Return "تعویض به نمای هفته کاری. مشاهده دقیق برای روز کاری در هفته خاص."
                Case SchedulerStringId.Msg_InconsistentRecurrenceInfoMapping
                    Return "برای حمایت از عود شما RecurrenceInfo و نوع نقشه باید عضو."
                Case SchedulerStringId.PrintPageSetupFormatTabControlSizeAndFontName
                    Return "{0} pt. {1}"
                Case SchedulerStringId.DescCmd_DeleteOccurrence
                    Return "حذف رخداد."
                Case SchedulerStringId.MenuCmd_CreateAppointmentDependency
                    Return "ایجاد وابستگی"
                Case SchedulerStringId.MenuCmd_CompressWeekend
                    Return "آخر هفته فشرده"
                Case SchedulerStringId.Msg_InvalidSize
                    Return "مقدار نامعتبر تعیین شده برای اندازه."
                Case SchedulerStringId.Caption_ModifyAppointmentStorageTransactionDescription
                    Return "تغییر ملاقات ذخیره سازی"
                Case SchedulerStringId.DescCmd_ChangeAppointmentReminderUI
                    Return "زمان ملاقات منتخب یادآوری می شود را انتخاب کنید."
                Case SchedulerStringId.Caption_WeeklyPrintStyle
                    Return "سبک هفتگی"
                Case SchedulerStringId.TextRecurrenceTypeYearly
                    Return "سالانه"
                Case SchedulerStringId.Caption_WeekViewDescription
                    Return "برای مشاهده هفته تعویض نمایید. قرار ملاقات را برای یک هفته خاص در یک فرم فشرده مرتب می کند."
                Case SchedulerStringId.Caption_AllDay
                    Return "همه روز"
                Case SchedulerStringId.MenuCmd_DeleteSeries
                    Return "حذف سری"
                Case SchedulerStringId.DescCmd_CompressWeekend
                    Return "شنبه و یکشنبه فشرده شده به ستون را نشان می دهد."
                Case SchedulerStringId.Msg_MappingsCheckPassedOk
                    Return "تعیین صحیح است!"
                Case SchedulerStringId.Msg_ApplyToAllStyles
                    Return "تنظیمات چاپگر را برای همه سبک اقدام کنم؟"
                Case SchedulerStringId.PrintRangeControlInvalidDate
                    Return "تاریخ پایان باید بزرگتر یا برابر با تاریخ شروع"
                Case SchedulerStringId.Caption_NoneReminder
                    Return "هیچ کدام"
                Case SchedulerStringId.Caption_MonthlyPrintStyle
                    Return "سبک ماهانه"
                Case SchedulerStringId.DescCmd_DeleteSeries
                    Return "حذف سری."
                Case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToStart
                    Return "پایان به شروع (FS)"
                Case SchedulerStringId.Msg_MemoPrintNoSelectedItems
                    Return "چاپ نمی باشد، مگر اینکه موردی انتخاب شده است. موردی را انتخاب کنید و سپس مجددا برای چاپ سعی کنید."
                Case SchedulerStringId.TextRecurrenceTypeMinutely
                    Return "Minutely"
                Case SchedulerStringId.DescCmd_ChangeTimelineScaleWidth
                    Return "پهنای ستون در پیکسل برای مقیاس پایه را مشخص کنید."
                Case SchedulerStringId.Caption_TrifoldPrintStyle
                    Return "سبک سه تایی"
                Case SchedulerStringId.Caption_SetupAppointmentMappings
                    Return "تنظیم قرار ملاقات نگاشت"
                Case SchedulerStringId.Caption_AppointmentDependencyTypeStartToStart
                    Return "شروع برای شروع (اس اس)"
                Case SchedulerStringId.Msg_SaveBeforeClose
                    Return "می خواهید تغییرات را ذخیره کنید؟"
                Case SchedulerStringId.Caption_AllResources
                    Return "تمام منابع"
                Case SchedulerStringId.MenuCmd_ChangeTimelineScaleWidth
                    Return "مقیاس عرض"
                Case SchedulerStringId.TextRecurrenceTypeHourly
                    Return "ساعات روز:"
                Case SchedulerStringId.Caption_CalendarDetailsPrintStyle
                    Return "جزئیات سبک تقویم"
                Case SchedulerStringId.String_to
                    Return "به"
                Case SchedulerStringId.Caption_VisibleResources
                    Return "منابع قابل مشاهده"
                Case SchedulerStringId.MenuCmd_OpenSchedule
                    Return "باز"
                Case SchedulerStringId.Caption_SetupResourceMappings
                    Return "راه اندازی منابع نگاشت"
                Case SchedulerStringId.Caption_MemoPrintStyle
                    Return "سبک یادآور"
                Case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToFinish
                    Return "پایان به پایان (FF)"
                Case SchedulerStringId.Caption_OnScreenResources
                    Return "صفحه منابع"
                Case SchedulerStringId.DescCmd_OpenSchedule
                    Return "برنامه واردات از فایل (.ics)."
                Case SchedulerStringId.Caption_ColorConverterFullColor
                    Return "رنگ کامل"
                Case SchedulerStringId.Msg_Warning
                    Return "هشدار!"
                Case SchedulerStringId.Caption_GroupByNone
                    Return "هیچ کدام"
                Case SchedulerStringId.Caption_SetupDependencyMappings
                    Return "تنظیم وابستگی نگاشت"
                Case SchedulerStringId.MenuCmd_SaveSchedule
                    Return "ذخیره"
                Case SchedulerStringId.Caption_ColorConverterGrayScale
                    Return "سایه خاکستری"
                Case SchedulerStringId.Caption_AppointmentDependencyTypeStartToFinish
                    Return "آغاز تا پایان (سانفرانسیسکو)"
                Case SchedulerStringId.Caption_GroupByDate
                    Return "تاریخ"
                Case SchedulerStringId.Msg_CantFitIntoPage
                    Return "خروجی چاپ را به یک صفحه با استفاده از تنظیمات چاپ مناسب است. لطفا سعی کنید به ارتفاع صفحه افزایش یا کاهش فاصله PrintTime."
                Case SchedulerStringId.DescCmd_SaveSchedule
                    Return "برنامه ذخیره فایل (.ics)."
                Case SchedulerStringId.TextAppointmentSnapToCells_Always
                    Return "همیشه"
                Case SchedulerStringId.Caption_GroupByResources
                    Return "منابع"
                Case SchedulerStringId.Caption_ModifyAppointmentMappingsTransactionDescription
                    Return "تعیین قرار ملاقات را تغییر دهید"
                Case SchedulerStringId.MenuCmd_ChangeSnapToCellsUI
                    Return "ضربه محکم و ناگهانی به سلول"
                Case SchedulerStringId.TextAppointmentSnapToCells_Auto
                    Return "خودکار"
                Case SchedulerStringId.Msg_PrintStyleNameExists
                    Return "نام سبک '{0}' در حال حاضر وجود دارد. نام دیگری را بنویسید."
                Case SchedulerStringId.Caption_ModifyResourceMappingsTransactionDescription
                    Return "تعیین منبع را تغییر دهید"
                Case SchedulerStringId.DescCmd_ChangeSnapToCellsUI
                    Return "حالت snapping برای نمایش قرار ملاقات ها در داخل سلول های زمان را مشخص کنید."
                Case SchedulerStringId.TextAppointmentSnapToCells_Disabled
                    Return "معلول"
                Case SchedulerStringId.Msg_OutlookCalendarNotFound
                    Return "'{0}' تقویم یافت نشد."
                Case SchedulerStringId.MenuCmd_OpenOccurrence
                    Return "وقوع باز"
                Case SchedulerStringId.Caption_ModifyAppointmentDependencyMappingsTransactionDescription
                    Return "تعیین وابستگی قرار ملاقات را تغییر دهید"
                Case SchedulerStringId.TextAppointmentSnapToCells_Never
                    Return "هرگز"
                Case SchedulerStringId.Caption_PrevAppointment
                    Return "ملاقات قبلی"
                Case SchedulerStringId.DescCmd_OpenOccurrence
                    Return "این رخداد جلسه را باز کنید."
                Case SchedulerStringId.Caption_MappingsValidation
                    Return "تعیین اعتبار"
                Case SchedulerStringId.MenuCmd_PrintPreview
                    Return "نسخه قابل چاپ پیشنمایش &"
                Case SchedulerStringId.Caption_NextAppointment
                    Return "ملاقات بعدی"
                Case SchedulerStringId.MenuCmd_OpenSeries
                    Return "سری باز"
                Case SchedulerStringId.Caption_MappingsWizard
                    Return "سهل آموز نگاشت..."
                Case SchedulerStringId.DescCmd_PrintPreview
                    Return "پیش نمایش و ایجاد تغییرات در صفحات قبل از چاپ."
                Case SchedulerStringId.DisplayName_Appointment
                    Return "قرار ملاقات"
                Case SchedulerStringId.Caption_CheckMappings
                    Return "تعیین را بررسی کنید"
                Case SchedulerStringId.MenuCmd_Print
                    Return "چاپ فوری"
                Case SchedulerStringId.Format_CopyOf
                    Return "کپی از {0}"
                Case SchedulerStringId.Format_CopyNOf
                    Return "کپی ({0}) از {1}"

                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
    Public Class ArabicSchedulerLocalizer
        Inherits SchedulerLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As SchedulerStringId) As String
            Select Case id
                Case SchedulerStringId.AppointmentLabel_Anniversary
                    Return "الذكرى السنوية"
                Case SchedulerStringId.Msg_InvalidEndDate
                    Return "يحدث التاريخ الذي أدخلته قبل تاريخ البدء."
                Case SchedulerStringId.Msg_IsNotValid
                    Return "'{0}' ليست قيمة صالحة ل '{1}'"
                Case SchedulerStringId.MenuCmd_20Minutes
                    Return "آند 20 دقيقة"
                Case SchedulerStringId.PrintCalendarDetailsControlDayPeriod
                    Return "اليوم"
                Case SchedulerStringId.Msg_InvalidDayOfWeekForDailyRecurrence
                    Return "غير صالح اليوم من الأسبوع لتكرار يومية. إلا WeekDays.EveryDay و WeekDays.WeekendDays و WeekDays.WorkDays صالحة في هذا السياق."
                Case SchedulerStringId.TimeScaleDisplayName_Year
                    Return "السنة"
                Case SchedulerStringId.Caption_MonthViewDescription
                    Return "قم بالتبديل إلى طريقة عرض الشهر (عدة أسابيع). طريقة عرض التقويم مفيدة لخطط طويلة الأجل."
                Case SchedulerStringId.Caption_Appointment
                    Return "{0}-التعيين"
                Case SchedulerStringId.DefaultToolTipStringFormat_SplitAppointment
                    Return "{0}: الخطوة {1}"
                Case SchedulerStringId.AppointmentLabel_PhoneCall
                    Return "مكالمة هاتفية"
                Case SchedulerStringId.Caption_Event
                    Return "{0}-الحدث"
                Case SchedulerStringId.MenuCmd_30Minutes
                    Return "آند 30 دقيقة"
                Case SchedulerStringId.PrintCalendarDetailsControlWeekPeriod
                    Return "الأسبوع"
                Case SchedulerStringId.Msg_InternalError
                    Return "خطأ داخلي!"
                Case SchedulerStringId.Abbr_MinutesShort1
                    Return "m"
                Case SchedulerStringId.Caption_WeekOfMonthFirst
                    Return "الأولى"
                Case SchedulerStringId.Caption_TimelineViewDescription
                    Return "قم بالتبديل إلى طريقة عرض المخطط الزمني. قطع التعيينات بالنسبة للوقت."
                Case SchedulerStringId.Caption_ReadOnly
                    Return " [للقراءة فقط]"
                Case SchedulerStringId.MenuCmd_60Minutes
                    Return "6 آند 0 دقيقة"
                Case SchedulerStringId.Appointment_StartContinueText
                    Return "من {0}"
                Case SchedulerStringId.Caption_UntitledAppointment
                    Return "بدون عنوان"
                Case SchedulerStringId.PrintCalendarDetailsControlMonthPeriod
                    Return "في الشهر"
                Case SchedulerStringId.Msg_XtraSchedulerNotAssigned
                    Return "لم يتم تعيين عنصر شيدوليرستوراجي إلى شيدوليركونترول"
                Case SchedulerStringId.Caption_FullWeekViewDescription
                    Return "قم بالتبديل إلى طريقة عرض أسبوع كامل. ترتيب مواعيد لأسبوع معين في نموذج مضغوط."
                Case SchedulerStringId.Caption_WeekDaysEveryDay
                    Return "اليوم"
                Case SchedulerStringId.Abbr_MinutesShort2
                    Return "دقيقة"
                Case SchedulerStringId.Caption_WeekOfMonthSecond
                    Return "الثانية"
                Case SchedulerStringId.Appointment_EndContinueText
                    Return "إلى {0}"
                Case SchedulerStringId.MenuCmd_SwitchViewMenu
                    Return "تغيير طريقة العرض إلى"
                Case SchedulerStringId.PrintMonthlyOptControlOnePagePerMonth
                    Return "الصفحة 1/الشهر"
                Case SchedulerStringId.Caption_WeekOfMonthThird
                    Return "الثالثة"
                Case SchedulerStringId.Msg_InvalidTimeOfDayInterval
                    Return "المدة غير صحيحة تيميوفدايينتيرفال"
                Case SchedulerStringId.Abbr_Minute
                    Return "دقيقة"
                Case SchedulerStringId.Caption_GanttViewDescription
                    Return "قم بالتبديل إلى طريقة العرض مخطط جانت. عرض إدارة المشروع تظهر المواعيد والتبعيات الخاصة بهم فيما يتعلق بالوقت."
                Case SchedulerStringId.Caption_WeekDaysWeekendDays
                    Return "يوم عطلة نهاية الأسبوع"
                Case SchedulerStringId.MenuCmd_SwitchToDayView
                    Return "آند طريقة العرض يوم"
                Case SchedulerStringId.Msg_InvalidDayCountValue
                    Return "عد اليوم غير صالحة. الرجاء إدخال عدد صحيح موجب."
                Case SchedulerStringId.PrintMonthlyOptControlTwoPagesPerMonth
                    Return "2 صفحات/الشهر"
                Case SchedulerStringId.Msg_InvalidMonthCountValue
                    Return "عدد غير صالح في الشهر. الرجاء إدخال عدد صحيح موجب."
                Case SchedulerStringId.Caption_WeekOfMonthFourth
                    Return "الرابعة"
                Case SchedulerStringId.Caption_AgendaViewDescription
                    Return "قم بالتبديل إلى طريقة عرض جدول. يعرض قائمة بالأحداث القادمة"
                Case SchedulerStringId.Caption_WeekDaysWorkDays
                    Return "يوم من أيام الأسبوع"
                Case SchedulerStringId.Msg_OverflowTimeOfDayInterval
                    Return "الحصول على قيمة غير صحيحة تيميوفدايينتيرفال. وينبغي أن يكون أقل من أو يساوي يوم واحد"
                Case SchedulerStringId.Abbr_Minutes
                    Return "دقيقة"
                Case SchedulerStringId.Msg_InvalidWeekCount
                    Return "عدد غير صالح في الأسبوع. الرجاء إدخال عدد صحيح موجب."
                Case SchedulerStringId.PrintTimeIntervalControlInvalidDuration
                    Return "يجب أن تكون مدة لا تزيد عن يوم واحد وأكبر من 0"
                Case SchedulerStringId.Caption_GroupByNoneDescription
                    Return "فك تجميع التعيينات."
                Case SchedulerStringId.Msg_InvalidYearCount
                    Return "عد السنة غير صالح. الرجاء إدخال عدد صحيح موجب."
                Case SchedulerStringId.Caption_WeekOfMonthLast
                    Return "آخر"
                Case SchedulerStringId.Msg_InvalidDayOfWeek
                    Return "لا يوجد اليوم المحدد. الرجاء تحديد يوم واحد على الأقل في الأسبوع."
                Case SchedulerStringId.MenuCmd_SwitchToMonthView
                    Return "آند طريقة عرض الشهر"
                Case SchedulerStringId.MenuCmd_SwitchToWorkWeekView
                    Return "عمل عرض الأسبوع"
                Case SchedulerStringId.Msg_LoadCollectionFromXml
                    Return "الجدولة تحتاج أن تكون في وضع غير منضم لتحميل عناصر مجموعة من xml"
                Case SchedulerStringId.MenuCmd_SwitchToWeekView
                    Return "آند طريقة عرض الأسبوع"
                Case SchedulerStringId.Abbr_HoursShort
                    Return "ح"
                Case SchedulerStringId.Msg_InvalidWeekCountValue
                    Return "عدد غير صالح في الأسبوع. الرجاء إدخال عدد صحيح موجب."
                Case SchedulerStringId.Msg_InvalidYearCountValue
                    Return "عد السنة غير صالح. الرجاء إدخال عدد صحيح موجب."
                Case SchedulerStringId.Msg_InvalidDayCount
                    Return "عد اليوم غير صالحة. الرجاء إدخال عدد صحيح موجب."
                Case SchedulerStringId.AppointmentLabel_None
                    Return "لا شيء"
                Case SchedulerStringId.PrintTimeIntervalControlInvalidStartEndTime
                    Return "يجب أن يكون وقت النهاية أكبر من وقت البدء"
                Case SchedulerStringId.Caption_GroupByDateDescription
                    Return "مجموعة التعيينات حسب التاريخ."
                Case SchedulerStringId.Msg_WarningAppointmentDeleted
                    Return "تم حذف التعيين من قبل مستخدم آخر."
                Case SchedulerStringId.Abbr_Hour
                    Return "ساعة"
                Case SchedulerStringId.Msg_InvalidMonthCount
                    Return "عدد غير صالح في الشهر. الرجاء إدخال عدد صحيح موجب."
                Case SchedulerStringId.Msg_InvalidOccurrencesCount
                    Return "عدد تكرارات غير صالحة. الرجاء إدخال عدد صحيح موجب."
                Case SchedulerStringId.MenuCmd_SwitchToTimelineView
                    Return "آند طريقة عرض الخط الزمني"
                Case SchedulerStringId.MenuCmd_SwitchToAgendaView
                    Return "آند عرض جدول الأعمال"
                Case SchedulerStringId.PrintTriFoldOptControlDailyCalendar
                    Return "تقويم يومي"
                Case SchedulerStringId.MenuCmd_EditSeries
                    Return "آند تحرير سلسلة"
                Case SchedulerStringId.AppointmentLabel_Important
                    Return "هام"
                Case SchedulerStringId.Abbr_Hours
                    Return "ساعات"
                Case SchedulerStringId.Caption_GroupByResourceDescription
                    Return "مجموعة تعيينات الموارد."
                Case SchedulerStringId.MenuCmd_OpenAppointment
                    Return "آند فتح"
                Case SchedulerStringId.MenuCmd_EditAppointmentDependency
                    Return "آند تحرير"
                Case SchedulerStringId.Msg_InvalidOccurrencesCountValue
                    Return "عدد تكرارات غير صالحة. الرجاء إدخال عدد صحيح موجب."
                Case SchedulerStringId.MenuCmd_SwitchToFullWeekView
                    Return "آند عرض أسبوع كامل"
                Case SchedulerStringId.MenuCmd_SwitchToGroupByNone
                    Return "آند مجموعة من لا شيء"
                Case SchedulerStringId.MenuCmd_RestoreOccurrence
                    Return "آند استعادة الحالة الافتراضية"
                Case SchedulerStringId.PrintTriFoldOptControlWeeklyCalendar
                    Return "تقويم أسبوعي"
                Case SchedulerStringId.AppointmentLabel_Business
                    Return "الأعمال التجارية"
                Case SchedulerStringId.Abbr_DaysShort
                    Return "د"
                Case SchedulerStringId.DescCmd_OpenAppointment
                    Return "افتح الموعد المحدد."
                Case SchedulerStringId.DescCmd_EditAppointmentDependency
                    Return "تحرير تعيين تبعية."
                Case SchedulerStringId.MenuCmd_TimeScaleDay
                    Return "آند اليوم"
                Case SchedulerStringId.MenuCmd_SwitchToGroupByResource
                    Return "آند مجموعة من الموارد"
                Case SchedulerStringId.Msg_InvalidDayNumber
                    Return "رقم غير صالح اليوم. الرجاء إدخال قيمة عدد صحيح من 1 إلى {0}."
                Case SchedulerStringId.MenuCmd_NewAppointment
                    Return "جديد التطبيق آند مرهم"
                Case SchedulerStringId.PrintTriFoldOptControlMonthlyCalendar
                    Return "تقويم شهري"
                Case SchedulerStringId.AppointmentLabel_Personal
                    Return "شخصية"
                Case SchedulerStringId.Msg_iCalendar_AppointmentsImportWarning
                    Return "لا يمكن استيراد بعض التعيين"
                Case SchedulerStringId.Abbr_Day
                    Return "اليوم"
                Case SchedulerStringId.MenuCmd_PrintAppointment
                    Return "آند طباعة"
                Case SchedulerStringId.MenuCmd_DeleteAppointmentDependency
                    Return "آند حذف"
                Case SchedulerStringId.MenuCmd_TimeScaleWeek
                    Return "آند الأسبوع"
                Case SchedulerStringId.Msg_InvalidDayNumberValue
                    Return "رقم غير صالح اليوم. الرجاء إدخال قيمة عدد صحيح من 1 إلى {0}."
                Case SchedulerStringId.MenuCmd_SwitchToGroupByDate
                    Return "آند مجموعة حسب التاريخ"
                Case SchedulerStringId.PrintWeeklyOptControlOneWeekPerPage
                    Return "الأسبوع الصفحة 1"
                Case SchedulerStringId.DescCmd_NewAppointment
                    Return "إنشاء موعد جديد."
                Case SchedulerStringId.AppointmentLabel_Vacation
                    Return "عطلة"
                Case SchedulerStringId.MenuCmd_NavigateBackward
                    Return "إلى الخلف"
                Case SchedulerStringId.MenuCmd_DeleteAppointment
                    Return "آند حذف"
                Case SchedulerStringId.MenuCmd_TimeScaleMonth
                    Return "آند الشهر"
                Case SchedulerStringId.Abbr_Days
                    Return "أيام"
                Case SchedulerStringId.DescCmd_DeleteAppointmentDependency
                    Return "حذف تعيين تبعية."
                Case SchedulerStringId.Abbr_Months
                    Return "أشهر"
                Case SchedulerStringId.MenuCmd_SwitchToGanttView
                    Return "آند طريقة عرض جانت"
                Case SchedulerStringId.PrintWeeklyOptControlTwoWeekPerPage
                    Return "2 صفحات/الأسبوع"
                Case SchedulerStringId.MenuCmd_NavigateForward
                    Return "إلى الأمام"
                Case SchedulerStringId.Msg_WarningDayNumber
                    Return "بعض أشهر لديها عدد أقل من الأيام {0}. لهذين الشهرين، سوف تقع الحوادث في اليوم الأخير من الشهر."
                Case SchedulerStringId.MenuCmd_NewAllDayEvent
                    Return "جديدة كل يوم آند الحدث"
                Case SchedulerStringId.AppointmentLabel_MustAttend
                    Return "ويجب أن يحضر"
                Case SchedulerStringId.DescCmd_DeleteAppointment
                    Return "حذف الموعد المحدد."
                Case SchedulerStringId.MenuCmd_TimeScaleQuarter
                    Return "آند الربع"
                Case SchedulerStringId.MenuCmd_TimeScalesMenu
                    Return "آند المقاييس الزمنية"
                Case SchedulerStringId.Abbr_WeeksShort
                    Return "w"
                Case SchedulerStringId.PrintPageSetupFormCaption
                    Return "خيارات الطباعة: {0}"
                Case SchedulerStringId.MenuCmd_GotoThisDay
                    Return "الذهاب إلى هذا آند اليوم"
                Case SchedulerStringId.Abbr_Year
                    Return "السنة"
                Case SchedulerStringId.MenuCmd_OtherSettings
                    Return "ضبط & تحديد أخرى..."
                Case SchedulerStringId.DescCmd_NavigateBackward
                    Return "خطوة إلى الوراء في الوقت المناسب كما اقترح طريقة العرض الحالية."
                Case SchedulerStringId.MenuCmd_TimeScaleYear
                    Return "آند العام"
                Case SchedulerStringId.MenuCmd_AppointmentLabelTravelRequired
                    Return "آند السفر المطلوبة"
                Case SchedulerStringId.MenuCmd_NewRecurringAppointment
                    Return "جديد متكرر & التعيين"
                Case SchedulerStringId.AppointmentLabel_TravelRequired
                    Return "السفر المطلوبة"
                Case SchedulerStringId.Abbr_Week
                    Return "الأسبوع"
                Case SchedulerStringId.MenuCmd_TimeScaleCaptionsMenu
                    Return "مقياس الوقت & التسميات التوضيحية"
                Case SchedulerStringId.PrintMoreItemsMsg
                    Return "المزيد من العناصر..."
                Case SchedulerStringId.MenuCmd_GotoToday
                    Return "اذهب إلى آند اليوم"
                Case SchedulerStringId.Abbr_Years
                    Return "السنوات"
                Case SchedulerStringId.MenuCmd_CustomizeCurrentView
                    Return "آند تخصيص طريقة العرض الحالية..."
                Case SchedulerStringId.DescCmd_NavigateForward
                    Return "المضي قدما إلى الأمام في الوقت المناسب كما اقترح طريقة العرض الحالية."
                Case SchedulerStringId.DescCmd_NewRecurringAppointment
                    Return "إنشاء موعد متكرر جديد."
                Case SchedulerStringId.MenuCmd_ShowTimeAs
                    Return "آند إظهار الوقت ك"
                Case SchedulerStringId.AppointmentLabel_NeedsPreparation
                    Return "يحتاج إعداد"
                Case SchedulerStringId.Abbr_Weeks
                    Return "أسابيع"
                Case SchedulerStringId.MenuCmd_AppointmentLabelNeedsPreparation
                    Return "آند يحتاج إلى إعداد"
                Case SchedulerStringId.Caption_FirstVisibleResources
                    Return "الأولى"
                Case SchedulerStringId.MenuCmd_TimeScaleHour
                    Return "آند ساعة"
                Case SchedulerStringId.PrintNoPrintersInstalled
                    Return "لا توجد طابعات مثبتة"
                Case SchedulerStringId.MenuCmd_ViewZoomIn
                    Return "تكبير"
                Case SchedulerStringId.DescCmd_ShowTimeAs
                    Return "لتغيير حالة الموعد المحدد."
                Case SchedulerStringId.MenuCmd_AppointmentLabelBirthday
                    Return "آند أعياد ميلاد"
                Case SchedulerStringId.DescCmd_GotoToday
                    Return "قم بتغيير تاريخ عرضه في طريقة العرض الحالية إلى التاريخ الحالي."
                Case SchedulerStringId.Caption_Reminder
                    Return "{0} تذكير"
                Case SchedulerStringId.MenuCmd_CustomizeTimeRuler
                    Return "تخصيص الوقت المسطرة..."
                Case SchedulerStringId.Caption_PrevVisibleResourcesPage
                    Return "الصفحة السابقة"
                Case SchedulerStringId.Caption_5Minutes
                    Return "بعد 5 دقائق"
                Case SchedulerStringId.Caption_NextVisibleResources
                    Return "القادم"
                Case SchedulerStringId.MenuCmd_NewRecurringEvent
                    Return "جديد متكرر ه & تنفيس"
                Case SchedulerStringId.AppointmentLabel_Birthday
                    Return "عيد ميلاد"
                Case SchedulerStringId.Abbr_Month
                    Return "في الشهر"
                Case SchedulerStringId.MenuCmd_ViewZoomOut
                    Return "التصغير"
                Case SchedulerStringId.MenuCmd_Free
                    Return "آند الحرة"
                Case SchedulerStringId.MenuCmd_AppointmentLabelAnniversary
                    Return "آند الذكرى"
                Case SchedulerStringId.Caption_PrevVisibleResources
                    Return "السابقة"
                Case SchedulerStringId.MenuCmd_GotoDate
                    Return "آند الانتقال إلى تاريخ..."
                Case SchedulerStringId.Caption_Reminders
                    Return "{0} رسائل تذكيرية"
                Case SchedulerStringId.MenuCmd_5Minutes
                    Return "آند 5 دقائق"
                Case SchedulerStringId.Caption_6Minutes
                    Return "6 دقائق"
                Case SchedulerStringId.Caption_NextVisibleResourcesPage
                    Return "الصفحة التالية"
                Case SchedulerStringId.ViewDisplayName_Timeline
                    Return "التقويم الزمني"
                Case SchedulerStringId.TimeScaleDisplayName_Quarter
                    Return "الربع"
                Case SchedulerStringId.Format_TimeBeforeStart
                    Return "{0} قبل البدء"
                Case SchedulerStringId.DescCmd_ViewZoomIn
                    Return "القيام برفع مستوى لعرض المحتوى بمزيد من التفصيل."
                Case SchedulerStringId.MenuCmd_Busy
                    Return "آند مشغول"
                Case SchedulerStringId.TextWeekly_2Day
                    Return "{0} و {1}"
                Case SchedulerStringId.Caption_StartTime
                    Return "وقت البدء: {0}"
                Case SchedulerStringId.MenuCmd_AppointmentLabelPhoneCall
                    Return "مكالمة هاتفية &"
                Case SchedulerStringId.MenuCmd_6Minutes
                    Return "آند 6 دقائق"
                Case SchedulerStringId.Caption_OnScreenResources
                    Return "الموارد التي تظهر على الشاشة"
                Case SchedulerStringId.Caption_10Minutes
                    Return "10 دقائق"
                Case SchedulerStringId.Caption_LastVisibleResources
                    Return "آخر"
                Case SchedulerStringId.ViewDisplayName_FullWeek
                    Return "تقويم أسبوع كامل"
                Case SchedulerStringId.Caption_PleaseSeeAbove
                    Return "الرجاء انظر أعلاه"
                Case SchedulerStringId.DescCmd_ViewZoomOut
                    Return "إجراء تقليص لعرض نظرة أوسع نطاقا من طريقة العرض."
                Case SchedulerStringId.MenuCmd_Tentative
                    Return "آند مؤقت"
                Case SchedulerStringId.MenuCmd_AppointmentMove
                    Return "مو آند ve"
                Case SchedulerStringId.Msg_Conflict
                    Return "تعيين محرر يتعارض مع واحد أو عدة تعيينات أخرى."
                Case SchedulerStringId.TextWeekly_3Day
                    Return "{0} و {1} و {2}"
                Case SchedulerStringId.Caption_NAppointmentsAreSelected
                    Return "يتم تحديد المواعيد {0}"
                Case SchedulerStringId.Caption_GroupByNone
                    Return "لا شيء"
                Case SchedulerStringId.Caption_15Minutes
                    Return "مدة 15 دقيقة"
                Case SchedulerStringId.Caption_IncreaseVisibleResourcesCount
                    Return "زيادة عدد الموارد مرئية"
                Case SchedulerStringId.MenuCmd_10Minutes
                    Return "10 آند دقيقة"
                Case SchedulerStringId.ViewDisplayName_Gantt
                    Return "طريقة عرض جانت"
                Case SchedulerStringId.Caption_RecurrenceSubject
                    Return "الموضوع:"
                Case SchedulerStringId.DescCmd_SplitAppointment
                    Return "تقسيم الموعد المحدد في اثنين بواسطة سحب خط تقسيم."
                Case SchedulerStringId.TextAppointmentSnapToCells_Always
                    Return "دائماً"
                Case SchedulerStringId.MenuCmd_OutOfOffice
                    Return "آند خارج المكتب"
                Case SchedulerStringId.MenuCmd_AppointmentCopy
                    Return "آند نسخة"
                Case SchedulerStringId.Msg_InvalidAppointmentDuration
                    Return "تحديد مدة الفاصل الزمني لقيمة غير صالحة. الرجاء إدخال قيمة إيجابية."
                Case SchedulerStringId.TextWeekly_4Day
                    Return "{0} {1}، {2} و {3}"
                Case SchedulerStringId.Caption_GroupByDate
                    Return "تاريخ"
                Case SchedulerStringId.Caption_20Minutes
                    Return "20 دقيقة"
                Case SchedulerStringId.Caption_MemoPrintStyle
                    Return "نمط المذكرة"
                Case SchedulerStringId.Caption_DecreaseVisibleResourcesCount
                    Return "إنقاص عدد الموارد مرئية"
                Case SchedulerStringId.MenuCmd_15Minutes
                    Return "آند 15 دقيقة"
                Case SchedulerStringId.ViewDisplayName_Agenda
                    Return "جدول التقويم"
                Case SchedulerStringId.Caption_SplitAppointment
                    Return "انقسام"
                Case SchedulerStringId.MenuCmd_WorkingElsewhere
                    Return "آند العمل في مكان آخر"
                Case SchedulerStringId.MenuCmd_AppointmentCancel
                    Return "ج & انسيل"
                Case SchedulerStringId.Caption_RecurrenceLocation
                    Return "الموقع:"
                Case SchedulerStringId.TextAppointmentSnapToCells_Auto
                    Return "تلقائي"
                Case SchedulerStringId.Msg_InvalidReminderTimeBeforeStart
                    Return "قيمة غير صالحة قبل وقت تذكير الحدث. الرجاء إدخال قيمة إيجابية."
                Case SchedulerStringId.Caption_GroupByResources
                    Return "الموارد"
                Case SchedulerStringId.Caption_30Minutes
                    Return "30 دقيقة"
                Case SchedulerStringId.Caption_ShadingApplyToAllDayArea
                    Return "كل يوم المنطقة"
                Case SchedulerStringId.TextWeekly_5Day
                    Return "{0} {1}، {2}، {3} و {4}"
                Case SchedulerStringId.Caption_ColorConverterFullColor
                    Return "لون كامل"
                Case SchedulerStringId.VS_SchedulerReportsToolboxCategoryName
                    Return "DX. {0}: جدولة التقارير"
                Case SchedulerStringId.MenuCmd_LabelAs
                    Return "آند التسمية"
                Case SchedulerStringId.PrintRangeControlInvalidDate
                    Return "يجب أن يكون تاريخ الانتهاء أكبر أو مساوياً لتاريخ البدء"
                Case SchedulerStringId.Msg_InvalidInputFile
                    Return "ملف الإدخال غير صالح"
                Case SchedulerStringId.ViewShortDisplayName_Day
                    Return "اليوم"
                Case SchedulerStringId.Caption_RecurrenceStartTime
                    Return "البدء:"
                Case SchedulerStringId.TextAppointmentSnapToCells_Disabled
                    Return "ذوي"
                Case SchedulerStringId.TextDuration_FromTo
                    Return "من {0} إلى {1}"
                Case SchedulerStringId.Msg_MissingRequiredMapping
                    Return "تعيين الخاصية '{0}' مطلوب مفقود."
                Case SchedulerStringId.Caption_60Minutes
                    Return "60 دقيقة"
                Case SchedulerStringId.Caption_ShadingApplyToAppointments
                    Return "التعيينات"
                Case SchedulerStringId.TextWeekly_6Day
                    Return "{0} {1}، {2}، {3}، {4} و {5}"
                Case SchedulerStringId.Caption_ColorConverterGrayScale
                    Return "تدرج الرمادي"
                Case SchedulerStringId.Caption_SetupResourceMappings
                    Return "إعداد تعيينات الموارد"
                Case SchedulerStringId.UD_SchedulerReportsToolboxCategoryName
                    Return "جدولة عناصر التحكم"
                Case SchedulerStringId.ViewShortDisplayName_WorkDays
                    Return "أسبوع العمل"
                Case SchedulerStringId.DescCmd_LabelAs
                    Return "تغيير تسمية الموعد المحدد."
                Case SchedulerStringId.TextRecurrenceTypeDaily
                    Return "اليومية"
                Case SchedulerStringId.Caption_RecurrenceEndTime
                    Return "نهاية:"
                Case SchedulerStringId.TextAppointmentSnapToCells_Never
                    Return "ابدأ"
                Case SchedulerStringId.TextDuration_FromForDays
                    Return "من {0} {1} "
                Case SchedulerStringId.Msg_MissingMappingMember
                    Return "مفقود '{1}' عضو تعيين الخاصية '{0}'."
                Case SchedulerStringId.Caption_Free
                    Return "مجاناً"
                Case SchedulerStringId.Caption_ShadingApplyToAppointmentStatuses
                    Return "حالات التعيين"
                Case SchedulerStringId.TextWeekly_7Day
                    Return "{0} {1}، {2}، {3}، {4}، {5} و {6}"
                Case SchedulerStringId.Caption_ColorConverterBlackAndWhite
                    Return "أسود وأبيض"
                Case SchedulerStringId.Caption_SetupDependencyMappings
                    Return "إعداد تعيينات التبعية"
                Case SchedulerStringId.ViewShortDisplayName_Week
                    Return "الأسبوع"
                Case SchedulerStringId.Reporting_NotAssigned_TimeCells
                    Return "لم يتم تعيين التحكم تيميسيلس المطلوب"
                Case SchedulerStringId.MenuCmd_AppointmentLabelNone
                    Return "آند بلا"
                Case SchedulerStringId.TextRecurrenceTypeWeekly
                    Return "التنزيلات"
                Case SchedulerStringId.Caption_RecurrenceShowTimeAs
                    Return "إظهار الوقت بصيغة:"
                Case SchedulerStringId.MenuCmd_PrintPreview
                    Return "معاينة قبل الطباعة &"
                Case SchedulerStringId.TextDuration_FromForDaysHours
                    Return "من {0} ل {1} {2}"
                Case SchedulerStringId.Msg_DuplicateMappingMember
                    Return "العضو '{0}' رسم الخرائط ليست فريدة من نوعها: "
                Case SchedulerStringId.Caption_Busy
                    Return "مشغول"
                Case SchedulerStringId.Caption_ShadingApplyToHeaders
                    Return "رؤوس"
                Case SchedulerStringId.TextWeeklyPatternString_EveryWeek
                    Return "كل {3} {0}"
                Case SchedulerStringId.Caption_ResourceNone
                    Return "(بلا)"
                Case SchedulerStringId.Caption_ModifyAppointmentMappingsTransactionDescription
                    Return "تعديل تعيين تعيينات"
                Case SchedulerStringId.Reporting_NotAssigned_View
                    Return "لم يتم تعيين المكون العرض المطلوب"
                Case SchedulerStringId.Caption_WeekViewDescription
                    Return "قم بالتبديل إلى طريقة عرض الأسبوع. ترتيب مواعيد لأسبوع معين في نموذج مضغوط."
                Case SchedulerStringId.ViewShortDisplayName_Month
                    Return "في الشهر"
                Case SchedulerStringId.MenuCmd_AppointmentLabelImportant
                    Return "آند هامة"
                Case SchedulerStringId.Caption_Recurrence
                    Return "التكرار:"
                Case SchedulerStringId.DescCmd_PrintPreview
                    Return "معاينة وإجراء التغييرات على الصفحات قبل الطباعة."
                Case SchedulerStringId.TextRecurrenceTypeMonthly
                    Return "الشهري"
                Case SchedulerStringId.TextDuration_FromForDaysMinutes
                    Return "من {0} ل {1} {3}"
                Case SchedulerStringId.Msg_InconsistentRecurrenceInfoMapping
                    Return "ولدعم تكرار يجب عليك تعيين كلا من ريكورينسينفو ونوع الأعضاء."
                Case SchedulerStringId.Caption_Tentative
                    Return "مؤقت"
                Case SchedulerStringId.TextWeeklyPatternString_EveryWeeks
                    Return "كل {1} {2} على {3} {0}"
                Case SchedulerStringId.Caption_ResourceAll
                    Return "(الكل)"
                Case SchedulerStringId.Caption_ShadingApplyToTimeRulers
                    Return "حكام الوقت"
                Case SchedulerStringId.Caption_ModifyResourceMappingsTransactionDescription
                    Return "تعديل تعيينات الموارد"
                Case SchedulerStringId.ViewShortDisplayName_Timeline
                    Return "الجدول الزمني"
                Case SchedulerStringId.Caption_RecurrencePattern
                    Return "نمط التكرار:"
                Case SchedulerStringId.Msg_RecurrenceExceptionsWillBeLost
                    Return "ستفقد أية استثناءات مقترنة بهذا الموعد المتكرر. هل تريد المتابعة؟"
                Case SchedulerStringId.MenuCmd_Print
                    Return "طباعة سريعة"
                Case SchedulerStringId.DescCmd_Print
                    Return "إرسال الجدول الزمني مباشرة إلى الطابعة الافتراضية دون إجراء تغييرات."
                Case SchedulerStringId.TextDuration_FromForDaysHoursMinutes
                    Return "من {0} ل {1} {2} {3}"
                Case SchedulerStringId.MenuCmd_AppointmentLabelBusiness
                    Return "آند الأعمال"
                Case SchedulerStringId.TextMonthlyPatternString_SubPattern
                    Return "لكل {0} {1} {2}"
                Case SchedulerStringId.TextRecurrenceTypeYearly
                    Return "سنوياً"
                Case SchedulerStringId.PrintPageSetupFormatTabControlCustomizeShading
                    Return "<Customize...></Customize...>"
                Case SchedulerStringId.Caption_WorkingElsewhere
                    Return "العمل في مكان آخر"
                Case SchedulerStringId.Caption_ModifyAppointmentDependencyMappingsTransactionDescription
                    Return "تعديل تعيين تبعية تعيينات"
                Case SchedulerStringId.ViewShortDisplayName_FullWeek
                    Return "أسبوع كامل"
                Case SchedulerStringId.Msg_MappingsCheckPassedOk
                    Return "التعيينات الصحيحة!"
                Case SchedulerStringId.Caption_ShadingApplyToCells
                    Return "الخلايا"
                Case SchedulerStringId.Caption_NoneRecurrence
                    Return "(بلا)"
                Case SchedulerStringId.DescCmd_CreateAppointmentDependency
                    Return "إنشاء تبعية بين المواعيد"
                Case SchedulerStringId.MenuCmd_PrintPageSetup
                    Return "إعداد الصفحة &"
                Case SchedulerStringId.DescCmd_PrintPageSetup
                    Return "تخصيص مظهر الصفحة وتكوين خيارات الطباعة المختلفة."
                Case SchedulerStringId.MenuCmd_AppointmentLabelPersonal
                    Return "آند الشخصية"
                Case SchedulerStringId.DescCmd_TimeScalesMenu
                    Return "تغيير مقياس الوقت."
                Case SchedulerStringId.TextDuration_ForPattern
                    Return "{0} {1}"
                Case SchedulerStringId.TextRecurrenceTypeMinutely
                    Return "دقة"
                Case SchedulerStringId.Caption_OutOfOffice
                    Return "خارج المكتب"
                Case SchedulerStringId.TextMonthlyPatternString1
                    Return "يوم {3} {0}"
                Case SchedulerStringId.PrintPageSetupFormatTabControlSizeAndFontName
                    Return "بنط {0} {1}"
                Case SchedulerStringId.Caption_SetupAppointmentMappings
                    Return "الإعداد تعيين تعيينات"
                Case SchedulerStringId.Caption_MappingsValidation
                    Return "التحقق من صحة التعيينات"
                Case SchedulerStringId.ViewShortDisplayName_Gantt
                    Return "مخطط جانت"
                Case SchedulerStringId.MemoPrintDateFormat
                    Return "{0} {1} {2}"
                Case SchedulerStringId.Msg_InvalidSize
                    Return "المحدد للحجم قيمة غير صالحة."
                Case SchedulerStringId.MenuCmd_CreateAppointmentDependency
                    Return "إنشاء تبعية"
                Case SchedulerStringId.DescCmd_ToggleRecurrence
                    Return "تكرار الموعد المحدد، أو تحرير نمط التكرار. "
                Case SchedulerStringId.DescCmd_ChangeTimelineScaleWidth
                    Return "تعيين عرض العمود بالبكسل لجدول المرتبات الأساسية."
                Case SchedulerStringId.MenuCmd_AppointmentLabelVacation
                    Return "آند عطلة"
                Case SchedulerStringId.TextRecurrenceTypeHourly
                    Return "كل ساعة"
                Case SchedulerStringId.MenuCmd_ShowWorkTimeOnly
                    Return "ساعات العمل"
                Case SchedulerStringId.TextDailyPatternString_EveryDay
                    Return "كل {0} {1}"
                Case SchedulerStringId.ViewDisplayName_Day
                    Return "يوم التقويم"
                Case SchedulerStringId.TextMonthlyPatternString2
                    Return "{1} {2} {0}"
                Case SchedulerStringId.MenuCmd_OpenSchedule
                    Return "فتح"
                Case SchedulerStringId.Caption_MappingsWizard
                    Return "تعيينات معالج..."
                Case SchedulerStringId.Msg_SaveBeforeClose
                    Return "هل تريد حفظ التغييرات التي أجريتها؟"
                Case SchedulerStringId.Msg_ApplyToAllStyles
                    Return "تنطبق إعدادات الطابعة الحالية على كافة الأنماط؟"
                Case SchedulerStringId.ViewShortDisplayName_Agenda
                    Return "جدول الأعمال"
                Case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToStart
                    Return "انتهاء-إلى-بدء (خ)"
                Case SchedulerStringId.Caption_EmptyResource
                    Return "(أي)"
                Case SchedulerStringId.MenuCmd_ChangeTimelineScaleWidth
                    Return "عرض الجدول"
                Case SchedulerStringId.MenuCmd_ChangeAppointmentReminderUI
                    Return "تذكير"
                Case SchedulerStringId.MenuCmd_AppointmentLabelMustAttend
                    Return "يجب أن آند حضور"
                Case SchedulerStringId.Msg_Warning
                    Return "تحذير!"
                Case SchedulerStringId.DescCmd_ShowWorkTimeOnly
                    Return "إظهار ساعات العمل فقط في التقويم."
                Case SchedulerStringId.TextDailyPatternString_EveryDays
                    Return "كل {0} {1} {2}"
                Case SchedulerStringId.TextYearlyPattern_YearString1
                    Return "كل {3} {4} {0}"
                Case SchedulerStringId.ViewDisplayName_WorkDays
                    Return "تقويم أسبوع العمل"
                Case SchedulerStringId.String_to
                    Return "إلى"
                Case SchedulerStringId.DescCmd_OpenSchedule
                    Return "استيراد جدول من ملف (.ics)."
                Case SchedulerStringId.Caption_CheckMappings
                    Return "تعيينات الاختيار"
                Case SchedulerStringId.Msg_MemoPrintNoSelectedItems
                    Return "لا يمكن طباعة ما لم يتم تحديد عنصر. تحديد عنصر، ومن ثم حاول الطباعة مرة أخرى."
                Case SchedulerStringId.TimeScaleDisplayName_Hour
                    Return "ساعة"
                Case SchedulerStringId.Caption_AppointmentDependencyTypeStartToStart
                    Return "بدء-إلى-بدء (SS)"
                Case SchedulerStringId.DescCmd_ChangeAppointmentReminderUI
                    Return "اختيار متى يتم تذكيرك الموعد المحدد."
                Case SchedulerStringId.Caption_DailyPrintStyle
                    Return "نمط يومي"
                Case SchedulerStringId.MenuCmd_CompressWeekend
                    Return "ضغط في نهاية الأسبوع"
                Case SchedulerStringId.TextDailyPatternString_EveryWeekDay
                    Return "كل يوم من أيام الأسبوع {0}"
                Case SchedulerStringId.Msg_CantFitIntoPage
                    Return "من المستحيل أن تناسب إخراج الطباعة باستخدام الإعدادات الحالية لطباعة صفحة واحدة. الرجاء محاولة زيادة ارتفاع الصفحة أو تقليل الفاصل الزمني برينتيمي."
                Case SchedulerStringId.ViewDisplayName_Week
                    Return "تقويم أسبوع"
                Case SchedulerStringId.MenuCmd_SaveSchedule
                    Return "حفظ"
                Case SchedulerStringId.TextYearlyPattern_YearString2
                    Return "{6} {5} {3} {0}"
                Case SchedulerStringId.Caption_SetupAppointmentStorage
                    Return "الإعداد تعيين مخزن"
                Case SchedulerStringId.TimeScaleDisplayName_Day
                    Return "اليوم"
                Case SchedulerStringId.Caption_AllResources
                    Return "جميع الموارد"
                Case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToFinish
                    Return "انتهاء-إلى-انتهاء (FF)"
                Case SchedulerStringId.Caption_NoneReminder
                    Return "لا شيء"
                Case SchedulerStringId.Caption_WeeklyPrintStyle
                    Return "نمط أسبوعي"
                Case SchedulerStringId.DescCmd_CompressWeekend
                    Return "إظهار يومي السبت والأحد مضغوطة في عمود واحد."
                Case SchedulerStringId.TextDailyPatternString_EveryWeekend
                    Return "كل نهاية الأسبوع {0}"
                Case SchedulerStringId.Msg_PrintStyleNameExists
                    Return "اسم النمط '{0}' موجود بالفعل. اكتب اسماً آخر."
                Case SchedulerStringId.ViewDisplayName_Month
                    Return "تقويم الشهر"
                Case SchedulerStringId.TextYearlyPattern_YearsString1
                    Return "{4} {3} من كل {0} {1} {2}"
                Case SchedulerStringId.DescCmd_SaveSchedule
                    Return "حفظ جدول إلى ملف (.ics)."
                Case SchedulerStringId.Caption_VisibleResources
                    Return "الموارد مرئية"
                Case SchedulerStringId.Caption_SetupResourceStorage
                    Return "إعداد مورد تخزين"
                Case SchedulerStringId.TimeScaleDisplayName_Week
                    Return "الأسبوع"
                Case SchedulerStringId.Caption_AppointmentDependencyTypeStartToFinish
                    Return "بدء-إلى-انتهاء (SF)"
                Case SchedulerStringId.Caption_MonthlyPrintStyle
                    Return "نمط شهري"
                Case SchedulerStringId.Msg_OutlookCalendarNotFound
                    Return "لم يتم العثور على التقويم '{0}'."
                Case SchedulerStringId.TextYearlyPattern_YearsString2
                    Return "{6} {5} من {3} كل {0} {1} {2}"
                Case SchedulerStringId.MenuCmd_ChangeSnapToCellsUI
                    Return "انجذاب إلى الخلايا"
                Case SchedulerStringId.MenuCmd_CellsAutoHeight
                    Return "ارتفاع السيارات الخلية"
                Case SchedulerStringId.Caption_TrifoldPrintStyle
                    Return "نمط ثلاثي إضعاف"
                Case SchedulerStringId.TextWeekly_0Day
                    Return "يوم غير محدد في الأسبوع"
                Case SchedulerStringId.Caption_PrevAppointment
                    Return "الموعد السابق"
                Case SchedulerStringId.Caption_SetupAppointmentDependencyStorage
                    Return "إعداد تبعية التخزين"
                Case SchedulerStringId.Caption_AllDay
                    Return "كل يوم"
                Case SchedulerStringId.TimeScaleDisplayName_Month
                    Return "في الشهر"
                Case SchedulerStringId.DescCmd_ChangeSnapToCellsUI
                    Return "تحديد وضع أطباق لعرض التعيينات داخل خلايا الوقت."
                Case SchedulerStringId.Caption_CalendarDetailsPrintStyle
                    Return "نمط تفاصيل التقويم"
                Case SchedulerStringId.Caption_NextAppointment
                    Return "الموعد التالي"
                Case SchedulerStringId.DescCmd_CellsAutoHeight
                    Return "تمكين خلية وقت تلقائياً ضبط حجمه لاستيعاب المواعيد يحتوي على."
                Case SchedulerStringId.TextWeekly_1Day
                    Return "{0}"
                Case SchedulerStringId.Caption_ModifyAppointmentStorageTransactionDescription
                    Return "تعديل تعيين مخزن"
                Case SchedulerStringId.MenuCmd_OpenOccurrence
                    Return "حدوث مفتوحة"
                Case SchedulerStringId.MenuCmd_ToggleRecurrence
                    Return "تكرار"
                Case SchedulerStringId.DisplayName_Appointment
                    Return "تعيين"
                Case SchedulerStringId.Caption_ModifyResourceStorageTransactionDescription
                    Return "تعديل مخزن الموارد"
                Case SchedulerStringId.DescCmd_OpenOccurrence
                    Return "فتح هذا التكرار الاجتماع."
                Case SchedulerStringId.Format_CopyOf
                    Return "نسخ {0}"
                Case SchedulerStringId.MenuCmd_OpenSeries
                    Return "سلسلة مفتوحة"
                Case SchedulerStringId.Caption_ModifyAppointmentDependencyStorageTransactionDescription
                    Return "تعديل مخزن أبوينتمينتديبيندينسي"
                Case SchedulerStringId.DescCmd_OpenSeries
                    Return "وهذا فتح سلسلة الاجتماعات."
                Case SchedulerStringId.Format_CopyNOf
                    Return "نسخة ({0}) {1}"
                Case SchedulerStringId.MenuCmd_DeleteOccurrence
                    Return "حذف التكرار"
                Case SchedulerStringId.Caption_DayViewDescription
                    Return "قم بالتبديل إلى طريقة عرض اليوم. العرض الأكثر تفصيلاً التعيينات أيام محددة."
                Case SchedulerStringId.DescCmd_DeleteOccurrence
                    Return "حذف التكرار."
                Case SchedulerStringId.MenuCmd_DeleteSeries
                    Return "حذف السلسلة"
                Case SchedulerStringId.DescCmd_DeleteSeries
                    Return "حذف سلسلة."
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
    Public Class HebrewSchedulerLocalizer
        Inherits SchedulerLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As SchedulerStringId) As String
            Select Case id
                Case SchedulerStringId.AppointmentLabel_Anniversary
                    Return "יום השנה"
                Case SchedulerStringId.Msg_IsNotValid
                    Return "'{0}' אינו ערך חוקי עבור '{1}'"
                Case SchedulerStringId.Caption_MonthViewDescription
                    Return "החלפה לתצוגה חודש (רב-שבועי). תצוגת לוח התאריכים שימושי עבור תוכניות ארוכות טווח."
                Case SchedulerStringId.MenuCmd_20Minutes
                    Return "& 20 דקות"
                Case SchedulerStringId.TimeScaleDisplayName_Year
                    Return "השנה"
                Case SchedulerStringId.Appointment_StartContinueText
                    Return "מ- {0}"
                Case SchedulerStringId.AppointmentLabel_PhoneCall
                    Return "שיחת טלפון"
                Case SchedulerStringId.Appointment_EndContinueText
                    Return "{0}"
                Case SchedulerStringId.Caption_TimelineViewDescription
                    Return "לעבור תצוגת ציר הזמן. חלקות פגישות ביחס לזמן."
                Case SchedulerStringId.Msg_InvalidDayOfWeekForDailyRecurrence
                    Return "לא חוקי יום בשבוע להישנות מדי יום. רק WeekDays.EveryDay, WeekDays.WeekendDays, WeekDays.WorkDays תקפים בהקשר זה."
                Case SchedulerStringId.DefaultToolTipStringFormat_SplitAppointment
                    Return "{0}: צעד {1}"
                Case SchedulerStringId.PrintCalendarDetailsControlDayPeriod
                    Return "היום"
                Case SchedulerStringId.MenuCmd_30Minutes
                    Return "& 30 דקות"
                Case SchedulerStringId.Abbr_MinutesShort1
                    Return "m"
                Case SchedulerStringId.Msg_InvalidWeekCountValue
                    Return "ספירת שבוע לא חוקי. נא הזן ערך מספר שלם חיובי."
                Case SchedulerStringId.Msg_InvalidDayCountValue
                    Return "ספירת היום לא חוקי. נא הזן ערך מספר שלם חיובי."
                Case SchedulerStringId.Msg_InternalError
                    Return "שגיאה פנימית!"
                Case SchedulerStringId.Msg_InvalidYearCountValue
                    Return "ספירת בן לא חוקי. נא הזן ערך מספר שלם חיובי."
                Case SchedulerStringId.Msg_InvalidEndDate
                    Return "התאריך שהזנת מתרחש לפני תאריך ההתחלה."
                Case SchedulerStringId.Caption_FullWeekViewDescription
                    Return "החלפה לתצוגה שבוע מלא. סידור פגישות לשבוע מסוים בצורה קומפקטית."
                Case SchedulerStringId.MenuCmd_60Minutes
                    Return "6 & 10 דקות"
                Case SchedulerStringId.PrintCalendarDetailsControlWeekPeriod
                    Return "השבוע"
                Case SchedulerStringId.Msg_InvalidWeekCount
                    Return "ספירת שבוע לא חוקי. נא הזן ערך מספר שלם חיובי."
                Case SchedulerStringId.Msg_XtraSchedulerNotAssigned
                    Return "הרכיב SchedulerStorage לא הוקצו את SchedulerControl"
                Case SchedulerStringId.Abbr_MinutesShort2
                    Return "min"
                Case SchedulerStringId.Msg_InvalidMonthCount
                    Return "לספור חודש לא חוקי. נא הזן ערך מספר שלם חיובי."
                Case SchedulerStringId.Caption_Appointment
                    Return "{0} - פעילות"
                Case SchedulerStringId.Msg_InvalidOccurrencesCount
                    Return "ספירת מופעים לא חוקי. נא הזן ערך מספר שלם חיובי."
                Case SchedulerStringId.PrintCalendarDetailsControlMonthPeriod
                    Return "חודש"
                Case SchedulerStringId.Msg_InvalidOccurrencesCountValue
                    Return "ספירת מופעים לא חוקי. נא הזן ערך מספר שלם חיובי."
                Case SchedulerStringId.Caption_GanttViewDescription
                    Return "לעבור בתצוגה ' גנט '. ניהול פרויקט תצוגה המציג פגישות והתלויות ביחס לזמן."
                Case SchedulerStringId.MenuCmd_SwitchViewMenu
                    Return "לשנות את התצוגה כך"
                Case SchedulerStringId.Msg_InvalidTimeOfDayInterval
                    Return "לא חוקי משך TimeOfDayInterval"
                Case SchedulerStringId.Abbr_Minute
                    Return "דקה"
                Case SchedulerStringId.Msg_InvalidDayOfWeek
                    Return "אין היום הנבחר. נא בחר לפחות יום אחד בשבוע."
                Case SchedulerStringId.Msg_InvalidMonthCountValue
                    Return "לספור חודש לא חוקי. נא הזן ערך מספר שלם חיובי."
                Case SchedulerStringId.Caption_Event
                    Return "{0} - אירוע"
                Case SchedulerStringId.Msg_InvalidDayNumber
                    Return "מספר יום לא חוקי. נא הזן ערך של מספר שלם בין 1 ל {0}."
                Case SchedulerStringId.Caption_AgendaViewDescription
                    Return "עבור לתצוגת סדר היום. מציג רשימה של אירועים עתידיים"
                Case SchedulerStringId.PrintMonthlyOptControlOnePagePerMonth
                    Return "1 עמוד לחודש"
                Case SchedulerStringId.Msg_OverflowTimeOfDayInterval
                    Return "ערך לא חוקי עבור TimeOfDayInterval. צריך להיות קטן או שווה ליום"
                Case SchedulerStringId.MenuCmd_SwitchToDayView
                    Return "& תצוגת ' יום '"
                Case SchedulerStringId.Abbr_Minutes
                    Return "דקות"
                Case SchedulerStringId.Msg_WarningAppointmentDeleted
                    Return "הפעילות נמחק על-ידי משתמש אחר."
                Case SchedulerStringId.Msg_InvalidDayNumberValue
                    Return "מספר יום לא חוקי. נא הזן ערך של מספר שלם בין 1 ל {0}."
                Case SchedulerStringId.Msg_InvalidYearCount
                    Return "ספירת בן לא חוקי. נא הזן ערך מספר שלם חיובי."
                Case SchedulerStringId.PrintMonthlyOptControlTwoPagesPerMonth
                    Return "2 עמודים לחודש"
                Case SchedulerStringId.Caption_UntitledAppointment
                    Return "ללא כותרת"
                Case SchedulerStringId.Caption_GroupByNoneDescription
                    Return "ביטול קיבוץ של פעילויות."
                Case SchedulerStringId.MenuCmd_SwitchToWorkWeekView
                    Return "Wo & rk תצוגת שבוע"
                Case SchedulerStringId.Msg_LoadCollectionFromXml
                    Return "מתזמן המשימות צריך להיות במצב לא מאוגדת כדי לטעון את אוסף הפריטים מ- xml"
                Case SchedulerStringId.MenuCmd_OpenAppointment
                    Return "& פתוח"
                Case SchedulerStringId.Abbr_HoursShort
                    Return "h"
                Case SchedulerStringId.DescCmd_OpenAppointment
                    Return "פתח את הפעילות שנבחרה."
                Case SchedulerStringId.Msg_WarningDayNumber
                    Return "כמה חודשים יש פחות מ- {0} ימים. חודשים אלה, המופעים תיפול ביום האחרון של החודש."
                Case SchedulerStringId.Caption_ReadOnly
                    Return " [לקריאה בלבד]"
                Case SchedulerStringId.PrintTimeIntervalControlInvalidDuration
                    Return "המשך להיות לא גדול יותר יום יותר מ 0"
                Case SchedulerStringId.AppointmentLabel_None
                    Return "אף אחד"
                Case SchedulerStringId.Caption_GroupByDateDescription
                    Return "פגישות הקבוצה לפי תאריך."
                Case SchedulerStringId.MenuCmd_SwitchToWeekView
                    Return "& תצוגת שבוע"
                Case SchedulerStringId.Abbr_Hour
                    Return "שעה"
                Case SchedulerStringId.MenuCmd_NewAllDayEvent
                    Return "חדש כל יום & האירוע"
                Case SchedulerStringId.MenuCmd_GotoThisDay
                    Return ". לך זה & היום"
                Case SchedulerStringId.PrintTimeIntervalControlInvalidStartEndTime
                    Return "שעת סיום חייב להיות גדול יותר זמן ההתחלה"
                Case SchedulerStringId.MenuCmd_PrintAppointment
                    Return "& הדפסה"
                Case SchedulerStringId.Caption_WeekDaysEveryDay
                    Return "היום"
                Case SchedulerStringId.Caption_GroupByResourceDescription
                    Return "פגישות הקבוצה על-ידי משאב."
                Case SchedulerStringId.AppointmentLabel_Important
                    Return "חשוב"
                Case SchedulerStringId.MenuCmd_NewRecurringAppointment
                    Return "חוזרת חדשה & תור"
                Case SchedulerStringId.MenuCmd_GotoToday
                    Return "ללכת ל & היום"
                Case SchedulerStringId.MenuCmd_SwitchToMonthView
                    Return "& תצוגת חודש"
                Case SchedulerStringId.Abbr_Hours
                    Return "שעות"
                Case SchedulerStringId.MenuCmd_DeleteAppointment
                    Return "& מחק"
                Case SchedulerStringId.PrintTriFoldOptControlDailyCalendar
                    Return "את לוח השנה היומי"
                Case SchedulerStringId.AppointmentLabel_Business
                    Return "עסקים"
                Case SchedulerStringId.Caption_WeekDaysWeekendDays
                    Return "היום בסוף השבוע"
                Case SchedulerStringId.DescCmd_NewRecurringAppointment
                    Return "צור פעילות מחזורית חדשה."
                Case SchedulerStringId.Msg_iCalendar_NotValidFile
                    Return "קובץ לוח שנה באינטרנט לא חוקי"
                Case SchedulerStringId.MenuCmd_SwitchToTimelineView
                    Return "& תצוגת ציר הזמן"
                Case SchedulerStringId.Abbr_DaysShort
                    Return "d"
                Case SchedulerStringId.DescCmd_DeleteAppointment
                    Return "למחוק את appointment(s) שנבחר."
                Case SchedulerStringId.Caption_WeekDaysWorkDays
                    Return "יום חול"
                Case SchedulerStringId.DescCmd_GotoToday
                    Return "לשנות את התאריך המוצג בתצוגה הנוכחית לתאריך הנוכחי."
                Case SchedulerStringId.PrintTriFoldOptControlWeeklyCalendar
                    Return "לוח שנה שבועי"
                Case SchedulerStringId.AppointmentLabel_Personal
                    Return "אישי"
                Case SchedulerStringId.Msg_iCalendar_AppointmentsImportWarning
                    Return "אין אפשרות לייבא איזושהי פגישה"
                Case SchedulerStringId.MenuCmd_SwitchToFullWeekView
                    Return "& תצוגת שבוע מלא"
                Case SchedulerStringId.Abbr_Day
                    Return "היום"
                Case SchedulerStringId.MenuCmd_NewRecurringEvent
                    Return "מחזורי חדש E & פתח"
                Case SchedulerStringId.MenuCmd_TimeScalesMenu
                    Return "& פרקי זמן"
                Case SchedulerStringId.MenuCmd_GotoDate
                    Return "& ללכת תאריך..."
                Case SchedulerStringId.MenuCmd_EditSeries
                    Return "& עריכת סדרות"
                Case SchedulerStringId.Caption_WeekOfMonthFirst
                    Return "הראשון"
                Case SchedulerStringId.MenuCmd_NavigateBackward
                    Return "לאחור"
                Case SchedulerStringId.PrintTriFoldOptControlMonthlyCalendar
                    Return "לוח שנה חודשי"
                Case SchedulerStringId.AppointmentLabel_Vacation
                    Return "חופשה"
                Case SchedulerStringId.MenuCmd_EditAppointmentDependency
                    Return "& ערוך"
                Case SchedulerStringId.MenuCmd_SwitchToAgendaView
                    Return "& סדר היום תצוגה"
                Case SchedulerStringId.Abbr_Days
                    Return "ימים"
                Case SchedulerStringId.MenuCmd_RestoreOccurrence
                    Return "& שחזור מצב ברירת המחדל"
                Case SchedulerStringId.MenuCmd_TimeScaleCaptionsMenu
                    Return "סרגל זמן & כיתובים"
                Case SchedulerStringId.MenuCmd_OtherSettings
                    Return "אחרים Sett & הפגישות..."
                Case SchedulerStringId.PrintWeeklyOptControlOneWeekPerPage
                    Return "1 עמוד לשבוע"
                Case SchedulerStringId.Caption_WeekOfMonthSecond
                    Return "שנייה"
                Case SchedulerStringId.MenuCmd_NavigateForward
                    Return "קדימה"
                Case SchedulerStringId.MenuCmd_SwitchToGroupByNone
                    Return "& קבוצה על ידי אף אחד"
                Case SchedulerStringId.AppointmentLabel_MustAttend
                    Return "מה אתו?"
                Case SchedulerStringId.DescCmd_EditAppointmentDependency
                    Return "לערוך פגישה תלות."
                Case SchedulerStringId.Abbr_WeeksShort
                    Return "w"
                Case SchedulerStringId.MenuCmd_NewAppointment
                    Return "New App & משחה"
                Case SchedulerStringId.Caption_WeekOfMonthThird
                    Return "שלישי"
                Case SchedulerStringId.MenuCmd_TimeScaleHour
                    Return "& שעה"
                Case SchedulerStringId.MenuCmd_CustomizeCurrentView
                    Return "& התאמה אישית של תצוגה נוכחית."
                Case SchedulerStringId.PrintWeeklyOptControlTwoWeekPerPage
                    Return "2 עמודים לשבוע"
                Case SchedulerStringId.DescCmd_NavigateBackward
                    Return "צעדו אחורה בזמן כפי שהוצע על ידי התצוגה הנוכחית."
                Case SchedulerStringId.MenuCmd_SwitchToGroupByResource
                    Return "& קבוצה על-ידי משאב"
                Case SchedulerStringId.AppointmentLabel_TravelRequired
                    Return "נסיעות חובה"
                Case SchedulerStringId.Abbr_Week
                    Return "השבוע"
                Case SchedulerStringId.MenuCmd_DeleteAppointmentDependency
                    Return "& מחק"
                Case SchedulerStringId.MenuCmd_TimeScaleDay
                    Return "& יום"
                Case SchedulerStringId.DescCmd_NewAppointment
                    Return "צור פעילות חדשה."
                Case SchedulerStringId.Caption_WeekOfMonthFourth
                    Return "הרביעי"
                Case SchedulerStringId.MenuCmd_CustomizeTimeRuler
                    Return "התאמה אישית של סרגל זמן..."
                Case SchedulerStringId.PrintPageSetupFormCaption
                    Return "אפשרויות הדפסה: {0}"
                Case SchedulerStringId.AppointmentLabel_NeedsPreparation
                    Return "צריך הכנה"
                Case SchedulerStringId.DescCmd_NavigateForward
                    Return "להתקדם קדימה בזמן כפי שהוצע על ידי התצוגה הנוכחית."
                Case SchedulerStringId.MenuCmd_SwitchToGroupByDate
                    Return "& קבוצה לפי תאריך"
                Case SchedulerStringId.Abbr_Weeks
                    Return "שבועות"
                Case SchedulerStringId.DescCmd_DeleteAppointmentDependency
                    Return "מחיקת הפעילות תלות."
                Case SchedulerStringId.MenuCmd_TimeScaleWeek
                    Return "& שבוע"
                Case SchedulerStringId.MenuCmd_5Minutes
                    Return "& 5 דקות"
                Case SchedulerStringId.Caption_WeekOfMonthLast
                    Return "אחרונה"
                Case SchedulerStringId.MenuCmd_ViewZoomIn
                    Return "התקרבות"
                Case SchedulerStringId.PrintMoreItemsMsg
                    Return "עוד פריטים..."
                Case SchedulerStringId.AppointmentLabel_Birthday
                    Return "יום הולדת"
                Case SchedulerStringId.MenuCmd_SwitchToGanttView
                    Return "& תצוגת גנט"
                Case SchedulerStringId.MenuCmd_TimeScaleYear
                    Return "& שנה"
                Case SchedulerStringId.Abbr_Month
                    Return "חודש"
                Case SchedulerStringId.MenuCmd_10Minutes
                    Return "10 & דקות"
                Case SchedulerStringId.MenuCmd_TimeScaleMonth
                    Return "& החודש"
                Case SchedulerStringId.Msg_InvalidDayCount
                    Return "ספירת היום לא חוקי. נא הזן ערך מספר שלם חיובי."
                Case SchedulerStringId.MenuCmd_AppointmentLabelTravelRequired
                    Return "& נסיעות חובה"
                Case SchedulerStringId.PrintNoPrintersInstalled
                    Return "לא מותקנות מדפסות"
                Case SchedulerStringId.MenuCmd_ViewZoomOut
                    Return "התרחקות"
                Case SchedulerStringId.ViewShortDisplayName_Timeline
                    Return "ציר הזמן"
                Case SchedulerStringId.Abbr_Months
                    Return "חודשים"
                Case SchedulerStringId.Caption_Busy
                    Return "עסוק"
                Case SchedulerStringId.MenuCmd_ShowTimeAs
                    Return "& הצג זמן כ"
                Case SchedulerStringId.MenuCmd_TimeScaleQuarter
                    Return "& הרובע"
                Case SchedulerStringId.MenuCmd_15Minutes
                    Return "& 15 דקות"
                Case SchedulerStringId.TextDuration_ForPattern
                    Return "{0} {1}"
                Case SchedulerStringId.MenuCmd_AppointmentLabelNeedsPreparation
                    Return "& צריך הכנה"
                Case SchedulerStringId.Caption_FirstVisibleResources
                    Return "הראשון"
                Case SchedulerStringId.DescCmd_ViewZoomIn
                    Return "לבצע שינוי גודל כדי להציג תוכן בפירוט רב יותר."
                Case SchedulerStringId.Caption_Tentative
                    Return "לא סופי"
                Case SchedulerStringId.ViewShortDisplayName_FullWeek
                    Return "שבוע מלא"
                Case SchedulerStringId.Abbr_Year
                    Return "השנה"
                Case SchedulerStringId.DescCmd_ShowTimeAs
                    Return "לשנות את מצב הפעילות שנבחרה."
                Case SchedulerStringId.TextMonthlyPatternString1
                    Return "יום {3} {0}"
                Case SchedulerStringId.Caption_RecurrenceSubject
                    Return "נושא:"
                Case SchedulerStringId.MenuCmd_AppointmentLabelBirthday
                    Return "& יום הולדת"
                Case SchedulerStringId.TextDailyPatternString_EveryDay
                    Return "כל {0} {1}"
                Case SchedulerStringId.DescCmd_ViewZoomOut
                    Return "לבצע להצטמצם כדי להציג מבט רחבה יותר של התצוגה."
                Case SchedulerStringId.Caption_PrevVisibleResourcesPage
                    Return "דף קודמות"
                Case SchedulerStringId.ViewShortDisplayName_Gantt
                    Return "גנט"
                Case SchedulerStringId.Abbr_Years
                    Return "שנים"
                Case SchedulerStringId.Caption_WorkingElsewhere
                    Return "עובד במקום אחר"
                Case SchedulerStringId.Caption_RecurrenceLocation
                    Return "מיקום:"
                Case SchedulerStringId.MenuCmd_Free
                    Return "& חינם"
                Case SchedulerStringId.TextMonthlyPatternString2
                    Return "{1} {2} {0}"
                Case SchedulerStringId.TextDailyPatternString_EveryDays
                    Return "כל {0} {1} {2}"
                Case SchedulerStringId.MenuCmd_AppointmentLabelAnniversary
                    Return "& השנה"
                Case SchedulerStringId.Caption_PrevVisibleResources
                    Return "הקודם"
                Case SchedulerStringId.DescCmd_SplitAppointment
                    Return "לפצל את הפעילות שנבחרה לשניים על-ידי גרירת קו הפיצול."
                Case SchedulerStringId.ViewShortDisplayName_Agenda
                    Return "סדר היום"
                Case SchedulerStringId.Caption_Reminder
                    Return "{0} תזכורת"
                Case SchedulerStringId.Caption_OutOfOffice
                    Return "מחוץ למשרד"
                Case SchedulerStringId.MenuCmd_Busy
                    Return "& עמוס"
                Case SchedulerStringId.TextYearlyPattern_YearString1
                    Return "כל {0} {4} {3}"
                Case SchedulerStringId.Caption_RecurrenceStartTime
                    Return "התחל:"
                Case SchedulerStringId.Caption_ColorConverterFullColor
                    Return "צבע מלא"
                Case SchedulerStringId.MenuCmd_AppointmentLabelPhoneCall
                    Return "טלפון &"
                Case SchedulerStringId.Caption_NextVisibleResources
                    Return "הבא"
                Case SchedulerStringId.TextDailyPatternString_EveryWeekDay
                    Return "{0} בכל יום בשבוע"
                Case SchedulerStringId.ViewDisplayName_Day
                    Return "יום השנה"
                Case SchedulerStringId.Caption_SplitAppointment
                    Return "פיצול"
                Case SchedulerStringId.TimeScaleDisplayName_Hour
                    Return "שעה"
                Case SchedulerStringId.MenuCmd_Tentative
                    Return "& סופי"
                Case SchedulerStringId.Caption_Reminders
                    Return "{0} תזכורות"
                Case SchedulerStringId.Caption_RecurrenceEndTime
                    Return "סוף:"
                Case SchedulerStringId.TextYearlyPattern_YearString2
                    Return "{6} {5} {0} {3}"
                Case SchedulerStringId.MenuCmd_AppointmentMove
                    Return "מו & ve"
                Case SchedulerStringId.Caption_ColorConverterGrayScale
                    Return "סולם אפור"
                Case SchedulerStringId.TextDailyPatternString_EveryWeekend
                    Return "{0} כל השבוע"
                Case SchedulerStringId.Caption_NextVisibleResourcesPage
                    Return "דף הבא"
                Case SchedulerStringId.VS_SchedulerReportsToolboxCategoryName
                    Return "DX. {0}: מתזמן דיווח"
                Case SchedulerStringId.TimeScaleDisplayName_Day
                    Return "היום"
                Case SchedulerStringId.ViewDisplayName_WorkDays
                    Return "לוח שנה שבוע עבודה"
                Case SchedulerStringId.MenuCmd_OutOfOffice
                    Return "& מחוץ למשרד"
                Case SchedulerStringId.Caption_StartTime
                    Return "שעת התחלה: {0}"
                Case SchedulerStringId.TextYearlyPattern_YearsString1
                    Return "{3} {4} כל {0} {2} ' {1} '"
                Case SchedulerStringId.Caption_RecurrenceShowTimeAs
                    Return "הצג זמן כ:"
                Case SchedulerStringId.MenuCmd_AppointmentCopy
                    Return "& להעתיק"
                Case SchedulerStringId.Caption_ColorConverterBlackAndWhite
                    Return "שחור-לבן"
                Case SchedulerStringId.Msg_MemoPrintNoSelectedItems
                    Return "אין אפשרות להדפיס אלא אם פריט נבחר. בחר פריט ולאחר מכן לנסות להדפיס שוב."
                Case SchedulerStringId.Caption_LastVisibleResources
                    Return "אחרונה"
                Case SchedulerStringId.ViewDisplayName_Week
                    Return "לוח שנה בשבוע"
                Case SchedulerStringId.TextWeekly_0Day
                    Return "לא צוין יום בשבוע"
                Case SchedulerStringId.UD_SchedulerReportsToolboxCategoryName
                    Return "מתזמן פקדים"
                Case SchedulerStringId.TimeScaleDisplayName_Week
                    Return "השבוע"
                Case SchedulerStringId.MenuCmd_WorkingElsewhere
                    Return "& עובד במקום אחר"
                Case SchedulerStringId.TextYearlyPattern_YearsString2
                    Return "{6} {5} של {3} כל {0} {2} ' {1} '"
                Case SchedulerStringId.MenuCmd_AppointmentCancel
                    Return "C & ancel"
                Case SchedulerStringId.Caption_AllResources
                    Return "כל המשאבים"
                Case SchedulerStringId.Caption_NAppointmentsAreSelected
                    Return "{0} פעילויות נבחרות"
                Case SchedulerStringId.Caption_Recurrence
                    Return "החוזר:"
                Case SchedulerStringId.Caption_ResourceNone
                    Return "(אף אחד)"
                Case SchedulerStringId.Caption_IncreaseVisibleResourcesCount
                    Return "להגדיל את ספירת משאבים גלוי"
                Case SchedulerStringId.ViewDisplayName_Month
                    Return "לוח שנה של חודש"
                Case SchedulerStringId.MenuCmd_LabelAs
                    Return "& תווית בתור"
                Case SchedulerStringId.TextWeekly_1Day
                    Return "{0}"
                Case SchedulerStringId.Reporting_NotAssigned_TimeCells
                    Return "השליטה TimeCells הנדרשים לא מוקצה"
                Case SchedulerStringId.TimeScaleDisplayName_Month
                    Return "חודש"
                Case SchedulerStringId.Caption_AllDay
                    Return "כל היום"
                Case SchedulerStringId.Caption_5Minutes
                    Return "5 דקות"
                Case SchedulerStringId.Caption_VisibleResources
                    Return "משאבים גלוי"
                Case SchedulerStringId.Format_TimeBeforeStart
                    Return "{0} לפני ההתחלה"
                Case SchedulerStringId.Caption_RecurrencePattern
                    Return "תבנית המופע החוזר:"
                Case SchedulerStringId.Caption_ResourceAll
                    Return "(הכל)"
                Case SchedulerStringId.Caption_DecreaseVisibleResourcesCount
                    Return "להקטין את ספירת משאבים גלוי"
                Case SchedulerStringId.ViewDisplayName_Timeline
                    Return "ציר לוח השנה"
                Case SchedulerStringId.DescCmd_LabelAs
                    Return "לשנות את התווית שנבחרו."
                Case SchedulerStringId.TextAppointmentSnapToCells_Always
                    Return "תמיד"
                Case SchedulerStringId.TextWeekly_2Day
                    Return "{0} ו- {1}"
                Case SchedulerStringId.Reporting_NotAssigned_View
                    Return "נדרש רכיב התצוגה אינה מוקצית"
                Case SchedulerStringId.Caption_PleaseSeeAbove
                    Return "נא עיין לעיל"
                Case SchedulerStringId.Caption_6Minutes
                    Return "6 דקות"
                Case SchedulerStringId.Caption_OnScreenResources
                    Return "משאבים על המסך"
                Case SchedulerStringId.TimeScaleDisplayName_Quarter
                    Return "הרובע"
                Case SchedulerStringId.Caption_ShadingApplyToAllDayArea
                    Return "כל יום באזור"
                Case SchedulerStringId.Msg_Conflict
                    Return "פגישה הערוך מתנגשת עם אחד או מספר פעילויות אחרות."
                Case SchedulerStringId.Caption_NoneRecurrence
                    Return "(אף אחד)"
                Case SchedulerStringId.ViewDisplayName_FullWeek
                    Return "שבוע מלא לוח שנה"
                Case SchedulerStringId.MenuCmd_AppointmentLabelNone
                    Return "& אף אחד"
                Case SchedulerStringId.PrintPageSetupFormatTabControlCustomizeShading
                    Return "<Customize...></Customize...>"
                Case SchedulerStringId.TextAppointmentSnapToCells_Auto
                    Return "אוטומטי"
                Case SchedulerStringId.PrintRangeControlInvalidDate
                    Return "תאריך הסיום להיות גדולה או שווה לתאריך ההתחלה"
                Case SchedulerStringId.Caption_10Minutes
                    Return "10 דקות"
                Case SchedulerStringId.Caption_GroupByNone
                    Return "אף אחד"
                Case SchedulerStringId.TextWeekly_3Day
                    Return "{0} {1}, {2}"
                Case SchedulerStringId.Msg_RecurrenceExceptionsWillBeLost
                    Return "מקרים חריגים המשויכים לפעילת חוזרת זו יאבדו. האם להמשיך?"
                Case SchedulerStringId.Msg_InvalidInputFile
                    Return "קובץ הקלט אינו חוקי"
                Case SchedulerStringId.Msg_InvalidAppointmentDuration
                    Return "ערך לא חוקי צוין למשך פרק זמן. הזינו ערך חיובי."
                Case SchedulerStringId.Caption_ShadingApplyToAppointments
                    Return "פגישות"
                Case SchedulerStringId.ViewDisplayName_Gantt
                    Return "תצוגת גנט"
                Case SchedulerStringId.MenuCmd_AppointmentLabelImportant
                    Return "& חשוב"
                Case SchedulerStringId.MemoPrintDateFormat
                    Return "{0} {1} {2}"
                Case SchedulerStringId.PrintPageSetupFormatTabControlSizeAndFontName
                    Return "{0} {1} pt."
                Case SchedulerStringId.TextAppointmentSnapToCells_Disabled
                    Return "בעלי מוגבלויות"
                Case SchedulerStringId.Msg_MissingRequiredMapping
                    Return "המיפוי הדרושים עבור המאפיין '{0}' חסרה."
                Case SchedulerStringId.Caption_15Minutes
                    Return "15 דקות"
                Case SchedulerStringId.Caption_GroupByDate
                    Return "תאריך"
                Case SchedulerStringId.TextWeekly_4Day
                    Return "{0} {1}, {2}, {3}"
                Case SchedulerStringId.DescCmd_CreateAppointmentDependency
                    Return "יצירת יחסי תלות בין פעילויות"
                Case SchedulerStringId.TextRecurrenceTypeDaily
                    Return "יומי"
                Case SchedulerStringId.Caption_ShadingApplyToAppointmentStatuses
                    Return "סטטוסים"
                Case SchedulerStringId.ViewDisplayName_Agenda
                    Return "לוח שנה סדר היום"
                Case SchedulerStringId.MenuCmd_AppointmentLabelBusiness
                    Return "& עסקים"
                Case SchedulerStringId.Msg_InvalidReminderTimeBeforeStart
                    Return "ערך לא חוקי צוין עבור לפני לתזכורת של האירוע. הזינו ערך חיובי."
                Case SchedulerStringId.Caption_EmptyResource
                    Return "(בכלל)"
                Case SchedulerStringId.Caption_SetupAppointmentStorage
                    Return "הגדרת פעילות אחסון"
                Case SchedulerStringId.Msg_MissingMappingMember
                    Return "חסר '{1}' חבר של מיפוי המאפיינים '{0}'."
                Case SchedulerStringId.Caption_20Minutes
                    Return "20 דקות"
                Case SchedulerStringId.Caption_GroupByResources
                    Return "משאבים"
                Case SchedulerStringId.TextAppointmentSnapToCells_Never
                    Return "אף פעם לא"
                Case SchedulerStringId.TextWeekly_5Day
                    Return "{0} {1}, {2}, {3}, {4}"
                Case SchedulerStringId.MenuCmd_CreateAppointmentDependency
                    Return "יצירת תלות"
                Case SchedulerStringId.Caption_ShadingApplyToHeaders
                    Return "כותרות"
                Case SchedulerStringId.ViewShortDisplayName_Day
                    Return "היום"
                Case SchedulerStringId.TextRecurrenceTypeWeekly
                    Return "שבועי"
                Case SchedulerStringId.MenuCmd_AppointmentLabelPersonal
                    Return "& אישיים"
                Case SchedulerStringId.TextDuration_FromTo
                    Return "מ- {0} {1}"
                Case SchedulerStringId.Caption_DailyPrintStyle
                    Return "סגנון יומי"
                Case SchedulerStringId.Caption_SetupResourceStorage
                    Return "הגדרת משאב אחסון"
                Case SchedulerStringId.Caption_WeekViewDescription
                    Return "החלפה לתצוגה בשבוע. סידור פגישות לשבוע מסוים בצורה קומפקטית."
                Case SchedulerStringId.MenuCmd_PrintPreview
                    Return "הדפסה &"
                Case SchedulerStringId.Msg_DuplicateMappingMember
                    Return "החבר '{0}' מיפוי אינו ייחודי: "
                Case SchedulerStringId.Caption_30Minutes
                    Return "30 דקות"
                Case SchedulerStringId.TextWeekly_6Day
                    Return "{0} {1}, {2}, {3}, {4}, {5}"
                Case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToStart
                    Return "סיום-התחלה (סה)"
                Case SchedulerStringId.DescCmd_Print
                    Return "שלח את לוח הזמנים ישירות למדפסת ברירת המחדל מבלי לבצע שינויים."
                Case SchedulerStringId.Caption_ShadingApplyToTimeRulers
                    Return "שליטי הזמן"
                Case SchedulerStringId.ViewShortDisplayName_WorkDays
                    Return "שבוע העבודה"
                Case SchedulerStringId.TextDuration_FromForDays
                    Return "מ- {0} עבור {1} "
                Case SchedulerStringId.Caption_WeeklyPrintStyle
                    Return "סגנון שבועי"
                Case SchedulerStringId.MenuCmd_AppointmentLabelVacation
                    Return "& נופש"
                Case SchedulerStringId.MenuCmd_CellsAutoHeight
                    Return "גובה אוטומטי התא"
                Case SchedulerStringId.Caption_SetupAppointmentDependencyStorage
                    Return "הגדרת יחסי תלות אחסון"
                Case SchedulerStringId.Msg_InconsistentRecurrenceInfoMapping
                    Return "כדי לתמוך הישנות עליך למפות גם RecurrenceInfo וגם סוג חברים."
                Case SchedulerStringId.DescCmd_PrintPreview
                    Return "תצוגה מקדימה ולבצע שינויים עמודים לפני הדפסה."
                Case SchedulerStringId.TextWeekly_7Day
                    Return "{0} {1}, {2}, {3}, {4}, {5}, {6}"
                Case SchedulerStringId.Caption_60Minutes
                    Return "60 דקות"
                Case SchedulerStringId.MenuCmd_PrintPageSetup
                    Return "הגדרת עמוד &"
                Case SchedulerStringId.Caption_ShadingApplyToCells
                    Return "תאים"
                Case SchedulerStringId.Caption_AppointmentDependencyTypeStartToStart
                    Return "התחלה-התחלה (הה)"
                Case SchedulerStringId.TextRecurrenceTypeYearly
                    Return "שנתי"
                Case SchedulerStringId.TextDuration_FromForDaysHours
                    Return "מ- {0} עבור {1} {2}"
                Case SchedulerStringId.ViewShortDisplayName_Week
                    Return "השבוע"
                Case SchedulerStringId.MenuCmd_AppointmentLabelMustAttend
                    Return "בטח & להשתתף"
                Case SchedulerStringId.DescCmd_CellsAutoHeight
                    Return "לאפשר תא הזמן להתאים אוטומטית את גודלו כדי להכיל את הפגישות שהוא מכיל."
                Case SchedulerStringId.Caption_ModifyAppointmentStorageTransactionDescription
                    Return "שינוי מינוי אחסון"
                Case SchedulerStringId.MenuCmd_Print
                    Return "הדפסה מהירה"
                Case SchedulerStringId.Msg_MappingsCheckPassedOk
                    Return "מיפויי נכונים!"
                Case SchedulerStringId.Caption_Free
                    Return "חינם"
                Case SchedulerStringId.TextWeeklyPatternString_EveryWeek
                    Return "כל {0} {3}"
                Case SchedulerStringId.MenuCmd_ToggleRecurrence
                    Return "מופע חוזר"
                Case SchedulerStringId.Caption_AppointmentDependencyTypeFinishToFinish
                    Return "סיום-סיום (סס)"
                Case SchedulerStringId.DescCmd_PrintPageSetup
                    Return "להתאים אישית את המראה של דף ולהגדיר את אפשרויות ההדפסה השונות."
                Case SchedulerStringId.Msg_InvalidSize
                    Return "ערך לא חוקי צוין עבור הגודל."
                Case SchedulerStringId.ViewShortDisplayName_Month
                    Return "חודש"
                Case SchedulerStringId.TextRecurrenceTypeMinutely
                    Return "מסוגל"
                Case SchedulerStringId.TextDuration_FromForDaysMinutes
                    Return "מ- {0} עבור {1} {3}"
                Case SchedulerStringId.MenuCmd_DeleteOccurrence
                    Return "מחק מופע"
                Case SchedulerStringId.DescCmd_ToggleRecurrence
                    Return "להפוך את הפעילות שנבחרה לחוזרת, או ערוך את תבנית המופע החוזר. "
                Case SchedulerStringId.Caption_TrifoldPrintStyle
                    Return "סגנון קיפול משולש"
                Case SchedulerStringId.Caption_ModifyResourceStorageTransactionDescription
                    Return "לשנות משאבי אחסון"
                Case SchedulerStringId.Caption_SetupAppointmentMappings
                    Return "מיפוי פעילות תוכנית ההתקנה"
                Case SchedulerStringId.Msg_SaveBeforeClose
                    Return "רוצה לשמור את השינויים שביצעת?"
                Case SchedulerStringId.Caption_AppointmentDependencyTypeStartToFinish
                    Return "התחלה-סיום (הס)"
                Case SchedulerStringId.TextWeeklyPatternString_EveryWeeks
                    Return "כל {2} {1} {0} {3}"
                Case SchedulerStringId.Msg_ApplyToAllStyles
                    Return "להחיל את הגדרות המדפסת הנוכחית על כל הסגנונות?"
                Case SchedulerStringId.TextRecurrenceTypeHourly
                    Return "כל שעה"
                Case SchedulerStringId.DescCmd_TimeScalesMenu
                    Return "שינוי ציר הזמן."
                Case SchedulerStringId.TextDuration_FromForDaysHoursMinutes
                    Return "מ- {0} עבור {1} {2} {3}"
                Case SchedulerStringId.DescCmd_DeleteOccurrence
                    Return "למחוק את המופע."
                Case SchedulerStringId.MenuCmd_ChangeAppointmentReminderUI
                    Return "תזכורת"
                Case SchedulerStringId.Caption_CalendarDetailsPrintStyle
                    Return "סגנון פרטי לוח שנה"
                Case SchedulerStringId.Caption_SetupResourceMappings
                    Return "הגדרת משאב מיפויים"
                Case SchedulerStringId.String_to
                    Return "כדי"
                Case SchedulerStringId.TextMonthlyPatternString_SubPattern
                    Return "של כל {2} {1} ' {0} '"
                Case SchedulerStringId.Msg_Warning
                    Return "אזהרה!"
                Case SchedulerStringId.MenuCmd_ShowWorkTimeOnly
                    Return "שעות עבודה"
                Case SchedulerStringId.Caption_MemoPrintStyle
                    Return "סגנון תזכיר"
                Case SchedulerStringId.MenuCmd_DeleteSeries
                    Return "למחוק את הסדרה"
                Case SchedulerStringId.DescCmd_ChangeAppointmentReminderUI
                    Return "לבחור מתי לקבל תזכורת של הפעילות שנבחרה."
                Case SchedulerStringId.Caption_DayViewDescription
                    Return "החלפה לתצוגה היום. הנוף המפורט ביותר של פגישות במשך ימים ספציפיים."
                Case SchedulerStringId.Caption_SetupDependencyMappings
                    Return "הגדרת יחסי תלות מיפויים"
                Case SchedulerStringId.Msg_CantFitIntoPage
                    Return "זה בלתי אפשרי להכניס את פלט הדפסה דף בודד באמצעות הגדרות ההדפסה הנוכחי. נסה להגדיל את גובה העמוד או להקטין את מרווח הזמן PrintTime."
                Case SchedulerStringId.DescCmd_DeleteSeries
                    Return "מחק את הסדרה."
                Case SchedulerStringId.DescCmd_ShowWorkTimeOnly
                    Return "הצג שעות עבודה בלבד בלוח השנה."
                Case SchedulerStringId.Caption_NoneReminder
                    Return "אף אחד"
                Case SchedulerStringId.Caption_WorkWeekViewDescription
                    Return "החלפה לתצוגה שבוע העבודה. תצוגה מפורטת עבור ימי העבודה בשבוע מסוים."
                Case SchedulerStringId.Caption_ModifyAppointmentMappingsTransactionDescription
                    Return "שינוי מינוי מיפויים"
                Case SchedulerStringId.Msg_PrintStyleNameExists
                    Return "שם סגנון '{0}' כבר קיים. הקלד שם אחר."
                Case SchedulerStringId.MenuCmd_CompressWeekend
                    Return "לדחוס בסוף השבוע"
                Case SchedulerStringId.Caption_ModifyResourceMappingsTransactionDescription
                    Return "שינוי מיפוי משאבים"
                Case SchedulerStringId.DescCmd_ChangeTimelineScaleWidth
                    Return "ציין רוחב העמודות בפיקסלים על הסולם הבסיס."
                Case SchedulerStringId.Msg_OutlookCalendarNotFound
                    Return "לוח '{0}' לא נמצא."
                Case SchedulerStringId.DescCmd_CompressWeekend
                    Return "הצג שבת וראשון נדחס לתוך עמודה בודדת."
                Case SchedulerStringId.Caption_ModifyAppointmentDependencyMappingsTransactionDescription
                    Return "שינוי מינוי תלות מיפויים"
                Case SchedulerStringId.MenuCmd_ChangeTimelineScaleWidth
                    Return "קנה מידה של רוחב"
                Case SchedulerStringId.Caption_PrevAppointment
                    Return "המינוי הקודם"
                Case SchedulerStringId.Caption_MappingsValidation
                    Return "מיפויי אימות"
                Case SchedulerStringId.Caption_NextAppointment
                    Return "הפגישה הבאה"
                Case SchedulerStringId.MenuCmd_OpenSchedule
                    Return "פתוח"
                Case SchedulerStringId.DisplayName_Appointment
                    Return "פגישה"
                Case SchedulerStringId.Caption_MappingsWizard
                    Return "אשף מיפויים..."
                Case SchedulerStringId.Format_CopyOf
                    Return "עותק של {0}"
                Case SchedulerStringId.DescCmd_OpenSchedule
                    Return "ייבוא זמנים מקובץ (.ics)."
                Case SchedulerStringId.Format_CopyNOf
                    Return "עותק ({0}) {1}"
                Case SchedulerStringId.Caption_CheckMappings
                    Return "סימון מיפויי"
                Case SchedulerStringId.MenuCmd_SaveSchedule
                    Return "שמור"
                Case SchedulerStringId.DescCmd_SaveSchedule
                    Return "לשמור את לוח זמנים לקובץ (.ics)."
                Case SchedulerStringId.MenuCmd_ChangeSnapToCellsUI
                    Return "הצמד לתאים"
                Case SchedulerStringId.DescCmd_ChangeSnapToCellsUI
                    Return "ציין מצב ההצמדה להצגת פעילויות בתוך התאים זמן."
                Case SchedulerStringId.MenuCmd_OpenOccurrence
                    Return "מופע פתוח"
                Case SchedulerStringId.DescCmd_OpenOccurrence
                    Return "פתח את מופע הפגישה הזאת."
                Case SchedulerStringId.MenuCmd_OpenSeries
                    Return "סדרת פתוח"
                Case SchedulerStringId.DescCmd_OpenSeries
                    Return "פתח את זה מפגש בסדרה"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class

    Public Class FarsiSchedulerExtensionsLocalizer
        Inherits SchedulerExtensionsLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As SchedulerExtensionsStringId) As String
            Select Case id
                Case SchedulerExtensionsStringId.CaptionViewNavigator_Today
                    Return "امروز"
                Case SchedulerExtensionsStringId.Caption_GroupActiveView
                    Return "فعال مشاهده"
                Case SchedulerExtensionsStringId.Caption_PageView
                    Return "مشاهده"
                Case SchedulerExtensionsStringId.Caption_Event
                    Return "رویداد"
                Case SchedulerExtensionsStringId.Caption_GroupActions
                    Return "اقدامات"
                Case SchedulerExtensionsStringId.Msg_Some
                    Return "برخی از"
                Case SchedulerExtensionsStringId.Caption_GroupGroupBy
                    Return "گروه بندی بر اساس"
                Case SchedulerExtensionsStringId.Caption_GroupTimeScale
                    Return "مقیاس زمانی"
                Case SchedulerExtensionsStringId.Caption_PageHome
                    Return "صفحه اصلی"
                Case SchedulerExtensionsStringId.Caption_GroupAppointment
                    Return "قرار ملاقات"
                Case SchedulerExtensionsStringId.Caption_GroupOptions
                    Return "گزینه های"
                Case SchedulerExtensionsStringId.Caption_RecurringAppointment
                    Return "ملاقات تکراری"
                Case SchedulerExtensionsStringId.Caption_ViewNavigator
                    Return "مشاهده ناوبر"
                Case SchedulerExtensionsStringId.Caption_PageAppointment
                    Return "قرار ملاقات"
                Case SchedulerExtensionsStringId.Caption_GroupNavigator
                    Return "حرکت"
                Case SchedulerExtensionsStringId.Caption_GroupCommon
                    Return "مشترک"
                Case SchedulerExtensionsStringId.Caption_ViewSelector
                    Return "مشاهده انتخاب"
                Case SchedulerExtensionsStringId.Caption_GroupLayout
                    Return "چیدمان"
                Case SchedulerExtensionsStringId.Caption_Reminder
                    Return "یادآوری:"
                Case SchedulerExtensionsStringId.Caption_GroupPrint
                    Return "نسخه قابل چاپ"
                Case SchedulerExtensionsStringId.Caption_PageCategoryCalendarTools
                    Return "ابزار تقویم"
                Case SchedulerExtensionsStringId.Caption_PageFile
                    Return "دریافت فایل"
                Case SchedulerExtensionsStringId.Caption_RecurringEvent
                    Return "رویداد تکراری"
                Case SchedulerExtensionsStringId.Caption_Appointment
                    Return "قرار ملاقات"
                Case SchedulerExtensionsStringId.Caption_GroupArrange
                    Return "ترتیب"
                Case Else
                Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
    Public Class ArabicSchedulerExtensionsLocalizer
        Inherits SchedulerExtensionsLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As SchedulerExtensionsStringId) As String
            Select Case id
                Case SchedulerExtensionsStringId.Caption_GroupGroupBy
                    Return "تجميع حسب"
                Case SchedulerExtensionsStringId.Caption_PageView
                    Return "طريقة العرض"
                Case SchedulerExtensionsStringId.Caption_PageHome
                    Return "الصفحة الرئيسية"
                Case SchedulerExtensionsStringId.CaptionViewNavigator_Today
                    Return "اليوم"
                Case SchedulerExtensionsStringId.Caption_Event
                    Return "الحدث"
                Case SchedulerExtensionsStringId.Caption_RecurringAppointment
                    Return "موعد متكرر"
                Case SchedulerExtensionsStringId.Msg_Some
                    Return "بعض"
                Case SchedulerExtensionsStringId.Caption_PageAppointment
                    Return "تعيين"
                Case SchedulerExtensionsStringId.Caption_PageFile
                    Return "الملف"
                Case SchedulerExtensionsStringId.Caption_GroupActions
                    Return "الإجراءات"
                Case SchedulerExtensionsStringId.Caption_GroupTimeScale
                    Return "مقياس الوقت"
                Case SchedulerExtensionsStringId.Caption_GroupActiveView
                    Return "طريقة العرض النشطة"
                Case SchedulerExtensionsStringId.Caption_ViewSelector
                    Return "محدد طريقة العرض"
                Case SchedulerExtensionsStringId.Caption_GroupLayout
                    Return "تخطيط"
                Case SchedulerExtensionsStringId.Caption_RecurringEvent
                    Return "تكرار الحدث"
                Case SchedulerExtensionsStringId.Caption_GroupAppointment
                    Return "تعيين"
                Case SchedulerExtensionsStringId.Caption_GroupArrange
                    Return "ترتيب"
                Case SchedulerExtensionsStringId.Caption_ViewNavigator
                    Return "طريقة عرض المستكشف"
                Case SchedulerExtensionsStringId.Caption_GroupOptions
                    Return "خيارات"
                Case SchedulerExtensionsStringId.Caption_PageCategoryCalendarTools
                    Return "أدوات التقويم"
                Case SchedulerExtensionsStringId.Caption_GroupPrint
                    Return "طباعة"
                Case SchedulerExtensionsStringId.Caption_GroupNavigator
                    Return "التنقل"
                Case SchedulerExtensionsStringId.Caption_Appointment
                    Return "تعيين"
                Case SchedulerExtensionsStringId.Caption_Reminder
                    Return "للتذكير:"
                Case SchedulerExtensionsStringId.Caption_GroupCommon
                    Return "المشتركة"
                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
    Public Class HebrewSchedulerExtensionsLocalizer
        Inherits SchedulerExtensionsLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As SchedulerExtensionsStringId) As String
            Select Case id
                Case SchedulerExtensionsStringId.Caption_PageHome
                    Return "הבית"
                Case SchedulerExtensionsStringId.Msg_Some
                    Return "כמה"
                Case SchedulerExtensionsStringId.Caption_GroupActions
                    Return "פעולות"
                Case SchedulerExtensionsStringId.Caption_GroupActiveView
                    Return "התצוגה הפעילה"
                Case SchedulerExtensionsStringId.Caption_PageView
                    Return "תצוגה"
                Case SchedulerExtensionsStringId.Caption_Event
                    Return "אירוע"
                Case SchedulerExtensionsStringId.Caption_PageFile
                    Return "קובץ"
                Case SchedulerExtensionsStringId.CaptionViewNavigator_Today
                    Return "היום"
                Case SchedulerExtensionsStringId.Caption_GroupOptions
                    Return "אפשרויות"
                Case SchedulerExtensionsStringId.Caption_GroupTimeScale
                    Return "סרגל זמן"
                Case SchedulerExtensionsStringId.Caption_GroupGroupBy
                    Return "קבץ לפי"
                Case SchedulerExtensionsStringId.Caption_PageAppointment
                    Return "פגישה"
                Case SchedulerExtensionsStringId.Caption_GroupAppointment
                    Return "פגישה"
                Case SchedulerExtensionsStringId.Caption_GroupPrint
                    Return "הדפסה"
                Case SchedulerExtensionsStringId.Caption_GroupNavigator
                    Return "נווט"
                Case SchedulerExtensionsStringId.Caption_RecurringAppointment
                    Return "החוזרת"
                Case SchedulerExtensionsStringId.Caption_GroupArrange
                    Return "לארגן"
                Case SchedulerExtensionsStringId.Caption_GroupCommon
                    Return "נפוצות"
                Case SchedulerExtensionsStringId.Caption_RecurringEvent
                    Return "אירוע חוזר"
                Case SchedulerExtensionsStringId.Caption_ViewNavigator
                    Return "תצוגת ניווט"
                Case SchedulerExtensionsStringId.Caption_Appointment
                    Return "פגישה"
                Case SchedulerExtensionsStringId.Caption_ViewSelector
                    Return "בורר התצוגות"
                Case SchedulerExtensionsStringId.Caption_GroupLayout
                    Return "פריסה"
                Case SchedulerExtensionsStringId.Caption_PageCategoryCalendarTools
                    Return "לוח כלים"
                Case SchedulerExtensionsStringId.Caption_Reminder
                    Return "תזכורת:"

                Case Else
                    Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
End Namespace
