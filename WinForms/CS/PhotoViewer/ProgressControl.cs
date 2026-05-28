using System.ComponentModel;
using DevExpress.XtraEditors;

namespace PhotoViewer {
    public partial class ProgressControl : XtraUserControl {
        public ProgressControl() {
            InitializeComponent();
        }
        [DefaultValue(0)]
        public int Maximum {
            get {
                return progressBarControl1.Properties.Maximum;
            }
            set {
                progressBarControl1.Properties.Maximum = value;
            }
        }
        [DefaultValue(0)]
        public int Value {
            get {
                return (int)progressBarControl1.EditValue;
            }
            set {
                progressBarControl1.EditValue = value;
            }
        }
        [DefaultValue("")]
        public string ProgressText {
            get {
                return labelControl1.Text;
            }
            set {
                labelControl1.Text = value;
            }
        }
    }
}
