Imports System.Collections.Generic
Imports System.Globalization
Imports System.IO
Imports System.Xml.Linq
Imports DevExpress.Utils

Namespace DevExpress.XtraTreeList.Demos

    Public Class ContinentInfo
        Inherits CountryInfo

        Private ReadOnly countriesInfoCore As List(Of CountryInfo)

        Public Sub New(ByVal name As String, ByVal totalStatistic As List(Of GDPStatisticByYear), ByVal countriesInfo As List(Of CountryInfo))
            MyBase.New(name, totalStatistic)
            countriesInfoCore = countriesInfo
        End Sub

        Public ReadOnly Property CountriesInfo As List(Of CountryInfo)
            Get
                Return countriesInfoCore
            End Get
        End Property
    End Class

    Public Class CountryInfo

        Private ReadOnly statisticCore As StatisticInfo

        Public Sub New(ByVal name As String, ByVal statistic As List(Of GDPStatisticByYear))
            statisticCore = New StatisticInfo(name, statistic)
        End Sub

        Public ReadOnly Property Statistic As StatisticInfo
            Get
                Return statisticCore
            End Get
        End Property
    End Class

    Public Class StatisticInfo

        Private ReadOnly nameCore As String

        Private ReadOnly statisticCore As List(Of GDPStatisticByYear)

        Public Sub New(ByVal name As String, ByVal statistic As List(Of GDPStatisticByYear))
            nameCore = name
            statisticCore = statistic
        End Sub

        Public ReadOnly Property Name As String
            Get
                Return nameCore
            End Get
        End Property

        Friend ReadOnly Property Statistic As List(Of GDPStatisticByYear)
            Get
                Return statisticCore
            End Get
        End Property

#Region "Years"
        Public ReadOnly Property GDPBy2004 As Double?
            Get
                Return statisticCore(0).GDP
            End Get
        End Property

        Public ReadOnly Property GDPBy2005 As Double?
            Get
                Return statisticCore(1).GDP
            End Get
        End Property

        Public ReadOnly Property GDPBy2006 As Double?
            Get
                If statisticCore Is Nothing Then Return Nothing
                Return statisticCore(2).GDP
            End Get
        End Property

        Public ReadOnly Property GDPBy2007 As Double?
            Get
                If statisticCore Is Nothing Then Return Nothing
                Return statisticCore(3).GDP
            End Get
        End Property

        Public ReadOnly Property GDPBy2008 As Double?
            Get
                If statisticCore Is Nothing Then Return Nothing
                Return statisticCore(4).GDP
            End Get
        End Property

        Public ReadOnly Property GDPBy2009 As Double?
            Get
                If statisticCore Is Nothing Then Return Nothing
                Return statisticCore(5).GDP
            End Get
        End Property

        Public ReadOnly Property GDPBy2010 As Double?
            Get
                If statisticCore Is Nothing Then Return Nothing
                Return statisticCore(6).GDP
            End Get
        End Property

        Public ReadOnly Property GDPBy2011 As Double?
            Get
                If statisticCore Is Nothing Then Return Nothing
                Return statisticCore(7).GDP
            End Get
        End Property

        Public ReadOnly Property GDPBy2012 As Double?
            Get
                If statisticCore Is Nothing Then Return Nothing
                Return statisticCore(8).GDP
            End Get
        End Property

        Public ReadOnly Property GDPBy2013 As Double?
            Get
                If statisticCore Is Nothing Then Return Nothing
                Return statisticCore(9).GDP
            End Get
        End Property

        Public ReadOnly Property GDPBy2014 As Double?
            Get
                If statisticCore Is Nothing Then Return Nothing
                Return statisticCore(10).GDP
            End Get
        End Property

        Public ReadOnly Property GDPBy2015 As Double?
            Get
                If statisticCore Is Nothing Then Return Nothing
                Return statisticCore(11).GDP
            End Get
        End Property
