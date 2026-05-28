Namespace DevExpress.XtraMap.Demos

    Partial Class ItemsMoving

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
            Dim geoMapCoordinateSystem1 As DevExpress.XtraMap.GeoMapCoordinateSystem = New DevExpress.XtraMap.GeoMapCoordinateSystem()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraMap.Demos.ItemsMoving))
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.AzureMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.vectorItemsLayer3 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.shapefileDataAdapter1 = New DevExpress.XtraMap.ShapefileDataAdapter()
            Me.solveLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.mapItemStorage2 = New DevExpress.XtraMap.MapItemStorage()
            Me.mazeLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.mazeData = New DevExpress.XtraMap.MapItemStorage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonItem1})
            Me.ribbonControl1.MaxItemId = 8
            ' 
            ' rpOptions
            ' 
            Me.rpOptions.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            geoMapCoordinateSystem1.CircularScrollingMode = DevExpress.XtraMap.CircularScrollingMode.TilesAndVectorItems
            Me.mapControl1.CoordinateSystem = geoMapCoordinateSystem1
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.imageLayer1)
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer3)
            Me.mapControl1.Layers.Add(Me.solveLayer)
            Me.mapControl1.Layers.Add(Me.mazeLayer)
            Me.mapControl1.Location = New System.Drawing.Point(0, 141)
            Me.mapControl1.MinZoomLevel = 2R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.[Single]
            Me.mapControl1.Size = New System.Drawing.Size(500, 359)
            Me.mapControl1.TabIndex = 1
            Me.mapControl1.ZoomLevel = 3R
            Me.mapControl1.EnableRotation = False
            AddHandler Me.mapControl1.SelectionChanged, New DevExpress.XtraMap.MapSelectionChangedEventHandler(AddressOf Me.mapControl1_SelectionChanged)
            AddHandler Me.mapControl1.OverlaysArranged, New DevExpress.XtraMap.OverlaysArrangedEventHandler(AddressOf Me.mapControl1_OverlaysArranged)
            AddHandler Me.mapControl1.MouseUp, New System.Windows.Forms.MouseEventHandler(AddressOf Me.mapControl1_MouseUp)
            Me.imageLayer1.DataProvider = Me.AzureMapDataProvider
            Me.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad
            Me.vectorItemsLayer3.AllowEditItems = False
            Me.vectorItemsLayer3.Data = Me.shapefileDataAdapter1
            Me.vectorItemsLayer3.EnableHighlighting = False
            Me.vectorItemsLayer3.EnableSelection = False
            Me.vectorItemsLayer3.ItemStyle.Fill = System.Drawing.Color.Transparent
            Me.vectorItemsLayer3.ItemStyle.StrokeWidth = 0
            Me.vectorItemsLayer3.Name = "ShapesLayer"
            Me.vectorItemsLayer3.ShapeTitlesPattern = ""
            AddHandler Me.shapefileDataAdapter1.ItemsLoaded, New DevExpress.XtraMap.ItemsLoadedEventHandler(AddressOf Me.shapefileDataAdapter1_ItemsLoaded)
            Me.solveLayer.AllowEditItems = False
            Me.solveLayer.Data = Me.mapItemStorage2
            Me.solveLayer.EnableHighlighting = False
            Me.solveLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb((CInt(((CByte((128)))))), (CInt(((CByte((0)))))), (CInt(((CByte((128)))))), (CInt(((CByte((0)))))))
            Me.solveLayer.Name = "SolveLayer"
            Me.mazeLayer.Data = Me.mazeData
            Me.mazeLayer.HighlightedItemStyle.StrokeWidth = 3
            Me.mazeLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((255)))))), (CInt(((CByte((0)))))), (CInt(((CByte((0)))))))
            Me.mazeLayer.ItemStyle.StrokeWidth = 2
            Me.mazeLayer.Name = "MazeLayer"
            Me.mazeLayer.ShapeTitlesPattern = ""
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Game"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Restart Game"
            Me.barButtonItem1.Id = 7
            Me.barButtonItem1.ImageOptions.SvgImage = CType((resources.GetObject("barButtonItem1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.barButtonItem1.Name = "barButtonItem1"
            AddHandler Me.barButtonItem1.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.barButtonItem1_ItemClick)
            ' 
            ' ItemsMoving
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.panelControl1.Controls.Add(Me.mapControl1)
            Me.Name = "ItemsMoving"
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.panelControl1.Controls.SetChildIndex(Me.mapControl1, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private imageLayer1 As DevExpress.XtraMap.ImageLayer

        Private AzureMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider

        Private mazeLayer As DevExpress.XtraMap.VectorItemsLayer

        Private mazeData As DevExpress.XtraMap.MapItemStorage

        Private solveLayer As DevExpress.XtraMap.VectorItemsLayer

        Private mapItemStorage2 As DevExpress.XtraMap.MapItemStorage

        Private vectorItemsLayer3 As DevExpress.XtraMap.VectorItemsLayer

        Private shapefileDataAdapter1 As DevExpress.XtraMap.ShapefileDataAdapter

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    End Class
End Namespace
