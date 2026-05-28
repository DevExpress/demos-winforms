Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraLayout

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class AnimationScale
        Inherits TutorialControl

        Private functions As Dictionary(Of String, IEasingFunction) = New Dictionary(Of String, IEasingFunction)()

        Private modes As Dictionary(Of String, EasingMode) = New Dictionary(Of String, EasingMode)()

        Public Sub New()
            InitializeComponent()
            InitData()
            AddHandler Load, New EventHandler(AddressOf OnLoad)
        End Sub

        Private Sub InitData()
            functions.Add("BackEase", New BackEase())
            functions.Add("ElasticEase", New ElasticEase())
            functions.Add("PowerEase", New PowerEase(1))
            functions.Add("QuadraticEase", New QuadraticEase())
            functions.Add("QuinticEase", New QuinticEase())
            functions.Add("SineEase", New SineEase())
            functions.Add("ExponentialEase", New ExponentialEase())
            functions.Add("CircleEase", New CircleEase())
            functions.Add("BounceEase", New BounceEase())
            functions.Add("CubicEase", New CubicEase())
            modes.Add("EaseIn", EasingMode.EaseIn)
            modes.Add("EaseOut", EasingMode.EaseOut)
            modes.Add("EaseInOut", EasingMode.EaseInOut)
            For Each item In modes
                EaseFuction.Properties.Items.Add(item.Key)
            Next

            arcScaleComponent1.EnableAnimation = True
            linearScaleComponent1.EnableAnimation = True
            EaseFuction.SelectedIndex = 0
        End Sub

        Private Sub ChangeEaseMode(ByVal sender As Object, ByVal e As EventArgs)
            arcScaleComponent1.EasingMode = modes(EaseFuction.SelectedItem.ToString())
            linearScaleComponent1.EasingMode = modes(EaseFuction.SelectedItem.ToString())
        End Sub

        Private Sub ChangeEaseFunction(ByVal sender As Object, ByVal e As EventArgs)
            Dim radioButton As RadioButton = TryCast(sender, RadioButton)
            Dim key As String = radioButton.Name
            Dim [function] As IEasingFunction = Nothing
            If Not functions.TryGetValue(key, [function]) Then Return
            If radioButton.Checked Then
                arcScaleComponent1.EasingFunction = [function]
                linearScaleComponent1.EasingFunction = [function]
            End If
        End Sub

#Region "Animation"
        Private animationLockCounterCore As Integer = 0

        Private timer As Timer

        Private ReadOnly Property IsAnimationLocked As Boolean
            Get
                Return animationLockCounterCore > 0
            End Get
        End Property

        Private Overloads Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs)
            timer = New Timer()
            timer.Interval = 2000
            AddHandler timer.Tick, New EventHandler(AddressOf OnTimerTick)
            timer.Start()
        End Sub

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
            Return Data.Utils.NonCryptographicRandom.Default.Next(0, 100)
        End Function

#End Region
        Protected Overrides ReadOnly Property UseRoundedPanel As Boolean?
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
