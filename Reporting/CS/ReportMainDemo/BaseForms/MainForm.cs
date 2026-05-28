using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UserDesigner;

namespace ReportDesigner {
    public class MainForm : XtraForm {
        private DevExpress.XtraReports.UserDesigner.XRDesignBarManager xrDesignBarManager1;
        private Bar bar2;
        private DevExpress.XtraReports.UserDesigner.DesignBar designBar1;
        private BarSubItem barSubItem1;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem31;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem39;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem32;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem33;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem40;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem41;
        private BarSubItem barSubItem2;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem37;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem38;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem34;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem35;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem36;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem42;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem43;
        private BarSubItem barSubItem3;
        private DevExpress.XtraReports.UserDesigner.BarReportTabButtonsListItem barReportTabButtonsListItem1;
        private BarSubItem barSubItem4;
        private DevExpress.XtraReports.UserDesigner.XRBarToolbarsListItem xrBarToolbarsListItem1;
        private BarSubItem barSubItem5;
        private DevExpress.XtraReports.UserDesigner.BarDockPanelsListItem barDockPanelsListItem1;
        private BarSubItem barSubItem6;
        private DevExpress.XtraReports.UserDesigner.CommandColorBarItem commandColorBarItem1;
        private DevExpress.XtraReports.UserDesigner.CommandColorBarItem commandColorBarItem2;
        private BarSubItem barSubItem7;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem1;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem2;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem3;
        private BarSubItem barSubItem8;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem4;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem5;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem6;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem7;
        private BarSubItem barSubItem9;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem9;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem10;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem11;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem12;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem13;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem14;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem8;
        private BarSubItem barSubItem10;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem15;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem16;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem17;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem18;
        private BarSubItem barSubItem11;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem19;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem20;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem21;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem22;
        private BarSubItem barSubItem12;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem23;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem24;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem25;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem26;
        private BarSubItem barSubItem13;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem27;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem28;
        private BarSubItem barSubItem14;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem29;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem30;
        private BarSubItem barSubItem15;
        private DevExpress.XtraReports.UserDesigner.CommandBarCheckItem commandBarCheckItem1;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem44;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem45;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem46;
        private BarMdiChildrenListItem barMdiChildrenListItem1;
        private BarSubItem bsiLookAndFeel;
        private DevExpress.XtraReports.UserDesigner.DesignBar designBar2;
        private DevExpress.XtraReports.UserDesigner.DesignBar designBar3;
        private BarEditItem barEditItem1;
        private DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox recentlyUsedItemsComboBox1;
        private BarEditItem barEditItem2;
        private DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox designRepositoryItemComboBox1;
        private DevExpress.XtraReports.UserDesigner.DesignBar designBar4;
        private DevExpress.XtraReports.UserDesigner.DesignBar designBar5;
        private BarStaticItem barStaticItem1;
        private Bar bar1;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem47;
        private DevExpress.XtraReports.UserDesigner.XRZoomBarEditItem xrZoomBarEditItem1;
        private DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox designRepositoryItemComboBox2;
        private DevExpress.XtraReports.UserDesigner.CommandBarItem commandBarItem48;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private DevExpress.XtraReports.UserDesigner.XRDesignDockManager xrDesignDockManager1;
        private DevExpress.XtraReports.UserDesigner.XRDesignMdiController xrDesignMdiController1;
        private XRTabbedMdiManager xtraTabbedMdiManager1;
        private CommandBarItem commandBarItem49;
        private CommandBarItem commandBarItem50;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer3;
        private GroupAndSortDockPanel groupAndSortDockPanel1;
        private DesignControlContainer groupAndSortDockPanel1_Container;
        private ErrorListDockPanel errorListDockPanel1;
        private DesignControlContainer errorListDockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer2;
        private ReportExplorerDockPanel reportExplorerDockPanel1;
        private DesignControlContainer reportExplorerDockPanel1_Container;
        private FieldListDockPanel fieldListDockPanel1;
        private DesignControlContainer fieldListDockPanel1_Container;
        private PropertyGridDockPanel propertyGridDockPanel1;
        private DesignControlContainer propertyGridDockPanel1_Container;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private IContainer components;

