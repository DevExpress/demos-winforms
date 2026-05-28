using System;
using System.Linq;
using DevExpress.Map;

namespace DevExpress.XtraMap.Demos {
    public partial class ShapeSimplifierDemo : MapTutorialControl {
        public static int MaxToleranceValue = 280;
        bool isActive = true;
        bool isDataLoaded = false;
        int tolerance = MaxToleranceValue;
        int toleranceDelta = 1;
        ShapeSimplifierOverlayManager overlayManager;

        int Tolerance {
            get { return tolerance; }
            set {
                tolerance = value;
                Simplify();
            }
        }
        MapEditor Editor { get { return MapControl.MapEditor; } }
        VectorItemsLayer ActiveLayer { get { return vectorItemsLayer1.Visible ? vectorItemsLayer1 : vectorItemsLayer2; } }
        ShapeSimplifierOverlayManager OverlayManager {
            get {
                if(overlayManager == null)
                    overlayManager = new ShapeSimplifierOverlayManager();
                return overlayManager;
            }
        }
        protected override MapOverlay[] Overlays { get { return OverlayManager.GetOverlays(); } }
        public override MapControl MapControl { get { return mapControl1; } }
        public override bool UseEmptyRootPadding { get { return false; } }

        public ShapeSimplifierDemo() {
            InitializeComponent();
            tabPaneOptions.AllowCollapse = Utils.DefaultBoolean.True;
            shapefileDataAdapter1.FileUri = DemoUtils.GetFileUri("Iceland.shp");
        }
        protected override void RestoreInitialView() {
            MapControl.ZoomToFitLayerItems(0.15);
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            ChkShowMinimap.Enabled = false;
        }
        protected override void OnHandleDestroyed(EventArgs e) {
            isActive = false;
            base.OnHandleDestroyed(e);
        }
        protected override void DoHide() {
            base.DoHide();
            UpdateTimerEnabled(false);
        }
        protected override void DoShow() {
            base.DoShow();
            UpdateTimerEnabled(true);
        }
        void UpdateTimerEnabled(bool enabled) {
            timer1.Enabled = enabled && isDataLoaded && ceAutoMode.Checked;
        }
        void OnTimerTick(object sender, EventArgs e) {
            if(!isActive) {
                UpdateTimerEnabled(false);
                return;
            }
            toleranceDelta = Tolerance == MaxToleranceValue ? -1 : Tolerance == 0 ? 1 : toleranceDelta;
            mfTrackBarControl.Value = Tolerance + toleranceDelta;
        }
        void OnItemsLoaded(object sender, ItemsLoadedEventArgs e) {
            MapPolyline line = new MapPolyline();
            line.Points.AddRange(((ISupportCoordPoints)e.Items[0]).Points.ToArray());
            mapItemStorage1.Items.Add(line);
            MapPolyline etalonLine = new MapPolyline();
            etalonLine.Points.AddRange(((ISupportCoordPoints)e.Items[0]).Points.ToArray());
            mapItemStorage2.Items.Add(etalonLine);
        }
        void OnDataLoaded(object sender, DataLoadedEventArgs e) {
            mfTrackBarControl.EditValue = 280;
            mfTrackBarControl.Value = 280;
            isDataLoaded = true;
            RestoreInitialView();
            UpdateCounterText(100);
            UpdateTimerEnabled(true);
        }
        void OnTrackBarControlValueChanged(object sender, EventArgs e) {
            Tolerance = mfTrackBarControl.Value;
        }
        void OnCheckedChanged(object sender, EventArgs e) {
            layoutControlItem2.Enabled = !ceAutoMode.Checked;
            UpdateTimerEnabled(true);
        }
        void Simplify() {
            double tolerance = CalculateTolerance(Tolerance);
            Editor.SimplifyItems(ActiveLayer.Data.Items, tolerance);
            UpdateCounterText(tolerance);
        }
        double CalculateTolerance(double value) {
            return Math.Max(Math.Round(100 * Math.Abs(Math.Pow(value / MaxToleranceValue, 5)), 4), 0.001);
        }
        void ShapeTypeSelectedIndexChanged(object sender, EventArgs e) {
            vectorItemsLayer1.Visible = shapeTypeRadioGroup.SelectedIndex == 0;
            vectorItemsLayer2.Visible = !vectorItemsLayer1.Visible;
            RestoreInitialView();
            Simplify();
        }
        void UpdateCounterText(double tolerance) {
            MapItem item = ActiveLayer.Data.Items.FirstOrDefault();
            if(item == null)
                return;
            int pointsCount = ((ISupportCoordPoints)item).Points.Count - 1;
            OverlayManager.UpdateText(pointsCount, tolerance);
        }
    }
}
