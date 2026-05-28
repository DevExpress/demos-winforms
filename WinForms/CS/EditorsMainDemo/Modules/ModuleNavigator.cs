using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using DevExpress.Tutorials;
// <icbTextLocations>
// <ceShowCustomButtons>
using DevExpress.XtraEditors;
// </ceShowCustomButtons>
using DevExpress.XtraEditors.Controls;
// </icbTextLocations>
using System.Windows.Forms;


namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleNavigator : TutorialControl {
        public ModuleNavigator() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "ModuleNavigator" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "navigator"; }
        }
        bool updateValues = false;
        void ModuleNavigator_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(dataNavigatorSample);
            InitComboBoxes();
            InitValues();
            InitData();
        }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        void InitComboBoxes() {
            // <icbTextLocations>
            icbTextLocations.Properties.Items.AddEnum(typeof(NavigatorButtonsTextLocation));
            // </icbTextLocations>
        }
        void InitValues() {
            updateValues = true;
            icbTextLocations.EditValue = dataNavigatorSample.TextLocation;
            ceEnableAutoRepeat.Checked = dataNavigatorSample.Buttons.EnabledAutoRepeat;
            ceShowToolTips.Checked = dataNavigatorSample.ShowToolTips;
            ceShowCustomButtons.Checked = true;
            ceShowEditingButtons.Checked = true;
            ceShowAppendRemove.Checked = true;
            ceShowPageButtons.Checked = true;
            updateValues = false;
        }
        void InitData() {
            var products = NWindDataSet.Tables["Products"];
            dataNavigatorSample.DataSource = products;
            layoutControlGroup1.DataBindings.Add("Text", products, "ProductName");
        }
        // <icbTextLocations>
        void icbTextLocations_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            dataNavigatorSample.TextLocation = (NavigatorButtonsTextLocation)icbTextLocations.EditValue;
            // <skip>
            ShowNavigator();
            // </skip>
        }
        // </icbTextLocations>
        // <ceEnableAutoRepeat>
        void ceEnableAutoRepeat_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            dataNavigatorSample.Buttons.EnabledAutoRepeat = ceEnableAutoRepeat.Checked;
        }
        // </ceEnableAutoRepeat>
        // <ceShowToolTips>
        void ceShowToolTips_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            dataNavigatorSample.ShowToolTips = ceShowToolTips.Checked;
        }
        // </ceShowToolTips>
        void ShowNavigator() {
            dataNavigatorSample.Width = 10;
            ControlUtils.CenterControlInParent(dataNavigatorSample);
        }
        // <ceShowCustomButtons>
        void ceShowCustomButtons_CheckedChanged(object sender, System.EventArgs e) {
            foreach(NavigatorCustomButton button in dataNavigatorSample.Buttons.CustomButtons)
                button.Visible = ceShowCustomButtons.Checked;
            ShowNavigator();
        }
        // </ceShowCustomButtons>
        // <ceShowEditingButtons>
        void ceShowEditingButtons_CheckedChanged(object sender, System.EventArgs e) {
            dataNavigatorSample.Buttons.CancelEdit.Visible = dataNavigatorSample.Buttons.EndEdit.Visible =
                ceShowEditingButtons.Checked;
            ShowNavigator();
        }
        // </ceShowEditingButtons>
        // <ceShowAppendRemove>
        void ceShowAppendRemove_CheckedChanged(object sender, System.EventArgs e) {
            dataNavigatorSample.Buttons.Append.Visible = dataNavigatorSample.Buttons.Remove.Visible =
                ceShowAppendRemove.Checked;
            ShowNavigator();
        }
        // </ceShowAppendRemove>
        // <ceShowPageButtons>
        void ceShowPageButtons_CheckedChanged(object sender, System.EventArgs e) {
            dataNavigatorSample.Buttons.PrevPage.Visible = dataNavigatorSample.Buttons.NextPage.Visible =
                ceShowPageButtons.Checked;
            ShowNavigator();
        }
        // </ceShowPageButtons>
        // <dataNavigatorSample>
        void dataNavigatorSample_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e) {
            ShowEvent("ButtonClick", e.Button);
        }
        void ShowEvent(string eventString, NavigatorButtonBase button) {
            string type = button.ButtonType.ToString();
            if(type == "Custom") type += " - " + button.Tag.ToString();
            meFiringEvents.Text = string.Format("{0}: {1}\r\n", eventString, type) + meFiringEvents.Text;
        }
        // </dataNavigatorSample>
    }
}
