using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors;

namespace DevExpress.XtraMap.Demos {
    public partial class DirectionsNavigation : FooteredMapTutorialControl {
        readonly Color defaultRouteColor = Color.FromArgb(0xFF, 0x8A, 0xFB, 0xFF);
        public const int DefaultStrokeWidth = 4;

        MapDemoOverlayManager overlayManager;
        RouteHelper routeHelper;
        MapItem activeItem;
        RouteState state = RouteState.Normal;
        bool enableRotation = true;

        protected override MapOverlay[] Overlays => OverlayManager.GetOverlays();
        protected override Image CopyrightImage => DemoUtils.AzureLogo;
        protected override string CopyrightText => DemoUtils.AzureCopyright;
        public override MapControl MapControl => mapControl1;

        MapDemoOverlayManager OverlayManager {
            get {
                if(overlayManager == null)
                    overlayManager = new MapDemoOverlayManager();
                return overlayManager;
            }
        }
        protected RouteHelper RouteHelper {
            get {
                if(routeHelper == null) {
                    routeHelper = new RouteHelper();
                    routeHelper.WayPointsChanged += OnWayPointsChanged;
                }
                return routeHelper;
            }
        }

        protected MapItemCollection RouteLayerItems { get { return RouteLayer.Data.Items; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public RouteState State {
            get {
                return state;
            }
            set {
                if(state == value)
                    return;
                state = value;
                OnRouteStateChanged();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool EnableRotation { get { return enableRotation; } set { enableRotation = value; } }

        public DirectionsNavigation() {
            InitializeComponent();
            PrepareLayerProviders();
            directionIcon.Location = new Point(MapControl.Right - 10 - directionIcon.Width, MapControl.Top + 10);
        }
        void UpdateInformationText() {
            OverlayManager.MessageItem.Text = GetActionText();
        }
        void SetRouteLayerStyles(InformationLayer routeLayer) {
            routeLayer.ItemStyle.Stroke = routeLayer.SelectedItemStyle.Stroke = defaultRouteColor;
            routeLayer.ItemStyle.StrokeWidth = routeLayer.SelectedItemStyle.StrokeWidth = DefaultStrokeWidth;
        }
        void PrepareLayerProviders() {
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider);
            DemoUtils.SetAzureMapDataProviderKey(SearchProvider);
            DemoUtils.SetAzureMapDataProviderKey(GeoCodeProvider);
            DemoUtils.SetAzureMapDataProviderKey(RouteProvider);
            SetRouteLayerStyles(RouteLayer);
        }
        void UpdateDirectionIcon(double angle) {
            directionIcon.Angle = (float)angle;
        }
        void OnRouteStateChanged() {
            bool isDriving = State == RouteState.Drive;
            mapControl1.SearchPanelOptions.Visible = !isDriving;
            GeoCodeProvider.ProcessMouseEvents = !isDriving;

            switch(State) {
                case RouteState.Drive:
                    RouteHelper.BeginDrive(MapControl, RouteLayer);
                    RouteHelper.DriveModel.ActionTextChanged += (s, e) => OverlayManager.MessageItem.Text = RouteHelper.DriveModel.ActionText;
                    RouteHelper.DriveModel.CurrentLocationChanged += (s, e) => {
                        mapControl1.CenterPoint = RouteHelper.DriveModel.CurrentLocation;
                        mapControl1.Angle = EnableRotation ? RouteHelper.DriveModel.CurrentDirection + 90.0 : 0;
                        UpdateDirectionIcon(-mapControl1.Angle);
                    };
                    driveButton.Enabled = false;
                    stopButton.Enabled = true;
                    clearButton.Enabled = false;
                    break;
                case RouteState.Normal:
                    RouteHelper.StopDrive();
                    driveButton.Enabled = true;
                    stopButton.Enabled = false;
                    clearButton.Enabled = true;
                    mapControl1.Angle = 0;
                    break;
            }
            mapControl1.EnableAnimation = driveButton.Enabled;
            directionIcon.Visible = stopButton.Enabled;
            UpdateInformationText();
        }
        void OnWayPointsChanged(object sender, EventArgs e) {
            DataAdapter.DataSource = new List<WayPointInfo>(RouteHelper.WaypointInfoList);
            if(RouteHelper.WayPoints.Count > 1) {
                AzureRouteOptions options = new AzureRouteOptions(){
                    InstructionsType = AzureRouteInstructionsType.Text,
                };
                RouteProvider.CalculateRoute(RouteHelper.WayPoints, options);
            }
            else
                driveButton.Enabled = false;
        }
        void OnRouteLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs args) {
            if(args.Error == null && !args.Cancelled)
                RouteHelper.ProcessRouteItems(args.Items);
        }
        void OnRouteCalculated(object sender, AzureRouteCalculatedEventArgs e) {
            List<AzureRouteResult> results = e.CalculationResult.RouteResults;
            AzureRouteResult routeResult = results.Count > 0 ? results[0] : null;
            if(RouteHelper.ProcessRouteResult(routeResult)) {
                DataAdapter.DataSource = null;
                driveButton.Enabled = true;
            }
        }
        void OnGeoCodeAndSearchLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs args) {
            if(state == RouteState.Drive)
                return;
            foreach(MapItem item in args.Items)
                RouteHelper.AddGeneratedPushpin(item as MapPushpin);

            UpdateInformationText();
        }
        void OnClearButtonClick(object sender, EventArgs e) {
            RouteHelper.Clear();
            ClearLayerResults();
            RouteLayer.ClearResults();
            SearchProvider.ClearSearchPanel();
            DataAdapter.DataSource = null;
            driveButton.Enabled = false;
            stopButton.Enabled = false;
            UpdateInformationText();
        }
        void ClearLayerResults() {
            SearchLayer.ClearResults();
            GeocodeLayer.ClearResults();
        }
        bool CanRemovePin(MapPushpin pin, MapItemClickEventArgs e) {
            return pin != null && object.Equals(RouteLayer, pin.Layer) && e.MouseArgs.Button == MouseButtons.Right && State != RouteState.Drive;
        }
        void OnMapItemClick(object sender, MapItemClickEventArgs e) {
            MapPushpin pin = e.Item as MapPushpin;
            if(CanRemovePin(pin, e)) {
                activeItem = pin;
                popupMenu1.ShowPopup(Cursor.Position);
            }
            if(e.MouseArgs.Button == MouseButtons.Left) {
                if(RouteHelper.GeneratedPushpins.Contains(pin)) {
                    AddPointToRoute(pin);
                    e.Handled = true;
                }
            }
            UpdateInformationText();
        }
        void AddPointToRoute(MapPushpin pushpin) {
            RouteHelper.AddWaypoint(pushpin);
            ClearLayerResults();
        }
        void DeleteWaypoint() {
            int index = CalculatePushpinIndex();
            RouteLayerItems.Remove(activeItem);
            RouteHelper.DeleteWaypoint(index);
            ClearRoute();
        }
        void ClearRoute() {
            List<MapItem> itemsToRemove = new List<MapItem>();
            foreach(MapItem item in RouteLayerItems)
                if(item is MapPolyline)
                    itemsToRemove.Add(item);
            foreach(MapItem item in itemsToRemove)
                RouteLayerItems.Remove(item);
        }
        int CalculatePushpinIndex() {
            MapItemCollection items = RouteLayerItems;
            int index = -1;
            for(int i = 0; i < items.Count; i++) {
                if(items[i] is MapPushpin) {
                    index++;
                    if(items[i].Equals(activeItem))
                        return index;
                }
            }
            return -1;
        }
        void OnBarDeleteButtonClick(object sender, XtraBars.ItemClickEventArgs e) {
            DeleteWaypoint();
        }
        void OnBarCloseButtonClick(object sender, XtraBars.ItemClickEventArgs e) {
            popupMenu1.HidePopup();
        }
        void OnDriveButtonClick(object sender, XtraBars.ItemClickEventArgs e) {
            State = RouteState.Drive;
        }
        void OnStopButtonClick(object sender, XtraBars.ItemClickEventArgs e) {
            State = RouteState.Normal;
        }
        void OnPictureEdit1MouseClick(object sender, MouseEventArgs e) {
            EnableRotation = !EnableRotation;
        }
        void OnDispose() {
            if(routeHelper != null) {
                routeHelper.Dispose();
                routeHelper = null;
            }
            if(overlayManager != null) {
                overlayManager.Dispose();
                overlayManager = null;
            }
        }
        string GetActionText() {
            if(RouteHelper.WayPoints.Count == 0) {
                if(RouteHelper.GeneratedPushpins.Count > 0)
                    return "Click the pushpin to set a start point.";
                else
                    return "Click the map or use Search to find a location.";
            }

            if(RouteHelper.WayPoints.Count == 1)
                return "Set a finish point to calculate a route.";


            return "Set another finish point or click Drive.";
        }
        protected override void DoHide() {
            if(State == RouteState.Drive)
                State = RouteState.Normal;
            base.DoHide();
        }
    }
    public enum RouteState {
        Normal,
        Drive
    }
    public class WayPointInfo {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Text { get; set; }
        public string ToolTipPattern { get; set; }
        public int Type { get; set; }
    }
    public class RouteHelper : IDisposable {
        readonly List<WayPointInfo> wayPointsInfoList = new List<WayPointInfo>();
        readonly List<MapPushpin> generatedPushpins = new List<MapPushpin>();
        readonly List<RouteWaypoint> wayPoints = new List<RouteWaypoint>();
        readonly List<RouteInstruction> routeInstructions = new List<RouteInstruction>();
        bool disposed = false;
        List<GeoPoint> routePath = new List<GeoPoint>();

