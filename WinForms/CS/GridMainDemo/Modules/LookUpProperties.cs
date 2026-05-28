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
using DevExpress.XtraGrid.Views.Tile;

namespace DevExpress.XtraGrid.Demos {
    public partial class LookUpProperties : XtraUserControl {
        public LookUpProperties()
            : this(null) {
        }
        public LookUpProperties(GridLookUpEdit lookUp) {
            InitializeComponent();
            InitComboBoxes();
            InitLookUp(lookUp);
        }

        RepositoryItemGridLookUpEdit lookUpProperties;
        bool updateValues = false;
        public void InitLookUp(GridLookUpEdit lookUp) {
            if(lookUp == null) return;
            this.lookUpProperties = lookUp.Properties;
            updateValues = true;
            lbDisplay.Text = lookUpProperties.DisplayMember;
            lbValue.Text = lookUpProperties.ValueMember;
            icbTextEditStyle.EditValue = lookUpProperties.TextEditStyle;
            ceAutoComplete.Checked = lookUpProperties.AutoComplete;
            ceImmediatePopup.Checked = lookUpProperties.ImmediatePopup;
            cePopupSizeable.Checked = lookUpProperties.PopupSizeable;
            ceShowPopupFooter.Checked = lookUpProperties.ShowFooter;
            if(GridView == null)
                groupControlGridView.HideToCustomization();
            if(TileView == null)
                groupControlTiles.HideToCustomization();
            if(GridView != null) {
                ceShowAutoFilterRow.Checked = GridView.OptionsView.ShowAutoFilterRow;
                ceShowColumnHeaders.Checked = GridView.OptionsView.ShowColumnHeaders;
                ceShowIndicator.Checked = GridView.OptionsView.ShowIndicator;
                ceShowHorzLines.Checked = GridView.OptionsView.ShowHorizontalLines != DefaultBoolean.False;
                ceShowVerticalLines.Checked = GridView.OptionsView.ShowVerticalLines != DefaultBoolean.False;
                ceEnableAppearanceEvenRow.Checked = GridView.OptionsView.EnableAppearanceEvenRow;
                ceEnableAppearanceOddRow.Checked = GridView.OptionsView.EnableAppearanceOddRow;
            }
            if(TileView != null) {
                ceShowSeparators.Checked = TileView.OptionsList.DrawItemSeparators != Views.Tile.DrawItemSeparatorsMode.None;
                ceHighlightFocused.Checked = TileView.OptionsTiles.HighlightFocusedTileStyle == Views.Tile.HighlightFocusedTileStyle.Default;
                ceShowContextButton.Checked = TileView.ContextButtons[0].Visibility != ContextItemVisibility.Hidden;
                ceListLayout.Checked = TileView.OptionsTiles.LayoutMode == TileViewLayoutMode.List;
            }
            EnableProperties();
            updateValues = false;
        }
        DevExpress.XtraGrid.Views.Tile.TileView TileView {
            get {
                DevExpress.XtraGrid.Views.Tile.TileView view = lookUpProperties.PopupView as DevExpress.XtraGrid.Views.Tile.TileView;
                return view;
            }
        }
        GridView GridView {
            get {
                GridView view = lookUpProperties.View as GridView;
                return view;
            }
        }
        void InitComboBoxes() {
            foreach(TextEditStyles style in Enum.GetValues(typeof(TextEditStyles)))
                icbTextEditStyle.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<TextEditStyles>.GetTitle(style), style, -1));
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

        //<ceImmediatePopup>
        private void ceImmediatePopup_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            lookUpProperties.ImmediatePopup = ceImmediatePopup.Checked;
        }
        //</ceImmediatePopup>

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
            GridView.OptionsView.ShowAutoFilterRow = ceShowAutoFilterRow.Checked;
        }
        //</ceShowAutoFilterRow>

        //<ceShowColumnHeaders>
        private void ceShowColumnHeaders_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            GridView.OptionsView.ShowColumnHeaders = ceShowColumnHeaders.Checked;
        }
        //</ceShowColumnHeaders>

        //<ceShowIndicator>
        private void ceShowIndicator_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            GridView.OptionsView.ShowIndicator = ceShowIndicator.Checked;
        }
        //</ceShowIndicator>

        //<ceShowHorzLines>
        private void ceShowHorzLines_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            GridView.OptionsView.ShowHorizontalLines = ceShowHorzLines.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        //</ceShowHorzLines>

        //<ceShowVerticalLines>
        private void ceShowVerticalLines_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            GridView.OptionsView.ShowVerticalLines = ceShowVerticalLines.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        //</ceShowVerticalLines>

        //<ceEnableAppearanceEvenRow>
        private void ceEnableAppearanceEvenRow_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            GridView.OptionsView.EnableAppearanceEvenRow = ceEnableAppearanceEvenRow.Checked;
        }
        //</ceEnableAppearanceEvenRow>

        //<ceEnableAppearanceOddRow>
        private void ceEnableAppearanceOddRow_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            GridView.OptionsView.EnableAppearanceOddRow = ceEnableAppearanceOddRow.Checked;
        }
        //</ceEnableAppearanceOddRow>

        //<ceAutoComplete>
        private void ceAutoComplete_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            lookUpProperties.AutoComplete = ceAutoComplete.Checked;
        }
        //</ceAutoComplete>

        private void ceShowSeparators_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            var value = ceShowSeparators.Checked ? DrawItemSeparatorsMode.All : DrawItemSeparatorsMode.None;
            TileView.OptionsList.DrawItemSeparators = value;
        }

        private void ceHighlightFocused_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            var value = ceHighlightFocused.Checked ? HighlightFocusedTileStyle.Default : HighlightFocusedTileStyle.None;
            TileView.OptionsTiles.HighlightFocusedTileStyle = value;
        }

        private void ceListLayout_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            TileView.OptionsTiles.LayoutMode = ceListLayout.Checked ? TileViewLayoutMode.List : TileViewLayoutMode.Default;
        }

        private void ceShowContextButton_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            TileView.ContextButtons[0].Visibility = ceShowContextButton.Checked ? ContextItemVisibility.Auto : ContextItemVisibility.Hidden;
        }
    }
}
