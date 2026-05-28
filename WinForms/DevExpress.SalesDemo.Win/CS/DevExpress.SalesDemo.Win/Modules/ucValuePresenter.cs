using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.SalesDemo.Win.Modules {
    public partial class ucValuePresenter : DevExpress.XtraEditors.XtraUserControl {
        double doubleValue;
        string valueFormat;

        public Color ValueTextColor {
            get { return labelValue.Appearance.ForeColor; }
            set { labelValue.Appearance.ForeColor = value; }
        }
        public string TitleText {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }
        public string ValueFormat {
            get { return valueFormat; }
            set {
                valueFormat = value;
                UpdateValueText();
            }
        }
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
            if (valueFormat != null)
                labelValue.Text = string.Format(valueFormat, doubleValue);
            else
                labelValue.Text = doubleValue.ToString();
        }
    }
}
