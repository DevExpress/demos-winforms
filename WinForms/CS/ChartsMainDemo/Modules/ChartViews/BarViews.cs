using System;
using System.Collections.Generic;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class BarViewsDemo : ChartDemoModuleLabelViews {
        bool IsSideBySideStackedSeriesActive {
            get {
                SeriesViewBase view = ActiveSeries.View;
                return view is SideBySideStackedBarSeriesView || view is SideBySideFullStackedBarSeriesView;
            }
        }
        bool IsFullStackedSeriesActive {
            get {
                SeriesViewBase view = ActiveSeries.View;
                return view is FullStackedBarSeriesView || view is SideBySideFullStackedBarSeriesView;
            }
        }
        bool IsStackedOrFullStackedSeriesActive {
            get {
                return IsSideBySideStackedSeriesActive
                    || IsFullStackedSeriesActive
                    || ActiveSeries.View is StackedBarSeriesView;
            }
        }
        bool IsSideBySideBarSeriesActive { get { return ActiveSeries.View is SideBySideBarSeriesView; } }
        bool IsRangeBarSeriesActive { get { return ActiveSeries.View is RangeBarSeriesView; } }

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
                return new List<ChartControl>() { chartBar, chartStackedBar, chartFullStackedBar, chartFullStackedBarSideBySide, chartStackedBarSideBySide, chartRangeBar, chartRangeBarSideBySide };
            }
        }

        public BarViewsDemo() {
            InitializeComponent();
        }

        void tabbedView_DocumentActivated(object sender, DocumentEventArgs e) {
            OnDocumentActivated(e.Document);
        }
        void comboBoxEditGroupSeriesBy_SelectedIndexChanged(object sender, EventArgs e) {
            ChartControl.RefreshData();
        }
        void checkEditDiagramRotated_CheckedChanged(object sender, EventArgs e) {
            XYDiagram diagram = ChartControl.Diagram as XYDiagram;
            diagram.Rotated = checkEditDiagramRotated.Checked;
        }
        void checkEditLabelVisible_CheckedChanged(object sender, EventArgs e) {
            SetLabelVisibility(layoutControlItemValueAsPercent, layoutControlItemIndent,
                               layoutControlItemOrientation, layoutControlItemPosition,
                               layoutControlItemRangeBarLabelPosition);
            if(IsRangeBarSeriesActive)
                UpdateRangeBarLabelIndent((RangeBarSeriesLabel)ActiveSeries.Label);
            else
                UpdateLabelIndent((BarSeriesLabel)ActiveSeries.Label);
        }
        void comboBoxEditLabelPosition_EditValueChanged(object sender, EventArgs e) {
            BarSeriesLabel label = ChartControl.SeriesTemplate.Label as BarSeriesLabel;
            if(label != null && comboBoxEditLabelPosition.SelectedItem != null) {
                BarLabelPositionItem item = comboBoxEditLabelPosition.SelectedItem as BarLabelPositionItem;
                if(item == null)
                    return;
                label.Position = item.Position;
                UpdateLabelIndent(label);
            }
        }
        void comboBoxEditRangeBarLabelPosition_SelectedIndexChanged(object sender, EventArgs e) {
            RangeBarLabelPosition position = (RangeBarLabelPosition)comboBoxEditRangeBarLabelPosition.SelectedIndex;
            foreach(Series series in ChartControl.Series) {
                RangeBarSeriesLabel label = (RangeBarSeriesLabel)series.Label;
                label.Position = position;
                UpdateRangeBarLabelIndent(label);
            }
        }
        void comboBoxEditLabelOrientation_SelectedIndexChanged(object sender, EventArgs e) {
            ChartControl.SeriesTemplate.Label.TextOrientation = (TextOrientation)comboBoxEditLabelOrientation.SelectedIndex;
        }
        void spinEditLabelIndent_EditValueChanged(object sender, EventArgs e) {
            BarSeriesLabel label = ChartControl.SeriesTemplate.Label as BarSeriesLabel;
            if(label != null) {
                label.Indent = (int)spinEditLabelIndent.Value;
                return;
            }
            if(IsRangeBarSeriesActive)
                foreach(Series series in ChartControl.Series)
                    ((RangeBarSeriesLabel)series.Label).Indent = (int)spinEditLabelIndent.Value;
        }
        void comboBoxEditTotalLabelVisible_CheckedChanged(object sender, EventArgs e) {
            XYDiagram xyDiagram = ChartControl.Diagram as XYDiagram;
            if(xyDiagram != null) {
                StackedBarTotalLabel label = xyDiagram.DefaultPane.StackedBarTotalLabel;
                label.Visible = comboBoxEditTotalLabelVisible.Checked;
            }
        }

        void chartStackedBarSideBySide_BoundDataChanged(object sender, EventArgs e) {
            if(ChartControl == null)
                return;
            DefaultBoolean labelVisibility = checkEditLabelVisible.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            StackGroupHelper.ApplyStackedGroup(ChartControl.Series, labelVisibility, comboBoxEditGroupSeriesBy.SelectedIndex, false);
        }
        void chartFullStackedBarSideBySide_BoundDataChanged(object sender, EventArgs e) {
            if(ChartControl == null)
                return;
            DefaultBoolean labelVisibility = checkEditLabelVisible.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            StackGroupHelper.ApplyStackedGroup(ChartControl.Series, labelVisibility, comboBoxEditGroupSeriesBy.SelectedIndex, true);
        }
        void OnRangeBarCustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e) {
            if(e.CrosshairElementGroups.Count > 0 && e.CrosshairElementGroups[0].CrosshairElements.Count > 0) {
                ChartHitInfo chi = ChartControl.CalcHitInfo(ChartControl.PointToClient(MousePosition));
                if(chi.InSeries) {
                    foreach(CrosshairElement element in e.CrosshairElementGroups[0].CrosshairElements)
                        element.Visible = chi.Series.Equals(element.Series);
                }
                else {
                    foreach(CrosshairElement element in e.CrosshairElementGroups[0].CrosshairElements)
                        element.Visible = false;
                }
            }
        }
        bool IsBottomOrTopInsidePosition(BarSeriesLabelPosition position) {
            return position.Equals(BarSeriesLabelPosition.TopInside) || position.Equals(BarSeriesLabelPosition.BottomInside);
        }
        void UpdateGroupByOption() {
            if(IsSideBySideStackedSeriesActive) {
                layoutControlItemGroupSeriesBy.Visibility = LayoutVisibility.Always;
                if(ActiveSeries.Tag is GenderAgeInfo) {
                    GenderAgeInfo genderAge = (GenderAgeInfo)ActiveSeries.Tag;
                    comboBoxEditGroupSeriesBy.SelectedIndex = ((ISupportStackedGroup)ActiveSeries.View).StackedGroup.ToString() == genderAge.Age ? 1 : 0;
                }
            }
            else
                layoutControlItemGroupSeriesBy.Visibility = LayoutVisibility.Never;
        }
        void UpdateTotalLabelAndRotatedOptions() {
            XYDiagram xyDiagram = ChartControl.Diagram as XYDiagram;
            if(xyDiagram != null) {
                checkEditDiagramRotated.Checked = xyDiagram.Rotated;
                if(IsStackedOrFullStackedSeriesActive) {
                    layoutControlGroupTotalLabels.Visibility = LayoutVisibility.Always;
                    StackedBarTotalLabel totalLabel = xyDiagram.DefaultPane.StackedBarTotalLabel;
                    comboBoxEditTotalLabelVisible.Checked = totalLabel.Visible;
                }
                else
                    layoutControlGroupTotalLabels.Visibility = LayoutVisibility.Never;
            }
        }
        void UpdateLabelOptions() {
            checkEditLabelVisible.Checked = ActiveSeries.LabelsVisibility.Equals(DefaultBoolean.True);
            if(IsRangeBarSeriesActive) {
                layoutControlItemOrientation.Visibility = LayoutVisibility.Never;
                layoutControlItemPosition.Visibility = LayoutVisibility.Never;
                layoutControlItemValueAsPercent.Visibility = LayoutVisibility.Never;
                layoutControlItemRangeBarLabelPosition.Visibility = LayoutVisibility.Always;
                RangeBarSeriesLabel rangeBarLabel = (RangeBarSeriesLabel)ActiveSeries.Label;
                comboBoxEditRangeBarLabelPosition.SelectedIndex = (int)rangeBarLabel.Position;
                UpdateRangeBarLabelIndent(rangeBarLabel);
            }
            else {
                BarSeriesLabel label = ActiveSeries.Label as BarSeriesLabel;
                if(label != null) {
                    layoutControlItemOrientation.Visibility = LayoutVisibility.Always;
                    layoutControlItemPosition.Visibility = LayoutVisibility.Always;
                    layoutControlItemRangeBarLabelPosition.Visibility = LayoutVisibility.Never;
                    layoutControlItemValueAsPercent.Visibility = IsFullStackedSeriesActive ? LayoutVisibility.Always : LayoutVisibility.Never;
                    comboBoxEditLabelPosition.Properties.Items.Clear();
                    List<BarLabelPositionItem> items = IsSideBySideBarSeriesActive ? BarLabelPositionItem.AllPositions : BarLabelPositionItem.StackedPositions;
                    comboBoxEditLabelPosition.Properties.Items.AddRange(items);
                    comboBoxEditLabelPosition.SelectedItem = BarLabelPositionItem.GetItemByPosition(label.Position);
                    UpdateLabelIndent(label);
                    comboBoxEditLabelOrientation.SelectedIndex = (int)label.TextOrientation;
                    checkEditValueAsPercent.Checked = label.TextPattern == PercentPattern;
                }
            }
        }
        void UpdateLabelIndent(BarSeriesLabel label) {
            bool isBottomOrTopInsidePosition = IsBottomOrTopInsidePosition(label.Position);
            layoutControlItemIndent.Enabled = isBottomOrTopInsidePosition && checkEditLabelVisible.Checked;
            if(isBottomOrTopInsidePosition)
                spinEditLabelIndent.Value = label.Indent;
        }
        void UpdateRangeBarLabelIndent(RangeBarSeriesLabel rangeBarSeriesLabel) {
            bool isCenterPosition = rangeBarSeriesLabel.Position.Equals(RangeBarLabelPosition.Center);
            layoutControlItemIndent.Enabled = !isCenterPosition && checkEditLabelVisible.Checked;
            if(!isCenterPosition)
                spinEditLabelIndent.Value = rangeBarSeriesLabel.Indent;
        }
        protected override void SetDataSources() {
            chartBar.DataSource = DevAV.GetSales();
            chartStackedBar.DataSource = AgeStructureDataReader.GetDataByMaleAge();
            chartFullStackedBar.DataSource = DevAV.GetSalesMixByRegion();
            chartFullStackedBarSideBySide.DataSource = AgeStructureDataReader.GetDataByAgeAndGender();
            chartStackedBarSideBySide.DataSource = AgeStructureDataReader.GetDataByAgeAndGender();
            chartRangeBar.Series[0].DataSource = SourceOfEnergy.GetEuropeBrentPrices();
            chartRangeBar.Series[1].DataSource = SourceOfEnergy.GetOkWtiPrices();
            chartRangeBarSideBySide.Series[0].DataSource = SourceOfEnergy.GetEuropeBrentPrices();
            chartRangeBarSideBySide.Series[1].DataSource = SourceOfEnergy.GetOkWtiPrices();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentManager.View.Controller.Activate(documentBar);
        }
        protected override void UpdateControlsCore() {
            base.UpdateControlsCore();
            UpdateGroupByOption();
            UpdateTotalLabelAndRotatedOptions();
            UpdateLabelOptions();
            sidePanelOptions.Visible = true;
        }
    }


    class BarLabelPositionItem {
        static readonly BarLabelPositionItem topInsidePositionList = new BarLabelPositionItem(BarSeriesLabelPosition.TopInside, "Top Inside");
        static readonly BarLabelPositionItem centerPositionList = new BarLabelPositionItem(BarSeriesLabelPosition.Center, "Center");
        static readonly BarLabelPositionItem bottomInsidePositionList = new BarLabelPositionItem(BarSeriesLabelPosition.BottomInside, "Bottom Inside");
        static readonly List<BarLabelPositionItem> stackedPositionsList = new List<BarLabelPositionItem>() {
                topInsidePositionList,
                centerPositionList,
                bottomInsidePositionList
            };
        static readonly List<BarLabelPositionItem> allPositionsList = new List<BarLabelPositionItem>() {
            new BarLabelPositionItem(BarSeriesLabelPosition.Auto, "Auto"),
            new BarLabelPositionItem(BarSeriesLabelPosition.Top, "Top"),
            topInsidePositionList,
            centerPositionList,
            bottomInsidePositionList
        };

        public static List<BarLabelPositionItem> StackedPositions { get { return stackedPositionsList; } }
        public static List<BarLabelPositionItem> AllPositions { get { return allPositionsList; } }

        public static BarLabelPositionItem GetItemByPosition(BarSeriesLabelPosition position) {
            foreach(BarLabelPositionItem item in AllPositions)
                if(item.Position.Equals(position))
                    return item;
            return null;
        }

        public BarSeriesLabelPosition Position {
            get;
            private set;
        }
        public string Name {
            get;
            private set;
        }

        public BarLabelPositionItem(BarSeriesLabelPosition labelPosition, string labelName) {
            Position = labelPosition;
            Name = labelName;
        }
        public override string ToString() {
            return Name;
        }
    }
}
