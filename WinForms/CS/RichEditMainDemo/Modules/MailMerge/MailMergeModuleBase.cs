using System;
using System.Collections.Generic;
using System.Data.OleDb;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Demos.Forms;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;

namespace DevExpress.XtraRichEdit.Demos.Modules.MailMerge {
    public class MailMergeModuleBase : TutorialControl {
        protected virtual GridView TopLevelRecordSelector { get; }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            FillDataSourceCore();
        }
        void FillDataSourceCore() {
            string path = DemoUtils.GetRelativePath("nwind.mdb");
            if(path.Length <= 0)
                return;
            using(OleDbConnection connection = new OleDbConnection()) {
                DemoUtils.SetConnectionString(connection, path);
                FillDataSource(connection);
            }
        }
        protected virtual void FillDataSource(OleDbConnection connection) {

        }
        public void MergeToNewDocumentClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            try {
                using(MergeDatabaseRecordsForm form = new MergeDatabaseRecordsForm()) {
                    if(form.ShowDialog(this) == DialogResult.OK) {
                        MailMergeOptions options = RichEdit.CreateMailMergeOptions();
                        UpdateMailMergeOptions(form.MergeRecords, options);
                        if(form.MergeDestination == MergeDestination.NewTab)
                            MailMergeToNewControl(options);
                        else
                            MailMergeToNewFile(options);
                    }
                }
            }
            catch(Exception ex) {
                XtraMessageBox.Show($"Mail Merge failed:{Environment.NewLine}{ex.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected void UpdateMailMergeOptions(MergeRecords recordsMode, MailMergeOptions options) {
            if(recordsMode == MergeRecords.Selected && TopLevelRecordSelector != null) {
                int[] selectedRowIndexes = TopLevelRecordSelector.GetSelectedRows();
                List<object> selectedRows = selectedRowIndexes.Select(TopLevelRecordSelector.GetRow).ToList();
                options.DataSource = selectedRows;
            }
            options.MergeMode = MergeMode.NewSection;
        }
        void MailMergeToNewControl(MailMergeOptions options) {
            using(MergeResultingDocumentForm form = new MergeResultingDocumentForm()) {
                RichEdit.Document.MailMerge(options, form.Document);
                form.ShowDialog(this);
            }
        }
        void MailMergeToNewFile(MailMergeOptions options) {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog()) {
                saveFileDialog.Filter = "Word 2007 Document (*.docx)|*.docx";
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.CheckFileExists = false;
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.DereferenceLinks = true;
                saveFileDialog.ValidateNames = true;
                if(saveFileDialog.ShowDialog(this) != DialogResult.OK)
                    return;
                string fileName = saveFileDialog.FileName;
                RichEdit.Document.MailMerge(options, fileName, DocumentFormat.OpenXml);
                if(XtraMessageBox.Show("Do you want to open this file?", "Mail Merge", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    DevExpress.Data.Utils.SafeProcess.Start(fileName);
            }
        }
    }
}
