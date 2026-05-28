Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraMap
Imports DevExpress.XtraTreeList.Columns

Namespace DevExpress.XtraTreeList.Demos

    Public Partial Class StatisticGDP
        Inherits DevExpress.XtraTreeList.Demos.TutorialControl

        Public Overrides ReadOnly Property MainControl As TreeList
            Get
                Return Me.treeList1
            End Get
        End Property

        Private statisticInfo As System.Collections.Generic.List(Of DevExpress.XtraTreeList.Demos.HierarchicalStatisticInfo)

        Public Sub New()
            Me.InitializeComponent()
            Me.InitializeData()
            Me.InitializeTreeList()
            Me.InitializeComboBox()
            Me.InitializeMap()
            AddHandler Me.LookAndFeel.StyleChanged, AddressOf Me.LookAndFeel_StyleChanged
            Me.mapControl1.BackColor = Me.BackColor
        End Sub

        Private Sub InitializeData()
            Me.statisticInfo = DevExpress.XtraTreeList.Demos.DataReader.LoadHierarchical()
        End Sub

        Private Sub StatisticGDP_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.LoadTreeList()
        End Sub

        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.mapControl1.BackColor = Me.BackColor
        End Sub

#Region "TreeList"
        Private Sub InitializeTreeList()
            Me.treeList1.DataSource = Me.statisticInfo
            Me.treeList1.BestFitColumns()
            Me.treeList1.OptionsMenu.ShowConditionalFormattingItem = True
            Me.treeList1.ActiveFilterCriteria = New DevExpress.Data.Filtering.BinaryOperator("GDPBy2015", 450000000000.0, DevExpress.Data.Filtering.BinaryOperatorType.GreaterOrEqual)
        End Sub

        Private Sub LoadTreeList()
            Me.treeList1.ForceInitialize()
            Me.treeList1.BestFitColumns()
            Me.treeList1.ExpandAll()
            Me.treeList1.HorzScrollStep = Me.tlcGDPBy2004.Width
        End Sub

        Private Sub treeList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        End Sub

#End Region
#Region "ComboBox"
        Private years As System.Collections.Generic.List(Of DevExpress.XtraTreeList.Demos.StatisticGDP.SimpleComboBoxItem)

        Private Sub InitializeComboBox()
            Me.currentColumn = New DevExpress.XtraTreeList.Demos.StatisticGDP.CurrentColumns()
            Me.years = Me.treeList1.Columns.Where(Function(column)(column.FieldName.Contains("GDPBy"))).[Select](Function(column) New DevExpress.XtraTreeList.Demos.StatisticGDP.SimpleComboBoxItem() With {.Caption = column.Caption, .FieldName = column.FieldName}).ToList()
            Dim yearsWithoutFirstElement = Me.years.Where(Function(year) Not year.FieldName.Contains("2004")).ToList()
            Me.cbeSelectedYear.Properties.Items.AddRange(yearsWithoutFirstElement)
            Me.selectedYearIndex = Me.cbeSelectedYear.Properties.Items.Count - 1
            Me.cbeSelectedYear.SelectedIndex = Me.cbeSelectedYear.Properties.Items.Count - 1
        End Sub

        Private selectedYearIndex As Integer

        Private currentColumn As DevExpress.XtraTreeList.Demos.StatisticGDP.CurrentColumns

        Private Sub cbeSelectedYear_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.selectedYearIndex = Me.cbeSelectedYear.SelectedIndex + 1
            Dim year As DevExpress.XtraTreeList.Demos.StatisticGDP.SimpleComboBoxItem = Me.years(Me.selectedYearIndex)
            Dim prevYear As DevExpress.XtraTreeList.Demos.StatisticGDP.SimpleComboBoxItem = Me.years(Me.selectedYearIndex - 1)
            Me.tlcGDPGrowth.UnboundExpression = String.Format("({0} - {1}) / {0}", year.FieldName, prevYear.FieldName)
            If Me.currentColumn.Column IsNot Nothing Then
                Me.treeList1.Bands(CStr((Me.currentColumn.Band.Name))).Columns.Add(Me.currentColumn.Column)
            End If

            Me.currentColumn.Column = Me.treeList1.Columns(year.FieldName)
            Me.currentColumn.Band = Me.treeList1.Bands(Me.currentColumn.Column.ParentBand.Name)
            Me.bcStatistic.Columns.Clear()
            Me.bcStatistic.Columns.Add(Me.currentColumn.Column)
            Me.bcStatistic.Columns.Add(Me.tlcGDPGrowth)
            Me.treeList1.FormatRules(CStr(("Year"))).Column = Me.currentColumn.Column
            If Me.continentView Then
                Me.UpdateMapColorizer(Me.GdpWorldColorizer, Me.worldLayer, Me.selectedYearIndex)
                Me.UpdateMapLegend(Me.GdpWorldLegend)
            Else
                Me.UpdateMapColorizer(Me.GdpContinentColorizer, Me.continentLayer, Me.selectedYearIndex)
                Me.UpdateMapLegend(Me.GdpContinentLegend)
            End If
        End Sub

        Private Class CurrentColumns

            Public Property Column As TreeListColumn

            Public Property Band As TreeListBand
        End Class

        Private Class SimpleComboBoxItem

            Public Property FieldName As String

            Public Property Caption As String

            Public Overrides Function ToString() As String
                Return Me.Caption
            End Function
        End Class

