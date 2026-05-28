using System;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Core.Model;

namespace DevExpress.XtraGauges.Demos {
    public partial class LogarithmicScaleGaugeFeatures : TutorialControl{
        public LogarithmicScaleGaugeFeatures() {
            InitializeComponent();
        }
        void UpdateCircularScaleFeaturesPage(object sender, System.EventArgs e) {
            arcScaleComponent1.BeginUpdate();
           
            SetupBaseProperty(arcScaleComponent1, rangeTrack, scaleValueTrack);
            SetupLogarithmicProperty(arcScaleComponent1, customLogarithmicBaseCircularScale, logarithmicBaseCircularScale);                            
            arcScaleComponent1.EndUpdate();
        }
        protected void InitCircularScaleFeaturesPage() {           
            InitScaleFeaturesPage(arcScaleComponent1, rangeTrack, scaleValueTrack,  logarithmicBaseCircularScale, customLogarithmicBaseCircularScale, UpdateCircularScaleFeaturesPage);
        }
        void InitControls() {
            InitLinearScaleFeaturesPage();
            InitCircularScaleFeaturesPage();
        }
        void LinearGaugeFeatures_Load(object sender, System.EventArgs e) {
            InitControls();
        }
        void UpdateLinearScaleFeaturesPage(object sender, System.EventArgs e) {
            linearScaleComponent1.BeginUpdate();
            SetupBaseProperty(linearScaleComponent1, rangeTrackLinear, valueTrack);
            SetupLogarithmicProperty(linearScaleComponent1, customLogarithmicBaseLinearScale, logarithmicBaseLinearScale);                                
            linearScaleComponent1.EndUpdate();
        }
        protected void InitLinearScaleFeaturesPage() {
            InitScaleFeaturesPage(linearScaleComponent1, rangeTrackLinear, valueTrack,  logarithmicBaseLinearScale, customLogarithmicBaseLinearScale, UpdateLinearScaleFeaturesPage);
        }
        protected void SubscribeChanged(TrackBarControl trackBar, EventHandler handler) {
            trackBar.EditValueChanged += handler;
        }
        protected void SubscribeChanged(ComboBoxEdit combo, EventHandler handler) {
            combo.SelectedIndexChanged += handler;
        }
        protected void SubscribeChanged(TextEdit text, EventHandler handler) {
            text.EditValueChanged += handler;
        }
        protected void FillCombo(ComboBoxEdit cbe, Type enumType) {
            string[] names = Enum.GetNames(enumType);
            foreach(string _name in names) {
                cbe.Properties.Items.Add(_name);
            }
        }
        protected void InitScaleFeaturesPage(IBaseScale scale, RangeTrackBarControl rangeTrack, TrackBarControl valueTrackBar, ComboBoxEdit logarithmicBase, TextEdit customLogarithmicBase, EventHandler UpdateScaleFeaturesPage) {
            rangeTrack.Value = new DevExpress.XtraEditors.Repository.TrackBarRange((int)scale.MinValue, (int)scale.MaxValue);
            valueTrackBar.Value = (int)scale.Value;            
            SubscribeChanged(rangeTrack, UpdateScaleFeaturesPage);
            SubscribeChanged(valueTrackBar, UpdateScaleFeaturesPage);           
            FillCombo(logarithmicBase, typeof(LogarithmicBase));          
            logarithmicBase.EditValue = scale.LogarithmicBase.ToString();
            customLogarithmicBase.Text = scale.CustomLogarithmicBase.ToString(); 
            SubscribeChanged(logarithmicBase, UpdateScaleFeaturesPage);
            SubscribeChanged(customLogarithmicBase, UpdateScaleFeaturesPage);
            UpdateScaleFeaturesPage(null, null); 
        }
        protected void SetupLogarithmicProperty(IBaseScale scale, TextEdit customLogarithmicBase, ComboBoxEdit logarithmicBaseComboBox) {
            scale.CustomLogarithmicBase = float.Parse(customLogarithmicBase.Text);
            if(scale.IsLogarithmic)
                scale.LogarithmicBase = (LogarithmicBase)Enum.Parse(typeof(LogarithmicBase), (string)logarithmicBaseComboBox.EditValue);
            if(scale.LogarithmicBase != LogarithmicBase.Custom) {
                customLogarithmicBase.Enabled = false;
                customLogarithmicBase.Text = scale.CustomLogarithmicBase.ToString();
            }
            else customLogarithmicBase.Enabled = true;
        }
        protected void SetupBaseProperty(IBaseScale scale, RangeTrackBarControl rangeTrack, TrackBarControl valueTrackBar) {
            scale.MinValue = rangeTrack.Value.Minimum;
            scale.MaxValue = rangeTrack.Value.Maximum;
            scale.Value = scale.MinValue + Math.Abs(scale.ScaleLength * ((float)valueTrackBar.Value / (float)valueTrackBar.Properties.Maximum));
        }
    }
}
