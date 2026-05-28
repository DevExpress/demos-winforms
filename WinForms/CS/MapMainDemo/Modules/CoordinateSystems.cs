using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraMap.Demos {
    public partial class CoordinateSystems : FooteredMapTutorialControl {
        const int HotelsCount = 3;

        HotelPlansOverlayManager overlayManager;
        readonly HotelRoomTooltipHelper tooltipHelper = new HotelRoomTooltipHelper();
        bool geoMapActivated = true;

        HotelPlansOverlayManager OverlayManager {
            get {
                if(overlayManager == null)
                    overlayManager = new HotelPlansOverlayManager();
                return overlayManager;
            }
        }
        protected override MapOverlay[] Overlays { get { return geoMapActivated ? base.Overlays : OverlayManager.GetOverlays(); } }
        protected override MiniMapAlignment MiniMapAlignment { get { return MiniMapAlignment.TopLeft; } }
        public override MapControl MapControl { get { return mapControl1; } }
        protected override Image CopyrightImage { get { return geoMapActivated ? DemoUtils.AzureLogo : null; } }
        protected override string CopyrightText { get { return geoMapActivated ? DemoUtils.AzureCopyright : string.Empty; } }

        public CoordinateSystems() {
            InitializeComponent();
            PrepareMap();
        }
        void PrepareMap() {
            DemoUtils.SetAzureMapDataProviderKey(AzureImageryMapDataProvider);
            DemoUtils.SetAzureMapDataProviderKey(AzureLabelsMapDataProvider);
            PopulateItemStorage();
        }
        void PopulateItemStorage() {
            HotelsItemStorage.Items.Clear();
            HotelsItemStorage.Items.Add(CreateHotel(new GeoPoint(-21.1434, -175.154), "Geek Island Resort", "Hotel1", 0));
            HotelsItemStorage.Items.Add(CreateHotel(new GeoPoint(-21.1936528, -175.1552), "Nerd Hotel Tonga", "Hotel2", 1));
            HotelsItemStorage.Items.Add(CreateHotel(new GeoPoint(-21.1658, -175.1134), "The IT Paradise Hotel", "Hotel3", 2));
        }
        MapItem CreateHotel(GeoPoint location, string name, string path, int index) {
            MapCustomElement hotel = new MapCustomElement() { Location = location, Text = name, ImageIndex = index, TextAlignment = TextAlignment.TopCenter };
            hotel.Attributes.Add(new MapItemAttribute() { Name = "path", Value = path, Type = typeof(string) });
            hotel.Attributes.Add(new MapItemAttribute() { Name = "index", Value = index, Type = typeof(int) });
            return hotel;
        }
        void ResetOverlays() {
            MapControl.Overlays.Clear();
            MapControl.Overlays.AddRange(Overlays);
        }
        void ActivateCartesianMap(MapItem item) {
            geoMapActivated = false;
            ChangeMiniMapState(false);
            MapControl.CoordinateSystem = new CartesianMapCoordinateSystem();
            ShapefileDataAdapter data = new ShapefileDataAdapter() {
                SourceCoordinateSystem = new CartesianSourceCoordinateSystem(),
                FileUri = GetFileUri(item)
            };
            tooltipHelper.UpdateHotelIndex((int)item.Attributes["index"].Value);
            HotelPlanLayer.Data = data;
            OverlayManager.HotelName.Text = ((MapCustomElement)item).Text;
            SetElementsVisibility(false);
            MapControl.MapItemClick -= mapControl1_MapItemClick;
            MapControl.DrawMapItem -= mapControl1_DrawMapItem;
            MapControl.MouseUp += mapControl1_MouseUp;
            ResetOverlays();
            UpdateCopyrights();
        }
        void ActivateGeoMap() {
            geoMapActivated = true;
            ChangeMiniMapState(true);
            MapControl.CoordinateSystem = new GeoMapCoordinateSystem();
            HotelsLayer.SelectedItems.Clear();
            SetElementsVisibility(true);
            ResetMinMaxZoomLevel();
            ZoomToFitMap(0.5);
            SetMinMaxZoomLevel();
            MapControl.MapItemClick += mapControl1_MapItemClick;
            MapControl.DrawMapItem += mapControl1_DrawMapItem;
            MapControl.MouseUp -= mapControl1_MouseUp;
            ResetOverlays();
            UpdateCopyrights();
        }

        void ZoomToFitMap(double paddingFactor) {
            bool scrolingEnabled = MapControl.EnableScrolling;
            bool zoomingEnabled = MapControl.EnableZooming;
            MapControl.EnableScrolling = MapControl.EnableZooming = true;
            MapControl.ZoomToFitLayerItems(paddingFactor);
            MapControl.EnableScrolling = scrolingEnabled;
            MapControl.EnableZooming = zoomingEnabled;
        }

        void ChangeMiniMapState(bool isEnable) {
            ChkShowMinimap.Enabled = isEnable;
            if(MapControl.MiniMap != null)
                MapControl.MiniMap.Visible = isEnable;
        }
        void ResetMinMaxZoomLevel() {
            MapControl.MinZoomLevel = 1;
            MapControl.MaxZoomLevel = 20;
        }
        void SetMinMaxZoomLevel() {
            MapControl.MinZoomLevel = MapControl.ZoomLevel;
            MapControl.MaxZoomLevel = MapControl.MinZoomLevel + 2;
        }
        void SetElementsVisibility(bool isGeoMap) {
            HotelPlanLayer.Visible = !isGeoMap;
            HotelsLayer.Visible = isGeoMap;
            TilesLayer.Visible = isGeoMap;
        }
        Uri GetFileUri(MapItem item) {
            string hotel = item.Attributes["path"].Value.ToString();
#pragma warning disable DX0025 // not path traversal (predefined name)
            return DemoUtils.GetFileUri(string.Format("Hotels\\{0}.shp", hotel));
#pragma warning restore DX0025
        }
        void HotelPlanLayer_DataLoaded(object sender, DataLoadedEventArgs e) {
            ResetMinMaxZoomLevel();
            ZoomToFitMap(0.3);
            SetMinMaxZoomLevel();
        }
        void mapControl1_MapItemClick(object sender, MapItemClickEventArgs e) {
            ActivateCartesianMap(e.Item);
        }
        void mapControl1_DrawMapItem(object sender, DrawMapItemEventArgs e) {
            MapCustomElement el = (MapCustomElement)e.Item;
            if(e.IsHighlighted && (el.ImageIndex < HotelsCount))
                el.ImageIndex += HotelsCount;
            if(!e.IsHighlighted && (el.ImageIndex >= HotelsCount))
                el.ImageIndex -= HotelsCount;
        }
        void mapControl1_MouseUp(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Left)
                return;
            MapHitInfo hitInfo = MapControl.CalcHitInfo(e.Location);
            MapOverlayItemBase clickedItem = OverlayUtils.GetClickedOverlayItem(hitInfo);
            if(clickedItem == null)
                return;
            if(clickedItem == OverlayManager.BackImage)
                ActivateGeoMap();
        }
        void toolTipController1_BeforeShow(object sender, Utils.ToolTipControllerShowEventArgs e) {
            e.SuperTip = tooltipHelper.CalculateSuperTooltip(e.SelectedObject as MapItem, e.ToolTip);
        }
        void OnDispose() {
            if(overlayManager != null) {
                overlayManager.Dispose();
                overlayManager = null;
            }
        }
        protected override void RestoreInitialView() {
            ActivateGeoMap();
            base.RestoreInitialView();
        }
    }
}
