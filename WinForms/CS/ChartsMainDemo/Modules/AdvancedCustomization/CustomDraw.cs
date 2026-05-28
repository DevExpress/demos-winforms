using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Drawing;
using DevExpress.XtraEditors;

namespace DevExpress.XtraCharts.Demos {
    public partial class CustomDrawDemo : ChartDemoModule {
        readonly Dictionary<string, Image> photos = new Dictionary<string, Image>();
        readonly Dictionary<Series, int> seriesIndexes = new Dictionary<Series, int>();
        readonly Dictionary<Color, SolidBrush> legendBackgroundBrushes = new Dictionary<Color, SolidBrush>();
        Dictionary<int, string> bestEmployees;
        Series selectedSeries;
        Color chartSkinBackColor;

        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public CustomDrawDemo() {
            InitializeComponent();
            ChartControl.BeginInit();
            BindChartToData();
            InitializePhotos();
            UpdateLegendBackColor();
            ChartControl.EndInit();
        }

        void BindChartToData() {
            chart.DataSource = dS51.Employees;
            string path = Utils.GetRelativePath("nwind.mdb");
            if(path.Length > 0)
                Utils.SetConnectionString(oleDbConnection, path);
            else {
                XtraMessageBox.Show("The \"nwind.mdb\" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                oleDbAdapter.Fill(dS51);
                bestEmployees = SelectBestEmployees();
            }
            catch(OleDbException e) {
                XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        void InitializePhotos() {
            byte[] imageBytes;
            foreach(DataRow row in dS51.Employees.Rows) {
                imageBytes = (byte[])row.ItemArray[4];
                string lastName = string.Format("{0}\r\n{1}", row.ItemArray[2].ToString(), row.ItemArray[3].ToString());
                using(MemoryStream stream = new MemoryStream(imageBytes))
                    if(!photos.ContainsKey(lastName))
                        photos.Add(lastName, Utils.ResizeImage(Image.FromStream(stream), 48, 48));
            }
        }
        void UpdateLegendBackColor() {
            chartSkinBackColor = ColorUtils.GetChartBackground(LookAndFeel);
            ChartControl.Legend.BackColor = chartSkinBackColor;
        }
        void RenderEllipses(Graphics g, Brush brush, int location, int side) {
            g.FillEllipse(Brushes.White, new Rectangle(new Point(location - 1, location - 1), new Size(side + 2, side + 2)));
            g.FillEllipse(brush, new Rectangle(new Point(location, location), new Size(side, side)));
        }
        string CalculateAxisLabelText(double axisValue) {
            const string dollar = "$";
            double millions = axisValue / 1000;
            if(millions == 0)
                return string.Format("{0}{1}", dollar, millions);
            else if(millions < 1)
                return string.Format("{0}{1}{2}", dollar, axisValue, "K");
            return string.Format("{0}{1}{2}", dollar, millions, "M");
        }
        float CalculateFontSize(double ratio, int minFontSize, int maxFontSize) {
            return (float)(minFontSize + (maxFontSize - minFontSize) * ratio);
        }
        Dictionary<int, string> SelectBestEmployees() {
            return dS51.Employees.GroupBy((g) => new { g.LastName, g.OrderDate.Year }).
                                    Select(o => new {
                                        o.Key.Year,
                                        FullName = string.Format("{0} {1}", o.Key.LastName, o.FirstOrDefault().FirstName),
                                        SumFreight = o.Sum(v => v.Freight)
                                    }).GroupBy((y) => y.Year).
                                    SelectMany(r => r.Where(b => b.SumFreight == r.Max(c => c.SumFreight))).
                                    ToDictionary(k => k.Year, v => v.FullName);
        }
        Image DrawMarkerOnPhoto(Image srcImage, bool isSelected, Color color, Color hatchColor, int location, int side) {
            Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);
            Graphics g = Graphics.FromImage(dstImage);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddRectangle(new Rectangle(-1, -1, dstImage.Width + 2, dstImage.Height + 2));
            graphicsPath.AddEllipse(0, 0, dstImage.Width, dstImage.Height);
            g.DrawImage(srcImage, 0, 0);
            g.FillPath(GetLegendMarkerBackground(chartSkinBackColor), graphicsPath);
            if(isSelected)
                RenderEllipses(g, new HatchBrush(HatchStyle.DarkUpwardDiagonal, color, hatchColor), location - 2, side + 3);
            else
                RenderEllipses(g, new LinearGradientBrush(new Rectangle(new Point(), srcImage.Size), color, hatchColor, LinearGradientMode.BackwardDiagonal), location, side);
            return dstImage;
        }
        Brush GetLegendMarkerBackground(Color chartSkinBackColor) {
            SolidBrush brush = null;
            if(!legendBackgroundBrushes.TryGetValue(chartSkinBackColor, out brush)) {
                brush = new SolidBrush(chartSkinBackColor);
                legendBackgroundBrushes[chartSkinBackColor] = brush;
            }
            return brush;
        }
        void chart_CustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {
            bool isSelected = selectedSeries != null && e.Series.Name == selectedSeries.Name;
            Bitmap photo = new Bitmap(48, 48);
            using(Graphics g = Graphics.FromImage(photo)) {
                foreach(string fullName in photos.Keys)
                    if(fullName.Contains(e.Series.Name)) {
                        g.DrawImage(photos[fullName], new Rectangle(new Point(0, 0), new Size(48, 48)));
                        e.LegendText = fullName;
                        break;
                    }
            }
            e.LegendMarkerImage = DrawMarkerOnPhoto(photo, isSelected, e.LegendDrawOptions.Color, e.LegendDrawOptions.ActualColor2, 33, 13);
            e.DisposeLegendMarkerImage = true;
            if(isSelected && e.SeriesDrawOptions is BarDrawOptions) {
                ((BarDrawOptions)e.SeriesDrawOptions).FillStyle.FillMode = FillMode.Hatch;
                ((HatchFillOptions)((BarDrawOptions)e.SeriesDrawOptions).FillStyle.Options).HatchStyle = HatchStyle.DarkUpwardDiagonal;
            }
        }
        void chart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            List<object> list = e.SeriesPoint.Tag as List<object>;
            if(list == null || list.Count == 0)
                return;
            DataRow row = ((DataRowView)list[0]).Row;
            int year = ((DateTime)row["OrderDate"]).Year;
            if(bestEmployees[year].Contains(row["LastName"].ToString())) {
                e.LabelText = string.Format("{0}\r\n Best employee in the {1}", bestEmployees[year], year);
                PaletteEntry[] entries = chart.GetPaletteEntries(chart.Series.Count);
                RectangularBorder border = ((BarDrawOptions)e.SeriesDrawOptions).Border;
                border.Color = ColorUtils.MixColors(Color.FromArgb(100, 0, 0, 0), entries[seriesIndexes[e.Series]].Color);
                border.Thickness = 4;
            }
            else
                e.LabelText = string.Empty;
        }
        void chart_CustomDrawAxisLabel(object sender, CustomDrawAxisLabelEventArgs e) {
            if(e.Item.Axis is AxisX)
                return;
            double axisValue = double.Parse(e.Item.Text);
            double max = e.Item.Axis.WholeRange.MaxValueInternal;
            double ratio = axisValue / max;
            e.Item.Text = CalculateAxisLabelText(axisValue);
            e.Item.TextColor = ColorUtils.InterpolateColors(Color.FromArgb(255, 170, 42, 0), Color.Green, ratio);
            if(ratio > 0)
                e.Item.DXFont = new DXFont("Tahoma", CalculateFontSize(ratio, 8, 15));
        }
        void chart_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            selectedSeries = e.HitInfo.InSeries ? (Series)e.HitInfo.Series : null;
            chart.Invalidate();
        }
        void chart_MouseLeave(object sender, EventArgs e) {
            selectedSeries = null;
        }
        void chart_BoundDataChanged(object sender, EventArgs e) {
            for(int i = 0; i < chart.Series.Count; i++)
                seriesIndexes[chart.Series[i]] = i;
        }

        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateLegendBackColor();
        }
    }
}
