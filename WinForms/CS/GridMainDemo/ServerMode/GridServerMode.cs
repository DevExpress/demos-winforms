using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo.DB;
using DevExpress.Xpo;
using DevExpress.Xpo.Helpers;
using System.Diagnostics;
using DevExpress.Utils;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public partial class GridServerMode : DevExpress.XtraGrid.Demos.TutorialControl {
        //<groupControl1>
        LogWriter writer = new LogWriter();
        //</groupControl1>

        public GridServerMode() {
             if(ServerModeStrings.SQLConnectionString == string.Empty)
                ShowConnectionWizard();
            try {
                //<groupControl1>
                IDataStore store = XpoDefault.GetConnectionProvider(ServerModeStrings.SQLConnectionString, AutoCreateOption.DatabaseAndSchema);
                //<skip>
                store = new WaitCursorWrapper(store);
                //</skip>
                store = new DataStoreLogger(store, writer);
                //</groupControl1>
                XpoDefault.DataLayer = new SimpleDataLayer(store);
            }
            catch {
                XtraMessageBox.Show(SQLConnectionHelper.FailedConnection, SQLConnectionHelper.FailedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ServerModeStrings.SQLConnectionString = "";
            }
            InitializeComponent();
            //<gridControl1>
            /*
            ~Note: the following property is set at design time and listed here only for demonstration purposes.
            ~Assign a data source to the grid via the DataSource property:
            
            gridControl1.DataSource = xpServerCollectionSource1;
            
            ~Sort rows by the Sent column in descending order
            */
            xpServerCollectionSource1.DefaultSorting = "Sent desc";
            //</gridControl1>
            colOid.AllowSummaryMenu = false;
            colHasAttachment.AllowSummaryMenu = false;
            colOid.OptionsColumn.AllowGroup = DefaultBoolean.False;
            colSize.OptionsColumn.AllowGroup = DefaultBoolean.False;
            writer.Enabled = ceTracing.Checked;
            //<groupControl1>
            writer.Console = xtraConsole1;
            //</groupControl1>
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "GridServerMode" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "GridServerMode"; }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            OnStyleChanged();
        }
        private void ShowConnectionWizard() {
            ShowConnectionWizard(string.Empty);
        }
        private void ShowConnectionWizard(string demoString) {
            frmSQLConnector frm = demoString == string.Empty ? new frmSQLConnector() : new frmSQLConnector(demoString);
            frm.ShowDialog();
            ServerModeStrings.SQLConnectionString = frm.GetDataBaseConnectionString();
        }

        private void ceTracing_CheckedChanged(object sender, EventArgs e) {
            writer.Enabled = ceTracing.Checked;
        }

        private void sbClear_Click(object sender, EventArgs e) {
            xtraConsole1.ClearText();
        }

        private void sbShowSQLConnection_Click(object sender, EventArgs e) {
            ShowConnectionWizard("Return");
            xpServerCollectionSource1.Reload();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            //<simpleButton1>
            unitOfWork1.CommitChanges();
            xpServerCollectionSource1.Reload();
            //</simpleButton1>
        }
    }
}
