Imports DevExpress.XtraBars.Localization
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DevExpress.MailClient.Win.Localizer
    Public Class FarsiBarLocalizer
        Inherits BarLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As BarString) As String
            Select Case id
                Case BarString.NewMenuName
                Return "منوی اصلی"
                Case BarString.SkinsBonus
                Return "پوسته های اضافی"
                Case BarString.RibbonCustomizationNewGroupDefaultAlias
                Return "گروه جدید"
                Case BarString.PopupMenuEditor
                Return "پنجره ویرایشگر منو"
                Case BarString.NewToolbarCaption
                Return "نوار ابزار جدید"
                Case BarString.CustomizeQuickAccessToolbar
                Return "& تنظیم سفارشی نوار ابزار دسترسی سریع..."
                Case BarString.RibbonTouchMouseModeCommandText
                Return "حالت لمسی/ماوس"
                Case BarString.RibbonToolbarBelow
                Return "& نمایش نوار ابزار دسترسی سریع در زیر روبان"
                Case BarString.SkinsCustom
                Return "پوسته های سفارشی"
                Case BarString.RibbonMinimizedItemDescription
                Return "زبانه های روبان تنها نشان می دهد. بند به دستورات نشان می دهد را کلیک کنید."
                Case BarString.NewStatusBarName
                Return "نوار وضعیت"
                Case BarString.RibbonCustomizationNewCategoryDefaultAlias
                Return "دسته جدید"
                Case BarString.NewToolbarCustomNameFormat
                Return "سفارشی {0}"
                Case BarString.RibbonTouchMouseModeGalleryGroupText
                Return "بهینه سازی فاصله بین دستورات."
                Case BarString.RibbonToolbarAdd
                Return "& اضافه کردن به نوار ابزار دسترسی سریع"
                Case BarString.AddOrRemove
                Return "& افزودن یا حذف دکمه ها"
                Case BarString.CustomizeToolbarText
                Return "سفارشی کردن نوار ابزار"
                Case BarString.RibbonExpandedItemCaption
                Return "زبانه ها و دستورات نشان می دهد"
                Case BarString.SkinCaptions
                Return "| DevExpress Style| Caramel| پول Twins| تاریکی DevExpress Style|iMaginary| Lilian| Black| Blue| دفتر 2010 Blue| دفتر 2010 Black| دفتر 2010 Silver| آفیس 2007 Blue| دفتر 2007 Black| آفیس 2007 Silver| آفیس 2007 Green| آفیس 2007 Pink| Seven| هفت Classic| Darkroom| McSkin| Sharp| تیز Plus| Foggy| تیره Side| Xmas (آبی) | Springtime| Summer| Pumpkin| Valentine| Stardust| Coffee| شیشه Oceans| Contrast| بالا مایع Sky| لندن مایع Sky| World| آسفالت Blueprint| Whiteprint| ویژوال استودیو 2010| Metropolis| کلان شهر Dark| دفتر White| 2013 دفتر Gray| Dark 2013 دفتر 2013 نور Gray| ویژوال استودیو Blue| 2013 ویژوال استودیو Dark| 2013 ویژوال استودیو Light| 2013 دفتر Colorful| 2016 دفتر Dark| 2016"
                Case BarString.RenameToolbarCaption
                Return "تغییر نام نوار ابزار"
                Case BarString.RibbonTouchMouseModeTouchItemText
                Return "لمسی"
                Case BarString.CloseButton
                Return "بستن"
                Case BarString.RibbonCustomizationNewCategoryCommand
                Return "دسته جدید"
                Case BarString.Visible
                Return "قابل مشاهده"
                Case BarString.RibbonToolbarMinimizeRibbon
                Return "سکته قلبی & روبان nimize"
                Case BarString.ShowScreenTipsOnToolbarsName
                Return "نمایش نکات صفحه در نوار ابزار"
                Case BarString.CustomizeWindowCaption
                Return "سفارشی"
                Case BarString.CustomizeToolbarSuperTipText
                Return "تنظیم سفارشی نوار ابزار دسترسی سریع"
                Case BarString.RibbonExpandedItemDescription
                Return "زبانه های روبان و دستورات همیشه نشان می دهد."
                Case BarString.RibbonCustomizationNewPageCommand
                Return "زبانه جدید"
                Case BarString.MinimizeButton
                Return "به حداقل رساندن"
                Case BarString.RibbonTouchMouseModeMouseItemText
                Return "ماوس"
                Case BarString.RibbonToolbarRemove
                Return "& حذف از نوار ابزار دسترسی سریع"
                Case BarString.ShowShortcutKeysOnScreenTipsName
                Return "نمایش کلیدهای میانبر در نکات صفحه"
                Case BarString.ResetBar
                Return "آیا مایلید تغییرات داده شده در '{0}' نوار ابزار را مجدداً تنظیم کنید؟"
                Case BarString.RibbonCustomizationOptionAllTabs
                Return "همه زبانه ها"
                Case BarString.CustomizeButton
                Return "& سفارشی..."
                Case BarString.MenuAnimationSystem
                Return "(پیش فرض سیستم)"
                Case BarString.RibbonTouchMouseModeTouchItemDescription
                Return "بیشتر فضای بین دستورات. بهینه شده برای استفاده با لمس."
                Case BarString.RibbonGalleryFilter
                Return "همه گروه ها"
                Case BarString.RibbonCustomizationNewGroupCommand
                Return "گروه جدید"
                Case BarString.MaximizeButton
                Return "حداکثر رساندن"
                Case BarString.ResetBarCaption
                Return "سفارشی کردن"
                Case BarString.ExpandRibbonSuperTipHeader
                Return "گسترش روبان (Ctrl + F1)"
                Case BarString.MenuAnimationNone
                Return "هیچ کدام"
                Case BarString.RibbonTouchMouseModeMouseItemDescription
                Return "روبان های استاندارد و دستورات. بهینه شده برای استفاده با ماوس."
                Case BarString.RibbonCustomizationOptionAllCommands
                Return "همه دستورات"
                Case BarString.CancelButton
                Return "لغو"
                Case BarString.RibbonCustomizationRenameText
                Return "تغییر نام"
                Case BarString.RibbonGalleryFilterNone
                Return "هیچ کدام"
                Case BarString.MenuAnimationFade
                Return "محو شدن"
                Case BarString.CollapseRibbonSuperTipHeader
                Return "کوچک کردن روبان (Ctrl + F1)"
                Case BarString.RestoreButton
                Return "برگرداندن به پایین"
                Case BarString.ResetButton
                Return "& تنظیم مجدد نوار ابزار"
                Case BarString.RibbonCustomizationStandardCustomItemSuffix
                Return "سفارشی"
                Case BarString.MenuAnimationSlide
                Return "اسلاید"
                Case BarString.ColorAuto
                Return "خودکار"
                Case BarString.BarUnassignedItems
                Return "(امضاء نشده مورد)"
                Case BarString.ToolBarMenu
                Return "& بازنشانی $& حذف $! & نام $! چاپگرهای پیش فرض & lt سبک $& متن فقط (همیشه) $Text & تنها (در منوها) $Image & و متن $! شروع یک & گروه اخیرا استفاده شده $& قابل مشاهده $& بیشتر"
                Case BarString.RibbonCustomizationRemoveText
                Return "حذف"
                Case BarString.HelpButton
                Return "کمک"
                Case BarString.MenuAnimationUnfold
                Return "آشکار شدن"
                Case BarString.ExpandRibbonSuperTipText
                Return "حتی پس از فرمان را کلیک می کنید طوری که همیشه گسترش روبان نشان می دهد"
                Case BarString.BarAllItems
                Return "(همه موارد)"
                Case BarString.RibbonToolbarAbove
                Return "& نمایش نوار ابزار دسترسی سریع در بالای روبان"
                Case BarString.RibbonCustomizationResetSelectedTabSettingsCommand
                Return "تنظیم مجدد تنها برگه انتخاب روبان"
                Case BarString.ToolbarNameCaption
                Return "& نام نوار ابزار:"
                Case BarString.AccordionControlSearchBoxPromptText
                Return "نوع کلمات کلیدی در اینجا"
                Case BarString.FullScreenButton
                Return "پنهان کردن خودکار نوار"
                Case BarString.MenuAnimationRandom
                Return "تصادفی"
                Case BarString.RibbonCustomizationAddText
                Return "اضافه کردن"
                Case BarString.RibbonCustomizationResetSettingsCommand
                Return "تنظیم مجدد تمام برنامه"
                Case BarString.CollapseRibbonSuperTipText
                Return "فقط نمایش نام برگه در روبان"
                Case BarString.RibbonUnassignedPages
                Return "(امضاء نشده صفحات)"
                Case BarString.RibbonFullScreenItemCaption
                Return "پنهان کردن خودکار نوار"
                Case BarString.SkinsMain
                Return "پوسته های استاندارد"
                Case BarString.RibbonCustomizationDownText
                Return "حرکت به پایین"
                Case BarString.RibbonCustomizationImportSettingsCommand
                Return "سفارشی سازی فایل"
                Case BarString.MoreCommands
                Return "& دستورات بیشتر..."
                Case BarString.RibbonFullScreenItemDescription
                Return "مخفی کردن روبان. کلیک کنید در بالای برنامه برای نشان دادن آن."
                Case BarString.RibbonAllPages
                Return "(تمام صفحات)"
                Case BarString.SkinsOffice
                Return "پوسته های دفتر"
                Case BarString.RibbonCustomizationUpText
                Return "حرکت به بالا"
                Case BarString.RibbonCustomizationExportSettingsCommand
                Return "همه موارد سفارشی شده برای صادرات"
                Case BarString.CustomizeRibbon
                Return "سفارشی کردن & روبان..."
                Case BarString.NewToolbarName
                Return "ابزار"
                Case BarString.RibbonMinimizedItemCaption
                Return "نمایش تب ها"
                Case BarString.SkinsTheme
                Return "پوسته های تم"
                Case BarString.RibbonCaptionTextNone
                Return "بدون نام"
                Case BarString.RibbonCustomizationNewTabDefaultAlias
                Return "زبانه جدید"

                Case Else
                Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
    Public Class ArabicBarLocalizer
        Inherits BarLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As BarString) As String
            Select Case id
                Case BarString.NewToolbarCaption
                Return "شريط أدوات جديد"
                Case BarString.RibbonMinimizedItemDescription
                Return "إظهار علامات تبويب الشريط فقط. انقر فوق علامة تبويب لعرض الأوامر."
                Case BarString.CustomizeQuickAccessToolbar
                Return "آند تخصيص شريط أدوات الوصول السريع..."
                Case BarString.RibbonCustomizationNewGroupDefaultAlias
                Return "مجموعة جديدة"
                Case BarString.NewMenuName
                Return "القائمة الرئيسية"
                Case BarString.RibbonTouchMouseModeCommandText
                Return "وضع اللمس/الماوس"
                Case BarString.RibbonToolbarBelow
                Return "آند إظهار شريط أدوات الوصول السريع أسفل الشريط"
                Case BarString.NewToolbarCustomNameFormat
                Return "{0} مخصصة"
                Case BarString.SkinsBonus
                Return "مكافأة جلود"
                Case BarString.CustomizeToolbarText
                Return "تخصيص شريط الأدوات"
                Case BarString.RibbonCustomizationNewCategoryDefaultAlias
                Return "فئة جديدة"
                Case BarString.PopupMenuEditor
                Return "محرر القائمة المنبثقة"
                Case BarString.RibbonExpandedItemCaption
                Return "إظهار علامات التبويب والأوامر"
                Case BarString.RibbonTouchMouseModeGalleryGroupText
                Return "تحقيق أمثلية مساحة بين الأمرين."
                Case BarString.RibbonToolbarAdd
                Return "آند إضافة إلى شريط أدوات الوصول السريع"
                Case BarString.NewStatusBarName
                Return "شريط المعلومات"
                Case BarString.RenameToolbarCaption
                Return "إعادة تسمية شريط أدوات"
                Case BarString.CustomizeToolbarSuperTipText
                Return "تخصيص شريط أدوات الوصول السريع"
                Case BarString.SkinsCustom
                Return "الجلود المخصصة"
                Case BarString.AddOrRemove
                Return "آند إضافة أو إزالة الأزرار"
                Case BarString.RibbonCustomizationNewCategoryCommand
                Return "فئة جديدة"
                Case BarString.CloseButton
                Return "قم بإغلاق"
                Case BarString.CustomizeWindowCaption
                Return "التخصيص"
                Case BarString.RibbonExpandedItemDescription
                Return "إظهار علامات تبويب الشريط والأوامر طوال الوقت."
                Case BarString.RibbonTouchMouseModeTouchItemText
                Return "تعمل باللمس"
                Case BarString.RibbonCustomizationOptionAllTabs
                Return "كافة علامات التبويب"
                Case BarString.RibbonCustomizationNewPageCommand
                Return "علامة تبويب جديدة"
                Case BarString.RibbonToolbarMinimizeRibbon
                Return "مي & نيميتز الشريط"
                Case BarString.MinimizeButton
                Return "التقليل إلى أدنى حد"
                Case BarString.SkinCaptions
                Return "| DevExpress Style| Caramel| Twins| المال Style|iMaginary| DevExpress الظلام Lilian| Black| Blue| مكتب 2010 Blue| مكتب 2010 Black| مكتب 2010 Silver| مكتب 2007 Blue| مكتب 2007 Black| مكتب 2007 Silver| مكتب 2007 Green| مكتب 2007 Pink| Seven| سبعة Classic| Darkroom| McSkin| Sharp| Plus| شارب Foggy| Side| الظلام عيد الميلاد (الأزرق) | Springtime| Summer| Pumpkin| Valentine| Stardust| Coffee| زجاج Oceans| Contrast| عالية Sky| السائلة لندن Sky| السائلة World| الأسفلت Blueprint| Whiteprint| Visual Studio 2010 | Metropolis| مدينة Dark| مكتب 2013 White| مكتب 2013 الظلام Gray| مكتب 2013 الضوء Gray| Visual Studio 2013 Blue| Visual Studio 2013 Dark| Visual Studio 2013 Light| مكتب 2016 Colorful| مكتب 2016 Dark|"
                Case BarString.Visible
                Return "مرئية"
                Case BarString.CustomizeButton
                Return "آند تخصيص..."
                Case BarString.MenuAnimationSystem
                Return "(الافتراضي للنظام)"
                Case BarString.RibbonCustomizationOptionAllCommands
                Return "كافة الأوامر"
                Case BarString.RibbonCustomizationNewGroupCommand
                Return "مجموعة جديدة"
                Case BarString.RibbonTouchMouseModeMouseItemText
                Return "الماوس"
                Case BarString.RibbonToolbarRemove
                Return "آند إزالة من شريط أدوات الوصول السريع"
                Case BarString.ShowScreenTipsOnToolbarsName
                Return "إظهار تلميحات الشاشة على أشرطة الأدوات"
                Case BarString.MaximizeButton
                Return "تكبير"
                Case BarString.MenuAnimationNone
                Return "لا شيء"
                Case BarString.RibbonCustomizationStandardCustomItemSuffix
                Return "مخصص"
                Case BarString.RibbonCustomizationRenameText
                Return "إعادة تسمية"
                Case BarString.RestoreButton
                Return "استعادة إلى الأسفل"
                Case BarString.MenuAnimationSlide
                Return "الشريحة"
                Case BarString.ResetBar
                Return "هل أنت متأكد من أنك تريد إعادة تعيين التغييرات التي تم إجراؤها على شريط الأدوات '{0}'؟"
                Case BarString.CancelButton
                Return "إلغاء الأمر"
                Case BarString.RibbonTouchMouseModeTouchItemDescription
                Return "الحصول على مساحة أكبر بين الأمرين. الأمثل للاستخدام مع لمسة."
                Case BarString.RibbonCustomizationResetSelectedTabSettingsCommand
                Return "إعادة تعيين علامة تبويب الشريط المحدد فقط"
                Case BarString.RibbonCustomizationRemoveText
                Return "إزالة"
                Case BarString.HelpButton
                Return "تعليمات"
                Case BarString.RibbonGalleryFilter
                Return "كافة المجموعات"
                Case BarString.ShowShortcutKeysOnScreenTipsName
                Return "إظهار مفاتيح الاختصار في تلميحات الشاشة"
                Case BarString.ResetBarCaption
                Return "تخصيص"
                Case BarString.MenuAnimationFade
                Return "تتلاشى"
                Case BarString.RibbonCustomizationResetSettingsCommand
                Return "إعادة تعيين كافة التخصيصات"
                Case BarString.RibbonCustomizationAddText
                Return "إضافة"
                Case BarString.RibbonTouchMouseModeMouseItemDescription
                Return "الشريط القياسي والأوامر. الأمثل للاستخدام مع ماوس."
                Case BarString.RibbonGalleryFilterNone
                Return "لا شيء"
                Case BarString.FullScreenButton
                Return "صناعة السيارات في إخفاء الشريط"
                Case BarString.MenuAnimationUnfold
                Return "تتكشف"
                Case BarString.RibbonCustomizationImportSettingsCommand
                Return "استيراد ملف التخصيص"
                Case BarString.RibbonCustomizationDownText
                Return "تحريك لأسفل"
                Case BarString.ResetButton
                Return "آند إعادة تعيين شريط الأدوات"
                Case BarString.SkinsMain
                Return "جلود القياسية"
                Case BarString.MenuAnimationRandom
                Return "عشوائية"
                Case BarString.ToolbarNameCaption
                Return "آند اسم شريط الأدوات:"
                Case BarString.ColorAuto
                Return "تلقائي"
                Case BarString.BarUnassignedItems
                Return "(العناصر غير المعينة)"
                Case BarString.RibbonCustomizationExportSettingsCommand
                Return "تصدير كافة التخصيصات"
                Case BarString.RibbonCustomizationUpText
                Return "تحريك لأعلى"
                Case BarString.SkinsOffice
                Return "مكتب جلود"
                Case BarString.BarAllItems
                Return "(جميع البنود)"
                Case BarString.ExpandRibbonSuperTipText
                Return "إظهار الشريط بحيث يتم توسيعه دائماً حتى بعد النقر فوق أحد الأوامر"
                Case BarString.AccordionControlSearchBoxPromptText
                Return "اكتب الكلمات الأساسية هنا"
                Case BarString.RibbonToolbarAbove
                Return "آند إظهار شريط أدوات الوصول السريع أعلى الشريط"
                Case BarString.RibbonCustomizationNewTabDefaultAlias
                Return "علامة تبويب جديدة"
                Case BarString.RibbonCaptionTextNone
                Return "لا يوجد اسم"
                Case BarString.SkinsTheme
                Return "موضوع الجلود"
                Case BarString.RibbonUnassignedPages
                Return "(صفحات غير المعينة)"
                Case BarString.CollapseRibbonSuperTipText
                Return "تظهر أسماء علامات التبويب فقط على الشريط"
                Case BarString.RibbonFullScreenItemCaption
                Return "صناعة السيارات في إخفاء الشريط"
                Case BarString.RibbonAllPages
                Return "(جميع الصفحات)"
                Case BarString.MoreCommands
                Return "آند المزيد من الأوامر..."
                Case BarString.NewToolbarName
                Return "أدوات"
                Case BarString.RibbonFullScreenItemDescription
                Return "إخفاء الشريط. انقر فوق في الجزء العلوي من التطبيق لإظهار ذلك."
                Case BarString.CustomizeRibbon
                Return "تخصيص & الشريط..."
                Case BarString.RibbonMinimizedItemCaption
                Return "إظهار علامات التبويب"

                Case Else
                Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
    Public Class HebrewBarLocalizer
        Inherits BarLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As BarString) As String
            Select Case id
                Case BarString.NewMenuName
                Return "תפריט ראשי"
                Case BarString.SkinsBonus
                Return "בונוס עורות"
                Case BarString.NewToolbarCaption
                Return "סרגל כלים חדש"
                Case BarString.RibbonMinimizedItemDescription
                Return "הצג רק את כרטיסיות רצועת הכלים. לחץ על כרטיסיה כדי להציג את הפקודות."
                Case BarString.RibbonTouchMouseModeCommandText
                Return "מצב מגע/עכבר"
                Case BarString.CustomizeQuickAccessToolbar
                Return "& להתאים אישית את סרגל הכלים לגישה מהירה..."
                Case BarString.PopupMenuEditor
                Return "עורך התפריטים מוקפץ"
                Case BarString.RibbonToolbarBelow
                Return "& להציג סרגל הכלים גישה מהירה מתחת לרצועת הכלים"
                Case BarString.NewStatusBarName
                Return "שורת מצב"
                Case BarString.RibbonCustomizationNewGroupDefaultAlias
                Return "קבוצה חדשה"
                Case BarString.SkinsCustom
                Return "מעטפת מותאמים אישית"
                Case BarString.NewToolbarCustomNameFormat
                Return "{0} מותאם אישית"
                Case BarString.RibbonExpandedItemCaption
                Return "הצג כרטיסיות ופקודות"
                Case BarString.RibbonTouchMouseModeGalleryGroupText
                Return "למטב את הרווח בין הפקודות."
                Case BarString.RibbonToolbarAdd
                Return "& הוסף לסרגל הכלים לגישה מהירה"
                Case BarString.CloseButton
                Return "סגור"
                Case BarString.CustomizeToolbarText
                Return "התאמה אישית של סרגל הכלים"
                Case BarString.AddOrRemove
                Return "& להוסיף או להסיר לחצני"
                Case BarString.RibbonCustomizationNewCategoryDefaultAlias
                Return "קטגוריה חדשה"
                Case BarString.RibbonExpandedItemDescription
                Return "להציג כרטיסיות רצועת הכלים ועל פקודות כל הזמן."
                Case BarString.RibbonTouchMouseModeTouchItemText
                Return "מגע"
                Case BarString.RibbonToolbarMinimizeRibbon
                Return "Mi & nimize רצועת הכלים"
                Case BarString.SkinCaptions
                Return "| DevExpress Style| Caramel| Twins| כסף Style|iMaginary| DevExpress כהה Lilian| Black| Blue| Office 2010 Blue| Office 2010 Black| Office 2010 Silver| Office 2007 Blue| Office 2007 Black| Office 2007 Silver| Office 2007 Green| Office 2007 Pink| Seven| Classic| שבע Darkroom| McSkin| Sharp| Plus| חד Foggy| Side| האפל חג המולד (כחול) | Springtime| Summer| Pumpkin| Valentine| Stardust| Coffee| זכוכית Oceans| Contrast| גבוה Sky| נוזלי Sky| נוזלי לונדון World| אספלט Blueprint| Whiteprint| Visual Studio 2010| Metropolis| Dark| מטרופוליס Office 2013 White| Office 2013 אפל Gray| Office 2013 אור Gray| Visual Studio 2013 Blue| Visual Studio 2013 Dark| Visual Studio 2013 Light| Office 2016 Colorful| Office 2016 Dark|"
                Case BarString.RenameToolbarCaption
                Return "לשנות שם סרגל כלים"
                Case BarString.CustomizeToolbarSuperTipText
                Return "התאמה אישית של סרגל הכלים לגישה מהירה"
                Case BarString.MinimizeButton
                Return "מזעור"
                Case BarString.CustomizeButton
                Return "& אישית של..."
                Case BarString.RibbonTouchMouseModeMouseItemText
                Return "העכבר"
                Case BarString.Visible
                Return "גלוי"
                Case BarString.RibbonCustomizationNewCategoryCommand
                Return "קטגוריה חדשה"
                Case BarString.RibbonToolbarRemove
                Return "& להסיר את סרגל הכלים לגישה מהירה"
                Case BarString.ShowScreenTipsOnToolbarsName
                Return "הצג תיאורי מסך בסרגלי"
                Case BarString.MaximizeButton
                Return "למקסם"
                Case BarString.CancelButton
                Return "ביטול"
                Case BarString.CustomizeWindowCaption
                Return "התאמה אישית"
                Case BarString.RibbonCustomizationOptionAllTabs
                Return "כל הכרטיסיות"
                Case BarString.RibbonTouchMouseModeTouchItemDescription
                Return "מקום רב יותר בין הפקודות. ממוטב לשימוש במגע."
                Case BarString.RibbonGalleryFilter
                Return "כל הקבוצות"
                Case BarString.RestoreButton
                Return "שחזור למטה"
                Case BarString.ResetBar
                Return "האם אתה בטוח שברצונך לאפס את השינויים שבוצעו לסרגל הכלים '{0}'?"
                Case BarString.RibbonCustomizationNewPageCommand
                Return "בכרטיסיה חדשה"
                Case BarString.ShowShortcutKeysOnScreenTipsName
                Return "הצג קיצורי מקשים בתיאורי מסך"
                Case BarString.ToolBarMenu
                Return "& איפוס $& $מחק! & שם $! Defau & זה סגנון $& טקסט בלבד (תמיד) $Text & בלבד (בתפריטים) $Image & ו- $ טקסט! מתחילים & הקבוצה $& $גלוי & ביותר שנעשה בהם שימוש לאחרונה"
                Case BarString.MenuAnimationSystem
                Return "(ברירת מחדל של המערכת)"
                Case BarString.RibbonTouchMouseModeMouseItemDescription
                Return "תקן רצועת הכלים, פקודות. ממוטב לשימוש עם עכבר."
                Case BarString.RibbonGalleryFilterNone
                Return "אף אחד"
                Case BarString.RibbonCustomizationOptionAllCommands
                Return "כל הפקודות"
                Case BarString.ResetBarCaption
                Return "התאמה אישית"
                Case BarString.HelpButton
                Return "עזרה"
                Case BarString.RibbonCustomizationNewGroupCommand
                Return "קבוצה חדשה"
                Case BarString.ToolbarNameCaption
                Return "& שם סרגל הכלים:"
                Case BarString.ColorAuto
                Return "אוטומטי"
                Case BarString.ExpandRibbonSuperTipHeader
                Return "הרחב את הכלים (Ctrl + F1)"
                Case BarString.MenuAnimationNone
                Return "אף אחד"
                Case BarString.BarUnassignedItems
                Return "(פריטים שלא הוקצו)"
                Case BarString.RibbonCustomizationStandardCustomItemSuffix
                Return "מותאם אישית"
                Case BarString.FullScreenButton
                Return "הסתר אוטומטית את רצועת הכלים"
                Case BarString.MenuAnimationFade
                Return "עמעום"
                Case BarString.ResetButton
                Return "& לאפס את סרגל הכלים"
                Case BarString.RibbonCustomizationRenameText
                Return "שינוי שם"
                Case BarString.CollapseRibbonSuperTipHeader
                Return "למזער את רצועת הכלים (Ctrl + F1)"
                Case BarString.AccordionControlSearchBoxPromptText
                Return "סוג מילות מפתח כאן"
                Case BarString.MenuAnimationSlide
                Return "שקופית"
                Case BarString.BarAllItems
                Return "(כל הפריטים)"
                Case BarString.RibbonCustomizationResetSelectedTabSettingsCommand
                Return "איפוס רק שנבחרו בכרטיסיה של רצועת הכלים"
                Case BarString.SkinsMain
                Return "פריטי מעטפת תקניים"
                Case BarString.ExpandRibbonSuperTipText
                Return "להראות את הסרט כך היא תמיד מורחבת גם לאחר לחיצה על פקודה"
                Case BarString.MenuAnimationUnfold
                Return "להתגלות"
                Case BarString.RibbonFullScreenItemCaption
                Return "הסתר אוטומטית את רצועת הכלים"
                Case BarString.RibbonCustomizationRemoveText
                Return "הסר"
                Case BarString.RibbonCustomizationResetSettingsCommand
                Return "איפוס כל ההתאמות האישיות"
                Case BarString.RibbonUnassignedPages
                Return "(עמודים שלא הוקצו)"
                Case BarString.RibbonCustomizationAddText
                Return "להוסיף"
                Case BarString.SkinsOffice
                Return "Office עורות"
                Case BarString.MenuAnimationRandom
                Return "אקראי"
                Case BarString.CollapseRibbonSuperTipText
                Return "הצג רק שמות הכרטיסיות ברצועת הכלים"
                Case BarString.RibbonFullScreenItemDescription
                Return "הסתר את רצועת הכלים. לחץ בחלק העליון של היישום כדי להציג אותו."
                Case BarString.RibbonCustomizationImportSettingsCommand
                Return "ייבוא קובץ ההתאמה האישית"
                Case BarString.RibbonAllPages
                Return "(כל דפים)"
                Case BarString.SkinsTheme
                Return "דירוג עורות"
                Case BarString.RibbonCustomizationDownText
                Return "הזז למטה"
                Case BarString.MoreCommands
                Return "& פקודות נוספות..."
                Case BarString.RibbonToolbarAbove
                Return "& להציג סרגל הכלים גישה מהירה מעל רצועת הכלים"
                Case BarString.RibbonMinimizedItemCaption
                Return "סרגל הלשוניות"
                Case BarString.RibbonCustomizationExportSettingsCommand
                Return "ייצוא כל ההתאמות האישיות"
                Case BarString.NewToolbarName
                Return "כלים"
                Case BarString.RibbonCustomizationUpText
                Return "הזז למעלה"
                Case BarString.CustomizeRibbon
                Return "להתאים אישית רצועת הכלים &..."
                Case BarString.RibbonCustomizationNewTabDefaultAlias
                Return "בכרטיסיה חדשה"
                Case BarString.RibbonCaptionTextNone
                Return "אין שם"
                Case Else
                Return MyBase.GetLocalizedString(id)
            End Select

        End Function
    End Class
End Namespace
