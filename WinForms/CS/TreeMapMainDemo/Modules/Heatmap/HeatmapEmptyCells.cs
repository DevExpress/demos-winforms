using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts.Heatmap;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class HeatmapEmptyCells : TreeMapDemoModuleWithOptions {
        public override Control ActiveDemoModule { get { return heatmapControl1; } }
        public HeatmapEmptyCells() {
            InitializeComponent();
            ((HeatmapDataSourceAdapter)heatmapControl1.DataAdapter).DataSource = Utils.CreateDataSet("SalesPersons.xml");
            InitializeHighlightMode();
        }

        void InitializeHighlightMode() {
            highlightModeComboBoxEdit.Properties.Items.AddRange(new RadioGroupItem[] {
                new RadioGroupItem(HeatmapHighlightMode.Row, "Row"),
                new RadioGroupItem(HeatmapHighlightMode.Column, "Column"),
                new RadioGroupItem(HeatmapHighlightMode.RowAndColumn, "RowAndColumn"),
                new RadioGroupItem(HeatmapHighlightMode.Cell, "Cell"),
                new RadioGroupItem(HeatmapHighlightMode.None, "None") });
            highlightModeComboBoxEdit.SelectedIndex = 2;
        }
        void HighlightModeChanged(object sender, EventArgs e) {
            heatmapControl1.HighlightMode = (HeatmapHighlightMode)highlightModeComboBoxEdit.EditValue;
        }
        void DiagramColorChanged(object sender, EventArgs e) {
            heatmapControl1.Diagram.BackColor = (Color)colorPickEdit1.EditValue;
        }
    }
}
