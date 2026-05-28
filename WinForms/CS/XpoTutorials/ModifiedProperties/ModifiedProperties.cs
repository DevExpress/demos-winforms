using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo.DB;
using DevExpress.Data.Filtering;
using System.Globalization;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.Xpo.Demos;
using DevExpress.Xpo.Demos.Tutorials;
using DevExpress.XtraGauges.Win.Base;
using DevExpress.XtraEditors;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraTab;

namespace DevExpress.Xpo.Demos {
    public partial class ModifiedProperties : TutorialControl {
        public override bool SetNewWhatsThisPadding { get { return true; } }
        string[] messages = new string[] { 
            DevExpress.Xpo.Demos.Properties.Resources.ModifiedPropertiesMessagesN1,
            DevExpress.Xpo.Demos.Properties.Resources.ModifiedPropertiesMessagesN2, 
            DevExpress.Xpo.Demos.Properties.Resources.ModifiedPropertiesMessagesN3, 
            DevExpress.Xpo.Demos.Properties.Resources.ModifiedPropertiesMessagesN4, 
            DevExpress.Xpo.Demos.Properties.Resources.ModifiedPropertiesMessagesN5, 
            DevExpress.Xpo.Demos.Properties.Resources.ModifiedPropertiesMessagesN6 
        };

        Customer customer1;
        Customer customer2;
        int customerOid;

        Person person1;
        Person person2;
        int personOid;

        OptimisticLockingReadBehavior olrb1;
        OptimisticLockingReadBehavior olrb2;

        MPData generalData = new MPData();
        MPData customData = new MPData();

        string[] comboSource1 = Enum.GetNames(typeof(OptimisticLockingReadBehavior));
        string[] comboSource2 = Enum.GetNames(typeof(OptimisticLockingReadBehavior));

        public ModifiedProperties() {
            InitializeComponent();
            AssignState(0);

            InitCustomDataObject();
            InitCustomTabPage();
            CreateCustomBinding();
            timer1.Start();
        }

        int currentState;
        public int CurrentState {
            get { return currentState; }
        }
        public void UpdateControls() {
            UpdateEditor(teC1ContactTitle, customer1, "ContactTitle");
            UpdateEditor(teC1ContactName, customer1, "ContactName");
            UpdateEditor(teC1CompanyName, customer1, "CompanyName");
            UpdateEditor(teC1Country, customer1, "Country");
            UpdateEditor(teC1City, customer1, "City");
            UpdateEditor(teC1Phone, customer1, "Phone");

            UpdateEditor(teC2ContactTitle, customer2, "ContactTitle");
            UpdateEditor(teC2ContactName, customer2, "ContactName");
            UpdateEditor(teC2CompanyName, customer2, "CompanyName");
            UpdateEditor(teC2Country, customer2, "Country");
            UpdateEditor(teC2City, customer2, "City");
            UpdateEditor(teC2Phone, customer2, "Phone");

            sbNext.Enabled = CurrentState < (messages.Length - 1);
            ((ILinearGauge)gcProgress.Gauges[0]).Scales[0].Value = CurrentState * 20;
            string message = CurrentState >= messages.Length ? "" : messages[CurrentState];
            if(CurrentState == 0)
                pnlHint.Text = message;
            else
                pnlHint.Text = string.Format("Step #{0} - {1}", CurrentState, message);
        }
        public void UpdateEditor(TextEdit textEdit, Customer customer, string propertyName) {
            XPMemberInfo member = customer.ClassInfo.GetMember(propertyName);
            string memberValue;
            if(member.GetModified(customer)) {
                memberValue = string.Format("{0} (old value: {1})", member.GetValue(customer), member.GetOldValue(customer));
            } else {
                memberValue = (string)member.GetValue(customer);
            }
            textEdit.Text = memberValue;
            textEdit.Properties.ReadOnly = true;
        }

        private void sbNext_Click(object sender, EventArgs e) {
            AssignState(CurrentState + 1);
        }
        private void sbReset_Click(object sender, EventArgs e) {
            AssignState(0);
        }
        //<lcModifiedProperties>        

