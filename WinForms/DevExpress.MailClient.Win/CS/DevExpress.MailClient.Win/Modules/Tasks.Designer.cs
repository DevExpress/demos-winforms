namespace DevExpress.MailClient.Win {
    partial class Tasks {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colComplete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIcon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.icEditors = new DevExpress.Utils.SvgImageCollection(this.components);
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
            this.icCategory = new DevExpress.Utils.SvgImageCollection(this.components);
            this.colFlagStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colOverdue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
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
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
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
            this.colIcon.ImageOptions.SvgImage = global::DevExpress.MailClient.Win.Properties.Resources.Report;
            this.colIcon.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
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
            this.repositoryItemImageComboBox2.SmallImages = this.icEditors;
            // 
            // icEditors
            // 
            this.icEditors.Add("Low", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icEditors.Low"))));
            this.icEditors.Add("High", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icEditors.High"))));
            this.icEditors.Add("Task", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icEditors.Task"))));
            this.icEditors.Add("Report", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icEditors.Report"))));
            // 
            // colPriority
            // 
            this.colPriority.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colPriority.FieldName = "Priority";
            this.colPriority.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colPriority.ImageOptions.Alignment")));
            this.colPriority.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("colPriority.ImageOptions.SvgImage")));
            this.colPriority.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.colPriority.Name = "colPriority";
            this.colPriority.OptionsColumn.AllowSize = false;
            this.colPriority.OptionsColumn.FixedWidth = true;
            this.colPriority.OptionsColumn.ShowCaption = false;
            this.colPriority.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
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
            this.repositoryItemImageComboBox1.SmallImages = this.icEditors;
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
            this.colStatus.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
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
            this.colCategory.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            // 
            // repositoryItemImageComboBox4
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox4, "repositoryItemImageComboBox4");
            this.repositoryItemImageComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemImageComboBox4.Buttons"))))});
            this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
            this.repositoryItemImageComboBox4.SmallImages = this.icCategory;
            // 
            // icCategory
            // 
            this.icCategory.Add("BO_Cart", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icCategory.BO_Cart"))));
            this.icCategory.Add("BO_Organization", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icCategory.BO_Organization"))));
            this.icCategory.Add("Home", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("icCategory.Home"))));
            // 
            // colFlagStatus
            // 
            this.colFlagStatus.ColumnEdit = this.repositoryItemImageComboBox5;
            this.colFlagStatus.FieldName = "FlagStatus";
            this.colFlagStatus.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colFlagStatus.ImageOptions.Alignment")));
            this.colFlagStatus.ImageOptions.SvgImage = global::DevExpress.MailClient.Win.Properties.Resources.NextWeek1;
            this.colFlagStatus.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
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
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlGroup1.Size = new System.Drawing.Size(942, 526);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(930, 514);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Tasks
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Tasks";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
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
        private DevExpress.Utils.SvgImageCollection icEditors;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
        private DevExpress.Utils.SvgImageCollection icCategory;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
        private DevExpress.XtraGrid.Columns.GridColumn colOverdue;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox5;
    }
}
