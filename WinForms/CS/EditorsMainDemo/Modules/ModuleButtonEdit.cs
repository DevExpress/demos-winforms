using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <comboBoxTextEditStyle>
using DevExpress.XtraEditors.Controls;
// </comboBoxTextEditStyle>
using DevExpress.XtraTab;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.Tutorials;
using DevExpress.XtraBars.Navigation;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleButtonEdit : TutorialControl  {
        public ModuleButtonEdit() {
            InitializeComponent();
            if(this.tabPane1 != null)
                this.tabPane1.SelectedPageChanged += OnSelectedPageChanged;
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleButtonEdit", "ButtonProperties" }; } }
        protected override string WhatsThisXMLFileName { get { return "buttonedit"; } }
        void OnSelectedPageChanged(object sender, SelectedPageChangedEventArgs e) {
            CalcContentCore();
        }
        protected override void UnsubscribeOnEvents() {
            base.UnsubscribeOnEvents();
            if(this.tabPane1 != null)
                this.tabPane1.SelectedPageChanged -= OnSelectedPageChanged;
        }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            if(this.xtraTabControlButtons != null && this.xtraTabControlButtons.MinimumSize != Size.Empty) {
                layoutControl2.BeginUpdate();
                layoutControlItem3.Size = this.xtraTabControlButtons.MinimumSize;
                layoutControl2.EndUpdate();
            }
            CalcLayoutControlBounds(layoutControl2);
            CalcLayoutControlBounds(layoutControl1);
        }
        private void ModuleButtonEdit_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(buttonEditSample);
            InitValues();
            InitButtonProperties();
        }

        bool updateValues = false;
        string[] editorsNames = new string[] {"Text Edit", "Button Edit", "Spin Edit", 
			"Check Edit", "ComboBox Edit", "ImageComboBox Edit", "Date Edit", "Calc Edit", 
			"Color Edit", "MemoEx Edit", "Image Edit", "Memo Edit", "Picture Edit", "ProgressBar Control", 
			"LookUp Edit", "PopupContainer Edit", "Radio Group", "Time Edit", "HyperLink Edit", "MRU Edit"};
        
        void InitValues() {
            updateValues = true;
            comboBoxTextEditStyle.Text = buttonEditSample.Properties.TextEditStyle.ToString();
            SetCustomValue(0, buttonEdit1);
            updateValues = false;
        }

        void InitButtonProperties() {
            foreach(EditorButton button in buttonEditSample.Properties.Buttons) {
                XtraTabPage page = new XtraTabPage();
                page.Text = string.Format("Button #{0}", buttonEditSample.Properties.Buttons.IndexOf(button) + 1);
                ButtonProperties pr = new ButtonProperties(button);
                pr.Dock = DockStyle.Fill;
                page.Controls.Add(pr);
                xtraTabControlButtons.TabPages.Add(page);
            }
        }

        // <comboBoxTextEditStyle>
        private void comboBoxTextEditStyle_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            TextEditStyles[] styles = new TextEditStyles[] { TextEditStyles.Standard, 
				TextEditStyles.HideTextEditor,
				TextEditStyles.DisableTextEditor };
            buttonEditSample.Properties.TextEditStyle = styles[comboBoxTextEditStyle.SelectedIndex];
        }
        // </comboBoxTextEditStyle>

        // <buttonEdit1>
        void ShowEvent(string eventString, EditorButton button) {
            meFiringEvents.Text = string.Format("{0}: {1}\r\n", eventString, button.Tag) + meFiringEvents.Text;
        }

        private void buttonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            ShowEvent("ButtonClick", e.Button);
        }
        // </buttonEdit1>

        private void buttonEdit_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            ShowEvent("ButtonPressed", e.Button);
        }

        // <buttonEdit1>
        private void buttonEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            buttonEdit_ButtonPressed(sender, e);
            ButtonEdit edit = sender as ButtonEdit;
            switch(edit.Properties.Buttons.IndexOf(e.Button)) {
                case 0: SetCustomValue(customIndex - 1, edit);
                    break;
                case 1: SetCustomValue(customIndex + 1, edit);
                    break;
            }
        }

        int customIndex = 0;
        private void SetCustomValue(int index, ButtonEdit edit) {
            if(index < 0 || index > editorsNames.Length - 1) return;
            customIndex = index;
            edit.EditValue = editorsNames[index];
            edit.Properties.Buttons[0].Enabled = index > 0;
            edit.Properties.Buttons[1].Enabled = index < editorsNames.Length - 1;
        }
        // </buttonEdit1>

        private void buttonEdit5_Properties_Click(object sender, System.EventArgs e) {
            meFiringEvents.Text = "";
        }

        // <checkEditAllowButtonsNavigation>
        private void checkEditAllowButtonsNavigation_CheckedChanged(object sender, EventArgs e) {
            buttonEditSample.Properties.AllowButtonNavigation = checkEditAllowButtonsNavigation.Checked
                ? Utils.DefaultBoolean.True
                : Utils.DefaultBoolean.Default;
        }
        // </checkEditAllowButtonsNavigation>
    }
}

