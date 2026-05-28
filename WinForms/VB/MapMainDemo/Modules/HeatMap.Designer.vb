Namespace DevExpress.XtraMap.Demos

    Partial Class HeatMap

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

            'this.isActive = false;
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim heatmapDensityBasedAlgorithm1 As DevExpress.XtraMap.HeatmapDensityBasedAlgorithm = New DevExpress.XtraMap.HeatmapDensityBasedAlgorithm()
            Dim heatmapDataSourceAdapter1 As DevExpress.XtraMap.HeatmapDataSourceAdapter = New DevExpress.XtraMap.HeatmapDataSourceAdapter()
            Dim colorScaleLegend1 As DevExpress.XtraMap.ColorScaleLegend = New DevExpress.XtraMap.ColorScaleLegend()
            Dim trackBarLabel1 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel2 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.heatmapProvider1 = New DevExpress.XtraMap.HeatmapProvider()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.imageLayer2 = New DevExpress.XtraMap.ImageLayer()
            Me.AzureMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.sidePanelOptions = New DevExpress.XtraEditors.SidePanel()
            Me.tabPaneOptions = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPageOptions = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.mfTrackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
            Me.paletteRadioGroup = New DevExpress.XtraEditors.RadioGroup()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.mfTrackBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mfTrackBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.paletteRadioGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.mapControl1)
            Me.panelControl1.Controls.Add(Me.sidePanelOptions)
            Me.panelControl1.Size = New System.Drawing.Size(581, 291)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.ribbonControl1.MaxItemId = 8
            Me.ribbonControl1.OptionsMenuMinWidth = 440
            ' 
            ' 
            ' 
            Me.ribbonControl1.SearchEditItem.AccessibleName = "Search Item"
            Me.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
            Me.ribbonControl1.SearchEditItem.EditWidth = 150
            Me.ribbonControl1.SearchEditItem.Id = -5000
            Me.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.ribbonControl1.Size = New System.Drawing.Size(581, 150)
            Me.imageLayer1.DataProvider = Me.heatmapProvider1
            Me.imageLayer1.Transparency =(CByte((50)))
            Me.imageLayer1.ZIndex = 1
            heatmapDensityBasedAlgorithm1.PointRadius = 8
            Me.heatmapProvider1.Algorithm = heatmapDensityBasedAlgorithm1
            heatmapDataSourceAdapter1.Mappings.XCoordinate = "glon"
            heatmapDataSourceAdapter1.Mappings.YCoordinate = "glat"
            Me.heatmapProvider1.PointSource = heatmapDataSourceAdapter1
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.EnableRotation = False
            Me.mapControl1.Layers.Add(Me.imageLayer1)
            Me.mapControl1.Layers.Add(Me.imageLayer2)
            colorScaleLegend1.EnableGradientScale = True
            colorScaleLegend1.Header = "Seismic Density"
            colorScaleLegend1.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 10F)
            colorScaleLegend1.Layer = Me.imageLayer1
            Me.mapControl1.Legends.Add(colorScaleLegend1)
            Me.mapControl1.Location = New System.Drawing.Point(0, 0)
            Me.mapControl1.MapEditor.AllowSaveActions = False
            Me.mapControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.[Single]
            Me.mapControl1.Size = New System.Drawing.Size(365, 291)
            Me.mapControl1.TabIndex = 1
            Me.mapControl1.ZoomLevel = 3R
            AddHandler Me.mapControl1.LegendItemCreating, New DevExpress.XtraMap.LegendItemCreatingEventHandler(AddressOf Me.OnLegendItemCreating)
            Me.imageLayer2.DataProvider = Me.AzureMapDataProvider
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.AllowResize = False
            Me.sidePanelOptions.Controls.Add(Me.tabPaneOptions)
            Me.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanelOptions.Location = New System.Drawing.Point(365, 0)
            Me.sidePanelOptions.Name = "sidePanelOptions"
            Me.sidePanelOptions.Size = New System.Drawing.Size(216, 291)
            Me.sidePanelOptions.TabIndex = 6
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Controls.Add(Me.tabNavigationPageOptions)
            Me.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPaneOptions.Location = New System.Drawing.Point(1, 0)
            Me.tabPaneOptions.Name = "tabPaneOptions"
            Me.tabPaneOptions.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPageOptions})
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(215, 291)
            Me.tabPaneOptions.SelectedPage = Me.tabNavigationPageOptions
            Me.tabPaneOptions.Size = New System.Drawing.Size(215, 291)
            Me.tabPaneOptions.TabIndex = 0
            Me.tabPaneOptions.Text = "tabPane1"
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.BackgroundPadding = New System.Windows.Forms.Padding(0)
            Me.tabNavigationPageOptions.Caption = "Options"
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPageOptions.Name = "tabNavigationPageOptions"
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(215, 258)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.mfTrackBarControl1)
            Me.layoutControl1.Controls.Add(Me.paletteRadioGroup)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(215, 258)
            Me.layoutControl1.TabIndex = 5
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' mfTrackBarControl1
            ' 
            Me.mfTrackBarControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.mfTrackBarControl1.EditValue = 8
            Me.mfTrackBarControl1.Location = New System.Drawing.Point(7, 30)
            Me.mfTrackBarControl1.Name = "mfTrackBarControl1"
            Me.mfTrackBarControl1.Properties.AutoSize = False
            Me.mfTrackBarControl1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mfTrackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.mfTrackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            trackBarLabel1.Label = "2"
            trackBarLabel1.Value = 2
            trackBarLabel2.Label = "20"
            trackBarLabel2.Value = 20
            Me.mfTrackBarControl1.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {trackBarLabel1, trackBarLabel2})
            Me.mfTrackBarControl1.Properties.Maximum = 20
            Me.mfTrackBarControl1.Properties.Minimum = 2
            Me.mfTrackBarControl1.Properties.ShowLabels = True
            Me.mfTrackBarControl1.Properties.TickStyle = System.Windows.Forms.TickStyle.None
            Me.mfTrackBarControl1.Size = New System.Drawing.Size(201, 46)
            Me.mfTrackBarControl1.StyleController = Me.layoutControl1
            Me.mfTrackBarControl1.TabIndex = 2
            Me.mfTrackBarControl1.Value = 8
            AddHandler Me.mfTrackBarControl1.EditValueChanged, New System.EventHandler(AddressOf Me.OnTrackBarControlEditValueChanged)
            ' 
            ' paletteRadioGroup
            ' 
            Me.paletteRadioGroup.Location = New System.Drawing.Point(11, 111)
            Me.paletteRadioGroup.Name = "paletteRadioGroup"
            Me.paletteRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.paletteRadioGroup.Properties.Appearance.Options.UseBackColor = True
            Me.paletteRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.paletteRadioGroup.Properties.ColumnIndent = 0
            Me.paletteRadioGroup.Properties.Columns = 1
            Me.paletteRadioGroup.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.paletteRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Default"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Hot"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Cold")})
            Me.paletteRadioGroup.Properties.Padding = New System.Windows.Forms.Padding(0)
            Me.paletteRadioGroup.Size = New System.Drawing.Size(193, 72)
            Me.paletteRadioGroup.StyleController = Me.layoutControl1
            Me.paletteRadioGroup.TabIndex = 4
            AddHandler Me.paletteRadioGroup.SelectedIndexChanged, New System.EventHandler(AddressOf Me.OnPaletteTypeSelectedIndexChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1, Me.emptySpaceItem1, Me.layoutControlGroup2})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(215, 258)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 6, 5)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(215, 83)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Point Radius"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.mfTrackBarControl1
            Me.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(0, 50)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(90, 14)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(205, 50)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 190)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(215, 68)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 83)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 5)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(215, 107)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Palette"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.paletteRadioGroup
            Me.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(197, 76)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' HeatMap
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "HeatMap"
            Me.Size = New System.Drawing.Size(581, 459)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.mfTrackBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mfTrackBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.paletteRadioGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Protected sidePanelOptions As DevExpress.XtraEditors.SidePanel

        Protected tabPaneOptions As DevExpress.XtraBars.Navigation.TabPane

        Protected tabNavigationPageOptions As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private imageLayer1 As DevExpress.XtraMap.ImageLayer

        Private heatmapProvider1 As DevExpress.XtraMap.HeatmapProvider

        Private imageLayer2 As DevExpress.XtraMap.ImageLayer

        Private AzureMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider

        Private mfTrackBarControl1 As DevExpress.XtraEditors.TrackBarControl

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private paletteRadioGroup As DevExpress.XtraEditors.RadioGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
