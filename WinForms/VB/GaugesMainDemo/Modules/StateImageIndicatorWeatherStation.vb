Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraGauges.Core.Drawing
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Win.Base
Imports DevExpress.XtraGauges.Win.Gauges.Circular

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class StateImageIndicatorWeatherStation
        Inherits TutorialControl

        Private [date] As Date = New DateTime(1900, 1, 1)

        Private seasons As String() = New String() {"Winter", "Spring", "Summer", "Autumn"}

        Private updateTimer As Timer = New Timer()

        Public Sub New()
            InitializeComponent()
            scHumidityLA.EnableAnimation = True
            scHumidityLA.EasingMode = EasingMode.EaseInOut
            scHumidityLA.EasingFunction = New CubicEase()
            scTempLA.EnableAnimation = True
            scTempLA.EasingMode = EasingMode.EaseInOut
            scTempLA.EasingFunction = New CubicEase()
            scHumidityLn.EnableAnimation = True
            scHumidityLn.EasingMode = EasingMode.EaseInOut
            scHumidityLn.EasingFunction = New CubicEase()
            scTempLn.EnableAnimation = True
            scTempLn.EasingMode = EasingMode.EaseInOut
            scTempLn.EasingFunction = New CubicEase()
            scHumidityMs.EnableAnimation = True
            scHumidityMs.EasingMode = EasingMode.EaseInOut
            scHumidityMs.EasingFunction = New CubicEase()
            scTempMs.EnableAnimation = True
            scTempMs.EasingMode = EasingMode.EaseInOut
            scTempMs.EasingFunction = New CubicEase()
            AddHandler LookAndFeel.StyleChanged, AddressOf OnStyleChanged
            updateTimer.Interval = 2000
            AddHandler updateTimer.Tick, AddressOf OnTimerTick
            UpdateColor()
            UpdateWeatherLA()
            UpdateWeatherLN()
            UpdateWeatherMS()
            updateTimer.Start()
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            updateTimer.Stop()
            MyBase.Dispose(disposing)
        End Sub

