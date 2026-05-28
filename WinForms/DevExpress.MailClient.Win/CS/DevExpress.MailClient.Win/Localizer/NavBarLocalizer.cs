using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.MailClient.Win.Localizer {
    public class FarsiNavBarLocalizer : NavBarLocalizer {
        public override string GetLocalizedString(NavBarStringId id) {
            switch(id) {
                case NavBarStringId.NavPaneMenuShowFewerButtons:
                return "نمایش & دکمه های کمتر";
                case NavBarStringId.NavPaneOptionsFormDescription:
                return "نمایش دکمه های این ترتیب";
                case NavBarStringId.NavPaneMenuShowMoreButtons:
                return "نمایش & دکمه های بیشتر";
                case NavBarStringId.NavPaneMenuAddRemoveButtons:
                return "& افزودن یا حذف دکمه ها";
                case NavBarStringId.NavPaneChevronHint:
                return "پیکربندی دکمه ها";
                case NavBarStringId.NavPaneMenuPaneOptions:
                return "Na&vigation گزینه های صفحه...";
                case NavBarStringId.NavPaneOptionsFormMoveUp:
                return "حرکت به بالا";
                case NavBarStringId.NavPaneOptionsFormMoveDown:
                return "حرکت به پایین";
                case NavBarStringId.NavPaneOptionsFormFont:
                return "نوع خط";
                case NavBarStringId.NavPaneOptionsFormReset:
                return "تنظیم مجدد";
                case NavBarStringId.NavPaneOptionsFormOk:
                return "باشه";
                case NavBarStringId.NavPaneOptionsFormCancel:
                return "لغو";
                default:
                return base.GetLocalizedString(id);
            }
        }
    }
    public class ArabicNavBarLocalizer : NavBarLocalizer {
        public override string GetLocalizedString(NavBarStringId id) {
            switch(id) {
                case NavBarStringId.NavPaneMenuShowFewerButtons:
                return "إظهار & أزرار أقل";
                case NavBarStringId.NavPaneOptionsFormDescription:
                return "عرض الأزرار بالترتيب";
                case NavBarStringId.NavPaneMenuShowMoreButtons:
                return "إظهار & المزيد من الأزرار";
                case NavBarStringId.NavPaneMenuAddRemoveButtons:
                return "آند إضافة أو إزالة الأزرار";
                case NavBarStringId.NavPaneChevronHint:
                return "تكوين الأزرار";
                case NavBarStringId.NavPaneOptionsFormMoveUp:
                return "تحريك لأعلى";
                case NavBarStringId.NavPaneOptionsFormMoveDown:
                return "تحريك لأسفل";
                case NavBarStringId.NavPaneOptionsFormFont:
                return "الخط";
                case NavBarStringId.NavPaneOptionsFormReset:
                return "إعادة تعيين";
                case NavBarStringId.NavPaneOptionsFormOk:
                return "موافق";
                case NavBarStringId.NavPaneOptionsFormCancel:
                return "إلغاء الأمر";
                default:
                return base.GetLocalizedString(id);
            }
        }
    }
    public class HebrewNavBarLocalizer : NavBarLocalizer {
        public override string GetLocalizedString(NavBarStringId id) {
            switch(id) {
                case NavBarStringId.NavPaneOptionsFormFont:
                return "גופן";
                case NavBarStringId.NavPaneOptionsFormDescription:
                return "להציג את הלחצנים בסדר זה";
                case NavBarStringId.NavPaneMenuShowFewerButtons:
                return "הצג & פחות לחצנים";
                case NavBarStringId.NavPaneOptionsFormMoveUp:
                return "הזז למעלה";
                case NavBarStringId.NavPaneMenuShowMoreButtons:
                return "הצג & לחצנים נוספים";
                case NavBarStringId.NavPaneOptionsFormReset:
                return "איפוס";
                case NavBarStringId.NavPaneMenuAddRemoveButtons:
                return "& להוסיף או להסיר לחצני";
                case NavBarStringId.NavPaneOptionsFormOk:
                return "אוקיי";
                case NavBarStringId.NavPaneOptionsFormMoveDown:
                return "הזז למטה";
                case NavBarStringId.NavPaneChevronHint:
                return "קביעת תצורה של לחצנים";
                case NavBarStringId.NavPaneOptionsFormCancel:
                return "ביטול";
                case NavBarStringId.NavPaneMenuPaneOptions:
                return "נה & vigation אפשרויות חלונית...";
                default:
                return base.GetLocalizedString(id);
            }
        }
    }
}
