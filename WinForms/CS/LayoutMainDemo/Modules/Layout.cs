using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraLayout.Demos {
	public partial class Layout : TutorialControl {
		public Layout() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		private void Layout_Load(object sender, System.EventArgs e) {
			DisableDeleteButton();
			timer1.Start();
		}

		void DisableButtons(bool disable) {
			sbOpen.Enabled = disable;
		}

		void DisableDeleteButton() {
			sbDelete.Enabled = System.IO.File.Exists(frmPassword.LayoutFileName);
		}

		void OpenForm(bool restoreLayout) {
			frmPassword dlg = new frmPassword(sbOpen.Parent.RectangleToScreen(sbOpen.Parent.Bounds), restoreLayout);
            if(checkBox1.Checked) {
                dlg.SetCustomizationMode(CustomizationModes.Quick);
            } else dlg.SetCustomizationMode(CustomizationModes.Default);
			DisableButtons(false);
			if(dlg.ShowDialog() == DialogResult.OK) {
				dlg.SaveLayout();
			}
			dlg.Dispose();
			DisableButtons(true);
			DisableDeleteButton();
		}

		private void sbOpen_Click(object sender, System.EventArgs e) {
			OpenForm(true);
		}

		private void sbDelete_Click(object sender, System.EventArgs e) {
			if(System.IO.File.Exists(frmPassword.LayoutFileName))
				System.IO.File.Delete(frmPassword.LayoutFileName);
			DisableDeleteButton();
		}

		private void timer1_Tick(object sender, System.EventArgs e) {
			timer1.Stop();
			OpenForm(true);
		}
	}
}

