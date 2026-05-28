using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
    public partial class LookUpServerMode : DevExpress.XtraGrid.Demos.TutorialControl {
        //<groupControl1>
        LogWriter writer = new LogWriter();
        //</groupControl1>
        public LookUpServerMode() {
            if(ServerModeStrings.SQLConnectionString == string.Empty)
                ShowConnectionWizard();
            try {
                //<groupControl1>
                IDataStore store = XpoDefault.GetConnectionProvider(ServerModeStrings.SQLConnectionString, AutoCreateOption.DatabaseAndSchema);
                //<skip>
                store = new WaitCursorWrapper(store);
                //</skip>
                store = new DataStoreLogger(store, writer);
                XpoDefault.DataLayer = new SimpleDataLayer(store);
                //</groupControl1>
                CreateMainData();
            }
            catch {
                XtraMessageBox.Show(SQLConnectionHelper.FailedConnection, SQLConnectionHelper.FailedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ServerModeStrings.SQLConnectionString = "";
            }
            InitializeComponent();

            colOid.AllowSummaryMenu = false;
            colHasAttachment.AllowSummaryMenu = false;
            colOid.OptionsColumn.AllowGroup = DefaultBoolean.False;
            colSize.OptionsColumn.AllowGroup = DefaultBoolean.False;
            writer.Enabled = ceTracing.Checked;
            //<groupControl1>
            writer.Console = xtraConsole1;
            //</groupControl1>
            repositoryItemComboBox1.Items.AddRange(OutlookData.users);
        }
        void DemoCode() {
            //<gridControl1>
            // Note: the following properties are set at design time and listed here only for demonstration purposes.
            // Assign a data source to the in-place GridLookUpEdit's DataSource property:
            repositoryItemGridLookUpEdit1.DataSource = xpServerCollectionSource1;
            // Specify the field whose values are displayed in the edit box:
            repositoryItemGridLookUpEdit1.DisplayMember = "Subject";
            //</gridControl1>
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "LookupServerMode" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "LookupServerMode"; }
        }
        void CreateMainData() {
            using(UnitOfWork uow = new UnitOfWork()) {
                if(uow.FindObject<ServerSideLookUpTest>(null) == null) {
                    var rnd = Data.Utils.NonCryptographicRandom.Default;
                    XPCollection<ServerSideGridTest> issues = new XPCollection<ServerSideGridTest>(uow);
                    issues.TopReturnedObjects = 1999;
                    while(issues.Count < 1000) {
                        issues.Add(OutlookData.CreateNewObject(uow));
                    }
                    for(int i = 0; i < 7; i++) {
                        int percent = 0;
                        if(i == 2) percent = 50;
                        if(i == 5) percent = 100;
                        ServerSideLookUpTest obj = new ServerSideLookUpTest(uow);
                        obj.AssignTo = OutlookData.GetFrom();
                        obj.DueDate = OutlookData.GetDueDate();
                        obj.Issue = issues[rnd.Next(issues.Count)];
                        obj.PercentComplete = percent;
                    }
                }
                uow.CommitChanges();
            }
        }
        void ShowConnectionWizard() {
            frmSQLConnector frm = new frmSQLConnector();
            frm.ShowDialog();
            ServerModeStrings.SQLConnectionString = frm.GetDataBaseConnectionString();
        }
        void ceTracing_CheckedChanged(object sender, EventArgs e) {
            writer.Enabled = ceTracing.Checked;
        }
        void sbClear_Click(object sender, EventArgs e) {
            xtraConsole1.ClearText();
        }
        void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e) {
            if(e.Column == colPercentComplete) 
                e.RepositoryItem = repositoryItemSpinEdit1;
        }
        IDisposable criteriaParseScope;
        protected override void DoShow() {
            criteriaParseScope = session1.CreateParseCriteriaSessionScope();
            base.DoShow();
        }
        protected override void DoHide() {
            base.DoHide();
            DisposeHelper.Dispose(ref criteriaParseScope);
        }
    }
}
