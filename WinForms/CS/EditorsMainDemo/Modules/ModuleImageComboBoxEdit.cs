using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors;
// <icbAlignment>
// <icbShowDropDown>
// <imageComboBoxEdit1>
using DevExpress.XtraEditors.Controls;
// </imageComboBoxEdit1>
// </icbShowDropDown>
using DevExpress.Utils;
// </icbAlignment>
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleImageComboBoxEdit : TutorialControl  {
        public ModuleImageComboBoxEdit() {
            InitializeComponent();
            if(tabPane1 != null)
                tabPane1.SelectedPageChanged += OnSelectedPageChanged;
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleImageComboBoxEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "imagecomboboxedit"; } }

        void OnSelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            CalcContentCore();
        }
        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            if(tabPane1 != null)
                tabPane1.SelectedPageChanged -= OnSelectedPageChanged;
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
            CalcLayoutControlBounds(layoutControl2);
        }

        bool updateValues = false;

        private void ModuleImageComboBoxEdit_Load(object sender, System.EventArgs e) {
            DevExpress.Tutorials.ControlUtils.CenterControlInParent(imageComboBoxEditSample);
            InitSamples();
            InitComboBoxes();
            InitValues();
        }

        void InitSamples() {
            imageComboBoxEdit2.Properties.Items.AddEnum(typeof(ButtonPredefines));
        }

        void InitComboBoxes() {
            // <icbShowDropDown>
            icbShowDropDown.Properties.Items.AddEnum(typeof(ShowDropDown));
            // </icbShowDropDown>
            // <icbAlignment>
            icbAlignment.Properties.Items.AddEnum(typeof(HorzAlignment));
            // </icbAlignment>
            // <icbHighlightedItemStyle>
            icbHighlightedItemStyle.Properties.Items.AddEnum(typeof(HighlightStyle));
            // </icbHighlightedItemStyle>
        }


        void InitValues() {
            updateValues = true;
            imageComboBoxEditSample.SelectedIndex = 0;
            imageComboBoxEdit1.SelectedIndex = 2;
            imageComboBoxEdit2.SelectedIndex = 0;
            imageComboBoxEdit3.SelectedIndex = 0;
            icbShowDropDown.EditValue = imageComboBoxEditSample.Properties.ShowDropDown;
            icbHighlightedItemStyle.EditValue = imageComboBoxEditSample.Properties.HighlightedItemStyle;
            seDropDownRows.Value = imageComboBoxEditSample.Properties.DropDownRows;
            ceAutoComplete.Checked = imageComboBoxEditSample.Properties.AutoComplete;
            ceCycleOnDblClick.Checked = imageComboBoxEditSample.Properties.CycleOnDblClick;
            ceHotTrackItems.Checked = imageComboBoxEditSample.Properties.HotTrackItems;
            ceImmediatePopup.Checked = imageComboBoxEditSample.Properties.ImmediatePopup;
            cePopupSizeable.Checked = imageComboBoxEditSample.Properties.PopupSizeable;
            ceCTRLScroll.Checked = imageComboBoxEditSample.Properties.UseCtrlScroll;
            icbAlignment.EditValue = imageComboBoxEditSample.Properties.GlyphAlignment;
            seDropDownRows.Enabled = !imageComboBoxEditSample.Properties.PopupSizeable;
            ceCycleOnDblClick.Enabled = imageComboBoxEditSample.Properties.ShowDropDown == ShowDropDown.Never;
            updateValues = false;
        }

        // <icbShowDropDown>
        private void icbShowDropDown_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageComboBoxEditSample.Properties.ShowDropDown = (ShowDropDown)icbShowDropDown.EditValue;
            // <ceCycleOnDblClick>
            ceCycleOnDblClick.Enabled = imageComboBoxEditSample.Properties.ShowDropDown == ShowDropDown.Never;
            // </ceCycleOnDblClick>
        }
        // </icbShowDropDown>
        // <seDropDownRows>
        private void seDropDownRows_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageComboBoxEditSample.Properties.DropDownRows = Convert.ToInt32(seDropDownRows.Value);
        }
        // </seDropDownRows>

        // <ceAutoComplete>
        private void ceAutoComplete_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageComboBoxEditSample.Properties.AutoComplete = ceAutoComplete.Checked;
        }
        // </ceAutoComplete>

        // <ceCycleOnDblClick>
        private void ceCycleOnDblClick_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageComboBoxEditSample.Properties.CycleOnDblClick = ceCycleOnDblClick.Checked;
        }
        // </ceCycleOnDblClick>

        // <ceHotTrackItems>
        private void ceHotTrackItems_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageComboBoxEditSample.Properties.HotTrackItems = ceHotTrackItems.Checked;
        }
        // </ceHotTrackItems>

        // <ceImmediatePopup>
        private void ceImmediatePopup_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageComboBoxEditSample.Properties.ImmediatePopup = ceImmediatePopup.Checked;
        }
        // </ceImmediatePopup>

        // <cePopupSizeable>
        private void cePopupSizeable_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageComboBoxEditSample.Properties.PopupSizeable = cePopupSizeable.Checked;
            // <seDropDownRows>
            seDropDownRows.Enabled = !cePopupSizeable.Checked;
            // </seDropDownRows>
        }
        // </cePopupSizeable>

        // <ceCTRLScroll>
        private void ceCTRLScroll_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageComboBoxEditSample.Properties.UseCtrlScroll = ceCTRLScroll.Checked;
        }
        // </ceCTRLScroll>

        // <icbAlignment>
        private void icbAlignment_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageComboBoxEditSample.Properties.GlyphAlignment = (HorzAlignment)icbAlignment.EditValue;
        }
        // </icbAlignment>

        // <ceLargeImages>
        private void ceLargeImages_CheckedChanged(object sender, System.EventArgs e) {
            imageComboBoxEditSample.Properties.LargeImages = ceLargeImages.Checked ? svgImageCollection2 : null;
        }
        // </ceLargeImages>

        // <imageComboBoxEdit1>
        void ShowValues(TextEdit edit, ImageComboBoxEdit comboBox) {
            if(comboBox == null) return;
            ImageComboBoxItem item = comboBox.SelectedItem as ImageComboBoxItem;
            if(item != null)
                edit.Text = string.Format("{0} / {1} / \"{2}\"",
                    comboBox.SelectedIndex, item.Value, item.Description);
            else edit.Text = "Item is null";
        }

        private void imageComboBoxEdit1_EditValueChanged(object sender, System.EventArgs e) {
            ShowValues(teImageComboBoxEdit1, sender as ImageComboBoxEdit);
        }
        // </imageComboBoxEdit1>

        private void imageComboBoxEdit2_EditValueChanged(object sender, System.EventArgs e) {
            ShowValues(teImageComboBoxEdit2, sender as ImageComboBoxEdit);
        }

        private void imageComboBoxEdit3_EditValueChanged(object sender, System.EventArgs e) {
            ShowValues(teImageComboBoxEdit3, sender as ImageComboBoxEdit);
        }

        // <icbHighlightedItemStyle>
        private void icbHighlightedItemStyle_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            imageComboBoxEditSample.Properties.HighlightedItemStyle = (HighlightStyle)icbHighlightedItemStyle.EditValue;
        }
        // </icbHighlightedItemStyle>
    }
}

