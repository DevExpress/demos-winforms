namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class FieldsCustomization {
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
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding9 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.dsSalesPerson1 = new DevExpress.XtraPivotGrid.Demos.dsSalesPerson();
            this.fieldCountry = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.icbCustomizationStyle = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.sbCustomizationForm = new DevExpress.XtraEditors.SimpleButton();
            this.ceSearchBox = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowSort = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowFilter = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAllowSort = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAllowFilter = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbCustomizationStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSearchBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowSort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAllowSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAllowFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // dsSalesPerson1
            // 
            this.dsSalesPerson1.DataSetName = "dsSalesPerson";
            this.dsSalesPerson1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldCountry
            // 
            this.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCountry.AreaIndex = 0;
            dataSourceColumnBinding1.ColumnName = "Country";
            this.fieldCountry.DataBinding = dataSourceColumnBinding1;
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSalesPerson.AreaIndex = 1;
            dataSourceColumnBinding2.ColumnName = "Sales Person";
            this.fieldSalesPerson.DataBinding = dataSourceColumnBinding2;
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            this.fieldSalesPerson.Width = 130;
            // 
            // fieldYear
            // 
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Order Year";
            dataSourceColumnBinding3.ColumnName = "OrderDate";
            dataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.DataBinding = dataSourceColumnBinding3;
            this.fieldYear.Name = "fieldYear";
            this.fieldYear.UnboundFieldName = "fieldYear";
            this.fieldYear.Width = 120;
            // 
            // fieldQuarter
            // 
            this.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldQuarter.AreaIndex = 0;
            this.fieldQuarter.Caption = "Order Quarter";
            dataSourceColumnBinding4.ColumnName = "OrderDate";
            dataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldQuarter.DataBinding = dataSourceColumnBinding4;
            this.fieldQuarter.Name = "fieldQuarter";
            this.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQuarter.UnboundFieldName = "fieldQuarter";
            this.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQuarter.Width = 140;
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Order Amount";
            this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            dataSourceColumnBinding5.ColumnName = "Extended Price";
            this.fieldExtendedPrice.DataBinding = dataSourceColumnBinding5;
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            dataSourceColumnBinding6.ColumnName = "Quantity";
            this.fieldQuantity.DataBinding = dataSourceColumnBinding6;
            this.fieldQuantity.Name = "fieldQuantity";
            this.fieldQuantity.Visible = false;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Caption = "Product Name";
            dataSourceColumnBinding7.ColumnName = "ProductName";
            this.fieldProductName.DataBinding = dataSourceColumnBinding7;
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Visible = false;
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 1;
            this.fieldCategoryName.Caption = "Category Name";
            dataSourceColumnBinding8.ColumnName = "CategoryName";
            this.fieldCategoryName.DataBinding = dataSourceColumnBinding8;
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.Width = 139;
            // 
            // fieldOrderID
            // 
            dataSourceColumnBinding9.ColumnName = "OrderID";
            this.fieldOrderID.DataBinding = dataSourceColumnBinding9;
            this.fieldOrderID.Name = "fieldOrderID";
            this.fieldOrderID.Visible = false;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.dsSalesPerson1.SalesPerson;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCountry,
            this.fieldSalesPerson,
            this.fieldYear,
            this.fieldQuarter,
            this.fieldExtendedPrice,
            this.fieldQuantity,
            this.fieldProductName,
            this.fieldCategoryName,
            this.fieldOrderID});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsCustomization.CustomizationFormSnapMode = ((DevExpress.Utils.Controls.SnapMode)((((DevExpress.Utils.Controls.SnapMode.OwnerControl | DevExpress.Utils.Controls.SnapMode.OwnerForm) 
            | DevExpress.Utils.Controls.SnapMode.Screens) 
            | DevExpress.Utils.Controls.SnapMode.SnapForms)));
            this.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.pivotGridControl1.Size = new System.Drawing.Size(497, 416);
            this.pivotGridControl1.TabIndex = 12;
            this.pivotGridControl1.ShowCustomizationForm += new System.EventHandler(this.pivotGridControl1_ShowCustomizationForm);
            this.pivotGridControl1.HideCustomizationForm += new System.EventHandler(this.pivotGridControl1_HideCustomizationForm);
            this.pivotGridControl1.FieldValueImageIndex += new DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(this.pivotGridControl1_FieldValueImageIndex);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(497, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(210, 416);
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
            this.tabPane1.RegularSize = new System.Drawing.Size(209, 416);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(209, 416);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(209, 387);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.icbCustomizationStyle);
            this.layoutControl1.Controls.Add(this.sbCustomizationForm);
            this.layoutControl1.Controls.Add(this.ceSearchBox);
            this.layoutControl1.Controls.Add(this.ceAllowSort);
            this.layoutControl1.Controls.Add(this.ceAllowFilter);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1109, 139, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(209, 387);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // icbCustomizationStyle
            // 
            this.icbCustomizationStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icbCustomizationStyle.EditValue = "imageComboBoxEdit1";
            this.icbCustomizationStyle.Location = new System.Drawing.Point(12, 74);
            this.icbCustomizationStyle.Name = "icbCustomizationStyle";
            this.icbCustomizationStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbCustomizationStyle.Properties.DropDownRows = 10;
            this.icbCustomizationStyle.Size = new System.Drawing.Size(185, 20);
            this.icbCustomizationStyle.StyleController = this.layoutControl1;
            this.icbCustomizationStyle.TabIndex = 8;
            this.icbCustomizationStyle.SelectedIndexChanged += new System.EventHandler(this.icbCustomizationStyle_SelectedIndexChanged);
            // 
            // sbCustomizationForm
            // 
            this.sbCustomizationForm.Location = new System.Drawing.Point(12, 34);
            this.sbCustomizationForm.Name = "sbCustomizationForm";
            this.sbCustomizationForm.Size = new System.Drawing.Size(185, 20);
            this.sbCustomizationForm.StyleController = this.layoutControl1;
            this.sbCustomizationForm.TabIndex = 0;
            this.sbCustomizationForm.Click += new System.EventHandler(this.sbCustomizationForm_Click);
            // 
            // ceSearchBox
            // 
            this.ceSearchBox.Location = new System.Drawing.Point(12, 146);
            this.ceSearchBox.Name = "ceSearchBox";
            this.ceSearchBox.Properties.Caption = "Show Search Box";
            this.ceSearchBox.Size = new System.Drawing.Size(185, 20);
            this.ceSearchBox.StyleController = this.layoutControl1;
            this.ceSearchBox.TabIndex = 9;
            this.ceSearchBox.CheckedChanged += new System.EventHandler(this.OnSearchBoxVisibilityChanged);
            // 
            // ceAllowSort
            // 
            this.ceAllowSort.Location = new System.Drawing.Point(12, 122);
            this.ceAllowSort.Name = "ceAllowSort";
            this.ceAllowSort.Properties.Caption = "Allow Sorting in Field List";
            this.ceAllowSort.Size = new System.Drawing.Size(185, 20);
            this.ceAllowSort.StyleController = this.layoutControl1;
            this.ceAllowSort.TabIndex = 10;
            this.ceAllowSort.CheckedChanged += new System.EventHandler(this.ceAllowSort_CheckedChanged);
            // 
            // ceAllowFilter
            // 
            this.ceAllowFilter.Location = new System.Drawing.Point(12, 98);
            this.ceAllowFilter.Name = "ceAllowFilter";
            this.ceAllowFilter.Properties.Caption = "Allow Filtering in Field List";
            this.ceAllowFilter.Size = new System.Drawing.Size(185, 20);
            this.ceAllowFilter.StyleController = this.layoutControl1;
            this.ceAllowFilter.TabIndex = 11;
            this.ceAllowFilter.CheckedChanged += new System.EventHandler(this.ceAllowFilter_CheckedChanged);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(209, 387);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 178);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(209, 209);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.lciAllowSort,
            this.lciAllowFilter});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(209, 178);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Customization Form";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.icbCustomizationStyle;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(189, 40);
            this.layoutControlItem2.Text = "Customization Style:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(98, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbCustomizationForm;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(189, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ceSearchBox;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(189, 24);
            this.layoutControlItem4.Text = "Show Search Box:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // lciAllowSort
            // 
            this.lciAllowSort.Control = this.ceAllowSort;
            this.lciAllowSort.Location = new System.Drawing.Point(0, 88);
            this.lciAllowSort.Name = "lciAllowSort";
            this.lciAllowSort.Size = new System.Drawing.Size(189, 24);
            this.lciAllowSort.TextSize = new System.Drawing.Size(0, 0);
            this.lciAllowSort.TextVisible = false;
            // 
            // lciAllowFilter
            // 
            this.lciAllowFilter.Control = this.ceAllowFilter;
            this.lciAllowFilter.Location = new System.Drawing.Point(0, 64);
            this.lciAllowFilter.Name = "lciAllowFilter";
            this.lciAllowFilter.Size = new System.Drawing.Size(189, 24);
            this.lciAllowFilter.TextSize = new System.Drawing.Size(0, 0);
            this.lciAllowFilter.TextVisible = false;
            // 
            // FieldsCustomization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "FieldsCustomization";
            this.Size = new System.Drawing.Size(707, 416);
            this.Load += new System.EventHandler(this.FieldsCustomization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSalesPerson1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbCustomizationStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceSearchBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowSort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAllowSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAllowFilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
		private DevExpress.XtraPivotGrid.Demos.dsSalesPerson dsSalesPerson1;
        private DevExpress.XtraEditors.SimpleButton sbCustomizationForm;
        private System.ComponentModel.IContainer components = null;
		private PivotGridControl pivotGridControl1;
		private PivotGridField fieldCountry;
		private PivotGridField fieldSalesPerson;
		private PivotGridField fieldYear;
		private PivotGridField fieldQuarter;
		private PivotGridField fieldExtendedPrice;
		private PivotGridField fieldQuantity;
		private PivotGridField fieldProductName;
		private PivotGridField fieldCategoryName;
		private PivotGridField fieldOrderID;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbCustomizationStyle;
        private XtraEditors.SidePanel sidePanel1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraEditors.CheckEdit ceSearchBox;
        private XtraEditors.CheckEdit ceAllowFilter;
        private XtraLayout.LayoutControlItem lciAllowFilter;
        private XtraEditors.CheckEdit ceAllowSort;
        private XtraLayout.LayoutControlItem lciAllowSort;
    }
}
