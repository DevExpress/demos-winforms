using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <icbColorAlignment>
using DevExpress.Utils;
// <icbColorText>
using DevExpress.XtraEditors.Controls;
// </icbColorText>
// </icbColorAlignment>
using System.Windows.Forms;
using DevExpress.XtraEditors.Popup;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleColorEdit : TutorialControl  {
        public ModuleColorEdit() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleColorEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "coloredit"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }

        bool updateValues = false;

        private void ModuleColorEdit_Load(object sender, System.EventArgs e) {
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(colorEditSample);
            InitComboBoxes();
            InitValues();
            InitMagnifierBehavior();
        }

        void InitMagnifierBehavior() {
            behaviorManager1.Attach<Behaviors.MagnifierBehavior>(colorEditSample, (s)=>{ s.Properties.ShowPixelGrid = true; });
        }

        void InitComboBoxes() {
            // <icbColorDialogType>
            icbColorDialogType.Properties.Items.AddEnum(typeof(ColorDialogType));
            // </icbColorDialogType>
            // <icbColorText>
            icbColorText.Properties.Items.AddEnum(typeof(ColorText));
            // </icbColorText>
            // <icbColorAlignment>
            icbColorAlignment.Properties.Items.AddEnum(typeof(HorzAlignment));
            // </icbColorAlignment>
        }

        void InitValues() {
            updateValues = true;
            icbColorAlignment.EditValue = colorEditSample.Properties.ColorAlignment;
            icbColorText.EditValue = colorEditSample.Properties.ColorText;
            icbColorDialogType.EditValue = colorEditSample.Properties.ColorDialogType;
            ceShowColorDialog.Checked = colorEditSample.Properties.ShowColorDialog;
            ceAsInteger.Checked = colorEditSample.Properties.StoreColorAsInteger;
            updateValues = false;
        }

        // <icbColorAlignment>
        private void icbColorAlignment_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            colorEditSample.Properties.ColorAlignment = (HorzAlignment)icbColorAlignment.EditValue;
        }
        // </icbColorAlignment>

        // <icbColorText>
        private void icbColorText_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            colorEditSample.Properties.ColorText = (ColorText)icbColorText.EditValue;
        }
        // </icbColorText>

        // <icbColorDialogType>
        private void icbColorDialogType_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            colorEditSample.Properties.ColorDialogType = (ColorDialogType)icbColorDialogType.EditValue;
        }
        // </icbColorDialogType>

        // <ceShowColorDialog>
        private void ceShowColorDialog_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            colorEditSample.Properties.ShowColorDialog = ceShowColorDialog.Checked;
        }
        // </ceShowColorDialog>

        // <ceAsInteger>
        private void ceIsInteger_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            colorEditSample.Properties.StoreColorAsInteger = ceAsInteger.Checked;
        }
        // </ceAsInteger>

        void SetButtonEnabled(bool enabled) {
            seAdd.Enabled = enabled;
            seClear.Enabled = !enabled;
        }

        // <seAdd>
        // <seClear>
        Color[] GetColorArray(bool empty) {
            var rnd = TutorialConstants.Random;
            Color[] ret = new Color[colorEditSample.Properties.CustomColors.Length];
            for(int i = 0; i < ret.Length; i++)
                ret.SetValue((empty ? Color.Empty : Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255))), i);
            return ret;
        }
        // </seClear>

        private void seAdd_Click(object sender, System.EventArgs e) {
            colorEditSample.Properties.CustomColors = GetColorArray(false);
            SetButtonEnabled(false);
        }
        // </seAdd>

        // <seClear>
        private void seClear_Click(object sender, System.EventArgs e) {
            colorEditSample.Properties.CustomColors = GetColorArray(true);
            SetButtonEnabled(true);
        }
        // </seClear>
    }
}

