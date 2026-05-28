using System.ComponentModel;
using System.Drawing;

namespace DevExpress.ApplicationUI.Demos {
    public partial class WeatherItem : XtraEditors.XtraUserControl {
        public WeatherItem() {
            InitializeComponent();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Sity {
            get { return labelControl1.Text; }
            set { labelControl1.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Temperature {
            get { return labelControl2.Text; }
            set { labelControl2.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string SkyConditions {
            get { return labelControl3.Text; }
            set { labelControl3.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string RelativeHumidity {
            get { return labelControl4.Text; }
            set { labelControl4.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Image {
            get { return windowsUIButtonPanel1.Buttons[0].Properties.Image; }
            set { windowsUIButtonPanel1.Buttons[0].Properties.Image = value; }
        }
    }
}
