using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.Xpo.DB;
using System.IO;
using DevExpress.XtraEditors;
using DevExpress.LookAndFeel;
using DevExpress.Internal;
using DevExpress.DXperience.Demos;

namespace DevExpress.Xpo.Demos {
	public partial class GeneratingPersistentClasses : TutorialControl {
		public GeneratingPersistentClasses() {
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
                PersistentClassGenerator.Generate(code, log, new MSSqlConnectionProvider(connection, AutoCreateOption.SchemaAlreadyExists));
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

			XtraForm1 form = (XtraForm1)dom.CreateInstanceFromAndUnwrap(typeof(XtraForm1).Assembly.CodeBase, typeof(XtraForm1).FullName);
			string errors = form.Show(source, GetDataBaseConnectionString(), UserLookAndFeel.Default.UseWindowsXPTheme, UserLookAndFeel.Default.Style, UserLookAndFeel.Default.SkinName, DevExpress.Skins.SkinManager.AllowFormSkins);
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
