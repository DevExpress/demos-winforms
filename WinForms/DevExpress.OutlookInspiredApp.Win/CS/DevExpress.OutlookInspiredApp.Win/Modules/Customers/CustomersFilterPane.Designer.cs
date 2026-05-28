namespace DevExpress.DevAV.Modules {
    partial class CustomersFilterPane {
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
            this.btnNewCustomer = new DevExpress.XtraEditors.SimpleButton();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.navigationContainer = new DevExpress.XtraEditors.XtraUserControl();
            this.btnNavigationContainer = new DevExpress.XtraEditors.XtraUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            this.navigationContainer.SuspendLayout();
            this.btnNavigationContainer.SuspendLayout();
            this.SuspendLayout();
            
            
            
            this.btnNewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewCustomer.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnNewCustomer.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewCustomer.svg?Size=16x16";
            this.btnNewCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(315, 28);
            this.btnNewCustomer.TabIndex = 0;
            this.btnNewCustomer.Text = "New Customer";
            
            
            
            this.accordionControl.AllowItemSelection = true;
            this.accordionControl.Appearance.Item.Normal.Options.UseTextOptions = true;
            this.accordionControl.Appearance.Item.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl.ExpandGroupOnHeaderClick = false;
            this.accordionControl.Location = new System.Drawing.Point(0, 28);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.Size = new System.Drawing.Size(315, 992);
            this.accordionControl.TabIndex = 4;
            
            
            
            this.navigationContainer.Controls.Add(this.accordionControl);
            this.navigationContainer.Controls.Add(this.btnNavigationContainer);
            this.navigationContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationContainer.Location = new System.Drawing.Point(0, 0);
            this.navigationContainer.Name = "navigationContainer";
            this.navigationContainer.Size = new System.Drawing.Size(315, 1020);
            this.navigationContainer.TabIndex = 5;
            
            
            
            this.btnNavigationContainer.Controls.Add(this.btnNewCustomer);
            this.btnNavigationContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavigationContainer.Location = new System.Drawing.Point(0, 0);
            this.btnNavigationContainer.Name = "btnNavigationContainer";
            this.btnNavigationContainer.Size = new System.Drawing.Size(315, 28);
            this.btnNavigationContainer.TabIndex = 6;
            this.btnNavigationContainer.Visible = false;
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationContainer);
            this.Name = "CustomersFilterPane";
            this.Size = new System.Drawing.Size(315, 1020);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            this.navigationContainer.ResumeLayout(false);
            this.btnNavigationContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNewCustomer;
        private XtraBars.Navigation.AccordionControl accordionControl;
        private XtraEditors.XtraUserControl navigationContainer;
        private XtraEditors.XtraUserControl btnNavigationContainer;
    }
}
