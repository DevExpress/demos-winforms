namespace DevExpress.ApplicationUI.Demos {
    partial class ucDocumentManagerWindowsUISearchPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDocumentManagerWindowsUISearchPanel));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.tileContainer = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.salesByStateTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.salesByState = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            this.ucChoroplethMapItemDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.ucProductsGridDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.ucCategorySalesDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.ucChartProductItemDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.salesInCaliforniaTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.salesInCalifornia = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            this.salesInMontanaTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.salesInMontana = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            this.salesInTexasTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.salesInTexas = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesByStateTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesByState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucChoroplethMapItemDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucProductsGridDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucCategorySalesDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucChartProductItemDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInCaliforniaTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInCalifornia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInMontanaTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInMontana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInTexasTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInTexas)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.documentManager.View = this.windowsUIView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView});
            // 
            // windowsUIView
            // 
            this.windowsUIView.Caption = "Press Ctrl+F to invoke the Search Panel";
            this.windowsUIView.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainer,
            this.salesByState,
            this.salesInCalifornia,
            this.salesInMontana,
            this.salesInTexas});
            this.windowsUIView.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.ucChartProductItemDocument,
            this.ucCategorySalesDocument,
            this.ucChoroplethMapItemDocument,
            this.ucProductsGridDocument});
            this.windowsUIView.SearchPanelProperties.ClearButtonShowMode = DevExpress.XtraBars.Docking2010.Customization.ClearButtonShowMode.Auto;
            this.windowsUIView.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.salesByStateTile,
            this.salesInCaliforniaTile,
            this.salesInMontanaTile,
            this.salesInTexasTile});
            this.windowsUIView.UseSplashScreen = DevExpress.Utils.DefaultBoolean.False;
            // 
            // tileContainer
            // 
            this.tileContainer.ExcludeFromSearch = true;
            this.tileContainer.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.salesByStateTile,
            this.salesInCaliforniaTile,
            this.salesInMontanaTile,
            this.salesInTexasTile});
            this.tileContainer.Name = "tileContainer";
            // 
            // salesByStateTile
            // 
            this.salesByStateTile.ActivationTarget = this.salesByState;
            this.salesByStateTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(186)))), ((int)(((byte)(212)))));
            this.salesByStateTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(186)))), ((int)(((byte)(212)))));
            this.salesByStateTile.Appearances.Normal.Options.UseBackColor = true;
            this.salesByStateTile.Appearances.Normal.Options.UseBorderColor = true;
            this.salesByStateTile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salesByStateTile.BackgroundImage")));
            tileItemElement1.Text = "Sales by state";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.salesByStateTile.Elements.Add(tileItemElement1);
            this.tileContainer.SetID(this.salesByStateTile, 3);
            this.salesByStateTile.Name = "salesByStateTile";
            // 
            // salesByState
            // 
            this.salesByState.Caption = "Sales by state";
            this.salesByState.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.ucChoroplethMapItemDocument,
            this.ucProductsGridDocument,
            this.ucCategorySalesDocument,
            this.ucChartProductItemDocument});
            this.salesByState.Name = "salesByState";
            this.salesByState.Parent = this.tileContainer;
            // 
            // ucChoroplethMapItemDocument
            // 
            this.ucChoroplethMapItemDocument.Caption = "Choropleth Map";
            this.ucChoroplethMapItemDocument.ControlName = "ucChoroplethMapItem";
            this.ucChoroplethMapItemDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucChoroplethMapItem";
            // 
            // ucProductsGridDocument
            // 
            this.ucProductsGridDocument.Caption = "Products";
            this.ucProductsGridDocument.ControlName = "ucProductsGrid";
            this.ucProductsGridDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucProductsGrid";
            // 
            // ucCategorySalesDocument
            // 
            this.ucCategorySalesDocument.Caption = "Category Sales";
            this.ucCategorySalesDocument.ControlName = "ucCategorySales";
            this.ucCategorySalesDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucCategorySales";
            // 
            // ucChartProductItemDocument
            // 
            this.ucChartProductItemDocument.Caption = "Chart Product";
            this.ucChartProductItemDocument.ControlName = "ucChartProductItem";
            this.ucChartProductItemDocument.ControlTypeName = "DevExpress.ApplicationUI.Demos.ucChartProductItem";
            // 
            // salesInCaliforniaTile
            // 
            this.salesInCaliforniaTile.ActivationTarget = this.salesInCalifornia;
            this.salesInCaliforniaTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(186)))), ((int)(((byte)(212)))));
            this.salesInCaliforniaTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(186)))), ((int)(((byte)(212)))));
            this.salesInCaliforniaTile.Appearances.Normal.Options.UseBackColor = true;
            this.salesInCaliforniaTile.Appearances.Normal.Options.UseBorderColor = true;
            this.salesInCaliforniaTile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salesInCaliforniaTile.BackgroundImage")));
            tileItemElement2.Text = "Sales in California";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.salesInCaliforniaTile.Elements.Add(tileItemElement2);
            this.tileContainer.SetID(this.salesInCaliforniaTile, 24);
            this.salesInCaliforniaTile.Name = "salesInCaliforniaTile";
            // 
            // salesInCalifornia
            // 
            this.salesInCalifornia.Caption = "Sales in California";
            this.salesInCalifornia.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.ucProductsGridDocument,
            this.ucCategorySalesDocument,
            this.ucChartProductItemDocument});
            this.salesInCalifornia.Name = "salesInCalifornia";
            this.salesInCalifornia.Parent = this.tileContainer;
            // 
            // salesInMontanaTile
            // 
            this.salesInMontanaTile.ActivationTarget = this.salesInMontana;
            this.salesInMontanaTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(186)))), ((int)(((byte)(212)))));
            this.salesInMontanaTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(186)))), ((int)(((byte)(212)))));
            this.salesInMontanaTile.Appearances.Normal.Options.UseBackColor = true;
            this.salesInMontanaTile.Appearances.Normal.Options.UseBorderColor = true;
            this.salesInMontanaTile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salesInMontanaTile.BackgroundImage")));
            tileItemElement3.Text = "Sales in Montana";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.salesInMontanaTile.Elements.Add(tileItemElement3);
            this.tileContainer.SetID(this.salesInMontanaTile, 25);
            this.salesInMontanaTile.Name = "salesInMontanaTile";
            // 
            // salesInMontana
            // 
            this.salesInMontana.Caption = "Sales in Montana";
            this.salesInMontana.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.ucProductsGridDocument,
            this.ucCategorySalesDocument,
            this.ucChartProductItemDocument});
            this.salesInMontana.Name = "salesInMontana";
            this.salesInMontana.Parent = this.tileContainer;
            // 
            // salesInTexasTile
            // 
            this.salesInTexasTile.ActivationTarget = this.salesInTexas;
            this.salesInTexasTile.Appearances.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(186)))), ((int)(((byte)(212)))));
            this.salesInTexasTile.Appearances.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(186)))), ((int)(((byte)(212)))));
            this.salesInTexasTile.Appearances.Normal.Options.UseBackColor = true;
            this.salesInTexasTile.Appearances.Normal.Options.UseBorderColor = true;
            this.salesInTexasTile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("salesInTexasTile.BackgroundImage")));
            tileItemElement4.Text = "Sales in Texas";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.salesInTexasTile.Elements.Add(tileItemElement4);
            this.tileContainer.SetID(this.salesInTexasTile, 36);
            this.salesInTexasTile.Name = "salesInTexasTile";
            // 
            // salesInTexas
            // 
            this.salesInTexas.Caption = "Sales in Texas";
            this.salesInTexas.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.ucProductsGridDocument,
            this.ucCategorySalesDocument,
            this.ucChartProductItemDocument});
            this.salesInTexas.Name = "salesInTexas";
            this.salesInTexas.Parent = this.tileContainer;
            // 
            // ucDocumentManagerWindowsUISearchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucDocumentManagerWindowsUISearchPanel";
            this.Size = new System.Drawing.Size(806, 448);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesByStateTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesByState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucChoroplethMapItemDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucProductsGridDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucCategorySalesDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucChartProductItemDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInCaliforniaTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInCalifornia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInMontanaTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInMontana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInTexasTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesInTexas)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private XtraBars.Docking2010.DocumentManager documentManager;
        private XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView;
        private XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer;
        private XtraBars.Docking2010.Views.WindowsUI.Tile salesByStateTile;
        private XtraBars.Docking2010.Views.WindowsUI.Document ucChartProductItemDocument;
        private XtraBars.Docking2010.Views.WindowsUI.Tile salesInCaliforniaTile;
        private XtraBars.Docking2010.Views.WindowsUI.Document ucCategorySalesDocument;
        private XtraBars.Docking2010.Views.WindowsUI.Tile salesInMontanaTile;
        private XtraBars.Docking2010.Views.WindowsUI.Document ucChoroplethMapItemDocument;
        private XtraBars.Docking2010.Views.WindowsUI.Tile salesInTexasTile;
        private XtraBars.Docking2010.Views.WindowsUI.Document ucProductsGridDocument;
        private XtraBars.Docking2010.Views.WindowsUI.PageGroup salesByState;
        private XtraBars.Docking2010.Views.WindowsUI.PageGroup salesInCalifornia;
        private XtraBars.Docking2010.Views.WindowsUI.PageGroup salesInMontana;
        private XtraBars.Docking2010.Views.WindowsUI.PageGroup salesInTexas;
    }
}
