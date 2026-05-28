using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Internal;
using DevExpress.XtraGantt.Printing;
using DevExpress.XtraPrinting;
using LookAndFeelMenu = DevExpress.DXperience.Demos.LookAndFeelMenu;
using DevExpress.XtraGantt.TimeLine;

namespace DevExpress.XtraGantt.Demos {
    public class GanttRibbonMenuManager : RibbonMenuManager {
        const string AllowResizeImageName = "AllowResize";
        const string FixedPanelImageName = "FixedPanel";
        const string PanelVisibilityImageName = "PanelVisibility";
        const string ShowCriticalPathImageName = "ShowCriticalPath";
        const string TimelinePositionImageName = "TimelinePosition";

        BarSubItem bsiFixedPanel;
        BarSubItem bsiPanelVisibility;
        BarSubItem bsiTimelinePosition;
        BarButtonItem bbiAllowResize;
        BarCheckItem bciFixedPanelChart;
        BarCheckItem bciFixedPanelDefault;
        BarCheckItem bciFixedPanelNone;
        BarCheckItem bciFixedPanelTree;
        BarCheckItem bciPanelVisibilityBoth;
        BarCheckItem bciPanelVisibilityChart;
        BarCheckItem bciPanelVisibilityDefault;
        BarCheckItem bciPanelVisibilityTree;
        BarCheckItem bciTimelinePositionTop;
        BarCheckItem bciTimelinePositionBottom;
        BarCheckItem bciTimelinePositionNone;
        BarButtonItem bbiShowCriticalPath;
        GanttControl ganttControl;
        SvgImageCollection svgImagesCore;

