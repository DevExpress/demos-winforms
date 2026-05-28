Imports DevExpress.XtraGrid.Localization
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DevExpress.MailClient.Win.Localizer
    Public Class FarsiGridLocalizer
        Inherits GridLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As GridStringId) As String
            Select Case id
                Case GridStringId.FileIsNotFoundError
                Return "فایل {0} یافت نشد"
                Case GridStringId.ColumnViewExceptionMessage
                Return " شما می خواهید برای اصلاح ارزش"
                Case GridStringId.CustomizationCaption
                Return "سفارشی"
                Case GridStringId.CustomizationColumns
                Return "ستون"
                Case GridStringId.CustomizationBands
                Return "باند"
                Case GridStringId.FilterPanelCustomizeButton
                Return "ویرایش فیلتر"
                Case GridStringId.PopupFilterAll
                Return "(تمام)"
                Case GridStringId.PopupFilterCustom
                Return "(سفارشی)"
                Case GridStringId.PopupFilterBlanks
                Return "(فاصله ها)"
                Case GridStringId.PopupFilterNonBlanks
                Return "(بدون فاصله)"
                Case GridStringId.CustomFilterDialogFormCaption
                Return "پالایش خودکار سفارشی"
                Case GridStringId.CustomFilterDialogCaption
                Return "نمایش ردیفها جایی که:"
                Case GridStringId.CustomFilterDialogRadioAnd
                Return "& و"
                Case GridStringId.CustomFilterDialogRadioOr
                Return "O & r"
                Case GridStringId.CustomFilterDialogOkButton
                Return "& خوب"
                Case GridStringId.CustomFilterDialogClearFilter
                Return "فیلتر C & لیر"
                Case GridStringId.CustomFilterDialog2FieldCheck
                Return "زمینه"
                Case GridStringId.CustomFilterDialogCancelButton
                Return "& لغو"
                Case GridStringId.CustomFilterDialogEmptyValue
                Return "(یک مقدار را وارد کنید)"
                Case GridStringId.CustomFilterDialogEmptyOperator
                Return "(انتخاب اپراتور)"
                Case GridStringId.CustomFilterDialogHint
                Return "_ برای نمایش هر نویسه تکی #Use % به نمایندگی از هر سری از نویسه استفاده کنید"
                Case GridStringId.WindowErrorCaption
                Return "خطا"
                Case GridStringId.MenuFooterSum
                Return "مجموع"
                Case GridStringId.MenuFooterMin
                Return "دقیقه"
                Case GridStringId.MenuFooterMax
                Return "حداکثر"
                Case GridStringId.MenuFooterCount
                Return "تعداد دفعات مشاهده"
                Case GridStringId.MenuFooterAverage
                Return "به طور متوسط"
                Case GridStringId.MenuFooterNone
                Return "هیچ کدام"
                Case GridStringId.MenuFooterSumFormat
                Return "مجموع = {0:0. ##}"
                Case GridStringId.MenuFooterMinFormat
                Return "دقیقه = {0}"
                Case GridStringId.MenuFooterMaxFormat
                Return "حداکثر = {0}"
                Case GridStringId.MenuFooterCountFormat
                Return "{0}"
                Case GridStringId.MenuFooterAverageFormat
                Return "میانگین = {0:0. ##}"
                Case GridStringId.MenuColumnSortAscending
                Return "مرتب سازی افزایشی"
                Case GridStringId.MenuColumnSortDescending
                Return "مرتب سازی افزایشی"
                Case GridStringId.MenuColumnShowColumn
                Return "نمایش این ستون"
                Case GridStringId.MenuColumnRemoveColumn
                Return "پنهان کردن این ستون"
                Case GridStringId.MenuColumnGroup
                Return "گروه براساس این ستون"
                Case GridStringId.MenuColumnUnGroup
                Return "لغو گروه بندی"
                Case GridStringId.MenuColumnColumnCustomization
                Return "انتخابگر ستون"
                Case GridStringId.MenuColumnBandCustomization
                Return "نوار/ستون انتخاب کننده"
                Case GridStringId.MenuColumnBestFit
                Return "بهترین جا"
                Case GridStringId.MenuColumnFilter
                Return "می توانید فیلتر"
                Case GridStringId.MenuColumnClearFilter
                Return "روشن فیلتر"
                Case GridStringId.MenuColumnBestFitAllColumns
                Return "بهترین جا (همه ستون)"
                Case GridStringId.MenuColumnResetGroupSummarySort
                Return "پاک کردن مرتب سازی خلاصه"
                Case GridStringId.MenuColumnGroupSummarySortFormat
                Return "{1} توسط '{0}' - {2}"
                Case GridStringId.MenuColumnSumSummaryTypeDescription
                Return "مجموع"
                Case GridStringId.MenuColumnMinSummaryTypeDescription
                Return "دقیقه"
                Case GridStringId.MenuColumnMaxSummaryTypeDescription
                Return "حداکثر"
                Case GridStringId.MenuColumnCountSummaryTypeDescription
                Return "تعداد دفعات مشاهده"
                Case GridStringId.MenuColumnAverageSummaryTypeDescription
                Return "به طور متوسط"
                Case GridStringId.MenuColumnCustomSummaryTypeDescription
                Return "سفارشی"
                Case GridStringId.MenuColumnSortGroupBySummaryMenu
                Return "مرتب کردن بر اساس خلاصه"
                Case GridStringId.MenuColumnGroupIntervalMenu
                Return "گروه فاصله"
                Case GridStringId.MenuColumnGroupIntervalNone
                Return "هیچ کدام"
                Case GridStringId.MenuColumnGroupIntervalDay
                Return "روز"
                Case GridStringId.MenuColumnGroupIntervalMonth
                Return "ماه"
                Case GridStringId.MenuColumnGroupIntervalYear
                Return "سال"
                Case GridStringId.MenuColumnGroupIntervalSmart
                Return "هوشمند"
                Case GridStringId.MenuColumnGroupSummaryEditor
                Return "گروه تدوین خلاصه..."
                Case GridStringId.MenuColumnExpressionEditor
                Return "ویرایشگر بیان..."
                Case GridStringId.MenuColumnConditionalFormatting
                Return "شکلبندی شرطی"
                Case GridStringId.MenuColumnFilterMode
                Return "حالت پالایه"
                Case GridStringId.MenuColumnFilterModeValue
                Return "ارزش"
                Case GridStringId.MenuColumnFilterModeDisplayText
                Return "نمایش متن"
                Case GridStringId.MenuGroupPanelFullExpand
                Return "گسترش کامل"
                Case GridStringId.MenuGroupPanelFullCollapse
                Return "فروپاشی کامل"
                Case GridStringId.MenuGroupPanelClearGrouping
                Return "گروه بندی روشن"
                Case GridStringId.MenuGroupPanelShow
                Return "نمایش گروه بندی بر اساس جعبه"
                Case GridStringId.MenuGroupPanelHide
                Return "مخفی کردن گروه بندی بر اساس جعبه"
                Case GridStringId.PrintDesignerGridView
                Return "تنظیمات چاپ (شبکه مشاهده)"
                Case GridStringId.PrintDesignerCardView
                Return "تنظیمات چاپ (کارت مشاهده)"
                Case GridStringId.PrintDesignerLayoutView
                Return "تنظیمات چاپ (طرح مشاهده)"
                Case GridStringId.PrintDesignerBandedView
                Return "تنظیمات چاپ (بررسي مشاهده)"
                Case GridStringId.PrintDesignerBandHeader
                Return "سر صفحه گروه"
                Case GridStringId.MenuColumnGroupBox
                Return "گروه بندی بر اساس جعبه"
                Case GridStringId.CardViewNewCard
                Return "کارت جدید"
                Case GridStringId.CardViewQuickCustomizationButton
                Return "سفارشی کردن"
                Case GridStringId.CardViewQuickCustomizationButtonFilter
                Return "فیلتر"
                Case GridStringId.CardViewQuickCustomizationButtonSort
                Return "مرتب کردن بر اساس:"
                Case GridStringId.CardViewCaptionFormat
                Return "رکورد N {0}"
                Case GridStringId.GridGroupPanelText
                Return "یک سرصفحه ستون را به گروه براساس آن ستون بکشید"
                Case GridStringId.GridNewRowText
                Return "اینجا را کلیک کنید برای اضافه کردن سطر جدید"
                Case GridStringId.GridOutlookIntervals
                Return "قدیمی تر; ماه گذشته; اوایل این ماه; سه هفته پیش؛ دو هفته پیش؛ هفته گذشته;; دیروز; امروز; فردا;; هفته آینده؛ دو هفته بعد؛ سه هفته بعد؛ بعد از این ماه; ماه آینده؛ پس از ماه بعد;"
                Case GridStringId.PrintDesignerDescription
                Return "تنظیم گزینه های چاپ مختلف برای نمای کنونی."
                Case GridStringId.MenuFooterCustomFormat
                Return "سفارشی {0} ="
                Case GridStringId.MenuFooterCountGroupFormat
                Return "تعداد دفعات مشاهده = {0}"
                Case GridStringId.MenuColumnClearSorting
                Return "پاک کردن مرتب سازی"
                Case GridStringId.MenuColumnClearAllSorting
                Return "پاک کردن مرتب سازی همه"
                Case GridStringId.MenuColumnFilterEditor
                Return "ویرایشگر فیلتر..."
                Case GridStringId.MenuColumnAutoFilterRowHide
                Return "پنهان کردن خودکار فیلتر ردیف"
                Case GridStringId.MenuColumnAutoFilterRowShow
                Return "نشان دادن ردیف فیلتر خودرو"
                Case GridStringId.MenuColumnFindFilterHide
                Return "مخفی کردن صفحه پیدا کردن"
                Case GridStringId.MenuColumnFindFilterShow
                Return "پیدا کردن صفحه نمایش"
                Case GridStringId.FilterBuilderOkButton
                Return "& خوب"
                Case GridStringId.FilterBuilderCancelButton
                Return "& لغو"
                Case GridStringId.FilterBuilderApplyButton
                Return "& اعمال"
                Case GridStringId.FilterBuilderCaption
                Return "ویرایشگر فیلتر"
                Case GridStringId.CustomizationFormColumnHint
                Return "کشیدن و رها کردن اینجا برای سفارشی کردن طرح بندی"
                Case GridStringId.CustomizationFormBandHint
                Return "کشیدن و رها کردن عکس در اینجا برای سفارشی کردن طرح بندی"
                Case GridStringId.LayoutViewSingleModeBtnHint
                Return "یک کارت"
                Case GridStringId.LayoutViewRowModeBtnHint
                Return "یک ردیف"
                Case GridStringId.LayoutViewColumnModeBtnHint
                Return "یک ستون"
                Case GridStringId.LayoutViewMultiRowModeBtnHint
                Return "چندین ردیف"
                Case GridStringId.LayoutViewMultiColumnModeBtnHint
                Return "ستون های متعدد"
                Case GridStringId.LayoutViewCarouselModeBtnHint
                Return "حالت چرخ فلک"
                Case GridStringId.LayoutViewPanBtnHint
                Return "سوژه متحرک از روبرو"
                Case GridStringId.LayoutViewCustomizeBtnHint
                Return "سفارشی"
                Case GridStringId.LayoutViewCloseZoomBtnHintClose
                Return "بازگرداندن مشاهده"
                Case GridStringId.LayoutViewCloseZoomBtnHintZoom
                Return "حداکثر رساندن جزئیات"
                Case GridStringId.LayoutViewButtonApply
                Return "& اعمال"
                Case GridStringId.LayoutViewButtonPreview
                Return "نمایش & کارت های بیشتر"
                Case GridStringId.LayoutViewButtonOk
                Return "& خوب"
                Case GridStringId.LayoutViewButtonCancel
                Return "& لغو"
                Case GridStringId.LayoutViewButtonSaveLayout
                Return "س & و طرح..."
                Case GridStringId.LayoutViewButtonLoadLayout
                Return "& بار طرح..."
                Case GridStringId.LayoutViewFormLoadLayoutCaption
                Return "طرح بار"
                Case GridStringId.LayoutViewFormSaveLayoutCaption
                Return "ذخیره چیدمان"
                Case GridStringId.LayoutViewButtonCustomizeShow
                Return "& نمایش سفارشی"
                Case GridStringId.LayoutViewButtonCustomizeHide
                Return "پنهان کردن تنظیم & zation"
                Case GridStringId.LayoutViewButtonReset
                Return "& تنظیم مجدد قالب کارت"
                Case GridStringId.LayoutViewButtonShrinkToMinimum
                Return "& کوچک قالب کارت"
                Case GridStringId.LayoutViewPageTemplateCard
                Return "قالب کارت"
                Case GridStringId.LayoutViewPageViewLayout
                Return "مشاهده طرح"
                Case GridStringId.LayoutViewGroupCustomization
                Return "سفارشی"
                Case GridStringId.LayoutViewGroupCaptions
                Return "شرح"
                Case GridStringId.LayoutViewGroupIndents
                Return "تورفتگی"
                Case GridStringId.LayoutViewGroupHiddenItems
                Return "موارد پنهان"
                Case GridStringId.LayoutViewGroupTreeStructure
                Return "چیدمان نمای درختی"
                Case GridStringId.LayoutViewGroupPropertyGrid
                Return "املاک شبکه"
                Case GridStringId.LayoutViewLabelTextIndent
                Return "تورفتگی متن"
                Case GridStringId.LayoutViewLabelPadding
                Return "پارچه کشی"
                Case GridStringId.LayoutViewLabelSpacing
                Return "فاصله"
                Case GridStringId.LayoutViewLabelCaptionLocation
                Return "زمینه محل زیرنویس:"
                Case GridStringId.LayoutViewLabelGroupCaptionLocation
                Return "گروه زیرنویس محل:"
                Case GridStringId.LayoutViewLabelTextAlignment
                Return "شرح زمینه تراز متن:"
                Case GridStringId.LayoutViewGroupView
                Return "مشاهده"
                Case GridStringId.LayoutViewGroupLayout
                Return "چیدمان"
                Case GridStringId.LayoutViewGroupCards
                Return "کارت"
                Case GridStringId.LayoutViewGroupFields
                Return "زمینه های"
                Case GridStringId.LayoutViewLabelShowLines
                Return "نمایش خطوط"
                Case GridStringId.LayoutViewLabelShowHeaderPanel
                Return "صفحه نمایش سرصفحه"
                Case GridStringId.LayoutViewLabelShowFilterPanel
                Return "نمایش صفحه فیلتر:"
                Case GridStringId.LayoutViewLabelScrollVisibility
                Return "پیمایش دید:"
                Case GridStringId.LayoutViewLabelViewMode
                Return "حالت مشاهده:"
                Case GridStringId.LayoutViewLabelCardArrangeRule
                Return "ترتیب قانون:"
                Case GridStringId.LayoutViewLabelCardEdgeAlignment
                Return "تراز لبه کارت:"
                Case GridStringId.LayoutViewGroupIntervals
                Return "فواصل"
                Case GridStringId.LayoutViewLabelHorizontal
                Return "فاصله افقی"
                Case GridStringId.LayoutViewLabelVertical
                Return "فاصله عمودی"
                Case GridStringId.LayoutViewLabelShowCardCaption
                Return "نمایش زیرنویس"
                Case GridStringId.LayoutViewLabelShowCardExpandButton
                Return "نمایش گسترش دکمه"
                Case GridStringId.LayoutViewLabelShowCardBorder
                Return "نشان دادن مرز"
                Case GridStringId.LayoutViewLabelAllowFieldHotTracking
                Return "امکان ردیابی داغ"
                Case GridStringId.LayoutViewLabelShowFieldBorder
                Return "نشان دادن مرز"
                Case GridStringId.LayoutViewLabelShowFieldHint
                Return "نمایش نشانه"
                Case GridStringId.LayoutViewCustomizationFormCaption
                Return "LayoutView سفارشی"
                Case GridStringId.LayoutViewCustomizationFormDescription
                Return "طرح کارت با استفاده از کشیدن و رها کردن و منو سفارشی و پیش نمایش داده ها را در نمای چیدمان صفحه را سفارشی کنید."
                Case GridStringId.LayoutViewCardCaptionFormat
                Return "رکورد [{0} از {1}]"
                Case GridStringId.LayoutViewFieldCaptionFormat
                Return "{0}:"
                Case GridStringId.GroupSummaryEditorFormCaption
                Return "گروه تدوین خلاصه"
                Case GridStringId.GroupSummaryEditorFormOkButton
                Return "باشه"
                Case GridStringId.GroupSummaryEditorFormCancelButton
                Return "لغو"
                Case GridStringId.GroupSummaryEditorFormItemsTabCaption
                Return "موارد"
                Case GridStringId.GroupSummaryEditorFormOrderTabCaption
                Return "سفارش"
                Case GridStringId.GroupSummaryEditorSummaryMin
                Return "دقیقه"
                Case GridStringId.GroupSummaryEditorSummaryMax
                Return "حداکثر"
                Case GridStringId.GroupSummaryEditorSummaryAverage
                Return "به طور متوسط"
                Case GridStringId.GroupSummaryEditorSummarySum
                Return "مجموع"
                Case GridStringId.GroupSummaryEditorSummaryCount
                Return "تعداد دفعات مشاهده"
                Case GridStringId.FindControlFindButton
                Return "پیدا کردن"
                Case GridStringId.FindControlClearButton
                Return "روشن"
                Case GridStringId.SearchLookUpAddNewButton
                Return "افزودن جدید"
                Case GridStringId.MenuFooterAddSummaryItem
                Return "خلاصه جدید اضافه کنید"
                Case GridStringId.MenuFooterClearSummaryItems
                Return "پاک کردن موارد خلاصه"
                Case GridStringId.MenuShowSplitItem
                Return "اسپلیت"
                Case GridStringId.MenuHideSplitItem
                Return "حذف تقسیم بندی"
                Case GridStringId.ServerRequestError
                Return "خطا هنگام پردازش درخواست سرور ({0}...)"
                Case GridStringId.WindowWarningCaption
                Return "هشدار"
                Case GridStringId.EditFormUpdateButton
                Return "به روز رسانی"
                Case GridStringId.EditFormCancelButton
                Return "لغو"
                Case GridStringId.EditFormCancelMessage
                Return "شما می خواهید به لغو ویرایش"
                Case GridStringId.EditFormSaveMessage
                Return "داده های شما تغییر یافته است. آیا مایلید تغییرات را ذخیره کنید"
                Case GridStringId.CheckboxSelectorColumnCaption
                Return "انتخاب"
                Case GridStringId.FindNullPrompt
                Return "متن جستجو را وارد کنید..."
                Case GridStringId.SearchForBand
                Return "جستجو برای گروه..."


                Case Else
                Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
    Public Class ArabicGridLocalizer
        Inherits GridLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As GridStringId) As String
            Select Case id
                Case GridStringId.FileIsNotFoundError
                Return "لم يتم العثور على الملف {0}"
                Case GridStringId.ColumnViewExceptionMessage
                Return " هل تريد تصحيح القيمة؟"
                Case GridStringId.CustomizationCaption
                Return "التخصيص"
                Case GridStringId.CustomizationColumns
                Return "الأعمدة"
                Case GridStringId.CustomizationBands
                Return "الفرق"
                Case GridStringId.FilterPanelCustomizeButton
                Return "تحرير عامل تصفية"
                Case GridStringId.PopupFilterAll
                Return "(الكل)"
                Case GridStringId.PopupFilterCustom
                Return "(مخصص)"
                Case GridStringId.PopupFilterBlanks
                Return "(فراغات)"
                Case GridStringId.PopupFilterNonBlanks
                Return "(غير فراغات)"
                Case GridStringId.CustomFilterDialogFormCaption
                Return "تصفية تلقائية مخصصة"
                Case GridStringId.CustomFilterDialogCaption
                Return "إظهار الصفوف حيث:"
                Case GridStringId.CustomFilterDialogRadioAnd
                Return "آند و"
                Case GridStringId.CustomFilterDialogRadioOr
                Return "O آند r"
                Case GridStringId.CustomFilterDialogOkButton
                Return "آند موافق"
                Case GridStringId.CustomFilterDialogClearFilter
                Return "ج & لير تصفية"
                Case GridStringId.CustomFilterDialog2FieldCheck
                Return "الميدان"
                Case GridStringId.CustomFilterDialogCancelButton
                Return "آند إلغاء الأمر"
                Case GridStringId.CustomFilterDialogEmptyValue
                Return "(قم بإدخال قيمة)"
                Case GridStringId.CustomFilterDialogEmptyOperator
                Return "(تحديد عامل تشغيل)"
                Case GridStringId.CustomFilterDialogHint
                Return "استخدام _ لتمثيل أي حرف مفرد #Use % لتمثيل أية سلسلة من الأحرف"
                Case GridStringId.WindowErrorCaption
                Return "خطأ"
                Case GridStringId.MenuFooterSum
                Return "مجموع"
                Case GridStringId.MenuFooterMin
                Return "دقيقة"
                Case GridStringId.MenuFooterMax
                Return "ماكس"
                Case GridStringId.MenuFooterCount
                Return "العد"
                Case GridStringId.MenuFooterAverage
                Return "في المتوسط"
                Case GridStringId.MenuFooterNone
                Return "لا شيء"
                Case GridStringId.MenuFooterSumFormat
                Return "مجموع = {0:0. # #}"
                Case GridStringId.MenuFooterMinFormat
                Return "مين = {0}"
                Case GridStringId.MenuFooterMaxFormat
                Return "الحد الأقصى = {0}"
                Case GridStringId.MenuFooterCountFormat
                Return "{0}"
                Case GridStringId.MenuFooterAverageFormat
                Return "متوسط = {0:0. # #}"
                Case GridStringId.MenuColumnSortAscending
                Return "فرز تصاعدي"
                Case GridStringId.MenuColumnSortDescending
                Return "فرز تنازلي"
                Case GridStringId.MenuColumnShowColumn
                Return "إظهار هذا العمود"
                Case GridStringId.MenuColumnRemoveColumn
                Return "إخفاء هذا العمود"
                Case GridStringId.MenuColumnGroup
                Return "المجموعة حسب هذا العمود"
                Case GridStringId.MenuColumnUnGroup
                Return "فك تجميع"
                Case GridStringId.MenuColumnColumnCustomization
                Return "محدد العمود"
                Case GridStringId.MenuColumnBandCustomization
                Return "منتقي العمود/الفرقة"
                Case GridStringId.MenuColumnBestFit
                Return "أفضل احتواء"
                Case GridStringId.MenuColumnFilter
                Return "ويمكن تصفية"
                Case GridStringId.MenuColumnClearFilter
                Return "مسح عامل التصفية"
                Case GridStringId.MenuColumnBestFitAllColumns
                Return "أفضل احتواء (كافة الأعمدة)"
                Case GridStringId.MenuColumnResetGroupSummarySort
                Return "قم بفرز ملخص"
                Case GridStringId.MenuColumnGroupSummarySortFormat
                Return "{1} من '{0}'-{2}"
                Case GridStringId.MenuColumnSumSummaryTypeDescription
                Return "مجموع"
                Case GridStringId.MenuColumnMinSummaryTypeDescription
                Return "دقيقة"
                Case GridStringId.MenuColumnMaxSummaryTypeDescription
                Return "ماكس"
                Case GridStringId.MenuColumnCountSummaryTypeDescription
                Return "العد"
                Case GridStringId.MenuColumnAverageSummaryTypeDescription
                Return "في المتوسط"
                Case GridStringId.MenuColumnCustomSummaryTypeDescription
                Return "مخصص"
                Case GridStringId.MenuColumnSortGroupBySummaryMenu
                Return "فرز حسب الملخص"
                Case GridStringId.MenuColumnGroupIntervalMenu
                Return "الفاصل الزمني للمجموعة"
                Case GridStringId.MenuColumnGroupIntervalNone
                Return "لا شيء"
                Case GridStringId.MenuColumnGroupIntervalDay
                Return "اليوم"
                Case GridStringId.MenuColumnGroupIntervalMonth
                Return "في الشهر"
                Case GridStringId.MenuColumnGroupIntervalYear
                Return "السنة"
                Case GridStringId.MenuColumnGroupIntervalSmart
                Return "الذكية"
                Case GridStringId.MenuColumnGroupSummaryEditor
                Return "محرر ملخص المجموعة..."
                Case GridStringId.MenuColumnExpressionEditor
                Return "محرر التعبير..."
                Case GridStringId.MenuColumnConditionalFormatting
                Return "التنسيق الشرطي"
                Case GridStringId.MenuColumnFilterMode
                Return "وضع التصفية"
                Case GridStringId.MenuColumnFilterModeValue
                Return "القيمة"
                Case GridStringId.MenuColumnFilterModeDisplayText
                Return "عرض النص"
                Case GridStringId.MenuGroupPanelFullExpand
                Return "توسيع كامل"
                Case GridStringId.MenuGroupPanelFullCollapse
                Return "انهيار كامل"
                Case GridStringId.MenuGroupPanelClearGrouping
                Return "قم بتجميع"
                Case GridStringId.MenuGroupPanelShow
                Return "المجموعة إظهار مربع"
                Case GridStringId.MenuGroupPanelHide
                Return "المجموعة إخفاء مربع"
                Case GridStringId.PrintDesignerGridView
                Return "إعدادات الطباعة (عرض الشبكة)"
                Case GridStringId.PrintDesignerCardView
                Return "إعدادات الطباعة (بطاقة عرض)"
                Case GridStringId.PrintDesignerLayoutView
                Return "إعدادات الطباعة (عرض المخطط)"
                Case GridStringId.PrintDesignerBandedView
                Return "إعدادات الطباعة (عرض النطاقات)"
                Case GridStringId.PrintDesignerBandHeader
                Return "رأس الفرقة"
                Case GridStringId.MenuColumnGroupBox
                Return "تجميع حسب مربع"
                Case GridStringId.CardViewNewCard
                Return "بطاقة جديدة"
                Case GridStringId.CardViewQuickCustomizationButton
                Return "تخصيص"
                Case GridStringId.CardViewQuickCustomizationButtonFilter
                Return "عامل التصفية"
                Case GridStringId.CardViewQuickCustomizationButtonSort
                Return "الفرز:"
                Case GridStringId.CardViewCaptionFormat
                Return "سجل ن {0}"
                Case GridStringId.GridGroupPanelText
                Return "اسحب رأس عمود هنا إلى المجموعة حسب هذا العمود"
                Case GridStringId.GridNewRowText
                Return "انقر هنا لإضافة صف جديد"
                Case GridStringId.GridOutlookIntervals
                Return "كبار السن؛ في الشهر الماضي؛ وفي وقت سابق من هذا الشهر؛ ثلاثة أسابيع؛ أسبوعين؛ في الأسبوع الماضي؛؛؛ أمس؛ اليوم؛ غدا؛؛؛ الأسبوع المقبل؛ بعد أسبوعين؛ ثلاثة أسابيع؛ في وقت لاحق من هذا الشهر؛ الشهر القادم؛ تتجاوز الشهر المقبل؛"
                Case GridStringId.PrintDesignerDescription
                Return "إعداد خيارات الطباعة المختلفة لطريقة العرض الحالية."
                Case GridStringId.MenuFooterCustomFormat
                Return "مخصص = {0}"
                Case GridStringId.MenuFooterCountGroupFormat
                Return "عد = {0}"
                Case GridStringId.MenuColumnClearSorting
                Return "قم بفرز"
                Case GridStringId.MenuColumnClearAllSorting
                Return "قم بفرز جميع"
                Case GridStringId.MenuColumnFilterEditor
                Return "محرر تصفية..."
                Case GridStringId.MenuColumnAutoFilterRowHide
                Return "إخفاء صف التصفية التلقائية"
                Case GridStringId.MenuColumnAutoFilterRowShow
                Return "إظهار صف التصفية التلقائية"
                Case GridStringId.MenuColumnFindFilterHide
                Return "إخفاء لوحة البحث"
                Case GridStringId.MenuColumnFindFilterShow
                Return "إظهار لوحة البحث"
                Case GridStringId.FilterBuilderOkButton
                Return "آند موافق"
                Case GridStringId.FilterBuilderCancelButton
                Return "آند إلغاء الأمر"
                Case GridStringId.FilterBuilderApplyButton
                Return "آند تطبيق"
                Case GridStringId.FilterBuilderCaption
                Return "تحرير عامل تصفية"
                Case GridStringId.CustomizationFormColumnHint
                Return "سحب وإفلات الأعمدة هنا لتخصيص تخطيط"
                Case GridStringId.CustomizationFormBandHint
                Return "سحب وإسقاط عصابات هنا لتخصيص تخطيط"
                Case GridStringId.LayoutViewSingleModeBtnHint
                Return "بطاقة واحدة"
                Case GridStringId.LayoutViewRowModeBtnHint
                Return "صف واحد"
                Case GridStringId.LayoutViewColumnModeBtnHint
                Return "عمود واحد"
                Case GridStringId.LayoutViewMultiRowModeBtnHint
                Return "صفوف متعددة"
                Case GridStringId.LayoutViewMultiColumnModeBtnHint
                Return "أعمدة متعددة"
                Case GridStringId.LayoutViewCarouselModeBtnHint
                Return "وضع دائري"
                Case GridStringId.LayoutViewPanBtnHint
                Return "الغسل"
                Case GridStringId.LayoutViewCustomizeBtnHint
                Return "التخصيص"
                Case GridStringId.LayoutViewCloseZoomBtnHintClose
                Return "استعادة طريقة عرض"
                Case GridStringId.LayoutViewCloseZoomBtnHintZoom
                Return "تحقيق أقصى قدر من التفصيل"
                Case GridStringId.LayoutViewButtonApply
                Return "آند تطبيق"
                Case GridStringId.LayoutViewButtonPreview
                Return "إظهار & المزيد من البطاقات"
                Case GridStringId.LayoutViewButtonOk
                Return "آند موافق"
                Case GridStringId.LayoutViewButtonCancel
                Return "آند إلغاء الأمر"
                Case GridStringId.LayoutViewButtonSaveLayout
                Return "سا آند ve التخطيط..."
                Case GridStringId.LayoutViewButtonLoadLayout
                Return "آند تحميل تخطيط..."
                Case GridStringId.LayoutViewFormLoadLayoutCaption
                Return "تحميل تخطيط"
                Case GridStringId.LayoutViewFormSaveLayoutCaption
                Return "حفظ التخطيط"
                Case GridStringId.LayoutViewButtonCustomizeShow
                Return "آند إظهار التخصيص"
                Case GridStringId.LayoutViewButtonCustomizeHide
                Return "إخفاء خصيص & التعاقد"
                Case GridStringId.LayoutViewButtonReset
                Return "آند إعادة تعيين قالب بطاقة"
                Case GridStringId.LayoutViewButtonShrinkToMinimum
                Return "& انكمش قالب بطاقة"
                Case GridStringId.LayoutViewPageTemplateCard
                Return "قالب بطاقة"
                Case GridStringId.LayoutViewPageViewLayout
                Return "تخطيط طريقة العرض"
                Case GridStringId.LayoutViewGroupCustomization
                Return "التخصيص"
                Case GridStringId.LayoutViewGroupCaptions
                Return "التسميات التوضيحية"
                Case GridStringId.LayoutViewGroupIndents
                Return "المسافات البادئة"
                Case GridStringId.LayoutViewGroupHiddenItems
                Return "العناصر المخفية"
                Case GridStringId.LayoutViewGroupTreeStructure
                Return "تخطيط طريقة العرض الشجري"
                Case GridStringId.LayoutViewGroupPropertyGrid
                Return "شبكة الخصائص"
                Case GridStringId.LayoutViewLabelTextIndent
                Return "المسافات البادئة لنص"
                Case GridStringId.LayoutViewLabelPadding
                Return "الحشو"
                Case GridStringId.LayoutViewLabelSpacing
                Return "المباعدة بين الولادات"
                Case GridStringId.LayoutViewLabelCaptionLocation
                Return "موقع حقل التسمية التوضيحية:"
                Case GridStringId.LayoutViewLabelGroupCaptionLocation
                Return "مجموعة موقع تسمية توضيحية:"
                Case GridStringId.LayoutViewLabelTextAlignment
                Return "محاذاة نص التسمية التوضيحية الحقل:"
                Case GridStringId.LayoutViewGroupView
                Return "طريقة العرض"
                Case GridStringId.LayoutViewGroupLayout
                Return "تخطيط"
                Case GridStringId.LayoutViewGroupCards
                Return "بطاقات"
                Case GridStringId.LayoutViewGroupFields
                Return "الحقول"
                Case GridStringId.LayoutViewLabelShowLines
                Return "إظهار الخطوط"
                Case GridStringId.LayoutViewLabelShowHeaderPanel
                Return "إظهار لوحة رأس"
                Case GridStringId.LayoutViewLabelShowFilterPanel
                Return "إظهار لوحة المرشح:"
                Case GridStringId.LayoutViewLabelScrollVisibility
                Return "الرؤية التمرير:"
                Case GridStringId.LayoutViewLabelViewMode
                Return "وضع العرض:"
                Case GridStringId.LayoutViewLabelCardArrangeRule
                Return "تنظيم القاعدة:"
                Case GridStringId.LayoutViewLabelCardEdgeAlignment
                Return "محاذاة حافة البطاقة:"
                Case GridStringId.LayoutViewGroupIntervals
                Return "الفواصل الزمنية"
                Case GridStringId.LayoutViewLabelHorizontal
                Return "فاصل أفقي"
                Case GridStringId.LayoutViewLabelVertical
                Return "فاصل عمودي"
                Case GridStringId.LayoutViewLabelShowCardCaption
                Return "تظهر التسمية التوضيحية"
                Case GridStringId.LayoutViewLabelShowCardExpandButton
                Return "إظهار الزر توسيع"
                Case GridStringId.LayoutViewLabelShowCardBorder
                Return "إظهار الحدود"
                Case GridStringId.LayoutViewLabelAllowFieldHotTracking
                Return "السماح للتعقب الساخنة"
                Case GridStringId.LayoutViewLabelShowFieldBorder
                Return "إظهار الحدود"
                Case GridStringId.LayoutViewLabelShowFieldHint
                Return "إظهار تلميح"
                Case GridStringId.LayoutViewCustomizationFormCaption
                Return "التخصيص لايوتفيو"
                Case GridStringId.LayoutViewCardCaptionFormat
                Return "سجل [{0} من {1}]"
                Case GridStringId.LayoutViewFieldCaptionFormat
                Return "{0}:"
                Case GridStringId.GroupSummaryEditorFormCaption
                Return "محرر ملخص المجموعة"
                Case GridStringId.GroupSummaryEditorFormOkButton
                Return "موافق"
                Case GridStringId.GroupSummaryEditorFormCancelButton
                Return "إلغاء الأمر"
                Case GridStringId.GroupSummaryEditorFormItemsTabCaption
                Return "العناصر"
                Case GridStringId.GroupSummaryEditorFormOrderTabCaption
                Return "ترتيب"
                Case GridStringId.GroupSummaryEditorSummaryMin
                Return "دقيقة"
                Case GridStringId.GroupSummaryEditorSummaryMax
                Return "ماكس"
                Case GridStringId.GroupSummaryEditorSummaryAverage
                Return "في المتوسط"
                Case GridStringId.GroupSummaryEditorSummarySum
                Return "مجموع"
                Case GridStringId.GroupSummaryEditorSummaryCount
                Return "العد"
                Case GridStringId.FindControlFindButton
                Return "البحث عن"
                Case GridStringId.FindControlClearButton
                Return "واضحة"
                Case GridStringId.SearchLookUpAddNewButton
                Return "إضافة جديد"
                Case GridStringId.MenuFooterAddSummaryItem
                Return "إضافة ملخص جديد"
                Case GridStringId.MenuFooterClearSummaryItems
                Return "مسح العناصر الموجزة"
                Case GridStringId.MenuShowSplitItem
                Return "انقسام"
                Case GridStringId.MenuHideSplitItem
                Return "إزالة الانقسام"
                Case GridStringId.ServerRequestError
                Return "حدث خطأ أثناء معالجة طلب الملقم ({0}...)"
                Case GridStringId.WindowWarningCaption
                Return "تحذير"
                Case GridStringId.EditFormUpdateButton
                Return "التحديث"
                Case GridStringId.EditFormCancelButton
                Return "إلغاء الأمر"
                Case GridStringId.EditFormCancelMessage
                Return "هل تريد إلغاء التحرير؟"
                Case GridStringId.EditFormSaveMessage
                Return "يتم تعديل البيانات الخاصة بك. هل تريد حفظ التغييرات؟"
                Case GridStringId.CheckboxSelectorColumnCaption
                Return "التحديد"
                Case GridStringId.FindNullPrompt
                Return "أدخل نص للبحث..."
                Case GridStringId.SearchForBand
                Return "البحث عن عصابة..."
                Case Else
                Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class
    Public Class HebrewGridLocalizer
        Inherits GridLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As GridStringId) As String
            Select Case id
                Case GridStringId.FileIsNotFoundError
                Return "קובץ {0} לא נמצא"
                Case GridStringId.ColumnViewExceptionMessage
                Return " האם ברצונך לתקן את הערך?"
                Case GridStringId.CustomizationCaption
                Return "התאמה אישית"
                Case GridStringId.CustomizationColumns
                Return "עמודות"
                Case GridStringId.CustomizationBands
                Return "להקות"
                Case GridStringId.FilterPanelCustomizeButton
                Return "ערוך מסנן"
                Case GridStringId.PopupFilterAll
                Return "(הכל)"
                Case GridStringId.PopupFilterCustom
                Return "(מותאם אישית)"
                Case GridStringId.PopupFilterBlanks
                Return "(ריקים)"
                Case GridStringId.PopupFilterNonBlanks
                Return "(לא ריקים)"
                Case GridStringId.CustomFilterDialogFormCaption
                Return "בסינון אוטומטי מותאם אישית"
                Case GridStringId.CustomFilterDialogCaption
                Return "הצג שורות שבהן:"
                Case GridStringId.CustomFilterDialogRadioAnd
                Return "& ו"
                Case GridStringId.CustomFilterDialogRadioOr
                Return "O & r"
                Case GridStringId.CustomFilterDialogOkButton
                Return "& בסדר"
                Case GridStringId.CustomFilterDialogClearFilter
                Return "C & ליר לסנן"
                Case GridStringId.CustomFilterDialog2FieldCheck
                Return "שדה"
                Case GridStringId.CustomFilterDialogCancelButton
                Return "& לבטל"
                Case GridStringId.CustomFilterDialogEmptyValue
                Return "(הזן ערך)"
                Case GridStringId.CustomFilterDialogEmptyOperator
                Return "(בחר אופרטור)"
                Case GridStringId.CustomFilterDialogHint
                Return "השתמש _ כדי לייצג כל תו יחיד #Use % כדי לייצג כל סדרה של תווים"
                Case GridStringId.WindowErrorCaption
                Return "שגיאה"
                Case GridStringId.MenuFooterSum
                Return "סכום"
                Case GridStringId.MenuFooterMin
                Return "Min"
                Case GridStringId.MenuFooterMax
                Return "מקס"
                Case GridStringId.MenuFooterCount
                Return "ספירה"
                Case GridStringId.MenuFooterAverage
                Return "ממוצע"
                Case GridStringId.MenuFooterNone
                Return "אף אחד"
                Case GridStringId.MenuFooterSumFormat
                Return "סכום = {0:0. # #}"
                Case GridStringId.MenuFooterMinFormat
                Return "MIN = {0}"
                Case GridStringId.MenuFooterMaxFormat
                Return "מקס = {0}"
                Case GridStringId.MenuFooterCountFormat
                Return "{0}"
                Case GridStringId.MenuFooterAverageFormat
                Return "AVG = {0:0. # #}"
                Case GridStringId.MenuColumnSortAscending
                Return "מיין בסדר עולה"
                Case GridStringId.MenuColumnSortDescending
                Return "מיין בסדר יורד"
                Case GridStringId.MenuColumnShowColumn
                Return "הצג עמודה זו"
                Case GridStringId.MenuColumnRemoveColumn
                Return "הסתר עמודה זו"
                Case GridStringId.MenuColumnGroup
                Return "קבץ לפי עמודה זו"
                Case GridStringId.MenuColumnUnGroup
                Return "לפרק"
                Case GridStringId.MenuColumnColumnCustomization
                Return "בוחר עמודה"
                Case GridStringId.MenuColumnBandCustomization
                Return "בוחר עמודה/להקה"
                Case GridStringId.MenuColumnBestFit
                Return "מיטבית"
                Case GridStringId.MenuColumnFilter
                Return "באפשרותך לסנן"
                Case GridStringId.MenuColumnClearFilter
                Return "נקה מסנן"
                Case GridStringId.MenuColumnBestFitAllColumns
                Return "מיטבית (כל העמודות)"
                Case GridStringId.MenuColumnResetGroupSummarySort
                Return "נקה מיון סיכום"
                Case GridStringId.MenuColumnGroupSummarySortFormat
                Return "{1} מאת '{0}' - {2}"
                Case GridStringId.MenuColumnSumSummaryTypeDescription
                Return "סכום"
                Case GridStringId.MenuColumnMinSummaryTypeDescription
                Return "Min"
                Case GridStringId.MenuColumnMaxSummaryTypeDescription
                Return "מקס"
                Case GridStringId.MenuColumnCountSummaryTypeDescription
                Return "ספירה"
                Case GridStringId.MenuColumnAverageSummaryTypeDescription
                Return "ממוצע"
                Case GridStringId.MenuColumnCustomSummaryTypeDescription
                Return "מותאם אישית"
                Case GridStringId.MenuColumnSortGroupBySummaryMenu
                Return "מיין לפי סיכום"
                Case GridStringId.MenuColumnGroupIntervalMenu
                Return "מרווח בין קבוצות"
                Case GridStringId.MenuColumnGroupIntervalNone
                Return "אף אחד"
                Case GridStringId.MenuColumnGroupIntervalDay
                Return "היום"
                Case GridStringId.MenuColumnGroupIntervalMonth
                Return "חודש"
                Case GridStringId.MenuColumnGroupIntervalYear
                Return "השנה"
                Case GridStringId.MenuColumnGroupIntervalSmart
                Return "חכם"
                Case GridStringId.MenuColumnGroupSummaryEditor
                Return "עורך סיכום קבוצתית..."
                Case GridStringId.MenuColumnExpressionEditor
                Return "הביטוי עורך..."
                Case GridStringId.MenuColumnConditionalFormatting
                Return "המותנה"
                Case GridStringId.MenuColumnFilterMode
                Return "מסנן מצב"
                Case GridStringId.MenuColumnFilterModeValue
                Return "ערך"
                Case GridStringId.MenuColumnFilterModeDisplayText
                Return "הצגת טקסט"
                Case GridStringId.MenuGroupPanelFullExpand
                Return "מלא להרחיב"
                Case GridStringId.MenuGroupPanelFullCollapse
                Return "כווץ מלאה"
                Case GridStringId.MenuGroupPanelClearGrouping
                Return "קיבוץ ברור"
                Case GridStringId.MenuGroupPanelShow
                Return "הצג קבוצה על-ידי קופסה"
                Case GridStringId.MenuGroupPanelHide
                Return "הסתר קבוצה על-ידי קופסה"
                Case GridStringId.PrintDesignerGridView
                Return "הגדרות הדפסה (רשת נוף)"
                Case GridStringId.PrintDesignerCardView
                Return "הגדרות הדפסה (כרטיס תצוגה)"
                Case GridStringId.PrintDesignerLayoutView
                Return "הגדרות הדפסה (תצוגת פריסה)"
                Case GridStringId.PrintDesignerBandedView
                Return "הגדרות הדפסה (תצוגת המפוספסת)"
                Case GridStringId.PrintDesignerBandHeader
                Return "פס כותרת"
                Case GridStringId.MenuColumnGroupBox
                Return "קבוצה על-ידי קופסה"
                Case GridStringId.CardViewNewCard
                Return "כרטיס חדש"
                Case GridStringId.CardViewQuickCustomizationButton
                Return "התאמה אישית"
                Case GridStringId.CardViewQuickCustomizationButtonFilter
                Return "מסנן"
                Case GridStringId.CardViewQuickCustomizationButtonSort
                Return "מיון:"
                Case GridStringId.CardViewCaptionFormat
                Return "רשומה N {0}"
                Case GridStringId.GridGroupPanelText
                Return "גרור את כותרת עמודה לכאן קבוצה לפי עמודה זו"
                Case GridStringId.GridNewRowText
                Return "לחץ כאן כדי להוסיף שורה חדשה"
                Case GridStringId.GridOutlookIntervals
                Return "מבוגר; בחודש שעבר; מוקדם יותר החודש; 3 שבועות; שבועיים; בשבוע שעבר;; אתמול; כיום; . מחר;; בשבוע הבא; שבועיים משם; בעוד שלושה שבועות; מאוחר יותר החודש; בחודש הבא; מעבר בחודש הבא;"
                Case GridStringId.PrintDesignerDescription
                Return "להגדיר אפשרויות הדפסה שונות עבור התצוגה הנוכחית."
                Case GridStringId.MenuFooterCustomFormat
                Return "מותאם אישית = {0}"
                Case GridStringId.MenuFooterCountGroupFormat
                Return "ספירה = {0}"
                Case GridStringId.MenuColumnClearSorting
                Return "נקה מיון"
                Case GridStringId.MenuColumnClearAllSorting
                Return "נקה כל מיון"
                Case GridStringId.MenuColumnFilterEditor
                Return "לסנן עורך..."
                Case GridStringId.MenuColumnAutoFilterRowHide
                Return "להסתיר השורה סינון אוטומטי"
                Case GridStringId.MenuColumnAutoFilterRowShow
                Return "הצג אוטומטי מסנן שורה"
                Case GridStringId.MenuColumnFindFilterHide
                Return "להסתיר את החלונית חיפוש"
                Case GridStringId.MenuColumnFindFilterShow
                Return "להציג לוח חיפוש"
                Case GridStringId.FilterBuilderOkButton
                Return "& בסדר"
                Case GridStringId.FilterBuilderCancelButton
                Return "& לבטל"
                Case GridStringId.FilterBuilderApplyButton
                Return "& להחיל"
                Case GridStringId.FilterBuilderCaption
                Return "לסנן עורך"
                Case GridStringId.CustomizationFormColumnHint
                Return "גרור ושחרר עמודות כאן כדי להתאים אישית את הפריסה"
                Case GridStringId.CustomizationFormBandHint
                Return "גרור ושחרר להקות כאן כדי להתאים אישית את הפריסה"
                Case GridStringId.LayoutViewSingleModeBtnHint
                Return "קלף אחד"
                Case GridStringId.LayoutViewRowModeBtnHint
                Return "שורה אחת"
                Case GridStringId.LayoutViewColumnModeBtnHint
                Return "עמודה אחת"
                Case GridStringId.LayoutViewMultiRowModeBtnHint
                Return "שורות מרובות"
                Case GridStringId.LayoutViewMultiColumnModeBtnHint
                Return "עמודות מרובות"
                Case GridStringId.LayoutViewCarouselModeBtnHint
                Return "מצב קרוסלה"
                Case GridStringId.LayoutViewPanBtnHint
                Return "פאנינג"
                Case GridStringId.LayoutViewCustomizeBtnHint
                Return "התאמה אישית"
                Case GridStringId.LayoutViewCloseZoomBtnHintClose
                Return "לשחזר תצוגה"
                Case GridStringId.LayoutViewCloseZoomBtnHintZoom
                Return "למקסם את פירוט"
                Case GridStringId.LayoutViewButtonApply
                Return "& להחיל"
                Case GridStringId.LayoutViewButtonPreview
                Return "הצג & עוד קלפים"
                Case GridStringId.LayoutViewButtonOk
                Return "& בסדר"
                Case GridStringId.LayoutViewButtonCancel
                Return "& לבטל"
                Case GridStringId.LayoutViewButtonSaveLayout
                Return "Sa & ve פריסה..."
                Case GridStringId.LayoutViewButtonLoadLayout
                Return "& פריסת עומס..."
                Case GridStringId.LayoutViewFormLoadLayoutCaption
                Return "פריסת עומס"
                Case GridStringId.LayoutViewFormSaveLayoutCaption
                Return "שמירת פריסה"
                Case GridStringId.LayoutViewButtonCustomizeShow
                Return "& להראות התאמה אישית"
                Case GridStringId.LayoutViewButtonCustomizeHide
                Return "הסתר צע התאמה אישית של & הסינכרון"
                Case GridStringId.LayoutViewButtonReset
                Return "& איפוס תבנית כרטיס"
                Case GridStringId.LayoutViewButtonShrinkToMinimum
                Return "& לכווץ תבנית כרטיס"
                Case GridStringId.LayoutViewPageTemplateCard
                Return "תבנית כרטיס"
                Case GridStringId.LayoutViewPageViewLayout
                Return "תצוגת פריסה"
                Case GridStringId.LayoutViewGroupCustomization
                Return "התאמה אישית"
                Case GridStringId.LayoutViewGroupCaptions
                Return "כיתובים"
                Case GridStringId.LayoutViewGroupIndents
                Return "כניסות"
                Case GridStringId.LayoutViewGroupHiddenItems
                Return "פריטים מוסתרים"
                Case GridStringId.LayoutViewGroupTreeStructure
                Return "תצוגת עץ פריסה"
                Case GridStringId.LayoutViewGroupPropertyGrid
                Return "המאפיין רשת"
                Case GridStringId.LayoutViewLabelTextIndent
                Return "כניסות טקסט"
                Case GridStringId.LayoutViewLabelPadding
                Return "ריפוד"
                Case GridStringId.LayoutViewLabelSpacing
                Return "מרווח"
                Case GridStringId.LayoutViewLabelCaptionLocation
                Return "מיקום שדה כיתוב:"
                Case GridStringId.LayoutViewLabelGroupCaptionLocation
                Return "קבוצה הכיתוב מיקום:"
                Case GridStringId.LayoutViewLabelTextAlignment
                Return "יישור טקסט כיתוב השדה:"
                Case GridStringId.LayoutViewGroupView
                Return "תצוגה"
                Case GridStringId.LayoutViewGroupLayout
                Return "פריסה"
                Case GridStringId.LayoutViewGroupCards
                Return "קלפים"
                Case GridStringId.LayoutViewGroupFields
                Return "שדות"
                Case GridStringId.LayoutViewLabelShowLines
                Return "הצג שורות"
                Case GridStringId.LayoutViewLabelShowHeaderPanel
                Return "להציג כותרת לוח"
                Case GridStringId.LayoutViewLabelShowFilterPanel
                Return "הצג את החלונית ' מסנן ':"
                Case GridStringId.LayoutViewLabelScrollVisibility
                Return "ניראות גלילה:"
                Case GridStringId.LayoutViewLabelViewMode
                Return "מצב תצוגה:"
                Case GridStringId.LayoutViewLabelCardArrangeRule
                Return "לארגן את הכלל:"
                Case GridStringId.LayoutViewLabelCardEdgeAlignment
                Return "יישור הקצה כרטיס:"
                Case GridStringId.LayoutViewGroupIntervals
                Return "מרווחי"
                Case GridStringId.LayoutViewLabelHorizontal
                Return "מרווח אופקי"
                Case GridStringId.LayoutViewLabelVertical
                Return "מרווח אנכי"
                Case GridStringId.LayoutViewLabelShowCardCaption
                Return "הצג כיתוב"
                Case GridStringId.LayoutViewLabelShowCardExpandButton
                Return "הצג לחצן הרחב"
                Case GridStringId.LayoutViewLabelShowCardBorder
                Return "הצג גבול"
                Case GridStringId.LayoutViewLabelAllowFieldHotTracking
                Return "לאפשר מעקב חם"
                Case GridStringId.LayoutViewLabelShowFieldBorder
                Return "הצג גבול"
                Case GridStringId.LayoutViewLabelShowFieldHint
                Return "רמז להראות"
                Case GridStringId.LayoutViewCustomizationFormCaption
                Return "התאמה LayoutView"
                Case GridStringId.LayoutViewCustomizationFormDescription
                Return "להתאים אישית את פריסת הכרטיס באמצעות גרור-ושחרר, התאמה אישית של תפריט תצוגה מקדימה של נתונים בעמוד בתצוגת פריסה."
                Case GridStringId.LayoutViewCardCaptionFormat
                Return "שיא [{0} של {1}]"
                Case GridStringId.LayoutViewFieldCaptionFormat
                Return "{0}:"
                Case GridStringId.GroupSummaryEditorFormCaption
                Return "עורך סיכום קבוצתית"
                Case GridStringId.GroupSummaryEditorFormOkButton
                Return "אוקיי"
                Case GridStringId.GroupSummaryEditorFormCancelButton
                Return "ביטול"
                Case GridStringId.GroupSummaryEditorFormItemsTabCaption
                Return "פריטים"
                Case GridStringId.GroupSummaryEditorFormOrderTabCaption
                Return "סדר"
                Case GridStringId.GroupSummaryEditorSummaryMin
                Return "Min"
                Case GridStringId.GroupSummaryEditorSummaryMax
                Return "מקס"
                Case GridStringId.GroupSummaryEditorSummaryAverage
                Return "ממוצע"
                Case GridStringId.GroupSummaryEditorSummarySum
                Return "סכום"
                Case GridStringId.GroupSummaryEditorSummaryCount
                Return "ספירה"
                Case GridStringId.FindControlFindButton
                Return "למצוא"
                Case GridStringId.FindControlClearButton
                Return "ברור"
                Case GridStringId.SearchLookUpAddNewButton
                Return "הוסף כתובת חדשה"
                Case GridStringId.MenuFooterAddSummaryItem
                Return "הוספת סיכום חדש"
                Case GridStringId.MenuFooterClearSummaryItems
                Return "נקה פריטים סיכום"
                Case GridStringId.MenuShowSplitItem
                Return "פיצול"
                Case GridStringId.MenuHideSplitItem
                Return "הסר פיצול"
                Case GridStringId.ServerRequestError
                Return "אירעה שגיאה בעת עיבוד בקשת שרת ({0}...)"
                Case GridStringId.WindowWarningCaption
                Return "אזהרה"
                Case GridStringId.EditFormUpdateButton
                Return "עדכון"
                Case GridStringId.EditFormCancelButton
                Return "ביטול"
                Case GridStringId.EditFormCancelMessage
                Return "האם ברצונך לבטל עריכה?"
                Case GridStringId.EditFormSaveMessage
                Return "הנתונים שלך משתנה. האם ברצונך לשמור את השינויים?"
                Case GridStringId.CheckboxSelectorColumnCaption
                Return "הבחירה"
                Case GridStringId.FindNullPrompt
                Return "הזן טקסט לחיפוש..."
                Case GridStringId.SearchForBand
                Return "החיפוש אחר להקה..."

                Case Else
                Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class
End Namespace
