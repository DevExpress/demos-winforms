using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.Utils.Controls;
using DevExpress.XtraScheduler.Native;

namespace DevExpress.XtraScheduler.Demos {
    public partial class CustomDrawModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        ImageCollection carUsageImages;
        Brush hatchBrush = null;

        public CustomDrawModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            this.carUsageImages = ImageHelper.CreateImageCollectionFromResources(DemoUtils.FindResourceName("Images.car_usage_types.png"), System.Reflection.Assembly.GetExecutingAssembly(), new Size(16, 16));
            // TODO: Add any initialization after the InitializeComponent call
        }

        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }


        public BaseAppearanceCollection SchedulerAppearances {
            get { return this.schedulerControl.Appearance; }
        }

        private void DayViewModule_Load(object sender, System.EventArgs e) {
            DemoUtils.FillAppointmentStatuses(this.schedulerStorage);
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
            UpdateControls();
        }
        private void schedulerControl_ActiveViewChanged(object sender, System.EventArgs e) {
            UpdateControls();
        }
        void UpdateControls() {
            SchedulerViewBase view = schedulerControl.ActiveView;
            SchedulerGroupType grType = schedulerControl.GroupType;

            bool isAgendaView = view is AgendaView;

            chkDayViewAllDayArea.Enabled = view is DayView;
            chkWeekViewTopLeftCorner.Enabled = (view is WeekView && grType.Equals(SchedulerGroupType.Date)) ||
                (view is TimelineView && !grType.Equals(SchedulerGroupType.None));
            chkGroupSeparator.Enabled = !grType.Equals(SchedulerGroupType.None) && !isAgendaView;
            chkResourceHeader.Enabled = !grType.Equals(SchedulerGroupType.None) && !isAgendaView;
            chkDayOfWeekHeader.Enabled = (view is WeekView && grType.Equals(SchedulerGroupType.Date)) ||
                (view is MonthView && !grType.Equals(SchedulerGroupType.None));
            chkTimeCell.Enabled = !isAgendaView;
        }
        private void schedulerControl_CustomDrawAppointment(object sender, DevExpress.XtraScheduler.CustomDrawObjectEventArgs e) {
            GraphicsCache cache = e.Cache;
            if (!chkAppointment.Checked)
                return;

            AppointmentViewInfo vi = e.ObjectInfo as AppointmentViewInfo;
            if (vi == null)
                return;

            Rectangle imgRect = RectUtils.CutFromLeft(vi.InnerBounds, vi.InnerBounds.Width - 18);
            imgRect = RectUtils.AlignRectangle(new Rectangle(0, 0, 16, 16), imgRect, ContentAlignment.MiddleCenter);
            cache.DrawImage(carUsageImages.Images[(int)vi.Appointment.StatusKey], imgRect);

            Rectangle textRect = RectUtils.CutFromRight(vi.InnerBounds, 18);
            vi.Appearance.DrawString(cache, vi.DisplayText, textRect, vi.Appearance.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis));

            if (this.schedulerControl.ActiveViewType == SchedulerViewType.Agenda && vi.Selected)
                cache.DrawRectangle(Pens.Black, e.Bounds);

            e.Handled = true;
        }
        private void schedulerControl_CustomDrawAppointmentBackground(object sender, CustomDrawObjectEventArgs e) {
            if (!chkAppointmentBackground.Checked)
                return;

            AppointmentViewInfo aptViewInfo = e.ObjectInfo as AppointmentViewInfo;
            if (aptViewInfo == null)
                return;

            GraphicsCache cache = e.Cache;
            Rectangle r = e.Bounds;
            FillRoundedRect(cache, GetStatusBrush(aptViewInfo.Status), r, 5);

            r.Inflate(-3, -3);
            Brush br = cache.GetSolidBrush(this.schedulerStorage.GetLabelColor(aptViewInfo.Appointment.LabelKey));
            FillRoundedRect(cache, br, r, 5);
            e.Handled = true;
        }
        Brush GetStatusBrush(IAppointmentStatus status) {
            if (status.Type == AppointmentStatusType.Tentative) {
                if (this.hatchBrush == null)
                    this.hatchBrush = new HatchBrush(HatchStyle.WideUpwardDiagonal, DXColor.White, ((SolidBrush)status.GetBrush()).Color);
                return this.hatchBrush;
            } 
            return status.GetBrush();
        }
        void FillRoundedRect(GraphicsCache cache, Brush br, Rectangle r, int roundRadius) {
            cache.FillPath(br, CreateRoundedRectPath(r, roundRadius));
        }
        private void schedulerControl_CustomDrawTimeCell(object sender, CustomDrawObjectEventArgs e) {
            if (!chkTimeCell.Checked)
                return;
            SelectableIntervalViewInfo viewInfo = e.ObjectInfo as SelectableIntervalViewInfo;

            SchedulerViewCellBase cell = e.ObjectInfo as SchedulerViewCellBase;

            GraphicsCache cache = e.Cache;
            if (viewInfo.Selected)
                cache.FillRectangle(SystemBrushes.Highlight, cell.Bounds);
            else {
                FillGradient(cache, cell.Bounds, Color.FromArgb(165, 203, 141), Color.FromArgb(185, 233, 181), 45);
            }
            e.Handled = true;
        }
        void FillGradient(GraphicsCache cache, Rectangle r, Color c1, Color c2, int angle) {
            if (r.Width <= 0 || r.Height <= 0)
                return;

            using (LinearGradientBrush br = new LinearGradientBrush(r, c1, c2, angle)) {
                cache.FillRectangle(br, r);
            }
        }
        static public GraphicsPath CreateRoundedRectPath(Rectangle r, int radius) {
            GraphicsPath path = new GraphicsPath();

            path.AddLine(r.Left + radius, r.Top, r.Left + r.Width - radius * 2, r.Top);
            path.AddArc(r.Left + r.Width - radius * 2, r.Top, radius * 2, radius * 2, 270, 90);
            path.AddLine(r.Left + r.Width, r.Top + radius, r.Left + r.Width, r.Top + r.Height - radius * 2);
            path.AddArc(r.Left + r.Width - radius * 2, r.Top + r.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddLine(r.Left + r.Width - radius * 2, r.Top + r.Height, r.Left + radius, r.Top + r.Height);
            path.AddArc(r.Left, r.Top + r.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.AddLine(r.Left, r.Top + r.Height - radius * 2, r.Left, r.Top + radius);
            path.AddArc(r.Left, r.Top, radius * 2, radius * 2, 180, 90);
            path.CloseFigure();
            return path;
        }
        private void schedulerControl_CustomDrawResourceHeader(object sender, CustomDrawObjectEventArgs e) {
            if (!chkResourceHeader.Checked)
                return;
            SchedulerHeader header = e.ObjectInfo as SchedulerHeader;
            AppearanceObject app = header.Appearance.HeaderCaption;

            SchedulerGroupType grType = schedulerControl.ActiveView.GroupType;
            bool vertLayout = (schedulerControl.ActiveView is WeekView && grType.Equals(SchedulerGroupType.Date))
                || (schedulerControl.ActiveView is TimelineView && !grType.Equals(SchedulerGroupType.None));

            LinearGradientMode gradientMode = vertLayout ? LinearGradientMode.Horizontal : LinearGradientMode.Vertical;
            GraphicsCache cache = e.Cache;
            cache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(206, 188, 239), Color.FromArgb(156, 138, 189), gradientMode), e.Bounds);
            Rectangle innerRect = Rectangle.Inflate(e.Bounds, -2, -2);
            cache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(156, 138, 189), Color.FromArgb(206, 188, 239), gradientMode), innerRect);

            StringFormat sf = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis);
            if (vertLayout)
                cache.DrawVString(header.Caption, app.Font, app.GetForeBrush(e.Cache), innerRect, sf, 270);
            else
                cache.DrawString(header.Caption, app.Font, app.GetForeBrush(e.Cache), innerRect, sf);
            e.Handled = true;
        }

        private void schedulerControl_CustomDrawWeekViewTopLeftCorner(object sender, CustomDrawObjectEventArgs e) {
            if (!chkWeekViewTopLeftCorner.Checked)
                return;
            GraphicsCache cache = e.Cache;
            cache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(176, 158, 209), Color.FromArgb(146, 128, 179), LinearGradientMode.Vertical), e.Bounds);
            Rectangle innerRect = Rectangle.Inflate(e.Bounds, -2, -2);
            cache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(146, 128, 179), Color.FromArgb(176, 158, 209), LinearGradientMode.Vertical), innerRect);
            e.Handled = true;
        }

        private void schedulerControl_CustomDrawDayHeader(object sender, CustomDrawObjectEventArgs e) {
            if (!chkDayHeader.Checked)
                return;

            SchedulerHeader header = e.ObjectInfo as SchedulerHeader;
            AppearanceObject app = header.Appearance.HeaderCaption;

            GraphicsCache cache = e.Cache;
            if (e.Bounds.Height > 0 && e.Bounds.Width > 0) {
                cache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(175, 231, 228), Color.FromArgb(125, 181, 178), LinearGradientMode.Vertical), e.Bounds);
                Rectangle innerRect = Rectangle.Inflate(e.Bounds, -2, -2);
                cache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(125, 181, 178), Color.FromArgb(175, 231, 228), LinearGradientMode.Vertical), innerRect);

                StringFormat sf = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis);
                cache.DrawString(header.Caption, app.Font, new SolidBrush(Color.Black), innerRect, sf);
            }
            e.Handled = true;
        }

        private void schedulerControl_CustomDrawDayOfWeekHeader(object sender, DevExpress.XtraScheduler.CustomDrawObjectEventArgs e) {
            if (!chkDayOfWeekHeader.Checked)
                return;
            SchedulerHeader header = e.ObjectInfo as SchedulerHeader;
            AppearanceObject app = header.Appearance.HeaderCaption;
            GraphicsCache cache = e.Cache;
            cache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(145, 181, 198), Color.FromArgb(95, 131, 148), LinearGradientMode.Vertical), e.Bounds);
            Rectangle innerRect = Rectangle.Inflate(e.Bounds, -2, -2);
            cache.FillRectangle(new LinearGradientBrush(e.Bounds, Color.FromArgb(95, 131, 148), Color.FromArgb(145, 181, 198), LinearGradientMode.Vertical), innerRect);

            StringFormat sf = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis);
            cache.DrawString(header.Caption, app.Font, Color.White, innerRect, sf);
            e.Handled = true;
        }

        private void schedulerControl_CustomDrawGroupSeparator(object sender, DevExpress.XtraScheduler.CustomDrawObjectEventArgs e) {
            if (!chkGroupSeparator.Checked)
                return;
            Color c = Color.FromArgb(0xC4, 0xA6, 0xF4);
            GraphicsCache cache = e.Cache;
            FillGradient(cache, e.Bounds, Color.FromArgb(0xE0, 0xCF, 0xE9), c, 45);
            cache.DrawRectangle(cache.GetPen(c), e.Bounds);
            e.Handled = true;
        }

        private void schedulerControl_CustomDrawDayViewAllDayArea(object sender, DevExpress.XtraScheduler.CustomDrawObjectEventArgs e) {
            if (!chkDayViewAllDayArea.Checked)
                return;
            GraphicsCache cache = e.Cache;
            SelectableIntervalViewInfo viewInfo = e.ObjectInfo as SelectableIntervalViewInfo;
            if (viewInfo != null && viewInfo.Selected) {
                cache.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                DrawAllDayAreaCaption(e, SystemBrushes.HighlightText);
            } else {
                FillGradient(cache, e.Bounds, Color.FromArgb(215, 233, 171), Color.FromArgb(185, 203, 141), 90);
                DrawAllDayAreaCaption(e, Brushes.Black);
            }
            e.Handled = true;
        }
        void DrawAllDayAreaCaption(CustomDrawObjectEventArgs e, Brush br) {
            AppearanceObject app = schedulerControl.Appearance.HeaderCaption;
            StringFormat sf = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis);
            e.Cache.DrawString("All Day Events", schedulerControl.DayView.Appearance.AllDayArea.Font, br, e.Bounds, sf);
        }

        private void OnCheckedChanged(object sender, System.EventArgs e) {
            schedulerControl.ActiveView.LayoutChanged();
        }

        private void schedulerControl_CustomDrawNavigationButton(object sender, CustomDrawObjectEventArgs e) {
            if (!chkNavigationButton.Checked)
                return;
            NavigationButton button = e.ObjectInfo as NavigationButton;
            Brush bgBrush;
            if (button.Enabled) {
                if (button.HotTracked)
                    bgBrush = new LinearGradientBrush(e.Bounds, Color.FromArgb(100, 200, 150), Color.FromArgb(150, 240, 150), LinearGradientMode.Horizontal);
                else
                    bgBrush = new LinearGradientBrush(e.Bounds, Color.FromArgb(100, 180, 150), Color.FromArgb(150, 220, 150), LinearGradientMode.Horizontal);
            } else
                bgBrush = new LinearGradientBrush(e.Bounds, Color.FromArgb(100, 160, 150), Color.FromArgb(150, 160, 150), LinearGradientMode.Horizontal);

            Pen borderPen = button.Enabled ? Pens.Green : Pens.Gray;
            Brush textBrush = button.Enabled ? SystemBrushes.ActiveCaptionText : SystemBrushes.InactiveCaptionText;

            GraphicsCache cache = e.Cache;
            cache.FillRectangle(bgBrush, e.Bounds);
            cache.DrawRectangle(borderPen, e.Bounds);
            AppearanceObject app = button.Appearance;
            StringFormat sf = app.TextOptions.GetStringFormat(TextOptions.DefaultOptionsCenteredWithEllipsis);
            cache.DrawVString(button.DisplayText, app.Font, textBrush, e.Bounds, sf, 270);
            e.Handled = true;
        }
        private void schedulerControl_InitNewAppointment(object sender, AppointmentEventArgs e) {
            e.Appointment.StatusKey = 0;
        }
        private void schedulerControl_GroupTypeChanged(object sender, EventArgs e) {
            UpdateControls();
        }
    }
}

