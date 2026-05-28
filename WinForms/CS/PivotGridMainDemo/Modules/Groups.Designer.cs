namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class Groups {
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
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding7 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding8 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup2 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup3 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderDate2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiscount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.dsSalesPerson1 = new DevExpress.XtraPivotGrid.Demos.dsSalesPerson();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceColumns = new DevExpress.XtraEditors.CheckEdit();
            this.ceRows = new DevExpress.XtraEditors.CheckEdit();
            this.ceData = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceColumns.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRows.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category Name";
            dataSourceColumnBinding1.ColumnName = "CategoryName";
            this.fieldCategoryName.DataBinding = dataSourceColumnBinding1;
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.Width = 150;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product Name";
            dataSourceColumnBinding2.ColumnName = "ProductName";
            this.fieldProductName.DataBinding = dataSourceColumnBinding2;
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Width = 170;
            // 
            // fieldOrderDate
            // 
            this.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate.AreaIndex = 0;
            this.fieldOrderDate.Caption = "Year";
            dataSourceColumnBinding3.ColumnName = "OrderDate";
            dataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderDate.DataBinding = dataSourceColumnBinding3;
            this.fieldOrderDate.Name = "fieldOrderDate";
            this.fieldOrderDate.UnboundFieldName = "fieldOrderDate";
            // 
            // fieldOrderDate1
            // 
            this.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate1.AreaIndex = 1;
            this.fieldOrderDate1.Caption = "Quarter";
            dataSourceColumnBinding4.ColumnName = "OrderDate";
            dataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldOrderDate1.DataBinding = dataSourceColumnBinding4;
            this.fieldOrderDate1.Name = "fieldOrderDate1";
            this.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1";
            this.fieldOrderDate1.ValueFormat.FormatString = "Quarter {0}";
            this.fieldOrderDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldOrderDate2
            // 
            this.fieldOrderDate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderDate2.AreaIndex = 2;
            this.fieldOrderDate2.Caption = "Month";
            dataSourceColumnBinding5.ColumnName = "OrderDate";
            dataSourceColumnBinding5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldOrderDate2.DataBinding = dataSourceColumnBinding5;
            this.fieldOrderDate2.Name = "fieldOrderDate2";
            this.fieldOrderDate2.UnboundFieldName = "fieldOrderDate2";
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Order Amount";
            dataSourceColumnBinding6.ColumnName = "Extended Price";
            this.fieldExtendedPrice.DataBinding = dataSourceColumnBinding6;
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 1;
            dataSourceColumnBinding7.ColumnName = "Quantity";
            this.fieldQuantity.DataBinding = dataSourceColumnBinding7;
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // fieldDiscount
            // 
            this.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDiscount.AreaIndex = 2;
            this.fieldDiscount.Caption = "Discount (Avg)";
            this.fieldDiscount.CellFormat.FormatString = "p";
            this.fieldDiscount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            dataSourceColumnBinding8.ColumnName = "Discount";
            this.fieldDiscount.DataBinding = dataSourceColumnBinding8;
            this.fieldDiscount.Name = "fieldDiscount";
            this.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            // 
            // dsSalesPerson1
            // 
            this.dsSalesPerson1.DataSetName = "dsSalesPerson";
            this.dsSalesPerson1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.ceColumns);
            this.layoutControl1.Controls.Add(this.ceRows);
            this.layoutControl1.Controls.Add(this.ceData);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(838, 330, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(199, 387);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceColumns
            // 
            this.ceColumns.Location = new System.Drawing.Point(12, 34);
            this.ceColumns.Name = "ceColumns";
            this.ceColumns.Properties.AllowGrayed = true;
            this.ceColumns.Properties.Caption = "Collapse Column Groups";
            this.ceColumns.Size = new System.Drawing.Size(175, 20);
            this.ceColumns.StyleController = this.layoutControl1;
            this.ceColumns.TabIndex = 6;
            this.ceColumns.CheckedChanged += new System.EventHandler(this.ceColumns_CheckedChanged);
            this.ceColumns.CheckStateChanged += new System.EventHandler(this.CheckStateChanged);
            // 
            // ceRows
            // 
            this.ceRows.Location = new System.Drawing.Point(12, 58);
            this.ceRows.Name = "ceRows";
            this.ceRows.Properties.AllowGrayed = true;
            this.ceRows.Properties.Caption = "Collapse Row Groups";
            this.ceRows.Size = new System.Drawing.Size(175, 20);
            this.ceRows.StyleController = this.layoutControl1;
            this.ceRows.TabIndex = 7;
            this.ceRows.CheckedChanged += new System.EventHandler(this.ceRows_CheckedChanged);
            this.ceRows.CheckStateChanged += new System.EventHandler(this.CheckStateChanged);
            // 
            // ceData
            // 
            this.ceData.Location = new System.Drawing.Point(12, 82);
            this.ceData.Name = "ceData";
            this.ceData.Properties.AllowGrayed = true;
            this.ceData.Properties.Caption = "Collapse Data Groups";
            this.ceData.Size = new System.Drawing.Size(175, 20);
            this.ceData.StyleController = this.layoutControl1;
            this.ceData.TabIndex = 8;
            this.ceData.CheckedChanged += new System.EventHandler(this.ceData_CheckedChanged);
            this.ceData.CheckStateChanged += new System.EventHandler(this.CheckStateChanged);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(199, 387);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 114);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(199, 273);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem5});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(199, 114);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Collapsed State";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceColumns;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(179, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ceRows;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(179, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ceData;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(179, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.dsSalesPerson1.SalesPerson;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldProductName,
            this.fieldQuantity,
            this.fieldExtendedPrice,
            this.fieldDiscount,
            this.fieldOrderDate,
            this.fieldOrderDate1,
            this.fieldOrderDate2});
            pivotGridGroup1.Fields.Add(this.fieldCategoryName);
            pivotGridGroup1.Fields.Add(this.fieldProductName);
            pivotGridGroup2.Fields.Add(this.fieldOrderDate);
            pivotGridGroup2.Fields.Add(this.fieldOrderDate1);
            pivotGridGroup2.Fields.Add(this.fieldOrderDate2);
            pivotGridGroup3.Fields.Add(this.fieldExtendedPrice);
            pivotGridGroup3.Fields.Add(this.fieldQuantity);
            pivotGridGroup3.Fields.Add(this.fieldDiscount);
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1,
            pivotGridGroup2,
            pivotGridGroup3});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(504, 416);
            this.pivotGridControl1.TabIndex = 12;
            this.pivotGridControl1.FieldAreaChanged += new DevExpress.XtraPivotGrid.PivotFieldEventHandler(this.pivotGridControl1_FieldAreaChanged);
            this.pivotGridControl1.FieldExpandedInFieldGroupChanged += new DevExpress.XtraPivotGrid.PivotFieldEventHandler(this.pivotGridControl1_FieldExpandedInFieldGroupChanged);
            this.pivotGridControl1.FieldValueImageIndex += new DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(this.pivotGridControl1_FieldValueImageIndex);
            this.pivotGridControl1.CustomDrawFieldHeader += new DevExpress.XtraPivotGrid.PivotCustomDrawFieldHeaderEventHandler(this.pivotGridControl1_CustomDrawFieldHeader);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(504, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(200, 416);
            this.sidePanel1.TabIndex = 13;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(1, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(199, 416);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(199, 416);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(199, 387);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "Groups";
            this.Size = new System.Drawing.Size(704, 416);
            this.Load += new System.EventHandler(this.Groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceColumns.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceRows.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
		private DevExpress.XtraPivotGrid.Demos.dsSalesPerson dsSalesPerson1;
        private System.ComponentModel.IContainer components = null;
		private PivotGridControl pivotGridControl1;
		private PivotGridField fieldCategoryName;
		private PivotGridField fieldProductName;
		private PivotGridField fieldQuantity;
		private PivotGridField fieldExtendedPrice;
		private PivotGridField fieldDiscount;
		private PivotGridField fieldOrderDate;
		private PivotGridField fieldOrderDate1;
		private PivotGridField fieldOrderDate2;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraEditors.CheckEdit ceColumns;
        private XtraEditors.CheckEdit ceRows;
        private XtraEditors.CheckEdit ceData;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
