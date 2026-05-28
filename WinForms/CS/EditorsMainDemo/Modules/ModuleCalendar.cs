using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleCalendar : TutorialControl {
        public ModuleCalendar() {
            InitializeComponent();
            InitComboBoxes();
            InitValues();
            InitCellDataProvider();
            if(tabPane1 != null)
                tabPane1.SelectedPageChanged += OnSelectedPageChanged;
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleCalendar" }; } }
        protected override string WhatsThisXMLFileName { get { return "calendar"; } }

        void OnSelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            CalcContentCore();
        }
        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            if(tabPane1 != null)
                tabPane1.SelectedPageChanged -= OnSelectedPageChanged;
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            if(layoutControl1 == null || !layoutControl1.IsHandleCreated) return;
            layoutControl1.Size = GetLayoutControlSize();
            CalcModuleContent();
        }
        void InitCellDataProvider() {
            this.calendarControl2.CellStyleProvider = new MyCellStyleProvider();
        }

        protected override bool AllowCenterControls {
            get { return false; }
        }

        void InitComboBoxes() {
            icbVistaDisplayMode.Properties.Items.AddEnum(typeof(CalendarView));
            icbVistaDisplayMode.SelectedIndexChanged += cbVistaDisplayMode_SelectedIndexChanged;
            icbShowVistaClock.Properties.Items.AddEnum(typeof(DefaultBoolean));
            icbWeekNumberRule.Properties.Items.AddEnum(typeof(WeekNumberRule));
            icbShowInactiveDays.Properties.Items.AddEnum(typeof(CalendarInactiveDaysVisibility));
            icbFirstDayOfWeek.Properties.Items.AddEnum(typeof(DayOfWeek));
            icbRowCount.Properties.Items.Add(new ImageComboBoxItem("Auto", 0));
            icbRowCount.Properties.Items.Add(new ImageComboBoxItem("1", 1));
            icbRowCount.Properties.Items.Add(new ImageComboBoxItem("2", 2));
            icbRowCount.Properties.Items.Add(new ImageComboBoxItem("3", 3));
            icbColumnCount.Properties.Items.Add(new ImageComboBoxItem("Auto", 0));
            icbColumnCount.Properties.Items.Add(new ImageComboBoxItem("1", 1));
            icbColumnCount.Properties.Items.Add(new ImageComboBoxItem("2", 2));
            icbColumnCount.Properties.Items.Add(new ImageComboBoxItem("3", 3));
            ceShowMonthName.Enabled = false;
        }

        void cbVistaDisplayMode_SelectedIndexChanged(object sender, EventArgs e) {
            this.calendarControl1.AllowAnimatedContentChange = false;
            this.calendarControl1.View = DateEditCalendarViewType.MonthInfo;
            this.calendarControl1.AllowAnimatedContentChange = true;
        }

        bool updateValues;
        void InitValues() {
            updateValues = true;
            calendarControl1.DateTime = TutorialConstants.Now;
            icbVistaDisplayMode.EditValue = calendarControl1.CalendarView;
            icbShowVistaClock.EditValue = calendarControl1.CalendarTimeEditing;
            icbWeekNumberRule.EditValue = calendarControl1.WeekNumberRule;
            icbShowInactiveDays.EditValue = calendarControl1.InactiveDaysVisibility;
            ceShowClear.Checked = calendarControl1.ShowClearButton;
            ceShowToday.Checked = calendarControl1.ShowTodayButton;
            ceShowWeekNumbers.Checked = calendarControl1.ShowWeekNumbers;
            ceShowHeader.Checked = calendarControl1.ShowHeader;
            ceShowFooter.Checked = calendarControl1.ShowFooter;
            ceShowWeekNumbers.Checked = calendarControl1.ShowWeekNumbers;

            icbFirstDayOfWeek.EditValue = calendarControl1.FirstDayOfWeek;
            icbRowCount.SelectedIndex = 1;
            icbColumnCount.SelectedIndex = 1;

            updateValues = false;
        }

        void ceShowHeader_CheckedChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            this.calendarControl1.ShowHeader = ceShowHeader.Checked;
        }

        void ceShowFooter_CheckedChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            this.calendarControl1.ShowFooter = ceShowFooter.Checked;
        }

        void ceShowMonthName_CheckedChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            this.calendarControl1.ShowMonthHeaders = ceShowMonthName.Checked;
        }

        void ceShowClear_CheckedChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            this.calendarControl1.ShowClearButton = ceShowClear.Checked;
        }

        void ceShowToday_CheckedChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            this.calendarControl1.ShowTodayButton = ceShowToday.Checked;
        }

        void ceShowWeekNumbers_CheckedChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            this.calendarControl1.ShowWeekNumbers = ceShowWeekNumbers.Checked;
        }

        void icbVistaDisplayMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues)
                return;
            CalendarView view = (CalendarView)((ImageComboBoxItem)icbVistaDisplayMode.SelectedItem).Value;
            this.calendarControl1.CalendarView = view;
            if(view == CalendarView.Classic || view == CalendarView.ClassicNew || view == CalendarView.Vista) {
                this.ceShowToday.Enabled = true;
                this.ceShowClear.Enabled = true;
            }
            else {
                this.ceShowToday.Enabled = false;
                this.ceShowClear.Enabled = false;
            }
        }

        void icbShowVistaClock_SelectedIndexChanged(object sender, EventArgs e) {
            DefaultBoolean value = (DefaultBoolean)((ImageComboBoxItem)icbShowVistaClock.SelectedItem).Value;
            this.calendarControl1.CalendarTimeEditing = value;
        }

        void icbWeekNumberRule_SelectedIndexChanged(object sender, EventArgs e) {
            WeekNumberRule value = (WeekNumberRule)((ImageComboBoxItem)icbWeekNumberRule.SelectedItem).Value;
            this.calendarControl1.WeekNumberRule = value;
        }

        void icbFirstDayOfWeek_SelectedIndexChanged(object sender, EventArgs e) {
            DayOfWeek value = (DayOfWeek)((ImageComboBoxItem)icbFirstDayOfWeek.SelectedItem).Value;
            this.calendarControl1.FirstDayOfWeek = value;
        }

        void icbShowInactiveDays_SelectedIndexChanged(object sender, EventArgs e) {
            CalendarInactiveDaysVisibility value = (CalendarInactiveDaysVisibility)((ImageComboBoxItem)icbShowInactiveDays.SelectedItem).Value;
            this.calendarControl1.InactiveDaysVisibility = value;
        }

        protected void UpdateInactiveDaysVisibility() {
            if(this.calendarControl1.RowCount > 1 || this.calendarControl1.ColumnCount > 1)
                this.icbShowInactiveDays.EditValue = CalendarInactiveDaysVisibility.FirstLast;
        }

        void icbRowCount_SelectedIndexChanged(object sender, EventArgs e) {
            int value = icbRowCount.SelectedIndex;
            this.calendarControl1.RowCount = value;
            this.ceShowMonthName.Enabled = this.calendarControl1.RowCount * this.calendarControl1.ColumnCount > 1;
            UpdateInactiveDaysVisibility();
            UpdateCalendarControlSizingMode();
        }

        void UpdateCalendarControlSizingMode() {
            if(this.calendarControl1.ColumnCount == 0 || this.calendarControl1.RowCount == 0)
                MakeCalendarControlSizeable();
            else
                MakeCalendarControlAutoSize();
        }

        protected Rectangle GetCalendarClientRect() {
            int _padding = ScaleDPI.ScaleHorizontal(32);
            return new Rectangle(this.tabNavigationPage1.ClientRectangle.X + _padding, this.tabNavigationPage1.ClientRectangle.Y + _padding,
                this.tabNavigationPage1.ClientRectangle.Width - GetLayoutControlSize().Width - _padding * 3, this.tabNavigationPage1.ClientRectangle.Height - _padding * 2);
        }

        void MakeCalendarControlAutoSize() {
            this.calendarControl1.AutoSize = true;
            this.calendarControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Rectangle rect = GetCalendarClientRect();
            this.calendarControl1.Location = new Point(rect.X + (rect.Width - this.calendarControl1.Width) / 2, rect.Y + (rect.Height - this.calendarControl1.Height) / 2);
        }

        void MakeCalendarControlSizeable() {
            this.calendarControl1.AutoSize = false;
            this.calendarControl1.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Rectangle rect = GetCalendarClientRect();
            this.calendarControl1.Bounds = rect;
        }

        void icbColumnCount_SelectedIndexChanged(object sender, EventArgs e) {
            int value = icbColumnCount.SelectedIndex;
            this.calendarControl1.ColumnCount = value;
            this.ceShowMonthName.Enabled = this.calendarControl1.RowCount * this.calendarControl1.ColumnCount > 1;
            UpdateInactiveDaysVisibility();
            UpdateCalendarControlSizingMode();
        }

        int Indent { get { return ScaleDPI.ScaleHorizontal(16); } }
        void xtraTabPage1_Resize(object sender, EventArgs e) {
            CalcModuleContent();
        }

        protected void CalcModuleContent() {
            if(layoutControl1 == null || !layoutControl1.IsHandleCreated) return;
            Size layoutControlBestSize = GetLayoutControlSize();
            this.layoutControl1.Location = new Point(this.tabNavigationPage1.ClientRectangle.Width - layoutControlBestSize.Width - Indent, this.tabNavigationPage1.ClientRectangle.Y + Math.Max(Indent, (this.tabNavigationPage1.ClientRectangle.Height - layoutControlBestSize.Height) / 2));
            UpdateCalendarControlSizingMode();
        }
        protected Size GetLayoutControlSize() {
            Size _size = layoutControl1.GetPreferredSize(Size.Empty);
            return new Size(Math.Min(_size.Width, this.tabNavigationPage1.ClientRectangle.Width - 2 * Indent), Math.Min(_size.Height, this.tabNavigationPage1.ClientRectangle.Height - 2 * Indent));
        }

        void calendarControl1_Resize(object sender, EventArgs e) {
            UpdateCalendarControlSizingMode();
        }

        void calendarControl2_ContextButtonCustomize(object sender, CalendarContextButtonCustomizeEventArgs e) {
            MyCellStyleProvider provider = (MyCellStyleProvider)this.calendarControl2.CellStyleProvider;
            MyCustomCellData data = provider.GetCell(e.Cell.Date);
            if(data == null || string.IsNullOrEmpty(data.InfoText)) {
                e.Item.Visibility = ContextItemVisibility.Hidden;
                return;
            }
            e.Item.AllowGlyphSkinning = DefaultBoolean.True;
            e.Item.Tag = data;
            e.Item.ImageOptions.SvgImage = data.SvgGlyph;
        }

        void calendarControl2_ContextButtonClick(object sender, ContextItemClickEventArgs e) {
            MyCustomCellData data = (MyCustomCellData)e.Item.Tag;
            if(data == null)
                return;
            this.memoEdit1.Text = data.InfoText;
            this.flyoutPanel1.ShowBeakForm(new Point(e.ScreenBounds.X + e.ScreenBounds.Width / 2, e.ScreenBounds.Top - 5));
        }

        void calendarControl1_SelectionChanged(object sender, EventArgs e) {
            this.listBoxControl1.BeginUpdate();
            try {
                this.listBoxControl1.Items.Clear();
                foreach(XtraEditors.Controls.DateRange range in this.calendarControl1.SelectedRanges) { 
                    this.listBoxControl1.Items.Add(range.StartDate.ToShortDateString() + " - " + range.EndDate.ToShortDateString());
                }
            }
            finally {
                this.listBoxControl1.EndUpdate();
            }
        }
    }

    public enum CellDataType { Undefined, Work, Family, Event }

    public class MyCustomCellData {
        public DateTime Date { get; set; }
        public SvgImage SvgGlyph { get; set; }
        public string InfoText { get; set; }
        public CellDataType CellType { get; set; }

        public string Description { get; set; }
        public bool SpecialDate { get; set; }
    }

    public class MyCellStyleProvider : ICalendarCellStyleProvider {

        List<MyCustomCellData> cellsCore;
        protected List<MyCustomCellData> Cells {
            get {
                if(cellsCore == null)
                    cellsCore = CreateCells();
                return cellsCore;
            }
        }

        protected virtual List<MyCustomCellData> CreateCells() {
            List <MyCustomCellData> res = new List<MyCustomCellData>();

            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 1), CellType = CellDataType.Work, InfoText = "Mexico City. Talks with Pure Products Inc.", SvgGlyph = DevExpress.XtraEditors.Demos.Properties.Resources.Flight });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 2), CellType = CellDataType.Work });

            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 4), SpecialDate = true, Description = "INDEPENDENCE DAY" });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 6), CellType = CellDataType.Family, InfoText = "New York Knicks vs Orlando Magic", SvgGlyph = DevExpress.XtraEditors.Demos.Properties.Resources.Game });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 13), CellType = CellDataType.Family });

            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 10), CellType = CellDataType.Work, InfoText = "Call Susanne Guper, New warehouse issues", SvgGlyph = DevExpress.XtraEditors.Demos.Properties.Resources.Meeting });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 16), Description = "JOHN\nBIRTHDAY", SpecialDate = true });

            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 21), CellType = CellDataType.Event  });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 22), Description = "MARY\nBIRTHDAY", SpecialDate = true });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 29), CellType = CellDataType.Event });

            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 17), CellType = CellDataType.Event, InfoText = "Flatiron Club", SvgGlyph = DevExpress.XtraEditors.Demos.Properties.Resources.Party });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 30), CellType = CellDataType.Family, InfoText = "Slow Food Farmers' Market", SvgGlyph = DevExpress.XtraEditors.Demos.Properties.Resources.Shopping });
            res.Add(new MyCustomCellData() { Date = new DateTime(2015, 7, 31), CellType = CellDataType.Family });

            return res;
        }

        public MyCustomCellData GetCell(DateTime date) {
            return Cells.FirstOrDefault((c) => c.Date.Date == date.Date);
        }
        void ICalendarCellStyleProvider.UpdateAppearance(CalendarCellStyle cell) {
            MyCustomCellData cellInfo = GetCell(cell.Date);
            if(cellInfo == null)
                return;

            cell.Description = cellInfo.Description;
            if(cell.Description != null) { 
                cell.DescriptionAppearance = (AppearanceObject)cell.Appearance.Clone();
                cell.DescriptionAppearance.Font = new Font(cell.Appearance.Font.FontFamily, 7.0f, FontStyle.Bold);
                cell.DescriptionAppearance.TextOptions.WordWrap = WordWrap.Wrap;
            }
            if(cell.State == Utils.Drawing.ObjectState.Normal) {
                cell.Appearance.BackColor = GetCellColor(cellInfo, cell);
                cell.Appearance.ForeColor = CheckForeColor(cell.Appearance.ForeColor, cell.Appearance.BackColor);
            }
            if(cellInfo.SpecialDate)
                cell.Appearance.Font = new Font(cell.Appearance.Font.FontFamily, 20.0f, FontStyle.Bold);
        }
        Color CheckForeColor(Color foreColor, Color backColor) {
            if(backColor.A == 0 || foreColor.A == 0)
                return foreColor;
            if(foreColor.R * 0.299 + foreColor.G * 0.587 + foreColor.B * 0.114 > 128)
                return Color.Black;
            return foreColor;
        }

        protected virtual Color GetCellColor(MyCustomCellData cellData, CalendarCellStyle cellStyle) {
            switch(cellData.CellType) { 
                case CellDataType.Event:
                    return SchedulerSkins.GetSkin(cellStyle.PaintStyle.LookAndFeel).Colors.GetColor("ResourceColor02", Color.FromArgb(255, 209, 240, 253));
                case CellDataType.Family:
                    return SchedulerSkins.GetSkin(cellStyle.PaintStyle.LookAndFeel).Colors.GetColor("ResourceColor03", Color.FromArgb(255, 229, 253, 177));
                case CellDataType.Work:
                    return SchedulerSkins.GetSkin(cellStyle.PaintStyle.LookAndFeel).Colors.GetColor("ResourceColor04", Color.FromArgb(255, 255, 228, 239));
            }
            return Color.Empty;
        }
    } 
}
