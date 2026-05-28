using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraEditors.Demos {
    public partial class ModuleDXValidationProvider : TutorialControl  {
        public ModuleDXValidationProvider() {
            InitializeComponent();
            InitValidationRules();
            InitFieldValues();
            InitAlignmentValues();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "DXValidationProvider" }; } }
        protected override string WhatsThisXMLFileName { get { return "dxvalidationprovider"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }
        private void InitAlignmentValues() {
            icbIconAlignment.Properties.Items.AddEnum(typeof(ErrorIconAlignment));
            icbIconAlignment.EditValue = ErrorIconAlignment.MiddleLeft;
        }
        private void ModuleDXValidationProvider_Load(object sender, EventArgs e) {
            manualValidate.Checked = true;
            dxValidationProvider1.ValidationMode = ValidationMode.Manual;
            dxValidationProvider1.Validate();
        }
        // <autoValidateCheck>
        // <manualValidate>
        private void OnCheckedChanged(object sender, EventArgs e) {
            dxValidationProvider1.ValidationMode = (manualValidate.Checked ? ValidationMode.Manual : ValidationMode.Auto);
            btnValidate.Enabled = manualValidate.Checked;
        }
        // </manualValidate>
        // </autoValidateCheck>

        private void InitValidationRules() {
            // <notEmptyTextEdit> 
            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "Please enter a value";
            // </notEmptyTextEdit>

            // <rangeTextEdit>
            ConditionValidationRule rangeValidationRule = new ConditionValidationRule();
            rangeValidationRule.ConditionOperator = ConditionOperator.Between;
            rangeValidationRule.Value1 = 1;
            rangeValidationRule.Value2 = 100;
            rangeValidationRule.ErrorText = "Please enter a value between 1 and 100";
            // </rangeTextEdit>

            // <notEqualsComboBoxEdit>
            ConditionValidationRule notEqualsValidationRule = new ConditionValidationRule();
            notEqualsValidationRule.ConditionOperator = ConditionOperator.NotEquals;
            notEqualsValidationRule.Value1 = "(select)";
            notEqualsValidationRule.ErrorText = "Please choose a value";
            notEqualsValidationRule.ErrorType = ErrorType.Information;
            // </notEqualsComboBoxEdit>

            // <containsTextEdit>
            ConditionValidationRule containsValidationRule = new ConditionValidationRule();
            containsValidationRule.ConditionOperator = ConditionOperator.Contains;
            containsValidationRule.Value1 = '@';
            containsValidationRule.ErrorText = "Please enter a valid email";
            containsValidationRule.ErrorType = ErrorType.Warning;
            // </containsTextEdit>

            // <compareTextEdit>
            CompareAgainstControlValidationRule compareValidationRule = new CompareAgainstControlValidationRule();
            compareValidationRule.Control = notEmptyTextEdit;
            compareValidationRule.CompareControlOperator = CompareControlOperator.Equals;
            compareValidationRule.ErrorText = "Please enter a value that equals to the first editor's value";
            compareValidationRule.CaseSensitive = true;
            // </compareTextEdit>
            
            // <customTextEdit>
            CustomValidationRule customValidationRule = new CustomValidationRule();
            customValidationRule.ErrorText = "Please enter a valid person name";
            customValidationRule.ErrorType = ErrorType.Warning;
            // </customTextEdit>
            
            // <notEmptyTextEdit>
            dxValidationProvider1.SetValidationRule(notEmptyTextEdit, notEmptyValidationRule);
            // </notEmptyTextEdit>
            // <rangeTextEdit>
            dxValidationProvider1.SetValidationRule(rangeTextEdit, rangeValidationRule);
            // </rangeTextEdit>
            // <containsTextEdit>
            dxValidationProvider1.SetValidationRule(containsTextEdit, containsValidationRule);
            // </containsTextEdit>
            // <notEqualsComboBoxEdit>
            dxValidationProvider1.SetValidationRule(notEqualsComboBoxEdit, notEqualsValidationRule);
            // </notEqualsComboBoxEdit>
            dxValidationProvider1.SetValidationRule(compareTextEdit, compareValidationRule);
            // <customTextEdit>
            dxValidationProvider1.SetValidationRule(customTextEdit, customValidationRule);
            // </customTextEdit>
        }
        private void InitFieldValues() {
            notEmptyTextEdit.EditValue = "DevExpress";
            rangeTextEdit.EditValue = 570;
            containsTextEdit.EditValue = "support@devexpress.com";
            notEqualsComboBoxEdit.EditValue = "(select)";
            compareTextEdit.EditValue = notEmptyTextEdit.EditValue;
            customTextEdit.EditValue = "Mr. Smith";  
        }
        // <manualValidate>
        // <btnValidate>
        private void btnValidate_Click(object sender, EventArgs e) {
            dxValidationProvider1.Validate();
        }
        // </btnValidate>
        // </manualValidate>

        #region CustomValidationRule
        // <customTextEdit>
        public class CustomValidationRule : ValidationRule {
            public override bool Validate(Control control, object value) {
                string str = (string)value;
                string[] values = new string[] { "Dr.", "Mr.", "Mrs.", "Miss", "Ms." };
                bool res = false;
                foreach(string val in values) {
                    if(ValidationHelper.Validate(str, ConditionOperator.BeginsWith, val, null, null, false)) {
                        string _name = str.Substring(val.Length);
                        if(_name.Trim().Length > 0) res = true;
                    }
                }
                return res;
            }
        }
        // </customTextEdit>
        // <icbIconAlignment>
        private void icbIconAlignment_SelectedIndexChanged(object sender, EventArgs e) {
            foreach(Control ctrl in layoutControl1.Controls)
                if(ctrl is BaseEdit)
                    this.dxValidationProvider1.SetIconAlignment(ctrl, (ErrorIconAlignment)icbIconAlignment.EditValue);
        }
        // </icbIconAlignment>
        #endregion 
                
        ControlCollection GetControlCollection(XtraTab.XtraTabPage page) {
            if(page.Controls.Count < 2) return page.Controls[0].Controls;
            return page.Controls;
        }
        
    }
}
