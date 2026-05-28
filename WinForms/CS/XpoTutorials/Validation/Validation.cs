using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DevExpress.Xpo.Demos {
    public partial class Validation : TutorialControl {
        public Validation() {

            InitializeComponent();
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
        private void Validation_Load(object sender, System.EventArgs e) {
            gridControl1.DataSource = xpContacts;
            gridView1.Columns["Oid"].Visible = false;
        }

        //<sbAddContact>
        private void sbAddContact_Click(object sender, System.EventArgs e) {
            Contact theContact = new Contact(unitOfWork1);
            NewContactForm contactForm = new NewContactForm(theContact, dxErrorProvider);
            if(contactForm.ShowDialog(this) == DialogResult.OK) {
                unitOfWork1.CommitChanges();
                xpContacts.Add(theContact);
            }
            else
                unitOfWork1.Delete(theContact);
        }
        //</sbAddContact>

        //<sbRemoveContact>
        private void sbRemoveContact_Click(object sender, System.EventArgs e) {
            if(gridView1.FocusedRowHandle < 0) return;
            Contact contact = ((Contact)xpContacts[gridView1.FocusedRowHandle]);
            unitOfWork1.Delete(contact);
            unitOfWork1.CommitChanges();
        }
        //</sbRemoveContact>

        private void bSave_Click(object sender, System.EventArgs e) {
            SaveChanges(unitOfWork1);
        }
    }
}
