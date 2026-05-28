Namespace DevExpress.XtraMap.Demos

    Public Partial Class MapArrows
        Inherits MapTutorialControl

        Protected Overrides ReadOnly Property MiniMapAlignment As MiniMapAlignment
            Get
                Return MiniMapAlignment.TopRight
            End Get
        End Property

        Public Overrides ReadOnly Property MapControl As MapControl
            Get
                Return mapControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            shapefileDataAdapter1.FileUri = DemoUtils.GetFileUri("Countries.shp")
            InitWindDataAdapter()
        End Sub

        Private Sub InitWindDataAdapter()
            listSourceDataAdapter1.DataSource = LoadItems()
            listSourceDataAdapter1.PropertyMappings.Add(New MapLinePoint1XMapping() With {.Member = "Longitude1"})
            listSourceDataAdapter1.PropertyMappings.Add(New MapLinePoint1YMapping() With {.Member = "Latitude1"})
            listSourceDataAdapter1.PropertyMappings.Add(New MapLinePoint2XMapping() With {.Member = "Longitude2"})
            listSourceDataAdapter1.PropertyMappings.Add(New MapLinePoint2YMapping() With {.Member = "Latitude2"})
            listSourceDataAdapter1.PropertyMappings.Add(New MapItemStrokeWidthMapping() With {.DefaultValue = 2})
            listSourceDataAdapter1.PropertyMappings.Add(New MapLineEndCapVisibleMapping() With {.DefaultValue = True})
            listSourceDataAdapter1.PropertyMappings.Add(New MapLineEndCapLengthMapping() With {.DefaultValue = 12})
            listSourceDataAdapter1.PropertyMappings.Add(New MapLineEndCapWidthMapping() With {.DefaultValue = 6})
            listSourceDataAdapter1.AttributeMappings.Add(New MapItemAttributeMapping("Speed", "Speed"))
        End Sub
    End Class
End Namespace