        void AssignState(int state) {
            if(state > 0 && (state < currentState || state - currentState > 1 || state >= messages.Length)) return;
            currentState = state;
            switch(state) {
                case 0: {
                        generalData.DataLayer = new SimpleDataLayer(new InMemoryDataStore(AutoCreateOption.DatabaseAndSchema));
                        using(UnitOfWork uow = new UnitOfWork(generalData.DataLayer)) {
                            Customer customer = new Customer(uow);
                            customer.ContactName = "Maria Anders";
                            customer.ContactTitle = "Sales Representative";
                            customer.CompanyName = "Alfreds Futterkiste";
                            customer.Country = "Germany";
                            customer.City = "Berlin";
                            customer.Phone = "030-0074321";
                            uow.CommitChanges();
                            customerOid = customer.Oid;
                        }
                        generalData.Uow1 = new UnitOfWork(generalData.DataLayer);
                        generalData.Uow2 = new UnitOfWork(generalData.DataLayer);
                        customer1 = generalData.Uow1.GetObjectByKey<Customer>(customerOid);
                        customer2 = generalData.Uow2.GetObjectByKey<Customer>(customerOid);
                    }
                    break;
                case 1:
                    customer1.CompanyName = "Frankenversand";
                    customer2.Phone = "030-0877310";
                    break;
                case 2:
                    generalData.Uow2.CommitChanges();
                    customer1.Reload();
                    break;
                case 3:
                    customer1.CompanyName = "Blauer See Delikatessen";
                    customer2.CompanyName = "Drachenblut Delikatessen";
                    break;
                case 4:
                    generalData.Uow2.CommitChanges();
                    try {
                        customer1.Reload();
                    } catch(Exception ex) {
                        XtraMessageBox.Show(this, ex.Message, frmMain.DemoNameConst);
                    }
                    break;
                case 5: {
                        XPMemberInfo miCompanyName = customer1.ClassInfo.GetMember("CompanyName");
                        miCompanyName.ResetModified(customer1);
                        customer1.Reload();
                    } break;
            }
            UpdateControls();
        }
        //</lcModifiedProperties>
        void InitCustomDataObject() {
            customData.DataLayer = new SimpleDataLayer(new InMemoryDataStore(AutoCreateOption.DatabaseAndSchema));
            using(UnitOfWork uow = new UnitOfWork(customData.DataLayer)) {
                Person person = new Person(uow);
                person.ContactName = "Maria Anders";
                person.ContactTitle = "Sales Representative";
                person.CompanyName = "Alfreds Futterkiste";
                person.Country = "Germany";
                person.City = "Berlin";
                person.Phone = "030-0074321";
                uow.CommitChanges();
                personOid = person.Oid;
            }
            customData.Uow1 = new UnitOfWork(customData.DataLayer);
            customData.Uow2 = new UnitOfWork(customData.DataLayer);
            customData.Uow1.TrackPropertiesModifications = true;
            customData.Uow2.TrackPropertiesModifications = true;
            person1 = customData.Uow1.GetObjectByKey<Person>(personOid);
            person2 = customData.Uow2.GetObjectByKey<Person>(personOid);
        }

        void InitCustomTabPage() {
            comboBoxEdit1.Properties.Items.AddRange(comboSource1);
            comboBoxEdit1.SelectedIndex = 0;
            comboBoxEdit2.Properties.Items.AddRange(comboSource2);
            comboBoxEdit2.SelectedIndex = 0;
        }

