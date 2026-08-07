using System;
using DevExpress.XtraEditors;

namespace DevExpress.WindowsMailClient.Win.Forms {
    public partial class EmailSignatureEditForm : XtraForm {
        public EmailSignatureEditForm() {
            InitializeComponent();
            toggleSwitch1.EditValue = (bool)Utils.Utils.UseAsEmailSignature;
            signatureEditFormControl1.LoadText(Utils.Utils.StartMhtText);
        }

        void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        void btnSave_Click(object sender, EventArgs e) {
            Utils.Utils.StartMhtText = signatureEditFormControl1.GetText();
            Close();
        }

        void toggleSwitch1_EditValueChanged(object sender, EventArgs e) {
            Utils.Utils.UseAsEmailSignature = (bool)((ToggleSwitch)sender).EditValue;
        }
    }
}
