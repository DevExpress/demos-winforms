using System;
using DevExpress.Diagram.Core;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Diagram.Core.Layout;

namespace DevExpress.XtraDiagram.Demos {
    public partial class LayoutModuleBase : DiagramTutorialControl {
        protected bool IsLoaded { get; set; }

        public LayoutModuleBase() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            IsLoaded = true;
            RelayoutDiagram();
        }
        protected void RelayoutDiagram() {
            if(Diagram == null || !IsLoaded)
                return;
            RelayoutDiagramCore();
            Application.DoEvents();
            Diagram.FitToPage();
        }
        protected virtual void RelayoutDiagramCore() { }
    }
}
