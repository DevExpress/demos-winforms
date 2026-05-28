namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class OrderReports {
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
            this.fieldOrderID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProduct = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiscount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSum = new DevExpress.XtraPivotGrid.PivotGridField();
            this.rgReport = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbeOrder = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.dsReports1 = new DevExpress.XtraPivotGrid.Demos.dsReports();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.rgReport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fieldOrderID
            // 
            this.fieldOrderID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldOrderID.AreaIndex = 0;
            this.fieldOrderID.Caption = "Order";
            this.fieldOrderID.DataBinding = new DataSourceColumnBinding("OrderID");
            this.fieldOrderID.Name = "fieldOrderID";
            this.fieldOrderID.Width = 105;
            // 
            // fieldProduct
            // 
            this.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProduct.AreaIndex = 1;
            this.fieldProduct.Caption = "Product Name";
            this.fieldProduct.DataBinding = new DataSourceColumnBinding("ProductName");
            this.fieldProduct.Name = "fieldProduct";
            this.fieldProduct.Width = 185;
            // 
            // fieldUnitPrice
            // 
            this.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitPrice.AreaIndex = 0;
            this.fieldUnitPrice.Caption = "Unit Price";
            this.fieldUnitPrice.CellFormat.FormatString = "c";
            this.fieldUnitPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldUnitPrice.DataBinding = new DataSourceColumnBinding("UnitPrice");
            this.fieldUnitPrice.Name = "fieldUnitPrice";
            this.fieldUnitPrice.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldUnitPrice.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 1;
            this.fieldQuantity.DataBinding = new DataSourceColumnBinding("Quantity");
            this.fieldQuantity.Name = "fieldQuantity";
            this.fieldQuantity.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            // 
            // fieldDiscount
            // 
            this.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDiscount.AreaIndex = 2;
            this.fieldDiscount.DataBinding = new DataSourceColumnBinding("Discount");
            this.fieldDiscount.Name = "fieldDiscount";
            this.fieldDiscount.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.fieldDiscount.TotalCellFormat.FormatString = "P";
            this.fieldDiscount.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldDiscount.Width = 99;
            // 
            // fieldSum
            // 
            this.fieldSum.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSum.AreaIndex = 3;
            this.fieldSum.CellFormat.FormatString = "c";
            this.fieldSum.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldSum.DataBinding = new DataSourceColumnBinding("Extended Price");
            this.fieldSum.Name = "fieldSum";
            this.fieldSum.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.False;
            this.fieldSum.Width = 120;
            // 
            // rgReport
            // 
            this.rgReport.AutoSizeInLayoutControl = true;
            this.rgReport.Location = new System.Drawing.Point(12, 31);
            this.rgReport.Name = "rgReport";
            this.rgReport.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgReport.Properties.Appearance.Options.UseBackColor = true;
            this.rgReport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgReport.Properties.Columns = 1;
            this.rgReport.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Orders"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Orders (filtering)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Quantity"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Average Unit Price")});
            this.rgReport.Size = new System.Drawing.Size(175, 68);
            this.rgReport.StyleController = this.layoutControl1;
            this.rgReport.TabIndex = 0;
            this.rgReport.SelectedIndexChanged += new System.EventHandler(this.rgReport_SelectedIndexChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.cbeOrder);
            this.layoutControl1.Controls.Add(this.rgReport);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(462, 490, 814, 613);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(199, 594);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbeOrder
            // 
            this.cbeOrder.EditValue = "";
            this.cbeOrder.Location = new System.Drawing.Point(58, 103);
            this.cbeOrder.Name = "cbeOrder";
            this.cbeOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeOrder.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeOrder.Size = new System.Drawing.Size(129, 20);
            this.cbeOrder.StyleController = this.layoutControl1;
            this.cbeOrder.TabIndex = 1;
            this.cbeOrder.SelectedIndexChanged += new System.EventHandler(this.cbeOrder_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(199, 594);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 135);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(199, 459);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(199, 135);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Order Reports";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rgReport;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(179, 72);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbeOrder;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(179, 24);
            this.layoutControlItem2.Text = "OrderID:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(43, 13);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.ActiveFilterString = "";
            this.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pivotGridControl1.DataSource = this.dsReports1.OrderReports;
            this.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldOrderID,
            this.fieldProduct,
            this.fieldUnitPrice,
            this.fieldQuantity,
            this.fieldDiscount,
            this.fieldSum});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(831, 621);
            this.pivotGridControl1.TabIndex = 4;
            // 
            // dsReports1
            // 
            this.dsReports1.DataSetName = "dsReports";
            this.dsReports1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mainPanel.Controls.Add(this.pivotGridControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(831, 621);
            this.mainPanel.TabIndex = 13;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(831, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(200, 621);
            this.sidePanel1.TabIndex = 5;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.Default;
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(199, 621);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(199, 621);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(199, 594);
            // 
            // OrderReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel1);
            this.Name = "OrderReports";
            this.Size = new System.Drawing.Size(1031, 621);
            this.Load += new System.EventHandler(this.OrderReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgReport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProduct;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQuantity;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDiscount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSum;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.Demos.dsReports dsReports1;
		private DevExpress.XtraEditors.RadioGroup rgReport;
		private DevExpress.XtraEditors.ComboBoxEdit cbeOrder;
        private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PanelControl mainPanel;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
    }
}
