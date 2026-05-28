using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
// <comboSpinStyle> <checkEditAdditionalButtons>
using DevExpress.XtraEditors.Controls;
using DevExpress.Tutorials;
using DevExpress.XtraBars.Navigation;
// </comboSpinStyle> </checkEditAdditionalButtons>

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleSpinEdit : TutorialControl {
        public ModuleSpinEdit() {
            InitializeComponent();
            if(this.tabPane1 != null)
                this.tabPane1.SelectedPageChanged += OnSelectedPageChanged;
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleSpinEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "spinedit"; } }
        void OnSelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            CalcContentCore();
        }
        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            if(this.tabPane1 != null)
                this.tabPane1.SelectedPageChanged -= OnSelectedPageChanged;
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl2);
            CalcLayoutControlBounds(layoutControl1);
        }

        bool updateValues = false;

        private void ModuleSpinEdit_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(spinEditSample1);
            ControlUtils.CenterControlInParent(spinEditSample2);
            InitValues();
        }


        void InitValues() {
            updateValues = true;
            checkEditFloatValue.Checked = spinEditSample1.Properties.IsFloatValue;
            spinEditButtonPos.Value = spinEditSample1.Properties.SpinButtonIndex;
            comboSpinStyle.EditValue = spinEditSample1.Properties.SpinStyle.ToString();
            comboFiringMode.EditValue = spinEditSample2.Properties.EditValueChangedFiringMode.ToString();
            checkEditValidate.Checked = spinEditSample2.Properties.ValidateOnEnterKey;
            updateValues = false;
        }

        // <comboSpinStyle>
        private void comboSpinStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            SpinStyles[] styles = new SpinStyles[] { SpinStyles.Vertical, SpinStyles.Horizontal };
            spinEditSample1.Properties.SpinStyle = styles[comboSpinStyle.SelectedIndex];
        }
        // </comboSpinStyle>

        // <checkEditAdditionalButtons>
        private void checkEditAdditionalButtons_CheckedChanged(object sender, System.EventArgs e) {
            spinEditButtonPos.Enabled = checkEditAdditionalButtons.Checked;
            EditorButtonCollection buttons = spinEditSample1.Properties.Buttons;
            if(checkEditAdditionalButtons.Checked) {
                buttons.Add(CreateButton(false, "1"));
                buttons.Add(CreateButton(true, "2"));
                buttons.Add(CreateButton(true, "3"));
            }
            else {
                while(buttons.Count > 1)
                    buttons.RemoveAt(buttons.Count - 1);
                spinEditSample1.Properties.SpinButtonIndex = 0;
                spinEditButtonPos.Value = 0;
            }
        }
        private EditorButton CreateButton(bool isLeft, string caption) {
            EditorButton button = new EditorButton(ButtonPredefines.Glyph);
            button.Caption = caption;
            button.IsLeft = isLeft;
            return button;
        }
        // </checkEditAdditionalButtons>

        // <spinEditButtonPos>
        private void spinEditButtonPos_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            spinEditSample1.Properties.SpinButtonIndex = (int)spinEditButtonPos.Value;
        }
        // </spinEditButtonPos>

        // <comboMaxMin>
        private void comboMaxMin_SelectedIndexChanged(object sender, System.EventArgs e) {
            decimal[] minValues = new decimal[] { -1000, 10, 0 };
            decimal[] maxValues = new decimal[] { 1000, 99, 12.5M };
            int index = comboMaxMin.SelectedIndex;
            spinEditSample1.Properties.MinValue = minValues[index];
            spinEditSample1.Properties.MaxValue = maxValues[index];
        }
        // </comboMaxMin>

        // <comboIncrementValue>
        private void comboIncrementValue_SelectedIndexChanged(object sender, System.EventArgs e) {
            decimal[] increments = new decimal[] { 10, 1, 0.5M, 0.1M };
            int index = comboIncrementValue.SelectedIndex;
            spinEditSample1.Properties.Increment = increments[index];
        }
        // </comboIncrementValue>

        // <checkEditFloatValue>
        private void checkEditFloatValue_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            spinEditSample1.Properties.IsFloatValue = checkEditFloatValue.Checked;
        }
        // </checkEditFloatValue>

        // <comboFiringMode>
        private void comboFiringMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            EditValueChangedFiringMode[] mode = new EditValueChangedFiringMode[] {
				EditValueChangedFiringMode.Buffered, 
				EditValueChangedFiringMode.Default };
            int index = comboFiringMode.SelectedIndex;
            spinEditSample2.Properties.EditValueChangedFiringMode = mode[index];
        }
        // </comboFiringMode>

        // <checkEditValidate>
        private void checkEditValidate_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            spinEditSample2.Properties.ValidateOnEnterKey = checkEditValidate.Checked;
        }
        // </checkEditValidate>

        // <spinEditSample2>
        private void spinEditSample2_EditValueChanged(object sender, System.EventArgs e) {
            meFiringEvents.Text = string.Format("EditValueChanged: {0}", spinEditSample2.EditValue);
        }
        // </spinEditSample2>

        // <checkEditValidate>
        private void spinEditSample2_Validated(object sender, System.EventArgs e) {
            meFiringEvents.Text = string.Format("Validated: {0}", spinEditSample2.EditValue);
        }
        // </checkEditValidate>
    }
}

