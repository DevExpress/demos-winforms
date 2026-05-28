using System;
using DataFiltering = DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.ViewInfo;
using System.Windows.Forms;
using DevExpress.Utils;

namespace DevExpress.XtraTreeList.Demos.Options {
    public partial class ucFindOptions : ucDefault {
        public ucFindOptions() {
            InitializeComponent();
        }
        protected override void InitDataCore() {
            //<layoutControl.customizationLayoutGroup>
            ceAllowFindPanel.Checked = TreeList.OptionsFind.AllowFindPanel;
            BindTo(ceHighlightFindResults, "Checked", TreeList.OptionsFind, "HighlightFindResults");
            BindTo(ceShowCloseButton, "Checked", TreeList.OptionsFind, "ShowCloseButton");
            BindTo(ceShowClearButton, "Checked", TreeList.OptionsFind, "ShowClearButton");
            BindTo(ceShowFindButton, "Checked", TreeList.OptionsFind, "ShowFindButton");
            BindTo(ceShowSearchNavButtons, "Checked", TreeList.OptionsFind, "ShowSearchNavButtons");
            ceExpandNodesOnSearch.Checked = TreeList.OptionsFind.ExpandNodesOnSearch != DefaultBoolean.False;
            //</layoutControl.customizationLayoutGroup>
            //<layoutControl.lgBehavior>
            InitImageComboBox<DataFiltering.FilterCondition>(imgFilterCondition, TreeList.OptionsFind.Condition);
            BindTo(imgFilterCondition, "EditValue", TreeList.OptionsFind, "Condition");
            InitImageComboBox<DataFiltering.FindPanelParserKind>(imgParserKind, TreeList.OptionsFind.ParserKind);
            BindTo(imgParserKind, "EditValue", TreeList.OptionsFind, "ParserKind");
            InitImageComboBox<XtraEditors.FindPanelBehavior>(imgBehavior, TreeList.OptionsFind.Behavior);
            //</layoutControl.lgBehavior>
            //<layoutControl.actionLayoutGroup>
            ceAlwaysVisible.Checked = TreeList.OptionsFind.AlwaysVisible;
            BindTo(ceClearFindPanelOnClose, "Checked", TreeList.OptionsFind, "ClearFindOnClose");
            InitImageComboBox<FindMode>(cbFindMode, TreeList.OptionsFind.FindMode);
            BindTo(cbFindMode, "EditValue", TreeList.OptionsFind, "FindMode");
            //</layoutControl.actionLayoutGroup>
            InitFindFilterColumns(TreeList.Columns);
            InitValues();
            UpdateFindPanelButtons();
        }
        void BindTo(Control source, string propertyName, object target, string member) {
            source.DataBindings.Add(propertyName, target, member, false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
        }
        void InitImageComboBox<TEnum>(XtraEditors.ImageComboBoxEdit comboBox, object value) {
            comboBox.EditValue = value;
            comboBox.Properties.AddEnum<TEnum>();
        }
        void InitFindFilterColumns(TreeListColumnCollection findFilterColumns) {
            cbFindFilterColumns.Properties.Items.Add(new ImageComboBoxItem("*", "*"));
            for(int i = 0; i < findFilterColumns.Count; i++) {
                string captions = findFilterColumns[i].GetCaption();
                string fieldNames = findFilterColumns[i].FieldName;
                for(int j = i; j < findFilterColumns.Count; j++) {
                    if(j != i) {
                        captions += string.Format(";{0}", findFilterColumns[j].GetCaption());
                        fieldNames += string.Format(";{0}", findFilterColumns[j].FieldName);
                    }
                    cbFindFilterColumns.Properties.Items.Add(new ImageComboBoxItem(captions, fieldNames));
                }
            }
            cbFindFilterColumns.EditValue = TreeList.OptionsFind.FindFilterColumns;
        }
        //<layoutControl.customizationLayoutGroup>
        private void ceAllowFindPanel_CheckedChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsFind.AllowFindPanel = ceAllowFindPanel.Checked;
            InitValues();
        }
        private void ceExpandNodesOnSearch_CheckedChanged(object sender, EventArgs e) {
            TreeList.OptionsFind.ExpandNodesOnSearch = ceExpandNodesOnSearch.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        //</layoutControl.customizationLayoutGroup>
        void InitValues() {
            ceAlwaysVisible.Enabled = TreeList.OptionsFind.AllowFindPanel;
            if(!TreeList.OptionsFind.AllowFindPanel) {
                ceAlwaysVisible.Checked = false;
                TreeList.HideFindPanel();
            }
            else {
                TreeList.ShowFindPanel();
            }
            ceShowCloseButton.Enabled = !TreeList.OptionsFind.AlwaysVisible;
        }
        //<layoutControl.actionLayoutGroup>
        private void ceAlwaysVisible_CheckedChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsFind.AlwaysVisible = ceAlwaysVisible.Checked;
            InitValues();
        }
        private void seFindDelay_EditValueChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsFind.FindDelay = Convert.ToInt32(seFindDelay.Value);
        }
        private void cbFindFilterColumns_SelectedIndexChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsFind.FindFilterColumns = string.Format("{0}", cbFindFilterColumns.EditValue);
            string findText = TreeList.FindFilterText;
            TreeList.ApplyFindFilter(string.Empty);
            TreeList.ApplyFindFilter(findText);
        }
        //</layoutControl.actionLayoutGroup>
        //<layoutControl.lgBehavior>
        private void imgBehavior_SelectedIndexChanged(object sender, EventArgs e) {
            if(IsInitializing || TreeList == null)
                return;
            TreeList.OptionsFind.Behavior = (XtraEditors.FindPanelBehavior)imgBehavior.EditValue;
            UpdateFindPanelButtons();
        }
        //</layoutControl.lgBehavior>
        void UpdateFindPanelButtons() {
            ceShowFindButton.Enabled = ceShowClearButton.Enabled = TreeList.OptionsFind.Behavior != XtraEditors.FindPanelBehavior.Search;
            ceShowSearchNavButtons.Enabled = TreeList.OptionsFind.Behavior == XtraEditors.FindPanelBehavior.Search;
        }
    }
}
