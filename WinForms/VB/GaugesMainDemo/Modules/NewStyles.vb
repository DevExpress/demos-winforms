Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win.Gauges.Digital
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Win.Base

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class GaugesNewStyles
        Inherits TutorialControl

        Private animationLockCounterCore As Integer = 0

        Private timer As Timer

        Private ReadOnly Property IsAnimationLocked As Boolean
            Get
                Return animationLockCounterCore > 0
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AddHandler Load, New EventHandler(AddressOf OnLoad)
        End Sub

        Private Overloads Sub OnLoad(ByVal sender As Object, ByVal e As EventArgs)
            timer = New Timer()
            timer.Interval = 166
            AddHandler timer.Tick, New EventHandler(AddressOf OnTimerTick)
            timer.Start()
        End Sub

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If IsAnimationLocked Then Return
            Dim activePage As XtraBars.Navigation.TabNavigationPage = xtraTabControl1.SelectedPage
            If Not xtraTabControl1.Visible OrElse activePage Is Nothing Then Return
            LockAnimation()
            Dim gauges As List(Of GaugeControl) = CollectChildGauges(activePage)
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
                If dGauge IsNot Nothing Then
                    dGauge.Text = AnimateStringValue(dGauge)
                End If
            Next
        End Sub

        Private Function AnimateScaleValue(ByVal scale As IScale) As Single
            Dim random = Data.Utils.NonCryptographicRandom.System
            Dim deviation As Single =(CSng(random.NextDouble()) - TryCast(scale, IConvertibleScale).Percent)
            Return scale.Value + scale.ScaleLength * 0.025F * deviation
        End Function

        Private Function AnimateStringValue(ByVal dGauge As DigitalGauge) As String
            Dim value As Integer = Date.Now.Second * 1000 + Date.Now.Millisecond
            Return value.ToString()
        End Function

        Private Function CollectChildGauges(ByVal parentControl As Control) As List(Of GaugeControl)
            Dim result As List(Of GaugeControl) = New List(Of GaugeControl)()
            For Each control As Control In parentControl.Controls
                If TypeOf control Is GaugeControl Then
                    result.Add(TryCast(control, GaugeControl))
                ElseIf control.Controls.Count > 0 Then
                    result.AddRange(CollectChildGauges(control))
                End If
            Next

            Return result
        End Function
    End Class
End Namespace
