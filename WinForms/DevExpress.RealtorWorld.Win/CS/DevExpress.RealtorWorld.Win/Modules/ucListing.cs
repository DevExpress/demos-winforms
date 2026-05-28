using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;

namespace DevExpress.RealtorWorld.Win {
    public partial class ucListing : BaseModule {
        public ucListing() {
            InitializeComponent();
            pnlList.ItemSize = 120;
            int width = pnlList.ItemSize * 3 / 2;
            ((ITileControl)pnlList).Properties.LargeItemWidth = width;
            pnlList.Width = width + pnlList.Padding.Horizontal + SystemInformation.VerticalScrollBarWidth + 2;
        }
        public override string ModuleCaption { get { return "Listings"; } }
        internal override void InitModule(IDXMenuManager manager, object data) {
            base.InitModule(manager, data);
            TileGroup group = new TileGroup();
            foreach(Home home in DataHelper.Homes) {
                TileItem item = new TileItem();
                item.BackgroundImageScaleMode = TileItemImageScaleMode.ZoomOutside;
                item.BackgroundImageAlignment = TileItemContentAlignment.MiddleCenter;
                item.ItemSize = TileItemSize.Wide;
                item.BackgroundImage = home.Photo;
                item.Padding = new Padding(0, 0, 0, 0);
                item.Text2 = string.Format("<backcolor=108,189,69><color=white>{0} Beds <br>{1} Baths", home.BedsString, home.Baths);
                item.Text3 = string.Format("<backcolor=108,189,69><color=white><size=+3>{0}", home.PriceString);
                //item.Text = string.Format("<size=+1>{0}<size=-2> Beds<br><size=+2>{1}<size=-2> Baths", home.BedsString, home.Baths);
                //item.Text3 = string.Format("<size=+3>{0}", home.PriceString);
                item.TextShowMode = TileItemContentShowMode.Hover;
                item.Tag = home;
                group.Items.Add(item);
            }
            pnlList.Groups.Add(group);
        }
        internal override void ShowModule(object item) {
            base.ShowModule(item);
            ucHomeDetail1.InitData((Home)item);
            DataHelper.SetTileSelectedItem(item, pnlList);
        }
        private void pnlList_ItemClick(object sender, TileItemEventArgs e) {
            ucHomeDetail1.InitData((Home)e.Item.Tag);
        }
    }
}