        public MainForm() {
            InitializeComponent();

            BarAndDockingController controller = new BarAndDockingController();
            controller.PropertiesBar.ScaleEditors = true;
            xrDesignBarManager1.Controller = controller;
            xtraTabbedMdiManager1.BarAndDockingController = controller;
            xrDesignDockManager1.Controller = controller;

            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinPopupMenu(bsiLookAndFeel);
        }

        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UserDesigner.BarInfo barInfo1 = new DevExpress.XtraReports.UserDesigner.BarInfo();
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener1 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener2 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener3 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener4 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener5 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener6 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            DevExpress.XtraReports.UserDesigner.XRDesignPanelListener xrDesignPanelListener7 = new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bar2 = new DevExpress.XtraBars.Bar();
            xrDesignBarManager1 = new DevExpress.XtraReports.UserDesigner.XRDesignBarManager(components);
            designBar1 = new DevExpress.XtraReports.UserDesigner.DesignBar();
            barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            commandBarItem31 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem39 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem32 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem33 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem40 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem49 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem50 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem41 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            commandBarItem37 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem38 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem34 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem35 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem36 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem42 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem43 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            barReportTabButtonsListItem1 = new DevExpress.XtraReports.UserDesigner.BarReportTabButtonsListItem();
            barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            xrBarToolbarsListItem1 = new DevExpress.XtraReports.UserDesigner.XRBarToolbarsListItem();
            barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            barDockPanelsListItem1 = new DevExpress.XtraReports.UserDesigner.BarDockPanelsListItem();
            barSubItem6 = new DevExpress.XtraBars.BarSubItem();
            commandColorBarItem1 = new DevExpress.XtraReports.UserDesigner.CommandColorBarItem();
            commandColorBarItem2 = new DevExpress.XtraReports.UserDesigner.CommandColorBarItem();
            barSubItem7 = new DevExpress.XtraBars.BarSubItem();
            commandBarItem1 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem2 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem3 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            barSubItem8 = new DevExpress.XtraBars.BarSubItem();
            commandBarItem4 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem5 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem6 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem7 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            barSubItem9 = new DevExpress.XtraBars.BarSubItem();
            commandBarItem9 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem10 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem11 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem12 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem13 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem14 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem8 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            barSubItem10 = new DevExpress.XtraBars.BarSubItem();
            commandBarItem15 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem16 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem17 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem18 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            barSubItem11 = new DevExpress.XtraBars.BarSubItem();
            commandBarItem19 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem20 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem21 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem22 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            barSubItem12 = new DevExpress.XtraBars.BarSubItem();
            commandBarItem23 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem24 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem25 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem26 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            barSubItem13 = new DevExpress.XtraBars.BarSubItem();
            commandBarItem27 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem28 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            barSubItem14 = new DevExpress.XtraBars.BarSubItem();
            commandBarItem29 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem30 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            barSubItem15 = new DevExpress.XtraBars.BarSubItem();
            commandBarCheckItem1 = new DevExpress.XtraReports.UserDesigner.CommandBarCheckItem();
            commandBarItem44 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem45 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            commandBarItem46 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            bsiLookAndFeel = new DevExpress.XtraBars.BarSubItem();
            designBar2 = new DevExpress.XtraReports.UserDesigner.DesignBar();
            designBar3 = new DevExpress.XtraReports.UserDesigner.DesignBar();
            barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            recentlyUsedItemsComboBox1 = new DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox();
            barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            designRepositoryItemComboBox1 = new DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox();
            designBar4 = new DevExpress.XtraReports.UserDesigner.DesignBar();
            designBar5 = new DevExpress.XtraReports.UserDesigner.DesignBar();
            barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            bar1 = new DevExpress.XtraBars.Bar();
            commandBarItem47 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            xrZoomBarEditItem1 = new DevExpress.XtraReports.UserDesigner.XRZoomBarEditItem();
            designRepositoryItemComboBox2 = new DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox();
            commandBarItem48 = new DevExpress.XtraReports.UserDesigner.CommandBarItem();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            xrDesignDockManager1 = new DevExpress.XtraReports.UserDesigner.XRDesignDockManager(components);
            panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            panelContainer2 = new DevExpress.XtraBars.Docking.DockPanel();
            reportExplorerDockPanel1 = new DevExpress.XtraReports.UserDesigner.ReportExplorerDockPanel();
            reportExplorerDockPanel1_Container = new DevExpress.XtraReports.UserDesigner.DesignControlContainer();
            fieldListDockPanel1 = new DevExpress.XtraReports.UserDesigner.FieldListDockPanel();
            fieldListDockPanel1_Container = new DevExpress.XtraReports.UserDesigner.DesignControlContainer();
            propertyGridDockPanel1 = new DevExpress.XtraReports.UserDesigner.PropertyGridDockPanel();
            propertyGridDockPanel1_Container = new DevExpress.XtraReports.UserDesigner.DesignControlContainer();
            panelContainer3 = new DevExpress.XtraBars.Docking.DockPanel();
            groupAndSortDockPanel1 = new DevExpress.XtraReports.UserDesigner.GroupAndSortDockPanel();
            groupAndSortDockPanel1_Container = new DevExpress.XtraReports.UserDesigner.DesignControlContainer();
            errorListDockPanel1 = new DevExpress.XtraReports.UserDesigner.ErrorListDockPanel();
            errorListDockPanel1_Container = new DevExpress.XtraReports.UserDesigner.DesignControlContainer();
            xrDesignMdiController1 = new DevExpress.XtraReports.UserDesigner.XRDesignMdiController(components);
            xtraTabbedMdiManager1 = new DevExpress.XtraReports.UserDesigner.XRTabbedMdiManager(components);
            tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(components);
            ((System.ComponentModel.ISupportInitialize)(xrDesignBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(recentlyUsedItemsComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(designRepositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(designRepositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xrDesignDockManager1)).BeginInit();
            panelContainer1.SuspendLayout();
            panelContainer2.SuspendLayout();
            reportExplorerDockPanel1.SuspendLayout();
            fieldListDockPanel1.SuspendLayout();
            propertyGridDockPanel1.SuspendLayout();
            panelContainer3.SuspendLayout();
            groupAndSortDockPanel1.SuspendLayout();
            errorListDockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(tabbedView1)).BeginInit();
            SuspendLayout();
            // 
            // bar2
            // 
            bar2.BarName = "Toolbox";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Left;
            bar2.OptionsBar.AllowQuickCustomization = false;
            bar2.Text = "Standard Controls";
            // 
            // xrDesignBarManager1
            // 
            barInfo1.Bar = bar2;
            barInfo1.ToolboxType = DevExpress.XtraReports.UserDesigner.ToolboxType.Standard;
            xrDesignBarManager1.BarInfos.AddRange(new DevExpress.XtraReports.UserDesigner.BarInfo[] {
            barInfo1});
            xrDesignBarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            designBar1,
            designBar2,
            designBar3,
            designBar4,
            designBar5,
            bar1,
            bar2});
            xrDesignBarManager1.DockControls.Add(barDockControlTop);
            xrDesignBarManager1.DockControls.Add(barDockControlBottom);
            xrDesignBarManager1.DockControls.Add(barDockControlLeft);
            xrDesignBarManager1.DockControls.Add(barDockControlRight);
            xrDesignBarManager1.DockManager = xrDesignDockManager1;
            xrDesignBarManager1.FontNameBox = recentlyUsedItemsComboBox1;
            xrDesignBarManager1.FontNameEdit = barEditItem1;
            xrDesignBarManager1.FontSizeBox = designRepositoryItemComboBox1;
            xrDesignBarManager1.FontSizeEdit = barEditItem2;
            xrDesignBarManager1.Form = this;
            xrDesignBarManager1.FormattingToolbar = designBar3;
            xrDesignBarManager1.HintStaticItem = barStaticItem1;
            xrDesignBarManager1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("xrDesignBarManager1.ImageStream")));
            xrDesignBarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            barEditItem1,
            barEditItem2,
            commandBarItem1,
            commandBarItem2,
            commandBarItem3,
            commandColorBarItem1,
            commandColorBarItem2,
            commandBarItem4,
            commandBarItem5,
            commandBarItem6,
            commandBarItem7,
            commandBarItem8,
            commandBarItem9,
            commandBarItem10,
            commandBarItem11,
            commandBarItem12,
            commandBarItem13,
            commandBarItem14,
            commandBarItem15,
            commandBarItem16,
            commandBarItem17,
            commandBarItem18,
            commandBarItem19,
            commandBarItem20,
            commandBarItem21,
            commandBarItem22,
            commandBarItem23,
            commandBarItem24,
            commandBarItem25,
            commandBarItem26,
            commandBarItem27,
            commandBarItem28,
            commandBarItem29,
            commandBarItem30,
            commandBarItem31,
            commandBarItem32,
            commandBarItem33,
            commandBarItem34,
            commandBarItem35,
            commandBarItem36,
            commandBarItem37,
            commandBarItem38,
            barStaticItem1,
            barSubItem1,
            barSubItem2,
            barSubItem3,
            barReportTabButtonsListItem1,
            barSubItem4,
            xrBarToolbarsListItem1,
            barSubItem5,
            barDockPanelsListItem1,
            barSubItem6,
            barSubItem7,
            barSubItem8,
            barSubItem9,
            barSubItem10,
            barSubItem11,
            barSubItem12,
            barSubItem13,
            barSubItem14,
            commandBarItem39,
            commandBarItem40,
            commandBarItem41,
            commandBarItem42,
            commandBarItem43,
            barSubItem15,
            commandBarCheckItem1,
            commandBarItem44,
            commandBarItem45,
            commandBarItem46,
            barMdiChildrenListItem1,
            commandBarItem47,
            xrZoomBarEditItem1,
            commandBarItem48,
            bsiLookAndFeel,
            commandBarItem49,
            commandBarItem50});
            xrDesignBarManager1.LayoutToolbar = designBar4;
            xrDesignBarManager1.MainMenu = designBar1;
            xrDesignBarManager1.MaxItemId = 79;
            xrDesignBarManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            recentlyUsedItemsComboBox1,
            designRepositoryItemComboBox1,
            designRepositoryItemComboBox2});
            xrDesignBarManager1.StatusBar = designBar5;
            xrDesignBarManager1.Toolbar = designBar2;
            xrDesignBarManager1.Updates.AddRange(new string[] {
            "Toolbox"});
            xrDesignBarManager1.ZoomItem = xrZoomBarEditItem1;
            // 
            // designBar1
            // 
            designBar1.BarName = "Main Menu";
            designBar1.DockCol = 0;
            designBar1.DockRow = 0;
            designBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            designBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem6),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem15),
            new DevExpress.XtraBars.LinkPersistInfo(bsiLookAndFeel)});
            designBar1.OptionsBar.MultiLine = true;
            designBar1.OptionsBar.UseWholeRow = true;
            designBar1.Text = "Main Menu";
            // 
            // barSubItem1
            // 
            barSubItem1.Caption = "&File";
            barSubItem1.Id = 43;
            barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem31),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem39),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem32),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem33, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem40),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem50),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem49),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem41, true)});
            barSubItem1.Name = "barSubItem1";
            // 
            // commandBarItem31
            // 
            commandBarItem31.Caption = "&New";
            commandBarItem31.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.NewReport;
            commandBarItem31.Enabled = false;
            commandBarItem31.Hint = "Create a new blank report";
            commandBarItem31.Id = 34;
            commandBarItem31.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            commandBarItem31.Name = "commandBarItem31";
            // 
            // commandBarItem39
            // 
            commandBarItem39.Caption = "New with &Wizard...";
            commandBarItem39.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.NewReportWizard;
            commandBarItem39.Enabled = false;
            commandBarItem39.Hint = "Create a new report using the Wizard";
            commandBarItem39.Id = 60;
            commandBarItem39.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W));
            commandBarItem39.Name = "commandBarItem39";
            // 
            // commandBarItem32
            // 
            commandBarItem32.Caption = "&Open...";
            commandBarItem32.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.OpenFile;
            commandBarItem32.Enabled = false;
            commandBarItem32.Hint = "Open a report";
            commandBarItem32.Id = 35;
            commandBarItem32.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            commandBarItem32.Name = "commandBarItem32";
            // 
            // commandBarItem33
            // 
            commandBarItem33.Caption = "&Save";
            commandBarItem33.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SaveFile;
            commandBarItem33.Enabled = false;
            commandBarItem33.Hint = "Save a report";
            commandBarItem33.Id = 36;
            commandBarItem33.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            commandBarItem33.Name = "commandBarItem33";
            // 
            // commandBarItem40
            // 
            commandBarItem40.Caption = "Save &As...";
            commandBarItem40.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SaveFileAs;
            commandBarItem40.Enabled = false;
            commandBarItem40.Hint = "Save a report with a new name";
            commandBarItem40.Id = 61;
            commandBarItem40.Name = "commandBarItem40";
            // 
            // commandBarItem50
            // 
            commandBarItem50.Caption = "Settings";
            commandBarItem50.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Settings;
            commandBarItem50.Enabled = true;
            commandBarItem50.Hint = "Open designer settings dialog";
            commandBarItem50.Id = 79;
            commandBarItem50.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K));
            commandBarItem50.Name = "commandBarItem50";
            // 
            // commandBarItem49
            // 
            commandBarItem49.Caption = "&Close";
            commandBarItem49.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Close;
            commandBarItem49.Enabled = false;
            commandBarItem49.Hint = "Close the report";
            commandBarItem49.Id = 78;
            commandBarItem49.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4));
            commandBarItem49.Name = "commandBarItem49";
            // 
            // commandBarItem41
            // 
            commandBarItem41.Caption = "E&xit";
            commandBarItem41.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Exit;
            commandBarItem41.Enabled = false;
            commandBarItem41.Hint = "Close the designer";
            commandBarItem41.Id = 62;
            commandBarItem41.Name = "commandBarItem41";
            // 
            // barSubItem2
            // 
            barSubItem2.Caption = "&Edit";
            barSubItem2.Id = 44;
            barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem37, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem38),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem34, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem35),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem36),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem42),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem43, true)});
            barSubItem2.Name = "barSubItem2";
            // 
            // commandBarItem37
            // 
            commandBarItem37.Caption = "&Undo";
            commandBarItem37.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Undo;
            commandBarItem37.Enabled = false;
            commandBarItem37.Hint = "Undo the last operation";
            commandBarItem37.Id = 40;
            commandBarItem37.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            commandBarItem37.Name = "commandBarItem37";
            // 
            // commandBarItem38
            // 
            commandBarItem38.Caption = "&Redo";
            commandBarItem38.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Redo;
            commandBarItem38.Enabled = false;
            commandBarItem38.Hint = "Redo the last operation";
            commandBarItem38.Id = 41;
            commandBarItem38.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
            commandBarItem38.Name = "commandBarItem38";
            // 
            // commandBarItem34
            // 
            commandBarItem34.Caption = "Cu&t";
            commandBarItem34.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Cut;
            commandBarItem34.Enabled = false;
            commandBarItem34.Hint = "Delete the control and copy it to the clipboard";
            commandBarItem34.Id = 37;
            commandBarItem34.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            commandBarItem34.Name = "commandBarItem34";
            // 
            // commandBarItem35
            // 
            commandBarItem35.Caption = "&Copy";
            commandBarItem35.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Copy;
            commandBarItem35.Enabled = false;
            commandBarItem35.Hint = "Copy the control to the clipboard";
            commandBarItem35.Id = 38;
            commandBarItem35.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            commandBarItem35.Name = "commandBarItem35";
            // 
            // commandBarItem36
            // 
            commandBarItem36.Caption = "&Paste";
            commandBarItem36.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Paste;
            commandBarItem36.Enabled = false;
            commandBarItem36.Hint = "Add the control from the clipboard";
            commandBarItem36.Id = 39;
            commandBarItem36.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
            commandBarItem36.Name = "commandBarItem36";
            // 
            // commandBarItem42
            // 
            commandBarItem42.Caption = "&Delete";
            commandBarItem42.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.Delete;
            commandBarItem42.Enabled = false;
            commandBarItem42.Hint = "Delete the control";
            commandBarItem42.Id = 63;
            commandBarItem42.Name = "commandBarItem42";
            // 
            // commandBarItem43
            // 
            commandBarItem43.Caption = "Select &All";
            commandBarItem43.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SelectAll;
            commandBarItem43.Enabled = false;
            commandBarItem43.Hint = "Select all the controls in the document";
            commandBarItem43.Id = 64;
            commandBarItem43.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            commandBarItem43.Name = "commandBarItem43";
            // 
            // barSubItem3
            // 
            barSubItem3.Caption = "&View";
            barSubItem3.Id = 45;
            barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(barReportTabButtonsListItem1),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem4, true),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem5, true)});
            barSubItem3.Name = "barSubItem3";
            // 
            // barReportTabButtonsListItem1
            // 
            barReportTabButtonsListItem1.Caption = "Tab Buttons";
            barReportTabButtonsListItem1.Id = 46;
            barReportTabButtonsListItem1.Name = "barReportTabButtonsListItem1";
            // 
            // barSubItem4
            // 
            barSubItem4.Caption = "&Toolbars";
            barSubItem4.Id = 47;
            barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(xrBarToolbarsListItem1)});
            barSubItem4.Name = "barSubItem4";
            // 
            // xrBarToolbarsListItem1
            // 
            xrBarToolbarsListItem1.Caption = "&Toolbars";
            xrBarToolbarsListItem1.Id = 48;
            xrBarToolbarsListItem1.Name = "xrBarToolbarsListItem1";
            // 
            // barSubItem5
            // 
            barSubItem5.Caption = "&Windows";
            barSubItem5.Id = 49;
            barSubItem5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(barDockPanelsListItem1)});
            barSubItem5.Name = "barSubItem5";
            // 
            // barDockPanelsListItem1
            // 
            barDockPanelsListItem1.Caption = "&Windows";
            barDockPanelsListItem1.DockManager = null;
            barDockPanelsListItem1.Id = 50;
            barDockPanelsListItem1.Name = "barDockPanelsListItem1";
            barDockPanelsListItem1.ShowCustomizationItem = false;
            barDockPanelsListItem1.ShowDockPanels = true;
            barDockPanelsListItem1.ShowToolbars = false;
            // 
            // barSubItem6
            // 
            barSubItem6.Caption = "Fo&rmat";
            barSubItem6.Id = 51;
            barSubItem6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandColorBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(commandColorBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem7, true),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem8),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem9, true),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem10),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem11, true),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem12),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem13, true),
            new DevExpress.XtraBars.LinkPersistInfo(barSubItem14, true)});
            barSubItem6.Name = "barSubItem6";
            // 
            // commandColorBarItem1
            // 
            commandColorBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            commandColorBarItem1.Caption = "For&eground Color";
            commandColorBarItem1.CloseSubMenuOnClick = false;
            commandColorBarItem1.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.ForeColor;
            commandColorBarItem1.Enabled = false;
            commandColorBarItem1.Hint = "Set the foreground color of the control";
            commandColorBarItem1.Id = 5;
            commandColorBarItem1.Name = "commandColorBarItem1";
            // 
            // commandColorBarItem2
            // 
            commandColorBarItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            commandColorBarItem2.Caption = "Bac&kground Color";
            commandColorBarItem2.CloseSubMenuOnClick = false;
            commandColorBarItem2.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.BackColor;
            commandColorBarItem2.Enabled = false;
            commandColorBarItem2.Hint = "Set the background color of the control";
            commandColorBarItem2.Id = 6;
            commandColorBarItem2.Name = "commandColorBarItem2";
            // 
            // barSubItem7
            // 
            barSubItem7.Caption = "&Font";
            barSubItem7.Id = 52;
            barSubItem7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem3)});
            barSubItem7.Name = "barSubItem7";
            // 
            // commandBarItem1
            // 
            commandBarItem1.Caption = "&Bold";
            commandBarItem1.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.FontBold;
            commandBarItem1.Enabled = false;
            commandBarItem1.Hint = "Make the font bold";
            commandBarItem1.Id = 2;
            commandBarItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B));
            commandBarItem1.Name = "commandBarItem1";
            // 
            // commandBarItem2
            // 
            commandBarItem2.Caption = "&Italic";
            commandBarItem2.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.FontItalic;
            commandBarItem2.Enabled = false;
            commandBarItem2.Hint = "Make the font italic";
            commandBarItem2.Id = 3;
            commandBarItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            commandBarItem2.Name = "commandBarItem2";
            // 
            // commandBarItem3
            // 
            commandBarItem3.Caption = "&Underline";
            commandBarItem3.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.FontUnderline;
            commandBarItem3.Enabled = false;
            commandBarItem3.Hint = "Underline the font";
            commandBarItem3.Id = 4;
            commandBarItem3.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            commandBarItem3.Name = "commandBarItem3";
            // 
            // barSubItem8
            // 
            barSubItem8.Caption = "&Justify";
            barSubItem8.Id = 53;
            barSubItem8.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem4, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem5),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem6),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem7)});
            barSubItem8.Name = "barSubItem8";
            // 
            // commandBarItem4
            // 
            commandBarItem4.Caption = "&Left";
            commandBarItem4.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.JustifyLeft;
            commandBarItem4.Enabled = false;
            commandBarItem4.Hint = "Align the control\'s text to the left";
            commandBarItem4.Id = 7;
            commandBarItem4.Name = "commandBarItem4";
            // 
            // commandBarItem5
            // 
            commandBarItem5.Caption = "&Center";
            commandBarItem5.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.JustifyCenter;
            commandBarItem5.Enabled = false;
            commandBarItem5.Hint = "Align the control\'s text to the center";
            commandBarItem5.Id = 8;
            commandBarItem5.Name = "commandBarItem5";
            // 
            // commandBarItem6
            // 
            commandBarItem6.Caption = "&Rights";
            commandBarItem6.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.JustifyRight;
            commandBarItem6.Enabled = false;
            commandBarItem6.Hint = "Align the control\'s text to the right";
            commandBarItem6.Id = 9;
            commandBarItem6.Name = "commandBarItem6";
            // 
            // commandBarItem7
            // 
            commandBarItem7.Caption = "&Justify";
            commandBarItem7.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.JustifyJustify;
            commandBarItem7.Enabled = false;
            commandBarItem7.Hint = "Justify the control\'s text";
            commandBarItem7.Id = 10;
            commandBarItem7.Name = "commandBarItem7";
            // 
            // barSubItem9
            // 
            barSubItem9.Caption = "&Align";
            barSubItem9.Id = 54;
            barSubItem9.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem9, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem10),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem11),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem12, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem13),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem14),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem8, true)});
            barSubItem9.Name = "barSubItem9";
            // 
            // commandBarItem9
            // 
            commandBarItem9.Caption = "&Lefts";
            commandBarItem9.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignLeft;
            commandBarItem9.Enabled = false;
            commandBarItem9.Hint = "Left align the selected controls";
            commandBarItem9.Id = 12;
            commandBarItem9.Name = "commandBarItem9";
            // 
            // commandBarItem10
            // 
            commandBarItem10.Caption = "&Centers";
            commandBarItem10.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignVerticalCenters;
            commandBarItem10.Enabled = false;
            commandBarItem10.Hint = "Align the centers of the selected controls vertically";
            commandBarItem10.Id = 13;
            commandBarItem10.Name = "commandBarItem10";
            // 
            // commandBarItem11
            // 
            commandBarItem11.Caption = "&Rights";
            commandBarItem11.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignRight;
            commandBarItem11.Enabled = false;
            commandBarItem11.Hint = "Right align the selected controls";
            commandBarItem11.Id = 14;
            commandBarItem11.Name = "commandBarItem11";
            // 
            // commandBarItem12
            // 
            commandBarItem12.Caption = "&Tops";
            commandBarItem12.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignTop;
            commandBarItem12.Enabled = false;
            commandBarItem12.Hint = "Align the tops of the selected controls";
            commandBarItem12.Id = 15;
            commandBarItem12.Name = "commandBarItem12";
            // 
            // commandBarItem13
            // 
            commandBarItem13.Caption = "&Middles";
            commandBarItem13.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignHorizontalCenters;
            commandBarItem13.Enabled = false;
            commandBarItem13.Hint = "Align the centers of the selected controls horizontally";
            commandBarItem13.Id = 16;
            commandBarItem13.Name = "commandBarItem13";
            // 
            // commandBarItem14
            // 
            commandBarItem14.Caption = "&Bottoms";
            commandBarItem14.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignBottom;
            commandBarItem14.Enabled = false;
            commandBarItem14.Hint = "Align the bottoms of the selected controls";
            commandBarItem14.Id = 17;
            commandBarItem14.Name = "commandBarItem14";
            // 
            // commandBarItem8
            // 
            commandBarItem8.Caption = "To &Grid";
            commandBarItem8.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.AlignToGrid;
            commandBarItem8.Enabled = false;
            commandBarItem8.Hint = "Align the positions of the selected controls to the grid";
            commandBarItem8.Id = 11;
            commandBarItem8.Name = "commandBarItem8";
            // 
            // barSubItem10
            // 
            barSubItem10.Caption = "&Make Same Size";
            barSubItem10.Id = 55;
            barSubItem10.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem15, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem16),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem17),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem18)});
            barSubItem10.Name = "barSubItem10";
            // 
            // commandBarItem15
            // 
            commandBarItem15.Caption = "&Width";
            commandBarItem15.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SizeToControlWidth;
            commandBarItem15.Enabled = false;
            commandBarItem15.Hint = "Make the selected controls have the same width";
            commandBarItem15.Id = 18;
            commandBarItem15.Name = "commandBarItem15";
            // 
            // commandBarItem16
            // 
            commandBarItem16.Caption = "Size to Gri&d";
            commandBarItem16.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SizeToGrid;
            commandBarItem16.Enabled = false;
            commandBarItem16.Hint = "Size the selected controls to the grid";
            commandBarItem16.Id = 19;
            commandBarItem16.Name = "commandBarItem16";
            // 
            // commandBarItem17
            // 
            commandBarItem17.Caption = "&Height";
            commandBarItem17.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SizeToControlHeight;
            commandBarItem17.Enabled = false;
            commandBarItem17.Hint = "Make the selected controls have the same height";
            commandBarItem17.Id = 20;
            commandBarItem17.Name = "commandBarItem17";
            // 
            // commandBarItem18
            // 
            commandBarItem18.Caption = "&Both";
            commandBarItem18.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SizeToControl;
            commandBarItem18.Enabled = false;
            commandBarItem18.Hint = "Make the selected controls the same size";
            commandBarItem18.Id = 21;
            commandBarItem18.Name = "commandBarItem18";
            // 
            // barSubItem11
            // 
            barSubItem11.Caption = "&Horizontal Spacing";
            barSubItem11.Id = 56;
            barSubItem11.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem19, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem20),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem21),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem22)});
            barSubItem11.Name = "barSubItem11";
            // 
            // commandBarItem19
            // 
            commandBarItem19.Caption = "Make &Equal";
            commandBarItem19.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.HorizSpaceMakeEqual;
            commandBarItem19.Enabled = false;
            commandBarItem19.Hint = "Make the spacing between the selected controls equal";
            commandBarItem19.Id = 22;
            commandBarItem19.Name = "commandBarItem19";
            // 
            // commandBarItem20
            // 
            commandBarItem20.Caption = "&Increase";
            commandBarItem20.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.HorizSpaceIncrease;
            commandBarItem20.Enabled = false;
            commandBarItem20.Hint = "Increase the spacing between the selected controls";
            commandBarItem20.Id = 23;
            commandBarItem20.Name = "commandBarItem20";
            // 
            // commandBarItem21
            // 
            commandBarItem21.Caption = "&Decrease";
            commandBarItem21.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.HorizSpaceDecrease;
            commandBarItem21.Enabled = false;
            commandBarItem21.Hint = "Decrease the spacing between the selected controls";
            commandBarItem21.Id = 24;
            commandBarItem21.Name = "commandBarItem21";
            // 
            // commandBarItem22
            // 
            commandBarItem22.Caption = "&Remove";
            commandBarItem22.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.HorizSpaceConcatenate;
            commandBarItem22.Enabled = false;
            commandBarItem22.Hint = "Remove the spacing between the selected controls";
            commandBarItem22.Id = 25;
            commandBarItem22.Name = "commandBarItem22";
            // 
            // barSubItem12
            // 
            barSubItem12.Caption = "&Vertical Spacing";
            barSubItem12.Id = 57;
            barSubItem12.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem23, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem24),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem25),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem26)});
            barSubItem12.Name = "barSubItem12";
            // 
            // commandBarItem23
            // 
            commandBarItem23.Caption = "Make &Equal";
            commandBarItem23.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.VertSpaceMakeEqual;
            commandBarItem23.Enabled = false;
            commandBarItem23.Hint = "Make the spacing between the selected controls equal";
            commandBarItem23.Id = 26;
            commandBarItem23.Name = "commandBarItem23";
            // 
            // commandBarItem24
            // 
            commandBarItem24.Caption = "&Increase";
            commandBarItem24.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.VertSpaceIncrease;
            commandBarItem24.Enabled = false;
            commandBarItem24.Hint = "Increase the spacing between the selected controls";
            commandBarItem24.Id = 27;
            commandBarItem24.Name = "commandBarItem24";
            // 
            // commandBarItem25
            // 
            commandBarItem25.Caption = "&Decrease";
            commandBarItem25.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.VertSpaceDecrease;
            commandBarItem25.Enabled = false;
            commandBarItem25.Hint = "Decrease the spacing between the selected controls";
            commandBarItem25.Id = 28;
            commandBarItem25.Name = "commandBarItem25";
            // 
            // commandBarItem26
            // 
            commandBarItem26.Caption = "&Remove";
            commandBarItem26.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.VertSpaceConcatenate;
            commandBarItem26.Enabled = false;
            commandBarItem26.Hint = "Remove the spacing between the selected controls";
            commandBarItem26.Id = 29;
            commandBarItem26.Name = "commandBarItem26";
            // 
            // barSubItem13
            // 
            barSubItem13.Caption = "&Center in Form";
            barSubItem13.Id = 58;
            barSubItem13.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem27, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem28)});
            barSubItem13.Name = "barSubItem13";
            // 
            // commandBarItem27
            // 
            commandBarItem27.Caption = "&Horizontally";
            commandBarItem27.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.CenterHorizontally;
            commandBarItem27.Enabled = false;
            commandBarItem27.Hint = "Horizontally center the selected controls within a band";
            commandBarItem27.Id = 30;
            commandBarItem27.Name = "commandBarItem27";
            // 
            // commandBarItem28
            // 
            commandBarItem28.Caption = "&Vertically";
            commandBarItem28.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.CenterVertically;
            commandBarItem28.Enabled = false;
            commandBarItem28.Hint = "Vertically center the selected controls within a band";
            commandBarItem28.Id = 31;
            commandBarItem28.Name = "commandBarItem28";
            // 
            // barSubItem14
            // 
            barSubItem14.Caption = "&Order";
            barSubItem14.Id = 59;
            barSubItem14.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem29, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem30)});
            barSubItem14.Name = "barSubItem14";
            // 
            // commandBarItem29
            // 
            commandBarItem29.Caption = "&Bring to Front";
            commandBarItem29.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.BringToFront;
            commandBarItem29.Enabled = false;
            commandBarItem29.Hint = "Bring the selected controls to the front";
            commandBarItem29.Id = 32;
            commandBarItem29.Name = "commandBarItem29";
            // 
            // commandBarItem30
            // 
            commandBarItem30.Caption = "&Send to Back";
            commandBarItem30.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.SendToBack;
            commandBarItem30.Enabled = false;
            commandBarItem30.Hint = "Move the selected controls to the back";
            commandBarItem30.Id = 33;
            commandBarItem30.Name = "commandBarItem30";
            // 
            // barSubItem15
            // 
            barSubItem15.Caption = "&Window";
            barSubItem15.Id = 65;
            barSubItem15.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarCheckItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem44),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem45),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem46),
            new DevExpress.XtraBars.LinkPersistInfo(barMdiChildrenListItem1, true)});
            barSubItem15.Name = "barSubItem15";
            // 
            // commandBarCheckItem1
            // 
            commandBarCheckItem1.BindableChecked = true;
            commandBarCheckItem1.Caption = "&Tabbed Interface";
            commandBarCheckItem1.Checked = true;
            commandBarCheckItem1.CheckedCommand = DevExpress.XtraReports.UserDesigner.ReportCommand.ShowTabbedInterface;
            commandBarCheckItem1.Enabled = false;
            commandBarCheckItem1.Hint = "Switch between tabbed and window MDI layout modes";
            commandBarCheckItem1.Id = 66;
            commandBarCheckItem1.Name = "commandBarCheckItem1";
            commandBarCheckItem1.UncheckedCommand = DevExpress.XtraReports.UserDesigner.ReportCommand.ShowWindowInterface;
            // 
            // commandBarItem44
            // 
            commandBarItem44.Caption = "&Cascade";
            commandBarItem44.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.MdiCascade;
            commandBarItem44.Enabled = false;
            commandBarItem44.Hint = "Arrange all open documents cascaded, so that they overlap each other";
            commandBarItem44.Id = 67;
            commandBarItem44.Name = "commandBarItem44";
            // 
            // commandBarItem45
            // 
            commandBarItem45.Caption = "Tile &Horizontal";
            commandBarItem45.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.MdiTileHorizontal;
            commandBarItem45.Enabled = false;
            commandBarItem45.Hint = "Arrange all open documents from top to bottom";
            commandBarItem45.Id = 68;
            commandBarItem45.Name = "commandBarItem45";
            // 
            // commandBarItem46
            // 
            commandBarItem46.Caption = "Tile &Vertical";
            commandBarItem46.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.MdiTileVertical;
            commandBarItem46.Enabled = false;
            commandBarItem46.Hint = "Arrange all open documents from left to right";
            commandBarItem46.Id = 69;
            commandBarItem46.Name = "commandBarItem46";
            // 
            // barMdiChildrenListItem1
            // 
            barMdiChildrenListItem1.Caption = "Windows";
            barMdiChildrenListItem1.Id = 70;
            barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // bsiLookAndFeel
            // 
            bsiLookAndFeel.Caption = "&Look and Feel";
            bsiLookAndFeel.Id = 74;
            bsiLookAndFeel.Name = "bsiLookAndFeel";
            // 
            // designBar2
            // 
            designBar2.BarName = "Toolbar";
            designBar2.DockCol = 0;
            designBar2.DockRow = 1;
            designBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            designBar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem31),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem32),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem33),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem34, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem35),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem36),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem37, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem38)});
            designBar2.Text = "Toolbar";
            // 
            // designBar3
            // 
            designBar3.BarName = "Formatting Toolbar";
            designBar3.DockCol = 1;
            designBar3.DockRow = 1;
            designBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            designBar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(barEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(barEditItem2),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem1),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem3),
            new DevExpress.XtraBars.LinkPersistInfo(commandColorBarItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandColorBarItem2),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem4, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem5),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem6),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem7)});
            designBar3.Text = "Formatting Toolbar";
            // 
            // barEditItem1
            // 
            barEditItem1.Caption = "Font Name";
            barEditItem1.Edit = recentlyUsedItemsComboBox1;
            barEditItem1.EditWidth = 120;
            barEditItem1.Hint = "Font Name";
            barEditItem1.Id = 0;
            barEditItem1.Name = "barEditItem1";
            // 
            // recentlyUsedItemsComboBox1
            // 
            recentlyUsedItemsComboBox1.AutoHeight = false;
            recentlyUsedItemsComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            recentlyUsedItemsComboBox1.DropDownRows = 12;
            recentlyUsedItemsComboBox1.Name = "recentlyUsedItemsComboBox1";
            // 
            // barEditItem2
            // 
            barEditItem2.Caption = "Font Size";
            barEditItem2.Edit = designRepositoryItemComboBox1;
            barEditItem2.EditWidth = 55;
            barEditItem2.Hint = "Font Size";
            barEditItem2.Id = 1;
            barEditItem2.Name = "barEditItem2";
            // 
            // designRepositoryItemComboBox1
            // 
            designRepositoryItemComboBox1.AutoHeight = false;
            designRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            designRepositoryItemComboBox1.Name = "designRepositoryItemComboBox1";
            // 
            // designBar4
            // 
            designBar4.BarName = "Layout Toolbar";
            designBar4.DockCol = 0;
            designBar4.DockRow = 2;
            designBar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            designBar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem8),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem9, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem10),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem11),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem12, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem13),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem14),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem15, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem16),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem17),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem18),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem19, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem20),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem21),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem22),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem23, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem24),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem25),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem26),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem27, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem28),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem29, true),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem30)});
            designBar4.Text = "Layout Toolbar";
            // 
            // designBar5
            // 
            designBar5.BarName = "Status Bar";
            designBar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            designBar5.DockCol = 0;
            designBar5.DockRow = 0;
            designBar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            designBar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(barStaticItem1)});
            designBar5.OptionsBar.AllowQuickCustomization = false;
            designBar5.OptionsBar.DrawDragBorder = false;
            designBar5.OptionsBar.DrawSizeGrip = true;
            designBar5.OptionsBar.UseWholeRow = true;
            designBar5.Text = "Status Bar";
            // 
            // barStaticItem1
            // 
            barStaticItem1.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            barStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            barStaticItem1.Id = 42;
            barStaticItem1.Name = "barStaticItem1";
            barStaticItem1.Size = new System.Drawing.Size(32, 0);
            barStaticItem1.Width = 32;
            // 
            // bar1
            // 
            bar1.BarName = "Zoom Toolbar";
            bar1.DockCol = 1;
            bar1.DockRow = 2;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem47),
            new DevExpress.XtraBars.LinkPersistInfo(xrZoomBarEditItem1),
            new DevExpress.XtraBars.LinkPersistInfo(commandBarItem48)});
            bar1.Text = "Zoom Toolbar";
            // 
            // commandBarItem47
            // 
            commandBarItem47.Caption = "Zoom Out";
            commandBarItem47.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.ZoomOut;
            commandBarItem47.Enabled = false;
            commandBarItem47.Hint = "Zoom out the design surface";
            commandBarItem47.Id = 71;
            commandBarItem47.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Subtract));
            commandBarItem47.Name = "commandBarItem47";
            // 
            // xrZoomBarEditItem1
            // 
            xrZoomBarEditItem1.Caption = "Zoom";
            xrZoomBarEditItem1.Edit = designRepositoryItemComboBox2;
            xrZoomBarEditItem1.EditWidth = 70;
            xrZoomBarEditItem1.Enabled = false;
            xrZoomBarEditItem1.Hint = "Select or input the zoom factor";
            xrZoomBarEditItem1.Id = 72;
            xrZoomBarEditItem1.Name = "xrZoomBarEditItem1";
            // 
            // designRepositoryItemComboBox2
            // 
            designRepositoryItemComboBox2.AutoComplete = false;
            designRepositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            designRepositoryItemComboBox2.Name = "designRepositoryItemComboBox2";
            // 
            // commandBarItem48
            // 
            commandBarItem48.Caption = "Zoom In";
            commandBarItem48.Command = DevExpress.XtraReports.UserDesigner.ReportCommand.ZoomIn;
            commandBarItem48.Enabled = false;
            commandBarItem48.Hint = "Zoom in the design surface";
            commandBarItem48.Id = 73;
            commandBarItem48.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Add));
            commandBarItem48.Name = "commandBarItem48";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = xrDesignBarManager1;
            barDockControlTop.Size = new System.Drawing.Size(901, 84);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 457);
            barDockControlBottom.Manager = xrDesignBarManager1;
            barDockControlBottom.Size = new System.Drawing.Size(901, 25);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 84);
            barDockControlLeft.Manager = xrDesignBarManager1;
            barDockControlLeft.Size = new System.Drawing.Size(29, 373);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(901, 84);
            barDockControlRight.Manager = xrDesignBarManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 373);
            // 
            // xrDesignDockManager1
            // 
            xrDesignDockManager1.Form = this;
            xrDesignDockManager1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("xrDesignDockManager1.ImageStream")));
            xrDesignDockManager1.MenuManager = xrDesignBarManager1;
            xrDesignDockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            panelContainer1,
            panelContainer3});
            xrDesignDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer1
            // 
            panelContainer1.Controls.Add(panelContainer2);
            panelContainer1.Controls.Add(propertyGridDockPanel1);
            panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            panelContainer1.ID = new System.Guid("73163da5-9eeb-4b18-8992-c9a9a9f93986");
            panelContainer1.Location = new System.Drawing.Point(526, 84);
            panelContainer1.Name = "panelContainer1";
            panelContainer1.OriginalSize = new System.Drawing.Size(375, 200);
            panelContainer1.SavedSizeFactor = 0D;
            panelContainer1.Size = new System.Drawing.Size(375, 373);
            panelContainer1.Text = "panelContainer1";
            // 
            // panelContainer2
            // 
            panelContainer2.ActiveChild = reportExplorerDockPanel1;
            panelContainer2.Controls.Add(reportExplorerDockPanel1);
            panelContainer2.Controls.Add(fieldListDockPanel1);
            panelContainer2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            panelContainer2.ID = new System.Guid("ec598d35-f04f-46c8-8b97-6b28f6c4dc4f");
            panelContainer2.Location = new System.Drawing.Point(0, 0);
            panelContainer2.Name = "panelContainer2";
            panelContainer2.OriginalSize = new System.Drawing.Size(248, 187);
            panelContainer2.SavedSizeFactor = 0D;
            panelContainer2.Size = new System.Drawing.Size(375, 173);
            panelContainer2.Tabbed = true;
            panelContainer2.Text = "panelContainer2";
            // 
            // reportExplorerDockPanel1
            // 
            reportExplorerDockPanel1.Controls.Add(reportExplorerDockPanel1_Container);
            reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            reportExplorerDockPanel1.ID = new System.Guid("fb3ec6cc-3b9b-4b9c-91cf-cff78c1edbf1");
            reportExplorerDockPanel1.Location = new System.Drawing.Point(5, 23);
            reportExplorerDockPanel1.Name = "reportExplorerDockPanel1";
            reportExplorerDockPanel1.OriginalSize = new System.Drawing.Size(239, 131);
            reportExplorerDockPanel1.SavedSizeFactor = 0D;
            reportExplorerDockPanel1.Size = new System.Drawing.Size(366, 117);
            reportExplorerDockPanel1.Text = "Report Explorer";
            // 
            // reportExplorerDockPanel1_Container
            // 
            reportExplorerDockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container";
            reportExplorerDockPanel1_Container.Size = new System.Drawing.Size(366, 117);
            reportExplorerDockPanel1_Container.TabIndex = 0;
            // 
            // fieldListDockPanel1
            // 
            fieldListDockPanel1.Controls.Add(fieldListDockPanel1_Container);
            fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            fieldListDockPanel1.ID = new System.Guid("faf69838-a93f-4114-83e8-d0d09cc5ce95");
            fieldListDockPanel1.Location = new System.Drawing.Point(5, 23);
            fieldListDockPanel1.Name = "fieldListDockPanel1";
            fieldListDockPanel1.OriginalSize = new System.Drawing.Size(239, 131);
            fieldListDockPanel1.SavedSizeFactor = 0D;
            fieldListDockPanel1.Size = new System.Drawing.Size(366, 117);
            fieldListDockPanel1.Text = "Field List";
            // 
            // fieldListDockPanel1_Container
            // 
            fieldListDockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container";
            fieldListDockPanel1_Container.Size = new System.Drawing.Size(366, 117);
            fieldListDockPanel1_Container.TabIndex = 0;
            // 
            // propertyGridDockPanel1
            // 
            propertyGridDockPanel1.Controls.Add(propertyGridDockPanel1_Container);
            propertyGridDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            propertyGridDockPanel1.ID = new System.Guid("b38d12c3-cd06-4dec-b93d-63a0088e495a");
            propertyGridDockPanel1.Location = new System.Drawing.Point(0, 173);
            propertyGridDockPanel1.Name = "propertyGridDockPanel1";
            propertyGridDockPanel1.OriginalSize = new System.Drawing.Size(248, 186);
            propertyGridDockPanel1.SavedSizeFactor = 0D;
            propertyGridDockPanel1.Size = new System.Drawing.Size(375, 200);
            propertyGridDockPanel1.Text = "Property Grid";
            // 
            // propertyGridDockPanel1_Container
            // 
            propertyGridDockPanel1_Container.Location = new System.Drawing.Point(5, 23);
            propertyGridDockPanel1_Container.Name = "propertyGridDockPanel1_Container";
            propertyGridDockPanel1_Container.Size = new System.Drawing.Size(366, 173);
            propertyGridDockPanel1_Container.TabIndex = 0;
            // 
            // panelContainer3
            // 
            panelContainer3.ActiveChild = groupAndSortDockPanel1;
            panelContainer3.Controls.Add(groupAndSortDockPanel1);
            panelContainer3.Controls.Add(errorListDockPanel1);
            panelContainer3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            panelContainer3.ID = new System.Guid("6027d502-d4b1-488d-b50b-ac2fbbd40bf8");
            panelContainer3.Location = new System.Drawing.Point(29, 297);
            panelContainer3.Name = "panelContainer3";
            panelContainer3.OriginalSize = new System.Drawing.Size(200, 160);
            panelContainer3.SavedSizeFactor = 0D;
            panelContainer3.Size = new System.Drawing.Size(497, 160);
            panelContainer3.Tabbed = true;
            panelContainer3.Text = "panelContainer3";
            // 
            // groupAndSortDockPanel1
            // 
            groupAndSortDockPanel1.Controls.Add(groupAndSortDockPanel1_Container);
            groupAndSortDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            groupAndSortDockPanel1.ID = new System.Guid("4bab159e-c495-4d67-87dc-f4e895da443e");
            groupAndSortDockPanel1.Location = new System.Drawing.Point(4, 24);
            groupAndSortDockPanel1.Name = "groupAndSortDockPanel1";
            groupAndSortDockPanel1.OriginalSize = new System.Drawing.Size(616, 104);
            groupAndSortDockPanel1.SavedSizeFactor = 0D;
            groupAndSortDockPanel1.Size = new System.Drawing.Size(489, 104);
            groupAndSortDockPanel1.Text = "Group and Sort";
            // 
            // groupAndSortDockPanel1_Container
            // 
            groupAndSortDockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            groupAndSortDockPanel1_Container.Name = "groupAndSortDockPanel1_Container";
            groupAndSortDockPanel1_Container.Size = new System.Drawing.Size(489, 104);
            groupAndSortDockPanel1_Container.TabIndex = 0;
            // 
            // errorListDockPanel1
            // 
            errorListDockPanel1.Controls.Add(errorListDockPanel1_Container);
            errorListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            errorListDockPanel1.ID = new System.Guid("5a9a01fd-6e95-4e81-a8c4-ac63153d7488");
            errorListDockPanel1.Location = new System.Drawing.Point(4, 24);
            errorListDockPanel1.Name = "errorListDockPanel1";
            errorListDockPanel1.OriginalSize = new System.Drawing.Size(616, 104);
            errorListDockPanel1.SavedSizeFactor = 0D;
            errorListDockPanel1.Size = new System.Drawing.Size(489, 104);
            errorListDockPanel1.Text = "Scripts Errors";
            // 
            // errorListDockPanel1_Container
            // 
            errorListDockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            errorListDockPanel1_Container.Name = "errorListDockPanel1_Container";
            errorListDockPanel1_Container.Size = new System.Drawing.Size(489, 104);
            errorListDockPanel1_Container.TabIndex = 0;
            // 
            // xrDesignMdiController1
            // 
            xrDesignMdiController1.ContainerControl = null;
            xrDesignPanelListener1.DesignControl = xrDesignBarManager1;
            xrDesignPanelListener2.DesignControl = xrDesignDockManager1;
            xrDesignPanelListener3.DesignControl = fieldListDockPanel1;
            xrDesignPanelListener4.DesignControl = propertyGridDockPanel1;
            xrDesignPanelListener5.DesignControl = reportExplorerDockPanel1;
            xrDesignPanelListener6.DesignControl = groupAndSortDockPanel1;
            xrDesignPanelListener7.DesignControl = errorListDockPanel1;
            xrDesignMdiController1.DesignPanelListeners.AddRange(new DevExpress.XtraReports.UserDesigner.XRDesignPanelListener[] {
            xrDesignPanelListener1,
            xrDesignPanelListener2,
            xrDesignPanelListener3,
            xrDesignPanelListener4,
            xrDesignPanelListener5,
            xrDesignPanelListener6,
            xrDesignPanelListener7});
            xrDesignMdiController1.Form = this;
            xrDesignMdiController1.XtraTabbedMdiManager = xtraTabbedMdiManager1;
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = this;
            xtraTabbedMdiManager1.MenuManager = xrDesignBarManager1;
            xtraTabbedMdiManager1.View = tabbedView1;
            xtraTabbedMdiManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            tabbedView1});
            // 
            // MainForm
            // 
            ClientSize = new System.Drawing.Size(901, 482);
            Controls.Add(panelContainer3);
            Controls.Add(panelContainer1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "Report Designer";
            ((System.ComponentModel.ISupportInitialize)(xrDesignBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(recentlyUsedItemsComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(designRepositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(designRepositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xrDesignDockManager1)).EndInit();
            panelContainer1.ResumeLayout(false);
            panelContainer2.ResumeLayout(false);
            reportExplorerDockPanel1.ResumeLayout(false);
            fieldListDockPanel1.ResumeLayout(false);
            propertyGridDockPanel1.ResumeLayout(false);
            panelContainer3.ResumeLayout(false);
            groupAndSortDockPanel1.ResumeLayout(false);
            errorListDockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(tabbedView1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        public void OpenReport(DevExpress.XtraReports.UI.XtraReport newReport) {
            xrDesignMdiController1.OpenReport(newReport);
        }
        public void CreateNewReport() {
            xrDesignMdiController1.CreateNewReport();
        }
        public XRDesignPanel ActiveXRDesignPanel {
            get { return xrDesignMdiController1.ActiveDesignPanel; }
        }
    }
}
