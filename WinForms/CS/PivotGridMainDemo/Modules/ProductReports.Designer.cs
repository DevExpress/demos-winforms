namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class ProductReports {
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            this.rgReport = new DevExpress.XtraEditors.RadioGroup();
            this.controlPanellayoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.cbeDate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ceDrillDown = new DevExpress.XtraEditors.CheckEdit();
            this.ceCategories = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dsReports1 = new DevExpress.XtraPivotGrid.Demos.dsReports();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCategoryName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShippedYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductSales = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShippedQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldShippedMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAverageSale = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMinimumSale = new DevExpress.XtraPivotGrid.PivotGridField();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.rgReport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanellayoutControl1ConvertedLayout)).BeginInit();
            this.controlPanellayoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceDrillDown.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCategories.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rgReport
            // 
            this.rgReport.AutoSizeInLayoutControl = true;
            this.rgReport.Location = new System.Drawing.Point(11, 30);
            this.rgReport.Name = "rgReport";
            this.rgReport.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgReport.Properties.Appearance.Options.UseBackColor = true;
            this.rgReport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgReport.Properties.Columns = 1;
            this.rgReport.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Category Sales"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Product Sales"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Interval Grouping"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Multiple Subtotals"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Average Sales"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(5, "Top 3 Products")});
            this.rgReport.Size = new System.Drawing.Size(177, 98);
            this.rgReport.StyleController = this.controlPanellayoutControl1ConvertedLayout;
            this.rgReport.TabIndex = 0;
            this.rgReport.SelectedIndexChanged += new System.EventHandler(this.rgReport_SelectedIndexChanged);
            // 
            // controlPanellayoutControl1ConvertedLayout
            // 
            this.controlPanellayoutControl1ConvertedLayout.AllowCustomization = false;
            this.controlPanellayoutControl1ConvertedLayout.Controls.Add(this.rgReport);
            this.controlPanellayoutControl1ConvertedLayout.Controls.Add(this.cbeDate);
            this.controlPanellayoutControl1ConvertedLayout.Controls.Add(this.ceDrillDown);
            this.controlPanellayoutControl1ConvertedLayout.Controls.Add(this.ceCategories);
            this.controlPanellayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanellayoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.controlPanellayoutControl1ConvertedLayout.Name = "controlPanellayoutControl1ConvertedLayout";
            this.controlPanellayoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(217, 286, 781, 674);
            this.controlPanellayoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.controlPanellayoutControl1ConvertedLayout.Size = new System.Drawing.Size(199, 398);
            this.controlPanellayoutControl1ConvertedLayout.TabIndex = 15;
            // 
            // cbeDate
            // 
            this.cbeDate.EditValue = "";
            this.cbeDate.Location = new System.Drawing.Point(11, 171);
            this.cbeDate.Name = "cbeDate";
            this.cbeDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeDate.Properties.Items.AddRange(new object[] {
            "by Years",
            "by Quarters",
            "by Months",
            "by Years, Quarters, Months"});
            this.cbeDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeDate.Size = new System.Drawing.Size(177, 20);
            this.cbeDate.StyleController = this.controlPanellayoutControl1ConvertedLayout;
            this.cbeDate.TabIndex = 3;
            this.cbeDate.SelectedIndexChanged += new System.EventHandler(this.cbeDate_SelectedIndexChanged);
            // 
            // ceDrillDown
            // 
            this.ceDrillDown.AutoSizeInLayoutControl = true;
            this.ceDrillDown.EditValue = true;
            this.ceDrillDown.Location = new System.Drawing.Point(11, 232);
            this.ceDrillDown.MinimumSize = new System.Drawing.Size(0, 26);
            this.ceDrillDown.Name = "ceDrillDown";
            this.ceDrillDown.Properties.Appearance.Options.UseTextOptions = true;
            this.ceDrillDown.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ceDrillDown.Properties.Caption = "Show on Cell Double Click";
            this.ceDrillDown.Size = new System.Drawing.Size(143, 26);
            this.ceDrillDown.StyleController = this.controlPanellayoutControl1ConvertedLayout;
            this.ceDrillDown.TabIndex = 0;
            // 
            // ceCategories
            // 
            this.ceCategories.Location = new System.Drawing.Point(11, 132);
            this.ceCategories.Name = "ceCategories";
            this.ceCategories.Properties.Caption = "Show Categories";
            this.ceCategories.Size = new System.Drawing.Size(177, 19);
            this.ceCategories.StyleController = this.controlPanellayoutControl1ConvertedLayout;
            this.ceCategories.TabIndex = 0;
            this.ceCategories.CheckedChanged += new System.EventHandler(this.ceCategories_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup3,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(199, 398);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 269);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(199, 129);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(199, 202);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup3.Text = "Product Reports";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rgReport;
            this.layoutControlItem1.CustomizationFormText = "RadioGroupItem";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(181, 102);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceCategories;
            this.layoutControlItem3.CustomizationFormText = "ShowCategories";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 102);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(181, 23);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbeDate;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 125);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(181, 40);
            this.layoutControlItem4.Text = "Grouping Layout:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "Drill Down Form";
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 202);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(199, 67);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Drill Down Form";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ceDrillDown;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(181, 30);
            this.layoutControlItem2.Text = "Drill Down Form";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // dsReports1
            // 
            this.dsReports1.DataSetName = "dsReports";
            this.dsReports1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.ActiveFilterString = "";
            this.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pivotGridControl1.DataSource = this.dsReports1.ProductReports;
            this.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCategoryName,
            this.fieldProductName,
            this.fieldShippedYear,
            this.fieldProductSales,
            this.fieldShippedQuarter,
            this.fieldShippedMonth,
            this.fieldAverageSale,
            this.fieldMinimumSale});
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup1.ShowNewValues = true;
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl1.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(566, 425);
            this.pivotGridControl1.TabIndex = 3;
            this.pivotGridControl1.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGridControl1_FieldValueDisplayText);
            this.pivotGridControl1.FieldValueImageIndex += new DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(this.pivotGridControl1_FieldValueImageIndex);
            this.pivotGridControl1.CellDoubleClick += new DevExpress.XtraPivotGrid.PivotCellEventHandler(this.pivotGridControl1_CellDoubleClick);
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.DataBinding = new DataSourceColumnBinding("CategoryName");
            this.fieldCategoryName.Name = "fieldCategoryName";
            this.fieldCategoryName.Width = 125;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.DataBinding = new DataSourceColumnBinding("ProductName");
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Width = 171;
            // 
            // fieldShippedYear
            // 
            this.fieldShippedYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldShippedYear.AreaIndex = 0;
            this.fieldShippedYear.Caption = "Shipped Year";
            this.fieldShippedYear.DataBinding = new DataSourceColumnBinding("ShippedDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear);
            this.fieldShippedYear.Name = "fieldShippedYear";
            // 
            // fieldProductSales
            // 
            this.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductSales.AreaIndex = 0;
            this.fieldProductSales.Caption = "Product Sales";
            this.fieldProductSales.CellFormat.FormatString = "c";
            this.fieldProductSales.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldProductSales.DataBinding = new DataSourceColumnBinding("ProductSales");
            this.fieldProductSales.Name = "fieldProductSales";
            this.fieldProductSales.Width = 130;
            // 
            // fieldShippedQuarter
            // 
            this.fieldShippedQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldShippedQuarter.AreaIndex = 1;
            this.fieldShippedQuarter.Caption = "Shipped Quarter";
            this.fieldShippedQuarter.DataBinding = new DataSourceColumnBinding("ShippedDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter);
            this.fieldShippedQuarter.Name = "fieldShippedQuarter";            
            this.fieldShippedQuarter.ValueFormat.FormatString = "Qtr {0}";
            this.fieldShippedQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldShippedQuarter.Width = 130;
            // 
            // fieldShippedMonth
            // 
            this.fieldShippedMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldShippedMonth.Caption = "Shipped Month";
            this.fieldShippedMonth.DataBinding = new DataSourceColumnBinding("ShippedDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth);
            this.fieldShippedMonth.Name = "fieldShippedMonth";
            this.fieldShippedMonth.Visible = false;
            this.fieldShippedMonth.Width = 120;
            // 
            // fieldAverageSale
            // 
            this.fieldAverageSale.Caption = "Average Sale";
            this.fieldAverageSale.CellFormat.FormatString = "c";
            this.fieldAverageSale.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldAverageSale.DataBinding = new DataSourceColumnBinding("ProductSales");
            this.fieldAverageSale.Name = "fieldAverageSale";
            this.fieldAverageSale.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average;
            this.fieldAverageSale.Visible = false;
            // 
            // fieldMinimumSale
            // 
            this.fieldMinimumSale.Caption = "Minimum Sale";
            this.fieldMinimumSale.CellFormat.FormatString = "c";
            this.fieldMinimumSale.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldMinimumSale.DataBinding = new DataSourceColumnBinding("ProductSales");
            this.fieldMinimumSale.Name = "fieldMinimumSale";
            this.fieldMinimumSale.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            this.fieldMinimumSale.Visible = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mainPanel.Controls.Add(this.pivotGridControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(566, 425);
            this.mainPanel.TabIndex = 13;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(566, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(200, 425);
            this.sidePanel1.TabIndex = 4;
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
            this.tabPane1.RegularSize = new System.Drawing.Size(199, 425);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(199, 425);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.controlPanellayoutControl1ConvertedLayout);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(199, 398);
            // 
            // ProductReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel1);
            this.Name = "ProductReports";
            this.Size = new System.Drawing.Size(766, 425);
            this.Load += new System.EventHandler(this.ProductReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgReport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlPanellayoutControl1ConvertedLayout)).EndInit();
            this.controlPanellayoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceDrillDown.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceCategories.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
		private DevExpress.XtraPivotGrid.Demos.dsReports dsReports1;
		private DevExpress.XtraEditors.RadioGroup rgReport;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategoryName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShippedQuarter;
        private DevExpress.XtraPivotGrid.PivotGridField fieldShippedYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductSales;
        private DevExpress.XtraEditors.CheckEdit ceCategories;
		private DevExpress.XtraPivotGrid.PivotGridField fieldShippedMonth;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAverageSale;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMinimumSale;
        private DevExpress.XtraEditors.CheckEdit ceDrillDown;
        private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PanelControl mainPanel;
        private XtraLayout.Converter.LayoutConverter layoutConverter1;
        private XtraLayout.LayoutControl controlPanellayoutControl1ConvertedLayout;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraEditors.ComboBoxEdit cbeDate;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
    }
}
