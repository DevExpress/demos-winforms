using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.XtraVerticalGrid;

namespace DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel {
    public partial class LoginView : XtraLayoutPanelDemoViewBase {
        public LoginView() {
            InitializeComponent();
        }
        public override XtraLayoutPanelBase LayoutPanel { get { return stackPanel; } }
        public StackPanel StackPanel { get { return stackPanel; } }
    }
}
