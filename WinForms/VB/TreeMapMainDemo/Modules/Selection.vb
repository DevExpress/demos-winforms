Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Xml.Linq
Imports DevExpress.XtraCharts
Imports DevExpress.XtraMap

Namespace DevExpress.XtraTreeMap.Demos

    Public Partial Class Selection
        Inherits TreeMapTutorialControl

        Const AlphaColor As Byte = 128

        Const ChartTitle As String = "GDP Dynamic"

        Private isSelectionLocked As Boolean = False

        Private ReadOnly countries As List(Of CountryStatisticInfo)

        Private ReadOnly Property BackgroundLayer As VectorItemsLayer
            Get
                Return CType(mapControl.Layers("BackgroundLayer"), VectorItemsLayer)
            End Get
        End Property

        Private ReadOnly Property DataLayer As VectorItemsLayer
            Get
                Return CType(mapControl.Layers("FileLayer"), VectorItemsLayer)
            End Get
        End Property

        Private ReadOnly Property DataAdapter As TreeMapFlatDataAdapter
            Get
                Return CType(treeMapControl1.DataAdapter, TreeMapFlatDataAdapter)
            End Get
        End Property

        Private ReadOnly Property MapColorizer As ChoroplethColorizer
            Get
                Return CType(DataLayer.Colorizer, ChoroplethColorizer)
            End Get
        End Property

        Private ReadOnly Property TreeMapColorizer As TreeMapPaletteColorizer
            Get
                Return CType(treeMapControl1.Colorizer, TreeMapPaletteColorizer)
            End Get
        End Property

        Private ReadOnly Property ChartSeries As Series
            Get
                Return chartControl1.Series(0)
            End Get
        End Property

        Public Overrides ReadOnly Property ActiveDemoModule As Control
            Get
                Return treeMapControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            countries = CountriesInfoDataReader.Load()
            BackgroundLayer.Data = CreateShapefileDataAdapter()
            DataLayer.Data = CreateShapefileDataAdapter()
            AddHandler DataLayer.DataLoaded, AddressOf FileLayer_DataLoaded
            DataAdapter.DataSource = countries
            InitializeColorizers()
        End Sub

        Private Sub InitializeColorizers()
            TreeMapColorizer.Palette = Palette.CreatePalette(SelectionDemoPalette)
            For Each color As Color In SelectionDemoPalette
                MapColorizer.ColorItems.Add(New ColorizerColorItem(color))
            Next
        End Sub

        Private Function CreateShapefileDataAdapter() As ShapefileDataAdapter
            Dim adapter As ShapefileDataAdapter = New ShapefileDataAdapter()
            adapter.FileUri = New Uri("file:\\" & GetRelativePath("CountriesGDP.shp"), UriKind.RelativeOrAbsolute)
            Return adapter
        End Function

        Private Sub SetMapItems(ByVal layerMapItemCollection As IEnumerable(Of MapItem))
            For Each item As MapItem In layerMapItemCollection
                Dim shapeName As String = CStr(item.Attributes("NAME").Value)
                If Equals(shapeName, "Others") Then item.Visible = False
                Dim countryInfo As CountryStatisticInfo = countries.Find(Function(info) Equals(info.Name, shapeName))
                If countryInfo IsNot Nothing Then
                    countryInfo.Shape = item
                    item.Attributes.Add(New MapItemAttribute() With {.Name = "CountryInfo", .Type = GetType(CountryStatisticInfo), .Value = countryInfo})
                    If Equals(countryInfo.Name, "United States") Then DataLayer.SelectedItem = item
                End If
            Next
        End Sub

        Private Sub UpdateChart(ByVal countryInfo As CountryStatisticInfo)
            If countryInfo IsNot Nothing Then
                ChartSeries.DataSource = countryInfo.GDPDynamic
                ChartSeries.View.Color = Color.FromArgb(AlphaColor, SelectionDemoPalette(countryInfo.ColorIndex))
                chartControl1.Titles(0).Text = countryInfo.Name & " " & ChartTitle
            Else
                ChartSeries.DataSource = Nothing
                chartControl1.Titles(0).Text = String.Empty
            End If
        End Sub

        Private Sub FileLayer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            SetMapItems(CType(e, MapItemsLoadedEventArgs).Items)
            mapControl.EnableZooming = True
            mapControl.ZoomToFitLayerItems()
            mapControl.EnableZooming = False
        End Sub

        Private Sub mapControl_SelectionChanged(ByVal sender As Object, ByVal e As MapSelectionChangedEventArgs)
            Dim countryInfo As CountryStatisticInfo = GetMapSelectedCountryInfo()
            UpdateSelection(countryInfo, Sub(country)
                treeMapControl1.SelectedItems.Clear()
                If country IsNot Nothing Then treeMapControl1.SelectedItems.Add(country)
            End Sub)
        End Sub

        Private Sub treeMapControl_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
            Dim countryInfo As CountryStatisticInfo = GetTreeMapSelectedCountryInfo()
            UpdateSelection(countryInfo, Sub(country)
                DataLayer.SelectedItems.Clear()
                If country IsNot Nothing Then DataLayer.SelectedItems.Add(country.Shape)
            End Sub)
        End Sub

        Private Sub layoutControl_ClientSizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            mapControl.EnableZooming = True
            mapControl.ZoomToFitLayerItems()
            mapControl.EnableZooming = False
        End Sub

        Private Function GetTreeMapSelectedCountryInfo() As CountryStatisticInfo
            If treeMapControl1.SelectedItems.Count > 0 Then Return CType(treeMapControl1.SelectedItems(0), CountryStatisticInfo)
            Return Nothing
        End Function

        Private Function GetMapSelectedCountryInfo() As CountryStatisticInfo
            If DataLayer.SelectedItems.Count > 0 Then
                Dim mapItem As MapItem = CType(DataLayer.SelectedItems(0), MapItem)
                Return CType(mapItem.Attributes("CountryInfo").Value, CountryStatisticInfo)
            End If

            Return Nothing
        End Function

        Private Sub UpdateSelection(ByVal countryInfo As CountryStatisticInfo, ByVal action As Action(Of CountryStatisticInfo))
            If Not isSelectionLocked Then
                isSelectionLocked = True
                Try
                    action(countryInfo)
                    UpdateChart(countryInfo)
                Finally
                    isSelectionLocked = False
                End Try
            End If
        End Sub
    End Class

    Public Class CountryStatisticInfo

        Private ReadOnly _name As String

        Private ReadOnly _continent As String

        Private ReadOnly _statistic As List(Of GDPStatisticByYear)

        Private ReadOnly _gdp As Double

        Private ReadOnly _colorIndex As Integer

        Private _shape As MapItem

        Public ReadOnly Property Name As String
            Get
                Return _name
            End Get
        End Property

        Public ReadOnly Property Continent As String
            Get
                Return _continent
            End Get
        End Property

        Public ReadOnly Property GDPDynamic As List(Of GDPStatisticByYear)
            Get
                Return _statistic
            End Get
        End Property

        Public ReadOnly Property GDP As Double
            Get
                Return _gdp
            End Get
        End Property

        Public ReadOnly Property ColorIndex As Integer
            Get
                Return _colorIndex
            End Get
        End Property

        Public Property Shape As MapItem
            Get
                Return _shape
            End Get

            Set(ByVal value As MapItem)
                _shape = value
            End Set
        End Property

        Public Sub New(ByVal name As String, ByVal continent As String, ByVal gdp As Double, ByVal colorIndex As Integer, ByVal statistic As List(Of GDPStatisticByYear))
            _name = name
            _continent = continent
            _gdp = gdp
            _colorIndex = colorIndex
            _statistic = statistic
        End Sub
    End Class

    Public Class GDPStatisticByYear

        Private ReadOnly _year As Integer

        Private ReadOnly _gdp As Double

        Public ReadOnly Property Year As Integer
            Get
                Return _year
            End Get
        End Property

        Public ReadOnly Property GDP As Double
            Get
                Return _gdp
            End Get
        End Property

        Public Sub New(ByVal year As Integer, ByVal gdp As Double)
            _year = year
            _gdp = gdp
        End Sub
    End Class

    Friend Class CountriesInfoDataReader

        Private Shared Function LoadStatistic(ByVal exportOfGoodsDynamic As XElement) As List(Of GDPStatisticByYear)
            Dim statistic As List(Of GDPStatisticByYear) = New List(Of GDPStatisticByYear)()
            For Each exportOfGoodsDynamicItem As XElement In exportOfGoodsDynamic.Elements("GDPByYear")
                Dim year As Integer = Integer.Parse(exportOfGoodsDynamicItem.Element("Year").Value)
                Dim exportOfGoodsPercent As Double = Double.Parse(exportOfGoodsDynamicItem.Element("GDP").Value, CultureInfo.InvariantCulture)
                Dim popDynamicItem As GDPStatisticByYear = New GDPStatisticByYear(year, exportOfGoodsPercent)
                statistic.Add(popDynamicItem)
            Next

            Return statistic
        End Function

        Public Shared Function Load() As List(Of CountryStatisticInfo)
            Dim data As List(Of CountryStatisticInfo) = New List(Of CountryStatisticInfo)()
            Try
                Dim Top10LargestCountries_xml As XDocument = XDocument.Load(GetRelativePath("CountriesGDPByYears.xml"))
                For Each countryInfo As XElement In Top10LargestCountries_xml.Root.Elements("CountryInfo")
                    Dim name As String = countryInfo.Element("Name").Value
                    Dim gdp As String = countryInfo.Element("GDP").Value
                    Dim continent As String = countryInfo.Element("Continent").Value
                    Dim colorIndex As String = countryInfo.Element("ColorIndex").Value
                    Dim statistic As List(Of GDPStatisticByYear) = LoadStatistic(countryInfo.Element("Statistic"))
                    Dim countryInfoInstance As CountryStatisticInfo = New CountryStatisticInfo(name, continent, Convert.ToDouble(gdp), Convert.ToInt32(colorIndex), statistic)
                    data.Add(countryInfoInstance)
                Next
            Catch
            End Try

            Return data
        End Function
    End Class
End Namespace
