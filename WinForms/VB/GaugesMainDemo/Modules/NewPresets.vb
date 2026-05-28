Imports System
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win.Base

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class NewPresets
        Inherits TutorialControl

        Private ReadOnly random As Data.Utils.NonCryptographicRandom = New Data.Utils.NonCryptographicRandom(10000)

        Private loadingCount As Integer = 0

        Public Sub New()
            InitializeComponent()
            InitLevelIndicatorPage()
            InitProgressPage()
            InitRatingPage()
            InitEqualizerPage()
            loadingTimer.Start()
            equalizerTimer.Interval = 200
            equalizerTimer.Start()
        End Sub

        Private Sub InitLevelIndicatorPage()
            equalizerLevel.Value = CInt(CType(levelIndicator.Gauges(0), ILinearGauge).Scales(0).Value)
        End Sub

        Private Sub InitProgressPage()
            ratingValue.SelectedIndex = 2
        End Sub

        Private Sub InitRatingPage()
            progressValue.Value = CInt(CType(progress1.Gauges(0), ILinearGauge).Scales(0).Value)
        End Sub

        Private Sub InitEqualizerPage()
            For Each _scale As IScale In CType(equalizer.Gauges(0), ILinearGauge).Scales
                _scale.Value = 0
            Next
        End Sub

        Private Sub OnLevelIndicatorValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            CType(levelIndicator.Gauges(0), ILinearGauge).Scales(0).Value = equalizerLevel.Value
        End Sub

        Private Sub OnProgressValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            CType(progress1.Gauges(0), ILinearGauge).Scales(0).Value = progressValue.Value
            CType(progress2.Gauges(0), ILinearGauge).Scales(0).Value = progressValue.Value
        End Sub

        Private Sub OnRatingChanged(ByVal sender As Object, ByVal e As EventArgs)
            CType(rating.Gauges(0), ILinearGauge).Scales(0).Value = CInt(ratingValue.EditValue)
        End Sub

        Private Sub OnLoadingTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            CType(rating1.Gauges(0), ILinearGauge).Scales(0).Value = CSng(Threading.Interlocked.Increment(loadingCount) Mod 10) * 10F + CSng(Date.Now.Millisecond) * 0.01F
        End Sub

        Private Sub OnEqualizerTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            Dim freqCount As Integer = CType(equalizer.Gauges(0), ILinearGauge).Scales.Count
            For i As Integer = 0 To freqCount - 1
                Dim timeFactor As Double =(CDbl(Date.Now.Millisecond) + CDbl(i) * 50R) * 0.0002R
                Dim noiseFactor As Single = CSng(random.NextDouble()) * 0.4F
                Dim f As Single = CSng(Math.Sin(Math.PI * timeFactor)) + noiseFactor
                CType(equalizer.Gauges(0), ILinearGauge).Scales(i).Value = 20F + 60F * f
            Next
        End Sub

        Protected Overrides ReadOnly Property UseRoundedPanel As Boolean?
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
