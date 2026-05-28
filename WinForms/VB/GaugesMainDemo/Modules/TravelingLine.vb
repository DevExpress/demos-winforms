Imports System

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class TravelingLine
        Inherits TutorialControl

        Private Shared specChars As Char() = New Char() {"."c, "'"c, ","c}

        Private visibleSymbolsCount As Integer = 0

        Private substringStartIndex As Integer = 0

        Private fullTextToShow As String = String.Empty

        Public Sub New()
            InitializeComponent()
            Init()
        End Sub

        Private lockTimerCounter As Integer

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If lockTimerCounter <> 0 Then Return
            lockTimerCounter += 1
            UpdateText()
            lockTimerCounter -= 1
        End Sub

        Private Sub OnDirectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            Init()
        End Sub

        Private Sub OnTravelingTextChanged(ByVal sender As Object, ByVal e As EventArgs)
            Init()
        End Sub

        Private Sub OnTravelingSpeedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Init()
        End Sub

        Private Function IsSpecialCharacter(ByVal character As Char) As Boolean
            Return Array.IndexOf(specChars, character) <> -1
        End Function

        Private Sub Init()
            If digitalGauge1.DigitCount < 0 Then Return
            timer.Stop()
            timer.Interval = 500 \ (travelingSpeed.Value + 1)
            timer.Start()
            fullTextToShow = New String(" "c, digitalGauge1.DigitCount) & travelingText.Text & New String(" "c, digitalGauge1.DigitCount)
            visibleSymbolsCount = digitalGauge1.DigitCount
            substringStartIndex = If(cbDirection.SelectedIndex = 0, 0, fullTextToShow.Length - visibleSymbolsCount)
        End Sub

        Private Sub UpdateText()
            Dim additionalSymbolsCount As Integer = Array.FindAll(fullTextToShow.Substring(substringStartIndex, visibleSymbolsCount).ToCharArray(), AddressOf IsSpecialCharacter).Length
            digitalGauge1.Text = fullTextToShow.Substring(substringStartIndex, visibleSymbolsCount + additionalSymbolsCount)
            substringStartIndex += If(cbDirection.SelectedIndex = 0, 1, -1)
            If substringStartIndex < 0 Then
                substringStartIndex = fullTextToShow.Length - visibleSymbolsCount
            ElseIf substringStartIndex > fullTextToShow.Length - visibleSymbolsCount Then
                substringStartIndex = 0
            End If

            If IsSpecialCharacter(fullTextToShow(substringStartIndex)) Then substringStartIndex += If(cbDirection.SelectedIndex = 0, 1, -1)
        End Sub

        Protected Overrides ReadOnly Property AllowBorderRounding As Boolean?
            Get
                Return False
            End Get
        End Property
    End Class
End Namespace
