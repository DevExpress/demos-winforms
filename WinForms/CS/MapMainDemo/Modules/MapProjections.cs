using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.Demos.DayAndNightLineCalculator;
using DevExpress.Map;
using DevExpress.XtraBars;
using DevExpress.XtraTreeList;

namespace DevExpress.XtraMap.Demos {
    public partial class MapProjections : MapTutorialControl {
        const double DiscreteHoursStep = 0.5;
        const double SteadilyHoursStep = 24.5;
        readonly List<MapItem> excludeFromSouth = new List<MapItem>();

        MapCustomElement Sun { get { return (MapCustomElement)Data.Items[0]; } }
        MapCustomElement Moon { get { return (MapCustomElement)Data.Items[2]; } }
        MapPolygon DayAndNightLine { get { return (MapPolygon)Data.Items[1]; } }
        DateTime ActualDateTime {
            get { return barEditCalendar.EditValue != null ? (DateTime)barEditCalendar.EditValue : DateTime.UtcNow; }
            set { barEditCalendar.EditValue = value; }
        }

        public override MapControl MapControl { get { return mapControl1; } }

        public MapProjections() {
            InitializeComponent();
            ShapefileDataAdapter.FileUri = DemoUtils.GetFileUri("Countries.shp");
            UpdateCurrentDayAndNightLine();
            PopulateData();
            GenerateGrid();
        }

