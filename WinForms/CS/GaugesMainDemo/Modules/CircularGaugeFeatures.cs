using System;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Core.Model;

namespace DevExpress.XtraGauges.Demos {
    public partial class CircularGaugeFeatures : TutorialControl {
        public CircularGaugeFeatures() {
            InitializeComponent();
        }
        void UpdateOtherFeaturesPage(object sender, EventArgs e) {
            arcScaleComponent2.Value = arcScaleComponent2.MinValue + arcScaleComponent2.ScaleLength * ((float)trackBarControl1.Value / (float)trackBarControl1.Properties.Maximum);
            arcScaleComponent2.Labels[0].TextOrientation = (LabelOrientation)Enum.Parse(typeof(LabelOrientation), (string)lblOrientation.EditValue);
            arcScaleComponent2.Labels[0].Position = new DevExpress.XtraGauges.Core.Base.PointF2D((float)horzLblPos.Value, (float)vertLblPos.Value);
        }      
        void UpdateRangeBarFeaturesPage(object sender, EventArgs e) {
            arcScaleComponent5.Value = arcScaleComponent5.MinValue + arcScaleComponent5.ScaleLength * ((float)trackBarControl32.Value / (float)trackBarControl32.Properties.Maximum);
            arcScaleRangeBarComponent1.BeginUpdate();
            arcScaleRangeBarComponent1.StartOffset = trackBarControl29.Value;
            arcScaleRangeBarComponent1.EndOffset = trackBarControl30.Value;
            arcScaleRangeBarComponent1.AnchorValue = arcScaleComponent5.MinValue + arcScaleComponent5.ScaleLength * ((float)trackBarControl31.Value / (float)trackBarControl31.Properties.Maximum);
            arcScaleRangeBarComponent1.EndUpdate();

            arcScaleMarkerComponent1.BeginUpdate();
            arcScaleMarkerComponent1.ShapeOffset = markerOffset.Value;
            arcScaleMarkerComponent1.ShapeType = (MarkerPointerShapeType)Enum.Parse(typeof(MarkerPointerShapeType), (string)markerShape.EditValue);
            arcScaleMarkerComponent1.EndUpdate();
        }
        void CircularGaugeFeatures_Load(object sender, System.EventArgs e) {
            InitControls();
        }
        void UpdateScaleFeaturesPage(object sender, System.EventArgs e) {
            arcScaleComponent1.BeginUpdate();
            arcScaleComponent1.RadiusX = scaleRTrack.Value;
            arcScaleComponent1.RadiusY = scaleRTrack.Value;

            arcScaleComponent1.MaxValue = rangeTrack.Value.Maximum;
            arcScaleComponent1.MinValue = rangeTrack.Value.Minimum;
            arcScaleComponent1.Value = arcScaleComponent1.MinValue + arcScaleComponent1.ScaleLength * ((float)scaleValueTrack.Value / (float)scaleValueTrack.Properties.Maximum);
            arcScaleComponent1.StartAngle = scaleStartAngleTrack.Value - 240;
            arcScaleComponent1.EndAngle = scaleEndAngleTrack.Value;
            arcScaleComponent1.MinorTickCount = scaleTicksCount.Value;
            arcScaleComponent1.MajorTickCount = scaleLabelsCount.Value;
            arcScaleComponent1.MajorTickmark.TextOffset = scaleTextExtentTrack.Value;

            arcScaleComponent1.MajorTickmark.ShapeOffset = majorTickOffset.Value;
            arcScaleComponent1.MinorTickmark.ShapeOffset = minorTickOffset.Value;
                      
            arcScaleComponent1.MajorTickmark.TextOrientation = (LabelOrientation)Enum.Parse(typeof(LabelOrientation), (string)scaleTextOrientation.EditValue);
            arcScaleComponent1.EndUpdate();
        }
        void UpdateNeedleFeaturesPage(object sender, EventArgs e) {
            arcScaleNeedleComponent6.StartOffset = trackBarControl25.Value;
            arcScaleNeedleComponent6.EndOffset = trackBarControl26.Value;
            arcScaleComponent6.Value = arcScaleComponent6.MinValue + arcScaleComponent6.ScaleLength * ((float)trackBarControl28.Value / (float)trackBarControl28.Properties.Maximum);
        }
        void UpdateStateIndicatorFeaturesPage(object sender, EventArgs e) {
            arcScaleComponent7.Value = arcScaleComponent7.MinValue
                + arcScaleComponent7.ScaleLength * ((float)statePageVal.Value / (float)statePageVal.Properties.Maximum);
        }
        protected virtual void InitControls() {
            InitScaleFeaturesPage();
            InitRangeBarFeaturesPage();
            InitNeedleFeaturesPage();
            InitStateIndicatorFeaturesPage();
            InitOtherFeaturesPage();
        }
        protected void SubscribeChanged(TrackBarControl trackBar) {
            trackBar.EditValueChanged += new System.EventHandler(UpdateScaleFeaturesPage);
        }
        protected void SubscribeChanged(ComboBoxEdit combo) {
            combo.SelectedIndexChanged += new System.EventHandler(UpdateScaleFeaturesPage);
        }
        protected void FillCombo(ComboBoxEdit cbe, Type enumType) {
            string[] _names = Enum.GetNames(enumType);
            foreach(string _name in _names) {
                cbe.Properties.Items.Add(_name);
            }
        }
        protected void FillCombo(ComboBoxEdit cbe, Type enumType, string filter) {
            string[] _names = Enum.GetNames(enumType);
            foreach(string _name in _names) {
                if(_name.StartsWith(filter)) cbe.Properties.Items.Add(_name);
            }
        }
        protected void InitScaleFeaturesPage() {
            scaleRTrack.Value = (int)arcScaleComponent1.RadiusX;
            rangeTrack.Value = new DevExpress.XtraEditors.Repository.TrackBarRange((int)arcScaleComponent1.MinValue, (int)arcScaleComponent1.MaxValue);

            scaleValueTrack.Value = (int)arcScaleComponent1.Value;
            scaleStartAngleTrack.Value = (int)arcScaleComponent1.StartAngle;
            scaleEndAngleTrack.Value = (int)arcScaleComponent1.EndAngle;
            scaleTicksCount.Value = arcScaleComponent1.MinorTickCount;
            scaleLabelsCount.Value = arcScaleComponent1.MajorTickCount;
            scaleTextExtentTrack.Value = (int)arcScaleComponent1.MajorTickmark.TextOffset;
            majorTickOffset.Value = (int)arcScaleComponent1.MajorTickmark.ShapeOffset;
            minorTickOffset.Value = (int)arcScaleComponent1.MinorTickmark.ShapeOffset;

            SubscribeChanged(scaleRTrack);
            SubscribeChanged(rangeTrack);
            SubscribeChanged(scaleTicksCount);
            SubscribeChanged(scaleLabelsCount);
            SubscribeChanged(scaleStartAngleTrack);
            SubscribeChanged(scaleEndAngleTrack);
            SubscribeChanged(scaleValueTrack);
            SubscribeChanged(scaleTextExtentTrack);
            SubscribeChanged(minorTickOffset);
            SubscribeChanged(majorTickOffset);

            FillCombo(scaleTextOrientation, typeof(LabelOrientation));
            scaleTextOrientation.EditValue = arcScaleComponent1.MajorTickmark.TextOrientation.ToString();

            SubscribeChanged(scaleTextOrientation);
            UpdateScaleFeaturesPage(null, null);
        }       
        protected void InitRangeBarFeaturesPage() {
            trackBarControl29.Value = (int)arcScaleRangeBarComponent1.StartOffset;
            trackBarControl30.Value = (int)arcScaleRangeBarComponent1.EndOffset;
            trackBarControl31.Value = (int)arcScaleRangeBarComponent1.AnchorValue;

            FillCombo(markerShape, typeof(MarkerPointerShapeType));
            markerShape.EditValue = arcScaleMarkerComponent1.ShapeType.ToString();
            markerOffset.Value = (int)arcScaleMarkerComponent1.ShapeOffset;

            trackBarControl29.EditValueChanged += UpdateRangeBarFeaturesPage;
            trackBarControl30.EditValueChanged += UpdateRangeBarFeaturesPage;
            trackBarControl31.EditValueChanged += UpdateRangeBarFeaturesPage;
            trackBarControl32.EditValueChanged += UpdateRangeBarFeaturesPage;
            markerOffset.EditValueChanged += UpdateRangeBarFeaturesPage;
            markerShape.EditValueChanged += UpdateRangeBarFeaturesPage;
        }
        protected void InitOtherFeaturesPage() {
            horzLblPos.EditValue = arcScaleComponent2.Labels[0].Position.X;
            vertLblPos.EditValue = arcScaleComponent2.Labels[0].Position.Y;
            FillCombo(lblOrientation, typeof(LabelOrientation));
            lblOrientation.EditValue = arcScaleComponent2.Labels[0].TextOrientation.ToString();

            horzLblPos.EditValueChanged += UpdateOtherFeaturesPage;
            vertLblPos.EditValueChanged += UpdateOtherFeaturesPage;
            trackBarControl1.EditValueChanged += UpdateOtherFeaturesPage;
            lblOrientation.EditValueChanged += UpdateOtherFeaturesPage;
        }
        protected void InitNeedleFeaturesPage() {
            trackBarControl25.Value = (int)arcScaleNeedleComponent6.StartOffset;
            trackBarControl25.EditValueChanged += new EventHandler(UpdateNeedleFeaturesPage);
            trackBarControl26.Value = (int)arcScaleNeedleComponent6.EndOffset;
            trackBarControl26.EditValueChanged += new EventHandler(UpdateNeedleFeaturesPage);
            trackBarControl28.Value = (int)(10 * arcScaleComponent6.Value);
            trackBarControl28.EditValueChanged += new EventHandler(UpdateNeedleFeaturesPage);
        }
        protected void InitStateIndicatorFeaturesPage() {
            statePageVal.Value = (int)(arcScaleComponent7.Value * 50f);
            statePageVal.ValueChanged += new EventHandler(UpdateStateIndicatorFeaturesPage);
        }
    }
}
