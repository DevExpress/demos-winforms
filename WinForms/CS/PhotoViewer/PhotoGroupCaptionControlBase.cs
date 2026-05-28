using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;

namespace PhotoViewer {
    public partial class PhotoGroupCaptionControlBase : UserControl {
        public PhotoGroupCaptionControlBase() {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            InitializeComponent();
        }

        MainForm mainForm;
        [DefaultValue(null)]
        public MainForm MainForm {
            get { return mainForm; }
            set { mainForm = value; }
        }
        protected virtual void OnGroupIconClick(object sender, EventArgs e) { }
        protected virtual void OnEditButtonClick(object sender, EventArgs e) { }
        protected virtual void OnRemoveButtonClick(object sender, EventArgs e) { }
        protected virtual void OnCollageButtonClick(object sender, EventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own collage settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected virtual void OnSlideShowButtonClick(object sender, EventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own slideshow settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        protected virtual void OnFilmButtonClick(object sender, EventArgs e) {
            XtraMessageBox.Show(this, "Here you can show your own film settings dialog.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
