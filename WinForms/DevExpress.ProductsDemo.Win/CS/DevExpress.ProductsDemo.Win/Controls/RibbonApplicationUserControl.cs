using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Drawing;

namespace DevExpress.ProductsDemo.Win.Controls {
    public partial class RibbonApplicationUserControl : UserControl {
        public RibbonApplicationUserControl() {
            InitializeComponent();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor {
            get {
                return GetBackgroundColor();
            }
            set {
                base.BackColor = value;
            }
        }
        private Color GetBackgroundColor() {
            BackstageViewClientControl backstageView = Parent as BackstageViewClientControl;
            if(backstageView == null)
                return Color.Transparent;
            return backstageView.GetBackgroundColor();
        }
        public BackstageViewControl BackstageView {
            get {
                if(Parent == null)
                    return null;
                return Parent.Parent as BackstageViewControl;
            }
        }
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            if(BackstageView != null)
                BackstageViewPainter.DrawBackstageViewImage(e, this, BackstageView);
        }
    }
}
