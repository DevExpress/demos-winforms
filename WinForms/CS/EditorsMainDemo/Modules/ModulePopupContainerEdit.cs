using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <icbShowDropDown>
// <popupContainerEditSample>
using DevExpress.XtraEditors.Controls;
// </popupContainerEditSample>
// </icbShowDropDown>
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Globalization;
using DevExpress.Tutorials;


namespace DevExpress.XtraEditors.Demos {
    public partial class ModulePopupContainerEdit : TutorialControl  {
        public ModulePopupContainerEdit() {
            InitializeComponent();
            this.splitContainerControl1.Panel1.DockPadding.All = 4;
            this.splitContainerControl1.Panel2.DockPadding.All = 4;
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModulePopupContainerEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "popupcontaineredit"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        bool updateValues = false;

        // <popupContainerEditSample>
        Font CurrentFont {
            get { return lbSample.Font; }
            set { lbSample.Font = value; }
        }
        // </popupContainerEditSample>

        string CurrentFontCaption {
            get { return string.Format("{0}, {1}, {2}", CurrentFont.Name, CurrentFont.Size.ToString(CultureInfo.InvariantCulture), CurrentFont.Style); }
        }

        // <popupContainerEditSample>
        string CurrentFontStyle {
            get { return CurrentFont.Style.ToString(); }
        }
        // </popupContainerEditSample>
        private void ModulePopupContainerEdit_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(popupContainerEditSample);
            DevExpress.Tutorials.TutorialHelper.InitFont(ilbFont, ScaleDPI);
            
            SetFontCaption();
            InitComboBoxes();
            InitValues();
        }

        void InitComboBoxes() {
            // <icbShowDropDown>
            icbShowDropDown.Properties.Items.AddEnum(typeof(ShowDropDown));
            // </icbShowDropDown>
        }


        void InitValues() {
            updateValues = true;
            ceCloseOnOuterMouseClick.Checked = popupContainerEditSample.Properties.CloseOnOuterMouseClick;
            icbShowDropDown.EditValue = popupContainerEditSample.Properties.ShowDropDown;
            cePopupSizeable.Checked = popupContainerEditSample.Properties.PopupSizeable;
            ceShowPopupCloseButton.Checked = popupContainerEditSample.Properties.ShowPopupCloseButton;
            ceShowPopupShadow.Checked = popupContainerEditSample.Properties.ShowPopupShadow;
            updateValues = false;
        }

        void SetFontCaption() {
            popupContainerEditSample.EditValue = CurrentFontCaption;
        }

        // <popupContainerEditSample>
        private void popupContainerEditSample_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e) {
            ilbFont.SelectedValue = CurrentFont.Name;
            seSize.Value = Convert.ToDecimal(CurrentFont.Size);
            foreach(CheckedListBoxItem item in clbStyle.Items)
                item.CheckState = (CurrentFontStyle.IndexOf(item.Value.ToString()) > -1) ? CheckState.Checked : CheckState.Unchecked;
        }
        // </popupContainerEditSample>

        // <popupContainerEditSample>
        FontStyle GetFontStyleByValues(CheckedListBoxControl clb) {
            FontStyle ret = new FontStyle();
            if(clb.GetItemChecked(0)) ret |= FontStyle.Bold;
            if(clb.GetItemChecked(1)) ret |= FontStyle.Italic;
            if(clb.GetItemChecked(2)) ret |= FontStyle.Strikeout;
            if(clb.GetItemChecked(3)) ret |= FontStyle.Underline;
            return ret;
        }

        private void popupContainerEditSample_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e) {
            CurrentFont = new Font(ilbFont.SelectedValue.ToString(), Convert.ToSingle(seSize.Value), GetFontStyleByValues(clbStyle));
            e.Value = CurrentFontCaption;
        }
        // </popupContainerEditSample>

        void ClosePopup() {
            if(popupContainerControlSample.OwnerEdit != null)
                popupContainerControlSample.OwnerEdit.ClosePopup();
        }

        private void ilbFont_DoubleClick(object sender, System.EventArgs e) {
            ClosePopup();
        }

        private void popupFont_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                popupContainerControlSample.FindForm().Validate();
                ClosePopup();
            }
        }

        // <ceCloseOnOuterMouseClick>
        private void ceCloseOnOuterMouseClick_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            popupContainerEditSample.Properties.CloseOnOuterMouseClick = ceCloseOnOuterMouseClick.Checked;
        }
        // </ceCloseOnOuterMouseClick>

        // <icbShowDropDown>
        private void icbShowDropDown_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            popupContainerEditSample.Properties.ShowDropDown = (ShowDropDown)icbShowDropDown.EditValue;
        }
        // </icbShowDropDown>

        // <cePopupSizeable>
        private void cePopupSizeable_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            popupContainerEditSample.Properties.PopupSizeable = cePopupSizeable.Checked;
        }
        // </cePopupSizeable>

        // <ceShowPopupCloseButton>
        private void ceShowPopupCloseButton_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            popupContainerEditSample.Properties.ShowPopupCloseButton = ceShowPopupCloseButton.Checked;
        }
        // </ceShowPopupCloseButton>

        // <ceShowPopupShadow>
        private void ceShowPopupShadow_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            popupContainerEditSample.Properties.ShowPopupShadow = ceShowPopupShadow.Checked;
        }
        // </ceShowPopupShadow>
    }
}

