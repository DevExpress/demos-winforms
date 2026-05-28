Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.MailClient.Win.Localizer
    Public Class FarsiEditorLocalizer
        Inherits XtraEditors.Controls.Localizer

        Public Overrides Function GetLocalizedString(ByVal id As StringId) As String
            Select Case id
                Case StringId.None
                Return ""
                Case StringId.CaptionError
                Return "خطا"
                Case StringId.InvalidValueText
                Return "مقدار نامعتبر"
                Case StringId.CheckChecked
                Return "بررسی"
                Case StringId.CheckUnchecked
                Return "بدون کنترل"
                Case StringId.CheckIndeterminate
                Return "نا مشخص"
                Case StringId.SearchControlNullValuePrompt
                Return "متن جستجو را وارد کنید..."
                Case StringId.DateEditToday
                Return "امروز"
                Case StringId.DateEditClear
                Return "روشن"
                Case StringId.OK
                Return "باشه"
                Case StringId.Cancel
                Return "لغو"
                Case StringId.NavigatorFirstButtonHint
                Return "اول"
                Case StringId.NavigatorPreviousButtonHint
                Return "قبلی"
                Case StringId.NavigatorPreviousPageButtonHint
                Return "صفحه قبلی"
                Case StringId.NavigatorNextButtonHint
                Return "بعدی"
                Case StringId.NavigatorNextPageButtonHint
                Return "صفحه بعد"
                Case StringId.NavigatorLastButtonHint
                Return "آخرين"
                Case StringId.NavigatorAppendButtonHint
                Return "الحاق"
                Case StringId.NavigatorRemoveButtonHint
                Return "حذف"
                Case StringId.NavigatorEditButtonHint
                Return "ویرایش"
                Case StringId.NavigatorEndEditButtonHint
                Return "پایان ویرایش"
                Case StringId.NavigatorCancelEditButtonHint
                Return "لغو ویرایش"
                Case StringId.NavigatorTextStringFormat
                Return "رکورد {0} از {1}"
                Case StringId.PictureEditMenuCut
                Return "برش"
                Case StringId.PictureEditMenuCopy
                Return "کپی"
                Case StringId.PictureEditMenuPaste
                Return "جای گذاری"
                Case StringId.PictureEditMenuDelete
                Return "حذف"
                Case StringId.PictureEditMenuLoad
                Return "بار"
                Case StringId.PictureEditMenuSave
                Return "ذخیره"
                Case StringId.PictureEditOpenFileFilter
                Return "فایل (*.bmp) بیت مپ | *. bmp| فرمت مبادله گرافیک (*.gif) | *. gif| فایل مبادله فرمت JPEG (*.jpg; *.jpeg) | *. jpg; *. jpeg| فایل های آیکون (*.ico) | *. ico| قابل حمل قالب کارت شبکه (*.png) | *. png| تمام فایل های تصویری | * .bmp; *.gif; *.jpg; *.jpeg; *.ico; *.png; *. tif| تمام فایل | *. *"
                Case StringId.PictureEditSaveFileFilter
                Return "فایل (*.bmp) بیت مپ | *. bmp| فرمت مبادله گرافیک (*.gif) | *. gif| فایل مبادله فرمت JPEG (*.jpg) | *. jpg| فرمت گرافیکی قابل حمل شبکه (*.png) | * .png"
                Case StringId.PictureEditOpenFileTitle
                Return "باز"
                Case StringId.PictureEditSaveFileTitle
                Return "ذخیره به عنوان"
                Case StringId.PictureEditOpenFileError
                Return "فرمت تصویر اشتباه"
                Case StringId.PictureEditOpenFileErrorCaption
                Return "خطا در باز کردن"
                Case StringId.PictureEditCopyImageError
                Return "نمی تواند رونوشت تصویر"
                Case StringId.LookUpEditValueIsNull
                Return "[EditValue پوچ است]"
                Case StringId.LookUpInvalidEditValueType
                Return "نوع نامعتبر LookUpEdit EditValue."
                Case StringId.LookUpColumnDefaultName
                Return "نام"
Case StringId.UnknownPictureFormat
                Return "فرمت عکس های ناشناخته"
                Case StringId.DataEmpty
                Return "فعلا تصویر"
                Case StringId.NotValidArrayLength
                Return "طول آرایه معتبر نیست."
                Case StringId.ImagePopupEmpty
                Return "(خالی)"
                Case StringId.ImagePopupPicture
                Return "(عکس)"
                Case StringId.ColorTabCustom
                Return "سفارشی"
                Case StringId.ColorTabWeb
                Return "وب"
                Case StringId.ColorTabSystem
                Return "سیستم"
                Case StringId.CalcButtonMC
                Return "پیمانکار مدیریت"
                Case StringId.CalcButtonMR
                Return "آقاي"
                Case StringId.CalcButtonMS
                Return "کارشناسی ارشد"
                Case StringId.CalcButtonMx
                Return "M +"
                Case StringId.CalcButtonSqrt
                Return "sqrt"
                Case StringId.CalcButtonBack
                Return "پشت"
                Case StringId.CalcButtonCE
                Return "م."
                Case StringId.CalcButtonC
                Return "ج"
                Case StringId.CalcError
                Return "محاسبه خطا"
                Case StringId.TabHeaderButtonPrev
                Return "پیمایش به چپ"
                Case StringId.TabHeaderButtonNext
                Return "پیمایش به راست"
                Case StringId.TabHeaderButtonUp
                Return "رفته بالا"
                Case StringId.TabHeaderButtonDown
                Return "پایین"
                Case StringId.TabHeaderButtonClose
                Return "بستن"
                Case StringId.TabHeaderButtonPin
                Return "پین"
                Case StringId.TabHeaderButtonUnpin
                Return "عدم اتصال"
                Case StringId.TabHeaderSelectorButton
                Return "نمایش لیست پنجره"
                Case StringId.XtraMessageBoxOkButtonText
                Return "& خوب"
                Case StringId.XtraMessageBoxCancelButtonText
                Return "& لغو"
                Case StringId.XtraMessageBoxYesButtonText
                Return "& بله"
                Case StringId.XtraMessageBoxNoButtonText
                Return "& هیچ"
                Case StringId.XtraMessageBoxAbortButtonText
                Return "& سقط جنین"
                Case StringId.XtraMessageBoxRetryButtonText
                Return "& مجدد"
                Case StringId.XtraMessageBoxIgnoreButtonText
                Return "& چشم پوشی"
                Case StringId.TextEditMenuUndo
                Return "& باطل"
                Case StringId.TextEditMenuCut
                Return "مس & t"
                Case StringId.TextEditMenuCopy
                Return "& کپی"
                Case StringId.TextEditMenuPaste
                Return "& رب"
                Case StringId.TextEditMenuDelete
                Return "& حذف"
                Case StringId.TextEditMenuSelectAll
                Return "انتخاب همه &"
                Case StringId.FilterEditorTabText
                Return "متن"
                Case StringId.FilterEditorTabVisual
                Return "بصری"
                Case StringId.FilterShowAll
                Return "(انتخاب همه)"
                Case StringId.FilterGroupAnd
                Return "و"
                Case StringId.FilterGroupNotAnd
                Return "نه و"
                Case StringId.FilterGroupNotOr
                Return "نمی یا"
                Case StringId.FilterGroupOr
                Return "یا"
                Case StringId.FilterClauseAnyOf
                Return "هیچ یک از"
                Case StringId.FilterClauseBeginsWith
                Return "با آغاز می شود"
                Case StringId.FilterClauseBetween
                Return "بین"
                Case StringId.FilterClauseBetweenAnd
                Return "و"
                Case StringId.FilterClauseContains
                Return "شامل"
                Case StringId.FilterClauseEndsWith
                Return "با به پایان می رسد"
                Case StringId.FilterClauseEquals
                Return "برابر است با"
                Case StringId.FilterClauseGreater
                Return "بزرگتر از"
                Case StringId.FilterClauseGreaterOrEqual
                Return "بزرگتر از یا برابر با"
                Case StringId.FilterClauseIsNotNull
                Return "پوچ است"
                Case StringId.FilterClauseIsNull
                Return "پوچ است"
                Case StringId.FilterClauseIsNotNullOrEmpty
                Return "خالی نیست"
                Case StringId.FilterClauseIsNullOrEmpty
                Return "خالی است"
                Case StringId.FilterClauseLess
                Return "است کمتر از"
                Case StringId.FilterClauseLessOrEqual
                Return "کمتر از یا مساوی با"
                Case StringId.FilterClauseLike
                Return "مثل"
                Case StringId.FilterClauseNoneOf
                Return "هیچ کدام از"
                Case StringId.FilterClauseNotBetween
                Return "نیست بین"
                Case StringId.FilterClauseDoesNotContain
                Return "شامل نمی شود"
                Case StringId.FilterClauseDoesNotEqual
                Return "نامساوی"
                Case StringId.FilterClauseNotLike
                Return "مانند نیست"
                Case StringId.FilterMenuAddNewParameter
                Return "اضافه کردن پارامتر..."
                Case StringId.FilterEmptyValue
                Return "<empty></empty>"
                Case StringId.FilterMenuConditionAdd
                Return "اضافه کردن وضعیت"
                Case StringId.FilterMenuGroupAdd
                Return "افزودن گروه"
                Case StringId.FilterMenuClearAll
                Return "پاک کردن همه"
                Case StringId.FilterMenuRowRemove
                Return "حذف گروه"
                Case StringId.FilterToolTipNodeAdd
                Return "شرایط جدید را به این گروه اضافه می کند"
                Case StringId.FilterToolTipNodeRemove
                Return "این وضعیت را حذف می کند"
                Case StringId.FilterToolTipNodeAction
                Return "اقدامات"
                Case StringId.FilterToolTipValueType
                Return "مقایسه با ارزش / دیگر مقدار فیلد را"
                Case StringId.FilterToolTipElementAdd
                Return "یک آیتم جدید به لیست اضافه می کند"
                Case StringId.FilterToolTipKeysAdd
                Return "(استفاده از قرار دادن یا اضافه کردن کلید)"
                Case StringId.FilterToolTipKeysRemove
                Return "(استفاده از حذف یا کلید تفریق)"
                Case StringId.ContainerAccessibleEditName
                Return "کنترل ویرایش"
                Case StringId.FilterCriteriaToStringGroupOperatorAnd
                Return "و"
                Case StringId.FilterCriteriaToStringGroupOperatorOr
                Return "یا"
                Case StringId.FilterCriteriaToStringUnaryOperatorBitwiseNot
                Return "~"
                Case StringId.FilterCriteriaToStringUnaryOperatorIsNull
                Return "پوچ است"
                Case StringId.FilterCriteriaToStringUnaryOperatorMinus
                Return "-"
                Case StringId.FilterCriteriaToStringUnaryOperatorNot
                Return "نه"
                Case StringId.FilterCriteriaToStringUnaryOperatorPlus
                Return "+"
                Case StringId.FilterCriteriaToStringBinaryOperatorBitwiseAnd
                Return "&"
                Case StringId.FilterCriteriaToStringBinaryOperatorBitwiseOr
                Return "|"
                Case StringId.FilterCriteriaToStringBinaryOperatorBitwiseXor
                Return "^"
                Case StringId.FilterCriteriaToStringBinaryOperatorDivide
                Return "/"
                Case StringId.FilterCriteriaToStringBinaryOperatorEqual
                Return "="
                Case StringId.FilterCriteriaToStringBinaryOperatorGreater
                Return ">"
                Case StringId.FilterCriteriaToStringBinaryOperatorGreaterOrEqual
                Return ">="
                Case StringId.FilterCriteriaToStringBinaryOperatorLess
                Return "<"
                Case StringId.FilterCriteriaToStringBinaryOperatorLessOrEqual
                Return "<="
                Case StringId.FilterCriteriaToStringBinaryOperatorLike
                Return "مانند"
                Case StringId.FilterCriteriaToStringBinaryOperatorMinus
                Return "-"
                Case StringId.FilterCriteriaToStringBinaryOperatorModulo
                Return "%"
                Case StringId.FilterCriteriaToStringBinaryOperatorMultiply
                Return "*"
                Case StringId.FilterCriteriaToStringBinaryOperatorNotEqual
                Return "<>"
                Case StringId.FilterCriteriaToStringBinaryOperatorPlus
                Return "+"
                Case StringId.FilterCriteriaToStringBetween
                Return "بین"
                Case StringId.FilterCriteriaToStringIn
                Return "در"
                Case StringId.FilterCriteriaToStringIsNotNull
                Return "پوچ است"
                Case StringId.FilterCriteriaToStringNotLike
                Return "نه مثل"
                Case StringId.FilterCriteriaToStringFunctionIif
                Return "Iif"
                Case StringId.FilterCriteriaToStringFunctionIsNull
                Return "IsNull"
                Case StringId.FilterCriteriaToStringFunctionLen
                Return "لن"
                Case StringId.FilterCriteriaToStringFunctionLower
                Return "پایین تر"
                Case StringId.FilterCriteriaToStringFunctionNone
                Return "هیچ کدام"
                Case StringId.FilterCriteriaToStringFunctionSubstring
                Return "زیر رشته"
                Case StringId.FilterCriteriaToStringFunctionTrim
                Return "تر و تمیز"
                Case StringId.FilterCriteriaToStringFunctionUpper
                Return "بالا"
                Case StringId.FilterCriteriaToStringFunctionIsThisYear
                Return "امسال است"
                Case StringId.FilterCriteriaToStringFunctionIsThisMonth
                Return "این ماه است"
                Case StringId.FilterCriteriaToStringFunctionIsThisWeek
                Return "این هفته"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisYear
                Return "امسال"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisMonth
                Return "این ماه"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeLastWeek
                Return "هفته ی قبل"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisWeek
                Return "این هفته"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeYesterday
                Return "دیروز"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeToday
                Return "امروز"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeNow
                Return "در حال حاضر"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeTomorrow
                Return "فردا"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeDayAfterTomorrow
                Return "روز بعد از فردا"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextWeek
                Return "هفته ی بعد"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeTwoWeeksAway
                Return "دو هفته بعد"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextMonth
                Return "ماه آینده"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextYear
                Return "سال آینده"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalBeyondThisYear
                Return "فراتر از امسال است"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisYear
                Return "بعد از این سال است"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisMonth
                Return "بعد از این ماه است"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalNextWeek
                Return "آینده است"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisWeek
                Return "بعد از این هفته"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalTomorrow
                Return "فردا"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalToday
                Return "امروز است"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalYesterday
                Return "دیروز است"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisWeek
                Return "اوایل این هفته است"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLastWeek
                Return "هفته گذشته"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisMonth
                Return "در اوایل این ماه است"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisYear
                Return "اوایل سال جاری است"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalPriorThisYear
                Return "قبل از این سال است"
                Case StringId.FilterCriteriaToStringFunctionCustom
                Return "سفارشی"
                Case StringId.FilterCriteriaToStringFunctionCustomNonDeterministic
                Return "سفارشی غیر قطعی"
                Case StringId.FilterCriteriaToStringFunctionIsNullOrEmpty
                Return "خالي است"
                Case StringId.FilterCriteriaToStringFunctionConcat
                Return "تماس با"
                Case StringId.FilterCriteriaToStringFunctionAscii
                Return "اسکی"
                Case StringId.FilterCriteriaToStringFunctionChar
                Return "کاراکتر"
                Case StringId.FilterCriteriaToStringFunctionToInt
                Return "به اعضای هیات تحریریه"
                Case StringId.FilterCriteriaToStringFunctionToLong
                Return "به طول"
                Case StringId.FilterCriteriaToStringFunctionToFloat
                Return "برای شناور"
                Case StringId.FilterCriteriaToStringFunctionToDouble
                Return "به دو"
                Case StringId.FilterCriteriaToStringFunctionToDecimal
                Return "به ده دهی"
                Case StringId.FilterCriteriaToStringFunctionToStr
                Return "به خ"
                Case StringId.FilterCriteriaToStringFunctionReplace
                Return "جایگزین"
                Case StringId.FilterCriteriaToStringFunctionReverse
                Return "معکوس"
                Case StringId.FilterCriteriaToStringFunctionInsert
                Return "را وارد کنید"
                Case StringId.FilterCriteriaToStringFunctionCharIndex
                Return "شاخص کاراکتر"
                Case StringId.FilterCriteriaToStringFunctionRemove
                Return "حذف"
                Case StringId.FilterCriteriaToStringFunctionAbs
                Return "Abs"
                Case StringId.FilterCriteriaToStringFunctionSqr
                Return "میدان"
                Case StringId.FilterCriteriaToStringFunctionCos
                Return "Cos"
                Case StringId.FilterCriteriaToStringFunctionSin
                Return "گناه"
                Case StringId.FilterCriteriaToStringFunctionAtn
                Return "Atn"
                Case StringId.FilterCriteriaToStringFunctionExp
                Return "درصد این سطح"
                Case StringId.FilterCriteriaToStringFunctionLog
                Return "ورود به سیستم"
                Case StringId.FilterCriteriaToStringFunctionRnd
                Return "آرند"
                Case StringId.FilterCriteriaToStringFunctionTan
                Return "قهوهای مایل به زرد"
                Case StringId.FilterCriteriaToStringFunctionPower
                Return "قدرت"
                Case StringId.FilterCriteriaToStringFunctionSign
                Return "ورود به سیستم"
                Case StringId.FilterCriteriaToStringFunctionRound
                Return "دور"
                Case StringId.FilterCriteriaToStringFunctionCeiling
                Return "سقف"
                Case StringId.FilterCriteriaToStringFunctionFloor
                Return "طبقه"
                Case StringId.FilterCriteriaToStringFunctionMax
                Return "حداکثر"
                Case StringId.FilterCriteriaToStringFunctionMin
                Return "دقیقه"
                Case StringId.FilterCriteriaToStringFunctionAcos
                Return "Acos"
                Case StringId.FilterCriteriaToStringFunctionAsin
                Return "آسین"
                Case StringId.FilterCriteriaToStringFunctionAtn2
                Return "Atn2"
                Case StringId.FilterCriteriaToStringFunctionBigMul
                Return "بازار بزرگ"
                Case StringId.FilterCriteriaToStringFunctionCosh
                Return "Cosh"
                Case StringId.FilterCriteriaToStringFunctionLog10
                Return "Log10"
                Case StringId.FilterCriteriaToStringFunctionSinh
                Return "Sinh"
                Case StringId.FilterCriteriaToStringFunctionTanh
                Return "Tanh"
                Case StringId.FilterCriteriaToStringFunctionPadLeft
                Return "پد سمت چپ"
                Case StringId.FilterCriteriaToStringFunctionPadRight
                Return "پد سمت راست"
                Case StringId.FilterCriteriaToStringFunctionDateDiffTick
                Return "تاریخ تفاوت کنه"
                Case StringId.FilterCriteriaToStringFunctionDateDiffSecond
                Return "تفاوت دوم ۱۳۹۰"
                Case StringId.FilterCriteriaToStringFunctionDateDiffMilliSecond
                Return "تاریخ تفاوت میلی ثانیه"
                Case StringId.FilterCriteriaToStringFunctionDateDiffMinute
                Return "دقیقه تفاوت تاریخ"
                Case StringId.FilterCriteriaToStringFunctionDateDiffHour
                Return "تفاوت تاریخ"
                Case StringId.FilterCriteriaToStringFunctionDateDiffDay
                Return "تاریخ روز تفاوت"
                Case StringId.FilterCriteriaToStringFunctionDateDiffMonth
                Return "شدن تفاوت ماه"
                Case StringId.FilterCriteriaToStringFunctionDateDiffYear
                Return "تاریخ سال تفاوت"
                Case StringId.FilterCriteriaToStringFunctionGetDate
                Return "تاریخ دریافت"
                Case StringId.FilterCriteriaToStringFunctionGetMilliSecond
                Return "دریافت میلی ثانیه"
                Case StringId.FilterCriteriaToStringFunctionGetSecond
                Return "می دوم"
                Case StringId.FilterCriteriaToStringFunctionGetMinute
                Return "دریافت دقیقه"
                Case StringId.FilterCriteriaToStringFunctionGetHour
                Return "دریافت ساعت"
                Case StringId.FilterCriteriaToStringFunctionGetDay
                Return "دریافت روز"
                Case StringId.FilterCriteriaToStringFunctionGetMonth
                Return "ماه"
                Case StringId.FilterCriteriaToStringFunctionGetYear
                Return "سال"
                Case StringId.FilterCriteriaToStringFunctionGetDayOfWeek
                Return "دریافت روز هفته"
                Case StringId.FilterCriteriaToStringFunctionGetDayOfYear
                Return "دریافت روز سال"
                Case StringId.FilterCriteriaToStringFunctionGetTimeOfDay
                Return "زمان روز"
                Case StringId.FilterCriteriaToStringFunctionNow
                Return "در حال حاضر"
                Case StringId.FilterCriteriaToStringFunctionUtcNow
                Return "در حال حاضر Utc"
                Case StringId.FilterCriteriaToStringFunctionToday
                Return "امروز"
                Case StringId.FilterCriteriaToStringFunctionAddTimeSpan
                Return "اضافه کردن طول زمان"
                Case StringId.FilterCriteriaToStringFunctionAddTicks
                Return "اضافه کنه"
                Case StringId.FilterCriteriaToStringFunctionAddMilliSeconds
                Return "اضافه کردن میلی ثانیه"
                Case StringId.FilterCriteriaToStringFunctionAddSeconds
                Return "اضافه کردن ثانیه"
                Case StringId.FilterCriteriaToStringFunctionAddMinutes
                Return "دقیقه"
                Case StringId.FilterCriteriaToStringFunctionAddHours
                Return "اضافه کردن ساعت"
                Case StringId.FilterCriteriaToStringFunctionAddDays
                Return "اضافه کردن روز"
                Case StringId.FilterCriteriaToStringFunctionAddMonths
                Return "اضافه کردن ماه"
                Case StringId.FilterCriteriaToStringFunctionAddYears
                Return "اضافه سال"
                Case StringId.FilterCriteriaToStringFunctionStartsWith
                Return "با شروع می شود"
                Case StringId.FilterCriteriaToStringFunctionEndsWith
                Return "با به پایان می رسد"
                Case StringId.FilterCriteriaToStringFunctionContains
                Return "شامل"
                Case StringId.FilterCriteriaInvalidExpression
                Return "بيان مشخص شده نامعتبر نمادها (خط {0}، شخصیت {1}) است."
                Case StringId.FilterCriteriaInvalidExpressionEx
                Return "بيان مشخص شده نامعتبر است."
                Case StringId.Apply
                Return "درخواست"
                Case StringId.PreviewPanelText
                Return "پیش نمایش:"
                Case StringId.TransparentBackColorNotSupported
                Return "این کنترل رنگ پس زمینه شفاف را پشتیبانی نمی کند"
                Case StringId.FilterOutlookDateText
                Return "نمایش all| نمایش Empty| فیلتر توسط تاریخ خاص: |Beyond این year| بعد این year| بعد این month| Week| بعدی بعد این week| Tomorrow| Today| Yesterday| قبلا این week| آخرین week| قبلا این month| قبلا این year| قبل از این سال"
                Case StringId.FilterDateTimeConstantMenuCaption
                Return "تاریخ و زمان ثابت"
                Case StringId.FilterDateTimeOperatorMenuCaption
                Return "تاریخ و زمان اپراتور"
                Case StringId.FilterDateTextAlt
                Return "نمایش all| نمایش Empty| فیلتر توسط تاریخ خاص: |Beyond||| Week| بعدی Today| این week| این month| Earlier| {0:yyyy}، {0: MMMM}"
                Case StringId.FilterFunctionsMenuCaption
                Return "توابع"
                Case StringId.DefaultBooleanTrue
                Return "درست است"
                Case StringId.DefaultBooleanFalse
                Return "نادرست"
                Case StringId.DefaultBooleanDefault
                Return "پیش فرض"
                Case StringId.ProgressExport
                Return "صادرات"
                Case StringId.ProgressPrinting
                Return "چاپ"
                Case StringId.ProgressCreateDocument
                Return "ایجاد نوشتار"
                Case StringId.ProgressCancel
                Return "لغو"
                Case StringId.ProgressCancelPending
                Return "بررسی لغو"
                Case StringId.ProgressLoadingData
                Return "بارگذاری داده ها"
                Case StringId.FilterAggregateAvg
                Return "متوسط امتیاز"
                Case StringId.FilterAggregateCount
                Return "تعداد دفعات مشاهده"
                Case StringId.FilterAggregateExists
                Return "وجود دارد"
                Case StringId.FilterAggregateMax
                Return "حداکثر"
                Case StringId.FilterAggregateMin
                Return "دقیقه"
                Case StringId.FilterAggregateSum
                Return "مجموع"
                Case StringId.FieldListName
                Return "لیست زمینه ({0})"
                Case StringId.RestoreLayoutDialogFileFilter
                Return "فایل های XML (*.xml) | *. xml| تمام پرونده هاى مضمون| *. *"
                Case StringId.SaveLayoutDialogFileFilter
                Return "فایل های XML (*.xml) | * .xml"
                Case StringId.RestoreLayoutDialogTitle
                Return "طرح بازیابی"
                Case StringId.SaveLayoutDialogTitle
                Return "ذخیره چیدمان"
                Case StringId.PictureEditMenuZoom
                Return "زوم"
                Case StringId.PictureEditMenuFullSize
                Return "اندازه کامل"
                Case StringId.PictureEditMenuFitImage
                Return "تصویر مناسب"
                Case StringId.PictureEditMenuZoomIn
                Return "بزرگنمایی"
                Case StringId.PictureEditMenuZoomOut
                Return "زوم کردن"
                Case StringId.PictureEditMenuZoomTo
                Return "زوم:"
                Case StringId.PictureEditMenuZoomToolTip
                Return "درصد {0}"
                Case StringId.FilterPopupToolbarShowOnlyAvailableItems
                Return "تنها موارد موجود نشان می دهد"
                Case StringId.FilterPopupToolbarShowNewValues
                Return "نشان دادن ارزش های زمینه جدید"
                Case StringId.FilterPopupToolbarIncrementalSearch
                Return "جستجوی افزایشی"
                Case StringId.FilterPopupToolbarMultiSelection
                Return "انتخاب چند"
                Case StringId.FilterPopupToolbarRadioMode
                Return "حالت رادیو"
                Case StringId.FilterPopupToolbarInvertFilter
                Return "معکوس کردن فیلتر"
                Case StringId.ColorPickPopupAutomaticItemCaption
                Return "خودکار"
                Case StringId.ColorPickPopupThemeColorsGroupCaption
                Return "رنگهای مضمون"
                Case StringId.ColorPickPopupStandardColorsGroupCaption
                Return "رنگ های استاندارد"
                Case StringId.ColorPickPopupRecentColorsGroupCaption
                Return "رنگ های اخیر"
                Case StringId.ColorPickPopupMoreColorsItemCaption
                Return "رنگهای بیشتر..."
                Case StringId.ColorPickHueAxisName
                Return "رنگ"
                Case StringId.ColorPickSaturationAxisName
                Return "اشباع"
                Case StringId.ColorPickLuminanceAxisName
                Return "درخشندگی"
                Case StringId.ColorPickBrightnessAxisName
                Return "روشنایی"
                Case StringId.ColorPickOpacityAxisName
                Return "تاری"
                Case StringId.ColorPickRedValidationMsg
                Return "جز قرمز می باید در محدوده 0..255"
                Case StringId.ColorPickGreenValidationMsg
                Return "جز سبز می باید در محدوده 0..255"
                Case StringId.ColorPickBlueValidationMsg
                Return "جزء کبود می باید در محدوده 0..255"
                Case StringId.ColorPickOpacityValidationMsg
                Return "جزء کدورت می باید در محدوده 0..255"
                Case StringId.ColorPickColorHexValidationMsg
                Return "مقدار هگزادسیمال نامعتبر"
                Case StringId.ColorPickHueValidationMsg
                Return "جزء رنگ می باید در محدوده 0..359"
                Case StringId.ColorPickSaturationValidationMsg
                Return "جزء اشباع می باید در محدوده 0..100"
                Case StringId.ColorPickBrightValidationMsg
                Return "اجزای روشنایی می باید در محدوده 0..100"
                Case StringId.ColorTabWebSafeColors
                Return "وب امن"
                Case StringId.Days
                Return "روز"
                Case StringId.Hours
                Return "ساعت"
                Case StringId.Mins
                Return "دقیقه"
                Case StringId.Secs
                Return "ثانیه"
                Case StringId.Millisecs
                Return "millisecs"
                Case StringId.IncorrectNumberCopies
                Return "تعداد باید بین 1 و 32767."
                Case StringId.ChartRangeControlClientInvalidGrid
                Return "فاصله بین خطوط شبکه بیش از حد کوچک برای کنترل محدوده نماینده است."
                Case StringId.ChartRangeControlClientNoData
                Return "هیچ داده ای برای نمایش در کنترل محدوده وجود دارد."
                Case StringId.DataBarBlue
                Return "آبی اطلاعات نوار"
                Case StringId.DataBarLightBlue
                Return "نور آبی نوار اطلاعات"
                Case StringId.DataBarGreen
                Return "نوار اطلاعات سبز"
                Case StringId.DataBarYellow
                Return "نوار اطلاعات زرد"
                Case StringId.DataBarOrange
                Return "نارنجی اطلاعات نوار"
                Case StringId.DataBarMint
                Return "نعناع نوار اطلاعات"
                Case StringId.DataBarViolet
                Return "نوار اطلاعات بنفش"
                Case StringId.DataBarRaspberry
                Return "نوار اطلاعات تمشک"
                Case StringId.DataBarCoral
                Return "مرجان نوار اطلاعات"
                Case StringId.DataBarBlueGradient
                Return "پیشرفت تدریجی آبی نوار اطلاعات"
                Case StringId.DataBarLightBlueGradient
                Return "نور آبی داده نوار پیشرفت تدریجی"
                Case StringId.DataBarGreenGradient
                Return "پیشرفت تدریجی سبز نوار اطلاعات"
                Case StringId.DataBarYellowGradient
                Return "پیشرفت تدریجی نوار زرد داده"
                Case StringId.DataBarOrangeGradient
                Return "پیشرفت تدریجی نوار نارنجی داده"
                Case StringId.DataBarMintGradient
                Return "شیب نعناع نوار اطلاعات"
                Case StringId.DataBarVioletGradient
                Return "شیب بنفش نوار اطلاعات"
                Case StringId.DataBarRaspberryGradient
                Return "شیب تمشک نوار اطلاعات"
                Case StringId.DataBarCoralGradient
                Return "شیب مرجان نوار اطلاعات"
                Case StringId.FormatRuleMenuItemClearColumnRules
                Return "قوانین روشن از این ستون"
                Case StringId.FormatRuleMenuItemClearAllRules
                Return "قوانین روشن از همه ستونها"
                Case StringId.FormatRuleMenuItemHighlightCellRules
                Return "قوانین برجسته سلول"
                Case StringId.FormatRuleMenuItemTopBottomRules
                Return "قوانین بالا/پایین"
                Case StringId.FormatRuleMenuItemDataBars
                Return "میله های داده"
                Case StringId.FormatRuleMenuItemColorScales
                Return "تعادل رنگ"
                Case StringId.FormatRuleMenuItemIconSets
                Return "مجموعه آیکون"
                Case StringId.FormatRuleMenuItemClearRules
                Return "قواعد مشخص"
                Case StringId.FormatRuleMenuItemManageRules
                Return "مدیریت قوانین..."
                Case StringId.FormatRuleMenuItemUniqueDuplicateRules
                Return "قوانین منحصر به فرد/تکراری"
                Case StringId.FormatRuleMenuItemGradientFill
                Return "پر شیب"
                Case StringId.FormatRuleMenuItemSolidFill
                Return "جامد را پر کنید"
                Case StringId.IconSetCategoryRatings
                Return "رتبه بندی"
                Case StringId.IconSetCategoryIndicators
                Return "شاخص های"
                Case StringId.IconSetCategorySymbols
                Return "نمادها"
                Case StringId.IconSetCategoryShapes
                Return "اشکال"
                Case StringId.IconSetCategoryDirectional
                Return "جهت"
                Case StringId.IconSetCategoryPositiveNegative
                Return "مثبت/منفی"
                Case StringId.FormatRuleMenuItemIconSetDescription
                Return "این آیکون تنظیم طبقه بندی ارزش های ستون به محدوده های زیر استفاده کنید:"
                Case StringId.ColorScaleGreenYellowRed
                Return "سبز - زرد - قرمز"
                Case StringId.ColorScalePurpleWhiteAzure
                Return "بنفش - سفید - لاجورد"
                Case StringId.ColorScaleYellowOrangeCoral
                Return "زرد - نارنجی - مرجان"
                Case StringId.ColorScaleGreenWhiteRed
                Return "سبز - سفید - قرمز"
                Case StringId.ColorScaleEmeraldAzureBlue
                Return "زمرد - لاجورد - آبی"
                Case StringId.ColorScaleWhiteRed
                Return "سفید - قرمز"
                Case StringId.ColorScaleWhiteGreen
                Return "سفید - سبز"
                Case StringId.ColorScaleWhiteAzure
                Return "سفید - لاجوردی"
                Case StringId.ColorScaleYellowGreen
                Return "زرد - سبز"
                Case StringId.ColorScaleBlueWhiteRed
                Return "آبی - سفید - قرمز"
