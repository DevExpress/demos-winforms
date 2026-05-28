using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.MailClient.Win.Localizer {
    public class FarsiEditorLocalizer : XtraEditors.Controls.Localizer {
        public override string GetLocalizedString(StringId id) {
            switch(id) {
                case StringId.None:
                return "";
                case StringId.CaptionError:
                return "خطا";
                case StringId.InvalidValueText:
                return "مقدار نامعتبر";
                case StringId.CheckChecked:
                return "بررسی";
                case StringId.CheckUnchecked:
                return "بدون کنترل";
                case StringId.CheckIndeterminate:
                return "نا مشخص";
                case StringId.SearchControlNullValuePrompt:
                return "متن جستجو را وارد کنید...";
                case StringId.DateEditToday:
                return "امروز";
                case StringId.DateEditClear:
                return "روشن";
                case StringId.OK:
                return "باشه";
                case StringId.Cancel:
                return "لغو";
                case StringId.NavigatorFirstButtonHint:
                return "اول";
                case StringId.NavigatorPreviousButtonHint:
                return "قبلی";
                case StringId.NavigatorPreviousPageButtonHint:
                return "صفحه قبلی";
                case StringId.NavigatorNextButtonHint:
                return "بعدی";
                case StringId.NavigatorNextPageButtonHint:
                return "صفحه بعد";
                case StringId.NavigatorLastButtonHint:
                return "آخرين";
                case StringId.NavigatorAppendButtonHint:
                return "الحاق";
                case StringId.NavigatorRemoveButtonHint:
                return "حذف";
                case StringId.NavigatorEditButtonHint:
                return "ویرایش";
                case StringId.NavigatorEndEditButtonHint:
                return "پایان ویرایش";
                case StringId.NavigatorCancelEditButtonHint:
                return "لغو ویرایش";
                case StringId.NavigatorTextStringFormat:
                return "رکورد {0} از {1}";
                case StringId.PictureEditMenuCut:
                return "برش";
                case StringId.PictureEditMenuCopy:
                return "کپی";
                case StringId.PictureEditMenuPaste:
                return "جای گذاری";
                case StringId.PictureEditMenuDelete:
                return "حذف";
                case StringId.PictureEditMenuLoad:
                return "بار";
                case StringId.PictureEditMenuSave:
                return "ذخیره";
                case StringId.PictureEditOpenFileFilter:
                return "فایل (*.bmp) بیت مپ | *. bmp| فرمت مبادله گرافیک (*.gif) | *. gif| فایل مبادله فرمت JPEG (*.jpg; *.jpeg) | *. jpg; *. jpeg| فایل های آیکون (*.ico) | *. ico| قابل حمل قالب کارت شبکه (*.png) | *. png| تمام فایل های تصویری | * .bmp; *.gif; *.jpg; *.jpeg; *.ico; *.png; *. tif| تمام فایل | *. *";
                case StringId.PictureEditSaveFileFilter:
                return "فایل (*.bmp) بیت مپ | *. bmp| فرمت مبادله گرافیک (*.gif) | *. gif| فایل مبادله فرمت JPEG (*.jpg) | *. jpg| فرمت گرافیکی قابل حمل شبکه (*.png) | * .png";
                case StringId.PictureEditOpenFileTitle:
                return "باز";
                case StringId.PictureEditSaveFileTitle:
                return "ذخیره به عنوان";
                case StringId.PictureEditOpenFileError:
                return "فرمت تصویر اشتباه";
                case StringId.PictureEditOpenFileErrorCaption:
                return "خطا در باز کردن";
                case StringId.PictureEditCopyImageError:
                return "نمی تواند رونوشت تصویر";
                case StringId.LookUpEditValueIsNull:
                return "[EditValue پوچ است]";
                case StringId.LookUpInvalidEditValueType:
                return "نوع نامعتبر LookUpEdit EditValue.";
                case StringId.LookUpColumnDefaultName:
                return "نام";
case StringId.UnknownPictureFormat:
                return "فرمت عکس های ناشناخته";
                case StringId.DataEmpty:
                return "فعلا تصویر";
                case StringId.NotValidArrayLength:
                return "طول آرایه معتبر نیست.";
                case StringId.ImagePopupEmpty:
                return "(خالی)";
                case StringId.ImagePopupPicture:
                return "(عکس)";
                case StringId.ColorTabCustom:
                return "سفارشی";
                case StringId.ColorTabWeb:
                return "وب";
                case StringId.ColorTabSystem:
                return "سیستم";
                case StringId.CalcButtonMC:
                return "پیمانکار مدیریت";
                case StringId.CalcButtonMR:
                return "آقاي";
                case StringId.CalcButtonMS:
                return "کارشناسی ارشد";
                case StringId.CalcButtonMx:
                return "M +";
                case StringId.CalcButtonSqrt:
                return "sqrt";
                case StringId.CalcButtonBack:
                return "پشت";
                case StringId.CalcButtonCE:
                return "م.";
                case StringId.CalcButtonC:
                return "ج";
                case StringId.CalcError:
                return "محاسبه خطا";
                case StringId.TabHeaderButtonPrev:
                return "پیمایش به چپ";
                case StringId.TabHeaderButtonNext:
                return "پیمایش به راست";
                case StringId.TabHeaderButtonUp:
                return "رفته بالا";
                case StringId.TabHeaderButtonDown:
                return "پایین";
                case StringId.TabHeaderButtonClose:
                return "بستن";
                case StringId.TabHeaderButtonPin:
                return "پین";
                case StringId.TabHeaderButtonUnpin:
                return "عدم اتصال";
                case StringId.TabHeaderSelectorButton:
                return "نمایش لیست پنجره";
                case StringId.XtraMessageBoxOkButtonText:
                return "& خوب";
                case StringId.XtraMessageBoxCancelButtonText:
                return "& لغو";
                case StringId.XtraMessageBoxYesButtonText:
                return "& بله";
                case StringId.XtraMessageBoxNoButtonText:
                return "& هیچ";
                case StringId.XtraMessageBoxAbortButtonText:
                return "& سقط جنین";
                case StringId.XtraMessageBoxRetryButtonText:
                return "& مجدد";
                case StringId.XtraMessageBoxIgnoreButtonText:
                return "& چشم پوشی";
                case StringId.TextEditMenuUndo:
                return "& باطل";
                case StringId.TextEditMenuCut:
                return "مس & t";
                case StringId.TextEditMenuCopy:
                return "& کپی";
                case StringId.TextEditMenuPaste:
                return "& رب";
                case StringId.TextEditMenuDelete:
                return "& حذف";
                case StringId.TextEditMenuSelectAll:
                return "انتخاب همه &";
                case StringId.FilterEditorTabText:
                return "متن";
                case StringId.FilterEditorTabVisual:
                return "بصری";
                case StringId.FilterShowAll:
                return "(انتخاب همه)";
                case StringId.FilterGroupAnd:
                return "و";
                case StringId.FilterGroupNotAnd:
                return "نه و";
                case StringId.FilterGroupNotOr:
                return "نمی یا";
                case StringId.FilterGroupOr:
                return "یا";
                case StringId.FilterClauseAnyOf:
                return "هیچ یک از";
                case StringId.FilterClauseBeginsWith:
                return "با آغاز می شود";
                case StringId.FilterClauseBetween:
                return "بین";
                case StringId.FilterClauseBetweenAnd:
                return "و";
                case StringId.FilterClauseContains:
                return "شامل";
                case StringId.FilterClauseEndsWith:
                return "با به پایان می رسد";
                case StringId.FilterClauseEquals:
                return "برابر است با";
                case StringId.FilterClauseGreater:
                return "بزرگتر از";
                case StringId.FilterClauseGreaterOrEqual:
                return "بزرگتر از یا برابر با";
                case StringId.FilterClauseIsNotNull:
                return "پوچ است";
                case StringId.FilterClauseIsNull:
                return "پوچ است";
                case StringId.FilterClauseIsNotNullOrEmpty:
                return "خالی نیست";
                case StringId.FilterClauseIsNullOrEmpty:
                return "خالی است";
                case StringId.FilterClauseLess:
                return "است کمتر از";
                case StringId.FilterClauseLessOrEqual:
                return "کمتر از یا مساوی با";
                case StringId.FilterClauseLike:
                return "مثل";
                case StringId.FilterClauseNoneOf:
                return "هیچ کدام از";
                case StringId.FilterClauseNotBetween:
                return "نیست بین";
                case StringId.FilterClauseDoesNotContain:
                return "شامل نمی شود";
                case StringId.FilterClauseDoesNotEqual:
                return "نامساوی";
                case StringId.FilterClauseNotLike:
                return "مانند نیست";
                case StringId.FilterMenuAddNewParameter:
                return "اضافه کردن پارامتر...";
                case StringId.FilterEmptyValue:
                return "<empty></empty>";
                case StringId.FilterMenuConditionAdd:
                return "اضافه کردن وضعیت";
                case StringId.FilterMenuGroupAdd:
                return "افزودن گروه";
                case StringId.FilterMenuClearAll:
                return "پاک کردن همه";
                case StringId.FilterMenuRowRemove:
                return "حذف گروه";
                case StringId.FilterToolTipNodeAdd:
                return "شرایط جدید را به این گروه اضافه می کند";
                case StringId.FilterToolTipNodeRemove:
                return "این وضعیت را حذف می کند";
                case StringId.FilterToolTipNodeAction:
                return "اقدامات";
                case StringId.FilterToolTipValueType:
                return "مقایسه با ارزش / دیگر مقدار فیلد را";
                case StringId.FilterToolTipElementAdd:
                return "یک آیتم جدید به لیست اضافه می کند";
                case StringId.FilterToolTipKeysAdd:
                return "(استفاده از قرار دادن یا اضافه کردن کلید)";
                case StringId.FilterToolTipKeysRemove:
                return "(استفاده از حذف یا کلید تفریق)";
                case StringId.ContainerAccessibleEditName:
                return "کنترل ویرایش";
                case StringId.FilterCriteriaToStringGroupOperatorAnd:
                return "و";
                case StringId.FilterCriteriaToStringGroupOperatorOr:
                return "یا";
                case StringId.FilterCriteriaToStringUnaryOperatorBitwiseNot:
                return "~";
                case StringId.FilterCriteriaToStringUnaryOperatorIsNull:
                return "پوچ است";
                case StringId.FilterCriteriaToStringUnaryOperatorMinus:
                return "-";
                case StringId.FilterCriteriaToStringUnaryOperatorNot:
                return "نه";
                case StringId.FilterCriteriaToStringUnaryOperatorPlus:
                return "+";
                case StringId.FilterCriteriaToStringBinaryOperatorBitwiseAnd:
                return "&";
                case StringId.FilterCriteriaToStringBinaryOperatorBitwiseOr:
                return "|";
                case StringId.FilterCriteriaToStringBinaryOperatorBitwiseXor:
                return "^";
                case StringId.FilterCriteriaToStringBinaryOperatorDivide:
                return "/";
                case StringId.FilterCriteriaToStringBinaryOperatorEqual:
                return "=";
                case StringId.FilterCriteriaToStringBinaryOperatorGreater:
                return ">";
                case StringId.FilterCriteriaToStringBinaryOperatorGreaterOrEqual:
                return ">=";
                case StringId.FilterCriteriaToStringBinaryOperatorLess:
                return "<";
                case StringId.FilterCriteriaToStringBinaryOperatorLessOrEqual:
                return "<=";
                case StringId.FilterCriteriaToStringBinaryOperatorLike:
                return "مانند";
                case StringId.FilterCriteriaToStringBinaryOperatorMinus:
                return "-";
                case StringId.FilterCriteriaToStringBinaryOperatorModulo:
                return "%";
                case StringId.FilterCriteriaToStringBinaryOperatorMultiply:
                return "*";
                case StringId.FilterCriteriaToStringBinaryOperatorNotEqual:
                return "<>";
                case StringId.FilterCriteriaToStringBinaryOperatorPlus:
                return "+";
                case StringId.FilterCriteriaToStringBetween:
                return "بین";
                case StringId.FilterCriteriaToStringIn:
                return "در";
                case StringId.FilterCriteriaToStringIsNotNull:
                return "پوچ است";
                case StringId.FilterCriteriaToStringNotLike:
                return "نه مثل";
                case StringId.FilterCriteriaToStringFunctionIif:
                return "Iif";
                case StringId.FilterCriteriaToStringFunctionIsNull:
                return "IsNull";
                case StringId.FilterCriteriaToStringFunctionLen:
                return "لن";
                case StringId.FilterCriteriaToStringFunctionLower:
                return "پایین تر";
                case StringId.FilterCriteriaToStringFunctionNone:
                return "هیچ کدام";
                case StringId.FilterCriteriaToStringFunctionSubstring:
                return "زیر رشته";
                case StringId.FilterCriteriaToStringFunctionTrim:
                return "تر و تمیز";
                case StringId.FilterCriteriaToStringFunctionUpper:
                return "بالا";
                case StringId.FilterCriteriaToStringFunctionIsThisYear:
                return "امسال است";
                case StringId.FilterCriteriaToStringFunctionIsThisMonth:
                return "این ماه است";
                case StringId.FilterCriteriaToStringFunctionIsThisWeek:
                return "این هفته";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisYear:
                return "امسال";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisMonth:
                return "این ماه";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeLastWeek:
                return "هفته ی قبل";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisWeek:
                return "این هفته";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeYesterday:
                return "دیروز";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeToday:
                return "امروز";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeNow:
                return "در حال حاضر";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeTomorrow:
                return "فردا";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeDayAfterTomorrow:
                return "روز بعد از فردا";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextWeek:
                return "هفته ی بعد";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeTwoWeeksAway:
                return "دو هفته بعد";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextMonth:
                return "ماه آینده";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextYear:
                return "سال آینده";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalBeyondThisYear:
                return "فراتر از امسال است";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisYear:
                return "بعد از این سال است";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisMonth:
                return "بعد از این ماه است";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalNextWeek:
                return "آینده است";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisWeek:
                return "بعد از این هفته";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalTomorrow:
                return "فردا";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalToday:
                return "امروز است";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalYesterday:
                return "دیروز است";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisWeek:
                return "اوایل این هفته است";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLastWeek:
                return "هفته گذشته";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisMonth:
                return "در اوایل این ماه است";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisYear:
                return "اوایل سال جاری است";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalPriorThisYear:
                return "قبل از این سال است";
                case StringId.FilterCriteriaToStringFunctionCustom:
                return "سفارشی";
                case StringId.FilterCriteriaToStringFunctionCustomNonDeterministic:
                return "سفارشی غیر قطعی";
                case StringId.FilterCriteriaToStringFunctionIsNullOrEmpty:
                return "خالي است";
                case StringId.FilterCriteriaToStringFunctionConcat:
                return "تماس با";
                case StringId.FilterCriteriaToStringFunctionAscii:
                return "اسکی";
                case StringId.FilterCriteriaToStringFunctionChar:
                return "کاراکتر";
                case StringId.FilterCriteriaToStringFunctionToInt:
                return "به اعضای هیات تحریریه";
                case StringId.FilterCriteriaToStringFunctionToLong:
                return "به طول";
                case StringId.FilterCriteriaToStringFunctionToFloat:
                return "برای شناور";
                case StringId.FilterCriteriaToStringFunctionToDouble:
                return "به دو";
                case StringId.FilterCriteriaToStringFunctionToDecimal:
                return "به ده دهی";
                case StringId.FilterCriteriaToStringFunctionToStr:
                return "به خ";
                case StringId.FilterCriteriaToStringFunctionReplace:
                return "جایگزین";
                case StringId.FilterCriteriaToStringFunctionReverse:
                return "معکوس";
                case StringId.FilterCriteriaToStringFunctionInsert:
                return "را وارد کنید";
                case StringId.FilterCriteriaToStringFunctionCharIndex:
                return "شاخص کاراکتر";
                case StringId.FilterCriteriaToStringFunctionRemove:
                return "حذف";
                case StringId.FilterCriteriaToStringFunctionAbs:
                return "Abs";
                case StringId.FilterCriteriaToStringFunctionSqr:
                return "میدان";
                case StringId.FilterCriteriaToStringFunctionCos:
                return "Cos";
                case StringId.FilterCriteriaToStringFunctionSin:
                return "گناه";
                case StringId.FilterCriteriaToStringFunctionAtn:
                return "Atn";
                case StringId.FilterCriteriaToStringFunctionExp:
                return "درصد این سطح";
                case StringId.FilterCriteriaToStringFunctionLog:
                return "ورود به سیستم";
                case StringId.FilterCriteriaToStringFunctionRnd:
                return "آرند";
                case StringId.FilterCriteriaToStringFunctionTan:
                return "قهوهای مایل به زرد";
                case StringId.FilterCriteriaToStringFunctionPower:
                return "قدرت";
                case StringId.FilterCriteriaToStringFunctionSign:
                return "ورود به سیستم";
                case StringId.FilterCriteriaToStringFunctionRound:
                return "دور";
                case StringId.FilterCriteriaToStringFunctionCeiling:
                return "سقف";
                case StringId.FilterCriteriaToStringFunctionFloor:
                return "طبقه";
                case StringId.FilterCriteriaToStringFunctionMax:
                return "حداکثر";
                case StringId.FilterCriteriaToStringFunctionMin:
                return "دقیقه";
                case StringId.FilterCriteriaToStringFunctionAcos:
                return "Acos";
                case StringId.FilterCriteriaToStringFunctionAsin:
                return "آسین";
                case StringId.FilterCriteriaToStringFunctionAtn2:
                return "Atn2";
                case StringId.FilterCriteriaToStringFunctionBigMul:
                return "بازار بزرگ";
                case StringId.FilterCriteriaToStringFunctionCosh:
                return "Cosh";
                case StringId.FilterCriteriaToStringFunctionLog10:
                return "Log10";
                case StringId.FilterCriteriaToStringFunctionSinh:
                return "Sinh";
                case StringId.FilterCriteriaToStringFunctionTanh:
                return "Tanh";
                case StringId.FilterCriteriaToStringFunctionPadLeft:
                return "پد سمت چپ";
                case StringId.FilterCriteriaToStringFunctionPadRight:
                return "پد سمت راست";
                case StringId.FilterCriteriaToStringFunctionDateDiffTick:
                return "تاریخ تفاوت کنه";
                case StringId.FilterCriteriaToStringFunctionDateDiffSecond:
                return "تفاوت دوم ۱۳۹۰";
                case StringId.FilterCriteriaToStringFunctionDateDiffMilliSecond:
                return "تاریخ تفاوت میلی ثانیه";
                case StringId.FilterCriteriaToStringFunctionDateDiffMinute:
                return "دقیقه تفاوت تاریخ";
                case StringId.FilterCriteriaToStringFunctionDateDiffHour:
                return "تفاوت تاریخ";
                case StringId.FilterCriteriaToStringFunctionDateDiffDay:
                return "تاریخ روز تفاوت";
                case StringId.FilterCriteriaToStringFunctionDateDiffMonth:
                return "شدن تفاوت ماه";
                case StringId.FilterCriteriaToStringFunctionDateDiffYear:
                return "تاریخ سال تفاوت";
                case StringId.FilterCriteriaToStringFunctionGetDate:
                return "تاریخ دریافت";
                case StringId.FilterCriteriaToStringFunctionGetMilliSecond:
                return "دریافت میلی ثانیه";
                case StringId.FilterCriteriaToStringFunctionGetSecond:
                return "می دوم";
                case StringId.FilterCriteriaToStringFunctionGetMinute:
                return "دریافت دقیقه";
                case StringId.FilterCriteriaToStringFunctionGetHour:
                return "دریافت ساعت";
                case StringId.FilterCriteriaToStringFunctionGetDay:
                return "دریافت روز";
                case StringId.FilterCriteriaToStringFunctionGetMonth:
                return "ماه";
                case StringId.FilterCriteriaToStringFunctionGetYear:
                return "سال";
                case StringId.FilterCriteriaToStringFunctionGetDayOfWeek:
                return "دریافت روز هفته";
                case StringId.FilterCriteriaToStringFunctionGetDayOfYear:
                return "دریافت روز سال";
                case StringId.FilterCriteriaToStringFunctionGetTimeOfDay:
                return "زمان روز";
                case StringId.FilterCriteriaToStringFunctionNow:
                return "در حال حاضر";
                case StringId.FilterCriteriaToStringFunctionUtcNow:
                return "در حال حاضر Utc";
                case StringId.FilterCriteriaToStringFunctionToday:
                return "امروز";
                case StringId.FilterCriteriaToStringFunctionAddTimeSpan:
                return "اضافه کردن طول زمان";
                case StringId.FilterCriteriaToStringFunctionAddTicks:
                return "اضافه کنه";
                case StringId.FilterCriteriaToStringFunctionAddMilliSeconds:
                return "اضافه کردن میلی ثانیه";
                case StringId.FilterCriteriaToStringFunctionAddSeconds:
                return "اضافه کردن ثانیه";
                case StringId.FilterCriteriaToStringFunctionAddMinutes:
                return "دقیقه";
                case StringId.FilterCriteriaToStringFunctionAddHours:
                return "اضافه کردن ساعت";
                case StringId.FilterCriteriaToStringFunctionAddDays:
                return "اضافه کردن روز";
                case StringId.FilterCriteriaToStringFunctionAddMonths:
                return "اضافه کردن ماه";
                case StringId.FilterCriteriaToStringFunctionAddYears:
                return "اضافه سال";
                case StringId.FilterCriteriaToStringFunctionStartsWith:
                return "با شروع می شود";
                case StringId.FilterCriteriaToStringFunctionEndsWith:
                return "با به پایان می رسد";
                case StringId.FilterCriteriaToStringFunctionContains:
                return "شامل";
                case StringId.FilterCriteriaInvalidExpression:
                return "بيان مشخص شده نامعتبر نمادها (خط {0}، شخصیت {1}) است.";
                case StringId.FilterCriteriaInvalidExpressionEx:
                return "بيان مشخص شده نامعتبر است.";
                case StringId.Apply:
                return "درخواست";
                case StringId.PreviewPanelText:
                return "پیش نمایش:";
                case StringId.TransparentBackColorNotSupported:
                return "این کنترل رنگ پس زمینه شفاف را پشتیبانی نمی کند";
                case StringId.FilterOutlookDateText:
                return "نمایش all| نمایش Empty| فیلتر توسط تاریخ خاص: |Beyond این year| بعد این year| بعد این month| Week| بعدی بعد این week| Tomorrow| Today| Yesterday| قبلا این week| آخرین week| قبلا این month| قبلا این year| قبل از این سال";
                case StringId.FilterDateTimeConstantMenuCaption:
                return "تاریخ و زمان ثابت";
                case StringId.FilterDateTimeOperatorMenuCaption:
                return "تاریخ و زمان اپراتور";
                case StringId.FilterDateTextAlt:
                return "نمایش all| نمایش Empty| فیلتر توسط تاریخ خاص: |Beyond||| Week| بعدی Today| این week| این month| Earlier| {0:yyyy}، {0: MMMM}";
                case StringId.FilterFunctionsMenuCaption:
                return "توابع";
                case StringId.DefaultBooleanTrue:
                return "درست است";
                case StringId.DefaultBooleanFalse:
                return "نادرست";
                case StringId.DefaultBooleanDefault:
                return "پیش فرض";
                case StringId.ProgressExport:
                return "صادرات";
                case StringId.ProgressPrinting:
                return "چاپ";
                case StringId.ProgressCreateDocument:
                return "ایجاد نوشتار";
                case StringId.ProgressCancel:
                return "لغو";
                case StringId.ProgressCancelPending:
                return "بررسی لغو";
                case StringId.ProgressLoadingData:
                return "بارگذاری داده ها";
                case StringId.FilterAggregateAvg:
                return "متوسط امتیاز";
                case StringId.FilterAggregateCount:
                return "تعداد دفعات مشاهده";
                case StringId.FilterAggregateExists:
                return "وجود دارد";
                case StringId.FilterAggregateMax:
                return "حداکثر";
                case StringId.FilterAggregateMin:
                return "دقیقه";
                case StringId.FilterAggregateSum:
                return "مجموع";
                case StringId.FieldListName:
                return "لیست زمینه ({0})";
                case StringId.RestoreLayoutDialogFileFilter:
                return "فایل های XML (*.xml) | *. xml| تمام پرونده هاى مضمون| *. *";
                case StringId.SaveLayoutDialogFileFilter:
                return "فایل های XML (*.xml) | * .xml";
                case StringId.RestoreLayoutDialogTitle:
                return "طرح بازیابی";
                case StringId.SaveLayoutDialogTitle:
                return "ذخیره چیدمان";
                case StringId.PictureEditMenuZoom:
                return "زوم";
                case StringId.PictureEditMenuFullSize:
                return "اندازه کامل";
                case StringId.PictureEditMenuFitImage:
                return "تصویر مناسب";
                case StringId.PictureEditMenuZoomIn:
                return "بزرگنمایی";
                case StringId.PictureEditMenuZoomOut:
                return "زوم کردن";
                case StringId.PictureEditMenuZoomTo:
                return "زوم:";
                case StringId.PictureEditMenuZoomToolTip:
                return "درصد {0}";
                case StringId.FilterPopupToolbarShowOnlyAvailableItems:
                return "تنها موارد موجود نشان می دهد";
                case StringId.FilterPopupToolbarShowNewValues:
                return "نشان دادن ارزش های زمینه جدید";
                case StringId.FilterPopupToolbarIncrementalSearch:
                return "جستجوی افزایشی";
                case StringId.FilterPopupToolbarMultiSelection:
                return "انتخاب چند";
                case StringId.FilterPopupToolbarRadioMode:
                return "حالت رادیو";
                case StringId.FilterPopupToolbarInvertFilter:
                return "معکوس کردن فیلتر";
                case StringId.ColorPickPopupAutomaticItemCaption:
                return "خودکار";
                case StringId.ColorPickPopupThemeColorsGroupCaption:
                return "رنگهای مضمون";
                case StringId.ColorPickPopupStandardColorsGroupCaption:
                return "رنگ های استاندارد";
                case StringId.ColorPickPopupRecentColorsGroupCaption:
                return "رنگ های اخیر";
                case StringId.ColorPickPopupMoreColorsItemCaption:
                return "رنگهای بیشتر...";
                case StringId.ColorPickHueAxisName:
                return "رنگ";
                case StringId.ColorPickSaturationAxisName:
                return "اشباع";
                case StringId.ColorPickLuminanceAxisName:
                return "درخشندگی";
                case StringId.ColorPickBrightnessAxisName:
                return "روشنایی";
                case StringId.ColorPickOpacityAxisName:
                return "تاری";
                case StringId.ColorPickRedValidationMsg:
                return "جز قرمز می باید در محدوده 0..255";
                case StringId.ColorPickGreenValidationMsg:
                return "جز سبز می باید در محدوده 0..255";
                case StringId.ColorPickBlueValidationMsg:
                return "جزء کبود می باید در محدوده 0..255";
                case StringId.ColorPickOpacityValidationMsg:
                return "جزء کدورت می باید در محدوده 0..255";
                case StringId.ColorPickColorHexValidationMsg:
                return "مقدار هگزادسیمال نامعتبر";
                case StringId.ColorPickHueValidationMsg:
                return "جزء رنگ می باید در محدوده 0..359";
                case StringId.ColorPickSaturationValidationMsg:
                return "جزء اشباع می باید در محدوده 0..100";
                case StringId.ColorPickBrightValidationMsg:
                return "اجزای روشنایی می باید در محدوده 0..100";
                case StringId.ColorTabWebSafeColors:
                return "وب امن";
                case StringId.Days:
                return "روز";
                case StringId.Hours:
                return "ساعت";
                case StringId.Mins:
                return "دقیقه";
                case StringId.Secs:
                return "ثانیه";
                case StringId.Millisecs:
                return "millisecs";
                case StringId.IncorrectNumberCopies:
                return "تعداد باید بین 1 و 32767.";
                case StringId.ChartRangeControlClientInvalidGrid:
                return "فاصله بین خطوط شبکه بیش از حد کوچک برای کنترل محدوده نماینده است.";
                case StringId.ChartRangeControlClientNoData:
                return "هیچ داده ای برای نمایش در کنترل محدوده وجود دارد.";
                case StringId.DataBarBlue:
                return "آبی اطلاعات نوار";
                case StringId.DataBarLightBlue:
                return "نور آبی نوار اطلاعات";
                case StringId.DataBarGreen:
                return "نوار اطلاعات سبز";
                case StringId.DataBarYellow:
                return "نوار اطلاعات زرد";
                case StringId.DataBarOrange:
                return "نارنجی اطلاعات نوار";
                case StringId.DataBarMint:
                return "نعناع نوار اطلاعات";
                case StringId.DataBarViolet:
                return "نوار اطلاعات بنفش";
                case StringId.DataBarRaspberry:
                return "نوار اطلاعات تمشک";
                case StringId.DataBarCoral:
                return "مرجان نوار اطلاعات";
                case StringId.DataBarBlueGradient:
                return "پیشرفت تدریجی آبی نوار اطلاعات";
                case StringId.DataBarLightBlueGradient:
                return "نور آبی داده نوار پیشرفت تدریجی";
                case StringId.DataBarGreenGradient:
                return "پیشرفت تدریجی سبز نوار اطلاعات";
                case StringId.DataBarYellowGradient:
                return "پیشرفت تدریجی نوار زرد داده";
                case StringId.DataBarOrangeGradient:
                return "پیشرفت تدریجی نوار نارنجی داده";
                case StringId.DataBarMintGradient:
                return "شیب نعناع نوار اطلاعات";
                case StringId.DataBarVioletGradient:
                return "شیب بنفش نوار اطلاعات";
                case StringId.DataBarRaspberryGradient:
                return "شیب تمشک نوار اطلاعات";
                case StringId.DataBarCoralGradient:
                return "شیب مرجان نوار اطلاعات";
                case StringId.FormatRuleMenuItemClearColumnRules:
                return "قوانین روشن از این ستون";
                case StringId.FormatRuleMenuItemClearAllRules:
                return "قوانین روشن از همه ستونها";
                case StringId.FormatRuleMenuItemHighlightCellRules:
                return "قوانین برجسته سلول";
                case StringId.FormatRuleMenuItemTopBottomRules:
                return "قوانین بالا/پایین";
                case StringId.FormatRuleMenuItemDataBars:
                return "میله های داده";
                case StringId.FormatRuleMenuItemColorScales:
                return "تعادل رنگ";
                case StringId.FormatRuleMenuItemIconSets:
                return "مجموعه آیکون";
                case StringId.FormatRuleMenuItemClearRules:
                return "قواعد مشخص";
                case StringId.FormatRuleMenuItemManageRules:
                return "مدیریت قوانین...";
                case StringId.FormatRuleMenuItemUniqueDuplicateRules:
                return "قوانین منحصر به فرد/تکراری";
                case StringId.FormatRuleMenuItemGradientFill:
                return "پر شیب";
                case StringId.FormatRuleMenuItemSolidFill:
                return "جامد را پر کنید"; 
                case StringId.IconSetCategoryRatings:
                return "رتبه بندی";
                case StringId.IconSetCategoryIndicators:
                return "شاخص های";
                case StringId.IconSetCategorySymbols:
                return "نمادها";
                case StringId.IconSetCategoryShapes:
                return "اشکال";
                case StringId.IconSetCategoryDirectional:
                return "جهت";
                case StringId.IconSetCategoryPositiveNegative:
                return "مثبت/منفی";
                case StringId.FormatRuleMenuItemIconSetDescription:
                return "این آیکون تنظیم طبقه بندی ارزش های ستون به محدوده های زیر استفاده کنید:";
                case StringId.ColorScaleGreenYellowRed:
                return "سبز - زرد - قرمز";
                case StringId.ColorScalePurpleWhiteAzure:
                return "بنفش - سفید - لاجورد";
                case StringId.ColorScaleYellowOrangeCoral:
                return "زرد - نارنجی - مرجان";
                case StringId.ColorScaleGreenWhiteRed:
                return "سبز - سفید - قرمز";
                case StringId.ColorScaleEmeraldAzureBlue:
                return "زمرد - لاجورد - آبی";
                case StringId.ColorScaleWhiteRed:
                return "سفید - قرمز";
                case StringId.ColorScaleWhiteGreen:
                return "سفید - سبز";
                case StringId.ColorScaleWhiteAzure:
                return "سفید - لاجوردی";
                case StringId.ColorScaleYellowGreen:
                return "زرد - سبز";
                case StringId.ColorScaleBlueWhiteRed:
                return "آبی - سفید - قرمز";
case StringId.FormatRuleMenuItemUnique:
                return "ارزش های منحصر به فرد";
                case StringId.FormatRuleUniqueText:
                return "شکلبندی سلولها است که ارزش های منحصر به فرد";
                case StringId.FormatRuleMenuItemDuplicate:
                return "تکراری ارزش";
                case StringId.FormatRuleDuplicateText:
                return "شکلبندی سلولها است که ارزش های تکراری";
                case StringId.FormatRuleApplyFormatProperty:
                return "اعمال شکلبندی به همه ردیف";
                case StringId.FormatRuleWith:
                return "با";
                case StringId.FormatRuleForThisColumnWith:
                return "برای این ستون";
                case StringId.IconSetTitleStars3:
                return "3 ستاره";
                case StringId.IconSetTitleRatings4:
                return "4 رأی";
                case StringId.IconSetTitleRatings5:
                return "5 رأی";
                case StringId.IconSetTitleQuarters5:
                return "محله های 5";
                case StringId.IconSetTitleBoxes5:
                return "5 جعبه";
                case StringId.IconSetTitleArrows3Colored:
                return "3 فلش (رنگی)";
                case StringId.IconSetTitleArrows3Gray:
                return "3 فلش (خاکستری)";
                case StringId.IconSetTitleTriangles3:
                return "3 مثلث";
                case StringId.IconSetTitleArrows4Colored:
                return "فلش 4 (رنگی)";
                case StringId.IconSetTitleArrows4Gray:
                return "فلش 4 (خاکستری)";
                case StringId.IconSetTitleArrows5Colored:
                return "5 فلش (رنگی)";
                case StringId.IconSetTitleArrows5Gray:
                return "5 فلش (خاکستری)";
                case StringId.IconSetTitleTrafficLights3Unrimmed:
                return "چراغ های ترافیک 3 (Unrimmed)";
                case StringId.IconSetTitleTrafficLights3Rimmed:
                return "3 چراغ های ترافیک (Rimmed)";
                case StringId.IconSetTitleSigns3:
                return "3 نشانه";
                case StringId.IconSetTitleTrafficLights4:
                return "4 چراغ های ترافیک";
                case StringId.IconSetTitleRedToBlack:
                return "قرمز به سیاه و سفید";
                case StringId.IconSetTitleSymbols3Circled:
                return "3 نماد (دور)";
                case StringId.IconSetTitleSymbols3Uncircled:
                return "3 نماد (Uncircled)";
                case StringId.IconSetTitleFlags3:
                return "پرچم 3";
                case StringId.IconSetTitlePositiveNegativeArrows:
                return "فلش (رنگی)";
                case StringId.IconSetTitlePositiveNegativeArrowsGray:
                return "فلش (خاکستری)";
                case StringId.IconSetTitlePositiveNegativeTriangles:
                return "مثلث";
                case StringId.FormatRuleMenuItemTop10Items:
                return "موارد بالا 10";
                case StringId.FormatRuleMenuItemTop10Percent:
                return "بالا 10%";
                case StringId.FormatRuleMenuItemBottom10Items:
                return "پایین 10 مورد";
                case StringId.FormatRuleMenuItemBottom10Percent:
                return "پایین 10 ٪";
                case StringId.FormatRuleMenuItemAboveAverage:
                return "بالاتر از حد متوسط";
                case StringId.FormatRuleMenuItemBelowAverage:
                return "زیر متوسط";
                case StringId.FormatRuleTopText:
                return "فرمت این رتبه در بالای سلول";
                case StringId.FormatRuleBottomText:
                return "فرمت سلول که رتبه در پایین";
                case StringId.FormatRuleAboveAverageText:
                return "شکلبندی سلولها است که بالاتر از متوسط";
                case StringId.FormatRuleBelowAverageText:
                return "شکلبندی سلولها که زیر متوسط";
                case StringId.FormatRuleMenuItemGreaterThan:
                return "بزرگتر از";
                case StringId.FormatRuleMenuItemLessThan:
                return "کمتر از";
                case StringId.FormatRuleMenuItemBetween:
                return "بین";
                case StringId.FormatRuleMenuItemEqualTo:
                return "برابر با";
                case StringId.FormatRuleMenuItemTextThatContains:
                return "متنی که حاوی";
                case StringId.FormatRuleMenuItemCustomCondition:
                return "بیماری های سفارشی";
                case StringId.FormatRuleGreaterThanText:
                return "شکلبندی سلولها است که بیشتر از";
                case StringId.FormatRuleLessThanText:
                return "شکلبندی سلولها است که کمتر از";
                case StringId.FormatRuleBetweenText:
                return "شکلبندی سلولها است که بین";
                case StringId.FormatRuleEqualToText:
                return "شکلبندی سلولها است که مساوی به";
                case StringId.FormatRuleTextThatContainsText:
                return "شکلبندی سلولها که حاوی متن";
                case StringId.FormatRuleCustomConditionText:
                return "شکلبندی سلولها است که منطبق با شرایط زیر";
                case StringId.FormatRuleMenuItemDateOccurring:
                return "تاریخ وقوع";
                case StringId.FormatRuleDateOccurring:
                return "شکلبندی سلولها که حاوی تاریخ تطبیق این شرایط";
                case StringId.FormatPredefinedAppearanceRedFillRedText:
                return "قرمز پر کردن با متن قرمز";
                case StringId.FormatPredefinedAppearanceYellowFillYellowText:
                return "پر زرد زرد متن";
                case StringId.FormatPredefinedAppearanceGreenFillGreenText:
                return "سبز پر کردن با متن سبز";
                case StringId.FormatPredefinedAppearanceRedFill:
                return "پر سرخ";
                case StringId.FormatPredefinedAppearanceRedText:
                return "متن قرمز";
                case StringId.FormatPredefinedAppearanceGreenFill:
                return "سبز پر";
                case StringId.FormatPredefinedAppearanceGreenText:
                return "متن سبز";
                case StringId.FormatPredefinedAppearanceBoldText:
                return "متن پررنگ";
                case StringId.FormatPredefinedAppearanceItalicText:
                return "متن مورب";
                case StringId.FormatPredefinedAppearanceStrikeoutText:
                return "خط زدن متن";
                case StringId.FormatPredefinedAppearanceRedBoldText:
                return "متن قرمز پررنگ";
                case StringId.FormatPredefinedAppearanceGreenBoldText:
                return "سبز پررنگ متن";
                case StringId.SearchForColumn:
                return "جستجو برای ستون...";
                case StringId.SearchForField:
                return "زمینه جستجو...";
                case StringId.ManageRuleCaption:
                return "مدیر های قوانین قالب بندی شرطی";
                case StringId.ManageRuleShowFormattingRules:
                return "قوانین نشان می دهد:";
                case StringId.ManageRuleUp:
                return "تا";
                case StringId.ManageRuleDown:
                return "پایین";
                case StringId.ManageRuleNewRule:
                return "قانون جدید...";
                case StringId.ManageRuleEditRule:
                return "ویرایش قانون...";
                case StringId.ManageRuleDeleteRule:
                return "حذف قانون";
                case StringId.ManageRuleGridCaptionRule:
                return "قانون";
                case StringId.ManageRuleGridCaptionFormat:
                return "قالب";
                case StringId.ManageRuleGridCaptionApplyToTheRow:
                return "اعمال بر سطر";
                case StringId.ManageRuleGridCaptionColumn:
                return "ستون";
                case StringId.ManageRuleAllColumns:
                return "(تمام)";
                case StringId.NewFormattingRule:
                return "قانون جدید شکلبندی";
                case StringId.EditFormattingRule:
                return "ویرایش قالب بندی";
                case StringId.NewEditFormattingRuleSelectARuleType:
                return "انتخاب نوع حکومت:";
                case StringId.NewEditFormattingRuleEditTheRuleDescription:
                return "ویرایش توضیح قانون:";
                case StringId.NewEditFormattingRuleFormatAllCellsBasedOnTheirValues:
                return "تمام سلول های مبتنی بر ارزش های خود را با فرمت";
                case StringId.NewEditFormattingRuleFormatOnlyCellsThatContain:
                return "سلول حاوی فرمت";
                case StringId.NewEditFormattingRuleFormatOnlyTopOrBottomRankedValues:
                return "رتبه بندی مقادیر قالب تنها بالا یا پایین";
                case StringId.NewEditFormattingRuleFormatOnlyValuesThatAreAboveOrBelowAverage:
                return "ارزش های بالا یا پایین به طور متوسط با فرمت";
                case StringId.NewEditFormattingRuleFormatOnlyUniqueOrDuplicateValues:
                return "فرمت تنها منحصر به فرد و یا تکراری ارزش";
                case StringId.NewEditFormattingRuleUseAFormulaToDetermineWhichCellsToFormat:
                return "با استفاده از فرمول تعیین کدام سلول به فرمت";
                case StringId.ManageRuleComplexRuleBaseFormatStyle:
                return "قالب سبک:";
                case StringId.ManageRuleColorScale2:
                return "مقیاس 2 رنگ";
                case StringId.ManageRuleColorScale3:
                return "3-رنگ مقیاس";
                case StringId.ManageRuleDataBar:
                return "نوار اطلاعات";
                case StringId.ManageRuleIconSets:
                return "مجموعه آیکون";
                case StringId.ManageRuleCommonMinimum:
                return "حداقل";
                case StringId.ManageRuleCommonMaximum:
                return "حداکثر";
                case StringId.ManageRuleCommonType:
                return "نوع:";
                case StringId.ManageRuleCommonPercent:
                return "درصد";
                case StringId.ManageRuleCommonNumber:
                return "شماره";
                case StringId.ManageRuleCommonValue:
                return "ارزش:";
                case StringId.ManageRuleCommonColor:
                return "رنگ:";
                case StringId.ManageRuleCommonPreview:
                return "پیش نمایش:";
                case StringId.ManageRuleNoFormatSet:
                return "بدون تعیین شکلبندی";
                case StringId.ManageRuleColorScaleMidpoint:
                return "نقطه میانی";
                case StringId.ManageRuleDataBarBarAppearance:
                return "ظاهر نوار:";
                case StringId.ManageRuleDataBarFill:
                return "را پر کنید:";
                case StringId.ManageRuleDataBarBorder:
                return "مرز:";
                case StringId.ManageRuleDataBarDrawAxis:
                return "قرعه کشی محور";
                case StringId.ManageRuleDataBarUseNegativeBar:
                return "استفاده از نوار منفی";
                case StringId.ManageRuleDataBarAxisColor:
                return "رنگ محور:";
                case StringId.ManageRuleDataBarBarDirection:
                return "نوار جهت";
                case StringId.ManageRuleDataBarSolidFill:
                return "جامد را پر کنید";
                case StringId.ManageRuleDataBarGradientFill:
                return "پر شیب";
                case StringId.ManageRuleDataBarNoBorder:
                return "بدون کادر";
                case StringId.ManageRuleDataBarSolidBorder:
                return "مرز جامد";
                case StringId.ManageRuleDataBarContext:
                return "چهار چوب";
                case StringId.ManageRuleDataBarLTR:
                return "چپ به راست";
                case StringId.ManageRuleDataBarRTL:
                return "راست به چپ";
                case StringId.ManageRuleIconSetsDisplayEachIconAccordingToTheseRules:
                return "هر یک از آیکون با توجه به این قوانین را نمایش می دهند:";
                case StringId.ManageRuleIconSetsReverseIconOrder:
                return "سفارش های نماد معکوس";
                case StringId.ManageRuleIconSetsWhen:
                return "وقتی";
                case StringId.ManageRuleIconSetsValueIs:
                return "ارزش است";
                case StringId.ManageRuleSimpleRuleBaseFormat:
                return "فرمت...";
                case StringId.ManageRuleAverageFormatValuesThatAre:
                return "ارزش قالب هستند که:";
                case StringId.ManageRuleAverageTheAverageForTheSelectedRange:
                return "متوسط ارزش های ستون";
                case StringId.ManageRuleAverageAbove:
                return "بالا";
                case StringId.ManageRuleAverageBelow:
                return "زیر";
                case StringId.ManageRuleAverageEqualOrAbove:
                return "مساوی یا بالاتر";
                case StringId.ManageRuleAverageEqualOrBelow:
                return "مساوی یا زیر";
                case StringId.ManageRuleFormulaFormatValuesWhereThisFormulaIsTrue:
                return "ارزش های فرمت که در آن این فرمول درست است:";
                case StringId.ManageRuleRankedValuesFormatValuesThatRankInThe:
                return "قالب ارزش این رتبه در:";
                case StringId.ManageRuleRankedValuesOfTheColumnsCellValues:
                return "درصد از ارزش های ستون";
                case StringId.ManageRuleRankedValuesTop:
                return "بالا";
                case StringId.ManageRuleRankedValuesBottom:
                return "پایین";
                case StringId.ManageRuleThatContainFormatOnlyCellsWith:
                return "فقط سلول های با فرمت:";
                case StringId.ManageRuleThatContainCellValue:
                return "مقدار سلول";
                case StringId.ManageRuleThatContainDatesOccurring:
                return "تاریخ وقوع";
                case StringId.ManageRuleThatContainSpecificText:
                return "متن خاص";
                case StringId.ManageRuleThatContainBlanks:
                return "جاهای خالی";
                case StringId.ManageRuleThatContainNoBlanks:
                return "هیچ شاهد";
                case StringId.ManageRuleThatContainErrors:
                return "خطاهای";
                case StringId.ManageRuleThatContainNoErrors:
                return "بدون خطا";
                case StringId.ManageRuleCellValueBetween:
                return "بین";
                case StringId.ManageRuleCellValueNotBetween:
                return "نیست بین";
                case StringId.ManageRuleCellValueEqualTo:
                return "برابر با";
                case StringId.ManageRuleCellValueNotEqualTo:
                return "نامساوی با";
                case StringId.ManageRuleCellValueGreaterThan:
                return "بزرگتر از";
                case StringId.ManageRuleCellValueLessThan:
                return "کمتر از";
                case StringId.ManageRuleCellValueGreaterThanOrEqualTo:
                return "بزرگتر از یا برابر با";
                case StringId.ManageRuleCellValueLessThanOrEqualTo:
                return "کمتر از یا مساوی با";
                case StringId.ManageRuleDatesOccurringBeyond:
                return "پس از ماه در 2 ماه زمان";
                case StringId.ManageRuleDatesOccurringBeyondThisYear:
                return "پس از این سال";
                case StringId.ManageRuleDatesOccurringEarlier:
                return "قبل از ماه 6 ماه پیش";
                case StringId.ManageRuleDatesOccurringEarlierThisMonth:
                return "این ماه قبل از هفته گذشته";
                case StringId.ManageRuleDatesOccurringEarlierThisWeek:
                return "این هفته قبل از دیروز";
                case StringId.ManageRuleDatesOccurringEarlierThisYear:
                return "امسال قبل از این ماه";
                case StringId.ManageRuleDatesOccurringLastWeek:
                return "هفته ی قبل";
                case StringId.ManageRuleDatesOccurringLaterThisMonth:
                return "این ماه فراتر از هفته آینده";
                case StringId.ManageRuleDatesOccurringLaterThisWeek:
                return "جاری از فردا";
                case StringId.ManageRuleDatesOccurringLaterThisYear:
                return "امسال فراتر از این ماه";
                case StringId.ManageRuleDatesOccurringMonthAfter1:
                return "ماه آینده";
                case StringId.ManageRuleDatesOccurringMonthAfter2:
                return "در طول ماه در 2 ماه زمان";
                case StringId.ManageRuleDatesOccurringMonthAgo1:
                return "ماه گذشته";
                case StringId.ManageRuleDatesOccurringMonthAgo2:
                return "در طول ماه 2 هفته پیش";
                case StringId.ManageRuleDatesOccurringMonthAgo3:
                return "در طول ماه 3 هفته پیش";
                case StringId.ManageRuleDatesOccurringMonthAgo4:
                return "در طول ماه 4 هفته پیش";
                case StringId.ManageRuleDatesOccurringMonthAgo5:
                return "در طول ماه 5 ماه پیش";
                case StringId.ManageRuleDatesOccurringMonthAgo6:
                return "در طول ماه 6 ماه پیش";
                case StringId.ManageRuleDatesOccurringNextWeek:
                return "هفته ی بعد";
                case StringId.ManageRuleDatesOccurringPriorThisYear:
                return "قبل از این سال";
                case StringId.ManageRuleDatesOccurringThisMonth:
                return "این ماه";
                case StringId.ManageRuleDatesOccurringThisWeek:
                return "این هفته";
                case StringId.ManageRuleDatesOccurringTomorrow:
                return "فردا";
                case StringId.ManageRuleDatesOccurringToday:
                return "امروز";
                case StringId.ManageRuleDatesOccurringYesterday:
                return "دیروز";
                case StringId.ManageRuleSpecificTextContaining:
                return "شامل";
                case StringId.ManageRuleSpecificTextNotContaining:
                return "شامل نیست";
                case StringId.ManageRuleSpecificTextBeginningWith:
                return "شروع با";
                case StringId.ManageRuleSpecificTextEndingWith:
                return "خاتم";
                case StringId.ManageRuleUniqueOrDuplicateFormatAll:
                return "همه فرمت:";
                case StringId.ManageRuleUniqueOrDuplicateValuesInTheSelectedRange:
                return "ارزش های ستون";
                case StringId.ManageRuleUniqueOrDuplicateUnique:
                return "منحصر به فرد";
                case StringId.ManageRuleUniqueOrDuplicateDuplicate:
                return "تکراری";
                case StringId.ManageRuleColorScale:
                return "مقیاس مدرج رنگ";
                case StringId.ManageRuleIconSet:
                return "مجموعه آیکون";
                case StringId.ManageRuleFormula:
                return "فرمول";
                case StringId.ManageRuleAboveAverage:
                return "بالاتر از حد متوسط";
                case StringId.ManageRuleBelowAverage:
                return "زیر متوسط";
                case StringId.ManageRuleEqualOrAboveAverage:
                return "مساوی و یا بالاتر از حد متوسط";
                case StringId.ManageRuleEqualOrBelowAverage:
                return "مساوی و یا زیر متوسط";
                case StringId.ManageRuleFormatCellsCaption:
                return "شکلبندی سلولها";
                case StringId.ManageRuleFormatCellsFont:
                return "نوع خط";
                case StringId.ManageRuleFormatCellsFill:
                return "پر کردن";
                case StringId.ManageRuleFormatCellsPredefinedAppearance:
                return "ظاهر از پیش تعریف شده";
                case StringId.ManageRuleFormatCellsFontStyle:
                return "سبک نوع خط";
                case StringId.ManageRuleFormatCellsFontColor:
                return "رنگ قلم";
                case StringId.ManageRuleFormatCellsEffects:
                return "عوارض:";
                case StringId.ManageRuleFormatCellsUnderline:
                return "زیر خط";
                case StringId.ManageRuleFormatCellsStrikethrough:
                return "خط زدن";
                case StringId.ManageRuleFormatCellsClear:
                return "روشن";
                case StringId.ManageRuleFormatCellsBackgroundColor:
                return "رنگ پس زمینه:";
                case StringId.ManageRuleFormatCellsNone:
                return "هیچ کدام";
                case StringId.ManageRuleFormatCellsRegular:
                return "منظم";
                case StringId.ManageRuleFormatCellsBold:
                return "توپر";
                case StringId.ManageRuleFormatCellsItalic:
                return "کج";
                case StringId.TakePictureDialogTitle:
                return "گرفتن عکس";
                case StringId.TakePictureMenuItem:
                return "گرفتن عکس از دوربین";
                case StringId.TakePictureDialogCapture:
                return "ضبط";
                case StringId.TakePictureDialogTryAgain:
                return "دوباره امتحان کن";
                case StringId.TakePictureDialogSave:
                return "ذخیره";
                case StringId.CameraSettingsActiveDevice:
                return "دستگاه های فعال:";
                case StringId.CameraSettingsBrightness:
                return "روشنایی:";
                case StringId.CameraSettingsContrast:
                return "کنتراست:";
                case StringId.CameraSettingsDesaturate:
                return "باطل کردن اشباع:";
                case StringId.CameraSettingsDefaults:
                return "تنظیم مجدد به صورت پیش فرض";
                case StringId.CameraSettingsCaption:
                return "تنظیمات دوربین";
                case StringId.CameraSettingsResolution:
                return "وضوح تصویر:";
                case StringId.CameraDeviceNotFound:
                return "کم در بر داشت. اتصال وب کم و یا تنظیمات دستگاه را بررسی کنید.";
                case StringId.CameraDeviceIsBusy:
                return "آیا استفاده از دستگاه، به عنوان آن در حال حاضر در استفاده در دیگر برنامه نمی تواند.";
                case StringId.CameraDesignTimeInfo:
                return "رندر در زمان طراحی غیرفعال شده است.";
                case StringId.OfficeNavigationOptions:
                return "گزینه های ناوبری";

                default:
                return base.GetLocalizedString(id);
            }
        }
    }
    public class ArabicEditorLocalizer : XtraEditors.Controls.Localizer {
        public override string GetLocalizedString(StringId id) {
            switch(id) {
                case StringId.FilterCriteriaToStringFunctionIsThisWeek:
                return "هذا الأسبوع";
                case StringId.IconSetCategoryDirectional:
                return "اتجاهي";
                case StringId.ManageRuleCellValueBetween:
                return "بين";
                case StringId.CaptionError:
                return "خطأ";
                case StringId.ColorPickGreenValidationMsg:
                return "ينبغي أن يكون العنصر الأخضر في مجموعة 0..255";
                case StringId.FilterCriteriaToStringFunctionGetMilliSecond:
                return "الحصول على ميلي ثانية";
                case StringId.FormatPredefinedAppearanceRedBoldText:
                return "أحمر غامق";
                case StringId.FilterEditorTabVisual:
                return "البصرية";
                case StringId.FilterShowAll:
                return "(تحديد الكل)";
                case StringId.InvalidValueText:
                return "قيمة غير صالحة";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisYear:
                return "هذا العام";
                case StringId.ManageRuleCellValueNotBetween:
                return "ليس بين";
                case StringId.IconSetCategoryPositiveNegative:
                return "إيجابية/سلبية";
                case StringId.CheckUnchecked:
                return "غير محدد";
                case StringId.FormatPredefinedAppearanceGreenBoldText:
                return "أخضر غامق";
                case StringId.ColorPickBlueValidationMsg:
                return "ينبغي أن يكون العنصر الأزرق في مجموعة 0..255";
                case StringId.FilterGroupAnd:
                return "و";
                case StringId.CheckChecked:
                return "فحص";
                case StringId.FilterCriteriaToStringFunctionGetSecond:
                return "الحصول على الثانية";
                case StringId.FilterGroupNotOr:
                return "لا أو";
                case StringId.ColorScaleGreenYellowRed:
                return "أحمر-أصفر-أخضر";
                case StringId.CheckIndeterminate:
                return "غير محدد";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisMonth:
                return "هذا الشهر";
                case StringId.SearchForColumn:
                return "البحث عن عمود...";
                case StringId.ManageRuleCellValueEqualTo:
                return "يساوي";
                case StringId.ColorPickOpacityValidationMsg:
                return "ينبغي أن يكون العنصر العتامة في مجموعة 0..255";
                case StringId.FilterGroupNotAnd:
                return "لا و";
                case StringId.FilterCriteriaToStringFunctionGetMinute:
                return "الحصول على دقيقة";
                case StringId.SearchControlNullValuePrompt:
                return "أدخل نص للبحث...";
                case StringId.ColorScalePurpleWhiteAzure:
                return "أرجواني-أبيض-أزور";
                case StringId.FilterGroupOr:
                return "أو";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeLastWeek:
                return "الأسبوع الماضي";
                case StringId.ManageRuleCellValueNotEqualTo:
                return "لا يساوي";
                case StringId.Cancel:
                return "إلغاء الأمر";
                case StringId.SearchForField:
                return "البحث عن حقل...";
                case StringId.ColorPickColorHexValidationMsg:
                return "القيمة الست عشرية غير صالحة";
                case StringId.FilterCriteriaToStringFunctionGetHour:
                return "الحصول على مدار";
                case StringId.FilterClauseAnyOf:
                return "أي من";
                case StringId.FilterClauseContains:
                return "يحتوي على";
                case StringId.DateEditToday:
                return "اليوم";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisWeek:
                return "هذا الأسبوع";
                case StringId.ColorScaleYellowOrangeCoral:
                return "أصفر-أورانج-كورال";
                case StringId.NavigatorFirstButtonHint:
                return "الأولى";
                case StringId.ManageRuleCellValueGreaterThan:
                return "أكبر من";
                case StringId.ColorPickHueValidationMsg:
                return "ينبغي أن يكون العنصر هوي في مجموعة 0..359";
                case StringId.FilterCriteriaToStringFunctionGetDay:
                return "الحصول على يوم";
                case StringId.FilterClauseEndsWith:
                return "ينتهي ب";
                case StringId.ManageRuleCaption:
                return "إدارة قواعد التنسيق الشرطي";
                case StringId.FilterClauseBeginsWith:
                return "يبدأ ب";
                case StringId.DateEditClear:
                return "واضحة";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeYesterday:
                return "أمس";
                case StringId.ManageRuleCellValueLessThan:
                return "أقل";
                case StringId.ColorScaleGreenWhiteRed:
                return "أخضر-أبيض-أحمر";
                case StringId.NavigatorPreviousButtonHint:
                return "السابقة";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeNow:
                return "الآن";
                case StringId.ColorPickSaturationValidationMsg:
                return "ينبغي أن يكون العنصر التشبع في مجموعة 0..100";
                case StringId.FilterCriteriaToStringFunctionGetMonth:
                return "احصل على شهر";
                case StringId.FilterClauseEquals:
                return "يساوي";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeToday:
                return "اليوم";
                case StringId.ManageRuleShowFormattingRules:
                return "إظهار القواعد على:";
                case StringId.FilterClauseBetween:
                return "هو بين";
                case StringId.OK:
                return "موافق";
                case StringId.ManageRuleCellValueGreaterThanOrEqualTo:
                return "أكبر من أو يساوي";
                case StringId.ColorPickBrightValidationMsg:
                return "ينبغي أن يكون مكون السطوع في مجموعة 0..100";
                case StringId.FilterCriteriaToStringFunctionGetYear:
                return "الحصول على سنة";
                case StringId.ColorScaleEmeraldAzureBlue:
                return "الزمرد-أزور--الأزرق";
                case StringId.NavigatorPreviousPageButtonHint:
                return "الصفحة السابقة";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeTomorrow:
                return "غدا";
                case StringId.FilterClauseGreater:
                return "أكبر من";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextWeek:
                return "الأسبوع القادم";
                case StringId.ManageRuleUp:
                return "حتى";
                case StringId.FilterClauseBetweenAnd:
                return "و";
                case StringId.NavigatorNextButtonHint:
                return "القادم";
                case StringId.ManageRuleCellValueLessThanOrEqualTo:
                return "أقل من أو يساوي";
                case StringId.ColorTabWebSafeColors:
                return "ويب أمن";
                case StringId.FilterCriteriaToStringFunctionGetDayOfWeek:
                return "الحصول على يوم من أيام الأسبوع";
                case StringId.ColorScaleWhiteRed:
                return "أبيض-أحمر";
                case StringId.NavigatorTextStringFormat:
                return "السجل {0} {1}";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeDayAfterTomorrow:
                return "بعد غد";
                case StringId.FilterClauseGreaterOrEqual:
                return "أكبر من أو يساوي";
                case StringId.ManageRuleDown:
                return "إلى أسفل";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeTwoWeeksAway:
                return "بعد أسبوعين";
                case StringId.FilterClauseNoneOf:
                return "لا شيء من";
                case StringId.NavigatorNextPageButtonHint:
                return "الصفحة التالية";
                case StringId.ManageRuleDatesOccurringBeyond:
                return "بعد الشهر في غضون أشهر 2";
                case StringId.Days:
                return "أيام";
                case StringId.FilterCriteriaToStringFunctionGetDayOfYear:
                return "الحصول على يوم من أيام السنة";
                case StringId.ColorScaleWhiteGreen:
                return "أبيض-أخضر";
                case StringId.PictureEditMenuCut:
                return "قص";
                case StringId.FilterClauseIsNotNull:
                return "ليست فارغة";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisWeek:
                return "في وقت لاحق من هذا الأسبوع";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextMonth:
                return "الشهر القادم";
                case StringId.ManageRuleDatesOccurringBeyondThisYear:
                return "وفي أعقاب هذا العام";
                case StringId.ManageRuleNewRule:
                return "قاعدة جديدة...";
                case StringId.FilterClauseNotBetween:
                return "ليس بين";
                case StringId.NavigatorLastButtonHint:
                return "آخر";
                case StringId.Hours:
                return "ساعات";
                case StringId.FilterCriteriaToStringFunctionGetTimeOfDay:
                return "الحصول على الوقت من اليوم";
                case StringId.FilterClauseIsNull:
                return "فارغة";
                case StringId.ColorScaleWhiteAzure:
                return "-الأبيض-الأزرق السماوي";
                case StringId.PictureEditMenuCopy:
                return "نسخة";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalTomorrow:
                return "هو غدا";
                case StringId.FilterCriteriaToStringFunctionAddMilliSeconds:
                return "إضافة ميلي ثانية";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextYear:
                return "العام القادم";
                case StringId.ManageRuleDatesOccurringEarlier:
                return "قبل الشهر من 6 أشهر";
                case StringId.ManageRuleEditRule:
                return "قم بتحرير القاعدة...";
                case StringId.FilterClauseDoesNotContain:
                return "لا يحتوي على";
                case StringId.Mins:
                return "دقيقة";
                case StringId.NavigatorAppendButtonHint:
                return "إلحاق";
                case StringId.FilterCriteriaToStringFunctionNow:
                return "الآن";
                case StringId.ColorScaleYellowGreen:
                return "أصفر-أخضر";
                case StringId.PictureEditMenuPaste:
                return "لصق";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalToday:
                return "اليوم";
                case StringId.FilterClauseIsNotNullOrEmpty:
                return "ليس فارغاً";
                case StringId.FilterCriteriaToStringFunctionAddSeconds:
                return "إضافة ثانية";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalBeyondThisYear:
                return "هو أبعد من هذا العام";
                case StringId.IncorrectNumberCopies:
                return "يجب أن يكون العدد بين 1 و 32767.";
                case StringId.ManageRuleDatesOccurringEarlierThisMonth:
                return "هذا الشهر، قبل الأسبوع السابق";
                case StringId.FilterCriteriaToStringFunctionUtcNow:
                return "الآن بالتوقيت العالمي";
                case StringId.NavigatorRemoveButtonHint:
                return "حذف";
                case StringId.ManageRuleDeleteRule:
                return "حذف قاعدة";
                case StringId.FilterClauseDoesNotEqual:
                return "لا يساوي";
                case StringId.FilterClauseIsNullOrEmpty:
                return "فارغة";
                case StringId.FilterCriteriaToStringFunctionAddMinutes:
                return "إضافة دقائق";
                case StringId.ColorScaleBlueWhiteRed:
                return "الأزرق-أبيض-أحمر";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisYear:
                return "في وقت لاحق من هذا العام";
                case StringId.PictureEditMenuDelete:
                return "حذف";
                case StringId.ManageRuleDatesOccurringEarlierThisWeek:
                return "هذا الأسبوع، قبل أمس";
                case StringId.FilterCriteriaToStringFunctionToday:
                return "اليوم";
                case StringId.NavigatorEditButtonHint:
                return "تحرير";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalYesterday:
                return "أمس";
                case StringId.ChartRangeControlClientInvalidGrid:
                return "الفاصل الزمني بين خطوط الشبكة صغير جداً تكون ممثلة في مجموعة عنصر التحكم.";
                case StringId.ManageRuleGridCaptionRule:
                return "القاعدة";
                case StringId.FilterClauseLess:
                return "هو أقل من";
                case StringId.FilterClauseNotLike:
                return "ليس مثل";
                case StringId.FilterCriteriaToStringFunctionAddHours:
                return "إضافة ساعة";
                case StringId.Millisecs:
                return "ميليسيكس";
                case StringId.FormatRuleMenuItemUnique:
                return "قيم فريدة";
                case StringId.PictureEditMenuLoad:
                return "تحميل";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisMonth:
                return "في وقت لاحق من هذا الشهر";
                case StringId.ManageRuleDatesOccurringEarlierThisYear:
                return "هذا العام، وقبل هذا الشهر";
                case StringId.FilterCriteriaToStringFunctionAddTimeSpan:
                return "إضافة فترة زمنية";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisWeek:
                return "وفي وقت سابق من هذا الأسبوع";
                case StringId.NavigatorEndEditButtonHint:
                return "تحرير نهاية";
                case StringId.ChartRangeControlClientNoData:
                return "لا توجد بيانات لتمثيل في عنصر تحكم نطاق.";
                case StringId.ManageRuleGridCaptionFormat:
                return "تنسيق";
                case StringId.FormatRuleMenuItemDuplicate:
                return "القيم المكررة";
                case StringId.FilterClauseLessOrEqual:
                return "أقل من أو يساوي";
                case StringId.FilterCriteriaToStringFunctionAddDays:
                return "إضافة أيام";
                case StringId.DataBarGreen:
                return "شريط بيانات أخضر";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalNextWeek:
                return "الأسبوع المقبل";
                case StringId.FormatRuleApplyFormatProperty:
                return "تطبيق تنسيق صف بأكمله";
                case StringId.ManageRuleDatesOccurringLastWeek:
                return "الأسبوع الماضي";
                case StringId.PictureEditMenuSave:
                return "حفظ";
                case StringId.FilterCriteriaToStringFunctionAddTicks:
                return "إضافة علامات التجزئة";
                case StringId.NavigatorCancelEditButtonHint:
                return "إلغاء التحرير";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLastWeek:
                return "الأسبوع الماضي";
                case StringId.DataBarBlue:
                return "شريط بيانات أزرق";
                case StringId.ManageRuleGridCaptionApplyToTheRow:
                return "تنطبق على الصف";
                case StringId.FilterClauseLike:
                return "مثل";
                case StringId.FilterCriteriaToStringFunctionAddMonths:
                return "إضافة الأشهر";
                case StringId.DataBarYellow:
                return "شريط بيانات الأصفر";
                case StringId.ManageRuleAllColumns:
                return "(الكل)";
                case StringId.FilterCriteriaToStringFunctionConcat:
                return "Concat";
                case StringId.ManageRuleDatesOccurringLaterThisMonth:
                return "هذا الشهر، إلى ما بعد الأسبوع المقبل";
                case StringId.FilterCriteriaToStringFunctionStartsWith:
                return "يبدأ ب";
                case StringId.FormatRuleWith:
                return "مع";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisMonth:
                return "وفي وقت سابق من هذا الشهر";
                case StringId.PictureEditSaveFileFilter:
                return "صورة نقطية (*.bmp) الملفات | *. bmp| تنسيق تبادل الرسومات (*.gif) | *. gif| تنسيق تبادل ملف JPEG (*.jpg) | *. jpg| تنسيق رسومات الشبكة للأجهزة المحمولة (*.png) | *.png";
                case StringId.IconSetTitleTrafficLights3Rimmed:
                return "3 إشارات مرور (انعقدت)";
                case StringId.FilterEmptyValue:
                return "<empty></empty>";
                case StringId.DataBarLightBlue:
                return "الضوء الأزرق شريط البيانات";
                case StringId.ManageRuleGridCaptionColumn:
                return "العمود";
                case StringId.FilterMenuAddNewParameter:
                return "إضافة معلمة...";
                case StringId.FilterCriteriaToStringFunctionAddYears:
                return "إضافة السنوات";
                case StringId.FilterCriteriaToStringFunctionAscii:
                return "آسكي";
                case StringId.DataBarOrange:
                return "شريط بيانات برتقالي";
                case StringId.ManageRuleDatesOccurringLaterThisWeek:
                return "هذا الأسبوع، إلى ما بعد الغد";
                case StringId.NewFormattingRule:
                return "قاعدة تنسيق جديدة";
                case StringId.FormatRuleForThisColumnWith:
                return "لهذا العمود مع";
                case StringId.FilterCriteriaToStringFunctionEndsWith:
                return "ينتهي ب";
                case StringId.PictureEditOpenFileTitle:
                return "فتح";
                case StringId.IconSetTitleSigns3:
                return "3 علامات";
                case StringId.ColorTabWeb:
                return "ويب";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisYear:
                return "وفي وقت سابق من هذا العام";
                case StringId.FilterMenuConditionAdd:
                return "إضافة شرط";
                case StringId.ProgressExport:
                return "تصدير";
                case StringId.FormatRuleMenuItemClearColumnRules:
                return "مسح القواعد من هذا العمود";
                case StringId.FilterCriteriaToStringFunctionChar:
                return "شار";
                case StringId.NewEditFormattingRuleSelectARuleType:
                return "حدد نوع قاعدة:";
                case StringId.FilterCriteriaToStringUnaryOperatorIsNull:
                return "فارغة";
                case StringId.DataBarMint:
                return "شريط بيانات النعناع";
                case StringId.ManageRuleDatesOccurringLaterThisYear:
                return "هذا العام، وبعد هذا الشهر";
                case StringId.FilterCriteriaToStringFunctionContains:
                return "يحتوي على";
                case StringId.PictureEditSaveFileTitle:
                return "حفظ باسم";
                case StringId.EditFormattingRule:
                return "تحرير قاعدة التنسيق";
                case StringId.IconSetTitleStars3:
                return "نجوم 3";
                case StringId.ColorTabSystem:
                return "نظام";
                case StringId.IconSetTitleTrafficLights4:
                return "4 إشارات المرور";
                case StringId.FilterMenuGroupAdd:
                return "إضافة مجموعة";
                case StringId.ProgressPrinting:
                return "الطباعة";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalPriorThisYear:
                return "قبل هذا العام";
                case StringId.FilterCriteriaToStringFunctionToInt:
                return "إلى int";
                case StringId.ManageRuleDatesOccurringToday:
                return "اليوم";
                case StringId.ManageRuleDatesOccurringMonthAfter1:
                return "الشهر القادم";
                case StringId.FormatRuleMenuItemClearAllRules:
                return "قواعد واضحة من كافة الأعمدة";
                case StringId.NewEditFormattingRuleEditTheRuleDescription:
                return "تحرير وصف القاعدة:";
                case StringId.FilterCriteriaToStringUnaryOperatorMinus:
                return "-";
                case StringId.FilterCriteriaInvalidExpression:
                return "التعبير المحدد يحتوي على رموز غير صالح (خط {0}، حرف {1}).";
                case StringId.DataBarViolet:
                return "شريط بيانات الأشعة فوق البنفسجية";
                case StringId.ManageRuleCommonPercent:
                return "في المائة";
                case StringId.PictureEditOpenFileError:
                return "تنسيق صورة خاطئة";
                case StringId.IconSetTitleRedToBlack:
                return "الأحمر إلى الأسود";
                case StringId.IconSetTitleRatings4:
                return "تصنيفات 4";
                case StringId.CalcButtonMC:
                return "مولودية";
                case StringId.FilterMenuClearAll:
                return "مسح الكل";
                case StringId.FilterCriteriaToStringFunctionCustom:
                return "مخصص";
                case StringId.ProgressCreateDocument:
                return "إنشاء المستند";
                case StringId.FilterCriteriaToStringFunctionToLong:
                return "لفترة طويلة";
                case StringId.FormatRuleMenuItemHighlightCellRules:
                return "قواعد تمييز الخلايا";
                case StringId.ManageRuleDatesOccurringYesterday:
                return "أمس";
                case StringId.NewEditFormattingRuleFormatAllCellsBasedOnTheirValues:
                return "تنسيق كافة الخلايا استناداً إلى قيمها";
                case StringId.FilterCriteriaToStringUnaryOperatorNot:
                return "لا";
                case StringId.ManageRuleDatesOccurringMonthAfter2:
                return "وخلال هذا الشهر في غضون أشهر 2";
                case StringId.FilterCriteriaInvalidExpressionEx:
                return "التعبير المحدد غير صالح.";
                case StringId.DataBarRaspberry:
                return "شريط بيانات التوت";
                case StringId.ManageRuleCommonNumber:
                return "عدد";
                case StringId.IconSetTitleRatings5:
                return "تصنيفات 5";
                case StringId.PictureEditOpenFileErrorCaption:
                return "خطأ في فتح";
                case StringId.IconSetTitleSymbols3Circled:
                return "3 رموز (دائري)";
                case StringId.FilterCriteriaToStringFunctionCustomNonDeterministic:
                return "مخصص غير قطعية";
                case StringId.CalcButtonMR:
                return "السيد";
                case StringId.ProgressCancel:
                return "إلغاء الأمر";
                case StringId.FilterMenuRowRemove:
                return "إزالة مجموعة";
                case StringId.FormatRuleMenuItemTopBottomRules:
                return "القواعد العليا/السفلي";
                case StringId.FilterCriteriaToStringFunctionToFloat:
                return "لتعويم";
                case StringId.ManageRuleSpecificTextContaining:
                return "يحتوي على";
                case StringId.ManageRuleDatesOccurringMonthAgo1:
                return "الشهر الماضي";
                case StringId.NewEditFormattingRuleFormatOnlyCellsThatContain:
                return "تنسيق الخلايا التي تحتوي على فقط";
                case StringId.FilterCriteriaToStringUnaryOperatorPlus:
                return "+";
                case StringId.TabHeaderButtonPin:
                return "رقم التعريف الشخصي";
                case StringId.Apply:
                return "تطبيق";
                case StringId.PictureEditCopyImageError:
                return "تعذر نسخ الصورة";
                case StringId.IconSetTitleSymbols3Uncircled:
                return "3 رموز (أونسيركليد)";
                case StringId.DataBarCoral:
                return "شريط بيانات الشعاب";
                case StringId.ManageRuleCommonValue:
                return "القيمة:";
                case StringId.IconSetTitleQuarters5:
                return "5 أرباع";
                case StringId.FilterCriteriaToStringFunctionIsNullOrEmpty:
                return "غير صحيح أو فارغ";
                case StringId.ProgressCancelPending:
                return "إلغاء تعليق";
                case StringId.FilterCriteriaToStringFunctionToDouble:
                return "أن يتضاعف";
                case StringId.CalcButtonMS:
                return "مرض التصلب العصبي المتعدد";
                case StringId.FilterToolTipNodeAdd:
                return "إضافة شرط جديد لهذه المجموعة";
                case StringId.FormatRuleMenuItemDataBars:
                return "أشرطة البيانات";
                case StringId.ManageRuleSpecificTextNotContaining:
                return "لا تحتوي على";
                case StringId.ManageRuleDatesOccurringMonthAgo2:
                return "خلال شهر قبل 2 أشهر";
                case StringId.PreviewPanelText:
                return "معاينة:";
                case StringId.NewEditFormattingRuleFormatOnlyTopOrBottomRankedValues:
                return "تنسيق فقط أعلى أو أسفل ترتيب القيم";
                case StringId.FilterCriteriaToStringBinaryOperatorBitwiseAnd:
                return "&";
                case StringId.LookUpEditValueIsNull:
                return "[اديتفالوي فارغ]";
                case StringId.IconSetTitleFlags3:
                return "3 إشارات";
                case StringId.FilterCriteriaToStringFunctionCos:
                return "كوس";
                case StringId.TabHeaderButtonUnpin:
                return "إلغاء التثبيت";
                case StringId.ProgressLoadingData:
                return "تحميل البيانات";
                case StringId.FilterCriteriaToStringFunctionToDecimal:
                return "إلى رقم عشري.";
                case StringId.DataBarBlueGradient:
                return "شريط بيانات أزرق التدرج";
                case StringId.ManageRuleCommonColor:
                return "اللون:";
                case StringId.ManageRuleSpecificTextBeginningWith:
                return "بداية مع";
                case StringId.IconSetTitleBoxes5:
                return "5 مربعات";
                case StringId.CalcButtonMx:
                return "M +";
                case StringId.ManageRuleDatesOccurringMonthAgo3:
                return "خلال شهر قبل 3 أشهر";
                case StringId.FilterToolTipNodeRemove:
                return "يزيل هذا الشرط";
                case StringId.FormatRuleMenuItemColorScales:
                return "تدرجات الألوان";
                case StringId.TransparentBackColorNotSupported:
                return "لا يدعم عنصر التحكم هذا ألوان خلفية شفافة";
                case StringId.LookUpInvalidEditValueType:
                return "نوع اديتفالوي لوكوبيديت غير صالح.";
                case StringId.IconSetTitlePositiveNegativeArrows:
                return "سهام (ملونة)";
                case StringId.FilterCriteriaToStringFunctionSin:
                return "الخطيئة";
                case StringId.FilterAggregateAvg:
                return "متوسط";
                case StringId.NewEditFormattingRuleFormatOnlyValuesThatAreAboveOrBelowAverage:
                return "تنسيق القيم التي تقع فوق المتوسط أو تحته";
                case StringId.FilterCriteriaToStringBinaryOperatorBitwiseOr:
                return "|";
                case StringId.TabHeaderSelectorButton:
                return "إظهار قائمة النافذة";
                case StringId.FilterCriteriaToStringFunctionToStr:
                return "للإبلاغ عن المعاملات المشبوهة";
                case StringId.ManageRuleSpecificTextEndingWith:
                return "تنتهي مع";
                case StringId.ManageRuleDatesOccurringMonthAgo4:
                return "وخلال شهر منذ 4 أشهر";
                case StringId.DataBarLightBlueGradient:
                return "الضوء الأزرق البيانات شريط التدرج";
                case StringId.ManageRuleCommonPreview:
                return "معاينة:";
                case StringId.IconSetTitleArrows3Colored:
                return "3 أسهم (ملونة)";
                case StringId.FilterOutlookDateText:
                return "إظهار all| إظهار Empty| تصفية حسب تاريخ: |Beyond محددة هذا year| وبعد هذا year| وبعد هذا month| Week| القادم وبعد هذا week| Tomorrow| Today| Yesterday| وفي وقت سابق هذا week| Week| الماضي وفي وقت سابق هذا month| وفي وقت سابق هذا year| قبل هذا العام";
                case StringId.LookUpColumnDefaultName:
                return "الاسم";
                case StringId.IconSetTitlePositiveNegativeArrowsGray:
                return "سهام (رمادي)";
                case StringId.CalcButtonSqrt:
                return "والجذر التربيعي";
                case StringId.FilterToolTipNodeAction:
                return "الإجراءات";
                case StringId.FormatRuleMenuItemIconSets:
                return "مجموعات الرموز";
                case StringId.FilterCriteriaToStringFunctionAtn:
                return "Atn";
                case StringId.FilterAggregateCount:
                return "العد";
                case StringId.FilterCriteriaToStringBinaryOperatorMultiply:
                return "*";
                case StringId.NewEditFormattingRuleFormatOnlyUniqueOrDuplicateValues:
                return "تنسيق القيم الفريدة أو المتكررة فقط";
                case StringId.FilterCriteriaToStringBinaryOperatorBitwiseXor:
                return "^";
                case StringId.FilterCriteriaToStringFunctionReplace:
                return "استبدال";
                case StringId.XtraMessageBoxOkButtonText:
                return "آند موافق";
                case StringId.ManageRuleUniqueOrDuplicateFormatAll:
                return "تنسيق كافة:";
                case StringId.ManageRuleDatesOccurringMonthAgo5:
                return "وخلال هذا الشهر قبل 5 أشهر";
                case StringId.DataBarGreenGradient:
                return "التدرج الأخضر شريط البيانات";
                case StringId.FilterDateTimeConstantMenuCaption:
                return "ثوابت التاريخ والوقت";
                case StringId.ManageRuleNoFormatSet:
                return "لم يتم تعيين تنسيق";
                case StringId.UnknownPictureFormat:
                return "تنسيق الصورة غير معروف";
                case StringId.IconSetTitleArrows3Gray:
                return "3 أسهم (رمادي)";
                case StringId.IconSetTitlePositiveNegativeTriangles:
                return "مثلثات";
                case StringId.CalcButtonBack:
                return "مرة أخرى";
                case StringId.FilterCriteriaToStringFunctionExp:
                return "أكسب";
                case StringId.FilterAggregateExists:
                return "موجود";
                case StringId.FilterCriteriaToStringBinaryOperatorNotEqual:
                return "<>";
                case StringId.FilterToolTipValueType:
                return "مقارنة مع قيمة أخرى قيمة الحقل";
                case StringId.FormatRuleMenuItemClearRules:
                return "قواعد واضحة";
                case StringId.FilterCriteriaToStringFunctionReverse:
                return "عكس";
                case StringId.ManageRuleUniqueOrDuplicateValuesInTheSelectedRange:
                return "قيم العمود";
                case StringId.ManageRuleDatesOccurringMonthAgo6:
                return "وخلال هذا الشهر قبل 6 أشهر";
                case StringId.NewEditFormattingRuleUseAFormulaToDetermineWhichCellsToFormat:
                return "استخدام صيغة لتحديد الخلايا التي سيتم تنسيقها";
                case StringId.FilterCriteriaToStringBinaryOperatorDivide:
                return "/";
                case StringId.XtraMessageBoxCancelButtonText:
                return "آند إلغاء الأمر";
                case StringId.FilterDateTimeOperatorMenuCaption:
                return "عوامل التاريخ والوقت";
                case StringId.DataEmpty:
                return "لا توجد بيانات الصورة";
                case StringId.FormatRuleMenuItemTop10Items:
                return "أحدث 10 عناصر";
                case StringId.DataBarYellowGradient:
                return "تدرج اللون الأصفر شريط البيانات";
                case StringId.ManageRuleColorScaleMidpoint:
                return "نقطة الوسط";
                case StringId.IconSetTitleTriangles3:
                return "3 مثلثات";
                case StringId.FilterCriteriaToStringFunctionLog:
                return "سجل";
                case StringId.FilterAggregateMax:
                return "ماكس";
                case StringId.FilterCriteriaToStringBinaryOperatorPlus:
                return "+";
                case StringId.CalcButtonCE:
                return "CE";
                case StringId.FilterToolTipElementAdd:
                return "إضافة عنصر جديد إلى القائمة";
                case StringId.FilterCriteriaToStringFunctionAtn2:
                return "Atn2";
                case StringId.FilterCriteriaToStringFunctionInsert:
                return "إدراج";
                case StringId.ManageRuleUniqueOrDuplicateUnique:
                return "فريدة من نوعها";
                case StringId.ManageRuleDatesOccurringNextWeek:
                return "الأسبوع القادم";
                case StringId.FormatRuleMenuItemManageRules:
                return "إدارة القواعد...";
                case StringId.ManageRuleComplexRuleBaseFormatStyle:
                return "نمط التنسيق:";
                case StringId.FilterCriteriaToStringBinaryOperatorEqual:
                return "=";
                case StringId.FilterDateTextAlt:
                return "إظهار all| إظهار Empty| تصفية بواسطة محددة تاريخ: |Beyond||| Week| القادم Today| هذا week| هذا month| Earlier| {0:yyyy}، {0: ش ش ش ش}";
                case StringId.NotValidArrayLength:
                return "طول الصفيف غير صالحة.";
                case StringId.FormatRuleMenuItemTop10Percent:
                return "أعلى 10 ٪";
                case StringId.XtraMessageBoxYesButtonText:
                return "آند نعم";
                case StringId.DataBarOrangeGradient:
                return "شريط بيانات أورانج التدرج";
                case StringId.ManageRuleDataBarBarAppearance:
                return "شريط مظهر:";
                case StringId.FilterCriteriaToStringFunctionRnd:
                return "التجمع الوطني الديمقراطي";
                case StringId.FilterAggregateMin:
                return "دقيقة";
                case StringId.FilterCriteriaToStringBetween:
                return "بين";
                case StringId.IconSetTitleArrows4Colored:
                return "4 أسهم (ملونة)";
                case StringId.CalcButtonC:
                return "ج";
                case StringId.FilterCriteriaToStringFunctionCharIndex:
                return "فهرس شار";
                case StringId.ManageRuleUniqueOrDuplicateDuplicate:
                return "مكرر";
                case StringId.ManageRuleDatesOccurringPriorThisYear:
                return "قبل هذا العام";
                case StringId.FilterToolTipKeysAdd:
                return "(استخدام الإدراج أو إضافة مفتاح)";
                case StringId.FilterCriteriaToStringFunctionBigMul:
                return "مول كبير";
                case StringId.FilterFunctionsMenuCaption:
                return "الوظائف";
                case StringId.ImagePopupEmpty:
                return "(فارغ)";
                case StringId.FormatRuleMenuItemUniqueDuplicateRules:
                return "قواعد مكررة/فريدة من نوعها";
                case StringId.ManageRuleColorScale2:
                return "الجدول 2-اللون";
                case StringId.FormatRuleMenuItemBottom10Items:
                return "العناصر الموجودة أسفل 10";
                case StringId.FilterCriteriaToStringFunctionTan:
                return "تان";
                case StringId.FilterCriteriaToStringBinaryOperatorGreater:
                return ">";
                case StringId.FilterAggregateSum:
                return "مجموع";
                case StringId.FilterCriteriaToStringIn:
                return "في";
                case StringId.XtraMessageBoxNoButtonText:
                return "آند لا";
                case StringId.DataBarMintGradient:
                return "شريط بيانات منت التدرج";
                case StringId.FilterCriteriaToStringFunctionRemove:
                return "إزالة";
                case StringId.ManageRuleColorScale:
                return "مقياس متدرج الألوان";
                case StringId.ManageRuleDatesOccurringThisMonth:
                return "هذا الشهر";
                case StringId.ManageRuleDataBarFill:
                return "التعبئة:";
                case StringId.IconSetTitleArrows4Gray:
                return "4 أسهم (رمادي)";
                case StringId.CalcError:
                return "خطأ في الحساب";
                case StringId.DefaultBooleanTrue:
                return "صحيح";
                case StringId.ImagePopupPicture:
                return "(صورة)";
                case StringId.FormatRuleMenuItemBottom10Percent:
                return "أسفل 10%";
                case StringId.FilterToolTipKeysRemove:
                return "(استخدم الحذف أو طرح المفتاح)";
                case StringId.FilterCriteriaToStringFunctionCosh:
                return "كوش";
                case StringId.FormatRuleMenuItemGradientFill:
                return "تعبئة متدرجة";
                case StringId.FilterPopupToolbarShowOnlyAvailableItems:
                return "تظهر فقط العناصر المتوفرة";
                case StringId.FilterCriteriaToStringFunctionPower:
                return "الطاقة";
                case StringId.FieldListName:
                return "قائمة الحقول ({0})";
                case StringId.ManageRuleColorScale3:
                return "تدرج ألوان ثلاثي";
                case StringId.FilterCriteriaToStringBinaryOperatorGreaterOrEqual:
                return ">=";
                case StringId.XtraMessageBoxAbortButtonText:
                return "آند إحباط";
                case StringId.FilterCriteriaToStringIsNotNull:
                return "ليست فارغة";
                case StringId.FilterCriteriaToStringFunctionAbs:
                return "القيمة المطلقة";
                case StringId.ManageRuleIconSet:
                return "رمز المجموعة";
                case StringId.DataBarVioletGradient:
                return "التدرج البنفسجي شريط البيانات";
                case StringId.ManageRuleDataBarBorder:
                return "الحدود:";
                case StringId.IconSetTitleArrows5Colored:
                return "5 أسهم (ملونة)";
                case StringId.ManageRuleDatesOccurringThisWeek:
                return "هذا الأسبوع";
                case StringId.DefaultBooleanFalse:
                return "كاذبة";
                case StringId.ColorTabCustom:
                return "مخصص";
                case StringId.TabHeaderButtonPrev:
                return "قم بالتمرير لليسار";
                case StringId.ContainerAccessibleEditName:
                return "تحرير عنصر التحكم";
                case StringId.FilterCriteriaToStringFunctionLog10:
                return "Log10";
                case StringId.FormatRuleMenuItemAboveAverage:
                return "فوق المتوسط";
                case StringId.FilterPopupToolbarShowNewValues:
                return "إظهار قيم حقل جديد";
                case StringId.FilterCriteriaToStringFunctionSign:
                return "تسجيل الدخول";
                case StringId.FormatRuleMenuItemSolidFill:
                return "تعبئة خالصة";
                case StringId.ManageRuleDataBar:
                return "شريط البيانات";
                case StringId.FilterCriteriaToStringBinaryOperatorLess:
                return "<";
                case StringId.XtraMessageBoxRetryButtonText:
                return "آند إعادة المحاولة";
                case StringId.DataBarRaspberryGradient:
                return "شريط بيانات التوت التدرج";
                case StringId.RestoreLayoutDialogFileFilter:
                return "ملفات XML (*.xml) | *. xml| جميع files| *. *";
                case StringId.ManageRuleDataBarDrawAxis:
                return "رسم المحور";
                case StringId.FilterCriteriaToStringNotLike:
                return "ليس مثل";
                case StringId.FilterCriteriaToStringFunctionSqr:
                return "Sqr";
                case StringId.IconSetTitleArrows5Gray:
                return "5 أسهم (رمادي)";
                case StringId.ManageRuleFormula:
                return "الصيغة";
                case StringId.IconSetCategoryShapes:
                return "الأشكال";
                case StringId.ManageRuleDatesOccurringTomorrow:
                return "غدا";
                case StringId.DefaultBooleanDefault:
                return "افتراضي";
                case StringId.TextEditMenuSelectAll:
                return "حدد كل &";
                case StringId.TabHeaderButtonNext:
                return "قم بالتمرير لليمين";
                case StringId.FilterCriteriaToStringGroupOperatorAnd:
                return "و";
                case StringId.FormatRuleMenuItemBelowAverage:
                return "أقل من المتوسط";
                case StringId.FilterPopupToolbarIncrementalSearch:
                return "البحث التزايدي";
                case StringId.FilterCriteriaToStringFunctionRound:
                return "الجولة";
                case StringId.IconSetCategoryRatings:
                return "تصنيفات";
                case StringId.ManageRuleIconSets:
                return "مجموعات الرموز";
                case StringId.FilterCriteriaToStringBinaryOperatorLessOrEqual:
                return "<=";
                case StringId.SaveLayoutDialogFileFilter:
                return "ملفات XML (*.xml) | *.xml";
                case StringId.FilterCriteriaToStringFunctionIif:
                return "Iif";
                case StringId.FilterCriteriaToStringFunctionPadRight:
                return "لوحة الحق";
                case StringId.XtraMessageBoxIgnoreButtonText:
                return "آند تجاهل";
                case StringId.ManageRuleAboveAverage:
                return "فوق المتوسط";
                case StringId.DataBarCoralGradient:
                return "شريط بيانات الشعاب التدرج";
                case StringId.ManageRuleEqualOrAboveAverage:
                return "تساوي أو تفوق المتوسط";
                case StringId.ManageRuleDataBarUseNegativeBar:
                return "استخدام شريط سالب";
                case StringId.FilterPopupToolbarMultiSelection:
                return "اختيار متعدد";
                case StringId.IconSetTitleTrafficLights3Unrimmed:
                return "3 إشارات مرور (أونريميد)";
                case StringId.FilterEditorTabText:
                return "نص";
                case StringId.FilterCriteriaToStringFunctionTanh:
                return "تانه";
                case StringId.FormatRuleBetweenText:
                return "تنسيق الخلايا التي تكون بين";
                case StringId.FormatRuleTextThatContainsText:
                return "تنسيق الخلايا التي تحتوي على نص";
                case StringId.FilterCriteriaToStringFunctionCeiling:
                return "الحد الأقصى";
                case StringId.RestoreLayoutDialogTitle:
                return "استعادة التخطيط";
                case StringId.TabHeaderButtonUp:
                return "التمرير لأعلى";
                case StringId.FilterCriteriaToStringGroupOperatorOr:
                return "أو";
                case StringId.FormatRuleTopText:
                return "تنسيق الخلايا التي يأتي ترتيبها في الأعلى";
                case StringId.FilterCriteriaToStringFunctionIsNull:
                return "IsNull";
                case StringId.FilterCriteriaToStringFunctionDateDiffTick:
                return "تاريخ التجزئة مهرجان دبي السينمائي الدولي";
                case StringId.ManageRuleBelowAverage:
                return "أقل من المتوسط";
                case StringId.IconSetCategoryIndicators:
                return "المؤشرات";
                case StringId.ManageRuleCommonMinimum:
                return "الحد الأدنى";
                case StringId.FilterCriteriaToStringBinaryOperatorLike:
                return "مثل";
                case StringId.ManageRuleEqualOrBelowAverage:
                return "يساوي أو أقل من المتوسط";
                case StringId.FilterPopupToolbarRadioMode:
                return "وضع الإذاعة";
                case StringId.TextEditMenuUndo:
                return "آند التراجع عن";
                case StringId.FilterCriteriaToStringFunctionIsThisYear:
                return "هذا العام";
                case StringId.FormatRuleDateOccurring:
                return "تنسيق الخلايا التي تحتوي على تاريخ مطابقة هذه الشروط";
                case StringId.ManageRuleDataBarAxisColor:
                return "لون المحور:";
                case StringId.FilterCriteriaToStringFunctionPadLeft:
                return "لوحة اليسار";
                case StringId.ManageRuleAverageAbove:
                return "أعلاه";
                case StringId.FormatRuleCustomConditionText:
                return "تنسيق الخلايا التي تتطابق مع الشرط التالي";
                case StringId.FilterCriteriaToStringFunctionFloor:
                return "الكلمة";
                case StringId.SaveLayoutDialogTitle:
                return "حفظ التخطيط";
                case StringId.FilterCriteriaToStringFunctionLen:
                return "ليون";
                case StringId.FilterCriteriaToStringFunctionDateDiffSecond:
                return "تاريخ المهرجان الثاني";
                case StringId.TabHeaderButtonDown:
                return "قم بالتمرير لأسفل";
                case StringId.FilterCriteriaToStringUnaryOperatorBitwiseNot:
                return "~";
                case StringId.ManageRuleFormatCellsItalic:
                return "مائل";
                case StringId.ManageRuleFormatCellsCaption:
                return "تنسيق خلايا";
                case StringId.FormatRuleBottomText:
                return "تنسيق الخلايا التي يأتي ترتيبها في الجزء السفلي";
                case StringId.FilterPopupToolbarInvertFilter:
                return "عكس عامل التصفية";
                case StringId.IconSetCategorySymbols:
                return "رموز";
                case StringId.ManageRuleCommonMaximum:
                return "الحد الأقصى";
                case StringId.FilterCriteriaToStringFunctionIsThisMonth:
                return "يتم هذا الشهر";
                case StringId.ManageRuleThatContainNoErrors:
                return "لا توجد أخطاء";
                case StringId.FilterCriteriaToStringBinaryOperatorMinus:
                return "-";
                case StringId.TextEditMenuCut:
                return "كو آند تي";
                case StringId.FilterCriteriaToStringFunctionMax:
                return "ماكس";
                case StringId.FormatPredefinedAppearanceRedFillRedText:
                return "تعبئة بالأحمر مع نص أحمر";
                case StringId.PictureEditMenuZoom:
                return "التكبير/التصغير";
                case StringId.FilterCriteriaToStringFunctionLower:
                return "الدنيا";
                case StringId.ManageRuleDataBarBarDirection:
                return "شريط التوجيه";
                case StringId.ManageRuleAverageBelow:
                return "أدناه";
                case StringId.OfficeNavigationOptions:
                return "خيارات التنقل";
                case StringId.FilterCriteriaToStringFunctionDateDiffMilliSecond:
                return "تاريخ المهرجان ميلي ثانية";
                case StringId.TakePictureDialogTitle:
                return "التقاط صورة";
                case StringId.ManageRuleFormatCellsFont:
                return "الخط";
                case StringId.TabHeaderButtonClose:
                return "قم بإغلاق";
                case StringId.ColorPickPopupAutomaticItemCaption:
                return "تلقائي";
                case StringId.FormatRuleMenuItemDateOccurring:
                return "تاريخ متكرر";
                case StringId.FilterCriteriaToStringFunctionMin:
                return "دقيقة";
                case StringId.ManageRuleCommonType:
                return "النوع:";
                case StringId.FilterCriteriaToStringBinaryOperatorModulo:
                return "%";
                case StringId.PictureEditMenuFullSize:
                return "الحجم الكامل";
                case StringId.FilterCriteriaToStringFunctionNone:
                return "لا شيء";
                case StringId.TextEditMenuCopy:
                return "آند نسخة";
                case StringId.FilterCriteriaToStringFunctionDateDiffMinute:
                return "تاريخ المهرجان دقيقة";
                case StringId.FormatPredefinedAppearanceYellowFillYellowText:
                return "تعبئة بالأصفر مع نص أصفر";
                case StringId.ManageRuleDataBarSolidFill:
                return "تعبئة خالصة";
                case StringId.TakePictureMenuItem:
                return "التقاط صورة من الكاميرا";
                case StringId.ManageRuleFormatCellsFill:
                return "التعبئة";
                case StringId.ManageRuleAverageEqualOrAbove:
                return "مساوية أو أعلى";
                case StringId.FilterCriteriaToStringFunctionAcos:
                return "Acos";
                case StringId.ColorPickPopupThemeColorsGroupCaption:
                return "ألوان السمة";
                case StringId.PictureEditMenuFitImage:
                return "ملاءمة الصورة";
                case StringId.TextEditMenuPaste:
                return "آند لصق";
                case StringId.FilterCriteriaToStringFunctionSubstring:
                return "سلسلة فرعية";
                case StringId.FilterCriteriaToStringFunctionDateDiffHour:
                return "تاريخ فرق ساعة";
                case StringId.FormatPredefinedAppearanceGreenFillGreenText:
                return "تعبئة بالأخضر مع نص أخضر";
                case StringId.ManageRuleDataBarGradientFill:
                return "تعبئة متدرجة";
                case StringId.TakePictureDialogCapture:
                return "التقاط";
                case StringId.ManageRuleFormatCellsPredefinedAppearance:
                return "ظهور معرف مسبقاً";
                case StringId.ManageRuleAverageEqualOrBelow:
                return "مساوية أو أقل";
                case StringId.FilterCriteriaToStringFunctionAsin:
                return "اسين";
                case StringId.ColorPickPopupStandardColorsGroupCaption:
                return "الألوان القياسية";
                case StringId.PictureEditMenuZoomIn:
                return "تكبير";
                case StringId.FormatRuleMenuItemGreaterThan:
                return "أكبر من";
                case StringId.FilterCriteriaToStringFunctionTrim:
                return "تقليم";
                case StringId.TextEditMenuDelete:
                return "آند حذف";
                case StringId.FilterCriteriaToStringFunctionDateDiffDay:
                return "تاريخ مهرجان دبي السينمائي الدولي اليوم";
                case StringId.FormatPredefinedAppearanceRedFill:
                return "تعبئة بالأحمر";
                case StringId.TakePictureDialogTryAgain:
                return "حاول مرة أخرى";
                case StringId.ManageRuleDataBarNoBorder:
                return "لا يوجد حد";
                case StringId.ManageRuleFormatCellsFontStyle:
                return "نمط الخط";
                case StringId.FormatRuleMenuItemLessThan:
                return "أقل";
                case StringId.ManageRuleFormulaFormatValuesWhereThisFormulaIsTrue:
                return "تنسيق القيم عندما تكون هذه الصيغة الحقيقية:";
                case StringId.ColorPickPopupRecentColorsGroupCaption:
                return "الألوان الأخيرة";
                case StringId.FilterCriteriaToStringFunctionUpper:
                return "العليا";
                case StringId.PictureEditMenuZoomOut:
                return "التصغير";
                case StringId.FilterCriteriaToStringFunctionDateDiffMonth:
                return "تاريخ المهرجان الشهر";
                case StringId.TakePictureDialogSave:
                return "حفظ";
                case StringId.FormatPredefinedAppearanceRedText:
                return "نص أحمر";
                case StringId.ManageRuleDataBarSolidBorder:
                return "الحدود الصلبة";
                case StringId.ManageRuleFormatCellsFontColor:
                return "لون الخط";
                case StringId.FormatRuleMenuItemBetween:
                return "بين";
                case StringId.FilterCriteriaToStringFunctionDateDiffYear:
                return "تاريخ المهرجان السنة";
                case StringId.ManageRuleRankedValuesFormatValuesThatRankInThe:
                return "تنسيق القيم التي يأتي ترتيبها في:";
                case StringId.ColorPickPopupMoreColorsItemCaption:
                return "مزيد من الألوان...";
                case StringId.CameraSettingsActiveDevice:
                return "جهاز النشط:";
                case StringId.ManageRuleFormatCellsEffects:
                return "التأثيرات:";
                case StringId.FormatRuleMenuItemEqualTo:
                return "يساوي";
                case StringId.PictureEditMenuZoomTo:
                return "تكبير إلى:";
                case StringId.FormatPredefinedAppearanceGreenFill:
                return "تعبئة بالأخضر";
                case StringId.ManageRuleDataBarContext:
                return "السياق";
                case StringId.FilterCriteriaToStringFunctionGetDate:
                return "الحصول على التاريخ";
                case StringId.CameraSettingsBrightness:
                return "السطوع:";
                case StringId.ManageRuleFormatCellsUnderline:
                return "تسطير";
                case StringId.ManageRuleRankedValuesOfTheColumnsCellValues:
                return "% من قيم العمود";
                case StringId.ColorPickHueAxisName:
                return "هوي";
                case StringId.FormatRuleMenuItemTextThatContains:
                return "النص الذي يحتوي على";
                case StringId.CameraSettingsContrast:
                return "التباين:";
                case StringId.PictureEditMenuZoomToolTip:
                return "{0} %";
                case StringId.FormatPredefinedAppearanceGreenText:
                return "نص أخضر";
                case StringId.ManageRuleDataBarLTR:
                return "اليمين إلى اليسار";
                case StringId.ManageRuleFormatCellsStrikethrough:
                return "يتوسطه خط";
                case StringId.ManageRuleRankedValuesTop:
                return "أعلى";
                case StringId.FormatRuleMenuItemCustomCondition:
                return "شرط مخصص";
                case StringId.ColorPickSaturationAxisName:
                return "تشبع";
                case StringId.FormatPredefinedAppearanceBoldText:
                return "نص غامق";
                case StringId.CameraSettingsDesaturate:
                return "التشبع:";
                case StringId.ManageRuleDataBarRTL:
                return "اليمين إلى اليسار";
                case StringId.ManageRuleRankedValuesBottom:
                return "أسفل";
                case StringId.ManageRuleFormatCellsClear:
                return "واضحة";
                case StringId.ColorPickLuminanceAxisName:
                return "النصوع";
                case StringId.FormatPredefinedAppearanceItalicText:
                return "نص مائل";
                case StringId.CameraSettingsDefaults:
                return "إعادة تعيين الافتراضيات";
                case StringId.ManageRuleIconSetsDisplayEachIconAccordingToTheseRules:
                return "عرض رمز كل وفقا لهذه القواعد:";
                case StringId.ManageRuleFormatCellsBackgroundColor:
                return "لون الخلفية:";
                case StringId.ColorPickBrightnessAxisName:
                return "سطوع";
                case StringId.ManageRuleThatContainFormatOnlyCellsWith:
                return "تنسيق الخلايا التي تحتوي فقط:";
                case StringId.FormatPredefinedAppearanceStrikeoutText:
                return "نص يتوسطه خط";
                case StringId.FormatRuleLessThanText:
                return "تنسيق الخلايا التي تكون أقل";
                case StringId.ManageRuleIconSetsReverseIconOrder:
                return "عكس ترتيب الرموز";
                case StringId.CameraSettingsCaption:
                return "إعدادات الكاميرا";
                case StringId.ManageRuleFormatCellsNone:
                return "لا شيء";
                case StringId.ColorPickOpacityAxisName:
                return "العتامة";
                case StringId.ManageRuleThatContainCellValue:
                return "قيمة الخلية";
                case StringId.ManageRuleIconSetsWhen:
                return "عندما";
                case StringId.CameraSettingsResolution:
                return "القرار:";
                case StringId.ColorPickRedValidationMsg:
                return "ينبغي أن يكون العنصر حمراء في مجموعة 0..255";
                case StringId.ManageRuleThatContainDatesOccurring:
                return "التواريخ التي تحدث";
                case StringId.ManageRuleIconSetsValueIs:
                return "القيمة";
                case StringId.ManageRuleFormatCellsBold:
                return "غامق";
                case StringId.CameraDeviceNotFound:
                return "كاميرا ويب لم يتم العثور على. تحقق من اتصال كاميرا ويب أو إعدادات الجهاز.";
                case StringId.ManageRuleThatContainSpecificText:
                return "نص محدد";
                case StringId.ManageRuleSimpleRuleBaseFormat:
                return "تنسيق...";
                case StringId.ManageRuleThatContainBlanks:
                return "الفراغات";
                case StringId.CameraDeviceIsBusy:
                return "لا يمكن استخدام الجهاز، كما أنه مسبقاً قيد الاستخدام في تطبيق آخر.";
                case StringId.ManageRuleThatContainNoBlanks:
                return "بلا فراغات";
                case StringId.ManageRuleAverageFormatValuesThatAre:
                return "تنسيق القيم التي:";
                case StringId.ManageRuleThatContainErrors:
                return "أخطاء";
                case StringId.CameraDesignTimeInfo:
                return "يتم تعطيل التقديم في وقت التصميم.";
                case StringId.ManageRuleAverageTheAverageForTheSelectedRange:
                return "متوسط قيم العمود";

                default:
                return base.GetLocalizedString(id);
            }
        }
    }
    public class HebrewEditorLocalizer : XtraEditors.Controls.Localizer {
        public override string GetLocalizedString(StringId id) {
            switch(id) {
                case StringId.ColorPickGreenValidationMsg:
                return "רכיב הירוק צריך להיות בתוך טווח 0..255";
                case StringId.FilterEditorTabVisual:
                return "חזותי";
                case StringId.FilterCriteriaToStringFunctionIsThisWeek:
                return "השבוע";
                case StringId.ManageRuleCellValueBetween:
                return "בין";
                case StringId.InvalidValueText:
                return "ערך לא חוקי";
                case StringId.ColorPickBlueValidationMsg:
                return "רכיב הכחול צריך להיות בתוך טווח 0..255";
                case StringId.FormatPredefinedAppearanceRedBoldText:
                return "טקסט מודגש אדום";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisYear:
                return "השנה";
                case StringId.ManageRuleCellValueNotBetween:
                return "לא בין";
                case StringId.FilterCriteriaToStringFunctionGetMilliSecond:
                return "לקבל אלפיות השנייה";
                case StringId.CheckChecked:
                return "בדקתי";
                case StringId.ColorPickOpacityValidationMsg:
                return "האטימות צריך להיות בתוך טווח 0..255";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisMonth:
                return "החודש";
                case StringId.CaptionError:
                return "שגיאה";
                case StringId.IconSetCategoryDirectional:
                return "כיוונים";
                case StringId.ManageRuleCellValueEqualTo:
                return "שווה ל";
                case StringId.CheckUnchecked:
                return "לא מסומן";
                case StringId.ColorPickColorHexValidationMsg:
                return "ערך הקסדצימאלי לא חוקי";
                case StringId.FilterShowAll:
                return "(בחר הכל)";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeLastWeek:
                return "בשבוע שעבר";
                case StringId.ManageRuleCellValueNotEqualTo:
                return "לא שווה";
                case StringId.CheckIndeterminate:
                return "לא מוגדר";
                case StringId.FormatPredefinedAppearanceGreenBoldText:
                return "טקסט מודגש ירוק";
                case StringId.FilterCriteriaToStringFunctionGetSecond:
                return "לקבל השני";
                case StringId.ColorPickHueValidationMsg:
                return "גוון רכיב צריך להיות בתוך טווח 0..359";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeThisWeek:
                return "השבוע";
                case StringId.ManageRuleCellValueGreaterThan:
                return "גדול מ-";
                case StringId.DateEditClear:
                return "ברור";
                case StringId.IconSetCategoryPositiveNegative:
                return "חיובי/שלילי";
                case StringId.SearchControlNullValuePrompt:
                return "הזן טקסט לחיפוש...";
                case StringId.ColorPickSaturationValidationMsg:
                return "רכיב רוויה צריך להיות בתוך טווח 0..100";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeYesterday:
                return "אתמול";
                case StringId.FilterGroupAnd:
                return "ו";
                case StringId.ManageRuleCellValueLessThan:
                return "פחות מ";
                case StringId.FilterGroupNotAnd:
                return "לא,";
                case StringId.DateEditToday:
                return "היום";
                case StringId.SearchForColumn:
                return "חיפוש עבור עמודה...";
                case StringId.FilterCriteriaToStringFunctionGetMinute:
                return "לקבל דקה";
                case StringId.ColorPickBrightValidationMsg:
                return "רכיב בהירות צריך להיות בתוך טווח 0..100";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeToday:
                return "היום";
                case StringId.ManageRuleCellValueGreaterThanOrEqualTo:
                return "גדול מאו שווה ל-";
                case StringId.OK:
                return "אוקיי";
                case StringId.FilterClauseBetween:
                return "בין";
                case StringId.Cancel:
                return "ביטול";
                case StringId.ColorScaleGreenYellowRed:
                return "ירוק - צהוב - אדום";
                case StringId.ColorTabWebSafeColors:
                return "לאינטרנט";
                case StringId.FilterGroupNotOr:
                return "לא או";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeNow:
                return "עכשיו";
                case StringId.ManageRuleCellValueLessThanOrEqualTo:
                return "קטן או שווה ל-";
                case StringId.FilterClauseBetweenAnd:
                return "ו";
                case StringId.SearchForField:
                return "חיפוש עבור שדה...";
                case StringId.FilterCriteriaToStringFunctionGetHour:
                return "לקבל שעה";
                case StringId.NavigatorFirstButtonHint:
                return "הראשון";
                case StringId.Days:
                return "ימים";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeTomorrow:
                return "מחר";
                case StringId.NavigatorRemoveButtonHint:
                return "מחק";
                case StringId.ManageRuleDatesOccurringBeyond:
                return "לאחר החודש בזמן 2 חודשים";
                case StringId.FilterClauseContains:
                return "מכיל";
                case StringId.NavigatorPreviousButtonHint:
                return "הקודם";
                case StringId.ColorScalePurpleWhiteAzure:
                return "סגול - לבן - תכלת";
                case StringId.FilterGroupOr:
                return "או";
                case StringId.Hours:
                return "שעות";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeDayAfterTomorrow:
                return "היום שאחרי מחר";
                case StringId.ManageRuleDatesOccurringBeyondThisYear:
                return "בעקבות השנה";
                case StringId.ManageRuleCaption:
                return "מנהל כללי עיצוב מותנה";
                case StringId.FilterClauseEndsWith:
                return "מסתיים";
                case StringId.NavigatorPreviousPageButtonHint:
                return "דף קודמות";
                case StringId.Mins:
                return "דקות";
                case StringId.FilterCriteriaToStringFunctionGetDay:
                return "היום";
                case StringId.NavigatorEditButtonHint:
                return "עריכה";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextWeek:
                return "בשבוע הבא";
                case StringId.ManageRuleDatesOccurringEarlier:
                return "לפני חודש לפני 6 חודשים";
                case StringId.FilterClauseEquals:
                return "שווה ל-";
                case StringId.ColorScaleYellowOrangeCoral:
                return "צהוב - כתום - אלמוג";
                case StringId.NavigatorNextButtonHint:
                return "הבא";
                case StringId.FilterClauseAnyOf:
                return "הוא אף אחד";
                case StringId.Secs:
                return "שניות";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeTwoWeeksAway:
                return "במרחק שבועיים";
                case StringId.ManageRuleShowFormattingRules:
                return "הצג כללי:";
                case StringId.ManageRuleDatesOccurringEarlierThisMonth:
                return "החודש, לפני שבוע קודם לכן";
                case StringId.FilterClauseGreater:
                return "גדול מ-";
                case StringId.NavigatorNextPageButtonHint:
                return "דף הבא";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisYear:
                return "מאוחר יותר השנה";
                case StringId.FilterCriteriaToStringFunctionGetMonth:
                return "להשיג בחודש";
                case StringId.Millisecs:
                return "millisecs";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextMonth:
                return "בחודש הבא";
                case StringId.ManageRuleDatesOccurringEarlierThisWeek:
                return "השבוע, לפני אתמול";
                case StringId.NavigatorEndEditButtonHint:
                return "סיום עריכה";
                case StringId.ColorScaleGreenWhiteRed:
                return "ירוק - לבן - אדום";
                case StringId.FilterClauseGreaterOrEqual:
                return "גדול או שווה ל-";
                case StringId.NavigatorLastButtonHint:
                return "אחרונה";
                case StringId.IncorrectNumberCopies:
                return "המספר חייב להיות בין 1 ל- 32767.";
                case StringId.FilterClauseBeginsWith:
                return "מתחילה עם";
                case StringId.FilterCriteriaToStringFunctionLocalDateTimeNextYear:
                return "בשנה הבאה";
                case StringId.ManageRuleDatesOccurringEarlierThisYear:
                return "השנה, לפני החודש";
                case StringId.FilterClauseIsNotNull:
                return "אינו null";
                case StringId.ManageRuleUp:
                return "למעלה";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisMonth:
                return "הוא מאוחר יותר החודש";
                case StringId.NavigatorAppendButtonHint:
                return "צרף";
                case StringId.FilterCriteriaToStringFunctionGetYear:
                return "לקבל בשנה";
                case StringId.ChartRangeControlClientInvalidGrid:
                return "המרווח בין קווי הרשת הוא קטן מדי כדי להיות מיוצג בפקד טווח.";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalBeyondThisYear:
                return "הוא מעבר לכל השנה";
                case StringId.ManageRuleDatesOccurringLastWeek:
                return "בשבוע שעבר";
                case StringId.NavigatorCancelEditButtonHint:
                return "ביטול עריכה";
                case StringId.ColorScaleEmeraldAzureBlue:
                return "ברקת - תכלת - כחול";
                case StringId.FilterClauseIsNull:
                return "הוא null";
                case StringId.NavigatorTextStringFormat:
                return "הרשומה {0} מתוך {1}";
                case StringId.ChartRangeControlClientNoData:
                return "יש נתונים כדי לייצג בפקד טווח.";
                case StringId.FilterClauseNoneOf:
                return "הוא אף אחד";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLaterThisWeek:
                return "מאוחר יותר השבוע";
                case StringId.ManageRuleDown:
                return "למטה";
                case StringId.ManageRuleDatesOccurringLaterThisMonth:
                return "בחודש זה, מעבר בשבוע הבא";
                case StringId.FilterClauseIsNotNullOrEmpty:
                return "אינו ריק";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalNextWeek:
                return "בשבוע הבא";
                case StringId.PictureEditMenuCut:
                return "לחתוך";
                case StringId.DataBarBlue:
                return "סרגל נתונים כחול";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalTomorrow:
                return "מחר";
                case StringId.FilterCriteriaToStringFunctionGetDayOfWeek:
                return "יום של השבוע";
                case StringId.ManageRuleDatesOccurringLaterThisWeek:
                return "השבוע, מעבר מחר";
                case StringId.LookUpColumnDefaultName:
                return "שם";
                case StringId.FilterClauseIsNullOrEmpty:
                return "ריק";
                case StringId.PictureEditMenuCopy:
                return "העתק";
                case StringId.ColorScaleWhiteRed:
                return "לבן - אדום";
                case StringId.DataBarLightBlue:
                return "אור כחול נתונים בר";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalToday:
                return "היום";
                case StringId.ManageRuleDatesOccurringLaterThisYear:
                return "השנה, מעבר החודש";
                case StringId.FilterClauseNotBetween:
                return "אינה בין";
                case StringId.FilterClauseLess:
                return "הוא פחות מ";
                case StringId.PictureEditMenuPaste:
                return "הדבק";
                case StringId.ManageRuleNewRule:
                return "חוק חדש...";
                case StringId.DataBarGreen:
                return "סרגל נתונים ירוק";
                case StringId.FilterCriteriaToStringFunctionToLong:
                return "כדי זמן רב";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalYesterday:
                return "אתמול";
                case StringId.ManageRuleDatesOccurringMonthAfter1:
                return "בחודש הבא";
                case StringId.FilterCriteriaToStringFunctionAddMilliSeconds:
                return "להוסיף אלפיות השניה";
                case StringId.FilterCriteriaToStringFunctionGetDayOfYear:
                return "יום השנה";
                case StringId.UnknownPictureFormat:
                return "תבנית התמונה לא ידוע";
                case StringId.FilterClauseLessOrEqual:
                return "קטן או שווה ל-";
                case StringId.PictureEditMenuDelete:
                return "מחק";
                case StringId.DataBarYellow:
                return "סרגל נתונים צהוב";
                case StringId.ColorScaleWhiteGreen:
                return "לבן - ירוק";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisWeek:
                return "מוקדם יותר השבוע";
                case StringId.FilterClauseDoesNotContain:
                return "אינו מכיל";
                case StringId.ManageRuleDatesOccurringMonthAfter2:
                return "במהלך החודש בזמן 2 חודשים";
                case StringId.FilterCriteriaToStringFunctionAddSeconds:
                return "להוסיף שניות";
                case StringId.ManageRuleEditRule:
                return "ערוך את הכלל...";
                case StringId.FilterClauseLike:
                return "זה כמו";
                case StringId.PictureEditMenuLoad:
                return "עומס";
                case StringId.DataBarOrange:
                return "סרגל נתונים כתום";
                case StringId.FilterCriteriaToStringFunctionToFloat:
                return "לצוף";
                case StringId.FilterCriteriaToStringFunctionGetTimeOfDay:
                return "לקבל זמן של יום";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalLastWeek:
                return "בשבוע שעבר";
                case StringId.ManageRuleDatesOccurringMonthAgo1:
                return "בחודש שעבר";
                case StringId.FilterCriteriaToStringFunctionAddMinutes:
                return "להוסיף דקות";
                case StringId.DataEmpty:
                return "אין נתוני תמונה";
                case StringId.FilterEmptyValue:
                return "<empty></empty>";
                case StringId.PictureEditMenuSave:
                return "שמור";
                case StringId.ColorScaleWhiteAzure:
                return "לבן - תכלת";
                case StringId.DataBarMint:
                return "סרגל נתונים מנטה";
                case StringId.FilterClauseDoesNotEqual:
                return "לא שווה";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisMonth:
                return ". זה מוקדם יותר החודש";
                case StringId.ManageRuleDatesOccurringMonthAgo2:
                return "במהלך החודש לפני 2 חודשים";
                case StringId.FilterCriteriaToStringFunctionAddHours:
                return "להוסיף שעות";
                case StringId.FormatRuleMenuItemClearAllRules:
                return "כללים ברורים של כל העמודות";
                case StringId.ManageRuleDeleteRule:
                return "מחיקת כלל";
                case StringId.FilterMenuConditionAdd:
                return "הוסף התנאי";
                case StringId.PictureEditOpenFileFilter:
                return "מפת סיביות קבצים (*.bmp) | *-bmp| Graphics Interchange Format (*.gif) | *-gif| תבנית הקובץ JPEG מחלף (*.jpg; *.jpeg) | *. jpg; *. jpeg| קבצי הסמלים (*.ico) | *-ico| רשת נייד גרפיקה בתבנית (*.png) | *-png| כל קבצי התמונות | *. bmp; *.gif; *.jpg; *.jpeg; *.ico; *.png; *. tif| כל הקבצים | * *";
                case StringId.DataBarViolet:
                return "סרגל נתונים ויולט";
                case StringId.FilterCriteriaToStringFunctionToDouble:
                return "זוגי";
                case StringId.FilterCriteriaToStringFunctionNow:
                return "עכשיו";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalEarlierThisYear:
                return "מוקדם יותר השנה";
                case StringId.ManageRuleDatesOccurringMonthAgo3:
                return "במהלך החודש לפני 3 חודשים";
                case StringId.FilterCriteriaToStringFunctionAddDays:
                return "הוספת ימים";
                case StringId.NotValidArrayLength:
                return "אורך המערך אינו חוקי.";
                case StringId.FilterMenuGroupAdd:
                return "הוסף קבוצת";
                case StringId.ColorScaleYellowGreen:
                return "צהוב - ירוק";
                case StringId.PictureEditSaveFileFilter:
                return "מפת סיביות קבצים (*.bmp) | *-bmp| Graphics Interchange Format (*.gif) | *-gif| תבנית הקובץ JPEG מחלף (*.jpg) | *-jpg| עיצוב גרפי רשת נייד (*.png) | *. png";
                case StringId.DataBarRaspberry:
                return "סרגל נתונים פטל";
                case StringId.FilterClauseNotLike:
                return ". לא מתאים";
                case StringId.FilterCriteriaToStringFunctionIsOutlookIntervalPriorThisYear:
                return "זה לפני השנה";
                case StringId.ManageRuleDatesOccurringMonthAgo4:
                return "במהלך חודש 4 חודשים לפני";
                case StringId.FormatRuleMenuItemHighlightCellRules:
                return "כללים תא האר";
                case StringId.FormatRuleUniqueText:
                return "עיצוב תאים כי הם ערכים ייחודיים";
                case StringId.ManageRuleGridCaptionRule:
                return "כלל";
                case StringId.FilterCriteriaToStringFunctionAddMonths:
                return "להוסיף חודשים";
                case StringId.FilterMenuClearAll:
                return "לנקות את כל";
                case StringId.PictureEditOpenFileTitle:
                return "פתוח";
                case StringId.FilterCriteriaToStringFunctionToDecimal:
                return "לעשרוני";
                case StringId.DataBarCoral:
                return "סרגל נתונים אלמוג";
                case StringId.FilterCriteriaToStringFunctionCustom:
                return "מותאם אישית";
                case StringId.FilterCriteriaToStringFunctionUtcNow:
                return "Utc עכשיו";
                case StringId.ManageRuleDatesOccurringMonthAgo5:
                return "במהלך החודש לפני 5 חודשים";
                case StringId.ImagePopupEmpty:
                return "(ריק)";
                case StringId.FormatRuleMenuItemDuplicate:
                return "ערכים כפולים";
                case StringId.FilterCriteriaToStringFunctionAddYears:
                return "להוסיף שנים";
                case StringId.FilterMenuRowRemove:
                return "הסר קבוצת";
                case StringId.ColorScaleBlueWhiteRed:
                return "כחול - לבן - אדום";
                case StringId.PictureEditSaveFileTitle:
                return "שמירה בשם";
                case StringId.FormatRuleMenuItemTopBottomRules:
                return "כללי עליון/תחתון";
                case StringId.DataBarBlueGradient:
                return "צבע כחול נתונים בר";
                case StringId.FilterCriteriaToStringFunctionCustomNonDeterministic:
                return "אישית לא דטרמיניסטי";
                case StringId.ManageRuleGridCaptionFormat:
                return "תבנית";
                case StringId.ManageRuleDatesOccurringMonthAgo6:
                return "במהלך החודש לפני 6 חודשים";
                case StringId.FilterCriteriaToStringFunctionToStr:
                return "ל str";
                case StringId.FormatRuleDuplicateText:
                return "עיצוב תאים כי הם ערכים כפולים";
                case StringId.FilterCriteriaToStringFunctionStartsWith:
                return "מתחיל עם";
                case StringId.FilterCriteriaToStringFunctionToday:
                return "היום";
                case StringId.FilterToolTipNodeAdd:
                return "מוסיף תנאי חדש לקבוצה זו";
                case StringId.ImagePopupPicture:
                return "(תמונה)";
                case StringId.PictureEditOpenFileError:
                return "בתבנית תמונה שגויה";
                case StringId.DataBarLightBlueGradient:
                return "שורת הנתונים באור כחול הדרגתי";
                case StringId.FormatRuleMenuItemUnique:
                return "ערכים ייחודיים";
                case StringId.FilterCriteriaToStringFunctionIsNullOrEmpty:
                return "הוא null או ריק";
                case StringId.ManageRuleDatesOccurringNextWeek:
                return "בשבוע הבא";
                case StringId.FormatRuleApplyFormatProperty:
                return "להחיל עיצוב על שורה שלמה";
                case StringId.FormatRuleMenuItemDataBars:
                return "סרגלי נתונים";
                case StringId.FilterCriteriaToStringFunctionEndsWith:
                return "מסתיים";
                case StringId.ManageRuleGridCaptionApplyToTheRow:
                return "שיחולו על השורה";
                case StringId.FilterToolTipNodeRemove:
                return "מסיר את המצב הזה";
                case StringId.PictureEditOpenFileErrorCaption:
                return "שגיאה בפתיחת";
                case StringId.FilterCriteriaToStringFunctionReplace:
                return "החלף";
                case StringId.DataBarGreenGradient:
                return "צבע ירוק נתונים בר";
                case StringId.FilterCriteriaToStringFunctionConcat:
                return "איש קשר";
                case StringId.ManageRuleDatesOccurringPriorThisYear:
                return "לפני השנה";
                case StringId.FilterCriteriaToStringFunctionAddTimeSpan:
                return "הוספת טווח זמן";
                case StringId.FormatRuleWith:
                return "עם";
                case StringId.FilterCriteriaToStringFunctionContains:
                return "מכיל";
                case StringId.ColorTabCustom:
                return "מותאם אישית";
                case StringId.FilterToolTipNodeAction:
                return "פעולות";
                case StringId.FilterMenuAddNewParameter:
                return "הוסף פרמטר...";
                case StringId.PictureEditCopyImageError:
                return "לא היתה אפשרות להעתיק את התמונה";
                case StringId.DataBarYellowGradient:
                return "צבע צהוב נתונים בר";
                case StringId.FilterCriteriaToStringFunctionAscii:
                return "Ascii";
                case StringId.IconSetTitleRatings4:
                return "4 דירוגים";
                case StringId.FormatRuleMenuItemColorScales:
                return "סרגלי צבעים";
                case StringId.ManageRuleDatesOccurringThisMonth:
                return "החודש";
                case StringId.FormatRuleForThisColumnWith:
                return "עבור עמודה זו עם";
                case StringId.FilterCriteriaInvalidExpression:
                return "הביטוי שצוין מכיל סמלים לא חוקי (קו {0}, תו {1}).";
                case StringId.ManageRuleGridCaptionColumn:
                return "טור";
                case StringId.FilterCriteriaToStringFunctionReverse:
                return "הפוך";
                case StringId.FilterToolTipValueType:
                return "להשוות עם ערך / אחר הערך של שדה";
                case StringId.LookUpEditValueIsNull:
                return "[EditValue הוא null]";
                case StringId.DataBarOrangeGradient:
                return "צבע כתום נתונים בר";
                case StringId.ManageRuleAllColumns:
                return "(הכל)";
                case StringId.FilterCriteriaToStringFunctionChar:
                return "Char";
                case StringId.ManageRuleDatesOccurringThisWeek:
                return "השבוע";
                case StringId.FilterCriteriaToStringFunctionAddTicks:
                return "להוסיף קרציות";
                case StringId.IconSetTitleStars3:
                return "3 כוכבים";
                case StringId.ColorTabWeb:
                return "אינטרנט";
                case StringId.FilterCriteriaInvalidExpressionEx:
                return "הביטוי שצוין אינו חוקי.";
                case StringId.FilterToolTipElementAdd:
                return "הוספת פריט חדש לרשימה";
                case StringId.FilterCriteriaToStringUnaryOperatorIsNull:
                return "הוא Null";
                case StringId.LookUpInvalidEditValueType:
                return "סוג לא חוקי LookUpEdit EditValue.";
                case StringId.IconSetTitleRatings5:
                return "דירוגי 5";
                case StringId.DataBarMintGradient:
                return "מעבר צבע סרגל נתונים מנטה";
                case StringId.FilterCriteriaToStringFunctionToInt:
                return "כדי אינטראקציה.";
                case StringId.ManageRuleDatesOccurringTomorrow:
                return "מחר";
                case StringId.FormatRuleMenuItemIconSets:
                return "ערכות סמלים";
                case StringId.IconSetTitleSymbols3Circled:
                return "3 סמלים (מסומן בעיגול)";
                case StringId.Apply:
                return "החל";
                case StringId.NewFormattingRule:
                return "כלל עיצוב חדש";
                case StringId.FilterToolTipKeysAdd:
                return "(השתמש את תותב או להוסיף מפתח)";
                case StringId.FilterCriteriaToStringFunctionInsert:
                return "הוספה";
                case StringId.TabHeaderButtonPin:
                return "סיכה";
                case StringId.DataBarVioletGradient:
                return "צבע סגול נתונים בר";
                case StringId.ManageRuleCommonMaximum:
                return "לכל היותר";
                case StringId.FilterCriteriaToStringFunctionCos:
                return "Cos";
                case StringId.ManageRuleDatesOccurringToday:
                return "היום";
                case StringId.IconSetTitleSymbols3Uncircled:
                return "(הלא-מוקפים) 3 סמלים";
                case StringId.FilterOutlookDateText:
                return "להראות all| להראות Empty| סנן לפי תאריך ספציפי: |Beyond year| הזה מאוחר יותר year| הזה מאוחר יותר month| הזה Week| הבא מאוחר יותר week| הזה Tomorrow| Today| Yesterday| מוקדם יותר week| הזה Week| האחרון מוקדם יותר month| הזה מוקדם יותר year| הזה לפני השנה";
                case StringId.ColorTabSystem:
                return "מערכת";
                case StringId.FilterCriteriaToStringUnaryOperatorMinus:
                return "-";
                case StringId.PreviewPanelText:
                return "תצוגה מקדימה:";
                case StringId.FilterToolTipKeysRemove:
                return "(השתמש מחק או להחסיר מפתח)";
                case StringId.TabHeaderButtonUnpin:
                return "בטל הצמדה";
                case StringId.IconSetTitleQuarters5:
                return "5 רבעים";
                case StringId.DataBarRaspberryGradient:
                return "מעבר צבע סרגל נתונים פטל";
                case StringId.ManageRuleEqualOrBelowAverage:
                return "שווה או מתחת לממוצע";
                case StringId.FilterCriteriaToStringFunctionSin:
                return "חטא";
                case StringId.FormatRuleMenuItemClearRules:
                return "כללים ברורים";
                case StringId.ManageRuleDatesOccurringYesterday:
                return "אתמול";
                case StringId.IconSetTitleFlags3:
                return "דגלים 3";
                case StringId.EditFormattingRule:
                return "עריכת כלל עיצוב";
                case StringId.TransparentBackColorNotSupported:
                return "פקד זה אינו תומך צבעי רקע שקוף";
                case StringId.FilterCriteriaToStringFunctionCharIndex:
                return "Char אינדקס";
                case StringId.ContainerAccessibleEditName:
                return "עריכת בקרה";
                case StringId.TabHeaderSelectorButton:
                return "הצג חלון הרשימה";
                case StringId.DataBarCoralGradient:
                return "מעבר צבע סרגל נתונים אלמוג";
                case StringId.ManageRuleCommonType:
                return "סוג:";
                case StringId.FilterDateTimeConstantMenuCaption:
                return "תאריך ושעה קבועים";
                case StringId.ManageRuleFormatCellsCaption:
                return "עיצוב תאים";
                case StringId.FilterCriteriaToStringFunctionAtn:
                return "Atn";
                case StringId.ManageRuleSpecificTextContaining:
                return "המכיל";
                case StringId.CalcButtonMC:
                return "MC";
                case StringId.IconSetTitlePositiveNegativeArrows:
                return "חיצים (בצבע)";
                case StringId.FilterAggregateExists:
                return "קיים";
                case StringId.FilterCriteriaToStringGroupOperatorAnd:
                return "ו";
                case StringId.FilterCriteriaToStringUnaryOperatorNot:
                return ". לא";
                case StringId.IconSetTitleBoxes5:
                return "5 תיבות";
                case StringId.XtraMessageBoxOkButtonText:
                return "& בסדר";
                case StringId.FormatRuleMenuItemClearColumnRules:
                return "כללים ברורים של עמודה זו";
                case StringId.ManageRuleFormatCellsFont:
                return "גופן";
                case StringId.FormatRuleMenuItemManageRules:
                return "ניהול כללי...";
                case StringId.NewEditFormattingRuleSelectARuleType:
                return "בחר סוג כלל:";
                case StringId.FilterCriteriaToStringFunctionExp:
                return "Exp";
                case StringId.ManageRuleSpecificTextNotContaining:
                return "אשר אינו מכיל";
                case StringId.IconSetTitlePositiveNegativeArrowsGray:
                return "חיצים (אפור)";
                case StringId.FilterCriteriaToStringFunctionRemove:
                return "הסר";
                case StringId.FilterAggregateMax:
                return "מקס";
                case StringId.FilterCriteriaToStringGroupOperatorOr:
                return "או";
                case StringId.ManageRuleCommonPercent:
                return "אחוז";
                case StringId.XtraMessageBoxCancelButtonText:
                return "& לבטל";
                case StringId.FilterDateTimeOperatorMenuCaption:
                return "מפעילי תאריך ושעה";
                case StringId.IconSetCategoryShapes:
                return "צורות";
                case StringId.ManageRuleFormatCellsFill:
                return "מילוי";
                case StringId.FilterCriteriaToStringFunctionLog:
                return "יומן";
                case StringId.CalcButtonMR:
                return "מר";
                case StringId.FilterCriteriaToStringUnaryOperatorPlus:
                return "+";
                case StringId.ManageRuleSpecificTextBeginningWith:
                return "החל מ-";
                case StringId.IconSetTitlePositiveNegativeTriangles:
                return "משולשים";
                case StringId.FilterAggregateMin:
                return "Min";
                case StringId.IconSetTitleArrows3Colored:
                return "3 חצים (בצבע)";
                case StringId.FilterCriteriaToStringUnaryOperatorBitwiseNot:
                return "~";
                case StringId.XtraMessageBoxYesButtonText:
                return "& כן";
                case StringId.FormatRuleMenuItemUniqueDuplicateRules:
                return "ייחודי/שכפול כללי";
                case StringId.FormatRuleMenuItemBottom10Items:
                return "התחתון 10 פריטים";
                case StringId.NewEditFormattingRuleEditTheRuleDescription:
                return "ערוך את תיאור הכלל:";
                case StringId.ManageRuleFormatCellsPredefinedAppearance:
                return "המראה מוגדרים מראש";
                case StringId.FilterCriteriaToStringFunctionRnd:
                return "Rnd";
                case StringId.ManageRuleSpecificTextEndingWith:
                return "המסתיימים";
                case StringId.FilterCriteriaToStringFunctionAbs:
                return "Abs";
                case StringId.ManageRuleCommonNumber:
                return "מספר";
                case StringId.FormatRuleMenuItemTop10Items:
                return "העליון 10 פריטים";
                case StringId.FilterAggregateSum:
                return "סכום";
                case StringId.FilterCriteriaToStringBinaryOperatorMultiply:
                return "*";
                case StringId.FilterDateTextAlt:
                return "להראות all| להראות Empty| סנן לפי תאריך ספציפי: |Beyond||| Week| הבא Today| Week| הזה Month| הזה Earlier| {0:yyyy}, {0: ממממ}";
                case StringId.XtraMessageBoxNoButtonText:
                return "& אין";
                case StringId.FormatRuleMenuItemBottom10Percent:
                return "תחתון 10%";
                case StringId.ManageRuleFormatCellsFontStyle:
                return "סגנון גופן";
                case StringId.FilterEditorTabText:
                return "טקסט";
                case StringId.CalcButtonMS:
                return "MS";
                case StringId.FilterCriteriaToStringBinaryOperatorBitwiseAnd:
                return "&";
                case StringId.FilterCriteriaToStringFunctionTan:
                return "טאן";
                case StringId.ManageRuleUniqueOrDuplicateFormatAll:
                return "לעצב כל:";
                case StringId.FormatRuleMenuItemTop10Percent:
                return "העליון 10%";
                case StringId.IconSetTitleArrows3Gray:
                return "3 חצים (אפור)";
                case StringId.FieldListName:
                return "רשימת שדות ({0})";
                case StringId.FilterCriteriaToStringBinaryOperatorNotEqual:
                return "<>";
                case StringId.XtraMessageBoxAbortButtonText:
                return "& בטל";
                case StringId.FormatRuleMenuItemGradientFill:
                return "מילוי";
                case StringId.FormatRuleMenuItemAboveAverage:
                return "מעל הממוצע";
                case StringId.NewEditFormattingRuleFormatAllCellsBasedOnTheirValues:
                return "עיצוב כל התאים בהתבסס על הערכים שלהם";
                case StringId.ManageRuleFormatCellsFontColor:
                return "צבע גופן";
                case StringId.FilterCriteriaToStringFunctionPower:
                return "כוח";
                case StringId.FilterCriteriaToStringFunctionSqr:
                return "Sqr";
                case StringId.ManageRuleUniqueOrDuplicateValuesInTheSelectedRange:
                return "ערכי עמודה";
                case StringId.FormatRuleBetweenText:
                return "עיצוב תאים הנמצאים BETWEEN";
                case StringId.RestoreLayoutDialogFileFilter:
                return "קבצי XML (*. xml) | *-xml| כל files| * *";
                case StringId.ManageRuleCommonValue:
                return "ערך:";
                case StringId.FilterFunctionsMenuCaption:
                return "פונקציות";
                case StringId.FilterCriteriaToStringBinaryOperatorPlus:
                return "+";
                case StringId.XtraMessageBoxRetryButtonText:
                return "& שנית";
                case StringId.FormatRuleMenuItemBelowAverage:
                return "מתחת לממוצע";
                case StringId.FilterCriteriaToStringFunctionIsThisMonth:
                return "הוא החודש";
                case StringId.ManageRuleFormatCellsEffects:
                return "אפקטים:";
                case StringId.FilterCriteriaToStringFunctionSign:
                return "סימן";
                case StringId.ManageRuleUniqueOrDuplicateUnique:
                return "ייחודי";
                case StringId.CalcButtonMx:
                return "M +";
                case StringId.FilterCriteriaToStringBinaryOperatorBitwiseOr:
                return "|";
                case StringId.FormatRuleEqualToText:
                return "עיצוב תאים הנמצאים שווה ל";
                case StringId.SaveLayoutDialogFileFilter:
                return "קבצי XML (*. xml) | *. xml";
                case StringId.IconSetTitleTriangles3:
                return "3 משולשים";
                case StringId.FilterCriteriaToStringBetween:
                return "בין";
                case StringId.FormatRuleMenuItemSolidFill:
                return "מילוי מלא";
                case StringId.XtraMessageBoxIgnoreButtonText:
                return "& להתעלם";
                case StringId.FormatRuleTopText:
                return "עיצוב תאים המדורגים בין החלק העליון";
                case StringId.ManageRuleFormatCellsUnderline:
                return "קו תחתון";
                case StringId.NewEditFormattingRuleFormatOnlyCellsThatContain:
                return "לעצב רק תאים המכילים";
                case StringId.FilterCriteriaToStringFunctionAtn2:
                return "Atn2";
                case StringId.FilterCriteriaToStringFunctionRound:
                return "עגול";
                case StringId.ManageRuleUniqueOrDuplicateDuplicate:
                return "שכפל";
                case StringId.FormatRuleTextThatContainsText:
                return "עיצוב תאים המכילים את הטקסט";
                case StringId.ManageRuleCommonColor:
                return "צבע:";
                case StringId.RestoreLayoutDialogTitle:
                return "שחזור פריסת";
                case StringId.FilterCriteriaToStringIn:
                return "ב";
                case StringId.DefaultBooleanTrue:
                return "נכון";
                case StringId.TextEditMenuUndo:
                return "& בטל";
                case StringId.FilterCriteriaToStringFunctionGetDate:
                return "להשיג דייט";
                case StringId.FormatRuleBottomText:
                return "עיצוב תאים המדורגים בתחתית";
                case StringId.ManageRuleFormatCellsStrikethrough:
                return "קו חוצה";
                case StringId.FilterPopupToolbarShowOnlyAvailableItems:
                return "הצג רק פריטים זמינים";
                case StringId.CalcButtonSqrt:
                return "sqrt";
                case StringId.FilterCriteriaToStringBinaryOperatorBitwiseXor:
                return "^";
                case StringId.IconSetTitleArrows4Colored:
                return "4 חצים (בצבע)";
                case StringId.FilterCriteriaToStringFunctionCeiling:
                return "התקרה";
                case StringId.ManageRuleColorScale:
                return "מרחב צבע מדורגת";
                case StringId.FormatRuleCustomConditionText:
                return "עיצוב תאים שתואמים את התנאי הבא";
                case StringId.IconSetCategoryRatings:
                return "דירוגים";
                case StringId.SaveLayoutDialogTitle:
                return "שמירת פריסה";
                case StringId.FilterCriteriaToStringIsNotNull:
                return "אינו Null";
                case StringId.TextEditMenuCut:
                return "Cu & t";
                case StringId.NewEditFormattingRuleFormatOnlyTopOrBottomRankedValues:
                return "לעצב רק המדורגים כעליונים או תחתונים ערכים";
                case StringId.FormatRuleAboveAverageText:
                return "עיצוב תאים שנמצאים מעל הממוצע";
                case StringId.ManageRuleFormatCellsClear:
                return "ברור";
                case StringId.FilterCriteriaToStringFunctionBigMul:
                return "מול גדול";
                case StringId.ColorPickPopupRecentColorsGroupCaption:
                return "צבעים האחרונות";
                case StringId.ManageRuleCommonPreview:
                return "תצוגה מקדימה:";
                case StringId.FilterCriteriaToStringFunctionFloor:
                return "קומה";
                case StringId.ManageRuleIconSet:
                return "ערכת סמלים";
                case StringId.DefaultBooleanFalse:
                return "שווא";
                case StringId.PictureEditMenuZoom:
                return "זום";
                case StringId.FilterPopupToolbarShowNewValues:
                return "הצג ערכי שדה חדש";
                case StringId.FilterCriteriaToStringNotLike:
                return "לא כמו";
                case StringId.TextEditMenuCopy:
                return "& להעתיק";
                case StringId.CalcButtonBack:
                return "בחזרה";
                case StringId.FilterCriteriaToStringBinaryOperatorDivide:
                return "/";
                case StringId.FormatRuleBelowAverageText:
                return "עיצוב תאים הנמצאים מתחת לממוצע";
                case StringId.ManageRuleFormatCellsBackgroundColor:
                return "צבע רקע:";
                case StringId.ColorPickPopupMoreColorsItemCaption:
                return "צבעים יותר...";
                case StringId.IconSetTitleArrows4Gray:
                return "4 חצים (אפור)";
                case StringId.FilterCriteriaToStringFunctionMax:
                return "מקס";
                case StringId.ManageRuleFormula:
                return "הנוסחה";
                case StringId.FormatRuleMenuItemDateOccurring:
                return "תאריך המתרחש";
                case StringId.IconSetCategoryIndicators:
                return "אינדיקטורים";
                case StringId.NewEditFormattingRuleFormatOnlyValuesThatAreAboveOrBelowAverage:
                return "פורמט רק ערכים שהם מעל או מתחת לממוצע";
                case StringId.PictureEditMenuFullSize:
                return "בגודל מלא";
                case StringId.FilterCriteriaToStringFunctionIif:
                return "Iif";
                case StringId.TextEditMenuPaste:
                return "& הדבק";
                case StringId.FilterCriteriaToStringFunctionCosh:
                return "Cosh";
                case StringId.FormatRuleMenuItemGreaterThan:
                return "גדול מ-";
                case StringId.ManageRuleFormatCellsNone:
                return "אף אחד";
                case StringId.ColorPickSaturationAxisName:
                return "רוויה";
                case StringId.ColorPickHueAxisName:
                return "גוון";
                case StringId.ManageRuleNoFormatSet:
                return "לא הוגדרו בתבנית";
                case StringId.FilterCriteriaToStringFunctionMin:
                return "Min";
                case StringId.ManageRuleAboveAverage:
                return "מעל הממוצע";
                case StringId.FormatRuleDateOccurring:
                return "עיצוב תאים המכילים תאריך התאמת התנאים האלה";
                case StringId.DefaultBooleanDefault:
                return "ברירת מחדל";
                case StringId.PictureEditMenuFitImage:
                return "התאם תמונה";
                case StringId.FilterCriteriaToStringFunctionIsNull:
                return "IsNull";
                case StringId.FilterPopupToolbarIncrementalSearch:
                return "חיפוש מצטבר";
                case StringId.TextEditMenuDelete:
                return "& מחק";
                case StringId.CalcButtonCE:
                return "לסה נ";
                case StringId.FilterCriteriaToStringBinaryOperatorEqual:
                return "=";
                case StringId.FormatRuleMenuItemLessThan:
                return "פחות מ";
                case StringId.ManageRuleFormatCellsRegular:
                return "רגיל";
                case StringId.ColorPickLuminanceAxisName:
                return "זוהר";
                case StringId.FilterCriteriaToStringFunctionAcos:
                return "Acos";
                case StringId.IconSetTitleArrows5Colored:
                return "5 חצים (בצבע)";
                case StringId.ManageRuleBelowAverage:
                return "מתחת לממוצע";
                case StringId.IconSetCategorySymbols:
                return "סמלים";
                case StringId.FormatPredefinedAppearanceRedFillRedText:
                return "מילוי אדום עם טקסט אדום";
                case StringId.PictureEditMenuZoomIn:
                return "התקרבות";
                case StringId.FilterCriteriaToStringFunctionLen:
                return "לן";
                case StringId.NewEditFormattingRuleFormatOnlyUniqueOrDuplicateValues:
                return "עיצוב ערכים ייחודיים או כפולים בלבד";
                case StringId.FormatPredefinedAppearanceStrikeoutText:
                return "קו חוצה טקסט";
                case StringId.FilterCriteriaToStringFunctionLog10:
                return "Log10";
                case StringId.TextEditMenuSelectAll:
                return "כל & בחר";
                case StringId.FormatRuleMenuItemBetween:
                return "בין";
                case StringId.ColorPickRedValidationMsg:
                return "ורכיב האדום צריך להיות בתוך טווח 0..255";
                case StringId.ManageRuleFormatCellsBold:
                return "מודגש";
                case StringId.ColorPickBrightnessAxisName:
                return "בהירות";
                case StringId.FilterCriteriaToStringFunctionAsin:
                return "Asin";
                case StringId.ManageRuleColorScaleMidpoint:
                return "נקודת אמצע";
                case StringId.ProgressExport:
                return "ייצוא";
                case StringId.ManageRuleEqualOrAboveAverage:
                return "שווה או מעל הממוצע";
                case StringId.FormatPredefinedAppearanceYellowFillYellowText:
                return "מילוי בצבע צהוב עם טקסט צהוב";
                case StringId.PictureEditMenuZoomOut:
                return "התרחקות";
                case StringId.FilterPopupToolbarMultiSelection:
                return "בחירה מרובה";
                case StringId.FilterCriteriaToStringFunctionLower:
                return "נמוך יותר";
                case StringId.ManageRuleAverageAbove:
                return "מעל";
                case StringId.CalcButtonC:
                return "C";
                case StringId.FilterCriteriaToStringBinaryOperatorGreater:
                return ">";
                case StringId.ManageRuleAverageEqualOrAbove:
                return "שווה או מעל";
                case StringId.FormatRuleMenuItemEqualTo:
                return "שווה ל";
                case StringId.TakePictureDialogTryAgain:
                return "נסה שוב";
                case StringId.ColorPickOpacityAxisName:
                return "אטימות";
                case StringId.ManageRuleDataBarAxisColor:
                return "ציר צבע:";
                case StringId.FormatPredefinedAppearanceGreenFillGreenText:
                return "מילוי בצבע ירוק עם טקסט ירוק";
                case StringId.PictureEditMenuZoomTo:
                return "זום:";
                case StringId.FilterPopupToolbarRadioMode:
                return "מצב רדיו";
                case StringId.NewEditFormattingRuleUseAFormulaToDetermineWhichCellsToFormat:
                return "שימוש בנוסחה כדי לקבוע אילו תאים כדי לעצב";
                case StringId.FilterCriteriaToStringFunctionNone:
                return "אף אחד";
                case StringId.ManageRuleAverageBelow:
                return "להלן";
                case StringId.ManageRuleAverageEqualOrBelow:
                return "שווה או להלן";
                case StringId.FilterCriteriaToStringFunctionSinh:
                return "Sinh";
                case StringId.ManageRuleFormatCellsItalic:
                return "נטוי";
                case StringId.FormatRuleMenuItemTextThatContains:
                return "טקסט המכיל";
                case StringId.TakePictureDialogSave:
                return "שמור";
                case StringId.FormatPredefinedAppearanceRedFill:
                return "מילוי אדום";
                case StringId.ManageRuleDataBarBarAppearance:
                return "בר המראה:";
                case StringId.PictureEditMenuZoomToolTip:
                return "{0} %";
                case StringId.FilterPopupToolbarInvertFilter:
                return "המסנן ' היפוך '";
                case StringId.ProgressPrinting:
                return "הדפסה";
                case StringId.FilterCriteriaToStringFunctionSubstring:
                return "מחרוזת משנה";
                case StringId.CalcError:
                return "חישוב שגיאות";
                case StringId.FilterCriteriaToStringBinaryOperatorGreaterOrEqual:
                return ">=";
                case StringId.ManageRuleFormulaFormatValuesWhereThisFormulaIsTrue:
                return "עצב ערכים איפה נכון בנוסחה זו:";
                case StringId.FilterCriteriaToStringFunctionTanh:
                return "Tanh";
                case StringId.IconSetTitleTrafficLights3Unrimmed:
                return "3 רמזורים (Unrimmed)";
                case StringId.FormatRuleMenuItemCustomCondition:
                return "מצב מותאם אישית";
                case StringId.ManageRuleDataBarBarDirection:
                return "בר כיוון";
                case StringId.CameraSettingsActiveDevice:
                return "התקן פעיל:";
                case StringId.FormatPredefinedAppearanceRedText:
                return "הטקסט האדום";
                case StringId.ColorPickPopupAutomaticItemCaption:
                return "אוטומטי";
                case StringId.ManageRuleComplexRuleBaseFormatStyle:
                return "סגנון עיצוב:";
                case StringId.FilterCriteriaToStringFunctionTrim:
                return "לקצץ";
                case StringId.ManageRuleRankedValuesFormatValuesThatRankInThe:
                return "תבנית ערכים המדורגים בין:";
                case StringId.TakePictureDialogTitle:
                return "לצלם";
                case StringId.FilterCriteriaToStringFunctionPadLeft:
                return "משטח שמאל";
                case StringId.ManageRuleDataBarFill:
                return "המילוי:";
                case StringId.FormatRuleGreaterThanText:
                return "עיצוב תאים הנמצאים גדולה מ";
                case StringId.CameraSettingsBrightness:
                return "בהירות:";
                case StringId.FormatPredefinedAppearanceGreenFill:
                return "מילוי בצבע ירוק";
                case StringId.ProgressCreateDocument:
                return "יצירת מסמך";
                case StringId.TabHeaderButtonPrev:
                return "גלול שמאלה";
                case StringId.FilterCriteriaToStringBinaryOperatorLess:
                return "<";
                case StringId.ColorPickPopupThemeColorsGroupCaption:
                return "צבעי ערכת נושא";
                case StringId.FilterCriteriaToStringFunctionUpper:
                return "העליון";
                case StringId.ManageRuleRankedValuesOfTheColumnsCellValues:
                return "% מהערכים בעמודה";
                case StringId.IconSetTitleTrafficLights3Rimmed:
                return "3 רמזורים (מסגרת)";
                case StringId.FilterCriteriaToStringFunctionPadRight:
                return "משטח ישר";
                case StringId.FormatRuleLessThanText:
                return "עיצוב תאים כי הם פחות מאשר";
                case StringId.CameraSettingsContrast:
                return "חדות:";
                case StringId.ManageRuleDataBarSolidFill:
                return "מילוי מלא";
                case StringId.FormatPredefinedAppearanceGreenText:
                return "טקסט ירוק";
                case StringId.ColorPickPopupStandardColorsGroupCaption:
                return "צבעים רגילים";
                case StringId.ManageRuleColorScale2:
                return "דו-צבעי";
                case StringId.FilterCriteriaToStringFunctionIsThisYear:
                return "השנה";
                case StringId.TakePictureMenuItem:
                return "לקחת את התמונות מהמצלמה";
                case StringId.ManageRuleRankedValuesTop:
                return "העליון";
                case StringId.FilterCriteriaToStringFunctionDateDiffTick:
                return "תאריך diff שנתות";
                case StringId.ManageRuleDataBarBorder:
                return "הגבול:";
                case StringId.CameraSettingsDesaturate:
                return "הפחתת רוויה:";
                case StringId.ProgressCancel:
                return "ביטול";
                case StringId.ManageRuleDataBarGradientFill:
                return "מילוי";
                case StringId.FormatPredefinedAppearanceBoldText:
                return "טקסט מודגש";
                case StringId.TakePictureDialogCapture:
                return "לכידת";
                case StringId.TabHeaderButtonNext:
                return "גלול ימינה";
                case StringId.FilterCriteriaToStringBinaryOperatorLessOrEqual:
                return "<=";
                case StringId.ManageRuleRankedValuesBottom:
                return "התחתון";
                case StringId.FilterCriteriaToStringFunctionDateDiffSecond:
                return "תאריך diff שנית";
                case StringId.CameraSettingsDefaults:
                return "איפוס לברירות המחדל";
                case StringId.IconSetTitleSigns3:
                return "3 שלטים";
                case StringId.ManageRuleDataBarNoBorder:
                return "ללא גבול";
                case StringId.FormatPredefinedAppearanceItalicText:
                return "טקסט נטוי";
                case StringId.ManageRuleColorScale3:
                return "סרגל תלת-צבעי";
                case StringId.ManageRuleThatContainFormatOnlyCellsWith:
                return "עיצוב תאים עם:";
                case StringId.ManageRuleDataBarDrawAxis:
                return "לצייר ציר";
                case StringId.FilterCriteriaToStringFunctionDateDiffMilliSecond:
                return "תאריך diff אלפיות השנייה";
                case StringId.CameraSettingsCaption:
                return "הגדרות המצלמה";
                case StringId.ProgressCancelPending:
                return "לבטל את המתנה";
                case StringId.ManageRuleDataBarSolidBorder:
                return "הגבול המלא";
                case StringId.ManageRuleDataBar:
                return "סרגל נתונים";
                case StringId.ManageRuleThatContainCellValue:
                return "ערך התא";
                case StringId.TabHeaderButtonUp:
                return "גלילה כלפי מעלה";
                case StringId.FilterCriteriaToStringBinaryOperatorLike:
                return "כמו";
                case StringId.FilterCriteriaToStringFunctionDateDiffMinute:
                return "תאריך diff דקות";
                case StringId.CameraSettingsResolution:
                return "רזולוציה:";
                case StringId.ManageRuleDataBarContext:
                return "ההקשר";
                case StringId.IconSetTitleTrafficLights4:
                return "4 רמזורים";
                case StringId.ManageRuleIconSets:
                return "ערכות סמלים";
                case StringId.ManageRuleThatContainDatesOccurring:
                return "תאריכים המתרחשים";
                case StringId.ManageRuleDataBarUseNegativeBar:
                return "שימוש שלילי בר";
                case StringId.FilterCriteriaToStringFunctionDateDiffHour:
                return "תאריך שעה diff";
                case StringId.ProgressLoadingData:
                return "טעינת נתונים";
                case StringId.CameraDeviceNotFound:
                return "מצלמת לא נמצאו. בדוק את חיבור מצלמת אינטרנט או הגדרות ההתקן.";
                case StringId.ManageRuleDataBarLTR:
                return "משמאל-לימין";
                case StringId.ManageRuleCommonMinimum:
                return "מינימום";
                case StringId.TabHeaderButtonDown:
                return "גלול למטה";
                case StringId.FilterCriteriaToStringBinaryOperatorMinus:
                return "-";
                case StringId.ManageRuleThatContainSpecificText:
                return "טקסט ספציפי";
                case StringId.IconSetTitleRedToBlack:
                return "אדום שחור";
                case StringId.CameraDeviceIsBusy:
                return "לא ניתן להשתמש המכשיר, כפי שהוא כבר נמצא בשימוש של יישום אחר.";
                case StringId.ManageRuleDataBarRTL:
                return "מימין-לשמאל";
                case StringId.TabHeaderButtonClose:
                return "סגור";
                case StringId.FilterCriteriaToStringFunctionDateDiffDay:
                return "תאריך יום diff";
                case StringId.ManageRuleThatContainBlanks:
                return "כדורי סרק";
                case StringId.FilterAggregateAvg:
                return "Avg";
                case StringId.FilterCriteriaToStringBinaryOperatorModulo:
                return "%";
                case StringId.ManageRuleIconSetsDisplayEachIconAccordingToTheseRules:
                return "הצגת כל סמל לפי כללים אלה:";
                case StringId.FilterCriteriaToStringFunctionDateDiffMonth:
                return "תאריך diff חודש";
                case StringId.CameraDesignTimeInfo:
                return "עיבוד אינו זמין בזמן העיצוב.";
                case StringId.ManageRuleThatContainNoBlanks:
                return "ללא רווחים";
                case StringId.FilterAggregateCount:
                return "ספירה";
                case StringId.FilterCriteriaToStringFunctionDateDiffYear:
                return "תאריך diff בשנה";
                case StringId.ManageRuleIconSetsReverseIconOrder:
                return "להפוך את סדר הסמלים";
                case StringId.OfficeNavigationOptions:
                return "אפשרויות ניווט";
                case StringId.ManageRuleThatContainErrors:
                return "שגיאות";
                case StringId.ManageRuleThatContainNoErrors:
                return "שגיאות";
                case StringId.ManageRuleIconSetsWhen:
                return "מתי";
                case StringId.ManageRuleIconSetsValueIs:
                return "הערך הוא";
                case StringId.ManageRuleSimpleRuleBaseFormat:
                return "עיצוב...";
                case StringId.ManageRuleAverageFormatValuesThatAre:
                return "תבנית ערכים:";
                case StringId.ManageRuleAverageTheAverageForTheSelectedRange:
                return "הממוצע של ערכי עמודה";
                default:
                return base.GetLocalizedString(id);
            }
        }
    }
}
