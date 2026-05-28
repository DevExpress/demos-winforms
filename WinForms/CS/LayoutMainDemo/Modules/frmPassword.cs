using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DevExpress.XtraLayout.Demos {
    /// <summary>
    /// Summary description for frmPassword.
    /// </summary>
    public partial class frmPassword : DevExpress.XtraEditors.XtraForm {
        public frmPassword(Rectangle r, bool restoreLayout) {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.Left = r.Left + (r.Width - this.Width) / 2;
            this.Top = r.Top + (r.Height - this.Height) / 2;
            if(restoreLayout) RestoreLayout();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        private CustomizationModes customizationMode;
        public void SetCustomizationMode(CustomizationModes mode) {
            customizationMode = mode;
            layoutControl1.CustomizationMode = customizationMode;
        }
        public static string LayoutFileName = "frmPasswordLayout.xml";
        private void sbCustomization_Click(object sender, System.EventArgs e) {
            layoutControl1.CustomizationMode = customizationMode;
            layoutControl1.ShowCustomizationForm();
           
         //   layoutControl1.CustomizationMode = customizationMode;
        }

        void RestoreLayout() {
            if(System.IO.File.Exists(LayoutFileName))
                layoutControl1.RestoreLayoutFromXml(LayoutFileName);
        }

        public void SaveLayout() {
            layoutControl1.SaveLayoutToXml(LayoutFileName);
        }
    }
}
