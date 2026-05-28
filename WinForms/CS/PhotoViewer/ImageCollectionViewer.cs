using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using System.IO;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Repository;

namespace PhotoViewer {
    public partial class ImageCollectionViewer : XtraUserControl {
        List<string> filesCore;
        string thumbPathCore;
        public ImageCollectionViewer(List<string> files, string thumbPath) {
            this.filesCore = files;
            this.thumbPathCore = thumbPath;
            InitializeComponent();
            InitializeGallery();
        }

        public List<string> Files { get { return filesCore; } }
        public string ThumbPath { get { return thumbPathCore; } }

        protected void InitializeGallery() {
            foreach(string file in Files) {
                galleryControl1.Gallery.Groups[0].Items.Add(CreateGalleryItem(file));        
            }
            galleryControl1.Gallery.Groups[0].Items[0].Checked = true;
            if(Files.Count == 1) {
                dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
                dockManager1.RemovePanel(dockPanel1);
            }
        }

        protected virtual GalleryItem CreateGalleryItem(string file) {
            GalleryItem item = new GalleryItem();
            item.Image = ThumbnailHelper.Default.GetThumbnail(file, 208, ThumbPath);
            if(item.Image != null)
                item.Tag = file;
            return item;
        }

        private void galleryControl1_Gallery_ItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            if(e.Item.Checked) {
                if(Parent == null)
                    UpdateImage();
                else
                    galleryControl1.Gallery.ScrollTo(e.Item, true, DevExpress.Utils.VertAlignment.Center);
            }
        }

        private void leftLabel_Click(object sender, EventArgs e) {
            GalleryItem item = GetCheckedItem();
            int itemIndex = item.GalleryGroup.Items.IndexOf(item);
            itemIndex = Math.Max(0, itemIndex - 1);
            item.GalleryGroup.Items[itemIndex].Checked = true;
        }

        private void rightLabel_Click(object sender, EventArgs e) {
            GalleryItem item = GetCheckedItem();
            int itemIndex = item.GalleryGroup.Items.IndexOf(item);
            itemIndex = Math.Min(item.GalleryGroup.Items.Count - 1, itemIndex + 1);
            item.GalleryGroup.Items[itemIndex].Checked = true;
        }

        protected virtual GalleryItem GetCheckedItem() {
            foreach(GalleryItem item in galleryControl1.Gallery.Groups[0].Items) {
                if(item.Checked)
                    return item;
            }
            return null;
        }

        private void galleryControl1_Gallery_EndScroll(object sender, EventArgs e) {
            BeginInvoke(new MethodInvoker(UpdateImage));
        }
        public void UpdateImage() {
            pictureEdit1.LoadAsync((string)GetCheckedItem().Tag);
        }
        private void UpdatePreviewImage() {
            if(dockPanel2_Container.Controls.Count > 0) {
                SimpleFilterParams fp = (SimpleFilterParams)dockPanel2_Container.Controls[0];
                fp.ImageToFilter = pictureEdit1.Image;
            }
        }
        public void SetFilter(FilterInfo info) {
            if(dockPanel2_Container.Controls.Count > 0) {
                SimpleFilterParams paramsControl = dockPanel2_Container.Controls[0] as SimpleFilterParams;
                if(paramsControl != null) {
                    paramsControl.ApplyFilter -= new EventHandler(OnApplyFilter);
                    dockPanel2_Container.Controls.Remove(paramsControl);
                    paramsControl.Dispose();
                }
                dockPanel2_Container.Controls.Clear();
            }
            if(info != null) {
                SimpleFilterParams pc = info.CreateParamsControl();
                pc.Dock = DockStyle.Fill;
                pc.ApplyFilter += new EventHandler(OnApplyFilter);
                dockPanel2.Text = info.Name;
                dockPanel2_Container.Controls.Add(pc);
                UpdatePreviewImage();
            }
        }
        protected override void OnParentChanged(EventArgs e) {
            base.OnParentChanged(e);
            if(Parent == null && dockPanel2_Container.Controls.Count > 0) { 
                ((SimpleFilterParams)dockPanel2_Container.Controls[0]).ApplyFilter -= new EventHandler(OnApplyFilter);
            }
        }
        private void OnApplyFilter(object sender, EventArgs e) {
            SimpleFilterParams paramsControl = dockPanel2_Container.Controls[0] as SimpleFilterParams;
            if(paramsControl == null)
                return;
            Image oldImage = pictureEdit1.Tag == null? null: pictureEdit1.Image;
            if(pictureEdit1.Tag == null)
                pictureEdit1.Tag = pictureEdit1.Image;
            pictureEdit1.Image = FilterHelper.ApplyFilter(paramsControl.Filter.Name, pictureEdit1.Image, paramsControl.GetParams());
            if(oldImage != null)
                oldImage.Dispose();
            MainForm form = (MainForm)FindForm();
            form.UpdateCancelButtonEnabledState();
        }

        public void CancelFilters() {
            Image oldImage = pictureEdit1.Image;
            if(pictureEdit1.Tag != null) {
                pictureEdit1.Image = (Image)pictureEdit1.Tag;
                pictureEdit1.Tag = null;
            }
        }
        internal bool IsImageFilterd() {
            return pictureEdit1.Tag != null;
        }

        private void pictureEdit1_LoadCompleted(object sender, EventArgs e) {
            UpdatePreviewImage();
        }

        internal void SetMenuManager(RibbonBarManager ribbonBarManager) {
            pictureEdit1.MenuManager = ribbonBarManager;
        }
    }
}
