using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos {

    public partial class frmMain : OutlookForm {
        const int RightPadding = 10;

        public frmMain() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            Ribbon.RibbonStyle = RibbonControlStyle.Office2019;
            SetBackstageInfoControl(new OverviewControl() { Dock = DockStyle.Fill });
            SetBackstageExportControl(new ExportControl(this) { Dock = DockStyle.Fill });
            SetBackstagePrintControl(new SchedulerPrint() { Dock = DockStyle.Fill });
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            ZoomBehaviour.RegisterZoomTracker(TrackBarItem);
        }
        protected override bool SupportAdvancedTitlePainting {
            get { return false; }
        }
        protected override string DemoName {
            get { return DemoHelper.GetFormText( "XtraScheduler Main Demo"); }
        }
        [DefaultValue(null)]
        public DateNavigator DateNavigator { get; private set; }

        protected override void ShowAbout() {
            SchedulerControl.About();
        }
        protected override string ProductName {
            get { return "XtraScheduler"; }
        }
		protected override void SetFormParam() {
            Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraScheduler.Demos.AppIcon.ico", typeof(frmMain).Assembly);
		}
        protected override void ShowModuleCore(string name, DevExpress.XtraEditors.GroupControl controlPlaceholder) {
            DemosInfo.DoShowModule(name, controlPlaceholder, DateNavigator, RibbonMenuManager);
        }

        protected override void ShowCalendars(DevExpress.XtraEditors.GroupControl calendarPlaceholder) {
            DateNavigator = new DateNavigator();
            DateNavigator.BeginInit();
            DateNavigator.Dock = DockStyle.Fill;
            DateNavigator.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
            DateNavigator.ShowTodayButton = false;
            DateNavigator.BackColor = ColorHelper.GetControlColor(LookAndFeel);
            SetUpCalendarAppearanceForeColor();
            DateNavigator.CalendarView = XtraEditors.Repository.CalendarView.ClassicNew;
            DateNavigator.NavigationMode = DateNavigationMode.ScrollCalendar;
            DateNavigator.LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            DateNavigator.TabStop = false;
            DateNavigator.EndInit();
            calendarPlaceholder.Controls.Add(DateNavigator);
            SidePanel.MinimumSize = new System.Drawing.Size(DateNavigator.CalcBestSize().Width + RightPadding, 0);
        }

        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            DateNavigator.BackColor = ColorHelper.GetControlColor(LookAndFeel);
            SetUpCalendarAppearanceForeColor();
            UpdateSidePanelWidth();
        }

        void SetUpCalendarAppearanceForeColor() {
            DateNavigator.CalendarAppearance.DayCell.ForeColor = DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.ControlText);
            DateNavigator.CalendarAppearance.DayCellSpecial.ForeColor = DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.ControlText);
            DateNavigator.CalendarAppearance.WeekNumber.ForeColor = DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.ControlText);
            DateNavigator.CalendarAppearance.WeekDay.ForeColor = DevExpress.LookAndFeel.LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.ControlText);
        }


        void UpdateSidePanelWidth() {
            int bestWidth = DateNavigator.GetPreferredSize(System.Drawing.Size.Empty).Width;
            if(DateNavigator.Parent.Width < bestWidth)
                SidePanel.Width = bestWidth;
        }
    }

    public class CheckBarItemWithPrintColorSchema : CheckBarItem {
        PrintColorSchema _printColorSchema;
        public CheckBarItemWithPrintColorSchema(BarManager manager, string text, ItemClickEventHandler handler, PrintColorSchema printColorSchema)
            : base(manager, text, handler) {
            this._printColorSchema = printColorSchema;
        }
        public PrintColorSchema PrintColorSchema { get { return _printColorSchema; } }
    }
    
    public interface IDemoSchedulerReport {        
        void UpdateActiveReport();
    }

    public class SchedulerRibbonMenuManager : RibbonMenuManager {
        #region Fields
        SchedulerControl fSchedulerControl;
        IDemoSchedulerReport fSchedulerReport;

        BarButtonItem bbiPageSetup;
        BarButtonItem bbiLoadPageSetup;
        BarButtonItem bbiSavePageSetup;

        BarSubItem bsiReports;
        BarItem cbiPrintColorSchemaBW;
        BarItem cbiPrintColorSchemaGS;
        BarItem cbiPrintColorSchemaFC; 
        #endregion

        public SchedulerRibbonMenuManager(RibbonMainForm form)
            : base(form) {
            CreatePageSetupMenu(form);
            CreateReportsMenu(form);
            EnableReportsMenu();
        }

        #region Properties
        public SchedulerControl SchedulerControl { get { return fSchedulerControl; } set { fSchedulerControl = value; } }
        public IDemoSchedulerReport SchedulerReport {
            get { return fSchedulerReport; }
            set {
                fSchedulerReport = value;
                EnableReportsMenu();
            }
        }
        #endregion

        protected internal virtual void EnableReportsMenu() {
            ShowReservGroup1(SchedulerReport != null);
        }
        protected internal virtual void CreatePageSetupMenu(RibbonMainForm form) {
            this.bbiPageSetup = CreateButtonItem("Page Setup", "PageSetup");
            this.bbiPageSetup.ItemClick += bbiPageSetup_Click;
            RibbonControl ribbon = form.Ribbon;
            RibbonPageGroup printExportGroup = form.PrintExportGroup;
            AddBarItemInRibbon(ribbon, printExportGroup, this.bbiPageSetup, true);
            this.bbiLoadPageSetup = CreateButtonItem("Load Page Setup", "LoadPageSetup");
            this.bbiLoadPageSetup.ItemClick += bbiLoadPageSetup_Click;
            AddBarItemInRibbon(ribbon, printExportGroup, this.bbiLoadPageSetup);
            this.bbiSavePageSetup = CreateButtonItem("Save Page Setup", "SavePageSetup");
            this.bbiSavePageSetup.ItemClick += bbiSavePageSetup_Click;
            AddBarItemInRibbon(ribbon, printExportGroup, this.bbiSavePageSetup);
        }
        protected internal virtual BarButtonItem CreateButtonItem(string caption, string imageName) {
            BarButtonItem item = new BarButtonItem(Manager, caption);
            MainFormHelper.SetBarButtonImage(item, imageName);
            //bbiAlphaBlendingAdjustment.Glyph = DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.XtraScheduler.Demos.Images.Blending.png", typeof(frmMain).Assembly);            
            return item;
        }
        protected internal virtual void AddBarItemInRibbon(RibbonControl ribbon, RibbonPageGroup group, BarItem item) {
            AddBarItemInRibbon(ribbon, group, item, false);
        }
        void AddBarItemInRibbon(RibbonControl ribbon, RibbonPageGroup group, BarItem item, bool beginGroup) {
            ribbon.Items.Add(item);
            group.ItemLinks.Add(item, beginGroup);
        }
        void bbiPageSetup_Click(object sender, ItemClickEventArgs e) {
            try {
                SchedulerControl.ShowPrintOptionsForm();
            }
            catch (Exception ex) {
                XtraMessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        void bbiLoadPageSetup_Click(object sender, ItemClickEventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            try {
                dlg.CheckPathExists = true;
                dlg.Filter = "XML files (*.xml) | *.xml";
                DialogResult result = dlg.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                SchedulerControl.PrintStyles.FromXml(dlg.FileName, Application.ProductName);
            }
            catch (Exception ex) {
                XtraMessageBox.Show(ex.Message, Application.ProductName);
            }

            finally {
                dlg.Dispose();
            }
        }
        void bbiSavePageSetup_Click(object sender, ItemClickEventArgs e) {
            SaveFileDialog dlg = new SaveFileDialog();
            try {
                dlg.Filter = "XML files (*.xml) | *.xml";
                DialogResult result = dlg.ShowDialog();
                if (result != DialogResult.OK)
                    return;
                SchedulerControl.PrintStyles.ToXml(dlg.FileName, Application.ProductName);
            }
            catch (Exception ex) {
                XtraMessageBox.Show(ex.Message, Application.ProductName);
            }
            finally {
                dlg.Dispose();
            }
        }

        protected internal virtual void CreateReportsMenu(RibbonMainForm form) {
            bsiReports = new BarSubItem(this.Manager, "Print Color Schemas");
            bsiReports.Popup += OnPopupReports;
            MainFormHelper.SetBarButtonImage(bsiReports, "PrintColorSchemas");
            RibbonControl ribbon = form.Ribbon;

            RibbonPageGroup reportsGroup = form.ReservGroup1;
            reportsGroup.Text = "Reports";
            AddBarItemInRibbon(ribbon, reportsGroup, bsiReports);

            cbiPrintColorSchemaFC = new CheckBarItemWithPrintColorSchema(this.Manager, "Full Color", cbiPrintColorSchema_Click, PrintColorSchema.FullColor);
            cbiPrintColorSchemaGS = new CheckBarItemWithPrintColorSchema(this.Manager, "Grayscale", cbiPrintColorSchema_Click, PrintColorSchema.GrayScale);
            cbiPrintColorSchemaBW = new CheckBarItemWithPrintColorSchema(this.Manager, "Black And White", cbiPrintColorSchema_Click, PrintColorSchema.BlackAndWhite);

            AddCheckBarItemInSubItem(ribbon, bsiReports, cbiPrintColorSchemaFC);
            AddCheckBarItemInSubItem(ribbon, bsiReports, cbiPrintColorSchemaGS);
            AddCheckBarItemInSubItem(ribbon, bsiReports, cbiPrintColorSchemaBW);
        }
        protected internal virtual void AddCheckBarItemInSubItem(RibbonControl ribbon, BarSubItem subItem, BarItem item) {
            ribbon.Items.Add(item);
            subItem.ItemLinks.Add(item);
        }
        void OnPopupReports(object sender, EventArgs e) {
            BarSubItem items = sender as BarSubItem;
            if (items == null)
                return;
            foreach (BarItemLink item in items.ItemLinks) {
                CheckBarItemWithPrintColorSchema aItem = item.Item as CheckBarItemWithPrintColorSchema;
                if (aItem != null)
                    aItem.Checked = aItem.PrintColorSchema.Equals(DemoUtils.ReportPrintColorSchema);
            }
        }
        void cbiPrintColorSchema_Click(object sender, ItemClickEventArgs e) {
            CheckBarItemWithPrintColorSchema schemaItem = (CheckBarItemWithPrintColorSchema)e.Item;
            if (SchedulerReport != null) {
                DemoUtils.ReportPrintColorSchema = schemaItem.PrintColorSchema;
                SchedulerReport.UpdateActiveReport();
            }
        }
	}
}


