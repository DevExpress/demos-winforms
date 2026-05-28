using System;
using DevExpress.XtraScheduler.Reporting;
using System.Drawing;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler.Native;
using System.Drawing.Drawing2D;
using DevExpress.Utils.Controls;
using DevExpress.Utils;

namespace DevExpress.XtraScheduler.Demos.Reporting.CustomDraw {
	/// <summary>
	/// Summary description for Report.
	/// </summary>
	public partial class Report : XtraSchedulerReport {
        ImageCollection carUsageImages;

        bool _allowCustomDrawDayHeader;
        bool _allowCustomDrawResourceHeader;
        bool _allowCustomDrawAllDayArea;
        bool _allowCustomDrawTimeCell;
        bool _allowCustomDrawTimeRuler;
        bool _allowCustomDrawAppointment;
        bool _allowCustomDrawAppointmentBackground;

		public Report() {

            this.carUsageImages = ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.car_usage_types.png"), System.Reflection.Assembly.GetExecutingAssembly(), new Size(16, 16));
			InitializeComponent();
		}
        public bool AllowCustomDrawDayHeader { get { return _allowCustomDrawDayHeader; } set { _allowCustomDrawDayHeader = value;}  }
        public bool AllowCustomDrawResourceHeader { get { return _allowCustomDrawResourceHeader; } set { _allowCustomDrawResourceHeader = value; } }
        public bool AllowCustomDrawAllDayArea { get { return _allowCustomDrawAllDayArea; } set { _allowCustomDrawAllDayArea = value; } }
        public bool AllowCustomDrawTimeCell { get { return _allowCustomDrawTimeCell; } set { _allowCustomDrawTimeCell = value; } }
        public bool AllowCustomDrawTimeRuler { get { return _allowCustomDrawTimeRuler; } set { _allowCustomDrawTimeRuler = value; } }
        public bool AllowCustomDrawAppointment { get { return _allowCustomDrawAppointment; } set { _allowCustomDrawAppointment = value; } }
        public bool AllowCustomDrawAppointmentBackground { get { return _allowCustomDrawAppointmentBackground; } set { _allowCustomDrawAppointmentBackground = value; } }

        private void dayViewTimeCells1_CustomDrawTimeCell(object sender, CustomDrawObjectEventArgs e) {
            if (!AllowCustomDrawTimeCell)
                return;
            TimeCell cell = (TimeCell)e.ObjectInfo;

            Rectangle rect = e.Bounds;
            rect.Height = 1;
            rect.Offset(0, rect.Height - 1);
            e.Cache.DrawRectangle(Pens.Gray, rect);

            if (cell is ExtendedCell) {
                SchedulerColorSchema schema = GetResourceColorSchema(cell.Resource);
                cell.Appearance.BackColor = Color.White;
                cell.Appearance.BackColor2 = schema.CellLight;
                e.DrawDefault();

            } else {
                using (StringFormat sf = new StringFormat()) {
                    sf.Alignment = StringAlignment.Far;
                    rect = cell.Bounds;
                    rect.Inflate(-10, 0);
                    e.Cache.DrawString(cell.Interval.Start.ToShortTimeString(),
                        e.Cache.GetFont(cell.Appearance.Font, FontStyle.Regular),
                        e.Cache.GetSolidBrush(Color.Gray), rect, sf);
                }
            }
            e.Handled = true;
        }

        private void dayViewTimeRuler1_CustomDrawDayViewTimeRuler(object sender, CustomDrawObjectEventArgs e) {
            if (!AllowCustomDrawTimeRuler)
                return;

            e.Cache.FillRectangle(e.Cache.GetSolidBrush(Color.LightYellow), e.Bounds);
            using (StringFormat sf = new StringFormat()) {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                
                e.Cache.DrawVString(TimeZoneInfo.Local.DisplayName,
                    e.Cache.GetFont(new Font(Font.Name, 20, FontStyle.Bold), FontStyle.Bold),
                    e.Cache.GetSolidBrush(Color.Gray), e.Bounds, sf, -90);

                e.Handled = true;
            }

        }

        private void horizontalResourceHeaders1_CustomDrawResourceHeader(object sender, CustomDrawObjectEventArgs e) {
            if (!AllowCustomDrawResourceHeader)
                return;

            ResourceHeader header = (ResourceHeader)e.ObjectInfo;
            DrawHeaderUsingColorSchema(header, e.Cache);
            e.DrawDefault();
            e.Handled = true;
        }
        private void horizontalDateHeaders1_CustomDrawDayHeader(object sender, CustomDrawObjectEventArgs e) {
            if (!AllowCustomDrawDayHeader)
                return;

            DayHeader header = (DayHeader)e.ObjectInfo;
            DrawHeaderUsingColorSchema(header, e.Cache);

            e.DrawDefault();
            e.Handled = true;
        }

