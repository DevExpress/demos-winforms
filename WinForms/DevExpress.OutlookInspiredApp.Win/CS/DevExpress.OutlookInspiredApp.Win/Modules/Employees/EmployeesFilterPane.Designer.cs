namespace DevExpress.DevAV.Modules {
    partial class EmployeesFilterPane {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnNewEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.navigationContainer = new DevExpress.XtraEditors.XtraUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            this.navigationContainer.SuspendLayout();
            this.SuspendLayout();
            
            
            
            this.btnNewEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewEmployee.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnNewEmployee.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewEmploye.svg?Size=16x16";
            this.btnNewEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnNewEmployee.MaximumSize = new System.Drawing.Size(170, 28);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(170, 28);
            this.btnNewEmployee.TabIndex = 0;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.Visible = false;
            
            
            
            this.accordionControl.AllowItemSelection = true;
            this.accordionControl.Appearance.Item.Normal.Options.UseTextOptions = true;
            this.accordionControl.Appearance.Item.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl.ExpandGroupOnHeaderClick = false;
            this.accordionControl.Location = new System.Drawing.Point(0, 28);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.Size = new System.Drawing.Size(178, 575);
            this.accordionControl.TabIndex = 4;
            
            
            
            this.navigationContainer.Controls.Add(this.accordionControl);
            this.navigationContainer.Controls.Add(this.btnNewEmployee);
            this.navigationContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationContainer.Location = new System.Drawing.Point(0, 0);
            this.navigationContainer.Name = "navigationContainer";
            this.navigationContainer.Size = new System.Drawing.Size(178, 603);
            this.navigationContainer.TabIndex = 5;
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationContainer);
            this.Name = "EmployeesFilterPane";
            this.Size = new System.Drawing.Size(178, 603);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            this.navigationContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNewEmployee;
        private XtraBars.Navigation.AccordionControl accordionControl;
        private XtraEditors.XtraUserControl navigationContainer;
    }
}