#End Region
    End Class

    Public Class HierarchicalStatisticInfo
        Inherits StatisticInfo

        Private _ParentID As Integer, _ID As Integer

        Public Sub New(ByVal name As String, ByVal statistic As List(Of GDPStatisticByYear))
            MyBase.New(name, statistic)
        End Sub

        Public Property ParentID As Integer
            Get
                Return _ParentID
            End Get

            Friend Set(ByVal value As Integer)
                _ParentID = value
            End Set
        End Property

        Public Property ID As Integer
            Get
                Return _ID
            End Get

            Friend Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property
    End Class

    '
    Public Class GDPStatisticByYear

        Private ReadOnly yearCore As Integer

        Private ReadOnly gdpCore As Double?

        Public Sub New(ByVal year As Integer, ByVal gdp As Double?)
            yearCore = year
            gdpCore = gdp
        End Sub

        Public ReadOnly Property Year As Integer
            Get
                Return yearCore
            End Get
        End Property

        Public ReadOnly Property GDP As Double?
            Get
                Return gdpCore
            End Get
        End Property
    End Class

    '
    Friend Module DataReader

        Public Function Load() As List(Of ContinentInfo)
            Dim data As List(Of ContinentInfo) = New List(Of ContinentInfo)()
            Try
                Dim path As String = Tutorials.FilePathUtils.FindFilePath("GDPStatistic.xml")
                Dim Continents_xml As XDocument = SafeXml.CreateXDocument(File.ReadAllText(path))
                For Each continent As XElement In Continents_xml.Root.Elements("ContinentInfo")
                    Dim name As String = continent.Element("ContinentName").Value
                    Dim statistic As List(Of GDPStatisticByYear) = LoadStatistic(continent.Element("Statistic"))
                    Dim countries As List(Of CountryInfo) = LoadCountries(continent.Element("Countries"))
                    Dim continentInfo As ContinentInfo = New ContinentInfo(name, statistic, countries)
                    data.Add(continentInfo)
                Next
            Catch
            End Try

            Return data
        End Function

        Public Function LoadHierarchical() As List(Of HierarchicalStatisticInfo)
            Dim data As List(Of HierarchicalStatisticInfo) = New List(Of HierarchicalStatisticInfo)()
            Dim continents = Load()
            Dim parentID As Integer = 0
            Dim id As Integer = 1
            For Each continent As ContinentInfo In continents
                Dim statistic = continent.Statistic
                Dim _item = New HierarchicalStatisticInfo(statistic.Name, statistic.Statistic)
                _item.ParentID = parentID
                _item.ID = System.Math.Min(System.Threading.Interlocked.Increment(id), id - 1)
                data.Add(_item)
                For Each country As CountryInfo In continent.CountriesInfo
                    Dim statisticCountry = country.Statistic
                    Dim childItem = New HierarchicalStatisticInfo(statisticCountry.Name, statisticCountry.Statistic)
                    childItem.ParentID = _item.ID
                    childItem.ID = System.Math.Min(System.Threading.Interlocked.Increment(id), id - 1)
                    data.Add(childItem)
                Next

                parentID = id
            Next

            Return data
        End Function

        '
        Private Function LoadCountries(ByVal countries As XElement) As List(Of CountryInfo)
            Dim countriesInfo As List(Of CountryInfo) = New List(Of CountryInfo)()
            For Each country As XElement In countries.Elements("CountryInfo")
                Dim name As String = country.Element("Name").Value
                Dim statistic As List(Of GDPStatisticByYear) = LoadStatistic(country.Element("Statistic"))
                Dim countryInfo As CountryInfo = New CountryInfo(name, statistic)
                countriesInfo.Add(countryInfo)
            Next

            Return countriesInfo
        End Function

        Private Function LoadStatistic(ByVal statistics As XElement) As List(Of GDPStatisticByYear)
            Dim statisticsByYear As List(Of GDPStatisticByYear) = New List(Of GDPStatisticByYear)()
            For Each statisticItem As XElement In statistics.Elements("GDPByYear")
                Dim year As Integer = Integer.Parse(statisticItem.Element("Year").Value)
                Dim gdp As Double? = GetGDP(statisticItem)
                Dim statisticByYearItem As GDPStatisticByYear = New GDPStatisticByYear(year, gdp)
                statisticsByYear.Add(statisticByYearItem)
            Next

            Return statisticsByYear
        End Function

        Private Function GetGDP(ByVal statisticItem As XElement) As Double?
            Dim value As String = statisticItem.Element("GDP").Value
            If String.IsNullOrEmpty(value) Then Return Nothing
            Return Double.Parse(value, CultureInfo.InvariantCulture)
        End Function
    End Module
End Namespace
