using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Xpo;

namespace DevExpress.Xpo.Demos {
    public partial class SimpleDataAwareApplication : TutorialControl {
        public SimpleDataAwareApplication() {
            InitializeComponent();
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
        private void SimpleDataAwareApplication_Load(object sender, System.EventArgs e) {
            // If the 'Customer' table is empty, adds new records and reloads the xpCustomers collection.
            if(xpCustomers.Count == 0) {
                CreateCustomers();
                xpCustomers.Reload();
            }
        }

        public override void ReloadData() {
            xpCustomers.Reload();
        }
    }
}
