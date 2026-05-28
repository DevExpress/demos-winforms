using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using DevExpress.Utils.Svg;

namespace DevExpress.XtraMap.Demos {
    public partial class ClusterCustomization : MapTutorialControl {

        public override MapControl MapControl { get { return mapControl1; } }
        protected override MapOverlay[] Overlays { get { return MapControl.Overlays.ToArray(); } }

        public ClusterCustomization() {
            InitializeComponent();
            ShapefileAdapter.FileUri = DemoUtils.GetFileUri("Countries.shp");
            ItemsClusterer.SetClusterItemFactory(new ClusterFactory(svgImageCollection1));
            ItemsDataAdapter.SetMapItemFactory(new ItemFactory(svgImageCollection1));
            ItemsDataAdapter.DataSource = LoadData();
        }

        List<EducationItem> LoadData() {
            List<EducationItem> items = new List<EducationItem>();
            string[] lines = File.ReadAllLines(DemoUtils.GetRelativePath("UniData.csv"));
            for(int i = 1; i < lines.Length; i++)
                items.Add(EducationItem.FromCsvLine(lines[i], ';'));
            return items;
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            DisableZoomOptions();
            ChkShowMinimap.Enabled = false;
        }
    }

    public class ClusterFactory : DefaultClusterItemFactory {
        readonly SvgImage image;

        public ClusterFactory(Utils.SvgImageCollection svgImageCollection1) {
            image = svgImageCollection1[0];
        }
        protected override MapItem CreateItemInstance(IList<MapItem> objects) {
            int dX = DemoUtils.DipToPixels(15);
            int dY = DemoUtils.DipToPixels(20);
            return new MapPushpin() { SvgImage = image, SvgImageSize = new Size(32, 32), TextOrigin = (new Point(dX, dY)) };
        }
    }

    public class ItemFactory : DefaultMapItemFactory {
        readonly SvgImage image;

        public ItemFactory(Utils.SvgImageCollection svgImageCollection1) {
            image = svgImageCollection1[0];
        }
        protected override void InitializeItem(MapItem item, object obj) {
            base.InitializeItem(item, obj);
            MapPushpin pin = item as MapPushpin;
            if(pin != null) {
                pin.SvgImage = image;
                pin.SvgImageSize = new Size(20, 20);
            }
            item.ToolTipPattern = "{Name}" + Environment.NewLine + Environment.NewLine + "State: {State}" + Environment.NewLine + "City: {City}" + Environment.NewLine + "Web site: {Site}";
        }
    }

    public struct EducationItem {
        public string Name { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string InfoUri { get; set; }
        public string SiteUri { get; set; }

        public double Lat { get; set; }
        public double Lon { get; set; }

        public static EducationItem FromCsvLine(string sourceStr, char separator) {
            string[] columns = sourceStr.Split(separator);
            if(columns.Length < 7)
                throw new Exception("Line format error");
            double lat = Convert.ToDouble(columns[3], CultureInfo.InvariantCulture);
            double lon = Convert.ToDouble(columns[4], CultureInfo.InvariantCulture);
            return new EducationItem() { Name = columns[0], State = columns[1], City = columns[2], Lat = lat, Lon = lon, InfoUri = columns[5], SiteUri = columns[6] };
        }
    }
}
