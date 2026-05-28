using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars.Ribbon;
using DevExpress.MailClient.Win;

namespace DevExpress.ProductsDemo.Win.Forms {
    public partial class frmEditContact : XtraForm {
        Contact contact, bindingContact;
        public frmEditContact() {
            InitializeComponent();
        }
        public frmEditContact(Contact contact, IDXMenuManager menuManager) {
            InitializeComponent();
            this.contact = contact;
            this.bindingContact = contact.Clone();
            InitEditors();
            InitMenuManager(menuManager);
            pePhoto.Image = bindingContact.Photo;
            
            teFirstName.DataBindings.Add("Text", bindingContact.FullName, "FirstName");
            teLastName.DataBindings.Add("Text", bindingContact.FullName, "LastName");
            teMiddleName.DataBindings.Add("Text", bindingContact.FullName, "MiddleName");
            icbTitle.DataBindings.Add("EditValue", bindingContact.FullName, "Title");
            meLine.DataBindings.Add("Text", bindingContact.Address, "AddressLine");
            cbeState.DataBindings.Add("Text", bindingContact.Address, "State");
            cbeCity.DataBindings.Add("Text", bindingContact.Address, "City");
            teZip.DataBindings.Add("Text", bindingContact.Address, "Zip");
            teEmail.DataBindings.Add("Text", bindingContact, "Email");
            tePhone.DataBindings.Add("Text", bindingContact, "Phone");
            deBirthDate.DataBindings.Add("DateTime", bindingContact, "BindingBirthDate");
            icbGender.DataBindings.Add("EditValue", bindingContact, "Gender");
            memoEdit1.DataBindings.Add("Text", bindingContact, "Note");
            UpdateCaption();
            InitValidationProvider();
        }

        void InitValidationProvider() {
            dxValidationProvider1.SetValidationRule(teFirstName, ValidationRulesHelper.RuleIsNotBlank);
            dxValidationProvider1.SetValidationRule(teLastName, ValidationRulesHelper.RuleIsNotBlank);
        }
        void UpdateCaption() {
            Text = bindingContact.Name;
        }
        void InitMenuManager(IDXMenuManager menuManager) {
            foreach(Control ctrl in lcMain.Controls) {
                BaseEdit edit = ctrl as BaseEdit;
                if(edit != null) {
                    edit.MenuManager = menuManager;
                }
            }
        }
        void InitEditors() {
            EditorHelper.InitPersonComboBox(icbGender.Properties);
            EditorHelper.InitTitleComboBox(icbTitle.Properties);
            cbeCity.Properties.Items.AddRange(EditorHelper.GetCities());
            cbeState.Properties.Items.AddRange(EditorHelper.GetStates());
        }
        private void sbOK_Click(object sender, EventArgs e) {
            bindingContact.Photo = pePhoto.Image;
            contact.Assign(bindingContact);
        }

    }
}
