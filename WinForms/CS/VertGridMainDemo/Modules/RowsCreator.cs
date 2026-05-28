using System;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Persistent;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;

namespace DevExpress.XtraVerticalGrid.Demos {
	public class RowsCreator {
		private static void AddComboBoxItems(RepositoryItemComboBox cb, string[] s) {
			for(int i = 0; i < s.Length; i++) 
				cb.Items.Add(s[i]);
			cb.TextEditStyle = TextEditStyles.DisableTextEditor;
		}
		private static void CreateOpenFileButtonDialog(RepositoryItemButtonEdit be) {
			be.ButtonClick += new ButtonPressedEventHandler(button_click);
		}
		private static void button_click(object sender, ButtonPressedEventArgs e) {
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Executable Files|*.exe;*.com|All Files|*.*";
			if(dlg.ShowDialog() == DialogResult.OK) {
				ButtonEdit be = sender as ButtonEdit;
				be.Text = dlg.FileName;
			}
		}
		public static void CreateRows(VGridControl vg, object[] rows) {
			vg.CloseEditor();
			vg.Rows.Clear();
			vg.RepositoryItems.Clear();
			vg.RepositoryItems.Add(new RepositoryItemCheckEdit()); 
			vg.RepositoryItems.Add(new RepositoryItemSpinEdit());
			vg.RepositoryItems.Add(new RepositoryItemComboBox()); 
			vg.RepositoryItems.Add(new RepositoryItemComboBox()); 
			vg.RepositoryItems.Add(new RepositoryItemButtonEdit());
			((RepositoryItemSpinEdit)vg.RepositoryItems[1]).IsFloatValue = false;
			AddComboBoxItems(vg.RepositoryItems[2] as RepositoryItemComboBox, new string[] {"Warning level 0", "Warning level 1", "Warning level 2", "Warning level 3", "Warning level 4"});
			AddComboBoxItems(vg.RepositoryItems[3] as RepositoryItemComboBox, new string[] {"Project", "Program", "URL", "Wait to Attach to an External Process"});
			CreateOpenFileButtonDialog(vg.RepositoryItems[4] as RepositoryItemButtonEdit);
			for(int i = 0; i < rows.Length; i++) {
				string name = ((object[])rows[i])[0].ToString();
				CategoryRow cRow = new CategoryRow(name);
				string[] names = ((object[])rows[i])[1] as string[];
					int[] editorInd = ((object[])rows[i])[2] as int[];
						object[] values = ((object[])rows[i])[3] as object[];
							bool[] enabled = null;
				try {
					enabled = ((object[])rows[i])[4] as bool[];
				} catch {}
				for(int j = 0; j < names.Length; j++) {
					EditorRow eRow = new EditorRow();
					eRow.Properties.Caption = names[j];
					if(editorInd[j] != -1) {
						eRow.Properties.RowEdit = vg.RepositoryItems[editorInd[j]];
					}
					eRow.Properties.Value = values[j];
					eRow.Tag = values[j];
					if(enabled != null) {
						eRow.Enabled = (bool)enabled[j];
					}
					cRow.ChildRows.Add(eRow);
				}
				vg.Rows.Add(cRow);
			}
		}
		public static void CreateRows(int i, VGridControl vg) {
			if(i == 0)
				RowsCreator.CreateRows(vg, new object[] {new object[] {"Code Generation", new string[] {"Conditional Compilation Constants", "Optimize code", "Check for Arithmetic Overflow/Underflow", "Allow unsafe code blocks"}, new int[] {-1, 0, 0, 0}, new object[] {"DEBUG;TRACE", false, false, false}},
																	   new object[] {"Errors and Warnings", new string[] {"Warning Level", "Treat Warnings As Errors"}, new int[] {2, 0}, new object[] {"Warning level 4", false}}, 
																	   new object[] {"Outputs", new string[] {"Output Path", "XML Documentation File", "Generate Debugging Information", "Register for COM interop"}, new int[] {-1, -1, 0, 0}, new object[] {"bin\\Debug\\", "", true, false}, new bool[] {true, true, true, false}}}); 
			if(i == 1)
				RowsCreator.CreateRows(vg, new object[] {new object[] {"Debuggers", new string[] {"Enable ASP Debugging", "Enable ASP.Net Debugging", "Enable Unmanaged Debugging", "Enable SQL Debugging"}, new int[] {0, 0, 0, 0}, new object[] {false, false, false, false}},
																	   new object[] {"Start Action", new string[] {"Debug Mode", "Start Application", "Start URL", "Start Page"}, new int[] {3, 4, -1, -1}, new object[] {"Project", "", "", ""}}, 
																	   new object[] {"Start Options", new string[] {"Command Line Arguments", "Working Directory", "Always use Internet Explorer", "Enable remote debugging", "Remote debug machine"}, new int[] {-1, -1, 0, 0, -1}, new object[] {"", "", false, true, ""}}}); 
			if(i == 2)
				RowsCreator.CreateRows(vg, new object[] {new object[] {"General", new string[] {"Incremental build", "Base Address", "File Alignment"}, new int[] {0, 1, 1}, new object[] {true, (decimal)285212672, (decimal)4096}}}); 
		}
	}
}
