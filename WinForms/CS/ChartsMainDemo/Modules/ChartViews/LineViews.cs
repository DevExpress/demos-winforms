using System;
using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class LineViewsDemo : ChartDemoModuleMarkerViews {
        bool IsSplineChartActive {
            get { return ActiveSeries.View is SplineSeriesView; }
        }
        bool IsScatterLineChartActive {
            get { return ActiveSeries == null ? false : ActiveSeries.View is ScatterLineSeriesView; }
        }
        bool IsFullStackedChartActive {
            get { return ActiveSeries.View is FullStackedLineSeriesView; }
        }
        bool IsSplineOrStackedChartActive {
            get { return ActiveSeries.View is StackedLineSeriesView || IsSplineChartActive; }
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
            get { return currentTabbedView; }
        }

        internal override List<ChartControl> ChartControls {
            get {
                return new List<ChartControl>() {
                    chartLine,
                    chartStackedLine,
                    chartFullStackedLine,
                    chartStepLine,
                    chartSpline,
                    chartScatterLine
                };
            }
        }

        public LineViewsDemo() {
            InitializeComponent();
        }

        void tabbedView_DocumentActivated(object sender, DocumentEventArgs e) {
            OnDocumentActivated(e.Document);
            if(IsScatterLineChartActive)
                ScatterLineDataGenerator.ShowSeries(comboBoxEditFunction.SelectedIndex, ChartControl.Series);
        }
        void checkEditLabelVisible_CheckedChanged(object sender, EventArgs e) {
            SetLabelVisibility(layoutControlItemAngle, layoutControlItemValueAsPercent);
        }
        void checkEditMarkerVisible_CheckedChanged(object sender, EventArgs e) {
            SetMarkerVisibility(layoutControlItemMarkerKind, layoutControlItemMarkerSize);
        }
        void comboBoxSplineAlgorithm_SelectedIndexChanged(object sender, EventArgs e) {
            ApplySettingsToSeriesView((view) => ((SplineSeriesView)view).SplineAlgorithm = (SplineAlgorithm)comboBoxEditSplineAlgorithm.SelectedIndex);
        }
        void spinEditLineTension_EditValueChanged(object sender, EventArgs e) {
            ApplySettingsToSeriesView((view) => ((SplineSeriesView)view).LineTensionPercent = (int)spinEditLineTension.Value);
        }
        void comboBoxEditFunction_EditValueChanged(object sender, EventArgs e) {
            ScatterLineDataGenerator.ShowSeries(comboBoxEditFunction.SelectedIndex, ChartControl.Series);
            UpdateControlsCore();
        }
        void UpdateCommonOptionsGroup() {
            if(IsSplineChartActive || IsScatterLineChartActive) {
                layoutControlGroupGeneral.Visibility = LayoutVisibility.Always;
                if(IsScatterLineChartActive) {
                    layoutControlItemFunction.Visibility = LayoutVisibility.Always;
                    layoutControlItemSplineAlgorithm.Visibility = LayoutVisibility.Never;
                    layoutControlItemLineTension.Visibility = LayoutVisibility.Never;
                }
                else {
                    layoutControlItemFunction.Visibility = LayoutVisibility.Never;
                    layoutControlItemSplineAlgorithm.Visibility = LayoutVisibility.Always;
                    layoutControlItemLineTension.Visibility = LayoutVisibility.Always;
                    SplineSeriesView splineView = ActiveSeries.View as SplineSeriesView;
                    if(splineView != null) {
                        comboBoxEditSplineAlgorithm.SelectedIndex = (int)splineView.SplineAlgorithm;
                        spinEditLineTension.Value = splineView.LineTensionPercent;
                    }
                }
            }
            else
                layoutControlGroupGeneral.Visibility = LayoutVisibility.Never;
        }
        void UpdateLabelAngelOptions() {
            if(IsSplineOrStackedChartActive) {
                layoutControlItemAngle.Visibility = LayoutVisibility.Always;
                PointSeriesLabel pointLabel = ActiveSeries.Label as PointSeriesLabel;
                if(pointLabel != null)
                    spinEditLabelAngle.Value = pointLabel.Angle;
            }
            else
                layoutControlItemAngle.Visibility = LayoutVisibility.Never;
        }

        protected override void SetDataSources() {
            chartStackedLine.DataSource = DevAV.GetSalesByLast10Years();
            chartFullStackedLine.DataSource = DevAV.GetBranchesSales();
            chartStepLine.DataSource = SourceOfEnergy.GetFuelPrices();
            chartSpline.DataSource = PowerConsumption.GetData();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentManager.View.Controller.Activate(documentLine);
        }
        protected override void UpdateControlsCore() {
            base.UpdateControlsCore();
            if(ActiveSeries == null)
                return;
            UpdateCommonOptionsGroup();
            UpdateLabelAngelOptions();
            layoutControlItemValueAsPercent.Visibility = IsFullStackedChartActive ? LayoutVisibility.Always : LayoutVisibility.Never;
            LineSeriesView view = ActiveSeries.View as LineSeriesView;
            if(view != null) {
                UpdateMarkerControls(view.LineMarkerOptions, view.MarkerVisibility);
                checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility == DefaultBoolean.True;
            }
        }
    }
}
