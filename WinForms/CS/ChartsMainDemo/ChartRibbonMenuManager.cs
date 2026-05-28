using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Drawing.Internal;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraSplashScreen;

namespace DevExpress.XtraCharts.Demos {
    class ChartRibbonMenuManager : RibbonMenuManager, IDisposable {
        BarSubItem bsiPalettes;
        ButtonBarItem bbiChartDesigner;
        readonly RibbonMainForm ribbonForm;
        bool disposedValue = false;

        public ChartDemoModule CurrentModule {
            get;
            set;
        }

        internal ChartRibbonMenuManager(RibbonMainForm form)
            : base(form) {
            ribbonForm = form;
            form.ReservGroup1.Text = "Chart";
            CreateChartPaletteRibbonItem(form.ReservGroup1);
            CreateChartDesignerRibbonItem(form.ReservGroup1);
        }

        #region IDisposable Support

        protected virtual void Dispose(bool disposing) {
            if(!disposedValue) {
                if(disposing) {
                    if(bbiChartDesigner != null)
                        bbiChartDesigner.Dispose();
                    if(bsiPalettes != null)
                        bsiPalettes.Dispose();
                }
                bbiChartDesigner = null;
                bsiPalettes = null;
                disposedValue = true;
            }
        }

        public void Dispose() {
            Dispose(true);
        }
        #endregion

        void CreateChartPaletteRibbonItem(RibbonPageGroup ribbonPageGroup) {
            ChartControl chart = new ChartControl();
            bsiPalettes = new BarSubItem();
            bsiPalettes.Caption = "Palette";
            bsiPalettes.ImageOptions.SvgImage = Properties.Resources.Palette;
            bsiPalettes.ItemClick += cbiPaletteName_Click;
            string[] paletteNames = chart.GetLocalizedPaletteNames();
            int defaultIndex = 0;
            for(int i = 0; i < paletteNames.Length; i++) {
                Palette palette = chart.PaletteRepository[paletteNames[i]];
                Image image = SystemDrawingConverter.UnwrapImage(PaletteUtils.CreateEditorImage(palette, 6));
                CheckBarItem cbiPaletteName = new CheckBarItem(Manager, paletteNames[i], cbiPaletteName_Click);
                cbiPaletteName.Glyph = image;
                if(paletteNames[i] == chart.PaletteName)
                    defaultIndex = i;
                bsiPalettes.ItemLinks.Add(cbiPaletteName);
            }
            ribbonPageGroup.ItemLinks.Add(bsiPalettes);
            if(paletteNames.Length > 0) {
                CheckBarItem item = bsiPalettes.ItemLinks[defaultIndex].Item as CheckBarItem;
                if(bsiPalettes != null) {
                    cbiPaletteName_Click(Manager, new ItemClickEventArgs(item, null));
                    item.Checked = true;
                }
            }
            chart.Dispose();
        }
        void CreateChartDesignerRibbonItem(RibbonPageGroup ribbonPageGroup) {
            bbiChartDesigner = new ButtonBarItem(Manager, "Designer", new ItemClickEventHandler(bbiChartDesigner_Click));
            bbiChartDesigner.ImageOptions.SvgImage = Properties.Resources.Designer;
            ribbonPageGroup.ItemLinks.Add(bbiChartDesigner);
        }
        void cbiPaletteName_Click(object sender, ItemClickEventArgs e) {
            CheckBarItem item = e.Item as CheckBarItem;
            if(item != null)
                DemosInfo.SetPaletteName(item.Caption);
            UpdateSelectedPalette();
        }
        void bbiChartDesigner_Click(object sender, ItemClickEventArgs e) {
            IOverlaySplashScreenHandle h = ShowProgressPanel();
            CurrentModule.BeforeChartDesignerShown();
            if(DemosInfo.RunChartDesigner().Equals(DialogResult.OK) && bsiPalettes != null)
                OnChartDesignerClosed();
            CloseProgressPanel(h);
        }
        void OnChartDesignerClosed() {
            UpdateSelectedPalette();
            CurrentModule.OnChartDesignerClosed();
        }
        void UpdateSelectedPalette() {
            if(CurrentModule == null || CurrentModule.ChartControl == null)
                return;
            string paletteName = CurrentModule.ChartControl.PaletteName;
            int count = bsiPalettes.ItemLinks.Count;
            for(int i = 0; i < count; i++) {
                BarCheckItem item = bsiPalettes.ItemLinks[i].Item as BarCheckItem;
                if(item != null && CurrentModule != null)
                    item.Checked = item.Caption == paletteName;
            }
        }
        IOverlaySplashScreenHandle ShowProgressPanel() {
            IOverlaySplashScreenHandle handle = null;
            try {
                handle = SplashScreenManager.ShowOverlayForm(ribbonForm, OverlayWindowOptions.Default);
            }
            catch {
            }
            return handle;
        }
        void CloseProgressPanel(IOverlaySplashScreenHandle handle) {
            try {
                SplashScreenManager.CloseOverlayForm(handle);
            }
            catch {
            }
        }

        internal void UpdateMenu(bool chartDesignerButtonEnabled, bool chartPaletteButtonEnabled) {
            if(bsiPalettes != null)
                bsiPalettes.Visibility = chartPaletteButtonEnabled ? BarItemVisibility.Always : BarItemVisibility.Never;
            if(bbiChartDesigner != null)
                bbiChartDesigner.Visibility = chartDesignerButtonEnabled ? BarItemVisibility.Always : BarItemVisibility.Never;
            ribbonForm.ReservGroup1.Visible = chartPaletteButtonEnabled || chartDesignerButtonEnabled;
        }
    }
}
