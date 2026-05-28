using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGauges.Win.Gauges.State;

namespace DevExpress.ApplicationUI.Demos {
    public partial class WidgetControl : XtraEditors.XtraUserControl {
        Timer updateTimer = new Timer();
        readonly static SolidBrush Positive = new SolidBrush(Color.FromArgb(70, 158, 165));
        readonly static SolidBrush Negative = new SolidBrush(Color.FromArgb(165, 70, 113));
        public WidgetControl() {
            InitializeComponent();
            if(components != null) components.Add(updateTimer);
            updateTimer.Interval = 1000;
            updateTimer.Tick += OnTimerTick;
            updateTimer.Start();
            OnTimerTick(this, EventArgs.Empty);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CompanyNameText {
            get { return labelControl1.Text; }
            set { labelControl1.Text = value; }
        }
        int index = 0;
        StockData previousData;
        void OnTimerTick(object sender, EventArgs e) {
            if(IsDisposed) {
                updateTimer.Stop();
                return;
            }
            StockData data = StockDataCreator.GetData(index);
            if(index > 0) {
                decimal d = data.ClosePrice - previousData.ClosePrice;
                decimal dq = (d * 100) / data.ClosePrice;
                labelControl5.Text = Math.Round(d, 2, MidpointRounding.ToEven).ToString("G29");
                stateIndicatorComponent1.StateIndex = (previousData.ClosePrice - data.ClosePrice) < 0 ? 0 : 1;
                if(stateIndicatorComponent1.StateIndex == 0) {
                    labelControl5.ForeColor = Positive.Color;
                    labelControl2.Text = data.ClosePrice.ToString("G29") + "<br><color=70,158,165>" + Math.Round(dq, 2, MidpointRounding.ToEven).ToString("G29") + '%';
                }
                else {
                    labelControl5.ForeColor = Negative.Color;
                    labelControl2.Text = data.ClosePrice.ToString("G29") + "<br><color=165,70,113>" + Math.Round(dq, 2, MidpointRounding.ToEven).ToString("G29") + '%';
                }
            }
            previousData = data;
            index++;
        }
        void OnCustomDrawElement(object sender, DevExpress.XtraGauges.Core.Primitive.CustomDrawElementEventArgs e) {
            StateIndicatorComponent indicator = sender as StateIndicatorComponent;
            Point p1 = Point.Empty;
            Point p2 = Point.Empty;
            Point p3 = Point.Empty;
            int _height = (int)(e.Info.BoundBox.Width * Math.Sqrt(3) / 2);
            p1.X = (int)((int)e.Info.BoundBox.Width / 2);
            p2.X = (int)e.Info.BoundBox.Left;
            p3.X = (int)e.Info.BoundBox.Right;
            int y = (int)((int)(e.Info.BoundBox.Height - _height) / 2);
            if(indicator.StateIndex == 0) {
                p1.Y = y;
                p2.Y = p3.Y = y + _height;
            }
            else {
                p1.Y = y + _height;
                p2.Y = p3.Y = y;
            }
            e.Context.Graphics.FillPolygon((indicator.StateIndex == 0) ? Positive : Negative, new Point[] { p1, p2, p3 });
            e.Handled = true;
        }
    }
}
