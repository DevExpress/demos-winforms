using System;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace DevExpress.XtraScheduler.Demos {
	public partial class ColorSchemasEditForm : DevExpress.XtraEditors.XtraForm {
        ISchedulerColorSchemaCollection<SchedulerColorSchemaBase> fColorSchemas;

		public ColorSchemasEditForm(ISchedulerColorSchemaCollection<SchedulerColorSchemaBase> lColorSchemas, Form parent) {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			Left = (int)(parent.Left + (parent.Width - Width) / 2);
			Top = (int)(parent.Top + (parent.Height - Height) / 2);

			this.fColorSchemas = lColorSchemas;

			UpdateColorSchemaList();
		}
        public ISchedulerColorSchemaCollection<SchedulerColorSchemaBase> ColorSchemas { get { return fColorSchemas; } }

		void UpdateColorSchemaList() {
			lbTimeScales.Items.Clear();
			for (int i = 0; i < ColorSchemas.Count; i++) {
				lbTimeScales.Items.Add(String.Format("{0}-{1}", ColorSchemas[i], i));
			}
			lbTimeScales.SelectedIndex = 0;
		}
		private void lbcAppearances_SelectedIndexChanged(object sender, EventArgs e) {
			propertyGrid1.SelectedObjects = GetSelectedObjects();
		}
		object[] GetSelectedObjects() {
			if (lbTimeScales.SelectedItem == null)
				return null;
			return new object[] { ColorSchemas[lbTimeScales.SelectedIndex] };
		}
		private void btnAdd_Click(object sender, EventArgs e) {
			ColorSchemas.Add(new SchedulerColorSchema());
			UpdateColorSchemaList();
		}
		private void btnRemove_Click(object sender, EventArgs e) {
			ColorSchemas.RemoveAt(lbTimeScales.SelectedIndex);
			UpdateColorSchemaList();
		}

		private void btnDefaults_Click(object sender, EventArgs e) {
			ColorSchemas.LoadDefaults();
			UpdateColorSchemaList();
		}
	}
}

