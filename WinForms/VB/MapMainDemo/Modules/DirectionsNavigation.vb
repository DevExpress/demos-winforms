Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports System.Runtime.InteropServices

Namespace DevExpress.XtraMap.Demos

    Public Partial Class DirectionsNavigation
        Inherits FooteredMapTutorialControl

        Private ReadOnly defaultRouteColor As Color = Color.FromArgb(&HFF, &H8A, &HFB, &HFF)

        Public Const DefaultStrokeWidth As Integer = 4

        Private overlayManagerField As MapDemoOverlayManager

        Private routeHelperField As RouteHelper

        Private activeItem As MapItem

        Private stateField As RouteState = RouteState.Normal

        Private enableRotationField As Boolean = True

        Protected Overrides ReadOnly Property Overlays As MapOverlay()
            Get
                Return OverlayManager.GetOverlays()
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightImage As Image
            Get
                Return DemoUtils.AzureLogo
            End Get
        End Property

        Protected Overrides ReadOnly Property CopyrightText As String
            Get
                Return DemoUtils.AzureCopyright
            End Get
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return mapControl1
            End Get
        End Property

        Private ReadOnly Property OverlayManager As MapDemoOverlayManager
            Get
                If overlayManagerField Is Nothing Then overlayManagerField = New MapDemoOverlayManager()
                Return overlayManagerField
            End Get
        End Property

        Protected ReadOnly Property RouteHelper As RouteHelper
            Get
                If routeHelperField Is Nothing Then
                    routeHelperField = New RouteHelper()
                    AddHandler routeHelperField.WayPointsChanged, AddressOf OnWayPointsChanged
                End If

                Return routeHelperField
            End Get
        End Property

        Protected ReadOnly Property RouteLayerItems As MapItemCollection
            Get
                Return RouteLayer.Data.Items
            End Get
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property State As RouteState
            Get
                Return stateField
            End Get

            Set(ByVal value As RouteState)
                If stateField = value Then Return
                stateField = value
                OnRouteStateChanged()
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property EnableRotation As Boolean
            Get
                Return enableRotationField
            End Get

            Set(ByVal value As Boolean)
                enableRotationField = value
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
            PrepareLayerProviders()
            directionIcon.Location = New Point(MapControl.Right - 10 - directionIcon.Width, MapControl.Top + 10)
        End Sub

        Private Sub UpdateInformationText()
            OverlayManager.MessageItem.Text = GetActionText()
        End Sub

        Private Sub SetRouteLayerStyles(ByVal routeLayer As InformationLayer)
            routeLayer.SelectedItemStyle.Stroke = defaultRouteColor
            routeLayer.ItemStyle.Stroke = routeLayer.SelectedItemStyle.Stroke
            routeLayer.SelectedItemStyle.StrokeWidth = DefaultStrokeWidth
            routeLayer.ItemStyle.StrokeWidth = routeLayer.SelectedItemStyle.StrokeWidth
        End Sub

        Private Sub PrepareLayerProviders()
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider)
            DemoUtils.SetAzureMapDataProviderKey(SearchProvider)
            DemoUtils.SetAzureMapDataProviderKey(GeoCodeProvider)
            DemoUtils.SetAzureMapDataProviderKey(RouteProvider)
            SetRouteLayerStyles(RouteLayer)
        End Sub

        Private Sub UpdateDirectionIcon(ByVal angle As Double)
            directionIcon.Angle = CSng(angle)
        End Sub

        Private Sub OnRouteStateChanged()
            Dim isDriving As Boolean = State = RouteState.Drive
            mapControl1.SearchPanelOptions.Visible = Not isDriving
            GeoCodeProvider.ProcessMouseEvents = Not isDriving
            Select Case State
                Case RouteState.Drive
                    RouteHelper.BeginDrive(MapControl, RouteLayer)
                    AddHandler RouteHelper.DriveModel.ActionTextChanged, Sub(s, e) OverlayManager.MessageItem.Text = RouteHelper.DriveModel.ActionText
                    AddHandler RouteHelper.DriveModel.CurrentLocationChanged, Sub(s, e)
                        mapControl1.CenterPoint = RouteHelper.DriveModel.CurrentLocation
                        mapControl1.Angle = If(EnableRotation, RouteHelper.DriveModel.CurrentDirection + 90.0, 0)
                        UpdateDirectionIcon(-mapControl1.Angle)
                    End Sub
                    driveButton.Enabled = False
                    stopButton.Enabled = True
                    clearButton.Enabled = False
                Case RouteState.Normal
                    RouteHelper.StopDrive()
                    driveButton.Enabled = True
                    stopButton.Enabled = False
                    clearButton.Enabled = True
                    mapControl1.Angle = 0
            End Select

            mapControl1.EnableAnimation = driveButton.Enabled
            directionIcon.Visible = stopButton.Enabled
            UpdateInformationText()
        End Sub

        Private Sub OnWayPointsChanged(ByVal sender As Object, ByVal e As EventArgs)
            DataAdapter.DataSource = New List(Of WayPointInfo)(RouteHelper.WaypointInfoList)
            If RouteHelper.WayPoints.Count > 1 Then
                Dim options As AzureRouteOptions = New AzureRouteOptions() With {.InstructionsType = AzureRouteInstructionsType.Text}
                RouteProvider.CalculateRoute(RouteHelper.WayPoints, options)
            Else
                driveButton.Enabled = False
            End If
        End Sub

        Private Sub OnRouteLayerItemsGenerating(ByVal sender As Object, ByVal args As LayerItemsGeneratingEventArgs)
            If args.Error Is Nothing AndAlso Not args.Cancelled Then RouteHelper.ProcessRouteItems(args.Items)
        End Sub

        Private Sub OnRouteCalculated(ByVal sender As Object, ByVal e As AzureRouteCalculatedEventArgs)
            Dim results As List(Of AzureRouteResult) = e.CalculationResult.RouteResults
            Dim routeResult As AzureRouteResult = If(results.Count > 0, results(0), Nothing)
            If RouteHelper.ProcessRouteResult(routeResult) Then
                DataAdapter.DataSource = Nothing
                driveButton.Enabled = True
            End If
        End Sub

        Private Sub OnGeoCodeAndSearchLayerItemsGenerating(ByVal sender As Object, ByVal args As LayerItemsGeneratingEventArgs)
            If stateField = RouteState.Drive Then Return
            For Each item As MapItem In args.Items
                RouteHelper.AddGeneratedPushpin(TryCast(item, MapPushpin))
            Next

            UpdateInformationText()
        End Sub

        Private Sub OnClearButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            RouteHelper.Clear()
            ClearLayerResults()
            RouteLayer.ClearResults()
            SearchProvider.ClearSearchPanel()
            DataAdapter.DataSource = Nothing
            driveButton.Enabled = False
            stopButton.Enabled = False
            UpdateInformationText()
        End Sub

        Private Sub ClearLayerResults()
            SearchLayer.ClearResults()
            GeocodeLayer.ClearResults()
        End Sub

        Private Function CanRemovePin(ByVal pin As MapPushpin, ByVal e As MapItemClickEventArgs) As Boolean
            Return pin IsNot Nothing AndAlso Equals(RouteLayer, pin.Layer) AndAlso e.MouseArgs.Button = MouseButtons.Right AndAlso State <> RouteState.Drive
        End Function

        Private Sub OnMapItemClick(ByVal sender As Object, ByVal e As MapItemClickEventArgs)
            Dim pin As MapPushpin = TryCast(e.Item, MapPushpin)
            If CanRemovePin(pin, e) Then
                activeItem = pin
                popupMenu1.ShowPopup(Cursor.Position)
            End If

            If e.MouseArgs.Button = MouseButtons.Left Then
                If RouteHelper.GeneratedPushpins.Contains(pin) Then
                    AddPointToRoute(pin)
                    e.Handled = True
                End If
            End If

            UpdateInformationText()
        End Sub

        Private Sub AddPointToRoute(ByVal pushpin As MapPushpin)
            RouteHelper.AddWaypoint(pushpin)
            ClearLayerResults()
        End Sub

        Private Sub DeleteWaypoint()
            Dim index As Integer = CalculatePushpinIndex()
            RouteLayerItems.Remove(activeItem)
            RouteHelper.DeleteWaypoint(index)
            ClearRoute()
        End Sub

        Private Sub ClearRoute()
            Dim itemsToRemove As List(Of MapItem) = New List(Of MapItem)()
            For Each item As MapItem In RouteLayerItems
                If TypeOf item Is MapPolyline Then itemsToRemove.Add(item)
            Next

            For Each item As MapItem In itemsToRemove
                RouteLayerItems.Remove(item)
            Next
        End Sub

        Private Function CalculatePushpinIndex() As Integer
            Dim items As MapItemCollection = RouteLayerItems
            Dim index As Integer = -1
            For i As Integer = 0 To items.Count - 1
                If TypeOf items(i) Is MapPushpin Then
                    index += 1
                    If items(i).Equals(activeItem) Then Return index
                End If
            Next

            Return -1
        End Function

        Private Sub OnBarDeleteButtonClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            DeleteWaypoint()
        End Sub

        Private Sub OnBarCloseButtonClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            popupMenu1.HidePopup()
        End Sub

        Private Sub OnDriveButtonClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            State = RouteState.Drive
        End Sub

        Private Sub OnStopButtonClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            State = RouteState.Normal
        End Sub

        Private Sub OnPictureEdit1MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            EnableRotation = Not EnableRotation
        End Sub

        Private Overloads Sub OnDispose()
            If routeHelperField IsNot Nothing Then
                routeHelperField.Dispose()
                routeHelperField = Nothing
            End If

            If overlayManagerField IsNot Nothing Then
                overlayManagerField.Dispose()
                overlayManagerField = Nothing
            End If
        End Sub

        Private Function GetActionText() As String
            If RouteHelper.WayPoints.Count = 0 Then
                If RouteHelper.GeneratedPushpins.Count > 0 Then
                    Return "Click the pushpin to set a start point."
                Else
                    Return "Click the map or use Search to find a location."
                End If
            End If

            If RouteHelper.WayPoints.Count = 1 Then Return "Set a finish point to calculate a route."
            Return "Set another finish point or click Drive."
        End Function

        Protected Overrides Sub DoHide()
            If State = RouteState.Drive Then State = RouteState.Normal
            MyBase.DoHide()
        End Sub
    End Class

    Public Enum RouteState
        Normal
        Drive
    End Enum

    Public Class WayPointInfo

        Public Property Latitude As Double

        Public Property Longitude As Double

        Public Property Text As String

        Public Property ToolTipPattern As String

        Public Property Type As Integer
    End Class

    Public Class RouteHelper
        Implements IDisposable

        Private ReadOnly wayPointsInfoList As List(Of WayPointInfo) = New List(Of WayPointInfo)()

        Private ReadOnly generatedPushpinsField As List(Of MapPushpin) = New List(Of MapPushpin)()

        Private ReadOnly wayPointsField As List(Of RouteWaypoint) = New List(Of RouteWaypoint)()

        Private ReadOnly routeInstructions As List(Of RouteInstruction) = New List(Of RouteInstruction)()

        Private disposed As Boolean = False

        Private routePath As List(Of GeoPoint) = New List(Of GeoPoint)()

        Private waypointIndex As Integer = 0

        Public ReadOnly Property GeneratedPushpins As List(Of MapPushpin)
            Get
                Return generatedPushpinsField
            End Get
        End Property

        Public ReadOnly Property WayPoints As List(Of RouteWaypoint)
            Get
                Return wayPointsField
            End Get
        End Property

        Public ReadOnly Property WaypointInfoList As List(Of WayPointInfo)
            Get
                Return wayPointsInfoList
            End Get
        End Property

        Public Property DriveModel As DriveHelper

        Public Event WayPointsChanged As EventHandler

        Public Sub AddGeneratedPushpin(ByVal pushpin As MapPushpin)
            If pushpin IsNot Nothing AndAlso Not GeneratedPushpins.Contains(pushpin) Then GeneratedPushpins.Add(pushpin)
        End Sub

        Public Sub Clear()
            waypointIndex = 0
            WayPoints.Clear()
            GeneratedPushpins.Clear()
            WaypointInfoList.Clear()
        End Sub

        Public Sub AddWaypoint(ByVal generatedPushpin As MapPushpin)
            Dim pushpinLocation As GeoPoint = CType(generatedPushpin.Location, GeoPoint)
            Dim info As LocationInformation = TryCast(generatedPushpin.Information, LocationInformation)
            Dim description As String = If(info IsNot Nothing, info.DisplayName, String.Empty)
            Dim location As GeoPoint = pushpinLocation
            Dim waypoint As RouteWaypoint = New RouteWaypoint(description, location)
            If wayPointsField.Contains(waypoint) Then Return
            wayPointsField.Add(waypoint)
            Dim pointInfo As WayPointInfo = CreateWayPointInfo(pushpinLocation, Convert.ToString(info))
            WaypointInfoList.Add(pointInfo)
            GeneratedPushpins.Clear()
            RaiseWayPointChanged()
        End Sub

        Private Function CreateWayPointInfo(ByVal location As GeoPoint, ByVal info As String) As WayPointInfo
            Dim pointInfo As WayPointInfo = New WayPointInfo()
            pointInfo.Type = CInt(MapItemType.Pushpin)
            pointInfo.ToolTipPattern = info
            pointInfo.Text = NextWaypointLetter()
            pointInfo.Latitude = location.Latitude
            pointInfo.Longitude = location.Longitude
            Return pointInfo
        End Function

        Private Sub RaiseWayPointChanged()
            RaiseEvent WayPointsChanged(Me, EventArgs.Empty)
        End Sub

        Protected Function NextWaypointLetter() As String
            Dim bA As Byte = Convert.ToByte(Char.Parse("A"))
            Dim letter As String = String.Format("{0}", Convert.ToChar(bA + waypointIndex Mod 26))
            waypointIndex += 1
            Return letter
        End Function

        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If disposed Then Return
            If disposing Then
                If DriveModel IsNot Nothing Then DriveModel.Dispose()
            End If

            disposed = True
        End Sub

        Public Sub ProcessRouteItems(ByVal items As MapItem())
            GeneratedPushpins.Clear()
            WaypointInfoList.Clear()
            waypointIndex = 0
            For Each item As MapItem In items
                Dim pushpin As MapPushpin = TryCast(item, MapPushpin)
                If pushpin IsNot Nothing Then
                    pushpin.Text = NextWaypointLetter()
                End If
            Next
        End Sub

        Public Function ProcessRouteResult(ByVal result As AzureRouteResult) As Boolean
            If result Is Nothing Then Return False
            routePath.Clear()
            routeInstructions.Clear()
            For Each leg As AzureRouteLeg In result.Legs
                routePath.AddRange(leg.Points)
            Next

            For Each instruction As AzureRouteInstruction In result.Guidance.Instructions
                routeInstructions.Add(New RouteInstruction(instruction.Point, instruction.Message))
            Next

            Return True
        End Function

        Public Sub DeleteWaypoint(ByVal index As Integer)
            If index < 0 OrElse index >= WayPoints.Count Then Return
            WayPoints.RemoveAt(index)
            RaiseWayPointChanged()
        End Sub

        Public Sub StopDrive()
            If DriveModel IsNot Nothing Then
                DriveModel.Cleanup()
                DriveModel.Dispose()
                DriveModel = Nothing
            End If
        End Sub

        Public Sub BeginDrive(ByVal map As MapControl, ByVal routeLayer As InformationLayer)
            If routePath IsNot Nothing AndAlso routePath.Count > 1 Then
                StopDrive()
                DriveModel = New DriveHelper(map, routeLayer, routePath, routeInstructions)
            End If
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
    End Class

    Public Class DriveHelper
        Implements IDisposable

        Private Shared ReadOnly driveMarkerField As Bitmap = New Bitmap(DemoUtils.GetRelativePath("\Images\Pin.png"))

        Const DriveSpeed As Double = 100.0

        Const DriveTicksPerSecond As Integer = 100

        Const DriveTimeQuant As Double = 1.0 / DriveTicksPerSecond

        Private ReadOnly DefaultDriveColor As Color = Color.FromArgb(&HFF, &HFE, &H72, &HFF)

        Const DefaultStrokeWidth As Integer = DirectionsNavigation.DefaultStrokeWidth

        Private ReadOnly routeLayerItems As MapItemCollection

        Private ReadOnly routeLayer As InformationLayer

        Private ReadOnly routePath As List(Of GeoPoint)

        Private ReadOnly drivePath As MapPolyline

        Private ReadOnly driveItems As ObservableCollection(Of MapItem)

        Private ReadOnly driveCustomElement As MapCustomElement

        Private ReadOnly animationTimer As Timer

        Private ReadOnly routeInstructions As List(Of RouteInstruction)

        Private baseLocation As GeoPoint = New GeoPoint()

        Private targetLocation As GeoPoint = New GeoPoint()

        Private basePoint As MapUnit

        Private targetPoint As MapUnit

        Private currentDistance As Double

        Private distance As Double

        Private currentPoint As MapUnit

        Private routeNodeIndex As Integer

        Private actionTextField As String

        Private ReadOnly map As MapControl

        Private disposed As Boolean = False

        Private currentDirectionField As Double

        Public ReadOnly Property CurrentLocation As GeoPoint
            Get
                Return CType(map.MapUnitToCoordPoint(currentPoint), GeoPoint)
            End Get
        End Property

        Public ReadOnly Property CurrentDirection As Double
            Get
                Return currentDirectionField
            End Get
        End Property

        Public Property ActionText As String
            Get
                Return actionTextField
            End Get

            Set(ByVal value As String)
                actionTextField = value
                RaiseEvent ActionTextChanged(Me, New PropertyChangedEventArgs("ActionText"))
            End Set
        End Property

        Public ReadOnly Property DriveMarker As Image
            Get
                Return driveMarkerField
            End Get
        End Property

        Public Event CurrentLocationChanged As PropertyChangedEventHandler

        Public Event ActionTextChanged As PropertyChangedEventHandler

        Shared Public Function KilometerPerHourToMapUnitsPerSecond(ByVal kmh As Double) As Double
            Return kmh / 40000.0 / 360.0
        End Function

        Shared Public Function DistanceBetweenPoints(ByVal a As MapUnit, ByVal b As MapUnit) As Double
            Dim vector As MapUnit = New MapUnit(b.X - a.X, b.Y - a.Y)
            Return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y)
        End Function

        Public Sub New(ByVal map As MapControl, ByVal routeLayer As InformationLayer, ByVal routePath As List(Of GeoPoint), ByVal routeInstructions As List(Of RouteInstruction))
            Me.map = map
            Me.routeLayer = routeLayer
            routeLayerItems = routeLayer.Data.Items
            Me.routePath = routePath
            Me.routeInstructions = New List(Of RouteInstruction)(routeInstructions)
            drivePath = New MapPolyline() With {.Stroke = DefaultDriveColor, .StrokeWidth = DefaultStrokeWidth}
            drivePath.Points.Add(targetLocation)
            driveCustomElement = New MapCustomElement() With {.Location = routePath(0), .Visible = True, .Image = DriveMarker, .UseAnimation = False, .BackgroundDrawingMode = ElementState.None}
            animationTimer = New Timer()
            animationTimer.Interval = CInt(DriveTimeQuant * 1000)
            AddHandler animationTimer.Tick, New EventHandler(AddressOf OnTimerTick)
            targetLocation = routePath(0)
            baseLocation = targetLocation
            basePoint = map.CoordPointToMapUnit(baseLocation)
            currentPoint = basePoint
            targetPoint = map.CoordPointToMapUnit(targetLocation)
            currentDistance = 0
            distance = 0
            routeNodeIndex = 0
            driveItems = New ObservableCollection(Of MapItem)()
            driveItems.Add(drivePath)
            driveItems.Add(driveCustomElement)
            routeLayerItems.AddRange(driveItems)
            Advance()
        End Sub

        Private Function Advance() As Boolean
            If routeNodeIndex < routePath.Count - 1 Then
                routeNodeIndex += 1
                baseLocation = targetLocation
                currentPoint = map.CoordPointToMapUnit(baseLocation)
                targetLocation = routePath(routeNodeIndex)
                basePoint = map.CoordPointToMapUnit(baseLocation)
                targetPoint = map.CoordPointToMapUnit(targetLocation)
                distance = DistanceBetweenPoints(targetPoint, basePoint)
                currentDistance = 0
                drivePath.Points(drivePath.Points.Count - 1) = baseLocation
                drivePath.Points.Add(baseLocation)
                CheckItinerary()
                If Not animationTimer.Enabled Then animationTimer.Start()
                Return True
            Else
                If animationTimer.Enabled Then animationTimer.Stop()
                driveCustomElement.Visible = False
                Return False
            End If
        End Function

        Private Sub CheckItinerary()
            Dim location As GeoPoint = CType(map.MapUnitToCoordPoint(currentPoint), GeoPoint)
            Dim currentItem As RouteInstruction = routeInstructions(0)
            Dim geoSize As MapSize = New MapSize(Math.Abs(location.Latitude - currentItem.Location.Latitude), Math.Abs(location.Longitude - currentItem.Location.Longitude))
            Dim metricSize As MapSize = map.CoordToMeasureUnitSize(location, geoSize)
            Dim distance As Double = Math.Sqrt(metricSize.Width * metricSize.Width + metricSize.Height * metricSize.Height)
            If distance < 0.005 Then
                If routeInstructions.Count > 1 Then
                    routeInstructions.Remove(currentItem)
                Else
                    distance = 0.0
                End If
            End If

            If distance > 0.0 Then
                Dim distanceString As String = If(distance > 0.9, String.Format("{0:0} km", Math.Ceiling(distance)), String.Format("{0:0} m", Math.Ceiling(distance * 10) * 100))
                ActionText = $"{routeInstructions(0).Maneuver}
