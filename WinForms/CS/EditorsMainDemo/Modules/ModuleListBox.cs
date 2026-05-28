using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using DevExpress.Tutorials;
using System.Windows.Forms;
// <imageListBoxControlSample>
using DevExpress.XtraEditors;
using DevExpress.Utils.Layout;
using DevExpress.XtraBars.Navigation;
// </imageListBoxControlSample>

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleListBox : TutorialControl {
        public ModuleListBox() {
            InitializeComponent();
            InitListBox();
            InitValues();
            tabPane1.SelectedPageChanged += SelectedPageChanged;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            DevExpress.Tutorials.TutorialHelper.InitFont(imageListBoxControlSample, ScaleDPI);
        }

        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            tabPane1.SelectedPageChanged -= SelectedPageChanged;
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "ModuleListBox", "ListBoxProperties" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "listbox"; }
        }
        protected override bool AllowCenterControls {
            get { return false; }
        }
        BaseListBoxControl CurrentListBox {
            get {
                switch(tabPane1.SelectedPageIndex) {
                    case 1: return listBoxControlSample;
                    case 2: return checkedListBoxControlSample;
                    case 3: return imageListBoxControlSample;
                }
                return listBoxTemplated;
            }
        }
        SearchControl CurrentSearchControl {
            get {
                switch(tabPane1.SelectedPageIndex) {
                    case 0: return searchControlTemplates;
                    case 2: return searchControlCheckedSample;
                    case 3: return searchControlImageSample;
                    default: return searchControlSample;
                }
            }
        }
        TablePanel CurrentContainer {
            get {
                switch(tabPane1.SelectedPageIndex) {
                    case 0: return tablePanel1;
                    case 2: return tablePanel3;
                    case 3: return tablePanel4;
                    default: return tablePanel2;
                }
            }
        }
                
        void InitValues() {
            properties.InitListBox(CurrentListBox);
        }

        void properties_SearchControlPropertyChanged(object sender, PropertyChangedEventArgs e) {
            PropertyValueChangedEventArgs args = e as PropertyValueChangedEventArgs;
            switch(args.PropertyName) {
                case "AllowAutoApply":
                    // <ceAllowAutoApply>
                    searchControlSample.Properties.AllowAutoApply = (bool)args.Value;
                    // </ceAllowAutoApply>
                    return;
                case "ShowSearchButton":
                    // <ceShowSearchButton>
                    searchControlSample.Properties.ShowSearchButton = (bool)args.Value;
                    // </ceShowSearchButton>
                    return;
                case "ShowClearButton":
                    // <ceShowClearButton>
                    searchControlSample.Properties.ShowClearButton = (bool)args.Value;
                    // </ceShowClearButton>
                    return;
                case "ShowMRUButton":
                    // <ceShowMRUButton>
                    searchControlSample.Properties.ShowMRUButton = (bool)args.Value;
                    // </ceShowMRUButton>
                    return;
                case "FindDelay":
                    // <tbFindDelay>
                    searchControlSample.Properties.FindDelay = (int)args.Value;
                    // </tbFindDelay>
                    return;
                case "FilterCondition":
                    // <cbFilterCondition>
                    searchControlSample.Properties.FilterCondition = (DevExpress.Data.Filtering.FilterCondition)args.Value;
                    // </cbFilterCondition>
                    return;
                case "ShowDefaultButtonsMode":
                    // <cbShowDefaultButtonsMode>
                    searchControlSample.Properties.ShowDefaultButtonsMode = (Repository.ShowDefaultButtonsMode)args.Value;
                    // <cbShowDefaultButtonsMode>
                    break;
                case "TurnSearch":
                    CurrentContainer.Rows[0].Visible= (bool)args.Value;
                    // <searchControlSample>
                    TurnSearch((bool)args.Value);
                    // </searchControlSample>
                    return;
            }
        }        
        // <searchControlSample>
        void TurnSearch(bool allowSearch) {
            BaseListBoxControl listBoxControl = CurrentListBox as BaseListBoxControl;
            SearchControl searchControl = CurrentSearchControl;
            if(searchControl != null) {
                if(allowSearch)
                    searchControl.Client = listBoxControl;
                else
                    searchControl.Client = null;
            }
        }
        // </searchControlSample>        

        void InitListBox() {
            listBoxTemplated.DataSource = GetContacts();
            listBoxControlSample.DataSource = TutorialHelper.Countries;
            //
            // <checkedListBoxControlSample>
            checkedListBoxControlSample.DataSource = GetProducts();
            if(checkedListBoxControlSample.DataSource != null) {
                checkedListBoxControlSample.DisplayMember = "ProductName";
                checkedListBoxControlSample.ValueMember = "Discontinued";
                int i = 0;
                while(checkedListBoxControlSample.GetItem(i) != null) {
                    checkedListBoxControlSample.SetItemCheckState(i, (true.Equals(checkedListBoxControlSample.GetItemValue(i)) ? CheckState.Unchecked : CheckState.Checked));
                    i++;
                }
            }
            // </checkedListBoxControlSample>
            //
            imageListBoxControlSample.SelectedIndex = 0;
        }

        // <checkedListBoxControlSample>
        DataTable GetProducts() {
            return NWindDataSet.Tables["Products"];
        }
        // </checkedListBoxControlSample>
        DataTable GetContacts() {
            return NWindDataSet.Tables["Employees"];
        }
        void SelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            InitValues();
        }
        // <ceCustomDraw>
        void checkedListBoxControlSample_DrawItem(object sender, DevExpress.XtraEditors.ListBoxDrawItemEventArgs e) {
            if(!ceCustomDraw.Checked) return;
            if(checkedListBoxControlSample.GetItemChecked(e.Index)) return;
            e.Appearance.FontStyleDelta = FontStyle.Strikeout;
        }
        void ceCustomDraw_CheckedChanged(object sender, System.EventArgs e) {
            checkedListBoxControlSample.Refresh();
        }
        // </ceCustomDraw>

        // <imageListBoxControlSample>
        void imageListBoxControlSample_SelectedIndexChanged(object sender, System.EventArgs e) {
            ImageListBoxControl ilb = sender as ImageListBoxControl;
            object fontName = ilb.SelectedValue;
            lbSample.Visible = fontName != null;
            if(fontName == null) return;
            lbSample.Font = new Font(fontName.ToString(), 12);
        }
        // </imageListBoxControlSample>

        // <seInvert>
        void seInvert_Click(object sender, System.EventArgs e) {
            checkedListBoxControlSample.BeginUpdate();
            try {
                int i = 0;
                while(checkedListBoxControlSample.GetItem(i) != null) {
                    checkedListBoxControlSample.SetItemCheckState(i, (checkedListBoxControlSample.GetItemChecked(i) ? CheckState.Unchecked : CheckState.Checked));
                    i++;
                }
            }
            finally {
                checkedListBoxControlSample.EndUpdate();
            }
        }
        // </seInvert>
    }
}
