Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Primitive

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class InteractionFeature
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub gaugeControl1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            CheckCursor(TryCast(gaugeControl1, IGaugeContainer), e)
            If e.Button = MouseButtons.Left Then CalculateMouseValue(TryCast(gaugeControl1, IGaugeContainer), arcScaleComponent1, e)
        End Sub

        Private Sub gaugeControl2_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            CheckCursor(TryCast(gaugeControl2, IGaugeContainer), e)
            If e.Button = MouseButtons.Left Then CalculateMouseValue(TryCast(gaugeControl2, IGaugeContainer), linearScaleComponent1, e)
        End Sub

        Private Sub gaugeControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            CalculateMouseValue(TryCast(gaugeControl1, IGaugeContainer), arcScaleComponent1, e)
        End Sub

        Private Sub gaugeControl2_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            CalculateMouseValue(TryCast(gaugeControl2, IGaugeContainer), linearScaleComponent1, e)
        End Sub

        Private Sub CalculateMouseValue(ByVal container As IGaugeContainer, ByVal scale As IConvertibleScaleEx, ByVal e As MouseEventArgs)
            Dim hi As BasePrimitiveHitInfo = container.CalcHitInfo(e.Location)
            If hi.Element IsNot Nothing AndAlso Not hi.Element.IsComposite Then
                Dim modelPt As PointF = MathHelper.PointToModelPoint(TryCast(scale, IElement(Of IRenderableElement)), New PointF(e.X, e.Y))
                Dim percent As Single = scale.PointToPercent(modelPt)
                scale.Value = scale.PercentToValue(percent)
            End If
        End Sub

        Private Sub CheckCursor(ByVal container As IGaugeContainer, ByVal e As MouseEventArgs)
            Dim hi As BasePrimitiveHitInfo = container.CalcHitInfo(e.Location)
            Dim _cursor As Cursor = If(hi.Element IsNot Nothing AndAlso Not hi.Element.IsComposite, Utils.Controls.DXCursors.Hand, Cursors.Default)
            If CType(container, Control).Cursor IsNot _cursor Then CType(container, Control).Cursor = _cursor
        End Sub
    End Class
End Namespace
