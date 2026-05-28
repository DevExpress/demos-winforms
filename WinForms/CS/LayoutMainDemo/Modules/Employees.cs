using DevExpress.DXperience.Demos;

namespace DevExpress.XtraLayout.Demos {
    public partial class Employees : BaseTutorialControl {
		public Employees() {
			CreateWaitDialog();
			InitializeComponent();
			MainFormHelper.UpdateTakeScreenSettings(this);
			InitData();
		}
        protected override string WhatsThisXMLFileName {
			get { return "BaseControl"; }
		}
        protected override string[] WhatsThisCodeFileNames {
			get { return new string[] { "BaseControl" }; }
		}
        void InitData() {
			layoutControl1.SetDefaultLayout();
			InitPanels();
			lookUpEdit1.Properties.DataSource = GetNWindData(dsEmployees1, "Employees");
		}
		public override LayoutControl BaseLayout {
			get { return layoutControl1; }
		}
		protected override string FileMask {
			get { return "nwind_"; }
		}
	}
}