        private void DrawHeaderUsingColorSchema(SchedulerHeader header, DevExpress.Utils.Drawing.GraphicsCache cache) {
            SchedulerColorSchema schema = GetResourceColorSchema(header.Resource);

            header.Appearance.HeaderCaption.BackColor = schema.CellLight;
            header.Appearance.HeaderCaption.BackColor2 = schema.Cell;
            
            Color color = schema.CellBorderDark;
            header.Appearance.HeaderCaption.ForeColor = TransformColor(color, 0.6);
            header.Appearance.HeaderCaption.Font = cache.GetFont(header.Appearance.HeaderCaption.Font, FontStyle.Bold);
        }

        private Color TransformColor(Color color, double light) {
            return Color.FromArgb((int)(color.R * light), (int)(color.G * light), (int)(color.B * light));
        }

        private void dayViewTimeCells1_CustomDrawDayViewAllDayArea(object sender, CustomDrawObjectEventArgs e) {
            if (!AllowCustomDrawAllDayArea)
                return;

            AllDayAreaCell cell = (AllDayAreaCell)e.ObjectInfo;
            SchedulerColorSchema schema = GetResourceColorSchema(cell.Resource);

            cell.Appearance.BackColor = schema.Cell;
            cell.Appearance.BackColor2 = schema.CellBorder;
        }

        private void dayViewTimeCells1_CustomDrawAppointmentBackground(object sender, CustomDrawObjectEventArgs e) {
            if (!AllowCustomDrawAppointmentBackground)
                return;
            
            e.DrawDefault();
            AppointmentViewInfo vi = (AppointmentViewInfo)e.ObjectInfo;
            Rectangle rect = vi.Bounds;
            rect.Inflate(-vi.LeftBorderBounds.Width, -vi.TopBorderBounds.Height); 
            
            Brush brush = e.Cache.GetGradientBrush(rect, Color.White, vi.Appearance.BackColor, LinearGradientMode.Vertical);
            e.Cache.FillRectangle(brush, rect);
            e.Handled = true;
        }

        private void dayViewTimeCells1_CustomDrawAppointment(object sender, CustomDrawObjectEventArgs e) {
            if (!AllowCustomDrawAppointment)
                return;

            AppointmentViewInfo vi = (AppointmentViewInfo)e.ObjectInfo;

            Rectangle imgRect = RectUtils.CutFromLeft(vi.InnerBounds, vi.InnerBounds.Width - 18);
            imgRect = RectUtils.AlignRectangle(new Rectangle(0, 0, 16, 16), imgRect, ContentAlignment.MiddleCenter);
            e.Cache.DrawImage(carUsageImages.Images[(int)vi.Appointment.StatusKey], imgRect);

            Rectangle textRect = RectUtils.CutFromRight(vi.InnerBounds, 18);
            using(StringFormat sf = new StringFormat()) {
                Brush brush = e.Cache.GetSolidBrush(vi.Appearance.ForeColor);

                Font fntBold = e.Cache.GetFont(vi.Appearance.Font, FontStyle.Bold);
                Font fntItalic = e.Cache.GetFont(vi.Appearance.Font, FontStyle.Italic);

                if (vi.Appointment.LongerThanADay) {
                    Rectangle[] rowRects = RectUtils.SplitHorizontally(textRect, 2);
                    string hours = String.Format(" [{0:F2} h]", vi.AppointmentInterval.Duration.TotalHours);
                    e.Cache.DrawString(vi.DisplayText + hours, fntBold, brush, textRect, sf);
                } else {
                    Rectangle[] rects = RectUtils.SplitVertically(textRect, 3);
                    e.Cache.DrawString(vi.Interval.Start.ToShortTimeString() + " " +
                        vi.Interval.End.ToShortTimeString(), vi.Appearance.Font, brush, rects[0], sf);
                    
                    e.Cache.DrawString(String.Format("{0} [{1}]", vi.Appointment.Subject, vi.Appointment.Location), fntBold, brush, rects[1], sf);
                    e.Cache.DrawString(vi.Description, fntItalic, brush, rects[2], sf);
                }
            }
            e.Handled = true;
        }

    }
}
