Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraTreeMap

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class SelectionDemo
        Inherits DevExpress.XtraCharts.Demos.ChartDemoModuleWithOptions

        Private focusedChart As DevExpress.XtraCharts.ChartControl

        Private blockTreeMapSelectionCallback As Boolean = False

        Private blockChartSelectionCallback As Boolean = False

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return Me.focusedChart
            End Get
        End Property

        Friend Overrides ReadOnly Property ChartControls As List(Of DevExpress.XtraCharts.ChartControl)
            Get
                Return New System.Collections.Generic.List(Of DevExpress.XtraCharts.ChartControl)() From {Me.chartCountries, Me.chartUrbanPopulationPercentage, Me.chartPopulationDynamic}
            End Get
        End Property

        Friend Overrides ReadOnly Property ExportedObject As Object
            Get
                Return Nothing
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            Me.InitializeCountriesChart()
            Me.InitializeTreeMap()
        End Sub

        Private Sub InitializeCountriesChart()
            Me.focusedChart = Me.chartCountries
            Me.chartCountries.BeginInit()
            Dim doughnutSeries As DevExpress.XtraCharts.Series = Me.chartCountries.Series("Countries Area")
            doughnutSeries.BindToData(DevExpress.XtraCharts.Demos.CountriesInfo.DataSource, "Name", "AreaMSqrKilometers")
            Dim chinaInfo As DevExpress.XtraCharts.Demos.CountryStatisticInfo = DevExpress.XtraCharts.Demos.CountriesInfo.DataSource(2)
            Me.chartCountries.SelectedItems.Add(chinaInfo)
            Me.chartCountries.EndInit()
            Me.UpdatePopulationDynamicCharts(New System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.CountryStatisticInfo)() From {chinaInfo})
            AddHandler Me.chartCountries.SelectedItemsChanged, AddressOf Me.chartCountries_SelectedItemsChanged
        End Sub

        Private Sub InitializeTreeMap()
            Dim dataAdapter As DevExpress.XtraTreeMap.TreeMapFlatDataAdapter = New DevExpress.XtraTreeMap.TreeMapFlatDataAdapter()
            dataAdapter.DataSource = DevExpress.XtraCharts.Demos.CountriesInfo.DataSource
            dataAdapter.ValueDataMember = NameOf(DevExpress.XtraCharts.Demos.CountryStatisticInfo.AreaMSqrKilometers)
            dataAdapter.LabelDataMember = NameOf(DevExpress.XtraCharts.Demos.CountryStatisticInfo.Name)
            Dim palette As DevExpress.XtraTreeMap.Palette = New DevExpress.XtraTreeMap.Palette()
            For Each entry In Me.chartCountries.GetPaletteEntries(11)
                palette.Add(entry.Color)
            Next

            Me.treeMap.Colorizer = New DevExpress.XtraTreeMap.TreeMapPaletteColorizer() With {.Palette = palette}
            Me.treeMap.DataAdapter = dataAdapter
        End Sub

        Private Sub UpdatePopulationDynamicCharts(ByVal selectedItems As System.Collections.IList)
            Me.chartPopulationDynamic.Series.Clear()
            Me.chartUrbanPopulationPercentage.Series.Clear()
            Dim entries As DevExpress.XtraCharts.PaletteEntry() = Me.chartCountries.GetPaletteEntries(11)
            For Each info As DevExpress.XtraCharts.Demos.CountryStatisticInfo In selectedItems
                Dim populationDynamic As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series(info.Name, DevExpress.XtraCharts.ViewType.Line)
                Dim lineView As DevExpress.XtraCharts.LineSeriesView = CType(populationDynamic.View, DevExpress.XtraCharts.LineSeriesView)
                lineView.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
                Dim selectedIndex As Integer = DevExpress.XtraCharts.Demos.CountriesInfo.DataSource.IndexOf(info)
                Dim color As System.Drawing.Color = entries(CInt((selectedIndex))).Color
                lineView.Color = color
                lineView.SeriesPointAnimation = New DevExpress.XtraCharts.XYMarkerSlideAnimation()
                populationDynamic.CrosshairLabelPattern = "{S}: {V:0.##}M"
                populationDynamic.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
                populationDynamic.BindToData(info.PopulationDynamic, "Year", "PopulationMillionsOfPeople")
                Me.chartPopulationDynamic.Series.Add(populationDynamic)
                Dim urban As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series(info.Name, DevExpress.XtraCharts.ViewType.Bar)
                urban.CrosshairLabelPattern = "{S}: {V:0.}%"
                urban.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
                urban.BindToData(info.PopulationDynamic, "Year", "UrbanPercent")
                Dim urbanView As DevExpress.XtraCharts.SideBySideBarSeriesView = CType(urban.View, DevExpress.XtraCharts.SideBySideBarSeriesView)
                urbanView.Color = color
                Me.chartUrbanPopulationPercentage.Series.Add(urban)
            Next
        End Sub

        Private Sub SelectCountriesOnTreeMap(ByVal infos As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.CountryStatisticInfo))
            Me.blockTreeMapSelectionCallback = True
            Me.treeMap.SelectedItems.Clear()
            For Each info In infos
                Me.treeMap.SelectedItems.Add(info)
            Next

            Me.blockTreeMapSelectionCallback = False
        End Sub

        Private Sub chartCountries_ObjectHotTracked(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs)
            If Not(TypeOf e.[Object] Is DevExpress.XtraCharts.Series) Then e.Cancel = True
        End Sub

        Private Sub chartCountries_ObjectSelected(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs)
            If Not(TypeOf e.[Object] Is DevExpress.XtraCharts.Series) Then e.Cancel = True
        End Sub

        Private Sub chartCountries_SelectedItemsChanged(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.SelectedItemsChangedEventArgs)
            If Me.blockChartSelectionCallback Then Return
            Dim infos As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.CountryStatisticInfo) = New System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.CountryStatisticInfo)()
            For Each info As DevExpress.XtraCharts.Demos.CountryStatisticInfo In Me.chartCountries.SelectedItems
                infos.Add(info)
            Next

            For Each oldItem As DevExpress.XtraCharts.Demos.CountryStatisticInfo In e.OldItems
                infos.Remove(oldItem)
            Next

            For Each newItem As DevExpress.XtraCharts.Demos.CountryStatisticInfo In e.NewItems
                If Not infos.Contains(newItem) Then infos.Add(newItem)
            Next

            Me.UpdatePopulationDynamicCharts(infos)
            Me.SelectCountriesOnTreeMap(infos)
        End Sub

        Private Sub OnChartClick(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.focusedChart = CType(sender, DevExpress.XtraCharts.ChartControl)
        End Sub

        Private Sub radioGroupSelectionMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim selectionMode As DevExpress.XtraCharts.ElementSelectionMode = CType(Me.radioGroupSelectionMode.EditValue, DevExpress.XtraCharts.ElementSelectionMode)
            If selectionMode.Equals(DevExpress.XtraCharts.ElementSelectionMode.[Single]) AndAlso Me.chartCountries.SelectedItems.Count > 1 Then Me.UpdateChartCountries()
            Me.chartCountries.SelectionMode = selectionMode
            Me.treeMap.SelectionMode = CType(Me.radioGroupSelectionMode.EditValue, DevExpress.XtraTreeMap.ElementSelectionMode)
        End Sub

        Private Sub UpdateChartCountries()
            Dim infos As System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.CountryStatisticInfo) = New System.Collections.Generic.List(Of DevExpress.XtraCharts.Demos.CountryStatisticInfo)() From {CType((Me.chartCountries.SelectedItems(0)), DevExpress.XtraCharts.Demos.CountryStatisticInfo)}
            Me.chartCountries.SelectedItems.Clear()
            Me.chartCountries.SelectedItems.Add(infos(0))
        End Sub

        Private Sub TreeMapSelectionChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeMap.SelectionChangedEventArgs)
            If Me.blockTreeMapSelectionCallback Then Return
            Me.blockChartSelectionCallback = True
            Me.chartCountries.SelectedItems.Clear()
            For Each info As DevExpress.XtraCharts.Demos.CountryStatisticInfo In e.SelectedItems
                Me.chartCountries.SelectedItems.Add(info)
            Next

            Me.blockChartSelectionCallback = False
        End Sub

        Protected Overrides Sub OnPaletteChanged()
            MyBase.OnPaletteChanged()
            Me.UpdatePopulationDynamicCharts(Me.chartCountries.SelectedItems)
        End Sub
    End Class
End Namespace
