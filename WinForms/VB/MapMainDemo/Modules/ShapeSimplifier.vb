Imports System
Imports System.Linq
Imports DevExpress.Map

Namespace DevExpress.XtraMap.Demos

    Public Partial Class ShapeSimplifierDemo
        Inherits MapTutorialControl

        Public Shared MaxToleranceValue As Integer = 280

        Private isActive As Boolean = True

        Private isDataLoaded As Boolean = False

        Private toleranceField As Integer = MaxToleranceValue

        Private toleranceDelta As Integer = 1

        Private overlayManagerField As ShapeSimplifierOverlayManager

        Private Property Tolerance As Integer
            Get
                Return toleranceField
            End Get

            Set(ByVal value As Integer)
                toleranceField = value
                Simplify()
            End Set
        End Property

        Private ReadOnly Property Editor As MapEditor
            Get
                Return MapControl.MapEditor
            End Get
        End Property

        Private ReadOnly Property ActiveLayer As VectorItemsLayer
            Get
                Return If(vectorItemsLayer1.Visible, vectorItemsLayer1, vectorItemsLayer2)
            End Get
        End Property

        Private ReadOnly Property OverlayManager As ShapeSimplifierOverlayManager
            Get
                If overlayManagerField Is Nothing Then overlayManagerField = New ShapeSimplifierOverlayManager()
                Return overlayManagerField
            End Get
        End Property

        Protected Overrides ReadOnly Property Overlays As MapOverlay()
            Get
                Return OverlayManager.GetOverlays()
            End Get
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return mapControl1
            End Get
        End Property

        Public Overrides ReadOnly Property UseEmptyRootPadding As Boolean
            Get
                Return False
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            tabPaneOptions.AllowCollapse = Utils.DefaultBoolean.True
            shapefileDataAdapter1.FileUri = DemoUtils.GetFileUri("Iceland.shp")
        End Sub

        Protected Overrides Sub RestoreInitialView()
            MapControl.ZoomToFitLayerItems(0.15)
        End Sub

        Protected Overrides Sub InitRibbon()
            MyBase.InitRibbon()
            ChkShowMinimap.Enabled = False
        End Sub

        Protected Overrides Sub OnHandleDestroyed(ByVal e As EventArgs)
            isActive = False
            MyBase.OnHandleDestroyed(e)
        End Sub

        Protected Overrides Sub DoHide()
            MyBase.DoHide()
            UpdateTimerEnabled(False)
        End Sub

        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            UpdateTimerEnabled(True)
        End Sub

        Private Sub UpdateTimerEnabled(ByVal enabled As Boolean)
            timer1.Enabled = enabled AndAlso isDataLoaded AndAlso ceAutoMode.Checked
        End Sub

        Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
            If Not isActive Then
                UpdateTimerEnabled(False)
                Return
            End If

            toleranceDelta = If(Tolerance = MaxToleranceValue, -1, If(Tolerance = 0, 1, toleranceDelta))
            mfTrackBarControl.Value = Tolerance + toleranceDelta
        End Sub

        Private Sub OnItemsLoaded(ByVal sender As Object, ByVal e As ItemsLoadedEventArgs)
            Dim line As MapPolyline = New MapPolyline()
            line.Points.AddRange(CType(e.Items(0), ISupportCoordPoints).Points.ToArray())
            mapItemStorage1.Items.Add(line)
            Dim etalonLine As MapPolyline = New MapPolyline()
            etalonLine.Points.AddRange(CType(e.Items(0), ISupportCoordPoints).Points.ToArray())
            mapItemStorage2.Items.Add(etalonLine)
        End Sub

        Private Sub OnDataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs)
            mfTrackBarControl.EditValue = 280
            mfTrackBarControl.Value = 280
            isDataLoaded = True
            RestoreInitialView()
            UpdateCounterText(100)
            UpdateTimerEnabled(True)
        End Sub

        Private Sub OnTrackBarControlValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Tolerance = mfTrackBarControl.Value
        End Sub

        Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            layoutControlItem2.Enabled = Not ceAutoMode.Checked
            UpdateTimerEnabled(True)
        End Sub

        Private Sub Simplify()
            Dim tolerance As Double = CalculateTolerance(Me.Tolerance)
            Editor.SimplifyItems(ActiveLayer.Data.Items, tolerance)
            UpdateCounterText(tolerance)
        End Sub

        Private Function CalculateTolerance(ByVal value As Double) As Double
            Return Math.Max(Math.Round(100 * Math.Abs(Math.Pow(value / MaxToleranceValue, 5)), 4), 0.001)
        End Function

        Private Sub ShapeTypeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            vectorItemsLayer1.Visible = shapeTypeRadioGroup.SelectedIndex = 0
            vectorItemsLayer2.Visible = Not vectorItemsLayer1.Visible
            RestoreInitialView()
            Simplify()
        End Sub

        Private Sub UpdateCounterText(ByVal tolerance As Double)
            Dim item As MapItem = ActiveLayer.Data.Items.FirstOrDefault()
            If item Is Nothing Then Return
            Dim pointsCount As Integer = CType(item, ISupportCoordPoints).Points.Count - 1
            OverlayManager.UpdateText(pointsCount, tolerance)
        End Sub
    End Class
End Namespace
