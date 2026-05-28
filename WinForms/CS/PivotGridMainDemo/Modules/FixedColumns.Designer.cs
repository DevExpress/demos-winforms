namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class FixedColumns {
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
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.ExpressionDataBinding expressionDataBinding1 = new DevExpress.XtraPivotGrid.ExpressionDataBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.ExpressionDataBinding expressionDataBinding2 = new DevExpress.XtraPivotGrid.ExpressionDataBinding();
            DevExpress.XtraPivotGrid.ExpressionDataBinding expressionDataBinding3 = new DevExpress.XtraPivotGrid.ExpressionDataBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.ExpressionDataBinding expressionDataBinding4 = new DevExpress.XtraPivotGrid.ExpressionDataBinding();
            DevExpress.XtraPivotGrid.ExpressionDataBinding expressionDataBinding5 = new DevExpress.XtraPivotGrid.ExpressionDataBinding();
            this.fieldExtendedPrice = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategory = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldMin = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProduct = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMax = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMedian = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fcFieldMin = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fcFieldMax = new DevExpress.XtraPivotGrid.PivotGridField();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.rgPinColLocation = new DevExpress.XtraEditors.RadioGroup();
            this.ceShowColumns = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgPinColLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowColumns.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 0;
            this.fieldExtendedPrice.Caption = "Extended Price";
            this.fieldExtendedPrice.CellFormat.FormatString = "C";
            this.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            dataSourceColumnBinding1.ColumnName = "Extended Price";
            this.fieldExtendedPrice.DataBinding = dataSourceColumnBinding1;
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fieldYear
            // 
            this.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldYear.AreaIndex = 0;
            this.fieldYear.Caption = "Year";
            dataSourceColumnBinding2.ColumnName = "OrderDate";
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.fieldYear.DataBinding = dataSourceColumnBinding2;
            this.fieldYear.Name = "fieldYear";
            // 
            // fieldCategory
            // 
            this.fieldCategory.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategory.AreaIndex = 0;
            this.fieldCategory.Caption = "Category";
            dataSourceColumnBinding3.ColumnName = "CategoryName";
            this.fieldCategory.DataBinding = dataSourceColumnBinding3;
            this.fieldCategory.Name = "fieldCategory";
            this.fieldCategory.Width = 123;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldYear,
            this.fieldExtendedPrice,
            this.fieldCategory,
            this.fieldMin,
            this.fieldMonth,
            this.fieldProduct,
            this.fieldMax,
            this.fieldMedian,
            this.fieldQuantity,
            this.fcFieldMin,
            this.fcFieldMax});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsCustomization.AllowFilter = false;
            this.pivotGridControl1.OptionsCustomization.AllowFilterBySummary = false;
            this.pivotGridControl1.OptionsCustomization.FilterPanelVisible = DevExpress.XtraPivotGrid.FilterPanelVisible.Never;
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.OptionsMenu.EnableFormatRulesMenu = true;
            this.pivotGridControl1.OptionsMenu.ShowDateTimeGroupIntervalItems = DevExpress.XtraPivotGrid.DateTimeGroupIntervals.None;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(584, 432);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // fieldMin
            // 
            this.fieldMin.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldMin.Appearance.ValueGrandTotal.Options.UseTextOptions = true;
            this.fieldMin.Appearance.ValueGrandTotal.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.fieldMin.Appearance.ValueGrandTotal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.fieldMin.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldMin.AreaIndex = 1;
            this.fieldMin.Caption = "Min Month Sales";
            this.fieldMin.CellFormat.FormatString = "C";
            this.fieldMin.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            expressionDataBinding1.Expression = "Min(Aggr(Sum([fieldExtendedPrice]),[CategoryName],[ProductName],[fieldYear],[fiel" +
    "dMonth]))";
            this.fieldMin.DataBinding = expressionDataBinding1;
            this.fieldMin.Name = "fieldMin";
            this.fieldMin.Options.ShowTotals = false;
            this.fieldMin.Options.ShowValues = false;
            this.fieldMin.UnboundFieldName = "fieldMin";
            this.fieldMin.Width = 60;
            // 
            // fieldMonth
            // 
            this.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldMonth.AreaIndex = 1;
            this.fieldMonth.Caption = "Month";
            dataSourceColumnBinding4.ColumnName = "OrderDate";
            dataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.fieldMonth.DataBinding = dataSourceColumnBinding4;
            this.fieldMonth.Name = "fieldMonth";
            // 
            // fieldProduct
            // 
            this.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProduct.AreaIndex = 1;
            this.fieldProduct.Caption = "Product";
            dataSourceColumnBinding5.ColumnName = "ProductName";
            this.fieldProduct.DataBinding = dataSourceColumnBinding5;
            this.fieldProduct.Name = "fieldProduct";
            // 
            // fieldMax
            // 
            this.fieldMax.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldMax.Appearance.ValueGrandTotal.Options.UseTextOptions = true;
            this.fieldMax.Appearance.ValueGrandTotal.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.fieldMax.Appearance.ValueGrandTotal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.fieldMax.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldMax.AreaIndex = 2;
            this.fieldMax.Caption = "Max Month Sales";
            this.fieldMax.CellFormat.FormatString = "C";
            this.fieldMax.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            expressionDataBinding2.Expression = "Max(Aggr(Sum([fieldExtendedPrice]),[CategoryName],[ProductName],[fieldYear],[fiel" +
    "dMonth]))";
            this.fieldMax.DataBinding = expressionDataBinding2;
            this.fieldMax.Name = "fieldMax";
            this.fieldMax.Options.ShowTotals = false;
            this.fieldMax.Options.ShowValues = false;
            this.fieldMax.UnboundFieldName = "fieldMax";
            this.fieldMax.Width = 60;
            // 
            // fieldMedian
            // 
            this.fieldMedian.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldMedian.Appearance.ValueGrandTotal.Options.UseTextOptions = true;
            this.fieldMedian.Appearance.ValueGrandTotal.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.fieldMedian.Appearance.ValueGrandTotal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.fieldMedian.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldMedian.AreaIndex = 3;
            this.fieldMedian.Caption = "Median Month Sales";
            this.fieldMedian.CellFormat.FormatString = "C";
            this.fieldMedian.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            expressionDataBinding3.Expression = "Median(Aggr(Sum([fieldExtendedPrice]),[CategoryName],[ProductName],[fieldYear],[f" +
    "ieldMonth]))";
            this.fieldMedian.DataBinding = expressionDataBinding3;
            this.fieldMedian.Name = "fieldMedian";
            this.fieldMedian.Options.ShowTotals = false;
            this.fieldMedian.Options.ShowValues = false;
            this.fieldMedian.UnboundFieldName = "fieldMedian";
            this.fieldMedian.Width = 60;
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 4;
            dataSourceColumnBinding6.ColumnName = "Quantity";
            this.fieldQuantity.DataBinding = dataSourceColumnBinding6;
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // fcFieldMin
            // 
            this.fcFieldMin.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fcFieldMin.AreaIndex = 5;
            this.fcFieldMin.CalculateHiddenSummaries = true;
            this.fcFieldMin.Caption = "Min Sales by Products";
            this.fcFieldMin.CellFormat.FormatString = "C";
            this.fcFieldMin.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            expressionDataBinding4.Expression = "Min(Aggr([fieldMin], [fieldCategory], [fieldProduct]))";
            this.fcFieldMin.DataBinding = expressionDataBinding4;
            this.fcFieldMin.Name = "fcFieldMin";
            this.fcFieldMin.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            this.fcFieldMin.Options.AllowDragInCustomizationForm = DevExpress.Utils.DefaultBoolean.False;
            this.fcFieldMin.UnboundFieldName = "fcFieldMin";
            this.fcFieldMin.Visible = false;
            // 
            // fcFieldMax
            // 
            this.fcFieldMax.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fcFieldMax.AreaIndex = 4;
            this.fcFieldMax.CalculateHiddenSummaries = true;
            this.fcFieldMax.Caption = "Max Sales by Products";
            this.fcFieldMax.CellFormat.FormatString = "C";
            this.fcFieldMax.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            expressionDataBinding5.Expression = "Max(Aggr([fieldMax], [fieldCategory], [fieldProduct]))";
            this.fcFieldMax.DataBinding = expressionDataBinding5;
            this.fcFieldMax.Name = "fcFieldMax";
            this.fcFieldMax.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.False;
            this.fcFieldMax.Options.AllowDragInCustomizationForm = DevExpress.Utils.DefaultBoolean.False;
            this.fcFieldMax.UnboundFieldName = "fcFieldMax";
            this.fcFieldMax.Visible = false;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(584, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(200, 432);
            this.sidePanel1.TabIndex = 1;
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
            this.tabPane1.RegularSize = new System.Drawing.Size(199, 432);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(199, 432);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Options";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(199, 403);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.rgPinColLocation);
            this.layoutControl1.Controls.Add(this.ceShowColumns);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(553, 465, 883, 561);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(199, 403);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // rgPinColLocation
            // 
            this.rgPinColLocation.AutoSizeInLayoutControl = true;
            this.rgPinColLocation.Location = new System.Drawing.Point(13, 83);
            this.rgPinColLocation.Name = "rgPinColLocation";
            this.rgPinColLocation.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgPinColLocation.Properties.Appearance.Options.UseBackColor = true;
            this.rgPinColLocation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgPinColLocation.Properties.Columns = 1;
            this.rgPinColLocation.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Left"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Right")});
            this.rgPinColLocation.Size = new System.Drawing.Size(173, 56);
            this.rgPinColLocation.StyleController = this.layoutControl1;
            this.rgPinColLocation.TabIndex = 4;
            this.rgPinColLocation.SelectedIndexChanged += new System.EventHandler(this.RgPinColLocation_SelectedIndexChanged);
            // 
            // ceShowColumns
            // 
            this.ceShowColumns.AutoSizeInLayoutControl = true;
            this.ceShowColumns.EditValue = true;
            this.ceShowColumns.Location = new System.Drawing.Point(13, 35);
            this.ceShowColumns.Name = "ceShowColumns";
            this.ceShowColumns.Properties.Caption = "Show in scrollable area";
            this.ceShowColumns.Size = new System.Drawing.Size(132, 20);
            this.ceShowColumns.StyleController = this.layoutControl1;
            this.ceShowColumns.TabIndex = 5;
            this.ceShowColumns.CheckedChanged += new System.EventHandler(this.CeShowColumns_CheckedChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(199, 403);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 152);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(199, 251);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlGroup1.Size = new System.Drawing.Size(199, 152);
            this.layoutControlGroup1.Text = "Pinned Columns";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.rgPinColLocation;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2);
            this.layoutControlItem1.Size = new System.Drawing.Size(177, 84);
            this.layoutControlItem1.Text = "Location";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(40, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ceShowColumns;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(177, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // FixedColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "FixedColumns";
            this.Load += new System.EventHandler(this.FixedColumns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgPinColLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceShowColumns.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PivotGridControl pivotGridControl1;
        private PivotGridField fieldYear;
        private PivotGridField fieldCategory;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraEditors.RadioGroup rgPinColLocation;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraEditors.CheckEdit ceShowColumns;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private PivotGridField fieldMin;
        private PivotGridField fieldMonth;
        private PivotGridField fieldExtendedPrice;
        private PivotGridField fieldProduct;
        private PivotGridField fieldMax;
        private PivotGridField fieldMedian;
        private PivotGridField fieldQuantity;
        private PivotGridField fcFieldMin;
        private PivotGridField fcFieldMax;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
    }
}
