using System.Drawing;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.XtraMap.Demos {
    public partial class FooteredMapTutorialControl : MapTutorialControl {
        protected virtual Image CopyrightImage { get { return null; } }
        protected virtual string CopyrightText { get { return string.Empty; } }

        public FooteredMapTutorialControl() {
            InitializeComponent();
            UpdateCopyrights();
        }

        void OnDispose() {
            DisposeCopyrightImage();
        }
        void DisposeCopyrightImage() {
            if(labelControl1.ImageOptions.Image != null) {
                labelControl1.ImageOptions.Image.Dispose();
                labelControl1.ImageOptions.Image = null;
            }
        }
        protected void UpdateCopyrights() {
            DisposeCopyrightImage();
            if(CopyrightImage != null)
                labelControl1.ImageOptions.Image = (Image)CopyrightImage.Clone();
            labelControl2.Text = CopyrightText;
            if(UseEmptyRootPadding) {
                simpleSeparator1.Visibility = LayoutVisibility.Always;
                layoutControlItem3.Padding = new Padding(
                    layoutControlItem3.Padding.Left,
                    layoutControlItem3.Padding.Top + 8,
                    layoutControlItem3.Padding.Right,
                    layoutControlItem3.Padding.Bottom);
            }
        }
    }
}
