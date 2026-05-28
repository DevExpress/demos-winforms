using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DevExpress.XtraMap.Demos {
    public partial class PixelMap : MapTutorialControl {
        readonly PixelMapGenerator pixelMapGenerator;
        PerformanceOverlayManager overlayManager;
        Color previousColor;
        int pointsPerDot = 4;
        int pointDensity = 56;

        protected PerformanceOverlayManager OverlayManager {
            get {
                if(overlayManager == null)
                    overlayManager = new PerformanceOverlayManager();
                return overlayManager;
            }
        }
        protected override MapOverlay[] Overlays { get { return OverlayManager.GetOverlays(); } }
        public override MapControl MapControl { get { return mapControl1; } }

        public PixelMap() {
            InitializeComponent();
            pixelMapGenerator = new PixelMapGenerator();
            UpdateItems(pointDensity, pointsPerDot);
        }

        void UpdateItems(int pointsPerMap, int pointsPerDot) {
            List<MapItem> items = pixelMapGenerator.GenerateMap(new Size(pointsPerMap, pointsPerMap), pointsPerDot);
            mapItemStorage1.Items.Clear();
            mapItemStorage1.Items.AddRange(items);
            OverlayManager.UpdateText(items.Count);
        }
        void OnPointsComplexityChanged(object sender, ItemClickEventArgs e) {
            if(e.Item.Tag == null)
                return;
            pointsPerDot = (int)e.Item.Tag;
            UpdateItems(pointDensity, pointsPerDot);
        }
        void OnPointDensityChanged(object sender, ItemClickEventArgs e) {
            if(e.Item.Tag == null)
                return;
            pointDensity = (int)e.Item.Tag;
            UpdateItems(pointDensity, pointsPerDot);
        }
        void OnShapesColorItemClick(object sender, ItemClickEventArgs e) {
            previousColor = vectorItemsLayer1.ItemStyle.Fill;
            using(ColorPickerForm colorWheelForm = new ColorPickerForm(pointDensity) { StartPosition = FormStartPosition.Manual, Location = MousePosition }) {
                colorWheelForm.StartPosition = FormStartPosition.Manual;
                colorWheelForm.Location = MousePosition;
                colorWheelForm.ColorWheel.Color = previousColor;
                colorWheelForm.ColorChanged += OnColorWheelColorChanged;
                colorWheelForm.ShowDialog();
                if(colorWheelForm.DialogResult == DialogResult.Cancel)
                    SetShapeColor(previousColor);
            }
        }
        void OnColorWheelColorChanged(object sender, ColorPickerForm.ColorChangedEventArgs args) {
            SetShapeColor(args.Color);
        }
        void SetShapeColor(Color color) {
            vectorItemsLayer1.ItemStyle.Fill = vectorItemsLayer1.ItemStyle.Stroke = color;
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            ChkShowMinimap.Enabled = false;
        }
    }
}
