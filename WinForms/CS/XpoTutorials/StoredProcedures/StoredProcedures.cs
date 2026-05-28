using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.LookAndFeel;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Demos.Generator;
using DevExpress.XtraEditors;

namespace DevExpress.Xpo.Demos {
	public partial class StoredProcedures : TutorialControl {
		public StoredProcedures() {
			InitializeComponent();
            teServer.Text = DbEngineDetector.GetSqlServerInstanceName();
		}

		private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e) {
			bool disable = radioGroup1.SelectedIndex == 0;
			DisableSQLServerAuthentication(disable);
		}

		private void DisableSQLServerAuthentication(bool disable) {
			teLogin.Enabled = !disable;
			tePassword.Enabled = !disable;
		}

		private string GetServerConnectionString() {
			string connectionString = String.Format("data source={0};integrated security=SSPI", teServer.Text);
			if(radioGroup1.SelectedIndex == 1)
				connectionString = String.Format("data source={0};user id={1};password={2}", teServer.Text, teLogin.Text, tePassword.Text);
			return connectionString;
		}

		private string GetDataBaseConnectionString() {
			string connectionString = GetServerConnectionString();
			return connectionString + ";initial catalog=" + cbDatabase.Text;
		}

		private void comboBoxEdit1_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e) {
			using(SqlConnection connection = SQLConnectionHelper.GetConnection(GetServerConnectionString())) {
                if(connection == null) return;
				using(SqlCommand command = new SqlCommand("select name from master..sysdatabases", connection)) {
					using(SqlDataReader reader = command.ExecuteReader()) {
						cbDatabase.Properties.Items.Clear();
						while(reader.Read()) {
							string name = reader.GetString(0);
							if(name != "master" && name != "model" && name != "tempdb" && name != "msdb" && name != "pubs")
								cbDatabase.Properties.Items.Add(name);
						}
					}
				}
			}
		}

		private void simpleButton1_Click(object sender, System.EventArgs e) {
			GeneratePersistentClasses();
		}

		private void GeneratePersistentClasses() {
			StringWriter code = new StringWriter();
			StringWriter log = new StringWriter();
            using(SqlConnection connection = SQLConnectionHelper.GetConnection(GetDataBaseConnectionString())) {
                if(connection == null) return;

                MSSqlConnectionProvider provider = new MSSqlConnectionProvider(connection, AutoCreateOption.SchemaAlreadyExists);
                Dictionary<string, bool> tableMasks = new Dictionary<string, bool>();
                Dictionary<string, bool> sprocMasks = new Dictionary<string, bool>();
                TableColumnsCheckContainer tables = new TableColumnsCheckContainer();
                SProcsResultSetCheckContainer sprocedures = new SProcsResultSetCheckContainer();
                sprocedures.SetUp(provider);
                foreach(string sprocName in sprocedures.GetSProcList()) {
                    sprocMasks[sprocName] = true;
                }
                new CSharpPersistentClassGenerator().Generate(code, log, provider, tableMasks, tables, sprocMasks, sprocedures, cbDatabase.Text);
                meCode.Text = code.ToString();
                meLog.Text = log.ToString();
            }
		}

		private void cbDatabase_EditValueChanged(object sender, System.EventArgs e) {
			if(cbDatabase.Text == String.Empty)
				simpleButton1.Enabled = false;
			else
				simpleButton1.Enabled = true;
		}

		private void simpleButton2_Click(object sender, System.EventArgs e) {
			AppDomainSetup setup = new AppDomainSetup();
			setup.ApplicationBase = AppDomain.CurrentDomain.BaseDirectory;
			AppDomain dom = AppDomain.CreateDomain("test", null, setup);
			string source = meCode.Text;

            XtraFormSP form = (XtraFormSP)dom.CreateInstanceFromAndUnwrap(typeof(XtraFormSP).Assembly.CodeBase, typeof(XtraFormSP).FullName);

            string errors = form.Show(source, GetDataBaseConnectionString(), DevExpress.Xpo.Demos.Generator.PersistentClassGenerator.StaticHelperClassName,
                UserLookAndFeel.Default.UseWindowsXPTheme, UserLookAndFeel.Default.Style, UserLookAndFeel.Default.SkinName, DevExpress.Skins.SkinManager.AllowFormSkins);
			AppDomain.Unload(dom);
			if(errors != null) {
				meLog.Text += errors;
				xtraTabControl1.SelectedTabPageIndex = 1;
			}
		}

		private void meCode_EditValueChanged(object sender, System.EventArgs e) {
			simpleButton2.Enabled = meCode.Text != String.Empty;
		}
	}
}
