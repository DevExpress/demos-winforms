Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Xml.Linq
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraMap.Demos

    Public Partial Class PhotoGallery
        Inherits DevExpress.XtraMap.Demos.FooteredMapTutorialControl

        Private currentViewType As DevExpress.XtraMap.Demos.ViewType

        Private dataLoaded As Boolean

        Private citiesInfoField As DevExpress.XtraMap.Demos.WorldCitiesInfo

        Private uiControlsField As DevExpress.XtraMap.Demos.UIControls

        Private overlayManagerField As DevExpress.XtraMap.Demos.PhotoGalleryOverlayManager

        Protected Overrides ReadOnly Property Overlays As DevExpress.XtraMap.MapOverlay()
            Get
                Return Me.OverlayManager.GetOverlays()
            End Get
        End Property

        Protected ReadOnly Property OverlayManager As PhotoGalleryOverlayManager
            Get
                If Me.overlayManagerField Is Nothing Then Me.overlayManagerField = New DevExpress.XtraMap.Demos.PhotoGalleryOverlayManager()
                Return Me.overlayManagerField
            End Get
        End Property

        Protected ReadOnly Property UIControls As UIControls
            Get
                If Me.uiControlsField Is Nothing Then Me.uiControlsField = New DevExpress.XtraMap.Demos.UIControls() With {.Gallery = Me.galleryControl1, .Map = Me.mapControl1, .Preview = Me.MiniMap}
                Return Me.uiControlsField
            End Get
        End Property

        Protected ReadOnly Property CitiesInfo As WorldCitiesInfo
            Get
                If Me.citiesInfoField Is Nothing Then Me.citiesInfoField = New DevExpress.XtraMap.Demos.WorldCitiesInfo()
                Return Me.citiesInfoField
            End Get
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return Me.mapControl1
            End Get
        End Property

        Public ReadOnly Property MiniMap As MiniMap
            Get
                Return If(Me.mapControl1 IsNot Nothing, Me.mapControl1.MiniMap, Nothing)
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightImage As Image
            Get
                Return DevExpress.XtraMap.Demos.DemoUtils.AzureLogo
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightText As String
            Get
                Return DevExpress.XtraMap.Demos.DemoUtils.AzureCopyright
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            Me.ViewMap()
            Call DevExpress.XtraMap.Demos.DemoUtils.SetAzureMapDataProviderKey(Me.AzureMapDataProvider)
            Call DevExpress.XtraMap.Demos.DemoUtils.SetAzureMapDataProviderKey(Me.MiniMapDataProvider)
        End Sub

        Private Sub TilesLayer_DataLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraMap.DataLoadedEventArgs)
            RemoveHandler Me.TilesLayer.DataLoaded, AddressOf Me.TilesLayer_DataLoaded
            Me.ListSourceDataAdapter.DataSource = Me.CitiesInfo.Cities
            Me.FillMiniMapData()
        End Sub

        Private Sub FillMiniMapData()
            For Each city As DevExpress.XtraMap.Demos.CityInfo In Me.CitiesInfo.Cities
                Me.MiniMapData.Items.Add(New DevExpress.XtraMap.MapDot() With {.Location = New DevExpress.XtraMap.GeoPoint(city.Latitude, city.Longitude), .Size = 8})
            Next
        End Sub

        Private Sub ItemsLayer_DataLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraMap.DataLoadedEventArgs)
            RemoveHandler Me.ItemsLayer.DataLoaded, AddressOf Me.ItemsLayer_DataLoaded
            Me.StartImagesChanging()
            Me.dataLoaded = True
        End Sub

        Private Sub timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.ChangeImages()
        End Sub

        Private Sub SetChkShowMiniMapState(ByVal enable As Boolean)
            Me.ChkShowMinimap.Enabled = enable
            Me.ChkShowMinimap.Checked = enable
        End Sub

        Private Sub MapControl_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.ResetCityGallery()
            Me.ViewMap()
        End Sub

        Private Sub StartImagesChanging()
            Me.MapControl.ImageList = Me.CitiesInfo.GetImages()
            Me.ChangeImages()
            Me.timer1.Start()
        End Sub

        Private Sub ChangeImages()
            Dim imageListTotalIndex As Integer = 0
            For Each city As DevExpress.XtraMap.Demos.CityInfo In Me.CitiesInfo.Cities
                Dim mapElement As DevExpress.XtraMap.MapCustomElement = CType(Me.ItemsLayer.GetMapItemBySourceObject(city), DevExpress.XtraMap.MapCustomElement)
                If mapElement IsNot Nothing Then mapElement.ImageIndex = imageListTotalIndex + city.CurrentImageIndex
                city.CurrentImageIndex += 1
                imageListTotalIndex += city.Places.Count
            Next
        End Sub

        Private Sub OnMapSelectionChanged(ByVal sender As Object, ByVal e As DevExpress.XtraMap.MapSelectionChangedEventArgs)
            If Me.IsDisposed OrElse e.Selection.Count = 0 Then Return
            Dim city As DevExpress.XtraMap.Demos.CityInfo = TryCast(e.Selection(0), DevExpress.XtraMap.Demos.CityInfo)
            If city Is Nothing Then Return
            Me.ViewCityGallery(city)
        End Sub

        Private Sub ViewMap()
            Me.SetChkShowMiniMapState(True)
            Me.ItemsLayer.SelectedItems.Clear()
            Me.currentViewType = New DevExpress.XtraMap.Demos.MapViewType(Me.UIControls, Me.OverlayManager)
            Me.mapControl1.EnableZooming = Me.mapControl1.EnableZooming And Not Me.ChkLockNavigation.Checked
            Me.mapControl1.EnableScrolling = Me.mapControl1.EnableZooming
            AddHandler Me.mapControl1.SelectionChanged, AddressOf Me.OnMapSelectionChanged
        End Sub

        Private Sub ViewCityGallery(ByVal city As DevExpress.XtraMap.Demos.CityInfo)
            Me.SetChkShowMiniMapState(False)
            RemoveHandler Me.mapControl1.SelectionChanged, AddressOf Me.OnMapSelectionChanged
            AddHandler Me.MapControl.Click, AddressOf Me.MapControl_Click
            Me.currentViewType = New DevExpress.XtraMap.Demos.GalleryViewType(Me.UIControls, city, Me.OverlayManager)
            CType(Me.currentViewType, DevExpress.XtraMap.Demos.GalleryViewType).ApplyGalleryOptions()
        End Sub

        Private Sub ViewPlace(ByVal place As DevExpress.XtraMap.Demos.PlaceInfo)
            Me.currentViewType = New DevExpress.XtraMap.Demos.DetailViewType(Me.UIControls, place, Me.OverlayManager)
            Me.mapControl1.EnableZooming = Me.mapControl1.EnableZooming And Not Me.ChkLockNavigation.Checked
            Me.mapControl1.EnableScrolling = Me.mapControl1.EnableZooming
        End Sub

        Private Sub galleryControlGallery1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs)
            Me.ResetCityGallery()
            Dim place As DevExpress.XtraMap.Demos.PlaceInfo = CType(e.Item.Value, DevExpress.XtraMap.Demos.PlaceInfo)
            Me.ViewPlace(place)
        End Sub

        Private Sub ResetCityGallery()
            RemoveHandler Me.MapControl.Click, AddressOf Me.MapControl_Click
            Me.galleryControl1.Gallery.Groups.Clear()
        End Sub

        Private Sub PerviousPlace()
            Dim activePlace As DevExpress.XtraMap.Demos.PlaceInfo = CType(Me.currentViewType, DevExpress.XtraMap.Demos.DetailViewType).Place
            Dim activeCity As DevExpress.XtraMap.Demos.CityInfo = CType(Me.ItemsLayer.SelectedItem, DevExpress.XtraMap.Demos.CityInfo)
            Me.ViewPlace(activeCity.GetPreviousPlace(activePlace))
        End Sub

        Private Sub NextPlace()
            Dim activePlace As DevExpress.XtraMap.Demos.PlaceInfo = CType(Me.currentViewType, DevExpress.XtraMap.Demos.DetailViewType).Place
            Dim activeCity As DevExpress.XtraMap.Demos.CityInfo = CType(Me.ItemsLayer.SelectedItem, DevExpress.XtraMap.Demos.CityInfo)
            Me.ViewPlace(activeCity.GetNextPlace(activePlace))
        End Sub

        Private Sub lblMapView_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.ViewMap()
        End Sub

        Private Sub mapControl1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
            If e.Button <> System.Windows.Forms.MouseButtons.Left Then Return
            Dim hitInfo As DevExpress.XtraMap.MapHitInfo = Me.MapControl.CalcHitInfo(e.Location)
            Dim clickedItem As DevExpress.XtraMap.MapOverlayItemBase = DevExpress.XtraMap.Demos.OverlayUtils.GetClickedOverlayItem(hitInfo)
            If clickedItem Is Nothing Then Return
            If Me.OverlayManager.BackIconOverlay.Items.Contains(clickedItem) Then
                Me.ViewMap()
            ElseIf clickedItem Is Me.OverlayManager.PlacePrevImage Then
                Me.PerviousPlace()
            ElseIf clickedItem Is Me.OverlayManager.PlaceNextImage Then
                Me.NextPlace()
            End If
        End Sub

        Private Overloads Sub OnDispose()
            If Me.uiControlsField IsNot Nothing Then
                Me.uiControlsField.Dispose()
                Me.uiControlsField = Nothing
            End If

            If Me.overlayManagerField IsNot Nothing Then
                Me.overlayManagerField.Dispose()
                Me.overlayManagerField = Nothing
            End If
        End Sub

        Private Sub PhotoGallery_Load(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.OnStyleChanged()
        End Sub

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            Me.timer1.[Stop]()
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            If Me.dataLoaded Then Me.timer1.Start()
        End Sub

        Protected Overrides Sub OnStyleChanged()
            MyBase.OnStyleChanged()
            Me.OverlayManager.UpdateImages(Me.MapControl.LookAndFeel)
        End Sub

        Protected Overrides Sub RestoreInitialView()
            Me.ViewMap()
            MyBase.RestoreInitialView()
        End Sub
    End Class

    Public Class WorldCitiesInfo

        Private ReadOnly citiesField As System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.CityInfo)

        Private ReadOnly imagesPath As String = DevExpress.XtraMap.Demos.DemoUtils.GetRelativeDirectoryPath("Images\PhotoGallery")

        Public ReadOnly Property Cities As List(Of DevExpress.XtraMap.Demos.CityInfo)
            Get
                Return Me.citiesField
            End Get
        End Property

        Public Sub New()
            Me.citiesField = Me.LoadDataFromXML()
        End Sub

        Private Function LoadDataFromXML() As List(Of DevExpress.XtraMap.Demos.CityInfo)
            Dim cities As System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.CityInfo) = New System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.CityInfo)()
            Dim document As System.Xml.Linq.XDocument = DevExpress.XtraMap.Demos.DemoUtils.LoadXml("CitiesPlacesData.xml")
            If document IsNot Nothing Then
                For Each cityElement As System.Xml.Linq.XElement In document.Element(CType(("Cities"), System.Xml.Linq.XName)).Elements()
                    Dim cityName As String = cityElement.Element(CType(("CityName"), System.Xml.Linq.XName)).Value
                    Dim latitude As Double = System.Convert.ToDouble(cityElement.Element(CType(("Latitude"), System.Xml.Linq.XName)).Value, System.Globalization.CultureInfo.InvariantCulture)
                    Dim longitude As Double = System.Convert.ToDouble(cityElement.Element(CType(("Longitude"), System.Xml.Linq.XName)).Value, System.Globalization.CultureInfo.InvariantCulture)
                    Dim places As System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.PlaceInfo) = New System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.PlaceInfo)()
                    For Each placeElement As System.Xml.Linq.XElement In cityElement.Element(CType(("Places"), System.Xml.Linq.XName)).Elements()
                        Dim name As String = placeElement.Element(CType(("Name"), System.Xml.Linq.XName)).Value
                        Dim placeLat As Double = System.Convert.ToDouble(placeElement.Element(CType(("Latitude"), System.Xml.Linq.XName)).Value, System.Globalization.CultureInfo.InvariantCulture)
                        Dim placeLon As Double = System.Convert.ToDouble(placeElement.Element(CType(("Longitude"), System.Xml.Linq.XName)).Value, System.Globalization.CultureInfo.InvariantCulture)
                        Dim description As String = placeElement.Element(CType(("Description"), System.Xml.Linq.XName)).Value
                        Dim imageUri As String = placeElement.Element(CType(("ImageUri"), System.Xml.Linq.XName)).Value
                        places.Add(New DevExpress.XtraMap.Demos.PlaceInfo() With {.Name = name, .Latitude = placeLat, .Longitude = placeLon, .Description = description, .ImageUri = Me.imagesPath & imageUri, .City = cityName})
                    Next

                    cities.Add(New DevExpress.XtraMap.Demos.CityInfo(places) With {.CityName = cityName, .Latitude = latitude, .Longitude = longitude})
                Next
            End If

            Return cities
        End Function

        Public Function GetImages() As ImageList
            Dim images As System.Windows.Forms.ImageList = New System.Windows.Forms.ImageList() With {.ImageSize = New System.Drawing.Size(110, 82), .ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit}
            For Each city As DevExpress.XtraMap.Demos.CityInfo In Me.citiesField
                For Each place As DevExpress.XtraMap.Demos.PlaceInfo In city.Places
                    images.Images.Add(DevExpress.XtraMap.Demos.DemoUtils.GetInflatedImage(place.ImageUri, 14, 12))
                Next
            Next

            Return images
        End Function
    End Class

    Public Class CityInfo

        Private ReadOnly placesField As System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.PlaceInfo)

        Private currentImageIndexField As Integer = 0

        Public Property CityName As String

        Public Property Latitude As Double

        Public Property Longitude As Double

        Public ReadOnly Property Places As List(Of DevExpress.XtraMap.Demos.PlaceInfo)
            Get
                Return Me.placesField
            End Get
        End Property

        Public Property CurrentImageIndex As Integer
            Get
                Return Me.currentImageIndexField
            End Get

            Set(ByVal value As Integer)
                If value < 0 OrElse value >= Me.Places.Count Then value = 0
                Me.currentImageIndexField = value
            End Set
        End Property

        Public Sub New(ByVal places As System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.PlaceInfo))
            Me.placesField = places
        End Sub

        Public Function GetNextPlace(ByVal place As DevExpress.XtraMap.Demos.PlaceInfo) As PlaceInfo
            Dim index As Integer = Me.Places.FindIndex(Function(p) Equals(place.Name, p.Name))
            index = If(index <> Me.Places.Count - 1, index + 1, 0)
            Return Me.Places(index)
        End Function

        Public Function GetPreviousPlace(ByVal place As DevExpress.XtraMap.Demos.PlaceInfo) As PlaceInfo
            Dim index As Integer = Me.Places.FindIndex(Function(p) Equals(place.Name, p.Name))
            index = If(index <> 0, index - 1, Me.Places.Count - 1)
            Return Me.Places(index)
        End Function
    End Class

    Public Class PlaceInfo

        Public Property Name As String

        Public Property Latitude As Double

        Public Property Longitude As Double

        Public Property Description As String

        Public Property ImageUri As String

        Public Property City As String
    End Class

    Public Class UIControls
        Implements System.IDisposable

        Public Property Map As MapControl

        Public Property Preview As MiniMap

        Public Property Gallery As GalleryControl

        Public Property InfoPanel As PanelControl

        Public Property City As LabelControl

        Public Property Place As LabelControl

        Public Property Description As LabelControl

        Public Property ImageBox As PictureEdit

