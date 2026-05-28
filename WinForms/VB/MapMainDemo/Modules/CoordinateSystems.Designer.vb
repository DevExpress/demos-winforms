Namespace DevExpress.XtraMap.Demos

    Partial Class CoordinateSystems

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
            Me.OnDispose()
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim keyColorColorizer1 As DevExpress.XtraMap.KeyColorColorizer = New DevExpress.XtraMap.KeyColorColorizer()
            Dim attributeItemKeyProvider1 As DevExpress.XtraMap.AttributeItemKeyProvider = New DevExpress.XtraMap.AttributeItemKeyProvider()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraMap.Demos.CoordinateSystems))
            Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
            Me.AzureImageryMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.HotelPlanLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.HotelsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.HotelsItemStorage = New DevExpress.XtraMap.MapItemStorage()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.AzureLabelsMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.mapControl1)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.TilesLayer.DataProvider = Me.AzureImageryMapDataProvider
            Me.TilesLayer.Name = "TilesLayer"
            attributeItemKeyProvider1.AttributeName = "CATEGORY"
            keyColorColorizer1.ItemKeyProvider = attributeItemKeyProvider1
            keyColorColorizer1.PredefinedColorSchema = DevExpress.XtraMap.PredefinedColorSchema.Palette
            Me.HotelPlanLayer.Colorizer = keyColorColorizer1
            Me.HotelPlanLayer.EnableSelection = False
            Me.HotelPlanLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb((CInt(((CByte((128)))))), (CInt(((CByte((128)))))), (CInt(((CByte((128)))))), (CInt(((CByte((128)))))))
            Me.HotelPlanLayer.ItemStyle.Stroke = System.Drawing.Color.FromArgb((CInt(((CByte((128)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))))
            Me.HotelPlanLayer.Name = "HotelPlanLayer"
            Me.HotelPlanLayer.ToolTipPattern = "{NAME}"
            Me.HotelPlanLayer.Visible = False
            AddHandler Me.HotelPlanLayer.DataLoaded, New DevExpress.XtraMap.DataLoadedEventHandler(AddressOf Me.HotelPlanLayer_DataLoaded)
            Me.HotelsLayer.Data = Me.HotelsItemStorage
            Me.HotelsLayer.HighlightedItemStyle.TextColor = System.Drawing.Color.White
            Me.HotelsLayer.HighlightedItemStyle.TextGlowColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((117)))))), (CInt(((CByte((0)))))))
            Me.HotelsLayer.Name = "HotelsOnMapLayer"
            Me.HotelsLayer.SelectedItemStyle.TextColor = System.Drawing.Color.White
            Me.HotelsLayer.SelectedItemStyle.TextGlowColor = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((117)))))), (CInt(((CByte((0)))))))
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(-21.1685R, -175.1343R)
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.ImageList = Me.imageCollection1
            Me.mapControl1.Layers.Add(Me.TilesLayer)
            Me.mapControl1.Layers.Add(Me.imageLayer1)
            Me.mapControl1.Layers.Add(Me.HotelsLayer)
            Me.mapControl1.Layers.Add(Me.HotelPlanLayer)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.MaxZoomLevel = 15R
            Me.mapControl1.MinZoomLevel = 13R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(500, 332)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ToolTipController = Me.toolTipController1
            Me.mapControl1.ZoomLevel = 13R
            AddHandler Me.mapControl1.DrawMapItem, New DevExpress.XtraMap.DrawMapItemEventHandler(AddressOf Me.mapControl1_DrawMapItem)
            AddHandler Me.mapControl1.MapItemClick, New DevExpress.XtraMap.MapItemClickEventHandler(AddressOf Me.mapControl1_MapItemClick)
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageSize = New System.Drawing.Size(83, 93)
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.Images.SetKeyName(0, "Hotel_1.png")
            Me.imageCollection1.Images.SetKeyName(1, "Hotel_2.png")
            Me.imageCollection1.Images.SetKeyName(2, "Hotel_3.png")
            Me.imageCollection1.Images.SetKeyName(3, "Hotel_1_h.png")
            Me.imageCollection1.Images.SetKeyName(4, "Hotel_2_h.png")
            Me.imageCollection1.Images.SetKeyName(5, "Hotel_3_h.png")
            Me.imageLayer1.DataProvider = Me.AzureLabelsMapDataProvider
            Me.AzureLabelsMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseLabelsRoad
            ' 
            ' toolTipController1
            ' 
            AddHandler Me.toolTipController1.BeforeShow, New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(AddressOf Me.toolTipController1_BeforeShow)
            ' 
            ' imageCollection2
            ' 
            Me.imageCollection2.ImageSize = New System.Drawing.Size(31, 31)
            Me.imageCollection2.ImageStream = CType((resources.GetObject("imageCollection2.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection2.Images.SetKeyName(0, "back_btn_2.png")
            ' 
            ' CoordinateSystems
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "CoordinateSystems"
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private imageCollection2 As DevExpress.Utils.ImageCollection

        Private TilesLayer As DevExpress.XtraMap.ImageLayer

        Private HotelPlanLayer As DevExpress.XtraMap.VectorItemsLayer

        Private HotelsLayer As DevExpress.XtraMap.VectorItemsLayer

        Private AzureImageryMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider

        Private AzureLabelsMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider

        Private HotelsItemStorage As DevExpress.XtraMap.MapItemStorage

        Private imageLayer1 As DevExpress.XtraMap.ImageLayer
    End Class
End Namespace
