namespace DevExpress.XtraEditors.Demos {
    partial class ModuleMultiSelectLookup {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.reviewsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssistants = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemAssistantsLookUp = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.assistantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeRoot = new DevExpress.XtraLayout.LayoutControlGroup();
            this.reviewDetailsGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciReviewsGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.FirstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AssistantsLookup = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.employeeGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLastNameTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFirstNameTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEmailTextEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.reviewersGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciAssistantsLookup = new DevExpress.XtraLayout.LayoutControlItem();
            this.adornerUIManager1 = new DevExpress.Utils.VisualEffects.AdornerUIManager(this.components);
            this.validationHint1 = new DevExpress.Utils.VisualEffects.ValidationHint();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            this.dataLayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAssistantsLookUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewDetailsGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReviewsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssistantsLookup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastNameTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFirstNameTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmailTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewersGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAssistantsLookup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 12F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.dataLayoutControl2);
            this.tablePanel1.Controls.Add(this.dataLayoutControl1);
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Size = new System.Drawing.Size(750, 280);
            this.tablePanel1.TabIndex = 0;
            // 
            // dataLayoutControl2
            // 
            this.dataLayoutControl2.AllowCustomization = false;
            this.tablePanel1.SetColumn(this.dataLayoutControl2, 2);
            this.dataLayoutControl2.Controls.Add(this.gridControl1);
            this.dataLayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl2.Location = new System.Drawing.Point(384, 3);
            this.dataLayoutControl2.Name = "dataLayoutControl2";
            this.dataLayoutControl2.Root = this.employeeRoot;
            this.tablePanel1.SetRow(this.dataLayoutControl2, 0);
            this.dataLayoutControl2.Size = new System.Drawing.Size(363, 274);
            this.dataLayoutControl2.TabIndex = 3;
            this.dataLayoutControl2.Text = "dataLayoutControl2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.reviewsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemAssistantsLookUp});
            this.gridControl1.Size = new System.Drawing.Size(357, 247);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // reviewsBindingSource
            // 
            this.reviewsBindingSource.DataSource = typeof(DevExpress.XtraEditors.Demos.Modules.Overview.EmployeeReview);
            // 
            // gridView1
            // 
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCreatedOn,
            this.colAssistants});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsMenu.EnableGroupPanelMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCreatedOn, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colCreatedOn
            // 
            this.colCreatedOn.Caption = "CreatedOn";
            this.colCreatedOn.FieldName = "CreatedOn";
            this.colCreatedOn.Name = "colCreatedOn";
            this.colCreatedOn.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCreatedOn.Visible = true;
            this.colCreatedOn.VisibleIndex = 0;
            this.colCreatedOn.Width = 25;
            // 
            // colAssistants
            // 
            this.colAssistants.Caption = "Assistants";
            this.colAssistants.ColumnEdit = this.repositoryItemAssistantsLookUp;
            this.colAssistants.FieldName = "AssistantIDs";
            this.colAssistants.Name = "colAssistants";
            this.colAssistants.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAssistants.OptionsFilter.AllowFilter = false;
            this.colAssistants.Visible = true;
            this.colAssistants.VisibleIndex = 1;
            // 
            // repositoryItemAssistantsLookUp
            // 
            this.repositoryItemAssistantsLookUp.AutoHeight = false;
            this.repositoryItemAssistantsLookUp.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemAssistantsLookUp.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DX$CheckboxSelectorColumn", "", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "Email", 33, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemAssistantsLookUp.DataSource = this.assistantsBindingSource;
            this.repositoryItemAssistantsLookUp.DisplayMember = "FullName";
            this.repositoryItemAssistantsLookUp.EditValueType = DevExpress.XtraEditors.Repository.LookUpEditValueType.ValueList;
            this.repositoryItemAssistantsLookUp.EnableEditValueCollectionEditing = DevExpress.Utils.DefaultBoolean.True;
            this.repositoryItemAssistantsLookUp.Name = "repositoryItemAssistantsLookUp";
            this.repositoryItemAssistantsLookUp.ValueMember = "ID";
            // 
            // assistantsBindingSource
            // 
            this.assistantsBindingSource.DataSource = typeof(DevExpress.XtraEditors.Demos.Modules.Overview.Assistant);
            // 
            // employeeRoot
            // 
            this.employeeRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.employeeRoot.GroupBordersVisible = false;
            this.employeeRoot.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.employeeRoot.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.reviewDetailsGroup});
            this.employeeRoot.Name = "employeeRoot";
            this.employeeRoot.Size = new System.Drawing.Size(363, 274);
            // 
            // reviewDetailsGroup
            // 
            this.reviewDetailsGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciReviewsGrid});
            this.reviewDetailsGroup.Location = new System.Drawing.Point(0, 0);
            this.reviewDetailsGroup.Name = "lciReviewsGrid";
            this.reviewDetailsGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.reviewDetailsGroup.Size = new System.Drawing.Size(363, 274);
            this.reviewDetailsGroup.Text = "Review History";
            // 
            // lciReviewsGrid
            // 
            this.lciReviewsGrid.Control = this.gridControl1;
            this.lciReviewsGrid.Location = new System.Drawing.Point(0, 0);
            this.lciReviewsGrid.Name = "lciReviewsGrid";
            this.lciReviewsGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciReviewsGrid.Size = new System.Drawing.Size(357, 247);
            this.lciReviewsGrid.TextVisible = false;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.tablePanel1.SetColumn(this.dataLayoutControl1, 0);
            this.dataLayoutControl1.Controls.Add(this.FirstNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.LastNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AssistantsLookup);
            this.dataLayoutControl1.DataSource = this.employeeBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(3, 3);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.tablePanel1.SetRow(this.dataLayoutControl1, 0);
            this.tablePanel1.SetRowSpan(this.dataLayoutControl1, 2);
            this.dataLayoutControl1.Size = new System.Drawing.Size(363, 274);
            this.dataLayoutControl1.TabIndex = 2;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // FirstNameTextEdit
            // 
            this.FirstNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "FirstName", true));
            this.FirstNameTextEdit.Location = new System.Drawing.Point(77, 59);
            this.FirstNameTextEdit.Name = "FirstNameTextEdit";
            this.FirstNameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.FirstNameTextEdit.Size = new System.Drawing.Size(272, 20);
            this.FirstNameTextEdit.StyleController = this.dataLayoutControl1;
            this.FirstNameTextEdit.TabIndex = 4;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(DevExpress.XtraEditors.Demos.Modules.Overview.ReviewedEmployee);
            // 
            // LastNameTextEdit
            // 
            this.LastNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "LastName", true));
            this.LastNameTextEdit.Location = new System.Drawing.Point(77, 83);
            this.LastNameTextEdit.Name = "LastNameTextEdit";
            this.LastNameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.LastNameTextEdit.Size = new System.Drawing.Size(272, 20);
            this.LastNameTextEdit.StyleController = this.dataLayoutControl1;
            this.LastNameTextEdit.TabIndex = 5;
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "Email", true));
            this.EmailTextEdit.Location = new System.Drawing.Point(77, 35);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Size = new System.Drawing.Size(272, 20);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 6;
            // 
            // AssistantsLookup
            // 
            this.AssistantsLookup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.reviewsBindingSource, "AssistantIDs", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AssistantsLookup.Location = new System.Drawing.Point(14, 152);
            this.AssistantsLookup.Name = "AssistantsLookup";
            this.AssistantsLookup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AssistantsLookup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DX$CheckboxSelectorColumn", "", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "E-mail")});
            this.AssistantsLookup.Properties.DataSource = this.assistantsBindingSource;
            this.AssistantsLookup.Properties.DisplayMember = "FullName";
            this.AssistantsLookup.Properties.DropDownRows = 10;
            this.AssistantsLookup.Properties.EditValueType = DevExpress.XtraEditors.Repository.LookUpEditValueType.ValueList;
            this.AssistantsLookup.Properties.NullValuePrompt = "Add assistants...";
            this.AssistantsLookup.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.AssistantsLookup.Properties.ShowLines = false;
            this.AssistantsLookup.Properties.ValueMember = "ID";
            this.AssistantsLookup.Size = new System.Drawing.Size(335, 20);
            this.AssistantsLookup.StyleController = this.dataLayoutControl1;
            this.AssistantsLookup.TabIndex = 8;
            this.AssistantsLookup.EditValueChanged += new System.EventHandler(this.OnEditValueChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.employeeGroup,
            this.reviewersGroup});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(363, 274);
            this.Root.TextVisible = false;
            // 
            // employeeGroup
            // 
            this.employeeGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLastNameTextEdit,
            this.lciFirstNameTextEdit,
            this.lciEmailTextEdit});
            this.employeeGroup.Location = new System.Drawing.Point(0, 0);
            this.employeeGroup.Name = "employeeGroup";
            this.employeeGroup.Size = new System.Drawing.Size(363, 117);
            this.employeeGroup.Text = "Employee";
            // 
            // lciLastNameTextEdit
            // 
            this.lciLastNameTextEdit.Control = this.LastNameTextEdit;
            this.lciLastNameTextEdit.Location = new System.Drawing.Point(0, 48);
            this.lciLastNameTextEdit.Name = "lciLastNameTextEdit";
            this.lciLastNameTextEdit.Size = new System.Drawing.Size(339, 24);
            this.lciLastNameTextEdit.Text = "Last Name";
            this.lciLastNameTextEdit.TextSize = new System.Drawing.Size(51, 13);
            // 
            // lciFirstNameTextEdit
            // 
            this.lciFirstNameTextEdit.Control = this.FirstNameTextEdit;
            this.lciFirstNameTextEdit.Location = new System.Drawing.Point(0, 24);
            this.lciFirstNameTextEdit.Name = "lciFirstNameTextEdit";
            this.lciFirstNameTextEdit.Size = new System.Drawing.Size(339, 24);
            this.lciFirstNameTextEdit.Text = "First Name";
            this.lciFirstNameTextEdit.TextSize = new System.Drawing.Size(51, 13);
            // 
            // lciEmailTextEdit
            // 
            this.lciEmailTextEdit.Control = this.EmailTextEdit;
            this.lciEmailTextEdit.Location = new System.Drawing.Point(0, 0);
            this.lciEmailTextEdit.Name = "lciEmailTextEdit";
            this.lciEmailTextEdit.Size = new System.Drawing.Size(339, 24);
            this.lciEmailTextEdit.Text = "E-mail";
            this.lciEmailTextEdit.TextSize = new System.Drawing.Size(51, 13);
            // 
            // reviewersGroup
            // 
            this.reviewersGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciAssistantsLookup});
            this.reviewersGroup.Location = new System.Drawing.Point(0, 117);
            this.reviewersGroup.Name = "reviewersGroup";
            this.reviewersGroup.Size = new System.Drawing.Size(363, 157);
            this.reviewersGroup.Text = "Assistants";
            // 
            // lciAssistantsLookup
            // 
            this.lciAssistantsLookup.Control = this.AssistantsLookup;
            this.lciAssistantsLookup.Location = new System.Drawing.Point(0, 0);
            this.lciAssistantsLookup.Name = "lciAssistantsLookup";
            this.lciAssistantsLookup.Size = new System.Drawing.Size(339, 112);
            this.lciAssistantsLookup.Text = "Assistants";
            this.lciAssistantsLookup.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciAssistantsLookup.TextVisible = false;
            // 
            // adornerUIManager1
            // 
            this.adornerUIManager1.Elements.Add(this.validationHint1);
            this.adornerUIManager1.Owner = this;
            // 
            // validationHint1
            // 
            this.validationHint1.Properties.State = DevExpress.Utils.VisualEffects.ValidationHintState.Invalid;
            this.validationHint1.TargetElement = this.AssistantsLookup;
            // 
            // ModuleMultiSelectLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.tablePanel1);
            this.Name = "ModuleMultiSelectLookup";
            this.Size = new System.Drawing.Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).EndInit();
            this.dataLayoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAssistantsLookUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewDetailsGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReviewsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssistantsLookup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastNameTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFirstNameTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmailTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewersGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAssistantsLookup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DevExpress.XtraEditors.TextEdit FirstNameTextEdit;
        private DevExpress.XtraEditors.TextEdit LastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private DevExpress.XtraEditors.LookUpEdit AssistantsLookup;
        private System.Windows.Forms.BindingSource assistantsBindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup employeeRoot;
        private DevExpress.XtraLayout.LayoutControlGroup employeeGroup;
        private DevExpress.XtraLayout.LayoutControlItem lciLastNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem lciFirstNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem lciEmailTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup reviewersGroup;
        private DevExpress.XtraLayout.LayoutControlItem lciAssistantsLookup;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem lciReviewsGrid;
        private System.Windows.Forms.BindingSource reviewsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colAssistants;
        private DevExpress.XtraLayout.LayoutControlGroup reviewDetailsGroup;
        private Utils.VisualEffects.AdornerUIManager adornerUIManager1;
        private Utils.VisualEffects.ValidationHint validationHint1;
        private Repository.RepositoryItemLookUpEdit repositoryItemAssistantsLookUp;
    }
}
