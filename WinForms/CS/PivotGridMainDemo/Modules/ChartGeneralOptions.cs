using System;
using DevExpress.XtraCharts;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class ChartGeneralOptions : DevExpress.XtraPivotGrid.Demos.TutorialControl {
        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl; } }

        public ChartGeneralOptions() {
            CreateWaitDialog();
            InitializeComponent();

            pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = ceChartDataVertical.Checked;
            pivotGridControl.OptionsChartDataSource.SelectionOnly = ceSelectionOnly.Checked;
            pivotGridControl.OptionsChartDataSource.ProvideColumnGrandTotals = ceShowColumnGrandTotals.Checked;
            pivotGridControl.OptionsChartDataSource.ProvideRowGrandTotals = ceShowRowGrandTotals.Checked;
            chartControl.CrosshairOptions.ShowArgumentLine = false;

            ViewType[] viewTypes = new ViewType[] {
                ViewType.Bar,
                ViewType.StackedBar,
                ViewType.Waterfall,
                ViewType.FullStackedBar,
                ViewType.Point,
                ViewType.Line,
                ViewType.StepLine,
                ViewType.Area,
                ViewType.Pie,
                ViewType.Doughnut,
                ViewType.Funnel,
                ViewType.RadarPoint,
                ViewType.RadarLine
            };
            comboChartType.Properties.Items.AddRange(viewTypes);
            comboChartType.SelectedItem = ViewType.Bar;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            pivotGridControl.DataSource = GetNWindData("SalesPerson");
            SetFilter();
            SetSelection();
            chartControl.DataSource = pivotGridControl;
        }
        void SetFilter() {
            fieldProductName.FilterValues.SetValues(new object[] {
                "Chai",
                "Chang",
                "Chocolade",
                "Filo Mix",
                "Geitost",
                "Ikura",
                "Konbu",
                "Maxilaku",
                "Pavlova",
                "Spegesild",
                "Tourtiere"
            }, PivotFilterType.Included, false);
            fieldOrderYear.FilterValues.SetValues(new object[] { 2015 }, PivotFilterType.Included, false);
        }
        void SetSelection() {
            pivotGridControl.Cells.SetSelectionByFieldValues(false, new object[] { "Chocolade" });
            pivotGridControl.Cells.SetSelectionByFieldValues(false, new object[] { "Chai" });
        }

        //<comboChartType>
        void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e) {
            ViewType viewType = (ViewType)comboChartType.SelectedItem;
            chartControl.SeriesTemplate.ChangeView(viewType);
            if(chartControl.SeriesTemplate.Label != null) {
                chartControl.SeriesTemplate.LabelsVisibility = checkShowPointLabels.Checked ?
                    DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
                chartControl.CrosshairEnabled = checkShowPointLabels.Checked ?
                    DevExpress.Utils.DefaultBoolean.False : DevExpress.Utils.DefaultBoolean.True;
                checkShowPointLabels.Enabled = true;
            } else {
                checkShowPointLabels.Enabled = false;
            }

            SeriesViewBase view = chartControl.SeriesTemplate.View;
            if(view as SimpleDiagramSeriesViewBase == null)
                chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            if(view as FunnelSeriesView != null)
                ((FunnelSeriesView)view).ColorEach = true;
            else if(view as SeriesViewColorEachSupportBase != null)
                ((SeriesViewColorEachSupportBase)view).ColorEach = false;
            else if(view as RadarSeriesViewBase != null)
                ((RadarSeriesViewBase)view).ColorEach = false;
            else if(view as SeriesView3DColorEachSupportBase != null)
                ((SeriesView3DColorEachSupportBase)view).ColorEach = false;
            if(chartControl.Diagram is Diagram3D) {
                Diagram3D diagram = (Diagram3D)chartControl.Diagram;
                diagram.RuntimeRotation = true;
                diagram.RuntimeZooming = true;
                diagram.RuntimeScrolling = true;
            }
            foreach(Series series in chartControl.Series) 
                UpdateSeriesTransparency(series.View);
            UpdateSeriesTransparency(view);
            UpdateAxisYLabels(viewType);
        }

        private void UpdateAxisYLabels(ViewType viewType) {
            string textPattern = viewType == ViewType.FullStackedBar ? "{VP:P0}" : "{V:C2}";
            XYDiagram xyDiagram = chartControl.Diagram as XYDiagram;
            if(chartControl.Diagram is XYDiagram)
                (chartControl.Diagram as XYDiagram).AxisY.Label.TextPattern = textPattern;
            else if(chartControl.Diagram is XYDiagram3D)
                (chartControl.Diagram as XYDiagram3D).AxisY.Label.TextPattern = textPattern;
        }

        void UpdateSeriesTransparency(SeriesViewBase seriesView) {
            ISupportTransparency supportTransparency = seriesView as ISupportTransparency;
            if (supportTransparency != null) {
                if ((seriesView is AreaSeriesView) || (seriesView is Area3DSeriesView)
                    || (seriesView is RadarAreaSeriesView) || (seriesView is Bar3DSeriesView))
                    supportTransparency.Transparency = 135;
                else
                    supportTransparency.Transparency = 0;
            }
        }
        //</comboChartType>

        //<checkShowPointLabels>
        void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            chartControl.SeriesTemplate.LabelsVisibility = checkShowPointLabels.Checked ?
                DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
            chartControl.CrosshairEnabled = checkShowPointLabels.Checked ?
                DevExpress.Utils.DefaultBoolean.False : DevExpress.Utils.DefaultBoolean.True;
        }
        //</checkShowPointLabels>

        //<ceChartDataVertical>
        void ceChartDataVertical_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = ceChartDataVertical.Checked;
        }
        //</ceChartDataVertical>
        //<ceSelectionOnly>
        void ceSelectionOnly_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl.OptionsChartDataSource.SelectionOnly = ceSelectionOnly.Checked;
            seUpdateDelay.Enabled = ceSelectionOnly.Checked;
        }
        //</ceSelectionOnly>
        //<ceShowColumnGrandTotals>
        void ceShowColumnGrandTotals_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl.OptionsChartDataSource.ProvideColumnGrandTotals = ceShowColumnGrandTotals.Checked;
        }
        //</ceShowColumnGrandTotals>

        //<ceShowRowGrandTotals>
        void ceShowRowGrandTotals_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl.OptionsChartDataSource.ProvideRowGrandTotals = ceShowRowGrandTotals.Checked;
        }
        //</ceShowRowGrandTotals>

        //<seUpdateDelay>
        void seUpdateDelay_EditValueChanged(object sender, EventArgs e) {
            pivotGridControl.OptionsChartDataSource.UpdateDelay = (int)seUpdateDelay.Value;
        }
        //</seUpdateDelay>
    }
}
