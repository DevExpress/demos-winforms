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

namespace DevExpress.XtraDiagram.Demos {
    public partial class FlowChartModule : DiagramTutorialControl {
        public FlowChartModule() {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            LoadDocument("Flowchart.xml");
        }
    }
}
