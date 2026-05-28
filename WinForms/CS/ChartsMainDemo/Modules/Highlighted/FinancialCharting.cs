using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.XtraBars;

namespace DevExpress.XtraCharts.Demos {

    public partial class FinancialChartingDemo : ChartDemoModule {
        const int InitialPointCountOnScreen = 90;

        readonly RealTimeFinancialDataGenerator dataGenerator;
        readonly object selectedObject = null;
        DefaultBoolean crosshairEnabled;

        XYDiagram XYDiagram {
            get { return (XYDiagram)chart.Diagram; }
        }
        AxisY AxisY {
            get { return XYDiagram.AxisY; }
        }
        Series PriceSeries {
            get { return chart.Series["Price"]; }
        }
        Series VolumeSeries {
            get { return chart.Series["Volume"]; }
        }
        BarSeriesView VolumeSeriesView {
            get { return (BarSeriesView)VolumeSeries.View; }
        }
        bool IsToolbarInteractionEnabled {
            get { return trendLineBarCheckItem.Checked || fibbArcBarCheckItem.Checked || fibbFansBarCheckItem.Checked || fibbRetrBarCheckItem.Checked || removeBarCheckItem.Checked || addTextAnnotationBarItem.Checked || addImageAnnotationBarItem.Checked; }
        }

        internal override bool PaletteButtonEnabled {
            get { return false; }
        }
        internal override object ExportedObject {
            get { return null; }
        }
        internal override bool ChartDesignerEnabled {
            get { return false; }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public FinancialChartingDemo() {
            InitializeComponent();
            AutoMergeRibbon = true;
            ChartControl.BeginInit();
            dataGenerator = new RealTimeFinancialDataGenerator();
            dataGenerator.GenerateInitialData();
            InitChartControl();
            ChartControl.EndInit();
            dataGenerator.Start();
            timer.Enabled = true;
        }

        void InitChartControl() {
            ChartControl.DataSource = dataGenerator.DataSource;
            SetCustomLabelColor();
            selectAxisMeasureUnitBarItem1.EditValue = selectAxisMeasureUnitRepositoryItemComboBox1.Items[1];
            selectperiodBarItem1.EditValue = selectPeriodRepositoryItemComboBox1.Items[1];
            changeSeriesViewBarItem1.EditValue = changeSeriesViewRepositoryItemComboBox1.Items[1];
        }
        void SetCustomLabelColor() {
            AxisY.CustomLabels[0].BackColor = ChartControl.GetPaletteEntries(2)[1].Color;
        }
        void timer_Tick(object sender, EventArgs e) {
            if(dataGenerator != null)
                dataGenerator.UpdateDataSource();
            CustomAxisLabel currentValueLabel = AxisY.CustomLabels[0];
            if(PriceSeries.Points.Count > 0) {
                FinancialDataCollection dataSource = dataGenerator.DataSource;
                double currentClose = dataSource[dataSource.Count - 1].Close;
                currentValueLabel.AxisValue = currentClose;
                currentValueLabel.Name = string.Format("{0:0.0000}", currentClose);
            }
        }
        void chart_Zoom(object sender, ChartZoomEventArgs e) {
            double rangeLengthInMeasureUnits = e.NewXRange.Max - e.NewXRange.Min;
            if(rangeLengthInMeasureUnits > 1.2 * InitialPointCountOnScreen)
                VolumeSeriesView.BarWidth = 1;
            else
                VolumeSeriesView.BarWidth = 0.6;
        }
        void chart_BoundDataChanged(object sender, EventArgs e) {
            ChartControl.SetObjectSelection(selectedObject);
            crosshairEnabled = ChartControl.CrosshairEnabled;
        }
        void chart_MouseUp(object sender, MouseEventArgs e) {
            if(IsToolbarInteractionEnabled)
                ChartControl.CrosshairEnabled = crosshairEnabled;
        }
        void chartCommandBarCheckItem_CheckedChanged(object sender, ItemClickEventArgs e) {
            bool isChecked = IsToolbarInteractionEnabled;
            timer.Enabled = !isChecked;
            ChartControl.CrosshairEnabled = IsToolbarInteractionEnabled ? DefaultBoolean.False : crosshairEnabled;
        }
        void BeforePopup(object sender, EventArgs e) {
            timer.Enabled = false;
        }
        void CloseUp(object sender, EventArgs e) {
            if(!IsToolbarInteractionEnabled)
                timer.Enabled = true;
        }
        protected override void OnPaletteChanged() {
            base.OnPaletteChanged();
            SetCustomLabelColor();
        }
        protected override void AllowExport() {
            EnabledPrintExportActions(true, ExportFormats.None, false);
        }
        protected override void Dispose(bool disposing) {
            if(disposing && components != null && dataGenerator != null) {
                dataGenerator.Stop();
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
