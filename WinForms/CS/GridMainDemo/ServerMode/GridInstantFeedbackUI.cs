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
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public partial class GridInstantFeedbackUI : DevExpress.XtraGrid.Demos.TutorialControl {
        LogWriter writer = new LogWriter();
        public GridInstantFeedbackUI() {
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
            //<gridControl1>
            /*
            ~Note: the following property is set at design time and listed here only for demonstration purposes.
            ~Assign a data source to the grid via the DataSource property:
            
            gridControl1.DataSource = xpAsyncServerModeSource1;
            
            ~Sort rows by the Sent column in descending order 
            */
            xpAsyncServerModeSource1.DefaultSorting = "Sent desc";
            //</gridControl1>
            colOid.AllowSummaryMenu = false;
            colExpression.AllowSummaryMenu = false;
            colHasAttachment.AllowSummaryMenu = false;
            colOid.OptionsColumn.AllowGroup = DefaultBoolean.False;
            colSize.OptionsColumn.AllowGroup = DefaultBoolean.False;
            InitEditors();
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "GridInstantFeedbackUI" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "GridInstantFeedbackUI"; }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            OnStyleChanged();
        }
        void InitEditors() {
            foreach(WaitAnimationOptions mode in Enum.GetValues(typeof(WaitAnimationOptions)))
                icbAnimation.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<WaitAnimationOptions>.GetTitle(mode), mode, -1));
            icbAnimation.EditValue = gridView1.OptionsView.WaitAnimationOptions;
        }
        private void ShowConnectionWizard() {
            ShowConnectionWizard(string.Empty);
        }
        private void ShowConnectionWizard(string demoString) {
            frmSQLConnector frm = demoString == string.Empty ? new frmSQLConnector() : new frmSQLConnector(demoString);
            frm.ShowDialog();
            ServerModeStrings.SQLConnectionString = frm.GetDataBaseConnectionString();
        }

        private void sbShowSQLConnection_Click(object sender, EventArgs e) {
            ShowConnectionWizard("Return");
        }

         private void xpAsyncServerModeSource1_ResolveSession(object sender, ResolveSessionEventArgs e) {
            try {
                Session session = new Session();
                session.ConnectionString = ServerModeStrings.SQLConnectionString;
                session.Connect();
                e.Session = session;
                e.Tag = session;
            } catch {
                e.Session = new Session(new SimpleDataLayer(new InMemoryDataStore()));
                e.Tag = null;
            }
        }

        private void xpAsyncServerModeSource1_DismissSession(object sender, ResolveSessionEventArgs e) {
            IDisposable session = e.Tag as IDisposable;
            if(session != null)
                session.Dispose();
        }

        //<icbAnimation>
        private void icbAnimation_SelectedIndexChanged(object sender, EventArgs e) {
            gridView1.OptionsView.WaitAnimationOptions = (WaitAnimationOptions)icbAnimation.EditValue;
        }
        //</icbAnimation>

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e) {
            if (e.Column == colExpression) {
                int value = 0;
                if (int.TryParse(string.Format("{0}", e.Value), out value))
                    e.DisplayText = string.Format("{0}:{1:00}", value / 60, value % 60);
            }
        }
    }
}
