using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.XtraEditors.DXErrorProvider;

namespace DevExpress.Xpo.Demos {
    public partial class NewContactForm : DevExpress.XtraEditors.XtraForm {
        //<gridControl1>
        private Contact theContact;
        private DXErrorProvider theDXErrorProvider;
        //</gridControl1>

        //<gridControl1>
        public NewContactForm(Contact theContact, DXErrorProvider theDXErrorProvider) {
            this.theContact = theContact;
            this.theDXErrorProvider = theDXErrorProvider;
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitBindings();
            InitErrorProvider();
        }

        // Initializes the DXErrorProvider
        private void InitErrorProvider() {
            theDXErrorProvider.ContainerControl = this;
            theDXErrorProvider.DataSource = theContact;
        }
        //</gridControl1>

        private void InitBindings() {
            teFirstName.DataBindings.Add("EditValue", theContact, "FirstName");
            teLastName.DataBindings.Add("EditValue", theContact, "LastName");
            teAddress.DataBindings.Add("EditValue", theContact, "Address");
            tePhone.DataBindings.Add("EditValue", theContact, "PhoneNumber");
            teEmail.DataBindings.Add("EditValue", theContact, "Email");
        }

        private void UpdateOkButtonState() {
            foreach(Control control in Controls)
                if(theDXErrorProvider.GetError(control) != string.Empty && theDXErrorProvider.GetErrorType(control) == ErrorType.Critical) {
                    sbOk.Enabled = false;
                    return;
                }
            sbOk.Enabled = true;
        }

        private void teFirstName_Validated(object sender, System.EventArgs e) {
            UpdateOkButtonState();
        }
    }
}
