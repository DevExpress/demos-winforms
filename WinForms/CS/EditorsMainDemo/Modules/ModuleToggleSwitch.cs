using DevExpress.Utils;
using System.Drawing;
using DevExpress.XtraEditors;
using System;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleToggleSwitch : TutorialControl {
        public ModuleToggleSwitch() {
            InitializeComponent();
            this.toggleSwitch.AutoSizeInLayoutControl = true;
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleToggleSwitch" }; } }
        protected override string WhatsThisXMLFileName { get { return "toggleSwitch"; } }
        //<tsTextOn>
        private void OnTextChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e) {
            string value = e.NewValue as string;
            if(value != null && value.Length > 10) {
                e.Cancel = true;
                return;
            }
            OnToggleSwitchTextChanging();
            try {
                toggleSwitch.Properties.OnText = e.NewValue.ToString();
            }
            finally { OnToggleSwitchTextChanged(); }
        }
        //</tsTextOn>
        //<tsTextOff>
        private void OffTextChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e) {
            string value = e.NewValue as string;
            if(value != null && value.Length > 10) {
                e.Cancel = true;
                return;
            }
            OnToggleSwitchTextChanging();
            try {
                toggleSwitch.Properties.OffText = e.NewValue.ToString();
            }
            finally { OnToggleSwitchTextChanged(); }
        }
        //</tsTextOff>
        //<btnToggleState>
        private void btnToggleState_Click(object sender, System.EventArgs e) {
            toggleSwitch.IsOn = !toggleSwitch.IsOn;            
        }
        //</btnToggleState>
        //<tsAllowHTMLString>
        private void tsAllowHTMLString_CheckedChanged(object sender, System.EventArgs e) {
            toggleSwitch.Properties.AllowHtmlDraw = tsAllowHTMLString.Checked ? DefaultBoolean.True : DefaultBoolean.False;
            SetToggleSwitchText();
        }
        //</tsAllowHTMLString>
        //<tsAllowMnemonics>
        string toggleSwitchOnText = "<Color=Blue><b>{0}{1}</b>";
        string toggleSwitchOffText = "<Color=Red><b>{0}{1}</b>";
        void SetToggleSwitchText() {
            string prefix = tsAllowMnemonics.Checked ? "&" : string.Empty;
            if(tsAllowHTMLString.Checked) {
                toggleSwitch.Properties.OnText = string.Format(toggleSwitchOnText, new object[] { prefix, tsTextOn.Text });
                toggleSwitch.Properties.OffText = string.Format(toggleSwitchOffText, new object[] { prefix, tsTextOff.Text });
            }
            else {
                toggleSwitch.Properties.OnText = string.Format(DevExpress.Utils.Text.StringPainter.Default.RemoveFormat(toggleSwitchOnText), new object[] { prefix, tsTextOn.Text });
                toggleSwitch.Properties.OffText = string.Format(DevExpress.Utils.Text.StringPainter.Default.RemoveFormat(toggleSwitchOffText), new object[] { prefix, tsTextOff.Text });
            }
        }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        private void tsAllowMnemonics_CheckedChanged(object sender, System.EventArgs e) {
            SetToggleSwitchText();
        }
        protected void OnToggleSwitchTextChanging() {
            this.layoutControl1.BeginUpdate();
        }
        protected void OnToggleSwitchTextChanged() {
            CalcContentCore();
            this.layoutControl1.EndUpdate();
        }
        //</tsAllowMnemonics>
        private void tsResize(object sender, System.EventArgs e) {
            SetToggleSwitchText();
        }
        //<comboAlign>
        private void comboAlign_SelectedIndexChanged(object sender, System.EventArgs e) {                        
            HorzAlignment[] alignments = new HorzAlignment[] { 
				HorzAlignment.Near, 
				HorzAlignment.Center, 
				HorzAlignment.Far };
            int selectedIndex = comboAlign.SelectedIndex;
            toggleSwitch.Properties.GlyphAlignment = alignments[selectedIndex];
            toggleSwitch.Properties.Appearance.TextOptions.HAlignment = alignments[selectedIndex];
        }
        //</comboAlign>
        //<tsAllowThumbAnimation>
        private void tsAllowThumbAnimation_CheckedChanged(object sender, System.EventArgs e) {
            toggleSwitch.Properties.AllowThumbAnimation = tsAllowThumbAnimation.Checked;
        }
        //</tsAllowThumbAnimation>
    }
}
