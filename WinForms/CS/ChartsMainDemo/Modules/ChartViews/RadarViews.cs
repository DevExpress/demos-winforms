using System;
using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class RadarViewsDemo : ChartDemoModuleMarkerViews {
        bool IsScatterLineSeriesActive {
            get { return ActiveSeries.View is ScatterRadarLineSeriesView; }
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
                    chartRangeArea,
                    chartScatterLine
                };
            }
        }

        public RadarViewsDemo() {
            InitializeComponent();
        }

        void tabbedView_DocumentActivated(object sender, DocumentEventArgs e) {
            OnDocumentActivated(e.Document);
            if(IsScatterLineSeriesActive)
                comboBoxEditFunction.SelectedIndex = 0;
        }
        void checkEditLabelVisible_CheckedChanged(object sender, EventArgs e) {
            SetLabelVisibility();
        }
        void checkEditMarkerVisible_CheckedChanged(object sender, EventArgs e) {
            SetMarkerVisibility(layoutControlItemMarkerKind, layoutControlItemMarkerSize);
        }
        void comboBoxEditTextDirection_SelectedIndexChanged(object sender, EventArgs e) {
            RadarAxisXLabelTextDirection textDirection = ((DirectionComboBoxItem)comboBoxEditTextDirection.EditValue).Direction;
            RadarDiagram diagram = ChartControl.Diagram as RadarDiagram;
            if(diagram != null)
                diagram.AxisX.Label.TextDirection = textDirection;
        }
        void comboBoxEditDiagramStyle_SelectedIndexChanged(object sender, EventArgs e) {
            RadarDiagram diagram = ChartControl.Diagram as RadarDiagram;
            if(diagram != null)
                diagram.DrawingStyle = (RadarDiagramDrawingStyle)comboBoxDiagramStyle.SelectedIndex;
        }
        void comboBoxEditFunction_SelectedIndexChanged(object sender, EventArgs e) {
            Series series = ActiveSeries as Series;
            if(series == null)
                return;
            series.Points.Clear();
            RadianScatterFunctionCalculator functionCalculator = new RadianScatterFunctionCalculator();
            SeriesPoint[] points = functionCalculator.GenerateScatterFunctionPoints(comboBoxEditFunction.SelectedIndex);
            series.Points.AddRange(points);
            ChartControl.Animate();
        }
        void comboBoxEditRotationDirection_SelectedIndexChanged(object sender, EventArgs e) {
            RadarDiagram diagram = ChartControl.Diagram as RadarDiagram;
            if(diagram != null)
                diagram.RotationDirection = (RadarDiagramRotationDirection)comboBoxEditRotationDirection.SelectedIndex;
        }
        void spinEditStartAngle_EditValueChanged(object sender, EventArgs e) {
            RadarDiagram diagram = ChartControl.Diagram as RadarDiagram;
            if(diagram != null)
                diagram.StartAngleInDegrees = (int)spinEditStartAngle.Value;
        }
        void spinEditAxisLabelAngle_EditValueChanged(object sender, EventArgs e) {
            RadarDiagram diagram = ChartControl.Diagram as RadarDiagram;
            if(diagram != null)
                diagram.AxisY.Label.Angle = (int)spinEditAxisLabelAngle.Value;
        }

        protected override void InitControls() {
            base.InitControls();
            Array directions = Enum.GetValues(typeof(RadarAxisXLabelTextDirection));
            foreach(RadarAxisXLabelTextDirection direction in directions)
                comboBoxEditTextDirection.Properties.Items.Add(new DirectionComboBoxItem(direction));
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentManager.View.Controller.Activate(documentPoint);
        }
        protected override void UpdateControlsCore() {
            base.UpdateControlsCore();
            layoutControlItemTextDirection.Visibility = IsScatterLineSeriesActive ? LayoutVisibility.Never : LayoutVisibility.Always;
            layoutControlItemFunction.Visibility = IsScatterLineSeriesActive ? LayoutVisibility.Always : LayoutVisibility.Never;
            layoutControlGroupGeneral.Visibility = IsScatterLineSeriesActive ? LayoutVisibility.Always : LayoutVisibility.Never;
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility == DefaultBoolean.True;
            RadarDiagram diagram = ChartControl.Diagram as RadarDiagram;
            if(diagram != null) {
                comboBoxEditTextDirection.EditValue = new DirectionComboBoxItem(diagram.AxisX.Label.TextDirection);
                comboBoxDiagramStyle.SelectedIndex = (int)diagram.DrawingStyle;
                comboBoxEditRotationDirection.SelectedIndex = (int)diagram.RotationDirection;
                spinEditStartAngle.EditValue = diagram.StartAngleInDegrees;
                spinEditAxisLabelAngle.EditValue = diagram.AxisY.Label.Angle;
            }
            layoutControlItemMarkerVisible.Visibility = UpdateRadarMarkerOptions();
        }
        protected override bool SetRangeMarkerVisibility(SeriesViewBase view, DefaultBoolean visibility) {
            RadarRangeAreaSeriesView rangeAreaView = view as RadarRangeAreaSeriesView;
            if(rangeAreaView == null)
                return false;
            rangeAreaView.Marker1Visibility = visibility;
            rangeAreaView.Marker2Visibility = visibility;
            return true;
        }
        protected override bool SetRangeMarkerSize(SeriesViewBase view, int size) {
            RadarRangeAreaSeriesView rangeAreaView = view as RadarRangeAreaSeriesView;
            if(rangeAreaView == null)
                return false;
            rangeAreaView.Marker1.Size = size;
            rangeAreaView.Marker2.Size = size;
            return true;
        }
        protected override bool SetRangeMarkerKind(SeriesViewBase view, MarkerKind kind, int starCount) {
            RadarRangeAreaSeriesView rangeAreaView = view as RadarRangeAreaSeriesView;
            if(rangeAreaView == null)
                return false;
            rangeAreaView.Marker1.Kind = kind;
            rangeAreaView.Marker1.StarPointCount = starCount;
            rangeAreaView.Marker2.Kind = kind;
            rangeAreaView.Marker2.StarPointCount = starCount;
            return true;
        }
    }


    class DirectionComboBoxItem {
        public string Text {
            get;
            private set;
        }
        public RadarAxisXLabelTextDirection Direction {
            get;
            private set;
        }

        public DirectionComboBoxItem(RadarAxisXLabelTextDirection textDirection) {
            Direction = textDirection;
            Text = Utils.SplitByWords(textDirection.ToString()).Replace("To ", "to ");
        }

        public override bool Equals(object obj) {
            if(obj == null)
                return false;
            DirectionComboBoxItem directionComboBoxItem = obj as DirectionComboBoxItem;
            if(directionComboBoxItem == null)
                return false;
            return (Direction == directionComboBoxItem.Direction);
        }
        public override int GetHashCode() {
            return Direction.GetHashCode();
        }
        public override string ToString() {
            return Text;
        }
    }

}