        public GanttRibbonMenuManager(RibbonMainForm form) : base(form) {
            CreateViewMenu(form.ReservGroup1, form.Ribbon);
            ShowReservGroup1(true);
        }
        public void AllowShowCriticalPath(object obj) {
            bbiShowCriticalPath.Visibility = obj != null ? BarItemVisibility.Always : BarItemVisibility.Never;
        }
        void CreateAllowResizeItem(RibbonPageGroup pageGroup, RibbonControl ribbonControl) {
            bbiAllowResize = new BarButtonItem() {
                Caption = "Allow Resize",
                ButtonStyle = BarButtonStyle.Check,
            };
            bbiAllowResize.DownChanged += OnAllowResizeDownChanged;
            ribbonControl.Items.Add(bbiAllowResize);
            pageGroup.ItemLinks.Add(bbiAllowResize);
            bbiAllowResize.Down = true;
            bbiAllowResize.ImageOptions.SvgImage = SvgImages[AllowResizeImageName];
        }
        BarCheckItem CreateBarCheckItem(BarSubItem parentItem, object name, int groupIndex, ItemClickEventHandler handler, bool @checked = false, SvgImage image = null) {
            BarCheckItem checkItem = CreateCheckItem(groupIndex, name, @checked, image);
            checkItem.CheckedChanged += handler;
            checkItem.Tag = name;
            parentItem.AddItem(checkItem);
            return checkItem;
        }
        BarCheckItem CreateCheckItem(int groupIndex, object name, bool @checked, SvgImage image) {
            BarCheckItem newItem = new BarCheckItem(Manager) { Caption = name.ToString() };
            newItem.Name = "bci" + name.ToString();
            newItem.GroupIndex = groupIndex;
            newItem.Checked = @checked;
            newItem.ImageOptions.SvgImage = image;
            return newItem;
        }
        void CreateFixedPanelCheckItem(RibbonPageGroup group, RibbonControl ribbonControl) {
            bsiFixedPanel = new BarSubItem(Manager, "Fixed Panel");
            bsiFixedPanel.ImageOptions.SvgImage = SvgImages[FixedPanelImageName];
            ribbonControl.Items.Add(bsiFixedPanel);
            group.ItemLinks.Add(bsiFixedPanel);

            bciFixedPanelDefault = CreateBarCheckItem(bsiFixedPanel, GanttFixedPanel.Default, 2, OnFixedPanelItemClick);
            ribbonControl.Items.Add(bciFixedPanelDefault);
            bciFixedPanelChart = CreateBarCheckItem(bsiFixedPanel, GanttFixedPanel.Chart, 2, OnFixedPanelItemClick);
            ribbonControl.Items.Add(bciFixedPanelChart);
            bciFixedPanelNone = CreateBarCheckItem(bsiFixedPanel, GanttFixedPanel.None, 2, OnFixedPanelItemClick);
            ribbonControl.Items.Add(bciFixedPanelNone);
            bciFixedPanelTree = CreateBarCheckItem(bsiFixedPanel, GanttFixedPanel.Tree, 2, OnFixedPanelItemClick);
            ribbonControl.Items.Add(bciFixedPanelTree);
        }
        void CreatePanelVisibilityItem(RibbonPageGroup pageGroup, RibbonControl ribbonControl) {
            bsiPanelVisibility = new BarSubItem(Manager, "Panel Visibility");
            bsiPanelVisibility.ImageOptions.SvgImage = SvgImages[PanelVisibilityImageName];
            ribbonControl.Items.Add(bsiPanelVisibility);
            pageGroup.ItemLinks.Add(bsiPanelVisibility);

            bciPanelVisibilityDefault = CreateBarCheckItem(bsiPanelVisibility, GanttPanelVisibility.Default, 1, OnPanelVisibilityItemClick);
            ribbonControl.Items.Add(bciPanelVisibilityDefault);

            bciPanelVisibilityBoth = CreateBarCheckItem(bsiPanelVisibility, GanttPanelVisibility.Both, 1, OnPanelVisibilityItemClick);
            ribbonControl.Items.Add(bciPanelVisibilityBoth);

            bciPanelVisibilityChart = CreateBarCheckItem(bsiPanelVisibility, GanttPanelVisibility.Chart, 1, OnPanelVisibilityItemClick);
            ribbonControl.Items.Add(bciPanelVisibilityChart);

            bciPanelVisibilityTree = CreateBarCheckItem(bsiPanelVisibility, GanttPanelVisibility.Tree, 1, OnPanelVisibilityItemClick);
            ribbonControl.Items.Add(bciPanelVisibilityTree);
        }
        void CreateTimelinePositionItem(RibbonPageGroup pageGroup, RibbonControl ribbonControl) {
            bsiTimelinePosition = new BarSubItem(Manager, "Timeline Position");
            bsiTimelinePosition.ImageOptions.SvgImage = SvgImages[TimelinePositionImageName];
            ribbonControl.Items.Add(bsiTimelinePosition);
            pageGroup.ItemLinks.Add(bsiTimelinePosition);

            bciTimelinePositionTop = CreateBarCheckItem(bsiTimelinePosition, TimelinePosition.Top, 1, OnTimelinePositionClick);
            ribbonControl.Items.Add(bciTimelinePositionTop);

            bciTimelinePositionBottom = CreateBarCheckItem(bsiTimelinePosition, TimelinePosition.Bottom, 1, OnTimelinePositionClick, true);
            ribbonControl.Items.Add(bciTimelinePositionBottom);

            bciTimelinePositionNone = CreateBarCheckItem(bsiTimelinePosition, TimelinePosition.None, 1, OnTimelinePositionClick);
            ribbonControl.Items.Add(bciTimelinePositionNone);
        }
        void CreateViewMenu(RibbonPageGroup pageGroup, RibbonControl ribbonControl) {
            pageGroup.Text = "View";
            CreateAllowResizeItem(pageGroup, ribbonControl);
            CreatePanelVisibilityItem(pageGroup, ribbonControl);
            CreateFixedPanelCheckItem(pageGroup, ribbonControl);
            CreateTimelinePositionItem(pageGroup, ribbonControl);
            CreateShowCriticalPathCheckItem(pageGroup, ribbonControl);
        }
        void CreateShowCriticalPathCheckItem(RibbonPageGroup pageGroup, RibbonControl ribbonControl) {
            bbiShowCriticalPath = new BarButtonItem() {
                Caption = "Critical Path",
                ButtonStyle = BarButtonStyle.Check,
            };
            bbiShowCriticalPath.DownChanged += OnShowCriticalPathChanged;
            ribbonControl.Items.Add(bbiShowCriticalPath);
            pageGroup.ItemLinks.Add(bbiShowCriticalPath);
            bbiShowCriticalPath.Down = true;
            bbiShowCriticalPath.ImageOptions.SvgImage = SvgImages[ShowCriticalPathImageName];
        }
        void RefreshViewMenuItems() {
            bbiAllowResize.Down = OptionsSplitter.AllowResize;
            switch(OptionsSplitter.FixedPanel) {
                case GanttFixedPanel.Tree:
                    bciFixedPanelTree.Checked = true;
                    break;
                case GanttFixedPanel.Chart:
                    bciFixedPanelChart.Checked = true;
                    break;
                case GanttFixedPanel.None:
                    bciFixedPanelNone.Checked = true;
                    break;
                case GanttFixedPanel.Default:
                    bciFixedPanelDefault.Checked = true;
                    break;
            }
            switch(OptionsSplitter.PanelVisibility) {
                case GanttPanelVisibility.Tree:
                    bciPanelVisibilityTree.Checked = true;
                    break;
                case GanttPanelVisibility.Chart:
                    bciPanelVisibilityChart.Checked = true;
                    break;
                case GanttPanelVisibility.Both:
                    bciPanelVisibilityBoth.Checked = true;
                    break;
                case GanttPanelVisibility.Default:
                    bciPanelVisibilityDefault.Checked = true;
                    break;
            }
        }