#Region "IDisposable implementation"
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.Map IsNot Nothing Then
                    Me.Map.Dispose()
                    Me.Map = Nothing
                End If

                If Me.Preview IsNot Nothing Then
                    Me.Preview.Dispose()
                    Me.Preview = Nothing
                End If

                If Me.Gallery IsNot Nothing Then
                    Me.Gallery.Dispose()
                    Me.Gallery = Nothing
                End If

                If Me.InfoPanel IsNot Nothing Then
                    Me.InfoPanel.Dispose()
                    Me.InfoPanel = Nothing
                End If

                If Me.City IsNot Nothing Then
                    Me.City.Dispose()
                    Me.City = Nothing
                End If

                If Me.Place IsNot Nothing Then
                    Me.Place.Dispose()
                    Me.Place = Nothing
                End If

                If Me.Description IsNot Nothing Then
                    Me.Description.Dispose()
                    Me.Description = Nothing
                End If

                If Me.ImageBox IsNot Nothing Then
                    Me.ImageBox.Dispose()
                    Me.ImageBox = Nothing
                End If
            End If
        End Sub

        Public Sub Dispose() Implements Global.System.IDisposable.Dispose
            Me.Dispose(True)
            System.GC.SuppressFinalize(Me)
        End Sub

        Protected Overrides Sub Finalize()
            Me.Dispose(False)
        End Sub
