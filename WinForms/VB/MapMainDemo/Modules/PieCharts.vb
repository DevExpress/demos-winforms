Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace DevExpress.XtraMap.Demos

    Public Partial Class PieCharts
        Inherits MapTutorialControl

        Private ReadOnly Property Tooltip As MapCallout
            Get
                Return CType(tooptipMapItemStorage.Items(0), MapCallout)
            End Get
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return mapControlField
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            ChangePieItemSize()
            PrepareDataSources()
        End Sub

        Private Sub PrepareDataSources()
            shapefileDataAdapter.FileUri = DemoUtils.GetFileUri("EUR.shp")
            Dim energyStatistics As EnergyStatistics = New EnergyStatistics()
            pieChartDataAdapter.DataSource = energyStatistics.EnergyUnits
        End Sub

        Private Sub ChangePieItemSize()
            pieChartDataAdapter.ItemMaxSize = pieSizeRangeTrackBar.Value.Maximum
            pieChartDataAdapter.ItemMinSize = pieSizeRangeTrackBar.Value.Minimum
        End Sub

        Private Sub ShowTooltipCallout(ByVal country As EnergyCountry)
            Tooltip.Visible = True
            Tooltip.Location = country.Location
            Dim idx As Integer = pieDataRadioGroup.SelectedIndex
            Dim energyTypes As IEnumerable(Of String) = country.EnergyUnits.Select(Function(item) $"{item.Key}: <b>{item.Value(idx)}</b>")
            Tooltip.Text = $"<size=+4>{country.Name}</size><br/>" & String.Join("<br/>", energyTypes)
        End Sub

        Private Sub HideTooltipCallout()
            Tooltip.Visible = False
        End Sub

        Private Sub MapControlSelectionChanged(ByVal sender As Object, ByVal e As MapSelectionChangedEventArgs)
            If e.Selection.Count = 0 Then
                HideTooltipCallout()
                Return
            End If

            Dim energyUnit As EnergyUnit = TryCast(e.Selection(0), EnergyUnit)
            If energyUnit IsNot Nothing Then
                Dim focusedCountry As EnergyCountry = energyUnit.Country
                ShowTooltipCallout(focusedCountry)
                Return
            End If

            If e.Selection(0) Is Tooltip Then Return
            HideTooltipCallout()
        End Sub

        Private Sub PieDataRadioGroupSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim mappingValue As String = pieDataRadioGroup.Properties.Items(pieDataRadioGroup.SelectedIndex).Description
            pieChartDataAdapter.Mappings.Value = mappingValue
        End Sub

        Private Sub PieSizeRangeTrackBarValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            ChangePieItemSize()
        End Sub

        Private Sub LegendTypeRadioGroupSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim sizeLegend As SizeLegend = CType(mapControlField.Legends(1), SizeLegend)
            sizeLegend.Type = CType(legendTypeRadioGroup.SelectedIndex, SizeLegendType)
        End Sub
    End Class

    Public Class EnergyUnit

        Private _EnergyType As String, _Country As EnergyCountry

        Public Property EnergyType As String
            Get
                Return _EnergyType
            End Get

            Private Set(ByVal value As String)
                _EnergyType = value
            End Set
        End Property

        Public Property Country As EnergyCountry
            Get
                Return _Country
            End Get

            Private Set(ByVal value As EnergyCountry)
                _Country = value
            End Set
        End Property

        Public Property Production As Double

        Public Property Import As Double

        Default Public ReadOnly Property Item(ByVal i As Integer) As Double
            Get
                Return If(i = 0, Production, Import)
            End Get
        End Property

        Public ReadOnly Property CountryName As String
            Get
                Return Country.Name
            End Get
        End Property

        Public ReadOnly Property Location As GeoPoint
            Get
                Return Country.Location
            End Get
        End Property

        Public Sub New(ByVal energyType As String, ByVal country As EnergyCountry)
            Me.EnergyType = energyType
            Me.Country = country
        End Sub
    End Class

    Public Class EnergyCountry

        Private _Name As String, _Location As GeoPoint

        Public Property Name As String
            Get
                Return _Name
            End Get

            Private Set(ByVal value As String)
                _Name = value
            End Set
        End Property

        Public Property Location As GeoPoint
            Get
                Return _Location
            End Get

            Private Set(ByVal value As GeoPoint)
                _Location = value
            End Set
        End Property

        Public EnergyUnits As Dictionary(Of String, EnergyUnit)

        Public Sub New(ByVal name As String, ByVal location As GeoPoint)
            Me.Name = name
            Me.Location = location
            EnergyUnits = New Dictionary(Of String, EnergyUnit)()
        End Sub
    End Class

    Public Class EnergyStatistics

        Public EnergyUnits As List(Of EnergyUnit) = New List(Of EnergyUnit)()

        Public Countries As Dictionary(Of String, EnergyCountry) = New Dictionary(Of String, EnergyCountry)()

        Public Sub New()
            Dim dataSet As DataSet = New DataSet()
            Dim path As String = DemoUtils.GetRelativePath("EuropeEnergyStatictics.xml")
            dataSet.ReadXml(path)
            Dim source As DataTable = dataSet.Tables(0)
            For Each row As DataRow In source.Rows
                Dim countryName As String = row.Field(Of String)("Country")
                Dim country As EnergyCountry = Nothing
                If Not Countries.TryGetValue(countryName, country) Then
                    Dim location As GeoPoint = New GeoPoint(row.Field(Of Double)("Latitude"), row.Field(Of Double)("Longitude"))
                    country = New EnergyCountry(countryName, location)
                    Countries.Add(countryName, country)
                End If

                Dim energyType As String = row.Field(Of String)("EnergyType")
                Dim energyUnit As EnergyUnit = Nothing
                If Not country.EnergyUnits.TryGetValue(energyType, energyUnit) Then
                    energyUnit = New EnergyUnit(energyType, country)
                    country.EnergyUnits.Add(energyType, energyUnit)
                    EnergyUnits.Add(energyUnit)
                End If

                If Not row.IsNull("Production") Then
                    energyUnit.Production += row.Field(Of Double)("Production")
                End If

                If Not row.IsNull("Import") Then
                    energyUnit.Import += row.Field(Of Double)("Import")
                End If
            Next
        End Sub
    End Class
End Namespace
