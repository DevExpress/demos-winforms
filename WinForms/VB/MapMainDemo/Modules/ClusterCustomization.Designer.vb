Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraMap.Demos

    Partial Class ClusterCustomization

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
            Me.components = New System.ComponentModel.Container()
            Dim mouseHoverInteractiveClusterMode1 As DevExpress.XtraMap.MouseHoverInteractiveClusterMode = New DevExpress.XtraMap.MouseHoverInteractiveClusterMode()
            Dim mapOverlay1 As DevExpress.XtraMap.MapOverlay = New DevExpress.XtraMap.MapOverlay()
            Dim mapOverlayTextItem1 As DevExpress.XtraMap.MapOverlayTextItem = New DevExpress.XtraMap.MapOverlayTextItem()
            Dim mapItemAttributeMapping1 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping2 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping3 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping4 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping5 As DevExpress.XtraMap.MapItemAttributeMapping = New DevExpress.XtraMap.MapItemAttributeMapping()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.BackgroundLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.ShapefileAdapter = New DevExpress.XtraMap.ShapefileDataAdapter()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.ItemsDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.ItemsClusterer = New DevExpress.XtraMap.DistanceBasedClusterer()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.AccessibleName = "Search Item"
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ribbonControl1.Size = New System.Drawing.Size(1117, 256)
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(38R, -98R)
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.InteractiveClusterMode = mouseHoverInteractiveClusterMode1
            Me.mapControl1.Layers.Add(Me.BackgroundLayer)
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer1)
            Me.mapControl1.Location = New System.Drawing.Point(0, 256)
            Me.mapControl1.MaxZoomLevel = 9R
            Me.mapControl1.MinZoomLevel = 4R
            Me.mapControl1.Name = "mapControl1"
            mapOverlayTextItem1.Text = "Top Ranked US Universities"
            mapOverlayTextItem1.TextStyle.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            mapOverlay1.Items.Add(mapOverlayTextItem1)
            mapOverlay1.Margin = New System.Windows.Forms.Padding(6, 6, 0, 0)
            mapOverlay1.Padding = New System.Windows.Forms.Padding(4)
            Me.mapControl1.Overlays.Add(mapOverlay1)
            Me.mapControl1.ScrollArea = New DevExpress.Map.MapBounds(-155R, 63R, -50R, 20R)
            Me.mapControl1.Size = New System.Drawing.Size(1117, 648)
            Me.mapControl1.TabIndex = 2
            Me.mapControl1.ZoomLevel = 5R
            Me.BackgroundLayer.Data = Me.ShapefileAdapter
            Me.BackgroundLayer.EnableHighlighting = False
            Me.BackgroundLayer.EnableSelection = False
            Me.BackgroundLayer.ShapeTitlesVisibility = DevExpress.XtraMap.VisibilityMode.Hidden
            Me.vectorItemsLayer1.Data = Me.ItemsDataAdapter
            mapItemAttributeMapping1.Member = "Name"
            mapItemAttributeMapping1.Name = "Name"
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            mapItemAttributeMapping2.Member = "City"
            mapItemAttributeMapping2.Name = "City"
            mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            mapItemAttributeMapping3.Member = "State"
            mapItemAttributeMapping3.Name = "State"
            mapItemAttributeMapping3.ValueType = DevExpress.XtraMap.FieldValueType.[String]
            mapItemAttributeMapping4.Member = "InfoUri"
            mapItemAttributeMapping4.Name = "Info"
            mapItemAttributeMapping5.Member = "SiteUri"
            mapItemAttributeMapping5.Name = "Site"
            Me.ItemsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1)
            Me.ItemsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2)
            Me.ItemsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping3)
            Me.ItemsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping4)
            Me.ItemsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping5)
            Me.ItemsDataAdapter.Clusterer = Me.ItemsClusterer
            Me.ItemsDataAdapter.DefaultMapItemType = DevExpress.XtraMap.MapItemType.Pushpin
            Me.ItemsDataAdapter.Mappings.Latitude = "Lat"
            Me.ItemsDataAdapter.Mappings.Longitude = "Lon"
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
            Me.svgImageCollection1.Add("bo_address", "image://svgimages/business objects/bo_address.svg")
            ' 
            ' ClusterCustomization
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "ClusterCustomization"
            Me.Size = New System.Drawing.Size(1117, 904)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.Controls.SetChildIndex(Me.mapControl1, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private BackgroundLayer As DevExpress.XtraMap.VectorItemsLayer

        Private ShapefileAdapter As DevExpress.XtraMap.ShapefileDataAdapter

        Private vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer

        Private ItemsDataAdapter As DevExpress.XtraMap.ListSourceDataAdapter

        Private ItemsClusterer As DevExpress.XtraMap.DistanceBasedClusterer

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
