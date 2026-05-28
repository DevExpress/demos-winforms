Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen

Namespace DevExpress.XtraEditors.Demos

    Public Partial Class ModuleOverlayForm
        Inherits TutorialControl

        Private ReadOnly options As OverlayWindowOptions

        Public Sub New()
            options = New OverlayWindowOptions(opacity:=100R / 255)
            InitializeComponent()
        End Sub

        Protected Overrides Sub UpdateTabControlPosition(ByVal tabControl As XtraTab.XtraTabControl)
        End Sub

        Protected Overrides Sub CalcContentCore()
            CalcLayoutControlBounds(layoutControl)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitValues()
        End Sub

        Private Sub InitValues()
            cbViewType.Properties.AddEnum(Of WaitAnimationType)()
            cbViewType.EditValue = WaitAnimationType.Line
            backColorEdit.Color = options.BackColor
            foreColorEdit.Color = options.ForeColor
            allowFadeInCheckEdit.Checked = options.FadeIn
            allowFadeOutCheckEdit.Checked = options.FadeOut
            spinOpacity.Value = CInt(options.Opacity.Value * 255 + 0.5)
        End Sub

        ' <backColorEdit>
        Private Sub OnBackColorEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim color As Color = CType(sender, ColorEdit).Color
            options.BackColor = color
        End Sub

        ' </backColorEdit>
        ' <foreColorEdit>
        Private Sub OnForeColorEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim color As Color = CType(sender, ColorEdit).Color
            options.ForeColor = color
        End Sub

        ' </foreColorEdit>
        ' <spinOpacity>
        Private Sub OnOpacityEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            options.Opacity = CByte(spinOpacity.Value) / 255R
        End Sub

        ' </spinOpacity>
        ' <allowFadeInCheckEdit>
        Private Sub OnAllowFadeInEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            options.FadeIn = CType(sender, CheckEdit).Checked
        End Sub

        ' </allowFadeInCheckEdit>
        ' <allowFadeOutCheckEdit>
        Private Sub OnAllowFadeOutEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            options.FadeOut = CType(sender, CheckEdit).Checked
        End Sub

        ' </allowFadeOutCheckEdit>
        ' <cbViewType>
        Private Sub OnViewTypeChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim animationType As WaitAnimationType = CType(CType(sender, BaseEdit).EditValue, WaitAnimationType)
            options.AnimationType = animationType
        End Sub

        ' </cbViewType>
        ' <btnShow>
        Private Sub OnShowClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim overlayHandle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(layoutControl, options)
            Dim timer As Timer = New Timer() With {.Interval = 4000}
            AddHandler timer.Tick, Sub(ss, ee)
                overlayHandle.Close()
                timer.Dispose()
            End Sub
            timer.Start()
        End Sub
    ' </btnShow>
    End Class
End Namespace
