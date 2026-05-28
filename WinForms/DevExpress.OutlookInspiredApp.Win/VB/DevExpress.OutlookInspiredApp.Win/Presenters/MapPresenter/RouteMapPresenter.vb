Imports System
Imports System.Collections.Generic
Imports DevExpress.DevAV
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.XtraMap
Imports DevExpress.Map.Dashboard

Namespace DevExpress.DevAV.Presenters

    Public MustInherit Class RouteMapPresenter(Of TEntity As Class, TViewModel As {Class, DevExpress.DevAV.IRouteMapViewModel})
        Inherits DevExpress.DevAV.Presenters.BasePresenter(Of TViewModel)

        Private mapControlCore As DevExpress.XtraMap.MapControl

        Private updateUIActionCore As System.Action(Of TEntity)

        Private updateRouteListActionCore As System.Action(Of System.Collections.Generic.List(Of DevExpress.DevAV.Presenters.RoutePoint))

        Public Sub New(ByVal mapControl As DevExpress.XtraMap.MapControl, ByVal viewModel As TViewModel, ByVal updateUIAction As System.Action(Of TEntity), ByVal updateRouteList As System.Action(Of System.Collections.Generic.List(Of DevExpress.DevAV.Presenters.RoutePoint)))
            MyBase.New(viewModel)
            Me.mapControlCore = mapControl
            Me.updateUIActionCore = updateUIAction
            Me.updateRouteListActionCore = updateRouteList
            If Me.MapControl IsNot Nothing Then
                Me.BindMap()
                Me.SubscribeRouteProviderEvents()
            End If

            Me.SubscribeViewModelEvents()
        End Sub

        Protected Overrides Sub OnDisposing()
            If Me.MapControl IsNot Nothing Then Me.UnsubscribeRouteProviderEvents()
            Me.UnsubscribeViewModelEvents()
            Me.updateUIActionCore = Nothing
            Me.updateRouteListActionCore = Nothing
            Me.mapControlCore = Nothing
            MyBase.OnDisposing()
        End Sub

        Public ReadOnly Property MapControl As MapControl
            Get
                Return Me.mapControlCore
            End Get
        End Property

        Protected ReadOnly Property TilesLayer As ImageLayer
            Get
                Return CType((Me.MapControl.Layers(0)), DevExpress.XtraMap.ImageLayer)
            End Get
        End Property

        Protected ReadOnly Property GeoCodeLayer As InformationLayer
            Get
                Return CType((Me.MapControl.Layers(1)), DevExpress.XtraMap.InformationLayer)
            End Get
        End Property

        Protected ReadOnly Property RouteLayer As InformationLayer
            Get
                Return CType((Me.MapControl.Layers(3)), DevExpress.XtraMap.InformationLayer)
            End Get
        End Property

        Protected ReadOnly Property TilesProvider As AzureMapDataProvider
            Get
                Return CType(Me.TilesLayer.DataProvider, DevExpress.XtraMap.AzureMapDataProvider)
            End Get
        End Property

        Protected ReadOnly Property GeoCodeProvider As AzureGeocodeDataProvider
            Get
                Return CType(Me.GeoCodeLayer.DataProvider, DevExpress.XtraMap.AzureGeocodeDataProvider)
            End Get
        End Property

        Protected ReadOnly Property RouteProvider As AzureRouteDataProvider
            Get
                Return CType(Me.RouteLayer.DataProvider, DevExpress.XtraMap.AzureRouteDataProvider)
            End Get
        End Property

        Private zoomService As DevExpress.Map.Dashboard.IZoomToRegionService

        Private Sub BindMap()
            Me.TilesProvider.AzureKey = DevExpress.DevAV.ViewModels.MapViewModelBase.AzureKey
            Me.RouteProvider.AzureKey = DevExpress.DevAV.ViewModels.MapViewModelBase.AzureKey
            Me.GeoCodeProvider.AzureKey = DevExpress.DevAV.ViewModels.MapViewModelBase.AzureKey
            Me.zoomService = TryCast(CType(Me.MapControl, System.IServiceProvider).GetService(GetType(DevExpress.Map.Dashboard.IZoomToRegionService)), DevExpress.Map.Dashboard.IZoomToRegionService)
        End Sub

        Protected Overridable Sub SubscribeRouteProviderEvents()
            AddHandler Me.GeoCodeProvider.LocationInformationReceived, AddressOf Me.GeoCodeProvider_LocationInformationReceived
            AddHandler Me.RouteProvider.RouteCalculated, AddressOf Me.RouteProvider_RouteCalculated
            AddHandler Me.RouteProvider.LayerItemsGenerating, AddressOf Me.RouteProvider_LayerItemsGenerating
        End Sub

        Protected Overridable Sub SubscribeViewModelEvents()
            AddHandler Me.ViewModel.UpdateRoute, AddressOf Me.ViewModel_UpdateRoute
            AddHandler Me.ViewModel.PointAChanged, AddressOf Me.ViewModel_PointAChanged
            AddHandler Me.ViewModel.PointBChanged, AddressOf Me.ViewModel_PointBChanged
            AddHandler Me.ViewModel.TravelModeChanged, AddressOf Me.ViewModel_TravelModeChanged
        End Sub

        Protected Overridable Sub UnsubscribeRouteProviderEvents()
            RemoveHandler Me.GeoCodeProvider.LocationInformationReceived, AddressOf Me.GeoCodeProvider_LocationInformationReceived
            RemoveHandler Me.RouteProvider.RouteCalculated, AddressOf Me.RouteProvider_RouteCalculated
            RemoveHandler Me.RouteProvider.LayerItemsGenerating, AddressOf Me.RouteProvider_LayerItemsGenerating
        End Sub

        Protected Overridable Sub UnsubscribeViewModelEvents()
            RemoveHandler Me.ViewModel.UpdateRoute, AddressOf Me.ViewModel_UpdateRoute
            RemoveHandler Me.ViewModel.PointAChanged, AddressOf Me.ViewModel_PointAChanged
            RemoveHandler Me.ViewModel.PointBChanged, AddressOf Me.ViewModel_PointBChanged
            RemoveHandler Me.ViewModel.TravelModeChanged, AddressOf Me.ViewModel_TravelModeChanged
        End Sub

        Private Sub ViewModel_UpdateRoute(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.UpdateUI(Me.GetViewModelEntity())
        End Sub

        Protected Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.UpdateUI(Me.GetViewModelEntity())
        End Sub

        Protected MustOverride Function GetViewModelEntity() As TEntity

        Private Sub ViewModel_TravelModeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.UpdateRoute()
        End Sub

        Private Property PointAPin As MapPushpin

        Private Sub ViewModel_PointAChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.PointAPin Is Nothing Then Me.PointAPin = New DevExpress.XtraMap.MapPushpin() With {.Text = "A"}
            Call DevExpress.DevAV.Presenters.RouteMapPresenter(Of TEntity, TViewModel).SetLocation(Me.PointAPin, Me.ViewModel.PointA)
        End Sub

        Private Property PointBPin As MapPushpin

        Private Sub ViewModel_PointBChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            If Me.PointBPin Is Nothing Then Me.PointBPin = New DevExpress.XtraMap.MapPushpin() With {.Text = "B"}
            Call DevExpress.DevAV.Presenters.RouteMapPresenter(Of TEntity, TViewModel).SetLocation(Me.PointBPin, Me.ViewModel.PointB)
        End Sub

        Private Shared Sub SetLocation(ByVal pin As DevExpress.XtraMap.MapPushpin, ByVal address As DevExpress.DevAV.Address)
            Dim p As DevExpress.XtraMap.GeoPoint = address.ToGeoPoint()
            pin.Visible = p IsNot Nothing
            If p IsNot Nothing Then pin.Location = p
        End Sub

        Private Sub RouteProvider_RouteCalculated(ByVal sender As Object, ByVal e As DevExpress.XtraMap.AzureRouteCalculatedEventArgs)
            If e.[Error] IsNot Nothing OrElse e.Cancelled OrElse e.CalculationResult Is Nothing OrElse e.CalculationResult.ResultCode <> DevExpress.XtraMap.RequestResultCode.Success Then Return
            Me.ProcessRouteResult(e.CalculationResult.RouteResults(0))
        End Sub

        Private Sub GeoCodeProvider_LocationInformationReceived(ByVal sender As Object, ByVal e As DevExpress.XtraMap.LocationInformationReceivedEventArgs)
            If e.[Error] IsNot Nothing OrElse e.Cancelled OrElse e.Result Is Nothing OrElse e.Result.ResultCode <> DevExpress.XtraMap.RequestResultCode.Success Then Return
            Dim locations As DevExpress.XtraMap.LocationInformation() = e.Result.Locations
            If locations.Length > 0 Then
                Dim loc As DevExpress.XtraMap.LocationInformation = locations(0)
                Me.ViewModel.PointB = New DevExpress.DevAV.Address() With {.Line = loc.Address.FormattedAddress, .Latitude = loc.Location.Latitude, .Longitude = loc.Location.Longitude}
            End If
        End Sub

        Private Sub RouteProvider_LayerItemsGenerating(ByVal sender As Object, ByVal args As DevExpress.XtraMap.LayerItemsGeneratingEventArgs)
            Dim items = args.Items
            For i As Integer = 0 To items.Length - 1
                Dim pushpin As DevExpress.XtraMap.MapPushpin = TryCast(items(i), DevExpress.XtraMap.MapPushpin)
                If pushpin IsNot Nothing Then pushpin.Visible = False
            Next

            Me.AddRoutePoints()
        End Sub

        Private Sub AddRoutePoints()
            Me.RouteLayer.Data.Items.Clear()
            Me.RouteLayer.Data.Items.Add(Me.PointAPin)
            Me.RouteLayer.Data.Items.Add(Me.PointBPin)
        End Sub

        Private Sub ProcessRouteResult(ByVal routeResult As DevExpress.XtraMap.AzureRouteResult)
            Const metersInMile As Double = 1609.344
            Me.ViewModel.RouteDistance = routeResult.Summary.TravelLengthMeters / metersInMile
            Me.ViewModel.RouteTime = System.TimeSpan.FromSeconds(routeResult.Summary.TravelTimeSeconds)
            Dim routePoints As System.Collections.Generic.List(Of DevExpress.DevAV.Presenters.RoutePoint) = New System.Collections.Generic.List(Of DevExpress.DevAV.Presenters.RoutePoint)()
            For Each instruction As DevExpress.XtraMap.AzureRouteInstruction In routeResult.Guidance.Instructions
                routePoints.Add(New DevExpress.DevAV.Presenters.RoutePoint(instruction))
            Next

            Me.UpdateRouteList(routePoints)
            Me.zoomService.ZoomTo(Me.ViewModel.PointA, Me.ViewModel.PointB)
        End Sub

        Private Sub UpdateRouteList(ByVal routePoints As System.Collections.Generic.List(Of DevExpress.DevAV.Presenters.RoutePoint))
            If Me.updateRouteListActionCore IsNot Nothing Then Me.updateRouteListActionCore(routePoints)
        End Sub

        Private Sub UpdateRoute()
            Dim points As System.Collections.Generic.List(Of DevExpress.XtraMap.RouteWaypoint) = New System.Collections.Generic.List(Of DevExpress.XtraMap.RouteWaypoint)()
            points.Add(New DevExpress.XtraMap.RouteWaypoint("Point A", Me.ViewModel.PointA.ToGeoPoint()))
            points.Add(New DevExpress.XtraMap.RouteWaypoint("Point B", Me.ViewModel.PointB.ToGeoPoint()))
            Dim options As DevExpress.XtraMap.AzureRouteOptions = New DevExpress.XtraMap.AzureRouteOptions() With {.TravelMode = Me.ViewModel.TravelMode, .InstructionsType = DevExpress.XtraMap.AzureRouteInstructionsType.Text}
            Me.RouteProvider.CalculateRoute(points, options)
        End Sub

        Private Sub UpdateUI(ByVal entity As TEntity)
            If entity Is Nothing Then Return
            If Me.updateUIActionCore IsNot Nothing Then Me.updateUIActionCore(entity)
            Me.MapControl.CenterPoint = Me.ViewModel.PointA.ToGeoPoint()
            Me.AddRoutePoints()
            Me.UpdateRoute()
        End Sub
    End Class

    Public NotInheritable Class RoutePoint

        Public ReadOnly Property ManeuverInstruction As String

        Public ReadOnly Property Distance As String

        Public ReadOnly Property Maneuver As AzureRouteGuidanceManeuver

        Public Sub New(ByVal instruction As DevExpress.XtraMap.AzureRouteInstruction)
            Me.ManeuverInstruction = instruction.Message
            Const metersInMile As Double = 1609.344
            Dim distanceMiles As Double = instruction.RouteOffsetMeters / metersInMile
            Me.Distance = If((distanceMiles > 0.9), System.[String].Format("{0:0} mi", System.Math.Ceiling(distanceMiles)), System.[String].Format("{0:0} ft", System.Math.Ceiling(distanceMiles * 52.8) * 100))
            Me.Maneuver = instruction.Maneuver
        End Sub
    End Class
End Namespace
