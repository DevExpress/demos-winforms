namespace DevExpress.ProductsDemo.Win.Modules {
    partial class GridModule {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridModule));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgEmployees = new DevExpress.XtraNavBar.NavBarGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colComplete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIcon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.icEditorsSVG = new DevExpress.Utils.SvgImageCollection(this.components);
            this.colPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.colCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.icCategorySVG = new DevExpress.Utils.SvgImageCollection(this.components);
            this.colFlagStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colOverdue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.icColumns = new DevExpress.Utils.SvgImageCollection(this.components);
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditorsSVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icCategorySVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.navBarControl1);
            this.layoutControl1.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(842, -11, 630, 697);
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.nbgEmployees;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgEmployees});
            resources.ApplyResources(this.navBarControl1, "navBarControl1");
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.NavigationPaneGroupClientHeight = 320;
            this.navBarControl1.OptionsNavPane.ExpandedWidth = ((int)(resources.GetObject("resource.ExpandedWidth")));
            this.navBarControl1.OptionsNavPane.ShowGroupImageInHeader = true;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.OptionsNavPane.ShowSplitter = false;
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
            // 
            // nbgEmployees
            // 
            resources.ApplyResources(this.nbgEmployees, "nbgEmployees");
            this.nbgEmployees.Expanded = true;
            this.nbgEmployees.ImageOptions.SvgImage = global::DevExpress.ProductsDemo.Win.Properties.Resources.Contact;
            this.nbgEmployees.Name = "nbgEmployees";
            this.nbgEmployees.NavigationPaneVisible = false;
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3,
            this.repositoryItemProgressBar1,
            this.repositoryItemImageComboBox4,
            this.repositoryItemTrackBar1,
            this.repositoryItemImageComboBox5});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colComplete,
            this.colIcon,
            this.colPriority,
            this.colSubject,
            this.colStatus,
            this.colPercent,
            this.colCreated,
            this.colStartDate,
            this.colDueDate,
            this.colCompleted,
            this.colCategory,
            this.colFlagStatus,
            this.colOverdue});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary"))), resources.GetString("gridView1.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary2"))), resources.GetString("gridView1.GroupSummary3"))});
            this.gridView1.Images = this.icColumns;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Excel;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindFilterColumns = "Subject";
            this.gridView1.OptionsPrint.PrintHorzLines = false;
            this.gridView1.OptionsPrint.PrintVertLines = false;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            this.gridView1.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEditForEditing);
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanging);
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // colComplete
            // 
            this.colComplete.FieldName = "Complete";
            this.colComplete.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colComplete.ImageOptions.Alignment")));
            this.colComplete.ImageOptions.ImageIndex = ((int)(resources.GetObject("colComplete.ImageOptions.ImageIndex")));
            this.colComplete.Name = "colComplete";
            this.colComplete.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colComplete.OptionsColumn.AllowSize = false;
            this.colComplete.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colComplete.OptionsColumn.FixedWidth = true;
            this.colComplete.OptionsColumn.ShowCaption = false;
            this.colComplete.OptionsColumn.ShowInCustomizationForm = false;
            this.colComplete.OptionsFilter.AllowFilter = false;
            resources.ApplyResources(this.colComplete, "colComplete");
            // 
            // colIcon
            // 
            this.colIcon.ColumnEdit = this.repositoryItemImageComboBox2;
            this.colIcon.FieldName = "Icon";
            this.colIcon.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colIcon.ImageOptions.Alignment")));
            this.colIcon.ImageOptions.ImageIndex = ((int)(resources.GetObject("colIcon.ImageOptions.ImageIndex")));
            this.colIcon.Name = "colIcon";
            this.colIcon.OptionsColumn.AllowEdit = false;
            this.colIcon.OptionsColumn.AllowFocus = false;
            this.colIcon.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colIcon.OptionsColumn.AllowSize = false;
            this.colIcon.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colIcon.OptionsColumn.FixedWidth = true;
            this.colIcon.OptionsColumn.ShowCaption = false;
            this.colIcon.OptionsFilter.AllowFilter = false;
            resources.ApplyResources(this.colIcon, "colIcon");
            // 
            // repositoryItemImageComboBox2
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox2, "repositoryItemImageComboBox2");
            this.repositoryItemImageComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox2.Buttons"))))});
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox2.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox2.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox2.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox2.Items5"))))});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            this.repositoryItemImageComboBox2.SmallImages = this.icEditorsSVG;
            // 
            // icEditorsSVG
            // 
            this.icEditorsSVG.Add("low", "low", typeof(DevExpress.ProductsDemo.Win.Properties.Resources));
            this.icEditorsSVG.Add("important", "important", typeof(DevExpress.ProductsDemo.Win.Properties.Resources));
            this.icEditorsSVG.Add("BO_Task_Large", "BO_Task_Large", typeof(DevExpress.ProductsDemo.Win.Properties.Resources));
            this.icEditorsSVG.Add("BandedReports", "BandedReports", typeof(DevExpress.ProductsDemo.Win.Properties.Resources));
            // 
            // colPriority
            // 
            this.colPriority.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colPriority.FieldName = "Priority";
            this.colPriority.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colPriority.ImageOptions.Alignment")));
            this.colPriority.ImageOptions.ImageIndex = ((int)(resources.GetObject("colPriority.ImageOptions.ImageIndex")));
            this.colPriority.Name = "colPriority";
            this.colPriority.OptionsColumn.AllowSize = false;
            this.colPriority.OptionsColumn.FixedWidth = true;
            this.colPriority.OptionsColumn.ShowCaption = false;
            resources.ApplyResources(this.colPriority, "colPriority");
            // 
            // repositoryItemImageComboBox1
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox1, "repositoryItemImageComboBox1");
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items5")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items7"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items8"))))});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.icEditorsSVG;
            // 
            // colSubject
            // 
            resources.ApplyResources(this.colSubject, "colSubject");
            this.colSubject.FieldName = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.OptionsColumn.AllowEdit = false;
            this.colSubject.OptionsColumn.AllowFocus = false;
            // 
            // colStatus
            // 
            resources.ApplyResources(this.colStatus, "colStatus");
            this.colStatus.ColumnEdit = this.repositoryItemImageComboBox3;
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // repositoryItemImageComboBox3
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox3, "repositoryItemImageComboBox3");
            this.repositoryItemImageComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox3.Buttons"))))});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            // 
            // colPercent
            // 
            resources.ApplyResources(this.colPercent, "colPercent");
            this.colPercent.ColumnEdit = this.repositoryItemProgressBar1;
            this.colPercent.FieldName = "PercentComplete";
            this.colPercent.Name = "colPercent";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.ShowTitle = true;
            // 
            // colCreated
            // 
            resources.ApplyResources(this.colCreated, "colCreated");
            this.colCreated.FieldName = "CreatedDate";
            this.colCreated.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.colCreated.Name = "colCreated";
            this.colCreated.OptionsColumn.AllowEdit = false;
            this.colCreated.OptionsColumn.AllowFocus = false;
            // 
            // colStartDate
            // 
            resources.ApplyResources(this.colStartDate, "colStartDate");
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.colStartDate.Name = "colStartDate";
            // 
            // colDueDate
            // 
            resources.ApplyResources(this.colDueDate, "colDueDate");
            this.colDueDate.FieldName = "DueDate";
            this.colDueDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.colDueDate.Name = "colDueDate";
            // 
            // colCompleted
            // 
            resources.ApplyResources(this.colCompleted, "colCompleted");
            this.colCompleted.FieldName = "CompletedDate";
            this.colCompleted.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.colCompleted.Name = "colCompleted";
            this.colCompleted.OptionsColumn.AllowEdit = false;
            this.colCompleted.OptionsColumn.AllowFocus = false;
            // 
            // colCategory
            // 
            resources.ApplyResources(this.colCategory, "colCategory");
            this.colCategory.ColumnEdit = this.repositoryItemImageComboBox4;
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.OptionsColumn.AllowEdit = false;
            this.colCategory.OptionsColumn.AllowFocus = false;
            // 
            // repositoryItemImageComboBox4
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox4, "repositoryItemImageComboBox4");
            this.repositoryItemImageComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox4.Buttons"))))});
            this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
            this.repositoryItemImageComboBox4.SmallImages = this.icCategorySVG;
            // 
            // icCategorySVG
            // 
            this.icCategorySVG.Add("Home", "Home", typeof(DevExpress.ProductsDemo.Win.Properties.Resources));
            this.icCategorySVG.Add("BO_Cart", "BO_Cart", typeof(DevExpress.ProductsDemo.Win.Properties.Resources));
            this.icCategorySVG.Add("BO_Organization", "BO_Organization", typeof(DevExpress.ProductsDemo.Win.Properties.Resources));
            // 
            // colFlagStatus
            // 
            this.colFlagStatus.ColumnEdit = this.repositoryItemImageComboBox5;
            this.colFlagStatus.FieldName = "FlagStatus";
            this.colFlagStatus.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colFlagStatus.ImageOptions.Alignment")));
            this.colFlagStatus.ImageOptions.ImageIndex = ((int)(resources.GetObject("colFlagStatus.ImageOptions.ImageIndex")));
            this.colFlagStatus.Name = "colFlagStatus";
            this.colFlagStatus.OptionsColumn.AllowEdit = false;
            this.colFlagStatus.OptionsColumn.AllowFocus = false;
            this.colFlagStatus.OptionsColumn.AllowSize = false;
            this.colFlagStatus.OptionsColumn.FixedWidth = true;
            this.colFlagStatus.OptionsColumn.ShowCaption = false;
            resources.ApplyResources(this.colFlagStatus, "colFlagStatus");
            // 
            // repositoryItemImageComboBox5
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox5, "repositoryItemImageComboBox5");
            this.repositoryItemImageComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox5.Buttons"))))});
            this.repositoryItemImageComboBox5.Name = "repositoryItemImageComboBox5";
            // 
            // colOverdue
            // 
            this.colOverdue.FieldName = "Overdue";
            this.colOverdue.Name = "colOverdue";
            this.colOverdue.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // icColumns
            // 
            this.icColumns.Add("Importance", "image://svgimages/scheduling/highimportance.svg");
            this.icColumns.Add("Icon", "image://svgimages/outlook inspired/new.svg");
            this.icColumns.Add("Complete", "image://svgimages/outlook inspired/markcomplete.svg");
            this.icColumns.Add("Flag", "NoDate_Flag1", typeof(DevExpress.ProductsDemo.Win.Properties.Resources));
            // 
            // repositoryItemTrackBar1
            // 
            this.repositoryItemTrackBar1.LargeChange = 10;
            this.repositoryItemTrackBar1.Maximum = 100;
            this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
            this.repositoryItemTrackBar1.ShowValueToolTip = true;
            this.repositoryItemTrackBar1.SmallChange = 5;
            this.repositoryItemTrackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // layoutControlGroup1
            // 
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1075, 593);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(879, 581);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.navBarControl1;
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.Location = new System.Drawing.Point(879, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(184, 581);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // GridModule
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "GridModule";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditorsSVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icCategorySVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colComplete;
        private DevExpress.XtraGrid.Columns.GridColumn colIcon;
        private DevExpress.XtraGrid.Columns.GridColumn colPriority;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCompleted;
        private DevExpress.XtraGrid.Columns.GridColumn colCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colFlagStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colPercent;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
        private DevExpress.XtraGrid.Columns.GridColumn colOverdue;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox5;
        private XtraNavBar.NavBarControl navBarControl1;
        private XtraNavBar.NavBarGroup nbgEmployees;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private Utils.SvgImageCollection icEditorsSVG;
        private Utils.SvgImageCollection icCategorySVG;
        private Utils.SvgImageCollection icColumns;
    }
}
