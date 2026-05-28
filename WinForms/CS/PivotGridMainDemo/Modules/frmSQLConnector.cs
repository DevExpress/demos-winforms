using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid.Demos.Helpers;
using System;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class frmSQLConnector : XtraForm {
        Cursor oldCursor;

        public frmSQLConnector()
            : this("Start Demo") {
        }
        public frmSQLConnector(string demoString) {
            InitializeComponent();
            Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", typeof(frmSQLConnector).Assembly);
            ShowInTaskbar = false;
            Owner = Form.ActiveForm;
            StartPosition = FormStartPosition.CenterParent;
            DemoString = demoString;
            sbGenerateDB.Text += DemoString;
            ServerParameters.LoadParameters();
            lblDBName.Text = ServerParameters.DBName;
            teServer.Text = ServerParameters.Server;
            radioGroup1.SelectedIndex = ServerParameters.UseWindowsAuthentication ? 0 : 1;
            teLogin.Text = ServerParameters.Login;
            tePassword.Text = ServerParameters.Password;
            teLogin.TextChanged += (s, e) => { ServerParameters.Login = teLogin.Text; };
            tePassword.TextChanged += (s, e) => { ServerParameters.Password = tePassword.Text; };
            teServer.TextChanged += (s, e) => { ServerParameters.Server = teServer.Text; };
            radioGroup1.SelectedIndexChanged += (s, e) => { ServerParameters.UseWindowsAuthentication = radioGroup1.SelectedIndex == 0; };
            FormClosed += (s, e) => {
                if(DatabaseHelper.IsGenerating)
                    DatabaseHelper.CancelDatabaseGenerationAsync();
                ServerParameters.SaveParameters();
                Cursor.Current = oldCursor;
            };
        }
        protected string DemoString { get; set; }
        void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            teLogin.Enabled = tePassword.Enabled = radioGroup1.SelectedIndex != 0;
        }
        void sbExit_Click(object sender, EventArgs e) {
            DialogResult = DatabaseHelper.IsGenerating ? DialogResult.OK : DialogResult.No;
            Close();
        }
        void sbGenerateDB_Click(object sender, EventArgs e) {
            GenerateRecords();
        }
        void DisableControls() {
            sbGenerateDB.Enabled = false;
            sbTestConfiguration.Enabled = false;
            radioGroup1.Enabled = false;
            teLogin.Enabled = false;
            tePassword.Enabled = false;
            teServer.Enabled = false;
            seRecordCount.Enabled = false;
        }
        void WriteServerParameters() {
            ServerParameters.Server = teServer.Text;
            ServerParameters.UseWindowsAuthentication = radioGroup1.SelectedIndex == 0;
            ServerParameters.Login = teLogin.Text;
            ServerParameters.Password = tePassword.Text;
        }
        void GenerateRecords() {
            WriteServerParameters();
            oldCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if(!DatabaseHelper.CreateDataLayer()) {
                Cursor.Current = oldCursor;
                XtraMessageBox.Show("Failed to connect to the server.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Text = "Generating records...";
            progressBarControl1.Position = 0;
            progressBarControl1.Properties.Maximum = (int)seRecordCount.Value;
            DisableControls();
            DatabaseHelper.GenerateDatabaseAsync((int)seRecordCount.Value, UpdateProgress, OnDatabaseGenerated);
        }
        void UpdateProgress(int rowsGenerated) {
            progressBarControl1.Position = rowsGenerated;
            sbExit.Text = string.Format("{0} rows is enough. {1}", rowsGenerated, DemoString);
        }
        void OnDatabaseGenerated() {
            DialogResult = DialogResult.OK;
            Close();
        }
        void sbTestConfiguration_Click(object sender, EventArgs e) {
            lbRecords.Text = string.Empty;
            int recordsCount = DatabaseHelper.CalculateRecordCount();
            if(recordsCount != -1)
                lbRecords.Text = string.Format("Current record count = {0}", recordsCount);
            else
                XtraMessageBox.Show(
                    string.Format("Unable to connect to the database. Make sure that connection parameters are correct or use the '{0}' button to generate a sample database.", sbGenerateDB.Text),
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
        }
    }
}