#Region "StateImageIndicator"
        Private ReadOnly Shared r As Data.Utils.NonCryptographicRandom = Data.Utils.NonCryptographicRandom.Default

        Public ReadOnly Property HotColor As Color
            Get
                Return GetColor(LookAndFeel, "Critical")
            End Get
        End Property

        Public ReadOnly Property ColdColor As Color
            Get
                Return GetColor(LookAndFeel, "Question")
            End Get
        End Property

        Public ReadOnly Property RangeColor As Color
            Get
                Return GetColor(LookAndFeel, "DisabledText")
            End Get
        End Property

        Public ReadOnly Property TextColor As Color
            Get
                Return GetColor(LookAndFeel, "DisabledText")
            End Get
        End Property

        Private Overloads Sub OnStyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            updateTimer.Stop()
            UpdateColor()
            UpdateWeatherLA()
            UpdateWeatherLN()
            UpdateWeatherMS()
            updateTimer.Start()
        End Sub

        Private Sub UpdateColor()
            rbLnHumidity.AppearanceRangeBar.ContentBrush = New SolidBrushObject(RangeColor)
            rbLAHumidity.AppearanceRangeBar.ContentBrush = New SolidBrushObject(RangeColor)
            rbMsHumidity.AppearanceRangeBar.ContentBrush = New SolidBrushObject(RangeColor)
            gaugeControl4.ColorScheme.Color = HotColor
            gaugeControl3.ColorScheme.Color = HotColor
            gaugeControl5.ColorScheme.Color = HotColor
            scTempLA.AppearanceTickmarkText.TextBrush = New SolidBrushObject(TextColor)
            scTempLn.AppearanceTickmarkText.TextBrush = New SolidBrushObject(TextColor)
            scTempMs.AppearanceTickmarkText.TextBrush = New SolidBrushObject(TextColor)
        End Sub

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If [date].Year > 2050 Then [date] = New DateTime(1900, 1, 1)
            [date] = [date].AddDays(r.Next(0, 30))
            UpdateDate()
            UpdateWeatherLA()
            UpdateWeatherLN()
            UpdateWeatherMS()
        End Sub

        Private Sub UpdateDate()
            Dim s As String() = [date].ToString("dd MMMM").Split(" "c)
            lcDay.Text = s(0)
            lcMonth.Text = s(1).ToUpper()
            If [date].Month = 12 OrElse [date].Month >= 1 AndAlso [date].Month <= 2 Then
                lcSeason.Text = seasons(0).ToUpper()
            End If

            If [date].Month >= 3 AndAlso [date].Month <= 5 Then
                lcSeason.Text = seasons(1).ToUpper()
            End If

            If [date].Month >= 6 AndAlso [date].Month <= 8 Then
                lcSeason.Text = seasons(2).ToUpper()
            End If

            If [date].Month >= 9 AndAlso [date].Month <= 11 Then
                lcSeason.Text = seasons(3).ToUpper()
            End If
        End Sub

        Private Sub UpdateWeatherLN()
            Dim temp As Double = 10 * Math.Sin([date].DayOfYear * Math.PI / 90 / 2 - 91 * Math.PI / 180) + r.Next(-5, 2) + 13
            Dim humidity As Integer = r.Next(65, 100)
            UpdateCityWeather(scTempLn, scHumidityLn, siiLn, lcLn, rbLnTemp, temp, humidity)
        End Sub

        Private Sub UpdateWeatherLA()
            Dim temp As Double = 7.5 * Math.Sin([date].DayOfYear * Math.PI / 90 / 2 - 91 * Math.PI / 180) + r.Next(-2, 2) + 20.5
            Dim humidity As Integer = r.Next(40, 92)
            UpdateCityWeather(scTempLA, scHumidityLA, siiLA, lcLA, rbLATemp, temp, humidity)
        End Sub

        Private Sub UpdateWeatherMS()
            Dim temp As Double = 28 * Math.Sin([date].DayOfYear * Math.PI / 90 / 2 - 91 * Math.PI / 180) + r.Next(0, 2)
            Dim humidity As Integer = r.Next(60, 100)
            UpdateCityWeather(scTempMs, scHumidityMs, siiMs, lcMs, rbMsTemp, temp, humidity)
        End Sub

        Private Sub UpdateCityWeather(ByVal tempScale As ArcScaleComponent, ByVal humidityScale As ArcScaleComponent, ByVal imageIndicator As StateImageIndicatorComponent, ByVal label As LabelComponent, ByVal rangeBar As ArcScaleRangeBar, ByVal temp As Double, ByVal humidity As Integer, ByVal Optional weather As String = "")
            If tempScale Is Nothing OrElse humidityScale Is Nothing OrElse imageIndicator Is Nothing OrElse label Is Nothing OrElse rangeBar Is Nothing Then Return
            tempScale.Value = CSng(temp)
            If temp < 0 Then
                rangeBar.Appearance.ContentBrush = New SolidBrushObject(ColdColor)
                imageIndicator.Color = ColdColor
            Else
                rangeBar.Appearance.ContentBrush = New SolidBrushObject(HotColor)
                imageIndicator.Color = HotColor
            End If

            humidityScale.Value = humidity
            Dim color As String = String.Format("{0},{1},{2}", RangeColor.R, RangeColor.G, RangeColor.B)
            Dim color2 As String = If(temp < 0, String.Format("{0},{1},{2}", ColdColor.R, ColdColor.G, ColdColor.B), String.Format("{0},{1},{2}", HotColor.R, HotColor.G, HotColor.B))
            Dim temperature As String = If(temp <= 0, (CInt(temp)).ToString(), "+" & (CInt(temp)).ToString())
            label.Text = String.Format("<color={0}>t: {1}C    <br><color={2}>h: {3}%   ", color2, temperature, color, humidity)
            If String.IsNullOrEmpty(weather) Then
                If humidity > 85 Then
                    If temp >= 0 Then
                        imageIndicator.StateIndex = 2
                    Else
                        imageIndicator.StateIndex = 3
                    End If
                ElseIf humidity > 70 Then
                    imageIndicator.StateIndex = 1
                Else
                    imageIndicator.StateIndex = 0
                End If
            Else
                Select Case weather
                    Case "Rain"
                        imageIndicator.StateIndex = 2
                    Case "Clear"
                        imageIndicator.StateIndex = 0
                    Case "Snow"
                        imageIndicator.StateIndex = 3
                    Case Else
                        imageIndicator.StateIndex = 1
                End Select
            End If
        End Sub
#End Region
    End Class

    Friend Module SkinColorHelper

        Public Function GetColor(ByVal provider As ISkinProvider, ByVal name As String) As Color
            Return CommonSkins.GetSkin(provider).Colors.GetColor(name)
        End Function
    End Module
End Namespace
