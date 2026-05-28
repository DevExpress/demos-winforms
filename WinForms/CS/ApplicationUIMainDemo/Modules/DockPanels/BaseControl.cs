using DevExpress.XtraBars.Docking;
using DevExpress.DXperience.Demos;

namespace DevExpress.ApplicationUI.Demos {
    /// <summary>
    /// Summary description for BaseControl.
    /// </summary>
    public partial class BaseControl : DevExpress.XtraEditors.XtraUserControl {
        public BaseControl() {
            InitializeComponent();
        }
        private void dockManager1_RegisterDockPanel(object sender, DevExpress.XtraBars.Docking.DockPanelEventArgs e) {
            if(!DesignMode)
                e.Panel.ImageIndex = TutorialConstants.Random.Next(svgImageCollection1.Count);
        }
        public DockManager Manager { get { return dockManager1; } }
    }
}
