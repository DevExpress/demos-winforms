using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.SalesDemo.Win.Modules {
    public partial class ucValuePresenter : UserControl {
        double doubleValue;
        string _valueFormat;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ValueTextColor {
            get { return labelValue.ForeColor; }
            set { labelValue.ForeColor = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TitleText {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string ValueFormat {
            get { return _valueFormat; }
            set {
                _valueFormat = value;
                UpdateValueText();
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double Value {
            get { return doubleValue; }
            set {
                doubleValue = value;
                UpdateValueText();
            }
        }
        public ucValuePresenter() {
            InitializeComponent();
        }
        void UpdateValueText() {
            if (_valueFormat != null)
                labelValue.Text = string.Format(_valueFormat, doubleValue);
            else
                labelValue.Text = doubleValue.ToString();
        }
    }
}
