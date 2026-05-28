using System.Drawing;
using System.Linq;
using DevExpress.XtraSplashScreen;

namespace DevExpress.XtraMap.Demos {
    public partial class RouteIsochrones : FooteredMapTutorialControl {
        GeoPoint origin;

        protected override MapOverlay[] Overlays { get { return MapControl.Overlays.ToArray(); } }
        protected override Image CopyrightImage { get { return DemoUtils.AzureLogo; } }
        protected override string CopyrightText { get { return DemoUtils.AzureCopyright; } }
        public override MapControl MapControl { get { return mapControl1; } }

        public RouteIsochrones() {
            InitializeComponent();
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider);
            DemoUtils.SetAzureMapDataProviderKey(SearchProvider);
            DemoUtils.SetAzureMapDataProviderKey(GeoCodeProvider);
            DemoUtils.SetAzureMapDataProviderKey(RouteIsochroneProvider);

            origin = new GeoPoint(42.3589935302734, -71.0586318969727);
            GeoCodeProvider.RequestLocationInformation(origin);
            radioGroup1.SelectedIndex = 0;
        }
        void ParametersChanged(object sender, System.EventArgs e) {
            UpdateAndCalculateIsochrone();
        }
        void UpdateAndCalculateIsochrone() {
            RouteIsochroneLayer.ClearResults();
            AzureRouteIsochroneOptions options = new AzureRouteIsochroneOptions();
            layoutControlGroup2.Text = radioGroup1.Properties.Items[radioGroup1.SelectedIndex].Description;
            if(radioGroup1.SelectedIndex == 0) {
                double timeSeconds = trackBarControl1.Value * 60;
                RouteIsochroneProvider.CalculateIsochroneByTime(new RouteWaypoint("", origin), timeSeconds, options);
            }
            else {
                const double metersInMile = 1609.344;
                double distanceMeters = radioGroup1.SelectedIndex == 1 ? trackBarControl1.Value * 1000 : trackBarControl1.Value * metersInMile;
                RouteIsochroneProvider.CalculateIsochroneByDistance(new RouteWaypoint("", origin), distanceMeters, options);
            }
            SplashScreenManager.ShowDefaultWaitForm(ParentForm, false, false, "", "Calculating the isochrone in process...");
        }
        void OnGeoCodeLocationInformationReceived(object sender, LocationInformationReceivedEventArgs args) {
            LocationInformation location = args.Result.Locations.FirstOrDefault();
            if(location != null && !origin.Equals(location.Location)) {
                origin = location.Location;
                UpdateAndCalculateIsochrone();
            }
        }
        void IsochroneItemsGenerating(object sender, LayerItemsGeneratingEventArgs e) {
            if(SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
                SplashScreenManager.CloseDefaultWaitForm();
            GeocodeLayer.ClearResults();
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            ChkShowMinimap.Enabled = false;
        }
        protected override void DoHide() {
            base.DoHide();
            GeoCodeProvider.RequestLocationInformation(null);
        }
    }
}
