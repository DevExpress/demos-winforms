namespace DevExpress.DevAV.Modules {
    partial class OrderMapView {
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
            this.imageTilesLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.azureMapDataProvider1 = new DevExpress.XtraMap.AzureMapDataProvider();
            this.informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            this.azureGeocodeDataProvider1 = new DevExpress.XtraMap.AzureGeocodeDataProvider();
            this.informationLayer2 = new DevExpress.XtraMap.InformationLayer();
            this.azureSearchDataProvider1 = new DevExpress.XtraMap.AzureSearchDataProvider();
            this.informationLayer3 = new DevExpress.XtraMap.InformationLayer();
            this.azureRouteDataProvider1 = new DevExpress.XtraMap.AzureRouteDataProvider();
            this.bindingSourceRoute = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biClose = new DevExpress.XtraBars.BarButtonItem();
            this.biPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barExportItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduleDataLayout = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.Viewer = new DevExpress.XtraPdfViewer.PdfViewer();
            this.InvoiceLabel = new DevExpress.XtraEditors.LabelControl();
            this.NameLabel = new DevExpress.XtraEditors.LabelControl();
            this.LogoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForLogo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForViewer = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForFullName = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForInvoice = new DevExpress.XtraLayout.LayoutControlItem();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.roundedSkinPanel1 = new DevExpress.XtraEditors.RoundedSkinPanel();
            this.roundedSkinPanel2 = new DevExpress.XtraEditors.RoundedSkinPanel();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleDataLayout)).BeginInit();
            this.moduleDataLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel1)).BeginInit();
            this.roundedSkinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel2)).BeginInit();
            this.roundedSkinPanel2.SuspendLayout();
            this.SuspendLayout();
            this.imageTilesLayer1.DataProvider = this.azureMapDataProvider1;
            this.azureMapDataProvider1.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad;
            this.informationLayer1.DataProvider = this.azureGeocodeDataProvider1;
            this.azureGeocodeDataProvider1.GenerateLayerItems = false;
            this.informationLayer2.DataProvider = this.azureSearchDataProvider1;
            this.azureSearchDataProvider1.GenerateLayerItems = false;
            this.informationLayer3.DataProvider = this.azureRouteDataProvider1;
            this.informationLayer3.HighlightedItemStyle.Stroke = System.Drawing.Color.Cyan;
            this.informationLayer3.HighlightedItemStyle.StrokeWidth = 3;
            this.informationLayer3.ItemStyle.Stroke = System.Drawing.Color.Cyan;
            this.informationLayer3.ItemStyle.StrokeWidth = 3;
            
            
            
            this.bindingSourceRoute.DataSource = typeof(DevExpress.DevAV.Presenters.RoutePoint);
            
            
            
            this.ribbonControl.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.biClose,
            this.biPrint,
            this.barExportItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 12;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1226, 120);
            
            
            
            this.biClose.Caption = "Close";
            this.biClose.Id = 2;
            this.biClose.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biClose.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biClose.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Close.svg";
            this.biClose.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Escape);
            this.biClose.Name = "biClose";
            
            
            
            this.biPrint.Caption = "Print";
            this.biPrint.Id = 8;
            this.biPrint.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.biPrint.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.biPrint.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg";
            this.biPrint.Name = "biPrint";
            
            
            
            this.barExportItem.Caption = "Export";
            this.barExportItem.Id = 11;
            this.barExportItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.barExportItem.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.barExportItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Export.svg";
            this.barExportItem.ImageOptions.LargeImageIndex = 50;
            this.barExportItem.Name = "barExportItem";
            
            
            
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            
            
            
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup5.ItemLinks.Add(this.biPrint);
            this.ribbonPageGroup5.ItemLinks.Add(this.barExportItem);
            this.ribbonPageGroup5.MergeOrder = 0;
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Print and Export";
            
            
            
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup3.ItemLinks.Add(this.biClose);
            this.ribbonPageGroup3.MergeOrder = 0;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Close";
            
            
            
            this.bindingSource.DataSource = typeof(DevExpress.DevAV.ViewModels.OrderMapViewModel);
            
            
            
            this.moduleDataLayout.AllowCustomization = false;
            this.moduleDataLayout.Controls.Add(this.Viewer);
            this.moduleDataLayout.Controls.Add(this.InvoiceLabel);
            this.moduleDataLayout.Controls.Add(this.NameLabel);
            this.moduleDataLayout.Controls.Add(this.LogoPictureEdit);
            this.moduleDataLayout.DataSource = this.bindingSource;
            this.moduleDataLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleDataLayout.Location = new System.Drawing.Point(16, 0);
            this.moduleDataLayout.MinimumSize = new System.Drawing.Size(32, 32);
            this.moduleDataLayout.Name = "moduleDataLayout";
            this.moduleDataLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(3215, 123, 650, 723);
            this.moduleDataLayout.Root = this.layoutControlGroup1;
            this.moduleDataLayout.Size = new System.Drawing.Size(484, 610);
            this.moduleDataLayout.TabIndex = 1;
            this.moduleDataLayout.Text = "moduleDataLayout";
            
            
            
            this.Viewer.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Viewer.Appearance.Options.UseBackColor = true;
            this.Viewer.DetachStreamAfterLoadComplete = true;
            this.Viewer.Location = new System.Drawing.Point(16, 154);
            this.Viewer.MenuManager = this.ribbonControl;
            this.Viewer.MinimumSize = new System.Drawing.Size(400, 0);
            this.Viewer.Name = "Viewer";
            this.Viewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden;
            this.Viewer.NavigationPanePageVisibility = DevExpress.XtraPdfViewer.PdfNavigationPanePageVisibility.None;
            this.Viewer.Size = new System.Drawing.Size(452, 440);
            this.Viewer.TabIndex = 20;
            this.Viewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.PageLevel;
            
            
            
            this.InvoiceLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.InvoiceLabel.Appearance.Options.UseFont = true;
            this.InvoiceLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Entity.InvoiceNumber", true));
            this.InvoiceLabel.Location = new System.Drawing.Point(224, 100);
            this.InvoiceLabel.Name = "InvoiceLabel";
            this.InvoiceLabel.Size = new System.Drawing.Size(228, 20);
            this.InvoiceLabel.StyleController = this.moduleDataLayout;
            this.InvoiceLabel.TabIndex = 19;
            
            
            
            this.NameLabel.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.NameLabel.Appearance.Options.UseFont = true;
            this.NameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Name", true));
            this.NameLabel.Location = new System.Drawing.Point(158, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(294, 32);
            this.NameLabel.StyleController = this.moduleDataLayout;
            this.NameLabel.TabIndex = 8;
            
            
            
            this.LogoPictureEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogoPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bindingSource, "Logo", true));
            this.LogoPictureEdit.Location = new System.Drawing.Point(16, 16);
            this.LogoPictureEdit.MaximumSize = new System.Drawing.Size(120, 120);
            this.LogoPictureEdit.MenuManager = this.ribbonControl;
            this.LogoPictureEdit.MinimumSize = new System.Drawing.Size(120, 120);
            this.LogoPictureEdit.Name = "LogoPictureEdit";
            this.LogoPictureEdit.Properties.ReadOnly = true;
            this.LogoPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.LogoPictureEdit.Size = new System.Drawing.Size(120, 120);
            this.LogoPictureEdit.StyleController = this.moduleDataLayout;
            this.LogoPictureEdit.TabIndex = 17;
            
            
            
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForLogo,
            this.ItemForViewer,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 6;
            this.layoutControlGroup1.Size = new System.Drawing.Size(484, 610);
            this.layoutControlGroup1.TextVisible = false;
            
            
            
            this.ItemForLogo.Control = this.LogoPictureEdit;
            this.ItemForLogo.CustomizationFormText = "Logo";
            this.ItemForLogo.Location = new System.Drawing.Point(0, 0);
            this.ItemForLogo.Name = "ItemForLogo";
            this.ItemForLogo.Size = new System.Drawing.Size(126, 126);
            this.ItemForLogo.Text = "Logo";
            this.ItemForLogo.TextVisible = false;
            
            
            
            this.ItemForViewer.Control = this.Viewer;
            this.ItemForViewer.Location = new System.Drawing.Point(0, 126);
            this.ItemForViewer.Name = "ItemForViewer";
            this.ItemForViewer.Size = new System.Drawing.Size(458, 458);
            this.ItemForViewer.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 12, 0);
            this.ItemForViewer.TextVisible = false;
            
            
            
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForFullName,
            this.emptySpaceItem2,
            this.ItemForInvoice});
            this.layoutControlGroup2.Location = new System.Drawing.Point(126, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(332, 126);
            
            
            
            this.ItemForFullName.Control = this.NameLabel;
            this.ItemForFullName.CustomizationFormText = "Full Name";
            this.ItemForFullName.Location = new System.Drawing.Point(0, 0);
            this.ItemForFullName.Name = "ItemForFullName";
            this.ItemForFullName.Size = new System.Drawing.Size(300, 38);
            this.ItemForFullName.Text = "Full Name";
            this.ItemForFullName.TextVisible = false;
            
            
            
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 38);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(300, 30);
            
            
            
            this.ItemForInvoice.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ItemForInvoice.AppearanceItemCaption.Options.UseFont = true;
            this.ItemForInvoice.Control = this.InvoiceLabel;
            this.ItemForInvoice.Location = new System.Drawing.Point(0, 68);
            this.ItemForInvoice.Name = "ItemForInvoice";
            this.ItemForInvoice.Size = new System.Drawing.Size(300, 26);
            this.ItemForInvoice.Text = "Invoice #";
            this.ItemForInvoice.TextSize = new System.Drawing.Size(60, 20);
            
            
            
            this.mapControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Layers.Add(this.imageTilesLayer1);
            this.mapControl.Layers.Add(this.informationLayer1);
            this.mapControl.Layers.Add(this.informationLayer2);
            this.mapControl.Layers.Add(this.informationLayer3);
            this.mapControl.Location = new System.Drawing.Point(16, 16);
            this.mapControl.MinimumSize = new System.Drawing.Size(32, 32);
            this.mapControl.Name = "mapControl";
            this.mapControl.SearchPanelOptions.Visible = false;
            this.mapControl.Size = new System.Drawing.Size(694, 610);
            this.mapControl.TabIndex = 18;
            this.mapControl.ZoomLevel = 8D;
            
            
            
            this.roundedSkinPanel1.Controls.Add(this.mapControl);
            this.roundedSkinPanel1.Controls.Add(this.roundedSkinPanel2);
            this.roundedSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedSkinPanel1.Location = new System.Drawing.Point(0, 120);
            this.roundedSkinPanel1.Name = "roundedSkinPanel1";
            this.roundedSkinPanel1.Size = new System.Drawing.Size(1226, 642);
            this.roundedSkinPanel1.TabIndex = 3;
            this.roundedSkinPanel1.Text = "roundedSkinPanel1";
            
            
            
            this.roundedSkinPanel2.Controls.Add(this.moduleDataLayout);
            this.roundedSkinPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.roundedSkinPanel2.Location = new System.Drawing.Point(710, 16);
            this.roundedSkinPanel2.Name = "roundedSkinPanel2";
            this.roundedSkinPanel2.Size = new System.Drawing.Size(500, 610);
            this.roundedSkinPanel2.TabIndex = 0;
            this.roundedSkinPanel2.Text = "roundedSkinPanel2";
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roundedSkinPanel1);
            this.Controls.Add(this.ribbonControl);
            this.Name = "OrderMapView";
            this.Size = new System.Drawing.Size(1226, 762);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleDataLayout)).EndInit();
            this.moduleDataLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel1)).EndInit();
            this.roundedSkinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel2)).EndInit();
            this.roundedSkinPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraBars.Ribbon.RibbonControl ribbonControl;
        private XtraBars.BarButtonItem biClose;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private XtraDataLayout.DataLayoutControl moduleDataLayout;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource bindingSource;
        private XtraEditors.LabelControl NameLabel;
        private XtraEditors.PictureEdit LogoPictureEdit;
        private DevExpress.XtraMap.MapControl mapControl;
        private System.Windows.Forms.BindingSource bindingSourceRoute;
        private XtraBars.BarButtonItem biPrint;
        private XtraBars.BarButtonItem barExportItem;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private XtraMap.ImageLayer imageTilesLayer1;
        private XtraMap.AzureMapDataProvider azureMapDataProvider1;
        private XtraMap.InformationLayer informationLayer1;
        private XtraMap.AzureGeocodeDataProvider azureGeocodeDataProvider1;
        private XtraMap.InformationLayer informationLayer2;
        private XtraMap.AzureSearchDataProvider azureSearchDataProvider1;
        private XtraMap.InformationLayer informationLayer3;
        private XtraMap.AzureRouteDataProvider azureRouteDataProvider1;
        private XtraPdfViewer.PdfViewer Viewer;
        private XtraEditors.LabelControl InvoiceLabel;
        private XtraEditors.RoundedSkinPanel roundedSkinPanel1;
        private XtraEditors.RoundedSkinPanel roundedSkinPanel2;
        private XtraLayout.LayoutControlItem ItemForLogo;
        private XtraLayout.LayoutControlItem ItemForFullName;
        private XtraLayout.LayoutControlItem ItemForInvoice;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraLayout.LayoutControlItem ItemForViewer;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
    }
}
