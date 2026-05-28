namespace DevExpress.XtraGrid.Demos {
    partial class AutoFilterRow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoFilterRow));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dsIssueList1 = new DevExpress.XtraGrid.Demos.dsIssueList();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwnerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFixedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ceAutoFilterRowMenuItem = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceAutoFilterRow = new DevExpress.XtraEditors.CheckEdit();
            this.ceAllowAutoFilterConditionChange = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIssueList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoFilterRowMenuItem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoFilterRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowAutoFilterConditionChange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.repositoryItemImageComboBox2});
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
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PreviewFieldName = "Description";
            this.gridView1.GridMenuItemClick += new DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventHandler(this.gridView1_GridMenuItemClick);
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
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
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
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("new", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.new"))));
            this.svgImageCollection1.Add("fixed", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.fixed"))));
            this.svgImageCollection1.Add("rejected", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.rejected"))));
            this.svgImageCollection1.Add("postponed", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.postponed"))));
            this.svgImageCollection1.Add("low", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.low"))));
            this.svgImageCollection1.Add("medium", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.medium"))));
            this.svgImageCollection1.Add("high", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.high"))));
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
            this.colFixedDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
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
            // ceAutoFilterRowMenuItem
            // 
            resources.ApplyResources(this.ceAutoFilterRowMenuItem, "ceAutoFilterRowMenuItem");
            this.ceAutoFilterRowMenuItem.Name = "ceAutoFilterRowMenuItem";
            this.ceAutoFilterRowMenuItem.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ceAutoFilterRowMenuItem.Properties.Appearance.Options.UseTextOptions = true;
            this.ceAutoFilterRowMenuItem.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ceAutoFilterRowMenuItem.Properties.Caption = resources.GetString("ceAutoFilterRowMenuItem.Properties.Caption");
            this.ceAutoFilterRowMenuItem.StyleController = this.layoutControl1;
            this.ceAutoFilterRowMenuItem.CheckedChanged += new System.EventHandler(this.ceAutoFilterRowMenuItem_CheckedChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.ceAutoFilterRowMenuItem);
            this.layoutControl1.Controls.Add(this.ceAutoFilterRow);
            this.layoutControl1.Controls.Add(this.ceAllowAutoFilterConditionChange);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1284, 203, 450, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // ceAutoFilterRow
            // 
            resources.ApplyResources(this.ceAutoFilterRow, "ceAutoFilterRow");
            this.ceAutoFilterRow.Name = "ceAutoFilterRow";
            this.ceAutoFilterRow.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ceAutoFilterRow.Properties.Caption = resources.GetString("ceAutoFilterRow.Properties.Caption");
            this.ceAutoFilterRow.StyleController = this.layoutControl1;
            this.ceAutoFilterRow.CheckedChanged += new System.EventHandler(this.ceAutoFilterRow_CheckedChanged);
            // 
            // ceAllowAutoFilterConditionChange
            // 
            resources.ApplyResources(this.ceAllowAutoFilterConditionChange, "ceAllowAutoFilterConditionChange");
            this.ceAllowAutoFilterConditionChange.Name = "ceAllowAutoFilterConditionChange";
            this.ceAllowAutoFilterConditionChange.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ceAllowAutoFilterConditionChange.Properties.Appearance.Options.UseTextOptions = true;
            this.ceAllowAutoFilterConditionChange.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.ceAllowAutoFilterConditionChange.Properties.Caption = resources.GetString("ceAllowAutoFilterConditionChange.Properties.Caption");
            this.ceAllowAutoFilterConditionChange.StyleController = this.layoutControl1;
            this.ceAllowAutoFilterConditionChange.CheckedChanged += new System.EventHandler(this.ceAllowAutoFilterConditionChange_CheckedChanged);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(249, 476);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 176);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(249, 300);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(249, 100);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            resources.ApplyResources(this.layoutControlGroup2, "layoutControlGroup2");
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ceAutoFilterRow;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(229, 24);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ceAutoFilterRowMenuItem;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(229, 34);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 100);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(249, 76);
            this.layoutControlGroup3.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            resources.ApplyResources(this.layoutControlGroup3, "layoutControlGroup3");
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceAllowAutoFilterConditionChange;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(229, 34);
            this.layoutControlItem3.TextVisible = false;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            resources.ApplyResources(this.navigationPane1, "navigationPane1");
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = true;
            this.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationPane1.RegularSize = new System.Drawing.Size(249, 509);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            // 
            // navigationPage1
            // 
            resources.ApplyResources(this.navigationPage1, "navigationPage1");
            this.navigationPage1.Controls.Add(this.layoutControl1);
            this.navigationPage1.Name = "navigationPage1";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.navigationPane1);
            resources.ApplyResources(this.sidePanel1, "sidePanel1");
            this.sidePanel1.Name = "sidePanel1";
            // 
            // AutoFilterRow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.sidePanel1);
            this.Name = "AutoFilterRow";
            this.Load += new System.EventHandler(this.AutoFilterRow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsIssueList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoFilterRowMenuItem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceAutoFilterRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceAllowAutoFilterConditionChange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private DevExpress.XtraEditors.CheckEdit ceAutoFilterRow;
        private System.ComponentModel.IContainer components;
        private DevExpress.XtraEditors.CheckEdit ceAutoFilterRowMenuItem;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraBars.Navigation.TabPane navigationPane1;
        private XtraBars.Navigation.TabNavigationPage navigationPage1;
        private XtraEditors.PanelControl panelControl1;
        private XtraEditors.CheckEdit ceAllowAutoFilterConditionChange;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraEditors.SidePanel sidePanel1;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private Utils.SvgImageCollection svgImageCollection1;
    }
}
