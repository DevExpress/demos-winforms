using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.Utils;
using System.IO;
using DevExpress.Internal;

namespace DevExpress.XtraPivotGrid.Demos {
	public partial class OLAPConnectionDesigner : DevExpress.XtraEditors.XtraForm {
		OLAPMetaGetter metaGetter = new OLAPMetaGetter();
		static string fSampleFileName;

		static string GetConnectionString(string serverName) {
			return "Provider=msolap;Data Source=" + serverName + ";Initial Catalog=Adventure Works;Cube Name=Adventure Works";
		}

		public string ConnectionString {
			get {
				return "Provider=msolap;Data Source=" + editServer.Text +
					";Initial Catalog=" + (string)listCatalog.EditValue +
					";Cube Name=" + (string)listCube.EditValue;
			}
		}
		public static string SampleConnectionString {
			get {
				if(string.IsNullOrEmpty(SampleFileName)) return null;
				return "Provider=msolap;Data Source=" + SampleFileName + ";Initial Catalog=Adventure Works;Cube Name=Adventure Works";
			}
		}

		const string MSMDPUMPAddress = "https://demos.devexpress.com/Services/OLAP/msmdpump.dll";
        const string AdventureWorksCatalogName = "Adventure Works DW Standard Edition 2026";
        const string AdventureWorksCubeName = "Adventure Works";

		public static string SampleXMLAConnectionString {
			get {
				return string.Format("Provider=msolap;Data Source={0};Initial Catalog={1};Cube Name={2};", MSMDPUMPAddress, AdventureWorksCatalogName, AdventureWorksCubeName);
			}
		}
		protected static string SampleFileName {
			get {
				if(string.IsNullOrEmpty(fSampleFileName)) {
                    string fileName = DevAVDataDirectoryHelper.GetFile(GetAdventureWorksFileName());
                    if(File.Exists(fileName)) {
                        fSampleFileName = Path.GetFullPath(fileName);
                        if(File.Exists(fSampleFileName))
							try {
                            File.SetAttributes(fSampleFileName, FileAttributes.Normal);
							} catch { }
                    }
				}
				return fSampleFileName;
			}
		}

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AllowCubeFile {
			get { return radioFile.Enabled; }
			set { radioFile.Enabled = value; }
		}

		static string GetAdventureWorksFileName() {
			return "AdventureWorks.cub";
		}

		public OLAPConnectionDesigner() {
			InitializeComponent();
			UpdateControls();
			buttonSample.Visible = !string.IsNullOrEmpty(SampleFileName);
			AllowCubeFile = true;
		}

		void radioServer_CheckedChanged(object sender, EventArgs e) {
			UpdateControls();
		}

		void radioFile_CheckedChanged(object sender, EventArgs e) {
			UpdateControls();
		}

		bool wasServer = true;
		string serverName, fileName;
		void UpdateControls() {
			if(wasServer) serverName = editServer.Text;
			else fileName = editServer.Text;

			bool useServer = radioServer.Checked;
			editServer.Properties.Buttons[0].Visible = !useServer;
			editServer.Text = useServer ? serverName : fileName;
			labelServer.Text = useServer ? "Server" : "File";
			listCatalog.Enabled = useServer;
			labelCatalog.Enabled = useServer;
			listCube.Enabled = useServer;
			labelCube.Enabled = useServer;
			wasServer = useServer;
		}

		private void editServer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
			using(OpenFileDialog dialog = new OpenFileDialog()) {
				dialog.Filter = "Cube files (*.cub)|*.cub";
				if(dialog.ShowDialog() == DialogResult.OK) {
					OpenCubeFile(dialog.FileName);
				}
			}
		}

		bool OpenCubeFile(string fileName) {
			return OpenCubeFile(fileName, true);
		}
		bool OpenCubeFile(string fileName, bool showBalloons) {
			try {
				editServer.Text = fileName;
				metaGetter.ConnectionString = "Provider=msolap;Data Source=" + editServer.Text;
				if(!metaGetter.Connected) {
					if(showBalloons) ShowBalloon("Invalid cube file.", "Error", editServer);
					return false;
				}
				List<string> catalogs = metaGetter.GetCatalogs();
				if(catalogs == null || catalogs.Count == 0) {
					if(showBalloons) ShowBalloon("There is no catalogs in the cube file.", "Error", editServer);
					return false;
				}
				listCatalog.EditValue = catalogs[0];
				List<string> cubes = metaGetter.GetCubes(catalogs[0]);
				if(cubes == null || cubes.Count == 0) {
					if(showBalloons) ShowBalloon("There is no cubes in the cube file.", "Error", editServer);
					return false;
				}
				listCube.EditValue = cubes[0];
				return true;
			} finally {
				metaGetter.Connected = false;
			}
		}

