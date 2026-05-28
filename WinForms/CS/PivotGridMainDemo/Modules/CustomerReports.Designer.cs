namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class CustomerReports {
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.fieldOrderYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOrderQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.rgReport = new DevExpress.XtraEditors.RadioGroup();
            this.panelControl1layoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.cbeQuarter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbeYear = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.rgReportitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbeYearItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbeQuarteritem = new DevExpress.XtraLayout.LayoutControlItem();
            this.dsReports1 = new DevExpress.XtraPivotGrid.Demos.dsReports();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldCompanyName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.mainPanel = new DevExpress.XtraEditors.PanelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.rgReport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1layoutControl1ConvertedLayout)).BeginInit();
            this.panelControl1layoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeQuarter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgReportitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeYearItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeQuarteritem)).BeginInit();
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
            // fieldOrderYear
            // 
            this.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderYear.AreaIndex = 0;
            this.fieldOrderYear.Caption = "Order Year";
            dataSourceColumnBinding1.ColumnName = "OrderDate";
            dataSourceColumnBinding1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldOrderYear.DataBinding = dataSourceColumnBinding1;
            this.fieldOrderYear.Name = "fieldOrderYear";
            this.fieldOrderYear.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
            this.fieldOrderYear.UnboundFieldName = "fieldOrderYear";
            // 
            // fieldOrderQuarter
            // 
            this.fieldOrderQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldOrderQuarter.AreaIndex = 1;
            this.fieldOrderQuarter.Caption = "Order Quarter";
            dataSourceColumnBinding2.ColumnName = "OrderDate";
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.fieldOrderQuarter.DataBinding = dataSourceColumnBinding2;
            this.fieldOrderQuarter.Name = "fieldOrderQuarter";
            this.fieldOrderQuarter.UnboundFieldName = "fieldOrderQuarter";
            this.fieldOrderQuarter.ValueFormat.FormatString = "Qtr {0}";
            this.fieldOrderQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
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
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Customers"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Products (filtering)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Top 2 Products"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Top 10 Customers")});
            this.rgReport.Size = new System.Drawing.Size(175, 104);
            this.rgReport.StyleController = this.panelControl1layoutControl1ConvertedLayout;
            this.rgReport.TabIndex = 0;
            this.rgReport.SelectedIndexChanged += new System.EventHandler(this.rgReport_SelectedIndexChanged);
            // 
            // panelControl1layoutControl1ConvertedLayout
            // 
            this.panelControl1layoutControl1ConvertedLayout.AllowCustomization = false;
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.cbeQuarter);
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.cbeYear);
            this.panelControl1layoutControl1ConvertedLayout.Controls.Add(this.rgReport);
            this.panelControl1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1layoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.panelControl1layoutControl1ConvertedLayout.Name = "panelControl1layoutControl1ConvertedLayout";
            this.panelControl1layoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(152, 224, 712, 821);
            this.panelControl1layoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.panelControl1layoutControl1ConvertedLayout.Size = new System.Drawing.Size(199, 381);
            this.panelControl1layoutControl1ConvertedLayout.TabIndex = 3;
            // 
            // cbeQuarter
            // 
            this.cbeQuarter.EditValue = "";
            this.cbeQuarter.Location = new System.Drawing.Point(59, 126);
            this.cbeQuarter.Name = "cbeQuarter";
            this.cbeQuarter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeQuarter.Properties.Items.AddRange(new object[] {
            "(All)"});
            this.cbeQuarter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeQuarter.Size = new System.Drawing.Size(129, 20);
            this.cbeQuarter.StyleController = this.panelControl1layoutControl1ConvertedLayout;
            this.cbeQuarter.TabIndex = 3;
            this.cbeQuarter.SelectedIndexChanged += new System.EventHandler(this.cbeQuarter_SelectedIndexChanged);
            // 
            // cbeYear
            // 
            this.cbeYear.EditValue = "";
            this.cbeYear.Location = new System.Drawing.Point(59, 102);
            this.cbeYear.Name = "cbeYear";
            this.cbeYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeYear.Size = new System.Drawing.Size(129, 20);
            this.cbeYear.StyleController = this.panelControl1layoutControl1ConvertedLayout;
            this.cbeYear.TabIndex = 1;
            this.cbeYear.SelectedIndexChanged += new System.EventHandler(this.cbeYear_SelectedIndexChanged);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(199, 381);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 157);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(199, 224);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.rgReportitem,
            this.cbeYearItem,
            this.cbeQuarteritem});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(199, 157);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "Customer Reports";
            // 
            // rgReportitem
            // 
            this.rgReportitem.Control = this.rgReport;
            this.rgReportitem.FillControlToClientArea = false;
            this.rgReportitem.Location = new System.Drawing.Point(0, 0);
            this.rgReportitem.Name = "rgReportitem";
            this.rgReportitem.Size = new System.Drawing.Size(181, 72);
            this.rgReportitem.TextLocation = DevExpress.Utils.Locations.Right;
            this.rgReportitem.TextSize = new System.Drawing.Size(0, 0);
            this.rgReportitem.TextVisible = false;
            // 
            // cbeYearItem
            // 
            this.cbeYearItem.Control = this.cbeYear;
            this.cbeYearItem.CustomizationFormText = "Year:";
            this.cbeYearItem.Location = new System.Drawing.Point(0, 72);
            this.cbeYearItem.Name = "cbeYearItem";
            this.cbeYearItem.Size = new System.Drawing.Size(181, 24);
            this.cbeYearItem.Text = "Year:";
            this.cbeYearItem.TextSize = new System.Drawing.Size(45, 13);
            // 
            // cbeQuarteritem
            // 
            this.cbeQuarteritem.Control = this.cbeQuarter;
            this.cbeQuarteritem.Location = new System.Drawing.Point(0, 96);
            this.cbeQuarteritem.Name = "cbeQuarteritem";
            this.cbeQuarteritem.Size = new System.Drawing.Size(181, 24);
            this.cbeQuarteritem.Text = "Quarter: ";
            this.cbeQuarteritem.TextLocation = DevExpress.Utils.Locations.Left;
            this.cbeQuarteritem.TextSize = new System.Drawing.Size(45, 13);
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
            this.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pivotGridControl1.DataSource = this.dsReports1.CustomerReports;
            this.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCompanyName,
            this.fieldProductName,
            this.fieldProductAmount,
            this.fieldOrderYear,
            this.fieldOrderQuarter});
            pivotGridGroup1.Fields.Add(this.fieldOrderYear);
            pivotGridGroup1.Fields.Add(this.fieldOrderQuarter);
            this.pivotGridControl1.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(502, 408);
            this.pivotGridControl1.TabIndex = 3;
            // 
            // fieldCompanyName
            // 
            this.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCompanyName.AreaIndex = 0;
            this.fieldCompanyName.Caption = "Customer";
            dataSourceColumnBinding3.ColumnName = "CompanyName";
            this.fieldCompanyName.DataBinding = dataSourceColumnBinding3;
            this.fieldCompanyName.Name = "fieldCompanyName";
            this.fieldCompanyName.Width = 150;
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product Name";
            dataSourceColumnBinding4.ColumnName = "ProductName";
            this.fieldProductName.DataBinding = dataSourceColumnBinding4;
            this.fieldProductName.Name = "fieldProductName";
            this.fieldProductName.Width = 186;
            // 
            // fieldProductAmount
            // 
            this.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductAmount.AreaIndex = 0;
            this.fieldProductAmount.Caption = "Product Amount";
            this.fieldProductAmount.CellFormat.FormatString = "c";
            this.fieldProductAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            dataSourceColumnBinding5.ColumnName = "ProductAmount";
            this.fieldProductAmount.DataBinding = dataSourceColumnBinding5;
            this.fieldProductAmount.Name = "fieldProductAmount";
            this.fieldProductAmount.Width = 130;
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.mainPanel.Controls.Add(this.pivotGridControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(502, 408);
            this.mainPanel.TabIndex = 11;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(502, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(200, 408);
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
            this.tabPane1.RegularSize = new System.Drawing.Size(199, 408);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(199, 408);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.panelControl1layoutControl1ConvertedLayout);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(199, 381);
            // 
            // CustomerReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidePanel1);
            this.Name = "CustomerReports";
            this.Size = new System.Drawing.Size(702, 408);
            this.Load += new System.EventHandler(this.CustomerReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgReport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1layoutControl1ConvertedLayout)).EndInit();
            this.panelControl1layoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeQuarter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgReportitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeYearItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeQuarteritem)).EndInit();
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
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCompanyName;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductAmount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOrderQuarter;
        private DevExpress.XtraEditors.ComboBoxEdit cbeYear;
        private DevExpress.XtraEditors.ComboBoxEdit cbeQuarter;
		private System.ComponentModel.IContainer components = null;
		private DevExpress.XtraEditors.PanelControl mainPanel;
		private DevExpress.XtraEditors.RadioGroup rgReport;
        private XtraLayout.LayoutControl panelControl1layoutControl1ConvertedLayout;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem rgReportitem;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlItem cbeYearItem;
        private XtraLayout.LayoutControlItem cbeQuarteritem;
    }
}
