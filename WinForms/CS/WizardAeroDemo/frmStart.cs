using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e) {
            UserLookAndFeel.Default.SetSkinStyle(SelectedSkinName);
        }
    }
}
