using DevExpress.StockMarketTrader.ViewModel;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Drawing;

namespace DevExpress.StockMarketTrader {
    public partial class StockMarketView : XtraForm {
        public static RealTimeDataViewModel defaultViewModel;
        public StockMarketView() {
            SplashScreenManager.ShowForm(this, typeof(SplashScreen1), true, true);
            InitializeComponent();
            defaultViewModel = new RealTimeDataViewModel(new System.Windows.Forms.Timer());
            Load += StockMarketView_Load;
        }
        void StockMarketView_Load(object sender, EventArgs e) {
            SplashScreenManager.CloseForm();
            Icon = new Icon(typeof(StockMarketView).Assembly.GetManifestResourceStream(@"DevExpress.StockMarketTrader.Images.DX.ico"));
            ShowIcon = true;
            Text = "DevExpress Stock Market";
            stockWorkspacesUC2.panelContainer1.Size = new Size((int)(Width * 0.33), stockWorkspacesUC2.panelContainer1.Height);
        }
        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            RealTimeDataViewModel.IsReady = true;
        }
    }
}
