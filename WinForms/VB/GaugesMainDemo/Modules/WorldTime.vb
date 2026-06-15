Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win
Imports DevExpress.XtraGauges.Win.Base

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class WorldTime
        Inherits TutorialControl

        Private lockTimerCounter As Integer = 0

        Private animationLockCounterCore As Integer = 0

        Private timeShifts As Dictionary(Of String, Integer)

        Private ReadOnly Property IsAnimationLocked As Boolean
            Get
                Return animationLockCounterCore > 0
            End Get
        End Property

        Public Sub New()
            timeShifts = New Dictionary(Of String, Integer)()
            timeShifts.Add("Washington", -4)
            timeShifts.Add("Paris", +1)
            timeShifts.Add("Madrid", +1)
            timeShifts.Add("London", +0)
            timeShifts.Add("Tokyo", +9)
            timeShifts.Add("Rome", +1)
            InitializeComponent()
            timer.Start()
            OnTimerTick(Nothing, Nothing)
        End Sub

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If lockTimerCounter = 0 Then
                lockTimerCounter += 1
                If Not Visible OrElse IsAnimationLocked Then Return
                LockAnimation()
                Dim gauges As List(Of GaugeControl) = CollectChildGauges(layoutControl1)
                For Each gauge As GaugeControl In gauges
                    DoAnimation(gauge)
                Next

                UnlockAnimation()
                lockTimerCounter -= 1
            End If
        End Sub

        Private Sub UnlockAnimation()
            animationLockCounterCore -= 1
        End Sub

        Private Sub LockAnimation()
            animationLockCounterCore += 1
        End Sub

        Private Sub DoAnimation(ByVal gauge As GaugeControl)
            Dim time As Date = Date.UtcNow.AddHours(timeShifts(gauge.Name))
            For Each gb As IGauge In gauge.Gauges
                Dim cGauge As ICircularGauge = TryCast(gb, ICircularGauge)
                If cGauge IsNot Nothing Then
                    UpdateClock(time, cGauge.Scales(0), cGauge.Scales(1), cGauge.Scales(2))
                End If
            Next
        End Sub

        Private Sub UpdateClock(ByVal dt As Date, ByVal h As IArcScale, ByVal m As IArcScale, ByVal s As IArcScale)
            Dim hour As Integer = If(dt.Hour <= 12, dt.Hour, dt.Hour - 12)
            Dim min As Integer = dt.Minute
            Dim sec As Integer = dt.Second
            h.Value = CSng(hour) + CSng(min) / 60.0F
            m.Value =(CSng(min) + CSng(sec) / 60.0F) / 5F
            s.Value = sec / 5.0F
        End Sub

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
