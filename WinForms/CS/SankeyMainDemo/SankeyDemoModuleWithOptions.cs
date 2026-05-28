using DevExpress.Utils;

namespace DevExpress.XtraSankey.Demos {
    public partial class SankeyDemoModuleWithOptions : SankeyTutorialControl {
        public SankeyDemoModuleWithOptions() {
            InitializeComponent();
            this.tabPaneOptions.AllowCollapse = DefaultBoolean.True;
        }
    }
}
