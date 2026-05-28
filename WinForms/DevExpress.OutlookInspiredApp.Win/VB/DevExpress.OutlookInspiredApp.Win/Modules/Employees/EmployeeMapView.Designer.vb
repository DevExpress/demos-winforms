Namespace DevExpress.DevAV.Modules

    Partial Class EmployeeMapView

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
            Dim windowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim windowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Dim windowsUIButtonImageOptions3 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
            Me.imageTilesLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.azureMapDataProvider1 = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.informationLayer1 = New DevExpress.XtraMap.InformationLayer()
            Me.azureGeocodeDataProvider1 = New DevExpress.XtraMap.AzureGeocodeDataProvider()
            Me.informationLayer2 = New DevExpress.XtraMap.InformationLayer()
            Me.azureSearchDataProvider1 = New DevExpress.XtraMap.AzureSearchDataProvider()
            Me.informationLayer3 = New DevExpress.XtraMap.InformationLayer()
            Me.azureRouteDataProvider1 = New DevExpress.XtraMap.AzureRouteDataProvider()
            Me.routePanel = New DevExpress.XtraEditors.PanelControl()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.bindingSourceRoute = New System.Windows.Forms.BindingSource(Me.components)
            Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colManeuver = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colDistance = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colManeuverInstruction = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biSave = New DevExpress.XtraBars.BarButtonItem()
            Me.biClose = New DevExpress.XtraBars.BarButtonItem()
            Me.biSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biDriving = New DevExpress.XtraBars.BarCheckItem()
            Me.biWalking = New DevExpress.XtraBars.BarCheckItem()
            Me.biPrint = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrintPreview = New DevExpress.XtraBars.BarButtonItem()
            Me.barExportItem = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.routeResultLabel = New DevExpress.XtraEditors.LabelControl()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.moduleDataLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.AddressLabelLine2 = New DevExpress.XtraEditors.LabelControl()
            Me.swapRouteButtons = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.routeButtons = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.editPointB = New DevExpress.XtraEditors.TextEdit()
            Me.editPointA = New DevExpress.XtraEditors.TextEdit()
            Me.FullNameLabel = New DevExpress.XtraEditors.LabelControl()
            Me.AddressLabelLine1 = New DevExpress.XtraEditors.LabelControl()
            Me.PhotoPictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForPhoto = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForAddressLine1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForFullName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForAddressLine2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForPointB = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForPointA = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForRoutePanel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForRouteButtons = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForSwapButton = New DevExpress.XtraLayout.LayoutControlItem()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.roundedSkinPanel1 = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.roundedSkinPanel2 = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.routePanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.routePanel.SuspendLayout()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSourceRoute), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.advBandedGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.moduleDataLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleDataLayout.SuspendLayout()
            CType((Me.editPointB.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.editPointA.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.PhotoPictureEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForPhoto), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForAddressLine1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForFullName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForAddressLine2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForPointB), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForPointA), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForRoutePanel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForRouteButtons), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForSwapButton), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel1.SuspendLayout()
            CType((Me.roundedSkinPanel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel2.SuspendLayout()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.imageTilesLayer1.DataProvider = Me.azureMapDataProvider1
            Me.azureMapDataProvider1.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad
            Me.informationLayer1.DataProvider = Me.azureGeocodeDataProvider1
            Me.azureGeocodeDataProvider1.GenerateLayerItems = False
            Me.informationLayer2.DataProvider = Me.azureSearchDataProvider1
            Me.azureSearchDataProvider1.GenerateLayerItems = False
            Me.informationLayer3.DataProvider = Me.azureRouteDataProvider1
            Me.informationLayer3.HighlightedItemStyle.Stroke = System.Drawing.Color.Cyan
            Me.informationLayer3.HighlightedItemStyle.StrokeWidth = 3
            Me.informationLayer3.ItemStyle.Stroke = System.Drawing.Color.Cyan
            Me.informationLayer3.ItemStyle.StrokeWidth = 3
            Me.routePanel.Controls.Add(Me.gridControl)
            Me.routePanel.Controls.Add(Me.routeResultLabel)
            Me.routePanel.Location = New System.Drawing.Point(49, 284)
            Me.routePanel.Name = "routePanel"
            Me.routePanel.Size = New System.Drawing.Size(346, 310)
            Me.routePanel.TabIndex = 32
            Me.gridControl.DataSource = Me.bindingSourceRoute
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(2, 38)
            Me.gridControl.MainView = Me.advBandedGridView1
            Me.gridControl.MenuManager = Me.ribbonControl
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMemoEdit1})
            Me.gridControl.ShowOnlyPredefinedDetails = True
            Me.gridControl.Size = New System.Drawing.Size(342, 270)
            Me.gridControl.TabIndex = 6
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.advBandedGridView1})
            Me.bindingSourceRoute.DataSource = GetType(DevExpress.DevAV.Presenters.RoutePoint)
            Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1, Me.gridBand2})
            Me.advBandedGridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colManeuver, Me.colManeuverInstruction, Me.colDistance})
            Me.advBandedGridView1.GridControl = Me.gridControl
            Me.advBandedGridView1.Name = "advBandedGridView1"
            Me.advBandedGridView1.OptionsBehavior.Editable = False
            Me.advBandedGridView1.OptionsFind.AllowFindPanel = False
            Me.advBandedGridView1.OptionsView.ColumnAutoWidth = True
            Me.advBandedGridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
            Me.advBandedGridView1.OptionsView.ShowBands = False
            Me.advBandedGridView1.OptionsView.ShowColumnHeaders = False
            Me.advBandedGridView1.OptionsView.ShowGroupPanel = False
            Me.advBandedGridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.advBandedGridView1.OptionsView.ShowIndicator = False
            Me.advBandedGridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.advBandedGridView1.RowHeight = 16
            Me.gridBand1.Columns.Add(Me.colManeuver)
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.OptionsBand.AllowSize = False
            Me.gridBand1.OptionsBand.FixedWidth = True
            Me.gridBand1.VisibleIndex = 0
            Me.gridBand1.Width = 64
            Me.colManeuver.FieldName = "Maneuver"
            Me.colManeuver.Name = "colManeuver"
            Me.colManeuver.OptionsColumn.AllowEdit = False
            Me.colManeuver.OptionsColumn.AllowFocus = False
            Me.colManeuver.RowCount = 4
            Me.colManeuver.Visible = True
            Me.colManeuver.Width = 64
            Me.gridBand2.Columns.Add(Me.colDistance)
            Me.gridBand2.Columns.Add(Me.colManeuverInstruction)
            Me.gridBand2.Name = "gridBand2"
            Me.gridBand2.VisibleIndex = 1
            Me.gridBand2.Width = 254
            Me.colDistance.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.colDistance.AppearanceCell.Options.UseFont = True
            Me.colDistance.AppearanceCell.Options.UseTextOptions = True
            Me.colDistance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.colDistance.FieldName = "Distance"
            Me.colDistance.Name = "colDistance"
            Me.colDistance.OptionsColumn.AllowEdit = False
            Me.colDistance.OptionsColumn.AllowFocus = False
            Me.colDistance.Visible = True
            Me.colDistance.Width = 254
            Me.colManeuverInstruction.AppearanceCell.Font = New System.Drawing.Font("Segoe UI", 12F)
            Me.colManeuverInstruction.AppearanceCell.Options.UseFont = True
            Me.colManeuverInstruction.AppearanceCell.Options.UseTextOptions = True
            Me.colManeuverInstruction.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.colManeuverInstruction.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.colManeuverInstruction.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colManeuverInstruction.FieldName = "ManeuverInstruction"
            Me.colManeuverInstruction.Name = "colManeuverInstruction"
            Me.colManeuverInstruction.OptionsColumn.AllowEdit = False
            Me.colManeuverInstruction.OptionsColumn.AllowFocus = False
            Me.colManeuverInstruction.RowCount = 3
            Me.colManeuverInstruction.RowIndex = 1
            Me.colManeuverInstruction.Visible = True
            Me.colManeuverInstruction.Width = 254
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            Me.ribbonControl.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.biSave, Me.biClose, Me.biSaveAndClose, Me.biDelete, Me.biDriving, Me.biWalking, Me.biPrint, Me.biPrintPreview, Me.barExportItem})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 12
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl.Size = New System.Drawing.Size(1226, 120)
            Me.biSave.Caption = "Save"
            Me.biSave.Id = 1
            Me.biSave.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biSave.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biSave.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Save.svg"
            Me.biSave.Name = "biSave"
            Me.biClose.Caption = "Close"
            Me.biClose.Id = 2
            Me.biClose.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_close_16
            Me.biClose.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biClose.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg"
            Me.biClose.ImageOptions.LargeImage = Global.DevExpress.DevAV.Properties.Resources.icon_close_32
            Me.biClose.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
            Me.biClose.Name = "biClose"
            Me.biSaveAndClose.Caption = "Save && Close"
            Me.biSaveAndClose.Id = 3
            Me.biSaveAndClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biSaveAndClose.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biSaveAndClose.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SaveAndClose.svg"
            Me.biSaveAndClose.Name = "biSaveAndClose"
            Me.biDelete.Caption = "Delete"
            Me.biDelete.Id = 4
            Me.biDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biDelete.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDelete.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg"
            Me.biDelete.Name = "biDelete"
            Me.biDriving.Caption = "Driving"
            Me.biDriving.Id = 5
            Me.biDriving.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biDriving.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDriving.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Driving.svg"
            Me.biDriving.Name = "biDriving"
            Me.biWalking.Caption = "Walking"
            Me.biWalking.Id = 6
            Me.biWalking.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biWalking.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biWalking.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Walking.svg"
            Me.biWalking.Name = "biWalking"
            Me.biPrint.Caption = "Print"
            Me.biPrint.Id = 8
            Me.biPrint.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biPrint.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPrint.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg"
            Me.biPrint.Name = "biPrint"
            Me.biPrintPreview.Caption = "Print Preview"
            Me.biPrintPreview.Id = 9
            Me.biPrintPreview.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biPrintPreview.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPrintPreview.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintPreview.svg"
            Me.biPrintPreview.Name = "biPrintPreview"
            Me.barExportItem.Caption = "Export"
            Me.barExportItem.Id = 11
            Me.barExportItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.barExportItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.barExportItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Export.svg"
            Me.barExportItem.ImageOptions.LargeImageIndex = 50
            Me.barExportItem.Name = "barExportItem"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup5, Me.ribbonPageGroup4, Me.ribbonPageGroup3})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Contact"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biSave)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biSaveAndClose)
            Me.ribbonPageGroup1.MergeOrder = 0
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup2.AllowTextClipping = False
            Me.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup2.ItemLinks.Add(Me.biDelete)
            Me.ribbonPageGroup2.MergeOrder = 0
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "Delete"
            Me.ribbonPageGroup5.AllowTextClipping = False
            Me.ribbonPageGroup5.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biPrintPreview)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biPrint)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.barExportItem)
            Me.ribbonPageGroup5.MergeOrder = 0
            Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
            Me.ribbonPageGroup5.Text = "Print and Export"
            Me.ribbonPageGroup4.AllowTextClipping = False
            Me.ribbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biDriving)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biWalking)
            Me.ribbonPageGroup4.MergeOrder = 0
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.Text = "Route Options"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biClose)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.Text = "Close"
            Me.routeResultLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.routeResultLabel.Appearance.Options.UseFont = True
            Me.routeResultLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.routeResultLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "RouteResult", True))
            Me.routeResultLabel.Dock = System.Windows.Forms.DockStyle.Top
            Me.routeResultLabel.Location = New System.Drawing.Point(2, 2)
            Me.routeResultLabel.Name = "routeResultLabel"
            Me.routeResultLabel.Padding = New System.Windows.Forms.Padding(12, 12, 12, 24)
            Me.routeResultLabel.Size = New System.Drawing.Size(342, 36)
            Me.routeResultLabel.TabIndex = 29
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.ViewModels.EmployeeMapViewModel)
            Me.moduleDataLayout.AllowCustomization = False
            Me.moduleDataLayout.Controls.Add(Me.AddressLabelLine2)
            Me.moduleDataLayout.Controls.Add(Me.swapRouteButtons)
            Me.moduleDataLayout.Controls.Add(Me.routeButtons)
            Me.moduleDataLayout.Controls.Add(Me.routePanel)
            Me.moduleDataLayout.Controls.Add(Me.editPointB)
            Me.moduleDataLayout.Controls.Add(Me.editPointA)
            Me.moduleDataLayout.Controls.Add(Me.FullNameLabel)
            Me.moduleDataLayout.Controls.Add(Me.AddressLabelLine1)
            Me.moduleDataLayout.Controls.Add(Me.PhotoPictureEdit)
            Me.moduleDataLayout.DataSource = Me.bindingSource
            Me.moduleDataLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleDataLayout.Location = New System.Drawing.Point(16, 0)
            Me.moduleDataLayout.MinimumSize = New System.Drawing.Size(32, 32)
            Me.moduleDataLayout.Name = "moduleDataLayout"
            Me.moduleDataLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(3215, 123, 650, 400)
            Me.moduleDataLayout.Root = Me.layoutControlGroup1
            Me.moduleDataLayout.Size = New System.Drawing.Size(411, 610)
            Me.moduleDataLayout.TabIndex = 1
            Me.moduleDataLayout.Text = "moduleDataLayout"
            Me.AddressLabelLine2.Appearance.Font = New System.Drawing.Font("Segoe UI", 11F)
            Me.AddressLabelLine2.Appearance.Options.UseFont = True
            Me.AddressLabelLine2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "AddressLine2", True))
            Me.AddressLabelLine2.Location = New System.Drawing.Point(158, 96)
            Me.AddressLabelLine2.Name = "AddressLabelLine2"
            Me.AddressLabelLine2.Size = New System.Drawing.Size(221, 20)
            Me.AddressLabelLine2.StyleController = Me.moduleDataLayout
            Me.AddressLabelLine2.TabIndex = 33
            Me.swapRouteButtons.AllowGlyphSkinning = False
            windowsUIButtonImageOptions1.Image = Global.DevExpress.DevAV.Properties.Resources.icon_revert_direction_14
            Me.swapRouteButtons.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Driving", False, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
            Me.swapRouteButtons.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.swapRouteButtons.Location = New System.Drawing.Point(49, 222)
            Me.swapRouteButtons.Name = "swapRouteButtons"
            Me.swapRouteButtons.Size = New System.Drawing.Size(346, 14)
            Me.swapRouteButtons.TabIndex = 31
            Me.swapRouteButtons.UseButtonBackgroundImages = False
            Me.routeButtons.AllowGlyphSkinning = False
            windowsUIButtonImageOptions2.Image = Global.DevExpress.DevAV.Properties.Resources.icon_walking_14
            windowsUIButtonImageOptions3.Image = Global.DevExpress.DevAV.Properties.Resources.icon_driving_14
            Me.routeButtons.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Walking", False, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Driving", False, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, True, Nothing, True, False, True, Nothing, -1, False)})
            Me.routeButtons.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
            Me.routeButtons.Location = New System.Drawing.Point(49, 160)
            Me.routeButtons.Name = "routeButtons"
            Me.routeButtons.Size = New System.Drawing.Size(346, 14)
            Me.routeButtons.TabIndex = 30
            Me.routeButtons.UseButtonBackgroundImages = False
            Me.editPointB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "PointBAddress", True))
            Me.editPointB.Location = New System.Drawing.Point(49, 242)
            Me.editPointB.MinimumSize = New System.Drawing.Size(340, 0)
            Me.editPointB.Name = "editPointB"
            Me.editPointB.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.editPointB.Properties.Appearance.Options.UseFont = True
            Me.editPointB.Size = New System.Drawing.Size(346, 36)
            Me.editPointB.StyleController = Me.moduleDataLayout
            Me.editPointB.TabIndex = 24
            Me.editPointA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "PointAAddress", True))
            Me.editPointA.Location = New System.Drawing.Point(49, 180)
            Me.editPointA.Name = "editPointA"
            Me.editPointA.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.editPointA.Properties.Appearance.Options.UseFont = True
            Me.editPointA.Size = New System.Drawing.Size(346, 36)
            Me.editPointA.StyleController = Me.moduleDataLayout
            Me.editPointA.TabIndex = 21
            Me.FullNameLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 18F)
            Me.FullNameLabel.Appearance.Options.UseFont = True
            Me.FullNameLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "FullName", True))
            Me.FullNameLabel.Location = New System.Drawing.Point(158, 32)
            Me.FullNameLabel.Name = "FullNameLabel"
            Me.FullNameLabel.Size = New System.Drawing.Size(221, 32)
            Me.FullNameLabel.StyleController = Me.moduleDataLayout
            Me.FullNameLabel.TabIndex = 8
            Me.AddressLabelLine1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11F)
            Me.AddressLabelLine1.Appearance.Options.UseFont = True
            Me.AddressLabelLine1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "AddressLine1", True))
            Me.AddressLabelLine1.Location = New System.Drawing.Point(158, 70)
            Me.AddressLabelLine1.Name = "AddressLabelLine1"
            Me.AddressLabelLine1.Size = New System.Drawing.Size(221, 20)
            Me.AddressLabelLine1.StyleController = Me.moduleDataLayout
            Me.AddressLabelLine1.TabIndex = 8
            Me.PhotoPictureEdit.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.PhotoPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Picture", True))
            Me.PhotoPictureEdit.Location = New System.Drawing.Point(16, 16)
            Me.PhotoPictureEdit.MaximumSize = New System.Drawing.Size(120, 120)
            Me.PhotoPictureEdit.MenuManager = Me.ribbonControl
            Me.PhotoPictureEdit.MinimumSize = New System.Drawing.Size(120, 120)
            Me.PhotoPictureEdit.Name = "PhotoPictureEdit"
            Me.PhotoPictureEdit.Properties.[ReadOnly] = True
            Me.PhotoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.PhotoPictureEdit.Size = New System.Drawing.Size(120, 120)
            Me.PhotoPictureEdit.StyleController = Me.moduleDataLayout
            Me.PhotoPictureEdit.TabIndex = 17
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForPhoto, Me.ItemForPointB, Me.ItemForPointA, Me.ItemForRoutePanel, Me.ItemForRouteButtons, Me.ItemForSwapButton, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6
            Me.layoutControlGroup1.Size = New System.Drawing.Size(411, 610)
            Me.layoutControlGroup1.TextVisible = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 90)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(227, 10)
            Me.ItemForPhoto.Control = Me.PhotoPictureEdit
            Me.ItemForPhoto.CustomizationFormText = "Photo"
            Me.ItemForPhoto.Location = New System.Drawing.Point(0, 0)
            Me.ItemForPhoto.Name = "ItemForPhoto"
            Me.ItemForPhoto.Size = New System.Drawing.Size(126, 132)
            Me.ItemForPhoto.Text = "Photo"
            Me.ItemForPhoto.TextVisible = False
            Me.ItemForAddressLine1.Control = Me.AddressLabelLine1
            Me.ItemForAddressLine1.CustomizationFormText = "Address"
            Me.ItemForAddressLine1.Location = New System.Drawing.Point(0, 38)
            Me.ItemForAddressLine1.Name = "ItemForAddressLine1"
            Me.ItemForAddressLine1.Size = New System.Drawing.Size(227, 26)
            Me.ItemForAddressLine1.Text = "Address"
            Me.ItemForAddressLine1.TextVisible = False
            Me.ItemForFullName.Control = Me.FullNameLabel
            Me.ItemForFullName.CustomizationFormText = "Full Name"
            Me.ItemForFullName.Location = New System.Drawing.Point(0, 0)
            Me.ItemForFullName.Name = "ItemForFullName"
            Me.ItemForFullName.Size = New System.Drawing.Size(227, 38)
            Me.ItemForFullName.Text = "Full Name"
            Me.ItemForFullName.TextVisible = False
            Me.ItemForAddressLine2.Control = Me.AddressLabelLine2
            Me.ItemForAddressLine2.CustomizationFormText = "Address"
            Me.ItemForAddressLine2.Location = New System.Drawing.Point(0, 64)
            Me.ItemForAddressLine2.Name = "ItemForAddressLine2"
            Me.ItemForAddressLine2.Size = New System.Drawing.Size(227, 26)
            Me.ItemForAddressLine2.Text = "Address"
            Me.ItemForAddressLine2.TextVisible = False
            Me.ItemForPointB.Control = Me.editPointB
            Me.ItemForPointB.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.ItemForPointB.CustomizationFormText = "B"
            Me.ItemForPointB.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.ItemForPointB.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.MapItem.icon-B-24.png"
            Me.ItemForPointB.ImageOptions.ImageToTextDistance = 0
            Me.ItemForPointB.Location = New System.Drawing.Point(0, 226)
            Me.ItemForPointB.Name = "ItemForPointB"
            Me.ItemForPointB.Size = New System.Drawing.Size(385, 42)
            Me.ItemForPointB.Text = " "
            Me.ItemForPointB.TextSize = New System.Drawing.Size(27, 24)
            Me.ItemForPointA.Control = Me.editPointA
            Me.ItemForPointA.ControlAlignment = System.Drawing.ContentAlignment.BottomLeft
            Me.ItemForPointA.CustomizationFormText = "A"
            Me.ItemForPointA.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.ItemForPointA.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.MapItem.icon-A-24.png"
            Me.ItemForPointA.ImageOptions.ImageToTextDistance = 0
            Me.ItemForPointA.Location = New System.Drawing.Point(0, 164)
            Me.ItemForPointA.Name = "ItemForPointA"
            Me.ItemForPointA.Size = New System.Drawing.Size(385, 42)
            Me.ItemForPointA.Text = " "
            Me.ItemForPointA.TextSize = New System.Drawing.Size(27, 24)
            Me.ItemForRoutePanel.Control = Me.routePanel
            Me.ItemForRoutePanel.CustomizationFormText = " "
            Me.ItemForRoutePanel.Location = New System.Drawing.Point(0, 268)
            Me.ItemForRoutePanel.Name = "ItemForRoutePanel"
            Me.ItemForRoutePanel.Size = New System.Drawing.Size(385, 316)
            Me.ItemForRoutePanel.Text = " "
            Me.ItemForRoutePanel.TextSize = New System.Drawing.Size(27, 13)
            Me.ItemForRouteButtons.Control = Me.routeButtons
            Me.ItemForRouteButtons.CustomizationFormText = " "
            Me.ItemForRouteButtons.Location = New System.Drawing.Point(0, 132)
            Me.ItemForRouteButtons.Name = "ItemForRouteButtons"
            Me.ItemForRouteButtons.Size = New System.Drawing.Size(385, 32)
            Me.ItemForRouteButtons.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 12, 0)
            Me.ItemForRouteButtons.Text = " "
            Me.ItemForRouteButtons.TextSize = New System.Drawing.Size(27, 13)
            Me.ItemForSwapButton.Control = Me.swapRouteButtons
            Me.ItemForSwapButton.CustomizationFormText = " "
            Me.ItemForSwapButton.Location = New System.Drawing.Point(0, 206)
            Me.ItemForSwapButton.Name = "ItemForSwapButton"
            Me.ItemForSwapButton.Size = New System.Drawing.Size(385, 20)
            Me.ItemForSwapButton.Text = " "
            Me.ItemForSwapButton.TextSize = New System.Drawing.Size(27, 13)
            Me.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl.Layers.Add(Me.imageTilesLayer1)
            Me.mapControl.Layers.Add(Me.informationLayer1)
            Me.mapControl.Layers.Add(Me.informationLayer2)
            Me.mapControl.Layers.Add(Me.informationLayer3)
            Me.mapControl.Location = New System.Drawing.Point(16, 16)
            Me.mapControl.MinimumSize = New System.Drawing.Size(32, 32)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.SearchPanelOptions.Visible = False
            Me.mapControl.Size = New System.Drawing.Size(767, 610)
            Me.mapControl.TabIndex = 18
            Me.mapControl.ZoomLevel = 8R
            Me.roundedSkinPanel1.Controls.Add(Me.mapControl)
            Me.roundedSkinPanel1.Controls.Add(Me.roundedSkinPanel2)
            Me.roundedSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.roundedSkinPanel1.Location = New System.Drawing.Point(0, 120)
            Me.roundedSkinPanel1.Name = "roundedSkinPanel1"
            Me.roundedSkinPanel1.Size = New System.Drawing.Size(1226, 642)
            Me.roundedSkinPanel1.TabIndex = 34
            Me.roundedSkinPanel1.Text = "roundedSkinPanel1"
            Me.roundedSkinPanel2.Controls.Add(Me.moduleDataLayout)
            Me.roundedSkinPanel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.roundedSkinPanel2.Location = New System.Drawing.Point(783, 16)
            Me.roundedSkinPanel2.Name = "roundedSkinPanel2"
            Me.roundedSkinPanel2.Size = New System.Drawing.Size(427, 610)
            Me.roundedSkinPanel2.TabIndex = 34
            Me.roundedSkinPanel2.Text = "roundedSkinPanel2"
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem2, Me.ItemForAddressLine2, Me.ItemForAddressLine1, Me.ItemForFullName})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(126, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(259, 132)
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.roundedSkinPanel1)
            Me.Controls.Add(Me.ribbonControl)
            Me.Name = "EmployeeMapView"
            Me.Size = New System.Drawing.Size(1226, 762)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.routePanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.routePanel.ResumeLayout(False)
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSourceRoute), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.advBandedGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.moduleDataLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleDataLayout.ResumeLayout(False)
            CType((Me.editPointB.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.editPointA.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.PhotoPictureEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForPhoto), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForAddressLine1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForFullName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForAddressLine2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForPointB), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForPointA), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForRoutePanel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForRouteButtons), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForSwapButton), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel1.ResumeLayout(False)
            CType((Me.roundedSkinPanel2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel2.ResumeLayout(False)
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl

        Private biSave As DevExpress.XtraBars.BarButtonItem

        Private biClose As DevExpress.XtraBars.BarButtonItem

        Private biSaveAndClose As DevExpress.XtraBars.BarButtonItem

        Private biDelete As DevExpress.XtraBars.BarButtonItem

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private moduleDataLayout As DevExpress.XtraDataLayout.DataLayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private bindingSource As System.Windows.Forms.BindingSource

        Private FullNameLabel As DevExpress.XtraEditors.LabelControl

        Private AddressLabelLine1 As DevExpress.XtraEditors.LabelControl

        Private PhotoPictureEdit As DevExpress.XtraEditors.PictureEdit

        Private mapControl As DevExpress.XtraMap.MapControl

        Private editPointB As DevExpress.XtraEditors.TextEdit

        Private editPointA As DevExpress.XtraEditors.TextEdit

        Private gridControl As DevExpress.XtraGrid.GridControl

        Private biDriving As DevExpress.XtraBars.BarCheckItem

        Private biWalking As DevExpress.XtraBars.BarCheckItem

        Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private routeResultLabel As DevExpress.XtraEditors.LabelControl

        Private bindingSourceRoute As System.Windows.Forms.BindingSource

        Private routeButtons As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel

        Private biPrint As DevExpress.XtraBars.BarButtonItem

        Private biPrintPreview As DevExpress.XtraBars.BarButtonItem

        Private barExportItem As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView

        Private colManeuver As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colManeuverInstruction As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colDistance As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private swapRouteButtons As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel

        Private routePanel As DevExpress.XtraEditors.PanelControl

        Private AddressLabelLine2 As DevExpress.XtraEditors.LabelControl

        Private imageTilesLayer1 As DevExpress.XtraMap.ImageLayer

        Private azureMapDataProvider1 As DevExpress.XtraMap.AzureMapDataProvider

        Private informationLayer1 As DevExpress.XtraMap.InformationLayer

        Private azureGeocodeDataProvider1 As DevExpress.XtraMap.AzureGeocodeDataProvider

        Private informationLayer2 As DevExpress.XtraMap.InformationLayer

        Private azureSearchDataProvider1 As DevExpress.XtraMap.AzureSearchDataProvider

        Private informationLayer3 As DevExpress.XtraMap.InformationLayer

        Private azureRouteDataProvider1 As DevExpress.XtraMap.AzureRouteDataProvider

        Private roundedSkinPanel1 As DevExpress.XtraEditors.RoundedSkinPanel

        Private roundedSkinPanel2 As DevExpress.XtraEditors.RoundedSkinPanel

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private ItemForPhoto As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForAddressLine1 As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForFullName As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForAddressLine2 As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForPointB As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForPointA As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForRoutePanel As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForRouteButtons As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForSwapButton As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
