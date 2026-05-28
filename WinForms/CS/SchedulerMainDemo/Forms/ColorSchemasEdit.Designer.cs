using System;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;

namespace DevExpress.XtraScheduler.Demos {
	partial class ColorSchemasEditForm {
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
			this.btnDefaults = new DevExpress.XtraEditors.SimpleButton();
			this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
			this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.lbTimeScales = new DevExpress.XtraEditors.ListBoxControl();
			this.propertyGrid1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lbTimeScales)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.propertyGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDefaults
			// 
			this.btnDefaults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDefaults.ImageIndex = 2;
			this.btnDefaults.Location = new System.Drawing.Point(370, 288);
			this.btnDefaults.Name = "btnDefaults";
			this.btnDefaults.Size = new System.Drawing.Size(125, 24);
			this.btnDefaults.TabIndex = 30;
			this.btnDefaults.Text = "Restore &Defaults";
			this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.ImageIndex = 2;
			this.btnAdd.Location = new System.Drawing.Point(12, 288);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(80, 24);
			this.btnAdd.TabIndex = 29;
			this.btnAdd.Text = "&Add";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.ImageIndex = 2;
			this.btnRemove.Location = new System.Drawing.Point(98, 288);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(80, 24);
			this.btnRemove.TabIndex = 28;
			this.btnRemove.Text = "&Remove";
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Controls.Add(this.lbTimeScales);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.Controls.Add(this.propertyGrid1);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(507, 282);
			this.splitContainerControl1.SplitterPosition = 179;
			this.splitContainerControl1.TabIndex = 29;
			this.splitContainerControl1.Text = "splitContainerControl1";
			// 
			// lbTimeScales
			// 
			this.lbTimeScales.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbTimeScales.ItemHeight = 16;
			this.lbTimeScales.Location = new System.Drawing.Point(0, 0);
			this.lbTimeScales.Name = "lbTimeScales";
			this.lbTimeScales.Size = new System.Drawing.Size(175, 278);
			this.lbTimeScales.TabIndex = 26;
			this.lbTimeScales.SelectedIndexChanged += new System.EventHandler(this.lbcAppearances_SelectedIndexChanged);
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.OptionsView.ShowRootCategories = false;
			this.propertyGrid1.ServiceProvider = null;
			this.propertyGrid1.Size = new System.Drawing.Size(318, 278);
			this.propertyGrid1.TabIndex = 25;
			// 
			// ColorSchemasEditForm
			// 
			this.ClientSize = new System.Drawing.Size(507, 322);
			this.Controls.Add(this.btnDefaults);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.splitContainerControl1);
			this.Controls.Add(this.btnRemove);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "ColorSchemasEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Color Schemas";
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lbTimeScales)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.propertyGrid1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private SimpleButton btnDefaults;
		private SimpleButton btnAdd;
		private SimpleButton btnRemove;
		private SplitContainerControl splitContainerControl1;
		private ListBoxControl lbTimeScales;
		private PropertyGridControl propertyGrid1;
	}
}