after {distanceString}"
            Else
                ActionText = "Finish! Click Stop and Clear to set a new route."
            End If
        End Sub

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            Dim scaledTime As Double = DriveTimeQuant
            While scaledTime > 0.0
                Dim quant As Double = Math.Min(scaledTime, DriveTimeQuant)
                Dim excess As Double = Update(quant * KilometerPerHourToMapUnitsPerSecond(DriveSpeed))
                If excess > 0.0 Then
                    If Not Advance() Then
                        CheckItinerary()
                        PlaceItems(CType(map.MapUnitToCoordPoint(currentPoint), GeoPoint))
                        Return
                    End If

                    excess = Update(excess)
                End If

                PlaceItems(CType(map.MapUnitToCoordPoint(currentPoint), GeoPoint))
                CheckItinerary()
                scaledTime -= quant
            End While
        End Sub

        Private Function CalculateNavAngle(ByVal direction As Double) As Double
            Dim angle As Double = direction
            Const delta As Double = 2.0
            If Math.Abs(direction - currentDirectionField) > delta Then
                Dim a As Double =(360.0 + direction - currentDirectionField) Mod 360
                angle = currentDirectionField + If(a > 180, -delta, delta)
            End If

            angle = angle Mod 360
            If angle < 0 Then angle += 360
            Return angle
        End Function

        Private Function Update(ByVal distanceToGo As Double) As Double
            currentDistance += distanceToGo
            If currentDistance > distance Then
                currentPoint = targetPoint
                Return currentDistance - distance
            End If

            Dim direction As Double = 0
            Dim offset As MapUnit = GetDirection(direction)
            offset.X *= currentDistance
            offset.Y *= currentDistance
            currentPoint = New MapUnit(basePoint.X + offset.X, basePoint.Y + offset.Y)
            currentDirectionField = CalculateNavAngle(direction)
            Return 0.0
        End Function

        Private Function GetDirection(<Out> ByRef angle As Double) As MapUnit
            Dim direction As MapUnit = New MapUnit(targetPoint.X - basePoint.X, targetPoint.Y - basePoint.Y)
            Dim length As Double = Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y)
            If length > 0.0 Then
                Dim oneByLength As Double = 1 / length
                direction.X *= oneByLength
                direction.Y *= oneByLength
            End If

            angle = Math.Atan2(direction.Y, direction.X) * 180.0 / Math.PI
            If angle < 0.0 Then angle += 360.0
            Return direction
        End Function

        Private Sub PlaceItems(ByVal location As GeoPoint)
            drivePath.Points(drivePath.Points.Count - 1) = location
            driveCustomElement.Location = location
            RaiseEvent CurrentLocationChanged(Me, New PropertyChangedEventArgs("CurrentLocation"))
        End Sub

        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If disposed Then Return
            If disposing Then
                If animationTimer IsNot Nothing Then
                    animationTimer.Stop()
                    RemoveHandler animationTimer.Tick, New EventHandler(AddressOf OnTimerTick)
                    animationTimer.Dispose()
                End If
            End If

            disposed = True
        End Sub

        Public Sub Cleanup()
            If animationTimer.Enabled Then animationTimer.Stop()
            drivePath.Points.Clear()
            driveCustomElement.Visible = False
            For Each item As MapItem In driveItems
                routeLayerItems.Remove(item)
            Next

            driveItems.Clear()
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
    End Class

    Public Class DirectionIcon
        Inherits PictureEdit

        Private angleField As Single

        Private clickTrigger As Boolean

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property Angle As Single
            Get
                Return angleField
            End Get

            Set(ByVal value As Single)
                angleField = value
                Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            Using mat As Matrix = New Matrix()
                mat.RotateAt(Angle - 45, New PointF(Width * 0.5F, Height * 0.5F))
                e.Graphics.Transform = mat
                e.Graphics.Clear(CommonSkins.GetSkin(GetActiveLookAndFeel()).TranslateColor(BackColor))
                MyBase.OnPaint(e)
            End Using
        End Sub

        Protected Overrides Sub OnMouseClick(ByVal e As MouseEventArgs)
            clickTrigger = Not clickTrigger
            BackColor = If(clickTrigger, Color.LightGray, Color.Empty)
            MyBase.OnMouseClick(e)
        End Sub
    End Class

    Public Class RouteInstruction

        Public ReadOnly Property Location As GeoPoint

        Public ReadOnly Property Maneuver As String

        Public Sub New(ByVal location As GeoPoint, ByVal maneuver As String)
            Me.Location = location
            Me.Maneuver = maneuver
        End Sub
    End Class
End Namespace
