Imports System
Imports DevExpress.XtraGauges.Win.Gauges.Circular
Imports DevExpress.XtraGauges.Core.Model

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class AnalogClock
        Inherits TutorialControl

        Private scaleMinutes, scaleSeconds As ArcScaleComponent

        Private lockTimerCounter As Integer = 0

        Public Sub New()
            InitializeComponent()
            scaleMinutes = circularGauge1.AddScale()
            scaleSeconds = circularGauge1.AddScale()
            scaleMinutes.Assign(scaleHours)
            scaleSeconds.Assign(scaleHours)
            arcScaleNeedleComponent2.ArcScale = scaleMinutes
            arcScaleNeedleComponent3.ArcScale = scaleSeconds
            timer.Start()
            OnTimerTick(Nothing, Nothing)
        End Sub

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If lockTimerCounter = 0 Then
                lockTimerCounter += 1
                UpdateClock(Date.Now, scaleHours, scaleMinutes, scaleSeconds)
                lockTimerCounter -= 1
            End If
        End Sub

        Private Sub UpdateClock(ByVal dt As Date, ByVal h As IArcScale, ByVal m As IArcScale, ByVal s As IArcScale)
            Dim hour As Integer = If(dt.Hour < 12, dt.Hour, dt.Hour - 12)
            Dim min As Integer = dt.Minute
            Dim sec As Integer = dt.Second
            h.Value = CSng(hour) + CSng(min) / 60.0F
            m.Value =(CSng(min) + CSng(sec) / 60.0F) / 5F
            s.Value = sec / 5.0F
        End Sub
    End Class
End Namespace
