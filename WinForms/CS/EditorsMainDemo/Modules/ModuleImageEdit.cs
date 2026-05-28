using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <icbSizeMode>
using DevExpress.XtraEditors.Controls;
// </icbSizeMode>
using System.Windows.Forms;
using DevExpress.Tutorials;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleImageEdit : TutorialControl  {
        public ModuleImageEdit() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleImageEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "imageedit"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }

        bool updateValues = false;

        private void ModuleImageEdit_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(imageEditSample);
            InitComboBoxes();
            InitValues();
        }

        void InitComboBoxes() {
            // <icbSizeMode>
            icbSizeMode.Properties.Items.AddEnum(typeof(PictureSizeMode));
            // </icbSizeMode>
        }


        void InitValues() {
            updateValues = true;
            icbSizeMode.EditValue = imageEditSample.Properties.SizeMode;
            ceIcon.Checked = imageEditSample.Properties.ShowIcon;
            ceMenu.Checked = imageEditSample.Properties.ShowMenu;
            cePopupSizeable.Checked = imageEditSample.Properties.PopupSizeable;
            ceCustomIcons.Enabled = imageEditSample.Properties.ShowIcon;
            updateValues = false;
        }

        // <icbSizeMode>
        private void icbSizeMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageEditSample.Properties.SizeMode = (PictureSizeMode)icbSizeMode.EditValue;
        }
        // </icbSizeMode>

        // <ceIcon>
        private void ceIcon_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageEditSample.Properties.ShowIcon = ceIcon.Checked;
            // <ceCustomIcons>
            ceCustomIcons.Enabled = imageEditSample.Properties.ShowIcon;
            // </ceCustomIcons>
        }
        // </ceIcon>

        // <ceMenu>
        private void ceMenu_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageEditSample.Properties.ShowMenu = ceMenu.Checked;
        }
        // </ceMenu>

        // <cePopupSizeable>
        private void cePopupSizeable_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageEditSample.Properties.PopupSizeable = cePopupSizeable.Checked;
        }
        // </cePopupSizeable>

        // <ceCustomIcons>
        private void ceCustomIcons_CheckedChanged(object sender, System.EventArgs e) {
            imageEditSample.Properties.Images = ceCustomIcons.Checked ? svgImageCollection1 : null;
        }
        // </ceCustomIcons>
    }
}

