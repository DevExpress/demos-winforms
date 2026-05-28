using System;
using DevExpress.Utils;
using DevExpress.Utils.Design;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace DevExpress.XtraCharts.Demos {
    public class ChartDemoModuleLabelViews : ChartDemoModuleWithOptions {
        protected const string PiePercentPattern = "{A}: {VP:P2}";
        protected const string FunnelPercentPattern = "{A}: {VP:P0}";
        protected const string PercentPattern = "{VP:P0}";

        ChartControl activeChart = new ChartControl();

        protected virtual SeriesBase ActiveSeries {
            get {
                if(ChartControl.Series.Count > 0)
                    return ChartControl.Series[0];
                return ChartControl.SeriesTemplate;
            }
        }
        protected virtual SpinEdit LabelAngleSpinEdit {
            get { return null; }
        }
        protected virtual CheckEdit ValueAsPercentCheckEdit {
            get { return null; }
        }
        protected virtual CheckEdit LabelVisibleCheckEdit {
            get { return null; }
        }
        protected virtual LayoutControl OptionsLayoutControl {
            get { return null; }
        }
        protected virtual DefaultBoolean CrosshairEnabled {
            get { return DefaultBoolean.Default; }
        }
        protected virtual DefaultBoolean ToolTipEnabled {
            get { return DefaultBoolean.Default; }
        }
        protected virtual bool AnimationEnabled {
            get { return true; }
        }
        protected virtual TabbedView TabbedView {
            get { return null; }
        }

        internal override ChartControl ChartControl {
            get { return activeChart; }
        }

        public ChartDemoModuleLabelViews() {
            Load += ChartDemoModuleLabelViews_Load;
        }

        void ChartDemoModuleLabelViews_Load(object sender, EventArgs e) {
            if(!DesignTimeTools.IsDesignMode)
                InitControls();
        }
        bool IsFullStackedBarView(SeriesViewBase view) {
            return view is FullStackedBarSeriesView || view is FullStackedBar3DSeriesView;
        }
        bool IsSideBySideFullStackedBarView(SeriesViewBase view) {
            return view is SideBySideFullStackedBarSeriesView || view is SideBySideFullStackedBar3DSeriesView;
        }
        bool IsFullStackedView(SeriesViewBase view) {
            return view is FullStackedAreaSeriesView ||
                   view is FullStackedSplineAreaSeriesView ||
                   view is FullStackedLineSeriesView ||
                   view is FullStackedArea3DSeriesView ||
                   view is FullStackedLine3DSeriesView;
        }
        bool IsFunnelView(SeriesViewBase view) {
            return view is FunnelSeriesView || view is Funnel3DSeriesView;
        }
        bool IsPieView(SeriesViewBase view) {
            return view is PieSeriesView || view is Pie3DSeriesView;
        }
        void ValueAsPercentCheckedEditCheckedChanged(object sender, EventArgs e) {
            ApplySettingsToSeries(SetValueAsPercent);
        }
        void LabelAngleSpinEditEditValueChanged(object sender, EventArgs e) {
            ApplySettingsToSeries(SetLabelAngle);
        }
        void OnLabelVisibilityChanged(LayoutControlItem[] items) {
            bool labelVisible = LabelVisibleCheckEdit.Checked;
            SetEnabledLayoutControlItems(labelVisible, items);
            ChartControl.CrosshairEnabled = labelVisible ? DefaultBoolean.False : CrosshairEnabled;
            ChartControl.ToolTipEnabled = labelVisible ? DefaultBoolean.False : ToolTipEnabled;
        }
        void UpdateControls() {
            if(OptionsLayoutControl == null)
                return;
            OptionsLayoutControl.BeginUpdate();
            UpdateControlsCore();
            OptionsLayoutControl.EndUpdate();
        }
        void TabbedView_PopupMenuShowing(object sender, XtraBars.Docking2010.Views.PopupMenuShowingEventArgs e) {
            e.Cancel = e.GetDocument() != null;
        }

        protected virtual void InitControls() {
            if(TabbedView != null)
                TabbedView.PopupMenuShowing += TabbedView_PopupMenuShowing;
            SetDataSources();
            if(LabelAngleSpinEdit != null)
                LabelAngleSpinEdit.EditValueChanged += LabelAngleSpinEditEditValueChanged;
            if(ValueAsPercentCheckEdit != null)
                ValueAsPercentCheckEdit.CheckedChanged += ValueAsPercentCheckedEditCheckedChanged;
        }
        protected virtual void SetDataSources() { }
        protected virtual void UpdateControlsCore() { }
        protected virtual void OnDocumentActivatedCore(BaseDocument document) {
            UpdateControls();
            if(AnimationEnabled)
                activeChart.Animate();
        }
        protected void ApplySettingsToSeries(Action<SeriesBase> action) {
            if(string.IsNullOrEmpty(ChartControl.SeriesDataMember) && ChartControl.SeriesTemplate.DataAdapter == null)
                foreach(Series series in ChartControl.Series)
                    action(series);
            else
                action(ChartControl.SeriesTemplate);
        }
        protected void ApplySettingsToSeriesView(Action<SeriesViewBase> viewAction) {
            ApplySettingsToSeries((series) => { viewAction(series.View); });
        }
        protected void SetEnabledLayoutControlItems(bool enabled, params LayoutControlItem[] items) {
            foreach(LayoutControlItem item in items)
                item.Enabled = enabled;
        }
        protected void OnDocumentActivated(BaseDocument document) {
            if(!document.IsDockPanel)
                return;
            activeChart = ((DockPanel)document.Control).ControlContainer.Controls[0] as ChartControl;
            OnDocumentActivatedCore(document);
        }
        protected void SetLabelAngle(SeriesBase series) {
            SeriesLabelBase label = series.Label;
            int labelAngle = (int)LabelAngleSpinEdit.Value;
            PointSeriesLabel pointLabel = label as PointSeriesLabel;
            if(pointLabel != null) {
                pointLabel.Angle = labelAngle;
                return;
            }
            RangeAreaSeriesLabel rangeAreaLabel = label as RangeAreaSeriesLabel;
            if(rangeAreaLabel != null) {
                rangeAreaLabel.MinValueAngle = labelAngle;
                rangeAreaLabel.MaxValueAngle = labelAngle;
            }
        }
        protected void SetLabelVisibility(params LayoutControlItem[] items) {
            OnLabelVisibilityChanged(items);
            DefaultBoolean labelsVisibility = Utils.CovertBoolToDefaultBoolean(LabelVisibleCheckEdit.Checked);
            ApplySettingsToSeries((series) => series.LabelsVisibility = labelsVisibility);
        }
        protected void SetLabelVisibility(SeriesBase series, params LayoutControlItem[] items) {
            OnLabelVisibilityChanged(items);
            series.LabelsVisibility = Utils.CovertBoolToDefaultBoolean(LabelVisibleCheckEdit.Checked);
        }
        protected void SetValueAsPercent(SeriesBase series) {
            SeriesViewBase view = series.View;
            bool valueAsPercent = ValueAsPercentCheckEdit.Checked;
            if(view is FullStackedStepAreaSeriesView)
                series.Label.TextPattern = valueAsPercent ? PercentPattern : "{V:F0}";
            else if(IsPieView(view))
                series.Label.TextPattern = valueAsPercent ? PiePercentPattern : "{A}: {V:F1}";
            else if(IsFunnelView(view))
                series.Label.TextPattern = valueAsPercent ? FunnelPercentPattern : "{A}: {V:F0}";
            else if(IsSideBySideFullStackedBarView(view))
                series.Label.TextPattern = valueAsPercent ? PercentPattern : "{V:0,,.0}M";
            else if(IsFullStackedBarView(view))
                series.Label.TextPattern = valueAsPercent ? PercentPattern : "{V:F0}K";
            else if(IsFullStackedView(view))
                series.Label.TextPattern = valueAsPercent ? PercentPattern : "${V}M";
        }
    }
}
