Imports System.Drawing
Imports DevExpress.Map

Namespace DevExpress.XtraMap.Demos

    Public Partial Class ShapeImage
        Inherits FooteredMapTutorialControl

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
                Return mapControlField
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider)
            Dim centralPark As MapPolygon = New MapPolygon() With {.Stroke = System.Drawing.Color.Transparent}
            centralPark.Points.Add(New GeoPoint(40.767809, -73.981249))
            centralPark.Points.Add(New GeoPoint(40.768458, -73.981477))
            centralPark.Points.Add(New GeoPoint(40.800273, -73.958291))
            centralPark.Points.Add(New GeoPoint(40.800396, -73.957846))
            centralPark.Points.Add(New GeoPoint(40.797011, -73.949683))
            centralPark.Points.Add(New GeoPoint(40.796626, -73.949541))
            centralPark.Points.Add(New GeoPoint(40.764918, -73.972547))
            centralPark.Points.Add(New GeoPoint(40.765230, -73.973245))
            centralPark.Points.Add(New GeoPoint(40.764704, -73.973741))
            centralPark.Image.Source = Properties.Resources.CentralPark
            mapItemStorage.Items.Add(centralPark)
        End Sub

        Private Sub ImageLayer1_ViewportChanged(ByVal sender As Object, ByVal e As ViewportChangedEventArgs)
            If Not e.IsAnimated AndAlso e.ZoomLevel <= 14 Then
                Dim center As CoordPoint = If(InitialCenterPoint, mapControlField.CenterPoint)
                Dim xOffset As Double =(e.BottomRight.GetX() - e.TopLeft.GetX()) / 2R
                Dim yOffset As Double =(e.BottomRight.GetY() - e.TopLeft.GetY()) / 2R
                mapControlField.ScrollArea = New MapBounds(center.Offset(-xOffset, -yOffset), center.Offset(xOffset, yOffset))
            End If
        End Sub
    End Class
End Namespace
