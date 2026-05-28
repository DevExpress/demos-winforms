using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
// <icbTextEditStyle>
// <icbShowDropDown>
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.Utils.Text;
using DevExpress.Tutorials;
// </icbShowDropDown>
// </icbTextEditStyle>

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleComboBoxEdit : TutorialControl  {
        public ModuleComboBoxEdit() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleComboBoxEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "comboboxedit"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }

        bool updateValues = false;

        private void ModuleComboBoxEdit_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(comboBoxEditSample);
            InitComboBoxes();
            InitValues();
        }

        void InitComboBoxes() {
            // <icbTextEditStyle>
            icbTextEditStyle.Properties.Items.AddEnum(typeof(TextEditStyles));
            // </icbTextEditStyle>
            // <icbShowDropDown>
            icbShowDropDown.Properties.Items.AddEnum(typeof(ShowDropDown));
            // </icbShowDropDown>
            // <icbHighlightedItemStyle>
            icbHighlightedItemStyle.Properties.Items.AddEnum(typeof(HighlightStyle));
            // </icbHighlightedItemStyle>
        }
        void UpdateComboBoxSampleData() {
            comboBoxEditSample.Properties.Items.BeginUpdate();
            try {
                comboBoxEditSample.Properties.Items.Clear();
                foreach(string country in TutorialHelper.Countries) {
                    string _name = comboBoxEditSample.Properties.TextEditStyle == TextEditStyles.Standard ? StringPainter.Default.RemoveFormat(country) : country;
                    comboBoxEditSample.Properties.Items.Add(_name);
                }
            } finally {
                comboBoxEditSample.Properties.Items.EndUpdate();
            }
            comboBoxEditSample.SelectedIndex = 0;
        }
        void InitValues() {
            updateValues = true;
            UpdateComboBoxSampleData();
            icbTextEditStyle.EditValue = comboBoxEditSample.Properties.TextEditStyle;
            icbShowDropDown.EditValue = comboBoxEditSample.Properties.ShowDropDown;
            icbHighlightedItemStyle.EditValue = comboBoxEditSample.Properties.HighlightedItemStyle;
            seItemHeight.Value = comboBoxEditSample.Properties.DropDownItemHeight;
            seDropDownRows.Value = comboBoxEditSample.Properties.DropDownRows;
            ceAutoComplete.Checked = comboBoxEditSample.Properties.AutoComplete;
            ceCycleOnDblClick.Checked = comboBoxEditSample.Properties.CycleOnDblClick;
            ceHotTrackItems.Checked = comboBoxEditSample.Properties.HotTrackItems;
            ceImmediatePopup.Checked = comboBoxEditSample.Properties.ImmediatePopup;
            cePopupSizeable.Checked = comboBoxEditSample.Properties.PopupSizeable;
            ceCTRLScroll.Checked = comboBoxEditSample.Properties.UseCtrlScroll;
            seDropDownRows.Enabled = !comboBoxEditSample.Properties.PopupSizeable;
            ceCycleOnDblClick.Enabled = comboBoxEditSample.Properties.ShowDropDown == ShowDropDown.Never;
            updateValues = false;
        }

        // <icbTextEditStyle>
        private void icbTextEditStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            comboBoxEditSample.Properties.TextEditStyle = (TextEditStyles)icbTextEditStyle.EditValue;
            UpdateComboBoxSampleData();
        }
        // </icbTextEditStyle>

        // <icbShowDropDown>
        private void icbShowDropDown_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            comboBoxEditSample.Properties.ShowDropDown = (ShowDropDown)icbShowDropDown.EditValue;
            // <ceCycleOnDblClick>
            ceCycleOnDblClick.Enabled = comboBoxEditSample.Properties.ShowDropDown == ShowDropDown.Never;
            // </ceCycleOnDblClick>
        }
        // </icbShowDropDown>

        // <seItemHeight>
        private void seItemHeight_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            comboBoxEditSample.Properties.DropDownItemHeight = Convert.ToInt32(seItemHeight.Value);
        }
        // </seItemHeight>

        // <seDropDownRows>
        private void seDropDownRows_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            comboBoxEditSample.Properties.DropDownRows = Convert.ToInt32(seDropDownRows.Value);
        }
        // </seDropDownRows>

        // <ceAutoComplete>
        private void ceAutoComplete_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            comboBoxEditSample.Properties.AutoComplete = ceAutoComplete.Checked;
        }
        // </ceAutoComplete>

        // <ceCycleOnDblClick>
        private void ceCycleOnDblClick_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            comboBoxEditSample.Properties.CycleOnDblClick = ceCycleOnDblClick.Checked;
        }
        // </ceCycleOnDblClick>

        // <ceHotTrackItems>
        private void ceHotTrackItems_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            comboBoxEditSample.Properties.HotTrackItems = ceHotTrackItems.Checked;
        }
        // </ceHotTrackItems>

        // <ceImmediatePopup>
        private void ceImmediatePopup_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            comboBoxEditSample.Properties.ImmediatePopup = ceImmediatePopup.Checked;
        }
        // </ceImmediatePopup>

        // <cePopupSizeable>
        private void cePopupSizeable_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            comboBoxEditSample.Properties.PopupSizeable = cePopupSizeable.Checked;
            // <seDropDownRows>
            seDropDownRows.Enabled = !cePopupSizeable.Checked;
            // </seDropDownRows>
        }
        // </cePopupSizeable>

        // <comboBoxEditSample>
        void ShowEditValue() {
            txtSelectedIndexValue.Text = string.Format("{0} / {1}", comboBoxEditSample.SelectedIndex, comboBoxEditSample.EditValue);
        }

        private void comboBoxEditSample_SelectedIndexChanged(object sender, System.EventArgs e) {
            ShowEditValue();
        }
        // </comboBoxEditSample>

        private void comboBoxEditSample_EditValueChanged(object sender, System.EventArgs e) {
            ShowEditValue();
        }

        // <ceCTRLScroll>
        private void ceCTRLScroll_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            comboBoxEditSample.Properties.UseCtrlScroll = ceCTRLScroll.Checked;
        }
        // </ceCTRLScroll>

        // <icbHighlightedItemStyle>
        private void icbHighlightedItemStyle_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            comboBoxEditSample.Properties.HighlightedItemStyle = (HighlightStyle)icbHighlightedItemStyle.EditValue;
        }
        // </icbHighlightedItemStyle>
    }
}

