using System;
using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class AreaViewsDemo : ChartDemoModuleMarkerViews {
        bool IsStackedAreaSeriesActive {
            get {
                SeriesViewBase view = ActiveSeries.View;
                return view is StackedAreaSeriesView || view is StackedSplineAreaSeriesView || view is StackedStepAreaSeriesView || IsFullStackedAreaSeriesActive;
            }
        }
        bool IsFullStackedAreaSeriesActive {
            get {
                SeriesViewBase view = ActiveSeries.View;
                return view is FullStackedAreaSeriesView || view is FullStackedSplineAreaSeriesView || view is FullStackedStepAreaSeriesView;
            }
        }
        bool IsStepAreaSeriesActive {
            get {
                SeriesViewBase view = ActiveSeries.View;
                return view is StepAreaSeriesView || view is StackedStepAreaSeriesView || view is FullStackedStepAreaSeriesView;
            }
        }
        bool IsSplineAreaSeriesActive {
            get {
                SeriesViewBase view = ActiveSeries.View;
                return view is SplineAreaSeriesView || view is StackedSplineAreaSeriesView || view is FullStackedSplineAreaSeriesView;
            }
        }

        protected override LayoutControl OptionsLayoutControl {
            get { return layoutControl; }
        }
        protected override SpinEdit LabelAngleSpinEdit {
            get { return spinEditLabelAngle; }
        }
        protected override CheckEdit ValueAsPercentCheckEdit {
            get { return checkEditValueAsPercent; }
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
            get { return tabbedView; }
        }

        internal override List<ChartControl> ChartControls {
            get {
                return new List<ChartControl>() {
                    chartArea,
                    chartStackedArea,
                    chartFullStackedArea,
                    chartStepArea,
                    chartStackedStepArea,
                    chartFullStackedStepArea,
                    chartSplineArea,
                    chartStackedSplineArea,
                    chartFullStackedSplineArea };
            }
        }

        public AreaViewsDemo() {
            InitializeComponent();
        }

        void documentManager_DocumentActivate(object sender, DocumentEventArgs e) {
            OnDocumentActivated(e.Document);
        }
        void checkEditMarkerVisible_CheckedChanged(object sender, EventArgs e) {
            SetMarkerVisibility(layoutControlItemKind, layoutControlItemSize);
        }
        void checkEditLabelVisible_CheckedChanged(object sender, EventArgs e) {
            SetLabelVisibility(layoutControlItemAngle, layoutControlItemValueAsPercent);
        }
        void spinEditTransparency_EditValueChanged(object sender, EventArgs e) {
            ApplySettingsToSeriesView(SetTransparency);
        }
        void checkEditInvertedStep_CheckedChanged(object sender, EventArgs e) {
            ApplySettingsToSeriesView(SetInvertedStep);
        }
        void comboBoxEditSplineAlgorithm_SelectedIndexChanged(object sender, EventArgs e) {
            ApplySettingsToSeriesView(SetSplineAlgorithm);
        }
        void spinEditLineTension_EditValueChanged(object sender, EventArgs e) {
            ApplySettingsToSeriesView(SetLineTension);
        }
        void SetTransparency(SeriesViewBase view) {
            byte transparency = (byte)spinEditTransparency.Value;
            AreaSeriesView areaView = view as AreaSeriesView;
            if(areaView != null)
                areaView.Transparency = transparency;
        }
        void SetInvertedStep(SeriesViewBase view) {
            bool invertedStep = checkEditInvertedStep.Checked;
            StepAreaSeriesView stepAreaView = view as StepAreaSeriesView;
            StackedStepAreaSeriesView stackedStepAreaView = view as StackedStepAreaSeriesView;
            FullStackedStepAreaSeriesView fullStackedStepAreaView = view as FullStackedStepAreaSeriesView;
            if(stepAreaView != null)
                stepAreaView.InvertedStep = invertedStep;
            if(stackedStepAreaView != null)
                stackedStepAreaView.InvertedStep = invertedStep;
            if(fullStackedStepAreaView != null)
                fullStackedStepAreaView.InvertedStep = invertedStep;
        }
        void SetSplineAlgorithm(SeriesViewBase view) {
            SplineAlgorithm splineAlgorithm = (SplineAlgorithm)comboBoxEditSplineAlgorithm.SelectedIndex;
            SplineAreaSeriesView splineView = view as SplineAreaSeriesView;
            if(splineView != null) {
                splineView.SplineAlgorithm = splineAlgorithm;
                return;
            }
            StackedSplineAreaSeriesView stackedSplineView = view as StackedSplineAreaSeriesView;
            if(stackedSplineView != null) {
                stackedSplineView.SplineAlgorithm = splineAlgorithm;
                return;
            }
            FullStackedSplineAreaSeriesView fullStackedSplineView = view as FullStackedSplineAreaSeriesView;
            if(fullStackedSplineView != null) {
                fullStackedSplineView.SplineAlgorithm = splineAlgorithm;
                return;
            }
        }
        void SetLineTension(SeriesViewBase view) {
            int lineTension = Convert.ToInt32(spinEditLineTension.EditValue);
            SplineAreaSeriesView splineView = view as SplineAreaSeriesView;
            if(splineView != null) {
                splineView.LineTensionPercent = lineTension;
                return;
            }
            StackedSplineAreaSeriesView stackedSplineView = view as StackedSplineAreaSeriesView;
            if(stackedSplineView != null) {
                stackedSplineView.LineTensionPercent = lineTension;
                return;
            }
            FullStackedSplineAreaSeriesView fullStackedSplineView = view as FullStackedSplineAreaSeriesView;
            if(fullStackedSplineView != null) {
                fullStackedSplineView.LineTensionPercent = lineTension;
                return;
            }
        }
        int GetSplineAlgorithmIndex(SeriesViewBase view) {
            SplineAreaSeriesView splineView = view as SplineAreaSeriesView;
            if(splineView != null)
                return (int)splineView.SplineAlgorithm;
            StackedSplineAreaSeriesView stackedSplineView = view as StackedSplineAreaSeriesView;
            if(stackedSplineView != null)
                return (int)stackedSplineView.SplineAlgorithm;
            FullStackedSplineAreaSeriesView fullStackedSplineView = view as FullStackedSplineAreaSeriesView;
            if(fullStackedSplineView != null)
                return (int)fullStackedSplineView.SplineAlgorithm;
            return 0;
        }
        int GetLineTension(SeriesViewBase view) {
            SplineAreaSeriesView splineView = view as SplineAreaSeriesView;
            if(splineView != null)
                return splineView.LineTensionPercent;
            StackedSplineAreaSeriesView stackedSplineView = view as StackedSplineAreaSeriesView;
            if(stackedSplineView != null)
                return stackedSplineView.LineTensionPercent;
            FullStackedSplineAreaSeriesView fullStackedSplineView = view as FullStackedSplineAreaSeriesView;
            if(fullStackedSplineView != null)
                return fullStackedSplineView.LineTensionPercent;
            return 0;
        }

        protected override void UpdateControlsCore() {
            base.UpdateControlsCore();
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility == DefaultBoolean.True;
            layoutControlItemInvertedStep.Visibility = IsStepAreaSeriesActive ? LayoutVisibility.Always : LayoutVisibility.Never;
            if(IsFullStackedAreaSeriesActive) {
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Always;
                layoutControlItemAngle.Visibility = LayoutVisibility.Never;
                checkEditValueAsPercent.Checked = ActiveSeries.Label.TextPattern == PercentPattern;
            }
            else {
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Never;
                layoutControlItemAngle.Visibility = LayoutVisibility.Always;
                PointSeriesLabel pointLabel = ActiveSeries.Label as PointSeriesLabel;
                RangeAreaSeriesLabel rangeAreaLabel = ActiveSeries.Label as RangeAreaSeriesLabel;
                if(pointLabel != null)
                    spinEditLabelAngle.Value = pointLabel.Angle;
                if(rangeAreaLabel != null)
                    spinEditLabelAngle.Value = rangeAreaLabel.MinValueAngle;
            }
            if(IsSplineAreaSeriesActive) {
                layoutControlItemSplineAlgorithm.Visibility = LayoutVisibility.Always;
                comboBoxEditSplineAlgorithm.SelectedIndex = GetSplineAlgorithmIndex(ActiveSeries.View);
                layoutControlItemLineTension.Visibility = LayoutVisibility.Always;
                spinEditLineTension.EditValue = GetLineTension(ActiveSeries.View);
            }
            else {
                layoutControlItemSplineAlgorithm.Visibility = LayoutVisibility.Never;
                layoutControlItemLineTension.Visibility = LayoutVisibility.Never;
            }
            AreaSeriesView view = ActiveSeries.View as AreaSeriesView;
            if(view != null) {
                spinEditTransparency.Value = view.Transparency;
                bool markerOptionsVisible = !IsStackedAreaSeriesActive;
                layoutControlGroupMarker.Visibility = markerOptionsVisible ? LayoutVisibility.Always : LayoutVisibility.Never;
                if(markerOptionsVisible) {
                    RangeAreaSeriesView rangeView = view as RangeAreaSeriesView;
                    if(rangeView != null)
                        UpdateMarkerControls(rangeView.Marker1, rangeView.Marker1Visibility);
                    else
                        UpdateMarkerControls(view.MarkerOptions, view.MarkerVisibility);
                }
            }
        }
        protected override void SetDataSources() {
            chartArea.DataSource = DevAV.GetOutsideVendorCosts();
            chartStackedArea.DataSource = DevAV.GetSalesByLast10Years();
            chartFullStackedArea.DataSource = DevAV.GetBranchesSales();
            chartStepArea.DataSource = SourceOfEnergy.GetFuelPrices();
            chartSplineArea.DataSource = DevAV.GetOutsideVendorCosts();
            chartStackedSplineArea.DataSource = DevAV.GetSalesByLast10Years();
            chartFullStackedSplineArea.DataSource = DevAV.GetBranchesSales();
            chartRangeArea.DataSource = SourceOfEnergy.GetEuropeBrentPrices();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentManager.View.Controller.Activate(documentArea);
        }
        protected override bool SetRangeMarkerVisibility(SeriesViewBase view, DefaultBoolean visibility) {
            RangeAreaSeriesView rangeAreaView = view as RangeAreaSeriesView;
            if(rangeAreaView == null)
                return false;
            rangeAreaView.Marker1Visibility = visibility;
            rangeAreaView.Marker2Visibility = visibility;
            return true;
        }
        protected override bool SetRangeMarkerSize(SeriesViewBase view, int size) {
            RangeAreaSeriesView rangeAreaView = view as RangeAreaSeriesView;
            if(rangeAreaView == null)
                return false;
            rangeAreaView.Marker1.Size = size;
            rangeAreaView.Marker2.Size = size;
            return true;
        }
        protected override bool SetRangeMarkerKind(SeriesViewBase view, MarkerKind kind, int starCount) {
            RangeAreaSeriesView rangeAreaView = view as RangeAreaSeriesView;
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
