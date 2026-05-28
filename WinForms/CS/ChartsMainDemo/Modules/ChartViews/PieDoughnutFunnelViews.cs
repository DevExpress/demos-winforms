using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class PieDoughnutFunnelViewsDemo : ChartDemoModuleLabelViews {
        readonly string[] pieLabelPosition = new string[] { "Inside", "Outside", "Two Columns", "Radial" };
        readonly string[] funnelLabelPosition = new string[] { "Left Column", "Left", "Center", "Right", "Right Column" };
        readonly CustomLegendItem[] ageLegendItems = new CustomLegendItem[3];
        readonly CustomLegendItem[] genderLegendItems = new CustomLegendItem[2];

        bool IsDoughnutActive {
            get { return ActiveSeries.View is DoughnutSeriesView; }
        }
        bool IsNestedDoughnutActive {
            get { return ActiveSeries.View is NestedDoughnutSeriesView; }
        }
        bool IsFunnelSeriesActive {
            get { return ActiveSeries.View is FunnelSeriesView; }
        }

        protected override DefaultBoolean ToolTipEnabled {
            get { return DefaultBoolean.True; }
        }
        protected override LayoutControl OptionsLayoutControl {
            get { return layoutControl; }
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
                    chartPie,
                    chartDoughnut,
                    chartNestedDoughnut,
                    chartFunnel
                };
            }
        }

        public PieDoughnutFunnelViewsDemo() {
            InitializeComponent();
            UpdateNestedDonutLegendsBackColor();
            SplitNestedDonutLegendItems();
        }

        void tabbedView_DocumentActivated(object sender, DocumentEventArgs e) {
            OnDocumentActivated(e.Document);
        }
        void chartNestedDoughnut_BoundDataChanged(object sender, EventArgs e) {
            if(chartNestedDoughnut.Series.Count > 0) {
                chartNestedDoughnut.Series[0].ShowInLegend = true;
                foreach(Series series in chartNestedDoughnut.Series) {
                    NestedDoughnutSeriesView nestedView = series.View as NestedDoughnutSeriesView;
                    AgePopulation population = series.Points[0].Tag as AgePopulation;
                    if(population != null && nestedView != null) {
                        string name = population.Name;
                        nestedView.Group = name;
                        nestedView.Titles.Clear();
                        nestedView.Titles.Add(new SeriesTitle() { Text = name });
                    }
                }
            }
        }
        void OnChartPieSeriesPointExploded(object sender, PieSeriesPointExplodedEventArgs e) {
            if(e.Dragged)
                comboBoxEditExplodedPoints.Text = PieExplodingHelper.Custom;
        }
        void checkEditLabelVisible_CheckedChanged(object sender, EventArgs e) {
            SetLabelVisibility(layoutControlItemPosition, layoutControlItemValueAsPercent);
        }
        void spinEditInnerIndent_EditValueChanged(object sender, EventArgs e) {
            NestedDoughnutSeriesView view = ChartControl.SeriesTemplate.View as NestedDoughnutSeriesView;
            if(view != null)
                view.InnerIndent = Convert.ToDouble(spinEditInnerIndent.EditValue);
        }
        void comboBoxEditExplodedPoints_SelectedIndexChanged(object sender, EventArgs e) {
            PieSeriesView view = ActiveSeries.View as PieSeriesView;
            if(view != null) {
                string mode = (string)comboBoxEditExplodedPoints.SelectedItem;
                PieExplodingHelper.ApplyMode(view, mode);
            }
        }
        void comboBoxEditGroupSeriesBy_SelectedIndexChanged(object sender, EventArgs e) {
            ChartControl.BeginInit();
            try {
                if(comboBoxEditGroupSeriesBy.SelectedIndex == 0)
                    GroupByGender();
                else
                    GroupByAge();
            }
            finally {
                ChartControl.EndInit();
            }
        }
        void comboBoxEditLabelPosition_SelectedIndexChanged(object sender, EventArgs e) {
            PieSeriesLabel pieLabel = ActiveSeries.Label as PieSeriesLabel;
            if(pieLabel != null) {
                pieLabel.Position = (PieSeriesLabelPosition)comboBoxEditLabelPosition.SelectedIndex;
                pieLabel.TextColor = (pieLabel.Position.Equals(PieSeriesLabelPosition.Outside) || pieLabel.Position.Equals(PieSeriesLabelPosition.TwoColumns)) ? Color.Empty : Color.Black;
                return;
            }
            FunnelSeriesLabel funnelLabel = ActiveSeries.Label as FunnelSeriesLabel;
            if(funnelLabel != null)
                funnelLabel.Position = (FunnelSeriesLabelPosition)comboBoxEditLabelPosition.SelectedIndex;
        }
        void spinEditTotalLabelVisible_CheckedChanged(object sender, EventArgs e) {
            PieSeriesView view = ActiveSeries.View as PieSeriesView;
            if(view != null)
                view.TotalLabel.Visible = checkEditTotalLabelVisible.Checked;
        }
        void checkEditAlignToCenter_CheckedChanged(object sender, EventArgs e) {
            FunnelSeriesView view = ActiveSeries.View as FunnelSeriesView;
            if(view != null)
                view.AlignToCenter = checkEditAlignToCenter.Checked;
        }
        void checkEditAutoHeightToWidthRatio_CheckedChanged(object sender, EventArgs e) {
            FunnelSeriesView view = ActiveSeries.View as FunnelSeriesView;
            if(view != null) {
                view.HeightToWidthRatioAuto = checkEditAutoHeightToWidthRatio.Checked;
                comboBoxEditHeightToWidthRatio.Enabled = !checkEditAutoHeightToWidthRatio.Checked;
            }
        }
        void comboBoxEditHeightToWidthRatio_SelectedIndexChanged(object sender, EventArgs e) {
            FunnelSeriesView view = ActiveSeries.View as FunnelSeriesView;
            if(view != null)
                view.HeightToWidthRatio = Convert.ToDouble(comboBoxEditHeightToWidthRatio.SelectedItem);
        }
        void spinEditPointDistance_EditValueChanged(object sender, EventArgs e) {
            FunnelSeriesView view = ActiveSeries.View as FunnelSeriesView;
            if(view != null)
                view.PointDistance = Convert.ToInt32(spinEditPointDistance.Value);
        }
        void OnSpinEditHoleRadiusEditValueChanged(object sender, EventArgs e) {
            SpinEdit spinEdit = sender as SpinEdit;
            if(spinEdit == null)
                return;
            int holeRadius = Convert.ToInt32(spinEdit.EditValue);
            ApplySettingsToSeriesView((view) => {
                DoughnutSeriesView doughnutView = view as DoughnutSeriesView;
                if(doughnutView != null)
                    doughnutView.HoleRadiusPercent = holeRadius;
            });
        }
        void GroupByAge() {
            ChartControl.SeriesDataMember = "CountryAgeKey";
            string argumentDataMember = "Gender";
            ChartControl.Titles[0].Text = "Population: " + argumentDataMember + " Structure";
            ChartControl.SeriesTemplate.ToolTipHintDataMember = "Age";
            ChartControl.SeriesTemplate.ArgumentDataMember = argumentDataMember;
            UpdateNestedDonutLegendItems(ageLegendItems);
        }
        void GroupByGender() {
            ChartControl.SeriesDataMember = "CountryGenderKey";
            string argumentDataMember = "Age";
            ChartControl.Titles[0].Text = "Population: " + argumentDataMember + " Structure";
            ChartControl.SeriesTemplate.ToolTipHintDataMember = "Gender";
            ChartControl.SeriesTemplate.ArgumentDataMember = argumentDataMember;
            UpdateNestedDonutLegendItems(genderLegendItems);
        }
        void UpdateNestedDonutLegendItems(CustomLegendItem[] items) {
            if(chartNestedDoughnut.Legends.Count < 1)
                return;
            CustomLegendItemCollection collection = chartNestedDoughnut.Legends[0].CustomItems;
            collection.Clear();
            collection.AddRange(items);
        }
        void UpdatePieAndDoughnutOptions() {
            layoutControlOptionsGroup.Visibility = LayoutVisibility.Always;
            layoutControlItemExplodedPoints.Visibility = LayoutVisibility.Always;

            UpdateExplodePointsCBE();
            comboBoxEditLabelPosition.Properties.Items.AddRange(pieLabelPosition);
            PieSeriesLabel pieLabel = ActiveSeries.Label as PieSeriesLabel;
            if(pieLabel != null)
                comboBoxEditLabelPosition.SelectedIndex = (int)pieLabel.Position;
            checkEditTotalLabelVisible.Checked = ((PieSeriesView)ActiveSeries.View).TotalLabel.Visible;
        }
        void UpdateNestedDoughnutOptions() {
            layoutControlOptionsGroup.Visibility = LayoutVisibility.Never;
            layoutControlItemExplodedPoints.Visibility = LayoutVisibility.Never;

            spinEditInnerIndent.EditValue = ((NestedDoughnutSeriesView)ActiveSeries.View).InnerIndent;
            comboBoxEditGroupSeriesBy.SelectedIndex = ChartControl.SeriesTemplate.ArgumentDataMember == "Age" ? 0 : 1;
            spinEditNestedDoughnutHoleRadius.EditValue = ((DoughnutSeriesView)ActiveSeries.View).HoleRadiusPercent;
        }
        void UpdateExplodePointsCBE() {
            int explodeSelectedIndex = -1;
            PieSeriesView view = (PieSeriesView)ActiveSeries.View;
            switch(view.ExplodeMode) {
                case PieExplodeMode.Others:
                case PieExplodeMode.UsePoints:
                    break;
                case PieExplodeMode.UseFilters:
                    object filterValue = view.ExplodedPointsFilters[0].Value;
                    explodeSelectedIndex = comboBoxEditExplodedPoints.Properties.Items.IndexOf(filterValue);
                    break;
                default:
                    explodeSelectedIndex = (int)view.ExplodeMode;
                    break;
            }
            comboBoxEditExplodedPoints.SelectedIndex = explodeSelectedIndex;
        }
        void UpdateFunnelOptions() {
            layoutControlOptionsGroup.Visibility = LayoutVisibility.Always;
            layoutControlGroupFunnelGeneral.Visibility = LayoutVisibility.Always;
            layoutControlItemTotalLabelVisible.Visibility = LayoutVisibility.Never;
            comboBoxEditLabelPosition.Properties.Items.AddRange(funnelLabelPosition);
            FunnelSeriesView view = (FunnelSeriesView)ActiveSeries.View;
            checkEditAutoHeightToWidthRatio.Checked = view.HeightToWidthRatioAuto;
            comboBoxEditHeightToWidthRatio.EditValue = view.HeightToWidthRatio;
            spinEditPointDistance.Value = view.PointDistance;
            checkEditAlignToCenter.Checked = view.AlignToCenter;
            comboBoxEditLabelPosition.SelectedIndex = (int)((FunnelSeriesLabel)ActiveSeries.Label).Position;
        }
        void UpdateNestedDonutLegendsBackColor() {
            Color chartBackColor = ColorUtils.GetChartBackground(ChartControl.LookAndFeel);
            chartNestedDoughnut.Legend.BackColor = chartBackColor;
            if(chartNestedDoughnut.Legends.Count > 0)
                chartNestedDoughnut.Legends[0].BackColor = chartBackColor;
        }
        void SplitNestedDonutLegendItems() {
            CustomLegendItemCollection items = chartNestedDoughnut.Legends[0].CustomItems;
            int ageItemsCount = ageLegendItems.Length;
            for(int i = 0; i < items.Count; i++)
                if(i < ageItemsCount)
                    ageLegendItems[i] = items[i];
                else
                    genderLegendItems[i - ageItemsCount] = items[i];
            UpdateNestedDonutLegendItems(genderLegendItems);
        }

        protected override void InitControls() {
            base.InitControls();
            comboBoxEditLabelPosition.SelectedIndex = 2;
            comboBoxEditLabelPosition.SelectedIndexChanged += comboBoxEditLabelPosition_SelectedIndexChanged;
            comboBoxEditExplodedPoints.Properties.Items.AddRange(PieExplodingHelper.CreateModeList(chartPie.Series[0].Points, false));
            comboBoxEditExplodedPoints.SelectedIndex = 0;
            spinEditPointDistance.EditValueChanged += spinEditPointDistance_EditValueChanged;
            comboBoxEditHeightToWidthRatio.Properties.Items.AddRange(new double[] { 0.1, 0.25, 0.5, 0.75, 1, 2, 4, 6, 8, 10 });
        }
        protected override void SetDataSources() {
            chartNestedDoughnut.DataSource = AgeStructureDataReader.GetPopulationAgeStructure();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentManager.View.Controller.Activate(documentPie);
        }
        protected override void UpdateControlsCore() {
            base.UpdateControlsCore();
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility == DefaultBoolean.True;
            string actualPattern = ActiveSeries.Label.TextPattern;
            checkEditValueAsPercent.Checked = actualPattern == PiePercentPattern || actualPattern == FunnelPercentPattern;
            comboBoxEditLabelPosition.Properties.Items.Clear();
            comboBoxEditLabelPosition.SelectedIndex = -1;
            LayoutVisibility nestedDonutOptionsVisibility = IsNestedDoughnutActive ? LayoutVisibility.Always : LayoutVisibility.Never;
            layoutControlItemInnerIndent.Visibility = nestedDonutOptionsVisibility;
            layoutControlItemGroupSeriesBy.Visibility = nestedDonutOptionsVisibility;
            layoutControlItemNestedDoughnutHoleRadius.Visibility = nestedDonutOptionsVisibility;
            layoutControlGroupPieDoughnutGeneral.Visibility = IsNestedDoughnutActive || IsFunnelSeriesActive ? LayoutVisibility.Never : LayoutVisibility.Always;
            if(IsFunnelSeriesActive)
                UpdateFunnelOptions();
            else {
                layoutControlGroupFunnelGeneral.Visibility = LayoutVisibility.Never;
                layoutControlItemPieDoughnutHoleRadius.Visibility = IsDoughnutActive ? LayoutVisibility.Always : LayoutVisibility.Never;
                if(IsDoughnutActive)
                    spinEditDoughnutHoleRadius.EditValue = ((DoughnutSeriesView)ActiveSeries.View).HoleRadiusPercent;
                layoutControlGroupTotalLabel.Visibility = IsDoughnutActive && !IsNestedDoughnutActive ? LayoutVisibility.Always : LayoutVisibility.Never;
                if(IsNestedDoughnutActive)
                    UpdateNestedDoughnutOptions();
                else
                    UpdatePieAndDoughnutOptions();
            }
        }
        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateNestedDonutLegendsBackColor();
        }
    }
}
