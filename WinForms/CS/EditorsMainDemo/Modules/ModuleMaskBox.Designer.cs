namespace DevExpress.XtraEditors.Demos {
    partial class ModuleMaskBox {
        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.optionsPanel = new DevExpress.XtraEditors.SidePanel();
            this.optionsPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.optionsPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.settingsPanel = new DevExpress.XtraEditors.Mask.Design.AdvancedSettingsEditor();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane)).BeginInit();
            this.optionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsPane)).BeginInit();
            this.optionsPane.SuspendLayout();
            this.optionsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane
            // 
            this.tabPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane.Location = new System.Drawing.Point(0, 0);
            this.tabPane.Margin = new System.Windows.Forms.Padding(0);
            this.tabPane.Name = "tabPane";
            this.tabPane.RegularSize = new System.Drawing.Size(600, 600);
            this.tabPane.Size = new System.Drawing.Size(600, 600);
            this.tabPane.TabIndex = 0;
            this.tabPane.Text = "tabPane";
            this.tabPane.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.OnSelectedPageChanged);
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.optionsPane);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.optionsPanel.Location = new System.Drawing.Point(600, 0);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.optionsPanel.MinimumSize = new System.Drawing.Size(250, 0);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(250, 600);
            this.optionsPanel.TabIndex = 1;
            // 
            // optionsPane
            // 
            this.optionsPane.Controls.Add(this.optionsPage);
            this.optionsPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsPane.Location = new System.Drawing.Point(1, 0);
            this.optionsPane.Name = "optionsPane";
            this.optionsPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.optionsPage});
            this.optionsPane.RegularSize = new System.Drawing.Size(249, 600);
            this.optionsPane.SelectedPage = this.optionsPage;
            this.optionsPane.Size = new System.Drawing.Size(249, 600);
            this.optionsPane.TabIndex = 1;
            this.optionsPane.Text = "tabPane1";
            // 
            // optionsPage
            // 
            this.optionsPage.Caption = "Options";
            this.optionsPage.Controls.Add(this.settingsPanel);
            this.optionsPage.Name = "optionsPage";
            this.optionsPage.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.optionsPage.Size = new System.Drawing.Size(249, 567);
            // 
            // settingsPanel
            // 
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(10, 20);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Padding = new System.Windows.Forms.Padding(10, 30, 10, 0);
            this.settingsPanel.Size = new System.Drawing.Size(229, 527);
            this.settingsPanel.TabIndex = 0;
            // 
            // ModuleMaskBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane);
            this.Controls.Add(this.optionsPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ModuleMaskBox";
            this.Size = new System.Drawing.Size(850, 600);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane)).EndInit();
            this.optionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optionsPane)).EndInit();
            this.optionsPane.ResumeLayout(false);
            this.optionsPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabPane tabPane;
        private DevExpress.XtraEditors.SidePanel optionsPanel;
        private DevExpress.XtraEditors.Mask.Design.AdvancedSettingsEditor settingsPanel;
        private DevExpress.XtraBars.Navigation.TabPane optionsPane;
        private DevExpress.XtraBars.Navigation.TabNavigationPage optionsPage;
    }
}
