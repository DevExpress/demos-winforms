using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.About;

namespace DevExpress.ProductsDemo.Win.Controls {
    public partial class HelpControl : RibbonApplicationUserControl {
        Form aboutPanel;
        bool isLoaded;
        public HelpControl() {
            InitializeComponent();
            this.Load += new EventHandler(HelpControl_Load);
        }

        void HelpControl_Load(object sender, EventArgs e) {
            if(isLoaded) return;
            aboutPanel = new AboutForm12(new ProductInfo(ProductKind.DXperienceWin));
            aboutPanel.TopLevel = false;
            aboutPanel.Parent = splitContainer1.Panel2;
            ResizeAbout();
            aboutPanel.Show();
            splitContainer1.Panel2.Resize += new EventHandler(Panel2_Resize);
            ResizeAbout();
            isLoaded = true;
        }

        void Panel2_Resize(object sender, EventArgs e) {
            ResizeAbout();
        }
        void ResizeAbout() {
            Panel pnl = aboutPanel.Parent as Panel;
            aboutPanel.Location = new Point((pnl.Width - aboutPanel.Width) / 2, (pnl.Height - aboutPanel.Height) / 2);
        }
        private void galleryControlGallery1_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            string link = string.Format("{0}", e.Item.Tag);
            switch(link) {
                case "LinkHelp": link = AssemblyInfo.DXLinkHelp; break;
                case "LinkGetSupport": link = AssemblyInfo.DXLinkGetSupport; break;
                case "LinkGetStarted": link = AssemblyInfo.DXLinkGetStartedWinGrid; break;
            }
            if(!string.IsNullOrEmpty(link)) ObjectHelper.StartProcess(link);
        }
    }
}