#End Region
#Region "Map"
        Const GdpContinentToolTipPattern As String = "{Continent}: ${GDP_MD_EST:#,0}M"

        Const GdpCountryToolTipPattern As String = "{NAME}: ${GDP_MD_EST:#,0}M"

        Private Property Legend As ItemsLayerLegend
            Get
                Return If(Me.MapControl.Legends.Count > 0, CType(Me.MapControl.Legends(0), DevExpress.XtraMap.ItemsLayerLegend), Nothing)
            End Get

            Set(ByVal value As ItemsLayerLegend)
                If Me.MapControl.Legends.Count > 0 Then Me.MapControl.Legends.RemoveAt(0)
                If value IsNot Nothing Then Me.MapControl.Legends.Add(value)
            End Set
        End Property

        Public ReadOnly Property MapControl As MapControl
            Get
                Return Me.mapControl1
            End Get
        End Property

        Private Sub InitializeMap()
            Me.continentsShapefile.FileUri = New System.Uri(DevExpress.Tutorials.FilePathUtils.FindFilePath("ShapeFiles\Continents.shp"))
            Me.legendAlignment = DevExpress.XtraMap.LegendAlignment.BottomRight
            Me.SetupWorldLayer()
        End Sub

#Region "Legend Alignment"
        Private legendAlignment As DevExpress.XtraMap.LegendAlignment

        Private Function GetLegendAlignment(ByVal value As String) As LegendAlignment
            Dim alignment As DevExpress.XtraMap.LegendAlignment
            System.[Enum].TryParse(Of DevExpress.XtraMap.LegendAlignment)(value, alignment)
            Return alignment
        End Function

        Private Sub UpdateLegendAligment()
            Dim choroplethColorizer As DevExpress.XtraMap.ChoroplethColorizer = TryCast(Me.worldLayer.Colorizer, DevExpress.XtraMap.ChoroplethColorizer)
            If choroplethColorizer IsNot Nothing AndAlso Me.Legend IsNot Nothing Then
                Me.Legend.Alignment = Me.legendAlignment
            End If
        End Sub

#End Region
        Private Sub ContinentLayer_DataLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraMap.DataLoadedEventArgs)
            Dim items = CType(e, DevExpress.XtraMap.MapItemsLoadedEventArgs).Items
            For Each _item As DevExpress.XtraMap.MapItem In items
                Dim shapeName As String = CStr(_item.Attributes(CStr(("Continent"))).Value)
                If Equals(shapeName, "Others") Then _item.Visible = False
            Next
        End Sub

        Private Sub mapControl1_MapItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraMap.MapItemClickEventArgs)
            If Not Me.continentView Then Return
            Me.SetupContinentLayer(e.Item)
        End Sub

        Private Sub btBackToWorld_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.SetupWorldLayer()
        End Sub

