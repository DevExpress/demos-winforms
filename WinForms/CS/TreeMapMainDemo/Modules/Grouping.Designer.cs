namespace DevExpress.XtraTreeMap.Demos {
    partial class Grouping {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraTreeMap.TreeMapPaletteColorizer treeMapPaletteColorizer1 = new DevExpress.XtraTreeMap.TreeMapPaletteColorizer();
            DevExpress.XtraTreeMap.TreeMapFlatDataAdapter treeMapFlatDataAdapter1 = new DevExpress.XtraTreeMap.TreeMapFlatDataAdapter();
            DevExpress.XtraTreeMap.Title title1 = new DevExpress.XtraTreeMap.Title();
            this.treeMapControl1 = new DevExpress.XtraTreeMap.TreeMapControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.groupByCBE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.enableGroupingCE = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupInteraction = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupByLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItemAllowAnchoring = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupByCBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enableGroupingCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInteraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupByLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAllowAnchoring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanelOptions
            // 
            this.sidePanelOptions.Location = new System.Drawing.Point(728, 10);
            this.sidePanelOptions.Size = new System.Drawing.Size(323, 737);
            // 
            // tabPaneOptions
            // 
            this.tabPaneOptions.Margin = new System.Windows.Forms.Padding(2);
            this.tabPaneOptions.RegularSize = new System.Drawing.Size(322, 737);
            this.tabPaneOptions.Size = new System.Drawing.Size(322, 737);
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(322, 696);
            // 
            // treeMapControl1
            // 
            this.treeMapControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.treeMapControl1.BorderOptions.Thickness = 2;
            this.treeMapControl1.BorderOptions.Visible = false;
            this.treeMapControl1.Colorizer = treeMapPaletteColorizer1;
            treeMapFlatDataAdapter1.DataMember = null;
            treeMapFlatDataAdapter1.LabelDataMember = "Name";
            treeMapFlatDataAdapter1.ValueDataMember = "NetWorth";
            this.treeMapControl1.DataAdapter = treeMapFlatDataAdapter1;
            this.treeMapControl1.Location = new System.Drawing.Point(0, 0);
            this.treeMapControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeMapControl1.Name = "treeMapControl1";
            this.treeMapControl1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.treeMapControl1.Size = new System.Drawing.Size(728, 737);
            this.treeMapControl1.TabIndex = 0;
            title1.Indent = 0;
            title1.Text = "Forbes World\'s Billionaires 2010";
            this.treeMapControl1.Titles.Add(title1);
            this.treeMapControl1.ToolTipController = this.toolTipController1;
            this.treeMapControl1.ToolTipGroupPattern = "{L}: {V}B$";
            this.treeMapControl1.ToolTipLeafPattern = "{L}: {V}B$";
            // 
            // toolTipController1
            // 
            this.toolTipController1.Appearance.Options.UseTextOptions = true;
            this.toolTipController1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.groupByCBE);
            this.layoutControl.Controls.Add(this.enableGroupingCE);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(322, 696);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // groupByCBE
            // 
            this.groupByCBE.Location = new System.Drawing.Point(83, 46);
            this.groupByCBE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupByCBE.Name = "groupByCBE";
            this.groupByCBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.groupByCBE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.groupByCBE.Size = new System.Drawing.Size(223, 22);
            this.groupByCBE.StyleController = this.layoutControl;
            this.groupByCBE.TabIndex = 8;
            this.groupByCBE.EditValueChanged += new System.EventHandler(this.groupByCBE_EditValueChanged);
            // 
            // enableGroupingCE
            // 
            this.enableGroupingCE.EditValue = true;
            this.enableGroupingCE.Location = new System.Drawing.Point(16, 16);
            this.enableGroupingCE.Margin = new System.Windows.Forms.Padding(13, 13, 0, 0);
            this.enableGroupingCE.Name = "enableGroupingCE";
            this.enableGroupingCE.Properties.AutoWidth = true;
            this.enableGroupingCE.Properties.Caption = "Enable Grouping";
            this.enableGroupingCE.Size = new System.Drawing.Size(121, 24);
            this.enableGroupingCE.StyleController = this.layoutControl;
            this.enableGroupingCE.TabIndex = 7;
            this.enableGroupingCE.CheckedChanged += new System.EventHandler(this.enableGroupingCE_CheckedChanged);
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupInteraction,
            this.emptySpaceItem});
            this.layoutControlGroupRoot.Name = "Root";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(322, 696);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // layoutControlGroupInteraction
            // 
            this.layoutControlGroupInteraction.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupInteraction.GroupBordersVisible = false;
            this.layoutControlGroupInteraction.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroupInteraction.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupByLCI,
            this.layoutControlItemAllowAnchoring});
            this.layoutControlGroupInteraction.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupInteraction.Name = "layoutControlGroupInteraction";
            this.layoutControlGroupInteraction.Size = new System.Drawing.Size(322, 84);
            this.layoutControlGroupInteraction.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupInteraction.Text = "Group settings";
            this.layoutControlGroupInteraction.TextVisible = false;
            // 
            // groupByLCI
            // 
            this.groupByLCI.Control = this.groupByCBE;
            this.groupByLCI.Location = new System.Drawing.Point(0, 30);
            this.groupByLCI.Name = "groupByLCI";
            this.groupByLCI.Size = new System.Drawing.Size(296, 28);
            this.groupByLCI.Text = "Group By";
            this.groupByLCI.TextSize = new System.Drawing.Size(51, 16);
            // 
            // layoutControlItemAllowAnchoring
            // 
            this.layoutControlItemAllowAnchoring.Control = this.enableGroupingCE;
            this.layoutControlItemAllowAnchoring.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItemAllowAnchoring.Name = "layoutControlItemAllowAnchoring";
            this.layoutControlItemAllowAnchoring.Size = new System.Drawing.Size(296, 30);
            this.layoutControlItemAllowAnchoring.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItemAllowAnchoring.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 84);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(322, 612);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.treeMapControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 10);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(593, 306, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(728, 737);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(728, 737);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.treeMapControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(728, 737);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Grouping
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Grouping";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupByCBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enableGroupingCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInteraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupByLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItemAllowAnchoring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private TreeMapControl treeMapControl1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private XtraLayout.LayoutControl layoutControl;
        private XtraEditors.CheckEdit enableGroupingCE;
        private XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        private XtraLayout.LayoutControlGroup layoutControlGroupInteraction;
        private XtraLayout.LayoutControlItem layoutControlItemAllowAnchoring;
        private XtraLayout.EmptySpaceItem emptySpaceItem;
        private XtraEditors.ComboBoxEdit groupByCBE;
        private XtraLayout.LayoutControlItem groupByLCI;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
