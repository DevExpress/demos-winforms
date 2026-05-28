Imports System

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class DigitalClock
        Inherits TutorialControl

        Private lockTimerCounter As Integer = 0

        Public Sub New()
            InitializeComponent()
            timer.Start()
            OnTimerTick(Nothing, Nothing)
        End Sub

        Private Function GetStringLength(ByVal str As String) As Integer
            Dim counter As Integer = 0
            Dim pos As Integer = 0
            While pos < str.Length
                If str(pos) <> ":"c Then counter += 1
                pos += 1
            End While

            Return counter
        End Function

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If lockTimerCounter = 0 Then
                lockTimerCounter += 1
                UpdateTime()
                lockTimerCounter -= 1
            End If
        End Sub

        Private Sub UpdateTime()
            Dim time As String = Date.Now.ToLongTimeString()
            If GetStringLength(time) > digitalGauge2.DigitCount Then digitalGauge2.DigitCount = GetStringLength(time)
            digitalGauge2.Text = time
        End Sub
    End Class
End Namespace
