Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.XtraMap.Demos

    Public Partial Class ItemsMoving
        Inherits FooteredMapTutorialControl

        Private puzzleGenerator As PuzzleLayoutGenerator

        Private overlayManagerField As ItemsMovingOverlayManager

        Private totalCountries As Integer

        Private ReadOnly Property MapEditor As MapEditor
            Get
                Return MapControl.MapEditor
            End Get
        End Property

        Private ReadOnly Property OverlayManager As ItemsMovingOverlayManager
            Get
                If overlayManagerField Is Nothing Then overlayManagerField = New ItemsMovingOverlayManager()
                Return overlayManagerField
            End Get
        End Property

        Private ReadOnly Property SolvedCountries As Integer
            Get
                Return mapItemStorage2.Items.Count
            End Get
        End Property

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

        Public Sub New()
            InitializeComponent()
            MapEditor.SetTransformMode(MapItemTransform.Move)
            shapefileDataAdapter1.FileUri = DemoUtils.GetFileUri("South America.shp")
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider)
        End Sub

        Private Sub shapefileDataAdapter1_ItemsLoaded(ByVal sender As Object, ByVal e As ItemsLoadedEventArgs)
            vectorItemsLayer3.Visible = False
            puzzleGenerator = New PuzzleLayoutGenerator(e.Items)
            PopulateItems()
        End Sub

        Private Sub PopulateItems()
            RemoveHandler MapEditor.MapItemEdited, AddressOf OnMapItemEdited
            MapEditor.AllowSaveActions = False
            OverlayManager.HideGameFinish()
            mapItemStorage2.Items.Clear()
            Dim pathInfos As IEnumerable(Of MapPathInfo) = puzzleGenerator.GeneratePathInfos()
            mazeData.Items.BeginUpdate()
            Try
                mazeData.Items.Clear()
                For Each pathInfo As MapPathInfo In pathInfos
                    Dim copiedItems As MapItem() = MapEditor.CopyItems(New MapItem() {pathInfo.Path}, mazeLayer)
                    Dim path As MapPath = CType(copiedItems(0), MapPath)
                    path.Attributes.Add(New MapItemAttribute() With {.Name = "RealCenter", .Type = GetType(GeoPoint), .Value = pathInfo.RealCenter})
                    Dim delta As MapPoint = MapControl.CoordPointToScreenPoint(pathInfo.GameCenter) - MapControl.CoordPointToScreenPoint(pathInfo.RealCenter)
                    MapEditor.TranslateItems(New MapItem() {path}, delta.X, delta.Y)
                Next
            Finally
                mazeData.Items.EndUpdate()
            End Try

            totalCountries = mazeData.Items.Count
            MapControl.ZoomToRegion(New GeoPoint(15, -180), New GeoPoint(-62, -45), 0.05)
            OverlayManager.UpdateGameStats(0, totalCountries)
            MapEditor.AllowSaveActions = True
            AddHandler MapEditor.MapItemEdited, AddressOf OnMapItemEdited
        End Sub

        Private Function CalculateDistance(ByVal point1 As MapPoint, ByVal point2 As MapPoint) As Double
            Dim dx As Double = point1.X - point2.X
            Dim dy As Double = point1.Y - point2.Y
            Return Math.Sqrt(dx * dx + dy * dy)
        End Function

        Private Sub MoveItemToSolveLayer(ByVal mapPath As MapPath)
            mazeLayer.SelectedItems.Remove(mapPath)
            mazeData.Items.Remove(mapPath)
            mapItemStorage2.Items.Add(mapPath)
            solveLayer.SelectedItem = mapPath
        End Sub

        Private Sub OnMapItemEdited(ByVal sender As Object, ByVal args As MapItemEditedEventArgs)
            For Each item As MapPath In args.Items
                If item.Layer Is solveLayer Then Continue For
                Dim realCenter As GeoPoint = CType(item.Attributes("RealCenter").Value, GeoPoint)
                Dim currentCenter As GeoPoint = GeoPoint.Normalize(PuzzleLayoutGenerator.GetItemLocation(item))
                Dim desiredScreenCenter As MapPoint = MapControl.CoordPointToScreenPoint(realCenter)
                Dim actualScreenCenter As MapPoint = MapControl.CoordPointToScreenPoint(currentCenter)
                If CalculateDistance(desiredScreenCenter, actualScreenCenter) < 20 Then
                    item.CanMove = False
                    MoveItemToSolveLayer(item)
                    Dim delta As MapPoint = desiredScreenCenter - actualScreenCenter
                    MapEditor.TranslateItems(New MapItem() {item}, delta.X, delta.Y)
                    MapEditor.ClearSavedActions()
                    OverlayManager.UpdateGameStats(SolvedCountries, totalCountries)
                    If SolvedCountries = totalCountries Then OverlayManager.ShowGameFinish()
                End If
            Next
        End Sub

        Protected Overrides Sub InitRibbon()
            MyBase.InitRibbon()
            ChkShowMinimap.Enabled = False
        End Sub

        Private Sub HideOverlay()
            OverlayManager.HideText()
        End Sub

        Private Sub ShowOverlay(ByVal attributes As MapItemAttributeCollection)
            OverlayManager.UpdateText(attributes)
        End Sub

        Private Sub mapControl1_SelectionChanged(ByVal sender As Object, ByVal e As MapSelectionChangedEventArgs)
            Dim item As MapItem = If(e.Selection.Count > 0, CType(e.Selection(0), MapItem), Nothing)
            If item Is Nothing OrElse item.Layer IsNot solveLayer Then
                HideOverlay()
                Return
            End If

            ShowOverlay(item.Attributes)
        End Sub

        Protected Overrides Sub RestoreInitialView()
            MapControl.ZoomToRegion(New GeoPoint(15, -180), New GeoPoint(-62, -45), 0.05)
        End Sub

        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            PopulateItems()
        End Sub

        Private Sub mapControl1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button <> MouseButtons.Left Then Return
            Dim hitInfo As MapHitInfo = MapControl.CalcHitInfo(e.Location)
            Dim clickedItem As MapOverlayItemBase = GetClickedOverlayItem(hitInfo)
            If clickedItem Is Nothing Then Return
            Dim action As ClickedAction = OverlayManager.GetClickedAction(clickedItem)
            If action = ClickedAction.Restart Then
                PopulateItems()
            ElseIf action = ClickedAction.NotRestart Then
                OverlayManager.HideGameFinish()
            End If
        End Sub

        Private Sub mapControl1_OverlaysArranged(ByVal sender As Object, ByVal e As OverlaysArrangedEventArgs)
            OverlayManager.ArrangeOverlays(e.OverlayArrangements)
        End Sub
    End Class

    Public Class MapPathInfo

        Private ReadOnly pathField As MapPath

        Private ReadOnly realCenterField As GeoPoint

        Private ReadOnly gameCenterField As GeoPoint

        Public ReadOnly Property Path As MapPath
            Get
                Return pathField
            End Get
        End Property

        Public ReadOnly Property RealCenter As GeoPoint
            Get
                Return realCenterField
            End Get
        End Property

        Public ReadOnly Property GameCenter As GeoPoint
            Get
                Return gameCenterField
            End Get
        End Property

        Public Sub New(ByVal path As MapPath, ByVal realCenter As GeoPoint, ByVal gameCenter As GeoPoint)
            pathField = path
            realCenterField = realCenter
            gameCenterField = gameCenter
        End Sub
    End Class
End Namespace
