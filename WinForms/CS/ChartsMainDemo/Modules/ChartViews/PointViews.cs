using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using DevExpress.Data.Utils;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class PointViewsDemo : ChartDemoModuleMarkerViews {
        BubbleSeriesView BubbleSeriesView {
            get { return ActiveSeries != null ? ActiveSeries.View as BubbleSeriesView : null; }
        }
        PointSeriesView PointSeriesView {
            get { return ActiveSeries != null ? ActiveSeries.View as PointSeriesView : null; }
        }

        protected override DefaultBoolean ToolTipEnabled {
            get { return BubbleSeriesView != null ? DefaultBoolean.True : DefaultBoolean.False; }
        }
        protected override DefaultBoolean CrosshairEnabled {
            get { return DefaultBoolean.False; }
        }
        protected override LayoutControl OptionsLayoutControl {
            get { return layoutControl; }
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
        protected override int MarkerKindDefaultIndex {
            get { return 0; }
        }
        protected override bool AnimationEnabled {
            get { return BubbleSeriesView != null; }
        }
        protected override TabbedView TabbedView {
            get { return currentTabbedView; }
        }

        internal override List<ChartControl> ChartControls {
            get {
                return new List<ChartControl>() {
                    chartPoint,
                    chartBubble
                };
            }
        }

        public PointViewsDemo() {
            InitializeComponent();
            OnPaletteChanged();
        }
        void tabbedView_DocumentActivated(object sender, DocumentEventArgs e) {
            OnDocumentActivated(e.Document);
        }
        void chartBubble_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LegendText = ((BubbleDataItem)e.SeriesPoint.Tag).Title;
        }
        void checkEditLabelVisible_CheckedChanged(object sender, EventArgs e) {
            SetLabelVisibility(ActiveSeries, layoutControlItemPosition);
        }
        void comboBoxEditLabelPosition_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboBoxEditLabelPosition.SelectedIndex >= 0 && BubbleSeriesView != null) {
                BubbleSeriesLabel label = ActiveSeries.Label as BubbleSeriesLabel;
                if(label != null)
                    label.Position = (PointLabelPosition)comboBoxEditLabelPosition.SelectedIndex;
            }
        }
        void spinEditMaxBubbleSize_EditValueChanging(object sender, ChangingEventArgs e) {
            if(BubbleSeriesView != null)
                if(Convert.ToDouble(e.NewValue, CultureInfo.InvariantCulture) <= BubbleSeriesView.MinSize)
                    e.Cancel = true;
        }
        void spinEditMinBubbleSize_EditValueChanging(object sender, ChangingEventArgs e) {
            if(BubbleSeriesView != null)
                if(Convert.ToDouble(e.NewValue, CultureInfo.InvariantCulture) >= BubbleSeriesView.MaxSize)
                    e.Cancel = true;
        }
        void spinEditMinBubbleSize_EditValueChanged(object sender, EventArgs e) {
            if(BubbleSeriesView == null)
                return;
            BubbleSeriesView.MinSize = Convert.ToDouble(spinEditMinBubbleSize.Value);
        }
        void spinEditMaxBubbleSize_EditValueChanged(object sender, EventArgs e) {
            if(BubbleSeriesView == null)
                return;
            BubbleSeriesView.MaxSize = Convert.ToDouble(spinEditMaxBubbleSize.Value);
        }
        void spinEditTransparencyEditValueChanged(object sender, EventArgs e) {
            if(BubbleSeriesView != null)
                BubbleSeriesView.Transparency = Convert.ToByte(spinEditTransparency.Value);
        }
        void tbcPointCount_EditValueChanged(object sender, EventArgs e) {
            if(!IsHandleCreated)
                return;
            BeginInvoke((Action)(() => {
                SetDataSources();
            }));
        }
        protected override void SetDataSources() {
            SeriesPointsInitializer.InitSeries(chartPoint, tbcPointCount.Value);
            chartBubble.Series[0].DataSource = MovieData.GetData();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentManager.View.Controller.Activate(documentPoint);
        }
        protected override void UpdateControlsCore() {
            base.UpdateControlsCore();
            bool isBubbleSeriesView = BubbleSeriesView != null;
            LayoutVisibility visibility = isBubbleSeriesView ? LayoutVisibility.Always : LayoutVisibility.Never;
            layoutControlGroupGeneral.Visibility = visibility;
            layoutControlGroupLabel.Visibility = visibility;
            visibility = isBubbleSeriesView ? LayoutVisibility.Never : LayoutVisibility.Always;
            layoutControlGroupMarker.Visibility = visibility;
            layoutControlGroupPointCount.Visibility = visibility;

            if(isBubbleSeriesView) {
                spinEditTransparency.Value = BubbleSeriesView.Transparency;
                spinEditMinBubbleSize.EditValue = BubbleSeriesView.MinSize;
                spinEditMaxBubbleSize.EditValue = BubbleSeriesView.MaxSize;
            }
            else if(PointSeriesView != null)
                UpdateMarkerControls(PointSeriesView.PointMarkerOptions);
        }
        protected override void OnPaletteChanged() {
            PaletteEntry[] entries = chartPoint.GetPaletteEntries(chartPoint.Series.Count);
            for(int i = 0; i < chartPoint.Series.Count; i++)
                chartPoint.Series[i].View.Color = Color.FromArgb(50, entries[i].Color);
        }
        protected internal override void BeforeChartDesignerShown() {
            if(PointSeriesView != null) {
                XYDiagram diagram = chartPoint.Diagram as XYDiagram;
                if(diagram != null)
                    diagram.ResetZoom();
            }
        }
    }

    public class SeriesPointsInitializer {
        public static void InitSeries(ChartControl chart, int count) {
            if(chart.Series.Count > 2 && chart.Series[0].View.GetType().Equals(typeof(PointSeriesView))) {
                NonCryptographicRandom random = NonCryptographicRandom.System;
                chart.Series[0].DataSource = PointGenerator.GenerateCluster(random, 140, 1280, 100, 1240, count);
                chart.Series[1].DataSource = PointGenerator.GenerateCluster(random, 500, 1600, 1000, 2100, count);
                chart.Series[2].DataSource = PointGenerator.GenerateCluster(random, 450, 950, 1550, 2050, count);
                chart.Series[3].DataSource = PointGenerator.GenerateCluster(random, 800, 1700, 300, 1200, count);
                foreach(Series series in chart.Series) {
                    series.ArgumentDataMember = "Argument";
                    series.ValueDataMembers.AddRange("Value");
                }
            }
        }
    }
}
