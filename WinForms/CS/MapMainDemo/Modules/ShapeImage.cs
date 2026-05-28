using System.Drawing;
using DevExpress.Map;

namespace DevExpress.XtraMap.Demos {
    public partial class ShapeImage : FooteredMapTutorialControl {
        protected override Image CopyrightImage { get { return DemoUtils.AzureLogo; } }
        protected override string CopyrightText { get { return DemoUtils.AzureCopyright; } }
        public override MapControl MapControl { get { return mapControl; } }

        public ShapeImage() {
            InitializeComponent();
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider);

            MapPolygon centralPark = new MapPolygon() { Stroke = System.Drawing.Color.Transparent };
            centralPark.Points.Add(new GeoPoint(40.767809, -73.981249));
            centralPark.Points.Add(new GeoPoint(40.768458, -73.981477));
            centralPark.Points.Add(new GeoPoint(40.800273, -73.958291));
            centralPark.Points.Add(new GeoPoint(40.800396, -73.957846));
            centralPark.Points.Add(new GeoPoint(40.797011, -73.949683));
            centralPark.Points.Add(new GeoPoint(40.796626, -73.949541));
            centralPark.Points.Add(new GeoPoint(40.764918, -73.972547));
            centralPark.Points.Add(new GeoPoint(40.765230, -73.973245));
            centralPark.Points.Add(new GeoPoint(40.764704, -73.973741));
            centralPark.Image.Source = Properties.Resources.CentralPark;
            mapItemStorage.Items.Add(centralPark);
        }
        void ImageLayer1_ViewportChanged(object sender, ViewportChangedEventArgs e) {
            if(!e.IsAnimated && e.ZoomLevel <= 14) {
                CoordPoint center = InitialCenterPoint ?? mapControl.CenterPoint;
                double xOffset = (e.BottomRight.GetX() - e.TopLeft.GetX()) / 2d;
                double yOffset = (e.BottomRight.GetY() - e.TopLeft.GetY()) / 2d;
                mapControl.ScrollArea = new MapBounds(center.Offset(-xOffset, -yOffset), center.Offset(xOffset, yOffset));
            }
        }
    }
}
