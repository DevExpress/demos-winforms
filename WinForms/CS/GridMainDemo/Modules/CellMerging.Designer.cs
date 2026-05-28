namespace DevExpress.XtraGrid.Demos {
    partial class CellMerging {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CellMerging));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1layoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.icbEditMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.ceMerging = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ceMergingitem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsIssueList1 = new DevExpress.XtraGrid.Demos.dsIssueList();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwnerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFixedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.panel1layoutControl1ConvertedLayout)).BeginInit();
            this.panel1layoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbEditMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMerging.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMergingitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIssueList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.StyleController = this.panel1layoutControl1ConvertedLayout;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel1layoutControl1ConvertedLayout
            // 
            this.panel1layoutControl1ConvertedLayout.AllowCustomization = false;
            this.panel1layoutControl1ConvertedLayout.Controls.Add(this.icbEditMode);
            this.panel1layoutControl1ConvertedLayout.Controls.Add(this.simpleButton1);
            this.panel1layoutControl1ConvertedLayout.Controls.Add(this.ceMerging);
            resources.ApplyResources(this.panel1layoutControl1ConvertedLayout, "panel1layoutControl1ConvertedLayout");
            this.panel1layoutControl1ConvertedLayout.Name = "panel1layoutControl1ConvertedLayout";
            this.panel1layoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(4999, 1601, 650, 400);
            this.panel1layoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            // 
            // icbEditMode
            // 
            resources.ApplyResources(this.icbEditMode, "icbEditMode");
            this.icbEditMode.Name = "icbEditMode";
            this.icbEditMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("icbEditMode.Properties.Buttons"))))});
            this.icbEditMode.StyleController = this.panel1layoutControl1ConvertedLayout;
            this.icbEditMode.SelectedIndexChanged += new System.EventHandler(this.icbEditMode_SelectedIndexChanged);
            // 
            // ceMerging
            // 
            resources.ApplyResources(this.ceMerging, "ceMerging");
            this.ceMerging.Name = "ceMerging";
            this.ceMerging.Properties.Caption = resources.GetString("ceMerging.Properties.Caption");
            this.ceMerging.StyleController = this.panel1layoutControl1ConvertedLayout;
            this.ceMerging.CheckedChanged += new System.EventHandler(this.ceMerging_CheckedChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(249, 399);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 158);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(249, 241);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ceMergingitem,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(249, 90);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            resources.ApplyResources(this.layoutControlGroup2, "layoutControlGroup2");
            // 
            // ceMergingitem
            // 
            this.ceMergingitem.Control = this.ceMerging;
            this.ceMergingitem.Location = new System.Drawing.Point(0, 0);
            this.ceMergingitem.Name = "ceMergingitem";
            this.ceMergingitem.Size = new System.Drawing.Size(229, 24);
            this.ceMergingitem.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.icbEditMode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(229, 24);
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 90);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(249, 68);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            resources.ApplyResources(this.layoutControlGroup3, "layoutControlGroup3");
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(229, 26);
            this.layoutControlItem1.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dsIssueList1.Items;
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dsIssueList1
            // 
            this.dsIssueList1.DataSetName = "dsIssueList";
            this.dsIssueList1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dsIssueList1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProjectID,
            this.colType,
            this.colName,
            this.colPriority,
            this.colStatus,
            this.colCreatedDate,
            this.colOwnerID,
            this.colFixedDate,
            this.colCreatorID,
            this.colModifiedDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted;
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PreviewFieldName = "Description";
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colProjectID
            // 
            resources.ApplyResources(this.colProjectID, "colProjectID");
            this.colProjectID.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colProjectID.FieldName = "ProjectID";
            this.colProjectID.Name = "colProjectID";
            // 
            // repositoryItemLookUpEdit1
            // 
            resources.ApplyResources(this.repositoryItemLookUpEdit1, "repositoryItemLookUpEdit1");
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemLookUpEdit1.Buttons"))))});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit1.Columns"), resources.GetString("repositoryItemLookUpEdit1.Columns1"), ((int)(resources.GetObject("repositoryItemLookUpEdit1.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("repositoryItemLookUpEdit1.Columns3"))), resources.GetString("repositoryItemLookUpEdit1.Columns4"), ((bool)(resources.GetObject("repositoryItemLookUpEdit1.Columns5"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("repositoryItemLookUpEdit1.Columns6"))), ((DevExpress.Data.ColumnSortOrder)(resources.GetObject("repositoryItemLookUpEdit1.Columns7"))), ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("repositoryItemLookUpEdit1.Columns8"))))});
            this.repositoryItemLookUpEdit1.DataSource = this.dsIssueList1.Projects;
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.DropDownRows = 3;
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.PopupWidth = 200;
            this.repositoryItemLookUpEdit1.ShowFooter = false;
            this.repositoryItemLookUpEdit1.ShowHeader = false;
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // colType
            // 
            resources.ApplyResources(this.colType, "colType");
            this.colType.ColumnEdit = this.repositoryItemImageComboBox3;
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            // 
            // repositoryItemImageComboBox3
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox3, "repositoryItemImageComboBox3");
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox3.Buttons"))))});
            this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox3.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox3.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox3.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox3.Items5"))))});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            this.repositoryItemImageComboBox3.SmallImages = this.svgImageCollection1;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("bugreport", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.bugreport"))));
            this.svgImageCollection1.Add("task", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.task"))));
            this.svgImageCollection1.Add("new", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.new"))));
            this.svgImageCollection1.Add("postponed", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.postponed"))));
            this.svgImageCollection1.Add("fixed", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.fixed"))));
            this.svgImageCollection1.Add("rejected", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.rejected"))));
            this.svgImageCollection1.Add("low", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.low"))));
            this.svgImageCollection1.Add("medium", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.medium"))));
            this.svgImageCollection1.Add("high", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.high"))));
            // 
            // colName
            // 
            resources.ApplyResources(this.colName, "colName");
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colName.Summary"))))});
            // 
            // colPriority
            // 
            resources.ApplyResources(this.colPriority, "colPriority");
            this.colPriority.ColumnEdit = this.repositoryItemImageComboBox2;
            this.colPriority.FieldName = "Priority";
            this.colPriority.Name = "colPriority";
            this.colPriority.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // repositoryItemImageComboBox2
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox2, "repositoryItemImageComboBox2");
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox2.Buttons"))))});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox2.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox2.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox2.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox2.Items5")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items6"), ((object)(resources.GetObject("repositoryItemImageComboBox2.Items7"))), ((int)(resources.GetObject("repositoryItemImageComboBox2.Items8"))))});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            this.repositoryItemImageComboBox2.SmallImages = this.svgImageCollection1;
            // 
            // colStatus
            // 
            resources.ApplyResources(this.colStatus, "colStatus");
            this.colStatus.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
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
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items10"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items11"))))});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.svgImageCollection1;
            // 
            // colCreatedDate
            // 
            resources.ApplyResources(this.colCreatedDate, "colCreatedDate");
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("colCreatedDate.Summary"))), resources.GetString("colCreatedDate.Summary1"), resources.GetString("colCreatedDate.Summary2"))});
            // 
            // colOwnerID
            // 
            resources.ApplyResources(this.colOwnerID, "colOwnerID");
            this.colOwnerID.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colOwnerID.FieldName = "OwnerID";
            this.colOwnerID.Name = "colOwnerID";
            // 
            // repositoryItemLookUpEdit2
            // 
            resources.ApplyResources(this.repositoryItemLookUpEdit2, "repositoryItemLookUpEdit2");
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemLookUpEdit2.Buttons"))))});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit2.Columns"), resources.GetString("repositoryItemLookUpEdit2.Columns1"), ((int)(resources.GetObject("repositoryItemLookUpEdit2.Columns2"))), ((DevExpress.Utils.FormatType)(resources.GetObject("repositoryItemLookUpEdit2.Columns3"))), resources.GetString("repositoryItemLookUpEdit2.Columns4"), ((bool)(resources.GetObject("repositoryItemLookUpEdit2.Columns5"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("repositoryItemLookUpEdit2.Columns6"))), ((DevExpress.Data.ColumnSortOrder)(resources.GetObject("repositoryItemLookUpEdit2.Columns7"))), ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("repositoryItemLookUpEdit2.Columns8"))))});
            this.repositoryItemLookUpEdit2.DataSource = this.dsIssueList1.Users;
            this.repositoryItemLookUpEdit2.DisplayMember = "FullName";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ShowFooter = false;
            this.repositoryItemLookUpEdit2.ShowHeader = false;
            this.repositoryItemLookUpEdit2.ValueMember = "ID";
            // 
            // colFixedDate
            // 
            resources.ApplyResources(this.colFixedDate, "colFixedDate");
            this.colFixedDate.FieldName = "FixedDate";
            this.colFixedDate.Name = "colFixedDate";
            // 
            // colCreatorID
            // 
            resources.ApplyResources(this.colCreatorID, "colCreatorID");
            this.colCreatorID.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colCreatorID.FieldName = "CreatorID";
            this.colCreatorID.Name = "colCreatorID";
            // 
            // colModifiedDate
            // 
            resources.ApplyResources(this.colModifiedDate, "colModifiedDate");
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
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
            this.tabPane1.RegularSize = new System.Drawing.Size(249, 432);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            // 
            // tabNavigationPage1
            // 
            resources.ApplyResources(this.tabNavigationPage1, "tabNavigationPage1");
            this.tabNavigationPage1.Controls.Add(this.panel1layoutControl1ConvertedLayout);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            // 
            // CellMerging
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "CellMerging";
            this.Load += new System.EventHandler(this.CellMerging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1layoutControl1ConvertedLayout)).EndInit();
            this.panel1layoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbEditMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMerging.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceMergingitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIssueList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.CheckEdit ceMerging;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectID;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPriority;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colOwnerID;
        private DevExpress.XtraGrid.Columns.GridColumn colFixedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatorID;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraGrid.Demos.dsIssueList dsIssueList1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private XtraLayout.LayoutControl panel1layoutControl1ConvertedLayout;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem ceMergingitem;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraEditors.SidePanel sidePanel1;
        private XtraBars.Navigation.TabPane tabPane1;
        private XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private Utils.SvgImageCollection svgImageCollection1;
        private XtraEditors.ImageComboBoxEdit icbEditMode;
        private XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
