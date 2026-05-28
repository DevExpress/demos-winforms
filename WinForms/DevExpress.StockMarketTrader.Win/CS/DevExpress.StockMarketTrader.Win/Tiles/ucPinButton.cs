using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.StockMarketTrader.Tiles {
    public partial class ucPinButton : UserControl {
        public ucPinButton() {
            InitializeComponent();
            labelControl1.Appearance.ForeColor = Color.White;
            pictureBox1.Image = Image.FromStream(typeof(ucPinButton).Assembly.GetManifestResourceStream(@"DevExpress.StockMarketTrader.Images.Live-Tile.png"));
            labelControl1.MouseEnter += new EventHandler(labelControl1_MouseEnter);
            labelControl1.MouseLeave += new EventHandler(labelControl1_MouseLeave);
            pictureBox1.MouseEnter += new EventHandler(labelControl1_MouseEnter);
            pictureBox1.MouseLeave += new EventHandler(labelControl1_MouseLeave);
            labelControl1.Click += new EventHandler(labelControl1_Click);
            pictureBox1.Click += new EventHandler(labelControl1_Click);
        }
        public event EventHandler OnButtonClick;
        void labelControl1_Click(object sender, EventArgs e) {
            if(OnButtonClick != null) OnButtonClick(this, e);
        }
        void labelControl1_MouseLeave(object sender, EventArgs e) {
            labelControl1.Appearance.ForeColor = Color.White;
            labelControl1.Appearance.FontStyleDelta &= ~FontStyle.Underline;
        }
        void labelControl1_MouseEnter(object sender, EventArgs e) {
            labelControl1.Appearance.ForeColor = Color.DarkOrange;
            labelControl1.Appearance.FontStyleDelta = FontStyle.Underline;
        }
    }
}
