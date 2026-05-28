Namespace DevExpress.XtraMap.Demos

    Partial Class OpenStreetMapProvider

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
            Dim miniMap1 As DevExpress.XtraMap.MiniMap = New DevExpress.XtraMap.MiniMap()
            Dim dynamicMiniMapBehavior1 As DevExpress.XtraMap.DynamicMiniMapBehavior = New DevExpress.XtraMap.DynamicMiniMapBehavior()
            Me.MiniMapImageTilesLayer = New DevExpress.XtraMap.MiniMapImageTilesLayer()
            Me.MiniMapDataProvider = New DevExpress.XtraMap.OpenStreetMapDataProvider()
            Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
            Me.BaseProvider = New DevExpress.XtraMap.OpenStreetMapDataProvider()
            Me.OverlayLayer = New DevExpress.XtraMap.ImageLayer()
            Me.OverlayProvider = New DevExpress.XtraMap.OpenStreetMapDataProvider()
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
            Me.listBoxControl2 = New DevExpress.XtraEditors.ListBoxControl()
            Me.trackBarControl2 = New DevExpress.XtraEditors.TrackBarControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleLabelItem1 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.simpleLabelItem2 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.simpleLabelItem3 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.simpleLabelItem4 = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.tabPaneOptions = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPageOptions = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.sidePanelOptions = New DevExpress.XtraEditors.SidePanel()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.listBoxControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.trackBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.listBoxControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBarControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBarControl2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.simpleLabelItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            Me.sidePanelOptions.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.mapControl1)
            Me.panelControl1.Controls.Add(Me.sidePanelOptions)
            Me.panelControl1.Size = New System.Drawing.Size(801, 422)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(53, 51, 53, 51)
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.ribbonControl1.MaxItemId = 8
            Me.ribbonControl1.OptionsMenuMinWidth = 587
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.AccessibleName = "Search Item"
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ribbonControl1.Size = New System.Drawing.Size(801, 183)
            Me.MiniMapImageTilesLayer.DataProvider = Me.MiniMapDataProvider
            AddHandler Me.MiniMapDataProvider.WebRequest, New DevExpress.XtraMap.MapWebRequestEventHandler(AddressOf Me.OnWebRequest)
            Me.TilesLayer.DataProvider = Me.BaseProvider
            Me.TilesLayer.Name = "TilesLayer"
            AddHandler Me.BaseProvider.WebRequest, New DevExpress.XtraMap.MapWebRequestEventHandler(AddressOf Me.OnWebRequest)
            Me.OverlayLayer.DataProvider = Me.OverlayProvider
            Me.OverlayLayer.Name = "OverlayLayer"
            AddHandler Me.OverlayProvider.WebRequest, New DevExpress.XtraMap.MapWebRequestEventHandler(AddressOf Me.OnWebRequest)
            ' 
            ' listBoxControl1
            ' 
            Me.listBoxControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.listBoxControl1.HotTrackItems = True
            Me.listBoxControl1.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
            Me.listBoxControl1.Location = New System.Drawing.Point(2, 30)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(190, 106)
            Me.listBoxControl1.StyleController = Me.layoutControl1
            Me.listBoxControl1.TabIndex = 5
            AddHandler Me.listBoxControl1.SelectedValueChanged, New System.EventHandler(AddressOf Me.OnListBoxControl1_SelectedValueChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.trackBarControl1)
            Me.layoutControl1.Controls.Add(Me.listBoxControl2)
            Me.layoutControl1.Controls.Add(Me.trackBarControl2)
            Me.layoutControl1.Controls.Add(Me.listBoxControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(744, 179, 806, 536)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(194, 381)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' trackBarControl1
            ' 
            Me.trackBarControl1.EditValue = Nothing
            Me.trackBarControl1.Location = New System.Drawing.Point(2, 323)
            Me.trackBarControl1.MenuManager = Me
            Me.trackBarControl1.Name = "trackBarControl1"
            Me.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl1.Properties.Maximum = 255
            Me.trackBarControl1.Properties.ShowLabels = True
            Me.trackBarControl1.Properties.TickStyle = System.Windows.Forms.TickStyle.None
            Me.trackBarControl1.Size = New System.Drawing.Size(190, 56)
            Me.trackBarControl1.StyleController = Me.layoutControl1
            Me.trackBarControl1.TabIndex = 6
            AddHandler Me.trackBarControl1.EditValueChanged, New System.EventHandler(AddressOf Me.OnTrackBarControl1_EditValueChanged)
            ' 
            ' listBoxControl2
            ' 
            Me.listBoxControl2.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.listBoxControl2.HotTrackItems = True
            Me.listBoxControl2.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick
            Me.listBoxControl2.Location = New System.Drawing.Point(2, 240)
            Me.listBoxControl2.Name = "listBoxControl2"
            Me.listBoxControl2.Size = New System.Drawing.Size(190, 59)
            Me.listBoxControl2.StyleController = Me.layoutControl1
            Me.listBoxControl2.TabIndex = 5
            AddHandler Me.listBoxControl2.SelectedValueChanged, New System.EventHandler(AddressOf Me.OnListBoxControl2_SelectedValueChanged)
            ' 
            ' trackBarControl2
            ' 
            Me.trackBarControl2.EditValue = Nothing
            Me.trackBarControl2.Location = New System.Drawing.Point(2, 160)
            Me.trackBarControl2.Name = "trackBarControl2"
            Me.trackBarControl2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.trackBarControl2.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl2.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl2.Properties.Maximum = 255
            Me.trackBarControl2.Properties.TickStyle = System.Windows.Forms.TickStyle.None
            Me.trackBarControl2.Size = New System.Drawing.Size(190, 56)
            Me.trackBarControl2.StyleController = Me.layoutControl1
            Me.trackBarControl2.TabIndex = 6
            AddHandler Me.trackBarControl2.EditValueChanged, New System.EventHandler(AddressOf Me.OnTrackBarControl2_EditValueChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem4, Me.simpleLabelItem1, Me.simpleLabelItem2, Me.layoutControlItem3, Me.simpleLabelItem3, Me.simpleLabelItem4})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(194, 381)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.listBoxControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 28)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(194, 110)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.trackBarControl2
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 158)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(194, 60)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.trackBarControl1
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 321)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(194, 60)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' simpleLabelItem1
            ' 
            Me.simpleLabelItem1.AllowHotTrack = False
            Me.simpleLabelItem1.Location = New System.Drawing.Point(0, 0)
            Me.simpleLabelItem1.Name = "simpleLabelItem1"
            Me.simpleLabelItem1.Size = New System.Drawing.Size(194, 28)
            Me.simpleLabelItem1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 8, 0)
            Me.simpleLabelItem1.Text = "Base Layers"
            Me.simpleLabelItem1.TextSize = New System.Drawing.Size(84, 16)
            ' 
            ' simpleLabelItem2
            ' 
            Me.simpleLabelItem2.AllowHotTrack = False
            Me.simpleLabelItem2.Location = New System.Drawing.Point(0, 218)
            Me.simpleLabelItem2.Name = "simpleLabelItem2"
            Me.simpleLabelItem2.Size = New System.Drawing.Size(194, 20)
            Me.simpleLabelItem2.Text = "Overlay Layers"
            Me.simpleLabelItem2.TextSize = New System.Drawing.Size(84, 16)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.listBoxControl2
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 238)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(54, 4)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(194, 63)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' simpleLabelItem3
            ' 
            Me.simpleLabelItem3.AllowHotTrack = False
            Me.simpleLabelItem3.Location = New System.Drawing.Point(0, 138)
            Me.simpleLabelItem3.Name = "simpleLabelItem3"
            Me.simpleLabelItem3.Size = New System.Drawing.Size(194, 20)
            Me.simpleLabelItem3.Text = "Transparency"
            Me.simpleLabelItem3.TextSize = New System.Drawing.Size(84, 16)
            ' 
            ' simpleLabelItem4
            ' 
            Me.simpleLabelItem4.AllowHotTrack = False
            Me.simpleLabelItem4.Location = New System.Drawing.Point(0, 301)
            Me.simpleLabelItem4.Name = "simpleLabelItem4"
            Me.simpleLabelItem4.Size = New System.Drawing.Size(194, 20)
            Me.simpleLabelItem4.Text = "Transparency"
            Me.simpleLabelItem4.TextSize = New System.Drawing.Size(84, 16)
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(50.067R, 14.417R)
            geoMapCoordinateSystem1.CircularScrollingMode = DevExpress.XtraMap.CircularScrollingMode.TilesAndVectorItems
            Me.mapControl1.CoordinateSystem = geoMapCoordinateSystem1
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.TilesLayer)
            Me.mapControl1.Layers.Add(Me.OverlayLayer)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            miniMap1.Alignment = DevExpress.XtraMap.MiniMapAlignment.TopRight
            miniMap1.Behavior = dynamicMiniMapBehavior1
            miniMap1.Layers.Add(Me.MiniMapImageTilesLayer)
            Me.mapControl1.MiniMap = miniMap1
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(603, 422)
            Me.mapControl1.TabIndex = 4
            Me.mapControl1.ZoomLevel = 5R
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Controls.Add(Me.tabNavigationPageOptions)
            Me.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPaneOptions.Location = New System.Drawing.Point(4, 0)
            Me.tabPaneOptions.Name = "tabPaneOptions"
            Me.tabPaneOptions.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPageOptions})
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(194, 422)
            Me.tabPaneOptions.SelectedPage = Me.tabNavigationPageOptions
            Me.tabPaneOptions.Size = New System.Drawing.Size(194, 422)
            Me.tabPaneOptions.TabIndex = 8
            Me.tabPaneOptions.Text = "tabPane1"
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.BackgroundPadding = New System.Windows.Forms.Padding(0)
            Me.tabNavigationPageOptions.Caption = "Options"
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPageOptions.Name = "tabNavigationPageOptions"
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(194, 381)
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.AllowResize = False
            Me.sidePanelOptions.Controls.Add(Me.tabPaneOptions)
            Me.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanelOptions.Location = New System.Drawing.Point(603, 0)
            Me.sidePanelOptions.Name = "sidePanelOptions"
            Me.sidePanelOptions.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
            Me.sidePanelOptions.Size = New System.Drawing.Size(198, 422)
            Me.sidePanelOptions.TabIndex = 6
            ' 
            ' OpenStreetMapProvider
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
            Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.Name = "OpenStreetMapProvider"
            Me.Size = New System.Drawing.Size(801, 628)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.listBoxControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.trackBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.listBoxControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBarControl2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBarControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.simpleLabelItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            Me.sidePanelOptions.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private TilesLayer As DevExpress.XtraMap.ImageLayer

        Private BaseProvider As DevExpress.XtraMap.OpenStreetMapDataProvider

        Private OverlayLayer As DevExpress.XtraMap.ImageLayer

        Private OverlayProvider As DevExpress.XtraMap.OpenStreetMapDataProvider

        Private MiniMapDataProvider As DevExpress.XtraMap.OpenStreetMapDataProvider

        Private MiniMapImageTilesLayer As DevExpress.XtraMap.MiniMapImageTilesLayer

        Private mapControl1 As DevExpress.XtraMap.MapControl

        Protected sidePanelOptions As DevExpress.XtraEditors.SidePanel

        Protected tabPaneOptions As DevExpress.XtraBars.Navigation.TabPane

        Protected tabNavigationPageOptions As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl

        Private trackBarControl2 As DevExpress.XtraEditors.TrackBarControl

        Private listBoxControl2 As DevExpress.XtraEditors.ListBoxControl

        Private trackBarControl1 As DevExpress.XtraEditors.TrackBarControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private simpleLabelItem1 As DevExpress.XtraLayout.SimpleLabelItem

        Private simpleLabelItem2 As DevExpress.XtraLayout.SimpleLabelItem

        Private simpleLabelItem3 As DevExpress.XtraLayout.SimpleLabelItem

        Private simpleLabelItem4 As DevExpress.XtraLayout.SimpleLabelItem
    End Class
End Namespace