#Region "Infrastructure"
        Private Function GetColorItems(ByVal colors As System.Collections.Generic.List(Of System.Drawing.Color)) As GenericColorizerItemCollection(Of DevExpress.XtraMap.ColorizerColorItem)
            Dim result As DevExpress.XtraMap.GenericColorizerItemCollection(Of DevExpress.XtraMap.ColorizerColorItem) = New DevExpress.XtraMap.GenericColorizerItemCollection(Of DevExpress.XtraMap.ColorizerColorItem)()
            result.BeginUpdate()
            Try
                For Each color As System.Drawing.Color In colors
                    result.Add(New DevExpress.XtraMap.ColorizerColorItem(color))
                Next
            Finally
                result.EndUpdate()
            End Try

            Return result
        End Function

        Private continentView As Boolean = True

        Private Sub UpdateView(ByVal continentView As Boolean)
            Me.continentView = continentView
            Me.worldLayer.Visible = continentView
            Me.btBackToWorld.Visible = Not continentView
            Me.allCountriesOnSelectedContinentLayer.Visible = Not continentView
            Me.continentLayer.Visible = Not continentView
        End Sub

        Private Sub UpdateMapLegend(ByVal legend As DevExpress.XtraMap.ItemsLayerLegend)
            Me.Legend = legend
        End Sub

        Private Sub UpdateMapColorizer(ByVal colorizer As DevExpress.XtraMap.MapColorizer, ByVal layer As DevExpress.XtraMap.VectorItemsLayer, ByVal year As Integer)
            CType(CType(colorizer, DevExpress.XtraMap.ChoroplethColorizer).ValueProvider, DevExpress.XtraTreeList.Demos.HierarchicalValueProvider).YearIndex = year
            layer.Colorizer = colorizer
            'continentLayer.ToolTipPattern = GdpContinentToolTipPattern;
            'topCountriesLayer.ToolTipPattern = GdpCountryToolTipPattern;
            Me.UpdateLegendAligment()
        End Sub

#End Region
#Region "World Layer"
        Private gdpWorldColorizerCore As DevExpress.XtraMap.ChoroplethColorizer

        Private gdpWorldLegendCore As DevExpress.XtraMap.ColorScaleLegend

        Private ReadOnly Property GdpWorldColorizer As ChoroplethColorizer
            Get
                If Me.gdpWorldColorizerCore Is Nothing Then Me.gdpWorldColorizerCore = Me.CreateGdpWorldColorizer()
                Return Me.gdpWorldColorizerCore
            End Get
        End Property

        Private Function CreateGdpWorldColorizer() As ChoroplethColorizer
            Dim colorizer As DevExpress.XtraMap.ChoroplethColorizer = New DevExpress.XtraMap.ChoroplethColorizer()
            colorizer.RangeStops.AddRange(New System.Collections.Generic.List(Of Double) From {0, 5000, 10000, 15000, 20000, 25000})
            Dim colors As System.Collections.Generic.List(Of System.Drawing.Color) = New System.Collections.Generic.List(Of System.Drawing.Color) From {System.Drawing.Color.FromArgb(&H5F, &H8B, &H95), System.Drawing.Color.FromArgb(&HA2, &HA8, &H75), System.Drawing.Color.FromArgb(&HF2, &HCB, &H4E), System.Drawing.Color.FromArgb(&HE5, &HA8, &H4D), System.Drawing.Color.FromArgb(&HBA, &H4D, &H51)}
            colorizer.ColorItems.AddRange(Me.GetColorItems(colors))
            colorizer.ValueProvider = New DevExpress.XtraTreeList.Demos.HierarchicalValueProvider() With {.AttributeName = "Continent", .StatisticInfo = Me.statisticInfo, .Round = 1000000000}
            colorizer.ApproximateColors = True
            Return colorizer
        End Function

        Private ReadOnly Property GdpWorldLegend As ColorScaleLegend
            Get
                If Me.gdpWorldLegendCore Is Nothing Then Me.gdpWorldLegendCore = Me.CreateGdpWorldLegend()
                Return Me.gdpWorldLegendCore
            End Get
        End Property

        Private Function CreateGdpWorldLegend() As ColorScaleLegend
            Dim _legend As DevExpress.XtraMap.ColorScaleLegend = New DevExpress.XtraMap.ColorScaleLegend()
            _legend.Header = "GDP by Continents"
            _legend.Description = "In US dollars"
            _legend.RangeStopsFormat = "0,B"
            _legend.Layer = Me.worldLayer
            Return _legend
        End Function

        Private Sub SetupWorldLayer()
            Me.UpdateView(True)
            Me.MapControl.ZoomToFitLayerItems(New DevExpress.XtraMap.LayerBase() {Me.worldLayer}, 0.15)
            Me.UpdateMapLegend(Me.GdpWorldLegend)
            Me.UpdateMapColorizer(Me.GdpWorldColorizer, Me.worldLayer, Me.selectedYearIndex)
        End Sub

