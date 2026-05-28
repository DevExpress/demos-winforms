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
using DevExpress.Internal;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.Xpo.Demos;
using DevExpress.Xpo.Demos.Tutorials;

namespace DevExpress.Xpo.Demos {
    public partial class InTransactionMode : TutorialControl {
        public override bool SetNewWhatsThisPadding { get { return true; } }
        bool inTransactionModeState = false;
        public InTransactionMode() {
            InitializeComponent();
            PrepareDataLayer();
            PrepareViews();
            sbEmployees_Click(this, EventArgs.Empty);
        }

        UnitOfWork session;
        void PrepareDataLayer() {
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if(!string.IsNullOrEmpty(DBFileName)) {
                InMemoryDataStore inMemory = new InMemoryDataStore(AutoCreateOption.SchemaAlreadyExists);
                inMemory.ReadXml(DBFileName);
                IDataLayer dataLayer = new SimpleDataLayer(inMemory);
                session = new UnitOfWork(dataLayer);
            }
        }

        //<sbEmployees>
        XPView viewEmployee;
        void PrepareViews() {
            viewEmployee = new XPView(session, typeof(Employees));
            viewEmployee.CriteriaString = "City='London'";
            viewEmployee.AddProperty("FirstName", "FirstName", false, true, SortDirection.Ascending);
            viewEmployee.AddProperty("LastName", "LastName", false, true, SortDirection.Ascending);
            viewEmployee.AddProperty("City", "City");
        }
        private void sbEmployees_Click(object sender, EventArgs e) {
            viewEmployee.Reload();
            if(gclInTransactionModeMain.DataSource != viewEmployee) {
                gclInTransactionModeMain.DataSource = viewEmployee;
                gvlInTransactionMode.PopulateColumns();
                sbEmployees.Text = "Reload Employees";
            }
        }
        //</sbEmployees>

        //<sbChangeAnyEmployee>
        private void changeAnyEmployee_Click(object sender, EventArgs e) {
            Employees employee = session.FindObject<Employees>(null);
            if(employee == null) return;
            if(employee.City == "London") {
                employee.City = "Chicago";
            } else {
                employee.City = "London";
            }
            employee.Save();
            sbCommit.Enabled = true;
        }
        //</sbChangeAnyEmployee>
        //<sbCommit>
        private void sbCommit_Click(object sender, EventArgs e) {
            session.CommitChanges();
            sbCommit.Enabled = false;
        }
        //</sbCommit>
        //<ceInTransactionMode>
        private void ceInTransactionMode_CheckedChanged(object sender, EventArgs e) {
            Session.InTransactionMode = ceInTransactionMode.Checked;
        }
        //</ceInTransactionMode>

        private void InTransactionMode_VisibleChanged(object sender, EventArgs e) {
            if(Visible) {
                Session.InTransactionMode = inTransactionModeState;
            } else {
                Session.InTransactionMode = false;
            }
        }
        private void ceInTransactionMode_CheckStateChanged(object sender, EventArgs e) {
            inTransactionModeState = ceInTransactionMode.Checked;
        }
    }
}

