using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PhotoViewer {
    public partial class AlbumPropertiesForm : XtraForm {
        public AlbumPropertiesForm() {
            InitializeComponent();
        }
        public AlbumPropertiesForm(PhotoViewerData viewData) : this() {
            this._viewData = viewData;
        }

        PhotoViewerData _viewData;
        [DefaultValue(null)]
        public PhotoViewerData ViewData {
            get { return _viewData; }
            set { _viewData = value; }
        }
        bool isEditExistingAlbumMode = false;
        [DefaultValue(false)]
        public bool IsEditExistingAlbumMode {
            get { return isEditExistingAlbumMode; }
            set { isEditExistingAlbumMode = value; }
        }
        private void simpleButton2_Click(object sender, EventArgs e) {
            if(CheckAlbumProperties()) {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        protected virtual bool CheckAlbumProperties() {
            string _albumName = albumNameEdit.Text.Trim();
            string messageCaption = IsEditExistingAlbumMode ? "Edit Album" : "New Album";
            if(string.IsNullOrEmpty(_albumName)) {
                XtraMessageBox.Show(this, "Error: please type album name.", messageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            foreach(AlbumData album in ViewData.Albums) {
                if(album.Name == _albumName && !IsEditExistingAlbumMode) {
                    XtraMessageBox.Show(this, $"Error: album with the name '{albumNameEdit.Text}' already exists in albums collection. Please type another name.", messageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void NewAlbumForm_Load(object sender, EventArgs e) {
            _albumDate.DateTime = DateTime.Now;
        }
        [DefaultValue("")]
        public string AlbumName {
            get {
                return albumNameEdit.Text;
            }
            set {
                albumNameEdit.Text = value;
            }
        }
        [DefaultValue(null)]
        public DateTime AlbumDate {
            get {
                return _albumDate.DateTime;
            }
            set {
                _albumDate.DateTime = value;
            }
        }
        [DefaultValue("")]
        public string AlbumDescription {
            get {
                return albumDescriptionCore.Text;
            }
            set {
                albumDescriptionCore.Text = value;
            }
        }
    }
}
