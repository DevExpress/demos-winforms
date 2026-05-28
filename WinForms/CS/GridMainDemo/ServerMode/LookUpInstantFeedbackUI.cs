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
    public partial class LookUpInstantFeedbackUI : DevExpress.XtraGrid.Demos.TutorialControl {
        LogWriter writer = new LogWriter();
        public LookUpInstantFeedbackUI() {
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
            //<searchLookUpEdit1>
            /* 
            ~Note: the following property is set at design time and listed here only for demonstration purposes.
            ~Assign a data source to the grid via the DataSource property:
            
            searchLookUpEdit1.Properties.DataSource = xpAsyncServerModeSource1;
            */
            //</searchLookUpEdit1>
            colOid.AllowSummaryMenu = false;
            colHasAttachment.AllowSummaryMenu = false;
            colOid.OptionsColumn.AllowGroup = DefaultBoolean.False;
            colSize.OptionsColumn.AllowGroup = DefaultBoolean.False;
            InitEditors();
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "LookUpInstantFeedbackUI", "SearchLookUpProperties" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "LookUpInstantFeedbackUI"; }
        }
        bool loaded = false;
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(loaded) return;
            this.loaded = true;
            SearchLookUpProperties lp = new SearchLookUpProperties(searchLookUpEdit1, false);
            lp.Dock = DockStyle.Right;
            lp.Parent = pnlControl;
            //<dataNavigator1>
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Id", typeof(int));
            for(int i = 1; i < 100; i++)
                tbl.Rows.Add(i * 3);
            this.searchLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", tbl, "ID"));
            dataNavigator1.DataSource = tbl;
            //</dataNavigator1>
            CreateTimer();
        }
        protected override void OnTick() {
            if(DemosInfo.CurrentModule == this)
                searchLookUpEdit1.ShowPopup();
        }
        void InitEditors() {
            foreach(WaitAnimationOptions mode in Enum.GetValues(typeof(WaitAnimationOptions)))
                icbAnimation.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<WaitAnimationOptions>.GetTitle(mode), mode, -1));
            icbAnimation.EditValue = gridLookUpEdit1View.OptionsView.WaitAnimationOptions;
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
            gridLookUpEdit1View.OptionsView.WaitAnimationOptions = (WaitAnimationOptions)icbAnimation.EditValue;
        }
        //</icbAnimation>
    }
}
