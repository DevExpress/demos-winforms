using System.Drawing;
using DevExpress.XtraEditors;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraNavBar.Demos {
	/// <summary>
	/// Summary description for GroupContainer.
	/// </summary>
	public partial class GroupContainer : TutorialControl {
		public GroupContainer() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void GroupContainer_Load(object sender, System.EventArgs e) {
			radioButton1.Checked = true;
			checkBox1.Checked = checkBox3.Checked = true;
			comboBox1.Properties.Items.AddRange(System.IO.Directory.GetLogicalDrives());
			if(comboBox1.Properties.Items.Count > 1) comboBox1.SelectedIndex = 1;
			comboBox2.SelectedIndex = 0;
			dateTimePicker1.EditValue = dateTimePicker2.EditValue = TutorialConstants.Now;
		}

		private void radioButton_CheckedChanged(object sender, System.EventArgs e) {
			CheckEdit rb = sender as CheckEdit;
			rb.Font = new Font(rb.Font, rb.Checked ? FontStyle.Bold : FontStyle.Regular);
			bool isSpecifyDates = rb == radioButton5 && rb.Checked;
			comboBox2.Enabled = dateTimePicker1.Enabled = dateTimePicker2.Enabled = isSpecifyDates;
		}

		private void checkBox_CheckedChanged(object sender, System.EventArgs e) {
			CheckEdit cb = sender as CheckEdit;
			cb.Font = new Font(cb.Font, cb.Checked ? FontStyle.Bold : FontStyle.Regular);
		}
	}
}
