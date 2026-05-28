Namespace DevExpress.DevAV.Modules

    Partial Class OrderMapView

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
            Me.imageTilesLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.azureMapDataProvider1 = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.informationLayer1 = New DevExpress.XtraMap.InformationLayer()
            Me.azureGeocodeDataProvider1 = New DevExpress.XtraMap.AzureGeocodeDataProvider()
            Me.informationLayer2 = New DevExpress.XtraMap.InformationLayer()
            Me.azureSearchDataProvider1 = New DevExpress.XtraMap.AzureSearchDataProvider()
            Me.informationLayer3 = New DevExpress.XtraMap.InformationLayer()
            Me.azureRouteDataProvider1 = New DevExpress.XtraMap.AzureRouteDataProvider()
            Me.bindingSourceRoute = New System.Windows.Forms.BindingSource(Me.components)
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biClose = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrint = New DevExpress.XtraBars.BarButtonItem()
            Me.barExportItem = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.moduleDataLayout = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.Viewer = New DevExpress.XtraPdfViewer.PdfViewer()
            Me.InvoiceLabel = New DevExpress.XtraEditors.LabelControl()
            Me.NameLabel = New DevExpress.XtraEditors.LabelControl()
            Me.LogoPictureEdit = New DevExpress.XtraEditors.PictureEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForLogo = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ItemForViewer = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForFullName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.ItemForInvoice = New DevExpress.XtraLayout.LayoutControlItem()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.roundedSkinPanel1 = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.roundedSkinPanel2 = New DevExpress.XtraEditors.RoundedSkinPanel()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSourceRoute), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.moduleDataLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleDataLayout.SuspendLayout()
            CType((Me.LogoPictureEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForLogo), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForViewer), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForFullName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForInvoice), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel1.SuspendLayout()
            CType((Me.roundedSkinPanel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel2.SuspendLayout()
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
            Me.bindingSourceRoute.DataSource = GetType(DevExpress.DevAV.Presenters.RoutePoint)
            Me.ribbonControl.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.biClose, Me.biPrint, Me.barExportItem})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 12
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl.Size = New System.Drawing.Size(1226, 120)
            Me.biClose.Caption = "Close"
            Me.biClose.Id = 2
            Me.biClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biClose.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biClose.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg"
            Me.biClose.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape)
            Me.biClose.Name = "biClose"
            Me.biPrint.Caption = "Print"
            Me.biPrint.Id = 8
            Me.biPrint.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biPrint.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPrint.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg"
            Me.biPrint.Name = "biPrint"
            Me.barExportItem.Caption = "Export"
            Me.barExportItem.Id = 11
            Me.barExportItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.barExportItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.barExportItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Export.svg"
            Me.barExportItem.ImageOptions.LargeImageIndex = 50
            Me.barExportItem.Name = "barExportItem"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup5, Me.ribbonPageGroup3})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Home"
            Me.ribbonPageGroup5.AllowTextClipping = False
            Me.ribbonPageGroup5.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biPrint)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.barExportItem)
            Me.ribbonPageGroup5.MergeOrder = 0
            Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
            Me.ribbonPageGroup5.Text = "Print and Export"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biClose)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.Text = "Close"
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.ViewModels.OrderMapViewModel)
            Me.moduleDataLayout.AllowCustomization = False
            Me.moduleDataLayout.Controls.Add(Me.Viewer)
            Me.moduleDataLayout.Controls.Add(Me.InvoiceLabel)
            Me.moduleDataLayout.Controls.Add(Me.NameLabel)
            Me.moduleDataLayout.Controls.Add(Me.LogoPictureEdit)
            Me.moduleDataLayout.DataSource = Me.bindingSource
            Me.moduleDataLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleDataLayout.Location = New System.Drawing.Point(16, 0)
            Me.moduleDataLayout.MinimumSize = New System.Drawing.Size(32, 32)
            Me.moduleDataLayout.Name = "moduleDataLayout"
            Me.moduleDataLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(3215, 123, 650, 723)
            Me.moduleDataLayout.Root = Me.layoutControlGroup1
            Me.moduleDataLayout.Size = New System.Drawing.Size(484, 610)
            Me.moduleDataLayout.TabIndex = 1
            Me.moduleDataLayout.Text = "moduleDataLayout"
            Me.Viewer.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.Viewer.Appearance.Options.UseBackColor = True
            Me.Viewer.DetachStreamAfterLoadComplete = True
            Me.Viewer.Location = New System.Drawing.Point(16, 154)
            Me.Viewer.MenuManager = Me.ribbonControl
            Me.Viewer.MinimumSize = New System.Drawing.Size(400, 0)
            Me.Viewer.Name = "Viewer"
            Me.Viewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
            Me.Viewer.NavigationPanePageVisibility = DevExpress.XtraPdfViewer.PdfNavigationPanePageVisibility.None
            Me.Viewer.Size = New System.Drawing.Size(452, 440)
            Me.Viewer.TabIndex = 20
            Me.Viewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel
            Me.InvoiceLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 11F)
            Me.InvoiceLabel.Appearance.Options.UseFont = True
            Me.InvoiceLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "Entity.InvoiceNumber", True))
            Me.InvoiceLabel.Location = New System.Drawing.Point(224, 100)
            Me.InvoiceLabel.Name = "InvoiceLabel"
            Me.InvoiceLabel.Size = New System.Drawing.Size(228, 20)
            Me.InvoiceLabel.StyleController = Me.moduleDataLayout
            Me.InvoiceLabel.TabIndex = 19
            Me.NameLabel.Appearance.Font = New System.Drawing.Font("Segoe UI", 18F)
            Me.NameLabel.Appearance.Options.UseFont = True
            Me.NameLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bindingSource, "Name", True))
            Me.NameLabel.Location = New System.Drawing.Point(158, 32)
            Me.NameLabel.Name = "NameLabel"
            Me.NameLabel.Size = New System.Drawing.Size(294, 32)
            Me.NameLabel.StyleController = Me.moduleDataLayout
            Me.NameLabel.TabIndex = 8
            Me.LogoPictureEdit.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.LogoPictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bindingSource, "Logo", True))
            Me.LogoPictureEdit.Location = New System.Drawing.Point(16, 16)
            Me.LogoPictureEdit.MaximumSize = New System.Drawing.Size(120, 120)
            Me.LogoPictureEdit.MenuManager = Me.ribbonControl
            Me.LogoPictureEdit.MinimumSize = New System.Drawing.Size(120, 120)
            Me.LogoPictureEdit.Name = "LogoPictureEdit"
            Me.LogoPictureEdit.Properties.[ReadOnly] = True
            Me.LogoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            Me.LogoPictureEdit.Size = New System.Drawing.Size(120, 120)
            Me.LogoPictureEdit.StyleController = Me.moduleDataLayout
            Me.LogoPictureEdit.TabIndex = 17
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForLogo, Me.ItemForViewer, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6
            Me.layoutControlGroup1.Size = New System.Drawing.Size(484, 610)
            Me.layoutControlGroup1.TextVisible = False
            Me.ItemForLogo.Control = Me.LogoPictureEdit
            Me.ItemForLogo.CustomizationFormText = "Logo"
            Me.ItemForLogo.Location = New System.Drawing.Point(0, 0)
            Me.ItemForLogo.Name = "ItemForLogo"
            Me.ItemForLogo.Size = New System.Drawing.Size(126, 126)
            Me.ItemForLogo.Text = "Logo"
            Me.ItemForLogo.TextVisible = False
            Me.ItemForViewer.Control = Me.Viewer
            Me.ItemForViewer.Location = New System.Drawing.Point(0, 126)
            Me.ItemForViewer.Name = "ItemForViewer"
            Me.ItemForViewer.Size = New System.Drawing.Size(458, 458)
            Me.ItemForViewer.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 12, 0)
            Me.ItemForViewer.TextVisible = False
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForFullName, Me.emptySpaceItem2, Me.ItemForInvoice})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(126, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(332, 126)
            Me.ItemForFullName.Control = Me.NameLabel
            Me.ItemForFullName.CustomizationFormText = "Full Name"
            Me.ItemForFullName.Location = New System.Drawing.Point(0, 0)
            Me.ItemForFullName.Name = "ItemForFullName"
            Me.ItemForFullName.Size = New System.Drawing.Size(300, 38)
            Me.ItemForFullName.Text = "Full Name"
            Me.ItemForFullName.TextVisible = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 38)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(300, 30)
            Me.ItemForInvoice.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 11F)
            Me.ItemForInvoice.AppearanceItemCaption.Options.UseFont = True
            Me.ItemForInvoice.Control = Me.InvoiceLabel
            Me.ItemForInvoice.Location = New System.Drawing.Point(0, 68)
            Me.ItemForInvoice.Name = "ItemForInvoice"
            Me.ItemForInvoice.Size = New System.Drawing.Size(300, 26)
            Me.ItemForInvoice.Text = "Invoice #"
            Me.ItemForInvoice.TextSize = New System.Drawing.Size(60, 20)
            Me.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.mapControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl.Layers.Add(Me.imageTilesLayer1)
            Me.mapControl.Layers.Add(Me.informationLayer1)
            Me.mapControl.Layers.Add(Me.informationLayer2)
            Me.mapControl.Layers.Add(Me.informationLayer3)
            Me.mapControl.Location = New System.Drawing.Point(16, 16)
            Me.mapControl.MinimumSize = New System.Drawing.Size(32, 32)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.SearchPanelOptions.Visible = False
            Me.mapControl.Size = New System.Drawing.Size(694, 610)
            Me.mapControl.TabIndex = 18
            Me.mapControl.ZoomLevel = 8R
            Me.roundedSkinPanel1.Controls.Add(Me.mapControl)
            Me.roundedSkinPanel1.Controls.Add(Me.roundedSkinPanel2)
            Me.roundedSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.roundedSkinPanel1.Location = New System.Drawing.Point(0, 120)
            Me.roundedSkinPanel1.Name = "roundedSkinPanel1"
            Me.roundedSkinPanel1.Size = New System.Drawing.Size(1226, 642)
            Me.roundedSkinPanel1.TabIndex = 3
            Me.roundedSkinPanel1.Text = "roundedSkinPanel1"
            Me.roundedSkinPanel2.Controls.Add(Me.moduleDataLayout)
            Me.roundedSkinPanel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.roundedSkinPanel2.Location = New System.Drawing.Point(710, 16)
            Me.roundedSkinPanel2.Name = "roundedSkinPanel2"
            Me.roundedSkinPanel2.Size = New System.Drawing.Size(500, 610)
            Me.roundedSkinPanel2.TabIndex = 0
            Me.roundedSkinPanel2.Text = "roundedSkinPanel2"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.roundedSkinPanel1)
            Me.Controls.Add(Me.ribbonControl)
            Me.Name = "OrderMapView"
            Me.Size = New System.Drawing.Size(1226, 762)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSourceRoute), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.moduleDataLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleDataLayout.ResumeLayout(False)
            CType((Me.LogoPictureEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForLogo), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForViewer), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForFullName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForInvoice), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel1.ResumeLayout(False)
            CType((Me.roundedSkinPanel2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl

        Private biClose As DevExpress.XtraBars.BarButtonItem

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private moduleDataLayout As DevExpress.XtraDataLayout.DataLayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private bindingSource As System.Windows.Forms.BindingSource

        Private NameLabel As DevExpress.XtraEditors.LabelControl

        Private LogoPictureEdit As DevExpress.XtraEditors.PictureEdit

        Private mapControl As DevExpress.XtraMap.MapControl

        Private bindingSourceRoute As System.Windows.Forms.BindingSource

        Private biPrint As DevExpress.XtraBars.BarButtonItem

        Private barExportItem As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private imageTilesLayer1 As DevExpress.XtraMap.ImageLayer

        Private azureMapDataProvider1 As DevExpress.XtraMap.AzureMapDataProvider

        Private informationLayer1 As DevExpress.XtraMap.InformationLayer

        Private azureGeocodeDataProvider1 As DevExpress.XtraMap.AzureGeocodeDataProvider

        Private informationLayer2 As DevExpress.XtraMap.InformationLayer

        Private azureSearchDataProvider1 As DevExpress.XtraMap.AzureSearchDataProvider

        Private informationLayer3 As DevExpress.XtraMap.InformationLayer

        Private azureRouteDataProvider1 As DevExpress.XtraMap.AzureRouteDataProvider

        Private Viewer As DevExpress.XtraPdfViewer.PdfViewer

        Private InvoiceLabel As DevExpress.XtraEditors.LabelControl

        Private roundedSkinPanel1 As DevExpress.XtraEditors.RoundedSkinPanel

        Private roundedSkinPanel2 As DevExpress.XtraEditors.RoundedSkinPanel

        Private ItemForLogo As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForFullName As DevExpress.XtraLayout.LayoutControlItem

        Private ItemForInvoice As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private ItemForViewer As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
