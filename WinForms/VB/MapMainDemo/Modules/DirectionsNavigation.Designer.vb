Namespace DevExpress.XtraMap.Demos

    Partial Class DirectionsNavigation

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

            Me.OnDispose()
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraMap.Demos.DirectionsNavigation))
            Me.TileLayer = New DevExpress.XtraMap.ImageLayer()
            Me.AzureMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.RouteLayer = New DevExpress.XtraMap.InformationLayer()
            Me.RouteProvider = New DevExpress.XtraMap.AzureRouteDataProvider()
            Me.GeocodeLayer = New DevExpress.XtraMap.InformationLayer()
            Me.GeoCodeProvider = New DevExpress.XtraMap.AzureGeocodeDataProvider()
            Me.SearchLayer = New DevExpress.XtraMap.InformationLayer()
            Me.SearchProvider = New DevExpress.XtraMap.AzureSearchDataProvider()
            Me.ItemsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.DataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.directionIcon = New DevExpress.XtraMap.Demos.DirectionIcon()
            Me.driveButton = New DevExpress.XtraBars.BarButtonItem()
            Me.clearButton = New DevExpress.XtraBars.BarButtonItem()
            Me.stopButton = New DevExpress.XtraBars.BarButtonItem()
            Me.actionPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.barDeleteButton = New DevExpress.XtraBars.BarButtonItem()
            Me.barCloseButton = New DevExpress.XtraBars.BarButtonItem()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.directionIcon.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.directionIcon)
            Me.panelControl1.Controls.Add(Me.mapControl1)
            Me.panelControl1.Size = New System.Drawing.Size(601, 463)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.clearButton, Me.driveButton, Me.stopButton})
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ribbonControl1.Size = New System.Drawing.Size(601, 150)
            ' 
            ' rpOptions
            ' 
            Me.rpOptions.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.actionPageGroup})
            Me.TileLayer.DataProvider = Me.AzureMapDataProvider
            Me.TileLayer.Name = "TilesLayer"
            Me.RouteLayer.DataProvider = Me.RouteProvider
            Me.RouteLayer.EnableHighlighting = False
            Me.RouteLayer.Name = "RouteLayer"
            AddHandler Me.RouteProvider.RouteCalculated, New DevExpress.XtraMap.AzureRouteCalculatedEventHandler(AddressOf Me.OnRouteCalculated)
            AddHandler Me.RouteProvider.LayerItemsGenerating, New DevExpress.XtraMap.LayerItemsGeneratingEventHandler(AddressOf Me.OnRouteLayerItemsGenerating)
            Me.GeocodeLayer.DataProvider = Me.GeoCodeProvider
            Me.GeocodeLayer.Name = "GeocodeLayer"
            Me.GeoCodeProvider.MaxVisibleResultCount = 1
            Me.GeoCodeProvider.ProcessMouseEvents = True
            AddHandler Me.GeoCodeProvider.LayerItemsGenerating, New DevExpress.XtraMap.LayerItemsGeneratingEventHandler(AddressOf Me.OnGeoCodeAndSearchLayerItemsGenerating)
            Me.SearchLayer.DataProvider = Me.SearchProvider
            Me.SearchLayer.Name = "SearchLayer"
            AddHandler Me.SearchProvider.LayerItemsGenerating, New DevExpress.XtraMap.LayerItemsGeneratingEventHandler(AddressOf Me.OnGeoCodeAndSearchLayerItemsGenerating)
            Me.ItemsLayer.Data = Me.DataAdapter
            Me.ItemsLayer.Name = "ItemsLayer"
            Me.DataAdapter.Mappings.Latitude = "Latitude"
            Me.DataAdapter.Mappings.Longitude = "Longitude"
            Me.DataAdapter.Mappings.Text = "Text"
            Me.DataAdapter.Mappings.Type = "Type"
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(34.158506R, -118.255629R)
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.TileLayer)
            Me.mapControl1.Layers.Add(Me.RouteLayer)
            Me.mapControl1.Layers.Add(Me.GeocodeLayer)
            Me.mapControl1.Layers.Add(Me.SearchLayer)
            Me.mapControl1.Layers.Add(Me.ItemsLayer)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.Size = New System.Drawing.Size(601, 463)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ToolTipController = Me.toolTipController1
            Me.mapControl1.ZoomLevel = 14R
            AddHandler Me.mapControl1.MapItemClick, New DevExpress.XtraMap.MapItemClickEventHandler(AddressOf Me.OnMapItemClick)
            ' 
            ' pictureEdit1
            ' 
            Me.directionIcon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.directionIcon.EditValue =(CObj((resources.GetObject("pictureEdit1.EditValue"))))
            Me.directionIcon.Location = New System.Drawing.Point(222, 169)
            Me.directionIcon.MenuManager = Me
            Me.directionIcon.Name = "pictureEdit1"
            Me.directionIcon.Properties.AllowFocused = False
            Me.directionIcon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.directionIcon.Properties.ShowMenu = False
            Me.directionIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
            Me.directionIcon.Size = New System.Drawing.Size(36, 36)
            Me.directionIcon.TabIndex = 1
            Me.directionIcon.Visible = False
            AddHandler Me.directionIcon.MouseClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.OnPictureEdit1MouseClick)
            ' 
            ' driveButton
            ' 
            Me.driveButton.Caption = "Drive"
            Me.driveButton.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.driveButton.Enabled = False
            Me.driveButton.Id = 1
            Me.driveButton.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Action_Debug_Start
            Me.driveButton.Name = "driveButton"
            AddHandler Me.driveButton.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnDriveButtonClick)
            ' 
            ' clearButton
            ' 
            Me.clearButton.Caption = "Clear"
            Me.clearButton.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.clearButton.Id = 2
            Me.clearButton.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Clear
            Me.clearButton.Name = "clearButton"
            AddHandler Me.clearButton.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnClearButtonClick)
            ' 
            ' stopButton
            ' 
            Me.stopButton.Caption = "Stop"
            Me.stopButton.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.stopButton.Enabled = False
            Me.stopButton.Id = 3
            Me.stopButton.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.[Stop]
            Me.stopButton.Name = "stopButton"
            AddHandler Me.stopButton.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnStopButtonClick)
            ' 
            ' actionPageGroup
            ' 
            Me.actionPageGroup.ItemLinks.Add(Me.clearButton)
            Me.actionPageGroup.ItemLinks.Add(Me.driveButton)
            Me.actionPageGroup.ItemLinks.Add(Me.stopButton)
            Me.actionPageGroup.Name = "actionPageGroup"
            Me.actionPageGroup.Text = "Actions"
            ' 
            ' popupMenu1
            ' 
            Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barDeleteButton), New DevExpress.XtraBars.LinkPersistInfo(Me.barCloseButton)})
            Me.popupMenu1.Manager = Me.barManager1
            Me.popupMenu1.Name = "popupMenu1"
            ' 
            ' barDeleteButton
            ' 
            Me.barDeleteButton.Caption = "Delete"
            Me.barDeleteButton.Description = "Delete way point from route"
            Me.barDeleteButton.Id = 0
            Me.barDeleteButton.Name = "barDeleteButton"
            AddHandler Me.barDeleteButton.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnBarDeleteButtonClick)
            ' 
            ' barCloseButton
            ' 
            Me.barCloseButton.Caption = "Close"
            Me.barCloseButton.Description = "Cancel operation"
            Me.barCloseButton.Id = 1
            Me.barCloseButton.Name = "barCloseButton"
            AddHandler Me.barCloseButton.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnBarCloseButtonClick)
            ' 
            ' barManager1
            ' 
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barDeleteButton, Me.barCloseButton})
            Me.barManager1.MaxItemId = 2
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(601, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 480)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(601, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 480)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(601, 0)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 480)
            ' 
            ' DirectionsNavigation
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "DirectionsNavigation"
            Me.Size = New System.Drawing.Size(601, 480)
            Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
            Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
            Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
            Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.directionIcon.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private actionPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private driveButton As DevExpress.XtraBars.BarButtonItem

        Private clearButton As DevExpress.XtraBars.BarButtonItem

        Private popupMenu1 As DevExpress.XtraBars.PopupMenu

        Private barDeleteButton As DevExpress.XtraBars.BarButtonItem

        Private barCloseButton As DevExpress.XtraBars.BarButtonItem

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private stopButton As DevExpress.XtraBars.BarButtonItem

        Private TileLayer As DevExpress.XtraMap.ImageLayer

        Private RouteLayer As DevExpress.XtraMap.InformationLayer

        Private GeocodeLayer As DevExpress.XtraMap.InformationLayer

        Private SearchLayer As DevExpress.XtraMap.InformationLayer

        Private ItemsLayer As DevExpress.XtraMap.VectorItemsLayer

        Private DataAdapter As DevExpress.XtraMap.ListSourceDataAdapter

        Private RouteProvider As DevExpress.XtraMap.AzureRouteDataProvider

        Private GeoCodeProvider As DevExpress.XtraMap.AzureGeocodeDataProvider

        Private SearchProvider As DevExpress.XtraMap.AzureSearchDataProvider

        Private AzureMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private directionIcon As DevExpress.XtraMap.Demos.DirectionIcon
    End Class
End Namespace
