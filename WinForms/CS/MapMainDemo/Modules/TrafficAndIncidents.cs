using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Map;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraMap.Demos {
    public partial class TrafficAndIncidents : FooteredMapTutorialControl {
        readonly List<WayPointInfo> wayPointsInfoList = new List<WayPointInfo>();
        readonly List<MapPushpin> generatedPushpins = new List<MapPushpin>();
        readonly List<RouteWaypoint> routeWaypoints = new List<RouteWaypoint>();
        readonly Timer trafficIncidentTimer = new Timer();
        readonly Timer routePropertiesTimer = new Timer();
        MapOverlayTextItem overlayTextItem;
        MapOverlay[] mapOverlays;
        MapBounds viewport;

        protected override MapOverlay[] Overlays => mapOverlays;
        protected MapItemCollection RouteLayerItems => RouteLayer.Data.Items;
        protected override Image CopyrightImage => DemoUtils.AzureLogo;
        protected override string CopyrightText => DemoUtils.AzureCopyright;
        public override MapControl MapControl => mapControl;

        public TrafficAndIncidents() {
            InitializeComponent();
            InitializeMapOverlay();
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider);
            DemoUtils.SetAzureMapDataProviderKey(SearchProvider);
            DemoUtils.SetAzureMapDataProviderKey(GeoCodeProvider);
            DemoUtils.SetAzureMapDataProviderKey(RouteProvider);
            DemoUtils.SetAzureMapDataProviderKey(TrafficIncidentProvider);

            DataAdapter.DataSource = new List<WayPointInfo>(wayPointsInfoList);
            routeWaypoints.Add(new RouteWaypoint("A", new GeoPoint(39.025538, -77.203833)));
            routeWaypoints.Add(new RouteWaypoint("B", new GeoPoint(38.960899, -76.98296)));
            routeWaypoints.Add(new RouteWaypoint("C", new GeoPoint(38.905435, -77.127861)));
            routeWaypoints.Add(new RouteWaypoint("D", new GeoPoint(38.8501856, -76.9276787)));

            trafficIncidentTimer.Interval = 2500;
            trafficIncidentTimer.Tick += (s, e) => UpdateTrafficIncidentData();
            routePropertiesTimer.Interval = 500;
            routePropertiesTimer.Tick += (s, e) => CalculateRoute();

            TravelModeRadioGroup.Properties.Items.AddEnum(typeof(AzureTravelMode));
            TravelModeRadioGroup.SelectedIndex = 2;
            RouteAvoidTypesComboBoxEdit.Properties.SetFlags(typeof(AzureRouteAvoidType));
            ChangeComboBoxEditDescriptions(RouteAvoidTypesComboBoxEdit);
            RouteSectionTypesComboBoxEdit.Properties.SetFlags(typeof(AzureRouteSectionType));
            ChangeComboBoxEditDescriptions(RouteSectionTypesComboBoxEdit);

            CalculateRoute();
        }

        void OnRouteLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs args) {
            if(args.Error == null && !args.Cancelled)
                ProcessRouteItems(args.Items);
        }
        void OnRouteCalculated(object sender, AzureRouteCalculatedEventArgs e) {
            if(e.CalculationResult != null)
                DataAdapter.DataSource = null;
        }
        void OnGeoCodeAndSearchLayerItemsGenerating(object sender, LayerItemsGeneratingEventArgs args) {
            foreach(MapItem item in args.Items)
                if(item is MapPushpin && !generatedPushpins.Contains((MapPushpin)item))
                    generatedPushpins.Add((MapPushpin)item);
        }
        void OnMapItemClick(object sender, MapItemClickEventArgs e) {
            if(e.MouseArgs.Button == MouseButtons.Left) {
                ChoosePushpin(e.Item as MapPushpin);
                e.Handled = true;
            }
        }
        void OnInformationLayerViewportChanged(object sender, ViewportChangedEventArgs e) {
            viewport = new MapBounds(e.TopLeft, e.BottomRight);
            trafficIncidentTimer.Stop();
            trafficIncidentTimer.Start();
        }
        void OnRouteLayerError(object sender, MapErrorEventArgs e) {
            string message = e.Exception.Message;
            const string startPattern = "\"message\":\"";
            int startIndex = message.IndexOf(startPattern);
            if(startIndex < 0)
                return;
            message = message.Substring(startIndex + startPattern.Length);
            message = message.Substring(0, message.IndexOf("\""));

            overlayTextItem.Text = message;
            mapOverlays[0].Visible = true;
        }
        void ChangeComboBoxEditDescriptions(CheckedComboBoxEdit boxEdit) {
            foreach(CheckedListBoxItem item in boxEdit.Properties.Items) {
                string description = item.Description;
                for(int i = description.Length - 1; i > 0; --i) {
                    if(char.IsUpper(description[i]))
                        description = description.Insert(i, " ");
                }
                item.Description = description;
            }
        }
        void OnRoutePropertyChanged(object sender, EventArgs e) {
            routePropertiesTimer.Stop();
            routePropertiesTimer.Start();
        }
        void InitializeMapOverlay() {
            MapOverlay overlay = new MapOverlay();
            overlayTextItem = new MapOverlayTextItem() {
                Padding = new Padding(15, 10, 15, 10),
            };
            overlayTextItem.TextStyle.TextColor = Color.Red;
            overlay = new MapOverlay() {
                Alignment = ContentAlignment.BottomRight,
                Margin = new Padding(8, 8, 8, 8),
            };
            overlay.Items.Add(overlayTextItem);
            mapOverlays = new MapOverlay[] { overlay };
            mapOverlays[0].Visible = false;
        }
        void ChoosePushpin(MapPushpin generatedPushpin) {
            if(generatedPushpins.Contains(generatedPushpin)) {
                GeoPoint pushpinLocation = (GeoPoint)generatedPushpin.Location;
                LocationInformation info = generatedPushpin.Information as LocationInformation;
                string description = string.Empty;
                if(info != null)
                    description = info.DisplayName;
                if(routeWaypoints.Count == 4)
                    routeWaypoints.Clear();
                char pinLetter = Convert.ToChar(Convert.ToInt32('A') + routeWaypoints.Count);
                string name = new string(pinLetter, 1);
                routeWaypoints.Add(new RouteWaypoint(description, pushpinLocation));
                wayPointsInfoList.Add(new WayPointInfo() {
                    Type = (int)MapItemType.Pushpin,
                    ToolTipPattern = Convert.ToString(info),
                    Text = name,
                    Latitude = pushpinLocation.Latitude,
                    Longitude = pushpinLocation.Longitude
                });
                generatedPushpins.Clear();
                GeocodeLayer.ClearResults();
                RouteLayer.ClearResults();
                DataAdapter.DataSource = new List<WayPointInfo>(wayPointsInfoList);
                CalculateRoute();
            }
        }
        void CalculateRoute() {
            mapOverlays[0].Visible = false;
            routePropertiesTimer.Stop();
            if(routeWaypoints.Count == 4) {
                AzureRouteOptions options = new AzureRouteOptions() {
                    TravelMode = (AzureTravelMode)TravelModeRadioGroup.EditValue,
                    AvoidTypes = (AzureRouteAvoidType)RouteAvoidTypesComboBoxEdit.EditValue,
                    SectionTypes = (AzureRouteSectionType)RouteSectionTypesComboBoxEdit.EditValue,
                    MaxAlternatives = decimal.ToInt32((decimal)MaxAlternativedSpinEdit.EditValue),
                    OptimizeWaypoints = (bool)OptimizeWaypointsCheckEdit.EditValue,
                };
                RouteProvider.CalculateRoute(routeWaypoints, options);
            }
        }
        void ProcessRouteItems(MapItem[] items) {
            generatedPushpins.Clear();
            wayPointsInfoList.Clear();
            int i = 0;
            foreach(MapItem item in items) {
                MapPushpin pushpin = item as MapPushpin;
                if(pushpin != null) {
                    char pinLetter = Convert.ToChar(Convert.ToInt32('A') + i++);
                    pushpin.Text = new string(pinLetter, 1);
                }
            }
        }
        void UpdateTrafficIncidentData() {
            trafficIncidentTimer.Stop();
            TrafficIncidentLayer.ClearResults();
            SearchBoundingBox bbox = new SearchBoundingBox(viewport.Left, viewport.Top, viewport.Right, viewport.Bottom);
            AzureTrafficIncidentOptions options = new AzureTrafficIncidentOptions();
            TrafficIncidentProvider.RequestTrafficIncidents(bbox, (int)mapControl.ZoomLevel, -1, options);
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            ChkShowMinimap.Enabled = false;
        }
    }
}
