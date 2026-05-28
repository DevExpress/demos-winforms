Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors
Imports DevExpress.XtraMap
Namespace DevExpress.ProductsDemo.Win.Modules
    Partial Public Class MapsModule
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            OnDispose()
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MapsModule))
            Dim mapItemAttributeMapping1 As New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping2 As New DevExpress.XtraMap.MapItemAttributeMapping()
            Dim mapItemAttributeMapping3 As New DevExpress.XtraMap.MapItemAttributeMapping()
            Me.AirportTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.PlaneTemplate = New DevExpress.Utils.Html.HtmlTemplate()
            Me.TilesLayer = New DevExpress.XtraMap.ImageLayer()
            Me.AirportsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.AirportsDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.PlanesDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.mapContainerPanel = New DevExpress.XtraEditors.PanelControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.PathsLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.PathsDataAdapter = New DevExpress.XtraMap.ListSourceDataAdapter()
            Me.RoutesLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.RoutesStorage = New DevExpress.XtraMap.MapItemStorage()
            Me.PlanesLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.chkAzureRoad = New DevExpress.XtraBars.BarCheckItem()
            Me.chkAzureImagery = New DevExpress.XtraBars.BarCheckItem()
            Me.chkAzureDark = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.viewRibbonPage1 = New DevExpress.XtraScheduler.UI.ViewRibbonPage()
            Me.activeViewRibbonPageGroup1 = New DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.htmlContentPopup1 = New DevExpress.XtraEditors.HtmlContentPopup(Me.components)
            DirectCast(Me.mapContainerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mapContainerPanel.SuspendLayout()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.htmlContentPopup1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()

            ' 
            ' AirportTemplate
            ' 
            Me.AirportTemplate.Name = "AirportTemplate"
            Me.AirportTemplate.Styles = resources.GetString("AirportTemplate.Styles")
            Me.AirportTemplate.Template = resources.GetString("AirportTemplate.Template")
            ' 
            ' PlaneTemplate
            ' 
            Me.PlaneTemplate.Name = "PlaneTemplate"
            Me.PlaneTemplate.Styles = resources.GetString("PlaneTemplate.Styles")
            Me.PlaneTemplate.Template = resources.GetString("PlaneTemplate.Template")
            Me.AirportsLayer.Data = Me.AirportsDataAdapter
            mapItemAttributeMapping1.Member = "Name"
            mapItemAttributeMapping1.Name = "Name"
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.String
            mapItemAttributeMapping2.Member = "City"
            mapItemAttributeMapping2.Name = "City"
            mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.String
            mapItemAttributeMapping3.Member = "IATA"
            mapItemAttributeMapping3.Name = "IATA"
            mapItemAttributeMapping3.ValueType = DevExpress.XtraMap.FieldValueType.String
            Me.AirportsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1)
            Me.AirportsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2)
            Me.AirportsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping3)
            Me.AirportsDataAdapter.Mappings.Latitude = "Latitude"
            Me.AirportsDataAdapter.Mappings.Longitude = "Longitude"
            Me.AirportsDataAdapter.Mappings.Type = "ItemType"
            Me.PlanesDataAdapter.Mappings.Latitude = "Latitude"
            Me.PlanesDataAdapter.Mappings.Longitude = "Longitude"
            Me.PlanesDataAdapter.Mappings.Type = "ItemType"
            ' 
            ' mapContainerPanel
            ' 
            Me.mapContainerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapContainerPanel.Controls.Add(Me.layoutControl1)
            Me.mapContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapContainerPanel.Location = New System.Drawing.Point(0, 150)
            Me.mapContainerPanel.Margin = New System.Windows.Forms.Padding(23)
            Me.mapContainerPanel.Name = "mapContainerPanel"
            Me.mapContainerPanel.Size = New System.Drawing.Size(1053, 589)
            Me.mapContainerPanel.TabIndex = 15
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.mapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(376, 238, 905, 577)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(1053, 589)
            Me.layoutControl1.TabIndex = 16
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(32.0R, 10.0R)
            Me.mapControl1.EnableRotation = False
            Me.mapControl1.Layers.Add(Me.TilesLayer)
            Me.mapControl1.Layers.Add(Me.AirportsLayer)
            Me.mapControl1.Layers.Add(Me.PathsLayer)
            Me.mapControl1.Layers.Add(Me.RoutesLayer)
            Me.mapControl1.Layers.Add(Me.PlanesLayer)
            Me.mapControl1.Location = New System.Drawing.Point(12, 12)
            Me.mapControl1.MaxZoomLevel = 10.0R
            Me.mapControl1.MinZoomLevel = 3.0R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.NavigationPanelOptions.Visible = False
            Me.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single
            Me.mapControl1.Size = New System.Drawing.Size(1029, 565)
            Me.mapControl1.TabIndex = 17
            Me.mapControl1.ZoomLevel = 3.0R
            AddHandler Me.mapControl1.SelectionChanged, AddressOf OnMapSelectionChanged
            Me.PathsLayer.Data = Me.PathsDataAdapter
            Me.PathsDataAdapter.Mappings.Latitude = "Latitude"
            Me.PathsDataAdapter.Mappings.Longitude = "Longitude"
            Me.PathsDataAdapter.Mappings.Type = "ItemType"
            Me.RoutesLayer.Data = Me.RoutesStorage
            Me.PlanesLayer.Data = Me.PlanesDataAdapter
            AddHandler Me.AirportsLayer.DataLoaded, AddressOf AirportsLayer_DataLoaded
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1053, 589)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.mapControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(1033, 569)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.chkAzureRoad, Me.chkAzureImagery, Me.chkAzureDark, Me.barCheckItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 48
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.viewRibbonPage1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1053, 150)
            ' 
            ' chkAzureRoad
            ' 
            Me.chkAzureRoad.BindableChecked = True
            Me.chkAzureRoad.Caption = "Road"
            Me.chkAzureRoad.Checked = True
            Me.chkAzureRoad.GroupIndex = 1
            Me.chkAzureRoad.Id = 40
            Me.chkAzureRoad.ImageOptions.SvgImage = My.Resources.BringRoad
            Me.chkAzureRoad.Name = "chkAzureRoad"
            Me.chkAzureRoad.Tag = 7
            AddHandler Me.chkAzureRoad.CheckedChanged, AddressOf OnAzureTilesetCheckedChanged
            ' 
            ' chkAzureImagery
            ' 
            Me.chkAzureImagery.Caption = "Imagery"
            Me.chkAzureImagery.GroupIndex = 1
            Me.chkAzureImagery.Id = 41
            Me.chkAzureImagery.ImageOptions.SvgImage = My.Resources.BringArea
            Me.chkAzureImagery.Name = "chkAzureImagery"
            Me.chkAzureImagery.Tag = 0
            AddHandler Me.chkAzureImagery.CheckedChanged, AddressOf OnAzureTilesetCheckedChanged
            ' 
            ' chkAzureDark
            ' 
            Me.chkAzureDark.Caption = "Dark"
            Me.chkAzureDark.GroupIndex = 1
            Me.chkAzureDark.Id = 42
            Me.chkAzureDark.ImageOptions.SvgImage = My.Resources.BringRoadDark
            Me.chkAzureDark.Name = "chkAzureDark"
            Me.chkAzureDark.Tag = 2
            AddHandler Me.chkAzureDark.CheckedChanged, AddressOf OnAzureTilesetCheckedChanged
            ' 
            ' barCheckItem1
            ' 
            Me.barCheckItem1.BindableChecked = True
            Me.barCheckItem1.Caption = "Show Planes"
            Me.barCheckItem1.Checked = True
            Me.barCheckItem1.Id = 47
            Me.barCheckItem1.ImageOptions.SvgImage = My.Resources.Plane
            Me.barCheckItem1.Name = "barCheckItem1"
            AddHandler Me.barCheckItem1.CheckedChanged, AddressOf OnPlanesVisibilityCheckedChanged
            ' 
            ' viewRibbonPage1
            ' 
            Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.activeViewRibbonPageGroup1, Me.ribbonPageGroup1})
            Me.viewRibbonPage1.Name = "viewRibbonPage1"
            ' 
            ' activeViewRibbonPageGroup1
            ' 
            Me.activeViewRibbonPageGroup1.AllowTextClipping = False
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.chkAzureRoad)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.chkAzureImagery)
            Me.activeViewRibbonPageGroup1.ItemLinks.Add(Me.chkAzureDark)
            Me.activeViewRibbonPageGroup1.Name = "activeViewRibbonPageGroup1"
            Me.activeViewRibbonPageGroup1.Text = "Azure Tileset"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barCheckItem1)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            ' 
            ' MapsModule
            ' 
            Me.Appearance.Options.UseFont = True
            Me.Controls.Add(Me.mapContainerPanel)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "MapsModule"
            Me.Size = New System.Drawing.Size(1053, 739)
            DirectCast(Me.mapContainerPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.mapContainerPanel.ResumeLayout(False)
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.htmlContentPopup1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapContainerPanel As XtraEditors.PanelControl
        Private ribbonControl1 As XtraBars.Ribbon.RibbonControl
        Private viewRibbonPage1 As XtraScheduler.UI.ViewRibbonPage
        Private activeViewRibbonPageGroup1 As XtraScheduler.UI.ActiveViewRibbonPageGroup
        Private chkAzureRoad As XtraBars.BarCheckItem
        Private chkAzureImagery As XtraBars.BarCheckItem
        Private chkAzureDark As XtraBars.BarCheckItem
        Private layoutControl1 As XtraLayout.LayoutControl
        Private mapControl1 As MapControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private TilesLayer As ImageLayer
        Private AirportsLayer As VectorItemsLayer
        Private PlanesDataAdapter As ListSourceDataAdapter
        Private AirportsDataAdapter As ListSourceDataAdapter
        Private PlanesLayer As VectorItemsLayer
        Private PathsDataAdapter As ListSourceDataAdapter
        Private RoutesLayer As VectorItemsLayer
        Private RoutesStorage As MapItemStorage
        Private PathsLayer As VectorItemsLayer
        Private htmlContentPopup1 As HtmlContentPopup
        Private AirportTemplate As HtmlTemplate
        Private PlaneTemplate As HtmlTemplate
        Private barCheckItem1 As XtraBars.BarCheckItem
        Private ribbonPageGroup1 As XtraBars.Ribbon.RibbonPageGroup
    End Class
End Namespace
