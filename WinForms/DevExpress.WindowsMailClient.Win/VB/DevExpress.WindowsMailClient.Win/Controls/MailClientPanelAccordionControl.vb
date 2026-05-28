Imports System.ComponentModel
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace DevExpress.WindowsMailClient.Win.Controls

    Public Class MailClientPanelAccordionControl
        Inherits AccordionControl

        Protected Overrides Function CreatePainter() As BaseControlPainter
            Return New MailClientAccordionControlPainter()
        End Function

        Protected Overrides Function CreateViewInfo() As BaseStyleControlViewInfo
            Return New MailClientAccordionControlViewInfo(Me)
        End Function

        <DefaultValue(0)>
        Public Property ContentTopIndent As Integer
    End Class

    Public Class MailClientAccordionControlViewInfo
        Inherits AccordionControlViewInfo

        Public Sub New(ByVal owner As AccordionControl)
            MyBase.New(owner)
        End Sub
    End Class

    Friend Class MailClientAccordionControlPainter
        Inherits AccordionControlPainter

        Protected Overrides Function DrawElementDCompBackground(ByVal cache As GraphicsCache, ByVal elementInfo As AccordionElementBaseViewInfo) As Boolean
            Return elementInfo.Element.Style = ElementStyle.Group
        End Function
    End Class
End Namespace
