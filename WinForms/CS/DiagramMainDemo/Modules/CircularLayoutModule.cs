using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraDiagram.Demos;
using DevExpress.DXperience.Demos;
using DevExpress.Diagram.Core;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils;
using DevExpress.XtraDiagram.Utils;
using DevExpress.Diagram.Core.Layout;
using DevExpress.XtraEditors;

namespace DevExpress.XtraDiagram.Demos {
    public partial class CircularLayoutModule : LayoutModuleBase {
        public CircularLayoutModule() { 
            InitializeComponent();
            LoadDocument("CircularLayoutDiagram.xml");
        }
        protected override void RelayoutDiagramCore() {
            Diagram.ApplyCircularLayout();
        }
        protected virtual void CircularOrderGroupSelectedItemChanged(object sender, EventArgs e) {
            RelayoutDiagram();
        }
        protected virtual void TrackBarValueChanged(object sender, EventArgs e) {
            RelayoutDiagram();
        }
    }
}
