using System;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Core.Model;

namespace DevExpress.XtraGauges.Demos {
    public partial class LinearGaugeFeatures : TutorialControl{
        public LinearGaugeFeatures() {
            InitializeComponent();
        }
        void InitControls() {
            InitScaleFeaturesPage();
            InitRangeBarFeaturesPage();
            InitStateIndicatorFeaturesPage();
            InitOtherFeaturesPage();
        }
        void LinearGaugeFeatures_Load(object sender, System.EventArgs e) {
            InitControls();
        }
        void UpdateOtherFeaturesPage(object sender, EventArgs e) {
            linearScaleComponent6.Value = linearScaleComponent6.MinValue + linearScaleComponent6.ScaleLength * ((float)trackBarControl1.Value / (float)trackBarControl1.Properties.Maximum);
            linearScaleComponent6.Labels[0].TextOrientation = (LabelOrientation)Enum.Parse(typeof(LabelOrientation), (string)lblOrientation.EditValue);
            linearScaleComponent6.Labels[0].Position = new DevExpress.XtraGauges.Core.Base.PointF2D(
                    (float)horzLblPos.Value, (float)vertLblPos.Value
                );
        }
        void UpdateStateIndicatorFeaturesPage(object sender, System.EventArgs e) {
            linearScaleComponent5.Value = stateValTrack.Value;
        }
        void UpdateRangeBarFeaturesPage(object sender, System.EventArgs e) {
            linearScaleComponent4.Value = rbValue.Value;
            linearScaleRangeBarComponent1.BeginUpdate();
            linearScaleRangeBarComponent1.AnchorValue = rbStartValue.Value;
            linearScaleRangeBarComponent1.StartOffset = rbStartExtent.Value;
            linearScaleRangeBarComponent1.EndOffset = rbEndExtent.Value;
            linearScaleRangeBarComponent1.EndUpdate();

            linearScaleMarkerComponent1.BeginUpdate();
            linearScaleMarkerComponent1.ShapeOffset = markerOffset.Value;
            linearScaleMarkerComponent1.ShapeType = (MarkerPointerShapeType)Enum.Parse(typeof(MarkerPointerShapeType), (string)markerShape.EditValue);
            linearScaleMarkerComponent1.EndUpdate();
        }       
        void UpdateScaleFeaturesPage(object sender, System.EventArgs e) {
            linearScaleComponent1.BeginUpdate();

            linearScaleComponent1.MinValue = rangeTrackLinear.Value.Minimum;
            linearScaleComponent1.MaxValue = rangeTrackLinear.Value.Maximum;
            linearScaleComponent1.Value = linearScaleComponent1.MinValue + linearScaleComponent1.ScaleLength * ((float)valueTrack.Value / (float)valueTrack.Properties.Maximum);
            linearScaleComponent1.MinorTickCount = tickmarksCountTrack.Value;
            linearScaleComponent1.MajorTickCount = labelsCountTrack.Value;
            linearScaleComponent1.MajorTickmark.TextOffset = textExtentTrack.Value;
           
            linearScaleComponent1.MajorTickmark.TextOrientation = (LabelOrientation)Enum.Parse(typeof(LabelOrientation), (string)labelsOrientation.EditValue);

            linearScaleComponent1.MinorTickmark.ShapeOffset = tickOffset.Value;
            linearScaleComponent1.MajorTickmark.ShapeOffset = lblTickOffset.Value;
            linearScaleComponent1.EndUpdate();
        }       
        protected void SubscribeChanged(TrackBarControl trackBar, EventHandler handler) {
            trackBar.EditValueChanged += handler;
        }
        protected void SubscribeChanged(ComboBoxEdit combo, EventHandler handler) {
            combo.SelectedIndexChanged += handler;
        }
        protected void FillCombo(ComboBoxEdit cbe, Type enumType) {
            string[] names = Enum.GetNames(enumType);
            foreach(string _name in names) {
                cbe.Properties.Items.Add(_name);
            }
        }
        protected void FillCombo(ComboBoxEdit cbe, Type enumType, string filter) {
            string[] names = Enum.GetNames(enumType);
            foreach(string _name in names) {
                if(_name.StartsWith(filter)) cbe.Properties.Items.Add(_name);
            }
        }
        protected void InitStateIndicatorFeaturesPage() {
            stateValTrack.Value = (int)linearScaleComponent5.Value;
            SubscribeChanged(stateValTrack, UpdateStateIndicatorFeaturesPage);
        }
        protected void InitRangeBarFeaturesPage() {
            rbValue.Value = (int)linearScaleComponent4.Value;
            rbStartValue.Value = (int)linearScaleRangeBarComponent1.AnchorValue;
            rbStartExtent.Value = (int)linearScaleRangeBarComponent1.StartOffset;
            rbEndExtent.Value = (int)linearScaleRangeBarComponent1.EndOffset;

            FillCombo(markerShape, typeof(MarkerPointerShapeType));
            markerShape.EditValue = linearScaleMarkerComponent1.ShapeType.ToString();
            markerOffset.Value = (int)linearScaleMarkerComponent1.ShapeOffset;

            SubscribeChanged(rbValue, UpdateRangeBarFeaturesPage);
            SubscribeChanged(rbStartValue, UpdateRangeBarFeaturesPage);
            SubscribeChanged(rbStartExtent, UpdateRangeBarFeaturesPage);
            SubscribeChanged(rbEndExtent, UpdateRangeBarFeaturesPage);
            markerOffset.EditValueChanged += UpdateRangeBarFeaturesPage;
            markerShape.EditValueChanged += UpdateRangeBarFeaturesPage;
        }
        protected void InitScaleFeaturesPage() {
            rangeTrackLinear.Value = new DevExpress.XtraEditors.Repository.TrackBarRange((int)linearScaleComponent1.MinValue, (int)linearScaleComponent1.MaxValue);
            valueTrack.Value = (int)linearScaleComponent1.Value;
            tickmarksCountTrack.Value = linearScaleComponent1.MinorTickCount;
            labelsCountTrack.Value = linearScaleComponent1.MajorTickCount;
            textExtentTrack.Value = (int)linearScaleComponent1.MajorTickmark.TextOffset;
            tickOffset.Value = (int)linearScaleComponent1.MinorTickmark.ShapeOffset;
            lblTickOffset.Value = (int)linearScaleComponent1.MajorTickmark.ShapeOffset;
         
            SubscribeChanged(rangeTrackLinear, UpdateScaleFeaturesPage);
            SubscribeChanged(valueTrack, UpdateScaleFeaturesPage);
            SubscribeChanged(tickmarksCountTrack, UpdateScaleFeaturesPage);
            SubscribeChanged(labelsCountTrack, UpdateScaleFeaturesPage);
            SubscribeChanged(textExtentTrack, UpdateScaleFeaturesPage);
            SubscribeChanged(tickOffset, UpdateScaleFeaturesPage);
            SubscribeChanged(lblTickOffset, UpdateScaleFeaturesPage);
                       
            FillCombo(labelsOrientation, typeof(LabelOrientation));
            labelsOrientation.Properties.Items.Remove(LabelOrientation.Radial.ToString());
            labelsOrientation.Properties.Items.Remove(LabelOrientation.Tangent.ToString());           
            labelsOrientation.EditValue = linearScaleComponent1.MajorTickmark.TextOrientation.ToString();

            SubscribeChanged(labelsOrientation, UpdateScaleFeaturesPage);
            UpdateScaleFeaturesPage(null, null);
        }
        protected void InitOtherFeaturesPage() {
            horzLblPos.EditValue = linearScaleComponent6.Labels[0].Position.X;
            vertLblPos.EditValue = linearScaleComponent6.Labels[0].Position.Y;
            FillCombo(lblOrientation, typeof(LabelOrientation));
            lblOrientation.Properties.Items.Remove(LabelOrientation.Radial.ToString());
            lblOrientation.Properties.Items.Remove(LabelOrientation.Tangent.ToString());
            lblOrientation.EditValue = linearScaleComponent6.Labels[0].TextOrientation.ToString();

            horzLblPos.EditValueChanged += UpdateOtherFeaturesPage;
            vertLblPos.EditValueChanged += UpdateOtherFeaturesPage;
            trackBarControl1.EditValueChanged += UpdateOtherFeaturesPage;
            lblOrientation.EditValueChanged += UpdateOtherFeaturesPage;
        }
    }
}
