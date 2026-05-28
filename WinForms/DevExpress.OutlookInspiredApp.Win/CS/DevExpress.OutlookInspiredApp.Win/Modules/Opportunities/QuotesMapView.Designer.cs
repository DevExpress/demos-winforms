namespace DevExpress.DevAV.Modules {
    partial class QuoteMapView {
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
            DevExpress.XtraMap.KeyColorColorizer keyColorColorizer1 = new DevExpress.XtraMap.KeyColorColorizer();
            DevExpress.XtraMap.ArgumentItemKeyProvider argumentItemKeyProvider1 = new DevExpress.XtraMap.ArgumentItemKeyProvider();
            DevExpress.XtraMap.MapCallout mapCallout1 = new DevExpress.XtraMap.MapCallout();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.azureMapDataProvider1 = new DevExpress.XtraMap.AzureMapDataProvider();
            this.vectorItemsLayer1 = new DevExpress.XtraMap.VectorItemsLayer();
            this.bubbleChartDataAdapter1 = new DevExpress.XtraMap.BubbleChartDataAdapter();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vectorItemsLayer2 = new DevExpress.XtraMap.VectorItemsLayer();
            this.mapItemStorage1 = new DevExpress.XtraMap.MapItemStorage();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biSave = new DevExpress.XtraBars.BarButtonItem();
            this.biClose = new DevExpress.XtraBars.BarButtonItem();
            this.biSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.biDelete = new DevExpress.XtraBars.BarButtonItem();
            this.biPrint = new DevExpress.XtraBars.BarButtonItem();
            this.biPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.barExportItem = new DevExpress.XtraBars.BarButtonItem();
            this.biHigh = new DevExpress.XtraBars.BarCheckItem();
            this.biMedium = new DevExpress.XtraBars.BarCheckItem();
            this.biLow = new DevExpress.XtraBars.BarCheckItem();
            this.biUnlikely = new DevExpress.XtraBars.BarCheckItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.roundedSkinPanel1 = new DevExpress.XtraEditors.RoundedSkinPanel();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel1)).BeginInit();
            this.roundedSkinPanel1.SuspendLayout();
            this.SuspendLayout();
            this.imageLayer1.DataProvider = this.azureMapDataProvider1;
            this.azureMapDataProvider1.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad;
            keyColorColorizer1.ItemKeyProvider = argumentItemKeyProvider1;
            this.vectorItemsLayer1.Colorizer = keyColorColorizer1;
            this.vectorItemsLayer1.Data = this.bubbleChartDataAdapter1;
            this.vectorItemsLayer1.ToolTipPattern = "City:%A% Value:%V%";
            this.vectorItemsLayer1.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.ItemsLayer_DataLoaded);
            this.bubbleChartDataAdapter1.BubbleItemDataMember = "City";
            this.bubbleChartDataAdapter1.DataSource = this.bindingSource;
            this.bubbleChartDataAdapter1.Mappings.BubbleGroup = "Index";
            this.bubbleChartDataAdapter1.Mappings.Latitude = "Latitude";
            this.bubbleChartDataAdapter1.Mappings.Longitude = "Longitude";
            this.bubbleChartDataAdapter1.Mappings.Value = "Value";
            
            
            
            this.bindingSource.DataSource = typeof(DevExpress.DevAV.QuoteMapItem);
            this.vectorItemsLayer2.Data = this.mapItemStorage1;
            mapCallout1.AllowHtmlText = true;
            mapCallout1.Text = "Test";
            this.mapItemStorage1.Items.Add(mapCallout1);
            
            
            
            this.ribbonControl.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.biSave,
            this.biClose,
            this.biSaveAndClose,
            this.biDelete,
            this.biPrint,
            this.biPrintPreview,
            this.barExportItem,
            this.biHigh,
            this.biMedium,
            this.biLow,
            this.biUnlikely});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 20;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.Size = new System.Drawing.Size(1226, 120);
            
            
            
            this.biSave.Caption = "Save";
            this.biSave.Id = 1;
            this.biSave.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biSave.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biSave.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Save.svg";
            this.biSave.Name = "biSave";
            
            
            
            this.biClose.Caption = "Close";
            this.biClose.Id = 2;
            this.biClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biClose.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biClose.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg";
            this.biClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape);
            this.biClose.Name = "biClose";
            
            
            
            this.biSaveAndClose.Caption = "Save && Close";
            this.biSaveAndClose.Id = 3;
            this.biSaveAndClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biSaveAndClose.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biSaveAndClose.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.SaveAndClose.svg";
            this.biSaveAndClose.Name = "biSaveAndClose";
            
            
            
            this.biDelete.Caption = "Delete";
            this.biDelete.Id = 4;
            this.biDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biDelete.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biDelete.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg";
            this.biDelete.Name = "biDelete";
            
            
            
            this.biPrint.Caption = "Print";
            this.biPrint.Id = 8;
            this.biPrint.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biPrint.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biPrint.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg";
            this.biPrint.Name = "biPrint";
            
            
            
            this.biPrintPreview.Caption = "Print Preview";
            this.biPrintPreview.Id = 9;
            this.biPrintPreview.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biPrintPreview.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biPrintPreview.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintPreview.svg";
            this.biPrintPreview.Name = "biPrintPreview";
            
            
            
            this.barExportItem.Caption = "Export";
            this.barExportItem.Id = 11;
            this.barExportItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.barExportItem.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.barExportItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Export.svg";
            this.barExportItem.ImageOptions.LargeImageIndex = 50;
            this.barExportItem.Name = "barExportItem";
            
            
            
            this.biHigh.Caption = "High";
            this.biHigh.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.biHigh.Id = 16;
            this.biHigh.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biHigh.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biHigh.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.High.svg";
            this.biHigh.Name = "biHigh";
            
            
            
            this.biMedium.Caption = "Medium";
            this.biMedium.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.biMedium.Id = 17;
            this.biMedium.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biMedium.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biMedium.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Medium.svg";
            this.biMedium.Name = "biMedium";
            
            
            
            this.biLow.Caption = "Low";
            this.biLow.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.biLow.Id = 18;
            this.biLow.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biLow.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biLow.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Low.svg";
            this.biLow.Name = "biLow";
            
            
            
            this.biUnlikely.Caption = "Unlikely";
            this.biUnlikely.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.biUnlikely.Id = 19;
            this.biUnlikely.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biUnlikely.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biUnlikely.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Unlike.svg";
            this.biUnlikely.Name = "biUnlikely";
            
            
            
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup5,
            this.ribbonPageGroup4,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            
            
            
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.biSave);
            this.ribbonPageGroup1.ItemLinks.Add(this.biSaveAndClose);
            this.ribbonPageGroup1.MergeOrder = 0;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            
            
            
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.biDelete);
            this.ribbonPageGroup2.MergeOrder = 0;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Delete";
            
            
            
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup5.ItemLinks.Add(this.biPrintPreview);
            this.ribbonPageGroup5.ItemLinks.Add(this.biPrint);
            this.ribbonPageGroup5.ItemLinks.Add(this.barExportItem);
            this.ribbonPageGroup5.MergeOrder = 0;
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Print and Export";
            
            
            
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup4.ItemLinks.Add(this.biHigh);
            this.ribbonPageGroup4.ItemLinks.Add(this.biMedium);
            this.ribbonPageGroup4.ItemLinks.Add(this.biLow);
            this.ribbonPageGroup4.ItemLinks.Add(this.biUnlikely);
            this.ribbonPageGroup4.MergeOrder = 0;
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Opportunities";
            
            
            
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup3.ItemLinks.Add(this.biClose);
            this.ribbonPageGroup3.MergeOrder = 0;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Close";
            
            
            
            this.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Layers.Add(this.imageLayer1);
            this.mapControl.Layers.Add(this.vectorItemsLayer1);
            this.mapControl.Layers.Add(this.vectorItemsLayer2);
            this.mapControl.Location = new System.Drawing.Point(16, 16);
            this.mapControl.MinimumSize = new System.Drawing.Size(32, 32);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(1194, 610);
            this.mapControl.TabIndex = 18;
            this.mapControl.ZoomLevel = 8D;
            
            
            
            this.roundedSkinPanel1.Controls.Add(this.mapControl);
            this.roundedSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedSkinPanel1.Location = new System.Drawing.Point(0, 120);
            this.roundedSkinPanel1.Name = "roundedSkinPanel1";
            this.roundedSkinPanel1.Size = new System.Drawing.Size(1226, 642);
            this.roundedSkinPanel1.TabIndex = 4;
            this.roundedSkinPanel1.Text = "roundedSkinPanel1";
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedSkinPanel1);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "QuoteMapView";
            this.Size = new System.Drawing.Size(1226, 762);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel1)).EndInit();
            this.roundedSkinPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private XtraBars.Ribbon.RibbonControl ribbonControl;
        private XtraBars.BarButtonItem biSave;
        private XtraBars.BarButtonItem biClose;
        private XtraBars.BarButtonItem biSaveAndClose;
        private XtraBars.BarButtonItem biDelete;
        private XtraBars.BarButtonItem biPrint;
        private XtraBars.BarButtonItem biPrintPreview;
        private XtraBars.BarButtonItem barExportItem;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraMap.MapControl mapControl;
        private XtraBars.BarCheckItem biHigh;
        private XtraBars.BarCheckItem biMedium;
        private XtraBars.BarCheckItem biLow;
        private XtraBars.BarCheckItem biUnlikely;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private XtraMap.ImageLayer imageLayer1;
        private XtraMap.AzureMapDataProvider azureMapDataProvider1;
        private XtraMap.VectorItemsLayer vectorItemsLayer1;
        private XtraMap.BubbleChartDataAdapter bubbleChartDataAdapter1;
        private XtraMap.VectorItemsLayer vectorItemsLayer2;
        private XtraMap.MapItemStorage mapItemStorage1;
        private XtraEditors.RoundedSkinPanel roundedSkinPanel1;
    }
}