Case StringId.FormatRuleMenuItemUnique
                Return "ارزش های منحصر به فرد"
                Case StringId.FormatRuleUniqueText
                Return "شکلبندی سلولها است که ارزش های منحصر به فرد"
                Case StringId.FormatRuleMenuItemDuplicate
                Return "تکراری ارزش"
                Case StringId.FormatRuleDuplicateText
                Return "شکلبندی سلولها است که ارزش های تکراری"
                Case StringId.FormatRuleApplyFormatProperty
                Return "اعمال شکلبندی به همه ردیف"
                Case StringId.FormatRuleWith
                Return "با"
                Case StringId.FormatRuleForThisColumnWith
                Return "برای این ستون"
                Case StringId.IconSetTitleStars3
                Return "3 ستاره"
                Case StringId.IconSetTitleRatings4
                Return "4 رأی"
                Case StringId.IconSetTitleRatings5
                Return "5 رأی"
                Case StringId.IconSetTitleQuarters5
                Return "محله های 5"
                Case StringId.IconSetTitleBoxes5
                Return "5 جعبه"
                Case StringId.IconSetTitleArrows3Colored
                Return "3 فلش (رنگی)"
                Case StringId.IconSetTitleArrows3Gray
                Return "3 فلش (خاکستری)"
                Case StringId.IconSetTitleTriangles3
                Return "3 مثلث"
                Case StringId.IconSetTitleArrows4Colored
                Return "فلش 4 (رنگی)"
                Case StringId.IconSetTitleArrows4Gray
                Return "فلش 4 (خاکستری)"
                Case StringId.IconSetTitleArrows5Colored
                Return "5 فلش (رنگی)"
                Case StringId.IconSetTitleArrows5Gray
                Return "5 فلش (خاکستری)"
                Case StringId.IconSetTitleTrafficLights3Unrimmed
                Return "چراغ های ترافیک 3 (Unrimmed)"
                Case StringId.IconSetTitleTrafficLights3Rimmed
                Return "3 چراغ های ترافیک (Rimmed)"
                Case StringId.IconSetTitleSigns3
                Return "3 نشانه"
                Case StringId.IconSetTitleTrafficLights4
                Return "4 چراغ های ترافیک"
                Case StringId.IconSetTitleRedToBlack
                Return "قرمز به سیاه و سفید"
                Case StringId.IconSetTitleSymbols3Circled
                Return "3 نماد (دور)"
                Case StringId.IconSetTitleSymbols3Uncircled
                Return "3 نماد (Uncircled)"
                Case StringId.IconSetTitleFlags3
                Return "پرچم 3"
                Case StringId.IconSetTitlePositiveNegativeArrows
                Return "فلش (رنگی)"
                Case StringId.IconSetTitlePositiveNegativeArrowsGray
                Return "فلش (خاکستری)"
                Case StringId.IconSetTitlePositiveNegativeTriangles
                Return "مثلث"
                Case StringId.FormatRuleMenuItemTop10Items
                Return "موارد بالا 10"
                Case StringId.FormatRuleMenuItemTop10Percent
                Return "بالا 10%"
                Case StringId.FormatRuleMenuItemBottom10Items
                Return "پایین 10 مورد"
                Case StringId.FormatRuleMenuItemBottom10Percent
                Return "پایین 10 ٪"
                Case StringId.FormatRuleMenuItemAboveAverage
                Return "بالاتر از حد متوسط"
                Case StringId.FormatRuleMenuItemBelowAverage
                Return "زیر متوسط"
                Case StringId.FormatRuleTopText
                Return "فرمت این رتبه در بالای سلول"
                Case StringId.FormatRuleBottomText
                Return "فرمت سلول که رتبه در پایین"
                Case StringId.FormatRuleAboveAverageText
                Return "شکلبندی سلولها است که بالاتر از متوسط"
                Case StringId.FormatRuleBelowAverageText
                Return "شکلبندی سلولها که زیر متوسط"
                Case StringId.FormatRuleMenuItemGreaterThan
                Return "بزرگتر از"
                Case StringId.FormatRuleMenuItemLessThan
                Return "کمتر از"
                Case StringId.FormatRuleMenuItemBetween
                Return "بین"
                Case StringId.FormatRuleMenuItemEqualTo
                Return "برابر با"
                Case StringId.FormatRuleMenuItemTextThatContains
                Return "متنی که حاوی"
                Case StringId.FormatRuleMenuItemCustomCondition
                Return "بیماری های سفارشی"
                Case StringId.FormatRuleGreaterThanText
                Return "شکلبندی سلولها است که بیشتر از"
                Case StringId.FormatRuleLessThanText
                Return "شکلبندی سلولها است که کمتر از"
                Case StringId.FormatRuleBetweenText
                Return "شکلبندی سلولها است که بین"
                Case StringId.FormatRuleEqualToText
                Return "شکلبندی سلولها است که مساوی به"
                Case StringId.FormatRuleTextThatContainsText
                Return "شکلبندی سلولها که حاوی متن"
                Case StringId.FormatRuleCustomConditionText
                Return "شکلبندی سلولها است که منطبق با شرایط زیر"
                Case StringId.FormatRuleMenuItemDateOccurring
                Return "تاریخ وقوع"
                Case StringId.FormatRuleDateOccurring
                Return "شکلبندی سلولها که حاوی تاریخ تطبیق این شرایط"
                Case StringId.FormatPredefinedAppearanceRedFillRedText
                Return "قرمز پر کردن با متن قرمز"
                Case StringId.FormatPredefinedAppearanceYellowFillYellowText
                Return "پر زرد زرد متن"
                Case StringId.FormatPredefinedAppearanceGreenFillGreenText
                Return "سبز پر کردن با متن سبز"
                Case StringId.FormatPredefinedAppearanceRedFill
                Return "پر سرخ"
                Case StringId.FormatPredefinedAppearanceRedText
                Return "متن قرمز"
                Case StringId.FormatPredefinedAppearanceGreenFill
                Return "سبز پر"
                Case StringId.FormatPredefinedAppearanceGreenText
                Return "متن سبز"
                Case StringId.FormatPredefinedAppearanceBoldText
                Return "متن پررنگ"
                Case StringId.FormatPredefinedAppearanceItalicText
                Return "متن مورب"
                Case StringId.FormatPredefinedAppearanceStrikeoutText
                Return "خط زدن متن"
                Case StringId.FormatPredefinedAppearanceRedBoldText
                Return "متن قرمز پررنگ"
                Case StringId.FormatPredefinedAppearanceGreenBoldText
                Return "سبز پررنگ متن"
                Case StringId.SearchForColumn
                Return "جستجو برای ستون..."
                Case StringId.SearchForField
                Return "زمینه جستجو..."
                Case StringId.ManageRuleCaption
                Return "مدیر های قوانین قالب بندی شرطی"
                Case StringId.ManageRuleShowFormattingRules
                Return "قوانین نشان می دهد:"
                Case StringId.ManageRuleUp
                Return "تا"
                Case StringId.ManageRuleDown
                Return "پایین"
                Case StringId.ManageRuleNewRule
                Return "قانون جدید..."
                Case StringId.ManageRuleEditRule
                Return "ویرایش قانون..."
                Case StringId.ManageRuleDeleteRule
                Return "حذف قانون"
                Case StringId.ManageRuleGridCaptionRule
                Return "قانون"
                Case StringId.ManageRuleGridCaptionFormat
                Return "قالب"
                Case StringId.ManageRuleGridCaptionApplyToTheRow
                Return "اعمال بر سطر"
                Case StringId.ManageRuleGridCaptionColumn
                Return "ستون"
                Case StringId.ManageRuleAllColumns
                Return "(تمام)"
                Case StringId.NewFormattingRule
                Return "قانون جدید شکلبندی"
                Case StringId.EditFormattingRule
                Return "ویرایش قالب بندی"
                Case StringId.NewEditFormattingRuleSelectARuleType
                Return "انتخاب نوع حکومت:"
                Case StringId.NewEditFormattingRuleEditTheRuleDescription
                Return "ویرایش توضیح قانون:"
                Case StringId.NewEditFormattingRuleFormatAllCellsBasedOnTheirValues
                Return "تمام سلول های مبتنی بر ارزش های خود را با فرمت"
                Case StringId.NewEditFormattingRuleFormatOnlyCellsThatContain
                Return "سلول حاوی فرمت"
                Case StringId.NewEditFormattingRuleFormatOnlyTopOrBottomRankedValues
                Return "رتبه بندی مقادیر قالب تنها بالا یا پایین"
                Case StringId.NewEditFormattingRuleFormatOnlyValuesThatAreAboveOrBelowAverage
                Return "ارزش های بالا یا پایین به طور متوسط با فرمت"
                Case StringId.NewEditFormattingRuleFormatOnlyUniqueOrDuplicateValues
                Return "فرمت تنها منحصر به فرد و یا تکراری ارزش"
                Case StringId.NewEditFormattingRuleUseAFormulaToDetermineWhichCellsToFormat
                Return "با استفاده از فرمول تعیین کدام سلول به فرمت"
                Case StringId.ManageRuleComplexRuleBaseFormatStyle
                Return "قالب سبک:"
                Case StringId.ManageRuleColorScale2
                Return "مقیاس 2 رنگ"
                Case StringId.ManageRuleColorScale3
                Return "3-رنگ مقیاس"
                Case StringId.ManageRuleDataBar
                Return "نوار اطلاعات"
                Case StringId.ManageRuleIconSets
                Return "مجموعه آیکون"
                Case StringId.ManageRuleCommonMinimum
                Return "حداقل"
                Case StringId.ManageRuleCommonMaximum
                Return "حداکثر"
                Case StringId.ManageRuleCommonType
                Return "نوع:"
                Case StringId.ManageRuleCommonPercent
                Return "درصد"
                Case StringId.ManageRuleCommonNumber
                Return "شماره"
                Case StringId.ManageRuleCommonValue
                Return "ارزش:"
                Case StringId.ManageRuleCommonColor
                Return "رنگ:"
                Case StringId.ManageRuleCommonPreview
                Return "پیش نمایش:"
                Case StringId.ManageRuleNoFormatSet
                Return "بدون تعیین شکلبندی"
                Case StringId.ManageRuleColorScaleMidpoint
                Return "نقطه میانی"
                Case StringId.ManageRuleDataBarBarAppearance
                Return "ظاهر نوار:"
                Case StringId.ManageRuleDataBarFill
                Return "را پر کنید:"
                Case StringId.ManageRuleDataBarBorder
                Return "مرز:"
                Case StringId.ManageRuleDataBarDrawAxis
                Return "قرعه کشی محور"
                Case StringId.ManageRuleDataBarUseNegativeBar
                Return "استفاده از نوار منفی"
                Case StringId.ManageRuleDataBarAxisColor
                Return "رنگ محور:"
                Case StringId.ManageRuleDataBarBarDirection
                Return "نوار جهت"
                Case StringId.ManageRuleDataBarSolidFill
                Return "جامد را پر کنید"
                Case StringId.ManageRuleDataBarGradientFill
                Return "پر شیب"
                Case StringId.ManageRuleDataBarNoBorder
                Return "بدون کادر"
                Case StringId.ManageRuleDataBarSolidBorder
                Return "مرز جامد"
                Case StringId.ManageRuleDataBarContext
                Return "چهار چوب"
                Case StringId.ManageRuleDataBarLTR
                Return "چپ به راست"
                Case StringId.ManageRuleDataBarRTL
                Return "راست به چپ"
                Case StringId.ManageRuleIconSetsDisplayEachIconAccordingToTheseRules
                Return "هر یک از آیکون با توجه به این قوانین را نمایش می دهند:"
                Case StringId.ManageRuleIconSetsReverseIconOrder
                Return "سفارش های نماد معکوس"
                Case StringId.ManageRuleIconSetsWhen
                Return "وقتی"
                Case StringId.ManageRuleIconSetsValueIs
                Return "ارزش است"
                Case StringId.ManageRuleSimpleRuleBaseFormat
                Return "فرمت..."
                Case StringId.ManageRuleAverageFormatValuesThatAre
                Return "ارزش قالب هستند که:"
                Case StringId.ManageRuleAverageTheAverageForTheSelectedRange
                Return "متوسط ارزش های ستون"
                Case StringId.ManageRuleAverageAbove
                Return "بالا"
                Case StringId.ManageRuleAverageBelow
                Return "زیر"
                Case StringId.ManageRuleAverageEqualOrAbove
                Return "مساوی یا بالاتر"
                Case StringId.ManageRuleAverageEqualOrBelow
                Return "مساوی یا زیر"
                Case StringId.ManageRuleFormulaFormatValuesWhereThisFormulaIsTrue
                Return "ارزش های فرمت که در آن این فرمول درست است:"
                Case StringId.ManageRuleRankedValuesFormatValuesThatRankInThe
                Return "قالب ارزش این رتبه در:"
                Case StringId.ManageRuleRankedValuesOfTheColumnsCellValues
                Return "درصد از ارزش های ستون"
                Case StringId.ManageRuleRankedValuesTop
                Return "بالا"
                Case StringId.ManageRuleRankedValuesBottom
                Return "پایین"
                Case StringId.ManageRuleThatContainFormatOnlyCellsWith
                Return "فقط سلول های با فرمت:"
                Case StringId.ManageRuleThatContainCellValue
                Return "مقدار سلول"
                Case StringId.ManageRuleThatContainDatesOccurring
                Return "تاریخ وقوع"
                Case StringId.ManageRuleThatContainSpecificText
                Return "متن خاص"
                Case StringId.ManageRuleThatContainBlanks
                Return "جاهای خالی"
                Case StringId.ManageRuleThatContainNoBlanks
                Return "هیچ شاهد"
                Case StringId.ManageRuleThatContainErrors
                Return "خطاهای"
                Case StringId.ManageRuleThatContainNoErrors
                Return "بدون خطا"
                Case StringId.ManageRuleCellValueBetween
                Return "بین"
                Case StringId.ManageRuleCellValueNotBetween
                Return "نیست بین"
                Case StringId.ManageRuleCellValueEqualTo
                Return "برابر با"
                Case StringId.ManageRuleCellValueNotEqualTo
                Return "نامساوی با"
                Case StringId.ManageRuleCellValueGreaterThan
                Return "بزرگتر از"
                Case StringId.ManageRuleCellValueLessThan
                Return "کمتر از"
                Case StringId.ManageRuleCellValueGreaterThanOrEqualTo
                Return "بزرگتر از یا برابر با"
                Case StringId.ManageRuleCellValueLessThanOrEqualTo
                Return "کمتر از یا مساوی با"
                Case StringId.ManageRuleDatesOccurringBeyond
                Return "پس از ماه در 2 ماه زمان"
                Case StringId.ManageRuleDatesOccurringBeyondThisYear
                Return "پس از این سال"
                Case StringId.ManageRuleDatesOccurringEarlier
                Return "قبل از ماه 6 ماه پیش"
                Case StringId.ManageRuleDatesOccurringEarlierThisMonth
                Return "این ماه قبل از هفته گذشته"
                Case StringId.ManageRuleDatesOccurringEarlierThisWeek
                Return "این هفته قبل از دیروز"
                Case StringId.ManageRuleDatesOccurringEarlierThisYear
                Return "امسال قبل از این ماه"
                Case StringId.ManageRuleDatesOccurringLastWeek
                Return "هفته ی قبل"
                Case StringId.ManageRuleDatesOccurringLaterThisMonth
                Return "این ماه فراتر از هفته آینده"
                Case StringId.ManageRuleDatesOccurringLaterThisWeek
                Return "جاری از فردا"
                Case StringId.ManageRuleDatesOccurringLaterThisYear
                Return "امسال فراتر از این ماه"
                Case StringId.ManageRuleDatesOccurringMonthAfter1
                Return "ماه آینده"
                Case StringId.ManageRuleDatesOccurringMonthAfter2
                Return "در طول ماه در 2 ماه زمان"
                Case StringId.ManageRuleDatesOccurringMonthAgo1
                Return "ماه گذشته"
                Case StringId.ManageRuleDatesOccurringMonthAgo2
                Return "در طول ماه 2 هفته پیش"
                Case StringId.ManageRuleDatesOccurringMonthAgo3
                Return "در طول ماه 3 هفته پیش"
                Case StringId.ManageRuleDatesOccurringMonthAgo4
                Return "در طول ماه 4 هفته پیش"
                Case StringId.ManageRuleDatesOccurringMonthAgo5
                Return "در طول ماه 5 ماه پیش"
                Case StringId.ManageRuleDatesOccurringMonthAgo6
                Return "در طول ماه 6 ماه پیش"
                Case StringId.ManageRuleDatesOccurringNextWeek
                Return "هفته ی بعد"
                Case StringId.ManageRuleDatesOccurringPriorThisYear
                Return "قبل از این سال"
                Case StringId.ManageRuleDatesOccurringThisMonth
                Return "این ماه"
                Case StringId.ManageRuleDatesOccurringThisWeek
                Return "این هفته"
                Case StringId.ManageRuleDatesOccurringTomorrow
                Return "فردا"
                Case StringId.ManageRuleDatesOccurringToday
                Return "امروز"
                Case StringId.ManageRuleDatesOccurringYesterday
                Return "دیروز"
                Case StringId.ManageRuleSpecificTextContaining
                Return "شامل"
                Case StringId.ManageRuleSpecificTextNotContaining
                Return "شامل نیست"
                Case StringId.ManageRuleSpecificTextBeginningWith
                Return "شروع با"
                Case StringId.ManageRuleSpecificTextEndingWith
                Return "خاتم"
                Case StringId.ManageRuleUniqueOrDuplicateFormatAll
                Return "همه فرمت:"
                Case StringId.ManageRuleUniqueOrDuplicateValuesInTheSelectedRange
                Return "ارزش های ستون"
                Case StringId.ManageRuleUniqueOrDuplicateUnique
                Return "منحصر به فرد"
                Case StringId.ManageRuleUniqueOrDuplicateDuplicate
                Return "تکراری"
                Case StringId.ManageRuleColorScale
                Return "مقیاس مدرج رنگ"
                Case StringId.ManageRuleIconSet
                Return "مجموعه آیکون"
                Case StringId.ManageRuleFormula
                Return "فرمول"
                Case StringId.ManageRuleAboveAverage
                Return "بالاتر از حد متوسط"
                Case StringId.ManageRuleBelowAverage
                Return "زیر متوسط"
                Case StringId.ManageRuleEqualOrAboveAverage
                Return "مساوی و یا بالاتر از حد متوسط"
                Case StringId.ManageRuleEqualOrBelowAverage
                Return "مساوی و یا زیر متوسط"
                Case StringId.ManageRuleFormatCellsCaption
                Return "شکلبندی سلولها"
                Case StringId.ManageRuleFormatCellsFont
                Return "نوع خط"
                Case StringId.ManageRuleFormatCellsFill
                Return "پر کردن"
                Case StringId.ManageRuleFormatCellsPredefinedAppearance
                Return "ظاهر از پیش تعریف شده"
                Case StringId.ManageRuleFormatCellsFontStyle
                Return "سبک نوع خط"
                Case StringId.ManageRuleFormatCellsFontColor
                Return "رنگ قلم"
                Case StringId.ManageRuleFormatCellsEffects
                Return "عوارض:"
                Case StringId.ManageRuleFormatCellsUnderline
                Return "زیر خط"
                Case StringId.ManageRuleFormatCellsStrikethrough
                Return "خط زدن"
                Case StringId.ManageRuleFormatCellsClear
                Return "روشن"
                Case StringId.ManageRuleFormatCellsBackgroundColor
                Return "رنگ پس زمینه:"
                Case StringId.ManageRuleFormatCellsNone
                Return "هیچ کدام"
                Case StringId.ManageRuleFormatCellsRegular
                Return "منظم"
                Case StringId.ManageRuleFormatCellsBold
                Return "توپر"
                Case StringId.ManageRuleFormatCellsItalic
                Return "کج"
                Case StringId.TakePictureDialogTitle
                Return "گرفتن عکس"
                Case StringId.TakePictureMenuItem
                Return "گرفتن عکس از دوربین"
                Case StringId.TakePictureDialogCapture
                Return "ضبط"
                Case StringId.TakePictureDialogTryAgain
                Return "دوباره امتحان کن"
                Case StringId.TakePictureDialogSave
                Return "ذخیره"
                Case StringId.CameraSettingsActiveDevice
                Return "دستگاه های فعال:"
                Case StringId.CameraSettingsBrightness
                Return "روشنایی:"
                Case StringId.CameraSettingsContrast
                Return "کنتراست:"
                Case StringId.CameraSettingsDesaturate
                Return "باطل کردن اشباع:"
                Case StringId.CameraSettingsDefaults
                Return "تنظیم مجدد به صورت پیش فرض"
                Case StringId.CameraSettingsCaption
                Return "تنظیمات دوربین"
                Case StringId.CameraSettingsResolution
                Return "وضوح تصویر:"
                Case StringId.CameraDeviceNotFound
                Return "کم در بر داشت. اتصال وب کم و یا تنظیمات دستگاه را بررسی کنید."
                Case StringId.CameraDeviceIsBusy
                Return "آیا استفاده از دستگاه، به عنوان آن در حال حاضر در استفاده در دیگر برنامه نمی تواند."
                Case StringId.CameraDesignTimeInfo
                Return "رندر در زمان طراحی غیرفعال شده است."
                Case StringId.OfficeNavigationOptions
                Return "گزینه های ناوبری"

                Case Else
                Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class
    Public Class ArabicEditorLocalizer
        Inherits XtraEditors.Controls.Localizer

        Public Overrides Function GetLocalizedString(ByVal id As StringId) As String
            Select Case id
                Case StringId.FilterCriteriaToStringFunctionIsThisWeek
                Return "هذا الأسبوع"
                Case StringId.IconSetCategoryDirectional
                Return "اتجاهي"
                Case StringId.ManageRuleCellValueBetween
                Return "بين"
                Case StringId.CaptionError
                Return "خطأ"
                Case StringId.ColorPickGreenValidationMsg
                Return "ينبغي أن يكون العنصر الأخضر في مجموعة 0..255"
                Case StringId.FilterCriteriaToStringFunctionGetMilliSecond
                Return "الحصول على ميلي ثانية"
                Case StringId.FormatPredefinedAppearanceRedBoldText
                Return "أحمر غامق"
                Case StringId.FilterEditorTabVisual
                Return "البصرية"
                Case StringId.FilterShowAll
                Return "(تحديد الكل)"
                Case StringId.InvalidValueText
                Return "قيمة غير صالحة"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisYear
                Return "هذا العام"
                Case StringId.ManageRuleCellValueNotBetween
                Return "ليس بين"
                Case StringId.IconSetCategoryPositiveNegative
                Return "إيجابية/سلبية"
                Case StringId.CheckUnchecked
                Return "غير محدد"
                Case StringId.FormatPredefinedAppearanceGreenBoldText
                Return "أخضر غامق"
                Case StringId.ColorPickBlueValidationMsg
                Return "ينبغي أن يكون العنصر الأزرق في مجموعة 0..255"
                Case StringId.FilterGroupAnd
                Return "و"
                Case StringId.CheckChecked
                Return "فحص"
                Case StringId.FilterCriteriaToStringFunctionGetSecond
                Return "الحصول على الثانية"
                Case StringId.FilterGroupNotOr
                Return "لا أو"
                Case StringId.ColorScaleGreenYellowRed
                Return "أحمر-أصفر-أخضر"
                Case StringId.CheckIndeterminate
                Return "غير محدد"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisMonth
                Return "هذا الشهر"
                Case StringId.SearchForColumn
                Return "البحث عن عمود..."
                Case StringId.ManageRuleCellValueEqualTo
                Return "يساوي"
                Case StringId.ColorPickOpacityValidationMsg
                Return "ينبغي أن يكون العنصر العتامة في مجموعة 0..255"
                Case StringId.FilterGroupNotAnd
                Return "لا و"
                Case StringId.FilterCriteriaToStringFunctionGetMinute
                Return "الحصول على دقيقة"
                Case StringId.SearchControlNullValuePrompt
                Return "أدخل نص للبحث..."
                Case StringId.ColorScalePurpleWhiteAzure
                Return "أرجواني-أبيض-أزور"
                Case StringId.FilterGroupOr
                Return "أو"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeLastWeek
                Return "الأسبوع الماضي"
                Case StringId.ManageRuleCellValueNotEqualTo
                Return "لا يساوي"
                Case StringId.Cancel
                Return "إلغاء الأمر"
                Case StringId.SearchForField
                Return "البحث عن حقل..."
                Case StringId.ColorPickColorHexValidationMsg
                Return "القيمة الست عشرية غير صالحة"
                Case StringId.FilterCriteriaToStringFunctionGetHour
                Return "الحصول على مدار"
                Case StringId.FilterClauseAnyOf
                Return "أي من"
                Case StringId.FilterClauseContains
                Return "يحتوي على"
                Case StringId.DateEditToday
                Return "اليوم"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisWeek
                Return "هذا الأسبوع"
                Case StringId.ColorScaleYellowOrangeCoral
                Return "أصفر-أورانج-كورال"
                Case StringId.NavigatorFirstButtonHint
                Return "الأولى"
                Case StringId.ManageRuleCellValueGreaterThan
                Return "أكبر من"
                Case StringId.ColorPickHueValidationMsg
                Return "ينبغي أن يكون العنصر هوي في مجموعة 0..359"
                Case StringId.FilterCriteriaToStringFunctionGetDay
                Return "الحصول على يوم"
                Case StringId.FilterClauseEndsWith
                Return "ينتهي ب"
                Case StringId.ManageRuleCaption
                Return "إدارة قواعد التنسيق الشرطي"
                Case StringId.FilterClauseBeginsWith
                Return "يبدأ ب"
                Case StringId.DateEditClear
                Return "واضحة"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeYesterday
                Return "أمس"
                Case StringId.ManageRuleCellValueLessThan
                Return "أقل"
                Case StringId.ColorScaleGreenWhiteRed
                Return "أخضر-أبيض-أحمر"
                Case StringId.NavigatorPreviousButtonHint
                Return "السابقة"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeNow
                Return "الآن"
                Case StringId.ColorPickSaturationValidationMsg
                Return "ينبغي أن يكون العنصر التشبع في مجموعة 0..100"
                Case StringId.FilterCriteriaToStringFunctionGetMonth
                Return "احصل على شهر"
                Case StringId.FilterClauseEquals
                Return "يساوي"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeToday
                Return "اليوم"
                Case StringId.ManageRuleShowFormattingRules
                Return "إظهار القواعد على:"
                Case StringId.FilterClauseBetween
                Return "هو بين"
                Case StringId.OK
                Return "موافق"
                Case StringId.ManageRuleCellValueGreaterThanOrEqualTo
                Return "أكبر من أو يساوي"
                Case StringId.ColorPickBrightValidationMsg
                Return "ينبغي أن يكون مكون السطوع في مجموعة 0..100"
                Case StringId.FilterCriteriaToStringFunctionGetYear
                Return "الحصول على سنة"
                Case StringId.ColorScaleEmeraldAzureBlue
                Return "الزمرد-أزور--الأزرق"
                Case StringId.NavigatorPreviousPageButtonHint
                Return "الصفحة السابقة"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeTomorrow
                Return "غدا"
                Case StringId.FilterClauseGreater
                Return "أكبر من"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextWeek
                Return "الأسبوع القادم"
                Case StringId.ManageRuleUp
                Return "حتى"
                Case StringId.FilterClauseBetweenAnd
                Return "و"
                Case StringId.NavigatorNextButtonHint
                Return "القادم"
                Case StringId.ManageRuleCellValueLessThanOrEqualTo
                Return "أقل من أو يساوي"
                Case StringId.ColorTabWebSafeColors
                Return "ويب أمن"
                Case StringId.FilterCriteriaToStringFunctionGetDayOfWeek
                Return "الحصول على يوم من أيام الأسبوع"
                Case StringId.ColorScaleWhiteRed
                Return "أبيض-أحمر"
                Case StringId.NavigatorTextStringFormat
                Return "السجل {0} {1}"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeDayAfterTomorrow
                Return "بعد غد"
                Case StringId.FilterClauseGreaterOrEqual
                Return "أكبر من أو يساوي"
                Case StringId.ManageRuleDown
                Return "إلى أسفل"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeTwoWeeksAway
                Return "بعد أسبوعين"
                Case StringId.FilterClauseNoneOf
                Return "لا شيء من"
                Case StringId.NavigatorNextPageButtonHint
                Return "الصفحة التالية"
                Case StringId.ManageRuleDatesOccurringBeyond
                Return "بعد الشهر في غضون أشهر 2"
                Case StringId.Days
                Return "أيام"
                Case StringId.FilterCriteriaToStringFunctionGetDayOfYear
                Return "الحصول على يوم من أيام السنة"
                Case StringId.ColorScaleWhiteGreen
                Return "أبيض-أخضر"
                Case StringId.PictureEditMenuCut
                Return "قص"
                Case StringId.FilterClauseIsNotNull
                Return "ليست فارغة"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisWeek
                Return "في وقت لاحق من هذا الأسبوع"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextMonth
                Return "الشهر القادم"
                Case StringId.ManageRuleDatesOccurringBeyondThisYear
                Return "وفي أعقاب هذا العام"
                Case StringId.ManageRuleNewRule
                Return "قاعدة جديدة..."
                Case StringId.FilterClauseNotBetween
                Return "ليس بين"
                Case StringId.NavigatorLastButtonHint
                Return "آخر"
                Case StringId.Hours
                Return "ساعات"
                Case StringId.FilterCriteriaToStringFunctionGetTimeOfDay
                Return "الحصول على الوقت من اليوم"
                Case StringId.FilterClauseIsNull
                Return "فارغة"
                Case StringId.ColorScaleWhiteAzure
                Return "-الأبيض-الأزرق السماوي"
                Case StringId.PictureEditMenuCopy
                Return "نسخة"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalTomorrow
                Return "هو غدا"
                Case StringId.FilterCriteriaToStringFunctionAddMilliSeconds
                Return "إضافة ميلي ثانية"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextYear
                Return "العام القادم"
                Case StringId.ManageRuleDatesOccurringEarlier
                Return "قبل الشهر من 6 أشهر"
                Case StringId.ManageRuleEditRule
                Return "قم بتحرير القاعدة..."
                Case StringId.FilterClauseDoesNotContain
                Return "لا يحتوي على"
                Case StringId.Mins
                Return "دقيقة"
                Case StringId.NavigatorAppendButtonHint
                Return "إلحاق"
                Case StringId.FilterCriteriaToStringFunctionNow
                Return "الآن"
                Case StringId.ColorScaleYellowGreen
                Return "أصفر-أخضر"
                Case StringId.PictureEditMenuPaste
                Return "لصق"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalToday
                Return "اليوم"
                Case StringId.FilterClauseIsNotNullOrEmpty
                Return "ليس فارغاً"
                Case StringId.FilterCriteriaToStringFunctionAddSeconds
                Return "إضافة ثانية"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalBeyondThisYear
                Return "هو أبعد من هذا العام"
                Case StringId.IncorrectNumberCopies
                Return "يجب أن يكون العدد بين 1 و 32767."
                Case StringId.ManageRuleDatesOccurringEarlierThisMonth
                Return "هذا الشهر، قبل الأسبوع السابق"
                Case StringId.FilterCriteriaToStringFunctionUtcNow
                Return "الآن بالتوقيت العالمي"
                Case StringId.NavigatorRemoveButtonHint
                Return "حذف"
                Case StringId.ManageRuleDeleteRule
                Return "حذف قاعدة"
                Case StringId.FilterClauseDoesNotEqual
                Return "لا يساوي"
                Case StringId.FilterClauseIsNullOrEmpty
                Return "فارغة"
                Case StringId.FilterCriteriaToStringFunctionAddMinutes
                Return "إضافة دقائق"
                Case StringId.ColorScaleBlueWhiteRed
                Return "الأزرق-أبيض-أحمر"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisYear
                Return "في وقت لاحق من هذا العام"
                Case StringId.PictureEditMenuDelete
                Return "حذف"
                Case StringId.ManageRuleDatesOccurringEarlierThisWeek
                Return "هذا الأسبوع، قبل أمس"
                Case StringId.FilterCriteriaToStringFunctionToday
                Return "اليوم"
                Case StringId.NavigatorEditButtonHint
                Return "تحرير"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalYesterday
                Return "أمس"
                Case StringId.ChartRangeControlClientInvalidGrid
                Return "الفاصل الزمني بين خطوط الشبكة صغير جداً تكون ممثلة في مجموعة عنصر التحكم."
                Case StringId.ManageRuleGridCaptionRule
                Return "القاعدة"
                Case StringId.FilterClauseLess
                Return "هو أقل من"
                Case StringId.FilterClauseNotLike
                Return "ليس مثل"
                Case StringId.FilterCriteriaToStringFunctionAddHours
                Return "إضافة ساعة"
                Case StringId.Millisecs
                Return "ميليسيكس"
                Case StringId.FormatRuleMenuItemUnique
                Return "قيم فريدة"
                Case StringId.PictureEditMenuLoad
                Return "تحميل"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisMonth
                Return "في وقت لاحق من هذا الشهر"
                Case StringId.ManageRuleDatesOccurringEarlierThisYear
                Return "هذا العام، وقبل هذا الشهر"
                Case StringId.FilterCriteriaToStringFunctionAddTimeSpan
                Return "إضافة فترة زمنية"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisWeek
                Return "وفي وقت سابق من هذا الأسبوع"
                Case StringId.NavigatorEndEditButtonHint
                Return "تحرير نهاية"
                Case StringId.ChartRangeControlClientNoData
                Return "لا توجد بيانات لتمثيل في عنصر تحكم نطاق."
                Case StringId.ManageRuleGridCaptionFormat
                Return "تنسيق"
                Case StringId.FormatRuleMenuItemDuplicate
                Return "القيم المكررة"
                Case StringId.FilterClauseLessOrEqual
                Return "أقل من أو يساوي"
                Case StringId.FilterCriteriaToStringFunctionAddDays
                Return "إضافة أيام"
                Case StringId.DataBarGreen
                Return "شريط بيانات أخضر"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalNextWeek
                Return "الأسبوع المقبل"
                Case StringId.FormatRuleApplyFormatProperty
                Return "تطبيق تنسيق صف بأكمله"
                Case StringId.ManageRuleDatesOccurringLastWeek
                Return "الأسبوع الماضي"
                Case StringId.PictureEditMenuSave
                Return "حفظ"
                Case StringId.FilterCriteriaToStringFunctionAddTicks
                Return "إضافة علامات التجزئة"
                Case StringId.NavigatorCancelEditButtonHint
                Return "إلغاء التحرير"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLastWeek
                Return "الأسبوع الماضي"
                Case StringId.DataBarBlue
                Return "شريط بيانات أزرق"
                Case StringId.ManageRuleGridCaptionApplyToTheRow
                Return "تنطبق على الصف"
                Case StringId.FilterClauseLike
                Return "مثل"
                Case StringId.FilterCriteriaToStringFunctionAddMonths
                Return "إضافة الأشهر"
                Case StringId.DataBarYellow
                Return "شريط بيانات الأصفر"
                Case StringId.ManageRuleAllColumns
                Return "(الكل)"
                Case StringId.FilterCriteriaToStringFunctionConcat
                Return "Concat"
                Case StringId.ManageRuleDatesOccurringLaterThisMonth
                Return "هذا الشهر، إلى ما بعد الأسبوع المقبل"
                Case StringId.FilterCriteriaToStringFunctionStartsWith
                Return "يبدأ ب"
                Case StringId.FormatRuleWith
                Return "مع"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisMonth
                Return "وفي وقت سابق من هذا الشهر"
                Case StringId.PictureEditSaveFileFilter
                Return "صورة نقطية (*.bmp) الملفات | *. bmp| تنسيق تبادل الرسومات (*.gif) | *. gif| تنسيق تبادل ملف JPEG (*.jpg) | *. jpg| تنسيق رسومات الشبكة للأجهزة المحمولة (*.png) | *.png"
                Case StringId.IconSetTitleTrafficLights3Rimmed
                Return "3 إشارات مرور (انعقدت)"
                Case StringId.FilterEmptyValue
                Return "<empty></empty>"
                Case StringId.DataBarLightBlue
                Return "الضوء الأزرق شريط البيانات"
                Case StringId.ManageRuleGridCaptionColumn
                Return "العمود"
                Case StringId.FilterMenuAddNewParameter
                Return "إضافة معلمة..."
                Case StringId.FilterCriteriaToStringFunctionAddYears
                Return "إضافة السنوات"
                Case StringId.FilterCriteriaToStringFunctionAscii
                Return "آسكي"
                Case StringId.DataBarOrange
                Return "شريط بيانات برتقالي"
                Case StringId.ManageRuleDatesOccurringLaterThisWeek
                Return "هذا الأسبوع، إلى ما بعد الغد"
                Case StringId.NewFormattingRule
                Return "قاعدة تنسيق جديدة"
                Case StringId.FormatRuleForThisColumnWith
                Return "لهذا العمود مع"
                Case StringId.FilterCriteriaToStringFunctionEndsWith
                Return "ينتهي ب"
                Case StringId.PictureEditOpenFileTitle
                Return "فتح"
                Case StringId.IconSetTitleSigns3
                Return "3 علامات"
                Case StringId.ColorTabWeb
                Return "ويب"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisYear
                Return "وفي وقت سابق من هذا العام"
                Case StringId.FilterMenuConditionAdd
                Return "إضافة شرط"
                Case StringId.ProgressExport
                Return "تصدير"
                Case StringId.FormatRuleMenuItemClearColumnRules
                Return "مسح القواعد من هذا العمود"
                Case StringId.FilterCriteriaToStringFunctionChar
                Return "شار"
                Case StringId.NewEditFormattingRuleSelectARuleType
                Return "حدد نوع قاعدة:"
                Case StringId.FilterCriteriaToStringUnaryOperatorIsNull
                Return "فارغة"
                Case StringId.DataBarMint
                Return "شريط بيانات النعناع"
                Case StringId.ManageRuleDatesOccurringLaterThisYear
                Return "هذا العام، وبعد هذا الشهر"
                Case StringId.FilterCriteriaToStringFunctionContains
                Return "يحتوي على"
                Case StringId.PictureEditSaveFileTitle
                Return "حفظ باسم"
                Case StringId.EditFormattingRule
                Return "تحرير قاعدة التنسيق"
                Case StringId.IconSetTitleStars3
                Return "نجوم 3"
                Case StringId.ColorTabSystem
                Return "نظام"
                Case StringId.IconSetTitleTrafficLights4
                Return "4 إشارات المرور"
                Case StringId.FilterMenuGroupAdd
                Return "إضافة مجموعة"
                Case StringId.ProgressPrinting
                Return "الطباعة"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalPriorThisYear
                Return "قبل هذا العام"
                Case StringId.FilterCriteriaToStringFunctionToInt
                Return "إلى int"
                Case StringId.ManageRuleDatesOccurringToday
                Return "اليوم"
                Case StringId.ManageRuleDatesOccurringMonthAfter1
                Return "الشهر القادم"
                Case StringId.FormatRuleMenuItemClearAllRules
                Return "قواعد واضحة من كافة الأعمدة"
                Case StringId.NewEditFormattingRuleEditTheRuleDescription
                Return "تحرير وصف القاعدة:"
                Case StringId.FilterCriteriaToStringUnaryOperatorMinus
                Return "-"
                Case StringId.FilterCriteriaInvalidExpression
                Return "التعبير المحدد يحتوي على رموز غير صالح (خط {0}، حرف {1})."
                Case StringId.DataBarViolet
                Return "شريط بيانات الأشعة فوق البنفسجية"
                Case StringId.ManageRuleCommonPercent
                Return "في المائة"
                Case StringId.PictureEditOpenFileError
                Return "تنسيق صورة خاطئة"
                Case StringId.IconSetTitleRedToBlack
                Return "الأحمر إلى الأسود"
                Case StringId.IconSetTitleRatings4
                Return "تصنيفات 4"
                Case StringId.CalcButtonMC
                Return "مولودية"
                Case StringId.FilterMenuClearAll
                Return "مسح الكل"
                Case StringId.FilterCriteriaToStringFunctionCustom
                Return "مخصص"
                Case StringId.ProgressCreateDocument
                Return "إنشاء المستند"
                Case StringId.FilterCriteriaToStringFunctionToLong
                Return "لفترة طويلة"
                Case StringId.FormatRuleMenuItemHighlightCellRules
                Return "قواعد تمييز الخلايا"
                Case StringId.ManageRuleDatesOccurringYesterday
                Return "أمس"
                Case StringId.NewEditFormattingRuleFormatAllCellsBasedOnTheirValues
                Return "تنسيق كافة الخلايا استناداً إلى قيمها"
                Case StringId.FilterCriteriaToStringUnaryOperatorNot
                Return "لا"
                Case StringId.ManageRuleDatesOccurringMonthAfter2
                Return "وخلال هذا الشهر في غضون أشهر 2"
                Case StringId.FilterCriteriaInvalidExpressionEx
                Return "التعبير المحدد غير صالح."
                Case StringId.DataBarRaspberry
                Return "شريط بيانات التوت"
                Case StringId.ManageRuleCommonNumber
                Return "عدد"
                Case StringId.IconSetTitleRatings5
                Return "تصنيفات 5"
                Case StringId.PictureEditOpenFileErrorCaption
                Return "خطأ في فتح"
                Case StringId.IconSetTitleSymbols3Circled
                Return "3 رموز (دائري)"
                Case StringId.FilterCriteriaToStringFunctionCustomNonDeterministic
                Return "مخصص غير قطعية"
                Case StringId.CalcButtonMR
                Return "السيد"
                Case StringId.ProgressCancel
                Return "إلغاء الأمر"
                Case StringId.FilterMenuRowRemove
                Return "إزالة مجموعة"
                Case StringId.FormatRuleMenuItemTopBottomRules
                Return "القواعد العليا/السفلي"
                Case StringId.FilterCriteriaToStringFunctionToFloat
                Return "لتعويم"
                Case StringId.ManageRuleSpecificTextContaining
                Return "يحتوي على"
                Case StringId.ManageRuleDatesOccurringMonthAgo1
                Return "الشهر الماضي"
                Case StringId.NewEditFormattingRuleFormatOnlyCellsThatContain
                Return "تنسيق الخلايا التي تحتوي على فقط"
                Case StringId.FilterCriteriaToStringUnaryOperatorPlus
                Return "+"
                Case StringId.TabHeaderButtonPin
                Return "رقم التعريف الشخصي"
                Case StringId.Apply
                Return "تطبيق"
                Case StringId.PictureEditCopyImageError
                Return "تعذر نسخ الصورة"
                Case StringId.IconSetTitleSymbols3Uncircled
                Return "3 رموز (أونسيركليد)"
                Case StringId.DataBarCoral
                Return "شريط بيانات الشعاب"
                Case StringId.ManageRuleCommonValue
                Return "القيمة:"
                Case StringId.IconSetTitleQuarters5
                Return "5 أرباع"
                Case StringId.FilterCriteriaToStringFunctionIsNullOrEmpty
                Return "غير صحيح أو فارغ"
                Case StringId.ProgressCancelPending
                Return "إلغاء تعليق"
                Case StringId.FilterCriteriaToStringFunctionToDouble
                Return "أن يتضاعف"
                Case StringId.CalcButtonMS
                Return "مرض التصلب العصبي المتعدد"
                Case StringId.FilterToolTipNodeAdd
                Return "إضافة شرط جديد لهذه المجموعة"
                Case StringId.FormatRuleMenuItemDataBars
                Return "أشرطة البيانات"
                Case StringId.ManageRuleSpecificTextNotContaining
                Return "لا تحتوي على"
                Case StringId.ManageRuleDatesOccurringMonthAgo2
                Return "خلال شهر قبل 2 أشهر"
                Case StringId.PreviewPanelText
                Return "معاينة:"
                Case StringId.NewEditFormattingRuleFormatOnlyTopOrBottomRankedValues
                Return "تنسيق فقط أعلى أو أسفل ترتيب القيم"
                Case StringId.FilterCriteriaToStringBinaryOperatorBitwiseAnd
                Return "&"
                Case StringId.LookUpEditValueIsNull
                Return "[اديتفالوي فارغ]"
                Case StringId.IconSetTitleFlags3
                Return "3 إشارات"
                Case StringId.FilterCriteriaToStringFunctionCos
                Return "كوس"
                Case StringId.TabHeaderButtonUnpin
                Return "إلغاء التثبيت"
                Case StringId.ProgressLoadingData
                Return "تحميل البيانات"
                Case StringId.FilterCriteriaToStringFunctionToDecimal
                Return "إلى رقم عشري."
                Case StringId.DataBarBlueGradient
                Return "شريط بيانات أزرق التدرج"
                Case StringId.ManageRuleCommonColor
                Return "اللون:"
                Case StringId.ManageRuleSpecificTextBeginningWith
                Return "بداية مع"
                Case StringId.IconSetTitleBoxes5
                Return "5 مربعات"
                Case StringId.CalcButtonMx
                Return "M +"
                Case StringId.ManageRuleDatesOccurringMonthAgo3
                Return "خلال شهر قبل 3 أشهر"
                Case StringId.FilterToolTipNodeRemove
                Return "يزيل هذا الشرط"
                Case StringId.FormatRuleMenuItemColorScales
                Return "تدرجات الألوان"
                Case StringId.TransparentBackColorNotSupported
                Return "لا يدعم عنصر التحكم هذا ألوان خلفية شفافة"
                Case StringId.LookUpInvalidEditValueType
                Return "نوع اديتفالوي لوكوبيديت غير صالح."
                Case StringId.IconSetTitlePositiveNegativeArrows
                Return "سهام (ملونة)"
                Case StringId.FilterCriteriaToStringFunctionSin
                Return "الخطيئة"
                Case StringId.FilterAggregateAvg
                Return "متوسط"
                Case StringId.NewEditFormattingRuleFormatOnlyValuesThatAreAboveOrBelowAverage
                Return "تنسيق القيم التي تقع فوق المتوسط أو تحته"
                Case StringId.FilterCriteriaToStringBinaryOperatorBitwiseOr
                Return "|"
                Case StringId.TabHeaderSelectorButton
                Return "إظهار قائمة النافذة"
                Case StringId.FilterCriteriaToStringFunctionToStr
                Return "للإبلاغ عن المعاملات المشبوهة"
                Case StringId.ManageRuleSpecificTextEndingWith
                Return "تنتهي مع"
                Case StringId.ManageRuleDatesOccurringMonthAgo4
                Return "وخلال شهر منذ 4 أشهر"
                Case StringId.DataBarLightBlueGradient
                Return "الضوء الأزرق البيانات شريط التدرج"
                Case StringId.ManageRuleCommonPreview
                Return "معاينة:"
                Case StringId.IconSetTitleArrows3Colored
                Return "3 أسهم (ملونة)"
                Case StringId.FilterOutlookDateText
                Return "إظهار all| إظهار Empty| تصفية حسب تاريخ: |Beyond محددة هذا year| وبعد هذا year| وبعد هذا month| Week| القادم وبعد هذا week| Tomorrow| Today| Yesterday| وفي وقت سابق هذا week| Week| الماضي وفي وقت سابق هذا month| وفي وقت سابق هذا year| قبل هذا العام"
                Case StringId.LookUpColumnDefaultName
                Return "الاسم"
                Case StringId.IconSetTitlePositiveNegativeArrowsGray
                Return "سهام (رمادي)"
                Case StringId.CalcButtonSqrt
                Return "والجذر التربيعي"
                Case StringId.FilterToolTipNodeAction
                Return "الإجراءات"
                Case StringId.FormatRuleMenuItemIconSets
                Return "مجموعات الرموز"
                Case StringId.FilterCriteriaToStringFunctionAtn
                Return "Atn"
                Case StringId.FilterAggregateCount
                Return "العد"
                Case StringId.FilterCriteriaToStringBinaryOperatorMultiply
                Return "*"
                Case StringId.NewEditFormattingRuleFormatOnlyUniqueOrDuplicateValues
                Return "تنسيق القيم الفريدة أو المتكررة فقط"
                Case StringId.FilterCriteriaToStringBinaryOperatorBitwiseXor
                Return "^"
                Case StringId.FilterCriteriaToStringFunctionReplace
                Return "استبدال"
                Case StringId.XtraMessageBoxOkButtonText
                Return "آند موافق"
                Case StringId.ManageRuleUniqueOrDuplicateFormatAll
                Return "تنسيق كافة:"
                Case StringId.ManageRuleDatesOccurringMonthAgo5
                Return "وخلال هذا الشهر قبل 5 أشهر"
                Case StringId.DataBarGreenGradient
                Return "التدرج الأخضر شريط البيانات"
                Case StringId.FilterDateTimeConstantMenuCaption
                Return "ثوابت التاريخ والوقت"
                Case StringId.ManageRuleNoFormatSet
                Return "لم يتم تعيين تنسيق"
                Case StringId.UnknownPictureFormat
                Return "تنسيق الصورة غير معروف"
                Case StringId.IconSetTitleArrows3Gray
                Return "3 أسهم (رمادي)"
                Case StringId.IconSetTitlePositiveNegativeTriangles
                Return "مثلثات"
                Case StringId.CalcButtonBack
                Return "مرة أخرى"
                Case StringId.FilterCriteriaToStringFunctionExp
                Return "أكسب"
                Case StringId.FilterAggregateExists
                Return "موجود"
                Case StringId.FilterCriteriaToStringBinaryOperatorNotEqual
                Return "<>"
                Case StringId.FilterToolTipValueType
                Return "مقارنة مع قيمة أخرى قيمة الحقل"
                Case StringId.FormatRuleMenuItemClearRules
                Return "قواعد واضحة"
                Case StringId.FilterCriteriaToStringFunctionReverse
                Return "عكس"
                Case StringId.ManageRuleUniqueOrDuplicateValuesInTheSelectedRange
                Return "قيم العمود"
                Case StringId.ManageRuleDatesOccurringMonthAgo6
                Return "وخلال هذا الشهر قبل 6 أشهر"
                Case StringId.NewEditFormattingRuleUseAFormulaToDetermineWhichCellsToFormat
                Return "استخدام صيغة لتحديد الخلايا التي سيتم تنسيقها"
                Case StringId.FilterCriteriaToStringBinaryOperatorDivide
                Return "/"
                Case StringId.XtraMessageBoxCancelButtonText
                Return "آند إلغاء الأمر"
                Case StringId.FilterDateTimeOperatorMenuCaption
                Return "عوامل التاريخ والوقت"
                Case StringId.DataEmpty
                Return "لا توجد بيانات الصورة"
                Case StringId.FormatRuleMenuItemTop10Items
                Return "أحدث 10 عناصر"
                Case StringId.DataBarYellowGradient
                Return "تدرج اللون الأصفر شريط البيانات"
                Case StringId.ManageRuleColorScaleMidpoint
                Return "نقطة الوسط"
                Case StringId.IconSetTitleTriangles3
                Return "3 مثلثات"
                Case StringId.FilterCriteriaToStringFunctionLog
                Return "سجل"
                Case StringId.FilterAggregateMax
                Return "ماكس"
                Case StringId.FilterCriteriaToStringBinaryOperatorPlus
                Return "+"
                Case StringId.CalcButtonCE
                Return "CE"
                Case StringId.FilterToolTipElementAdd
                Return "إضافة عنصر جديد إلى القائمة"
                Case StringId.FilterCriteriaToStringFunctionAtn2
                Return "Atn2"
                Case StringId.FilterCriteriaToStringFunctionInsert
                Return "إدراج"
                Case StringId.ManageRuleUniqueOrDuplicateUnique
                Return "فريدة من نوعها"
                Case StringId.ManageRuleDatesOccurringNextWeek
                Return "الأسبوع القادم"
                Case StringId.FormatRuleMenuItemManageRules
                Return "إدارة القواعد..."
                Case StringId.ManageRuleComplexRuleBaseFormatStyle
                Return "نمط التنسيق:"
                Case StringId.FilterCriteriaToStringBinaryOperatorEqual
                Return "="
                Case StringId.FilterDateTextAlt
                Return "إظهار all| إظهار Empty| تصفية بواسطة محددة تاريخ: |Beyond||| Week| القادم Today| هذا week| هذا month| Earlier| {0:yyyy}، {0: ش ش ش ش}"
                Case StringId.NotValidArrayLength
                Return "طول الصفيف غير صالحة."
                Case StringId.FormatRuleMenuItemTop10Percent
                Return "أعلى 10 ٪"
                Case StringId.XtraMessageBoxYesButtonText
                Return "آند نعم"
                Case StringId.DataBarOrangeGradient
                Return "شريط بيانات أورانج التدرج"
                Case StringId.ManageRuleDataBarBarAppearance
                Return "شريط مظهر:"
                Case StringId.FilterCriteriaToStringFunctionRnd
                Return "التجمع الوطني الديمقراطي"
                Case StringId.FilterAggregateMin
                Return "دقيقة"
                Case StringId.FilterCriteriaToStringBetween
                Return "بين"
                Case StringId.IconSetTitleArrows4Colored
                Return "4 أسهم (ملونة)"
                Case StringId.CalcButtonC
                Return "ج"
                Case StringId.FilterCriteriaToStringFunctionCharIndex
                Return "فهرس شار"
                Case StringId.ManageRuleUniqueOrDuplicateDuplicate
                Return "مكرر"
                Case StringId.ManageRuleDatesOccurringPriorThisYear
                Return "قبل هذا العام"
                Case StringId.FilterToolTipKeysAdd
                Return "(استخدام الإدراج أو إضافة مفتاح)"
                Case StringId.FilterCriteriaToStringFunctionBigMul
                Return "مول كبير"
                Case StringId.FilterFunctionsMenuCaption
                Return "الوظائف"
                Case StringId.ImagePopupEmpty
                Return "(فارغ)"
                Case StringId.FormatRuleMenuItemUniqueDuplicateRules
                Return "قواعد مكررة/فريدة من نوعها"
                Case StringId.ManageRuleColorScale2
                Return "الجدول 2-اللون"
                Case StringId.FormatRuleMenuItemBottom10Items
                Return "العناصر الموجودة أسفل 10"
                Case StringId.FilterCriteriaToStringFunctionTan
                Return "تان"
                Case StringId.FilterCriteriaToStringBinaryOperatorGreater
                Return ">"
                Case StringId.FilterAggregateSum
                Return "مجموع"
                Case StringId.FilterCriteriaToStringIn
                Return "في"
                Case StringId.XtraMessageBoxNoButtonText
                Return "آند لا"
                Case StringId.DataBarMintGradient
                Return "شريط بيانات منت التدرج"
                Case StringId.FilterCriteriaToStringFunctionRemove
                Return "إزالة"
                Case StringId.ManageRuleColorScale
                Return "مقياس متدرج الألوان"
                Case StringId.ManageRuleDatesOccurringThisMonth
                Return "هذا الشهر"
                Case StringId.ManageRuleDataBarFill
                Return "التعبئة:"
                Case StringId.IconSetTitleArrows4Gray
                Return "4 أسهم (رمادي)"
                Case StringId.CalcError
                Return "خطأ في الحساب"
                Case StringId.DefaultBooleanTrue
                Return "صحيح"
                Case StringId.ImagePopupPicture
                Return "(صورة)"
                Case StringId.FormatRuleMenuItemBottom10Percent
                Return "أسفل 10%"
                Case StringId.FilterToolTipKeysRemove
                Return "(استخدم الحذف أو طرح المفتاح)"
                Case StringId.FilterCriteriaToStringFunctionCosh
                Return "كوش"
                Case StringId.FormatRuleMenuItemGradientFill
                Return "تعبئة متدرجة"
                Case StringId.FilterPopupToolbarShowOnlyAvailableItems
                Return "تظهر فقط العناصر المتوفرة"
                Case StringId.FilterCriteriaToStringFunctionPower
                Return "الطاقة"
                Case StringId.FieldListName
                Return "قائمة الحقول ({0})"
                Case StringId.ManageRuleColorScale3
                Return "تدرج ألوان ثلاثي"
                Case StringId.FilterCriteriaToStringBinaryOperatorGreaterOrEqual
                Return ">="
                Case StringId.XtraMessageBoxAbortButtonText
                Return "آند إحباط"
                Case StringId.FilterCriteriaToStringIsNotNull
                Return "ليست فارغة"
                Case StringId.FilterCriteriaToStringFunctionAbs
                Return "القيمة المطلقة"
                Case StringId.ManageRuleIconSet
                Return "رمز المجموعة"
                Case StringId.DataBarVioletGradient
                Return "التدرج البنفسجي شريط البيانات"
                Case StringId.ManageRuleDataBarBorder
                Return "الحدود:"
                Case StringId.IconSetTitleArrows5Colored
                Return "5 أسهم (ملونة)"
                Case StringId.ManageRuleDatesOccurringThisWeek
                Return "هذا الأسبوع"
                Case StringId.DefaultBooleanFalse
                Return "كاذبة"
                Case StringId.ColorTabCustom
                Return "مخصص"
                Case StringId.TabHeaderButtonPrev
                Return "قم بالتمرير لليسار"
                Case StringId.ContainerAccessibleEditName
                Return "تحرير عنصر التحكم"
                Case StringId.FilterCriteriaToStringFunctionLog10
                Return "Log10"
                Case StringId.FormatRuleMenuItemAboveAverage
                Return "فوق المتوسط"
                Case StringId.FilterPopupToolbarShowNewValues
                Return "إظهار قيم حقل جديد"
                Case StringId.FilterCriteriaToStringFunctionSign
                Return "تسجيل الدخول"
                Case StringId.FormatRuleMenuItemSolidFill
                Return "تعبئة خالصة"
                Case StringId.ManageRuleDataBar
                Return "شريط البيانات"
                Case StringId.FilterCriteriaToStringBinaryOperatorLess
                Return "<"
                Case StringId.XtraMessageBoxRetryButtonText
                Return "آند إعادة المحاولة"
                Case StringId.DataBarRaspberryGradient
                Return "شريط بيانات التوت التدرج"
                Case StringId.RestoreLayoutDialogFileFilter
                Return "ملفات XML (*.xml) | *. xml| جميع files| *. *"
                Case StringId.ManageRuleDataBarDrawAxis
                Return "رسم المحور"
                Case StringId.FilterCriteriaToStringNotLike
                Return "ليس مثل"
                Case StringId.FilterCriteriaToStringFunctionSqr
                Return "Sqr"
                Case StringId.IconSetTitleArrows5Gray
                Return "5 أسهم (رمادي)"
                Case StringId.ManageRuleFormula
                Return "الصيغة"
                Case StringId.IconSetCategoryShapes
                Return "الأشكال"
                Case StringId.ManageRuleDatesOccurringTomorrow
                Return "غدا"
                Case StringId.DefaultBooleanDefault
                Return "افتراضي"
                Case StringId.TextEditMenuSelectAll
                Return "حدد كل &"
                Case StringId.TabHeaderButtonNext
                Return "قم بالتمرير لليمين"
                Case StringId.FilterCriteriaToStringGroupOperatorAnd
                Return "و"
                Case StringId.FormatRuleMenuItemBelowAverage
                Return "أقل من المتوسط"
                Case StringId.FilterPopupToolbarIncrementalSearch
                Return "البحث التزايدي"
                Case StringId.FilterCriteriaToStringFunctionRound
                Return "الجولة"
                Case StringId.IconSetCategoryRatings
                Return "تصنيفات"
                Case StringId.ManageRuleIconSets
                Return "مجموعات الرموز"
                Case StringId.FilterCriteriaToStringBinaryOperatorLessOrEqual
                Return "<="
                Case StringId.SaveLayoutDialogFileFilter
                Return "ملفات XML (*.xml) | *.xml"
                Case StringId.FilterCriteriaToStringFunctionIif
                Return "Iif"
                Case StringId.FilterCriteriaToStringFunctionPadRight
                Return "لوحة الحق"
                Case StringId.XtraMessageBoxIgnoreButtonText
                Return "آند تجاهل"
                Case StringId.ManageRuleAboveAverage
                Return "فوق المتوسط"
                Case StringId.DataBarCoralGradient
                Return "شريط بيانات الشعاب التدرج"
                Case StringId.ManageRuleEqualOrAboveAverage
                Return "تساوي أو تفوق المتوسط"
                Case StringId.ManageRuleDataBarUseNegativeBar
                Return "استخدام شريط سالب"
                Case StringId.FilterPopupToolbarMultiSelection
                Return "اختيار متعدد"
                Case StringId.IconSetTitleTrafficLights3Unrimmed
                Return "3 إشارات مرور (أونريميد)"
                Case StringId.FilterEditorTabText
                Return "نص"
                Case StringId.FilterCriteriaToStringFunctionTanh
                Return "تانه"
                Case StringId.FormatRuleBetweenText
                Return "تنسيق الخلايا التي تكون بين"
                Case StringId.FormatRuleTextThatContainsText
                Return "تنسيق الخلايا التي تحتوي على نص"
                Case StringId.FilterCriteriaToStringFunctionCeiling
                Return "الحد الأقصى"
                Case StringId.RestoreLayoutDialogTitle
                Return "استعادة التخطيط"
                Case StringId.TabHeaderButtonUp
                Return "التمرير لأعلى"
                Case StringId.FilterCriteriaToStringGroupOperatorOr
                Return "أو"
                Case StringId.FormatRuleTopText
                Return "تنسيق الخلايا التي يأتي ترتيبها في الأعلى"
                Case StringId.FilterCriteriaToStringFunctionIsNull
                Return "IsNull"
                Case StringId.FilterCriteriaToStringFunctionDateDiffTick
                Return "تاريخ التجزئة مهرجان دبي السينمائي الدولي"
                Case StringId.ManageRuleBelowAverage
                Return "أقل من المتوسط"
                Case StringId.IconSetCategoryIndicators
                Return "المؤشرات"
                Case StringId.ManageRuleCommonMinimum
                Return "الحد الأدنى"
                Case StringId.FilterCriteriaToStringBinaryOperatorLike
                Return "مثل"
                Case StringId.ManageRuleEqualOrBelowAverage
                Return "يساوي أو أقل من المتوسط"
                Case StringId.FilterPopupToolbarRadioMode
                Return "وضع الإذاعة"
                Case StringId.TextEditMenuUndo
                Return "آند التراجع عن"
                Case StringId.FilterCriteriaToStringFunctionIsThisYear
                Return "هذا العام"
                Case StringId.FormatRuleDateOccurring
                Return "تنسيق الخلايا التي تحتوي على تاريخ مطابقة هذه الشروط"
                Case StringId.ManageRuleDataBarAxisColor
                Return "لون المحور:"
                Case StringId.FilterCriteriaToStringFunctionPadLeft
                Return "لوحة اليسار"
                Case StringId.ManageRuleAverageAbove
                Return "أعلاه"
                Case StringId.FormatRuleCustomConditionText
                Return "تنسيق الخلايا التي تتطابق مع الشرط التالي"
                Case StringId.FilterCriteriaToStringFunctionFloor
                Return "الكلمة"
                Case StringId.SaveLayoutDialogTitle
                Return "حفظ التخطيط"
                Case StringId.FilterCriteriaToStringFunctionLen
                Return "ليون"
                Case StringId.FilterCriteriaToStringFunctionDateDiffSecond
                Return "تاريخ المهرجان الثاني"
                Case StringId.TabHeaderButtonDown
                Return "قم بالتمرير لأسفل"
                Case StringId.FilterCriteriaToStringUnaryOperatorBitwiseNot
                Return "~"
                Case StringId.ManageRuleFormatCellsItalic
                Return "مائل"
                Case StringId.ManageRuleFormatCellsCaption
                Return "تنسيق خلايا"
                Case StringId.FormatRuleBottomText
                Return "تنسيق الخلايا التي يأتي ترتيبها في الجزء السفلي"
                Case StringId.FilterPopupToolbarInvertFilter
                Return "عكس عامل التصفية"
                Case StringId.IconSetCategorySymbols
                Return "رموز"
                Case StringId.ManageRuleCommonMaximum
                Return "الحد الأقصى"
                Case StringId.FilterCriteriaToStringFunctionIsThisMonth
                Return "يتم هذا الشهر"
                Case StringId.ManageRuleThatContainNoErrors
                Return "لا توجد أخطاء"
                Case StringId.FilterCriteriaToStringBinaryOperatorMinus
                Return "-"
                Case StringId.TextEditMenuCut
                Return "كو آند تي"
                Case StringId.FilterCriteriaToStringFunctionMax
                Return "ماكس"
                Case StringId.FormatPredefinedAppearanceRedFillRedText
                Return "تعبئة بالأحمر مع نص أحمر"
                Case StringId.PictureEditMenuZoom
                Return "التكبير/التصغير"
                Case StringId.FilterCriteriaToStringFunctionLower
                Return "الدنيا"
                Case StringId.ManageRuleDataBarBarDirection
                Return "شريط التوجيه"
                Case StringId.ManageRuleAverageBelow
                Return "أدناه"
                Case StringId.OfficeNavigationOptions
                Return "خيارات التنقل"
                Case StringId.FilterCriteriaToStringFunctionDateDiffMilliSecond
                Return "تاريخ المهرجان ميلي ثانية"
                Case StringId.TakePictureDialogTitle
                Return "التقاط صورة"
                Case StringId.ManageRuleFormatCellsFont
                Return "الخط"
                Case StringId.TabHeaderButtonClose
                Return "قم بإغلاق"
                Case StringId.ColorPickPopupAutomaticItemCaption
                Return "تلقائي"
                Case StringId.FormatRuleMenuItemDateOccurring
                Return "تاريخ متكرر"
                Case StringId.FilterCriteriaToStringFunctionMin
                Return "دقيقة"
                Case StringId.ManageRuleCommonType
                Return "النوع:"
                Case StringId.FilterCriteriaToStringBinaryOperatorModulo
                Return "%"
                Case StringId.PictureEditMenuFullSize
                Return "الحجم الكامل"
                Case StringId.FilterCriteriaToStringFunctionNone
                Return "لا شيء"
                Case StringId.TextEditMenuCopy
                Return "آند نسخة"
                Case StringId.FilterCriteriaToStringFunctionDateDiffMinute
                Return "تاريخ المهرجان دقيقة"
                Case StringId.FormatPredefinedAppearanceYellowFillYellowText
                Return "تعبئة بالأصفر مع نص أصفر"
                Case StringId.ManageRuleDataBarSolidFill
                Return "تعبئة خالصة"
                Case StringId.TakePictureMenuItem
                Return "التقاط صورة من الكاميرا"
                Case StringId.ManageRuleFormatCellsFill
                Return "التعبئة"
                Case StringId.ManageRuleAverageEqualOrAbove
                Return "مساوية أو أعلى"
                Case StringId.FilterCriteriaToStringFunctionAcos
                Return "Acos"
                Case StringId.ColorPickPopupThemeColorsGroupCaption
                Return "ألوان السمة"
                Case StringId.PictureEditMenuFitImage
                Return "ملاءمة الصورة"
                Case StringId.TextEditMenuPaste
                Return "آند لصق"
                Case StringId.FilterCriteriaToStringFunctionSubstring
                Return "سلسلة فرعية"
                Case StringId.FilterCriteriaToStringFunctionDateDiffHour
                Return "تاريخ فرق ساعة"
                Case StringId.FormatPredefinedAppearanceGreenFillGreenText
                Return "تعبئة بالأخضر مع نص أخضر"
                Case StringId.ManageRuleDataBarGradientFill
                Return "تعبئة متدرجة"
                Case StringId.TakePictureDialogCapture
                Return "التقاط"
                Case StringId.ManageRuleFormatCellsPredefinedAppearance
                Return "ظهور معرف مسبقاً"
                Case StringId.ManageRuleAverageEqualOrBelow
                Return "مساوية أو أقل"
                Case StringId.FilterCriteriaToStringFunctionAsin
                Return "اسين"
                Case StringId.ColorPickPopupStandardColorsGroupCaption
                Return "الألوان القياسية"
                Case StringId.PictureEditMenuZoomIn
                Return "تكبير"
                Case StringId.FormatRuleMenuItemGreaterThan
                Return "أكبر من"
                Case StringId.FilterCriteriaToStringFunctionTrim
                Return "تقليم"
                Case StringId.TextEditMenuDelete
                Return "آند حذف"
                Case StringId.FilterCriteriaToStringFunctionDateDiffDay
                Return "تاريخ مهرجان دبي السينمائي الدولي اليوم"
                Case StringId.FormatPredefinedAppearanceRedFill
                Return "تعبئة بالأحمر"
                Case StringId.TakePictureDialogTryAgain
                Return "حاول مرة أخرى"
                Case StringId.ManageRuleDataBarNoBorder
                Return "لا يوجد حد"
                Case StringId.ManageRuleFormatCellsFontStyle
                Return "نمط الخط"
                Case StringId.FormatRuleMenuItemLessThan
                Return "أقل"
                Case StringId.ManageRuleFormulaFormatValuesWhereThisFormulaIsTrue
                Return "تنسيق القيم عندما تكون هذه الصيغة الحقيقية:"
                Case StringId.ColorPickPopupRecentColorsGroupCaption
                Return "الألوان الأخيرة"
                Case StringId.FilterCriteriaToStringFunctionUpper
                Return "العليا"
                Case StringId.PictureEditMenuZoomOut
                Return "التصغير"
                Case StringId.FilterCriteriaToStringFunctionDateDiffMonth
                Return "تاريخ المهرجان الشهر"
                Case StringId.TakePictureDialogSave
                Return "حفظ"
                Case StringId.FormatPredefinedAppearanceRedText
                Return "نص أحمر"
                Case StringId.ManageRuleDataBarSolidBorder
                Return "الحدود الصلبة"
                Case StringId.ManageRuleFormatCellsFontColor
                Return "لون الخط"
                Case StringId.FormatRuleMenuItemBetween
                Return "بين"
                Case StringId.FilterCriteriaToStringFunctionDateDiffYear
                Return "تاريخ المهرجان السنة"
                Case StringId.ManageRuleRankedValuesFormatValuesThatRankInThe
                Return "تنسيق القيم التي يأتي ترتيبها في:"
                Case StringId.ColorPickPopupMoreColorsItemCaption
                Return "مزيد من الألوان..."
                Case StringId.CameraSettingsActiveDevice
                Return "جهاز النشط:"
                Case StringId.ManageRuleFormatCellsEffects
                Return "التأثيرات:"
                Case StringId.FormatRuleMenuItemEqualTo
                Return "يساوي"
                Case StringId.PictureEditMenuZoomTo
                Return "تكبير إلى:"
                Case StringId.FormatPredefinedAppearanceGreenFill
                Return "تعبئة بالأخضر"
                Case StringId.ManageRuleDataBarContext
                Return "السياق"
                Case StringId.FilterCriteriaToStringFunctionGetDate
                Return "الحصول على التاريخ"
                Case StringId.CameraSettingsBrightness
                Return "السطوع:"
                Case StringId.ManageRuleFormatCellsUnderline
                Return "تسطير"
                Case StringId.ManageRuleRankedValuesOfTheColumnsCellValues
                Return "% من قيم العمود"
                Case StringId.ColorPickHueAxisName
                Return "هوي"
                Case StringId.FormatRuleMenuItemTextThatContains
                Return "النص الذي يحتوي على"
                Case StringId.CameraSettingsContrast
                Return "التباين:"
                Case StringId.PictureEditMenuZoomToolTip
                Return "{0} %"
                Case StringId.FormatPredefinedAppearanceGreenText
                Return "نص أخضر"
                Case StringId.ManageRuleDataBarLTR
                Return "اليمين إلى اليسار"
                Case StringId.ManageRuleFormatCellsStrikethrough
                Return "يتوسطه خط"
                Case StringId.ManageRuleRankedValuesTop
                Return "أعلى"
                Case StringId.FormatRuleMenuItemCustomCondition
                Return "شرط مخصص"
                Case StringId.ColorPickSaturationAxisName
                Return "تشبع"
                Case StringId.FormatPredefinedAppearanceBoldText
                Return "نص غامق"
                Case StringId.CameraSettingsDesaturate
                Return "التشبع:"
                Case StringId.ManageRuleDataBarRTL
                Return "اليمين إلى اليسار"
                Case StringId.ManageRuleRankedValuesBottom
                Return "أسفل"
                Case StringId.ManageRuleFormatCellsClear
                Return "واضحة"
                Case StringId.ColorPickLuminanceAxisName
                Return "النصوع"
                Case StringId.FormatPredefinedAppearanceItalicText
                Return "نص مائل"
                Case StringId.CameraSettingsDefaults
                Return "إعادة تعيين الافتراضيات"
                Case StringId.ManageRuleIconSetsDisplayEachIconAccordingToTheseRules
                Return "عرض رمز كل وفقا لهذه القواعد:"
                Case StringId.ManageRuleFormatCellsBackgroundColor
                Return "لون الخلفية:"
                Case StringId.ColorPickBrightnessAxisName
                Return "سطوع"
                Case StringId.ManageRuleThatContainFormatOnlyCellsWith
                Return "تنسيق الخلايا التي تحتوي فقط:"
                Case StringId.FormatPredefinedAppearanceStrikeoutText
                Return "نص يتوسطه خط"
                Case StringId.FormatRuleLessThanText
                Return "تنسيق الخلايا التي تكون أقل"
                Case StringId.ManageRuleIconSetsReverseIconOrder
                Return "عكس ترتيب الرموز"
                Case StringId.CameraSettingsCaption
                Return "إعدادات الكاميرا"
                Case StringId.ManageRuleFormatCellsNone
                Return "لا شيء"
                Case StringId.ColorPickOpacityAxisName
                Return "العتامة"
                Case StringId.ManageRuleThatContainCellValue
                Return "قيمة الخلية"
                Case StringId.ManageRuleIconSetsWhen
                Return "عندما"
                Case StringId.CameraSettingsResolution
                Return "القرار:"
                Case StringId.ColorPickRedValidationMsg
                Return "ينبغي أن يكون العنصر حمراء في مجموعة 0..255"
                Case StringId.ManageRuleThatContainDatesOccurring
                Return "التواريخ التي تحدث"
                Case StringId.ManageRuleIconSetsValueIs
                Return "القيمة"
                Case StringId.ManageRuleFormatCellsBold
                Return "غامق"
                Case StringId.CameraDeviceNotFound
                Return "كاميرا ويب لم يتم العثور على. تحقق من اتصال كاميرا ويب أو إعدادات الجهاز."
                Case StringId.ManageRuleThatContainSpecificText
                Return "نص محدد"
                Case StringId.ManageRuleSimpleRuleBaseFormat
                Return "تنسيق..."
                Case StringId.ManageRuleThatContainBlanks
                Return "الفراغات"
                Case StringId.CameraDeviceIsBusy
                Return "لا يمكن استخدام الجهاز، كما أنه مسبقاً قيد الاستخدام في تطبيق آخر."
                Case StringId.ManageRuleThatContainNoBlanks
                Return "بلا فراغات"
                Case StringId.ManageRuleAverageFormatValuesThatAre
                Return "تنسيق القيم التي:"
                Case StringId.ManageRuleThatContainErrors
                Return "أخطاء"
                Case StringId.CameraDesignTimeInfo
                Return "يتم تعطيل التقديم في وقت التصميم."
                Case StringId.ManageRuleAverageTheAverageForTheSelectedRange
                Return "متوسط قيم العمود"

                Case Else
                Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class
    Public Class HebrewEditorLocalizer
        Inherits XtraEditors.Controls.Localizer

        Public Overrides Function GetLocalizedString(ByVal id As StringId) As String
            Select Case id
                Case StringId.ColorPickGreenValidationMsg
                Return "רכיב הירוק צריך להיות בתוך טווח 0..255"
                Case StringId.FilterEditorTabVisual
                Return "חזותי"
                Case StringId.FilterCriteriaToStringFunctionIsThisWeek
                Return "השבוע"
                Case StringId.ManageRuleCellValueBetween
                Return "בין"
                Case StringId.InvalidValueText
                Return "ערך לא חוקי"
                Case StringId.ColorPickBlueValidationMsg
                Return "רכיב הכחול צריך להיות בתוך טווח 0..255"
                Case StringId.FormatPredefinedAppearanceRedBoldText
                Return "טקסט מודגש אדום"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisYear
                Return "השנה"
                Case StringId.ManageRuleCellValueNotBetween
                Return "לא בין"
                Case StringId.FilterCriteriaToStringFunctionGetMilliSecond
                Return "לקבל אלפיות השנייה"
                Case StringId.CheckChecked
                Return "בדקתי"
                Case StringId.ColorPickOpacityValidationMsg
                Return "האטימות צריך להיות בתוך טווח 0..255"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisMonth
                Return "החודש"
                Case StringId.CaptionError
                Return "שגיאה"
                Case StringId.IconSetCategoryDirectional
                Return "כיוונים"
                Case StringId.ManageRuleCellValueEqualTo
                Return "שווה ל"
                Case StringId.CheckUnchecked
                Return "לא מסומן"
                Case StringId.ColorPickColorHexValidationMsg
                Return "ערך הקסדצימאלי לא חוקי"
                Case StringId.FilterShowAll
                Return "(בחר הכל)"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeLastWeek
                Return "בשבוע שעבר"
                Case StringId.ManageRuleCellValueNotEqualTo
                Return "לא שווה"
                Case StringId.CheckIndeterminate
                Return "לא מוגדר"
                Case StringId.FormatPredefinedAppearanceGreenBoldText
                Return "טקסט מודגש ירוק"
                Case StringId.FilterCriteriaToStringFunctionGetSecond
                Return "לקבל השני"
                Case StringId.ColorPickHueValidationMsg
                Return "גוון רכיב צריך להיות בתוך טווח 0..359"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisWeek
                Return "השבוע"
                Case StringId.ManageRuleCellValueGreaterThan
                Return "גדול מ-"
                Case StringId.DateEditClear
                Return "ברור"
                Case StringId.IconSetCategoryPositiveNegative
                Return "חיובי/שלילי"
                Case StringId.SearchControlNullValuePrompt
                Return "הזן טקסט לחיפוש..."
                Case StringId.ColorPickSaturationValidationMsg
                Return "רכיב רוויה צריך להיות בתוך טווח 0..100"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeYesterday
                Return "אתמול"
                Case StringId.FilterGroupAnd
                Return "ו"
                Case StringId.ManageRuleCellValueLessThan
                Return "פחות מ"
                Case StringId.FilterGroupNotAnd
                Return "לא,"
                Case StringId.DateEditToday
                Return "היום"
                Case StringId.SearchForColumn
                Return "חיפוש עבור עמודה..."
                Case StringId.FilterCriteriaToStringFunctionGetMinute
                Return "לקבל דקה"
                Case StringId.ColorPickBrightValidationMsg
                Return "רכיב בהירות צריך להיות בתוך טווח 0..100"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeToday
                Return "היום"
                Case StringId.ManageRuleCellValueGreaterThanOrEqualTo
                Return "גדול מאו שווה ל-"
                Case StringId.OK
                Return "אוקיי"
                Case StringId.FilterClauseBetween
                Return "בין"
                Case StringId.Cancel
                Return "ביטול"
                Case StringId.ColorScaleGreenYellowRed
                Return "ירוק - צהוב - אדום"
                Case StringId.ColorTabWebSafeColors
                Return "לאינטרנט"
                Case StringId.FilterGroupNotOr
                Return "לא או"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeNow
                Return "עכשיו"
                Case StringId.ManageRuleCellValueLessThanOrEqualTo
                Return "קטן או שווה ל-"
                Case StringId.FilterClauseBetweenAnd
                Return "ו"
                Case StringId.SearchForField
                Return "חיפוש עבור שדה..."
                Case StringId.FilterCriteriaToStringFunctionGetHour
                Return "לקבל שעה"
                Case StringId.NavigatorFirstButtonHint
                Return "הראשון"
                Case StringId.Days
                Return "ימים"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeTomorrow
                Return "מחר"
                Case StringId.NavigatorRemoveButtonHint
                Return "מחק"
                Case StringId.ManageRuleDatesOccurringBeyond
                Return "לאחר החודש בזמן 2 חודשים"
                Case StringId.FilterClauseContains
                Return "מכיל"
                Case StringId.NavigatorPreviousButtonHint
                Return "הקודם"
                Case StringId.ColorScalePurpleWhiteAzure
                Return "סגול - לבן - תכלת"
                Case StringId.FilterGroupOr
                Return "או"
                Case StringId.Hours
                Return "שעות"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeDayAfterTomorrow
                Return "היום שאחרי מחר"
                Case StringId.ManageRuleDatesOccurringBeyondThisYear
                Return "בעקבות השנה"
                Case StringId.ManageRuleCaption
                Return "מנהל כללי עיצוב מותנה"
                Case StringId.FilterClauseEndsWith
                Return "מסתיים"
                Case StringId.NavigatorPreviousPageButtonHint
                Return "דף קודמות"
                Case StringId.Mins
                Return "דקות"
                Case StringId.FilterCriteriaToStringFunctionGetDay
                Return "היום"
                Case StringId.NavigatorEditButtonHint
                Return "עריכה"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextWeek
                Return "בשבוע הבא"
                Case StringId.ManageRuleDatesOccurringEarlier
                Return "לפני חודש לפני 6 חודשים"
                Case StringId.FilterClauseEquals
                Return "שווה ל-"
                Case StringId.ColorScaleYellowOrangeCoral
                Return "צהוב - כתום - אלמוג"
                Case StringId.NavigatorNextButtonHint
                Return "הבא"
                Case StringId.FilterClauseAnyOf
                Return "הוא אף אחד"
                Case StringId.Secs
                Return "שניות"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeTwoWeeksAway
                Return "במרחק שבועיים"
                Case StringId.ManageRuleShowFormattingRules
                Return "הצג כללי:"
                Case StringId.ManageRuleDatesOccurringEarlierThisMonth
                Return "החודש, לפני שבוע קודם לכן"
                Case StringId.FilterClauseGreater
                Return "גדול מ-"
                Case StringId.NavigatorNextPageButtonHint
                Return "דף הבא"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisYear
                Return "מאוחר יותר השנה"
                Case StringId.FilterCriteriaToStringFunctionGetMonth
                Return "להשיג בחודש"
                Case StringId.Millisecs
                Return "millisecs"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextMonth
                Return "בחודש הבא"
                Case StringId.ManageRuleDatesOccurringEarlierThisWeek
                Return "השבוע, לפני אתמול"
                Case StringId.NavigatorEndEditButtonHint
                Return "סיום עריכה"
                Case StringId.ColorScaleGreenWhiteRed
                Return "ירוק - לבן - אדום"
                Case StringId.FilterClauseGreaterOrEqual
                Return "גדול או שווה ל-"
                Case StringId.NavigatorLastButtonHint
                Return "אחרונה"
                Case StringId.IncorrectNumberCopies
                Return "המספר חייב להיות בין 1 ל- 32767."
                Case StringId.FilterClauseBeginsWith
                Return "מתחילה עם"
                Case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextYear
                Return "בשנה הבאה"
                Case StringId.ManageRuleDatesOccurringEarlierThisYear
                Return "השנה, לפני החודש"
                Case StringId.FilterClauseIsNotNull
                Return "אינו null"
                Case StringId.ManageRuleUp
                Return "למעלה"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisMonth
                Return "הוא מאוחר יותר החודש"
                Case StringId.NavigatorAppendButtonHint
                Return "צרף"
                Case StringId.FilterCriteriaToStringFunctionGetYear
                Return "לקבל בשנה"
                Case StringId.ChartRangeControlClientInvalidGrid
                Return "המרווח בין קווי הרשת הוא קטן מדי כדי להיות מיוצג בפקד טווח."
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalBeyondThisYear
                Return "הוא מעבר לכל השנה"
                Case StringId.ManageRuleDatesOccurringLastWeek
                Return "בשבוע שעבר"
                Case StringId.NavigatorCancelEditButtonHint
                Return "ביטול עריכה"
                Case StringId.ColorScaleEmeraldAzureBlue
                Return "ברקת - תכלת - כחול"
                Case StringId.FilterClauseIsNull
                Return "הוא null"
                Case StringId.NavigatorTextStringFormat
                Return "הרשומה {0} מתוך {1}"
                Case StringId.ChartRangeControlClientNoData
                Return "יש נתונים כדי לייצג בפקד טווח."
                Case StringId.FilterClauseNoneOf
                Return "הוא אף אחד"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisWeek
                Return "מאוחר יותר השבוע"
                Case StringId.ManageRuleDown
                Return "למטה"
                Case StringId.ManageRuleDatesOccurringLaterThisMonth
                Return "בחודש זה, מעבר בשבוע הבא"
                Case StringId.FilterClauseIsNotNullOrEmpty
                Return "אינו ריק"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalNextWeek
                Return "בשבוע הבא"
                Case StringId.PictureEditMenuCut
                Return "לחתוך"
                Case StringId.DataBarBlue
                Return "סרגל נתונים כחול"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalTomorrow
                Return "מחר"
                Case StringId.FilterCriteriaToStringFunctionGetDayOfWeek
                Return "יום של השבוע"
                Case StringId.ManageRuleDatesOccurringLaterThisWeek
                Return "השבוע, מעבר מחר"
                Case StringId.LookUpColumnDefaultName
                Return "שם"
                Case StringId.FilterClauseIsNullOrEmpty
                Return "ריק"
                Case StringId.PictureEditMenuCopy
                Return "העתק"
                Case StringId.ColorScaleWhiteRed
                Return "לבן - אדום"
                Case StringId.DataBarLightBlue
                Return "אור כחול נתונים בר"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalToday
                Return "היום"
                Case StringId.ManageRuleDatesOccurringLaterThisYear
                Return "השנה, מעבר החודש"
                Case StringId.FilterClauseNotBetween
                Return "אינה בין"
                Case StringId.FilterClauseLess
                Return "הוא פחות מ"
                Case StringId.PictureEditMenuPaste
                Return "הדבק"
                Case StringId.ManageRuleNewRule
                Return "חוק חדש..."
                Case StringId.DataBarGreen
                Return "סרגל נתונים ירוק"
                Case StringId.FilterCriteriaToStringFunctionToLong
                Return "כדי זמן רב"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalYesterday
                Return "אתמול"
                Case StringId.ManageRuleDatesOccurringMonthAfter1
                Return "בחודש הבא"
                Case StringId.FilterCriteriaToStringFunctionAddMilliSeconds
                Return "להוסיף אלפיות השניה"
                Case StringId.FilterCriteriaToStringFunctionGetDayOfYear
                Return "יום השנה"
                Case StringId.UnknownPictureFormat
                Return "תבנית התמונה לא ידוע"
                Case StringId.FilterClauseLessOrEqual
                Return "קטן או שווה ל-"
                Case StringId.PictureEditMenuDelete
                Return "מחק"
                Case StringId.DataBarYellow
                Return "סרגל נתונים צהוב"
                Case StringId.ColorScaleWhiteGreen
                Return "לבן - ירוק"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisWeek
                Return "מוקדם יותר השבוע"
                Case StringId.FilterClauseDoesNotContain
                Return "אינו מכיל"
                Case StringId.ManageRuleDatesOccurringMonthAfter2
                Return "במהלך החודש בזמן 2 חודשים"
                Case StringId.FilterCriteriaToStringFunctionAddSeconds
                Return "להוסיף שניות"
                Case StringId.ManageRuleEditRule
                Return "ערוך את הכלל..."
                Case StringId.FilterClauseLike
                Return "זה כמו"
                Case StringId.PictureEditMenuLoad
                Return "עומס"
                Case StringId.DataBarOrange
                Return "סרגל נתונים כתום"
                Case StringId.FilterCriteriaToStringFunctionToFloat
                Return "לצוף"
                Case StringId.FilterCriteriaToStringFunctionGetTimeOfDay
                Return "לקבל זמן של יום"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLastWeek
                Return "בשבוע שעבר"
                Case StringId.ManageRuleDatesOccurringMonthAgo1
                Return "בחודש שעבר"
                Case StringId.FilterCriteriaToStringFunctionAddMinutes
                Return "להוסיף דקות"
                Case StringId.DataEmpty
                Return "אין נתוני תמונה"
                Case StringId.FilterEmptyValue
                Return "<empty></empty>"
                Case StringId.PictureEditMenuSave
                Return "שמור"
                Case StringId.ColorScaleWhiteAzure
                Return "לבן - תכלת"
                Case StringId.DataBarMint
                Return "סרגל נתונים מנטה"
                Case StringId.FilterClauseDoesNotEqual
                Return "לא שווה"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisMonth
                Return ". זה מוקדם יותר החודש"
                Case StringId.ManageRuleDatesOccurringMonthAgo2
                Return "במהלך החודש לפני 2 חודשים"
                Case StringId.FilterCriteriaToStringFunctionAddHours
                Return "להוסיף שעות"
                Case StringId.FormatRuleMenuItemClearAllRules
                Return "כללים ברורים של כל העמודות"
                Case StringId.ManageRuleDeleteRule
                Return "מחיקת כלל"
                Case StringId.FilterMenuConditionAdd
                Return "הוסף התנאי"
                Case StringId.PictureEditOpenFileFilter
                Return "מפת סיביות קבצים (*.bmp) | *-bmp| Graphics Interchange Format (*.gif) | *-gif| תבנית הקובץ JPEG מחלף (*.jpg; *.jpeg) | *. jpg; *. jpeg| קבצי הסמלים (*.ico) | *-ico| רשת נייד גרפיקה בתבנית (*.png) | *-png| כל קבצי התמונות | *. bmp; *.gif; *.jpg; *.jpeg; *.ico; *.png; *. tif| כל הקבצים | * *"
                Case StringId.DataBarViolet
                Return "סרגל נתונים ויולט"
                Case StringId.FilterCriteriaToStringFunctionToDouble
                Return "זוגי"
                Case StringId.FilterCriteriaToStringFunctionNow
                Return "עכשיו"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisYear
                Return "מוקדם יותר השנה"
                Case StringId.ManageRuleDatesOccurringMonthAgo3
                Return "במהלך החודש לפני 3 חודשים"
                Case StringId.FilterCriteriaToStringFunctionAddDays
                Return "הוספת ימים"
                Case StringId.NotValidArrayLength
                Return "אורך המערך אינו חוקי."
                Case StringId.FilterMenuGroupAdd
                Return "הוסף קבוצת"
                Case StringId.ColorScaleYellowGreen
                Return "צהוב - ירוק"
                Case StringId.PictureEditSaveFileFilter
                Return "מפת סיביות קבצים (*.bmp) | *-bmp| Graphics Interchange Format (*.gif) | *-gif| תבנית הקובץ JPEG מחלף (*.jpg) | *-jpg| עיצוב גרפי רשת נייד (*.png) | *. png"
                Case StringId.DataBarRaspberry
                Return "סרגל נתונים פטל"
                Case StringId.FilterClauseNotLike
                Return ". לא מתאים"
                Case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalPriorThisYear
                Return "זה לפני השנה"
                Case StringId.ManageRuleDatesOccurringMonthAgo4
                Return "במהלך חודש 4 חודשים לפני"
                Case StringId.FormatRuleMenuItemHighlightCellRules
                Return "כללים תא האר"
                Case StringId.FormatRuleUniqueText
                Return "עיצוב תאים כי הם ערכים ייחודיים"
                Case StringId.ManageRuleGridCaptionRule
                Return "כלל"
                Case StringId.FilterCriteriaToStringFunctionAddMonths
                Return "להוסיף חודשים"
                Case StringId.FilterMenuClearAll
                Return "לנקות את כל"
                Case StringId.PictureEditOpenFileTitle
                Return "פתוח"
                Case StringId.FilterCriteriaToStringFunctionToDecimal
                Return "לעשרוני"
                Case StringId.DataBarCoral
                Return "סרגל נתונים אלמוג"
                Case StringId.FilterCriteriaToStringFunctionCustom
                Return "מותאם אישית"
                Case StringId.FilterCriteriaToStringFunctionUtcNow
                Return "Utc עכשיו"
                Case StringId.ManageRuleDatesOccurringMonthAgo5
                Return "במהלך החודש לפני 5 חודשים"
                Case StringId.ImagePopupEmpty
                Return "(ריק)"
                Case StringId.FormatRuleMenuItemDuplicate
                Return "ערכים כפולים"
                Case StringId.FilterCriteriaToStringFunctionAddYears
                Return "להוסיף שנים"
                Case StringId.FilterMenuRowRemove
                Return "הסר קבוצת"
                Case StringId.ColorScaleBlueWhiteRed
                Return "כחול - לבן - אדום"
                Case StringId.PictureEditSaveFileTitle
                Return "שמירה בשם"
                Case StringId.FormatRuleMenuItemTopBottomRules
                Return "כללי עליון/תחתון"
                Case StringId.DataBarBlueGradient
                Return "צבע כחול נתונים בר"
                Case StringId.FilterCriteriaToStringFunctionCustomNonDeterministic
                Return "אישית לא דטרמיניסטי"
                Case StringId.ManageRuleGridCaptionFormat
                Return "תבנית"
                Case StringId.ManageRuleDatesOccurringMonthAgo6
                Return "במהלך החודש לפני 6 חודשים"
                Case StringId.FilterCriteriaToStringFunctionToStr
                Return "ל str"
                Case StringId.FormatRuleDuplicateText
                Return "עיצוב תאים כי הם ערכים כפולים"
                Case StringId.FilterCriteriaToStringFunctionStartsWith
                Return "מתחיל עם"
                Case StringId.FilterCriteriaToStringFunctionToday
                Return "היום"
                Case StringId.FilterToolTipNodeAdd
                Return "מוסיף תנאי חדש לקבוצה זו"
                Case StringId.ImagePopupPicture
                Return "(תמונה)"
                Case StringId.PictureEditOpenFileError
                Return "בתבנית תמונה שגויה"
                Case StringId.DataBarLightBlueGradient
                Return "שורת הנתונים באור כחול הדרגתי"
                Case StringId.FormatRuleMenuItemUnique
                Return "ערכים ייחודיים"
                Case StringId.FilterCriteriaToStringFunctionIsNullOrEmpty
                Return "הוא null או ריק"
                Case StringId.ManageRuleDatesOccurringNextWeek
                Return "בשבוע הבא"
                Case StringId.FormatRuleApplyFormatProperty
                Return "להחיל עיצוב על שורה שלמה"
                Case StringId.FormatRuleMenuItemDataBars
                Return "סרגלי נתונים"
                Case StringId.FilterCriteriaToStringFunctionEndsWith
                Return "מסתיים"
                Case StringId.ManageRuleGridCaptionApplyToTheRow
                Return "שיחולו על השורה"
                Case StringId.FilterToolTipNodeRemove
                Return "מסיר את המצב הזה"
                Case StringId.PictureEditOpenFileErrorCaption
                Return "שגיאה בפתיחת"
                Case StringId.FilterCriteriaToStringFunctionReplace
                Return "החלף"
                Case StringId.DataBarGreenGradient
                Return "צבע ירוק נתונים בר"
                Case StringId.FilterCriteriaToStringFunctionConcat
                Return "איש קשר"
                Case StringId.ManageRuleDatesOccurringPriorThisYear
                Return "לפני השנה"
                Case StringId.FilterCriteriaToStringFunctionAddTimeSpan
                Return "הוספת טווח זמן"
                Case StringId.FormatRuleWith
                Return "עם"
                Case StringId.FilterCriteriaToStringFunctionContains
                Return "מכיל"
                Case StringId.ColorTabCustom
                Return "מותאם אישית"
                Case StringId.FilterToolTipNodeAction
                Return "פעולות"
                Case StringId.FilterMenuAddNewParameter
                Return "הוסף פרמטר..."
                Case StringId.PictureEditCopyImageError
                Return "לא היתה אפשרות להעתיק את התמונה"
                Case StringId.DataBarYellowGradient
                Return "צבע צהוב נתונים בר"
                Case StringId.FilterCriteriaToStringFunctionAscii
                Return "Ascii"
                Case StringId.IconSetTitleRatings4
                Return "4 דירוגים"
                Case StringId.FormatRuleMenuItemColorScales
                Return "סרגלי צבעים"
                Case StringId.ManageRuleDatesOccurringThisMonth
                Return "החודש"
                Case StringId.FormatRuleForThisColumnWith
                Return "עבור עמודה זו עם"
                Case StringId.FilterCriteriaInvalidExpression
                Return "הביטוי שצוין מכיל סמלים לא חוקי (קו {0}, תו {1})."
                Case StringId.ManageRuleGridCaptionColumn
                Return "טור"
                Case StringId.FilterCriteriaToStringFunctionReverse
                Return "הפוך"
                Case StringId.FilterToolTipValueType
                Return "להשוות עם ערך / אחר הערך של שדה"
                Case StringId.LookUpEditValueIsNull
                Return "[EditValue הוא null]"
                Case StringId.DataBarOrangeGradient
                Return "צבע כתום נתונים בר"
                Case StringId.ManageRuleAllColumns
                Return "(הכל)"
                Case StringId.FilterCriteriaToStringFunctionChar
                Return "Char"
                Case StringId.ManageRuleDatesOccurringThisWeek
                Return "השבוע"
                Case StringId.FilterCriteriaToStringFunctionAddTicks
                Return "להוסיף קרציות"
                Case StringId.IconSetTitleStars3
                Return "3 כוכבים"
                Case StringId.ColorTabWeb
                Return "אינטרנט"
                Case StringId.FilterCriteriaInvalidExpressionEx
                Return "הביטוי שצוין אינו חוקי."
                Case StringId.FilterToolTipElementAdd
                Return "הוספת פריט חדש לרשימה"
                Case StringId.FilterCriteriaToStringUnaryOperatorIsNull
                Return "הוא Null"
                Case StringId.LookUpInvalidEditValueType
                Return "סוג לא חוקי LookUpEdit EditValue."
                Case StringId.IconSetTitleRatings5
                Return "דירוגי 5"
                Case StringId.DataBarMintGradient
                Return "מעבר צבע סרגל נתונים מנטה"
                Case StringId.FilterCriteriaToStringFunctionToInt
                Return "כדי אינטראקציה."
                Case StringId.ManageRuleDatesOccurringTomorrow
                Return "מחר"
                Case StringId.FormatRuleMenuItemIconSets
                Return "ערכות סמלים"
                Case StringId.IconSetTitleSymbols3Circled
                Return "3 סמלים (מסומן בעיגול)"
                Case StringId.Apply
                Return "החל"
                Case StringId.NewFormattingRule
                Return "כלל עיצוב חדש"
                Case StringId.FilterToolTipKeysAdd
                Return "(השתמש את תותב או להוסיף מפתח)"
                Case StringId.FilterCriteriaToStringFunctionInsert
                Return "הוספה"
                Case StringId.TabHeaderButtonPin
                Return "סיכה"
                Case StringId.DataBarVioletGradient
                Return "צבע סגול נתונים בר"
                Case StringId.ManageRuleCommonMaximum
                Return "לכל היותר"
                Case StringId.FilterCriteriaToStringFunctionCos
                Return "Cos"
                Case StringId.ManageRuleDatesOccurringToday
                Return "היום"
                Case StringId.IconSetTitleSymbols3Uncircled
                Return "(הלא-מוקפים) 3 סמלים"
                Case StringId.FilterOutlookDateText
                Return "להראות all| להראות Empty| סנן לפי תאריך ספציפי: |Beyond year| הזה מאוחר יותר year| הזה מאוחר יותר month| הזה Week| הבא מאוחר יותר week| הזה Tomorrow| Today| Yesterday| מוקדם יותר week| הזה Week| האחרון מוקדם יותר month| הזה מוקדם יותר year| הזה לפני השנה"
                Case StringId.ColorTabSystem
                Return "מערכת"
                Case StringId.FilterCriteriaToStringUnaryOperatorMinus
                Return "-"
                Case StringId.PreviewPanelText
                Return "תצוגה מקדימה:"
                Case StringId.FilterToolTipKeysRemove
                Return "(השתמש מחק או להחסיר מפתח)"
                Case StringId.TabHeaderButtonUnpin
                Return "בטל הצמדה"
                Case StringId.IconSetTitleQuarters5
                Return "5 רבעים"
                Case StringId.DataBarRaspberryGradient
                Return "מעבר צבע סרגל נתונים פטל"
                Case StringId.ManageRuleEqualOrBelowAverage
                Return "שווה או מתחת לממוצע"
                Case StringId.FilterCriteriaToStringFunctionSin
                Return "חטא"
                Case StringId.FormatRuleMenuItemClearRules
                Return "כללים ברורים"
                Case StringId.ManageRuleDatesOccurringYesterday
                Return "אתמול"
                Case StringId.IconSetTitleFlags3
                Return "דגלים 3"
                Case StringId.EditFormattingRule
                Return "עריכת כלל עיצוב"
                Case StringId.TransparentBackColorNotSupported
                Return "פקד זה אינו תומך צבעי רקע שקוף"
                Case StringId.FilterCriteriaToStringFunctionCharIndex
                Return "Char אינדקס"
                Case StringId.ContainerAccessibleEditName
                Return "עריכת בקרה"
                Case StringId.TabHeaderSelectorButton
                Return "הצג חלון הרשימה"
                Case StringId.DataBarCoralGradient
                Return "מעבר צבע סרגל נתונים אלמוג"
                Case StringId.ManageRuleCommonType
                Return "סוג:"
                Case StringId.FilterDateTimeConstantMenuCaption
                Return "תאריך ושעה קבועים"
                Case StringId.ManageRuleFormatCellsCaption
                Return "עיצוב תאים"
                Case StringId.FilterCriteriaToStringFunctionAtn
                Return "Atn"
                Case StringId.ManageRuleSpecificTextContaining
                Return "המכיל"
                Case StringId.CalcButtonMC
                Return "MC"
                Case StringId.IconSetTitlePositiveNegativeArrows
                Return "חיצים (בצבע)"
                Case StringId.FilterAggregateExists
                Return "קיים"
                Case StringId.FilterCriteriaToStringGroupOperatorAnd
                Return "ו"
                Case StringId.FilterCriteriaToStringUnaryOperatorNot
                Return ". לא"
                Case StringId.IconSetTitleBoxes5
                Return "5 תיבות"
                Case StringId.XtraMessageBoxOkButtonText
                Return "& בסדר"
                Case StringId.FormatRuleMenuItemClearColumnRules
                Return "כללים ברורים של עמודה זו"
                Case StringId.ManageRuleFormatCellsFont
                Return "גופן"
                Case StringId.FormatRuleMenuItemManageRules
                Return "ניהול כללי..."
                Case StringId.NewEditFormattingRuleSelectARuleType
                Return "בחר סוג כלל:"
                Case StringId.FilterCriteriaToStringFunctionExp
                Return "Exp"
                Case StringId.ManageRuleSpecificTextNotContaining
                Return "אשר אינו מכיל"
                Case StringId.IconSetTitlePositiveNegativeArrowsGray
                Return "חיצים (אפור)"
                Case StringId.FilterCriteriaToStringFunctionRemove
                Return "הסר"
                Case StringId.FilterAggregateMax
                Return "מקס"
                Case StringId.FilterCriteriaToStringGroupOperatorOr
                Return "או"
                Case StringId.ManageRuleCommonPercent
                Return "אחוז"
                Case StringId.XtraMessageBoxCancelButtonText
                Return "& לבטל"
                Case StringId.FilterDateTimeOperatorMenuCaption
                Return "מפעילי תאריך ושעה"
                Case StringId.IconSetCategoryShapes
                Return "צורות"
                Case StringId.ManageRuleFormatCellsFill
                Return "מילוי"
                Case StringId.FilterCriteriaToStringFunctionLog
                Return "יומן"
                Case StringId.CalcButtonMR
                Return "מר"
                Case StringId.FilterCriteriaToStringUnaryOperatorPlus
                Return "+"
                Case StringId.ManageRuleSpecificTextBeginningWith
                Return "החל מ-"
                Case StringId.IconSetTitlePositiveNegativeTriangles
                Return "משולשים"
                Case StringId.FilterAggregateMin
                Return "Min"
                Case StringId.IconSetTitleArrows3Colored
                Return "3 חצים (בצבע)"
                Case StringId.FilterCriteriaToStringUnaryOperatorBitwiseNot
                Return "~"
                Case StringId.XtraMessageBoxYesButtonText
                Return "& כן"
                Case StringId.FormatRuleMenuItemUniqueDuplicateRules
                Return "ייחודי/שכפול כללי"
                Case StringId.FormatRuleMenuItemBottom10Items
                Return "התחתון 10 פריטים"
                Case StringId.NewEditFormattingRuleEditTheRuleDescription
                Return "ערוך את תיאור הכלל:"
                Case StringId.ManageRuleFormatCellsPredefinedAppearance
                Return "המראה מוגדרים מראש"
                Case StringId.FilterCriteriaToStringFunctionRnd
                Return "Rnd"
                Case StringId.ManageRuleSpecificTextEndingWith
                Return "המסתיימים"
                Case StringId.FilterCriteriaToStringFunctionAbs
                Return "Abs"
                Case StringId.ManageRuleCommonNumber
                Return "מספר"
                Case StringId.FormatRuleMenuItemTop10Items
                Return "העליון 10 פריטים"
                Case StringId.FilterAggregateSum
                Return "סכום"
                Case StringId.FilterCriteriaToStringBinaryOperatorMultiply
                Return "*"
                Case StringId.FilterDateTextAlt
                Return "להראות all| להראות Empty| סנן לפי תאריך ספציפי: |Beyond||| Week| הבא Today| Week| הזה Month| הזה Earlier| {0:yyyy}, {0: ממממ}"
                Case StringId.XtraMessageBoxNoButtonText
                Return "& אין"
                Case StringId.FormatRuleMenuItemBottom10Percent
                Return "תחתון 10%"
                Case StringId.ManageRuleFormatCellsFontStyle
                Return "סגנון גופן"
                Case StringId.FilterEditorTabText
                Return "טקסט"
                Case StringId.CalcButtonMS
                Return "MS"
                Case StringId.FilterCriteriaToStringBinaryOperatorBitwiseAnd
                Return "&"
                Case StringId.FilterCriteriaToStringFunctionTan
                Return "טאן"
                Case StringId.ManageRuleUniqueOrDuplicateFormatAll
                Return "לעצב כל:"
                Case StringId.FormatRuleMenuItemTop10Percent
                Return "העליון 10%"
                Case StringId.IconSetTitleArrows3Gray
                Return "3 חצים (אפור)"
                Case StringId.FieldListName
                Return "רשימת שדות ({0})"
                Case StringId.FilterCriteriaToStringBinaryOperatorNotEqual
                Return "<>"
                Case StringId.XtraMessageBoxAbortButtonText
                Return "& בטל"
                Case StringId.FormatRuleMenuItemGradientFill
                Return "מילוי"
                Case StringId.FormatRuleMenuItemAboveAverage
                Return "מעל הממוצע"
                Case StringId.NewEditFormattingRuleFormatAllCellsBasedOnTheirValues
                Return "עיצוב כל התאים בהתבסס על הערכים שלהם"
                Case StringId.ManageRuleFormatCellsFontColor
                Return "צבע גופן"
                Case StringId.FilterCriteriaToStringFunctionPower
                Return "כוח"
                Case StringId.FilterCriteriaToStringFunctionSqr
                Return "Sqr"
                Case StringId.ManageRuleUniqueOrDuplicateValuesInTheSelectedRange
                Return "ערכי עמודה"
                Case StringId.FormatRuleBetweenText
                Return "עיצוב תאים הנמצאים BETWEEN"
                Case StringId.RestoreLayoutDialogFileFilter
                Return "קבצי XML (*. xml) | *-xml| כל files| * *"
                Case StringId.ManageRuleCommonValue
                Return "ערך:"
                Case StringId.FilterFunctionsMenuCaption
                Return "פונקציות"
                Case StringId.FilterCriteriaToStringBinaryOperatorPlus
                Return "+"
                Case StringId.XtraMessageBoxRetryButtonText
                Return "& שנית"
                Case StringId.FormatRuleMenuItemBelowAverage
                Return "מתחת לממוצע"
                Case StringId.FilterCriteriaToStringFunctionIsThisMonth
                Return "הוא החודש"
                Case StringId.ManageRuleFormatCellsEffects
                Return "אפקטים:"
                Case StringId.FilterCriteriaToStringFunctionSign
                Return "סימן"
                Case StringId.ManageRuleUniqueOrDuplicateUnique
                Return "ייחודי"
                Case StringId.CalcButtonMx
                Return "M +"
                Case StringId.FilterCriteriaToStringBinaryOperatorBitwiseOr
                Return "|"
                Case StringId.FormatRuleEqualToText
                Return "עיצוב תאים הנמצאים שווה ל"
                Case StringId.SaveLayoutDialogFileFilter
                Return "קבצי XML (*. xml) | *. xml"
                Case StringId.IconSetTitleTriangles3
                Return "3 משולשים"
                Case StringId.FilterCriteriaToStringBetween
                Return "בין"
                Case StringId.FormatRuleMenuItemSolidFill
                Return "מילוי מלא"
                Case StringId.XtraMessageBoxIgnoreButtonText
                Return "& להתעלם"
                Case StringId.FormatRuleTopText
                Return "עיצוב תאים המדורגים בין החלק העליון"
                Case StringId.ManageRuleFormatCellsUnderline
                Return "קו תחתון"
                Case StringId.NewEditFormattingRuleFormatOnlyCellsThatContain
                Return "לעצב רק תאים המכילים"
                Case StringId.FilterCriteriaToStringFunctionAtn2
                Return "Atn2"
                Case StringId.FilterCriteriaToStringFunctionRound
                Return "עגול"
                Case StringId.ManageRuleUniqueOrDuplicateDuplicate
                Return "שכפל"
                Case StringId.FormatRuleTextThatContainsText
                Return "עיצוב תאים המכילים את הטקסט"
                Case StringId.ManageRuleCommonColor
                Return "צבע:"
                Case StringId.RestoreLayoutDialogTitle
                Return "שחזור פריסת"
                Case StringId.FilterCriteriaToStringIn
                Return "ב"
                Case StringId.DefaultBooleanTrue
                Return "נכון"
                Case StringId.TextEditMenuUndo
                Return "& בטל"
                Case StringId.FilterCriteriaToStringFunctionGetDate
                Return "להשיג דייט"
                Case StringId.FormatRuleBottomText
                Return "עיצוב תאים המדורגים בתחתית"
                Case StringId.ManageRuleFormatCellsStrikethrough
                Return "קו חוצה"
                Case StringId.FilterPopupToolbarShowOnlyAvailableItems
                Return "הצג רק פריטים זמינים"
                Case StringId.CalcButtonSqrt
                Return "sqrt"
                Case StringId.FilterCriteriaToStringBinaryOperatorBitwiseXor
                Return "^"
                Case StringId.IconSetTitleArrows4Colored
                Return "4 חצים (בצבע)"
                Case StringId.FilterCriteriaToStringFunctionCeiling
                Return "התקרה"
                Case StringId.ManageRuleColorScale
                Return "מרחב צבע מדורגת"
                Case StringId.FormatRuleCustomConditionText
                Return "עיצוב תאים שתואמים את התנאי הבא"
                Case StringId.IconSetCategoryRatings
                Return "דירוגים"
                Case StringId.SaveLayoutDialogTitle
                Return "שמירת פריסה"
                Case StringId.FilterCriteriaToStringIsNotNull
                Return "אינו Null"
                Case StringId.TextEditMenuCut
                Return "Cu & t"
                Case StringId.NewEditFormattingRuleFormatOnlyTopOrBottomRankedValues
                Return "לעצב רק המדורגים כעליונים או תחתונים ערכים"
                Case StringId.FormatRuleAboveAverageText
                Return "עיצוב תאים שנמצאים מעל הממוצע"
                Case StringId.ManageRuleFormatCellsClear
                Return "ברור"
                Case StringId.FilterCriteriaToStringFunctionBigMul
                Return "מול גדול"
                Case StringId.ColorPickPopupRecentColorsGroupCaption
                Return "צבעים האחרונות"
                Case StringId.ManageRuleCommonPreview
                Return "תצוגה מקדימה:"
                Case StringId.FilterCriteriaToStringFunctionFloor
                Return "קומה"
                Case StringId.ManageRuleIconSet
                Return "ערכת סמלים"
                Case StringId.DefaultBooleanFalse
                Return "שווא"
                Case StringId.PictureEditMenuZoom
                Return "זום"
                Case StringId.FilterPopupToolbarShowNewValues
                Return "הצג ערכי שדה חדש"
                Case StringId.FilterCriteriaToStringNotLike
                Return "לא כמו"
                Case StringId.TextEditMenuCopy
                Return "& להעתיק"
                Case StringId.CalcButtonBack
                Return "בחזרה"
                Case StringId.FilterCriteriaToStringBinaryOperatorDivide
                Return "/"
                Case StringId.FormatRuleBelowAverageText
                Return "עיצוב תאים הנמצאים מתחת לממוצע"
                Case StringId.ManageRuleFormatCellsBackgroundColor
                Return "צבע רקע:"
                Case StringId.ColorPickPopupMoreColorsItemCaption
                Return "צבעים יותר..."
                Case StringId.IconSetTitleArrows4Gray
                Return "4 חצים (אפור)"
                Case StringId.FilterCriteriaToStringFunctionMax
                Return "מקס"
                Case StringId.ManageRuleFormula
                Return "הנוסחה"
                Case StringId.FormatRuleMenuItemDateOccurring
                Return "תאריך המתרחש"
                Case StringId.IconSetCategoryIndicators
                Return "אינדיקטורים"
                Case StringId.NewEditFormattingRuleFormatOnlyValuesThatAreAboveOrBelowAverage
                Return "פורמט רק ערכים שהם מעל או מתחת לממוצע"
                Case StringId.PictureEditMenuFullSize
                Return "בגודל מלא"
                Case StringId.FilterCriteriaToStringFunctionIif
                Return "Iif"
                Case StringId.TextEditMenuPaste
                Return "& הדבק"
                Case StringId.FilterCriteriaToStringFunctionCosh
                Return "Cosh"
                Case StringId.FormatRuleMenuItemGreaterThan
                Return "גדול מ-"
                Case StringId.ManageRuleFormatCellsNone
                Return "אף אחד"
                Case StringId.ColorPickSaturationAxisName
                Return "רוויה"
                Case StringId.ColorPickHueAxisName
                Return "גוון"
                Case StringId.ManageRuleNoFormatSet
                Return "לא הוגדרו בתבנית"
                Case StringId.FilterCriteriaToStringFunctionMin
                Return "Min"
                Case StringId.ManageRuleAboveAverage
                Return "מעל הממוצע"
                Case StringId.FormatRuleDateOccurring
                Return "עיצוב תאים המכילים תאריך התאמת התנאים האלה"
                Case StringId.DefaultBooleanDefault
                Return "ברירת מחדל"
                Case StringId.PictureEditMenuFitImage
                Return "התאם תמונה"
                Case StringId.FilterCriteriaToStringFunctionIsNull
                Return "IsNull"
                Case StringId.FilterPopupToolbarIncrementalSearch
                Return "חיפוש מצטבר"
                Case StringId.TextEditMenuDelete
                Return "& מחק"
                Case StringId.CalcButtonCE
                Return "לסה נ"
                Case StringId.FilterCriteriaToStringBinaryOperatorEqual
                Return "="
                Case StringId.FormatRuleMenuItemLessThan
                Return "פחות מ"
                Case StringId.ManageRuleFormatCellsRegular
                Return "רגיל"
                Case StringId.ColorPickLuminanceAxisName
                Return "זוהר"
                Case StringId.FilterCriteriaToStringFunctionAcos
                Return "Acos"
                Case StringId.IconSetTitleArrows5Colored
                Return "5 חצים (בצבע)"
                Case StringId.ManageRuleBelowAverage
                Return "מתחת לממוצע"
                Case StringId.IconSetCategorySymbols
                Return "סמלים"
                Case StringId.FormatPredefinedAppearanceRedFillRedText
                Return "מילוי אדום עם טקסט אדום"
                Case StringId.PictureEditMenuZoomIn
                Return "התקרבות"
                Case StringId.FilterCriteriaToStringFunctionLen
                Return "לן"
                Case StringId.NewEditFormattingRuleFormatOnlyUniqueOrDuplicateValues
                Return "עיצוב ערכים ייחודיים או כפולים בלבד"
                Case StringId.FormatPredefinedAppearanceStrikeoutText
                Return "קו חוצה טקסט"
                Case StringId.FilterCriteriaToStringFunctionLog10
                Return "Log10"
                Case StringId.TextEditMenuSelectAll
                Return "כל & בחר"
                Case StringId.FormatRuleMenuItemBetween
                Return "בין"
                Case StringId.ColorPickRedValidationMsg
                Return "ורכיב האדום צריך להיות בתוך טווח 0..255"
                Case StringId.ManageRuleFormatCellsBold
                Return "מודגש"
                Case StringId.ColorPickBrightnessAxisName
                Return "בהירות"
                Case StringId.FilterCriteriaToStringFunctionAsin
                Return "Asin"
                Case StringId.ManageRuleColorScaleMidpoint
                Return "נקודת אמצע"
                Case StringId.ProgressExport
                Return "ייצוא"
                Case StringId.ManageRuleEqualOrAboveAverage
                Return "שווה או מעל הממוצע"
                Case StringId.FormatPredefinedAppearanceYellowFillYellowText
                Return "מילוי בצבע צהוב עם טקסט צהוב"
                Case StringId.PictureEditMenuZoomOut
                Return "התרחקות"
                Case StringId.FilterPopupToolbarMultiSelection
                Return "בחירה מרובה"
                Case StringId.FilterCriteriaToStringFunctionLower
                Return "נמוך יותר"
                Case StringId.ManageRuleAverageAbove
                Return "מעל"
                Case StringId.CalcButtonC
                Return "C"
                Case StringId.FilterCriteriaToStringBinaryOperatorGreater
                Return ">"
                Case StringId.ManageRuleAverageEqualOrAbove
                Return "שווה או מעל"
                Case StringId.FormatRuleMenuItemEqualTo
                Return "שווה ל"
                Case StringId.TakePictureDialogTryAgain
                Return "נסה שוב"
                Case StringId.ColorPickOpacityAxisName
                Return "אטימות"
                Case StringId.ManageRuleDataBarAxisColor
                Return "ציר צבע:"
                Case StringId.FormatPredefinedAppearanceGreenFillGreenText
                Return "מילוי בצבע ירוק עם טקסט ירוק"
                Case StringId.PictureEditMenuZoomTo
                Return "זום:"
                Case StringId.FilterPopupToolbarRadioMode
                Return "מצב רדיו"
                Case StringId.NewEditFormattingRuleUseAFormulaToDetermineWhichCellsToFormat
                Return "שימוש בנוסחה כדי לקבוע אילו תאים כדי לעצב"
                Case StringId.FilterCriteriaToStringFunctionNone
                Return "אף אחד"
                Case StringId.ManageRuleAverageBelow
                Return "להלן"
                Case StringId.ManageRuleAverageEqualOrBelow
                Return "שווה או להלן"
                Case StringId.FilterCriteriaToStringFunctionSinh
                Return "Sinh"
                Case StringId.ManageRuleFormatCellsItalic
                Return "נטוי"
                Case StringId.FormatRuleMenuItemTextThatContains
                Return "טקסט המכיל"
                Case StringId.TakePictureDialogSave
                Return "שמור"
                Case StringId.FormatPredefinedAppearanceRedFill
                Return "מילוי אדום"
                Case StringId.ManageRuleDataBarBarAppearance
                Return "בר המראה:"
                Case StringId.PictureEditMenuZoomToolTip
                Return "{0} %"
                Case StringId.FilterPopupToolbarInvertFilter
                Return "המסנן ' היפוך '"
                Case StringId.ProgressPrinting
                Return "הדפסה"
                Case StringId.FilterCriteriaToStringFunctionSubstring
                Return "מחרוזת משנה"
                Case StringId.CalcError
                Return "חישוב שגיאות"
                Case StringId.FilterCriteriaToStringBinaryOperatorGreaterOrEqual
                Return ">="
                Case StringId.ManageRuleFormulaFormatValuesWhereThisFormulaIsTrue
                Return "עצב ערכים איפה נכון בנוסחה זו:"
                Case StringId.FilterCriteriaToStringFunctionTanh
                Return "Tanh"
                Case StringId.IconSetTitleTrafficLights3Unrimmed
                Return "3 רמזורים (Unrimmed)"
                Case StringId.FormatRuleMenuItemCustomCondition
                Return "מצב מותאם אישית"
                Case StringId.ManageRuleDataBarBarDirection
                Return "בר כיוון"
                Case StringId.CameraSettingsActiveDevice
                Return "התקן פעיל:"
                Case StringId.FormatPredefinedAppearanceRedText
                Return "הטקסט האדום"
                Case StringId.ColorPickPopupAutomaticItemCaption
                Return "אוטומטי"
                Case StringId.ManageRuleComplexRuleBaseFormatStyle
                Return "סגנון עיצוב:"
                Case StringId.FilterCriteriaToStringFunctionTrim
                Return "לקצץ"
                Case StringId.ManageRuleRankedValuesFormatValuesThatRankInThe
                Return "תבנית ערכים המדורגים בין:"
                Case StringId.TakePictureDialogTitle
                Return "לצלם"
                Case StringId.FilterCriteriaToStringFunctionPadLeft
                Return "משטח שמאל"
                Case StringId.ManageRuleDataBarFill
                Return "המילוי:"
                Case StringId.FormatRuleGreaterThanText
                Return "עיצוב תאים הנמצאים גדולה מ"
                Case StringId.CameraSettingsBrightness
                Return "בהירות:"
                Case StringId.FormatPredefinedAppearanceGreenFill
                Return "מילוי בצבע ירוק"
                Case StringId.ProgressCreateDocument
                Return "יצירת מסמך"
                Case StringId.TabHeaderButtonPrev
                Return "גלול שמאלה"
                Case StringId.FilterCriteriaToStringBinaryOperatorLess
                Return "<"
                Case StringId.ColorPickPopupThemeColorsGroupCaption
                Return "צבעי ערכת נושא"
                Case StringId.FilterCriteriaToStringFunctionUpper
                Return "העליון"
                Case StringId.ManageRuleRankedValuesOfTheColumnsCellValues
                Return "% מהערכים בעמודה"
                Case StringId.IconSetTitleTrafficLights3Rimmed
                Return "3 רמזורים (מסגרת)"
                Case StringId.FilterCriteriaToStringFunctionPadRight
                Return "משטח ישר"
                Case StringId.FormatRuleLessThanText
                Return "עיצוב תאים כי הם פחות מאשר"
                Case StringId.CameraSettingsContrast
                Return "חדות:"
                Case StringId.ManageRuleDataBarSolidFill
                Return "מילוי מלא"
                Case StringId.FormatPredefinedAppearanceGreenText
                Return "טקסט ירוק"
                Case StringId.ColorPickPopupStandardColorsGroupCaption
                Return "צבעים רגילים"
                Case StringId.ManageRuleColorScale2
                Return "דו-צבעי"
                Case StringId.FilterCriteriaToStringFunctionIsThisYear
                Return "השנה"
                Case StringId.TakePictureMenuItem
                Return "לקחת את התמונות מהמצלמה"
                Case StringId.ManageRuleRankedValuesTop
                Return "העליון"
                Case StringId.FilterCriteriaToStringFunctionDateDiffTick
                Return "תאריך diff שנתות"
                Case StringId.ManageRuleDataBarBorder
                Return "הגבול:"
                Case StringId.CameraSettingsDesaturate
                Return "הפחתת רוויה:"
                Case StringId.ProgressCancel
                Return "ביטול"
                Case StringId.ManageRuleDataBarGradientFill
                Return "מילוי"
                Case StringId.FormatPredefinedAppearanceBoldText
                Return "טקסט מודגש"
                Case StringId.TakePictureDialogCapture
                Return "לכידת"
                Case StringId.TabHeaderButtonNext
                Return "גלול ימינה"
                Case StringId.FilterCriteriaToStringBinaryOperatorLessOrEqual
                Return "<="
                Case StringId.ManageRuleRankedValuesBottom
                Return "התחתון"
                Case StringId.FilterCriteriaToStringFunctionDateDiffSecond
                Return "תאריך diff שנית"
                Case StringId.CameraSettingsDefaults
                Return "איפוס לברירות המחדל"
                Case StringId.IconSetTitleSigns3
                Return "3 שלטים"
                Case StringId.ManageRuleDataBarNoBorder
                Return "ללא גבול"
                Case StringId.FormatPredefinedAppearanceItalicText
                Return "טקסט נטוי"
                Case StringId.ManageRuleColorScale3
                Return "סרגל תלת-צבעי"
                Case StringId.ManageRuleThatContainFormatOnlyCellsWith
                Return "עיצוב תאים עם:"
                Case StringId.ManageRuleDataBarDrawAxis
                Return "לצייר ציר"
                Case StringId.FilterCriteriaToStringFunctionDateDiffMilliSecond
                Return "תאריך diff אלפיות השנייה"
                Case StringId.CameraSettingsCaption
                Return "הגדרות המצלמה"
                Case StringId.ProgressCancelPending
                Return "לבטל את המתנה"
                Case StringId.ManageRuleDataBarSolidBorder
                Return "הגבול המלא"
                Case StringId.ManageRuleDataBar
                Return "סרגל נתונים"
                Case StringId.ManageRuleThatContainCellValue
                Return "ערך התא"
                Case StringId.TabHeaderButtonUp
                Return "גלילה כלפי מעלה"
                Case StringId.FilterCriteriaToStringBinaryOperatorLike
                Return "כמו"
                Case StringId.FilterCriteriaToStringFunctionDateDiffMinute
                Return "תאריך diff דקות"
                Case StringId.CameraSettingsResolution
                Return "רזולוציה:"
                Case StringId.ManageRuleDataBarContext
                Return "ההקשר"
                Case StringId.IconSetTitleTrafficLights4
                Return "4 רמזורים"
                Case StringId.ManageRuleIconSets
                Return "ערכות סמלים"
                Case StringId.ManageRuleThatContainDatesOccurring
                Return "תאריכים המתרחשים"
                Case StringId.ManageRuleDataBarUseNegativeBar
                Return "שימוש שלילי בר"
                Case StringId.FilterCriteriaToStringFunctionDateDiffHour
                Return "תאריך שעה diff"
                Case StringId.ProgressLoadingData
                Return "טעינת נתונים"
                Case StringId.CameraDeviceNotFound
                Return "מצלמת לא נמצאו. בדוק את חיבור מצלמת אינטרנט או הגדרות ההתקן."
                Case StringId.ManageRuleDataBarLTR
                Return "משמאל-לימין"
                Case StringId.ManageRuleCommonMinimum
                Return "מינימום"
                Case StringId.TabHeaderButtonDown
                Return "גלול למטה"
                Case StringId.FilterCriteriaToStringBinaryOperatorMinus
                Return "-"
                Case StringId.ManageRuleThatContainSpecificText
                Return "טקסט ספציפי"
                Case StringId.IconSetTitleRedToBlack
                Return "אדום שחור"
                Case StringId.CameraDeviceIsBusy
                Return "לא ניתן להשתמש המכשיר, כפי שהוא כבר נמצא בשימוש של יישום אחר."
                Case StringId.ManageRuleDataBarRTL
                Return "מימין-לשמאל"
                Case StringId.TabHeaderButtonClose
                Return "סגור"
                Case StringId.FilterCriteriaToStringFunctionDateDiffDay
                Return "תאריך יום diff"
                Case StringId.ManageRuleThatContainBlanks
                Return "כדורי סרק"
                Case StringId.FilterAggregateAvg
                Return "Avg"
                Case StringId.FilterCriteriaToStringBinaryOperatorModulo
                Return "%"
                Case StringId.ManageRuleIconSetsDisplayEachIconAccordingToTheseRules
                Return "הצגת כל סמל לפי כללים אלה:"
                Case StringId.FilterCriteriaToStringFunctionDateDiffMonth
                Return "תאריך diff חודש"
                Case StringId.CameraDesignTimeInfo
                Return "עיבוד אינו זמין בזמן העיצוב."
                Case StringId.ManageRuleThatContainNoBlanks
                Return "ללא רווחים"
                Case StringId.FilterAggregateCount
                Return "ספירה"
                Case StringId.FilterCriteriaToStringFunctionDateDiffYear
                Return "תאריך diff בשנה"
                Case StringId.ManageRuleIconSetsReverseIconOrder
                Return "להפוך את סדר הסמלים"
                Case StringId.OfficeNavigationOptions
                Return "אפשרויות ניווט"
                Case StringId.ManageRuleThatContainErrors
                Return "שגיאות"
                Case StringId.ManageRuleThatContainNoErrors
                Return "שגיאות"
                Case StringId.ManageRuleIconSetsWhen
                Return "מתי"
                Case StringId.ManageRuleIconSetsValueIs
                Return "הערך הוא"
                Case StringId.ManageRuleSimpleRuleBaseFormat
                Return "עיצוב..."
                Case StringId.ManageRuleAverageFormatValuesThatAre
                Return "תבנית ערכים:"
                Case StringId.ManageRuleAverageTheAverageForTheSelectedRange
                Return "הממוצע של ערכי עמודה"
                Case Else
                Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class
End Namespace
