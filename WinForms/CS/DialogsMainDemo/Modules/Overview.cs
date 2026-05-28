using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.Internal;
using DevExpress.Utils;
using DevExpress.Utils.About;
using DevExpress.XtraEditors;

namespace DevExpress.XtraDialogs.Demos {
    public partial class Overview : TutorialControl {
        public Overview() {
            InitializeComponent();
            this.initialPath = Path.GetDirectoryName(DataDirectoryHelper.GetDataFile(defaultFileName));
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { WhatsThisXMLFileName }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "Overview"; }
        }
        string initialPath = string.Empty;
        const string defaultFileName = "DemoText.txt";
        void OpenItemClick(object sender, EventArgs e) {
            //<loadButton>
            using(var dialog = new DevExpress.XtraEditors.XtraOpenFileDialog()) {
                dialog.InitialDirectory = initialPath;
                dialog.ShowDragDropConfirmation = true;
                dialog.AutoUpdateFilterDescription = false;
                dialog.Filter = "Text files (*.txt)|*.txt|All Files (*.*)|*.*";
                var dialogResult = dialog.ShowDialog();
                if(dialogResult == DialogResult.OK) {
                    if(Path.GetExtension(dialog.FileName).ToLower() == ".txt")
                        this.mainModule.LoadDocument(dialog.FileName);
                    else
                        XtraMessageBox.Show(this, "Invalid file format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //</loadButton>
        }
        void SaveItemClick(object sender, EventArgs e) {
            //<saveButton>
            using(var dialog = new DevExpress.XtraEditors.XtraSaveFileDialog()) {
                dialog.InitialDirectory = initialPath;
                dialog.ShowDragDropConfirmation = true;
                dialog.Filter = "Text files|*.txt";
                dialog.CreatePrompt = true;
                dialog.OverwritePrompt = true;
                var dialogResult = dialog.ShowDialog();
                if(dialogResult == DialogResult.OK) {
                    this.mainModule.SaveDocument(dialog.FileName);
                }
            }
            //</saveButton>
        }
        void SetWorkingFolderItemClick(object sender, EventArgs e) {
            //<workingFolderButton>
            using(XtraFolderBrowserDialog dialog = new XtraFolderBrowserDialog()) {
                dialog.DialogStyle = Utils.CommonDialogs.FolderBrowserDialogStyle.Wide;
                dialog.SelectedPath = initialPath;
                if(dialog.ShowDialog() == DialogResult.OK) {
                    this.initialPath = dialog.SelectedPath;
                }
            }
            //</workingFolderButton>
        }
        void MainModule_DocumentLoaded(object sender, System.EventArgs e) {
            this.saveButton.Enabled = true;
        }
    }
}
