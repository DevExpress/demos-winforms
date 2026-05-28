using System;
using System.Drawing;
using DevExpress.Diagram.Core;
using DevExpress.Diagram.Demos;

namespace DevExpress.XtraDiagram.Demos {
    public partial class MindMapTreeLayoutModule : LayoutModuleBase {
        public MindMapTreeLayoutModule() {
            InitializeComponent();
            LoadDocument("MindMapTreeLayoutDiagram.xml");
            Diagram.OptionsProtection.AllowUndoRedo = false;
            Diagram.SelectionChanged += OnSelectionChanged;
        }
        protected override void RelayoutDiagramCore() {
            Diagram.ApplyMindMapTreeLayout();
        }
        protected virtual void RadioGroupSelectedItemChanged(object sender, EventArgs e) {
            RelayoutDiagram();
        }
        protected virtual void TrackBarValueChanged(object sender, EventArgs e) {
            RelayoutDiagram();
        }
        void AddChild(object sender, EventArgs e) {
            var parent = diagramControl.PrimarySelection as DiagramItem;
            var size = MindMapHelpers.GetSize(OrgChartHelpers.GetItemLevel(parent) + 1);
            var child = new DiagramShape() { Shape = BasicShapes.Ellipse, Width = (float)size.Width, Height = (float)size.Height, Content = "New Item" };
            child.Appearance.Font = new Font("Segoe UI", MindMapHelpers.GetFontSize(OrgChartHelpers.GetItemLevel(parent) + 1));
            child.ThemeStyleId = MindMapHelpers.GetMindMapStyle(child, parent);
            Diagram.Items.Add(child);
            var connector = new DiagramConnector() { Type = ConnectorType.Curved, ThemeStyleId = child.ThemeStyleId, BeginItem = parent, EndItem = child };
            connector.Appearance.BorderSize = 3;
            Diagram.Items.Add(connector);
            RelayoutDiagramCore();
        }

        void OnSelectionChanged(object sender, DiagramSelectionChangedEventArgs e) {
            addChildButton.Enabled = Diagram.PrimarySelection is DiagramShape;
        }
    }
}
