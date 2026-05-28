using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
    public partial class frmSQLConnector : XtraForm {
        string defaultDB = "ServerModeGridProjects";
        string serverParameters = "SQLParameters.xml";
        public frmSQLConnector()
            : this(Properties.Resources.StartDemo) {
        }
        public frmSQLConnector(string demoString) {
            InitializeComponent();
            npMain.Text = Properties.Resources.DescriptionSQLConnection;
            cbDatabase.Text = defaultDB;
            sbAddRecords.Text += demoString;
            sbGenerateDB.Text += demoString;
            sbExit.Text += demoString;
            teServer.Text = DbEngineDetector.GetSqlServerInstanceName();
            ShowParameters();
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this.ClientSize = new Size(ClientSize.Width, npMain.Height + MinHeight + this.Padding.Vertical);
        }
        void ShowParameters() {
            if(!System.IO.File.Exists(serverParameters))
                return;
            sbExit.Enabled = true;
            try {
                XmlDocument doc = SafeXml.CreateDocument(serverParameters);
                if(doc.DocumentElement.Name == "Parameters") {
                    string[] prm = doc.DocumentElement.InnerText.Split(new char[] { ';' });
                    teServer.Text = prm[0];
                    radioGroup1.SelectedIndex = Convert.ToInt32(prm[1]);
                    teLogin.Text = prm[2];
                    tePassword.Text = prm[3];
                }
            }
            catch { }
            CheckRecords();
        }
        int MinHeight {
            get { return layoutControl1.Root.MinSize.Height; }
        }
        void CheckRecords() {
            int num = CalcRecordCount(GetDataBaseConnectionString());
            if(num > 0) {
                sbAddRecords.Enabled = true;
                lbRecords.Text = string.Format(ServerModeStrings.recordCount, num);
            }
        }
        void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            bool disable = radioGroup1.SelectedIndex == 0;
            DisableSQLServerAuthentication(disable);
        }
        void DisableSQLServerAuthentication(bool disable) {
            teLogin.Enabled = !disable;
            tePassword.Enabled = !disable;
        }
        public string ConnectionStringParameters {
            get { return string.Format("{0};{1};{2};{3}", teServer.Text, radioGroup1.SelectedIndex, teLogin.Text, tePassword.Text); }
        }
        string GetServerConnectionString() {
            string connectionString = string.Format("data source={0};integrated security=SSPI", teServer.Text);
            if(radioGroup1.SelectedIndex == 1)
                connectionString = string.Format("data source={0};user id={1};password={2}", teServer.Text, teLogin.Text, tePassword.Text);
            return connectionString;
        }
        public string GetDataBaseConnectionString() {
            if(DialogResult == DialogResult.Cancel)
                return string.Empty;
            string connectionString = GetServerConnectionString();
            return connectionString + ";initial catalog=" + cbDatabase.Text;
        }
        public static int CalcRecordCount(string serverConnectionString) {
            try {
                using(Session session = new Session()) {
                    session.AutoCreateOption = AutoCreateOption.None;
                    session.ConnectionString = serverConnectionString;
                    return Convert.ToInt32(session.Evaluate<ServerSideGridTest>(new AggregateOperand(null, null, Aggregate.Count, null), null));
                }
            }
            catch { return 0; }
        }
        void AddTableNames() {
            using(SqlConnection connection = SQLConnectionHelper.GetConnection(GetServerConnectionString())) {
                if(connection == null)
                    return;
#pragma warning disable DX0024
                using(SqlCommand command = new SqlCommand("select name from master..sysdatabases", connection)) {
                    using(SqlDataReader reader = command.ExecuteReader()) {
                        cbDatabase.Properties.Items.Clear();
                        while(reader.Read()) {
                            string _name = reader.GetString(0);
                            if("master;model;tempdb;msdb;pubs".IndexOf(_name) < 0)
                                cbDatabase.Properties.Items.Add(_name);
                        }
                    }
                }
#pragma warning restore DX0024
            }
        }
        void cbDatabase_QueryPopUp(object sender, CancelEventArgs e) {
            AddTableNames();
        }
        void cbDatabase_EditValueChanged(object sender, EventArgs e) {
            sbGenerateDB.Enabled = cbDatabase.Text == defaultDB;
        }
        void teServer_EditValueChanged(object sender, EventArgs e) {
            cbDatabase.Text = defaultDB;
            cbDatabase.Properties.Items.Clear();
        }
        void sbGenerateDB_Click(object sender, EventArgs e) {
            GenerateRecords(true);
        }
        void sbAddRecords_Click(object sender, EventArgs e) {
            GenerateRecords(false);
        }
        void GenerateRecords(bool clearRecords) {
            if(!SQLConnectionHelper.IsConnectionCorrect(GetServerConnectionString()))
                return;
            Cursor cur = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            try {
                IDataStore store = XpoDefault.GetConnectionProvider(GetDataBaseConnectionString(), AutoCreateOption.DatabaseAndSchema);
                XpoDefault.DataLayer = new SimpleDataLayer(store);
                Text = ServerModeStrings.dataAdding;
                using(UnitOfWork uow = new UnitOfWork()) {
                    if(clearRecords) {
                        try {
                            uow.ClearDatabase();
                        }
                        catch { }
                    }
                    int step = (int)(seRecordCount.Value / 100);
                    for(decimal i = 0; i < seRecordCount.Value; i++) {
                        OutlookData.CreateNewObject(uow);
                        if(i % step == 0) {
                            uow.CommitChanges();
                            progressBarControl1.Position = (int)(i * 100 / seRecordCount.Value);
                            Application.DoEvents();
                            this.Refresh();
                            Cursor.Current = Cursors.WaitCursor;
                        }
                    }
                    uow.CommitChanges();
                }
                DialogResult = DialogResult.OK;
                CloseForm();
            }
            catch(Exception ex) {
                XtraMessageBox.Show(ex.Message, SQLConnectionHelper.FailedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Cursor.Current = cur; }
        }
        void sbExit_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.No;
            CloseForm();
        }
        void CloseForm() {
            if(!SQLConnectionHelper.IsConnectionCorrect(GetServerConnectionString())) return;
            try {
                using(XmlTextWriter tw = new XmlTextWriter(serverParameters, System.Text.Encoding.UTF8)) {
                    tw.WriteElementString("Parameters", ConnectionStringParameters);
                }
            }
            catch { }
            this.Close();
        }
    }
}