        GanttControlTimelineOptions OptionsTimeline {
            get {
                if(ganttControl != null)
                    return ganttControl.OptionsTimeline;
                return null;
            }
        }
        GanttControlOptionsSplitter OptionsSplitter {
            get {
                if(ganttControl != null)
                    return ganttControl.OptionsSplitter;
                return null;
            }
        }
        GanttControlOptionsView OptionsView {
            get {
                if(ganttControl != null)
                    return ganttControl.OptionsView;
                return null;
            }
        }
        SvgImageCollection SvgImages {
            get {
                if(svgImagesCore == null) {
                    svgImagesCore = new SvgImageCollection();
                    Assembly @assembly = typeof(GanttRibbonMenuManager).Assembly;
                    svgImagesCore.Add(PanelVisibilityImageName, SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraGantt.Demos.Resources.PanelVisibility.svg", @assembly)));
                    svgImagesCore.Add(FixedPanelImageName, SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraGantt.Demos.Resources.FixedPanel.svg", @assembly)));
                    svgImagesCore.Add(AllowResizeImageName, SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraGantt.Demos.Resources.AllowResize.svg", @assembly)));
                    svgImagesCore.Add(ShowCriticalPathImageName, SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraGantt.Demos.Resources.CriticalPath.svg", @assembly)));
                    svgImagesCore.Add(TimelinePositionImageName, SvgImage.FromStream(ResourceImageHelper.FindStream("DevExpress.XtraGantt.Demos.Resources.TimelinePosition.svg", @assembly)));
                }
                return svgImagesCore;
            }
        }

        public void RefreshViewMenu(GanttControl ganttControl) {
            ShowReservGroup1(ganttControl != null);
            this.ganttControl = ganttControl;
            if(ganttControl != null)
                RefreshViewMenuItems();
        }
        void OnTimelinePositionClick(object sender, ItemClickEventArgs e) {
            if(OptionsTimeline != null)
                OptionsTimeline.TimelinePosition = (TimelinePosition)Enum.Parse(typeof(TimelinePosition), e.Item.Tag.ToString());
        }
        void OnPanelVisibilityItemClick(object sender, ItemClickEventArgs e) {
            if(OptionsSplitter != null)
                OptionsSplitter.PanelVisibility = (GanttPanelVisibility)Enum.Parse(typeof(GanttPanelVisibility), e.Item.Tag.ToString());
        }
        void OnFixedPanelItemClick(object sender, ItemClickEventArgs e) {
            if(OptionsSplitter != null)
                OptionsSplitter.FixedPanel = (GanttFixedPanel)Enum.Parse(typeof(GanttFixedPanel), e.Item.Tag.ToString());
        }
        void OnAllowResizeDownChanged(object sender, ItemClickEventArgs e) {
            BarButtonItem checkItem = e.Item as BarButtonItem;
            if(OptionsSplitter != null && checkItem != null)
                OptionsSplitter.AllowResize = checkItem.Down;
        }
        void OnShowCriticalPathChanged(object sender, ItemClickEventArgs e) {
            BarButtonItem checkItem = e.Item as BarButtonItem;
            if(OptionsView != null && checkItem != null)
                OptionsView.CriticalPathHighlightMode = checkItem.Down ? CriticalPathHighlightMode.Single : CriticalPathHighlightMode.None;
        }
    }

    public class TutorialControl : TutorialControlBase {
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            GanttControl gantt = ctrl as GanttControl;
            if(gantt != null)
                gantt.MenuManager = manager;
            ScrollBarBase scrollBar = ctrl as ScrollBarBase;
            if(scrollBar != null && FluentScrollBars)
                ScrollBarBase.ApplyUIMode(scrollBar, ScrollUIMode.Fluent);
            BaseEdit be = ctrl as BaseEdit;
            if(be != null)
                be.MenuManager = manager;
        }
        protected virtual bool FluentScrollBars {
            get { return false; }
        }
        protected override void AllowExport() {
            EnabledPrintExportActions(true, ExportFormats.PDF | ExportFormats.HTML | ExportFormats.MHT | ExportFormats.XLS |
                                            ExportFormats.RTF | ExportFormats.DOCX | ExportFormats.Text | ExportFormats.XLSX, false);
        }
        protected override void ExportToCore(String filename, string ext) {
            if(MainControl == null)
                return;
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if(ext == "rtf")
                MainControl.ExportToRtf(filename);
            if(ext == "docx")
                MainControl.ExportToDocx(filename);
            if(ext == "pdf") {
                PdfExportOptions options = new PdfExportOptions();
                options.ConvertImagesToJpeg = false;
                MainControl.ExportToPdf(filename, options);
            }
            if(ext == "mht")
                MainControl.ExportToMht(filename, new MhtExportOptions());
            if(ext == "html")
                MainControl.ExportToHtml(filename);
            if(ext == "txt")
                MainControl.ExportToText(filename);
            if(ext == "xls")
                MainControl.ExportToXls(filename);
            if(ext == "xlsx")
                MainControl.ExportToXlsx(filename);
            Cursor.Current = currentCursor;
        }
        protected override void ExportToPDF() {
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf");
        }
        protected override void ExportToHTML() {
            ExportTo("html", "HTML document (*.html)|*.html");
        }
        protected override void ExportToMHT() {
            ExportTo("mht", "MHT document (*.mht)|*.mht");
        }
        protected override void ExportToXLS() {
            ExportTo("xls", "XLS document (*.xls)|*.xls");
        }
        protected override void ExportToXLSX() {
            ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx");
        }
        protected override void ExportToRTF() {
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf");
        }
        protected override void ExportToDOCX() {
            ExportTo("docx", "DOCX document (*.docx)|*.docx");
        }
        protected override void ExportToText() {
            ExportTo("txt", "Text document (*.txt)|*.txt");
        }
        public override bool AllowGenerateReport {
            get { return false; }
        }
        public virtual bool AllowShowCriticalPath {
            get { return false; }
        }
        protected override string ModulesFolder {
            get { return "GanttMainDemo\\Modules"; }
        }
        protected override string CodeInfoFolder {
            get { return "DevExpress.XtraGantt.Demos.CodeInfo"; }
        }
        public bool IsActiveDemo {
            get { return false; }
        }
        protected static Stream LoadXml(string name) {
            string fileName = DataDirectoryHelper.GetDataFile(name);
            if(!string.IsNullOrEmpty(fileName))
                return new FileStream(fileName, FileMode.Open, FileAccess.Read);
            return null;
        }

        public virtual GanttControl MainControl {
            get { return null; }
        }
        protected override void PrintPreview() {
            try {
                if(this.MainControl != null) {
                    if(RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                        this.MainControl.ShowRibbonPrintPreview();
                    else
                        this.MainControl.ShowPrintPreview();
                }
            }
            catch (Exception ex) {
                NotificationService.ShowException<XtraGanttPrintingSystemBase>(LookAndFeel, FindForm(), ex);
            }
        }
    }
}
