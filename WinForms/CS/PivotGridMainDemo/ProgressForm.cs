using System;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos {
	public partial class ProgressForm : DevExpress.XtraEditors.XtraForm {
		public ProgressForm(Form parent) {
			InitializeComponent();
			if(parent != null) {
                Left = parent.Left + (int)((parent.Width - Width) / 2);
                Top = parent.Top + (int)((parent.Height - Height) / 2);
			}
			this.Height = progressBarControl1.Height + progressBarControl1.Top * 2 + 4;
		}

		public void SetProgressValue(int position) {
			progressBarControl1.Position = position;
			this.Update();
		}
	}
}
