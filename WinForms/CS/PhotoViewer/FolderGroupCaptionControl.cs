using System;
using System.ComponentModel;
using System.IO;

namespace PhotoViewer {
    public partial class FolderGroupCaptionControl : PhotoGroupCaptionControlBase {
        public FolderGroupCaptionControl() {
            InitializeComponent();
        }
        PathData folderData;
        [DefaultValue(null)]
        public PathData Folder {
            get { return folderData; }
            set {
                if(Folder == value)
                    return;
                folderData = value;
                OnFolderChanged();
            }
        }
        protected virtual void OnFolderChanged() {
            nameLabel.Text = Folder.Name;
            dataLabel.Text = Directory.GetCreationTime(Folder.Path).ToShortDateString();
        }
        protected override void OnGroupIconClick(object sender, EventArgs e) {
            DevExpress.Data.Utils.SafeProcess.Start(Folder.Path, string.Empty);
        }
        protected override void OnRemoveButtonClick(object sender, EventArgs e) {
            if(MainForm != null)
                MainForm.RemoveFolder(Folder);
        }
    }
}
