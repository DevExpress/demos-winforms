Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraMap.Demos

    Partial Class ImportExport

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
            Dim galleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItem1 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem2 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem3 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem4 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem5 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem6 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem7 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem8 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem9 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraMap.Demos.ImportExport))
            Dim editorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim serializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.FileLayer = New DevExpress.XtraMap.VectorItemsLayer()
            Me.ShapefileDataAdapter = New DevExpress.XtraMap.ShapefileDataAdapter()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
            Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.rpgLegendAlignment = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.bbLegendAlignment = New DevExpress.XtraBars.BarButtonItem()
            Me.ddLegendAligment = New DevExpress.XtraBars.Ribbon.GalleryDropDown(Me.components)
            Me.chkPolitical = New DevExpress.XtraBars.BarCheckItem()
            Me.chkGDP = New DevExpress.XtraBars.BarCheckItem()
            Me.chkPopulation = New DevExpress.XtraBars.BarCheckItem()
            Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
            Me.btnExportShape = New DevExpress.XtraBars.BarButtonItem()
            Me.rpgMapKind = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.rpgExport = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ddLegendAligment), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemButtonEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.chkGDP, Me.chkPolitical, Me.chkPopulation, Me.bbLegendAlignment})
            Me.ribbonControl1.MaxItemId = 8
            Me.ribbonControl1.Size = New System.Drawing.Size(601, 141)
            ' 
            ' rpOptions
            ' 
            Me.rpOptions.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.rpgMapKind, Me.rpgLegendAlignment, Me.rpgExport})
            Me.FileLayer.Data = Me.ShapefileDataAdapter
            Me.FileLayer.Name = "FileLayer"
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mapControl1.CenterPoint = New DevExpress.XtraMap.GeoPoint(49R, 14R)
            Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl1.Layers.Add(Me.FileLayer)
            Me.mapControl1.Location = New System.Drawing.Point(0, 141)
            Me.mapControl1.MaxZoomLevel = 9R
            Me.mapControl1.MinZoomLevel = 4.7R
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.ScrollArea = New DevExpress.Map.MapBounds(-10R, 80R, 25R, 30R)
            Me.mapControl1.Size = New System.Drawing.Size(601, 330)
            Me.mapControl1.TabIndex = 0
            Me.mapControl1.ToolTipController = Me.toolTipController1
            Me.mapControl1.ZoomLevel = 4.7R
            ' 
            ' popupMenu1
            ' 
            Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3)})
            Me.popupMenu1.Manager = Me.barManager1
            Me.popupMenu1.MinWidth = 165
            Me.popupMenu1.Name = "popupMenu1"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = ".shp-file"
            Me.barButtonItem1.CategoryGuid = New System.Guid("f62a8a6f-3d2e-45c0-9eed-3470637db758")
            Me.barButtonItem1.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.FormatSHP
            Me.barButtonItem1.Id = 0
            Me.barButtonItem1.Name = "barButtonItem1"
            Me.barButtonItem1.Tag = "shp"
            AddHandler Me.barButtonItem1.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.Export_ItemClick)
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = ".kml-file"
            Me.barButtonItem2.CategoryGuid = New System.Guid("f62a8a6f-3d2e-45c0-9eed-3470637db758")
            Me.barButtonItem2.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.FormatKML
            Me.barButtonItem2.Id = 1
            Me.barButtonItem2.Name = "barButtonItem2"
            Me.barButtonItem2.Tag = "kml"
            AddHandler Me.barButtonItem2.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.Export_ItemClick)
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = ".svg-file"
            Me.barButtonItem3.CategoryGuid = New System.Guid("f62a8a6f-3d2e-45c0-9eed-3470637db758")
            Me.barButtonItem3.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.FormatSVG
            Me.barButtonItem3.Id = 2
            Me.barButtonItem3.Name = "barButtonItem3"
            Me.barButtonItem3.Tag = "svg"
            AddHandler Me.barButtonItem3.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.Export_ItemClick)
            ' 
            ' barManager1
            ' 
            Me.barManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("Export To", New System.Guid("f62a8a6f-3d2e-45c0-9eed-3470637db758"))})
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3})
            Me.barManager1.MaxItemId = 3
            ' 
            ' rpgLegendAlignment
            ' 
            Me.rpgLegendAlignment.AllowTextClipping = False
            Me.rpgLegendAlignment.ItemLinks.Add(Me.bbLegendAlignment)
            Me.rpgLegendAlignment.Name = "rpgLegendAlignment"
            ' 
            ' bbLegendAlignment
            ' 
            Me.bbLegendAlignment.ActAsDropDown = True
            Me.bbLegendAlignment.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.bbLegendAlignment.Caption = "Legend Alignment"
            Me.bbLegendAlignment.DropDownControl = Me.ddLegendAligment
            Me.bbLegendAlignment.Id = 20
            Me.bbLegendAlignment.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.LegendAlignment
            Me.bbLegendAlignment.Name = "bbLegendAlignment"
            ' 
            ' ddLegendAligment
            ' 
            ' 
            ' 
            ' 
            Me.ddLegendAligment.Gallery.ColumnCount = 3
            galleryItemGroup1.CaptionAlignment = DevExpress.XtraBars.Ribbon.GalleryItemGroupCaptionAlignment.Stretch
            galleryItem1.Caption = "TopLeft"
            galleryItem1.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Alignment1
            galleryItem2.Caption = "TopCenter"
            galleryItem2.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Alignment2
            galleryItem3.Caption = "TopRight"
            galleryItem3.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Alignment3
            galleryItem4.Caption = "MiddleLeft"
            galleryItem4.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Alignment4
            galleryItem5.Enabled = False
            galleryItem6.Caption = "MiddleRight"
            galleryItem6.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Alignment5
            galleryItem7.Caption = "BottomLeft"
            galleryItem7.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Alignment8
            galleryItem8.Caption = "BottomCenter"
            galleryItem8.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Alignment7
            galleryItem9.Caption = "BottomRight"
            galleryItem9.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Alignment6
            galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {galleryItem1, galleryItem2, galleryItem3, galleryItem4, galleryItem5, galleryItem6, galleryItem7, galleryItem8, galleryItem9})
            Me.ddLegendAligment.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup1})
            Me.ddLegendAligment.Gallery.ShowGroupCaption = False
            Me.ddLegendAligment.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
            Me.ddLegendAligment.Name = "ddLegendAligment"
            Me.ddLegendAligment.Ribbon = Me.rpOptions.Ribbon
            AddHandler Me.ddLegendAligment.GalleryItemClick, New DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(AddressOf Me.ddLegendAligment_GalleryItemClick)
            ' 
            ' chkPolitical
            ' 
            Me.chkPolitical.Caption = "Political"
            Me.chkPolitical.GroupIndex = 1
            Me.chkPolitical.Id = 1
            Me.chkPolitical.Name = "chkPolitical"
            AddHandler Me.chkPolitical.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.MapMode_CheckedChanged)
            Me.chkPolitical.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Political
            ' 
            ' chkGDP
            ' 
            Me.chkGDP.Caption = "GDP"
            Me.chkGDP.GroupIndex = 1
            Me.chkGDP.Id = 2
            Me.chkGDP.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.GDP
            Me.chkGDP.Name = "chkGDP"
            AddHandler Me.chkGDP.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.MapMode_CheckedChanged)
            ' 
            ' chkPopulation
            ' 
            Me.chkPopulation.Caption = "Population"
            Me.chkPopulation.GroupIndex = 1
            Me.chkPopulation.Id = 3
            Me.chkPopulation.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Population
            Me.chkPopulation.Name = "chkPopulation"
            AddHandler Me.chkPopulation.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.MapMode_CheckedChanged)
            ' 
            ' barButtonItem5
            ' 
            Me.barButtonItem5.Caption = "TopLeft"
            Me.barButtonItem5.Id = 11
            Me.barButtonItem5.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem5.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem5.Name = "barButtonItem5"
            ' 
            ' barButtonItem6
            ' 
            Me.barButtonItem6.Caption = "TopCenter"
            Me.barButtonItem6.Id = 12
            Me.barButtonItem6.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem6.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem6.Name = "barButtonItem6"
            ' 
            ' barButtonItem7
            ' 
            Me.barButtonItem7.Caption = "TopRight"
            Me.barButtonItem7.Id = 13
            Me.barButtonItem7.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem7.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem7.Name = "barButtonItem7"
            ' 
            ' barButtonItem8
            ' 
            Me.barButtonItem8.Caption = "MiddleLeft"
            Me.barButtonItem8.Id = 14
            Me.barButtonItem8.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem8.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem8.Name = "barButtonItem8"
            ' 
            ' barButtonItem9
            ' 
            Me.barButtonItem9.Caption = "MiddleRight"
            Me.barButtonItem9.Id = 15
            Me.barButtonItem9.ImageOptions.LargeImage = CType((resources.GetObject("barButtonItem9.ImageOptions.LargeImage")), System.Drawing.Image)
            Me.barButtonItem9.Name = "barButtonItem9"
            ' 
            ' btnExportShape
            ' 
            Me.btnExportShape.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown
            Me.btnExportShape.Caption = "Export Shapes To .shp file"
            Me.btnExportShape.DropDownControl = Me.popupMenu1
            Me.btnExportShape.Id = 18
            Me.btnExportShape.ImageOptions.SvgImage = Global.DevExpress.XtraMap.Demos.Properties.Resources.Export
            Me.btnExportShape.Name = "btnExportShape"
            Me.btnExportShape.Tag = "shp"
            AddHandler Me.btnExportShape.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.btnExportShape_ItemClick)
            ' 
            ' rpgMapKind
            ' 
            Me.rpgMapKind.ItemLinks.Add(Me.chkPolitical)
            Me.rpgMapKind.ItemLinks.Add(Me.chkGDP)
            Me.rpgMapKind.ItemLinks.Add(Me.chkPopulation)
            Me.rpgMapKind.Name = "rpgMapKind"
            Me.rpgMapKind.Text = "Map Kind"
            ' 
            ' rpgExport
            ' 
            Me.rpgExport.AllowTextClipping = False
            Me.rpgExport.ItemLinks.Add(Me.btnExportShape)
            Me.rpgExport.Name = "rpgExport"
            ' 
            ' repositoryItemButtonEdit1
            ' 
            Me.repositoryItemButtonEdit1.AutoHeight = False
            Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
            ' 
            ' repositoryItemComboBox1
            ' 
            Me.repositoryItemComboBox1.AutoHeight = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, True, True, False, editorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.repositoryItemComboBox1.Items.AddRange(New Object() {"Default", "TopLeft", "TopCenter", "TopRight", "MiddleLeft", "MiddleRight", "BottomLeft", "BottomRight"})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' saveFileDialog1
            ' 
            Me.saveFileDialog1.Title = "Export..."
            ' 
            ' ImportExport
            ' 
            Me.Controls.Add(Me.mapControl1)
            Me.Name = "ImportExport"
            Me.Size = New System.Drawing.Size(601, 480)
            Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
            Me.Controls.SetChildIndex(Me.mapControl1, 0)
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupMenu1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ddLegendAligment), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemButtonEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private toolTipController1 As DevExpress.Utils.ToolTipController

        Private popupMenu1 As DevExpress.XtraBars.PopupMenu

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog

        Private FileLayer As DevExpress.XtraMap.VectorItemsLayer

        Private ShapefileDataAdapter As DevExpress.XtraMap.ShapefileDataAdapter

        Private chkPolitical As DevExpress.XtraBars.BarCheckItem

        Private chkGDP As DevExpress.XtraBars.BarCheckItem

        Private chkPopulation As DevExpress.XtraBars.BarCheckItem

        Private rpgMapKind As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private rpgLegendAlignment As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ddLegendAligment As DevExpress.XtraBars.Ribbon.GalleryDropDown

        Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem6 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem7 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem8 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem9 As DevExpress.XtraBars.BarButtonItem

        Private btnExportShape As DevExpress.XtraBars.BarButtonItem

        Private rpgExport As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox

        Private bbLegendAlignment As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace
