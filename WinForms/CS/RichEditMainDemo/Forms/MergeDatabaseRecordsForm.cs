using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DevExpress.XtraRichEdit.Demos.Forms {
    public enum MergeDestination { NewTab, File }
    public enum MergeRecords { All, Current, Selected, FromInterval }

    public partial class MergeDatabaseRecordsForm : XtraForm {
        MergeRecords _mergeRecords;
        MergeDestination _mergeDestination;

        public MergeDatabaseRecordsForm() {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MergeDestination MergeDestination { get { return _mergeDestination; } set { _mergeDestination = value; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MergeRecords MergeRecords { get { return _mergeRecords; } set { _mergeRecords = value; } }

        private void btnOk_Click(object sender, EventArgs e) {
            MergeRecords = GetMergeRecords();
            MergeDestination = (MergeDestination)rgMergeTo.SelectedIndex;
            DialogResult = DialogResult.OK;
            Close();
        }
        private MergeRecords GetMergeRecords() {
            return rgMergeRecords.SelectedIndex == 0 ? MergeRecords.Selected : MergeRecords.All;
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