        int waypointIndex = 0;

        public List<MapPushpin> GeneratedPushpins { get { return generatedPushpins; } }
        public List<RouteWaypoint> WayPoints { get { return wayPoints; } }
        public List<WayPointInfo> WaypointInfoList { get { return wayPointsInfoList; } }
        public DriveHelper DriveModel { get; set; }

        public event EventHandler WayPointsChanged;

        public void AddGeneratedPushpin(MapPushpin pushpin) {
            if(pushpin != null && !GeneratedPushpins.Contains(pushpin))
                GeneratedPushpins.Add(pushpin);
        }
        public void Clear() {
            waypointIndex = 0;
            WayPoints.Clear();
            GeneratedPushpins.Clear();
            WaypointInfoList.Clear();
        }
        public void AddWaypoint(MapPushpin generatedPushpin) {
            GeoPoint pushpinLocation = (GeoPoint)generatedPushpin.Location;
            LocationInformation info = generatedPushpin.Information as LocationInformation;
            string description = info != null ? info.DisplayName : string.Empty;
            GeoPoint location = pushpinLocation;
            RouteWaypoint waypoint = new RouteWaypoint(description, location);
            if(wayPoints.Contains(waypoint))
                return;

            wayPoints.Add(waypoint);
            WayPointInfo pointInfo = CreateWayPointInfo(pushpinLocation, Convert.ToString(info));
            WaypointInfoList.Add(pointInfo);
            GeneratedPushpins.Clear();
            RaiseWayPointChanged();
        }
        WayPointInfo CreateWayPointInfo(GeoPoint location, string info) {
            WayPointInfo pointInfo = new WayPointInfo();
            pointInfo.Type = (int)MapItemType.Pushpin;
            pointInfo.ToolTipPattern = info;
            pointInfo.Text = NextWaypointLetter();
            pointInfo.Latitude = location.Latitude;
            pointInfo.Longitude = location.Longitude;
            return pointInfo;
        }
        void RaiseWayPointChanged() {
            if(WayPointsChanged != null)
                WayPointsChanged(this, EventArgs.Empty);
        }
        protected string NextWaypointLetter() {
            byte bA = Convert.ToByte(Char.Parse("A"));
            string letter = string.Format("{0}", Convert.ToChar(bA + waypointIndex % 26));
            waypointIndex++;
            return letter;
        }
        protected virtual void Dispose(bool disposing) {
            if(disposed)
                return;
            if(disposing) {
                if(DriveModel != null)
                    DriveModel.Dispose();
            }
            disposed = true;
        }

