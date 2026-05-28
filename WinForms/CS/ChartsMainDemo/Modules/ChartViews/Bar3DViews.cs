using System;
using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class Bar3DViewsDemo : ChartDemoModule3DViews {
        const string DefaultBar3DModel = "Box";

        bool IsSideBySideStackSeriesActive {
            get {
                SeriesViewBase view = ActiveSeries.View;
                return view is SideBySideStackedBar3DSeriesView
                    || view is SideBySideFullStackedBar3DSeriesView;
            }
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
                return new List<ChartControl>() {
                    chartBar3D,
                    chartManhattanBar3D,
                    chartStackedBar3D,
                    chartStackedBar3DSideBySide,
                    chartFullStackedBar3D,
                    chartFullStackedBar3DSideBySide
                };
            }
        }

        public Bar3DViewsDemo() {
            InitializeComponent();
        }

        void tabbedView_DocumentActivated(object sender, DocumentEventArgs e) {
            OnDocumentActivated(e.Document);
        }
        void checkEditLabelVisible_CheckedChanged(object sender, EventArgs e) {
            SetLabelVisibility(layoutControlItemValueAsPercent);
        }
        void checkEditShowFacet_CheckedChanged(object sender, EventArgs e) {
            ApplySettingsToSeriesView(ApplyShowFacet);
        }
        void ApplyShowFacet(SeriesViewBase view) {
            Bar3DSeriesView seriesView = view as Bar3DSeriesView;
            if(seriesView != null)
                seriesView.ShowFacet = checkEditShowFacet.Checked;
        }
        void comboBoxEdit3DModel_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboBoxEdit3DModel.SelectedIndex == -1)
                return;
            ApplySettingsToSeriesView(ApplyBarModel);
        }
        void ApplyBarModel(SeriesViewBase view) {
            Bar3DModel barModel = (Bar3DModel)comboBoxEdit3DModel.SelectedIndex;
            Bar3DSeriesView seriesView = view as Bar3DSeriesView;
            if(seriesView != null)
                seriesView.Model = barModel;
            checkEditShowFacet.Enabled = IsFacetEnabled(barModel);
        }
        void comboBoxEditGroupSeriesBy_SelectedIndexChanged(object sender, EventArgs e) {
            ChartControl.RefreshData();
        }
        void OnStackedSideBySideChartsBoundDataChanged(object sender, EventArgs e) {
            DefaultBoolean labelVisibility = checkEditLabelVisible.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            StackGroupHelper.ApplyStackedGroup(ChartControl.Series, labelVisibility, comboBoxEditGroupSeriesBy.SelectedIndex, false);
        }
        void UpdateGroupByOption() {
            layoutControlGroupGroupSeriesBy.Visibility = LayoutVisibility.Always;
            if(ActiveSeries.Tag is GenderAgeInfo) {
                GenderAgeInfo genderAge = (GenderAgeInfo)ActiveSeries.Tag;
                comboBoxEditGroupSeriesBy.SelectedIndex = ((ISupportStackedGroup)ActiveSeries.View).StackedGroup.ToString() == genderAge.Age ? 1 : 0;
            }
        }
        void UpdateLabelOptions() {
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility == DefaultBoolean.True;
            FullStackedBar3DSeriesLabel fullStackedLabel = ActiveSeries.Label as FullStackedBar3DSeriesLabel;
            if(fullStackedLabel != null) {
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Always;
                checkEditValueAsPercent.Checked = fullStackedLabel.TextPattern == PercentPattern;
            }
            else
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Never;
        }
        void UpdateBarModelFacetOption() {
            layoutControlItem3DModel.Visibility = LayoutVisibility.Always;
            layoutControlItemShowFacet.Visibility = LayoutVisibility.Always;
            Bar3DSeriesView seriesView = ActiveSeries.View as Bar3DSeriesView;
            if(seriesView != null) {
                checkEditShowFacet.Checked = seriesView.ShowFacet;
                comboBoxEdit3DModel.SelectedIndex = (int)seriesView.Model;
            }
        }
        bool IsFacetEnabled(Bar3DModel barModel) {
            return (barModel.Equals(Bar3DModel.Box) || barModel.Equals(Bar3DModel.Cylinder));
        }

        protected override void InitControls() {
            base.InitControls();
            string[] bar3DModelArray = new string[] { DefaultBar3DModel, "Cylinder", "Cone", "Pyramid" };
            comboBoxEdit3DModel.Properties.Items.AddRange(bar3DModelArray);
            comboBoxEdit3DModel.Text = DefaultBar3DModel;
            comboBoxEdit3DModel.SelectedIndexChanged += comboBoxEdit3DModel_SelectedIndexChanged;
        }
        protected override void SetDataSources() {
            chartBar3D.DataSource = DevAV.GetSales();
            chartManhattanBar3D.DataSource = DevAV.GetSales();
            chartStackedBar3D.DataSource = AgeStructureDataReader.GetDataByFemaleAge();
            chartStackedBar3DSideBySide.DataSource = AgeStructureDataReader.GetDataByAgeAndGender();
            chartStackedBar3DSideBySide.BoundDataChanged += OnStackedSideBySideChartsBoundDataChanged;
            chartFullStackedBar3D.DataSource = DevAV.GetSalesMixByRegion();
            chartFullStackedBar3DSideBySide.DataSource = AgeStructureDataReader.GetDataByAgeAndGender();
            chartFullStackedBar3DSideBySide.BoundDataChanged += OnStackedSideBySideChartsBoundDataChanged;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentManager.View.Controller.Activate(documentBar3D);
        }
        protected override void UpdateControlsCore() {
            base.UpdateControlsCore();
            if(IsSideBySideStackSeriesActive)
                UpdateGroupByOption();
            else
                layoutControlGroupGroupSeriesBy.Visibility = LayoutVisibility.Never;
            UpdateLabelOptions();
            if(!IsSideBySideStackSeriesActive)
                UpdateBarModelFacetOption();
            else {
                layoutControlItem3DModel.Visibility = LayoutVisibility.Never;
                layoutControlItemShowFacet.Visibility = LayoutVisibility.Never;
            }
        }
    }
}
