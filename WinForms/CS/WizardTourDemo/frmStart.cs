using System;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace DevExpress.XtraWizard.Demos {
    public partial class frmStart : XtraForm {
        public frmStart() {
            InitializeComponent();
            foreach(SkinContainer cnt in SkinManager.Default.Skins) 
                listBoxControl1.Items.Add(cnt.SkinName);
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXI);
            listBoxControl1.SelectedItem = UserLookAndFeel.Default.ActiveSkinName;
        }

        public string SelectedSkinName { get { return listBoxControl1.SelectedItem.ToString(); } }
        public bool AllowAnimation { get { return checkEdit1.Checked; } }
        public bool AllowSkin4Form { get { return checkEdit2.Checked; } }
        public WizardStyle WizardStyle { get { return WizardStyle.Wizard97; } }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e) {
            UserLookAndFeel.Default.SetSkinStyle(SelectedSkinName);
        }
    }
}
