Namespace DevExpress.DevAV.Modules

    Partial Class QuoteMapView

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
            Dim keyColorColorizer1 As DevExpress.XtraMap.KeyColorColorizer = New DevExpress.XtraMap.KeyColorColorizer()
            Dim argumentItemKeyProvider1 As DevExpress.XtraMap.ArgumentItemKeyProvider = New DevExpress.XtraMap.ArgumentItemKeyProvider()
            Dim mapCallout1 As DevExpress.XtraMap.MapCallout = New DevExpress.XtraMap.MapCallout()
            Me.imageLayer1 = New DevExpress.XtraMap.ImageLayer()
            Me.azureMapDataProvider1 = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.vectorItemsLayer1 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.bubbleChartDataAdapter1 = New DevExpress.XtraMap.BubbleChartDataAdapter()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.vectorItemsLayer2 = New DevExpress.XtraMap.VectorItemsLayer()
            Me.mapItemStorage1 = New DevExpress.XtraMap.MapItemStorage()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biSave = New DevExpress.XtraBars.BarButtonItem()
            Me.biClose = New DevExpress.XtraBars.BarButtonItem()
            Me.biSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrint = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrintPreview = New DevExpress.XtraBars.BarButtonItem()
            Me.barExportItem = New DevExpress.XtraBars.BarButtonItem()
            Me.biHigh = New DevExpress.XtraBars.BarCheckItem()
            Me.biMedium = New DevExpress.XtraBars.BarCheckItem()
            Me.biLow = New DevExpress.XtraBars.BarCheckItem()
            Me.biUnlikely = New DevExpress.XtraBars.BarCheckItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.roundedSkinPanel1 = New DevExpress.XtraEditors.RoundedSkinPanel()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel1.SuspendLayout()
            Me.SuspendLayout()
            Me.imageLayer1.DataProvider = Me.azureMapDataProvider1
            Me.azureMapDataProvider1.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1
            Me.vectorItemsLayer1.Colorizer = keyColorColorizer1
            Me.vectorItemsLayer1.Data = Me.bubbleChartDataAdapter1
            Me.vectorItemsLayer1.ToolTipPattern = "City:%A% Value:%V%"
            AddHandler Me.vectorItemsLayer1.DataLoaded, New DevExpress.XtraMap.DataLoadedEventHandler(AddressOf Me.ItemsLayer_DataLoaded)
            Me.bubbleChartDataAdapter1.BubbleItemDataMember = "City"
            Me.bubbleChartDataAdapter1.DataSource = Me.bindingSource
            Me.bubbleChartDataAdapter1.Mappings.BubbleGroup = "Index"
            Me.bubbleChartDataAdapter1.Mappings.Latitude = "Latitude"
            Me.bubbleChartDataAdapter1.Mappings.Longitude = "Longitude"
            Me.bubbleChartDataAdapter1.Mappings.Value = "Value"
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.QuoteMapItem)
            Me.vectorItemsLayer2.Data = Me.mapItemStorage1
            mapCallout1.AllowHtmlText = True
            mapCallout1.Text = "Test"
            Me.mapItemStorage1.Items.Add(mapCallout1)
            Me.ribbonControl.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.biSave, Me.biClose, Me.biSaveAndClose, Me.biDelete, Me.biPrint, Me.biPrintPreview, Me.barExportItem, Me.biHigh, Me.biMedium, Me.biLow, Me.biUnlikely})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 20
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
            Me.ribbonControl.Size = New System.Drawing.Size(1226, 120)
            Me.biSave.Caption = "Save"
            Me.biSave.Id = 1
            Me.biSave.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biSave.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biSave.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Save.svg"
            Me.biSave.Name = "biSave"
            Me.biClose.Caption = "Close"
            Me.biClose.Id = 2
            Me.biClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biClose.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biClose.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg"
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
            Me.biHigh.Caption = "High"
            Me.biHigh.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.biHigh.Id = 16
            Me.biHigh.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biHigh.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biHigh.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.High.svg"
            Me.biHigh.Name = "biHigh"
            Me.biMedium.Caption = "Medium"
            Me.biMedium.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.biMedium.Id = 17
            Me.biMedium.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biMedium.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMedium.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Medium.svg"
            Me.biMedium.Name = "biMedium"
            Me.biLow.Caption = "Low"
            Me.biLow.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.biLow.Id = 18
            Me.biLow.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biLow.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biLow.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Low.svg"
            Me.biLow.Name = "biLow"
            Me.biUnlikely.Caption = "Unlikely"
            Me.biUnlikely.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
            Me.biUnlikely.Id = 19
            Me.biUnlikely.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biUnlikely.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biUnlikely.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Unlike.svg"
            Me.biUnlikely.Name = "biUnlikely"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup5, Me.ribbonPageGroup4, Me.ribbonPageGroup3})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Home"
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
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biHigh)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biMedium)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biLow)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biUnlikely)
            Me.ribbonPageGroup4.MergeOrder = 0
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.Text = "Opportunities"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biClose)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.Text = "Close"
            Me.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.mapControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl.Layers.Add(Me.imageLayer1)
            Me.mapControl.Layers.Add(Me.vectorItemsLayer1)
            Me.mapControl.Layers.Add(Me.vectorItemsLayer2)
            Me.mapControl.Location = New System.Drawing.Point(16, 16)
            Me.mapControl.MinimumSize = New System.Drawing.Size(32, 32)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(1194, 610)
            Me.mapControl.TabIndex = 18
            Me.mapControl.ZoomLevel = 8R
            Me.roundedSkinPanel1.Controls.Add(Me.mapControl)
            Me.roundedSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.roundedSkinPanel1.Location = New System.Drawing.Point(0, 120)
            Me.roundedSkinPanel1.Name = "roundedSkinPanel1"
            Me.roundedSkinPanel1.Size = New System.Drawing.Size(1226, 642)
            Me.roundedSkinPanel1.TabIndex = 4
            Me.roundedSkinPanel1.Text = "roundedSkinPanel1"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.roundedSkinPanel1)
            Me.Controls.Add(Me.ribbonControl)
            Me.Margin = New System.Windows.Forms.Padding(6)
            Me.Name = "QuoteMapView"
            Me.Size = New System.Drawing.Size(1226, 762)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private bindingSource As System.Windows.Forms.BindingSource

        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl

        Private biSave As DevExpress.XtraBars.BarButtonItem

        Private biClose As DevExpress.XtraBars.BarButtonItem

        Private biSaveAndClose As DevExpress.XtraBars.BarButtonItem

        Private biDelete As DevExpress.XtraBars.BarButtonItem

        Private biPrint As DevExpress.XtraBars.BarButtonItem

        Private biPrintPreview As DevExpress.XtraBars.BarButtonItem

        Private barExportItem As DevExpress.XtraBars.BarButtonItem

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private mapControl As DevExpress.XtraMap.MapControl

        Private biHigh As DevExpress.XtraBars.BarCheckItem

        Private biMedium As DevExpress.XtraBars.BarCheckItem

        Private biLow As DevExpress.XtraBars.BarCheckItem

        Private biUnlikely As DevExpress.XtraBars.BarCheckItem

        Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private imageLayer1 As DevExpress.XtraMap.ImageLayer

        Private azureMapDataProvider1 As DevExpress.XtraMap.AzureMapDataProvider

        Private vectorItemsLayer1 As DevExpress.XtraMap.VectorItemsLayer

        Private bubbleChartDataAdapter1 As DevExpress.XtraMap.BubbleChartDataAdapter

        Private vectorItemsLayer2 As DevExpress.XtraMap.VectorItemsLayer

        Private mapItemStorage1 As DevExpress.XtraMap.MapItemStorage

        Private roundedSkinPanel1 As DevExpress.XtraEditors.RoundedSkinPanel
    End Class
End Namespace
