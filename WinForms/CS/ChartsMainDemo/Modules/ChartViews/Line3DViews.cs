using System;
using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class Line3DViewsDemo : ChartDemoModule3DViews {
        bool IsStepLine3DSeriesActive {
            get { return ActiveSeries.View is StepLine3DSeriesView; }
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
        protected override CheckEdit LabelVisibleCheckEdit {
            get { return checkEditLabelVisible; }
        }
        protected override CheckEdit ValueAsPercentCheckEdit {
            get { return checkEditValueAsPercent; }
        }
        protected override TabbedView TabbedView {
            get { return currentTabbedView; }
        }

        internal override List<ChartControl> ChartControls {
            get {
                return new List<ChartControl>() {
                    chartLine3D,
                    chartStepLine3D,
                    chartSpline,
                    chartStackedLine,
                    chartFulStackedLine
                };
            }
        }

        public Line3DViewsDemo() {
            InitializeComponent();
        }

        void tabbedView_DocumentActivated(object sender, DocumentEventArgs e) {
            OnDocumentActivated(e.Document);
        }
        void SetCoalProductionDataSource(SeriesCollection seriesCollection) {
            foreach(Series series in seriesCollection)
                series.DataSource = SourceOfEnergy.GetCoalProduction();
        }
        void checkEditLabelVisible_CheckedChanged(object sender, EventArgs e) {
            SetLabelVisibility(LayoutControlItemValueAsPercent);
        }
        void checkEditInvertedStep_CheckedChanged(object sender, EventArgs e) {
            if(IsStepLine3DSeriesActive)
                ((StepLine3DSeriesView)ActiveSeries.View).InvertedStep = checkEditInvertedStep.Checked;
        }

        protected override void SetDataSources() {
            SetCoalProductionDataSource(chartLine3D.Series);
            chartStepLine3D.Series[0].DataSource = SourceOfEnergy.GetGasolinePrices();
            SetCoalProductionDataSource(chartSpline.Series);
            chartStackedLine.DataSource = DevAV.GetSalesByLast10Years();
            chartFulStackedLine.DataSource = DevAV.GetBranchesSales();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentManager.View.Controller.Activate(documentLine3D);
        }
        protected override void UpdateControlsCore() {
            base.UpdateControlsCore();
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility == DefaultBoolean.True;
            layoutControlGroupGeneral.Visibility = IsStepLine3DSeriesActive ? LayoutVisibility.Always : LayoutVisibility.Never;
            LayoutControlItemValueAsPercent.Visibility = ActiveSeries.View is FullStackedLine3DSeriesView ? LayoutVisibility.Always : LayoutVisibility.Never;
        }
    }
}
