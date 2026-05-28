namespace DevExpress.ApplicationUI.Demos {
    partial class DocumentManagerNative {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentManagerNative));
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.biAddDocument = new DevExpress.XtraBars.BarButtonItem();
            this.bsiSkin = new DevExpress.XtraBars.BarSubItem();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.nativeView = new DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView(this.components);
            this.noDocumentsView1 = new DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(this.components);
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nativeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager
            // 
            this.documentManager.BarAndDockingController = this.barAndDockingController1;
            this.documentManager.ContainerControl = this;
            this.documentManager.MenuManager = this.ribbonControl1;
            this.documentManager.View = this.nativeView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.nativeView,
            this.noDocumentsView1});
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.biAddDocument,
            this.bsiSkin,
            this.barDockingMenuItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(786, 150);
            // 
            // biAddDocument
            // 
            this.biAddDocument.Caption = "Add New Document";
            this.biAddDocument.Id = 0;
            this.biAddDocument.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("biAddDocument.ImageOptions.Image")));
            this.biAddDocument.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("biAddDocument.ImageOptions.LargeImage")));
            this.biAddDocument.Name = "biAddDocument";
            this.biAddDocument.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biAddDocumentClick);
            // 
            // bsiSkin
            // 
            this.bsiSkin.Caption = "Skin";
            this.bsiSkin.Id = 1;
            this.bsiSkin.Name = "bsiSkin";
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "Manage Documents Layout";
            this.barDockingMenuItem1.Id = 1;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Native View Setttings";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.biAddDocument, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barDockingMenuItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Layout";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "boscheduler_16x16.png");
            this.imageCollection1.Images.SetKeyName(1, "picturebox_16x16.png");
            this.imageCollection1.Images.SetKeyName(2, "customer_16x16.png");
            this.imageCollection1.Images.SetKeyName(3, "project_16x16.png");
            this.imageCollection1.Images.SetKeyName(4, "bopermission_16x16.png");
            this.imageCollection1.Images.SetKeyName(5, "boemployee_16x16.png");
            // 
            // DocumentManagerNative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DocumentManagerNative";
            this.Size = new System.Drawing.Size(786, 448);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nativeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noDocumentsView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.NativeMdi.NativeMdiView nativeView;

        private System.ComponentModel.IContainer components;
        private DevExpress.XtraBars.BarButtonItem biAddDocument;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.BarSubItem bsiSkin;
        private XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView noDocumentsView1;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private XtraBars.Ribbon.RibbonPage ribbonPage1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private XtraBars.BarDockingMenuItem barDockingMenuItem1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private Utils.ImageCollection imageCollection1;
    }
}