#End Region
#Region "Continent Layer"
        Private gdpContinentColorizerCore As DevExpress.XtraMap.ChoroplethColorizer

        Private gdpContinentLegendCore As DevExpress.XtraMap.ColorScaleLegend

        Private ReadOnly Property GdpContinentColorizer As ChoroplethColorizer
            Get
                If Me.gdpContinentColorizerCore Is Nothing Then Me.gdpContinentColorizerCore = Me.CreateGdpContinentColorizer()
                Return Me.gdpContinentColorizerCore
            End Get
        End Property

        Private Function CreateGdpContinentColorizer() As ChoroplethColorizer
            Dim colorizer As DevExpress.XtraMap.ChoroplethColorizer = New DevExpress.XtraMap.ChoroplethColorizer()
            colorizer.RangeStops.AddRange(New System.Collections.Generic.List(Of Double) From {0, 500, 10000, 50000, 200000, 500000, 1000000})
            Dim colors As System.Collections.Generic.List(Of System.Drawing.Color) = New System.Collections.Generic.List(Of System.Drawing.Color) From {System.Drawing.Color.FromArgb(&H79, &H96, &H89), System.Drawing.Color.FromArgb(&HCE, &HBB, &H5F), System.Drawing.Color.FromArgb(&HF1, &HC1, &H49), System.Drawing.Color.FromArgb(&HD6, &H86, &H4E), System.Drawing.Color.FromArgb(&HC5, &H64, &H50), System.Drawing.Color.FromArgb(&HBA, &H4D, &H51)}
            colorizer.ColorItems.AddRange(Me.GetColorItems(colors))
            colorizer.ValueProvider = New DevExpress.XtraTreeList.Demos.HierarchicalValueProvider() With {.AttributeName = "ADMIN", .StatisticInfo = Me.statisticInfo, .Round = 10000000}
            colorizer.ApproximateColors = True
            Return colorizer
        End Function

        Private ReadOnly Property GdpContinentLegend As ColorScaleLegend
            Get
                If Me.gdpContinentLegendCore Is Nothing Then Me.gdpContinentLegendCore = Me.CreateGdpContinentLegend()
                Return Me.gdpContinentLegendCore
            End Get
        End Property

        Private Function CreateGdpContinentLegend() As ColorScaleLegend
            Dim _legend As DevExpress.XtraMap.ColorScaleLegend = New DevExpress.XtraMap.ColorScaleLegend()
            _legend.Header = "GDP by Countries"
            _legend.Description = "In US dollars"
            _legend.RangeStopsFormat = "0,M"
            _legend.Layer = Me.continentLayer
            Return _legend
        End Function

        Private selectedContinent As String

        Private Sub SetupContinentLayer(ByVal _item As DevExpress.XtraMap.MapItem)
            Me.UpdateView(False)
            Me.selectedContinent = _item.Attributes(CStr(("Continent"))).Value.ToString()
            Dim continentShapeFileName As String = System.IO.Path.Combine("ShapeFiles", Me.selectedContinent & ".shp")
            Me.allCountriesOnSelectedContinentLayer.Data = New DevExpress.XtraMap.ShapefileDataAdapter() With {.FileUri = New System.Uri(DevExpress.Tutorials.FilePathUtils.FindFilePath(continentShapeFileName))}
            Me.PopulateTopItems()
            Me.MapControl.ZoomToFitLayerItems(New DevExpress.XtraMap.LayerBase() {Me.continentLayer}, 0.15)
            Me.UpdateMapLegend(Me.GdpContinentLegend)
            Me.UpdateMapColorizer(Me.GdpContinentColorizer, Me.continentLayer, Me.selectedYearIndex)
        End Sub

        Private Sub PopulateTopItems()
            Dim data As DevExpress.XtraMap.ShapefileDataAdapter = New DevExpress.XtraMap.ShapefileDataAdapter() With {.FileUri = New System.Uri(DevExpress.Tutorials.FilePathUtils.FindFilePath("ShapeFiles\Countries.shp"))}
            AddHandler data.ItemsLoaded, AddressOf Me.Data_ItemsLoaded
            data.Load()
            Dim storage As DevExpress.XtraMap.MapItemStorage = New DevExpress.XtraMap.MapItemStorage()
            For Each _item As DevExpress.XtraMap.MapItem In CType(data, DevExpress.XtraMap.IMapDataAdapter).Items
                storage.Items.Add(_item)
            Next

            Me.continentLayer.Data = storage
        End Sub

        Private Sub Data_ItemsLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraMap.ItemsLoadedEventArgs)
            RemoveHandler CType(sender, DevExpress.XtraMap.ShapefileDataAdapter).ItemsLoaded, AddressOf Me.Data_ItemsLoaded
            For i As Integer = e.Items.Count - 1 To 0 Step -1
                If Not Equals(e.Items(CInt((i))).Attributes(CStr(("Continent"))).Value.ToString(), Me.selectedContinent) Then e.Items.RemoveAt(i)
            Next
        End Sub