        void CreateCustomBinding() {
            buttonEdit1.DataBindings.Add("EditValue", person1, "ContactTitle");
            buttonEdit2.DataBindings.Add("EditValue", person1, "ContactName");
            buttonEdit3.DataBindings.Add("EditValue", person1, "CompanyName");
            buttonEdit4.DataBindings.Add("EditValue", person1, "Country");
            buttonEdit5.DataBindings.Add("EditValue", person1, "City");
            buttonEdit6.DataBindings.Add("EditValue", person1, "Phone");

            buttonEdit7.DataBindings.Add("EditValue", person2, "ContactTitle");
            buttonEdit8.DataBindings.Add("EditValue", person2, "ContactName");
            buttonEdit9.DataBindings.Add("EditValue", person2, "CompanyName");
            buttonEdit10.DataBindings.Add("EditValue", person2, "Country");
            buttonEdit11.DataBindings.Add("EditValue", person2, "City");
            buttonEdit12.DataBindings.Add("EditValue", person2, "Phone");
        }

        private void comboBoxEdit1_Properties_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEdit currentEdit = sender as ComboBoxEdit;
            olrb1 = (OptimisticLockingReadBehavior)Enum.Parse(typeof(OptimisticLockingReadBehavior), (string)currentEdit.SelectedItem, true);
            customData.Uow1.OptimisticLockingReadBehavior = olrb1;
        }

