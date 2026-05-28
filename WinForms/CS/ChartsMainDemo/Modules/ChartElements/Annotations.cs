using System;

namespace DevExpress.XtraCharts.Demos {
    public partial class AnnotationsDemo : ChartDemoModuleWithOptions {
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public AnnotationsDemo() {
            InitializeComponent();
            AutoMergeRibbon = true;
        }

        void checkEditMoving_CheckedChanged(object sender, EventArgs e) {
            foreach(Annotation annotation in chart.AnnotationRepository)
                annotation.RuntimeMoving = checkEditMoving.Checked;
        }
        void checkEditResizing_CheckedChanged(object sender, EventArgs e) {
            foreach(Annotation annotation in chart.AnnotationRepository)
                annotation.RuntimeResizing = checkEditResizing.Checked;
        }
        void checkEditRotation_CheckedChanged(object sender, EventArgs e) {
            foreach(Annotation annotation in chart.AnnotationRepository)
                annotation.RuntimeRotation = checkEditRotation.Checked;
        }
        void checkEditAnchoring_CheckedChanged(object sender, EventArgs e) {
            foreach(Annotation annotation in chart.AnnotationRepository)
                annotation.RuntimeAnchoring = checkEditAnchoring.Checked;
        }
        void checkEditEditing_CheckedChanged(object sender, EventArgs e) {
            foreach(Annotation annotation in chart.AnnotationRepository)
                annotation.RuntimeEditing = checkEditEditing.Checked;
        }
        void comboBoxEditConnector_SelectedIndexChanged(object sender, EventArgs e) {
            foreach(Annotation annotation in chart.AnnotationRepository)
                annotation.ConnectorStyle = (AnnotationConnectorStyle)comboBoxEditConnector.SelectedIndex;
        }
        void comboBoxEditShape_SelectedIndexChanged(object sender, EventArgs e) {
            foreach(Annotation annotation in chart.AnnotationRepository)
                annotation.ShapeKind = (ShapeKind)comboBoxEditShape.SelectedIndex;
        }
        void OnChartObjectHotTrackedOrSelected(object sender, HotTrackEventArgs e) {
            e.Cancel = !(e.Object is Annotation);
        }
        void OnAnnotationRepositoryChanged(object sender, AnnotationRepositoryChangedEventArgs e) {
            if(e.Change == AnnotationRepositoryChange.Addition)
                ApplyAnnotationOptions(e.Annotation);
        }
        void ApplyAnnotationOptions(Annotation annotation) {
            annotation.RuntimeMoving = checkEditMoving.Checked;
            annotation.RuntimeResizing = checkEditResizing.Checked;
            annotation.RuntimeRotation = checkEditRotation.Checked;
            annotation.RuntimeAnchoring = checkEditAnchoring.Checked;
            annotation.RuntimeEditing = checkEditEditing.Checked;
            annotation.ConnectorStyle = (AnnotationConnectorStyle)comboBoxEditConnector.SelectedIndex;
            annotation.ShapeKind = (ShapeKind)comboBoxEditShape.SelectedIndex;
        }
    }
}
