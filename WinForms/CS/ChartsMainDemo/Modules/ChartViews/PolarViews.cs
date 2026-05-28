using System;
using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace DevExpress.XtraCharts.Demos {
    public partial class PolarViewsDemo : ChartDemoModuleMarkerViews {
        readonly string[] polarDiagramFunctions = new string[] { "Circles", "Cardioid", "Lemniscate" };
        readonly string[] scatterLineFunctions = new string[] { "Archimedean Spiral", "Cardioid", "Cartesian Folium" };

        bool IsScatterLineSeriesActive {
            get { return ActiveSeries.View is ScatterPolarLineSeriesView; }
        }

        protected override LayoutControl OptionsLayoutControl {
            get { return layoutControl; }
        }
        protected override CheckEdit LabelVisibleCheckEdit {
            get { return checkEditLabelVisible; }
        }
        protected override ComboBoxEdit MarkerKindComboBox {
            get { return comboBoxEditMarkerKind; }
        }
        protected override SpinEdit MarkerSizeSpinEdit {
            get { return spinEditMarkerSize; }
        }
        protected override CheckEdit MarkerVisibleCheckEdit {
            get { return checkEditMarkerVisible; }
        }
        protected override TabbedView TabbedView {
            get { return currentTabbedView; }
        }

        internal override List<ChartControl> ChartControls {
            get {
                return new List<ChartControl>() {
                    chartPoint,
                    chartLine,
                    chartArea,
                    chartScatterLine,
                    chartRangeArea
                };
            }
        }

        public PolarViewsDemo() {
            InitializeComponent();
        }

        void tabbedView_DocumentActivated(object sender, DocumentEventArgs e) {
            OnDocumentActivated(e.Document);
            comboBoxEditFunction.Properties.Items.Clear();
            comboBoxEditFunction.Properties.Items.AddRange(IsScatterLineSeriesActive ? scatterLineFunctions : polarDiagramFunctions);
            comboBoxEditFunction.SelectedIndex = IsScatterLineSeriesActive ? 0 : 2;
            UpdatePoints();
        }
        void checkEditLabelVisible_CheckedChanged(object sender, EventArgs e) {
            SetLabelVisibility();
        }
        void checkEditMarkerVisible_CheckedChanged(object sender, EventArgs e) {
            SetMarkerVisibility(layoutControlItemKind, layoutControlItemSize);
        }
        void comboBoxEditStyle_SelectedIndexChanged(object sender, EventArgs e) {
            PolarDiagram diagram = ChartControl.Diagram as PolarDiagram;
            if(diagram != null)
                diagram.DrawingStyle = (RadarDiagramDrawingStyle)comboBoxStyle.SelectedIndex;
        }
        void comboBoxEditFunction_SelectedIndexChanged(object sender, EventArgs e) {
            if(ChartControl.Series.Count > 0 && ChartControl.Diagram is PolarDiagram)
                UpdatePoints();
        }
        void comboBoxEditRotationDirection_SelectedIndexChanged(object sender, EventArgs e) {
            PolarDiagram diagram = ChartControl.Diagram as PolarDiagram;
            if(diagram != null)
                diagram.RotationDirection = (RadarDiagramRotationDirection)comboBoxEditRotationDirection.SelectedIndex;
        }
        void spinEditStartAngle_EditValueChanged(object sender, EventArgs e) {
            PolarDiagram diagram = ChartControl.Diagram as PolarDiagram;
            if(diagram != null)
                diagram.StartAngleInDegrees = (int)spinEditStartAngle.Value;
        }
        void spinEditAxisLabelAngle_EditValueChanged(object sender, EventArgs e) {
            PolarDiagram diagram = ChartControl.Diagram as PolarDiagram;
            if(diagram != null)
                diagram.AxisY.Label.Angle = (int)spinEditAxisLabelAngle.Value;
        }
        void UpdatePoints() {
            SeriesPoint[] points = null;
            if(IsScatterLineSeriesActive) {
                DegreeScatterFunctionCalculator functionCalculator = new DegreeScatterFunctionCalculator();
                points = functionCalculator.GenerateScatterFunctionPoints(comboBoxEditFunction.SelectedIndex);
            }
            else {
                int pointCount = ActiveSeries.View is PolarRangeAreaSeriesView ? 2 : 1;
                points = PolarDiagramPointsGenerator.GenerateFunctionPoints(comboBoxEditFunction.SelectedIndex, pointCount);
            }
            ChartControl.Series[0].Points.Clear();
            ChartControl.Series[0].Points.AddRange(points);
            ChartControl.Series[0].Name = comboBoxEditFunction.Text;
            ChartControl.Animate();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentManager.View.Controller.Activate(documentPoint);
        }
        protected override void UpdateControlsCore() {
            base.UpdateControlsCore();
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility == DefaultBoolean.True;
            PolarDiagram diagram = ChartControl.Diagram as PolarDiagram;
            if(diagram != null) {
                comboBoxStyle.SelectedIndex = (int)diagram.DrawingStyle;
                comboBoxEditRotationDirection.SelectedIndex = (int)diagram.RotationDirection;
                spinEditStartAngle.EditValue = diagram.StartAngleInDegrees;
                spinEditAxisLabelAngle.EditValue = diagram.AxisY.Label.Angle;
            }
            layoutControlItemMarkerVisible.Visibility = UpdateRadarMarkerOptions();
        }
        protected override bool SetRangeMarkerVisibility(SeriesViewBase view, DefaultBoolean visibility) {
            PolarRangeAreaSeriesView rangeAreaView = view as PolarRangeAreaSeriesView;
            if(rangeAreaView == null)
                return false;
            rangeAreaView.Marker1Visibility = visibility;
            rangeAreaView.Marker2Visibility = visibility;
            return true;
        }
        protected override bool SetRangeMarkerSize(SeriesViewBase view, int size) {
            PolarRangeAreaSeriesView rangeAreaView = view as PolarRangeAreaSeriesView;
            if(rangeAreaView == null)
                return false;
            rangeAreaView.Marker1.Size = size;
            rangeAreaView.Marker2.Size = size;
            return true;
        }
        protected override bool SetRangeMarkerKind(SeriesViewBase view, MarkerKind kind, int starCount) {
            PolarRangeAreaSeriesView rangeAreaView = view as PolarRangeAreaSeriesView;
            if(rangeAreaView == null)
                return false;
            rangeAreaView.Marker1.Kind = kind;
            rangeAreaView.Marker1.StarPointCount = starCount;
            rangeAreaView.Marker2.Kind = kind;
            rangeAreaView.Marker2.StarPointCount = starCount;
            return true;
        }
    }
}

