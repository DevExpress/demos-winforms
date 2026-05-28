using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Xpo.DB;
using DevExpress.Xpo;
using DevExpress.Utils;
using DevExpress.DXperience.Demos;

namespace DevExpress.Xpo.Demos {
    public partial class GridServerMode : TutorialControl {
        LogWriter writer = new LogWriter();
        public GridServerMode() {
             if(ServerModeStrings.SQLConnectionString == string.Empty)
                ShowConnectionWizard();
            try {
                IDataStore store = XpoDefault.GetConnectionProvider(ServerModeStrings.SQLConnectionString, AutoCreateOption.DatabaseAndSchema);
                store = new WaitCursorWrapper(store);
                store = new DataStoreLogger(store, writer);
                XpoDefault.DataLayer = new SimpleDataLayer(store);
            }
            catch {
                XtraMessageBox.Show(SQLConnectionHelper.FailedConnection, SQLConnectionHelper.FailedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ServerModeStrings.SQLConnectionString = "";
            }
            InitializeComponent();
            xpInstantFeedbackSource1.DefaultSorting = "Sent desc";
            colOid.AllowSummaryMenu = false;
            colHasAttachment.AllowSummaryMenu = false;
            colOid.OptionsColumn.AllowGroup = DefaultBoolean.False;
            colSize.OptionsColumn.AllowGroup = DefaultBoolean.False;
            writer.Enabled = ceTracing.Checked;
            writer.Console = xtraConsole1;
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
            //xpInstantFeedbackSource1.Reload();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            unitOfWork1.CommitChanges();
            //xpInstantFeedbackSource1.Reload();
        }
    }
}
