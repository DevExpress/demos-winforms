using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraMap.Demos {
    public partial class ItemsMoving : FooteredMapTutorialControl {
        PuzzleLayoutGenerator puzzleGenerator;
        ItemsMovingOverlayManager overlayManager;
        int totalCountries;

        MapEditor MapEditor { get { return MapControl.MapEditor; } }
        ItemsMovingOverlayManager OverlayManager {
            get {
                if(overlayManager == null)
                    overlayManager = new ItemsMovingOverlayManager();
                return overlayManager;
            }
        }
        int SolvedCountries { get { return mapItemStorage2.Items.Count; } }
        protected override MapOverlay[] Overlays { get { return OverlayManager.GetOverlays(); } }
        protected override Image CopyrightImage { get { return DemoUtils.AzureLogo; } }
        protected override string CopyrightText { get { return DemoUtils.AzureCopyright; } }

        public override MapControl MapControl { get { return mapControl1; } }

        public ItemsMoving() {
            InitializeComponent();
            MapEditor.SetTransformMode(MapItemTransform.Move);
            shapefileDataAdapter1.FileUri = DemoUtils.GetFileUri("South America.shp");
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider);
        }
        void shapefileDataAdapter1_ItemsLoaded(object sender, ItemsLoadedEventArgs e) {
            vectorItemsLayer3.Visible = false;
            puzzleGenerator = new PuzzleLayoutGenerator(e.Items);
            PopulateItems();
        }
        void PopulateItems() {
            MapEditor.MapItemEdited -= OnMapItemEdited;
            MapEditor.AllowSaveActions = false;
            OverlayManager.HideGameFinish();
            mapItemStorage2.Items.Clear();
            IEnumerable<MapPathInfo> pathInfos = puzzleGenerator.GeneratePathInfos();
            mazeData.Items.BeginUpdate();
            try {
                mazeData.Items.Clear();
                foreach(MapPathInfo pathInfo in pathInfos) {
                    MapItem[] copiedItems = MapEditor.CopyItems(new MapItem[] { pathInfo.Path }, mazeLayer);
                    MapPath path = (MapPath)copiedItems[0];
                    path.Attributes.Add(new MapItemAttribute() { Name = "RealCenter", Type = typeof(GeoPoint), Value = pathInfo.RealCenter });
                    MapPoint delta = MapControl.CoordPointToScreenPoint(pathInfo.GameCenter) - MapControl.CoordPointToScreenPoint(pathInfo.RealCenter);
                    MapEditor.TranslateItems(new MapItem[] { path }, delta.X, delta.Y);
                }
            }
            finally {
                mazeData.Items.EndUpdate();
            }
            totalCountries = mazeData.Items.Count;
            MapControl.ZoomToRegion(new GeoPoint(15, -180), new GeoPoint(-62, -45), 0.05);
            OverlayManager.UpdateGameStats(0, totalCountries);
            MapEditor.AllowSaveActions = true;
            MapEditor.MapItemEdited += OnMapItemEdited;
        }
        double CalculateDistance(MapPoint point1, MapPoint point2) {
            double dx = point1.X - point2.X;
            double dy = point1.Y - point2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        void MoveItemToSolveLayer(MapPath mapPath) {
            mazeLayer.SelectedItems.Remove(mapPath);
            mazeData.Items.Remove(mapPath);
            mapItemStorage2.Items.Add(mapPath);
            solveLayer.SelectedItem = mapPath;
        }
        void OnMapItemEdited(object sender, MapItemEditedEventArgs args) {
            foreach(MapPath item in args.Items) {
                if(item.Layer == solveLayer)
                    continue;
                GeoPoint realCenter = (GeoPoint)item.Attributes["RealCenter"].Value;
                GeoPoint currentCenter = GeoPoint.Normalize(PuzzleLayoutGenerator.GetItemLocation(item));
                MapPoint desiredScreenCenter = MapControl.CoordPointToScreenPoint(realCenter);
                MapPoint actualScreenCenter = MapControl.CoordPointToScreenPoint(currentCenter);
                if(CalculateDistance(desiredScreenCenter, actualScreenCenter) < 20) {
                    item.CanMove = false;
                    MoveItemToSolveLayer(item);
                    MapPoint delta = desiredScreenCenter - actualScreenCenter;
                    MapEditor.TranslateItems(new MapItem[] { item }, delta.X, delta.Y);
                    MapEditor.ClearSavedActions();
                    OverlayManager.UpdateGameStats(SolvedCountries, totalCountries);
                    if(SolvedCountries == totalCountries)
                        OverlayManager.ShowGameFinish();
                }
            }
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            ChkShowMinimap.Enabled = false;
        }
        void HideOverlay() {
            OverlayManager.HideText();
        }
        void ShowOverlay(MapItemAttributeCollection attributes) {
            OverlayManager.UpdateText(attributes);
        }
        void mapControl1_SelectionChanged(object sender, MapSelectionChangedEventArgs e) {
            MapItem item = e.Selection.Count > 0 ? (MapItem)e.Selection[0] : null;
            if(item == null || item.Layer != solveLayer) {
                HideOverlay();
                return;
            }
            ShowOverlay(item.Attributes);
        }
        protected override void RestoreInitialView() {
            MapControl.ZoomToRegion(new GeoPoint(15, -180), new GeoPoint(-62, -45), 0.05);
        }
        void barButtonItem1_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            PopulateItems();
        }
        void mapControl1_MouseUp(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Left)
                return;
            MapHitInfo hitInfo = MapControl.CalcHitInfo(e.Location);
            MapOverlayItemBase clickedItem = OverlayUtils.GetClickedOverlayItem(hitInfo);
            if(clickedItem == null)
                return;
            ClickedAction action = OverlayManager.GetClickedAction(clickedItem);
            if(action == ClickedAction.Restart)
                PopulateItems();
            else if(action == ClickedAction.NotRestart)
                OverlayManager.HideGameFinish();
        }
        void mapControl1_OverlaysArranged(object sender, OverlaysArrangedEventArgs e) {
            OverlayManager.ArrangeOverlays(e.OverlayArrangements);
        }
    }
    public class MapPathInfo {
        readonly MapPath path;
        readonly GeoPoint realCenter;
        readonly GeoPoint gameCenter;

        public MapPath Path { get { return path; } }
        public GeoPoint RealCenter { get { return realCenter; } }
        public GeoPoint GameCenter { get { return gameCenter; } }

        public MapPathInfo(MapPath path, GeoPoint realCenter, GeoPoint gameCenter) {
            this.path = path;
            this.realCenter = realCenter;
            this.gameCenter = gameCenter;
        }
    }
}
