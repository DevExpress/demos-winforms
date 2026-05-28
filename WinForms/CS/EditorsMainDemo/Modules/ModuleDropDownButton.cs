using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Tutorials;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleDropDownButton : TutorialControl {
        public ModuleDropDownButton() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleDropDownButton" }; } }
        protected override string WhatsThisXMLFileName { get { return "dropdownbutton"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }

        bool updateValues = false;

        private void ModulePictureEdit_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(sampleDropDownButton);
            InitCombo();
            InitValues();
        }

        void InitCombo() {
            //<icbImageLocation>
            icbImageLocation.Properties.Items.AddEnum(typeof(ImageLocation));
            //</icbImageLocation>
            //<icbImage>
            int index = 0;
            foreach(var keyName in svgImageCollection1.Keys) {
                icbImage.Properties.Items.Add(new ImageComboBoxItem(keyName, index, index));
                index++;
            }
            //</icbImage>
        }


        void InitValues() {
            updateValues = true;
            icbImageLocation.EditValue = sampleDropDownButton.ImageLocation;
            icbImage.EditValue = sampleDropDownButton.ImageIndex;
            icbDropDownStyle.Properties.Items.AddEnum(typeof(DropDownArrowStyle));
            icbDropDownStyle.EditValue = DropDownArrowStyle.Default;
            icbDropDownControl.EditValue = 0;
            updateValues = false;
        }
        //<icbImageLocation>
        private void icbImageLocation_SelectedIndexChanged(object sender, EventArgs e) {
            //<skip>
            if(updateValues) return;
            //</skip>
            sampleDropDownButton.ImageLocation = (ImageLocation)icbImageLocation.EditValue;
        }
        //</icbImageLocation>
        //<icbImage>
        private void icbImage_SelectedIndexChanged(object sender, EventArgs e) {
            //<skip>
            if(updateValues) return;
            //</skip>
            sampleDropDownButton.ImageIndex = (int)icbImage.EditValue;
        }
        //</icbImage>

        //<icbDropDownControl>
        private void icbDropDownControl_SelectedIndexChanged(object sender, EventArgs e) {
            //<skip>
            if(updateValues) return;
            //</skip>
            if(icbDropDownControl.EditValue.Equals(0))
                sampleDropDownButton.DropDownControl = popupMenu1;
            else sampleDropDownButton.DropDownControl = popupControlContainer1;
        }
        //</icbDropDownControl>

        private void simpleButton1_Click(object sender, EventArgs e) {
            dateEdit1.DateTime = TutorialConstants.Now;
            timeEdit1.Time = dateEdit1.DateTime;
        }

        private void simpleButton2_Click(object sender, EventArgs e) {
            dateEdit1.EditValue = null;
            timeEdit1.EditValue = null;
        }

        //<meFiringEvents>
        private void sampleDropDownButton_Click(object sender, EventArgs e) {
            ShowEvent("Click", sender);
        }

        private void sampleDropDownButton_ShowDropDownControl(object sender, ShowDropDownControlEventArgs e) {
            ShowEvent("ShowDropDownControl", e.DropDownControl);
        }

        void ShowEvent(string eventString, object obj) {
            meFiringEvents.Text = string.Format("{0}: {1}\r\n", eventString, obj) + meFiringEvents.Text;
        }
        //</meFiringEvents>
        private void simpleButton3_Click(object sender, EventArgs e) {
            meFiringEvents.Text = string.Empty;
        }
        private void icbDropDownStyle_SelectedIndexChanged(object sender, EventArgs e) {
            sampleDropDownButton.DropDownArrowStyle = (DropDownArrowStyle)icbDropDownStyle.EditValue;
        }

    }
}

