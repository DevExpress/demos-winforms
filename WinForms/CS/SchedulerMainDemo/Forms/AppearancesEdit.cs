using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Utils;
using System.Collections.Generic;

namespace DevExpress.XtraScheduler.Demos {
	/// <summary>
	/// Summary description for Appearances.
	/// </summary>
	public partial class AppearancesEditForm : DevExpress.XtraEditors.XtraForm {
		BaseAppearanceCollection appearances;

		public AppearancesEditForm(BaseAppearanceCollection appearances, Form parent) {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			Left = (int)(parent.Left + (parent.Width - Width) / 2);
			Top = (int)(parent.Top + (parent.Height - Height) / 2);

			this.appearances = appearances;
			FillAppearanceList();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		void FillAppearanceList() {
			lbcAppearances.Items.Clear();

            List<string> validNames = CalculateValidAppearanceNames();
			foreach (AppearanceObject app in appearances) {
				if (validNames.Contains(app.Name))
                    lbcAppearances.Items.Add(app.Name);
			}
			lbcAppearances.SelectedIndex = 0;
		}
        private List<string> CalculateValidAppearanceNames() {
            List<string> names = new List<string>();
            PropertyDescriptorCollection descriptors = TypeDescriptor.GetProperties(appearances, new Attribute[] { new BrowsableAttribute(true) });
            for (int i = 0; i < descriptors.Count; i++) {
                names.Add(descriptors[i].Name);
            }
            return names;
        }

        private void lbcAppearances_SelectedIndexChanged(object sender, System.EventArgs e) {
            propertyGrid1.SelectedObjects = GetSelectedObjects();
		}
		object[] GetSelectedObjects() {
			if (lbcAppearances.SelectedItem == null) return null;
			ArrayList result = new ArrayList();
			for (int i = 0; i < lbcAppearances.SelectedIndices.Count; i++) {
				object obj = appearances.GetAppearance(lbcAppearances.Text);
				result.Add(obj);
			}
			return result.ToArray();
		}
	}
}
