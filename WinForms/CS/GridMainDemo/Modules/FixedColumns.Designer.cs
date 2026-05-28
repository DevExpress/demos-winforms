namespace DevExpress.XtraGrid.Demos {
    partial class FixedColumns {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixedColumns));
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.numFixedLineWidth1 = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbMiddleColumns = new DevExpress.XtraEditors.SimpleButton();
            this.icbFixedColumnHighlightMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.icbFixedStyle = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.icbColumn = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFixedLineWidth = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedLineWidth1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbFixedColumnHighlightMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbFixedStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbColumn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFixedLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl2
            // 
            resources.ApplyResources(this.gridControl2, "gridControl2");
            this.gridControl2.MainView = this.gridView1;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2});
            this.gridControl2.ShowOnlyPredefinedDetails = true;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID,
            this.colCompanyName,
            this.colContactName,
            this.colContactTitle,
            this.colAddress,
            this.colCity,
            this.colRegion,
            this.colPostalCode,
            this.colCountry,
            this.colPhone,
            this.colFax});
            this.gridView1.GridControl = this.gridControl2;
            this.gridView1.GroupCount = 1;
            this.gridView1.HorzScrollStep = 30;
            this.gridView1.Images = this.svgImageCollection1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.FixedColumnHighlightMode = DevExpress.XtraGrid.Views.Grid.GridFixedColumnHighlightMode.Line;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colContactTitle, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            // 
            // colCustomerID
            // 
            resources.ApplyResources(this.colCustomerID, "colCustomerID");
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.OptionsFilter.AllowFilter = false;
            // 
            // colCompanyName
            // 
            resources.ApplyResources(this.colCompanyName, "colCompanyName");
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.ImageOptions.ImageIndex = ((int)(resources.GetObject("colCompanyName.ImageOptions.ImageIndex")));
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colCompanyName.Summary"))))});
            // 
            // colContactName
            // 
            resources.ApplyResources(this.colContactName, "colContactName");
            this.colContactName.FieldName = "ContactName";
            this.colContactName.ImageOptions.ImageIndex = ((int)(resources.GetObject("colContactName.ImageOptions.ImageIndex")));
            this.colContactName.Name = "colContactName";
            // 
            // colContactTitle
            // 
            resources.ApplyResources(this.colContactTitle, "colContactTitle");
            this.colContactTitle.FieldName = "ContactTitle";
            this.colContactTitle.Name = "colContactTitle";
            // 
            // colAddress
            // 
            resources.ApplyResources(this.colAddress, "colAddress");
            this.colAddress.FieldName = "Address";
            this.colAddress.ImageOptions.ImageIndex = ((int)(resources.GetObject("colAddress.ImageOptions.ImageIndex")));
            this.colAddress.Name = "colAddress";
            // 
            // colCity
            // 
            resources.ApplyResources(this.colCity, "colCity");
            this.colCity.FieldName = "City";
            this.colCity.ImageOptions.ImageIndex = ((int)(resources.GetObject("colCity.ImageOptions.ImageIndex")));
            this.colCity.Name = "colCity";
            // 
            // colRegion
            // 
            resources.ApplyResources(this.colRegion, "colRegion");
            this.colRegion.ColumnEdit = this.repositoryItemComboBox1;
            this.colRegion.FieldName = "Region";
            this.colRegion.ImageOptions.ImageIndex = ((int)(resources.GetObject("colRegion.ImageOptions.ImageIndex")));
            this.colRegion.Name = "colRegion";
            // 
            // repositoryItemComboBox1
            // 
            resources.ApplyResources(this.repositoryItemComboBox1, "repositoryItemComboBox1");
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemComboBox1.Buttons"))))});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            resources.GetString("repositoryItemComboBox1.Items"),
            resources.GetString("repositoryItemComboBox1.Items1"),
            resources.GetString("repositoryItemComboBox1.Items2"),
            resources.GetString("repositoryItemComboBox1.Items3"),
            resources.GetString("repositoryItemComboBox1.Items4"),
            resources.GetString("repositoryItemComboBox1.Items5"),
            resources.GetString("repositoryItemComboBox1.Items6"),
            resources.GetString("repositoryItemComboBox1.Items7"),
            resources.GetString("repositoryItemComboBox1.Items8"),
            resources.GetString("repositoryItemComboBox1.Items9"),
            resources.GetString("repositoryItemComboBox1.Items10"),
            resources.GetString("repositoryItemComboBox1.Items11"),
            resources.GetString("repositoryItemComboBox1.Items12"),
            resources.GetString("repositoryItemComboBox1.Items13"),
            resources.GetString("repositoryItemComboBox1.Items14"),
            resources.GetString("repositoryItemComboBox1.Items15"),
            resources.GetString("repositoryItemComboBox1.Items16"),
            resources.GetString("repositoryItemComboBox1.Items17")});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colPostalCode
            // 
            resources.ApplyResources(this.colPostalCode, "colPostalCode");
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.ImageOptions.ImageIndex = ((int)(resources.GetObject("colPostalCode.ImageOptions.ImageIndex")));
            this.colPostalCode.Name = "colPostalCode";
            // 
            // colCountry
            // 
            resources.ApplyResources(this.colCountry, "colCountry");
            this.colCountry.ColumnEdit = this.repositoryItemComboBox2;
            this.colCountry.FieldName = "Country";
            this.colCountry.ImageOptions.ImageIndex = ((int)(resources.GetObject("colCountry.ImageOptions.ImageIndex")));
            this.colCountry.Name = "colCountry";
            // 
            // repositoryItemComboBox2
            // 
            resources.ApplyResources(this.repositoryItemComboBox2, "repositoryItemComboBox2");
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemComboBox2.Buttons"))))});
            this.repositoryItemComboBox2.Items.AddRange(new object[] {
            resources.GetString("repositoryItemComboBox2.Items"),
            resources.GetString("repositoryItemComboBox2.Items1"),
            resources.GetString("repositoryItemComboBox2.Items2"),
            resources.GetString("repositoryItemComboBox2.Items3"),
            resources.GetString("repositoryItemComboBox2.Items4"),
            resources.GetString("repositoryItemComboBox2.Items5"),
            resources.GetString("repositoryItemComboBox2.Items6"),
            resources.GetString("repositoryItemComboBox2.Items7"),
            resources.GetString("repositoryItemComboBox2.Items8"),
            resources.GetString("repositoryItemComboBox2.Items9"),
            resources.GetString("repositoryItemComboBox2.Items10"),
            resources.GetString("repositoryItemComboBox2.Items11"),
            resources.GetString("repositoryItemComboBox2.Items12"),
            resources.GetString("repositoryItemComboBox2.Items13"),
            resources.GetString("repositoryItemComboBox2.Items14"),
            resources.GetString("repositoryItemComboBox2.Items15"),
            resources.GetString("repositoryItemComboBox2.Items16"),
            resources.GetString("repositoryItemComboBox2.Items17"),
            resources.GetString("repositoryItemComboBox2.Items18"),
            resources.GetString("repositoryItemComboBox2.Items19"),
            resources.GetString("repositoryItemComboBox2.Items20")});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // colPhone
            // 
            resources.ApplyResources(this.colPhone, "colPhone");
            this.colPhone.FieldName = "Phone";
            this.colPhone.ImageOptions.ImageIndex = ((int)(resources.GetObject("colPhone.ImageOptions.ImageIndex")));
            this.colPhone.Name = "colPhone";
            // 
            // colFax
            // 
            resources.ApplyResources(this.colFax, "colFax");
            this.colFax.FieldName = "Fax";
            this.colFax.ImageOptions.ImageIndex = ((int)(resources.GetObject("colFax.ImageOptions.ImageIndex")));
            this.colFax.Name = "colFax";
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("ContactName", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.ContactName"))));
            this.svgImageCollection1.Add("Home", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Home"))));
            this.svgImageCollection1.Add("Company", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Company"))));
            this.svgImageCollection1.Add("NotFixed", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.NotFixed"))));
            this.svgImageCollection1.Add("FixedLeft", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.FixedLeft"))));
            this.svgImageCollection1.Add("FixedRight", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.FixedRight"))));
            this.svgImageCollection1.Add("City", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.City"))));
            this.svgImageCollection1.Add("Country", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Country"))));
            this.svgImageCollection1.Add("Fax", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Fax"))));
            this.svgImageCollection1.Add("PostalCode", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.PostalCode"))));
            this.svgImageCollection1.Add("Region", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Region"))));
            this.svgImageCollection1.Add("glyph_phone", "image://svgimages/outlook inspired/glyph_phone.svg");
            // 
            // numFixedLineWidth1
            // 
            resources.ApplyResources(this.numFixedLineWidth1, "numFixedLineWidth1");
            this.numFixedLineWidth1.Name = "numFixedLineWidth1";
            this.numFixedLineWidth1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.numFixedLineWidth1.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.numFixedLineWidth1.Properties.IsFloatValue = false;
            this.numFixedLineWidth1.Properties.Mask.EditMask = resources.GetString("numFixedLineWidth1.Properties.Mask.EditMask");
            this.numFixedLineWidth1.Properties.MaxValue = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numFixedLineWidth1.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFixedLineWidth1.StyleController = this.layoutControl1;
            this.numFixedLineWidth1.EditValueChanged += new System.EventHandler(this.numFixedLineWidth1_ValueChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.sbMiddleColumns);
            this.layoutControl1.Controls.Add(this.icbFixedColumnHighlightMode);
            this.layoutControl1.Controls.Add(this.icbFixedStyle);
            this.layoutControl1.Controls.Add(this.numFixedLineWidth1);
            this.layoutControl1.Controls.Add(this.icbColumn);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1152, 640, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // sbMiddleColumns
            // 
            resources.ApplyResources(this.sbMiddleColumns, "sbMiddleColumns");
            this.sbMiddleColumns.Name = "sbMiddleColumns";
            this.sbMiddleColumns.StyleController = this.layoutControl1;
            this.sbMiddleColumns.Click += new System.EventHandler(this.sbMiddleColumns_Click);
            // 
            // icbFixedColumnHighlightMode
            // 
            resources.ApplyResources(this.icbFixedColumnHighlightMode, "icbFixedColumnHighlightMode");
            this.icbFixedColumnHighlightMode.Name = "icbFixedColumnHighlightMode";
            this.icbFixedColumnHighlightMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("icbFixedColumnHighlightMode.Properties.Buttons"))))});
            this.icbFixedColumnHighlightMode.StyleController = this.layoutControl1;
            this.icbFixedColumnHighlightMode.SelectedIndexChanged += new System.EventHandler(this.icbFixedColumnHighlightMode_SelectedIndexChanged);
            // 
            // icbFixedStyle
            // 
            resources.ApplyResources(this.icbFixedStyle, "icbFixedStyle");
            this.icbFixedStyle.Name = "icbFixedStyle";
            this.icbFixedStyle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("icbFixedStyle.Properties.Buttons"))))});
            this.icbFixedStyle.StyleController = this.layoutControl1;
            this.icbFixedStyle.SelectedIndexChanged += new System.EventHandler(this.icbFixedStyle_SelectedIndexChanged);
            // 
            // icbColumn
            // 
            resources.ApplyResources(this.icbColumn, "icbColumn");
            this.icbColumn.Name = "icbColumn";
            this.icbColumn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("icbColumn.Properties.Buttons"))))});
            this.icbColumn.Properties.DropDownRows = 15;
            this.icbColumn.StyleController = this.layoutControl1;
            this.icbColumn.SelectedIndexChanged += new System.EventHandler(this.icbColumn_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(249, 397);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 255);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(249, 142);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.lciFixedLineWidth,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.emptySpaceItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(249, 255);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            resources.ApplyResources(this.layoutControlGroup2, "layoutControlGroup2");
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.icbColumn;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(229, 40);
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(137, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.icbFixedStyle;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(229, 40);
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(137, 13);
            // 
            // lciFixedLineWidth
            // 
            this.lciFixedLineWidth.Control = this.numFixedLineWidth1;
            this.lciFixedLineWidth.Location = new System.Drawing.Point(0, 173);
            this.lciFixedLineWidth.Name = "lciFixedLineWidth";
            this.lciFixedLineWidth.Size = new System.Drawing.Size(229, 40);
            resources.ApplyResources(this.lciFixedLineWidth, "lciFixedLineWidth");
            this.lciFixedLineWidth.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciFixedLineWidth.TextSize = new System.Drawing.Size(137, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.icbFixedColumnHighlightMode;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 133);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(229, 40);
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(137, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sbMiddleColumns;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 107);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(229, 26);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 80);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 27);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(229, 27);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.tabPane1);
            resources.ApplyResources(this.sidePanel1, "sidePanel1");
            this.sidePanel1.Name = "sidePanel1";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            resources.ApplyResources(this.tabPane1, "tabPane1");
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1});
            this.tabPane1.RegularSize = new System.Drawing.Size(249, 430);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            // 
            // tabNavigationPage1
            // 
            resources.ApplyResources(this.tabNavigationPage1, "tabNavigationPage1");
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            // 
            // FixedColumns
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.sidePanel1);
            this.Name = "FixedColumns";
            this.Load += new System.EventHandler(this.FixedColumns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedLineWidth1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbFixedColumnHighlightMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbFixedStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icbColumn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFixedLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colRegion;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private XtraEditors.SpinEdit numFixedLineWidth1;
        private XtraEditors.ImageComboBoxEdit icbFixedStyle;
        private XtraEditors.ImageComboBoxEdit icbColumn;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem lciFixedLineWidth;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private Utils.SvgImageCollection svgImageCollection1;
        private XtraEditors.ImageComboBoxEdit icbFixedColumnHighlightMode;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraEditors.SimpleButton sbMiddleColumns;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
