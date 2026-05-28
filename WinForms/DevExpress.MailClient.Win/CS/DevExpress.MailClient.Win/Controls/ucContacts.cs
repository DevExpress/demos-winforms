using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.MailClient.Win.Controls {
    public partial class ucContacts : BaseControl {
        public event EventHandler CheckedChanged;
        RibbonGalleryBarItem gallery;
        //bool lockItemCheck = false;
        public ucContacts() {
            InitializeComponent();
            ceList.Tag = TagResources.ContactList;
            ceAlphabetical.Tag = TagResources.ContactAlphabetical;
            ceState.Tag = TagResources.ContactByState;
            ceCards.Tag = TagResources.ContactCard;
        }
        public void SynchronizeGalleryItems(RibbonGalleryBarItem gallery) {
            this.gallery = gallery;
            SetItemCheck(gallery.Gallery.GetAllItems());
            gallery.GalleryItemCheckedChanged += new GalleryItemEventHandler(gallery_GalleryItemCheckedChanged);
        }

        void gallery_GalleryItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            if(e.Item.Checked)
                UpdateCheckEditors(e.Item.Tag.ToString());
        }

        void UpdateCheckEditors(string checkTag) {
            foreach(Control control in pcCheckControls.Controls) {
                CheckEdit edit = control as CheckEdit;
                if(edit != null && edit.Tag.Equals(checkTag)) {
                    edit.Checked = true;
                    break;
                }
            }
        }

        void SetItemCheck(List<DevExpress.XtraBars.Ribbon.GalleryItem> list) {
            string checkTag = string.Empty;
            foreach(Control control in pcCheckControls.Controls) {
                CheckEdit edit = control as CheckEdit;
                if(edit != null && edit.Checked) {
                    checkTag = edit.Tag.ToString();
                    break;
                }
            }
            foreach(GalleryItem item in list)
                if(item.Tag.Equals(checkTag))
                    item.Checked = true;
        }
        private void ce_CheckedChanged(object sender, EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            if(ce.Checked && CheckedChanged != null) {
                SetItemCheck(gallery.Gallery.GetAllItems());
                CheckedChanged(sender, EventArgs.Empty);
            }
        }

        private void ucContacts_Resize(object sender, EventArgs e) {
            labelControl1.Width = this.Width;
        }
    }
}
