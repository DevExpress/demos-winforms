Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.HTML.Demos.Modules.AccordionControl

    Public Class HtmlComboBoxEdit
        Inherits ComboBoxEdit

        Public Sub New()
            AddHandler PaintEx, AddressOf OnPaintEx
            Width = 162
            Height = 36
            Properties.TextEditStyle = XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Properties.AutoHeight = False
            Properties.UseAdvancedMode = Utils.DefaultBoolean.True
            context = New DxHtmlPainterContext()
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Protected Friend Property HtmlTemplate As HtmlTemplate

        Private Sub OnPaintEx(ByVal sender As Object, ByVal e As TextEditPaintExEventArgs)
            If HtmlTemplate Is Nothing Then Return
            Dim args = New DxHtmlPainterArgs()
            args.Cache = e.Cache
            args.Bounds = New Rectangle(Point.Empty, Size)
            args.LookAndFeel = LookAndFeel
            Dim hasValue As Boolean = SelectedIndex >= 0
            args.SetFieldValue("Value", If(hasValue, EditValue, Properties.NullValuePrompt))
            args.SetFieldValue("HasValue", hasValue)
            args.HtmlImages = Properties.HtmlImages
            DxHtmlPainter.Default.Draw(HtmlTemplate, args, context)
        End Sub

        Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
            MyBase.OnMouseMove(e)
            context.OnMouseMove(e)
            Invalidate()
        End Sub

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            Dim result = context.CalcHitInfo(e.Location)
            If result Is Nothing Then Return
            If IsPopupOpen Then
                ClosePopup()
            Else
                ShowPopup()
            End If
        End Sub

        Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
            MyBase.OnMouseLeave(e)
            context.OnMouseLeave(e)
            Invalidate()
        End Sub

        Private context As DxHtmlPainterContext
    End Class
End Namespace