        public void ProcessRouteItems(MapItem[] items) {
            GeneratedPushpins.Clear();
            WaypointInfoList.Clear();
            waypointIndex = 0;

            foreach(MapItem item in items) {
                MapPushpin pushpin = item as MapPushpin;
                if(pushpin != null) {
                    pushpin.Text = NextWaypointLetter();
                }
            }
        }
        public bool ProcessRouteResult(AzureRouteResult result) {
            if(result == null)
                return false;
            routePath.Clear();
            routeInstructions.Clear();
            foreach(AzureRouteLeg leg in result.Legs)
                routePath.AddRange(leg.Points);
            foreach (AzureRouteInstruction instruction in result.Guidance.Instructions)
                routeInstructions.Add(new RouteInstruction(instruction.Point, instruction.Message));
            return true;
        }

        public void DeleteWaypoint(int index) {
            if(index < 0 || index >= WayPoints.Count)
                return;
            WayPoints.RemoveAt(index);
            RaiseWayPointChanged();
        }
        public void StopDrive() {
            if(DriveModel != null) {
                DriveModel.Cleanup();
                DriveModel.Dispose();
                DriveModel = null;
            }
        }
        public void BeginDrive(MapControl map, InformationLayer routeLayer) {
            if((routePath != null) && (routePath.Count > 1)) {
                StopDrive();
                DriveModel = new DriveHelper(map, routeLayer, routePath, routeInstructions);
            }
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }

