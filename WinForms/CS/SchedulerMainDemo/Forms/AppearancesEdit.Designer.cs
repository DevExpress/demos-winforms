using System;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid;

namespace DevExpress.XtraScheduler.Demos {
	partial class AppearancesEditForm {
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.lbcAppearances = new DevExpress.XtraEditors.ListBoxControl();
			this.propertyGrid1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lbcAppearances)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.propertyGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl1.Location = new System.Drawing.Point(5, 5);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Controls.Add(this.lbcAppearances);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.Controls.Add(this.propertyGrid1);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(382, 314);
			this.splitContainerControl1.SplitterPosition = 156;
			this.splitContainerControl1.TabIndex = 7;
			this.splitContainerControl1.Text = "splitContainerControl1";
			// 
			// lbcAppearances
			// 
			this.lbcAppearances.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbcAppearances.ItemHeight = 16;
			this.lbcAppearances.Location = new System.Drawing.Point(0, 0);
			this.lbcAppearances.Name = "lbcAppearances";
			this.lbcAppearances.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbcAppearances.Size = new System.Drawing.Size(152, 310);
			this.lbcAppearances.SortOrder = System.Windows.Forms.SortOrder.Ascending;
			this.lbcAppearances.TabIndex = 24;
			this.lbcAppearances.SelectedIndexChanged += new System.EventHandler(this.lbcAppearances_SelectedIndexChanged);
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.ServiceProvider = null;
			this.propertyGrid1.Size = new System.Drawing.Size(216, 310);
			this.propertyGrid1.TabIndex = 1;
			// 
			// Appearances
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(392, 324);
			this.Controls.Add(this.splitContainerControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Appearances";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Appearances";
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lbcAppearances)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.propertyGrid1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.ComponentModel.Container components = null;
		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
		private DevExpress.XtraEditors.ListBoxControl lbcAppearances;
		private PropertyGridControl propertyGrid1;
	}
}
