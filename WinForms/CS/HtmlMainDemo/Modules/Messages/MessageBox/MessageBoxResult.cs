using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.HTML.Demos {
    public partial class MessageBoxResult : XtraUserControl {
        public MessageBoxResult() {
            InitializeComponent();
        }
        public void Output(object val) {
            memoEdit1.Text += val.ToString() + Environment.NewLine;
            memoEdit1.SelectionStart = Int32.MaxValue;
            memoEdit1.ScrollToCaret();
        }
    }
}
