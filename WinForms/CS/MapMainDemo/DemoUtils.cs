using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.Data.Utils;
using DevExpress.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.Map;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraMap.Demos {
    public class DemoUtils {
        const string azureKey = "CDOhtwNBSsbmBiN3rUEjmBJGHW2tRMbp5XVwu4J55VBZg8PdRe9MJQQJ99BEACYeBjFllM6LAAAgAZMP1cA4";
        const string testKey = "TestKey";
        //
        public static string AzureKey {
            get { return DemoHelper.IsTesting ? testKey : azureKey; }
        }
        public static Image AzureLogo {
            get { return new Bitmap(GetRelativePath("Images\\AzureMapLogo.png")); }
        }
        public static string AzureCopyright {
            get { return "Copyright © " + DateTime.Now.Year + " Microsoft and its suppliers. All rights reserved."; }
        }
        public static string OsmCopyright {
            get { return "© OpenStreetMap contributors"; }
        }
        //
        public static XDocument LoadXml(string name) {
            try {
                return SafeXml.CreateXDocument(File.ReadAllText(GetRelativePath(name)));
            }
            catch { return null; }
        }
        internal static void SetAzureMapDataProviderKey(AzureMapDataProvider provider) {
            if(provider != null) provider.AzureKey = AzureKey;
        }
        internal static void SetAzureMapDataProviderKey(AzureMapDataProviderBase provider) {
            if(provider != null) provider.AzureKey = AzureKey;
        }
        public static Uri GetFileUri(string fileName) {
            return new Uri("file:\\\\" + GetRelativePath(fileName), UriKind.RelativeOrAbsolute);
        }
        public static string GetRelativePath(string name) {
            name = "Data\\" + name;
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            while(dir != null) {
                string filePath = Path.Combine(dir.FullName, name);
                if(File.Exists(filePath))
                    return filePath;
                dir = Directory.GetParent(dir.FullName);
            }
            return string.Empty;
        }
        public static string GetRelativeDirectoryPath(string name) {
            name = "Data\\" + name;
            DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);
            while(dir != null) {
                string directoryPath = Path.Combine(dir.FullName, name);
                if(Directory.Exists(directoryPath))
                    return directoryPath;
                dir = Directory.GetParent(dir.FullName);
            }
            return string.Empty;
        }
        public static Image GetBackGroundImage(MapControl map, Rectangle galleryRect, float opacity) {
            using(MemoryStream stream = new MemoryStream()) {
                try {
                    map.ExportToImage(stream, DXImageFormat.Png);
                    using(Image image = Image.FromStream(stream)) {
                        Bitmap result = new Bitmap(galleryRect.Width, galleryRect.Height);
                        using(Graphics g = Graphics.FromImage(result)) {
                            ColorMatrix matrix = new ColorMatrix() { Matrix33 = opacity };
                            ImageAttributes attributes = new ImageAttributes();
                            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                            g.DrawImage(image, new Rectangle(0, 0, result.Width, result.Height), galleryRect.X, galleryRect.Y, galleryRect.Width, galleryRect.Height, GraphicsUnit.Pixel, attributes);
                        }
                        return result;
                    }
                }
                catch { return null; }
            }
        }
        public static Image GetInflatedImage(string imageUri, int inflateX, int inflateY) {
            using(Image image = Image.FromFile(imageUri)) {
                Rectangle rect = new Rectangle(new Point(0, 0), image.Size);
                rect.Inflate(inflateX, inflateY);
                Bitmap result = new Bitmap(rect.Width, rect.Height);
                using(Graphics g = Graphics.FromImage(result)) {
                    g.FillRectangle(Brushes.White, new Rectangle(0, 0, result.Width, result.Height));
                    g.DrawImage(image, new Rectangle(inflateX, inflateY, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
                    return result;
                }
            }
        }
        public static object[] GetOSMBaseLayers() {
            List<object> result = new List<object> {
                OpenStreetMapKind.Basic,
                OpenStreetMapKind.CycleMap,
                OpenStreetMapKind.Hot,
                OpenStreetMapKind.Transport
            };
            return result.ToArray();
        }
        public static object[] GetOSMOverlays() {
            List<object> result = new List<object> {
                "None",
                OpenStreetMapKind.SeaMarks,
                OpenStreetMapKind.HikingRoutes,
                OpenStreetMapKind.CyclingRoutes,
                OpenStreetMapKind.PublicTransport
            };
            return result.ToArray();
        }
        public static Dictionary<String, Image> CreateFlagsDictionary() {
            Dictionary<String, Image> flags = new Dictionary<string, Image>();
            string path = DemoUtils.GetRelativeDirectoryPath("\\Images\\Flags");
            string[] fileEntries = string.IsNullOrEmpty(path)
                ? new string[0]
                : Directory.GetFiles(path).Where(entry => entry.EndsWith(".png")).ToArray();
            foreach(string fileName in fileEntries) {
                string key = fileName.Substring(fileName.LastIndexOf(@"\") + 1).Remove(2, 4);
                flags.Add(key, Image.FromFile(fileName));
            }
            return flags;
        }
        public static Image GetCountryFlag(Dictionary<string, Image> flagsCache, string countryName) {
#pragma warning disable DX0025 // no path traversal
            string countryFileName = countryName.Replace(' ', '_') + ".png";
#pragma warning restore DX0025
            string flagPath = Path.Combine(GetRelativeDirectoryPath(@"Images\Flags\Big"), countryFileName);
            Image flagImage = null;
            if(!flagsCache.TryGetValue(countryName, out flagImage)) {
                flagImage = Image.FromFile(flagPath);
                flagsCache.Add(countryName, flagImage);
            }
            return flagImage;
        }
        static readonly Dictionary<string, Image> images = new Dictionary<string, Image>();
        public static Image GetAreaImage(int fontSize) {
            string key = string.Format("Area {0}", fontSize);
            Image image = null;
            if(!images.TryGetValue(key, out image)) {
                image = CreateAreaImage(fontSize);
                images[key] = image;
            }
            return image;
        }
        public static Image GetPerimeterImage(int fontSize) {
            string key = string.Format("Perimeter {0}", fontSize);
            Image image = null;
            if(!images.TryGetValue(key, out image)) {
                image = CreatePerimeterImage(fontSize);
                images[key] = image;
            }
            return image;
        }
        public static Image GetDiameterImage(int fontSize) {
            string key = string.Format("Diameter {0}", fontSize);
            Image image = null;
            if(!images.TryGetValue(key, out image)) {
                image = CreateDiameterImage(fontSize);
                images[key] = image;
            }
            return image;
        }
        static Image CreateDiameterImage(int fontSize) {
            Bitmap perimeterImage = new Bitmap(fontSize, fontSize);
            int halfSize = (int)(fontSize / 2.0);
            using(Graphics gr = Graphics.FromImage(perimeterImage)) {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.DrawEllipse(Pens.Black, new Rectangle(0, fontSize / 4, halfSize, halfSize));
                gr.DrawLine(Pens.DarkGray, 0, halfSize, halfSize, halfSize);
            }
            return perimeterImage;
        }
        static Image CreatePerimeterImage(int fontSize) {
            Bitmap perimeterImage = new Bitmap(fontSize, fontSize);
            using(Graphics gr = Graphics.FromImage(perimeterImage)) {
                gr.Clear(Color.Transparent);
                gr.DrawRectangle(Pens.Black, new Rectangle(0, fontSize / 4, fontSize / 2, fontSize / 2));
            }
            return perimeterImage;
        }
        static Image CreateAreaImage(int fontSize) {
            Bitmap areaImage = new Bitmap(fontSize, fontSize);
            using(Graphics gr = Graphics.FromImage(areaImage)) {
                gr.Clear(Color.Transparent);
                gr.FillRectangle(new SolidBrush(Color.FromArgb(80, 0, 0, 0)), new RectangleF(0, fontSize / 4, fontSize / 2, fontSize / 2));
            }
            return areaImage;
        }
        public static int DipToPixels(int value) {
            return (int)(value * DpiProvider.Default.DpiScaleFactor);
        }
        public static Image ScaleImage(Image source, Utils.DPI.ScaleHelper scaleHelper) {
            Size sourceSize = source.Size;
            Size deviceImageSize = scaleHelper.ScaleSize(sourceSize);
            if(sourceSize == deviceImageSize)
                return source;
            Bitmap bitmap = new Bitmap(deviceImageSize.Width, deviceImageSize.Height, PixelFormat.Format24bppRgb);
            using(Graphics graphics = Graphics.FromImage(bitmap)) {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                RectangleF srcRect = new RectangleF(0f, 0f, source.Size.Width, source.Size.Height);
                RectangleF destRect = new RectangleF(0f, 0f, deviceImageSize.Width, deviceImageSize.Height);
                srcRect.Offset(-0.5f, -0.5f);
                graphics.DrawImage(source, destRect, srcRect, GraphicsUnit.Pixel);
            }
            return bitmap;
        }
    }
    public class InvariantImageRepositoryItem : RepositoryItemCheckEdit {
        protected override Image TransformPicture(Image image) {
            return image;
        }
    }
    public class HotelRoomTooltipHelper {
        readonly SuperToolTip superToolTip = new SuperToolTip();
        readonly HotelImagesGenerator imageGenerator = new HotelImagesGenerator();
        readonly ToolTipTitleItem titleItem = new ToolTipTitleItem();
        readonly ToolTipItem contentItem = new ToolTipItem() { ImageToTextDistance = 0 };
        public HotelRoomTooltipHelper() {
            superToolTip.Items.Add(titleItem);
            superToolTip.Items.Add(contentItem);
        }
        string CalculateTitle(int category, string tooltip) {
            return category == 4 ? string.Format("Room: {0}", tooltip) : tooltip;
        }
        public SuperToolTip CalculateSuperTooltip(MapItem item, string tooltip) {
            if(item == null)
                return null;
            MapItemAttribute attr = item.Attributes["CATEGORY"];
            if(attr == null)
                return null;
            titleItem.Text = CalculateTitle((int)attr.Value, tooltip);
            attr = item.Attributes["IMAGE"];
            if(superToolTip.Items.Count == 1)
                superToolTip.Items.Add(contentItem);
            Image result = attr != null ? (Image)attr.Value : imageGenerator.GetItemImage(item);
            if(result != null)
                contentItem.Image = result;
            else
                superToolTip.Items.RemoveAt(1);
            return superToolTip;
        }
        public void UpdateHotelIndex(int index) {
            imageGenerator.HotelIndex = index;
        }
    }
    public class HotelImagesGenerator {
        class PathsIndexPair {
            public string[] Paths { get; set; }
            public int Index { get; set; }
        }
        const int ImageWidth = 200;
        static readonly string[] Categories = new string[] {
            "Restaurant", "MeetingRoom", "Bathroom", "Bedroom", "OutOfDoors", "ServiceRoom", "Pool", "Lobby"
        };
        int hotelIndex = 0;
        readonly List<PathsIndexPair> filesWithIndices = new List<PathsIndexPair>();
        public int HotelIndex {
            get { return hotelIndex; }
            set {
                hotelIndex = value;
                UpdateIndices();
            }
        }
        public HotelImagesGenerator() {
            foreach(string category in Categories)
                filesWithIndices.Add(new PathsIndexPair() { Index = 0, Paths = GetAvailableFiles(category) });
        }
        void UpdateIndices() {
            filesWithIndices[0].Index = hotelIndex * 2;
            filesWithIndices[1].Index = 0;
            filesWithIndices[2].Index = hotelIndex * 4;
            filesWithIndices[6].Index = hotelIndex;
        }
        string[] GetAvailableFiles(string category) {
            string path = DemoUtils.GetRelativeDirectoryPath("\\Images\\Hotels\\");
            return Directory.GetFiles(path).Where(p => p.StartsWith(path + category)).ToArray();
        }
        Image GetImage(int category, int roomCat) {
            if(category == 4)
                filesWithIndices[3].Index = roomCat;
            return GetCategoryImage(filesWithIndices[category - 1]);
        }
        Image GetCategoryImage(PathsIndexPair pathsWithIndex) {
            if(pathsWithIndex.Paths.Length == 0)
                return null;
            int index = pathsWithIndex.Index % pathsWithIndex.Paths.Length;
            pathsWithIndex.Index++;
            return new Bitmap(pathsWithIndex.Paths[index]);
        }
        Image ScaleImage(Image srcImg) {
            double ratio = (double)srcImg.Width / srcImg.Height;
            int newHeight = (int)(ImageWidth / ratio);
            Image resImg = new Bitmap(ImageWidth, newHeight);
            Graphics.FromImage(resImg).DrawImage(srcImg, 0, 0, ImageWidth, newHeight);
            return resImg;
        }
        public Image GetItemImage(MapItem item) {
            Image image = GetImage((int)item.Attributes["CATEGORY"].Value, (int)item.Attributes["ROOMCAT"].Value);
            if(image == null)
                return null;
            image = ScaleImage(image);
            item.Attributes.Add(new MapItemAttribute() { Name = "IMAGE", Value = image });
            return image;
        }
    }
    public static class ColorHelper {
        public static void UpdateColor(Image image, UserLookAndFeel lookAndFeel) {
            Color foreColor = GetForeColor(lookAndFeel);
            SetColor((Bitmap)image, foreColor);
        }
        public static Color GetForeColor(UserLookAndFeel lookAndFeel) {
            Color ret = SystemColors.ControlText;
            if(lookAndFeel.ActiveStyle != ActiveLookAndFeelStyle.Skin) return ret;
            return MapSkins.GetSkin(lookAndFeel).Properties.GetColor(MapSkins.PropPanelTextColor);
        }
        static void SetColor(Bitmap bmp, Color color) {
            for(int i = 0; i < bmp.Width; i++)
                for(int j = 0; j < bmp.Height; j++)
                    if(bmp.GetPixel(i, j).A > 0)
                        bmp.SetPixel(i, j, color);
        }
    }
    public class FlagsRepository {
        readonly Dictionary<string, Image> gridImages = new Dictionary<string, Image>();
        readonly Dictionary<string, Image> calloutImages = new Dictionary<string, Image>();
        public FlagsRepository() {
            calloutImages = DemoUtils.CreateFlagsDictionary();
            gridImages = DemoUtils.CreateFlagsDictionary();
        }
        public Image GetFlag(string country, bool forCallout) {
            return forCallout ? calloutImages[country] : gridImages[country];
        }
        public bool Contains(string country) {
            return calloutImages.ContainsKey(country);
        }
    }
    public class PixelMapGenerator {
        const string SvgFileName = "Countries.svg";
        public static readonly ProjectionBase Projection = new EPSG4326Projection();

        MapUnit[] template;
        Size resolution;
        bool SvgMapExists() {
            string path = DemoUtils.GetRelativePath(SvgFileName);
            return File.Exists(path);
        }
        bool CheckWritingAllowed(string path) {
            try {
                using(new FileStream(path, FileMode.Create))
                    return true;
            }
            catch { return false; }
        }
        Stream GenerateSvgMap() {
            using(VectorItemsLayer layer = new VectorItemsLayer())
            using(ShapefileDataAdapter data = new ShapefileDataAdapter()) {
                data.FileUri = new Uri(@"file:\\" + DemoUtils.GetRelativePath("Countries.shp"));
                layer.Data = data;
                layer.ItemStyle.Fill = layer.ItemStyle.Stroke = Color.Black;
                data.Load();
                string filePath = Path.Combine(DemoUtils.GetRelativeDirectoryPath(string.Empty), SvgFileName);
                bool isWritingAllowed = CheckWritingAllowed(filePath);
                if(isWritingAllowed) {
                    layer.ExportToSvg(filePath, new SvgExportOptions() { CoordinateSystem = new GeoMapCoordinateSystem() { Projection = Projection } });
                    return new FileStream(filePath, FileMode.Open);
                }
                Stream stream = new MemoryStream();
                layer.ExportToSvg(stream, new SvgExportOptions() { CoordinateSystem = new GeoMapCoordinateSystem() { Projection = Projection } });
                stream.Seek(0, SeekOrigin.Begin);
                return stream;
            }
        }
        Bitmap GenerateRasterMap(Stream stream) {
            return (Bitmap)SvgBitmap.FromStream(stream).Render(resolution, null);
        }
        MapUnit CalculateOffset(int row, int col) {
            return new MapUnit((double)col / resolution.Height, (double)row / resolution.Width);
        }
        MapItem CreatePath(int row, int col) {
            MapUnit offset = CalculateOffset(row, col);
            GeoPoint[] geoPoints = CalculateGeoPoints(offset);
            MapPathSegment segment = new MapPathSegment();
            segment.Points.AddRange(geoPoints);
            MapPath path = new MapPath();
            path.Segments.Add(segment);
            return path;
        }
        GeoPoint[] CalculateGeoPoints(MapUnit offset) {
            GeoPoint[] points = new GeoPoint[template.Length];
            for(int i = 0; i < points.Length; i++) {
                MapUnit actualUnit = new MapUnit(offset.X + template[i].X, offset.Y + template[i].Y);
                points[i] = Projection.MapUnitToGeoPoint(actualUnit);
            }
            return points;
        }
        List<MapItem> GeneratePaths(Bitmap image) {
            List<MapItem> items = new List<MapItem>();
            BitmapData bitmapData = image.LockBits(new Rectangle(Point.Empty, image.Size), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            int byteArrayLength = bitmapData.Stride * image.Height;
            byte[] byteArray = new byte[byteArrayLength];
            Marshal.Copy(bitmapData.Scan0, byteArray, 0, byteArrayLength);
            int stride = bitmapData.Stride;
            for(int i = 3; i < byteArrayLength; i += 4)
                if(byteArray[i] != 0)
                    items.Add(CreatePath(i / stride, i / 4 % image.Width));
            image.UnlockBits(bitmapData);
            return items;
        }
        MapUnit[] GenerateDotTemplate(int pointsPerDotCount) {
            int scaleX = resolution.Width;
            int scaleY = resolution.Height;
            MapUnit[] result = new MapUnit[pointsPerDotCount];
            double phi = pointsPerDotCount == 3 ? -Math.PI / 2 : 0;
            double step = Math.PI * 2d / pointsPerDotCount;
            for(int i = 0; i < pointsPerDotCount; i++) {
                double x = Math.Cos(phi) / 2 + 0.5;
                double y = Math.Sin(phi) / 2 + 0.5;
                result[i] = new MapUnit(x / scaleX, y / scaleY);
                phi += step;
            }
            return result;
        }
        Stream GetSvgMapStream() {
            if(SvgMapExists())
                return new FileStream(DemoUtils.GetRelativePath(SvgFileName), FileMode.Open, FileAccess.Read);
            return GenerateSvgMap();
        }
        public List<MapItem> GenerateMap(Size resolution, int pointsPerDotCount) {
            using(Stream svgMapStream = GetSvgMapStream()) {
                this.resolution = resolution;
                template = GenerateDotTemplate(pointsPerDotCount);
                using(Bitmap rasterImage = GenerateRasterMap(svgMapStream))
                    return GeneratePaths(rasterImage);
            }
        }
    }

    public class PuzzleLayoutGenerator {
        const double HeightPadding = 0.01;
        const double WidthPadding = 0.01;

        readonly IList<Tuple<MapPath, MapRect>> items;
        readonly MapRect availableBounds;
        readonly ProjectionBase projection = new SphericalMercatorProjection();
        public static GeoPoint GetItemLocation(ISupportCoordPoints item) {
            return (GeoPoint)item.Points[0];
        }
        public PuzzleLayoutGenerator(IEnumerable<MapItem> items) {
            this.items = new List<Tuple<MapPath, MapRect>>();
            foreach(MapPath item in items) {
                MapRect itemBoundingBox = CalculateBoundingBox(item);
                this.items.Add(new Tuple<MapPath, MapRect>(item, itemBoundingBox));
            }
            MapUnit leftTop = projection.GeoPointToMapUnit(new GeoPoint(15, -180));
            MapUnit rightBottom = projection.GeoPointToMapUnit(new GeoPoint(-62, -90));
            availableBounds = MapRect.FromLTRB(leftTop.X, leftTop.Y, rightBottom.X, rightBottom.Y);
        }
        MapRect CalculateBoundingBox(ISupportCoordPoints item) {
            double maxLat = double.NegativeInfinity;
            double minLat = double.PositiveInfinity;
            double maxLon = double.NegativeInfinity;
            double minLon = double.PositiveInfinity;
            foreach(GeoPoint point in item.Points) {
                if(maxLat < point.Latitude)
                    maxLat = point.Latitude;
                if(minLat > point.Latitude)
                    minLat = point.Latitude;
                if(maxLon < point.Longitude)
                    maxLon = point.Longitude;
                if(minLon > point.Longitude)
                    minLon = point.Longitude;
            }
            MapUnit corner1 = projection.GeoPointToMapUnit(new GeoPoint(maxLat, minLon));
            MapUnit corner2 = projection.GeoPointToMapUnit(new GeoPoint(minLat, maxLon));
            return MapRect.FromLTRB(corner1.X, corner1.Y, corner2.X, corner2.Y);
        }
        public IEnumerable<MapPathInfo> GeneratePathInfos() {
            NonCryptographicRandom rnd = new NonCryptographicRandom(DateTime.Now.Millisecond);
            List<Tuple<MapPath, MapRect>> unusedItems = new List<Tuple<MapPath, MapRect>>(items);
            List<MapPathInfo> result = new List<MapPathInfo>();
            double availableHeight = availableBounds.Height;
            double y = availableBounds.Top;
            double x = availableBounds.Left;
            double maxWidth = 0;
            while(unusedItems.Count > 0) {
                List<Tuple<MapPath, MapRect>> availableItems = new List<Tuple<MapPath, MapRect>>();
                foreach(Tuple<MapPath, MapRect> item in unusedItems)
                    if(item.Item2.Height < availableHeight)
                        availableItems.Add(item);
                if(availableItems.Count > 0) {
                    int index = rnd.Next(availableItems.Count);
                    Tuple<MapPath, MapRect> pair = availableItems[index];
                    MapUnit gameCenter = new MapUnit(x + pair.Item2.Width / 2, y + pair.Item2.Height / 2);
                    result.Add(new MapPathInfo(pair.Item1, GetItemLocation(pair.Item1), projection.MapUnitToGeoPoint(gameCenter)));

                    unusedItems.Remove(pair);
                    availableHeight -= (pair.Item2.Height + HeightPadding);
                    y += pair.Item2.Height + HeightPadding;
                    if(pair.Item2.Width > maxWidth)
                        maxWidth = pair.Item2.Width;
                }
                else {
                    availableHeight = availableBounds.Height;
                    x += maxWidth + WidthPadding;
                    y = availableBounds.Top;
                    maxWidth = 0;
                }
            }
            return result;
        }
    }

    public abstract class FractalGeneratorBase {
        protected abstract List<CartesianPoint> GenerateCore(CartesianPoint start, CartesianPoint finish);
        public List<CartesianPoint> Generate(CartesianPoint start, CartesianPoint finish, int depth) {
            List<CartesianPoint> previousResult = new List<CartesianPoint>() { start, finish };
            for(int i = 0; i < depth; ++i) {
                List<CartesianPoint> result = new List<CartesianPoint>();
                result.Add(start);
                for(int j = 0; j < previousResult.Count - 1; ++j) {
                    List<CartesianPoint> points = GenerateCore(previousResult[j], previousResult[j + 1]);
                    points.RemoveAt(0);
                    result.AddRange(points);
                }
                previousResult = result;
            }
            return previousResult;
        }
    }
    public class MinkowskiLine : FractalGeneratorBase {
        protected override List<CartesianPoint> GenerateCore(CartesianPoint start, CartesianPoint finish) {
            List<CartesianPoint> result = new List<CartesianPoint>();
            double dx = (finish.X - start.X) / 4;
            double dy = (finish.Y - start.Y) / 4;
            result.Add(start);
            result.Add(new CartesianPoint(result.Last().X + dx, result.Last().Y + dy));
            result.Add(new CartesianPoint(result.Last().X - dy, result.Last().Y + dx));
            result.Add(new CartesianPoint(result.Last().X + dx, result.Last().Y + dy));
            result.Add(new CartesianPoint(result.Last().X + dy, result.Last().Y - dx));
            result.Add(new CartesianPoint(result.Last().X + dy, result.Last().Y - dx));
            result.Add(new CartesianPoint(result.Last().X + dx, result.Last().Y + dy));
            result.Add(new CartesianPoint(result.Last().X - dy, result.Last().Y + dx));
            result.Add(new CartesianPoint(result.Last().X + dx, result.Last().Y + dy));
            return result;
        }
    }
    public class KochLine : FractalGeneratorBase {
        protected override List<CartesianPoint> GenerateCore(CartesianPoint start, CartesianPoint finish) {
            List<CartesianPoint> result = new List<CartesianPoint>();
            double dx = (finish.X - start.X) / 3;
            double dy = (finish.Y - start.Y) / 3;
            result.Add(start);
            result.Add(new CartesianPoint(result.Last().X + dx, result.Last().Y + dy));
            result.Add(new CartesianPoint(result.Last().X + Math.Cos(Math.PI / 3) * dx - Math.Sin(Math.PI / 3) * dy,
                result.Last().Y + Math.Sin(Math.PI / 3) * dx + Math.Cos(Math.PI / 3) * dy));
            result.Add(new CartesianPoint(result.Last().X + Math.Cos(-Math.PI / 3) * dx - Math.Sin(-Math.PI / 3) * dy,
                result.Last().Y + Math.Sin(-Math.PI / 3) * dx + Math.Cos(-Math.PI / 3) * dy));
            result.Add(finish);
            return result;
        }
    }
    public static class TrackInfoHelper {
        readonly static string templateBegin = @"
        <table class=""table"">
	        <tr>
		        <th><img src=""Duration"" class=""image""></th>
		        <th class=""text"">Duration<br>${Duration}</th>
	        </tr>
	        <tr>
		        <th><img src=""Distance"" class=""image""></th>
		        <th class=""text"">Distance<br>${Distance}</th>
            </tr>";
        readonly static string templateHeartRate = @"
            <tr>
                <th><img src=""HeartRate"" class= ""image""></th>
                <th class= ""text"">Average Heart Rate<br>${AverageHeartRate}<br>$(Max {MaxHeartRate} | Min {MinHeartRate})</th>
            </tr>";
        readonly static string templateEnd = @"
            <tr>
                <th><img src=""Pace"" class= ""image""></th>
                <th class=""text"">$Average Pace {AveragePace}/km<br>$(Max {MaxPace})</th >
            </tr>
        </table>";

        static void CalculateHeartRate(DataView data, GpxTrackInfo info) {
            string heartRate = "gpxtpx:hr";
            if(!data.Table.Columns.Contains(heartRate))
                return;
            int minHeartRate = Convert.ToInt32(data[0][heartRate]), maxHeartRate = minHeartRate, heartRateSum = 0;
            foreach(DataRowView row in data) {
                minHeartRate = Math.Min(minHeartRate, Convert.ToInt32(row[heartRate]));
                maxHeartRate = Math.Max(maxHeartRate, Convert.ToInt32(row[heartRate]));
                heartRateSum += Convert.ToInt32(row[heartRate]);
            }
            info.MinHeartRate = minHeartRate;
            info.MaxHeartRate = maxHeartRate;
            info.AverageHeartRate = heartRateSum / data.Count;
        }
        static void CalculatePace(DataView data, GpxTrackInfo info) {
            if(!data.Table.Columns.Contains("Pace"))
                data.Table.Columns.Add("Pace");
            string distance = "gpxdata:distance", time = "time";
            int window = 10;
            long minTicks = long.MaxValue;
            for(int i = 1; i < window; i++) {
                double d = (double)data[i][distance] - (double)data[i - 1][distance];
                TimeSpan pace = TimeSpan.FromMilliseconds(0);
                if(d > double.Epsilon) {
                    TimeSpan dTime = (DateTime)data[i][time] - (DateTime)data[i - 1][time];
                    pace = TimeSpan.FromMinutes(dTime.TotalMinutes / (d * 0.001));
                    minTicks = Math.Min(minTicks, pace.Ticks);
                }
                data[i]["Pace"] = pace;
            }
            for(int j = window; j < data.Count; j++) {
                double d = (double)data[j][distance] - (double)data[j - window][distance];
                if(d < double.Epsilon)
                    continue;
                TimeSpan dTime = (DateTime)data[j][time] - (DateTime)data[j - window][time];
                TimeSpan pace = TimeSpan.FromMinutes(dTime.TotalMinutes / (d * 0.001));
                minTicks = Math.Min(minTicks, pace.Ticks);
                data[j]["Pace"] = pace;
            }
            info.AveragePace = TimeSpan.FromMinutes(info.Duration.TotalMinutes / info.Distance).ToString("mm\\:ss");
            info.MaxPace = TimeSpan.FromTicks(minTicks).ToString("mm\\:ss");
        }
        public static GpxTrackInfo CalculateTrackInfo(IListSource source) {
            GpxTrackInfo info = new GpxTrackInfo();
            DataView data = source.GetList() as DataView;
            if(data == null)
                return info;
            double durationSeconds = ((DateTime)data[data.Count - 1]["time"] - (DateTime)data[0]["time"]).TotalSeconds;
            info.Duration = TimeSpan.FromSeconds((long)durationSeconds);
            info.Distance = Math.Round(((double)data[data.Count - 1]["gpxdata:distance"] - (double)data[0]["gpxdata:distance"]) * 0.001, 3);
            CalculatePace(data, info);
            CalculateHeartRate(data, info);
            return info;
        }
        public static string GenerateTrackTemplate(bool isTrackHasHeartRate) {
            return templateBegin + (isTrackHasHeartRate ? templateHeartRate : string.Empty) + templateEnd;
        }
    }
    public static class MapArrowsDemoHelper {
        public static List<WindDataItem> LoadItems() {
            List<WindDataItem> items = new List<WindDataItem>();
            try {
                using(StreamReader reader = new StreamReader(DemoUtils.GetRelativePath("windData.csv"))) {
                    while(!reader.EndOfStream) {
                        string[] values = reader.ReadLine().Split(' ');
                        items.Add(new WindDataItem(
                            double.Parse(values[1], CultureInfo.InvariantCulture),
                            double.Parse(values[2], CultureInfo.InvariantCulture),
                            double.Parse(values[3], CultureInfo.InvariantCulture),
                            double.Parse(values[4], CultureInfo.InvariantCulture)));
                    }
                }
            }
            catch {
                throw new Exception("It's impossible to load wind data");
            }
            return items;
        }
    }
    //
    public class WindDataItem {
        const double ArrowLength = 70000;
        //
        public double Latitude1 { get; private set; }
        public double Longitude1 { get; private set; }
        public double Latitude2 { get; private set; }
        public double Longitude2 { get; private set; }
        public double Speed { get; private set; }
        //
        public WindDataItem(double latitude, double longitude, double direction, double speed) {
            GeoPoint destination = GeoUtils.CalculateDestinationPoint(new GeoPoint(latitude, longitude), ArrowLength, direction);
            Latitude1 = latitude;
            Longitude1 = longitude;
            Latitude2 = destination.Latitude;
            Longitude2 = destination.Longitude;
            Speed = speed;
        }
    }
}
