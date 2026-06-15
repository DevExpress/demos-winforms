using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Filtering;
using DevExpress.XtraSplashScreen;
using System;
using System.ComponentModel;
using System.Drawing;

namespace DevExpress.XtraLayout.Demos {
    public partial class GroupStyle : TutorialControl {
        Color disabledColor = Color.Gray;
        IOverlaySplashScreenHandle viewNameSplashScreen = null;

        public GroupStyle() {
            InitializeComponent();
            gridControlAllTickets.DataSource = DataHelper.GetBestTickets();
            tileView2.Assign(tileView1, true);
            tileView2.OptionsTiles.HighlightFocusedTileStyle = XtraGrid.Views.Tile.HighlightFocusedTileStyle.None;
            UpdateColors();
            gridControlCheapestPrice.MaximumSize = new Size(0, 2 * ScaleHelper.ScaleHorizontal(tileView1.OptionsTiles.ItemSize.Height) + ScaleHelper.ScaleHorizontal(2));
            gridControlCheapestPrice.MinimumSize = new Size(ScaleHelper.ScaleHorizontal(500), 2 * ScaleHelper.ScaleHorizontal(tileView1.OptionsTiles.ItemSize.Height) + ScaleHelper.ScaleHorizontal(2));
            gridControlAllTickets.MinimumSize = new Size(ScaleHelper.ScaleHorizontal(500), 2 * ScaleHelper.ScaleHorizontal(tileView1.OptionsTiles.ItemSize.Height) + ScaleHelper.ScaleHorizontal(2));
        }

        void tileView1_CustomUnboundColumnData(object sender, XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            Ticket ticket = e.Row as Ticket;
            if(e.Column == colDepartTakeOffTimeSpan && e.IsGetData) {
                e.Value = new TimeSpan(ticket.Depart.TakeOff.Hour, ticket.Depart.TakeOff.Minute, 0);
            }
            if(e.Column == colDepartLandingTimeSpan && e.IsGetData) {
                e.Value = new TimeSpan(ticket.Depart.Landing.Hour, ticket.Depart.Landing.Minute, 0);
            }
            if(e.Column == colReturnTakeOffTimeSpan && e.IsGetData) {
                e.Value = new TimeSpan(ticket.Return.TakeOff.Hour, ticket.Return.TakeOff.Minute, 0);
            }
            if(e.Column == colReturnLandingTimeSpan && e.IsGetData) {
                e.Value = new TimeSpan(ticket.Return.Landing.Hour, ticket.Return.Landing.Minute, 0);
            }
        }
        void tileView1_ItemCustomize(object sender, XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e) {
            if(e.RowHandle % 2 == 0)
                e.Item.AppearanceItem.Normal.BackColor = SkinManager.GetSkinElement(SkinProductId.Grid, LookAndFeel, GridSkins.SkinGridOddRow).Color.GetBackColor();
            e.Item.GetElementByName(">").Appearance.Normal.ForeColor = disabledColor;
            e.Item["Depart.To"].Appearance.Normal.ForeColor = disabledColor;
            e.Item["Depart.From"].Appearance.Normal.ForeColor = disabledColor;
            e.Item["Depart.AirportFrom"].Appearance.Normal.ForeColor = disabledColor;
            e.Item["Depart.AirportTo"].Appearance.Normal.ForeColor = disabledColor;
            e.Item["Return.To"].Appearance.Normal.ForeColor = disabledColor;
            e.Item["Return.From"].Appearance.Normal.ForeColor = disabledColor;
            e.Item["Return.AirportFrom"].Appearance.Normal.ForeColor = disabledColor;
            e.Item["Return.AirportTo"].Appearance.Normal.ForeColor = disabledColor;
        }
        void timer1_Tick(object sender, EventArgs e) {
            Ticket chipTicket = null;
            Ticket prevChipTicket = null;
            for(int i = 0; i < tileView1.DataRowCount; i++) {
                Ticket rowObj = (Ticket)tileView1.GetRow(i);
                if(chipTicket == null)
                    chipTicket = rowObj;
                else {
                    if(rowObj.Depart.Price + rowObj.Return.Price < chipTicket.Depart.Price + chipTicket.Return.Price) {
                        prevChipTicket = chipTicket;
                        chipTicket = rowObj;
                    }
                }
            }
            layoutControlGroupBest.Text = string.Format("{0} flights found", tileView1.DataRowCount);
            layoutControlGroupCheapestPrice.Text = chipTicket == null ? "Cheapest" : "Cheapest ($" + (chipTicket.Depart.Price + chipTicket.Return.Price) + ")";
            BindingList<Ticket> bindingList = new BindingList<Ticket> { chipTicket };
            if(prevChipTicket != null)
                bindingList.Add(prevChipTicket);
            gridControlCheapestPrice.DataSource = bindingList;
        }
        void UpdateColors() {
            disabledColor = CommonSkins.GetSkin(LookAndFeel).GetSystemColor(SystemColors.GrayText);
        }
        protected override void DoShow() {
            base.DoShow();
            timer1.Enabled = true;
        }
        protected override void DoHide() {
            if(viewNameSplashScreen != null) {
                simpleButton1_Click(null, null);
            }
            timer1.Enabled = false;
            base.DoHide();
        }
        protected override void OnStyleChanged(EventArgs e) {
            base.OnStyleChanged(e);
            UpdateColors();
        }
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                if(viewNameSplashScreen != null) simpleButton1_Click(null, null);
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region ShowGroupStyles
        void CloseProgressPanel(IOverlaySplashScreenHandle handle) {
            try {
                SplashScreenManager.CloseOverlayForm(handle);
            }
            catch { }
        }
        IOverlaySplashScreenHandle ShowProgressPanel(OverlayWindowOptions windowOptions = null) {
            try {
                return SplashScreenManager.ShowOverlayForm(this, windowOptions ?? OverlayWindowOptions.Default);
            }
            catch { return null; }
        }
        ViewNamePainter _painter = null;
        ViewNamePainter ViewNamePainter {
            get {
                if(_painter == null)
                    _painter = new ViewNamePainter(GetTitleRect, GetLightRect, GetCardRect);
                return _painter;
            }
        }
        void simpleButton1_Click(object sender, EventArgs e) {
            if(viewNameSplashScreen != null) {
                CloseProgressPanel(viewNameSplashScreen);
                viewNameSplashScreen = null;
                simpleButton1.Text = "Show Group Styles";
            }
            else {
                viewNameSplashScreen = ShowProgressPanel(new OverlayWindowOptions(fadeIn: false, fadeOut: false, customPainter: ViewNamePainter));
                simpleButton1.Text = "Hide Group Styles";
            }
        }
        Rectangle GetTitleRect() {
            return layoutControl1.Bounds;
        }
        Rectangle GetCardRect() {
            Rectangle cardBounds = Rectangle.Union(layoutControlGroupWeather.ViewInfo.BoundsRelativeToControl, layoutControlGroupClock.ViewInfo.BoundsRelativeToControl);
            cardBounds.Location = Point.Add(cardBounds.Location, new Size(dataLayoutControl1.Location.X, dataLayoutControl1.Location.Y));
            return cardBounds;
        }
        Rectangle GetLightRect() {
            Rectangle lightBounds = Rectangle.Union(layoutControlGroupBest.ViewInfo.BoundsRelativeToControl, layoutControlGroupCheapestPrice.ViewInfo.BoundsRelativeToControl);
            lightBounds.Location = Point.Add(lightBounds.Location, new Size(dataLayoutControl1.Location.X, dataLayoutControl1.Location.Y));
            return lightBounds;
        }
        #endregion
    }

