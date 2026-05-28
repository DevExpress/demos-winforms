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
    public partial class LayeredLayoutModule : LayoutModuleBase {
        public LayeredLayoutModule() {
            InitializeComponent();
            LoadDocument("LayeredLayoutDiagram.xml");
        }
        protected override void RelayoutDiagramCore() {
            Diagram.ApplySugiyamaLayout();
        }
        protected virtual void RadioGroupSelectedItemChanged(object sender, EventArgs e) {
            RelayoutDiagram();
        }
        protected virtual void TrackBarValueChanged(object sender, EventArgs e) {
            RelayoutDiagram();
        }
    }
}
