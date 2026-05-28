Imports DevExpress.XtraNavBar
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DevExpress.MailClient.Win.Localizer
    Public Class FarsiNavBarLocalizer
        Inherits NavBarLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As NavBarStringId) As String
            Select Case id
                Case NavBarStringId.NavPaneMenuShowFewerButtons
                Return "نمایش & دکمه های کمتر"
                Case NavBarStringId.NavPaneOptionsFormDescription
                Return "نمایش دکمه های این ترتیب"
                Case NavBarStringId.NavPaneMenuShowMoreButtons
                Return "نمایش & دکمه های بیشتر"
                Case NavBarStringId.NavPaneMenuAddRemoveButtons
                Return "& افزودن یا حذف دکمه ها"
                Case NavBarStringId.NavPaneChevronHint
                Return "پیکربندی دکمه ها"
                Case NavBarStringId.NavPaneMenuPaneOptions
                Return "Na&vigation گزینه های صفحه..."
                Case NavBarStringId.NavPaneOptionsFormMoveUp
                Return "حرکت به بالا"
                Case NavBarStringId.NavPaneOptionsFormMoveDown
                Return "حرکت به پایین"
                Case NavBarStringId.NavPaneOptionsFormFont
                Return "نوع خط"
                Case NavBarStringId.NavPaneOptionsFormReset
                Return "تنظیم مجدد"
                Case NavBarStringId.NavPaneOptionsFormOk
                Return "باشه"
                Case NavBarStringId.NavPaneOptionsFormCancel
                Return "لغو"
                Case Else
                Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class
    Public Class ArabicNavBarLocalizer
        Inherits NavBarLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As NavBarStringId) As String
            Select Case id
                Case NavBarStringId.NavPaneMenuShowFewerButtons
                Return "إظهار & أزرار أقل"
                Case NavBarStringId.NavPaneOptionsFormDescription
                Return "عرض الأزرار بالترتيب"
                Case NavBarStringId.NavPaneMenuShowMoreButtons
                Return "إظهار & المزيد من الأزرار"
                Case NavBarStringId.NavPaneMenuAddRemoveButtons
                Return "آند إضافة أو إزالة الأزرار"
                Case NavBarStringId.NavPaneChevronHint
                Return "تكوين الأزرار"
                Case NavBarStringId.NavPaneOptionsFormMoveUp
                Return "تحريك لأعلى"
                Case NavBarStringId.NavPaneOptionsFormMoveDown
                Return "تحريك لأسفل"
                Case NavBarStringId.NavPaneOptionsFormFont
                Return "الخط"
                Case NavBarStringId.NavPaneOptionsFormReset
                Return "إعادة تعيين"
                Case NavBarStringId.NavPaneOptionsFormOk
                Return "موافق"
                Case NavBarStringId.NavPaneOptionsFormCancel
                Return "إلغاء الأمر"
                Case Else
                Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class
    Public Class HebrewNavBarLocalizer
        Inherits NavBarLocalizer

        Public Overrides Function GetLocalizedString(ByVal id As NavBarStringId) As String
            Select Case id
                Case NavBarStringId.NavPaneOptionsFormFont
                Return "גופן"
                Case NavBarStringId.NavPaneOptionsFormDescription
                Return "להציג את הלחצנים בסדר זה"
                Case NavBarStringId.NavPaneMenuShowFewerButtons
                Return "הצג & פחות לחצנים"
                Case NavBarStringId.NavPaneOptionsFormMoveUp
                Return "הזז למעלה"
                Case NavBarStringId.NavPaneMenuShowMoreButtons
                Return "הצג & לחצנים נוספים"
                Case NavBarStringId.NavPaneOptionsFormReset
                Return "איפוס"
                Case NavBarStringId.NavPaneMenuAddRemoveButtons
                Return "& להוסיף או להסיר לחצני"
                Case NavBarStringId.NavPaneOptionsFormOk
                Return "אוקיי"
                Case NavBarStringId.NavPaneOptionsFormMoveDown
                Return "הזז למטה"
                Case NavBarStringId.NavPaneChevronHint
                Return "קביעת תצורה של לחצנים"
                Case NavBarStringId.NavPaneOptionsFormCancel
                Return "ביטול"
                Case NavBarStringId.NavPaneMenuPaneOptions
                Return "נה & vigation אפשרויות חלונית..."
                Case Else
                Return MyBase.GetLocalizedString(id)
            End Select
        End Function
    End Class
End Namespace
