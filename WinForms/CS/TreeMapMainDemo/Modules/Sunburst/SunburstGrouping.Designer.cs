namespace DevExpress.XtraTreeMap.Demos {
    partial class SunburstGrouping {
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
            DevExpress.XtraTreeMap.SunburstFlatDataAdapter sunburstFlatDataAdapter1 = new DevExpress.XtraTreeMap.SunburstFlatDataAdapter();
            DevExpress.XtraTreeMap.ColorListLegend colorListLegend1 = new DevExpress.XtraTreeMap.ColorListLegend();
            this.sunburstControl1 = new DevExpress.XtraTreeMap.SunburstControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.displayModeCBE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.autoLayoutCE = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroupInteraction1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.displayModeLCI1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.varyColorInGroupLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sunburstControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayModeCBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoLayoutCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInteraction1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayModeLCI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varyColorInGroupLCI)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPaneOptions
            // 
            this.tabPaneOptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl1);
            this.tabNavigationPageOptions.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(241, 538);
            // 
            // sunburstControl1
            // 
            this.sunburstControl1.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.sunburstControl1.BorderOptions.Thickness = 2;
            this.sunburstControl1.CenterLabel.TextPattern = "Periodic Table";
            sunburstFlatDataAdapter1.GroupDataMembersSerializable = "Block;Family;";
            sunburstFlatDataAdapter1.LabelDataMember = "Symbol";
            sunburstFlatDataAdapter1.ValueDataMember = "FakeValue";
            this.sunburstControl1.DataAdapter = sunburstFlatDataAdapter1;
            this.sunburstControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            colorListLegend1.Title.Font = new System.Drawing.Font("Tahoma", 10F);
            colorListLegend1.Title.Text = "Chemical Element Block";
            this.sunburstControl1.Legend = colorListLegend1;
            this.sunburstControl1.Location = new System.Drawing.Point(0, 0);
            this.sunburstControl1.MaxVisibleLevel = 5;
            this.sunburstControl1.Name = "sunburstControl1";
            this.sunburstControl1.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.sunburstControl1.Size = new System.Drawing.Size(546, 571);
            this.sunburstControl1.TabIndex = 1;
            this.sunburstControl1.ToolTipController = this.toolTipController1;
            this.sunburstControl1.ToolTipTextPattern = "{L}: {V}MB";
            // 
            // toolTipController1
            // 
            this.toolTipController1.AutoPopDelay = 50000;
            this.toolTipController1.BeforeShow += new DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(this.toolTipController1_BeforeShow);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.displayModeCBE);
            this.layoutControl1.Controls.Add(this.autoLayoutCE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(241, 538);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // displayModeCBE
            // 
            this.displayModeCBE.Location = new System.Drawing.Point(105, 7);
            this.displayModeCBE.Name = "displayModeCBE";
            this.displayModeCBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.displayModeCBE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.displayModeCBE.Size = new System.Drawing.Size(129, 20);
            this.displayModeCBE.StyleController = this.layoutControl1;
            this.displayModeCBE.TabIndex = 8;
            this.displayModeCBE.SelectedIndexChanged += new System.EventHandler(this.displayModeCBE_SelectedIndexChanged);
            // 
            // autoLayoutCE
            // 
            this.autoLayoutCE.EditValue = true;
            this.autoLayoutCE.Location = new System.Drawing.Point(7, 29);
            this.autoLayoutCE.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.autoLayoutCE.Name = "autoLayoutCE";
            this.autoLayoutCE.Properties.AutoWidth = true;
            this.autoLayoutCE.Properties.Caption = "Auto Layout";
            this.autoLayoutCE.Size = new System.Drawing.Size(82, 20);
            this.autoLayoutCE.StyleController = this.layoutControl1;
            this.autoLayoutCE.TabIndex = 7;
            this.autoLayoutCE.CheckedChanged += new System.EventHandler(this.autoLayoutCE_CheckedChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem,
            this.layoutControlGroupInteraction1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(241, 538);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.CustomizationFormText = "emptySpaceItem";
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 44);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(229, 482);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroupInteraction1
            // 
            this.layoutControlGroupInteraction1.CustomizationFormText = "Group settings";
            this.layoutControlGroupInteraction1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupInteraction1.GroupBordersVisible = false;
            this.layoutControlGroupInteraction1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroupInteraction1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.displayModeLCI1,
            this.varyColorInGroupLCI});
            this.layoutControlGroupInteraction1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupInteraction1.Name = "layoutControlGroupInteraction1";
            this.layoutControlGroupInteraction1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupInteraction1.Size = new System.Drawing.Size(229, 44);
            this.layoutControlGroupInteraction1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupInteraction1.Text = "Group settings";
            this.layoutControlGroupInteraction1.TextVisible = false;
            // 
            // displayModeLCI1
            // 
            this.displayModeLCI1.Control = this.displayModeCBE;
            this.displayModeLCI1.CustomizationFormText = "Colorizer";
            this.displayModeLCI1.Location = new System.Drawing.Point(0, 0);
            this.displayModeLCI1.Name = "displayModeLCI1";
            this.displayModeLCI1.Size = new System.Drawing.Size(229, 22);
            this.displayModeLCI1.Text = "Label Display Mode";
            this.displayModeLCI1.TextSize = new System.Drawing.Size(91, 13);
            // 
            // varyColorInGroupLCI
            // 
            this.varyColorInGroupLCI.Control = this.autoLayoutCE;
            this.varyColorInGroupLCI.CustomizationFormText = "varyColorInGroupLCI";
            this.varyColorInGroupLCI.Location = new System.Drawing.Point(0, 22);
            this.varyColorInGroupLCI.Name = "varyColorInGroupLCI";
            this.varyColorInGroupLCI.Size = new System.Drawing.Size(229, 22);
            this.varyColorInGroupLCI.TextSize = new System.Drawing.Size(0, 0);
            this.varyColorInGroupLCI.TextVisible = false;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.sunburstControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(546, 571);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // SunburstGrouping
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "SunburstGrouping";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.sidePanel1, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sunburstControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayModeCBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoLayoutCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInteraction1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayModeLCI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varyColorInGroupLCI)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SunburstControl sunburstControl1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraEditors.ComboBoxEdit displayModeCBE;
        private XtraEditors.CheckEdit autoLayoutCE;
        private XtraLayout.EmptySpaceItem emptySpaceItem;
        private XtraLayout.LayoutControlGroup layoutControlGroupInteraction1;
        private XtraLayout.LayoutControlItem displayModeLCI1;
        private XtraLayout.LayoutControlItem varyColorInGroupLCI;
        private XtraEditors.SidePanel sidePanel1;
    }
}
