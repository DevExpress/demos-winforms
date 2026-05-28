using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;

namespace DevExpress.ApplicationUI.Demos {
	/// <summary>
	/// Summary description for PopupControlContainer.
	/// </summary>
	public partial class PopupControlContainer : TutorialControlBase {
		public PopupControlContainer() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			CurrentLabel.Font = new Font(CurrentLabel.Font.Name, 14, FontStyle.Bold); 

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private Label CurrentLabel {
			get { return label1; }
		}

		private void popupControlContainer1_Popup(object sender, System.EventArgs e) {
			alignmentControl1.Alignment = CurrentLabel.TextAlign;
		}

		private void alignmentControl1_AlignmentChanged(object sender, System.EventArgs e) {
			CurrentLabel.TextAlign = alignmentControl1.Alignment;
		}
	}
}
