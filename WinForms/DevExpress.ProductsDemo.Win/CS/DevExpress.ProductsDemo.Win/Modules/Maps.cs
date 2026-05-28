using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Map;
using DevExpress.Utils.Design;
using DevExpress.Utils.DPI;
using DevExpress.Utils.Html;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;

namespace DevExpress.ProductsDemo.Win.Modules {
    public partial class MapsModule : BaseModule {
        FlightMapDataGenerator dataGenerator;
        MapInfoPanel mapInfoPanel;

        protected override bool AutoMergeRibbon { get { return true; } }

        public MapControl MapControl { get { return mapControl1; } }

        public MapsModule() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            TilesLayer.DataProvider = MapUtils.CreateAzureDataProvider(AzureTileset.BaseRoad);
            MapControl.SetMapItemFactory(new FlightMapFactory(ScaleDPI));

            Dictionary<string, HtmlTemplate> templates = new Dictionary<string, HtmlTemplate>();
            templates.Add("plane", PlaneTemplate);
            templates.Add("airport", AirportTemplate);
            mapInfoPanel = new MapInfoPanel(ScaleDPI, htmlContentPopup1, templates);

            dataGenerator = new FlightMapDataGenerator();
            dataGenerator.DataChanged += OnDataChanged;

            PlanesDataAdapter.DataSource = dataGenerator.Planes;
            PathsDataAdapter.DataSource = dataGenerator.AirPaths;
            AirportsDataAdapter.DataSource = dataGenerator.Airports;
        }
        void OnAzureKindCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            UpdateAzureMapKind((int)e.Item.Tag);
        }
        void OnDataChanged(object sender, EventArgs e) {
            if(!PlanesLayer.Visible)
                return;
            MapControl.SuspendRender();
            foreach(MapItem item in PlanesLayer.Data.Items) {
                PlaneInfo info = item.Tag as PlaneInfo;
                MapPushpin pin = item as MapPushpin;
                if(pin != null && info != null) {
                    pin.Location = new GeoPoint(info.Latitude, info.Longitude);
                    pin.Angle = info.Course;
                    pin.Visible = !info.IsLanded;
                }
            }
            MapControl.ResumeRender();
            this.mapInfoPanel.Update();
        }
        void AirportsLayer_DataLoaded(object sender, DataLoadedEventArgs e) {
            AirportInfo current = dataGenerator.Airports.Find(a => a.IATA == "FRA");
            AirportsLayer.SelectedItem = current;
            dataGenerator.Start();
        }
        void OnMapSelectionChanged(object sender, MapSelectionChangedEventArgs e) {
            ItemInfoBase info = e.Selection.FirstOrDefault() as ItemInfoBase;
            this.mapInfoPanel.SetCurrentInfo(info, MapControl);
            ShowRoutes(info as AirportInfo);
            OnActivePlaneChanged(info as PlaneInfo);
        }
        void OnPlanesVisibilityCheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            PlanesLayer.Visible = barCheckItem1.Checked;
            PlanesLayer.SelectedItems.Clear();
        }
        void UpdateAzureMapKind(int azureMapKind) {
            AzureMapDataProvider provider = (AzureMapDataProvider)TilesLayer.DataProvider;
            provider.Tileset = (AzureTileset)azureMapKind;
        }
        void ShowRoutes(AirportInfo info) {
            RoutesStorage.Items.Clear();
            if(info != null) {
                RoutesStorage.Items.BeginUpdate();
                List<RouteInfo> res = dataGenerator.Routes.FindAll(r => r.Src == info.IATA);
                foreach(var item in res) {
                    AirportInfo ap = dataGenerator.Airports.Find(a => a.IATA.Equals(item.Dst));
                    if(ap != null) {
                        RoutesStorage.Items.Add(new MapLine() {
                            Point1 = new GeoPoint(info.Latitude, info.Longitude),
                            Point2 = new GeoPoint(ap.Latitude, ap.Longitude),
                            IsGeodesic = true,
                            EnableSelection = Utils.DefaultBoolean.False,
                            EnableHighlighting = Utils.DefaultBoolean.False,
                            Stroke = FlightMapFactory.AccentShapeColor,
                            StrokeWidth = 2
                        });
                        AccentPoint(new GeoPoint(ap.Latitude, ap.Longitude));
                    }
                }
                RoutesStorage.Items.EndUpdate();
            }
        }
        void AccentPoint(CoordPoint point) {
            RoutesStorage.Items.Add(new MapDot() {
                Location = point,
                Stroke = FlightMapFactory.AccentShapeColor,
                StrokeWidth = 2,
                Size = ScaleDPI.ScaleHorizontal(FlightMapFactory.PointSizeDIP),
                Fill = Color.White,
                IsHitTestVisible = false
            });
        }
        void OnActivePlaneChanged(PlaneInfo planeInfo) {
            MapItemCollection items = (MapItemCollection)PathsLayer.Data.Items;
            items.BeginUpdate();
            HideLayerItems(PathsLayer);
            List<ItemInfoBase> airPath = dataGenerator.FindAirPath(planeInfo);
            foreach(ItemInfoBase airPathElement in airPath) {
                MapPolyline item = PathsLayer.GetMapItemBySourceObject(airPathElement) as MapPolyline;
                if(item != null) {
                    item.Visible = true;
                    AccentPoint(item.Points[0]);
                    AccentPoint(item.Points[item.Points.Count - 1]);
                }
            }
            items.EndUpdate();
        }
        void HideLayerItems(VectorItemsLayer layer) {
            foreach(MapItem item in layer.Data.Items)
                item.Visible = false;
        }
        void OnDispose() {
            if(dataGenerator != null) {
                dataGenerator.Dispose();
                dataGenerator = null;
            }
            if(mapInfoPanel != null) {
                mapInfoPanel.Dispose();
                mapInfoPanel = null;
            }
        }
        internal override void ShowModule(bool firstShow) {
            base.ShowModule(firstShow);
            if(!firstShow)
                dataGenerator.Start();
        }
        internal override void HideModule() {
            dataGenerator.Stop();
            base.HideModule();
        }
    }

    public class FlightMapDataGenerator : IDisposable {
        const double SecPerHour = 3600000;
        const double SpeedScale = 10.0;

        readonly List<PlaneInfo> planes = new List<PlaneInfo>();
        readonly List<ItemInfoBase> airPaths = new List<ItemInfoBase>();
        readonly List<AirportInfo> airports;
        readonly List<RouteInfo> routes;
        readonly Timer timer = new Timer();

        DateTime lastTime;

        public List<AirportInfo> Airports { get { return airports; } }
        public List<RouteInfo> Routes { get { return routes; } }
        public List<PlaneInfo> Planes { get { return planes; } }
        public List<ItemInfoBase> AirPaths { get { return airPaths; } }

        public event EventHandler DataChanged;

        static string RandomID(DevExpress.Data.Utils.NonCryptographicRandom random) {
            int A = 'A';
            int Z = 'Z';
            int n0 = '0';
            int n9 = '9';
            return string.Format("{0}{1}{2}{3}{4}{5}",
                (char)random.Next(A, Z),
                (char)random.Next(A, Z),
                (char)random.Next(n0, n9),
                (char)random.Next(n0, n9),
                (char)random.Next(n0, n9),
                (char)random.Next(A, Z));
        }
        static string GetPlaneName(DevExpress.Data.Utils.NonCryptographicRandom random, double length) {
            string[] farStr = new string[] { "Boeing 777", "Airbus A380" };
            string[] nearStr = new string[] { "Boeing 737", "Airbus A318", "Airbus A320" };
            string[] mediumStr = new string[] { "Boeing 747", "Airbus A340" };

            if(length > 8000)
                return farStr[random.Next(farStr.Length)];
            if(length < 3500)
                return nearStr[random.Next(nearStr.Length)];
            return mediumStr[random.Next(mediumStr.Length)];
        }

        public FlightMapDataGenerator() {
            airports = LoadAirports();
            routes = LoadRoutes();
            LoadPlanes();
            timer.Tick += new EventHandler(OnTimedEvent);
            timer.Interval = 2000;
        }

        void RaiseDataChanged() {
            EventHandler dataChanged = DataChanged;
            if(dataChanged != null)
                dataChanged(this, EventArgs.Empty);
        }
        List<AirportInfo> LoadAirports() {
            List<AirportInfo> airports = new List<AirportInfo>();
            try {
                using(StreamReader reader = new StreamReader(DemoUtils.GetRelativePath("airports.csv"))) {
                    while(!reader.EndOfStream) {
                        string line = reader.ReadLine();
                        var values = line.Split(';');
                        AirportInfo point = new AirportInfo(new GeoPoint(double.Parse(values[4], CultureInfo.InvariantCulture), double.Parse(values[5], CultureInfo.InvariantCulture))) {
                            Name = values[0],
                            City = values[1],
                            Country = values[2],
                            IATA = values[3]
                        };
                        airports.Add(point);
                    }
                }
            }
            catch {
                throw new Exception("It's impossible to load airports data");
            }
            return airports;
        }
        List<RouteInfo> LoadRoutes() {
            List<RouteInfo> routes = new List<RouteInfo>();
            try {
                using(StreamReader reader = new StreamReader(DemoUtils.GetRelativePath("airroutes.csv"))) {
                    while(!reader.EndOfStream) {
                        string line = reader.ReadLine();
                        var values = line.Split(';');
                        routes.Add(new RouteInfo() { Src = values[0], Dst = values[1] });
                    }
                }
            }
            catch {
                throw new Exception("It's impossible to load route data");
            }
            return routes;
        }
        void LoadPlanes() {
            int count = 1200;
            while(count > 0) {
                RouteInfo routeInfo = Routes[TutorialConstants.Random.Next(0, Routes.Count - 1)];
                AirportInfo a1 = Airports.Find(a => a.IATA == routeInfo.Src);
                AirportInfo a2 = Airports.Find(a => a.IATA == routeInfo.Dst);
                if(a1 == null || a2 == null)
                    continue;
                count--;
                List<CoordPoint> points = new List<CoordPoint> {
                    new GeoPoint(a1.Latitude, a1.Longitude),
                    new GeoPoint(a2.Latitude, a2.Longitude)
                };

                double speed = TutorialConstants.Random.Next(600, 850);
                TrajectoryInfo trajectory = new TrajectoryInfo(points, speed);
                string planeName = GetPlaneName(TutorialConstants.Random, trajectory.Length);
                PlaneInfo info = new PlaneInfo(planeName, RandomID(TutorialConstants.Random), a2.City, a1.City, speed, TutorialConstants.Random.Next(7200, 10500), trajectory);
                info.CurrentFlightTime = info.TotalFlightTime * TutorialConstants.Random.NextDouble() * 0.7;

                int size = (int)(14 + 0.001 * trajectory.Length);
                info.IconSize = new Size(size, size);

                planes.Add(info);
                airPaths.Add(info.Trajectory);
            }
        }
        
        void OnTimedEvent(object source, EventArgs e) {
            DateTime currentTime = TutorialConstants.Now;
            TimeSpan interval = currentTime.Subtract(lastTime);

            foreach(PlaneInfo info in Planes) {
                if(!info.IsLanded)
                    info.CurrentFlightTime += SpeedScale * interval.TotalMilliseconds / SecPerHour;
            }
            lastTime = currentTime;
            RaiseDataChanged();
        }

        public void Dispose() {
            Stop();
            timer.Tick -= OnTimedEvent;
            timer.Dispose();
        }
        public void Start() {
            lastTime = TutorialConstants.Now;
            timer.Start();
        }
        public void Stop() {
            timer.Stop();
        }
        public List<ItemInfoBase> FindAirPath(PlaneInfo plane) {
            return plane != null ? airPaths.FindAll(p => p == plane.Trajectory) : new List<ItemInfoBase>();
        }
    }
    public class RouteInfo {
        public string Src { get; set; }
        public string Dst { get; set; }
    }

    public abstract class ItemInfoBase {
        protected abstract MapItemType Type { get; }

        public int ItemType { get { return (int)Type; } }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class TrajectoryInfo : ItemInfoBase {
        class TrajectoryPart {
            public GeoPoint StartPoint { get; private set; }
            public GeoPoint EndPoint { get; private set; }
            public double FlightTime { get; private set; }
            public double Course { get; private set; }
            public double Length { get; private set; }

            public TrajectoryPart(GeoPoint start, GeoPoint end, double speedInKmH) {
                StartPoint = start;
                EndPoint = end;
                Length = GeoUtils.CalculateDistance(start, end) * 0.001;
                FlightTime = Length / speedInKmH;
                Course = Math.Atan2((end.Longitude - start.Longitude), (end.Latitude - start.Latitude));
            }
            public GeoPoint GetPointByCurrentFlightTime(double currentFlightTime) {
                if(currentFlightTime > FlightTime)
                    return EndPoint;
                double ratio = currentFlightTime / FlightTime;
                return new GeoPoint(StartPoint.Latitude + ratio * (EndPoint.Latitude - StartPoint.Latitude), StartPoint.Longitude + ratio * (EndPoint.Longitude - StartPoint.Longitude));
            }
        }

        readonly List<TrajectoryPart> trajectory = new List<TrajectoryPart>();
        readonly double speedInKmH;

        protected override MapItemType Type { get { return MapItemType.Polyline; } }

        public double FlightTime {
            get {
                double result = 0.0;
                foreach(TrajectoryPart part in trajectory)
                    result += part.FlightTime;
                return result;
            }
        }
        public double Length {
            get {
                double result = 0.0;
                foreach(TrajectoryPart part in trajectory)
                    result += part.Length;
                return result;
            }
        }

        public TrajectoryInfo(List<CoordPoint> points, double speedInKmH) {
            this.speedInKmH = speedInKmH;
            UpdateTrajectory(points);
        }
        public GeoPoint GetPointByCurrentFlightTime(double currentFlightTime) {
            double time = 0.0;
            for(int i = 0; i < trajectory.Count - 1; i++) {
                if(trajectory[i].FlightTime > currentFlightTime - time)
                    return trajectory[i].GetPointByCurrentFlightTime(currentFlightTime - time);
                time += trajectory[i].FlightTime;
            }
            return trajectory[trajectory.Count - 1].GetPointByCurrentFlightTime(currentFlightTime - time);
        }
        public CoordPointCollection GetAirPath() {
            CoordPointCollection result = new CoordPointCollection();
            foreach(TrajectoryPart trajectoryPart in trajectory)
                result.Add(trajectoryPart.StartPoint);
            if(trajectory.Count > 0)
                result.Add(trajectory[trajectory.Count - 1].EndPoint);
            return result;
        }
        public double GetCourseByCurrentFlightTime(double currentFlightTime) {
            double time = 0.0;
            for(int i = 0; i < trajectory.Count - 1; i++) {
                if(trajectory[i].FlightTime > currentFlightTime - time)
                    return trajectory[i].Course;
                time += trajectory[i].FlightTime;
            }
            return trajectory[trajectory.Count - 1].Course;
        }
        public void UpdateTrajectory(List<CoordPoint> points) {
            trajectory.Clear();
            for(int i = 0; i < points.Count - 1; i++)
                trajectory.Add(new TrajectoryPart((GeoPoint)points[i], (GeoPoint)points[i + 1], speedInKmH));
        }
    }
    public class AirportInfo : ItemInfoBase {
        protected override MapItemType Type { get { return MapItemType.Dot; } }

        public string Title { get { return "Airport info"; } }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string IATA { get; set; }

        public AirportInfo(GeoPoint location) {
            this.Latitude = location.Latitude;
            this.Longitude = location.Longitude;
        }
    }
    public class PlaneInfo : ItemInfoBase {
        static readonly SvgImage icon = Properties.Resources.Plane;

        readonly string planeID;
        readonly string name;
        readonly string endPointName;
        readonly string startPointName;
        readonly double speedInKmH;
        readonly double flightAltitude;
        readonly TrajectoryInfo trajectory;
        double currentFlightTime;
        Image image;

        public double Course { get; private set; }

        protected override MapItemType Type { get { return MapItemType.Pushpin; } }
        
        public string Title { get { return "Flight info"; } }
        public double CurrentFlightTime {
            get { return currentFlightTime; }
            set {
                if(currentFlightTime == value)
                    return;
                currentFlightTime = value;
                UpdatePosition(currentFlightTime);
            }
        }
        public string PlaneID { get { return planeID; } }
        public string Name { get { return name; } }
        public string EndPointName { get { return endPointName; } }
        public string StartPointName { get { return startPointName; } }
        public double SpeedKmH { get { return IsLanded ? 0.0 : speedInKmH; } }
        public double FlightAltitude { get { return IsLanded ? 0.0 : flightAltitude; } }
        public bool IsLanded { get; private set; }
        public double TotalFlightTime { get { return trajectory.FlightTime; } }
        public SvgImage Icon { get { return icon; } }
        public Image Image { get { return image; } }
        public Size IconSize { get; set; }
        public TrajectoryInfo Trajectory { get { return trajectory; } }

        public TimeSpan CurrentFlightTimeInfo => new TimeSpan(0, 0, (int)Math.Ceiling(CurrentFlightTime * 3600));
        public TimeSpan TotalFlightTimeInfo => new TimeSpan(0, 0, (int)Math.Ceiling(TotalFlightTime * 3600));

        public PlaneInfo(string name, string id, string endPointName, string startPointName, double speedInKmH, double flightAltitude, TrajectoryInfo trajectory) {
            this.name = name;
            this.planeID = id;
            this.endPointName = endPointName;
            this.startPointName = startPointName;
            this.speedInKmH = speedInKmH;
            this.flightAltitude = flightAltitude;
            this.trajectory = trajectory;
            UpdatePosition(CurrentFlightTime);
        }

        void UpdatePosition(double flightTime) {
            IsLanded = flightTime >= trajectory.FlightTime;
            GeoPoint point = trajectory.GetPointByCurrentFlightTime(flightTime);
            Latitude = point.Latitude;
            Longitude = point.Longitude;
            Course = trajectory.GetCourseByCurrentFlightTime(flightTime);
        }
        public void UpdateImage(Image planeImage) {
            image = planeImage;
        }
    }

    public class FlightMapFactory : DefaultMapItemFactory {
        public static Color AccentShapeColor = Color.FromArgb(255, 209, 28, 28);
        public static int PointSizeDIP = 8;

        readonly PlaneSvgPaletteProvider provider = new PlaneSvgPaletteProvider();
        readonly ScaleHelper scaleDPI;

        public FlightMapFactory(ScaleHelper scaleDPI) {
            this.scaleDPI = scaleDPI;
        }

        protected override void InitializeItem(MapItem item, object obj) {
            base.InitializeItem(item, obj);

            MapPolyline polyLine = item as MapPolyline;
            TrajectoryInfo trajectory = obj as TrajectoryInfo;
            if(polyLine != null && trajectory != null) {
                polyLine.IsGeodesic = true;
                polyLine.Points = trajectory.GetAirPath();
                polyLine.Fill = Color.Empty;
                polyLine.Stroke = AccentShapeColor;
                polyLine.StrokeWidth = 2;
                trajectory.UpdateTrajectory(polyLine.ActualPoints.ToList());
                polyLine.Visible = false;
                return;
            }

            MapDot airport = item as MapDot;
            AirportInfo airportInfo = obj as AirportInfo;
            if(airport != null && airportInfo != null) {
                airport.Size = this.scaleDPI.ScaleHorizontal(PointSizeDIP);
                airport.Fill = Color.White;
                airport.SelectedFill = AccentShapeColor;
                airport.HighlightedStroke = AccentShapeColor;
                airport.SelectedStroke = AccentShapeColor;
                airport.Stroke = Color.FromArgb(255, 114, 114, 114);
                airport.StrokeWidth = 2;
                return;
            }

            MapPushpin planeElement = item as MapPushpin;
            PlaneInfo info = obj as PlaneInfo;
            if(planeElement != null && info != null) {
                planeElement.UseAnimation = false;
                planeElement.SvgImage = info.Icon;
                planeElement.SvgImageSize = info.IconSize;
                planeElement.SvgPaletteProvider = provider;
                planeElement.Angle = info.Course;
                planeElement.Visible = false;
            }
        }
    }
    public class PlaneSvgPaletteProvider : IMapSvgPaletteProvider {
        ISvgPaletteProvider IMapSvgPaletteProvider.GetSvgPalette(MapElementState state) {
            SvgPalette svgPalette = new SvgPalette();
            if((state & MapElementState.Highlighted) == MapElementState.Highlighted ||
               (state & MapElementState.Selected) == MapElementState.Selected)
                svgPalette.Colors.Add(new SvgColor("Blue", Color.FromArgb(255, 255, 177, 21)));
            return svgPalette;
        }
    }
    public class MapInfoPanel : IDisposable {
        readonly Dictionary<string, Image> PlaneImages = new Dictionary<string, Image>();
        readonly HtmlContentPopup htmlContentPopup;
        readonly ScaleHelper scaleHelper;
        readonly Dictionary<string, HtmlTemplate> templates;

        static string ConvertPlaneNameToFilePath(string PlaneName) {
            return DemoUtils.GetRelativePath("Planes\\" + PlaneName.Replace(" ", "") + ".png");
        }

        public MapInfoPanel(ScaleHelper scaleHelper, HtmlContentPopup htmlContentPopup, Dictionary<string, HtmlTemplate> templates) {
            this.templates = templates;
            this.htmlContentPopup = htmlContentPopup;
            this.htmlContentPopup.HideAutomatically = Utils.DefaultBoolean.False;
            this.scaleHelper = scaleHelper;
        }

        Image GetPlaneImage(string name) {
            Image result = null;
            if(!PlaneImages.TryGetValue(name, out result)) {
                Image src = new Bitmap(ConvertPlaneNameToFilePath(name));
                try {
                    result = MapUtils.ScaleImage(src, this.scaleHelper);
                    if(src != result)
                        src.Dispose();
                }
                catch {
                    result = src;
                }
                PlaneImages.Add(name, result);
            }
            return result;
        }
        
        public void Update() {
            htmlContentPopup.UpdateLayout();
        }
        public void Dispose() {
            foreach(Image image in PlaneImages.Values)
                image.Dispose();
            PlaneImages.Clear();
            GC.SuppressFinalize(this);
        }
        public void SetCurrentInfo(ItemInfoBase obj, Control owner) {
            if(obj == null) {
                htmlContentPopup.Hide();
                return;
            }

            PlaneInfo planeInfo = obj as PlaneInfo;
            if(planeInfo != null) {
                planeInfo.UpdateImage(GetPlaneImage(planeInfo.Name));
                htmlContentPopup.HtmlTemplate.Assign(templates["plane"]);
            }
            AirportInfo airportInfo = obj as AirportInfo;
            if(airportInfo != null)
                htmlContentPopup.HtmlTemplate.Assign(templates["airport"]);

            htmlContentPopup.DataContext = obj;
            Size sz = this.htmlContentPopup.CalcBestSize(owner, -1);
            Rectangle bounds = owner.RectangleToScreen(new Rectangle(new Point(owner.Bounds.Right - sz.Width, owner.Bounds.Top), sz));
            htmlContentPopup.Show(owner, bounds);
        }
    }
}