        private void comboBoxEdit2_Properties_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBoxEdit currentEdit = sender as ComboBoxEdit;
            olrb2 = (OptimisticLockingReadBehavior)Enum.Parse(typeof(OptimisticLockingReadBehavior), (string)currentEdit.SelectedItem, true);
            customData.Uow2.OptimisticLockingReadBehavior = olrb2;
        }

        private void newUowButton1_Click(object sender, EventArgs e) {
            customData.Uow1 = new UnitOfWork(customData.DataLayer);
            customData.Uow1.OptimisticLockingReadBehavior = olrb1;
        }

        private void newUowButton2_Click(object sender, EventArgs e) {
            customData.Uow2 = new UnitOfWork(customData.DataLayer);
            customData.Uow2.OptimisticLockingReadBehavior = olrb2;
        }

        private void uow1CommitChangesButton_Click(object sender, EventArgs e) {
            try {
                customData.Uow1.CommitChanges();
            } catch(Exception ex) {
                XtraMessageBox.Show(this, ex.Message, frmMain.DemoNameConst);
            }
        }

        private void uow2CommitChangesButton_Click(object sender, EventArgs e) {
            try {
                customData.Uow2.CommitChanges();
            } catch(Exception ex) {
                XtraMessageBox.Show(this, ex.Message, frmMain.DemoNameConst);
            }
        }

        private void reloadButton1_Click(object sender, EventArgs e) {
            try {
                person1.Reload();
            } catch(Exception ex) {
                XtraMessageBox.Show(this, ex.Message, frmMain.DemoNameConst);
            }
        }

        private void reloadButton2_Click(object sender, EventArgs e) {
            try {
                person2.Reload();
            } catch(Exception ex) {
                XtraMessageBox.Show(this, ex.Message, frmMain.DemoNameConst);
            }
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            XPMemberInfo miContactTitle = person1.ClassInfo.GetMember("ContactTitle");
            if(miContactTitle.GetOldValue(person1) != null) miContactTitle.SetValue(person1, miContactTitle.GetOldValue(person1));
            miContactTitle.ResetModified(person1);
        }

        private void buttonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            XPMemberInfo miContactName = person1.ClassInfo.GetMember("ContactName");
            if(miContactName.GetOldValue(person1) != null) miContactName.SetValue(person1, miContactName.GetOldValue(person1));
            miContactName.ResetModified(person1);
        }

        private void buttonEdit3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            XPMemberInfo miCompanyName = person1.ClassInfo.GetMember("CompanyName");
            if(miCompanyName.GetOldValue(person1) != null) miCompanyName.SetValue(person1, miCompanyName.GetOldValue(person1));
            miCompanyName.ResetModified(person1);
        }

        private void buttonEdit4_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            XPMemberInfo miCountry = person1.ClassInfo.GetMember("Country");
            if(miCountry.GetOldValue(person1) != null) miCountry.SetValue(person1, miCountry.GetOldValue(person1));
            miCountry.ResetModified(person1);
        }

        private void buttonEdit5_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            XPMemberInfo miCity = person1.ClassInfo.GetMember("City");
            if(miCity.GetOldValue(person1) != null) miCity.SetValue(person1, miCity.GetOldValue(person1));
            miCity.ResetModified(person1);
        }

        private void buttonEdit6_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            XPMemberInfo miPhone = person1.ClassInfo.GetMember("Phone");
            if(miPhone.GetOldValue(person1) != null) miPhone.SetValue(person1, miPhone.GetOldValue(person1));
            miPhone.ResetModified(person1);
        }

        private void buttonEdit7_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            XPMemberInfo miContactTitle = person2.ClassInfo.GetMember("ContactTitle");
            if(miContactTitle.GetOldValue(person2) != null) miContactTitle.SetValue(person2, miContactTitle.GetOldValue(person2));
            miContactTitle.ResetModified(person2);
        }

        private void buttonEdit8_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            XPMemberInfo miContactName = person2.ClassInfo.GetMember("ContactName");
            if(miContactName.GetOldValue(person2) != null) miContactName.SetValue(person2, miContactName.GetOldValue(person2));
            miContactName.ResetModified(person2);
        }

        private void buttonEdit9_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            XPMemberInfo miCompanyName = person2.ClassInfo.GetMember("CompanyName");
            if(miCompanyName.GetOldValue(person2) != null) miCompanyName.SetValue(person2, miCompanyName.GetOldValue(person2));
            miCompanyName.ResetModified(person2);
        }

        private void buttonEdit10_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            XPMemberInfo miCountry = person2.ClassInfo.GetMember("Country");
            if(miCountry.GetOldValue(person2) != null) miCountry.SetValue(person2, miCountry.GetOldValue(person2));
            miCountry.ResetModified(person2);
        }

        private void buttonEdit11_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            XPMemberInfo miCity = person2.ClassInfo.GetMember("City");
            if(miCity.GetOldValue(person2) != null) miCity.SetValue(person2, miCity.GetOldValue(person2));
            miCity.ResetModified(person2);
        }

        private void buttonEdit12_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            XPMemberInfo miPhone = person2.ClassInfo.GetMember("Phone");
            if(miPhone.GetOldValue(person2) != null) miPhone.SetValue(person2, miPhone.GetOldValue(person2));
            miPhone.ResetModified(person2);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Person currentPerson = person1;
            foreach(XPMemberInfo member in currentPerson.ClassInfo.PersistentProperties) {
                if(member.GetModified(currentPerson)) {
                    switch(member.Name) {
                        case "ContactTitle":
                            labelControl1.Text = string.Format("Old value: {0}", member.GetOldValue(currentPerson));
                            break;
                        case "ContactName":
                            labelControl2.Text = string.Format("Old value: {0}", member.GetOldValue(currentPerson));
                            break;
                        case "CompanyName":
                            labelControl3.Text = string.Format("Old value: {0}", member.GetOldValue(currentPerson));
                            break;
                        case "Country":
                            labelControl4.Text = string.Format("Old value: {0}", member.GetOldValue(currentPerson));
                            break;
                        case "City":
                            labelControl5.Text = string.Format("Old value: {0}", member.GetOldValue(currentPerson));
                            break;
                        case "Phone":
                            labelControl6.Text = string.Format("Old value: {0}", member.GetOldValue(currentPerson));
                            break;
                    }
                } else {
                    switch(member.Name) {
                        case "ContactTitle":
                            labelControl1.Text = string.Empty;
                            break;
                        case "ContactName":
                            labelControl2.Text = string.Empty;
                            break;
                        case "CompanyName":
                            labelControl3.Text = string.Empty;
                            break;
                        case "Country":
                            labelControl4.Text = string.Empty;
                            break;
                        case "City":
                            labelControl5.Text = string.Empty;
                            break;
                        case "Phone":
                            labelControl6.Text = string.Empty;
                            break;
                    }
                }
            }
            currentPerson = person2;
            foreach(XPMemberInfo member in currentPerson.ClassInfo.PersistentProperties) {
                if(member.GetModified(currentPerson)) {
                    switch(member.Name) {
                        case "ContactTitle":
                            labelControl7.Text = string.Format("Old value: {0}", member.GetOldValue(currentPerson));
                            break;
                        case "ContactName":
                            labelControl8.Text = string.Format("Old value: {0}", member.GetOldValue(currentPerson));
                            break;
                        case "CompanyName":
                            labelControl9.Text = string.Format("Old value: {0}", member.GetOldValue(currentPerson));
                            break;
                        case "Country":
                            labelControl10.Text = string.Format("Old value: {0}", member.GetOldValue(currentPerson));
                            break;
                        case "City":
                            labelControl11.Text = string.Format("Old value: {0}", member.GetOldValue(currentPerson));
                            break;
                        case "Phone":
                            labelControl2.Text = string.Format("Old value: {0}", member.GetOldValue(currentPerson));
                            break;
                    }
                } else {
                    switch(member.Name) {
                        case "ContactTitle":
                            labelControl7.Text = string.Empty;
                            break;
                        case "ContactName":
                            labelControl8.Text = string.Empty;
                            break;
                        case "CompanyName":
                            labelControl9.Text = string.Empty;
                            break;
                        case "Country":
                            labelControl10.Text = string.Empty;
                            break;
                        case "City":
                            labelControl11.Text = string.Empty;
                            break;
                        case "Phone":
                            labelControl12.Text = string.Empty;
                            break;
                    }
                }
            }
        }

        class MPData {
            public IDataLayer DataLayer;
            public UnitOfWork Uow1;
            public UnitOfWork Uow2;
        }

        [OptimisticLockingReadBehavior(OptimisticLockingReadBehavior.MergeCollisionThrowException, true)]
        [OptimisticLocking(OptimisticLockingBehavior.LockAll)]
        public class Customer : XPObject {
            string contactName;
            public string ContactName {
                get { return contactName; }
                set { SetPropertyValue(nameof(ContactName), ref contactName, value); }
            }
            string contactTitle;
            public string ContactTitle {
                get { return contactTitle; }
                set { SetPropertyValue(nameof(ContactTitle), ref contactTitle, value); }
            }
            string city;
            public string City {
                get { return city; }
                set { SetPropertyValue(nameof(City), ref city, value); }
            }
            private string companyName;
            public string CompanyName {
                get { return companyName; }
                set { SetPropertyValue(nameof(CompanyName), ref companyName, value); }
            }
            private string country;
            public string Country {
                get { return country; }
                set { SetPropertyValue(nameof(Country), ref country, value); }
            }
            private string phone;
            public string Phone {
                get { return phone; }
                set { SetPropertyValue(nameof(Phone), ref phone, value); }
            }
            public Customer(Session session)
                : base(session) {
            }
        }

        [OptimisticLocking(OptimisticLockingBehavior.LockAll)]
        public class Person : XPObject {
            string _contactName;
            public string ContactName {
                get { return _contactName; }
                set { SetPropertyValue(nameof(ContactName), ref _contactName, value); }
            }
            string _contactTitle;
            public string ContactTitle {
                get { return _contactTitle; }
                set { SetPropertyValue(nameof(ContactTitle), ref _contactTitle, value); }
            }
            string _city;
            public string City {
                get { return _city; }
                set { SetPropertyValue(nameof(City), ref _city, value); }
            }
            private string _companyName;
            public string CompanyName {
                get { return _companyName; }
                set { SetPropertyValue(nameof(CompanyName), ref _companyName, value); }
            }
            private string _country;
            public string Country {
                get { return _country; }
                set { SetPropertyValue(nameof(Country), ref _country, value); }
            }
            private string _phone;
            public string Phone {
                get { return _phone; }
                set { SetPropertyValue(nameof(Phone), ref _phone, value); }
            }
            public Person(Session session)
                : base(session) {
            }
        }        
    }
}

