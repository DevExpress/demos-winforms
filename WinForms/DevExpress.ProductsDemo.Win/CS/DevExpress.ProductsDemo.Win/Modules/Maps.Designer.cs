using DevExpress.Utils.Html;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;
namespace DevExpress.ProductsDemo.Win.Modules {
    partial class MapsModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            OnDispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapsModule));
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping1 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping2 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping3 = new DevExpress.XtraMap.MapItemAttributeMapping();
            this.AirportTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.PlaneTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.TilesLayer = new DevExpress.XtraMap.ImageLayer();
            this.AirportsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.AirportsDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.PlanesDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.mapContainerPanel = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.PathsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.PathsDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.RoutesLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.RoutesStorage = new DevExpress.XtraMap.MapItemStorage();
            this.PlanesLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.chkAzureRoad = new DevExpress.XtraBars.BarCheckItem();
            this.chkAzureImagery = new DevExpress.XtraBars.BarCheckItem();
            this.chkAzureDark = new DevExpress.XtraBars.BarCheckItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.viewRibbonPage1 = new DevExpress.XtraScheduler.UI.ViewRibbonPage();
            this.activeViewRibbonPageGroup1 = new DevExpress.XtraScheduler.UI.ActiveViewRibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.htmlContentPopup1 = new DevExpress.XtraEditors.HtmlContentPopup(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mapContainerPanel)).BeginInit();
            this.mapContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentPopup1)).BeginInit();
            this.SuspendLayout();
            // 
            // AirportTemplate
            // 
            this.AirportTemplate.Name = "AirportTemplate";
            this.AirportTemplate.Styles = resources.GetString("AirportTemplate.Styles");
            this.AirportTemplate.Template = resources.GetString("AirportTemplate.Template");
            // 
            // PlaneTemplate
            // 
            this.PlaneTemplate.Name = "PlaneTemplate";
            this.PlaneTemplate.Styles = resources.GetString("PlaneTemplate.Styles");
            this.PlaneTemplate.Template = resources.GetString("PlaneTemplate.Template");
            this.AirportsLayer.Data = this.AirportsDataAdapter;
            mapItemAttributeMapping1.Member = "Name";
            mapItemAttributeMapping1.Name = "Name";
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.String;
            mapItemAttributeMapping2.Member = "City";
            mapItemAttributeMapping2.Name = "City";
            mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.String;
            mapItemAttributeMapping3.Member = "IATA";
            mapItemAttributeMapping3.Name = "IATA";
            mapItemAttributeMapping3.ValueType = DevExpress.XtraMap.FieldValueType.String;
            this.AirportsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1);
            this.AirportsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2);
            this.AirportsDataAdapter.AttributeMappings.Add(mapItemAttributeMapping3);
            this.AirportsDataAdapter.Mappings.Latitude = "Latitude";
            this.AirportsDataAdapter.Mappings.Longitude = "Longitude";
            this.AirportsDataAdapter.Mappings.Type = "ItemType";
            this.PlanesDataAdapter.Mappings.Latitude = "Latitude";
            this.PlanesDataAdapter.Mappings.Longitude = "Longitude";
            this.PlanesDataAdapter.Mappings.Type = "ItemType";
            // 
            // mapContainerPanel
            // 
            this.mapContainerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapContainerPanel.Controls.Add(this.layoutControl1);
            this.mapContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapContainerPanel.Location = new System.Drawing.Point(0, 150);
            this.mapContainerPanel.Margin = new System.Windows.Forms.Padding(23);
            this.mapContainerPanel.Name = "mapContainerPanel";
            this.mapContainerPanel.Size = new System.Drawing.Size(1053, 589);
            this.mapContainerPanel.TabIndex = 15;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.mapControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(376, 238, 905, 577);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1053, 589);
            this.layoutControl1.TabIndex = 16;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(32D, 10D);
            this.mapControl1.EnableRotation = false;
            this.mapControl1.Layers.Add(this.TilesLayer);
            this.mapControl1.Layers.Add(this.AirportsLayer);
            this.mapControl1.Layers.Add(this.PathsLayer);
            this.mapControl1.Layers.Add(this.RoutesLayer);
            this.mapControl1.Layers.Add(this.PlanesLayer);
            this.mapControl1.Location = new System.Drawing.Point(12, 12);
            this.mapControl1.MaxZoomLevel = 10D;
            this.mapControl1.MinZoomLevel = 3D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.SelectionMode = DevExpress.XtraMap.ElementSelectionMode.Single;
            this.mapControl1.Size = new System.Drawing.Size(1029, 565);
            this.mapControl1.TabIndex = 17;
            this.mapControl1.ZoomLevel = 3D;
            this.mapControl1.SelectionChanged += new DevExpress.XtraMap.MapSelectionChangedEventHandler(this.OnMapSelectionChanged);
            this.PathsLayer.Data = this.PathsDataAdapter;
            this.PathsDataAdapter.Mappings.Latitude = "Latitude";
            this.PathsDataAdapter.Mappings.Longitude = "Longitude";
            this.PathsDataAdapter.Mappings.Type = "ItemType";
            this.RoutesLayer.Data = this.RoutesStorage;
            this.PlanesLayer.Data = this.PlanesDataAdapter;
            this.AirportsLayer.DataLoaded += new DevExpress.XtraMap.DataLoadedEventHandler(this.AirportsLayer_DataLoaded);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1053, 589);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mapControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1033, 569);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.chkAzureRoad,
            this.chkAzureImagery,
            this.chkAzureDark,
            this.barCheckItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 48;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.viewRibbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1053, 150);
            //
            // chkAzureRoad
            //
            this.chkAzureRoad.BindableChecked = true;
            this.chkAzureRoad.Caption = "Road";
            this.chkAzureRoad.Checked = true;
            this.chkAzureRoad.GroupIndex = 1;
            this.chkAzureRoad.Id = 40;
            this.chkAzureRoad.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.BringRoad;
            this.chkAzureRoad.Name = "chkAzureRoad";
            this.chkAzureRoad.Tag = 7;
            this.chkAzureRoad.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAzureKindCheckedChanged);
            //
            // chkAzureImagery
            //
            this.chkAzureImagery.Caption = "Imagery";
            this.chkAzureImagery.GroupIndex = 1;
            this.chkAzureImagery.Id = 41;
            this.chkAzureImagery.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.BringArea;
            this.chkAzureImagery.Name = "chkAzureImagery";
            this.chkAzureImagery.Tag = 0;
            this.chkAzureImagery.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAzureKindCheckedChanged);
            //
            // chkAzureDark
            //
            this.chkAzureDark.Caption = "Dark";
            this.chkAzureDark.GroupIndex = 1;
            this.chkAzureDark.Id = 42;
            this.chkAzureDark.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.BringRoadDark;
            this.chkAzureDark.Name = "chkAzureDark";
            this.chkAzureDark.Tag = 2;
            this.chkAzureDark.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnAzureKindCheckedChanged);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.BindableChecked = true;
            this.barCheckItem1.Caption = "Show Planes";
            this.barCheckItem1.Checked = true;
            this.barCheckItem1.Id = 47;
            this.barCheckItem1.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.Plane;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnPlanesVisibilityCheckedChanged);
            // 
            // viewRibbonPage1
            // 
            this.viewRibbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.activeViewRibbonPageGroup1,
            this.ribbonPageGroup1});
            this.viewRibbonPage1.Name = "viewRibbonPage1";
            // 
            // activeViewRibbonPageGroup1
            // 
            this.activeViewRibbonPageGroup1.AllowTextClipping = false;
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.chkAzureRoad);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.chkAzureImagery);
            this.activeViewRibbonPageGroup1.ItemLinks.Add(this.chkAzureDark);
            this.activeViewRibbonPageGroup1.Name = "activeViewRibbonPageGroup1";
            this.activeViewRibbonPageGroup1.Text = "AzureMap Kind";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barCheckItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // MapsModule
            // 
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.mapContainerPanel);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "MapsModule";
            this.Size = new System.Drawing.Size(1053, 739);
            ((System.ComponentModel.ISupportInitialize)(this.mapContainerPanel)).EndInit();
            this.mapContainerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentPopup1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraEditors.PanelControl mapContainerPanel;
        private XtraBars.Ribbon.RibbonControl ribbonControl1;
        private XtraScheduler.UI.ViewRibbonPage viewRibbonPage1;
        private XtraScheduler.UI.ActiveViewRibbonPageGroup activeViewRibbonPageGroup1;
        private XtraBars.BarCheckItem chkAzureRoad;
        private XtraBars.BarCheckItem chkAzureImagery;
        private XtraBars.BarCheckItem chkAzureDark;
        private XtraLayout.LayoutControl layoutControl1;
        private MapControl mapControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private ImageLayer TilesLayer;
        private VectorItemsLayer AirportsLayer;
        private ListSourceDataAdapter PlanesDataAdapter;
        private ListSourceDataAdapter AirportsDataAdapter;
        private VectorItemsLayer PlanesLayer;
        private ListSourceDataAdapter PathsDataAdapter;
        private VectorItemsLayer RoutesLayer;
        private MapItemStorage RoutesStorage;
        private VectorItemsLayer PathsLayer;
        private HtmlContentPopup htmlContentPopup1;
        private HtmlTemplate AirportTemplate;
        private HtmlTemplate PlaneTemplate;
        private XtraBars.BarCheckItem barCheckItem1;
        private XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}
