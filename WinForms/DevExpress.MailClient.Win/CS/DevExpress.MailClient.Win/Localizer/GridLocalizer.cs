using DevExpress.XtraGrid.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.MailClient.Win.Localizer {
    public class FarsiGridLocalizer : GridLocalizer {
        public override string GetLocalizedString(GridStringId id) {
            switch(id) {
                case GridStringId.FileIsNotFoundError:
                return "فایل {0} یافت نشد";
                case GridStringId.ColumnViewExceptionMessage:
                return " شما می خواهید برای اصلاح ارزش";
                case GridStringId.CustomizationCaption:
                return "سفارشی";
                case GridStringId.CustomizationColumns:
                return "ستون";
                case GridStringId.CustomizationBands:
                return "باند";
                case GridStringId.FilterPanelCustomizeButton:
                return "ویرایش فیلتر";
                case GridStringId.PopupFilterAll:
                return "(تمام)";
                case GridStringId.PopupFilterCustom:
                return "(سفارشی)";
                case GridStringId.PopupFilterBlanks:
                return "(فاصله ها)";
                case GridStringId.PopupFilterNonBlanks:
                return "(بدون فاصله)";
                case GridStringId.CustomFilterDialogFormCaption:
                return "پالایش خودکار سفارشی";
                case GridStringId.CustomFilterDialogCaption:
                return "نمایش ردیفها جایی که:";
                case GridStringId.CustomFilterDialogRadioAnd:
                return "& و";
                case GridStringId.CustomFilterDialogRadioOr:
                return "O & r";
                case GridStringId.CustomFilterDialogOkButton:
                return "& خوب";
                case GridStringId.CustomFilterDialogClearFilter:
                return "فیلتر C & لیر";
                case GridStringId.CustomFilterDialog2FieldCheck:
                return "زمینه";
                case GridStringId.CustomFilterDialogCancelButton:
                return "& لغو";
                case GridStringId.CustomFilterDialogEmptyValue:
                return "(یک مقدار را وارد کنید)";
                case GridStringId.CustomFilterDialogEmptyOperator:
                return "(انتخاب اپراتور)";
                case GridStringId.CustomFilterDialogHint:
                return "_ برای نمایش هر نویسه تکی #Use % به نمایندگی از هر سری از نویسه استفاده کنید";
                case GridStringId.WindowErrorCaption:
                return "خطا";
                case GridStringId.MenuFooterSum:
                return "مجموع";
                case GridStringId.MenuFooterMin:
                return "دقیقه";
                case GridStringId.MenuFooterMax:
                return "حداکثر";
                case GridStringId.MenuFooterCount:
                return "تعداد دفعات مشاهده";
                case GridStringId.MenuFooterAverage:
                return "به طور متوسط";
                case GridStringId.MenuFooterNone:
                return "هیچ کدام";
                case GridStringId.MenuFooterSumFormat:
                return "مجموع = {0:0. ##}";
                case GridStringId.MenuFooterMinFormat:
                return "دقیقه = {0}";
                case GridStringId.MenuFooterMaxFormat:
                return "حداکثر = {0}";
                case GridStringId.MenuFooterCountFormat:
                return "{0}";
                case GridStringId.MenuFooterAverageFormat:
                return "میانگین = {0:0. ##}";
                case GridStringId.MenuColumnSortAscending:
                return "مرتب سازی افزایشی";
                case GridStringId.MenuColumnSortDescending:
                return "مرتب سازی افزایشی";
                case GridStringId.MenuColumnShowColumn:
                return "نمایش این ستون";
                case GridStringId.MenuColumnRemoveColumn:
                return "پنهان کردن این ستون";
                case GridStringId.MenuColumnGroup:
                return "گروه براساس این ستون";
                case GridStringId.MenuColumnUnGroup:
                return "لغو گروه بندی";
                case GridStringId.MenuColumnColumnCustomization:
                return "انتخابگر ستون";
                case GridStringId.MenuColumnBandCustomization:
                return "نوار/ستون انتخاب کننده";
                case GridStringId.MenuColumnBestFit:
                return "بهترین جا";
                case GridStringId.MenuColumnFilter:
                return "می توانید فیلتر";
                case GridStringId.MenuColumnClearFilter:
                return "روشن فیلتر";
                case GridStringId.MenuColumnBestFitAllColumns:
                return "بهترین جا (همه ستون)";
                case GridStringId.MenuColumnResetGroupSummarySort:
                return "پاک کردن مرتب سازی خلاصه";
                case GridStringId.MenuColumnGroupSummarySortFormat:
                return "{1} توسط '{0}' - {2}";
                case GridStringId.MenuColumnSumSummaryTypeDescription:
                return "مجموع";
                case GridStringId.MenuColumnMinSummaryTypeDescription:
                return "دقیقه";
                case GridStringId.MenuColumnMaxSummaryTypeDescription:
                return "حداکثر";
                case GridStringId.MenuColumnCountSummaryTypeDescription:
                return "تعداد دفعات مشاهده";
                case GridStringId.MenuColumnAverageSummaryTypeDescription:
                return "به طور متوسط";
                case GridStringId.MenuColumnCustomSummaryTypeDescription:
                return "سفارشی";
                case GridStringId.MenuColumnSortGroupBySummaryMenu:
                return "مرتب کردن بر اساس خلاصه";
                case GridStringId.MenuColumnGroupIntervalMenu:
                return "گروه فاصله";
                case GridStringId.MenuColumnGroupIntervalNone:
                return "هیچ کدام";
                case GridStringId.MenuColumnGroupIntervalDay:
                return "روز";
                case GridStringId.MenuColumnGroupIntervalMonth:
                return "ماه";
                case GridStringId.MenuColumnGroupIntervalYear:
                return "سال";
                case GridStringId.MenuColumnGroupIntervalSmart:
                return "هوشمند";
                case GridStringId.MenuColumnGroupSummaryEditor:
                return "گروه تدوین خلاصه...";
                case GridStringId.MenuColumnExpressionEditor:
                return "ویرایشگر بیان...";
                case GridStringId.MenuColumnConditionalFormatting:
                return "شکلبندی شرطی";
                case GridStringId.MenuColumnFilterMode:
                return "حالت پالایه";
                case GridStringId.MenuColumnFilterModeValue:
                return "ارزش";
                case GridStringId.MenuColumnFilterModeDisplayText:
                return "نمایش متن";
                case GridStringId.MenuGroupPanelFullExpand:
                return "گسترش کامل";
                case GridStringId.MenuGroupPanelFullCollapse:
                return "فروپاشی کامل";
                case GridStringId.MenuGroupPanelClearGrouping:
                return "گروه بندی روشن";
                case GridStringId.MenuGroupPanelShow:
                return "نمایش گروه بندی بر اساس جعبه";
                case GridStringId.MenuGroupPanelHide:
                return "مخفی کردن گروه بندی بر اساس جعبه";
                case GridStringId.PrintDesignerGridView:
                return "تنظیمات چاپ (شبکه مشاهده)";
                case GridStringId.PrintDesignerCardView:
                return "تنظیمات چاپ (کارت مشاهده)";
                case GridStringId.PrintDesignerLayoutView:
                return "تنظیمات چاپ (طرح مشاهده)";
                case GridStringId.PrintDesignerBandedView:
                return "تنظیمات چاپ (بررسي مشاهده)";
                case GridStringId.PrintDesignerBandHeader:
                return "سر صفحه گروه";
                case GridStringId.MenuColumnGroupBox:
                return "گروه بندی بر اساس جعبه";
                case GridStringId.CardViewNewCard:
                return "کارت جدید";
                case GridStringId.CardViewQuickCustomizationButton:
                return "سفارشی کردن";
                case GridStringId.CardViewQuickCustomizationButtonFilter:
                return "فیلتر";
                case GridStringId.CardViewQuickCustomizationButtonSort:
                return "مرتب کردن بر اساس:";
                case GridStringId.CardViewCaptionFormat:
                return "رکورد N {0}";
                case GridStringId.GridGroupPanelText:
                return "یک سرصفحه ستون را به گروه براساس آن ستون بکشید";
                case GridStringId.GridNewRowText:
                return "اینجا را کلیک کنید برای اضافه کردن سطر جدید";
                case GridStringId.GridOutlookIntervals:
                return "قدیمی تر; ماه گذشته; اوایل این ماه; سه هفته پیش؛ دو هفته پیش؛ هفته گذشته;; دیروز; امروز; فردا;; هفته آینده؛ دو هفته بعد؛ سه هفته بعد؛ بعد از این ماه; ماه آینده؛ پس از ماه بعد;";
                case GridStringId.PrintDesignerDescription:
                return "تنظیم گزینه های چاپ مختلف برای نمای کنونی.";
                case GridStringId.MenuFooterCustomFormat:
                return "سفارشی {0} =";
                case GridStringId.MenuFooterCountGroupFormat:
                return "تعداد دفعات مشاهده = {0}";
                case GridStringId.MenuColumnClearSorting:
                return "پاک کردن مرتب سازی";
                case GridStringId.MenuColumnClearAllSorting:
                return "پاک کردن مرتب سازی همه";
                case GridStringId.MenuColumnFilterEditor:
                return "ویرایشگر فیلتر...";
                case GridStringId.MenuColumnAutoFilterRowHide:
                return "پنهان کردن خودکار فیلتر ردیف";
                case GridStringId.MenuColumnAutoFilterRowShow:
                return "نشان دادن ردیف فیلتر خودرو";
                case GridStringId.MenuColumnFindFilterHide:
                return "مخفی کردن صفحه پیدا کردن";
                case GridStringId.MenuColumnFindFilterShow:
                return "پیدا کردن صفحه نمایش";
                case GridStringId.FilterBuilderOkButton:
                return "& خوب";
                case GridStringId.FilterBuilderCancelButton:
                return "& لغو";
                case GridStringId.FilterBuilderApplyButton:
                return "& اعمال";
                case GridStringId.FilterBuilderCaption:
                return "ویرایشگر فیلتر";
                case GridStringId.CustomizationFormColumnHint:
                return "کشیدن و رها کردن اینجا برای سفارشی کردن طرح بندی";
                case GridStringId.CustomizationFormBandHint:
                return "کشیدن و رها کردن عکس در اینجا برای سفارشی کردن طرح بندی";
                case GridStringId.LayoutViewSingleModeBtnHint:
                return "یک کارت";
                case GridStringId.LayoutViewRowModeBtnHint:
                return "یک ردیف";
                case GridStringId.LayoutViewColumnModeBtnHint:
                return "یک ستون";
                case GridStringId.LayoutViewMultiRowModeBtnHint:
                return "چندین ردیف";
                case GridStringId.LayoutViewMultiColumnModeBtnHint:
                return "ستون های متعدد";
                case GridStringId.LayoutViewCarouselModeBtnHint:
                return "حالت چرخ فلک";
                case GridStringId.LayoutViewPanBtnHint:
                return "سوژه متحرک از روبرو";
                case GridStringId.LayoutViewCustomizeBtnHint:
                return "سفارشی";
                case GridStringId.LayoutViewCloseZoomBtnHintClose:
                return "بازگرداندن مشاهده";
                case GridStringId.LayoutViewCloseZoomBtnHintZoom:
                return "حداکثر رساندن جزئیات";
                case GridStringId.LayoutViewButtonApply:
                return "& اعمال";
                case GridStringId.LayoutViewButtonPreview:
                return "نمایش & کارت های بیشتر";
                case GridStringId.LayoutViewButtonOk:
                return "& خوب";
                case GridStringId.LayoutViewButtonCancel:
                return "& لغو";
                case GridStringId.LayoutViewButtonSaveLayout:
                return "س & و طرح...";
                case GridStringId.LayoutViewButtonLoadLayout:
                return "& بار طرح...";
                case GridStringId.LayoutViewFormLoadLayoutCaption:
                return "طرح بار";
                case GridStringId.LayoutViewFormSaveLayoutCaption:
                return "ذخیره چیدمان";
                case GridStringId.LayoutViewButtonCustomizeShow:
                return "& نمایش سفارشی";
                case GridStringId.LayoutViewButtonCustomizeHide:
                return "پنهان کردن تنظیم & zation";
                case GridStringId.LayoutViewButtonReset:
                return "& تنظیم مجدد قالب کارت";
                case GridStringId.LayoutViewButtonShrinkToMinimum:
                return "& کوچک قالب کارت";
                case GridStringId.LayoutViewPageTemplateCard:
                return "قالب کارت";
                case GridStringId.LayoutViewPageViewLayout:
                return "مشاهده طرح";
                case GridStringId.LayoutViewGroupCustomization:
                return "سفارشی";
                case GridStringId.LayoutViewGroupCaptions:
                return "شرح";
                case GridStringId.LayoutViewGroupIndents:
                return "تورفتگی";
                case GridStringId.LayoutViewGroupHiddenItems:
                return "موارد پنهان";
                case GridStringId.LayoutViewGroupTreeStructure:
                return "چیدمان نمای درختی";
                case GridStringId.LayoutViewGroupPropertyGrid:
                return "املاک شبکه";
                case GridStringId.LayoutViewLabelTextIndent:
                return "تورفتگی متن";
                case GridStringId.LayoutViewLabelPadding:
                return "پارچه کشی";
                case GridStringId.LayoutViewLabelSpacing:
                return "فاصله";
                case GridStringId.LayoutViewLabelCaptionLocation:
                return "زمینه محل زیرنویس:";
                case GridStringId.LayoutViewLabelGroupCaptionLocation:
                return "گروه زیرنویس محل:";
                case GridStringId.LayoutViewLabelTextAlignment:
                return "شرح زمینه تراز متن:";
                case GridStringId.LayoutViewGroupView:
                return "مشاهده";
                case GridStringId.LayoutViewGroupLayout:
                return "چیدمان";
                case GridStringId.LayoutViewGroupCards:
                return "کارت";
                case GridStringId.LayoutViewGroupFields:
                return "زمینه های";
                case GridStringId.LayoutViewLabelShowLines:
                return "نمایش خطوط";
                case GridStringId.LayoutViewLabelShowHeaderPanel:
                return "صفحه نمایش سرصفحه";
                case GridStringId.LayoutViewLabelShowFilterPanel:
                return "نمایش صفحه فیلتر:";
                case GridStringId.LayoutViewLabelScrollVisibility:
                return "پیمایش دید:";
                case GridStringId.LayoutViewLabelViewMode:
                return "حالت مشاهده:";
                case GridStringId.LayoutViewLabelCardArrangeRule:
                return "ترتیب قانون:";
                case GridStringId.LayoutViewLabelCardEdgeAlignment:
                return "تراز لبه کارت:";
                case GridStringId.LayoutViewGroupIntervals:
                return "فواصل";
                case GridStringId.LayoutViewLabelHorizontal:
                return "فاصله افقی";
                case GridStringId.LayoutViewLabelVertical:
                return "فاصله عمودی";
                case GridStringId.LayoutViewLabelShowCardCaption:
                return "نمایش زیرنویس";
                case GridStringId.LayoutViewLabelShowCardExpandButton:
                return "نمایش گسترش دکمه";
                case GridStringId.LayoutViewLabelShowCardBorder:
                return "نشان دادن مرز";
                case GridStringId.LayoutViewLabelAllowFieldHotTracking:
                return "امکان ردیابی داغ";
                case GridStringId.LayoutViewLabelShowFieldBorder:
                return "نشان دادن مرز";
                case GridStringId.LayoutViewLabelShowFieldHint:
                return "نمایش نشانه";
                case GridStringId.LayoutViewCustomizationFormCaption:
                return "LayoutView سفارشی";
                case GridStringId.LayoutViewCustomizationFormDescription:
                return "طرح کارت با استفاده از کشیدن و رها کردن و منو سفارشی و پیش نمایش داده ها را در نمای چیدمان صفحه را سفارشی کنید.";
                case GridStringId.LayoutViewCardCaptionFormat:
                return "رکورد [{0} از {1}]";
                case GridStringId.LayoutViewFieldCaptionFormat:
                return "{0}:";
                case GridStringId.GroupSummaryEditorFormCaption:
                return "گروه تدوین خلاصه";
                case GridStringId.GroupSummaryEditorFormOkButton:
                return "باشه";
                case GridStringId.GroupSummaryEditorFormCancelButton:
                return "لغو";
                case GridStringId.GroupSummaryEditorFormItemsTabCaption:
                return "موارد";
                case GridStringId.GroupSummaryEditorFormOrderTabCaption:
                return "سفارش";
                case GridStringId.GroupSummaryEditorSummaryMin:
                return "دقیقه";
                case GridStringId.GroupSummaryEditorSummaryMax:
                return "حداکثر";
                case GridStringId.GroupSummaryEditorSummaryAverage:
                return "به طور متوسط";
                case GridStringId.GroupSummaryEditorSummarySum:
                return "مجموع";
                case GridStringId.GroupSummaryEditorSummaryCount:
                return "تعداد دفعات مشاهده";
                case GridStringId.FindControlFindButton:
                return "پیدا کردن";
                case GridStringId.FindControlClearButton:
                return "روشن";
                case GridStringId.SearchLookUpAddNewButton:
                return "افزودن جدید";
                case GridStringId.MenuFooterAddSummaryItem:
                return "خلاصه جدید اضافه کنید";
                case GridStringId.MenuFooterClearSummaryItems:
                return "پاک کردن موارد خلاصه";
                case GridStringId.MenuShowSplitItem:
                return "اسپلیت";
                case GridStringId.MenuHideSplitItem:
                return "حذف تقسیم بندی";
                case GridStringId.ServerRequestError:
                return "خطا هنگام پردازش درخواست سرور ({0}...)";
                case GridStringId.WindowWarningCaption:
                return "هشدار";
                case GridStringId.EditFormUpdateButton:
                return "به روز رسانی";
                case GridStringId.EditFormCancelButton:
                return "لغو";
                case GridStringId.EditFormCancelMessage:
                return "شما می خواهید به لغو ویرایش";
                case GridStringId.EditFormSaveMessage:
                return "داده های شما تغییر یافته است. آیا مایلید تغییرات را ذخیره کنید";
                case GridStringId.CheckboxSelectorColumnCaption:
                return "انتخاب";
                case GridStringId.FindNullPrompt:
                return "متن جستجو را وارد کنید...";
                case GridStringId.SearchForBand:
                return "جستجو برای گروه...";


                default:
                return base.GetLocalizedString(id);
            }

        }
    }
    public class ArabicGridLocalizer : GridLocalizer {
        public override string GetLocalizedString(GridStringId id) {
            switch(id) {
                case GridStringId.FileIsNotFoundError:
                return "لم يتم العثور على الملف {0}";
                case GridStringId.ColumnViewExceptionMessage:
                return " هل تريد تصحيح القيمة؟";
                case GridStringId.CustomizationCaption:
                return "التخصيص";
                case GridStringId.CustomizationColumns:
                return "الأعمدة";
                case GridStringId.CustomizationBands:
                return "الفرق";
                case GridStringId.FilterPanelCustomizeButton:
                return "تحرير عامل تصفية";
                case GridStringId.PopupFilterAll:
                return "(الكل)";
                case GridStringId.PopupFilterCustom:
                return "(مخصص)";
                case GridStringId.PopupFilterBlanks:
                return "(فراغات)";
                case GridStringId.PopupFilterNonBlanks:
                return "(غير فراغات)";
                case GridStringId.CustomFilterDialogFormCaption:
                return "تصفية تلقائية مخصصة";
                case GridStringId.CustomFilterDialogCaption:
                return "إظهار الصفوف حيث:";
                case GridStringId.CustomFilterDialogRadioAnd:
                return "آند و";
                case GridStringId.CustomFilterDialogRadioOr:
                return "O آند r";
                case GridStringId.CustomFilterDialogOkButton:
                return "آند موافق";
                case GridStringId.CustomFilterDialogClearFilter:
                return "ج & لير تصفية";
                case GridStringId.CustomFilterDialog2FieldCheck:
                return "الميدان";
                case GridStringId.CustomFilterDialogCancelButton:
                return "آند إلغاء الأمر";
                case GridStringId.CustomFilterDialogEmptyValue:
                return "(قم بإدخال قيمة)";
                case GridStringId.CustomFilterDialogEmptyOperator:
                return "(تحديد عامل تشغيل)";
                case GridStringId.CustomFilterDialogHint:
                return "استخدام _ لتمثيل أي حرف مفرد #Use % لتمثيل أية سلسلة من الأحرف";
                case GridStringId.WindowErrorCaption:
                return "خطأ";
                case GridStringId.MenuFooterSum:
                return "مجموع";
                case GridStringId.MenuFooterMin:
                return "دقيقة";
                case GridStringId.MenuFooterMax:
                return "ماكس";
                case GridStringId.MenuFooterCount:
                return "العد";
                case GridStringId.MenuFooterAverage:
                return "في المتوسط";
                case GridStringId.MenuFooterNone:
                return "لا شيء";
                case GridStringId.MenuFooterSumFormat:
                return "مجموع = {0:0. # #}";
                case GridStringId.MenuFooterMinFormat:
                return "مين = {0}";
                case GridStringId.MenuFooterMaxFormat:
                return "الحد الأقصى = {0}";
                case GridStringId.MenuFooterCountFormat:
                return "{0}";
                case GridStringId.MenuFooterAverageFormat:
                return "متوسط = {0:0. # #}";
                case GridStringId.MenuColumnSortAscending:
                return "فرز تصاعدي";
                case GridStringId.MenuColumnSortDescending:
                return "فرز تنازلي";
                case GridStringId.MenuColumnShowColumn:
                return "إظهار هذا العمود";
                case GridStringId.MenuColumnRemoveColumn:
                return "إخفاء هذا العمود";
                case GridStringId.MenuColumnGroup:
                return "المجموعة حسب هذا العمود";
                case GridStringId.MenuColumnUnGroup:
                return "فك تجميع";
                case GridStringId.MenuColumnColumnCustomization:
                return "محدد العمود";
                case GridStringId.MenuColumnBandCustomization:
                return "منتقي العمود/الفرقة";
                case GridStringId.MenuColumnBestFit:
                return "أفضل احتواء";
                case GridStringId.MenuColumnFilter:
                return "ويمكن تصفية";
                case GridStringId.MenuColumnClearFilter:
                return "مسح عامل التصفية";
                case GridStringId.MenuColumnBestFitAllColumns:
                return "أفضل احتواء (كافة الأعمدة)";
                case GridStringId.MenuColumnResetGroupSummarySort:
                return "قم بفرز ملخص";
                case GridStringId.MenuColumnGroupSummarySortFormat:
                return "{1} من '{0}'-{2}";
                case GridStringId.MenuColumnSumSummaryTypeDescription:
                return "مجموع";
                case GridStringId.MenuColumnMinSummaryTypeDescription:
                return "دقيقة";
                case GridStringId.MenuColumnMaxSummaryTypeDescription:
                return "ماكس";
                case GridStringId.MenuColumnCountSummaryTypeDescription:
                return "العد";
                case GridStringId.MenuColumnAverageSummaryTypeDescription:
                return "في المتوسط";
                case GridStringId.MenuColumnCustomSummaryTypeDescription:
                return "مخصص";
                case GridStringId.MenuColumnSortGroupBySummaryMenu:
                return "فرز حسب الملخص";
                case GridStringId.MenuColumnGroupIntervalMenu:
                return "الفاصل الزمني للمجموعة";
                case GridStringId.MenuColumnGroupIntervalNone:
                return "لا شيء";
                case GridStringId.MenuColumnGroupIntervalDay:
                return "اليوم";
                case GridStringId.MenuColumnGroupIntervalMonth:
                return "في الشهر";
                case GridStringId.MenuColumnGroupIntervalYear:
                return "السنة";
                case GridStringId.MenuColumnGroupIntervalSmart:
                return "الذكية";
                case GridStringId.MenuColumnGroupSummaryEditor:
                return "محرر ملخص المجموعة...";
                case GridStringId.MenuColumnExpressionEditor:
                return "محرر التعبير...";
                case GridStringId.MenuColumnConditionalFormatting:
                return "التنسيق الشرطي";
                case GridStringId.MenuColumnFilterMode:
                return "وضع التصفية";
                case GridStringId.MenuColumnFilterModeValue:
                return "القيمة";
                case GridStringId.MenuColumnFilterModeDisplayText:
                return "عرض النص";
                case GridStringId.MenuGroupPanelFullExpand:
                return "توسيع كامل";
                case GridStringId.MenuGroupPanelFullCollapse:
                return "انهيار كامل";
                case GridStringId.MenuGroupPanelClearGrouping:
                return "قم بتجميع";
                case GridStringId.MenuGroupPanelShow:
                return "المجموعة إظهار مربع";
                case GridStringId.MenuGroupPanelHide:
                return "المجموعة إخفاء مربع";
                case GridStringId.PrintDesignerGridView:
                return "إعدادات الطباعة (عرض الشبكة)";
                case GridStringId.PrintDesignerCardView:
                return "إعدادات الطباعة (بطاقة عرض)";
                case GridStringId.PrintDesignerLayoutView:
                return "إعدادات الطباعة (عرض المخطط)";
                case GridStringId.PrintDesignerBandedView:
                return "إعدادات الطباعة (عرض النطاقات)";
                case GridStringId.PrintDesignerBandHeader:
                return "رأس الفرقة";
                case GridStringId.MenuColumnGroupBox:
                return "تجميع حسب مربع";
                case GridStringId.CardViewNewCard:
                return "بطاقة جديدة";
                case GridStringId.CardViewQuickCustomizationButton:
                return "تخصيص";
                case GridStringId.CardViewQuickCustomizationButtonFilter:
                return "عامل التصفية";
                case GridStringId.CardViewQuickCustomizationButtonSort:
                return "الفرز:";
                case GridStringId.CardViewCaptionFormat:
                return "سجل ن {0}";
                case GridStringId.GridGroupPanelText:
                return "اسحب رأس عمود هنا إلى المجموعة حسب هذا العمود";
                case GridStringId.GridNewRowText:
                return "انقر هنا لإضافة صف جديد";
                case GridStringId.GridOutlookIntervals:
                return "كبار السن؛ في الشهر الماضي؛ وفي وقت سابق من هذا الشهر؛ ثلاثة أسابيع؛ أسبوعين؛ في الأسبوع الماضي؛؛؛ أمس؛ اليوم؛ غدا؛؛؛ الأسبوع المقبل؛ بعد أسبوعين؛ ثلاثة أسابيع؛ في وقت لاحق من هذا الشهر؛ الشهر القادم؛ تتجاوز الشهر المقبل؛";
                case GridStringId.PrintDesignerDescription:
                return "إعداد خيارات الطباعة المختلفة لطريقة العرض الحالية.";
                case GridStringId.MenuFooterCustomFormat:
                return "مخصص = {0}";
                case GridStringId.MenuFooterCountGroupFormat:
                return "عد = {0}";
                case GridStringId.MenuColumnClearSorting:
                return "قم بفرز";
                case GridStringId.MenuColumnClearAllSorting:
                return "قم بفرز جميع";
                case GridStringId.MenuColumnFilterEditor:
                return "محرر تصفية...";
                case GridStringId.MenuColumnAutoFilterRowHide:
                return "إخفاء صف التصفية التلقائية";
                case GridStringId.MenuColumnAutoFilterRowShow:
                return "إظهار صف التصفية التلقائية";
                case GridStringId.MenuColumnFindFilterHide:
                return "إخفاء لوحة البحث";
                case GridStringId.MenuColumnFindFilterShow:
                return "إظهار لوحة البحث";
                case GridStringId.FilterBuilderOkButton:
                return "آند موافق";
                case GridStringId.FilterBuilderCancelButton:
                return "آند إلغاء الأمر";
                case GridStringId.FilterBuilderApplyButton:
                return "آند تطبيق";
                case GridStringId.FilterBuilderCaption:
                return "تحرير عامل تصفية";
                case GridStringId.CustomizationFormColumnHint:
                return "سحب وإفلات الأعمدة هنا لتخصيص تخطيط";
                case GridStringId.CustomizationFormBandHint:
                return "سحب وإسقاط عصابات هنا لتخصيص تخطيط";
                case GridStringId.LayoutViewSingleModeBtnHint:
                return "بطاقة واحدة";
                case GridStringId.LayoutViewRowModeBtnHint:
                return "صف واحد";
                case GridStringId.LayoutViewColumnModeBtnHint:
                return "عمود واحد";
                case GridStringId.LayoutViewMultiRowModeBtnHint:
                return "صفوف متعددة";
                case GridStringId.LayoutViewMultiColumnModeBtnHint:
                return "أعمدة متعددة";
                case GridStringId.LayoutViewCarouselModeBtnHint:
                return "وضع دائري";
                case GridStringId.LayoutViewPanBtnHint:
                return "الغسل";
                case GridStringId.LayoutViewCustomizeBtnHint:
                return "التخصيص";
                case GridStringId.LayoutViewCloseZoomBtnHintClose:
                return "استعادة طريقة عرض";
                case GridStringId.LayoutViewCloseZoomBtnHintZoom:
                return "تحقيق أقصى قدر من التفصيل";
                case GridStringId.LayoutViewButtonApply:
                return "آند تطبيق";
                case GridStringId.LayoutViewButtonPreview:
                return "إظهار & المزيد من البطاقات";
                case GridStringId.LayoutViewButtonOk:
                return "آند موافق";
                case GridStringId.LayoutViewButtonCancel:
                return "آند إلغاء الأمر";
                case GridStringId.LayoutViewButtonSaveLayout:
                return "سا آند ve التخطيط...";
                case GridStringId.LayoutViewButtonLoadLayout:
                return "آند تحميل تخطيط...";
                case GridStringId.LayoutViewFormLoadLayoutCaption:
                return "تحميل تخطيط";
                case GridStringId.LayoutViewFormSaveLayoutCaption:
                return "حفظ التخطيط";
                case GridStringId.LayoutViewButtonCustomizeShow:
                return "آند إظهار التخصيص";
                case GridStringId.LayoutViewButtonCustomizeHide:
                return "إخفاء خصيص & التعاقد";
                case GridStringId.LayoutViewButtonReset:
                return "آند إعادة تعيين قالب بطاقة";
                case GridStringId.LayoutViewButtonShrinkToMinimum:
                return "& انكمش قالب بطاقة";
                case GridStringId.LayoutViewPageTemplateCard:
                return "قالب بطاقة";
                case GridStringId.LayoutViewPageViewLayout:
                return "تخطيط طريقة العرض";
                case GridStringId.LayoutViewGroupCustomization:
                return "التخصيص";
                case GridStringId.LayoutViewGroupCaptions:
                return "التسميات التوضيحية";
                case GridStringId.LayoutViewGroupIndents:
                return "المسافات البادئة";
                case GridStringId.LayoutViewGroupHiddenItems:
                return "العناصر المخفية";
                case GridStringId.LayoutViewGroupTreeStructure:
                return "تخطيط طريقة العرض الشجري";
                case GridStringId.LayoutViewGroupPropertyGrid:
                return "شبكة الخصائص";
                case GridStringId.LayoutViewLabelTextIndent:
                return "المسافات البادئة لنص";
                case GridStringId.LayoutViewLabelPadding:
                return "الحشو";
                case GridStringId.LayoutViewLabelSpacing:
                return "المباعدة بين الولادات";
                case GridStringId.LayoutViewLabelCaptionLocation:
                return "موقع حقل التسمية التوضيحية:";
                case GridStringId.LayoutViewLabelGroupCaptionLocation:
                return "مجموعة موقع تسمية توضيحية:";
                case GridStringId.LayoutViewLabelTextAlignment:
                return "محاذاة نص التسمية التوضيحية الحقل:";
                case GridStringId.LayoutViewGroupView:
                return "طريقة العرض";
                case GridStringId.LayoutViewGroupLayout:
                return "تخطيط";
                case GridStringId.LayoutViewGroupCards:
                return "بطاقات";
                case GridStringId.LayoutViewGroupFields:
                return "الحقول";
                case GridStringId.LayoutViewLabelShowLines:
                return "إظهار الخطوط";
                case GridStringId.LayoutViewLabelShowHeaderPanel:
                return "إظهار لوحة رأس";
                case GridStringId.LayoutViewLabelShowFilterPanel:
                return "إظهار لوحة المرشح:";
                case GridStringId.LayoutViewLabelScrollVisibility:
                return "الرؤية التمرير:";
                case GridStringId.LayoutViewLabelViewMode:
                return "وضع العرض:";
                case GridStringId.LayoutViewLabelCardArrangeRule:
                return "تنظيم القاعدة:";
                case GridStringId.LayoutViewLabelCardEdgeAlignment:
                return "محاذاة حافة البطاقة:";
                case GridStringId.LayoutViewGroupIntervals:
                return "الفواصل الزمنية";
                case GridStringId.LayoutViewLabelHorizontal:
                return "فاصل أفقي";
                case GridStringId.LayoutViewLabelVertical:
                return "فاصل عمودي";
                case GridStringId.LayoutViewLabelShowCardCaption:
                return "تظهر التسمية التوضيحية";
                case GridStringId.LayoutViewLabelShowCardExpandButton:
                return "إظهار الزر توسيع";
                case GridStringId.LayoutViewLabelShowCardBorder:
                return "إظهار الحدود";
                case GridStringId.LayoutViewLabelAllowFieldHotTracking:
                return "السماح للتعقب الساخنة";
                case GridStringId.LayoutViewLabelShowFieldBorder:
                return "إظهار الحدود";
                case GridStringId.LayoutViewLabelShowFieldHint:
                return "إظهار تلميح";
                case GridStringId.LayoutViewCustomizationFormCaption:
                return "التخصيص لايوتفيو";
                case GridStringId.LayoutViewCardCaptionFormat:
                return "سجل [{0} من {1}]";
                case GridStringId.LayoutViewFieldCaptionFormat:
                return "{0}:";
                case GridStringId.GroupSummaryEditorFormCaption:
                return "محرر ملخص المجموعة";
                case GridStringId.GroupSummaryEditorFormOkButton:
                return "موافق";
                case GridStringId.GroupSummaryEditorFormCancelButton:
                return "إلغاء الأمر";
                case GridStringId.GroupSummaryEditorFormItemsTabCaption:
                return "العناصر";
                case GridStringId.GroupSummaryEditorFormOrderTabCaption:
                return "ترتيب";
                case GridStringId.GroupSummaryEditorSummaryMin:
                return "دقيقة";
                case GridStringId.GroupSummaryEditorSummaryMax:
                return "ماكس";
                case GridStringId.GroupSummaryEditorSummaryAverage:
                return "في المتوسط";
                case GridStringId.GroupSummaryEditorSummarySum:
                return "مجموع";
                case GridStringId.GroupSummaryEditorSummaryCount:
                return "العد";
                case GridStringId.FindControlFindButton:
                return "البحث عن";
                case GridStringId.FindControlClearButton:
                return "واضحة";
                case GridStringId.SearchLookUpAddNewButton:
                return "إضافة جديد";
                case GridStringId.MenuFooterAddSummaryItem:
                return "إضافة ملخص جديد";
                case GridStringId.MenuFooterClearSummaryItems:
                return "مسح العناصر الموجزة";
                case GridStringId.MenuShowSplitItem:
                return "انقسام";
                case GridStringId.MenuHideSplitItem:
                return "إزالة الانقسام";
                case GridStringId.ServerRequestError:
                return "حدث خطأ أثناء معالجة طلب الملقم ({0}...)";
                case GridStringId.WindowWarningCaption:
                return "تحذير";
                case GridStringId.EditFormUpdateButton:
                return "التحديث";
                case GridStringId.EditFormCancelButton:
                return "إلغاء الأمر";
                case GridStringId.EditFormCancelMessage:
                return "هل تريد إلغاء التحرير؟";
                case GridStringId.EditFormSaveMessage:
                return "يتم تعديل البيانات الخاصة بك. هل تريد حفظ التغييرات؟";
                case GridStringId.CheckboxSelectorColumnCaption:
                return "التحديد";
                case GridStringId.FindNullPrompt:
                return "أدخل نص للبحث...";
                case GridStringId.SearchForBand:
                return "البحث عن عصابة...";
                default:
                return base.GetLocalizedString(id);
            }
        }
    }
    public class HebrewGridLocalizer : GridLocalizer {
        public override string GetLocalizedString(GridStringId id) {
            switch(id) {
                case GridStringId.FileIsNotFoundError:
                return "קובץ {0} לא נמצא";
                case GridStringId.ColumnViewExceptionMessage:
                return " האם ברצונך לתקן את הערך?";
                case GridStringId.CustomizationCaption:
                return "התאמה אישית";
                case GridStringId.CustomizationColumns:
                return "עמודות";
                case GridStringId.CustomizationBands:
                return "להקות";
                case GridStringId.FilterPanelCustomizeButton:
                return "ערוך מסנן";
                case GridStringId.PopupFilterAll:
                return "(הכל)";
                case GridStringId.PopupFilterCustom:
                return "(מותאם אישית)";
                case GridStringId.PopupFilterBlanks:
                return "(ריקים)";
                case GridStringId.PopupFilterNonBlanks:
                return "(לא ריקים)";
                case GridStringId.CustomFilterDialogFormCaption:
                return "בסינון אוטומטי מותאם אישית";
                case GridStringId.CustomFilterDialogCaption:
                return "הצג שורות שבהן:";
                case GridStringId.CustomFilterDialogRadioAnd:
                return "& ו";
                case GridStringId.CustomFilterDialogRadioOr:
                return "O & r";
                case GridStringId.CustomFilterDialogOkButton:
                return "& בסדר";
                case GridStringId.CustomFilterDialogClearFilter:
                return "C & ליר לסנן";
                case GridStringId.CustomFilterDialog2FieldCheck:
                return "שדה";
                case GridStringId.CustomFilterDialogCancelButton:
                return "& לבטל";
                case GridStringId.CustomFilterDialogEmptyValue:
                return "(הזן ערך)";
                case GridStringId.CustomFilterDialogEmptyOperator:
                return "(בחר אופרטור)";
                case GridStringId.CustomFilterDialogHint:
                return "השתמש _ כדי לייצג כל תו יחיד #Use % כדי לייצג כל סדרה של תווים";
                case GridStringId.WindowErrorCaption:
                return "שגיאה";
                case GridStringId.MenuFooterSum:
                return "סכום";
                case GridStringId.MenuFooterMin:
                return "Min";
                case GridStringId.MenuFooterMax:
                return "מקס";
                case GridStringId.MenuFooterCount:
                return "ספירה";
                case GridStringId.MenuFooterAverage:
                return "ממוצע";
                case GridStringId.MenuFooterNone:
                return "אף אחד";
                case GridStringId.MenuFooterSumFormat:
                return "סכום = {0:0. # #}";
                case GridStringId.MenuFooterMinFormat:
                return "MIN = {0}";
                case GridStringId.MenuFooterMaxFormat:
                return "מקס = {0}";
                case GridStringId.MenuFooterCountFormat:
                return "{0}";
                case GridStringId.MenuFooterAverageFormat:
                return "AVG = {0:0. # #}";
                case GridStringId.MenuColumnSortAscending:
                return "מיין בסדר עולה";
                case GridStringId.MenuColumnSortDescending:
                return "מיין בסדר יורד";
                case GridStringId.MenuColumnShowColumn:
                return "הצג עמודה זו";
                case GridStringId.MenuColumnRemoveColumn:
                return "הסתר עמודה זו";
                case GridStringId.MenuColumnGroup:
                return "קבץ לפי עמודה זו";
                case GridStringId.MenuColumnUnGroup:
                return "לפרק";
                case GridStringId.MenuColumnColumnCustomization:
                return "בוחר עמודה";
                case GridStringId.MenuColumnBandCustomization:
                return "בוחר עמודה/להקה";
                case GridStringId.MenuColumnBestFit:
                return "מיטבית";
                case GridStringId.MenuColumnFilter:
                return "באפשרותך לסנן";
                case GridStringId.MenuColumnClearFilter:
                return "נקה מסנן";
                case GridStringId.MenuColumnBestFitAllColumns:
                return "מיטבית (כל העמודות)";
                case GridStringId.MenuColumnResetGroupSummarySort:
                return "נקה מיון סיכום";
                case GridStringId.MenuColumnGroupSummarySortFormat:
                return "{1} מאת '{0}' - {2}";
                case GridStringId.MenuColumnSumSummaryTypeDescription:
                return "סכום";
                case GridStringId.MenuColumnMinSummaryTypeDescription:
                return "Min";
                case GridStringId.MenuColumnMaxSummaryTypeDescription:
                return "מקס";
                case GridStringId.MenuColumnCountSummaryTypeDescription:
                return "ספירה";
                case GridStringId.MenuColumnAverageSummaryTypeDescription:
                return "ממוצע";
                case GridStringId.MenuColumnCustomSummaryTypeDescription:
                return "מותאם אישית";
                case GridStringId.MenuColumnSortGroupBySummaryMenu:
                return "מיין לפי סיכום";
                case GridStringId.MenuColumnGroupIntervalMenu:
                return "מרווח בין קבוצות";
                case GridStringId.MenuColumnGroupIntervalNone:
                return "אף אחד";
                case GridStringId.MenuColumnGroupIntervalDay:
                return "היום";
                case GridStringId.MenuColumnGroupIntervalMonth:
                return "חודש";
                case GridStringId.MenuColumnGroupIntervalYear:
                return "השנה";
                case GridStringId.MenuColumnGroupIntervalSmart:
                return "חכם";
                case GridStringId.MenuColumnGroupSummaryEditor:
                return "עורך סיכום קבוצתית...";
                case GridStringId.MenuColumnExpressionEditor:
                return "הביטוי עורך...";
                case GridStringId.MenuColumnConditionalFormatting:
                return "המותנה";
                case GridStringId.MenuColumnFilterMode:
                return "מסנן מצב";
                case GridStringId.MenuColumnFilterModeValue:
                return "ערך";
                case GridStringId.MenuColumnFilterModeDisplayText:
                return "הצגת טקסט";
                case GridStringId.MenuGroupPanelFullExpand:
                return "מלא להרחיב";
                case GridStringId.MenuGroupPanelFullCollapse:
                return "כווץ מלאה";
                case GridStringId.MenuGroupPanelClearGrouping:
                return "קיבוץ ברור";
                case GridStringId.MenuGroupPanelShow:
                return "הצג קבוצה על-ידי קופסה";
                case GridStringId.MenuGroupPanelHide:
                return "הסתר קבוצה על-ידי קופסה";
                case GridStringId.PrintDesignerGridView:
                return "הגדרות הדפסה (רשת נוף)";
                case GridStringId.PrintDesignerCardView:
                return "הגדרות הדפסה (כרטיס תצוגה)";
                case GridStringId.PrintDesignerLayoutView:
                return "הגדרות הדפסה (תצוגת פריסה)";
                case GridStringId.PrintDesignerBandedView:
                return "הגדרות הדפסה (תצוגת המפוספסת)";
                case GridStringId.PrintDesignerBandHeader:
                return "פס כותרת";
                case GridStringId.MenuColumnGroupBox:
                return "קבוצה על-ידי קופסה";
                case GridStringId.CardViewNewCard:
                return "כרטיס חדש";
                case GridStringId.CardViewQuickCustomizationButton:
                return "התאמה אישית";
                case GridStringId.CardViewQuickCustomizationButtonFilter:
                return "מסנן";
                case GridStringId.CardViewQuickCustomizationButtonSort:
                return "מיון:";
                case GridStringId.CardViewCaptionFormat:
                return "רשומה N {0}";
                case GridStringId.GridGroupPanelText:
                return "גרור את כותרת עמודה לכאן קבוצה לפי עמודה זו";
                case GridStringId.GridNewRowText:
                return "לחץ כאן כדי להוסיף שורה חדשה";
                case GridStringId.GridOutlookIntervals:
                return "מבוגר; בחודש שעבר; מוקדם יותר החודש; 3 שבועות; שבועיים; בשבוע שעבר;; אתמול; כיום; . מחר;; בשבוע הבא; שבועיים משם; בעוד שלושה שבועות; מאוחר יותר החודש; בחודש הבא; מעבר בחודש הבא;";
                case GridStringId.PrintDesignerDescription:
                return "להגדיר אפשרויות הדפסה שונות עבור התצוגה הנוכחית.";
                case GridStringId.MenuFooterCustomFormat:
                return "מותאם אישית = {0}";
                case GridStringId.MenuFooterCountGroupFormat:
                return "ספירה = {0}";
                case GridStringId.MenuColumnClearSorting:
                return "נקה מיון";
                case GridStringId.MenuColumnClearAllSorting:
                return "נקה כל מיון";
                case GridStringId.MenuColumnFilterEditor:
                return "לסנן עורך...";
                case GridStringId.MenuColumnAutoFilterRowHide:
                return "להסתיר השורה סינון אוטומטי";
                case GridStringId.MenuColumnAutoFilterRowShow:
                return "הצג אוטומטי מסנן שורה";
                case GridStringId.MenuColumnFindFilterHide:
                return "להסתיר את החלונית חיפוש";
                case GridStringId.MenuColumnFindFilterShow:
                return "להציג לוח חיפוש";
                case GridStringId.FilterBuilderOkButton:
                return "& בסדר";
                case GridStringId.FilterBuilderCancelButton:
                return "& לבטל";
                case GridStringId.FilterBuilderApplyButton:
                return "& להחיל";
                case GridStringId.FilterBuilderCaption:
                return "לסנן עורך";
                case GridStringId.CustomizationFormColumnHint:
                return "גרור ושחרר עמודות כאן כדי להתאים אישית את הפריסה";
                case GridStringId.CustomizationFormBandHint:
                return "גרור ושחרר להקות כאן כדי להתאים אישית את הפריסה";
                case GridStringId.LayoutViewSingleModeBtnHint:
                return "קלף אחד";
                case GridStringId.LayoutViewRowModeBtnHint:
                return "שורה אחת";
                case GridStringId.LayoutViewColumnModeBtnHint:
                return "עמודה אחת";
                case GridStringId.LayoutViewMultiRowModeBtnHint:
                return "שורות מרובות";
                case GridStringId.LayoutViewMultiColumnModeBtnHint:
                return "עמודות מרובות";
                case GridStringId.LayoutViewCarouselModeBtnHint:
                return "מצב קרוסלה";
                case GridStringId.LayoutViewPanBtnHint:
                return "פאנינג";
                case GridStringId.LayoutViewCustomizeBtnHint:
                return "התאמה אישית";
                case GridStringId.LayoutViewCloseZoomBtnHintClose:
                return "לשחזר תצוגה";
                case GridStringId.LayoutViewCloseZoomBtnHintZoom:
                return "למקסם את פירוט";
                case GridStringId.LayoutViewButtonApply:
                return "& להחיל";
                case GridStringId.LayoutViewButtonPreview:
                return "הצג & עוד קלפים";
                case GridStringId.LayoutViewButtonOk:
                return "& בסדר";
                case GridStringId.LayoutViewButtonCancel:
                return "& לבטל";
                case GridStringId.LayoutViewButtonSaveLayout:
                return "Sa & ve פריסה...";
                case GridStringId.LayoutViewButtonLoadLayout:
                return "& פריסת עומס...";
                case GridStringId.LayoutViewFormLoadLayoutCaption:
                return "פריסת עומס";
                case GridStringId.LayoutViewFormSaveLayoutCaption:
                return "שמירת פריסה";
                case GridStringId.LayoutViewButtonCustomizeShow:
                return "& להראות התאמה אישית";
                case GridStringId.LayoutViewButtonCustomizeHide:
                return "הסתר צע התאמה אישית של & הסינכרון";
                case GridStringId.LayoutViewButtonReset:
                return "& איפוס תבנית כרטיס";
                case GridStringId.LayoutViewButtonShrinkToMinimum:
                return "& לכווץ תבנית כרטיס";
                case GridStringId.LayoutViewPageTemplateCard:
                return "תבנית כרטיס";
                case GridStringId.LayoutViewPageViewLayout:
                return "תצוגת פריסה";
                case GridStringId.LayoutViewGroupCustomization:
                return "התאמה אישית";
                case GridStringId.LayoutViewGroupCaptions:
                return "כיתובים";
                case GridStringId.LayoutViewGroupIndents:
                return "כניסות";
                case GridStringId.LayoutViewGroupHiddenItems:
                return "פריטים מוסתרים";
                case GridStringId.LayoutViewGroupTreeStructure:
                return "תצוגת עץ פריסה";
                case GridStringId.LayoutViewGroupPropertyGrid:
                return "המאפיין רשת";
                case GridStringId.LayoutViewLabelTextIndent:
                return "כניסות טקסט";
                case GridStringId.LayoutViewLabelPadding:
                return "ריפוד";
                case GridStringId.LayoutViewLabelSpacing:
                return "מרווח";
                case GridStringId.LayoutViewLabelCaptionLocation:
                return "מיקום שדה כיתוב:";
                case GridStringId.LayoutViewLabelGroupCaptionLocation:
                return "קבוצה הכיתוב מיקום:";
                case GridStringId.LayoutViewLabelTextAlignment:
                return "יישור טקסט כיתוב השדה:";
                case GridStringId.LayoutViewGroupView:
                return "תצוגה";
                case GridStringId.LayoutViewGroupLayout:
                return "פריסה";
                case GridStringId.LayoutViewGroupCards:
                return "קלפים";
                case GridStringId.LayoutViewGroupFields:
                return "שדות";
                case GridStringId.LayoutViewLabelShowLines:
                return "הצג שורות";
                case GridStringId.LayoutViewLabelShowHeaderPanel:
                return "להציג כותרת לוח";
                case GridStringId.LayoutViewLabelShowFilterPanel:
                return "הצג את החלונית ' מסנן ':";
                case GridStringId.LayoutViewLabelScrollVisibility:
                return "ניראות גלילה:";
                case GridStringId.LayoutViewLabelViewMode:
                return "מצב תצוגה:";
                case GridStringId.LayoutViewLabelCardArrangeRule:
                return "לארגן את הכלל:";
                case GridStringId.LayoutViewLabelCardEdgeAlignment:
                return "יישור הקצה כרטיס:";
                case GridStringId.LayoutViewGroupIntervals:
                return "מרווחי";
                case GridStringId.LayoutViewLabelHorizontal:
                return "מרווח אופקי";
                case GridStringId.LayoutViewLabelVertical:
                return "מרווח אנכי";
                case GridStringId.LayoutViewLabelShowCardCaption:
                return "הצג כיתוב";
                case GridStringId.LayoutViewLabelShowCardExpandButton:
                return "הצג לחצן הרחב";
                case GridStringId.LayoutViewLabelShowCardBorder:
                return "הצג גבול";
                case GridStringId.LayoutViewLabelAllowFieldHotTracking:
                return "לאפשר מעקב חם";
                case GridStringId.LayoutViewLabelShowFieldBorder:
                return "הצג גבול";
                case GridStringId.LayoutViewLabelShowFieldHint:
                return "רמז להראות";
                case GridStringId.LayoutViewCustomizationFormCaption:
                return "התאמה LayoutView";
                case GridStringId.LayoutViewCustomizationFormDescription:
                return "להתאים אישית את פריסת הכרטיס באמצעות גרור-ושחרר, התאמה אישית של תפריט תצוגה מקדימה של נתונים בעמוד בתצוגת פריסה.";
                case GridStringId.LayoutViewCardCaptionFormat:
                return "שיא [{0} של {1}]";
                case GridStringId.LayoutViewFieldCaptionFormat:
                return "{0}:";
                case GridStringId.GroupSummaryEditorFormCaption:
                return "עורך סיכום קבוצתית";
                case GridStringId.GroupSummaryEditorFormOkButton:
                return "אוקיי";
                case GridStringId.GroupSummaryEditorFormCancelButton:
                return "ביטול";
                case GridStringId.GroupSummaryEditorFormItemsTabCaption:
                return "פריטים";
                case GridStringId.GroupSummaryEditorFormOrderTabCaption:
                return "סדר";
                case GridStringId.GroupSummaryEditorSummaryMin:
                return "Min";
                case GridStringId.GroupSummaryEditorSummaryMax:
                return "מקס";
                case GridStringId.GroupSummaryEditorSummaryAverage:
                return "ממוצע";
                case GridStringId.GroupSummaryEditorSummarySum:
                return "סכום";
                case GridStringId.GroupSummaryEditorSummaryCount:
                return "ספירה";
                case GridStringId.FindControlFindButton:
                return "למצוא";
                case GridStringId.FindControlClearButton:
                return "ברור";
                case GridStringId.SearchLookUpAddNewButton:
                return "הוסף כתובת חדשה";
                case GridStringId.MenuFooterAddSummaryItem:
                return "הוספת סיכום חדש";
                case GridStringId.MenuFooterClearSummaryItems:
                return "נקה פריטים סיכום";
                case GridStringId.MenuShowSplitItem:
                return "פיצול";
                case GridStringId.MenuHideSplitItem:
                return "הסר פיצול";
                case GridStringId.ServerRequestError:
                return "אירעה שגיאה בעת עיבוד בקשת שרת ({0}...)";
                case GridStringId.WindowWarningCaption:
                return "אזהרה";
                case GridStringId.EditFormUpdateButton:
                return "עדכון";
                case GridStringId.EditFormCancelButton:
                return "ביטול";
                case GridStringId.EditFormCancelMessage:
                return "האם ברצונך לבטל עריכה?";
                case GridStringId.EditFormSaveMessage:
                return "הנתונים שלך משתנה. האם ברצונך לשמור את השינויים?";
                case GridStringId.CheckboxSelectorColumnCaption:
                return "הבחירה";
                case GridStringId.FindNullPrompt:
                return "הזן טקסט לחיפוש...";
                case GridStringId.SearchForBand:
                return "החיפוש אחר להקה...";

                default:
                return base.GetLocalizedString(id);
            }
        }
    }
}
