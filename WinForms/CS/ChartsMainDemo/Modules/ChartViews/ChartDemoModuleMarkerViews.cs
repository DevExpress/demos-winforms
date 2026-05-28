using System;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.XtraCharts.Demos {
    public class ChartDemoModuleMarkerViews : ChartDemoModuleLabelViews {
        readonly MarkerKindItemCollection markerKindItems;

        protected virtual ComboBoxEdit MarkerKindComboBox {
            get { return null; }
        }
        protected virtual SpinEdit MarkerSizeSpinEdit {
            get { return null; }
        }
        protected virtual CheckEdit MarkerVisibleCheckEdit {
            get { return null; }
        }
        protected virtual int MarkerKindDefaultIndex {
            get { return 4; }
        }

        public ChartDemoModuleMarkerViews() {
            markerKindItems = MarkerKindItemCollection.CreateCollection();
        }

        void SetMarkerKind(SeriesViewBase view) {
            MarkerKind kind;
            int starCount;
            ParseMarkerKind(MarkerKindComboBox.EditValue, out kind, out starCount);
            if(SetRangeMarkerKind(view, kind, starCount))
                return;
            PointSeriesView pointView = view as PointSeriesView;
            if(pointView != null) {
                pointView.PointMarkerOptions.Kind = kind;
                pointView.PointMarkerOptions.StarPointCount = starCount;
                return;
            }
            BubbleSeriesView bubbleView = view as BubbleSeriesView;
            if(bubbleView != null) {
                bubbleView.BubbleMarkerOptions.Kind = kind;
                bubbleView.BubbleMarkerOptions.StarPointCount = starCount;
                return;
            }
            RadarPointSeriesView radarPointView = view as RadarPointSeriesView;
            if(radarPointView != null) {
                radarPointView.PointMarkerOptions.Kind = kind;
                radarPointView.PointMarkerOptions.StarPointCount = starCount;
            }
        }
        void ParseMarkerKind(object editValue, out MarkerKind kind, out int starCount) {
            MarkerKindItem markerKind = (MarkerKindItem)editValue;
            kind = markerKind.MarkerKind;
            starCount = 3;
            StarMarkerKindItem starKindItem = markerKind as StarMarkerKindItem;
            if(starKindItem != null)
                starCount = starKindItem.PointCount;
        }
        void MarkerSizeEditValueChanged(object sender, EventArgs e) {
            ApplySettingsToSeriesView(SetMarkerSize);
        }
        void MarkerKindSelectedIndexChanged(object sender, EventArgs e) {
            ApplySettingsToSeriesView(SetMarkerKind);
        }
        void InitMarkerKindOptions(ComboBoxEdit rgMarkerKind) {
            foreach(MarkerKindItem item in markerKindItems)
                rgMarkerKind.Properties.Items.Add(item);
            rgMarkerKind.SelectedIndex = MarkerKindDefaultIndex;
            rgMarkerKind.SelectedIndexChanged += MarkerKindSelectedIndexChanged;
        }
        void UpdateMarkerControlCore(SimpleMarker markerOptions) {
            MarkerSizeSpinEdit.Value = markerOptions.Size;
            if(markerOptions.Kind != MarkerKind.Star)
                MarkerKindComboBox.SelectedItem = markerKindItems.GetItemByKind(markerOptions.Kind);
            else
                MarkerKindComboBox.SelectedItem = markerKindItems.GetItemByStarPointCount(markerOptions.StarPointCount);
        }
        void SetMarkerSize(SeriesViewBase view) {
            int size = (int)MarkerSizeSpinEdit.Value;
            if(SetRangeMarkerSize(view, size))
                return;
            PointSeriesView areaView = view as PointSeriesView;
            if(areaView != null) {
                areaView.PointMarkerOptions.Size = size;
                return;
            }
            RadarPointSeriesView radarPointView = view as RadarPointSeriesView;
            if(radarPointView != null)
                radarPointView.PointMarkerOptions.Size = size;
        }
        protected override void InitControls() {
            base.InitControls();
            InitMarkerKindOptions(MarkerKindComboBox);
            MarkerSizeSpinEdit.EditValueChanged += MarkerSizeEditValueChanged;
        }
        protected virtual bool SetRangeMarkerVisibility(SeriesViewBase view, DefaultBoolean visibility) {
            return false;
        }
        protected virtual bool SetRangeMarkerSize(SeriesViewBase view, int size) {
            return false;
        }
        protected virtual bool SetRangeMarkerKind(SeriesViewBase view, MarkerKind kind, int starCount) {
            return false;
        }
        protected void SetMarkerVisibility(params LayoutControlItem[] items) {
            SetEnabledLayoutControlItems(MarkerVisibleCheckEdit.Checked, items);
            ApplySettingsToSeriesView(SetMarkerVisibility);
        }
        protected void SetMarkerVisibility(SeriesViewBase view) {
            DefaultBoolean visibility = Utils.CovertBoolToDefaultBoolean(MarkerVisibleCheckEdit.Checked);
            if(SetRangeMarkerVisibility(view, visibility))
                return;
            LineSeriesView lineView = view as LineSeriesView;
            if(lineView != null) {
                lineView.MarkerVisibility = Utils.CovertBoolToDefaultBoolean(MarkerVisibleCheckEdit.Checked);
                return;
            }
            RadarLineSeriesView radarLineView = view as RadarLineSeriesView;
            if(radarLineView != null)
                radarLineView.MarkerVisibility = visibility;
        }
        protected void UpdateMarkerControls(SimpleMarker markerOptions) {
            UpdateMarkerControlCore(markerOptions);
        }
        protected void UpdateMarkerControls(SimpleMarker markerOptions, DefaultBoolean visibility) {
            MarkerVisibleCheckEdit.Checked = visibility.Equals(DefaultBoolean.True);
            UpdateMarkerControlCore(markerOptions);
        }
        protected LayoutVisibility UpdateRadarMarkerOptions() {
            RadarRangeAreaSeriesView radarRangeView = ActiveSeries.View as RadarRangeAreaSeriesView;
            if(radarRangeView != null) {
                UpdateMarkerControls(radarRangeView.Marker1, radarRangeView.Marker1Visibility);
                return LayoutVisibility.Always;
            }
            RadarLineSeriesView radarLineView = ActiveSeries.View as RadarLineSeriesView;
            if(radarLineView != null) {
                UpdateMarkerControls(radarLineView.LineMarkerOptions, radarLineView.MarkerVisibility);
                return LayoutVisibility.Always;
            }
            RadarPointSeriesView radarPointView = ActiveSeries.View as RadarPointSeriesView;
            if(radarPointView != null)
                UpdateMarkerControls(radarPointView.PointMarkerOptions);
            return LayoutVisibility.Never;
        }
    }
}
