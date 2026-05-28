using System;
using System.Windows.Forms;
// <icbHeaderClickMode>
// <icbSearchMode>
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
// </icbSearchMode>
// </icbHeaderClickMode>

namespace DevExpress.XtraEditors.Demos {
    public partial class LookUpProperties : XtraUserControl {
        RepositoryItemLookUpEdit lookUpProperties;
        bool updateValues = false;

        public LookUpProperties() {
            InitializeComponent();
            InitComboBoxes();
        }
        public void InitLookUp(LookUpEdit lookUp) {
            this.lookUpProperties = lookUp.Properties;
            updateValues = true;
            seColumnIndex.Properties.MaxValue = lookUpProperties.Columns.Count - 1;
            seColumnIndex.Enabled = seColumnIndex.Properties.MaxValue > 0;
            lbDisplay.Text = lookUpProperties.DisplayMember;
            lbValue.Text = lookUpProperties.ValueMember;
            seColumnIndex.Value = lookUpProperties.AutoSearchColumnIndex;
            icbSearchMode.EditValue = lookUpProperties.SearchMode;
            icbHeaderClickMode.EditValue = lookUpProperties.HeaderClickMode;
            ceCaseSensitiveSearch.Checked = lookUpProperties.CaseSensitiveSearch;
            seItemHeight.Value = lookUpProperties.DropDownItemHeight;
            teNullText.Text = lookUpProperties.NullText;
            ceHotTrack.Checked = lookUpProperties.HotTrackItems;
            ceShowFooter.Checked = lookUpProperties.ShowFooter;
            ceShowHeader.Checked = lookUpProperties.ShowHeader;
            ceShowLines.Checked = lookUpProperties.ShowLines;
            updateValues = false;
        }
        void InitComboBoxes() {
            // <icbHeaderClickMode>
            icbHeaderClickMode.Properties.Items.AddEnum(typeof(HeaderClickMode));
            // </icbHeaderClickMode>
            // <icbSearchMode>
            icbSearchMode.Properties.Items.AddEnum(typeof(SearchMode));
            // </icbSearchMode>
            icbSearchMode.Properties.Items.RemoveAt(icbSearchMode.Properties.Items.Count - 1); // Hide SearchMode.AutoSuggest
        }

        // <seColumnIndex>
        void seColumnIndex_EditValueChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.AutoSearchColumnIndex = Convert.ToInt32(seColumnIndex.Value);
        }
        // </seColumnIndex>

        // <icbHeaderClickMode>
        void icbHeaderClickMode_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.HeaderClickMode = (HeaderClickMode)icbHeaderClickMode.EditValue;
        }
        // </icbHeaderClickMode>

        // <icbSearchMode>
        void icbSearchMode_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.SearchMode = (SearchMode)icbSearchMode.EditValue;
        }
        // </icbSearchMode>

        // <ceCaseSensitiveSearch>
        void ceCaseSensitiveSearch_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.CaseSensitiveSearch = ceCaseSensitiveSearch.Checked;
        }
        // </ceCaseSensitiveSearch>

        // <seItemHeight>
        void seItemHeight_EditValueChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.DropDownItemHeight = Convert.ToInt32(seItemHeight.Value);
        }
        // </seItemHeight>

        // <teNullText>
        void teNullText_EditValueChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.NullText = teNullText.Text;
        }
        // </teNullText>

        // <ceHotTrack>
        void ceHotTrack_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.HotTrackItems = ceHotTrack.Checked;
        }
        // </ceHotTrack>

        // <ceShowFooter>
        void ceShowFooter_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.ShowFooter = ceShowFooter.Checked;
        }
        // </ceShowFooter>

        // <ceShowHeader>
        void ceShowHeader_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.ShowHeader = ceShowHeader.Checked;
        }
        // </ceShowHeader>

        // <ceShowLines>
        void ceShowLines_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            lookUpProperties.ShowLines = ceShowLines.Checked;
        }
        // </ceShowLines>
    }
}
