Imports System
Imports System.Globalization
Imports System.IO
Imports DevExpress.Internal
Imports DevExpress.Map
Imports DevExpress.Utils.Design
Imports DevExpress.Utils.DPI
Imports DevExpress.Utils.Html
Imports DevExpress.Utils.Svg
Imports DevExpress.XtraEditors
Imports DevExpress.XtraMap

Namespace DevExpress.ProductsDemo.Win.Modules
    Partial Public Class MapsModule
        Inherits BaseModule

        Private dataGenerator As FlightMapDataGenerator
        Private mapInfoPanel As MapInfoPanel

        Protected Overrides Property AutoMergeRibbon As Boolean
            Get
                Return True
            End Get
            Set(value As Boolean)
                MyBase.AutoMergeRibbon = value
            End Set
        End Property


        Public ReadOnly Property MapControl() As MapControl
            Get
                Return mapControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            TilesLayer.DataProvider = MapUtils.CreateAzureDataProvider(AzureTileset.BaseRoad)
            MapControl.SetMapItemFactory(New FlightMapFactory(ScaleDPI))

            Dim templates As New Dictionary(Of String, HtmlTemplate)()
            templates.Add("plane", PlaneTemplate)
            templates.Add("airport", AirportTemplate)
            mapInfoPanel = New MapInfoPanel(ScaleDPI, htmlContentPopup1, templates)

            dataGenerator = New FlightMapDataGenerator()
            AddHandler dataGenerator.DataChanged, AddressOf OnDataChanged

            PlanesDataAdapter.DataSource = dataGenerator.Planes
            PathsDataAdapter.DataSource = dataGenerator.AirPaths
            AirportsDataAdapter.DataSource = dataGenerator.Airports
        End Sub
        Private Sub OnAzureTilesetCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            UpdateAzureTileset(CInt(e.Item.Tag))
        End Sub
        Private Sub OnDataChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Not PlanesLayer.Visible Then
                Return
            End If
            MapControl.SuspendRender()
            For Each item As MapItem In PlanesLayer.Data.Items
                Dim info As PlaneInfo = TryCast(item.Tag, PlaneInfo)
                Dim pin As MapPushpin = TryCast(item, MapPushpin)
                If pin IsNot Nothing AndAlso info IsNot Nothing Then
                    pin.Location = New GeoPoint(info.Latitude, info.Longitude)
                    pin.Angle = info.Course
                    pin.Visible = Not info.IsLanded
                End If
            Next item
            MapControl.ResumeRender()
            Me.mapInfoPanel.Update()
        End Sub
        Private Sub AirportsLayer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            Dim current As AirportInfo = dataGenerator.Airports.Find(Function(a) a.IATA = "FRA")
            AirportsLayer.SelectedItem = current
            dataGenerator.Start()
        End Sub
        Private Sub OnMapSelectionChanged(ByVal sender As Object, ByVal e As MapSelectionChangedEventArgs)
            Dim info As ItemInfoBase = TryCast(e.Selection.FirstOrDefault(), ItemInfoBase)
            Me.mapInfoPanel.SetCurrentInfo(info, MapControl)
            ShowRoutes(TryCast(info, AirportInfo))
            OnActivePlaneChanged(TryCast(info, PlaneInfo))
        End Sub
        Private Sub OnPlanesVisibilityCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            PlanesLayer.Visible = barCheckItem1.Checked
            PlanesLayer.SelectedItems.Clear()
        End Sub
        Private Sub UpdateAzureTileset(ByVal tileset As Integer)
            Dim provider As AzureMapDataProvider = CType(TilesLayer.DataProvider, AzureMapDataProvider)
            provider.Tileset = CType(tileset, AzureTileset)
        End Sub
        Private Sub ShowRoutes(ByVal info As AirportInfo)
            RoutesStorage.Items.Clear()
            If info IsNot Nothing Then
                RoutesStorage.Items.BeginUpdate()
                Dim res As List(Of RouteInfo) = dataGenerator.Routes.FindAll(Function(r) r.Src = info.IATA)
                For Each item In res
                    Dim ap As AirportInfo = dataGenerator.Airports.Find(Function(a) a.IATA.Equals(item.Dst))
                    If ap IsNot Nothing Then
                        RoutesStorage.Items.Add(New MapLine() With {
                            .Point1 = New GeoPoint(info.Latitude, info.Longitude),
                            .Point2 = New GeoPoint(ap.Latitude, ap.Longitude),
                            .IsGeodesic = True,
                            .EnableSelection = Utils.DefaultBoolean.False,
                            .EnableHighlighting = Utils.DefaultBoolean.False,
                            .Stroke = FlightMapFactory.AccentShapeColor,
                            .StrokeWidth = 2
                        })
                        AccentPoint(New GeoPoint(ap.Latitude, ap.Longitude))
                    End If
                Next item
                RoutesStorage.Items.EndUpdate()
            End If
        End Sub
        Private Sub AccentPoint(ByVal point As CoordPoint)
            RoutesStorage.Items.Add(New MapDot() With {
                .Location = point,
                .Stroke = FlightMapFactory.AccentShapeColor,
                .StrokeWidth = 2,
                .Size = ScaleDPI.ScaleHorizontal(FlightMapFactory.PointSizeDIP),
                .Fill = Color.White,
                .IsHitTestVisible = False
            })
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
            Next airPathElement
            items.EndUpdate()
        End Sub
        Private Sub HideLayerItems(ByVal layer As VectorItemsLayer)
            For Each item As MapItem In layer.Data.Items
                item.Visible = False
            Next item
        End Sub
        Private Sub OnDispose()
            If dataGenerator IsNot Nothing Then
                dataGenerator.Dispose()
                dataGenerator = Nothing
            End If
            If mapInfoPanel IsNot Nothing Then
                mapInfoPanel.Dispose()
                mapInfoPanel = Nothing
            End If
        End Sub

        Friend Overrides Sub ShowModule(ByVal firstShow As Boolean)
            MyBase.ShowModule(firstShow)
            If Not firstShow Then
                dataGenerator.Start()
            End If
        End Sub
        Friend Overrides Sub HideModule()
            dataGenerator.StopGen()
            MyBase.HideModule()
        End Sub
    End Class


    Public Class FlightMapDataGenerator
        Implements IDisposable

        Const SecPerHour As Double = 3600000
        Const SpeedScale As Double = 10.0
        ReadOnly _planes As List(Of PlaneInfo) = New List(Of PlaneInfo)()
        ReadOnly _airPaths As List(Of ItemInfoBase) = New List(Of ItemInfoBase)()
        ReadOnly _airports As List(Of AirportInfo)
        ReadOnly _routes As List(Of RouteInfo)
        ReadOnly timer As Timer = New Timer()
        Private lastTime As DateTime

        Public ReadOnly Property Airports As List(Of AirportInfo)
            Get
                Return _airports
            End Get
        End Property

        Public ReadOnly Property Routes As List(Of RouteInfo)
            Get
                Return _routes
            End Get
        End Property

        Public ReadOnly Property Planes As List(Of PlaneInfo)
            Get
                Return _planes
            End Get
        End Property

        Public ReadOnly Property AirPaths As List(Of ItemInfoBase)
            Get
                Return _airPaths
            End Get
        End Property

        Public Event DataChanged As EventHandler

        Private Shared Function RandomID(ByVal random As Random) As String
            Dim A As Integer = Convert.ToInt32("A"c)
            Dim Z As Integer = Convert.ToInt32("Z"c)
            Dim n0 As Integer = Convert.ToInt32("0"c)
            Dim n9 As Integer = Convert.ToInt32("9"c)
            Return String.Format("{0}{1}{2}{3}{4}{5}", Convert.ToChar(random.Next(A, Z)), Convert.ToChar(random.Next(A, Z)),
                                                       Convert.ToChar(random.Next(n0, n9)), Convert.ToChar(random.Next(n0, n9)),
                                                       Convert.ToChar(random.Next(n0, n9)), Convert.ToChar(random.Next(A, Z)))
        End Function

        Private Shared Function GetPlaneName(ByVal random As Random, ByVal length As Double) As String
            Dim farStr As String() = New String() {"Boeing 777", "Airbus A380"}
            Dim nearStr As String() = New String() {"Boeing 737", "Airbus A318", "Airbus A320"}
            Dim mediumStr As String() = New String() {"Boeing 747", "Airbus A340"}
            If length > 8000 Then Return farStr(random.[Next](farStr.Length))
            If length < 3500 Then Return nearStr(random.[Next](nearStr.Length))
            Return mediumStr(random.[Next](mediumStr.Length))
        End Function

        Public Sub New()
            _airports = LoadAirports()
            _routes = LoadRoutes()
            LoadPlanes()
            timer.Interval = 2000
            AddHandler timer.Tick, AddressOf OnTimedEvent
        End Sub

        Private Sub RaiseDataChanged()
            RaiseEvent DataChanged(Me, EventArgs.Empty)
        End Sub

        Private Function LoadAirports() As List(Of AirportInfo)
            Dim airports As List(Of AirportInfo) = New List(Of AirportInfo)()
            Try
                Using reader As StreamReader = New StreamReader(DataDirectoryHelper.GetDataFile("airports.csv"))

                    While Not reader.EndOfStream
                        Dim line As String = reader.ReadLine()
                        Dim values = line.Split(";"c)
                        Dim point As AirportInfo = New AirportInfo(New GeoPoint(Double.Parse(values(4), CultureInfo.InvariantCulture), Double.Parse(values(5), CultureInfo.InvariantCulture))) With {
                        .Name = values(0),
                        .City = values(1),
                        .Country = values(2),
                        .IATA = values(3)
                    }
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
                Using reader As StreamReader = New StreamReader(DataDirectoryHelper.GetDataFile("airroutes.csv"))
                    While Not reader.EndOfStream
                        Dim line As String = reader.ReadLine()
                        Dim values = line.Split(";"c)
                        routes.Add(New RouteInfo() With {
                        .Src = values(0),
                        .Dst = values(1)
                    })
                    End While
                End Using
            Catch
                Throw New Exception("It's impossible to load route data")
            End Try
            Return routes
        End Function
        Private Sub LoadPlanes()
            Dim count As Integer = 1200
            Dim rnd As Random = New Random()

            While count > 0
                Dim routeInfo As RouteInfo = Routes(rnd.[Next](0, Routes.Count - 1))
                Dim a1 As AirportInfo = Airports.Find(Function(a) a.IATA = routeInfo.Src)
                Dim a2 As AirportInfo = Airports.Find(Function(a) a.IATA = routeInfo.Dst)
                If a1 Is Nothing OrElse a2 Is Nothing Then Continue While
                count -= 1
                Dim points As List(Of CoordPoint) = New List(Of CoordPoint) From {
                New GeoPoint(a1.Latitude, a1.Longitude),
                New GeoPoint(a2.Latitude, a2.Longitude)
            }
                Dim speed As Double = rnd.[Next](600, 850)
                Dim trajectory As TrajectoryInfo = New TrajectoryInfo(points, speed)
                Dim planeName As String = GetPlaneName(rnd, trajectory.Length)
                Dim info As PlaneInfo = New PlaneInfo(planeName, RandomID(rnd), a2.City, a1.City, speed, rnd.[Next](7200, 10500), trajectory)
                info.CurrentFlightTime = info.TotalFlightTime * rnd.NextDouble() * 0.7
                Dim size As Integer = CInt((14 + 0.001 * trajectory.Length))
                info.IconSize = New Size(size, size)
                Planes.Add(info)
                AirPaths.Add(info.Trajectory)
            End While
        End Sub
        Private Sub OnTimedEvent(ByVal source As Object, ByVal e As EventArgs)
            Dim currentTime As DateTime = DateTime.Now
            Dim interval As TimeSpan = currentTime.Subtract(lastTime)

            For Each info As PlaneInfo In Planes
                If Not info.IsLanded Then info.CurrentFlightTime += SpeedScale * interval.TotalMilliseconds / SecPerHour
            Next

            lastTime = currentTime
            RaiseDataChanged()
        End Sub
        Public Sub Dispose() Implements IDisposable.Dispose
            StopGen()
            RemoveHandler timer.Tick, AddressOf OnTimedEvent
            timer.Dispose()
        End Sub
        Public Sub Start()
            lastTime = DateTime.Now
            timer.Start()
        End Sub
        Public Sub StopGen()
            timer.Stop()
        End Sub
        Public Function FindAirPath(ByVal plane As PlaneInfo) As List(Of ItemInfoBase)
            Return If(plane IsNot Nothing, AirPaths.FindAll(Function(p) p.Equals(plane.Trajectory)), New List(Of ItemInfoBase)())
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
        Class TrajectoryPart
            Public Property StartPoint As GeoPoint
            Public Property EndPoint As GeoPoint
            Public Property FlightTime As Double
            Public Property Course As Double
            Public Property Length As Double

            Public Sub New(ByVal start As GeoPoint, ByVal [end] As GeoPoint, ByVal speedInKmH As Double)
                StartPoint = start
                EndPoint = [end]
                Length = GeoUtils.CalculateDistance(start, [end]) * 0.001
                FlightTime = Length / speedInKmH
                Course = Math.Atan2(([end].Longitude - start.Longitude), ([end].Latitude - start.Latitude))
            End Sub

            Public Function GetPointByCurrentFlightTime(ByVal currentFlightTime As Double) As GeoPoint
                If currentFlightTime > FlightTime Then Return EndPoint
                Dim ratio As Double = currentFlightTime / FlightTime
                Return New GeoPoint(StartPoint.Latitude + ratio * (EndPoint.Latitude - StartPoint.Latitude), StartPoint.Longitude + ratio * (EndPoint.Longitude - StartPoint.Longitude))
            End Function
        End Class

        ReadOnly trajectory As List(Of TrajectoryPart) = New List(Of TrajectoryPart)()
        ReadOnly speedInKmH As Double

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
            Me.Latitude = location.Latitude
            Me.Longitude = location.Longitude
        End Sub
    End Class

    Public Class PlaneInfo
        Inherits ItemInfoBase

        Shared ReadOnly _icon As SvgImage = My.Resources.Plane

        ReadOnly _planeID As String
        ReadOnly _name As String
        ReadOnly _endPointName As String
        ReadOnly _startPointName As String
        ReadOnly _speedInKmH As Double
        ReadOnly _flightAltitude As Double
        ReadOnly _trajectory As TrajectoryInfo
        Private _currentFlightTime As Double
        Private _image As Image
        Public Property Course As Double

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
                Return _currentFlightTime
            End Get
            Set(ByVal value As Double)
                If _currentFlightTime = value Then Return
                _currentFlightTime = value
                UpdatePosition(_currentFlightTime)
            End Set
        End Property

        Public ReadOnly Property PlaneID As String
            Get
                Return _planeID
            End Get
        End Property

        Public ReadOnly Property Name As String
            Get
                Return _name
            End Get
        End Property

        Public ReadOnly Property EndPointName As String
            Get
                Return _endPointName
            End Get
        End Property

        Public ReadOnly Property StartPointName As String
            Get
                Return _startPointName
            End Get
        End Property

        Public ReadOnly Property SpeedKmH As Double
            Get
                Return If(IsLanded, 0.0, _speedInKmH)
            End Get
        End Property

        Public ReadOnly Property FlightAltitude As Double
            Get
                Return If(IsLanded, 0.0, _flightAltitude)
            End Get
        End Property

        Public Property IsLanded As Boolean

        Public ReadOnly Property TotalFlightTime As Double
            Get
                Return _trajectory.FlightTime
            End Get
        End Property

        Public ReadOnly Property Icon As SvgImage
            Get
                Return _icon
            End Get
        End Property

        Public ReadOnly Property Image As Image
            Get
                Return _image
            End Get
        End Property

        Public Property IconSize As Size

        Public ReadOnly Property Trajectory As TrajectoryInfo
            Get
                Return _trajectory
            End Get
        End Property

        Public ReadOnly Property CurrentFlightTimeInfo As TimeSpan
            Get
                Return New TimeSpan(0, 0, CInt(Math.Ceiling(_currentFlightTime * 3600)))
            End Get
        End Property

        Public ReadOnly Property TotalFlightTimeInfo As TimeSpan
            Get
                Return New TimeSpan(0, 0, CInt(Math.Ceiling(TotalFlightTime * 3600)))
            End Get
        End Property

        Public Sub New(ByVal name As String, ByVal id As String, ByVal endPointName As String, ByVal startPointName As String, ByVal speedInKmH As Double, ByVal flightAltitude As Double, ByVal trajectory As TrajectoryInfo)
            _name = name
            _planeID = id
            _endPointName = endPointName
            _startPointName = startPointName
            _speedInKmH = speedInKmH
            _flightAltitude = flightAltitude
            _trajectory = trajectory
            UpdatePosition(_currentFlightTime)
        End Sub

        Private Sub UpdatePosition(ByVal flightTime As Double)
            IsLanded = flightTime >= Trajectory.FlightTime
            Dim point As GeoPoint = Trajectory.GetPointByCurrentFlightTime(flightTime)
            Latitude = point.Latitude
            Longitude = point.Longitude
            Course = Trajectory.GetCourseByCurrentFlightTime(flightTime)
        End Sub

        Public Sub UpdateImage(ByVal planeImage As Image)
            _image = planeImage
        End Sub
    End Class

    Public Class FlightMapFactory
        Inherits DefaultMapItemFactory

        Public Shared AccentShapeColor As Color = Color.FromArgb(255, 209, 28, 28)
        Public Shared PointSizeDIP As Integer = 8
        ReadOnly provider As PlaneSvgPaletteProvider = New PlaneSvgPaletteProvider()
        ReadOnly scaleDPI As ScaleHelper

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
                airport.Size = Me.scaleDPI.ScaleHorizontal(PointSizeDIP)
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

        Private Function IMapSvgPaletteProvider_GetSvgPalette(ByVal state As MapElementState) As ISvgPaletteProvider Implements IMapSvgPaletteProvider.GetSvgPalette
            Dim svgPalette As New SvgPalette()
            If (state And MapElementState.Highlighted) = MapElementState.Highlighted OrElse (state And MapElementState.Selected) = MapElementState.Selected Then
                svgPalette.Colors.Add(New SvgColor("Blue", Color.FromArgb(255, 255, 177, 21)))
            End If
            Return svgPalette
        End Function
    End Class

    Public Class MapInfoPanel
        Implements IDisposable
        Private ReadOnly PlaneImages As New Dictionary(Of String, Image)()
        Private ReadOnly htmlContentPopup As HtmlContentPopup
        Private ReadOnly scaleHelper As ScaleHelper
        Private ReadOnly templates As Dictionary(Of String, HtmlTemplate)
        Private Shared Function ConvertPlaneNameToFilePath(ByVal PlaneName As String) As String
            Return DataDirectoryHelper.GetDataFile("Planes\" & PlaneName.Replace(" ", "") & ".png")
        End Function
        Public Sub New(ByVal scaleHelper As ScaleHelper, ByVal htmlContentPopup As HtmlContentPopup, ByVal templates As Dictionary(Of String, HtmlTemplate))
            Me.templates = templates
            Me.htmlContentPopup = htmlContentPopup
            Me.htmlContentPopup.HideAutomatically = Utils.DefaultBoolean.False
            Me.scaleHelper = scaleHelper
        End Sub
        Private Function GetPlaneImage(ByVal name As String) As Image
            Dim result As Image = Nothing
            If Not PlaneImages.TryGetValue(name, result) Then
                Dim src As Image = New Bitmap(ConvertPlaneNameToFilePath(name))
                Try
                    result = MapUtils.ScaleImage(src, Me.scaleHelper)
                    If src IsNot result Then
                        src.Dispose()
                    End If
                Catch
                    result = src
                End Try
                PlaneImages.Add(name, result)
            End If
            Return result
        End Function

        Public Sub Update()
            htmlContentPopup.UpdateLayout()
        End Sub
        Public Sub Dispose() Implements IDisposable.Dispose
            For Each image As Image In PlaneImages.Values
                image.Dispose()
            Next image
            PlaneImages.Clear()
            GC.SuppressFinalize(Me)
        End Sub
        Public Sub SetCurrentInfo(ByVal obj As ItemInfoBase, ByVal owner As Control)
            If obj Is Nothing Then
                htmlContentPopup.Hide()
                Return
            End If

            Dim planeInfo As PlaneInfo = TryCast(obj, PlaneInfo)
            If planeInfo IsNot Nothing Then
                planeInfo.UpdateImage(GetPlaneImage(planeInfo.Name))
                htmlContentPopup.HtmlTemplate.Assign(templates("plane"))
            End If
            Dim airportInfo As AirportInfo = TryCast(obj, AirportInfo)
            If airportInfo IsNot Nothing Then
                htmlContentPopup.HtmlTemplate.Assign(templates("airport"))
            End If

            htmlContentPopup.DataContext = obj
            Dim sz As Size = Me.htmlContentPopup.CalcBestSize(owner, -1)
            Dim bounds As Rectangle = owner.RectangleToScreen(New Rectangle(New Point(owner.Bounds.Right - sz.Width, owner.Bounds.Top), sz))
            htmlContentPopup.Show(owner, bounds)
        End Sub
    End Class
End Namespace
