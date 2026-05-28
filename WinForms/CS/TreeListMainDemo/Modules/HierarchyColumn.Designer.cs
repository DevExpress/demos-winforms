namespace DevExpress.XtraTreeList.Demos {
    partial class HierarchyColumn {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HierarchyColumn));
            DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule treeListFormatRule1 = new DevExpress.XtraTreeList.StyleFormatConditions.TreeListFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            this.statusColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.completedColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCompletedComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.svgImageCollection = new DevExpress.Utils.SvgImageCollection(this.components);
            this.priorityColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemPriorityComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.employeeColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.taskColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.startDateColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dueDateColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.descriptionColumn = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemDescriptionComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.sidePanel = new DevExpress.XtraEditors.SidePanel();
            this.navigationPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.navigationPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.ucScrollAnnotationsOptions = new DevExpress.XtraTreeList.Demos.Options.ucScrollAnnotationsOptions();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCompletedComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPriorityComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDescriptionComboBox)).BeginInit();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane)).BeginInit();
            this.navigationPane.SuspendLayout();
            this.navigationPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusColumn
            // 
            this.statusColumn.AppearanceCell.Options.UseTextOptions = true;
            this.statusColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.statusColumn.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.statusColumn.Caption = "Status";
            this.statusColumn.FieldName = "Status";
            this.statusColumn.Format.FormatString = "{0}%";
            this.statusColumn.Format.FormatType = DevExpress.Utils.FormatType.Custom;
            this.statusColumn.MaxWidth = 100;
            this.statusColumn.MinWidth = 80;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.Visible = true;
            this.statusColumn.VisibleIndex = 5;
            this.statusColumn.Width = 97;
            // 
            // completedColumn
            // 
            this.completedColumn.ColumnEdit = this.repositoryItemCompletedComboBox;
            this.completedColumn.FieldName = "IsCompleted";
            this.completedColumn.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.completedColumn.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.completedColumn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("completedColumn.ImageOptions.SvgImage")));
            this.completedColumn.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.completedColumn.MaxWidth = 33;
            this.completedColumn.MinWidth = 33;
            this.completedColumn.Name = "completedColumn";
            this.completedColumn.OptionsColumn.AllowEdit = false;
            this.completedColumn.OptionsColumn.AllowFocus = false;
            this.completedColumn.OptionsColumn.AllowMove = false;
            this.completedColumn.OptionsColumn.AllowSize = false;
            this.completedColumn.OptionsColumn.AllowSort = false;
            this.completedColumn.OptionsFilter.AllowAutoFilter = false;
            this.completedColumn.OptionsFilter.AllowFilter = false;
            this.completedColumn.ToolTip = "Completed";
            this.completedColumn.Visible = true;
            this.completedColumn.VisibleIndex = 0;
            this.completedColumn.Width = 33;
            // 
            // repositoryItemCompletedComboBox
            // 
            this.repositoryItemCompletedComboBox.AutoHeight = false;
            this.repositoryItemCompletedComboBox.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemCompletedComboBox.Name = "repositoryItemCompletedComboBox";
            this.repositoryItemCompletedComboBox.SmallImages = this.svgImageCollection;
            // 
            // svgImageCollection
            // 
            this.svgImageCollection.Add("YellowFlag", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.YellowFlag"))));
            this.svgImageCollection.Add("RedFlag", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.RedFlag"))));
            this.svgImageCollection.Add("apply", "image://devav/actions/apply.svg");
            this.svgImageCollection.Add("show", "image://devav/actions/show.svg");
            this.svgImageCollection.Add("bookmark", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.bookmark"))));
            this.svgImageCollection.Add("GreenFlag", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.GreenFlag"))));
            this.svgImageCollection.Add("IndentDecrease", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.IndentDecrease"))));
            this.svgImageCollection.Add("IndentIncrease", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection.IndentIncrease"))));
            // 
            // priorityColumn
            // 
            this.priorityColumn.ColumnEdit = this.repositoryItemPriorityComboBox;
            this.priorityColumn.FieldName = "Priority";
            this.priorityColumn.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.priorityColumn.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.priorityColumn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("priorityColumn.ImageOptions.SvgImage")));
            this.priorityColumn.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.priorityColumn.MaxWidth = 33;
            this.priorityColumn.MinWidth = 33;
            this.priorityColumn.Name = "priorityColumn";
            this.priorityColumn.OptionsColumn.AllowEdit = false;
            this.priorityColumn.OptionsColumn.AllowFocus = false;
            this.priorityColumn.OptionsColumn.AllowMove = false;
            this.priorityColumn.OptionsColumn.AllowSize = false;
            this.priorityColumn.OptionsColumn.AllowSort = false;
            this.priorityColumn.OptionsFilter.AllowAutoFilter = false;
            this.priorityColumn.OptionsFilter.AllowFilter = false;
            this.priorityColumn.ToolTip = "Priority";
            this.priorityColumn.Visible = true;
            this.priorityColumn.VisibleIndex = 1;
            this.priorityColumn.Width = 33;
            // 
            // repositoryItemPriorityComboBox
            // 
            this.repositoryItemPriorityComboBox.AutoHeight = false;
            this.repositoryItemPriorityComboBox.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemPriorityComboBox.Name = "repositoryItemPriorityComboBox";
            this.repositoryItemPriorityComboBox.SmallImages = this.svgImageCollection;
            // 
            // employeeColumn
            // 
            this.employeeColumn.Caption = "Employee";
            this.employeeColumn.FieldName = "Employee";
            this.employeeColumn.MaxWidth = 200;
            this.employeeColumn.MinWidth = 130;
            this.employeeColumn.Name = "employeeColumn";
            this.employeeColumn.Visible = true;
            this.employeeColumn.VisibleIndex = 4;
            this.employeeColumn.Width = 150;
            // 
            // treeList1
            // 
            this.treeList1.AutoFillColumn = this.taskColumn;
            this.treeList1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.taskColumn,
            this.startDateColumn,
            this.dueDateColumn,
            this.priorityColumn,
            this.employeeColumn,
            this.statusColumn,
            this.completedColumn,
            this.descriptionColumn});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.FixedLineWidth = 1;
            treeListFormatRule1.Column = this.statusColumn;
            treeListFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            formatConditionRuleDataBar1.MaximumType = DevExpress.XtraEditors.FormatConditionValueType.Percent;
            formatConditionRuleDataBar1.MinimumType = DevExpress.XtraEditors.FormatConditionValueType.Percent;
            formatConditionRuleDataBar1.PredefinedName = "Mint";
            treeListFormatRule1.Rule = formatConditionRuleDataBar1;
            this.treeList1.FormatRules.Add(treeListFormatRule1);
            this.treeList1.HierarchyFieldName = "Name";
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsBehavior.EditorShowMode = DevExpress.XtraTreeList.TreeListEditorShowMode.DoubleClick;
            this.treeList1.OptionsFind.AlwaysVisible = true;
            this.treeList1.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Search;
            this.treeList1.OptionsMenu.ShowConditionalFormattingItem = true;
            this.treeList1.OptionsScrollAnnotations.ShowCustomAnnotations = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsScrollAnnotations.ShowErrors = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsSelection.MultiSelect = true;
            this.treeList1.OptionsSelection.SelectNodesOnRightClick = true;
            this.treeList1.OptionsSelection.UseIndicatorForSelection = true;
            this.treeList1.OptionsView.AutoWidth = false;
            this.treeList1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFocus;
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPriorityComboBox,
            this.repositoryItemCompletedComboBox,
            this.repositoryItemDescriptionComboBox});
            this.treeList1.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowOnlyInEditor;
            this.treeList1.Size = new System.Drawing.Size(616, 397);
            this.treeList1.TabIndex = 3;
            this.treeList1.CustomDrawNodeIndicator += new DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventHandler(this.OnCustomDrawRowIndicator);
            this.treeList1.CustomScrollAnnotation += new System.EventHandler<DevExpress.XtraTreeList.TreeListCustomScrollAnnotationsEventArgs>(this.OnCustomScrollAnnotation);
            this.treeList1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // taskColumn
            // 
            this.taskColumn.Caption = "Task";
            this.taskColumn.FieldName = "Name";
            this.taskColumn.MinWidth = 80;
            this.taskColumn.Name = "taskColumn";
            this.taskColumn.Visible = true;
            this.taskColumn.VisibleIndex = 3;
            this.taskColumn.Width = 218;
            // 
            // startDateColumn
            // 
            this.startDateColumn.Caption = "Start Date";
            this.startDateColumn.FieldName = "StartDate";
            this.startDateColumn.MaxWidth = 100;
            this.startDateColumn.MinWidth = 80;
            this.startDateColumn.Name = "startDateColumn";
            this.startDateColumn.Visible = true;
            this.startDateColumn.VisibleIndex = 6;
            this.startDateColumn.Width = 97;
            // 
            // dueDateColumn
            // 
            this.dueDateColumn.Caption = "Due Date";
            this.dueDateColumn.FieldName = "DueDate";
            this.dueDateColumn.MaxWidth = 100;
            this.dueDateColumn.MinWidth = 80;
            this.dueDateColumn.Name = "dueDateColumn";
            this.dueDateColumn.Visible = true;
            this.dueDateColumn.VisibleIndex = 7;
            this.dueDateColumn.Width = 97;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.ColumnEdit = this.repositoryItemDescriptionComboBox;
            this.descriptionColumn.FieldName = "HasDescription";
            this.descriptionColumn.Fixed = DevExpress.XtraTreeList.Columns.FixedStyle.Left;
            this.descriptionColumn.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.descriptionColumn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("descriptionColumn.ImageOptions.SvgImage")));
            this.descriptionColumn.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.descriptionColumn.MaxWidth = 33;
            this.descriptionColumn.MinWidth = 33;
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.OptionsColumn.AllowEdit = false;
            this.descriptionColumn.OptionsColumn.AllowMove = false;
            this.descriptionColumn.OptionsColumn.AllowSize = false;
            this.descriptionColumn.OptionsColumn.AllowSort = false;
            this.descriptionColumn.OptionsFilter.AllowAutoFilter = false;
            this.descriptionColumn.OptionsFilter.AllowFilter = false;
            this.descriptionColumn.ToolTip = "Description";
            this.descriptionColumn.Visible = true;
            this.descriptionColumn.VisibleIndex = 2;
            this.descriptionColumn.Width = 33;
            // 
            // repositoryItemDescriptionComboBox
            // 
            this.repositoryItemDescriptionComboBox.AutoHeight = false;
            this.repositoryItemDescriptionComboBox.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDescriptionComboBox.Name = "repositoryItemDescriptionComboBox";
            this.repositoryItemDescriptionComboBox.SmallImages = this.svgImageCollection;
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.navigationPane);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel.Location = new System.Drawing.Point(616, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(250, 397);
            this.sidePanel.TabIndex = 12;
            this.sidePanel.Text = "sidePanel1";
            // 
            // navigationPane
            // 
            this.navigationPane.Controls.Add(this.navigationPage);
            this.navigationPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane.Location = new System.Drawing.Point(1, 0);
            this.navigationPane.Name = "navigationPane";
            this.navigationPane.PageProperties.AppearanceCaption.Options.UseTextOptions = true;
            this.navigationPane.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.navigationPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage});
            this.navigationPane.RegularSize = new System.Drawing.Size(249, 397);
            this.navigationPane.SelectedPage = this.navigationPage;
            this.navigationPane.Size = new System.Drawing.Size(249, 397);
            this.navigationPane.TabIndex = 13;
            this.navigationPane.Text = "navigationPane1";
            // 
            // navigationPage
            // 
            this.navigationPage.Caption = "Options";
            this.navigationPage.Controls.Add(this.ucScrollAnnotationsOptions);
            this.navigationPage.Name = "navigationPage";
            this.navigationPage.Size = new System.Drawing.Size(249, 364);
            // 
            // ucScrollAnnotationsOptions
            // 
            this.ucScrollAnnotationsOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucScrollAnnotationsOptions.Location = new System.Drawing.Point(0, 0);
            this.ucScrollAnnotationsOptions.Margin = new System.Windows.Forms.Padding(1);
            this.ucScrollAnnotationsOptions.Name = "ucScrollAnnotationsOptions";
            this.ucScrollAnnotationsOptions.Size = new System.Drawing.Size(249, 364);
            this.ucScrollAnnotationsOptions.TabIndex = 0;
            // 
            // HierarchyColumn
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.sidePanel);
            this.Name = "HierarchyColumn";
            this.Size = new System.Drawing.Size(866, 397);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCompletedComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPriorityComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDescriptionComboBox)).EndInit();
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane)).EndInit();
            this.navigationPane.ResumeLayout(false);
            this.navigationPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn taskColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn startDateColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn dueDateColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn priorityColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn employeeColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn statusColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn completedColumn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn descriptionColumn;
        private DevExpress.Utils.SvgImageCollection svgImageCollection;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemCompletedComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemPriorityComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemDescriptionComboBox;
        private XtraEditors.SidePanel sidePanel;
        private XtraBars.Navigation.TabPane navigationPane;
        private XtraBars.Navigation.TabNavigationPage navigationPage;
        private Options.ucScrollAnnotationsOptions ucScrollAnnotationsOptions;
    }
}
