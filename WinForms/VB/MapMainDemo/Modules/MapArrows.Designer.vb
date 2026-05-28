Namespace DevExpress.XtraMap.Demos

    Partial Class MapArrows

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim choroplethColorizer1 As DevExpress.XtraMap.ChoroplethColorizer = New DevExpress.XtraMap.ChoroplethColorizer()
            Dim colorizerColorItem1 As DevExpress.XtraMap.ColorizerColorItem = New DevExpress.XtraMap.ColorizerColorItem()
            Dim colorizerColorItem2 As DevExpress.XtraMap.ColorizerColorItem = New DevExpress.XtraMap.ColorizerColorItem()
            Dim colorizerColorItem3 As DevExpress.XtraMap.ColorizerColorItem = New DevExpress.XtraMap.ColorizerColorItem()
            Dim linearRangeDistribution1 As DevExpress.XtraMap.LinearRangeDistribution = New DevExpress.XtraMap.LinearRangeDistribution()
            Dim shapeAttributeValueProvider1 As DevExpress.XtraMap.ShapeAttributeValueProvider = New DevExpress.XtraMap.ShapeAttributeValueProvider()
            Dim geoMapCoordinateSystem1 As DevExpress.XtraMap.GeoMapCoordinateSystem = New DevExpress.XtraMap.GeoMapCoordinateSystem()
            Dim colorScaleLegend1 As DevExpress.XtraMap.ColorScaleLegend = New DevExpress.XtraMap.ColorScaleLegend()
            Me.itemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.listSourceDataAdapter1 = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.shapefileDataAdapter1 = New DevExpress.XtraMap.ShapefileDataAdapter()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.MaxItemId = 8
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ribbonControl1.Size = New System.Drawing.Size(721, 256)
            choroplethColorizer1.ApproximateColors = True
            colorizerColorItem1.Color = System.Drawing.Color.Green
            colorizerColorItem2.Color = System.Drawing.Color.Yellow
            colorizerColorItem3.Color = System.Drawing.Color.Red
            choroplethColorizer1.ColorItems.Add(colorizerColorItem1)
            choroplethColorizer1.ColorItems.Add(colorizerColorItem2)
            choroplethColorizer1.ColorItems.Add(colorizerColorItem3)
            choroplethColorizer1.RangeDistribution = linearRangeDistribution1
            choroplethColorizer1.RangeStops.Add(0R)
            choroplethColorizer1.RangeStops.Add(22R)
            choroplethColorizer1.RangeStops.Add(56R)
            shapeAttributeValueProvider1.AttributeName = "Speed"
            choroplethColorizer1.ValueProvider = shapeAttributeValueProvider1
            Me.itemsLayer.Colorizer = choroplethColorizer1
            Me.itemsLayer.Data = Me.listSourceDataAdapter1
            Me.listSourceDataAdapter1.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Line
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(46.25R, 13.26R)
            geoMapCoordinateSystem1.CircularScrollingMode = DevExpress.XtraMap.CircularScrollingMode.TilesAndVectorItems
            Me.mapControl1.CoordinateSystem = geoMapCoordinateSystem1
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer1)
            Me.mapControl1.Layers.Add(Me.itemsLayer)
            colorScaleLegend1.DescriptionStyle.Font = New System.Drawing.Font("Tahoma", 10F)
            colorScaleLegend1.EnableGradientScale = True
            colorScaleLegend1.Header = "Wind Speed, m/s"
            colorScaleLegend1.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 12F)
            colorScaleLegend1.Layer = Me.itemsLayer
            colorScaleLegend1.Visibility = DevExpress.XtraMap.VisibilityMode.Visible
            Me.mapControl1.Legends.Add(colorScaleLegend1)
            Me.mapControl1.Location = New System.Drawing.Point(0, 256)
            Me.mapControl1.MaxZoomLevel = 8R
            Me.mapControl1.MinZoomLevel = 4R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.None
            Me.mapControl1.Size = New System.Drawing.Size(721, 389)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ZoomLevel = 4.5R
            Me.vectorItemsLayer1.Data = Me.shapefileDataAdapter1
            Me.vectorItemsLayer1.EnableHighlighting = False
            Me.vectorItemsLayer1.EnableSelection = False
            ' 
            ' MapArrows
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "MapArrows"
            Me.Size = New System.Drawing.Size(721, 645)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.Controls.SetChildIndex(Me.mapControl1, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private itemsLayer As DevExpress.XtraMap.VectorItemsLayer

        Private vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer

        Private shapefileDataAdapter1 As DevExpress.XtraMap.ShapefileDataAdapter

        Private listSourceDataAdapter1 As DevExpress.XtraMap.ListSourceDataAdapter
    End Class
End Namespace
