using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class FinancialViewsDemo : ChartDemoModuleLabelViews {
        FinancialSeriesViewBase FinancialView {
            get { return ActiveSeries.View as FinancialSeriesViewBase; }
        }
        StockSeriesView StockView {
            get { return ActiveSeries.View as StockSeriesView; }
        }
        CandleStickSeriesView CandleStickView {
            get { return ActiveSeries.View as CandleStickSeriesView; }
        }

        protected override LayoutControl OptionsLayoutControl {
            get { return layoutControl; }
        }
        protected override CheckEdit LabelVisibleCheckEdit {
            get { return null; }
        }
        protected override TabbedView TabbedView {
            get { return currentTabbedView; }
        }

        internal override bool PaletteButtonEnabled {
            get { return false; }
        }
        internal override List<ChartControl> ChartControls {
            get { return new List<ChartControl>() { chartCandleStick, chartStock }; }
        }

        public FinancialViewsDemo() {
            InitializeComponent();
            ((XYDiagram)chartCandleStick.Diagram).AxisX.VisualRange.SetMinMaxValues(new DateTime(2016, 4, 26), new DateTime(2016, 7, 25));
            ((XYDiagram)chartStock.Diagram).AxisX.VisualRange.SetMinMaxValues(new DateTime(2016, 4, 26), new DateTime(2016, 7, 25));
        }

        void tabbedView_DocumentActivated(object sender, XtraBars.Docking2010.Views.DocumentEventArgs e) {
            OnDocumentActivated(e.Document);
        }
        void comboBoxEditReductionLevel_SelectedIndexChanged(object sender, EventArgs e) {
            if(ActiveSeries == null)
                return;
            if(FinancialView != null)
                FinancialView.ReductionOptions.Level = (StockLevel)comboBoxEditReductionLevel.SelectedIndex;
        }
        void checkEditWorkdaysOnly_CheckedChanged(object sender, EventArgs e) {
            IXYDiagram2D diagram = ChartControl.Diagram as IXYDiagram2D;
            if(diagram != null)
                diagram.AxisX.DateTimeScaleOptions.WorkdaysOnly = checkEditWorkDaysOnly.Checked;
        }
        void comboBoxEditStockType_SelectedIndexChanged(object sender, EventArgs e) {
            if(ActiveSeries == null)
                return;
            if(StockView != null)
                StockView.ShowOpenClose = (StockType)comboBoxEditStockType.SelectedIndex;
        }
        void comboBoxEditReductionColorMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(FinancialView != null) {
                ReductionColorMode colorMode = (ReductionColorMode)comboBoxEditReductionColorMode.SelectedIndex;
                FinancialView.ReductionOptions.ColorMode = colorMode;
                layoutControlItemReductionLevel.Enabled = colorMode.Equals(ReductionColorMode.PreviousToCurrentPoint);
            }
        }
        void colorPickEditReductionColor_EditValueChanged(object sender, EventArgs e) {
            if(FinancialView != null)
                FinancialView.ReductionOptions.Color = (Color)colorPickEditReductionColor.EditValue;
        }
        void colorPickEditBaseColor_EditValueChanged(object sender, EventArgs e) {
            if(FinancialView != null)
                FinancialView.Color = (Color)colorPickEditBaseColor.EditValue;
        }
        void comboBoxEditFillMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(CandleStickView != null) {
                CandleStickView.ReductionOptions.FillMode = (CandleStickFillMode)comboBoxEditFillMode.SelectedIndex;
            }
        }
        void LoadSeriesData(Series series) {
            series.SetFinancialDataMembers("Date", "Low", "High", "Open", "Close");
            series.DataSource = MarketPricesReader.GetGoogleStockPrices();
        }

        protected override void SetDataSources() {
            LoadSeriesData(chartCandleStick.Series[0]);
            LoadSeriesData(chartStock.Series[0]);
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentManager.View.Controller.Activate(documentCandleStick);
        }
        protected override void UpdateControlsCore() {
            base.UpdateControlsCore();
            layoutControlItemStockType.Visibility = StockView != null ? LayoutVisibility.Always : LayoutVisibility.Never;
            layoutControlItemFillMode.Visibility = CandleStickView != null ? LayoutVisibility.Always : LayoutVisibility.Never;
            if(FinancialView != null) {
                ReductionStockOptions reductionStockOptions = FinancialView.ReductionOptions;
                comboBoxEditReductionLevel.SelectedIndex = (int)reductionStockOptions.Level;
                comboBoxEditReductionColorMode.SelectedIndex = (int)reductionStockOptions.ColorMode;
                colorPickEditBaseColor.EditValue = FinancialView.Color;
                colorPickEditReductionColor.EditValue = reductionStockOptions.Color;
            }
            IXYDiagram2D diagram = ChartControl.Diagram as IXYDiagram2D;
            if(diagram != null)
                checkEditWorkDaysOnly.Checked = diagram.AxisX.DateTimeScaleOptions.WorkdaysOnly;
        }
    }
}
