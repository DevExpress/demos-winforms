using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.DXperience.Demos;
using DevExpress.Data.Filtering;

namespace DevExpress.XtraGrid.Demos {
    public partial class ucFindOptions : XtraUserControl {
        GridView view = null;
        readonly string customButtonName = "customButton";
        public ucFindOptions() {
            InitializeComponent();
            InitEditors();
        }
        bool updateValues = false;
        public void InitData(GridView view, List<ImageComboBoxItem> findFilterColumns) {
            this.view = view;
            cbFindFilterColumns.Properties.Items.AddRange(findFilterColumns);
            updateValues = true;
            icbFindPanelBehavior.EditValue = view.OptionsFind.Behavior;
            ceAllowFindFilter.Checked = view.OptionsFind.AllowFindPanel;
            ceAllowMRUItems.Checked = view.OptionsFind.AllowMruItems;
            ceAlwaysVisible.Checked = view.OptionsFind.AlwaysVisible;
            ceClearFind.Checked = view.OptionsFind.ClearFindOnClose;
            ceHighlightFindResults.Checked = view.OptionsFind.HighlightFindResults;
            ceShowCloseButton.Checked = view.OptionsFind.ShowCloseButton;
            seFindDelay.Value = view.OptionsFind.FindDelay;
            cbFindFilterColumns.EditValue = view.OptionsFind.FindFilterColumns;
            icbFindMode.EditValue = view.OptionsFind.FindMode;
            ceShowClearButton.Checked = view.OptionsFind.ShowClearButton;
            ceShowFindButton.Checked = view.OptionsFind.ShowFindButton;
            ceShowNavButtons.Checked = view.OptionsFind.ShowSearchNavButtons;
            ceSearchInPreview.Checked = view.OptionsFind.SearchInPreview;
            icbParserKind.EditValue = view.OptionsFind.ParserKind;
            icbFilterCondition.EditValue = view.OptionsFind.Condition;
            updateValues = false;
            InitValues();
        }
        void InitEditors() {
            foreach(FindMode mode in Enum.GetValues(typeof(FindMode)))
                icbFindMode.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<FindMode>.GetTitle(mode), mode, -1));
            foreach(FindPanelBehavior b in Enum.GetValues(typeof(FindPanelBehavior)))
                icbFindPanelBehavior.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<FindPanelBehavior>.GetTitle(b), b, -1));
            foreach(FindPanelParserKind kind in Enum.GetValues(typeof(FindPanelParserKind)))
                icbParserKind.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<FindPanelParserKind>.GetTitle(kind), kind, -1));
            foreach(FilterCondition condition in Enum.GetValues(typeof(FilterCondition)))
                icbFilterCondition.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<FilterCondition>.GetTitle(condition), condition, -1));
        }
        public int MinHeight {
            get { return layoutControl1.Root.MinSize.Height; }
        }
        void InitValues() {
            bool isSearchMode = view.OptionsFind.Behavior == FindPanelBehavior.Search;
            ceAlwaysVisible.Enabled = view.OptionsFind.AllowFindPanel;
            if(!view.OptionsFind.AllowFindPanel) {
                ceAlwaysVisible.Checked = false;
                view.HideFindPanel();
            }
            else {
                view.ShowFindPanel();
            }
            ceShowCloseButton.Enabled = !view.OptionsFind.AlwaysVisible;
            ceShowClearButton.Enabled = !isSearchMode;
            ceShowFindButton.Enabled = !isSearchMode;
            ceShowNavButtons.Enabled = isSearchMode;
        }
        //<ceAllowFindFilter>
        void ceAllowFindFilter_CheckedChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.AllowFindPanel = edit.Checked;
            InitValues();
        }
        //</ceAllowFindFilter>
        //<ceAlwaysVisible>
        void ceAlwaysVisible_CheckedChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.AlwaysVisible = edit.Checked;
            InitValues();
        }
        //</ceAlwaysVisible>

        //<ceClearFind>
        void ceClearFind_CheckedChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.ClearFindOnClose = edit.Checked;
        }
        //</ceClearFind>

        //<ceHighlightFindResults>
        void ceHighlightFindResults_CheckedChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.HighlightFindResults = edit.Checked;
        }
        //</ceHighlightFindResults>

        //<ceShowCloseButton>
        void ceShowCloseButton_CheckedChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.ShowCloseButton = edit.Checked;
        }
        //</ceShowCloseButton>

        //<seFindDelay>
        void seFindDelay_EditValueChanged(object sender, EventArgs e) {
            SpinEdit edit = sender as SpinEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.FindDelay = Convert.ToInt32(edit.Value);
        }
        //</seFindDelay>
        //<cbFindFilterColumns>
        void cbFindFilterColumns_EditValueChanged(object sender, EventArgs e) {
            BaseEdit edit = sender as BaseEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.FindFilterColumns = string.Format("{0}", edit.EditValue);
            RefreshFindFilter();
        }
        
        void RefreshFindFilter() {
            string findText = view.FindFilterText;
            view.ApplyFindFilter(string.Empty);
            view.ApplyFindFilter(findText);
        }
        //</cbFindFilterColumns>
        //<icbFindMode>
        void icbFindMode_SelectedIndexChanged(object sender, EventArgs e) {
            BaseEdit edit = sender as BaseEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.FindMode = (FindMode)edit.EditValue;
        }
        //</icbFindMode>
        //<ceShowClearButton>
        void ceShowClearButton_CheckedChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.ShowClearButton = edit.Checked;
        }
        //</ceShowClearButton>

        //<ceShowFindButton>
        void ceShowFindButton_CheckedChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.ShowFindButton = edit.Checked;
        }
        //</ceShowFindButton>
        //<ceShowNavButtons>
        void ceShowNavButtons_CheckedChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.ShowSearchNavButtons = edit.Checked;
        }
        //</ceShowNavButtons>
        //<ceSearchInPreview>
        void ceSearchInPreview_CheckedChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsView.ShowPreview = edit.Checked;
            view.OptionsFind.SearchInPreview = edit.Checked;
        }
        //</ceSearchInPreview>
        //<icbFindPanelBehavior>
        void icbFindPanelBehavior_SelectedIndexChanged(object sender, EventArgs e) {
            BaseEdit edit = sender as BaseEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.Behavior = (FindPanelBehavior)edit.EditValue;
            InitValues();
        }
        //</icbFindPanelBehavior>
        //<icbParserKind>
        private void icbParserKind_SelectedIndexChanged(object sender, EventArgs e) {
            BaseEdit edit = sender as BaseEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.ParserKind = (FindPanelParserKind)edit.EditValue;
            RefreshFindFilter();
        }
        //</icbParserKind>
        //<icbFilterCondition>
        private void icbFilterCondition_SelectedIndexChanged(object sender, EventArgs e) {
            BaseEdit edit = sender as BaseEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.Condition = (FilterCondition)edit.EditValue;
            RefreshFindFilter();
        }
        //</icbFilterCondition>
        //<ceAllowMRUItems>
        private void ceAllowMRUItems_CheckedChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            if(updateValues || view == null || edit == null) return;
            view.OptionsFind.AllowMruItems = edit.Checked;
        }
        //</ceAllowMRUItems>
        //<ceShowCustomButton>
        CheckButton showCustomButton = null;
        private void ceShowCustomButton_CheckedChanged(object sender, EventArgs e) {
            CheckEdit customButton = sender as CheckEdit;
            if(customButton.Checked) {
                showCustomButton = view.FindPanelItems.AddCheckButton(customButtonName, null, view.OptionsFind.Behavior != FindPanelBehavior.Search,
                    (button, args) => {
                        CheckButton checkButton = button as CheckButton;
                        view.OptionsFind.Behavior = checkButton.Checked ? FindPanelBehavior.Filter : FindPanelBehavior.Search;
                        checkButton.ToolTip = "Find Panel Mode";
                        icbFindPanelBehavior.EditValue = view.OptionsFind.Behavior;
                    });
                showCustomButton.ImageOptions.ImageUri.Uri = "Filter;Size16x16;Svg";
            }
            else {
                showCustomButton = null;
                view.FindPanelItems.RemoveItem(customButtonName);
            }
            icbFindPanelBehavior.Enabled = showCustomButton == null;
        }
        //</ceShowCustomButton>
    }
}
