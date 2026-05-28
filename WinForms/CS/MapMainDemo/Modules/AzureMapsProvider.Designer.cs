namespace DevExpress.XtraMap.Demos {
    partial class AzureMapsProvider {
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
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.sidePanelOptions = new DevExpress.XtraEditors.SidePanel();
            this.tabPaneOptions = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPageOptions = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.chkShowTerrain = new DevExpress.XtraEditors.CheckEdit();
            this.additionalLayersRadio = new DevExpress.XtraEditors.RadioGroup();
            this.appearanceRadio = new DevExpress.XtraEditors.RadioGroup();
            this.mapStyleRadio = new DevExpress.XtraEditors.RadioGroup();
            this.weatherLayersRadio = new DevExpress.XtraEditors.RadioGroup();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.additionalLayersGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.additionalLayersItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.mapStyleGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.showTerrainItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.mapStyleItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.weatherLayersGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.weatherLayersItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.appearanceGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.appearanceItem = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowTerrain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalLayersRadio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appearanceRadio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapStyleRadio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherLayersRadio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalLayersGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalLayersItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapStyleGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTerrainItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapStyleItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherLayersGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherLayersItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appearanceGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appearanceItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.mapControl);
            this.panelControl1.Controls.Add(this.sidePanelOptions);
            this.panelControl1.Size = new System.Drawing.Size(686, 602);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Size = new System.Drawing.Size(686, 150);
            // 
            // mapControl
            // 
            this.mapControl.CenterPoint = new DevExpress.XtraMap.GeoPoint(47.1D, 11.1D);
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Layers.Add(this.imageLayer1);
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(488, 602);
            this.mapControl.TabIndex = 0;
            this.mapControl.ZoomLevel = 5D;
            // 
            // sidePanelOptions
            // 
            this.sidePanelOptions.AllowResize = false;
            this.sidePanelOptions.Controls.Add(this.tabPaneOptions);
            this.sidePanelOptions.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanelOptions.Location = new System.Drawing.Point(488, 0);
            this.sidePanelOptions.Name = "sidePanelOptions";
            this.sidePanelOptions.Size = new System.Drawing.Size(198, 602);
            this.sidePanelOptions.TabIndex = 7;
            // 
            // tabPaneOptions
            // 
            this.tabPaneOptions.Controls.Add(this.tabNavigationPageOptions);
            this.tabPaneOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPaneOptions.Location = new System.Drawing.Point(1, 0);
            this.tabPaneOptions.Name = "tabPaneOptions";
            this.tabPaneOptions.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPageOptions});
            this.tabPaneOptions.RegularSize = new System.Drawing.Size(197, 602);
            this.tabPaneOptions.SelectedPage = this.tabNavigationPageOptions;
            this.tabPaneOptions.Size = new System.Drawing.Size(197, 602);
            this.tabPaneOptions.TabIndex = 8;
            this.tabPaneOptions.Text = "tabPane1";
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Caption = "Options";
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl1);
            this.tabNavigationPageOptions.Name = "tabNavigationPageOptions";
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(197, 569);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AutoSize = true;
            this.layoutControl1.Controls.Add(this.chkShowTerrain);
            this.layoutControl1.Controls.Add(this.additionalLayersRadio);
            this.layoutControl1.Controls.Add(this.appearanceRadio);
            this.layoutControl1.Controls.Add(this.mapStyleRadio);
            this.layoutControl1.Controls.Add(this.weatherLayersRadio);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(827, 319, 806, 536);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(197, 392);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // chkShowTerrain
            // 
            this.chkShowTerrain.Location = new System.Drawing.Point(11, 80);
            this.chkShowTerrain.MenuManager = this;
            this.chkShowTerrain.Name = "chkShowTerrain";
            this.chkShowTerrain.Properties.Caption = "Show Terrain";
            this.chkShowTerrain.Size = new System.Drawing.Size(175, 20);
            this.chkShowTerrain.StyleController = this.layoutControl1;
            this.chkShowTerrain.TabIndex = 4;
            this.chkShowTerrain.CheckedChanged += new System.EventHandler(this.chkShowTerrain_CheckedChanged);
            // 
            // additionalLayersRadio
            // 
            this.additionalLayersRadio.EditValue = "Labels";
            this.additionalLayersRadio.Location = new System.Drawing.Point(11, 212);
            this.additionalLayersRadio.Margin = new System.Windows.Forms.Padding(0);
            this.additionalLayersRadio.Name = "additionalLayersRadio";
            this.additionalLayersRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.additionalLayersRadio.Properties.Appearance.Options.UseBackColor = true;
            this.additionalLayersRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.additionalLayersRadio.Properties.Columns = 1;
            this.additionalLayersRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("None", "None"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Hybrid Road", "Hybrid Road"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Labels", "Labels")});
            this.additionalLayersRadio.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.additionalLayersRadio.Size = new System.Drawing.Size(175, 72);
            this.additionalLayersRadio.StyleController = this.layoutControl1;
            this.additionalLayersRadio.TabIndex = 5;
            this.additionalLayersRadio.SelectedIndexChanged += new System.EventHandler(this.additionalLayersRadio_SelectedIndexChanged);
            // 
            // appearanceRadio
            // 
            this.appearanceRadio.EditValue = "Light";
            this.appearanceRadio.Location = new System.Drawing.Point(11, 132);
            this.appearanceRadio.Margin = new System.Windows.Forms.Padding(0);
            this.appearanceRadio.Name = "appearanceRadio";
            this.appearanceRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.appearanceRadio.Properties.Appearance.Options.UseBackColor = true;
            this.appearanceRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.appearanceRadio.Properties.Columns = 1;
            this.appearanceRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Light", "Light"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Dark", "Dark")});
            this.appearanceRadio.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.appearanceRadio.Size = new System.Drawing.Size(175, 48);
            this.appearanceRadio.StyleController = this.layoutControl1;
            this.appearanceRadio.TabIndex = 7;
            this.appearanceRadio.SelectedIndexChanged += new System.EventHandler(this.appearanceRadio_SelectedIndexChanged);
            // 
            // mapStyleRadio
            // 
            this.mapStyleRadio.EditValue = "Satellite";
            this.mapStyleRadio.Location = new System.Drawing.Point(11, 28);
            this.mapStyleRadio.Margin = new System.Windows.Forms.Padding(0);
            this.mapStyleRadio.Name = "mapStyleRadio";
            this.mapStyleRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.mapStyleRadio.Properties.Appearance.Options.UseBackColor = true;
            this.mapStyleRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mapStyleRadio.Properties.Columns = 1;
            this.mapStyleRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Satellite", "Satellite"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Road", "Road")});
            this.mapStyleRadio.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.mapStyleRadio.Size = new System.Drawing.Size(175, 48);
            this.mapStyleRadio.StyleController = this.layoutControl1;
            this.mapStyleRadio.TabIndex = 7;
            this.mapStyleRadio.SelectedIndexChanged += new System.EventHandler(this.mapStyleRadio_SelectedIndexChanged);
            // 
            // weatherLayersRadio
            // 
            this.weatherLayersRadio.EditValue = "None";
            this.weatherLayersRadio.Location = new System.Drawing.Point(11, 316);
            this.weatherLayersRadio.Margin = new System.Windows.Forms.Padding(0);
            this.weatherLayersRadio.Name = "weatherLayersRadio";
            this.weatherLayersRadio.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.weatherLayersRadio.Properties.Appearance.Options.UseBackColor = true;
            this.weatherLayersRadio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.weatherLayersRadio.Properties.Columns = 1;
            this.weatherLayersRadio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("None", "None"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Radar", "Radar"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Infrared", "Infrared")});
            this.weatherLayersRadio.Properties.Padding = new System.Windows.Forms.Padding(0);
            this.weatherLayersRadio.Size = new System.Drawing.Size(175, 72);
            this.weatherLayersRadio.StyleController = this.layoutControl1;
            this.weatherLayersRadio.TabIndex = 7;
            this.weatherLayersRadio.SelectedIndexChanged += new System.EventHandler(this.weatherLayersRadio_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.additionalLayersGroup,
            this.mapStyleGroup,
            this.weatherLayersGroup,
            this.appearanceGroup});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(197, 392);
            this.Root.TextVisible = false;
            // 
            // additionalLayersGroup
            // 
            this.additionalLayersGroup.CustomizationFormText = "additionalLayersGroup";
            this.additionalLayersGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.additionalLayersGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.additionalLayersItem});
            this.additionalLayersGroup.Location = new System.Drawing.Point(0, 184);
            this.additionalLayersGroup.Name = "additionalLayersGroup";
            this.additionalLayersGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 2);
            this.additionalLayersGroup.Size = new System.Drawing.Size(197, 104);
            this.additionalLayersGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.additionalLayersGroup.Text = "Additional Layers";
            // 
            // additionalLayersItem
            // 
            this.additionalLayersItem.Control = this.additionalLayersRadio;
            this.additionalLayersItem.Location = new System.Drawing.Point(0, 0);
            this.additionalLayersItem.Name = "additionalLayersItem";
            this.additionalLayersItem.Size = new System.Drawing.Size(179, 76);
            this.additionalLayersItem.TextSize = new System.Drawing.Size(0, 0);
            this.additionalLayersItem.TextVisible = false;
            // 
            // mapStyleGroup
            // 
            this.mapStyleGroup.CustomizationFormText = "mapStyleGroup";
            this.mapStyleGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.mapStyleGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.showTerrainItem,
            this.mapStyleItem});
            this.mapStyleGroup.Location = new System.Drawing.Point(0, 0);
            this.mapStyleGroup.Name = "mapStyleGroup";
            this.mapStyleGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 2);
            this.mapStyleGroup.Size = new System.Drawing.Size(197, 104);
            this.mapStyleGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.mapStyleGroup.Text = "Map Style";
            // 
            // showTerrainItem
            // 
            this.showTerrainItem.Control = this.chkShowTerrain;
            this.showTerrainItem.Location = new System.Drawing.Point(0, 52);
            this.showTerrainItem.Name = "showTerrainItem";
            this.showTerrainItem.Size = new System.Drawing.Size(179, 24);
            this.showTerrainItem.TextSize = new System.Drawing.Size(0, 0);
            this.showTerrainItem.TextVisible = false;
            // 
            // mapStyleItem
            // 
            this.mapStyleItem.Control = this.mapStyleRadio;
            this.mapStyleItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.mapStyleItem.CustomizationFormText = "weatherLayersItem";
            this.mapStyleItem.Location = new System.Drawing.Point(0, 0);
            this.mapStyleItem.Name = "mapStyleItem";
            this.mapStyleItem.Size = new System.Drawing.Size(179, 52);
            this.mapStyleItem.Text = "weatherLayersItem";
            this.mapStyleItem.TextVisible = false;
            // 
            // weatherLayersGroup
            // 
            this.weatherLayersGroup.CustomizationFormText = "weatherLayersGroup";
            this.weatherLayersGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.weatherLayersGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.weatherLayersItem});
            this.weatherLayersGroup.Location = new System.Drawing.Point(0, 288);
            this.weatherLayersGroup.Name = "weatherLayersGroup";
            this.weatherLayersGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 2);
            this.weatherLayersGroup.Size = new System.Drawing.Size(197, 104);
            this.weatherLayersGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.weatherLayersGroup.Text = "Weather";
            // 
            // weatherLayersItem
            // 
            this.weatherLayersItem.Control = this.weatherLayersRadio;
            this.weatherLayersItem.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.weatherLayersItem.Location = new System.Drawing.Point(0, 0);
            this.weatherLayersItem.Name = "weatherLayersItem";
            this.weatherLayersItem.Size = new System.Drawing.Size(179, 76);
            this.weatherLayersItem.TextVisible = false;
            // 
            // appearanceGroup
            // 
            this.appearanceGroup.BestFitWeight = 0;
            this.appearanceGroup.CustomizationFormText = "appearanceGroup";
            this.appearanceGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.appearanceGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.appearanceItem});
            this.appearanceGroup.Location = new System.Drawing.Point(0, 104);
            this.appearanceGroup.Name = "appearanceGroup";
            this.appearanceGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 4, 2);
            this.appearanceGroup.Size = new System.Drawing.Size(197, 80);
            this.appearanceGroup.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.appearanceGroup.Text = "Appearance";
            // 
            // appearanceItem
            // 
            this.appearanceItem.Control = this.appearanceRadio;
            this.appearanceItem.Location = new System.Drawing.Point(0, 0);
            this.appearanceItem.Name = "appearanceItem";
            this.appearanceItem.Size = new System.Drawing.Size(179, 52);
            this.appearanceItem.TextSize = new System.Drawing.Size(0, 0);
            this.appearanceItem.TextVisible = false;
            // 
            // AzureMapsProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AzureMapsProvider";
            this.Size = new System.Drawing.Size(686, 770);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkShowTerrain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalLayersRadio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appearanceRadio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapStyleRadio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherLayersRadio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalLayersGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additionalLayersItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapStyleGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTerrainItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapStyleItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherLayersGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherLayersItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appearanceGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appearanceItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MapControl mapControl;
        private ImageLayer imageLayer1;
        protected XtraEditors.SidePanel sidePanelOptions;
        protected XtraBars.Navigation.TabPane tabPaneOptions;
        protected XtraBars.Navigation.TabNavigationPage tabNavigationPageOptions;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlGroup mapStyleGroup;
        private XtraLayout.LayoutControlItem mapStyleItem;
        private XtraEditors.RadioGroup mapStyleRadio;
        private XtraLayout.LayoutControlItem showTerrainItem;
        private XtraEditors.CheckEdit chkShowTerrain;
        private XtraLayout.LayoutControlGroup appearanceGroup;
        private XtraLayout.LayoutControlItem appearanceItem;
        private XtraEditors.RadioGroup appearanceRadio;
        private XtraLayout.LayoutControlGroup additionalLayersGroup;
        private XtraLayout.LayoutControlItem additionalLayersItem;
        private XtraEditors.RadioGroup additionalLayersRadio;
        private XtraLayout.LayoutControlGroup weatherLayersGroup;
        private XtraLayout.LayoutControlItem weatherLayersItem;
        private XtraEditors.RadioGroup weatherLayersRadio;
    }
}
