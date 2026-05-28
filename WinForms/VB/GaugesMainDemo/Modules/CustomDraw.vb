Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Data.Utils
Imports DevExpress.Drawing
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Primitive

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class CustomDrawFeature
        Inherits TutorialControl

        Private IsDisposing As Boolean

        Public Sub New()
            InitializeComponent()
            ceAllowCustomDraw.Checked = True
            SubscribeEvents()
        End Sub

#Region "Infrastructure"
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            IsDisposing = True
            If disposing AndAlso components IsNot Nothing Then
                UnsubscribeEvents()
                timer.Stop()
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub SubscribeEvents()
            AddHandler Load, AddressOf OnLoad
            AddHandler arcScale.CustomDrawElement, AddressOf Scale_CustomDrawElement
            AddHandler linearScale.CustomDrawElement, AddressOf Scale_CustomDrawElement
            AddHandler arcScaleNeedle.CustomDrawElement, AddressOf arcScaleNeedle_CustomDrawElement
            AddHandler arcScaleBackgroundLayer.CustomDrawElement, AddressOf arcScaleBackgroundLayer_CustomDrawElement
            AddHandler linearScaleLevel.CustomDrawElement, AddressOf linearScaleLevel_CustomDrawElement
            AddHandler linearScaleBackgroundLayer.CustomDrawElement, AddressOf linearScaleBackgroundLayer_CustomDrawElement
        End Sub

        Private Sub UnsubscribeEvents()
            RemoveHandler timer.Tick, AddressOf OnTimerTick
            RemoveHandler Load, AddressOf OnLoad
            RemoveHandler arcScale.CustomDrawElement, AddressOf Scale_CustomDrawElement
            RemoveHandler linearScale.CustomDrawElement, AddressOf Scale_CustomDrawElement
            RemoveHandler arcScaleNeedle.CustomDrawElement, AddressOf arcScaleNeedle_CustomDrawElement
            RemoveHandler arcScaleBackgroundLayer.CustomDrawElement, AddressOf arcScaleBackgroundLayer_CustomDrawElement
            RemoveHandler linearScaleLevel.CustomDrawElement, AddressOf linearScaleLevel_CustomDrawElement
            RemoveHandler linearScaleBackgroundLayer.CustomDrawElement, AddressOf linearScaleBackgroundLayer_CustomDrawElement
        End Sub

#End Region  ' Infrastructure
        Private handleCustomDraw As Boolean = False

        Private Sub ceAllowCustomDraw_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            handleCustomDraw = ceAllowCustomDraw.Checked
            arcScaleBackgroundLayer.Self.ResetCache(CacheKeys.RenderedImage)
            linearScaleBackgroundLayer.Self.ResetCache(CacheKeys.RenderedImage)
        End Sub

#Region "CustomDraw"
        Private Sub Scale_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
            If Not handleCustomDraw Then Return
            e.Handled = True
        End Sub

        Private Sub linearScaleBackgroundLayer_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
            If Not handleCustomDraw Then Return
            e.Handled = True
        End Sub

        Private pen As DXPen = New DXPen(Color.Black, 2F)

        Private Sub linearScaleLevel_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
            If Not handleCustomDraw Then Return
            For i As Integer = 0 To 5 - 1
                e.Context.DrawLine(DXPens.DarkGray, 60, 75 + i * 25, 190, 75 + i * 25)
            Next

            Dim pos As Single = 75 + CSng(Math.Round(linearScale.Percent * 8F)) * 12.5F
            e.Context.FillEllipse(DXBrushes.Black, New RectangleF(102, pos - 8, 19, 16))
            e.Context.DrawLine(pen, 120, pos - 45, 120, pos)
            e.Context.FillEllipse(DXBrushes.Black, New RectangleF(127, pos - 20.5F, 19, 16))
            e.Context.DrawLine(pen, 145, pos - 45, 145, pos - 12.5F)
            e.Context.DrawLine(pen, 120, pos - 44, 145, pos - 44)
            e.Context.DrawLine(pen, 120, pos - 36, 145, pos - 36)
            e.Handled = True
        End Sub

        Private Sub arcScaleBackgroundLayer_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
            If Not handleCustomDraw Then Return
            Dim _bounds As RectangleF = RectangleF.Inflate(e.Info.BoundBox, -15, -15)
            e.Context.FillEllipse(DXBrushes.Black, _bounds)
            _bounds.Inflate(-2, -2)
            e.Context.SetClip(New RectangleF(_bounds.Left + _bounds.Width * 0.5F, _bounds.Top, _bounds.Width * 0.5F, _bounds.Height))
            e.Context.FillEllipse(DXBrushes.White, _bounds)
            e.Context.ResetClip()
            e.Context.FillEllipse(DXBrushes.White, New RectangleF(_bounds.Left + _bounds.Width * 0.25F, _bounds.Top, _bounds.Width * 0.5F, _bounds.Height * 0.5F))
            e.Context.FillEllipse(DXBrushes.Black, New RectangleF(_bounds.Left + _bounds.Width * 0.25F, _bounds.Top + _bounds.Height * 0.5F, _bounds.Width * 0.5F, _bounds.Height * 0.5F))
            e.Handled = True
        End Sub

        Private Sub arcScaleNeedle_CustomDrawElement(ByVal sender As Object, ByVal e As CustomDrawElementEventArgs)
            If Not handleCustomDraw Then Return
            e.Context.FillEllipse(DXBrushes.White, New RectangleF(50, 112.5F, 25, 25))
            e.Context.FillEllipse(DXBrushes.Black, New RectangleF(175, 112.5F, 25, 25))
            e.Handled = True
        End Sub

#End Region  ' CustomDraw
#Region "Animation"
        Private timer As Timer

        Private Overloads Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs)
            timer = New Timer()
            timer.Interval = 350
            AddHandler timer.Tick, AddressOf OnTimerTick
            timer.Start()
        End Sub

        Private animationLockCounterCore As Integer = 0

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If animationLockCounterCore > 0 OrElse Not Visible OrElse IsDisposing OrElse IsDisposed Then Return
            If arcScale.IsDisposing OrElse linearScale.IsDisposing Then Return
            animationLockCounterCore += 1
            arcScale.Value = AnimateScaleValue(arcScale, 0.05F)
            linearScale.Value = AnimateScaleValue(linearScale, 0.75F)
            animationLockCounterCore -= 1
        End Sub

        Private Function AnimateScaleValue(ByVal scale As IBaseScale, ByVal factor As Single) As Single
            Dim deviation As Single = CSng(NonCryptographicRandom.Default.NextDouble()) - scale.Percent
            Return scale.Value + scale.ScaleLength * factor * deviation
        End Function
#End Region  ' Animation
    End Class
End Namespace
