using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;

namespace DevExpress.HTML.Demos {
    public partial class PreviewCoreContentProperties : XtraUserControl {
        public PreviewCoreContentProperties() {
            InitializeComponent();
            propertyGridControl1.StyleChanged += delegate { BestFitHeight(); };
        }
        public PropertyGridControl Properties {
            get { return propertyGridControl1; }
        }
        public virtual void BestFitHeight() { }
    }
}