    public class DriveHelper : IDisposable {
        static readonly Bitmap driveMarker = new Bitmap(DemoUtils.GetRelativePath("\\Images\\Pin.png"));

        const double DriveSpeed = 100.0;
        const int DriveTicksPerSecond = 100;
        const double DriveTimeQuant = 1.0 / DriveTicksPerSecond;

        readonly Color DefaultDriveColor = Color.FromArgb(0xFF, 0xFE, 0x72, 0xFF);
        const int DefaultStrokeWidth = DirectionsNavigation.DefaultStrokeWidth;

        readonly MapItemCollection routeLayerItems;
        readonly InformationLayer routeLayer;
        readonly List<GeoPoint> routePath;
        readonly MapPolyline drivePath;
        readonly ObservableCollection<MapItem> driveItems;
        readonly MapCustomElement driveCustomElement;
        readonly Timer animationTimer;
        readonly List<RouteInstruction> routeInstructions;
        GeoPoint baseLocation = new GeoPoint();
        GeoPoint targetLocation = new GeoPoint();
        MapUnit basePoint;
        MapUnit targetPoint;
        double currentDistance;
        double distance;
        MapUnit currentPoint;
        int routeNodeIndex;
        string actionText;
        readonly MapControl map;
        bool disposed = false;
        double currentDirection;

        public GeoPoint CurrentLocation {
            get { return (GeoPoint)map.MapUnitToCoordPoint(currentPoint); }
        }
        public double CurrentDirection { get { return currentDirection; } }

        public string ActionText {
            get { return actionText; }
            set {
                actionText = value;
                if(ActionTextChanged != null)
                    ActionTextChanged(this, new PropertyChangedEventArgs("ActionText"));
            }
        }
        public Image DriveMarker { get { return driveMarker; } }

        public event PropertyChangedEventHandler CurrentLocationChanged;
        public event PropertyChangedEventHandler ActionTextChanged;

