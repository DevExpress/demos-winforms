namespace DevExpress.DevAV.Modules {
    partial class CustomersFilterPaneCollapsed {
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
            this.navigationBar = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.navigationContainer = new DevExpress.XtraEditors.XtraUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar)).BeginInit();
            this.navigationContainer.SuspendLayout();
            this.SuspendLayout();
            
            
            
            this.navigationBar.AnimateItemPressing = false;
            this.navigationBar.AutoSize = false;
            this.navigationBar.CustomizationButtonVisibility = DevExpress.XtraBars.Navigation.CustomizationButtonVisibility.Hidden;
            this.navigationBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationBar.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navigationBar.Location = new System.Drawing.Point(0, 28);
            this.navigationBar.MaximumSize = new System.Drawing.Size(50, 0);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.navigationBar.ShowPeekFormOnItemHover = false;
            this.navigationBar.Size = new System.Drawing.Size(50, 572);
            this.navigationBar.TabIndex = 2;
            this.navigationBar.ViewMode = DevExpress.XtraBars.Navigation.OfficeNavigationBarViewMode.Skinned;
            
            
            
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNew.ImageOptions.ImageUri.ResourceType = typeof(DevExpress.DevAV.MainForm);
            this.btnNew.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewCustomer.svg?Size=16x16";
            this.btnNew.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNew.Location = new System.Drawing.Point(0, 0);
            this.btnNew.MaximumSize = new System.Drawing.Size(50, 28);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(50, 28);
            this.btnNew.TabIndex = 0;
            this.btnNew.Visible = false;
            
            
            
            this.navigationContainer.Controls.Add(this.navigationBar);
            this.navigationContainer.Controls.Add(this.btnNew);
            this.navigationContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationContainer.Location = new System.Drawing.Point(0, 0);
            this.navigationContainer.Name = "navigationContainer";
            this.navigationContainer.Size = new System.Drawing.Size(60, 600);
            this.navigationContainer.TabIndex = 2;
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.navigationContainer);
            this.Name = "CustomersFilterPaneCollapsed";
            this.Size = new System.Drawing.Size(60, 600);
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBar)).EndInit();
            this.navigationContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar navigationBar;
        private XtraEditors.XtraUserControl navigationContainer;
    }
}
