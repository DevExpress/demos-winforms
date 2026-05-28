using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <ceShowCustomButtons>
using DevExpress.XtraEditors.Controls;
// </ceShowCustomButtons>
using System.Windows.Forms;
using DevExpress.Tutorials;


namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleCalcEdit : TutorialControl  {
        public ModuleCalcEdit() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleCalcEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "calcedit"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }

        bool updateValues = false;

        private void ModuleCalcEdit_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(calcEditSample);
            InitValues();
        }

        void InitValues() {
            updateValues = true;
            sePrecision.Value = calcEditSample.Properties.Precision;
            ceShowCloseButton.Checked = calcEditSample.Properties.ShowCloseButton;
            ShowCustomButtons(ceShowCustomButtons.Checked);
            updateValues = false;
        }

        // <sePrecision>
        private void sePrecision_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            calcEditSample.Properties.Precision = Convert.ToInt32(sePrecision.Value);
        }
        // </sePrecision>

        // <ceShowCloseButton>
        private void ceShowCloseButton_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            calcEditSample.Properties.ShowCloseButton = ceShowCloseButton.Checked;
        }
        // </ceShowCloseButton>

        // <calcEditSample>
        private void calcEditSample_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            if(e.Button.Tag == null) return;
            switch(e.Button.Tag.ToString()) {
                case "involution2":
                    try {
                        calcEditSample.Value *= calcEditSample.Value;
                    }
                    catch(Exception ex) {
                        DevExpress.XtraEditors.XtraMessageBox.Show(this.FindForm(), ex.Message, "Error");
                    }
                    break;
                case "clear":
                    calcEditSample.Value = 0;
                    break;

            }
        }
        // </calcEditSample>

        // <ceShowCustomButtons>
        private void ceShowCustomButtons_CheckedChanged(object sender, System.EventArgs e) {
            ShowCustomButtons(ceShowCustomButtons.Checked);
        }

        void ShowCustomButtons(bool show) {
            foreach(EditorButton button in calcEditSample.Properties.Buttons)
                if(button.Tag != null) button.Visible = show;
        }
        // </ceShowCustomButtons>
    }
}

