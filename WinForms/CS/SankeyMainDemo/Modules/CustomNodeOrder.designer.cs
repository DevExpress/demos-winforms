namespace DevExpress.XtraSankey.Demos {
    partial class CustomNodeOrder {
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.Sankey.SankeyTitle sankeyTitle1 = new DevExpress.XtraCharts.Sankey.SankeyTitle();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.ordersTableAdapter1 = new DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.OrdersTableAdapter();
            this.nwindDataSet = new DevExpress.XtraSankey.Demos.nwindDataSet();
            this.customersTableAdapter1 = new DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.CustomersTableAdapter();
            this.productsTableAdapter1 = new DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.ProductsTableAdapter();
            this.nwindDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_DetailsTableAdapter1 = new DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.Order_DetailsTableAdapter();
            this.suppliersTableAdapter1 = new DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.SuppliersTableAdapter();
            this.categoriesTableAdapter1 = new DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.CategoriesTableAdapter();
            this.shippersTableAdapter1 = new DevExpress.XtraSankey.Demos.nwindDataSetTableAdapters.ShippersTableAdapter();
            this.layoutControlGroupRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupTotalLabels = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.comparerRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.orderRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.sankeyDiagramControl1 = new DevExpress.XtraCharts.Sankey.SankeyDiagramControl();
            this.sidePanelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).BeginInit();
            this.tabPaneOptions.SuspendLayout();
            this.tabNavigationPageOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupTotalLabels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparerRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanelOptions
            // 
            this.sidePanelOptions.Location = new System.Drawing.Point(578, 0);
            this.sidePanelOptions.Size = new System.Drawing.Size(210, 571);
            // 
            // tabPaneOptions
            // 
            this.tabPaneOptions.RegularSize = new System.Drawing.Size(209, 571);
            this.tabPaneOptions.Size = new System.Drawing.Size(209, 571);
            // 
            // tabNavigationPageOptions
            // 
            this.tabNavigationPageOptions.Controls.Add(this.layoutControl);
            this.tabNavigationPageOptions.Size = new System.Drawing.Size(209, 542);
            // 
            // toolTipController1
            // 
            this.toolTipController1.Appearance.Options.UseTextOptions = true;
            this.toolTipController1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.None;
            this.toolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // nwindDataSetBindingSource
            // 
            this.nwindDataSetBindingSource.DataSource = this.nwindDataSet;
            this.nwindDataSetBindingSource.Position = 0;
            // 
            // order_DetailsTableAdapter1
            // 
            this.order_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter1
            // 
            this.suppliersTableAdapter1.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // shippersTableAdapter1
            // 
            this.shippersTableAdapter1.ClearBeforeFill = true;
            // 
            // layoutControlGroupRoot
            // 
            this.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroupRoot.GroupBordersVisible = false;
            this.layoutControlGroupRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupTotalLabels,
            this.layoutControlGroup1});
            this.layoutControlGroupRoot.Name = "Root";
            this.layoutControlGroupRoot.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupRoot.Size = new System.Drawing.Size(209, 542);
            this.layoutControlGroupRoot.TextVisible = false;
            // 
            // layoutControlGroupTotalLabels
            // 
            this.layoutControlGroupTotalLabels.CustomizationFormText = "Sort by";
            this.layoutControlGroupTotalLabels.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroupTotalLabels.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroupTotalLabels.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupTotalLabels.Name = "layoutControlGroupTotalLabels";
            this.layoutControlGroupTotalLabels.Size = new System.Drawing.Size(209, 59);
            this.layoutControlGroupTotalLabels.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroupTotalLabels.Text = "Sort by";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.comparerRadioGroup;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(189, 17);
            this.layoutControlItem1.Text = "Sort by:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // comparerRadioGroup
            // 
            this.comparerRadioGroup.Location = new System.Drawing.Point(12, 34);
            this.comparerRadioGroup.MenuManager = this;
            this.comparerRadioGroup.Name = "comparerRadioGroup";
            this.comparerRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.comparerRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.comparerRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.comparerRadioGroup.Size = new System.Drawing.Size(185, 13);
            this.comparerRadioGroup.StyleController = this.layoutControl;
            this.comparerRadioGroup.TabIndex = 4;
            this.comparerRadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroup_SelectedIndexChanged);
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.comparerRadioGroup);
            this.layoutControl.Controls.Add(this.orderRadioGroup);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(835, 283, 650, 400);
            this.layoutControl.Root = this.layoutControlGroupRoot;
            this.layoutControl.Size = new System.Drawing.Size(209, 542);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl1";
            // 
            // orderRadioGroup
            // 
            this.orderRadioGroup.Location = new System.Drawing.Point(12, 93);
            this.orderRadioGroup.MenuManager = this;
            this.orderRadioGroup.Name = "orderRadioGroup";
            this.orderRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.orderRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.orderRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.orderRadioGroup.Size = new System.Drawing.Size(185, 13);
            this.orderRadioGroup.StyleController = this.layoutControl;
            this.orderRadioGroup.TabIndex = 5;
            this.orderRadioGroup.SelectedIndexChanged += new System.EventHandler(this.RadioGroup_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 59);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(209, 483);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "Order";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.orderRadioGroup;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(189, 17);
            this.layoutControlItem2.Text = "Order:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 17);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(189, 424);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // sankeyDiagramControl1
            // 
            this.sankeyDiagramControl1.BorderOptions.Thickness = 0;
            this.sankeyDiagramControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sankeyDiagramControl1.Location = new System.Drawing.Point(0, 0);
            this.sankeyDiagramControl1.Name = "sankeyDiagramControl1";
            this.sankeyDiagramControl1.Size = new System.Drawing.Size(578, 571);
            this.sankeyDiagramControl1.TabIndex = 5;
            this.sankeyDiagramControl1.Text = "sankeyDiagramControl1";
            sankeyTitle1.Text = "Top 10 Companies by Revenue";
            this.sankeyDiagramControl1.Titles.Add(sankeyTitle1);
            this.sankeyDiagramControl1.CustomizeNodeToolTip += new DevExpress.XtraCharts.Sankey.CustomizeSankeyNodeToolTipEventHandler(this.OnCustomizeNodeToolTip);
            this.sankeyDiagramControl1.CustomizeLinkToolTip += new DevExpress.XtraCharts.Sankey.CustomizeSankeyLinkToolTipEventHandler(this.OnCustomizeLinkToolTip);
            // 
            // CustomNodeOrder
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.sankeyDiagramControl1);
            this.Name = "CustomNodeOrder";
            this.Controls.SetChildIndex(this.sidePanelOptions, 0);
            this.Controls.SetChildIndex(this.sankeyDiagramControl1, 0);
            this.sidePanelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneOptions)).EndInit();
            this.tabPaneOptions.ResumeLayout(false);
            this.tabNavigationPageOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupTotalLabels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparerRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.BindingSource nwindDataSetBindingSource;
        private nwindDataSet nwindDataSet;
        private nwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private nwindDataSetTableAdapters.Order_DetailsTableAdapter order_DetailsTableAdapter1;
        private nwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private nwindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter1;
        private nwindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private nwindDataSetTableAdapters.ShippersTableAdapter shippersTableAdapter1;
        private nwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private XtraLayout.LayoutControl layoutControl;
        private XtraLayout.LayoutControlGroup layoutControlGroupRoot;
        private XtraCharts.Sankey.SankeyDiagramControl sankeyDiagramControl1;
        private XtraEditors.RadioGroup comparerRadioGroup;
        private XtraEditors.RadioGroup orderRadioGroup;
        private XtraLayout.LayoutControlGroup layoutControlGroupTotalLabels;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
