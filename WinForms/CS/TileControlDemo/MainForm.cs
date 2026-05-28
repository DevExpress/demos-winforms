using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.XtraBars.Demos.TileControlDemo {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.userControl11.OnDesktopClick += userControl11_OnDesktopClick;
        }

        void userControl11_OnDesktopClick(object sender, EventArgs e) {
            this.Close();
        }
    }
}
