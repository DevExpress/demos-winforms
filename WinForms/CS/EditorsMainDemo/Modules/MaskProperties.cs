using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
// <icbAutoComplete>
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
// </icbAutoComplete>

namespace DevExpress.XtraEditors.Demos {
    public partial class MaskProperties : XtraUserControl {
        public RepositoryItemTextEdit ActiveProperties { get { return textProperties; } }
        public event EventHandler PropertyValueChanged;

        public MaskProperties(TextEdit textEdit) {
            InitializeComponent();
            InitComboBoxes();
            InitMask(textEdit);
        }

        RepositoryItemTextEdit textProperties;
        bool updateValues = false;

        public void InitMask(TextEdit textEdit, string pageName = "") {
            updateValues = true;
            teEditMask.Enabled = icbAutoComplete.Enabled = cbPlaceHolder.Enabled =
            ceBeepOnError.Enabled = ceIgnoreMaskBlank.Enabled = ceSaveLiteral.Enabled =
            ceShowPlaceHolder.Enabled = ceUseMaskAsDisplayFormat.Enabled = textEdit != null;
            if(textEdit != null) {
                this.textProperties = textEdit.Properties;
                lbMaskType.Text = GetNameText(pageName, textEdit.Tag != null ? textEdit.Tag.ToString() : textEdit.Text); ;
                teEditMask.EditValue = textProperties.Mask.EditMask;
                icbAutoComplete.EditValue = textProperties.Mask.AutoComplete;
                cbPlaceHolder.EditValue = textProperties.Mask.PlaceHolder;
                ceBeepOnError.Checked = textProperties.Mask.BeepOnError;
                ceIgnoreMaskBlank.Checked = textProperties.Mask.IgnoreMaskBlank;
                ceSaveLiteral.Checked = textProperties.Mask.SaveLiteral;
                ceShowPlaceHolder.Checked = textProperties.Mask.ShowPlaceHolders;
                ceUseMaskAsDisplayFormat.Checked = textProperties.Mask.UseMaskAsDisplayFormat;
            }
            else {
                this.textProperties = null;
                lbMaskType.Text = "None";
                teEditMask.EditValue = icbAutoComplete.EditValue = cbPlaceHolder.EditValue = "";
                ceBeepOnError.Checked = ceIgnoreMaskBlank.Checked = ceSaveLiteral.Checked =
                ceShowPlaceHolder.Checked = ceUseMaskAsDisplayFormat.Checked = false;
            }
            updateValues = false;
        }
        protected string GetNameText(string pageName, string editorName) {
            if(string.IsNullOrEmpty(pageName))
                return editorName;
            return String.Format("{0} ({1})", pageName, editorName);
        }
        void InitComboBoxes() {
            // <icbAutoComplete>
            icbAutoComplete.Properties.Items.AddEnum(typeof(AutoCompleteType));
            // </icbAutoComplete>
        }

        void RaisePropertyValueChanged(object sender) {
            if(PropertyValueChanged != null)
                PropertyValueChanged(sender, EventArgs.Empty);
        }

        private void teEditMask_EditValueChanged(object sender, System.EventArgs e) {
            DoUpdateProperties(sender);
        }

        private void icbAutoComplete_SelectedIndexChanged(object sender, System.EventArgs e) {
            DoUpdateProperties(sender);
        }

        private void cbPlaceHolder_SelectedIndexChanged(object sender, System.EventArgs e) {
            DoUpdateProperties(sender);
        }

        private void ceBeepOnError_CheckedChanged(object sender, System.EventArgs e) {
            DoUpdateProperties(sender);
        }

        private void ceIgnoreMaskBlank_CheckedChanged(object sender, System.EventArgs e) {
            DoUpdateProperties(sender);
        }

        private void ceSaveLiteral_CheckedChanged(object sender, System.EventArgs e) {
            DoUpdateProperties(sender);
        }

        private void ceShowPlaceHolder_CheckedChanged(object sender, System.EventArgs e) {
            DoUpdateProperties(sender);
        }

        private void ceUseMaskAsDisplayFormat_CheckedChanged(object sender, System.EventArgs e) {
            DoUpdateProperties(sender);
        }

        void DoUpdateProperties(object sender) {
            if(updateValues || textProperties == null) return;
            try {
                textProperties.Mask.EditMask = teEditMask.Text;
                textProperties.Mask.AutoComplete = (AutoCompleteType)icbAutoComplete.EditValue;
                textProperties.Mask.PlaceHolder = Convert.ToChar(cbPlaceHolder.EditValue);
                textProperties.Mask.BeepOnError = ceBeepOnError.Checked;
                textProperties.Mask.IgnoreMaskBlank = ceIgnoreMaskBlank.Checked;
                textProperties.Mask.SaveLiteral = ceSaveLiteral.Checked;
                textProperties.Mask.ShowPlaceHolders = ceShowPlaceHolder.Checked;
            textProperties.Mask.UseMaskAsDisplayFormat = ceUseMaskAsDisplayFormat.Checked;
            }
            catch { }
            RaisePropertyValueChanged(sender);
        }
    }
}