        static public double KilometerPerHourToMapUnitsPerSecond(double kmh) {
            return kmh / 40000.0 / 360.0;
        }
        static public double DistanceBetweenPoints(MapUnit a, MapUnit b) {
            MapUnit vector = new MapUnit(b.X - a.X, b.Y - a.Y);
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
        }

        public DriveHelper(MapControl map, InformationLayer routeLayer, List<GeoPoint> routePath, List<RouteInstruction> routeInstructions) {
            this.map = map;
            this.routeLayer = routeLayer;
            routeLayerItems = routeLayer.Data.Items;
            this.routePath = routePath;
            this.routeInstructions = new List<RouteInstruction>(routeInstructions);
            drivePath = new MapPolyline() { Stroke = DefaultDriveColor, StrokeWidth = DefaultStrokeWidth };
            drivePath.Points.Add(targetLocation);
            driveCustomElement = new MapCustomElement() { Location = routePath[0], Visible = true, Image = DriveMarker, UseAnimation = false, BackgroundDrawingMode = ElementState.None };
            animationTimer = new Timer();
            animationTimer.Interval = (int)(DriveTimeQuant * 1000);
            animationTimer.Tick += new EventHandler(OnTimerTick);
            baseLocation = targetLocation = routePath[0];
            currentPoint = basePoint = map.CoordPointToMapUnit(baseLocation);
            targetPoint = map.CoordPointToMapUnit(targetLocation);
            currentDistance = 0;
            distance = 0;
            routeNodeIndex = 0;
            driveItems = new ObservableCollection<MapItem>();
            driveItems.Add(drivePath);
            driveItems.Add(driveCustomElement);
            routeLayerItems.AddRange(driveItems);
            Advance();
        }

