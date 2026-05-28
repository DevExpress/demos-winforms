using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.Tutorials;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleCheckedComboBoxEdit : TutorialControl  {
        // <checkedComboBoxEdit1>
        [FlagsAttribute]
        enum Colors { None = 0, Red = 1, Green = 2, Blue = 4, Yellow = 8, Black = 16 };
        // </checkedComboBoxEdit1>
        // <checkedComboBoxEdit2>
        [Flags]
        enum Platforms {
            Win98 = 16, Win2000 = 32, WinNT = 64, WinXP = 128, Vista = 256,
            [Description("Windows 7")]
            Win7 = 512,
            [Description("Windows 8")]
            Win8 = 1024
        };
        // </checkedComboBoxEdit2>
        public ModuleCheckedComboBoxEdit() {
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleCheckedComboBoxEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "checkedcomboboxEdit"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }

        bool updateValues = false;

        private void ModuleCheckedComboBoxEdit_Load(object sender, System.EventArgs e) {
            ControlUtils.CenterControlInParent(checkedComboBoxEditSample);
            InitComboBoxes();
            InitValues();
        }

        void InitComboBoxes() {
            string[] editValues = new string[] { 
				"Circle", "Rectangle", "Ellipse", 
				"Triangle", "Square" };
            foreach(string value in editValues)
                checkedComboBoxEditSample.Properties.Items.Add(value, CheckState.Unchecked, true);
            // <icbHighlightedItemStyle>
            icbHighlightedItemStyle.Properties.Items.AddEnum(typeof(HighlightStyle));
            // </icbHighlightedItemStyle>
        }

        void InitValues() {
            updateValues = true;
            icbHighlightedItemStyle.EditValue = checkedComboBoxEditSample.Properties.HighlightedItemStyle;
            cmbSeparatorChar.EditValue = checkedComboBoxEditSample.Properties.SeparatorChar;
            ceSelectAllItem.EditValue = checkedComboBoxEditSample.Properties.SelectAllItemVisible;
            teSelectAllItemCaption.EditValue = checkedComboBoxEditSample.Properties.SelectAllItemCaption;
            ceShowButtons.Checked = checkedComboBoxEditSample.Properties.ShowButtons;
            ceIncrementalSearch.Checked = checkedComboBoxEditSample.Properties.IncrementalSearch;
            ceAllowMultiSelect.Checked = checkedComboBoxEditSample.Properties.AllowMultiSelect;
            checkedComboBoxEditSample.SetEditValue("Circle, Ellipse");
            updateValues = false;
            // <checkedComboBoxEdit1>
            checkedComboBoxEdit1.Properties.SetFlags(typeof(Colors));
            checkedComboBoxEdit1.SetEditValue(Colors.Red | Colors.Blue | Colors.Yellow);
            // </checkedComboBoxEdit1>
            // <checkedComboBoxEdit2>
            checkedComboBoxEdit2.Properties.SetFlags(typeof(Platforms));
            checkedComboBoxEdit2.SetEditValue(Platforms.WinXP | Platforms.Win98);
            // </checkedComboBoxEdit2>
        }

        // <icbHighlightedItemStyle>
        private void icbHighlightedItemStyle_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            checkedComboBoxEditSample.Properties.HighlightedItemStyle = (HighlightStyle)icbHighlightedItemStyle.EditValue;
        }
        // </icbHighlightedItemStyle>

        // <cmbSeparatorChar>
        private void cmbSeparatorChar_SelectedIndexChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            checkedComboBoxEditSample.Properties.SeparatorChar = Convert.ToChar(cmbSeparatorChar.EditValue);
        }
        // </cmbSeparatorChar>

        // <ceSelectAllItem>
        private void ceSelectAllItem_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            checkedComboBoxEditSample.Properties.SelectAllItemVisible = ceSelectAllItem.Checked;
        }
        // </ceSelectAllItem>

        private void checkedComboBoxEditSample_CustomDisplayText(object sender, CustomDisplayTextEventArgs e) {
            if(e.DisplayText == string.Empty)
                e.DisplayText = "Nothing";
        }

        // <teSelectAllItemCaption>
        private void teSelectAllItemCaption_EditValueChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            checkedComboBoxEditSample.Properties.SelectAllItemCaption = teSelectAllItemCaption.Text;
        }
        // </teSelectAllItemCaption>
        private void ceShowButtons_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            // </skip>
            checkedComboBoxEditSample.Properties.ShowButtons = ceShowButtons.Checked;
        }
        // <ceIncrementalSearch>
        private void ceIncrementalSearch_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            checkedComboBoxEditSample.Properties.IncrementalSearch = ceIncrementalSearch.Checked;
        }
        // </ceIncrementalSearch>
        // <ceAllowMultiSelect>
        private void ceAllowMultiSelect_CheckedChanged(object sender, EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            checkedComboBoxEditSample.Properties.AllowMultiSelect = ceAllowMultiSelect.Checked;
        }
        // </ceAllowMultiSelect>
    }
}

