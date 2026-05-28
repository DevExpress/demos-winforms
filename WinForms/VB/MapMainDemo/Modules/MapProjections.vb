Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.Demos.DayAndNightLineCalculator
Imports DevExpress.Map
Imports DevExpress.XtraBars
Imports DevExpress.XtraTreeList

Namespace DevExpress.XtraMap.Demos

    Public Partial Class MapProjections
        Inherits DevExpress.XtraMap.Demos.MapTutorialControl

        Const DiscreteHoursStep As Double = 0.5

        Const SteadilyHoursStep As Double = 24.5

        Private ReadOnly excludeFromSouth As System.Collections.Generic.List(Of DevExpress.XtraMap.MapItem) = New System.Collections.Generic.List(Of DevExpress.XtraMap.MapItem)()

        Private ReadOnly Property Sun As MapCustomElement
            Get
                Return CType(Me.Data.Items(0), DevExpress.XtraMap.MapCustomElement)
            End Get
        End Property

        Private ReadOnly Property Moon As MapCustomElement
            Get
                Return CType(Me.Data.Items(2), DevExpress.XtraMap.MapCustomElement)
            End Get
        End Property

        Private ReadOnly Property DayAndNightLine As MapPolygon
            Get
                Return CType(Me.Data.Items(1), DevExpress.XtraMap.MapPolygon)
            End Get
        End Property

        Private Property ActualDateTime As DateTime
            Get
                Return If(Me.barEditCalendar.EditValue IsNot Nothing, CDate(Me.barEditCalendar.EditValue), System.DateTime.UtcNow)
            End Get

            Set(ByVal value As DateTime)
                Me.barEditCalendar.EditValue = value
            End Set
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return Me.mapControl1
            End Get
        End Property

        Public Sub New()
            Me.InitializeComponent()
            Me.ShapefileDataAdapter.FileUri = DevExpress.XtraMap.Demos.DemoUtils.GetFileUri("Countries.shp")
            Me.UpdateCurrentDayAndNightLine()
            Me.PopulateData()
            Me.GenerateGrid()
        End Sub

        Private Sub PopulateData()
            Dim LAEAParent As DevExpress.XtraMap.Demos.Projection = New DevExpress.XtraMap.Demos.Projection() With {.Name = "Lambert Azimuthal Equal Area", .PrjInstance = Nothing}
            Me.projectionsList.DataSource = New System.Collections.Generic.List(Of DevExpress.XtraMap.Demos.Projection)() From {New DevExpress.XtraMap.Demos.Projection() With {.Name = "Spherical Mercator", .PrjInstance = New DevExpress.XtraMap.SphericalMercatorProjection()}, New DevExpress.XtraMap.Demos.Projection() With {.Name = "Equal Area", .PrjInstance = New DevExpress.XtraMap.EqualAreaProjection()}, New DevExpress.XtraMap.Demos.Projection() With {.Name = "Equirectangular", .PrjInstance = New DevExpress.XtraMap.EquirectangularProjection()}, New DevExpress.XtraMap.Demos.Projection() With {.Name = "Elliptical Mercator", .PrjInstance = New DevExpress.XtraMap.EllipticalMercatorProjection()}, New DevExpress.XtraMap.Demos.Projection() With {.Name = "Miller", .PrjInstance = New DevExpress.XtraMap.MillerProjection()}, New DevExpress.XtraMap.Demos.Projection() With {.Name = "Equidistant", .PrjInstance = New DevExpress.XtraMap.EquidistantProjection()}, New DevExpress.XtraMap.Demos.Projection() With {.Name = "Lambert Cylindrical Equal Area", .PrjInstance = New DevExpress.XtraMap.LambertCylindricalEqualAreaProjection()}, LAEAParent, New DevExpress.XtraMap.Demos.Projection() With {.Name = "ETRS89", .PrjInstance = New DevExpress.XtraMap.Etrs89LambertAzimuthalEqualAreaProjection(), .ParentPrjName = LAEAParent.Name}, New DevExpress.XtraMap.Demos.Projection() With {.Name = "North Pole", .PrjInstance = New DevExpress.XtraMap.Demos.NorthPole(), .ParentPrjName = LAEAParent.Name}, New DevExpress.XtraMap.Demos.Projection() With {.Name = "South Pole", .PrjInstance = New DevExpress.XtraMap.Demos.SouthPole(), .ParentPrjName = LAEAParent.Name}, New DevExpress.XtraMap.Demos.Projection() With {.Name = "Braun Stereographic", .PrjInstance = New DevExpress.XtraMap.BraunStereographicProjection()}, New DevExpress.XtraMap.Demos.Projection() With {.Name = "Kavrayskiy VII", .PrjInstance = New DevExpress.XtraMap.KavrayskiyProjection()}, New DevExpress.XtraMap.Demos.Projection() With {.Name = "Sinusoidal", .PrjInstance = New DevExpress.XtraMap.SinusoidalProjection()}, New DevExpress.XtraMap.Demos.Projection() With {.Name = "EPSG:4326", .PrjInstance = New DevExpress.XtraMap.EPSG4326Projection()}}
        End Sub

        Private Sub GenerateGrid()
            Dim gridColor As System.Drawing.Color = System.Drawing.Color.FromArgb(50, 255, 255, 255)
            Me.GenerateLatitudes(gridColor)
            Me.GenerateLongitudes(gridColor)
        End Sub

        Private Sub GenerateLatitudes(ByVal gridColor As System.Drawing.Color)
            For i As Double = -90 To 90 Step 10
                Dim points As DevExpress.XtraMap.CoordPointCollection = New DevExpress.XtraMap.CoordPointCollection()
                For x As Integer = -180 To 180
                    points.Add(New DevExpress.XtraMap.GeoPoint(i, x))
                Next

                Dim line As DevExpress.XtraMap.MapPolyline = New DevExpress.XtraMap.MapPolyline() With {.Points = points, .StrokeWidth = 1, .Stroke = gridColor, .IsGeodesic = False}
                Me.GridData.Items.Add(line)
            Next
        End Sub

        Private Sub GenerateLongitudes(ByVal gridColor As System.Drawing.Color)
            For i As Double = -180 To 180 Step 10
                Dim points As DevExpress.XtraMap.CoordPointCollection = New DevExpress.XtraMap.CoordPointCollection()
                For y As Integer = -90 To 90
                    points.Add(New DevExpress.XtraMap.GeoPoint(y, i))
                Next

                Dim line As DevExpress.XtraMap.MapPolyline = New DevExpress.XtraMap.MapPolyline() With {.Points = points, .StrokeWidth = 1, .Stroke = gridColor, .IsGeodesic = False}
                Me.GridData.Items.Add(line)
            Next
        End Sub

        Private Sub UpdateCurrentDayAndNightLine()
            Dim dt As System.DateTime = System.DateTime.UtcNow
            Me.ActualDateTime = dt
            Me.UpdateDayAndNightLine(dt)
        End Sub

        Private Sub UpdateDayAndNightLine(ByVal dt As System.DateTime)
            Dim sun3DPosition As Double() = DevExpress.Demos.DayAndNightLineCalculator.DayAndNightLineCalculator.CalculateSunPosition(dt)
            Dim sunLocation As DevExpress.XtraMap.GeoPoint = New DevExpress.XtraMap.GeoPoint(sun3DPosition(1), sun3DPosition(0))
            Dim moonLocation As DevExpress.XtraMap.GeoPoint = Me.GetOppositePoint(sunLocation)
            Me.Sun.Location = sunLocation
            Me.Moon.Location = moonLocation
            Dim isNorthNight As Boolean = DevExpress.Demos.DayAndNightLineCalculator.DayAndNightLineCalculator.CalculateIsNorthNight(sun3DPosition)
            Dim dayAndNightLineVertices As DevExpress.XtraMap.CoordPointCollection = Me.GetDayAndNightLineVertices(sunLocation, 0.1)
            If isNorthNight Then
                Me.AddNorthContour(dayAndNightLineVertices)
            Else
                Me.AddSouthContour(dayAndNightLineVertices)
            End If

            Me.DayAndNightLine.Points = dayAndNightLineVertices
        End Sub

        Private Function GetDayAndNightLineVertices(ByVal sunLocation As DevExpress.XtraMap.GeoPoint, ByVal [step] As Double) As CoordPointCollection
            Dim result As DevExpress.XtraMap.CoordPointCollection = New DevExpress.XtraMap.CoordPointCollection()
            Dim latitudes As System.Collections.Generic.IList(Of Double) = DevExpress.Demos.DayAndNightLineCalculator.DayAndNightLineCalculator.GetDayAndNightLineLatitudes(sunLocation.Latitude, sunLocation.Longitude, [step])
            Dim lon As Double = -180
            For Each lat As Double In latitudes
                result.Add(New DevExpress.XtraMap.GeoPoint(lat, lon))
                lon += [step]
            Next

            Return result
        End Function

        Private Function GetOppositePoint(ByVal sunLocation As DevExpress.XtraMap.GeoPoint) As GeoPoint
            Dim lat As Double = -sunLocation.Latitude
            Dim lon As Double = sunLocation.Longitude + 180
            If lon > 180 Then lon -= 360
            Return New DevExpress.XtraMap.GeoPoint(lat, lon)
        End Function

        Private Sub AddNorthContour(ByVal dayAndNightLineVertices As DevExpress.XtraMap.CoordPointCollection)
            Dim initLat As Double = System.Math.Ceiling(CType(dayAndNightLineVertices(CInt((dayAndNightLineVertices.Count - 1))), DevExpress.XtraMap.GeoPoint).Latitude)
            For latForward As Double = initLat To 90.0
                dayAndNightLineVertices.Add(New DevExpress.XtraMap.GeoPoint(latForward, 180))
            Next

            initLat = System.Math.Ceiling(CType(dayAndNightLineVertices(CInt((0))), DevExpress.XtraMap.GeoPoint).Latitude)
            For latBackward As Double = 90 To initLat Step -1
                dayAndNightLineVertices.Add(New DevExpress.XtraMap.GeoPoint(latBackward, -180))
            Next
        End Sub

        Private Sub AddSouthContour(ByVal dayAndNightLineVertices As DevExpress.XtraMap.CoordPointCollection)
            Dim initLat As Double = System.Math.Ceiling(CType(dayAndNightLineVertices(CInt((dayAndNightLineVertices.Count - 1))), DevExpress.XtraMap.GeoPoint).Latitude)
            For lat As Double = initLat To -90.0 Step -1
                dayAndNightLineVertices.Add(New DevExpress.XtraMap.GeoPoint(lat, 180))
            Next

            initLat = System.Math.Ceiling(CType(dayAndNightLineVertices(CInt((0))), DevExpress.XtraMap.GeoPoint).Latitude)
            For lat As Double = -90 To initLat
                dayAndNightLineVertices.Add(New DevExpress.XtraMap.GeoPoint(lat, -180))
            Next
        End Sub

        Private Sub UpdateTimerEnabled(ByVal enabled As Boolean)
            Me.timer.Enabled = enabled
            Me.chkSteadily.Checked = enabled
        End Sub

        Private Function IsDateOverFlow(ByVal currentDate As System.DateTime, ByVal stepHours As Double) As Boolean
            Dim hoursTicks As Long = CLng((stepHours * System.TimeSpan.TicksPerHour + currentDate.Ticks))
            Return hoursTicks >= System.DateTime.MaxValue.Ticks Or hoursTicks <= System.DateTime.MinValue.Ticks
        End Function

        Private Function GetNextDateTime(ByVal dt As System.DateTime) As DateTime
            Dim [step] As Double = If(Me.chkSteadily.Checked, DevExpress.XtraMap.Demos.MapProjections.SteadilyHoursStep, DevExpress.XtraMap.Demos.MapProjections.DiscreteHoursStep)
            Return If(Me.IsDateOverFlow(dt, [step]), System.DateTime.MaxValue, dt.AddHours([step]))
        End Function

        Private Function GetPreviousDateTime(ByVal dt As System.DateTime) As DateTime
            Return If(Me.IsDateOverFlow(dt, -DevExpress.XtraMap.Demos.MapProjections.DiscreteHoursStep), System.DateTime.MinValue, dt.AddHours(-DevExpress.XtraMap.Demos.MapProjections.DiscreteHoursStep))
        End Function

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.ActualDateTime = Me.GetNextDateTime(Me.ActualDateTime)
        End Sub

        Private Sub DayAndNight_DataLoaded(ByVal sender As Object, ByVal e As DevExpress.XtraMap.DataLoadedEventArgs)
            For Each item As DevExpress.XtraMap.MapShape In CType(e, DevExpress.XtraMap.MapItemsLoadedEventArgs).Items
                Dim bounds As DevExpress.Map.MapBounds = item.GetBounds()
                If bounds.Width > 359.0 AndAlso bounds.Bottom < -89.9 Then Me.excludeFromSouth.Add(item)
            Next

            Me.projectionsList.ExpandAll()
            Me.projectionsList.FocusedNode = Me.projectionsList.FindNodeByID(12)
        End Sub

        Private Sub barEditItem2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.UpdateDayAndNightLine(Me.ActualDateTime)
        End Sub

        Private Sub btnCurrent_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Me.UpdateTimerEnabled(False)
            Me.UpdateCurrentDayAndNightLine()
        End Sub

        Private Sub chkSteadily_CheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Me.UpdateTimerEnabled(Me.chkSteadily.Checked)
        End Sub

        Private Sub btnPlus_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Me.UpdateTimerEnabled(False)
            Me.ActualDateTime = Me.GetNextDateTime(Me.ActualDateTime)
        End Sub

        Private Sub btnMinus_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Me.UpdateTimerEnabled(False)
            Me.ActualDateTime = Me.GetPreviousDateTime(Me.ActualDateTime)
        End Sub

        Private Sub ZoomLayersToFit()
            Me.MapControl.EnableZooming = True
            Me.MapControl.ZoomToFitLayerItems(New DevExpress.XtraMap.LayerBase() {Me.FileLayer}, 0.3)
            Me.MapControl.EnableZooming = False
        End Sub

        Private Sub SetVisibleEx(ByVal value As Boolean)
            Me.excludeFromSouth.ForEach(Sub(item) item.Visible = value)
        End Sub

        Private Sub OnProjectionsListFocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs)
            Dim data As DevExpress.XtraMap.Demos.Projection = CType(Me.projectionsList.GetDataRecordByNode(e.Node), DevExpress.XtraMap.Demos.Projection)
            If data.PrjInstance Is Nothing Then Return
            Dim cs As DevExpress.XtraMap.GeoMapCoordinateSystem = CType(Me.mapControl1.CoordinateSystem, DevExpress.XtraMap.GeoMapCoordinateSystem)
            cs.Projection = data.PrjInstance
            Me.SetVisibleEx(Not(TypeOf cs.Projection Is DevExpress.XtraMap.Demos.NorthPole))
            Me.ZoomLayersToFit()
            If TypeOf cs.Projection Is DevExpress.XtraMap.LambertAzimuthalEqualAreaProjectionBase Then Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(CType(cs.Projection, DevExpress.XtraMap.LambertAzimuthalEqualAreaProjectionBase).OriginLatitude, CType(cs.Projection, DevExpress.XtraMap.LambertAzimuthalEqualAreaProjectionBase).CentralMeridian)
        End Sub

        Private Sub OnShowGridCheckedChanged(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Me.GridLayer.Visible = Me.ShowGridBarCheckItem.Checked
        End Sub

        Protected Overrides Sub InitRibbon()
            MyBase.InitRibbon()
            Me.DisableZoomOptions()
            Me.ChkShowMinimap.Enabled = False
        End Sub

        Protected Overrides Sub RestoreInitialView()
            Me.MapControl.CenterPoint = New DevExpress.XtraMap.GeoPoint()
        End Sub

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            Me.UpdateTimerEnabled(False)
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            Me.UpdateTimerEnabled(True)
        End Sub
    End Class

    Public Class Projection

        Public Property Name As String

        Public Property PrjInstance As ProjectionBase

        Public Property ParentPrjName As String
    End Class

    Public Class SouthPole
        Inherits DevExpress.XtraMap.LambertAzimuthalEqualAreaProjectionBase

        Protected Overrides ReadOnly Property IsPredefined As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Function GetBoundingBox() As MapBounds
            Return New DevExpress.Map.MapBounds(-180.0, -90.0, 180.0, 0.0)
        End Function

        Public Sub New()
            Me.OriginLatitude = -90.0
        End Sub

        Public Overrides Function MapUnitToGeoPoint(ByVal mapPoint As DevExpress.XtraMap.MapUnit) As GeoPoint
            Dim res As DevExpress.XtraMap.GeoPoint = MyBase.MapUnitToGeoPoint(mapPoint)
            If mapPoint.X > 0.5 AndAlso mapPoint.Y > 0.5 Then res = New DevExpress.XtraMap.GeoPoint(res.GetY(), 180.0 + res.GetX())
            If mapPoint.X <= 0.5 AndAlso mapPoint.Y > 0.5 Then res = New DevExpress.XtraMap.GeoPoint(res.GetY(), res.GetX() - 180.0)
            Return res
        End Function
    End Class

    Public Class NorthPole
        Inherits DevExpress.XtraMap.LambertAzimuthalEqualAreaProjectionBase

        Protected Overrides ReadOnly Property IsPredefined As Boolean
            Get
                Return False
            End Get
        End Property

        Protected Overrides Function GetBoundingBox() As MapBounds
            Return New DevExpress.Map.MapBounds(-180.0, 0.0, 180.0, 90.0)
        End Function

        Public Sub New()
            Me.OriginLatitude = 90.0
        End Sub

        Public Overrides Function MapUnitToGeoPoint(ByVal mapPoint As DevExpress.XtraMap.MapUnit) As GeoPoint
            Dim res As DevExpress.XtraMap.GeoPoint = MyBase.MapUnitToGeoPoint(mapPoint)
            If mapPoint.X >= 0.5 AndAlso mapPoint.Y < 0.5 Then res = New DevExpress.XtraMap.GeoPoint(res.GetY(), 180.0 + res.GetX())
            If mapPoint.X < 0.5 AndAlso mapPoint.Y < 0.5 Then res = New DevExpress.XtraMap.GeoPoint(res.GetY(), res.GetX() - 180.0)
            Return res
        End Function
    End Class
End Namespace
