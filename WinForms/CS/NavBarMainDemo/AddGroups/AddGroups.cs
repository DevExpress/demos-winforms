using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DevExpress.XtraNavBar.Demos {
    /// <summary>
    /// Summary description for AddGroups.
    /// </summary>
    public partial class AddGroups : TutorialControl {
        public AddGroups() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            for(int i = 0; i < 3; i++) {
                OnAddGroup();
            }
        }

        //<button2>
        NavBarGroup LastGroup {
            get {
                if(navBarControl1.Groups.Count > 0)
                    return navBarControl1.Groups[navBarControl1.Groups.Count - 1];
                return null;
            }
        }
        //</button2>


        //<button1>
        int i = 0;
        private void button1_Click(object sender, System.EventArgs e) {
            OnAddGroup();
        }
        //</button1>

        //<button2>
        private void button2_Click(object sender, System.EventArgs e) {
            OnRemoveGroup();
        }
        //</button2>

        private void ChangeGroups() {
            button2.Enabled = LastGroup != null;
        }
        private void OnAddGroup() {
            DevExpress.XtraNavBar.NavBarGroup group = navBarControl1.Groups.Add();
            group.Caption = "Group " + (i++).ToString();
            ChangeGroups();
        }
        private void OnRemoveGroup() {
            if(LastGroup != null)
                LastGroup.Dispose();
            ChangeGroups();
        }
    }
}
