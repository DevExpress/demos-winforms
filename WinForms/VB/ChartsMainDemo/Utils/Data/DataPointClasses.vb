Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Xml.Serialization
Imports DevExpress.Utils.Filtering

Namespace DevExpress.XtraCharts.Demos

    Public Class DataPoint

        Public Property Series As String

        Public Property Argument As Double

        Public Property Value As Double

        Public Property Value2 As Double

        Public Property Weight As Double

        Public Property Low As Double

        Public Property High As Double

        Public Property Open As Double

        Public Property Close As Double

        Public Property Min As Double

        Public Property Quartile1 As Double

        Public Property Median As Double

        Public Property Quartile3 As Double

        Public Property Max As Double

        Public Property Mean As Double

        Public Property Outliers As Double()
    End Class

    Public Class FinancialDataPoint

        Public Property DateTimeStamp As DateTime

        Public Property Low As Double

        Public Property High As Double

        Public Property Open As Double

        Public Property Close As Double

        Public Property Volume As Double

        Public ReadOnly Property IsEmpty As Boolean
            Get
                Return Me.DateTimeStamp.Equals(New System.DateTime())
            End Get
        End Property

        Public Sub New()
        End Sub

        Public Sub New(ByVal [date] As System.DateTime, ByVal open As Double, ByVal high As Double, ByVal low As Double, ByVal close As Double, ByVal volume As Double)
            Me.DateTimeStamp = [date]
            Me.Low = low
            Me.High = high
            Me.Open = open
            Me.Close = close
            Me.Volume = volume
        End Sub
    End Class

    Public Class CarbonContributionDataPoint

        Public Property Year As String

        Public Property Contribution As Double

        Public Property Factor As String

        Public Sub New()
        End Sub

        Public Sub New(ByVal year As String, ByVal contribution As Double, ByVal factor As String)
            Me.Year = year
            Me.Contribution = contribution
            Me.Factor = factor
        End Sub
    End Class

    Public Class SimpleDataPoint

        Private _Argument As Double, _Value As Double

        Public Property Argument As Double
            Get
                Return _Argument
            End Get

            Private Set(ByVal value As Double)
                _Argument = value
            End Set
        End Property

        Public Property Value As Double
            Get
                Return _Value
            End Get

            Private Set(ByVal value As Double)
                _Value = value
            End Set
        End Property

        Public Sub New(ByVal arg As Double, ByVal val As Double)
            Me.Argument = arg
            Me.Value = val
        End Sub
    End Class

    Public Class HeadphoneComparisonPoint

        Private _HeadphonesName As String, _Frequency As Double, _Spl90Db As Double, _Spl100Db As Double

        Public Property HeadphonesName As String
            Get
                Return _HeadphonesName
            End Get

            Private Set(ByVal value As String)
                _HeadphonesName = value
            End Set
        End Property

        Public Property Frequency As Double
            Get
                Return _Frequency
            End Get

            Private Set(ByVal value As Double)
                _Frequency = value
            End Set
        End Property

        Public Property Spl90Db As Double
            Get
                Return _Spl90Db
            End Get

            Private Set(ByVal value As Double)
                _Spl90Db = value
            End Set
        End Property

        Public Property Spl100Db As Double
            Get
                Return _Spl100Db
            End Get

            Private Set(ByVal value As Double)
                _Spl100Db = value
            End Set
        End Property

        Public Sub New(ByVal headphoneName As String, ByVal frequency As Double, ByVal spl90Db As Double, ByVal spl100Db As Double)
            Me.HeadphonesName = headphoneName
            Me.Frequency = frequency
            Me.Spl90Db = spl90Db
            Me.Spl100Db = spl100Db
        End Sub
    End Class

    Public Class SensorIndicationItem

        Private _TimeStamp As DateTime, _SensorIndication1 As Double, _SensorIndication2 As Double, _SensorIndication3 As Double, _SensorIndication4 As Double, _SensorIndication5 As Double, _SensorIndication6 As Double, _SensorIndication7 As Double, _SensorIndication8 As Double

        Public Property TimeStamp As DateTime
            Get
                Return _TimeStamp
            End Get

            Private Set(ByVal value As DateTime)
                _TimeStamp = value
            End Set
        End Property

        Public Property SensorIndication1 As Double
            Get
                Return _SensorIndication1
            End Get

            Private Set(ByVal value As Double)
                _SensorIndication1 = value
            End Set
        End Property

        Public Property SensorIndication2 As Double
            Get
                Return _SensorIndication2
            End Get

            Private Set(ByVal value As Double)
                _SensorIndication2 = value
            End Set
        End Property

        Public Property SensorIndication3 As Double
            Get
                Return _SensorIndication3
            End Get

            Private Set(ByVal value As Double)
                _SensorIndication3 = value
            End Set
        End Property

        Public Property SensorIndication4 As Double
            Get
                Return _SensorIndication4
            End Get

            Private Set(ByVal value As Double)
                _SensorIndication4 = value
            End Set
        End Property

        Public Property SensorIndication5 As Double
            Get
                Return _SensorIndication5
            End Get

            Private Set(ByVal value As Double)
                _SensorIndication5 = value
            End Set
        End Property

        Public Property SensorIndication6 As Double
            Get
                Return _SensorIndication6
            End Get

            Private Set(ByVal value As Double)
                _SensorIndication6 = value
            End Set
        End Property

        Public Property SensorIndication7 As Double
            Get
                Return _SensorIndication7
            End Get

            Private Set(ByVal value As Double)
                _SensorIndication7 = value
            End Set
        End Property

        Public Property SensorIndication8 As Double
            Get
                Return _SensorIndication8
            End Get

            Private Set(ByVal value As Double)
                _SensorIndication8 = value
            End Set
        End Property

        Friend Sub New(ByVal timeStamp As System.DateTime, ByVal sensorIndication1 As Double, ByVal sensorIndication2 As Double, ByVal sensorIndication3 As Double, ByVal sensorIndication4 As Double, ByVal sensorIndication5 As Double, ByVal sensorIndication6 As Double, ByVal sensorIndication7 As Double, ByVal sensorIndication8 As Double)
            Me.TimeStamp = timeStamp
            Me.SensorIndication1 = sensorIndication1
            Me.SensorIndication2 = sensorIndication2
            Me.SensorIndication3 = sensorIndication3
            Me.SensorIndication4 = sensorIndication4
            Me.SensorIndication5 = sensorIndication5
            Me.SensorIndication6 = sensorIndication6
            Me.SensorIndication7 = sensorIndication7
            Me.SensorIndication8 = sensorIndication8
        End Sub
    End Class

    Public Class SeaIceAreaDataPoint

        Private _FullDate As DateTime, _Year As String, _DayOfYear As Double, _IceArea As Double

        Public Property FullDate As DateTime
            Get
                Return _FullDate
            End Get

            Private Set(ByVal value As DateTime)
                _FullDate = value
            End Set
        End Property

        Public Property Year As String
            Get
                Return _Year
            End Get

            Private Set(ByVal value As String)
                _Year = value
            End Set
        End Property

        Public Property DayOfYear As Double
            Get
                Return _DayOfYear
            End Get

            Private Set(ByVal value As Double)
                _DayOfYear = value
            End Set
        End Property

        Public Property IceArea As Double
            Get
                Return _IceArea
            End Get

            Private Set(ByVal value As Double)
                _IceArea = value
            End Set
        End Property

        Friend Sub New(ByVal fullDateP As System.DateTime, ByVal yearP As String, ByVal dayOfYearP As Double, ByVal iceAreaP As Double) 'P - parameter (for correct VB conversion)
            Me.FullDate = fullDateP
            Me.Year = yearP
            Me.DayOfYear = dayOfYearP
            Me.IceArea = iceAreaP
        End Sub
    End Class

    Public Class TemperaturePoint

        Private _TimeStamp As TimeSpan, _Temperature As Double

        Public Property TimeStamp As TimeSpan
            Get
                Return _TimeStamp
            End Get

            Private Set(ByVal value As TimeSpan)
                _TimeStamp = value
            End Set
        End Property

        Public Property Temperature As Double
            Get
                Return _Temperature
            End Get

            Private Set(ByVal value As Double)
                _Temperature = value
            End Set
        End Property

        Friend Sub New(ByVal time As System.TimeSpan, ByVal temperature As Double)
            Me.TimeStamp = time
            Me.Temperature = temperature
        End Sub
    End Class

    Public Class BubbleDataItem

        Private _Year As DateTime, _Budget As Double, _Grosses As Double, _Title As String

        Public Property Year As DateTime
            Get
                Return _Year
            End Get

            Private Set(ByVal value As DateTime)
                _Year = value
            End Set
        End Property

        Public Property Budget As Double
            Get
                Return _Budget
            End Get

            Private Set(ByVal value As Double)
                _Budget = value
            End Set
        End Property

        Public Property Grosses As Double
            Get
                Return _Grosses
            End Get

            Private Set(ByVal value As Double)
                _Grosses = value
            End Set
        End Property

        Public Property Title As String
            Get
                Return _Title
            End Get

            Private Set(ByVal value As String)
                _Title = value
            End Set
        End Property

        Public Sub New(ByVal year As System.DateTime, ByVal budget As Double, ByVal grosses As Double, ByVal title As String)
            Me.Year = year
            Me.Budget = budget
            Me.Grosses = grosses
            Me.Title = title
        End Sub
    End Class

    Public Class GDP

        Private _Year As Integer, _Product As Decimal

        Public Property Year As Integer
            Get
                Return _Year
            End Get

            Private Set(ByVal value As Integer)
                _Year = value
            End Set
        End Property

        Public Property Product As Decimal
            Get
                Return _Product
            End Get

            Private Set(ByVal value As Decimal)
                _Product = value
            End Set
        End Property

        Public Sub New(ByVal year As Integer, ByVal product As Decimal)
            Me.Year = year
            Me.Product = product
        End Sub
    End Class

    Public Class G7Member

        Private _CountryName As String, _GDPs As List(Of DevExpress.XtraCharts.Demos.GDP), _ColorNumberInPalette As Integer

        Public ReadOnly Property GDPin2015 As Decimal
            Get
                Return System.Linq.Enumerable.First(Of DevExpress.XtraCharts.Demos.GDP)(Me.GDPs, CType((Function(gdp) CBool((gdp.Year = 2015))), System.Func(Of DevExpress.XtraCharts.Demos.GDP, System.[Boolean]))).Product
            End Get
        End Property

        Public Property CountryName As String
            Get
                Return _CountryName
            End Get

            Private Set(ByVal value As String)
                _CountryName = value
            End Set
        End Property

        Public Property GDPs As List(Of DevExpress.XtraCharts.Demos.GDP)
            Get
                Return _GDPs
            End Get

            Private Set(ByVal value As List(Of DevExpress.XtraCharts.Demos.GDP))
                _GDPs = value
            End Set
        End Property

        Public Property ColorNumberInPalette As Integer
            Get
                Return _ColorNumberInPalette
            End Get

            Private Set(ByVal value As Integer)
                _ColorNumberInPalette = value
            End Set
        End Property

        Public Sub New(ByVal country As String, ByVal colorNumberInPalette As Integer)
            Me.CountryName = country
            Me.GDPs = New System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.GDP)()
            Me.ColorNumberInPalette = colorNumberInPalette
        End Sub
    End Class

    Public Class AgePopulation

        Private _Name As String, _Age As String, _Gender As String, _Population As Double

        Public Property Name As String
            Get
                Return _Name
            End Get

            Private Set(ByVal value As String)
                _Name = value
            End Set
        End Property

        Public Property Age As String
            Get
                Return _Age
            End Get

            Private Set(ByVal value As String)
                _Age = value
            End Set
        End Property

        Public Property Gender As String
            Get
                Return _Gender
            End Get

            Private Set(ByVal value As String)
                _Gender = value
            End Set
        End Property

        Public ReadOnly Property GenderAgeKey As String
            Get
                Return Me.Gender.ToString() & ": " & Me.Age
            End Get
        End Property

        Public ReadOnly Property CountryAgeKey As String
            Get
                Return Me.Name & ": " & Me.Age
            End Get
        End Property

        Public ReadOnly Property CountryGenderKey As String
            Get
                Return Me.Name & ": " & Me.Gender.ToString()
            End Get
        End Property

        Public Property Population As Double
            Get
                Return _Population
            End Get

            Private Set(ByVal value As Double)
                _Population = value
            End Set
        End Property

        Public Sub New(ByVal name As String, ByVal age As String, ByVal gender As String, ByVal population As Double)
            Me.Name = name
            Me.Age = age
            Me.Gender = gender
            Me.Population = population
        End Sub
    End Class

    Public Structure GenderAgeInfo

        Private ReadOnly genderField As String

        Private ReadOnly ageField As String

        Public ReadOnly Property Gender As String
            Get
                Return Me.genderField
            End Get
        End Property

        Public ReadOnly Property Age As String
            Get
                Return Me.ageField
            End Get
        End Property

        Public Sub New(ByVal gender As String, ByVal age As String)
            Me.genderField = gender
            Me.ageField = age
        End Sub

        Public Overrides Function ToString() As String
            Return Me.Gender & ": " & Me.Age
        End Function
    End Structure

    Public Class DevAVDataItem

        <DevExpress.Utils.Filtering.FilterRangeAttribute(EditorType:=DevExpress.Utils.Filtering.RangeUIEditorType.Range)>
        <System.ComponentModel.DataAnnotations.DisplayAttribute(Order:=1)>
        Public Property Year As Integer

        <System.ComponentModel.DataAnnotations.DisplayAttribute(AutoGenerateFilter:=False)>
        Public Property Region As String

        <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Sales, millions of USD", Order:=3)>
        Public Property Sales As Decimal

        <System.ComponentModel.DataAnnotations.DisplayAttribute(AutoGenerateFilter:=False)>
        Public Property Cost As Decimal

        <System.ComponentModel.DataAnnotations.DisplayAttribute(AutoGenerateFilter:=False)>
        Public Property ProductCategory As String

        <DevExpress.Utils.Filtering.FilterLookupAttribute(UseBlanks:=False, UseSelectAll:=False)>
        <System.ComponentModel.DataAnnotations.DisplayAttribute(Order:=2)>
        Public Property Company As String

        <System.ComponentModel.DataAnnotations.DisplayAttribute(AutoGenerateFilter:=False)>
        Public Property SaleDate As DateTime

        <System.ComponentModel.DataAnnotations.DisplayAttribute(Name:="Charges, millions of USD", Order:=4)>
        Public Property Charges As Decimal

        <System.ComponentModel.DataAnnotations.DisplayAttribute(AutoGenerateFilter:=False)>
        Public Property Penalties As Decimal
    End Class

    Public Class PerformanceDataItem

        Private _Time As TimeSpan, _Process1CpuUsage As Double, _Process2CpuUsage As Double, _Process3CpuUsage As Double, _Process1Memory As Double, _Process2Memory As Double, _Process3Memory As Double

        Public Property Time As TimeSpan
            Get
                Return _Time
            End Get

            Private Set(ByVal value As TimeSpan)
                _Time = value
            End Set
        End Property

        Public Property Process1CpuUsage As Double
            Get
                Return _Process1CpuUsage
            End Get

            Private Set(ByVal value As Double)
                _Process1CpuUsage = value
            End Set
        End Property

        Public Property Process2CpuUsage As Double
            Get
                Return _Process2CpuUsage
            End Get

            Private Set(ByVal value As Double)
                _Process2CpuUsage = value
            End Set
        End Property

        Public Property Process3CpuUsage As Double
            Get
                Return _Process3CpuUsage
            End Get

            Private Set(ByVal value As Double)
                _Process3CpuUsage = value
            End Set
        End Property

        Public Property Process1Memory As Double
            Get
                Return _Process1Memory
            End Get

            Private Set(ByVal value As Double)
                _Process1Memory = value
            End Set
        End Property

        Public Property Process2Memory As Double
            Get
                Return _Process2Memory
            End Get

            Private Set(ByVal value As Double)
                _Process2Memory = value
            End Set
        End Property

        Public Property Process3Memory As Double
            Get
                Return _Process3Memory
            End Get

            Private Set(ByVal value As Double)
                _Process3Memory = value
            End Set
        End Property

        Public Sub New(ByVal second As Integer, ByVal process1CpuUsage As Double, ByVal process2CpuUsage As Double, ByVal process3CpuUsage As Double, ByVal process1Memory As Double, ByVal process2Memory As Double, ByVal process3Memory As Double)
            Me.Time = System.TimeSpan.FromSeconds(second)
            Me.Process1CpuUsage = process1CpuUsage
            Me.Process2CpuUsage = process2CpuUsage
            Me.Process3CpuUsage = process3CpuUsage
            Me.Process1Memory = process1Memory
            Me.Process2Memory = process2Memory
            Me.Process3Memory = process3Memory
        End Sub
    End Class

    <System.Xml.Serialization.XmlTypeAttribute("CountryInfo")>
    Public Class CountryStatisticInfo

        Public Property Name As String

        <System.Xml.Serialization.XmlArrayAttribute("Statistic")>
        <System.Xml.Serialization.XmlArrayItemAttribute("PopulationStatisticByYear")>
        Public Property PopulationDynamic As List(Of DevExpress.XtraCharts.Demos.PopulationStatisticByYear)

        Public Property AreaSqrKilometers As Double

        Public ReadOnly Property AreaMSqrKilometers As Double
            Get
                Return Me.AreaSqrKilometers / 1000000
            End Get
        End Property
    End Class

    Public Class PopulationStatisticByYear

        Public Property Year As Integer

        Public Property Population As Double

        Public Property UrbanPercent As Double

        Public ReadOnly Property PopulationMillionsOfPeople As Double
            Get
                Return Me.Population / 1000000
            End Get
        End Property
    End Class
End Namespace
