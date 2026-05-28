namespace DevExpress.DevAV.Presenters {
    using System;
    using System.Collections.Generic;
    using DevExpress.DevAV;
    using DevExpress.DevAV.ViewModels;
    using DevExpress.XtraMap;
    using DevExpress.Map.Dashboard;

    public abstract class RouteMapPresenter<TEntity, TViewModel> : BasePresenter<TViewModel>
        where TEntity : class
        where TViewModel : class, IRouteMapViewModel {
        MapControl mapControlCore;
        Action<TEntity> updateUIActionCore;
        Action<List<RoutePoint>> updateRouteListActionCore;
        public RouteMapPresenter(MapControl mapControl, TViewModel viewModel, Action<TEntity> updateUIAction, Action<List<RoutePoint>> updateRouteList)
            : base(viewModel) {
            this.mapControlCore = mapControl;
            this.updateUIActionCore = updateUIAction;
            this.updateRouteListActionCore = updateRouteList;
            if(MapControl != null) {
                BindMap();
                SubscribeRouteProviderEvents();
            }
            SubscribeViewModelEvents();
        }
        protected override void OnDisposing() {
            if(MapControl != null)
                UnsubscribeRouteProviderEvents();
            UnsubscribeViewModelEvents();
            this.updateUIActionCore = null;
            this.updateRouteListActionCore = null;
            this.mapControlCore = null;
            base.OnDisposing();
        }
        public MapControl MapControl {
            get { return mapControlCore; }
        }
        protected ImageLayer TilesLayer {
            get { return (ImageLayer)(MapControl.Layers[0]); }
        }
        protected InformationLayer GeoCodeLayer {
            get { return (InformationLayer)(MapControl.Layers[1]); }
        }
        protected InformationLayer RouteLayer {
            get { return (InformationLayer)(MapControl.Layers[3]); }
        }
        protected AzureMapDataProvider TilesProvider {
            get { return (AzureMapDataProvider)TilesLayer.DataProvider; }
        }
        protected AzureGeocodeDataProvider GeoCodeProvider {
            get { return (AzureGeocodeDataProvider)GeoCodeLayer.DataProvider; }
        }
        protected AzureRouteDataProvider RouteProvider {
            get { return (AzureRouteDataProvider)RouteLayer.DataProvider; }
        }
        IZoomToRegionService zoomService;
        void BindMap() {
            TilesProvider.AzureKey = MapViewModelBase.AzureKey;
            RouteProvider.AzureKey = MapViewModelBase.AzureKey;
            GeoCodeProvider.AzureKey = MapViewModelBase.AzureKey;
            
            this.zoomService = ((IServiceProvider)MapControl).GetService(typeof(IZoomToRegionService)) as IZoomToRegionService;
        }
        protected virtual void SubscribeRouteProviderEvents() {
            GeoCodeProvider.LocationInformationReceived += GeoCodeProvider_LocationInformationReceived;
            RouteProvider.RouteCalculated += RouteProvider_RouteCalculated;
            RouteProvider.LayerItemsGenerating += RouteProvider_LayerItemsGenerating;
        }
        protected virtual void SubscribeViewModelEvents() {
            ViewModel.UpdateRoute += ViewModel_UpdateRoute;
            ViewModel.PointAChanged += ViewModel_PointAChanged;
            ViewModel.PointBChanged += ViewModel_PointBChanged;
            ViewModel.TravelModeChanged += ViewModel_TravelModeChanged;
        }
        protected virtual void UnsubscribeRouteProviderEvents() {
            GeoCodeProvider.LocationInformationReceived -= GeoCodeProvider_LocationInformationReceived;
            RouteProvider.RouteCalculated -= RouteProvider_RouteCalculated;
            RouteProvider.LayerItemsGenerating -= RouteProvider_LayerItemsGenerating;
        }
        protected virtual void UnsubscribeViewModelEvents() {
            ViewModel.UpdateRoute -= ViewModel_UpdateRoute;
            ViewModel.PointAChanged -= ViewModel_PointAChanged;
            ViewModel.PointBChanged -= ViewModel_PointBChanged;
            ViewModel.TravelModeChanged -= ViewModel_TravelModeChanged;
        }
        void ViewModel_UpdateRoute(object sender, EventArgs e) {
            UpdateUI(GetViewModelEntity());
        }
        protected void ViewModel_EntityChanged(object sender, System.EventArgs e) {
            UpdateUI(GetViewModelEntity());
        }
        protected abstract TEntity GetViewModelEntity();
        void ViewModel_TravelModeChanged(object sender, System.EventArgs e) {
            UpdateRoute();
        }
        MapPushpin PointAPin { get; set; }
        void ViewModel_PointAChanged(object sender, System.EventArgs e) {
            if(PointAPin == null)
                PointAPin = new MapPushpin() { Text = "A" };
            SetLocation(PointAPin, ViewModel.PointA);
        }
        MapPushpin PointBPin { get; set; }
        void ViewModel_PointBChanged(object sender, System.EventArgs e) {
            if(PointBPin == null)
                PointBPin = new MapPushpin() { Text = "B" };
            SetLocation(PointBPin, ViewModel.PointB);
        }
        static void SetLocation(MapPushpin pin, Address address) {
            GeoPoint p = address.ToGeoPoint();
            pin.Visible = p != null;
            if(p != null)
                pin.Location = p;
        }
        void RouteProvider_RouteCalculated(object sender, AzureRouteCalculatedEventArgs e) {
            if(e.Error != null || e.Cancelled || e.CalculationResult == null || e.CalculationResult.ResultCode != RequestResultCode.Success)
                return;
            ProcessRouteResult(e.CalculationResult.RouteResults[0]);
        }
        void GeoCodeProvider_LocationInformationReceived(object sender, LocationInformationReceivedEventArgs e) {
            if(e.Error != null || e.Cancelled || e.Result == null || e.Result.ResultCode != RequestResultCode.Success)
                return;
            LocationInformation[] locations = e.Result.Locations;
            if(locations.Length > 0) {
                LocationInformation loc = locations[0];
                ViewModel.PointB = new Address() {
                    Line = loc.Address.FormattedAddress,
                    Latitude = loc.Location.Latitude,
                    Longitude = loc.Location.Longitude,
                };
            }
        }
        void RouteProvider_LayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs args) {
            var items = args.Items;
            for(int i = 0; i < items.Length; i++) {
                MapPushpin pushpin = items[i] as MapPushpin;
                if(pushpin != null)
                    pushpin.Visible = false;
            }
            AddRoutePoints();
        }
        void AddRoutePoints() {
            RouteLayer.Data.Items.Clear();
            RouteLayer.Data.Items.Add(PointAPin);
            RouteLayer.Data.Items.Add(PointBPin);
        }
        void ProcessRouteResult(AzureRouteResult routeResult) {
            const double metersInMile = 1609.344;
            ViewModel.RouteDistance = routeResult.Summary.TravelLengthMeters / metersInMile;
            ViewModel.RouteTime = TimeSpan.FromSeconds(routeResult.Summary.TravelTimeSeconds);
            List<RoutePoint> routePoints = new List<RoutePoint>();
            foreach(AzureRouteInstruction instruction in routeResult.Guidance.Instructions)
                routePoints.Add(new RoutePoint(instruction));
            UpdateRouteList(routePoints);
            zoomService.ZoomTo(ViewModel.PointA, ViewModel.PointB);
        }
        void UpdateRouteList(List<RoutePoint> routePoints) {
            if(updateRouteListActionCore != null)
                updateRouteListActionCore(routePoints);
        }
        void UpdateRoute() {
            List<RouteWaypoint> points = new List<RouteWaypoint>();
            points.Add(new RouteWaypoint("Point A", ViewModel.PointA.ToGeoPoint()));
            points.Add(new RouteWaypoint("Point B", ViewModel.PointB.ToGeoPoint()));
            AzureRouteOptions options = new AzureRouteOptions() {
                TravelMode = ViewModel.TravelMode,
                InstructionsType = AzureRouteInstructionsType.Text,
            };
            RouteProvider.CalculateRoute(points, options);
        }
        void UpdateUI(TEntity entity) {
            if(entity == null) return;
            if(updateUIActionCore != null)
                updateUIActionCore(entity);
            MapControl.CenterPoint = ViewModel.PointA.ToGeoPoint();
            AddRoutePoints();
            UpdateRoute();
        }
    }
    public sealed class RoutePoint {
        public string ManeuverInstruction { get; }
        public string Distance { get; }
        public AzureRouteGuidanceManeuver Maneuver { get; }
        public RoutePoint(AzureRouteInstruction instruction) {
            ManeuverInstruction = instruction.Message;
            const double metersInMile = 1609.344;
            double distanceMiles = instruction.RouteOffsetMeters / metersInMile;
            Distance = (distanceMiles > 0.9) ?
                String.Format("{0:0} mi", Math.Ceiling(distanceMiles)) :
                String.Format("{0:0} ft", Math.Ceiling(distanceMiles * 52.8) * 100);
            Maneuver = instruction.Maneuver;
        }
    }
}