    public class ViewNamePainter : OverlayWindowPainterBase {
        static Font font = new Font("Segoe UI", 30f);
        //
        readonly Func<Rectangle> CardRectangle;
        readonly Func<Rectangle> LightRectangle;
        readonly Func<Rectangle> TitleRectangle;
        public ViewNamePainter(Func<Rectangle> titleRectangle, Func<Rectangle> lightRectangle, Func<Rectangle> cardRectangle) {
            CardRectangle = cardRectangle;
            LightRectangle = lightRectangle;
            TitleRectangle = titleRectangle;
        }
        public static void DrawInfo(GraphicsCache cache, string textToDraw, Rectangle rect, Color color) {
            cache.FillRectangle(cache.GetSolidBrush(Color.FromArgb(128, color)), rect);
            cache.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            cache.DrawString(textToDraw, font, Color.White, rect, AppearanceObject.ControlAppearance.GetStringFormat());
        }
        protected override void Draw(OverlayWindowCustomDrawContext context) {
            context.Handled = true;
            context.DrawArgs.Cache.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            DrawInfo(context.DrawArgs.Cache, "Light Style", LightRectangle.Invoke(), Color.FromArgb(17, 119, 215)/* CommonColors.GetCriticalColor(provider)*/);
            DrawInfo(context.DrawArgs.Cache, "Title Style", TitleRectangle.Invoke(), Color.FromArgb(209, 28, 28)/*CommonColors.GetInformationColor(provider)*/);
            DrawInfo(context.DrawArgs.Cache, "Card Style", CardRectangle.Invoke(), Color.FromArgb(3, 156, 35)/*CommonColors.GetQuestionColor(provider)*/);
        }
    }
    //
    public static class DataHelper {
        public static BindingList<Ticket> GetBestTickets() {
            BindingList<Ticket> tickets = new BindingList<Ticket>();
            //M-L
            for(int i = 0; i < 10; i++) {
                tickets.Add(new Ticket {
                    Depart = GetFlight("MAD", "LHR", "Madrid", "London", 7, 35, 9, 45, 4 + i * 2, 260),
                    Return = GetFlight("LHR", "MAD", "London", "Madrid", 13, 25, 19, 05, 11 + i * 3, 275)
                });
                tickets.Add(new Ticket {
                    Return = GetFlight("MAD", "LHR", "Madrid", "London", 7, 35, 9, 45, 11 + i * 2, 275),
                    Depart = GetFlight("LHR", "MAD", "London", "Madrid", 13, 25, 19, 05, 4 + i * 3, 260)
                });
            }
            for(int i = 0; i < 10; i++) {
                tickets.Add(new Ticket {
                    Depart = GetFlight("BCN", "LHR", "Barcelona", "London", 18, 10, 20, 20, 1 + i, 310),
                    Return = GetFlight("LHR", "BCN", "London", "Barcelona", 22, 35, 28, 20, 4 + i * 2, 295)
                });
                tickets.Add(new Ticket {
                    Return = GetFlight("BCN", "LHR", "Barcelona", "London", 18, 10, 20, 20, 8 + i, 295),
                    Depart = GetFlight("LHR", "BCN", "London", "Barcelona", 22, 35, 28, 20, 3 + i * 2, 310)
                });
            }
            //L-NY
            for(int i = 0; i < 10; i++) {
                tickets.Add(new Ticket {
                    Depart = GetFlight("STN", "JFK", "London", "New York", 17, 20, 23, 25, 3 + i, 250),
                    Return = GetFlight("JFK", "STN", "New York", "London", 00, 40, 16, 15, 8 + i * 2, 245)
                });
                tickets.Add(new Ticket {
                    Return = GetFlight("STN", "JFK", "London", "New York", 17, 20, 23, 25, 8 + i, 245),
                    Depart = GetFlight("JFK", "STN", "New York", "London", 00, 40, 16, 15, 3 + i * 2, 250)
                });
            }
            for(int i = 0; i < 10; i++) {
                tickets.Add(new Ticket {
                    Depart = GetFlight("LHR", "EWR", "London", "New York", 18, 00, 21, 00, 5 + i, 280),
                    Return = GetFlight("EWR", "LHR", "New York", "London", 00, 40, 16, 15, 10 + i, 310)
                });
                tickets.Add(new Ticket {
                    Return = GetFlight("LHR", "EWR", "London", "New York", 18, 00, 21, 00, 10 + i, 310),
                    Depart = GetFlight("EWR", "LHR", "New York", "London", 00, 40, 16, 15, 5 + i, 280)
                });
            }
            //M-NY
            for(int i = 0; i < 20; i++) {
                tickets.Add(new Ticket {
                    Depart = GetFlight("MAD", "JFK", "Madrid", "New York", 9, 20, 12, 05, 3 + i, 320),
                    Return = GetFlight("JFK", "MAD", "New York", "Madrid", 00, 40, 16, 15, 8 + i * 2, 300)
                });
                tickets.Add(new Ticket {
                    Return = GetFlight("MAD", "JFK", "Madrid", "New York", 9, 20, 12, 05, 8 + i, 300),
                    Depart = GetFlight("JFK", "MAD", "New York", "Madrid", 00, 40, 16, 15, 3 + i * 2, 320)
                });
            }
            return tickets;
        }
        public static Flight GetFlight(string airFrom, string airTo, string from, string to, int takeHour, int takeMin, int landHour, int landMin, int dateOffset, decimal basePrice) {
            return new Flight {
                AirportFrom = airFrom,
                AirportTo = airTo,
                From = from,
                To = to,
                TakeOff = DateTime.Now.Date + new TimeSpan(dateOffset, takeHour, takeMin, 0),
                Landing = DateTime.Now.Date + new TimeSpan(dateOffset, landHour, landMin, 0),
                Price = basePrice + DevExpress.Data.Utils.NonCryptographicRandom.Default.Next(-20, 20)
            };
        }
    }
    public class Flight {
        [FilterLookup(UseSelectAll = false)]
        public string AirportFrom { get; set; }
        [FilterLookup(UseSelectAll = false)]
        public string AirportTo { get; set; }
        [FilterLookup(UseSelectAll = false)]
        public string From { get; set; }
        public DateTime Landing { get; set; }
        public decimal Price { get; set; }
        public DateTime TakeOff { get; set; }
        [FilterLookup(UseSelectAll = false)]
        public string To { get; set; }
    }
    public class Ticket {
        public Flight Depart { get; set; }
        public Flight Return { get; set; }
    }
}
