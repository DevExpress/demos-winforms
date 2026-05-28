using System;
using System.Data;
using System.Drawing;
using System.Linq;
using DevExpress.Map;
using DevExpress.XtraCharts;

namespace DevExpress.XtraMap.Demos {
    public partial class GpxDataAdapterDemo : FooteredMapTutorialControl {
        const int PointStrokeWidth = 2;
        readonly Color TrackColor = Color.FromArgb(30, 140, 210);

        MapDot highlightedDot;
        protected override Image CopyrightImage { get { return DemoUtils.AzureLogo; } }
        protected override string CopyrightText { get { return DemoUtils.AzureCopyright; } }
        public override MapControl MapControl { get { return mapControl1; } }
        protected override MapOverlay[] Overlays { get { return MapControl.Overlays.ToArray(); } }
        public override bool UseEmptyRootPadding { get { return false; } }

        public GpxDataAdapterDemo() {
            InitializeComponent();
            chartControl1.DataSource = gpxFileDataAdapter1;
            gridLookUpEdit1.CustomDisplayText += OnGridLookUpCustomDisplayText;
            FillActivities();
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider);
        }

        void FillActivities() {
            DataSet xmlDataSet = new DataSet("XML DataSet");
            xmlDataSet.ReadXml(DemoUtils.GetRelativePath("Gpx\\Activities.xml"));
            DataTable activities = xmlDataSet.Tables["Activity"];
            activities.Columns["Data"].ColumnMapping = MappingType.Hidden;
            gridLookUpEdit1.Properties.DataSource = activities;
            gridLookUpEdit1.EditValue = activities.DefaultView[0];
        }
        void VectorItemsLayer1_DataLoaded(object sender, DataLoadedEventArgs e) {
            PopulateMapLayer();
            PopulateParams();
            RestoreInitialView();
            ((XYDiagram)chartControl1.Diagram).AxisX.WholeRange.Auto = true;
            ((XYDiagram)chartControl1.Diagram).AxisX.VisualRange.Auto = true;
            chartControl1.EndInit();
        }
        void PopulateParams() {
            GpxTrackInfo info = TrackInfoHelper.CalculateTrackInfo(gpxFileDataAdapter1);
            htmlContentControl1.DataContext = info;
            bool isTrackHasHeartRate = info.AverageHeartRate != 0;
            chartControl1.Series[1].Visible = isTrackHasHeartRate;
            htmlContentControl1.HtmlTemplate.Template = TrackInfoHelper.GenerateTrackTemplate(isTrackHasHeartRate);
            htmlContentControl1.MaximumSize = htmlContentControl1.GetContentSize();
        }
        void PopulateMapLayer() {
            MapPathSegment pathSegment = ((MapPath)GpxDataLayer.Data.Items.First()).Segments[0];
            CoordPoint startPosition = pathSegment.Points[0];
            CoordPoint endPosition = pathSegment.Points.Last();
            MapDot startPoint = new MapDot() { Location = startPosition, Stroke = Color.White, StrokeWidth = PointStrokeWidth, Fill = TrackColor, Size = DemoUtils.DipToPixels(16) };
            MapDot finishPoint = new MapDot() { Location = endPosition, Stroke = Color.White, StrokeWidth = PointStrokeWidth, Fill = TrackColor, Size = DemoUtils.DipToPixels(16) };
            highlightedDot = new MapDot() { Fill = TrackColor, Stroke = Color.White, StrokeWidth = PointStrokeWidth, Visible = false, Size = DemoUtils.DipToPixels(10) };

            startPoint.TitleOptions.Pattern = "A";
            startPoint.TitleOptions.TextColor = Color.White;
            startPoint.TitleOptions.TextGlowColor = Color.Transparent;
            startPoint.TitleOptions.Visibility = VisibilityMode.Visible;
            finishPoint.TitleOptions.Pattern = "B";
            finishPoint.TitleOptions.TextColor = Color.White;
            finishPoint.TitleOptions.TextGlowColor = Color.Transparent;
            finishPoint.TitleOptions.Visibility = VisibilityMode.Visible;

            mapItemStorage1.Items.AddRange(new MapItem[] { startPoint, finishPoint, highlightedDot });
        }
        void ChartControl1_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e) {
            if(e.CrosshairElementGroups.Count > 0) {
                DataRowView sourceItem = (DataRowView)e.CrosshairElementGroups[0].CrosshairElements[0].SeriesPoint.Tag;
                highlightedDot.Location = new GeoPoint((double)sourceItem["lat"], (double)sourceItem["lon"]);
            }
        }
        void OnGridLookUpCustomDisplayText(object sender, XtraEditors.Controls.CustomDisplayTextEventArgs e) {
            DataRowView rowView = e.Value as DataRowView;
            if(rowView != null)
                e.DisplayText = string.Format("{0:D} - {1}", rowView["Date"], rowView["Title"]);
        }
        void OnGridLookUpEditValueChanged(object sender, EventArgs e) {
            chartControl1.BeginInit();
            mapItemStorage1.Items.Clear();
            string uriStr = string.Format("Gpx\\{0}.gpx", ((DataRowView)gridLookUpEdit1.EditValue)["Data"]);
            gpxFileDataAdapter1.FileUri = DemoUtils.GetFileUri(uriStr);
        }
        void ChartControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            highlightedDot.Visible = chartControl1.CalcHitInfo(new Point(e.X, e.Y)).InDiagram;
        }
        protected override void RestoreInitialView() {
            MapControl.Measurements.RemoveRulers();
            MapControl.ZoomToFitLayerItems(new LayerBase[] { GpxDataLayer });
        }
        void mapControl1_OverlaysArranged(object sender, OverlaysArrangedEventArgs e) {
            Rectangle rulerRect = e.OverlayArrangements[0].OverlayLayout;
            e.OverlayArrangements[0].OverlayLayout = new Rectangle(new Point(gridLookUpEdit1.Left, MapControl.ClientSize.Height - rulerRect.Height - DemoUtils.DipToPixels(14)), rulerRect.Size);
        }
    }

    public class GpxTrackInfo {
        public TimeSpan Duration { get; set; }
        public double Distance { get; set; }
        public int AverageHeartRate { get; set; }
        public int MinHeartRate { get; set; }
        public int MaxHeartRate { get; set; }
        public string AveragePace { get; set; }
        public string MaxPace { get; set; }
    }
}
