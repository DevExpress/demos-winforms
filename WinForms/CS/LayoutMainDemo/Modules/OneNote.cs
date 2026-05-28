using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;

namespace DevExpress.XtraLayout.Demos {
    /// <summary>
    /// Summary description for Employees.
    /// </summary>
    public partial class OneNote : DevExpress.XtraLayout.Demos.TutorialControl {
        public OneNote() {
            // This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog();
            InitializeComponent();

            // TODO: Add any initialization after the InitForm call

        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            webBrowser1.Url = new System.Uri("https://www.devexpress.com/Products/NET/Controls/WinForms/Layout/");
        }
    }
}
