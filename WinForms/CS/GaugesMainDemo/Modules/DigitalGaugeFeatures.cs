using System;
using System.Collections.Generic;
using DevExpress.XtraGauges.Core.Model;

namespace DevExpress.XtraGauges.Demos {
    public partial class DigitalGaugeFeatures : TutorialControl {
        Dictionary<char, byte[]> customMap;
        Dictionary<char, byte[]> emptyMap;

        public DigitalGaugeFeatures() {
            emptyMap = new Dictionary<char, byte[]>();
            customMap = new Dictionary<char, byte[]>();
            CreateCustomCharacterMap();

            InitializeComponent();
            this.gaugeNumber.Properties.Mask.Culture = (System.Globalization.CultureInfo)System.Globalization.CultureInfo.InvariantCulture.Clone();
            this.gaugeNumber.Properties.Mask.Culture.NumberFormat.NumberGroupSeparator = "`";
            this.gaugeTime.Properties.Mask.Culture = System.Globalization.CultureInfo.InvariantCulture;
            InitGauge();
        }
        void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateGauge();
        }
        void textEdit1_EditValueChanged(object sender, EventArgs e) {
            this.radioGroup1.SelectedIndex = 0;
            UpdateGauge();
        }
        void textEdit3_EditValueChanged(object sender, EventArgs e) {
            this.radioGroup1.SelectedIndex = 1;
            UpdateGauge();
        }
        void textEdit2_EditValueChanged(object sender, EventArgs e) {
            this.radioGroup1.SelectedIndex = 2;
            UpdateGauge();
        }
        void trackBarControl1_ValueChanged(object sender, EventArgs e) {
            UpdateGauge();
        }
        void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateGauge();
        }
        void OnUseCustomCharacterMap(object sender, EventArgs e) {
            dGauge.BeginUpdate();
            UserCharacterMap.Load(useCustomCharacterMap.Checked ? customMap : emptyMap);
            dGauge.Text = "AAAAAA";
            dGauge.EndUpdate();
            UpdateGauge();
        }
        void CreateCustomCharacterMap() {
            customMap.Add('G',
                new byte[] { 0x1C, 0x1C, 0x1C, 0x08, 0x18, 0x3C, 0x5A, 0x5A, 0x18, 0x18, 0x18, 0x24, 0x44, 0xC6 }
                );
            customMap.Add('a',
                new byte[] { 0x1C, 0x1C, 0x1C, 0x48, 0x58, 0x3C, 0x1A, 0x1A, 0x18, 0x18, 0x18, 0x24, 0x42, 0xC3 }
                );
            customMap.Add('u',
                new byte[] { 0x1C, 0x1C, 0x1C, 0x08, 0x18, 0x3C, 0x5A, 0x5A, 0x18, 0x18, 0x18, 0x24, 0x44, 0xC6 }
                );
            customMap.Add('g',
                new byte[] { 0x1C, 0x1C, 0x1d, 0x09, 0x1e, 0x3C, 0x58, 0x58, 0x18, 0x18, 0x18, 0x24, 0x44, 0xC6 }
                );
            customMap.Add('e',
                new byte[] { 0x1C, 0x1C, 0x1C, 0x08, 0x18, 0x3C, 0x5A, 0x5A, 0x18, 0x18, 0x18, 0x24, 0x44, 0xC6 }
                );
            customMap.Add('s',
                new byte[] { 0x1C, 0x1C, 0x1C, 0x48, 0x58, 0x3C, 0x1A, 0x1A, 0x18, 0x18, 0x18, 0x24, 0x42, 0xC3 }
                );
        }
        protected void UpdateGauge() {
            dGauge.DisplayMode = (DigitalGaugeDisplayMode)Enum.Parse(typeof(DigitalGaugeDisplayMode), (string)gaugeMode.EditValue);
            useCustomCharacterMap.Enabled = (dGauge.DisplayMode == DigitalGaugeDisplayMode.Matrix8x14);
            if(!useCustomCharacterMap.Enabled) useCustomCharacterMap.Checked = false;
            switch(radioGroup1.SelectedIndex) {
                case 0: dGauge.Text = gaugeText.EditValue.ToString(); break;
                case 1:
                    dGauge.Text = gaugeTime.Properties.GetDisplayText(gaugeTime.Properties.DisplayFormat, gaugeTime.EditValue);
                    break;
                case 2:
                    string txt = gaugeNumber.Text;
                    if(txt.Replace("`", "").Replace(".", "").Length > 6)
                        dGauge.Text = "OVRFLW";
                    else
                        dGauge.Text = gaugeNumber.Text;
                    break;
            }
            dGauge.LetterSpacing = letterSpacing.Value;
        }
        protected void InitGauge() {
            useCustomCharacterMap.Enabled = false;
            radioGroup1.SelectedIndex = 0;
            gaugeMode.Properties.Items.Add(DigitalGaugeDisplayMode.FourteenSegment.ToString());
            gaugeMode.Properties.Items.Add(DigitalGaugeDisplayMode.SevenSegment.ToString());
            gaugeMode.Properties.Items.Add(DigitalGaugeDisplayMode.Matrix5x8.ToString());
            gaugeMode.Properties.Items.Add(DigitalGaugeDisplayMode.Matrix8x14.ToString());
        }
        protected override bool? AllowBorderRounding {
            get { return false; }
        }
    }
}
