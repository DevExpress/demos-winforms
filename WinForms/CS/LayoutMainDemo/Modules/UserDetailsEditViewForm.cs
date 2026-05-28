using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraLayout.Utils;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraEditors;
namespace DevExpress.XtraLayout.Demos {
    public partial class UserDetailsEditViewForm : TutorialControl {
        protected bool isEditing = false;
        public UserDetailsEditViewForm() {
            XpoDefault.DataLayer = new SimpleDataLayer(new InMemoryDataStore(AutoCreateOption.DatabaseAndSchema));
            XpoDefault.Session.Delete(new XPCollection(typeof(DBObjects.Employees)));
            CreatePersons();
            InitializeComponent();
        }
        public static void CreatePersons() {
            DBObjects.Employees emploee;
            emploee = new DBObjects.Employees(XpoDefault.Session);
            emploee.Title = "Ms.";
            emploee.FirstName = "Nancy";
            emploee.LastName = "Davolio";
            emploee.Notes = "Education includes a BA in psychology from Colorado State University in 1970.  She also completed The Art of the Cold Call.  Nancy is a member of Toastmasters International.";
            emploee.Address = "507 - 20th Ave. E. Apt. 2A";
            emploee.Country = "USA";
            emploee.City = "Seattle";
            emploee.Save();

            emploee = new DBObjects.Employees(XpoDefault.Session);
            emploee.Title = "Dr.";
            emploee.FirstName = "Andrew";
            emploee.LastName = "Fuller";
            emploee.Notes = "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.";
            emploee.Address = "908 W. Capital Way";
            emploee.Country = "USA";
            emploee.City = "Tacoma";
            emploee.HomePhone = "(206) 555-9482";
            emploee.Region = "WA";
            emploee.PostalCode = "98401";
            emploee.Save();
        
            emploee = new DBObjects.Employees(XpoDefault.Session);
            emploee.Title = "Ms.";
            emploee.FirstName = "Janet";
            emploee.LastName = "Leverling";
            emploee.Notes = "Janet has a BS degree in chemistry from Boston College (1984).  She has also completed a certificate program in food retailing management.  Janet was hired as a sales associate in 1991 and promoted to sales representative in February 1992.";
            emploee.City = "Kirkland";

            emploee = new DBObjects.Employees(XpoDefault.Session);
            emploee.Title = "Mr.";
            emploee.FirstName = "John";
            emploee.LastName = "Doe";
            emploee.Save();
        
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(Site != null && Site.DesignMode) return;
            UpdateItemsVisibility();
        }
        void dataLayoutControl1_CurrentRecordChanged(object sender, EventArgs e) {
            UpdateItemsVisibility();
        }
        protected void UpdateItemsVisibility() {
            if(!dataLayoutControl1.IsInitialized) return;
            dataLayoutControl1.BeginUpdate();
            try {
                foreach(BaseLayoutItem item in dataLayoutControl1.Items) {
                    LayoutControlItem lci = item as LayoutControlItem;
                    if(lci != null && lci.Control != null) {
                        if(lci.Control.DataBindings.Count > 0) {
                            BaseEdit be = lci.Control as BaseEdit;
                            if(be != null) {
                                string str = be.Properties.GetDisplayText(be.EditValue);
                                be.Properties.ReadOnly = !isEditing;
                                if(isEditing) lci.Visibility = LayoutVisibility.Always;
                                else {
                                    if(be.EditValue == null || str == null || str == string.Empty)
                                        lci.Visibility = LayoutVisibility.OnlyInCustomization;
                                    else
                                        lci.Visibility = LayoutVisibility.Always;
                                }
                            }
                        }
                    }
                }
            }
            finally {
                dataLayoutControl1.EndUpdate();
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e) {
            isEditing = !isEditing;
            if(isEditing) simpleButton2.Text = "View Data";
            else simpleButton2.Text = "Edit Data";
            UpdateItemsVisibility();
        }
    }
}
