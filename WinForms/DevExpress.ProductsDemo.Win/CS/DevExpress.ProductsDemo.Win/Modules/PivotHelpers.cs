using System.ComponentModel;
using DevExpress.XtraEditors;

namespace DevExpress.ProductsDemo.Win {
    public class PivotTileControl : TileControl {
        [DefaultValue(-1)]
        public int LargeItemWidth {
            get { return ((ITileControlProperties)this).LargeItemWidth; }
            set { ((ITileControlProperties)this).LargeItemWidth = value; }
        }
    }
}
