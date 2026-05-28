using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PhotoViewer {
    public partial class SimpleFilterParams : XtraUserControl {
        FilterInfo filterInfo;
        
        public SimpleFilterParams() {
            InitializeComponent();
        }

        public virtual object[] GetParams() => new object[] { };
        [DefaultValue(null)]
        public FilterInfo Filter {
            get { return filterInfo; }
            set { filterInfo = value; }
        }
        Image imageToFilterCore;
        [DefaultValue(null)]
        public Image ImageToFilter {
            get { return imageToFilterCore; }
            set {
                if(ImageToFilter == value)
                    return;
                imageToFilterCore = value;
                OnImageToFilterChanged();
            }
        }
        private void OnImageToFilterChanged() {
            Image img = pictureEdit1.Tag as Image;
            if(img != null)
                img.Dispose();
            pictureEdit1.Tag = null;
            img = pictureEdit1.Image;
            pictureEdit1.Image = null;
            if(img != null)
                img.Dispose();
            if(ImageToFilter != null) {
                pictureEdit1.Image = ThumbnailHelper.Default.CreateThumbnail(ImageToFilter, 128);
                UpdatePreview();
            }
        }
        public event EventHandler ApplyFilter {
            add { applyFilterButton.Click += value; }
            remove { applyFilterButton.Click -= value; }
        }
        public virtual void UpdatePreview() {
            Image oldImage = pictureEdit1.Tag == null? null: pictureEdit1.Image;
            if(pictureEdit1.Tag == null)
                pictureEdit1.Tag = pictureEdit1.Image;
            if(pictureEdit1.Tag == null)
                return;
            pictureEdit1.Image = FilterHelper.ApplyFilter(Filter.Name, (Image)pictureEdit1.Tag, GetParams());
            if(oldImage != null)
                oldImage.Dispose();
        }
        protected override void OnParentChanged(EventArgs e) {
            base.OnParentChanged(e);
            if(Parent != null && Filter != null)
                UpdatePreview();
            else if(Parent == null) {
                ImageToFilter = null;
            }
        }
    }
}
