namespace DevExpress.XtraTreeMap.Demos {
    partial class SunburstHierarchicalData {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region InitializeComponent
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraTreeMap.SunburstHierarchicalDataAdapter sunburstHierarchicalDataAdapter1 = new DevExpress.XtraTreeMap.SunburstHierarchicalDataAdapter();
            DevExpress.XtraTreeMap.SunburstHierarchicalDataMapping sunburstHierarchicalDataMapping1 = new DevExpress.XtraTreeMap.SunburstHierarchicalDataMapping();
            this.sunburstControl1 = new DevExpress.XtraTreeMap.SunburstControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.colorizerCBE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.varyColorInGroupCE = new DevExpress.XtraEditors.CheckEdit();
            this.modeCBE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroupInteraction1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.colorizerLCI1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.varyColorInGroupLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.modeLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sunburstControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorizerCBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varyColorInGroupCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeCBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInteraction1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorizerLCI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varyColorInGroupLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(241, 538);
            // 
            // sunburstControl1
            // 
            this.sunburstControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.sunburstControl1.CenterLabel.TextPattern = "Type Count in XtraBars : {TV}";
            sunburstHierarchicalDataMapping1.ChildrenDataMember = "NestedNamespaces";
            sunburstHierarchicalDataMapping1.LabelDataMember = "NamespaceString";
            sunburstHierarchicalDataMapping1.ValueDataMember = "TypesCount";
            sunburstHierarchicalDataAdapter1.Mappings.Add(sunburstHierarchicalDataMapping1);
            this.sunburstControl1.DataAdapter = sunburstHierarchicalDataAdapter1;
            this.sunburstControl1.HoleRadiusPercent = 25;
            this.sunburstControl1.Location = new System.Drawing.Point(0, 0);
            this.sunburstControl1.Name = "sunburstControl1";
            this.sunburstControl1.Padding = new System.Windows.Forms.Padding(2);
            this.sunburstControl1.Size = new System.Drawing.Size(546, 571);
            this.sunburstControl1.TabIndex = 0;
            this.sunburstControl1.ToolTipController = this.toolTipController1;
            // 
            // toolTipController1
            // 
            this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.ToolTipController_BeforeShow);
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.colorizerCBE);
            this.layoutControl.Controls.Add(this.varyColorInGroupCE);
            this.layoutControl.Controls.Add(this.modeCBE);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(241, 538);
            this.layoutControl.TabIndex = 4;
            this.layoutControl.Text = "layoutControl1";
            // 
            // colorizerCBE
            // 
            this.colorizerCBE.Location = new System.Drawing.Point(66, 12);
            this.colorizerCBE.Name = "colorizerCBE";
            this.colorizerCBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorizerCBE.Properties.Items.AddRange(new object[] {
            "Palette Colorizer",
            "Gradient Colorizer"});
            this.colorizerCBE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.colorizerCBE.Size = new System.Drawing.Size(163, 20);
            this.colorizerCBE.StyleController = this.layoutControl;
            this.colorizerCBE.TabIndex = 8;
            // 
            // varyColorInGroupCE
            // 
            this.varyColorInGroupCE.Location = new System.Drawing.Point(12, 36);
            this.varyColorInGroupCE.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.varyColorInGroupCE.Name = "varyColorInGroupCE";
            this.varyColorInGroupCE.Properties.AutoWidth = true;
            this.varyColorInGroupCE.Properties.Caption = "Vary Color In Group";
            this.varyColorInGroupCE.Size = new System.Drawing.Size(118, 20);
            this.varyColorInGroupCE.StyleController = this.layoutControl;
            this.varyColorInGroupCE.TabIndex = 7;
            // 
            // modeCBE
            // 
            this.modeCBE.EditValue = "By Group Level";
            this.modeCBE.Location = new System.Drawing.Point(66, 60);
            this.modeCBE.Name = "modeCBE";
            this.modeCBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.modeCBE.Properties.Items.AddRange(new object[] {
            "By Group Level",
            "By Item Index"});
            this.modeCBE.Size = new System.Drawing.Size(163, 20);
            this.modeCBE.StyleController = this.layoutControl;
            this.modeCBE.TabIndex = 9;
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem,
            this.layoutControlGroupInteraction1});
            this.layoutControlGroupRoot.Name = "Root";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(241, 538);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 92);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(241, 446);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroupInteraction1
            // 
            this.layoutControlGroupInteraction1.CustomizationFormText = "Group settings";
            this.layoutControlGroupInteraction1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupInteraction1.GroupBordersVisible = false;
            this.layoutControlGroupInteraction1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroupInteraction1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.colorizerLCI1,
            this.varyColorInGroupLCI,
            this.modeLCI});
            this.layoutControlGroupInteraction1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupInteraction1.Name = "layoutControlGroupInteraction1";
            this.layoutControlGroupInteraction1.Size = new System.Drawing.Size(241, 92);
            this.layoutControlGroupInteraction1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupInteraction1.Text = "Group settings";
            this.layoutControlGroupInteraction1.TextVisible = false;
            // 
            // colorizerLCI1
            // 
            this.colorizerLCI1.Control = this.colorizerCBE;
            this.colorizerLCI1.CustomizationFormText = "Colorizer";
            this.colorizerLCI1.Location = new System.Drawing.Point(0, 0);
            this.colorizerLCI1.Name = "colorizerLCI1";
            this.colorizerLCI1.Size = new System.Drawing.Size(221, 24);
            this.colorizerLCI1.Text = "Colorizer";
            this.colorizerLCI1.TextSize = new System.Drawing.Size(42, 13);
            // 
            // varyColorInGroupLCI
            // 
            this.varyColorInGroupLCI.Control = this.varyColorInGroupCE;
            this.varyColorInGroupLCI.CustomizationFormText = "varyColorInGroupLCI";
            this.varyColorInGroupLCI.Location = new System.Drawing.Point(0, 24);
            this.varyColorInGroupLCI.Name = "varyColorInGroupLCI";
            this.varyColorInGroupLCI.Size = new System.Drawing.Size(221, 24);
            this.varyColorInGroupLCI.TextSize = new System.Drawing.Size(0, 0);
            this.varyColorInGroupLCI.TextVisible = false;
            // 
            // modeLCI
            // 
            this.modeLCI.Control = this.modeCBE;
            this.modeLCI.CustomizationFormText = "Mode";
            this.modeLCI.Location = new System.Drawing.Point(0, 48);
            this.modeLCI.Name = "modeLCI";
            this.modeLCI.Size = new System.Drawing.Size(221, 24);
            this.modeLCI.Text = "Mode";
            this.modeLCI.TextSize = new System.Drawing.Size(42, 13);
            this.modeLCI.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sunburstControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(593, 306, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(546, 571);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(546, 571);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sunburstControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(546, 571);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // SunburstHierarchicalData
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.layoutControl1);
            this.Name = "SunburstHierarchicalData";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sunburstControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorizerCBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varyColorInGroupCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeCBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInteraction1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorizerLCI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varyColorInGroupLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private SunburstControl sunburstControl1;
        private XtraLayout.LayoutControl layoutControl;
        private XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private XtraEditors.ComboBoxEdit colorizerCBE;
        private XtraEditors.CheckEdit varyColorInGroupCE;
        private XtraEditors.ComboBoxEdit modeCBE;
        private XtraLayout.EmptySpaceItem emptySpaceItem;
        private XtraLayout.LayoutControlGroup layoutControlGroupInteraction1;
        private XtraLayout.LayoutControlItem colorizerLCI1;
        private XtraLayout.LayoutControlItem varyColorInGroupLCI;
        private XtraLayout.LayoutControlItem modeLCI;
    }
}
