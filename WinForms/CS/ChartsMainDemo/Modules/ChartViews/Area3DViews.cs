using System;
using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class Area3DViewsDemo : ChartDemoModule3DViews {
        bool IsFullStackedArea3DSeriesActive {
            get {
                SeriesViewBase view = ActiveSeries.View;
                return view is FullStackedArea3DSeriesView || view is FullStackedSplineArea3DSeriesView;
            }
        }
        bool IsStepArea3DSeriesActive {
            get { return ActiveSeries.View is StepArea3DSeriesView; }
        }

        protected override LayoutControl OptionsLayoutControl {
            get { return layoutControl; }
        }
        protected override SimpleButton DefaultAnglesButton {
            get { return simpleButtonRestoreDefaultAngles; }
        }
        protected override ComboBoxEdit PerspectiveAngleComboBoxEdit {
            get { return comboBoxEditPerspectiveAngle; }
        }
        protected override CheckEdit ValueAsPercentCheckEdit {
            get { return checkEditValueAsPercent; }
        }
        protected override CheckEdit LabelVisibleCheckEdit {
            get { return checkEditLabelVisible; }
        }
        protected override TabbedView TabbedView {
            get { return currentTabbedView; }
        }

        internal override List<ChartControl> ChartControls {
            get {
                return new List<ChartControl>() { chartStackedArea3D, chartRangeArea3D, chartStepArea3D, chartSplineArea3D, chartArea3D, chartStackedSplineArea3D, chartFullStackedArea3D, chartFullStackedSplineArea3D };
            }
        }

        public Area3DViewsDemo() {
            InitializeComponent();
        }

        void documentManager_DocumentActivate(object sender, DocumentEventArgs e) {
            OnDocumentActivated(e.Document);
        }
        void checkEditLabelVisible_CheckedChanged(object sender, EventArgs e) {
            SetLabelVisibility(layoutControlItemValueAsPercent);
        }
        void spinEditTransparency_EditValueChanged(object sender, EventArgs e) {
            ApplySettingsToSeriesView(ApplyTransparency);
        }
        void ApplyTransparency(SeriesViewBase view) {
            Area3DSeriesView areaView = view as Area3DSeriesView;
            if(areaView != null)
                areaView.Transparency = (byte)spinEditTransparency.Value;
        }
        void checkEditInvertedStep_CheckedChanged(object sender, EventArgs e) {
            StepArea3DSeriesView view = ActiveSeries.View as StepArea3DSeriesView;
            if(view != null)
                view.InvertedStep = checkEditInvertedStep.Checked;
        }

        protected override void UpdateControlsCore() {
            base.UpdateControlsCore();
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility == DefaultBoolean.True;
            layoutControlItemInvertedStep.Visibility = IsStepArea3DSeriesActive ? LayoutVisibility.Always : LayoutVisibility.Never;
            if(IsFullStackedArea3DSeriesActive) {
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Always;
                checkEditValueAsPercent.Checked = ActiveSeries.Label.TextPattern == PercentPattern;
            }
            else
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Never;
            Area3DSeriesView view = ActiveSeries.View as Area3DSeriesView;
            if(view != null)
                spinEditTransparency.Value = view.Transparency;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentManager.View.Controller.Activate(documentArea3D);
        }
        protected override void SetDataSources() {
            chartStackedArea3D.DataSource = DevAV.GetSalesByLast10Years();
            chartRangeArea3D.DataSource = SourceOfEnergy.GetOkWtiPrices();
            chartStepArea3D.DataSource = SourceOfEnergy.GetGasolinePrices();
            chartSplineArea3D.DataSource = DevAV.GetOutsideVendorCosts();
            chartArea3D.DataSource = DevAV.GetOutsideVendorCosts();
            chartStackedSplineArea3D.DataSource = DevAV.GetSalesByLast10Years();
            chartFullStackedArea3D.DataSource = DevAV.GetBranchesSales();
            chartFullStackedSplineArea3D.DataSource = DevAV.GetBranchesSales();
        }
    }
}
