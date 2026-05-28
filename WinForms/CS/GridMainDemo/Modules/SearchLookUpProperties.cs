using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public partial class SearchLookUpProperties : XtraUserControl {
        public SearchLookUpProperties()
            : this(null) {
        }
        public SearchLookUpProperties(SearchLookUpEdit lookUp) : this(lookUp, true) { }
        public SearchLookUpProperties(SearchLookUpEdit lookUp, bool showAddNewButton) {
            InitializeComponent();
            InitComboBoxes();
            InitLookUp(lookUp);
            ceShowAddNewButton.Enabled = showAddNewButton;
        }

        RepositoryItemSearchLookUpEdit lookUpProperties;
        bool updateValues = false;
        public void InitLookUp(SearchLookUpEdit lookUp) {
            if(lookUp == null) return;
            this.lookUpProperties = lookUp.Properties;
            updateValues = true;
            lbDisplay.Text = lookUpProperties.DisplayMember;
            lbValue.Text = lookUpProperties.ValueMember;
            icbTextEditStyle.EditValue = lookUpProperties.TextEditStyle;
            icbFilterMode.EditValue = lookUpProperties.PopupFilterMode;
            icbFindMode.EditValue = lookUpProperties.PopupFindMode;
            cePopupSizeable.Checked = lookUpProperties.PopupSizeable;
            ceShowPopupFooter.Checked = lookUpProperties.ShowFooter;
            ceShowAddNewButton.Checked = lookUpProperties.ShowAddNewButton;
            ceShowClearButton.Checked = lookUpProperties.ShowClearButton;
            ceShowAutoFilterRow.Checked = View.OptionsView.ShowAutoFilterRow;
            ceShowColumnHeaders.Checked = View.OptionsView.ShowColumnHeaders;
            ceShowIndicator.Checked = View.OptionsView.ShowIndicator;
            ceShowHorzLines.Checked = View.OptionsView.ShowHorizontalLines != DevExpress.Utils.DefaultBoolean.False;
            ceShowVerticalLines.Checked = View.OptionsView.ShowVerticalLines != DevExpress.Utils.DefaultBoolean.False;
            ceEnableAppearanceEvenRow.Checked = View.OptionsView.EnableAppearanceEvenRow;
            ceEnableAppearanceOddRow.Checked = View.OptionsView.EnableAppearanceOddRow;
            EnableProperties();
            updateValues = false;
        }
        GridView View {
            get {
                GridView viewCore = lookUpProperties.View as GridView;
                return viewCore;
            }
        }
        void InitComboBoxes() {
            foreach(TextEditStyles style in Enum.GetValues(typeof(TextEditStyles)))
                if(style != TextEditStyles.Standard)
                    icbTextEditStyle.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<TextEditStyles>.GetTitle(style), style, -1));
            foreach(PopupFilterMode mode in Enum.GetValues(typeof(PopupFilterMode)))
                icbFilterMode.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<PopupFilterMode>.GetTitle(mode), mode, -1));
            foreach(FindMode mode in Enum.GetValues(typeof(FindMode)))
                icbFindMode.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<FindMode>.GetTitle(mode), mode, -1));
        }
        void EnableProperties() {
            cePopupSizeable.Enabled = lookUpProperties.ShowFooter;
        }

        private void LookUpProperties_Load(object sender, System.EventArgs e) {
        }

        //<icbTextEditStyle>
        private void icbTextEditStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            lookUpProperties.TextEditStyle = (TextEditStyles)icbTextEditStyle.EditValue;
        }
        //</icbTextEditStyle>

        //<cePopupSizeable>
        private void cePopupSizeable_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            lookUpProperties.PopupSizeable = cePopupSizeable.Checked;
        }
        //</cePopupSizeable>

        //<ceShowPopupFooter>
        private void ceShowPopupFooter_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            lookUpProperties.ShowFooter = ceShowPopupFooter.Checked;
            EnableProperties();
        }
        //</ceShowPopupFooter>

        //<ceShowAutoFilterRow>
        private void ceShowAutoFilterRow_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.ShowAutoFilterRow = ceShowAutoFilterRow.Checked;
        }
        //</ceShowAutoFilterRow>

        //<ceShowColumnHeaders>
        private void ceShowColumnHeaders_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.ShowColumnHeaders = ceShowColumnHeaders.Checked;
        }
        //</ceShowColumnHeaders>

        //<ceShowIndicator>
        private void ceShowIndicator_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.ShowIndicator = ceShowIndicator.Checked;
        }
        //</ceShowIndicator>

        //<ceShowHorzLines>
        private void ceShowHorzLines_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.ShowHorizontalLines = ceShowHorzLines.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        //</ceShowHorzLines>

        //<ceShowVerticalLines>
        private void ceShowVerticalLines_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.ShowVerticalLines = ceShowVerticalLines.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        //</ceShowVerticalLines>

        //<ceEnableAppearanceEvenRow>
        private void ceEnableAppearanceEvenRow_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.EnableAppearanceEvenRow = ceEnableAppearanceEvenRow.Checked;
        }
        //</ceEnableAppearanceEvenRow>

        //<ceEnableAppearanceOddRow>
        private void ceEnableAppearanceOddRow_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            View.OptionsView.EnableAppearanceOddRow = ceEnableAppearanceOddRow.Checked;
        }
        //</ceEnableAppearanceOddRow>

        //<ceShowAddNewButton>
        private void ceShowAddNewButton_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            lookUpProperties.ShowAddNewButton = ceShowAddNewButton.Checked;
        }
        //</ceShowAddNewButton>

        //<ceShowClearButton>
        private void ceShowClearButton_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            lookUpProperties.ShowClearButton = ceShowClearButton.Checked;
        }
        //</ceShowClearButton>

        //<icbFilterMode>
        private void icbFilterMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            lookUpProperties.PopupFilterMode = (PopupFilterMode)icbFilterMode.EditValue;
        }
        //</icbFilterMode>

        //<icbFindMode>
        private void icbFindMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(updateValues) return;
            lookUpProperties.PopupFindMode = (FindMode)icbFindMode.EditValue;
        }
        //</icbFindMode>



    }
}
