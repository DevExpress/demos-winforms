using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
// <mruEditSample>
using DevExpress.XtraEditors;
// </mruEditSample>
// <ceShowCustomButtons>
using DevExpress.XtraEditors.Controls;
// </ceShowCustomButtons>
using System.Windows.Forms;
using DevExpress.Tutorials;

namespace DevExpress.XtraEditors.Demos {
	public partial class ModuleMRUEdit : TutorialControl {
		public ModuleMRUEdit() {
			InitializeComponent();
		}
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "ModuleMRUEdit" }; } }
        protected override string WhatsThisXMLFileName { get { return "mruedit"; } }
        protected override void UpdateTabControlPosition(XtraTab.XtraTabControl tabControl) { }
        protected override void CalcContentCore() {
            CalcLayoutControlBounds(layoutControl1);
        }

        bool updateValues = false;

		private void ModuleMRUEdit_Load(object sender, System.EventArgs e) {
			ControlUtils.CenterControlInParent(mruEditSample);
			InitValues();
		}

		
		void InitValues() {
			updateValues = true;
			seMaxItemCount.Value = mruEditSample.Properties.MaxItemCount;
            ceAllowRemoveItems.Checked = mruEditSample.Properties.AllowRemoveMRUItems;
			ShowCustomButtons(ceShowCustomButtons.Checked);
			updateValues = false;
		}

		// <seMaxItemCount>
		private void seMaxItemCount_EditValueChanged(object sender, System.EventArgs e) {
			// <skip>
			if(updateValues) return;
			// </skip>
			mruEditSample.Properties.MaxItemCount = Convert.ToInt32(seMaxItemCount.Value);
		}
		// </seMaxItemCount>

		// <mruEditSample>
		private void mruEditSample_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
			MRUEdit edit = sender as MRUEdit;
			if(edit.Properties.Buttons.IndexOf(e.Button) != edit.Properties.ActionButtonIndex) {
				OpenFileDialog dlg = new OpenFileDialog();
				dlg.Filter = "All Files(*.*)|*.*";
				if(dlg.ShowDialog() == DialogResult.OK) {
					edit.EditValue = new System.IO.FileInfo(dlg.FileName).Name;
					edit.Properties.Items.Add(edit.Text);
				}
			}
		}
		// </mruEditSample>

		// <ceAllowAdding>
		private void mruEditSample_AddingMRUItem(object sender, DevExpress.XtraEditors.Controls.AddingMRUItemEventArgs e) {
			e.Cancel = !ceAllowAdding.Checked;
		}
		// </ceAllowAdding>

		// <ceShowCustomButtons>
		void ShowCustomButtons(bool show) {
			foreach(EditorButton button in mruEditSample.Properties.Buttons)
				if(button.Tag != null) button.Visible = show;
		}

		private void ceShowCustomButtons_CheckedChanged(object sender, System.EventArgs e) {
			ShowCustomButtons(ceShowCustomButtons.Checked);
		}
		// </ceShowCustomButtons>

        private void ceAllowRemoveItems_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            mruEditSample.Properties.AllowRemoveMRUItems = ceAllowRemoveItems.Checked;
        }
	}
}

