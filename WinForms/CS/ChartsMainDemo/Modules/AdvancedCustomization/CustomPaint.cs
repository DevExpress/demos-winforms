using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevExpress.Data.Utils;
using DevExpress.Utils.Drawing;

namespace DevExpress.XtraCharts.Demos {
    public partial class CustomPaintDemo : ChartDemoModuleWithOptions {
        readonly List<Cluster> clusters = new List<Cluster>();

        XYDiagram XYDiagram {
            get { return (chart.Diagram as XYDiagram); }
        }
        AxisX AxisX {
            get { return XYDiagram.AxisX; }
        }
        AxisY AxisY {
            get { return XYDiagram.AxisY; }
        }
        internal override bool ChartDesignerEnabled {
            get { return false; }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }


        public CustomPaintDemo() {
            InitializeComponent();
            ChartControl.BeginInit();
            InitSeries();
            ProcessAutoClusters();
            ChartControl.EndInit();
        }


        void InitSeries() {
            if(chart.Series.Count > 0) {
                NonCryptographicRandom random = NonCryptographicRandom.System;
                chart.Series[0].Points.Clear();
                chart.Series[0].Points.AddRange(DiagramToPointHelper.CalculatePoints(random, 50, 5, 9));
                chart.Series[0].Points.AddRange(DiagramToPointHelper.CalculatePoints(random, 50, 13, 5));
                chart.Series[0].Points.AddRange(DiagramToPointHelper.CalculatePoints(random, 50, 10, 18));
            }
        }
        void ProcessAutoClusters() {
            List<PointF>[] pointsLists = new List<PointF>[3] { new List<PointF>(), new List<PointF>(), new List<PointF>() };
            DiagramToPointHelper.CalculateClusters(chart.Series[0].Points, pointsLists[0], pointsLists[1], pointsLists[2]);
            for(int i = 0; i < 3; i++) {
                Cluster cluster = new Cluster();
                cluster.Calculate(pointsLists[i]);
                clusters.Add(cluster);
                if(i == 0) {
                    cluster.IsSelected = true;
                }
            }
        }
        Rectangle CalculateDiagramBounds() {
            Point p1 = XYDiagram.DiagramToPoint((double)AxisX.WholeRange.MinValue, (double)AxisY.WholeRange.MinValue).Point;
            Point p2 = XYDiagram.DiagramToPoint((double)AxisX.WholeRange.MaxValue, (double)XYDiagram.AxisY.WholeRange.MaxValue).Point;
            return DiagramToPointHelper.CreateRectangle(p1, p2);
        }
        Point[] GetScreenPoints(List<PointF> contourPoints) {
            Point[] screenPoints = new Point[contourPoints.Count];
            for(int i = 0; i < contourPoints.Count; i++)
                screenPoints[i] = XYDiagram.DiagramToPoint(contourPoints[i].X, contourPoints[i].Y).Point;
            return screenPoints;
        }
        void DrawCluster(Cluster cluster, GraphicsCache g, Color color, Color borderColor) {
            Point[] screenPoints = GetScreenPoints(cluster.ContourPoints);
            if(screenPoints.Length > 0) {
                Color fillColor = Color.FromArgb(50, color.R, color.G, color.B);
                if(cluster.IsSelected) {
                    g.FillPolygon(screenPoints, fillColor);
                    g.DrawPolygon(screenPoints, borderColor, 4);
                }
                else {
                    g.FillPolygon(screenPoints, fillColor);
                    g.DrawPolygon(screenPoints, borderColor, 1);
                }
            }
        }
        void SelectOrUnselectCluster(Cluster cluster, Point point) {
            if(cluster.Points.Count < 2)
                return;
            Point[] screenPoints = GetScreenPoints(cluster.ContourPoints);
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(screenPoints);
            cluster.IsSelected = path.IsVisible(point);
        }
        void chart_CustomPaint(object sender, CustomPaintEventArgs e) {
            DXCustomPaintEventArgs args = e as DXCustomPaintEventArgs;
            if(args == null)
                return;
            GraphicsCache g = args.Cache;
            if(clusters.Count == 0) {
                if(!toggleSwitchClusteringMode.IsOn) {
                    using(Font font = new Font("Tahoma", 18)) {
                        g.DrawString("Drag the mouse with the Ctrl key pressed to form a cluster.", font, Brushes.LightSlateGray, new PointF(40, 60));
                    }
                }
                return;
            }
            g.ClipInfo.SetClip(CalculateDiagramBounds());
            g.SmoothingMode = SmoothingMode.AntiAlias;
            PaletteEntry[] paletteEntries = ChartControl.GetPaletteEntries(clusters.Count);
            for(int i = 0; i < clusters.Count; i++) {
                DrawCluster(clusters[i], g, paletteEntries[i].Color, paletteEntries[i].Color);
            }
        }
        void chart_MouseDown(object sender, MouseEventArgs e) {
            foreach(Cluster cluster in clusters)
                SelectOrUnselectCluster(cluster, e.Location);
            ChartControl.Invalidate();
        }
        void chart_SelectedItemsChanging(object sender, SelectedItemsChangingEventArgs e) {
            if(toggleSwitchClusteringMode.IsOn) {
                e.Cancel = true;
                return;
            }
            List<PointF> newSelectedPoints = new List<PointF>();
            foreach(SeriesPoint seriesPoint in e.NewItems) {
                PointF point = new PointF((float)seriesPoint.NumericalArgument, (float)seriesPoint.Values[0]);
                newSelectedPoints.Add(point);
            }
            Cluster cluster = new Cluster();
            cluster.Calculate(newSelectedPoints);
            clusters.Add(cluster);
            e.Cancel = true;
            ChartControl.Invalidate();
        }
        void chart_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            e.Cancel = true;
        }
        void simpleButtonGeneratePoints_Click(object sender, EventArgs e) {
            InitSeries();
            clusters.Clear();
            if(toggleSwitchClusteringMode.IsOn)
                ProcessAutoClusters();
            chart.Animate();
            chart.Invalidate();
        }
        void toggleSwitchClusteringMode_Toggled(object sender, EventArgs e) {
            clusters.Clear();
            if(toggleSwitchClusteringMode.IsOn)
                ProcessAutoClusters();
            chart.Invalidate();
        }
        void simpleButtonClearClusters_Click(object sender, EventArgs e) {
            clusters.Clear();
            ChartControl.Invalidate();
        }
    }


    class Cluster {
        List<PointF> points = new List<PointF>();
        List<PointF> sortedPoints = new List<PointF>();
        List<PointF> contourPoints = new List<PointF>();
        bool isClusterSelected = false;

        public List<PointF> Points { get { return points; } }
        public List<PointF> SortedPoints { get { return sortedPoints; } }
        public List<PointF> ContourPoints { get { return contourPoints; } }
        public bool IsSelected { get { return isClusterSelected; } set { isClusterSelected = value; } }

        public void Calculate(List<PointF> points) {
            this.points = points;
            sortedPoints = DiagramToPointHelper.Sort(points);
            contourPoints = DiagramToPointHelper.CreateClosedCircuit(sortedPoints);
            isClusterSelected = false;
        }
        public void Clear() {
            points.Clear();
            sortedPoints.Clear();
            contourPoints.Clear();
            isClusterSelected = false;
        }
    }


    static class DiagramToPointHelper {
        const double Epsilon = 0.001;

        static PointF CalcRandomPoint(NonCryptographicRandom random, int xCenter, int yCenter) {
            const int dispersion = 2;
            const int expectedSum = 6;
            PointF point = new PointF();
            double sum = 0;
            for(int i = 0; i < 12; i++)
                sum += random.NextDouble();
            double radius = (sum - expectedSum) * dispersion;
            double angle = random.Next(360) * Math.PI / 180;
            point.X = (float)(xCenter + radius * Math.Cos(angle));
            point.Y = (float)(yCenter + radius * Math.Sin(angle));
            return point;
        }
        static bool AreEqual(PointF point1, PointF point2) {
            return AreEqual(point1.X, point2.X) && AreEqual(point1.Y, point2.Y);
        }
        static bool AreEqual(double number1, double number2) {
            double difference = number1 - number2;
            if(Math.Abs(difference) <= Epsilon)
                return true;
            return false;
        }
        static PointF GetClusterCenter(List<PointF> cluster) {
            if(cluster.Count == 0)
                return PointF.Empty;
            float centerX = 0;
            float centerY = 0;
            foreach(PointF point in cluster) {
                centerX += point.X;
                centerY += point.Y;
            }
            centerX /= cluster.Count;
            centerY /= cluster.Count;
            return new PointF(centerX, centerY);
        }
        static void CreateUpperArc(List<PointF> cluster, List<PointF> sortedCluster) {
            for(int i = 1; i < cluster.Count; i++) {
                if(i + 1 == cluster.Count) {
                    sortedCluster.Add(cluster[i]);
                    break;
                }
                bool shouldAddPoint = false;
                float x0 = sortedCluster[sortedCluster.Count - 1].X;
                float y0 = sortedCluster[sortedCluster.Count - 1].Y;
                float x1 = cluster[i].X;
                float y1 = cluster[i].Y;
                if(x1 == x0) {
                    if(y0 < y1)
                        shouldAddPoint = true;
                }
                else
                    for(int j = i + 1; j < cluster.Count; j++) {
                        if(cluster[j].Y >= (double)(cluster[j].X - x0) * (double)(y1 - y0) / (double)(x1 - x0) + y0) {
                            shouldAddPoint = false;
                            break;
                        }
                        else
                            shouldAddPoint = true;
                    }
                if(shouldAddPoint)
                    sortedCluster.Add(cluster[i]);
            }
        }
        static void CreateBottomArc(List<PointF> cluster, List<PointF> sortedCluster) {
            for(int i = cluster.Count - 1; i >= 0; i--) {
                if(i == 0) {
                    sortedCluster.Add(cluster[i]);
                    break;
                }
                bool shouldAddPoint = false;
                float x0 = sortedCluster[sortedCluster.Count - 1].X;
                float y0 = sortedCluster[sortedCluster.Count - 1].Y;
                float x1 = cluster[i].X;
                float y1 = cluster[i].Y;
                if(x1 == x0) {
                    if(y0 > y1)
                        shouldAddPoint = true;
                }
                else
                    for(int j = i - 1; j >= 0; j--) {
                        if(cluster[j].Y <= (double)(cluster[j].X - x0) * (double)(y1 - y0) / (double)(x1 - x0) + y0) {
                            shouldAddPoint = false;
                            break;
                        }
                        else
                            shouldAddPoint = true;
                    }
                if(shouldAddPoint)
                    sortedCluster.Add(cluster[i]);
            }
        }

        public static Rectangle CreateRectangle(Point corner1, Point corner2) {
            int x = corner1.X < corner2.X ? corner1.X : corner2.X;
            int y = corner1.Y < corner2.Y ? corner1.Y : corner2.Y;
            int width = Math.Abs(corner1.X - corner2.X);
            int height = Math.Abs(corner1.Y - corner2.Y);
            return new Rectangle(x, y, width, height);
        }
        public static RectangleF CreateRectangle(PointF corner1, PointF corner2) {
            float x = corner1.X < corner2.X ? corner1.X : corner2.X;
            float y = corner1.Y < corner2.Y ? corner1.Y : corner2.Y;
            float width = Math.Abs(corner1.X - corner2.X);
            float height = Math.Abs(corner1.Y - corner2.Y);
            return new RectangleF(x, y, width, height);
        }
        public static Point GetLastSelectionCornerPosition(Point p, Rectangle bounds) {
            if(p.X < bounds.Left)
                p.X = bounds.Left;
            else if(p.X > bounds.Right)
                p.X = bounds.Right - 1;
            if(p.Y < bounds.Top)
                p.Y = bounds.Top;
            else if(p.Y > bounds.Bottom)
                p.Y = bounds.Bottom - 1;
            return p;
        }
        public static SeriesPoint[] CalculatePoints(NonCryptographicRandom random, int count, int xCenter, int yCenter) {
            SeriesPoint[] seriesPoints = new SeriesPoint[count];
            for(int i = 0; i < count; i++) {
                PointF point = CalcRandomPoint(random, xCenter, yCenter);
                seriesPoints[i] = new SeriesPoint(point.X, new double[] { point.Y });
            }
            return seriesPoints;
        }
        public static void CalculateClusters(SeriesPointCollection seriesPoints, List<PointF> cluster1, List<PointF> cluster2, List<PointF> cluster3) {
            List<PointF> points = new List<PointF>();
            foreach(SeriesPoint point in seriesPoints)
                points.Add(new PointF((float)point.NumericalArgument, (float)point.Values[0]));
            if(points.Count < 100)
                return;
            PointF nextCenter1 = points[0];
            PointF nextCenter2 = points[50];
            PointF nextCenter3 = points[100];
            PointF center1;
            PointF center2;
            PointF center3;
            do {
                center1 = nextCenter1;
                center2 = nextCenter2;
                center3 = nextCenter3;
                cluster1.Clear();
                cluster2.Clear();
                cluster3.Clear();
                foreach(PointF point in points) {
                    float x = point.X;
                    float y = point.Y;
                    double distance1 = Math.Sqrt((center1.X - x) * (center1.X - x) + (center1.Y - y) * (center1.Y - y));
                    double distance2 = Math.Sqrt((center2.X - x) * (center2.X - x) + (center2.Y - y) * (center2.Y - y));
                    double distance3 = Math.Sqrt((center3.X - x) * (center3.X - x) + (center3.Y - y) * (center3.Y - y));
                    if(distance1 <= distance2 && distance1 <= distance3)
                        cluster1.Add(point);
                    else if(distance2 <= distance1 && distance2 <= distance3)
                        cluster2.Add(point);
                    else
                        cluster3.Add(point);
                }
                nextCenter1 = GetClusterCenter(cluster1);
                nextCenter2 = GetClusterCenter(cluster2);
                nextCenter3 = GetClusterCenter(cluster3);
            } while(!AreEqual(center1, nextCenter1) || !AreEqual(center2, nextCenter2) || !AreEqual(center3, nextCenter3));
        }
        public static List<PointF> Sort(List<PointF> cluster) {
            List<PointF> sortedCluster = new List<PointF>();
            if(cluster.Count == 0)
                return sortedCluster;
            sortedCluster.Add(cluster[0]);
            for(int i = 1; i < cluster.Count; i++) {
                if(sortedCluster[0].X >= cluster[i].X)
                    sortedCluster.Insert(0, cluster[i]);
                else if(sortedCluster[sortedCluster.Count - 1].X <= cluster[i].X)
                    sortedCluster.Insert(sortedCluster.Count, cluster[i]);
                else
                    for(int j = 0; j < sortedCluster.Count - 1; j++) {
                        if(sortedCluster[j].X <= cluster[i].X && sortedCluster[j + 1].X >= cluster[i].X) {
                            sortedCluster.Insert(j + 1, cluster[i]);
                            break;
                        }
                    }
            }
            return sortedCluster;
        }
        public static List<PointF> CreateClosedCircuit(List<PointF> sortedCluster) {
            List<PointF> contourPoints = new List<PointF>();
            if(sortedCluster.Count == 0)
                return contourPoints;
            contourPoints.Add(sortedCluster[0]);
            CreateUpperArc(sortedCluster, contourPoints);
            CreateBottomArc(sortedCluster, contourPoints);
            return contourPoints;
        }
    }

}
