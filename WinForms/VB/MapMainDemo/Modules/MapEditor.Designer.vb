Namespace DevExpress.XtraMap.Demos

    Partial Class MapEditorDemo

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
            Dim colorListLegend1 As DevExpress.XtraMap.ColorListLegend = New DevExpress.XtraMap.ColorListLegend()
            Dim colorLegendItem1 As DevExpress.XtraMap.ColorLegendItem = New DevExpress.XtraMap.ColorLegendItem()
            Dim colorLegendItem2 As DevExpress.XtraMap.ColorLegendItem = New DevExpress.XtraMap.ColorLegendItem()
            Dim colorLegendItem3 As DevExpress.XtraMap.ColorLegendItem = New DevExpress.XtraMap.ColorLegendItem()
            Dim colorLegendItem4 As DevExpress.XtraMap.ColorLegendItem = New DevExpress.XtraMap.ColorLegendItem()
            Dim colorLegendItem5 As DevExpress.XtraMap.ColorLegendItem = New DevExpress.XtraMap.ColorLegendItem()
            Dim colorLegendItem6 As DevExpress.XtraMap.ColorLegendItem = New DevExpress.XtraMap.ColorLegendItem()
            Dim colorLegendItem7 As DevExpress.XtraMap.ColorLegendItem = New DevExpress.XtraMap.ColorLegendItem()
            Dim mapOverlay1 As DevExpress.XtraMap.MapOverlay = New DevExpress.XtraMap.MapOverlay()
            Dim mapOverlayTextItem1 As DevExpress.XtraMap.MapOverlayTextItem = New DevExpress.XtraMap.MapOverlayTextItem()
            Dim mapOverlay2 As DevExpress.XtraMap.MapOverlay = New DevExpress.XtraMap.MapOverlay()
            Dim mapOverlayTextItem2 As DevExpress.XtraMap.MapOverlayTextItem = New DevExpress.XtraMap.MapOverlayTextItem()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.AzureMapDataProvider = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.kmlFileDataAdapter1 = New DevExpress.XtraMap.KmlFileDataAdapter()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.fillEdit = New DevExpress.XtraEditors.ColorPickEdit()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ExportBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
            Me.strokeEdit = New DevExpress.XtraEditors.ColorPickEdit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.fillEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.strokeEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.EmptyAreaImageOptions.ImagePadding = New System.Windows.Forms.Padding(40, 39, 40, 39)
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ExportBarButtonItem})
            Me.ribbonControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
            Me.ribbonControl1.Size = New System.Drawing.Size(977, 183)
            ' 
            ' rpOptions
            ' 
            Me.rpOptions.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(26.804559994944R, 33.947806856342R)
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.imageLayer1)
            Me.mapControl1.Layers.Add(Me.vectorItemsLayer1)
            colorListLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight
            colorLegendItem1.Color = System.Drawing.Color.Gray
            colorLegendItem1.Text = "Roads/Parking"
            colorLegendItem2.Color = System.Drawing.Color.FromArgb((CInt(((CByte((192)))))), (CInt(((CByte((0)))))), (CInt(((CByte((0)))))))
            colorLegendItem2.Text = "Services"
            colorLegendItem3.Color = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((176)))))), (CInt(((CByte((80)))))))
            colorLegendItem3.Text = "Botanic Gardens"
            colorLegendItem4.Color = System.Drawing.Color.FromArgb((CInt(((CByte((0)))))), (CInt(((CByte((176)))))), (CInt(((CByte((240)))))))
            colorLegendItem4.Text = "Pools and Fountains"
            colorLegendItem5.Color = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((203)))))), (CInt(((CByte((47)))))))
            colorLegendItem5.Text = "Recreation/Play Areas"
            colorLegendItem6.Color = System.Drawing.Color.FromArgb((CInt(((CByte((196)))))), (CInt(((CByte((92)))))), (CInt(((CByte((7)))))))
            colorLegendItem6.Text = "Residential Buildings"
            colorLegendItem7.Color = System.Drawing.Color.FromArgb((CInt(((CByte((170)))))), (CInt(((CByte((0)))))), (CInt(((CByte((255)))))))
            colorLegendItem7.Text = "Reception/Restaurant"
            colorListLegend1.CustomItems.Add(colorLegendItem1)
            colorListLegend1.CustomItems.Add(colorLegendItem2)
            colorListLegend1.CustomItems.Add(colorLegendItem3)
            colorListLegend1.CustomItems.Add(colorLegendItem4)
            colorListLegend1.CustomItems.Add(colorLegendItem5)
            colorListLegend1.CustomItems.Add(colorLegendItem6)
            colorListLegend1.CustomItems.Add(colorLegendItem7)
            colorListLegend1.Header = "Resort Map"
            Me.mapControl1.Legends.Add(colorListLegend1)
            Me.mapControl1.Location = New System.Drawing.Point(0, 183)
            Me.mapControl1.MapEditor.ShowEditorPanel = True
            Me.mapControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.mapControl1.Measurements.AreaUnits = DevExpress.XtraMap.AreaMeasurementUnit.SquareMeter
            Me.mapControl1.Measurements.DistanceUnits = DevExpress.XtraMap.MeasureUnit.Meter
            Me.mapControl1.Measurements.ShowToolbar = True
            Me.mapControl1.MinZoomLevel = 17R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            mapOverlayTextItem1.Text = "Fill:"
            mapOverlay1.Items.Add(mapOverlayTextItem1)
            mapOverlay1.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
            mapOverlay1.Padding = New System.Windows.Forms.Padding(10, 10, 0, 10)
            mapOverlayTextItem2.Text = "Stroke:"
            mapOverlay2.Items.Add(mapOverlayTextItem2)
            mapOverlay2.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
            mapOverlay2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
            Me.mapControl1.Overlays.Add(mapOverlay1)
            Me.mapControl1.Overlays.Add(mapOverlay2)
            Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.[Single]
            Me.mapControl1.Size = New System.Drawing.Size(977, 471)
            Me.mapControl1.TabIndex = 1
            Me.mapControl1.ToolTipController = Me.toolTipController1
            Me.mapControl1.ZoomLevel = 18R
            AddHandler Me.mapControl1.OverlaysArranged, New DevExpress.XtraMap.OverlaysArrangedEventHandler(AddressOf Me.OnOverlaysArranged)
            Me.imageLayer1.DataProvider = Me.AzureMapDataProvider
            Me.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.Imagery
            Me.vectorItemsLayer1.Data = Me.kmlFileDataAdapter1
            Me.vectorItemsLayer1.ToolTipPattern = "{name}"
            AddHandler Me.kmlFileDataAdapter1.ItemsLoaded, New DevExpress.XtraMap.ItemsLoadedEventHandler(AddressOf Me.OnItemsLoaded)
            ' 
            ' toolTipController1
            ' 
            AddHandler Me.toolTipController1.BeforeShow, New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(AddressOf Me.BeforeShowToolTip)
            ' 
            ' fillEdit
            ' 
            Me.fillEdit.EditValue = System.Drawing.Color.FromArgb((CInt(((CByte((127)))))), (CInt(((CByte((0)))))), (CInt(((CByte((176)))))), (CInt(((CByte((80)))))))
            Me.fillEdit.Location = New System.Drawing.Point(13, 246)
            Me.fillEdit.Margin = New System.Windows.Forms.Padding(0, 0, 13, 0)
            Me.fillEdit.Name = "fillEdit"
            Me.fillEdit.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.fillEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.fillEdit.Properties.ColorDialogType = DevExpress.XtraEditors.Popup.ColorDialogType.Advanced
            Me.fillEdit.Size = New System.Drawing.Size(77, 22)
            Me.fillEdit.TabIndex = 14
            AddHandler Me.fillEdit.EditValueChanged, New System.EventHandler(AddressOf Me.OnColorEditValueChanged)
            AddHandler Me.fillEdit.CustomDisplayText, New DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(AddressOf Me.OnCustomDisplayText)
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.ExportBarButtonItem)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            ' 
            ' ExportBarButtonItem
            ' 
            Me.ExportBarButtonItem.Caption = "Save to KML"
            Me.ExportBarButtonItem.Id = 7
            Me.ExportBarButtonItem.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Export
            Me.ExportBarButtonItem.Name = "ExportBarButtonItem"
            AddHandler Me.ExportBarButtonItem.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnExportBarButtonItemClick)
            ' 
            ' strokeEdit
            ' 
            Me.strokeEdit.EditValue = System.Drawing.Color.FromArgb((CInt(((CByte((255)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))))
            Me.strokeEdit.Location = New System.Drawing.Point(95, 246)
            Me.strokeEdit.Margin = New System.Windows.Forms.Padding(0, 0, 13, 0)
            Me.strokeEdit.Name = "strokeEdit"
            Me.strokeEdit.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.strokeEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.strokeEdit.Properties.ColorDialogType = DevExpress.XtraEditors.Popup.ColorDialogType.Advanced
            Me.strokeEdit.Size = New System.Drawing.Size(77, 22)
            Me.strokeEdit.TabIndex = 39
            AddHandler Me.strokeEdit.EditValueChanged, New System.EventHandler(AddressOf Me.OnColorEditValueChanged)
            AddHandler Me.strokeEdit.CustomDisplayText, New DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(AddressOf Me.OnCustomDisplayText)
            ' 
            ' MapEditorDemo
            ' 
            Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 17F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.strokeEdit)
            Me.Controls.Add(Me.fillEdit)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panelControl1.Controls.Add(Me.mapControl1)
            Me.Name = "MapEditorDemo"
            Me.Size = New System.Drawing.Size(977, 654)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.panelControl1.Controls.SetChildIndex(Me.mapControl1, 0)
            Me.Controls.SetChildIndex(Me.fillEdit, 0)
            Me.Controls.SetChildIndex(Me.strokeEdit, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.fillEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.strokeEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private imageLayer1 As DevExpress.XtraMap.ImageLayer

        Private AzureMapDataProvider As DevExpress.XtraMap.AzureMapDataProvider

        Private fillEdit As DevExpress.XtraEditors.ColorPickEdit

        Private ExportBarButtonItem As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private strokeEdit As DevExpress.XtraEditors.ColorPickEdit

        Private vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer

        Private kmlFileDataAdapter1 As DevExpress.XtraMap.KmlFileDataAdapter

        Private toolTipController1 As DevExpress.Utils.ToolTipController
    End Class
End Namespace
