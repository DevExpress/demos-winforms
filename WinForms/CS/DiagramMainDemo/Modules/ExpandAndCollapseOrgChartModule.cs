using System;
using System.Data;
using System.Linq;
using DevExpress.XtraLayout.Utils;
using DevExpress.Diagram.Demos;
using DevExpress.XtraBars.Ribbon;
using System.Drawing;
using DevExpress.XtraTreeList;
using DevExpress.XtraDiagram.Commands;
using DevExpress.Diagram.Core;

namespace DevExpress.XtraDiagram.Demos {
    public partial class ExpandAndCollapseOrgChartModule : DiagramTutorialControlBase {
        public ExpandAndCollapseOrgChartModule() {
            InitializeComponent();
            employeeBindingSource.DataSource = EmployeesData.GetOrgChartEmployees();
        }
        void OnItemsGenerated(object sender, DiagramItemsGeneratedEventArgs e) {
            foreach(var item in e.GeneratedItems) {
                item.ThemeStyleId = OrgChartHelpers.GetStyleID(item);
            }
        }
        void LayoutKindChanged(object sender, EventArgs e) {
            var layoutKind = (DiagramLayoutKind)layoutKindGroup.RadioGroup.Properties.Items[layoutKindGroup.RadioGroup.SelectedIndex].Value;
            if(Equals(layoutKind, DiagramLayoutKind.OrgChart))
                diagramControl.ApplyOrgChartLayout();
            if(Equals(layoutKind, DiagramLayoutKind.Tree))
                diagramControl.ApplyTreeLayout();
            if(Equals(layoutKind, DiagramLayoutKind.TipOverTree))
                diagramControl.ApplyTipOverTreeLayout();
            if(Equals(layoutKind, DiagramLayoutKind.MindMapTree))
                diagramControl.ApplyMindMapTreeLayout();
            diagramOrgChartController1.LayoutKind = layoutKind;
            diagramControl.FitToItems(diagramControl.Items);
        }
        void FitToItems(object sender, EventArgs e) {
            diagramControl.FitToItems(diagramControl.Items);
        }
    }
}
