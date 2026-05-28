using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.ViewInfo;

namespace DevExpress.XtraLayout.Demos {
    public partial class ImageLayout : TutorialControl {
        public ImageLayout() {
            InitializeComponent();
            barcelonaPE.Properties.Caption.Text = @"Barcelona"+Environment.NewLine+ "L'Arc de Triomf";
            londonPE.Properties.Caption.Text = @"London" + Environment.NewLine + "Tower Bridge";
            moscowPE.Properties.Caption.Text = @"Moscow" + Environment.NewLine + "Bolshoi Theatre";
            parisPE.Properties.Caption.Text = @"Paris" + Environment.NewLine + "Eiffel Tower";
            berlinPE.Properties.Caption.Text = @"Berlin" + Environment.NewLine + "Red City Hall";
            newYorkPE.Properties.Caption.Text = @"New York" + Environment.NewLine + "Empire State Building";
        }
        protected override string WhatsThisXMLFileName { get { return "ImageLayout"; } }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ImageLayout" }; } }

        static object hoverPictureEdit = new object();
        private void PictureEdit1_PaintEx(object sender, XtraGrid.PaintExEventArgs e) {
            PictureEdit pictureEdit = sender as PictureEdit;
            if(pictureEdit != null) {
                if(object.Equals(pictureEdit.Tag, hoverPictureEdit)) {
                    Rectangle drawRectangle = new Rectangle(Point.Empty, pictureEdit.Size);
                    e.Cache.FillRectangle(Color.FromArgb(150, 0, 0, 0), drawRectangle);
                    drawRectangle.Inflate(ScaleHelper.ScaleHorizontal(-10), ScaleHelper.ScaleHorizontal(-10));
                    pictureEdit.Properties.Caption.Appearance.DrawString(e.Cache, pictureEdit.Properties.Caption.Text, drawRectangle);
                }
            }
        }

        private void pictureEdit1_MouseEnter(object sender, EventArgs e) {
            PictureEdit pictureEdit = sender as PictureEdit;
            if(pictureEdit != null)
                pictureEdit.Tag = hoverPictureEdit;
        }

        private void pictureEdit1_MouseLeave(object sender, EventArgs e) {
            PictureEdit pictureEdit = sender as PictureEdit;
            if(pictureEdit != null)
                pictureEdit.Tag = null;
        }
        //<imagesLayoutControl>
        protected override void OnParentChanged(EventArgs e) {
            base.OnParentChanged(e);
            XtraForm ownerForm = FindForm() as XtraForm;
            if(ownerForm != null) {
                ownerForm.ApplyAcrylicAccent(imagesLayoutControl);
                ownerForm.ApplyAcrylicAccent(mainLayoutControl);
            }
        }
        //</imagesLayoutControl>

        private void dataLayoutControl2_SizeChanged(object sender, EventArgs e) {
            int min = Math.Min(lciImagesLayoutControl.Width, lciImagesLayoutControl.Height);
            min = Math.Min(ScaleHelper.ScaleHorizontal(800), min);
            imagesLayoutControl.MaximumSize = new Size(min, min);
        }
    }
}
