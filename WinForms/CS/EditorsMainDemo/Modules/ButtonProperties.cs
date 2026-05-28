using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
// <icbAlignment>
// <icbKind>
using DevExpress.XtraEditors.Controls;
// </icbKind>
// </icbAlignment>
using DevExpress.Utils;
using DevExpress.XtraEditors;

namespace DevExpress.XtraEditors.Demos {
    public partial class ButtonProperties : XtraUserControl {
        public ButtonProperties(EditorButton button) {
            this.button = button;
            InitializeComponent();
            InitComboBoxes();
            updateValues = true;
            teCaption.Text = button.Caption;
            teToolTip.Text = button.ToolTip;
            icbKind.EditValue = button.Kind;
            seWidth.Value = button.Width;
            ceEnabled.Checked = button.Enabled;
            ceVisible.Checked = button.Visible;
            icbAlignment.EditValue = button.ImageLocation;
            updateValues = false;
        }

        EditorButton button;
        bool updateValues = false;

        void InitComboBoxes() {
            // <icbKind>
            icbKind.Properties.Items.AddEnum(typeof(ButtonPredefines));
            // </icbKind>
            // <icbAlignment>
            icbAlignment.Properties.Items.AddEnum(typeof(ImageLocation));
            // </icbAlignment>
        }

        // <teCaption>
        private void teCaption_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            button.Caption = teCaption.Text;
        }
        // </teCaption>

        // <teToolTip>
        private void teToolTip_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            button.ToolTip = teToolTip.Text;
        }
        // </teToolTip>

        // <icbKind>
        private void icbKind_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            button.Kind = (ButtonPredefines)icbKind.EditValue;
        }
        // </icbKind>

        // <seWidth>
        private void seWidth_EditValueChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            button.Width = Convert.ToInt32(seWidth.Value);
        }
        // </seWidth>

        // <ceEnabled>
        private void ceEnabled_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            button.Enabled = ceEnabled.Checked;
        }
        // </ceEnabled>

        // <ceVisible>
        private void ceVisible_CheckedChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            button.Visible = ceVisible.Checked;
        }
        // </ceVisible>

        // <icbAlignment>
        private void icbAlignment_SelectedIndexChanged(object sender, System.EventArgs e) {
            // <skip>
            if(updateValues) return;
            // </skip>
            button.ImageLocation = (ImageLocation)icbAlignment.EditValue;
        }
        // </icbAlignment>

        // <sbImageLoad>
        private void sbImageLoad_Click(object sender, System.EventArgs e) {
            string file = GetImage();
            if(file == null) return;
            LoadImage(file);
        }

        string GetImage() {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Select image file";
            dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.PNG;*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            if(dialog.ShowDialog(this) == DialogResult.OK) {
                return dialog.FileName;
            }
            return null;
        }

        void LoadImage(string fileName) {
            try {
                Bitmap image = DevExpress.Utils.Controls.ImageHelper.LoadImageFromFileEx(fileName) as Bitmap;
                if(image != null)
                    button.Image = image;
            }
            catch(Exception e) {
                XtraMessageBox.Show(e.Message, "Can't load file");
            }
        }
        //</sbImageLoad>

        // <sbImageClear>
        private void sbImageClear_Click(object sender, System.EventArgs e) {
            button.Image = null;
        }
        // </sbImageClear>
    }
}
