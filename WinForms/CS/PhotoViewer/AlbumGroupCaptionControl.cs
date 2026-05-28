using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PhotoViewer {
    public partial class AlbumGroupCaptionControl : PhotoGroupCaptionControlBase {
        public AlbumGroupCaptionControl() {
            InitializeComponent();
        }

        AlbumData albumData;
        [DefaultValue(null)]
        public AlbumData Album {
            get { return albumData; }
            set {
                if(Album == value)
                    return;
                albumData = value;
                OnAlbumChanged();
            }
        }

        protected virtual void OnAlbumChanged() {
            nameLabel.Text = Album.Name;
            dataLabel.Text = Album.Date.ToLongDateString();
        }
        protected override void OnRemoveButtonClick(object sender, EventArgs e) {
            if(MainForm != null)
                MainForm.RemoveAlbum(Album);
        }
        protected override void OnEditButtonClick(object sender, EventArgs e) {
            if(MainForm != null)
                MainForm.EditAlbum(Album);
        }
        public void HideEditButtons() {
            removeLabel.Visible = false;
            editLabel.Visible = false;
            separatorLabel.Visible = false;
        }
    }
}
