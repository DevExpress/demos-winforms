using DevExpress.ApplicationUI.Demos.VisualEffects.Badges;
using DevExpress.DXperience.Demos;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Design;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Svg;
using DevExpress.Utils.VisualEffects;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.ApplicationUI.Demos.VisualEffects {
    public partial class ModuleBadges : TutorialControl {
        Color unreadTextColor;
        TileItem current;
        public ModuleBadges() {
            InitializeComponent();
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
        }
        protected override int TakeScreenDelay => 500;
        private void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            unreadTextColor = CommonColors.GetQuestionColor(LookAndFeel);
            InitTileItems();
            SelectPage(current);
        }
        delegate void InvokeMethod();
        private void ModuleBadges_Load(object sender, EventArgs e) {
            dashboardItem.Tag = navigationPage1;
            calendarItem.Tag = navigationPage2;
            mailItem.Tag = navigationPage3;
            unreadTextColor = CommonColors.GetQuestionColor(LookAndFeel);
            InitBadges();
            navigationTileControl.Paint += OnPaint;
            InitTileItems();
            InitAppointments();
            InitScheduller();
            schedulerControl1.Start = TutorialConstants.Now;
            schedulerControl1.DayView.TopRowTime = new TimeSpan(8, 0, 0);
            current = dashboardItem;
            SelectPage(current);
            gridControl1.DataSource = SourceHelper.GetMessages();
        }
        private void InitBadges() {
            InitBadge(dashMainBadge, "3", dashboardItem);
            InitBadge(dashClockBadge, "2", clockItem);
            InitBadge(dashSettingsBadge, "1", settingsItem);
            InitBadge(calendarMainBadge, "4", calendarItem);
            InitBadge(mailMainBadge, "6", mailItem);
        }
        private void InitBadge(Badge badge, string text, TileItem target) {
            badge.Properties.BeginUpdate();
            badge.Properties.PaintStyle = BadgePaintStyle.Critical;
            badge.Properties.Location = ContentAlignment.TopRight;
            badge.TargetElement = target;
            badge.Properties.Text = text;
            badge.Properties.EndUpdate();
        }
        private void InitScheduller() {
            schedulerControl1.HandleCreated += SchedulerControl1_HandleCreated;
            schedulerControl1.SizeChanged += (sender, e) => schedulerControl1.DateNavigationBar.Panel.Invalidate();
        }
        private void SchedulerControl1_HandleCreated(object sender, EventArgs e) {
            schedulerControl1.DateNavigationBar.Panel = new SchedulerCustomPanel(schedulerControl1) { ImageCollection = svgImageCollection1 };
        }
        private void SelectPage(TileItem tile) {
            current = tile;
            UpdateSelection();
            navigationFrame1.SelectedPage = (NavigationPage)tile.Tag;
        }
        private void UpdateSelection() {
            UpdateTileContent(dashboardItem, current == dashboardItem, "Dashboard");
            UpdateTileContent(calendarItem, current == calendarItem, "Calendar");
            UpdateTileContent(mailItem, current == mailItem, "Mail");
            UpdateTileContent(notesItem, current == notesItem, "Notes");
        }
        private void UpdateTileContent(TileItem item, bool highlight, string imageKey) {
            item.ImageOptions.SvgImageColorizationMode = SvgImageColorizationMode.Default;
            item.ImageOptions.SvgImage = null;
            Color frColor = highlight ? CommonColors.GetSystemColor("HighlightText") : GetSkinColor("ControlText");
            Color bkColor = highlight ? GetSkinColor("Question") : Color.Transparent;
            item.AppearanceItem.Normal.ForeColor = frColor;
            item.AppearanceItem.Normal.BackColor = bkColor;
            item.AppearanceItem.Normal.BorderColor = bkColor;
            if(highlight) {
                imageKey += "H";
                item.ImageOptions.SvgImageColorizationMode = SvgImageColorizationMode.None;
            }
            item.ImageOptions.SvgImage = svgImageCollection2[imageKey];
        }
        private void OnSizeChanged(object sender, EventArgs e) {
            int tileHeight = (dashTiles.Height - ScaleDPI.ScaleVertical(dashTiles.IndentBetweenItems)) / 3;
            int vertPadding = tileHeight / 2;
            int horzPadding = (dashTiles.Width - tileHeight * 3 - 2 * dashTiles.IndentBetweenItems) / 2;
            dashTiles.ItemSize = (int)(tileHeight / ScaleDPI.ScaleFactorVert);
            dashTiles.Padding = new Padding(horzPadding, vertPadding, horzPadding, vertPadding);
            UpdateBadges();
        }
        private void OnPaint(object sender, EventArgs e) {
            UpdateBadges();
        }
        private void InitTileItems() {
            Color bkColor = CommonColors.GetQuestionColor(LookAndFeel);
            InitTileItem(dashboardItem, 9F, 10);
            InitTileItem(calendarItem, 9F, 10);
            InitTileItem(mailItem, 9F, 10);
            InitTileItem(notesItem, 9F, 10);
            InitDashboardTileItem(clockItem, "Alarms", bkColor);
            InitDashboardTileItem(calculatorItem, "Calculator", bkColor);
            InitDashboardTileItem(weatherItem, "Weather", bkColor);
            InitDashboardTileItem(photosItem, "Photos", bkColor);
            InitDashboardTileItem(mapsItem, "Map", bkColor);
            InitDashboardTileItem(settingsItem, "settings", bkColor);
        }
        private void InitDashboardTileItem(TileItem tile, string imageKey, Color bkColor) {
            InitTileItem(tile, 10F, 15);
            tile.AppearanceItem.Normal.BackColor = bkColor;
            tile.AppearanceItem.Normal.BorderColor = bkColor;
            tile.ImageOptions.SvgImageColorizationMode = SvgImageColorizationMode.None;
            tile.ImageOptions.SvgImage = svgImageCollection2[imageKey];
            tile.ImageOptions.SvgImageSize = new Size(48, 48);
        }
        private void InitTileItem(TileItem tile, float textSize, int indent) {
            tile.ImageToTextIndent = indent;
            tile.AppearanceItem.Normal.Font = new Font("Segoe UI", textSize);
        }
        private void UpdateBadges() {
            SetBadgeOffset(dashClockBadge, clockItem, 4, 5);
            SetBadgeOffset(dashSettingsBadge, settingsItem, 0, 9);
            SetBadgeOffset(dashMainBadge, dashboardItem, 0, 9);
            SetBadgeOffset(calendarMainBadge, calendarItem, 0, 9);
            SetBadgeOffset(mailMainBadge, mailItem, 0, 9);
        }
        private void SetBadgeOffset(Badge badge, TileItem tile, int deltaX, int deltaY) {
            int delta = tile.ImageOptions.SvgImageSize.Width / 2;
            var rect = ((ISupportAdornerElement)tile).Bounds;
            int x = ScaleDPI.DeScaleHorizontal(rect.Width) / 2 - delta;
            int y = ScaleDPI.DeScaleHorizontal(rect.Height) / 2 - delta;
            badge.Properties.Offset = new Point(-x - deltaX, y - deltaY);
        }
        private Color GetSkinColor(string name) {
            return CommonSkins.GetSkin(LookAndFeel).Colors[name];
        }
        private void DashboardItemClick(object sender, TileItemEventArgs e) {
            SelectPage(dashboardItem);
        }
        private void CalendarItemClick(object sender, TileItemEventArgs e) {
            SelectPage(calendarItem);
        }
        private void MailItemClick(object sender, TileItemEventArgs e) {
            SelectPage(mailItem);
        }
        private void NotesItemClick(object sender, TileItemEventArgs e) {
        }
        private void InitAppointments() {
            AppointmentMappingInfo mappings = this.schedulerDataStorage1.Appointments.Mappings;
            mappings.Start = "StartTime";
            mappings.End = "EndTime";
            mappings.Subject = "Subject";
            mappings.AllDay = "AllDay";
            mappings.Description = "Description";
            mappings.Label = "Label";
            mappings.Location = "Location";
            mappings.RecurrenceInfo = "RecurrenceInfo";
            mappings.ReminderInfo = "ReminderInfo";
            mappings.ResourceId = "OwnerId";
            mappings.Status = "Status";
            mappings.Type = "EventType";
            schedulerDataStorage1.Appointments.DataSource = SourceHelper.GetEvents();
        }
        private void tileView1_ItemCustomize(object sender, XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e) {
            Badges.Message msg = tileView1.GetRow(e.RowHandle) as Badges.Message;
            if(msg != null) {
                if(!msg.Read) {
                    e.Item["Date"].Appearance.Normal.ForeColor = unreadTextColor;
                    e.Item["Subject"].Appearance.Normal.ForeColor = unreadTextColor;
                    e.Item["Subject"].Appearance.Normal.FontStyleDelta = FontStyle.Bold;
                }
            }
        }
        protected override bool? AllowBorderRounding { get { return true; } }
    }
}
namespace DevExpress.ApplicationUI.Demos.VisualEffects.Badges {
    public class SchedulerCustomPanel : XtraUserControl, ISchedulerDateNavigationBarPanel {
        Font textFont = new Font("Segoe UI", 8.25F, FontStyle.Bold);
        SchedulerControl _schedulerControl;
        SvgImageCollection _imageCollection;
        string _caption;
        Color _backColor;
        public SchedulerCustomPanel(SchedulerControl schedulerControl) {
            this._schedulerControl = schedulerControl;
        }
        [DefaultValue(null)]
        public SchedulerControl SchedulerControl {
            get { return _schedulerControl; }
            set { _schedulerControl = value; }
        }
        public Size CalcBestSize() {
            return ScaleDPI.ScaleSize(new Size(_schedulerControl.DateNavigationBar.Panel.Width, 36));
        }
        protected override void Dispose(bool disposing) {
            base.Dispose(disposing);
            _schedulerControl = null;
        }
        public void Recalculate(DateNavigationBarViewInfo viewInfo) {
            _caption = viewInfo.Caption;
            _backColor = viewInfo.BackColor;
        }
        [DefaultValue(null)]
        public SvgImageCollection ImageCollection {
            get { return _imageCollection; }
            set { _imageCollection = value; }
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            using(GraphicsCache cache = new GraphicsCache(e.Graphics)) {
                cache.Clear(_backColor);
                DrawText(cache);
                ISvgPaletteProvider provider = SvgPaletteHelper.GetSvgPalette(_schedulerControl.LookAndFeel, ObjectState.Disabled);
                Image backImage = _imageCollection.GetImage(0, provider, ScaleDPI.ScaleSize(new Size(16, 16)));
                Image forwardImage = _imageCollection.GetImage(1, provider, ScaleDPI.ScaleSize(new Size(16, 16)));
                int imageIndent = Bounds.Height / 2 - backImage.Size.Height / 2;
                cache.DrawImage(backImage, new Point(imageIndent, imageIndent));
                cache.DrawImage(forwardImage, new Point(Bounds.Right - forwardImage.Size.Width - imageIndent, imageIndent));
            }
        }
        void DrawText(GraphicsCache cache) {
            Color textColor = CommonSkins.GetSkin(LookAndFeel).GetSystemColor(SystemColors.ControlText);
            Size textSize = cache.CalcTextSize(_caption, textFont).ToSize();
            float textX = Bounds.Width / 2 - textSize.Width / 2;
            float textY = Bounds.Height / 2 - textSize.Height / 2;
            cache.DrawString(_caption, textFont, cache.GetSolidBrush(textColor), new PointF(textX, textY));
        }
    }
    class SourceHelper {
        public static BindingList<CustomAppointment> GetEvents() {
            BindingList<CustomAppointment> eventList = new BindingList<CustomAppointment>();
            eventList.Add(new CustomAppointment() {
                StartTime = TutorialConstants.Today + TimeSpan.FromMinutes(9.5 * 60),
                EndTime = TutorialConstants.Today + TimeSpan.FromMinutes(11 * 60),
                Subject = "Customer retention review",
                Description = "Discuss ways in which we can improve relationship with customers and prove to them that we are long term source for all their A/V needs.",
                Label = 1
            });

            eventList.Add(new CustomAppointment() {
                StartTime = TutorialConstants.Today + TimeSpan.FromMinutes(11.5 * 60),
                EndTime = TutorialConstants.Today + TimeSpan.FromMinutes(13 * 60),
                Subject = "Lunch with Arthur Doyle",
                Description = "Has some information on our main competitor. Need to discuss a position within our company as he would be a great asset going forward"
            });

            eventList.Add(new CustomAppointment() {
                StartTime = TutorialConstants.Today + TimeSpan.FromMinutes(13.5 * 60),
                EndTime = TutorialConstants.Today + TimeSpan.FromMinutes(15 * 60),
                Subject = "Accountant review",
                Description = "Prepare for accountants. Review P&L for last few mounths. Balance sheet must also be reviewed and questions for accountants formulated.",
                Label = 2
            });

            eventList.Add(new CustomAppointment() {
                StartTime = TutorialConstants.Today + TimeSpan.FromMinutes(15 * 60),
                EndTime = TutorialConstants.Today + TimeSpan.FromMinutes(17 * 60),
                Subject = "French lesson",
                Description = "If we are to have any chance in France, salespeople must learn french. Practice makes perfect and without constant repetition, learning a new language is impossible."
            });
            return eventList;
        }
        public static BindingList<Message> GetMessages() {
            BindingList<Message> messages = new BindingList<Message>();
            messages.Add(new Message() {
                Date = TutorialConstants.Now,
                From = "Mary Stern",
                Subject = "My Favorite Resort in Las Vegas",
                Text = "I know there are many impressive hotels in the city, but I just love the Eiffel Tower. It reminds me of the summer I spent in Paris studying at the Sorbonne."
            });
            messages.Add(new Message() {
                Date = TutorialConstants.Now,
                From = "Olivia Peyton",
                Subject = "Your Favorite Snakespeare Play",
                Text = "We’ve got an open poll and you are the only two who have yet to respond. Which is your favorite Shakespeare play?"
            });
            messages.Add(new Message() {
                Date = TutorialConstants.Now,
                From = "Cindy Stanwick",
                Subject = "Roy Orbison is my favorite",
                Text = "I was surprised to find out that you are not related to Roy Orbison. Sandra told me you were… In any event, you should listen to some of his music…he was a trail blazer."
            });
            messages.Add(new Message() {
                Read = true,
                Date = TutorialConstants.Now.AddHours(-25),
                From = "Brett Wade",
                Subject = "Cabling and Termination",
                Text = "Good Afternoon. Taylor, you need to learn how to terminate twisted - pair cables.I neither have the time nor the patience to teach you.Search the web and you’ll come across countless tutorials."
            });
            messages.Add(new Message() {
                Date = TutorialConstants.Now.AddHours(-26),
                From = "Harv Mudd",
                Subject = "Online Sales are Growing",
                Text = "Hello Hannah Looks like online sales continue to outpace expectations.What accounts for the increase? Do you see anything that might disrupt growth in the coming year ? "
            });
            messages.Add(new Message() {
                Read = true,
                Date = TutorialConstants.Now.AddHours(-26),
                From = "Anthony Remmen",
                Subject = "Wikipedia Syas I'm Right",
                Text = "I told you I was right…The longest river in the world is the Nile. The Nile is a major north - flowing river in northeastern Africa, and is commonly regarded as the longest river in the world, though some sources claim that the Amazon River is longer.The Nile, which is 6, 853 km(4, 258 miles) long, is an international river as its drainage basin covers eleven countries, namely, Tanzania, Uganda, Rwanda, Burundi, the Democratic Republic of the Congo, Kenya, Ethiopia, Eritrea, South Sudan, Sudan and Egypt.In particular, the Nile is the primary water source of Egypt and Sudan."
            });
            messages.Add(new Message() {
                Date = TutorialConstants.Now.AddHours(-26),
                From = "Clark Morgan",
                Subject = "Circut Town Orders",
                Text = "Hey Todd. Circuit Town has been ordering a lot of products recently.Did you thank them already or did you want me to reach out? Please advise."
            });
            messages.Add(new Message() {
                Date = TutorialConstants.Now.AddHours(-26),
                From = "Bart Arnaz",
                Subject = "My All-time Favorite Quote",
                Text = "Here is the exact quote from Calvin Coolidge…please share it with those who might benefit… Nothing in this world can take the place of persistence.Talent will not: nothing is more common than unsuccessful men with talent.Genius will not; unrewarded genius is almost a proverb.Education will not: the world is full of educated derelicts. Persistence and determination alone are omnipotent."
            });
            messages.Add(new Message() {
                Read = true,
                Date = TutorialConstants.Now.AddHours(-26),
                From = "Stu Pizaro",
                Subject = "RE: Your Mailind Address",
                Text = "Hey Wally  You don’t have to send me a gift.I don’t like the fact that I’m getting old and birthday gifts are a reminder that I’m not as young as I used to be."
            });
            messages.Add(new Message() {
                Read = true,
                Date = TutorialConstants.Now.AddHours(-26),
                From = "Samantha Piper",
                Subject = "New Circuit Board Design",
                Text = "Hi Maggie  I hope you had a great time in Hawaii.I know you are busy catching up on email, but I did want to remind you that we have a meeting scheduled for 3PM to discuss our new circuit boards. Will you be able to make the meeting ? If you cannot attend, I will be more than happy to swing by your office and review the design with you. By the way, I still think we need to create a custom amplifier using vacuum tubes."
            });
            return messages;
        }
    }
    #region calendar data
    class CustomAppointment {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Subject { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public int Label { get; set; }
        public string Location { get; set; }
        public bool AllDay { get; set; }
        public int EventType { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public object OwnerId { get; set; }
    }
    #endregion
    #region mail data
    class Message {
        public DateTime Date { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        internal bool Read { get; set; }
    }
    #endregion
}
