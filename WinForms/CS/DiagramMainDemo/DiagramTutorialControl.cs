using System;
using System.Linq;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraDiagram.Demos {
    public partial class DiagramTutorialControl : DiagramTutorialControlBase {
        public DiagramTutorialControl() : this(true, true) {
        }
        protected override RibbonControl Ribbon {
            get { return containerControl == null ? null : containerControl.Controls.OfType<RibbonControl>().FirstOrDefault(); }
        }

        protected DiagramTutorialControl(bool createRibbon, bool createDocking) {
            InitializeComponent();
            if(createRibbon)
                Diagram.CreateRibbon();
            if(createDocking) {
                Diagram.CreateDocking(Docking.DockingMode.All);
                SubscribePanAndZoomEvents();
            }             
        }
        protected override void CreateDockingWithPanAndZoom() {}
    }
}
