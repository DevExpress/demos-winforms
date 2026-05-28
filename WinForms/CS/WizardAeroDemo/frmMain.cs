using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraWizard.Demos {
    public partial class frmMain : XtraForm {
        bool finish = false;
        public frmMain() {
            InitializeComponent();
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraWizard.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }

        private void wizardControl1_SelectedPageChanging(object sender, WizardPageChangingEventArgs e) {
            if(e.PrevPage == wpCardTemplate && e.Direction == Direction.Forward)
                e.Page = ceSignature.Checked ? wpSignature : wpPreview;
            if(e.PrevPage == wpPreview && e.Direction == Direction.Backward)
                e.Page = ceSignature.Checked ? wpSignature : wpCardTemplate;
            if(e.Page == wpPreview && e.Direction == Direction.Forward)
                CreateCardPreview();
        }

        private void wizardControl1_SelectedPageChanged(object sender, WizardPageChangedEventArgs e) {
            if(e.Page == wpRecipientData)
                teRecipientName.Focus();
            if(e.Page == wpSignature)
                teYourName.Focus();
        }

        private void teRecipient_TextChanged(object sender, EventArgs e) {
            wpRecipientData.AllowNext = teRecipientName.Text != string.Empty && teEmail.Text != string.Empty;
        }

        private void teYourName_TextChanged(object sender, EventArgs e) {
            wpSignature.AllowNext = teYourName.Text != string.Empty;
        }

        private void sbSkipSignature_Click(object sender, EventArgs e) {
            teYourName.Text = string.Empty;
            ceSignature.Checked = false;
            wizardControl1.SelectedPage = wpPreview;
        }

        void CreateCardPreview() {
            meCard.Text = string.Format("Happy birthday, {0}!!!\r\n{1}", teRecipientName.Text, rgWishes.Properties.Items[rgWishes.SelectedIndex].Description);
            if(ceSignature.Checked)
                meCard.Text += string.Format("\r\n\r\n{0}, {1}", cbeSignatureTemplate.Text, teYourName.Text);
        }

        private void sbSend_Click(object sender, EventArgs e) {
            string emailTag = string.Format("mailto:{0}?subject={1}&body={2}",
                Uri.EscapeDataString(teEmail.Text),
                Uri.EscapeDataString("Happy Birthday!"),
                Uri.EscapeDataString(meCard.Text));
            Data.Utils.SafeProcess.Start(emailTag);
        }

        private void wizardControl1_CancelClick(object sender, CancelEventArgs e) {
            this.Close();
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e) {
            finish = true;
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
            if(finish) return;
            if(XtraMessageBox.Show(this, "Do you want to exit the XtraWizard control demo?", "XtraWizard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void teEmail_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e) {
            e.ErrorText = "Invalid email address";
        }
    }
}
