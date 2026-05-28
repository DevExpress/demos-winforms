using System;
using DevExpress.Diagram.Core;
using DevExpress.Diagram.Demos;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Svg;

namespace DevExpress.XtraDiagram.Demos {
    public partial class FloorPlanModule : DiagramTutorialControl {
        DiagramStencil homeObjectsStencil;
        SvgBitmap backgroundSvgBitmap;

        public FloorPlanModule() {
            InitializeComponent();
            InitializeBackgroundImage();
            InitializeStencils();

            this.diagramControl.CustomDrawBackground += DiagramControl_CustomDrawBackground;
            this.diagramControl.ItemInitializing += DiagramControlItemInitializing;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            LoadDocument("OfficePlan.xml");
        }
        void InitializeBackgroundImage() {
            const string filePath = "images/backgrounds/floor.svg";
            var assembly = this.GetType().Assembly;
            using(var stream = AssemblyHelper.GetResourceStream(assembly, filePath, true)) {
                this.backgroundSvgBitmap = SvgBitmap.FromStream(stream);
            }
        }
        void InitializeStencils() {
            this.homeObjectsStencil = DemoHelper.CreatePredefinedSvgStencil("HomeObjects", "Home Objects", true);
            diagramControl.OptionsBehavior.Stencils = DemoHelper.CreateExtendedStencilCollection(homeObjectsStencil);
        }
        void DiagramControl_CustomDrawBackground(object sender, CustomDrawBackgroundEventArgs e) {
            var graphicsState = e.GraphicsCache.Paint.SaveCacheState(e.GraphicsCache);
            try {
                e.GraphicsCache.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.GraphicsCache.TranslateTransform(diagramControl.OptionsView.PageMargin.Left, diagramControl.OptionsView.PageMargin.Top);
                using(var svgCache = new GraphicsCacheSvgWrapper(e.GraphicsCache)) {
                    backgroundSvgBitmap.RenderToSvgGraphics(svgCache);
                }
            }
            finally {
                e.GraphicsCache.Paint.RestoreCacheState(e.GraphicsCache, graphicsState);
            }
        }
        void DiagramControlItemInitializing(object sender, DiagramItemInitializingEventArgs e) {
            DemoHelper.InitializeSvgShape(homeObjectsStencil, e.Item as IDiagramShape);
        }
    }
}
