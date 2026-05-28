Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Styles
Imports DevExpress.XtraGauges.Presets.Localization
Imports DevExpress.XtraGauges.Presets.Styles
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGauges.Win.Gauges.Digital
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class GaugeStylesXPF
        Inherits TutorialControl

        Private radioButton As List(Of RadioButton) = New List(Of RadioButton)()

        Public Sub New()
            InitializeComponent()
            timer = New Timer()
            timer.Interval = 166
            AddHandler timer.Tick, AddressOf OnTimerTick
            ApplyLocalization()
        End Sub

        Private Sub ApplyLocalization()
            Clever.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeClever)
            Classic.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeClassic)
            Future.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeFuture)
            MagicLight.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeMagicLight)
            iStyle.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeiStyle)
            Eco.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeEco)
            Cosmic.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeCosmic)
            Smart.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeSmart)
            Progressive.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeProgressive)
            YellowSubmarine.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeYellowSubmarine)
            Red.Text = GaugesPresetsLocalizer.GetString(GaugesPresetsStringId.ThemeRed)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            For Each item In layoutControl1.Controls
                If TypeOf item Is RadioButton Then radioButton.Add(CType(item, RadioButton))
            Next

            timer.Start()
        End Sub

        Private Sub ApplySelectStyle(ByVal sender As Object, ByVal e As EventArgs)
            For Each item As RadioButton In radioButton
                If item.Checked Then OnThemeRadioButtonCheckedChanged(item, EventArgs.Empty)
            Next
        End Sub

        Private Sub OnThemeRadioButtonCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If tabbedControlGroup2.SelectedTabPage Is Nothing Then Return
            Dim radioButton As RadioButton = TryCast(sender, RadioButton)
            If radioButton.Checked Then
                Dim key As StyleCollectionKey = New StyleCollectionKey(tabbedControlGroup2.SelectedTabPage.Name)
                key.Name = radioButton.Text.Replace(" ", "")
                key.Tag = CStr(tabbedControlGroup2.SelectedTabPage.Tag)
                Dim styleCollection As StyleCollection = StyleLoader.Load(key)
                If styleCollection Is Nothing Then Return
                Select Case tabbedControlGroup2.SelectedTabPage.Name
                    Case "Circular"
                        styleCollection.Apply(circularGauge1)
                    Case "Digital"
                        styleCollection.Apply(digitalGauge1)
                    Case "Linear"
                        styleCollection.Apply(linearGauge1)
                End Select
            End If
        End Sub

#Region "Animation"
        Private animationLockCounterCore As Integer = 0

        Private ReadOnly timer As Timer

        Private ReadOnly Property IsAnimationLocked As Boolean
            Get
                Return animationLockCounterCore > 0
            End Get
        End Property

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If IsAnimationLocked Then Return
            Dim activePage As LayoutGroup = tabbedControlGroup2.SelectedTabPage
            If Not tabbedControlGroup2.Visible OrElse activePage Is Nothing Then Return
            LockAnimation()
            Dim gauges As List(Of GaugeControl) = CollectChildGauges()
            For Each gauge As GaugeControl In gauges
                DoAnimation(gauge)
            Next

            UnlockAnimation()
        End Sub

        Private Sub UnlockAnimation()
            animationLockCounterCore -= 1
        End Sub

        Private Sub LockAnimation()
            animationLockCounterCore += 1
        End Sub

        Private Sub DoAnimation(ByVal gauge As GaugeControl)
            For Each gb As IGauge In gauge.Gauges
                Dim cGauge As ICircularGauge = TryCast(gb, ICircularGauge)
                If cGauge IsNot Nothing Then
                    For Each _scale As IScale In cGauge.Scales
                        _scale.Value = AnimateScaleValue(_scale)
                    Next
                End If

                Dim lGauge As ILinearGauge = TryCast(gb, ILinearGauge)
                If lGauge IsNot Nothing Then
                    For Each _scale As IScale In lGauge.Scales
                        _scale.Value = AnimateScaleValue(_scale)
                    Next
                End If

                Dim dGauge As DigitalGauge = TryCast(gb, DigitalGauge)
                If dGauge IsNot Nothing Then dGauge.Text = AnimateStringValue(dGauge)
            Next
        End Sub

        Private Function CollectChildGauges() As List(Of GaugeControl)
            Dim result As List(Of GaugeControl) = New List(Of GaugeControl)()
            For Each item In layoutControl1.Controls
                If TypeOf item Is GaugeControl Then result.Add(CType(item, GaugeControl))
            Next

            Return result
        End Function

        Private Function AnimateScaleValue(ByVal scale As IScale) As Single
            Dim random = Data.Utils.NonCryptographicRandom.System
            Dim deviation As Single =(CSng(random.NextDouble()) - TryCast(scale, IConvertibleScale).Percent)
            Return scale.Value + scale.ScaleLength * 0.025F * deviation
        End Function

        Private Function AnimateStringValue(ByVal dGauge As DigitalGauge) As String
            Dim value As Integer = Date.Now.Second * 1000 + Date.Now.Millisecond
            Return value.ToString()
        End Function

#End Region
        Protected Overrides ReadOnly Property UseRoundedPanel As Boolean?
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
