Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars

Namespace DevExpress.XtraMap.Demos

    Public Partial Class PixelMap
        Inherits MapTutorialControl

        Private ReadOnly pixelMapGenerator As PixelMapGenerator

        Private overlayManagerField As PerformanceOverlayManager

        Private previousColor As Color

        Private pointsPerDot As Integer = 4

        Private pointDensity As Integer = 56

        Protected ReadOnly Property OverlayManager As PerformanceOverlayManager
            Get
                If overlayManagerField Is Nothing Then overlayManagerField = New PerformanceOverlayManager()
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

        Public Sub New()
            InitializeComponent()
            pixelMapGenerator = New PixelMapGenerator()
            UpdateItems(pointDensity, pointsPerDot)
        End Sub

        Private Sub UpdateItems(ByVal pointsPerMap As Integer, ByVal pointsPerDot As Integer)
            Dim items As List(Of MapItem) = pixelMapGenerator.GenerateMap(New Size(pointsPerMap, pointsPerMap), pointsPerDot)
            mapItemStorage1.Items.Clear()
            mapItemStorage1.Items.AddRange(items)
            OverlayManager.UpdateText(items.Count)
        End Sub

        Private Sub OnPointsComplexityChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If e.Item.Tag Is Nothing Then Return
            pointsPerDot = CInt(e.Item.Tag)
            UpdateItems(pointDensity, pointsPerDot)
        End Sub

        Private Sub OnPointDensityChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            If e.Item.Tag Is Nothing Then Return
            pointDensity = CInt(e.Item.Tag)
            UpdateItems(pointDensity, pointsPerDot)
        End Sub

        Private Sub OnShapesColorItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            previousColor = vectorItemsLayer1.ItemStyle.Fill
            Using colorWheelForm As ColorPickerForm = New ColorPickerForm(pointDensity) With {.StartPosition = FormStartPosition.Manual, .Location = MousePosition}
                colorWheelForm.StartPosition = FormStartPosition.Manual
                colorWheelForm.Location = MousePosition
                colorWheelForm.ColorWheel.Color = previousColor
                AddHandler colorWheelForm.ColorChanged, AddressOf OnColorWheelColorChanged
                colorWheelForm.ShowDialog()
                If colorWheelForm.DialogResult = DialogResult.Cancel Then SetShapeColor(previousColor)
            End Using
        End Sub

        Private Sub OnColorWheelColorChanged(ByVal sender As Object, ByVal args As ColorPickerForm.ColorChangedEventArgs)
            SetShapeColor(args.Color)
        End Sub

        Private Sub SetShapeColor(ByVal color As Color)
            vectorItemsLayer1.ItemStyle.Stroke = color
            vectorItemsLayer1.ItemStyle.Fill = vectorItemsLayer1.ItemStyle.Stroke
        End Sub

        Protected Overrides Sub InitRibbon()
            MyBase.InitRibbon()
            ChkShowMinimap.Enabled = False
        End Sub
    End Class
End Namespace
