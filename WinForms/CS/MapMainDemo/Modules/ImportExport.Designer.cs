using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraMap.Demos {
    partial class ImportExport {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem5 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem6 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem7 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem8 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem9 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportExport));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.FileLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.ShapefileDataAdapter = new DevExpress.XtraMap.ShapefileDataAdapter();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.rpgLegendAlignment = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbLegendAlignment = new DevExpress.XtraBars.BarButtonItem();
            this.ddLegendAligment = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.chkPolitical = new DevExpress.XtraBars.BarCheckItem();
            this.chkGDP = new DevExpress.XtraBars.BarCheckItem();
            this.chkPopulation = new DevExpress.XtraBars.BarCheckItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportShape = new DevExpress.XtraBars.BarButtonItem();
            this.rpgMapKind = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgExport = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLegendAligment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.chkGDP,
            this.chkPolitical,
            this.chkPopulation,
            this.bbLegendAlignment});
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Size = new System.Drawing.Size(601, 141);
            // 
            // rpOptions
            // 
            this.rpOptions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgMapKind,
            this.rpgLegendAlignment,
            this.rpgExport});
            this.FileLayer.Data = this.ShapefileDataAdapter;
            this.FileLayer.Name = "FileLayer";
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(49D, 14D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.FileLayer);
            this.mapControl1.Location = new System.Drawing.Point(0, 141);
            this.mapControl1.MaxZoomLevel = 9D;
            this.mapControl1.MinZoomLevel = 4.7D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.ScrollArea = new DevExpress.Map.MapBounds(-10D, 80D, 25D, 30D);
            this.mapControl1.Size = new System.Drawing.Size(601, 330);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ToolTipController = this.toolTipController1;
            this.mapControl1.ZoomLevel = 4.7D;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.MinWidth = 165;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = ".shp-file";
            this.barButtonItem1.CategoryGuid = new System.Guid("f62a8a6f-3d2e-45c0-9eed-3470637db758");
            this.barButtonItem1.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.FormatSHP;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Tag = "shp";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = ".kml-file";
            this.barButtonItem2.CategoryGuid = new System.Guid("f62a8a6f-3d2e-45c0-9eed-3470637db758");
            this.barButtonItem2.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.FormatKML;
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.Tag = "kml";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = ".svg-file";
            this.barButtonItem3.CategoryGuid = new System.Guid("f62a8a6f-3d2e-45c0-9eed-3470637db758");
            this.barButtonItem3.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.FormatSVG;
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.Tag = "svg";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Export To", new System.Guid("f62a8a6f-3d2e-45c0-9eed-3470637db758"))});
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 3;
            // 
            // rpgLegendAlignment
            // 
            this.rpgLegendAlignment.AllowTextClipping = false;
            this.rpgLegendAlignment.ItemLinks.Add(this.bbLegendAlignment);
            this.rpgLegendAlignment.Name = "rpgLegendAlignment";
            // 
            // bbLegendAlignment
            // 
            this.bbLegendAlignment.ActAsDropDown = true;
            this.bbLegendAlignment.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbLegendAlignment.Caption = "Legend Alignment";
            this.bbLegendAlignment.DropDownControl = this.ddLegendAligment;
            this.bbLegendAlignment.Id = 20;
            this.bbLegendAlignment.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.LegendAlignment;
            this.bbLegendAlignment.Name = "bbLegendAlignment";
            // 
            // ddLegendAligment
            // 
            // 
            // 
            // 
            this.ddLegendAligment.Gallery.ColumnCount = 3;
            galleryItemGroup1.CaptionAlignment = DevExpress.XtraBars.Ribbon.GalleryItemGroupCaptionAlignment.Stretch;
            galleryItem1.Caption = "TopLeft";
            galleryItem1.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Alignment1;
            galleryItem2.Caption = "TopCenter";
            galleryItem2.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Alignment2;
            galleryItem3.Caption = "TopRight";
            galleryItem3.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Alignment3;
            galleryItem4.Caption = "MiddleLeft";
            galleryItem4.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Alignment4;
            galleryItem5.Enabled = false;
            galleryItem6.Caption = "MiddleRight";
            galleryItem6.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Alignment5;
            galleryItem7.Caption = "BottomLeft";
            galleryItem7.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Alignment8;
            galleryItem8.Caption = "BottomCenter";
            galleryItem8.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Alignment7;
            galleryItem9.Caption = "BottomRight";
            galleryItem9.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Alignment6;
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3,
            galleryItem4,
            galleryItem5,
            galleryItem6,
            galleryItem7,
            galleryItem8,
            galleryItem9});
            this.ddLegendAligment.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.ddLegendAligment.Gallery.ShowGroupCaption = false;
            this.ddLegendAligment.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide;
            this.ddLegendAligment.Name = "ddLegendAligment";
            this.ddLegendAligment.Ribbon = this.rpOptions.Ribbon;
            this.ddLegendAligment.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.ddLegendAligment_GalleryItemClick);
            // 
            // chkPolitical
            // 
            this.chkPolitical.Caption = "Political";
            this.chkPolitical.GroupIndex = 1;
            this.chkPolitical.Id = 1;
            this.chkPolitical.Name = "chkPolitical";
            this.chkPolitical.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.MapMode_CheckedChanged);
            this.chkPolitical.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Political;
            // 
            // chkGDP
            // 
            this.chkGDP.Caption = "GDP";
            this.chkGDP.GroupIndex = 1;
            this.chkGDP.Id = 2;
            this.chkGDP.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.GDP;
            this.chkGDP.Name = "chkGDP";
            this.chkGDP.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.MapMode_CheckedChanged);
            // 
            // chkPopulation
            // 
            this.chkPopulation.Caption = "Population";
            this.chkPopulation.GroupIndex = 1;
            this.chkPopulation.Id = 3;
            this.chkPopulation.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Population;
            this.chkPopulation.Name = "chkPopulation";
            this.chkPopulation.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.MapMode_CheckedChanged);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "TopLeft";
            this.barButtonItem5.Id = 11;
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "TopCenter";
            this.barButtonItem6.Id = 12;
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "TopRight";
            this.barButtonItem7.Id = 13;
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "MiddleLeft";
            this.barButtonItem8.Id = 14;
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "MiddleRight";
            this.barButtonItem9.Id = 15;
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // btnExportShape
            // 
            this.btnExportShape.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.CheckDropDown;
            this.btnExportShape.Caption = "Export Shapes To .shp file";
            this.btnExportShape.DropDownControl = this.popupMenu1;
            this.btnExportShape.Id = 18;
            this.btnExportShape.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Export;
            this.btnExportShape.Name = "btnExportShape";
            this.btnExportShape.Tag = "shp";
            this.btnExportShape.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportShape_ItemClick);
            // 
            // rpgMapKind
            // 
            this.rpgMapKind.ItemLinks.Add(this.chkPolitical);
            this.rpgMapKind.ItemLinks.Add(this.chkGDP);
            this.rpgMapKind.ItemLinks.Add(this.chkPopulation);
            this.rpgMapKind.Name = "rpgMapKind";
            this.rpgMapKind.Text = "Map Kind";
            // 
            // rpgExport
            // 
            this.rpgExport.AllowTextClipping = false;
            this.rpgExport.ItemLinks.Add(this.btnExportShape);
            this.rpgExport.Name = "rpgExport";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "Default", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Default",
            "TopLeft",
            "TopCenter",
            "TopRight",
            "MiddleLeft",
            "MiddleRight",
            "BottomLeft",
            "BottomRight"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Export...";
            // 
            // ImportExport
            // 
            this.Controls.Add(this.mapControl1);
            this.Name = "ImportExport";
            this.Size = new System.Drawing.Size(601, 480);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.Controls.SetChildIndex(this.mapControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddLegendAligment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapControl mapControl1;
        private Utils.ToolTipController toolTipController1;
        private XtraBars.PopupMenu popupMenu1;
        private XtraBars.BarButtonItem barButtonItem1;
        private XtraBars.BarButtonItem barButtonItem2;
        private XtraBars.BarButtonItem barButtonItem3;
        private XtraBars.BarManager barManager1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private VectorItemsLayer FileLayer;
        private ShapefileDataAdapter ShapefileDataAdapter;
        private XtraBars.BarCheckItem chkPolitical;
        private XtraBars.BarCheckItem chkGDP;
        private XtraBars.BarCheckItem chkPopulation;
        private XtraBars.Ribbon.RibbonPageGroup rpgMapKind;
        private XtraBars.Ribbon.RibbonPageGroup rpgLegendAlignment;
        private XtraBars.Ribbon.GalleryDropDown ddLegendAligment;
        private XtraBars.BarButtonItem barButtonItem5;
        private XtraBars.BarButtonItem barButtonItem6;
        private XtraBars.BarButtonItem barButtonItem7;
        private XtraBars.BarButtonItem barButtonItem8;
        private XtraBars.BarButtonItem barButtonItem9;
        private XtraBars.BarButtonItem btnExportShape;
        private XtraBars.Ribbon.RibbonPageGroup rpgExport;
        private XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private XtraBars.BarButtonItem bbLegendAlignment;
    }
}
