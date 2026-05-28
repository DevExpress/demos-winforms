using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using DevExpress.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.Map;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace DevExpress.XtraMap.Demos {
    public partial class MapTutorialControl : TutorialControlBase, IDXMenuManager {
        #region static
        public static string GetSaveFileName(string defaulName) {
            return GetSaveFileName("Xlsx files(*.xlsx)|*.xlsx|All files (*.*)|*.*", defaulName);
        }
        public static string GetSaveFileName(string filter, string defaulName) {
            using(SaveFileDialog sfDialog = new SaveFileDialog()) {
                sfDialog.Filter = filter;
                sfDialog.FileName = defaulName;
                if(sfDialog.ShowDialog() != DialogResult.OK)
                    return null;
                return sfDialog.FileName;
            }
        }
        public static void ShowFile(string fileName, TutorialControlBase control) {
            if(!File.Exists(fileName))
                return;
            DialogResult dResult = XtraMessageBox.Show(control.LookAndFeel, control, String.Format("Do you want to open the resulting file: {0} ?", fileName), control.TutorialName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dResult == DialogResult.Yes)
                Data.Utils.SafeProcess.Start(fileName);
        }
        #endregion
        #region fields
        readonly Dictionary<string, DXImageFormat> imageFormats = new Dictionary<string, DXImageFormat>() {
            { "bmp", DXImageFormat.Bmp },
            { "jpeg", DXImageFormat.Jpeg },
            { "gif", DXImageFormat.Gif },
            { "tiff", DXImageFormat.Tiff },
            { "png", DXImageFormat.Png }
        };
        private LookAndFeelMenu menu = null;
        private BarCheckItem chkShowNavPanel;
        private BarCheckItem chkNavigation;
        private BarCheckItem chkMiniMap;
        private BarButtonItem bbiZoomIn;
        private BarButtonItem bbiZoomOut;
        private BarButtonItem bbiInitialView;
        private XtraBars.Ribbon.RibbonPageGroup rpgView;
        protected XtraBars.Ribbon.RibbonControl ribbonControl1;
        protected XtraBars.Ribbon.RibbonPage rpOptions;
        #endregion
        public MapTutorialControl() {
            InitializeComponent();
            AutoMergeRibbon = true;
        }
        #region properties
        protected override bool? AllowRectangularBorderRounding { get { return true; } }
        protected virtual MapOverlay[] Overlays { get { return new MapOverlay[0]; } }
        protected virtual AzureTileset MiniMapAzureKind { get { return AzureTileset.Imagery; } }
        protected virtual MiniMapAlignment MiniMapAlignment { get { return MiniMapAlignment.BottomLeft; } }
        protected BarCheckItem ChkShowNavigationPanel { get { return chkShowNavPanel; } }
        protected BarCheckItem ChkShowMinimap { get { return chkMiniMap; } }
        protected BarCheckItem ChkLockNavigation { get { return chkNavigation; } }
        protected RibbonPage OptionsPage { get { return rpOptions; } }
        protected CoordPoint InitialCenterPoint { get; private set; }
        protected double InitialZoomFactor { get; private set; }
        public virtual MapControl MapControl { get { return null; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public LookAndFeelMenu DemoMainMenu {
            get { return menu; }
            set { menu = value; }
        }
        public virtual bool ShowOptions { get { return false; } }
        public virtual bool UseEmptyRootPadding { get { return true; } }
        #endregion
        #region initialize
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapTutorialControl));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            chkMiniMap = new DevExpress.XtraBars.BarCheckItem();
            chkShowNavPanel = new DevExpress.XtraBars.BarCheckItem();
            chkNavigation = new DevExpress.XtraBars.BarCheckItem();
            bbiZoomIn = new DevExpress.XtraBars.BarButtonItem();
            bbiZoomOut = new DevExpress.XtraBars.BarButtonItem();
            bbiInitialView = new DevExpress.XtraBars.BarButtonItem();
            rpOptions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            rpgView = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(ribbonControl1)).BeginInit();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            ribbonControl1.ExpandCollapseItem,
            chkMiniMap,
            chkShowNavPanel,
            chkNavigation,
            bbiZoomIn,
            bbiZoomOut,
            bbiInitialView});
            ribbonControl1.Location = new System.Drawing.Point(0, 0);
            ribbonControl1.MaxItemId = 7;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            rpOptions});
            ribbonControl1.Size = new System.Drawing.Size(500, 141);
            // 
            // chkShowMiniMap
            // 
            chkMiniMap.Caption = "Show Minimap";
            chkMiniMap.Id = 1;
            chkMiniMap.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Travel_Map;
            chkMiniMap.Name = "chkShowMiniMap";
            chkMiniMap.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(chkShowMiniMap_CheckedChanged);
            // 
            // chkShowNavPanel
            // 
            chkShowNavPanel.BindableChecked = true;
            chkShowNavPanel.Caption = "Show Navigation Panel";
            chkShowNavPanel.Checked = true;
            chkShowNavPanel.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.Action_NavigationBar;
            chkShowNavPanel.Id = 2;
            chkShowNavPanel.Name = "chkShowNavPanel";
            chkShowNavPanel.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(chkShowNavPanel_CheckedChanged);
            // 
            // chkLockNavigation
            // 
            chkNavigation.Caption = "Lock Navigation";
            chkNavigation.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.LockNavigation;
            chkNavigation.Id = 3;
            chkNavigation.Name = "chkLockNavigation";
            chkNavigation.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(chkLockNavigation_CheckedChanged);
            //this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
            // 
            // bbiZoomIn
            // 
            bbiZoomIn.Caption = "Zoom In";
            bbiZoomIn.Id = 4;
            bbiZoomIn.Name = "bbiZoomIn";
            bbiZoomIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiZoomIn_ItemClick);
            bbiZoomIn.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.ZoomIn;
            // 
            // bbiZoomOut
            // 
            bbiZoomOut.Caption = "Zoom Out";
            bbiZoomOut.Id = 5;
            bbiZoomOut.Name = "bbiZoomOut";
            bbiZoomOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiZoomOut_ItemClick);
            bbiZoomOut.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.ZoomOut;
            // 
            // bbiInitialView
            // 
            bbiInitialView.Caption = "Initial View";
            bbiInitialView.Id = 6;
            bbiInitialView.ImageOptions.SvgImage = global::DevExpress.XtraMap.Demos.Properties.Resources.InitialView;
            bbiInitialView.Name = "bbiInitialView";
            bbiInitialView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(bbiInitialView_ItemClick);
            // 
            // ribbonPage1
            // 
            rpOptions.Name = "ribbonPage1";
            rpOptions.Text = "Options";
            rpOptions.Groups.Add(rpgView);
            // 
            // ribbonPageGroup1
            // 
            rpgView.ItemLinks.Add(chkShowNavPanel);
            rpgView.ItemLinks.Add(chkNavigation);
            rpgView.ItemLinks.Add(chkMiniMap);
            rpgView.ItemLinks.Add(bbiZoomIn);
            rpgView.ItemLinks.Add(bbiZoomOut);
            rpgView.ItemLinks.Add(bbiInitialView);
            rpgView.Name = "ribbonPageGroup1";
            rpgView.Text = "View";
            // 
            // MapTutorialControl
            // 
            Controls.Add(ribbonControl1);
            Name = "MapTutorialControl";
            Size = new System.Drawing.Size(500, 500);
            Load += new System.EventHandler(MapTutorialControl_Load);
            ((System.ComponentModel.ISupportInitialize)(ribbonControl1)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion
        #region IDXMenuManager
        void IDXMenuManager.ShowPopupMenu(DXPopupMenu menu, Control control, System.Drawing.Point pos) {
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, this, control, pos);
        }
        IDXMenuManager IDXMenuManager.Clone(Form newForm) {
            return this;
        }
        void IDXMenuManager.DisposeManager() { }
        #endregion IDXMenuManager
        void InitializeMiniMap() {
            MiniMap miniMap = new MiniMap();
            miniMap.Behavior = new DynamicMiniMapBehavior() { ZoomOffset = -5 };
            miniMap.Layers.Add(CreateMiniMapLayer());
            miniMap.Alignment = MiniMapAlignment;
            MapControl.MiniMap = miniMap;
        }
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            BaseEdit be = ctrl as BaseEdit;
            if(be != null) be.MenuManager = manager;
        }
        protected override void AllowExport() {
            EnabledPrintExportActions(true, true,
                ExportFormats.PDF | ExportFormats.MHT | ExportFormats.RTF | ExportFormats.XLS | ExportFormats.XLSX | ExportFormats.Image | ExportFormats.DOCX,
                false);
        }
        protected override void PrintPreview() {
            if(MapControl != null)
                MapControl.ShowRibbonPrintPreview();
        }
        protected override void Print() {
            if(MapControl != null)
                MapControl.Print();
        }
        protected override void ExportToCore(string filename, string ext) {
            MapControl map = MapControl;
            if(map != null) {
                Cursor currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                if(ext == "rtf")
                    map.ExportToRtf(filename);
                else if(ext == "pdf")
                    map.ExportToPdf(filename);
                else if(ext == "mht")
                    map.ExportToMht(filename);
                else if(ext == "xls")
                    map.ExportToXls(filename);
                else if(ext == "xlsx")
                    map.ExportToXlsx(filename);
                else if(ext == "docx")
                    map.ExportToDocx(filename);
                Cursor.Current = currentCursor;
            }
        }
        public override bool Equals(object obj) {
            if(obj == null)
                return false;
            return GetType().Equals(obj.GetType());
        }
        public override int GetHashCode() {
            return GetType().GetHashCode();
        }
        protected override void ExportToImage() {
            if(MapControl == null)
                return;
            string fileName = MainFormHelper.GetFileName("", GetImageFormatsFilter());
            if(!string.IsNullOrEmpty(fileName))
                MapControl.ExportToImage(fileName, imageFormats[Path.GetExtension(fileName).TrimStart('.').ToLower()]);
        }
        protected virtual MiniMapLayerBase CreateMiniMapLayer() {
            MiniMapImageTilesLayer miniMapImageTilesLayer = new MiniMapImageTilesLayer();
            AzureMapDataProvider miniMapDataProvider = new AzureMapDataProvider();
            miniMapDataProvider.Tileset = MiniMapAzureKind;
            DemoUtils.SetAzureMapDataProviderKey(miniMapDataProvider);
            miniMapImageTilesLayer.DataProvider = miniMapDataProvider;
            return miniMapImageTilesLayer;
        }
        string GetImageFormatsFilter() {
            string result = string.Empty;
            foreach(string format in imageFormats.Keys)
                result += string.Format("{0} Image (*.{1})|*.{1}|", format.ToUpper(), format.ToLower());
            return result.TrimEnd('|');
        }
        void chkShowMiniMap_CheckedChanged(object sender, ItemClickEventArgs e) {
            if(MapControl.MiniMap == null)
                InitializeMiniMap();
            MapControl.MiniMap.Visible = ((BarCheckItem)e.Item).Checked;
        }
        void chkShowNavPanel_CheckedChanged(object sender, ItemClickEventArgs e) {
            if(MapControl != null)
                MapControl.NavigationPanelOptions.Visible = ((BarCheckItem)e.Item).Checked;
        }
        void chkLockNavigation_CheckedChanged(object sender, ItemClickEventArgs e) {
            ChangeEnableNavigation(!((BarCheckItem)e.Item).Checked);
        }
        void bbiZoomIn_ItemClick(object sender, ItemClickEventArgs e) {
            MapControl.ZoomIn();
        }
        void bbiZoomOut_ItemClick(object sender, ItemClickEventArgs e) {
            MapControl.ZoomOut();
        }
        void bbiInitialView_ItemClick(object sender, ItemClickEventArgs e) {
            RestoreInitialView();
        }
        protected virtual void RestoreInitialView() {
            MapControl.CenterPoint = InitialCenterPoint;
            MapControl.ZoomLevel = InitialZoomFactor;
        }
        protected virtual void ChangeEnableNavigation(bool enable) {
            MapControl.EnableScrolling = enable;
            MapControl.EnableZooming = enable;
            bbiZoomIn.Enabled = enable;
            bbiZoomOut.Enabled = enable;
        }
        protected virtual void InitRibbon() {
            chkMiniMap.Checked = MapControl != null &&
                                        MapControl.MiniMap != null &&
                                        MapControl.MiniMap.Visible;
            chkShowNavPanel.Checked = MapControl != null &&
                                        MapControl.NavigationPanelOptions != null &&
                                        MapControl.NavigationPanelOptions.Visible;
        }
        protected void DisableZoomOptions() {
            bbiZoomIn.Enabled = false;
            bbiZoomOut.Enabled = false;
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
        protected override void ExportToText() {
            ExportTo("txt", "Text document (*.txt)|*.txt");
        }
        protected override void ExportToDOCX() {
            ExportTo("docx", "DOCX document (*.docx)|*.docx");
        }
        public void AppendOverlays() {
            if(MapControl == null)
                return;
            MapOverlay[] overlays = Overlays;
            MapControl.Overlays.Clear();
            MapControl.Overlays.AddRange(overlays);
        }
        void MapTutorialControl_Load(object sender, EventArgs e) {
            InitRibbon();
            InitialCenterPoint = MapControl != null ? MapControl.CenterPoint : null;
            InitialZoomFactor = MapControl != null ? MapControl.ZoomLevel : 1;
        }
    }

    public static class MapModulesPool {
        const int MaxModulesCount = 5;
        static readonly List<MapTutorialControl> modules = new List<MapTutorialControl>(MaxModulesCount);
        static void UnregisterModule(MapTutorialControl module) {
            if(!modules.Contains(module))
                return;
            ModuleInfo moduleInfo = ModulesInfo.GetItem(module.TutorialName);
            moduleInfo.ResetModule();
            if(!module.IsDisposed)
                module.Dispose();
            modules.Remove(module);
        }
        public static void RegisterModule(MapTutorialControl module) {
            if(modules.Remove(module)) {
                modules.Add(module);
                return;
            }
            if(modules.Count == MaxModulesCount)
                UnregisterModule(modules[0]);
            modules.Add(module);
        }
        public static MapTutorialControl GetPreviousModule() {
            return modules.Count > 0 ? modules[modules.Count - 1] : null;
        }
    }
}
