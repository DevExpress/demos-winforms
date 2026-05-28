using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
// <icbAlignment>
// <icbSelectionMode>
// <icbSortOrder>
using DevExpress.XtraEditors.Controls;
// </icbSortOrder>
// </icbSelectionMode>
using DevExpress.Utils;
// </icbAlignment>

namespace DevExpress.XtraEditors.Demos {
    public partial class ListBoxProperties : XtraUserControl {
        CheckedListBoxControl CheckedListBox { get { return listBoxCore as CheckedListBoxControl; } }
        ImageListBoxControl ImageListBox { get { return listBoxCore as ImageListBoxControl; } }
        ListBoxControl ListBox { get { return listBoxCore as ListBoxControl; } }
        bool IsTemplatedListBox { get { return ListBox != null && ListBox.Templates.Count > 0; } }
        public ListBoxProperties() {
            InitializeComponent();
            InitComboBoxes();
            InitSearchControlProperties();
        }

        BaseListBoxControl listBoxCore;
        bool updateValues = false;
        readonly object searchControlPropertyChangedCore = new object();
        public event PropertyChangedEventHandler SearchControlPropertyChanged {
            add { Events.AddHandler(searchControlPropertyChangedCore, value); }
            remove { Events.RemoveHandler(searchControlPropertyChangedCore, value); }
        }
        // <ceAllowAutoApply>      
        // <ceShowSearchButton>        
        // <ceShowClearButton>
        // <ceShowMRUButton>
        // <tbFindDelay>
        // <cbFilterCondition>
        // <cbShowDefaultButtonsMode>
        // <searchControlSample>
        protected void RaiseSearchControlPropertyChanged(string propertyName, object value) {
            PropertyChangedEventHandler handler = (PropertyChangedEventHandler)Events[searchControlPropertyChangedCore];
            if(handler != null)
                handler(this, new PropertyValueChangedEventArgs(propertyName, value));
        }
        // </ceAllowAutoApply>      
        // </ceShowSearchButton>        
        // </ceShowClearButton>
        // </ceShowMRUButton>
        // </tbFindDelay>
        // </cbFilterCondition>
        // </cbShowDefaultButtonsMode>
        // </searchControlSample>
        public void InitListBox(BaseListBoxControl listBox) {
            this.listBoxCore = listBox;
            updateValues = true;
            icbSelectionMode.EditValue = listBox.SelectionMode;
            icbSortOrder.EditValue = listBox.SortOrder;
            icbHighlightedItemStyle.EditValue = listBox.HighlightedItemStyle;
            icbHotTrackSelectMode.EditValue = listBox.HotTrackSelectMode;
            seColumnWidth.Value = listBox.ColumnWidth;
            ceHotTrack.Checked = listBox.HotTrackItems;
            ceMultiColumn.Checked = listBox.MultiColumn;
            seColumnWidth.Enabled = listBox.MultiColumn;
            // <icbSelectionMode>
            icbSelectionMode.Enabled = CheckedListBox == null;
            // </icbSelectionMode>
            if(ImageListBox != null) icbAlignment.EditValue = ImageListBox.GlyphAlignment;
            if(CheckedListBox != null) ceCheckOnClick.Checked = CheckedListBox.CheckOnClick;
            groupControlSearch.Visible = (ListBox != null && !IsTemplatedListBox && ceTurnSearch.Checked);
            ceMultiColumn.Enabled = !IsTemplatedListBox;
            ceAutoHeight.Enabled = IsTemplatedListBox;
            ceAutoHeight.Checked = IsTemplatedListBox && listBox.ItemAutoHeight;
            //ceTurnSearch.Enabled = ListBox != null;
            ceTurnSearch.Checked = (listBox as ISearchControlClient).IsAttachedToSearchControl;
            groupControlChecked.Visible = CheckedListBox != null;
            groupControlImage.Visible = ImageListBox != null;
            groupControlTemplated.Visible = IsTemplatedListBox;
            icbSortOrder.Enabled = listBox.DataSource == null;
            ceHotTrack.Enabled = AllowHotTrack;
            ceIncrementalSearch.Checked = listBox.IncrementalSearch;
            UpdateHotTrackSelectModeEnabled();
            updateValues = false;
        }
        void InitSearchControlProperties() {
            if(listBoxCore is ListBoxControl) {
                ceTurnSearch.Checked = true;
                // <ceAllowAutoApply>
                ceAllowAutoApply.Checked = true;
                // </ceAllowAutoApply>
                // <ceShowSearchButton>
                ceShowSearchButton.Checked = true;
                // </ceShowSearchButton>
                // <ceShowClearButton>
                ceShowClearButton.Checked = true;
                // </ceShowClearButton>
                // <ceShowMRUButton>
                ceShowMRUButton.Checked = false;
                // </ceShowMRUButton>
                // <cbFilterCondition>
                cbFilterCondition.Properties.Items.AddEnum(typeof(DevExpress.Data.Filtering.FilterCondition));
                cbFilterCondition.SelectedIndex = (int)DevExpress.Data.Filtering.FilterCondition.Default;
                // </cbFilterCondition>
                // <tbFindDelay>
                tbFindDelay.Value = 1000;
                // </tbFindDelay>
                // <cbShowDefaultButtonsMode>
                cbShowDefaultButtonsMode.Properties.Items.AddEnum(typeof(Repository.ShowDefaultButtonsMode));
                cbShowDefaultButtonsMode.SelectedIndex = (int)Repository.ShowDefaultButtonsMode.Default;
                // </cbShowDefaultButtonsMode>
            }
        }
        void UpdateHotTrackSelectModeEnabled() {
            icbHotTrackSelectMode.Enabled = listBoxCore.HighlightedItemStyle == HighlightStyle.Skinned &&
                listBoxCore.HotTrackItems;
        }
        void InitComboBoxes() {
            // <icbSelectionMode>
            icbSelectionMode.Properties.Items.AddEnum(typeof(SelectionMode));
            // </icbSelectionMode>
            // <icbSortOrder>
            icbSortOrder.Properties.Items.AddEnum(typeof(SortOrder));
            // </icbSortOrder>
            // <icbAlignment>
            icbAlignment.Properties.Items.AddEnum(typeof(HorzAlignment));
            // </icbAlignment>
            // <icbHighlightedItemStyle>
            icbHighlightedItemStyle.Properties.Items.AddEnum(typeof(HighlightStyle));
            // </icbHighlightedItemStyle>
            // <icbHotTrackSelectMode>
            icbHotTrackSelectMode.Properties.Items.AddEnum(typeof(HotTrackSelectMode));
            // </icbHotTrackSelectMode>
        }

