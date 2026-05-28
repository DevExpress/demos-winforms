Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraGauges.Demos.net.webservicex.www

Namespace DevExpress.XtraGauges.Demos

    Public Partial Class WeatherStation
        Inherits TutorialControl

        Private data As BindingList(Of DemoWeatherData)

        Public Sub New()
            InitializeComponent()
            UpdateWeather("London(Offline data)")
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            UpdateWeather(comboBoxEdit1.EditValue.ToString())
        End Sub

        Protected Sub UpdateWeather(ByVal place As String)
            Dim wfc As WeatherForecasts = GetWeatherByPlaceNameSafe(place)
            If wfc Is Nothing Then Return
            InitDataSource(wfc)
            InitCharts()
            InitGauge()
        End Sub

        Protected Function GetWeatherByPlaceNameSafe(ByVal place As String) As WeatherForecasts
            Cursor = Cursors.WaitCursor
            Dim wfc As WeatherForecasts = Nothing
            Try
                Using dlg As WaitDialogForm = New WaitDialogForm("Loading weather at " & place)
                    If place.Contains("Offline") Then
                        Dim stream = ResourceImageHelperCore.FindStream("DevExpress.XtraGauges.Demos.Data.weather.xml", GetType(WeatherStation).Assembly)
                        wfc = SafeXml.Deserialize(Of WeatherForecasts)(stream)
                    Else
#If Not NET
                        Dim service As WeatherForecast = New WeatherForecast()
                        wfc = service.GetWeatherByPlaceName(place)
#End If
                    End If
                End Using
            Catch
                XtraEditors.XtraMessageBox.Show("could not retrieve weather data for " & place)
                Cursor = Cursors.Arrow
                Return Nothing
            End Try

            If wfc.Details Is Nothing Then
                XtraEditors.XtraMessageBox.Show("could not retrieve weather data for " & place)
                Cursor = Cursors.Arrow
                Return Nothing
            End If

            Cursor = Cursors.Arrow
            Return wfc
        End Function

        Protected Sub InitDataSource(ByVal wfc As WeatherForecasts)
            Try
                Try
                    If data Is Nothing Then
                        data = New BindingList(Of DemoWeatherData)()
                    Else
                        data.Clear()
                    End If
                Catch
                End Try

                Dim counter As Integer = 0
                Dim isCelsius As Boolean = comboBoxEdit2.Text.StartsWith("C")
                For Each wd As WeatherData In wfc.Details
                    Dim minF, maxF, minC, maxC, f, c As Integer
                    Integer.TryParse(wd.MinTemperatureF, minF)
                    Integer.TryParse(wd.MaxTemperatureF, maxF)
                    Integer.TryParse(wd.MinTemperatureC, minC)
                    Integer.TryParse(wd.MaxTemperatureC, maxC)
                    f =(minF + maxF) \ 2
                    c =(minC + maxC) \ 2
                    Dim minT As Integer = If(isCelsius, minC, minF)
                    Dim maxT As Integer = If(isCelsius, maxC, maxF)
                    Dim item As DemoWeatherData = New DemoWeatherData(minT, maxT, c, f, counter)
                    counter += 1
                    data.Add(item)
                Next
            Catch
            End Try
        End Sub

        Protected Sub InitGauge()
            Dim isCelsius As Boolean = comboBoxEdit2.Text.StartsWith("C")
            If currentTempScale.DataBindings.Count = 0 Then
                currentTempScale.DataBindings.Add("Value", data, "CurrentTemperature" & If(isCelsius, "C", "F"))
            End If
        End Sub

        Protected Sub InitCharts()
            If chartControl1.DataSource IsNot data Then
                chartControl1.DataSource = data
                chartControl1.Series(0).ArgumentDataMember = "Day"
                chartControl1.Series(0).ValueDataMembers(0) = "MinTemperature"
                chartControl1.Series(1).ArgumentDataMember = "Day"
                chartControl1.Series(1).ValueDataMembers(0) = "MaxTemperature"
            Else
                chartControl1.Invalidate()
            End If
        End Sub
    End Class

    Public Class DemoWeatherData

        Private minTemperatureCore As Integer

        Private maxTemperatureCore As Integer

        Private dayCore As Integer

        Private currentTemperatureCCore As Integer

        Private currentTemperatureFCore As Integer

        Public Property MinTemperature As Integer
            Get
                Return minTemperatureCore
            End Get

            Set(ByVal value As Integer)
                minTemperatureCore = value
            End Set
        End Property

        Public Property MaxTemperature As Integer
            Get
                Return maxTemperatureCore
            End Get

            Set(ByVal value As Integer)
                maxTemperatureCore = value
            End Set
        End Property

        Public Property Day As Integer
            Get
                Return dayCore
            End Get

            Set(ByVal value As Integer)
                dayCore = value
            End Set
        End Property

        Public Property CurrentTemperatureF As Integer
            Get
                Return currentTemperatureCCore
            End Get

            Set(ByVal value As Integer)
                currentTemperatureCCore = value
            End Set
        End Property

        Public Property CurrentTemperatureC As Integer
            Get
                Return currentTemperatureFCore
            End Get

            Set(ByVal value As Integer)
                currentTemperatureFCore = value
            End Set
        End Property

        Public Sub New(ByVal minT As Integer, ByVal maxT As Integer, ByVal currentTemperatureC As Integer, ByVal currentTemperatureF As Integer, ByVal day As Integer)
            Me.Day = day
            MinTemperature = minT
            MaxTemperature = maxT
            Me.CurrentTemperatureC = currentTemperatureC
            Me.CurrentTemperatureF = currentTemperatureF
        End Sub
    End Class
End Namespace