        bool Advance() {
            if(routeNodeIndex < (routePath.Count - 1)) {
                routeNodeIndex++;
                baseLocation = targetLocation;
                currentPoint = map.CoordPointToMapUnit(baseLocation);
                targetLocation = routePath[routeNodeIndex];
                basePoint = map.CoordPointToMapUnit(baseLocation);
                targetPoint = map.CoordPointToMapUnit(targetLocation);
                distance = DriveHelper.DistanceBetweenPoints(targetPoint, basePoint);
                currentDistance = 0;

                drivePath.Points[drivePath.Points.Count - 1] = baseLocation;
                drivePath.Points.Add(baseLocation);

                CheckItinerary();

                if(!animationTimer.Enabled)
                    animationTimer.Start();
                return true;
            }
            else {
                if(animationTimer.Enabled)
                    animationTimer.Stop();
                driveCustomElement.Visible = false;
                return false;
            }
        }
        void CheckItinerary() {
            GeoPoint location = (GeoPoint)map.MapUnitToCoordPoint(currentPoint);
            RouteInstruction currentItem = routeInstructions[0];
            MapSize geoSize = new MapSize(Math.Abs(location.Latitude - currentItem.Location.Latitude), Math.Abs(location.Longitude - currentItem.Location.Longitude));
            MapSize metricSize = map.CoordToMeasureUnitSize(location, geoSize);
            double distance = Math.Sqrt(metricSize.Width * metricSize.Width + metricSize.Height * metricSize.Height);
            if(distance < 0.005)
                if(routeInstructions.Count > 1)
                    routeInstructions.Remove(currentItem);
                else
                    distance = 0.0;
            if(distance > 0.0) {
                string distanceString = (distance > 0.9) ? String.Format("{0:0} km", Math.Ceiling(distance)) : String.Format("{0:0} m", Math.Ceiling(distance * 10) * 100);
                ActionText = $"{routeInstructions[0].Maneuver}\nafter {distanceString}";
            }
            else
                ActionText = "Finish! Click Stop and Clear to set a new route.";
        }
        void OnTimerTick(object sender, EventArgs e) {
            double scaledTime = DriveTimeQuant;
            while(scaledTime > 0.0) {
                double quant = Math.Min(scaledTime, DriveTimeQuant);
                double excess = Update(quant * DriveHelper.KilometerPerHourToMapUnitsPerSecond(DriveSpeed));
                if(excess > 0.0) {
                    if(!Advance()) {
                        CheckItinerary();
                        PlaceItems((GeoPoint)map.MapUnitToCoordPoint(currentPoint));
                        return;
                    }
                    excess = Update(excess);
                }
                PlaceItems((GeoPoint)map.MapUnitToCoordPoint(currentPoint));
                CheckItinerary();
                scaledTime -= quant;
            }
        }
        double CalculateNavAngle(double direction) {
            double angle = direction;
            const double delta = 2.0;
            if(Math.Abs(direction - currentDirection) > delta) {
                double a = (360.0 + direction - currentDirection) % 360;
                angle = currentDirection + (a > 180 ? -delta : delta);
            }
            angle = angle % 360;
            if(angle < 0)
                angle += 360;
            return angle;
        }
        double Update(double distanceToGo) {
            currentDistance += distanceToGo;
            if(currentDistance > distance) {
                currentPoint = targetPoint;
                return currentDistance - distance;
            }
            double direction = 0;
            MapUnit offset = GetDirection(out direction);
            offset.X *= currentDistance;
            offset.Y *= currentDistance;
            currentPoint = new MapUnit(basePoint.X + offset.X, basePoint.Y + offset.Y);
            currentDirection = CalculateNavAngle(direction);
            return 0.0;
        }
        MapUnit GetDirection(out double angle) {
            MapUnit direction = new MapUnit(targetPoint.X - basePoint.X, targetPoint.Y - basePoint.Y);
            double length = Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y);
            if(length > 0.0) {
                double oneByLength = 1 / length;
                direction.X *= oneByLength;
                direction.Y *= oneByLength;
            }
            angle = Math.Atan2(direction.Y, direction.X) * 180.0 / Math.PI;
            if(angle < 0.0)
                angle += 360.0;
            return direction;
        }
        void PlaceItems(GeoPoint location) {
            drivePath.Points[drivePath.Points.Count - 1] = location;
            driveCustomElement.Location = location;
            if(CurrentLocationChanged != null)
                CurrentLocationChanged(this, new PropertyChangedEventArgs("CurrentLocation"));
        }

        protected virtual void Dispose(bool disposing) {
            if(disposed)
                return;
            if(disposing) {
                if(animationTimer != null) {
                    animationTimer.Stop();
                    animationTimer.Tick -= new EventHandler(OnTimerTick);
                    animationTimer.Dispose();
                }
            }
            disposed = true;
        }

        public void Cleanup() {
            if(animationTimer.Enabled)
                animationTimer.Stop();
            drivePath.Points.Clear();
            driveCustomElement.Visible = false;
            foreach(MapItem item in driveItems)
                routeLayerItems.Remove(item);
            driveItems.Clear();
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    public class DirectionIcon : PictureEdit {
        float angle;
        bool clickTrigger;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float Angle { get { return angle; } set { angle = value; Invalidate(); } }

        protected override void OnPaint(PaintEventArgs e) {
            using(Matrix mat = new Matrix()) {
                mat.RotateAt(Angle - 45, new PointF(Width * 0.5f, Height * 0.5f));
                e.Graphics.Transform = mat;
                e.Graphics.Clear(CommonSkins.GetSkin(GetActiveLookAndFeel()).TranslateColor(BackColor));
                base.OnPaint(e);
            }
        }
        protected override void OnMouseClick(MouseEventArgs e) {
            clickTrigger = !clickTrigger;
            BackColor = clickTrigger ? Color.LightGray : Color.Empty;
            base.OnMouseClick(e);
        }
    }

    public class RouteInstruction {
        public GeoPoint Location { get; }
        public string Maneuver { get; }
        public RouteInstruction(GeoPoint location, string maneuver) {
            Location = location;
            Maneuver = maneuver;
        }
    }
}
