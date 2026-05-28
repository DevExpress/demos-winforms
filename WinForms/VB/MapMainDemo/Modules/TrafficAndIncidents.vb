Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Map
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraMap.Demos

    Public Partial Class TrafficAndIncidents
        Inherits DevExpress.XtraMap.Demos.FooteredMapTutorialControl

        Private ReadOnly wayPointsInfoList As System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.WayPointInfo) = New System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.WayPointInfo)()

        Private ReadOnly generatedPushpins As System.Collections.Generic.List(Of DevExpress.XtraMap.MapPushpin) = New System.Collections.Generic.List(Of DevExpress.XtraMap.MapPushpin)()

        Private ReadOnly routeWaypoints As System.Collections.Generic.List(Of DevExpress.XtraMap.RouteWaypoint) = New System.Collections.Generic.List(Of DevExpress.XtraMap.RouteWaypoint)()

        Private ReadOnly trafficIncidentTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()

        Private ReadOnly routePropertiesTimer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()

        Private overlayTextItem As DevExpress.XtraMap.MapOverlayTextItem

        Private mapOverlays As DevExpress.XtraMap.MapOverlay()

        Private viewport As DevExpress.Map.MapBounds

        Protected Overrides ReadOnly Property Overlays As DevExpress.XtraMap.MapOverlay()
            Get
                Return Me.mapOverlays
            End Get
        End Property

        Protected ReadOnly Property RouteLayerItems As MapItemCollection
            Get
                Return Me.RouteLayer.Data.Items
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

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return Me.mapControlField
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            Me.InitializeMapOverlay()
            Call DevExpress.XtraMap.Demos.DemoUtils.SetAzureMapDataProviderKey(Me.AzureMapDataProvider)
            Call DevExpress.XtraMap.Demos.DemoUtils.SetAzureMapDataProviderKey(Me.SearchProvider)
            Call DevExpress.XtraMap.Demos.DemoUtils.SetAzureMapDataProviderKey(Me.GeoCodeProvider)
            Call DevExpress.XtraMap.Demos.DemoUtils.SetAzureMapDataProviderKey(Me.RouteProvider)
            Call DevExpress.XtraMap.Demos.DemoUtils.SetAzureMapDataProviderKey(Me.TrafficIncidentProvider)
            Me.DataAdapter.DataSource = New System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.WayPointInfo)(Me.wayPointsInfoList)
            Me.routeWaypoints.Add(New DevExpress.XtraMap.RouteWaypoint("A", New DevExpress.XtraMap.GeoPoint(39.025538, -77.203833)))
            Me.routeWaypoints.Add(New DevExpress.XtraMap.RouteWaypoint("B", New DevExpress.XtraMap.GeoPoint(38.960899, -76.98296)))
            Me.routeWaypoints.Add(New DevExpress.XtraMap.RouteWaypoint("C", New DevExpress.XtraMap.GeoPoint(38.905435, -77.127861)))
            Me.routeWaypoints.Add(New DevExpress.XtraMap.RouteWaypoint("D", New DevExpress.XtraMap.GeoPoint(38.8501856, -76.9276787)))
            Me.trafficIncidentTimer.Interval = 2500
            AddHandler Me.trafficIncidentTimer.Tick, Sub(s, e) Me.UpdateTrafficIncidentData()
            Me.routePropertiesTimer.Interval = 500
            AddHandler Me.routePropertiesTimer.Tick, Sub(s, e) Me.CalculateRoute()
            Me.TravelModeRadioGroup.Properties.Items.AddEnum(GetType(DevExpress.XtraMap.AzureTravelMode))
            Me.TravelModeRadioGroup.SelectedIndex = 2
            Me.RouteAvoidTypesComboBoxEdit.Properties.SetFlags(GetType(DevExpress.XtraMap.AzureRouteAvoidType))
            Me.ChangeComboBoxEditDescriptions(Me.RouteAvoidTypesComboBoxEdit)
            Me.RouteSectionTypesComboBoxEdit.Properties.SetFlags(GetType(DevExpress.XtraMap.AzureRouteSectionType))
            Me.ChangeComboBoxEditDescriptions(Me.RouteSectionTypesComboBoxEdit)
            Me.CalculateRoute()
        End Sub

        Private Sub OnRouteLayerItemsGenerating(ByVal sender As Object, ByVal args As DevExpress.XtraMap.LayerItemsGeneratingEventArgs)
            If args.[Error] Is Nothing AndAlso Not args.Cancelled Then Me.ProcessRouteItems(args.Items)
        End Sub

        Private Sub OnRouteCalculated(ByVal sender As Object, ByVal e As DevExpress.XtraMap.AzureRouteCalculatedEventArgs)
            If e.CalculationResult IsNot Nothing Then Me.DataAdapter.DataSource = Nothing
        End Sub

        Private Sub OnGeoCodeAndSearchLayerItemsGenerating(ByVal sender As Object, ByVal args As DevExpress.XtraMap.LayerItemsGeneratingEventArgs)
            For Each item As DevExpress.XtraMap.MapItem In args.Items
                If TypeOf item Is DevExpress.XtraMap.MapPushpin AndAlso Not Me.generatedPushpins.Contains(CType(item, DevExpress.XtraMap.MapPushpin)) Then Me.generatedPushpins.Add(CType(item, DevExpress.XtraMap.MapPushpin))
            Next
        End Sub

        Private Sub OnMapItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraMap.MapItemClickEventArgs)
            If e.MouseArgs.Button = System.Windows.Forms.MouseButtons.Left Then
                Me.ChoosePushpin(TryCast(e.Item, DevExpress.XtraMap.MapPushpin))
                e.Handled = True
            End If
        End Sub

        Private Sub OnInformationLayerViewportChanged(ByVal sender As Object, ByVal e As DevExpress.XtraMap.ViewportChangedEventArgs)
            Me.viewport = New DevExpress.Map.MapBounds(e.TopLeft, e.BottomRight)
            Me.trafficIncidentTimer.[Stop]()
            Me.trafficIncidentTimer.Start()
        End Sub

        Private Sub OnRouteLayerError(ByVal sender As Object, ByVal e As DevExpress.XtraMap.MapErrorEventArgs)
            Dim message As String = e.Exception.Message
            Const startPattern As String = """message"":"""
            Dim startIndex As Integer = message.IndexOf(startPattern)
            If startIndex < 0 Then Return
            message = message.Substring(startIndex + startPattern.Length)
            message = message.Substring(0, message.IndexOf(""""))
            Me.overlayTextItem.Text = message
            Me.mapOverlays(CInt((0))).Visible = True
        End Sub

        Private Sub ChangeComboBoxEditDescriptions(ByVal boxEdit As DevExpress.XtraEditors.CheckedComboBoxEdit)
            For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In boxEdit.Properties.Items
                Dim description As String = item.Description
                Dim i As Integer = description.Length - 1
                While i > 0
                    If Char.IsUpper(description(i)) Then description = description.Insert(i, " ")
                    Call System.Threading.Interlocked.Decrement(i)
                End While

                item.Description = description
            Next
        End Sub

        Private Sub OnRoutePropertyChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.routePropertiesTimer.[Stop]()
            Me.routePropertiesTimer.Start()
        End Sub

        Private Sub InitializeMapOverlay()
            Dim overlay As DevExpress.XtraMap.MapOverlay = New DevExpress.XtraMap.MapOverlay()
            Me.overlayTextItem = New DevExpress.XtraMap.MapOverlayTextItem() With {.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)}
            Me.overlayTextItem.TextStyle.TextColor = System.Drawing.Color.Red
            overlay = New DevExpress.XtraMap.MapOverlay() With {.Alignment = System.Drawing.ContentAlignment.BottomRight, .Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)}
            overlay.Items.Add(Me.overlayTextItem)
            Me.mapOverlays = New DevExpress.XtraMap.MapOverlay() {overlay}
            Me.mapOverlays(CInt((0))).Visible = False
        End Sub

        Private Sub ChoosePushpin(ByVal generatedPushpin As DevExpress.XtraMap.MapPushpin)
            If Me.generatedPushpins.Contains(generatedPushpin) Then
                Dim pushpinLocation As DevExpress.XtraMap.GeoPoint = CType(generatedPushpin.Location, DevExpress.XtraMap.GeoPoint)
                Dim info As DevExpress.XtraMap.LocationInformation = TryCast(generatedPushpin.Information, DevExpress.XtraMap.LocationInformation)
                Dim description As String = String.Empty
                If info IsNot Nothing Then description = info.DisplayName
                If Me.routeWaypoints.Count = 4 Then Me.routeWaypoints.Clear()
                Dim pinLetter As Char = System.Convert.ToChar(System.Convert.ToInt32("A"c) + Me.routeWaypoints.Count)
                Dim name As String = New String(pinLetter, 1)
                Me.routeWaypoints.Add(New DevExpress.XtraMap.RouteWaypoint(description, pushpinLocation))
                Me.wayPointsInfoList.Add(New DevExpress.XtraMap.Demos.WayPointInfo() With {.Type = CInt(DevExpress.XtraMap.MapItemType.Pushpin), .ToolTipPattern = System.Convert.ToString(info), .Text = name, .Latitude = pushpinLocation.Latitude, .Longitude = pushpinLocation.Longitude})
                Me.generatedPushpins.Clear()
                Me.GeocodeLayer.ClearResults()
                Me.RouteLayer.ClearResults()
                Me.DataAdapter.DataSource = New System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.WayPointInfo)(Me.wayPointsInfoList)
                Me.CalculateRoute()
            End If
        End Sub

        Private Sub CalculateRoute()
            Me.mapOverlays(CInt((0))).Visible = False
            Me.routePropertiesTimer.[Stop]()
            If Me.routeWaypoints.Count = 4 Then
                Dim options As DevExpress.XtraMap.AzureRouteOptions = New DevExpress.XtraMap.AzureRouteOptions() With {.TravelMode = CType(Me.TravelModeRadioGroup.EditValue, DevExpress.XtraMap.AzureTravelMode), .AvoidTypes = CType(Me.RouteAvoidTypesComboBoxEdit.EditValue, DevExpress.XtraMap.AzureRouteAvoidType), .SectionTypes = CType(Me.RouteSectionTypesComboBoxEdit.EditValue, DevExpress.XtraMap.AzureRouteSectionType), .MaxAlternatives = Decimal.ToInt32(CDec(Me.MaxAlternativedSpinEdit.EditValue)), .OptimizeWaypoints = CBool(Me.OptimizeWaypointsCheckEdit.EditValue)}
                Me.RouteProvider.CalculateRoute(Me.routeWaypoints, options)
            End If
        End Sub

        Private Sub ProcessRouteItems(ByVal items As DevExpress.XtraMap.MapItem())
            Me.generatedPushpins.Clear()
            Me.wayPointsInfoList.Clear()
            Dim i As Integer = 0
            For Each item As DevExpress.XtraMap.MapItem In items
                Dim pushpin As DevExpress.XtraMap.MapPushpin = TryCast(item, DevExpress.XtraMap.MapPushpin)
                If pushpin IsNot Nothing Then
                    Dim pinLetter As Char = System.Convert.ToChar(System.Convert.ToInt32("A"c) + System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                    pushpin.Text = New String(pinLetter, 1)
                End If
            Next
        End Sub

        Private Sub UpdateTrafficIncidentData()
            Me.trafficIncidentTimer.[Stop]()
            Me.TrafficIncidentLayer.ClearResults()
            Dim bbox As DevExpress.XtraMap.SearchBoundingBox = New DevExpress.XtraMap.SearchBoundingBox(Me.viewport.Left, Me.viewport.Top, Me.viewport.Right, Me.viewport.Bottom)
            Dim options As DevExpress.XtraMap.AzureTrafficIncidentOptions = New DevExpress.XtraMap.AzureTrafficIncidentOptions()
            Me.TrafficIncidentProvider.RequestTrafficIncidents(bbox, CInt(Me.mapControlField.ZoomLevel), -1, options)
        End Sub

        Protected Overrides Sub InitRibbon()
            MyBase.InitRibbon()
            Me.ChkShowMinimap.Enabled = False
        End Sub
    End Class
End Namespace
