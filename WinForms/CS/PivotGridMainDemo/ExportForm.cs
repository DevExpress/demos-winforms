using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos {
	public partial class ExportForm : DevExpress.XtraEditors.XtraForm {
		public ExportForm(Form parent) {
			InitializeComponent();
			this.ClientSize = new Size( 
				pictureBox1.Image.Width + this.DockPadding.All * 2, 
				pictureBox1.Image.Height + this.DockPadding.All * 2);
			if(parent != null) {
                Left = parent.Left + (int)((parent.Width - Width) / 2);
                Top = parent.Top + (int)((parent.Height - Height) / 2);
			}
		}
	}
}
