using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraSplashScreen;

namespace DevExpress.ProductsDemo.Win.Forms {
    public partial class ssMain : DemoSplashScreen {
        int dotCount = 0;
        public ssMain() {
            InitializeComponent();
            labelControl1.Text = string.Format("{0}{1}", labelControl1.Text, GetYearString());
            this.DemoText = "Build Your Own Office";
            this.ProductText = "WinForms";
            Timer tmr = new Timer();
            tmr.Interval = 400;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
        }
        void tmr_Tick(object sender, EventArgs e) {
            if(++dotCount > 3) dotCount = 0;
            labelControl2.Text = string.Format("{1}{0}", GetDots(dotCount), DevExpress.ProductsDemo.Win.Properties.Resources.Starting);
        }
        string GetDots(int count) {
            string ret = string.Empty;
            for(int i = 0; i < count; i++) ret += ".";
            return ret;
        }
        int GetYearString() {
            int ret = TutorialConstants.Now.Year;
            return (ret < 2012 ? 2012 : ret);
        }
    }
}
