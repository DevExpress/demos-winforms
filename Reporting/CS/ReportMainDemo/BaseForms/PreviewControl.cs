using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.Utils.VisualEffects;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.Extensions;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;

namespace XtraReportsDemos {
    /// <summary>
    /// Summary description for ModuleControl.
    /// </summary>
    public class PreviewControl : TutorialControlBase {
        #region inner classes
        protected class CustomDocumentViewer : DocumentViewer {
            public CustomDocumentViewer() {
                UseDirectXPaint = MainFormHelper.DirectXEnabled ? DefaultBoolean.True : DefaultBoolean.Default;
            }
            protected override void OnViewKeyDown(object sender, KeyEventArgs e) {
                if(e.KeyCode == Keys.H && e.Modifiers.HasFlag(Keys.Control) && e.Modifiers.HasFlag(Keys.Shift)) {
                    if(PrintingSystem != null) {
                        PrintingSystem.HighlightIntersectedBricks(Color.Red);
                        Invalidate(true);
                    }
                }
                else
                    base.OnViewKeyDown(sender, e);
            }
        }
        protected sealed class AdornerController : IDisposable {

            readonly IDictionary<string, object> adornerElements;
            AdornerUIManager adorner;
            Timer timer = new Timer() { Interval = 4000 };

            public AdornerController(IDictionary<string, object> adornerElements) {
                this.adornerElements = adornerElements;
                timer.Tick += OnTimerTick;
            }
            void OnTimerTick(object sender, EventArgs e) {
                HideGuides();
            }
            public void Dispose() {
                DisposeAdorner();
                DisposeTimer();
            }
            void DisposeTimer() {
                if(timer != null) {
                    timer.Tick -= OnTimerTick;
                    timer.Dispose();
                    timer = null;
                }
            }
            void DisposeAdorner() {
                if(adorner != null) {
                    adorner.ShowGuides = DefaultBoolean.False;
                    adorner.Click -= OnClick;
                    adorner.Dispose();
                    adorner = null;
                }
            }
            public void HideGuides() {
                if(timer != null)
                    timer.Stop();
                DisposeAdorner();
            }
            public void ShowGuides(ContainerControl owner, ReportModule module) {
                adorner = new AdornerUIManager() { Owner = owner };
                module.AddElements(adorner, adornerElements);
                if(adorner.Elements.Count > 0) {
                    timer.Start();
                    adorner.ShowGuides = DefaultBoolean.True;
                    adorner.Click += OnClick;
                }
            }
            void OnClick(object sender, MouseEventArgs e) {
                if(adorner != null)
                    adorner.Owner.BeginInvoke(new Action(HideGuides));
            }
        }
        #endregion

        #region fields
        protected DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private PrintPreviewBarItem printPreviewBarItem1;
        private DocumentViewerRibbonController documentViewerRibbonController1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private PrintPreviewStaticItem printPreviewStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private ProgressBarEditItem progressBarEditItem1;
        private RepositoryItemProgressBar repositoryItemProgressBar1;
        private PrintPreviewBarItem printPreviewBarItem48;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private PrintPreviewStaticItem printPreviewStaticItem2;
        private ZoomTrackBarEditItem zoomTrackBarEditItem1;
        private RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private PrintPreviewBarItem printPreviewBarItem2;
        private PrintPreviewBarItem printPreviewBarItem4;
        private PrintPreviewBarItem printPreviewBarItem3;
        private PrintPreviewBarItem printPreviewBarItem5;
        private PrintPreviewBarItem printPreviewBarItem6;
        private PrintPreviewBarItem printPreviewBarItem7;
        private PrintPreviewBarItem printPreviewBarItem9;
        private PrintPreviewBarItem printPreviewBarItem10;
        private PrintPreviewBarItem printPreviewBarItem11;
        private PrintPreviewBarItem printPreviewBarItem12;
        private PrintPreviewBarItem printPreviewBarItem13;
        private PrintPreviewBarItem printPreviewBarItem14;
        private PrintPreviewBarItem printPreviewBarItem15;
        private PrintPreviewBarItem printPreviewBarItem16;
        private PrintPreviewBarItem printPreviewBarItem17;
        private PrintPreviewBarItem printPreviewBarItem18;
        private PrintPreviewBarItem printPreviewBarItem19;
        private PrintPreviewBarItem printPreviewBarItem20;
        private PrintPreviewBarItem printPreviewBarItem21;
        private PrintPreviewBarItem printPreviewBarItem22;
        private PrintPreviewBarItem printPreviewBarItem23;
        private PrintPreviewBarItem printPreviewBarItem24;
        private PrintPreviewBarItem printPreviewBarItem25;
        private PrintPreviewBarItem printPreviewBarItem26;
        private PrintPreviewBarItem printPreviewBarItem27;
        private PrintPreviewBarItem printPreviewBarItem28;
        private PrintPreviewBarItem printPreviewBarItem29;
        private PrintPreviewBarItem printPreviewBarItem30;
        private PrintPreviewBarItem printPreviewBarItem31;
        private PrintPreviewBarItem printPreviewBarItem32;
        private PrintPreviewBarItem printPreviewBarItem33;
        private PrintPreviewBarItem printPreviewBarItem34;
        private PrintPreviewBarItem printPreviewBarItem35;
        private PrintPreviewBarItem printPreviewBarItem36;
        private PrintPreviewBarItem printPreviewBarItem37;
        private PrintPreviewBarItem printPreviewBarItem38;
        private PrintPreviewBarItem printPreviewBarItem39;
        private PrintPreviewBarItem printPreviewBarItem40;
        private PrintPreviewBarItem printPreviewBarItem41;
        private PrintPreviewBarItem printPreviewBarItem42;
        private PrintPreviewBarItem printPreviewBarItem43;
        private PrintPreviewBarItem printPreviewBarItem44;
        private PrintPreviewBarItem printPreviewBarItem45;
        private PrintPreviewBarItem printPreviewBarItem46;
        private PrintPreviewBarItem printPreviewBarItem47;
        private PrintPreviewRibbonPage ribbonPage1;
        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup1;
        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup2;
        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup3;
        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup4;
        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup5;
        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup6;
        private PrintPreviewRibbonPageGroup printPreviewRibbonPageGroup7;
        protected CustomDocumentViewer printControl;
        protected DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.ComponentModel.IContainer components;
        private PrintPreviewBarItem printPreviewBarItem8;
        private RoundedSkinPanel roundedSkinPanel1;
        private DevExpress.XtraLayout.LayoutControl lcc;
        private DevExpress.XtraLayout.LayoutControlGroup lcgRoot;
        private DevExpress.XtraLayout.LayoutControlItem lciContent;
        private DevExpress.XtraLayout.LayoutControlItem lciHeader;

        ReportModule module;
        AdornerController _adornerController;
        #endregion