#End Region
    End Class

    Public MustInherit Class ViewType

        Private ReadOnly overlayManagerField As DevExpress.XtraMap.Demos.PhotoGalleryOverlayManager

        Private ReadOnly uiControlsField As DevExpress.XtraMap.Demos.UIControls

        Protected ReadOnly Property OverlayManager As PhotoGalleryOverlayManager
            Get
                Return Me.overlayManagerField
            End Get
        End Property

        Protected ReadOnly Property UIControls As UIControls
            Get
                Return Me.uiControlsField
            End Get
        End Property

        Protected ReadOnly Property Map As MapControl
            Get
                Return Me.UIControls.Map
            End Get
        End Property

        Protected ReadOnly Property Gallery As GalleryControl
            Get
                Return Me.UIControls.Gallery
            End Get
        End Property

        Protected ReadOnly Property ItemsLayer As VectorItemsLayer
            Get
                Return CType(Me.Map.Layers("ItemsLayer"), DevExpress.XtraMap.VectorItemsLayer)
            End Get
        End Property

        Protected ReadOnly Property PushpinLayer As VectorItemsLayer
            Get
                Return CType(Me.Map.Layers("PushpinLayer"), DevExpress.XtraMap.VectorItemsLayer)
            End Get
        End Property

        Protected MustOverride ReadOnly Property MaxZoomLevel As Double

        Protected MustOverride ReadOnly Property MinZoomLevel As Double

        Protected MustOverride ReadOnly Property MapViewItemsVisible As Boolean

        Protected MustOverride ReadOnly Property GalleryViewItemsVisible As Boolean

        Protected MustOverride ReadOnly Property DetailViewItemsVisible As Boolean

        Protected Sub New(ByVal controls As DevExpress.XtraMap.Demos.UIControls, ByVal overlayManager As DevExpress.XtraMap.Demos.PhotoGalleryOverlayManager)
            Me.overlayManagerField = overlayManager
            Me.uiControlsField = controls
            Me.ApplyOptions()
        End Sub

        Private Sub Gallery_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
            RemoveHandler Me.Gallery.Paint, AddressOf Me.Gallery_Paint
            DevExpress.XtraMap.Demos.OverlapFlickeringSolver.Refresh(Me.Map.FindForm())
        End Sub

        Protected Overridable Sub ApplyOptions()
            Me.SetMinMaxZoomLevel()
            Me.Map.EnableScrolling = Not Me.GalleryViewItemsVisible
            Me.Map.EnableZooming = Not Me.GalleryViewItemsVisible
            Me.ItemsLayer.Visible = Me.MapViewItemsVisible
            Me.PushpinLayer.Visible = Me.DetailViewItemsVisible
            If Me.GalleryViewItemsVisible Then AddHandler Me.Gallery.Paint, AddressOf Me.Gallery_Paint
            Me.Gallery.Visible = Me.GalleryViewItemsVisible
            If Me.uiControlsField.Preview IsNot Nothing Then Me.uiControlsField.Preview.Visible = Me.MapViewItemsVisible
            Me.overlayManagerField.BackIconOverlay.Visible = Me.DetailViewItemsVisible
            Me.overlayManagerField.PlaceOverlay.Visible = Me.DetailViewItemsVisible
            Me.overlayManagerField.NavigationOverlay.Visible = Me.DetailViewItemsVisible
            Me.overlayManagerField.DescriptionOverlay.Visible = Me.DetailViewItemsVisible
        End Sub

        Private Sub SetMinMaxZoomLevel()
            If Me.Map.MaxZoomLevel < Me.MinZoomLevel Then
                Me.Map.MaxZoomLevel = Me.MaxZoomLevel
                Me.Map.MinZoomLevel = Me.MinZoomLevel
            Else
                Me.Map.MinZoomLevel = Me.MinZoomLevel
                Me.Map.MaxZoomLevel = Me.MaxZoomLevel
            End If
        End Sub
    End Class

    Public Class MapViewType
        Inherits DevExpress.XtraMap.Demos.ViewType

        Const MaxZoom As Integer = 7

        Const MinZoom As Integer = 5

        Protected Overrides ReadOnly Property MaxZoomLevel As Double
            Get
                Return DevExpress.XtraMap.Demos.MapViewType.MaxZoom
            End Get
        End Property

        Protected Overrides ReadOnly Property MinZoomLevel As Double
            Get
                Return DevExpress.XtraMap.Demos.MapViewType.MinZoom
            End Get
        End Property

        Protected Overrides ReadOnly Property MapViewItemsVisible As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property GalleryViewItemsVisible As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property DetailViewItemsVisible As Boolean
            Get
                Return False
            End Get
        End Property

        Public Sub New(ByVal controls As DevExpress.XtraMap.Demos.UIControls, ByVal overlayManager As DevExpress.XtraMap.Demos.PhotoGalleryOverlayManager)
            MyBase.New(controls, overlayManager)
        End Sub

        Protected Overrides Sub ApplyOptions()
            MyBase.ApplyOptions()
            Me.Map.ZoomLevel = Me.MinZoomLevel
        End Sub
    End Class

    Public Class GalleryViewType
        Inherits DevExpress.XtraMap.Demos.ViewType

        Const MaxZoom As Integer = 7

        Const MinZoom As Integer = 5

        Private ReadOnly cityField As DevExpress.XtraMap.Demos.CityInfo

        Protected Overrides ReadOnly Property MaxZoomLevel As Double
            Get
                Return DevExpress.XtraMap.Demos.GalleryViewType.MaxZoom
            End Get
        End Property

        Protected Overrides ReadOnly Property MinZoomLevel As Double
            Get
                Return DevExpress.XtraMap.Demos.GalleryViewType.MinZoom
            End Get
        End Property

        Protected Overrides ReadOnly Property MapViewItemsVisible As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property GalleryViewItemsVisible As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides ReadOnly Property DetailViewItemsVisible As Boolean
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property City As CityInfo
            Get
                Return Me.cityField
            End Get
        End Property

        Public Sub New(ByVal controls As DevExpress.XtraMap.Demos.UIControls, ByVal city As DevExpress.XtraMap.Demos.CityInfo, ByVal overlayManager As DevExpress.XtraMap.Demos.PhotoGalleryOverlayManager)
            MyBase.New(controls, overlayManager)
            Me.cityField = city
        End Sub

        Public Sub ApplyGalleryOptions()
            Dim galleryGroup As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup() With {.Caption = Me.cityField.CityName, .CaptionAlignment = DevExpress.XtraBars.Ribbon.GalleryItemGroupCaptionAlignment.Center}
            For Each place As DevExpress.XtraMap.Demos.PlaceInfo In Me.cityField.Places
                Dim item As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem(System.Drawing.Image.FromFile(place.ImageUri), place.Name, "")
                item.Value = place
                galleryGroup.Items.Add(item)
            Next

            Me.Gallery.Gallery.Groups.Add(galleryGroup)
            Dim galleryPos As System.Drawing.Point = New System.Drawing.Point(Me.Map.Width \ 2 - Me.Gallery.Width \ 2, Me.Map.Height \ 2 - Me.Gallery.Height \ 2)
            Me.Gallery.Location = galleryPos
            Dim img As System.Drawing.Image = DevExpress.XtraMap.Demos.DemoUtils.GetBackGroundImage(Me.Map, New System.Drawing.Rectangle(galleryPos, Me.Gallery.Size), 0.5F)
            If img IsNot Nothing Then Me.Gallery.Gallery.BackgroundImage = img
        End Sub
    End Class

    Public Class DetailViewType
        Inherits DevExpress.XtraMap.Demos.ViewType

        Const MaxZoom As Integer = 18

        Const MinZoom As Integer = 15

        Private ReadOnly placeField As DevExpress.XtraMap.Demos.PlaceInfo

        Private ReadOnly Property Pushpin As MapPushpin
            Get
                Return CType((CType((Me.PushpinLayer).Data, DevExpress.XtraMap.MapItemStorage).Items(0)), DevExpress.XtraMap.MapPushpin)
            End Get
        End Property

        Private ReadOnly Property LabelCity As LabelControl
            Get
                Return Me.UIControls.City
            End Get
        End Property

        Private ReadOnly Property LabelPlace As LabelControl
            Get
                Return Me.UIControls.Place
            End Get
        End Property

        Private ReadOnly Property LabelDescription As LabelControl
            Get
                Return Me.UIControls.Description
            End Get
        End Property

        Private ReadOnly Property ImageBox As PictureEdit
            Get
                Return Me.UIControls.ImageBox
            End Get
        End Property

        Protected Overrides ReadOnly Property MaxZoomLevel As Double
            Get
                Return DevExpress.XtraMap.Demos.DetailViewType.MaxZoom
            End Get
        End Property

        Protected Overrides ReadOnly Property MinZoomLevel As Double
            Get
                Return DevExpress.XtraMap.Demos.DetailViewType.MinZoom
            End Get
        End Property

        Protected Overrides ReadOnly Property MapViewItemsVisible As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property GalleryViewItemsVisible As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides ReadOnly Property DetailViewItemsVisible As Boolean
            Get
                Return True
            End Get
        End Property

        Public ReadOnly Property Place As PlaceInfo
            Get
                Return Me.placeField
            End Get
        End Property

        Public Sub New(ByVal controls As DevExpress.XtraMap.Demos.UIControls, ByVal place As DevExpress.XtraMap.Demos.PlaceInfo, ByVal overlayManager As DevExpress.XtraMap.Demos.PhotoGalleryOverlayManager)
            MyBase.New(controls, overlayManager)
            Me.placeField = place
            Me.ApplyPlaceOptions()
        End Sub

        Private Sub ApplyPlaceOptions()
            Me.Map.CenterPoint = New DevExpress.XtraMap.GeoPoint(Me.placeField.Latitude, Me.placeField.Longitude)
            Me.Pushpin.Location = Me.Map.CenterPoint
            Me.OverlayManager.PlaceImage.Image = System.Drawing.Image.FromFile(Me.placeField.ImageUri)
            Me.OverlayManager.CityName.Text = Me.placeField.City
            Me.OverlayManager.PlaceName.Text = Me.placeField.Name
            Me.OverlayManager.PlaceDescription.Text = Me.placeField.Description
        End Sub
    End Class
End Namespace
