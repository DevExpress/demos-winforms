Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraMap.Demos

    Public Partial Class CoordinateSystems
        Inherits DevExpress.XtraMap.Demos.FooteredMapTutorialControl

        Const HotelsCount As Integer = 3

        Private overlayManagerField As DevExpress.XtraMap.Demos.HotelPlansOverlayManager

        Private ReadOnly tooltipHelper As DevExpress.XtraMap.Demos.HotelRoomTooltipHelper = New DevExpress.XtraMap.Demos.HotelRoomTooltipHelper()

        Private geoMapActivated As Boolean = True

        Private ReadOnly Property OverlayManager As HotelPlansOverlayManager
            Get
                If Me.overlayManagerField Is Nothing Then Me.overlayManagerField = New DevExpress.XtraMap.Demos.HotelPlansOverlayManager()
                Return Me.overlayManagerField
            End Get
        End Property

        Protected Overrides ReadOnly Property Overlays As DevExpress.XtraMap.MapOverlay()
            Get
                Return If(Me.geoMapActivated, MyBase.Overlays, Me.OverlayManager.GetOverlays())
            End Get
        End Property

        Protected Overrides ReadOnly Property MiniMapAlignment As MiniMapAlignment
            Get
                Return DevExpress.XtraMap.MiniMapAlignment.TopLeft
            End Get
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return Me.mapControl1
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightImage As Image
            Get
                Return If(Me.geoMapActivated, DevExpress.XtraMap.Demos.DemoUtils.AzureLogo, Nothing)
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightText As String
            Get
                Return If(Me.geoMapActivated, DevExpress.XtraMap.Demos.DemoUtils.AzureCopyright, String.Empty)
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            Me.PrepareMap()
        End Sub

        Private Sub PrepareMap()
            Call DevExpress.XtraMap.Demos.DemoUtils.SetAzureMapDataProviderKey(Me.AzureImageryMapDataProvider)
            Call DevExpress.XtraMap.Demos.DemoUtils.SetAzureMapDataProviderKey(Me.AzureLabelsMapDataProvider)
            Me.PopulateItemStorage()
        End Sub

        Private Sub PopulateItemStorage()
            Me.HotelsItemStorage.Items.Clear()
            Me.HotelsItemStorage.Items.Add(Me.CreateHotel(New DevExpress.XtraMap.GeoPoint(-21.1434, -175.154), "Geek Island Resort", "Hotel1", 0))
            Me.HotelsItemStorage.Items.Add(Me.CreateHotel(New DevExpress.XtraMap.GeoPoint(-21.1936528, -175.1552), "Nerd Hotel Tonga", "Hotel2", 1))
            Me.HotelsItemStorage.Items.Add(Me.CreateHotel(New DevExpress.XtraMap.GeoPoint(-21.1658, -175.1134), "The IT Paradise Hotel", "Hotel3", 2))
        End Sub

        Private Function CreateHotel(ByVal location As DevExpress.XtraMap.GeoPoint, ByVal name As String, ByVal path As String, ByVal index As Integer) As MapItem
            Dim hotel As DevExpress.XtraMap.MapCustomElement = New DevExpress.XtraMap.MapCustomElement() With {.Location = location, .Text = name, .ImageIndex = index, .TextAlignment = DevExpress.XtraMap.TextAlignment.TopCenter}
            hotel.Attributes.Add(New DevExpress.XtraMap.MapItemAttribute() With {.Name = "path", .Value = path, .Type = GetType(String)})
            hotel.Attributes.Add(New DevExpress.XtraMap.MapItemAttribute() With {.Name = "index", .Value = index, .Type = GetType(Integer)})
            Return hotel
        End Function

        Private Sub ResetOverlays()
            Me.MapControl.Overlays.Clear()
            Me.MapControl.Overlays.AddRange(Me.Overlays)
        End Sub

        Private Sub ActivateCartesianMap(ByVal item As DevExpress.XtraMap.MapItem)
            Me.geoMapActivated = False
            Me.ChangeMiniMapState(False)
            Me.MapControl.CoordinateSystem = New DevExpress.XtraMap.CartesianMapCoordinateSystem()
            Dim data As DevExpress.XtraMap.ShapefileDataAdapter = New DevExpress.XtraMap.ShapefileDataAdapter() With {.SourceCoordinateSystem = New DevExpress.XtraMap.CartesianSourceCoordinateSystem(), .FileUri = Me.GetFileUri(item)}
            Me.tooltipHelper.UpdateHotelIndex(CInt(item.Attributes(CStr(("index"))).Value))
            Me.HotelPlanLayer.Data = data
            Me.OverlayManager.HotelName.Text = CType(item, DevExpress.XtraMap.MapCustomElement).Text
            Me.SetElementsVisibility(False)
            RemoveHandler Me.MapControl.MapItemClick, AddressOf Me.mapControl1_MapItemClick
            RemoveHandler Me.MapControl.DrawMapItem, AddressOf Me.mapControl1_DrawMapItem
            AddHandler Me.MapControl.MouseUp, AddressOf Me.mapControl1_MouseUp
            Me.ResetOverlays()
            Me.UpdateCopyrights()
        End Sub

        Private Sub ActivateGeoMap()
            Me.geoMapActivated = True
            Me.ChangeMiniMapState(True)
            Me.MapControl.CoordinateSystem = New DevExpress.XtraMap.GeoMapCoordinateSystem()
            Me.HotelsLayer.SelectedItems.Clear()
            Me.SetElementsVisibility(True)
            Me.ResetMinMaxZoomLevel()
            Me.ZoomToFitMap(0.5)
            Me.SetMinMaxZoomLevel()
            AddHandler Me.MapControl.MapItemClick, AddressOf Me.mapControl1_MapItemClick
            AddHandler Me.MapControl.DrawMapItem, AddressOf Me.mapControl1_DrawMapItem
            RemoveHandler Me.MapControl.MouseUp, AddressOf Me.mapControl1_MouseUp
            Me.ResetOverlays()
            Me.UpdateCopyrights()
        End Sub

        Private Sub ZoomToFitMap(ByVal paddingFactor As Double)
            Dim scrolingEnabled As Boolean = Me.MapControl.EnableScrolling
            Dim zoomingEnabled As Boolean = Me.MapControl.EnableZooming
            Me.MapControl.EnableZooming = True
            Me.MapControl.EnableScrolling = Me.MapControl.EnableZooming
            Me.MapControl.ZoomToFitLayerItems(paddingFactor)
            Me.MapControl.EnableScrolling = scrolingEnabled
            Me.MapControl.EnableZooming = zoomingEnabled
        End Sub

        Private Sub ChangeMiniMapState(ByVal isEnable As Boolean)
            Me.ChkShowMinimap.Enabled = isEnable
            If Me.MapControl.MiniMap IsNot Nothing Then Me.MapControl.MiniMap.Visible = isEnable
        End Sub

        Private Sub ResetMinMaxZoomLevel()
            Me.MapControl.MinZoomLevel = 1
            Me.MapControl.MaxZoomLevel = 20
        End Sub

        Private Sub SetMinMaxZoomLevel()
            Me.MapControl.MinZoomLevel = Me.MapControl.ZoomLevel
            Me.MapControl.MaxZoomLevel = Me.MapControl.MinZoomLevel + 2
        End Sub

        Private Sub SetElementsVisibility(ByVal isGeoMap As Boolean)
            Me.HotelPlanLayer.Visible = Not isGeoMap
            Me.HotelsLayer.Visible = isGeoMap
            Me.TilesLayer.Visible = isGeoMap
        End Sub

        Private Function GetFileUri(ByVal item As DevExpress.XtraMap.MapItem) As Uri
            Dim hotel As String = item.Attributes(CStr(("path"))).Value.ToString()
            Return DevExpress.XtraMap.Demos.DemoUtils.GetFileUri(String.Format("Hotels\{0}.shp", hotel))
        End Function

        Private Sub HotelPlanLayer_DataLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraMap.DataLoadedEventArgs)
            Me.ResetMinMaxZoomLevel()
            Me.ZoomToFitMap(0.3)
            Me.SetMinMaxZoomLevel()
        End Sub

        Private Sub mapControl1_MapItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraMap.MapItemClickEventArgs)
            Me.ActivateCartesianMap(e.Item)
        End Sub

        Private Sub mapControl1_DrawMapItem(ByVal sender As Object, ByVal e As DevExpress.XtraMap.DrawMapItemEventArgs)
            Dim el As DevExpress.XtraMap.MapCustomElement = CType(e.Item, DevExpress.XtraMap.MapCustomElement)
            If e.IsHighlighted AndAlso (el.ImageIndex < DevExpress.XtraMap.Demos.CoordinateSystems.HotelsCount) Then el.ImageIndex += DevExpress.XtraMap.Demos.CoordinateSystems.HotelsCount
            If Not e.IsHighlighted AndAlso (el.ImageIndex >= DevExpress.XtraMap.Demos.CoordinateSystems.HotelsCount) Then el.ImageIndex -= DevExpress.XtraMap.Demos.CoordinateSystems.HotelsCount
        End Sub

        Private Sub mapControl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If e.Button <> System.Windows.Forms.MouseButtons.Left Then Return
            Dim hitInfo As DevExpress.XtraMap.MapHitInfo = Me.MapControl.CalcHitInfo(e.Location)
            Dim clickedItem As DevExpress.XtraMap.MapOverlayItemBase = DevExpress.XtraMap.Demos.OverlayUtils.GetClickedOverlayItem(hitInfo)
            If clickedItem Is Nothing Then Return
            If clickedItem Is Me.OverlayManager.BackImage Then Me.ActivateGeoMap()
        End Sub

        Private Sub toolTipController1_BeforeShow(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerShowEventArgs)
            e.SuperTip = Me.tooltipHelper.CalculateSuperTooltip(TryCast(e.SelectedObject, DevExpress.XtraMap.MapItem), e.ToolTip)
        End Sub

        Private Overloads Sub OnDispose()
            If Me.overlayManagerField IsNot Nothing Then
                Me.overlayManagerField.Dispose()
                Me.overlayManagerField = Nothing
            End If
        End Sub

        Protected Overrides Sub RestoreInitialView()
            Me.ActivateGeoMap()
            MyBase.RestoreInitialView()
        End Sub
    End Class
End Namespace
