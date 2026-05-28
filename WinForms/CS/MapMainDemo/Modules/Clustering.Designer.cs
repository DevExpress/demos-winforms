using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System.Drawing;
namespace DevExpress.XtraMap.Demos {
    partial class Clustering {
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true, typeof(System.Windows.Forms.UserControl));
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping1 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapItemAttributeMapping mapItemAttributeMapping2 = new DevExpress.XtraMap.MapItemAttributeMapping();
            DevExpress.XtraMap.MapDotSizeMapping mapDotSizeMapping1 = new DevExpress.XtraMap.MapDotSizeMapping();
            DevExpress.XtraMap.ColorListLegend colorListLegend1 = new DevExpress.XtraMap.ColorListLegend();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel10 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel11 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel12 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clustering));
            this.ItemsLayer = new DevExpress.XtraMap.VectorItemsLayer();
            this.ListSourceDataAdapter = new DevExpress.XtraMap.ListSourceDataAdapter();
            this.TilesLayer = new DevExpress.XtraMap.ImageLayer();
            this.AzureMapDataProvider = new DevExpress.XtraMap.AzureMapDataProvider();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.barStepInPixels = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.chkClusteringByAttr = new DevExpress.XtraBars.BarCheckItem();
            this.chkMarkerClustering = new DevExpress.XtraBars.BarCheckItem();
            this.chkDistanceBasedClustering = new DevExpress.XtraBars.BarCheckItem();
            this.chkWithoutClustering = new DevExpress.XtraBars.BarCheckItem();
            this.chkCustomFactory = new DevExpress.XtraBars.BarCheckItem();
            this.chkWitoutFactory = new DevExpress.XtraBars.BarCheckItem();
            this.chkClusteringWitoutAttribute = new DevExpress.XtraBars.BarCheckItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.rpgClusteringMethod = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgCustomClusterRepresentative = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgGroupByAttributeValues = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgAdditionalOptions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.chkMarkerClustering,
            this.chkDistanceBasedClustering,
            this.chkWithoutClustering,
            this.chkCustomFactory,
            this.chkWitoutFactory,
            this.chkClusteringByAttr,
            this.chkClusteringWitoutAttribute});
            this.ribbonControl1.Size = new System.Drawing.Size(604, 141);
            // 
            // rpOptions
            // 
            this.rpOptions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgClusteringMethod,
            this.rpgCustomClusterRepresentative,
            this.rpgGroupByAttributeValues,
            this.rpgAdditionalOptions});
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            this.ItemsLayer.Data = this.ListSourceDataAdapter;
            this.ItemsLayer.HighlightedItemStyle.TextColor = System.Drawing.Color.White;
            this.ItemsLayer.HighlightedItemStyle.TextGlowColor = System.Drawing.Color.Black;
            this.ItemsLayer.ItemStyle.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(194)))), ((int)(((byte)(18)))));
            this.ItemsLayer.ItemStyle.Stroke = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(117)))), ((int)(((byte)(11)))));
            this.ItemsLayer.ItemStyle.TextColor = System.Drawing.Color.White;
            this.ItemsLayer.ItemStyle.TextGlowColor = System.Drawing.Color.Black;
            this.ItemsLayer.Name = "ItemsLayer";
            this.ItemsLayer.SelectedItemStyle.TextColor = System.Drawing.Color.White;
            this.ItemsLayer.SelectedItemStyle.TextGlowColor = System.Drawing.Color.Black;
            mapItemAttributeMapping1.Member = "location";
            mapItemAttributeMapping1.Name = "location";
            mapItemAttributeMapping1.ValueType = DevExpress.XtraMap.FieldValueType.String;
            mapItemAttributeMapping2.Member = "genus";
            mapItemAttributeMapping2.Name = "genus";
            mapItemAttributeMapping2.ValueType = DevExpress.XtraMap.FieldValueType.String;
            this.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping1);
            this.ListSourceDataAdapter.AttributeMappings.Add(mapItemAttributeMapping2);
            this.ListSourceDataAdapter.Mappings.Latitude = "lat";
            this.ListSourceDataAdapter.Mappings.Longitude = "lon";
            this.ListSourceDataAdapter.Mappings.Type = "type";
            mapDotSizeMapping1.DefaultValue = 7D;
            this.ListSourceDataAdapter.PropertyMappings.Add(mapDotSizeMapping1);
            this.TilesLayer.DataProvider = this.AzureMapDataProvider;
            this.TilesLayer.Name = "TilesLayer";
            this.AzureMapDataProvider.Tileset = DevExpress.XtraMap.AzureTileset.BaseRoad;
            // 
            // mapControl1
            // 
            this.mapControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(-37.58D, 143.8D);
            this.mapControl1.ScrollArea = new DevExpress.Map.MapBounds(new GeoPoint(-37.47D, 143.65D), new GeoPoint(-37.62D, 143.94D));
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.TilesLayer);
            this.mapControl1.Layers.Add(this.ItemsLayer);
            colorListLegend1.Alignment = DevExpress.XtraMap.LegendAlignment.TopRight;
            colorListLegend1.Header = "Trees density";
            colorListLegend1.Layer = this.ItemsLayer;
            this.mapControl1.Legends.Add(colorListLegend1);
            this.mapControl1.Location = new System.Drawing.Point(0, 141);
            this.mapControl1.MinZoomLevel = 10D;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.Size = new System.Drawing.Size(604, 339);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 12D;
            this.mapControl1.MapItemClick += new DevExpress.XtraMap.MapItemClickEventHandler(this.mapControl1_MapItemClick);
            // 
            // barStepInPixels
            // 
            this.barStepInPixels.Edit = this.repositoryItemTrackBar1;
            this.barStepInPixels.EditHeight = 40;
            this.barStepInPixels.EditValue = 50;
            this.barStepInPixels.EditWidth = 150;
            this.barStepInPixels.Id = 5;
            this.barStepInPixels.Name = "barStepInPixels";
            // 
            // repositoryItemTrackBar1
            // 
            this.repositoryItemTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = true;
            this.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel10.Label = "10";
            trackBarLabel10.Value = 10;
            trackBarLabel11.Label = "80";
            trackBarLabel11.Value = 80;
            trackBarLabel12.Label = "150";
            trackBarLabel12.Value = 150;
            this.repositoryItemTrackBar1.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel10,
            trackBarLabel11,
            trackBarLabel12});
            this.repositoryItemTrackBar1.LargeChange = 10;
            this.repositoryItemTrackBar1.Maximum = 150;
            this.repositoryItemTrackBar1.Minimum = 10;
            this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
            this.repositoryItemTrackBar1.ShowLabels = true;
            this.repositoryItemTrackBar1.ShowValueToolTip = true;
            this.repositoryItemTrackBar1.SmallChange = 10;
            this.repositoryItemTrackBar1.TickFrequency = 10;
            this.repositoryItemTrackBar1.BeforeShowValueToolTip += new DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(this.repositoryItemTrackBar1_BeforeShowValueToolTip);
            this.repositoryItemTrackBar1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.OnEditValueChanging);
            // 
            // chkClusteringByAttr
            // 
            this.chkClusteringByAttr.Caption = "Attribute";
            this.chkClusteringByAttr.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkClusteringByAttr.GroupIndex = 4;
            this.chkClusteringByAttr.Id = 7;
            this.chkClusteringByAttr.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Attribute;
            this.chkClusteringByAttr.Name = "chkClusteringByAttr";
            this.chkClusteringByAttr.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkClusteringByAttr.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // chkMarkerClustering
            // 
            this.chkMarkerClustering.BindableChecked = true;
            this.chkMarkerClustering.Caption = "Marker";
            this.chkMarkerClustering.Checked = true;
            this.chkMarkerClustering.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkMarkerClustering.GroupIndex = 2;
            this.chkMarkerClustering.Id = 8;
            this.chkMarkerClustering.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Marker;
            this.chkMarkerClustering.Name = "chkMarkerClustering";
            this.chkMarkerClustering.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkMarkerClustering.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // chkDistanceBasedClustering
            // 
            this.chkDistanceBasedClustering.Caption = "Distance-based";
            this.chkDistanceBasedClustering.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkDistanceBasedClustering.GroupIndex = 2;
            this.chkDistanceBasedClustering.Id = 9;
            this.chkDistanceBasedClustering.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Distance_based;
            this.chkDistanceBasedClustering.Name = "chkDistanceBasedClustering";
            this.chkDistanceBasedClustering.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkDistanceBasedClustering.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // chkWithoutClustering
            // 
            this.chkWithoutClustering.Caption = "None";
            this.chkWithoutClustering.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkWithoutClustering.GroupIndex = 2;
            this.chkWithoutClustering.Id = 10;
            this.chkWithoutClustering.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.None;
            this.chkWithoutClustering.Name = "chkWithoutClustering";
            this.chkWithoutClustering.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkWithoutClustering.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // chkCustomFactory
            // 
            this.chkCustomFactory.BindableChecked = true;
            this.chkCustomFactory.Caption = "Custom callout";
            this.chkCustomFactory.Checked = true;
            this.chkCustomFactory.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkCustomFactory.GroupIndex = 3;
            this.chkCustomFactory.Id = 12;
            this.chkCustomFactory.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Custom_callout;
            this.chkCustomFactory.Name = "chkCustomFactory";
            this.chkCustomFactory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkCustomFactory.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // chkWitoutFactory
            // 
            this.chkWitoutFactory.Caption = "Default";
            this.chkWitoutFactory.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkWitoutFactory.GroupIndex = 3;
            this.chkWitoutFactory.Id = 19;
            this.chkWitoutFactory.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Default;
            this.chkWitoutFactory.Name = "chkWitoutFactory";
            this.chkWitoutFactory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkWitoutFactory.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // chkClusteringWitoutAttribute
            // 
            this.chkClusteringWitoutAttribute.BindableChecked = true;
            this.chkClusteringWitoutAttribute.Caption = "None";
            this.chkClusteringWitoutAttribute.Checked = true;
            this.chkClusteringWitoutAttribute.CheckStyle = DevExpress.XtraBars.BarCheckStyles.Radio;
            this.chkClusteringWitoutAttribute.GroupIndex = 4;
            this.chkClusteringWitoutAttribute.Id = 20;
            this.chkClusteringWitoutAttribute.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.None;
            this.chkClusteringWitoutAttribute.Name = "chkClusteringWitoutAttribute";
            this.chkClusteringWitoutAttribute.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.chkClusteringWitoutAttribute.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRibbonItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 23;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // rpgClusteringMethod
            // 
            this.rpgClusteringMethod.ItemLinks.Add(this.chkMarkerClustering);
            this.rpgClusteringMethod.ItemLinks.Add(this.chkDistanceBasedClustering);
            this.rpgClusteringMethod.ItemLinks.Add(this.chkWithoutClustering);
            this.rpgClusteringMethod.Name = "rpgClusteringMethod";
            this.rpgClusteringMethod.Text = "Clustering Method";
            // 
            // rpgCustomClusterRepresentative
            // 
            this.rpgCustomClusterRepresentative.AllowTextClipping = false;
            this.rpgCustomClusterRepresentative.ItemLinks.Add(this.chkCustomFactory);
            this.rpgCustomClusterRepresentative.ItemLinks.Add(this.chkWitoutFactory);
            this.rpgCustomClusterRepresentative.Name = "rpgCustomClusterRepresentative";
            this.rpgCustomClusterRepresentative.Text = "Custom Cluster Representative";
            // 
            // rpgGroupByAttributeValues
            // 
            this.rpgGroupByAttributeValues.AllowTextClipping = false;
            this.rpgGroupByAttributeValues.ItemLinks.Add(this.chkClusteringByAttr);
            this.rpgGroupByAttributeValues.ItemLinks.Add(this.chkClusteringWitoutAttribute);
            this.rpgGroupByAttributeValues.Name = "rpgGroupByAttributeValues";
            this.rpgGroupByAttributeValues.Text = "Group By Attribute Values";
            // 
            // rpgAdditionalOptions
            // 
            this.rpgAdditionalOptions.ItemLinks.Add(this.barStaticItem1);
            this.rpgAdditionalOptions.ItemLinks.Add(this.barStepInPixels);
            this.rpgAdditionalOptions.Name = "rpgAdditionalOptions";
            this.rpgAdditionalOptions.Text = "Step In Pixels";
            // 
            // Clustering
            // 
            this.AllowDrop = true;
            this.panelControl1.Controls.Add(this.mapControl1);
            this.Name = "Clustering";
            this.Size = new System.Drawing.Size(604, 480);
            this.Controls.SetChildIndex(this.ribbonControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.mapControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion

        private MapControl mapControl1;
        private XtraBars.Ribbon.RibbonPageGroup rpgClusteringMethod;
        private XtraBars.Ribbon.RibbonPageGroup rpgGroupByAttributeValues;
        private XtraBars.Ribbon.RibbonPageGroup rpgAdditionalOptions;
        private XtraBars.Ribbon.RibbonPageGroup rpgCustomClusterRepresentative;
        private XtraBars.BarEditItem barStepInPixels;
        private XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
        private XtraBars.BarCheckItem chkClusteringByAttr;
        private XtraBars.BarCheckItem chkMarkerClustering;
        private XtraBars.BarCheckItem chkDistanceBasedClustering;
        private XtraBars.BarCheckItem chkWithoutClustering;
        private XtraBars.BarCheckItem chkCustomFactory;
        private XtraBars.BarCheckItem chkWitoutFactory;
        private XtraBars.BarCheckItem chkClusteringWitoutAttribute;
        private XtraBars.BarStaticItem barStaticItem1;
        private ImageLayer TilesLayer;
        private VectorItemsLayer ItemsLayer;
        private ListSourceDataAdapter ListSourceDataAdapter;
        private AzureMapDataProvider AzureMapDataProvider;
    }
}
