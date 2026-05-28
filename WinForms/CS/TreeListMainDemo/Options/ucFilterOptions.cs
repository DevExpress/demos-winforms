using System;
using System.Windows.Forms;

namespace DevExpress.XtraTreeList.Demos.Options {
    public partial class ucFilterOptions : ucDefault {
        public ucFilterOptions() {
            InitializeComponent();
        }
        protected override void InitDataCore() {
            ceAllowFilter.Checked = TreeList.OptionsCustomization.AllowFilter;
            ceAutoFilterRow.Checked = TreeList.OptionsView.ShowAutoFilterRow;
            ceFilterEditor.Checked = TreeList.OptionsFilter.AllowFilterEditor;
            ceFilterList.Checked = TreeList.OptionsFilter.AllowMRUFilterList;
            ceShowAllValuesInFilterPopup.Checked = TreeList.OptionsFilter.ShowAllValuesInFilterPopup;
            cbFilterMode.Properties.Items.AddEnum(typeof(FilterMode));
            cbFilterMode.EditValue = TreeList.OptionsFilter.FilterMode;
            ieShowFilterPanelMode.Properties.Items.AddEnum(typeof(ShowFilterPanelMode));
            ieShowFilterPanelMode.EditValue = TreeList.OptionsView.ShowFilterPanelMode;
            InitEnabled();
        }
        bool isLoaded;
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            isLoaded = true;
        }
        private void InitEnabled() {
            ceColumnFilterList.Enabled = ceFilterEditor.Enabled = ceFilterList.Enabled = ceAutoFilterRow.Enabled = ieShowFilterPanelMode.Enabled = cbFilterMode.Enabled = ceShowAllValuesInFilterPopup.Enabled = ceAllowFilter.Checked;
        }
        //<ceAllowFilter>
        private void ceAllowFilter_CheckedChanged(object sender, System.EventArgs e) {
            TreeList.OptionsCustomization.AllowFilter = ceAllowFilter.Checked;
            if(isLoaded) {
                bool allow = TreeList.OptionsCustomization.AllowFilter;
                if(!allow)
                    TreeList.HideFindPanel();
                else {
                    if(TreeList.OptionsFind.AllowFindPanel)
                        TreeList.ShowFindPanel();
                }
                TreeList.OptionsView.ShowAutoFilterRow = allow ? ceAutoFilterRow.Checked : false;
                InitEnabled();
            }
        }
        //</ceAllowFilter>
        //<ceFilterEditor>
        private void ceFilterEditor_CheckedChanged(object sender, System.EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsFilter.AllowFilterEditor = ceFilterEditor.Checked;
        }
        //</ceFilterEditor>
        //<ceFilterList>
        private void ceFilterList_CheckedChanged(object sender, System.EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsFilter.AllowMRUFilterList = ceFilterList.Checked;
        }
        //</ceFilterList>
        //<ceAutoFilterRow>
        private void ceAutoFilterRow_CheckedChanged(object sender, System.EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsView.ShowAutoFilterRow = ceAutoFilterRow.Checked;
        }
        //<cbFilterMode>
        private void cbFilterMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsFilter.FilterMode = (FilterMode)cbFilterMode.EditValue;
        }
        //</cbFilterMode>       
        private void ceShowAllValuesInFilterPopup_CheckedChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsFilter.ShowAllValuesInFilterPopup = ceShowAllValuesInFilterPopup.Checked;
        }
        private void ieShowFilterPanelMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsView.ShowFilterPanelMode = (ShowFilterPanelMode)ieShowFilterPanelMode.SelectedIndex;
        }
        //<ceColumnFilterList>
        private void ceColumnFilterList_CheckedChanged(object sender, System.EventArgs e) {
            TreeList.OptionsFilter.AllowColumnMRUFilterList = ceColumnFilterList.Checked;
        }
        //</ceColumnFilterList>
    }
}
