using System;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace DevExpress.MailClient.Win.Forms {
    public partial class ssMain : DemoSplashScreen {
        int dotCount = 0;
        public ssMain() {
            InitializeComponent();
            labelControl1.Text = string.Format("{0}{1}", labelControl1.Text, GetYearString());
            pictureEdit2.Image = global::DevExpress.MailClient.Win.Properties.Resources.SplashScreen;
            Timer tmr = new Timer();
            tmr.Interval = 400;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();
        }

        void tmr_Tick(object sender, EventArgs e) {
            if(++dotCount > 3) dotCount = 0;
            labelControl2.Text = string.Format("{1}{0}", GetDots(dotCount), DevExpress.MailClient.Win.Properties.Resources.Starting);
        }

        string GetDots(int count) {
            string ret = string.Empty;
            for(int i = 0; i < count; i++) ret += ".";
            return ret;
        }
        int GetYearString() {
            int ret = DateTime.Now.Year;
            return (ret < 2012 ? 2012 : ret);
        }
    }
}
