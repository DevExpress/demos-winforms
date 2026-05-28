using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;

namespace DevExpress.XtraCharts.Demos {

    public partial class ChartDemoModuleWithOptions : ChartDemoModule {
        NavigationPaneState optionsPanelStateField;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public NavigationPaneState OptionsPanelState {
            get { return optionsPanelStateField; }
            set {
                optionsPanelStateField = value;
                tabPaneOptions.State = optionsPanelStateField;
            }
        }
        public ChartDemoModuleWithOptions() {
            InitializeComponent();
            tabPaneOptions.AllowCollapse = DefaultBoolean.True;
            tabPaneOptions.State = optionsPanelStateField;
            tabPaneOptions.StateChanged += tabPaneOptions_StateChanged;
        }

        void tabPaneOptions_StateChanged(object sender, StateChangedEventArgs e) {
            optionsPanelStateField = e.State;
        }
    }

}
