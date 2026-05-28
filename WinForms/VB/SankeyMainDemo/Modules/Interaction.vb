Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports DevExpress.Map
Imports DevExpress.XtraCharts.Sankey
Imports DevExpress.XtraMap

Namespace DevExpress.XtraSankey.Demos

    Public Partial Class Interaction
        Inherits DevExpress.XtraSankey.Demos.SankeyTutorialControl

        Private ReadOnly data As System.Collections.Generic.List(Of DevExpress.XtraSankey.Demos.Export)

        Private ReadOnly continentCountriesPairs As System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of String)) = New System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of String))()

        Private ReadOnly continentColorPairs As System.Collections.Generic.Dictionary(Of String, System.Drawing.Color) = New System.Collections.Generic.Dictionary(Of String, System.Drawing.Color)()

        Private countryNameExportPairs As System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of DevExpress.XtraSankey.Demos.Export)) = New System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of DevExpress.XtraSankey.Demos.Export))()

        Private countryNameMapItemPairs As System.Collections.Generic.Dictionary(Of String, DevExpress.XtraMap.MapItem) = New System.Collections.Generic.Dictionary(Of String, DevExpress.XtraMap.MapItem)()

        Private exportMapArrowPairs As System.Collections.Generic.Dictionary(Of DevExpress.XtraSankey.Demos.Export, DevExpress.XtraMap.MapShape) = New System.Collections.Generic.Dictionary(Of DevExpress.XtraSankey.Demos.Export, DevExpress.XtraMap.MapShape)()

        Private updateSelectedArrows As Boolean = True

        Private selectedExportItems As System.Collections.Generic.HashSet(Of DevExpress.XtraSankey.Demos.Export) = New System.Collections.Generic.HashSet(Of DevExpress.XtraSankey.Demos.Export)()

        Public Overrides ReadOnly Property SankeyDiagramControl As SankeyDiagramControl
            Get
                Return Me.sankeyDiagramControl1
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            Me.InitContinentColorPairs()
            Me.InitContinentCountriesPairs()
            Me.data = DevExpress.XtraSankey.Demos.OilTradeDataGenerator.GetData()
            Me.sankeyDiagramControl1.DataSource = Me.data
            Me.sankeyDiagramControl1.Colorizer = New DevExpress.XtraSankey.Demos.ContinentColorizer(Me.continentColorPairs, Me.continentCountriesPairs)
            Me.shapefileDataAdapter1.FileUri = DevExpress.XtraSankey.Demos.Utils.GetFileUri("Countries.shp")
            Me.backgroundLayer.Data = New DevExpress.XtraMap.ShapefileDataAdapter() With {.FileUri = DevExpress.XtraSankey.Demos.Utils.GetFileUri("Countries.shp")}
            Me.InitMapColorizer()
            Me.updateSelectedArrows = False
            Me.gridControl1.DataSource = Me.data
            Me.gridView1.ClearSelection()
            Me.updateSelectedArrows = True
        End Sub

        Private Sub InitContinentColorPairs()
            Me.continentColorPairs.Add("North America", System.Drawing.Color.FromArgb(29, 178, 245))
            Me.continentColorPairs.Add("South and Central America", System.Drawing.Color.FromArgb(151, 201, 92))
            Me.continentColorPairs.Add("Europe", System.Drawing.Color.FromArgb(255, 199, 32))
            Me.continentColorPairs.Add("CIS", System.Drawing.Color.FromArgb(44, 115, 255))
            Me.continentColorPairs.Add("Middle East", System.Drawing.Color.FromArgb(186, 85, 211))
            Me.continentColorPairs.Add("West Africa", System.Drawing.Color.FromArgb(255, 126, 32))
            Me.continentColorPairs.Add("North Africa", System.Drawing.Color.FromArgb(51, 204, 170))
            Me.continentColorPairs.Add("Africa", System.Drawing.Color.FromArgb(103, 113, 220))
            Me.continentColorPairs.Add("Australasia", System.Drawing.Color.FromArgb(198, 144, 83))
            Me.continentColorPairs.Add("Asia Pacific", System.Drawing.Color.FromArgb(245, 86, 74))
        End Sub

        Private Sub InitContinentCountriesPairs()
            Me.continentCountriesPairs.Add("North America", New System.Collections.Generic.List(Of String)() From {"United States", "Canada", "Mexico"})
            Me.continentCountriesPairs.Add("South and Central America", New System.Collections.Generic.List(Of String)() From {"Brazil", "Argentina"})
            Me.continentCountriesPairs.Add("Australasia", New System.Collections.Generic.List(Of String)() From {"Australia"})
            Me.continentCountriesPairs.Add("Europe", New System.Collections.Generic.List(Of String)() From {"Netherlands", "Germany", "United Kingdom", "Italy", "France", "Spain", "United Kingdom"})
            Me.continentCountriesPairs.Add("Asia Pacific", New System.Collections.Generic.List(Of String)() From {"Japan", "South Korea", "India", "Singapore", "Other Asia Pacific"})
            '"Other Middle East",
            Me.continentCountriesPairs.Add("Middle East", New System.Collections.Generic.List(Of String)() From {"Saudi Arabia", "UAE", "United Arab Emirates", "Kuwait", "Iraq"})
        End Sub

        Private Sub InitMapColorizer()
            Dim colorizer As DevExpress.XtraMap.KeyColorColorizer = CType(Me.interactableItemsLayer.Colorizer, DevExpress.XtraMap.KeyColorColorizer)
            colorizer.Colors.AddRange(Me.continentColorPairs.Values)
            For Each continentColorPair In Me.continentColorPairs
                colorizer.Keys.Add(New DevExpress.XtraMap.ColorizerKeyItem() With {.Key = continentColorPair.Key, .Name = continentColorPair.Key})
            Next
        End Sub

        Private Sub Adapter_ItemsLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraMap.ItemsLoadedEventArgs)
            Dim territoryNameCenterCoordPairs As System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of DevExpress.Map.CoordPoint)) = Me.GetTerritoryCenterPoints(e.Items)
            Me.CreateArrows(territoryNameCenterCoordPairs)
            Me.DisableUnknownItems(e.Items)
            Me.mapControl1.ZoomToFit(e.Items, 0)
        End Sub

        Private Sub DisableUnknownItems(ByVal mapItems As System.Collections.Generic.IList(Of DevExpress.XtraMap.MapItem))
            For Each mapItem In mapItems
                Dim countryName As String = mapItem.Attributes(CStr(("NAME"))).Value.ToString()
                If Me.countryNameExportPairs.ContainsKey(countryName) Then Continue For
                countryName = mapItem.Attributes(CStr(("CONTINENT"))).Value.ToString()
                If Not Me.countryNameExportPairs.ContainsKey(countryName) Then mapItem.Visible = False
            Next
        End Sub

        Private Function GetTerritoryCenterPoints(ByVal mapItems As System.Collections.Generic.IList(Of DevExpress.XtraMap.MapItem)) As Dictionary(Of String, System.Collections.Generic.List(Of DevExpress.Map.CoordPoint))
            Dim territoryNameCenterCoordPairs = New System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of DevExpress.Map.CoordPoint))()
            Dim nodeNames As System.Collections.Generic.List(Of String) = Me.data.[Select](Function(export) export.Exporter).Union(Me.data.[Select](Function(export) export.Importer)).ToList()
            For Each mapItem In mapItems
                Dim countryName As String = mapItem.Attributes(CStr(("NAME"))).Value.ToString()
                If Not nodeNames.Contains(countryName) Then countryName = mapItem.Attributes(CStr(("CONTINENT"))).Value.ToString()
                If Not Me.countryNameMapItemPairs.ContainsKey(countryName) Then Me.countryNameMapItemPairs.Add(countryName, mapItem)
                Dim buffPoints As System.Collections.Generic.List(Of DevExpress.Map.CoordPoint) = Nothing
                If Not territoryNameCenterCoordPairs.TryGetValue(countryName, buffPoints) Then
                    buffPoints = New System.Collections.Generic.List(Of DevExpress.Map.CoordPoint)()
                    territoryNameCenterCoordPairs.Add(countryName, buffPoints)
                End If

                For Each segment As DevExpress.XtraMap.MapPathSegment In CType(mapItem, DevExpress.XtraMap.MapPath).Segments
                    buffPoints.AddRange(segment.Points)
                Next
            Next

            Return territoryNameCenterCoordPairs
        End Function

        Private Sub CreateArrows(ByVal territoryNameCenterCoordPairs As System.Collections.Generic.Dictionary(Of String, System.Collections.Generic.List(Of DevExpress.Map.CoordPoint)))
            For Each export In Me.data
                Dim startPoint As DevExpress.XtraMap.GeoPoint = Me.GetAveragePoint(territoryNameCenterCoordPairs(export.Exporter))
                Dim endPoint As DevExpress.XtraMap.GeoPoint = Me.GetAveragePoint(territoryNameCenterCoordPairs(export.Importer))
                Dim polyline = New DevExpress.XtraMap.MapPolyline()
                polyline.Points.AddRange(New DevExpress.XtraMap.GeoPoint() {startPoint, endPoint})
                Me.SetPolylineDrawOptions(polyline)
                Me.mapItemStorage1.Items.Add(polyline)
                Dim exports As System.Collections.Generic.List(Of DevExpress.XtraSankey.Demos.Export) = Nothing
                If Not Me.countryNameExportPairs.TryGetValue(export.Exporter, exports) Then Me.countryNameExportPairs.Add(export.Exporter, CSharpImpl.__Assign(exports, New System.Collections.Generic.List(Of DevExpress.XtraSankey.Demos.Export)()))
                exports.Add(export)
                Me.exportMapArrowPairs.Add(export, polyline)
            Next
        End Sub

        Private Sub SetPolylineDrawOptions(ByVal shape As DevExpress.XtraMap.MapPolyline)
            shape.EndLineCap.Visible = True
            shape.IsGeodesic = True
            shape.Fill = System.Drawing.Color.FromArgb(255, 209, 28, 28)
            shape.Stroke = System.Drawing.Color.FromArgb(255, 209, 28, 28)
            shape.StrokeWidth = 2
            shape.Visible = False
        End Sub

        Private Function GetAveragePoint(ByVal points As System.Collections.Generic.List(Of DevExpress.Map.CoordPoint)) As GeoPoint
            Dim longitudeSum As Double = 0, latitudeSum As Double = 0
            For Each point As DevExpress.XtraMap.GeoPoint In points
                longitudeSum += point.Longitude
                latitudeSum += point.Latitude
            Next

            Return New DevExpress.XtraMap.GeoPoint(latitudeSum / points.Count, longitudeSum / points.Count)
        End Function

        Private Sub HideAllUnselectedArrows()
            If Me.exportMapArrowPairs.Count > 0 Then
                For Each linkTagMapArrowPair In Me.exportMapArrowPairs
                    If Me.selectedExportItems Is Nothing OrElse Not Me.selectedExportItems.Contains(linkTagMapArrowPair.Key) Then linkTagMapArrowPair.Value.Visible = False
                Next
            End If
        End Sub

        Private Sub SetArrowVisibilityByExport(ByVal items As System.Collections.Generic.IEnumerable(Of DevExpress.XtraSankey.Demos.Export), ByVal visible As Boolean)
            Dim shape As DevExpress.XtraMap.MapShape = Nothing
            For Each link As DevExpress.XtraSankey.Demos.Export In items
                If Me.exportMapArrowPairs.TryGetValue(link, shape) Then shape.Visible = visible
            Next
        End Sub

        Private Sub UpdateSelection(ByVal action As System.Action)
            Me.updateSelectedArrows = False
            action()
            Me.updateSelectedArrows = True
            Me.SetArrowVisibilityByExport(Me.selectedExportItems, True)
            Me.HideAllUnselectedArrows()
        End Sub

        Private Sub SetGridSelectedItems()
            Me.selectedExportItems.Clear()
            Me.gridView1.GetSelectedRows()
            For Each rowIndex As Integer In Me.gridView1.GetSelectedRows()
                Me.selectedExportItems.Add(CType(Me.gridView1.GetRow(rowIndex), DevExpress.XtraSankey.Demos.Export))
            Next
        End Sub

        Private Sub SetSankeySelectedItems()
            Me.selectedExportItems.Clear()
            For Each item In Me.SankeyDiagramControl.SelectedItems
                Dim export = TryCast(item, DevExpress.XtraSankey.Demos.Export)
                If export IsNot Nothing Then Me.selectedExportItems.Add(export)
            Next
        End Sub

        Private Sub SetMapSelectedItems(ByVal mapItems As System.Collections.Generic.IList(Of Object))
            Me.selectedExportItems.Clear()
            For Each mapItem As DevExpress.XtraMap.MapItem In mapItems
                Dim countryName As String = mapItem.Attributes(CStr(("NAME"))).Value.ToString()
                If Not Me.countryNameExportPairs.ContainsKey(countryName) Then countryName = mapItem.Attributes(CStr(("CONTINENT"))).Value.ToString()
                For Each export In Me.countryNameExportPairs(countryName)
                    Me.selectedExportItems.Add(export)
                Next
            Next
        End Sub

        Private Sub OnCustomizeNodeToolTip(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Sankey.CustomizeSankeyNodeToolTipEventArgs)
            Dim text = New System.Text.StringBuilder()
            Dim totalImportAndExportText = New System.Text.StringBuilder()
            If e.Node.InputLinks IsNot Nothing AndAlso e.Node.InputLinks.Count > 0 Then
                totalImportAndExportText.Append(String.Format("Total import: {0} million tonnes", System.Linq.Enumerable.[Select](Of DevExpress.XtraCharts.Sankey.SankeyLink, Global.System.[Double])(e.Node.InputLinks, CType((Function(link) CDbl((link.TotalWeight))), System.Func(Of DevExpress.XtraCharts.Sankey.SankeyLink, System.[Double]))).Sum()))
                totalImportAndExportText.AppendLine()
                text.Append("Import:")
                text.AppendLine()
                For Each inputLink In e.Node.InputLinks
                    text.Append(String.Format("{0} million tonnes from {1}", inputLink.TotalWeight, inputLink.SourceNode.Tag))
                    text.AppendLine()
                Next
            End If

            If text.Length <> 0 Then text.AppendLine()
            If e.Node.OutputLinks IsNot Nothing AndAlso e.Node.OutputLinks.Count > 0 Then
                totalImportAndExportText.Append(String.Format("Total export: {0} million tonnes", System.Linq.Enumerable.[Select](Of DevExpress.XtraCharts.Sankey.SankeyLink, Global.System.[Double])(e.Node.OutputLinks, CType((Function(link) CDbl((link.TotalWeight))), System.Func(Of DevExpress.XtraCharts.Sankey.SankeyLink, System.[Double]))).Sum()))
                totalImportAndExportText.AppendLine()
                text.Append("Export:")
                text.AppendLine()
                For Each outputLink In e.Node.OutputLinks
                    text.Append(String.Format("{0} million tonnes to {1}", outputLink.TotalWeight, outputLink.TargetNode.Tag))
                    text.AppendLine()
                Next
            End If

            If totalImportAndExportText.Length <> 0 Then totalImportAndExportText.AppendLine()
            e.Content = totalImportAndExportText.ToString() & text.ToString().TrimEnd(Global.Microsoft.VisualBasic.Strings.ChrW(10))
        End Sub

        Private Sub OnCustomizeLinkToolTip(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Sankey.CustomizeSankeyLinkToolTipEventArgs)
            e.Content = e.Link.TotalWeight & " million tonnes"
        End Sub

        Private Sub OnSankeyHighlightedItemsChanged(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Sankey.SankeyHighlightedItemsChangedEventArgs)
            Dim highlightedTags = e.HighlightedLinks.[Select](Function(x) CType(x.Tags(0), DevExpress.XtraSankey.Demos.Export))
            Me.HideAllUnselectedArrows()
            Me.SetArrowVisibilityByExport(highlightedTags, True)
        End Sub

        Private Sub OnSankeySelectedItemsChanged(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.Sankey.SankeySelectedItemsChangedEventArgs)
            If Not Me.updateSelectedArrows Then Return
            Me.SetSankeySelectedItems()
            Me.UpdateSelection(Sub()
                Me.gridView1.ClearSelection()
                Me.interactableItemsLayer.SelectedItems.Clear()
                For Each export In Me.selectedExportItems
                    Me.gridView1.SelectRow(Me.gridView1.FindRow(export))
                    Dim mapItem = Me.countryNameMapItemPairs(export.Exporter)
                    If Not Me.interactableItemsLayer.SelectedItems.Contains(mapItem) Then Me.interactableItemsLayer.SelectedItems.Add(mapItem)
                    mapItem = Me.countryNameMapItemPairs(export.Importer)
                    If Not Me.interactableItemsLayer.SelectedItems.Contains(mapItem) Then Me.interactableItemsLayer.SelectedItems.Add(mapItem)
                Next
            End Sub)
        End Sub

        Private Sub OnGridSelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs)
            If Not Me.updateSelectedArrows Then Return
            Me.SetGridSelectedItems()
            Me.UpdateSelection(Sub()
                Me.SankeyDiagramControl.SelectedItems.Clear()
                Me.interactableItemsLayer.SelectedItems.Clear()
                For Each export In Me.selectedExportItems
                    Me.SankeyDiagramControl.SelectedItems.Add(export)
                    Dim mapItem = Me.countryNameMapItemPairs(export.Exporter)
                    If Not Me.interactableItemsLayer.SelectedItems.Contains(mapItem) Then Me.interactableItemsLayer.SelectedItems.Add(mapItem)
                    mapItem = Me.countryNameMapItemPairs(export.Importer)
                    If Not Me.interactableItemsLayer.SelectedItems.Contains(mapItem) Then Me.interactableItemsLayer.SelectedItems.Add(mapItem)
                Next
            End Sub)
        End Sub

        Private Sub OnMapSelectionChanged(ByVal sender As Object, ByVal e As DevExpress.XtraMap.MapSelectionChangedEventArgs)
            If Not Me.updateSelectedArrows Then Return
            Me.SetMapSelectedItems(e.Selection)
            Me.UpdateSelection(Sub()
                Me.gridView1.ClearSelection()
                Me.SankeyDiagramControl.SelectedItems.Clear()
                For Each export In Me.selectedExportItems
                    Me.gridView1.SelectRow(Me.gridView1.FindRow(export))
                    Me.SankeyDiagramControl.SelectedItems.Add(export)
                Next
            End Sub)
        End Sub

        Private Sub mapControl1_Resize(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.mapControl1.ZoomToFitLayerItems(0)
        End Sub

        Private Class CSharpImpl

            <System.Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
