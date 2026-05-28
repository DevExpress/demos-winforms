using DevExpress.Export;

namespace DevExpress.XtraGrid.Demos {
    partial class GridLookUpEditDemo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridLookUpEditDemo));
            DevExpress.Utils.ContextButton contextButton1 = new DevExpress.Utils.ContextButton();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colPhoto1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colNotes1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colDiscontinued = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridLookUpEdit2 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.dsNWindCustomers1 = new DevExpress.XtraGrid.Demos.dsNWindCustomers();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colAddress = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colEmployeeID1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colExtension = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colFirstName1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colHireDate = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colHomePhone = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colLastName1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPostalCode = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colRegion = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colReportsTo = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colTitleOfCourtesy = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tabPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.dsNWindProducts1 = new DevExpress.XtraGrid.Demos.dsNWindProducts();
            this.gridLookUpEdit1 = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityPerUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPhoto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colFirstName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLastName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colNotes = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNWindCustomers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsNWindProducts1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // colPhoto1
            // 
            this.colPhoto1.FieldName = "Photo";
            this.colPhoto1.Name = "colPhoto1";
            resources.ApplyResources(this.colPhoto1, "colPhoto1");
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            resources.ApplyResources(this.colName, "colName");
            // 
            // colNotes1
            // 
            this.colNotes1.FieldName = "Notes";
            this.colNotes1.Name = "colNotes1";
            resources.ApplyResources(this.colNotes1, "colNotes1");
            // 
            // colCategoryID
            // 
            this.colCategoryID.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colCategoryID.ImageOptions.Alignment")));
            this.colCategoryID.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("colCategoryID.ImageOptions.SvgImage")));
            this.colCategoryID.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colCategoryID.OptionsColumn.AllowMove = false;
            this.colCategoryID.OptionsColumn.AllowSize = false;
            this.colCategoryID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCategoryID.OptionsColumn.FixedWidth = true;
            this.colCategoryID.OptionsFilter.AllowFilter = false;
            resources.ApplyResources(this.colCategoryID, "colCategoryID");
            // 
            // repositoryItemImageComboBox1
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox1, "repositoryItemImageComboBox1");
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox1.Buttons"))))});
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items5")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items7"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items8")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items10"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items11")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items12"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items13"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items14")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items15"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items16"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items17")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items18"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items19"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items20")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items21"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items22"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items23"))))});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            // 
            // colDiscontinued
            // 
            resources.ApplyResources(this.colDiscontinued, "colDiscontinued");
            this.colDiscontinued.FieldName = "Discontinued";
            this.colDiscontinued.Name = "colDiscontinued";
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabPage1);
            this.tabPane1.Controls.Add(this.tabPage3);
            this.tabPane1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabPane1, "tabPane1");
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabPage1,
            this.tabPage3,
            this.tabPage2});
            this.tabPane1.SelectedPage = this.tabPage3;
            // 
            // tabPage3
            // 
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Controls.Add(this.groupControl1);
            this.tabPage3.Name = "tabPage3";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.gridLookUpEdit2);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            // 
            // gridLookUpEdit2
            // 
            resources.ApplyResources(this.gridLookUpEdit2, "gridLookUpEdit2");
            this.gridLookUpEdit2.Name = "gridLookUpEdit2";
            this.gridLookUpEdit2.Properties.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.False;
            this.gridLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("gridLookUpEdit2.Properties.Buttons"))))});
            this.gridLookUpEdit2.Properties.DataSource = this.dsNWindCustomers1.Employees;
            this.gridLookUpEdit2.Properties.DisplayMember = "Name";
            this.gridLookUpEdit2.Properties.PopupFormSize = new System.Drawing.Size(500, 0);
            this.gridLookUpEdit2.Properties.PopupView = this.gridLookUpEdit2View;
            this.gridLookUpEdit2.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridLookUpEdit2.Properties.ValueMember = "EmployeeID";
            this.gridLookUpEdit2.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.TileView;
            // 
            // dsNWindCustomers1
            // 
            this.dsNWindCustomers1.DataSetName = "dsNWindCustomers";
            this.dsNWindCustomers1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsNWindCustomers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAddress,
            this.colBirthDate,
            this.colCity,
            this.colCountry,
            this.colEmployeeID1,
            this.colExtension,
            this.colFirstName1,
            this.colHireDate,
            this.colHomePhone,
            this.colLastName1,
            this.colNotes1,
            this.colPhoto1,
            this.colPostalCode,
            this.colRegion,
            this.colReportsTo,
            this.colTitle,
            this.colTitleOfCourtesy,
            this.colName});
            contextButton1.AlignmentOptions.Position = DevExpress.Utils.ContextItemPosition.Far;
            contextButton1.Id = new System.Guid("3c2a68ae-c0c8-45ae-9d32-ed4596b39df3");
            contextButton1.ImageOptionsCollection.ItemNormal.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            contextButton1.ImageOptionsCollection.ItemNormal.SvgImageSize = new System.Drawing.Size(16, 16);
            contextButton1.Name = "contextButton1";
            resources.ApplyResources(contextButton1, "contextButton1");
            contextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Hidden;
            this.gridLookUpEdit2View.ContextButtons.Add(contextButton1);
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsBehavior.AllowSmoothScrolling = true;
            this.gridLookUpEdit2View.OptionsTiles.AllowPressAnimation = false;
            this.gridLookUpEdit2View.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridLookUpEdit2View.OptionsTiles.ItemSize = new System.Drawing.Size(300, 90);
            this.gridLookUpEdit2View.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.gridLookUpEdit2View.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.gridLookUpEdit2View.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel;
            tableColumnDefinition1.Length.Value = 71D;
            tableColumnDefinition1.PaddingRight = 4;
            tableColumnDefinition2.Length.Value = 153D;
            this.gridLookUpEdit2View.TileColumns.Add(tableColumnDefinition1);
            this.gridLookUpEdit2View.TileColumns.Add(tableColumnDefinition2);
            tableRowDefinition1.Length.Value = 26D;
            tableRowDefinition2.Length.Value = 48D;
            this.gridLookUpEdit2View.TileRows.Add(tableRowDefinition1);
            this.gridLookUpEdit2View.TileRows.Add(tableRowDefinition2);
            tableSpan1.RowSpan = 2;
            this.gridLookUpEdit2View.TileSpans.Add(tableSpan1);
            tileViewItemElement1.Column = this.colPhoto1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            resources.ApplyResources(tileViewItemElement1, "tileViewItemElement1");
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font1")));
            tileViewItemElement2.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement2.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement2.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            tileViewItemElement2.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            tileViewItemElement2.Column = this.colName;
            tileViewItemElement2.ColumnIndex = 1;
            resources.ApplyResources(tileViewItemElement2, "tileViewItemElement2");
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileViewItemElement3.Appearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font2")));
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.Appearance.Normal.Options.UseTextOptions = true;
            tileViewItemElement3.Appearance.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            tileViewItemElement3.Column = this.colNotes1;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.RowIndex = 1;
            resources.ApplyResources(tileViewItemElement3, "tileViewItemElement3");
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            this.gridLookUpEdit2View.TileTemplate.Add(tileViewItemElement1);
            this.gridLookUpEdit2View.TileTemplate.Add(tileViewItemElement2);
            this.gridLookUpEdit2View.TileTemplate.Add(tileViewItemElement3);
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            resources.ApplyResources(this.colAddress, "colAddress");
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            resources.ApplyResources(this.colBirthDate, "colBirthDate");
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            resources.ApplyResources(this.colCity, "colCity");
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            resources.ApplyResources(this.colCountry, "colCountry");
            // 
            // colEmployeeID1
            // 
            this.colEmployeeID1.FieldName = "EmployeeID";
            this.colEmployeeID1.Name = "colEmployeeID1";
            resources.ApplyResources(this.colEmployeeID1, "colEmployeeID1");
            // 
            // colExtension
            // 
            this.colExtension.FieldName = "Extension";
            this.colExtension.Name = "colExtension";
            resources.ApplyResources(this.colExtension, "colExtension");
            // 
            // colFirstName1
            // 
            this.colFirstName1.FieldName = "FirstName";
            this.colFirstName1.Name = "colFirstName1";
            resources.ApplyResources(this.colFirstName1, "colFirstName1");
            // 
            // colHireDate
            // 
            this.colHireDate.FieldName = "HireDate";
            this.colHireDate.Name = "colHireDate";
            resources.ApplyResources(this.colHireDate, "colHireDate");
            // 
            // colHomePhone
            // 
            this.colHomePhone.FieldName = "HomePhone";
            this.colHomePhone.Name = "colHomePhone";
            resources.ApplyResources(this.colHomePhone, "colHomePhone");
            // 
            // colLastName1
            // 
            this.colLastName1.FieldName = "LastName";
            this.colLastName1.Name = "colLastName1";
            resources.ApplyResources(this.colLastName1, "colLastName1");
            // 
            // colPostalCode
            // 
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.Name = "colPostalCode";
            resources.ApplyResources(this.colPostalCode, "colPostalCode");
            // 
            // colRegion
            // 
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            resources.ApplyResources(this.colRegion, "colRegion");
            // 
            // colReportsTo
            // 
            this.colReportsTo.FieldName = "ReportsTo";
            this.colReportsTo.Name = "colReportsTo";
            resources.ApplyResources(this.colReportsTo, "colReportsTo");
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            resources.ApplyResources(this.colTitle, "colTitle");
            // 
            // colTitleOfCourtesy
            // 
            this.colTitleOfCourtesy.FieldName = "TitleOfCourtesy";
            this.colTitleOfCourtesy.Name = "colTitleOfCourtesy";
            resources.ApplyResources(this.colTitleOfCourtesy, "colTitleOfCourtesy");
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.xtraScrollableControl1);
            this.tabPage1.Name = "tabPage1";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            resources.ApplyResources(this.xtraScrollableControl1, "xtraScrollableControl1");
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.dataNavigator1);
            this.panelControl1.Controls.Add(this.gridLookUpEdit1);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Buttons.Append.Visible = false;
            this.dataNavigator1.Buttons.CancelEdit.Visible = false;
            this.dataNavigator1.Buttons.EndEdit.Visible = false;
            this.dataNavigator1.Buttons.NextPage.Visible = false;
            this.dataNavigator1.Buttons.PrevPage.Visible = false;
            this.dataNavigator1.Buttons.Remove.Visible = false;
            this.dataNavigator1.DataSource = this.dsNWindProducts1.Order_Details;
            resources.ApplyResources(this.dataNavigator1, "dataNavigator1");
            this.dataNavigator1.Name = "dataNavigator1";
            // 
            // dsNWindProducts1
            // 
            this.dsNWindProducts1.DataSetName = "dsNWindProducts";
            this.dsNWindProducts1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsNWindProducts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridLookUpEdit1
            // 
            resources.ApplyResources(this.gridLookUpEdit1, "gridLookUpEdit1");
            this.gridLookUpEdit1.Name = "gridLookUpEdit1";
            this.gridLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("gridLookUpEdit1.Properties.Buttons"))))});
            this.gridLookUpEdit1.Properties.DataSource = this.dsNWindProducts1.Products;
            this.gridLookUpEdit1.Properties.DisplayMember = "ProductName";
            this.gridLookUpEdit1.Properties.PopupFormSize = new System.Drawing.Size(500, 0);
            this.gridLookUpEdit1.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEdit1.Properties.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1});
            this.gridLookUpEdit1.Properties.ValueMember = "ProductID";
            this.gridLookUpEdit1.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.gridLookUpEdit1_ProcessNewValue);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCategoryID,
            this.colProductName,
            this.colQuantityPerUnit,
            this.colUnitPrice,
            this.colDiscontinued});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colCategoryID;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = 1;
            styleFormatCondition2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Gray;
            styleFormatCondition2.Appearance.Options.UseFont = true;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.colDiscontinued;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = true;
            this.gridLookUpEdit1View.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2});
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridLookUpEdit1View.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.gridLookUpEdit1View.OptionsView.ShowIndicator = false;
            // 
            // colProductName
            // 
            resources.ApplyResources(this.colProductName, "colProductName");
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            // 
            // colQuantityPerUnit
            // 
            resources.ApplyResources(this.colQuantityPerUnit, "colQuantityPerUnit");
            this.colQuantityPerUnit.FieldName = "QuantityPerUnit";
            this.colQuantityPerUnit.Name = "colQuantityPerUnit";
            // 
            // colUnitPrice
            // 
            resources.ApplyResources(this.colUnitPrice, "colUnitPrice");
            this.colUnitPrice.DisplayFormat.FormatString = "c";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.gridControl1);
            this.tabPage2.Name = "tabPage2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dsNWindCustomers1.Orders;
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2});
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderID,
            this.colCustomerID,
            this.colEmployeeID,
            this.colOrderDate,
            this.colRequiredDate,
            this.colShipName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            // 
            // colOrderID
            // 
            resources.ApplyResources(this.colOrderID, "colOrderID");
            this.colOrderID.FieldName = "OrderID";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.OptionsFilter.AllowFilter = false;
            // 
            // colCustomerID
            // 
            this.colCustomerID.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colCustomerID.AppearanceHeader.Font")));
            this.colCustomerID.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.colCustomerID, "colCustomerID");
            this.colCustomerID.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            // 
            // repositoryItemGridLookUpEdit1
            // 
            resources.ApplyResources(this.repositoryItemGridLookUpEdit1, "repositoryItemGridLookUpEdit1");
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemGridLookUpEdit1.Buttons"))))});
            this.repositoryItemGridLookUpEdit1.DataSource = this.dsNWindCustomers1.Customers;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "CompanyName";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupFormSize = new System.Drawing.Size(400, 0);
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "CustomerID";
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompanyName,
            this.colContactName,
            this.colContactTitle});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemGridLookUpEdit1View.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.AutoCalcPreviewLineCount = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowIndicator = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowPreview = true;
            this.repositoryItemGridLookUpEdit1View.CalcPreviewText += new DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventHandler(this.repositoryItemGridLookUpEdit1View_CalcPreviewText);
            // 
            // colCompanyName
            // 
            resources.ApplyResources(this.colCompanyName, "colCompanyName");
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            // 
            // colContactName
            // 
            resources.ApplyResources(this.colContactName, "colContactName");
            this.colContactName.FieldName = "ContactName";
            this.colContactName.Name = "colContactName";
            // 
            // colContactTitle
            // 
            resources.ApplyResources(this.colContactTitle, "colContactTitle");
            this.colContactTitle.FieldName = "ContactTitle";
            this.colContactTitle.Name = "colContactTitle";
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colEmployeeID.AppearanceHeader.Font")));
            this.colEmployeeID.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.colEmployeeID, "colEmployeeID");
            this.colEmployeeID.ColumnEdit = this.repositoryItemGridLookUpEdit2;
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            // 
            // repositoryItemGridLookUpEdit2
            // 
            resources.ApplyResources(this.repositoryItemGridLookUpEdit2, "repositoryItemGridLookUpEdit2");
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemGridLookUpEdit2.Buttons"))))});
            this.repositoryItemGridLookUpEdit2.DataSource = this.dsNWindCustomers1.Employees;
            this.repositoryItemGridLookUpEdit2.DisplayMember = "Name";
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.PopupFormSize = new System.Drawing.Size(400, 0);
            this.repositoryItemGridLookUpEdit2.PopupView = this.repositoryItemGridLookUpEdit2View;
            this.repositoryItemGridLookUpEdit2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemMemoEdit1});
            this.repositoryItemGridLookUpEdit2.ValueMember = "EmployeeID";
            this.repositoryItemGridLookUpEdit2.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.AdvBandedView;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colPhoto,
            this.colFirstName,
            this.colLastName,
            this.colNotes});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ColumnAutoWidth = true;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowColumnHeaders = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowIndicator = false;
            // 
            // gridBand1
            // 
            resources.ApplyResources(this.gridBand1, "gridBand1");
            this.gridBand1.Columns.Add(this.colPhoto);
            this.gridBand1.OptionsBand.FixedWidth = true;
            this.gridBand1.VisibleIndex = 0;
            // 
            // colPhoto
            // 
            resources.ApplyResources(this.colPhoto, "colPhoto");
            this.colPhoto.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.RowCount = 4;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // gridBand2
            // 
            resources.ApplyResources(this.gridBand2, "gridBand2");
            this.gridBand2.Columns.Add(this.colFirstName);
            this.gridBand2.Columns.Add(this.colLastName);
            this.gridBand2.Columns.Add(this.colNotes);
            this.gridBand2.VisibleIndex = 1;
            // 
            // colFirstName
            // 
            resources.ApplyResources(this.colFirstName, "colFirstName");
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            // 
            // colLastName
            // 
            resources.ApplyResources(this.colLastName, "colLastName");
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            // 
            // colNotes
            // 
            this.colNotes.AutoFillDown = true;
            resources.ApplyResources(this.colNotes, "colNotes");
            this.colNotes.ColumnEdit = this.repositoryItemMemoEdit1;
            this.colNotes.FieldName = "Notes";
            this.colNotes.Name = "colNotes";
            this.colNotes.RowIndex = 1;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // colOrderDate
            // 
            resources.ApplyResources(this.colOrderDate, "colOrderDate");
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            // 
            // colRequiredDate
            // 
            resources.ApplyResources(this.colRequiredDate, "colRequiredDate");
            this.colRequiredDate.FieldName = "RequiredDate";
            this.colRequiredDate.Name = "colRequiredDate";
            // 
            // colShipName
            // 
            resources.ApplyResources(this.colShipName, "colShipName");
            this.colShipName.FieldName = "ShipName";
            this.colShipName.Name = "colShipName";
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("Beverages", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Beverages"))));
            this.svgImageCollection1.Add("condiments", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.condiments"))));
            this.svgImageCollection1.Add("confections", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.confections"))));
            this.svgImageCollection1.Add("DairyProduct", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.DairyProduct"))));
            this.svgImageCollection1.Add("grains_cereals", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.grains_cereals"))));
            this.svgImageCollection1.Add("MeatPoultry", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.MeatPoultry"))));
            this.svgImageCollection1.Add("produce", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.produce"))));
            this.svgImageCollection1.Add("Seafood", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.Seafood"))));
            // 
            // GridLookUpEditDemo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "GridLookUpEditDemo";
            this.Load += new System.EventHandler(this.GridLookUpEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNWindCustomers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsNWindProducts1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPage2;
        private DevExpress.XtraEditors.GroupControl panelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Demos.dsNWindProducts dsNWindProducts1;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityPerUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscontinued;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredDate;
        private DevExpress.XtraGrid.Columns.GridColumn colShipName;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactTitle;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPhoto;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFirstName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLastName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNotes;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Demos.dsNWindCustomers dsNWindCustomers1;
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPage3;
        private XtraEditors.GroupControl groupControl1;
        private XtraEditors.GridLookUpEdit gridLookUpEdit2;
        private Views.Tile.TileView gridLookUpEdit2View;
        private Columns.TileViewColumn colAddress;
        private Columns.TileViewColumn colBirthDate;
        private Columns.TileViewColumn colCity;
        private Columns.TileViewColumn colCountry;
        private Columns.TileViewColumn colEmployeeID1;
        private Columns.TileViewColumn colExtension;
        private Columns.TileViewColumn colFirstName1;
        private Columns.TileViewColumn colHireDate;
        private Columns.TileViewColumn colHomePhone;
        private Columns.TileViewColumn colLastName1;
        private Columns.TileViewColumn colNotes1;
        private Columns.TileViewColumn colPhoto1;
        private Columns.TileViewColumn colPostalCode;
        private Columns.TileViewColumn colRegion;
        private Columns.TileViewColumn colReportsTo;
        private Columns.TileViewColumn colTitle;
        private Columns.TileViewColumn colTitleOfCourtesy;
        private Columns.TileViewColumn colName;
        private Utils.SvgImageCollection svgImageCollection1;
    }
}
