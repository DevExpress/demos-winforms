Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports DevExpress.Data.Utils
Imports DevExpress.XtraMap.Demos

Namespace DevExpress.Demos.FlagsGameCore

    Public Enum GameLevel
        Easy = 0
        Middle = 1
        High = 2
        VeryHigh = 3
    End Enum

    Public Enum AnswerStatus
        Win
        Lose
        WrongTry
        ShowCountry
    End Enum

    Public Class CountryDataEventArgs
        Inherits System.EventArgs

        Public Property Flag As Image

        Public Property Name As String
    End Class

    Public Class ChoiceAnswerEventArgs
        Inherits System.EventArgs

        Public Property Status As AnswerStatus

        Public Property ScoreDelta As Double

        Public Property CountryName As String
    End Class

    Public Class ScoreChangedAnswerEventArgs
        Inherits System.EventArgs

        Public Property Score As Double

        Public Property Wins As Integer

        Public Property Losses As Integer
    End Class

    Public Class GameOverEventArgs
        Inherits System.EventArgs

        Public Property Time As String
    End Class

    Public Class FlagsGameCore
        Implements System.IDisposable

        Private Shared ReadOnly rand As DevExpress.Data.Utils.NonCryptographicRandom = New DevExpress.Data.Utils.NonCryptographicRandom(System.DateTime.Now.Millisecond)

        Private ReadOnly actualCountries As System.Collections.Generic.List(Of String)

        Private unusedCountries As System.Collections.Generic.List(Of String)

        Private ReadOnly countriesFlags As System.Collections.Generic.Dictionary(Of String, System.Drawing.Image)

        Private gameLevel As DevExpress.Demos.FlagsGameCore.GameLevel = DevExpress.Demos.FlagsGameCore.GameLevel.Easy

        Private startGameTime As System.DateTime

        Private finishGameTime As System.DateTime

        Private currentCountry As String

        Private isGameActiveField As Boolean

        Private wins As Integer

        Private losses As Integer

        Private score As Double

        Private ReadOnly Property GamingTicks As Long
            Get
                Return If(Me.isGameActiveField, (System.DateTime.Now - Me.startGameTime).Ticks, (Me.finishGameTime - Me.startGameTime).Ticks)
            End Get
        End Property

        Public ReadOnly Property IsGameActive As Boolean
            Get
                Return Me.isGameActiveField
            End Get
        End Property

        Public ReadOnly Property CurrentCountryName As String
            Get
                Return Me.currentCountry
            End Get
        End Property

        Public Event GameOver As System.EventHandler(Of DevExpress.Demos.FlagsGameCore.GameOverEventArgs)

        Public Event ScoreChanged As System.EventHandler(Of DevExpress.Demos.FlagsGameCore.ScoreChangedAnswerEventArgs)

        Public Event CountryChanged As System.EventHandler(Of DevExpress.Demos.FlagsGameCore.CountryDataEventArgs)

        Public Event ChoiceAnswer As System.EventHandler(Of DevExpress.Demos.FlagsGameCore.ChoiceAnswerEventArgs)

        Public Sub New(ByVal countriesList As System.Collections.Generic.List(Of String))
            Me.actualCountries = countriesList
            Me.countriesFlags = New System.Collections.Generic.Dictionary(Of String, System.Drawing.Image)()
        End Sub

        Private Sub RaiseEventGameOver()
            If GameOverEvent IsNot Nothing Then
                Dim gameOverData As DevExpress.Demos.FlagsGameCore.GameOverEventArgs = New DevExpress.Demos.FlagsGameCore.GameOverEventArgs() With {.Time = Me.GetGameTime()}
                RaiseEvent GameOver(Me, gameOverData)
            End If
        End Sub

        Private Sub RaiseEventScoreChanged()
            If ScoreChangedEvent IsNot Nothing Then
                Dim scoreData As DevExpress.Demos.FlagsGameCore.ScoreChangedAnswerEventArgs = New DevExpress.Demos.FlagsGameCore.ScoreChangedAnswerEventArgs() With {.Score = Me.score, .Wins = Me.wins, .Losses = Me.losses}
                RaiseEvent ScoreChanged(Me, scoreData)
            End If
        End Sub

        Private Sub RaiseEventCountryChanged(ByVal flag As System.Drawing.Image, ByVal countryName As String)
            If CountryChangedEvent IsNot Nothing Then
                Dim countryData As DevExpress.Demos.FlagsGameCore.CountryDataEventArgs = New DevExpress.Demos.FlagsGameCore.CountryDataEventArgs() With {.Flag = flag, .Name = countryName}
                RaiseEvent CountryChanged(Me, countryData)
            End If
        End Sub

        Private Sub RaiseEventChoiceAnswer(ByVal status As DevExpress.Demos.FlagsGameCore.AnswerStatus, ByVal countryName As String, ByVal scoreDelta As Double)
            If ChoiceAnswerEvent IsNot Nothing Then
                Dim answerData As DevExpress.Demos.FlagsGameCore.ChoiceAnswerEventArgs = New DevExpress.Demos.FlagsGameCore.ChoiceAnswerEventArgs() With {.Status = status, .CountryName = countryName, .ScoreDelta = scoreDelta}
                RaiseEvent ChoiceAnswer(Me, answerData)
            End If
        End Sub

        Private Sub NextCountry()
            If Me.unusedCountries.Count > 0 Then
                Dim index As Integer = DevExpress.Demos.FlagsGameCore.FlagsGameCore.rand.[Next](Me.unusedCountries.Count)
                Dim countryName As String = Me.unusedCountries(index)
                Me.unusedCountries.Remove(countryName)
                Me.currentCountry = countryName
                Me.RaiseEventCountryChanged(DevExpress.XtraMap.Demos.DemoUtils.GetCountryFlag(Me.countriesFlags, countryName), countryName)
            Else
                Me.FinishGame()
            End If
        End Sub

        Private Sub RightChoice(ByVal countryName As String)
            Dim stepScore As Integer = Me.GetScoreStep()
            Me.wins += 1
            Me.score += stepScore
            Me.RaiseEventChoiceAnswer(DevExpress.Demos.FlagsGameCore.AnswerStatus.Win, countryName, stepScore)
        End Sub

        Private Sub WrongChoice(ByVal countryName As String)
            Dim stepScore As Integer = Me.GetScoreStep()
            Me.losses += 1
            Me.score -= stepScore
            Me.RaiseEventChoiceAnswer(DevExpress.Demos.FlagsGameCore.AnswerStatus.Lose, countryName, -stepScore)
        End Sub

        Private Sub WrongTry(ByVal countryName As String)
            Dim stepScore As Integer = 1
            Me.score -= stepScore
            Me.RaiseEventChoiceAnswer(DevExpress.Demos.FlagsGameCore.AnswerStatus.WrongTry, countryName, -stepScore)
        End Sub

        Private Function GetScoreStep() As Integer
            Return 10 + 5 * CInt(Me.gameLevel)
        End Function

        Private Function GetGameTime() As String
            Dim time As System.DateTime = New System.DateTime(Me.GamingTicks)
            Dim isPrinting As Boolean = False
            Dim timeString As String = ""
            If isPrinting OrElse time.Hour > 0 Then
                timeString += time.ToString("HH", System.Globalization.CultureInfo.InvariantCulture) & "H "
                isPrinting = True
            End If

            If isPrinting OrElse time.Minute > 0 Then
                timeString += time.ToString("mm", System.Globalization.CultureInfo.InvariantCulture) & "m "
                isPrinting = True
            End If

            If isPrinting OrElse time.Second > 0 Then
                timeString += time.ToString("ss", System.Globalization.CultureInfo.InvariantCulture) & "s "
                isPrinting = True
            End If

            timeString += time.ToString("ff", System.Globalization.CultureInfo.InvariantCulture) & "ms "
            Return timeString
        End Function

        Public Sub StartGame(ByVal level As DevExpress.Demos.FlagsGameCore.GameLevel)
            Me.gameLevel = level
            Me.unusedCountries = New System.Collections.Generic.List(Of String)(Me.actualCountries)
            Me.currentCountry = ""
            Me.wins = 0
            Me.losses = 0
            Me.score = 0
            Me.isGameActiveField = True
            Me.startGameTime = System.DateTime.Now
            Me.RaiseEventScoreChanged()
            Me.NextCountry()
        End Sub

        Public Sub StartGame()
            Me.StartGame(DevExpress.Demos.FlagsGameCore.GameLevel.Easy)
        End Sub

        Public Sub FinishGame()
            Me.finishGameTime = System.DateTime.Now
            Me.isGameActiveField = False
            Me.RaiseEventGameOver()
        End Sub

        Public Function TrySelectionCountry(ByVal countryName As String) As Boolean
            If Not Me.isGameActiveField Then Return False
            Dim isCorrectSelection As Boolean = Equals(countryName, Me.currentCountry)
            If isCorrectSelection Then
                Me.RightChoice(Me.currentCountry)
                Me.NextCountry()
            ElseIf Me.gameLevel <> DevExpress.Demos.FlagsGameCore.GameLevel.Easy Then
                Me.WrongChoice(Me.currentCountry)
                Me.NextCountry()
            Else
                Me.WrongTry(countryName)
            End If

            Me.RaiseEventScoreChanged()
            Return isCorrectSelection
        End Function

        Public Sub SkipCountry()
            If Not Me.isGameActiveField Then Return
            Me.WrongChoice(Me.currentCountry)
            Me.RaiseEventScoreChanged()
            Me.NextCountry()
        End Sub

        Public Sub ShowCountry()
            If Not Me.isGameActiveField Then Return
            Dim stepScore As Double = 0.5
            Me.score -= stepScore
            Me.RaiseEventChoiceAnswer(DevExpress.Demos.FlagsGameCore.AnswerStatus.ShowCountry, Me.currentCountry, -stepScore)
            Me.RaiseEventScoreChanged()
        End Sub

#Region "IDisposable implementation"
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                Dim keysCollection As System.Collections.Generic.IEnumerable(Of String) = New System.Collections.Generic.List(Of String)(Me.countriesFlags.Keys)
                For Each key As String In keysCollection
                    If Me.countriesFlags(key) IsNot Nothing Then
                        Me.countriesFlags(CStr((key))).Dispose()
                        Me.countriesFlags(key) = Nothing
                    End If
                Next
            End If
        End Sub

        Public Sub Dispose() Implements Global.System.IDisposable.Dispose
            Me.Dispose(True)
            System.GC.SuppressFinalize(Me)
        End Sub

        Protected Overrides Sub Finalize()
            Me.Dispose(False)
        End Sub
#End Region
    End Class
End Namespace