        public PreviewControl() {
            InitializeComponent();
            AutoMergeRibbon = true;
            UpdateRoundedSkinPanel();
            _adornerController = new AdornerController(
                new Dictionary<string, object>() { { "PageSetup", printPreviewBarItem26 } }
            );
        }
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(_adornerController != null) {
                    _adornerController.Dispose();
                    _adornerController = null;
                }
            }
            base.Dispose(disposing);
        }
        public void Initialize(RibbonMenuManager manager) {
            RibbonMenuManager = manager;
            DevExpress.XtraBars.Docking.DockPanel documentMapPanel = printControl.GetDockPanel(PreviewDockPanelKind.DocumentMap);
            if(documentMapPanel != null) {
                documentMapPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
                documentMapPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            }
        }
        public void Deactivate() {
            if(DesignMode) return;
            printControl.DocumentSource = null;
            if(_adornerController != null)
                _adornerController.HideGuides();
        }
        public void Activate(ReportModule module) {
            if(DesignMode) return;

            _adornerController.HideGuides();
            this.module = module;
            this.module.Viewer = printControl;
            this.module.SetPreviewRibbon(ribbonControl1);
            this.module.Activate();
            UpdateHeader();
            UpdateRoundedSkinPanel();
            if(RibbonOwnerForm.Ribbon.SelectedPage.Text == "Print Preview")
                _adornerController.ShowGuides((ContainerControl)RibbonOwnerForm, this.module);
            printControl.Invalidate(true);

            bool hasModuleFileName = !string.IsNullOrEmpty(module.FileName);
            barButtonItem2.Enabled = hasModuleFileName;
            if(hasModuleFileName)
                SafeDeleteFile(this.module.FileName);
        }

        void UpdateHeader() {
            lcc.BeginInit();
            if(lciHeader.Control != null) {
                lcc.Controls.Remove(lciHeader.Control);
                lciHeader.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            lciHeader.Control = module?.HeaderContent;
            if(lciHeader.Control != null) {
                lcc.Controls.Add(lciHeader.Control);
                lciHeader.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
            lcc.EndInit();
            UpdateHeaderBottomSpacing();
        }

        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateHeaderBottomSpacing();
        }

        protected override bool? UseRoundedPanel => false;

        void UpdateHeaderBottomSpacing() {
            lciHeader.Spacing = new DevExpress.XtraLayout.Utils.Padding(
                            lciHeader.Spacing.Left,
                            lciHeader.Spacing.Right,
                            lciHeader.Spacing.Top,
                            -roundedSkinPanel1.DisplayRectangle.Y
                            );
        }

        protected virtual XtraReport Report {
            get { return module != null ? module.Report : null; }
        }
        void UpdateRoundedSkinPanel() {
            //bool useRoundedPanel = module != null && !module.GetUseRoundedPanel();
            //roundedSkinPanel1.BorderStyle = useRoundedPanel
            //    ? RoundedPanelBorderStyle.Default
            //    : RoundedPanelBorderStyle.Rectangular;
            //roundedSkinPanel1.UseDefaultPadding = useRoundedPanel
            //    ? DefaultBoolean.True
            //    : DefaultBoolean.False;
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip4 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem4 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip5 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem5 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip6 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem6 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip7 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem7 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem7 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip8 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem8 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem8 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip9 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem9 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem9 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip10 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem10 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem10 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip11 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem11 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem11 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip12 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem12 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem12 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip13 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem13 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem13 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip14 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem14 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem14 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip15 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem15 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem15 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip16 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem16 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem16 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip17 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem17 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem17 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip18 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem18 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem18 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip19 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem19 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem19 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip20 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem20 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem20 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip21 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem21 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem21 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip22 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem22 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem22 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip23 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem23 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem23 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip24 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem24 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem24 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip25 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem25 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem25 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip26 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem26 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem26 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip27 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem27 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem27 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip28 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem28 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem28 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip29 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem29 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem29 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip30 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem30 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem30 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip31 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem31 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem31 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip32 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem32 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem32 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip33 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem33 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem33 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip34 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem34 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem34 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip35 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem35 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem35 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip36 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem36 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem36 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip37 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem37 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem37 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip38 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem38 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem38 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip39 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem39 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem39 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip40 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem40 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem40 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip41 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem41 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem41 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip42 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem42 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem42 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip43 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem43 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem43 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip44 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem44 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem44 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip45 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem45 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem45 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip46 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem46 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem46 = new DevExpress.Utils.ToolTipItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewControl));
            DevExpress.Utils.SuperToolTip superToolTip47 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem47 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem47 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip48 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem48 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem48 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip49 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem49 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem49 = new DevExpress.Utils.ToolTipItem();
            this.lcc = new DevExpress.XtraLayout.LayoutControl();
            this.roundedSkinPanel1 = new DevExpress.XtraEditors.RoundedSkinPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.printControl = new XtraReportsDemos.PreviewControl.CustomDocumentViewer();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.printPreviewStaticItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.progressBarEditItem1 = new DevExpress.XtraPrinting.Preview.ProgressBarEditItem();
            this.documentViewerRibbonController1 = new DevExpress.XtraPrinting.Preview.DocumentViewerRibbonController(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.printPreviewBarItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem3 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem4 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem5 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem6 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem7 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem9 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem10 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem11 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem12 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem13 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem14 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem15 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem16 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem17 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem18 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem19 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem20 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem21 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem22 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem23 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem24 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem25 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem26 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem27 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem28 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem29 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem30 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem31 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem32 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem33 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem34 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem35 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem36 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem37 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem38 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem39 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem40 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem41 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem42 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem43 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem44 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem45 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem46 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem47 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.printPreviewBarItem48 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.printPreviewStaticItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
            this.zoomTrackBarEditItem1 = new DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.printPreviewBarItem8 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
            this.ribbonPage1 = new DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.printPreviewRibbonPageGroup1 = new DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup();
            this.printPreviewRibbonPageGroup2 = new DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup();
            this.printPreviewRibbonPageGroup3 = new DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup();
            this.printPreviewRibbonPageGroup4 = new DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup();
            this.printPreviewRibbonPageGroup5 = new DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup();
            this.printPreviewRibbonPageGroup6 = new DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup();
            this.printPreviewRibbonPageGroup7 = new DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroup();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.lcgRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciHeader = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciContent = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcc)).BeginInit();
            this.lcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel1)).BeginInit();
            this.roundedSkinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerRibbonController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).BeginInit();
            this.SuspendLayout();
            // 
            // lcc
            // 
            this.lcc.Controls.Add(this.roundedSkinPanel1);
            this.lcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcc.Location = new System.Drawing.Point(0, 307);
            this.lcc.Margin = new System.Windows.Forms.Padding(0);
            this.lcc.Name = "lcc";
            this.lcc.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1834, 0, 1300, 800);
            this.lcc.Root = this.lcgRoot;
            this.lcc.Size = new System.Drawing.Size(1116, 167);
            this.lcc.TabIndex = 0;
            // 
            // roundedSkinPanel1
            // 
            this.roundedSkinPanel1.Controls.Add(this.panelControl1);
            this.roundedSkinPanel1.Location = new System.Drawing.Point(0, 54);
            this.roundedSkinPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.roundedSkinPanel1.Name = "roundedSkinPanel1";
            this.roundedSkinPanel1.Size = new System.Drawing.Size(1116, 113);
            this.roundedSkinPanel1.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.printControl);
            this.panelControl1.Controls.Add(this.ribbonStatusBar1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(34, 34);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.MinimumSize = new System.Drawing.Size(64, 64);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1048, 64);
            this.panelControl1.TabIndex = 4;
            // 
            // printControl
            // 
            this.printControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printControl.IsMetric = false;
            this.printControl.Location = new System.Drawing.Point(0, 0);
            this.printControl.Margin = new System.Windows.Forms.Padding(0);
            this.printControl.Name = "printControl";
            this.printControl.Size = new System.Drawing.Size(1048, 0);
            this.printControl.TabIndex = 1;
            this.printControl.UseAsyncDocumentCreation = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.printPreviewStaticItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.barStaticItem1, true);
            this.ribbonStatusBar1.ItemLinks.Add(this.progressBarEditItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.printPreviewBarItem48);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.printPreviewStaticItem2);
            this.ribbonStatusBar1.ItemLinks.Add(this.zoomTrackBarEditItem1);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, -14);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(0);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1048, 78);
            // 
            // printPreviewStaticItem1
            // 
            this.printPreviewStaticItem1.Caption = "Nothing";
            this.printPreviewStaticItem1.Id = 48;
            this.printPreviewStaticItem1.LeftIndent = 1;
            this.printPreviewStaticItem1.Name = "printPreviewStaticItem1";
            this.printPreviewStaticItem1.RightIndent = 1;
            this.printPreviewStaticItem1.Type = "PageOfPages";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 49;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;
            // 
            // progressBarEditItem1
            // 
            this.progressBarEditItem1.ContextSpecifier = this.documentViewerRibbonController1;
            this.progressBarEditItem1.Edit = this.repositoryItemProgressBar1;
            this.progressBarEditItem1.EditHeight = 12;
            this.progressBarEditItem1.EditWidth = 150;
            this.progressBarEditItem1.Id = 50;
            this.progressBarEditItem1.Name = "progressBarEditItem1";
            this.progressBarEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // documentViewerRibbonController1
            // 
            this.documentViewerRibbonController1.DocumentViewer = this.printControl;
            this.documentViewerRibbonController1.RibbonControl = this.ribbonControl1;
            this.documentViewerRibbonController1.RibbonStatusBar = this.ribbonStatusBar1;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.printPreviewBarItem1,
            this.printPreviewBarItem2,
            this.printPreviewBarItem3,
            this.printPreviewBarItem4,
            this.printPreviewBarItem5,
            this.printPreviewBarItem6,
            this.printPreviewBarItem7,
            this.printPreviewBarItem9,
            this.printPreviewBarItem10,
            this.printPreviewBarItem11,
            this.printPreviewBarItem12,
            this.printPreviewBarItem13,
            this.printPreviewBarItem14,
            this.printPreviewBarItem15,
            this.printPreviewBarItem16,
            this.printPreviewBarItem17,
            this.printPreviewBarItem18,
            this.printPreviewBarItem19,
            this.printPreviewBarItem20,
            this.printPreviewBarItem21,
            this.printPreviewBarItem22,
            this.printPreviewBarItem23,
            this.printPreviewBarItem24,
            this.printPreviewBarItem25,
            this.printPreviewBarItem26,
            this.printPreviewBarItem27,
            this.printPreviewBarItem28,
            this.printPreviewBarItem29,
            this.printPreviewBarItem30,
            this.printPreviewBarItem31,
            this.printPreviewBarItem32,
            this.printPreviewBarItem33,
            this.printPreviewBarItem34,
            this.printPreviewBarItem35,
            this.printPreviewBarItem36,
            this.printPreviewBarItem37,
            this.printPreviewBarItem38,
            this.printPreviewBarItem39,
            this.printPreviewBarItem40,
            this.printPreviewBarItem41,
            this.printPreviewBarItem42,
            this.printPreviewBarItem43,
            this.printPreviewBarItem44,
            this.printPreviewBarItem45,
            this.printPreviewBarItem46,
            this.printPreviewBarItem47,
            this.printPreviewStaticItem1,
            this.barStaticItem1,
            this.progressBarEditItem1,
            this.printPreviewBarItem48,
            this.barButtonItem1,
            this.printPreviewStaticItem2,
            this.zoomTrackBarEditItem1,
            this.barButtonItem2,
            this.printPreviewBarItem8});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 68;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1,
            this.repositoryItemZoomTrackBar1});
            this.ribbonControl1.Size = new System.Drawing.Size(1116, 307);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // printPreviewBarItem1
            // 
            this.printPreviewBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.printPreviewBarItem1.Caption = "Bookmarks";
            this.printPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap;
            this.printPreviewBarItem1.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem1.Enabled = false;
            this.printPreviewBarItem1.Id = 1;
            this.printPreviewBarItem1.Name = "printPreviewBarItem1";
            superToolTip1.FixedTooltipWidth = true;
            toolTipTitleItem1.Text = "Document Map";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Open the Document Map, which allows you to navigate through a structural view of " +
    "the document.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.MaxWidth = 210;
            this.printPreviewBarItem1.SuperTip = superToolTip1;
            // 
            // printPreviewBarItem2
            // 
            this.printPreviewBarItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.printPreviewBarItem2.Caption = "Parameters";
            this.printPreviewBarItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Parameters;
            this.printPreviewBarItem2.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem2.Enabled = false;
            this.printPreviewBarItem2.Id = 2;
            this.printPreviewBarItem2.Name = "printPreviewBarItem2";
            superToolTip2.FixedTooltipWidth = true;
            toolTipTitleItem2.Text = "Parameters";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Open the Parameters pane, which allows you to enter values for report parameters." +
    "";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            superToolTip2.MaxWidth = 210;
            this.printPreviewBarItem2.SuperTip = superToolTip2;
            // 
            // printPreviewBarItem3
            // 
            this.printPreviewBarItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.printPreviewBarItem3.Caption = "Find";
            this.printPreviewBarItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find;
            this.printPreviewBarItem3.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem3.Enabled = false;
            this.printPreviewBarItem3.Id = 3;
            this.printPreviewBarItem3.Name = "printPreviewBarItem3";
            superToolTip3.FixedTooltipWidth = true;
            toolTipTitleItem3.Text = "Find";
            toolTipItem3.LeftIndent = 6;
            toolTipItem3.Text = "Show the Find dialog to find text in the document.";
            superToolTip3.Items.Add(toolTipTitleItem3);
            superToolTip3.Items.Add(toolTipItem3);
            superToolTip3.MaxWidth = 210;
            this.printPreviewBarItem3.SuperTip = superToolTip3;
            // 
            // printPreviewBarItem4
            // 
            this.printPreviewBarItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.printPreviewBarItem4.Caption = "Thumbnails";
            this.printPreviewBarItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Thumbnails;
            this.printPreviewBarItem4.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem4.Enabled = false;
            this.printPreviewBarItem4.Id = 4;
            this.printPreviewBarItem4.Name = "printPreviewBarItem4";
            superToolTip4.FixedTooltipWidth = true;
            toolTipTitleItem4.Text = "Thumbnails";
            toolTipItem4.LeftIndent = 6;
            toolTipItem4.Text = "Open the Thumbnails, which allows you to navigate through the document.";
            superToolTip4.Items.Add(toolTipTitleItem4);
            superToolTip4.Items.Add(toolTipItem4);
            superToolTip4.MaxWidth = 210;
            this.printPreviewBarItem4.SuperTip = superToolTip4;
            // 
            // printPreviewBarItem5
            // 
            this.printPreviewBarItem5.Caption = "Print";
            this.printPreviewBarItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print;
            this.printPreviewBarItem5.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem5.Enabled = false;
            this.printPreviewBarItem5.Id = 5;
            this.printPreviewBarItem5.Name = "printPreviewBarItem5";
            superToolTip5.FixedTooltipWidth = true;
            toolTipTitleItem5.Text = "Print (Ctrl+P)";
            toolTipItem5.LeftIndent = 6;
            toolTipItem5.Text = "Select a printer, number of copies and other printing options before printing.";
            superToolTip5.Items.Add(toolTipTitleItem5);
            superToolTip5.Items.Add(toolTipItem5);
            superToolTip5.MaxWidth = 210;
            this.printPreviewBarItem5.SuperTip = superToolTip5;
            // 
            // printPreviewBarItem6
            // 
            this.printPreviewBarItem6.Caption = "Quick Print";
            this.printPreviewBarItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect;
            this.printPreviewBarItem6.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem6.Enabled = false;
            this.printPreviewBarItem6.Id = 6;
            this.printPreviewBarItem6.Name = "printPreviewBarItem6";
            superToolTip6.FixedTooltipWidth = true;
            toolTipTitleItem6.Text = "Quick Print";
            toolTipItem6.LeftIndent = 6;
            toolTipItem6.Text = "Send the document directly to the default printer without making changes.";
            superToolTip6.Items.Add(toolTipTitleItem6);
            superToolTip6.Items.Add(toolTipItem6);
            superToolTip6.MaxWidth = 210;
            this.printPreviewBarItem6.SuperTip = superToolTip6;
            // 
            // printPreviewBarItem7
            // 
            this.printPreviewBarItem7.Caption = "Custom Margins...";
            this.printPreviewBarItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup;
            this.printPreviewBarItem7.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem7.Enabled = false;
            this.printPreviewBarItem7.Id = 7;
            this.printPreviewBarItem7.Name = "printPreviewBarItem7";
            superToolTip7.FixedTooltipWidth = true;
            toolTipTitleItem7.Text = "Page Setup";
            toolTipItem7.LeftIndent = 6;
            toolTipItem7.Text = "Show the Page Setup dialog.";
            superToolTip7.Items.Add(toolTipTitleItem7);
            superToolTip7.Items.Add(toolTipItem7);
            superToolTip7.MaxWidth = 210;
            this.printPreviewBarItem7.SuperTip = superToolTip7;
            // 
            // printPreviewBarItem9
            // 
            this.printPreviewBarItem9.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.printPreviewBarItem9.Caption = "Scale";
            this.printPreviewBarItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale;
            this.printPreviewBarItem9.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem9.Enabled = false;
            this.printPreviewBarItem9.Id = 9;
            this.printPreviewBarItem9.Name = "printPreviewBarItem9";
            superToolTip8.FixedTooltipWidth = true;
            toolTipTitleItem8.Text = "Scale";
            toolTipItem8.LeftIndent = 6;
            toolTipItem8.Text = "Stretch or shrink the printed output to a percentage of its actual size.";
            superToolTip8.Items.Add(toolTipTitleItem8);
            superToolTip8.Items.Add(toolTipItem8);
            superToolTip8.MaxWidth = 210;
            this.printPreviewBarItem9.SuperTip = superToolTip8;
            // 
            // printPreviewBarItem10
            // 
            this.printPreviewBarItem10.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.printPreviewBarItem10.Caption = "Pointer";
            this.printPreviewBarItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Pointer;
            this.printPreviewBarItem10.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem10.Down = true;
            this.printPreviewBarItem10.Enabled = false;
            this.printPreviewBarItem10.GroupIndex = 1;
            this.printPreviewBarItem10.Id = 10;
            this.printPreviewBarItem10.Name = "printPreviewBarItem10";
            this.printPreviewBarItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            superToolTip9.FixedTooltipWidth = true;
            toolTipTitleItem9.Text = "Mouse Pointer";
            toolTipItem9.LeftIndent = 6;
            toolTipItem9.Text = "Show the mouse pointer.";
            superToolTip9.Items.Add(toolTipTitleItem9);
            superToolTip9.Items.Add(toolTipItem9);
            superToolTip9.MaxWidth = 210;
            this.printPreviewBarItem10.SuperTip = superToolTip9;
            // 
            // printPreviewBarItem11
            // 
            this.printPreviewBarItem11.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.printPreviewBarItem11.Caption = "Hand Tool";
            this.printPreviewBarItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool;
            this.printPreviewBarItem11.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem11.Enabled = false;
            this.printPreviewBarItem11.GroupIndex = 1;
            this.printPreviewBarItem11.Id = 11;
            this.printPreviewBarItem11.Name = "printPreviewBarItem11";
            this.printPreviewBarItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            superToolTip10.FixedTooltipWidth = true;
            toolTipTitleItem10.Text = "Hand Tool";
            toolTipItem10.LeftIndent = 6;
            toolTipItem10.Text = "Invoke the Hand tool to manually scroll through pages.";
            superToolTip10.Items.Add(toolTipTitleItem10);
            superToolTip10.Items.Add(toolTipItem10);
            superToolTip10.MaxWidth = 210;
            this.printPreviewBarItem11.SuperTip = superToolTip10;
            // 
            // printPreviewBarItem12
            // 
            this.printPreviewBarItem12.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.printPreviewBarItem12.Caption = "Magnifier";
            this.printPreviewBarItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier;
            this.printPreviewBarItem12.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem12.Enabled = false;
            this.printPreviewBarItem12.GroupIndex = 1;
            this.printPreviewBarItem12.Id = 12;
            this.printPreviewBarItem12.Name = "printPreviewBarItem12";
            this.printPreviewBarItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            superToolTip11.FixedTooltipWidth = true;
            toolTipTitleItem11.Text = "Magnifier";
            toolTipItem11.LeftIndent = 6;
            toolTipItem11.Text = "Invoke the Magnifier tool.\r\n\r\nClicking once on a document zooms it so that a sing" +
    "le page becomes entirely visible, while clicking another time zooms it to 100% o" +
    "f the normal size.";
            superToolTip11.Items.Add(toolTipTitleItem11);
            superToolTip11.Items.Add(toolTipItem11);
            superToolTip11.MaxWidth = 210;
            this.printPreviewBarItem12.SuperTip = superToolTip11;
            // 
            // printPreviewBarItem13
            // 
            this.printPreviewBarItem13.Caption = "Zoom Out";
            this.printPreviewBarItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut;
            this.printPreviewBarItem13.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem13.Enabled = false;
            this.printPreviewBarItem13.Id = 13;
            this.printPreviewBarItem13.Name = "printPreviewBarItem13";
            superToolTip12.FixedTooltipWidth = true;
            toolTipTitleItem12.Text = "Zoom Out";
            toolTipItem12.LeftIndent = 6;
            toolTipItem12.Text = "Zoom out to see more of the page at a reduced size.";
            superToolTip12.Items.Add(toolTipTitleItem12);
            superToolTip12.Items.Add(toolTipItem12);
            superToolTip12.MaxWidth = 210;
            this.printPreviewBarItem13.SuperTip = superToolTip12;
            // 
            // printPreviewBarItem14
            // 
            this.printPreviewBarItem14.Caption = "Zoom In";
            this.printPreviewBarItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn;
            this.printPreviewBarItem14.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem14.Enabled = false;
            this.printPreviewBarItem14.Id = 14;
            this.printPreviewBarItem14.Name = "printPreviewBarItem14";
            superToolTip13.FixedTooltipWidth = true;
            toolTipTitleItem13.Text = "Zoom In";
            toolTipItem13.LeftIndent = 6;
            toolTipItem13.Text = "Zoom in to get a close-up view of the document.";
            superToolTip13.Items.Add(toolTipTitleItem13);
            superToolTip13.Items.Add(toolTipItem13);
            superToolTip13.MaxWidth = 210;
            this.printPreviewBarItem14.SuperTip = superToolTip13;
            // 
            // printPreviewBarItem15
            // 
            this.printPreviewBarItem15.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.printPreviewBarItem15.Caption = "Zoom";
            this.printPreviewBarItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Zoom;
            this.printPreviewBarItem15.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem15.Enabled = false;
            this.printPreviewBarItem15.Id = 15;
            this.printPreviewBarItem15.Name = "printPreviewBarItem15";
            superToolTip14.FixedTooltipWidth = true;
            toolTipTitleItem14.Text = "Zoom";
            toolTipItem14.LeftIndent = 6;
            toolTipItem14.Text = "Change the zoom level of the document preview.";
            superToolTip14.Items.Add(toolTipTitleItem14);
            superToolTip14.Items.Add(toolTipItem14);
            superToolTip14.MaxWidth = 210;
            this.printPreviewBarItem15.SuperTip = superToolTip14;
            // 
            // printPreviewBarItem16
            // 
            this.printPreviewBarItem16.Caption = "First Page";
            this.printPreviewBarItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage;
            this.printPreviewBarItem16.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem16.Enabled = false;
            this.printPreviewBarItem16.Id = 16;
            this.printPreviewBarItem16.Name = "printPreviewBarItem16";
            superToolTip15.FixedTooltipWidth = true;
            toolTipTitleItem15.Text = "First Page (Home)";
            toolTipItem15.LeftIndent = 6;
            toolTipItem15.Text = "Navigate to the first page of the document.";
            superToolTip15.Items.Add(toolTipTitleItem15);
            superToolTip15.Items.Add(toolTipItem15);
            superToolTip15.MaxWidth = 210;
            this.printPreviewBarItem16.SuperTip = superToolTip15;
            // 
            // printPreviewBarItem17
            // 
            this.printPreviewBarItem17.Caption = "Previous Page";
            this.printPreviewBarItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage;
            this.printPreviewBarItem17.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem17.Enabled = false;
            this.printPreviewBarItem17.Id = 17;
            this.printPreviewBarItem17.Name = "printPreviewBarItem17";
            superToolTip16.FixedTooltipWidth = true;
            toolTipTitleItem16.Text = "Previous Page (Left Arrow)";
            toolTipItem16.LeftIndent = 6;
            toolTipItem16.Text = "Navigate to the previous page of the document.";
            superToolTip16.Items.Add(toolTipTitleItem16);
            superToolTip16.Items.Add(toolTipItem16);
            superToolTip16.MaxWidth = 210;
            this.printPreviewBarItem17.SuperTip = superToolTip16;
            // 
            // printPreviewBarItem18
            // 
            this.printPreviewBarItem18.Caption = "Next  Page ";
            this.printPreviewBarItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage;
            this.printPreviewBarItem18.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem18.Enabled = false;
            this.printPreviewBarItem18.Id = 18;
            this.printPreviewBarItem18.Name = "printPreviewBarItem18";
            superToolTip17.FixedTooltipWidth = true;
            toolTipTitleItem17.Text = "Next Page (Right Arrow)";
            toolTipItem17.LeftIndent = 6;
            toolTipItem17.Text = "Navigate to the next page of the document.";
            superToolTip17.Items.Add(toolTipTitleItem17);
            superToolTip17.Items.Add(toolTipItem17);
            superToolTip17.MaxWidth = 210;
            this.printPreviewBarItem18.SuperTip = superToolTip17;
            // 
            // printPreviewBarItem19
            // 
            this.printPreviewBarItem19.Caption = "Last  Page ";
            this.printPreviewBarItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage;
            this.printPreviewBarItem19.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem19.Enabled = false;
            this.printPreviewBarItem19.Id = 19;
            this.printPreviewBarItem19.Name = "printPreviewBarItem19";
            superToolTip18.FixedTooltipWidth = true;
            toolTipTitleItem18.Text = "Last Page (End)";
            toolTipItem18.LeftIndent = 6;
            toolTipItem18.Text = "Navigate to the last page of the document.";
            superToolTip18.Items.Add(toolTipTitleItem18);
            superToolTip18.Items.Add(toolTipItem18);
            superToolTip18.MaxWidth = 210;
            this.printPreviewBarItem19.SuperTip = superToolTip18;
            // 
            // printPreviewBarItem20
            // 
            this.printPreviewBarItem20.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.printPreviewBarItem20.Caption = "Many Pages";
            this.printPreviewBarItem20.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages;
            this.printPreviewBarItem20.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem20.Enabled = false;
            this.printPreviewBarItem20.Id = 20;
            this.printPreviewBarItem20.Name = "printPreviewBarItem20";
            superToolTip19.FixedTooltipWidth = true;
            toolTipTitleItem19.Text = "View Many Pages";
            toolTipItem19.LeftIndent = 6;
            toolTipItem19.Text = "Choose the page layout to arrange the document pages in preview.";
            superToolTip19.Items.Add(toolTipTitleItem19);
            superToolTip19.Items.Add(toolTipItem19);
            superToolTip19.MaxWidth = 210;
            this.printPreviewBarItem20.SuperTip = superToolTip19;
            // 
            // printPreviewBarItem21
            // 
            this.printPreviewBarItem21.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.printPreviewBarItem21.Caption = "Page Color";
            this.printPreviewBarItem21.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground;
            this.printPreviewBarItem21.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem21.Enabled = false;
            this.printPreviewBarItem21.Id = 21;
            this.printPreviewBarItem21.Name = "printPreviewBarItem21";
            superToolTip20.FixedTooltipWidth = true;
            toolTipTitleItem20.Text = "Background Color";
            toolTipItem20.LeftIndent = 6;
            toolTipItem20.Text = "Choose a color for the background of the document pages.";
            superToolTip20.Items.Add(toolTipTitleItem20);
            superToolTip20.Items.Add(toolTipItem20);
            superToolTip20.MaxWidth = 210;
            this.printPreviewBarItem21.SuperTip = superToolTip20;
            // 
            // printPreviewBarItem22
            // 
            this.printPreviewBarItem22.Caption = "Watermark";
            this.printPreviewBarItem22.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark;
            this.printPreviewBarItem22.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem22.Enabled = false;
            this.printPreviewBarItem22.Id = 22;
            this.printPreviewBarItem22.Name = "printPreviewBarItem22";
            superToolTip21.FixedTooltipWidth = true;
            toolTipTitleItem21.Text = "Watermark";
            toolTipItem21.LeftIndent = 6;
            toolTipItem21.Text = "Insert ghosted text or image behind the content of a page.\r\n\r\nThis is often used " +
    "to indicate that a document is to be treated specially.";
            superToolTip21.Items.Add(toolTipTitleItem21);
            superToolTip21.Items.Add(toolTipItem21);
            superToolTip21.MaxWidth = 210;
            this.printPreviewBarItem22.SuperTip = superToolTip21;
            // 
            // printPreviewBarItem23
            // 
            this.printPreviewBarItem23.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.printPreviewBarItem23.Caption = "Export To";
            this.printPreviewBarItem23.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile;
            this.printPreviewBarItem23.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem23.Enabled = false;
            this.printPreviewBarItem23.Id = 23;
            this.printPreviewBarItem23.Name = "printPreviewBarItem23";
            superToolTip22.FixedTooltipWidth = true;
            toolTipTitleItem22.Text = "Export To...";
            toolTipItem22.LeftIndent = 6;
            toolTipItem22.Text = "Export the current document in one of the available formats, and save it to the f" +
    "ile on a disk.";
            superToolTip22.Items.Add(toolTipTitleItem22);
            superToolTip22.Items.Add(toolTipItem22);
            superToolTip22.MaxWidth = 210;
            this.printPreviewBarItem23.SuperTip = superToolTip22;
            // 
            // printPreviewBarItem24
            // 
            this.printPreviewBarItem24.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.printPreviewBarItem24.Caption = "E-Mail As";
            this.printPreviewBarItem24.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile;
            this.printPreviewBarItem24.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem24.Enabled = false;
            this.printPreviewBarItem24.Id = 24;
            this.printPreviewBarItem24.Name = "printPreviewBarItem24";
            superToolTip23.FixedTooltipWidth = true;
            toolTipTitleItem23.Text = "E-Mail As...";
            toolTipItem23.LeftIndent = 6;
            toolTipItem23.Text = "Export the current document in one of the available formats, and attach it to the" +
    " e-mail.";
            superToolTip23.Items.Add(toolTipTitleItem23);
            superToolTip23.Items.Add(toolTipItem23);
            superToolTip23.MaxWidth = 210;
            this.printPreviewBarItem24.SuperTip = superToolTip23;
            // 
            // printPreviewBarItem25
            // 
            this.printPreviewBarItem25.Caption = "Close";
            this.printPreviewBarItem25.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview;
            this.printPreviewBarItem25.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem25.Enabled = false;
            this.printPreviewBarItem25.Id = 25;
            this.printPreviewBarItem25.Name = "printPreviewBarItem25";
            superToolTip24.FixedTooltipWidth = true;
            toolTipTitleItem24.Text = "Close Print Preview";
            toolTipItem24.LeftIndent = 6;
            toolTipItem24.Text = "Close Print Preview of the document.";
            superToolTip24.Items.Add(toolTipTitleItem24);
            superToolTip24.Items.Add(toolTipItem24);
            superToolTip24.MaxWidth = 210;
            this.printPreviewBarItem25.SuperTip = superToolTip24;
            // 
            // printPreviewBarItem26
            // 
            this.printPreviewBarItem26.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.printPreviewBarItem26.Caption = "Orientation";
            this.printPreviewBarItem26.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageOrientation;
            this.printPreviewBarItem26.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem26.Enabled = false;
            this.printPreviewBarItem26.Id = 26;
            this.printPreviewBarItem26.Name = "printPreviewBarItem26";
            superToolTip25.FixedTooltipWidth = true;
            toolTipTitleItem25.Text = "Page Orientation";
            toolTipItem25.LeftIndent = 6;
            toolTipItem25.Text = "Switch the pages between portrait and landscape layouts.";
            superToolTip25.Items.Add(toolTipTitleItem25);
            superToolTip25.Items.Add(toolTipItem25);
            superToolTip25.MaxWidth = 210;
            this.printPreviewBarItem26.SuperTip = superToolTip25;
            // 
            // printPreviewBarItem27
            // 
            this.printPreviewBarItem27.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.printPreviewBarItem27.Caption = "Size";
            this.printPreviewBarItem27.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PaperSize;
            this.printPreviewBarItem27.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem27.Enabled = false;
            this.printPreviewBarItem27.Id = 27;
            this.printPreviewBarItem27.Name = "printPreviewBarItem27";
            superToolTip26.FixedTooltipWidth = true;
            toolTipTitleItem26.Text = "Page Size";
            toolTipItem26.LeftIndent = 6;
            toolTipItem26.Text = "Choose the paper size of the document.";
            superToolTip26.Items.Add(toolTipTitleItem26);
            superToolTip26.Items.Add(toolTipItem26);
            superToolTip26.MaxWidth = 210;
            this.printPreviewBarItem27.SuperTip = superToolTip26;
            // 
            // printPreviewBarItem28
            // 
            this.printPreviewBarItem28.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.printPreviewBarItem28.Caption = "Margins";
            this.printPreviewBarItem28.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageMargins;
            this.printPreviewBarItem28.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem28.Enabled = false;
            this.printPreviewBarItem28.Id = 28;
            this.printPreviewBarItem28.Name = "printPreviewBarItem28";
            superToolTip27.FixedTooltipWidth = true;
            toolTipTitleItem27.Text = "Page Margins";
            toolTipItem27.LeftIndent = 6;
            toolTipItem27.Text = "Select the margin sizes for the entire document.\r\n\r\nTo apply specific margin size" +
    "s to the document, click Custom Margins.";
            superToolTip27.Items.Add(toolTipTitleItem27);
            superToolTip27.Items.Add(toolTipItem27);
            superToolTip27.MaxWidth = 210;
            this.printPreviewBarItem28.SuperTip = superToolTip27;
            // 
            // printPreviewBarItem29
            // 
            this.printPreviewBarItem29.Caption = "PDF File";
            this.printPreviewBarItem29.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf;
            this.printPreviewBarItem29.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem29.Description = "Adobe Portable Document Format";
            this.printPreviewBarItem29.Enabled = false;
            this.printPreviewBarItem29.Id = 29;
            this.printPreviewBarItem29.Name = "printPreviewBarItem29";
            superToolTip28.FixedTooltipWidth = true;
            toolTipTitleItem28.Text = "E-Mail As PDF";
            toolTipItem28.LeftIndent = 6;
            toolTipItem28.Text = "Export the document to PDF and attach it to the e-mail.";
            superToolTip28.Items.Add(toolTipTitleItem28);
            superToolTip28.Items.Add(toolTipItem28);
            superToolTip28.MaxWidth = 210;
            this.printPreviewBarItem29.SuperTip = superToolTip28;
            // 
            // printPreviewBarItem30
            // 
            this.printPreviewBarItem30.Caption = "Text File";
            this.printPreviewBarItem30.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt;
            this.printPreviewBarItem30.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem30.Description = "Plain Text";
            this.printPreviewBarItem30.Enabled = false;
            this.printPreviewBarItem30.Id = 30;
            this.printPreviewBarItem30.Name = "printPreviewBarItem30";
            superToolTip29.FixedTooltipWidth = true;
            toolTipTitleItem29.Text = "E-Mail As Text";
            toolTipItem29.LeftIndent = 6;
            toolTipItem29.Text = "Export the document to Text and attach it to the e-mail.";
            superToolTip29.Items.Add(toolTipTitleItem29);
            superToolTip29.Items.Add(toolTipItem29);
            superToolTip29.MaxWidth = 210;
            this.printPreviewBarItem30.SuperTip = superToolTip29;
            // 
            // printPreviewBarItem31
            // 
            this.printPreviewBarItem31.Caption = "CSV File";
            this.printPreviewBarItem31.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv;
            this.printPreviewBarItem31.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem31.Description = "Comma-Separated Values Text";
            this.printPreviewBarItem31.Enabled = false;
            this.printPreviewBarItem31.Id = 31;
            this.printPreviewBarItem31.Name = "printPreviewBarItem31";
            superToolTip30.FixedTooltipWidth = true;
            toolTipTitleItem30.Text = "E-Mail As CSV";
            toolTipItem30.LeftIndent = 6;
            toolTipItem30.Text = "Export the document to CSV and attach it to the e-mail.";
            superToolTip30.Items.Add(toolTipTitleItem30);
            superToolTip30.Items.Add(toolTipItem30);
            superToolTip30.MaxWidth = 210;
            this.printPreviewBarItem31.SuperTip = superToolTip30;
            // 
            // printPreviewBarItem32
            // 
            this.printPreviewBarItem32.Caption = "MHT File";
            this.printPreviewBarItem32.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht;
            this.printPreviewBarItem32.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem32.Description = "Single File Web Page";
            this.printPreviewBarItem32.Enabled = false;
            this.printPreviewBarItem32.Id = 32;
            this.printPreviewBarItem32.Name = "printPreviewBarItem32";
            superToolTip31.FixedTooltipWidth = true;
            toolTipTitleItem31.Text = "E-Mail As MHT";
            toolTipItem31.LeftIndent = 6;
            toolTipItem31.Text = "Export the document to MHT and attach it to the e-mail.";
            superToolTip31.Items.Add(toolTipTitleItem31);
            superToolTip31.Items.Add(toolTipItem31);
            superToolTip31.MaxWidth = 210;
            this.printPreviewBarItem32.SuperTip = superToolTip31;
            // 
            // printPreviewBarItem33
            // 
            this.printPreviewBarItem33.Caption = "XLS File";
            this.printPreviewBarItem33.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls;
            this.printPreviewBarItem33.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem33.Description = "Microsoft Excel 2000-2003 Workbook";
            this.printPreviewBarItem33.Enabled = false;
            this.printPreviewBarItem33.Id = 33;
            this.printPreviewBarItem33.Name = "printPreviewBarItem33";
            superToolTip32.FixedTooltipWidth = true;
            toolTipTitleItem32.Text = "E-Mail As XLS";
            toolTipItem32.LeftIndent = 6;
            toolTipItem32.Text = "Export the document to XLS and attach it to the e-mail.";
            superToolTip32.Items.Add(toolTipTitleItem32);
            superToolTip32.Items.Add(toolTipItem32);
            superToolTip32.MaxWidth = 210;
            this.printPreviewBarItem33.SuperTip = superToolTip32;
            // 
            // printPreviewBarItem34
            // 
            this.printPreviewBarItem34.Caption = "XLSX File";
            this.printPreviewBarItem34.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx;
            this.printPreviewBarItem34.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem34.Description = "Microsoft Excel 2007 Workbook";
            this.printPreviewBarItem34.Enabled = false;
            this.printPreviewBarItem34.Id = 34;
            this.printPreviewBarItem34.Name = "printPreviewBarItem34";
            superToolTip33.FixedTooltipWidth = true;
            toolTipTitleItem33.Text = "E-Mail As XLSX";
            toolTipItem33.LeftIndent = 6;
            toolTipItem33.Text = "Export the document to XLSX and attach it to the e-mail.";
            superToolTip33.Items.Add(toolTipTitleItem33);
            superToolTip33.Items.Add(toolTipItem33);
            superToolTip33.MaxWidth = 210;
            this.printPreviewBarItem34.SuperTip = superToolTip33;
            // 
            // printPreviewBarItem35
            // 
            this.printPreviewBarItem35.Caption = "RTF File";
            this.printPreviewBarItem35.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf;
            this.printPreviewBarItem35.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem35.Description = "Rich Text Format";
            this.printPreviewBarItem35.Enabled = false;
            this.printPreviewBarItem35.Id = 35;
            this.printPreviewBarItem35.Name = "printPreviewBarItem35";
            superToolTip34.FixedTooltipWidth = true;
            toolTipTitleItem34.Text = "E-Mail As RTF";
            toolTipItem34.LeftIndent = 6;
            toolTipItem34.Text = "Export the document to RTF and attach it to the e-mail.";
            superToolTip34.Items.Add(toolTipTitleItem34);
            superToolTip34.Items.Add(toolTipItem34);
            superToolTip34.MaxWidth = 210;
            this.printPreviewBarItem35.SuperTip = superToolTip34;
            // 
            // printPreviewBarItem36
            // 
            this.printPreviewBarItem36.Caption = "Image File";
            this.printPreviewBarItem36.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic;
            this.printPreviewBarItem36.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem36.Description = "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF";
            this.printPreviewBarItem36.Enabled = false;
            this.printPreviewBarItem36.Id = 36;
            this.printPreviewBarItem36.Name = "printPreviewBarItem36";
            superToolTip35.FixedTooltipWidth = true;
            toolTipTitleItem35.Text = "E-Mail As Image";
            toolTipItem35.LeftIndent = 6;
            toolTipItem35.Text = "Export the document to Image and attach it to the e-mail.";
            superToolTip35.Items.Add(toolTipTitleItem35);
            superToolTip35.Items.Add(toolTipItem35);
            superToolTip35.MaxWidth = 210;
            this.printPreviewBarItem36.SuperTip = superToolTip35;
            // 
            // printPreviewBarItem37
            // 
            this.printPreviewBarItem37.Caption = "PDF File";
            this.printPreviewBarItem37.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf;
            this.printPreviewBarItem37.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem37.Description = "Adobe Portable Document Format";
            this.printPreviewBarItem37.Enabled = false;
            this.printPreviewBarItem37.Id = 37;
            this.printPreviewBarItem37.Name = "printPreviewBarItem37";
            superToolTip36.FixedTooltipWidth = true;
            toolTipTitleItem36.Text = "Export to PDF";
            toolTipItem36.LeftIndent = 6;
            toolTipItem36.Text = "Export the document to PDF and save it to the file on a disk.";
            superToolTip36.Items.Add(toolTipTitleItem36);
            superToolTip36.Items.Add(toolTipItem36);
            superToolTip36.MaxWidth = 210;
            this.printPreviewBarItem37.SuperTip = superToolTip36;
            // 
            // printPreviewBarItem38
            // 
            this.printPreviewBarItem38.Caption = "HTML File";
            this.printPreviewBarItem38.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm;
            this.printPreviewBarItem38.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem38.Description = "Web Page";
            this.printPreviewBarItem38.Enabled = false;
            this.printPreviewBarItem38.Id = 38;
            this.printPreviewBarItem38.Name = "printPreviewBarItem38";
            superToolTip37.FixedTooltipWidth = true;
            toolTipTitleItem37.Text = "Export to HTML";
            toolTipItem37.LeftIndent = 6;
            toolTipItem37.Text = "Export the document to HTML and save it to the file on a disk.";
            superToolTip37.Items.Add(toolTipTitleItem37);
            superToolTip37.Items.Add(toolTipItem37);
            superToolTip37.MaxWidth = 210;
            this.printPreviewBarItem38.SuperTip = superToolTip37;
            // 
            // printPreviewBarItem39
            // 
            this.printPreviewBarItem39.Caption = "Text File";
            this.printPreviewBarItem39.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt;
            this.printPreviewBarItem39.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem39.Description = "Plain Text";
            this.printPreviewBarItem39.Enabled = false;
            this.printPreviewBarItem39.Id = 39;
            this.printPreviewBarItem39.Name = "printPreviewBarItem39";
            superToolTip38.FixedTooltipWidth = true;
            toolTipTitleItem38.Text = "Export to Text";
            toolTipItem38.LeftIndent = 6;
            toolTipItem38.Text = "Export the document to Text and save it to the file on a disk.";
            superToolTip38.Items.Add(toolTipTitleItem38);
            superToolTip38.Items.Add(toolTipItem38);
            superToolTip38.MaxWidth = 210;
            this.printPreviewBarItem39.SuperTip = superToolTip38;
            // 
            // printPreviewBarItem40
            // 
            this.printPreviewBarItem40.Caption = "CSV File";
            this.printPreviewBarItem40.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv;
            this.printPreviewBarItem40.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem40.Description = "Comma-Separated Values Text";
            this.printPreviewBarItem40.Enabled = false;
            this.printPreviewBarItem40.Id = 40;
            this.printPreviewBarItem40.Name = "printPreviewBarItem40";
            superToolTip39.FixedTooltipWidth = true;
            toolTipTitleItem39.Text = "Export to CSV";
            toolTipItem39.LeftIndent = 6;
            toolTipItem39.Text = "Export the document to CSV and save it to the file on a disk.";
            superToolTip39.Items.Add(toolTipTitleItem39);
            superToolTip39.Items.Add(toolTipItem39);
            superToolTip39.MaxWidth = 210;
            this.printPreviewBarItem40.SuperTip = superToolTip39;
            // 
            // printPreviewBarItem41
            // 
            this.printPreviewBarItem41.Caption = "MHT File";
            this.printPreviewBarItem41.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht;
            this.printPreviewBarItem41.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem41.Description = "Single File Web Page";
            this.printPreviewBarItem41.Enabled = false;
            this.printPreviewBarItem41.Id = 41;
            this.printPreviewBarItem41.Name = "printPreviewBarItem41";
            superToolTip40.FixedTooltipWidth = true;
            toolTipTitleItem40.Text = "Export to MHT";
            toolTipItem40.LeftIndent = 6;
            toolTipItem40.Text = "Export the document to MHT and save it to the file on a disk.";
            superToolTip40.Items.Add(toolTipTitleItem40);
            superToolTip40.Items.Add(toolTipItem40);
            superToolTip40.MaxWidth = 210;
            this.printPreviewBarItem41.SuperTip = superToolTip40;
            // 
            // printPreviewBarItem42
            // 
            this.printPreviewBarItem42.Caption = "XLS File";
            this.printPreviewBarItem42.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls;
            this.printPreviewBarItem42.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem42.Description = "Microsoft Excel 2000-2003 Workbook";
            this.printPreviewBarItem42.Enabled = false;
            this.printPreviewBarItem42.Id = 42;
            this.printPreviewBarItem42.Name = "printPreviewBarItem42";
            superToolTip41.FixedTooltipWidth = true;
            toolTipTitleItem41.Text = "Export to XLS";
            toolTipItem41.LeftIndent = 6;
            toolTipItem41.Text = "Export the document to XLS and save it to the file on a disk.";
            superToolTip41.Items.Add(toolTipTitleItem41);
            superToolTip41.Items.Add(toolTipItem41);
            superToolTip41.MaxWidth = 210;
            this.printPreviewBarItem42.SuperTip = superToolTip41;
            // 
            // printPreviewBarItem43
            // 
            this.printPreviewBarItem43.Caption = "XLSX File";
            this.printPreviewBarItem43.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx;
            this.printPreviewBarItem43.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem43.Description = "Microsoft Excel 2007 Workbook";
            this.printPreviewBarItem43.Enabled = false;
            this.printPreviewBarItem43.Id = 43;
            this.printPreviewBarItem43.Name = "printPreviewBarItem43";
            superToolTip42.FixedTooltipWidth = true;
            toolTipTitleItem42.Text = "Export to XLSX";
            toolTipItem42.LeftIndent = 6;
            toolTipItem42.Text = "Export the document to XLSX and save it to the file on a disk.";
            superToolTip42.Items.Add(toolTipTitleItem42);
            superToolTip42.Items.Add(toolTipItem42);
            superToolTip42.MaxWidth = 210;
            this.printPreviewBarItem43.SuperTip = superToolTip42;
            // 
            // printPreviewBarItem44
            // 
            this.printPreviewBarItem44.Caption = "RTF File";
            this.printPreviewBarItem44.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf;
            this.printPreviewBarItem44.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem44.Description = "Rich Text Format";
            this.printPreviewBarItem44.Enabled = false;
            this.printPreviewBarItem44.Id = 44;
            this.printPreviewBarItem44.Name = "printPreviewBarItem44";
            superToolTip43.FixedTooltipWidth = true;
            toolTipTitleItem43.Text = "Export to RTF";
            toolTipItem43.LeftIndent = 6;
            toolTipItem43.Text = "Export the document to RTF and save it to the file on a disk.";
            superToolTip43.Items.Add(toolTipTitleItem43);
            superToolTip43.Items.Add(toolTipItem43);
            superToolTip43.MaxWidth = 210;
            this.printPreviewBarItem44.SuperTip = superToolTip43;
            // 
            // printPreviewBarItem45
            // 
            this.printPreviewBarItem45.Caption = "Image File";
            this.printPreviewBarItem45.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic;
            this.printPreviewBarItem45.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem45.Description = "BMP, GIF, JPEG, PNG, TIFF, EMF, WMF";
            this.printPreviewBarItem45.Enabled = false;
            this.printPreviewBarItem45.Id = 45;
            this.printPreviewBarItem45.Name = "printPreviewBarItem45";
            superToolTip44.FixedTooltipWidth = true;
            toolTipTitleItem44.Text = "Export to Image";
            toolTipItem44.LeftIndent = 6;
            toolTipItem44.Text = "Export the document to Image and save it to the file on a disk.";
            superToolTip44.Items.Add(toolTipTitleItem44);
            superToolTip44.Items.Add(toolTipItem44);
            superToolTip44.MaxWidth = 210;
            this.printPreviewBarItem45.SuperTip = superToolTip44;
            // 
            // printPreviewBarItem46
            // 
            this.printPreviewBarItem46.Caption = "Open";
            this.printPreviewBarItem46.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open;
            this.printPreviewBarItem46.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem46.Enabled = false;
            this.printPreviewBarItem46.Id = 46;
            this.printPreviewBarItem46.Name = "printPreviewBarItem46";
            superToolTip45.FixedTooltipWidth = true;
            toolTipTitleItem45.Text = "Open (Ctrl + O)";
            toolTipItem45.LeftIndent = 6;
            toolTipItem45.Text = "Open a document.";
            superToolTip45.Items.Add(toolTipTitleItem45);
            superToolTip45.Items.Add(toolTipItem45);
            superToolTip45.MaxWidth = 210;
            this.printPreviewBarItem46.SuperTip = superToolTip45;
            // 
            // printPreviewBarItem47
            // 
            this.printPreviewBarItem47.Caption = "Save";
            this.printPreviewBarItem47.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save;
            this.printPreviewBarItem47.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem47.Enabled = false;
            this.printPreviewBarItem47.Id = 47;
            this.printPreviewBarItem47.Name = "printPreviewBarItem47";
            superToolTip46.FixedTooltipWidth = true;
            toolTipTitleItem46.Text = "Save (Ctrl + S)";
            toolTipItem46.LeftIndent = 6;
            toolTipItem46.Text = "Save the document.";
            superToolTip46.Items.Add(toolTipTitleItem46);
            superToolTip46.Items.Add(toolTipItem46);
            superToolTip46.MaxWidth = 210;
            this.printPreviewBarItem47.SuperTip = superToolTip46;
            // 
            // printPreviewBarItem48
            // 
            this.printPreviewBarItem48.Caption = "Stop";
            this.printPreviewBarItem48.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding;
            this.printPreviewBarItem48.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem48.Enabled = false;
            this.printPreviewBarItem48.Hint = "Stop";
            this.printPreviewBarItem48.Id = 51;
            this.printPreviewBarItem48.Name = "printPreviewBarItem48";
            this.printPreviewBarItem48.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barButtonItem1.Enabled = false;
            this.barButtonItem1.Id = 52;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime;
            // 
            // printPreviewStaticItem2
            // 
            this.printPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.printPreviewStaticItem2.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None;
            this.printPreviewStaticItem2.Caption = "100%";
            this.printPreviewStaticItem2.Id = 53;
            this.printPreviewStaticItem2.Name = "printPreviewStaticItem2";
            this.printPreviewStaticItem2.Type = "ZoomFactorText";
            // 
            // zoomTrackBarEditItem1
            // 
            this.zoomTrackBarEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.zoomTrackBarEditItem1.ContextSpecifier = this.documentViewerRibbonController1;
            this.zoomTrackBarEditItem1.Edit = this.repositoryItemZoomTrackBar1;
            this.zoomTrackBarEditItem1.EditValue = 90;
            this.zoomTrackBarEditItem1.EditWidth = 140;
            this.zoomTrackBarEditItem1.Enabled = false;
            this.zoomTrackBarEditItem1.Id = 54;
            this.zoomTrackBarEditItem1.Name = "zoomTrackBarEditItem1";
            this.zoomTrackBarEditItem1.Range = new int[] {
        10,
        500};
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemZoomTrackBar1.AllowFocused = false;
            this.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemZoomTrackBar1.Maximum = 180;
            this.repositoryItemZoomTrackBar1.Middle = 90;
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Designer";
            this.barButtonItem2.Id = 57;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            toolTipTitleItem47.Text = "Designer";
            toolTipItem47.LeftIndent = 6;
            toolTipItem47.Text = "Run Ribbon Report Designer";
            superToolTip47.Items.Add(toolTipTitleItem47);
            superToolTip47.Items.Add(toolTipItem47);
            this.barButtonItem2.SuperTip = superToolTip47;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // printPreviewBarItem8
            // 
            this.printPreviewBarItem8.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.printPreviewBarItem8.Caption = "Editing Fields";
            this.printPreviewBarItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields;
            this.printPreviewBarItem8.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewBarItem8.Enabled = false;
            this.printPreviewBarItem8.Id = 59;
            this.printPreviewBarItem8.Name = "printPreviewBarItem8";
            superToolTip48.FixedTooltipWidth = true;
            toolTipTitleItem48.Text = "Highlight Editing Fields";
            toolTipItem48.LeftIndent = 6;
            toolTipItem48.Text = "Highlight all editing fields to quickly discover which of the document elements a" +
    "re editable.";
            superToolTip48.Items.Add(toolTipTitleItem48);
            superToolTip48.Items.Add(toolTipItem48);
            superToolTip48.MaxWidth = 210;
            this.printPreviewBarItem8.SuperTip = superToolTip48;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.ContextSpecifier = this.documentViewerRibbonController1;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.printPreviewRibbonPageGroup1,
            this.printPreviewRibbonPageGroup2,
            this.printPreviewRibbonPageGroup3,
            this.printPreviewRibbonPageGroup4,
            this.printPreviewRibbonPageGroup5,
            this.printPreviewRibbonPageGroup6,
            this.printPreviewRibbonPageGroup7});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Print Preview";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup1.Text = "Actions";
            // 
            // printPreviewRibbonPageGroup1
            // 
            this.printPreviewRibbonPageGroup1.AllowTextClipping = false;
            this.printPreviewRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.printPreviewRibbonPageGroup1.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewRibbonPageGroup1.ItemLinks.Add(this.printPreviewBarItem46);
            this.printPreviewRibbonPageGroup1.ItemLinks.Add(this.printPreviewBarItem47);
            this.printPreviewRibbonPageGroup1.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Document;
            this.printPreviewRibbonPageGroup1.Name = "printPreviewRibbonPageGroup1";
            this.printPreviewRibbonPageGroup1.Text = "Document";
            // 
            // printPreviewRibbonPageGroup2
            // 
            this.printPreviewRibbonPageGroup2.AllowTextClipping = false;
            this.printPreviewRibbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.printPreviewRibbonPageGroup2.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewRibbonPageGroup2.ItemLinks.Add(this.printPreviewBarItem5);
            this.printPreviewRibbonPageGroup2.ItemLinks.Add(this.printPreviewBarItem6);
            this.printPreviewRibbonPageGroup2.ItemLinks.Add(this.printPreviewBarItem2);
            this.printPreviewRibbonPageGroup2.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Print;
            this.printPreviewRibbonPageGroup2.Name = "printPreviewRibbonPageGroup2";
            this.printPreviewRibbonPageGroup2.Text = "Print";
            // 
            // printPreviewRibbonPageGroup3
            // 
            this.printPreviewRibbonPageGroup3.AllowTextClipping = false;
            this.printPreviewRibbonPageGroup3.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewRibbonPageGroup3.ItemLinks.Add(this.printPreviewBarItem9);
            this.printPreviewRibbonPageGroup3.ItemLinks.Add(this.printPreviewBarItem28);
            this.printPreviewRibbonPageGroup3.ItemLinks.Add(this.printPreviewBarItem26);
            this.printPreviewRibbonPageGroup3.ItemLinks.Add(this.printPreviewBarItem27);
            this.printPreviewRibbonPageGroup3.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.PageSetup;
            this.printPreviewRibbonPageGroup3.Name = "printPreviewRibbonPageGroup3";
            superToolTip49.FixedTooltipWidth = true;
            toolTipTitleItem49.Text = "Page Setup";
            toolTipItem49.LeftIndent = 6;
            toolTipItem49.Text = "Show the Page Setup dialog.";
            superToolTip49.Items.Add(toolTipTitleItem49);
            superToolTip49.Items.Add(toolTipItem49);
            superToolTip49.MaxWidth = 210;
            this.printPreviewRibbonPageGroup3.SuperTip = superToolTip49;
            this.printPreviewRibbonPageGroup3.Text = "Page Setup";
            // 
            // printPreviewRibbonPageGroup4
            // 
            this.printPreviewRibbonPageGroup4.AllowTextClipping = false;
            this.printPreviewRibbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.printPreviewRibbonPageGroup4.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewRibbonPageGroup4.ItemLinks.Add(this.printPreviewBarItem3);
            this.printPreviewRibbonPageGroup4.ItemLinks.Add(this.printPreviewBarItem4);
            this.printPreviewRibbonPageGroup4.ItemLinks.Add(this.printPreviewBarItem1);
            this.printPreviewRibbonPageGroup4.ItemLinks.Add(this.printPreviewBarItem8);
            this.printPreviewRibbonPageGroup4.ItemLinks.Add(this.printPreviewBarItem16, true);
            this.printPreviewRibbonPageGroup4.ItemLinks.Add(this.printPreviewBarItem17);
            this.printPreviewRibbonPageGroup4.ItemLinks.Add(this.printPreviewBarItem18);
            this.printPreviewRibbonPageGroup4.ItemLinks.Add(this.printPreviewBarItem19);
            this.printPreviewRibbonPageGroup4.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Navigation;
            this.printPreviewRibbonPageGroup4.Name = "printPreviewRibbonPageGroup4";
            this.printPreviewRibbonPageGroup4.Text = "Navigation";
            // 
            // printPreviewRibbonPageGroup5
            // 
            this.printPreviewRibbonPageGroup5.AllowTextClipping = false;
            this.printPreviewRibbonPageGroup5.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.printPreviewRibbonPageGroup5.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewRibbonPageGroup5.ItemLinks.Add(this.printPreviewBarItem10);
            this.printPreviewRibbonPageGroup5.ItemLinks.Add(this.printPreviewBarItem11);
            this.printPreviewRibbonPageGroup5.ItemLinks.Add(this.printPreviewBarItem12);
            this.printPreviewRibbonPageGroup5.ItemLinks.Add(this.printPreviewBarItem20);
            this.printPreviewRibbonPageGroup5.ItemLinks.Add(this.printPreviewBarItem13);
            this.printPreviewRibbonPageGroup5.ItemLinks.Add(this.printPreviewBarItem15);
            this.printPreviewRibbonPageGroup5.ItemLinks.Add(this.printPreviewBarItem14);
            this.printPreviewRibbonPageGroup5.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Zoom;
            this.printPreviewRibbonPageGroup5.Name = "printPreviewRibbonPageGroup5";
            this.printPreviewRibbonPageGroup5.Text = "Zoom";
            // 
            // printPreviewRibbonPageGroup6
            // 
            this.printPreviewRibbonPageGroup6.AllowTextClipping = false;
            this.printPreviewRibbonPageGroup6.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.printPreviewRibbonPageGroup6.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewRibbonPageGroup6.ItemLinks.Add(this.printPreviewBarItem21);
            this.printPreviewRibbonPageGroup6.ItemLinks.Add(this.printPreviewBarItem22);
            this.printPreviewRibbonPageGroup6.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Background;
            this.printPreviewRibbonPageGroup6.Name = "printPreviewRibbonPageGroup6";
            this.printPreviewRibbonPageGroup6.Text = "Page Background";
            // 
            // printPreviewRibbonPageGroup7
            // 
            this.printPreviewRibbonPageGroup7.AllowTextClipping = false;
            this.printPreviewRibbonPageGroup7.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.printPreviewRibbonPageGroup7.ContextSpecifier = this.documentViewerRibbonController1;
            this.printPreviewRibbonPageGroup7.ItemLinks.Add(this.printPreviewBarItem23);
            this.printPreviewRibbonPageGroup7.ItemLinks.Add(this.printPreviewBarItem24);
            this.printPreviewRibbonPageGroup7.Kind = DevExpress.XtraPrinting.Preview.PrintPreviewRibbonPageGroupKind.Export;
            this.printPreviewRibbonPageGroup7.Name = "printPreviewRibbonPageGroup7";
            this.printPreviewRibbonPageGroup7.Text = "Export";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // lcgRoot
            // 
            this.lcgRoot.GroupBordersVisible = false;
            this.lcgRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciHeader,
            this.lciContent});
            this.lcgRoot.Name = "Root";
            this.lcgRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgRoot.Size = new System.Drawing.Size(1116, 167);
            this.lcgRoot.TextVisible = false;
            // 
            // lciHeader
            // 
            this.lciHeader.AppearanceItemCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lciHeader.AppearanceItemCaption.Options.UseBackColor = true;
            this.lciHeader.Location = new System.Drawing.Point(0, 0);
            this.lciHeader.Name = "lciUcDisclaimerPanel1";
            this.lciHeader.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciHeader.Size = new System.Drawing.Size(1116, 54);
            this.lciHeader.TextVisible = false;
            this.lciHeader.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciContent
            // 
            this.lciContent.Control = this.roundedSkinPanel1;
            this.lciContent.Location = new System.Drawing.Point(0, 54);
            this.lciContent.Name = "lciContent";
            this.lciContent.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciContent.Size = new System.Drawing.Size(1116, 113);
            this.lciContent.TextVisible = false;
            // 
            // PreviewControl
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.lcc);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PreviewControl";
            this.Size = new System.Drawing.Size(1116, 474);
            ((System.ComponentModel.ISupportInitialize)(this.lcc)).EndInit();
            this.lcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel1)).EndInit();
            this.roundedSkinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerRibbonController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void ShowDesignerForm(Form designForm, Form parentForm) {
            if(designForm == null || parentForm == null)
                return;
            designForm.MinimumSize = parentForm.MinimumSize;
            if(parentForm.WindowState == FormWindowState.Normal)
                designForm.StartPosition = FormStartPosition.Manual;
            if(parentForm.WindowState != FormWindowState.Minimized)
                designForm.Bounds = parentForm.Bounds;
            designForm.WindowState = FormWindowState.Maximized;
            parentForm.Visible = false;
            designForm.ShowDialog(parentForm);
            parentForm.Visible = true;
        }
        void EditReport(Func<IDesignForm> createForm) {
            if(module == null) return;
            Report.StopPageBuilding();
            Report.ReportPrintOptions.DetailCountAtDesignTime = 0;
            foreach(XtraReportBase item in Report.AllControls<XtraReportBase>())
                item.ReportPrintOptions.DetailCountAtDesignTime = 0;
            System.ComponentModel.DXDisplayNameAttribute.UseResourceManager = true;
            string fileName = module.FileName;
            if(!string.IsNullOrEmpty(fileName))
                EditReport(createForm, module.Report, fileName);
        }
        void EditReport(Func<IDesignForm> createForm, XtraReport report, string fileName) {
            Guard.ArgumentNotNull(report, "report");
            Guard.ArgumentNotNull(fileName, "fileName");
            string saveFileName = Path.ChangeExtension(fileName, "sav");
            report.PrintingSystem.ExecCommand(PrintingSystemCommand.StopPageBuilding);
            report.SaveLayoutToXml(saveFileName);
            using(XtraReport newReport = XtraReport.FromFile(saveFileName, true)) {
                IDesignForm designForm = createForm();
                designForm.OpenReport(newReport);

                XRDesignPanel panel = designForm.ActiveXRDesignPanel;
                if(panel != null) panel.FileName = fileName;

                ShowDesignerForm(designForm.Form, FindForm());

                if(panel != null && !panel.IsDisposed && panel.FileName != fileName && File.Exists(panel.FileName))
                    File.Copy(panel.FileName, fileName, true);

                if(designForm.Form != null)
                    designForm.Form.Dispose();
            }
            if(File.Exists(fileName)) {
                report.LoadLayout(fileName);
                try {
                    module.Activate();
                }
                catch(Exception ex) {
                    Form form = FindForm();
                    if(form != null)
                        XtraMessageBox.Show(LookAndFeel.ParentLookAndFeel, form,
                            ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if(report != null) {
                        report.LoadLayoutFromXml(saveFileName);
                        module.Activate();
                    }
                }
                finally {
                    SafeDeleteFile(fileName);
                }
            }
            SafeDeleteFile(saveFileName);
        }
        void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if(Control.ModifierKeys == Keys.Control)
                EditReport(() => new StandardFormWrapper());
            else
                EditReport(() => new RibbonFormWrapper(Control.ModifierKeys == Keys.Shift));
        }
        static void SafeDeleteFile(string fileName) {
            try {
                File.Delete(fileName);
            }
            catch(UnauthorizedAccessException) {
            }
        }
    }
    class DemoReportExtension : ReportDesignExtension {
        protected RepositoryItem CreateRepositoryItemImageComboBox(string[] names, int valuesShift) {
            RepositoryItemImageComboBox item = new RepositoryItemImageComboBox();
            object[] values = CreateValues(valuesShift, names.Length);
            for(int i = 0; i < values.Length && i < names.Length; i++) {
                item.Items.Add(new ImageComboBoxItem(names[i], values[i]));
            }
            return item;
        }

        object[] CreateValues(int valuesShift, int count) {
            List<object> values = new List<object>();
            for(int i = valuesShift; i < valuesShift + count; i++) {
                values.Add(i);
            }
            return values.ToArray();
        }
    }
    public class ReportModuleBase : TutorialControlBase {
        protected override bool? UseRoundedPanel => false;
        protected virtual bool IsActive => false;
        public virtual void Activate() { }
        public virtual Task Deactivate() { return Task.CompletedTask; }
        public virtual bool IsExternalPreviewApplicable() => false;
        public ReportModuleBase() {
            AutoMergeRibbon = true;
        }
    }
    public abstract class ReportModule : ReportModuleBase {
        DocumentViewer _viewer;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DocumentViewer Viewer {
            get { return _viewer; }
            set {
                _viewer = value;
                if(_viewer != null)
                    OnSetViewer();
            }
        }
        RibbonControl previewRibbon;
        protected override RibbonControl ChildRibbon => previewRibbon;

        protected override bool IsActive {
            get {
                return Viewer != null && ReferenceEquals(Viewer.DocumentSource, DocumentSource);
            }
        }

        protected override bool? UseRoundedPanel => false;

        protected internal virtual Control HeaderContent => null;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FileName { get; private set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public XtraReport Report {
            get; private set;
        }

        public ReportModule() {
            Report = CreateReport();
            Report.AfterPrint += report_AfterPrint;
            FileName = GetReportPath(Report, "repx");
        }
        void report_AfterPrint(object sender, EventArgs e) {
            if(Viewer != null && IsActive)
                OnAfterReportPrint();
        }
        protected virtual void OnAfterReportPrint() {
        }
        protected abstract XtraReport CreateReport();

        public override async Task Deactivate() {
            try {
                await StopWorkingAsync().ConfigureAwait(false);
            }
            catch(OperationCanceledException) {
            }
            if(Report != null && Report.PrintingSystem != null)
                Report.PrintingSystem.ClearContent();
        }
        public override bool IsExternalPreviewApplicable() {
            return Viewer == null || !Viewer.IsDisposed;
        }
        public void SetPreviewRibbon(RibbonControl ribbon) {
            previewRibbon = ribbon;
        }
        protected virtual Task StopWorkingAsync() {
            if(Report != null && Report.PrintingSystem != null)
                return Report.PrintingSystem.CompleteWorkingAsync(true);
            return Task.FromResult<object>(null);
        }
        protected virtual object DocumentSource {
            get {
                return Report;
            }
        }
        public virtual void AddElements(AdornerUIManager adorner, IDictionary<string, object> targets) {
        }
        public override void Activate() {
            if(Viewer == null || IsActive) return;

            Viewer.DocumentSource = DocumentSource;
            if(DocumentSource == null) return;

            Viewer.InitiateDocumentCreation();
        }
        protected virtual void OnSetViewer() {
            Viewer.Zoom = 1;
        }
        internal bool GetUseRoundedPanel() => UseRoundedPanel.GetValueOrDefault(true);
        protected override void Dispose(bool disposing) {
            if(disposing) {
                DisposeReport();
                HeaderContent?.Dispose();
            }
            base.Dispose(disposing);
        }
        protected virtual void DisposeReport() {
            if(Report != null) {
                Report.AfterPrint -= report_AfterPrint;
                Report.Dispose();
                Report = null;
            }
        }
        static string GetReportPath(XtraReport fReport, string ext) {
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            string repName = fReport.Name;
            if(string.IsNullOrEmpty(repName))
                repName = fReport.GetType().Name;
            string dirName = Path.GetDirectoryName(asm.Location);
            return GetNewFilePath(Path.Combine(dirName, repName), ext);
        }
        static string GetNewFilePath(string repFullName, string ext) {
            int i = 0;
            string path = repFullName + "." + ext;
            Exception lastException = null;
            while(i < 20) {
                try {
                    using(FileStream testStream = File.Open(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None)) {
                    }
                    return path;
                }
                catch(Exception e) {
                    lastException = e;
                }
                i++;
                path = repFullName + i.ToString() + "." + ext;
            }
            if(lastException != null) {
                System.Diagnostics.Trace.WriteLine("ReportModule.GetNewFilePath error: " + lastException.ToString());
            }
            return null;
        }
    }
}
