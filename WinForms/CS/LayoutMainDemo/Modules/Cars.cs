using DevExpress.DXperience.Demos;
using System;
using System.Data;

namespace DevExpress.XtraLayout.Demos {
    public partial class Cars : BaseTutorialControl {
        public Cars() {
            CreateWaitDialog();
            InitializeComponent();
            InitVehiclesData(vehiclesDataSet1);
            InitPanels();
            layoutControl1.SetDefaultLayout();
            dataNavigator1.PositionChanged += dataNavigator1_PositionChanged;
            dataNavigator1_PositionChanged(null, EventArgs.Empty);
        }
        protected override string WhatsThisXMLFileName {
            get { return "BaseControl"; }
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "BaseControl" }; }
        }
        void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            layoutControl1.BeginUpdate();
            calcEdit1.Enabled = dateEdit1.Enabled = checkEdit1.Checked;
            layoutControl1.EndUpdate();
        }
        void dataNavigator1_PositionChanged(object sender, EventArgs e) {
            hyperLinkEdit1.EditValue = ((VehiclesDataSet.ModelRow)((DataRowView)modelBindingSource.Current).Row).TrademarkRow.Site;
        }
        protected override string FileMask {
            get { return "cars_"; }
        }
        public override LayoutControl BaseLayout {
            get { return layoutControl1; }
        }
    }
}