#End Region
#End Region
    End Class

    Public Class HierarchicalValueProvider
        Inherits DevExpress.XtraMap.ShapeAttributeValueProvider

        Private _StatisticInfo As List(Of DevExpress.XtraTreeList.Demos.HierarchicalStatisticInfo)

        Private yearIndexCore As Integer

        Public Property StatisticInfo As List(Of DevExpress.XtraTreeList.Demos.HierarchicalStatisticInfo)
            Get
                Return _StatisticInfo
            End Get

            Friend Set(ByVal value As List(Of DevExpress.XtraTreeList.Demos.HierarchicalStatisticInfo))
                _StatisticInfo = value
            End Set
        End Property

        Public Property Round As Integer

        Public Property YearIndex As Integer
            Get
                Return Me.yearIndexCore
            End Get

            Friend Set(ByVal value As Integer)
                If Me.yearIndexCore = value Then Return
                Me.yearIndexCore = value
                Me.RaiseChanged()
            End Set
        End Property

        Protected Overrides Function GetValue(ByVal _item As DevExpress.XtraMap.IColorizerElement) As Double
            Dim shapeItem As DevExpress.XtraMap.MapShape = TryCast(_item, DevExpress.XtraMap.MapShape)
            If shapeItem Is Nothing Then Return Double.NaN
            Dim attr As DevExpress.XtraMap.MapItemAttribute = shapeItem.Attributes(Me.AttributeName)
            If attr IsNot Nothing AndAlso attr.Value IsNot Nothing Then
                Dim hsi = Me.StatisticInfo.Find(Function(country) Equals(country.Name, attr.Value.ToString()))
                If hsi Is Nothing Then Return Double.NaN
                Dim gdp As Double? = hsi.Statistic(CInt((Me.YearIndex))).GDP
                Return If(gdp.HasValue, gdp.Value / Me.Round, Double.NaN)
            End If

            Return Double.NaN
        End Function
    End Class
End Namespace
