using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;

namespace DevExpress.RealtorWorld.Win {
    public partial class ucBrowser : BaseModule {
        string url_string = "http://www.zillow.com/";
        public ucBrowser() {
            InitializeComponent();
        }
        public override string ModuleCaption { get { return "zillow.com"; } }
        public override bool AllowWaitDialog { get { return false; } }
        internal override void ShowModule(object item) {
            if(webBrowser1.Url == null || webBrowser1.Url.AbsoluteUri != url_string) {
                SplashScreenManager.ShowDefaultWaitForm(FindForm(), false, true, false, 0);
                Navigate();
            }
            base.ShowModule(item);
        }
        internal void Navigate() {
            webBrowser1.Navigate(url_string);
        }
        internal void RefreshBrowser() {
            webBrowser1.Refresh();
        }
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e) {
            SplashScreenManager.CloseForm(false);
        }
    }
}
