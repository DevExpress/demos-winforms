Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Data.Utils
Imports DevExpress.Map
Imports DevExpress.Utils.Design
Imports DevExpress.Utils.DPI
Imports DevExpress.Utils.Svg

Namespace DevExpress.XtraMap.Demos

    Public Partial Class MapElements
        Inherits FooteredMapTutorialControl

        Private dataGenerator As FlightMapDataGenerator

        Private mapInfoPanel As MapInfoPanel

        Private firstLoad As Boolean = True

        Private ReadOnly overlayManager As MapElementsOverlayManager

        Protected Overrides ReadOnly Property Overlays As MapOverlay()
            Get
                Return overlayManager.GetOverlays()
            End Get
        End Property

        Protected Overrides ReadOnly Property MiniMapAzureKind As AzureTileset
            Get
                Return AzureTileset.BaseRoad
            End Get
        End Property

        Protected Overrides ReadOnly Property MiniMapAlignment As MiniMapAlignment
            Get
                Return MiniMapAlignment.TopLeft
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

        Public Sub New()
            InitializeComponent()
            overlayManager = New MapElementsOverlayManager(MapControl)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider)
            MapControl.SetMapItemFactory(New FlightMapFactory(ScaleDPI))
            mapInfoPanel = New MapInfoPanel(ScaleDPI, overlayManager)
            dataGenerator = New FlightMapDataGenerator()
            AddHandler dataGenerator.DataChanged, AddressOf OnDataChanged
            PlanesDataAdapter.DataSource = dataGenerator.Planes
            PathsDataAdapter.DataSource = dataGenerator.AirPaths
            AirportsDataAdapter.DataSource = dataGenerator.Airports
        End Sub

        Private Sub OnDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not PlanesLayer.Visible Then Return
            MapControl.SuspendRender()
            For Each item As MapItem In PlanesLayer.Data.Items
                Dim info As PlaneInfo = TryCast(item.Tag, PlaneInfo)
                Dim pin As MapPushpin = TryCast(item, MapPushpin)
                If pin IsNot Nothing AndAlso info IsNot Nothing Then
                    pin.Location = New GeoPoint(info.Latitude, info.Longitude)
                    pin.Angle = info.Course
                    pin.Visible = Not info.IsLanded
                End If
            Next

            MapControl.ResumeRender()
            mapInfoPanel.Update()
        End Sub

        Private Sub AirportsLayer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            Dim current As AirportInfo = dataGenerator.Airports.Find(Function(a) Equals(a.IATA, "FRA"))
            AirportsLayer.SelectedItem = current
            dataGenerator.Start()
            firstLoad = False
        End Sub

        Private Sub OnMapSelectionChanged(ByVal sender As Object, ByVal e As MapSelectionChangedEventArgs)
            Dim info As ItemInfoBase = TryCast(e.Selection.FirstOrDefault(), ItemInfoBase)
            mapInfoPanel.SetCurrentInfo(info, MapControl)
            ShowRoutes(TryCast(info, AirportInfo))
            OnActivePlaneChanged(TryCast(info, PlaneInfo))
        End Sub

        Private Sub OnPlanesVisibilityCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            PlanesLayer.Visible = ShowPlanesCheckItem.Checked
            PlanesLayer.SelectedItems.Clear()
        End Sub

        Private Sub OnMapControlMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            dataGenerator.Start()
        End Sub

        Private Sub OnMapControlMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            dataGenerator.Stop()
        End Sub

        Private Sub ShowRoutes(ByVal info As AirportInfo)
            RoutesStorage.Items.Clear()
            If info IsNot Nothing Then
                RoutesStorage.Items.BeginUpdate()
                Dim res As List(Of RouteInfo) = dataGenerator.Routes.FindAll(Function(r) Equals(r.Src, info.IATA))
                For Each item As RouteInfo In res
                    Dim ap As AirportInfo = dataGenerator.Airports.Find(Function(a) a.IATA.Equals(item.Dst))
                    If ap IsNot Nothing Then
                        RoutesStorage.Items.Add(New MapLine() With {.Point1 = New GeoPoint(info.Latitude, info.Longitude), .Point2 = New GeoPoint(ap.Latitude, ap.Longitude), .IsGeodesic = True, .EnableSelection = Utils.DefaultBoolean.False, .EnableHighlighting = Utils.DefaultBoolean.False, .Stroke = FlightMapFactory.AccentShapeColor, .StrokeWidth = 2})
                        AccentPoint(New GeoPoint(ap.Latitude, ap.Longitude))
                    End If
                Next

                RoutesStorage.Items.EndUpdate()
            End If
        End Sub

        Private Sub AccentPoint(ByVal point As CoordPoint)
            RoutesStorage.Items.Add(New MapDot() With {.Location = point, .Stroke = FlightMapFactory.AccentShapeColor, .StrokeWidth = 2, .Size = ScaleDPI.ScaleHorizontal(FlightMapFactory.PointSizeDIP), .Fill = Color.White, .IsHitTestVisible = False})
        End Sub

        Private Sub OnActivePlaneChanged(ByVal planeInfo As PlaneInfo)
            Dim items As MapItemCollection = CType(PathsLayer.Data.Items, MapItemCollection)
            items.BeginUpdate()
            HideLayerItems(PathsLayer)
            Dim airPath As List(Of ItemInfoBase) = dataGenerator.FindAirPath(planeInfo)
            For Each airPathElement As ItemInfoBase In airPath
                Dim item As MapPolyline = TryCast(PathsLayer.GetMapItemBySourceObject(airPathElement), MapPolyline)
                If item IsNot Nothing Then
                    item.Visible = True
                    AccentPoint(item.Points(0))
                    AccentPoint(item.Points(item.Points.Count - 1))
                End If
            Next

            items.EndUpdate()
        End Sub

        Private Sub HideLayerItems(ByVal layer As VectorItemsLayer)
            For Each item As MapItem In layer.Data.Items
                item.Visible = False
            Next
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            If Not firstLoad Then dataGenerator.Start()
        End Sub

        Protected Overrides Sub DoHide()
            dataGenerator.Stop()
            MyBase.DoHide()
        End Sub

        Private Overloads Sub OnDispose()
            If dataGenerator IsNot Nothing Then
                dataGenerator.Dispose()
                dataGenerator = Nothing
            End If

            If mapInfoPanel IsNot Nothing Then
                mapInfoPanel.Dispose()
                mapInfoPanel = Nothing
            End If
        End Sub
    End Class

    Public Class FlightMapDataGenerator
        Implements IDisposable

        Const SecPerHour As Double = 3600000

        Const SpeedScale As Double = 10.0

        Private ReadOnly planesField As List(Of PlaneInfo) = New List(Of PlaneInfo)()

        Private ReadOnly airPathsField As List(Of ItemInfoBase) = New List(Of ItemInfoBase)()

        Private ReadOnly airportsField As List(Of AirportInfo)

        Private ReadOnly routesField As List(Of RouteInfo)

        Private ReadOnly timer As Timer = New Timer()

        Private lastTime As Date

        Public ReadOnly Property Airports As List(Of AirportInfo)
            Get
                Return airportsField
            End Get
        End Property

        Public ReadOnly Property Routes As List(Of RouteInfo)
            Get
                Return routesField
            End Get
        End Property

        Public ReadOnly Property Planes As List(Of PlaneInfo)
            Get
                Return planesField
            End Get
        End Property

        Public ReadOnly Property AirPaths As List(Of ItemInfoBase)
            Get
                Return airPathsField
            End Get
        End Property

        Public Event DataChanged As EventHandler

        Private Shared Function RandomID(ByVal random As NonCryptographicRandom) As String
            Dim A As Integer = Convert.ToInt32("A"c)
            Dim Z As Integer = Convert.ToInt32("Z"c)
            Dim n0 As Integer = Convert.ToInt32("0"c)
            Dim n9 As Integer = Convert.ToInt32("9"c)
            Return String.Format("{0}{1}{2}{3}{4}{5}", Convert.ToChar(random.Next(A, Z)), Convert.ToChar(random.Next(A, Z)), Convert.ToChar(random.Next(n0, n9)), Convert.ToChar(random.Next(n0, n9)), Convert.ToChar(random.Next(n0, n9)), Convert.ToChar(random.Next(A, Z)))
        End Function

        Private Shared Function GetPlaneName(ByVal random As NonCryptographicRandom, ByVal length As Double) As String
            Dim farStr As String() = New String() {"Boeing 777", "Airbus A380"}
            Dim nearStr As String() = New String() {"Boeing 737", "Airbus A318", "Airbus A320"}
            Dim mediumStr As String() = New String() {"Boeing 747", "Airbus A340"}
            If length > 8000 Then Return farStr(random.Next(farStr.Length))
            If length < 3500 Then Return nearStr(random.Next(nearStr.Length))
            Return mediumStr(random.Next(mediumStr.Length))
        End Function

        Public Sub New()
            airportsField = LoadAirports()
            routesField = LoadRoutes()
            LoadPlanes()
            AddHandler timer.Tick, New EventHandler(AddressOf OnTimedEvent)
            timer.Interval = 2000
        End Sub

        Private Sub RaiseDataChanged()
            Dim dataChanged As EventHandler = DataChangedEvent
            If dataChanged IsNot Nothing Then dataChanged(Me, EventArgs.Empty)
        End Sub

        Private Function LoadAirports() As List(Of AirportInfo)
            Dim airports As List(Of AirportInfo) = New List(Of AirportInfo)()
            Try
                Using reader As StreamReader = New StreamReader(DemoUtils.GetRelativePath("airports.csv"))
                    While Not reader.EndOfStream
                        Dim line As String = reader.ReadLine()
                        Dim values As String() = line.Split(";"c)
                        Dim point As AirportInfo = New AirportInfo(New GeoPoint(Double.Parse(values(4), CultureInfo.InvariantCulture), Double.Parse(values(5), CultureInfo.InvariantCulture))) With {.Name = values(0), .City = values(1), .Country = values(2), .IATA = values(3)}
                        airports.Add(point)
                    End While
                End Using
            Catch
                Throw New Exception("It's impossible to load airports data")
            End Try

            Return airports
        End Function

        Private Function LoadRoutes() As List(Of RouteInfo)
            Dim routes As List(Of RouteInfo) = New List(Of RouteInfo)()
            Try
                Using reader As StreamReader = New StreamReader(DemoUtils.GetRelativePath("airroutes.csv"))
                    While Not reader.EndOfStream
                        Dim line As String = reader.ReadLine()
                        Dim values As String() = line.Split(";"c)
                        routes.Add(New RouteInfo() With {.Src = values(0), .Dst = values(1)})
                    End While
                End Using
            Catch
                Throw New Exception("It's impossible to load route data")
            End Try

            Return routes
        End Function

        Private Sub LoadPlanes()
            Dim count As Integer = 1200
            Dim rnd As NonCryptographicRandom = NonCryptographicRandom.System
            While count > 0
                Dim routeInfo As RouteInfo = Routes(rnd.Next(0, Routes.Count - 1))
                Dim a1 As AirportInfo = Airports.Find(Function(a) Equals(a.IATA, routeInfo.Src))
                Dim a2 As AirportInfo = Airports.Find(Function(a) Equals(a.IATA, routeInfo.Dst))
                If a1 Is Nothing OrElse a2 Is Nothing Then Continue While
                count -= 1
                Dim points As List(Of CoordPoint) = New List(Of CoordPoint) From {New GeoPoint(a1.Latitude, a1.Longitude), New GeoPoint(a2.Latitude, a2.Longitude)}
                Dim speed As Double = rnd.Next(600, 850)
                Dim trajectory As TrajectoryInfo = New TrajectoryInfo(points, speed)
                Dim planeName As String = GetPlaneName(rnd, trajectory.Length)
                Dim info As PlaneInfo = New PlaneInfo(planeName, RandomID(rnd), a2.City, a1.City, speed, rnd.Next(7200, 10500), trajectory)
                info.CurrentFlightTime = info.TotalFlightTime * rnd.NextDouble() * 0.7
                Dim size As Integer = CInt(14 + 0.001 * trajectory.Length)
                info.IconSize = New Size(size, size)
                planesField.Add(info)
                airPathsField.Add(info.Trajectory)
            End While
        End Sub

        Private Sub OnTimedEvent(ByVal source As Object, ByVal e As EventArgs)
            Dim currentTime As Date = Date.Now
            Dim interval As TimeSpan = currentTime.Subtract(lastTime)
            For Each info As PlaneInfo In Planes
                If Not info.IsLanded Then info.CurrentFlightTime += SpeedScale * interval.TotalMilliseconds / SecPerHour
            Next

            lastTime = currentTime
            RaiseDataChanged()
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            [Stop]()
            RemoveHandler timer.Tick, AddressOf OnTimedEvent
            timer.Dispose()
        End Sub

        Public Sub Start()
            lastTime = Date.Now
            timer.Start()
        End Sub

        Public Sub [Stop]()
            timer.Stop()
        End Sub

        Public Function FindAirPath(ByVal plane As PlaneInfo) As List(Of ItemInfoBase)
            Return If(plane IsNot Nothing, airPathsField.FindAll(Function(p) p Is plane.Trajectory), New List(Of ItemInfoBase)())
        End Function
    End Class

    Public Class RouteInfo

        Public Property Src As String

        Public Property Dst As String
    End Class

    Public MustInherit Class ItemInfoBase

        Protected MustOverride ReadOnly Property Type As MapItemType

        Public ReadOnly Property ItemType As Integer
            Get
                Return CInt(Type)
            End Get
        End Property

        Public Property Latitude As Double

        Public Property Longitude As Double
    End Class

    Public Class TrajectoryInfo
        Inherits ItemInfoBase

        Private Class TrajectoryPart

            Private _StartPoint As GeoPoint, _EndPoint As GeoPoint, _FlightTime As Double, _Course As Double, _Length As Double

            Public Property StartPoint As GeoPoint
                Get
                    Return _StartPoint
                End Get

                Private Set(ByVal value As GeoPoint)
                    _StartPoint = value
                End Set
            End Property

            Public Property EndPoint As GeoPoint
                Get
                    Return _EndPoint
                End Get

                Private Set(ByVal value As GeoPoint)
                    _EndPoint = value
                End Set
            End Property

            Public Property FlightTime As Double
                Get
                    Return _FlightTime
                End Get

                Private Set(ByVal value As Double)
                    _FlightTime = value
                End Set
            End Property

            Public Property Course As Double
                Get
                    Return _Course
                End Get

                Private Set(ByVal value As Double)
                    _Course = value
                End Set
            End Property

            Public Property Length As Double
                Get
                    Return _Length
                End Get

                Private Set(ByVal value As Double)
                    _Length = value
                End Set
            End Property

            Public Sub New(ByVal start As GeoPoint, ByVal [end] As GeoPoint, ByVal speedInKmH As Double)
                StartPoint = start
                EndPoint = [end]
                Length = GeoUtils.CalculateDistance(start, [end]) * 0.001
                FlightTime = Length / speedInKmH
                Course = Math.Atan2([end].Longitude - start.Longitude, [end].Latitude - start.Latitude)
            End Sub

            Public Function GetPointByCurrentFlightTime(ByVal currentFlightTime As Double) As GeoPoint
                If currentFlightTime > FlightTime Then Return EndPoint
                Dim ratio As Double = currentFlightTime / FlightTime
                Return New GeoPoint(StartPoint.Latitude + ratio * (EndPoint.Latitude - StartPoint.Latitude), StartPoint.Longitude + ratio * (EndPoint.Longitude - StartPoint.Longitude))
            End Function
        End Class

        Private ReadOnly trajectory As List(Of TrajectoryPart) = New List(Of TrajectoryPart)()

        Private ReadOnly speedInKmH As Double

        Protected Overrides ReadOnly Property Type As MapItemType
            Get
                Return MapItemType.Polyline
            End Get
        End Property

        Public ReadOnly Property FlightTime As Double
            Get
                Dim result As Double = 0.0
                For Each part As TrajectoryPart In trajectory
                    result += part.FlightTime
                Next

                Return result
            End Get
        End Property

        Public ReadOnly Property Length As Double
            Get
                Dim result As Double = 0.0
                For Each part As TrajectoryPart In trajectory
                    result += part.Length
                Next

                Return result
            End Get
        End Property

        Public Sub New(ByVal points As List(Of CoordPoint), ByVal speedInKmH As Double)
            Me.speedInKmH = speedInKmH
            UpdateTrajectory(points)
        End Sub

        Public Function GetPointByCurrentFlightTime(ByVal currentFlightTime As Double) As GeoPoint
            Dim time As Double = 0.0
            For i As Integer = 0 To trajectory.Count - 1 - 1
                If trajectory(i).FlightTime > currentFlightTime - time Then Return trajectory(i).GetPointByCurrentFlightTime(currentFlightTime - time)
                time += trajectory(i).FlightTime
            Next

            Return trajectory(trajectory.Count - 1).GetPointByCurrentFlightTime(currentFlightTime - time)
        End Function

        Public Function GetAirPath() As CoordPointCollection
            Dim result As CoordPointCollection = New CoordPointCollection()
            For Each trajectoryPart As TrajectoryPart In trajectory
                result.Add(trajectoryPart.StartPoint)
            Next

            If trajectory.Count > 0 Then result.Add(trajectory(trajectory.Count - 1).EndPoint)
            Return result
        End Function

        Public Function GetCourseByCurrentFlightTime(ByVal currentFlightTime As Double) As Double
            Dim time As Double = 0.0
            For i As Integer = 0 To trajectory.Count - 1 - 1
                If trajectory(i).FlightTime > currentFlightTime - time Then Return trajectory(i).Course
                time += trajectory(i).FlightTime
            Next

            Return trajectory(trajectory.Count - 1).Course
        End Function

        Public Sub UpdateTrajectory(ByVal points As List(Of CoordPoint))
            trajectory.Clear()
            For i As Integer = 0 To points.Count - 1 - 1
                trajectory.Add(New TrajectoryPart(CType(points(i), GeoPoint), CType(points(i + 1), GeoPoint), speedInKmH))
            Next
        End Sub
    End Class

    Public Class AirportInfo
        Inherits ItemInfoBase

        Protected Overrides ReadOnly Property Type As MapItemType
            Get
                Return MapItemType.Dot
            End Get
        End Property

        Public ReadOnly Property Title As String
            Get
                Return "Airport info"
            End Get
        End Property

        Public Property Name As String

        Public Property City As String

        Public Property Country As String

        Public Property IATA As String

        Public Sub New(ByVal location As GeoPoint)
            Latitude = location.Latitude
            Longitude = location.Longitude
        End Sub
    End Class

    Public Class PlaneInfo
        Inherits ItemInfoBase

        Private _Course As Double, _IsLanded As Boolean

        Private Shared ReadOnly iconField As SvgImage = SvgImage.FromFile(DemoUtils.GetRelativePath("\Images\Plane.svg"))

        Private ReadOnly planeIDField As String

        Private ReadOnly nameField As String

        Private ReadOnly endPointNameField As String

        Private ReadOnly startPointNameField As String

        Private ReadOnly speedInKmH As Double

        Private ReadOnly flightAltitudeField As Double

        Private ReadOnly trajectoryField As TrajectoryInfo

        Private currentFlightTimeField As Double

        Private imageField As Image

        Public Property Course As Double
            Get
                Return _Course
            End Get

            Private Set(ByVal value As Double)
                _Course = value
            End Set
        End Property

        Protected Overrides ReadOnly Property Type As MapItemType
            Get
                Return MapItemType.Pushpin
            End Get
        End Property

        Public ReadOnly Property Title As String
            Get
                Return "Flight info"
            End Get
        End Property

        Public Property CurrentFlightTime As Double
            Get
                Return currentFlightTimeField
            End Get

            Set(ByVal value As Double)
                If currentFlightTimeField = value Then Return
                currentFlightTimeField = value
                UpdatePosition(currentFlightTimeField)
            End Set
        End Property

        Public ReadOnly Property PlaneID As String
            Get
                Return planeIDField
            End Get
        End Property

        Public ReadOnly Property Name As String
            Get
                Return nameField
            End Get
        End Property

        Public ReadOnly Property EndPointName As String
            Get
                Return endPointNameField
            End Get
        End Property

        Public ReadOnly Property StartPointName As String
            Get
                Return startPointNameField
            End Get
        End Property

        Public ReadOnly Property SpeedKmH As Double
            Get
                Return If(IsLanded, 0.0, speedInKmH)
            End Get
        End Property

        Public ReadOnly Property FlightAltitude As Double
            Get
                Return If(IsLanded, 0.0, flightAltitudeField)
            End Get
        End Property

        Public Property IsLanded As Boolean
            Get
                Return _IsLanded
            End Get

            Private Set(ByVal value As Boolean)
                _IsLanded = value
            End Set
        End Property

        Public ReadOnly Property TotalFlightTime As Double
            Get
                Return trajectoryField.FlightTime
            End Get
        End Property

        Public ReadOnly Property Icon As SvgImage
            Get
                Return iconField
            End Get
        End Property

        Public ReadOnly Property Image As Image
            Get
                Return imageField
            End Get
        End Property

        Public Property IconSize As Size

        Public ReadOnly Property Trajectory As TrajectoryInfo
            Get
                Return trajectoryField
            End Get
        End Property

        Public ReadOnly Property CurrentFlightTimeInfo As TimeSpan
            Get
                Return New TimeSpan(0, 0, CInt(Math.Ceiling(CurrentFlightTime * 3600)))
            End Get
        End Property

        Public ReadOnly Property TotalFlightTimeInfo As TimeSpan
            Get
                Return New TimeSpan(0, 0, CInt(Math.Ceiling(TotalFlightTime * 3600)))
            End Get
        End Property

        Public Sub New(ByVal name As String, ByVal id As String, ByVal endPointName As String, ByVal startPointName As String, ByVal speedInKmH As Double, ByVal flightAltitude As Double, ByVal trajectory As TrajectoryInfo)
            nameField = name
            planeIDField = id
            endPointNameField = endPointName
            startPointNameField = startPointName
            Me.speedInKmH = speedInKmH
            flightAltitudeField = flightAltitude
            trajectoryField = trajectory
            UpdatePosition(CurrentFlightTime)
        End Sub

        Private Sub UpdatePosition(ByVal flightTime As Double)
            IsLanded = flightTime >= trajectoryField.FlightTime
            Dim point As GeoPoint = trajectoryField.GetPointByCurrentFlightTime(flightTime)
            Latitude = point.Latitude
            Longitude = point.Longitude
            Course = trajectoryField.GetCourseByCurrentFlightTime(flightTime)
        End Sub

        Public Sub UpdateImage(ByVal planeImage As Image)
            imageField = planeImage
        End Sub
    End Class

    Public Class FlightMapFactory
        Inherits DefaultMapItemFactory

        Public Shared AccentShapeColor As Color = Color.FromArgb(255, 209, 28, 28)

        Public Shared PointSizeDIP As Integer = 8

        Private ReadOnly provider As PlaneSvgPaletteProvider = New PlaneSvgPaletteProvider()

        Private ReadOnly scaleDPI As ScaleHelper

        Public Sub New(ByVal scaleDPI As ScaleHelper)
            Me.scaleDPI = scaleDPI
        End Sub

        Protected Overrides Sub InitializeItem(ByVal item As MapItem, ByVal obj As Object)
            MyBase.InitializeItem(item, obj)
            Dim polyLine As MapPolyline = TryCast(item, MapPolyline)
            Dim trajectory As TrajectoryInfo = TryCast(obj, TrajectoryInfo)
            If polyLine IsNot Nothing AndAlso trajectory IsNot Nothing Then
                polyLine.IsGeodesic = True
                polyLine.Points = trajectory.GetAirPath()
                polyLine.Fill = Color.Empty
                polyLine.Stroke = AccentShapeColor
                polyLine.StrokeWidth = 2
                trajectory.UpdateTrajectory(polyLine.ActualPoints.ToList())
                polyLine.Visible = False
                Return
            End If

            Dim airport As MapDot = TryCast(item, MapDot)
            Dim airportInfo As AirportInfo = TryCast(obj, AirportInfo)
            If airport IsNot Nothing AndAlso airportInfo IsNot Nothing Then
                airport.Size = scaleDPI.ScaleHorizontal(PointSizeDIP)
                airport.Fill = Color.White
                airport.SelectedFill = AccentShapeColor
                airport.HighlightedStroke = AccentShapeColor
                airport.SelectedStroke = AccentShapeColor
                airport.Stroke = Color.FromArgb(255, 114, 114, 114)
                airport.StrokeWidth = 2
                Return
            End If

            Dim planeElement As MapPushpin = TryCast(item, MapPushpin)
            Dim info As PlaneInfo = TryCast(obj, PlaneInfo)
            If planeElement IsNot Nothing AndAlso info IsNot Nothing Then
                planeElement.UseAnimation = False
                planeElement.SvgImage = info.Icon
                planeElement.SvgImageSize = info.IconSize
                planeElement.SvgPaletteProvider = provider
                planeElement.Angle = info.Course
                planeElement.Visible = False
            End If
        End Sub
    End Class

    Public Class PlaneSvgPaletteProvider
        Implements IMapSvgPaletteProvider

        Private Function GetSvgPalette(ByVal state As MapElementState) As ISvgPaletteProvider Implements IMapSvgPaletteProvider.GetSvgPalette
            Dim svgPalette As SvgPalette = New SvgPalette()
            If(state And MapElementState.Highlighted) = MapElementState.Highlighted OrElse (state And MapElementState.Selected) = MapElementState.Selected Then svgPalette.Colors.Add(New SvgColor("Blue", Color.FromArgb(255, 255, 177, 21)))
            Return svgPalette
        End Function
    End Class

    Public Class MapInfoPanel
        Implements IDisposable

        Private ReadOnly PlaneImages As Dictionary(Of String, Image) = New Dictionary(Of String, Image)()

        Private ReadOnly overlayManager As MapElementsOverlayManager

        Private ReadOnly scaleHelper As ScaleHelper

        Private selectedPlane As PlaneInfo

        Private selectedAirport As AirportInfo

        Private Shared Function ConvertPlaneNameToFilePath(ByVal PlaneName As String) As String
            Return DemoUtils.GetRelativePath("\Images\Planes\" & PlaneName.Replace(" ", "") & ".png")
        End Function

        Public Sub New(ByVal scaleHelper As ScaleHelper, ByVal overlayManager As MapElementsOverlayManager)
            Me.overlayManager = overlayManager
            Me.scaleHelper = scaleHelper
        End Sub

        Private Function GetPlaneImage(ByVal name As String) As Image
            Dim result As Image = Nothing
            If Not PlaneImages.TryGetValue(name, result) Then
                Dim src As Image = New Bitmap(ConvertPlaneNameToFilePath(name))
                Try
                    result = DemoUtils.ScaleImage(src, scaleHelper)
                    If src IsNot result Then src.Dispose()
                Catch
                    result = src
                End Try

                PlaneImages.Add(name, result)
            End If

            Return result
        End Function

        Private Sub UpdatePlaneInfo()
            If selectedPlane Is Nothing Then
                overlayManager.SetOverlaysVisibility(False, selectedAirport IsNot Nothing)
                Return
            End If

            overlayManager.SetOverlaysVisibility(True, False)
            overlayManager.SetTextToItemByKey("name", selectedPlane.Name)
            overlayManager.SetTextToItemByKey("id", selectedPlane.PlaneID)
            overlayManager.SetTextToItemByKey("from", selectedPlane.StartPointName)
            overlayManager.SetTextToItemByKey("to", selectedPlane.EndPointName)
            overlayManager.SetTextToItemByKey("current_time", New TimeSpan(0, 0, CInt(Math.Ceiling(selectedPlane.CurrentFlightTime * 3600))).ToString())
            overlayManager.SetTextToItemByKey("flight_time", New TimeSpan(0, 0, CInt(Math.Ceiling(selectedPlane.TotalFlightTime * 3600))).ToString())
            overlayManager.SetTextToItemByKey("speed", selectedPlane.SpeedKmH.ToString())
            overlayManager.SetTextToItemByKey("altitude", selectedPlane.FlightAltitude.ToString())
            overlayManager.SetImage(GetPlaneImage(selectedPlane.Name))
        End Sub

        Private Sub UpdateAirportInfo()
            If selectedAirport Is Nothing Then
                overlayManager.SetOverlaysVisibility(selectedPlane IsNot Nothing, False)
                Return
            End If

            overlayManager.SetOverlaysVisibility(False, True)
            overlayManager.SetTextToItemByKey("ap_name", selectedAirport.Name)
            overlayManager.SetTextToItemByKey("ap_iata", selectedAirport.IATA)
            overlayManager.SetTextToItemByKey("ap_city", selectedAirport.City)
            overlayManager.SetTextToItemByKey("ap_country", selectedAirport.Country)
            overlayManager.SetTextToItemByKey("ap_latitude", selectedAirport.Latitude.ToString())
            overlayManager.SetTextToItemByKey("ap_longitude", selectedAirport.Longitude.ToString())
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            For Each image As Image In PlaneImages.Values
                image.Dispose()
            Next

            PlaneImages.Clear()
            GC.SuppressFinalize(Me)
        End Sub

        Public Sub SetCurrentInfo(ByVal obj As ItemInfoBase, ByVal owner As Control)
            selectedPlane = Nothing
            selectedAirport = Nothing
            Dim planeInfo As PlaneInfo = TryCast(obj, PlaneInfo)
            If planeInfo IsNot Nothing Then
                planeInfo.UpdateImage(GetPlaneImage(planeInfo.Name))
                selectedPlane = planeInfo
            End If

            Dim airportInfo As AirportInfo = TryCast(obj, AirportInfo)
            If airportInfo IsNot Nothing Then selectedAirport = airportInfo
            Update()
        End Sub

        Public Sub Update()
            overlayManager.Map.SuspendRender()
            UpdatePlaneInfo()
            UpdateAirportInfo()
            overlayManager.Map.ResumeRender()
        End Sub
    End Class
End Namespace