        // <icbSelectionMode>
        // <ceHotTrack>
        bool AllowHotTrack { get { return listBoxCore.SelectionMode.ToString().IndexOf("Multi") == -1; } }
        // </ceHotTrack>
        private void icbSelectionMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBoxCore.SelectionMode = (SelectionMode)icbSelectionMode.EditValue;
            // <ceHotTrack>
            ceHotTrack.Enabled = AllowHotTrack;
            // </ceHotTrack>
        }
        // </icbSelectionMode>

        // <icbSortOrder>
        private void icbSortOrder_SelectedIndexChanged(object sender, System.EventArgs e) {
            // </skip>
            if(updateValues) return;
            // </skip>
            listBoxCore.SortOrder = (SortOrder)icbSortOrder.EditValue;
        }
        // </icbSortOrder>

        // <seColumnWidth>
        private void seColumnWidth_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBoxCore.ColumnWidth = Convert.ToInt32(seColumnWidth.Value);
        }
        // </seColumnWidth>

        // <ceHotTrack>
        private void ceHotTrack_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBoxCore.HotTrackItems = ceHotTrack.Checked;
            // <skip>
            UpdateHotTrackSelectModeEnabled();
            // </skip>
        }
        // </ceHotTrack>

        // <ceMultiColumn>
        private void ceMultiColumn_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBoxCore.MultiColumn = ceMultiColumn.Checked;
            // <seColumnWidth>
            seColumnWidth.Enabled = listBoxCore.MultiColumn;
            // </seColumnWidth>
        }
        // </ceMultiColumn>

        // <icbAlignment>
        private void icbAlignment_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            if(ImageListBox == null) return;
            ImageListBox.GlyphAlignment = (HorzAlignment)icbAlignment.EditValue;
        }
        // </icbAlignment>

        // <ceCheckOnClick>
        private void ceCheckOnClick_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            if(CheckedListBox == null) return;
            CheckedListBox.CheckOnClick = ceCheckOnClick.Checked;
        }
        // </ceCheckOnClick>

        // <icbHighlightedItemStyle>
        private void icbHighlightedItemStyle_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBoxCore.HighlightedItemStyle = (HighlightStyle)icbHighlightedItemStyle.EditValue;
            // <skip>
            UpdateHotTrackSelectModeEnabled();
            // </skip>
        }
        // </icbHighlightedItemStyle>

        // <icbHotTrackSelectMode>
        private void icbHotTrackSelectMode_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBoxCore.HotTrackSelectMode = (HotTrackSelectMode)icbHotTrackSelectMode.EditValue;
        }
        // </icbHotTrackSelectMode>
        // <ceIncrementalSearch>
        private void ceIncrementalSearch_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            listBoxCore.IncrementalSearch = ceIncrementalSearch.Checked;
        }
        // </ceIncrementalSearch>
        // <ceAllowAutoApply>
        private void ceAllowAutoApply_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("AllowAutoApply", ceAllowAutoApply.Checked);
        }
        // </ceAllowAutoApply>
        // <ceShowSearchButton>
        private void ceShowSearchButton_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("ShowSearchButton", ceShowSearchButton.Checked);
        }
        // </ceShowSearchButton>
        // <ceShowClearButton>
        private void ceShowClearButton_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("ShowClearButton", ceShowClearButton.Checked);
        }
        // </ceShowClearButton>
        // <ceShowMRUButton>
        private void ceShowMRUButton_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("ShowMRUButton", ceShowMRUButton.Checked);
        }
        // </ceShowMRUButton>
        // <tbFindDelay>
        private void tbFindDelay_EditValueChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("FindDelay", tbFindDelay.Value);
        }
        // </tbFindDelay>
        // <cbFilterCondition>
        private void cbFilterCondition_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("FilterCondition", cbFilterCondition.EditValue);
        }
        // </cbFilterCondition>
        // <searchControlSample>
        private void ceTurnSearch_CheckedChanged(object sender, EventArgs e) {
            RaiseSearchControlPropertyChanged("TurnSearch", ceTurnSearch.Checked);
            // <skip>
            groupControlSearch.Visible = ListBox != null && ceTurnSearch.Checked && !IsTemplatedListBox;
            // </skip>
        }
        // </searchControlSample>
        // <cbShowDefaultButtonsMode>
        private void cbShowDefaultButtonsMode_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            RaiseSearchControlPropertyChanged("ShowDefaultButtonsMode", cbShowDefaultButtonsMode.EditValue);
        }
        // </cbShowDefaultButtonsMode>

        private void ceShowContextButtons_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            if(!IsTemplatedListBox) return;
            // </skip>
            foreach(ContextItem btn in ListBox.ContextButtons)
                btn.Visibility = ceShowContextButtons.Checked ? ContextItemVisibility.Visible : ContextItemVisibility.Hidden;
        }

        private void ceAutoHeight_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            if(!IsTemplatedListBox) return;
            // </skip>
            var notesElement = ListBox.Templates[0].Elements["Notes"];
            if(notesElement != null) {
                ListBox.ItemAutoHeight = ceAutoHeight.Checked;
                notesElement.GetRow().AutoHeight = ceAutoHeight.Checked;
            }
        }
    }
    public class PropertyValueChangedEventArgs : PropertyChangedEventArgs {
        object valueCore;
        public PropertyValueChangedEventArgs(string propertyName, object value)
            : base(propertyName) {
            this.valueCore = value;
        }
        public object Value { get { return valueCore; } }
    }
}
