namespace DevExpress.XtraNavBar.Demos {
    partial class AddGroups {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
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
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.button2 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel1)).BeginInit();
            this.contentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel1
            // 
            this.contentPanel1.Controls.Add(this.panelControl1);
            this.contentPanel1.Controls.Add(this.navBarControl1);
            this.contentPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.contentPanel1.Size = new System.Drawing.Size(346, 273);
            // 
            // navBarControl1
            // 
            this.navBarControl1.Appearance.ItemDisabled.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Appearance.ItemHotTracked.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Appearance.ItemPressed.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Location = new System.Drawing.Point(4, 5);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 172;
            this.navBarControl1.Size = new System.Drawing.Size(172, 264);
            this.navBarControl1.StoreDefaultPaintStyleName = true;
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 24);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add New Group";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 24);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete Last Group";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Location = new System.Drawing.Point(176, 5);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(166, 264);
            this.panelControl1.TabIndex = 8;
            // 
            // AddGroups
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AddGroups";
            this.Size = new System.Drawing.Size(346, 273);
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel1)).EndInit();
            this.contentPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraEditors.SimpleButton button2;
        private System.ComponentModel.Container components = null;
        private XtraEditors.PanelControl panelControl1;

    }
}