        void PopulateData() {
            Projection LAEAParent = new Projection() { Name = "Lambert Azimuthal Equal Area", PrjInstance = null };
            projectionsList.DataSource = new List<Projection>() {
            new Projection() { Name = "Spherical Mercator", PrjInstance = new SphericalMercatorProjection() },
            new Projection() { Name = "Equal Area", PrjInstance = new EqualAreaProjection()},
            new Projection() { Name = "Equirectangular", PrjInstance = new EquirectangularProjection()},
            new Projection() { Name = "Elliptical Mercator", PrjInstance = new EllipticalMercatorProjection()},
            new Projection() { Name = "Miller", PrjInstance = new MillerProjection()},
            new Projection() { Name = "Equidistant", PrjInstance = new EquidistantProjection() },
            new Projection() { Name = "Lambert Cylindrical Equal Area", PrjInstance = new LambertCylindricalEqualAreaProjection() },
            LAEAParent,
            new Projection() { Name = "ETRS89", PrjInstance = new Etrs89LambertAzimuthalEqualAreaProjection(), ParentPrjName = LAEAParent.Name},
            new Projection() { Name = "North Pole", PrjInstance = new NorthPole(), ParentPrjName = LAEAParent.Name},
            new Projection() { Name = "South Pole", PrjInstance = new SouthPole(), ParentPrjName = LAEAParent.Name},
            new Projection() { Name = "Braun Stereographic", PrjInstance = new BraunStereographicProjection() },
            new Projection() { Name = "Kavrayskiy VII", PrjInstance = new KavrayskiyProjection() },
            new Projection() { Name = "Sinusoidal", PrjInstance = new SinusoidalProjection() },
            new Projection() { Name = "EPSG:4326", PrjInstance = new EPSG4326Projection()},
            };
        }
        void GenerateGrid() {
            Color gridColor = Color.FromArgb(50, 255, 255, 255);
            GenerateLatitudes(gridColor);
            GenerateLongitudes(gridColor);
        }
        void GenerateLatitudes(Color gridColor) {
            for(double i = -90; i <= 90; i += 10) {
                CoordPointCollection points = new CoordPointCollection();
                for(int x = -180; x <= 180; x++)
                    points.Add(new GeoPoint(i, x));
                MapPolyline line = new MapPolyline() {
                    Points = points,
                    StrokeWidth = 1,
                    Stroke = gridColor,
                    IsGeodesic = false
                };
                GridData.Items.Add(line);
            }
        }
        void GenerateLongitudes(Color gridColor) {
            for(double i = -180; i <= 180; i += 10) {
                CoordPointCollection points = new CoordPointCollection();
                for(int y = -90; y <= 90; y++)
                    points.Add(new GeoPoint(y, i));
                MapPolyline line = new MapPolyline() {
                    Points = points,
                    StrokeWidth = 1,
                    Stroke = gridColor,
                    IsGeodesic = false
                };
                GridData.Items.Add(line);
            }
        }
        void UpdateCurrentDayAndNightLine() {
            DateTime dt = DateTime.UtcNow;
            ActualDateTime = dt;
            UpdateDayAndNightLine(dt);
        }
        void UpdateDayAndNightLine(DateTime dt) {
            double[] sun3DPosition = DayAndNightLineCalculator.CalculateSunPosition(dt);
            GeoPoint sunLocation = new GeoPoint(sun3DPosition[1], sun3DPosition[0]);
            GeoPoint moonLocation = GetOppositePoint(sunLocation);
            Sun.Location = sunLocation;
            Moon.Location = moonLocation;
            bool isNorthNight = DayAndNightLineCalculator.CalculateIsNorthNight(sun3DPosition);
            CoordPointCollection dayAndNightLineVertices = GetDayAndNightLineVertices(sunLocation, 0.1);
            if(isNorthNight)
                AddNorthContour(dayAndNightLineVertices);
            else
                AddSouthContour(dayAndNightLineVertices);
            DayAndNightLine.Points = dayAndNightLineVertices;
        }
        CoordPointCollection GetDayAndNightLineVertices(GeoPoint sunLocation, double step) {
            CoordPointCollection result = new CoordPointCollection();
            IList<double> latitudes = DayAndNightLineCalculator.GetDayAndNightLineLatitudes(sunLocation.Latitude, sunLocation.Longitude, step);
            double lon = -180;
            foreach(double lat in latitudes) {
                result.Add(new GeoPoint(lat, lon));
                lon += step;
            }
            return result;
        }
        GeoPoint GetOppositePoint(GeoPoint sunLocation) {
            double lat = -sunLocation.Latitude;
            double lon = sunLocation.Longitude + 180;
            if(lon > 180)
                lon -= 360;
            return new GeoPoint(lat, lon);
        }
        void AddNorthContour(CoordPointCollection dayAndNightLineVertices) {
            double initLat = Math.Ceiling(((GeoPoint)dayAndNightLineVertices[dayAndNightLineVertices.Count - 1]).Latitude);
            for(double latForward = initLat; latForward <= 90.0; latForward++)
                dayAndNightLineVertices.Add(new GeoPoint(latForward, 180));
            initLat = Math.Ceiling(((GeoPoint)dayAndNightLineVertices[0]).Latitude);
            for(double latBackward = 90; latBackward >= initLat; latBackward--)
                dayAndNightLineVertices.Add(new GeoPoint(latBackward, -180));
        }
        void AddSouthContour(CoordPointCollection dayAndNightLineVertices) {
            double initLat = Math.Ceiling(((GeoPoint)dayAndNightLineVertices[dayAndNightLineVertices.Count - 1]).Latitude);
            for(double lat = initLat; lat >= -90.0; lat--)
                dayAndNightLineVertices.Add(new GeoPoint(lat, 180));
            initLat = Math.Ceiling(((GeoPoint)dayAndNightLineVertices[0]).Latitude);
            for(double lat = -90; lat <= initLat; lat++)
                dayAndNightLineVertices.Add(new GeoPoint(lat, -180));
        }
        void UpdateTimerEnabled(bool enabled) {
            timer.Enabled = enabled;
            chkSteadily.Checked = enabled;
        }
        bool IsDateOverFlow(DateTime currentDate, double stepHours) {
            long hoursTicks = (long)(stepHours * TimeSpan.TicksPerHour + currentDate.Ticks);
            return hoursTicks >= DateTime.MaxValue.Ticks | hoursTicks <= DateTime.MinValue.Ticks;
        }
        DateTime GetNextDateTime(DateTime dt) {
            double step = chkSteadily.Checked ? SteadilyHoursStep : DiscreteHoursStep;
            return IsDateOverFlow(dt, step) ? DateTime.MaxValue : dt.AddHours(step);
        }
        DateTime GetPreviousDateTime(DateTime dt) {
            return IsDateOverFlow(dt, -DiscreteHoursStep) ? DateTime.MinValue : dt.AddHours(-DiscreteHoursStep);
        }
        void OnTimerTick(object sender, EventArgs e) {
            ActualDateTime = GetNextDateTime(ActualDateTime);
        }
        void DayAndNight_DataLoaded(object sender, DataLoadedEventArgs e) {
            foreach(MapShape item in ((MapItemsLoadedEventArgs)e).Items) {
                MapBounds bounds = item.GetBounds();
                if(bounds.Width > 359.0 && bounds.Bottom < -89.9)
                    excludeFromSouth.Add(item);
            }
            projectionsList.ExpandAll();
            projectionsList.FocusedNode = projectionsList.FindNodeByID(12);
        }
        void barEditItem2_EditValueChanged(object sender, EventArgs e) {
            UpdateDayAndNightLine(ActualDateTime);
        }
        void btnCurrent_ItemClick(object sender, ItemClickEventArgs e) {
            UpdateTimerEnabled(false);
            UpdateCurrentDayAndNightLine();
        }
        void chkSteadily_CheckedChanged(object sender, ItemClickEventArgs e) {
            UpdateTimerEnabled(chkSteadily.Checked);
        }
        void btnPlus_ItemClick(object sender, ItemClickEventArgs e) {
            UpdateTimerEnabled(false);
            ActualDateTime = GetNextDateTime(ActualDateTime);
        }
        void btnMinus_ItemClick(object sender, ItemClickEventArgs e) {
            UpdateTimerEnabled(false);
            ActualDateTime = GetPreviousDateTime(ActualDateTime);
        }
        void ZoomLayersToFit() {
            MapControl.EnableZooming = true;
            MapControl.ZoomToFitLayerItems(new LayerBase[] { FileLayer }, 0.3);
            MapControl.EnableZooming = false;
        }
        void SetVisibleEx(bool value) {
            excludeFromSouth.ForEach((item) => item.Visible = value);
        }
        void OnProjectionsListFocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e) {
            Projection data = (Projection)projectionsList.GetDataRecordByNode(e.Node);
            if(data.PrjInstance == null)
                return;
            GeoMapCoordinateSystem cs = (GeoMapCoordinateSystem)mapControl1.CoordinateSystem;
            cs.Projection = data.PrjInstance;
            SetVisibleEx(!(cs.Projection is NorthPole));
            ZoomLayersToFit();
            if(cs.Projection is LambertAzimuthalEqualAreaProjectionBase)
                mapControl1.CenterPoint = new GeoPoint(((LambertAzimuthalEqualAreaProjectionBase)cs.Projection).OriginLatitude,
                                                       ((LambertAzimuthalEqualAreaProjectionBase)cs.Projection).CentralMeridian);
        }
        void OnShowGridCheckedChanged(object sender, ItemClickEventArgs e) {
            GridLayer.Visible = ShowGridBarCheckItem.Checked;
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            DisableZoomOptions();
            ChkShowMinimap.Enabled = false;
        }
        protected override void RestoreInitialView() {
            MapControl.CenterPoint = new GeoPoint();
        }
        protected override void DoHide() {
            base.DoHide();
            UpdateTimerEnabled(false);
        }
        protected override void DoShow() {
            base.DoShow();
            UpdateTimerEnabled(true);
        }
    }
    public class Projection {
        public string Name { get; set; }
        public ProjectionBase PrjInstance { get; set; }
        public string ParentPrjName { get; set; }
    }

    public class SouthPole : LambertAzimuthalEqualAreaProjectionBase {
        protected override bool IsPredefined { get { return false; } }
        protected override MapBounds GetBoundingBox() {
            return new MapBounds(-180.0, -90.0, 180.0, 0.0);
        }
        public SouthPole() {
            OriginLatitude = -90.0;
        }
        public override GeoPoint MapUnitToGeoPoint(MapUnit mapPoint) {
            GeoPoint res = base.MapUnitToGeoPoint(mapPoint);
            if(mapPoint.X > 0.5 && mapPoint.Y > 0.5)
                res = new GeoPoint(res.GetY(), 180.0 + res.GetX());
            if(mapPoint.X <= 0.5 && mapPoint.Y > 0.5)
                res = new GeoPoint(res.GetY(), res.GetX() - 180.0);
            return res;
        }
    }

    public class NorthPole : LambertAzimuthalEqualAreaProjectionBase {
        protected override bool IsPredefined { get { return false; } }
        protected override MapBounds GetBoundingBox() {
            return new MapBounds(-180.0, 0.0, 180.0, 90.0);
        }

        public NorthPole() {
            OriginLatitude = 90.0;
        }
        public override GeoPoint MapUnitToGeoPoint(MapUnit mapPoint) {
            GeoPoint res = base.MapUnitToGeoPoint(mapPoint);
            if(mapPoint.X >= 0.5 && mapPoint.Y < 0.5)
                res = new GeoPoint(res.GetY(), 180.0 + res.GetX());
            if(mapPoint.X < 0.5 && mapPoint.Y < 0.5)
                res = new GeoPoint(res.GetY(), res.GetX() - 180.0);
            return res;
        }
    }
}