		void ShowBalloon(string text, string caption, Control control) {
			ToolTipControllerShowEventArgs eShow = toolTipController1.CreateShowArgs();
			eShow.ToolTip = text;
			eShow.Title = caption;
			eShow.IconType = ToolTipIconType.Error;
			eShow.IconSize = ToolTipIconSize.Small;
			toolTipController1.ShowHint(eShow, control);
		}

		private void listCatalog_QueryPopUp(object sender, CancelEventArgs e) {
			if(!String.IsNullOrEmpty(editServer.Text)) {
				metaGetter.ConnectionString = "Provider=msolap;Data Source=" + editServer.Text;
				if(!metaGetter.Connected) ShowBalloon("Couldn't connect to the server.", "Error", editServer);
				List<string> catalogs = metaGetter.GetCatalogs();
				if(catalogs != null) {
					listCatalog.Properties.Items.Clear();
					listCatalog.Properties.Items.AddRange(catalogs);
					e.Cancel = false;
				} else e.Cancel = true;
			} else e.Cancel = true;
		}

		private void listCube_QueryPopUp(object sender, CancelEventArgs e) {
			if(!String.IsNullOrEmpty(editServer.Text)) {
				metaGetter.ConnectionString = "Provider=msolap;Data Source=" + editServer.Text;
				if(!metaGetter.Connected) {
					ShowBalloon("Couldn't connect to the server.", "Error", editServer);
					e.Cancel = true;
					return;
				}
				string catalogName = null;
				if(!String.IsNullOrEmpty((string)listCatalog.EditValue)) {
					catalogName = (string)listCatalog.EditValue;
					metaGetter.ConnectionString += ";Initial Catalog=" + catalogName;
				}
				if(!metaGetter.Connected) {
					ShowBalloon("Couldn't connect to the \"" + catalogName + "\" database.", "Error", listCatalog);
					e.Cancel = true;
					return;
				}
				List<string> cubes = metaGetter.GetCubes(catalogName);
				if(cubes != null) {
					listCube.Properties.Items.Clear();
					if(cubes.Count == 0) {
						ShowBalloon("There are no cubes in the \"" + catalogName + "\" database.", "Error", listCube);
						e.Cancel = true;
						return;
					}
					listCube.Properties.Items.AddRange(cubes);
					e.Cancel = false;
				} else e.Cancel = true;
			} else e.Cancel = true;
		}

		void simpleButton1_Click(object sender, EventArgs e) {
			if(AllowCubeFile) {
				radioFile.Checked = true;
				if(OpenCubeFile(fSampleFileName))
					DialogResult = DialogResult.OK;
			}
			else {
				editServer.Text = MSMDPUMPAddress;
				listCatalog.Text = AdventureWorksCatalogName;
				listCube.Text = AdventureWorksCubeName;
			}
		}

		void buttonOK_Click(object sender, EventArgs e) {
			if(radioServer.Checked)
				ConnectToServer();
			else
				ConnectToCubeFile();
		}

		void ConnectToCubeFile() {
			if(string.IsNullOrEmpty(editServer.Text) ||
				string.IsNullOrEmpty(listCatalog.EditValue as string) || string.IsNullOrEmpty(listCube.EditValue as string)) return;
			DialogResult = DialogResult.OK;
		}
		void ConnectToServer() {
			string server = radioServer.Checked ? "server" : "cube file";
			if(String.IsNullOrEmpty(editServer.Text)) {
				ShowBalloon("Please specify the " + server + ".", "Error", editServer);
				return;
			}
			metaGetter.ConnectionString = "Provider=msolap;Data Source=" + editServer.Text;
			if(!metaGetter.Connected) {
				ShowBalloon("Couldn't connect to the " + server + ". Please check that it is correct.", "Error", editServer);
				return;
			}
			string catalogName = (string)listCatalog.EditValue;
			if(!String.IsNullOrEmpty(catalogName))
				metaGetter.ConnectionString += ";Initial Catalog=" + catalogName;
			else {
				ShowBalloon("Please specify the database name.", "Error", listCatalog);
				return;
			}
			if(!metaGetter.Connected) {
				ShowBalloon("Couldn't connect to the \"" + catalogName + "\" database. Please check that it is correct.", "Error", listCatalog);
				return;
			}
			List<string> cubes = metaGetter.GetCubes(catalogName);
			if(cubes != null) {
				string cubeName = (string)listCube.EditValue;
				if(string.IsNullOrEmpty(cubeName)) {
					ShowBalloon("Please specify the cube name.", "Error", listCube);
					return;
				}
				if(!cubes.Contains(cubeName)) {
					ShowBalloon("Couldn't connect to the \"" + cubeName + "\" cube. Please check that it is correct.", "Error", listCube);
					return;
				}
			}
			DialogResult = DialogResult.OK;
		}

		private void listCatalog_SelectedValueChanged(object sender, EventArgs e) {
			listCube.EditValue = "";
		}

	}
}

